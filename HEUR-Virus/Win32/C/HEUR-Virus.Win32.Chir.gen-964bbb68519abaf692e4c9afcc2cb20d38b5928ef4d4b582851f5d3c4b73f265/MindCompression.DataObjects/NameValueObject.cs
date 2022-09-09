namespace MindCompression.DataObjects;

public class NameValueObject
{
	private string _name;

	private byte _value;

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

	public byte Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public NameValueObject(string name, byte value)
	{
		_name = name;
		_value = value;
	}

	public override string ToString()
	{
		return Name;
	}
}
