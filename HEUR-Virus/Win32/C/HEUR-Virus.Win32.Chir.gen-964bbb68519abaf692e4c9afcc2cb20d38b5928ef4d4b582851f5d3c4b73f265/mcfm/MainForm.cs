using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Windows.Forms;
using MindCompression.DataObjects;
using MindCompression.Memory;
using MindCompression.Utils;

namespace mcfm;

public class MainForm : Form
{
	private byte[] bytes01 = new byte[48]
	{
		156, 216, 201, 0, 136, 216, 201, 0, 100, 66,
		235, 0, 172, 68, 235, 0, 108, 73, 236, 0,
		192, 75, 236, 0, 60, 191, 235, 0, 132, 192,
		235, 0, 204, 223, 234, 0, 188, 223, 234, 0,
		252, 245, 234, 0, 232, 245, 234, 0
	};

	private byte[] bytes02 = new byte[48]
	{
		68, 148, 206, 0, 52, 148, 206, 0, 148, 88,
		235, 0, 220, 90, 235, 0, 172, 67, 236, 0,
		0, 70, 236, 0, 44, 34, 236, 0, 116, 35,
		236, 0, 28, 67, 235, 0, 12, 67, 235, 0,
		212, 94, 235, 0, 192, 94, 235, 0
	};

	public static string FullTrustErrorMessage = "Mcfm05 has not been granted FullTrust permission by the" + Environment.NewLine + ".NET Framework. Mcfm05 needs this permission to work. If" + Environment.NewLine + "you get this error this usually means you have installed" + Environment.NewLine + "mcfm05 to a network or internet folder. If you install" + Environment.NewLine + "the program to your local drive these problems will most" + Environment.NewLine + "likely not occur." + Environment.NewLine + Environment.NewLine + "If problems persist ask your computer administrator to grant" + Environment.NewLine + "mcfm05 FullTrust permission. More information about .NET security" + Environment.NewLine + "can be found at the following location:" + Environment.NewLine + Environment.NewLine + "http://www.gotdotnet.com/team/clr/SecurityPolicyBestPractices.htm";

	public static string ProcessCounterErrorMessage = "The process performance counter is disabled. It needs to be" + Environment.NewLine + "enabled to use mcfm05. Use the following links for possible" + Environment.NewLine + "solutions to this problem:" + Environment.NewLine + Environment.NewLine + "http://support.microsoft.com/default.aspx?scid=kb;EN-US;q249138" + Environment.NewLine + "http://support.microsoft.com/default.aspx?scid=kb;en-us;Q248993" + Environment.NewLine + "http://www.error-bank.com/microsoft.public.dotnet.general/115926_Thread.aspx" + Environment.NewLine + "http://www.microsoft.com/windows2000/techinfo/reskit/tools/existing/exctrlst-o.asp" + Environment.NewLine + "If problems still persist after trying all of the solutions" + Environment.NewLine + "please visit our forum at the following link:" + Environment.NewLine + Environment.NewLine + "http://community.mindcompression.com";

	public static string UnknownFootballManagerVersion = "The version of the currently running instance of Football Manager 2005" + Environment.NewLine + "could not be determined. This might be because you installed a patch" + Environment.NewLine + "that was released later then this version of MCFM05. MCFM05 will try" + Environment.NewLine + "to work using the search parameters of the latest know version at" + Environment.NewLine + "this time. If MCFM05 does not work correctly, please visit our website" + Environment.NewLine + "to see if a newer version of our program was released. Our website can" + Environment.NewLine + "be found at http://www.mindcompression.com";

	public static string CouldNotFindPlayers = "MCFM could not find any players in the currently running instance of" + Environment.NewLine + "Football Manager 2005. This happens in 2 situations:" + Environment.NewLine + Environment.NewLine + "1. You might not have loaded your save game in FM 2005." + Environment.NewLine + "2. The currently running version of FM 2005 is not supported." + Environment.NewLine + "3. You are running FM 2005 using a cracked executable." + Environment.NewLine + Environment.NewLine + "In the first case, load your game in FM 2005 and try again." + Environment.NewLine + "In the second case, wait for the next version to be released." + Environment.NewLine + "In the third case, buy the original version and try again.";

	public static string StillCouldNotFindPlayers = "Your version of World Wide Soccer Manager (WWSM) is not yet supported, or" + Environment.NewLine + "you did not load your save game in WWSM. If the first is the case, please" + Environment.NewLine + "wait for a next version of MCFM which does support your version of WWSM." + Environment.NewLine + "If the latter is the case, please load your game in WWSM and try again.";

	public static string NotBackwardsCompatible = "Since version 0.3.0 of MCFM it is no longer backwards compatible. This" + Environment.NewLine + "was caused by the large amount of changes and the complexity of these" + Environment.NewLine + "changes in the latest patch for FM 2005 (patch version 5.0.5). MCFM" + Environment.NewLine + "detected an older version of FM 2005 on your machine, you will have" + Environment.NewLine + "to download and install the 5.0.5 patch for FM 2005 to get MCFM to" + Environment.NewLine + "work correctly.";

	private ProcessMemory pReader = new ProcessMemory();

	private SearchOptions options = new SearchOptions();

	private PropertyGrid propertyGrid1;

	private Button btLoad;

	private TextBox tbSearch;

	private Button btSearch;

	private Panel paSearch;

	private ListBox lbSearchResults;

	private Panel paUnicode;

	private Button btUnicode;

	private TextBox tbUnicode;

	private LinkLabel linkLabel1;

	private ListBox tbLog;

	private DateTimePicker dateTimePicker1;

	private Button button1;

	private Panel panel1;

	private Splitter splitter1;

	private Panel panel5;

	private PropertyGrid propertyGrid2;

	private Panel panel6;

	private Panel panel4;

	private CheckBox checkBox1;

	private Panel panel2;

	private Panel panel3;

	private ToolBar toolBar1;

	private ToolBarButton btAllPlayersFromClub;

	private ImageList imageList1;

	private ToolBarButton btAllPlayersFromSameClub;

	private ToolBarButton btHealPlayer;

	private IContainer components;

	public MainForm()
	{
		InitializeComponent();
		((Control)this).set_Text(((Control)this).get_Text() + " - Version " + Assembly.GetExecutingAssembly().GetName().Version!.ToString());
		propertyGrid2.set_SelectedObject((object)options);
		((Control)paUnicode).set_Visible(false);
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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_0b15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1f: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Expected O, but got Unknown
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f49: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(MainForm));
		btLoad = new Button();
		lbSearchResults = new ListBox();
		propertyGrid1 = new PropertyGrid();
		paSearch = new Panel();
		checkBox1 = new CheckBox();
		tbSearch = new TextBox();
		btSearch = new Button();
		paUnicode = new Panel();
		button1 = new Button();
		dateTimePicker1 = new DateTimePicker();
		tbLog = new ListBox();
		btUnicode = new Button();
		tbUnicode = new TextBox();
		linkLabel1 = new LinkLabel();
		panel1 = new Panel();
		panel3 = new Panel();
		panel2 = new Panel();
		toolBar1 = new ToolBar();
		btAllPlayersFromClub = new ToolBarButton();
		btAllPlayersFromSameClub = new ToolBarButton();
		imageList1 = new ImageList(components);
		splitter1 = new Splitter();
		panel5 = new Panel();
		panel6 = new Panel();
		propertyGrid2 = new PropertyGrid();
		panel4 = new Panel();
		btHealPlayer = new ToolBarButton();
		((Control)paSearch).SuspendLayout();
		((Control)paUnicode).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)panel6).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btLoad).set_Location(new Point(8, 8));
		((Control)btLoad).set_Name("btLoad");
		((Control)btLoad).set_Size(new Size(144, 23));
		((Control)btLoad).set_TabIndex(0);
		((Control)btLoad).set_Text("Load FM2005");
		((Control)btLoad).add_Click((EventHandler)btLoad_Click);
		((Control)lbSearchResults).set_Dock((DockStyle)5);
		lbSearchResults.set_ItemHeight(14);
		((Control)lbSearchResults).set_Location(new Point(8, 8));
		((Control)lbSearchResults).set_Name("lbSearchResults");
		lbSearchResults.set_SelectionMode((SelectionMode)3);
		((Control)lbSearchResults).set_Size(new Size(268, 550));
		lbSearchResults.set_Sorted(true);
		((Control)lbSearchResults).set_TabIndex(4);
		lbSearchResults.add_SelectedIndexChanged((EventHandler)lbSearchResults_SelectedIndexChanged);
		propertyGrid1.set_CommandsVisibleIfAvailable(true);
		((Control)propertyGrid1).set_Cursor(Cursors.get_HSplit());
		((Control)propertyGrid1).set_Dock((DockStyle)5);
		((Control)propertyGrid1).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		propertyGrid1.set_LargeButtons(false);
		propertyGrid1.set_LineColor(SystemColors.ScrollBar);
		((Control)propertyGrid1).set_Location(new Point(0, 0));
		((Control)propertyGrid1).set_Name("propertyGrid1");
		((Control)propertyGrid1).set_Size(new Size(266, 487));
		((Control)propertyGrid1).set_TabIndex(4);
		((Control)propertyGrid1).set_Text("propertyGrid1");
		propertyGrid1.set_ViewBackColor(SystemColors.Window);
		propertyGrid1.set_ViewForeColor(SystemColors.WindowText);
		((Control)paSearch).get_Controls().Add((Control)(object)checkBox1);
		((Control)paSearch).get_Controls().Add((Control)(object)tbSearch);
		((Control)paSearch).get_Controls().Add((Control)(object)btSearch);
		((Control)paSearch).get_Controls().Add((Control)(object)btLoad);
		((Control)paSearch).set_Dock((DockStyle)1);
		((Control)paSearch).set_Location(new Point(4, 4));
		((Control)paSearch).set_Name("paSearch");
		((Control)paSearch).set_Size(new Size(232, 124));
		((Control)paSearch).set_TabIndex(1);
		((Control)checkBox1).set_Enabled(false);
		((Control)checkBox1).set_Location(new Point(8, 96));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(152, 24));
		((Control)checkBox1).set_TabIndex(3);
		((Control)checkBox1).set_Text("Advanced search options");
		checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
		((Control)tbSearch).set_Enabled(false);
		((Control)tbSearch).set_Location(new Point(8, 40));
		((Control)tbSearch).set_Name("tbSearch");
		((Control)tbSearch).set_Size(new Size(144, 20));
		((Control)tbSearch).set_TabIndex(1);
		((Control)tbSearch).set_Text("");
		((Control)tbSearch).add_KeyDown(new KeyEventHandler(tbSearch_KeyDown));
		((Control)btSearch).set_Enabled(false);
		((Control)btSearch).set_Location(new Point(8, 64));
		((Control)btSearch).set_Name("btSearch");
		((Control)btSearch).set_Size(new Size(144, 23));
		((Control)btSearch).set_TabIndex(2);
		((Control)btSearch).set_Text("Search");
		((Control)btSearch).add_Click((EventHandler)btSearch_Click);
		((Control)paUnicode).get_Controls().Add((Control)(object)button1);
		((Control)paUnicode).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)paUnicode).get_Controls().Add((Control)(object)tbLog);
		((Control)paUnicode).get_Controls().Add((Control)(object)btUnicode);
		((Control)paUnicode).get_Controls().Add((Control)(object)tbUnicode);
		((Control)paUnicode).set_Dock((DockStyle)2);
		((Control)paUnicode).set_Location(new Point(4, 307));
		((Control)paUnicode).set_Name("paUnicode");
		((Control)paUnicode).set_Size(new Size(232, 256));
		((Control)paUnicode).set_TabIndex(5);
		((Control)button1).set_Location(new Point(8, 88));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(216, 23));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("Convert date");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)dateTimePicker1).set_Location(new Point(8, 64));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(216, 20));
		((Control)dateTimePicker1).set_TabIndex(6);
		tbLog.set_ItemHeight(14);
		((Control)tbLog).set_Location(new Point(8, 120));
		((Control)tbLog).set_Name("tbLog");
		((Control)tbLog).set_Size(new Size(216, 130));
		((Control)tbLog).set_TabIndex(5);
		((Control)btUnicode).set_Location(new Point(8, 32));
		((Control)btUnicode).set_Name("btUnicode");
		((Control)btUnicode).set_Size(new Size(216, 23));
		((Control)btUnicode).set_TabIndex(4);
		((Control)btUnicode).set_Text("Convert to unicode");
		((Control)btUnicode).add_Click((EventHandler)btUnicode_Click);
		((Control)tbUnicode).set_Location(new Point(8, 8));
		((Control)tbUnicode).set_Name("tbUnicode");
		((Control)tbUnicode).set_Size(new Size(208, 20));
		((Control)tbUnicode).set_TabIndex(3);
		((Control)tbUnicode).set_Text("");
		((Control)linkLabel1).set_Location(new Point(8, 48));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(152, 16));
		((Control)linkLabel1).set_TabIndex(6);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("www.mindcompression.com");
		((Label)linkLabel1).set_TextAlign((ContentAlignment)32);
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)panel1).get_Controls().Add((Control)(object)panel3);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).set_Dock((DockStyle)4);
		((ScrollableControl)panel1).get_DockPadding().set_Bottom(4);
		((ScrollableControl)panel1).get_DockPadding().set_Left(2);
		((ScrollableControl)panel1).get_DockPadding().set_Right(4);
		((ScrollableControl)panel1).get_DockPadding().set_Top(4);
		((Control)panel1).set_Location(new Point(522, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(272, 567));
		((Control)panel1).set_TabIndex(7);
		((Control)panel3).get_Controls().Add((Control)(object)propertyGrid1);
		((Control)panel3).set_Dock((DockStyle)5);
		((Control)panel3).set_Location(new Point(2, 4));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(266, 487));
		((Control)panel3).set_TabIndex(1);
		((Control)panel2).get_Controls().Add((Control)(object)toolBar1);
		((Control)panel2).get_Controls().Add((Control)(object)linkLabel1);
		((Control)panel2).set_Dock((DockStyle)2);
		((Control)panel2).set_Location(new Point(2, 491));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(266, 72));
		((Control)panel2).set_TabIndex(0);
		toolBar1.set_AutoSize(false);
		toolBar1.get_Buttons().AddRange((ToolBarButton[])(object)new ToolBarButton[3] { btAllPlayersFromClub, btAllPlayersFromSameClub, btHealPlayer });
		toolBar1.set_DropDownArrows(true);
		toolBar1.set_ImageList(imageList1);
		((Control)toolBar1).set_Location(new Point(0, 0));
		((Control)toolBar1).set_Name("toolBar1");
		toolBar1.set_ShowToolTips(true);
		((Control)toolBar1).set_Size(new Size(266, 28));
		((Control)toolBar1).set_TabIndex(7);
		toolBar1.add_ButtonClick(new ToolBarButtonClickEventHandler(toolBar1_ButtonClick));
		btAllPlayersFromClub.set_ImageIndex(0);
		btAllPlayersFromClub.set_ToolTipText("Select all players from this club");
		btAllPlayersFromSameClub.set_ImageIndex(0);
		btAllPlayersFromSameClub.set_ToolTipText("Select all players from the same club");
		imageList1.set_ImageSize(new Size(16, 16));
		imageList1.set_ImageStream((ImageListStreamer)resourceManager.GetObject("imageList1.ImageStream"));
		imageList1.set_TransparentColor(Color.Transparent);
		((Control)splitter1).set_BackColor(SystemColors.Control);
		((Control)splitter1).set_Dock((DockStyle)4);
		((Control)splitter1).set_Location(new Point(518, 0));
		((Control)splitter1).set_Name("splitter1");
		((Control)splitter1).set_Size(new Size(4, 567));
		((Control)splitter1).set_TabIndex(8);
		splitter1.set_TabStop(false);
		((Control)panel5).get_Controls().Add((Control)(object)panel6);
		((Control)panel5).get_Controls().Add((Control)(object)paSearch);
		((Control)panel5).get_Controls().Add((Control)(object)paUnicode);
		((Control)panel5).set_Dock((DockStyle)3);
		((ScrollableControl)panel5).get_DockPadding().set_All(4);
		((Control)panel5).set_Location(new Point(0, 0));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(240, 567));
		((Control)panel5).set_TabIndex(10);
		((Control)panel6).get_Controls().Add((Control)(object)propertyGrid2);
		((Control)panel6).set_Dock((DockStyle)5);
		((ScrollableControl)panel6).get_DockPadding().set_All(4);
		((Control)panel6).set_Location(new Point(4, 128));
		((Control)panel6).set_Name("panel6");
		((Control)panel6).set_Size(new Size(232, 179));
		((Control)panel6).set_TabIndex(7);
		propertyGrid2.set_CommandsVisibleIfAvailable(true);
		((Control)propertyGrid2).set_Dock((DockStyle)5);
		propertyGrid2.set_LargeButtons(false);
		propertyGrid2.set_LineColor(SystemColors.ScrollBar);
		((Control)propertyGrid2).set_Location(new Point(4, 4));
		((Control)propertyGrid2).set_Name("propertyGrid2");
		((Control)propertyGrid2).set_Size(new Size(224, 171));
		((Control)propertyGrid2).set_TabIndex(6);
		((Control)propertyGrid2).set_Text("propertyGrid2");
		propertyGrid2.set_ViewBackColor(SystemColors.Window);
		propertyGrid2.set_ViewForeColor(SystemColors.WindowText);
		((Control)propertyGrid2).set_Visible(false);
		((Control)panel4).get_Controls().Add((Control)(object)lbSearchResults);
		((Control)panel4).set_Dock((DockStyle)5);
		((ScrollableControl)panel4).get_DockPadding().set_Bottom(8);
		((ScrollableControl)panel4).get_DockPadding().set_Left(8);
		((ScrollableControl)panel4).get_DockPadding().set_Right(2);
		((ScrollableControl)panel4).get_DockPadding().set_Top(8);
		((Control)panel4).set_Location(new Point(240, 0));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(278, 567));
		((Control)panel4).set_TabIndex(11);
		btHealPlayer.set_ImageIndex(1);
		btHealPlayer.set_ToolTipText("Heal the selected player(s)");
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(794, 567));
		((Control)this).get_Controls().Add((Control)(object)panel4);
		((Control)this).get_Controls().Add((Control)(object)panel5);
		((Control)this).get_Controls().Add((Control)(object)splitter1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Font(new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)resourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("MCFM 05");
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)paSearch).ResumeLayout(false);
		((Control)paUnicode).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel5).ResumeLayout(false);
		((Control)panel6).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void Main()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Application.Run((Form)(object)new MainForm());
		}
		catch (SecurityException)
		{
			MessageBox.Show(FullTrustErrorMessage);
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.ToString());
		}
	}

	private void btLoad_Click(object sender, EventArgs e)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		int num = -1;
		byte[] sb = new byte[0];
		try
		{
			num = pReader.OpenProcess("fm2005");
		}
		catch (InvalidOperationException)
		{
			num = pReader.EvenOlderOpenProcess("Football Manager 2005");
			if (num != 0)
			{
				MessageBox.Show(ProcessCounterErrorMessage);
				Application.Exit();
			}
		}
		if (num == 0)
		{
			switch (pReader.ReadInt32(pReader.ProcessStart + 244))
			{
			case 782425187:
			case 788935750:
			case 1192244486:
				FmMemory.Version = VersionInfo.v502Retail;
				MessageBox.Show(NotBackwardsCompatible);
				Application.Exit();
				break;
			default:
				FmMemory.Version = VersionInfo.v503Retail;
				sb = bytes02;
				((Control)this).set_Text(((Control)this).get_Text() + "                      FM 2005 version could not be detected");
				MessageBox.Show(UnknownFootballManagerVersion);
				break;
			case 797114482:
				if (pReader.ReadInt32(pReader.ProcessStart + 280) == 1109695600)
				{
					FmMemory.Version = VersionInfo.v503Retail;
					sb = bytes01;
					((Control)this).set_Text(((Control)this).get_Text() + "                      FM 2005 v5.0.3 Retail detected");
				}
				else if (pReader.ReadInt32(pReader.ProcessStart + 280) == 1110558028)
				{
					FmMemory.Version = VersionInfo.v505Retail;
					sb = bytes02;
					((Control)this).set_Text(((Control)this).get_Text() + "                      FM 2005 v5.0.5 Retail detected");
				}
				else
				{
					FmMemory.Version = VersionInfo.v505Retail;
					sb = bytes02;
					((Control)this).set_Text(((Control)this).get_Text() + "                      FM 2005 version could not be detected");
					MessageBox.Show(UnknownFootballManagerVersion);
				}
				break;
			}
			((Control)btLoad).set_Enabled(false);
			FmObjectLists.Instance.AllObjects = FmMemory.LoadFmMItems(pReader, sb);
			if (FmMemory.cntPlayers == 0)
			{
				MessageBox.Show(CouldNotFindPlayers);
				Application.Exit();
			}
			tbLog.get_Items().Add((object)("Cities : " + FmMemory.cntCities));
			tbLog.get_Items().Add((object)("Countries : " + FmMemory.cntCountries));
			tbLog.get_Items().Add((object)("Teams : " + FmMemory.cntTeams));
			tbLog.get_Items().Add((object)("Players : " + FmMemory.cntPlayers));
			tbLog.get_Items().Add((object)("PlayerCoaches : " + FmMemory.cntPlayerCoaches));
			tbLog.get_Items().Add((object)("Coaches : " + FmMemory.cntCoaches));
			((Control)tbSearch).set_Enabled(true);
			((Control)btSearch).set_Enabled(true);
			((Control)checkBox1).set_Enabled(true);
			((Control)tbSearch).Focus();
		}
		else
		{
			MessageBox.Show("FM2005 is not started!");
		}
	}

	public void SelectFirst()
	{
		if (lbSearchResults.get_Items().get_Count() > 0)
		{
			((ListControl)lbSearchResults).set_SelectedIndex(0);
		}
	}

	private void btUnicode_Click(object sender, EventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		for (int i = 0; i < ((Control)tbUnicode).get_Text().Length; i++)
		{
			text += $"{(int)((Control)tbUnicode).get_Text()[i]:X2}00";
		}
		MessageBox.Show(text);
	}

	private void lbSearchResults_SelectedIndexChanged(object sender, EventArgs e)
	{
		object[] array = new object[lbSearchResults.get_SelectedItems().get_Count()];
		HideToolBars();
		bool flag = true;
		for (int i = 0; i < lbSearchResults.get_SelectedItems().get_Count(); i++)
		{
			FmObject fmObject = (FmObject)lbSearchResults.get_SelectedItems().get_Item(i);
			array[i] = fmObject.ExpandObject();
			if (lbSearchResults.get_SelectedItems().get_Count() == 1 && fmObject.Type == FmObjectType.Team)
			{
				btAllPlayersFromClub.set_Visible(true);
			}
			if (lbSearchResults.get_SelectedItems().get_Count() == 1 && fmObject.Type == FmObjectType.Player)
			{
				btAllPlayersFromSameClub.set_Visible(true);
			}
			if (fmObject.Type != FmObjectType.Player && fmObject.Type != FmObjectType.PlayerCoach)
			{
				flag = false;
			}
		}
		if (flag)
		{
			btHealPlayer.set_Visible(true);
		}
		propertyGrid1.set_SelectedObjects(array);
	}

	private void btSearch_Click(object sender, EventArgs e)
	{
		lbSearchResults.get_Items().Clear();
		foreach (FmObject item in Search.SearchItem(((Control)tbSearch).get_Text(), options))
		{
			lbSearchResults.get_Items().Add((object)item);
		}
		SelectFirst();
	}

	private void tbSearch_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.get_KeyValue() == 13)
		{
			btSearch_Click(sender, (EventArgs)(object)e);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("IExplore", "http://www.mindcompression.com");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show($"{FmDateTime.ToFmDateTime(dateTimePicker1.get_Value()):X}");
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)propertyGrid2).set_Visible(checkBox1.get_Checked());
	}

	private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
	{
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		if (((object)e.get_Button()).Equals((object?)btAllPlayersFromClub))
		{
			lbSearchResults.get_Items().Clear();
			Team team = (Team)propertyGrid1.get_SelectedObject();
			ArrayList playersFromTeam = team.GetPlayersFromTeam();
			lbSearchResults.get_Items().AddRange(playersFromTeam.ToArray());
			SelectFirst();
		}
		if (((object)e.get_Button()).Equals((object?)btAllPlayersFromSameClub))
		{
			lbSearchResults.get_Items().Clear();
			Player player = (Player)propertyGrid1.get_SelectedObject();
			Team teamFromPlayer = player.GetTeamFromPlayer();
			ArrayList playersFromTeam2 = teamFromPlayer.GetPlayersFromTeam();
			lbSearchResults.get_Items().AddRange(playersFromTeam2.ToArray());
			SelectFirst();
		}
		if (!((object)e.get_Button()).Equals((object?)btHealPlayer))
		{
			return;
		}
		for (int i = 0; i < lbSearchResults.get_SelectedItems().get_Count(); i++)
		{
			FmObject fmObject = (FmObject)lbSearchResults.get_SelectedItems().get_Item(i);
			if (fmObject.Type == FmObjectType.Player)
			{
				Player player2 = new Player(fmObject);
				player2.Condition = 100;
				player2.Fitness = 100;
				player2.Morale = 127;
				player2.Heal();
			}
			if (fmObject.Type == FmObjectType.PlayerCoach)
			{
				PlayerCoach playerCoach = new PlayerCoach(fmObject);
				playerCoach.Condition = 100;
				playerCoach.Fitness = 100;
				playerCoach.Morale = 127;
				playerCoach.Heal();
			}
		}
		MessageBox.Show("All selected players are healed, motivated and massaged!");
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		HideToolBars();
	}

	public void HideToolBars()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		foreach (ToolBarButton button in toolBar1.get_Buttons())
		{
			ToolBarButton val = button;
			val.set_Visible(false);
		}
	}
}
