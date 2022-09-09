using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Resources;
using System.Windows.Forms;
using System.Xml;

namespace urDrive.unInstall;

public class frmSysInformation : Form
{
	private const string MessageBoxYes = "MessageBox_Yes";

	private const string unInstaller_Invalidparameter = "unInstaller_Invalidparameter";

	private const string unInstaller_Sucess = "unInstaller_Sucess";

	private const string MessageBoxNo = "MessageBox_No";

	private const string unInstaller_Failed = "unInstaller_Failed";

	private const string unInstaller_Title = "unInstaller_Title";

	private const string unInstaller_Information = "unInstaller_Information";

	private static readonly string sUninstall2File = "unInstall2.exe";

	private static readonly string sUninstall3File = "unInstall3.exe";

	private string sUninstall2Path = string.Empty;

	private string sTempFolder = string.Empty;

	private string strAppConfigPath = Application.get_StartupPath();

	private IContainer components;

	private Label label1;

	private Button button1;

	private Button button2;

	public frmSysInformation()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		submitUUID();
		string directoryRoot = Directory.GetDirectoryRoot(Application.get_StartupPath());
		string text = directoryRoot + "urDrive";
		sUninstall2Path = sTempFolder + "\\" + sUninstall2File;
		string sourceFileName = text + "\\" + sUninstall2File;
		string @string = SystemInfo.MyResManager.GetString("MessageBox_Yes", SystemInfo.MyCulture);
		SystemInfo.MyResManager.GetString("unInstaller_Invalidparameter", SystemInfo.MyCulture);
		string string2 = SystemInfo.MyResManager.GetString("unInstaller_Sucess", SystemInfo.MyCulture);
		string string3 = SystemInfo.MyResManager.GetString("unInstaller_Failed", SystemInfo.MyCulture);
		try
		{
			try
			{
				FileInfo fileInfo = new FileInfo(sUninstall2Path);
				if (fileInfo.Exists)
				{
					File.Delete(sUninstall2Path);
				}
				File.Copy(sourceFileName, sUninstall2Path, overwrite: true);
			}
			catch
			{
				sUninstall2Path = sTempFolder + "\\" + sUninstall3File;
				FileInfo fileInfo2 = new FileInfo(sUninstall2Path);
				if (fileInfo2.Exists)
				{
					File.Delete(sUninstall2Path);
				}
				File.Copy(sourceFileName, sUninstall2Path, overwrite: true);
			}
			Process process = new Process();
			directoryRoot = directoryRoot.Trim() + "*" + @string + "*" + string2.Replace(" ", "#") + "*" + string3.Replace(" ", "#");
			process.StartInfo.Arguments = directoryRoot;
			process.StartInfo.FileName = sUninstall2Path;
			process.StartInfo.WorkingDirectory = sTempFolder;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			submitUUID();
		}
		catch
		{
			string string4 = SystemInfo.MyResManager.GetString("unInstaller_Failed", SystemInfo.MyCulture);
			showResult(string4);
		}
		((Form)this).set_DialogResult((DialogResult)6);
		((Form)this).Close();
	}

	private void submitUUID()
	{
		string url = ".\\urDrive\\Config\\AppConfig.xml";
		string text = string.Empty;
		string text2 = string.Empty;
		try
		{
			XmlReader xmlReader = new XmlTextReader(url);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(xmlReader);
			XmlNode documentElement = xmlDocument.DocumentElement;
			XmlNode xmlNode = documentElement.SelectSingleNode("WhatsNew");
			if (xmlNode != null)
			{
				text = xmlNode.Attributes!["UUID"]!.Value;
			}
			xmlNode = documentElement.SelectSingleNode("UninstallerTrackUrl");
			if (xmlNode != null)
			{
				text2 = xmlNode.InnerText;
			}
			xmlReader.Close();
		}
		catch
		{
		}
		if (string.IsNullOrEmpty(text))
		{
			text = Guid.NewGuid().ToString().Replace("-", "");
		}
		try
		{
			text2 = ((!string.IsNullOrEmpty(text2.Trim())) ? (text2 + "apikey=37ed9e04-8a52-4464-8f78-7d7b0e88ea57") : "http://urdrive.fuhu.org/webservices/set-uninstall/v2?apikey=37ed9e04-8a52-4464-8f78-7d7b0e88ea57");
			text2 = text2 + "&uuid=" + text;
			WebRequest webRequest = WebRequest.Create(text2);
			webRequest.Timeout = 10000;
			webRequest.GetResponse();
		}
		catch
		{
		}
	}

	private void SetupTextToControl()
	{
		try
		{
			GetDefaultLanguage();
			string @string = SystemInfo.MyResManager.GetString("unInstaller_Title", SystemInfo.MyCulture);
			string string2 = SystemInfo.MyResManager.GetString("MessageBox_Yes", SystemInfo.MyCulture);
			string string3 = SystemInfo.MyResManager.GetString("MessageBox_No", SystemInfo.MyCulture);
			string string4 = SystemInfo.MyResManager.GetString("unInstaller_Information", SystemInfo.MyCulture);
			((Control)this).set_Text(@string);
			((Control)label1).set_Text(string4);
			((Control)button1).set_Text(string2);
			((Control)button2).set_Text(string3);
		}
		catch (Exception)
		{
		}
	}

	public void GetDefaultLanguage()
	{
		string nodeName = "//AppLanguage/DefaultLanguage";
		strAppConfigPath = Application.get_StartupPath() + "\\urDrive\\Config\\AppConfig.xml";
		SystemInfo.DefaultLanguage = ReadDefaultLanguage(strAppConfigPath, nodeName);
		if (string.IsNullOrEmpty(SystemInfo.DefaultLanguage))
		{
			SystemInfo.DefaultLanguage = "en";
		}
		InitResource();
	}

	public string ReadDefaultLanguage(string strFullPath, string nodeName)
	{
		string text = "DefaultLanguage";
		text = string.Empty;
		XmlReader xmlReader = new XmlTextReader(strFullPath);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(xmlReader);
		XmlNode documentElement = xmlDocument.DocumentElement;
		XmlNode xmlNode = documentElement.SelectSingleNode(nodeName);
		if (xmlNode != null)
		{
			text = xmlNode.InnerText;
		}
		xmlReader.Close();
		return text;
	}

	public void InitResource()
	{
		ResourceManager resourceManager = null;
		CultureInfo cultureInfo = null;
		string resourceDir = strAppConfigPath;
		string text = "Resource_" + SystemInfo.DefaultLanguage.ToLower();
		string path = Application.get_StartupPath() + "\\urDrive\\Config\\" + text + ".resources";
		if (!File.Exists(path))
		{
			text = "Resource_EN";
			resourceManager = ResourceManager.CreateFileBasedResourceManager(text, resourceDir, null);
			cultureInfo = new CultureInfo("en");
			SystemInfo.MyResManager = resourceManager;
			SystemInfo.MyCulture = cultureInfo;
			SystemInfo.DefaultLanguage = "en";
			return;
		}
		resourceDir = Application.get_StartupPath() + "\\urDrive\\Config";
		resourceManager = ResourceManager.CreateFileBasedResourceManager(text, resourceDir, null);
		try
		{
			cultureInfo = new CultureInfo(SystemInfo.DefaultLanguage);
		}
		catch
		{
			cultureInfo = new CultureInfo("en");
			SystemInfo.DefaultLanguage = "en";
		}
		SystemInfo.MyResManager = resourceManager;
		SystemInfo.MyCulture = cultureInfo;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)7);
		((Form)this).Close();
	}

	private void showResult(string sMsg)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmSysQustion frmSysQustion2 = new frmSysQustion();
		frmSysQustion2.MSGContent = sMsg;
		((Form)frmSysQustion2).set_StartPosition((FormStartPosition)4);
		((Form)frmSysQustion2).set_TopLevel(true);
		((Form)frmSysQustion2).ShowDialog();
	}

	private void frmSysInformation_Load(object sender, EventArgs e)
	{
		SetupTextToControl();
		sTempFolder = Environment.GetEnvironmentVariable("Temp");
		if (sTempFolder == string.Empty)
		{
			sTempFolder = Environment.GetEnvironmentVariable("Tmp");
			if (sTempFolder == string.Empty)
			{
				sTempFolder = Environment.GetEnvironmentVariable("SystemRoot") + "\\Temp";
			}
		}
	}

	private void frmSysInformation_FormClosing(object sender, FormClosingEventArgs e)
	{
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
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSysInformation));
		label1 = new Label();
		button1 = new Button();
		button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_Location(new Point(25, 19));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(222, 37));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Are you sure want to uninstall the urDrive completely?");
		((Control)button1).set_AutoSize(true);
		((Control)button1).set_Font(new Font("Arial", 8.25f));
		((Control)button1).set_Location(new Point(128, 61));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(50, 24));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("&Yes");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_AutoSize(true);
		((Control)button2).set_Location(new Point(188, 61));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(50, 24));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("&No");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Form)this).set_ClientSize(new Size(269, 97));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Arial", 8.25f));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmSysInformation");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Kingston urDrive Uninstaller");
		((Form)this).add_Load((EventHandler)frmSysInformation_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmSysInformation_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
