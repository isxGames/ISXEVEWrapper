using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class ChatChannel : LavishScriptObject
    {
        public ChatChannel(LavishScriptObject copy) : base(copy)
        {
            
        }

        #region LavishScript Members
        public Int64 ID
        {
            get { return this.GetInt64("ID"); }
        }

        public string Name
        {
            get { return this.GetString("Name"); }
        }

        public int PilotCount
        {
            get { return this.GetInt("PilotCount"); }
        }

        public string MOTD
        {
            get { return this.GetString("MOTD"); }
        }

        public string Category
        {
            get { return this.GetString("Category"); }
        }

        public EVETime LastActivityTime
        {
            get { return new EVETime(GetMember("LastActivityTime")); }
        }
        #endregion

        #region LavishScript Methods

        public IList<Pilot> GetMembers()
        {
            return this.GetListFromMethod<Pilot>("GetMembers", "pilot");
        }

        public IList<ChatChannelMessage> GetMessages()
        {
            return this.GetListFromMethod<ChatChannelMessage>("GetMessages", "chatchannelmessage");
        }

        #endregion
    }
}
