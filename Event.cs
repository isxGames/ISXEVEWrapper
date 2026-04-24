using System;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Event-key constants for the three actively-fired ISXEVE events.  Use these with
	/// <see cref="LavishScriptAPI.LavishScriptEvents.AttachEventTarget(int, LavishScriptAPI.LavishScriptEvent)"/>
	/// (or the <c>AttachEventTarget(string, ...)</c> overload that resolves the key to a
	/// registered event ID) to subscribe from .NET without typo risk.
	/// </summary>
	/// <remarks>
	/// <para>
	/// ISXEVE registers six public events (see <c>ISXEVE.cpp:253-259</c>), but three are
	/// currently dormant — their firing sites in <c>PyObject_Hooks.cpp</c> are commented out:
	/// </para>
	/// <list type="bullet">
	///   <item><description><c>EVE_OnChannelMessage</c> (firing site at line 410, commented out)</description></item>
	///   <item><description><c>EVE_OnPilotJoinedChannel</c> (firing site at line 367, commented out)</description></item>
	///   <item><description><c>EVE_OnPilotLeftChannel</c> (firing site at line 383, commented out)</description></item>
	/// </list>
	/// <para>
	/// Those are intentionally NOT exposed here to avoid misleading callers into subscribing
	/// to events that will never fire.  If ISXEVE ever re-enables them, add matching constants.
	/// </para>
	/// </remarks>
	public static class Event
	{
		/// <summary>
		/// Fired each game frame while ISXEVE is ready.  Zero event args.
		/// Firing site: <c>PyRefHandler.cpp:144</c> inside <c>HandleOnFrame</c>.
		/// Underlying registered name: <c>ISXEVE_onFrame</c>.
		/// </summary>
		public const string OnFrame = "ISXEVE_onFrame";

		/// <summary>
		/// Fired after the survey-scanner module delivers results.  One event arg:
		/// <c>argv[0]</c> is the survey result count as a decimal string.
		/// Firing site: <c>PyObject_Hooks.cpp:1411</c>.
		/// Underlying registered name: <c>EVE_OnSurveyScanData</c>.
		/// </summary>
		public const string OnSurveyScanData = "EVE_OnSurveyScanData";

		/// <summary>
		/// Fired when an HTTP request (see the <c>GetURL</c>, <c>PostURL</c>, and
		/// <c>PostURLFiles</c> slash commands registered in <c>Commands.h:17-19</c>) completes.
		/// Event args carry the HTTP response payload; the exact arg layout is defined in
		/// shared isxdk HTTP code (not in the ISXEVE source tree).
		/// Underlying registered name: <c>isxGames_onHTTPResponse</c>.
		/// </summary>
		public const string OnHTTPResponse = "isxGames_onHTTPResponse";
	}
}
