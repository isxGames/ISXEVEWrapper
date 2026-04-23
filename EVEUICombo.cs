using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EVEUICombo : LavishScriptObject
    {
        #region Constructors
        public EVEUICombo(LavishScriptObject copy) : base(copy)
        {

        }
        #endregion


        #region Members

        private string _Index;
        public string Index
        {
            get { return _Index ?? (_Index = this.GetString("Index")); }
        }

        private string _Key;
        public string Key
        {
            get { return _Key ?? (_Key = this.GetString("Key")); }
        }

        private string _Value;
        public string Value
        {
            get { return _Value ?? (_Value = this.GetString("Value")); }
        }
        #endregion

        #region Method
        /// <summary>
        /// Wraps the SelectByIndex method of the EVEUISingleLineEdit datatype.
        /// </summary>
        /// <param name="index">set index value</param>
        /// <returns></returns>
        public bool SelectByIndex(string index)
        {
            Tracing.SendCallback("EVEUICombo.SelectByIndex", index);
            return ExecuteMethod("SelectByIndex", index.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Wraps the SelectByValue method of the EVEUICombo datatype.
        /// </summary>
        /// <remarks>
        /// The registered LavishScript method name is actually <c>SetectByValue</c> (typo in
        /// <c>DataTypes.h:2555,2566</c> and <c>DT-EVEUIElements.cpp:287</c>) — documented
        /// correctly as <c>SelectByValue</c> in <c>ISXEVEChanges.txt:437</c>, but registered
        /// with the typo via the <c>TypeMethod(SetectByValue)</c> macro.  This wrapper
        /// dispatches the typo'd name to match the actual registered method and restore
        /// functionality.  If the source is ever fixed to rename to <c>SelectByValue</c>, this
        /// string must be updated.
        /// </remarks>
        /// <param name="value">set Value value</param>
        /// <returns></returns>
        public bool SelectByValue(string value)
        {
            Tracing.SendCallback("EVEUICombo.SelectByValue", value);
            return ExecuteMethod("SetectByValue", value.ToString(CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Wraps the SelectByLabel method of the EVEUISingleLineEdit datatype.
        /// </summary>
        /// <param name="label">set Label value</param>
        /// <returns></returns>
        public bool SelectByLabel(string label)
        {
            Tracing.SendCallback("EVEUICombo.SelectByLabel", label);
            return ExecuteMethod("SelectByLabel", label.ToString(CultureInfo.CurrentCulture));
        }


        #endregion



    }
}
