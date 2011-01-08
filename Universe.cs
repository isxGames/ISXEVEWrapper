using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
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
		public static Interstellar ByName(string name)
		{
			return new Interstellar(LavishScript.Objects.GetObject("Universe", name));
		}

		/// <summary>
		/// can refer to any solarsystem, region, or constellation
		/// </summary>
		public static Interstellar ByID(int ID)
		{
			return new Interstellar(LavishScript.Objects.GetObject("Universe", ID.ToString()));
		}
		#endregion
	}
}
