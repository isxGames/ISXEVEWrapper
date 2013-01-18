using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	public class ModuleCharge : LavishScriptObject
	{
		public ModuleCharge(LavishScriptObject copy) : base(copy)
		{
			
		}

		private Int64? _id;
		/// <summary>
		/// The ID of the ModuleCharge.
		/// </summary>
		public Int64 Id
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
		/// The type of the ModuleCharge.
		/// </summary>
		public string Type
		{
			get { return _type ?? (_type = this.GetStringFromLSO("Type")); }
		}

		private int? _typeId;
		/// <summary>
		/// The type Id of the ModuleCharge.
		/// </summary>
		public int TypeId
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
		/// The group of the ModuleCharge.
		/// </summary>
		public string Group
		{
			get { return _group ?? (_group = this.GetStringFromLSO("Group")); }
		}

		private int? _groupId;
		/// <summary>
		/// The group ID of the ModuleCharge.
		/// </summary>
		public int GroupId
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
		/// The category of the ModuleCharge.
		/// </summary>
		public string Category
		{
			get { return _category ?? (_category = this.GetStringFromLSO("Categroy")); }
		}

		private int? _categoryId;
		/// <summary>
		/// The category ID of the ModuleCharge.
		/// </summary>
		public int CategoryId
		{
			get
			{
				if (_categoryId == null)
					_categoryId = this.GetIntFromLSO("CategoryID");

				return _categoryId.Value;
			}
		}

		private string _location;
		/// <summary>
		/// The location of the ModuleCharge.
		/// </summary>
		public string Location
		{
			get { return _location ?? (_location = this.GetStringFromLSO("Location")); }
		}

		private Int64? _locationId;
		/// <summary>
		/// The location ID of the ModuleCharge.
		/// </summary>
		public Int64 LocationId
		{
			get
			{
				if (_locationId == null)
					_locationId = this.GetInt64FromLSO("LocationID");

				return _locationId.Value;
			}
		}

		private string _slot;
		/// <summary>
		/// The slot of the ModuleCharge.
		/// </summary>
		public string Slot
		{
			get { return _slot ?? (_slot = this.GetStringFromLSO("Slot")); }
		}

		private int? _slotId;
		/// <summary>
		/// The slot ID of the ModuleCharge.
		/// </summary>
		public int SlotId
		{
			get
			{
				if (_slotId == null)
					_slotId = this.GetIntFromLSO("SlotID");

				return _slotId.Value;
			}
		}

		private int? _quantity;
		/// <summary>
		/// The quantity of the ModuleCharge.
		/// </summary>
		public int Quantity
		{
			get
			{
				if (_quantity == null)
					_quantity = this.GetIntFromLSO("Quantity");

				return _quantity.Value;
			}
		}

		private double? _maxFlightTime;
		/// <summary>
		/// The max flight time of the ModuleCharge.
		/// </summary>
		public double MaxFlightTime
		{
			get
			{
				if (_maxFlightTime == null)
					_maxFlightTime = this.GetDoubleFromLSO("MaxFlightTime");

				return _maxFlightTime.Value;
			}
		}

		private double? _maxVelocity;
		/// <summary>
		/// The max velocity of the ModuleCharge.
		/// </summary>
		public double MaxVelocity
		{
			get
			{
				if (_maxVelocity == null)
					_maxVelocity = this.GetDoubleFromLSO("MaxVelocity");

				return _maxVelocity.Value;
			}
		}

		private int? _chargeSize;
		/// <summary>
		/// The charge size of the ModuleCharge.
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

		private double? _volume;
		/// <summary>
		/// The volume of the ModuleCharge.
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
	}
}
