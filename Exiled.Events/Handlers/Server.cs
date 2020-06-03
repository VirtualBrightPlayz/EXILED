// -----------------------------------------------------------------------
// <copyright file="Server.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.Handlers
{
    using System;
    using System.IO;
    using Exiled.API.Extensions;
    using Exiled.API.Features;
    using Exiled.Events.Handlers.EventArgs;
    using static Exiled.Events.Events;

    /// <summary>
    /// Server related events.
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Invoked before waiting for players.
        /// </summary>
        public static event CustomEventHandler WaitingForPlayers;

        /// <summary>
        /// Invoked after the start of a new round.
        /// </summary>
        public static event CustomEventHandler RoundStarted;

        /// <summary>
        /// Invoked before ending a round
        /// </summary>
        public static event CustomEventHandler<EndingRoundEventArgs> EndingRound;

        /// <summary>
        /// Invoked after the end of a round.
        /// </summary>
        public static event CustomEventHandler<RoundEndedEventArgs> RoundEnded;

        /// <summary>
        /// Invoked before the restart of a round.
        /// </summary>
        public static event CustomEventHandler RestartingRound;

        /// <summary>
        /// Invoked when a player reports a cheater.
        /// </summary>
        public static event CustomEventHandler<ReportingCheaterEventArgs> ReportingCheater;

        /// <summary>
        /// Invoked before respawning a wave of Chaos Insurgency or NTF.
        /// </summary>
        public static event CustomEventHandler<RespawningTeamEventArgs> RespawningTeam;

        /// <summary>
        /// Invoked when sending a command through the in-game console.
        /// </summary>
        public static event CustomEventHandler<SendingConsoleCommandEventArgs> SendingConsoleCommand;

        /// <summary>
        /// Invoked when sending a command through the Remote Admin console.
        /// </summary>
        public static event CustomEventHandler<SendingRemoteAdminCommandEventArgs> SendingRemoteAdminCommand;

        /// <summary>
        /// Called before waiting for players.
        /// </summary>
        public static void OnWaitingForPlayers() => WaitingForPlayers.InvokeSafely();

        /// <summary>
        /// Called after the start of a new round.
        /// </summary>
        public static void OnRoundStarted() => RoundStarted.InvokeSafely();

        /// <summary>
        /// Called before ending a round.
        /// </summary>
        /// <param name="ev">The <see cref="EndingRoundEventArgs"/> instance.</param>
        public static void OnEndingRound(EndingRoundEventArgs ev) => EndingRound.InvokeSafely(ev);

        /// <summary>
        /// Called after the end of a round.
        /// </summary>
        /// <param name="ev">The <see cref="RoundEndedEventArgs"/> instance.</param>
        public static void OnRoundEnded(RoundEndedEventArgs ev) => RoundEnded.InvokeSafely(ev);

        /// <summary>
        /// Called before restarting a round.
        /// </summary>
        public static void OnRestartingRound() => RestartingRound.InvokeSafely();

        /// <summary>
        /// Called when a player reports a cheater.
        /// </summary>
        /// <param name="ev">The <see cref="ReportingCheaterEventArgs"/> instance.</param>
        public static void OnReportingCheater(ReportingCheaterEventArgs ev) => ReportingCheater.InvokeSafely(ev);

        /// <summary>
        /// Called before respawning a wave of Chaso Insurgency or NTF.
        /// </summary>
        /// <param name="ev">The <see cref="RespawningTeamEventArgs"/> instance.</param>
        public static void OnRespawningTeam(RespawningTeamEventArgs ev) => RespawningTeam.InvokeSafely(ev);

        /// <summary>
        /// Called when sending a command through in-game console.
        /// </summary>
        /// <param name="ev">The <see cref="SendingConsoleCommandEventArgs"/> instance.</param>
        public static void OnSendingConsoleCommand(SendingConsoleCommandEventArgs ev) => SendingConsoleCommand.InvokeSafely(ev);

        /// <summary>
        /// Called when sending a command through the Remote Admin console.
        /// </summary>
        /// <param name="ev">The <see cref="SendingRemoteAdminCommandEventArgs"/> instance.</param>
        public static void OnSendingRemoteAdminCommand(SendingRemoteAdminCommandEventArgs ev)
        {
            SendingRemoteAdminCommand.InvokeSafely(ev);

            lock (ServerLogs.LockObject)
            {
                File.AppendAllText(Paths.Log, $"[{DateTime.Now}] {ev.Sender.Nickname} ({ev.Sender.UserId}) ran command: {ev.Name}. Command Permitted: {(ev.IsAllowed ? "[YES]" : "[NO]")}" + Environment.NewLine);
            }
        }
    }
}
