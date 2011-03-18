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
		/// <summary>
		/// The EntityID of the Attacker.
		/// </summary>
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
		public List<Attack> GetAttacks()
		{
			if (Tracing.Callback != null)
				Tracing.SendCallback("Attacker.GetAttacks");

			return Util.GetListFromMember<Attack>(this, "GetAttacks", "attack");
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

		/// <summary>
		/// Get the Jammer member of the Attacker object
		/// </summary>
		public Jammer ToJammer
		{
			get
			{
				return new Jammer(GetMember("ToJammer"));
			}
		}
		#endregion
	}
}
