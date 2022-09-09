using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal static class Strings
{
	internal static readonly string WPFRequired;

	internal static readonly string GraphicalPowerShell;

	internal static readonly string OK;

	internal static readonly string Usage;

	internal static readonly string UnableToRetrieveFullPath;

	internal static readonly string AssemblyCorruptOrMissing;

	static Strings()
	{
		ResourceManager resourceManager = new ResourceManager("GPowerShell", Assembly.GetCallingAssembly());
		WPFRequired = resourceManager.GetString("WPFRequired", Thread.CurrentThread.CurrentUICulture);
		GraphicalPowerShell = resourceManager.GetString("GraphicalPowerShell", Thread.CurrentThread.CurrentUICulture);
		OK = resourceManager.GetString("OK", Thread.CurrentThread.CurrentUICulture);
		Usage = Format(resourceManager.GetString("Usage", Thread.CurrentThread.CurrentUICulture), "powershell_ise.exe");
		AssemblyCorruptOrMissing = resourceManager.GetString("AssemblyCorruptOrMissing", Thread.CurrentThread.CurrentUICulture);
		UnableToRetrieveFullPath = resourceManager.GetString("UnableToRetrieveFullPath", Thread.CurrentThread.CurrentUICulture);
	}

	internal static string Format(string format, params object[] args)
	{
		return string.Format(CultureInfo.CurrentCulture, format, args);
	}
}
