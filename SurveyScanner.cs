using System.Globalization;

using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the SurveyScanner datatype.
    /// </summary>
    public class SurveyScanner : LavishScriptObject
    {
        public SurveyScanner(LavishScriptObject Copy) : base(Copy)
        {
        }

        /// <summary>
        /// Starts a single cycle of the survey module.
        /// </summary>
        public bool StartScan()
        {
            return ExecuteMethod("StartScan");
        }

        /// <summary>
        /// Starts a single cycle of the survey module. When showResultsWindow is true, the in-game results window is shown (ISXEVE blocks it by default).
        /// </summary>
        /// <param name="showResultsWindow"></param>
        /// <returns></returns>
        public bool StartScan(bool showResultsWindow)
        {
            return ExecuteMethod("StartScan", showResultsWindow.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Clear all survey module information for all entities.
        /// </summary>
        /// <returns></returns>
        public bool ClearSurveyResults()
        {
            return ExecuteMethod("ClearSurveyResults");
        }
    }
}
