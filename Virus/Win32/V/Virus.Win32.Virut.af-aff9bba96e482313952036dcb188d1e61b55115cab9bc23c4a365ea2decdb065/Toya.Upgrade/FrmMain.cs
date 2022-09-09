using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace Toya.Upgrade;

public class FrmMain : Form
{
	private delegate void ChangeInt(int value);

	private delegate void ChangeString(string value);

	private IContainer components;

	private Label label1;

	private Label label2;

	private Label lblStatus;

	private Label lblSpeed;

	private Label lblMessage;

	private ProgressBar progressBarControlDownload;

	private Thread ThreadDown;

	private bool IsDownFile = true;

	private string StrFileName;

	private string StrUrl;

	private bool ReTransfers;

	private string FileName = string.Empty;

	private string Caption;

	private string UpdateUrl;

	private string[] args;

	public static string CompanyCode
	{
		get
		{
			string text = string.Empty;
			if (text == string.Empty)
			{
				text = ConfigurationManager.get_AppSettings()["CompanyCode"];
				if (string.IsNullOrEmpty(text))
				{
					text = "";
				}
			}
			return text;
		}
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FrmMain));
		label1 = new Label();
		label2 = new Label();
		lblStatus = new Label();
		lblSpeed = new Label();
		lblMessage = new Label();
		progressBarControlDownload = new ProgressBar();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(2, 20));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(89, 12));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("下载文件状态：");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(2, 44));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(89, 12));
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("下载文件速率：");
		((Control)lblStatus).set_AutoSize(true);
		((Control)lblStatus).set_Location(new Point(86, 20));
		((Control)lblStatus).set_Name("lblStatus");
		((Control)lblStatus).set_Size(new Size(113, 12));
		((Control)lblStatus).set_TabIndex(9);
		((Control)lblStatus).set_Text("正在初始化下载……");
		((Control)lblSpeed).set_AutoSize(true);
		((Control)lblSpeed).set_Location(new Point(86, 44));
		((Control)lblSpeed).set_Name("lblSpeed");
		((Control)lblSpeed).set_Size(new Size(41, 12));
		((Control)lblSpeed).set_TabIndex(10);
		((Control)lblSpeed).set_Text("0KB/秒");
		((Control)lblMessage).set_ForeColor(Color.Red);
		((Control)lblMessage).set_Location(new Point(12, 107));
		((Control)lblMessage).set_Name("lblMessage");
		((Control)lblMessage).set_Size(new Size(532, 21));
		((Control)lblMessage).set_TabIndex(11);
		((Control)progressBarControlDownload).set_Location(new Point(5, 71));
		((Control)progressBarControlDownload).set_Name("progressBarControlDownload");
		((Control)progressBarControlDownload).set_Size(new Size(539, 23));
		((Control)progressBarControlDownload).set_TabIndex(12);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(556, 137));
		((Control)this).get_Controls().Add((Control)(object)progressBarControlDownload);
		((Control)this).get_Controls().Add((Control)(object)lblMessage);
		((Control)this).get_Controls().Add((Control)(object)lblSpeed);
		((Control)this).get_Controls().Add((Control)(object)lblStatus);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("FrmMain");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("通亚物流软件在线升级系统V3.5");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)FrmMain_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public FrmMain()
	{
		InitializeComponent();
	}

	public FrmMain(string[] args)
	{
		InitializeComponent();
		this.args = args;
	}

	private void FrmMain_Load(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (args.Length == 0)
		{
			MessageBox.Show("升级程序启动失败", "提示", (MessageBoxButtons)0, (MessageBoxIcon)16);
			Application.Exit();
		}
		UpdateUrl = AppFile.Read("UpgrateConfig", "UpdateUrl", " http://www.youlm.com/Upgrade", 32);
		Caption = AppFile.Read("UpgrateConfig", "UpdateText", "通亚物流软件在线升级系统V3.5", 32);
		((Control)this).set_Text(Caption);
		FileName = "/Toya.Upgrade." + CompanyCode + ".zip";
		Upgrade();
	}

	private void Upgrade()
	{
		ReTransfers = true;
		StrUrl = UpdateUrl + FileName;
		if (File.Exists(Application.get_StartupPath() + FileName))
		{
			File.Delete(Application.get_StartupPath() + FileName);
			File.Delete(Application.get_StartupPath() + "/Toya.Upgrade.Dos.exe");
		}
		StrFileName = Application.get_StartupPath() + FileName;
		ThreadDown = new Thread(DownFile);
		ThreadDown.Start();
	}

	private void SetStatusText(string value)
	{
		((Control)lblStatus).set_Text(value);
	}

	private void SetSpeedText(string value)
	{
		((Control)lblSpeed).set_Text(value);
	}

	private void SetMessageText(string value)
	{
		((Control)lblMessage).set_Text(value);
	}

	private void progressBarControlDownloadValue(int value)
	{
		progressBarControlDownload.set_Value(value);
	}

	private void progressBarControlDownloadMaximum(int value)
	{
		progressBarControlDownload.set_Maximum(value);
	}

	private void DownFile()
	{
		long num = 0L;
		FileStream fileStream;
		if (ReTransfers & File.Exists(StrFileName))
		{
			fileStream = new FileStream(StrFileName, FileMode.Open, FileAccess.ReadWrite);
			num = fileStream.Length;
			fileStream.Seek(num, SeekOrigin.Current);
		}
		else
		{
			fileStream = new FileStream(StrFileName, FileMode.Create, FileAccess.Write);
		}
		try
		{
			((Control)lblStatus).BeginInvoke((Delegate)new ChangeString(SetStatusText), new object[1] { "读取远程文件大小..." });
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(StrUrl);
			if (num > 0L)
			{
				httpWebRequest.AddRange((int)num);
			}
			Stream responseStream = httpWebRequest.GetResponse().GetResponseStream();
			WebResponse response = httpWebRequest.GetResponse();
			int num2 = (int)response.ContentLength;
			((Control)progressBarControlDownload).BeginInvoke((Delegate)new ChangeInt(progressBarControlDownloadMaximum), new object[1] { num2 });
			((Control)lblStatus).BeginInvoke((Delegate)new ChangeString(SetStatusText), new object[1] { "正在下载数据...." });
			byte[] array = new byte[204800];
			int num3 = 0;
			DateTime now = DateTime.Now;
			while ((num3 = responseStream.Read(array, 0, array.Length)) > 0)
			{
				fileStream.Write(array, 0, num3);
				num += num3;
				double num4 = (double)num / (DateTime.Now - now).TotalSeconds / 1024.0;
				((Control)lblSpeed).BeginInvoke((Delegate)new ChangeString(SetSpeedText), new object[1] { $"{(int)num4}KB/秒" });
				((Control)progressBarControlDownload).BeginInvoke((Delegate)new ChangeInt(progressBarControlDownloadValue), new object[1] { (int)num });
				if (!IsDownFile)
				{
					break;
				}
			}
			fileStream.Close();
			responseStream.Close();
			((Control)lblStatus).BeginInvoke((Delegate)new ChangeString(SetStatusText), new object[1] { "文件下载完毕!" });
			((Control)lblStatus).BeginInvoke((Delegate)new ChangeString(SetStatusText), new object[1] { "正在解压软件包和更新!" });
			Thread.Sleep(5000);
			if (UnZIP())
			{
				AppFile.Write("system", "VersionMain", args[0]);
				if (File.Exists(Application.get_StartupPath() + "/Toya.Upgrade.Dos.exe"))
				{
					Process process = new Process();
					process.StartInfo.FileName = "Toya.Upgrade.Dos.exe";
					process.StartInfo.UseShellExecute = true;
					process.Start();
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = "Toya.exe";
				process2.StartInfo.UseShellExecute = true;
				process2.Start();
				Application.Exit();
			}
		}
		catch (Exception ex)
		{
			fileStream.Close();
			((Control)lblStatus).BeginInvoke((Delegate)new ChangeString(SetStatusText), new object[1] { "下载出错，" + ex.Message });
		}
	}

	private bool UnZIP()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			ZipInputStream val = new ZipInputStream((Stream)File.OpenRead(Application.get_StartupPath() + FileName));
			try
			{
				ZipEntry nextEntry;
				while ((nextEntry = val.GetNextEntry()) != null)
				{
					string directoryName = Path.GetDirectoryName(nextEntry.get_Name());
					string fileName = Path.GetFileName(nextEntry.get_Name());
					if (directoryName.Length > 0)
					{
						Directory.CreateDirectory(directoryName);
					}
					if (!(fileName != string.Empty))
					{
						continue;
					}
					using FileStream fileStream = File.Create(nextEntry.get_Name());
					int num = 2048;
					byte[] array = new byte[2048];
					while (true)
					{
						num = ((Stream)(object)val).Read(array, 0, array.Length);
						if (num > 0)
						{
							fileStream.Write(array, 0, num);
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			((Control)lblMessage).BeginInvoke((Delegate)new ChangeString(SetMessageText), new object[1] { "升级出现错误，请关闭通亚物流软件，然后尝试从新升级。" });
			return false;
		}
	}

	private void btnUpgrade_Click(object sender, EventArgs e)
	{
		Upgrade();
	}
}
