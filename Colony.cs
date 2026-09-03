using System;
using System.Collections.Generic;

using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the colony datatype.  Represents one of the character's colonized planets, as returned by
	/// <see cref="EVE.GetColonies"/>.
	/// </summary>
	public class Colony : LavishScriptObject
	{
		/// <summary>
		/// Colony copy constructor.
		/// </summary>
		/// <param name="copy"></param>
		public Colony(LavishScriptObject copy) : base(copy)
		{
		}

		#region LS Members

		private long? _planetID;
		/// <summary>
		/// Wrapper for the PlanetID member of the colony datatype.
		/// </summary>
		public long PlanetID
		{
			get
			{
				if (_planetID == null)
					_planetID = this.GetInt64("PlanetID");
				return _planetID.Value;
			}
		}

		private int? _planetTypeID;
		/// <summary>
		/// Wrapper for the PlanetTypeID member of the colony datatype.
		/// </summary>
		public int PlanetTypeID
		{
			get
			{
				if (_planetTypeID == null)
					_planetTypeID = this.GetInt("PlanetTypeID");
				return _planetTypeID.Value;
			}
		}

		private string _planetType;
		/// <summary>
		/// Wrapper for the PlanetType member of the colony datatype.  The planet's type name
		/// (e.g. "Planet (Barren)"), resolved from <see cref="PlanetTypeID"/>.
		/// </summary>
		public string PlanetType
		{
			get { return _planetType ?? (_planetType = this.GetString("PlanetType")); }
		}

		private long? _solarSystemID;
		/// <summary>
		/// Wrapper for the SolarSystemID member of the colony datatype.
		/// </summary>
		public long SolarSystemID
		{
			get
			{
				if (_solarSystemID == null)
					_solarSystemID = this.GetInt64("SolarSystemID");
				return _solarSystemID.Value;
			}
		}

		private int? _celestialIndex;
		/// <summary>
		/// Wrapper for the CelestialIndex member of the colony datatype.  The planet's orbital index within
		/// its solar system.
		/// </summary>
		public int CelestialIndex
		{
			get
			{
				if (_celestialIndex == null)
					_celestialIndex = this.GetInt("CelestialIndex");
				return _celestialIndex.Value;
			}
		}

		private bool? _isEditing;
		/// <summary>
		/// Wrapper for the IsEditing member of the colony datatype.  True while the planet is being edited
		/// (uncommitted layout changes).
		/// </summary>
		public bool IsEditing
		{
			get
			{
				if (_isEditing == null)
					_isEditing = this.GetBool("IsEditing");
				return _isEditing.Value;
			}
		}

		private bool? _needsRestart;
		/// <summary>
		/// Wrapper for the NeedsRestart member of the colony datatype.  True when one or more of the colony's
		/// extractor control units can be restarted (see <see cref="RestartExtractors"/>).
		/// </summary>
		public bool NeedsRestart
		{
			get
			{
				if (_needsRestart == null)
					_needsRestart = this.GetBool("NeedsRestart");
				return _needsRestart.Value;
			}
		}

		private bool? _needsAttention;
		/// <summary>
		/// Wrapper for the NeedsAttention member of the colony datatype.  True when some pin of the colony
		/// needs attention.
		/// </summary>
		public bool NeedsAttention
		{
			get
			{
				if (_needsAttention == null)
					_needsAttention = this.GetBool("NeedsAttention");
				return _needsAttention.Value;
			}
		}

		private int? _numExtractors;
		/// <summary>
		/// Wrapper for the NumExtractors member of the colony datatype.  The number of extractor control units
		/// in the colony.
		/// </summary>
		public int NumExtractors
		{
			get
			{
				if (_numExtractors == null)
					_numExtractors = this.GetInt("NumExtractors");
				return _numExtractors.Value;
			}
		}

		#endregion

		#region LS Methods

		/// <summary>
		/// Wrapper for the GetExtractors method of the colony datatype.  Returns the colony's extractor
		/// control units.
		/// </summary>
		/// <returns></returns>
		public List<ExtractorControlUnit> GetExtractors()
		{
			Tracing.SendCallback("Colony.GetExtractors");
			return Util.GetListFromMethodDirect<ExtractorControlUnit>(this, "GetExtractors", "extractorcontrolunit");
		}

		/// <summary>
		/// Wrapper for the RestartExtractors method of the colony datatype.  Restarts the colony's extractor
		/// programs (submits the change server-side).
		/// </summary>
		/// <returns></returns>
		public bool RestartExtractors()
		{
			Tracing.SendCallback("Colony.RestartExtractors");
			return ExecuteMethod("RestartExtractors");
		}

		#endregion
	}
}
