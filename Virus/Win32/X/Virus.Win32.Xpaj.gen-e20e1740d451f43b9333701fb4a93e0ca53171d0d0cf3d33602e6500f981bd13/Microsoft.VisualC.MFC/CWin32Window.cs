using System;
using System.Windows.Forms;

namespace Microsoft.VisualC.MFC;

public class CWin32Window : IWin32Window
{
	private unsafe HWND__* m_hWnd;

	public unsafe virtual IntPtr Handle => (IntPtr)m_hWnd;

	public unsafe CWin32Window(HWND__* hWnd)
	{
		m_hWnd = hWnd;
		base._002Ector();
	}
}
