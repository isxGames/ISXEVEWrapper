using System;
using System.Collections.Generic;
using InnerSpaceAPI;
using LavishScriptAPI;
using Extensions;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the character type.
	/// </summary>
	public class Character : LavishScriptPersistentObject
	{
		#region Constructors
		/// <summary>
		/// Character copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Character(LavishScriptPersistentObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Character constructor.  Returns persistent object.
		/// </summary>
		public Character()
			: base(LavishScript.Objects.GetPersistentObject("Me"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ToEntity member of the character type.
		/// </summary>
		public Entity ToEntity
		{
			get
			{
				return new Entity(GetMember("ToEntity"));
			}
		}

		/// <summary>
		/// Wrapper for the ToPilot member of the character type.
		/// </summary>
		public Pilot ToPilot
		{
			get
			{
				return new Pilot(GetMember("ToPilot"));
			}
		}

		/// <summary>
		/// Wrapper for the Ship member of the character type.
		/// </summary>
		public Ship Ship
		{
			get
			{
				return new Ship(GetMember("Ship"));
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

		/// <summary>
		/// Wrapper for the AutoPilotOn member of the character type.
		/// </summary>
		public bool AutoPilotOn
		{
			get { return this.GetBoolFromLSO("AutoPilotOn"); }
		}

		/// <summary>
		/// Wrapper for the GetActiveDrones member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<ActiveDrone> GetActiveDrones()
		{
			Tracing.SendCallback("Character.GetActiveDrones");
			return Util.GetListFromMethod<ActiveDrone>(this, "GetActiveDrones", "activedrone");
		}

		/// <summary>
		/// Wrapper for the GetActiveDroneIDs member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<long> GetActiveDroneIDs()
		{
			Tracing.SendCallback("Character.GetActiveDroneIDs");
			return Util.GetListFromMethod<long>(this, "GetActiveDroneIDs", "int64");
		}

		#region SelfCorpLocation
		/// <summary>
		/// Wrapper for the Name member of the character type.
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

        /// <summary>
        /// Wrapper for the Character Corp member.
        /// </summary>
	    public Corporation Corp
	    {
	        get
	        {
	            return new Corporation(GetMember("Corp"));
	        }
	    }

		/// <summary>
		/// Wrapper for the Alliance member of the character type.
		/// </summary>
		public string Alliance
		{
			get { return this.GetStringFromLSO("Alliance"); }
		}

		/// <summary>
		/// Wrapper for the AllianceID member of the character type.
		/// </summary>
		public int AllianceID
		{
			get { return this.GetIntFromLSO("AllianceID"); }
		}

		/// <summary>
		/// Wrapper for the AllianceTicker member of the character type.
		/// </summary>
		public string AllianceTicker
		{
			get { return this.GetStringFromLSO("AllianceTicker"); }
		}

		/// <summary>
		/// Wrapper for the RegionID member of the character type.
		/// </summary>
		public int RegionID
		{
			get { return this.GetIntFromLSO("RegionID"); }
		}

		/// <summary>
		/// Wrapper for the ConstellationID member of the character type.
		/// </summary>
		public int ConstellationID
		{
			get { return this.GetIntFromLSO("ConstellationID"); }
		}

		/// <summary>
		/// Wrapper for the SolarSystemID member of the character type.
		/// </summary>
		public int SolarSystemID
		{
			get { return this.GetIntFromLSO("SolarSystemID"); }
		}

		/// <summary>
		/// Wrapper for the Fleet member of the character type.
		/// </summary>
		public Fleet Fleet
		{
			get
			{
				return new Fleet(GetMember("Fleet"));
			}
		}

		/// <summary>
		/// Wrapper for the ShipID member of the character type.
		/// </summary>
		public Int64 ShipID
		{
			get { return this.GetInt64FromLSO("ShipID"); }
		}

		/// <summary>
		/// Wrapper for the CharID member of the character type.
		/// </summary>
		public Int64 CharID
		{
			get { return this.GetInt64FromLSO("CharID"); }
		}

		/// <summary>
		/// This does not change state until you are fully completed transitioning; 
		/// for example, if you are undocking, it is TRUE until you actually arrive in space.
		/// </summary>
		public bool InStation
		{
			get { return this.GetBoolFromLSO("InStation"); }
		}

		/// <summary>
		/// Wrapper for the InSpace member of the character type.
		/// </summary>
		public bool InSpace
		{
			get { return this.GetBoolFromLSO("InSpace"); }
		}

		/// <summary>
		/// Wrapper for the StationID member of the character type.
		/// </summary>
		public int StationID
		{
			get { return this.GetIntFromLSO("StationID"); }
		}

		/// <summary>
		/// Wrapper for the Intelligence member of the character type.
		/// </summary>
		public double Intelligence
		{
			get { return this.GetDoubleFromLSO("Intelligence"); }
		}

		/// <summary>
		/// Wrapper for the Perception member of the character type.
		/// </summary>
		public double Perception
		{
			get { return this.GetDoubleFromLSO("Perception"); }
		}

		/// <summary>
		/// Wrapper for the Charisma member of the character type.
		/// </summary>
		public double Charisma
		{
			get { return this.GetDoubleFromLSO("Charisma"); }
		}

	    public Wallet Wallet
	    {
	        get { return new Wallet(GetMember("Wallet")); }
	    }

		/// <summary>
		/// Wrapper for the Willpower member of the character type.
		/// </summary>
		public double Willpower
		{
			get { return this.GetDoubleFromLSO("Willpower"); }
		}

		/// <summary>
		/// Wrapper for the Memory member of the character type.
		/// </summary>
		public double Memory
		{
			get { return this.GetDoubleFromLSO("Memory"); }
		}

		/// <summary>
		/// See also the 'MaxLockedTargets' member of the ship datatype for 
		/// the ship restriction on locked targets 
		/// </summary>
		public double MaxLockedTargets
		{
			get { return this.GetDoubleFromLSO("MaxLockedTargets"); }
		}

		/// <summary>
		/// Wrapper for the MiningDroneAmountBonus member of the character type.
		/// </summary>
		public double MiningDroneAmountBonus
		{
			get { return this.GetDoubleFromLSO("MiningDroneAmountBonus"); }
		}

		/// <summary>
		/// Wrapper for the MaxActiveDrones member of the character type.
		/// </summary>
		public double MaxActiveDrones
		{
			get { return this.GetDoubleFromLSO("MaxActiveDrones"); }
		}

		/// <summary>
		/// Wrapper for the DroneControlDistance member of the character type.
		/// </summary>
		public double DroneControlDistance
		{
			get { return this.GetDoubleFromLSO("DroneControlDistance"); }
		}

		/// <summary>
		/// Wrapper for the MaxJumpClones member of the character type.
		/// </summary>
		public double MaxJumpClones
		{
			get
			{
				return this.GetDoubleFromLSO("MaxJumpClones");
			}
		}
		#endregion

		/// <summary>
		/// Wrapper for the Station member of the character type.
		/// </summary>
		public Station Station
		{
			get
			{
				return new Station(GetMember("Station"));
			}
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

		/// <summary>
		/// Wrapper for the SkillCurrentlyTraining member of the character type.
		/// </summary>
		/// <returns></returns>
		public Skill SkillCurrentlyTraining()
		{
			return new Skill(GetMember("SkillCurrentlyTraining"));
		}

		/// <summary>
		/// Wrapper for the GetSkills member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Skill> GetSkills()
		{
			return Util.GetListFromMethod<Skill>(this, "GetSkills", "skill");
		}


		/// <summary>
		/// Wrapper for the SkillPoints member of the character type.
		/// </summary>
		public double SkillPoints
		{
			get { return this.GetDoubleFromLSO("SkillPoints"); }
		}

        /// <summary>
        /// *** Note:  The return value from this datatype member does not correlate, in any way, with the way that humans typically
        /// ***        tell time.   However, it is useful in the following contexts:
        /// ***        1.  If it's >0, then you are still training.  If it's 0 or NULL, then you're not training.  Etc...
        /// ***        2.  echo "My training queue will end at {$EVETime[${Math.Calc64[${Me.SkillQueueLength}+${EVETime.AsInt64}]}]}"
        /// </summary>
        public double SkillQueueLength
        {
            get { return this.GetDoubleFromLSO("SkillQueueLength"); }
        }
		#endregion

		#region Targeting
		/// <summary>
		/// Wrapper for the ActiveTarget member of the character type.
		/// </summary>
		public Entity ActiveTarget
		{
			get
			{
				return new Entity(GetMember("ActiveTarget"));
			}
		}

		/// <summary>
		/// Entities you are currently locked on
		/// </summary>
		public List<Entity> GetTargets()
		{
			Tracing.SendCallback("Character.GetTargets");
			return Util.GetListFromMethod<Entity>(this, "GetTargets", "entity");
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

		/// <summary>
		/// Entities currently being targeted by you.
		/// </summary>
		public List<Entity> GetTargeting()
		{
			Tracing.SendCallback("Character.GetTargeting");
			return Util.GetListFromMethod<Entity>(this, "GetTargeting", "entity");
		}

		/// <summary>
		/// Entities targetting you.
		/// </summary>
		public List<Entity> GetTargetedBy()
		{
			Tracing.SendCallback("Character.GetTargetedBy");
			return Util.GetListFromMethod<Entity>(this, "GetTargetedBy", "entity");
		}
		#endregion

		/// <summary>
		/// Wrapper for the GetHangarItems member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetHangarItems()
		{
			Tracing.SendCallback("Character.GetHangarItems");
			return Util.GetListFromMethod<Item>(this, "GetHangarItems", "item");
		}

		/// <summary>
		/// Wrapper for the GetHangarShips member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetHangarShips()
		{
			Tracing.SendCallback("Character.GetHangarShips");
			return Util.GetListFromMethod<Item>(this, "GetHangarShips", "item");
		}

		/// <summary>
		/// Wrapper for the GetCorpHangarItems member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCorpHangarItems()
		{
			Tracing.SendCallback("Character.GetCorpHangarItems");
			return Util.GetListFromMethod<Item>(this, "GetCorpHangarItems", "item");
		}

        /// <summary>
        /// Wrapper for the GetCorpHangarShips member of the character type.
        /// </summary>
        /// <returns></returns>
        public List<Item> GetCorpHangarShips()
        {
            return Util.GetListFromMethod<Item>(this, "GetCorpHangarShips", "item");
        }

		/// <summary>
        /// 1. GetAssets[index:item] (int type) [Retrieves all items that are in your assets window]
		/// </summary>
		public List<Item> GetAssets()
		{
			Tracing.SendCallback("Character.GetAssets");
			return Util.GetListFromMethod<Item>(this, "GetAssets", "item");
		}

		/// <summary>
        /// GetAssets[index:item,#] (int type) [Retrieves all items that match the StationID# given]
		/// </summary>
        public List<Item> GetAssets(Int64 StationID)
		{
			Tracing.SendCallback("Character.GetAssets", StationID);
            return Util.GetListFromMethod<Item>(this, "GetAssets", "item", StationID.ToString());
		}

		/// <summary>
		/// 2. GetStationsWithAssets[&lt;index:int&gt;] (int type) [Retrieves a list of StationID#s where you currently have assets.]
		/// </summary>
		public List<Int64> GetStationsWithAssets()
		{
			Tracing.SendCallback("Character.GetStationsWithAssets");
			return Util.GetListFromMethod<Int64>(this, "GetStationsWithAssets", "int64");
		}

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
			return Util.GetListFromMethod<MyOrder>(this, "GetMyOrders", "myorder");
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

		/// <summary>
		/// Wrapper for Me.TargetCount
		/// </summary>
		public int TargetCount
		{
			get { return this.GetIntFromLSO("TargetCount"); }
		}

		/// <summary>
		/// Wrapper for Me.TargetingCount
		/// </summary>
		public int TargetingCount
		{
			get { return this.GetIntFromLSO("TargetingCount"); }
		}

		/// <summary>
		/// Wrapper for Me.TargetedByCount
		/// </summary>
		public int TargetedByCount
		{
			get { return this.GetIntFromLSO("TargetedByCount"); }
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
		/// Wrapper for the OpenCorpHangar method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool OpenCorpHangar()
		{
			Tracing.SendCallback("Character.OpenCorpHangar");
			return ExecuteMethod("OpenCorpHangar");
		}

		/// <summary>
		/// Wrapper for the StackAllHangarItems method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool StackAllHangarItems()
		{
			Tracing.SendCallback("Character.StackAllHangarItems");
			return ExecuteMethod("StackAllHangarItems");
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

        /// <summary>
        /// Get a list of Attackers.
        /// Note: This will return a null list if there are no attackers.
        /// </summary>
        /// <returns></returns>
        public List<Attacker> GetAttackers()
        {
            if (Tracing.Callback != null)
                Tracing.SendCallback("Character.GetAttackers");

            return Util.GetListFromMethod<Attacker>(this, "GetAttackers", "attacker");
        }

        /// <summary>
        /// Get a list of Attackers as entities.
        /// </summary>
        /// <returns></returns>
        public List<Entity> GetAttackersAsEntities()
        {
            if (Tracing.Callback != null)
                Tracing.SendCallback("Character.GetAttackersAsEntities");

            return Util.GetListFromMethod<Entity>(this, "GetAttackers", "entity");
        }

        /// <summary>
        /// Get a list of Jammers on us.
        /// </summary>
        /// <returns></returns>
        public List<Jammer> GetJammers()
        {
            if (Tracing.Callback != null)
                Tracing.SendCallback("Character.GetAttackers");

            return Util.GetListFromMethod<Jammer>(this, "GetJammers", "jammer");
        }
		#endregion

		/// <summary>
		/// Type of market order (buy or sell)
		/// </summary>
		public enum OrderType
		{
			/// <summary>
			/// A buy order.
			/// </summary>
			Buy = 1,

			/// <summary>
			/// A sell order.
			/// </summary>
			Sell = 2
		}
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
