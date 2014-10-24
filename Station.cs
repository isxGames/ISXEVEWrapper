using System.Collections.Generic;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the station data type.
	/// </summary>
	public class Station : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// The station we're in.  Invalid if we're not in station.
		/// Check using LavishScriptObject.IsNullOrInvalid
		/// </summary>
		public Station()
			: base(LavishScript.Objects.GetObject("Me").GetMember("Station"))
		{
		}

		/// <summary>
		/// Station copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public Station(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Get all the items in the hanger
		/// </summary>
		public List<Item> GetHangarItems()
		{
			Tracing.SendCallback("Station.GetHangarItems");
			return Util.GetListFromMethod<Item>(this, "GetHangerItems", "item");
		}

		/// <summary>
		/// Get all the ships in the hanger as items.
		/// </summary>
		public List<Item> GetHangarShips()
		{
			Tracing.SendCallback("Station.GetCorpHangarShips");
			return Util.GetListFromMethod<Item>(this, "GetHangerShips", "item");
		}

		/// <summary>
		/// Get all the items in the corporate hanger (all together)
		/// </summary>
		public List<Item> GetCorpHangarItems()
		{
			Tracing.SendCallback("Station.GetCorpHangarItems");
			return Util.GetListFromMethod<Item>(this, "GetCorpHangarItems", "item");
		}

        /// <summary>
        /// Wrapper for the GetCorpHangarShips member of the station type.
        /// </summary>
        /// <returns></returns>
        public List<Item> GetCorpHangarShips()
        {
            Tracing.SendCallback("Station.GetCorpHangarShips");
            return Util.GetListFromMethod<Item>(this, "GetCorpHangarShips", "item");
        }

		/// <summary>
		/// Wrapper for Name member of station type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

		/// <summary>
		/// Wrapper for ID member of station type.
		/// </summary>
		public int ID
		{
			get { return this.GetInt("ID"); }
		}

		/// <summary>
		/// Wrapper for TypeID member of station type.
		/// </summary>
		public int TypeID
		{
			get { return this.GetInt("TypeID"); }
		}

		/// <summary>
		/// Wrapper for Type member of station type.
		/// </summary>
		public string Type
		{
			get { return this.GetString("Type"); }
		}

		/// <summary>
		/// Wrapper for OwnerID member of station type.
		/// </summary>
		public int OwnerID
		{
			get { return this.GetInt("OwnerID"); }
		}

		/// <summary>
		/// Wrapper for Owner member of station type.
		/// </summary>
		public string Owner
		{
			get { return this.GetString("Owner"); }
		}

		/// <summary>
		/// Wrapper for OwnerTypeID member of station type.
		/// </summary>
		public int OwnerTypeID
		{
			get { return this.GetInt("OwnerTypeID"); }
		}

		/// <summary>
		/// Wrapper for OwnerType member of station type.
		/// </summary>
		public string OwnerType
		{
			get { return this.GetString("OwnerType"); }
		}

	    private SolarSystem _solarSystem;

	    public SolarSystem SolarSystem
	    {
	        get { return _solarSystem ?? (_solarSystem = new SolarSystem(GetMember("SolarSystem"))); }
	    }
		#endregion

		#region Methods
		/// <summary>
		/// Same as right click - Stack All - consolidates stacks of items.
		/// </summary>
		public bool StackAllHangarItems()
		{
            // TODO - Remove this when stealthbot is updated.
            Tracing.SendCallback("Station.StackAllHangarItems - Redirecting to EVEWindow");
            EVEWindow wnd = new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", "ByName", "hangarFloor"));
            return wnd.StackAll();
		}

        public bool AddWaypoint()
        {
            Tracing.SendCallback("Station.AddWaypoint");
            return ExecuteMethod("AddWaypoint");
        }

        public bool ClearWaypoint()
        {
            Tracing.SendCallback("Station.ClearWaypoint");
            return ExecuteMethod("ClearWaypoint");
        }

        public bool SetDestination()
        {
            Tracing.SendCallback("Station.SetDestination");
            return ExecuteMethod("SetDestination");
        }

	    public List<Item> GetRepairableItems()
	    {
	        var repairableItems = this.GetListFromMethod<Item>("GetRepairableItems", "item");
	        return repairableItems;
	    }

        
        #endregion
    }
}
