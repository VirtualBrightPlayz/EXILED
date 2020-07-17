// -----------------------------------------------------------------------
// <copyright file="IPlugin.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using CommandSystem;

    using Exiled.API.Enums;

    /// <summary>
    /// Defines the contract for basic plugin features.
    /// </summary>
    /// <typeparam name="TConfig">The config type.</typeparam>
    public interface IPlugin<out TConfig>
        where TConfig : IConfig
    {
        /// <summary>
        /// Gets the plugin assembly.
        /// </summary>
        Assembly Assembly { get; }

        /// <summary>
        /// Gets the plugin name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the plugin prefix.
        /// </summary>
        string Prefix { get; }

        /// <summary>
        /// Gets the plugin author.
        /// </summary>
        string Author { get; }

        /// <summary>
        /// Gets the plugin commands.
        /// </summary>
        Dictionary<Type, Dictionary<Type, ICommand>> Commands { get; }

        /// <summary>
        /// Gets the auto subscribed plugin events.
        /// </summary>
        Dictionary<Type, List<MethodInfo>> AutoSubscribers { get; }

        /// <summary>
        /// Gets the plugin priority.
        /// Higher values mean higher priority and vice versa.
        /// </summary>
        PluginPriority Priority { get; }

        /// <summary>
        /// Gets the plugin version.
        /// </summary>
        Version Version { get; }

        /// <summary>
        /// Gets the required version of Exiled to run the plugin without bugs or incompatibilities.
        /// </summary>
        Version RequiredExiledVersion { get; }

        /// <summary>
        /// Gets the plugin config.
        /// </summary>
        TConfig Config { get; }

        /// <summary>
        /// Fired after enabling the plugin.
        /// </summary>
        void OnEnabled();

        /// <summary>
        /// Fired after disabling the plugin.
        /// </summary>
        void OnDisabled();

        /// <summary>
        /// Fired after reloading the plugin.
        /// </summary>
        void OnReloaded();

        /// <summary>
        /// Fired before registering commands.
        /// </summary>
        void OnRegisteringCommands();

        /// <summary>
        /// Fired before unregistering configs.
        /// </summary>
        void OnUnregisteringCommands();
    }
}
