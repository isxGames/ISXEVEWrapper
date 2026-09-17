using System;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the probe data type.
	/// </summary>
	public class Probe : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Probe copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Probe(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ID member of the probe type.
		/// </summary>
		public Int64 ID
		{
			get { return this.GetInt64("ID"); }
		}

		/// <summary>
		/// Wrapper for the TypeID member of the probe type.
		/// </summary>
		public int TypeID
		{
			get { return this.GetInt("TypeID"); }
		}

		/// <summary>
		/// Wrapper for the Type member of the probe type.
		/// </summary>
		public string Type
		{
			get { return this.GetString("Type"); }
		}

		/// <summary>
		/// Probe state: 0=Inactive, 1=Idle, 2=Moving, 3=Warping, 4=Scanning, 5=Returning.
		/// </summary>
		public int State
		{
			get { return this.GetInt("State"); }
		}

		/// <summary>
		/// Probe state name (matches State).
		/// </summary>
		public string StateName
		{
			get { return this.GetString("StateName"); }
		}

		/// <summary>
		/// Current scan radius, in meters.
		/// </summary>
		public double ScanRange
		{
			get { return this.GetDouble("ScanRange"); }
		}

		/// <summary>
		/// Wrapper for the RangeStep member of the probe type (1-8).
		/// </summary>
		public int RangeStep
		{
			get { return this.GetInt("RangeStep"); }
		}

		/// <summary>
		/// Wrapper for the X member of the probe type.
		/// </summary>
		public double X
		{
			get { return this.GetDouble("X"); }
		}

		/// <summary>
		/// Wrapper for the Y member of the probe type.
		/// </summary>
		public double Y
		{
			get { return this.GetDouble("Y"); }
		}

		/// <summary>
		/// Wrapper for the Z member of the probe type.
		/// </summary>
		public double Z
		{
			get { return this.GetDouble("Z"); }
		}

		/// <summary>
		/// Wrapper for the DestinationX member of the probe type.
		/// </summary>
		public double DestinationX
		{
			get { return this.GetDouble("DestinationX"); }
		}

		/// <summary>
		/// Wrapper for the DestinationY member of the probe type.
		/// </summary>
		public double DestinationY
		{
			get { return this.GetDouble("DestinationY"); }
		}

		/// <summary>
		/// Wrapper for the DestinationZ member of the probe type.
		/// </summary>
		public double DestinationZ
		{
			get { return this.GetDouble("DestinationZ"); }
		}

		/// <summary>
		/// The entity representing this probe.
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
		/// Wrapper for the SetDestination method of the probe type.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		public bool SetDestination(double x, double y, double z)
		{
			Tracing.SendCallback("Probe.SetDestination", x, y, z);
			return ExecuteMethod("SetDestination", x.ToString(CultureInfo.CurrentCulture), y.ToString(CultureInfo.CurrentCulture), z.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the SetRangeStep method of the probe type.
		/// </summary>
		/// <param name="rangeStep">A value from 1 to 8.</param>
		/// <returns></returns>
		public bool SetRangeStep(int rangeStep)
		{
			Tracing.SendCallback("Probe.SetRangeStep", rangeStep.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("SetRangeStep", rangeStep.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the Recall method of the probe type.
		/// </summary>
		/// <returns></returns>
		public bool Recall()
		{
			Tracing.SendCallback("Probe.Recall");
			return ExecuteMethod("Recall");
		}

		/// <summary>
		/// Wrapper for the Destroy method of the probe type.
		/// </summary>
		/// <returns></returns>
		public bool Destroy()
		{
			Tracing.SendCallback("Probe.Destroy");
			return ExecuteMethod("Destroy");
		}
		#endregion
	}
}
