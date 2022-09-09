using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace Google.SQLiteWrapper;

public class SQLiteBase
{
	public enum SQLiteDataTypes
	{
		INT = 1,
		FLOAT,
		TEXT,
		BLOB,
		NULL
	}

	private const int argodjutbynj = 0;

	private const int argodjutbynjshtjtfivlctv = 100;

	private const int argodjutbynjshtj = 101;

	private IntPtr lauxizzgrti;

	[DllImport("kernel32")]
	private static extern IntPtr pydmwohwsovbfzw(IntPtr otypdfabumbbazo, uint flags, uint bytes);

	[DllImport("kernel32")]
	private static extern IntPtr pydmwohwsov();

	[DllImport("kernel32")]
	private static extern int lgpstramndzumslzwjrd(IntPtr xlbajfectkynafukpyk);

	[DllImport("sqlite3")]
	private static extern int lgpstramndzumslzw(IntPtr xlbajfectkyna, ref IntPtr lauxizzgrti);

	[DllImport("sqlite3")]
	private static extern int lgpstramnd(IntPtr lauxizzgrti);

	[DllImport("sqlite3")]
	private static extern int lgpstramndzumslz(IntPtr lauxizzgrti, IntPtr tomzmznssajvmzdf, IntPtr callback, IntPtr arguments, ref IntPtr tomzmznssajvmzdfdxkhrvehfkgabymp);

	[DllImport("sqlite3")]
	private static extern IntPtr vwucwrfnnar(IntPtr lauxizzgrti);

	[DllImport("sqlite3")]
	private static extern int vwucwrfnnargmarzshciis(IntPtr lauxizzgrti, IntPtr tomzmznssajvmzdf, int zremmakgnkfavavoeegh, ref IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, ref IntPtr tail);

	[DllImport("sqlite3")]
	private static extern int rjghtuxbjnswvvegap(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);

	[DllImport("sqlite3")]
	private static extern int rjghtuxbjnswv(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);

	[DllImport("sqlite3")]
	private static extern IntPtr abltwtccjl(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int abltwtccjlmlv(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int jurdetgdiihwvm(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern double jurdetgdiihwv(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr eediwvwrfzirdhbputu(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr eediwvwrfzirdhbputui(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr nyhuevdreudedp(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int nyhuevdreuded(IntPtr zkgholaugpdrwxcmll);

	public SQLiteBase()
	{
		lauxizzgrti = IntPtr.Zero;
	}

	public SQLiteBase(string gdksvleufmxdwg)
	{
		OpenDatabase(gdksvleufmxdwg);
	}

	public void OpenDatabase(string gdksvleufmxdwg)
	{
		if (lgpstramndzumslzw(creukzfgwctylb(gdksvleufmxdwg), ref lauxizzgrti) != 0)
		{
			lauxizzgrti = IntPtr.Zero;
			throw new Exception("Error with opening lauxizzgrti " + gdksvleufmxdwg + "!");
		}
	}

	public void CloseDatabase()
	{
		if (lauxizzgrti != IntPtr.Zero)
		{
			lgpstramnd(lauxizzgrti);
		}
	}

	public ArrayList jguwwxyfahez()
	{
		string tomzmznssajvmzdf = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
		DataTable dataTable = jguwwxyfahezlktwvwpismyp(tomzmznssajvmzdf);
		ArrayList arrayList = new ArrayList();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				arrayList.Add(dataRow.ItemArray[0]!.ToString());
			}
			return arrayList;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void ExecuteNonQuery(string tomzmznssajvmzdf)
	{
		IntPtr tomzmznssajvmzdfdxkhrvehfkgabymp = default(IntPtr);
		lgpstramndzumslz(lauxizzgrti, creukzfgwctylb(tomzmznssajvmzdf), IntPtr.Zero, IntPtr.Zero, ref tomzmznssajvmzdfdxkhrvehfkgabymp);
		if (tomzmznssajvmzdfdxkhrvehfkgabymp != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + tomzmznssajvmzdf + "\"!\n" + vllpuemchutvyftvmToString(vwucwrfnnar(tomzmznssajvmzdfdxkhrvehfkgabymp)));
		}
	}

	public DataTable jguwwxyfahezlktwvwpismyp(string tomzmznssajvmzdf)
	{
		IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn = default(IntPtr);
		IntPtr tail = default(IntPtr);
		vwucwrfnnargmarzshciis(lauxizzgrti, creukzfgwctylb(tomzmznssajvmzdf), xbrwewxuyrvou(creukzfgwctylb(tomzmznssajvmzdf)), ref tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, ref tail);
		DataTable tomzmznssajvmzd = new DataTable();
		for (int num = jguwwxyfahezlktw(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, ref tomzmznssajvmzd); num == 100; num = jguwwxyfahezlk(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, ref tomzmznssajvmzd))
		{
		}
		nyhuevdreuded(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);
		return tomzmznssajvmzd;
	}

	private int jguwwxyfahezlktw(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, ref DataTable tomzmznssajvmzd)
	{
		tomzmznssajvmzd = new DataTable("resultTable");
		int num = rjghtuxbjnswvvegap(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);
		checked
		{
			if (num == 100)
			{
				int num2 = rjghtuxbjnswv(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);
				string text = "";
				int num3 = 0;
				object[] array = new object[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
				{
					text = vllpuemchutvyftvmToString(abltwtccjl(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i));
					switch (abltwtccjlmlv(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i))
					{
					default:
						tomzmznssajvmzd.Columns.Add(text, Type.GetType("System.String"));
						array[i] = "";
						break;
					case 1:
						tomzmznssajvmzd.Columns.Add(text, Type.GetType("System.Int32"));
						array[i] = jurdetgdiihwvm(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i);
						break;
					case 2:
						tomzmznssajvmzd.Columns.Add(text, Type.GetType("System.Single"));
						array[i] = jurdetgdiihwv(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i);
						break;
					case 3:
						tomzmznssajvmzd.Columns.Add(text, Type.GetType("System.String"));
						array[i] = vllpuemchutvyftvmToString(eediwvwrfzirdhbputu(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i));
						break;
					case 4:
						tomzmznssajvmzd.Columns.Add(text, Type.GetType("System.String"));
						array[i] = vllpuemchutvyftvmToString(eediwvwrfzirdhbputui(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i));
						break;
					}
				}
				tomzmznssajvmzd.Rows.Add(array);
			}
			return rjghtuxbjnswvvegap(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);
		}
	}

	private int jguwwxyfahezlk(IntPtr tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, ref DataTable tomzmznssajvmzd)
	{
		int num = rjghtuxbjnswv(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);
		int num2 = 0;
		checked
		{
			object[] array = new object[num - 1 + 1];
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				switch (abltwtccjlmlv(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i))
				{
				default:
					array[i] = "";
					break;
				case 1:
					array[i] = jurdetgdiihwvm(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i);
					break;
				case 2:
					array[i] = jurdetgdiihwv(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i);
					break;
				case 3:
					array[i] = vllpuemchutvyftvmToString(eediwvwrfzirdhbputu(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i));
					break;
				case 4:
					array[i] = vllpuemchutvyftvmToString(eediwvwrfzirdhbputui(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn, i));
					break;
				}
			}
			tomzmznssajvmzd.Rows.Add(array);
			return rjghtuxbjnswvvegap(tomzmznssajvmzdfdxkhrvehfkgabympsbevhmownbhmufmn);
		}
	}

	private IntPtr creukzfgwctylb(string xlbajfectkynafukpyk)
	{
		if (xlbajfectkynafukpyk == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(xlbajfectkynafukpyk);
		uint bytes2 = checked((uint)(bytes.Length + 1));
		IntPtr intPtr = pydmwohwsovbfzw(pydmwohwsov(), 0u, bytes2);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}

	private string vllpuemchutvyftvmToString(IntPtr kfchvnbibxuih)
	{
		if (kfchvnbibxuih == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = xbrwewxuyrvou(kfchvnbibxuih);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(kfchvnbibxuih, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private int xbrwewxuyrvou(IntPtr kfchvnbibxuih)
	{
		if (kfchvnbibxuih == IntPtr.Zero)
		{
			return 0;
		}
		return lgpstramndzumslzwjrd(kfchvnbibxuih);
	}
}
