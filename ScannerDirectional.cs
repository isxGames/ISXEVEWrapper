using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the ScannerDirectional datatype
    /// </summary>
    // God damn CyberTech, someone needs to teach you to name datatypes.
    // "ScannerDirectional" reads like someone who natively speaks in clicks and clacks named it. DirectionalScanner!
    public class ScannerDirectional : LavishScriptObject
    {
        public ScannerDirectional(LavishScriptObject Copy) : base(Copy)
        {
        }

        /// <summary>
        /// Start a directional scan at the given angle and range.
        /// </summary>
        /// <param name="angle">Angle of the scan. Default is 360.</param>
        /// <param name="range">Range of the scan. Default is 2147483647.</param>
        /// <returns></returns>
        public bool StartScan(int angle, int range)
        {
            return ExecuteMethod("StartScan", angle.ToString(), range.ToString());
        }

        /// <summary>
        /// Get the results of the last started scan with the given angle and range. Default is the same as StartScan.
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public List<ScannerDirectionalResult> GetScanResults(int angle, int range)
        {
            return this.GetListFromMethod<ScannerDirectionalResult>("GetScanResults", "scannerdirectionalresult", angle.ToString(), range.ToString());
        }
    }
}
