using System;
using System.Collections.Generic;
using System.Globalization;

using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the CargoScanner datatype.
    /// </summary>
    public class CargoScanner : LavishScriptObject
    {
        public CargoScanner(LavishScriptObject Copy) : base(Copy)
        {
        }

        /// <summary>
        /// If ClearPreviousResults is false, then new results are appended to previous. Results will be available in Entity.GetCargoScannerResults()
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="clearPreviousResults"></param>
        /// <returns></returns>
        public bool StartScan(Int64 entityId, bool clearPreviousResults)
        {
            return ExecuteMethod("StartScan", entityId.ToString(CultureInfo.CurrentCulture), clearPreviousResults.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// If ClearPreviousResults is false, then new results are appended to previous. When ShowResultsWindow is true, the in-game results window is shown (ISXEVE blocks it by default).
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="clearPreviousResults"></param>
        /// <param name="showResultsWindow"></param>
        /// <returns></returns>
        public bool StartScan(Int64 entityId, bool clearPreviousResults, bool showResultsWindow)
        {
            return ExecuteMethod("StartScan", entityId.ToString(CultureInfo.CurrentCulture), clearPreviousResults.ToString(CultureInfo.CurrentCulture), showResultsWindow.ToString(CultureInfo.CurrentCulture));
        }
    }
}
