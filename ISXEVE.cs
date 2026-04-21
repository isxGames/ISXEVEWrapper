using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the isxeve data type.
	/// </summary>
	public class ISXEVE : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Copy constructor for ISXEVE object
		/// </summary>
		/// <param name="Obj"></param>
		public ISXEVE(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Default constructor for ISXEVE object.  Returns the  LS object.
		/// </summary>
		public ISXEVE()
			: base(LavishScript.Objects.GetObject("ISXEVE"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the Version member of the isxeve object.
		/// </summary>
		public string Version
		{
			get { return this.GetString("Version"); }
		}

		/// <summary>
		/// Note: All scripts should check to make sure that this is true before running.
		/// </summary>
		public bool IsReady
		{
			get { return this.GetBool("IsReady"); }
		}

		/// <summary>
		/// Returns true if the extension is currently in the authentication/patching phase of loading
		/// </summary>
		public bool IsLoading
		{
			get { return this.GetBool("IsLoading"); }
		}

		/// <summary>
		/// This is simply a utility for scripts to convert any number of seconds into a string:
		/// 0 - 59 = "# seconds"
		/// 60 - 3599 = "# minutes and # seconds"
		/// 3600+ = "# hours, # minutes, and # seconds" 
		/// </summary>
		public string SecsToString(int seconds)
		{
			return this.GetString("SecsToString", seconds.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// This should be checked before doing anything else once docking/undocking/system changing/warping.
		/// Returns true if safe to use ISXEVE members/methods/TLOS/etc, false if you need to avoid using ISXEVE calls.
		/// </summary>
		public bool IsSafe
		{
			get { return this.GetBool("IsSafe"); }
		}

		public bool IsBeta
		{
			get { return this.GetBool("IsBeta"); }
		}

		/// <summary>
		/// Utility: returns true if the given argument is numeric.  Takes a single string argument
		/// and resolves via LavishScript's IsNumber check.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public bool IsNumeric(string value)
		{
			return this.GetBool("IsNumeric", value);
		}

		/// <summary>
		/// Diagnostic: returns the ISXEVE internal <c>gIsBusy</c> flag as an int.
		/// </summary>
		/// <remarks>
		/// Not intended for normal script use.  Exposed for symmetry with the registered datatype surface
		/// and for ISXEVE developer diagnostics only.
		/// </remarks>
		public int Debug1
		{
			get { return this.GetInt("Debug1"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Unload the extension.
		/// </summary>
		public void Unload()
		{
			Tracing.SendCallback("ISXEVE.Unload");
			ExecuteMethod("Unload");
		}

		public void Debug_SetTypeValidation(bool enabled)
		{
			Tracing.SendCallback("ISXEVE.Debug_SetTypeValidation", enabled);
			ExecuteMethod("Debug_SetTypeValidation", enabled.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Disables flushing/closing the ISXEVE logfile between logs, critical for intensive debug logging. Use only when requested by ISXEVE dev.
		/// </summary>
		/// <param name="enabled"></param>
		public void Debug_SetHighPerfLogging(bool enabled)
		{
			Tracing.SendCallback("ISXEVE.Debug_SetHighPerfLogging", enabled);
			ExecuteMethod("Debug_SetHighPerfLogging", enabled.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// This will send a message to the ISXEVE logfile. Useful for marking script actions around ISXEVE output.
		/// </summary>
		/// <param name="scriptName"></param>
		/// <param name="logMessage"></param>
		public void Debug_LogMsg(string scriptName, string logMessage)
		{
			Tracing.SendCallback("ISXEVE.Debug_LogMsg", scriptName, logMessage);
			ExecuteMethod("Debug_LogMsg", scriptName, logMessage);
		}

		/// <summary>
		/// Enable the ISXEVE entity cache.  Equivalent to the <c>ISXEVE:Debug_SetEntityCacheEnabled</c>
		/// LavishScript method.
		/// </summary>
		/// <returns></returns>
		public bool Debug_SetEntityCacheEnabled()
		{
			Tracing.SendCallback("ISXEVE.Debug_SetEntityCacheEnabled");
			return ExecuteMethod("Debug_SetEntityCacheEnabled");
		}

		/// <summary>
		/// Disable the ISXEVE entity cache.  Equivalent to the <c>ISXEVE:Debug_SetEntityCacheDisabled</c>
		/// LavishScript method.
		/// </summary>
		/// <returns></returns>
		public bool Debug_SetEntityCacheDisabled()
		{
			Tracing.SendCallback("ISXEVE.Debug_SetEntityCacheDisabled");
			return ExecuteMethod("Debug_SetEntityCacheDisabled");
		}

		/// <summary>
		/// Print ISXEVE cache statistics (held references, per-frame cache, market cache, entity cache)
		/// to the console.  Diagnostic use only.
		/// </summary>
		/// <returns></returns>
		public bool Debug_PrintCacheInfo()
		{
			Tracing.SendCallback("ISXEVE.Debug_PrintCacheInfo");
			return ExecuteMethod("Debug_PrintCacheInfo");
		}

		/// <summary>
		/// Dump the contents of the ISXEVE entity cache to the debug log.  Diagnostic use only.
		/// </summary>
		/// <returns></returns>
		public bool Debug_DumpEntityCache()
		{
			Tracing.SendCallback("ISXEVE.Debug_DumpEntityCache");
			return ExecuteMethod("Debug_DumpEntityCache");
		}

		/// <summary>
		/// Switch the ISXEVE installation to the BETA build branch.  The extension will reload after
		/// the patcher completes.
		/// </summary>
		/// <remarks>
		/// Typically invoked from an interactive InnerSpace console (<c>ISXEVE:InstallBeta</c>), not
		/// from runtime script flow.  Calling this mid-session interrupts the extension.
		/// </remarks>
		/// <returns></returns>
		public bool InstallBeta()
		{
			Tracing.SendCallback("ISXEVE.InstallBeta");
			return ExecuteMethod("InstallBeta");
		}

		/// <summary>
		/// Switch the ISXEVE installation to the TEST build branch.  The extension will reload after
		/// the patcher completes.
		/// </summary>
		/// <remarks>
		/// Typically invoked from an interactive InnerSpace console (<c>ISXEVE:InstallTest</c>), not
		/// from runtime script flow.  Calling this mid-session interrupts the extension.
		/// </remarks>
		/// <returns></returns>
		public bool InstallTest()
		{
			Tracing.SendCallback("ISXEVE.InstallTest");
			return ExecuteMethod("InstallTest");
		}

		/// <summary>
		/// Switch the ISXEVE installation back to the LIVE build branch.  The extension will reload
		/// after the patcher completes.
		/// </summary>
		/// <remarks>
		/// Typically invoked from an interactive InnerSpace console (<c>ISXEVE:InstallLive</c>), not
		/// from runtime script flow.  Calling this mid-session interrupts the extension.
		/// </remarks>
		/// <returns></returns>
		public bool InstallLive()
		{
			Tracing.SendCallback("ISXEVE.InstallLive");
			return ExecuteMethod("InstallLive");
		}
		#endregion
	}
}
