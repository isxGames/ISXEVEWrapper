using System;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the eveindustrywindow datatype (inherits evewindow).  Represents the EVE Industry
	/// window (industryWnd) used to install manufacturing/research/copying/invention/reaction jobs.
	/// Accessed via <c>EVEWindow[industryWnd]</c>, which auto-promotes the returned evewindow to this
	/// type.  Every member is a pure local read off the already-loaded window; installing a blueprint
	/// (via <c>item:UseBlueprint</c>) is asynchronous, so poll <see cref="IsStartEnabled"/> before
	/// pressing <c>Button["Start"]</c> rather than using a fixed wait.
	/// </summary>
	public class EVEIndustryWindow : EVEWindow
	{
		public EVEIndustryWindow(LavishScriptObject copy) : base(copy)
		{
		}

		#region Members

		/// <summary>
		/// Wrapper for the IsBlueprintInstalled member of the eveindustrywindow datatype.  True when a
		/// blueprint/job is loaded; false in the empty "Please install blueprint" state.
		/// </summary>
		public bool IsBlueprintInstalled
		{
			get { return this.GetBool("IsBlueprintInstalled"); }
		}

		/// <summary>
		/// Wrapper for the IsStartEnabled member of the eveindustrywindow datatype.  True when the Start
		/// button is enabled/pressable right now (reflects the loaded job's status plus any job errors).
		/// </summary>
		public bool IsStartEnabled
		{
			get { return this.GetBool("IsStartEnabled"); }
		}

		/// <summary>
		/// Wrapper for the Runs member of the eveindustrywindow datatype.  The number of runs of the
		/// installed job.  Returns -1 when no blueprint/job is installed.
		/// </summary>
		public int Runs
		{
			get { return this.GetInt("Runs"); }
		}

		/// <summary>
		/// Wrapper for the MaterialEfficiency member of the eveindustrywindow datatype.  The material
		/// efficiency (ME) of the installed blueprint/job.  Returns -1 when nothing is installed.
		/// </summary>
		public int MaterialEfficiency
		{
			get { return this.GetInt("MaterialEfficiency"); }
		}

		/// <summary>
		/// Wrapper for the TimeEfficiency member of the eveindustrywindow datatype.  The time efficiency
		/// (TE) of the installed blueprint/job.  Returns -1 when nothing is installed.
		/// </summary>
		public int TimeEfficiency
		{
			get { return this.GetInt("TimeEfficiency"); }
		}

		/// <summary>
		/// Wrapper for the ActivityID member of the eveindustrywindow datatype.  The industry activity id
		/// (1=Manufacturing, 3=Research Time, 4=Research Material, 5=Copying, 8=Invention, 9=Reaction).
		/// Returns -1 when no blueprint/job is installed.
		/// </summary>
		public int ActivityID
		{
			get { return this.GetInt("ActivityID"); }
		}

		/// <summary>
		/// Wrapper for the Activity member of the eveindustrywindow datatype.  The industry activity name
		/// matching <see cref="ActivityID"/>.  Returns "None" when no blueprint/job is installed.
		/// </summary>
		public string Activity
		{
			get { return this.GetString("Activity"); }
		}

		#endregion
	}
}
