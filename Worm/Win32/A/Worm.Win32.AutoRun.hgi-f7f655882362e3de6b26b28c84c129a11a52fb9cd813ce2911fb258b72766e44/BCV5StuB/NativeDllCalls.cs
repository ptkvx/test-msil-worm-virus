using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace BCV5StuB;

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
		private const string KERNEL32 = "kernel32";

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
		string fileName = HexToString(sHexLib);
		string procname = HexToString(sHexMethod);
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

	public string HexToString(string sText)
	{
		string text = sText;
		string text2 = "";
		string text3 = "";
		if (text.StartsWith("0x"))
		{
			text = text.Substring(2);
		}
		for (int i = 0; i < text.Length; i = checked(i + 2))
		{
			text3 = text.Substring(i, 2);
			text2 += Conversions.ToString(Strings.ChrW((int)ushort.Parse(text3, NumberStyles.HexNumber)));
		}
		return text2;
	}
}
