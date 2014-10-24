using System;
using EVE.ISXEVE.Extensions;
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
            get { return this.GetInt64("ID"); }
        }

        public string Name
        {
            get { return this.GetString("Name"); }
        }

        public string Ticker
        {
            get { return this.GetString("Ticker"); }
        }

        public CorporationWallet Wallet
        {
            get { return new CorporationWallet(GetMember("Wallet")); }
        }
    }
}
