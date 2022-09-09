using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DShowNET;

namespace DirectX.Capture;

public class DirectShowPropertyPage : PropertyPage
{
	protected ISpecifyPropertyPages specifyPropertyPages;

	public DirectShowPropertyPage(string name, ISpecifyPropertyPages specifyPropertyPages)
	{
		Name = name;
		SupportsPersisting = false;
		this.specifyPropertyPages = specifyPropertyPages;
	}

	public override void Show(Control owner)
	{
		DsCAUUID pPages = default(DsCAUUID);
		try
		{
			specifyPropertyPages.GetPages(out pPages);
			object ppUnk = specifyPropertyPages;
			OleCreatePropertyFrame(owner.get_Handle(), 30, 30, null, 1, ref ppUnk, pPages.cElems, pPages.pElems, 0, 0, IntPtr.Zero);
		}
		finally
		{
			if (pPages.pElems != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(pPages.pElems);
			}
		}
	}

	public new void Dispose()
	{
		if (specifyPropertyPages != null)
		{
			Marshal.ReleaseComObject(specifyPropertyPages);
		}
		specifyPropertyPages = null;
	}

	[DllImport("olepro32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	private static extern int OleCreatePropertyFrame(IntPtr hwndOwner, int x, int y, string lpszCaption, int cObjects, [In][MarshalAs(UnmanagedType.Interface)] ref object ppUnk, int cPages, IntPtr pPageClsID, int lcid, int dwReserved, IntPtr pvReserved);
}
