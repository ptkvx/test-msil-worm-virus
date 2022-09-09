using System;
using System.ComponentModel;
using MindCompression.Utils;

namespace MindCompression.DataObjects;

public class PlayerCoach : Person, IPlayer, ICoach
{
	private GoalkeepingSkills _gkskills;

	private MentalSkills _mskills;

	private PositionalSkills _poskills;

	private NewPositionalSkills _newposskills;

	private TechnicalSkills _tskills;

	private PhysicalSkills _phskills;

	private HiddenSkills _hdskills;

	private CoachingSkills _coskills;

	private CoachMentalSkills _cmskills;

	private Contract _contract;

	private int _contractAddress;

	private int _injuryAddress;

	public override string FirstName
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.FirstName);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override string LastName
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.LastName);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override string Nickname
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.Nickname);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override DateTime DateOfBirth
	{
		get
		{
			return base.ProcMemory.ReadDateTime(base.Address + PlayerCoachOffsets.DateOfBirth);
		}
		set
		{
			base.ProcMemory.WriteDateTime(value, base.Address + PlayerCoachOffsets.DateOfBirth);
		}
	}

	public override byte InternationalCaps
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerCoachOffsets.InternationalCaps);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerCoachOffsets.InternationalCaps);
		}
	}

	public override byte InternationalGoals
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerCoachOffsets.InternationalGoals);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerCoachOffsets.InternationalGoals);
		}
	}

	public override byte U21InternationalCaps
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerCoachOffsets.U21InternationalCaps);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerCoachOffsets.U21InternationalCaps);
		}
	}

	public override byte U21InternationalGoals
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerCoachOffsets.U21InternationalGoals);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerCoachOffsets.U21InternationalGoals);
		}
	}

	[FmObjectListType(FmObjectType.Country)]
	[TypeConverter(typeof(FmObjectListConverter))]
	public override int Nationality
	{
		get
		{
			return base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.Nationality);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, base.Address + PlayerCoachOffsets.Nationality, reverse: false);
		}
	}

	[TypeConverter(typeof(FmObjectListConverter))]
	[FmObjectListType(FmObjectType.City)]
	public override int CityOfBirth
	{
		get
		{
			return base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.CityOfBirth);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, base.Address + PlayerCoachOffsets.CityOfBirth, reverse: false);
		}
	}

	[Browsable(false)]
	public int CurrentCoachingAbility
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[Browsable(false)]
	public int PotentialCoachingAbility
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[ExtendedCategory("Coaching attributes", 5)]
	[PropertyInfo("Mental attributes")]
	public CoachMentalSkills CoachMentalSkills => _cmskills;

	[ExtendedCategory("Coaching attributes", 5)]
	[PropertyInfo("General attributes")]
	public CoachingSkills CoachingSkills => _coskills;

	[PropertyInfo("Current ability", "The players current ability (range 1-200).")]
	[ExtendedCategory("General playing information", 3)]
	public int CurrentPlayingAbility
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerCoachOffsets.CurrentPlayingAbility);
		}
		set
		{
			base.ProcMemory.WriteInt16(value, base.Address + PlayerCoachOffsets.CurrentPlayingAbility);
		}
	}

	[PropertyInfo("Potential ability", "The players maximum ability (range 1-200).")]
	[ExtendedCategory("General playing information", 3)]
	public int PotentialPlayingAbility
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerCoachOffsets.PotentialPlayingAbility);
		}
		set
		{
			base.ProcMemory.WriteInt16(value, base.Address + PlayerCoachOffsets.PotentialPlayingAbility);
		}
	}

	[ExtendedCategory("General playing information", 3)]
	[PropertyInfo("Condition", "The persons condition (range 1-100%).")]
	public int Condition
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerCoachOffsets.Condition) / 100;
		}
		set
		{
			base.ProcMemory.WriteInt16(value * 100, base.Address + PlayerCoachOffsets.Condition);
		}
	}

	[ExtendedCategory("General playing information", 3)]
	[PropertyInfo("Fitness", "The persons fitness (range 1-100%).")]
	public int Fitness
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerCoachOffsets.Fitness) / 100;
		}
		set
		{
			base.ProcMemory.WriteInt16(value * 100, base.Address + PlayerCoachOffsets.Fitness);
		}
	}

	[ExtendedCategory("General playing information", 3)]
	[PropertyInfo("Morale", "The persons morale (range 1-20).")]
	public byte Morale
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerCoachOffsets.Morale);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerCoachOffsets.Morale);
		}
	}

	[ExtendedCategory("General playing information", 3)]
	[PropertyInfo("Contract")]
	public Contract Contract => _contract;

	[PropertyInfo("Position", 1)]
	[ExtendedCategory("Playing attributes", 4)]
	public PositionalSkills PositionalSkills => _poskills;

	[PropertyInfo("New position", 2)]
	[ExtendedCategory("Playing attributes", 4)]
	public NewPositionalSkills NewPositionalSkills => _newposskills;

	[PropertyInfo("Goalkeeping attributes", 3)]
	[ExtendedCategory("Playing attributes", 4)]
	public GoalkeepingSkills GoalkeepingSkills => _gkskills;

	[ExtendedCategory("Playing attributes", 4)]
	[PropertyInfo("Technical attributes", 4)]
	public TechnicalSkills TechnicalSkills => _tskills;

	[ExtendedCategory("Playing attributes", 4)]
	[PropertyInfo("Mental attributes", 5)]
	public MentalSkills MentalSkills => _mskills;

	[ExtendedCategory("Playing attributes", 4)]
	[PropertyInfo("Physical attributes", 6)]
	public PhysicalSkills PhysicalSkills => _phskills;

	[PropertyInfo("Hidden attributes", 7)]
	[ExtendedCategory("Playing attributes", 4)]
	public HiddenSkills HiddenSkills => _hdskills;

	public PlayerCoach(FmObject obj)
		: base(obj)
	{
		_gkskills = new GoalkeepingSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_mskills = new MentalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_poskills = new PositionalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_newposskills = new NewPositionalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_tskills = new TechnicalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_phskills = new PhysicalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_hdskills = new HiddenSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_coskills = new CoachingSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_cmskills = new CoachMentalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.SkillsAddress), base.ProcMemory);
		_injuryAddress = base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.InjuryAddress);
		if (base.ProcMemory.ReadByte(base.Address + PlayerCoachOffsets.ContractAddress + 4) == 1)
		{
			_contractAddress = base.ProcMemory.ReadInt32(base.Address + PlayerCoachOffsets.ContractAddress);
			_contractAddress = base.ProcMemory.ReadInt32(_contractAddress);
			_contract = new Contract(_contractAddress, base.ProcMemory);
		}
	}

	public void Heal()
	{
		base.ProcMemory.WriteByte(0, _injuryAddress + 12);
	}
}
