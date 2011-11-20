using System;
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
            get { return Util.GetInt64FromLSO(GetMember("ID")); }
        }

        public string Name
        {
            get { return Util.GetStringFromLSO(GetMember("Name")); }
        }

        public string Ticker
        {
            get { return Util.GetStringFromLSO(GetMember("Ticker")); }
        }

        public CorporationWallet Wallet
        {
            get { return new CorporationWallet(GetMember("Wallet")); }
        }
    }
}
