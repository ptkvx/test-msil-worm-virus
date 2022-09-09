using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's physical skills.")]
public class PhysicalSkills : Skills
{
	[PropertyInfo("Acceleration", "Players acceleration (range 1-20).")]
	public sbyte Acceleration
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Acceleration);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Acceleration);
		}
	}

	[PropertyInfo("Agility", "Players agility (range 1-20).")]
	public sbyte Agility
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Agility);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Agility);
		}
	}

	[PropertyInfo("Balance", "Players balance (range 1-20).")]
	public sbyte Balance
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Balance);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Balance);
		}
	}

	[PropertyInfo("Jumping", "Players jumping ability (range 1-20).")]
	public sbyte Jumping
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Jumping);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Jumping);
		}
	}

	[PropertyInfo("Natural fitness", "Players natural fitness (range 1-20).")]
	public sbyte NaturalFitness
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.NaturalFitness);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.NaturalFitness);
		}
	}

	[PropertyInfo("Pace", "Players pace (range 1-20).")]
	public sbyte Pace
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Pace);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Pace);
		}
	}

	[PropertyInfo("Stamina", "Players stamina (range 1-20).")]
	public sbyte Stamina
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Stamina);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Stamina);
		}
	}

	[PropertyInfo("Strength", "Players strength (range 1-20).")]
	public sbyte Strength
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Strength);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Strength);
		}
	}

	public PhysicalSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
