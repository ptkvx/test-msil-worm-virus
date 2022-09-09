using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace hpCasl;

public class Notification : Form
{
	private ArrayList arrayList_0 = new ArrayList();

	private ProgressBar_1 progressBar_1_0;

	private ArrayList arrayList_1 = new ArrayList();

	private IContainer icontainer_0;

	private TextBox tbMessages;

	protected override bool ShowWithoutActivation => true;

	public static bool smethod_0(string string_0)
	{
		return GClass2.smethod_0(string_0);
	}

	public Notification(string string_0)
	{
		if (!method_0())
		{
			((Form)this).set_WindowState((FormWindowState)1);
			((Form)this).set_ShowInTaskbar(false);
		}
		InitializeComponent();
		((Control)this).set_Text("hpNotification.c9c74d8c-a080-41c1-8521-4148c8764789");
		method_2(string_0, bool_0: true);
	}

	[SpecialName]
	private bool method_0()
	{
		return Class1.class0_0.method_24();
	}

	private void method_1(string string_0)
	{
		if (method_0())
		{
			TextBox obj = tbMessages;
			((Control)obj).set_Text(((Control)obj).get_Text() + string_0);
			TextBox obj2 = tbMessages;
			((Control)obj2).set_Text(((Control)obj2).get_Text() + "\r\n");
			((TextBoxBase)tbMessages).set_SelectionStart(((Control)tbMessages).get_Text().Length);
			((TextBoxBase)tbMessages).ScrollToCaret();
		}
	}

	private void method_2(string string_0, bool bool_0)
	{
		if (method_0())
		{
			method_1(" = ProcessParameter ==========");
			method_1(string_0);
			method_1(" =============================");
		}
		try
		{
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(string_0));
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType == XmlNodeType.Element)
				{
					switch (xmlTextReader.Name)
					{
					case "Command":
						xmlTextReader.MoveToContent();
						xmlTextReader.Read();
						method_4(xmlTextReader.Value, bool_0);
						break;
					case "MultiIcon":
					{
						string string_3 = xmlTextReader.ReadOuterXml();
						method_15(string_3);
						break;
					}
					case "ProgressBar":
					{
						string string_2 = xmlTextReader.ReadOuterXml();
						method_11(string_2);
						break;
					}
					case "Toast":
					{
						string string_ = xmlTextReader.ReadOuterXml();
						method_7(string_);
						break;
					}
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_3()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
		{
			((Control)this).Hide();
			((Form)this).Close();
		});
	}

	private void method_4(string string_0, bool bool_0)
	{
		string text;
		if ((text = string_0) != null && text == "Shutdown" && !bool_0)
		{
			method_3();
		}
	}

	private void method_5()
	{
		if (method_6() == 0 && method_10() == 0 && method_13() == 0 && !method_0())
		{
			method_3();
		}
	}

	[SpecialName]
	private int method_6()
	{
		return arrayList_0.Count;
	}

	private bool method_7(string string_0)
	{
		uint uint_ = 0u;
		bool flag = false;
		if (Toast_1.smethod_1(string_0, out uint_))
		{
			foreach (Toast_1 item in arrayList_0)
			{
				if (item.method_5() == uint_)
				{
					item.method_6(string_0);
					flag = true;
				}
			}
		}
		if (!flag)
		{
			try
			{
				if (method_6() >= Toast_1.smethod_0())
				{
					return flag;
				}
				Toast_1 toast_2 = new Toast_1(method_9, method_6(), method_14(), string_0);
				arrayList_0.Add(toast_2);
				GClass3.smethod_0((Form)(object)toast_2);
				((Control)toast_2).Show();
				flag = true;
				return flag;
			}
			catch (Exception ex)
			{
				method_1(ex.Message);
				return flag;
			}
		}
		return flag;
	}

	private void method_8()
	{
		foreach (Toast_1 item in arrayList_0)
		{
			item.method_7(method_14());
			item.method_9();
		}
	}

	internal void method_9(Toast_1 toast_1_0)
	{
		int num = 0;
		arrayList_0.Remove(toast_1_0);
		foreach (Toast_1 item in arrayList_0)
		{
			item.method_8(num++);
			item.method_9();
		}
		method_5();
	}

	[SpecialName]
	private int method_10()
	{
		if (progressBar_1_0 == null)
		{
			return 0;
		}
		return 1;
	}

	private bool method_11(string string_0)
	{
		bool flag = false;
		if (progressBar_1_0 != null)
		{
			progressBar_1_0.method_5(string_0);
			return true;
		}
		progressBar_1_0 = new ProgressBar_1(method_12, string_0);
		GClass3.smethod_0((Form)(object)progressBar_1_0);
		((Control)progressBar_1_0).Show();
		return true;
	}

	internal void method_12()
	{
		progressBar_1_0 = null;
		method_5();
	}

	[SpecialName]
	private int method_13()
	{
		return arrayList_1.Count;
	}

	[SpecialName]
	private Point method_14()
	{
		Point result = new Point(Screen.get_PrimaryScreen().get_WorkingArea().Right, Screen.get_PrimaryScreen().get_WorkingArea().Bottom);
		if (method_13() != 0)
		{
			MultiIcon_1 multiIcon_ = (MultiIcon_1)arrayList_1[method_13() - 1];
			return multiIcon_.method_6();
		}
		return result;
	}

	private bool method_15(string string_0)
	{
		uint uint_ = 0u;
		bool flag = false;
		if (MultiIcon_1.smethod_1(string_0, out uint_))
		{
			foreach (MultiIcon_1 item in arrayList_1)
			{
				if (item.method_5() == uint_)
				{
					item.method_7(string_0);
					flag = true;
				}
			}
		}
		if (!flag)
		{
			try
			{
				if (method_13() < MultiIcon_1.smethod_0())
				{
					MultiIcon_1 multiIcon_2 = new MultiIcon_1(method_16, method_13(), string_0);
					arrayList_1.Add(multiIcon_2);
					GClass3.smethod_0((Form)(object)multiIcon_2);
					((Control)multiIcon_2).Show();
					flag = true;
				}
			}
			catch (Exception ex)
			{
				method_1(ex.Message);
			}
		}
		if (flag)
		{
			method_8();
		}
		return flag;
	}

	internal void method_16(MultiIcon_1 multiIcon_1_0)
	{
		int num = 0;
		arrayList_1.Remove(multiIcon_1_0);
		foreach (MultiIcon_1 item in arrayList_1)
		{
			item.method_8(num++);
		}
		method_8();
		method_5();
	}

	protected override void WndProc(ref Message message_0)
	{
		int msg = ((Message)(ref message_0)).get_Msg();
		if (msg == 74)
		{
			string string_ = Marshal.PtrToStringUni(((GClass3.GStruct1)((Message)(ref message_0)).GetLParam(typeof(GClass3.GStruct1))).intptr_1);
			method_2(string_, bool_0: false);
		}
		else
		{
			((Form)this).WndProc(ref message_0);
		}
	}

	private void Notification_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	private void Notification_SizeChanged(object sender, EventArgs e)
	{
		((Control)tbMessages).set_Location(new Point(0, 0));
		((Control)tbMessages).set_Size(((Form)this).get_ClientSize());
	}

	private void Notification_Load(object sender, EventArgs e)
	{
		try
		{
			Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MinWorkingSet;
		}
		catch
		{
		}
		method_5();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		tbMessages = new TextBox();
		((Control)this).SuspendLayout();
		((Control)tbMessages).set_Location(new Point(-1, -1));
		((TextBoxBase)tbMessages).set_Multiline(true);
		((Control)tbMessages).set_Name("tbMessages");
		((TextBoxBase)tbMessages).set_ReadOnly(true);
		tbMessages.set_ScrollBars((ScrollBars)3);
		((Control)tbMessages).set_Size(new Size(275, 255));
		((Control)tbMessages).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 14f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ContainerControl)this).set_AutoValidate((AutoValidate)0);
		((Control)this).set_CausesValidation(false);
		((Form)this).set_ClientSize(new Size(274, 252));
		((Control)this).get_Controls().Add((Control)(object)tbMessages);
		((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this).set_Name("Notification");
		((Control)this).set_Text("hp Notification");
		((Form)this).add_Load((EventHandler)Notification_Load);
		((Control)this).add_SizeChanged((EventHandler)Notification_SizeChanged);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Notification_FormClosed));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void method_17()
	{
		((Control)this).Hide();
		((Form)this).Close();
	}
}
