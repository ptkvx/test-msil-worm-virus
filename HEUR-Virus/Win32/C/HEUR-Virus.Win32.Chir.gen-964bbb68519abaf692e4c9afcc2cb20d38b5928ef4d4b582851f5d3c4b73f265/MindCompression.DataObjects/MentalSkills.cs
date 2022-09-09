using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's mental skills.")]
public class MentalSkills : Skills
{
	[PropertyInfo("Aggression", "Players aggression (range 1 to 20).")]
	public sbyte Aggression
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Aggression);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Aggression);
		}
	}

	[PropertyInfo("Anticipation", "Players anticipation (range -127 to 127).")]
	public sbyte Anticipation
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Anticipation);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Anticipation);
		}
	}

	[PropertyInfo("Bravery", "Players bravery (range 1 to 20).")]
	public sbyte Bravery
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Bravery);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Bravery);
		}
	}

	[PropertyInfo("Composure", "Players composure (range -127 to 127).")]
	public sbyte Composure
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Composure);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Composure);
		}
	}

	[PropertyInfo("Concentration", "Players concentration (range -127 to 127).")]
	public sbyte Concentration
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Concentration);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Concentration);
		}
	}

	[PropertyInfo("Creativity", "Players creativity (range -127 to 127).")]
	public sbyte Creativity
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Creativity);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Creativity);
		}
	}

	[PropertyInfo("Decisions", "Players decisions (range -127 to 127).")]
	public sbyte Decisions
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Decisions);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Decisions);
		}
	}

	[PropertyInfo("Determination", "Players determination (range 1 to 20).")]
	public sbyte Determination
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Determination);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Determination);
		}
	}

	[PropertyInfo("Flair", "Players flair (range 1 to 20).")]
	public sbyte Flair
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Flair);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Flair);
		}
	}

	[PropertyInfo("Influence", "Players influence (range 1 to 20).")]
	public sbyte Influence
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Influence);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Influence);
		}
	}

	[PropertyInfo("Off the ball", "Players off the ball ability (range -127 to 127).")]
	public sbyte OffTheBall
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.OffTheBall);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.OffTheBall);
		}
	}

	[PropertyInfo("Positioning", "Players positioning ability (range -127 to 127).")]
	public sbyte Positioning
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Positioning);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Positioning);
		}
	}

	[PropertyInfo("Teamwork", "Players teamwork ability (range 1 to 20).")]
	public sbyte Teamwork
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Teamwork);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Teamwork);
		}
	}

	[PropertyInfo("Work rate", "Players work rate (range 1 to 20).")]
	public sbyte Workrate
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Workrate);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Workrate);
		}
	}

	public MentalSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
