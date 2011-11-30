using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the isxeve data type.
	/// </summary>
	public class ISXEVE : LavishScriptPersistentObject
	{
		#region Constructors
		/// <summary>
		/// Copy constructor for ISXEVE object
		/// </summary>
		/// <param name="Obj"></param>
		public ISXEVE(LavishScriptPersistentObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Default constructor for ISXEVE object.  Returns the persistent LS object.
		/// </summary>
		public ISXEVE()
			: base(LavishScript.Objects.GetPersistentObject("ISXEVE"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the Version member of the isxeve object.
		/// </summary>
		public string Version
		{
			get { return this.GetStringFromLSO("Version"); }
		}

		/// <summary>
		/// Note: All scripts should check to make sure that this is true before running.
		/// </summary>
		public bool IsReady
		{
			get { return this.GetBoolFromLSO("IsReady"); }
		}

		/// <summary>
		/// Returns true if the extension is currently in the authentication/patching phase of loading
		/// </summary>
		public bool IsLoading
		{
			get { return this.GetBoolFromLSO("IsLoading"); }
		}

		/// <summary>
		/// This is simply a utility for scripts to convert any number of seconds into a string:
		/// 0 - 59 = "# seconds"
		/// 60 - 3599 = "# minutes and # seconds"
		/// 3600+ = "# hours, # minutes, and # seconds" 
		/// </summary>
		public string SecsToString(int seconds)
		{
			return this.GetStringFromLSO("SecsToString", seconds.ToString());
		}

		/// <summary>
		/// This should be checked before doing anything else once docking/undocking/system changing/warping.
		/// Returns true if safe to use ISXEVE members/methods/TLOS/etc, false if you need to avoid using ISXEVE calls.
		/// </summary>
		public bool IsSafe
		{
			get { return this.GetBoolFromLSO("IsSafe"); }
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
            ExecuteMethod("Debug_SetTypeValidation", enabled.ToString());
        }

        /// <summary>
        /// Disables flushing/closing the ISXEVE logfile between logs, critical for intensive debug logging. Use only when requested by ISXEVE dev.
        /// </summary>
        /// <param name="enabled"></param>
        public void Debug_SetHighPerfLogging(bool enabled)
        {
            Tracing.SendCallback("ISXEVE.Debug_SetHighPerfLogging", enabled);
            ExecuteMethod("Debug_SetHighPerfLogging", enabled.ToString());
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
		#endregion
	}
}
