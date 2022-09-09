using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Data.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Windows.Controls;

namespace Appointments;

[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public class Add : Window, IComponentConnector
{
	private myAppointmentsDataContext DC = new myAppointmentsDataContext();

	internal GroupBox groupBox_addAppointment;

	internal Label label1;

	internal Label label2;

	internal Label label3;

	internal Label label4;

	internal Label label5;

	internal ComboBox comboBox_addAppointmentDoctor;

	internal Separator separator1;

	internal ComboBox comboBox_addAppointmentPatient;

	internal DatePicker datePicker_addAppointmentDate;

	internal TextBox textBox_addAppointmentHour;

	internal TextBox textBox_addAppointmentMinute;

	internal Label label7;

	internal RadioButton radioButton_addAppointmentAM;

	internal RadioButton radioButton_addAppointmentPM;

	internal TextBox textBox_addAppointmentNotes;

	internal Button button_addAppointment;

	internal Button button1;

	internal Button button_close;

	private bool _contentLoaded;

	public Add()
	{
		InitializeComponent();
	}

	private bool is_Numeric(string text)
	{
		bool result = true;
		char[] array = text.ToCharArray();
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (!char.IsNumber(array[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return result;
		}
		result = false;
		return false;
	}

	private bool checkTime(TimeSpan Registered, TimeSpan notRegistered, string span)
	{
		if (notRegistered <= Registered.Subtract(TimeSpan.Parse(span)))
		{
			return false;
		}
		if (notRegistered >= Registered.Add(TimeSpan.Parse(span)))
		{
			return false;
		}
		return true;
	}

	private void button_addAppointment_Click(object sender, RoutedEventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Invalid comparison between Unknown and I4
		if (((Selector)comboBox_addAppointmentDoctor).get_SelectedIndex() == -1)
		{
			MessageBox.Show("لم يتم تحديد اسم الطبيب , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			((UIElement)comboBox_addAppointmentDoctor).Focus();
			return;
		}
		if (string.IsNullOrWhiteSpace(comboBox_addAppointmentPatient.get_Text()))
		{
			MessageBox.Show("لم يتم تحديد اسم المريض , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			((UIElement)comboBox_addAppointmentPatient).Focus();
			return;
		}
		if (!datePicker_addAppointmentDate.get_SelectedDate().HasValue)
		{
			MessageBox.Show("لم يتم تحديد تاريخ الموعد , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			((UIElement)datePicker_addAppointmentDate).Focus();
			return;
		}
		if (!is_Numeric(textBox_addAppointmentHour.get_Text()))
		{
			MessageBox.Show("يرجى تحديد ساعة الموعد بالشكل الصحيح", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_addAppointmentHour.set_Text("ساعة");
			((UIElement)textBox_addAppointmentHour).Focus();
			return;
		}
		if (int.Parse(textBox_addAppointmentHour.get_Text().Trim()) > 12 || int.Parse(textBox_addAppointmentHour.get_Text().Trim()) < 1)
		{
			MessageBox.Show("الساعة المدخلة خاطئة , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_addAppointmentHour.set_Text("");
			((UIElement)textBox_addAppointmentHour).Focus();
			return;
		}
		if (!is_Numeric(textBox_addAppointmentMinute.get_Text()))
		{
			MessageBox.Show("يرجى تحديد ساعة الموعد بالشكل الصحيح", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_addAppointmentMinute.set_Text("دقيقة");
			((UIElement)textBox_addAppointmentMinute).Focus();
			return;
		}
		if (int.Parse(textBox_addAppointmentMinute.get_Text().Trim()) > 60 || int.Parse(textBox_addAppointmentMinute.get_Text().Trim()) < 0)
		{
			MessageBox.Show("الدقائق المدخلة خاطئة , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_addAppointmentMinute.set_Text("");
			((UIElement)textBox_addAppointmentMinute).Focus();
			return;
		}
		Appointment appointment = new Appointment();
		appointment.ID = Guid.NewGuid();
		Doctor doctor = ((IQueryable<Doctor>)DC.Doctors).Single((Doctor D) => D.Name == ((Selector)comboBox_addAppointmentDoctor).get_SelectedItem().ToString());
		comboBox_addAppointmentPatient.set_Text(comboBox_addAppointmentPatient.get_Text().Trim());
		if (((Selector)comboBox_addAppointmentPatient).get_SelectedIndex() == -1)
		{
			Patient patient = new Patient();
			patient.ID = Guid.NewGuid();
			patient.Name = comboBox_addAppointmentPatient.get_Text();
			DC.Patients.InsertOnSubmit(patient);
			((DataContext)DC).SubmitChanges();
		}
		Patient patient2 = ((IQueryable<Patient>)DC.Patients).Single((Patient P) => P.Name == comboBox_addAppointmentPatient.get_Text());
		appointment.Doctor_ID = doctor.ID;
		appointment.Patient_ID = patient2.ID;
		appointment.Appointment_Date = datePicker_addAppointmentDate.get_SelectedDate().Value;
		if (textBox_addAppointmentNotes.get_Text() != "")
		{
			appointment.Notes = textBox_addAppointmentNotes.get_Text();
		}
		string timeFormat;
		if (((ToggleButton)radioButton_addAppointmentAM).get_IsChecked() == true)
		{
			appointment.Timing_Zone = 'A';
			if (textBox_addAppointmentHour.get_Text().Trim() == "12")
			{
				timeFormat = "00:" + textBox_addAppointmentMinute.get_Text().Trim();
			}
			else
			{
				timeFormat = textBox_addAppointmentHour.get_Text().Trim() + ":" + textBox_addAppointmentMinute.get_Text().Trim();
			}
		}
		else
		{
			appointment.Timing_Zone = 'P';
			if (textBox_addAppointmentHour.get_Text().Trim() != "12")
			{
				int num = int.Parse(textBox_addAppointmentHour.get_Text().Trim());
				timeFormat = num + 12 + ":" + textBox_addAppointmentMinute.get_Text().Trim();
			}
			else
			{
				timeFormat = textBox_addAppointmentHour.get_Text().Trim() + ":" + textBox_addAppointmentMinute.get_Text().Trim();
			}
		}
		appointment.Appointment_Time = TimeSpan.Parse(timeFormat);
		Management Options = new Management();
		IQueryable<Appointment> source = ((IQueryable<Appointment>)DC.Appointments).Where((Appointment myMatch) => myMatch.Doctor.Name == ((Selector)comboBox_addAppointmentDoctor).get_SelectedItem().ToString() && myMatch.Appointment_Date == datePicker_addAppointmentDate.get_SelectedDate() && myMatch.Appointment_Time == TimeSpan.Parse(timeFormat));
		if (source.Count() != 0)
		{
			MessageBox.Show("يوجد موعد آخر يتضارب مع الموعد الذي تحاول إضافته\nيرجى إجراء التعديلات في الموعد السابق ثم إعادة المحاولة", "خطأ في الموعد", (MessageBoxButton)0, (MessageBoxImage)16);
			return;
		}
		IQueryable<Appointment> source2 = ((IQueryable<Appointment>)DC.Appointments).Where((Appointment myMatch) => myMatch.Doctor.Name == ((Selector)comboBox_addAppointmentDoctor).get_SelectedItem().ToString() && myMatch.Appointment_Date == datePicker_addAppointmentDate.get_SelectedDate() && checkTime(myMatch.Appointment_Time, TimeSpan.Parse(timeFormat), Options.textBox_separateMinutes.get_Text()));
		if (source2.Count() != 0)
		{
			MessageBoxResult val = MessageBox.Show(" انت تحاول إضافة موعد يتعارض مع الحد الأدنى الفاصل بين المواعيد الذي قمت بتحديده من خلال إدارة البرنامج\nهل تود تثبيت الموعد السابق أم إجراء تعديلات على التوقيت", "تنبيه", (MessageBoxButton)4, (MessageBoxImage)48);
			if ((int)val == 7)
			{
				((UIElement)textBox_addAppointmentHour).Focus();
				return;
			}
		}
		DC.Appointments.InsertOnSubmit(appointment);
		((DataContext)DC).SubmitChanges();
		if (((CollectionView)((ItemsControl)comboBox_addAppointmentDoctor).get_Items()).get_Count() > 1)
		{
			((Selector)comboBox_addAppointmentDoctor).set_SelectedIndex(-1);
		}
		((Selector)comboBox_addAppointmentPatient).set_SelectedIndex(-1);
		comboBox_addAppointmentPatient.set_Text("");
		textBox_addAppointmentHour.set_Text("ساعة");
		textBox_addAppointmentMinute.set_Text("دقيقة");
		datePicker_addAppointmentDate.set_SelectedDate((DateTime?)null);
		((ToggleButton)radioButton_addAppointmentPM).set_IsChecked((bool?)true);
		textBox_addAppointmentNotes.set_Text("");
		((Window)this).Close();
	}

	private void comboBox_addAppointmentDoctor_DropDownOpened(object sender, EventArgs e)
	{
		IQueryable<string> queryable = ((IQueryable<Doctor>)DC.Doctors).Select((Doctor doc) => doc.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_addAppointmentDoctor).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void comboBox_addAppointmentPatient_DropDownOpened(object sender, EventArgs e)
	{
		IQueryable<string> queryable = ((IQueryable<Patient>)DC.Patients).Select((Patient pat) => pat.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_addAppointmentPatient).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void textBox_addAppointmentHour_GotFocus(object sender, RoutedEventArgs e)
	{
		if (textBox_addAppointmentHour.get_Text() == "ساعة")
		{
			textBox_addAppointmentHour.set_Text("");
		}
	}

	private void textBox_addAppointmentMinute_GotFocus(object sender, RoutedEventArgs e)
	{
		if (textBox_addAppointmentMinute.get_Text() == "دقيقة")
		{
			textBox_addAppointmentMinute.set_Text("");
		}
	}

	private void textBox_addAppointmentHour_LostFocus(object sender, RoutedEventArgs e)
	{
		if (textBox_addAppointmentHour.get_Text() == "")
		{
			textBox_addAppointmentHour.set_Text("ساعة");
		}
	}

	private void textBox_addAppointmentMinute_LostFocus(object sender, RoutedEventArgs e)
	{
		if (textBox_addAppointmentMinute.get_Text() == "")
		{
			textBox_addAppointmentMinute.set_Text("دقيقة");
		}
	}

	private void comboBox_addAppointmentPatient_GotFocus(object sender, RoutedEventArgs e)
	{
		IQueryable<string> queryable = ((IQueryable<Patient>)DC.Patients).Select((Patient pat) => pat.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_addAppointmentPatient).set_ItemsSource((IEnumerable)queryable);
		}
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		InputLanguageManager.SetInputLanguage((DependencyObject)(object)textBox_addAppointmentHour, CultureInfo.CreateSpecificCulture("ar"));
		InputLanguageManager.SetInputLanguage((DependencyObject)(object)textBox_addAppointmentMinute, CultureInfo.CreateSpecificCulture("ar"));
		InputLanguageManager.SetInputLanguage((DependencyObject)(object)comboBox_addAppointmentPatient, CultureInfo.CreateSpecificCulture("ar"));
		InputLanguageManager.SetInputLanguage((DependencyObject)(object)textBox_addAppointmentNotes, CultureInfo.CreateSpecificCulture("ar"));
		IQueryable<string> queryable = ((IQueryable<Doctor>)DC.Doctors).Select((Doctor doc) => doc.Name);
		if (queryable.Count() != 0)
		{
			((ItemsControl)comboBox_addAppointmentDoctor).set_ItemsSource((IEnumerable)queryable);
			((Selector)comboBox_addAppointmentDoctor).set_SelectedIndex(-1);
			if (queryable.Count() == 1)
			{
				((Selector)comboBox_addAppointmentDoctor).set_SelectedIndex(0);
			}
		}
	}

	private void button_close_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	private void button1_Click(object sender, RoutedEventArgs e)
	{
	}

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Appointments;component/add.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			((FrameworkElement)(Add)target).add_Loaded(new RoutedEventHandler(Window_Loaded));
			break;
		case 2:
			groupBox_addAppointment = (GroupBox)target;
			break;
		case 3:
			label1 = (Label)target;
			break;
		case 4:
			label2 = (Label)target;
			break;
		case 5:
			label3 = (Label)target;
			break;
		case 6:
			label4 = (Label)target;
			break;
		case 7:
			label5 = (Label)target;
			break;
		case 8:
			comboBox_addAppointmentDoctor = (ComboBox)target;
			comboBox_addAppointmentDoctor.add_DropDownOpened((EventHandler)comboBox_addAppointmentDoctor_DropDownOpened);
			break;
		case 9:
			separator1 = (Separator)target;
			break;
		case 10:
			comboBox_addAppointmentPatient = (ComboBox)target;
			comboBox_addAppointmentPatient.add_DropDownOpened((EventHandler)comboBox_addAppointmentPatient_DropDownOpened);
			((UIElement)comboBox_addAppointmentPatient).add_GotFocus(new RoutedEventHandler(comboBox_addAppointmentPatient_GotFocus));
			break;
		case 11:
			datePicker_addAppointmentDate = (DatePicker)target;
			break;
		case 12:
			textBox_addAppointmentHour = (TextBox)target;
			((UIElement)textBox_addAppointmentHour).add_GotFocus(new RoutedEventHandler(textBox_addAppointmentHour_GotFocus));
			((UIElement)textBox_addAppointmentHour).add_LostFocus(new RoutedEventHandler(textBox_addAppointmentHour_LostFocus));
			break;
		case 13:
			textBox_addAppointmentMinute = (TextBox)target;
			((UIElement)textBox_addAppointmentMinute).add_GotFocus(new RoutedEventHandler(textBox_addAppointmentMinute_GotFocus));
			((UIElement)textBox_addAppointmentMinute).add_LostFocus(new RoutedEventHandler(textBox_addAppointmentMinute_LostFocus));
			break;
		case 14:
			label7 = (Label)target;
			break;
		case 15:
			radioButton_addAppointmentAM = (RadioButton)target;
			break;
		case 16:
			radioButton_addAppointmentPM = (RadioButton)target;
			break;
		case 17:
			textBox_addAppointmentNotes = (TextBox)target;
			break;
		case 18:
			button_addAppointment = (Button)target;
			((ButtonBase)button_addAppointment).add_Click(new RoutedEventHandler(button_addAppointment_Click));
			break;
		case 19:
			button1 = (Button)target;
			((ButtonBase)button1).add_Click(new RoutedEventHandler(button1_Click));
			break;
		case 20:
			button_close = (Button)target;
			((ButtonBase)button_close).add_Click(new RoutedEventHandler(button_close_Click));
			break;
		}
	}
}
