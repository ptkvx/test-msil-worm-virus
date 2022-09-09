using System;
using System.Windows.Forms;

namespace Microsoft.VisualC.MFC;

public class CWinFormsEventsHelper
{
	public Control m_pControl;

	public unsafe IHandleEvents* m_pSink;

	public Control Control
	{
		get
		{
			return m_pControl;
		}
		set
		{
			if (value == null)
			{
				_003CModule_003E.AfxThrowInvalidArgException();
			}
			if (m_pControl != null)
			{
				_003CModule_003E.AfxThrowInvalidArgException();
			}
			m_pControl = value;
			m_pControl.add_HandleCreated((EventHandler)OnHandleCreated);
			m_pControl.add_HandleDestroyed((EventHandler)OnHandleDestroyed);
		}
	}

	public unsafe CWinFormsEventsHelper()
	{
		m_pSink = null;
	}

	public unsafe void Advise(IHandleEvents* pSink)
	{
		if (pSink == null)
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		IHandleEvents* pSink2 = m_pSink;
		if (pSink2 != null && pSink2 != pSink)
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		m_pSink = pSink;
	}

	public unsafe void Unadvise(IHandleEvents* pSink)
	{
		IHandleEvents* pSink2 = m_pSink;
		if (pSink2 != null && pSink2 != pSink)
		{
			_003CModule_003E.AfxThrowInvalidArgException();
		}
		m_pSink = null;
	}

	protected unsafe void OnHandleCreated(object sender, EventArgs e)
	{
		IHandleEvents* pSink = m_pSink;
		if (pSink != null)
		{
			((delegate*<IntPtr, object, EventArgs, void>)(int)(*(uint*)(int)(*(uint*)pSink)))((nint)pSink, sender, e);
		}
	}

	protected unsafe void OnHandleDestroyed(object sender, EventArgs e)
	{
		IHandleEvents* pSink = m_pSink;
		if (pSink != null)
		{
			((delegate*<IntPtr, object, EventArgs, void>)(int)(*(uint*)(*(int*)pSink + 4)))((nint)pSink, sender, e);
		}
	}
}
