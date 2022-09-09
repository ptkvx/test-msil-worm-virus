namespace ASInstanceRename;

internal class UnregisterPerfCountersCommand : IInstCommand
{
	private string serviceName = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public UnregisterPerfCountersCommand(string serviceName, string description)
	{
		Argument.NullCheck(serviceName, "serviceName");
		Argument.NullCheck(description, "description");
		this.serviceName = serviceName;
		this.description = description;
	}

	public void Execute()
	{
		string text = $"xx \"{serviceName}\"";
		int num = UnsafeNativeMethods.UnloadPerfCounterTextStrings(text, quietMod: true);
		if (num != 0)
		{
			string nameOfMethod = $"UnloadPerfCounterTextStrings for command line {text}";
			throw new Win32Exception(nameOfMethod, num);
		}
	}
}
