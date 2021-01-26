using Exiled.API.Features;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPatches
{
    public class MainClass : Plugin<PluginConfig>
    {
        public override string Author { get; } = "Killers0992";
        public override string Name { get; } = "RandomPatches";
        public override string Prefix { get; } = "randompatches";

        public Harmony harmony;
        public EventHandlers eventHandlers;
        public static MainClass singleton;

        public override void OnEnabled()
        {
            if (!Config.IsEnabled)
                return;
            singleton = this;
            base.OnEnabled();
            eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.ActivatingWorkstation += eventHandlers.OnActivateWorkstation;
            Exiled.Events.Handlers.Player.ActivatingWarheadPanel += eventHandlers.OnActivateWarheadPanel;
            Exiled.Events.Handlers.Player.ClosingGenerator += eventHandlers.OnClosingGenerator;
            Exiled.Events.Handlers.Player.OpeningGenerator += eventHandlers.OnOpenGenerator;
            Exiled.Events.Handlers.Player.DeactivatingWorkstation += eventHandlers.OnDeactivateWorkstation;
            Exiled.Events.Handlers.Player.DroppingItem += eventHandlers.OnDropItem;
            Exiled.Events.Handlers.Player.PickingUpItem += eventHandlers.OnPickupItem;
            Exiled.Events.Handlers.Player.EjectingGeneratorTablet += eventHandlers.OnRemoveTablet;
            Exiled.Events.Handlers.Player.InsertingGeneratorTablet += eventHandlers.OnAddTablet;
            Exiled.Events.Handlers.Player.EnteringPocketDimension += eventHandlers.OnEnterPD;
            Exiled.Events.Handlers.Player.EscapingPocketDimension += eventHandlers.OnExitPD;
            Exiled.Events.Handlers.Player.FailingEscapePocketDimension += eventHandlers.OnFailEscapePD;
            Exiled.Events.Handlers.Player.ReloadingWeapon += eventHandlers.OnReloadWeapon;
            Exiled.Events.Handlers.Player.Shooting += eventHandlers.OnShotWeapon;
            Exiled.Events.Handlers.Player.UnlockingGenerator += eventHandlers.OnUnlockGenerator;
            Exiled.Events.Handlers.Player.TriggeringTesla += eventHandlers.OnActivateTesla;
            Exiled.Events.Handlers.Player.StoppingMedicalItem += eventHandlers.OnCancelMedicalItem;
            Exiled.Events.Handlers.Player.UsingMedicalItem += eventHandlers.OnUseMedicalItem;
            Exiled.Events.Handlers.Player.ThrowingGrenade += eventHandlers.OnThrowGrenade;
            Exiled.Events.Handlers.Player.InteractingElevator += eventHandlers.OnInteractElevator;
            Exiled.Events.Handlers.Player.SpawningRagdoll += eventHandlers.OnSpawnRagdoll;
            Exiled.Events.Handlers.Item.ChangingAttachments += eventHandlers.OnChangeAttachments;
            Exiled.Events.Handlers.Item.ChangingDurability += eventHandlers.OnChangeDurability;
            Exiled.Events.Handlers.Map.AnnouncingDecontamination += eventHandlers.OnAnnounceDecontamination;
            Exiled.Events.Handlers.Map.DamagingWindow += eventHandlers.OnDamageWindow;
            Exiled.Events.Handlers.Map.Decontaminating += eventHandlers.OnDecontaminate;
            Exiled.Events.Handlers.Map.AnnouncingScpTermination += eventHandlers.OnAnnounceTermination;
            Exiled.Events.Handlers.Map.ExplodingGrenade += eventHandlers.OnExplodeGrenade;
            Exiled.Events.Handlers.Scp049.StartingRecall += eventHandlers.OnRecallStart;
            Exiled.Events.Handlers.Scp079.ChangingCamera += eventHandlers.OnScp079ChangeCamera;
            Exiled.Events.Handlers.Scp079.ElevatorTeleport += eventHandlers.OnScp079ElevatorTeleport;
            Exiled.Events.Handlers.Scp079.InteractingTesla += eventHandlers.OnScp079InteractTesla;
            Exiled.Events.Handlers.Scp079.InteractingDoor += eventHandlers.OnScp079InteractDoor;
            Exiled.Events.Handlers.Scp079.StartingSpeaker += eventHandlers.OnScp079InteractSpeaker;
            Exiled.Events.Handlers.Scp079.GainingExperience += eventHandlers.OnScp079GainExperience;
            Exiled.Events.Handlers.Scp079.GainingLevel += eventHandlers.OnScp079GainLevel;
            Exiled.Events.Handlers.Scp096.CalmingDown += eventHandlers.OnScp096Calmdown;
            Exiled.Events.Handlers.Scp096.Enraging += eventHandlers.OnScp096Enrage;
            Exiled.Events.Handlers.Scp096.StartPryingGate += eventHandlers.OnScp096PryGate;
            Exiled.Events.Handlers.Scp106.CreatingPortal += eventHandlers.OnScp106CreatePortal;
            Exiled.Events.Handlers.Scp106.Containing += eventHandlers.OnScp106Contain;
            Exiled.Events.Handlers.Scp106.Teleporting += eventHandlers.OnScp106UsePortal;
            Exiled.Events.Handlers.Scp173.Blinking += eventHandlers.OnScp173Blink;
            Exiled.Events.Handlers.Scp914.Activating += eventHandlers.OnScp914Activate;
            Exiled.Events.Handlers.Scp914.ChangingKnobSetting += eventHandlers.OnScp914ChangeKnob;
            Exiled.Events.Handlers.Warhead.ChangingLeverStatus += eventHandlers.OnWarheadChangeLeverStatus;
            Exiled.Events.Handlers.Warhead.Starting += eventHandlers.OnWarheadStart;
            Exiled.Events.Handlers.Warhead.Stopping += eventHandlers.OnWarheadStop;
            harmony = new Harmony($"randompatches.{DateTime.Now.Ticks}");
            harmony.PatchAll();
            Exiled.Events.Handlers.Server.WaitingForPlayers += Server_WaitingForPlayers;
        }

        private void Server_WaitingForPlayers()
        {
            foreach(var tesla in Map.TeslaGates)
            {
                tesla.sizeOfTrigger = Config.Events.Tesla.triggerRange;
            }
            foreach(var gen in UnityEngine.Object.FindObjectsOfType<Generator079>())
            {
                gen.NetworkremainingPowerup = Config.Events.Generator.remainingPowerup;
            }
        }

    }
}
