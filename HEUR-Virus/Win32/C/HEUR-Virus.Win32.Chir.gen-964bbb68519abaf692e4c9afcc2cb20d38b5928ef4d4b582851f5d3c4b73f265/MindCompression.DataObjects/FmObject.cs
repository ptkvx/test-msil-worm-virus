using System;
using System.ComponentModel;
using MindCompression.Memory;

namespace MindCompression.DataObjects;

public class FmObject : PropertyObject, IComparable, IFmObject
{
	private int _address;

	private string _name;

	private int _id;

	private FmObjectType _type;

	private ProcessMemory _pm;

	protected internal int Address
	{
		get
		{
			return _address;
		}
		set
		{
			_address = value;
		}
	}

	protected internal ProcessMemory ProcMemory
	{
		get
		{
			return _pm;
		}
		set
		{
			_pm = value;
		}
	}

	[ExtendedCategory("General", 2)]
	[ReadOnly(true)]
	public FmObjectType Type => _type;

	[ExtendedCategory("General", 2)]
	[ReadOnly(true)]
	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	[ExtendedCategory("General", 2)]
	[ReadOnly(true)]
	public int Id => _id;

	public FmObject(int address, string name, FmObjectType type, ProcessMemory pm)
	{
		_address = address;
		_name = name;
		_type = type;
		_pm = pm;
		_id = -1;
	}

	public FmObject(int address, string name, FmObjectType type, ProcessMemory pm, int id)
		: this(address, name, type, pm)
	{
		_id = id;
	}

	public override string ToString()
	{
		return Name;
	}

	public FmObject ExpandObject()
	{
		return Type switch
		{
			FmObjectType.Team => new Team(this), 
			FmObjectType.Country => new Country(this), 
			FmObjectType.City => new City(this), 
			FmObjectType.PlayerCoach => new PlayerCoach(this), 
			FmObjectType.Coach => new Coach(this), 
			FmObjectType.Player => new Player(this), 
			_ => this, 
		};
	}

	public int CompareTo(object obj)
	{
		return ToString().CompareTo(obj.ToString());
	}
}
