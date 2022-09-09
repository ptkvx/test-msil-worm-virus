using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's goalkeeping skills.")]
public class GoalkeepingSkills : Skills
{
	[PropertyInfo("Aerial ability", "Players aerial ability (range -127 to 127).")]
	public sbyte AerialAbility
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.AerialAbility);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.AerialAbility);
		}
	}

	[PropertyInfo("Command of area", "Players command of area (range -127 to 127).")]
	public sbyte CommandOfArea
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.CommandOfArea);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.CommandOfArea);
		}
	}

	[PropertyInfo("Communication", "Players communication (range -127 to 127).")]
	public sbyte Communication
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Communication);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Communication);
		}
	}

	[PropertyInfo("Eccentricity", "Players eccentricity (range 1 to 20).")]
	public sbyte Eccentricity
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Eccentricity);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Eccentricity);
		}
	}

	[PropertyInfo("Handling", "Players handling ability (range -127 to 127).")]
	public sbyte Handling
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Handling);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Handling);
		}
	}

	[PropertyInfo("Kicking", "Players kicking ability (range -127 to 127).")]
	public sbyte Kicking
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Kicking);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Kicking);
		}
	}

	[PropertyInfo("One on ones", "Players one on ones ability (range -127 to 127).")]
	public sbyte OneOnOnes
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.OneOnOnes);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.OneOnOnes);
		}
	}

	[PropertyInfo("Reflexes", "Players reflexes (range -127 to 127).")]
	public sbyte Reflexes
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Reflexes);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Reflexes);
		}
	}

	[PropertyInfo("Rushing out", "Players rushing out (range 1 to 20).")]
	public sbyte RushingOut
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.RushingOut);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.RushingOut);
		}
	}

	[PropertyInfo("Tendency to punch", "Players tendency to punch (range 1 to 20).")]
	public sbyte TendencyToPunch
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.TendencyToPunch);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.TendencyToPunch);
		}
	}

	[PropertyInfo("Throwing", "Players throwing ability(range -127 to 127).")]
	public sbyte Throwing
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Throwing);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Throwing);
		}
	}

	public GoalkeepingSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
