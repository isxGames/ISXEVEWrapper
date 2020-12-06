using System;
using System.Collections.Generic;
using System.Globalization;

using EVE.ISXEVE;
using EVE.ISXEVE.Extensions;
using EVE.ISXEVE.Interfaces;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the entity data type.
	/// </summary>
	public class Entity : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Copy constructor for the Entity object.
		/// </summary>
		/// <param name="Obj"></param>
		public Entity(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Search for an Entity using LS Query syntax.
		/// </summary>
		/// <param queryString="queryString"></param>
		public Entity(string queryString)
			: base(LavishScript.Objects.GetObject("Entity", queryString))
		{
		}

		/// <summary>
		/// Search for an Entity matching the given ID.
		/// </summary>
		/// <param name="entityID"></param>
		public Entity(long entityID)
			: base(LavishScript.Objects.GetObject("Entity", entityID.ToString(CultureInfo.CurrentCulture)))
		{
		}
		#endregion

		#region Static Members
		public static List<Entity> All
		{
			get
			{
				return new EVE().QueryEntities();
			}
		}
		#endregion

		#region LavishScript Members

		private string _alliance;
		/// <summary>
		/// Wrapper for the Alliance member of the entity type.
		/// </summary>
		public string Alliance
		{
			get { return _alliance ?? (_alliance = this.GetString("Alliance")); }
		}

		private int? _allianceId;
		/// <summary>
		/// Wrapper for the AllianceID member of the entity type.
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
		/// Wrapper for the AllianceTicker member of the entity type.
		/// </summary>
		public string AllianceTicker
		{
			get { return _allianceTicker ?? (_allianceTicker = this.GetString("AllianceTicker")); }
		}

		private double? _bounty;
		/// <summary>
		/// Wrapper for the Bounty member of the Entity datatype.
		/// </summary>
		public double Bounty
		{
			get
			{
				if (_bounty == null)
					_bounty = this.GetDouble("Bounty");
				return _bounty.Value;
			}
		}

		private string _category;
		/// <summary>
		/// Wrapper for the Category member of the entity type.
		/// </summary>
		public string Category
		{
			get { return _category ?? (_category = this.GetString("Category")); }
		}

		private int? _categoryId;
		/// <summary>
		/// Wrapper for the CategoryID member of the entity type.
		/// </summary>
		public int CategoryID
		{
			get
			{
				if (_categoryId == null)
					_categoryId = this.GetInt("CategoryID");
				return _categoryId.Value;
			}
		}

		/// <summary>
		/// Wrapper for the CategoryType member of the entity type.
		/// </summary>
		public CategoryType CategoryType
		{
			get
			{
				return (CategoryType)CategoryID;
			}
		}

		private Int64? _charId;
		/// <summary>
		/// Wrapper for the CharID member of the entity type.
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

		private Corporation _corp;
		/// <summary>
		/// Wrapper for the Corporation member of the entity type.
		/// </summary>
		public Corporation Corp
		{
			get
			{
				return _corp ?? (_corp = new Corporation(GetMember("Corporation")));
			}
		}

		private int? _formationId;
		/// <summary>
		/// Wrapper for the FormationID member of the entity type.
		/// </summary>
		public int FormationID
		{
			get
			{
				if (_formationId == null)
					_formationId = this.GetInt("FormationID");
				return _formationId.Value;
			}
		}

		private string _group;
		/// <summary>
		/// Wrapper for the Group member of the entity type.
		/// </summary>
		public string Group
		{
			get { return _group ?? (_group = this.GetString("Group")); }
		}

		private int? _groupId;
		/// <summary>
		/// Wrapper for the GroupID member of the entity type.
		/// </summary>
		public int GroupID
		{
			get
			{
				if (_groupId == null)
					_groupId = this.GetInt("GroupID");
				return _groupId.Value;
			}
		}

		private Int64? _id;
		/// <summary>
		/// Wrapper for the ID member of the entity type.
		/// </summary>
		public Int64 ID
		{
			get
			{
				Tracing.SendCallback("Entity.ID");
				if (_id == null)
					_id = this.GetInt64("ID");
				return _id.Value;
			}
		}

		private bool? _isWreckViewed;
		public bool IsWreckViewed
		{
			get
			{
				if (_isWreckViewed == null)
					_isWreckViewed = this.GetBool("IsWreckViewed");
				return _isWreckViewed.Value;
			}
		}

		private bool? _isAbandoned;
		public bool IsAbandoned
		{
			get
			{
				if (_isAbandoned == null)
					_isAbandoned = this.GetBool("IsAbandoned");
				return _isAbandoned.Value;
			}
		}

		private double? _maxVelocity;
		/// <summary>
		/// Wrapper for the MaxVelocity member of the entity type.
		/// </summary>
		public double MaxVelocity
		{
			get
			{
				if (_maxVelocity == null)
					_maxVelocity = this.GetDouble("MaxVelocity");
				return _maxVelocity.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of the entity type.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetString("Name")); }
		}

		private Pilot _owner;
		/// <summary>
		/// Only valid if the owner is on the locals list.  Use OwnerID otherwise.
		/// </summary>
		public Pilot Owner
		{
			get { return _owner ?? (_owner = new Pilot(GetMember("Owner"))); }
		}

		private Int64? _ownerId;
		/// <summary>
		/// Wrapper for the OwnerID member of the entity type.
		/// </summary>
		public Int64 OwnerID
		{
			get
			{
				if (_ownerId == null)
					_ownerId = this.GetInt64("OwnerID");
				return _ownerId.Value;
			}
		}

		private double? _security;
		/// <summary>
		/// Wrapper for the Security member of the entity type.
		/// </summary>
		public double Security
		{
			get
			{
				if (_security == null)
					_security = this.GetDouble("Security");
				return _security.Value;
			}
		}

		private string _type;
		/// <summary>
		/// Wrapper for the Type member of the entity type.
		/// </summary>
		public string Type
		{
			get { return _type ?? (_type = this.GetString("Type")); }
		}

		private int? _typeId;
		/// <summary>
		/// Wrapper for the TypeID member of the entity type.
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

		private int? _wreckId;
		/// <summary>
		/// Wrapper for the WreckID member of the entity type.
		/// </summary>
		public int WreckID
		{
			get
			{
				if (_wreckId == null)
					_wreckId = this.GetInt("WreckID");
				return _wreckId.Value;
			}
		}

		private ActiveDrone _toActiveDrone;
		/// <summary>
		/// Wrapper for the ToActiveDrone member of the entity type.
		/// </summary>
		public ActiveDrone ToActiveDrone
		{
			get { return _toActiveDrone ?? (_toActiveDrone = new ActiveDrone(GetMember("ToActiveDrone"))); }
		}

		private List<ActiveDrone> _activeDrones;
		/// <summary>
		/// Wrapper for the GetActiveDrones member of the entity type.
		/// </summary>
		/// <returns></returns>
		public List<ActiveDrone> GetActiveDrones()
		{
			Tracing.SendCallback("Entity.GetActiveDrones");
			return _activeDrones ?? (_activeDrones = Util.GetListFromMethod<ActiveDrone>(this, "GetActiveDrones", "activedrone"));
		}

		private bool? _isWreckEmpty;
		/// <summary>
		/// Wrapper for the IsWreckEmpty member of the entity type.
		/// </summary>
		public bool IsWreckEmpty
		{
			get
			{
				if (_isWreckEmpty == null)
					_isWreckEmpty = this.GetBool("IsWreckEmpty");
				return _isWreckEmpty.Value;
			}
		}

		private bool? _isOwnedByCorpMember;
		/// <summary>
		/// Wrapper for the IsOwnedByCorpMember member of the entity type.
		/// </summary>
		public bool IsOwnedByCorpMember
		{
			get
			{
				if (_isOwnedByCorpMember == null)
					_isOwnedByCorpMember = this.GetBool("IsOwnedByCorpMember");
				return _isOwnedByCorpMember.Value;
			}
		}

		private bool? _isOwnedByAllianceMember;
		/// <summary>
		/// Wrapper for the IsOwnedByAllianceMember member of the entity type.
		/// </summary>
		public bool IsOwnedByAllianceMember
		{
			get
			{
				if (_isOwnedByAllianceMember == null)
					_isOwnedByAllianceMember = this.GetBool("IsOwnedByAllianceMember");
				return _isOwnedByAllianceMember.Value;
			}
		}

		#region Location

		private double? _x;
		/// <summary>
		/// Wrapper for the X member of the entity type.
		/// </summary>
		public double X
		{
			get
			{
				if (_x == null)
					_x = this.GetDouble("X");
				return _x.Value;
			}
		}

		private double? _y;
		/// <summary>
		/// Wrapper for the Y member of the entity type.
		/// </summary>
		public double Y
		{
			get
			{
				if (_y == null)
					_y = this.GetDouble("Y");
				return _y.Value;
			}
		}

		private double? _z;
		/// <summary>
		/// Wrapper for the Z member of the entity type.
		/// </summary>
		public double Z
		{
			get
			{
				if (_z == null)
					_z = this.GetDouble("Z");
				return _z.Value;
			}
		}

		private double? _vx;
		/// <summary>
		/// Wrapper for the vX member of the entity type.
		/// </summary>
#pragma warning disable IDE1006 // Naming Styles
		public double vX
#pragma warning restore IDE1006 // Naming Styles
		{
			get
			{
				if (_vx == null)
					_vx = this.GetDouble("vX");
				return _vx.Value;
			}
		}

		private double? _vy;
		/// <summary>
		/// Wrapper for the vY member of the entity type.
		/// </summary>
#pragma warning disable IDE1006 // Naming Styles
		public double vY
#pragma warning restore IDE1006 // Naming Styles
		{
			get
			{
				if (_vy == null)
					_vy = this.GetDouble("vY");
				return _vy.Value;
			}
		}

		private double? _vz;
		/// <summary>
		/// Wrapper for the vZ member of the entity type.
		/// </summary>
#pragma warning disable IDE1006 // Naming Styles
		public double vZ
#pragma warning restore IDE1006 // Naming Styles
		{
			get
			{
				if (_vz == null)
					_vz = this.GetDouble("vZ");
				return _vz.Value;
			}
		}

		private double? _pitch;
		/// <summary>
		/// Wrapper for the Pitch member of the entity type.
		/// </summary>
		public double Pitch
		{
			get
			{
				if (_pitch == null)
					_pitch = this.GetDouble("Pitch");
				return _pitch.Value;
			}
		}


		private double? _roll;
		/// <summary>
		/// Wrapper for the Roll member of the entity type.
		/// </summary>
		public double Roll
		{
			get
			{
				if (_roll == null)
					_roll = this.GetDouble("Roll");
				return _roll.Value;
			}
		}

		private double? _yaw;
		/// <summary>
		/// Wrapper for the Yaw member of the entity type.
		/// </summary>
		public double Yaw
		{
			get
			{
				if (_yaw == null)
					_yaw = this.GetDouble("Yaw");
				return _yaw.Value;
			}
		}

		private double? _velocity;
		/// <summary>
		/// Wrapper for the Velocity member of the entity type.
		/// </summary>
		public double Velocity
		{
			get
			{
				if (_velocity == null)
					_velocity = this.GetDouble("Velocity");
				return _velocity.Value;
			}
		}

		private double? _distance;
		/// <summary>
		/// Wrapper for the Distance member of the entity type.
		/// </summary>
		public double Distance
		{
			get
			{
				if (_distance == null)
					_distance = this.GetDouble("Distance");
				return _distance.Value;
			}
		}

		/// <summary>
		/// Wrapper for the DistanceTo member of the entity type.
		/// </summary>
		/// <param name="entityId"></param>
		/// <returns></returns>
		public double DistanceTo(long entityId)
		{
			return this.GetDouble("DistanceTo", entityId.ToString(CultureInfo.CurrentCulture));
		}

		private double? _followRange;
		/// <summary>
		/// Wrapper for the FollowRange member of the entity type.
		/// </summary>
		public double FollowRange
		{
			get
			{
				if (_followRange == null)
					_followRange = this.GetDouble("FollowRange");
				return _followRange.Value;
			}
		}
		#endregion

		#region Physical

		private double? _mass;
		/// <summary>
		/// Wrapper for the Mass member of the entity type.
		/// </summary>
		public double Mass
		{
			get
			{
				if (_mass == null)
					_mass = this.GetDouble("Mass");
				return _mass.Value;
			}
		}

		private double? _radius;
		/// <summary>
		/// Wrapper for the Radius member of the entity type.
		/// </summary>
		public double Radius
		{
			get
			{
				if (_radius == null)
					_radius = this.GetDouble("Radius");
				return _radius.Value;
			}
		}

		private double? _shieldPct;
		/// <summary>
		/// Wrapper for the ShieldPct member of the entity type.
		/// </summary>
		public double ShieldPct
		{
			get
			{
				if (_shieldPct == null)
					_shieldPct = this.GetDouble("ShieldPct");
				return _shieldPct.Value;
			}
		}

		private double? _armorPct;
		/// <summary>
		/// Wrapper for the ArmorPct member of the entity type.
		/// </summary>
		public double ArmorPct
		{
			get
			{
				if (_armorPct == null)
					_armorPct = this.GetDouble("ArmorPct");
				return _armorPct.Value;
			}
		}

		private double? _structurePct;
		/// <summary>
		/// Wrapper for the StructurePct member of the entity type.
		/// </summary>
		public double StructurePct
		{
			get
			{
				if (_structurePct == null)
					_structurePct = this.GetDouble("StructurePct");
				return _structurePct.Value;
			}
		}
		#endregion

		#region Logical

		private bool? _isCloaked;
		/// <summary>
		/// Wrapper for the IsCloaked member of the entity type.
		/// </summary>
		public bool IsCloaked
		{
			get
			{
				if (_isCloaked == null)
					_isCloaked = this.GetBool("IsCloaked");
				return _isCloaked.Value;
			}
		}

		private bool? _isInteractive;
		/// <summary>
		/// Wrapper for the IsInteractive member of the entity type.
		/// </summary>
		public bool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
					_isInteractive = this.GetBool("IsInteractive");
				return _isInteractive.Value;
			}
		}

		private bool? _isMassive;
		/// <summary>
		/// Wrapper for the IsMassive member of the entity type.
		/// </summary>
		public bool IsMassive
		{
			get
			{
				if (_isMassive == null)
					_isMassive = this.GetBool("IsMassive");
				return _isMassive.Value;
			}
		}

		private bool? _isGlobal;
		/// <summary>
		/// Wrapper for the IsGlobal member of the entity type.
		/// </summary>
		public bool IsGlobal
		{
			get
			{
				if (_isGlobal == null)
					_isGlobal = this.GetBool("IsGlobal");
				return _isGlobal.Value;
			}
		}

		private bool? _isMoribund;
		/// <summary>
		/// Wrapper for the IsMoribund member of the entity type.
		/// </summary>
		public bool IsMoribund
		{
			get
			{
				if (_isMoribund == null)
					_isMoribund = this.GetBool("IsMoribund");
				return _isMoribund.Value;
			}
		}

		private bool? _isWarpScrambled;
		/// <summary>
		/// Wrapper for the IsWarpScrambled member of the entity type.
		/// </summary>
		public bool IsWarpScrambled
		{
			get
			{
				if (_isWarpScrambled == null)
					_isWarpScrambled = this.GetBool("IsWarpScrambled");
				return _isWarpScrambled.Value;
			}
		}

		private bool? _isActiveTarget;
		/// <summary>
		/// Wrapper for the IsActiveTarget member of the entity type.
		/// </summary>
		public bool IsActiveTarget
		{
			get
			{
				if (_isActiveTarget == null)
					_isActiveTarget = this.GetBool("IsActiveTarget");
				return _isActiveTarget.Value;
			}
		}

		private bool? _isLockedTarget;
		/// <summary>
		/// Wrapper for the IsLockedTarget member of the entity type.
		/// </summary>
		public bool IsLockedTarget
		{
			get
			{
				if (_isLockedTarget == null)
					_isLockedTarget = this.GetBool("IsLockedTarget");
				return _isLockedTarget.Value;
			}
		}

		private bool? _isNpc;
		/// <summary>
		/// Wrapper for the IsNPC member of the entity type.
		/// </summary>
		public bool IsNPC
		{
			get
			{
				if (_isNpc == null)
					_isNpc = this.GetBool("IsNPC");
				return _isNpc.Value;
			}
		}

		private bool? _isPc;
		/// <summary>
		/// Wrapper for the IsPC member of the entity type.
		/// </summary>
		public bool IsPC
		{
			get
			{
				if (_isPc == null)
					_isPc = this.GetBool("IsPC");
				return _isPc.Value;
			}
		}

		private bool? _haveLootRights;
		/// <summary>
		/// Wrapper for the HaveLootRights member of the entity type.
		/// </summary>
		public bool HaveLootRights
		{
			get
			{
				if (_haveLootRights == null)
					_haveLootRights = this.GetBool("HaveLootRights");
				return _haveLootRights.Value;
			}
		}

		public int? _mode;
		/// <summary>
		/// Known Modes
		/// 2 - Stopped 
		/// 3 - Warping (in warp) 
		/// </summary>
		public int Mode
		{
			get
			{
				if (_mode == null)
					_mode = this.GetInt("Mode");
				return _mode.Value;
			}
		}

		private bool? _isTargetingMe;
		/// <summary>
		/// Wrapper for the IsTargetingMe member of the entity type.
		/// </summary>
		public bool IsTargetingMe
		{
			get
			{
				if (_isTargetingMe == null)
					_isTargetingMe = this.GetBool("IsTargetingMe");
				return _isTargetingMe.Value;
			}
		}

		private bool? _isWarpScramblingMe;
		/// <summary>
		/// Wrapper for the IsWarpScramblingMe member of the entity type.
		/// </summary>
		public bool IsWarpScramblingMe
		{
			get
			{
				if (_isWarpScramblingMe == null)
					_isWarpScramblingMe = this.GetBool("IsWarpScramblingMe");
				return _isWarpScramblingMe.Value;
			}
		}

		private bool? _isTargetJammingMe;
		/// <summary>
		/// Wrapper for the IsTargetJammingMe member of the entity type.
		/// </summary>
		public bool IsTargetJammingMe
		{
			get
			{
				if (_isTargetJammingMe == null)
					_isTargetJammingMe = this.GetBool("IsTargetJammingMe");
				return _isTargetJammingMe.Value;
			}
		}

		private bool? _beingTargeted;
		/// <summary>
		/// Wrapper for the BeingTargeted member of the entity type.
		/// </summary>
		public bool BeingTargeted
		{
			get
			{
				if (_beingTargeted == null)
					_beingTargeted = this.GetBool("BeingTargeted");
				return _beingTargeted.Value;
			}
		}

		private Entity _approaching;
		/// <summary>
		/// Wrapper for the Approaching member of the entity type.
		/// </summary>
		public Entity Approaching
		{
			get
			{
				return _approaching ?? (_approaching = new Entity(GetMember("Approaching")));
			}
		}

		private Entity _following;
		/// <summary>
		/// Wrapper for the Following member of the entity type.
		/// </summary>
		public Entity Following
		{
			get
			{
				return _following ?? (_following = new Entity(GetMember("Following")));
			}
		}
		#endregion

		#region Cargo

		private double? _cargoCapacity;
		/// <summary>
		/// Wrapper for the CargoCapacity member of the entity type.
		/// </summary>
		public double CargoCapacity
		{
			get
			{
				if (_cargoCapacity == null)
					_cargoCapacity = this.GetDouble("CargoCapacity");
				return _cargoCapacity.Value;
			}
		}

		private double? _usedCargoCapacity;
		/// <summary>
		/// Wrapper for the UsedCargoCapacity member of the entity type.
		/// </summary>
		public double UsedCargoCapacity
		{
			get
			{
				if (_usedCargoCapacity == null)
					_usedCargoCapacity = this.GetDouble("UsedCargoCapacity");
				return _usedCargoCapacity.Value;
			}
		}

		private List<IItem> _cargo;
		/// <summary>
		/// List of all cargo items.  Keep in mind this might
		/// be empty or invalid if the cargo hold isn't open
		/// </summary>
		/// <returns></returns>
		public List<IItem> GetCargo()
		{
			Tracing.SendCallback("Entity.GetCargo");
			return _cargo ?? (_cargo = Util.GetListFromMethod<IItem>(this, "GetCargo", "item"));
		}

		private bool? _hasOreHold;
		/// <summary>
		/// Wrapper for the HasOreHold member of the entity type.
		/// </summary>
		public bool HasOreHold
		{
			get
			{
				if (_hasOreHold == null)
					_hasOreHold = this.GetBool("HasOreHold");
				return _hasOreHold.Value;
			}
		}
		#endregion

		private Attacker _attacker;
		/// <summary>
		/// Wrapper for the ToAttacker member of the Entity datatype.
		/// </summary>
		public Attacker ToAttacker
		{
			get
			{
				return _attacker ?? (_attacker = new Attacker(GetMember("ToAttacker")));
			}
		}

		private Jammer _jammer;
		/// <summary>
		/// Get the Jammer member of the Entity object
		/// </summary>
		public Jammer ToJammer
		{
			get
			{
				return _jammer ?? (_jammer = new Jammer(GetMember("ToJammer")));
			}
		}

		private EntityWormhole _entityWormhole;

		public EntityWormhole ToEntityWormhole
		{
			get { return _entityWormhole ?? (_entityWormhole = new EntityWormhole(GetMember("ToWormhole"))); }
		}

		private Int64? _surveyScannerOreQuantity;
		/// <summary>
		/// Wrapper for the SurveyScannerOreQuantity member of the Entity datatype.
		/// </summary>
		public Int64 SurveyScannerOreQuantity
		{
			get
			{
				if (_surveyScannerOreQuantity == null)
					_surveyScannerOreQuantity = this.GetInt64("SurveyScannerOreQuantity");

				return _surveyScannerOreQuantity.Value;
			}
		}

		private bool? _hasShipScannerResults;
		/// <summary>
		/// Wrapper for the HasShipScannerResults member of the Entity datatype.
		/// </summary>
		public bool HasShipScannerResults
		{
			get
			{
				if (_hasShipScannerResults == null)
					_hasShipScannerResults = this.GetBool("HasShipScannerResults");

				return _hasShipScannerResults.Value;
			}
		}

		private List<ItemInfoList> _shipScannerResults;
		/// <summary>
		/// Wrapper for the GetShipScannerResults method of the entity datatype.
		/// </summary>
		/// <returns></returns>
		public List<ItemInfoList> GetShipScannerResults()
		{
			return _shipScannerResults ?? (_shipScannerResults = this.GetListFromMethod<ItemInfoList>("GetShipScannerResults", "iteminfolist"));
		}

		private bool? _hasCargoScannerResults;
		/// <summary>
		/// Wrapper for the HasCargoScannerResults member of the Entity datatype.
		/// </summary>
		public bool HasCargoScannerResults
		{
			get
			{
				if (_hasCargoScannerResults == null)
					_hasCargoScannerResults = this.GetBool("HasCargoScannerResults");

				return _hasCargoScannerResults.Value;
			}
		}

		private string _fleetTag;
		/// <summary>
		/// Wrapper for the FleetTag member of the Entity datatype.
		/// </summary>
		public string FleetTag
		{
			get
			{
				if (_fleetTag == null)
					_fleetTag = this.GetString("FleetTag");

				return _fleetTag;
			}
		}

		private List<ItemInfoList> _cargoScannerResults;
		/// <summary>
		/// Wrapper for the GetCargoScannerResults method of the entity datatype.
		/// </summary>
		/// <returns></returns>
		public List<ItemInfoList> GetCargoScannerResults()
		{
			return _cargoScannerResults ?? (_cargoScannerResults = this.GetListFromMethod<ItemInfoList>("GetCargoScannerResults", "iteminfolist"));
		}

		private double? _shipScannerCapacitorCharge;
		/// <summary>
		/// Wrapper for the ShipScannerCapacitorCharge member of the Entity datatype.
		/// </summary>
		public double ShipScannerCapacitorCharge
		{
			get
			{
				if (_shipScannerCapacitorCharge == null)
					_shipScannerCapacitorCharge = this.GetDouble("ShipScannerCapacitorCharge");

				return _shipScannerCapacitorCharge.Value;
			}
		}

		private double? _shipScannerCapacitorCapacity;
		/// <summary>
		/// Wrapper for the ShipScannerCapacitorCapacity member of the Entity datatype.
		/// </summary>
		public double ShipScannerCapacitorCapacity
		{
			get
			{
				if (_shipScannerCapacitorCapacity == null)
					_shipScannerCapacitorCapacity = this.GetDouble("ShipScannerCapacitorCapacity");

				return _shipScannerCapacitorCapacity.Value;
			}
		}

		public bool? _isPos;

		public bool IsPos
		{
			get
			{
				if (_isPos == null)
					_isPos = this.GetBool("IsPOS");
				return _isPos.Value;
			}
		}

		private string _posState;

		/// <summary>
		/// The following return values (with the exception of "N/A") may be 
		/// localized: N/A, anchored, anchoring, online, onlining, unanchored, 
		/// unanchoring, vulnerable, invulnerable, reinforced, operating, 
		/// incapacitated
		/// </summary>
		public string PosState
		{
			get { return _posState ?? (_posState = this.GetString("POSState")); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Activate the entity.
		/// </summary>
		/// <returns></returns>
		public bool Activate()
		{
			Tracing.SendCallback("Entity.Activate");
			return ExecuteMethod("Activate");
		}
		/// <summary>
		/// Warp to zero distance
		/// </summary>
		public bool WarpTo()
		{
			Tracing.SendCallback("Entity.WarpTo");
			return ExecuteMethod("WarpTo");
		}

		/// <summary>
		/// Warp to the given distance, in meters.
		/// </summary>
		public bool WarpTo(int Distance)
		{
			Tracing.SendCallback("Entity.WarpTo", Distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("WarpTo", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Warp fleet to zero distance
		/// </summary>
		public bool WarpFleetTo()
		{
			Tracing.SendCallback("Entity.WarpFleetTo");
			return ExecuteMethod("WarpFleetTo");
		}

		/// <summary>
		/// Warp fleet to the given distance, in meters.
		/// </summary>
		public bool WarpFleetTo(int Distance)
		{
			Tracing.SendCallback("Entity.WarpFleetTo", string.Empty);
			return ExecuteMethod("WarpFleetTo", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Align to the entity.
		/// </summary>
		public bool AlignTo()
		{
			Tracing.SendCallback("Entity.AlignTo");
			return ExecuteMethod("AlignTo");
		}

		/// <summary>
		/// Start target lock on the entity
		/// </summary>
		/// <returns></returns>
		public bool LockTarget()
		{
			Tracing.SendCallback("Entity.LockTarget");
			return ExecuteMethod("LockTarget");
		}

		/// <summary>
		/// Unlock the entity
		/// </summary>
		/// <returns></returns>
		public bool UnlockTarget()
		{
			Tracing.SendCallback("Entity.UnlockTarget");
			return ExecuteMethod("UnlockTarget");
		}

		/// <summary>
		/// Approach to 50 meters from target
		/// </summary>
		public bool Approach()
		{
			Tracing.SendCallback("Entity.Approach");
			return ExecuteMethod("Approach");
		}

		/// <summary>
		/// Approach to within the given number of meters
		/// </summary>
		public bool Approach(int Distance)
		{
			Tracing.SendCallback("Entity.Approach", Distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("Approach", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Keep at a range of 1000 meters.
		/// </summary>
		public bool KeepAtRange()
		{
			Tracing.SendCallback("Entity.KeepAtRange");
			return ExecuteMethod("KeepAtRange");
		}

		/// <summary>
		/// Keep at a range of Distance meters.
		/// </summary>
		public bool KeepAtRange(int Distance)
		{
			Tracing.SendCallback("Entity.KeepAtRange", Distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("KeepAtRange", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Orbit at 5000 meters
		/// </summary>
		/// <returns></returns>
		public bool Orbit()
		{
			Tracing.SendCallback("Entity.Orbit");
			return ExecuteMethod("Orbit");
		}

		/// <summary>
		/// Orbit at Distance meters
		/// </summary>
		public bool Orbit(int Distance)
		{
			Tracing.SendCallback("Entity.Orbit", Distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("Orbit", Distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Dock at a station.  Note: You must be within docking range of the station.
		/// </summary>
		public bool Dock()
		{
			Tracing.SendCallback("Entity.Dock");
			return ExecuteMethod("Dock");
		}

		/// <summary>
		/// Selects a locked target as your current Active target
		/// </summary>
		public bool MakeActiveTarget()
		{
			Tracing.SendCallback("Entity.MakeActiveTarget");
			return ExecuteMethod("MakeActiveTarget");
		}

		/// <summary>
		/// Open inventory of entity.
		/// </summary>
		/// <returns></returns>
		public bool Open()
		{
			Tracing.SendCallback("Entity.Open");
			return ExecuteMethod("Open");
		}

		/// <summary>
		/// Same as right click, Stack All -- consolidates stacks
		/// </summary>
		public bool StackAllCargo()
		{
			// TODO - Remove this when stealthbot is updated.
			Tracing.SendCallback("Entity.StackAllCargo - Redirecting to EVEWindow");
			EVEWindow wnd = new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", "ByName", this.ID.ToString(CultureInfo.CurrentCulture)));
			return wnd.StackAll();
		}

		/// <summary>
		/// Sets the entity (container, probably) name.  Your code shouldn't name unnamable entities.
		/// </summary>
		public bool SetName(string Name)
		{
			Tracing.SendCallback("Entity.SetName", Name);
			return ExecuteMethod("SetName", Name);
		}


		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark()
		{
			return CreateBookmark(null, null);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark(string Label)
		{
			return CreateBookmark(Label, null);
		}

		/// <summary>
		/// Creates a bookmark.
		/// </summary>
		public bool CreateBookmark(string Label, string Notes)
		{
			if (!string.IsNullOrEmpty(Label) &&
				!string.IsNullOrEmpty(Notes))
			{
				Tracing.SendCallback("Entity.CreateBookmark", Label, Notes);
				return ExecuteMethod("CreateBookmark", Label, Notes);
			}
			else if (!string.IsNullOrEmpty(Label))
			{
				Tracing.SendCallback("Entity.CreateBookmark", Label);
				return ExecuteMethod("CreateBookmark", Label);
			}
			else
			{
				Tracing.SendCallback("Entity.CreateBookmark");
				return ExecuteMethod("CreateBookmark");
			}
		}

		/// <summary>
		/// For stations, similar to choosing 'Dock' from the station right click menu while in space.
		/// </summary>
		public bool WarpToAndDock()
		{
			Tracing.SendCallback("Entity.WarpToAndDock");
			return ExecuteMethod("WarpToAndDock");
		}

		/// <summary>
		/// 'Stargate' entities only. You must also be in range to jump.
		/// </summary>
		public bool Jump()
		{
			Tracing.SendCallback("Entity.Jump");
			return ExecuteMethod("Jump");
		}

		/// <summary>
		/// This is the preferred method if your script is abandoning one thing at a time.
		/// </summary>
		public bool Abandon()
		{
			Tracing.SendCallback("Entity.Abandon", string.Empty);
			return ExecuteMethod("Abandon");
		}

		/// <summary>
		/// Abandons all of nearby entities of the same group type
		/// </summary>
		public bool AbandonAll()
		{
			Tracing.SendCallback("Entity.AbandonAll", string.Empty);
			return ExecuteMethod("AbandonAll");
		}

		#region Mines
		/// <summary>
		/// Mines only
		/// </summary>
		public bool Mine()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Mine", string.Empty);
			return ExecuteMethod("Mine");
		}

		/// <summary>
		/// Mines only
		/// </summary>
		public bool MineRepeatedly()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.MineRepeatedly", string.Empty);
			return ExecuteMethod("MineRepeatedly");
		}

		/// <summary>
		/// Mines only
		/// </summary>
		public bool ReturnAndOrbit()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.ReturnAndOrbit", string.Empty);
			return ExecuteMethod("ReturnAndOrbit");
		}

		/// <summary>
		/// Mines only
		/// </summary>
		public bool ReturnToDroneBay()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.ReturnToDroneBay", string.Empty);
			return ExecuteMethod("ReturnToDroneBay");
		}

		/// <summary>
		/// Mines only
		/// </summary>
		public bool ScoopToDroneBay()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.ScoopToDroneBay", string.Empty);
			return ExecuteMethod("ScoopToDroneBay");
		}

		/// <summary>
		/// Mines only
		/// </summary>
		public bool ScoopToCargoBay()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.ScoopToCargoBay", string.Empty);
			return ExecuteMethod("ScoopToCargoBay");
		}

		/// <summary>
		/// Mines only
		/// </summary>
		public bool EngageMyTarget()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.EngageMyTarget", string.Empty);
			return ExecuteMethod("EngageMyTarget");
		}
		#endregion

		public bool SetAsSelectedItem()
		{
			return ExecuteMethod("SetAsSelectedItem");
		}
		#endregion
	}

	public class Drone : Entity
	{
		#region Constructors
		/// <summary>
		/// Copy constructor for the Drone object.
		/// </summary>
		/// <param name="Obj"></param>
		public Drone(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Search for a Drone using LS Query syntax.
		/// </summary>
		/// <param queryString="queryString"></param>
		public Drone(string queryString)
			: base(LavishScript.Objects.GetObject("Entity", queryString))
		{
		}

		/// <summary>
		/// Search for a Drone matching the given ID.
		/// </summary>
		/// <param name="entityID"></param>
		public Drone(long entityID)
			: base(LavishScript.Objects.GetObject("Entity", entityID.ToString(CultureInfo.CurrentCulture)))
		{
		}
		#endregion
	}

	/// <summary>
	/// Entity category types
	/// </summary>
	public enum CategoryType
	{
		/// <summary>
		/// System type.
		/// </summary>
		System = 0,

		/// <summary>
		/// Owner type.
		/// </summary>
		Owner = 1,

		/// <summary>
		/// Celestial type.
		/// </summary>
		Celestial = 2,

		/// <summary>
		/// Station type.
		/// </summary>
		Station = 3,

		/// <summary>
		/// Material type.
		/// </summary>
		Material = 4,

		/// <summary>
		/// Accessoriestype.
		/// </summary>
		Accessories = 5,

		/// <summary>
		/// Ship type.
		/// </summary>
		Ship = 6,

		/// <summary>
		/// Module type.
		/// </summary>
		Module = 7,

		/// <summary>
		/// Charge type.
		/// </summary>
		Charge = 8,

		/// <summary>
		/// Blueprint type.
		/// </summary>
		Blueprint = 9,

		/// <summary>
		/// Trading type.
		/// </summary>
		Trading = 10,

		/// <summary>
		/// Entity type.
		/// </summary>
		Entity = 11,

		/// <summary>
		/// Bonus type.
		/// </summary>
		Bonus = 14,

		/// <summary>
		/// AsteroidBelt type.
		/// </summary>
		AsteroidBelt = 15,

		/// <summary>
		/// Skill type.
		/// </summary>
		Skill = 16,

		/// <summary>
		/// Commodity type.
		/// </summary>
		Commodity = 17,

		/// <summary>
		/// Drone type.
		/// </summary>
		Drone = 18,

		/// <summary>
		/// Implant type.
		/// </summary>
		Implant = 20,

		/// <summary>
		/// Deployable type.
		/// </summary>
		Deployable = 22,

		/// <summary>
		/// Structure type.
		/// </summary>
		Structure = 23,

		/// <summary>
		/// Reaction type.
		/// </summary>
		Reaction = 24,

		/// <summary>
		/// Asteroid type.
		/// </summary>
		Asteroid = 25,
	}
}
