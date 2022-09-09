using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's hidden skills.")]
public class HiddenSkills : Skills
{
	[PropertyInfo("Consistency", "Players consistency (range 1-20).")]
	public sbyte Consistency
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Consistency);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Consistency);
		}
	}

	[PropertyInfo("Dirtyness", "Players dirtyness (range 1-20).")]
	public sbyte Dirtyness
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Dirtyness);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Dirtyness);
		}
	}

	[PropertyInfo("Important matches", "Players important matches (range 1-20).")]
	public sbyte ImportantMatches
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.ImportantMatches);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.ImportantMatches);
		}
	}

	[PropertyInfo("Injury proness", "Players injury proness (range 1-20).")]
	public sbyte InjuryProness
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.InjuryProness);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.InjuryProness);
		}
	}

	[PropertyInfo("Versatility", "Players versatility (range 1-20).")]
	public sbyte Versatility
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + SkillOffsets.Versatility);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + SkillOffsets.Versatility);
		}
	}

	public HiddenSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
