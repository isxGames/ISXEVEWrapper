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
		#region Constants
		public readonly string EVENT_ON_CHANNEL_MESSAGE = "EVE_OnChannelMessage";
		#endregion

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
			Tracing.SendCallback("EVE.Station", StationID);
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
		/// If no optional parameters are used, then the given List is filled with an array 
		/// of entities visible to the client at the point of creation (sorted by distance.) 
		/// The optional parameters can be anything typically used with the entity search 
		/// routines (including 'sorting' parameters).
		/// </summary>
		public List<Entity> GetEntities(params string[] Args)
		{
			Tracing.SendCallback("EVE.GetEntities", Args);
			return Util.GetListFromMember<Entity>(this, "GetEntities", "entity", Args);
			//return new List<Entity>();
		}

		/// <summary>
		/// Get a list of the IDs of all entities.
		/// </summary>
		/// <returns></returns>
		public List<Int64> GetEntityIDs()
		{
			Tracing.SendCallback("EVE.DoGetEntityIDs");
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
			Tracing.SendCallback("EVE.GetCachedEntities", Args);
			return Util.GetListFromMethod<CachedEntity>(this, "GetCachedEntities", "cachedentity", Args);
			//return new List<Entity>();
		}

		/// <summary>
		/// Returns a list of the "SystemIDs" of the systems along your current destination (autopilot) route.
		/// Returns a single -1 if you currently have no destinations.
		/// </summary>
		public List<int> GetToDestinationPath()
		{
			Tracing.SendCallback("EVE.GetToDestinationPath");
			return Util.GetListFromMethod<int>(this, "DoGetToDestinationPath", "int");
		}

		/// <summary>
		/// Returns a list of the "SystemIDs" of the waypoints in your current route.
		/// </summary>
		public List<int> GetWaypoints()
		{
			Tracing.SendCallback("EVE.DoGetWaypoints");
			return Util.GetListFromMethod<int>(this, "DoGetWaypoints", "int");
		}

		/// <summary>
		/// Wrapper for the GetAgentMissions member of the eve type.
		/// </summary>
		/// <returns></returns>
		public List<AgentMission> GetAgentMissions()
		{
			Tracing.SendCallback("EVE.DoGetAgentMissions");
			return Util.GetListFromMethod<AgentMission>(this, "DoGetAgentMissions", "agentmission");
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
			Tracing.SendCallback("EVE.DoGetBookmarks", string.Empty);
			return Util.GetListFromMethod<BookMark>(this, "DoGetBookmarks", "bookmark");
		}

		/// <summary>
		/// Returns number of jump to a station. Returns -1 if you're currently in the station.
		/// </summary>
		public int JumpsToStation(int StationID)
		{
			Tracing.SendCallback("EVE.JumpsToStation", StationID.ToString());
			return GetMember<int>("JumpsToStation", StationID.ToString());
		}

		/// <summary>
		/// Returns the distance between two entities.
		/// </summary>
		public double DistanceBetween(int Entity1ID, int Entity2ID)
		{
			Tracing.SendCallback("EVE.DistanceBetween", Entity1ID.ToString(), Entity2ID.ToString());
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
			Tracing.SendCallback("EVE.DoGetPilots", Args);
			return Util.GetListFromMethod<Pilot>(this, "DoGetPilots", "pilot", Args);
			//return new List<LocalPilots>();
		}

		/// <summary>
		/// the agents in your *addressbook*
		/// </summary>
		public List<Being> GetBuddies()
		{
			Tracing.SendCallback("EVE.DoGetBuddies");
			return Util.GetListFromMethod<Being>(this, "DoGetBuddies", "being");
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
		/// 1.  NumAssetsAtStation[#] (int type) [Returns the number of items currently housed at the StationID# given.]
		/// </summary>
		public int NumAssetsAtStation(int StationID)
		{
			Tracing.SendCallback("EVE.NumAssetsAtStation", StationID.ToString());
			return GetMember<int>("NumAssetsAtStation", StationID.ToString());
		}

		/// <summary>
		/// 2.  GetLocationNameByID[#] (string type) [Useful for changing a StationID# to an actual name.]
		/// </summary>
		public string GetLocationNameByID(int StationID)
		{
			Tracing.SendCallback("EVE.GetLocationNameByID", StationID.ToString());
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
			Tracing.SendCallback("EVE.GetMarketOrders", typeID.ToString());
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
			Tracing.SendCallback("EVE.GetMarketOrders", typeID.ToString(), buyOrSell.ToString());
            return Util.GetListFromMember<MarketOrder>(this, "GetMarketOrders", "marketorder", typeID.ToString(), buyOrSell.ToString());
		}

		/// <summary>
		/// Download market order information from EVE servers.
		/// </summary>
		public bool FetchMarketOrders()
		{
			Tracing.SendCallback("EVE.FetchMarketOrders");
			return ExecuteMethod("FetchMarketOrders");
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
		/// Note: Uses Lavishscript query syntax, query will be created and destroyed after use
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
		public bool InfoWindow(string Text)
		{
			Tracing.SendCallback("EVE.InfoWindow", Text);
			return ExecuteMethod("InfoWindow", Text);
		}

		/// <summary>
		/// This method sets the status text that appears in space over your ship controls.
		/// </summary>
		public bool SetInSpaceStatus(string Title, string Text)
		{
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
			Tracing.SendCallback("EVE.Execute", Command.ToString());
			return ExecuteMethod("Execute", Command.ToString());
		}

		/// <summary>
		/// Execute an eve command.
		/// </summary>
		public bool Execute(string Command)
		{
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
				Tracing.SendCallback("EVE.CreateBookmark", Label, Notes);
				return ExecuteMethod("CreateBookmark", Label, Notes);
			}
			else if (!string.IsNullOrEmpty(Label))
			{
				Tracing.SendCallback("EVE.CreateBookmark", Label);
				return ExecuteMethod("CreateBookmark", Label);
			}
			else
			{
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
			Tracing.SendCallback("EVE.AddWaypoint", SolarSystemID.ToString());
			return ExecuteMethod("AddWaypoint", SolarSystemID.ToString());
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
			Tracing.SendCallback("EVE.MoveItemsTo", DestinationEntityID, CorporationHangarFolder);
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
			Tracing.SendCallback("EVE.FetchMarketOrders", typeID.ToString());

			return ExecuteMethod("FetchMarketOrders", typeID.ToString());
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
			Tracing.SendCallback("EVE.RefreshStandings");
			return ExecuteMethod("RefreshStandings");
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
			_processLsEventArgs(lsEventArgs);
		}

		/// <summary>
		/// Process all of the string args in the LSEventArgs and set the values of this EventArgs object
		/// </summary>
		/// <param name="lsEventArgs"></param>
		void _processLsEventArgs(LSEventArgs lsEventArgs)
		{
			ChannelID = _stringToInt64(lsEventArgs.Args[0]);
			CharID = _stringToInt64(lsEventArgs.Args[1]);
			CorpID = _stringToInt64(lsEventArgs.Args[2]);
			AllianceID = _stringToInt64(lsEventArgs.Args[3]);
			CharName = lsEventArgs.Args[4];
			MessageText = lsEventArgs.Args[5];
		}

		Int64 _stringToInt64(string text)
		{
			Int64 retVal = -1;

			Int64.TryParse(text, out retVal);

			return retVal;
		}
	}
}
