using Microsoft.Win32;

namespace ASInstanceRename;

internal class DeleteRegistryKeyCommand : IInstCommand
{
	private string nameOfKey = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public DeleteRegistryKeyCommand(string nameOfKey, string description)
	{
		Argument.NullCheck(nameOfKey, "nameOfKey");
		Argument.NullCheck(description, "description");
		this.nameOfKey = nameOfKey;
		this.description = description;
	}

	public void Execute()
	{
		Registry.LocalMachine.DeleteSubKey(nameOfKey, throwOnMissingSubKey: true);
	}
}
