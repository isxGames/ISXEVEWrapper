using EVE.ISXEVE.Extensions;
using LavishScriptAPI;


namespace EVE.ISXEVE
{
    public class EveRepairShopWindow : LavishScriptObject
    {
        public string AverageDamage
        {
            get { return this.GetString("AverageDamage"); }
        }

        public string TotalCost
        {
            get { return this.GetString("TotalCost"); }    
        }

        public EveRepairShopWindow(LavishScriptObject copy) : base(copy)
        {
        }

        public bool RepairAll()
        {
            return ExecuteMethod("RepairAll");
        }
    }
}
