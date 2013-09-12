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
        /// Clear all survey module information for all entities.
        /// </summary>
        /// <returns></returns>
        public bool ClearSurveyResults()
        {
            return ExecuteMethod("ClearSurveyResults");
        }
    }
}
