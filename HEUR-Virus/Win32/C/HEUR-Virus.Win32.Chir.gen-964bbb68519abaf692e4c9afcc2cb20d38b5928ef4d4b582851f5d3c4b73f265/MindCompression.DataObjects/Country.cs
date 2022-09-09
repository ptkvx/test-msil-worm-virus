namespace MindCompression.DataObjects;

public class Country : FmObject, ICountry
{
	public Country(FmObject obj)
		: base(obj.Address, obj.Name, obj.Type, obj.ProcMemory, obj.Id)
	{
	}
}
