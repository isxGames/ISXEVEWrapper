using System;
using System.Collections.Generic;
using System.Text;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the fleet data type.
	/// </summary>
	public class Fleet : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Fleet object copy constructor.
		/// </summary>
		/// <param name="objectToCopy"></param>
		public Fleet(LavishScriptObject objectToCopy)
			: base(objectToCopy)
		{

		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ID member of the fleet type.
		/// </summary>
		public Int64 ID
		{
			get
			{
				Tracing.SendCallback("Fleet.ID");
				LavishScriptObject id = GetMember("ID");
				if (!LavishScriptObject.IsNullOrInvalid(id))
				{
					return id.GetValue<Int64>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the InvitationText member of the fleet type.
		/// </summary>
		public string InvitationText
		{
			get
			{
				return GetMember<string>("InvitationText");
			}
		}

		/// <summary>
		/// Wrapper for the Invited member of the fleet type.
		/// </summary>
		public bool Invited
		{
			get
			{
				LavishScriptObject invited = GetMember("Invited");
				if (!LavishScriptObject.IsNullOrInvalid(invited))
				{
					return invited.GetValue<bool>();
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// Wrapper for the IsFleetCommander member of the fleet type.
		/// </summary>
		public bool IsFleetCommander
		{
			get
			{
				LavishScriptObject isFleetCommander = GetMember("IsFleetCommander");
				if (!LavishScriptObject.IsNullOrInvalid(isFleetCommander))
				{
					return isFleetCommander.GetValue<bool>();
				}
				else
				{
					return false;
				}
			}
		}

		/// <summary>
		/// Wrapper for the GetMember member of the fleet type.
		/// </summary>
		/// <param name="charID"></param>
		/// <returns></returns>
		public FleetMember GetMember(Int64 charID)
		{
			return GetMember<FleetMember>("Member", charID.ToString());
		}

		/// <summary>
		/// Wrapper for the Size member of the fleet type.
		/// </summary>
		public int Size
		{
			get
			{
				LavishScriptObject size = GetMember("Size");
				if (!LavishScriptObject.IsNullOrInvalid(size))
				{
					return size.GetValue<int>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the IsMember member of the fleet type.
		/// </summary>
		/// <param name="charID"></param>
		/// <returns></returns>
		public bool IsMember(Int64 charID)
		{
			LavishScriptObject isMember = GetMember("IsMember", charID.ToString());
			if (!LavishScriptObject.IsNullOrInvalid(isMember))
			{
				return isMember.GetValue<bool>();
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Wrapper for the WingName member of the fleet type.
		/// </summary>
		/// <param name="wingID"></param>
		/// <returns></returns>
		public string WingName(Int64 wingID)
		{
			return GetMember<string>("WingName", wingID.ToString());
		}

		/// <summary>
		/// Wrapper for the WingNameToID member of the fleet type.
		/// </summary>
		/// <param name="wingName"></param>
		/// <returns></returns>
		public Int64 WingNameToID(string wingName)
		{
			LavishScriptObject wingID = GetMember("WingNameToID", wingName);
			if (!LavishScriptObject.IsNullOrInvalid(wingID))
			{
				return wingID.GetValue<Int64>();
			}
			else
			{
				return -1;
			}
		}

		/// <summary>
		/// Wrapper for the SquadName member of the fleet type.
		/// </summary>
		/// <param name="squadID"></param>
		/// <returns></returns>
		public string SquadName(Int64 squadID)
		{
			return GetMember<string>("SquadName", squadID.ToString());
		}

		/// <summary>
		/// Wrapper for the SquadNameToID member of the fleet type.
		/// </summary>
		/// <param name="squadName"></param>
		/// <returns></returns>
		public Int64 SquadNameToID(string squadName)
		{
			LavishScriptObject squadID = GetMember("SquadNameToID", squadName);
			if (!LavishScriptObject.IsNullOrInvalid(squadID))
			{
				return squadID.GetValue<Int64>();
			}
			else
			{
				return -1;
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the AcceptInvite method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool AcceptInvite()
		{
			Tracing.SendCallback("Fleet.AcceptInvite");
			return ExecuteMethod("AcceptInvite");
		}

		/// <summary>
		/// Wrapper for the Broadcast_AlignTo method of the fleet type.
		/// </summary>
		/// <param name="entityID"></param>
		/// <returns></returns>
		public bool Broadcast_AlignTo(int entityID)
		{
			Tracing.SendCallback("Fleet.Broadcast_AlignTo", entityID);
			return ExecuteMethod("Broadcast_AlignTo", entityID.ToString());
		}

		/// <summary>
		/// Wrapper for the Broadcast_EnemySpotted method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_EnemySpotted()
		{
			Tracing.SendCallback("Fleet.Broadcast_EnemySpotted");
			return ExecuteMethod("Broadcast_EnemySpotted");
		}

		/// <summary>
		/// Wrapper for the Broadcast_HealArmor method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_HealArmor()
		{
			Tracing.SendCallback("Fleet.Broadcast_HealArmor");
			return ExecuteMethod("Broadcast_HealArmor");
		}

		/// <summary>
		/// Wrapper for the Broadcast_HealCapacitor method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_HealCapacitor()
		{
			Tracing.SendCallback("Fleet.Broadcast_HealCapacitor");
			return ExecuteMethod("Broadcast_HealCapacitor");
		}

		/// <summary>
		/// Wrapper for the Broadcast_HealShield method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_HealShield()
		{
			Tracing.SendCallback("Fleet.Broadcast_HealShield");
			return ExecuteMethod("Broadcast_HealShield");
		}

		/// <summary>
		/// Wrapper for the Broadcast_HoldPosition method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_HoldPosition()
		{
			Tracing.SendCallback("Fleet.Broadcast_HoldPosition");
			return ExecuteMethod("Broadcast_HoldPosition");
		}

		/// <summary>
		/// Wrapper for the Broadcast_InPosition method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_InPosition()
		{
			Tracing.SendCallback("Fleet.Broadcast_InPosition");
			return ExecuteMethod("Broadcast_InPosition");
		}

		/// <summary>
		/// Wrapper for the Broadcast_JumpBeacon method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_JumpBeacon()
		{
			Tracing.SendCallback("Fleet.Broadcast_JumpBeacon");
			return ExecuteMethod("Broadcast_JumpBeacon");
		}

		/// <summary>
		/// Wrapper for the Broadcast_JumpTo method of the fleet type.
		/// </summary>
		/// <param name="solarSystemID"></param>
		/// <returns></returns>
		public bool Broadcast_JumpTo(int solarSystemID)
		{
			Tracing.SendCallback("Fleet.Broadcast_JumpTo");
			return ExecuteMethod("Broadcast_JumpTo", solarSystemID.ToString());
		}

		/// <summary>
		/// Wrapper for the Broadcast_Location method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_Location()
		{
			Tracing.SendCallback("Fleet.Broadcast_Location");
			return ExecuteMethod("Broadcast_Location");
		}

		/// <summary>
		/// Wrapper for the Broadcast_NeedBackup method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool Broadcast_NeedBackup()
		{
			Tracing.SendCallback("Fleet.Broadcast_NeedBackup");
			return ExecuteMethod("Broadcast_NeedBackup");
		}

		/// <summary>
		/// Wrapper for the Broadcast_Target method of the fleet type.
		/// </summary>
		/// <param name="entityID"></param>
		/// <returns></returns>
		public bool Broadcast_Target(int entityID)
		{
			Tracing.SendCallback("Fleet.Broadcast_Target", entityID);
			return ExecuteMethod("Broadcast_Target", entityID.ToString());
		}

		/// <summary>
		/// Wrapper for the Broadcast_TravelTo method of the fleet type.
		/// </summary>
		/// <param name="solarSystemID"></param>
		/// <returns></returns>
		public bool Broadcast_TravelTo(int solarSystemID)
		{
			Tracing.SendCallback("Fleet.Broadcast_TravelTo", solarSystemID);
			return ExecuteMethod("Broadcast_TravelTo", solarSystemID.ToString());
		}

		/// <summary>
		/// Wrapper for the Broadcast_WarpTo method of the fleet type.
		/// </summary>
		/// <param name="entityID"></param>
		/// <returns></returns>
		public bool Broadcast_WarpTo(int entityID)
		{
			Tracing.SendCallback("Fleet.Broadcast_WarpTo", entityID);
			return ExecuteMethod("Broadcast_WarpTo", entityID.ToString());
		}

		/// <summary>
		/// Wrapper for the ChangeSquadName method of the fleet type.
		/// </summary>
		/// <param name="squadID"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool ChangeSquadName(Int64 squadID, string name)
		{
			Tracing.SendCallback("Fleet.ChangeSquadName", squadID, name);
			return ExecuteMethod("ChangeSquadName", squadID.ToString(), name);
		}

		/// <summary>
		/// Wrapper for the ChangeWingName method of the fleet type.
		/// </summary>
		/// <param name="wingID"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool ChangeWingName(Int64 wingID, string name)
		{
			Tracing.SendCallback("Fleet.ChangeWingName", wingID, name);
			return ExecuteMethod("ChangeWingName", wingID.ToString(), name);
		}

		/// <summary>
		/// Wrapper for the CreateSquad method of the fleet type.
		/// </summary>
		/// <param name="wingID"></param>
		/// <returns></returns>
		public bool CreateSquad(Int64 wingID)
		{
			Tracing.SendCallback("Fleet.CreateSquad", wingID);
			return ExecuteMethod("CreateSquad", wingID.ToString());
		}

		/// <summary>
		/// Wrapper for the CreateWing method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool CreateWing()
		{
			Tracing.SendCallback("Fleet.CreateWing");
			return ExecuteMethod("CreateWing");
		}

		/// <summary>
		/// Wrapper for the DeleteSquad method of the fleet type.
		/// </summary>
		/// <param name="squadID"></param>
		/// <returns></returns>
		public bool DeleteSquad(Int64 squadID)
		{
			Tracing.SendCallback("Fleet.DeleteSquad");
			return ExecuteMethod("DeleteSquad", squadID.ToString());
		}

		/// <summary>
		/// Wrapper for the DeleteWing method of the fleet type.
		/// </summary>
		/// <param name="wingID"></param>
		/// <returns></returns>
		public bool DeleteWing(Int64 wingID)
		{
			Tracing.SendCallback("Fleet.DeleteWing");
			return ExecuteMethod("DeleteWing", wingID.ToString());
		}

		/// <summary>
		/// Wrapper for the GetMembers method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public List<FleetMember> GetMembers()
		{
			Tracing.SendCallback("Fleet.GetMembers", string.Empty);
			return Util.GetListFromMethod<FleetMember>(this, "GetMembers", "fleetmember");
		}

		/// <summary>
		/// Wrapper for the GetSquads method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public List<Int64> GetSquads()
		{
			Tracing.SendCallback("Fleet.GetSquads", string.Empty);
			return Util.GetListFromMethod<Int64>(this, "GetSquads", "int64");
		}

		/// <summary>
		/// Wrapper for the GetSquads method of the fleet type.
		/// </summary>
		/// <param name="wingID"></param>
		/// <returns></returns>
		public List<Int64> GetSquads(Int64 wingID)
		{
			Tracing.SendCallback("Fleet.GetSquads", wingID.ToString());
			return Util.GetListFromMethod<Int64>(this, "GetSquads", "int64", wingID.ToString());
		}

		/// <summary>
		/// Wrapper for the GetWings method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public List<Int64> GetWings()
		{
			Tracing.SendCallback("Fleet.GetWings", string.Empty);
			return Util.GetListFromMethod<Int64>(this, "GetWings", "int64");
		}

		/// <summary>
		/// Wrapper for the LeaveFleet method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool LeaveFleet()
		{
			Tracing.SendCallback("Fleet.LeaveFleet", string.Empty);
			return ExecuteMethod("LeaveFleet");
		}

		/// <summary>
		/// Wrapper for the RejectInvite method of the fleet type.
		/// </summary>
		/// <returns></returns>
		public bool RejectInvite()
		{
			Tracing.SendCallback("Fleet.RejectInvite", string.Empty);
			return ExecuteMethod("RejectInvite");
		}

		/// <summary>
		/// Wrapper for the WarpToFleetMember method of the fleet type.
		/// </summary>
		/// <param name="fleetMemberCharID"></param>
		/// <returns></returns>
		public bool WarpToFleetMember(Int64 fleetMemberCharID)
		{
			Tracing.SendCallback("Fleet.WarpToFleetMember", fleetMemberCharID.ToString());
			return WarpToFleetMember(fleetMemberCharID, 0);
		}

		/// <summary>
		/// Wrapper for the WarpToFleetMember method of the fleet type.
		/// </summary>
		/// <param name="fleetMemberCharID"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		public bool WarpToFleetMember(Int64 fleetMemberCharID, double distance)
		{
			Tracing.SendCallback("Fleet.WarpToFleetMember", fleetMemberCharID, distance);
			return ExecuteMethod("WarpToFleetMember", fleetMemberCharID.ToString(), distance.ToString());
		}
		#endregion
	}
}
