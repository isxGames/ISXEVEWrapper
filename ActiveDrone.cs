using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the activedrone data type.
	/// </summary>
	public class ActiveDrone : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// ActiveDrone copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public ActiveDrone(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ID member of the activedrone type.
		/// </summary>
		public Int64 ID
		{
			get
			{
				Tracing.SendCallback("ActiveDrone.ID");
				return this.GetInt64FromLSO("ID");
			}
		}

		/// <summary>
		/// Wrapper for the Owner member of the activedrone type.
		/// </summary>
		public Pilot Owner
		{
			get
			{
				return new Pilot(GetMember("Owner"));
			}
		}

		/// <summary>
		/// Wrapper for the Controller member of the activedrone type.
		/// </summary>
		public Entity Controller
		{
			get
			{
				return new Entity(GetMember("Controller"));
			}
		}

		/// <summary>
		/// Wrapper for the Type member of the activedrone type.
		/// </summary>
		public string Type
		{
			get { return this.GetStringFromLSO("Type"); }
		}

		/// <summary>
		/// Wrapper for the TypeID member of the activedrone type.
		/// </summary>
		public int TypeID
		{
			get { return this.GetIntFromLSO("TypeID"); }
		}

		/// <summary>
		/// ie 0 is 'idle', etc.
		/// </summary>
		public int State
		{
			get { return this.GetIntFromLSO("State"); }
		}

		/// <summary>
		/// Wrapper for the ToEntity member of the activedrone type.
		/// </summary>
		public Entity ToEntity
		{
			get
			{
				return new Entity(GetMember("ToEntity"));
			}
		}

		/// <summary>
		/// Wrapper for the Target member of the activedrone type.
		/// </summary>
		public Entity Target
		{
			get
			{
				return new Entity(GetMember("Target"));
			}
		}
		#endregion
	}
}
