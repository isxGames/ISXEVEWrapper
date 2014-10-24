using System;
using System.Collections.Generic;
using System.Text;
using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Allows manipulation of Character Select screen.
	/// </summary>
	public class CharSelect : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// CharSelect copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public CharSelect(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Check with LavishScriptObject.IsNullOrInvalid.  If its not valid,
		/// you're not at the char select screen.
		/// </summary>
		public CharSelect()
			: base(LavishScript.Objects.GetObject("CharSelect"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// True if the given character exists on the charselect screen
		/// </summary>
		public bool CharExists(Int64 ID)
		{
			return this.GetBool("CharExists", ID.ToString());
		}

        public bool CharExists(string name)
        {
        	return this.GetBool("CharExists", name);
        }
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for ClickCharacter method of charselect type.
		/// </summary>
		/// <returns></returns>
		public bool ClickCharacter(string name)
		{
			Tracing.SendCallback("CharSelect.ClickCharacter", name);
			return ExecuteMethod("ClickCharacter", name);
		}

		/// <summary>
		/// Wrapper for ClickCharacter method of charselect type.
		/// </summary>
		/// <param name="CharID"></param>
		/// <returns></returns>
		public bool ClickCharacter(int CharID)
		{
			Tracing.SendCallback("CharSelect.ClickCharacter", CharID.ToString());
			return ExecuteMethod("ClickCharacter", CharID.ToString());
		}
		#endregion
	}
}
