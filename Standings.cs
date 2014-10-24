using System;
using System.Collections.Generic;
using System.Text;
using EVE.ISXEVE.Extensions;
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
			get { return this.GetInt("CorpToAlliance"); }
		}

		/// <summary>
		/// Standings of your corp to their corp.
		/// </summary>
		public int CorpToCorp
		{
			get { return this.GetInt("CorpToCorp"); }
		}

		/// <summary>
		/// Stadings of your corp to them.
		/// </summary>
		public int CorpToPilot
		{
			get { return this.GetInt("CorpToPilot"); }
		}

		/// <summary>
		/// Standings of you to their corp.
		/// </summary>
		public int MeToCorp
		{
			get { return this.GetInt("MeToCorp"); }
		}

		/// <summary>
		/// Standings of you to them.
		/// </summary>
		public int MeToPilot
		{
			get { return this.GetInt("MeToPilot"); }
		}

		/// <summary>
		/// Standings of your allianc to their alliance.
		/// </summary>
		public int AllianceToAlliance
		{
			get { return this.GetInt("AllianceToAlliance"); }
		}

        public int MeToAlliance
        {
            get { return this.GetInt("MeToAlliance"); }
        }

        public int AllianceToCorp
        {
            get { return this.GetInt("AllianceToCorp"); }
        }

        public int AllianceToPilot
        {
            get { return this.GetInt("AlliancetoPilot"); }
        }
		#endregion
	}
}
