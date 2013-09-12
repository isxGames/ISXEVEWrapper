using System;
using EVE.ISXEVE.Interfaces;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the iteminfolist datatype.
    /// </summary>
    public class ItemInfoList : ItemInfo, IItemInfoList
    {
        public ItemInfoList(LavishScriptObject Copy) : base(Copy)
        {
        }

        private int? _id;
        /// <summary>
        /// Wrapper for the ID member of the ItemInfoList datatype.
        /// </summary>
        public int ID
        {
            get
            {
                if (_id == null)
                    _id = this.GetIntFromLSO("ID");

                return _id.Value;
            }
        }

        private int? _typeId;
        /// <summary>
        /// Wrapper for the TypeID member of the ItemInfoList datatype.
        /// </summary>
        public int TypeID
        {
            get
            {
                if (_typeId == null)
                    _typeId = this.GetIntFromLSO("TypeID");

                return _typeId.Value;
            }
        }

        private Int64? _quantity;
        /// <summary>
        /// Wrapper for the Quantity member of the ItemInfoList datatype.
        /// </summary>
        public Int64 Quantity
        {
            get
            {
                if (_quantity == null)
                    _quantity = this.GetInt64FromLSO("Quantity");

                return _quantity.Value;
            }
        }
    }
}
