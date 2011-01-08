using System;
using System.Collections.Generic;
using InnerSpaceAPI;
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
		/// Get the number of items in the hanger.
		/// </summary>
		public int HangarItemsCount
		{
			get
			{
				return GetMember<int>("GetHangerItems");
			}
		}

		/// <summary>
		/// Get all the items in the hanger
		/// </summary>
		public List<Item> GetHangarItems()
		{
			return Util.GetListFromMember<Item>(this, "GetHangerItems", "item");
		}

		/// <summary>
		/// Get the number of ships in the hanger
		/// </summary>
		public int HangarShipsCount
		{
			get
			{
				return GetMember<int>("GetHangarShips");
			}
		}

		/// <summary>
		/// Get all the ships in the hanger as items.
		/// </summary>
		public List<Item> GetHangarShips()
		{
			return Util.GetListFromMember<Item>(this, "GetHangerShips", "item");
		}

		/// <summary>
		/// Get the number of items in the corporate hanger (all together)
		/// </summary>
		public int CorpHangarItemsCount
		{
			get
			{
				return GetMember<int>("GetCorpHangarItems");
			}
		}

		/// <summary>
		/// Get all the items in the corporate hanger (all together)
		/// </summary>
		public List<Item> GetCorpHangarItems()
		{
			return Util.GetListFromMember<Item>(this, "GetCorpHangarItems", "item");
		}

        /// <summary>
        /// Wrapper for the GetCorpHangarShips member of the station type.
        /// </summary>
        /// <returns></returns>
        public List<Item> GetCorpHangarShips()
        {
            return Util.GetListFromMember<Item>(this, "GetCorpHangarShips", "item");
        }


        /// <summary>
        /// Wrapper for Name member of station type.
        /// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

    /// <summary>
    /// Wrapper for Description member of station type.
    /// </summary>
		public string Description
		{
			get
			{
				return GetMember<string>("Description");
			}
		}

    /// <summary>
    /// Wrapper for ID member of station type.
    /// </summary>
		public int ID
		{
			get
			{
				return GetMember<int>("ID");
			}
		}

    /// <summary>
    /// Wrapper for TypeID member of station type.
    /// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}

    /// <summary>
    /// Wrapper for Type member of station type.
    /// </summary>
		public string Type
		{
			get
			{
				return GetMember<string>("Type");
			}
		}

    /// <summary>
    /// Wrapper for OwnerID member of station type.
    /// </summary>
		public int OwnerID
		{
			get
			{
				return GetMember<int>("OwnerID");
			}
		}

    /// <summary>
    /// Wrapper for Owner member of station type.
    /// </summary>
		public string Owner
		{
			get
			{
				return GetMember<string>("Owner");
			}
		}

    /// <summary>
    /// Wrapper for OwnerTypeID member of station type.
    /// </summary>
		public int OwnerTypeID
		{
			get
			{
				return GetMember<int>("OwnerTypeID");
			}
		}

    /// <summary>
    /// Wrapper for OwnerType member of station type.
    /// </summary>
		public string OwnerType
		{
			get
			{
				return GetMember<string>("OwnerType");
			}
		}

    /// <summary>
    /// Wrapper for SolarSystem member of station type.
    /// </summary>
		public Interstellar SolarSystem
		{
			get
			{
				return GetMember<Interstellar>("SolarSystem");
			}
		}

    /// <summary>
    /// Wrapper for Constellation member of station type.
    /// </summary>
		public Interstellar Constellation
		{
			get
			{
				return GetMember<Interstellar>("Constellation");
			}
		}

    /// <summary>
    /// Wrapper for Region member of station type.
    /// </summary>
		public Interstellar Region
		{
			get
			{
				return GetMember<Interstellar>("Region");
			}
		}

    /// <summary>
    /// Wrapper for X member of station type.
    /// </summary>
		public double X
		{
			get
			{
				return GetMember<double>("X");
			}
		}

    /// <summary>
    /// Wrapper for Y member of station type.
    /// </summary>
		public double Y
		{
			get
			{
				return GetMember<double>("Y");
			}
		}

    /// <summary>
    /// Wrapper for Z member of station type.
    /// </summary>
		public double Z
		{
			get
			{
				return GetMember<double>("Z");
			}
		}

    /// <summary>
    /// Wrapper for Radius member of station type.
    /// </summary>
		public double Radius
		{
			get
			{
				return GetMember<double>("Radius");
			}
		}

    /// <summary>
    /// Wrapper for Security member of station type.
    /// </summary>
		public int Security
		{
			get
			{
				return GetMember<int>("Security");
			}
		}

    /// <summary>
    /// Wrapper for DockingCostPerVolume member of station type.
    /// </summary>
		public double DockingCostPerVolume
		{
			get
			{
				return GetMember<double>("DockingCostPerVolume");
			}
		}

    /// <summary>
    /// Wrapper for MaxShipVolumeDockable member of station type.
    /// </summary>
		public double MaxShipVolumeDockable
		{
			get
			{
				return GetMember<double>("MaxShipVolumeDockable");
			}
		}

    /// <summary>
    /// Wrapper for OfficeRentalCost member of station type.
    /// </summary>
		public int OfficeRentalCost
		{
			get
			{
				return GetMember<int>("OfficeRentalCost");
			}
		}

    /// <summary>
    /// Wrapper for ReprocessingEfficiency member of station type.
    /// </summary>
		public double ReprocessingEfficiency
		{
			get
			{
				return GetMember<double>("ReprocessingEfficiency");
			}
		}

    /// <summary>
    /// Wrapper for ReprocessingStationTakes member of station type.
    /// </summary>
		public double ReprocessingStationTakes
		{
			get
			{
				return GetMember<double>("ReprocessingStationTakes");
			}
		}

    /// <summary>
    /// Wrapper for Conquerable member of station type.
    /// </summary>
		public bool Conquerable
		{
			get
			{
				return GetMember<bool>("Conquerable");
			}
		}

    /// <summary>
    /// Wrapper for GetServices member of station type.
    /// </summary>
    /// <returns></returns>
		public List<string> GetServices()
		{
			return Util.GetListFromMember<string>(this, "GetServices", "string");
		}
		#endregion

		#region Methods
		/// <summary>
		/// Same as right click - Stack All - consolidates stacks of items.
		/// </summary>
		public bool StackAllHangarItems()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("Station.StackAllHangarItems", string.Empty);
			return ExecuteMethod("StackAllHangarItems");
		}

        /// <summary>
        /// Open the corp hangar.
        /// </summary>
        /// <returns></returns>
		public bool OpenCorpHangar()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("Station.OpenCorpHangar", string.Empty);
			return ExecuteMethod("OpenCorpHangar");
		}
		#endregion
	}
}
