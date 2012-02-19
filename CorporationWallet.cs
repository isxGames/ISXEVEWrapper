using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class CorporationWallet : LavishScriptObject
    {
        public CorporationWallet(LavishScriptObject copy) : base(copy)
        {
        }

        public double Balance
        {
            get { return this.GetDoubleFromLSO("Balance"); }
        }
    }
}
