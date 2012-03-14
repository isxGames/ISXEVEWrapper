using System;
using Extensions;
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
			get { return this.GetIntFromLSO("ID"); }
		}

		/// <summary>
		/// Wrapper for Name member of interstellar type.
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

		/// <summary>
		/// Wrapper for Type member of interstellar type.
		/// </summary>
		public string Type
		{
			get { return this.GetStringFromLSO("Type"); }
		}

		/// <summary>
		/// Wrapper for TypeID member of interstellar type.
		/// </summary>
		public int TypeID
		{
			get { return this.GetIntFromLSO("TypeID"); }
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
			get { return this.GetFloatFromLSO("Security"); }
		}

        /// <summary>
        /// Only works for solar systems
        /// </summary>
        public int FactionID
        {
            get { return this.GetIntFromLSO("FactionID"); }
        }

        /// <summary>
        /// Only works for solar systems
        /// </summary>
        public string Faction
        {
            get { return this.GetStringFromLSO("Faction"); }
        }
		#endregion

		#region Methods
		public bool AddWaypoint()
		{
			Tracing.SendCallback("Interstellar.AddWaypoint");
			return ExecuteMethod("AddWaypoint");
		}

        public bool ClearWaypoint()
        {
            Tracing.SendCallback("Interstellar.ClearWaypoint");
            return ExecuteMethod("ClearWaypoint");
        }

		public bool SetDestination()
		{
			Tracing.SendCallback("Interstellar.SetDestination");
			return ExecuteMethod("SetDestination");
		}
		#endregion
	}
}
