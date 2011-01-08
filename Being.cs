using System;
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
		public Int32 ID
		{
			get
			{
				LavishScriptObject id = GetMember("ID");
				if (LavishScriptObject.IsNullOrInvalid(id))
				{
					return -1;
				}
				else
				{
					return id.GetValue<Int32>();
				}
			}
		}

		/// <summary>
		/// Returns the CharID member of a being object.
		/// </summary>
		public int CharID
		{
			get
			{
				return GetMember<int>("CharID");
			}
		}

		/// <summary>
		/// Returns the Name member of a being object.
		/// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Returns the IsOnline member of a being object.
		/// </summary>
		public bool IsOnline
		{
			get
			{
				LavishScriptObject isOnline = GetMember("IsOnline");
				if (LavishScriptObject.IsNullOrInvalid(isOnline))
				{
					return false;
				}
				else
				{
					return isOnline.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Returns the IsNPC member of a being object.
		/// </summary>
		public bool IsNPC
		{
			get
			{
				LavishScriptObject isNPC = GetMember("IsNPC");
				if (LavishScriptObject.IsNullOrInvalid(isNPC))
				{
					return false;
				}
				else
				{
					return isNPC.GetValue<bool>();
				}
			}
		}

		/// <summary>
		/// Returns the IsPC member of a being object.
		/// </summary>
		public bool IsPC
		{
			get
			{
				LavishScriptObject isPC = GetMember("IsPC");
				if (LavishScriptObject.IsNullOrInvalid(isPC))
				{
					return false;
				}
				else
				{
					return isPC.GetValue<bool>();
				}
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
