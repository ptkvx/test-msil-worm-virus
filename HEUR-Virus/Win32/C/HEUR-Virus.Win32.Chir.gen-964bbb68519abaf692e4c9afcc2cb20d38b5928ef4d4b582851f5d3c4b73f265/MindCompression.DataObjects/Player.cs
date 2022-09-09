using System;
using System.ComponentModel;
using MindCompression.Utils;

namespace MindCompression.DataObjects;

public class Player : Person, IPlayer
{
	private GoalkeepingSkills _gkskills;

	private MentalSkills _mskills;

	private PositionalSkills _poskills;

	private NewPositionalSkills _newposskills;

	private TechnicalSkills _tskills;

	private PhysicalSkills _phskills;

	private HiddenSkills _hdskills;

	private Contract _contract;

	private int _contractAddress;

	private int _injuryAddress;

	public override string FirstName
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.FirstName);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override string LastName
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.LastName);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override string Nickname
	{
		get
		{
			int addr = base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.Nickname);
			return FmMemory.GetName(base.ProcMemory, addr, 28, 8);
		}
	}

	public override DateTime DateOfBirth
	{
		get
		{
			return base.ProcMemory.ReadDateTime(base.Address + PlayerOffsets.DateOfBirth);
		}
		set
		{
			base.ProcMemory.WriteDateTime(value, base.Address + PlayerOffsets.DateOfBirth);
		}
	}

	public override byte InternationalCaps
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerOffsets.InternationalCaps);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerOffsets.InternationalCaps);
		}
	}

	public override byte InternationalGoals
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerOffsets.InternationalGoals);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerOffsets.InternationalGoals);
		}
	}

	public override byte U21InternationalCaps
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerOffsets.U21InternationalCaps);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerOffsets.U21InternationalCaps);
		}
	}

	public override byte U21InternationalGoals
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerOffsets.U21InternationalGoals);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerOffsets.U21InternationalGoals);
		}
	}

	[FmObjectListType(FmObjectType.Country)]
	[TypeConverter(typeof(FmObjectListConverter))]
	public override int Nationality
	{
		get
		{
			return base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.Nationality);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, base.Address + PlayerOffsets.Nationality, reverse: false);
		}
	}

	[TypeConverter(typeof(FmObjectListConverter))]
	[FmObjectListType(FmObjectType.City)]
	public override int CityOfBirth
	{
		get
		{
			return base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.CityOfBirth);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, base.Address + PlayerOffsets.CityOfBirth, reverse: false);
		}
	}

	[PropertyInfo("Current ability", "The players current ability (range 1-200).")]
	[ExtendedCategory("General playing information", 3)]
	public int CurrentPlayingAbility
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerOffsets.CurrentPlayingAbility);
		}
		set
		{
			base.ProcMemory.WriteInt16(value, base.Address + PlayerOffsets.CurrentPlayingAbility);
		}
	}

	[PropertyInfo("Potential ability", "The players maximum ability (range 1-200).")]
	[ExtendedCategory("General playing information", 3)]
	public int PotentialPlayingAbility
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerOffsets.PotentialPlayingAbility);
		}
		set
		{
			base.ProcMemory.WriteInt16(value, base.Address + PlayerOffsets.PotentialPlayingAbility);
		}
	}

	[ExtendedCategory("General playing information", 3)]
	[PropertyInfo("Condition", "The persons condition (range 1-100%).")]
	public int Condition
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerOffsets.Condition) / 100;
		}
		set
		{
			base.ProcMemory.WriteInt16(value * 100, base.Address + PlayerOffsets.Condition);
		}
	}

	[ExtendedCategory("General playing information", 3)]
	[PropertyInfo("Fitness", "The persons fitness (range 1-100%).")]
	public int Fitness
	{
		get
		{
			return base.ProcMemory.ReadInt16(base.Address + PlayerOffsets.Fitness) / 100;
		}
		set
		{
			base.ProcMemory.WriteInt16(value * 100, base.Address + PlayerOffsets.Fitness);
		}
	}

	[PropertyInfo("Morale", "The persons morale (range 1-20).")]
	[ExtendedCategory("General playing information", 3)]
	public byte Morale
	{
		get
		{
			return base.ProcMemory.ReadByte(base.Address + PlayerOffsets.Morale);
		}
		set
		{
			base.ProcMemory.WriteByte(value, base.Address + PlayerOffsets.Morale);
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

	[PropertyInfo("Technical attributes", 4)]
	[ExtendedCategory("Playing attributes", 4)]
	public TechnicalSkills TechnicalSkills => _tskills;

	[ExtendedCategory("Playing attributes", 4)]
	[PropertyInfo("Mental attributes", 5)]
	public MentalSkills MentalSkills => _mskills;

	[PropertyInfo("Physical attributes", 6)]
	[ExtendedCategory("Playing attributes", 4)]
	public PhysicalSkills PhysicalSkills => _phskills;

	[PropertyInfo("Hidden attributes", 7)]
	[ExtendedCategory("Playing attributes", 4)]
	public HiddenSkills HiddenSkills => _hdskills;

	public Player(FmObject obj)
		: base(obj)
	{
		_gkskills = new GoalkeepingSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_mskills = new MentalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_poskills = new PositionalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_newposskills = new NewPositionalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_tskills = new TechnicalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_phskills = new PhysicalSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_hdskills = new HiddenSkills(base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.SkillsAddress), base.ProcMemory);
		_injuryAddress = base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.InjuryAddress);
		if (base.ProcMemory.ReadByte(base.Address + PlayerOffsets.ContractAddress + 4) == 1)
		{
			_contractAddress = base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.ContractAddress);
			_contractAddress = base.ProcMemory.ReadInt32(_contractAddress);
			_contract = new Contract(_contractAddress, base.ProcMemory);
		}
	}

	public static Player GetPlayerByAddress(int address)
	{
		foreach (FmObject item in FmObjectLists.Instance.GetList(FmObjectType.Player))
		{
			if (item.Address == address)
			{
				return item as Player;
			}
		}
		return null;
	}

	public Team GetTeamFromPlayer()
	{
		int address = base.ProcMemory.ReadInt32(base.Address + PlayerOffsets.Team);
		return Team.GetTeamByAddress(address);
	}

	public void Heal()
	{
		base.ProcMemory.WriteByte(0, _injuryAddress + 12);
	}
}
