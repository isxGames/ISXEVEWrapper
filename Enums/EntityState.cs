using System;

namespace EVE.ISXEVE.Enums
{
	/// <summary>
	/// States for an entity
	/// </summary>
	public enum EntityState
	{
		Offlining = -7,
		Anchoring,
		Onlining,
		Anchored,
		Unanchoring,
		Unanchored,
		Incapacitated,
		Idle,
		Combat,
		Mining,
		Approaching,
		Departing,
		Departing_2,
		Pursuit,
		Fleeing,
		Reinforced,
		Operating,
		Engage,
		Vulnerable,
		Shield_Reinforce,
		Armor_Reinforce,
		Invulnerable,
		WarpAwayAndDie,
		WarpAwayAndComeback,
		WarpToPosition
	}
}
