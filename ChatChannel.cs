using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            get { return Util.GetInt64FromLSO(GetMember("ID")); }
        }

        public string Name
        {
            get { return Util.GetStringFromLSO(GetMember("Name")); }
        }

        public Int64 OwnerID
        {
            get { return Util.GetInt64FromLSO(GetMember("OwnerID")); }
        }

        public int PilotCount
        {
            get { return Util.GetIntFromLSO(GetMember("PilotCount")); }
        }

        public string MOTD
        {
            get { return Util.GetStringFromLSO(GetMember("MOTD")); }
        }
    }
}
