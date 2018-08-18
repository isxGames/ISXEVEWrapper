using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return ExecuteMethod("SelectByIndex", index.ToString());
        }

        /// <summary>
        /// Wraps the SelectByValue method of the EVEUISingleLineEdit datatype.
        /// </summary>
        /// <param name="value">set Value value</param>
        /// <returns></returns>
        public bool SelectByValue(string value)
        {
            Tracing.SendCallback("EVEUICombo.SelectByValue", value);
            return ExecuteMethod("SelectByValue", value.ToString());
        }

        /// <summary>
        /// Wraps the SelectByLabel method of the EVEUISingleLineEdit datatype.
        /// </summary>
        /// <param name="label">set Label value</param>
        /// <returns></returns>
        public bool SelectByLabel(string label)
        {
            Tracing.SendCallback("EVEUICombo.SelectByLabel", label);
            return ExecuteMethod("SelectByLabel", label.ToString());
        }


        #endregion



    }
}
