using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    public class FittingSlot : LavishScriptObject
    {
        public FittingSlot(LavishScriptObject copy) : base(copy)
        {

        }

        #region LS Members
        private string _name;

        public string Name
        {
            get { return _name ?? (_name = this.GetString("Name")); }
        }

        private int? _id;

        public int Id
        {
            get
            {
                if (_id == null)
                    _id = this.GetInt("ID");
                return _id.Value;
            }
        }

        private bool? _isOnline;

        public bool IsOnline
        {
            get
            {
                if (_isOnline == null)
                    _isOnline = this.GetBool("IsOnline");
                return _isOnline.Value;
            }
        }

        private bool? _containsCharge;

        public bool ContainsCharge
        {
            get
            {
                if (_containsCharge == null)
                    _containsCharge = this.GetBool("ContainsCharge");
                return _containsCharge.Value;
            }
        }

        private bool? _isEmpty;

        public bool IsEmpty
        {
            get
            {
                if (_isEmpty == null)
                    _isEmpty = this.GetBool("IsEmpty");
                return _isEmpty.Value;
            }
        }

        private Module _module;

        public Module Module
        {
            get { return _module ?? (_module = new Module(GetMember("Module"))); }
        }
        #endregion

        #region LS Methods
        public bool PutOnline()
        {
            return ExecuteMethod("PutOnline");
        }

        public bool PutOffline()
        {
            return ExecuteMethod("PutOffline");
        }

        public bool Unfit()
        {
            return ExecuteMethod("Unfit");
        }

        public bool UnfitCharge()
        {
            return ExecuteMethod("UnfitCharge");
        }

        public bool FitItem(Int64 itemId)
        {
            return ExecuteMethod("FitItem", itemId.ToString(CultureInfo.CurrentCulture));
        }
        #endregion
    }
}
