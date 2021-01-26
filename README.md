# RandomPatches


# Global/Role means that option can be for everyone or role based.

WorkStation:
- canActivateWorkstation ( GLOBAL/ROLE )
- canDeactivateWorkstation ( GLOBAL/ROLE )

Warhead:
- canChangeLeverStatus ( GLOBAL/ROLE )
- canBeEnabled ( GLOBAL/ROLE )
- canBeDisabled ( GLOBAL/ROLE )

Generator:
- canCloseGenerator ( GLOBAL/ROLE )
- canOpenGenerator ( GLOBAL/ROLE )
- canInsertTablet ( GLOBAL/ROLE )
- canRemoveTablet ( GLOBAL/ROLE )
- canUnlockGenerator ( GLOBAL/ROLE )
- remainingPowerup

Item:
- canDropAnyItem ( GLOBAL/ROLE )
- canPickupAnyItem ( GLOBAL/ROLE )

MedicalItem:
- canUseMedicalItem ( GLOBAL/ROLE )
- canCancelUsingMedicalItem ( GLOBAL/ROLE )

PocketDimension:
- canEnterPocketDimension ( GLOBAL/ROLE )
- canExitPocketDimension ( GLOBAL/ROLE )
- alwaysExitPocketDimension ( GLOBAL/ROLE )

Weapon:
- canReloadWeapon ( GLOBAL/ROLE )
- canShotWeapon ( GLOBAL/ROLE )
- canChangeAttachments
- canChangeDurability

Tesla:
- canActivateTesla ( GLOBAL/ROLE )
- triggerRange

Grenade:
- canThrowGrenade ( GLOBAL/ROLE )
- canThrowFlashGrenade ( GLOBAL/ROLE )
- canGrenadeExplode
- canFlashGrenadeExplode
- canGrenadeDealDamage ( GLOBAL/ROLE )

Elevator:
- canCallElevator ( GLOBAL/ROLE )

Ragdoll:
- canCreateRagdoll ( GLOBAL/ROLE )

Decontamination:
- canAnnounce
- canStartDecontaminationProcedure

Window:
- canBeDamaged
- damageMultiplier

SCP:
- announceTermination ( GLOBAL/ROLE )
- canScp049StartRecalling
#
- canScp079ChangeCamera
- canScp079useElevatorTeleport
- canScp079useTesla
- canScp079useDoor
- canScp079useSpeaker
- canScp079gainLevel
- canScp079gainExperience
- scp079experienceMultiplier
#
- canScp096calmDown
- canScp096startEnrage
- canScp096pryGate
#
- canScp106createPortal
- canScp106usePortal
- canScp106getContained
#
- canScp173blink

SCP914:
- canBeActivated ( GLOBAL/ROLE )
- canChangeKnob ( GLOBAL/ROLE )
