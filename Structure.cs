using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the structure data type.  Represents an Upwell (player-owned) structure;
	/// functionally similar to <see cref="Station"/> but gated by structure-access rules.
	/// The source datatype (<c>StructureType</c> in <c>DataTypes.h:1792</c>) inherits directly
	/// from <c>StationType</c> via <c>INHERITDIRECT</c>, so this wrapper inherits <see cref="Station"/>.
	/// Accessed via <c>EVE.Structure(long id)</c> (eve datatype member) or via
	/// <c>Entity.Structure[ID#]</c> (see <c>ISXEVEChanges.txt:536-538</c>).
	/// </summary>
	public class Structure : Station
	{
		#region Constructors
		/// <summary>
		/// Structure copy constructor.
		/// </summary>
		/// <param name="Copy"></param>
		public Structure(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the CanBoard member of the structure datatype.  True if the current
		/// character is permitted to board / dock at this structure.  Source: calls
		/// <c>structureControl.CanBoard(structureID)</c> (<c>DT-Stations_Structures.cpp:513-518</c>).
		/// </summary>
		public bool CanBoard
		{
			get { return this.GetBool("CanBoard"); }
		}

		/// <summary>
		/// Wrapper for the MyCorpHasOffice member of the structure datatype.  True if the current
		/// character's corporation rents an office at this structure.  Source: calls
		/// <c>structureOffices.HasOffice()</c> (<c>DT-Stations_Structures.cpp:519-524</c>).
		/// </summary>
		public bool MyCorpHasOffice
		{
			get { return this.GetBool("MyCorpHasOffice"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the Board method of the structure datatype.  Attempts to dock / board
		/// this structure.  Source (<c>DT-Stations_Structures.cpp:539-547</c>) first re-checks
		/// <c>CanBoard</c> server-side before dispatching the actual Board call, so this is
		/// safe to call without a prior CanBoard check.
		/// </summary>
		/// <returns></returns>
		public bool Board()
		{
			Tracing.SendCallback("Structure.Board");
			return ExecuteMethod("Board");
		}
		#endregion
	}
}
