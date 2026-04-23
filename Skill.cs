using System;
using System.Collections.Generic;
using System.Globalization;

using EVE.ISXEVE.Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Wrapper for the skill data type.
	/// </summary>
	public class Skill : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// Skill object copy constructor.
		/// </summary>
		public Skill(LavishScriptObject Copy)
			: base(Copy)
		{
		}
		#endregion

		#region Statics
		/// <summary>
		/// Get all skills our character knows.
		/// </summary>
		/// <returns></returns>
		public static List<Skill> GetSkills()
		{
			Me me = new Me();

			if (!LavishScriptObject.IsNullOrInvalid(me))
				return new Me().GetSkills();

			return new List<Skill>();
		}

		/// <summary>
		/// Return a skill object based on the skill name parameter.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static Skill GetSkill(string name)
		{
			Me me = new Me();

			if (!LavishScriptObject.IsNullOrInvalid(me))
				return new Me().Skill(name);

			return new Skill(null);
		}

		/// <summary>
		/// Returns the skill currently being trained, delegating to the
		/// SkillCurrentlyTraining member of the character datatype.
		/// Check LavishScriptObject.IsNullOrInvalid on the result.
		/// </summary>
		public static Skill SkillBeingTrained
		{
			get
			{
				Me me = new Me();

				if (!LavishScriptObject.IsNullOrInvalid(me))
					return me.SkillCurrentlyTraining;

				return new Skill(null);
			}
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for Name member of skill type.
		/// </summary>
		public string Name
		{
			get { return this.GetString("Name"); }
		}

		/// <summary>
		/// NOTE: This will be the time left to train this skill to the next level,
		/// no matter if the skill is currently being trained or not. If the value
		/// is ZERO, then the skill is maxed out. 
		/// ALSO! To get an accurate value for this, a skill must not be currently 
		/// training. So, if you need to know the time remaining on a skill that is 
		/// currently training, abort it first, then check this value.
		/// </summary>
		public double TimeToTrain
		{
			get { return this.GetDouble("TimeToTrain"); }
		}

		/// <summary>
		/// Wrapper for TrainingTimeMultiplier member of skill type.
		/// </summary>
		public double TrainingTimeMultiplier
		{
			get { return this.GetDouble("TrainingTimeMultiplier"); }
		}

		/// <summary>
		/// Wrapper for the Points member of the skill type.
		/// </summary>
		public int Points
		{
			get { return this.GetInt("Points"); }
		}

		/// <summary>
		/// Wrapper for the TrainedLevel member of the skill type.
		/// </summary>
		public int TrainedLevel
		{
			get { return this.GetInt("TrainedLevel"); }
		}

		/// <summary>
		/// Wrapper for the EffectiveLevel member of the skill type.
		/// Added ISXEVE 2023-07-12. Returns the skill's effective level
		/// (may exceed TrainedLevel when boosted by implants or similar).
		/// </summary>
		public int EffectiveLevel
		{
			get { return this.GetInt("EffectiveLevel"); }
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for AddToQueue method of the skill type.
		/// </summary>
		/// <param name="skillLevel">Ignored by ISXEVE (kept for backwards compatibility).</param>
		/// <returns></returns>
		[Obsolete("The skillLevel argument is ignored by ISXEVE — the level is determined by the skill's own skillLevel attribute in source. Pass any int for legacy compatibility.")]
		public bool AddToQueue(int skillLevel)
		{
			Tracing.SendCallback("Skill.AddtoQueue", skillLevel.ToString(CultureInfo.CurrentCulture));
			return ExecuteMethod("AddToQueue", skillLevel.ToString(CultureInfo.CurrentCulture));
		}

		/// <summary>
		/// Wrapper for StartTraining method of the skill type.
		/// </summary>
		/// <returns></returns>
		[Obsolete("StartTraining is deprecated in ISXEVE and prints a console warning on each call. Use AddToQueue instead.")]
		public bool StartTraining()
		{
			Tracing.SendCallback("Skill.StartTraining", string.Empty);
			return ExecuteMethod("StartTraining");
		}
		#endregion
	}
}
