using Exiled.API.Features;
using Exiled.API.Interfaces;
using Interactables.Interobjects.DoorUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPatches
{
    public class PluginConfig : IConfig
    {
        public PluginConfig()
        {
            Folder = Paths.Configs;
            FullPath = Path.Combine(Folder, $"{Server.Port}-randompatches.yml");
        }
        public bool IsEnabled { get; set; } = true;

        [Description("The randompatches folder path")]
        public string Folder { get; private set; }

        [Description("The randompatches full path")]
        public string FullPath { get; private set; }
    }

    public class Events
    {
        public EventWorkstation Workstation { get; set; } = new EventWorkstation();
        public EventWarhead Warhead { get; set; } = new EventWarhead();
        public EventGenerator Generator { get; set; } = new EventGenerator();
        public EventMedicalItem MedicalItem { get; set; } = new EventMedicalItem();
        public EventItem Item { get; set; } = new EventItem();
        public EventPocketDimension PocketDimension { get; set; } = new EventPocketDimension();
        public EventWeapon Weapon { get; set; } = new EventWeapon();
        public EventTesla Tesla { get; set; } = new EventTesla();
        public EventGrenade Grenade { get; set; } = new EventGrenade();
        public EventElevator Elevator { get; set; } = new EventElevator();
        public EventRagdoll Ragdoll { get; set; } = new EventRagdoll();
        public EventDecontamination Decontamination { get; set; } = new EventDecontamination();
        public EventWindow Window { get; set; } = new EventWindow();
        public EventScp Scp { get; set; } = new EventScp();
        public EventScp914 Scp914 { get; set; } = new EventScp914();
        public EventsCheckpoint Checkpoint { get; set; } = new EventsCheckpoint();
        public EventsDoor Door { get; set; } = new EventsDoor();

    }

    public class EventsDoor
    {
        public Dictionary<string, Door> Doors { get; set; } = new Dictionary<string, Door>();
        public Dictionary<string, DoorBreakable> DoorsBreakable { get; set; } = new Dictionary<string, DoorBreakable>();
    }

    public class DoorPerm
    {
        public bool requireAll { get; set; }
        public KeycardPermissions keycardPermission { get; set; }
    }

    public class DoorBreakable
    {
        public float health { get; set; }
        public DoorPerm doorPermission { get; set; }
        public DoorDamageType ignoreDamageType { get; set; }
    }

    public class Door
    {
        public DoorPerm doorPermission { get; set; }
    }


    public class EventsCheckpoint
    {
        public Dictionary<string, Checkpoint> Checkpoints { get; set; } = new Dictionary<string, Checkpoint>();
    }

    public class Checkpoint
    {
        public float health { get; set; }
        public DoorPerm doorPermission { get; set; }
        public DoorDamageType ignoreDamageType { get; set; }
    }

    public class EventWorkstation
    {
        public bool canActivateWorkstationGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canActivateWorkstation { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
        public bool canDeactivateWorkstationGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canDeactivateWorkstation { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventWarhead
    {
        public bool canChangeLeverStatusGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canChangeLeverStatus { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canBeEnabledGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canBeEnabled { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canBeDisabledGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canBeDisabled { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventGenerator
    {
        public bool canCloseGeneratorGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canCloseGenerator { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canOpenGeneratorGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canOpenGenerator { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canInsertTabletGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canInsertTablet { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
        public bool canRemoveTabletGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canRemoveTablet { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canUnlockGeneratorGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canUnlockGenerator { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
        public float remainingPowerup { get; set; } = 70f;
    }

    public class EventItem
    {
        public bool canDropAnyItemGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canDropAnyItem { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
        public bool canPickupAnyItemGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canPickupAnyItem { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventMedicalItem
    {
        public bool canUseMedicalItemGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canUseMedicalItem { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canCancelUsingMedicalItemGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canCancelUsingMedicalItem { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventPocketDimension
    {
        public bool canEnterPocketDimensionGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canEnterPocketDimension { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canExitPocketDimensionGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canExitPocketDimension { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool alwaysExitPocketDimensionGlobal { get; set; } = false;
        public Dictionary<RoleType, bool> alwaysExitPocketDimension { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, false },
            { RoleType.ClassD, false },
            { RoleType.FacilityGuard, false },
            { RoleType.NtfCadet, false },
            { RoleType.NtfCommander, false },
            { RoleType.NtfLieutenant, false },
            { RoleType.NtfScientist, false },
            { RoleType.Scientist, false },
            { RoleType.Scp049, false },
            { RoleType.Scp0492, false },
            { RoleType.Scp079, false },
            { RoleType.Scp096, false },
            { RoleType.Scp106, false },
            { RoleType.Scp173, false },
            { RoleType.Scp93953, false },
            { RoleType.Scp93989, false },
            { RoleType.Tutorial, false }
        };
    }

    public class EventWeapon
    {
        public bool canReloadWeaponGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canReloadWeapon { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canShotWeaponGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canShotWeapon { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canChangeAttachments { get; set; } = true;
        public bool canChangeDurabilityGlobal { get; set; } = true;
        public Dictionary<ItemType, bool> canChangeDurability { get; set; } = new Dictionary<ItemType, bool>()
        {
            { ItemType.MicroHID, true },
            { ItemType.GunCOM15, true },
            { ItemType.GunE11SR, true },
            { ItemType.GunLogicer, true },
            { ItemType.GunMP7, true },
            { ItemType.GunProject90, true },
            { ItemType.GunUSP, true }
        };
    }

    public class EventTesla
    {
        public bool canActivateTeslaGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canActivateTesla { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public float triggerRange { get; set; } = 5.5f;
    }

    public class EventGrenade
    {
        public bool canThrowGrenadeGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canThrowGrenade { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
        public bool canThrowFlashGrenadeGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canThrowFlashGrenade { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Tutorial, true }
        };
        public bool canGrenadeExplode { get; set; } = true;
        public bool canFlashGrenadeExplode { get; set; } = true;
        public bool canGrenadeDealDamageGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canGrenadeDealDamage { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventElevator
    {
        public bool canCallElevatorGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canCallElevator { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventRagdoll
    {
        public bool canCreateRagdollGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canCreateRagdoll { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
    }

    public class EventDecontamination
    {
        public bool canAnnounce { get; set; } = true;
        public bool canStartDecontaminationProcedure { get; set; } = true;
    }

    public class EventWindow
    {
        public bool canBeDamaged { get; set; } = true;
        public float damageMultiplier { get; set; } = 1f;
    }

    public class EventScp
    {
        public bool announceTerminationGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> announceTermination { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.Scp049, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true }
        };
        public bool canScp049StartRecalling { get; set; } = true;
        public bool canScp079ChangeCamera { get; set; } = true;
        public bool canScp079useElevatorTeleport { get; set; } = true;
        public bool canScp079useTesla { get; set; } = true;
        public bool canScp079useDoor { get; set; } = true;
        public bool canScp079useSpeaker { get; set; } = true;
        public bool canScp079gainLevel { get; set; } = true;
        public bool canScp079gainExperience { get; set; } = true;
        public float scp079experienceMultiplier { get; set; } = 1f;
        public bool canScp096calmDown { get; set; } = true;
        public bool canScp096startEnrage { get; set; } = true;
        public bool canScp096pryGate { get; set; } = true;
        public bool canScp096destroyDoor { get; set; } = true;
        public bool canScp106createPortal { get; set; } = true;
        public bool canScp106usePortal { get; set; } = true;
        public bool canScp106getContained { get; set; } = true;
        public bool canScp173blink { get; set; } = true;
    }

    public class EventScp914
    {
        public bool canBeActivatedGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canBeActivated { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
        public bool canChangeKnobGlobal { get; set; } = true;
        public Dictionary<RoleType, bool> canChangeKnob { get; set; } = new Dictionary<RoleType, bool>()
        {
            { RoleType.ChaosInsurgency, true },
            { RoleType.ClassD, true },
            { RoleType.FacilityGuard, true },
            { RoleType.NtfCadet, true },
            { RoleType.NtfCommander, true },
            { RoleType.NtfLieutenant, true },
            { RoleType.NtfScientist, true },
            { RoleType.Scientist, true },
            { RoleType.Scp049, true },
            { RoleType.Scp0492, true },
            { RoleType.Scp079, true },
            { RoleType.Scp096, true },
            { RoleType.Scp106, true },
            { RoleType.Scp173, true },
            { RoleType.Scp93953, true },
            { RoleType.Scp93989, true },
            { RoleType.Tutorial, true }
        };
    }
}
