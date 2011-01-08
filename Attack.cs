using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
		public Int64 ID
		{
			get
			{
				LavishScriptObject id = GetMember("ID");
				if (LavishScriptObject.IsNullOrInvalid(id))
				{
					return -1;
				}
				else
				{
					return id.GetValue<Int64>();
				}
			}
		}

		/// <summary>
		/// Name member
		/// </summary>
		public string Name
		{
			get
			{
				LavishScriptObject name = GetMember("Name");
				if (LavishScriptObject.IsNullOrInvalid(name))
				{
					return string.Empty;
				}
				return name.GetValue<string>();
			}
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

		/// <summary>
		/// Jammer member
		/// </summary>
		public Jammer Jammer
		{
			get
			{
				return new Jammer(GetMember("Jammer"));
			}
		}
		#endregion
	}
}
