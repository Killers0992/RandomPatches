using HarmonyLib;
using Interactables.Interobjects;
using Interactables.Interobjects.DoorUtils;
using PlayableScps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RandomPatches.Patches
{
    [HarmonyPatch(typeof(Scp096), nameof(Scp096.ChargeDoor))]
    internal static class Scp096DestroyDoorPatch
    {
        private static bool Prefix(Scp096 __instance, DoorVariant door)
		{
			if (door.GetExactState() >= 1f)
			{
				return false;
			}
			IDamageableDoor damageableDoor;
			PryableDoor gate;
			if ((damageableDoor = (door as IDamageableDoor)) != null)
			{
				if (!damageableDoor.IsDestroyed && door.GetExactState() < 1f && __instance._lastChargedDamageableDoor != damageableDoor && MainClass.singleton.Cfg.Scp.canScp096destroyDoor)
				{
					damageableDoor.ServerDamage(250f, DoorDamageType.Scp096);
					__instance._lastChargedDamageableDoor = damageableDoor;
					return false;
				}
			}
			else if ((gate = (door as PryableDoor)) != null && door.GetExactState() == 0f && !door.TargetState)
			{
				__instance.Hub.fpc.NetworkmovementOverride = Vector2.zero;
				__instance._chargeCooldown = 0f;
				__instance.PryGate(gate);
			}
			return false;
        }
    }
}
