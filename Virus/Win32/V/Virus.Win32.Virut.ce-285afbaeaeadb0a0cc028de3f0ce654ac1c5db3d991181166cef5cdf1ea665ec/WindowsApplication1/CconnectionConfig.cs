using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

public class CconnectionConfig
{
	public delegate void NotconfiguredEventHandler();

	public delegate void ConfiguredEventHandler();

	public delegate void InvalidDataSourceEventHandler();

	public delegate void DataValidatedEventHandler(bool blnIsValid);

	private static ArrayList __ENCList = new ArrayList();

	private FileInfo objfileInfo;

	private bool IsExisting;

	private long fileSize;

	private string filePath;

	private string filename;

	private bool ConStatus;

	private bool m_IsNetwork;

	public string m_dataSource;

	private long m_Sqlport;

	private string m_Initcatalog;

	private string m_connectionString;

	private bool connectionstatus;

	private string m_Username;

	private string m_Password;

	private SqlConnection objconnection;

	private string connStr;

	private StreamReader objStreamreader;

	public StreamReader objStreamStatus;

	private StreamWriter objStreamwriter;

	private NotconfiguredEventHandler NotconfiguredEvent;

	private ConfiguredEventHandler ConfiguredEvent;

	private InvalidDataSourceEventHandler InvalidDataSourceEvent;

	private DataValidatedEventHandler DataValidatedEvent;

	public object SQLIPAddress
	{
		get
		{
			try
			{
				objStreamreader = new StreamReader(filename);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			object result = objStreamreader.ReadLine();
			m_Sqlport = Conversions.ToLong(objStreamreader.ReadLine());
			m_Initcatalog = objStreamreader.ReadLine();
			m_Username = objStreamreader.ReadLine();
			m_Password = objStreamreader.ReadLine();
			objStreamreader.Close();
			objStreamreader = null;
			return result;
		}
		set
		{
			m_dataSource = Conversions.ToString(value);
		}
	}

	public object SQLPort
	{
		get
		{
			objStreamreader = new StreamReader(filename);
			m_dataSource = objStreamreader.ReadLine();
			object result = objStreamreader.ReadLine();
			m_Initcatalog = objStreamreader.ReadLine();
			m_Username = objStreamreader.ReadLine();
			m_Password = objStreamreader.ReadLine();
			objStreamreader.Close();
			objStreamreader = null;
			return result;
		}
		set
		{
			if (Operators.ConditionalCompareObjectEqual(value, (object)"", false))
			{
				value = 0;
			}
			m_Sqlport = Conversions.ToLong(value);
		}
	}

	public object Initcatalog
	{
		get
		{
			objStreamreader = new StreamReader(filename);
			m_dataSource = objStreamreader.ReadLine();
			m_Sqlport = Conversions.ToLong(objStreamreader.ReadLine());
			object result = objStreamreader.ReadLine();
			m_Username = objStreamreader.ReadLine();
			m_Password = objStreamreader.ReadLine();
			objStreamreader.Close();
			objStreamreader = null;
			return result;
		}
		set
		{
			m_Initcatalog = Conversions.ToString(value);
		}
	}

	public object nUsername
	{
		get
		{
			objStreamreader = new StreamReader(filename);
			m_dataSource = objStreamreader.ReadLine();
			m_Sqlport = Conversions.ToLong(objStreamreader.ReadLine());
			m_Initcatalog = objStreamreader.ReadLine();
			object result = objStreamreader.ReadLine();
			m_Password = objStreamreader.ReadLine();
			objStreamreader.Close();
			objStreamreader = null;
			return result;
		}
		set
		{
			m_Username = Conversions.ToString(value);
		}
	}

	public object nPassword
	{
		get
		{
			objStreamreader = new StreamReader(filename);
			m_dataSource = objStreamreader.ReadLine();
			m_Sqlport = Conversions.ToLong(objStreamreader.ReadLine());
			m_Initcatalog = objStreamreader.ReadLine();
			m_Username = objStreamreader.ReadLine();
			object result = objStreamreader.ReadLine();
			objStreamreader.Close();
			objStreamreader = null;
			return result;
		}
		set
		{
			m_Password = Conversions.ToString(value);
		}
	}

	public object netWorkSource
	{
		get
		{
			objStreamStatus = new StreamReader(filename);
			m_dataSource = objStreamStatus.ReadLine();
			m_Sqlport = Conversions.ToLong(objStreamStatus.ReadLine());
			m_Initcatalog = objStreamStatus.ReadLine();
			m_Username = objStreamStatus.ReadLine();
			nPassword = objStreamStatus.ReadLine();
			object obj = objStreamStatus.ReadLine();
			if (Operators.ConditionalCompareObjectEqual(obj, (object)"", false))
			{
				obj = false;
			}
			objStreamStatus.Close();
			objStreamStatus = null;
			return obj;
		}
		set
		{
			ConStatus = Conversions.ToBoolean(value);
		}
	}

	public object ConnectionString
	{
		get
		{
			return connStr;
		}
		set
		{
			m_connectionString = Conversions.ToString(value);
		}
	}

	public object nConnectionStatus
	{
		get
		{
			return ConStatus;
		}
		set
		{
			ConStatus = Conversions.ToBoolean(value);
		}
	}

	public event NotconfiguredEventHandler Notconfigured
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			NotconfiguredEvent = (NotconfiguredEventHandler)Delegate.Combine(NotconfiguredEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			NotconfiguredEvent = (NotconfiguredEventHandler)Delegate.Remove(NotconfiguredEvent, value);
		}
	}

	public event ConfiguredEventHandler Configured
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ConfiguredEvent = (ConfiguredEventHandler)Delegate.Combine(ConfiguredEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ConfiguredEvent = (ConfiguredEventHandler)Delegate.Remove(ConfiguredEvent, value);
		}
	}

	public event InvalidDataSourceEventHandler InvalidDataSource
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			InvalidDataSourceEvent = (InvalidDataSourceEventHandler)Delegate.Combine(InvalidDataSourceEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			InvalidDataSourceEvent = (InvalidDataSourceEventHandler)Delegate.Remove(InvalidDataSourceEvent, value);
		}
	}

	public event DataValidatedEventHandler DataValidated
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			DataValidatedEvent = (DataValidatedEventHandler)Delegate.Combine(DataValidatedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			DataValidatedEvent = (DataValidatedEventHandler)Delegate.Remove(DataValidatedEvent, value);
		}
	}

	public CconnectionConfig()
	{
		__ENCList.Add(new WeakReference(this));
		ConStatus = false;
	}

	public bool IsValid()
	{
		bool flag = true;
		flag = true & (Operators.CompareString(m_dataSource, "", false) != 0);
		if (m_IsNetwork)
		{
			flag &= m_Sqlport > 0L;
		}
		flag = (flag &= Operators.CompareString(m_Initcatalog, "", false) != 0) & (Operators.CompareString(m_Username, "", false) != 0);
		DataValidatedEvent?.Invoke(flag);
		bool result = default(bool);
		return result;
	}

	public void initialise()
	{
		filePath = "C:\\";
		fileSize = 0L;
		IsExisting = false;
		filename = filePath + "ConnectionConfig.txt";
		CheckFileExists();
		FileInfo fileInfo = new FileInfo(filename);
		fileSize = fileInfo.Length;
		if (fileSize == 0L)
		{
			NotconfiguredEvent?.Invoke();
			return;
		}
		ConfiguredEvent?.Invoke();
		Refreshdata();
	}

	private void CheckFileExists()
	{
		IsExisting = File.Exists(filename);
		if (!IsExisting)
		{
			objStreamwriter = new StreamWriter(filename);
			objStreamwriter.Close();
			objStreamwriter = null;
			NotconfiguredEvent?.Invoke();
		}
	}

	public void Testconnection()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		objconnection = new SqlConnection();
		if (m_IsNetwork)
		{
			connStr = "data source=" + m_dataSource + "," + Conversions.ToString(m_Sqlport) + " Network library = dbmssocn;initial catalog = " + m_Initcatalog + "; user id=" + m_Username + "; password =" + m_Password + " ;";
		}
		if (!m_IsNetwork)
		{
			connStr = "Data Source=(local);Initial Catalog=" + m_Initcatalog + " ;user id =" + m_Username + " ; password =" + m_Password + ";";
		}
		try
		{
			objconnection.set_ConnectionString(connStr);
			objconnection.Open();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)16, (object)"Information");
			InvalidDataSourceEvent?.Invoke();
			ProjectData.ClearProjectError();
		}
		if (objconnection.get_State() == ConnectionState.Open)
		{
			ConStatus = true;
			ConfiguredEvent?.Invoke();
		}
		else
		{
			connectionstatus = false;
		}
	}

	private void Refreshdata()
	{
		m_dataSource = Conversions.ToString(SQLIPAddress);
		m_Sqlport = Conversions.ToLong(SQLPort);
		m_Initcatalog = Conversions.ToString(Initcatalog);
		m_Password = Conversions.ToString(nPassword);
		m_Username = Conversions.ToString(nUsername);
		m_IsNetwork = Conversions.ToBoolean(netWorkSource);
	}

	public void SaveConfig()
	{
		StreamWriter streamWriter = new StreamWriter("C:\\ConnectionConfig.txt");
		streamWriter.WriteLine(m_dataSource);
		streamWriter.WriteLine(m_Sqlport);
		streamWriter.WriteLine(m_Initcatalog);
		streamWriter.WriteLine(m_Username);
		streamWriter.WriteLine(m_Password);
		streamWriter.WriteLine(m_IsNetwork);
		streamWriter.Close();
		streamWriter = null;
	}
}
