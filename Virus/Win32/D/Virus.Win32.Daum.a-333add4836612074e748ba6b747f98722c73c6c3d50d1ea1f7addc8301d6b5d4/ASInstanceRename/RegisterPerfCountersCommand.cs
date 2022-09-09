namespace ASInstanceRename;

internal class RegisterPerfCountersCommand : IInstCommand
{
	private string fileName = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public RegisterPerfCountersCommand(string fileName, string description)
	{
		Argument.NullCheck(fileName, "fileName");
		Argument.NullCheck(description, "description");
		this.fileName = fileName;
		this.description = description;
	}

	public void Execute()
	{
		string commandLine = $"xx \"{fileName}\"";
		int num = UnsafeNativeMethods.LoadPerfCounterTextStrings(commandLine, quietMod: true);
		if (num != 0)
		{
			string nameOfMethod = $"LoadPerfCounterTextStrings for file {fileName}";
			throw new Win32Exception(nameOfMethod, num);
		}
	}
}
