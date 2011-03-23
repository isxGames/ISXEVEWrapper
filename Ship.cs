using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
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
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Wrapper for the Capacitor member of the ship type.
		/// </summary>
		public double Capacitor
		{
			get
			{
				LavishScriptObject capacitor = GetMember("Capacitor");
				if (!LavishScriptObject.IsNullOrInvalid(capacitor))
				{
					return capacitor.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// one sec<summary>
		/// Wrapper for the MaxCapacitor member of the ship type.
		/// </summary>
		public double MaxCapacitor
		{
			get
			{
				LavishScriptObject maxCapacitor = GetMember("MaxCapacitor");
				if (!LavishScriptObject.IsNullOrInvalid(maxCapacitor))
				{
					return maxCapacitor.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the CapacitorPct member of the ship type.
		/// </summary>
		public double CapacitorPct
		{
			get
			{
				LavishScriptObject capacitorPct = GetMember("CapacitorPct");
				if (!LavishScriptObject.IsNullOrInvalid(capacitorPct))
				{
					return capacitorPct.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Shield member of the ship type.
		/// </summary>
		public double Shield
		{
			get
			{
				LavishScriptObject shield = GetMember("Shield");
				if (!LavishScriptObject.IsNullOrInvalid(shield))
				{
					return shield.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the MaxShield member of the ship type.
		/// </summary>
		public double MaxShield
		{
			get
			{
				LavishScriptObject maxShield = GetMember("MaxShield");
				if (!LavishScriptObject.IsNullOrInvalid(maxShield))
				{
					return maxShield.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the ShieldPct member of the ship type.
		/// </summary>
		public double ShieldPct
		{
			get
			{
				LavishScriptObject shieldPct = GetMember("ShieldPct");
				if (!LavishScriptObject.IsNullOrInvalid(shieldPct))
				{
					return shieldPct.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Armor member of the ship type.
		/// </summary>
		public double Armor
		{
			get
			{
				LavishScriptObject armor = GetMember("Armor");
				if (!LavishScriptObject.IsNullOrInvalid(armor))
				{
					return armor.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the MaxArmor member of the ship type.
		/// </summary>
		public double MaxArmor
		{
			get
			{
				LavishScriptObject maxArmor = GetMember("MaxArmor");
				if (!LavishScriptObject.IsNullOrInvalid(maxArmor))
				{
					return maxArmor.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the ArmorPct member of the ship type.
		/// </summary>
		public double ArmorPct
		{
			get
			{
				LavishScriptObject armorPct = GetMember("ArmorPct");
				if (!LavishScriptObject.IsNullOrInvalid(armorPct))
				{
					return armorPct.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Structure member of the ship type.
		/// </summary>
		public double Structure
		{
			get
			{
				LavishScriptObject structure = GetMember("Structure");
				if (!LavishScriptObject.IsNullOrInvalid(structure))
				{
					return structure.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the MaxStructure member of the ship type.
		/// </summary>
		public double MaxStructure
		{
			get
			{
				LavishScriptObject maxStructure = GetMember("MaxStructure");
				if (!LavishScriptObject.IsNullOrInvalid(maxStructure))
				{
					return maxStructure.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the StructurePct member of the ship type.
		/// </summary>
		public double StructurePct
		{
			get
			{
				LavishScriptObject structurePct = GetMember("StructurePct");
				if (!LavishScriptObject.IsNullOrInvalid(structurePct))
				{
					return structurePct.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the CPULoad member of the ship type.
		/// </summary>
		public double CPULoad
		{
			get
			{
				return GetMember<double>("CPULoad");
			}
		}

		/// <summary>
		/// Wrapper for the CPUOutput member of the ship type.
		/// </summary>
		public double CPUOutput
		{
			get
			{
				return GetMember<double>("CPUOutput");
			}
		}

		/// <summary>
		/// Wrapper for the PowerLoad member of the ship type.
		/// </summary>
		public double PowerLoad
		{
			get
			{
				return GetMember<double>("PowerLoad");
			}
		}

		/// <summary>
		/// Wrapper for the PowerOutput member of the ship type.
		/// </summary>
		public double PowerOutput
		{
			get
			{
				return GetMember<double>("PowerOutput");
			}
		}

		/// <summary>
		/// Wrapper for the TurretSlotsLeft member of the ship type.
		/// </summary>
		public double TurretSlotsLeft
		{
			get
			{
				return GetMember<double>("TurretSlotsLeft");
			}
		}

		/// <summary>
		/// Wrapper for the HeatCapacityHigh member of the ship type.
		/// </summary>
		public double HeatCapacityHigh
		{
			get
			{
				return GetMember<double>("HeatCapacityHigh");
			}
		}

		/// <summary>
		/// Wrapper for the HeatCapacityMedium member of the ship type.
		/// </summary>
		public double HeatCapacityMedium
		{
			get
			{
				return GetMember<double>("HeatCapacityMedium");
			}
		}

		/// <summary>
		/// Wrapper for the HeatCapacityLow member of the ship type.
		/// </summary>
		public double HeatCapacityLow
		{
			get
			{
				return GetMember<double>("HeatCapacityLow");
			}
		}

		/// <summary>
		/// Wrapper for the RigSlots member of the ship type.
		/// </summary>
		public double RigSlots
		{
			get
			{
				return GetMember<double>("RigSlots");
			}
		}

		/// <summary>
		/// Wrapper for the RigSlotsLeft member of the ship type.
		/// </summary>
		public double RigSlotsLeft
		{
			get
			{
				return GetMember<double>("RigSlotsLeft");
			}
		}

		/// <summary>
		/// Wrapper for the ScanSpeed member of the ship type.
		/// </summary>
		public double ScanSpeed
		{
			get
			{
				return GetMember<double>("ScanSpeed");
			}
		}

		/// <summary>
		/// Wrapper for the MaxTargetRange member of the ship type.
		/// </summary>
		public double MaxTargetRange
		{
			get
			{
				return GetMember<double>("MaxTargetRange");
			}
		}

		/// <summary>
		/// Wrapper for the LowSlots member of the ship type.
		/// </summary>
		public double LowSlots
		{
			get
			{
				return GetMember<double>("LowSlots");
			}
		}

		/// <summary>
		/// Wrapper for the MediumSlots member of the ship type.
		/// </summary>
		public double MediumSlots
		{
			get
			{
				return GetMember<double>("MediumSlots");
			}
		}

		/// <summary>
		/// Wrapper for the HighSlots member of the ship type.
		/// </summary>
		public double HighSlots
		{
			get
			{
				return GetMember<double>("HighSlots");
			}
		}

		/// <summary>
		/// Wrapper for the Radius member of the ship type.
		/// </summary>
		public double Radius
		{
			get
			{
				return GetMember<double>("Radius");
			}
		}

		/// <summary>
		/// Wrapper for the TechLevel member of the ship type.
		/// </summary>
		public double TechLevel
		{
			get
			{
				return GetMember<double>("TechLevel");
			}
		}

		/// <summary>
		/// Wrapper for the HeatLow member of the ship type.
		/// </summary>
		public double HeatLow
		{
			get
			{
				LavishScriptObject heatLow = GetMember("HeatLow");
				if (LavishScriptObject.IsNullOrInvalid(heatLow))
				{
					return -1;
				}
				return heatLow.GetValue<double>();
			}
		}

		/// <summary>
		/// Wrapper for the HeatMedium member of the ship type.
		/// </summary>
		public double HeatMedium
		{
			get
			{
				LavishScriptObject heatMedium = GetMember("HeatMedium");
				if (LavishScriptObject.IsNullOrInvalid(heatMedium))
				{
					return -1;
				}
				return heatMedium.GetValue<double>();
			}
		}

		/// <summary>
		/// Wrapper for the HeatHigh member of the ship type.
		/// </summary>
		public double HeatHigh
		{
			get
			{
				LavishScriptObject heatHigh = GetMember("HeatHigh");
				if (LavishScriptObject.IsNullOrInvalid(heatHigh))
				{
					return -1;
				}
				return heatHigh.GetValue<double>();
			}
		}

		/// <summary>
		/// Wrapper for the MaxVelocity member of the ship type.
		/// </summary>
		public double MaxVelocity
		{
			get
			{
				return GetMember<double>("MaxVelocity");
			}
		}

		/// <summary>
		/// Wrapper for the ScanResolution member of the ship type.
		/// </summary>
		public double ScanResolution
		{
			get
			{
				return GetMember<double>("ScanResolution");
			}
		}

		/// <summary>
		/// Wrapper for the ScanRadarStrength member of the ship type.
		/// </summary>
		public double ScanRadarStrength
		{
			get
			{
				return GetMember<double>("ScanRadarStrength");
			}
		}

		/// <summary>
		/// Wrapper for the Agility member of the ship type.
		/// </summary>
		public double Agility
		{
			get
			{
				return GetMember<double>("Agility");
			}
		}

		/// <summary>
		/// Wrapper for the LauncherSlotsLeft member of the ship type.
		/// </summary>
		public double LauncherSlotsLeft
		{
			get
			{
				return GetMember<double>("LauncherSlotsLeft");
			}
		}

		/// <summary>
		/// Wrapper for the CapacitorRechargeRate member of the ship type.
		/// </summary>
		public double CapacitorRechargeRate
		{
			get
			{
				return GetMember<double>("CapacitorRechargeRate");
			}
		}

		/// <summary>
		/// Wrapper for the ShieldRechargeRate member of the ship type.
		/// </summary>
		public double ShieldRechargeRate
		{
			get
			{
				return GetMember<double>("ShieldRechargeRate");
			}
		}

		/// <summary>
		/// Wrapper for the SignatureRadius member of the ship type.
		/// </summary>
		public double SignatureRadius
		{
			get
			{
				return GetMember<double>("SignatureRadius");
			}
		}

		/// <summary>
		/// See also the 'MaxLockedTargets' member of the character datatype for the character's restrictions on locked targets.
		/// </summary>
		public double MaxLockedTargets
		{
			get
			{
				LavishScriptObject maxLockedTarges = GetMember("MaxLockedTargets");
				if (!LavishScriptObject.IsNullOrInvalid(maxLockedTarges))
				{
					return maxLockedTarges.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}
		#endregion

		#region Cargo
		/// <summary>
		/// Wrapper for the CargoCapacity member of the ship type.
		/// </summary>
		public double CargoCapacity
		{
			get
			{
				LavishScriptObject cargoCapacity = GetMember("CargoCapacity");
				if (!LavishScriptObject.IsNullOrInvalid(cargoCapacity))
				{
					return cargoCapacity.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the UsedCargoCapacity member of the ship type.
		/// </summary>
		public double UsedCargoCapacity
		{
			get
			{
				LavishScriptObject usedCargoCapacity = GetMember("UsedCargoCapacity");
				if (!LavishScriptObject.IsNullOrInvalid(usedCargoCapacity))
				{
					return usedCargoCapacity.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
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
			get
			{
				return GetMember<double>("DronebayCapacity");
			}
		}

		/// <summary>
		/// Wrapper for the UsedDronebayCapacity member of the ship type.
		/// </summary>
		public double UsedDronebayCapacity
		{
			get
			{
				return GetMember<double>("UsedDronebayCapacity");
			}
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
