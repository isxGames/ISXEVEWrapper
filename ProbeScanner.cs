using System;
using System.Collections.Generic;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the probescanner data type (MyShip.Scanners.Probe).
	/// </summary>
	public class ProbeScanner : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// ProbeScanner copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public ProbeScanner(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ActiveProbeCount member of the probescanner type.
		/// </summary>
		public int ActiveProbeCount
		{
			get { return this.GetInt("ActiveProbeCount"); }
		}

		/// <summary>
		/// Wrapper for the IsScanning member of the probescanner type.
		/// </summary>
		public bool IsScanning
		{
			get { return this.GetBool("IsScanning"); }
		}

		/// <summary>
		/// Wrapper for the HasOnlineProbeLauncher member of the probescanner type.
		/// </summary>
		public bool HasOnlineProbeLauncher
		{
			get { return this.GetBool("HasOnlineProbeLauncher"); }
		}

		/// <summary>
		/// Wrapper for the ChargesInLauncher member of the probescanner type.
		/// </summary>
		public int ChargesInLauncher
		{
			get { return this.GetInt("ChargesInLauncher"); }
		}

		/// <summary>
		/// Wrapper for the CanClaimProbes member of the probescanner type.
		/// </summary>
		public bool CanClaimProbes
		{
			get { return this.GetBool("CanClaimProbes"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the GetProbes method of the probescanner type.
		/// </summary>
		/// <returns></returns>
		public List<Probe> GetProbes()
		{
			Tracing.SendCallback("ProbeScanner.GetProbes");
			return Util.GetListFromMethod<Probe>(this, "GetProbes", "probe");
		}

		/// <summary>
		/// Wrapper for the GetScanResults method of the probescanner type.
		/// </summary>
		/// <returns></returns>
		public List<ProbeScanResult> GetScanResults()
		{
			Tracing.SendCallback("ProbeScanner.GetScanResults");
			return Util.GetListFromMethod<ProbeScanResult>(this, "GetScanResults", "probescanresult");
		}

		/// <summary>
		/// Wrapper for the LaunchProbes method of the probescanner type.
		/// </summary>
		/// <param name="formationID"></param>
		/// <returns></returns>
		public bool LaunchProbes(int formationID)
		{
			Tracing.SendCallback("ProbeScanner.LaunchProbes", formationID.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("LaunchProbes", formationID.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the Scan method of the probescanner type.
		/// </summary>
		/// <returns></returns>
		public bool Scan()
		{
			Tracing.SendCallback("ProbeScanner.Scan");
			return ExecuteMethod("Scan");
		}

		/// <summary>
		/// Wrapper for the RecallProbes method of the probescanner type.
		/// </summary>
		/// <returns></returns>
		public bool RecallProbes()
		{
			Tracing.SendCallback("ProbeScanner.RecallProbes");
			return ExecuteMethod("RecallProbes");
		}

		/// <summary>
		/// Wrapper for the ReconnectToLostProbes method of the probescanner type.
		/// </summary>
		/// <returns></returns>
		public bool ReconnectToLostProbes()
		{
			Tracing.SendCallback("ProbeScanner.ReconnectToLostProbes");
			return ExecuteMethod("ReconnectToLostProbes");
		}
		#endregion
	}
}
