using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class Wallet : LavishScriptObject
    {
        public Wallet(LavishScriptObject copy) : base(copy)
        {
            
        }

        public double Balance
        {
            get { return Util.GetDoubleFromLSO(GetMember("Balance")); }
        }

        public double BalanceAUR
        {
            get { return Util.GetDoubleFromLSO(GetMember("BalanceAUR")); }
        }
    }
}
