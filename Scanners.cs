using System;
using System.Globalization;

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

        private DirectionalScanner _directional;
        /// <summary>
        /// Wraps the Directional member of the Scanners datatype.
        /// </summary>
        public DirectionalScanner Directional
        {
            get { return _directional ?? (_directional = new DirectionalScanner(GetMember("Directional"))); }
        }

        private SystemScanner _system;
        /// <summary>
        /// Wraps the System member of the Scanners datatype.
        /// </summary>
        public SystemScanner System
        {
            get { return _system ?? (_system = new SystemScanner(GetMember("System"))); }
        }

        /// <summary>
        /// Wraps the Survey member of the Scanners datatype.
        /// </summary>
        /// <param name="moduleId">ID of the module to use for survey scanning.</param>
        /// <returns></returns>
        public SurveyScanner Survey(Int64 moduleId)
        {
            return new SurveyScanner(GetMember("Survey", moduleId.ToString(CultureInfo.CurrentCulture)));
        }

        /// <summary>
        /// Wraps the Ship member of the Scanners datatype.
        /// </summary>
        /// <param name="moduleId">ID of the module to use for ship scanning.</param>
        /// <returns></returns>
        public ShipScanner Ship(Int64 moduleId)
        {
            return new ShipScanner(GetMember("Ship", moduleId.ToString(CultureInfo.CurrentCulture)));
        }

        /// <summary>
        /// Wraps the Cargo member of the Scanners datatype.
        /// </summary>
        /// <param name="moduleId">ID of the module to use for ship scanning.</param>
        /// <returns></returns>
        public CargoScanner Cargo(Int64 moduleId)
        {
            return new CargoScanner(GetMember("Cargo", moduleId.ToString(CultureInfo.CurrentCulture)));
        }
    }
}
