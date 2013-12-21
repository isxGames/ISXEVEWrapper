using System;
using EVE.ISXEVE.Interfaces;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the ItemInfo datatype.
    /// </summary>
    public class ItemInfo : LavishScriptObject, IItemInfo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Copy"></param>
        public ItemInfo(LavishScriptObject Copy) : base(Copy)
        {
        }

        private Int64? _id;
        /// <summary>
        /// Wrapper for the ID member of the ItemInfo datatype.
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

        private string _type;
        /// <summary>
        /// Wrapper for the Type member of the ItemInfo datatype.
        /// </summary>
        public string Type
        {
            get { return _type ?? (_type = this.GetStringFromLSO("Type")); }
        }

        private int? _typeId;
        /// <summary>
        /// Wrapper for the TypeID member of the ItemInfo datatype.
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

        private string _group;
        /// <summary>
        /// Wrapper for the Group member of the ItemInfo datatype.
        /// </summary>
        public string Group
        {
            get { return _group ?? (_group = this.GetStringFromLSO("Group")); }
        }

        private int? _groupId;
        /// <summary>
        /// Wrapper for the GroupID member of the ItemInfo datatype.
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

        private string _category;
        /// <summary>
        /// Wrapper for the Category member of the ItemInfo datatype.
        /// </summary>
        public string Category
        {
            get { return _category ?? (_category = this.GetStringFromLSO("Category")); }
        }

        private int? _categoryId;
        /// <summary>
        /// Wrapper for the CategoryID member of the ItemInfo datatype.
        /// </summary>
        public int CategoryID
        {
            get
            {
                if (_categoryId == null)
                    _categoryId = this.GetIntFromLSO("CategoryID");

                return _categoryId.Value;
            }
        }

        private bool? _isContraband;
        /// <summary>
        /// Wrapper for the IsContraband member of the ItemInfo datatype.
        /// </summary>
        public bool IsContraband
        {
            get
            {
                if (_isContraband == null)
                    _isContraband = this.GetBoolFromLSO("IsContraband");

                return _isContraband.Value;
            }
        }

        private int? _graphicId;
        /// <summary>
        /// Wrapper for the GraphicID member of the ItemInfo datatype.
        /// </summary>
        public int GraphicID
        {
            get
            {
                if (_graphicId == null)
                    _graphicId = this.GetIntFromLSO("GraphicID");

                return _graphicId.Value;
            }
        }

        private double? _capacity;
        /// <summary>
        /// Wrapper for the Capacity member of the ItemInfo datatype.
        /// </summary>
        public double Capacity
        {
            get
            {
                if (_capacity == null)
                    _capacity = this.GetDoubleFromLSO("Capacity");

                return _capacity.Value;
            }
        }

        private double? _radius;
        /// <summary>
        /// Wrapper for the Radius member of the ItemInfo datatype.
        /// </summary>
        public double Radius
        {
            get
            {
                if (_radius == null)
                    _radius = this.GetDoubleFromLSO("Radius");

                return _radius.Value;
            }
        }

        private int? _raceId;
        /// <summary>
        /// Wrapper for the RaceID member of the ItemInfo datatype.
        /// </summary>
        public int RaceID
        {
            get
            {
                if (_raceId == null)
                    _raceId = this.GetIntFromLSO("RaceID");

                return _raceId.Value;
            }
        }

        private double? _volume;
        /// <summary>
        /// Wrapper for the Volume member of the ItemInfo datatype.
        /// </summary>
        public double Volume
        {
            get
            {
                if (_volume == null)
                    _volume = this.GetDoubleFromLSO("Volume");

                return _volume.Value;
            }
        }

        private double? _basePrice;
        /// <summary>
        /// Wrapper for the BasePrice member of the ItemInfo datatype.
        /// </summary>
        public double BasePrice
        {
            get
            {
                if (_basePrice == null)
                    _basePrice = this.GetDoubleFromLSO("BasePrice");

                return _basePrice.Value;
            }
        }

        private int? _portionSize;
        /// <summary>
        /// Wrapper for the PortionSize member of the ItemInfo datatype.
        /// </summary>
        public int PortionSize
        {
            get
            {
                if (_portionSize == null)
                    _portionSize = this.GetIntFromLSO("PortionSize");

                return _portionSize.Value;
            }
        }

        private int? _marketGroupId;
        /// <summary>
        /// Wrapper for the MarketGroupID member of the ItemInfo datatype.
        /// </summary>
        public int MarketGroupID
        {
            get
            {
                if (_marketGroupId == null)
                    _marketGroupId = this.GetIntFromLSO("MarketGroupID");

                return _marketGroupId.Value;
            }
        }

        private string _description;
        /// <summary>
        /// Wrapper for the Description member of the ItemInfo datatype.
        /// </summary>
        public string Description
        {
            get { return _description ?? (_description = this.GetStringFromLSO("Description")); }
        }

        private int? _chargeSize;
        /// <summary>
        /// Wrapper for the ChargeSize member of the ItemInfo datatype.
        /// </summary>
        public int ChargeSize
        {
            get
            {
                if (_chargeSize == null)
                    _chargeSize = this.GetIntFromLSO("ChargeSize");

                return _chargeSize.Value;
            }
        }

        private float? _rangeBonus;
        /// <summary>
        /// Wrapper for the RangeBonus member of the ItemInfo datatype.
        /// </summary>
        public float RangeBonus
        {
            get
            {
                if (_rangeBonus == null)
                    _rangeBonus = this.GetFloatFromLSO("RangeBonus");

                return _rangeBonus.Value;
            }
        }

        private int? _shieldRadius;
        /// <summary>
        /// Wrapper for the ShieldRadius member of the ItemInfo datatype.
        /// </summary>
        public int ShieldRadius
        {
            get
            {
                if (_shieldRadius == null)
                    _shieldRadius = this.GetIntFromLSO("ShieldRadius");

                return _shieldRadius.Value;
            }
        }
    }
}