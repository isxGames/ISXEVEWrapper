using System.Globalization;

using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the universe TLO. The ISXEVE Universe TLO returns one of five interstellar-family
	/// types depending on the ID kind: region, constellation, solarsystem, planet, or the interstellar
	/// base type for other celestials. Callers who know the ID's category can downcast (for example,
	/// <c>(SolarSystem)Universe.ByID(systemID)</c>).
	/// </summary>
	public class Universe
	{
		#region Statics
		/// <summary>
		/// Can refer to any solarsystem, region, constellation, planet, or other celestial. The returned
		/// object is the interstellar base type; downcast to <see cref="SolarSystem"/>, <see cref="Region"/>,
		/// <see cref="Constellation"/>, or <see cref="Planet"/> based on the ID's known category.
		/// </summary>
        public static Interstellar ByName(string name)
		{
            return new Interstellar(LavishScript.Objects.GetObject("Universe", name));
		}

		/// <summary>
		/// Can refer to any solarsystem, region, constellation, planet, or other celestial. The returned
		/// object is the interstellar base type; downcast to <see cref="SolarSystem"/>, <see cref="Region"/>,
		/// <see cref="Constellation"/>, or <see cref="Planet"/> based on the ID's known category.
		/// </summary>
		public static Interstellar ByID(long ID)
		{
            return new Interstellar(LavishScript.Objects.GetObject("Universe", ID.ToString(CultureInfo.CurrentCulture)));
		}
		#endregion
	}
}
