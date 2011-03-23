using System;
using System.Collections.Generic;
using System.Text;

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
			get
			{
				return GetMember<int>("State");
			}
		}

		/// <summary>
		/// Wrapper for the Type member of the agentmission type.
		/// </summary>
		public string Type
		{
			get
			{
				return GetMember<string>("Type");
			}
		}

		/// <summary>
		/// Wrapper for the Name member of the agentmission type.
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Wrapper for the AgentID member of the agentmission type.
		/// </summary>
		public int AgentID
		{
			get
			{
				return GetMember<int>("AgentID");
			}
		}

		/// <summary>
		/// Wrapper for the Expires member of the agentmission type.
		/// </summary>
		public EVETime Expires
		{
			get
			{
				LavishScriptObject expires = GetMember("Expires");
				if (LavishScriptObject.IsNullOrInvalid(expires))
				{
					return null;
				}
				else
				{
					return new EVETime(expires);
				}
			}
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
            get
            {
                return GetMember<bool>("RemoteOfferable");
            }
        }

        public bool RemoteCompletable
        {
            get
            {
                return GetMember<bool>("RemoteCompletable");
            }
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
