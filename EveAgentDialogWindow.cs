using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the eveagentdialogwindow datatype (inherits evewindow).  Represents the
	/// agent dialog / mission briefing window.  The matching evewindow is auto-promoted to
	/// this type when its <c>__guid__</c> equals <c>form.AgentDialogueWindow</c>.
	/// </summary>
	public class EveAgentDialogWindow : EVEWindow
	{
		public EveAgentDialogWindow(LavishScriptObject copy) : base(copy)
		{
		}

		#region Members

		/// <summary>
		/// Wrapper for the BriefingHTML member of the eveagentdialogwindow datatype.
		/// Returns the raw HTML of the agent's mission briefing (pulled from <c>briefingHtml</c>).
		/// </summary>
		public string BriefingHTML
		{
			get { return this.GetString("BriefingHTML"); }
		}

		/// <summary>
		/// Wrapper for the ObjectivesHTML member of the eveagentdialogwindow datatype.
		/// Returns the raw HTML of the agent's mission objectives (pulled from <c>objectiveHtml</c>).
		/// </summary>
		public string ObjectivesHTML
		{
			get { return this.GetString("ObjectivesHTML"); }
		}

		#endregion
	}
}
