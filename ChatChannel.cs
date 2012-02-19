using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class ChatChannel : LavishScriptObject
    {
        public ChatChannel(LavishScriptObject copy) : base(copy)
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

        public Int64 OwnerID
        {
            get { return this.GetInt64FromLSO("OwnerID"); }
        }

        public int PilotCount
        {
            get { return this.GetIntFromLSO("PilotCount"); }
        }

        public string MOTD
        {
            get { return this.GetStringFromLSO("MOTD"); }
        }
    }
}
