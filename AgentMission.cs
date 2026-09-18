using System;
using System.Collections.Generic;
using System.Globalization;
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
			None = 0,
			Offered,
			Accepted
		}

		/// <summary>
		/// Type of the mission
		/// </summary>
		public enum MissionType
		{
			None = 0,
			Courier,
			Encounter,
			Mining,
			Unknown
		}

		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ID member of the agentmission type.
		/// </summary>
		public int ID
		{
			get { return this.GetInt("ID"); }
		}

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
			Tracing.SendCallback("AgentMission.GetBookmarks");
			return Util.GetListFromMethod<BookMark>(this, "GetBookmarks", "bookmark");
		}

		/// <summary>
		/// Wrapper for the ImportantMission member of the agentmission type.
		/// </summary>
		public bool ImportantMission
		{
			get { return this.GetBool("ImportantMission"); }
		}

		public bool RemoteOfferable
		{
			get { return this.GetBool("RemoteOfferable"); }
		}

		public bool RemoteCompletable
		{
			get { return this.GetBool("RemoteCompletable"); }
		}

		/// <summary>
		/// TRUE once RefreshObjectives has cached this mission's objective data.
		/// </summary>
		public bool ObjectivesReady
		{
			get { return this.GetBool("ObjectivesReady"); }
		}

		/// <summary>
		/// The number of dungeon objectives on this mission.
		/// </summary>
		public int NumObjectives
		{
			get { return this.GetInt("NumObjectives"); }
		}

		/// <summary>
		/// The #th objective on this mission (1-based).
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public AgentMissionObjective Objective(int index)
		{
			var objective = GetMember<AgentMissionObjective>("Objective", index.ToString(CultureInfo.CurrentCulture));
			return IsNullOrInvalid(objective) ? null : objective;
		}

		/// <summary>
		/// The mission completion status: 0=not complete, 1=complete, 2=GM cheat-complete.
		/// </summary>
		public int CompletionStatus
		{
			get { return this.GetInt("CompletionStatus"); }
		}

		/// <summary>
		/// TRUE when CompletionStatus == 2 (GM cheat-complete).
		/// </summary>
		public bool IsCheatComplete
		{
			get { return this.GetBool("IsCheatComplete"); }
		}

		/// <summary>
		/// Wrapper for the LoyaltyPoints member of the agentmission type.
		/// </summary>
		public long LoyaltyPoints
		{
			get { return this.GetInt64("LoyaltyPoints"); }
		}

		/// <summary>
		/// Wrapper for the ResearchPoints member of the agentmission type.
		/// </summary>
		public int ResearchPoints
		{
			get { return this.GetInt("ResearchPoints"); }
		}

		/// <summary>
		/// Wrapper for the NumNormalRewards member of the agentmission type.
		/// </summary>
		public int NumNormalRewards
		{
			get { return this.GetInt("NumNormalRewards"); }
		}

		/// <summary>
		/// Wrapper for the NumBonusRewards member of the agentmission type.
		/// </summary>
		public int NumBonusRewards
		{
			get { return this.GetInt("NumBonusRewards"); }
		}

		/// <summary>
		/// Wrapper for the NumCollateral member of the agentmission type.
		/// </summary>
		public int NumCollateral
		{
			get { return this.GetInt("NumCollateral"); }
		}

		/// <summary>
		/// Wrapper for the NumGrantedItems member of the agentmission type.
		/// </summary>
		public int NumGrantedItems
		{
			get { return this.GetInt("NumGrantedItems"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Primes the mission's objective data off-thread. Poll ObjectivesReady, then read the objective members.
		/// </summary>
		/// <returns></returns>
		public bool RefreshObjectives()
		{
			Tracing.SendCallback("AgentMission.RefreshObjectives");
			return ExecuteMethod("RefreshObjectives");
		}

		/// <summary>
		/// Wrapper for the GetObjectives method of the agentmission type.
		/// </summary>
		/// <returns></returns>
		public List<AgentMissionObjective> GetObjectives()
		{
			Tracing.SendCallback("AgentMission.GetObjectives");
			return Util.GetListFromMethod<AgentMissionObjective>(this, "GetObjectives", "agentmissionobjective");
		}
		#endregion
	}
}
