using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the agent data type.
	/// </summary>
	public class Agent : LavishScriptObject
	{
        /// <summary>
        /// Factory method for fetching an agent by index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static Agent ByIndex(int index)
        {
            return new Agent(index);
        }

        /// <summary>
        /// Factory method for fetching an agent by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Agent ById(int id)
        {
            return new Agent("", id);
        }

        /// <summary>
        /// Factory method for fetching an agent by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Agent ByName(string name)
        {
            return new Agent(name);
        }

		#region Constructors
		/// <summary>
		/// Agent copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public Agent(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Agent constructor by index.
		/// </summary>
		/// <param name="Index"></param>
		public Agent(int Index)
			: base(LavishScript.Objects.GetObject("Agent", Index.ToString()))
		{
		}

		/// <summary>
		/// Agent constructor by ID.
		/// </summary>
		/// <param name="ByID"></param>
		/// <param name="ID"></param>
		public Agent(string ByID, int ID)
			: base(LavishScript.Objects.GetObject("Agent", "id", ID.ToString()))
		{
		}

		/// <summary>
		/// Agent constructor by name.
		/// </summary>
		/// <param name="Name"></param>
		public Agent(string Name)
			: base(LavishScript.Objects.GetObject("Agent", Name))
		{
		}
		#endregion

		#region Members

		private int? _id;
		/// <summary>
		/// Wrapper for the ID member of the agent type.
		/// </summary>
		public int ID
		{
			get
			{
				if (_id == null)
					_id = this.GetIntFromLSO("ID");
				return _id.Value;
			}
		}

		private string _name;
		/// <summary>
		/// Wrapper for the Name member of the agent type.
		/// </summary>
		public string Name
		{
			get { return _name ?? (_name = this.GetStringFromLSO("Name")); }
		}

		private int? _typeId;
		/// <summary>
		/// Wrapper for the TypeID member of the agent type.
		/// </summary>
		[Obsolete]
		public int TypeID
		{
			get
			{
				if (_typeId == null)
					_typeId = this.GetIntFromLSO("TypeID");
				return _typeId.Value;
			}
		}

	    private int? _agentTypeId;
        /// <summary>
        /// Wrapper for the AgentTypeID member of the agent type.
        /// </summary>
	    public int AgentTypeID
	    {
	        get
	        {
	            if (_agentTypeId == null)
	                _agentTypeId = this.GetIntFromLSO("AgentTypeID");

	            return _agentTypeId.Value;
	        }
	    }

		private string _division;
		/// <summary>
		/// Wrapper for the Division member of the agent type.
		/// </summary>
		public string Division
		{
			get { return _division ?? (_division = this.GetStringFromLSO("Division")); }
		}

		private int? _divisionId;
		/// <summary>
		/// Wrapper for the DivisionID member of the agent type.
		/// </summary>
		public int DivisionID
		{
			get
			{
				if (_divisionId == null)
					_divisionId = this.GetIntFromLSO("DivisionID");
				return _divisionId.Value;
			}
		}

		private int? _level;
		/// <summary>
		/// Wrapper for the Level member of the agent type.
		/// </summary>
		public int Level
		{
			get
			{
				if (_level == null)
					_level = this.GetIntFromLSO("Level");
				return _level.Value;
			}
		}

		private int? _corporationId;
		/// <summary>
		/// Wrapper for the CorporationID member of the agent type.
		/// </summary>
		public int CorporationID
		{
			get
			{
				if (_corporationId == null)
					_corporationId = this.GetIntFromLSO("CorporationID");
				return _corporationId.Value;
			}
		}

		private int? _factionId;
		/// <summary>
		/// Wrapper for the FactionID member of the agent type.
		/// </summary>
		public int FactionID
		{
			get
			{
				if (_factionId == null)
					_factionId = this.GetIntFromLSO("FactionID");
				return _factionId.Value;
			}
		}

		private float? _standingTo;
		/// <summary>
		/// Wrapper for the StandingTo member of the agent type.
		/// </summary>
		public float StandingTo
		{
			get
			{
				if (_standingTo == null)
					_standingTo = this.GetFloatFromLSO("StandingTo");
				return _standingTo.Value;
			}
		}

		private Interstellar _solarsystem;
		/// <summary>
		/// Wrapper for the Solarsystem member of the agent type.
		/// </summary>
		public Interstellar Solarsystem
		{
			get
			{
				return _solarsystem ?? (_solarsystem = new Interstellar(GetMember("Solarsystem")));
			}
		}

		private string _station;
		/// <summary>
		/// Wrapper for the Station member of the agent type.
		/// </summary>
		public string Station
		{
			get { return _station ?? (_station = this.GetStringFromLSO("Station")); }
		}

		private int? _stationId;
		/// <summary>
		/// Wrapper for the StationID member of the agent type.
		/// </summary>
		public int StationID
		{
			get
			{
				if (_stationId == null)
					_stationId = this.GetIntFromLSO("StationID");
				return _stationId.Value;
			}
		}

		private int? _index;
		/// <summary>
		/// Wrapper for the Index member of the agent type.
		/// </summary>
		public int Index
		{
			get
			{
				if (_index == null)
					_index = this.GetIntFromLSO("Index");
				return _index.Value;
			}
		}

		private string _dialog;
		/// <summary>
		/// Wrapper for the Dialog member of the agent type.
		/// </summary>
		public string Dialog
		{
			get { return _dialog ?? (_dialog = this.GetStringFromLSO("Dialog")); }
		}

		private List<DialogString> _dialogResponses;
		/// <summary>
		/// Wrapper for the GetDialogResponses member of the agent type.
		/// </summary>
		/// <returns></returns>
		public List<DialogString> GetDialogResponses()
		{
			Tracing.SendCallback("Agent:GetDialogResponses");
			return _dialogResponses ?? (_dialogResponses = Util.GetListFromMethod<DialogString>(this, "GetDialogResponses", "dialogstring"));
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the StartConversation method of the agent type.
		/// </summary>
		/// <returns></returns>
		public bool StartConversation()
		{
			Tracing.SendCallback("Agent.StartConversation");
			return ExecuteMethod("StartConversation");
		}
		#endregion

	}
}
