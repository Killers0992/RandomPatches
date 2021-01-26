# RandomPatches


# Global/Role means that option can be for everyone or role based.

WorkStation:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canActivateWorkstation   | true | yes |
| canDeactivateWorkstation | true | yes |

Warhead:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canChangeLeverStatus   | true | yes |
| canBeEnabled | true | yes |
| canBeDisabled | true | yes |

Generator:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canCloseGenerator   | true | yes |
| canOpenGenerator | true | yes |
| canInsertTablet | true | yes |
| canRemoveTablet | true | yes |
| canUnlockGenerator | true | yes |
| remainingPowerup | 70f | no |

Item:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canDropAnyItem   | true | yes |
| canPickupAnyItem | true | yes |

MedicalItem:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canUseMedicalItem   | true | yes |
| canCancelUsingMedicalItem | true | yes |

PocketDimension:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canEnterPocketDimension   | true | yes |
| canExitPocketDimension | true | yes |
| alwaysExitPocketDimension | false | yes |

Weapon:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canReloadWeapon   | true | yes |
| canShotWeapon | true | yes |
| canChangeAttachments | true | no |
| canChangeDurability | true | no |

Tesla:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canActivateTesla   | true | yes |
| triggerRange | 5.5f | no |

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
