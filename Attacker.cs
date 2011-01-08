using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LavishScriptAPI;
using InnerSpaceAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Attacker class
	/// </summary>
	public class Attacker : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Attacker copy constructor
		/// </summary>
		/// <param name="copy"></param>
		public Attacker(LavishScriptObject copy) : base(copy) { }
		#endregion

		#region Members
		public Int64 ID
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
					return id.GetValue<Int64>();
				}
			}
		}

		/// <summary>
		/// GetAttacks member
		/// </summary>
		public int GetAttacks
		{
			get
			{
				LavishScriptObject getAttacks = GetMember("GetAttacks");
				if (LavishScriptObject.IsNullOrInvalid(getAttacks))
				{
					return -1;
				}
				return getAttacks.GetValue<int>();
			}
		}

		/// <summary>
		/// IsCurrentlyAttacking member
		/// </summary>
		public bool IsCurrentlyAttacking
		{
			get
			{
				LavishScriptObject isCurrentlyAttacking = GetMember("IsCurrentlyAttacking");
				if (LavishScriptObject.IsNullOrInvalid(isCurrentlyAttacking))
				{
					return false;
				}
				return isCurrentlyAttacking.GetValue<bool>();
			}
		}

		/// <summary>
		/// ToEntity member
		/// </summary>
		public Entity ToEntity
		{
			get
			{
				return new Entity(GetMember("ToEntity"));
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// DoGetAttacks method
		/// </summary>
		/// <returns></returns>
		public List<Attack> DoGetAttacks()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Attacker.DoGetAttacks", string.Empty);
			return Util.GetListFromMethod<Attack>(this, "DoGetAttacks", "attack");
		}
		#endregion
	}
}
