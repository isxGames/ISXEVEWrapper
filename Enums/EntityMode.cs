using System;

namespace EVE.ISXEVE.Enums
{
	/// <summary>
	/// Modes for an entity
	/// </summary>
	public enum EntityMode
	{
		/// <summary>
		/// Aligning for warp
		/// </summary>
		Aligned,
		/// <summary>
		/// Approaching target
		/// </summary>
		Approaching,
		/// <summary>
		/// Idle
		/// </summary>
		Stopped,
		/// <summary>
		/// Warping
		/// </summary>
		Warping,
		/// <summary>
		/// Orbiting a target
		/// </summary>
		Orbiting
	}
}
