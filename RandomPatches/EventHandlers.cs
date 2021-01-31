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
        private MainClass instance;
        private Events config;

        public EventHandlers(MainClass instance)
        {
            this.instance = instance;
            this.config = this.instance.Cfg;
        }

        internal void OnActivateWorkstation(ActivatingWorkstationEventArgs ev)
        {
            if (!config.Workstation.canActivateWorkstationGlobal && !config.Workstation.canActivateWorkstation[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnActivateWarheadPanel(ActivatingWarheadPanelEventArgs ev)
        {
        }

        internal void OnClosingGenerator(ClosingGeneratorEventArgs ev)
        {
            if (!config.Generator.canCloseGeneratorGlobal && !config.Generator.canCloseGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnDeactivateWorkstation(DeactivatingWorkstationEventArgs ev)
        {
            if (!config.Workstation.canDeactivateWorkstationGlobal && !config.Workstation.canDeactivateWorkstation[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnDropItem(DroppingItemEventArgs ev)
        {
            if (!config.Item.canDropAnyItemGlobal && !config.Item.canDropAnyItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnOpenGenerator(OpeningGeneratorEventArgs ev)
        {
            if (!config.Generator.canOpenGeneratorGlobal && !config.Generator.canOpenGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnPickupItem(PickingUpItemEventArgs ev)
        {
            if (!config.Item.canPickupAnyItemGlobal && !config.Item.canPickupAnyItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnAddTablet(InsertingGeneratorTabletEventArgs ev)
        {
            if (!config.Generator.canInsertTabletGlobal && !config.Generator.canInsertTablet[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnFailEscapePD(FailingEscapePocketDimensionEventArgs ev)
        {
            if (config.PocketDimension.alwaysExitPocketDimensionGlobal && config.PocketDimension.alwaysExitPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnShotWeapon(ShootingEventArgs ev)
        {
            if (!config.Weapon.canShotWeaponGlobal && !config.Weapon.canShotWeapon[ev.Shooter.Role])
                ev.IsAllowed = false;
        }

        internal void OnActivateTesla(TriggeringTeslaEventArgs ev)
        {
            if (!config.Tesla.canActivateTeslaGlobal && !config.Tesla.canActivateTesla[ev.Player.Role])
                ev.IsTriggerable = false;
        }

        internal void OnUseMedicalItem(UsingMedicalItemEventArgs ev)
        {
            if (!config.MedicalItem.canUseMedicalItemGlobal && !config.MedicalItem.canUseMedicalItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnSpawnRagdoll(SpawningRagdollEventArgs ev)
        {
            if (!config.Ragdoll.canCreateRagdollGlobal && !config.Ragdoll.canCreateRagdoll[ev.RoleType])
                ev.IsAllowed = false;
        }

        internal void OnChangeDurability(ChangingDurabilityEventArgs ev)
        {
            if (!config.Weapon.canChangeDurabilityGlobal)
            {
                if (config.Weapon.canChangeDurability.ContainsKey(ev.OldItem.id))
                {
                    if (!config.Weapon.canChangeDurability[ev.OldItem.id])
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
            ev.Damage = ev.Damage * config.Window.damageMultiplier;
            if (!config.Window.canBeDamaged)
                ev.Damage = 0f;
        }

        internal void OnAnnounceTermination(AnnouncingScpTerminationEventArgs ev)
        {
            if (!config.Scp.announceTerminationGlobal && !config.Scp.announceTermination[ev.Role.roleId])
                ev.IsAllowed = false;
        }

        internal void OnRecallStart(StartingRecallEventArgs ev)
        {
            if (!config.Scp.canScp049StartRecalling)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractTesla(InteractingTeslaEventArgs ev)
        {
            if (!config.Scp.canScp079useTesla)
                ev.IsAllowed = false;
        }

        internal void OnScp079InteractSpeaker(StartingSpeakerEventArgs ev)
        {
            if (!config.Scp.canScp079useSpeaker)
                ev.IsAllowed = false;
        }

        internal void OnScp079GainLevel(GainingLevelEventArgs ev)
        {
            if (!config.Scp.canScp079gainLevel)
                ev.IsAllowed = false;
        }

        internal void OnScp096Enrage(EnragingEventArgs ev)
        {
            if (!config.Scp.canScp096startEnrage)
                ev.IsAllowed = false;
        }

        internal void OnScp106CreatePortal(CreatingPortalEventArgs ev)
        {
            if (!config.Scp.canScp106createPortal)
                ev.IsAllowed = false;
        }

        internal void OnScp173Blink(BlinkingEventArgs ev)
        {
            if (!config.Scp.canScp173blink)
                ev.Targets.Clear();
        }

        internal void OnScp914ChangeKnob(ChangingKnobSettingEventArgs ev)
        {
            if (!config.Scp914.canChangeKnobGlobal && !config.Scp914.canChangeKnob[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadChangeLeverStatus(ChangingLeverStatusEventArgs ev)
        {
            if (!config.Warhead.canChangeLeverStatusGlobal && !config.Warhead.canChangeLeverStatus[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadStop(StoppingEventArgs ev)
        {
            if (!config.Warhead.canBeDisabledGlobal && !config.Warhead.canBeDisabled[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnWarheadStart(StartingEventArgs ev)
        {
            if (!config.Warhead.canBeEnabledGlobal && !config.Warhead.canBeEnabled[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnReloadConfigs()
        {
            instance.LoadConfig();
            OnWaitingForPlayers();
        }

        internal void OnWaitingForPlayers()
        {
            foreach (var tesla in Map.TeslaGates)
            {
                tesla.sizeOfTrigger = config.Tesla.triggerRange;
            }
            foreach (var gen in UnityEngine.Object.FindObjectsOfType<Generator079>())
            {
                gen.NetworkremainingPowerup = config.Generator.remainingPowerup;
            }
            List<string> doors = new List<string>();
            List<string> checkpoints = new List<string>();

            foreach (var cp in UnityEngine.Object.FindObjectsOfType<CheckpointDoor>())
            {
                if (cp.TryGetComponent<DoorNametagExtension>(out DoorNametagExtension name))
                {
                    if (!name.GetName.Contains("CHECKPOINT"))
                        continue;
                    if (!config.Checkpoint.Checkpoints.ContainsKey(name.GetName))
                    {
                        Log.Info($"Add missing checkpoint {name.GetName}.");
                        var doorPerm = cp.RequiredPermissions;
                        config.Checkpoint.Checkpoints.Add(name.GetName, new Checkpoint()
                        {
                            ignoreDamageType = (cp._subDoors[0] as BreakableDoor)._ignoredDamageSources,
                            health = (cp._subDoors[0] as BreakableDoor)._maxHealth,
                            doorPermission = new DoorPerm()
                            {
                                requireAll = doorPerm.RequireAll,
                                keycardPermission = doorPerm.RequiredPermissions
                            }
                        });
                    }
                    var checkpoint = config.Checkpoint.Checkpoints[name.GetName];
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
                            dr._maxHealth = checkpoint.health;
                            dr._remainingHealth = checkpoint.health;
                            dr._ignoredDamageSources = checkpoint.ignoreDamageType;
                        }
                    }
                }
            }
            foreach (var d in UnityEngine.Object.FindObjectsOfType<DoorVariant>())
            {
                if (d.TryGetComponent<DoorNametagExtension>(out DoorNametagExtension name))
                {
                    if (checkpoints.Contains(name.GetName))
                        continue;
                    if (d is BreakableDoor bd)
                    {
                        doors.Add(name.GetName);
                        if (!config.Door.DoorsBreakable.ContainsKey(name.GetName))
                        {
                            Log.Info($"Add missing breakable door {name.GetName}.");
                            var doorPerm = bd.RequiredPermissions;
                            config.Door.DoorsBreakable.Add(name.GetName, new DoorBreakable()
                            {
                                ignoreDamageType = bd._ignoredDamageSources,
                                health = bd._maxHealth,
                                doorPermission = new DoorPerm()
                                {
                                    requireAll = doorPerm.RequireAll,
                                    keycardPermission = doorPerm.RequiredPermissions
                                }
                            });
                        }
                        var door = config.Door.DoorsBreakable[name.GetName];
                        bd._maxHealth = door.health;
                        bd._remainingHealth = door.health;
                        bd._ignoredDamageSources = door.ignoreDamageType;
                        bd.RequiredPermissions = new DoorPermissions()
                        {
                            RequireAll = door.doorPermission.requireAll,
                            RequiredPermissions = door.doorPermission.keycardPermission
                        };
                    }
                    else
                    {
                        doors.Add(name.GetName);
                        if (!config.Door.Doors.ContainsKey(name.GetName))
                        {
                            Log.Info($"Add missing door {name.GetName}.");
                            var doorPerm = d.RequiredPermissions;
                            config.Door.Doors.Add(name.GetName, new Door()
                            {
                                doorPermission = new DoorPerm()
                                {
                                    requireAll = doorPerm.RequireAll,
                                    keycardPermission = doorPerm.RequiredPermissions
                                }
                            });
                        }
                        var door = config.Door.Doors[name.GetName];
                        d.RequiredPermissions = new DoorPermissions()
                        {
                            RequireAll = door.doorPermission.requireAll,
                            RequiredPermissions = door.doorPermission.keycardPermission
                        };
                    }
                }
                else
                {
                    if (d is BreakableDoor bd)
                    {
                        var nm = $"{(d.name.StartsWith("EZ") ? "ENTRANCE_ZONE" : d.name.StartsWith("HCZ") ? "HEAVY_ZONE" : "LIGHT_ZONE")}";
                        doors.Add(nm);
                        if (!config.Door.DoorsBreakable.ContainsKey(nm))
                        {
                            Log.Info($"Add missing breakable door {nm}.");
                            var doorPerm = bd.RequiredPermissions;
                            config.Door.DoorsBreakable.Add(nm, new DoorBreakable()
                            {
                                ignoreDamageType = bd._ignoredDamageSources,
                                health = bd._maxHealth,
                                doorPermission = new DoorPerm()
                                {
                                    requireAll = doorPerm.RequireAll,
                                    keycardPermission = doorPerm.RequiredPermissions
                                }
                            });
                        }
                        var bdoor = config.Door.DoorsBreakable[nm];
                        bd._ignoredDamageSources = bdoor.ignoreDamageType;
                        bd.RequiredPermissions = new DoorPermissions()
                        {
                            RequireAll = bdoor.doorPermission.requireAll,
                            RequiredPermissions = bdoor.doorPermission.keycardPermission
                        };
                        bd._maxHealth = bdoor.health;
                        bd._remainingHealth = bdoor.health;
                    }
                }
            }
            foreach (var door in config.Door.Doors.Keys.ToArray())
            {
                if (!doors.Contains(door))
                {
                    config.Door.Doors.Remove(door);
                    Log.Info($"Removed door {door}, reason: not found.");
                }
            }
            foreach (var door in config.Door.DoorsBreakable.Keys.ToArray())
            {
                if (!doors.Contains(door))
                {
                    config.Door.DoorsBreakable.Remove(door);
                    Log.Info($"Removed breakable door {door}, reason: not found.");
                }
            }
            foreach (var checkpoint in config.Checkpoint.Checkpoints.Keys.ToArray())
            {
                if (!checkpoints.Contains(checkpoint))
                {
                    config.Checkpoint.Checkpoints.Remove(checkpoint);
                    Log.Info($"Removed checkpoint {checkpoint}, reason: not found.");
                }
            }
            instance.SaveConfig();
        }

        internal void OnScp914Activate(ActivatingEventArgs ev)
        {
            if (!config.Scp914.canBeActivatedGlobal && !config.Scp914.canBeActivated[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnScp106UsePortal(TeleportingEventArgs ev)
        {
            if (!config.Scp.canScp106usePortal)
                ev.IsAllowed = false;
        }

        internal void OnScp106Contain(ContainingEventArgs ev)
        {
            if (!config.Scp.canScp106getContained)
                ev.IsAllowed = false;
        }

        internal void OnScp096PryGate(StartPryingGateEventArgs ev)
        {
            if (!config.Scp.canScp096pryGate)
                ev.IsAllowed = false;
        }

        internal void OnScp096Calmdown(CalmingDownEventArgs ev)
        {
            if (!config.Scp.canScp096calmDown)
                ev.IsAllowed = false;
        }

        internal void OnScp079GainExperience(GainingExperienceEventArgs ev)
        {
            if (!config.Scp.canScp079gainExperience)
                ev.IsAllowed = false;
            ev.Amount = ev.Amount * config.Scp.scp079experienceMultiplier;
        }

        internal void OnScp079InteractDoor(InteractingDoorEventArgs ev)
        {
            if (!config.Scp.canScp079useDoor)
                ev.IsAllowed = false;
        }

        internal void OnScp079ElevatorTeleport(ElevatorTeleportEventArgs ev)
        {
            if (!config.Scp.canScp079useElevatorTeleport)
                ev.IsAllowed = false;
        }

        internal void OnScp079ChangeCamera(ChangingCameraEventArgs ev)
        {
            if (!config.Scp.canScp079ChangeCamera)
                ev.IsAllowed = false;
        }

        internal void OnExplodeGrenade(ExplodingGrenadeEventArgs ev)
        {
            if (ev.IsFrag)
            {
                if (!config.Grenade.canGrenadeExplode)
                    ev.IsAllowed = false;
                if (!config.Grenade.canGrenadeDealDamageGlobal)
                {
                    ev.TargetToDamages.Clear();
                }
                else
                {
                    foreach (var target in ev.TargetToDamages)
                    {
                        if (!config.Grenade.canGrenadeDealDamage[target.Key.Role])
                            ev.TargetToDamages[target.Key] = 0f;
                    }
                }
            }
            else
                if (!config.Grenade.canFlashGrenadeExplode)
                ev.IsAllowed = false;
        }

        internal void OnDecontaminate(DecontaminatingEventArgs ev)
        {
            if (!config.Decontamination.canStartDecontaminationProcedure)
                ev.IsAllowed = false;
        }

        internal void OnAnnounceDecontamination(AnnouncingDecontaminationEventArgs ev)
        {
            if (!config.Decontamination.canAnnounce)
                ev.Id = -1;
        }

        internal void OnChangeAttachments(ChangingAttachmentsEventArgs ev)
        {
            if (!config.Weapon.canChangeAttachments)
                ev.IsAllowed = false;
        }

        internal void OnInteractElevator(InteractingElevatorEventArgs ev)
        {
            if (!config.Elevator.canCallElevatorGlobal && !config.Elevator.canCallElevator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnThrowGrenade(ThrowingGrenadeEventArgs ev)
        {
            switch (ev.Type)
            {
                case Exiled.API.Enums.GrenadeType.FragGrenade:
                    if (!config.Grenade.canThrowGrenadeGlobal && !config.Grenade.canThrowGrenade[ev.Player.Role])
                        ev.IsAllowed = false;
                    break;
                case Exiled.API.Enums.GrenadeType.Flashbang:
                    if (!config.Grenade.canThrowFlashGrenadeGlobal && !config.Grenade.canThrowFlashGrenade[ev.Player.Role])
                        ev.IsAllowed = false;
                    break;
            }
        }

        internal void OnCancelMedicalItem(StoppingMedicalItemEventArgs ev)
        {
            if (!config.MedicalItem.canCancelUsingMedicalItemGlobal && !config.MedicalItem.canUseMedicalItem[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnUnlockGenerator(UnlockingGeneratorEventArgs ev)
        {
            if (!config.Generator.canUnlockGeneratorGlobal && !config.Generator.canUnlockGenerator[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnReloadWeapon(ReloadingWeaponEventArgs ev)
        {
            if (!config.Weapon.canReloadWeaponGlobal && !config.Weapon.canReloadWeapon[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnExitPD(EscapingPocketDimensionEventArgs ev)
        {
            if (!config.PocketDimension.canExitPocketDimensionGlobal && !config.PocketDimension.canExitPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnEnterPD(EnteringPocketDimensionEventArgs ev)
        {
            if (!config.PocketDimension.canEnterPocketDimensionGlobal && !config.PocketDimension.canEnterPocketDimension[ev.Player.Role])
                ev.IsAllowed = false;
        }

        internal void OnRemoveTablet(EjectingGeneratorTabletEventArgs ev)
        {
            if (!config.Generator.canRemoveTabletGlobal && !config.Generator.canRemoveTablet[ev.Player.Role])
                ev.IsAllowed = false;
        }
    }
}