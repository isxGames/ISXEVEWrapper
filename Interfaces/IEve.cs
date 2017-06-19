using System;
using System.Collections.Generic;
using LavishScriptAPI.Interfaces;
using EVE.ISXEVE.Enums;

namespace EVE.ISXEVE.Interfaces
{
	/// <summary>
	/// Wrapper for the EVE datatype.
	/// </summary>
	public interface IEve : ILSObject
	{
	  /// <summary>
	  /// Number of entities currently in range of your overhead
	  /// </summary>
	  int EntitiesCount { get; }

	  /// <summary>
	  /// # of seconds until a session change can be performed. This includes docking, undocking, exiting a ship, entering a new ship, etc.
	  /// </summary>
	  int NextSessionChange { get; }

	  /// <summary>
	  /// example: "18:23:55"
	  /// </summary>
	  string Time { get; }

	  /// <summary>
	  /// example: "18:23"
	  /// </summary>
	  string TimeShort { get; }

	  /// <summary>
	  /// example: "2007.08.25"
	  /// </summary>
	  string Date { get; }

	  /// <summary>
	  /// Wrapper for the Is3DDisplayOn member of the eve type.
	  /// </summary>
	  bool Is3DDisplayOn { get; }

	  /// <summary>
	  /// Wrapper for the IsUIDisplayOn member of the eve type.
	  /// </summary>
	  bool IsUIDisplayOn { get; }

	  bool IsTextureLoadingOn { get; }
	  bool AbandonedDronesExist { get; }
	  bool IsProgressWindowOpen { get; }
	  string ProgressWindowTitle { get; }

	  /// <summary>
	  /// Returns the number of chat channels currently open in your UI
	  /// </summary>
	  /// <returns></returns>
	  Int32 NumOpenChannels { get; }

	  /// <summary>
	  /// Wrapper for the StationID member of the eve type.
	  /// </summary>
	  /// <param name="stationID"></param>
	  /// <returns></returns>
	  Station Station(int stationID);

	  /// <summary>
	  /// Returns a list of the "SystemIDs" of the systems along your current destination (autopilot) route.
	  /// Returns a single -1 if you currently have no destinations.
	  /// </summary>
	  List<int> GetToDestinationPath();

	  /// <summary>
	  /// Returns a list of the "SystemIDs" of the waypoints in your current route.
	  /// </summary>
	  List<int> GetWaypoints();

	  /// <summary>
	  /// Wrapper for the GetAgentMissions member of the eve type.
	  /// </summary>
	  /// <returns></returns>
	  List<AgentMission> GetAgentMissions();

	  /// <summary>
	  /// Returns a bookmark based on its label.
	  /// </summary>
	  BookMark Bookmark(string label);

	  /// <summary>
	  /// Returns a list of your bookmarks.
	  /// </summary>
	  List<BookMark> GetBookmarks();

	  /// <summary>
	  /// Returns number of jumps to the given solarsystem or station.
	  /// </summary>
	  int GetJumpsTo(int solarSystemOrStationId);

	  /// <summary>
	  /// Get the # of jumps between the given two solar systems.
	  /// </summary>
	  /// <param name="firstSolarSystem"></param>
	  /// <param name="secondSolarSystemId"></param>
	  /// <returns></returns>
	  int GetJumpsBetween(int firstSolarSystem, int secondSolarSystemId);

	  /// <summary>
	  /// Returns the distance between two entities.
	  /// </summary>
	  double DistanceBetween(Int64 firstEntityID, Int64 secondEntityID);

	  /// <summary>
	  /// Wrapper for the GetLocalPilots member of the eve type.
	  /// </summary>
	  /// <param name="args"></param>
	  /// <returns></returns>
	  List<Pilot> GetLocalPilots(params string[] args);

	  /// <summary>
	  /// Wrapper for the GetOnlineCorpMembers method of the eve type.
	  /// </summary>
	  /// <param name="args"></param>
	  /// <returns></returns>
	  List<Pilot> GetOnlineCorpMembersAsPilots(params string[] args);

	  /// <summary>
	  /// Wrapper for the GetOnlineCorpMembers method of the eve type.
	  /// </summary>
	  /// <param name="args"></param>
	  /// <returns></returns>
	  List<Being> GetOnlineCorpMembersAsBeings(params string[] args);

	  /// <summary>
	  /// Your "buddies"
	  /// </summary>
	  List<Being> GetBuddies();

	  /// <summary>
	  /// ISXEVE-20141001.0009 on October 4, 2014:
	  /// This does EXACTLY the same thing as "GetBuddies" does currently.  "GetBuddies" is now deprecated and should be removed. 
	  /// </summary>
	  /// <returns></returns>
	  IList<Being> GetContacts();

	  /// <summary>
	  /// the agents in your *addressbook* 
	  /// </summary>
	  List<Being> GetAgents();

	  /// <summary>
	  /// 1.  NumAssetsAtStation[#] (int type) [Returns the number of items currently housed at the StationID# given.]
	  /// </summary>
	  int NumAssetsAtStation(int stationID);

	  /// <summary>
	  /// 2.  GetLocationNameByID[#] (string type) [Useful for changing a StationID# to an actual name.]
	  /// </summary>
	  string GetLocationNameByID(int stationID);

	  /// <summary>
	  /// Download market order information from EVE servers.
	  /// </summary>
	  bool FetchMarketOrders();

	  /// <summary>
	  /// Get entities matching query specified by queryID.
	  /// Note: ID from Lavishscript query system -- query will not be freed
	  /// </summary>
	  /// <param name="queryID"></param>
	  /// <returns></returns>
	  List<Entity> QueryEntities(int queryID);

	  /// <summary>
	  /// Get entities matching the passed query.
	  /// Note: Uses Lavishscript query syntax, query will be created and destroyed after use
	  /// </summary>
	  /// <param name="queryString"></param>
	  /// <returns></returns>
	  List<Entity> QueryEntities(string queryString);

	  /// <summary>
	  /// Get all entities
	  /// </summary>
	  /// <returns></returns>
	  List<Entity> QueryEntities();

	  /// <summary>
	  /// if bool is true, forces repopulation of entities. This should be called ONCE after isxeve is loaded... any more will have no effect.
	  /// </summary>
	  /// <param name="forceRepopulate"></param>
	  /// <returns></returns>
	  bool PopulateEntities(bool forceRepopulate);

	  /// <summary>
	  /// This method creates a simple EVE popup window with the 'text' given.
	  /// </summary>
	  bool InfoWindow(string text);

	  /// <summary>
	  /// This method sets the status text that appears in space over your ship controls.
	  /// </summary>
	  bool SetInSpaceStatus(string title, string text);

	  /// <summary>
	  /// Order drones to engage active target.
	  /// </summary>
	  /// <param name="drones">drones to order</param>
	  /// <returns>true if successful, else false</returns>
	  bool DronesEngageMyTarget(List<Int64> drones);

	  /// <summary>
	  /// Order drones to mine repeatedly.
	  /// </summary>
	  /// <param name="drones">ActiveDrone IDs</param>
	  /// <returns></returns>
	  bool DronesMineRepeatedly(List<Int64> drones);

	  /// <summary>
	  /// Execute an eve command.
	  /// </summary>
	  bool Execute(ExecuteCommand command);

	  /// <summary>
	  /// Execute an eve command.
	  /// </summary>
	  bool Execute(string command);

	  /// <summary>
	  /// Creates a bookmark.
	  /// </summary>
	  bool CreateBookmark();

	  /// <summary>
	  /// Creates a bookmark.
	  /// </summary>
	  bool CreateBookmark(string label);

	  /// <summary>
	  /// Creates a bookmark.
	  /// </summary>
	  bool CreateBookmark(string label, string notes, string location);

	  /// <summary>
	  /// Wrapper for the AddWaypoint method of the eve type.
	  /// </summary>
	  /// <param name="solarSystemID"></param>
	  /// <returns></returns>
	  bool AddWaypoint(int solarSystemID);

	  bool ClearAllWaypoints();

	  /// <summary>
	  /// Closes any of the simple 'information message boxes', etc that might be up.
	  /// </summary>
	  bool CloseAllMessageBoxes();

	  /// <summary>
	  /// Wrapper for the CloseAllChatInvites method of the eve type.
	  /// </summary>
	  /// <returns></returns>
	  bool CloseAllChatInvites();

	  /// <summary>
	  /// Wrapper for the LaunchDrones method of the eve type.
	  /// </summary>
	  /// <param name="DroneIDs"></param>
	  /// <returns></returns>
	  bool LaunchDrones(List<Int64> DroneIDs);

	  /// <summary>
	  /// Wrapper for the ItemInfo member of the EVE datatype.
	  /// </summary>
	  /// <param name="typeId"></param>
	  /// <returns></returns>
	  IItemInfo ItemInfo(int typeId);

	  List<EVEWindow> GetEveWindows();

	  /// <summary>
	  /// Wrapper for the MoveItemsTo method fo the eve type.
	  /// </summary>
	  /// <param name="items"></param>
	  /// <param name="ToLocationID"></param>
	  /// <param name="destinationName"></param>
	  /// <returns></returns>
	  bool MoveItemsTo(List<Int64> items, Int64 ToLocationID, string destinationName);

	  /// <summary>
	  /// Wrapper for the MoveItemsTo method of the eve type.
	  /// </summary>
	  /// <param name="items"></param>
	  /// <param name="ToLocationID"></param>
	  /// <param name="destinationName"></param>
	  /// <param name="corporationHangarFolder"></param>
	  /// <returns></returns>
	  bool MoveItemsTo(List<Int64> items, Int64 ToLocationID, string destinationName, int corporationHangarFolder);

	  /// <summary>
	  /// Wrapper for the MoveItemsTo method fo the eve type.
	  /// </summary>
	  /// <param name="items"></param>
	  /// <param name="ToLocationName">'MyShip','MyStationHangar', or 'MyStationCorporateHangar'</param>
	  /// <param name="destinationName"></param>
	  /// <returns></returns>
	  bool MoveItemsTo(List<Int64> items, string ToLocationName, string destinationName);

	  /// <summary>
	  /// Wrapper for the MoveItemsTo method of the eve type.
	  /// </summary>
	  /// <param name="items"></param>
	  /// <param name="ToLocationName">'MyShip','MyStationHangar', or 'MyStationCorporateHangar'</param>
	  /// <param name="destinationName"></param>
	  /// <param name="corporationHangarFolder"></param>
	  /// <returns></returns>
	  bool MoveItemsTo(List<Int64> items, string ToLocationName, string destinationName, int corporationHangarFolder);

	  /// <summary>
	  /// 2. PlaceBuyOrder[StationID#, TypeID#, Price#, Quantity#, &lt;Range&gt;, MinQuantity#, &lt;Duration&gt;]
	  ///  ~ &lt;Range&gt; can be: "Station", "System", "Region", 1, 2, 3, 4, 5, 10, 20, 30, 40
	  ///  ~ Duration is in DAYS
	  ///  ~ To get your current stationID# use ${Me.StationID}
	  ///  ~ Quantity# is the MAX quantity you will buy overall, while MinQuantity# is the minimum that you will buy in a single transaction
	  ///  ~ NOTE: If you place a buy order that already matches a sell order that's on market, it will act as an 'instant' buy order.
	  /// </summary>
	  bool PlaceBuyOrder(int stationID, int typeID, double price, int quantity, string range, int minQuantity, int duration);

	  /// <summary>
	  ///   2. ClearMarketOrderCache     {This clears your market order cache.  It is useful if you're doing a lot of market transactions and want 
	  ///                                 to keep things tidy.}
	  /// </summary>
	  /// <returns></returns>
	  bool ClearMarketOrderCache();

	  /// <summary>
	  /// Fetch the market orders matching the given typeID.
	  /// </summary>
	  /// <param name="typeID"></param>
	  /// <returns></returns>
	  bool FetchMarketOrders(int typeID);

	  /// <summary>
	  /// Retrieve all market orders for the given typeID. Returns null if loading.
	  /// </summary>
	  /// <param name="typeID"></param>
	  /// <returns></returns>
	  List<MarketOrder> GetMarketOrders(int typeID);

	  /// <summary>
	  /// Retrieve all market orders for the given typeID and given order type. Returns null if loading.
	  /// </summary>
	  /// <param name="typeID"></param>
	  /// <param name="orderType"></param>
	  /// <returns></returns>
	  List<MarketOrder> GetMarketOrders(int typeID, OrderType orderType);

	  /// <summary>
	  /// Wrapper for the Toggle3DDisplay method of the eve type.
	  /// </summary>
	  /// <returns></returns>
	  bool Toggle3DDisplay();

	  /// <summary>
	  /// Wrapper for the ToggleUIDisplay method of the eve type.
	  /// </summary>
	  /// <returns></returns>
	  bool ToggleUIDisplay();

	  bool ToggleTextureLoading();

	  /// <summary>
	  /// Wrapper for the RefreshStandings method of the eve type.
	  /// </summary>
	  /// <returns></returns>
	  bool RefreshStandings();

	  bool ReclaimDrones();
	  List<long> GetViewedWrecks();
	  bool RefreshBookmarks();
	}
}