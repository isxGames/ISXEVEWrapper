using System;
using System.Collections.Generic;
using System.Text;

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
		public bool CharExists(int ID)
		{
			return GetMember<bool>("CharExists", ID.ToString());
		}

		/// <summary>
		/// Returns the currently selected charid from the charselect screen
		/// </summary>
		public int SelectedChar()
		{
			return GetMember<int>("SelectedChar");
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for ClickCharacter method of charselect type.
		/// </summary>
		/// <returns></returns>
		public bool ClickCharacter()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("CharSelect.ClickCharacter", string.Empty);
			return ExecuteMethod("ClickCharacter");
		}

		/// <summary>
		/// Wrapper for ClickCharacter method of charselect type.
		/// </summary>
		/// <param name="CharID"></param>
		/// <returns></returns>
		public bool ClickCharacter(int CharID)
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("CharSelect.ClickCharacter", CharID.ToString());
			return ExecuteMethod("ClickCharacter", CharID.ToString());
		}
		#endregion
	}
}
