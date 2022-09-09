using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace ODPReg;

public class RegUtility
{
	internal static int RegFile(string assembly)
	{
		IRegister ppAsmCache = null;
		int num = CreateAssemblyCache(out ppAsmCache, 0u);
		if (num != 0)
		{
			return num;
		}
		return ppAsmCache.InstallAssembly(0u, assembly, (IntPtr)0);
	}

	internal static int UnRegFile(string assembly)
	{
		IRegister ppAsmCache = null;
		int num = CreateAssemblyCache(out ppAsmCache, 0u);
		if (num != 0)
		{
			return num;
		}
		uint pulDisposition;
		return ppAsmCache.UninstallAssembly(0u, assembly, (IntPtr)0, out pulDisposition);
	}

	public static string GetFileRegInfo(string filename)
	{
		string text = "";
		string text2 = "FusionInstall: " + Guid.NewGuid();
		string fullPath = Path.GetFullPath(filename);
		Evidence evidence = null;
		AppDomain appDomain = AppDomain.CreateDomain(text2, evidence);
		if (appDomain == null)
		{
			throw new ApplicationException("Unable to create AppDomain for assembly cache install ");
		}
		Util util = (Util)appDomain.CreateInstanceAndUnwrap(Assembly.GetAssembly(typeof(Util))!.FullName, typeof(Util).FullName);
		text = util.FullAssemblyName(fullPath);
		AppDomain.Unload(appDomain);
		return text;
	}

	[DllImport("Fusion.dll", CharSet = CharSet.Auto)]
	internal static extern int CreateAssemblyCache(out IRegister ppAsmCache, uint dwReserved);
}
