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

		private string _id;
		public string ID
		{
			get { return _id ?? (_id = this.GetStringFromLSO("ID")); }
		}

		private string _name;
		/// <summary>
		/// Name member
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
		}

		private EVETime _timeStarted;
		/// <summary>
		/// TimeStarted member
		/// </summary>
		public EVETime TimeStarted
		{
			get
			{
				return _timeStarted ?? (_timeStarted = new EVETime(GetMember("TimeStarted")));
			}
		}
		#endregion
	}
}
