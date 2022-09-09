using System;
using System.Windows.Forms;

namespace DirectX.Capture;

public class PropertyPage : IDisposable
{
	public string Name;

	public bool SupportsPersisting = false;

	public virtual byte[] State
	{
		get
		{
			throw new NotSupportedException("This property page does not support persisting state.");
		}
		set
		{
			throw new NotSupportedException("This property page does not support persisting state.");
		}
	}

	public virtual void Show(Control owner)
	{
	}

	public void Dispose()
	{
	}
}
