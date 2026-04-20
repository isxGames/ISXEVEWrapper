using System.Collections.Generic;
using System.Globalization;

using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the directionalscanner datatype
    /// </summary>
    public class DirectionalScanner : LavishScriptObject
    {
        public DirectionalScanner(LavishScriptObject Copy) : base(Copy)
        {
        }

        /// <summary>
        /// Start a directional scan using the engine defaults (angle 360, range 2147483647 km).
        /// </summary>
        /// <returns></returns>
        public bool StartScan()
        {
            return ExecuteMethod("StartScan");
        }

        /// <summary>
        /// Start a directional scan at the given angle with the default range (2147483647 km). Valid angles: 5/15/30/60/90/180/360.
        /// </summary>
        /// <param name="angle">Angle of the scan. Valid values: 5, 15, 30, 60, 90, 180, 360.</param>
        /// <returns></returns>
        public bool StartScan(int angle)
        {
            return ExecuteMethod("StartScan", angle.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Start a directional scan at the given angle and range.
        /// </summary>
        /// <param name="angle">Angle of the scan. Default is 360.</param>
        /// <param name="range">Range of the scan. Default is 2147483647.</param>
        /// <returns></returns>
        public bool StartScan(int angle, int range)
        {
            return ExecuteMethod("StartScan", angle.ToString(CultureInfo.CurrentCulture), range.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Get the results of the last started scan using the engine defaults (angle 360, range 2147483647 km).
        /// </summary>
        /// <returns></returns>
        public List<DirectionalScannerResult> GetScanResults()
        {
            return this.GetListFromMethod<DirectionalScannerResult>("GetScanResults", "DirectionalScannerresult");
        }

        /// <summary>
        /// Get the results of the last started scan with the given angle and range. Default is the same as StartScan.
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public List<DirectionalScannerResult> GetScanResults(int angle, int range)
        {
            return this.GetListFromMethod<DirectionalScannerResult>("GetScanResults", "DirectionalScannerresult", angle.ToString(CultureInfo.CurrentCulture), range.ToString(CultureInfo.CurrentCulture));
        }
    }
}
