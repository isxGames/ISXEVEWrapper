using System;
using EVE.ISXEVE.Interfaces;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the bookmark data type.
	/// </summary>
	public class BookMark : LavishScriptObject, IBookMark
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
				//Tracing.SendCallback("Bookmark.ID");
				return this.GetInt64FromLSO("ID");
			}
		}

		/// <summary>
		/// Wrapper for the Type member of a bookmark object
		/// </summary>
		public string Type
		{
			get { return this.GetStringFromLSO("Type"); }
		}

		/// <summary>
		/// Wrapper for the TypeID member of a bookmark object
		/// </summary>
		public int TypeID
		{
			get { return this.GetIntFromLSO("TypeID"); }
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
			get { return this.GetIntFromLSO("SolarSystemID"); }
		}

		/// <summary>
		/// Wrapper for the X member of a bookmark object
		/// </summary>
		public double X
		{
			get { return this.GetDoubleFromLSO("X"); }
		}

		/// <summary>
		/// Wrapper for the Y member of a bookmark object
		/// </summary>
		public double Y
		{
			get { return this.GetDoubleFromLSO("Y"); }
		}

		/// <summary>
		/// Wrapper for the Z member of a bookmark object
		/// </summary>
		public double Z
		{
			get { return this.GetDoubleFromLSO("Z"); }
		}

		/// <summary>
		/// Wrapper for the Label member of a bookmark object
		/// </summary>
		public string Label
		{
			get { return this.GetStringFromLSO("Label"); }
		}

		/// <summary>
		/// Wrapper for the Note member of a bookmark object
		/// </summary>
		public string Note
		{
			get { return this.GetStringFromLSO("Note"); }
		}

		/// <summary>
		/// Wrapper for the DateCreated member of a bookmark object
		/// </summary>
		public string DateCreated
		{
			get { return this.GetStringFromLSO("DateCreated"); }
		}

		/// <summary>
		/// Wrapper for the TimeCreated member of a bookmark object
		/// </summary>
		public string TimeCreated
		{
			get { return this.GetStringFromLSO("TimeCreated"); }
		}

		/// <summary>
		/// Wrapper for the AgentID member of a bookmark object
		/// </summary>
		public int AgentID
		{
			get { return this.GetIntFromLSO("AgentID"); }
		}

		/// <summary>
		/// Wrapper for the LocationID member of a bookmark object
		/// </summary>
		public Int64 LocationID
		{
			get
			{
				Tracing.SendCallback("Bookmark.LocationID");
				return this.GetInt64FromLSO("LocationID");
			}
		}

		/// <summary>
		/// Wrapper for the LocationNumber member of a bookmark object
		/// </summary>
		public int LocationNumber
		{
			get { return this.GetIntFromLSO("LocationNumber"); }
		}

		/// <summary>
		/// Wrapper for the LocationType member of a bookmark object
		/// </summary>
		public string LocationType
		{
			get { return this.GetStringFromLSO("LocationType"); }
		}

		/// <summary>
		/// Wrapper for the ItemID member of a bookmark object
		/// </summary>
		public Int64 ItemID
		{
			get
			{
				Tracing.SendCallback("Bookmark.ItemID");
				return this.GetInt64FromLSO("ItemID");
			}
		}

        /// <summary>
        /// Wrapper for the CreatorID member of a bookmark object
        /// </summary>
        public Int64 CreatorID
        {
            get
            {
                Tracing.SendCallback("Bookmark.CreatorID");
                return this.GetInt64FromLSO("CreatorID");
            }
        }

        /// <summary>
        /// (NOTE:  Only works for agent bookmarks.)
        /// </summary>
        public bool DeadSpace
        {
            get { return this.GetBoolFromLSO("DeadSpace"); }
        }
		#endregion

		#region Methods
        /// <summary>
        /// This will only work with bookmarks for which there is an "AlignTo To" option available via the in-game UI.
        /// </summary>
        /// <returns></returns>
        public bool AlignTo()
        {
			Tracing.SendCallback("BM.AlignTo", string.Empty);
            return ExecuteMethod("AlignTo");
        }

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
