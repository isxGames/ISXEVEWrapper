using System;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the jumpclone data type.
	/// </summary>
	public class JumpClone : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// JumpClone copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public JumpClone(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the ID member of the jumpclone type.
		/// </summary>
		public Int64 ID
		{
			get { return this.GetInt64("ID"); }
		}

		/// <summary>
		/// Wrapper for the CloneID member of the jumpclone type.
		/// </summary>
		public Int64 CloneID
		{
			get { return this.GetInt64("CloneID"); }
		}

		/// <summary>
		/// Wrapper for the LocationID member of the jumpclone type.
		/// </summary>
		public Int64 LocationID
		{
			get { return this.GetInt64("LocationID"); }
		}

		/// <summary>
		/// Wrapper for the LocationName member of the jumpclone type.
		/// </summary>
		public string LocationName
		{
			get { return this.GetString("LocationName"); }
		}

		/// <summary>
		/// Wrapper for the Name member of the jumpclone type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

		/// <summary>
		/// Wrapper for the NumImplants member of the jumpclone type.
		/// </summary>
		public int NumImplants
		{
			get { return this.GetInt("NumImplants"); }
		}

		/// <summary>
		/// The typeID of the #th implant on this clone (1-based).
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public int Implant(int index)
		{
			return this.GetInt("Implant", index.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// The type name of the #th implant on this clone (1-based).
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public string ImplantName(int index)
		{
			return this.GetString("ImplantName", index.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// The station (or structure, when docked at an Upwell structure) this clone is installed at.
		/// </summary>
		public Station ToStation
		{
			get
			{
				var station = GetMember("ToStation");
				return IsNullOrInvalid(station) ? null : new Station(station);
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the JumpTo method of the jumpclone type.
		/// </summary>
		/// <returns></returns>
		public bool JumpTo()
		{
			Tracing.SendCallback("JumpClone.JumpTo");
			return ExecuteMethod("JumpTo");
		}

		/// <summary>
		/// Wrapper for the Destroy method of the jumpclone type.
		/// </summary>
		/// <returns></returns>
		public bool Destroy()
		{
			Tracing.SendCallback("JumpClone.Destroy");
			return ExecuteMethod("Destroy");
		}

		/// <summary>
		/// Wrapper for the SetName method of the jumpclone type.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool SetName(string name)
		{
			Tracing.SendCallback("JumpClone.SetName", name);
			return ExecuteMethod("SetName", name);
		}
		#endregion
	}
}
