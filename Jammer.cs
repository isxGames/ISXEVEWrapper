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
	public class Jammer : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Jammer copy constructor
		/// </summary>
		/// <param name="copy"></param>
		public Jammer(LavishScriptObject copy) : base(copy) { }
		#endregion

        #region Members
        /// <summary>
        /// Get the Entity this Jammer is from.
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
        public List<string> GetJams()
        {
            return Util.GetListFromMethod<string>(this, "GetJams", "string");
        }
        #endregion
    }
}
