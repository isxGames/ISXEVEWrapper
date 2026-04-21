using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the evecustomsofficewindow datatype (inherits evewindow).  Represents the
	/// Planetary Import/Export UI window opened when accessing an orbital customs office.
	/// Accessed via <c>EVEWindow[PlanetaryImportExportUI]</c>, which auto-promotes the returned
	/// evewindow to this type.
	/// </summary>
	public class EveCustomsOfficeWindow : EVEWindow
	{
		public EveCustomsOfficeWindow(LavishScriptObject copy) : base(copy)
		{
		}

		#region Members

		/// <summary>
		/// Wrapper for the TaxRate member of the evecustomsofficewindow datatype.
		/// Returns the customs office tax rate as a float (pulled from <c>Window.taxRate</c>).
		/// </summary>
		public float TaxRate
		{
			get { return this.GetFloat("TaxRate"); }
		}

		/// <summary>
		/// Wrapper for the HeaderTitle member of the evecustomsofficewindow datatype.
		/// Returns the customs office header title text (pulled from <c>customsHeaderTitle.text</c>).
		/// </summary>
		public string HeaderTitle
		{
			get { return this.GetString("HeaderTitle"); }
		}

		#endregion
	}
}
