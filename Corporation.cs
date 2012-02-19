using System;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class Corporation : LavishScriptObject
    {
        public Corporation(LavishScriptObject copy) : base(copy)
        {
            
        }

        public Int64 ID
        {
            get { return this.GetInt64FromLSO("ID"); }
        }

        public string Name
        {
            get { return this.GetStringFromLSO("Name"); }
        }

        public string Ticker
        {
            get { return this.GetStringFromLSO("Ticker"); }
        }

        public CorporationWallet Wallet
        {
            get { return new CorporationWallet(GetMember("Wallet")); }
        }
    }
}
