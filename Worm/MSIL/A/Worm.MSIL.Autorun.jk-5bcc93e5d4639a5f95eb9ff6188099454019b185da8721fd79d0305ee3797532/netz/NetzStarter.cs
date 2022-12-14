using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace netz;

public class NetzStarter
{
	private static readonly string Name = "Name";

	private static readonly string Culture = "Culture";

	private static readonly string NetzSuffix = "z.dll";

	private static HybridDictionary cache = null;

	private static ResourceManager rm = null;

	private static ArrayList xrRm = null;

	private static bool inResourceResolveFlag = false;

	[STAThread]
	public static int Main(string[] args)
	{
		try
		{
			InitXR();
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += NetzResolveEventHandler;
			return StartApp(args);
		}
		catch (Exception ex)
		{
			string text = " .NET Runtime: ";
			Log(string.Concat("#Error: ", ex.GetType().ToString(), Environment.NewLine, ex.Message, Environment.NewLine, ex.StackTrace, Environment.NewLine, ex.InnerException, Environment.NewLine, "Using", text, Environment.Version.ToString(), Environment.NewLine, "Created with", text, "2.0.50727.3074"));
			return -1;
		}
	}

	private static void InitXR()
	{
		try
		{
			string text = "file:\\";
			string text2 = "-netz.resources";
			string text3 = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
			if (text3.StartsWith(text))
			{
				text3 = text3.Substring(text.Length, text3.Length - text.Length);
			}
			string[] files = Directory.GetFiles(text3, "*" + text2);
			if (files == null || files.Length <= 0)
			{
				return;
			}
			xrRm = new ArrayList();
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = Path.GetFileName(files[i]);
				fileName = fileName.Substring(0, fileName.Length - text2.Length);
				ResourceManager resourceManager = ResourceManager.CreateFileBasedResourceManager(fileName + "-netz", text3, null);
				if (resourceManager != null)
				{
					xrRm.Add(resourceManager);
				}
			}
		}
		catch
		{
		}
	}

	public static int StartApp(string[] args)
	{
		byte[] resource = GetResource("A6C24BF5-3690-4982-887E-11E1B159B249");
		if (resource == null)
		{
			throw new Exception("application data cannot be found");
		}
		Assembly assembly = GetAssembly(resource);
		int result = InvokeApp(assembly, args);
		resource = null;
		return result;
	}

	private static Assembly GetAssembly(byte[] data)
	{
		MemoryStream memoryStream = null;
		Assembly assembly = null;
		try
		{
			memoryStream = UnZip(data);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return Assembly.Load(memoryStream.ToArray());
		}
		finally
		{
			memoryStream?.Close();
			memoryStream = null;
		}
	}

	private static int InvokeApp(Assembly assembly, string[] args)
	{
		MethodInfo entryPoint = assembly.EntryPoint;
		ParameterInfo[] parameters = entryPoint.GetParameters();
		object[] parameters2 = null;
		if (parameters != null && parameters.Length > 0)
		{
			parameters2 = new object[1] { args };
		}
		object obj = entryPoint.Invoke(null, parameters2);
		if (obj == null)
		{
			return 0;
		}
		if (obj is int)
		{
			return (int)obj;
		}
		return 0;
	}

	private static Assembly NetzResolveEventHandler(object sender, ResolveEventArgs args)
	{
		if (inResourceResolveFlag)
		{
			return null;
		}
		return GetAssemblyByName(args.Name);
	}

	private static byte[] GetResource(string id)
	{
		byte[] array = null;
		if (rm == null)
		{
			rm = new ResourceManager("app", Assembly.GetExecutingAssembly());
		}
		try
		{
			inResourceResolveFlag = true;
			string name = MangleDllName(id);
			if (array == null && xrRm != null)
			{
				for (int i = 0; i < xrRm.Count; i++)
				{
					try
					{
						ResourceManager resourceManager = (ResourceManager)xrRm[i];
						if (resourceManager != null)
						{
							array = (byte[])resourceManager.GetObject(name);
						}
					}
					catch
					{
					}
					if (array != null)
					{
						break;
					}
				}
			}
			if (array == null)
			{
				return (byte[])rm.GetObject(name);
			}
			return array;
		}
		finally
		{
			inResourceResolveFlag = false;
		}
	}

	private static string MangleDllName(string dll)
	{
		string text = dll;
		text = text.Replace(" ", "!1");
		text = text.Replace(",", "!2");
		text = text.Replace(".Resources", "!3");
		text = text.Replace(".resources", "!3");
		return text.Replace("Culture", "!4");
	}

	private static MemoryStream UnZip(byte[] data)
	{
		if (data == null)
		{
			return null;
		}
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		InflaterInputStream inflaterInputStream = null;
		try
		{
			memoryStream = new MemoryStream(data);
			memoryStream2 = new MemoryStream();
			inflaterInputStream = new InflaterInputStream(memoryStream);
			byte[] array = new byte[data.Length];
			while (true)
			{
				int num = inflaterInputStream.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				memoryStream2.Write(array, 0, num);
			}
			memoryStream2.Flush();
			memoryStream2.Seek(0L, SeekOrigin.Begin);
			return memoryStream2;
		}
		finally
		{
			memoryStream?.Close();
			inflaterInputStream?.Close();
			memoryStream = null;
			inflaterInputStream = null;
		}
	}

	private static byte[] ResolveDLL(StringDictionary assName)
	{
		string text = null;
		byte[] array = null;
		string text2 = assName[Culture];
		string text3 = assName[Name];
		bool flag = text2?.ToLower().Equals("neutral") ?? true;
		AppDomain currentDomain = AppDomain.CurrentDomain;
		StringCollection stringCollection = new StringCollection();
		text = currentDomain.SetupInformation.ApplicationBase;
		if (!flag)
		{
			text = Path.Combine(text, text2);
		}
		stringCollection.Add(text);
		stringCollection.Add(Path.Combine(text, text3));
		array = ProbeDirs(stringCollection, text3);
		if (array != null)
		{
			return array;
		}
		stringCollection = new StringCollection();
		text = currentDomain.SetupInformation.get_PrivateBinPath();
		if (text != null && text.Trim().Length > 0)
		{
			string[] array2 = text.Split(new char[1] { Path.PathSeparator });
			for (int i = 0; i < array2.Length; i++)
			{
				text = array2[i].Trim(' ', '\t', Path.PathSeparator);
				if (!Path.IsPathRooted(text))
				{
					text = Path.Combine(currentDomain.SetupInformation.ApplicationBase, text);
				}
				if (!flag)
				{
					text = Path.Combine(text, text2);
				}
				stringCollection.Add(text);
				stringCollection.Add(Path.Combine(text, text3));
			}
			return ProbeDirs(stringCollection, text3);
		}
		return null;
	}

	private static byte[] ProbeDirs(StringCollection probePaths, string assName)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < probePaths.Count)
			{
				text = Path.Combine(probePaths[num], assName + NetzSuffix);
				if (File.Exists(text))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return ReadFile(text);
	}

	private static byte[] ReadFile(string file)
	{
		FileStream fileStream = null;
		byte[] array = null;
		try
		{
			fileStream = File.OpenRead(file);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Flush();
			return array;
		}
		finally
		{
			fileStream?.Close();
			fileStream = null;
		}
	}

	private static void Log(string s)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show((IWin32Window)null, s, "Error");
	}

	private static Assembly GetAssemblyByName(string name)
	{
		if (name == null)
		{
			return null;
		}
		if (cache == null)
		{
			cache = new HybridDictionary();
		}
		name = name.Trim();
		string key = name.ToLower();
		if (cache[key] != null)
		{
			return (Assembly)cache[key];
		}
		StringDictionary stringDictionary = ParseAssName(name);
		string text = stringDictionary[Name];
		if (text == null)
		{
			return null;
		}
		byte[] array = null;
		array = GetResource(name);
		if (array == null)
		{
			array = GetResource(name.ToLower());
		}
		if (array == null)
		{
			array = GetResource(text);
		}
		if (array == null)
		{
			array = GetResource(text.ToLower());
		}
		if (array == null)
		{
			array = GetResource(Path.GetFileNameWithoutExtension(text)!.ToLower());
		}
		if (array == null)
		{
			try
			{
				array = ResolveDLL(stringDictionary);
			}
			catch
			{
				array = null;
			}
		}
		if (array == null)
		{
			return null;
		}
		Assembly assembly = GetAssembly(array);
		array = null;
		cache[key] = assembly;
		return assembly;
	}

	private static StringDictionary ParseAssName(string fullAssName)
	{
		StringDictionary stringDictionary = new StringDictionary();
		string[] array = fullAssName.Split(new char[1] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Trim(' ', ',').Split(new char[1] { '=' });
			if (array2.Length < 2)
			{
				stringDictionary.Add(Name, array2[0]);
				continue;
			}
			stringDictionary.Add(array2[0].Trim(' ', '='), array2[1].Trim(' ', '='));
		}
		return stringDictionary;
	}
}
