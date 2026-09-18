using System;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the agentmissionobjective data type.
	/// </summary>
	public class AgentMissionObjective : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// AgentMissionObjective copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public AgentMissionObjective(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// The objective type; currently "Dungeon".
		/// </summary>
		public string Type
		{
			get { return this.GetString("Type"); }
		}

		/// <summary>
		/// The objective state: Completed, Failed, or InProgress.
		/// </summary>
		public string State
		{
			get { return this.GetString("State"); }
		}

		/// <summary>
		/// The objective state id: 1=Completed, 0=Failed, 2=InProgress.
		/// </summary>
		public int StateID
		{
			get { return this.GetInt("StateID"); }
		}

		/// <summary>
		/// Wrapper for the IsComplete member of the agentmissionobjective type.
		/// </summary>
		public bool IsComplete
		{
			get { return this.GetBool("IsComplete"); }
		}

		/// <summary>
		/// Wrapper for the IsFailed member of the agentmissionobjective type.
		/// </summary>
		public bool IsFailed
		{
			get { return this.GetBool("IsFailed"); }
		}

		/// <summary>
		/// TRUE when this is an optional objective.
		/// </summary>
		public bool Optional
		{
			get { return this.GetBool("Optional"); }
		}

		/// <summary>
		/// Wrapper for the DungeonID member of the agentmissionobjective type.
		/// </summary>
		public long DungeonID
		{
			get { return this.GetInt64("DungeonID"); }
		}

		/// <summary>
		/// Wrapper for the LocationID member of the agentmissionobjective type.
		/// </summary>
		public long LocationID
		{
			get { return this.GetInt64("LocationID"); }
		}

		/// <summary>
		/// Wrapper for the SolarSystemID member of the agentmissionobjective type.
		/// </summary>
		public long SolarSystemID
		{
			get { return this.GetInt64("SolarSystemID"); }
		}

		/// <summary>
		/// The ship restrictions for this objective: None, Normal, or Special.
		/// </summary>
		public string ShipRestrictions
		{
			get { return this.GetString("ShipRestrictions"); }
		}

		/// <summary>
		/// The ship restriction id: 0=Normal, 1=Special, 2=None.
		/// </summary>
		public int ShipRestrictionID
		{
			get { return this.GetInt("ShipRestrictionID"); }
		}

		/// <summary>
		/// The position of this objective in the objective list, 0-based.
		/// </summary>
		public int Index
		{
			get { return this.GetInt("Index"); }
		}
		#endregion
	}
}
