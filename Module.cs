using System;
using InnerSpaceAPI;
using LavishScriptAPI;
using System.Collections.Generic;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the module data type.
	/// </summary>
	public class Module : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Module object constructor.
		/// </summary>
		/// <param name="moduleSlot"></param>
		public Module(string moduleSlot)
			: base(LavishScript.Objects.GetObject("MyShip").GetMember("Module", moduleSlot))
		{
		}

		/// <summary>
		/// Module object copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public Module(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		public Int64 ID
		{
			get
			{
				LavishScriptObject id = GetMember("ID");
				if (LavishScriptObject.IsNullOrInvalid(id))
				{
					return -1;
				}
				else
				{
					return id.GetValue<Int64>();
				}
			}
		}

		/// <summary>
		/// Access the module as an item type.
		/// </summary>
		public Item ToItem
		{
			get
			{
				return new Item(GetMember("ToItem"));
			}
		}

		/// <summary>
		/// Returns the ShieldTransferRange member of a module object.
		/// </summary>
		public double ShieldTransferRange
		{
			get
			{
				LavishScriptObject shieldTransferRange = GetMember("ShieldTransferRange");
				if (LavishScriptObject.IsNullOrInvalid(shieldTransferRange))
				{
					return -1;
				}
				return shieldTransferRange.GetValue<double>();
			}
		}

		/// <summary>
		/// Returns the UsesFrequencyCrystals member of a module object.
		/// </summary>
		public bool UsesFrequencyCrystals
		{
			get
			{
				LavishScriptObject usesFrequencyCrystals = GetMember("UsesFrequencyCrystals");
				if (LavishScriptObject.IsNullOrInvalid(usesFrequencyCrystals))
				{
					return false;
				}
				return usesFrequencyCrystals.GetValue<bool>();
			}
		}

		/// <summary>
		/// Returns the IsGoingOnline member of a module object.
		/// </summary>
		public bool IsGoingOnline
		{
			get
			{
				return GetMember<bool>("IsGoingOnline");
			}
		}

		/// <summary>
		/// Returns the IsWaitingForActiveTarget member of a module object.
		/// </summary>
		public bool IsWaitingForActiveTarget
		{
			get
			{
				return GetMember<bool>("IsWaitingForActiveTarget");
			}
		}

		/// <summary>
		/// Is module online (as opposed to active)
		/// </summary>
		public bool IsOnline
		{
			get
			{
				return GetMember<bool>("IsOnline");
			}
		}

		/// <summary>
		/// Wrapper for the IsDeactivating member of a module object.
		/// </summary>
		public bool IsDeactivating
		{
			get
			{
				return GetMember<bool>("IsDeactivating");
			}
		}

		/// <summary>
		/// Wrapper for the IsActivatable member of a module object.
		/// </summary>
		public bool IsActivatable
		{
			get
			{
				return GetMember<bool>("IsActivatable");
			}
		}

		/// <summary>
		/// Wrapper for the IsAutoReloadOn member of a module object.
		/// </summary>
		public bool IsAutoReloadOn
		{
			get
			{
				return GetMember<bool>("IsAutoReloadOn");
			}
		}

		/// <summary>
		/// Wrapper for the GetAvailableAmmo member of a module object.
		/// </summary>
		public List<Item> GetAvailableAmmo()
		{
			return Util.GetListFromMember<Item>(this, "GetAvailableAmmo", "item");
		}


		/// <summary>
		/// Wrapper for the SpecialtyCrystalMiningAmount member of a module object.
		/// </summary>
		public double SpecialtyCrystalMiningAmount
		{
			get
			{
				LavishScriptObject specialtyCrystalMiningAmount = GetMember("SpecialtyCrystalMiningAmount");
				if (LavishScriptObject.IsNullOrInvalid(specialtyCrystalMiningAmount))
				{
					return -1;
				}
				return specialtyCrystalMiningAmount.GetValue<double>();
			}
		}

		/// <summary>
		/// Wrapper for the DefaultEffectName member of a module object.
		/// </summary>
		public string DefaultEffectName
		{
			get
			{
				return GetMember<string>("DefaultEffectName");
			}
		}

		/// <summary>
		/// Wrapper for the DefaultEffectDescription member of a module object.
		/// </summary>
		public string DefaultEffectDescription
		{
			get
			{
				return GetMember<string>("DefaultEffectDescription");
			}
		}

		/// <summary>
		/// This member returns the last target upon which the module was activated.
		/// </summary>
		public Entity LastTarget
		{
			get
			{
				return new Entity(GetMember("LastTarget"));
			}
		}

		/// <summary>
		/// Wrapper for the TargetID member of a module object.
		/// </summary>
		public Int64 TargetID
		{
			get
			{
				LavishScriptObject targetID = GetMember("TargetID");
				if (LavishScriptObject.IsNullOrInvalid(targetID))
				{
					return -1;
				}
				return targetID.GetValue<Int64>();
			}
		}
		#region Activatable
		/// <summary>
		/// TRUE when the module is active, including when the module is 
		/// flashing red in cooldown mode after being deactivated.
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public bool IsActive
		{
			get
			{
				LavishScriptObject isActive = GetMember("IsActive");
				if (LavishScriptObject.IsNullOrInvalid(isActive))
				{
					return false;
				}
				return isActive.GetValue<bool>();
			}
		}

		/// <summary>
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public bool IsOffensive
		{
			get
			{
				return GetMember<bool>("IsOffensive");
			}
		}

		/// <summary>
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public bool IsAssistance
		{
			get
			{
				return GetMember<bool>("IsAssistance");
			}
		}

		/// <summary>
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public int EffectCategory
		{
			get
			{
				return GetMember<int>("EffectCategory");
			}
		}
		#endregion

		#region Charges
		/// <summary>
		/// The charge type loaded into this module.
		/// </summary>
		public Item Charge
		{
			get
			{
				return new Item(GetMember("Charge"));
			}
		}

		/// <summary>
		/// Requires this.Charge.IsValid == true
		/// </summary>
		public int CurrentCharges
		{
			get
			{
				return GetMember<int>("CurrentCharges");
			}
		}

		/// <summary>
		/// Requires this.Charge.IsValid == true
		/// </summary>
		public int MaxCharges
		{
			get
			{
				LavishScriptObject maxCharges = GetMember("MaxCharges");
				if (LavishScriptObject.IsNullOrInvalid(maxCharges))
				{
					return -1;
				}
				return maxCharges.GetValue<int>();
			}
		}
		#endregion

		#region Properties
		/// <summary>
		/// Wrapper for the PowergridUsage member of a module object.
		/// </summary>
		public double? PowergridUsage
		{
			get
			{
				LavishScriptObject obj = GetMember("PowergridUsage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the OptimalRange member of a module object.
		/// </summary>
		public double? OptimalRange
		{
			get
			{
				LavishScriptObject obj = GetMember("OptimalRange");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the TechLevel member of a module object.
		/// </summary>
		public double? TechLevel
		{
			get
			{
				LavishScriptObject obj = GetMember("TechLevel");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ActivationCost member of a module object.
		/// </summary>
		public double? ActivationCost
		{
			get
			{
				LavishScriptObject obj = GetMember("ActivationCost");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Hitpoints
		/// </summary>
		public double? HP
		{
			get
			{
				LavishScriptObject obj = GetMember("HP");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Hit points damage.
		/// </summary>
		public double? Damage
		{
			get
			{
				LavishScriptObject obj = GetMember("Damage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ActivationTime member of a module object.
		/// </summary>
		public double? ActivationTime
		{
			get
			{
				LavishScriptObject obj = GetMember("ActivationTime");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Alias for ActivationTime.
		/// </summary>
		public double? Duration
		{
			get
			{
				LavishScriptObject obj = GetMember("Duration");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the Volume member of a module object.
		/// </summary>
		public double? Volume
		{
			get
			{
				LavishScriptObject obj = GetMember("Volume");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the AccessDifficultyBonus member of a module object.
		/// </summary>
		public double? AccessDifficultyBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("AccessDifficultyBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CPUUsage member of a module object.
		/// </summary>
		public double? CPUUsage
		{
			get
			{
				LavishScriptObject obj = GetMember("CPUUsage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the Capacity member of a module object.
		/// </summary>
		public double? Capacity
		{
			get
			{
				LavishScriptObject obj = GetMember("Capacity");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the MaxTractorVelocity member of a module object.
		/// </summary>
		public double? MaxTractorVelocity
		{
			get
			{
				LavishScriptObject obj = GetMember("MaxTractorVelocity");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the Mass member of a module object.
		/// </summary>
		public double? Mass
		{
			get
			{
				LavishScriptObject obj = GetMember("Mass");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the OverloadSpeedFactorBonus member of a module object.
		/// </summary>
		public double? OverloadSpeedFactorBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("OverloadSpeedFactorBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the MassAddition member of a module object.
		/// </summary>
		public double? MassAddition
		{
			get
			{
				LavishScriptObject obj = GetMember("MassAddition");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the HeatDamage member of a module object.
		/// </summary>
		public double? HeatDamage
		{
			get
			{
				LavishScriptObject obj = GetMember("HeatDamage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the Thrust member of a module object.
		/// </summary>
		public double? Thrust
		{
			get
			{
				LavishScriptObject obj = GetMember("Thrust");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the MaxVelocityBonus member of a module object.
		/// </summary>
		public double? MaxVelocityBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("MaxVelocityBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the MaxVelocityPenalty member of a module object.
		/// </summary>
		public double? MaxVelocityPenalty
		{
			get
			{
				LavishScriptObject obj = GetMember("MaxVelocityPenalty");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the StructureHPBonus member of a module object.
		/// </summary>
		public double? StructureHPBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("StructureHPBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CargoCapacityBonus member of a module object.
		/// </summary>
		public double? CargoCapacityBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("CargoCapacityBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return -1;
			}
		}

		/// <summary>
		/// Wrapper for the ShieldBonus member of a module object.
		/// </summary>
		public double? ShieldBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ShieldBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
				{
					return obj.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the ShieldBoostBonus member of a module object.
		/// </summary>
		public double? ShieldBoostBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ShieldBoostBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CapacitorRechargeRateBonus member of a module object.
		/// </summary>
		public double? CapacitorRechargeRateBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("CapacitorRechargeRateBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ShieldRechargeRateBonus member of a module object.
		/// </summary>
		public double? ShieldRechargeRateBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ShieldRechargeRateBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CapacitorBonus member of a module object.
		/// </summary>
		public double? CapacitorBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("CapacitorBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the PowergridBonus member of a module object.
		/// </summary>
		public double? PowergridBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("PowergridBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ShieldHPBonus member of a module object.
		/// </summary>
		public double? ShieldHPBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ShieldHPBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the VelocityModifier member of a module object.
		/// </summary>
		public double? VelocityModifier
		{
			get
			{
				LavishScriptObject obj = GetMember("VelocityModifier");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ChargeRate member of a module object.
		/// </summary>
		public double? ChargeRate
		{
			get
			{
				LavishScriptObject obj = GetMember("ChargeRate");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the RateOfFire member of a module object.
		/// </summary>
		public double? RateOfFire
		{
			get
			{
				LavishScriptObject obj = GetMember("RateOfFire");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the OverloadRateOfFireBonus member of a module object.
		/// </summary>
		public double? OverloadRateOfFireBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("OverloadRateOfFireBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the MiningAmount member of a module object.
		/// </summary>
		public double? MiningAmount
		{
			get
			{
				LavishScriptObject obj = GetMember("MiningAmount");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CrystalsDamage member of a module object.
		/// </summary>
		public double? CrystalsDamage
		{
			get
			{
				LavishScriptObject obj = GetMember("CrystalsDamage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the TargetGroup member of a module object.
		/// </summary>
		public int? TargetGroup
		{
			get
			{
				LavishScriptObject obj = GetMember("TargetGroup");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<int>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the SurveyScanRange member of a module object.
		/// </summary>
		public double? SurveyScanRange
		{
			get
			{
				LavishScriptObject obj = GetMember("SurveyScanRange");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CPUOutputBonus member of a module object.
		/// </summary>
		public double? CPUOutputBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("CPUOutputBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// This rounds to the nearest thousandth. 
		/// </summary>
		public double? TrackingSpeed
		{
			get
			{
				LavishScriptObject obj = GetMember("TrackingSpeed");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the DamageModifier member of a module object.
		/// </summary>
		public double? DamageModifier
		{
			get
			{
				LavishScriptObject obj = GetMember("DamageModifier");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the EMDamage member of a module object.
		/// </summary>
		public double? EMDamage
		{
			get
			{
				LavishScriptObject obj = GetMember("EMDamage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the KineticDamage member of a module object.
		/// </summary>
		public double? KineticDamage
		{
			get
			{
				LavishScriptObject obj = GetMember("KineticDamage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ThermalDamage member of a module object.
		/// </summary>
		public double? ThermalDamage
		{
			get
			{
				LavishScriptObject obj = GetMember("ThermalDamage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ExplosiveDamage member of a module object.
		/// </summary>
		public double? ExplosiveDamage
		{
			get
			{
				LavishScriptObject obj = GetMember("ExplosiveDamage");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ChargeSize member of a module object.
		/// </summary>
		public double? ChargeSize
		{
			get
			{
				LavishScriptObject obj = GetMember("ChargeSize");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the AccuracyFalloff member of a module object.
		/// </summary>
		public double? AccuracyFalloff
		{
			get
			{
				LavishScriptObject obj = GetMember("AccuracyFalloff");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the SignatureResolution member of a module object.
		/// </summary>
		public double? SignatureResolution
		{
			get
			{
				LavishScriptObject obj = GetMember("SignatureResolution");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the OverloadOptimalRangeBonus member of a module object.
		/// </summary>
		public double? OverloadOptimalRangeBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("OverloadOptimalRangeBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the OverloadRepairBonus member of a module object.
		/// </summary>
		public double? OverloadRepairBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("OverloadRepairBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the OverloadDurationBonus member of a module object.
		/// </summary>
		public double? OverloadDurationBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("OverloadDurationBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ArmorHPRepaired member of a module object.
		/// </summary>
		public double? ArmorHPRepaired
		{
			get
			{
				LavishScriptObject obj = GetMember("ArmorHPRepaired");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ExplosiveDmgResistanceBonus member of a module object.
		/// </summary>
		public double? ExplosiveDmgResistanceBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ExplosiveDmgResistanceBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the KineticDmgResistanceBonus member of a module object.
		/// </summary>
		public double? KineticDmgResistanceBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("KineticDmgResistanceBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ThermalDmgResistanceBonus member of a module object.
		/// </summary>
		public double? ThermalDmgResistanceBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ThermalDmgResistanceBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the EMDmgResistanceBonus member of a module object.
		/// </summary>
		public double? EMDmgResistanceBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("EMDmgResistanceBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the ArmorHPBonus member of a module object.
		/// </summary>
		public double? ArmorHPBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("ArmorHPBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the RateOfFireBonus member of a module object.
		/// </summary>
		public double? RateOfFireBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("RateOfFireBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the MiningAmountBonus member of a module object.
		/// </summary>
		public double? MiningAmountBonus
		{
			get
			{
				LavishScriptObject obj = GetMember("MiningAmountBonus");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the CPUPenaltyPercent member of a module object.
		/// </summary>
		public double? CPUPenaltyPercent
		{
			get
			{
				LavishScriptObject obj = GetMember("CPUPenaltyPercent");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}

		/// <summary>
		/// Wrapper for the WarpScrambleStrength member of a module object.
		/// </summary>
		public double? WarpScrambleStrength
		{
			get
			{
				LavishScriptObject obj = GetMember("WarpScrambleStrength");
				if (!LavishScriptObject.IsNullOrInvalid(obj))
					return obj.GetValue<double>();
				else
					return null;
			}
		}
		#endregion
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the Click method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Click()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.Click", string.Empty);
			return ExecuteMethod("Click");
		}

		/// <summary>
		/// Wrapper for the Activate method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Activate()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.Activate", string.Empty);
			return ExecuteMethod("Activate");
		}

		/// <summary>
		/// Wrapper for the Activate method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Activate(Int64 EntityID)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.Activate", EntityID.ToString());
			return ExecuteMethod("Activate", EntityID.ToString());
		}

		/// <summary>
		/// Wrapper for the Activate method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Deactivate()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.Deactivate", string.Empty);
			return ExecuteMethod("Deactivate");
		}

		/// <summary>
		/// Reload the module with the currently loaded charge type.
		/// NOTE: Does not work on empty modules.
		/// </summary>
		/// <returns></returns>
		public bool ChangeAmmo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.ChangeAmmo");
			return ExecuteMethod("ChangeAmmo");
		}

		/// <summary>
		/// Parameter is the Item.ID of an ammunition from your ship's cargo
		/// NOTE: This method will replace your current ammo with the ammo given 
		/// in the same quantity 
		/// </summary>
		public bool ChangeAmmo(Int64 AmmoID)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.ChangeAmmo", AmmoID.ToString());
			return ExecuteMethod("ChangeAmmo", AmmoID.ToString());
		}

		/// <summary>
		/// Parameter is the Item.ID of an ammunition from your ship's cargo
		/// NOTE: be careful, if you use a quantity that is too high for the module, 
		/// it'll fail entirely. See Module.MaxCharges
		/// </summary>
		public bool ChangeAmmo(Int64 AmmoID, int Quantity)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.ChangeAmmo", String.Format("{0},{1}", AmmoID, Quantity));
			return ExecuteMethod("ChangeAmmo", AmmoID.ToString(), Quantity.ToString());
		}

		/// <summary>
		/// Wrapper for the SetAutoReloadOn method of a module object
		/// </summary>
		/// <returns></returns>
		public bool SetAutoReloadOn()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.SetAutoReloadOn", string.Empty);
			return ExecuteMethod("SetAutoReloadOn");
		}

		/// <summary>
		/// Wrapper for the SetAutoReloadOff method of a module object
		/// </summary>
		/// <returns></returns>
		public bool SetAutoReloadOff()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.SetAutoReloadOff", string.Empty);
			return ExecuteMethod("SetAutoReloadOff");
		}

		/// <summary>
		/// Wrapper for the PutOnline method of a module object
		/// </summary>
		/// <returns></returns>
		public bool PutOnline()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.PutOnline", string.Empty);
			return ExecuteMethod("PutOnline");
		}

		/// <summary>
		/// Wrapper for the PutOffline method of a module object
		/// </summary>
		/// <returns></returns>
		public bool PutOffline()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Module.PutOffline", string.Empty);
			return ExecuteMethod("PutOffline");
		}
		#endregion
	}
}
