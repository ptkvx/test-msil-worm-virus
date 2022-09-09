using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns2;

internal sealed class Class11
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static string smethod_0()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		string text5 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		int num6 = default(int);
		int num7 = default(int);
		string text8 = default(string);
		int num8 = default(int);
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
				case 1211:
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
							goto IL_000d;
						case 4:
							goto IL_0013;
						case 5:
							goto IL_0019;
						case 6:
							goto IL_001f;
						case 7:
							goto IL_002d;
						case 8:
							goto IL_0045;
						case 9:
						case 10:
							goto IL_0054;
						case 11:
							goto IL_0065;
						case 12:
							goto IL_0082;
						case 15:
							goto IL_0095;
						case 16:
							goto IL_009c;
						case 17:
							goto IL_00a8;
						case 18:
							goto IL_00c3;
						case 19:
						case 20:
							goto IL_00d2;
						case 13:
						case 14:
						case 23:
						case 24:
							goto IL_00ef;
						case 21:
							goto IL_00fd;
						case 22:
						case 25:
							goto IL_010c;
						case 26:
							goto IL_0124;
						case 27:
							goto IL_0135;
						case 28:
							goto IL_016a;
						case 29:
							goto IL_0177;
						case 30:
							goto IL_0188;
						case 31:
							goto IL_01c1;
						case 32:
							goto IL_01cb;
						case 33:
							goto IL_01d8;
						case 34:
							goto IL_01e3;
						case 35:
							goto IL_01fd;
						case 36:
							goto IL_021a;
						case 37:
							goto IL_0234;
						case 38:
							goto IL_0258;
						case 39:
							goto IL_0272;
						case 40:
							goto IL_0296;
						case 41:
							goto IL_02b0;
						case 42:
							goto IL_02cd;
						case 43:
							goto IL_02e7;
						case 44:
							goto IL_0311;
						case 45:
							goto IL_032b;
						case 46:
							goto IL_0348;
						case 47:
							goto IL_0362;
						case 48:
							goto IL_037f;
						case 49:
							goto IL_0399;
						case 50:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 51:
						case 52:
						case 53:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_016a:
					num = 28;
					num5 = checked(num5 + 2);
					goto IL_0172;
					IL_0008:
					num = 2;
					text = null;
					goto IL_000d;
					IL_000d:
					num = 3;
					text2 = null;
					goto IL_0013;
					IL_0013:
					num = 4;
					text3 = null;
					goto IL_0019;
					IL_0019:
					num = 5;
					text4 = null;
					goto IL_001f;
					IL_001f:
					num = 6;
					text5 = Interaction.Environ("ALLUSERSPROFILE");
					goto IL_002d;
					IL_002d:
					num = 7;
					if (Operators.CompareString(Strings.Right(text5, 1), "\\", false) != 0)
					{
						goto IL_0045;
					}
					goto IL_0054;
					IL_0045:
					num = 8;
					text5 += "\\";
					goto IL_0054;
					IL_0054:
					num = 10;
					text6 = text5 + "DynDNS\\Updater\\config.dyndns";
					goto IL_0065;
					IL_0065:
					num = 11;
					if (Operators.CompareString(FileSystem.Dir(text6, (FileAttribute)0), "", false) == 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_0082;
					IL_0082:
					num = 12;
					FileSystem.FileOpen(1, text6, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_00ef;
					IL_00ef:
					num = 14;
					if (!FileSystem.EOF(1))
					{
						goto IL_0095;
					}
					goto IL_010c;
					IL_0095:
					num = 15;
					text7 = null;
					goto IL_009c;
					IL_009c:
					num = 16;
					text7 = FileSystem.LineInput(1);
					goto IL_00a8;
					IL_00a8:
					num = 17;
					if (Operators.CompareString(Strings.Left(text7, 9), "Username=", false) == 0)
					{
						goto IL_00c3;
					}
					goto IL_00d2;
					IL_00c3:
					num = 18;
					text2 = Strings.Mid(text7, 10);
					goto IL_00d2;
					IL_00d2:
					num = 20;
					if (Operators.CompareString(Strings.Left(text7, 9), "Password=", false) != 0)
					{
						goto IL_00ef;
					}
					goto IL_00fd;
					IL_00fd:
					num = 21;
					text3 = Strings.Mid(text7, 10);
					goto IL_010c;
					IL_010c:
					num = 25;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0124;
					IL_0124:
					num = 26;
					num6 = Strings.Len(text3);
					num5 = 1;
					goto IL_0172;
					IL_0172:
					if (num5 <= num6)
					{
						goto IL_0135;
					}
					goto IL_0177;
					IL_0177:
					num = 29;
					num7 = Strings.Len(text4);
					num5 = 1;
					goto IL_01d3;
					IL_01d3:
					if (num5 <= num7)
					{
						goto IL_0188;
					}
					goto IL_01d8;
					IL_01d8:
					num = 33;
					text8 = "\r\n";
					goto IL_01e3;
					IL_01e3:
					num = 34;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_01fd;
					IL_01fd:
					num = 35;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============DYNDNS==============");
					goto IL_021a;
					IL_021a:
					num = 36;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_0234;
					IL_0234:
					num = 37;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Username: " + text2);
					goto IL_0258;
					IL_0258:
					num = 38;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_0272;
					IL_0272:
					num = 39;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("Password: " + text4);
					goto IL_0296;
					IL_0296:
					num = 40;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_02b0;
					IL_02b0:
					num = 41;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("=============================");
					goto IL_02cd;
					IL_02cd:
					num = 42;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_02e7;
					IL_02e7:
					num = 43;
					if (!((Operators.CompareString(text2, "", false) == 0) | (Operators.CompareString(text4, "", false) == 0)))
					{
						goto end_IL_0000_3;
					}
					goto IL_0311;
					IL_0311:
					num = 44;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_032b;
					IL_032b:
					num = 45;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("============DYNDNS==============");
					goto IL_0348;
					IL_0348:
					num = 46;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_0362;
					IL_0362:
					num = 47;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("DYNDNS Couldn't Be Recovered!");
					goto IL_037f;
					IL_037f:
					num = 48;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
					goto IL_0399;
					IL_0399:
					num = 49;
					((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText("=============================");
					break;
					IL_0188:
					num = 30;
					StringType.MidStmtStr(ref text4, num5, 1, Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(text4, num5, 1)) ^ Strings.Asc(Strings.Mid("t6KzXhCh", checked(num8 + 1), 1)))));
					goto IL_01c1;
					IL_01c1:
					num = 31;
					num8 = checked(num8 + 1) % 8;
					goto IL_01cb;
					IL_01cb:
					num = 32;
					num5 = checked(num5 + 1);
					goto IL_01d3;
					IL_0135:
					num = 27;
					text4 += Conversions.ToString(Strings.Chr(checked((int)Math.Round(Conversion.Val("&H" + Strings.Mid(text3, num5, 2))))));
					goto IL_016a;
					end_IL_0000_2:
					break;
				}
				num = 50;
				((TextBoxBase)Class1.smethod_2().method_0().vmethod_14()).AppendText(text8);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1211;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		string result = text;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
