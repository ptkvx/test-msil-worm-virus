using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class0
{
	private static IntPtr smethod_0(object object_0)
	{
		GCHandle gCHandle = GCHandle.Alloc(RuntimeHelpers.GetObjectValue(object_0), GCHandleType.Pinned);
		try
		{
			return gCHandle.AddrOfPinnedObject();
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool UpdateResource(IntPtr intptr_0, string string_0, string string_1, ushort ushort_0, IntPtr intptr_1, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool EndUpdateResource(IntPtr intptr_0, bool bool_0);

	public static bool smethod_1(string string_0, byte[] byte_0, int int_0)
	{
		try
		{
			IntPtr intptr_ = BeginUpdateResource(string_0, bool_0: false);
			IntPtr intptr_2 = smethod_0(byte_0);
			UpdateResource(intptr_, "File_Info", int_0.ToString(), 0, intptr_2, Convert.ToUInt32(byte_0.Length));
			EndUpdateResource(intptr_, bool_0: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}
}
