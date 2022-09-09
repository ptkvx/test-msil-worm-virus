using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace ns0;

public abstract class GClass0
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	public sealed class GClass2 : SafeHandleZeroOrMinusOneIsInvalid
	{
		private GClass2()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return GClass3.FreeLibrary(handle);
		}
	}

	public sealed class GClass3
	{
		private const string string_0 = "kernel32";

		[DebuggerNonUserCode]
		public GClass3()
		{
		}

		[DllImport("kernel32", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
		public static extern GClass2 LoadLibrary(string string_1);

		[DllImport("kernel32", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr intptr_0);

		[DllImport("kernel32")]
		public static extern IntPtr GetProcAddress(GClass2 gclass2_0, string string_1);
	}

	[DebuggerNonUserCode]
	public GClass0()
	{
	}

	public Delegate method_0(string string_0, string string_1, Type type_0)
	{
		string string_2 = Class13.smethod_0(string_0);
		string string_3 = Class13.smethod_0(string_1);
		GClass2 gClass = GClass3.LoadLibrary(string_2);
		Delegate result = null;
		if ((!gClass.IsInvalid && !gClass.IsClosed) ? true : false)
		{
			IntPtr procAddress = GClass3.GetProcAddress(gClass, string_3);
			result = Marshal.GetDelegateForFunctionPointer(procAddress, type_0);
			gClass.Close();
		}
		return result;
	}
}
