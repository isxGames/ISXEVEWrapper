using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LavishScriptAPI;
using Extensions;

namespace EVE.ISXEVE
{
	public class EveInvChildWindow : LavishScriptObject
	{
		public EveInvChildWindow(LavishScriptObject copy)
			: base(copy)
		{
			
		}

		#region Members

		private double? _capacity;
		/// <summary>
		/// Wrapper for the Capacity member of eveinvchildwindow
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

		private double? _usedCapacity;
		/// <summary>
		/// Wrapper for the UsedCapacity member of eveinvchildwindow
		/// </summary>
		public double UsedCapacity
		{
			get
			{
				if (_usedCapacity == null)
					_usedCapacity = this.GetDoubleFromLSO("UsedCapacity");

				return _usedCapacity.Value;
			}
		}

		private string _locationFlag;
		/// <summary>
		/// Wrapper for the LocationFlag member of eveinvchildwindow
		/// </summary>
		public string LocationFlag
		{
			get { return _locationFlag ?? (_locationFlag = this.GetStringFromLSO("LocationFlag")); }
		}

		private int? _locationFlagId;
		/// <summary>
		/// Wrapper for the LocationFlagID member of eveinvchildwindow
		/// </summary>
		public int LocationFlagId
		{
			get
			{
				if (_locationFlagId == null)
					_locationFlagId = this.GetIntFromLSO("LocationFlagID");

				return _locationFlagId.Value;
			}
		}

		private bool? _isInRange;
		/// <summary>
		/// Wrapper for the IsInRange member of eveinvchildwindow
		/// </summary>
		public bool IsInRange
		{
			get
			{
				if (_isInRange == null)
					_isInRange = this.GetBoolFromLSO("IsInRange");

				return _isInRange.Value;
			}
		}

		private Int64? _itemId;
		/// <summary>
		/// Wrapper for the ItemID member of eveinvchildwindow
		/// </summary>
		public Int64 ItemId
		{
			get
			{
				if (_itemId == null)
					_itemId = this.GetInt64FromLSO("ItemID");

				return _itemId.Value;
			}
		}

		private bool? _hasCapacity;
		/// <summary>
		/// Wrapper for the HasCapacity member of eveinvchildwindow
		/// </summary>
		public bool HasCapacity
		{
			get
			{
				if (_hasCapacity == null)
					_hasCapacity = this.GetBoolFromLSO("HasCapacity");

				return _hasCapacity.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of eveinvchildwindow
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
		}
		#endregion

		#region Methods

		/// <summary>
		/// Wrapper for the MakeActive method of eveinvchildwindow
		/// </summary>
		/// <returns></returns>
		public bool MakeActive()
		{
			return ExecuteMethod("MakeActive");
		}

		/// <summary>
		/// Wrapper for the OpenAsNewWindow method of eveinvchildwindow
		/// </summary>
		/// <returns></returns>
		public bool OpenAsNewWindow()
		{
			return ExecuteMethod("OpenAsNewWindow");
		}

		#endregion
	}
}
