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

public class Ccustomer
{
	public delegate void NoRecordsEventHandler();

	public delegate void RecordExitsEventHandler();

	public delegate void MoveForwardEventHandler(bool blnMoveForward);

	public delegate void MoveBackwardEventHandler(bool blnMoveBack);

	public delegate void DataValidatedEventHandler(bool blnIsValid);

	private static ArrayList __ENCList = new ArrayList();

	public string m_CustomerId;

	public string m_CustomerName;

	public string m_GroupId;

	public string m_VATNo;

	public string m_Address;

	public string m_Country;

	public string m_Town;

	public string m_telephone;

	public string m_Cellno;

	public string m_ContactPerson1;

	public string m_Contactperson2;

	public double m_Lastbill;

	public double m_Lastpayment;

	public double m_balance;

	public DateTime m_LastTransDate;

	public DataRow nRow;

	public long nCurrec;

	public long m_lngRecordCount;

	public long m_lngRecordNumber;

	public string nkey;

	private bool m_blnIsNewRecord;

	public SqlCommand SelectCmd;

	public DataSet DsCustomer;

	public SqlDataAdapter DaCustomer;

	public DataTable DtCustomer;

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

	public object CustomerID
	{
		get
		{
			return m_CustomerId;
		}
		set
		{
			m_CustomerId = Conversions.ToString(value);
		}
	}

	public object CustomerName
	{
		get
		{
			return m_CustomerName;
		}
		set
		{
			m_CustomerName = Conversions.ToString(value);
		}
	}

	public object GroupId
	{
		get
		{
			return m_GroupId;
		}
		set
		{
			m_GroupId = Conversions.ToString(value);
		}
	}

	public object VatNo
	{
		get
		{
			return m_VATNo;
		}
		set
		{
			m_VATNo = Conversions.ToString(value);
		}
	}

	public object PhysicalAddress
	{
		get
		{
			return m_Address;
		}
		set
		{
			m_Address = Conversions.ToString(value);
		}
	}

	public object Town
	{
		get
		{
			return m_Town;
		}
		set
		{
			m_Town = Conversions.ToString(value);
		}
	}

	public object Country
	{
		get
		{
			return m_Country;
		}
		set
		{
			m_Country = Conversions.ToString(value);
		}
	}

	public object Telephone
	{
		get
		{
			return m_telephone;
		}
		set
		{
			m_telephone = Conversions.ToString(value);
		}
	}

	public object Cellno
	{
		get
		{
			return m_Cellno;
		}
		set
		{
			m_Cellno = Conversions.ToString(value);
		}
	}

	public object ContactPerson1
	{
		get
		{
			return m_ContactPerson1;
		}
		set
		{
			m_ContactPerson1 = Conversions.ToString(value);
		}
	}

	public object ContactPerson2
	{
		get
		{
			return m_Contactperson2;
		}
		set
		{
			m_Contactperson2 = Conversions.ToString(value);
		}
	}

	public object LastBill
	{
		get
		{
			return m_Lastbill;
		}
		set
		{
			m_Lastbill = Conversions.ToDouble(value);
		}
	}

	public object LastPayment
	{
		get
		{
			return m_Lastpayment;
		}
		set
		{
			m_Lastpayment = Conversions.ToDouble(value);
		}
	}

	public object Balance
	{
		get
		{
			return m_balance;
		}
		set
		{
			m_balance = Conversions.ToDouble(value);
		}
	}

	public object LastTransDate
	{
		get
		{
			return m_LastTransDate;
		}
		set
		{
			m_LastTransDate = Conversions.ToDate(value);
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
	public Ccustomer()
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
				((DbDataAdapter)(object)DaCustomer).Update(DsCustomer, "debtors");
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
		if (DsCustomer.Tables["debtors"]!.Rows.Count == 0)
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
				nRow = DsCustomer.Tables["debtors"]!.Rows[(int)m_lngRecordNumber];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
				return;
			}
			CustomerID = nRow["acref"].ToString();
			CustomerName = nRow["acname"].ToString();
			GroupId = nRow["groupid"].ToString();
			VatNo = nRow["vatnumber"].ToString();
			PhysicalAddress = nRow["address"].ToString();
			Town = nRow["town"].ToString();
			Country = nRow["Country"].ToString();
			Telephone = nRow["phone1"].ToString();
			Cellno = nRow["Cellno"].ToString();
			ContactPerson1 = nRow["Contnam1"].ToString();
			ContactPerson2 = nRow["Contnam2"].ToString();
			LastBill = nRow["Lastbill"].ToString();
			LastPayment = nRow["Lastpayment"].ToString();
			Balance = nRow["balance"].ToString();
			LastTransDate = nRow["LastTransDate"].ToString();
		}
	}

	public bool IsValid()
	{
		bool flag = true;
		flag = (flag = true & (Operators.CompareString(m_CustomerId, "", false) != 0)) & (Operators.CompareString(m_CustomerName, "", false) != 0);
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
		StrSql = "select * from debtors order by acref";
		SelectCmd = new SqlCommand(StrSql, Startup.dBcon);
		DsCustomer = new DataSet();
		DaCustomer = new SqlDataAdapter(StrSql, Startup.dBcon);
		DtCustomer = new DataTable("debtors");
		objCommandBuilder = new SqlCommandBuilder(DaCustomer);
		try
		{
			((DbDataAdapter)(object)DaCustomer).FillSchema(DsCustomer, SchemaType.Mapped, "debtors");
			((DbDataAdapter)(object)DaCustomer).Fill(DsCustomer, "debtors");
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
			m_lngRecordCount = DsCustomer.Tables["debtors"]!.Rows.Count;
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
		nRow["acref"] = m_CustomerId;
		nRow["acname"] = m_CustomerName;
		nRow["groupid"] = m_GroupId;
		nRow["vatnumber"] = m_VATNo;
		nRow["address"] = m_Address;
		nRow["town"] = m_Town;
		nRow["country"] = m_Country;
		nRow["phone1"] = m_telephone;
		nRow["cellno"] = m_Cellno;
		nRow["contnam1"] = m_ContactPerson1;
		nRow["contnam2"] = m_Contactperson2;
		nRow["lastbill"] = m_Lastbill;
		nRow["lastpayment"] = m_Lastpayment;
		nRow["Balance"] = m_balance;
		nRow["lastTransdate"] = m_LastTransDate;
	}

	public void Save(bool blnIsNewRecord)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (blnIsNewRecord)
		{
			try
			{
				nRow = DsCustomer.Tables["debtors"]!.NewRow();
				Getvalues();
				DsCustomer.Tables["debtors"]!.Rows.Add(nRow);
				((DbDataAdapter)(object)DaCustomer).Update(DsCustomer, "debtors");
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
				((DbDataAdapter)(object)DaCustomer).Update(DsCustomer, "debtors");
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
		nRow = DsCustomer.Tables["debtors"]!.Rows.Find(nSearchkey);
		if (nRow != null)
		{
			RecordExitsEvent?.Invoke();
		}
	}
}
