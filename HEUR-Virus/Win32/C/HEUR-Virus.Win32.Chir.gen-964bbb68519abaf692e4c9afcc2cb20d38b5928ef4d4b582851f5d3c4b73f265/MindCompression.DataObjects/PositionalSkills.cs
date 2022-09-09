using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's positional skills.")]
public class PositionalSkills : Skills
{
	[PropertyInfo("Goalkeeper", "(range 1-20)", 1)]
	public sbyte Goalkeeper
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Goalkeeper);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Goalkeeper);
		}
	}

	[PropertyInfo("Sweeper", "(range 1-20)", 2)]
	public sbyte Sweeper
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Sweeper);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Sweeper);
		}
	}

	[PropertyInfo("Defender", "(range 1-20)", 3)]
	public sbyte Defender
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Defender);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Defender);
		}
	}

	[PropertyInfo("Defensive midfielder", "(range 1-20)", 4)]
	public sbyte DefensiveMidfielder
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.DefensiveMidfielder);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.DefensiveMidfielder);
		}
	}

	[PropertyInfo("Midfielder", "(range 1-20)", 5)]
	public sbyte Midfielder
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Midfielder);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Midfielder);
		}
	}

	[PropertyInfo("Attacking midfielder", "(range 1-20)", 6)]
	public sbyte AttackingMidfielder
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.AttackingMidfielder);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.AttackingMidfielder);
		}
	}

	[PropertyInfo("Attacker", "(range 1-20)", 7)]
	public sbyte Attacker
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Attacker);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Attacker);
		}
	}

	[PropertyInfo("Wing back", "(range 1-20)", 8)]
	public sbyte WingBack
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.WingBack);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.WingBack);
		}
	}

	[PropertyInfo("Free role", "(range 1-20)", 9)]
	public sbyte FreeRole
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.FreeRole);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.FreeRole);
		}
	}

	[PropertyInfo("Right", "(range 1-20)", 10)]
	public sbyte Right
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Right);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Right);
		}
	}

	[PropertyInfo("Centre", "(range 1-20)", 11)]
	public sbyte Centre
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Centre);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Centre);
		}
	}

	[PropertyInfo("Left", "(range 1-20)", 12)]
	public sbyte Left
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.Left);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.Left);
		}
	}

	public PositionalSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
