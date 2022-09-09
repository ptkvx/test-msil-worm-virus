using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using Autodesk.AutoCAD.ADMigrator.Properties;
using Autodesk.AutoCAD.AcZipInterface;
using Autodesk.AutoCAD.CustomMigrator;
using Autodesk.AutoCAD.Customization;
using Autodesk.AutoCAD.MNUParser;
using Autodesk.AutoCAD.MyAutoCAD;
using Microsoft.Win32;

namespace Autodesk.AutoCAD.ADMigrator;

public class MainForm : Form, ILogXML
{
	private const string VERTICAL_ADMIGRATOR_DLL = "VerticalAdMigrator.dll";

	private const string MIGRATION_PROFILES_FILE = "AdMigrator.xml";

	private const string MIGRATION_DATA_FILE = "MigrationDataFile.xml";

	private bool bRun;

	private Button OkBtn;

	private Button CancelBtn;

	private Button HelpBtn;

	private Label HeaderText;

	private Label ComboText;

	private Label FooterText;

	private ComboBox InstalledVersionsCombo;

	private IContainer components;

	private UTF8Encoding UTF8 = new UTF8Encoding();

	private static string LogFileName = null;

	private static string LogFileNameXml = null;

	private static XmlTextWriter MainWriter = null;

	private bool m_SkipACADCheck;

	internal static bool m_isVertMigration = false;

	private string m_VertDLLPath;

	public static string MigrationFolder = null;

	public static ArrayList CUIFileMapArray;

	internal Migrator _Migrator;

	private static string m_CurrentSourceProfilePath = null;

	public static bool isTarget = false;

	private static string m_CurrentTargetProfilePath = null;

	private bool m_isImport;

	private bool m_isExport;

	private bool m_includeNetworkFiles = true;

	public string ProductRegistryRootKey;

	private ADMigratorResources m_LocalResources = new ADMigratorResources();

	private Label ItemList;

	private ProductInfo m_prodInfo;

	private Panel FilesCheckBoxPanel;

	private CheckBox UserProfilesCheck;

	private CheckBox CUIFilesCheck;

	private CheckBox MNUMNSFilesCheck;

	private CheckBox UserIconFilesCheck;

	private CheckBox UserLineFilesCheck;

	private CheckBox UserHatchFilesCheck;

	private CheckBox AcadHatchFilesCheck;

	private CheckBox AcadLineFilesCheck;

	private CheckBox AcadPgpFilesCheck;

	internal static bool isACAD = false;

	internal static CustomizationHostServices customizationHostServices = new CustomizationHostServices();

	internal static MainForm _theForm = null;

	public static string CurrentSourceProfilePath => m_CurrentSourceProfilePath;

	public static string CurrentTargetProfilePath => m_CurrentTargetProfilePath;

	public bool IsImportExport
	{
		get
		{
			if (!m_isExport)
			{
				return m_isImport;
			}
			return true;
		}
	}

	public ProductInfo ProdInfo
	{
		get
		{
			return m_prodInfo;
		}
		set
		{
			m_prodInfo = value;
		}
	}

	public MainForm()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		InitializeComponent();
		_Migrator = new Migrator((ILogXML)(object)this);
		CUIFileMigrator._logger = (ILogXML)(object)this;
		MNUFileMigrator._logger = (ILogXML)(object)this;
		_theForm = this;
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		HeaderText = new Label();
		ComboText = new Label();
		InstalledVersionsCombo = new ComboBox();
		FooterText = new Label();
		OkBtn = new Button();
		CancelBtn = new Button();
		HelpBtn = new Button();
		ItemList = new Label();
		FilesCheckBoxPanel = new Panel();
		UserProfilesCheck = new CheckBox();
		CUIFilesCheck = new CheckBox();
		MNUMNSFilesCheck = new CheckBox();
		UserIconFilesCheck = new CheckBox();
		AcadLineFilesCheck = new CheckBox();
		UserLineFilesCheck = new CheckBox();
		UserHatchFilesCheck = new CheckBox();
		AcadHatchFilesCheck = new CheckBox();
		AcadPgpFilesCheck = new CheckBox();
		((Control)FilesCheckBoxPanel).SuspendLayout();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(HeaderText, "HeaderText");
		((Control)HeaderText).set_Name("HeaderText");
		HeaderText.set_UseMnemonic(false);
		componentResourceManager.ApplyResources(ComboText, "ComboText");
		((Control)ComboText).set_Name("ComboText");
		componentResourceManager.ApplyResources(InstalledVersionsCombo, "InstalledVersionsCombo");
		InstalledVersionsCombo.set_DropDownStyle((ComboBoxStyle)2);
		((Control)InstalledVersionsCombo).set_Name("InstalledVersionsCombo");
		InstalledVersionsCombo.add_SelectedIndexChanged((EventHandler)InstalledVersionsCombo_SelectedIndexChanged);
		componentResourceManager.ApplyResources(FooterText, "FooterText");
		((Control)FooterText).set_Name("FooterText");
		FooterText.set_UseMnemonic(false);
		componentResourceManager.ApplyResources(OkBtn, "OkBtn");
		((Control)OkBtn).set_Name("OkBtn");
		((Control)OkBtn).add_Click((EventHandler)OkBtn_Click);
		componentResourceManager.ApplyResources(CancelBtn, "CancelBtn");
		CancelBtn.set_DialogResult((DialogResult)2);
		((Control)CancelBtn).set_Name("CancelBtn");
		((Control)CancelBtn).add_Click((EventHandler)CancelBtn_Click);
		componentResourceManager.ApplyResources(HelpBtn, "HelpBtn");
		((Control)HelpBtn).set_Name("HelpBtn");
		((Control)HelpBtn).add_Click((EventHandler)HelpBtn_Click);
		componentResourceManager.ApplyResources(ItemList, "ItemList");
		((Control)ItemList).set_Name("ItemList");
		componentResourceManager.ApplyResources(FilesCheckBoxPanel, "FilesCheckBoxPanel");
		((Control)FilesCheckBoxPanel).set_BackColor(SystemColors.ControlLightLight);
		FilesCheckBoxPanel.set_BorderStyle((BorderStyle)2);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)UserProfilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)CUIFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)MNUMNSFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)UserIconFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)AcadLineFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)UserLineFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)UserHatchFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)AcadHatchFilesCheck);
		((Control)FilesCheckBoxPanel).get_Controls().Add((Control)(object)AcadPgpFilesCheck);
		((Control)FilesCheckBoxPanel).set_Name("FilesCheckBoxPanel");
		componentResourceManager.ApplyResources(UserProfilesCheck, "UserProfilesCheck");
		((Control)UserProfilesCheck).set_Name("UserProfilesCheck");
		UserProfilesCheck.add_CheckedChanged((EventHandler)UserProfilesCheck_CheckedChanged);
		componentResourceManager.ApplyResources(CUIFilesCheck, "CUIFilesCheck");
		((Control)CUIFilesCheck).set_Name("CUIFilesCheck");
		componentResourceManager.ApplyResources(MNUMNSFilesCheck, "MNUMNSFilesCheck");
		((Control)MNUMNSFilesCheck).set_Name("MNUMNSFilesCheck");
		componentResourceManager.ApplyResources(UserIconFilesCheck, "UserIconFilesCheck");
		((Control)UserIconFilesCheck).set_Name("UserIconFilesCheck");
		componentResourceManager.ApplyResources(AcadLineFilesCheck, "AcadLineFilesCheck");
		((Control)AcadLineFilesCheck).set_Name("AcadLineFilesCheck");
		componentResourceManager.ApplyResources(UserLineFilesCheck, "UserLineFilesCheck");
		((Control)UserLineFilesCheck).set_Name("UserLineFilesCheck");
		componentResourceManager.ApplyResources(UserHatchFilesCheck, "UserHatchFilesCheck");
		((Control)UserHatchFilesCheck).set_Name("UserHatchFilesCheck");
		componentResourceManager.ApplyResources(AcadHatchFilesCheck, "AcadHatchFilesCheck");
		((Control)AcadHatchFilesCheck).set_Name("AcadHatchFilesCheck");
		componentResourceManager.ApplyResources(AcadPgpFilesCheck, "AcadPgpFilesCheck");
		((Control)AcadPgpFilesCheck).set_Name("AcadPgpFilesCheck");
		((Form)this).set_AcceptButton((IButtonControl)(object)OkBtn);
		componentResourceManager.ApplyResources(this, "$this");
		((Form)this).set_CancelButton((IButtonControl)(object)CancelBtn);
		((Control)this).get_Controls().Add((Control)(object)FilesCheckBoxPanel);
		((Control)this).get_Controls().Add((Control)(object)ItemList);
		((Control)this).get_Controls().Add((Control)(object)HelpBtn);
		((Control)this).get_Controls().Add((Control)(object)CancelBtn);
		((Control)this).get_Controls().Add((Control)(object)OkBtn);
		((Control)this).get_Controls().Add((Control)(object)FooterText);
		((Control)this).get_Controls().Add((Control)(object)InstalledVersionsCombo);
		((Control)this).get_Controls().Add((Control)(object)ComboText);
		((Control)this).get_Controls().Add((Control)(object)HeaderText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).add_Closed((EventHandler)MainForm_Closed);
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)FilesCheckBoxPanel).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static int Main(string[] args)
	{
		if (args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i].ToLower().Equals("/myautocad"))
				{
					if (IsMyAutoCADInstalled())
					{
						return CallMyAutoCAD();
					}
					return 0;
				}
			}
		}
		return RunMigrator(args);
	}

	private static int RunMigrator(string[] args)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Invalid comparison between Unknown and I4
		Application.EnableVisualStyles();
		Mutex mutex = null;
		string text = "";
		ProductInfo val = null;
		CustomizationSection.set_HostServices((IHostServices)(object)customizationHostServices);
		try
		{
			text = "Local\\" + Assembly.GetEntryAssembly()!.GetName().Name;
			mutex = new Mutex(initiallyOwned: true, text);
		}
		catch (Exception)
		{
		}
		if (mutex != null && !mutex.WaitOne(10, exitContext: true))
		{
			return 1;
		}
		string text2 = null;
		try
		{
			text2 = Migrator.GetVerifiedRootKeyFromIni();
			val = new ProductInfo();
			Migrator.getProductInfoFromRegistryString(text2, val);
			if (val.m_languageTag.Length > 3)
			{
				throw new INIException(3);
			}
			int culture = int.Parse(val.m_languageTag, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture, useUserOverride: true);
		}
		catch (INIException val2)
		{
			INIException val3 = val2;
			bool flag = true;
			MainForm mainForm = new MainForm();
			switch (val3.nProblem)
			{
			case 1:
				MessageBox.Show(mainForm.m_LocalResources.GetString("ERROR_RK_NF"), mainForm.m_LocalResources.GetString("UI_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
				break;
			case 2:
				MessageBox.Show(mainForm.m_LocalResources.GetString("ERROR_INI_INVALID"), mainForm.m_LocalResources.GetString("UI_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
				break;
			case 3:
				flag = false;
				if (val.m_languageTag != "24242424")
				{
					MessageBox.Show(string.Format(mainForm.m_LocalResources.GetString("ERROR_RK_INVALID"), text2), mainForm.m_LocalResources.GetString("UI_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				break;
			}
			if (flag)
			{
				return 1;
			}
		}
		MainForm mainForm2 = new MainForm();
		mainForm2.ProductRegistryRootKey = text2;
		customizationHostServices.RegProdRootKey = text2;
		mainForm2.ProdInfo = val;
		if (args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i].ToLower().Equals("/a"))
				{
					mainForm2.m_SkipACADCheck = true;
				}
				if (args[i].ToLower().Equals("/i"))
				{
					mainForm2.m_isImport = true;
				}
				if (args[i].ToLower().Equals("/e"))
				{
					mainForm2.m_isExport = true;
				}
			}
		}
		if (!mainForm2.m_SkipACADCheck)
		{
			Process[] processesByName = Process.GetProcessesByName(val.m_productId);
			if (processesByName.Length > 0)
			{
				if (!mainForm2.m_isImport && !mainForm2.m_isExport)
				{
					MessageBox.Show(string.Format(mainForm2.m_LocalResources.GetString("NOTICE_ISRUNNING"), mainForm2.ProdInfo.m_productName), mainForm2.m_LocalResources.GetString("UI_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				else
				{
					MessageBox.Show(string.Format(mainForm2.m_LocalResources.GetString("NOTICE_ISRUNNING_IMPORTEXPORT"), mainForm2.ProdInfo.m_productName, mainForm2.ProdInfo.m_productName), mainForm2.ProdInfo.m_productName, (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				return 1;
			}
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(mainForm2.ProductRegistryRootKey));
		if (registryKey == null)
		{
			if (mainForm2.m_isImport)
			{
				mainForm2.LaunchProductFirst(Migrator.GetAppInstallDir(mainForm2.ProductRegistryRootKey), ExportMsg: false);
			}
			else if (mainForm2.m_isExport)
			{
				mainForm2.LaunchProductFirst(Migrator.GetAppInstallDir(mainForm2.ProductRegistryRootKey), ExportMsg: true);
			}
			else
			{
				MessageBox.Show(string.Format(mainForm2.m_LocalResources.GetString("NOTICE_PRODUCT_MUST_BE_RUN"), mainForm2.ProdInfo.m_productName), mainForm2.m_LocalResources.GetString("UI_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return 1;
		}
		if (!mainForm2.m_isExport && !mainForm2.m_isImport && Migrator.HasMigrated(mainForm2.ProductRegistryRootKey) && (int)MigratorMessageBox.Show(string.Format(mainForm2.m_LocalResources.GetString("NOTICE_ALREADYRUN"), val.m_productName), mainForm2.m_LocalResources.GetString("NOTICE_WARNING"), mainForm2.m_LocalResources.GetString("UI_TITLE")) != 1)
		{
			return 0;
		}
		Parser.Initialize();
		try
		{
			mainForm2.m_VertDLLPath = Application.get_ExecutablePath();
			mainForm2.m_VertDLLPath = Path.GetDirectoryName(mainForm2.m_VertDLLPath);
			mainForm2.m_VertDLLPath += "\\VerticalAdMigrator.dll";
			if (File.Exists(mainForm2.m_VertDLLPath))
			{
				m_isVertMigration = true;
			}
			if (mainForm2.m_isExport)
			{
				mainForm2.ExportCustomizations();
			}
			else if (mainForm2.m_isImport)
			{
				mainForm2.ImportCustomizations();
			}
			else
			{
				Application.Run((Form)(object)mainForm2);
			}
			((SettingsBase)Settings.Default).Save();
		}
		catch (Exception)
		{
			return 1;
		}
		Parser.Terminate();
		return 0;
	}

	public void LaunchProductFirst(string AppInstallDir, bool ExportMsg)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Invalid comparison between Unknown and I4
		string text = AppInstallDir + (m_prodInfo.get_isAcad() ? "acad" : "acadlt") + ".exe";
		LaunchDialog val = new LaunchDialog();
		val.set_dlgName(m_prodInfo.m_productName);
		if (ExportMsg)
		{
			val.set_messageBody(string.Format(LocalResources.GetString("Export_Launch_Message"), m_prodInfo.m_productName));
		}
		else
		{
			val.set_messageBody(string.Format(LocalResources.GetString("Import_Launch_Message"), m_prodInfo.m_productName));
		}
		if ((int)((Form)val).ShowDialog() == 1 && File.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void SetUIText(Control thing)
	{
		thing.set_Text(m_LocalResources.GetString(thing.get_Text()));
	}

	private void InitProductInfo()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(ProductRegistryRootKey);
		if (registryKey != null)
		{
			Migrator.getProductInfoFromRegistryString(ProductRegistryRootKey, m_prodInfo);
			isACAD = m_prodInfo.get_isAcad();
			registryKey.Close();
			string roamableRootFolder = Migrator.GetRoamableRootFolder(ProductRegistryRootKey);
			MigrationFolder = roamableRootFolder + m_LocalResources.GetString("LOG_FOLDER");
			if (!Directory.Exists(MigrationFolder))
			{
				Directory.CreateDirectory(MigrationFolder);
			}
		}
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		InitProductInfo();
		((Control)AcadLineFilesCheck).set_Text(string.Format(((Control)AcadLineFilesCheck).get_Text(), m_prodInfo.m_product));
		((Control)AcadHatchFilesCheck).set_Text(string.Format(((Control)AcadHatchFilesCheck).get_Text(), m_prodInfo.m_product));
		((Control)AcadPgpFilesCheck).set_Text(string.Format(((Control)AcadPgpFilesCheck).get_Text(), m_prodInfo.m_productId.ToLower()));
		((Control)HeaderText).set_Text(string.Format(((Control)HeaderText).get_Text(), m_prodInfo.m_product, m_prodInfo.m_productName));
		if (m_isVertMigration)
		{
			object[] array = new object[2] { _Migrator.MinProductVersion, _Migrator.MinCUIVersion };
			CallVerticalMigration("LatestSupportedVersions", array);
			if ((double)array[0] > _Migrator.MinProductVersion)
			{
				_Migrator.MinProductVersion = (double)array[0];
			}
			if ((double)array[1] > _Migrator.MinCUIVersion)
			{
				_Migrator.MinCUIVersion = (double)array[1];
			}
		}
		ArrayList installedAppList = _Migrator.GetInstalledAppList(ProductRegistryRootKey);
		if (installedAppList.Count == 0)
		{
			if (!m_SkipACADCheck)
			{
				MessageBox.Show(string.Format(m_LocalResources.GetString("ERROR_NO_PREVIOUS"), m_prodInfo.m_product), m_LocalResources.GetString("UI_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			((Form)this).Close();
			return;
		}
		foreach (ProductInfo item in installedAppList)
		{
			ProductInfo val = item;
			InstalledVersionsCombo.get_Items().Add((object)val);
		}
		((ListControl)InstalledVersionsCombo).set_SelectedIndex(InstalledVersionsCombo.get_Items().get_Count() - 1);
		for (int i = 0; i < ((ArrangedElementCollection)((Control)FilesCheckBoxPanel).get_Controls()).get_Count(); i++)
		{
			Control obj = ((Control)FilesCheckBoxPanel).get_Controls().get_Item(i);
			CheckBox val2 = (CheckBox)(object)((obj is CheckBox) ? obj : null);
			if (val2 != null)
			{
				val2.set_Checked(true);
			}
		}
		UpdateCheckBoxes(InstalledVersionsCombo);
	}

	private static bool IsMyAutoCADInstalled()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		string text = null;
		try
		{
			text = Migrator.GetVerifiedRootKeyFromIni();
			text = Migrator.StripWOWFromCURegKey(text);
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text))
			{
				if (registryKey == null)
				{
					throw new INIException(4);
				}
				object value = registryKey.GetValue("InitialSetup");
				if (value == null || !(value is int num))
				{
					throw new INIException(4);
				}
				if (num < 1)
				{
					throw new INIException(4);
				}
			}
			string location = Assembly.GetCallingAssembly().Location;
			string path = location.Substring(0, location.LastIndexOf("\\") + 1) + "MyAutoCAD.dll";
			if (!File.Exists(path))
			{
				throw new INIException(4);
			}
			return true;
		}
		catch (INIException)
		{
			ADMigratorResources aDMigratorResources = new ADMigratorResources();
			MessageBox.Show(aDMigratorResources.GetString("INITIALSETUP_ERROR_NOT_INSTALLED"), aDMigratorResources.GetString("INITIALSETUP_DIALOG_TITLE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		return false;
	}

	private static int CallMyAutoCAD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		try
		{
			ProductInfo val = new ProductInfo();
			string verifiedRootKeyFromIni = Migrator.GetVerifiedRootKeyFromIni();
			if (Migrator.getProductInfoFromRegistryString(verifiedRootKeyFromIni, val) && val.m_languageTag.Length <= 3)
			{
				int culture = int.Parse(val.m_languageTag, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture, useUserOverride: true);
			}
		}
		catch (INIException)
		{
		}
		MainWindow val3 = new MainWindow();
		if (val3 != null)
		{
			((Window)val3).ShowDialog();
		}
		return 0;
	}

	private void CancelBtn_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void OkBtn_Click(object sender, EventArgs e)
	{
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cef: Expected O, but got Unknown
		//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef4: Expected O, but got Unknown
		//IL_1238: Unknown result type (might be due to invalid IL or missing references)
		//IL_123f: Expected O, but got Unknown
		//IL_1599: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a0: Expected O, but got Unknown
		//IL_1748: Unknown result type (might be due to invalid IL or missing references)
		//IL_174e: Invalid comparison between Unknown and I4
		//IL_1779: Unknown result type (might be due to invalid IL or missing references)
		object obj = InstalledVersionsCombo.get_Items().get_Item(((ListControl)InstalledVersionsCombo).get_SelectedIndex());
		ProductInfo val = (ProductInfo)((obj is ProductInfo) ? obj : null);
		if (val == null)
		{
			return;
		}
		_Migrator.set_SourceProdInfo(val);
		CUIFileMapArray = new ArrayList();
		if (m_isVertMigration)
		{
			try
			{
				object[] parameters = new object[2] { val.m_regRootKey, CUIFileMapArray };
				CallVerticalMigration("PreProcess", parameters);
			}
			catch (Exception ex)
			{
				Log2File(string.Format(m_LocalResources.GetString("ERROR_ACAD_VERTICAL"), m_prodInfo.m_productId.ToLower(), ex.Message));
				Migrator.m_bErrors = true;
			}
		}
		else if (val.get_isLT() && val.IsBeforeSpago())
		{
			CUIFileMap value = new CUIFileMap("aclt.cui", "ACLT", "ACLTMacros", "acadlt.cui", "ACADLT", "ACADLTMacros");
			CUIFileMapArray.Add(value);
		}
		else if (val.IsBeforeGator())
		{
			CUIFileMap value2 = new CUIFileMap("contentsearch", "CONTENTSEARCH", "CONTENTSEARCHMacros", "AutodeskSeek", "CONTENTSEARCH", "CONTENTSEARCHMacros");
			CUIFileMapArray.Add(value2);
		}
		bool flag = false;
		for (int i = 0; i < ((ArrangedElementCollection)((Control)FilesCheckBoxPanel).get_Controls()).get_Count(); i++)
		{
			Control obj2 = ((Control)FilesCheckBoxPanel).get_Controls().get_Item(i);
			CheckBox val2 = (CheckBox)(object)((obj2 is CheckBox) ? obj2 : null);
			if (val2 != null && val2.get_Checked())
			{
				flag = true;
				break;
			}
		}
		try
		{
			if (flag)
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				bRun = true;
				string text = null;
				LogXMLInitialize();
				string[] profiles = Migrator.GetProfiles(val.m_regRootKey);
				if (UserProfilesCheck.get_Checked() && profiles != null)
				{
					if (m_isVertMigration)
					{
						StringDictionary stringDictionary = new StringDictionary();
						object[] parameters2 = new object[2] { val.m_regRootKey, stringDictionary };
						CallVerticalMigration("GetMigrationEnvironmentVariables", parameters2);
						if (stringDictionary.Count > 0)
						{
							foreach (string key in stringDictionary.Keys)
							{
								val.get_EnvVars().Add(key, stringDictionary[key], true);
							}
						}
						stringDictionary.Clear();
						parameters2 = new object[2]
						{
							_Migrator.destProductInfo().m_regRootKey,
							stringDictionary
						};
						CallVerticalMigration("GetMigrationEnvironmentVariables", parameters2);
						if (stringDictionary.Count > 0)
						{
							foreach (string key2 in stringDictionary.Keys)
							{
								_Migrator.destProductInfo().get_EnvVars().Add(key2, stringDictionary[key2], true);
							}
						}
					}
					ProfileMigrator val3 = null;
					try
					{
						LogXMLStartSection((LogSection)0);
						string location = Assembly.GetEntryAssembly()!.Location;
						string text4 = location.Substring(0, location.LastIndexOf("\\") + 1) + "AdMigrator.xml";
						val3 = new ProfileMigrator(text4);
						val3.Migrate(val, _Migrator.destProductInfo(), ProductRegistryRootKey, new Log(Log2File));
					}
					catch (FileNotFoundException ex2)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_FNF"), "AdMigrator.xml", ex2.Message);
						Log2File(text);
						LogXMLElement((LogOperation)0, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
					catch (Exception ex3)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_PROFILE"), ex3.Message);
						LogXMLElement((LogOperation)0, (LogCategory)0, text);
						Log2File(text);
						Migrator.m_bErrors = true;
					}
					finally
					{
						LogXMLEndSection();
					}
					StringCollection stringCollection = new StringCollection();
					StringCollection stringCollection2 = new StringCollection();
					string[] array = profiles;
					foreach (string text5 in array)
					{
						StringCollection stringCollection3 = new StringCollection();
						string text6 = null;
						string text7 = null;
						m_CurrentSourceProfilePath = val.m_regRootKey + "\\Profiles\\" + text5;
						m_CurrentTargetProfilePath = ProductRegistryRootKey + "\\Profiles\\" + text5;
						RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(m_CurrentSourceProfilePath) + "\\General Configuration");
						if (registryKey == null)
						{
							continue;
						}
						text6 = (string)registryKey.GetValue("MenuFile");
						if (text6 != null && text6.Length > 1 && !StringCollectionContains(stringCollection3, text6, ignoreCase: true))
						{
							stringCollection3.Add(text6);
						}
						text7 = (string)registryKey.GetValue("EnterpriseMenuFile");
						if (text7 != null && text7.Length > 1 && !StringCollectionContains(stringCollection3, text7, ignoreCase: true))
						{
							stringCollection3.Add(text7);
						}
						if (CUIFilesCheck.get_Checked() && !val3.get_SrcProdInfo().IsBeforeRio())
						{
							DisposableContainer disposableContainer = new DisposableContainer();
							try
							{
								LogXMLStartSection((LogSection)1);
								StringCollection stringCollection4 = new StringCollection();
								CUIFileMigrator.FindTargetCUIFiles(ProductRegistryRootKey);
								Hashtable hashtable = new Hashtable();
								Hashtable hashtable2 = new Hashtable();
								StringEnumerator enumerator2 = stringCollection3.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										string current = enumerator2.Current;
										if (stringCollection.Contains(current.ToLower()))
										{
											continue;
										}
										stringCollection.Add(current.ToLower());
										CUIFileMigrator cUIFileMigrator = new CUIFileMigrator(current, (ILogXML)(object)this, val, _Migrator.destProductInfo());
										disposableContainer.AddDisposableObject(cUIFileMigrator);
										if (cUIFileMigrator.SourceFile == null)
										{
											continue;
										}
										cUIFileMigrator.FindInitialTarget();
										if (!cUIFileMigrator.SetFinalTarget(val3, ProductRegistryRootKey))
										{
											continue;
										}
										if (cUIFileMigrator.MergeFiles())
										{
											if (current == text6)
											{
												RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(m_CurrentTargetProfilePath) + "\\General Configuration", writable: true);
												registryKey2.SetValue("MenuFile", cUIFileMigrator.TargetFile);
												registryKey2.Close();
												text = string.Format(LocalResources.GetString("LOG_MENU_FILE_CHANGE"), cUIFileMigrator.TargetFile);
												LogXMLElement((LogOperation)0, (LogCategory)5, text);
											}
											if (current == text7)
											{
												RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(m_CurrentTargetProfilePath) + "\\General Configuration", writable: true);
												registryKey3.SetValue("EnterpriseMenuFile", cUIFileMigrator.TargetFile);
												registryKey3.Close();
												text = string.Format(LocalResources.GetString("LOG_ENTERPRISE_FILE_CHANGE"), cUIFileMigrator.TargetFile);
												LogXMLElement((LogOperation)0, (LogCategory)5, text);
											}
										}
										cUIFileMigrator.CopyImagesDll();
										cUIFileMigrator.CopySldAndSlbFiles();
										hashtable2.Add(cUIFileMigrator, new List<CUIFileMigrator>());
										StringCollection partialsFromSource = cUIFileMigrator.GetPartialsFromSource();
										StringEnumerator enumerator3 = partialsFromSource.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												string current2 = enumerator3.Current;
												if (current2.Length > 1 && !StringCollectionContains(stringCollection4, current2, ignoreCase: true))
												{
													stringCollection4.Add(current2);
													if (!hashtable.Contains(current2))
													{
														hashtable.Add(current2, cUIFileMigrator);
													}
												}
											}
										}
										finally
										{
											if (enumerator3 is IDisposable disposable)
											{
												disposable.Dispose();
											}
										}
									}
								}
								finally
								{
									if (enumerator2 is IDisposable disposable2)
									{
										disposable2.Dispose();
									}
								}
								enumerator2 = stringCollection4.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										string current3 = enumerator2.Current;
										if (stringCollection.Contains(current3.ToLower()))
										{
											continue;
										}
										stringCollection.Add(current3.ToLower());
										CUIFileMigrator cUIFileMigrator2 = new CUIFileMigrator(current3, (ILogXML)(object)this, val, _Migrator.destProductInfo());
										disposableContainer.AddDisposableObject(cUIFileMigrator2);
										if (cUIFileMigrator2.SourceFile == null)
										{
											continue;
										}
										cUIFileMigrator2.FindInitialTarget();
										if (cUIFileMigrator2.SetFinalTarget(val3, ProductRegistryRootKey))
										{
											CUIFileMigrator cUIFileMigrator3 = null;
											if (hashtable.Contains(current3))
											{
												cUIFileMigrator3 = hashtable[current3] as CUIFileMigrator;
											}
											cUIFileMigrator2.setParentCUIFile(cUIFileMigrator3);
											cUIFileMigrator2.MergeFiles();
											cUIFileMigrator2.CopyImagesDll();
											cUIFileMigrator2.CopySldAndSlbFiles();
											if (hashtable2[cUIFileMigrator3] is IList<CUIFileMigrator> list)
											{
												list.Add(cUIFileMigrator2);
											}
											text = ((!cUIFileMigrator2.AutodeskSourceFile) ? string.Format(LocalResources.GetString("LOG_FILE_COPY"), cUIFileMigrator2.SourceFile, cUIFileMigrator2.TargetFile) : string.Format(LocalResources.GetString("LOG_FILE_MERGE"), cUIFileMigrator2.SourceFile, cUIFileMigrator2.TargetFile));
											LogXMLElement((LogOperation)1, (LogCategory)5, text);
										}
									}
								}
								finally
								{
									if (enumerator2 is IDisposable disposable3)
									{
										disposable3.Dispose();
									}
								}
								foreach (CUIFileMigrator key3 in hashtable2.Keys)
								{
									CUIFileMigrator.RemoveUnresolvedReferences(key3, hashtable2[key3] as IList<CUIFileMigrator>);
								}
								if (val.IsBeforeGator())
								{
									using (RegistryKey registryKey4 = Migrator.GetProfileGeneralRegKey(_Migrator.destProductInfo().m_regRootKey, (string)null, true))
									{
										if (registryKey4 != null)
										{
											registryKey4.DeleteValue("ContentSearchInit", throwOnMissingValue: false);
											registryKey4.DeleteValue("ImpressionInit", throwOnMissingValue: false);
										}
									}
									using RegistryKey registryKey5 = Migrator.GetProfileGeneralRegKey(_Migrator.destProductInfo().m_regRootKey, text5, true);
									registryKey5?.DeleteValue("ACET-ACETMAIN-MENULOADED", throwOnMissingValue: false);
								}
							}
							finally
							{
								disposableContainer.Dispose();
								LogXMLEndSection();
							}
						}
						else if (MNUMNSFilesCheck.get_Checked() && val3.get_SrcProdInfo().IsBeforeRio())
						{
							try
							{
								LogXMLStartSection((LogSection)2);
								if (stringCollection3.Count > 0)
								{
									MNUFileMigrator mNUFileMigrator = new MNUFileMigrator(stringCollection3[0], (ILogXML)(object)this);
									if (mNUFileMigrator.OriginalSource != null)
									{
										mNUFileMigrator.ConvertToCUIx(val3, ProductRegistryRootKey, mainMNS: true);
										stringCollection.Add(mNUFileMigrator.TargetCUIPath);
									}
									stringCollection3.Clear();
								}
								registryKey = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(m_CurrentSourceProfilePath) + "\\Menus");
								if (registryKey != null)
								{
									string[] valueNames = registryKey.GetValueNames();
									if (valueNames != null && valueNames.Length > 0)
									{
										string[] array2 = valueNames;
										foreach (string text8 in array2)
										{
											if (!text8.StartsWith("Group"))
											{
												continue;
											}
											string text9 = (string)registryKey.GetValue(text8);
											if (text9 != null)
											{
												int num = text9.IndexOf(" ");
												if (num > 0)
												{
													text9 = text9.Substring(text9.IndexOf(" ") + 1);
												}
												if (text9.Length > 1 && !StringCollectionContains(stringCollection3, text9, ignoreCase: true))
												{
													stringCollection3.Add(text9);
												}
											}
										}
									}
									registryKey = Registry.CurrentUser.OpenSubKey(Migrator.StripWOWFromCURegKey(CurrentTargetProfilePath) + "\\General Configuration");
									if (registryKey == null)
									{
										continue;
									}
									text6 = (string)registryKey.GetValue("MenuFile");
									CustomizationSection val4 = null;
									if (text6 == null || text6.Length < 1)
									{
										string text10 = val3.get_DestProdInfo().m_productId + CustomizationSection.EXTENSION_OPC;
										text6 = Migrator.FindFirstDefaultSupportFile(isACAD, text10, ProductRegistryRootKey);
									}
									if (text6 != null && text6.Length > 1)
									{
										val4 = new CustomizationSection(text6);
									}
									StringEnumerator enumerator2 = stringCollection3.GetEnumerator();
									try
									{
										while (enumerator2.MoveNext())
										{
											string current4 = enumerator2.Current;
											MNUFileMigrator mNUFileMigrator2 = new MNUFileMigrator(current4, (ILogXML)(object)this);
											if (mNUFileMigrator2.OriginalSource == null)
											{
												continue;
											}
											mNUFileMigrator2.ConvertToCUIx(val3, ProductRegistryRootKey, mainMNS: false);
											if (!mNUFileMigrator2.LoadTarget)
											{
												continue;
											}
											if (val4 != null)
											{
												bool flag2 = false;
												StringEnumerator enumerator3 = ((StringCollection)(object)val4.get_PartialCuiFiles()).GetEnumerator();
												try
												{
													while (enumerator3.MoveNext())
													{
														string current5 = enumerator3.Current;
														string fileName = Path.GetFileName(current5);
														string fileName2 = Path.GetFileName(mNUFileMigrator2.TargetCUIPath);
														if (string.Compare(fileName, fileName2, ignoreCase: true) == 0)
														{
															flag2 = true;
															break;
														}
													}
												}
												finally
												{
													if (enumerator3 is IDisposable disposable4)
													{
														disposable4.Dispose();
													}
												}
												if (!flag2)
												{
													((CuiFileCollectionBase)val4.get_PartialCuiFiles()).Add(mNUFileMigrator2.TargetCUIPath);
													val4.Save();
												}
											}
											stringCollection.Add(mNUFileMigrator2.TargetCUIPath);
										}
									}
									finally
									{
										if (enumerator2 is IDisposable disposable5)
										{
											disposable5.Dispose();
										}
									}
								}
							}
							finally
							{
								LogXMLEndSection();
							}
						}
						if (!UserIconFilesCheck.get_Checked())
						{
							continue;
						}
						try
						{
							LogXMLStartSection((LogSection)3);
							string roamableRootFolder = Migrator.GetRoamableRootFolder(ProductRegistryRootKey);
							string text11 = roamableRootFolder + "support\\icons";
							if (!Directory.Exists(text11))
							{
								Directory.CreateDirectory(text11);
							}
							text = string.Format(LocalResources.GetString("LOG_ICON_FILE_LOCATION"), text11);
							LogXMLElement((LogOperation)1, (LogCategory)3, text);
							StringEnumerator enumerator2 = stringCollection.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									string current6 = enumerator2.Current;
									if (stringCollection2.Contains(current6.ToLower()))
									{
										continue;
									}
									stringCollection2.Add(current6.ToLower());
									try
									{
										CustomizationSection val5 = new CustomizationSection(current6);
										if (val5 == null)
										{
											continue;
										}
										int num2 = 0;
										StringCollection stringCollection5 = val5.FindImages();
										StringEnumerator enumerator3 = stringCollection5.GetEnumerator();
										try
										{
											while (enumerator3.MoveNext())
											{
												string current7 = enumerator3.Current;
												try
												{
													string text12 = null;
													string text13 = null;
													if (File.Exists(current7))
													{
														text12 = current7;
													}
													else
													{
														text13 = Path.GetDirectoryName(current6) + Path.DirectorySeparatorChar + Path.GetFileName(current7);
														if (File.Exists(text13))
														{
															text12 = current7;
														}
													}
													if (text12 == null)
													{
														text13 = Path.GetFileName(current7);
														text12 = Migrator.FindFirstProfileSupportFile(isACAD, text13, m_CurrentSourceProfilePath);
													}
													if (text12 != null && File.Exists(text12))
													{
														string text14 = text11 + Path.DirectorySeparatorChar + Path.GetFileName(current7);
														if (!File.Exists(text14))
														{
															File.Copy(text12, text14, overwrite: false);
														}
														num2++;
													}
												}
												catch (IOException)
												{
												}
											}
										}
										finally
										{
											if (enumerator3 is IDisposable disposable6)
											{
												disposable6.Dispose();
											}
										}
										text = string.Format(LocalResources.GetString("LOG_ICON_FILES_COPIED"), num2, val5.get_CUIFileBaseName());
										LogXMLElement((LogOperation)1, (LogCategory)3, text);
									}
									catch (IOException)
									{
									}
								}
							}
							finally
							{
								if (enumerator2 is IDisposable disposable7)
								{
									disposable7.Dispose();
								}
							}
						}
						finally
						{
							LogXMLEndSection();
						}
						m_CurrentSourceProfilePath = null;
						m_CurrentTargetProfilePath = null;
					}
				}
				if (AcadLineFilesCheck.get_Checked())
				{
					Log2File(m_LocalResources.GetString("LOG_LINE"));
					try
					{
						LogXMLStartSection((LogSection)4);
						string text15 = val.m_productId.ToLower() + ".lin";
						string text16 = m_prodInfo.m_productId.ToLower() + ".lin";
						string text17 = Migrator.FindFirstDefaultSupportFile(isACAD, text15, val.m_regRootKey);
						string text18 = Migrator.FindFirstDefaultSupportFile(isACAD, text16, ProductRegistryRootKey);
						LINFileMigrator val6 = new LINFileMigrator();
						StringCollection stringCollection6 = ((FileMigrator)val6).MigrateFile(text17, text18);
						text = string.Format(m_LocalResources.GetString("LOG_ITEMS_MIGRATED"), stringCollection6.Count, text16 + m_LocalResources.GetString("LOG_LINE_PATTERNS"), text17, text18);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)4, text);
						string text19 = val.m_productId.ToLower() + "iso.lin";
						string text20 = m_prodInfo.m_productId.ToLower() + "iso.lin";
						string text21 = Migrator.FindFirstDefaultSupportFile(isACAD, text19, val.m_regRootKey);
						string text22 = Migrator.FindFirstDefaultSupportFile(isACAD, text20, ProductRegistryRootKey);
						stringCollection6 = ((FileMigrator)val6).MigrateFile(text21, text22);
						text = string.Format(m_LocalResources.GetString("LOG_ITEMS_MIGRATED"), stringCollection6.Count, text20 + m_LocalResources.GetString("LOG_LINE_PATTERNS"), text21, text22);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)4, text);
					}
					catch (Exception ex6)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_ACAD_LINE"), m_prodInfo.m_product, ex6.Message);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
					finally
					{
						LogXMLEndSection();
					}
				}
				if (UserLineFilesCheck.get_Checked())
				{
					Log2File(m_LocalResources.GetString("LOG_LINE"));
					try
					{
						LogXMLStartSection((LogSection)5);
						string text23 = m_prodInfo.m_productId.ToLower() + ".lin";
						string text24 = Migrator.FindDefaultSupportFileDir(isACAD, text23, val.m_regRootKey);
						string text25 = Migrator.FindDefaultSupportFileDir(isACAD, text23, ProductRegistryRootKey);
						StringCollection stringCollection7 = FileMigrator.CopyFilesToNewDir(text24, text25, "*.lin", false);
						text = string.Format(m_LocalResources.GetString("LOG_ITEMS_MIGRATED"), stringCollection7.Count, m_LocalResources.GetString("LOG_USER_LIN_FILES"), text24, text25);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)3, text);
					}
					catch (Exception ex7)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_USER_LINE"), ex7.Message);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
					finally
					{
						LogXMLEndSection();
					}
				}
				if (AcadHatchFilesCheck.get_Checked())
				{
					Log2File(m_LocalResources.GetString("LOG_LINE"));
					try
					{
						LogXMLStartSection((LogSection)6);
						string text26 = val.m_productId.ToLower() + ".pat";
						string text27 = m_prodInfo.m_productId.ToLower() + ".pat";
						string text28 = Migrator.FindFirstDefaultSupportFile(isACAD, text26, val.m_regRootKey);
						string text29 = Migrator.FindFirstDefaultSupportFile(isACAD, text27, ProductRegistryRootKey);
						PATFileMigrator val7 = new PATFileMigrator();
						StringCollection stringCollection8 = ((FileMigrator)val7).MigrateFile(text28, text29);
						text = string.Format(m_LocalResources.GetString("LOG_ITEMS_MIGRATED"), stringCollection8.Count, text27 + string.Format(m_LocalResources.GetString("LOG_HATCH_PATTERNS")), text28, text29);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)4, text);
						string text30 = val.m_productId.ToLower() + "iso.pat";
						string text31 = m_prodInfo.m_productId.ToLower() + "iso.pat";
						string text32 = Migrator.FindFirstDefaultSupportFile(isACAD, text30, val.m_regRootKey);
						string text33 = Migrator.FindFirstDefaultSupportFile(isACAD, text31, ProductRegistryRootKey);
						stringCollection8 = ((FileMigrator)val7).MigrateFile(text32, text33);
						text = string.Format(m_LocalResources.GetString("LOG_ITEMS_MIGRATED"), stringCollection8.Count, text31 + string.Format(m_LocalResources.GetString("LOG_HATCH_PATTERNS")), text32, text33);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)4, text);
					}
					catch (Exception ex8)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_ACAD_PATTERN"), m_prodInfo.m_product, ex8.Message);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
					finally
					{
						LogXMLEndSection();
					}
				}
				if (UserHatchFilesCheck.get_Checked())
				{
					Log2File(m_LocalResources.GetString("LOG_LINE"));
					try
					{
						LogXMLStartSection((LogSection)7);
						string text34 = m_prodInfo.m_productId.ToLower() + ".pat";
						string text35 = Migrator.FindDefaultSupportFileDir(isACAD, text34, val.m_regRootKey);
						string text36 = Migrator.FindDefaultSupportFileDir(isACAD, text34, ProductRegistryRootKey);
						StringCollection stringCollection9 = FileMigrator.CopyFilesToNewDir(text35, text36, "*.pat", false);
						text = string.Format(m_LocalResources.GetString("LOG_ITEMS_MIGRATED"), stringCollection9.Count, m_LocalResources.GetString("LOG_HATCH_USER_PAT"), text35, text36);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)3, text);
					}
					catch (Exception ex9)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_USER_PATTERN"), ex9.Message);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
					finally
					{
						LogXMLEndSection();
					}
				}
				if (AcadPgpFilesCheck.get_Checked())
				{
					Log2File(m_LocalResources.GetString("LOG_LINE"));
					try
					{
						LogXMLStartSection((LogSection)8);
						string text37 = val.m_productId.ToLower() + ".pgp";
						string text38 = m_prodInfo.m_productId.ToLower() + ".pgp";
						string text39 = Migrator.FindFirstDefaultSupportFile(isACAD, text37, val.m_regRootKey);
						string text40 = Migrator.FindFirstDefaultSupportFile(isACAD, text38, ProductRegistryRootKey);
						PGPFileMigrator val8 = new PGPFileMigrator();
						StringCollection stringCollection10 = ((FileMigrator)val8).MigrateFile(text39, text40);
						text = string.Format(m_LocalResources.GetString("PGP_MIGRATED"), stringCollection10.Count);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)4, text);
					}
					catch (Exception ex10)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_ACAD_PGP"), m_prodInfo.m_productId.ToLower(), ex10.Message);
						Log2File(text);
						LogXMLElement((LogOperation)1, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
					finally
					{
						LogXMLEndSection();
					}
				}
				((Control)this).Hide();
				if (m_isVertMigration)
				{
					try
					{
						CallVerticalMigration("Start", null);
					}
					catch (Exception ex11)
					{
						text = string.Format(m_LocalResources.GetString("ERROR_ACAD_VERTICAL"), m_prodInfo.m_productId.ToLower(), ex11.Message);
						Log2File(text);
						LogXMLElement((LogOperation)2, (LogCategory)0, text);
						Migrator.m_bErrors = true;
					}
				}
				string @string;
				if (Migrator.m_bErrors)
				{
					text = string.Format(m_LocalResources.GetString("LOG_FINISHED_ERRORS"), DateTime.Now);
					Log2File(text);
					LogXMLStartSection((LogSection)9);
					LogXMLElement((LogOperation)2, (LogCategory)2, text);
					@string = m_LocalResources.GetString("ERROR_VIEW");
				}
				else
				{
					text = string.Format(m_LocalResources.GetString("LOG_FINISHED_OK"), DateTime.Now);
					Log2File(text);
					LogXMLElement((LogOperation)2, (LogCategory)2, text);
					@string = m_LocalResources.GetString("SUCCESS_VIEW");
				}
				((Control)this).set_Cursor(Cursors.get_Default());
				if ((int)MessageBox.Show(@string, ((Control)this).get_Text(), (MessageBoxButtons)4, (MessageBoxIcon)64) == 6)
				{
					try
					{
						Process.Start("IExplore.exe", LogFileNameXml);
					}
					catch
					{
						MessageBox.Show(m_LocalResources.GetString("NO_LOG"), ((Control)this).get_Text());
					}
				}
			}
		}
		finally
		{
			LogXMLFinalize();
		}
		((Form)this).Close();
	}

	internal void CallVerticalMigration(string methodName, object[] parameters)
	{
		try
		{
			Assembly assembly = Assembly.LoadFrom(m_VertDLLPath);
			Type[] types = assembly.GetTypes();
			foreach (Type type in types)
			{
				if (!(type.FullName == "VerticalAdMigrator.VertAdMigrator"))
				{
					continue;
				}
				Activator.CreateInstance(type);
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == methodName)
					{
						methodInfo.Invoke(null, parameters);
						break;
					}
				}
			}
		}
		catch (SystemException)
		{
			m_isVertMigration = false;
		}
	}

	public static void Log2File(string sLine)
	{
		FileStream fileStream = new FileStream(LogFileName, FileMode.Append, FileAccess.Write, FileShare.None);
		fileStream.Seek(0L, SeekOrigin.End);
		sLine += "\r\n\r\n";
		StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
		streamWriter.Write(sLine);
		streamWriter.Flush();
		streamWriter.Close();
		fileStream.Close();
	}

	public void LogXMLInitialize()
	{
		LogFileName = MigrationFolder + "\\" + m_LocalResources.GetString("LOG_FILE");
		LogFileNameXml = Path.GetFileNameWithoutExtension(LogFileName);
		LogFileNameXml = MigrationFolder + "\\" + LogFileNameXml + ".xml";
		string text = MigrationFolder + "\\migration.xsl";
		string location = Assembly.GetEntryAssembly()!.Location;
		string text2 = location.Substring(0, location.LastIndexOf("\\") + 1) + "migration.xsl";
		if (!File.Exists(text) && File.Exists(text2))
		{
			File.Copy(text2, text, overwrite: false);
		}
		File.Delete(LogFileName);
		File.Delete(LogFileNameXml);
		FileStream fileStream = new FileStream(LogFileNameXml, FileMode.Append, FileAccess.Write, FileShare.None);
		fileStream.Seek(0L, SeekOrigin.End);
		MainWriter = new XmlTextWriter(fileStream, null);
		MainWriter.Formatting = Formatting.Indented;
		MainWriter.WriteStartDocument();
		string text3 = "type='text/xsl' href='migration.xsl'";
		MainWriter.WriteProcessingInstruction("xml-stylesheet", text3);
		MainWriter.WriteStartElement("Log");
		MainWriter.Flush();
	}

	public void LogXMLFinalize()
	{
		if (MainWriter != null)
		{
			MainWriter.Formatting = Formatting.Indented;
			MainWriter.WriteEndElement();
			MainWriter.WriteEndDocument();
			MainWriter.Flush();
			MainWriter.Close();
		}
	}

	public void LogXMLStartSection(LogSection section)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		MainWriter.Formatting = Formatting.Indented;
		string enumDescription = Migrator.GetEnumDescription(typeof(LogSection), (Enum)(object)section);
		MainWriter.WriteStartElement("Section");
		MainWriter.WriteStartAttribute(null, "Name", null);
		MainWriter.WriteString(enumDescription);
		MainWriter.WriteEndAttribute();
		MainWriter.Flush();
	}

	public void LogXMLElement(LogOperation operation, LogCategory category, string message)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		MainWriter.Formatting = Formatting.Indented;
		string enumDescription = Migrator.GetEnumDescription(typeof(LogOperation), (Enum)(object)operation);
		string enumDescription2 = Migrator.GetEnumDescription(typeof(LogCategory), (Enum)(object)category);
		MainWriter.WriteStartElement(enumDescription);
		MainWriter.WriteStartAttribute(null, "Category", null);
		MainWriter.WriteString(enumDescription2);
		MainWriter.WriteEndAttribute();
		MainWriter.WriteString(message);
		MainWriter.WriteEndElement();
		MainWriter.Flush();
	}

	public void LogXMLEndSection()
	{
		MainWriter.Formatting = Formatting.Indented;
		MainWriter.WriteEndElement();
		MainWriter.Flush();
	}

	private void HelpBtn_Click(object sender, EventArgs e)
	{
		string location = Assembly.GetEntryAssembly()!.Location;
		string text = location.Substring(0, location.LastIndexOf("\\") + 1) + "help\\" + m_prodInfo.m_productId + "_sig.chm";
		string text2 = "admigrate.htm";
		if (m_isVertMigration)
		{
			object[] parameters = new object[3] { this, text, text2 };
			CallVerticalMigration("VerticalHelp", parameters);
		}
		else
		{
			Help.ShowHelp((Control)(object)this, text, (HelpNavigator)(-2147483647), (object)text2);
		}
	}

	private void MainForm_Closed(object sender, EventArgs e)
	{
		if (!Migrator.HasMigrated(ProductRegistryRootKey))
		{
			if (bRun)
			{
				Migrator.SetHasMigrated(_Migrator, 0);
			}
			else
			{
				Migrator.SetHasMigrated(_Migrator, 2);
			}
		}
	}

	private void UserProfilesCheck_CheckedChanged(object sender, EventArgs e)
	{
		if (!UserProfilesCheck.get_Checked())
		{
			((Control)CUIFilesCheck).set_Enabled(false);
			((Control)MNUMNSFilesCheck).set_Enabled(false);
			((Control)UserIconFilesCheck).set_Enabled(false);
		}
		else
		{
			((Control)UserIconFilesCheck).set_Enabled(true);
			UpdateCheckBoxes(InstalledVersionsCombo);
		}
	}

	internal static bool StringCollectionContains(StringCollection a, string b, bool ignoreCase)
	{
		if (a == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < a.Count)
			{
				if (string.Compare(a[num], b, ignoreCase, CultureInfo.InvariantCulture) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private void InstalledVersionsCombo_SelectedIndexChanged(object sender, EventArgs e)
	{
		ComboBox val = (ComboBox)((sender is ComboBox) ? sender : null);
		if (val != null)
		{
			UpdateCheckBoxes(val);
		}
	}

	private void UpdateCheckBoxes(ComboBox versionsCombo)
	{
		object selectedItem = versionsCombo.get_SelectedItem();
		ProductInfo val = (ProductInfo)((selectedItem is ProductInfo) ? selectedItem : null);
		if (UserProfilesCheck.get_Checked())
		{
			if (val.m_dVersion >= _Migrator.MinCUIVersion)
			{
				((Control)MNUMNSFilesCheck).set_Enabled(false);
				MNUMNSFilesCheck.set_Checked(false);
				((Control)CUIFilesCheck).set_Enabled(true);
				CUIFilesCheck.set_Checked(true);
			}
			else if (val.IsBeforeRio())
			{
				((Control)MNUMNSFilesCheck).set_Enabled(true);
				MNUMNSFilesCheck.set_Checked(true);
				((Control)CUIFilesCheck).set_Enabled(false);
				CUIFilesCheck.set_Checked(false);
			}
			else
			{
				((Control)MNUMNSFilesCheck).set_Enabled(false);
				MNUMNSFilesCheck.set_Checked(false);
				((Control)CUIFilesCheck).set_Enabled(false);
				CUIFilesCheck.set_Checked(false);
			}
		}
	}

	private void ExportCustomizations()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Invalid comparison between Unknown and I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			InitProductInfo();
			LogXMLInitialize();
			_Migrator.GetInstalledAppList(ProductRegistryRootKey);
			m_prodInfo.m_migrationType = (MigrationType)1;
			m_prodInfo.dataFile = new DataFile(MigrationFolder + "\\MigrationDataFile.xml");
			m_prodInfo.dataFile.SetProductInfo(m_prodInfo);
			ExportDialog exportDialog = new ExportDialog(this);
			((Control)exportDialog.BodyMessage).set_Text(string.Format(LocalResources.GetString("EXPORT_SETTINGS_BODY"), m_prodInfo.m_productName));
			DialogResult val = ((Form)exportDialog).ShowDialog((IWin32Window)(object)this);
			if ((int)val != 1)
			{
				return;
			}
			m_includeNetworkFiles = exportDialog.IncludeNetworkedFiles;
			SaveFileDialog val2 = new SaveFileDialog();
			if (Settings.Default.ExportInitialDirectory != null && Settings.Default.ExportInitialDirectory.Length > 0)
			{
				((FileDialog)val2).set_InitialDirectory(Settings.Default.ExportInitialDirectory);
			}
			else
			{
				((FileDialog)val2).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			}
			((FileDialog)val2).set_CheckFileExists(false);
			((FileDialog)val2).set_Title(LocalResources.GetString("EXPORT_TITLE"));
			((FileDialog)val2).set_Filter(LocalResources.GetString("ZIP_FILEDIALOG_FILTERS"));
			((FileDialog)val2).set_FileName(m_prodInfo.m_productName + LocalResources.GetString("DEFAULT_EXPORT_FILENAME_BODY") + ".zip");
			if ((int)((CommonDialog)val2).ShowDialog() != 1 || Util.IsEmpty(((FileDialog)val2).get_FileName()))
			{
				return;
			}
			ProgressForm progressForm = new ProgressForm();
			try
			{
				((Control)progressForm).Show();
				Application.DoEvents();
				Settings.Default.ExportInitialDirectory = Path.GetDirectoryName(((FileDialog)val2).get_FileName());
				m_prodInfo.zipInt = new ZipInterface();
				m_prodInfo.zipInt.createZipFile(((FileDialog)val2).get_FileName());
				m_prodInfo.m_zipFileName = ((FileDialog)val2).get_FileName();
				Application.DoEvents();
				if (m_isVertMigration)
				{
					object[] parameters = new object[2]
					{
						((FileDialog)val2).get_FileName(),
						m_prodInfo.m_regRootKey
					};
					CallVerticalMigration("ZipPreProcess", parameters);
					StringDictionary stringDictionary = new StringDictionary();
					object[] parameters2 = new object[1] { stringDictionary };
					CallVerticalMigration("VerticalEnvironmentVariables", parameters2);
					if (stringDictionary.Count > 0)
					{
						foreach (string key in stringDictionary.Keys)
						{
							m_prodInfo.get_EnvVars().Add(key, stringDictionary[key], true);
						}
					}
				}
				Application.DoEvents();
				ProfileMigrator val3 = null;
				string location = Assembly.GetEntryAssembly()!.Location;
				string text2 = location.Substring(0, location.LastIndexOf("\\") + 1) + "AdMigrator.xml";
				val3 = new ProfileMigrator(text2);
				val3.set_IncludeNetworkedFiles(exportDialog.IncludeNetworkedFiles);
				val3.Migrate(_Migrator.destProductInfo(), m_prodInfo, ProductRegistryRootKey, new Log(Log2File));
				Application.DoEvents();
				m_prodInfo.dataFile.SetSourceVariables(m_prodInfo.get_EnvVars());
				Application.DoEvents();
				if (m_isVertMigration)
				{
					CallVerticalMigration("ZipPostProcess", null);
				}
				Application.DoEvents();
				m_prodInfo.dataFile.Save();
				m_prodInfo.zipInt.addFileToZip(m_prodInfo.dataFile.get_FileName());
				File.Delete(m_prodInfo.dataFile.get_FileName());
			}
			finally
			{
				((IDisposable)progressForm)?.Dispose();
			}
			string text3 = string.Format(LocalResources.GetString("EXPORT_SUCCESS"), ((FileDialog)val2).get_FileName());
			MessageBox.Show(text3, m_prodInfo.m_productName);
		}
		catch (SystemException ex)
		{
			string text4 = string.Format(LocalResources.GetString("EXPORT_FAILURE"), ex.Message);
			MessageBox.Show(text4, m_prodInfo.m_productName);
		}
		finally
		{
			LogXMLFinalize();
			if (m_prodInfo.zipInt != null)
			{
				m_prodInfo.zipInt.closeZipFile();
			}
		}
	}

	private void ImportCustomizations()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		bool flag = false;
		InitProductInfo();
		LogXMLInitialize();
		_Migrator.GetInstalledAppList(ProductRegistryRootKey);
		OpenFileDialog val = new OpenFileDialog();
		if (Settings.Default.ImportInitialDirectory != null && Settings.Default.ImportInitialDirectory.Length > 0)
		{
			((FileDialog)val).set_InitialDirectory(Settings.Default.ImportInitialDirectory);
		}
		else
		{
			((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		}
		((FileDialog)val).set_Title(LocalResources.GetString("IMPORT_TITLE"));
		((FileDialog)val).set_Filter(LocalResources.GetString("ZIP_FILEDIALOG_FILTERS"));
		if ((int)((CommonDialog)val).ShowDialog() != 1 || Util.IsEmpty(((FileDialog)val).get_FileName()))
		{
			return;
		}
		Settings.Default.ImportInitialDirectory = Path.GetDirectoryName(((FileDialog)val).get_FileName());
		m_prodInfo.zipInt = new ZipInterface();
		int num = m_prodInfo.zipInt.initZipExtraction(((FileDialog)val).get_FileName(), MigrationFolder);
		if (num < 0)
		{
			if (num == -2)
			{
				text = string.Format(LocalResources.GetString("ERROR_NOT_EXPORT_PACKAGE"), m_prodInfo.m_productName);
			}
			if (num == -1)
			{
				text = LocalResources.GetString("ERROR_UNZIPPING_FILE");
			}
			MessageBox.Show(text, LocalResources.GetString("IMPORT_TITLE"));
			return;
		}
		m_prodInfo.m_migrationType = (MigrationType)1;
		m_prodInfo.dataFile = new DataFile(MigrationFolder + "\\MigrationDataFile.xml");
		m_prodInfo.PostProcessDataFile();
		bool flag2 = true;
		if (string.Compare(m_prodInfo.m_productId, _Migrator.destProductInfo().m_productId, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
		{
			flag2 = false;
		}
		if (string.Compare(m_prodInfo.m_productTag, _Migrator.destProductInfo().m_productTag, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
		{
			flag2 = false;
		}
		if (string.Compare(m_prodInfo.m_version, _Migrator.destProductInfo().m_version, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
		{
			flag2 = false;
		}
		if (string.Compare(m_prodInfo.m_languageTag, _Migrator.destProductInfo().m_languageTag, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
		{
			flag2 = false;
		}
		if (!flag2)
		{
			text = string.Format(LocalResources.GetString("ERROR_IMPORT_TYPE"), m_prodInfo.m_productName, m_prodInfo.m_version, m_prodInfo.m_languageTag);
			MessageBox.Show(text, LocalResources.GetString("IMPORT_TITLE"));
			return;
		}
		if (string.Compare(m_prodInfo.dataFile.get_Culture(), CultureInfo.CurrentCulture.Name, ignoreCase: true, CultureInfo.InvariantCulture) != 0)
		{
			MessageBox.Show(LocalResources.GetString("WARNING_DIFFERENTCODEPAGE"), LocalResources.GetString("IMPORT_TITLE"));
		}
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetTempPath() + "\\AdMigExtraction");
		m_prodInfo.m_zipExtractDir = directoryInfo.FullName;
		ProfileMigrator val2 = null;
		try
		{
			ProgressForm progressForm = new ProgressForm();
			try
			{
				((Control)progressForm).Show();
				Application.DoEvents();
				LogXMLStartSection((LogSection)10);
				text = string.Format(m_LocalResources.GetString("IMPORT_FILE"), ((FileDialog)val).get_FileName());
				LogXMLElement((LogOperation)2, (LogCategory)1, text);
				string location = Assembly.GetEntryAssembly()!.Location;
				string text2 = location.Substring(0, location.LastIndexOf("\\") + 1) + "AdMigrator.xml";
				val2 = new ProfileMigrator(text2);
				Application.DoEvents();
				if (m_isVertMigration)
				{
					object[] parameters = new object[2] { directoryInfo.FullName, ProductRegistryRootKey };
					CallVerticalMigration("UnZipPreProcess", parameters);
					StringDictionary stringDictionary = new StringDictionary();
					object[] parameters2 = new object[1] { stringDictionary };
					CallVerticalMigration("VerticalEnvironmentVariables", parameters2);
					if (stringDictionary.Count > 0)
					{
						foreach (string key in stringDictionary.Keys)
						{
							_Migrator.destProductInfo().get_EnvVars().Add(key, stringDictionary[key], true);
						}
					}
				}
				Application.DoEvents();
				flag = val2.Migrate(m_prodInfo, _Migrator.destProductInfo(), ProductRegistryRootKey, new Log(Log2File));
				Application.DoEvents();
				if (m_isVertMigration)
				{
					CallVerticalMigration("UnZipPostProcess", null);
				}
				Application.DoEvents();
			}
			finally
			{
				((IDisposable)progressForm)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			text = string.Format(m_LocalResources.GetString("ERROR_UNKNOWN"), ex.Message);
			LogXMLElement((LogOperation)0, (LogCategory)0, text);
			Log2File(text);
			Migrator.m_bErrors = true;
		}
		finally
		{
			LogXMLEndSection();
			if (m_prodInfo.zipInt != null)
			{
				m_prodInfo.zipInt.closeUnzip();
			}
			if (Directory.Exists(m_prodInfo.m_zipExtractDir))
			{
				Directory.Delete(m_prodInfo.m_zipExtractDir, recursive: true);
			}
			if (File.Exists(m_prodInfo.dataFile.get_FileName()))
			{
				File.Delete(m_prodInfo.dataFile.get_FileName());
			}
		}
		LogXMLFinalize();
		ImportDialog importDialog = new ImportDialog();
		if (!flag)
		{
			text = (importDialog.successMsg = m_LocalResources.GetString("IMPORT_FAILURE"));
		}
		else
		{
			text = (importDialog.labelLogText = string.Format(m_LocalResources.GetString("IMPORT_LOG_LOCATION"), LogFileNameXml));
		}
		((Form)importDialog).ShowDialog();
		if (!importDialog.displayLog)
		{
			return;
		}
		try
		{
			Process.Start("IExplore.exe", LogFileNameXml);
		}
		catch
		{
			MessageBox.Show(m_LocalResources.GetString("NO_LOG"), ((Control)this).get_Text());
		}
	}

	public static CUIFileMap GetFileMapFromMenuGroup(string menuGroupName)
	{
		foreach (CUIFileMap item in CUIFileMapArray)
		{
			if (menuGroupName.Equals(item.SourceMenuGroupName, StringComparison.InvariantCultureIgnoreCase))
			{
				return item;
			}
		}
		return null;
	}

	public static CUIFileMap GetFileMapFromMacroGroup(string macroGroupName)
	{
		foreach (CUIFileMap item in CUIFileMapArray)
		{
			if (macroGroupName.Equals(item.SourceMacroGroupName, StringComparison.InvariantCultureIgnoreCase))
			{
				return item;
			}
		}
		return null;
	}

	public static CUIFileMap GetFileMapFromFileName(string fileName)
	{
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
		foreach (CUIFileMap item in CUIFileMapArray)
		{
			string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(item.SourceFileName);
			if (fileNameWithoutExtension.Equals(fileNameWithoutExtension2, StringComparison.InvariantCultureIgnoreCase))
			{
				return item;
			}
		}
		return null;
	}
}
