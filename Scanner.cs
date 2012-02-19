using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class Scanner : LavishScriptObject
    {
        public Scanner(LavishScriptObject copy) : base(copy)
        {
            
        }

        public void StartDirectionalScan(float angle, int range)
        {
            Tracing.SendCallback("Scanner.StartDirectionalScan", angle, range);
            ExecuteMethod("StartDirectionalScan", angle.ToString(), range.ToString());
        }
    }
}
