using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the eve data type.
	/// </summary>
	public class EVE : LavishScriptPersistentObject
	{
		#region Constructors
		/// <summary>
		/// Copy constructor for the EVE object.
		/// </summary>
		/// <param name="Obj"></param>
		public EVE(LavishScriptPersistentObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Constructor for the EVE object.  Returns the persistent LS object.
		/// </summary>
		public EVE()
			: base(LavishScript.Objects.GetPersistentObject("EVE"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the StationID member of the eve type.
		/// </summary>
		/// <param name="StationID"></param>
		/// <returns></returns>
		public Station Station(int StationID)
		{
			return GetMember<Station>("Station", StationID.ToString());
		}
		/// <summary>
		/// Number of pilots in the Local channel
		/// </summary>
		public int LocalsCount
		{
			get
			{
				return GetMember<int>("LocalsCount");
			}
		}

		/// <summary>
		/// Number of entities currently in range of your overhead
		/// </summary>
		public int EntitiesCount
		{
			get
			{
				return GetMember<int>("EntitiesCount");
			}
		}
		/// <summary>
		/// This member retrieves the standing between the two ID#s given.  Any 'CharID', 'ShipID', 'CorporationID', or 'AllianceID' should work.
		/// </summary>
		public double Standing(int FromID, int ToID)
		{
			return GetMember<double>("Standing", FromID.ToString(), ToID.ToString());
		}

		/// <summary>
		/// If no optional parameters are used, then the given List is filled with an array 
		/// of entities visible to the client at the point of creation (sorted by distance.) 
		/// The optional parameters can be anything typically used with the entity search 
		/// routines (including 'sorting' parameters).
		/// </summary>
		public List<Entity> GetEntities(params string[] Args)
		{
			return Util.GetListFromMember<Entity>(this, "GetEntities", "entity", Args);
			//return new List<Entity>();
		}

		/// <summary>
		/// Get a list of the IDs of all entities.
		/// </summary>
		/// <returns></returns>
		public List<Int64> GetEntityIDs()
		{
			return Util.GetListFromMethod<Int64>(this, "DoGetEntityIDs", "int64");
		}

		/// <summary>
		/// If no optional parameters are used, then the given List is filled with an array 
		/// of cached entities visible to the client at the point of creation (sorted by distance.) 
		/// The optional parameters can be anything typically used with the entity search 
		/// routines (including 'sorting' parameters).
		/// </summary>
		public List<CachedEntity> GetCachedEntities(params string[] Args)
		{
			return Util.GetListFromMethod<CachedEntity>(this, "GetCachedEntities", "cachedentity", Args);
			//return new List<Entity>();
		}

		/// <summary>
		/// Returns a list of the "SystemIDs" of the systems along your current destination (autopilot) route.
		/// Returns a single -1 if you currently have no destinations.
		/// </summary>
		public List<int> GetToDestinationPath()
		{
			return Util.GetListFromMember<int>(this, "GetToDestinationPath", "int");
		}

		/// <summary>
		/// Returns a list of the "SystemIDs" of the waypoints in your current route.
		/// </summary>
		public List<int> GetWaypoints()
		{
			return Util.GetListFromMember<int>(this, "GetWaypoints", "int");
		}

		/// <summary>
		/// Wrapper for the GetAgentMissions member of the eve type.
		/// </summary>
		/// <returns></returns>
		public List<AgentMission> GetAgentMissions()
		{
			return Util.GetListFromMember<AgentMission>(this, "GetAgentMissions", "agentmission");
		}

		/// <summary>
		/// Returns a bookmark based on its label.
		/// </summary>
		public BookMark Bookmark(string label)
		{
			return new BookMark(GetMember("Bookmark", label));
		}

		/// <summary>
		/// Returns a list of your bookmarks.
		/// </summary>
		public List<BookMark> GetBookmarks()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.GetBookmarks", string.Empty);
			return Util.GetListFromMember<BookMark>(this, "GetBookmarks", "bookmark");
		}

		/// <summary>
		/// Returns number of jump to a station. Returns -1 if you're currently in the station.
		/// </summary>
		public int JumpsToStation(int StationID)
		{
			return GetMember<int>("JumpsToStation", StationID.ToString());
		}

		/// <summary>
		/// Returns the distance between two entities.
		/// </summary>
		public double DistanceBetween(int Entity1ID, int Entity2ID)
		{
			return GetMember<double>("DistanceBetween", Entity1ID.ToString(), Entity2ID.ToString());
		}

		/// <summary>
		/// example: "18:23:55"
		/// </summary>
		public string Time
		{
			get
			{
				return GetMember<string>("Time");
			}
		}

		/// <summary>
		/// example: "18:23"
		/// </summary>
		public string TimeShort
		{
			get
			{
				return GetMember<string>("Time", "short");
			}
		}

		/// <summary>
		/// example: "2007.08.25"
		/// </summary>
		public string Date
		{
			get
			{
				return GetMember<string>("Date");
			}
		}

		/// <summary>
		/// Wrapper for the Is3DDisplayOn member of the eve type.
		/// </summary>
		public bool Is3DDisplayOn
		{
			get
			{
				LavishScriptObject is3dDisplayOn = GetMember("Is3DDisplayOn");
				if (LavishScriptObject.IsNullOrInvalid(is3dDisplayOn))
				{
					return true;
				}
				else
				{
					return is3dDisplayOn.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the IsUIDisplayOn member of the eve type.
		/// </summary>
		public bool IsUIDisplayOn
		{
			get
			{
				LavishScriptObject isUiDisplayOn = GetMember("IsUIDisplayOn");
				if (LavishScriptObject.IsNullOrInvalid(isUiDisplayOn))
				{
					return true;
				}
				else
				{
					return isUiDisplayOn.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the GetPilots member of the eve type.
		/// </summary>
		/// <param name="Args"></param>
		/// <returns></returns>
		public List<Pilot> GetPilots(params string[] Args)
		{
			return Util.GetListFromMember<Pilot>(this, "GetPilots", "pilot", Args);
			//return new List<LocalPilots>();
		}

		/// <summary>
		/// Wrapper for the PilotsCount member of the eve type.
		/// </summary>
		public int PilotsCount
		{
			get
			{
				return GetMember<int>("GetPilots");
			}
		}

		/// <summary>
		/// the agents in your *addressbook*
		/// </summary>
		public List<Being> GetBuddies()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.DoGetBuddies", string.Empty);
			return Util.GetListFromMethod<Being>(this, "DoGetBuddies", "being");
		}

		/// <summary>
		/// the number of agents in your *addressbook*
		/// </summary>
		public int BuddiesCount
		{
			get
			{
				return GetBuddies().Count;
			}
		}

		/// <summary>
		/// Returns the number of chat channels currently open in your UI
		/// </summary>
		/// <returns></returns>
		public Int32 NumOpenChannels
		{
			get
			{
				return GetMember<Int32>("NumOpenChannels");
			}
		}

		/// <summary>
		/// Retrieve all channel messages
		/// </summary>
		/// <returns></returns>
		public List<String> GetChannelMessages()
		{
			return Util.GetListFromMethod<String>(this, "DoGetChannelMessages", "string");
		}

		/// <summary>
		/// Retrieves all messages from the given channel
		/// </summary>
		/// <param name="ChannelName"></param>
		/// <returns></returns>
		public List<String> GetChannelMessages(string ChannelName)
		{
			return Util.GetListFromMethod<String>(this, "DoGetChannelMessages", "string", ChannelName);
		}

		/// <summary>
		/// Retrieves all channel messages since timestamp #
		/// </summary>
		/// <param name="TimeStamp"></param>
		/// <returns></returns>
		public List<String> GetChannelMessages(long TimeStamp)
		{
			return Util.GetListFromMethod<String>(this, "DoGetChannelMessages", "string", TimeStamp.ToString());
		}

		/// <summary>
		/// Retrieves all messages from the given channel since timestamp #
		/// </summary>
		/// <param name="ChannelName"></param>
		/// <param name="TimeStamp"></param>
		/// <returns></returns>
		public List<String> GetChannelMessages(string ChannelName, Int64 TimeStamp)
		{
			return Util.GetListFromMethod<String>(this, "DoGetChannelMessages", "string", ChannelName, TimeStamp.ToString());
		}

		/// <summary>
		/// 1.  NumAssetsAtStation[#] (int type) [Returns the number of items currently housed at the StationID# given.]
		/// </summary>
		public int NumAssetsAtStation(int StationID)
		{
			return GetMember<int>("NumAssetsAtStation", StationID.ToString());
		}

		/// <summary>
		/// 2.  GetLocationNameByID[#] (string type) [Useful for changing a StationID# to an actual name.]
		/// </summary>
		public string GetLocationNameByID(int StationID)
		{
			return GetMember<string>("GetLocationNameByID", StationID.ToString());
		}

		/// <summary>
		/// 1. GetMarketOrders[index:marketorder,#]         (int type) {retrieves all buy/sell orders currently cached by your client for the given TypeID#}
		///    GetMarketOrders[index:marketorder,#,"Buy"]   (int type) {retrieves all buy orders currently cached by your client for the given TypeID#}
		///    GetMarketOrders[index:marketorder,#,"Sell"]  (int type) {retrieves all sell orders currently cached by your client for the given TypeID#}
		/// </summary>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public List<MarketOrder> GetMarketOrders(int typeID)
		{
			return Util.GetListFromMember<MarketOrder>(this, "GetMarketOrders", "marketorder", typeID.ToString());
		}

		/// <summary>
		/// Wrapper for the GetMarketOrders member of the eve type.
		/// </summary>
		/// <param name="typeID"></param>
		/// <param name="buyOrSell"></param>
		/// <returns></returns>
		public List<MarketOrder> GetMarketOrders(int typeID, OrderType buyOrSell)
		{
			return Util.GetListFromMember<MarketOrder>(this, "GetMarketOrders", "marketorder", typeID.ToString(), buyOrSell.ToString());
		}
		#endregion

		#region Methods
		/// <summary>
		/// Get entities matching query specified by queryID.
		/// Note: ID from Lavishscript query system -- query will not be freed
		/// </summary>
		/// <param name="queryID"></param>
		/// <returns></returns>
		public List<Entity> QueryEntities(int queryID)
		{
			if (Tracing.Callback != null)
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
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.QueryEntities", queryString);
			return Util.GetListFromMethod<Entity>(this, "QueryEntities", "entity", queryString);
		}

		/// <summary>
		/// Get all entities
		/// Note: Uses Lavishscript query syntax, query will be created and destroyed after use
		/// </summary>
		/// <returns></returns>
		public List<Entity> QueryEntities()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.QueryEntities", "");
			return Util.GetListFromMethod<Entity>(this, "QueryEntities", "entity");
		}

		/// <summary>
		/// if bool is true, forces repopulation of entities. This should be called ONCE after isxeve is loaded... any more will have no effect.
		/// </summary>
		/// <param name="forceRepopulate"></param>
		/// <returns></returns>
		public bool PopulateEntities(bool forceRepopulate)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.PopulateEntities", forceRepopulate.ToString());
			return ExecuteMethod("PopulateEntities", forceRepopulate.ToString());
		}

		/// <summary>
		/// This method creates a simple EVE popup window with the 'text' given.
		/// </summary>
		public bool InfoWindow(string Text)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.InfoWindow", Text);
			return ExecuteMethod("InfoWindow", Text);
		}

		/// <summary>
		/// This method sets the status text that appears in space over your ship controls.
		/// </summary>
		public bool SetInSpaceStatus(string Title, string Text)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.SetInSpaceStatus", string.Empty);
			return ExecuteMethod("SetInSpaceStatus", Title, Text);
		}

		/// <summary>
		/// Order drones to engage active target.
		/// </summary>
		/// <param name="drones">drones to order</param>
		/// <returns>true if successful, else false</returns>
		public bool DronesEngageMyTarget(List<Int64> drones)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.DronesEngageMyTarget", string.Empty);
			LavishScriptObject LSIndex = LavishScript.Objects.NewObject("index:int64");
			foreach (Int64 i in drones)
			{
				LSIndex.ExecuteMethod("Insert", i.ToString());
			}
			return ExecuteMethod("DronesEngageMyTarget", LSIndex.GetLSReference());
		}

		/// <summary>
		/// Order drones to mine repeatedly.
		/// </summary>
		/// <param name="drones">ActiveDrone IDs</param>
		/// <returns></returns>
		public bool DronesMineRepeatedly(List<Int64> drones)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.DronesMineRepeatedly", string.Empty);

			LavishScriptObject LSIndex = LavishScript.Objects.NewObject("index:int64");
			foreach (Int64 droneID in drones)
			{
				LSIndex.ExecuteMethod("Insert", droneID.ToString());
			}
			return ExecuteMethod("DronesMineRepeatedly", LSIndex.GetLSReference());
		}

		/// <summary>
		/// Execute an eve command.
		/// </summary>
		public bool Execute(ExecuteCommand Command)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.Execute", Command.ToString());
			return ExecuteMethod("Execute", Command.ToString());
		}

		/// <summary>
		/// Execute an eve command.
		/// </summary>
		public bool Execute(string Command)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.Execute", Command);
			return ExecuteMethod("Execute", Command);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark()
		{
			return CreateBookmark(null, null);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark(string Label)
		{
			return CreateBookmark(Label, null);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark(string Label, string Notes)
		{
			if (!string.IsNullOrEmpty(Label) &&
				!string.IsNullOrEmpty(Notes))
			{
				if (Tracing.Callback != null)
					Tracing.SendCallback("EVE.CreateBookmark", String.Format("{0},{1}", Label, Notes));
				return ExecuteMethod("CreateBookmark", Label, Notes);
			}
			else if (!string.IsNullOrEmpty(Label))
			{
				if (Tracing.Callback != null)
					Tracing.SendCallback("EVE.CreateBookmark", Label);
				return ExecuteMethod("CreateBookmark", Label);
			}
			else
			{
				if (Tracing.Callback != null)
					Tracing.SendCallback("EVE.CreateBookmark", string.Empty);
				return ExecuteMethod("CreateBookmark");
			}
		}

		/// <summary>
		/// Wrapper for the AddWaypoint method of the eve type.
		/// </summary>
		/// <param name="SolarSystemID"></param>
		/// <returns></returns>
		public bool AddWaypoint(int SolarSystemID)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.AddWaypoint", SolarSystemID.ToString());
			return ExecuteMethod("AddWaypoint", SolarSystemID.ToString());
		}

		/// <summary>
		/// Closes any of the simple 'information message boxes', etc that might be up.
		/// </summary>
		public bool CloseAllMessageBoxes()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.CloseAllMessageBoxes", string.Empty);
			return ExecuteMethod("CloseAllMessageBoxes");
		}

		/// <summary>
		/// Wrapper for the CloseAllChatInvites method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool CloseAllChatInvites()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.CloseAllChatInvites", string.Empty);
			return ExecuteMethod("CloseAllChatInvites");
		}

		/// <summary>
		/// Destination may be one of:
		///		MyShip
		///		Hangar
		///		DroneBay
		///		Corporation Hangar
		/// </summary>
		/// <param name="Items"></param>
		/// <param name="Destination"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> Items, String Destination)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.MoveItemsTo", Destination);
			if (Items.Count == 0)
			{
				return false;
			}
			LavishScriptObject LSIndex = LavishScript.Objects.NewObject("index:int64");
			Int32 Count = Items.Count;
			for (int i = 0; i < Count; i++)
			{
				LSIndex.ExecuteMethod("Insert", Items[i].ToString());
			}
			//InnerSpace.Echo("*** " + LSIndex.GetMember<int>("Used"));
			// TODO - Test this to make sure passing a populated index into ExecuteMethod works
			// - CyberTech
			return ExecuteMethod("MoveItemsTo", LSIndex.GetLSReference(), Destination.ToString());
		}

		/// <summary>
		/// Destination is an Entity ID
		/// </summary>
		/// <param name="Items"></param>
		/// <param name="DestinationEntityID"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> Items, Int64 DestinationEntityID)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.", DestinationEntityID.ToString());
			if (Items.Count == 0)
			{
				return false;
			}
			LavishScriptObject LSIndex = LavishScript.Objects.NewObject("index:int64");
			Int32 Count = Items.Count;
			for (int i = 0; i < Count; i++)
			{
				LSIndex.ExecuteMethod("Insert", Items[i].ToString());
			}

			return ExecuteMethod("MoveItemsTo", LSIndex.GetLSReference(), DestinationEntityID.ToString());
		}

		/// <summary>
		/// Wrapper for the MoveItemsTo method of the eve type.
		/// </summary>
		/// <param name="Items"></param>
		/// <param name="DestinationEntityID"></param>
		/// <param name="CorporationHangarFolder"></param>
		/// <returns></returns>
		public bool MoveItemsTo(List<Int64> Items, Int64 DestinationEntityID, Int32 CorporationHangarFolder)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.MoveItemsTo", String.Format("{0},{1}", DestinationEntityID, CorporationHangarFolder));
			if (Items.Count == 0)
			{
				return false;
			}
			LavishScriptObject LSIndex = LavishScript.Objects.NewObject("index:int64");
			Int32 Count = Items.Count;
			for (int i = 0; i < Count; i++)
			{
				LSIndex.ExecuteMethod("Insert", Items[i].ToString());
			}

			return ExecuteMethod("MoveItemsTo", LSIndex.GetLSReference(), DestinationEntityID.ToString(),
				String.Format("Corporation Folder {0}", CorporationHangarFolder));
		}

		/// <summary>
		/// Parameter is the interval, in seconds, that you wish for ISXEVE to check for new messages.  The default is 3 seconds.
		/// Note: Works as a toggle
		/// </summary>
		/// <returns></returns>
		public bool ActivateChannelMessageEvents()
		{
			return ActivateChannelMessageEvents(3);
		}

		/// <summary>
		/// Parameter is the interval, in seconds, that you wish for ISXEVE to check for new messages.  The default is 3 seconds.
		/// Note: Works as a toggle
		/// </summary>
		/// <param name="IntervalInSeconds"></param>
		/// <returns></returns>
		public bool ActivateChannelMessageEvents(Int32 IntervalInSeconds)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.ActivateChannelMessageEvents", IntervalInSeconds.ToString());
			return ExecuteMethod("ActivateChannelMessageEvents", IntervalInSeconds.ToString());
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
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.PlaceBuyOrder", String.Format("{0},{1},{2},{3},{4},{5},{6}",
					stationID, typeID, price, quantity, range, minQuantity, duration));
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
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.ClearMarketOrderCache", string.Empty);
			return ExecuteMethod("ClearMarketOrderCache");
		}

		/// <summary>
		/// Fetch the market orders matching the given typeID.
		/// </summary>
		/// <param name="typeID"></param>
		/// <returns></returns>
		public bool FetchMarketOrders(int typeID)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.FetchMarketOrders", typeID.ToString());

			return ExecuteMethod("FetchMarketOrders", typeID.ToString());
		}

		/// <summary>
		/// Wrapper for the Toggle3DDisplay method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool Toggle3DDisplay()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.Toggle3DDisplay", string.Empty);
			return ExecuteMethod("Toggle3DDisplay");
		}

		/// <summary>
		/// Wrapper for the ToggleUIDisplay method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool ToggleUIDisplay()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("EVE.ToggleUIDisplay", string.Empty);
			return ExecuteMethod("ToggleUIDisplay");
		}
		#endregion

		/// <summary>
		/// Type of market order (buy or sell).
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

		/// <summary>
		/// Wrapper for the RefreshStandings method of the eve type.
		/// </summary>
		/// <returns></returns>
		public bool RefreshStandings()
		{
            if (Tracing.Callback != null)
			    Tracing.SendCallback("EVE.RefreshStandings", string.Empty);
			return ExecuteMethod("RefreshStandings");
		}
	}
}
