using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Windows.Controls;

namespace Appointments;

[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public class Search : Window, IComponentConnector
{
	private myAppointmentsDataContext DC = new myAppointmentsDataContext();

	internal Label label1;

	internal ComboBox comboBox_showAppointmentPatient;

	internal Button button1;

	internal ListView listView1;

	internal Button button2;

	internal Separator separator1;

	private bool _contentLoaded;

	public Search()
	{
		InitializeComponent();
	}

	private void comboBox1_DropDownOpened(object sender, EventArgs e)
	{
		IQueryable<string> queryable = ((IQueryable<Patient>)DC.Patients).Select((Patient pat) => pat.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_showAppointmentPatient).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void comboBox1_GotFocus(object sender, RoutedEventArgs e)
	{
		IQueryable<string> queryable = ((IQueryable<Patient>)DC.Patients).Select((Patient pat) => pat.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_showAppointmentPatient).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void button1_Click(object sender, RoutedEventArgs e)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		comboBox_showAppointmentPatient.set_Text(comboBox_showAppointmentPatient.get_Text().Trim());
		if (((Selector)comboBox_showAppointmentPatient).get_SelectedIndex() == -1)
		{
			MessageBox.Show("لم يتم تحديد اسم مريض للبحث , يرجى إعادة المحاولة", "خطأ", (MessageBoxButton)0, (MessageBoxImage)16);
			((UIElement)comboBox_showAppointmentPatient).Focus();
			return;
		}
		IQueryable<Appointment> queryable = ((IQueryable<Appointment>)DC.Appointments).Where((Appointment query) => query.Patient.Name == ((Selector)comboBox_showAppointmentPatient).get_SelectedItem().ToString());
		if (queryable.Count() == 0)
		{
			MessageBox.Show("لا يوجد مواعيد محددة للمريض الذي قمت باختياره", "انتبه", (MessageBoxButton)0, (MessageBoxImage)64);
			return;
		}
		((ItemsControl)listView1).set_ItemsSource((IEnumerable)queryable);
		((FrameworkElement)this).set_Height(516.0);
	}

	private void button2_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		InputLanguageManager.SetInputLanguage((DependencyObject)(object)comboBox_showAppointmentPatient, CultureInfo.CreateSpecificCulture("ar"));
		((FrameworkElement)this).set_Height(135.0);
	}

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Appointments;component/search.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			((FrameworkElement)(Search)target).add_Loaded(new RoutedEventHandler(Window_Loaded));
			break;
		case 2:
			label1 = (Label)target;
			break;
		case 3:
			comboBox_showAppointmentPatient = (ComboBox)target;
			comboBox_showAppointmentPatient.add_DropDownOpened((EventHandler)comboBox1_DropDownOpened);
			((UIElement)comboBox_showAppointmentPatient).add_GotFocus(new RoutedEventHandler(comboBox1_GotFocus));
			break;
		case 4:
			button1 = (Button)target;
			((ButtonBase)button1).add_Click(new RoutedEventHandler(button1_Click));
			break;
		case 5:
			listView1 = (ListView)target;
			break;
		case 6:
			button2 = (Button)target;
			((ButtonBase)button2).add_Click(new RoutedEventHandler(button2_Click));
			break;
		case 7:
			separator1 = (Separator)target;
			break;
		}
	}
}
