using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Extensions;
using LavishScriptAPI;
using InnerSpaceAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Attacker class
	/// </summary>
	public class Attacker : Entity
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
				Tracing.SendCallback("Attacker.ID");
			    return this.GetInt64FromLSO("ID");
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

		/// Get the Jammer member of the Attacker object
        public Jammer ToJammer
        {
            get
            {
                return new Jammer(GetMember("ToJammer"));
            }
        }
		#endregion

		#region Methods
		/// <summary>
		/// GetAttacks method
		/// </summary>
		/// <returns></returns>
		public List<Attack> GetAttacks()
		{
			Tracing.SendCallback("Attacker.GetAttacks");
			return Util.GetListFromMethod<Attack>(this, "GetAttacks", "attack");
		}
		#endregion
	}
}
