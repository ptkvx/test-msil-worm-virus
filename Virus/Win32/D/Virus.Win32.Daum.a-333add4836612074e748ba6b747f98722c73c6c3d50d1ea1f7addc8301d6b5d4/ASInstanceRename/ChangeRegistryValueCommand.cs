using Microsoft.Win32;

namespace ASInstanceRename;

internal class ChangeRegistryValueCommand : IInstCommand
{
	private string nameOfSubKey = string.Empty;

	private string nameOfValue = string.Empty;

	private object value = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public ChangeRegistryValueCommand(string nameOfSubKey, string nameOfValue, object value, string description)
	{
		Argument.NullCheck(nameOfSubKey, "nameOfSubKey");
		Argument.NullCheck(value, "value");
		Argument.NullCheck(description, "description");
		this.nameOfSubKey = nameOfSubKey;
		this.nameOfValue = nameOfValue;
		this.value = value;
		this.description = description;
	}

	public void Execute()
	{
		using RegistryKey registryKey = RegistryHelpers.OpenSubKey(nameOfSubKey, writable: true);
		registryKey.SetValue(nameOfValue, value);
	}
}
