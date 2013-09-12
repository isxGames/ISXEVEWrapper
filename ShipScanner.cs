using System;
using System.Collections.Generic;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the shipscanner datatype.
    /// </summary>
    public class ShipScanner : LavishScriptObject
    {
        public ShipScanner(LavishScriptObject Copy) : base(Copy)
        {

        }

        /// <summary>
        /// If ClearPreviousResults is false, then new results are appended to previous. Results will be available in Entity.GetShipScannerResults().
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="clearPreviousResults"></param>
        /// <returns></returns>
        public bool StartScan(Int64 entityId, bool clearPreviousResults)
        {
            return ExecuteMethod("StartScan", entityId.ToString(), clearPreviousResults.ToString());
        }
    }
}
