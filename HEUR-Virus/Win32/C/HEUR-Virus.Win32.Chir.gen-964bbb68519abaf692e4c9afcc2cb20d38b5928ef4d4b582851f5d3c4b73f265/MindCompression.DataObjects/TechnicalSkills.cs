using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's technical skills.")]
public class TechnicalSkills : Skills
{
	[PropertyInfo("Corners", "Players corners (range 1 to 20).")]
	public sbyte Corners
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Corners);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Corners);
		}
	}

	[PropertyInfo("Crossing", "Players crossing ability (range -127 to 127).")]
	public sbyte Crossing
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Crossing);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Crossing);
		}
	}

	[PropertyInfo("Dribbling", "Players dribbling ability (range -127 to 127).")]
	public sbyte Dribbling
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Dribbling);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Dribbling);
		}
	}

	[PropertyInfo("Finishing", "Players finishing ability (range -127 to 127).")]
	public sbyte Finishing
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Finishing);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Finishing);
		}
	}

	[PropertyInfo("First touch", "Players first touch (range -127 to 127).")]
	public sbyte FirstTouch
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.FirstTouch);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.FirstTouch);
		}
	}

	[PropertyInfo("Free kicks", "Players free kicks ability (range 1 to 20).")]
	public sbyte Freekicks
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Freekicks);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Freekicks);
		}
	}

	[PropertyInfo("Heading", "Players heading ability (range -127 to 127).")]
	public sbyte Heading
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Heading);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Heading);
		}
	}

	[PropertyInfo("Long shots", "Players long shot ability (range -127 to 127).")]
	public sbyte LongShots
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.LongShots);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.LongShots);
		}
	}

	[PropertyInfo("Long throws", "Players long throwing ability (range 1 to 20).")]
	public sbyte Longthrows
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Longthrows);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Longthrows);
		}
	}

	[PropertyInfo("Marking", "Players marking ability (range -127 to 127).")]
	public sbyte Marking
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Marking);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Marking);
		}
	}

	[PropertyInfo("Passing", "Players passing ability (range -127 to 127).")]
	public sbyte Passing
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Passing);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Passing);
		}
	}

	[PropertyInfo("Penalty taking", "Players penalty ability (range 1 to 20).")]
	public sbyte PenaltyTaking
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.PenaltyTaking);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.PenaltyTaking);
		}
	}

	[PropertyInfo("Tackling", "Players tackling ability (range -127 to 127).")]
	public sbyte Tackling
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Tackling);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Tackling);
		}
	}

	[PropertyInfo("Technique", "Players technique (range -127 to 127).")]
	public sbyte Technique
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Technique);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Technique);
		}
	}

	public TechnicalSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
