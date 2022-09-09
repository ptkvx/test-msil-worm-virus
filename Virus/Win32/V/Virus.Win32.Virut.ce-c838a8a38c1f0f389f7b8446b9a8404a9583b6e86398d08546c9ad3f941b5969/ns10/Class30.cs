using System;
using System.Runtime.InteropServices;
using ns13;
using ns8;

namespace ns10;

internal class Class30 : Class23
{
	public Class30()
	{
		Class33.smethod_0();
		base._002Ector();
	}

	public override object vmethod_0(object[] object_0)
	{
		IntPtr intptr_ = LoadLibrary((string)object_0[0]);
		IntPtr procAddress = GetProcAddress(intptr_, (string)object_0[1]);
		return Marshal.GetDelegateForFunctionPointer(procAddress, (Type)object_0[2]);
	}

	[DllImport("kernel32")]
	private static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);
}
