using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace urDrive.unInstall;

public class frmSysQustion : Form
{
	private IContainer components;

	private Button button1;

	private Label label1;

	private string strMSGTitle = string.Empty;

	private string strMSGContent = string.Empty;

	private bool IsCloseNormal;

	public string MSGTitle
	{
		get
		{
			return strMSGTitle;
		}
		set
		{
			strMSGTitle = value;
		}
	}

	public string MSGContent
	{
		get
		{
			return strMSGContent;
		}
		set
		{
			((Control)label1).set_Text(value);
			strMSGContent = value;
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmSysQustion));
		button1 = new Button();
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)button1).set_AutoSize(true);
		((Control)button1).set_Font(new Font("Arial", 8.25f));
		((Control)button1).set_Location(new Point(208, 79));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(55, 24));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_Location(new Point(12, 19));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(251, 57));
		((Control)label1).set_TabIndex(5);
		((Form)this).set_ClientSize(new Size(290, 115));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("Arial", 8.25f));
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmSysQustion");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmSysInformation_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public frmSysQustion()
	{
		InitializeComponent();
	}

	private void frmSysInformation_Load(object sender, EventArgs e)
	{
	}

	private void frmSysInformation_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!IsCloseNormal)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		IsCloseNormal = true;
		((Form)this).set_DialogResult((DialogResult)6);
	}
}
