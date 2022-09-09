using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Intuit.QuickBooks.FCS;

[ClassInterface(ClassInterfaceType.None)]
[Guid("72C315AC-5A15-4f70-9CB3-899012406150")]
[ComVisible(true)]
public class ShareInfoSession : IShareInfoSession
{
	public ShareInfoSession()
	{
		FCService.WriteTraceLine("ShareInfoSession component just Constructed");
		Process currentProcess = Process.GetCurrentProcess();
		FCService.WriteTraceLine("ShareInfoSession Component runs inside Process ID: " + currentProcess.Id + " , Main module: " + currentProcess.MainModule!.ModuleName);
		FCService.FixRegistry();
	}

	public FCSErrors GetLocalSharePath(string ShareName, out string SharePath)
	{
		FCService.WriteTraceLine("GetLocalSharePath() is called. Share Name: " + ShareName);
		string sServerName = "";
		SharePath = "";
		IntPtr bufptr = (IntPtr)Marshal.SizeOf(typeof(NetAPI32.SHARE_INFO_2));
		int num = NetAPI32.NetShareGetInfo(sServerName, ShareName, 2, out bufptr);
		FCService.WriteTraceLine("NetShareGetInfo() returned Status code: " + num);
		if (num != 0)
		{
			FCSErrors fCSErrors = (FCSErrors)num;
			if (fCSErrors != FCSErrors.NetError_Access_Denied && fCSErrors != FCSErrors.NetError_InvalidParameter && fCSErrors != FCSErrors.NetError_NetNameNotFound)
			{
				return FCSErrors.NetError_General;
			}
			return (FCSErrors)num;
		}
		NetAPI32.SHARE_INFO_2 sHARE_INFO_ = (NetAPI32.SHARE_INFO_2)Marshal.PtrToStructure(bufptr, default(NetAPI32.SHARE_INFO_2).GetType());
		NetAPI32.NetApiBufferFree(bufptr);
		if (sHARE_INFO_.shi2_type != 0)
		{
			FCService.WriteTraceLine("The share type being quiried is not allowed for security reasons. Share Type: " + sHARE_INFO_.shi2_type);
			return FCSErrors.NetError_ShareTypeNotSupported;
		}
		SharePath = sHARE_INFO_.shi2_path;
		return FCSErrors.Operation_Success;
	}
}
