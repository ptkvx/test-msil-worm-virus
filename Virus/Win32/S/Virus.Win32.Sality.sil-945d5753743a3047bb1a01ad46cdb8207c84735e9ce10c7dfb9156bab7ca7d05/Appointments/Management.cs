using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Data.Linq;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using Microsoft.Win32;
using Microsoft.Windows.Controls;

namespace Appointments;

[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
public class Management : Window, IComponentConnector
{
	private myAppointmentsDataContext DC = new myAppointmentsDataContext();

	private RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);

	internal Management myManagementWindow;

	internal GroupBox groupBox_controlDoctors;

	internal Label label1;

	internal TextBox textBox_addDoctor;

	internal Button button_addDoctor;

	internal Label label2;

	internal Button button_deleteDoctor;

	internal ComboBox comboBox_deleteDoctor;

	internal Separator separator1;

	internal GroupBox groupBox_controls;

	internal CheckBox checkBox_autoStart;

	internal CheckBox checkBox_activeVoice;

	internal Label label3;

	internal TextBox textBox_minutes;

	internal Label label4;

	internal CheckBox checkBox1;

	internal TextBox textBox_separateMinutes;

	internal Label label5;

	internal CheckBox checkBox2;

	internal TextBox textBox_oldMinutes;

	internal Label label6;

	internal Button button_back;

	private bool _contentLoaded;

	public Management()
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

	private void button_back_Click(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
		myManagementWindow.Window_Loaded(sender, e);
	}

	private void button_deleteDoctor_Click(object sender, RoutedEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Invalid comparison between Unknown and I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Invalid comparison between Unknown and I4
		MessageBoxResult val;
		if (((Selector)comboBox_deleteDoctor).get_SelectedIndex() == -1)
		{
			val = MessageBox.Show("لم يتم اختيار أي طبيب , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			if ((int)val == 1)
			{
				((UIElement)comboBox_deleteDoctor).Focus();
			}
			return;
		}
		val = MessageBox.Show("هل تريد بالتأكيد حذف الطبيب الذي قمت باختياره\nإن حذف الطبيب سيؤدي إلى حذف جميع مواعيده التي تم تحديدها مسبقا", "انتبه", (MessageBoxButton)4, (MessageBoxImage)48);
		if ((int)val == 6)
		{
			((Selector)comboBox_deleteDoctor).get_SelectedItem().ToString();
			IQueryable<Appointment> queryable = ((IQueryable<Appointment>)DC.Appointments).Where((Appointment myApp) => myApp.Doctor.Name == ((Selector)comboBox_deleteDoctor).get_SelectedItem().ToString());
			foreach (Appointment item in queryable)
			{
				DC.Appointments.DeleteOnSubmit(item);
			}
			((DataContext)DC).SubmitChanges();
			Doctor doctor = ((IQueryable<Doctor>)DC.Doctors).Single((Doctor doc) => doc.Name == ((Selector)comboBox_deleteDoctor).get_SelectedItem().ToString());
			DC.Doctors.DeleteOnSubmit(doctor);
			((DataContext)DC).SubmitChanges();
			MessageBoxResult val2 = MessageBox.Show("لقد تمت عملية الحذف بنجاح", "تأكيد", (MessageBoxButton)0, (MessageBoxImage)64);
			if ((int)val2 == 1)
			{
				((Selector)comboBox_deleteDoctor).set_SelectedIndex(-1);
				((UIElement)comboBox_deleteDoctor).Focus();
			}
		}
		else if ((int)val == 7)
		{
			((Selector)comboBox_deleteDoctor).set_SelectedIndex(-1);
			((UIElement)comboBox_deleteDoctor).Focus();
		}
	}

	private void button_addDoctor_Click(object sender, RoutedEventArgs e)
	{
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		IQueryable<string> source = from doc in (IQueryable<Doctor>)DC.Doctors
			where doc.Name == textBox_addDoctor.get_Text()
			select doc.Name;
		if (string.IsNullOrWhiteSpace(textBox_addDoctor.get_Text()))
		{
			textBox_addDoctor.set_Text("");
			((UIElement)textBox_addDoctor).Focus();
		}
		else if (textBox_addDoctor.get_Text() != "تمت إضافة الاسم بنجاح")
		{
			if (source.Count() == 0)
			{
				Doctor doctor = new Doctor();
				doctor.ID = Guid.NewGuid();
				doctor.Name = textBox_addDoctor.get_Text().Trim();
				DC.Doctors.InsertOnSubmit(doctor);
				((DataContext)DC).SubmitChanges();
				textBox_addDoctor.set_Text("تمت إضافة الاسم بنجاح");
			}
			else if (source.Count() != 0)
			{
				MessageBoxResult val = MessageBox.Show("هذا الاسم مسجل مسبقا , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
				if ((int)val == 1)
				{
					textBox_addDoctor.set_Text("");
					((UIElement)textBox_addDoctor).Focus();
				}
			}
		}
		else if (textBox_addDoctor.get_Text() == "تمت إضافة الاسم بنجاح")
		{
			MessageBoxResult val = MessageBox.Show("لم يتم إدخال اسم محدد , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			if ((int)val == 1)
			{
				textBox_addDoctor.set_Text("");
				((UIElement)textBox_addDoctor).Focus();
			}
		}
	}

	private void textBox_addDoctor_GotFocus(object sender, RoutedEventArgs e)
	{
		if (textBox_addDoctor.get_Text() == "تمت إضافة الاسم بنجاح")
		{
			textBox_addDoctor.set_Text("");
		}
	}

	private void checkBox_autoStart_Checked(object sender, RoutedEventArgs e)
	{
		rkApp.SetValue("Appointment_Organizer", Assembly.GetExecutingAssembly().Location);
	}

	private void checkBox_autoStart_Unchecked(object sender, RoutedEventArgs e)
	{
		rkApp.DeleteValue("Appointment_Organizer", throwOnMissingValue: false);
	}

	private void checkBox_activeVoice_Checked(object sender, RoutedEventArgs e)
	{
		((UIElement)label3).set_IsEnabled(true);
		((UIElement)label4).set_IsEnabled(true);
		((UIElement)textBox_minutes).set_IsEnabled(true);
	}

	private void comboBox_deleteDoctor_DropDownOpened(object sender, EventArgs e)
	{
		IQueryable<string> itemsSource = ((IQueryable<Doctor>)DC.Doctors).Select((Doctor doc) => doc.Name);
		((ItemsControl)comboBox_deleteDoctor).set_ItemsSource((IEnumerable)itemsSource);
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		InputLanguageManager.SetInputLanguage((DependencyObject)(object)textBox_addDoctor, CultureInfo.CreateSpecificCulture("ar"));
	}

	private void textBox_minutes_TextChanged(object sender, TextChangedEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (!is_Numeric(textBox_minutes.get_Text()))
		{
			MessageBox.Show("يرجى استخدام الأرقام فقط , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_minutes.set_Text("");
			((UIElement)textBox_minutes).Focus();
		}
	}

	private void checkBox_activeVoice_Unchecked(object sender, RoutedEventArgs e)
	{
		((UIElement)label3).set_IsEnabled(false);
		((UIElement)label4).set_IsEnabled(false);
		((UIElement)textBox_minutes).set_IsEnabled(false);
	}

	private void textBox_separateMinutes_TextChanged(object sender, TextChangedEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (!is_Numeric(textBox_separateMinutes.get_Text()))
		{
			MessageBox.Show("يرجى استخدام الأرقام فقط , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_separateMinutes.set_Text("");
			((UIElement)textBox_separateMinutes).Focus();
		}
	}

	private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (!is_Numeric(textBox_oldMinutes.get_Text()))
		{
			MessageBox.Show("يرجى استخدام الأرقام فقط , يرجى إعادة المحاولة", "خطأ في الإدخال", (MessageBoxButton)0, (MessageBoxImage)16);
			textBox_oldMinutes.set_Text("");
			((UIElement)textBox_oldMinutes).Focus();
		}
	}

	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/Appointments;component/management.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			break;
		case 1:
			myManagementWindow = (Management)target;
			((FrameworkElement)myManagementWindow).add_Loaded(new RoutedEventHandler(Window_Loaded));
			break;
		case 2:
			groupBox_controlDoctors = (GroupBox)target;
			break;
		case 3:
			label1 = (Label)target;
			break;
		case 4:
			textBox_addDoctor = (TextBox)target;
			((UIElement)textBox_addDoctor).add_GotFocus(new RoutedEventHandler(textBox_addDoctor_GotFocus));
			break;
		case 5:
			button_addDoctor = (Button)target;
			((ButtonBase)button_addDoctor).add_Click(new RoutedEventHandler(button_addDoctor_Click));
			break;
		case 6:
			label2 = (Label)target;
			break;
		case 7:
			button_deleteDoctor = (Button)target;
			((ButtonBase)button_deleteDoctor).add_Click(new RoutedEventHandler(button_deleteDoctor_Click));
			break;
		case 8:
			comboBox_deleteDoctor = (ComboBox)target;
			comboBox_deleteDoctor.add_DropDownOpened((EventHandler)comboBox_deleteDoctor_DropDownOpened);
			break;
		case 9:
			separator1 = (Separator)target;
			break;
		case 10:
			groupBox_controls = (GroupBox)target;
			break;
		case 11:
			checkBox_autoStart = (CheckBox)target;
			((ToggleButton)checkBox_autoStart).add_Checked(new RoutedEventHandler(checkBox_autoStart_Checked));
			((ToggleButton)checkBox_autoStart).add_Unchecked(new RoutedEventHandler(checkBox_autoStart_Unchecked));
			break;
		case 12:
			checkBox_activeVoice = (CheckBox)target;
			((ToggleButton)checkBox_activeVoice).add_Checked(new RoutedEventHandler(checkBox_activeVoice_Checked));
			((ToggleButton)checkBox_activeVoice).add_Unchecked(new RoutedEventHandler(checkBox_activeVoice_Unchecked));
			break;
		case 13:
			label3 = (Label)target;
			break;
		case 14:
			textBox_minutes = (TextBox)target;
			((TextBoxBase)textBox_minutes).add_TextChanged(new TextChangedEventHandler(textBox_minutes_TextChanged));
			break;
		case 15:
			label4 = (Label)target;
			break;
		case 16:
			checkBox1 = (CheckBox)target;
			break;
		case 17:
			textBox_separateMinutes = (TextBox)target;
			((TextBoxBase)textBox_separateMinutes).add_TextChanged(new TextChangedEventHandler(textBox_separateMinutes_TextChanged));
			break;
		case 18:
			label5 = (Label)target;
			break;
		case 19:
			checkBox2 = (CheckBox)target;
			break;
		case 20:
			textBox_oldMinutes = (TextBox)target;
			((TextBoxBase)textBox_oldMinutes).add_TextChanged(new TextChangedEventHandler(textBox1_TextChanged));
			break;
		case 21:
			label6 = (Label)target;
			break;
		case 22:
			button_back = (Button)target;
			((ButtonBase)button_back).add_Click(new RoutedEventHandler(button_back_Click));
			break;
		}
	}
}
