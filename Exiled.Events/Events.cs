// -----------------------------------------------------------------------
// <copyright file="Events.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using Exiled.Loader;

    using HarmonyLib;

    /// <summary>
    /// Patch and unpatch events into the game.
    /// </summary>
    public sealed class Events : Plugin<Config>
    {
        private static readonly Lazy<Events> LazyInstance = new Lazy<Events>(() => new Events());
        private readonly Handlers.Round round = new Handlers.Round();

        /// <summary>
        /// The below variable is used to increment the name of the harmony instance, otherwise harmony will not work upon a plugin reload.
        /// </summary>
        private int patchesCounter;

        private Events()
        {
        }

        /// <summary>
        /// The custom <see cref="EventHandler"/> delegate.
        /// </summary>
        /// <typeparam name="TEventArgs">The <see cref="EventHandler{TEventArgs}"/> type.</typeparam>
        /// <param name="ev">The <see cref="EventHandler{TEventArgs}"/> instance.</param>
        public delegate void CustomEventHandler<TEventArgs>(TEventArgs ev)
            where TEventArgs : System.EventArgs;

        /// <summary>
        /// The custom <see cref="EventHandler"/> delegate, with empty parameters.
        /// </summary>
        public delegate void CustomEventHandler();

        /// <summary>
        /// Gets the plugin instance.
        /// </summary>
        public static Events Instance => LazyInstance.Value;

        /// <summary>
        /// Gets a list of types and methods for which EXILED patches should not be run.
        /// </summary>
        public static List<Tuple<Type, string>> DisabledPatches { get; } = new List<Tuple<Type, string>>();

        /// <summary>
        /// Gets a value indicating whether the <see cref="AutoEvents"/> dictionary has been filled or not.
        /// </summary>
        public static bool HasAutoEventsBeenFilled { get; private set; } = false;

        /// <inheritdoc/>
        public override PluginPriority Priority { get; } = PluginPriority.Last;

        /// <summary>
        /// Gets the <see cref="HarmonyLib.Harmony"/> instance.
        /// </summary>
        public Harmony Harmony { get; private set; }

        /// <summary>
        /// Gets a dictionary of all the events sorted by type. Used for auto event subscriptions.
        /// </summary>
        public Dictionary<Type, EventInfo> AutoEvents { get; private set; } = new Dictionary<Type, EventInfo>();

        /// <summary>
        /// Gets a dictionary of all the events automatically registered.
        /// </summary>
        public Dictionary<MethodInfo, EventInfo> AutoRegisteredEvents { get; private set; } = new Dictionary<MethodInfo, EventInfo>();

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            base.OnEnabled();

            Patch();
            RegisterAllEvents();

            Handlers.Server.WaitingForPlayers += round.OnWaitingForPlayers;
            Handlers.Server.RoundStarted += round.OnRoundStarted;

            Handlers.Player.ChangingRole += round.OnChangingRole;

            ServerConsole.ReloadServerName();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            base.OnDisabled();

            Unpatch();
            UnregisterAllEvents();

            Handlers.Server.WaitingForPlayers -= round.OnWaitingForPlayers;
            Handlers.Server.RoundStarted -= round.OnRoundStarted;

            Handlers.Player.ChangingRole -= round.OnChangingRole;
        }

        /// <summary>
        /// Registers every plugin's auto events.
        /// </summary>
        public void RegisterAllEvents()
        {
            if (!HasAutoEventsBeenFilled)
            {
                foreach (Type type in Assembly.GetTypes())
                {
                    foreach (EventInfo eventinfo in type.GetEvents())
                    {
                        if (eventinfo.EventHandlerType != typeof(CustomEventHandler))
                            continue;
                        if (eventinfo.EventHandlerType.GenericTypeArguments.Length != 0 && !AutoEvents.ContainsKey(eventinfo.EventHandlerType.GenericTypeArguments[0]))
                            AutoEvents.Add(eventinfo.EventHandlerType.GenericTypeArguments[0], eventinfo);
                    }
                }
            }

            foreach (IPlugin<IConfig> plugin in Loader.Plugins)
            {
                if (plugin == this)
                    continue;
                foreach (KeyValuePair<Type, EventInfo> ev in AutoEvents)
                {
                    if (!plugin.AutoSubscribers.ContainsKey(ev.Key))
                        continue;
                    foreach (MethodInfo method in plugin.AutoSubscribers[ev.Key])
                    {
                        try
                        {
                            ev.Value.GetAddMethod().Invoke(null, new object[] { method });
                            AutoRegisteredEvents.Add(method, ev.Value);
                        }
                        catch (Exception e)
                        {
                            Log.Warn($"Unable to register event {method.Name} automatically. {e}");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Unregisters every plugin's auto events.
        /// </summary>
        public void UnregisterAllEvents()
        {
            foreach (KeyValuePair<MethodInfo, EventInfo> autosubbed in AutoRegisteredEvents)
            {
                autosubbed.Value.GetRemoveMethod().Invoke(null, new object[] { autosubbed.Key });
            }

            AutoRegisteredEvents.Clear();
        }

        /// <summary>
        /// Patches all events.
        /// </summary>
        public void Patch()
        {
            try
            {
                Harmony = new Harmony($"exiled.events.{++patchesCounter}");
#if DEBUG
                var lastDebugStatus = Harmony.DEBUG;
                Harmony.DEBUG = true;
#endif
                Harmony.PatchAll();
#if DEBUG
                Harmony.DEBUG = lastDebugStatus;
#endif
                Log.Debug("Events patched successfully!", Loader.ShouldDebugBeShown);
            }
            catch (Exception exception)
            {
                Log.Error($"Patching failed! {exception}");
            }
        }

        /// <summary>
        /// Checks the <see cref="DisabledPatches"/> list and un-patches any methods that have been defined there. Once un-patching has been done, they can be patched by plugins, but will not be re-patchable by Exiled until a server reboot.
        /// </summary>
        public void ReloadDisabledPatches()
        {
            foreach ((Type type, string methodName) in DisabledPatches)
            {
                Harmony.Unpatch(type.GetMethod(methodName), HarmonyPatchType.All, Harmony.Id);
            }
        }

        /// <summary>
        /// Unpatches all events.
        /// </summary>
        public void Unpatch()
        {
            Log.Debug("Unpatching events...", Loader.ShouldDebugBeShown);

            Harmony.UnpatchAll();

            Log.Debug("All events have been unpatched complete. Goodbye!", Loader.ShouldDebugBeShown);
        }
    }
}
