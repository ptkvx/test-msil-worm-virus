using System.Collections;
using System.ComponentModel;

namespace MindCompression.DataObjects;

public class Team : FmObject, ITeam
{
	private int _clubAddress;

	private int _kitAddress;

	private int _financeAddress;

	private int _sponsorAddress;

	private int _playersAddress;

	private Finances _finances;

	[NameValueListType(typeof(ClubStatus))]
	[PropertyInfo("Status", "The clubs status")]
	[ExtendedCategory("General club information", 3)]
	[TypeConverter(typeof(CustomStringListConverter))]
	public byte Status
	{
		get
		{
			return base.ProcMemory.ReadByte(_clubAddress + ClubOffsets.Status);
		}
		set
		{
			base.ProcMemory.WriteByte(value, _clubAddress + ClubOffsets.Status);
		}
	}

	[PropertyInfo("Training ground", "The clubs training ground & facilities")]
	[TypeConverter(typeof(CustomStringListConverter))]
	[NameValueListType(typeof(ClubTrainingGround))]
	[ExtendedCategory("General club information", 3)]
	public byte TrainingGround
	{
		get
		{
			return base.ProcMemory.ReadByte(_clubAddress + ClubOffsets.TrainingGround);
		}
		set
		{
			base.ProcMemory.WriteByte(value, _clubAddress + ClubOffsets.TrainingGround);
		}
	}

	[ExtendedCategory("Stadium", 4)]
	[PropertyInfo("Average attendance", "The clubs average attendance")]
	public int AverageAttendance
	{
		get
		{
			return base.ProcMemory.ReadInt32(_clubAddress + ClubOffsets.AverageAttendance);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, _clubAddress + ClubOffsets.AverageAttendance);
		}
	}

	[PropertyInfo("Minimum attendance", "The clubs minimum attendance")]
	[ExtendedCategory("Stadium", 4)]
	public int MinimumAttendance
	{
		get
		{
			return base.ProcMemory.ReadInt32(_clubAddress + ClubOffsets.MinimumAttendance);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, _clubAddress + ClubOffsets.MinimumAttendance);
		}
	}

	[ExtendedCategory("Stadium", 4)]
	[PropertyInfo("Maximum attendance", "The clubs maximum attendance")]
	public int MaximumAttendance
	{
		get
		{
			return base.ProcMemory.ReadInt32(_clubAddress + ClubOffsets.MaximumAttendance);
		}
		set
		{
			base.ProcMemory.WriteInt32(value, _clubAddress + ClubOffsets.MaximumAttendance);
		}
	}

	[PropertyInfo("Finances", 4)]
	[ExtendedCategory("General club information", 3)]
	public Finances Finances => _finances;

	public Team(FmObject obj)
		: base(obj.Address, obj.Name, obj.Type, obj.ProcMemory, obj.Id)
	{
		_clubAddress = base.ProcMemory.ReadInt32(base.Address + TeamOffsets.ClubAddress);
		_kitAddress = base.ProcMemory.ReadInt32(_clubAddress + ClubOffsets.KitAddress);
		_financeAddress = base.ProcMemory.ReadInt32(_clubAddress + ClubOffsets.FinanceAddress);
		_sponsorAddress = base.ProcMemory.ReadInt32(_clubAddress + ClubOffsets.SponsorAddress);
		_playersAddress = base.ProcMemory.ReadInt32(base.Address + TeamOffsets.PlayersAddress);
		_finances = new Finances(_financeAddress, base.ProcMemory);
	}

	public ArrayList GetPlayersFromTeam()
	{
		byte b = base.ProcMemory.ReadByte(base.Address + TeamOffsets.NumberOfPlayers);
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < b; i++)
		{
			int address = base.ProcMemory.ReadInt32(_playersAddress + i * 4);
			FmObject personByAddress = Person.GetPersonByAddress(address);
			if (personByAddress != null)
			{
				arrayList.Add(personByAddress);
			}
		}
		return arrayList;
	}

	public static Team GetTeamByAddress(int address)
	{
		ArrayList arrayList = new ArrayList();
		arrayList.AddRange(FmObjectLists.Instance.GetList(FmObjectType.Team));
		foreach (FmObject item in arrayList)
		{
			if (item.Address == address)
			{
				return new Team(item);
			}
		}
		return null;
	}
}
