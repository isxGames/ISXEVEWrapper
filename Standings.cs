using System;
using System.Collections.Generic;
using System.Text;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
  /// Wrapper for the standing data type.
	/// </summary>
  public class Standing : LavishScriptObject
	{
		#region Constructors
    /// <summary>
    /// Standing object copy constructor.
    /// </summary>
    public Standing(LavishScriptObject obj) :
			base(obj)
		{

		}
		#endregion

		#region Members
		/// <summary>
		/// Standings of your corp to their alliance.
		/// </summary>
		public int CorpToAlliance
		{
			get
			{
				return GetMember<int>("CorpToAlliance");
			}
		}

		/// <summary>
		/// Standings of your corp to their corp.
		/// </summary>
		public int CorpToCorp
		{
			get
			{
				return GetMember<int>("CorpToCorp");
			}
		}

		/// <summary>
		/// Stadings of your corp to them.
		/// </summary>
		public int CorpToPilot
		{
			get
			{
				return GetMember<int>("CorpToPilot");
			}
		}

		/// <summary>
		/// Standings of you to their corp.
		/// </summary>
		public int MeToCorp
		{
			get
			{
				return GetMember<int>("MeToCorp");
			}
		}

		/// <summary>
		/// Standings of you to them.
		/// </summary>
		public int MeToPilot
		{
			get
			{
				return GetMember<int>("MeToPilot");
			}
		}

		/// <summary>
		/// Standings of your allianc to their alliance.
		/// </summary>
		public int AllianceToAlliance
		{
			get
			{
				return GetMember<int>("AllianceToAlliance");
			}
		}
		#endregion
	}
}
