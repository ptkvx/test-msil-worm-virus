using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

public class Cdependant
{
	public delegate void NoRecordsEventHandler();

	public delegate void RecordExitsEventHandler();

	public delegate void MoveForwardEventHandler(bool blnMoveForward);

	public delegate void MoveBackwardEventHandler(bool blnMoveBack);

	public delegate void DataValidatedEventHandler(bool blnIsValid);

	private static ArrayList __ENCList = new ArrayList();

	public string m_DependantId;

	public string m_EmployeeId;

	public string m_Acref;

	public string m_Fname;

	public string m_Lname;

	public string m_Sex;

	public DateTime m_DOB;

	public string m_Relationship;

	public DataRow nRow;

	public long nCurrec;

	public long m_lngRecordCount;

	public long m_lngRecordNumber;

	public string nkey;

	private bool m_blnIsNewRecord;

	public SqlCommand SelectCmd;

	public DataSet DsDependant;

	public SqlDataAdapter DaDependant;

	public DataTable DtDependant;

	public SqlCommandBuilder objCommandBuilder;

	public DataColumn nKeycolumn;

	private string StrSql;

	private NoRecordsEventHandler NoRecordsEvent;

	private RecordExitsEventHandler RecordExitsEvent;

	private MoveForwardEventHandler MoveForwardEvent;

	private MoveBackwardEventHandler MoveBackwardEvent;

	private DataValidatedEventHandler DataValidatedEvent;

	public object RecordNumber
	{
		get
		{
			return m_lngRecordNumber;
		}
		set
		{
		}
	}

	public object RecordCount
	{
		get
		{
			return m_lngRecordCount;
		}
		set
		{
		}
	}

	public object DependantID
	{
		get
		{
			return m_DependantId;
		}
		set
		{
			m_DependantId = Conversions.ToString(value);
		}
	}

	public object EmployeeID
	{
		get
		{
			return m_EmployeeId;
		}
		set
		{
			m_EmployeeId = Conversions.ToString(value);
		}
	}

	public object Acref
	{
		get
		{
			return m_Acref;
		}
		set
		{
			m_Acref = Conversions.ToString(value);
		}
	}

	public object Fname
	{
		get
		{
			return m_Fname;
		}
		set
		{
			m_Fname = Conversions.ToString(value);
		}
	}

	public object Lname
	{
		get
		{
			return m_Lname;
		}
		set
		{
			m_Lname = Conversions.ToString(value);
		}
	}

	public object DOB
	{
		get
		{
			return m_DOB;
		}
		set
		{
			m_DOB = Conversions.ToDate(value);
		}
	}

	public object Sex
	{
		get
		{
			return m_Sex;
		}
		set
		{
			m_Sex = Conversions.ToString(value);
		}
	}

	public object Relationship
	{
		get
		{
			return m_Relationship;
		}
		set
		{
			m_Relationship = Conversions.ToString(value);
		}
	}

	public event NoRecordsEventHandler NoRecords
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			NoRecordsEvent = (NoRecordsEventHandler)Delegate.Combine(NoRecordsEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			NoRecordsEvent = (NoRecordsEventHandler)Delegate.Remove(NoRecordsEvent, value);
		}
	}

	public event RecordExitsEventHandler RecordExits
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			RecordExitsEvent = (RecordExitsEventHandler)Delegate.Combine(RecordExitsEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			RecordExitsEvent = (RecordExitsEventHandler)Delegate.Remove(RecordExitsEvent, value);
		}
	}

	public event MoveForwardEventHandler MoveForward
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			MoveForwardEvent = (MoveForwardEventHandler)Delegate.Combine(MoveForwardEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			MoveForwardEvent = (MoveForwardEventHandler)Delegate.Remove(MoveForwardEvent, value);
		}
	}

	public event MoveBackwardEventHandler MoveBackward
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			MoveBackwardEvent = (MoveBackwardEventHandler)Delegate.Combine(MoveBackwardEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			MoveBackwardEvent = (MoveBackwardEventHandler)Delegate.Remove(MoveBackwardEvent, value);
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

	[DebuggerNonUserCode]
	public Cdependant()
	{
		__ENCList.Add(new WeakReference(this));
	}

	public void Delete(string nkey)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(nkey, "", false) != 0)
		{
			try
			{
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		checked
		{
			try
			{
				if (m_lngRecordNumber - 1L < 0L)
				{
					m_lngRecordNumber = 0L;
					nCurrec = m_lngRecordNumber;
				}
				else
				{
					nCurrec = m_lngRecordNumber - 1L;
				}
				nRow.Delete();
				((DbDataAdapter)(object)DaDependant).Update(DsDependant, "Dependant");
				m_lngRecordNumber = nCurrec;
				m_lngRecordCount--;
				Initialise(Startup.dBcon, Conversions.ToString(EmployeeID), Conversions.ToString(Acref));
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
			}
		}
	}

	public void MoveFirst()
	{
		if (m_lngRecordCount > 0L)
		{
			m_lngRecordNumber = 0L;
		}
		Refreshdata();
	}

	public void MovePrevious()
	{
		checked
		{
			if (m_lngRecordNumber - 1L >= 0L)
			{
				m_lngRecordNumber--;
			}
			else
			{
				m_lngRecordNumber = 0L;
			}
			Refreshdata();
		}
	}

	public void MoveLast()
	{
		if (m_lngRecordCount > 0L)
		{
			m_lngRecordNumber = checked(m_lngRecordCount - 1L);
		}
		else
		{
			m_lngRecordNumber = 0L;
		}
		Refreshdata();
	}

	public void MoveNext()
	{
		checked
		{
			if (m_lngRecordCount > m_lngRecordNumber + 1L)
			{
				m_lngRecordNumber++;
			}
			else
			{
				m_lngRecordNumber = m_lngRecordCount - 1L;
			}
			Refreshdata();
		}
	}

	public void Refreshdata()
	{
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		if (DsDependant.Tables["Dependants"]!.Rows.Count == 0)
		{
			NoRecordsEvent?.Invoke();
			return;
		}
		if (m_lngRecordNumber == 0L)
		{
			MoveBackwardEvent?.Invoke(blnMoveBack: false);
		}
		checked
		{
			if (m_lngRecordNumber == m_lngRecordCount - 1L)
			{
				MoveForwardEvent?.Invoke(blnMoveForward: false);
			}
			if (m_lngRecordNumber < m_lngRecordCount - 1L)
			{
				MoveForwardEvent?.Invoke(blnMoveForward: true);
			}
			if ((m_lngRecordNumber == m_lngRecordCount - 1L) & (m_lngRecordCount > 1L))
			{
				MoveForwardEvent?.Invoke(blnMoveForward: false);
				MoveBackwardEvent?.Invoke(blnMoveBack: true);
			}
			if ((m_lngRecordNumber == 0L) & (m_lngRecordCount > 1L))
			{
				MoveBackwardEvent?.Invoke(blnMoveBack: false);
				MoveForwardEvent?.Invoke(blnMoveForward: true);
			}
			if ((m_lngRecordNumber != 0L) & (m_lngRecordCount - 1L != m_lngRecordNumber) & (m_lngRecordCount > 1L))
			{
				MoveBackwardEvent?.Invoke(blnMoveBack: true);
				MoveForwardEvent?.Invoke(blnMoveForward: true);
			}
			try
			{
				nRow = DsDependant.Tables["Dependants"]!.Rows[(int)m_lngRecordNumber];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
				return;
			}
			EmployeeID = nRow["DependantID"].ToString();
			EmployeeID = nRow["EmployeeID"].ToString();
			Acref = nRow["Acref"].ToString();
			Fname = nRow["Fname"].ToString();
			Lname = nRow["Lname"].ToString();
			Relationship = nRow["Relationship"].ToString();
			Sex = nRow["Sex"].ToString();
			DOB = nRow["DOB"].ToString();
		}
	}

	public bool IsValid()
	{
		bool flag = true;
		flag = (flag = (flag = (flag = (flag = true & (Operators.CompareString(m_DependantId, "", false) != 0)) & (Operators.CompareString(m_EmployeeId, "", false) != 0)) & (Operators.CompareString(m_Acref, "", false) != 0)) & (Operators.CompareString(m_Fname, "", false) != 0)) & (Operators.CompareString(m_Lname, "", false) != 0);
		DataValidatedEvent?.Invoke(flag);
		bool result = default(bool);
		return result;
	}

	public void Initialise(SqlConnection objDB, string StrEmployeeID, string StrAcref)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		StrSql = "select * from Dependants  Where acref = " + StrAcref + " And EmployeeId = " + StrEmployeeID + " order by dependantId";
		SelectCmd = new SqlCommand(StrSql, Startup.dBcon);
		DsDependant = new DataSet();
		DaDependant = new SqlDataAdapter(StrSql, Startup.dBcon);
		DtDependant = new DataTable("Dependants");
		objCommandBuilder = new SqlCommandBuilder(DaDependant);
		try
		{
			((DbDataAdapter)(object)DaDependant).FillSchema(DsDependant, SchemaType.Mapped, "Dependants");
			((DbDataAdapter)(object)DaDependant).Fill(DsDependant, "Dependant");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Information");
			ProjectData.ClearProjectError();
		}
		try
		{
			m_lngRecordCount = DsDependant.Tables["Dependants"]!.Rows.Count;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)64, (object)"Information");
			ProjectData.ClearProjectError();
		}
		if (m_lngRecordCount == 0L)
		{
			NoRecordsEvent?.Invoke();
		}
		else
		{
			Refreshdata();
		}
	}

	private void Getvalues()
	{
		nRow["DependantID"] = m_DependantId;
		nRow["EmployeeID"] = m_EmployeeId;
		nRow["Acref"] = m_Acref;
		nRow["Fname"] = m_Fname;
		nRow["Lname"] = m_Lname;
		nRow["Sex"] = m_Sex;
		nRow["DOB"] = m_DOB;
		nRow["Relationship"] = m_Relationship;
	}

	public void Save(bool blnIsNewRecord)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (blnIsNewRecord)
		{
			try
			{
				nRow = DsDependant.Tables["Dependants"]!.NewRow();
				Getvalues();
				DsDependant.Tables["Dependants"]!.Rows.Add(nRow);
				((DbDataAdapter)(object)DaDependant).Update(DsDependant, "Dependents");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
			}
			nCurrec = m_lngRecordCount;
		}
		if (!blnIsNewRecord)
		{
			nRow.BeginEdit();
			Getvalues();
			nRow.EndEdit();
			try
			{
				((DbDataAdapter)(object)DaDependant).Update(DsDependant, "Dependants");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
			}
			nCurrec = m_lngRecordNumber;
		}
		Initialise(Startup.dBcon, Conversions.ToString(EmployeeID), Conversions.ToString(Acref));
		m_lngRecordNumber = nCurrec;
		Refreshdata();
	}

	public void FindRecord(string nSearchkey)
	{
		nRow = DsDependant.Tables["Dependants"]!.Rows.Find(nSearchkey);
		if (nRow != null)
		{
			RecordExitsEvent?.Invoke();
		}
	}
}
