using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the dialogstring data type.
	/// </summary>
	public class DialogString : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// DialogString copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public DialogString(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public Int32 ID
		{
			get { return this.GetIntFromLSO("ID"); }
		}

		/// <summary>
		/// Wrapper for the Text member of a dialogstring type.
		/// </summary>
		public string Text
		{
			get { return this.GetStringFromLSO("Text"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the Say method of a dialogstring type.
		/// </summary>
		/// <param name="ToWhomID"></param>
		/// <returns></returns>
		public bool Say(int ToWhomID)
		{
			Tracing.SendCallback("DialogString.Say", ToWhomID.ToString());
			return ExecuteMethod("Say", ToWhomID.ToString());
		}
		#endregion

	}
}
