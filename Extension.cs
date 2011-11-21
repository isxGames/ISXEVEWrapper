using System;
using System.Text;
using System.Runtime.InteropServices;
using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Utility class that wraps common ISXEVE elements.
	/// </summary>
	public class Extension
	{
		/// <summary>
		/// Extension object constructor.
		/// </summary>
		public Extension()
		{
		}

		/// <summary>
		/// Return a new EVE object.
		/// </summary>
		/// <returns></returns>
		public EVE EVE()
		{
			return new EVE();
		}

		/// <summary>
		/// Return a new "me" object.
		/// </summary>
		public Character Me
		{
			get
			{
				return new Me();
			}
		}

		/// <summary>
		/// Create an Entity object based on an ID.
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		public Entity Entity(int ID)
		{
			return new Entity(ID);
		}

		/// <summary>
		/// Create a new Entity object based on a lookup string.
		/// </summary>
		/// <param name="Args"></param>
		/// <returns></returns>
		public Entity Entity(params string[] Args)
		{
			return new Entity(Args);
		}

		/// <summary>
		/// Check with LavishScriptObject.IsNullOrInvalid.  If its not valid, 
		/// you're not at the char select screen.
		/// </summary>
		public CharSelect CharSelect
		{
			get
			{
				return new CharSelect();
			}
		}

		/// <summary>
		/// Returns a new ISXEVE object
		/// </summary>
		public ISXEVE ISXEVE
		{
			get
			{
				return new ISXEVE();
			}
		}

		/// <summary>
		/// Possible "Names" include: "MyShipCargo", "MyDroneBay", "Market", "hangarFloor", 
		/// "shipHangar", "Local", "Corporation Hangar" (more added as needed/requested).
		/// </summary>
		public EVEWindow EVEWindow(string name)
		{
			return new EVEWindow(name);
		}

		/// <summary>
		/// Returns a new EVETime object
		/// </summary>
		public EVETime EVETime()
		{
			return new EVETime();
		}

		/// <summary>
		/// Get an agent by ID.
		/// </summary>
		public Agent Agent(int AgentID)
		{
			return new Agent("id", AgentID);
		}

		/// <summary>
		/// Get an agent by ID.
		/// </summary>
		public Agent AgentByID(int AgentID)
		{
			return new Agent("id", AgentID);
		}

		/// <summary>
		/// Get an agent by Index
		/// </summary>
		public Agent AgentByIndex(int Index)
		{
			return new Agent(Index);
		}

		/// <summary>
		/// Get an agent by Name
		/// </summary>
		public Agent Agent(string Name)
		{
			return new Agent(Name);
		}

		/// <summary>
		/// Get a Local pilot by ID.
		/// </summary>
		public Pilot Local(Int64 CharID)
		{
			return new Pilot(CharID);
		}

		/// <summary>
		/// Get a Local pilot by name.
		/// </summary>
		public Pilot Local(string CharName)
		{
			return new Pilot(CharName);
		}

		/// <summary>
		/// Check with LavishScriptObject.IsNullOrInvalid. If its not valid,
		/// you're not at the login screen.
		/// </summary>
		public Login Login
		{
			get
			{
				return new Login();
			}
		}

		/// <summary>
		/// can refer to any solarsystem, region, or constellation
		/// </summary>
		public Interstellar InterstellarByName(string Name)
		{
			return Universe.ByName(Name);
		}

		/// <summary>
		/// can refer to any solarsystem, region, or constellation
		/// </summary>
		public Interstellar InterstellarByID(int ID)
		{
			return Universe.ByID(ID);
		}
	}
}