using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Microsoft.Windows.Controls;

namespace Appointments;

[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public class Show : Window, IComponentConnector
{
	private myAppointmentsDataContext DC = new myAppointmentsDataContext();

	internal GroupBox groupBox_showAppointments;

	internal Label label8;

	internal Label label9;

	internal ComboBox comboBox_showAppointmentsDoctor;

	internal DatePicker datePicker_showAppointmentDate;

	internal Separator separator2;

	internal ListView listView_appointmentsList;

	internal Button button_close;

	private bool _contentLoaded;

	public Show()
	{
		InitializeComponent();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		datePicker_showAppointmentDate.set_SelectedDate((DateTime?)DateTime.Today);
		IQueryable<string> queryable = ((IQueryable<Doctor>)DC.Doctors).Select((Doctor doc) => doc.Name);
		if (queryable.Count() == 0)
		{
			return;
		}
		((ItemsControl)comboBox_showAppointmentsDoctor).set_ItemsSource((IEnumerable)queryable);
		((Selector)comboBox_showAppointmentsDoctor).set_SelectedIndex(-1);
		if (queryable.Count() == 1)
		{
			((Selector)comboBox_showAppointmentsDoctor).set_SelectedIndex(0);
			var itemsSource = from myApp in (IQueryable<Appointment>)DC.Appointments
				where myApp.Appointment_Date == datePicker_showAppointmentDate.get_SelectedDate() && myApp.Doctor.Name == ((Selector)comboBox_showAppointmentsDoctor).get_SelectedItem().ToString()
				select new
				{
					myApp.Patient.Name,
					myApp.Appointment_Time
				};
			((ItemsControl)listView_appointmentsList).set_ItemsSource((IEnumerable)itemsSource);
		}
	}

	private void comboBox_showAppointmentsDoctor_DropDownOpened(object sender, EventArgs e)
	{
		IQueryable<string> queryable = ((IQueryable<Doctor>)DC.Doctors).Select((Doctor doc) => doc.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_showAppointmentsDoctor).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void datePicker_showAppointmentDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		if (((Selector)comboBox_showAppointmentsDoctor).get_SelectedIndex() != -1)
		{
			var queryable = from myApp in (IQueryable<Appointment>)DC.Appointments
				where myApp.Appointment_Date == datePicker_showAppointmentDate.get_SelectedDate() && myApp.Doctor.Name == ((Selector)comboBox_showAppointmentsDoctor).get_SelectedItem().ToString()
				select new
				{
					myApp.Patient.Name,
					myApp.Appointment_Time
				};
			if (queryable.Count() == 0)
			{
				MessageBox.Show("لا يوجد أي موعد محدد حسب الإعدادات المطلوبة", "رسالة إعلامية", (MessageBoxButton)0, (MessageBoxImage)64);
			}
			else
			{
				((ItemsControl)listView_appointmentsList).set_ItemsSource((IEnumerable)queryable);
			}
		}
	}

	private void comboBox_showAppointmentsDoctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		var queryable = from myApp in (IQueryable<Appointment>)DC.Appointments
			where myApp.Appointment_Date == datePicker_showAppointmentDate.get_SelectedDate() && myApp.Doctor.Name == ((Selector)comboBox_showAppointmentsDoctor).get_SelectedItem().ToString()
			select new
			{
				myApp.Patient.Name,
				myApp.Appointment_Time
			};
		if (queryable.Count() == 0)
		{
			MessageBox.Show("لا يوجد أي موعد محدد حسب الإعدادات المطلوبة", "رسالة إعلامية", (MessageBoxButton)0, (MessageBoxImage)64);
		}
		else
		{
			((ItemsControl)listView_appointmentsList).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void button_close_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Appointments;component/show.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			((FrameworkElement)(Show)target).add_Loaded(new RoutedEventHandler(Window_Loaded));
			break;
		case 2:
			groupBox_showAppointments = (GroupBox)target;
			break;
		case 3:
			label8 = (Label)target;
			break;
		case 4:
			label9 = (Label)target;
			break;
		case 5:
			comboBox_showAppointmentsDoctor = (ComboBox)target;
			comboBox_showAppointmentsDoctor.add_DropDownOpened((EventHandler)comboBox_showAppointmentsDoctor_DropDownOpened);
			((Selector)comboBox_showAppointmentsDoctor).add_SelectionChanged(new SelectionChangedEventHandler(comboBox_showAppointmentsDoctor_SelectionChanged));
			break;
		case 6:
			datePicker_showAppointmentDate = (DatePicker)target;
			datePicker_showAppointmentDate.add_SelectedDateChanged((EventHandler<SelectionChangedEventArgs>)datePicker_showAppointmentDate_SelectedDateChanged);
			break;
		case 7:
			separator2 = (Separator)target;
			break;
		case 8:
			listView_appointmentsList = (ListView)target;
			break;
		case 9:
			button_close = (Button)target;
			((ButtonBase)button_close).add_Click(new RoutedEventHandler(button_close_Click));
			break;
		}
	}
}
