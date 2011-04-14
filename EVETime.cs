using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the evetime data type.
	/// </summary>
	public class EVETime : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// EVETime copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public EVETime(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// EVETime constructor.
		/// </summary>
		public EVETime()
			: base(LavishScript.Objects.GetObject("EVETime"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the DateAndTime member of a evetime type.
		/// </summary>
		public string DateAndTime
		{
			get
			{
				return GetMember<string>("DateAndTime");
			}
		}

		/// <summary>
		/// Wrapper for the Date member of a evetime type.
		/// </summary>
		public string Date
		{
			get
			{
				return GetMember<string>("Date");
			}
		}

		/// <summary>
		/// Wrapper for the Time member of a evetime type.
		/// </summary>
		public string Time
		{
			get
			{
				return GetMember<string>("Time");
			}
		}

		/// <summary>
		/// Wrapper for the AsInt64 member of a evetime type.
		/// </summary>
		public Int64 AsInt64
		{
			get
			{
				Tracing.SendCallback("EVETime.AsInt64");
				return GetMember<Int64>("AsInt64");
			}
		}
		#endregion

		#region Methods

		#endregion

	}
}
