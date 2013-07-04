using System;
using System.Collections.Generic;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    /// <summary>
    /// Represents a ship module.
    /// </summary>
    public interface IModule : ILSObject
    {
        /// <summary>
        /// ID of the module.
        /// </summary>
        Int64 ID { get; }

        /// <summary>
        /// Access the module as an item type.
        /// </summary>
        Item ToItem { get; }

        /// <summary>
        /// Returns the ShieldTransferRange member of a module object.
        /// </summary>
        double ShieldTransferRange { get; }

        /// <summary>
        /// Returns the UsesFrequencyCrystals member of a module object.
        /// </summary>
        bool UsesFrequencyCrystals { get; }

        /// <summary>
        /// Returns the IsGoingOnline member of a module object.
        /// </summary>
        bool IsGoingOnline { get; }

        /// <summary>
        /// Returns the IsWaitingForActiveTarget member of a module object.
        /// </summary>
        bool IsWaitingForActiveTarget { get; }

        /// <summary>
        /// Wrapper for the IsWaitingForActiveTarget member of a module object.
        /// </summary>
        bool IsChangingAmmo { get; }

        /// <summary>
        /// Wrapper for the IsReloadingAmmo member of a module object.
        /// </summary>
        bool IsReloadingAmmo { get; }

        /// <summary>
        /// Is module online (as opposed to active)
        /// </summary>
        bool IsOnline { get; }

        /// <summary>
        /// Wrapper for the IsDeactivating member of a module object.
        /// </summary>
        bool IsDeactivating { get; }

        /// <summary>
        /// Wrapper for the IsActivatable member of a module object.
        /// </summary>
        bool IsActivatable { get; }

        /// <summary>
        /// Wrapper for the IsAutoReloadOn member of a module object.
        /// </summary>
        bool IsAutoReloadOn { get; }

        /// <summary>
        /// Wrapper for the SpecialtyCrystalMiningAmount member of a module object.
        /// </summary>
        double SpecialtyCrystalMiningAmount { get; }

        /// <summary>
        /// Wrapper for the DefaultEffectName member of a module object.
        /// </summary>
        string DefaultEffectName { get; }

        /// <summary>
        /// Wrapper for the DefaultEffectDescription member of a module object.
        /// </summary>
        string DefaultEffectDescription { get; }

        /// <summary>
        /// This member returns the last target upon which the module was activated.
        /// </summary>
        Entity LastTarget { get; }

        /// <summary>
        /// This member returns the last target upon which the module was activated.
        /// </summary>
        Entity Target { get; }

        /// <summary>
        /// Wrapper for the TargetID member of a module object.
        /// </summary>
        Int64 TargetID { get; }

        /// <summary>
        /// TRUE when the module is active, including when the module is 
        /// flashing red in cooldown mode after being deactivated.
        /// Note: Require Module.IsActivatable == TRUE
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Note: Require Module.IsActivatable == TRUE
        /// </summary>
        bool IsOffensive { get; }

        /// <summary>
        /// Note: Require Module.IsActivatable == TRUE
        /// </summary>
        bool IsAssistance { get; }

        /// <summary>
        /// Note: Require Module.IsActivatable == TRUE
        /// </summary>
        int EffectCategory { get; }

        /// <summary>
        /// The charge type loaded into this module.
        /// </summary>
        ModuleCharge Charge { get; }

        /// <summary>
        /// Requires this.Charge.IsValid == true
        /// </summary>
        int CurrentCharges { get; }

        /// <summary>
        /// Requires this.Charge.IsValid == true
        /// </summary>
        int MaxCharges { get; }

        /// <summary>
        /// Wrapper for the PowergridUsage member of a module object.
        /// </summary>
        double? PowergridUsage { get; }

        /// <summary>
        /// Wrapper for the OptimalRange member of a module object.
        /// </summary>
        double? OptimalRange { get; }

        /// <summary>
        /// Wrapper for the TechLevel member of a module object.
        /// </summary>
        double? TechLevel { get; }

        /// <summary>
        /// Wrapper for the ActivationCost member of a module object.
        /// </summary>
        double? ActivationCost { get; }

        /// <summary>
        /// Hitpoints
        /// </summary>
        double? HP { get; }

        /// <summary>
        /// Hit points damage.
        /// </summary>
        double? Damage { get; }

        /// <summary>
        /// Wrapper for the ActivationTime member of a module object.
        /// </summary>
        double? ActivationTime { get; }

        /// <summary>
        /// Alias for ActivationTime.
        /// </summary>
        double? Duration { get; }

        /// <summary>
        /// Wrapper for the Volume member of a module object.
        /// </summary>
        double? Volume { get; }

        /// <summary>
        /// Wrapper for the AccessDifficultyBonus member of a module object.
        /// </summary>
        double? AccessDifficultyBonus { get; }

        /// <summary>
        /// Wrapper for the CPUUsage member of a module object.
        /// </summary>
        double? CPUUsage { get; }

        /// <summary>
        /// Wrapper for the Capacity member of a module object.
        /// </summary>
        double? Capacity { get; }

        /// <summary>
        /// Wrapper for the MaxTractorVelocity member of a module object.
        /// </summary>
        double? MaxTractorVelocity { get; }

        /// <summary>
        /// Wrapper for the Mass member of a module object.
        /// </summary>
        double? Mass { get; }

        /// <summary>
        /// Wrapper for the OverloadSpeedFactorBonus member of a module object.
        /// </summary>
        double? OverloadSpeedFactorBonus { get; }

        /// <summary>
        /// Wrapper for the MassAddition member of a module object.
        /// </summary>
        double? MassAddition { get; }

        /// <summary>
        /// Wrapper for the HeatDamage member of a module object.
        /// </summary>
        double? HeatDamage { get; }

        /// <summary>
        /// Wrapper for the Thrust member of a module object.
        /// </summary>
        double? Thrust { get; }

        /// <summary>
        /// Wrapper for the MaxVelocityBonus member of a module object.
        /// </summary>
        double? MaxVelocityBonus { get; }

        /// <summary>
        /// Wrapper for the MaxVelocityPenalty member of a module object.
        /// </summary>
        double? MaxVelocityPenalty { get; }

        /// <summary>
        /// Wrapper for the StructureHPBonus member of a module object.
        /// </summary>
        double? StructureHPBonus { get; }

        /// <summary>
        /// Wrapper for the CargoCapacityBonus member of a module object.
        /// </summary>
        double? CargoCapacityBonus { get; }

        /// <summary>
        /// Wrapper for the ShieldBonus member of a module object.
        /// </summary>
        double? ShieldBonus { get; }

        /// <summary>
        /// Wrapper for the ShieldBoostBonus member of a module object.
        /// </summary>
        double? ShieldBoostBonus { get; }

        /// <summary>
        /// Wrapper for the CapacitorRechargeRateBonus member of a module object.
        /// </summary>
        double? CapacitorRechargeRateBonus { get; }

        /// <summary>
        /// Wrapper for the ShieldRechargeRateBonus member of a module object.
        /// </summary>
        double? ShieldRechargeRateBonus { get; }

        /// <summary>
        /// Wrapper for the CapacitorBonus member of a module object.
        /// </summary>
        double? CapacitorBonus { get; }

        /// <summary>
        /// Wrapper for the PowergridBonus member of a module object.
        /// </summary>
        double? PowergridBonus { get; }

        /// <summary>
        /// Wrapper for the ShieldHPBonus member of a module object.
        /// </summary>
        double? ShieldHPBonus { get; }

        /// <summary>
        /// Wrapper for the VelocityModifier member of a module object.
        /// </summary>
        double? VelocityModifier { get; }

        /// <summary>
        /// Wrapper for the ChargeRate member of a module object.
        /// </summary>
        double? ChargeRate { get; }

        /// <summary>
        /// Wrapper for the RateOfFire member of a module object.
        /// </summary>
        double? RateOfFire { get; }

        /// <summary>
        /// Wrapper for the OverloadRateOfFireBonus member of a module object.
        /// </summary>
        double? OverloadRateOfFireBonus { get; }

        /// <summary>
        /// Wrapper for the MiningAmount member of a module object.
        /// </summary>
        double? MiningAmount { get; }

        /// <summary>
        /// Wrapper for the CrystalsDamage member of a module object.
        /// </summary>
        double? CrystalsDamage { get; }

        /// <summary>
        /// Wrapper for the TargetGroup member of a module object.
        /// </summary>
        int? TargetGroup { get; }

        /// <summary>
        /// Wrapper for the SurveyScanRange member of a module object.
        /// </summary>
        double? SurveyScanRange { get; }

        /// <summary>
        /// Wrapper for the CPUOutputBonus member of a module object.
        /// </summary>
        double? CPUOutputBonus { get; }

        /// <summary>
        /// This rounds to the nearest thousandth. 
        /// </summary>
        double? TrackingSpeed { get; }

        /// <summary>
        /// Wrapper for the DamageModifier member of a module object.
        /// </summary>
        double? DamageModifier { get; }

        /// <summary>
        /// Wrapper for the EMDamage member of a module object.
        /// </summary>
        double? EMDamage { get; }

        /// <summary>
        /// Wrapper for the KineticDamage member of a module object.
        /// </summary>
        double? KineticDamage { get; }

        /// <summary>
        /// Wrapper for the ThermalDamage member of a module object.
        /// </summary>
        double? ThermalDamage { get; }

        /// <summary>
        /// Wrapper for the ExplosiveDamage member of a module object.
        /// </summary>
        double? ExplosiveDamage { get; }

        /// <summary>
        /// Wrapper for the ChargeSize member of a module object.
        /// </summary>
        double? ChargeSize { get; }

        /// <summary>
        /// Wrapper for the AccuracyFalloff member of a module object.
        /// </summary>
        double? AccuracyFalloff { get; }

        /// <summary>
        /// Wrapper for the SignatureResolution member of a module object.
        /// </summary>
        double? SignatureResolution { get; }

        /// <summary>
        /// Wrapper for the OverloadOptimalRangeBonus member of a module object.
        /// </summary>
        double? OverloadOptimalRangeBonus { get; }

        /// <summary>
        /// Wrapper for the OverloadRepairBonus member of a module object.
        /// </summary>
        double? OverloadRepairBonus { get; }

        /// <summary>
        /// Wrapper for the OverloadDurationBonus member of a module object.
        /// </summary>
        double? OverloadDurationBonus { get; }

        /// <summary>
        /// Wrapper for the ArmorHPRepaired member of a module object.
        /// </summary>
        double? ArmorHPRepaired { get; }

        /// <summary>
        /// Wrapper for the ExplosiveDmgResistanceBonus member of a module object.
        /// </summary>
        double? ExplosiveDmgResistanceBonus { get; }

        /// <summary>
        /// Wrapper for the KineticDmgResistanceBonus member of a module object.
        /// </summary>
        double? KineticDmgResistanceBonus { get; }

        /// <summary>
        /// Wrapper for the ThermalDmgResistanceBonus member of a module object.
        /// </summary>
        double? ThermalDmgResistanceBonus { get; }

        /// <summary>
        /// Wrapper for the EMDmgResistanceBonus member of a module object.
        /// </summary>
        double? EMDmgResistanceBonus { get; }

        /// <summary>
        /// Wrapper for the ArmorHPBonus member of a module object.
        /// </summary>
        double? ArmorHPBonus { get; }

        /// <summary>
        /// Wrapper for the RateOfFireBonus member of a module object.
        /// </summary>
        double? RateOfFireBonus { get; }

        /// <summary>
        /// Wrapper for the MiningAmountBonus member of a module object.
        /// </summary>
        double? MiningAmountBonus { get; }

        /// <summary>
        /// Wrapper for the CPUPenaltyPercent member of a module object.
        /// </summary>
        double? CPUPenaltyPercent { get; }

        /// <summary>
        /// Wrapper for the WarpScrambleStrength member of a module object.
        /// </summary>
        double? WarpScrambleStrength { get; }

        /// <summary>
        /// Wrapper for Module.EnergyTransferAmount
        /// </summary>
        double? EnergyTransferAmount { get; }

        /// <summary>
        /// Wrapper for Module.TransferRange
        /// </summary>
        double? TransferRange { get; }

        /// <summary>
        /// Wrapper for Module.MaxNeutralizationRange
        /// </summary>
        double? MaxNeutralizationRange { get; }

        /// <summary>
        /// Wrapper for Module.MaxNeutralizationRange
        /// </summary>
        double? EnergyNeutralized { get; }

        /// <summary>
        /// Wrapper for the GetAvailableAmmo member of a module object.
        /// </summary>
        List<Item> GetAvailableAmmo();

        /// <summary>
        /// Wrapper for the Click method of a module object
        /// </summary>
        /// <returns></returns>
        bool Click();

        /// <summary>
        /// Wrapper for the Activate method of a module object
        /// </summary>
        /// <returns></returns>
        bool Activate();

        /// <summary>
        /// Wrapper for the Activate method of a module object
        /// </summary>
        /// <returns></returns>
        bool Activate(Int64 EntityID);

        /// <summary>
        /// Wrapper for the Activate method of a module object
        /// </summary>
        /// <returns></returns>
        bool Deactivate();

        /// <summary>
        /// Parameter is the Item.ID of an ammunition from your ship's cargo
        /// NOTE: This method will replace your current ammo with the ammo given 
        /// in the same quantity 
        /// </summary>
        bool ChangeAmmo(Int64 AmmoID);

        /// <summary>
        /// Parameter is the Item.ID of an ammunition from your ship's cargo
        /// NOTE: be careful, if you use a quantity that is too high for the module, 
        /// it'll fail entirely. See Module.MaxCharges
        /// </summary>
        bool ChangeAmmo(Int64 AmmoID, int Quantity);

        /// <summary>
        /// Wrapper for the SetAutoReloadOn method of a module object
        /// </summary>
        /// <returns></returns>
        bool SetAutoReloadOn();

        /// <summary>
        /// Wrapper for the SetAutoReloadOff method of a module object
        /// </summary>
        /// <returns></returns>
        bool SetAutoReloadOff();

        /// <summary>
        /// Wrapper for the PutOnline method of a module object
        /// </summary>
        /// <returns></returns>
        bool PutOnline();

        /// <summary>
        /// Wrapper for the PutOffline method of a module object
        /// </summary>
        /// <returns></returns>
        bool PutOffline();
    }
}