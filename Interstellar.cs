using System;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// This Data Type includes all of the data and actions available to ISXEVE about Systems, Constellations, and Regions.
	/// </summary>
	public class Interstellar : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Interstellar object copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public Interstellar(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for ID member of interstellar type.
		/// </summary>
		public int ID
		{
			get
			{
				return GetMember<int>("ID");
			}
		}

		/// <summary>
		/// Wrapper for Name member of interstellar type.
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Wrapper for Type member of interstellar type.
		/// </summary>
		public string Type
		{
			get
			{
				return GetMember<string>("Type");
			}
		}

		/// <summary>
		/// Wrapper for TypeID member of interstellar type.
		/// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}

		/// <summary>
		/// Wrapper for Region member of interstellar type.
		/// </summary>
		public Interstellar Region
		{
			get
			{
				return new Interstellar(GetMember("Region"));
			}
		}

		/// <summary>
		/// applicable for systems and constellations only
		/// </summary>
		public Interstellar Constellation
		{
			get
			{
				return new Interstellar(GetMember("Constellation"));
			}
		}

		/// <summary>
		/// Wrapper for Security member of interstellar type.
		/// </summary>
		public float Security
		{
			get
			{
				return GetMember<float>("Security");
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Only works for "Solar System" type interstellar types. Adds a waypoint to the autopilot queue. 
		/// </summary>
		public bool AddWaypoint()
		{
			Tracing.SendCallback("Interstellar.AddWaypoint");
			return ExecuteMethod("AddWaypoint");
		}

		/// <summary>
		/// Only works for "Solar System" type interstellar types. Sets the autopilot destination. 
		/// </summary>
		public bool SetDestination()
		{
			Tracing.SendCallback("Interstellar.SetDestination");
			return ExecuteMethod("SetDestination");
		}
		#endregion
	}
}
