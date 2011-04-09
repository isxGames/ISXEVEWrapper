using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LavishScriptAPI;
using InnerSpaceAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Jammer class
	/// </summary>
	public class Jammer : Attacker
	{
		#region Constructors
		/// <summary>
		/// Jammer copy constructor
		/// </summary>
		/// <param name="copy"></param>
		public Jammer(LavishScriptObject copy) : base(copy) { }
		#endregion

        #region Methods
        public List<string> GetJams()
        {
            return Util.GetListFromMethod<string>(this, "GetJams", "string");
        }
        #endregion
    }
}
