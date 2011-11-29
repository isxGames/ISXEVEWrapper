using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using LavishScriptAPI;
using InnerSpaceAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Attack class
	/// </summary>
	public class Attack : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Attack copy constructor
		/// </summary>
		/// <param name="copy"></param>
		public Attack(LavishScriptObject copy)
			: base(copy)
		{

		}
		#endregion

		#region Members
		public string ID
		{
			get { return this.GetStringFromLSO("ID"); }
		}

		/// <summary>
		/// Name member
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

		/// <summary>
		/// TimeStarted member
		/// </summary>
		public EVETime TimeStarted
		{
			get
			{
				return new EVETime(GetMember("TimeStarted"));
			}
		}
		#endregion
	}
}
