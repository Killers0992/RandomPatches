# RandomPatches -
That plugin allows to change doors keycard permissions or who can throw grenades and more !!!


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
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canThrowGrenade   | true | yes |
| canThrowFlashGrenade | true | yes |
| canGrenadeExplode | true | no |
| canFlashGrenadeExplode | true | no |
| canGrenadeDealDamage | true | yes |

Elevator:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canCallElevator   | true | yes |

Ragdoll:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canCreateRagdoll   | true | yes |

Decontamination:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canAnnounce   | true | no |
| canStartDecontaminationProcedure   | true | no |

Window:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canBeDamaged   | true | no |
| damageMultiplier   | 0 | no |

SCP:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| announceTermination   | true | yes |
| canScp049StartRecalling   | true | no |
| canScp079ChangeCamera   | true | no |
| canScp079useElevatorTeleport   | true | no |
| canScp079useTesla   | true | no |
| canScp079useDoor   | true | no |
| canScp079useSpeaker   | true | no |
| canScp079gainLevel   | true | no |
| canScp079gainExperience   | true | no |
| scp079experienceMultiplier   | 0 | no |
| canScp096calmDown   | true | no |
| canScp096startEnrage   | true | no |
| canScp096pryGate   | true | no |
| canScp106createPortal   | true | no |
| canScp106usePortal   | true | no |
| canScp106getContained   | true | no |
| canScp173blink   | true | no |

SCP914:
| Type | Default Value | Is global/role |
| --- | :---: | :---: |
| canBeActivated   | true | yes |
| canChangeKnob   | true | yes |

Checkpoint & Doors:

Seperate keycard permissions by comma example:
``
keycard_permission: AlphaWarhead, ContainmentLevelThree
``

Seperate ignore damage type by comma example:
``
ignore_damage_type: Grenade, Weapon
``

| Keycard Permission Name |
| --- |
| None |
| Checkpoints |
| ExitGates |
| Intercom |
| AlphaWarhead |
| ContainmentLevelOne |
| ContainmentLevelTwo |
| ContainmentLevelThree |
| ArmoryLevelOne |
| ArmoryLevelTwo |
| ArmoryLevelThree |
| ScpOverride |

| Damage Type Name |
| --- |
| None |
| ServerCommand |
| Grenade |
| Weapon |
| Scp096 |
