using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;
using Microsoft.Windows.Controls;

namespace Appointments;

[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public class MainWindow : Window, IComponentConnector
{
	private NotifyIcon myNotifyIcon;

	internal MainWindow myMainWindow;

	internal Button button1;

	internal Button button2;

	internal Button button3;

	internal Separator separator1;

	internal Button button4;

	internal Button button6;

	internal Button button5;

	internal Label label1;

	internal Label label2;

	internal Label label3;

	internal Label label4;

	private bool _contentLoaded;

	public MainWindow()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, RoutedEventArgs e)
	{
		Add add = new Add();
		((Window)add).ShowDialog();
	}

	private void button2_Click(object sender, RoutedEventArgs e)
	{
		Show show = new Show();
		((Window)show).ShowDialog();
	}

	private void button3_Click(object sender, RoutedEventArgs e)
	{
		Management management = new Management();
		((Window)management).ShowDialog();
	}

	private void button4_Click(object sender, RoutedEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		MessageBoxResult val = MessageBox.Show("هل تريد بالتأكيد إغلاق برنامج منظم المواعيد", "تنبيه", (MessageBoxButton)4, (MessageBoxImage)48);
		if ((int)val == 6)
		{
			Application.get_Current().Shutdown();
		}
		else
		{
			((UIElement)myMainWindow).Focus();
		}
	}

	private void button5_Click(object sender, RoutedEventArgs e)
	{
		Search search = new Search();
		((Window)search).ShowDialog();
	}

	private void button6_Click(object sender, RoutedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		myNotifyIcon = new NotifyIcon();
		myNotifyIcon.set_BalloonTipTitle("برنامج منظم المواعيد الطبية");
		myNotifyIcon.set_BalloonTipText("البرنامج لازال يعمل حاليا , و لكن في الوضع المخفي");
		myNotifyIcon.set_Icon(new Icon("clock.ico"));
		((Window)myMainWindow).set_WindowState((WindowState)1);
		myNotifyIcon.set_Visible(true);
		myNotifyIcon.ShowBalloonTip(2000);
		((Window)myMainWindow).Hide();
		myNotifyIcon.add_BalloonTipClicked((EventHandler)myNotifyIcon_Click_BalloonTip);
	}

	private void myNotifyIcon_Click_BalloonTip(object sender, EventArgs e)
	{
		((Component)(object)myNotifyIcon).Dispose();
		myNotifyIcon = null;
		((Window)myMainWindow).set_WindowState((WindowState)0);
		((UIElement)myMainWindow).set_Visibility((Visibility)0);
		((Window)myMainWindow).Show();
	}

	private void myNotifyIcon_Click(object sender, EventArgs e)
	{
	}

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Appointments;component/mainwindow.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			myMainWindow = (MainWindow)target;
			break;
		case 2:
			button1 = (Button)target;
			((ButtonBase)button1).add_Click(new RoutedEventHandler(button1_Click));
			break;
		case 3:
			button2 = (Button)target;
			((ButtonBase)button2).add_Click(new RoutedEventHandler(button2_Click));
			break;
		case 4:
			button3 = (Button)target;
			((ButtonBase)button3).add_Click(new RoutedEventHandler(button3_Click));
			break;
		case 5:
			separator1 = (Separator)target;
			break;
		case 6:
			button4 = (Button)target;
			((ButtonBase)button4).add_Click(new RoutedEventHandler(button4_Click));
			break;
		case 7:
			button6 = (Button)target;
			((ButtonBase)button6).add_Click(new RoutedEventHandler(button6_Click));
			break;
		case 8:
			button5 = (Button)target;
			((ButtonBase)button5).add_Click(new RoutedEventHandler(button5_Click));
			break;
		case 9:
			label1 = (Label)target;
			break;
		case 10:
			label2 = (Label)target;
			break;
		case 11:
			label3 = (Label)target;
			break;
		case 12:
			label4 = (Label)target;
			break;
		}
	}
}
