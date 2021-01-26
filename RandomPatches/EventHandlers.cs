using Exiled.Events.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPatches
{
    public class EventHandlers
    {
        internal void OnActivateWorkstation(ActivatingWorkstationEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Workstation.canActivateWorkstationGlobal || !MainClass.singleton.Config.Events.Workstation.canActivateWorkstation[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnActivateWarheadPanel(ActivatingWarheadPanelEventArgs ev)
        {
        }

        internal void OnClosingGenerator(ClosingGeneratorEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Generator.canCloseGeneratorGlobal || !MainClass.singleton.Config.Events.Generator.canCloseGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnDeactivateWorkstation(DeactivatingWorkstationEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Workstation.canDeactivateWorkstationGlobal || !MainClass.singleton.Config.Events.Workstation.canDeactivateWorkstation[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnDropItem(DroppingItemEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Item.canDropAnyItemGlobal || !MainClass.singleton.Config.Events.Item.canDropAnyItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnOpenGenerator(OpeningGeneratorEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Generator.canOpenGeneratorGlobal || !MainClass.singleton.Config.Events.Generator.canOpenGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnPickupItem(PickingUpItemEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Item.canPickupAnyItemGlobal || !MainClass.singleton.Config.Events.Item.canPickupAnyItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnAddTablet(InsertingGeneratorTabletEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Generator.canInsertTabletGlobal || !MainClass.singleton.Config.Events.Generator.canInsertTablet[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnFailEscapePD(FailingEscapePocketDimensionEventArgs ev)
        {
            if (MainClass.singleton.Config.Events.PocketDimension.alwaysExitPocketDimensionGlobal || MainClass.singleton.Config.Events.PocketDimension.alwaysExitPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnShotWeapon(ShootingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Weapon.canShotWeaponGlobal || !MainClass.singleton.Config.Events.Weapon.canShotWeapon[ev.Shooter.Role])
                ev.IsAllowed = false;
        }

        internal void OnActivateTesla(TriggeringTeslaEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Tesla.canActivateTeslaGlobal || !MainClass.singleton.Config.Events.Tesla.canActivateTesla[ev.Player.Role])
                ev.IsTriggerable = false;
        }

        internal void OnUseMedicalItem(UsingMedicalItemEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.MedicalItem.canUseMedicalItemGlobal || !MainClass.singleton.Config.Events.MedicalItem.canUseMedicalItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnSpawnRagdoll(SpawningRagdollEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Ragdoll.canCreateRagdollGlobal || !MainClass.singleton.Config.Events.Ragdoll.canCreateRagdoll[ev.RoleType])
                ev.IsAllowed = false;
        }

        internal void OnChangeDurability(ChangingDurabilityEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Weapon.canChangeDurability)
                ev.IsAllowed = false;
        }

        internal void OnDamageWindow(DamagingWindowEventArgs ev)
        {
            ev.Damage = ev.Damage * MainClass.singleton.Config.Events.Window.damageMultiplier;
            if (!MainClass.singleton.Config.Events.Window.canBeDamaged)
                ev.Damage = 0f;
        }

        internal void OnAnnounceTermination(AnnouncingScpTerminationEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.announceTerminationGlobal || !MainClass.singleton.Config.Events.Scp.announceTermination[ev.Role.roleId])
                ev.IsAllowed = false;
        }

        internal void OnRecallStart(StartingRecallEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp049StartRecalling)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractTesla(InteractingTeslaEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079useTesla)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractSpeaker(StartingSpeakerEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079useSpeaker)
                ev.IsAllowed = false;
        }

        internal void OnScp079GainLevel(GainingLevelEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079gainLevel)
                ev.IsAllowed = false;
        }

        internal void OnScp096Enrage(EnragingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp096startEnrage)
                ev.IsAllowed = false;
        }

        internal void OnScp106CreatePortal(CreatingPortalEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp106createPortal)
                ev.IsAllowed = false;
        }

        internal void OnScp173Blink(BlinkingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp173blink)
                ev.Targets.Clear();
        }

        internal void OnScp914ChangeKnob(ChangingKnobSettingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp914.canChangeKnobGlobal || !MainClass.singleton.Config.Events.Scp914.canChangeKnob[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadChangeLeverStatus(ChangingLeverStatusEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Warhead.canChangeLeverStatusGlobal || !MainClass.singleton.Config.Events.Warhead.canChangeLeverStatus[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadStop(StoppingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Warhead.canBeDisabledGlobal || !MainClass.singleton.Config.Events.Warhead.canBeDisabled[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadStart(StartingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Warhead.canBeEnabledGlobal || !MainClass.singleton.Config.Events.Warhead.canBeEnabled[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnScp914Activate(ActivatingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp914.canBeActivatedGlobal || !MainClass.singleton.Config.Events.Scp914.canBeActivated[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnScp106UsePortal(TeleportingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp106usePortal)
                ev.IsAllowed = false;
        }

        internal void OnScp106Contain(ContainingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp106getContained)
                ev.IsAllowed = false;
        }

        internal void OnScp096PryGate(StartPryingGateEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp096pryGate)
                ev.IsAllowed = false;
        }

        internal void OnScp096Calmdown(CalmingDownEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp096calmDown)
                ev.IsAllowed = false;
        }

        internal void OnScp079GainExperience(GainingExperienceEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079gainExperience)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractDoor(InteractingDoorEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079useDoor)
                ev.IsAllowed = false;
        }

        internal void OnScp079ElevatorTeleport(ElevatorTeleportEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079useElevatorTeleport)
                ev.IsAllowed = false;
        }

        internal void OnScp079ChangeCamera(ChangingCameraEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Scp.canScp079ChangeCamera)
                ev.IsAllowed = false;
        }

        internal void OnExplodeGrenade(ExplodingGrenadeEventArgs ev)
        {
            if (ev.IsFrag)
            {
                if (!MainClass.singleton.Config.Events.Grenade.canGrenadeExplode)
                    ev.IsAllowed = false;
                if (!MainClass.singleton.Config.Events.Grenade.canGrenadeDealDamageGlobal)
                {
                    ev.TargetToDamages.Clear();
                }
                else
                {
                    foreach(var target in ev.TargetToDamages)
                    {
                        if (!MainClass.singleton.Config.Events.Grenade.canGrenadeDealDamage[target.Key.Role])
                            ev.TargetToDamages[target.Key] = 0f;
                    }
                }
            }
            else
                if (!MainClass.singleton.Config.Events.Grenade.canFlashGrenadeExplode)
                    ev.IsAllowed = false;
        }

        internal void OnDecontaminate(DecontaminatingEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Decontamination.canStartDecontaminationProcedure)
                ev.IsAllowed = false;
        }

        internal void OnAnnounceDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Decontamination.canAnnounce)
                ev.Id = -1;
        }

        internal void OnChangeAttachments(ChangingAttachmentsEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Weapon.canChangeAttachments)
                ev.IsAllowed = false;
        }

        internal void OnInteractElevator(InteractingElevatorEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Elevator.canCallElevatorGlobal || !MainClass.singleton.Config.Events.Elevator.canCallElevator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnThrowGrenade(ThrowingGrenadeEventArgs ev)
        {
            switch (ev.Type)
            {
                case Exiled.API.Enums.GrenadeType.FragGrenade:
                    if (!MainClass.singleton.Config.Events.Grenade.canThrowGrenadeGlobal || !MainClass.singleton.Config.Events.Grenade.canThrowGrenade[ev.Player.Role])
                        ev.IsAllowed = false;
                    break;
                case Exiled.API.Enums.GrenadeType.Flashbang:
                    if (!MainClass.singleton.Config.Events.Grenade.canThrowFlashGrenadeGlobal || !MainClass.singleton.Config.Events.Grenade.canThrowFlashGrenade[ev.Player.Role])
                        ev.IsAllowed = false;
                    break;
            }
        }

        internal void OnCancelMedicalItem(StoppingMedicalItemEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.MedicalItem.canCancelUsingMedicalItemGlobal || !MainClass.singleton.Config.Events.MedicalItem.canUseMedicalItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnUnlockGenerator(UnlockingGeneratorEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Generator.canUnlockGeneratorGlobal || !MainClass.singleton.Config.Events.Generator.canUnlockGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnReloadWeapon(ReloadingWeaponEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Weapon.canReloadWeaponGlobal || !MainClass.singleton.Config.Events.Weapon.canReloadWeapon[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnExitPD(EscapingPocketDimensionEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.PocketDimension.canExitPocketDimensionGlobal || !MainClass.singleton.Config.Events.PocketDimension.canExitPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnEnterPD(EnteringPocketDimensionEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.PocketDimension.canEnterPocketDimensionGlobal || !MainClass.singleton.Config.Events.PocketDimension.canEnterPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnRemoveTablet(EjectingGeneratorTabletEventArgs ev)
        {
            if (!MainClass.singleton.Config.Events.Generator.canRemoveTabletGlobal || !MainClass.singleton.Config.Events.Generator.canRemoveTablet[ev.Player.Role])
                ev.IsAllowed = false;
        }
    }
}
