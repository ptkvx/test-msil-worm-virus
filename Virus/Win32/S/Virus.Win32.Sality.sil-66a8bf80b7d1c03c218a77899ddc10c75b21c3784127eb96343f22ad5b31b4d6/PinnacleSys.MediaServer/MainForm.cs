using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PinnacleSys.FirewallConfig;

namespace PinnacleSys.MediaServer;

public class MainForm : Form
{
	private IPMediaServerProxy m_MediaServerProxy = null;

	private DateTime m_FailTime;

	private Timer m_Timer = new Timer();

	private bool m_ScanSubfolder = false;

	private bool m_Relative = false;

	private string m_RelativRoot = null;

	private ArrayList m_ImportFolders = new ArrayList();

	private FolderImporter m_Importer = null;

	private bool m_Done = false;

	private int m_FolderIndex = 0;

	private bool m_Quiet = false;

	private ArrayList m_FWAddFiles = new ArrayList();

	private GroupBox groupBox;

	private Label label;

	private Container components = null;

	public MainForm(string[] args)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		if (args.Length == 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Commandline:\n");
			stringBuilder.Append("\n   /fw AppPath1 AppPath2\t- unblock firewall for these programs ( local scope )");
			stringBuilder.Append("\n   /q\t\t\t- quiet media import");
			stringBuilder.Append("\n   /r RootPath\t\t- import folders are realtiv to this root path");
			stringBuilder.Append("\n   /f Folder1 Folder2\t\t- import folders (absolut or relativ(/r) )");
			stringBuilder.Append("\n   /l FilePath\t\t- textfile which contains import folder list (absolut or relativ(/r)");
			stringBuilder.Append("\n   /s\t\t\t- scan also subfolder");
			MessageBox.Show(stringBuilder.ToString(), "PMS Install Init", (MessageBoxButtons)0, (MessageBoxIcon)64);
			throw new Exception();
		}
		ParseArgs(args);
		try
		{
			WinXPFirewall winXPFirewall = new WinXPFirewall();
			string executablePath = Application.get_ExecutablePath();
			winXPFirewall.AddApp(Path.GetFileName(executablePath), executablePath, bEnable: true, NET_FW_SCOPE_.NET_FW_SCOPE_LOCAL_SUBNET);
			for (int i = 0; i < m_FWAddFiles.Count; i++)
			{
				winXPFirewall.AddApp(Path.GetFileName((string)m_FWAddFiles[i]), (string)m_FWAddFiles[i], bEnable: true, NET_FW_SCOPE_.NET_FW_SCOPE_LOCAL_SUBNET);
			}
		}
		catch
		{
		}
		if (m_ImportFolders.Count == 0)
		{
			throw new Exception();
		}
		if (m_Quiet)
		{
			((Control)this).Hide();
		}
		else
		{
			((Control)this).Show();
		}
		m_Timer.add_Tick((EventHandler)TimerEvent);
		m_Timer.set_Interval(1000);
		m_Timer.Start();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void TimerEvent(object sender, EventArgs e)
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		if (m_MediaServerProxy == null)
		{
			m_MediaServerProxy = MediaServerProxy.CreateProxy();
			if (m_MediaServerProxy == null)
			{
				m_Timer.Stop();
				return;
			}
			m_FailTime = DateTime.Now.AddMinutes(1.0);
			Box("Waiting for MediaServer connection ...");
		}
		else if (!m_MediaServerProxy.get_IsConnected())
		{
			if (!(DateTime.Now > m_FailTime))
			{
				try
				{
					m_MediaServerProxy.Connect();
					return;
				}
				catch (MediaServerException)
				{
					return;
				}
			}
			m_Timer.Stop();
			Application.Exit();
		}
		else
		{
			if (m_Done)
			{
				return;
			}
			if (m_FolderIndex >= m_ImportFolders.Count)
			{
				m_Timer.Stop();
				Application.Exit();
				return;
			}
			if (m_Importer == null)
			{
				m_Importer = new FolderImporter(((IPMediaServer)m_MediaServerProxy).GetMediaContext((string)null));
				m_Importer.set_IncludeSubdirectories(m_ScanSubfolder);
				m_Importer.add_FileDetected(new PathFileEventHandler2(Import_FileDetected));
				m_Importer.add_Done(new PathFileEventHandler(Import_Done));
			}
			Box("Importing ... ");
			m_Importer.set_Path((string)m_ImportFolders[m_FolderIndex++]);
			m_Importer.Run();
			m_Done = false;
		}
	}

	private bool Import_FileDetected(IPMediaItem item)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Label(((IPPropertiesBase)item).get_StoragePath());
		return true;
	}

	private bool Import_Done(string fullpath)
	{
		Label("");
		m_Done = true;
		return true;
	}

	private void Box(string text)
	{
		((Control)groupBox).set_Text(text);
		((Control)groupBox).Update();
	}

	private void Label(string text)
	{
		((Control)label).set_Text(text);
		((Control)label).Update();
	}

	private bool ParseArgs(string[] args)
	{
		int num = 0;
		while (num < args.Length)
		{
			switch (args[num++].ToLower())
			{
			case "/s":
				m_ScanSubfolder = true;
				break;
			case "/q":
				m_Quiet = true;
				break;
			case "/r":
				if (num < args.Length && args[num].IndexOf("/", 0, 1) < 0)
				{
					m_RelativRoot = args[num++];
					m_Relative = true;
					break;
				}
				return false;
			case "/f":
				if (num < args.Length && args[num].IndexOf("/", 0, 1) < 0)
				{
					while (num < args.Length && args[num].IndexOf("/", 0, 1) < 0)
					{
						m_ImportFolders.Add(args[num++]);
					}
					break;
				}
				return false;
			case "/l":
				if (num < args.Length && args[num].IndexOf("/", 0, 1) < 0)
				{
					string path = args[num++];
					if (File.Exists(path))
					{
						StreamReader streamReader = null;
						try
						{
							streamReader = File.OpenText(path);
							string text;
							while ((text = streamReader.ReadLine()) != null)
							{
								if (text.Length != 0)
								{
									m_ImportFolders.Add(text);
								}
							}
						}
						catch
						{
							return false;
						}
						finally
						{
							streamReader?.Close();
						}
						break;
					}
					return false;
				}
				return false;
			case "/fw":
				if (num < args.Length && args[num].IndexOf("/", 0, 1) < 0)
				{
					while (num < args.Length && args[num].IndexOf("/", 0, 1) < 0)
					{
						m_FWAddFiles.Add(args[num++]);
					}
					break;
				}
				return false;
			}
		}
		if (m_Relative)
		{
			for (int i = 0; i < m_ImportFolders.Count; i++)
			{
				m_ImportFolders[i] = m_RelativRoot + "\\" + m_ImportFolders[i];
			}
		}
		return true;
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		groupBox = new GroupBox();
		label = new Label();
		((Control)groupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox).set_Anchor((AnchorStyles)15);
		((Control)groupBox).get_Controls().Add((Control)(object)label);
		((Control)groupBox).set_Location(new Point(8, 16));
		((Control)groupBox).set_Name("groupBox");
		((Control)groupBox).set_Size(new Size(432, 72));
		((Control)groupBox).set_TabIndex(1);
		groupBox.set_TabStop(false);
		((Control)label).set_Anchor((AnchorStyles)13);
		((Control)label).set_Location(new Point(8, 24));
		((Control)label).set_Name("label");
		((Control)label).set_Size(new Size(416, 40));
		((Control)label).set_TabIndex(0);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(448, 110));
		((Control)this).get_Controls().Add((Control)(object)groupBox);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Pinnacle Install Init");
		((Control)groupBox).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Application.Run((ApplicationContext)(object)new MyApplicationContext(args));
		}
		catch
		{
		}
	}
}
