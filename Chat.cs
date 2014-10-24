using System;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public static class Chat
    {
        public static EveChat GetChat()
        {
            return new EveChat(LavishScript.Objects.GetObject("Chat"));
        }

        public static ChatChannel GetChat(string channelName)
        {
            return new ChatChannel(LavishScript.Objects.GetObject("Chat", channelName));
        }

        public static ChatChannel GetChat(Int64 channelId)
        {
            return new ChatChannel(LavishScript.Objects.GetObject("Chat", channelId.ToString()));
        }
    }
}
