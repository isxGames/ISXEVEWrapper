using System;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the Scanners datatype.
    /// </summary>
    public class Scanners : LavishScriptObject
    {
        public Scanners(LavishScriptObject Copy) : base(Copy)
        {
        }

        private ScannerDirectional _directional;
        /// <summary>
        /// Wraps the Directional member of the Scanners datatype.
        /// </summary>
        public ScannerDirectional Directional
        {
            get { return _directional ?? (_directional = new ScannerDirectional(GetMember("Directional"))); }
        }

        private ScannerSystem _system;
        /// <summary>
        /// Wraps the System member of the Scanners datatype.
        /// </summary>
        public ScannerSystem System
        {
            get { return _system ?? (_system = new ScannerSystem(GetMember("System"))); }
        }

        /// <summary>
        /// Wraps the Survey member of the Scanners datatype.
        /// </summary>
        /// <param name="moduleId">ID of the module to use for survey scanning.</param>
        /// <returns></returns>
        public ScannerSurvey Survey(Int64 moduleId)
        {
            return new ScannerSurvey(GetMember("Survey", moduleId.ToString()));
        }

        /// <summary>
        /// Wraps the Ship member of the Scanners datatype.
        /// </summary>
        /// <param name="moduleId">ID of the module to use for ship scanning.</param>
        /// <returns></returns>
        public ScannerShip Ship(Int64 moduleId)
        {
            return new ScannerShip(GetMember("Ship", moduleId.ToString()));
        }

        /// <summary>
        /// Wraps the Cargo member of the Scanners datatype.
        /// </summary>
        /// <param name="moduleId">ID of the module to use for ship scanning.</param>
        /// <returns></returns>
        public ScannerCargo Cargo(Int64 moduleId)
        {
            return new ScannerCargo(GetMember("Cargo", moduleId.ToString()));
        }
    }
}
