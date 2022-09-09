namespace MindCompression.DataObjects;

public class City : FmObject, ICity
{
	public City(FmObject obj)
		: base(obj.Address, obj.Name, obj.Type, obj.ProcMemory, obj.Id)
	{
	}
}
