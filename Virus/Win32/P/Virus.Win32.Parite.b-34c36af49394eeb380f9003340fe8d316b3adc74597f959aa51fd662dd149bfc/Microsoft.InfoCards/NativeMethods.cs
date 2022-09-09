using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal static class NativeMethods
{
	public enum SecurityImpersonationLevel
	{
		SecurityAnonymous,
		SecurityIdentification,
		SecurityImpersonation,
		SecurityDelegation
	}

	public sealed class SafeHandleOnlyMethods
	{
		private SafeHandleOnlyMethods()
		{
		}

		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern bool CloseHandle([In] IntPtr handle);
	}

	public const int E_BUSY = -2147024825;

	public const int ERROR_ACCESS_DENIED = 5;

	public const int ERROR_NOT_ENOUGH_MEMORY = 8;

	public const int ERROR_OUTOFMEMORY = 14;

	public const int E_NOTIMPL = -2147467263;

	public const int E_ACCESSDENIED = -2147024891;

	public const int COR_E_APPLICATION = -2146232832;

	public const int COR_E_ARGUMENT = -2147024809;

	public const int ERROR_INVALID_DATA = 13;

	public const int CRYPTPROTECT_LOCAL_MACHINE = 4;

	public const int CRYPTPROTECT_UI_FORBIDDEN = 1;

	public const int CRYPTPROTECT_NO_RECOVERY = 32;

	public const int CRYPTPROTECT_VERIFY_PROTECTION = 64;

	public const int CRYPTPROTECT_AUDIT = 16;

	public const int CRYPTPROTECTMEMORY_SAME_PROCESS = 0;

	public const int CRYPTPROTECTMEMORY_CROSS_PROCESS = 1;

	public const int CRYPTPROTECTMEMORY_SAME_LOGON = 2;

	public const int EVENT_MODIFY_STATE = 2;

	public const int PROCESS_DUP_HANDLE = 64;

	public const int TOKEN_QUERY = 8;

	public const int TOKEN_IMPERSONATE = 4;

	public const int TOKEN_DUPLICATE = 2;

	public const int TOKEN_ASSIGN_PRIMARY = 1;

	public const int TOKEN_ALL_ACCESS = 511;

	public const uint WAIT_TIMEOUT = 258u;

	public const uint WAIT_ABANDONED = 128u;

	public const uint WAIT_FAILED = uint.MaxValue;

	public const int CSIDL_LOCAL_APPDATA = 28;

	public const int SHGFP_TYPE_CURRENT = 0;

	public const int MAX_PATH = 260;

	public const int MUTEX_MODIFY_STATE = 2;

	public const int SYNCHRONIZE = 1048576;

	public const int FILE_PERSISTENT_ACLS = 8;

	public const int ERROR_CANCELLED = 1223;

	public const int SM_TABLETPC = 86;

	[DllImport("Crypt32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool CryptProtectData([In] IntPtr pDataIn, [In][MarshalAs(UnmanagedType.LPWStr)] string szDataDescr, [In] IntPtr pOptionalEntropy, [In] IntPtr pvReserved, [In] IntPtr pPromptStruct, [In][MarshalAs(UnmanagedType.I4)] int dwFlags, [In] IntPtr pDataOut);

	[DllImport("Crypt32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool CryptUnprotectData([In] IntPtr pDataIn, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder ppszDataDescr, [In] IntPtr pOptionalEntropy, [In] IntPtr pvReserved, [In] IntPtr pPromptStruct, [In][MarshalAs(UnmanagedType.I4)] int dwFlags, [In] IntPtr pDataOut);

	[DllImport("Rpcrt4.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern uint RpcImpersonateClient([In] IntPtr rpcBindingHandle);

	[DllImport("Rpcrt4.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern uint RpcRevertToSelfEx([In] IntPtr rpcBindingHandle);

	[DllImport("Rpcrt4.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern uint I_RpcBindingInqLocalClientPID([In] IntPtr rpcBindingHandle, out uint pid);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool RevertToSelf();

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool ImpersonateLoggedOnUser([In] IntPtr hToken);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool ProcessIdToSessionId([In] int pid, out int tSSession);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern SafeNativeHandle OpenProcess([In] int desiredAccess, [In] bool inheritHandle, [In] int processId);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool DuplicateHandle([In] SafeNativeHandle sourceProcessHandle, [In] SafeWaitHandle sourceHandle, [In] SafeNativeHandle targetProcessHandle, out SafeWaitHandle targetHandle, [In] int desiredAccess, [In] bool inheritHandle, [In] int options);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LocalFree(IntPtr hMem);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool CryptDecrypt([In] SafeCryptoKeyHandle hKey, [In] IntPtr hHash, [In] uint Final, [In] uint Flags, [In] IntPtr data, [In][Out] ref uint length);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool CryptEncrypt([In] SafeCryptoKeyHandle hKey, [In] IntPtr hHash, [In] uint Final, [In] uint Flags, [In] IntPtr data, [In][Out] ref uint length, [In] uint bufLength);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern void RtlZeroMemory([In] IntPtr dest, [In] int size);

	[DllImport("Crypt32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern int CertGetNameStringW(IntPtr pCertContext, int dwType, int dwFlags, [In][MarshalAs(UnmanagedType.LPStr)] string pvTypePara, [Out] StringBuilder pszNameString, int cchNameString);

	[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern int WTSGetActiveConsoleSessionId();

	[DllImport("user32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern int GetSystemMetrics(int nIndex);
}
