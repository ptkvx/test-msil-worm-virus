using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Microsoft.Windows.PowerShell.GuiExe.Internal;

internal static class NativeMethods
{
	internal struct SID_AND_ATTRIBUTES
	{
		public IntPtr Sid;

		public uint Attributes;
	}

	internal struct TOKEN_GROUPSStart
	{
		public int GroupCount;

		public IntPtr Groups;
	}

	internal struct TOKEN_GROUPS
	{
		public int GroupCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public SID_AND_ATTRIBUTES[] FirstGroup;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal class SECURITY_ATTRIBUTES
	{
		public int NLength;

		public IntPtr LPSecurityDescriptor = IntPtr.Zero;

		public bool InheritHandle;

		public SECURITY_ATTRIBUTES()
		{
			NLength = 12;
		}
	}

	internal const uint PIPE_ACCESS_DUPLEX = 3u;

	internal const uint PIPE_ACCESS_OUTBOUND = 2u;

	internal const uint PIPE_ACCESS_INBOUND = 1u;

	internal const uint PIPE_TYPE_BYTE = 0u;

	internal const uint PIPE_TYPE_MESSAGE = 4u;

	internal const uint FILE_FLAG_OVERLAPPED = 1073741824u;

	internal const uint PIPE_WAIT = 0u;

	internal const uint PIPE_NOWAIT = 1u;

	internal const uint PIPE_READMODE_BYTE = 0u;

	internal const uint PIPE_READMODE_MESSAGE = 2u;

	internal const uint PIPE_ACCEPT_REMOTE_CLIENTS = 0u;

	internal const uint PIPE_REJECT_REMOTE_CLIENTS = 8u;

	internal const uint PIPE_UNLIMITED_INSTANCES = 255u;

	internal const uint ERROR_MORE_DATA = 234u;

	internal const uint ERROR_PIPE_CONNECTED = 535u;

	internal const uint ERROR_IO_INCOMPLETE = 996u;

	internal const uint ERROR_IO_PENDING = 997u;

	internal const uint ERROR_NO_DATA = 232u;

	internal const uint ERROR_BROKEN_PIPE = 109u;

	internal const uint ERROR_PIPE_BUSY = 231u;

	internal const uint INFINITE = uint.MaxValue;

	internal const uint GENERIC_READ = 2147483648u;

	internal const uint GENERIC_WRITE = 1073741824u;

	internal const uint GENERIC_EXECUTE = 536870912u;

	internal const uint GENERIC_ALL = 268435456u;

	internal const uint CREATE_NEW = 1u;

	internal const uint CREATE_ALWAYS = 2u;

	internal const uint OPEN_EXISTING = 3u;

	internal const uint OPEN_ALWAYS = 4u;

	internal const uint TRUNCATE_EXISTING = 5u;

	internal const uint TOKEN_QUERY = 8u;

	internal const uint SE_GROUP_LOGON_ID = 3221225472u;

	internal const int TokenGroups = 2;

	internal static readonly IntPtr INVALID_HANDLE_VALUE = (IntPtr)(-1);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern NamedPipeSafeHandle CreateNamedPipe(string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, SECURITY_ATTRIBUTES securityAttributes);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool GetOverlappedResult(NamedPipeSafeHandle hFile, [In] ref NativeOverlapped lpOverlapped, out uint lpNumberOfBytesTransferred, bool bWait);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

	[DllImport("Advapi32.Dll", SetLastError = true)]
	internal static extern int GetTokenInformation(IntPtr TokenHandle, int TokenInformationClass, IntPtr TokenInformation, uint TokenInformationLength, ref uint ReturnLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool ConnectNamedPipe(NamedPipeSafeHandle hNamedPipe, [In] ref NativeOverlapped lpOverlapped);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool WaitNamedPipe(string lpNamedPipeName, uint nTimeOut);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool DisconnectNamedPipe(NamedPipeSafeHandle hNamedPipe);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool ReadFile(NamedPipeSafeHandle hFile, byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, [In] ref NativeOverlapped lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool WriteFile(NamedPipeSafeHandle hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, [In] IntPtr lpOverlapped);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern NamedPipeSafeHandle CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr SecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32.dll")]
	internal static extern bool SetEvent(IntPtr hEvent);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	internal static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);

	[DllImport("kernel32.dll")]
	internal static extern uint WaitForMultipleObjects(uint nCount, IntPtr[] lpHandles, bool bWaitAll, uint dwMilliseconds);
}
