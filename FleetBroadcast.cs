using System;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the fleetbroadcast data type.
	/// </summary>
	public class FleetBroadcast : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// FleetBroadcast copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public FleetBroadcast(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// The broadcast kind (e.g. NeedBackup, WarpTo, Target, HealArmor, InPosition).
		/// </summary>
		public string Type
		{
			get { return this.GetString("Type"); }
		}

		/// <summary>
		/// The broadcast scope: Down, Up, or All.
		/// </summary>
		public string Scope
		{
			get { return this.GetString("Scope"); }
		}

		/// <summary>
		/// How far the broadcast was heard: Universe, System, or Bubble.
		/// </summary>
		public string Where
		{
			get { return this.GetString("Where"); }
		}

		/// <summary>
		/// Wrapper for the SenderID member of the fleetbroadcast type.
		/// </summary>
		public Int64 SenderID
		{
			get { return this.GetInt64("SenderID"); }
		}

		/// <summary>
		/// Wrapper for the SenderCharID member of the fleetbroadcast type.
		/// </summary>
		public Int64 SenderCharID
		{
			get { return this.GetInt64("SenderCharID"); }
		}

		/// <summary>
		/// The fleet member who sent the broadcast.
		/// </summary>
		public FleetMember ToFleetMember
		{
			get
			{
				var member = GetMember("ToFleetMember");
				return IsNullOrInvalid(member) ? null : new FleetMember(member);
			}
		}

		/// <summary>
		/// Entity id for a Target broadcast; location id for WarpTo/AlignTo/JumpTo/TravelTo/InPosition.
		/// </summary>
		public Int64 TargetID
		{
			get { return this.GetInt64("TargetID"); }
		}

		/// <summary>
		/// Wrapper for the ItemID member of the fleetbroadcast type.
		/// </summary>
		public Int64 ItemID
		{
			get { return this.GetInt64("ItemID"); }
		}

		/// <summary>
		/// Wrapper for the SolarSystemID member of the fleetbroadcast type.
		/// </summary>
		public Int64 SolarSystemID
		{
			get { return this.GetInt64("SolarSystemID"); }
		}

		/// <summary>
		/// Only set for a JumpBeacon broadcast; NULL otherwise.
		/// </summary>
		public int TypeID
		{
			get { return this.GetInt("TypeID"); }
		}

		/// <summary>
		/// The time at which the broadcast was received.
		/// </summary>
		public EVETime Timestamp
		{
			get
			{
				var timestamp = GetMember("Timestamp");
				return IsNullOrInvalid(timestamp) ? null : new EVETime(timestamp);
			}
		}

		/// <summary>
		/// Wrapper for the Label member of the fleetbroadcast type.
		/// </summary>
		public string Label
		{
			get { return this.GetString("Label"); }
		}
		#endregion
	}
}
