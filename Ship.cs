using System;
using System.Collections.Generic;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the ship data type.
	/// </summary>
	public class Ship : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Ship copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Ship(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Ship constructor.
		/// </summary>
		public Ship()
			: base(LavishScript.Objects.GetObject("MyShip"))
		{
		}
		#endregion

		#region Members
		#region ShipStats
		/// <summary>
		/// Wrapper for the Name member of the ship type.
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

		/// <summary>
		/// Wrapper for the Capacitor member of the ship type.
		/// </summary>
		public double Capacitor
		{
			get { return this.GetDoubleFromLSO("Capacitor"); }
		}

		/// one sec<summary>
		/// Wrapper for the MaxCapacitor member of the ship type.
		/// </summary>
		public double MaxCapacitor
		{
			get { return this.GetDoubleFromLSO("MaxCapacitor"); }
		}

		/// <summary>
		/// Wrapper for the CapacitorPct member of the ship type.
		/// </summary>
		public double CapacitorPct
		{
			get { return this.GetDoubleFromLSO("CapacitorPct"); }
		}

		/// <summary>
		/// Wrapper for the Shield member of the ship type.
		/// </summary>
		public double Shield
		{
			get { return this.GetDoubleFromLSO("Shield"); }
		}

		/// <summary>
		/// Wrapper for the MaxShield member of the ship type.
		/// </summary>
		public double MaxShield
		{
			get { return this.GetDoubleFromLSO("MaxShield"); }
		}

		/// <summary>
		/// Wrapper for the ShieldPct member of the ship type.
		/// </summary>
		public double ShieldPct
		{
			get { return this.GetDoubleFromLSO("ShieldPct"); }
		}

		/// <summary>
		/// Wrapper for the Armor member of the ship type.
		/// </summary>
		public double Armor
		{
			get { return this.GetDoubleFromLSO("Armor"); }
		}

		/// <summary>
		/// Wrapper for the MaxArmor member of the ship type.
		/// </summary>
		public double MaxArmor
		{
			get { return this.GetDoubleFromLSO("MaxArmor"); }
		}

		/// <summary>
		/// Wrapper for the ArmorPct member of the ship type.
		/// </summary>
		public double ArmorPct
		{
			get { return this.GetDoubleFromLSO("ArmorPct"); }
		}

		/// <summary>
		/// Wrapper for the Structure member of the ship type.
		/// </summary>
		public double Structure
		{
			get { return this.GetDoubleFromLSO("Structure"); }
		}

		/// <summary>
		/// Wrapper for the MaxStructure member of the ship type.
		/// </summary>
		public double MaxStructure
		{
			get { return this.GetDoubleFromLSO("MaxStructure"); }
		}

		/// <summary>
		/// Wrapper for the StructurePct member of the ship type.
		/// </summary>
		public double StructurePct
		{
			get { return this.GetDoubleFromLSO("StructurePct"); }
		}

	    public Item ToItem
	    {
	        get { return new Item(GetMember("ToItem")); }
	    }

	    public Scanner Scanner
	    {
	        get { return new Scanner(GetMember("Scanner")); }
	    }

		/// <summary>
		/// Wrapper for the CPULoad member of the ship type.
		/// </summary>
		public double CPULoad
		{
			get { return this.GetDoubleFromLSO("CPULoad"); }
		}

		/// <summary>
		/// Wrapper for the CPUOutput member of the ship type.
		/// </summary>
		public double CPUOutput
		{
			get { return this.GetDoubleFromLSO("CPUOutput"); }
		}

		/// <summary>
		/// Wrapper for the PowerLoad member of the ship type.
		/// </summary>
		public double PowerLoad
		{
			get { return this.GetDoubleFromLSO("PowerLoad"); }
		}

		/// <summary>
		/// Wrapper for the PowerOutput member of the ship type.
		/// </summary>
		public double PowerOutput
		{
			get { return this.GetDoubleFromLSO("PowerOutput"); }
		}

		/// <summary>
		/// Wrapper for the TurretSlotsLeft member of the ship type.
		/// </summary>
		public double TurretSlotsLeft
		{
			get { return this.GetDoubleFromLSO("TurretSlotsLeft"); }
		}

		/// <summary>
		/// Wrapper for the HeatCapacityHigh member of the ship type.
		/// </summary>
		public double HeatCapacityHigh
		{
			get { return this.GetDoubleFromLSO("HeatCapacityHigh"); }
		}

		/// <summary>
		/// Wrapper for the HeatCapacityMedium member of the ship type.
		/// </summary>
		public double HeatCapacityMedium
		{
			get { return this.GetDoubleFromLSO("HeatCapacityMedium"); }
		}

		/// <summary>
		/// Wrapper for the HeatCapacityLow member of the ship type.
		/// </summary>
		public double HeatCapacityLow
		{
			get { return this.GetDoubleFromLSO("HeatCapacityLow"); }
		}

		/// <summary>
		/// Wrapper for the RigSlots member of the ship type.
		/// </summary>
		public double RigSlots
		{
			get { return this.GetDoubleFromLSO("RigSlots"); }
		}

		/// <summary>
		/// Wrapper for the RigSlotsLeft member of the ship type.
		/// </summary>
		public double RigSlotsLeft
		{
			get { return this.GetDoubleFromLSO("RigSlotsLeft"); }
		}

		/// <summary>
		/// Wrapper for the ScanSpeed member of the ship type.
		/// </summary>
		public double ScanSpeed
		{
			get { return this.GetDoubleFromLSO("ScanSpeed"); }
		}

		/// <summary>
		/// Wrapper for the MaxTargetRange member of the ship type.
		/// </summary>
		public double MaxTargetRange
		{
			get { return this.GetDoubleFromLSO("MaxTargetRange"); }
		}

		/// <summary>
		/// Wrapper for the LowSlots member of the ship type.
		/// </summary>
		public double LowSlots
		{
			get { return this.GetDoubleFromLSO("LowSlots"); }
		}

		/// <summary>
		/// Wrapper for the MediumSlots member of the ship type.
		/// </summary>
		public double MediumSlots
		{
			get { return this.GetDoubleFromLSO("MediumSlots"); }
		}

		/// <summary>
		/// Wrapper for the HighSlots member of the ship type.
		/// </summary>
		public double HighSlots
		{
			get { return this.GetDoubleFromLSO("HighSlots"); }
		}

		/// <summary>
		/// Wrapper for the Radius member of the ship type.
		/// </summary>
		public double Radius
		{
			get { return this.GetDoubleFromLSO("Radius"); }
		}

		/// <summary>
		/// Wrapper for the TechLevel member of the ship type.
		/// </summary>
		public double TechLevel
		{
			get { return this.GetDoubleFromLSO("TechLevel"); }
		}

		/// <summary>
		/// Wrapper for the HeatLow member of the ship type.
		/// </summary>
		public double HeatLow
		{
			get { return this.GetDoubleFromLSO("HeatLow"); }
		}

		/// <summary>
		/// Wrapper for the HeatMedium member of the ship type.
		/// </summary>
		public double HeatMedium
		{
			get { return this.GetDoubleFromLSO("HeatMedium"); }
		}

		/// <summary>
		/// Wrapper for the HeatHigh member of the ship type.
		/// </summary>
		public double HeatHigh
		{
			get { return this.GetDoubleFromLSO("HeatHigh"); }
		}

		/// <summary>
		/// Wrapper for the MaxVelocity member of the ship type.
		/// </summary>
		public double MaxVelocity
		{
			get { return this.GetDoubleFromLSO("MaxVelocity"); }
		}

		/// <summary>
		/// Wrapper for the ScanResolution member of the ship type.
		/// </summary>
		public double ScanResolution
		{
			get { return this.GetDoubleFromLSO("ScanResolution"); }
		}

		/// <summary>
		/// Wrapper for the ScanRadarStrength member of the ship type.
		/// </summary>
		public double ScanRadarStrength
		{
			get { return this.GetDoubleFromLSO("ScanRadarStrength"); }
		}

		/// <summary>
		/// Wrapper for the Agility member of the ship type.
		/// </summary>
		public double Agility
		{
			get { return this.GetDoubleFromLSO("Agility"); }
		}

		/// <summary>
		/// Wrapper for the LauncherSlotsLeft member of the ship type.
		/// </summary>
		public double LauncherSlotsLeft
		{
			get { return this.GetDoubleFromLSO("LauncherSlotsLeft"); }
		}

		/// <summary>
		/// Wrapper for the CapacitorRechargeRate member of the ship type.
		/// </summary>
		public double CapacitorRechargeRate
		{
			get { return this.GetDoubleFromLSO("CapacitorRechargeRate"); }
		}

		/// <summary>
		/// Wrapper for the ShieldRechargeRate member of the ship type.
		/// </summary>
		public double ShieldRechargeRate
		{
			get { return this.GetDoubleFromLSO("ShieldRechargeRate"); }
		}

		/// <summary>
		/// Wrapper for the SignatureRadius member of the ship type.
		/// </summary>
		public double SignatureRadius
		{
			get { return this.GetDoubleFromLSO("SignatureRadius"); }
		}

		/// <summary>
		/// See also the 'MaxLockedTargets' member of the character datatype for the character's restrictions on locked targets.
		/// </summary>
		public double MaxLockedTargets
		{
			get { return this.GetDoubleFromLSO("MaxLockedTargets"); }
		}
		#endregion

		#region Cargo
		/// <summary>
		/// Wrapper for the CargoCapacity member of the ship type.
		/// </summary>
		public double CargoCapacity
		{
			get { return this.GetDoubleFromLSO("CargoCapacity"); }
		}

		/// <summary>
		/// Wrapper for the UsedCargoCapacity member of the ship type.
		/// </summary>
		public double UsedCargoCapacity
		{
			get { return this.GetDoubleFromLSO("UsedCargoCapacity"); }
		}

		/// <summary>
		/// Wrapper for the Cargo member of the ship type.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public Item Cargo(int i)
		{
			return new Item(GetMember("Cargo", i.ToString()));
		}

		/// <summary>
		/// Wrapper for the Cargo member of the ship type.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Item Cargo(string name)
		{
			return new Item(GetMember("Cargo", name));
		}

		/// <summary>
		/// Wrapper for the GetCargo member of the ship type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCargo()
		{
			Tracing.SendCallback("Ship.GetCargo");
			return Util.GetListFromMethod<Item>(this, "GetCargo", "item");
		}
		#endregion

		#region Drone
		/// <summary>
		/// Wrapper for the DronebayCapacity member of the ship type.
		/// </summary>
		public double DronebayCapacity
		{
			get { return this.GetDoubleFromLSO("DronebayCapacity"); }
		}

		/// <summary>
		/// Wrapper for the UsedDronebayCapacity member of the ship type.
		/// </summary>
		public double UsedDronebayCapacity
		{
			get { return this.GetDoubleFromLSO("UsedDronebayCapacity"); }
		}

		/// <summary>
		/// Wrapper for the Drone member of the ship type.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public Item Drone(int i)
		{
			return new Item(GetMember("Drone", i.ToString()));
		}

		/// <summary>
		/// Wrapper for the Drone member of the ship type.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public Item Drone(string name)
		{
			return new Item(GetMember("Drone", name));
		}

		/// <summary>
		/// Wrapper for the GetDrones member of the ship type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetDrones()
		{
			Tracing.SendCallback("Ship.GetDrones", string.Empty);
			return Util.GetListFromMethod<Item>(this, "GetDrones", "item");
		}
		#endregion

		#region Space
		/// <summary>
		/// Retrieve a module based on its slot
		/// Note: Must be in space.
		/// </summary>
		public Module Module(SlotType slottype, int number)
		{
			if (number < 0 || number > 7)
				throw new Exception("Slot number must be between 0 and 7, inclusive");

			return new Module(GetMember("Module", slottype.ToString() + number.ToString()));
		}

		/// <summary>
		/// Wrapper for the Module member of the ship type.
		/// </summary>
		/// <param name="slotname"></param>
		/// <returns></returns>
		public Module Module(string slotname)
		{
			return new Module(GetMember("Module", slotname));
		}

		/// <summary>
		/// Retreive a module item based on its slot.  Usable both
		/// in station and in space.
		/// </summary>
		public Item ModuleItem(SlotType slottype, int number)
		{
			return Module(slottype, number).ToItem;
		}

		/// <summary>
		/// Wrapper for the ModuleItem member of the ship type.
		/// </summary>
		/// <param name="slotname"></param>
		/// <returns></returns>
		public Item ModuleItem(string slotname)
		{
			return Module(slotname).ToItem;
		}

		/// <summary>
		/// Modules fit to the ship
		/// Note: Must be in space.
		/// </summary>
		public List<Module> GetModules()
		{
			Tracing.SendCallback("Ship.GetModules");
			return Util.GetListFromMethod<Module>(this, "GetModules", "module");
		}
		#endregion
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the StackAllCargo method of the ship type.
		/// </summary>
		/// <returns></returns>
		public bool StackAllCargo()
		{
			Tracing.SendCallback("Ship.StackAllCargo");
			return ExecuteMethod("StackAllCargo");
		}

		/// <summary>
		/// To utilize the drone methods properly, your drones must be UNSTACKED in 
		/// your drone bay. To do this, you can either SHIFT-DRAG the drones to your 
		/// drone bay and select a quantity of 1, or you can go in space, launch all 
		/// your drones, and then recall them to your drone bay. When drones return 
		/// to your drone bay, they always go back 'unstacked'.
		/// </summary>
		public bool LaunchAllDrones()
		{
			Tracing.SendCallback("Ship.LaunchAllDrones");
			return ExecuteMethod("LaunchAllDrones");
		}

		/// <summary>
		/// Wrapper for the OpenCargo method of the ship type.
		/// </summary>
		/// <returns></returns>
		public bool OpenCargo()
		{
			Tracing.SendCallback("Ship.OpenCargo");
			return ExecuteMethod("OpenCargo");
		}
		#endregion
	}
}
