using System;
using System.ComponentModel;
using MindCompression.Utils;

namespace MindCompression.DataObjects;

public class Coach : Person, ICoach
{
	private CoachingSkills _coskills;

	private CoachMentalSkills _cmskills;

	public override string FirstName
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + CoachOffsets.FirstName);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override string LastName
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + CoachOffsets.LastName);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override string Nickname
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + CoachOffsets.Nickname);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override DateTime DateOfBirth
	{
		get
		{
			return base.ProcMemory.ReadDateTime(base.Address + CoachOffsets.DateOfBirth);
		}
		set
		{
			base.ProcMemory.WriteDateTime(value, base.Address + CoachOffsets.DateOfBirth);
		}
	}

	public override byte InternationalCaps
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + CoachOffsets.InternationalCaps);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + CoachOffsets.InternationalCaps);
		}
	}

	public override byte InternationalGoals
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + CoachOffsets.InternationalGoals);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + CoachOffsets.InternationalGoals);
		}
	}

	public override byte U21InternationalCaps
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + CoachOffsets.U21InternationalCaps);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + CoachOffsets.U21InternationalCaps);
		}
	}

	public override byte U21InternationalGoals
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + CoachOffsets.U21InternationalGoals);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + CoachOffsets.U21InternationalGoals);
		}
	}

	[FmObjectListType(FmObjectType.Country)]
	[TypeConverter(typeof(FmObjectListConverter))]
	public override int Nationality
	{
		get
		{
			return base.ProcMemory.ReadInt32(base.Address + CoachOffsets.Nationality);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, base.Address + CoachOffsets.Nationality, reverse: false);
		}
	}

	[FmObjectListType(FmObjectType.City)]
	[TypeConverter(typeof(FmObjectListConverter))]
	public override int CityOfBirth
	{
		get
		{
			return base.ProcMemory.ReadInt32(base.Address + CoachOffsets.CityOfBirth);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, base.Address + CoachOffsets.CityOfBirth, reverse: false);
		}
	}

	[ExtendedCategory("General coaching information", 4)]
	[PropertyInfo("Current coaching ability", "The coach's current ability (range 1-200).", 1)]
	public int CurrentCoachingAbility
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + CoachOffsets.CurrentCoachingAbility);
		}
		set
		{
			base.ProcMemory.WriteInt16(value, base.Address + CoachOffsets.CurrentCoachingAbility);
		}
	}

	[ExtendedCategory("General coaching information", 4)]
	[PropertyInfo("Potential coaching ability", "The coach's potential ability (range 1-200).", 2)]
	public int PotentialCoachingAbility
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + CoachOffsets.PotentialCoachingAbility);
		}
		set
		{
			base.ProcMemory.WriteInt16(value, base.Address + CoachOffsets.PotentialCoachingAbility);
		}
	}

	[PropertyInfo("Mental attributes")]
	[ExtendedCategory("Coaching attributes", 5)]
	public CoachMentalSkills CoachMentalSkills => _cmskills;

	[ExtendedCategory("Coaching attributes", 5)]
	[PropertyInfo("General attributes")]
	public CoachingSkills CoachingSkills => _coskills;

	public Coach(FmObject obj)
		: base(obj)
	{
		_cmskills = new CoachMentalSkills(base.ProcMemory.ReadInt32(base.Address + CoachOffsets.SkillsAdress), base.ProcMemory);
		_coskills = new CoachingSkills(base.ProcMemory.ReadInt32(base.Address + CoachOffsets.SkillsAdress), base.ProcMemory);
	}
}
