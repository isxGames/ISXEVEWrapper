using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
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
            get { return this.GetDouble("Balance"); }
        }

        public double BalanceAUR
        {
            get { return this.GetDouble("BalanceAUR"); }
        }
    }
}
