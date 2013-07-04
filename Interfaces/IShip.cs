using System;
using System.Collections.Generic;
using LavishScriptAPI.Interfaces;

namespace EVE.ISXEVE.Interfaces
{
    /// <summary>
    /// Wrapper for the Ship datatype.
    /// </summary>
    public interface IShip : ILSObject
    {
        /// <summary>
        /// Wrapper for the ID member of this ship type. This is the same as our Entity ID.
        /// </summary>
        Int64 ID { get; }

        /// <summary>
        /// Wrapper for the Name member of the ship type.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Wrapper for the Capacitor member of the ship type.
        /// </summary>
        double Capacitor { get; }

        /// one sec<summary>
        /// Wrapper for the MaxCapacitor member of the ship type.
        /// </summary>
        double MaxCapacitor { get; }

        /// <summary>
        /// Wrapper for the CapacitorPct member of the ship type.
        /// </summary>
        double CapacitorPct { get; }

        /// <summary>
        /// Wrapper for the Shield member of the ship type.
        /// </summary>
        double Shield { get; }

        /// <summary>
        /// Wrapper for the MaxShield member of the ship type.
        /// </summary>
        double MaxShield { get; }

        /// <summary>
        /// Wrapper for the ShieldPct member of the ship type.
        /// </summary>
        double ShieldPct { get; }

        /// <summary>
        /// Wrapper for the Armor member of the ship type.
        /// </summary>
        double Armor { get; }

        /// <summary>
        /// Wrapper for the MaxArmor member of the ship type.
        /// </summary>
        double MaxArmor { get; }

        /// <summary>
        /// Wrapper for the ArmorPct member of the ship type.
        /// </summary>
        double ArmorPct { get; }

        /// <summary>
        /// Wrapper for the Structure member of the ship type.
        /// </summary>
        double Structure { get; }

        /// <summary>
        /// Wrapper for the MaxStructure member of the ship type.
        /// </summary>
        double MaxStructure { get; }

        /// <summary>
        /// Wrapper for the StructurePct member of the ship type.
        /// </summary>
        double StructurePct { get; }

        /// <summary>
        /// Wrapper for the Ship.ToItem member
        /// </summary>
        IItem ToItem { get; }

        /// <summary>
        /// Wrapper for the Ship.Scanner member
        /// </summary>
        Scanner Scanner { get; }

        /// <summary>
        /// Wrapper for the CPULoad member of the ship type.
        /// </summary>
        double CPULoad { get; }

        /// <summary>
        /// Wrapper for the CPUOutput member of the ship type.
        /// </summary>
        double CPUOutput { get; }

        /// <summary>
        /// Wrapper for the PowerLoad member of the ship type.
        /// </summary>
        double PowerLoad { get; }

        /// <summary>
        /// Wrapper for the PowerOutput member of the ship type.
        /// </summary>
        double PowerOutput { get; }

        /// <summary>
        /// Wrapper for the TurretSlotsLeft member of the ship type.
        /// </summary>
        double TurretSlotsLeft { get; }

        /// <summary>
        /// Wrapper for the HeatCapacityHigh member of the ship type.
        /// </summary>
        double HeatCapacityHigh { get; }

        /// <summary>
        /// Wrapper for the HeatCapacityMedium member of the ship type.
        /// </summary>
        double HeatCapacityMedium { get; }

        /// <summary>
        /// Wrapper for the HeatCapacityLow member of the ship type.
        /// </summary>
        double HeatCapacityLow { get; }

        /// <summary>
        /// Wrapper for the RigSlots member of the ship type.
        /// </summary>
        double RigSlots { get; }

        /// <summary>
        /// Wrapper for the RigSlotsLeft member of the ship type.
        /// </summary>
        double RigSlotsLeft { get; }

        /// <summary>
        /// Wrapper for the ScanSpeed member of the ship type.
        /// </summary>
        double ScanSpeed { get; }

        /// <summary>
        /// Wrapper for the MaxTargetRange member of the ship type.
        /// </summary>
        double MaxTargetRange { get; }

        /// <summary>
        /// Wrapper for the LowSlots member of the ship type.
        /// </summary>
        double LowSlots { get; }

        /// <summary>
        /// Wrapper for the MediumSlots member of the ship type.
        /// </summary>
        double MediumSlots { get; }

        /// <summary>
        /// Wrapper for the HighSlots member of the ship type.
        /// </summary>
        double HighSlots { get; }

        /// <summary>
        /// Wrapper for the Radius member of the ship type.
        /// </summary>
        double Radius { get; }

        /// <summary>
        /// Wrapper for the TechLevel member of the ship type.
        /// </summary>
        double TechLevel { get; }

        /// <summary>
        /// Wrapper for the HeatLow member of the ship type.
        /// </summary>
        double HeatLow { get; }

        /// <summary>
        /// Wrapper for the HeatMedium member of the ship type.
        /// </summary>
        double HeatMedium { get; }

        /// <summary>
        /// Wrapper for the HeatHigh member of the ship type.
        /// </summary>
        double HeatHigh { get; }

        /// <summary>
        /// Wrapper for the MaxVelocity member of the ship type.
        /// </summary>
        double MaxVelocity { get; }

        /// <summary>
        /// Wrapper for the ScanResolution member of the ship type.
        /// </summary>
        double ScanResolution { get; }

        /// <summary>
        /// Wrapper for the ScanRadarStrength member of the ship type.
        /// </summary>
        double ScanRadarStrength { get; }

        /// <summary>
        /// Wrapper for the Agility member of the ship type.
        /// </summary>
        double Agility { get; }

        /// <summary>
        /// Wrapper for the LauncherSlotsLeft member of the ship type.
        /// </summary>
        double LauncherSlotsLeft { get; }

        /// <summary>
        /// Wrapper for the CapacitorRechargeRate member of the ship type.
        /// </summary>
        double CapacitorRechargeRate { get; }

        /// <summary>
        /// Wrapper for the ShieldRechargeRate member of the ship type.
        /// </summary>
        double ShieldRechargeRate { get; }

        /// <summary>
        /// Wrapper for the SignatureRadius member of the ship type.
        /// </summary>
        double SignatureRadius { get; }

        /// <summary>
        /// See also the 'MaxLockedTargets' member of the character datatype for the character's restrictions on locked targets.
        /// </summary>
        double MaxLockedTargets { get; }

        /// <summary>
        /// Wrapper for the CargoCapacity member of the ship type.
        /// </summary>
        double CargoCapacity { get; }

        /// <summary>
        /// Wrapper for the UsedCargoCapacity member of the ship type.
        /// </summary>
        double UsedCargoCapacity { get; }

        /// <summary>
        /// Wrapper for the HasOreHold member of the ship type.
        /// </summary>
        bool HasOreHold { get; }

        /// <summary>
        /// Wrapper for the DronebayCapacity member of the ship type.
        /// </summary>
        double DronebayCapacity { get; }

        /// <summary>
        /// Wrapper for the UsedDronebayCapacity member of the ship type.
        /// </summary>
        double UsedDronebayCapacity { get; }

        /// <summary>
        /// Wrapper for the Cargo member of the ship type.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        IItem Cargo(int i);

        /// <summary>
        /// Wrapper for the Cargo member of the ship type.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IItem Cargo(string name);

        /// <summary>
        /// Wrapper for the GetCargo member of the ship type.
        /// </summary>
        /// <returns></returns>
        List<IItem> GetCargo();

        /// <summary>
        /// Wrapper for the GetOreHoldCargo method of the ship type
        /// </summary>
        /// <returns></returns>
        List<IItem> GetOreHoldCargo();

        /// <summary>
        /// Wrapper for the Drone member of the ship type.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        IItem Drone(int i);

        /// <summary>
        /// Wrapper for the Drone member of the ship type.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IItem Drone(string name);

        /// <summary>
        /// Wrapper for the GetDrones member of the ship type.
        /// </summary>
        /// <returns></returns>
        List<IItem> GetDrones();

        /// <summary>
        /// Retrieve a module based on its slot
        /// Note: Must be in space.
        /// </summary>
        IModule Module(SlotType slottype, int number);

        /// <summary>
        /// Wrapper for the Module member of the ship type.
        /// </summary>
        /// <param name="slotname"></param>
        /// <returns></returns>
        IModule Module(string slotname);

        /// <summary>
        /// Retreive a module item based on its slot.  Usable both
        /// in station and in space.
        /// </summary>
        IItem ModuleItem(SlotType slottype, int number);

        /// <summary>
        /// Wrapper for the ModuleItem member of the ship type.
        /// </summary>
        /// <param name="slotname"></param>
        /// <returns></returns>
        IItem ModuleItem(string slotname);

        /// <summary>
        /// Modules fit to the ship
        /// Note: Must be in space.
        /// </summary>
        List<IModule> GetModules();

        /// <summary>
        /// Wrapper for the StackAllCargo method of the ship type.
        /// </summary>
        /// <returns></returns>
        bool StackAllCargo();

        /// <summary>
        /// To utilize the drone methods properly, your drones must be UNSTACKED in 
        /// your drone bay. To do this, you can either SHIFT-DRAG the drones to your 
        /// drone bay and select a quantity of 1, or you can go in space, launch all 
        /// your drones, and then recall them to your drone bay. When drones return 
        /// to your drone bay, they always go back 'unstacked'.
        /// </summary>
        bool LaunchAllDrones();

        /// <summary>
        /// Wrapper for the Open method of the ship type.
        /// </summary>
        /// <returns></returns>
        bool Open();
    }
}