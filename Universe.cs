using System.Globalization;

using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the universe data type.
	/// </summary>
	public class Universe
	{
		#region Statics
		/// <summary>
		/// can refer to any solarsystem, region, or constellation
		/// </summary>
        public static SolarSystem ByName(string name)
		{
            return new SolarSystem(LavishScript.Objects.GetObject("Universe", name));
		}

		/// <summary>
		/// can refer to any solarsystem, region, or constellation
		/// </summary>
		public static SolarSystem ByID(int ID)
		{
            return new SolarSystem(LavishScript.Objects.GetObject("Universe", ID.ToString(CultureInfo.CurrentCulture)));
		}
		#endregion
	}
}
