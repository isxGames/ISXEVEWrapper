using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EveFittingWindow : EVEWindow
    {
        public EveFittingWindow(LavishScriptObject obj) : base(obj)
        {
        }

        #region LavishScript Members

        private string _cpu;

        public string Cpu
        {
            get { return _cpu ?? (_cpu = this.GetString("CPU")); }
        }

        private string _power;

        public string Power
        {
            get { return _power ?? (_power = this.GetString("Power")); }
        }

        private string _calibration;

        public string Calibration
        {
            get { return _calibration ?? (_calibration = this.GetString("Calibration")); }
        }

        private bool? _isShipSimulated;

        /// <summary>
        /// True if the ship currently displayed in the fitting window is a simulation (not the active ship).
        /// </summary>
        public bool IsShipSimulated
        {
            get
            {
                if (_isShipSimulated == null)
                    _isShipSimulated = this.GetBool("IsShipSimulated");
                return _isShipSimulated.Value;
            }
        }

        /// <summary>
        /// Wraps the Slot member of the EveFittingWindow datatype.  Returns a FittingSlot for the given
        /// slot location-flag ID (e.g. one of the EVEConstant flag IDs for lo/hi/rig/subsystem slots).
        /// </summary>
        /// <param name="locationFlagID"></param>
        /// <returns></returns>
        public FittingSlot Slot(int locationFlagID)
        {
            return new FittingSlot(GetMember("Slot", locationFlagID.ToString(CultureInfo.CurrentCulture)));
        }

        /// <summary>
        /// Wraps the Slot member of the EveFittingWindow datatype.  Returns a FittingSlot for the given
        /// slot location-flag name (resolved server-side via GetLocationFlagID).
        /// </summary>
        /// <param name="locationFlagName"></param>
        /// <returns></returns>
        public FittingSlot Slot(string locationFlagName)
        {
            return new FittingSlot(GetMember("Slot", locationFlagName));
        }

        #endregion

        #region LavishScript Methods

        public List<FittingSlot> GetSlots()
        {
            return this.GetListFromMethod<FittingSlot>("GetSlots", "fittingslot");
        }

        /// <summary>
        /// Wraps the StripFitting method of the EveFittingWindow datatype.  Removes all modules from the
        /// fitting displayed in the window.
        /// </summary>
        /// <returns></returns>
        public bool StripFitting()
        {
            return ExecuteMethod("StripFitting");
        }

        #endregion
    }
}
