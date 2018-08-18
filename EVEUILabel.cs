using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class EVEUILabel : LavishScriptObject
    {
        #region Constructors
        public EVEUILabel(LavishScriptObject copy) : base(copy)
        {

        }
        #endregion


        #region Members


        private string _Text;
        public string Text
        {
            get { return _Text ?? (_Text = this.GetString("Text")); }
        }


        #endregion


    }
}
