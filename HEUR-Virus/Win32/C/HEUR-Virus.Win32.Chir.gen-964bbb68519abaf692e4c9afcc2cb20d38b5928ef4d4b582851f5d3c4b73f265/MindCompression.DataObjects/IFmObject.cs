namespace MindCompression.DataObjects;

public interface IFmObject
{
	FmObjectType Type { get; }

	string Name { get; set; }
}
