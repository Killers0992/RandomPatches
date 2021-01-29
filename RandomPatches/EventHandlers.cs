using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Interactables.Interobjects;
using Interactables.Interobjects.DoorUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPatches
{
    public class EventHandlers
    {
        internal void OnActivateWorkstation(ActivatingWorkstationEventArgs ev)
        {
            if (!MainClass.Cfg.Workstation.canActivateWorkstationGlobal || !MainClass.Cfg.Workstation.canActivateWorkstation[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnActivateWarheadPanel(ActivatingWarheadPanelEventArgs ev)
        {
        }

        internal void OnClosingGenerator(ClosingGeneratorEventArgs ev)
        {
            if (!MainClass.Cfg.Generator.canCloseGeneratorGlobal || !MainClass.Cfg.Generator.canCloseGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnDeactivateWorkstation(DeactivatingWorkstationEventArgs ev)
        {
            if (!MainClass.Cfg.Workstation.canDeactivateWorkstationGlobal || !MainClass.Cfg.Workstation.canDeactivateWorkstation[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnDropItem(DroppingItemEventArgs ev)
        {
            if (!MainClass.Cfg.Item.canDropAnyItemGlobal || !MainClass.Cfg.Item.canDropAnyItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnOpenGenerator(OpeningGeneratorEventArgs ev)
        {
            if (!MainClass.Cfg.Generator.canOpenGeneratorGlobal || !MainClass.Cfg.Generator.canOpenGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnPickupItem(PickingUpItemEventArgs ev)
        {
            if (!MainClass.Cfg.Item.canPickupAnyItemGlobal || !MainClass.Cfg.Item.canPickupAnyItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnAddTablet(InsertingGeneratorTabletEventArgs ev)
        {
            if (!MainClass.Cfg.Generator.canInsertTabletGlobal || !MainClass.Cfg.Generator.canInsertTablet[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnFailEscapePD(FailingEscapePocketDimensionEventArgs ev)
        {
            if (MainClass.Cfg.PocketDimension.alwaysExitPocketDimensionGlobal || MainClass.Cfg.PocketDimension.alwaysExitPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnShotWeapon(ShootingEventArgs ev)
        {
            if (!MainClass.Cfg.Weapon.canShotWeaponGlobal || !MainClass.Cfg.Weapon.canShotWeapon[ev.Shooter.Role])
                ev.IsAllowed = false;
        }

        internal void OnActivateTesla(TriggeringTeslaEventArgs ev)
        {
            if (!MainClass.Cfg.Tesla.canActivateTeslaGlobal || !MainClass.Cfg.Tesla.canActivateTesla[ev.Player.Role])
                ev.IsTriggerable = false;
        }

        internal void OnUseMedicalItem(UsingMedicalItemEventArgs ev)
        {
            if (!MainClass.Cfg.MedicalItem.canUseMedicalItemGlobal || !MainClass.Cfg.MedicalItem.canUseMedicalItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnSpawnRagdoll(SpawningRagdollEventArgs ev)
        {
            if (!MainClass.Cfg.Ragdoll.canCreateRagdollGlobal || !MainClass.Cfg.Ragdoll.canCreateRagdoll[ev.RoleType])
                ev.IsAllowed = false;
        }

        internal void OnChangeDurability(ChangingDurabilityEventArgs ev)
        {
            if (!MainClass.Cfg.Weapon.canChangeDurabilityGlobal)
            {
                if (MainClass.Cfg.Weapon.canChangeDurability.ContainsKey(ev.OldItem.id))
                {
                    if (!MainClass.Cfg.Weapon.canChangeDurability[ev.OldItem.id])
                    {
                        ev.IsAllowed = false;
                        return;
                    }
                }
                ev.IsAllowed = false;
            }
        }

        internal void OnDamageWindow(DamagingWindowEventArgs ev)
        {
            ev.Damage = ev.Damage * MainClass.Cfg.Window.damageMultiplier;
            if (!MainClass.Cfg.Window.canBeDamaged)
                ev.Damage = 0f;
        }

        internal void OnAnnounceTermination(AnnouncingScpTerminationEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.announceTerminationGlobal || !MainClass.Cfg.Scp.announceTermination[ev.Role.roleId])
                ev.IsAllowed = false;
        }

        internal void OnRecallStart(StartingRecallEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp049StartRecalling)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractTesla(InteractingTeslaEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079useTesla)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractSpeaker(StartingSpeakerEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079useSpeaker)
                ev.IsAllowed = false;
        }

        internal void OnScp079GainLevel(GainingLevelEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079gainLevel)
                ev.IsAllowed = false;
        }

        internal void OnScp096Enrage(EnragingEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp096startEnrage)
                ev.IsAllowed = false;
        }

        internal void OnScp106CreatePortal(CreatingPortalEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp106createPortal)
                ev.IsAllowed = false;
        }

        internal void OnScp173Blink(BlinkingEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp173blink)
                ev.Targets.Clear();
        }

        internal void OnScp914ChangeKnob(ChangingKnobSettingEventArgs ev)
        {
            if (!MainClass.Cfg.Scp914.canChangeKnobGlobal || !MainClass.Cfg.Scp914.canChangeKnob[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadChangeLeverStatus(ChangingLeverStatusEventArgs ev)
        {
            if (!MainClass.Cfg.Warhead.canChangeLeverStatusGlobal || !MainClass.Cfg.Warhead.canChangeLeverStatus[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadStop(StoppingEventArgs ev)
        {
            if (!MainClass.Cfg.Warhead.canBeDisabledGlobal || !MainClass.Cfg.Warhead.canBeDisabled[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadStart(StartingEventArgs ev)
        {
            if (!MainClass.Cfg.Warhead.canBeEnabledGlobal || !MainClass.Cfg.Warhead.canBeEnabled[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnReloadConfigs()
        {
            MainClass.Cfg = MainClass.Deserializer.Deserialize<Events>(File.ReadAllText(MainClass.singleton.Config.FullPath));
            OnWaitingForPlayers();
        }

        internal void OnWaitingForPlayers()
        {
            foreach (var tesla in Map.TeslaGates)
            {
                tesla.sizeOfTrigger = MainClass.Cfg.Tesla.triggerRange;
            }
            foreach (var gen in UnityEngine.Object.FindObjectsOfType<Generator079>())
            {
                gen.NetworkremainingPowerup = MainClass.Cfg.Generator.remainingPowerup;
            }
            List<string> doors = new List<string>();
            List<string> checkpoints = new List<string>();

            foreach (var cp in UnityEngine.Object.FindObjectsOfType<CheckpointDoor>())
            {
                if (cp.TryGetComponent<DoorNametagExtension>(out DoorNametagExtension name))
                {
                    if (!name.GetName.Contains("CHECKPOINT"))
                        continue;
                    if (!MainClass.Cfg.Checkpoint.Checkpoints.ContainsKey(name.GetName))
                    {
                        Log.Info($"Add missing checkpoint {name.GetName}.");
                        var doorPerm = cp.RequiredPermissions;
                        MainClass.Cfg.Checkpoint.Checkpoints.Add(name.GetName, new Checkpoint()
                        {
                            ignoreDamageType = (cp._subDoors[0] as BreakableDoor)._ignoredDamageSources,
                            doorPermission = new DoorPerm()
                            {
                                requireAll = doorPerm.RequireAll,
                                keycardPermission = doorPerm.RequiredPermissions
                            }
                        });
                    }
                    var checkpoint = MainClass.Cfg.Checkpoint.Checkpoints[name.GetName];
                    checkpoints.Add(name.GetName);
                    cp.RequiredPermissions = new DoorPermissions()
                    {
                        RequireAll = checkpoint.doorPermission.requireAll,
                        RequiredPermissions = checkpoint.doorPermission.keycardPermission
                    };
                    foreach (var door in cp._subDoors)
                    {
                        if (door is BreakableDoor dr)
                        {
                            dr._ignoredDamageSources = checkpoint.ignoreDamageType;
                        }
                    }
                }
            }
            foreach(var d in UnityEngine.Object.FindObjectsOfType<DoorVariant>())
            {
                if (d.TryGetComponent<DoorNametagExtension>(out DoorNametagExtension name))
                {
                    if (checkpoints.Contains(name.GetName))
                        continue;
                    if (d is BreakableDoor bd)
                    {
                        doors.Add(name.GetName);
                        if (!MainClass.Cfg.Door.Doors.ContainsKey(name.GetName))
                        {
                            Log.Info($"Add missing door {name.GetName}.");
                            var doorPerm = bd.RequiredPermissions;
                            MainClass.Cfg.Door.Doors.Add(name.GetName, new Door()
                            {
                                ignoreDamageType = bd._ignoredDamageSources,
                                doorPermission = new DoorPerm()
                                {
                                    requireAll = doorPerm.RequireAll,
                                    keycardPermission = doorPerm.RequiredPermissions
                                }
                            });
                        }
                        bd._ignoredDamageSources = MainClass.Cfg.Door.Doors[name.GetName].ignoreDamageType;
                    }
                }
            }
            foreach(var door in MainClass.Cfg.Door.Doors.Keys.ToArray())
            {
                if (!doors.Contains(door))
                {
                    MainClass.Cfg.Door.Doors.Remove(door);
                    Log.Info($"Removed door {door}, reason: not found.");
                }
            }
            foreach (var checkpoint in MainClass.Cfg.Checkpoint.Checkpoints.Keys.ToArray())
            {
                if (!checkpoints.Contains(checkpoint))
                {
                    MainClass.Cfg.Checkpoint.Checkpoints.Remove(checkpoint);
                    Log.Info($"Removed checkpoint {checkpoint}, reason: not found.");
                }
            }
            MainClass.singleton.SaveConfig();
        }

        internal void OnScp914Activate(ActivatingEventArgs ev)
        {
            if (!MainClass.Cfg.Scp914.canBeActivatedGlobal || !MainClass.Cfg.Scp914.canBeActivated[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnScp106UsePortal(TeleportingEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp106usePortal)
                ev.IsAllowed = false;
        }

        internal void OnScp106Contain(ContainingEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp106getContained)
                ev.IsAllowed = false;
        }

        internal void OnScp096PryGate(StartPryingGateEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp096pryGate)
                ev.IsAllowed = false;
        }

        internal void OnScp096Calmdown(CalmingDownEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp096calmDown)
                ev.IsAllowed = false;
        }

        internal void OnScp079GainExperience(GainingExperienceEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079gainExperience)
                ev.IsAllowed = false;
            ev.Amount = ev.Amount * MainClass.Cfg.Scp.scp079experienceMultiplier;
        }

        internal void OnScp079InteractDoor(InteractingDoorEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079useDoor)
                ev.IsAllowed = false;
        }

        internal void OnScp079ElevatorTeleport(ElevatorTeleportEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079useElevatorTeleport)
                ev.IsAllowed = false;
        }

        internal void OnScp079ChangeCamera(ChangingCameraEventArgs ev)
        {
            if (!MainClass.Cfg.Scp.canScp079ChangeCamera)
                ev.IsAllowed = false;
        }

        internal void OnExplodeGrenade(ExplodingGrenadeEventArgs ev)
        {
            if (ev.IsFrag)
            {
                if (!MainClass.Cfg.Grenade.canGrenadeExplode)
                    ev.IsAllowed = false;
                if (!MainClass.Cfg.Grenade.canGrenadeDealDamageGlobal)
                {
                    ev.TargetToDamages.Clear();
                }
                else
                {
                    foreach (var target in ev.TargetToDamages)
                    {
                        if (!MainClass.Cfg.Grenade.canGrenadeDealDamage[target.Key.Role])
                            ev.TargetToDamages[target.Key] = 0f;
                    }
                }
            }
            else
                if (!MainClass.Cfg.Grenade.canFlashGrenadeExplode)
                ev.IsAllowed = false;
        }

        internal void OnDecontaminate(DecontaminatingEventArgs ev)
        {
            if (!MainClass.Cfg.Decontamination.canStartDecontaminationProcedure)
                ev.IsAllowed = false;
        }

        internal void OnAnnounceDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            if (!MainClass.Cfg.Decontamination.canAnnounce)
                ev.Id = -1;
        }

        internal void OnChangeAttachments(ChangingAttachmentsEventArgs ev)
        {
            if (!MainClass.Cfg.Weapon.canChangeAttachments)
                ev.IsAllowed = false;
        }

        internal void OnInteractElevator(InteractingElevatorEventArgs ev)
        {
            if (!MainClass.Cfg.Elevator.canCallElevatorGlobal || !MainClass.Cfg.Elevator.canCallElevator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnThrowGrenade(ThrowingGrenadeEventArgs ev)
        {
            switch (ev.Type)
            {
                case Exiled.API.Enums.GrenadeType.FragGrenade:
                    if (!MainClass.Cfg.Grenade.canThrowGrenadeGlobal || !MainClass.Cfg.Grenade.canThrowGrenade[ev.Player.Role])
                        ev.IsAllowed = false;
                    break;
                case Exiled.API.Enums.GrenadeType.Flashbang:
                    if (!MainClass.Cfg.Grenade.canThrowFlashGrenadeGlobal || !MainClass.Cfg.Grenade.canThrowFlashGrenade[ev.Player.Role])
                        ev.IsAllowed = false;
                    break;
            }
        }

        internal void OnCancelMedicalItem(StoppingMedicalItemEventArgs ev)
        {
            if (!MainClass.Cfg.MedicalItem.canCancelUsingMedicalItemGlobal || !MainClass.Cfg.MedicalItem.canUseMedicalItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnUnlockGenerator(UnlockingGeneratorEventArgs ev)
        {
            if (!MainClass.Cfg.Generator.canUnlockGeneratorGlobal || !MainClass.Cfg.Generator.canUnlockGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnReloadWeapon(ReloadingWeaponEventArgs ev)
        {
            if (!MainClass.Cfg.Weapon.canReloadWeaponGlobal || !MainClass.Cfg.Weapon.canReloadWeapon[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnExitPD(EscapingPocketDimensionEventArgs ev)
        {
            if (!MainClass.Cfg.PocketDimension.canExitPocketDimensionGlobal || !MainClass.Cfg.PocketDimension.canExitPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnEnterPD(EnteringPocketDimensionEventArgs ev)
        {
            if (!MainClass.Cfg.PocketDimension.canEnterPocketDimensionGlobal || !MainClass.Cfg.PocketDimension.canEnterPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnRemoveTablet(EjectingGeneratorTabletEventArgs ev)
        {
            if (!MainClass.Cfg.Generator.canRemoveTabletGlobal || !MainClass.Cfg.Generator.canRemoveTablet[ev.Player.Role])
                ev.IsAllowed = false;
        }
    }
}