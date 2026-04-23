using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the SystemScanner datatype.
	/// </summary>
	public class SystemScanner : LavishScriptObject
	{
		public SystemScanner(LavishScriptObject Copy) : base(Copy)
		{
		}

		/// <summary>
		/// Wrapper for the IsSensorOverlayActive member of the SystemScanner datatype. Queried live
		/// on every access so the state reflects user-driven overlay toggles immediately.
		/// </summary>
		public bool IsSensorOverlayActive
		{
			get { return this.GetBool("IsSensorOverlayActive"); }
		}

		/// <summary>
		/// Wrapper for the EnableSensorOverlay method of the SystemScanner datatype.
		/// </summary>
		/// <returns></returns>
		public bool EnableSensorOverlay()
		{
			return ExecuteMethod("EnableSensorOverlay");
		}

		/// <summary>
		/// Wrapper for the DisableSensorOverlay method of the SystemScanner datatype.
		/// </summary>
		/// <returns></returns>
		public bool DisableSensorOverlay()
		{
			return ExecuteMethod("DisableSensorOverlay");
		}

		/// <summary>
		/// Wrapper for the GetAnomalies method of the SystemScanner datatype. Re-queries the sensor suite
		/// service on every call — results reflect current anomaly state (new sites, completed sites).
		/// </summary>
		/// <returns></returns>
		public List<SystemAnomaly> GetAnomalies()
		{
			return this.GetListFromMethod<SystemAnomaly>("GetAnomalies", "systemanomaly");
		}

		/// <summary>
		/// Wrapper for the GetSignatures method of the SystemScanner datatype. Re-queries the sensor suite
		/// service on every call — results reflect current signature state (new sigs, resolved sigs).
		/// </summary>
		/// <returns></returns>
		public List<SystemSignature> GetSignatures()
		{
			return this.GetListFromMethod<SystemSignature>("GetSignatures", "systemsignature");
		}
	}
}
