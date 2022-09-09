using System;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public class DsROT
{
	private const int ROTFLAGS_REGISTRATIONKEEPSALIVE = 1;

	public static bool AddGraphToRot(object graph, out int cookie)
	{
		cookie = 0;
		int num = 0;
		UCOMIRunningObjectTable pprot = null;
		UCOMIMoniker ppmk = null;
		try
		{
			num = GetRunningObjectTable(0, out pprot);
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			int currentProcessId = GetCurrentProcessId();
			IntPtr iUnknownForObject = Marshal.GetIUnknownForObject(graph);
			int num2 = (int)iUnknownForObject;
			Marshal.Release(iUnknownForObject);
			string item = string.Format("FilterGraph {0} pid {1}", num2.ToString("x8"), currentProcessId.ToString("x8"));
			num = CreateItemMoniker("!", item, out ppmk);
			if (num < 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			pprot.Register(1, graph, ppmk, ref cookie);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			if (ppmk != null)
			{
				Marshal.ReleaseComObject(ppmk);
			}
			ppmk = null;
			if (pprot != null)
			{
				Marshal.ReleaseComObject(pprot);
			}
			pprot = null;
		}
	}

	public static bool RemoveGraphFromRot(ref int cookie)
	{
		UCOMIRunningObjectTable pprot = null;
		try
		{
			GetRunningObjectTable(0, out pprot);
			pprot.Revoke(cookie);
			cookie = 0;
			return true;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			if (pprot != null)
			{
				Marshal.ReleaseComObject(pprot);
			}
			pprot = null;
		}
	}

	[DllImport("ole32.dll", ExactSpelling = true)]
	private static extern int GetRunningObjectTable(int r, out UCOMIRunningObjectTable pprot);

	[DllImport("ole32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	private static extern int CreateItemMoniker(string delim, string item, out UCOMIMoniker ppmk);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	private static extern int GetCurrentProcessId();
}
