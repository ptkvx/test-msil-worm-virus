namespace ASInstanceRename;

internal class NopCommand : IInstCommand
{
	public string Description => string.Empty;

	public void Execute()
	{
	}
}
