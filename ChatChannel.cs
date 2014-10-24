using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
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
            get { return this.GetInt64("ID"); }
        }

        public string Name
        {
            get { return this.GetString("Name"); }
        }

        public Int64 OwnerID
        {
            get { return this.GetInt64("OwnerID"); }
        }

        public int PilotCount
        {
            get { return this.GetInt("PilotCount"); }
        }

        public string MOTD
        {
            get { return this.GetString("MOTD"); }
        }
    }
}
