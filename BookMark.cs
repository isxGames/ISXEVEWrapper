using System;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the bookmark data type.
	/// </summary>
	public class BookMark : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Bookmark object copy constructor
		/// </summary>
		/// <param name="Copy"></param>
		public BookMark(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ID member of a bookmark object
		/// </summary>
		public Int64 ID
		{
			get
			{
				return GetMember<Int64>("ID");
			}
		}

		/// <summary>
		/// Wrapper for the Type member of a bookmark object
		/// </summary>
		public string Type
		{
			get
			{
				return GetMember<String>("Type");
			}
		}

		/// <summary>
		/// Wrapper for the TypeID member of a bookmark object
		/// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}

		/// <summary>
		/// If the bookmark refers to an entity currently available on your 
		/// overhead, it will return said entity. Use LavishScriptObject.IsNullOrInvalid
		/// to check for validity
		/// </summary>
		public Entity ToEntity
		{
			get
			{
				return new Entity(GetMember("ToEntity"));
			}
		}

		/// <summary>
		/// Wrapper for the SolarSystemID member of a bookmark object
		/// </summary>
		public int SolarSystemID
		{
			get
			{
				return GetMember<int>("SolarSystemID");
			}
		}

		/// <summary>
		/// Wrapper for the X member of a bookmark object
		/// </summary>
		public double X
		{
			get
			{
				LavishScriptObject x = GetMember("X");
				if (!LavishScriptObject.IsNullOrInvalid(x))
				{
					return x.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Y member of a bookmark object
		/// </summary>
		public double Y
		{
			get
			{
				LavishScriptObject y = GetMember("Y");
				if (!LavishScriptObject.IsNullOrInvalid(y))
				{
					return y.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Z member of a bookmark object
		/// </summary>
		public double Z
		{
			get
			{
				LavishScriptObject z = GetMember("Z");
				if (!LavishScriptObject.IsNullOrInvalid(z))
				{
					return z.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Label member of a bookmark object
		/// </summary>
		public string Label
		{
			get
			{
				return GetMember<string>("Label");
			}
		}

		/// <summary>
		/// Wrapper for the Note member of a bookmark object
		/// </summary>
		public string Note
		{
			get
			{
				return GetMember<string>("Note");
			}
		}

		/// <summary>
		/// Wrapper for the DateCreated member of a bookmark object
		/// </summary>
		public string DateCreated
		{
			get
			{
				return GetMember<string>("DateCreated");
			}
		}

		/// <summary>
		/// Wrapper for the TimeCreated member of a bookmark object
		/// </summary>
		public string TimeCreated
		{
			get
			{
				return GetMember<string>("TimeCreated");
			}
		}

		/// <summary>
		/// Wrapper for the AgentID member of a bookmark object
		/// </summary>
		public int AgentID
		{
			get
			{
				return GetMember<int>("AgentID");
			}
		}

		/// <summary>
		/// Wrapper for the LocationID member of a bookmark object
		/// </summary>
		public Int64 LocationID
		{
			get
			{
				return GetMember<Int64>("LocationID");
			}
		}

		/// <summary>
		/// Wrapper for the LocationNumber member of a bookmark object
		/// </summary>
		public int LocationNumber
		{
			get
			{
				return GetMember<int>("LocationNumber");
			}
		}

		/// <summary>
		/// Wrapper for the LocationType member of a bookmark object
		/// </summary>
		public string LocationType
		{
			get
			{
				return GetMember<string>("LocationType");
			}
		}

		/// <summary>
		/// Wrapper for the ItemID member of a bookmark object
		/// </summary>
		public Int64 ItemID
		{
			get
			{
				LavishScriptObject itemID = GetMember("ItemID");
				if (LavishScriptObject.IsNullOrInvalid(itemID))
				{
					return -1;
				}
				else
				{
					return itemID.GetValue<Int64>();
				}
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Warp to 0 distance
		/// </summary>
		public bool WarpTo()
		{
			Tracing.SendCallback("BM.WarpTo");
			return ExecuteMethod("WarpTo");
		}

		/// <summary>
		/// Warp to the given distance
		/// </summary>
		public bool WarpTo(int Distance)
		{
			Tracing.SendCallback("BM.WarpTo", Distance.ToString());
			return ExecuteMethod("WarpTo", Distance.ToString());
		}

		/// <summary>
		/// Removes bookmark.
		/// </summary>
		public bool Remove()
		{
			Tracing.SendCallback("BM.Remove");
			return ExecuteMethod("Remove");
		}

		/// <summary>
		/// Sets bookmark as current destination.
		/// </summary>
		public bool SetDestination()
		{
			Tracing.SendCallback("BM.SetDestination");
			return ExecuteMethod("SetDestination");
		}

		/// <summary>
		/// Add bookmark to waypoint list.
		/// </summary>
		public bool AddWaypoint()
		{
			Tracing.SendCallback("BM.AddWaypoint");
			return ExecuteMethod("AddWaypoint");
		}
		#endregion
	}
}
