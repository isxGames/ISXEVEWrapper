using System;
using System.Collections.Generic;
using System.Globalization;

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

		/// <summary>
		/// Wrapper for the CustomsOfficeID member of the evecustomsofficewindow datatype.  The itemID of the
		/// orbital customs office / spaceport this window is operating on.
		/// </summary>
		public long CustomsOfficeID
		{
			get { return this.GetInt64("CustomsOfficeID"); }
		}

		/// <summary>
		/// Wrapper for the SpaceportPinID member of the evecustomsofficewindow datatype.  The currently
		/// selected launchpad/spaceport pin, or -1 for a plain POCO with no integrated launchpad.
		/// </summary>
		public long SpaceportPinID
		{
			get { return this.GetInt64("SpaceportPinID"); }
		}

		/// <summary>
		/// Wrapper for the HasLaunchpad member of the evecustomsofficewindow datatype.  True when the customs
		/// office has an integrated launchpad/spaceport (i.e. <see cref="SpaceportPinID"/> is set).
		/// </summary>
		public bool HasLaunchpad
		{
			get { return this.GetBool("HasLaunchpad"); }
		}

		/// <summary>
		/// Wrapper for the CustomsCapacityUsed member of the evecustomsofficewindow datatype.
		/// </summary>
		public float CustomsCapacityUsed
		{
			get { return this.GetFloat("CustomsCapacityUsed"); }
		}

		/// <summary>
		/// Wrapper for the CustomsCapacityTotal member of the evecustomsofficewindow datatype.
		/// </summary>
		public float CustomsCapacityTotal
		{
			get { return this.GetFloat("CustomsCapacityTotal"); }
		}

		/// <summary>
		/// Wrapper for the CustomsCapacityAvailable member of the evecustomsofficewindow datatype.
		/// </summary>
		public float CustomsCapacityAvailable
		{
			get { return this.GetFloat("CustomsCapacityAvailable"); }
		}

		/// <summary>
		/// Wrapper for the SpaceportCapacityUsed member of the evecustomsofficewindow datatype.
		/// </summary>
		public float SpaceportCapacityUsed
		{
			get { return this.GetFloat("SpaceportCapacityUsed"); }
		}

		/// <summary>
		/// Wrapper for the SpaceportCapacityTotal member of the evecustomsofficewindow datatype.
		/// </summary>
		public float SpaceportCapacityTotal
		{
			get { return this.GetFloat("SpaceportCapacityTotal"); }
		}

		/// <summary>
		/// Wrapper for the SpaceportCapacityAvailable member of the evecustomsofficewindow datatype.
		/// </summary>
		public float SpaceportCapacityAvailable
		{
			get { return this.GetFloat("SpaceportCapacityAvailable"); }
		}

		/// <summary>
		/// Wrapper for the NumCustomsOfficeItems member of the evecustomsofficewindow datatype.  The number of
		/// commodity rows currently in the customs office contents.
		/// </summary>
		public int NumCustomsOfficeItems
		{
			get { return this.GetInt("NumCustomsOfficeItems"); }
		}

		/// <summary>
		/// Wrapper for the NumSpaceportItems member of the evecustomsofficewindow datatype.  The number of
		/// commodity rows currently in the spaceport (launchpad) contents.
		/// </summary>
		public int NumSpaceportItems
		{
			get { return this.GetInt("NumSpaceportItems"); }
		}

		/// <summary>
		/// Wrapper for the CustomsOfficeItem[index] member of the evecustomsofficewindow datatype.  Returns the
		/// Nth (1-based) commodity row of the customs office contents.
		/// </summary>
		/// <param name="index">1-based row index (1..<see cref="NumCustomsOfficeItems"/>).</param>
		public EVECustomsOfficeItem CustomsOfficeItem(int index)
		{
			return new EVECustomsOfficeItem(GetMember("CustomsOfficeItem", index.ToString(CultureInfo.CurrentCulture)));
		}

		/// <summary>
		/// Wrapper for the SpaceportItem[index] member of the evecustomsofficewindow datatype.  Returns the
		/// Nth (1-based) commodity row of the spaceport (launchpad) contents.
		/// </summary>
		/// <param name="index">1-based row index (1..<see cref="NumSpaceportItems"/>).</param>
		public EVECustomsOfficeItem SpaceportItem(int index)
		{
			return new EVECustomsOfficeItem(GetMember("SpaceportItem", index.ToString(CultureInfo.CurrentCulture)));
		}

		/// <summary>
		/// Wrapper for the NumStagedImport member of the evecustomsofficewindow datatype.  The number of rows
		/// staged for import (populated by <see cref="StageImport"/>).
		/// </summary>
		public int NumStagedImport
		{
			get { return this.GetInt("NumStagedImport"); }
		}

		/// <summary>
		/// Wrapper for the NumStagedExport member of the evecustomsofficewindow datatype.  The number of rows
		/// staged for export (populated by <see cref="StageExport"/>).
		/// </summary>
		public int NumStagedExport
		{
			get { return this.GetInt("NumStagedExport"); }
		}

		/// <summary>
		/// Wrapper for the StagedImportItem[index] member of the evecustomsofficewindow datatype.  Returns the
		/// Nth (1-based) staged import row.
		/// </summary>
		/// <param name="index">1-based row index (1..<see cref="NumStagedImport"/>).</param>
		public EVECustomsOfficeItem StagedImportItem(int index)
		{
			return new EVECustomsOfficeItem(GetMember("StagedImportItem", index.ToString(CultureInfo.CurrentCulture)));
		}

		/// <summary>
		/// Wrapper for the StagedExportItem[index] member of the evecustomsofficewindow datatype.  Returns the
		/// Nth (1-based) staged export row.
		/// </summary>
		/// <param name="index">1-based row index (1..<see cref="NumStagedExport"/>).</param>
		public EVECustomsOfficeItem StagedExportItem(int index)
		{
			return new EVECustomsOfficeItem(GetMember("StagedExportItem", index.ToString(CultureInfo.CurrentCulture)));
		}

		#endregion

		#region Methods

		/// <summary>
		/// Wrapper for the AddToPOCO method of the evecustomsofficewindow datatype.  Adds the given item into
		/// the customs office from the given source location.
		/// </summary>
		/// <param name="itemID">The itemID to add.</param>
		/// <param name="fromLocationID">The source location (container) itemID.</param>
		/// <param name="quantity">The quantity to add (must be greater than 0).</param>
		/// <returns></returns>
		public bool AddToPOCO(long itemID, long fromLocationID, long quantity)
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.AddToPOCO", itemID, fromLocationID, quantity);
			return ExecuteMethod("AddToPOCO", itemID.ToString(CultureInfo.CurrentCulture),
				fromLocationID.ToString(CultureInfo.CurrentCulture), quantity.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the PullFromPOCO method of the evecustomsofficewindow datatype.  Pulls the given item
		/// from the customs office into the named ship hold.
		/// </summary>
		/// <param name="itemID">The itemID to pull.</param>
		/// <param name="holdName">The destination ship hold name.</param>
		/// <param name="quantity">The quantity to pull (must be greater than 0).</param>
		/// <returns></returns>
		public bool PullFromPOCO(long itemID, string holdName, long quantity)
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.PullFromPOCO", itemID, holdName, quantity);
			return ExecuteMethod("PullFromPOCO", itemID.ToString(CultureInfo.CurrentCulture), holdName,
				quantity.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the SelectLaunchpad method of the evecustomsofficewindow datatype.  Sets the destination
		/// launchpad/spaceport pin (from <see cref="GetLaunchpads"/>) and rebuilds the window contents.
		/// </summary>
		/// <param name="pinID">The launchpad pin ID to select.</param>
		/// <returns></returns>
		public bool SelectLaunchpad(long pinID)
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.SelectLaunchpad", pinID);
			return ExecuteMethod("SelectLaunchpad", pinID.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the GetLaunchpads method of the evecustomsofficewindow datatype.  Returns the valid
		/// launchpad/spaceport endpoints of this POCO's colony (the pins <see cref="SelectLaunchpad"/> accepts).
		/// </summary>
		/// <returns></returns>
		public List<PILaunchpad> GetLaunchpads()
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.GetLaunchpads");
			return Util.GetListFromMethodDirect<PILaunchpad>(this, "GetLaunchpads", "pilaunchpad");
		}

		/// <summary>
		/// Wrapper for the StageImport method of the evecustomsofficewindow datatype.  Stages the given item
		/// for import (POCO -> ship).
		/// </summary>
		/// <param name="itemID">The itemID to stage for import.</param>
		/// <param name="quantity">The quantity to stage.</param>
		/// <returns></returns>
		public bool StageImport(long itemID, long quantity)
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.StageImport", itemID, quantity);
			return ExecuteMethod("StageImport", itemID.ToString(CultureInfo.CurrentCulture),
				quantity.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the StageExport method of the evecustomsofficewindow datatype.  Stages the given
		/// commodity type for export (ship -> POCO).
		/// </summary>
		/// <param name="typeID">The commodity typeID to stage for export.</param>
		/// <param name="quantity">The quantity to stage.</param>
		/// <returns></returns>
		public bool StageExport(int typeID, long quantity)
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.StageExport", typeID, quantity);
			return ExecuteMethod("StageExport", typeID.ToString(CultureInfo.CurrentCulture),
				quantity.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for the Transfer method of the evecustomsofficewindow datatype.  Commits the staged
		/// import/export (executes the transfer).
		/// </summary>
		/// <returns></returns>
		public bool Transfer()
		{
			Tracing.SendCallback("EveCustomsOfficeWindow.Transfer");
			return ExecuteMethod("Transfer");
		}

		#endregion
	}
}
