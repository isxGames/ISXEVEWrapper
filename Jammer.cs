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
    /// Type member
    /// </summary>
		public string Type
		{
			get
			{
				LavishScriptObject type = GetMember("Type");
				if (LavishScriptObject.IsNullOrInvalid(type))
				{
					return string.Empty;
				}
				return type.GetValue<string>();
			}
		}

    /// <summary>
    /// CycleTimeRemaining member
    /// </summary>
		public double CycleTimeRemaining
		{
			get
			{
				LavishScriptObject cycleTimeRemaining = GetMember("CycleTimeRemaining");
				if (LavishScriptObject.IsNullOrInvalid(cycleTimeRemaining))
				{
					return -1;
				}
				return cycleTimeRemaining.GetValue<double>();
			}
		}

    /// <summary>
    /// Origin member
    /// </summary>
		public Entity Origin
		{
			get
			{
				return new Entity(GetMember("Origin"));
			}
		}

    /// <summary>
    /// StartTime member
    /// </summary>
		public EVETime StartTime
		{
			get
			{
				return new EVETime(GetMember("StartTime"));
			}
		}
		#endregion
	}
}
