using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxThreed;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class frmcommonlookup : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("CmdOk")]
	private AxSSCommand _CmdOk;

	[AccessedThroughProperty("lvwlookup")]
	private ListView _lvwlookup;

	private Form frmEdit;

	private Control txtLookupID;

	private Control txtLookupDesc;

	private const int conHwndTopmost = -1;

	private const int conHwndNoTopmost = -2;

	private const int conSwpNoActivate = 16;

	private const int conSwpShowWindow = 64;

	private long nIdsize;

	private long nDetailSize;

	private long rs;

	private Point objdrawingpoint;

	private string strname;

	private ListViewItem nlistItem;

	private ListViewSubItem nSubListItem;

	private ListView Objlvwlookup;

	private int ncount;

	private DataColumn nColn;

	private ColumnHeader nHeader;

	private SqlDataAdapter dA;

	private DataSet dS;

	private DataTable dT;

	private DataRow dR;

	private string Strsql;

	private ListViewItem objListViewItem;

	private ListViewSubItem objlistViewSubItem;

	private Form nEditform;

	private TextBox nEdittxtId;

	private TextBox nEdittxtDetails;

	private ListViewHitTestInfo lhi;

	private string StrID;

	private string StrDetails;

	internal virtual AxSSCommand CmdOk
	{
		[DebuggerNonUserCode]
		get
		{
			return _CmdOk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CmdOk != null)
			{
				((Control)_CmdOk).remove_Enter((EventHandler)CmdOk_Enter);
				_CmdOk.remove_ClickEvent((EventHandler)CmdOk_ClickEvent);
			}
			_CmdOk = value;
			if (_CmdOk != null)
			{
				((Control)_CmdOk).add_Enter((EventHandler)CmdOk_Enter);
				_CmdOk.add_ClickEvent((EventHandler)CmdOk_ClickEvent);
			}
		}
	}

	internal virtual ListView lvwlookup
	{
		[DebuggerNonUserCode]
		get
		{
			return _lvwlookup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected O, but got Unknown
			if (_lvwlookup != null)
			{
				_lvwlookup.remove_SelectedIndexChanged((EventHandler)Lvwlookup_SelectedIndexChanged);
				((Control)_lvwlookup).remove_MouseDown(new MouseEventHandler(lvwlookup_MouseDown));
				((Control)_lvwlookup).remove_KeyPress(new KeyPressEventHandler(Lvwloolup_KeyPress));
				_lvwlookup.remove_ItemSelectionChanged(new ListViewItemSelectionChangedEventHandler(lvwlookup_ItemSelectionChanged));
				((Control)_lvwlookup).remove_DoubleClick((EventHandler)Lvwlookup_DoubleClick);
				_lvwlookup.remove_ColumnClick(new ColumnClickEventHandler(Lvwloolup_ColumnClick));
				((Control)_lvwlookup).remove_Click((EventHandler)lvwlookup_Click);
			}
			_lvwlookup = value;
			if (_lvwlookup != null)
			{
				_lvwlookup.add_SelectedIndexChanged((EventHandler)Lvwlookup_SelectedIndexChanged);
				((Control)_lvwlookup).add_MouseDown(new MouseEventHandler(lvwlookup_MouseDown));
				((Control)_lvwlookup).add_KeyPress(new KeyPressEventHandler(Lvwloolup_KeyPress));
				_lvwlookup.add_ItemSelectionChanged(new ListViewItemSelectionChangedEventHandler(lvwlookup_ItemSelectionChanged));
				((Control)_lvwlookup).add_DoubleClick((EventHandler)Lvwlookup_DoubleClick);
				_lvwlookup.add_ColumnClick(new ColumnClickEventHandler(Lvwloolup_ColumnClick));
				((Control)_lvwlookup).add_Click((EventHandler)lvwlookup_Click);
			}
		}
	}

	public frmcommonlookup()
	{
		((Form)this).add_Activated((EventHandler)frmcommonlookup_Activated);
		((Form)this).add_Load((EventHandler)frmcommonlookup_Load);
		__ENCList.Add(new WeakReference(this));
		Objlvwlookup = lvwlookup;
		dS = new DataSet();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmcommonlookup));
		CmdOk = new AxSSCommand();
		lvwlookup = new ListView();
		((ISupportInitialize)CmdOk).BeginInit();
		((Control)this).SuspendLayout();
		AxSSCommand cmdOk = CmdOk;
		Point location = new Point(99, 248);
		((Control)cmdOk).set_Location(location);
		((Control)CmdOk).set_Name("CmdOk");
		((AxHost)CmdOk).set_OcxState((State)componentResourceManager.GetObject("CmdOk.OcxState"));
		AxSSCommand cmdOk2 = CmdOk;
		Size size = new Size(61, 24);
		((Control)cmdOk2).set_Size(size);
		((Control)CmdOk).set_TabIndex(41);
		lvwlookup.set_BorderStyle((BorderStyle)1);
		lvwlookup.set_HideSelection(false);
		ListView obj = lvwlookup;
		location = new Point(12, 12);
		((Control)obj).set_Location(location);
		((Control)lvwlookup).set_Name("lvwlookup");
		ListView obj2 = lvwlookup;
		size = new Size(245, 230);
		((Control)obj2).set_Size(size);
		((Control)lvwlookup).set_TabIndex(43);
		lvwlookup.set_UseCompatibleStateImageBehavior(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.InactiveCaptionText);
		size = new Size(272, 279);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lvwlookup);
		((Control)this).get_Controls().Add((Control)(object)CmdOk);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmcommonlookup");
		((Form)this).set_Text("Selection");
		((ISupportInitialize)CmdOk).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void frmcommonlookup_Activated(object sender, EventArgs e)
	{
	}

	private void frmcommonlookup_Load(object sender, EventArgs e)
	{
	}

	public void InitialiseLookup(Form EditForm, TextBox txtID, TextBox txtDescription, string TableName, string nKey)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		nEdittxtId = txtID;
		nEdittxtDetails = txtDescription;
		Strsql = "select * from " + TableName + " order by " + nKey;
		lvwlookup.set_View((View)1);
		nHeader = new ColumnHeader();
		nHeader.set_Width(80);
		nHeader.set_Text("ID");
		lvwlookup.get_Columns().Add(nHeader);
		nHeader = new ColumnHeader();
		nHeader.set_Width(200);
		nHeader.set_Text("Details");
		lvwlookup.get_Columns().Add(nHeader);
		dA = new SqlDataAdapter(Strsql, Startup.dBcon);
		((DbDataAdapter)(object)dA).Fill(dS, TableName);
		dT = dS.Tables[TableName];
		if (dT.Rows.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dT.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				dR = (DataRow)enumerator.Current;
				nlistItem = new ListViewItem();
				nlistItem.set_Text(Conversions.ToString(dR[dT.Columns[0]]));
				lvwlookup.get_Items().Add(nlistItem);
				nSubListItem = new ListViewSubItem();
				nSubListItem.set_Text(dR[1].ToString());
				nlistItem.get_SubItems().Add(nSubListItem);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		lvwlookup.set_FullRowSelect(true);
		((Form)this).ShowDialog();
	}

	private void GetSelection()
	{
	}

	private void CmdOk_ClickEvent(object sender, EventArgs e)
	{
		if (Operators.CompareString(CmdOk.get_Caption(), "&Cancel", false) == 0)
		{
			closeme();
		}
		else
		{
			GetSelection();
		}
		closeme();
	}

	private void CmdOk_Enter(object sender, EventArgs e)
	{
	}

	private void closeme()
	{
		nlistItem = null;
		nSubListItem = null;
		Objlvwlookup = null;
		dA = null;
		dS = null;
		dT = null;
		dR = null;
		((Form)this).Close();
	}

	private void lvwlookup_Click(object sender, EventArgs e)
	{
		objdrawingpoint = ((Control)lvwlookup).PointToClient(Cursor.get_Position());
		if ((objdrawingpoint.X == 0) & (objdrawingpoint.Y == 0))
		{
			CmdOk.set_Caption("&Close");
		}
		else
		{
			CmdOk.set_Caption("&OK");
		}
	}

	private void Lvwloolup_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		if ((objdrawingpoint.X != 0) & (objdrawingpoint.Y != 0))
		{
		}
	}

	private void Lvwlookup_DoubleClick(object sender, EventArgs e)
	{
		objdrawingpoint = ((Control)lvwlookup).PointToClient(Cursor.get_Position());
		if ((objdrawingpoint.X == 0) & (objdrawingpoint.Y == 0))
		{
			CmdOk.set_Caption("&Close");
		}
		else
		{
			CmdOk.set_Caption("&OK");
		}
		closeme();
	}

	private void lvwlookup_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
	{
	}

	private void Lvwloolup_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(e.get_KeyChar()), "13", false) == 0)
		{
			CmdOk.set_Value(true);
		}
	}

	private void lvwlookup_MouseDown(object sender, MouseEventArgs e)
	{
		lhi = lvwlookup.HitTest(80, e.get_Y());
		nEdittxtId.set_Text(lhi.get_Item().get_Text());
		nEdittxtDetails.set_Text(lhi.get_SubItem().get_Text());
	}

	private void Lvwlookup_SelectedIndexChanged(object sender, EventArgs e)
	{
	}
}
