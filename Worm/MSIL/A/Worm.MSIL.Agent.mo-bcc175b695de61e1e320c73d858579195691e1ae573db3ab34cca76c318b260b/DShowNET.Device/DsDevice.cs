using System;
using System.Runtime.InteropServices;

namespace DShowNET.Device;

[ComVisible(false)]
public class DsDevice : IDisposable
{
	public string Name;

	public UCOMIMoniker Mon;

	public void Dispose()
	{
		if (Mon != null)
		{
			Marshal.ReleaseComObject(Mon);
		}
		Mon = null;
	}
}
