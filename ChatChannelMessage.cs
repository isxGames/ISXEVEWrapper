using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class ChatChannelMessage : LavishScriptObject
    {
        public ChatChannelMessage(LavishScriptObject copy) : base(copy)
        {
        }

        #region LavishScript Members

        public Pilot Author
        {
            get { return new Pilot(GetMember("Author")); }
        }

        public string Message
        {
            get { return this.GetString("Message"); }
        }

        public EVETime Timestamp
        {
            get { return new EVETime(GetMember("Timestamp")); }
        }
        #endregion
    }
}
