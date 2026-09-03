using System;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the pilaunchpad datatype.  Represents one valid launchpad/spaceport endpoint of a colony
	/// (the pins <see cref="EveCustomsOfficeWindow.SelectLaunchpad"/> accepts), as returned by
	/// <see cref="EveCustomsOfficeWindow.GetLaunchpads"/>.
	/// </summary>
	public class PILaunchpad : LavishScriptObject
	{
		/// <summary>
		/// PILaunchpad copy constructor.
		/// </summary>
		/// <param name="copy"></param>
		public PILaunchpad(LavishScriptObject copy) : base(copy)
		{
		}

		#region LS Members

		private long? _pinID;
		/// <summary>
		/// Wrapper for the PinID member of the pilaunchpad datatype.  Pass this to
		/// <see cref="EveCustomsOfficeWindow.SelectLaunchpad"/> to route transfers through this launchpad.
		/// </summary>
		public long PinID
		{
			get
			{
				if (_pinID == null)
					_pinID = this.GetInt64("PinID");
				return _pinID.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of the pilaunchpad datatype.  The launchpad's generated pin designator.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetString("Name")); }
		}

		private float? _capacity;
		/// <summary>
		/// Wrapper for the Capacity member of the pilaunchpad datatype.  The launchpad's total storage volume.
		/// </summary>
		public float Capacity
		{
			get
			{
				if (_capacity == null)
					_capacity = this.GetFloat("Capacity");
				return _capacity.Value;
			}
		}

		private float? _capacityUsed;
		/// <summary>
		/// Wrapper for the CapacityUsed member of the pilaunchpad datatype.  The volume currently in use.
		/// </summary>
		public float CapacityUsed
		{
			get
			{
				if (_capacityUsed == null)
					_capacityUsed = this.GetFloat("CapacityUsed");
				return _capacityUsed.Value;
			}
		}

		#endregion
	}
}
