using System;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

internal class ComAPI
{
	public const int RPC_C_AUTHN_LEVEL_NONE = 1;

	public const int RPC_C_AUTHN_LEVEL_PKT_PRIVACY = 6;

	public const int RPC_C_IMP_LEVEL_IDENTIFY = 2;

	public const int CLSCTX_LOCAL_SERVER = 4;

	public const int REGCLS_MULTIPLEUSE = 1;

	public const int EOAC_DISABLE_AAA = 4096;

	public const int EOAC_NO_CUSTOM_MARSHAL = 8192;

	public const int EOAC_SECURE_REFS = 2;

	public const int EOAC_APPID = 8;

	public const int CLASS_E_NOAGGREGATION = -2147221232;

	public const int E_NOINTERFACE = -2147467262;

	public const string guidIClassFactory = "00000001-0000-0000-C000-000000000046";

	public const string guidIUnknown = "00000000-0000-0000-C000-000000000046";

	[DllImport("OLE32.DLL")]
	public static extern uint CoInitializeSecurity(ref Guid AppID, int cAuth, IntPtr asAuthSvc, IntPtr reserved, uint AuthLevel, uint ImpLevel, IntPtr pAuthList, uint Capabilities, IntPtr reserved3);

	[DllImport("ole32.dll")]
	public static extern uint CoRegisterClassObject(ref Guid rclsid, [MarshalAs(UnmanagedType.Interface)] IClassFactory pUnkn, int dwClsContext, int flags, out int lpdwRegister);

	[DllImport("ole32.dll")]
	public static extern uint CoRevokeClassObject(int dwRegister);
}
