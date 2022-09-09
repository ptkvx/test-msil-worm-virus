using System;
using System.Runtime.InteropServices;

namespace hpCasl;

public class GClass2
{
	public struct GStruct0
	{
		public IntPtr intptr_0;

		public int int_0;

		public IntPtr intptr_1;
	}

	public const int int_0 = 74;

	public const string string_0 = "hpNotification.c9c74d8c-a080-41c1-8521-4148c8764789";

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string string_1, string string_2);

	[DllImport("user32.dll")]
	public static extern bool IsWindow(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	public static bool smethod_0(string string_1)
	{
		IntPtr intptr_ = FindWindow(null, "hpNotification.c9c74d8c-a080-41c1-8521-4148c8764789");
		bool result = false;
		if (IsWindow(intptr_))
		{
			GStruct0 gStruct = default(GStruct0);
			gStruct.intptr_0 = (IntPtr)1;
			gStruct.int_0 = (string_1.Length + 1) * 2;
			gStruct.intptr_1 = Marshal.StringToHGlobalUni(string_1);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)gStruct));
			Marshal.StructureToPtr((object)gStruct, intPtr, fDeleteOld: true);
			SendMessage(intptr_, 74u, IntPtr.Zero, intPtr);
			Marshal.FreeHGlobal(gStruct.intptr_1);
			Marshal.FreeHGlobal(intPtr);
			result = true;
		}
		return result;
	}
}
