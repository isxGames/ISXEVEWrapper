using System;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the being data type.
	/// </summary>
	public class Being : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Being data type copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public Being(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members

		private int? _id;
		public Int32 ID
		{
			get
			{
				if (_id == null)
					_id = this.GetIntFromLSO("ID");
				return _id.Value;
			}
		}

		private Int64? _charId;
		/// <summary>
		/// Returns the CharID member of a being object.
		/// </summary>
		public Int64 CharID
		{
			get
			{
				if (_charId == null)
					_charId = this.GetInt64FromLSO("CharID");
				return _charId.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Returns the Name member of a being object.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
		}

		private bool? _isOnline;
		/// <summary>
		/// Returns the IsOnline member of a being object.
		/// </summary>
		public bool IsOnline
		{
			get
			{
				if (_isOnline == null)
					_isOnline = this.GetBoolFromLSO("IsOnline");
				return _isOnline.Value;
			}
		}

		private bool? _isNpc;
		/// <summary>
		/// Returns the IsNPC member of a being object.
		/// </summary>
		public bool IsNPC
		{
			get
			{
				if (_isNpc == null)
					_isNpc = this.GetBoolFromLSO("IsNPC");
				return _isNpc.Value;
			}
		}

		private bool? _isPc;
		/// <summary>
		/// Returns the IsPC member of a being object.
		/// </summary>
		public bool IsPC
		{
			get
			{
				if (_isPc == null)
					_isPc = this.GetBoolFromLSO("IsPC");
				return _isPc.Value;
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Invite a beign to your fleet.
		/// </summary>
		/// <returns></returns>
		public bool InviteToFleet()
		{
			Tracing.SendCallback("Being.InviteToFleet");
			return ExecuteMethod("InviteToFleet");
		}
		#endregion
	}
}
