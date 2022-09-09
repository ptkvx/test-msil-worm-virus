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

public class Cproduct
{
	public delegate void NoRecordsEventHandler();

	public delegate void RecordExitsEventHandler();

	public delegate void MoveForwardEventHandler(bool blnMoveForward);

	public delegate void MoveBackwardEventHandler(bool blnMoveBack);

	public delegate void DataValidatedEventHandler(bool blnIsValid);

	private static ArrayList __ENCList = new ArrayList();

	public string m_ProductId;

	public string m_ProductName;

	public bool m_IsService;

	public string m_ProductGroupId;

	public string m_Units;

	public double m_Unitcost;

	public double m_StockQty;

	public double m_StockValue;

	public double m_SellingPrice1;

	public string m_StockAcref;

	public string m_SalesAcref;

	public string m_CogsAcref;

	public DataRow nRow;

	public long nCurrec;

	public long m_lngRecordCount;

	public long m_lngRecordNumber;

	public string nkey;

	private bool m_blnIsNewRecord;

	public SqlCommand SelectCmd;

	public DataSet DsProduct;

	public SqlDataAdapter DaProduct;

	public DataTable DtProduct;

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

	public object ProductiD
	{
		get
		{
			return m_ProductId;
		}
		set
		{
			m_ProductId = Conversions.ToString(value);
		}
	}

	public object ProductName
	{
		get
		{
			return m_ProductName;
		}
		set
		{
			m_ProductName = Conversions.ToString(value);
		}
	}

	public object IsService
	{
		get
		{
			return m_IsService;
		}
		set
		{
			m_IsService = Conversions.ToBoolean(value);
		}
	}

	public object ProductGroupId
	{
		get
		{
			return m_ProductGroupId;
		}
		set
		{
			m_ProductGroupId = Conversions.ToString(value);
		}
	}

	public object Units
	{
		get
		{
			return m_Units;
		}
		set
		{
			m_Units = Conversions.ToString(value);
		}
	}

	public object Unitcost
	{
		get
		{
			return m_Unitcost;
		}
		set
		{
			m_Unitcost = Conversions.ToDouble(value);
		}
	}

	public object StockQty
	{
		get
		{
			return m_StockQty;
		}
		set
		{
			m_StockQty = Conversions.ToDouble(value);
		}
	}

	public object Stockvalue
	{
		get
		{
			return m_StockValue;
		}
		set
		{
			m_StockValue = Conversions.ToDouble(value);
		}
	}

	public object SellingPrice1
	{
		get
		{
			return m_SellingPrice1;
		}
		set
		{
			m_SellingPrice1 = Conversions.ToDouble(value);
		}
	}

	public object Stockacref
	{
		get
		{
			return m_StockAcref;
		}
		set
		{
			m_StockAcref = Conversions.ToString(value);
		}
	}

	public object Salesacref
	{
		get
		{
			return m_SalesAcref;
		}
		set
		{
			m_SalesAcref = Conversions.ToString(value);
		}
	}

	public object Cogsacref
	{
		get
		{
			return m_CogsAcref;
		}
		set
		{
			m_CogsAcref = Conversions.ToString(value);
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
	public Cproduct()
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
				((DbDataAdapter)(object)DaProduct).Update(DsProduct, "products");
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
		if (DsProduct.Tables["products"]!.Rows.Count == 0)
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
				nRow = DsProduct.Tables["products"]!.Rows[(int)m_lngRecordNumber];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Information");
				ProjectData.ClearProjectError();
				return;
			}
			ProductiD = nRow["productid"].ToString();
			ProductName = nRow["productname"].ToString();
			IsService = nRow["isservice"].ToString();
			Units = nRow["units"].ToString();
			ProductGroupId = nRow["productgroupid"].ToString();
			Unitcost = nRow["unitcost"].ToString();
			StockQty = nRow["stockqty"].ToString();
			Stockvalue = nRow["stockvalue"].ToString();
			SellingPrice1 = nRow["sellingprice1"].ToString();
			Stockacref = nRow["stocksacref"].ToString();
			Salesacref = nRow["salesacref"].ToString();
			Cogsacref = nRow["Cogsacref"].ToString();
		}
	}

	public bool IsValid()
	{
		bool flag = true;
		flag = (flag = (flag = (flag = (flag = (flag = (flag = (flag = true & (Operators.CompareString(m_ProductId, "", false) != 0)) & (Operators.CompareString(m_ProductName, "", false) != 0)) & (Operators.CompareString(m_Units, "", false) != 0)) & (m_Unitcost != 0.0)) & (m_SellingPrice1 != 0.0)) & (Operators.CompareString(m_StockAcref, "", false) != 0)) & (Operators.CompareString(m_SalesAcref, "", false) != 0)) & (Operators.CompareString(m_CogsAcref, "", false) != 0);
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
		StrSql = "select * from products order by productid";
		SelectCmd = new SqlCommand(StrSql, Startup.dBcon);
		DsProduct = new DataSet();
		DaProduct = new SqlDataAdapter(StrSql, Startup.dBcon);
		DtProduct = new DataTable("products");
		objCommandBuilder = new SqlCommandBuilder(DaProduct);
		try
		{
			((DbDataAdapter)(object)DaProduct).FillSchema(DsProduct, SchemaType.Mapped, "products");
			((DbDataAdapter)(object)DaProduct).Fill(DsProduct, "products");
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
			m_lngRecordCount = DsProduct.Tables["products"]!.Rows.Count;
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
		nRow["productid"] = m_ProductId;
		nRow["productname"] = m_ProductName;
		nRow["Isservice"] = m_IsService;
		nRow["productgroupid"] = m_ProductGroupId;
		nRow["units"] = m_Units;
		nRow["unitcost"] = m_Unitcost;
		nRow["stockqty"] = m_StockQty;
		nRow["stockvalue"] = m_StockValue;
		nRow["sellingprice1"] = m_SellingPrice1;
		nRow["stocksacref"] = m_StockAcref;
		nRow["salesacref"] = m_SalesAcref;
		nRow["cogsacref"] = m_CogsAcref;
	}

	public void Save(bool blnIsNewRecord)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (blnIsNewRecord)
		{
			try
			{
				nRow = DsProduct.Tables["products"]!.NewRow();
				Getvalues();
				DsProduct.Tables["products"]!.Rows.Add(nRow);
				((DbDataAdapter)(object)DaProduct).Update(DsProduct, "products");
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
				((DbDataAdapter)(object)DaProduct).Update(DsProduct, "products");
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
		nRow = DsProduct.Tables["products"]!.Rows.Find(nSearchkey);
		if (nRow != null)
		{
			RecordExitsEvent?.Invoke();
		}
	}
}
