using System;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the ScannerDirectionalResult datatype.
    /// </summary>
    public class ScannerDirectionalResult : LavishScriptObject
    {
        public ScannerDirectionalResult(LavishScriptObject Copy) : base(Copy)
        {
        }

        private Int64? _id;
        /// <summary>
        /// Wrapper for the ID member of the ScannerDirectionalResult datatype.
        /// </summary>
        public Int64 ID
        {
            get
            {
                if (_id == null)
                    _id = this.GetInt64FromLSO("ID");

                return _id.Value;
            }
        }

        private string _name;
        /// <summary>
        /// Wrapper for the Name member of the ScannerDirectionalResult datatype.
        /// </summary>
        public string Name
        {
            get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
        }

        private int? _groupId;
        /// <summary>
        /// Wrapper for the GroupID member of the ScannerDirectionalResult datatype.
        /// </summary>
        public int GroupID
        {
            get
            {
                if (_groupId == null)
                    _groupId = this.GetIntFromLSO("GroupID");

                return _groupId.Value;
            }
        }

        private int? _typeId;
        /// <summary>
        /// Wrapper for the TypeID member of the ScannerDirectionalResult datatype.
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

        private Entity _toEntity;
        /// <summary>
        /// Wrapper for the ToEntity member of the ScannerDirectionalResult datatype.
        /// </summary>
        public Entity ToEntity
        {
            get { return _toEntity ?? (_toEntity = new Entity(GetMember("ToEntity"))); }
        }
    }
}
