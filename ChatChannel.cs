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

        public bool NewMessageReceived
        {
            get { return this.GetBool("NewMessageReceived"); }
        }

        public bool CanSpeak
        {
            get { return this.GetBool("CanSpeak"); }
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

        public bool MarkAsRead()
        {
            return ExecuteMethod("MarkAsRead");
        }

        /// <summary>
        /// 'Send' will broadcast any utf-8 string to the channel with the current player as the person speaking the text.  'Send' has a
        /// global throttle of one message ever 5 seconds, except for the "Local" channel in Jita; in that channel only one message every 40 
        /// seconds is allowed.   (These throttles only apply to using the "Send" method of the channel datatype.  You can
        /// still type messages and send them manually as often as you want.)   The throttles begin when ISXEVE is loaded.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Send(string text)
        {
            return ExecuteMethod("Send", text);
        }

        /// <summary>
        /// 'Echo' sends text to the local client's window, but NOT to other players in the channel.  In other words, it's a 
        /// "local echo only".  The second argument is optional but will set who the message is "from" -- if no second argument 
        /// is provided, it will be "from" the current player.  (Sidebar:  the charID# for "EVE System" is 1.)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Echo(string text)
        {
            return ExecuteMethod("Echo", text);
        }

        /// <summary>
        /// 'Echo' sends text to the local client's window, but NOT to other players in the channel.  In other words, it's a 
        /// "local echo only".  The second argument is optional but will set who the message is "from" -- if no second argument 
        /// is provided, it will be "from" the current player.  (Sidebar:  the charID# for "EVE System" is 1.)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="charId"></param>
        /// <returns></returns>
        public bool Echo(string text, Int64 charId)
        {
            return ExecuteMethod("Echo", text, charId.ToString());
        }

        #endregion
    }
}
