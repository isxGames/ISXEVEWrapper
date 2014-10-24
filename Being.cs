using System;
using EVE.ISXEVE.Extensions;
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
					_id = this.GetInt("ID");
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
					_charId = this.GetInt64("CharID");
				return _charId.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Returns the Name member of a being object.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetString("Name")); }
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
					_isOnline = this.GetBool("IsOnline");
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
					_isNpc = this.GetBool("IsNPC");
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
					_isPc = this.GetBool("IsPC");
				return _isPc.Value;
			}
		}
		#endregion

		#region LavishScript Methods
		/// <summary>
		/// Invite a beign to your fleet.
		/// </summary>
		/// <returns></returns>
		public bool InviteToFleet()
		{
			Tracing.SendCallback("Being.InviteToFleet");
			return ExecuteMethod("InviteToFleet");
		}

	    public bool GiveMoney(Int64 amount, string reason)
	    {
	        return ExecuteMethod("GiveMoney", amount.ToString(), reason);
	    }
		#endregion
	}
}
