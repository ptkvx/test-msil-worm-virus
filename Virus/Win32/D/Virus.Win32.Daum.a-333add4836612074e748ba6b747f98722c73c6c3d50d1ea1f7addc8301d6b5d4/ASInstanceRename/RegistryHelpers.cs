using Microsoft.Win32;

namespace ASInstanceRename;

internal class RegistryHelpers
{
	public static RegistryKey OpenSubKey(string path)
	{
		return OpenSubKey(path, writable: false);
	}

	public static RegistryKey OpenSubKey(string path, bool writable)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(path, writable);
		if (registryKey == null)
		{
			string message = $"Can't open registry key {path} under HKEY_LOCAL_MACHINE.";
			throw new RegistryManipulationException(message);
		}
		return registryKey;
	}
}
