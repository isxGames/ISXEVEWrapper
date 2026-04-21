using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the planet datatype. Inherits the interstellar datatype (ID, Name).
    /// Returned by the Universe TLO when the supplied ID refers to a planet.
    /// </summary>
    public class Planet : Interstellar
    {
        public Planet(LavishScriptObject copy) : base(copy)
        {
        }

        private int? _radius;
        /// <summary>
        /// Wrapper for the Radius member of the planet datatype.
        /// </summary>
        public int Radius
        {
            get
            {
                if (_radius == null)
                    _radius = this.GetInt("Radius");
                return _radius.Value;
            }
        }

        private int? _typeId;
        /// <summary>
        /// Wrapper for the TypeID member of the planet datatype.
        /// </summary>
        public int TypeID
        {
            get
            {
                if (_typeId == null)
                    _typeId = this.GetInt("TypeID");
                return _typeId.Value;
            }
        }

        private string _type;
        /// <summary>
        /// Wrapper for the Type member of the planet datatype. Returns the planet-type name (e.g. "Temperate", "Gas").
        /// </summary>
        public string Type
        {
            get { return _type ?? (_type = this.GetString("Type")); }
        }

        private SolarSystem _solarSystem;
        /// <summary>
        /// Wrapper for the SolarSystem member of the planet datatype.
        /// </summary>
        public SolarSystem SolarSystem
        {
            get { return _solarSystem ?? (_solarSystem = new SolarSystem(GetMember("SolarSystem"))); }
        }

        /// <summary>
        /// Wrapper for the GetOrbitalCustomsOffices method of the planet datatype. Populates a caller-supplied index:int64 with the entity IDs of the planet's orbital customs offices.
        /// </summary>
        /// <remarks>
        /// Only works in space. The underlying LavishScript method populates an index:int64 in-place.
        /// The caller must pre-declare a variable of type "index:int64" and pass its name. Example:
        ///   <c>declare myCustomsOffices index:int64</c> ...then... <c>${Universe[${planetID}].GetOrbitalCustomsOffices[myCustomsOffices]}</c>
        /// The C# wrapper cannot return the list directly because there is no existing Util helper precedent for int64 list marshalling.
        /// </remarks>
        /// <param name="indexLsVarName">Name of a pre-declared LavishScript index:int64 variable to populate.</param>
        /// <returns>True if the method succeeded.</returns>
        public bool GetOrbitalCustomsOffices(string indexLsVarName)
        {
            Tracing.SendCallback("Planet.GetOrbitalCustomsOffices", indexLsVarName);
            return ExecuteMethod("GetOrbitalCustomsOffices", indexLsVarName);
        }
    }
}
