using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
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
		/// Create Entity object by ID
		/// </summary>
		/// <param name="ID"></param>
		public Entity(Int64 ID)
			: base(LavishScript.Objects.GetObject("Entity", ID.ToString()))
		{
		}

		/// <summary>
		/// Create Entity object by name
		/// </summary>
		/// <param name="name"></param>
		public Entity(string name)
			: base(LavishScript.Objects.GetObject("Entity", name))
		{
		}

		/// <summary>
		/// Create Entity object by search
		/// </summary>
		/// <param name="Args"></param>
		public Entity(params string[] Args)
			: base(LavishScript.Objects.GetObject("Entity", Args))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the Alliance member of the entity type.
		/// </summary>
		public string Alliance
		{
			get
			{
				return GetMember<string>("Alliance");
			}
		}

		/// <summary>
		/// Wrapper for the AllianceID member of the entity type.
		/// </summary>
		public int AllianceID
		{
			get
			{
				return GetMember<int>("AllianceID");
			}
		}

		/// <summary>
		/// Wrapper for the AllianceTicker member of the entity type.
		/// </summary>
		public string AllianceTicker
		{
			get
			{
				return GetMember<string>("AllianceTicker");
			}
		}

		/// <summary>
		/// Wrapper for the Category member of the entity type.
		/// </summary>
		public string Category
		{
			get
			{
				return GetMember<string>("Category");
			}
		}

		/// <summary>
		/// Wrapper for the CategoryID member of the entity type.
		/// </summary>
		public int CategoryID
		{
			get
			{
				LavishScriptObject categoryID = GetMember("CategoryID");
				if (LavishScriptObject.IsNullOrInvalid(categoryID))
				{
					return -1;
				}
				else
				{
					return categoryID.GetValue<int>();
				}
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

		/// <summary>
		/// Wrapper for the CharID member of the entity type.
		/// </summary>
		public int CharID
		{
			get
			{
				return GetMember<int>("CharID");
			}
		}

		/// <summary>
		/// Wrapper for the Corporation member of the entity type.
		/// </summary>
		public string Corporation
		{
			get
			{
				return GetMember<string>("Corporation");
			}
		}

		/// <summary>
		/// Wrapper for the CorporationID member of the entity type.
		/// </summary>
		public int CorporationID
		{
			get
			{
				return GetMember<int>("CorporationID");
			}
		}

		/// <summary>
		/// Wrapper for the CorporationTicker member of the entity type.
		/// </summary>
		public string CorporationTicker
		{
			get
			{
				return GetMember<string>("CorporationTicker");
			}
		}

		/// <summary>
		/// Wrapper for the FormationID member of the entity type.
		/// </summary>
		public int FormationID
		{
			get
			{
				return GetMember<int>("FormationID");
			}
		}

		/// <summary>
		/// Wrapper for the Group member of the entity type.
		/// </summary>
		public string Group
		{
			get
			{
				return GetMember<string>("Group");
			}
		}

		/// <summary>
		/// Wrapper for the GroupID member of the entity type.
		/// </summary>
		public int GroupID
		{
			get
			{
				LavishScriptObject groupID = GetMember("GroupID");
				if (LavishScriptObject.IsNullOrInvalid(groupID))
				{
					return -1;
				}
				else
				{
					return groupID.GetValue<int>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the ID member of the entity type.
		/// </summary>
		public Int64 ID
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
					return id.GetValue<Int64>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the MaxVelocity member of the entity type.
		/// </summary>
		public double MaxVelocity
		{
			get
			{
				LavishScriptObject maxVelocity = GetMember("MaxVelocity");
				if (!LavishScriptObject.IsNullOrInvalid(maxVelocity))
				{
					return maxVelocity.GetValue<double>();
				}
				else
				{
					return -1;
				}
			}
		}

		/// <summary>
		/// Wrapper for the Name member of the entity type.
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Only valid if the owner is on the locals list.  Use OwnerID otherwise.
		/// </summary>
		public Pilot Owner
		{
			get
			{
				LavishScriptObject owner = GetMember("Owner");

				if (!LavishScriptObject.IsNullOrInvalid(owner) && owner.LSType == "pilot")
					return new Pilot(owner);

				// invalid return
				return new Pilot((LavishScriptObject)null);
			}
		}

		/// <summary>
		/// Wrapper for the OwnerID member of the entity type.
		/// </summary>
		public int OwnerID
		{
			get
			{
				LavishScriptObject ownerID = GetMember("OwnerID");
				if (LavishScriptObject.IsNullOrInvalid(ownerID))
				{
					return -1;
				}
				else
				{
					return ownerID.GetValue<int>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the Security member of the entity type.
		/// </summary>
		public double Security
		{
			get
			{
				LavishScriptObject security = GetMember("Security");
				if (LavishScriptObject.IsNullOrInvalid(security))
				{
					return -1;
				}
				else
				{
					return security.GetValue<double>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the Type member of the entity type.
		/// </summary>
		public string Type
		{
			get
			{
				return GetMember<string>("Type");
			}
		}

		/// <summary>
		/// Wrapper for the TypeID member of the entity type.
		/// </summary>
		public int TypeID
		{
			get
			{
				LavishScriptObject typeID = GetMember("TypeID");
				if (LavishScriptObject.IsNullOrInvalid(typeID))
				{
					return -1;
				}
				else
				{
					return typeID.GetValue<int>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the WreckID member of the entity type.
		/// </summary>
		public int WreckID
		{
			get
			{
				return GetMember<int>("WreckID");
			}
		}

		/// <summary>
		/// Wrapper for the ToActiveDrone member of the entity type.
		/// </summary>
		public ActiveDrone ToActiveDrone
		{
			get
			{
				return new ActiveDrone(GetMember("ToActiveDrone"));
			}
		}

		/// <summary>
		/// Wrapper for the GetActiveDrones member of the entity type.
		/// </summary>
		/// <returns></returns>
		public List<ActiveDrone> GetActiveDrones()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.GetActiveDrones", string.Empty);

			return Util.GetListFromMember<ActiveDrone>(this, "GetActiveDrones", "activedrone");
		}

		/// <summary>
		/// Wrapper for the IsWreckEmpty member of the entity type.
		/// </summary>
		public bool IsWreckEmpty
		{
			get
			{
				LavishScriptObject isWreckEmpty = GetMember("IsWreckEmpty");
				if (LavishScriptObject.IsNullOrInvalid(isWreckEmpty))
				{
					//return true because a "negative" is empty, aka true
					return true;
				}
				return isWreckEmpty.GetValue<bool>();
			}
		}

		/// <summary>
		/// Wrapper for the IsOwnedByCorpMember member of the entity type.
		/// </summary>
		public bool IsOwnedByCorpMember
		{
			get
			{
				LavishScriptObject isOwnedByCorpMember = GetMember("IsOwnedByCorpMember");
				if (LavishScriptObject.IsNullOrInvalid(isOwnedByCorpMember))
				{
					return false;
				}
				return isOwnedByCorpMember.GetValue<bool>();
			}
		}

		/// <summary>
		/// Wrapper for the IsOwnedByAllianceMember member of the entity type.
		/// </summary>
		public bool IsOwnedByAllianceMember
		{
			get
			{
				LavishScriptObject isOwnedByAllianceMember = GetMember("IsOwnedByAllianceMember");
				if (LavishScriptObject.IsNullOrInvalid(isOwnedByAllianceMember))
				{
					return false;
				}
				return isOwnedByAllianceMember.GetValue<bool>();
			}
		}

        public bool IsAbandoned
        {
            get
            {
                LavishScriptObject IsAbandoned = GetMember("IsAbandoned");
                if (LavishScriptObject.IsNullOrInvalid(IsAbandoned))
                {
                    return false;
                }
                return IsAbandoned.GetValue<bool>();
            }
        }

		#region Location
		/// <summary>
		/// Wrapper for the X member of the entity type.
		/// </summary>
		public double X
		{
			get
			{
				return GetMember<double>("X");
			}
		}

		/// <summary>
		/// Wrapper for the Y member of the entity type.
		/// </summary>
		public double Y
		{
			get
			{
				return GetMember<double>("Y");
			}
		}

		/// <summary>
		/// Wrapper for the Z member of the entity type.
		/// </summary>
		public double Z
		{
			get
			{
				return GetMember<double>("Z");
			}
		}

		/// <summary>
		/// Wrapper for the vX member of the entity type.
		/// </summary>
		public double vX
		{
			get
			{
				return GetMember<double>("vX");
			}
		}

		/// <summary>
		/// Wrapper for the vY member of the entity type.
		/// </summary>
		public double vY
		{
			get
			{
				return GetMember<double>("vY");
			}
		}

		/// <summary>
		/// Wrapper for the vZ member of the entity type.
		/// </summary>
		public double vZ
		{
			get
			{
				return GetMember<double>("vZ");
			}
		}

		/// <summary>
		/// Wrapper for the Pitch member of the entity type.
		/// </summary>
		public double Pitch
		{
			get
			{
				return GetMember<double>("Pitch");
			}
		}

		/// <summary>
		/// Wrapper for the Roll member of the entity type.
		/// </summary>
		public double Roll
		{
			get
			{
				return GetMember<double>("Roll");
			}
		}

		/// <summary>
		/// Wrapper for the Yaw member of the entity type.
		/// </summary>
		public double Yaw
		{
			get
			{
				return GetMember<double>("Yaw");
			}
		}

		/// <summary>
		/// Wrapper for the Velocity member of the entity type.
		/// </summary>
		public double Velocity
		{
			get
			{
				return (double)GetMember<float>("Velocity");
			}
		}

		/// <summary>
		/// Wrapper for the Distance member of the entity type.
		/// </summary>
		public double Distance
		{
			get
			{
				return (double)GetMember<float>("Distance");
			}
		}

		/// <summary>
		/// Wrapper for the DistanceTo member of the entity type.
		/// </summary>
		/// <param name="EntityID"></param>
		/// <returns></returns>
		public double DistanceTo(int EntityID)
		{
			return GetMember<double>("DistanceTo", EntityID.ToString());
		}

		/// <summary>
		/// Wrapper for the FollowRange member of the entity type.
		/// </summary>
		public double FollowRange
		{
			get
			{
				return GetMember<double>("FollowRange");
			}
		}
		#endregion

		#region Physical
		/// <summary>
		/// Wrapper for the Mass member of the entity type.
		/// </summary>
		public double Mass
		{
			get
			{
				return GetMember<double>("Mass");
			}
		}

		/// <summary>
		/// Wrapper for the Radius member of the entity type.
		/// </summary>
		public double Radius
		{
			get
			{
				return GetMember<double>("Radius");
			}
		}

		/// <summary>
		/// Wrapper for the ShieldPct member of the entity type.
		/// </summary>
		public double ShieldPct
		{
			get
			{
				return GetMember<double>("ShieldPct");
			}
		}

		/// <summary>
		/// Wrapper for the ArmorPct member of the entity type.
		/// </summary>
		public double ArmorPct
		{
			get
			{
				return GetMember<double>("ArmorPct");
			}
		}

		/// <summary>
		/// Wrapper for the StructurePct member of the entity type.
		/// </summary>
		public double StructurePct
		{
			get
			{
				return GetMember<double>("StructurePct");
			}
		}
		#endregion

		#region Logical
		/// <summary>
		/// Wrapper for the IsCloaked member of the entity type.
		/// </summary>
		public bool IsCloaked
		{
			get
			{
				return GetMember<bool>("IsCloaked");
			}
		}

		/// <summary>
		/// Wrapper for the IsInteractive member of the entity type.
		/// </summary>
		public bool IsInteractive
		{
			get
			{
				return GetMember<bool>("IsInteractive");
			}
		}

		/// <summary>
		/// Wrapper for the IsMassive member of the entity type.
		/// </summary>
		public bool IsMassive
		{
			get
			{
				return GetMember<bool>("IsMassive");
			}
		}

		/// <summary>
		/// Wrapper for the IsGlobal member of the entity type.
		/// </summary>
		public bool IsGlobal
		{
			get
			{
				return GetMember<bool>("IsGlobal");
			}
		}

		/// <summary>
		/// Wrapper for the IsMoribund member of the entity type.
		/// </summary>
		public bool IsMoribund
		{
			get
			{
				return GetMember<bool>("IsMoribund");
			}
		}

		/// <summary>
		/// Wrapper for the IsWarpScrambled member of the entity type.
		/// </summary>
		public bool IsWarpScrambled
		{
			get
			{
				LavishScriptObject isWarpScrambled = GetMember("IsWarpScrambled");
				if (LavishScriptObject.IsNullOrInvalid(isWarpScrambled))
				{
					return false;
				}
				return isWarpScrambled.GetValue<bool>();
			}
		}

		/// <summary>
		/// Wrapper for the IsActiveTarget member of the entity type.
		/// </summary>
		public bool IsActiveTarget
		{
			get
			{
				LavishScriptObject isActiveTarget = GetMember("IsActiveTarget");
				if (LavishScriptObject.IsNullOrInvalid(isActiveTarget))
				{
					return false;
				}
				return isActiveTarget.GetValue<bool>();
			}
		}

		/// <summary>
		/// Wrapper for the IsLockedTarget member of the entity type.
		/// </summary>
		public bool IsLockedTarget
		{
			get
			{
				return GetMember<bool>("IsLockedTarget");
			}
		}

		/// <summary>
		/// Wrapper for the IsNPC member of the entity type.
		/// </summary>
		public bool IsNPC
		{
			get
			{
				LavishScriptObject isNPC = GetMember("IsNPC");
				if (LavishScriptObject.IsNullOrInvalid(isNPC))
				{
					return false;
				}
				else
				{
					return isNPC.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the IsPC member of the entity type.
		/// </summary>
		public bool IsPC
		{
			get
			{
				LavishScriptObject isPC = GetMember("IsPC");
				if (LavishScriptObject.IsNullOrInvalid(isPC))
				{
					return false;
				}
				else
				{
					return isPC.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Wrapper for the HaveLootRights member of the entity type.
		/// </summary>
		public bool HaveLootRights
		{
			get
			{
				LavishScriptObject haveLootRights = GetMember("HaveLootRights");
				if (LavishScriptObject.IsNullOrInvalid(haveLootRights))
				{
					return false;
				}
				return haveLootRights.GetValue<bool>();
			}
		}

		/// <summary>
		/// Known Modes
		/// 2 - Stopped 
		/// 3 - Warping (in warp) 
		/// </summary>
		public int Mode
		{
			get
			{
				return GetMember<int>("Mode");
			}
		}

		/// <summary>
		/// Wrapper for the IsTargetingMe member of the entity type.
		/// </summary>
		public bool IsTargetingMe
		{
			get
			{
				return GetMember<bool>("IsTargetingMe");
			}
		}

		/// <summary>
		/// Wrapper for the IsWarpScramblingMe member of the entity type.
		/// </summary>
		public bool IsWarpScramblingMe
		{
			get
			{
				return GetMember<bool>("IsWarpScramblingMe");
			}
		}

		/// <summary>
		/// Wrapper for the IsTargetJammingMe member of the entity type.
		/// </summary>
		public bool IsTargetJammingMe
		{
			get
			{
				return GetMember<bool>("IsTargetJammingMe");
			}
		}

		/// <summary>
		/// Wrapper for the BeingTargeted member of the entity type.
		/// </summary>
		public bool BeingTargeted
		{
			get
			{
				return GetMember<bool>("BeingTargeted");
			}
		}

		/// <summary>
		/// Wrapper for the Approaching member of the entity type.
		/// </summary>
		public Entity Approaching
		{
			get
			{
				return new Entity(GetMember("Approaching"));
			}
		}

		/// <summary>
		/// Wrapper for the Following member of the entity type.
		/// </summary>
		public Entity Following
		{
			get
			{
				return new Entity(GetMember("Following"));
			}
		}
		#endregion

		#region Cargo
		/// <summary>
		/// Wrapper for the CargoCapacity member of the entity type.
		/// </summary>
		public double CargoCapacity
		{
			get
			{
				return GetMember<double>("CargoCapacity");
			}
		}

		/// <summary>
		/// Wrapper for the UsedCargoCapacity member of the entity type.
		/// </summary>
		public double UsedCargoCapacity
		{
			get
			{
				return GetMember<double>("UsedCargoCapacity");
			}
		}

		/// <summary>
		/// Number of items in the cargo.  Keep in mind this might
		/// be wrong if the cargo hold isn't open.
		/// </summary>
		public int CargoCount
		{
			get
			{
				LavishScriptObject cargoCount = GetMember("GetCargo");
				if (LavishScriptObject.IsNullOrInvalid(cargoCount))
				{
					return -1;
				}
				return cargoCount.GetValue<int>();
			}
		}

		/// <summary>
		/// List of all cargo items.  Keep in mind this might
		/// be empty or invalid if the cargo hold isn't open
		/// </summary>
		/// <returns></returns>
		public List<Item> GetCargo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.GetCargo", string.Empty);
			return Util.GetListFromMember<Item>(this, "GetCargo", "item");
		}

		/// <summary>
		/// If you have used "OpenCargo" on this entity and a 'loot window' 
		/// has appeared, then this member will return an evewindow datatype 
		/// object representing that lootwindow. Otherwise, it will return NULL.
		/// </summary>
		public EVEWindow LootWindow
		{
			get
			{
				return new EVEWindow(GetMember("LootWindow"));
			}
		}

		/// <summary>
		/// Alias for 'LootWindow'
		/// </summary>
		public EVEWindow CargoWindow
		{
			get
			{
				return new EVEWindow(GetMember("CargoWindow"));
			}
		}
		#endregion

		/// <summary>
		/// Wrapper for the ToAttacker member of the Entity datatype.
		/// </summary>
		public Attacker ToAttacker
		{
			get
			{
				return new Attacker(GetMember("ToAttacker"));
			}
		}

		/// <summary>
		/// Get the Jammer member of the Entity object
		/// </summary>
		public Jammer ToJammer
		{
			get
			{
				return new Jammer(GetMember("ToJammer"));
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Activate the entity.
		/// </summary>
		/// <returns></returns>
		public bool Activate()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Activate", string.Empty);
			return ExecuteMethod("Activate");
		}
		/// <summary>
		/// Warp to zero distance
		/// </summary>
		public bool WarpTo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.WarpTo", string.Empty);
			return ExecuteMethod("WarpTo");
		}

		/// <summary>
		/// Warp to the given distance, in meters.
		/// </summary>
		public bool WarpTo(int Distance)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.WarpTo", Distance.ToString());
			return ExecuteMethod("WarpTo", Distance.ToString());
		}

        /// <summary>
        /// This is the preferred method if your script is abandoning one thing at a time.
        /// </summary>
        public bool Abandon()
        {
            if (Tracing.Callback != null)
                Tracing.SendCallback("Entity.Abandon", string.Empty);
            return ExecuteMethod("Abandon");
        }

        /// <summary>
        /// Abandons all of nearby entities of the same group type
        /// </summary>
        public bool AbandonAll()
        {
            if (Tracing.Callback != null)
                Tracing.SendCallback("Entity.AbandonAll", string.Empty);
            return ExecuteMethod("AbandonAll");
        }

		/// <summary>
		/// Warp fleet to zero distance
		/// </summary>
		public bool WarpFleetTo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.WarpFleetTo", string.Empty);
			return ExecuteMethod("WarpFleetTo");
		}

		/// <summary>
		/// Warp fleet to the given distance, in meters.
		/// </summary>
		public bool WarpFleetTo(int Distance)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("StartConversation", string.Empty);
			return ExecuteMethod("WarpFleetTo", Distance.ToString());
		}

		/// <summary>
		/// Align to the entity.
		/// </summary>
		public bool Align()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Align", string.Empty);
			return ExecuteMethod("Align");
		}

		/// <summary>
		/// Start target lock on the entity
		/// </summary>
		/// <returns></returns>
		public bool LockTarget()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.LockTarget", string.Empty);
			return ExecuteMethod("LockTarget");
		}

		/// <summary>
		/// Unlock the entity
		/// </summary>
		/// <returns></returns>
		public bool UnlockTarget()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.UnlockTarget", string.Empty);
			return ExecuteMethod("UnlockTarget");
		}

		/// <summary>
		/// Approach to 50 meters from target
		/// </summary>
		public bool Approach()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Approach", string.Empty);
			return ExecuteMethod("Approach");
		}

		/// <summary>
		/// Approach to within the given number of meters
		/// </summary>
		public bool Approach(int Distance)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Approach", Distance.ToString());
			return ExecuteMethod("Approach", Distance.ToString());
		}

		/// <summary>
		/// Keep at a range of 1000 meters.
		/// </summary>
		public bool KeepAtRange()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.KeepAtRange", string.Empty);
			return ExecuteMethod("KeepAtRange");
		}

		/// <summary>
		/// Keep at a range of Distance meters.
		/// </summary>
		public bool KeepAtRange(int Distance)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.KeepAtRange", Distance.ToString());
			return ExecuteMethod("KeepAtRange", Distance.ToString());
		}

		/// <summary>
		/// Orbit at 5000 meters
		/// </summary>
		/// <returns></returns>
		public bool Orbit()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Orbit", string.Empty);
			return ExecuteMethod("Orbit");
		}

		/// <summary>
		/// Orbit at Distance meters
		/// </summary>
		public bool Orbit(int Distance)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Orbit", Distance.ToString());
			return ExecuteMethod("Orbit", Distance.ToString());
		}

		/// <summary>
		/// Dock at a station.  Note: You must be within docking range of the station.
		/// </summary>
		public bool Dock()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Dock", string.Empty);
			return ExecuteMethod("Dock");
		}

		/// <summary>
		/// Selects a locked target as your current Active target
		/// </summary>
		public bool MakeActiveTarget()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.MakeActiveTarget", string.Empty);
			return ExecuteMethod("MakeActiveTarget");
		}

		/// <summary>
		/// Open cargo hold of entity.
		/// </summary>
		/// <returns></returns>
		public bool OpenCargo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.OpenCargo", string.Empty);
			return ExecuteMethod("OpenCargo");
		}

		/// <summary>
		/// Close cargo hold of entity.
		/// </summary>
		/// <returns></returns>
		public bool CloseCargo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.CloseCargo", string.Empty);
			return ExecuteMethod("CloseCargo");
		}

		/// <summary>
		/// Same as right click, Stack All -- consolidates stacks
		/// </summary>
		public bool StackAllCargo()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.StackAllCargo", string.Empty);
			return ExecuteMethod("StackAllCargo");
		}

		/// <summary>
		/// Sets the entity (container, probably) name.  Your code shouldn't name unnamable entities.
		/// </summary>
		public bool SetName(string Name)
		{
			if (Tracing.Callback != null)
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
				if (Tracing.Callback != null)
					Tracing.SendCallback("Entity.CreateBM", String.Format("{0},{1}", Label, Notes));
				return ExecuteMethod("CreateBookmark", Label, Notes);
			}
			else if (!string.IsNullOrEmpty(Label))
			{
				if (Tracing.Callback != null)
					Tracing.SendCallback("Entity.CreateBM", Label);
				return ExecuteMethod("CreateBookmark", Label);
			}
			else
			{
				if (Tracing.Callback != null)
					Tracing.SendCallback("Entity.CreateBM", string.Empty);
				return ExecuteMethod("CreateBookmark");
			}
		}

		/// <summary>
		/// For stations, similar to choosing 'Dock' from the station right click menu while in space.
		/// </summary>
		public bool WarpToAndDock()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.WarpToAndDock", string.Empty);
			return ExecuteMethod("WarpToAndDock");
		}

		/// <summary>
		/// 'Stargate' entities only. You must also be in range to jump.
		/// </summary>
		public bool Jump()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Entity.Jump", string.Empty);
			return ExecuteMethod("Jump");
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
