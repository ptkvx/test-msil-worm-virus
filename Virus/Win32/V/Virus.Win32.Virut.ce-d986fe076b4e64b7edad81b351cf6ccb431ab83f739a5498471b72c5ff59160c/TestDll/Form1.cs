using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using TestDll.Properties;

namespace TestDll;

public class Form1 : Form
{
	private delegate void SaveToFileDelegate(string p, string d);

	private IContainer components;

	private Button buttonStart;

	private Label label1;

	private Button buttonStop;

	private GroupBox groupBox1;

	private RadioButton radioButtonSiteExplorer;

	private RadioButton radioButtonWebSearch;

	private GroupBox groupBox2;

	private LinkLabel linkLabel1;

	private TextBox textBox1;

	private GroupBox groupBox3;

	private CheckBox checkBoxSnippets;

	private CheckBox checkBoxLinks;

	private CheckBox checkBoxRelatedWords;

	private RadioButton radioButtonImageSearch;

	private CheckBox checkBoxDelisiousTags;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private GroupBox groupBox4;

	private LinkLabel queryLabel;

	private LinkLabel tldLabelRu;

	private GroupBox groupBox5;

	private LinkLabel imagesLabel;

	private LinkLabel resultsLabel;

	private RadioButton radioButtonNewsSearch;

	private ComboBox comboBox1;

	private CheckBox checkBoxTLDRotation;

	private CheckBox checkBoxTitles;

	private Thread d;

	private bool stop;

	private int res_temp;

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
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Expected O, but got Unknown
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected O, but got Unknown
		//IL_0e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9e: Expected O, but got Unknown
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected O, but got Unknown
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected O, but got Unknown
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_104f: Expected O, but got Unknown
		//IL_1057: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		buttonStart = new Button();
		label1 = new Label();
		buttonStop = new Button();
		groupBox1 = new GroupBox();
		radioButtonNewsSearch = new RadioButton();
		radioButtonImageSearch = new RadioButton();
		radioButtonSiteExplorer = new RadioButton();
		radioButtonWebSearch = new RadioButton();
		groupBox2 = new GroupBox();
		linkLabel1 = new LinkLabel();
		textBox1 = new TextBox();
		groupBox3 = new GroupBox();
		checkBoxTitles = new CheckBox();
		checkBoxDelisiousTags = new CheckBox();
		checkBoxRelatedWords = new CheckBox();
		checkBoxLinks = new CheckBox();
		checkBoxSnippets = new CheckBox();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		groupBox4 = new GroupBox();
		checkBoxTLDRotation = new CheckBox();
		comboBox1 = new ComboBox();
		tldLabelRu = new LinkLabel();
		queryLabel = new LinkLabel();
		groupBox5 = new GroupBox();
		imagesLabel = new LinkLabel();
		resultsLabel = new LinkLabel();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)buttonStart).set_Location(new Point(12, 353));
		((Control)buttonStart).set_Name("buttonStart");
		((Control)buttonStart).set_Size(new Size(75, 23));
		((Control)buttonStart).set_TabIndex(0);
		((Control)buttonStart).set_Text("START");
		((ButtonBase)buttonStart).set_UseVisualStyleBackColor(true);
		((Control)buttonStart).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(150, 358));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(13, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("0");
		((Control)buttonStop).set_Location(new Point(234, 353));
		((Control)buttonStop).set_Name("buttonStop");
		((Control)buttonStop).set_Size(new Size(75, 23));
		((Control)buttonStop).set_TabIndex(2);
		((Control)buttonStop).set_Text("STOP");
		((ButtonBase)buttonStop).set_UseVisualStyleBackColor(true);
		((Control)buttonStop).add_Click((EventHandler)button2_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)radioButtonNewsSearch);
		((Control)groupBox1).get_Controls().Add((Control)(object)radioButtonImageSearch);
		((Control)groupBox1).get_Controls().Add((Control)(object)radioButtonSiteExplorer);
		((Control)groupBox1).get_Controls().Add((Control)(object)radioButtonWebSearch);
		((Control)groupBox1).set_Location(new Point(12, 273));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(297, 66));
		((Control)groupBox1).set_TabIndex(3);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Search Settings");
		((Control)radioButtonNewsSearch).set_AutoSize(true);
		((Control)radioButtonNewsSearch).set_Location(new Point(148, 42));
		((Control)radioButtonNewsSearch).set_Name("radioButtonNewsSearch");
		((Control)radioButtonNewsSearch).set_Size(new Size(89, 17));
		((Control)radioButtonNewsSearch).set_TabIndex(3);
		((Control)radioButtonNewsSearch).set_Text("News Search");
		((ButtonBase)radioButtonNewsSearch).set_UseVisualStyleBackColor(true);
		radioButtonNewsSearch.add_CheckedChanged((EventHandler)radioButtonNewsSearch_CheckedChanged);
		((Control)radioButtonImageSearch).set_AutoSize(true);
		((Control)radioButtonImageSearch).set_Location(new Point(148, 19));
		((Control)radioButtonImageSearch).set_Name("radioButtonImageSearch");
		((Control)radioButtonImageSearch).set_Size(new Size(91, 17));
		((Control)radioButtonImageSearch).set_TabIndex(2);
		((Control)radioButtonImageSearch).set_Text("Image Search");
		((ButtonBase)radioButtonImageSearch).set_UseVisualStyleBackColor(true);
		radioButtonImageSearch.add_CheckedChanged((EventHandler)radioButton3_CheckedChanged);
		((Control)radioButtonSiteExplorer).set_AutoSize(true);
		((Control)radioButtonSiteExplorer).set_Location(new Point(6, 43));
		((Control)radioButtonSiteExplorer).set_Name("radioButtonSiteExplorer");
		((Control)radioButtonSiteExplorer).set_Size(new Size(138, 17));
		((Control)radioButtonSiteExplorer).set_TabIndex(1);
		((Control)radioButtonSiteExplorer).set_Text("Site Explorer (backlinks)");
		((ButtonBase)radioButtonSiteExplorer).set_UseVisualStyleBackColor(true);
		radioButtonSiteExplorer.add_CheckedChanged((EventHandler)radioButton2_CheckedChanged);
		((Control)radioButtonWebSearch).set_AutoSize(true);
		radioButtonWebSearch.set_Checked(true);
		((Control)radioButtonWebSearch).set_Location(new Point(6, 19));
		((Control)radioButtonWebSearch).set_Name("radioButtonWebSearch");
		((Control)radioButtonWebSearch).set_Size(new Size(85, 17));
		((Control)radioButtonWebSearch).set_TabIndex(0);
		radioButtonWebSearch.set_TabStop(true);
		((Control)radioButtonWebSearch).set_Text("Web Search");
		((ButtonBase)radioButtonWebSearch).set_UseVisualStyleBackColor(true);
		((Control)groupBox2).get_Controls().Add((Control)(object)linkLabel1);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox2).set_Location(new Point(12, 12));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(297, 72));
		((Control)groupBox2).set_TabIndex(4);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("BOSS App ID Settings");
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(102, 47));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(92, 13));
		((Control)linkLabel1).set_TabIndex(1);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("Get BOSS App ID");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)textBox1).set_Location(new Point(6, 19));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(285, 20));
		((Control)textBox1).set_TabIndex(0);
		((Control)groupBox3).get_Controls().Add((Control)(object)checkBoxTitles);
		((Control)groupBox3).get_Controls().Add((Control)(object)checkBoxDelisiousTags);
		((Control)groupBox3).get_Controls().Add((Control)(object)checkBoxRelatedWords);
		((Control)groupBox3).get_Controls().Add((Control)(object)checkBoxLinks);
		((Control)groupBox3).get_Controls().Add((Control)(object)checkBoxSnippets);
		((Control)groupBox3).set_Location(new Point(12, 201));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(297, 66));
		((Control)groupBox3).set_TabIndex(4);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Parser Output Settings");
		((Control)checkBoxTitles).set_AutoSize(true);
		((Control)checkBoxTitles).set_Location(new Point(240, 20));
		((Control)checkBoxTitles).set_Name("checkBoxTitles");
		((Control)checkBoxTitles).set_Size(new Size(51, 17));
		((Control)checkBoxTitles).set_TabIndex(4);
		((Control)checkBoxTitles).set_Text("Titles");
		((ButtonBase)checkBoxTitles).set_UseVisualStyleBackColor(true);
		((Control)checkBoxDelisiousTags).set_AutoSize(true);
		((Control)checkBoxDelisiousTags).set_Location(new Point(79, 43));
		((Control)checkBoxDelisiousTags).set_Name("checkBoxDelisiousTags");
		((Control)checkBoxDelisiousTags).set_Size(new Size(108, 17));
		((Control)checkBoxDelisiousTags).set_TabIndex(3);
		((Control)checkBoxDelisiousTags).set_Text("delicious top tags");
		((ButtonBase)checkBoxDelisiousTags).set_UseVisualStyleBackColor(true);
		((Control)checkBoxRelatedWords).set_AutoSize(true);
		((Control)checkBoxRelatedWords).set_Location(new Point(79, 20));
		((Control)checkBoxRelatedWords).set_Name("checkBoxRelatedWords");
		((Control)checkBoxRelatedWords).set_Size(new Size(155, 17));
		((Control)checkBoxRelatedWords).set_TabIndex(2);
		((Control)checkBoxRelatedWords).set_Text("Related words and phrases");
		((ButtonBase)checkBoxRelatedWords).set_UseVisualStyleBackColor(true);
		((Control)checkBoxLinks).set_AutoSize(true);
		checkBoxLinks.set_Checked(true);
		checkBoxLinks.set_CheckState((CheckState)1);
		((Control)checkBoxLinks).set_Enabled(false);
		((Control)checkBoxLinks).set_Location(new Point(6, 20));
		((Control)checkBoxLinks).set_Name("checkBoxLinks");
		((Control)checkBoxLinks).set_Size(new Size(51, 17));
		((Control)checkBoxLinks).set_TabIndex(1);
		((Control)checkBoxLinks).set_Text("Links");
		((ButtonBase)checkBoxLinks).set_UseVisualStyleBackColor(true);
		((Control)checkBoxSnippets).set_AutoSize(true);
		((Control)checkBoxSnippets).set_Location(new Point(6, 43));
		((Control)checkBoxSnippets).set_Name("checkBoxSnippets");
		((Control)checkBoxSnippets).set_Size(new Size(67, 17));
		((Control)checkBoxSnippets).set_TabIndex(0);
		((Control)checkBoxSnippets).set_Text("Snippets");
		((ButtonBase)checkBoxSnippets).set_UseVisualStyleBackColor(true);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		statusStrip1.set_LayoutStyle((ToolStripLayoutStyle)3);
		((Control)statusStrip1).set_Location(new Point(0, 398));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(320, 5));
		statusStrip1.set_SizingGrip(false);
		((Control)statusStrip1).set_TabIndex(5);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(0, 0));
		((Control)groupBox4).get_Controls().Add((Control)(object)checkBoxTLDRotation);
		((Control)groupBox4).get_Controls().Add((Control)(object)comboBox1);
		((Control)groupBox4).get_Controls().Add((Control)(object)tldLabelRu);
		((Control)groupBox4).get_Controls().Add((Control)(object)queryLabel);
		((Control)groupBox4).set_Location(new Point(12, 93));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(171, 102));
		((Control)groupBox4).set_TabIndex(5);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Parser Search Settings");
		((Control)checkBoxTLDRotation).set_AutoSize(true);
		((Control)checkBoxTLDRotation).set_Location(new Point(13, 79));
		((Control)checkBoxTLDRotation).set_Name("checkBoxTLDRotation");
		((Control)checkBoxTLDRotation).set_Size(new Size(133, 17));
		((Control)checkBoxTLDRotation).set_TabIndex(6);
		((Control)checkBoxTLDRotation).set_Text("Disable TLDs Rotation");
		((ButtonBase)checkBoxTLDRotation).set_UseVisualStyleBackColor(true);
		comboBox1.set_DropDownStyle((ComboBoxStyle)2);
		comboBox1.get_Items().AddRange(new object[1] { "Select TLDs here" });
		((Control)comboBox1).set_Location(new Point(13, 51));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(136, 21));
		((Control)comboBox1).set_TabIndex(5);
		((Control)comboBox1).add_Click((EventHandler)comboBox1_Click);
		((Control)tldLabelRu).set_AutoSize(true);
		((Control)tldLabelRu).set_Location(new Point(10, 35));
		((Control)tldLabelRu).set_Name("tldLabelRu");
		((Control)tldLabelRu).set_Size(new Size(73, 13));
		((Control)tldLabelRu).set_TabIndex(1);
		((Label)tldLabelRu).set_TabStop(true);
		((Control)tldLabelRu).set_Text("Edit TLDs File");
		tldLabelRu.add_LinkClicked(new LinkLabelLinkClickedEventHandler(tldLabel_LinkClicked));
		((Control)queryLabel).set_AutoSize(true);
		((Control)queryLabel).set_Location(new Point(10, 16));
		((Control)queryLabel).set_Name("queryLabel");
		((Control)queryLabel).set_Size(new Size(85, 13));
		((Control)queryLabel).set_TabIndex(0);
		((Label)queryLabel).set_TabStop(true);
		((Control)queryLabel).set_Text("Edit QUERY File");
		queryLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(queryLabel_LinkClicked));
		((Control)groupBox5).get_Controls().Add((Control)(object)imagesLabel);
		((Control)groupBox5).get_Controls().Add((Control)(object)resultsLabel);
		((Control)groupBox5).set_Location(new Point(189, 93));
		((Control)groupBox5).set_Name("groupBox5");
		((Control)groupBox5).set_Size(new Size(119, 102));
		((Control)groupBox5).set_TabIndex(6);
		groupBox5.set_TabStop(false);
		((Control)groupBox5).set_Text("View Results");
		((Control)imagesLabel).set_AutoSize(true);
		((Control)imagesLabel).set_Location(new Point(6, 46));
		((Control)imagesLabel).set_Name("imagesLabel");
		((Control)imagesLabel).set_Size(new Size(111, 13));
		((Control)imagesLabel).set_TabIndex(3);
		((Label)imagesLabel).set_TabStop(true);
		((Control)imagesLabel).set_Text("Images Results Folder");
		imagesLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(imagesLabel_LinkClicked));
		((Control)resultsLabel).set_AutoSize(true);
		((Control)resultsLabel).set_Location(new Point(6, 16));
		((Control)resultsLabel).set_Name("resultsLabel");
		((Control)resultsLabel).set_Size(new Size(111, 13));
		((Control)resultsLabel).set_TabIndex(2);
		((Label)resultsLabel).set_TabStop(true);
		((Control)resultsLabel).set_Text("Search Results Folder");
		resultsLabel.add_LinkClicked(new LinkLabelLinkClickedEventHandler(resultsLabel_LinkClicked));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(320, 403));
		((Control)this).get_Controls().Add((Control)(object)groupBox5);
		((Control)this).get_Controls().Add((Control)(object)groupBox4);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)buttonStop);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)buttonStart);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Yahoo BOSS Parser by neru");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox4).PerformLayout();
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox5).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)comboBox1).get_Text().Contains("tld"))
		{
			MessageBox.Show("Select TLDs", "Info");
			((Control)comboBox1).Focus();
			return;
		}
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("BOSS App Field is empty. Insert App ID key.");
			Application.Exit();
		}
		((Control)buttonStart).set_Enabled(false);
		((Control)buttonStop).set_Enabled(true);
		stop = false;
		if (d != null && d.IsAlive)
		{
			d.Resume();
			return;
		}
		d = new Thread(work);
		d.Start();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		MethodInvoker val = null;
		if (!((Control)this).get_InvokeRequired())
		{
			((Control)buttonStart).set_Enabled(true);
			((Control)buttonStop).set_Enabled(false);
			stop = true;
			if (d != null)
			{
				d.Suspend();
			}
			return;
		}
		if (val == null)
		{
			val = (MethodInvoker)delegate
			{
				((Control)buttonStart).set_Enabled(true);
				((Control)buttonStop).set_Enabled(false);
				stop = true;
			};
		}
		((Control)this).BeginInvoke((Delegate)(object)val);
	}

	private void work()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		Application.DoEvents();
		if (stop)
		{
			return;
		}
		MethodInvoker val = null;
		ArrayList arrayList = new ArrayList();
		ArrayList t = new ArrayList();
		string[] array = File.ReadAllLines(Environment.CurrentDirectory + "\\params\\query.txt", Encoding.Default);
		foreach (string value in array)
		{
			arrayList.Add(value);
		}
		if (((Control)comboBox1).get_InvokeRequired())
		{
			ComboBox obj = comboBox1;
			if (val == null)
			{
				val = (MethodInvoker)delegate
				{
					string[] array2 = File.ReadAllLines(Environment.CurrentDirectory + "\\params\\" + comboBox1.get_SelectedItem(), Encoding.Default);
					foreach (string value2 in array2)
					{
						t.Add(value2);
					}
				};
			}
			((Control)obj).BeginInvoke((Delegate)(object)val);
			Thread.Sleep(1000);
		}
		foreach (string item in arrayList)
		{
			foreach (string item2 in t)
			{
				Application.DoEvents();
				XmlDocument xmlDocument = new XmlDocument();
				string text3 = ((Control)textBox1).get_Text().Trim();
				string text4 = item;
				text4 = text4.Replace("http://", "");
				text4 = text4.Replace("https://", "");
				text4 = text4.Replace("https://www.", "");
				text4 = text4.Replace("http://www.", "");
				text4 = HttpUtility.UrlEncode(text4, Encoding.UTF8);
				string text5 = HttpUtility.UrlDecode(text4, Encoding.UTF8);
				text5 = text4;
				string text6 = "keyterms";
				string text7 = item2;
				if (checkBoxTLDRotation.get_Checked())
				{
					text7 = "";
				}
				string text8 = "";
				UpdateStatusStrip("Query: " + text5 + " sites:" + text7);
				if (radioButtonNewsSearch.get_Checked())
				{
					text8 = "http://boss.yahooapis.com/ysearch/news/v1/" + text4 + "?appid=" + text3 + "&format=xml&count=50&style=raw&abstract=long&sites=" + text7 + "&view=language&orderby=date";
				}
				if (radioButtonWebSearch.get_Checked())
				{
					text8 = "http://boss.yahooapis.com/ysearch/web/v1/" + text4 + "?appid=" + text3 + "&format=xml&count=50&style=raw&abstract=long&sites=" + text7 + "&view=" + text6 + ",delicious_toptags";
				}
				if (radioButtonSiteExplorer.get_Checked())
				{
					text8 = "http://boss.yahooapis.com/ysearch/se_inlink/v1/" + text4 + "?appid=" + text3 + "&format=xml&count=50&style=raw&abstract=long&sites=" + text7 + "&omit_inlinks=domain";
				}
				if (radioButtonImageSearch.get_Checked())
				{
					text8 = "http://boss.yahooapis.com/ysearch/images/v1/" + text4 + "?appid=" + text3 + "&format=xml&count=50&sites=" + text7;
				}
				while (text8.Contains(text3))
				{
					Application.DoEvents();
					try
					{
						XmlTextReader xmlTextReader = new XmlTextReader(text8);
						XmlUrlResolver xmlUrlResolver = new XmlUrlResolver();
						xmlUrlResolver.Credentials = CredentialCache.DefaultCredentials;
						xmlTextReader.XmlResolver = xmlUrlResolver;
						xmlDocument.Load(xmlTextReader);
					}
					catch (Exception ex)
					{
						SaveToFile(Environment.CurrentDirectory + "/debug.txt", ex.Message + "\r\n");
						continue;
					}
					XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("url");
					XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("nextpage");
					XmlNodeList elementsByTagName3 = xmlDocument.GetElementsByTagName("prevpage");
					XmlNodeList elementsByTagName4 = xmlDocument.GetElementsByTagName("abstract");
					XmlNodeList elementsByTagName5 = xmlDocument.GetElementsByTagName("term");
					XmlNodeList elementsByTagName6 = xmlDocument.GetElementsByTagName("url");
					XmlNodeList elementsByTagName7 = xmlDocument.GetElementsByTagName("name");
					XmlNodeList elementsByTagName8 = xmlDocument.GetElementsByTagName("resultset_web");
					XmlNodeList elementsByTagName9 = xmlDocument.GetElementsByTagName("resultset_se_inlink");
					XmlNodeList elementsByTagName10 = xmlDocument.GetElementsByTagName("title");
					string text9 = Regex.Replace(text5, "[^.0-1a-zA-Z_]", "");
					if (checkBoxLinks.get_Checked() && !radioButtonImageSearch.get_Checked() && !radioButtonNewsSearch.get_Checked())
					{
						foreach (XmlNode item3 in elementsByTagName)
						{
							SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " link base.txt", item3.InnerText + "\r\n");
							UpdateLabel();
						}
					}
					if (checkBoxLinks.get_Checked() && radioButtonNewsSearch.get_Checked())
					{
						foreach (XmlNode item4 in elementsByTagName)
						{
							SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " news link base.txt", item4.InnerText + "\r\n");
							UpdateLabel();
						}
					}
					if (checkBoxLinks.get_Checked() && radioButtonImageSearch.get_Checked())
					{
						string text10 = Environment.CurrentDirectory + "\\images\\";
						string text11 = text10 + text9 + "\\";
						Directory.CreateDirectory(text11.Replace("+", "_"));
						foreach (XmlNode item5 in elementsByTagName6)
						{
							SaveToFile(Environment.CurrentDirectory + "\\results\\" + text9 + " images link base.txt", item5.InnerText + "\r\n");
							try
							{
								FetchAndStoreImage2(text11.Replace("+", "_") + text9.Replace("+", "_") + "_" + Environment.TickCount + ".jpg", item5.InnerText);
							}
							catch (Exception ex2)
							{
								SaveToFile(Environment.CurrentDirectory + "/debug.txt", ex2.ToString() + "\r\n\r\n");
								continue;
							}
							UpdateLabel();
						}
					}
					if (checkBoxSnippets.get_Checked())
					{
						foreach (XmlNode item6 in elementsByTagName4)
						{
							if (item6.InnerText != "")
							{
								item6.InnerText.Trim();
								if (radioButtonNewsSearch.get_Checked())
								{
									SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " news snippets.txt", item6.InnerText.Replace("...", "") + "\r\n");
								}
								else
								{
									SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " snippets.txt", item6.InnerText.Replace("...", "") + "\r\n");
								}
							}
						}
					}
					if (checkBoxRelatedWords.get_Checked())
					{
						foreach (XmlNode item7 in elementsByTagName5)
						{
							SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " keyterms.txt", item7.InnerText + "\r\n");
						}
					}
					if (checkBoxTitles.get_Checked())
					{
						foreach (XmlNode item8 in elementsByTagName10)
						{
							SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " titles.txt", item8.InnerText + "\r\n");
						}
					}
					if (checkBoxDelisiousTags.get_Checked())
					{
						foreach (XmlNode item9 in elementsByTagName7)
						{
							SaveToFile(Environment.CurrentDirectory + "/results/" + text9 + " delicious toptags.txt", item9.InnerText + ",");
						}
					}
					if (radioButtonWebSearch.get_Checked())
					{
						XmlNode xmlNode8 = elementsByTagName8.Item(0);
						if (xmlNode8 == null || xmlNode8.Attributes!["count"]!.InnerText == "0")
						{
							break;
						}
					}
					if (radioButtonSiteExplorer.get_Checked())
					{
						XmlNode xmlNode9 = elementsByTagName9.Item(0);
						if (xmlNode9 == null || xmlNode9.Attributes!["count"]!.InnerText == "0")
						{
							break;
						}
					}
					if (elementsByTagName2.Count == 0 || (elementsByTagName3.Count > 0 && elementsByTagName3[0]!.InnerText.Contains("start=900")))
					{
						break;
					}
					text8 = "http://boss.yahooapis.com" + elementsByTagName2[0]!.InnerText;
				}
				if (checkBoxTLDRotation.get_Checked())
				{
					break;
				}
			}
		}
		UpdateStatusStrip("All done");
		if (!((Control)this).get_InvokeRequired())
		{
			button2_Click(null, null);
		}
		else
		{
			button2_Click(null, null);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel1.set_LinkVisited(true);
		Process.Start("http://developer.yahoo.com/search/boss/");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(Settings.Default.BOSSID);
		((Control)buttonStop).set_Enabled(false);
		((ListControl)comboBox1).set_SelectedIndex(0);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Settings.Default.BOSSID = ((Control)textBox1).get_Text();
		((SettingsBase)Settings.Default).Save();
		Application.Exit();
	}

	private void SaveToFile(string path, string data)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		path = path.Replace("\"", "");
		HttpUtility.UrlEncode(path, Encoding.ASCII);
		try
		{
			File.AppendAllText(path, data);
		}
		catch (PathTooLongException)
		{
			MessageBox.Show("Query string is too long", "Info");
			Application.Exit();
		}
	}

	private void radioButton3_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButtonImageSearch.get_Checked())
		{
			checkBoxLinks.set_Checked(true);
			((Control)checkBoxSnippets).set_Enabled(false);
			((Control)checkBoxRelatedWords).set_Enabled(false);
			((Control)checkBoxDelisiousTags).set_Enabled(false);
			((Control)checkBoxTitles).set_Enabled(false);
		}
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButtonSiteExplorer.get_Checked())
		{
			checkBoxLinks.set_Checked(true);
			((Control)checkBoxSnippets).set_Enabled(false);
			((Control)checkBoxRelatedWords).set_Enabled(false);
			((Control)checkBoxDelisiousTags).set_Enabled(false);
			((Control)checkBoxTitles).set_Enabled(false);
		}
	}

	public Image FetchAndStoreImage(string sUrl)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(sUrl);
		httpWebRequest.KeepAlive = false;
		httpWebRequest.Timeout = 10000;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		Image result = Image.FromStream(responseStream);
		responseStream.Close();
		return result;
	}

	public void FetchAndStoreImage2(string path, string sUrl)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(sUrl);
		httpWebRequest.KeepAlive = false;
		httpWebRequest.Timeout = 10000;
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		Image val = Image.FromStream(responseStream);
		val.Save(path, ImageFormat.get_Jpeg());
		responseStream.Close();
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		Environment.Exit(0);
	}

	private void UpdateLabel()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		MethodInvoker val = null;
		if (!((Control)label1).get_InvokeRequired())
		{
			return;
		}
		Label obj = label1;
		if (val == null)
		{
			val = (MethodInvoker)delegate
			{
				((Control)label1).set_Text(Convert.ToString(++res_temp));
			};
		}
		((Control)obj).BeginInvoke((Delegate)(object)val);
	}

	private void UpdateStatusStrip(string status)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		MethodInvoker val = null;
		MethodInvoker val2 = null;
		if (!((Control)statusStrip1).get_InvokeRequired())
		{
			return;
		}
		StatusStrip obj = statusStrip1;
		if (val == null)
		{
			val = (MethodInvoker)delegate
			{
				((ToolStripItem)toolStripStatusLabel1).set_Text(status);
			};
		}
		((Control)obj).BeginInvoke((Delegate)(object)val);
		StatusStrip obj2 = statusStrip1;
		if (val2 == null)
		{
			val2 = (MethodInvoker)delegate
			{
				((Control)statusStrip1).Update();
			};
		}
		((Control)obj2).BeginInvoke((Delegate)(object)val2);
	}

	private void queryLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("notepad.exe", Environment.CurrentDirectory + "\\params\\query.txt");
	}

	private void tldLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		if (comboBox1.get_SelectedItem() != null)
		{
			Process.Start("notepad.exe", Environment.CurrentDirectory + "\\params\\" + comboBox1.get_SelectedItem());
		}
	}

	private void resultsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(Environment.CurrentDirectory + "\\results\\");
	}

	private void imagesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(Environment.CurrentDirectory + "\\images\\");
	}

	private void radioButtonNewsSearch_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButtonNewsSearch.get_Checked())
		{
			checkBoxLinks.set_Checked(true);
			checkBoxSnippets.set_Checked(true);
			((Control)checkBoxSnippets).set_Enabled(false);
			((Control)checkBoxRelatedWords).set_Enabled(false);
			((Control)checkBoxDelisiousTags).set_Enabled(false);
			((Control)checkBoxTitles).set_Enabled(false);
		}
	}

	private void linkLabelRu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("notepad.exe", Environment.CurrentDirectory + "\\params\\tldRu.txt");
	}

	private void comboBox1_Click(object sender, EventArgs e)
	{
		comboBox1.get_Items().Clear();
		string text = Environment.CurrentDirectory + "\\params\\";
		string[] files = Directory.GetFiles(text, "tld*");
		string[] array = files;
		foreach (string text2 in array)
		{
			string text3 = text2.Replace(text, "");
			comboBox1.get_Items().Add((object)text3);
		}
	}
}
