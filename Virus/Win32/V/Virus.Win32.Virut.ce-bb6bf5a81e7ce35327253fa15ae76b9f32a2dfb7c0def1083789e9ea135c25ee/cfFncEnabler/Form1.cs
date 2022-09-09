#define TRACE
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace cfFncEnabler;

public class Form1 : Form
{
	private bool bRunningWinSidebar;

	private bool bRunningGglSidebar;

	private int nCount;

	private IContainer components;

	private Timer timer1;

	private TextBox myTextBox;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
		((Control)myTextBox).set_Text("TOSHIBA ConfigFree WPS/Sidebar gadgets enabler version 1.0.0.14.\r\n");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Invalid comparison between Unknown and I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Invalid comparison between Unknown and I4
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Invalid comparison between Unknown and I4
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Invalid comparison between Unknown and I4
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Invalid comparison between Unknown and I4
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Invalid comparison between Unknown and I4
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Invalid comparison between Unknown and I4
		try
		{
			Hashtable hashtable = new Hashtable();
			try
			{
				ManagementScope val = new ManagementScope("root\\cimv2");
				val.Connect();
				ObjectQuery val2 = new ObjectQuery("select ProductName,PNPDeviceID from Win32_NetworkAdapter");
				ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
				ManagementObjectCollection val4 = val3.Get();
				NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
				NetworkInterface[] array = allNetworkInterfaces;
				foreach (NetworkInterface networkInterface in array)
				{
					if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211)
					{
						continue;
					}
					ManagementObjectEnumerator enumerator = val4.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementObject val5 = (ManagementObject)enumerator.get_Current();
							if (!networkInterface.Description.ToString().Contains(((ManagementBaseObject)val5).GetPropertyValue("ProductName").ToString()))
							{
								continue;
							}
							if (((ManagementBaseObject)val5).GetPropertyValue("PNPDeviceID") != null)
							{
								hashtable.Add(((ManagementBaseObject)val5).GetPropertyValue("PNPDeviceID").ToString(), ((ManagementBaseObject)val5).GetPropertyValue("PNPDeviceID").ToString()!.Substring(4, 8));
								continue;
							}
							if (((ManagementBaseObject)val5).GetPropertyValue("ProductName").ToString()!.Contains("Atheros"))
							{
								hashtable.Add("PCI\\VEN_168C\\NULL", "VEN_168C");
							}
							if (((ManagementBaseObject)val5).GetPropertyValue("ProductName").ToString()!.Contains("Realtek"))
							{
								hashtable.Add("PCI\\VEN_10EC\\NULL", "VEN_10EC");
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				ndsDBGError(1, -1, "cfFncEnabler", "scope.Connect():" + ex.Message);
			}
			try
			{
				string subkey = "SOFTWARE\\TOSHIBA\\ConfigFree\\";
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
				foreach (DictionaryEntry item in hashtable)
				{
					if (item.Value!.ToString()!.CompareTo(null) == 0)
					{
						continue;
					}
					switch (item.Value!.ToString())
					{
					default:
						registryKey.SetValue("EnableWPS", 0);
						continue;
					case "VID_0BDA":
					case "VEN_10EC":
					{
						string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
						string directoryName = Path.GetDirectoryName(folderPath);
						string text = directoryName + "\\SysWOW64";
						string text2 = "\\RtlLib.dll";
						if (!File.Exists(folderPath + text2) && !File.Exists(text + text2))
						{
							registryKey.SetValue("EnableWPS", 0);
						}
						else
						{
							registryKey.SetValue("EnableWPS", 3);
						}
						break;
					}
					case "VEN_168C":
					{
						ServiceController val6 = new ServiceController("jswpsapi");
						try
						{
							if ((int)val6.get_Status() != 5 && (int)val6.get_Status() != 7 && (int)val6.get_Status() != 6 && (int)val6.get_Status() != 4 && (int)val6.get_Status() != 2 && (int)val6.get_Status() != 1 && (int)val6.get_Status() != 3)
							{
								registryKey.SetValue("EnableWPS", 0);
							}
							else
							{
								registryKey.SetValue("EnableWPS", 1);
							}
						}
						catch (Exception ex2)
						{
							ndsDBGError(1, 0, "cfWPSEnabler", ex2.Message);
							registryKey.SetValue("EnableWPS", 0);
						}
						break;
					}
					}
					break;
				}
				registryKey.Close();
			}
			catch (Exception ex3)
			{
				ndsDBGError(1, -1, "cfFncEnabler", "Registry.CurrentUser.CreateSubKey" + ex3.Message);
			}
		}
		catch (Exception ex4)
		{
			ndsDBGError(1, -1, "cfFncEnabler", "IPGlobalProperties:" + ex4.Message);
		}
		if (Environment.OSVersion.Version.Major >= 6 && Environment.OSVersion.Version.Minor >= 1)
		{
			string subkey2 = "SOFTWARE\\TOSHIBA\\ConfigFree\\";
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(subkey2);
			try
			{
				registryKey2.SetValue("EnableWPS", 0);
			}
			catch (Exception ex5)
			{
				ndsDBGError(1, -1, "Form1_Load", "Registry.CurrentUser.CreateSubKey(rKeyName):" + ex5.Message);
			}
			registryKey2.Close();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		int num = 0;
		string name = "SOFTWARE\\Wow6432Node\\TOSHIBA\\ConfigFree\\";
		string text = "SOFTWARE\\TOSHIBA\\ConfigFree\\";
		if (nCount >= 4)
		{
			timer1.Stop();
			ndsDBGError(1, -1, "timer1_Tick", "timer1 is timeout.:");
			num = 1;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text);
			try
			{
				registryKey = Registry.CurrentUser.CreateSubKey(text);
				registryKey.SetValue("GadgetsConfigured", num);
			}
			catch (Exception ex)
			{
				ndsDBGError(1, -1, "timer1_Tick", "Registry.CurrentUser.CreateSubKey(rKeyName):" + ex.Message);
			}
			registryKey.Close();
			Environment.Exit(0);
		}
		Process[] processesByName = Process.GetProcessesByName("sidebar");
		if (processesByName.Length > 0)
		{
			bRunningWinSidebar = true;
			((Control)myTextBox).set_Text("Windows Sidebar is running.\r\n");
		}
		Process[] processesByName2 = Process.GetProcessesByName("GoogleDesktop");
		if (processesByName2.Length > 0)
		{
			bRunningGglSidebar = true;
			((Control)myTextBox).set_Text("Google Sidebar is running.\r\n");
		}
		bool flag = Marshal.SizeOf((object)(nint)IntPtr.Zero) == 8;
		try
		{
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(text);
			try
			{
				num = (int)registryKey2.GetValue("GadgetsConfigured");
			}
			catch (Exception ex2)
			{
				ndsDBGError(1, -1, "timer1_Tick", "Registry.CurrentUser.OpenSubKey(rKeyName):nGadgetsConfigured:" + ex2.Message);
			}
			finally
			{
				registryKey2.Close();
			}
			int num2 = 2;
			try
			{
				registryKey2 = ((!flag) ? Registry.LocalMachine.OpenSubKey(text) : Registry.LocalMachine.OpenSubKey(name));
				num2 = (int)registryKey2.GetValue("EnableGadgets", 2);
			}
			catch (Exception ex3)
			{
				ndsDBGError(1, -1, "timer1_Tick", "Registry.LocalMachine.OpenSubKey(rKeyName):nEnableGadgets:" + ex3.Message);
			}
			finally
			{
				registryKey2.Close();
			}
			if (num == 0)
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				string text2 = folderPath + " (x86)";
				string text3 = "\\Windows Sidebar\\sidebar.exe";
				string text4 = "\\TOSHIBA\\ConfigFree\\";
				if (bRunningWinSidebar && num2 != 2)
				{
					try
					{
						Process[] processesByName3 = Process.GetProcessesByName("sidebar");
						Process[] array = processesByName3;
						foreach (Process process in array)
						{
							try
							{
								process.Kill();
							}
							catch (Exception ex4)
							{
								ndsDBGError(1, -1, "cfFncEnabler", "p.Kill():" + ex4.Message);
							}
						}
					}
					catch (Exception ex5)
					{
						ndsDBGError(1, -1, "cfFncEnabler", "p.Kill():" + ex5.Message);
					}
				}
				try
				{
					if (num2 != 2)
					{
						if (flag)
						{
							Process.Start("\"" + text2 + text4 + "AddGadget.exe\"", "-add \"" + text2 + text4 + "SrcSetting.ini\"");
							TextBox obj = myTextBox;
							((Control)obj).set_Text(((Control)obj).get_Text() + "AddGadget.exe registered (x64)\r\n");
							num = 1;
							timer1.Stop();
						}
						else
						{
							Process.Start("\"" + folderPath + text4 + "AddGadget.exe\"", "-add \"" + folderPath + text4 + "SrcSetting.ini\"");
							TextBox obj2 = myTextBox;
							((Control)obj2).set_Text(((Control)obj2).get_Text() + "AddGadget.exe registered (x86)\r\n");
							num = 1;
							timer1.Stop();
						}
					}
				}
				catch (Exception ex6)
				{
					ndsDBGError(1, -1, "timer1_Tick", "System.Diagnostics.Process.Start:Enable:" + ex6.Message);
				}
				try
				{
					registryKey2 = Registry.CurrentUser.CreateSubKey(text);
					registryKey2.SetValue("GadgetsConfigured", num);
				}
				catch (Exception ex7)
				{
					ndsDBGError(1, -1, "timer1_Tick", "Registry.CurrentUser.CreateSubKey(rKeyName):" + ex7.Message);
				}
				finally
				{
					registryKey2.Close();
				}
				if (num2 == 1 && bRunningWinSidebar && !bRunningGglSidebar)
				{
					Thread.Sleep(500);
					Process.Start("\"" + folderPath + text3 + "\"");
				}
			}
			else
			{
				((Control)myTextBox).set_Text("Gadget setting has already done.\r\n");
			}
		}
		catch (Exception ex8)
		{
			ndsDBGError(1, -1, "timer1_Tick", "Registry.CurrentUser.CreateSubKey(2):" + ex8.Message);
		}
		if (num == 1)
		{
			TextBox obj3 = myTextBox;
			((Control)obj3).set_Text(((Control)obj3).get_Text() + nCount + "Exit.\r\n");
			Environment.Exit(0);
		}
		TextBox obj4 = myTextBox;
		((Control)obj4).set_Text(((Control)obj4).get_Text() + nCount + ": timer1_Tick finished.\r\n");
		nCount++;
	}

	private void ndsDBGError(int i, int err, string function, string error)
	{
		if (i == 1)
		{
			string text = "Warining:";
			Trace.WriteLine(text + "\"" + error + "\" in " + function + "(" + err + ")");
			TextBox obj = myTextBox;
			string text2 = ((Control)obj).get_Text();
			((Control)obj).set_Text(text2 + text + "\"" + error + "\" in " + function + "(" + err + ")\r\n");
		}
		else
		{
			string text = "Fatal:";
			Trace.WriteLine(text + "\"" + error + "\" in " + function + "(" + err + ")");
			TextBox obj2 = myTextBox;
			string text3 = ((Control)obj2).get_Text();
			((Control)obj2).set_Text(text3 + text + "\"" + error + "\" in " + function + "(" + err + ")\r\n");
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		myTextBox = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(3000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)myTextBox).set_Location(new Point(12, 12));
		((TextBoxBase)myTextBox).set_Multiline(true);
		((Control)myTextBox).set_Name("myTextBox");
		myTextBox.set_ScrollBars((ScrollBars)2);
		((Control)myTextBox).set_Size(new Size(560, 210));
		((Control)myTextBox).set_TabIndex(0);
		((Control)button1).set_Location(new Point(497, 228));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(584, 263));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)myTextBox);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("cfFncEnabler");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
