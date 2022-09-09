using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace Client.SQLiteWrapper;

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

	private const int ojJnHGEnneIErHGEGnnj = 0;

	private const int GIojgJHjfoenrrEEeenn = 100;

	private const int JHIjgIPEIGrGEjGnjPjn = 101;

	private IntPtr database;

	[DllImport("kernel32")]
	private static extern IntPtr jrIJePrEEeJnrEnreerj(IntPtr heap, uint flags, uint bytes);

	[DllImport("kernel32")]
	private static extern IntPtr rJrEjPonJEHnGnJJPPEn();

	[DllImport("kernel32")]
	private static extern int oIRroEHErjGoIJjTGEGn(IntPtr str);

	[DllImport("sqlite3")]
	private static extern int GoTIeJrIeeGPIHPTnGfj(IntPtr fileName, ref IntPtr database);

	[DllImport("sqlite3")]
	private static extern int ofgnPIeJnjrjIrPHgGjP(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int JePneTfnnPnfjoeojjIj(IntPtr database, IntPtr jonGgIGnGnePTRjJnIge, IntPtr callback, IntPtr arguments, ref IntPtr EHHonJPJrHGGGjErnenn);

	[DllImport("sqlite3")]
	private static extern IntPtr jPjeejEHegjennEGoePn(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int reRRRojTjnfPnPnGoerE(IntPtr database, IntPtr jonGgIGnGnePTRjJnIge, int ERgHjJrgEgenjneneJPe, ref IntPtr jEGnEHPngenjEJRJnjJE, ref IntPtr tail);

	[DllImport("sqlite3")]
	private static extern int PEGHInrfoEPnnEjERrEI(IntPtr jEGnEHPngenjEJRJnjJE);

	[DllImport("sqlite3")]
	private static extern int ggrJIrrEJjPnPHgnErnI(IntPtr jEGnEHPngenjEJRJnjJE);

	[DllImport("sqlite3")]
	private static extern IntPtr EnGIRjGeEEGnnGRnnPPE(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int nefgIefnIPnGnePnGErI(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int GReEEnngPPneneEjEREo(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern double EJInEejGJrneeJGEJPPj(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr EenjPnPjnEjgIrenEfHJ(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr ETJPEjHrnEERIEjnIEnj(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr rjeeEnIPegRGnRgjEgnj(IntPtr jEGnEHPngenjEJRJnjJE, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int RGnEgjnEnEEnnnnjnjIn(IntPtr handle);

	public SQLiteBase()
	{
		database = IntPtr.Zero;
	}

	public SQLiteBase(string baseName)
	{
		OpenDatabase(baseName);
	}

	public void OpenDatabase(string baseName)
	{
		if (GoTIeJrIeeGPIHPTnGfj(rjEGjnPnngEIjgJjnene(baseName), ref database) != 0)
		{
			database = IntPtr.Zero;
			throw new Exception("Error with opening database " + baseName + "!");
		}
	}

	public void CloseDatabase()
	{
		if (database != IntPtr.Zero)
		{
			ofgnPIeJnjrjIrPHgGjP(database);
		}
	}

	public ArrayList rEHnnJTHGEnePGPjnrEn()
	{
		string jonGgIGnGnePTRjJnIge = "SELECT name FROM sqlite_master WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'UNION ALL SELECT name FROM sqlite_temp_master WHERE type IN ('table','view') ORDER BY 1";
		DataTable dataTable = GrejPGTEjErEGIerIErI(jonGgIGnGnePTRjJnIge);
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

	public void ExecuteNonQuery(string jonGgIGnGnePTRjJnIge)
	{
		IntPtr EHHonJPJrHGGGjErnenn = default(IntPtr);
		JePneTfnnPnfjoeojjIj(database, rjEGjnPnngEIjgJjnene(jonGgIGnGnePTRjJnIge), IntPtr.Zero, IntPtr.Zero, ref EHHonJPJrHGGGjErnenn);
		if (EHHonJPJrHGGGjErnenn != IntPtr.Zero)
		{
			throw new Exception("Error with executing non-query: \"" + jonGgIGnGnePTRjJnIge + "\"!\n" + jeIHrJRIErnHjInjnETn(jPjeejEHegjennEGoePn(EHHonJPJrHGGGjErnenn)));
		}
	}

	public DataTable GrejPGTEjErEGIerIErI(string jonGgIGnGnePTRjJnIge)
	{
		IntPtr jEGnEHPngenjEJRJnjJE = default(IntPtr);
		IntPtr tail = default(IntPtr);
		reRRRojTjnfPnPnGoerE(database, rjEGjnPnngEIjgJjnene(jonGgIGnGnePTRjJnIge), ETnjEGEEIjEjjjjrEGnG(rjEGjnPnngEIjgJjnene(jonGgIGnGnePTRjJnIge)), ref jEGnEHPngenjEJRJnjJE, ref tail);
		DataTable PjGPGGnJPgERTgGPEEfE = new DataTable();
		for (int num = ejPPffEPHPGEejJHPejj(jEGnEHPngenjEJRJnjJE, ref PjGPGGnJPgERTgGPEEfE); num == 100; num = jJnegjRferHjjEGjIjGe(jEGnEHPngenjEJRJnjJE, ref PjGPGGnJPgERTgGPEEfE))
		{
		}
		RGnEgjnEnEEnnnnjnjIn(jEGnEHPngenjEJRJnjJE);
		return PjGPGGnJPgERTgGPEEfE;
	}

	private int ejPPffEPHPGEejJHPejj(IntPtr jEGnEHPngenjEJRJnjJE, ref DataTable PjGPGGnJPgERTgGPEEfE)
	{
		PjGPGGnJPgERTgGPEEfE = new DataTable("resultTable");
		int num = PEGHInrfoEPnnEjERrEI(jEGnEHPngenjEJRJnjJE);
		checked
		{
			if (num == 100)
			{
				int num2 = ggrJIrrEJjPnPHgnErnI(jEGnEHPngenjEJRJnjJE);
				string text = "";
				int num3 = 0;
				object[] array = new object[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
				{
					text = jeIHrJRIErnHjInjnETn(EnGIRjGeEEGnnGRnnPPE(jEGnEHPngenjEJRJnjJE, i));
					switch (nefgIefnIPnGnePnGErI(jEGnEHPngenjEJRJnjJE, i))
					{
					default:
						PjGPGGnJPgERTgGPEEfE.Columns.Add(text, Type.GetType("System.String"));
						array[i] = "";
						break;
					case 1:
						PjGPGGnJPgERTgGPEEfE.Columns.Add(text, Type.GetType("System.Int32"));
						array[i] = GReEEnngPPneneEjEREo(jEGnEHPngenjEJRJnjJE, i);
						break;
					case 2:
						PjGPGGnJPgERTgGPEEfE.Columns.Add(text, Type.GetType("System.Single"));
						array[i] = EJInEejGJrneeJGEJPPj(jEGnEHPngenjEJRJnjJE, i);
						break;
					case 3:
						PjGPGGnJPgERTgGPEEfE.Columns.Add(text, Type.GetType("System.String"));
						array[i] = jeIHrJRIErnHjInjnETn(EenjPnPjnEjgIrenEfHJ(jEGnEHPngenjEJRJnjJE, i));
						break;
					case 4:
						PjGPGGnJPgERTgGPEEfE.Columns.Add(text, Type.GetType("System.String"));
						array[i] = jeIHrJRIErnHjInjnETn(ETJPEjHrnEERIEjnIEnj(jEGnEHPngenjEJRJnjJE, i));
						break;
					}
				}
				PjGPGGnJPgERTgGPEEfE.Rows.Add(array);
			}
			return PEGHInrfoEPnnEjERrEI(jEGnEHPngenjEJRJnjJE);
		}
	}

	private int jJnegjRferHjjEGjIjGe(IntPtr jEGnEHPngenjEJRJnjJE, ref DataTable PjGPGGnJPgERTgGPEEfE)
	{
		int num = ggrJIrrEJjPnPHgnErnI(jEGnEHPngenjEJRJnjJE);
		int num2 = 0;
		checked
		{
			object[] array = new object[num - 1 + 1];
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				switch (nefgIefnIPnGnePnGErI(jEGnEHPngenjEJRJnjJE, i))
				{
				default:
					array[i] = "";
					break;
				case 1:
					array[i] = GReEEnngPPneneEjEREo(jEGnEHPngenjEJRJnjJE, i);
					break;
				case 2:
					array[i] = EJInEejGJrneeJGEJPPj(jEGnEHPngenjEJRJnjJE, i);
					break;
				case 3:
					array[i] = jeIHrJRIErnHjInjnETn(EenjPnPjnEjgIrenEfHJ(jEGnEHPngenjEJRJnjJE, i));
					break;
				case 4:
					array[i] = jeIHrJRIErnHjInjnETn(ETJPEjHrnEERIEjnIEnj(jEGnEHPngenjEJRJnjJE, i));
					break;
				}
			}
			PjGPGGnJPgERTgGPEEfE.Rows.Add(array);
			return PEGHInrfoEPnnEjERrEI(jEGnEHPngenjEJRJnjJE);
		}
	}

	private IntPtr rjEGjnPnngEIjgJjnene(string str)
	{
		if (str == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(str);
		uint bytes2 = checked((uint)(bytes.Length + 1));
		IntPtr intPtr = jrIJePrEEeJnrEnreerj(rJrEjPonJEHnGnJJPPEn(), 0u, bytes2);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}

	private string jeIHrJRIErnHjInjnETn(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int num = ETnjEGEEIjEjjjjrEGnG(ptr);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(ptr, array, 0, num);
		return uTF.GetString(array, 0, num);
	}

	private int ETnjEGEEIjEjjjjrEGnG(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return 0;
		}
		return oIRroEHErjGoIJjTGEGn(ptr);
	}
}
