using System;
using System.Collections.Generic;
using EVE.ISXEVE.Interfaces;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the ship data type.
	/// </summary>
	public class Ship : LavishScriptObject, IShip
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

		private Int64? _id;
		/// <summary>
		/// Wrapper for the ID member of this ship type. This is the same as our Entity ID.
		/// </summary>
		public Int64 ID
		{
			get
			{
				if (_id == null)
					_id = this.GetInt64FromLSO("ID");
				return _id.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of the ship type.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
		}

		private double? _capacitor;
		/// <summary>
		/// Wrapper for the Capacitor member of the ship type.
		/// </summary>
		public double Capacitor
		{
			get
			{
				if (_capacitor == null)
					_capacitor = this.GetDoubleFromLSO("Capacitor");
				return _capacitor.Value;
			}
		}

		private double? _maxCapacitor;
		/// one sec<summary>
		/// Wrapper for the MaxCapacitor member of the ship type.
		/// </summary>
		public double MaxCapacitor
		{
			get
			{
				if (_maxCapacitor == null)
					_maxCapacitor = this.GetDoubleFromLSO("MaxCapacitor");
				return _maxCapacitor.Value;
			}
		}

		private double? _capacitorPct;
		/// <summary>
		/// Wrapper for the CapacitorPct member of the ship type.
		/// </summary>
		public double CapacitorPct
		{
			get
			{
				if (_capacitorPct == null)
					_capacitorPct = this.GetDoubleFromLSO("CapacitorPct");
				return _capacitorPct.Value;
			}
		}

		private double? _shield;
		/// <summary>
		/// Wrapper for the Shield member of the ship type.
		/// </summary>
		public double Shield
		{
			get
			{
				if (_shield == null)
					_shield = this.GetDoubleFromLSO("Shield");
				return _shield.Value;
			}
		}

		private double? _maxShield;
		/// <summary>
		/// Wrapper for the MaxShield member of the ship type.
		/// </summary>
		public double MaxShield
		{
			get
			{
				if (_maxShield == null)
					_maxShield = this.GetDoubleFromLSO("MaxShield");
				return _maxShield.Value;
			}
		}

		private double? _shieldPct;
		/// <summary>
		/// Wrapper for the ShieldPct member of the ship type.
		/// </summary>
		public double ShieldPct
		{
			get
			{
				if (_shieldPct == null)
					_shieldPct = this.GetDoubleFromLSO("ShieldPct");
				return _shieldPct.Value;
			}
		}

		private double? _armor;
		/// <summary>
		/// Wrapper for the Armor member of the ship type.
		/// </summary>
		public double Armor
		{
			get
			{
				if (_armor == null)
					_armor = this.GetDoubleFromLSO("Armor");
				return _armor.Value;
			}
		}

		private double? _maxArmor;
		/// <summary>
		/// Wrapper for the MaxArmor member of the ship type.
		/// </summary>
		public double MaxArmor
		{
			get
			{
				if (_maxArmor == null)
					_maxArmor = this.GetDoubleFromLSO("MaxArmor");
				return _maxArmor.Value;
			}
		}

		private double? _armorPct;
		/// <summary>
		/// Wrapper for the ArmorPct member of the ship type.
		/// </summary>
		public double ArmorPct
		{
			get
			{
				if (_armorPct == null)
					_armorPct = this.GetDoubleFromLSO("ArmorPct");

				return _armorPct.Value;
			}
		}

		private double? _structure;
		/// <summary>
		/// Wrapper for the Structure member of the ship type.
		/// </summary>
		public double Structure
		{
			get
			{
				if (_structure == null)
					_structure = this.GetDoubleFromLSO("Structure");
				return _structure.Value;
			}
		}

		private double? _maxStructure;
		/// <summary>
		/// Wrapper for the MaxStructure member of the ship type.
		/// </summary>
		public double MaxStructure
		{
			get
			{
				if (_maxStructure == null)
					_maxStructure = this.GetDoubleFromLSO("MaxStructure");
				return _maxStructure.Value;
			}
		}

		private double? _structurePct;
		/// <summary>
		/// Wrapper for the StructurePct member of the ship type.
		/// </summary>
		public double StructurePct
		{
			get
			{
				if (_structurePct == null)
					_structurePct = this.GetDoubleFromLSO("StructurePct");
				return _structurePct.Value;
			}
		}

		private IItem _toItem;
		/// <summary>
		/// Wrapper for the Ship.ToItem member
		/// </summary>
		public IItem ToItem
		{
			get { return _toItem ?? (_toItem = new Item(GetMember("ToItem"))); }
		}

		private double? _cpuLoad;
		/// <summary>
		/// Wrapper for the CPULoad member of the ship type.
		/// </summary>
		public double CPULoad
		{
			get
			{
				if (_cpuLoad == null)
					_cpuLoad = this.GetDoubleFromLSO("CPULoad");
				return _cpuLoad.Value;
			}
		}

		private double? _cpuOutput;
		/// <summary>
		/// Wrapper for the CPUOutput member of the ship type.
		/// </summary>
		public double CPUOutput
		{
			get
			{
				if (_cpuOutput == null)
					_cpuOutput = this.GetDoubleFromLSO("CPUOutput");
				return _cpuOutput.Value;
			}
		}

		private double? _powerLoad;
		/// <summary>
		/// Wrapper for the PowerLoad member of the ship type.
		/// </summary>
		public double PowerLoad
		{
			get
			{
				if (_powerLoad == null)
					_powerLoad = this.GetDoubleFromLSO("PowerLoad");
				return _powerLoad.Value;
			}
		}

		private double? _powerOutput;
		/// <summary>
		/// Wrapper for the PowerOutput member of the ship type.
		/// </summary>
		public double PowerOutput
		{
			get
			{
				if (_powerOutput == null)
					_powerOutput = this.GetDoubleFromLSO("PowerOutput");
				return _powerOutput.Value;
			}
		}

		private double? _turretSlotsLeft;
		/// <summary>
		/// Wrapper for the TurretSlotsLeft member of the ship type.
		/// </summary>
		public double TurretSlotsLeft
		{
			get
			{
				if (_turretSlotsLeft == null)
					_turretSlotsLeft = this.GetDoubleFromLSO("TurretSlotsLeft");
				return _turretSlotsLeft.Value;
			}
		}

		private double? _heatCapacityHigh;
		/// <summary>
		/// Wrapper for the HeatCapacityHigh member of the ship type.
		/// </summary>
		public double HeatCapacityHigh
		{
			get
			{
				if (_heatCapacityHigh == null)
					_heatCapacityHigh = this.GetDoubleFromLSO("HeatCapacityHigh");
				return _heatCapacityHigh.Value;
			}
		}

		private double? _heatCapacityMedium;
		/// <summary>
		/// Wrapper for the HeatCapacityMedium member of the ship type.
		/// </summary>
		public double HeatCapacityMedium
		{
			get
			{
				if (_heatCapacityMedium == null)
					_heatCapacityMedium = this.GetDoubleFromLSO("HeatCapacityMedium");
				return _heatCapacityMedium.Value;
			}
		}

		private double? _heatCapacityLow;
		/// <summary>
		/// Wrapper for the HeatCapacityLow member of the ship type.
		/// </summary>
		public double HeatCapacityLow
		{
			get
			{
				if (_heatCapacityLow == null)
					_heatCapacityLow = this.GetDoubleFromLSO("HeatCapacityLow");
				return _heatCapacityLow.Value;
			}
		}

		private double? _rigSlots;
		/// <summary>
		/// Wrapper for the RigSlots member of the ship type.
		/// </summary>
		public double RigSlots
		{
			get
			{
				if (_rigSlots == null)
					_rigSlots = this.GetDoubleFromLSO("RigSlots");
				return _rigSlots.Value;
			}
		}

		private double? _rigSlotsLeft;
		/// <summary>
		/// Wrapper for the RigSlotsLeft member of the ship type.
		/// </summary>
		public double RigSlotsLeft
		{
			get
			{
				if (_rigSlotsLeft == null)
					_rigSlotsLeft = this.GetDoubleFromLSO("RigSlotsLeft");
				return _rigSlotsLeft.Value;
			}
		}

		private double? _scanSpeed;
		/// <summary>
		/// Wrapper for the ScanSpeed member of the ship type.
		/// </summary>
		public double ScanSpeed
		{
			get
			{
				if (_scanSpeed == null)
					_scanSpeed = this.GetDoubleFromLSO("ScanSpeed");
				return _scanSpeed.Value;
			}
		}

		private double? _maxTargetRange;
		/// <summary>
		/// Wrapper for the MaxTargetRange member of the ship type.
		/// </summary>
		public double MaxTargetRange
		{
			get
			{
				if (_maxTargetRange == null)
					_maxTargetRange = this.GetDoubleFromLSO("MaxTargetRange");
				return _maxTargetRange.Value;
			}
		}

		private double? _lowSlots;
		/// <summary>
		/// Wrapper for the LowSlots member of the ship type.
		/// </summary>
		public double LowSlots
		{
			get
			{
				if (_lowSlots == null)
					_lowSlots = this.GetDoubleFromLSO("LowSlots");
				return _lowSlots.Value;
			}
		}

		private double? _mediumSlots;
		/// <summary>
		/// Wrapper for the MediumSlots member of the ship type.
		/// </summary>
		public double MediumSlots
		{
			get
			{
				if (_mediumSlots == null)
					_mediumSlots = this.GetDoubleFromLSO("MediumSlots");
				return _mediumSlots.Value;
			}
		}

		private double? _highSlots;
		/// <summary>
		/// Wrapper for the HighSlots member of the ship type.
		/// </summary>
		public double HighSlots
		{
			get
			{
				if (_highSlots == null)
					_highSlots = this.GetDoubleFromLSO("HighSlots");
				return _highSlots.Value;
			}
		}

		private double? _radius;
		/// <summary>
		/// Wrapper for the Radius member of the ship type.
		/// </summary>
		public double Radius
		{
			get
			{
				if (_radius == null)
					_radius = this.GetDoubleFromLSO("Radius");
				return _radius.Value;
			}
		}

		private double? _techLevel;
		/// <summary>
		/// Wrapper for the TechLevel member of the ship type.
		/// </summary>
		public double TechLevel
		{
			get
			{
				if (_techLevel == null)
					_techLevel = this.GetDoubleFromLSO("TechLevel");
				return _techLevel.Value;
			}
		}

		private double? _heatLow;
		/// <summary>
		/// Wrapper for the HeatLow member of the ship type.
		/// </summary>
		public double HeatLow
		{
			get
			{
				if (_heatLow == null)
					_heatLow = this.GetDoubleFromLSO("HeatLow");
				return _heatLow.Value;
			}
		}

		private double? _heatMedium;
		/// <summary>
		/// Wrapper for the HeatMedium member of the ship type.
		/// </summary>
		public double HeatMedium
		{
			get
			{
				if (_heatMedium == null)
					_heatMedium = this.GetDoubleFromLSO("HeatMedium");
				return _heatMedium.Value;
			}
		}

		private double? _heatHigh;
		/// <summary>
		/// Wrapper for the HeatHigh member of the ship type.
		/// </summary>
		public double HeatHigh
		{
			get
			{
				if (_heatHigh == null)
					_heatHigh = this.GetDoubleFromLSO("HeatHigh");
				return _heatHigh.Value;
			}
		}

		private double? _maxVelocity;
		/// <summary>
		/// Wrapper for the MaxVelocity member of the ship type.
		/// </summary>
		public double MaxVelocity
		{
			get
			{
				if (_maxVelocity == null)
					_maxVelocity = this.GetDoubleFromLSO("MaxVelocity");
				return _maxVelocity.Value;
			}
		}

		private double? _scanResolution;
		/// <summary>
		/// Wrapper for the ScanResolution member of the ship type.
		/// </summary>
		public double ScanResolution
		{
			get
			{
				if (_scanResolution == null)
					_scanResolution = this.GetDoubleFromLSO("ScanResolution");
				return _scanResolution.Value;
			}
		}

		private double? _scanRadarStrength;
		/// <summary>
		/// Wrapper for the ScanRadarStrength member of the ship type.
		/// </summary>
		public double ScanRadarStrength
		{
			get
			{
				if (_scanRadarStrength == null)
					_scanRadarStrength = this.GetDoubleFromLSO("ScanRadarStrength");
				return _scanRadarStrength.Value;
			}
		}

		private double? _agility;
		/// <summary>
		/// Wrapper for the Agility member of the ship type.
		/// </summary>
		public double Agility
		{
			get
			{
				if (_agility == null)
					_agility = this.GetDoubleFromLSO("Agility");
				return _agility.Value;
			}
		}

		private double? _launcherSlotsLeft;
		/// <summary>
		/// Wrapper for the LauncherSlotsLeft member of the ship type.
		/// </summary>
		public double LauncherSlotsLeft
		{
			get
			{
				if (_launcherSlotsLeft == null)
					_launcherSlotsLeft = this.GetDoubleFromLSO("LauncherSlotsLeft");
				return _launcherSlotsLeft.Value;
			}
		}

		private double? _capacitorRechargeRate;
		/// <summary>
		/// Wrapper for the CapacitorRechargeRate member of the ship type.
		/// </summary>
		public double CapacitorRechargeRate
		{
			get
			{
				if (_capacitorRechargeRate == null)
					_capacitorRechargeRate = this.GetDoubleFromLSO("CapacitorRechargeRate");
				return _capacitorRechargeRate.Value;
			}
		}

		private double? _shieldRechargeRate;
		/// <summary>
		/// Wrapper for the ShieldRechargeRate member of the ship type.
		/// </summary>
		public double ShieldRechargeRate
		{
			get
			{
				if (_shieldRechargeRate == null)
					_shieldRechargeRate = this.GetDoubleFromLSO("ShieldRechargeRate");
				return _shieldRechargeRate.Value;
			}
		}

		private double? _signatureRadius;
		/// <summary>
		/// Wrapper for the SignatureRadius member of the ship type.
		/// </summary>
		public double SignatureRadius
		{
			get
			{
				if (_signatureRadius == null)
					_signatureRadius = this.GetDoubleFromLSO("SignatureRadius");
				return _signatureRadius.Value;
			}
		}

		private double? _maxLockedTargets;
		/// <summary>
		/// See also the 'MaxLockedTargets' member of the character datatype for the character's restrictions on locked targets.
		/// </summary>
		public double MaxLockedTargets
		{
			get
			{
				if (_maxLockedTargets == null)
					_maxLockedTargets = this.GetDoubleFromLSO("MaxLockedTargets");
				return _maxLockedTargets.Value;
			}
		}
		#endregion

		#region Cargo

		private double? _cargoCapacity;
		/// <summary>
		/// Wrapper for the CargoCapacity member of the ship type.
		/// </summary>
		public double CargoCapacity
		{
			get
			{
				if (_cargoCapacity == null)
					_cargoCapacity = this.GetDoubleFromLSO("CargoCapacity");
				return _cargoCapacity.Value;
			}
		}

		private double? _usedCargoCapacity;
		/// <summary>
		/// Wrapper for the UsedCargoCapacity member of the ship type.
		/// </summary>
		public double UsedCargoCapacity
		{
			get
			{
				if (_usedCargoCapacity == null)
					_usedCargoCapacity = this.GetDoubleFromLSO("UsedCargoCapacity");
				return _usedCargoCapacity.Value;
			}
		}

	    /// <summary>
	    /// Wrapper for the Cargo member of the ship type.
	    /// </summary>
	    /// <param name="i"></param>
	    /// <returns></returns>
	    public IItem Cargo(int i)
		{
			return new Item(GetMember("Cargo", i.ToString()));
		}

	    /// <summary>
	    /// Wrapper for the Cargo member of the ship type.
	    /// </summary>
	    /// <param name="name"></param>
	    /// <returns></returns>
	    public IItem Cargo(string name)
		{
			return new Item(GetMember("Cargo", name));
		}

		private List<IItem> _cargo;

	    /// <summary>
	    /// Wrapper for the GetCargo member of the ship type.
	    /// </summary>
	    /// <returns></returns>
	    public List<IItem> GetCargo()
		{
			Tracing.SendCallback("Ship.GetCargo");
			return _cargo ?? (_cargo = Util.GetListFromMethod<IItem>(this, "GetCargo", "item"));
		}

		private bool? _hasOreHold;
		/// <summary>
		/// Wrapper for the HasOreHold member of the ship type.
		/// </summary>
		public bool HasOreHold
		{
			get
			{
				if (_hasOreHold == null)
					_hasOreHold = this.GetBoolFromLSO("HasOreHold");
				return _hasOreHold.Value;
			}
		}

		private List<IItem> _oreHoldCargo;

	    /// <summary>
	    /// Wrapper for the GetOreHoldCargo method of the ship type
	    /// </summary>
	    /// <returns></returns>
	    public List<IItem> GetOreHoldCargo()
		{
			return _oreHoldCargo ?? (_oreHoldCargo = Util.GetListFromMethod<IItem>(this, "GetOreHoldCargo", "item"));
		}
		#endregion

		#region Drone

		private double? _droneBayCapacity;
		/// <summary>
		/// Wrapper for the DronebayCapacity member of the ship type.
		/// </summary>
		public double DronebayCapacity
		{
			get
			{
				if (_droneBayCapacity == null)
					_droneBayCapacity = this.GetDoubleFromLSO("DronebayCapacity");
				return _droneBayCapacity.Value;
			}
		}

		private double? _usedDroneBayCapacity;
		/// <summary>
		/// Wrapper for the UsedDronebayCapacity member of the ship type.
		/// </summary>
		public double UsedDronebayCapacity
		{
			get
			{
				if (_usedDroneBayCapacity == null)
					_usedDroneBayCapacity = this.GetDoubleFromLSO("UsedDronebayCapacity");
				return _usedDroneBayCapacity.Value;
			}
		}

	    /// <summary>
	    /// Wrapper for the Drone member of the ship type.
	    /// </summary>
	    /// <param name="i"></param>
	    /// <returns></returns>
	    public IItem Drone(int i)
		{
			return new Item(GetMember("Drone", i.ToString()));
		}

	    /// <summary>
	    /// Wrapper for the Drone member of the ship type.
	    /// </summary>
	    /// <param name="name"></param>
	    /// <returns></returns>
	    public IItem Drone(string name)
		{
			return new Item(GetMember("Drone", name));
		}

		private List<IItem> _drones;

	    /// <summary>
	    /// Wrapper for the GetDrones member of the ship type.
	    /// </summary>
	    /// <returns></returns>
	    public List<IItem> GetDrones()
		{
			Tracing.SendCallback("Ship.GetDrones", string.Empty);
			return _drones ?? (_drones = Util.GetListFromMethod<IItem>(this, "GetDrones", "item"));
		}
		#endregion

		#region Space
		/// <summary>
		/// Retrieve a module based on its slot
		/// Note: Must be in space.
		/// </summary>
		public IModule Module(SlotType slottype, int number)
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
	    public IModule Module(string slotname)
		{
			return new Module(GetMember("Module", slotname));
		}

		/// <summary>
		/// Retreive a module item based on its slot.  Usable both
		/// in station and in space.
		/// </summary>
		public IItem ModuleItem(SlotType slottype, int number)
		{
			return Module(slottype, number).ToItem;
		}

	    /// <summary>
	    /// Wrapper for the ModuleItem member of the ship type.
	    /// </summary>
	    /// <param name="slotname"></param>
	    /// <returns></returns>
	    public IItem ModuleItem(string slotname)
		{
			return Module(slotname).ToItem;
		}

		private List<IModule> _modules;

	    /// <summary>
	    /// Modules fit to the ship
	    /// Note: Must be in space.
	    /// </summary>
	    public List<IModule> GetModules()
		{
			Tracing.SendCallback("Ship.GetModules");
			return _modules ?? (_modules = Util.GetListFromMethod<IModule>(this, "GetModules", "module"));
		}
		#endregion

	    private Scanners _scanners;
        /// <summary>
        /// Wraps the Scanners member of the Ship datatype.
        /// </summary>
	    public Scanners Scanners
	    {
            get { return _scanners ?? (_scanners = new Scanners(GetMember("Scanners"))); }
	    }
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the StackAllCargo method of the ship type.
		/// </summary>
		/// <returns></returns>
		public bool StackAllCargo()
		{
			// TODO - Remove this when stealthbot is updated.
			Tracing.SendCallback("Ship.StackAllCargo - Redirecting to EVEWindow");
			var wnd = new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", "ByName", ID.ToString()));
			return wnd.StackAll();
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
		/// Wrapper for the Open method of the ship type.
		/// </summary>
		/// <returns></returns>
		public bool Open()
		{
			Tracing.SendCallback("Ship.Open");
			return ExecuteMethod("Open");
		}
		#endregion
	}
}
