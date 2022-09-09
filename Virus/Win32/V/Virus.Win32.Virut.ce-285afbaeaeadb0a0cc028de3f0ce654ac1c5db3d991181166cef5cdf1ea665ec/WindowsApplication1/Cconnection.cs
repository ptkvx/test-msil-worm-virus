using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

public class Cconnection
{
	private FileInfo objfileInfo;

	private bool IsExisting;

	private long fileSize;

	private string filePath;

	private string filename;

	private string m_datasource;

	private long m_SQLport;

	public bool Constatus;

	private SqlConnection SQLconn;

	private string ConStr;

	private SqlCommand Sqlcmd;

	private SqlDataReader sqlreader;

	private CconnectionConfig objconn;

	private StreamReader objStreamreader;

	public object ConnectionStatus
	{
		get
		{
			return Constatus;
		}
		set
		{
			Constatus = Conversions.ToBoolean(value);
		}
	}

	public object conDataSource
	{
		get
		{
			return m_datasource;
		}
		set
		{
			m_datasource = Conversions.ToString(value);
		}
	}

	public object conString
	{
		get
		{
			return RuntimeHelpers.GetObjectValue(objconn.ConnectionString);
		}
		set
		{
		}
	}

	[DebuggerNonUserCode]
	public Cconnection()
	{
	}

	public void initialise()
	{
		filePath = "C:\\";
		fileSize = 0L;
		IsExisting = false;
		filename = filePath + "ConnectionConfig.txt";
		IsExisting = File.Exists(filename);
		if (!IsExisting)
		{
			Constatus = false;
			return;
		}
		objconn = new CconnectionConfig();
		objconn.initialise();
		objconn.Testconnection();
		Constatus = Conversions.ToBoolean(objconn.nConnectionStatus);
		if (Constatus)
		{
			if (Startup.dBcon.get_State() == ConnectionState.Open)
			{
				Startup.dBcon.Close();
				Startup.dBcon.set_ConnectionString(Conversions.ToString(objconn.ConnectionString));
				Startup.dBcon.Open();
			}
			else
			{
				Startup.dBcon.set_ConnectionString(Conversions.ToString(objconn.ConnectionString));
				Startup.dBcon.Open();
			}
		}
	}
}
