using System;
using System.Collections.Generic;
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

			if (!LavishScriptPersistentObject.IsNullOrInvalid(me))
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

			if (!LavishScriptPersistentObject.IsNullOrInvalid(me))
				return new Me().Skill(name);

			return new Skill(null);
		}

		/// <summary>
		/// This just goes through all the skills looking for the skill
		/// currently being trained.  Check LavishScriptObject.IsNullOrInvalid 
		/// on the result.
		/// </summary>
		public static Skill SkillBeingTrained
		{
			get
			{
				Me me = new Me();

				if (!LavishScriptPersistentObject.IsNullOrInvalid(me))
				{
					List<Skill> skills = GetSkills();

					foreach (Skill skill in skills)
						if (!LavishScriptObject.IsNullOrInvalid(skill) &&
							skill.IsTraining)
							return skill;
				}

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
			get
			{
				return GetMember<string>("Name");
			}
		}

		/// <summary>
		/// Wrapper for ID member of skill type.
		/// </summary>
		public int ID
		{
			get
			{
				return GetMember<int>("ID");
			}
		}

		/// <summary>
		/// Wrapper for Group member of skill type.
		/// </summary>
		public string Group
		{
			get
			{
				return GetMember<string>("Group");
			}
		}

		/// <summary>
		/// Wrapper for GroupID member of skill type.
		/// </summary>
		public int GroupID
		{
			get
			{
				return GetMember<int>("GroupID");
			}
		}

		/// <summary>
		/// Wrapper for IsTraining member of skill type.
		/// </summary>
		public bool IsTraining
		{
			get
			{
				return GetMember<bool>("IsTraining");
			}
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
			get
			{
				return GetMember<double>("TimeToTrain");
			}
		}

		/// <summary>
		/// Wrapper for TrainingTimeMultiplier member of skill type.
		/// </summary>
		public double TrainingTimeMultiplier
		{
			get
			{
				return GetMember<double>("TrainingTimeMultiplier");
			}
		}

		/// <summary>
		/// Wrapper for SkillPoints member of skill type.
		/// </summary>
		public int SkillPoints
		{
			get
			{
				return GetMember<int>("SkillPoints");
			}
		}

		/// <summary>
		/// Wrapper for Level member of skill type.
		/// </summary>
		public int Level
		{
			get
			{
				return GetMember<int>("Level");
			}
		}
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for AddToQueue method of the skill type.
		/// </summary>
		/// <returns></returns>
		public bool AddToQueue(int skillLevel)
		{
			Tracing.SendCallback("Skill.AddtoQueue", skillLevel.ToString());
			return ExecuteMethod("AddToQueue", skillLevel.ToString());
		}

		/// <summary>
		/// Wrapper for AbortTraining method of the skill type.
		/// </summary>
		/// <returns></returns>
		public bool AbortTraining()
		{
			Tracing.SendCallback("Skill.AbortTraining", string.Empty);
			return ExecuteMethod("AbortTraining");
		}

		/// <summary>
		/// Wrapper for StartTraining method of the skill type.
		/// </summary>
		/// <returns></returns>
		public bool StartTraining()
		{
			Tracing.SendCallback("Skill.StartTraining", string.Empty);
			return ExecuteMethod("StartTraining");
		}
		#endregion
	}
}
