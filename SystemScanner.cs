using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the SystemScanner datatype.
    /// </summary>
    public class SystemScanner : LavishScriptObject
    {
        public SystemScanner(LavishScriptObject Copy) : base(Copy)
        {
        }

        private bool? _isSensorOverlayActive;
        /// <summary>
        /// Wrapper for the IsSensorOverlayActive member of the SystemScanner datatype.
        /// </summary>
        public bool IsSensorOverlayActive
        {
            get
            {
                if (_isSensorOverlayActive == null)
                    _isSensorOverlayActive = this.GetBoolFromLSO("IsSensorOverlayActive");

                return _isSensorOverlayActive.Value;
            }
        }

        /// <summary>
        /// Wrapper for the EnableSensorOverlay method of the SystemScanner datatype.
        /// </summary>
        /// <returns></returns>
        public bool EnableSensorOverlay()
        {
            return ExecuteMethod("EnableSensorOverlay");
        }

        /// <summary>
        /// Wrapper for the DisableSensorOverlay method of the SystemScanner datatype.
        /// </summary>
        /// <returns></returns>
        public bool DisableSensorOverlay()
        {
            return ExecuteMethod("DisableSensorOverlay");
        }

        private List<SystemAnomaly> _systemAnomalies; 
        /// <summary>
        /// Wrapper for the GetAnomalies method of the SystemScanner datatype.
        /// </summary>
        /// <returns></returns>
        public List<SystemAnomaly> GetAnomalies()
        {
            return _systemAnomalies ?? (_systemAnomalies = this.GetListFromMethod<SystemAnomaly>("GetAnomalies", "systemanomaly"));
        }

        private List<SystemSignature> _systemSignatures;
        /// <summary>
        /// Wrapper for the GetSigantures method of the SystemScanner datatype.
        /// </summary>
        /// <returns></returns>
        public List<SystemSignature> GetSignatures()
        {
            return _systemSignatures ?? (_systemSignatures = this.GetListFromMethod<SystemSignature>("GetSignatures", "systemsignature"));
        }
    }
}
