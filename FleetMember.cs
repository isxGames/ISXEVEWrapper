using System;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the fleetmember data type.
	/// </summary>
	public class FleetMember : LavishScriptObject
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
		public Int32 ID
		{
			get
			{
				LavishScriptObject id = GetMember("ID");
				if (LavishScriptObject.IsNullOrInvalid(id))
				{
					return -1;
				}
				else
				{
					return id.GetValue<Int32>();
				}
			}
		}

		/// <summary>
		/// Wrapper for ToPilot member of fleetmember type.
		/// </summary>
		public Pilot ToPilot
		{
			get
			{
				return new Pilot(GetMember("ToPilot"));
			}
		}

		/// <summary>
		/// Wrapper for CharID member of fleetmember type.
		/// </summary>
		public int CharID
		{
			get
			{
				return GetMember<int>("CharID");
			}
		}

		/// <summary>
		/// Wrapper for Job member of fleetmember type.
		/// </summary>
		public string Job
		{
			get
			{
				return GetMember<string>("Job");
			}
		}

		/// <summary>
		/// Wrapper for JobID member of fleetmember type.
		/// </summary>
		public int JobID
		{
			get
			{
				return GetMember<int>("JobID");
			}
		}

		/// <summary>
		/// Wrapper for Role member of fleetmember type.
		/// </summary>
		public string Role
		{
			get
			{
				return GetMember<string>("Role");
			}
		}

		/// <summary>
		/// Wrapper for RoleID member of fleetmember type.
		/// </summary>
		public int RoleID
		{
			get
			{
				return GetMember<int>("RoleID");
			}
		}

		/// <summary>
		/// Wrapper for Boosting member of fleetmember type.
		/// </summary>
		public int Boosting
		{
			get
			{
				return GetMember<int>("Boosting");
			}
		}

		/// <summary>
		/// Wrapper for SquadID member of fleetmember type.
		/// </summary>
		public Int64 SquadID
		{
			get
			{
				return GetMember<Int64>("SquadID");
			}
		}

		/// <summary>
		/// Wrapper for WingID member of fleetmember type.
		/// </summary>
		public Int64 WingID
		{
			get
			{
				return GetMember<Int64>("WingID");
			}
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
			Tracing.SendCallback("FleetMember.WarpTo", Distance.ToString());
			return ExecuteMethod("WarpTo", Distance.ToString());
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
			Tracing.SendCallback("FleetMember.WarpFleetTo", Distance.ToString());
			return ExecuteMethod("WarpFleetTo", Distance.ToString());
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
			return ExecuteMethod("Move", WingID.ToString(), SquadID.ToString());
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
			return ExecuteMethod("MoveToSquadCommander", WingID.ToString(), SquadID.ToString());
		}

		/// <summary>
		/// Wrapper for MoveToWingCommander method of fleetmember type.
		/// </summary>
		/// <param name="WingID"></param>
		/// <returns></returns>
		public bool MoveToWingCommander(Int64 WingID)
		{
			Tracing.SendCallback("FleetMember.MoveToWingCommander", WingID.ToString());
			return ExecuteMethod("MoveToWingCommander", WingID.ToString());
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
