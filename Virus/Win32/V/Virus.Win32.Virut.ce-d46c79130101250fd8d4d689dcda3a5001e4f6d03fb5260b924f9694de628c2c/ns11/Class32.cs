using System;
using System.Runtime.InteropServices;
using ns14;
using ns9;

namespace ns11;

internal sealed class Class32 : Class25
{
	public Class32()
	{
		Class35.smethod_0();
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
