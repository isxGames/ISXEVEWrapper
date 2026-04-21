using System.Collections.Generic;

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

        /// <summary>
        /// Wrapper for the GetPlanetIDs method of the solarsystem datatype. Populates and returns a list of planet item IDs in this solar system.
        /// </summary>
        /// <returns></returns>
        public List<int> GetPlanetIDs()
        {
            Tracing.SendCallback("SolarSystem.GetPlanetIDs");
            return Util.GetListFromMethod<int>(this, "GetPlanetIDs", "int");
        }

        /// <summary>
        /// Wrapper for the GetNumPlanetsByType method of the solarsystem datatype.
        /// </summary>
        /// <remarks>
        /// The underlying LavishScript method populates a collection:int in-place, keyed by planet-type-name (string) with int counts.
        /// The caller must pre-declare a variable of type "collection:int" and pass its name. Example:
        ///   <c>declare myPlanets collection:int</c> ...then... <c>${Universe[${Me.SolarSystemID}].GetNumPlanetsByType[myPlanets]}</c>
        /// The C# wrapper cannot return the collection directly because Util has no collection-to-dict helper.
        /// </remarks>
        /// <param name="collectionLsVarName">Name of a pre-declared LavishScript collection:int variable to populate.</param>
        /// <returns>True if the method succeeded.</returns>
        public bool GetNumPlanetsByType(string collectionLsVarName)
        {
            Tracing.SendCallback("SolarSystem.GetNumPlanetsByType", collectionLsVarName);
            return ExecuteMethod("GetNumPlanetsByType", collectionLsVarName);
        }
    }
}
