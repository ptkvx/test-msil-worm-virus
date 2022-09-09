using MindCompression.Memory;

namespace MindCompression.DataObjects;

[ExpandDescription("This player's new positional skills.")]
public class NewPositionalSkills : Skills
{
	[PropertyInfo("Defender left", "(range 1-20)", 1)]
	public sbyte NewDefenderLeft
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewDefLeft);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewDefLeft);
		}
	}

	[PropertyInfo("Defender central", "(range 1-20)", 2)]
	public sbyte NewDefenderCentral
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewDefCentre);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewDefCentre);
		}
	}

	[PropertyInfo("Defender right", "(range 1-20)", 3)]
	public sbyte NewDefenderRight
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewDefRight);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewDefRight);
		}
	}

	[PropertyInfo("Defensive mid. central", "(range 1-20)", 4)]
	public sbyte NewDefensiveMidCentral
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewDefMidCentre);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewDefMidCentre);
		}
	}

	[PropertyInfo("Midfielder left", "(range 1-20)", 5)]
	public sbyte NewMidfielderLeft
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewMidLeft);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewMidLeft);
		}
	}

	[PropertyInfo("Midfielder central", "(range 1-20)", 6)]
	public sbyte NewMidfielderCentral
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewMidCentre);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewMidCentre);
		}
	}

	[PropertyInfo("Midfielder right", "(range 1-20)", 7)]
	public sbyte NewMidfielderRight
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewMidRight);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewMidRight);
		}
	}

	[PropertyInfo("Attacking mid. left", "(range 1-20)", 8)]
	public sbyte NewAttackingMidLeft
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewAttMidLeft);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewAttMidLeft);
		}
	}

	[PropertyInfo("Attacking mid. central", "(range 1-20)", 9)]
	public sbyte NewAttackingMidCentral
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewAttMidCentre);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewAttMidCentre);
		}
	}

	[PropertyInfo("Attacking mid. right", "(range 1-20)", 10)]
	public sbyte NewAttackingMidRight
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewAttMidRight);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewAttMidRight);
		}
	}

	[PropertyInfo("Attacker central", "(range 1-20)", 11)]
	public sbyte NewAttackerCentral
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewAttCentre);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewAttCentre);
		}
	}

	[PropertyInfo("Wing back left", "(range 1-20)", 12)]
	public sbyte NewWingBackLeft
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewWingBackLeft);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewWingBackLeft);
		}
	}

	[PropertyInfo("Wing back right", "(range 1-20)", 13)]
	public sbyte NewWingBackRight
	{
		get
		{
			return base.ProcMemory.ReadSByte(_skillsAddress + PositionOffsets.NewWingBackRight);
		}
		set
		{
			base.ProcMemory.WriteSByte(value, _skillsAddress + PositionOffsets.NewWingBackRight);
		}
	}

	public NewPositionalSkills(int skillsAddress, ProcessMemory pm)
		: base(skillsAddress, pm)
	{
	}
}
