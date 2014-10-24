using System;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// This is the Local TLO -- it is named LocalPilots to avoid reserved word conflict.
	/// </summary>
	public class Pilot : Being
	{
		#region Constructors
		/// <summary>
		/// LocalPilots copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Pilot(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Get a Local pilot by ID.
		/// </summary>
		public Pilot(Int64 CharID)
			: base(LavishScript.Objects.GetObject("Local", CharID.ToString()))
		{
		}

		/// <summary>
		/// Get a Local pilot by name.
		/// </summary>
		public Pilot(string CharName)
			: base(LavishScript.Objects.GetObject("Local", CharName))
		{
		}
		#endregion

		#region Members

		private Int64? _id;
		public Int64 ID
		{
			get
			{
				if (_id == null)
					_id = this.GetInt64("ID");
				return _id.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of a localpilots type.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetString("Name")); }
		}

		private Int64? _charId;
		/// <summary>
		/// Wrapper for the CharID member of a localpilots type.
		/// </summary>
		public Int64 CharID
		{
			get
			{
				if (_charId == null)
					_charId = this.GetInt64("CharID");
				return _charId.Value;
			}
		}

		private string _type;
		/// <summary>
		/// Wrapper for the Type member of a localpilots type.
		/// </summary>
		public string Type
		{
			get { return _type ?? (_type = this.GetString("Type")); }
		}

		private int? _typeId;
		/// <summary>
		/// This is, for the most part, your 'race' subtype)
		/// </summary>
		public int TypeID
		{
			get
			{
				if (_typeId == null)
					_typeId = this.GetInt("TypeID");
				return _typeId.Value;
			}
		}

		private Corporation _corp;
	    public Corporation Corp
	    {
	        get
	        {
	            return _corp ?? (_corp = new Corporation(GetMember("Corp")));
	        }
	    }

		private string _alliance;
		/// <summary>
		/// Wrapper for the Alliance member of a localpilots type.
		/// </summary>
		public string Alliance
		{
			get { return _alliance ?? (_alliance = this.GetString("Alliance")); }
		}

		private int? _allianceId;
		/// <summary>
		/// Wrapper for the AllianceID member of a localpilots type.
		/// </summary>
		public int AllianceID
		{
			get
			{
				if (_allianceId == null)
					_allianceId = this.GetInt("AllianceID");
				return _allianceId.Value;
			}
		}

		private string _allianceTicker;
		/// <summary>
		/// Wrapper for the AllianceTicker member of a localpilots type.
		/// </summary>
		public string AllianceTicker
		{
			get { return _allianceTicker ?? (_allianceTicker = this.GetString("AllianceTicker")); }
		}

		private Entity _toEntity;
		/// <summary>
		/// If they're within range of your overhead.
		/// </summary>
		public Entity ToEntity
		{
			get { return _toEntity ?? (_toEntity = new Entity(GetMember("ToEntity"))); }
		}

		private FleetMember _toFleetMemeber;
		/// <summary>
		/// Returns invalid if this pilot is not in your fleet.
		/// Use LavishScriptObject.IsNullOrInvalid to check.
		/// </summary>
		public FleetMember ToFleetMember
		{
			get { return _toFleetMemeber ?? (_toFleetMemeber = new FleetMember(GetMember("ToFleetMember"))); }
		}

		private Standing _standing;
		/// <summary>
		/// The pilots standing towards you.
		/// </summary>
		public Standing Standing
		{
			get
			{
				return _standing ?? (_standing = new Standing(GetMember("Standing")));
			}
		}

		/// <summary>
		/// The pilots standing towards any other CharID, CorporationID, or AllianceID
		/// </summary>
		public double StandingTo(int ID)
		{
			return this.GetDouble("StandingTo", ID.ToString());
		}
		#endregion

		#region Methods
		/// <summary>
		/// EXAMPLE: new LocalPilots("Amadeus").SetStanding(5.0,"Amadeus rocks");
		/// </summary>
		public bool SetStanding(int Standing, string Reason)
		{
			Tracing.SendCallback("Pilot.SetStanding", Standing, Reason);
			return ExecuteMethod("SetStanding", Standing.ToString(), Reason);
		}

		/// <summary>
		/// Invite a localpilot to your fleet.
		/// </summary>
		/// <returns></returns>
		public bool InviteToFleet()
		{
			Tracing.SendCallback("Pilot.InviteToFleet");
			return ExecuteMethod("InviteToFleet");
		}
		#endregion
	}
}
