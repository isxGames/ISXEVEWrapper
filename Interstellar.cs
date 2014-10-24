using System;
using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// This Data Type includes all of the data and actions available to ISXEVE about Systems, Constellations, and Regions.
	/// </summary>
	public class Interstellar : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Interstellar object copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public Interstellar(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for ID member of interstellar type.
		/// </summary>
		public int ID
		{
			get { return this.GetInt("ID"); }
		}

		/// <summary>
		/// Wrapper for Name member of interstellar type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}
		#endregion
	}
}
