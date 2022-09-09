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

public class Cledger
{
	public delegate void NoRecordsEventHandler();

	public delegate void RecordExitsEventHandler();

	public delegate void MoveForwardEventHandler(bool blnMoveForward);

	public delegate void MoveBackwardEventHandler(bool blnMoveBack);

	public delegate void DataValidatedEventHandler(bool blnIsValid);

	private static ArrayList __ENCList = new ArrayList();

	public string m_Acref;

	public string m_Acname;

	public string m_Actype;

	public string m_ActypeId;

	public string m_ExportAcref;

	public DataRow nRow;

	public long nCurrec;

	public long m_lngRecordCount;

	public long m_lngRecordNumber;

	public string nkey;

	private bool m_blnIsNewRecord;

	public SqlCommand SelectCmd;

	public DataSet Dsledger;

	public SqlDataAdapter Daledger;

	public DataTable Dtledger;

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

	public object Acname
	{
		get
		{
			return m_Acname;
		}
		set
		{
			m_Acname = Conversions.ToString(value);
		}
	}

	public object Actype
	{
		get
		{
			return m_Actype;
		}
		set
		{
			m_Actype = Conversions.ToString(value);
		}
	}

	public object ActypeId
	{
		get
		{
			return m_ActypeId;
		}
		set
		{
			m_ActypeId = Conversions.ToString(value);
		}
	}

	public object ExportAcref
	{
		get
		{
			return m_ExportAcref;
		}
		set
		{
			m_ExportAcref = Conversions.ToString(value);
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
	public Cledger()
	{
		__ENCList.Add(new WeakReference(this));
	}

	public void Delete(string nkey)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
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
				((DbDataAdapter)(object)Daledger).Update(Dsledger, "ledger");
				m_lngRecordNumber = nCurrec;
				m_lngRecordCount--;
				Initialise(Startup.dBcon);
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
		if (Dsledger.Tables["ledger"]!.Rows.Count == 0)
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
				nRow = Dsledger.Tables["ledger"]!.Rows[(int)m_lngRecordNumber];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
				return;
			}
			Acref = nRow["acref"].ToString();
			Acname = nRow["acname"].ToString();
			Actype = nRow["actype"].ToString();
			ActypeId = nRow["actypeid"].ToString();
			ExportAcref = nRow["exportacref"].ToString();
		}
	}

	public bool IsValid()
	{
		bool flag = true;
		flag = (flag = (flag = true & (Operators.CompareString(m_Acref, "", false) != 0)) & (Operators.CompareString(m_Acname, "", false) != 0)) & (Operators.CompareString(m_Actype, "", false) != 0);
		DataValidatedEvent?.Invoke(flag);
		bool result = default(bool);
		return result;
	}

	public void Initialise(SqlConnection objDB)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		StrSql = "select * from ledger order by acref";
		SelectCmd = new SqlCommand(StrSql, Startup.dBcon);
		Dsledger = new DataSet();
		Daledger = new SqlDataAdapter(StrSql, Startup.dBcon);
		Dtledger = new DataTable("ledger");
		objCommandBuilder = new SqlCommandBuilder(Daledger);
		try
		{
			((DbDataAdapter)(object)Daledger).FillSchema(Dsledger, SchemaType.Mapped, "ledger");
			((DbDataAdapter)(object)Daledger).Fill(Dsledger, "ledger");
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
			m_lngRecordCount = Dsledger.Tables["ledger"]!.Rows.Count;
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
		nRow["acref"] = m_Acref;
		nRow["acname"] = m_Acname;
		nRow["actypeid"] = m_ActypeId;
		nRow["actype"] = m_Actype;
		nRow["exportacref"] = m_ExportAcref;
	}

	public void Save(bool blnIsNewRecord)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (blnIsNewRecord)
		{
			try
			{
				nRow = Dsledger.Tables["ledger"]!.NewRow();
				Getvalues();
				Dsledger.Tables["ledger"]!.Rows.Add(nRow);
				((DbDataAdapter)(object)Daledger).Update(Dsledger, "ledger");
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
				((DbDataAdapter)(object)Daledger).Update(Dsledger, "ledger");
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
		Initialise(Startup.dBcon);
		m_lngRecordNumber = nCurrec;
		Refreshdata();
	}

	public void FindRecord(string nSearchkey)
	{
		nRow = Dsledger.Tables["ledger"]!.Rows.Find(nSearchkey);
		if (nRow != null)
		{
			RecordExitsEvent?.Invoke();
		}
	}
}
