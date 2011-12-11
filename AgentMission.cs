using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
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

		#region Members
		/// <summary>
		/// Wrapper for the State member of the agentmission type.
		/// </summary>
		public int State
		{
			get { return this.GetIntFromLSO("State"); }
		}

		/// <summary>
		/// Wrapper for the Type member of the agentmission type.
		/// </summary>
		public string Type
		{
			get { return this.GetStringFromLSO("Type"); }
		}

		/// <summary>
		/// Wrapper for the Name member of the agentmission type.
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

		/// <summary>
		/// Wrapper for the AgentID member of the agentmission type.
		/// </summary>
		public int AgentID
		{
			get { return this.GetIntFromLSO("AgentID"); }
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
			get { return this.GetBoolFromLSO("Expires"); }
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
            get { return this.GetBoolFromLSO("RemoteOfferable"); }
        }

        public bool RemoteCompletable
        {
            get { return this.GetBoolFromLSO("RemoteCompletable"); }
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
