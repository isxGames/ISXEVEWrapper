using System.Collections.Generic;
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
			get
			{
				return GetMember<string>("Name");
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
		#endregion

		#region Methods
		/// <summary>
		/// Same as right click - Stack All - consolidates stacks of items.
		/// </summary>
		public bool StackAllHangarItems()
		{
			Tracing.SendCallback("Station.StackAllHangarItems");
			return ExecuteMethod("StackAllHangarItems");
		}

		/// <summary>
		/// Open the corp hangar.
		/// </summary>
		/// <returns></returns>
		public bool OpenCorpHangar()
		{
			Tracing.SendCallback("Station.OpenCorpHangar");
			return ExecuteMethod("OpenCorpHangar");
		}
		#endregion
	}
}
