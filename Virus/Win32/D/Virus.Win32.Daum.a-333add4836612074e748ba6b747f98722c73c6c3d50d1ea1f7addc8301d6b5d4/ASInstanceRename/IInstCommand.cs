namespace ASInstanceRename;

internal interface IInstCommand
{
	string Description { get; }

	void Execute();
}
