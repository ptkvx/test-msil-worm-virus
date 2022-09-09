using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

namespace BlankWPF;

public class Window1 : Window, IComponentConnector
{
	private bool _contentLoaded;

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/BlankWPF;component/window1.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		_contentLoaded = true;
	}

	public Window1()
	{
		((FrameworkElement)this).add_Initialized((EventHandler)Window1_Initialized);
		InitializeComponent();
	}

	private void Window1_Initialized(object sender, EventArgs e)
	{
		if (true.Equals(Application.get_Current().get_Properties()["exit"]))
		{
			Application.get_Current().Shutdown();
		}
	}
}
