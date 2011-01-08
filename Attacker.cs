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
			Tracing.SendCallback("Attacker.DoGetAttacks");
			return Util.GetListFromMethod<Attack>(this, "DoGetAttacks", "attack");
		}
		#endregion
	}
}
