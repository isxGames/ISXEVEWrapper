using System;
using System.Collections.Generic;
using System.Text;
using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the agentmission data type.
	/// </summary>
	public class AgentMission : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// AgentMission copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public AgentMission(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region enums
		/// <summary>
		/// State of the mission
		/// </summary>
		public enum MissionState
		{
			Offered = 1,
			Accepted
		}

		/// <summary>
		/// Type of the mission
		/// </summary>
		public enum MissionType
		{
			Courier = 1,
			Encounter,
			Mining,
			Unknown
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the State member of the agentmission type.
		/// </summary>
		public int State
		{
			get { return this.GetInt("State"); }
		}

		/// <summary>
		/// Wrapper for the Type member of the agentmission type.
		/// </summary>
		public string Type
		{
			get { return this.GetString("Type"); }
		}

		/// <summary>
		/// Wrapper for the Name member of the agentmission type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

		/// <summary>
		/// Wrapper for the AgentID member of the agentmission type.
		/// </summary>
		public int AgentID
		{
			get { return this.GetInt("AgentID"); }
		}

		/// <summary>
		/// Wrapper for the ExpirationTime member of the agentmission type.
		/// </summary>
		public EVETime ExpirationTime
		{
			get
			{
				var expires = GetMember("ExpirationTime");
				return IsNullOrInvalid(expires) ? null : new EVETime(expires);
			}
		}

		public bool Expires
		{
			get { return this.GetBool("Expires"); }
		}

		/// <summary>
		/// Wrapper for the GetBookmarks member of the agentmission type.
		/// </summary>
		/// <returns></returns>
		public List<BookMark> GetBookmarks()
		{
			Tracing.SendCallback("AgentMission.GetDetails");
			return Util.GetListFromMethod<BookMark>(this, "GetBookmarks", "bookmark");
		}

		public bool RemoteOfferable
		{
			get { return this.GetBool("RemoteOfferable"); }
		}

		public bool RemoteCompletable
		{
			get { return this.GetBool("RemoteCompletable"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Get the details.
		/// </summary>
		public bool GetDetails()
		{
			Tracing.SendCallback("AgentMission.GetDetails");
			return ExecuteMethod("GetDetails");
		}
		#endregion

	}
}
