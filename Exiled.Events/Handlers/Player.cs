// -----------------------------------------------------------------------
// <copyright file="Player.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.Handlers
{
    using Exiled.API.Extensions;
    using Exiled.Events.Handlers.EventArgs;
    using static Exiled.Events.Events;

    /// <summary>
    /// Player related events.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Invoked before authenticating a player.
        /// </summary>
        public static event CustomEventHandler<PreAuthenticatingEventArgs> PreAuthenticating;

        /// <summary>
        /// Invoked before kicking a player.
        /// </summary>
        public static event CustomEventHandler<KickingEventArgs> Kicking;

        /// <summary>
        /// Invoked after a player has been kicked.
        /// </summary>
        public static event CustomEventHandler<KickedEventArgs> Kicked;

        /// <summary>
        /// Invoked before banning a player.
        /// </summary>
        public static event CustomEventHandler<BanningEventArgs> Banning;

        /// <summary>
        /// Invoked after a player has been banned.
        /// </summary>
        public static event CustomEventHandler<BannedEventArgs> Banned;

        /// <summary>
        /// Invoked after a player used a medical item.
        /// </summary>
        public static event CustomEventHandler<UsedMedicalItemEventArgs> MedicalItemUsed;

        /// <summary>
        /// Invoked after a player has stopped the use of a medical item.
        /// </summary>
        public static event CustomEventHandler<StoppingMedicalItemEventArgs> StoppingMedicalItem;

        /// <summary>
        /// Invoked after a player interacted with something.
        /// </summary>
        public static event CustomEventHandler<InteractedEventArgs> Interacted;

        /// <summary>
        /// Invoked before spawning a player's ragdoll.
        /// </summary>
        public static event CustomEventHandler<SpawningRagdollEventArgs> SpawningRagdoll;

        /// <summary>
        /// Invoked before creating an SCP-106 portal.
        /// </summary>
        public static event CustomEventHandler<CreatingScp106PortalEventArgs> CreatingScp106Portal;

        /// <summary>
        /// Invoked before gaining experience with SCP-079
        /// </summary>
        public static event CustomEventHandler<GainingScp079ExperienceEventArgs> GainingScp079Experience;

        /// <summary>
        /// Invoked before gaining levels with SCP-079
        /// </summary>
        public static event CustomEventHandler<GainingScp079LevelEventArgs> GainingScp079Level;

        /// <summary>
        /// Invoked before activating the warhead panel.
        /// </summary>
        public static event CustomEventHandler<ActivatingWarheadPanelEventArgs> ActivatingWarheadPanel;

        /// <summary>
        /// Invoked before using a medical item.
        /// </summary>
        public static event CustomEventHandler<UsingMedicalItemEventArgs> UsingMedicalItem;

        /// <summary>
        /// Invoked before enraging with SCP-096.
        /// </summary>
        public static event CustomEventHandler<EnragingScp096EventArgs> EnragingScp096;

        /// <summary>
        /// Invoked before calming down with SCP-096.
        /// </summary>
        public static event CustomEventHandler<CalmingDownScp096EventArgs> CalmingDownScp096;

        /// <summary>
        /// Invoked after a player has joined the server.
        /// </summary>
        public static event CustomEventHandler<JoinedEventArgs> Joined;

        /// <summary>
        /// Invoked after a player has left the server.
        /// </summary>
        public static event CustomEventHandler<LeftEventArgs> Left;

        /// <summary>
        /// Invoked before hurting a player.
        /// </summary>
        public static event CustomEventHandler<HurtingEventArgs> Hurting;

        /// <summary>
        /// Invoked after a player died.
        /// </summary>
        public static event CustomEventHandler<DiedEventArgs> Died;

        /// <summary>
        /// Invoked before changing a player's role.
        /// </summary>
        public static event CustomEventHandler<ChangingRoleEventArgs> ChangingRole;

        /// <summary>
        /// Invoked before throwing a grenade.
        /// </summary>
        public static event CustomEventHandler<ThrowingGrenadeEventArgs> ThrowingGrenade;

        /// <summary>
        /// Invoked before dropping an item.
        /// </summary>
        public static event CustomEventHandler<DroppingItemEventArgs> DroppingItem;

        /// <summary>
        /// Invoked after an item has been dropped.
        /// </summary>
        public static event CustomEventHandler<ItemDroppedEventArgs> ItemDropped;

        /// <summary>
        /// Invoked before picking up an item
        /// </summary>
        public static event CustomEventHandler<PickingUpItemEventArgs> PickingUpItem;

        /// <summary>
        /// Invoked before handcuffing a player.
        /// </summary>
        public static event CustomEventHandler<HandcuffingEventArgs> Handcuffing;

        /// <summary>
        /// Invoked before removing handcuffs to a player.
        /// </summary>
        public static event CustomEventHandler<RemovingHandcuffsEventArgs> RemovingHandcuffs;

        /// <summary>
        /// Invoked before triggering a tesla with SCP-079.
        /// </summary>
        public static event CustomEventHandler<TriggeringScp079TeslaEventArgs> TriggeringScp079Tesla;

        /// <summary>
        /// Invoked before escaping from the facility.
        /// </summary>
        public static event CustomEventHandler<EscapingEventArgs> Escaping;

        /// <summary>
        /// Invoked before speaking to the intercom.
        /// </summary>
        public static event CustomEventHandler<IntercomSpeakingEventArgs> IntercomSpeaking;

        /// <summary>
        /// Invoked after a player's shot.
        /// </summary>
        public static event CustomEventHandler<ShotEventArgs> Shot;

        /// <summary>
        /// Invoked before shooting.
        /// </summary>
        public static event CustomEventHandler<ShootingEventArgs> Shooting;

        /// <summary>
        /// Invoked before teleporting with SCP-106.
        /// </summary>
        public static event CustomEventHandler<TeleportingScp106EventArgs> TeleportingScp106;

        /// <summary>
        /// Invoked before entering the pocket dimension.
        /// </summary>
        public static event CustomEventHandler<EnteringPocketDimensionEventArgs> EnteringPocketDimension;

        /// <summary>
        /// Invoked before escaping the pocket dimension.
        /// </summary>
        public static event CustomEventHandler<EscapingPocketDimensionEventArgs> EscapingPocketDimension;

        /// <summary>
        /// Invoked before reloading a weapon.
        /// </summary>
        public static event CustomEventHandler<ReloadingWeaponEventArgs> ReloadingWeapon;

        /// <summary>
        /// Invoked before spawning a player.
        /// </summary>
        public static event CustomEventHandler<SpawningEventArgs> Spawning;

        /// <summary>
        /// Invoked before containing SCP-106.
        /// </summary>
        public static event CustomEventHandler<ContainingScp106EventArgs> ContainingScp106;

        /// <summary>
        /// Invoked before activating the SCP-914 machine.
        /// </summary>
        public static event CustomEventHandler<ActivatingScp914EventArgs> ActivatingScp914;

        /// <summary>
        /// Invoked before changing the SCP-914 machine knob setting.
        /// </summary>
        public static event CustomEventHandler<ChangingScp914KnobSettingEventArgs> ChangingScp914KnobSetting;

        /// <summary>
        /// Invoked before entering the femur breaker
        /// </summary>
        public static event CustomEventHandler<EnteringFemurBreakerEventArgs> EnteringFemurBreaker;

        /// <summary>
        /// Invoked before syncing player's data.
        /// </summary>
        public static event CustomEventHandler<SyncingDataEventArgs> SyncingData;

        /// <summary>
        /// Invoked before changing a player changes the item in his hand.
        /// </summary>
        public static event CustomEventHandler<ChangingItemEventArgs> ChangingItem;

        /// <summary>
        /// Invoked before changing a player's group.
        /// </summary>
        public static event CustomEventHandler<ChangingGroupEventArgs> ChangingGroup;

        /// <summary>
        /// Invoked before pre-authenticating a player.
        /// </summary>
        /// <param name="ev">The <see cref="PreAuthenticatingEventArgs"/> instance.</param>
        public static void OnPreAuthenticating(PreAuthenticatingEventArgs ev) => PreAuthenticating.InvokeSafely(ev);

        /// <summary>
        /// Invoked before kicking a player.
        /// </summary>
        /// <param name="ev">The <see cref="KickingEventArgs"/> instance.</param>
        public static void OnKicking(KickingEventArgs ev) => Kicking.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player has been kicked.
        /// </summary>
        /// <param name="ev">The <see cref="KickedEventArgs"/> instance.</param>
        public static void OnKicked(KickedEventArgs ev) => Kicked.InvokeSafely(ev);

        /// <summary>
        /// Invoked before banning a player.
        /// </summary>
        /// <param name="ev">The <see cref="BanningEventArgs"/> instance.</param>
        public static void OnBanning(BanningEventArgs ev) => Banning.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player has been banned.
        /// </summary>
        /// <param name="ev">The <see cref="BannedEventArgs"/> instance.</param>
        public static void OnBanned(BannedEventArgs ev) => Banned.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player used a medical item.
        /// </summary>
        /// <param name="ev">The <see cref="MedicalItemUsed"/> instance.</param>
        public static void OnMedicalItemUsed(UsedMedicalItemEventArgs ev) => MedicalItemUsed.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player has stopped the use of a medical item.
        /// </summary>
        /// <param name="ev">The <see cref="StoppingMedicalItemEventArgs"/> instance.</param>
        public static void OnStoppingMedicalItem(StoppingMedicalItemEventArgs ev) => StoppingMedicalItem.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player interacted with something.
        /// </summary>
        /// <param name="ev">The <see cref="InteractedEventArgs"/> instance.</param>
        public static void OnInteracted(InteractedEventArgs ev) => Interacted.InvokeSafely(ev);

        /// <summary>
        /// Invoked before spawning a player's ragdoll.
        /// </summary>
        /// <param name="ev">The <see cref="SpawningRagdollEventArgs"/> instance.</param>
        public static void OnSpawningRagdoll(SpawningRagdollEventArgs ev) => SpawningRagdoll.InvokeSafely(ev);

        /// <summary>
        /// Invoked before creating an SCP-106 portal.
        /// </summary>
        /// <param name="ev">The <see cref="CreatingScp106PortalEventArgs"/> instance.</param>
        public static void OnCreatingScp106Portal(CreatingScp106PortalEventArgs ev) => CreatingScp106Portal.InvokeSafely(ev);

        /// <summary>
        /// Invoked before gaining experience with SCP-079.
        /// </summary>
        /// <param name="ev">The <see cref="GainingScp079ExperienceEventArgs"/> instance.</param>
        public static void OnGainingScp079Experience(GainingScp079ExperienceEventArgs ev) => GainingScp079Experience.InvokeSafely(ev);

        /// <summary>
        /// Invoked before gaining levels with SCP-079.
        /// </summary>
        /// <param name="ev">The <see cref="GainingScp079LevelEventArgs"/> instance.</param>
        public static void OnGainingScp079Level(GainingScp079LevelEventArgs ev) => GainingScp079Level.InvokeSafely(ev);

        /// <summary>
        /// Invoked before activating the warhead panel.
        /// </summary>
        /// <param name="ev">The <see cref="ActivatingWarheadPanelEventArgs"/> instance.</param>
        public static void OnActivatingWarheadPanel(ActivatingWarheadPanelEventArgs ev) => ActivatingWarheadPanel.InvokeSafely(ev);

        /// <summary>
        /// Invoked before using a medical item.
        /// </summary>
        /// <param name="ev">The <see cref="UsingMedicalItemEventArgs"/> instance.</param>
        public static void OnUsingMedicalItem(UsingMedicalItemEventArgs ev) => UsingMedicalItem.InvokeSafely(ev);

        /// <summary>
        /// Invoked before enraging with SCP-096.
        /// </summary>
        /// <param name="ev">The <see cref="EnragingScp096EventArgs"/> instance.</param>
        public static void OnEnragingScp096(EnragingScp096EventArgs ev) => EnragingScp096.InvokeSafely(ev);

        /// <summary>
        /// Invoked before calming down with SCP-096.
        /// </summary>
        /// <param name="ev">The <see cref="CalmingDownScp096EventArgs"/> instance.</param>
        public static void OnCalmingDownScp096(CalmingDownScp096EventArgs ev) => CalmingDownScp096.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player has joined the server.
        /// </summary>
        /// <param name="ev">The <see cref="JoinedEventArgs"/> instance.</param>
        public static void OnJoined(JoinedEventArgs ev) => Joined.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player has left the server.
        /// </summary>
        /// <param name="ev">The <see cref="LeftEventArgs"/> instance.</param>
        public static void OnLeft(LeftEventArgs ev) => Left.InvokeSafely(ev);

        /// <summary>
        /// Invoked before hurting a player.
        /// </summary>
        /// <param name="ev">The <see cref="HurtingEventArgs"/> instance.</param>
        public static void OnHurting(HurtingEventArgs ev) => Hurting.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player died.
        /// </summary>
        /// <param name="ev">The <see cref="DiedEventArgs"/> instance.</param>
        public static void OnDied(DiedEventArgs ev) => Died.InvokeSafely(ev);

        /// <summary>
        /// Invoked before changing a player's role.
        /// </summary>
        /// <param name="ev">The <see cref="ChangingRoleEventArgs"/> instance.</param>
        public static void OnChangingRole(ChangingRoleEventArgs ev) => ChangingRole.InvokeSafely(ev);

        /// <summary>
        /// Invoked before throwing a grenade.
        /// </summary>
        /// <param name="ev">The <see cref="ThrowingGrenadeEventArgs"/> instance.</param>
        public static void OnThrowingGrenade(ThrowingGrenadeEventArgs ev) => ThrowingGrenade.InvokeSafely(ev);

        /// <summary>
        /// Invoked before dropping an item.
        /// </summary>
        /// <param name="ev">The <see cref="DroppingItemEventArgs"/> instance.</param>
        public static void OnDroppingItem(DroppingItemEventArgs ev) => DroppingItem.InvokeSafely(ev);

        /// <summary>
        /// Invoked after an item has been dropped.
        /// </summary>
        /// <param name="ev">The <see cref="ItemDroppedEventArgs"/> instance.</param>
        public static void OnItemDropped(ItemDroppedEventArgs ev) => ItemDropped.InvokeSafely(ev);

        /// <summary>
        /// Invoked before picking up an item.
        /// </summary>
        /// <param name="ev">The <see cref="PickingUpItemEventArgs"/> instance.</param>
        public static void OnPickingUpItem(PickingUpItemEventArgs ev) => PickingUpItem.InvokeSafely(ev);

        /// <summary>
        /// Invoked before handcuffing a player.
        /// </summary>
        /// <param name="ev">The <see cref="HandcuffingEventArgs"/> instance.</param>
        public static void OnHandcuffing(HandcuffingEventArgs ev) => Handcuffing.InvokeSafely(ev);

        /// <summary>
        /// Invoked before removing handcuffs to a player.
        /// </summary>
        /// <param name="ev">The <see cref="RemovingHandcuffsEventArgs"/> instance.</param>
        public static void OnRemovingHandcuffs(RemovingHandcuffsEventArgs ev) => RemovingHandcuffs.InvokeSafely(ev);

        /// <summary>
        /// Invoked before triggering a tesla with SCP-079.
        /// </summary>
        /// <param name="ev">The <see cref="TriggeringScp079TeslaEventArgs"/> instance.</param>
        public static void OnTriggeringScp079Tesla(TriggeringScp079TeslaEventArgs ev) => TriggeringScp079Tesla.InvokeSafely(ev);

        /// <summary>
        /// Invoked before escaping from the facility.
        /// </summary>
        /// <param name="ev">The <see cref="EscapingEventArgs"/> instance.</param>
        public static void OnEscaping(EscapingEventArgs ev) => Escaping.InvokeSafely(ev);

        /// <summary>
        /// Invoked before speaking to the intercom.
        /// </summary>
        /// <param name="ev">The <see cref="IntercomSpeakingEventArgs"/> instance.</param>
        public static void OnIntercomSpeaking(IntercomSpeakingEventArgs ev) => IntercomSpeaking.InvokeSafely(ev);

        /// <summary>
        /// Invoked after a player's shot.
        /// </summary>
        /// <param name="ev">The <see cref="ShotEventArgs"/> instance.</param>
        public static void OnShot(ShotEventArgs ev) => Shot.InvokeSafely(ev);

        /// <summary>
        /// Invoked before shooting.
        /// </summary>
        /// <param name="ev">The <see cref="ShootingEventArgs"/> instance.</param>
        public static void OnShooting(ShootingEventArgs ev) => Shooting.InvokeSafely(ev);

        /// <summary>
        /// Invoked before teleporting with SCP-106.
        /// </summary>
        /// <param name="ev">The <see cref="TeleportingScp106EventArgs"/> instance.</param>
        public static void OnTeleportingScp106(TeleportingScp106EventArgs ev) => TeleportingScp106.InvokeSafely(ev);

        /// <summary>
        /// Invoked before entering the pocket dimension.
        /// </summary>
        /// <param name="ev">The <see cref="EnteringPocketDimensionEventArgs"/> instance.</param>
        public static void OnEnteringPocketDimension(EnteringPocketDimensionEventArgs ev) => EnteringPocketDimension.InvokeSafely(ev);

        /// <summary>
        /// Invoked before escaping the pocket dimension.
        /// </summary>
        /// <param name="ev">The <see cref="EscapingPocketDimensionEventArgs"/> instance.</param>
        public static void OnEscapingPocketDimension(EscapingPocketDimensionEventArgs ev) => EscapingPocketDimension.InvokeSafely(ev);

        /// <summary>
        /// Invoked before reloading a weapon.
        /// </summary>
        /// <param name="ev">The <see cref="ReloadingWeaponEventArgs"/> instance.</param>
        public static void OnReloadingWeapon(ReloadingWeaponEventArgs ev) => ReloadingWeapon.InvokeSafely(ev);

        /// <summary>
        /// Invoked before spawning a player.
        /// </summary>
        /// <param name="ev">The <see cref="SpawningEventArgs"/> instance.</param>
        public static void OnSpawning(SpawningEventArgs ev) => Spawning.InvokeSafely(ev);

        /// <summary>
        /// Invoked before containing SCP-106.
        /// </summary>
        /// <param name="ev">The <see cref="ContainingScp106EventArgs"/> instance.</param>
        public static void OnContainingScp106(ContainingScp106EventArgs ev) => ContainingScp106.InvokeSafely(ev);

        /// <summary>
        /// Invoked before activating the SCP-914 machine.
        /// </summary>
        /// <param name="ev">The <see cref="ActivatingScp914EventArgs"/> instance.</param>
        public static void OnActivatingScp914(ActivatingScp914EventArgs ev) => ActivatingScp914.InvokeSafely(ev);

        /// <summary>
        /// Invoked before changing the SCP-914 machine knob setting.
        /// </summary>
        /// <param name="ev">The <see cref="ChangingScp914KnobSettingEventArgs"/> instance.</param>
        public static void OnChangingScp914KnobSetting(ChangingScp914KnobSettingEventArgs ev) => ChangingScp914KnobSetting.InvokeSafely(ev);

        /// <summary>
        /// Invoked before entering the femur breaker.
        /// </summary>
        /// <param name="ev">The <see cref="EnteringFemurBreakerEventArgs"/> instance.</param>
        public static void OnEnteringFemurBreaker(EnteringFemurBreakerEventArgs ev) => EnteringFemurBreaker.InvokeSafely(ev);

        /// <summary>
        /// Invoked before syncing player's data.
        /// </summary>
        /// <param name="ev">The <see cref="SyncingDataEventArgs"/> instance.</param>
        public static void OnSyncingData(SyncingDataEventArgs ev) => SyncingData.InvokeSafely(ev);

        /// <summary>
        /// Invoked before changing a player changes the item in his hand.
        /// </summary>
        /// <param name="ev">The <see cref="ChangingItemEventArgs"/> instance.</param>
        public static void OnChangingItem(ChangingItemEventArgs ev) => ChangingItem.InvokeSafely(ev);

        /// <summary>
        /// Called before changing a player's group.
        /// </summary>
        /// <param name="ev">The <see cref="ChangingGroupEventArgs"/> instance.</param>
        public static void OnChangingGroup(ChangingGroupEventArgs ev) => ChangingGroup.InvokeSafely(ev);
    }
}