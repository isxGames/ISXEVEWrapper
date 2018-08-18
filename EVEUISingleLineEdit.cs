using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EVEUISingleLineEdit : LavishScriptObject
    {
        #region Constructors
		public EVEUISingleLineEdit(LavishScriptObject copy) : base(copy)
        {

        }
        #endregion


        #region Members
        ///// <summary>
        ///// Wrapper for the Value member of a EVEUILabel type.
        ///// </summary>
        //public string Value
        //{
        //    get { return this.GetString("Value"); }
        //}

        private string _Value;
        public string Value
        {
            get { return _Value ?? (_Value = this.GetString("Value")); }
        }


        #endregion

        #region Method
        /// <summary>
        /// Wraps the SetValue method of the EVEUISingleLineEdit datatype.
        /// </summary>
        /// <param name="value">set the value</param>
        /// <returns></returns>
        public bool SetValue(string value)
        {
            Tracing.SendCallback("EVEUISingleLineEdit.SetValue", value);
            return ExecuteMethod("SetValue", value.ToString());
        }

        #endregion



    }
}
