using System;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the extractorcontrolunit datatype.  Represents one Extractor Control Unit (ECU) pin of a
	/// colony, as returned by <see cref="Colony.GetExtractors"/>.
	/// </summary>
	public class ExtractorControlUnit : LavishScriptObject
	{
		/// <summary>
		/// ExtractorControlUnit copy constructor.
		/// </summary>
		/// <param name="copy"></param>
		public ExtractorControlUnit(LavishScriptObject copy) : base(copy)
		{
		}

		#region LS Members

		private long? _id;
		/// <summary>
		/// Wrapper for the ID member of the extractorcontrolunit datatype.  The pin's itemID.
		/// </summary>
		public long ID
		{
			get
			{
				if (_id == null)
					_id = this.GetInt64("ID");
				return _id.Value;
			}
		}

		private int? _typeID;
		/// <summary>
		/// Wrapper for the TypeID member of the extractorcontrolunit datatype.
		/// </summary>
		public int TypeID
		{
			get
			{
				if (_typeID == null)
					_typeID = this.GetInt("TypeID");
				return _typeID.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of the extractorcontrolunit datatype.  The generated ECU designator
		/// (e.g. "Barren Extractor Control Unit 5W-ASF").
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetString("Name")); }
		}

		private int? _programType;
		/// <summary>
		/// Wrapper for the ProgramType member of the extractorcontrolunit datatype.  The typeID of the raw
		/// resource this ECU is programmed to extract.
		/// </summary>
		public int ProgramType
		{
			get
			{
				if (_programType == null)
					_programType = this.GetInt("ProgramType");
				return _programType.Value;
			}
		}

		private int? _qtyPerCycle;
		/// <summary>
		/// Wrapper for the QtyPerCycle member of the extractorcontrolunit datatype.  Units produced per cycle.
		/// </summary>
		public int QtyPerCycle
		{
			get
			{
				if (_qtyPerCycle == null)
					_qtyPerCycle = this.GetInt("QtyPerCycle");
				return _qtyPerCycle.Value;
			}
		}

		private long? _cycleTime;
		/// <summary>
		/// Wrapper for the CycleTime member of the extractorcontrolunit datatype.  The extraction cycle length.
		/// </summary>
		public long CycleTime
		{
			get
			{
				if (_cycleTime == null)
					_cycleTime = this.GetInt64("CycleTime");
				return _cycleTime.Value;
			}
		}

		private long? _installTime;
		/// <summary>
		/// Wrapper for the InstallTime member of the extractorcontrolunit datatype.  The program install time
		/// as a Windows FILETIME-style timestamp.
		/// </summary>
		public long InstallTime
		{
			get
			{
				if (_installTime == null)
					_installTime = this.GetInt64("InstallTime");
				return _installTime.Value;
			}
		}

		private long? _expiryTime;
		/// <summary>
		/// Wrapper for the ExpiryTime member of the extractorcontrolunit datatype.  The program expiry time
		/// as a Windows FILETIME-style timestamp.
		/// </summary>
		public long ExpiryTime
		{
			get
			{
				if (_expiryTime == null)
					_expiryTime = this.GetInt64("ExpiryTime");
				return _expiryTime.Value;
			}
		}

		private long? _timeToExpiry;
		/// <summary>
		/// Wrapper for the TimeToExpiry member of the extractorcontrolunit datatype.  Nanoseconds remaining
		/// before the program expires (0 when expired).
		/// </summary>
		public long TimeToExpiry
		{
			get
			{
				if (_timeToExpiry == null)
					_timeToExpiry = this.GetInt64("TimeToExpiry");
				return _timeToExpiry.Value;
			}
		}

		private bool? _isActive;
		/// <summary>
		/// Wrapper for the IsActive member of the extractorcontrolunit datatype.
		/// </summary>
		public bool IsActive
		{
			get
			{
				if (_isActive == null)
					_isActive = this.GetBool("IsActive");
				return _isActive.Value;
			}
		}

		private bool? _isExpired;
		/// <summary>
		/// Wrapper for the IsExpired member of the extractorcontrolunit datatype.
		/// </summary>
		public bool IsExpired
		{
			get
			{
				if (_isExpired == null)
					_isExpired = this.GetBool("IsExpired");
				return _isExpired.Value;
			}
		}

		#endregion
	}
}
