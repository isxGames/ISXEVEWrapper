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

        public bool CharExists(string name)
        {
            return GetMember<bool>("CharExists", name);
        }

		/// <summary>
		/// Returns the currently selected character from the charselect screen
		/// </summary>
		public string SelectedChar
		{
			get
			{
                var selectedChar = GetMember("SelectedChar");
			    return IsNullOrInvalid(selectedChar) ? null : selectedChar.GetValue<string>();
			}
		}

        /// <summary>
        /// Returns the CharID of the currently selected character
        /// </summary>
	    public int SelectedCharID
	    {
	        get
	        {
                var selectedCharID = GetMember("SelectedCharID");
	            return IsNullOrInvalid(selectedCharID) ? -1 : selectedCharID.GetValue<int>();
	        }
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
