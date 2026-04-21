using System.Collections.Generic;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the evedirectionalscannerwindow datatype (inherits evewindow).  Represents
	/// the in-game directional scanner window.  Per <c>ISXEVEChanges.txt:170-171</c>, any
	/// directional scanner window is automatically assigned this type — i.e.
	/// <c>EVEWindow[directionalScannerWindow]</c> returns an object of this type.
	/// </summary>
	public class EveDirectionalScannerWindow : EVEWindow
	{
		public EveDirectionalScannerWindow(LavishScriptObject copy) : base(copy)
		{
		}

		#region Members

		/// <summary>
		/// Wrapper for the Range member of the evedirectionalscannerwindow datatype.
		/// Returns the scanner's configured range in astronomical units (AU), as a float.
		/// </summary>
		public float Range
		{
			get { return this.GetFloat("Range"); }
		}

		/// <summary>
		/// Wrapper for the Angle member of the evedirectionalscannerwindow datatype.
		/// Returns the scanner's configured scan angle in degrees (0-360), as a double.
		/// </summary>
		public double Angle
		{
			get { return this.GetDouble("Angle"); }
		}

		/// <summary>
		/// Wrapper for the IsScanning member of the evedirectionalscannerwindow datatype.
		/// True while a directional scan is in progress.
		/// </summary>
		public bool IsScanning
		{
			get { return this.GetBool("IsScanning"); }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Wrapper for the GetScanResults method of the evedirectionalscannerwindow datatype.
		/// Returns the most recent directional scan results as a list of
		/// <see cref="DirectionalScannerResult"/>.
		/// </summary>
		/// <returns></returns>
		public List<DirectionalScannerResult> GetScanResults()
		{
			return Util.GetListFromMethod<DirectionalScannerResult>(this, "GetScanResults", "directionalscannerresult");
		}

		#endregion
	}
}
