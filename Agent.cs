using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
  /// Wrapper for the agent data type.
	/// </summary>
  public class Agent : LavishScriptObject
	{
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
    /// <summary>
    /// Wrapper for the ID member of the agent type.
    /// </summary>
		public int ID
		{
			get
			{
				return GetMember<int>("ID");
			}
		}

    /// <summary>
    /// Wrapper for the Name member of the agent type.
    /// </summary>
		public string Name
		{
			get
			{
				return GetMember<string>("Name");
			}
		}

    /// <summary>
    /// Wrapper for the TypeID member of the agent type.
    /// </summary>
		public int TypeID
		{
			get
			{
				return GetMember<int>("TypeID");
			}
		}

    /// <summary>
    /// Wrapper for the Division member of the agent type.
    /// </summary>
		public string Division
		{
			get
			{
				return GetMember<string>("Division");
			}
		}

    /// <summary>
    /// Wrapper for the DivisionID member of the agent type.
    /// </summary>
		public int DivisionID
		{
			get
			{
				return GetMember<int>("DivisionID");
			}
		}

    /// <summary>
    /// Wrapper for the Level member of the agent type.
    /// </summary>
		public int Level
		{
			get
			{
				return GetMember<int>("Level");
			}
		}

    /// <summary>
    /// Wrapper for the Quality member of the agent type.
    /// </summary>
		public int Quality
		{
			get
			{
				return GetMember<int>("Quality");
			}
		}

    /// <summary>
    /// Wrapper for the CorporationID member of the agent type.
    /// </summary>
		public int CorporationID
		{
			get
			{
				return GetMember<int>("CorporationID");
			}
		}

    /// <summary>
    /// Wrapper for the FactionID member of the agent type.
    /// </summary>
		public int FactionID
		{
			get
			{
				return GetMember<int>("FactionID");
			}
		}

    /// <summary>
    /// Wrapper for the StandingTo member of the agent type.
    /// </summary>
		public float StandingTo
		{
			get
			{
				return GetMember<float>("StandingTo");
			}
		}

    /// <summary>
    /// Wrapper for the Solarsystem member of the agent type.
    /// </summary>
		public Interstellar Solarsystem
		{
			get
			{
				return new Interstellar(GetMember("Solarsystem"));
			}
		}

    /// <summary>
    /// Wrapper for the Station member of the agent type.
    /// </summary>
		public string Station
		{
			get
			{
				return GetMember<string>("Station");
			}
		}

    /// <summary>
    /// Wrapper for the StationID member of the agent type.
    /// </summary>
		public int StationID
		{
			get
			{
				return GetMember<int>("StationID");
			}
		}

    /// <summary>
    /// Wrapper for the Index member of the agent type.
    /// </summary>
		public int Index
		{
			get
			{
				return GetMember<int>("Index");
			}
		}

    /// <summary>
    /// Wrapper for the Dialog member of the agent type.
    /// </summary>
		public string Dialog
		{
			get
			{
				return GetMember<string>("Dialog");
			}
		}

    /// <summary>
    /// Wrapper for the GetDialogResponses member of the agent type.
    /// </summary>
    /// <returns></returns>
		public List<DialogString> GetDialogResponses()
		{
			return Util.GetListFromMember<DialogString>(this, "GetDialogResponses", "dialogstring");
		}
		#endregion

		#region Methods
    /// <summary>
    /// Wrapper for the StartConversation method of the agent type.
    /// </summary>
    /// <returns></returns>
		public bool StartConversation()
		{
            if (Tracing.Callback != null)
                Tracing.SendCallback("Agent.StartConversation", string.Empty);
			return ExecuteMethod("StartConversation");
		}
		#endregion

	}
}
