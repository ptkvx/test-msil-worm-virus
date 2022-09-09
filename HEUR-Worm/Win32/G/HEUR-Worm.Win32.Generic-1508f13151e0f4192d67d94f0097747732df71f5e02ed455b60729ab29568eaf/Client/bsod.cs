using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Client;

[DesignerGenerated]
public class bsod : Form
{
	private IContainer components;

	public bsod()
	{
		((Form)this).add_Load((EventHandler)bsod_Load);
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
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(bsod));
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		Size clientSize = new Size(1456, 916);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("bsod");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("bsod");
		((Control)this).ResumeLayout(false);
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void bsod_Load(object sender, EventArgs e)
	{
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_WindowState((FormWindowState)2);
	}
}
