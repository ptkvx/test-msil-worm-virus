using System;
using Microsoft.Win32;

namespace ASInstanceRename;

internal class RenameRegistryValueCommand : IInstCommand
{
	private string nameOfSubKey = string.Empty;

	private string nameOfValueSrc = string.Empty;

	private string nameOfValueDest = string.Empty;

	private string description = string.Empty;

	public string Description => description;

	public RenameRegistryValueCommand(string nameOfSubKey, string nameOfValueSrc, string nameOfValueDest, string description)
	{
		Argument.NullCheck(nameOfSubKey, "nameOfSubKey");
		Argument.NullCheck(nameOfValueSrc, "nameOfValueSrc");
		Argument.NullCheck(nameOfValueDest, "nameOfValueDest");
		Argument.NullCheck(description, "description");
		this.nameOfSubKey = nameOfSubKey;
		this.nameOfValueSrc = nameOfValueSrc;
		this.nameOfValueDest = nameOfValueDest;
		if (nameOfValueSrc == nameOfValueDest)
		{
			throw new ArgumentException("Names of values should be different.");
		}
		this.description = description;
	}

	public void Execute()
	{
		using RegistryKey registryKey = RegistryHelpers.OpenSubKey(nameOfSubKey, writable: true);
		object value = registryKey.GetValue(nameOfValueSrc);
		if (value == null)
		{
			string message = $"Can't find value {nameOfValueSrc} of registry key {nameOfSubKey}.";
			throw new RegistryManipulationException(message);
		}
		int num = 0;
		try
		{
			registryKey.SetValue(nameOfValueDest, value);
			num++;
			registryKey.DeleteValue(nameOfValueSrc);
			num++;
		}
		finally
		{
			if (num == 1)
			{
				registryKey.DeleteValue(nameOfValueDest);
			}
		}
	}
}
