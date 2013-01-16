using System;
using Extensions;
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

		private Int64? _id;
		public Int64 ID
		{
			get
			{
				if (_id == null)
					_id = this.GetInt64FromLSO("ID");
				return _id.Value;
			}
		}

		private Item _toItem;
		/// <summary>
		/// Access the module as an item type.
		/// </summary>
		public Item ToItem
		{
			get
			{
				return _toItem ?? (_toItem = new Item(GetMember("ToItem")));
			}
		}

		private double? _shieldTransferRange;
		/// <summary>
		/// Returns the ShieldTransferRange member of a module object.
		/// </summary>
		public double ShieldTransferRange
		{
			get
			{
				if (_shieldTransferRange == null)
					_shieldTransferRange = this.GetDoubleFromLSO("ShieldTransferRange");
				return _shieldTransferRange.Value;
			}
		}

		private bool? _usesFrequencyCrystals;
		/// <summary>
		/// Returns the UsesFrequencyCrystals member of a module object.
		/// </summary>
		public bool UsesFrequencyCrystals
		{
			get
			{
				if (_usesFrequencyCrystals == null)
					_usesFrequencyCrystals = this.GetBoolFromLSO("UsesFrequencyCrystals");
				return _usesFrequencyCrystals.Value;
			}
		}

		private bool? _isGoingOnline;
		/// <summary>
		/// Returns the IsGoingOnline member of a module object.
		/// </summary>
		public bool IsGoingOnline
		{
			get
			{
				if (_isGoingOnline == null)
					_isGoingOnline = this.GetBoolFromLSO("IsGoingOnline");
				return _isGoingOnline.Value;
			}
		}

		private bool? _isWaitingForActiveTarget;
		/// <summary>
		/// Returns the IsWaitingForActiveTarget member of a module object.
		/// </summary>
		public bool IsWaitingForActiveTarget
		{
			get
			{
				if (_isWaitingForActiveTarget == null)
					_isWaitingForActiveTarget = this.GetBoolFromLSO("IsWaitingForActiveTarget");
				return _isWaitingForActiveTarget.Value;
			}
		}

		private bool? _isChangingAmmo;
		/// <summary>
		/// Wrapper for the IsWaitingForActiveTarget member of a module object.
		/// </summary>
		public bool IsChangingAmmo
		{
			get
			{
				if (_isChangingAmmo == null)
					_isChangingAmmo = this.GetBoolFromLSO("IsChangingAmmo");
				return _isChangingAmmo.Value;
			}
		}

		private bool? _isReloadingAmmo;
		/// <summary>
		/// Wrapper for the IsReloadingAmmo member of a module object.
		/// </summary>
		public bool IsReloadingAmmo
		{
			get
			{
				if (_isReloadingAmmo == null)
					_isReloadingAmmo = this.GetBoolFromLSO("IsReloadingAmmo");
				return _isReloadingAmmo.Value;
			}
		}

		private bool? _isOnline;
		/// <summary>
		/// Is module online (as opposed to active)
		/// </summary>
		public bool IsOnline
		{
			get
			{
				if (_isOnline == null)
					_isOnline = this.GetBoolFromLSO("IsOnline");
				return _isOnline.Value;
			}
		}

		private bool? _isDeactivating;
		/// <summary>
		/// Wrapper for the IsDeactivating member of a module object.
		/// </summary>
		public bool IsDeactivating
		{
			get
			{
				if (_isDeactivating == null)
					_isDeactivating = this.GetBoolFromLSO("IsDeactivating");
				return _isDeactivating.Value;
			}
		}

		private bool? _isActivatable;
		/// <summary>
		/// Wrapper for the IsActivatable member of a module object.
		/// </summary>
		public bool IsActivatable
		{
			get
			{
				if (_isActivatable == null)
					_isActivatable = this.GetBoolFromLSO("IsActivatabe");
				return _isActivatable.Value;
			}
		}

		private bool? _isAutoReloadOn;
		/// <summary>
		/// Wrapper for the IsAutoReloadOn member of a module object.
		/// </summary>
		public bool IsAutoReloadOn
		{
			get
			{
				if (_isAutoReloadOn == null)
					_isAutoReloadOn = this.GetBoolFromLSO("IsAutoReloadOn");
				return _isAutoReloadOn.Value;
			}
		}

		private List<Item> _availableAmmo;
		/// <summary>
		/// Wrapper for the GetAvailableAmmo member of a module object.
		/// </summary>
		public List<Item> GetAvailableAmmo()
		{
			Tracing.SendCallback("Module.GetAvailableAmmo");
			return _availableAmmo ?? (_availableAmmo = Util.GetListFromMethod<Item>(this, "GetAvailableAmmo", "item"));
		}

		private double? _specialtyCrystalMiningAmount;
		/// <summary>
		/// Wrapper for the SpecialtyCrystalMiningAmount member of a module object.
		/// </summary>
		public double SpecialtyCrystalMiningAmount
		{
			get
			{
				if (_specialtyCrystalMiningAmount == null)
					_specialtyCrystalMiningAmount = this.GetDoubleFromLSO("SpecialtyCrystalMiningAmount");
				return _specialtyCrystalMiningAmount.Value;
			}
		}

		private string _defaultEffectName;
		/// <summary>
		/// Wrapper for the DefaultEffectName member of a module object.
		/// </summary>
		public string DefaultEffectName
		{
			get
			{
				return _defaultEffectName ?? (_defaultEffectName = this.GetStringFromLSO("DefaultEffectiveName"));
			}
		}

		private string _defaultEffectDescription;
		/// <summary>
		/// Wrapper for the DefaultEffectDescription member of a module object.
		/// </summary>
		public string DefaultEffectDescription
		{
			get { return _defaultEffectDescription ?? (_defaultEffectDescription = this.GetStringFromLSO("DefaultEffectiveDescription")); }
		}

		private Entity _lastTarget;
		/// <summary>
		/// This member returns the last target upon which the module was activated.
		/// </summary>
		public Entity LastTarget
		{
			get { return _lastTarget ?? (_lastTarget = new Entity(GetMember("LastTarget"))); }
		}

		private Entity _target;
		/// <summary>
		/// This member returns the last target upon which the module was activated.
		/// </summary>
		public Entity Target
		{
			get { return _target ?? (_target = new Entity(GetMember("Target"))); }
		}

		private Int64? _targetId;
		/// <summary>
		/// Wrapper for the TargetID member of a module object.
		/// </summary>
		public Int64 TargetID
		{
			get
			{
				Tracing.SendCallback("TargetID");
				if (_targetId == null)
					_targetId = this.GetInt64FromLSO("TargetID");
				return _targetId.Value;
			}
		}

		#region Activatable

		private bool? _isActive;
		/// <summary>
		/// TRUE when the module is active, including when the module is 
		/// flashing red in cooldown mode after being deactivated.
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public bool IsActive
		{
			get
			{
				if (_isActive == null)
					_isActive = this.GetBoolFromLSO("IsActive");
				return _isActive.Value;
			}
		}

		private bool? _isOffensive;
		/// <summary>
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public bool IsOffensive
		{
			get
			{
				if (_isOffensive == null)
					_isOffensive = this.GetBoolFromLSO("IsOffensive");
				return _isOffensive.Value;
			}
		}

		private bool? _isAssistance;
		/// <summary>
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public bool IsAssistance
		{
			get
			{
				if (_isAssistance == null)
					_isAssistance = this.GetBoolFromLSO("IsAssistance");
				return _isAssistance.Value;
			}
		}

		private int? _effectCategory;
		/// <summary>
		/// Note: Require Module.IsActivatable == TRUE
		/// </summary>
		public int EffectCategory
		{
			get
			{
				if (_effectCategory == null)
					_effectCategory = this.GetIntFromLSO("EffectCategory");
				return _effectCategory.Value;
			}
		}
		#endregion

		#region Charges

		private ModuleCharge _charge;
		/// <summary>
		/// The charge type loaded into this module.
		/// </summary>
		public ModuleCharge Charge
		{
			get { return _charge ?? (_charge = new ModuleCharge(GetMember("Charge"))); }
		}

		private int? _currentCharges;
		/// <summary>
		/// Requires this.Charge.IsValid == true
		/// </summary>
		public int CurrentCharges
		{
			get
			{
				if (_currentCharges == null)
					_currentCharges = this.GetIntFromLSO("CurrentCharges");
				return _currentCharges.Value;
			}
		}

		private int? _maxCharges;
		/// <summary>
		/// Requires this.Charge.IsValid == true
		/// </summary>
		public int MaxCharges
		{
			get
			{
				if (_maxCharges == null)
					_maxCharges = this.GetIntFromLSO("MaxCharges");
				return _maxCharges.Value;
			}
		}
		#endregion

		#region Properties

		/// <summary>
		/// Wrapper for the PowergridUsage member of a module object.
		/// </summary>
		public double? PowergridUsage
		{
			get { return this.GetNullableDoubleFromLSO("PowergridUsage"); }
		}

		/// <summary>
		/// Wrapper for the OptimalRange member of a module object.
		/// </summary>
		public double? OptimalRange
		{
			get { return this.GetNullableDoubleFromLSO("OptimalRange"); }
		}

		/// <summary>
		/// Wrapper for the TechLevel member of a module object.
		/// </summary>
		public double? TechLevel
		{
			get { return this.GetNullableDoubleFromLSO("TechLevel"); }
		}

		/// <summary>
		/// Wrapper for the ActivationCost member of a module object.
		/// </summary>
		public double? ActivationCost
		{
			get { return this.GetNullableDoubleFromLSO("ActivationCost"); }
		}

		/// <summary>
		/// Hitpoints
		/// </summary>
		public double? HP
		{
			get { return this.GetNullableDoubleFromLSO("HP"); }
		}

		/// <summary>
		/// Hit points damage.
		/// </summary>
		public double? Damage
		{
			get { return this.GetNullableDoubleFromLSO("Damage"); }
		}

		/// <summary>
		/// Wrapper for the ActivationTime member of a module object.
		/// </summary>
		public double? ActivationTime
		{
			get { return this.GetNullableDoubleFromLSO("ActivationTime"); }
		}

		/// <summary>
		/// Alias for ActivationTime.
		/// </summary>
		public double? Duration
		{
			get { return this.GetNullableDoubleFromLSO("Duration"); }
		}

		/// <summary>
		/// Wrapper for the Volume member of a module object.
		/// </summary>
		public double? Volume
		{
			get { return this.GetNullableDoubleFromLSO("Volume"); }
		}

		/// <summary>
		/// Wrapper for the AccessDifficultyBonus member of a module object.
		/// </summary>
		public double? AccessDifficultyBonus
		{
			get { return this.GetNullableDoubleFromLSO("AccessDifficultyBonus"); }
		}

		/// <summary>
		/// Wrapper for the CPUUsage member of a module object.
		/// </summary>
		public double? CPUUsage
		{
			get { return this.GetNullableDoubleFromLSO("CPUUsage"); }
		}

		/// <summary>
		/// Wrapper for the Capacity member of a module object.
		/// </summary>
		public double? Capacity
		{
			get { return this.GetNullableDoubleFromLSO("Capacity"); }
		}

		/// <summary>
		/// Wrapper for the MaxTractorVelocity member of a module object.
		/// </summary>
		public double? MaxTractorVelocity
		{
			get { return this.GetNullableDoubleFromLSO("MaxTractorVelocity"); }
		}

		/// <summary>
		/// Wrapper for the Mass member of a module object.
		/// </summary>
		public double? Mass
		{
			get { return this.GetNullableDoubleFromLSO("Mass"); }
		}

		/// <summary>
		/// Wrapper for the OverloadSpeedFactorBonus member of a module object.
		/// </summary>
		public double? OverloadSpeedFactorBonus
		{
			get { return this.GetNullableDoubleFromLSO("OverloadSpeedFactorBonus"); }
		}

		/// <summary>
		/// Wrapper for the MassAddition member of a module object.
		/// </summary>
		public double? MassAddition
		{
			get
			{
				return this.GetNullableDoubleFromLSO("MassAddition");
			}
		}

		/// <summary>
		/// Wrapper for the HeatDamage member of a module object.
		/// </summary>
		public double? HeatDamage
		{
			get { return this.GetNullableDoubleFromLSO("HeatDamage"); }
		}

		/// <summary>
		/// Wrapper for the Thrust member of a module object.
		/// </summary>
		public double? Thrust
		{
			get { return this.GetNullableDoubleFromLSO("Thrust"); }
		}

		/// <summary>
		/// Wrapper for the MaxVelocityBonus member of a module object.
		/// </summary>
		public double? MaxVelocityBonus
		{
			get { return this.GetNullableDoubleFromLSO("MaxVelocityBonus"); }
		}

		/// <summary>
		/// Wrapper for the MaxVelocityPenalty member of a module object.
		/// </summary>
		public double? MaxVelocityPenalty
		{
			get { return this.GetNullableDoubleFromLSO("MaxVelocityPenalty"); }
		}

		/// <summary>
		/// Wrapper for the StructureHPBonus member of a module object.
		/// </summary>
		public double? StructureHPBonus
		{
			get { return this.GetNullableDoubleFromLSO("StructureHPBonus"); }
		}

		/// <summary>
		/// Wrapper for the CargoCapacityBonus member of a module object.
		/// </summary>
		public double? CargoCapacityBonus
		{
			get { return this.GetNullableDoubleFromLSO("CargoCapacityBonus"); }
		}

		/// <summary>
		/// Wrapper for the ShieldBonus member of a module object.
		/// </summary>
		public double? ShieldBonus
		{
			get { return this.GetNullableDoubleFromLSO("ShieldBonus"); }
		}

		/// <summary>
		/// Wrapper for the ShieldBoostBonus member of a module object.
		/// </summary>
		public double? ShieldBoostBonus
		{
			get { return this.GetNullableDoubleFromLSO("ShieldBoostBonus"); }
		}

		/// <summary>
		/// Wrapper for the CapacitorRechargeRateBonus member of a module object.
		/// </summary>
		public double? CapacitorRechargeRateBonus
		{
			get { return this.GetNullableDoubleFromLSO("CapacitorRechargeRateBonus"); }
		}

		/// <summary>
		/// Wrapper for the ShieldRechargeRateBonus member of a module object.
		/// </summary>
		public double? ShieldRechargeRateBonus
		{
			get { return this.GetNullableDoubleFromLSO("ShieldRechargeRateBonus"); }
		}

		/// <summary>
		/// Wrapper for the CapacitorBonus member of a module object.
		/// </summary>
		public double? CapacitorBonus
		{
			get { return this.GetNullableDoubleFromLSO("CapacitorBonus"); }
		}

		/// <summary>
		/// Wrapper for the PowergridBonus member of a module object.
		/// </summary>
		public double? PowergridBonus
		{
			get { return this.GetNullableDoubleFromLSO("PowergridBonus"); }
		}

		/// <summary>
		/// Wrapper for the ShieldHPBonus member of a module object.
		/// </summary>
		public double? ShieldHPBonus
		{
			get { return this.GetNullableDoubleFromLSO("ShieldHPBonus"); }
		}

		/// <summary>
		/// Wrapper for the VelocityModifier member of a module object.
		/// </summary>
		public double? VelocityModifier
		{
			get { return this.GetNullableDoubleFromLSO("VelocityModifier"); }
		}

		/// <summary>
		/// Wrapper for the ChargeRate member of a module object.
		/// </summary>
		public double? ChargeRate
		{
			get { return this.GetNullableDoubleFromLSO("ChargeRate"); }
		}

		/// <summary>
		/// Wrapper for the RateOfFire member of a module object.
		/// </summary>
		public double? RateOfFire
		{
			get { return this.GetNullableDoubleFromLSO("RateOfFire"); }
		}

		/// <summary>
		/// Wrapper for the OverloadRateOfFireBonus member of a module object.
		/// </summary>
		public double? OverloadRateOfFireBonus
		{
			get { return this.GetNullableDoubleFromLSO("OverloadRateOfFireBonus"); }
		}

		/// <summary>
		/// Wrapper for the MiningAmount member of a module object.
		/// </summary>
		public double? MiningAmount
		{
			get { return this.GetNullableDoubleFromLSO("MiningAmount"); }
		}

		/// <summary>
		/// Wrapper for the CrystalsDamage member of a module object.
		/// </summary>
		public double? CrystalsDamage
		{
			get { return this.GetNullableDoubleFromLSO("CrystalsDamage"); }
		}

		/// <summary>
		/// Wrapper for the TargetGroup member of a module object.
		/// </summary>
		public int? TargetGroup
		{
			get { return this.GetNullableIntFromLSO("TargetGroup"); }
		}

		/// <summary>
		/// Wrapper for the SurveyScanRange member of a module object.
		/// </summary>
		public double? SurveyScanRange
		{
			get { return this.GetNullableDoubleFromLSO("SurveyScanRange"); }
		}

		/// <summary>
		/// Wrapper for the CPUOutputBonus member of a module object.
		/// </summary>
		public double? CPUOutputBonus
		{
			get { return this.GetNullableDoubleFromLSO("CPUOutputBonus"); }
		}

		/// <summary>
		/// This rounds to the nearest thousandth. 
		/// </summary>
		public double? TrackingSpeed
		{
			get { return this.GetNullableDoubleFromLSO("TrackingSpeed"); }
		}

		/// <summary>
		/// Wrapper for the DamageModifier member of a module object.
		/// </summary>
		public double? DamageModifier
		{
			get { return this.GetNullableDoubleFromLSO("DamageModifier"); }
		}

		/// <summary>
		/// Wrapper for the EMDamage member of a module object.
		/// </summary>
		public double? EMDamage
		{
			get { return this.GetNullableDoubleFromLSO("EMDamage"); }
		}

		/// <summary>
		/// Wrapper for the KineticDamage member of a module object.
		/// </summary>
		public double? KineticDamage
		{
			get { return this.GetNullableDoubleFromLSO("KineticDamage"); }
		}

		/// <summary>
		/// Wrapper for the ThermalDamage member of a module object.
		/// </summary>
		public double? ThermalDamage
		{
			get { return this.GetNullableDoubleFromLSO("ThermalDamage"); }
		}

		/// <summary>
		/// Wrapper for the ExplosiveDamage member of a module object.
		/// </summary>
		public double? ExplosiveDamage
		{
			get { return this.GetNullableDoubleFromLSO("ExplosiveDamage"); }
		}

		/// <summary>
		/// Wrapper for the ChargeSize member of a module object.
		/// </summary>
		public double? ChargeSize
		{
			get { return this.GetNullableDoubleFromLSO("ChargeSize"); }
		}

		/// <summary>
		/// Wrapper for the AccuracyFalloff member of a module object.
		/// </summary>
		public double? AccuracyFalloff
		{
			get { return this.GetNullableDoubleFromLSO("AccuracyFalloff"); }
		}

		/// <summary>
		/// Wrapper for the SignatureResolution member of a module object.
		/// </summary>
		public double? SignatureResolution
		{
			get { return this.GetNullableDoubleFromLSO("SignatureResolution"); }
		}

		/// <summary>
		/// Wrapper for the OverloadOptimalRangeBonus member of a module object.
		/// </summary>
		public double? OverloadOptimalRangeBonus
		{
			get { return this.GetNullableDoubleFromLSO("OverloadOptimalRangeBonus"); }
		}

		/// <summary>
		/// Wrapper for the OverloadRepairBonus member of a module object.
		/// </summary>
		public double? OverloadRepairBonus
		{
			get { return this.GetDoubleFromLSO("OverloadRepairBonus"); }
		}

		/// <summary>
		/// Wrapper for the OverloadDurationBonus member of a module object.
		/// </summary>
		public double? OverloadDurationBonus
		{
			get { return this.GetDoubleFromLSO("OverloadDurationBonus"); }
		}

		/// <summary>
		/// Wrapper for the ArmorHPRepaired member of a module object.
		/// </summary>
		public double? ArmorHPRepaired
		{
			get { return this.GetNullableDoubleFromLSO("ArmorHPRepaired"); }
		}

		/// <summary>
		/// Wrapper for the ExplosiveDmgResistanceBonus member of a module object.
		/// </summary>
		public double? ExplosiveDmgResistanceBonus
		{
			get { return this.GetNullableDoubleFromLSO("ExplosiveDmgResistanceBonus"); }
		}

		/// <summary>
		/// Wrapper for the KineticDmgResistanceBonus member of a module object.
		/// </summary>
		public double? KineticDmgResistanceBonus
		{
			get { return this.GetNullableDoubleFromLSO("KineticDmgResistanceBonus"); }
		}

		/// <summary>
		/// Wrapper for the ThermalDmgResistanceBonus member of a module object.
		/// </summary>
		public double? ThermalDmgResistanceBonus
		{
			get { return this.GetNullableDoubleFromLSO("ThermalDmgResistanceBonus"); }
		}

		/// <summary>
		/// Wrapper for the EMDmgResistanceBonus member of a module object.
		/// </summary>
		public double? EMDmgResistanceBonus
		{
			get { return this.GetNullableDoubleFromLSO("EMDmgResistanceBonus"); }
		}

		/// <summary>
		/// Wrapper for the ArmorHPBonus member of a module object.
		/// </summary>
		public double? ArmorHPBonus
		{
			get { return this.GetNullableDoubleFromLSO("ArmorHPBonus"); }
		}

		/// <summary>
		/// Wrapper for the RateOfFireBonus member of a module object.
		/// </summary>
		public double? RateOfFireBonus
		{
			get { return this.GetNullableDoubleFromLSO("RateOfFireBonus"); }
		}

		/// <summary>
		/// Wrapper for the MiningAmountBonus member of a module object.
		/// </summary>
		public double? MiningAmountBonus
		{
			get { return this.GetNullableDoubleFromLSO("MiningAmountBonus"); }
		}

		/// <summary>
		/// Wrapper for the CPUPenaltyPercent member of a module object.
		/// </summary>
		public double? CPUPenaltyPercent
		{
			get { return this.GetNullableDoubleFromLSO("CPUPenaltyPercent"); }
		}

		/// <summary>
		/// Wrapper for the WarpScrambleStrength member of a module object.
		/// </summary>
		public double? WarpScrambleStrength
		{
			get { return this.GetNullableDoubleFromLSO("WarpScrambleStrength"); }
		}

		/// <summary>
		/// Wrapper for Module.EnergyTransferAmount
		/// </summary>
		public double? EnergyTransferAmount
		{
			get { return this.GetNullableDoubleFromLSO("EnergyTransferAmount"); }
		}

		/// <summary>
		/// Wrapper for Module.TransferRange
		/// </summary>
		public double? TransferRange
		{
			get { return this.GetNullableDoubleFromLSO("TransferRange"); }
		}

		/// <summary>
		/// Wrapper for Module.MaxNeutralizationRange
		/// </summary>
		public double? MaxNeutralizationRange
		{
			get { return this.GetNullableDoubleFromLSO("MaxNeutralizationRange"); }
		}

		/// <summary>
		/// Wrapper for Module.MaxNeutralizationRange
		/// </summary>
		public double? EnergyNeutralized
		{
			get { return this.GetNullableDoubleFromLSO("EnergyNeutralized"); }
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
			Tracing.SendCallback("Module.Click");
			return ExecuteMethod("Click");
		}

		/// <summary>
		/// Wrapper for the Activate method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Activate()
		{
			Tracing.SendCallback("Module.Activate");
			return ExecuteMethod("Activate");
		}

		/// <summary>
		/// Wrapper for the Activate method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Activate(Int64 EntityID)
		{
			Tracing.SendCallback("Module.Activate", EntityID.ToString());
			return ExecuteMethod("Activate", EntityID.ToString());
		}

		/// <summary>
		/// Wrapper for the Activate method of a module object
		/// </summary>
		/// <returns></returns>
		public bool Deactivate()
		{
			Tracing.SendCallback("Module.Deactivate", string.Empty);
			return ExecuteMethod("Deactivate");
		}

		/// <summary>
		/// Parameter is the Item.ID of an ammunition from your ship's cargo
		/// NOTE: This method will replace your current ammo with the ammo given 
		/// in the same quantity 
		/// </summary>
		public bool ChangeAmmo(Int64 AmmoID)
		{
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
			Tracing.SendCallback("Module.ChangeAmmo", AmmoID, Quantity);
			return ExecuteMethod("ChangeAmmo", AmmoID.ToString(), Quantity.ToString());
		}

		/// <summary>
		/// Wrapper for the SetAutoReloadOn method of a module object
		/// </summary>
		/// <returns></returns>
		public bool SetAutoReloadOn()
		{
			Tracing.SendCallback("Module.SetAutoReloadOn");
			return ExecuteMethod("SetAutoReloadOn");
		}

		/// <summary>
		/// Wrapper for the SetAutoReloadOff method of a module object
		/// </summary>
		/// <returns></returns>
		public bool SetAutoReloadOff()
		{
			Tracing.SendCallback("Module.SetAutoReloadOff");
			return ExecuteMethod("SetAutoReloadOff");
		}

		/// <summary>
		/// Wrapper for the PutOnline method of a module object
		/// </summary>
		/// <returns></returns>
		public bool PutOnline()
		{
			Tracing.SendCallback("Module.PutOnline");
			return ExecuteMethod("PutOnline");
		}

		/// <summary>
		/// Wrapper for the PutOffline method of a module object
		/// </summary>
		/// <returns></returns>
		public bool PutOffline()
		{
			Tracing.SendCallback("Module.PutOffline");
			return ExecuteMethod("PutOffline");
		}
		#endregion
	}
}
