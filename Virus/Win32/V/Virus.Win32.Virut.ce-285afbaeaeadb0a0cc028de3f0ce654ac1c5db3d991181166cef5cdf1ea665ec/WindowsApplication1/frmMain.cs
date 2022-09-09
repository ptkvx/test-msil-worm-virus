using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My;

namespace WindowsApplication1;

[DesignerGenerated]
public class frmMain : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("ContentsToolStripMenuItem")]
	private ToolStripMenuItem _ContentsToolStripMenuItem;

	[AccessedThroughProperty("HelpMenu")]
	private ToolStripMenuItem _HelpMenu;

	[AccessedThroughProperty("IndexToolStripMenuItem")]
	private ToolStripMenuItem _IndexToolStripMenuItem;

	[AccessedThroughProperty("SearchToolStripMenuItem")]
	private ToolStripMenuItem _SearchToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	[AccessedThroughProperty("ArrangeIconsToolStripMenuItem")]
	private ToolStripMenuItem _ArrangeIconsToolStripMenuItem;

	[AccessedThroughProperty("CloseAllToolStripMenuItem")]
	private ToolStripMenuItem _CloseAllToolStripMenuItem;

	[AccessedThroughProperty("NewWindowToolStripMenuItem")]
	private ToolStripMenuItem _NewWindowToolStripMenuItem;

	[AccessedThroughProperty("WindowsMenu")]
	private ToolStripMenuItem _WindowsMenu;

	[AccessedThroughProperty("CascadeToolStripMenuItem")]
	private ToolStripMenuItem _CascadeToolStripMenuItem;

	[AccessedThroughProperty("TileVerticalToolStripMenuItem")]
	private ToolStripMenuItem _TileVerticalToolStripMenuItem;

	[AccessedThroughProperty("TileHorizontalToolStripMenuItem")]
	private ToolStripMenuItem _TileHorizontalToolStripMenuItem;

	[AccessedThroughProperty("OptionsToolStripMenuItem")]
	private ToolStripMenuItem _OptionsToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripButton")]
	private ToolStripButton _HelpToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("PrintPreviewToolStripButton")]
	private ToolStripButton _PrintPreviewToolStripButton;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("ToolStripStatusLabel")]
	private ToolStripStatusLabel _ToolStripStatusLabel;

	[AccessedThroughProperty("StatusStrip")]
	private StatusStrip _StatusStrip;

	[AccessedThroughProperty("PrintToolStripButton")]
	private ToolStripButton _PrintToolStripButton;

	[AccessedThroughProperty("NewToolStripButton")]
	private ToolStripButton _NewToolStripButton;

	[AccessedThroughProperty("ToolStrip")]
	private ToolStrip _ToolStrip;

	[AccessedThroughProperty("OpenToolStripButton")]
	private ToolStripButton _OpenToolStripButton;

	[AccessedThroughProperty("SaveToolStripButton")]
	private ToolStripButton _SaveToolStripButton;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("PrintPreviewToolStripMenuItem")]
	private ToolStripMenuItem _PrintPreviewToolStripMenuItem;

	[AccessedThroughProperty("PrintToolStripMenuItem")]
	private ToolStripMenuItem _PrintToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("PrintSetupToolStripMenuItem")]
	private ToolStripMenuItem _PrintSetupToolStripMenuItem;

	[AccessedThroughProperty("SaveAsToolStripMenuItem")]
	private ToolStripMenuItem _SaveAsToolStripMenuItem;

	[AccessedThroughProperty("NewToolStripMenuItem")]
	private ToolStripMenuItem _NewToolStripMenuItem;

	[AccessedThroughProperty("FileMenu")]
	private ToolStripMenuItem _FileMenu;

	[AccessedThroughProperty("OpenToolStripMenuItem")]
	private ToolStripMenuItem _OpenToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("MenuStrip")]
	private MenuStrip _MenuStrip;

	[AccessedThroughProperty("EditMenu")]
	private ToolStripMenuItem _EditMenu;

	[AccessedThroughProperty("UndoToolStripMenuItem")]
	private ToolStripMenuItem _UndoToolStripMenuItem;

	[AccessedThroughProperty("RedoToolStripMenuItem")]
	private ToolStripMenuItem _RedoToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("CutToolStripMenuItem")]
	private ToolStripMenuItem _CutToolStripMenuItem;

	[AccessedThroughProperty("CopyToolStripMenuItem")]
	private ToolStripMenuItem _CopyToolStripMenuItem;

	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("ViewMenu")]
	private ToolStripMenuItem _ViewMenu;

	[AccessedThroughProperty("ToolBarToolStripMenuItem")]
	private ToolStripMenuItem _ToolBarToolStripMenuItem;

	[AccessedThroughProperty("StatusBarToolStripMenuItem")]
	private ToolStripMenuItem _StatusBarToolStripMenuItem;

	[AccessedThroughProperty("ToolsMenu")]
	private ToolStripMenuItem _ToolsMenu;

	[AccessedThroughProperty("TransMenu")]
	private ToolStripMenuItem _TransMenu;

	[AccessedThroughProperty("ReportMenu")]
	private ToolStripMenuItem _ReportMenu;

	[AccessedThroughProperty("SetupMenu")]
	private ToolStripMenuItem _SetupMenu;

	[AccessedThroughProperty("EnterBillToolStripMenuItem")]
	private ToolStripMenuItem _EnterBillToolStripMenuItem;

	[AccessedThroughProperty("ReverseBillsToolStripMenuItem")]
	private ToolStripMenuItem _ReverseBillsToolStripMenuItem;

	[AccessedThroughProperty("CustomerCategoryListToolStripMenuItem")]
	private ToolStripMenuItem _CustomerCategoryListToolStripMenuItem;

	[AccessedThroughProperty("CustomerListToolStripMenuItem")]
	private ToolStripMenuItem _CustomerListToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripSeparator _ToolStripMenuItem1;

	[AccessedThroughProperty("CustomerStatementsToolStripMenuItem")]
	private ToolStripMenuItem _CustomerStatementsToolStripMenuItem;

	[AccessedThroughProperty("ConsolidatedStatementsToolStripMenuItem")]
	private ToolStripMenuItem _ConsolidatedStatementsToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripSeparator _ToolStripMenuItem2;

	[AccessedThroughProperty("ChartOfAccountsToolStripMenuItem")]
	private ToolStripMenuItem _ChartOfAccountsToolStripMenuItem;

	[AccessedThroughProperty("CustomerCategoryToolStripMenuItem")]
	private ToolStripMenuItem _CustomerCategoryToolStripMenuItem;

	[AccessedThroughProperty("CustomerAccountToolStripMenuItem")]
	private ToolStripMenuItem _CustomerAccountToolStripMenuItem;

	[AccessedThroughProperty("ProductsServicesToolStripMenuItem")]
	private ToolStripMenuItem _ProductsServicesToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripSeparator _ToolStripMenuItem3;

	[AccessedThroughProperty("ProductsToolStripMenuItem")]
	private ToolStripMenuItem _ProductsToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripSeparator _ToolStripMenuItem4;

	[AccessedThroughProperty("ChartOfAccountsToolStripMenuItem1")]
	private ToolStripMenuItem _ChartOfAccountsToolStripMenuItem1;

	[AccessedThroughProperty("RestoreDataToolStripMenuItem")]
	private ToolStripMenuItem _RestoreDataToolStripMenuItem;

	[AccessedThroughProperty("ToolStripMenuItem5")]
	private ToolStripSeparator _ToolStripMenuItem5;

	[AccessedThroughProperty("CloseFinancePeriodToolStripMenuItem")]
	private ToolStripMenuItem _CloseFinancePeriodToolStripMenuItem;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[AccessedThroughProperty("ToolStripSeparator9")]
	private ToolStripSeparator _ToolStripSeparator9;

	[AccessedThroughProperty("Companyemployee")]
	private ToolStripMenuItem _Companyemployee;

	private int m_ChildFormNumber;

	internal virtual ToolStripMenuItem ContentsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContentsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContentsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem HelpMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _HelpMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HelpMenu = value;
		}
	}

	internal virtual ToolStripMenuItem IndexToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _IndexToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_IndexToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SearchToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SearchToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SearchToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator8 = value;
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_AboutToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ArrangeIconsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ArrangeIconsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).remove_Click((EventHandler)ArrangeIconsToolStripMenuItem_Click);
			}
			_ArrangeIconsToolStripMenuItem = value;
			if (_ArrangeIconsToolStripMenuItem != null)
			{
				((ToolStripItem)_ArrangeIconsToolStripMenuItem).add_Click((EventHandler)ArrangeIconsToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem CloseAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).remove_Click((EventHandler)CloseAllToolStripMenuItem_Click);
			}
			_CloseAllToolStripMenuItem = value;
			if (_CloseAllToolStripMenuItem != null)
			{
				((ToolStripItem)_CloseAllToolStripMenuItem).add_Click((EventHandler)CloseAllToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem NewWindowToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewWindowToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).remove_Click((EventHandler)ShowNewForm);
			}
			_NewWindowToolStripMenuItem = value;
			if (_NewWindowToolStripMenuItem != null)
			{
				((ToolStripItem)_NewWindowToolStripMenuItem).add_Click((EventHandler)ShowNewForm);
			}
		}
	}

	internal virtual ToolStripMenuItem WindowsMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _WindowsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WindowsMenu = value;
		}
	}

	internal virtual ToolStripMenuItem CascadeToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CascadeToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).remove_Click((EventHandler)CascadeToolStripMenuItem_Click);
			}
			_CascadeToolStripMenuItem = value;
			if (_CascadeToolStripMenuItem != null)
			{
				((ToolStripItem)_CascadeToolStripMenuItem).add_Click((EventHandler)CascadeToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem TileVerticalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TileVerticalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).remove_Click((EventHandler)TileVerticleToolStripMenuItem_Click);
			}
			_TileVerticalToolStripMenuItem = value;
			if (_TileVerticalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileVerticalToolStripMenuItem).add_Click((EventHandler)TileVerticleToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem TileHorizontalToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _TileHorizontalToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).remove_Click((EventHandler)TileHorizontalToolStripMenuItem_Click);
			}
			_TileHorizontalToolStripMenuItem = value;
			if (_TileHorizontalToolStripMenuItem != null)
			{
				((ToolStripItem)_TileHorizontalToolStripMenuItem).add_Click((EventHandler)TileHorizontalToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem OptionsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OptionsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_OptionsToolStripMenuItem != null)
			{
				((ToolStripItem)_OptionsToolStripMenuItem).remove_Click((EventHandler)OptionsToolStripMenuItem_Click);
			}
			_OptionsToolStripMenuItem = value;
			if (_OptionsToolStripMenuItem != null)
			{
				((ToolStripItem)_OptionsToolStripMenuItem).add_Click((EventHandler)OptionsToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripButton HelpToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _HelpToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HelpToolStripButton = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripButton PrintPreviewToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewToolStripButton = value;
		}
	}

	internal virtual ToolTip ToolTip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel = value;
		}
	}

	internal virtual StatusStrip StatusStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip = value;
		}
	}

	internal virtual ToolStripButton PrintToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintToolStripButton = value;
		}
	}

	internal virtual ToolStripButton NewToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).remove_Click((EventHandler)ShowNewForm);
			}
			_NewToolStripButton = value;
			if (_NewToolStripButton != null)
			{
				((ToolStripItem)_NewToolStripButton).add_Click((EventHandler)ShowNewForm);
			}
		}
	}

	internal virtual ToolStrip ToolStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStrip = value;
		}
	}

	internal virtual ToolStripButton OpenToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).remove_Click((EventHandler)OpenFile);
			}
			_OpenToolStripButton = value;
			if (_OpenToolStripButton != null)
			{
				((ToolStripItem)_OpenToolStripButton).add_Click((EventHandler)OpenFile);
			}
		}
	}

	internal virtual ToolStripButton SaveToolStripButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveToolStripButton = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintPreviewToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintPreviewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintPreviewToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem PrintToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).remove_Click((EventHandler)ExitToolsStripMenuItem_Click);
			}
			_ExitToolStripMenuItem = value;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).add_Click((EventHandler)ExitToolsStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal virtual ToolStripMenuItem PrintSetupToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PrintSetupToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PrintSetupToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem SaveAsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveAsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).remove_Click((EventHandler)SaveAsToolStripMenuItem_Click);
			}
			_SaveAsToolStripMenuItem = value;
			if (_SaveAsToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveAsToolStripMenuItem).add_Click((EventHandler)SaveAsToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem NewToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _NewToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).remove_Click((EventHandler)ShowNewForm);
			}
			_NewToolStripMenuItem = value;
			if (_NewToolStripMenuItem != null)
			{
				((ToolStripItem)_NewToolStripMenuItem).add_Click((EventHandler)ShowNewForm);
			}
		}
	}

	internal virtual ToolStripMenuItem FileMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FileMenu = value;
		}
	}

	internal virtual ToolStripMenuItem OpenToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).remove_Click((EventHandler)OpenFile);
			}
			_OpenToolStripMenuItem = value;
			if (_OpenToolStripMenuItem != null)
			{
				((ToolStripItem)_OpenToolStripMenuItem).add_Click((EventHandler)OpenFile);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual ToolStripMenuItem SaveToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveToolStripMenuItem = value;
		}
	}

	internal virtual MenuStrip MenuStrip
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip = value;
		}
	}

	internal virtual ToolStripMenuItem EditMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _EditMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EditMenu = value;
		}
	}

	internal virtual ToolStripMenuItem UndoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _UndoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_UndoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem RedoToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RedoToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RedoToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator6 = value;
		}
	}

	internal virtual ToolStripMenuItem CutToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).remove_Click((EventHandler)CutToolStripMenuItem_Click);
			}
			_CutToolStripMenuItem = value;
			if (_CutToolStripMenuItem != null)
			{
				((ToolStripItem)_CutToolStripMenuItem).add_Click((EventHandler)CutToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem CopyToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).remove_Click((EventHandler)CopyToolStripMenuItem_Click);
			}
			_CopyToolStripMenuItem = value;
			if (_CopyToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyToolStripMenuItem).add_Click((EventHandler)CopyToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem PasteToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _PasteToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).remove_Click((EventHandler)PasteToolStripMenuItem_Click);
			}
			_PasteToolStripMenuItem = value;
			if (_PasteToolStripMenuItem != null)
			{
				((ToolStripItem)_PasteToolStripMenuItem).add_Click((EventHandler)PasteToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator7 = value;
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SelectAllToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ViewMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ViewMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ViewMenu = value;
		}
	}

	internal virtual ToolStripMenuItem ToolBarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).remove_Click((EventHandler)ToolBarToolStripMenuItem_Click);
			}
			_ToolBarToolStripMenuItem = value;
			if (_ToolBarToolStripMenuItem != null)
			{
				((ToolStripItem)_ToolBarToolStripMenuItem).add_Click((EventHandler)ToolBarToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem StatusBarToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusBarToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).remove_Click((EventHandler)StatusBarToolStripMenuItem_Click);
			}
			_StatusBarToolStripMenuItem = value;
			if (_StatusBarToolStripMenuItem != null)
			{
				((ToolStripItem)_StatusBarToolStripMenuItem).add_Click((EventHandler)StatusBarToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolsMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolsMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolsMenu = value;
		}
	}

	internal virtual ToolStripMenuItem TransMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _TransMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TransMenu = value;
		}
	}

	internal virtual ToolStripMenuItem ReportMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReportMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReportMenu = value;
		}
	}

	internal virtual ToolStripMenuItem SetupMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _SetupMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SetupMenu = value;
		}
	}

	internal virtual ToolStripMenuItem EnterBillToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EnterBillToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_EnterBillToolStripMenuItem != null)
			{
				((ToolStripItem)_EnterBillToolStripMenuItem).remove_Click((EventHandler)EnterBillToolStripMenuItem_Click);
			}
			_EnterBillToolStripMenuItem = value;
			if (_EnterBillToolStripMenuItem != null)
			{
				((ToolStripItem)_EnterBillToolStripMenuItem).add_Click((EventHandler)EnterBillToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem ReverseBillsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ReverseBillsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ReverseBillsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem CustomerCategoryListToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CustomerCategoryListToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CustomerCategoryListToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem CustomerListToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CustomerListToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CustomerListToolStripMenuItem != null)
			{
				((ToolStripItem)_CustomerListToolStripMenuItem).remove_Click((EventHandler)CustomerListToolStripMenuItem_Click);
			}
			_CustomerListToolStripMenuItem = value;
			if (_CustomerListToolStripMenuItem != null)
			{
				((ToolStripItem)_CustomerListToolStripMenuItem).add_Click((EventHandler)CustomerListToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem1 = value;
		}
	}

	internal virtual ToolStripMenuItem CustomerStatementsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CustomerStatementsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CustomerStatementsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ConsolidatedStatementsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ConsolidatedStatementsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ConsolidatedStatementsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripMenuItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem2 = value;
		}
	}

	internal virtual ToolStripMenuItem ChartOfAccountsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChartOfAccountsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ChartOfAccountsToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem CustomerCategoryToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CustomerCategoryToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CustomerCategoryToolStripMenuItem != null)
			{
				((ToolStripItem)_CustomerCategoryToolStripMenuItem).remove_Click((EventHandler)CustomerCategoryToolStripMenuItem_Click);
			}
			_CustomerCategoryToolStripMenuItem = value;
			if (_CustomerCategoryToolStripMenuItem != null)
			{
				((ToolStripItem)_CustomerCategoryToolStripMenuItem).add_Click((EventHandler)CustomerCategoryToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem CustomerAccountToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CustomerAccountToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_CustomerAccountToolStripMenuItem != null)
			{
				((ToolStripItem)_CustomerAccountToolStripMenuItem).remove_Click((EventHandler)CustomerAccountToolStripMenuItem_Click);
			}
			_CustomerAccountToolStripMenuItem = value;
			if (_CustomerAccountToolStripMenuItem != null)
			{
				((ToolStripItem)_CustomerAccountToolStripMenuItem).add_Click((EventHandler)CustomerAccountToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem ProductsServicesToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProductsServicesToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ProductsServicesToolStripMenuItem != null)
			{
				((ToolStripItem)_ProductsServicesToolStripMenuItem).remove_Click((EventHandler)ProductsServicesToolStripMenuItem_Click);
			}
			_ProductsServicesToolStripMenuItem = value;
			if (_ProductsServicesToolStripMenuItem != null)
			{
				((ToolStripItem)_ProductsServicesToolStripMenuItem).add_Click((EventHandler)ProductsServicesToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripMenuItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem3 = value;
		}
	}

	internal virtual ToolStripMenuItem ProductsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProductsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ProductsToolStripMenuItem != null)
			{
				((ToolStripItem)_ProductsToolStripMenuItem).remove_Click((EventHandler)ProductsToolStripMenuItem_Click);
			}
			_ProductsToolStripMenuItem = value;
			if (_ProductsToolStripMenuItem != null)
			{
				((ToolStripItem)_ProductsToolStripMenuItem).add_Click((EventHandler)ProductsToolStripMenuItem_Click);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripMenuItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem4 = value;
		}
	}

	internal virtual ToolStripMenuItem ChartOfAccountsToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ChartOfAccountsToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_ChartOfAccountsToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ChartOfAccountsToolStripMenuItem1).remove_Click((EventHandler)ChartOfAccountsToolStripMenuItem1_Click);
			}
			_ChartOfAccountsToolStripMenuItem1 = value;
			if (_ChartOfAccountsToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ChartOfAccountsToolStripMenuItem1).add_Click((EventHandler)ChartOfAccountsToolStripMenuItem1_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem RestoreDataToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RestoreDataToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RestoreDataToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripMenuItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem5 = value;
		}
	}

	internal virtual ToolStripMenuItem CloseFinancePeriodToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CloseFinancePeriodToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CloseFinancePeriodToolStripMenuItem = value;
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel1 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel2 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel3 = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel4 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator9 = value;
		}
	}

	internal virtual ToolStripMenuItem Companyemployee
	{
		[DebuggerNonUserCode]
		get
		{
			return _Companyemployee;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Companyemployee != null)
			{
				((ToolStripItem)_Companyemployee).remove_Click((EventHandler)Companyemployee_Click);
			}
			_Companyemployee = value;
			if (_Companyemployee != null)
			{
				((ToolStripItem)_Companyemployee).add_Click((EventHandler)Companyemployee_Click);
			}
		}
	}

	public frmMain()
	{
		((Form)this).add_Load((EventHandler)frmMain_Load);
		__ENCList.Add(new WeakReference(this));
		m_ChildFormNumber = 0;
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e4: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a90: Expected O, but got Unknown
		//IL_0afb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected O, but got Unknown
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7a: Expected O, but got Unknown
		//IL_16d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16df: Expected O, but got Unknown
		//IL_173a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1744: Expected O, but got Unknown
		//IL_18ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d4: Expected O, but got Unknown
		//IL_1938: Unknown result type (might be due to invalid IL or missing references)
		//IL_1942: Expected O, but got Unknown
		//IL_19a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b0: Expected O, but got Unknown
		//IL_1a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a44: Expected O, but got Unknown
		//IL_1aa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab2: Expected O, but got Unknown
		//IL_1b3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		MenuStrip = new MenuStrip();
		FileMenu = new ToolStripMenuItem();
		NewToolStripMenuItem = new ToolStripMenuItem();
		OpenToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		SaveAsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		PrintToolStripMenuItem = new ToolStripMenuItem();
		PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
		PrintSetupToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		EditMenu = new ToolStripMenuItem();
		UndoToolStripMenuItem = new ToolStripMenuItem();
		RedoToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator6 = new ToolStripSeparator();
		CutToolStripMenuItem = new ToolStripMenuItem();
		CopyToolStripMenuItem = new ToolStripMenuItem();
		PasteToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator7 = new ToolStripSeparator();
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		ViewMenu = new ToolStripMenuItem();
		ToolBarToolStripMenuItem = new ToolStripMenuItem();
		StatusBarToolStripMenuItem = new ToolStripMenuItem();
		TransMenu = new ToolStripMenuItem();
		EnterBillToolStripMenuItem = new ToolStripMenuItem();
		ReverseBillsToolStripMenuItem = new ToolStripMenuItem();
		ReportMenu = new ToolStripMenuItem();
		CustomerCategoryListToolStripMenuItem = new ToolStripMenuItem();
		CustomerListToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem1 = new ToolStripSeparator();
		CustomerStatementsToolStripMenuItem = new ToolStripMenuItem();
		ConsolidatedStatementsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripSeparator();
		ChartOfAccountsToolStripMenuItem = new ToolStripMenuItem();
		SetupMenu = new ToolStripMenuItem();
		CustomerCategoryToolStripMenuItem = new ToolStripMenuItem();
		CustomerAccountToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem3 = new ToolStripSeparator();
		Companyemployee = new ToolStripMenuItem();
		ToolStripSeparator9 = new ToolStripSeparator();
		ProductsServicesToolStripMenuItem = new ToolStripMenuItem();
		ProductsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripSeparator();
		ChartOfAccountsToolStripMenuItem1 = new ToolStripMenuItem();
		ToolsMenu = new ToolStripMenuItem();
		OptionsToolStripMenuItem = new ToolStripMenuItem();
		RestoreDataToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem5 = new ToolStripSeparator();
		CloseFinancePeriodToolStripMenuItem = new ToolStripMenuItem();
		WindowsMenu = new ToolStripMenuItem();
		NewWindowToolStripMenuItem = new ToolStripMenuItem();
		CascadeToolStripMenuItem = new ToolStripMenuItem();
		TileVerticalToolStripMenuItem = new ToolStripMenuItem();
		TileHorizontalToolStripMenuItem = new ToolStripMenuItem();
		CloseAllToolStripMenuItem = new ToolStripMenuItem();
		ArrangeIconsToolStripMenuItem = new ToolStripMenuItem();
		HelpMenu = new ToolStripMenuItem();
		ContentsToolStripMenuItem = new ToolStripMenuItem();
		IndexToolStripMenuItem = new ToolStripMenuItem();
		SearchToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator8 = new ToolStripSeparator();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ToolStrip = new ToolStrip();
		NewToolStripButton = new ToolStripButton();
		OpenToolStripButton = new ToolStripButton();
		SaveToolStripButton = new ToolStripButton();
		ToolStripSeparator1 = new ToolStripSeparator();
		PrintToolStripButton = new ToolStripButton();
		PrintPreviewToolStripButton = new ToolStripButton();
		ToolStripSeparator2 = new ToolStripSeparator();
		HelpToolStripButton = new ToolStripButton();
		StatusStrip = new StatusStrip();
		ToolStripStatusLabel = new ToolStripStatusLabel();
		ToolTip = new ToolTip(components);
		StatusStrip1 = new StatusStrip();
		ToolStripStatusLabel1 = new ToolStripStatusLabel();
		ToolStripStatusLabel2 = new ToolStripStatusLabel();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		ToolStripStatusLabel4 = new ToolStripStatusLabel();
		((Control)MenuStrip).SuspendLayout();
		((Control)ToolStrip).SuspendLayout();
		((Control)StatusStrip).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)MenuStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)FileMenu,
			(ToolStripItem)EditMenu,
			(ToolStripItem)ViewMenu,
			(ToolStripItem)TransMenu,
			(ToolStripItem)ReportMenu,
			(ToolStripItem)SetupMenu,
			(ToolStripItem)ToolsMenu,
			(ToolStripItem)WindowsMenu,
			(ToolStripItem)HelpMenu
		});
		MenuStrip menuStrip = MenuStrip;
		Point location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		MenuStrip.set_MdiWindowListItem(WindowsMenu);
		((Control)MenuStrip).set_Name("MenuStrip");
		MenuStrip menuStrip2 = MenuStrip;
		Size size = new Size(632, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip).set_TabIndex(5);
		((Control)MenuStrip).set_Text("MenuStrip");
		((ToolStripDropDownItem)FileMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)NewToolStripMenuItem,
			(ToolStripItem)OpenToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)SaveToolStripMenuItem,
			(ToolStripItem)SaveAsToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)PrintToolStripMenuItem,
			(ToolStripItem)PrintPreviewToolStripMenuItem,
			(ToolStripItem)PrintSetupToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)ExitToolStripMenuItem
		});
		((ToolStripItem)FileMenu).set_ImageTransparentColor(SystemColors.ActiveBorder);
		((ToolStripItem)FileMenu).set_Name("FileMenu");
		ToolStripMenuItem fileMenu = FileMenu;
		size = new Size(35, 20);
		((ToolStripItem)fileMenu).set_Size(size);
		((ToolStripItem)FileMenu).set_Text("&File");
		((ToolStripItem)NewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("NewToolStripMenuItem.Image"));
		((ToolStripItem)NewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripMenuItem).set_Name("NewToolStripMenuItem");
		NewToolStripMenuItem.set_ShortcutKeys((Keys)131150);
		ToolStripMenuItem newToolStripMenuItem = NewToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)newToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewToolStripMenuItem).set_Text("&New");
		((ToolStripItem)OpenToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("OpenToolStripMenuItem.Image"));
		((ToolStripItem)OpenToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripMenuItem).set_Name("OpenToolStripMenuItem");
		OpenToolStripMenuItem.set_ShortcutKeys((Keys)131151);
		ToolStripMenuItem openToolStripMenuItem = OpenToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)openToolStripMenuItem).set_Size(size);
		((ToolStripItem)OpenToolStripMenuItem).set_Text("&Open");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator3;
		size = new Size(148, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SaveToolStripMenuItem.Image"));
		((ToolStripItem)SaveToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		SaveToolStripMenuItem.set_ShortcutKeys((Keys)131155);
		ToolStripMenuItem saveToolStripMenuItem = SaveToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)saveToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("&Save");
		((ToolStripItem)SaveAsToolStripMenuItem).set_Name("SaveAsToolStripMenuItem");
		ToolStripMenuItem saveAsToolStripMenuItem = SaveAsToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)saveAsToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveAsToolStripMenuItem).set_Text("Save &As");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator4;
		size = new Size(148, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintToolStripMenuItem.Image"));
		((ToolStripItem)PrintToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripMenuItem).set_Name("PrintToolStripMenuItem");
		PrintToolStripMenuItem.set_ShortcutKeys((Keys)131152);
		ToolStripMenuItem printToolStripMenuItem = PrintToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)printToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintToolStripMenuItem).set_Text("&Print");
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripMenuItem.Image"));
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Name("PrintPreviewToolStripMenuItem");
		ToolStripMenuItem printPreviewToolStripMenuItem = PrintPreviewToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)printPreviewToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripMenuItem).set_Text("Print Pre&view");
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Name("PrintSetupToolStripMenuItem");
		ToolStripMenuItem printSetupToolStripMenuItem = PrintSetupToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)printSetupToolStripMenuItem).set_Size(size);
		((ToolStripItem)PrintSetupToolStripMenuItem).set_Text("Print Setup");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator5;
		size = new Size(148, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(151, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("E&xit");
		((ToolStripDropDownItem)EditMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)UndoToolStripMenuItem,
			(ToolStripItem)RedoToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)CutToolStripMenuItem,
			(ToolStripItem)CopyToolStripMenuItem,
			(ToolStripItem)PasteToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)SelectAllToolStripMenuItem
		});
		((ToolStripItem)EditMenu).set_Name("EditMenu");
		ToolStripMenuItem editMenu = EditMenu;
		size = new Size(37, 20);
		((ToolStripItem)editMenu).set_Size(size);
		((ToolStripItem)EditMenu).set_Text("&Edit");
		((ToolStripItem)UndoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("UndoToolStripMenuItem.Image"));
		((ToolStripItem)UndoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)UndoToolStripMenuItem).set_Name("UndoToolStripMenuItem");
		UndoToolStripMenuItem.set_ShortcutKeys((Keys)131162);
		ToolStripMenuItem undoToolStripMenuItem = UndoToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)undoToolStripMenuItem).set_Size(size);
		((ToolStripItem)UndoToolStripMenuItem).set_Text("&Undo");
		((ToolStripItem)RedoToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("RedoToolStripMenuItem.Image"));
		((ToolStripItem)RedoToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)RedoToolStripMenuItem).set_Name("RedoToolStripMenuItem");
		RedoToolStripMenuItem.set_ShortcutKeys((Keys)131161);
		ToolStripMenuItem redoToolStripMenuItem = RedoToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)redoToolStripMenuItem).set_Size(size);
		((ToolStripItem)RedoToolStripMenuItem).set_Text("&Redo");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator6;
		size = new Size(164, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image"));
		((ToolStripItem)CutToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CutToolStripMenuItem).set_Name("CutToolStripMenuItem");
		CutToolStripMenuItem.set_ShortcutKeys((Keys)131160);
		ToolStripMenuItem cutToolStripMenuItem = CutToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)cutToolStripMenuItem).set_Size(size);
		((ToolStripItem)CutToolStripMenuItem).set_Text("Cu&t");
		((ToolStripItem)CopyToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image"));
		((ToolStripItem)CopyToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)CopyToolStripMenuItem).set_Name("CopyToolStripMenuItem");
		CopyToolStripMenuItem.set_ShortcutKeys((Keys)131139);
		ToolStripMenuItem copyToolStripMenuItem = CopyToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)copyToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyToolStripMenuItem).set_Text("&Copy");
		((ToolStripItem)PasteToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image"));
		((ToolStripItem)PasteToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PasteToolStripMenuItem).set_Name("PasteToolStripMenuItem");
		PasteToolStripMenuItem.set_ShortcutKeys((Keys)131158);
		ToolStripMenuItem pasteToolStripMenuItem = PasteToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)pasteToolStripMenuItem).set_Size(size);
		((ToolStripItem)PasteToolStripMenuItem).set_Text("&Paste");
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator7;
		size = new Size(164, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		SelectAllToolStripMenuItem.set_ShortcutKeys((Keys)131137);
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(167, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select &All");
		((ToolStripDropDownItem)ViewMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ToolBarToolStripMenuItem,
			(ToolStripItem)StatusBarToolStripMenuItem
		});
		((ToolStripItem)ViewMenu).set_Name("ViewMenu");
		ToolStripMenuItem viewMenu = ViewMenu;
		size = new Size(41, 20);
		((ToolStripItem)viewMenu).set_Size(size);
		((ToolStripItem)ViewMenu).set_Text("&View");
		ToolBarToolStripMenuItem.set_Checked(true);
		ToolBarToolStripMenuItem.set_CheckOnClick(true);
		ToolBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Name("ToolBarToolStripMenuItem");
		ToolStripMenuItem toolBarToolStripMenuItem = ToolBarToolStripMenuItem;
		size = new Size(135, 22);
		((ToolStripItem)toolBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolBarToolStripMenuItem).set_Text("&Toolbar");
		StatusBarToolStripMenuItem.set_Checked(true);
		StatusBarToolStripMenuItem.set_CheckOnClick(true);
		StatusBarToolStripMenuItem.set_CheckState((CheckState)1);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Name("StatusBarToolStripMenuItem");
		ToolStripMenuItem statusBarToolStripMenuItem = StatusBarToolStripMenuItem;
		size = new Size(135, 22);
		((ToolStripItem)statusBarToolStripMenuItem).set_Size(size);
		((ToolStripItem)StatusBarToolStripMenuItem).set_Text("&Status Bar");
		((ToolStripDropDownItem)TransMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)EnterBillToolStripMenuItem,
			(ToolStripItem)ReverseBillsToolStripMenuItem
		});
		((ToolStripItem)TransMenu).set_Name("TransMenu");
		ToolStripMenuItem transMenu = TransMenu;
		size = new Size(80, 20);
		((ToolStripItem)transMenu).set_Size(size);
		((ToolStripItem)TransMenu).set_Text("Transactions");
		((ToolStripItem)EnterBillToolStripMenuItem).set_Name("EnterBillToolStripMenuItem");
		EnterBillToolStripMenuItem.set_ShortcutKeys((Keys)131138);
		ToolStripMenuItem enterBillToolStripMenuItem = EnterBillToolStripMenuItem;
		size = new Size(184, 22);
		((ToolStripItem)enterBillToolStripMenuItem).set_Size(size);
		((ToolStripItem)EnterBillToolStripMenuItem).set_Text("Enter Bills");
		((ToolStripItem)ReverseBillsToolStripMenuItem).set_Name("ReverseBillsToolStripMenuItem");
		ReverseBillsToolStripMenuItem.set_ShortcutKeys((Keys)131154);
		ToolStripMenuItem reverseBillsToolStripMenuItem = ReverseBillsToolStripMenuItem;
		size = new Size(184, 22);
		((ToolStripItem)reverseBillsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ReverseBillsToolStripMenuItem).set_Text("Reverse Bills");
		((ToolStripDropDownItem)ReportMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[7]
		{
			(ToolStripItem)CustomerCategoryListToolStripMenuItem,
			(ToolStripItem)CustomerListToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)CustomerStatementsToolStripMenuItem,
			(ToolStripItem)ConsolidatedStatementsToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ChartOfAccountsToolStripMenuItem
		});
		((ToolStripItem)ReportMenu).set_Name("ReportMenu");
		ToolStripMenuItem reportMenu = ReportMenu;
		size = new Size(57, 20);
		((ToolStripItem)reportMenu).set_Size(size);
		((ToolStripItem)ReportMenu).set_Text("&Reports");
		((ToolStripItem)CustomerCategoryListToolStripMenuItem).set_Name("CustomerCategoryListToolStripMenuItem");
		ToolStripMenuItem customerCategoryListToolStripMenuItem = CustomerCategoryListToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)customerCategoryListToolStripMenuItem).set_Size(size);
		((ToolStripItem)CustomerCategoryListToolStripMenuItem).set_Text("Customer Category List");
		((ToolStripItem)CustomerListToolStripMenuItem).set_Name("CustomerListToolStripMenuItem");
		ToolStripMenuItem customerListToolStripMenuItem = CustomerListToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)customerListToolStripMenuItem).set_Size(size);
		((ToolStripItem)CustomerListToolStripMenuItem).set_Text("Customer Account List");
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripSeparator toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(202, 6);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)CustomerStatementsToolStripMenuItem).set_Name("CustomerStatementsToolStripMenuItem");
		ToolStripMenuItem customerStatementsToolStripMenuItem = CustomerStatementsToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)customerStatementsToolStripMenuItem).set_Size(size);
		((ToolStripItem)CustomerStatementsToolStripMenuItem).set_Text("Customer Statements");
		((ToolStripItem)ConsolidatedStatementsToolStripMenuItem).set_Name("ConsolidatedStatementsToolStripMenuItem");
		ToolStripMenuItem consolidatedStatementsToolStripMenuItem = ConsolidatedStatementsToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)consolidatedStatementsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ConsolidatedStatementsToolStripMenuItem).set_Text("Consolidated Statements");
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		ToolStripSeparator toolStripMenuItem2 = ToolStripMenuItem2;
		size = new Size(202, 6);
		((ToolStripItem)toolStripMenuItem2).set_Size(size);
		((ToolStripItem)ChartOfAccountsToolStripMenuItem).set_Name("ChartOfAccountsToolStripMenuItem");
		ToolStripMenuItem chartOfAccountsToolStripMenuItem = ChartOfAccountsToolStripMenuItem;
		size = new Size(205, 22);
		((ToolStripItem)chartOfAccountsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ChartOfAccountsToolStripMenuItem).set_Text("Chart of Accounts");
		((ToolStripDropDownItem)SetupMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)CustomerCategoryToolStripMenuItem,
			(ToolStripItem)CustomerAccountToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)Companyemployee,
			(ToolStripItem)ToolStripSeparator9,
			(ToolStripItem)ProductsServicesToolStripMenuItem,
			(ToolStripItem)ProductsToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem4,
			(ToolStripItem)ChartOfAccountsToolStripMenuItem1
		});
		((ToolStripItem)SetupMenu).set_Name("SetupMenu");
		ToolStripMenuItem setupMenu = SetupMenu;
		size = new Size(47, 20);
		((ToolStripItem)setupMenu).set_Size(size);
		((ToolStripItem)SetupMenu).set_Text("&Setup");
		((ToolStripItem)CustomerCategoryToolStripMenuItem).set_Name("CustomerCategoryToolStripMenuItem");
		ToolStripMenuItem customerCategoryToolStripMenuItem = CustomerCategoryToolStripMenuItem;
		size = new Size(236, 22);
		((ToolStripItem)customerCategoryToolStripMenuItem).set_Size(size);
		((ToolStripItem)CustomerCategoryToolStripMenuItem).set_Text("Company Category");
		((ToolStripItem)CustomerAccountToolStripMenuItem).set_Name("CustomerAccountToolStripMenuItem");
		ToolStripMenuItem customerAccountToolStripMenuItem = CustomerAccountToolStripMenuItem;
		size = new Size(236, 22);
		((ToolStripItem)customerAccountToolStripMenuItem).set_Size(size);
		((ToolStripItem)CustomerAccountToolStripMenuItem).set_Text("Company Account");
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		ToolStripSeparator toolStripMenuItem3 = ToolStripMenuItem3;
		size = new Size(233, 6);
		((ToolStripItem)toolStripMenuItem3).set_Size(size);
		((ToolStripItem)Companyemployee).set_Name("Companyemployee");
		ToolStripMenuItem companyemployee = Companyemployee;
		size = new Size(192, 22);
		((ToolStripItem)companyemployee).set_Size(size);
		((ToolStripItem)Companyemployee).set_Text("Employee  Account");
		((ToolStripItem)ToolStripSeparator9).set_Name("ToolStripSeparator9");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator9;
		size = new Size(233, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)ProductsServicesToolStripMenuItem).set_Name("ProductsServicesToolStripMenuItem");
		ToolStripMenuItem productsServicesToolStripMenuItem = ProductsServicesToolStripMenuItem;
		size = new Size(236, 22);
		((ToolStripItem)productsServicesToolStripMenuItem).set_Size(size);
		((ToolStripItem)ProductsServicesToolStripMenuItem).set_Text("Product Category");
		((ToolStripItem)ProductsToolStripMenuItem).set_Name("ProductsToolStripMenuItem");
		ToolStripMenuItem productsToolStripMenuItem = ProductsToolStripMenuItem;
		size = new Size(236, 22);
		((ToolStripItem)productsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ProductsToolStripMenuItem).set_Text("Products And Services");
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		ToolStripSeparator toolStripMenuItem4 = ToolStripMenuItem4;
		size = new Size(233, 6);
		((ToolStripItem)toolStripMenuItem4).set_Size(size);
		((ToolStripItem)ChartOfAccountsToolStripMenuItem1).set_Name("ChartOfAccountsToolStripMenuItem1");
		ToolStripMenuItem chartOfAccountsToolStripMenuItem2 = ChartOfAccountsToolStripMenuItem1;
		size = new Size(236, 22);
		((ToolStripItem)chartOfAccountsToolStripMenuItem2).set_Size(size);
		((ToolStripItem)ChartOfAccountsToolStripMenuItem1).set_Text("Chart of Accounts");
		((ToolStripDropDownItem)ToolsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)OptionsToolStripMenuItem,
			(ToolStripItem)RestoreDataToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem5,
			(ToolStripItem)CloseFinancePeriodToolStripMenuItem
		});
		((ToolStripItem)ToolsMenu).set_Name("ToolsMenu");
		ToolStripMenuItem toolsMenu = ToolsMenu;
		size = new Size(44, 20);
		((ToolStripItem)toolsMenu).set_Size(size);
		((ToolStripItem)ToolsMenu).set_Text("&Tools");
		((ToolStripItem)OptionsToolStripMenuItem).set_Name("OptionsToolStripMenuItem");
		ToolStripMenuItem optionsToolStripMenuItem = OptionsToolStripMenuItem;
		size = new Size(184, 22);
		((ToolStripItem)optionsToolStripMenuItem).set_Size(size);
		((ToolStripItem)OptionsToolStripMenuItem).set_Text("&Backup Data");
		((ToolStripItem)RestoreDataToolStripMenuItem).set_Name("RestoreDataToolStripMenuItem");
		ToolStripMenuItem restoreDataToolStripMenuItem = RestoreDataToolStripMenuItem;
		size = new Size(184, 22);
		((ToolStripItem)restoreDataToolStripMenuItem).set_Size(size);
		((ToolStripItem)RestoreDataToolStripMenuItem).set_Text("&Restore Data");
		((ToolStripItem)ToolStripMenuItem5).set_Name("ToolStripMenuItem5");
		ToolStripSeparator toolStripMenuItem5 = ToolStripMenuItem5;
		size = new Size(181, 6);
		((ToolStripItem)toolStripMenuItem5).set_Size(size);
		((ToolStripItem)CloseFinancePeriodToolStripMenuItem).set_Name("CloseFinancePeriodToolStripMenuItem");
		ToolStripMenuItem closeFinancePeriodToolStripMenuItem = CloseFinancePeriodToolStripMenuItem;
		size = new Size(184, 22);
		((ToolStripItem)closeFinancePeriodToolStripMenuItem).set_Size(size);
		((ToolStripItem)CloseFinancePeriodToolStripMenuItem).set_Text("Close Finance Period");
		((ToolStripDropDownItem)WindowsMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)NewWindowToolStripMenuItem,
			(ToolStripItem)CascadeToolStripMenuItem,
			(ToolStripItem)TileVerticalToolStripMenuItem,
			(ToolStripItem)TileHorizontalToolStripMenuItem,
			(ToolStripItem)CloseAllToolStripMenuItem,
			(ToolStripItem)ArrangeIconsToolStripMenuItem
		});
		((ToolStripItem)WindowsMenu).set_Name("WindowsMenu");
		ToolStripMenuItem windowsMenu = WindowsMenu;
		size = new Size(62, 20);
		((ToolStripItem)windowsMenu).set_Size(size);
		((ToolStripItem)WindowsMenu).set_Text("&Windows");
		((ToolStripItem)NewWindowToolStripMenuItem).set_Name("NewWindowToolStripMenuItem");
		ToolStripMenuItem newWindowToolStripMenuItem = NewWindowToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)newWindowToolStripMenuItem).set_Size(size);
		((ToolStripItem)NewWindowToolStripMenuItem).set_Text("&New Window");
		((ToolStripItem)CascadeToolStripMenuItem).set_Name("CascadeToolStripMenuItem");
		ToolStripMenuItem cascadeToolStripMenuItem = CascadeToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)cascadeToolStripMenuItem).set_Size(size);
		((ToolStripItem)CascadeToolStripMenuItem).set_Text("&Cascade");
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Name("TileVerticalToolStripMenuItem");
		ToolStripMenuItem tileVerticalToolStripMenuItem = TileVerticalToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)tileVerticalToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileVerticalToolStripMenuItem).set_Text("Tile &Vertical");
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Name("TileHorizontalToolStripMenuItem");
		ToolStripMenuItem tileHorizontalToolStripMenuItem = TileHorizontalToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)tileHorizontalToolStripMenuItem).set_Size(size);
		((ToolStripItem)TileHorizontalToolStripMenuItem).set_Text("Tile &Horizontal");
		((ToolStripItem)CloseAllToolStripMenuItem).set_Name("CloseAllToolStripMenuItem");
		ToolStripMenuItem closeAllToolStripMenuItem = CloseAllToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)closeAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)CloseAllToolStripMenuItem).set_Text("C&lose All");
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Name("ArrangeIconsToolStripMenuItem");
		ToolStripMenuItem arrangeIconsToolStripMenuItem = ArrangeIconsToolStripMenuItem;
		size = new Size(153, 22);
		((ToolStripItem)arrangeIconsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ArrangeIconsToolStripMenuItem).set_Text("&Arrange Icons");
		((ToolStripDropDownItem)HelpMenu).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ContentsToolStripMenuItem,
			(ToolStripItem)IndexToolStripMenuItem,
			(ToolStripItem)SearchToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpMenu).set_Name("HelpMenu");
		ToolStripMenuItem helpMenu = HelpMenu;
		size = new Size(40, 20);
		((ToolStripItem)helpMenu).set_Size(size);
		((ToolStripItem)HelpMenu).set_Text("&Help");
		((ToolStripItem)ContentsToolStripMenuItem).set_Name("ContentsToolStripMenuItem");
		ContentsToolStripMenuItem.set_ShortcutKeys((Keys)131184);
		ToolStripMenuItem contentsToolStripMenuItem = ContentsToolStripMenuItem;
		size = new Size(173, 22);
		((ToolStripItem)contentsToolStripMenuItem).set_Size(size);
		((ToolStripItem)ContentsToolStripMenuItem).set_Text("&Contents");
		((ToolStripItem)IndexToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("IndexToolStripMenuItem.Image"));
		((ToolStripItem)IndexToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)IndexToolStripMenuItem).set_Name("IndexToolStripMenuItem");
		ToolStripMenuItem indexToolStripMenuItem = IndexToolStripMenuItem;
		size = new Size(173, 22);
		((ToolStripItem)indexToolStripMenuItem).set_Size(size);
		((ToolStripItem)IndexToolStripMenuItem).set_Text("&Index");
		((ToolStripItem)SearchToolStripMenuItem).set_Image((Image)componentResourceManager.GetObject("SearchToolStripMenuItem.Image"));
		((ToolStripItem)SearchToolStripMenuItem).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SearchToolStripMenuItem).set_Name("SearchToolStripMenuItem");
		ToolStripMenuItem searchToolStripMenuItem = SearchToolStripMenuItem;
		size = new Size(173, 22);
		((ToolStripItem)searchToolStripMenuItem).set_Size(size);
		((ToolStripItem)SearchToolStripMenuItem).set_Text("&Search");
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator8;
		size = new Size(170, 6);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(173, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("&About ...");
		ToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)NewToolStripButton,
			(ToolStripItem)OpenToolStripButton,
			(ToolStripItem)SaveToolStripButton,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)PrintToolStripButton,
			(ToolStripItem)PrintPreviewToolStripButton,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)HelpToolStripButton
		});
		ToolStrip toolStrip = ToolStrip;
		location = new Point(0, 24);
		((Control)toolStrip).set_Location(location);
		((Control)ToolStrip).set_Name("ToolStrip");
		ToolStrip toolStrip2 = ToolStrip;
		size = new Size(632, 25);
		((Control)toolStrip2).set_Size(size);
		((Control)ToolStrip).set_TabIndex(6);
		((Control)ToolStrip).set_Text("ToolStrip");
		((ToolStripItem)NewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)NewToolStripButton).set_Image((Image)componentResourceManager.GetObject("NewToolStripButton.Image"));
		((ToolStripItem)NewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)NewToolStripButton).set_Name("NewToolStripButton");
		ToolStripButton newToolStripButton = NewToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)newToolStripButton).set_Size(size);
		((ToolStripItem)NewToolStripButton).set_Text("New");
		((ToolStripItem)OpenToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)OpenToolStripButton).set_Image((Image)componentResourceManager.GetObject("OpenToolStripButton.Image"));
		((ToolStripItem)OpenToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)OpenToolStripButton).set_Name("OpenToolStripButton");
		ToolStripButton openToolStripButton = OpenToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)openToolStripButton).set_Size(size);
		((ToolStripItem)OpenToolStripButton).set_Text("Open");
		((ToolStripItem)SaveToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)SaveToolStripButton).set_Image((Image)componentResourceManager.GetObject("SaveToolStripButton.Image"));
		((ToolStripItem)SaveToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)SaveToolStripButton).set_Name("SaveToolStripButton");
		ToolStripButton saveToolStripButton = SaveToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)saveToolStripButton).set_Size(size);
		((ToolStripItem)SaveToolStripButton).set_Text("Save");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator1;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)PrintToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintToolStripButton.Image"));
		((ToolStripItem)PrintToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintToolStripButton).set_Name("PrintToolStripButton");
		ToolStripButton printToolStripButton = PrintToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)printToolStripButton).set_Size(size);
		((ToolStripItem)PrintToolStripButton).set_Text("Print");
		((ToolStripItem)PrintPreviewToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)PrintPreviewToolStripButton).set_Image((Image)componentResourceManager.GetObject("PrintPreviewToolStripButton.Image"));
		((ToolStripItem)PrintPreviewToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)PrintPreviewToolStripButton).set_Name("PrintPreviewToolStripButton");
		ToolStripButton printPreviewToolStripButton = PrintPreviewToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)printPreviewToolStripButton).set_Size(size);
		((ToolStripItem)PrintPreviewToolStripButton).set_Text("Print Preview");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator9 = ToolStripSeparator2;
		size = new Size(6, 25);
		((ToolStripItem)toolStripSeparator9).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)HelpToolStripButton).set_Image((Image)componentResourceManager.GetObject("HelpToolStripButton.Image"));
		((ToolStripItem)HelpToolStripButton).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)HelpToolStripButton).set_Name("HelpToolStripButton");
		ToolStripButton helpToolStripButton = HelpToolStripButton;
		size = new Size(23, 22);
		((ToolStripItem)helpToolStripButton).set_Size(size);
		((ToolStripItem)HelpToolStripButton).set_Text("Help");
		((ToolStrip)StatusStrip).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripStatusLabel });
		StatusStrip statusStrip = StatusStrip;
		location = new Point(0, 431);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip).set_Name("StatusStrip");
		StatusStrip statusStrip2 = StatusStrip;
		size = new Size(632, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip).set_TabIndex(7);
		((Control)StatusStrip).set_Text("StatusStrip");
		((ToolStripItem)ToolStripStatusLabel).set_Name("ToolStripStatusLabel");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel;
		size = new Size(38, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel).set_Text("Status");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[4]
		{
			(ToolStripItem)ToolStripStatusLabel1,
			(ToolStripItem)ToolStripStatusLabel2,
			(ToolStripItem)ToolStripStatusLabel3,
			(ToolStripItem)ToolStripStatusLabel4
		});
		StatusStrip statusStrip3 = StatusStrip1;
		location = new Point(0, 409);
		((Control)statusStrip3).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip4 = StatusStrip1;
		size = new Size(632, 22);
		((Control)statusStrip4).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(9);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ToolStripStatusLabel1).set_Name("ToolStripStatusLabel1");
		ToolStripStatusLabel toolStripStatusLabel2 = ToolStripStatusLabel1;
		size = new Size(63, 17);
		((ToolStripItem)toolStripStatusLabel2).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel1).set_Text("User Name:");
		((ToolStripItem)ToolStripStatusLabel2).set_Name("ToolStripStatusLabel2");
		ToolStripStatusLabel toolStripStatusLabel3 = ToolStripStatusLabel2;
		size = new Size(29, 17);
		((ToolStripItem)toolStripStatusLabel3).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel2).set_Text("Time");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel4 = ToolStripStatusLabel3;
		size = new Size(34, 17);
		((ToolStripItem)toolStripStatusLabel4).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("Date:");
		((ToolStripItem)ToolStripStatusLabel4).set_Name("ToolStripStatusLabel4");
		ToolStripStatusLabel toolStripStatusLabel5 = ToolStripStatusLabel4;
		size = new Size(82, 17);
		((ToolStripItem)toolStripStatusLabel5).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel4).set_Text("Active Window:");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip);
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(MenuStrip);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Text("Hospital Billing");
		((Control)MenuStrip).ResumeLayout(false);
		((Control)MenuStrip).PerformLayout();
		((Control)ToolStrip).ResumeLayout(false);
		((Control)ToolStrip).PerformLayout();
		((Control)StatusStrip).ResumeLayout(false);
		((Control)StatusStrip).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void ShowNewForm(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		checked
		{
			m_ChildFormNumber++;
			val.set_Text("Window " + Conversions.ToString(m_ChildFormNumber));
			((Control)val).Show();
		}
	}

	private void OpenFile(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void CutToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)ToolStrip).set_Visible(ToolBarToolStripMenuItem.get_Checked());
	}

	private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)StatusStrip).set_Visible(StatusBarToolStripMenuItem.get_Checked());
	}

	private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}

	private void EnterBillToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void CustomerListToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void CustomerCategoryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmCustomerGroup frmCustomerGroup2 = new frmCustomerGroup();
		((Form)frmCustomerGroup2).set_MaximizeBox(false);
		((Form)frmCustomerGroup2).set_MinimizeBox(false);
		((Form)frmCustomerGroup2).set_StartPosition((FormStartPosition)1);
		((Form)frmCustomerGroup2).ShowDialog();
	}

	private void CustomerAccountToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmCustomer frmCustomer2 = new frmCustomer();
		((Form)frmCustomer2).set_MaximizeBox(false);
		((Form)frmCustomer2).set_MinimizeBox(false);
		((Form)frmCustomer2).set_StartPosition((FormStartPosition)1);
		((Form)frmCustomer2).ShowDialog();
	}

	private void ChartOfAccountsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmLedger frmLedger2 = new frmLedger();
		((Form)frmLedger2).set_MaximizeBox(false);
		((Form)frmLedger2).set_MinimizeBox(false);
		((Form)frmLedger2).set_StartPosition((FormStartPosition)1);
		((Form)frmLedger2).ShowDialog();
	}

	private void ProductsServicesToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmProductCategory frmProductCategory2 = new frmProductCategory();
		((Form)frmProductCategory2).set_MaximizeBox(false);
		((Form)frmProductCategory2).set_MinimizeBox(false);
		((Form)frmProductCategory2).set_StartPosition((FormStartPosition)1);
		((Form)frmProductCategory2).ShowDialog();
	}

	private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmProduct frmProduct2 = new frmProduct();
		((Form)frmProduct2).set_MaximizeBox(false);
		((Form)frmProduct2).set_MinimizeBox(false);
		((Form)frmProduct2).set_StartPosition((FormStartPosition)1);
		((Form)frmProduct2).ShowDialog();
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
	}

	private void Companyemployee_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		frmEmployee frmEmployee2 = new frmEmployee();
		((Form)frmEmployee2).set_MaximizeBox(false);
		((Form)frmEmployee2).set_MinimizeBox(false);
		((Form)frmEmployee2).set_StartPosition((FormStartPosition)1);
		((Form)frmEmployee2).ShowDialog();
	}
}
