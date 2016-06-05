using System;
using System.Collections.Generic;
using EVE.ISXEVE.Extensions;
using EVE.ISXEVE.Enums;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the character type.
	/// </summary>
	public class Character : Pilot
	{
		#region Constructors
		/// <summary>
		/// Character copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Character(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Character constructor.  Returns  object.
		/// </summary>
		public Character()
			: base(LavishScript.Objects.GetObject("Me"))
		{
		}
		#endregion

		#region LavishScript Members

		private Ship _ship;
		/// <summary>
		/// Wrapper for the Ship member of the character type.
		/// </summary>
		public Ship Ship
		{
			get
			{
				return _ship ?? (_ship = new Ship(GetMember("Ship")));
			}
		}

		/// <summary>
		/// Your current standing towards any CharID, CorporationID, or AllianceID. All 3 IDs are required. 0 or -1 are valid arguments for those without corporation or alliance. 
		/// </summary>
		/// <param name="charID">CharID</param>
		/// <param name="corpID">CorporationID</param>
		/// <param name="allianceID">AllianceID</param>
		/// <returns></returns>
		public Standing StandingTo(Int64 charID, Int64 corpID, int allianceID)
		{
			return new Standing(GetMember("StandingTo", charID.ToString(), corpID.ToString(), allianceID.ToString()));
		}

		private bool? _autoPilotOn;
		/// <summary>
		/// Wrapper for the AutoPilotOn member of the character type.
		/// </summary>
		public bool AutoPilotOn
		{
			get
			{
				if (_autoPilotOn == null)
					_autoPilotOn = this.GetBool("AutoPilotOn");
				return _autoPilotOn.Value;
			}
		}

		private List<ActiveDrone> _activeDrones;
		/// <summary>
		/// Wrapper for the GetActiveDrones member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<ActiveDrone> GetActiveDrones()
		{
			Tracing.SendCallback("Character.GetActiveDrones");
			return _activeDrones ?? (_activeDrones = Util.GetListFromMethod<ActiveDrone>(this, "GetActiveDrones", "activedrone"));
		}

		private List<long> _activeDroneIds;
		/// <summary>
		/// Wrapper for the GetActiveDroneIDs member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<long> GetActiveDroneIDs()
		{
			Tracing.SendCallback("Character.GetActiveDroneIDs");
			return _activeDroneIds ?? (_activeDroneIds = Util.GetListFromMethod<long>(this, "GetActiveDroneIDs", "int64"));
		}

		#region SelfCorpLocation

		private int? _regionId;
		/// <summary>
		/// Wrapper for the RegionID member of the character type.
		/// </summary>
		public int RegionID
		{
			get
			{
				if (_regionId == null)
					_regionId = this.GetInt("RegionID");
				return _regionId.Value;
			}
		}

		private int? _constellationId;
		/// <summary>
		/// Wrapper for the ConstellationID member of the character type.
		/// </summary>
		public int ConstellationID
		{
			get
			{
				if (_constellationId == null)
					_constellationId = this.GetInt("ConstellationID");
				return _constellationId.Value;
			}
		}

		private int? _solarSystemId;
		/// <summary>
		/// Wrapper for the SolarSystemID member of the character type.
		/// </summary>
		public int SolarSystemID
		{
			get
			{
				if (_solarSystemId == null)
					_solarSystemId = this.GetInt("SolarSystemID");
				return _solarSystemId.Value;
			}
		}

		private Fleet _fleet;
		/// <summary>
		/// Wrapper for the Fleet member of the character type.
		/// </summary>
		public Fleet Fleet
		{
			get { return _fleet ?? (_fleet = new Fleet(GetMember("Fleet"))); }
		}

		private Int64? _shipId;
		/// <summary>
		/// Wrapper for the ShipID member of the character type.
		/// </summary>
		public Int64 ShipID
		{
			get
			{
				if (_shipId == null)
					_shipId = this.GetInt64("ShipID");
				return _shipId.Value;
			}
		}

		private bool? _inStation;
		/// <summary>
		/// This does not change state until you are fully completed transitioning; 
		/// for example, if you are undocking, it is TRUE until you actually arrive in space.
		/// </summary>
		public bool InStation
		{
			get
			{
				if (_inStation == null)
					_inStation = this.GetBool("InStation");
				return _inStation.Value;
			}
		}

		private bool? _inSpace;
		/// <summary>
		/// Wrapper for the InSpace member of the character type.
		/// </summary>
		public bool InSpace
		{
			get
			{
				if (_inSpace == null)
					_inSpace = this.GetBool("InSpace");
				return _inSpace.Value;
			}
		}

		private int? _stationId;
		/// <summary>
		/// Wrapper for the StationID member of the character type.
		/// </summary>
		public int StationID
		{
			get
			{
				if (_stationId == null)
					_stationId = this.GetInt("StationID");
				return _stationId.Value;
			}
		}

		/// <summary>
		/// Wrapper for the Intelligence member of the character type.
		/// </summary>
		public double Intelligence
		{
			get { return this.GetDouble("Intelligence"); }
		}

		/// <summary>
		/// Wrapper for the Perception member of the character type.
		/// </summary>
		public double Perception
		{
			get { return this.GetDouble("Perception"); }
		}

		/// <summary>
		/// Wrapper for the Charisma member of the character type.
		/// </summary>
		public double Charisma
		{
			get { return this.GetDouble("Charisma"); }
		}

		private Wallet _wallet;
		public Wallet Wallet
		{
			get { return _wallet ?? (_wallet = new Wallet(GetMember("Wallet"))); }
		}

		/// <summary>
		/// Wrapper for the Willpower member of the character type.
		/// </summary>
		public double Willpower
		{
			get { return this.GetDouble("Willpower"); }
		}

		/// <summary>
		/// Wrapper for the Memory member of the character type.
		/// </summary>
		public double Memory
		{
			get { return this.GetDouble("Memory"); }
		}

		private double? _maxLockedTargets;
		/// <summary>
		/// See also the 'MaxLockedTargets' member of the ship datatype for 
		/// the ship restriction on locked targets 
		/// </summary>
		public double MaxLockedTargets
		{
			get
			{
				if (_maxLockedTargets == null)
					_maxLockedTargets = this.GetDouble("MaxLockedTargets");
				return _maxLockedTargets.Value;
			}
		}

		/// <summary>
		/// Wrapper for the MiningDroneAmountBonus member of the character type.
		/// </summary>
		public double MiningDroneAmountBonus
		{
			get { return this.GetDouble("MiningDroneAmountBonus"); }
		}

		private double? _maxActiveDrones;
		/// <summary>
		/// Wrapper for the MaxActiveDrones member of the character type.
		/// </summary>
		public double MaxActiveDrones
		{
			get
			{
				if (_maxActiveDrones == null)
					_maxActiveDrones = this.GetDouble("MaxActiveDrones");
				return _maxActiveDrones.Value;
			}
		}

		private double? _droneControlDistance;
		/// <summary>
		/// Wrapper for the DroneControlDistance member of the character type.
		/// </summary>
		public double DroneControlDistance
		{
			get
			{
				if (_droneControlDistance == null)
					_droneControlDistance = this.GetDouble("DroneControlDistance");
				return _droneControlDistance.Value;
			}
		}

		/// <summary>
		/// Wrapper for the MaxJumpClones member of the character type.
		/// </summary>
		public double MaxJumpClones
		{
			get
			{
				return this.GetDouble("MaxJumpClones");
			}
		}
		#endregion

		private Station _station;
		/// <summary>
		/// Wrapper for the Station member of the character type.
		/// </summary>
		public Station Station
		{
			get { return _station ?? (_station = new Station(GetMember("Station"))); }
		}

		#region Skills
		/// <summary>
		/// Wrapper for the Skill member of the character type.
		/// </summary>
		/// <param name="Name"></param>
		/// <returns></returns>
		public Skill Skill(string Name)
		{
			return new Skill(GetMember("Skill", Name));
		}

		/// <summary>
		/// Wrapper for the Skill member of the character type.
		/// </summary>
		/// <param name="Index"></param>
		/// <returns></returns>
		public Skill Skill(int Index)
		{
			return new Skill(GetMember("Skill", Index.ToString()));
		}

		private Skill _skillCurrentlyTraining;
		/// <summary>
		/// Wrapper for the SkillCurrentlyTraining member of the character type.
		/// </summary>
		/// <returns></returns>
		public Skill SkillCurrentlyTraining
		{
			get { return _skillCurrentlyTraining ?? (_skillCurrentlyTraining = new Skill(GetMember("SkillCurrentlyTraining"))); }
		}

		private List<Skill> _skills;
		/// <summary>
		/// Wrapper for the GetSkills member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Skill> GetSkills()
		{
			return _skills ?? (_skills = Util.GetListFromMethod<Skill>(this, "GetSkills", "skill"));
		}

		private double? _skillPoints;
		/// <summary>
		/// Wrapper for the SkillPoints member of the character type.
		/// </summary>
		public double SkillPoints
		{
			get
			{
				if (_skillPoints == null)
					_skillPoints = this.GetDouble("SkillPoints");
				return _skillPoints.Value;
			}
		}

		private double? _skillQueueLength;
		/// <summary>
		/// *** Note:  The return value from this datatype member does not correlate, in any way, with the way that humans typically
		/// ***        tell time.   However, it is useful in the following contexts:
		/// ***        1.  If it's >0, then you are still training.  If it's 0 or NULL, then you're not training.  Etc...
		/// ***        2.  echo "My training queue will end at {$EVETime[${Math.Calc64[${Me.SkillQueueLength}+${EVETime.AsInt64}]}]}"
		/// </summary>
		public double SkillQueueLength
		{
			get
			{
				if (_skillQueueLength == null)
					_skillQueueLength = this.GetDouble("SkillQueueLength");
				return _skillQueueLength.Value;
			}
		}
		#endregion

		#region Targeting

		private Entity _activeTarget;
		/// <summary>
		/// Wrapper for the ActiveTarget member of the character type.
		/// </summary>
		public Entity ActiveTarget
		{
			get { return _activeTarget ?? (_activeTarget = new Entity(GetMember("ActiveTarget"))); }
		}

		private List<Entity> _targets;
		/// <summary>
		/// Entities you are currently locked on
		/// </summary>
		public List<Entity> GetTargets()
		{
			Tracing.SendCallback("Character.GetTargets");
			return _targets ?? (_targets = Util.GetListFromMethod<Entity>(this, "GetTargets", "entity"));
		}

		/// <summary>
		/// Entities you are currently locked on
		/// Grabs one specific target by index (0 based)
		/// </summary>
		public Entity GetTarget(int i)
		{
			Tracing.SendCallback("Character.GetTargets", i.ToString());
			return Util.GetFromIndexMethod<Entity>(this, "GetTargets", "entity", i);
		}

		private List<Entity> _targeting;
		/// <summary>
		/// Entities currently being targeted by you.
		/// </summary>
		public List<Entity> GetTargeting()
		{
			Tracing.SendCallback("Character.GetTargeting");
			return _targeting ?? (_targeting = Util.GetListFromMethod<Entity>(this, "GetTargeting", "entity"));
		}

		private List<Entity> _targetedBy;
		/// <summary>
		/// Entities targetting you.
		/// </summary>
		public List<Entity> GetTargetedBy()
		{
			Tracing.SendCallback("Character.GetTargetedBy");
			return _targetedBy ?? (_targetedBy = Util.GetListFromMethod<Entity>(this, "GetTargetedBy", "entity"));
		}
		#endregion

		private List<Item> _hangarItems;
		/// <summary>
		/// Wrapper for the GetHangarItems member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetHangarItems()
		{
			Tracing.SendCallback("Character.GetHangarItems");
			return _hangarItems ?? (_hangarItems = Util.GetListFromMethod<Item>(this, "GetHangarItems", "item"));
		}

		private List<Item> _hangarShips;
		/// <summary>
		/// Wrapper for the GetHangarShips member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetHangarShips()
		{
			Tracing.SendCallback("Character.GetHangarShips");
			return _hangarShips ?? (_hangarShips = Util.GetListFromMethod<Item>(this, "GetHangarShips", "item"));
		}

		private List<Item> _corpHangarItems;
		/// <summary>
		/// Wrapper for the GetCorpHangarItems member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCorpHangarItems()
		{
			Tracing.SendCallback("Character.GetCorpHangarItems");
			return _corpHangarItems ?? (_corpHangarItems = Util.GetListFromMethod<Item>(this, "GetCorpHangarItems", "item"));
		}

		/// <summary>
		/// Wrapper for the GetCorpHangarItems member of the character type.
		/// </summary>
		/// <param name="corporationFolderNumber">The corporation folder number.</param>
		/// <returns></returns>
		public List<Item> GetCorpHangarItems(int corporationFolderNumber)
		{
			if (corporationFolderNumber < 1 || corporationFolderNumber > 7)
				throw new ArgumentException("Corporation folder number must between 1 and 7, inclusive.", "corporationFolderNumber");

			Tracing.SendCallback("Character.GetCorpHangarItems");
			return Util.GetListFromMethod<Item>(this, "GetCorpHangarItems", "item",
												string.Format("Corporation Folder {0}", corporationFolderNumber));
		}

		private List<Item> _corpHangarShips;
		/// <summary>
		/// Wrapper for the GetCorpHangarShips member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCorpHangarShips()
		{
			return _corpHangarShips ?? (_corpHangarShips = Util.GetListFromMethod<Item>(this, "GetCorpHangarShips", "item"));
		}

		private List<Item> _assets;
		/// <summary>
		/// 1. GetAssets[index:item] (int type) [Retrieves all items that are in your assets window]
		/// </summary>
		public List<Item> GetAssets()
		{
			Tracing.SendCallback("Character.GetAssets");
			return _assets ?? (_assets = Util.GetListFromMethod<Item>(this, "GetAssets", "item"));
		}

		/// <summary>
		/// GetAssets[index:item,#] (int type) [Retrieves all items that match the StationID# given]
		/// </summary>
		public List<Item> GetAssets(Int64 StationID)
		{
			Tracing.SendCallback("Character.GetAssets", StationID);
			return Util.GetListFromMethod<Item>(this, "GetAssets", "item", StationID.ToString());
		}

		private List<Int64> _stationsWithAssets;
		/// <summary>
		/// 2. GetStationsWithAssets[&lt;index:int&gt;] (int type) [Retrieves a list of StationID#s where you currently have assets.]
		/// </summary>
		public List<Int64> GetStationsWithAssets()
		{
			Tracing.SendCallback("Character.GetStationsWithAssets");
			return _stationsWithAssets ?? (_stationsWithAssets = Util.GetListFromMethod<Int64>(this, "GetStationsWithAssets", "int64"));
		}

		private List<MyOrder> _myOrders;
		/// <summary>
		///   1. GetMyOrders[&lt;index:myorder&gt;]           (int type) {retrieves all "My Orders" cached by your client}          
		///      GetMyOrders[&lt;index:myorder&gt;,#]         (int type) {retrieves all "My Orders" cached by your client for the given TypeID#}
		///      GetMyOrders[&lt;index:myorder&gt;,"Buy"]     (int type) {retrieves all *buy* "My Orders" cached by your client}
		///      GetMyOrders[&lt;index:myorder&gt;,"Buy",#]   (int type) {retrieves all *buy* "My Orders" cached by your client for the given TypeID#}
		///      GetMyOrders[&lt;index:myorder&gt;,"Sell"]    (int type) {retrieves all *sell* "My Orders" cached by your client}
		///      GetMyOrders[&lt;index:myorder&gt;,"Sell",#]  (int type) {retrieves all *sell* "My Orders" cached by your client for the given TypeID#}        
		/// </summary>
		public List<MyOrder> GetMyOrders()
		{
			Tracing.SendCallback("Character.GetMyOrders");
			return _myOrders ?? (_myOrders = Util.GetListFromMethod<MyOrder>(this, "GetMyOrders", "myorder"));
		}

		/// <summary>
		/// Wrapper for the GetMyOrders member of the character type.
		/// </summary>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public List<MyOrder> GetMyOrders(int typeID)
		{
			Tracing.SendCallback("Character.GetMyOrders", typeID);
			return Util.GetListFromMethod<MyOrder>(this, "GetMyOrders", "myorder", typeID.ToString());
		}

		/// <summary>
		/// Wrapper for the GetMyOrders member of the character type.
		/// </summary>
		/// <param name="orderType"></param>
		/// <returns></returns>
		public List<MyOrder> GetMyOrders(OrderType orderType)
		{
			Tracing.SendCallback("Character.GetMyOrders", orderType);
			return Util.GetListFromMethod<MyOrder>(this, "GetMyOrders", "myorder", orderType.ToString());
		}

		/// <summary>
		/// Wrapper for the GetMyOrders member of the character type.
		/// </summary>
		/// <param name="orderType"></param>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public List<MyOrder> GetMyOrders(OrderType orderType, int typeID)
		{
			Tracing.SendCallback("Character.GetMyOrders", orderType, typeID);
			return Util.GetListFromMethod<MyOrder>(this, "GetMyOrders", "myorder", orderType.ToString(), typeID.ToString());
		}

		private int? _targetCount;
		/// <summary>
		/// Wrapper for Me.TargetCount
		/// </summary>
		public int TargetCount
		{
			get
			{
				if (_targetCount == null)
					_targetCount = this.GetInt("TargetCount");
				return _targetCount.Value;
			}
		}

		private int? _targetingCount;
		/// <summary>
		/// Wrapper for Me.TargetingCount
		/// </summary>
		public int TargetingCount
		{
			get
			{
				if (_targetingCount == null)
					_targetingCount = this.GetInt("TargetingCount");
				return _targetingCount.Value;
			}
		}

		private int? _targetedByCount;
		/// <summary>
		/// Wrapper for Me.TargetedByCount
		/// </summary>
		public int TargetedByCount
		{
			get
			{
				if (_targetedByCount == null)
					_targetedByCount = this.GetInt("TargetedByCount");
				return _targetedByCount.Value;
			}
		}

		/// <summary>
		/// Index starts at 1.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public Being ContactByIndex(int index)
		{
			return new Being(GetMember("Contact", index.ToString()));
		}

		public Being ContactById(int id)
		{
			return new Being(GetMember("Contact", "id", id.ToString()));
		}

		public Being ContactByName(string name)
		{
			return new Being(GetMember("Contact", name));
		}
		#endregion

		#region Methods
		/// <summary>
		/// Argument is a PERCENTAGE of your max velocity.
		/// </summary>
		public bool SetVelocity(int SpeedAsPercentage)
		{
			Tracing.SendCallback("Character.SetVelocity", SpeedAsPercentage.ToString());
			return ExecuteMethod("SetVelocity", SpeedAsPercentage.ToString());
		}

		/// <summary>
		/// Wrapper for the SetCorpStanding method of the character type.
		/// </summary>
		/// <param name="CorpID"></param>
		/// <param name="Standing"></param>
		/// <param name="Reason"></param>
		/// <returns></returns>
		public bool SetCorpStanding(int CorpID, float Standing, string Reason)
		{
			Tracing.SendCallback("Character.SetCorpStanding", CorpID, Standing, Reason);
			return ExecuteMethod("SetCorpStanding", CorpID.ToString(), Standing.ToString(), Reason);
		}

		/// <summary>
		/// Wrapper for the SetPilotStanding method of the character type.
		/// </summary>
		/// <param name="CharID"></param>
		/// <param name="Standing"></param>
		/// <param name="Reason"></param>
		/// <returns></returns>
		public bool SetPilotStanding(Int64 CharID, float Standing, string Reason)
		{
			Tracing.SendCallback("Character.SetPilotStanding", CharID, Standing, Reason);
			return ExecuteMethod("SetPilotStanding", CharID.ToString(), Standing.ToString(), Reason);
		}

		/// <summary>
		/// Wrapper for the StackAllHangarItems method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool StackAllHangarItems()
		{
			// TODO - Remove this when stealthbot is updated.
			Tracing.SendCallback("Character.StackAllHangarItems - Redirecting to EVEWindow");
			EVEWindow wnd = new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", "ByName", "hangarFloor"));
			return wnd.StackAll();
		}

		/// <summary>
		///  2. UpdateMyOrders   
		///     ~ This method should be called before any calling of "GetMyOrders".
		/// </summary>
		public bool UpdateMyOrders()
		{
			Tracing.SendCallback("Character.UpdateMyOrders");
			return ExecuteMethod("UpdateMyOrders");
		}

		private List<Attacker> _attackers;
		/// <summary>
		/// Get a list of Attackers.
		/// Note: This will return a null list if there are no attackers.
		/// </summary>
		/// <returns></returns>
		public List<Attacker> GetAttackers()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.GetAttackers");

			return _attackers ?? (_attackers = Util.GetListFromMethod<Attacker>(this, "GetAttackers", "attacker"));
		}

		private List<Entity> _attackersAsEntities;
		/// <summary>
		/// Get a list of Attackers as entities.
		/// </summary>
		/// <returns></returns>
		public List<Entity> GetAttackersAsEntities()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.GetAttackersAsEntities");

			return _attackersAsEntities ?? (_attackersAsEntities = Util.GetListFromMethod<Entity>(this, "GetAttackers", "entity"));
		}

		private List<Jammer> _jammers;
		/// <summary>
		/// Get a list of Jammers on us.
		/// </summary>
		/// <returns></returns>
		public List<Jammer> GetJammers()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.GetAttackers");

			return _jammers ?? (_jammers = Util.GetListFromMethod<Jammer>(this, "GetJammers", "jammer"));
		}
		#endregion

	}

	/// <summary>
	/// The ubiquitous Me object.  Alias for a Character object.
	/// </summary>
	public class Me : Character
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public Me()
			: base()
		{
		}
	}
}
