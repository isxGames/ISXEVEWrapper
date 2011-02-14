using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

//November 4, 2007 -- By Amadeus
//[ISXEVE-20070911.0505]
//*** 
//*** NOTES ABOUT ASSETS:
//***
//*** 1. "GetAssets" will NOT include items that are in the same station you are currently residing (if applicable).  However,
//***    "GetStationsWithAssets" and "NumAssetsAtStation" WILL contain information about your current station.
//*** 2. ISXEVE cannot override the 5 minute updating delay present in EVE.  In other words, the information given by ISXEVE
//***    will match what you see in your UI.
//*** 3. StationID#s match the "LocationID" member of the 'asset' datatype as well as the "ID" member of the 'entity' datatype.
//*** 4. You will need to open the assets window and have all stations expanded to have access to the items at that station.
//*** 5. I have placed an example script at http://www.isxgames.com/forums/showthread.php?p=11830&posted=1#post11830
//***
//* Added new MEMBERS to the 'character' datatype:
//  1. GetAssets[<index:asset>]                            (int type)   [Retrieves all items that are in your assets window]
//     GetAssets[<index:asset>,#]                          (int type)   [Retrieves all items that match the StationID# given]
//  2. GetStationsWithAssets[<index:int>]                  (int type)   [Retrieves a list of StationID#s where you currently have assets.]
//* Added new METHODS to the 'character' datatype:
//  1. DoGetAssets[<index:asset>]                                       [Retrieves all items that are in your assets window]
//     DoGetAssets[<index:asset>,#]                                     [Retrieves all items that match the StationID# given]
//  2. DoGetStationsWithAssets[<index:int>]                             [Retrieves a list of StationID#s where you currently have assets.]  

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
		public Standing StandingTo(int charID, int corpID, int allianceID)
		{
			return new Standing(GetMember("StandingTo", charID.ToString(), corpID.ToString(), allianceID.ToString()));
		}

		/// <summary>
		/// Wrapper for the AutoPilotOn member of the character type.
		/// </summary>
		public bool AutoPilotOn
		{
			get
			{
				return GetMember<bool>("AutoPilotOn");
			}
		}

		/// <summary>
		/// Wrapper for the GetFleet member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<FleetMember> GetFleet()
		{
			return Util.GetListFromMember<FleetMember>(this, "GetFleet", "fleetmember");
		}

		/// <summary>
		/// Wrapper for the GetActiveDrones member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<ActiveDrone> GetActiveDrones()
		{
			return Util.GetListFromMember<ActiveDrone>(this, "GetActiveDrones", "activedrone");
		}

		/// <summary>
		/// Wrapper for the GetActiveDroneIDs member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<long> GetActiveDroneIDs()
		{
			return Util.GetListFromMember<long>(this, "GetActiveDroneIDs", "int64");
		}

		#region SelfCorpLocation
		/// <summary>
		/// Wrapper for the Name member of the character type.
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Wrapper for the Corporation member of the character type.
		/// </summary>
		public string Corporation
		{
			get
			{
				return GetMember<string>("Corporation");
			}
		}

		/// <summary>
		/// Wrapper for the CorporationID member of the character type.
		/// </summary>
		public int CorporationID
		{
			get
			{
				LavishScriptObject corporationID = GetMember("CorporationID");
				if (!LavishScriptObject.IsNullOrInvalid(corporationID))
				{
					return corporationID.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the CorporationTicker member of the character type.
		/// </summary>
		public string CorporationTicker
		{
			get
			{
				return GetMember<string>("CorporationTicker");
			}
		}

		/// <summary>
		/// Wrapper for the Alliance member of the character type.
		/// </summary>
		public string Alliance
		{
			get
			{
				return GetMember<string>("Alliance");
			}
		}

		/// <summary>
		/// Wrapper for the AllianceID member of the character type.
		/// </summary>
		public int AllianceID
		{
			get
			{
				LavishScriptObject allianceID = GetMember("AllianceID");
				if (!LavishScriptObject.IsNullOrInvalid(allianceID))
				{
					return allianceID.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the AllianceTicker member of the character type.
		/// </summary>
		public string AllianceTicker
		{
			get
			{
				return GetMember<string>("AllianceTicker");
			}
		}

		/// <summary>
		/// Wrapper for the RegionID member of the character type.
		/// </summary>
		public int RegionID
		{
			get
			{
				return GetMember<int>("RegionID");
			}
		}

		/// <summary>
		/// Wrapper for the ConstellationID member of the character type.
		/// </summary>
		public int ConstellationID
		{
			get
			{
				return GetMember<int>("ConstellationID");
			}
		}

		/// <summary>
		/// Wrapper for the SolarSystemID member of the character type.
		/// </summary>
		public int SolarSystemID
		{
			get
			{
				LavishScriptObject solarSystemID = GetMember("SolarSystemID");
				if (!LavishScriptObject.IsNullOrInvalid(solarSystemID))
				{
					return solarSystemID.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
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
			get
			{
				LavishScriptObject shipID = GetMember("ShipID");
				if (!LavishScriptObject.IsNullOrInvalid(shipID))
				{
					return shipID.GetValue<Int64>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the CharID member of the character type.
		/// </summary>
		public int CharID
		{
			get
			{
				LavishScriptObject charID = GetMember("CharID");
				if (!LavishScriptObject.IsNullOrInvalid(charID))
				{
					return charID.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// This does not change state until you are fully completed transitioning; 
		/// for example, if you are undocking, it is TRUE until you actually arrive in space.
		/// </summary>
		public bool InStation
		{
			get
			{
				LavishScriptObject inStation = GetMember("InStation");
				if (LavishScriptObject.IsNullOrInvalid(inStation))
				{
					return false;
				}
				else
				{
					return inStation.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the InSpace member of the character type.
		/// </summary>
		public bool InSpace
		{
			get
			{
				LavishScriptObject inSpace = GetMember("InSpace");
				if (LavishScriptObject.IsNullOrInvalid(inSpace))
				{
					return false;
				}
				else
				{
					return inSpace.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the StationID member of the character type.
		/// </summary>
		public int StationID
		{
			get
			{
				LavishScriptObject stationID = GetMember("StationID");
				if (!LavishScriptObject.IsNullOrInvalid(stationID))
				{
					return stationID.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Intelligence member of the character type.
		/// </summary>
		public double Intelligence
		{
			get
			{
				return GetMember<double>("Intelligence");
			}
		}

		/// <summary>
		/// Wrapper for the Perception member of the character type.
		/// </summary>
		public double Perception
		{
			get
			{
				return GetMember<double>("Perception");
			}
		}

		/// <summary>
		/// Wrapper for the Charisma member of the character type.
		/// </summary>
		public double Charisma
		{
			get
			{
				return GetMember<double>("Charisma");
			}
		}

		/// <summary>
		/// Wrapper for the Willpower member of the character type.
		/// </summary>
		public double Willpower
		{
			get
			{
				return GetMember<double>("Willpower");
			}
		}

		/// <summary>
		/// Wrapper for the Memory member of the character type.
		/// </summary>
		public double Memory
		{
			get
			{
				return GetMember<double>("Memory");
			}
		}

		/// <summary>
		/// See also the 'MaxLockedTargets' member of the ship datatype for 
		/// the ship restriction on locked targets 
		/// </summary>
		public double MaxLockedTargets
		{
			get
			{
				LavishScriptObject maxLockedTargets = GetMember("MaxLockedTargets");
				if (!LavishScriptObject.IsNullOrInvalid(maxLockedTargets))
				{
					return maxLockedTargets.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the MiningDroneAmountBonus member of the character type.
		/// </summary>
		public double MiningDroneAmountBonus
		{
			get
			{
				return GetMember<double>("MiningDroneAmountBonus");
			}
		}

		/// <summary>
		/// Wrapper for the MaxActiveDrones member of the character type.
		/// </summary>
		public double MaxActiveDrones
		{
			get
			{
				LavishScriptObject maxActiveDrones = GetMember("MaxActiveDrones");
				if (!LavishScriptObject.IsNullOrInvalid(maxActiveDrones))
				{
					return maxActiveDrones.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the DroneControlDistance member of the character type.
		/// </summary>
		public double DroneControlDistance
		{
			get
			{
				LavishScriptObject droneControlDistance = GetMember("DroneControlDistance");
				if (!LavishScriptObject.IsNullOrInvalid(droneControlDistance))
				{
					return droneControlDistance.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the MaxJumpClones member of the character type.
		/// </summary>
		public double MaxJumpClones
		{
			get
			{
				try
				{
					LavishScriptObject maxJumpClones = GetMember("MaxJumpClones");
					if (LavishScriptObject.IsNullOrInvalid(maxJumpClones))
					{
						return -1;
					}
					return maxJumpClones.GetValue<double>();
				}
				catch (Exception ex)
				{
					InnerSpace.Echo("Exception: MaxJumpClones:" + ex.Message);
					return -1;
				}
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
			return Util.GetListFromMember<Skill>(this, "GetSkills", "skill");
		}

		/// <summary>
		/// Wrapper for the SkillCount member of the character type.
		/// </summary>
		public int SkillCount
		{
			get
			{
				return GetMember<int>("GetSkills");
			}
		}

		/// <summary>
		/// Wrapper for the SkillPoints member of the character type.
		/// </summary>
		public int SkillPoints
		{
			get
			{
				LavishScriptObject skillPoints = GetMember("SkillPoints");
				if (LavishScriptObject.IsNullOrInvalid(skillPoints))
				{
					return -1;
				}
				return skillPoints.GetValue<int>();
			}
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
		/// Wrapper for the TargetCount member of the character type.
		/// </summary>
		public int TargetCount
		{
			get
			{
				LavishScriptObject targetCount = GetMember("GetTargets");
				if (!LavishScriptObject.IsNullOrInvalid(targetCount))
				{
					return targetCount.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Entities you are currently locked on
		/// </summary>
		public List<Entity> GetTargets()
		{
			return Util.GetListFromMember<Entity>(this, "GetTargets", "entity");
		}

		/// <summary>
		/// Entities you are currently locked on
		/// Grabs one specific target by index (0 based)
		/// </summary>
		public Entity GetTarget(int i)
		{
			return Util.GetFromIndexMember<Entity>(this, "GetTargets", "entity", i);
		}

		/// <summary>
		/// Entities currently being targeted by you.
		/// </summary>
		public List<Entity> GetTargeting()
		{
			return Util.GetListFromMember<Entity>(this, "GetTargeting", "entity");
		}

		/// <summary>
		/// Entities targetting you.
		/// </summary>
		public List<Entity> GetTargetedBy()
		{
			return Util.GetListFromMember<Entity>(this, "GetTargetedBy", "entity");
		}
		#endregion

		/// <summary>
		/// Wrapper for the GetHangarItems member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetHangarItems()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.GetHangarItems", string.Empty);
			return Util.GetListFromMember<Item>(this, "GetHangarItems", "item");
		}

		/// <summary>
		/// Wrapper for the GetHangarShips member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetHangarShips()
		{
			return Util.GetListFromMember<Item>(this, "GetHangarShips", "item");
		}

		/// <summary>
		/// Wrapper for the GetCorpHangarItems member of the character type.
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCorpHangarItems()
		{
			return Util.GetListFromMember<Item>(this, "GetCorpHangarItems", "item");
		}

        /// <summary>
        /// Wrapper for the GetCorpHangarShips member of the character type.
        /// </summary>
        /// <returns></returns>
        public List<Item> GetCorpHangarShips()
        {
            return Util.GetListFromMember<Item>(this, "GetCorpHangarShips", "item");
        }

		/// <summary>
		/// 1. GetAssets[&lt;index:asset&gt;] (int type) [Retrieves all items that are in your assets window]
		/// </summary>
		public List<Asset> GetAssets()
		{
			return Util.GetListFromMember<Asset>(this, "GetAssets", "asset");
		}

		/// <summary>
		/// GetAssets[&lt;index:asset&gt;,#] (int type) [Retrieves all items that match the StationID# given]
		/// </summary>
		public List<Asset> GetAssets(Int64 StationID)
		{
			return Util.GetListFromMember<Asset>(this, "GetAssets", "asset", StationID.ToString());
		}

		/// <summary>
		/// 2. GetStationsWithAssets[&lt;index:int&gt;] (int type) [Retrieves a list of StationID#s where you currently have assets.]
		/// </summary>
		public List<Int64> GetStationsWithAssets()
		{
			return Util.GetListFromMember<Int64>(this, "GetStationsWithAssets", "int64");
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
			return Util.GetListFromMember<MyOrder>(this, "GetMyOrders", "myorder");
		}

		/// <summary>
		/// Wrapper for the GetMyOrders member of the character type.
		/// </summary>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public List<MyOrder> GetMyOrders(int typeID)
		{
			return Util.GetListFromMember<MyOrder>(this, "GetMyOrders", "myorder", typeID.ToString());
		}

		/// <summary>
		/// Wrapper for the GetMyOrders member of the character type.
		/// </summary>
		/// <param name="buyOrSell"></param>
		/// <returns></returns>
		public List<MyOrder> GetMyOrders(OrderType buyOrSell)
		{
			return Util.GetListFromMember<MyOrder>(this, "GetMyOrders", "myorder", buyOrSell.ToString());
		}

		/// <summary>
		/// Wrapper for the GetMyOrders member of the character type.
		/// </summary>
		/// <param name="buyOrSell"></param>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public List<MyOrder> GetMyOrders(OrderType buyOrSell, int typeID)
		{
			return Util.GetListFromMember<MyOrder>(this, "GetMyOrders", "myorder", buyOrSell.ToString(), typeID.ToString());
		}
		#endregion

        /// <summary>
        /// January 21, 2010
        /// [ISXEVE-20100121.0001]
        /// * Added the following MEMBERS to the 'character' datatype
        /// 1. GetMyOrdersIsReady     (bool) If this is true, you are able to call GetMyOrders, otherwise they will fail.
        /// </summary>
        public bool GetMyOrdersIsReady
        {
            get
            {
                return GetMember<bool>("GetMyOrdersIsReady");
            }
        }

        #region Methods
		/// <summary>
		/// Argument is a PERCENTAGE of your max velocity.
		/// </summary>
		public bool SetVelocity(int SpeedAsPercentage)
		{
			if (Tracing.Callback != null)
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
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.SetCorpStanding", String.Format("{0},{1},{2}", CorpID, Standing, Reason));
			return ExecuteMethod("SetCorpStanding", CorpID.ToString(), Standing.ToString(), Reason);
		}

		/// <summary>
		/// Wrapper for the SetPilotStanding method of the character type.
		/// </summary>
		/// <param name="CharID"></param>
		/// <param name="Standing"></param>
		/// <param name="Reason"></param>
		/// <returns></returns>
		public bool SetPilotStanding(int CharID, float Standing, string Reason)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.SetPilotStanding", String.Format("{0},{1},{2}", CharID, Standing, Reason));
			return ExecuteMethod("SetPilotStanding", CharID.ToString(), Standing.ToString(), Reason);
		}

		/// <summary>
		/// Wrapper for the AcceptFleetInvite method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool AcceptFleetInvite()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.AcceptFleetInvite", string.Empty);
			return ExecuteMethod("AcceptFleetInvite");
		}

		/// <summary>
		/// Wrapper for the RejectFleetInvite method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool RejectFleetInvite()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.RejectFleetInvite", string.Empty);
			return ExecuteMethod("RejectFleetInvite");
		}

		/// <summary>
		/// Wrapper for the OpenCorpHangar method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool OpenCorpHangar()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.OpenCorpHangar", string.Empty);
			return ExecuteMethod("OpenCorpHangar");
		}

		/// <summary>
		/// Wrapper for the StackAllHangarItems method of the character type.
		/// </summary>
		/// <returns></returns>
		public bool StackAllHangarItems()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.StackAllHangarItems", string.Empty);
			return ExecuteMethod("StackAllHangarItems");
		}

		/// <summary>
		///  2. UpdateMyOrders   
		///     ~ This method should be called before any calling of "GetMyOrders" or "DoGetMyOrders".
		/// </summary>
		public bool UpdateMyOrders()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Character.UpdateMyOrders", string.Empty);
			return ExecuteMethod("UpdateMyOrders");
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
