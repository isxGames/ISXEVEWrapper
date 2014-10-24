using System;
using System.Collections.Generic;
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

        #endregion

        #region LavishScript Methods

        public List<FittingSlot> GetSlots()
        {
            return this.GetListFromMethod<FittingSlot>("GetSlots", "fittingslot");
        }

        #endregion
    }
}
