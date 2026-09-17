using System;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the probescanresult data type.
	/// </summary>
	public class ProbeScanResult : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// ProbeScanResult copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public ProbeScanResult(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// The scan result id (targetID); a STRING for signature/anomaly sites.
		/// </summary>
		public string ID
		{
			get { return this.GetString("ID"); }
		}

		/// <summary>
		/// Wrapper for the ScanGroupID member of the probescanresult type.
		/// </summary>
		public int ScanGroupID
		{
			get { return this.GetInt("ScanGroupID"); }
		}

		/// <summary>
		/// Wrapper for the ScanGroup member of the probescanresult type (matches ScanGroupID).
		/// </summary>
		public string ScanGroup
		{
			get { return this.GetString("ScanGroup"); }
		}

		/// <summary>
		/// Wrapper for the GroupID member of the probescanresult type.
		/// </summary>
		public int GroupID
		{
			get { return this.GetInt("GroupID"); }
		}

		/// <summary>
		/// Wrapper for the Group member of the probescanresult type (matches GroupID).
		/// </summary>
		public string Group
		{
			get { return this.GetString("Group"); }
		}

		/// <summary>
		/// Wrapper for the TypeID member of the probescanresult type.
		/// </summary>
		public int TypeID
		{
			get { return this.GetInt("TypeID"); }
		}

		/// <summary>
		/// Wrapper for the Type member of the probescanresult type (matches TypeID).
		/// </summary>
		public string Type
		{
			get { return this.GetString("Type"); }
		}

		/// <summary>
		/// Wrapper for the Name member of the probescanresult type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

		/// <summary>
		/// 0-100 probe-scan signal strength; 100 = perfect.
		/// </summary>
		public double Certainty
		{
			get { return this.GetDouble("Certainty"); }
		}

		/// <summary>
		/// 0-100 signal strength from the previous scan.
		/// </summary>
		public double PreviousCertainty
		{
			get { return this.GetDouble("PreviousCertainty"); }
		}

		/// <summary>
		/// Wrapper for the IsPerfect member of the probescanresult type.
		/// </summary>
		public bool IsPerfect
		{
			get { return this.GetBool("IsPerfect"); }
		}

		/// <summary>
		/// Wrapper for the IsIdentified member of the probescanresult type.
		/// </summary>
		public bool IsIdentified
		{
			get { return this.GetBool("IsIdentified"); }
		}

		/// <summary>
		/// Wrapper for the IsWarpable member of the probescanresult type.
		/// </summary>
		public bool IsWarpable
		{
			get { return this.GetBool("IsWarpable"); }
		}

		/// <summary>
		/// Wrapper for the X member of the probescanresult type.
		/// </summary>
		public double X
		{
			get { return this.GetDouble("X"); }
		}

		/// <summary>
		/// Wrapper for the Y member of the probescanresult type.
		/// </summary>
		public double Y
		{
			get { return this.GetDouble("Y"); }
		}

		/// <summary>
		/// Wrapper for the Z member of the probescanresult type.
		/// </summary>
		public double Z
		{
			get { return this.GetDouble("Z"); }
		}

		/// <summary>
		/// Meters from your ship; -1 if position unknown.
		/// </summary>
		public double Distance
		{
			get { return this.GetDouble("Distance"); }
		}

		/// <summary>
		/// Wrapper for the Difficulty member of the probescanresult type.
		/// </summary>
		public int Difficulty
		{
			get { return this.GetInt("Difficulty"); }
		}

		/// <summary>
		/// Wrapper for the DungeonID member of the probescanresult type.
		/// </summary>
		public int DungeonID
		{
			get { return this.GetInt("DungeonID"); }
		}

		/// <summary>
		/// Wrapper for the DungeonName member of the probescanresult type.
		/// </summary>
		public string DungeonName
		{
			get { return this.GetString("DungeonName"); }
		}

		/// <summary>
		/// Wrapper for the FactionID member of the probescanresult type.
		/// </summary>
		public int FactionID
		{
			get { return this.GetInt("FactionID"); }
		}

		/// <summary>
		/// Wrapper for the Faction member of the probescanresult type.
		/// </summary>
		public string Faction
		{
			get { return this.GetString("Faction"); }
		}

		/// <summary>
		/// The entity representing this scan result, when available.
		/// </summary>
		public Entity ToEntity
		{
			get
			{
				var entity = GetMember("ToEntity");
				return IsNullOrInvalid(entity) ? null : new Entity(entity);
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the WarpTo method of the probescanresult type. Warps to 0 distance with FleetWarp=false.
		/// </summary>
		/// <returns></returns>
		public bool WarpTo()
		{
			Tracing.SendCallback("ProbeScanResult.WarpTo");
			return ExecuteMethod("WarpTo");
		}

		/// <summary>
		/// Wrapper for the WarpTo method of the probescanresult type. Warps to the given distance with FleetWarp=false.
		/// </summary>
		/// <param name="distance"></param>
		/// <returns></returns>
		public bool WarpTo(int distance)
		{
			Tracing.SendCallback("ProbeScanResult.WarpTo", distance.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("WarpTo", distance.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the WarpTo method of the probescanresult type.
		/// </summary>
		/// <param name="distance"></param>
		/// <param name="isFleetWarp"></param>
		/// <returns></returns>
		public bool WarpTo(int distance, bool isFleetWarp)
		{
			Tracing.SendCallback("ProbeScanResult.WarpTo", distance, isFleetWarp);
			return ExecuteMethod("WarpTo", distance.ToString(CultureInfo.CurrentCulture), isFleetWarp.ToString(CultureInfo.CurrentCulture));
		}
		#endregion
	}
}
