using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using ns0;

namespace WindowsApplication;

public abstract class NativeDllCalls
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	public sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		private SafeLibraryHandle()
			: base(ownsHandle: true)
		{
		}

		protected override bool ReleaseHandle()
		{
			return Methods.FreeLibrary(handle);
		}
	}

	public sealed class Methods
	{
		private const string string_0 = "kernel32";

		[DebuggerNonUserCode]
		public Methods()
		{
		}

		[DllImport("kernel32", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
		public static extern SafeLibraryHandle LoadLibrary(string fileName);

		[DllImport("kernel32", SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr hModule);

		[DllImport("kernel32")]
		public static extern IntPtr GetProcAddress(SafeLibraryHandle hModule, string procname);
	}

	[DebuggerNonUserCode]
	public NativeDllCalls()
	{
	}

	public Delegate DynamicCall(string sHexLib, string sHexMethod, Type oType)
	{
		string fileName = Class7.smethod_0(sHexLib);
		string procname = Class7.smethod_0(sHexMethod);
		SafeLibraryHandle safeLibraryHandle = Methods.LoadLibrary(fileName);
		Delegate result = null;
		if (!safeLibraryHandle.IsInvalid && !safeLibraryHandle.IsClosed)
		{
			IntPtr procAddress = Methods.GetProcAddress(safeLibraryHandle, procname);
			result = Marshal.GetDelegateForFunctionPointer(procAddress, oType);
			safeLibraryHandle.Close();
		}
		return result;
	}
}
