using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DShowNET;

[ComVisible(false)]
public class DsUtils
{
	public static bool IsCorrectDirectXVersion()
	{
		return File.Exists(Path.Combine(Environment.SystemDirectory, "dpnhpast.dll"));
	}

	public static bool ShowCapPinDialog(ICaptureGraphBuilder2 bld, IBaseFilter flt, IntPtr hwnd)
	{
		object ppint = null;
		ISpecifyPropertyPages specifyPropertyPages = null;
		DsCAUUID pPages = default(DsCAUUID);
		try
		{
			Guid pCategory = PinCategory.Capture;
			Guid pType = MediaType.Interleaved;
			Guid riid = typeof(IAMStreamConfig).GUID;
			if (bld.FindInterface(ref pCategory, ref pType, flt, ref riid, out ppint) != 0)
			{
				pType = MediaType.Video;
				if (bld.FindInterface(ref pCategory, ref pType, flt, ref riid, out ppint) != 0)
				{
					return false;
				}
			}
			if (!(ppint is ISpecifyPropertyPages specifyPropertyPages2))
			{
				return false;
			}
			int pages = specifyPropertyPages2.GetPages(out pPages);
			pages = OleCreatePropertyFrame(hwnd, 30, 30, null, 1, ref ppint, pPages.cElems, pPages.pElems, 0, 0, IntPtr.Zero);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			if (pPages.pElems != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(pPages.pElems);
			}
			specifyPropertyPages = null;
			if (ppint != null)
			{
				Marshal.ReleaseComObject(ppint);
			}
			ppint = null;
		}
	}

	public static bool ShowTunerPinDialog(ICaptureGraphBuilder2 bld, IBaseFilter flt, IntPtr hwnd)
	{
		object ppint = null;
		ISpecifyPropertyPages specifyPropertyPages = null;
		DsCAUUID pPages = default(DsCAUUID);
		try
		{
			Guid pCategory = PinCategory.Capture;
			Guid pType = MediaType.Interleaved;
			Guid riid = typeof(IAMTVTuner).GUID;
			if (bld.FindInterface(ref pCategory, ref pType, flt, ref riid, out ppint) != 0)
			{
				pType = MediaType.Video;
				if (bld.FindInterface(ref pCategory, ref pType, flt, ref riid, out ppint) != 0)
				{
					return false;
				}
			}
			if (!(ppint is ISpecifyPropertyPages specifyPropertyPages2))
			{
				return false;
			}
			int pages = specifyPropertyPages2.GetPages(out pPages);
			pages = OleCreatePropertyFrame(hwnd, 30, 30, null, 1, ref ppint, pPages.cElems, pPages.pElems, 0, 0, IntPtr.Zero);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
		finally
		{
			if (pPages.pElems != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(pPages.pElems);
			}
			specifyPropertyPages = null;
			if (ppint != null)
			{
				Marshal.ReleaseComObject(ppint);
			}
			ppint = null;
		}
	}

	public int GetPin(IBaseFilter filter, PinDirection dirrequired, int num, out IPin ppPin)
	{
		ppPin = null;
		IEnumPins ppEnum;
		int num2 = filter.EnumPins(out ppEnum);
		if (num2 < 0 || ppEnum == null)
		{
			return num2;
		}
		IPin[] array = new IPin[1];
		do
		{
			num2 = ppEnum.Next(1, array, out var _);
			if (num2 != 0 || array[0] == null)
			{
				break;
			}
			PinDirection pPinDir = (PinDirection)3;
			num2 = array[0].QueryDirection(out pPinDir);
			if (num2 == 0 && pPinDir == dirrequired)
			{
				if (num == 0)
				{
					ppPin = array[0];
					array[0] = null;
					break;
				}
				num--;
			}
			Marshal.ReleaseComObject(array[0]);
			array[0] = null;
		}
		while (num2 == 0);
		Marshal.ReleaseComObject(ppEnum);
		ppEnum = null;
		return num2;
	}

	public static void FreeAMMediaType(AMMediaType mediaType)
	{
		if (mediaType.formatSize != 0)
		{
			Marshal.FreeCoTaskMem(mediaType.formatPtr);
		}
		if (mediaType.unkPtr != IntPtr.Zero)
		{
			Marshal.Release(mediaType.unkPtr);
		}
		mediaType.formatSize = 0;
		mediaType.formatPtr = IntPtr.Zero;
		mediaType.unkPtr = IntPtr.Zero;
	}

	[DllImport("olepro32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	private static extern int OleCreatePropertyFrame(IntPtr hwndOwner, int x, int y, string lpszCaption, int cObjects, [In][MarshalAs(UnmanagedType.Interface)] ref object ppUnk, int cPages, IntPtr pPageClsID, int lcid, int dwReserved, IntPtr pvReserved);
}
