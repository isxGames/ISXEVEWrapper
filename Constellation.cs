using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class Constellation : Interstellar
    {
        public Constellation(LavishScriptObject copy) : base(copy)
        {
        }

        private Region _region;
        public Region Region
        {
            get { return _region ?? (_region = new Region(GetMember("Region"))); }
        }
    }
}
