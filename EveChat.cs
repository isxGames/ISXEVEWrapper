using System.Collections.Generic;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EveChat : LavishScriptObject
    {
        public EveChat(LavishScriptObject copy) : base(copy)
        {
        }

        #region LavishScript Members

        public int ChannelCount
        {
            get { return this.GetInt("ChannelCount"); }
        }

        #endregion

        #region LavishScript Methods

        public IList<ChatChannel> GetChannels()
        {
            return this.GetListFromMethod<ChatChannel>("GetChannels", "chatchannel");
        }

        #endregion
    }
}
