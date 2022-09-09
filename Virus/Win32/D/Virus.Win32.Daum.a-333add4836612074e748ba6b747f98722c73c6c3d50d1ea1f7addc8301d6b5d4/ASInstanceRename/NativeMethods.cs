using System;
using System.Runtime.InteropServices;

namespace ASInstanceRename;

internal class NativeMethods
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class ENUM_SERVICE_STATUS
	{
		public string serviceName;

		public string displayName;

		public int serviceType;

		public int currentState;

		public int controlsAccepted;

		public int win32ExitCode;

		public int serviceSpecificExitCode;

		public int checkPoint;

		public int waitHint;
	}

	public struct SERVICE_STATUS
	{
		public int serviceType;

		public int currentState;

		public int controlsAccepted;

		public int win32ExitCode;

		public int serviceSpecificExitCode;

		public int checkPoint;

		public int waitHint;
	}

	[StructLayout(LayoutKind.Sequential)]
	public class QUERY_SERVICE_CONFIG
	{
		public int dwServiceType;

		public int dwStartType;

		public int dwErrorControl;

		public IntPtr lpBinaryPathName = IntPtr.Zero;

		public IntPtr lpLoadOrderGroup = IntPtr.Zero;

		public int dwTagId;

		public IntPtr lpDependencies = IntPtr.Zero;

		public IntPtr lpServiceStartName = IntPtr.Zero;

		public IntPtr lpDisplayName = IntPtr.Zero;
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SERVICE_DESCRIPTION
	{
		public IntPtr lpDescription = IntPtr.Zero;
	}

	public const int SERVICE_NO_CHANGE = -1;

	public const int ERROR_MORE_DATA = 234;

	public const int ERROR_INSUFFICIENT_BUFFER = 122;

	public const int STANDARD_RIGHTS_DELETE = 65536;

	public const int STANDARD_RIGHTS_REQUIRED = 983040;

	public const int ACCESS_TYPE_CHANGE_CONFIG = 2;

	public const int ACCESS_TYPE_ENUMERATE_DEPENDENTS = 8;

	public const int ACCESS_TYPE_INTERROGATE = 128;

	public const int ACCESS_TYPE_PAUSE_CONTINUE = 64;

	public const int ACCESS_TYPE_QUERY_CONFIG = 1;

	public const int ACCESS_TYPE_QUERY_STATUS = 4;

	public const int ACCESS_TYPE_START = 16;

	public const int ACCESS_TYPE_STOP = 32;

	public const int ACCESS_TYPE_USER_DEFINED_CONTROL = 256;

	public const int ACCESS_TYPE_ALL = 983551;

	public const int ERROR_CONTROL_CRITICAL = 3;

	public const int ERROR_CONTROL_IGNORE = 0;

	public const int ERROR_CONTROL_NORMAL = 1;

	public const int ERROR_CONTROL_SEVERE = 2;

	public const int SC_MANAGER_CONNECT = 1;

	public const int SC_MANAGER_CREATE_SERVICE = 2;

	public const int SC_MANAGER_ENUMERATE_SERVICE = 4;

	public const int SC_MANAGER_LOCK = 8;

	public const int SC_MANAGER_MODIFY_BOOT_CONFIG = 32;

	public const int SC_MANAGER_QUERY_LOCK_STATUS = 16;

	public const int SC_MANAGER_ALL = 983103;

	public const int SC_ENUM_PROCESS_INFO = 0;

	public const int SERVICE_QUERY_CONFIG = 1;

	public const int SERVICE_CHANGE_CONFIG = 2;

	public const int SERVICE_QUERY_STATUS = 4;

	public const int SERVICE_ENUMERATE_DEPENDENTS = 8;

	public const int SERVICE_START = 16;

	public const int SERVICE_STOP = 32;

	public const int SERVICE_PAUSE_CONTINUE = 64;

	public const int SERVICE_INTERROGATE = 128;

	public const int SERVICE_USER_DEFINED_CONTROL = 256;

	public const int SERVICE_ALL_ACCESS = 983551;

	public const int SERVICE_TYPE_ADAPTER = 4;

	public const int SERVICE_TYPE_FILE_SYSTEM_DRIVER = 2;

	public const int SERVICE_TYPE_INTERACTIVE_PROCESS = 256;

	public const int SERVICE_TYPE_KERNEL_DRIVER = 1;

	public const int SERVICE_TYPE_RECOGNIZER_DRIVER = 8;

	public const int SERVICE_TYPE_WIN32_OWN_PROCESS = 16;

	public const int SERVICE_TYPE_WIN32_SHARE_PROCESS = 32;

	public const int SERVICE_TYPE_WIN32 = 48;

	public const int SERVICE_TYPE_DRIVER = 11;

	public const int SERVICE_TYPE_ALL = 319;

	public const int SERVICE_CONFIG_DESCRIPTION = 1;

	public const int SERVICE_FAILURE_ACTIONS = 2;

	public const int SERVICE_CONFIG_PRESHUTDOWN_INFO = 3;

	public const int START_TYPE_AUTO = 2;

	public const int START_TYPE_BOOT = 0;

	public const int START_TYPE_DEMAND = 3;

	public const int START_TYPE_DISABLED = 4;

	public const int START_TYPE_SYSTEM = 1;

	public const int SERVICE_ACTIVE = 1;

	public const int SERVICE_INACTIVE = 2;

	public const int SERVICE_STATE_ALL = 3;

	public const int STATE_CONTINUE_PENDING = 5;

	public const int STATE_PAUSED = 7;

	public const int STATE_PAUSE_PENDING = 6;

	public const int STATE_RUNNING = 4;

	public const int STATE_START_PENDING = 2;

	public const int STATE_STOPPED = 1;

	public const int STATE_STOP_PENDING = 3;

	public const int STATUS_ACTIVE = 1;

	public const int STATUS_INACTIVE = 2;

	public const int STATUS_ALL = 3;

	public const int POLICY_VIEW_LOCAL_INFORMATION = 1;

	public const int POLICY_VIEW_AUDIT_INFORMATION = 2;

	public const int POLICY_GET_PRIVATE_INFORMATION = 4;

	public const int POLICY_TRUST_ADMIN = 8;

	public const int POLICY_CREATE_ACCOUNT = 16;

	public const int POLICY_CREATE_SECRET = 32;

	public const int POLICY_CREATE_PRIVILEGE = 64;

	public const int POLICY_SET_DEFAULT_QUOTA_LIMITS = 128;

	public const int POLICY_SET_AUDIT_REQUIREMENTS = 256;

	public const int POLICY_AUDIT_LOG_ADMIN = 512;

	public const int POLICY_SERVER_ADMIN = 1024;

	public const int POLICY_LOOKUP_NAMES = 2048;

	public const int POLICY_ALL_ACCESS = 985087;

	public const int STATUS_OBJECT_NAME_NOT_FOUND = -1073741772;

	[DllImport("Advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool DeleteService(ServiceHandle serviceHandle);

	[DllImport("sqlconf.dll", CharSet = CharSet.Unicode)]
	public static extern int ValidateInstanceSyntax(string instanceName);

	[DllImport("sqlconf.dll", CharSet = CharSet.Unicode)]
	public static extern int ValidateAccount(string account, string password);
}
