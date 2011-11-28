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
		public Int32 ID
		{
			get { return this.GetIntFromLSO("ID"); }
		}

		/// <summary>
		/// Returns the CharID member of a being object.
		/// </summary>
		public Int64 CharID
		{
			get { return this.GetInt64FromLSO("CharID"); }
		}

		/// <summary>
		/// Returns the Name member of a being object.
		/// </summary>
		public string Name
		{
			get { return this.GetStringFromLSO("Name"); }
		}

		/// <summary>
		/// Returns the IsOnline member of a being object.
		/// </summary>
		public bool IsOnline
		{
			get { return this.GetBoolFromLSO("IsOnline"); }
		}

		/// <summary>
		/// Returns the IsNPC member of a being object.
		/// </summary>
		public bool IsNPC
		{
			get { return this.GetBoolFromLSO("IsNPC"); }
		}

		/// <summary>
		/// Returns the IsPC member of a being object.
		/// </summary>
		public bool IsPC
		{
			get { return this.GetBoolFromLSO("IsPC"); }
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
