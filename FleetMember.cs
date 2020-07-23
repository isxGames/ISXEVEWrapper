using System;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the fleetmember data type.
	/// </summary>
	public class FleetMember : Pilot
	{
		#region Constructors
		/// <summary>
		/// FleetMember object copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public FleetMember(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for Job member of fleetmember type.
		/// </summary>
		public string Job
		{
			get { return this.GetString("Job"); }
		}

		/// <summary>
		/// Wrapper for JobID member of fleetmember type.
		/// </summary>
		public int JobID
		{
			get { return this.GetInt("JobID"); }
		}

		/// <summary>
		/// Wrapper for Role member of fleetmember type.
		/// </summary>
		public string Role
		{
			get { return this.GetString("Role"); }
		}

		/// <summary>
		/// Wrapper for RoleID member of fleetmember type.
		/// </summary>
		public int RoleID
		{
			get { return this.GetInt("RoleID"); }
		}

		/// <summary>
		/// Wrapper for Boosting member of fleetmember type.
		/// </summary>
		public int Boosting
		{
			get { return this.GetInt("Boosting"); }
		}

		/// <summary>
		/// Wrapper for SquadID member of fleetmember type.
		/// </summary>
		public Int64 SquadID
		{
			get { return this.GetInt64("SquadID"); }
		}

		/// <summary>
		/// Wrapper for WingID member of fleetmember type.
		/// </summary>
		public Int64 WingID
		{
			get { return this.GetInt64("WingID"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Warps to zero meters of this Fleet member
		/// </summary>
		public bool WarpTo()
		{
			Tracing.SendCallback("FleetMember.WarpTo", string.Empty);
			return ExecuteMethod("WarpTo");
		}

		/// <summary>
		/// Warps to within the given distance of this fleet member
		/// </summary>
		public bool WarpTo(int Distance)
		{
			Tracing.SendCallback("FleetMember.WarpTo", Distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("WarpTo", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Warps the fleet to zero meters of this fleet member
		/// </summary>
		public bool WarpFleetTo()
		{
			Tracing.SendCallback("FleetMember.WarpFleetTo");
			return ExecuteMethod("WarpFleetTo");
		}

		/// <summary>
		/// Warps the fleet to within Distance meters of this fleet member
		/// </summary>
		public bool WarpFleetTo(int Distance)
		{
			Tracing.SendCallback("FleetMember.WarpFleetTo", Distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("WarpFleetTo", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Note: You can also 'kick' yourself from a fleet.
		/// </summary>
		public bool Kick()
		{
			Tracing.SendCallback("FleetMember.Kick");
			return ExecuteMethod("Kick");
		}

		/// <summary>
		/// Wrapper for MakeLeader method of fleetmember type.
		/// </summary>
		/// <returns></returns>
		public bool MakeLeader()
		{
			Tracing.SendCallback("FleetMember.MakeLeader");
			return ExecuteMethod("MakeLeader");
		}

		/// <summary>
		/// Wrapper for Move method of fleetmember type.
		/// </summary>
		/// <param name="WingID"></param>
		/// <param name="SquadID"></param>
		/// <returns></returns>
		public bool Move(Int64 WingID, Int64 SquadID)
		{
			Tracing.SendCallback("FleetMember.Move", WingID, SquadID);
			return ExecuteMethod("Move", WingID.ToString(CultureInfo.CurrentCulture), SquadID.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for MoveToSquadCommander method of fleetmember type.
		/// </summary>
		/// <param name="WingID"></param>
		/// <param name="SquadID"></param>
		/// <returns></returns>
		public bool MoveToSquadCommander(Int64 WingID, Int64 SquadID)
		{
			Tracing.SendCallback("FleetMember.MoveToSquadCommander", WingID, SquadID);
			return ExecuteMethod("MoveToSquadCommander", WingID.ToString(CultureInfo.CurrentCulture), SquadID.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for MoveToWingCommander method of fleetmember type.
		/// </summary>
		/// <param name="WingID"></param>
		/// <returns></returns>
		public bool MoveToWingCommander(Int64 WingID)
		{
			Tracing.SendCallback("FleetMember.MoveToWingCommander", WingID.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("MoveToWingCommander", WingID.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for MoveToFleetCommander method of fleetmember type.
		/// </summary>
		/// <returns></returns>
		public bool MoveToFleetCommander()
		{
			Tracing.SendCallback("FleetMember.MoveToFleetCommander");
			return ExecuteMethod("MoveToFleetCommander");
		}
		#endregion
	}
}
