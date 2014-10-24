using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class SolarSystem : Interstellar
    {
        public SolarSystem(LavishScriptObject copy) : base(copy)
        {
        }

        private Region _region;
        public Region Region
        {
            get { return _region ?? (_region = new Region(GetMember("Region"))); }
        }

        private Constellation _constellation;
        public Constellation Constellation
        {
            get
            {
                return _constellation ?? (_constellation = new Constellation(GetMember("Constellation")));
            }
        }

        private float? _security;
        public float Security
        {
            get
            {
                if (_security == null)
                    _security = this.GetFloat("Security");
                return _security.Value;
            }
        }

        private int? _factionId;
        public int FactionID
        {
            get
            {
                if (_factionId == null)
                    _factionId = this.GetInt("FactionID");
                return _factionId.Value;
            }
        }

        private string _faction;
        public string Faction
        {
            get { return _faction ?? (_faction = this.GetString("Faction")); }
        }

        private int? _jumpsTo;

        public int JumpsTo
        {
            get
            {
                if (_jumpsTo == null)
                    _jumpsTo = this.GetInt("JumpsTo");
                return _jumpsTo.Value;
            }
        }

        public bool AddWaypoint()
        {
            Tracing.SendCallback("Interstellar.AddWaypoint");
            return ExecuteMethod("AddWaypoint");
        }

        public bool ClearWaypoint()
        {
            Tracing.SendCallback("Interstellar.ClearWaypoint");
            return ExecuteMethod("ClearWaypoint");
        }

        public bool SetDestination()
        {
            Tracing.SendCallback("Interstellar.SetDestination");
            return ExecuteMethod("SetDestination");
        }
    }
}
