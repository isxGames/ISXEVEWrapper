using System;
using System.Collections.Generic;
using System.Text;
using EVE.ISXEVE.Enums;
using EVE.ISXEVE.Extensions;
using EVE.ISXEVE.Interfaces;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the eve data type.
	/// </summary>
	public class EVE : LavishScriptObject, IEve
	{
		#region Constants

	  #endregion

		#region Constructors
		/// <summary>
		/// Copy constructor for the EVE object.
		/// </summary>
		/// <param name="Obj"></param>
		public EVE(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Constructor for the EVE object.  Returns the  LS object.
		/// </summary>
		public EVE()
			: base(LavishScript.Objects.GetObject("EVE"))
		{
		}
		#endregion

		/// <summary>
		/// Wrapper for the StationID member of the eve type.
		/// </summary>
		/// <param name="stationID"></param>
		/// <returns></returns>
		public Station Station(int stationID)
		{
			Tracing.SendCallback("EVE.Station", stationID);
			return GetMember<Station>("Station", stationID.ToString());
		}

		/// <summary>
		/// Number of entities currently in range of your overhead
		/// </summary>
		public int EntitiesCount
		{
			get { return this.GetInt("EntitiesCount"); }
		}

		/// <summary>
		/// # of seconds until a session change can be performed. This includes docking, undocking, exiting a ship, entering a new ship, etc.
		/// </summary>
		public int NextSessionChange
		{
			get { return this.GetInt("NextSessionChange"); }
		}

		/// <summary>
		/// Returns a list of the "SystemIDs" of the systems along your current destination (autopilot) route.
		/// Returns a single -1 if you currently have no destinations.
		/// </summary>
		public List<int> GetToDestinationPath()
		{
			Tracing.SendCallback("EVE.GetToDestinationPath");
			return Util.GetListFromMethod<int>(this, "GetToDestinationPath", "int");
		}

		/// <summary>
		/// Returns a list of the "SystemIDs" of the waypoints in your current route.
		/// </summary>
		public List<int> GetWaypoints()
		{
			Tracing.SendCallback("EVE.GetWaypoints");
			return Util.GetListFromMethod<int>(this, "GetWaypoints", "int");
		}

		/// <summary>
		/// Wrapper for the GetAgentMissions member of the eve type.
		/// </summary>
		/// <returns></returns>
		public List<AgentMission> GetAgentMissions()
		{
			Tracing.SendCallback("EVE.GetAgentMissions");
			return Util.GetListFromMethod<AgentMission>(this, "GetAgentMissions", "agentmission");
		}

		/// <summary>
		/// Returns a bookmark based on its label.
		/// </summary>
		public BookMark Bookmark(string label)
		{
			Tracing.SendCallback("EVE.Bookmark", label);
			return new BookMark(GetMember("Bookmark", label));
		}

		/// <summary>
		/// Returns a list of your bookmarks.
		/// </summary>
		public List<BookMark> GetBookmarks()
		{
			Tracing.SendCallback("EVE.GetBookmarks", string.Empty);
			return Util.GetListFromMethod<BookMark>(this, "GetBookmarks", "bookmark");
		}

		/// <summary>
		/// Returns number of jumps to the given solarsystem or station.
		/// </summary>
		public int GetJumpsTo(int solarSystemOrStationId)
		{
			Tracing.SendCallback("EVE.GetJumpsTo", solarSystemOrStationId.ToString());
			return this.GetInt("JumpsTo", solarSystemOrStationId.ToString());
		}

		/// <summary>
		/// Get the # of jumps between the given two solar systems.
		/// </summary>
		/// <param name="firstSolarSystem"></param>
		/// <param name="secondSolarSystemId"></param>
		/// <returns></returns>
		public int GetJumpsBetween(int firstSolarSystem, int secondSolarSystemId)
		{
			return this.GetInt("JumpsBetween", firstSolarSystem.ToString(), secondSolarSystemId.ToString());
		}

		/// <summary>
		/// Returns the distance between two entities.
		/// </summary>
		public double DistanceBetween(Int64 firstEntityID, Int64 secondEntityID)
		{
			Tracing.SendCallback("EVE.DistanceBetween", firstEntityID, secondEntityID);
			return this.GetDouble("DistanceBetween", firstEntityID.ToString(), secondEntityID.ToString());
		}

		/// <summary>
		/// example: "18:23:55"
		/// </summary>
		public string Time
		{
			get { return this.GetString("Time"); }
		}

		/// <summary>
		/// example: "18:23"
		/// </summary>
		public string TimeShort
		{
			get { return this.GetString("Time", "short"); }
		}

		/// <summary>
		/// example: "2007.08.25"
		/// </summary>
		public string Date
		{
			get { return this.GetString("Date"); }
		}

		/// <summary>
		/// Wrapper for the Is3DDisplayOn member of the eve type.
		/// </summary>
		public bool Is3DDisplayOn
		{
			get { return this.GetBool("Is3DDisplayOn"); }
		}

		/// <summary>
		/// Wrapper for the IsUIDisplayOn member of the eve type.
		/// </summary>
		public bool IsUIDisplayOn
		{
			get { return this.GetBool("IsUIDisplayOn"); }
		}

		public bool IsTextureLoadingOn
		{
			get { return this.GetBool("IsTextureLoadingOn"); }
		}

		public bool AbandonedDronesExist
		{
			get { return this.GetBool("AbandonedDronesExist"); }
		}

		public bool IsProgressWindowOpen
		{
			get { return this.GetBool("IsProgressWindowOpen"); }
		}

		public string ProgressWindowTitle
		{
			get { return this.GetString("ProgressWindowTitle"); }
		}

		/// <summary>
		/// Wrapper for the GetLocalPilots member of the eve type.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public List<Pilot> GetLocalPilots(params string[] args)
		{
			Tracing.SendCallback("EVE.GetLocalPilots", args);
			return Util.GetListFromMethod<Pilot>(this, "GetLocalPilots", "pilot", args);
		}

		/// <summary>
		/// Wrapper for the GetOnlineCorpMembers method of the eve type.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public List<Pilot> GetOnlineCorpMembersAsPilots(params string[] args)
		{
			Tracing.SendCallback("EVE.GetOnlineCorpMembers", args);
			return Util.GetListFromMethod<Pilot>(this, "GetOnlineCorpMembers", "pilot", args);
		}

		/// <summary>
		/// Wrapper for the GetOnlineCorpMembers method of the eve type.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public List<Being> GetOnlineCorpMembersAsBeings(params string[] args)
		{
			Tracing.SendCallback("EVE.GetOnlineCorpMembers", args);
			return Util.GetListFromMethod<Being>(this, "GetOnlineCorpMembers", "being", args);
		}

		/// <summary>
		/// Your "buddies"
		/// </summary>
		[Obsolete("Use GetContacts().", false)]
		public List<Being> GetBuddies()
		{
			Tracing.SendCallback("EVE.GetBuddies");
			return Util.GetListFromMethod<Being>(this, "GetBuddies", "being");
		}

		/// <summary>
		/// ISXEVE-20141001.0009 on October 4, 2014:
		/// This does EXACTLY the same thing as "GetBuddies" does currently.  "GetBuddies" is now deprecated and should be removed. 
		/// </summary>
		/// <returns></returns>
		public IList<Being> GetContacts()
		{
			Tracing.SendCallback("EVE.GetContacts");
			return this.GetListFromMethod<Being>("GetContacts", "being");
		}

		/// <summary>
		/// the agents in your *addressbook* 
		/// </summary>
		public List<Being> GetAgents()
		{
			Tracing.SendCallback("EVE.GetAgents");
			return Util.GetListFromMethod<Being>(this, "GetAgents", "being");
		}

		/// <summary>
		/// Returns the number of chat channels currently open in your UI
		/// </summary>
		/// <returns></returns>
		public Int32 NumOpenChannels
		{
			get { return this.GetInt("NumOpenChannels"); }
		}

		/// <summary>
		/// 1.  NumAssetsAtStation[#] (int type) [Returns the number of items currently housed at the StationID# given.]
		/// </summary>
		public int NumAssetsAtStation(int stationID)
		{
			Tracing.SendCallback("EVE.NumAssetsAtStation", stationID);
			return this.GetInt("NumAssetsAtStation", stationID.ToString());
		}

		/// <summary>
		/// 2.  GetLocationNameByID[#] (string type) [Useful for changing a StationID# to an actual name.]
		/// </summary>
		public string GetLocationNameByID(int stationID)
		{
			Tracing.SendCallback("EVE.GetLocationNameByID", stationID);
			return this.GetString("GetLocationNameByID", stationID.ToString());
		}

		/// <summary>
		/// Download market order information from EVE servers.
		/// </summary>
		public bool FetchMarketOrders()
		{
			Tracing.SendCallback("EVE.FetchMarketOrders");
			return this.GetBool("FetchMarketOrders");
		}

		/// <summary>
		/// Get entities matching query specified by queryID.
		/// Note: ID from Lavishscript query system -- query will not be freed
		/// </summary>
		/// <param name="queryID"></param>
		/// <returns></returns>
		public List<Entity> QueryEntities(int queryID)
		{
			Tracing.SendCallback("EVE.QueryEntities", queryID.ToString());
			return Util.GetListFromMethod<Entity>(this, "QueryEntities", "entity", queryID.ToString());
		}

		/// <summary>
		/// Get entities matching the passed query.
		/// Note: Uses Lavishscript query syntax, query will be created and destroyed after use
		/// </summary>
		/// <param name="queryString"></param>
		/// <returns></returns>
		public List<Entity> QueryEntities(string queryString)
		{
			Tracing.SendCallback("EVE.QueryEntities", queryString);
			return Util.GetListFromMethod<Entity>(this, "QueryEntities", "entity", queryString);
		}

		/// <summary>
		/// Get all entities
		/// </summary>
		/// <returns></returns>
		public List<Entity> QueryEntities()
		{
			Tracing.SendCallback("EVE.QueryEntities");
			return Util.GetListFromMethod<Entity>(this, "QueryEntities", "entity");
		}

		/// <summary>
		/// if bool is true, forces repopulation of entities. This should be called ONCE after isxeve is loaded... any more will have no effect.
		/// </summary>
		/// <param name="forceRepopulate"></param>
		/// <returns></returns>
		public bool PopulateEntities(bool forceRepopulate)
		{
			Tracing.SendCallback("EVE.PopulateEntities", forceRepopulate.ToString());
			return ExecuteMethod("PopulateEntities", forceRepopulate.ToString());
		}

		/// <summary>
		/// This method creates a simple EVE popup window with the 'text' given.
		/// </summary>
		public bool InfoWindow(string text)
		{
			Tracing.SendCallback("EVE.InfoWindow", text);
			return ExecuteMethod("InfoWindow", text);
		}

		/// <summary>
		/// This method sets the status text that appears in space over your ship controls.
		/// </summary>
		public bool SetInSpaceStatus(string title, string text)
		{
			Tracing.SendCallback("EVE.SetInSpaceStatus");
			return ExecuteMethod("SetInSpaceStatus", title, text);
		}

		/// <summary>
		/// Order drones to engage active target.
		/// </summary>
		/// <param name="drones">drones to order</param>
		/// <returns>true if successful, else false</returns>
		public bool DronesEngageMyTarget(List<Int64> drones)
		{
			Tracing.SendCallback("EVE.DronesEngageMyTarget");
			var lsIndex = LavishScript.Objects.NewObject("index:int64");
			foreach (var droneID in drones)
			{
				lsIndex.ExecuteMethod("Insert", droneID.ToString());
			}
			return ExecuteMethod("DronesEngageMyTarget", lsIndex.GetLSReference());
		}

		/// <summary>
		/// Order drones to mine repeatedly.
		/// </summary>
		/// <param name="drones">ActiveDrone IDs</param>
		/// <returns></returns>
		public bool DronesMineRepeatedly(List<Int64> drones)
		{
			Tracing.SendCallback("EVE.DronesMineRepeatedly", string.Empty);

			var lsIndex = LavishScript.Objects.NewObject("index:int64");
			foreach (var droneID in drones)
			{
				lsIndex.ExecuteMethod("Insert", droneID.ToString());
			}
			return ExecuteMethod("DronesMineRepeatedly", lsIndex.GetLSReference());
		}

		/// <summary>
		/// Execute an eve command.
		/// </summary>
		public bool Execute(ExecuteCommand command)
		{
			Tracing.SendCallback("EVE.Execute", command);
			return ExecuteMethod("Execute", command.ToString());
		}

		/// <summary>
		/// Execute an eve command.
		/// </summary>
		public bool Execute(string command)
		{
			Tracing.SendCallback("EVE.Execute", command);
			return ExecuteMethod("Execute", command);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark()
		{
			return CreateBookmark(null, null, null);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark(string label)
		{
			return CreateBookmark(label, null, null);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark(string label, string notes, string location)
		{
			Tracing.SendCallback("EVE.CreateBookmark", label, notes, location);
			return ExecuteMethod("CreateBookmark", label, notes, location);
		}

		/// <summary>
		/// Wrapper for the AddWaypoint method of the eve type.
		/// </summary>
		/// <param name="solarSystemID"></param>
		/// <returns></returns>
		public bool AddWaypoint(int solarSystemID)
		{
			Tracing.SendCallback("EVE.AddWaypoint", solarSystemID);
			return ExecuteMethod("AddWaypoint", solarSystemID.ToString());
		}

    /// <summary>
    /// Closes all waypoints.
    /// </summary>
    public bool ClearAllWaypoints()
    {
      Tracing.SendCallback("EVE.ClearAllWaypoints", string.Empty);
      return ExecuteMethod("ClearAllWaypoints");
    }

    /// <summary>
    /// Closes any of the simple 'information message boxes', etc that might be up.
    /// </summary>
    public bool CloseAllMessageBoxes()
		{
			Tracing.SendCallback("EVE.CloseAllMessageBoxes", string.Empty);
			return ExecuteMethod("CloseAllMessageBoxes");
		}

		/// <summary>
		/// Wrapper for the CloseAllChatInvites method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool CloseAllChatInvites()
		{
			Tracing.SendCallback("EVE.CloseAllChatInvites", string.Empty);
			return ExecuteMethod("CloseAllChatInvites");
		}

		/// <summary>
		/// Wrapper for the LaunchDrones method of the eve type.
		/// </summary>
		/// <param name="DroneIDs"></param>
		/// <returns></returns>
		public bool LaunchDrones(List<Int64> DroneIDs)
		{
			Tracing.SendCallback("EVE.LaunchDrones", DroneIDs);
			if (DroneIDs.Count == 0)
			{
				return false;
			}

			var lsIndex = LavishScript.Objects.NewObject("index:int64");

			for (var index = 0; index < DroneIDs.Count; index++)
			{
				lsIndex.ExecuteMethod("Insert", DroneIDs[index].ToString());
			}
			//InnerSpace.Echo("*** " + LSIndex.GetMember<int>("Used"));
			// TODO - Test this to make sure passing a populated index into ExecuteMethod works
			// - CyberTech
			return ExecuteMethod("LaunchDrones", lsIndex.GetLSReference());
		}

		/// <summary>
		/// Wrapper for the ItemInfo member of the EVE datatype.
		/// </summary>
		/// <param name="typeId"></param>
		/// <returns></returns>
		public IItemInfo ItemInfo(int typeId)
		{
			Tracing.SendCallback("EVE.ItemInfo", typeId);

			return new ItemInfo(GetMember("ItemInfo", typeId.ToString()));
		}

		public List<EVEWindow> GetEveWindows()
		{
			return this.GetListFromMethod<EVEWindow>("GetEVEWindows", "evewindow");
		}

		/// <summary>
		/// Wrapper for the MoveItemsTo method fo the eve type.
		/// </summary>
		/// <param name="items"></param>
		/// <param name="ToLocationID"></param>
		/// <param name="destinationName"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> items, Int64 ToLocationID, string destinationName)
		{
			Tracing.SendCallback("EVE.MoveItemsTo", ToLocationID, destinationName);
			if (items.Count == 0)
			{
				return false;
			}

			var lsIndex = LavishScript.Objects.NewObject("index:int64");

			for (var index = 0; index < items.Count; index++)
			{
				lsIndex.ExecuteMethod("Insert", items[index].ToString());
			}
			//InnerSpace.Echo("*** " + LSIndex.GetMember<int>("Used"));
			// TODO - Test this to make sure passing a populated index into ExecuteMethod works
			// - CyberTech
			return ExecuteMethod("MoveItemsTo", lsIndex.GetLSReference(), ToLocationID.ToString(), destinationName);
		}

		/// <summary>
		/// Wrapper for the MoveItemsTo method of the eve type.
		/// </summary>
		/// <param name="items"></param>
		/// <param name="ToLocationID"></param>
		/// <param name="destinationName"></param>
		/// <param name="corporationHangarFolder"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> items, Int64 ToLocationID, string destinationName, int corporationHangarFolder)
		{
			Tracing.SendCallback("EVE.MoveItemsTo", ToLocationID, destinationName, corporationHangarFolder);
			if (items.Count == 0)
			{
				return false;
			}

			var lsIndex = LavishScript.Objects.NewObject("index:int64");
			for (var index = 0; index < items.Count; index++)
			{
				lsIndex.ExecuteMethod("Insert", items[index].ToString());
			}

			return ExecuteMethod("MoveItemsTo", lsIndex.GetLSReference(), ToLocationID.ToString(), destinationName,
				String.Format("Corporation Folder {0}", corporationHangarFolder));
		}


		/// <summary>
		/// Wrapper for the MoveItemsTo method fo the eve type.
		/// </summary>
		/// <param name="items"></param>
		/// <param name="ToLocationName">'MyShip','MyStationHangar', or 'MyStationCorporateHangar'</param>
		/// <param name="destinationName"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> items, string ToLocationName, string destinationName)
		{
			Tracing.SendCallback("EVE.MoveItemsTo", ToLocationName, destinationName);
			if (items.Count == 0)
			{
				return false;
			}

			var lsIndex = LavishScript.Objects.NewObject("index:int64");

			for (var index = 0; index < items.Count; index++)
			{
				lsIndex.ExecuteMethod("Insert", items[index].ToString());
			}
			//InnerSpace.Echo("*** " + LSIndex.GetMember<int>("Used"));
			// TODO - Test this to make sure passing a populated index into ExecuteMethod works
			// - CyberTech
			return ExecuteMethod("MoveItemsTo", lsIndex.GetLSReference(), ToLocationName, destinationName);
		}

		/// <summary>
		/// Wrapper for the MoveItemsTo method of the eve type.
		/// </summary>
		/// <param name="items"></param>
		/// <param name="ToLocationName">'MyShip','MyStationHangar', or 'MyStationCorporateHangar'</param>
		/// <param name="destinationName"></param>
		/// <param name="corporationHangarFolder"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> items, string ToLocationName, string destinationName, int corporationHangarFolder)
		{
			Tracing.SendCallback("EVE.MoveItemsTo", ToLocationName, destinationName, corporationHangarFolder);
			if (items.Count == 0)
			{
				return false;
			}

			var lsIndex = LavishScript.Objects.NewObject("index:int64");
			for (var index = 0; index < items.Count; index++)
			{
				lsIndex.ExecuteMethod("Insert", items[index].ToString());
			}

			return ExecuteMethod("MoveItemsTo", lsIndex.GetLSReference(), ToLocationName, destinationName,
				String.Format("Corporation Folder {0}", corporationHangarFolder));
		}

		/// <summary>
		/// 2. PlaceBuyOrder[StationID#, TypeID#, Price#, Quantity#, &lt;Range&gt;, MinQuantity#, &lt;Duration&gt;]
		///  ~ &lt;Range&gt; can be: "Station", "System", "Region", 1, 2, 3, 4, 5, 10, 20, 30, 40
		///  ~ Duration is in DAYS
		///  ~ To get your current stationID# use ${Me.StationID}
		///  ~ Quantity# is the MAX quantity you will buy overall, while MinQuantity# is the minimum that you will buy in a single transaction
		///  ~ NOTE: If you place a buy order that already matches a sell order that's on market, it will act as an 'instant' buy order.
		/// </summary>
		public bool PlaceBuyOrder(int stationID, int typeID, double price, int quantity, string range, int minQuantity, int duration)
		{
			Tracing.SendCallback("EVE.PlaceBuyOrder", stationID, typeID, price, quantity, range, minQuantity, duration);
			return ExecuteMethod("PlaceBuyOrder",
				stationID.ToString(),
				typeID.ToString(),
				price.ToString(),
				quantity.ToString(),
				range,
				minQuantity.ToString(),
				duration.ToString());
		}

		/// <summary>
		///   2. ClearMarketOrderCache     {This clears your market order cache.  It is useful if you're doing a lot of market transactions and want 
		///                                 to keep things tidy.}
		/// </summary>
		/// <returns></returns>
		public bool ClearMarketOrderCache()
		{
			Tracing.SendCallback("EVE.ClearMarketOrderCache");
			return ExecuteMethod("ClearMarketOrderCache");
		}

		/// <summary>
		/// Fetch the market orders matching the given typeID.
		/// </summary>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public bool FetchMarketOrders(int typeID)
		{
			Tracing.SendCallback("EVE.FetchMarketOrders", typeID);

			return ExecuteMethod("FetchMarketOrders", typeID.ToString());
		}

		/// <summary>
		/// Retrieve all market orders for the given typeID. Returns null if loading.
		/// </summary>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public List<MarketOrder> GetMarketOrders(int typeID)
		{
			Tracing.SendCallback("GetMarketOrders", typeID);

			return Util.GetListFromMethod<MarketOrder>(this, "GetMarketOrders", "marketorder", typeID.ToString());
		}

		/// <summary>
		/// Retrieve all market orders for the given typeID and given order type. Returns null if loading.
		/// </summary>
		/// <param name="typeID"></param>
		/// <param name="orderType"></param>
		/// <returns></returns>
		public List<MarketOrder> GetMarketOrders(int typeID, OrderType orderType)
		{
			Tracing.SendCallback("GetMarketOrders", typeID, orderType);

			return Util.GetListFromMethod<MarketOrder>(this, "GetMarketOrders", "marketorder", typeID.ToString(), orderType.ToString());
		}

		/// <summary>
		/// Wrapper for the Toggle3DDisplay method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool Toggle3DDisplay()
		{
			Tracing.SendCallback("EVE.Toggle3DDisplay");
			return ExecuteMethod("Toggle3DDisplay");
		}

		/// <summary>
		/// Wrapper for the ToggleUIDisplay method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool ToggleUIDisplay()
		{
			Tracing.SendCallback("EVE.ToggleUIDisplay");
			return ExecuteMethod("ToggleUIDisplay");
		}

		public bool ToggleTextureLoading()
		{
			Tracing.SendCallback("EVE.ToggleTextureLoading");
			return ExecuteMethod("ToggleTextureLoading");
		}

		/// <summary>
		/// Wrapper for the RefreshStandings method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool RefreshStandings()
		{
			Tracing.SendCallback("EVE.RefreshStandings");
			return ExecuteMethod("RefreshStandings");
		}

		public bool ReclaimDrones()
		{
			Tracing.SendCallback("EVE.ReclaimDrones");
			return ExecuteMethod("ReclaimDrones");
		}

		public List<long> GetViewedWrecks()
		{
			Tracing.SendCallback("EVE.GetViewedWrecks");
			return Util.GetListFromMethod<long>(this, "GetViewedWrecks", "int64");
		}

		public bool RefreshBookmarks()
		{
			Tracing.SendCallback("EVE.RefreshBookmarks");
			return ExecuteMethod("RefreshBookmarks");
		}
	}

	/// <summary>
	/// Represents the arguments passed as part of an EVE_OnChannelMessage event, parsing
	/// the text values in the LSEventArgs and producing something easily usible.
	/// </summary>
	public class EVE_OnChannelMessageEventArgs : EventArgs
	{
		public Int64 ChannelID = -1, CharID = -1, CorpID = -1, AllianceID = -1;
		public string CharName = string.Empty, MessageText = string.Empty;

		public EVE_OnChannelMessageEventArgs(LSEventArgs lsEventArgs)
		{
			ProcessLsEventArgs(lsEventArgs);
		}

		/// <summary>
		/// Process all of the string args in the LSEventArgs and set the values of this EventArgs object
		/// </summary>
		/// <param name="lsEventArgs"></param>
		private void ProcessLsEventArgs(LSEventArgs lsEventArgs)
		{
			ChannelID = StringToInt64(lsEventArgs.Args[0]);
			CharID = StringToInt64(lsEventArgs.Args[1]);
			CorpID = StringToInt64(lsEventArgs.Args[2]);
			AllianceID = StringToInt64(lsEventArgs.Args[3]);
			CharName = lsEventArgs.Args[4];
			MessageText = lsEventArgs.Args[5];
		}

		/// <summary>
		/// Convert string to 64-bit signed integer
		/// </summary>
		/// <param name="Int64Str">String value to convert to int64</param>
		/// <param name="DefaultValue">Value to return if conversion fails</param>
		private static Int64 StringToInt64(string Int64Str, Int64 DefaultValue = 0)
		{
			Int64 retVal;

			if (!Int64.TryParse(Int64Str, out retVal))
			{
				return DefaultValue;
			}

			return retVal;
		}
	}
}
