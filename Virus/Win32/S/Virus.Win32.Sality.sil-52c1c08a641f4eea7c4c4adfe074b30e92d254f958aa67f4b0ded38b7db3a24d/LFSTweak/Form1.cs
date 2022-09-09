using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LFSTweak;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("enginecc_value")]
	private TextBox _enginecc_value;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("currentCar")]
	private Label _currentCar;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("enginecylinders_value")]
	private TextBox _enginecylinders_value;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("enginetype_value")]
	private ComboBox _enginetype_value;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("engineturbo_value")]
	private ComboBox _engineturbo_value;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("engineturbopressure_value")]
	private TextBox _engineturbopressure_value;

	[AccessedThroughProperty("engineturbolag_value")]
	private TextBox _engineturbolag_value;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("enginetorque_value")]
	private TextBox _enginetorque_value;

	[AccessedThroughProperty("torque")]
	private Label _torque;

	[AccessedThroughProperty("applyButton")]
	private Button _applyButton;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("transmissiontype_value")]
	private ComboBox _transmissiontype_value;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("engineredline_value")]
	private TextBox _engineredline_value;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("fueltank_value")]
	private TextBox _fueltank_value;

	[AccessedThroughProperty("enginepower_value")]
	private TextBox _enginepower_value;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("mec_ccmax")]
	private TextBox _mec_ccmax;

	[AccessedThroughProperty("mec_ccmin")]
	private TextBox _mec_ccmin;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("mec_cylmax")]
	private TextBox _mec_cylmax;

	[AccessedThroughProperty("mec_cylmin")]
	private TextBox _mec_cylmin;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("mec_gearsmax")]
	private TextBox _mec_gearsmax;

	[AccessedThroughProperty("mec_gearsmin")]
	private TextBox _mec_gearsmin;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("mec_torque")]
	private TextBox _mec_torque;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("mec_drive")]
	private ComboBox _mec_drive;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("mec_weight")]
	private TextBox _mec_weight;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("mec_idle")]
	private TextBox _mec_idle;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("mec_power")]
	private TextBox _mec_power;

	[AccessedThroughProperty("cartype_value")]
	private TextBox _cartype_value;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("tyre_rsize")]
	private TextBox _tyre_rsize;

	[AccessedThroughProperty("tyre_rheight")]
	private TextBox _tyre_rheight;

	[AccessedThroughProperty("tyre_rwidth")]
	private TextBox _tyre_rwidth;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("tyre_fsize")]
	private TextBox _tyre_fsize;

	[AccessedThroughProperty("tyre_fheight")]
	private TextBox _tyre_fheight;

	[AccessedThroughProperty("tyre_fwidthrim")]
	private TextBox _tyre_fwidthrim;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("FileToolStripMenuItem")]
	private ToolStripMenuItem _FileToolStripMenuItem;

	[AccessedThroughProperty("SaveToolStripMenuItem")]
	private ToolStripMenuItem _SaveToolStripMenuItem;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("tyre_rwidthrim")]
	private TextBox _tyre_rwidthrim;

	[AccessedThroughProperty("tyre_fwidth")]
	private TextBox _tyre_fwidth;

	[AccessedThroughProperty("massheight_value")]
	private TextBox _massheight_value;

	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	[AccessedThroughProperty("enginepos_value")]
	private TextBox _enginepos_value;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	[AccessedThroughProperty("tyrefronttrack_value")]
	private TextBox _tyrefronttrack_value;

	[AccessedThroughProperty("tyrefrontangle_value")]
	private TextBox _tyrefrontangle_value;

	[AccessedThroughProperty("tyrereartrack_value")]
	private TextBox _tyrereartrack_value;

	[AccessedThroughProperty("tyrerearangle_value")]
	private TextBox _tyrerearangle_value;

	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	[AccessedThroughProperty("tyrefrontypos_value")]
	private TextBox _tyrefrontypos_value;

	[AccessedThroughProperty("tyrerearypos_value")]
	private TextBox _tyrerearypos_value;

	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	private string currentCarValue;

	private float currentenginecc;

	private float currentengineredline;

	private byte currentenginecylinders;

	private int currentenginetype;

	private byte currentengineturbo;

	private byte currenttransmissiontype;

	private byte currentcartype;

	private float currentengineturbopressure;

	private float currentengineturbolag;

	private double currentenginetorque;

	private float currentfueltank;

	private float currentenginepower;

	private float currenttyrefwidth;

	private float currenttyrefheight;

	private float currenttyrefsize;

	private float currenttyrefwidthrim;

	private float currenttyrerwidth;

	private float currenttyrerheight;

	private float currenttyrersize;

	private float currenttyrerwidthrim;

	private float enginepos;

	private float massheightpos;

	private float tyrefrontypos;

	private float tyrefrontangle;

	private float tyrefronttrack;

	private float tyrerearypos;

	private float tyrerearangle;

	private float tyrereartrack;

	private byte mec_currentcylmin;

	private byte mec_currentcylmax;

	private byte mec_currentdrive;

	private byte mec_currentgearsmin;

	private byte mec_currentgearsmax;

	private float mec_currentccmin;

	private float mec_currentccmax;

	private float mec_currenttorque;

	private float mec_currentpower;

	private float mec_currentidle;

	private float mec_currentweight;

	internal virtual TextBox enginecc_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _enginecc_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_enginecc_value = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label currentCar
	{
		[DebuggerNonUserCode]
		get
		{
			return _currentCar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_currentCar = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual TextBox enginecylinders_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _enginecylinders_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_enginecylinders_value = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual ComboBox enginetype_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _enginetype_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_enginetype_value = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual ComboBox engineturbo_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _engineturbo_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_engineturbo_value = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual TextBox engineturbopressure_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _engineturbopressure_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_engineturbopressure_value = value;
		}
	}

	internal virtual TextBox engineturbolag_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _engineturbolag_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_engineturbolag_value = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	internal virtual TextBox enginetorque_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _enginetorque_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_enginetorque_value = value;
		}
	}

	internal virtual Label torque
	{
		[DebuggerNonUserCode]
		get
		{
			return _torque;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_torque = value;
		}
	}

	internal virtual Button applyButton
	{
		[DebuggerNonUserCode]
		get
		{
			return _applyButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = applyButton_Click;
			if (_applyButton != null)
			{
				((Control)_applyButton).remove_Click(eventHandler);
			}
			_applyButton = value;
			if (_applyButton != null)
			{
				((Control)_applyButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual ComboBox transmissiontype_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _transmissiontype_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_transmissiontype_value = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox engineredline_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _engineredline_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_engineredline_value = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual TextBox fueltank_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _fueltank_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fueltank_value = value;
		}
	}

	internal virtual TextBox enginepower_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _enginepower_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_enginepower_value = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual TextBox mec_ccmax
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_ccmax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_ccmax = value;
		}
	}

	internal virtual TextBox mec_ccmin
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_ccmin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_ccmin = value;
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual TextBox mec_cylmax
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_cylmax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_cylmax = value;
		}
	}

	internal virtual TextBox mec_cylmin
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_cylmin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_cylmin = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual TextBox mec_gearsmax
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_gearsmax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_gearsmax = value;
		}
	}

	internal virtual TextBox mec_gearsmin
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_gearsmin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_gearsmin = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual TextBox mec_torque
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_torque;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_torque = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual ComboBox mec_drive
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_drive;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_drive = value;
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual TextBox mec_weight
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_weight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_weight = value;
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual TextBox mec_idle
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_idle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_idle = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual TextBox mec_power
	{
		[DebuggerNonUserCode]
		get
		{
			return _mec_power;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mec_power = value;
		}
	}

	internal virtual TextBox cartype_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _cartype_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cartype_value = value;
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual TextBox tyre_rsize
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_rsize;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_rsize = value;
		}
	}

	internal virtual TextBox tyre_rheight
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_rheight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_rheight = value;
		}
	}

	internal virtual TextBox tyre_rwidth
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_rwidth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_rwidth = value;
		}
	}

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual TextBox tyre_fsize
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_fsize;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_fsize = value;
		}
	}

	internal virtual TextBox tyre_fheight
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_fheight;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_fheight = value;
		}
	}

	internal virtual TextBox tyre_fwidthrim
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_fwidthrim;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_fwidthrim = value;
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual SaveFileDialog SaveFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFileDialog1 = value;
		}
	}

	internal virtual MenuStrip MenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
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

	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = FileToolStripMenuItem_Click;
			if (_FileToolStripMenuItem != null)
			{
				((ToolStripItem)_FileToolStripMenuItem).remove_Click(eventHandler);
			}
			_FileToolStripMenuItem = value;
			if (_FileToolStripMenuItem != null)
			{
				((ToolStripItem)_FileToolStripMenuItem).add_Click(eventHandler);
			}
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
			EventHandler eventHandler = SaveToolStripMenuItem_Click;
			if (_SaveToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveToolStripMenuItem).remove_Click(eventHandler);
			}
			_SaveToolStripMenuItem = value;
			if (_SaveToolStripMenuItem != null)
			{
				((ToolStripItem)_SaveToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual TextBox tyre_rwidthrim
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_rwidthrim;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_rwidthrim = value;
		}
	}

	internal virtual TextBox tyre_fwidth
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyre_fwidth;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyre_fwidth = value;
		}
	}

	internal virtual TextBox massheight_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _massheight_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_massheight_value = value;
		}
	}

	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label26 = value;
		}
	}

	internal virtual TextBox enginepos_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _enginepos_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_enginepos_value = value;
		}
	}

	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label27_Click;
			if (_Label27 != null)
			{
				((Control)_Label27).remove_Click(eventHandler);
			}
			_Label27 = value;
			if (_Label27 != null)
			{
				((Control)_Label27).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox tyrefronttrack_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyrefronttrack_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyrefronttrack_value = value;
		}
	}

	internal virtual TextBox tyrefrontangle_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyrefrontangle_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyrefrontangle_value = value;
		}
	}

	internal virtual TextBox tyrereartrack_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyrereartrack_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyrereartrack_value = value;
		}
	}

	internal virtual TextBox tyrerearangle_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyrerearangle_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyrerearangle_value = value;
		}
	}

	internal virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label28 = value;
		}
	}

	internal virtual TextBox tyrefrontypos_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyrefrontypos_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyrefrontypos_value = value;
		}
	}

	internal virtual TextBox tyrerearypos_value
	{
		[DebuggerNonUserCode]
		get
		{
			return _tyrerearypos_value;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tyrerearypos_value = value;
		}
	}

	internal virtual Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label29 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_106e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1078: Expected O, but got Unknown
		//IL_18a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ad: Expected O, but got Unknown
		//IL_26ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		enginecc_value = new TextBox();
		Label1 = new Label();
		currentCar = new Label();
		Label2 = new Label();
		Label3 = new Label();
		enginecylinders_value = new TextBox();
		Label4 = new Label();
		enginetype_value = new ComboBox();
		Label5 = new Label();
		engineturbo_value = new ComboBox();
		Label6 = new Label();
		engineturbopressure_value = new TextBox();
		engineturbolag_value = new TextBox();
		Label7 = new Label();
		enginetorque_value = new TextBox();
		torque = new Label();
		applyButton = new Button();
		Label8 = new Label();
		transmissiontype_value = new ComboBox();
		Button1 = new Button();
		engineredline_value = new TextBox();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		fueltank_value = new TextBox();
		enginepower_value = new TextBox();
		Label12 = new Label();
		GroupBox1 = new GroupBox();
		Label29 = new Label();
		massheight_value = new TextBox();
		Label26 = new Label();
		enginepos_value = new TextBox();
		Label25 = new Label();
		tyre_fwidth = new TextBox();
		tyre_rwidthrim = new TextBox();
		tyre_rsize = new TextBox();
		tyre_rheight = new TextBox();
		tyre_rwidth = new TextBox();
		Label24 = new Label();
		tyre_fsize = new TextBox();
		tyre_fheight = new TextBox();
		tyre_fwidthrim = new TextBox();
		Label23 = new Label();
		cartype_value = new TextBox();
		Label21 = new Label();
		GroupBox2 = new GroupBox();
		Label22 = new Label();
		mec_drive = new ComboBox();
		Label20 = new Label();
		mec_weight = new TextBox();
		Label19 = new Label();
		mec_idle = new TextBox();
		Label18 = new Label();
		mec_power = new TextBox();
		Label17 = new Label();
		mec_gearsmax = new TextBox();
		mec_gearsmin = new TextBox();
		Label16 = new Label();
		mec_torque = new TextBox();
		Label15 = new Label();
		mec_cylmax = new TextBox();
		mec_cylmin = new TextBox();
		Label14 = new Label();
		mec_ccmax = new TextBox();
		mec_ccmin = new TextBox();
		Label13 = new Label();
		SaveFileDialog1 = new SaveFileDialog();
		MenuStrip1 = new MenuStrip();
		ToolStripMenuItem1 = new ToolStripMenuItem();
		FileToolStripMenuItem = new ToolStripMenuItem();
		SaveToolStripMenuItem = new ToolStripMenuItem();
		OpenFileDialog1 = new OpenFileDialog();
		Label27 = new Label();
		tyrefronttrack_value = new TextBox();
		tyrefrontangle_value = new TextBox();
		tyrereartrack_value = new TextBox();
		tyrerearangle_value = new TextBox();
		Label28 = new Label();
		tyrefrontypos_value = new TextBox();
		tyrerearypos_value = new TextBox();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		TextBox obj = enginecc_value;
		Point location = new Point(157, 95);
		((Control)obj).set_Location(location);
		((Control)enginecc_value).set_Name("enginecc_value");
		TextBox obj2 = enginecc_value;
		Size size = new Size(95, 20);
		((Control)obj2).set_Size(size);
		((Control)enginecc_value).set_TabIndex(0);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(38, 64);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(60, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Current Car");
		currentCar.set_AutoSize(true);
		Label obj3 = currentCar;
		location = new Point(154, 64);
		((Control)obj3).set_Location(location);
		((Control)currentCar).set_Name("currentCar");
		Label obj4 = currentCar;
		size = new Size(56, 13);
		((Control)obj4).set_Size(size);
		((Control)currentCar).set_TabIndex(2);
		currentCar.set_Text("currentCar");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(38, 98);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(57, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(3);
		Label2.set_Text("Engine CC");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(38, 124);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(85, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Engine Cylinders");
		TextBox obj5 = enginecylinders_value;
		location = new Point(157, 121);
		((Control)obj5).set_Location(location);
		((Control)enginecylinders_value).set_Name("enginecylinders_value");
		TextBox obj6 = enginecylinders_value;
		size = new Size(95, 20);
		((Control)obj6).set_Size(size);
		((Control)enginecylinders_value).set_TabIndex(5);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(38, 150);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(67, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Engine Type");
		((ListControl)enginetype_value).set_FormattingEnabled(true);
		enginetype_value.get_Items().AddRange(new object[3] { "Inline", "Flat", "V-Type" });
		ComboBox obj7 = enginetype_value;
		location = new Point(157, 147);
		((Control)obj7).set_Location(location);
		((Control)enginetype_value).set_Name("enginetype_value");
		ComboBox obj8 = enginetype_value;
		size = new Size(95, 21);
		((Control)obj8).set_Size(size);
		((Control)enginetype_value).set_TabIndex(7);
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(38, 177);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(35, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Turbo");
		((ListControl)engineturbo_value).set_FormattingEnabled(true);
		engineturbo_value.get_Items().AddRange(new object[2] { "Off", "On" });
		ComboBox obj9 = engineturbo_value;
		location = new Point(157, 174);
		((Control)obj9).set_Location(location);
		((Control)engineturbo_value).set_Name("engineturbo_value");
		ComboBox obj10 = engineturbo_value;
		size = new Size(95, 21);
		((Control)obj10).set_Size(size);
		((Control)engineturbo_value).set_TabIndex(9);
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(38, 204);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(79, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(10);
		Label6.set_Text("Turbo Pressure");
		TextBox obj11 = engineturbopressure_value;
		location = new Point(157, 201);
		((Control)obj11).set_Location(location);
		((Control)engineturbopressure_value).set_Name("engineturbopressure_value");
		TextBox obj12 = engineturbopressure_value;
		size = new Size(95, 20);
		((Control)obj12).set_Size(size);
		((Control)engineturbopressure_value).set_TabIndex(11);
		TextBox obj13 = engineturbolag_value;
		location = new Point(157, 227);
		((Control)obj13).set_Location(location);
		((Control)engineturbolag_value).set_Name("engineturbolag_value");
		TextBox obj14 = engineturbolag_value;
		size = new Size(95, 20);
		((Control)obj14).set_Size(size);
		((Control)engineturbolag_value).set_TabIndex(12);
		Label7.set_AutoSize(true);
		Label label13 = Label7;
		location = new Point(38, 230);
		((Control)label13).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label14 = Label7;
		size = new Size(56, 13);
		((Control)label14).set_Size(size);
		((Control)Label7).set_TabIndex(13);
		Label7.set_Text("Turbo Lag");
		TextBox obj15 = enginetorque_value;
		location = new Point(157, 253);
		((Control)obj15).set_Location(location);
		((Control)enginetorque_value).set_Name("enginetorque_value");
		TextBox obj16 = enginetorque_value;
		size = new Size(95, 20);
		((Control)obj16).set_Size(size);
		((Control)enginetorque_value).set_TabIndex(14);
		torque.set_AutoSize(true);
		Label obj17 = torque;
		location = new Point(38, 256);
		((Control)obj17).set_Location(location);
		((Control)torque).set_Name("torque");
		Label obj18 = torque;
		size = new Size(41, 13);
		((Control)obj18).set_Size(size);
		((Control)torque).set_TabIndex(15);
		torque.set_Text("Torque");
		Button obj19 = applyButton;
		location = new Point(93, 523);
		((Control)obj19).set_Location(location);
		((Control)applyButton).set_Name("applyButton");
		Button obj20 = applyButton;
		size = new Size(95, 21);
		((Control)obj20).set_Size(size);
		((Control)applyButton).set_TabIndex(16);
		((ButtonBase)applyButton).set_Text("Apply");
		((ButtonBase)applyButton).set_UseVisualStyleBackColor(true);
		Label8.set_AutoSize(true);
		Label label15 = Label8;
		location = new Point(38, 282);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(95, 13);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(17);
		Label8.set_Text("Transmission Type");
		((ListControl)transmissiontype_value).set_FormattingEnabled(true);
		transmissiontype_value.get_Items().AddRange(new object[5] { "Manual", "Motorbike", "Sequential", "??", "Paddleshift" });
		ComboBox obj21 = transmissiontype_value;
		location = new Point(157, 279);
		((Control)obj21).set_Location(location);
		((Control)transmissiontype_value).set_Name("transmissiontype_value");
		ComboBox obj22 = transmissiontype_value;
		size = new Size(95, 21);
		((Control)obj22).set_Size(size);
		((Control)transmissiontype_value).set_TabIndex(18);
		Button button = Button1;
		location = new Point(12, 522);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(19);
		((ButtonBase)Button1).set_Text("Refresh");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox obj23 = engineredline_value;
		location = new Point(157, 306);
		((Control)obj23).set_Location(location);
		((Control)engineredline_value).set_Name("engineredline_value");
		TextBox obj24 = engineredline_value;
		size = new Size(95, 20);
		((Control)obj24).set_Size(size);
		((Control)engineredline_value).set_TabIndex(20);
		Label9.set_AutoSize(true);
		Label label17 = Label9;
		location = new Point(38, 309);
		((Control)label17).set_Location(location);
		((Control)Label9).set_Name("Label9");
		Label label18 = Label9;
		size = new Size(79, 13);
		((Control)label18).set_Size(size);
		((Control)Label9).set_TabIndex(21);
		Label9.set_Text("Engine Redline");
		Label10.set_AutoSize(true);
		Label label19 = Label10;
		location = new Point(275, 488);
		((Control)label19).set_Location(location);
		((Control)Label10).set_Name("Label10");
		Label label20 = Label10;
		size = new Size(289, 52);
		((Control)label20).set_Size(size);
		((Control)Label10).set_TabIndex(22);
		Label10.set_Text("Licencecheck by DavidTiger\r\nProgramming by Beerkeeper\r\n\r\nIf you like the program, leave a comment on LFSTweak.net!");
		Label11.set_AutoSize(true);
		Label label21 = Label11;
		location = new Point(38, 335);
		((Control)label21).set_Location(location);
		((Control)Label11).set_Name("Label11");
		Label label22 = Label11;
		size = new Size(55, 13);
		((Control)label22).set_Size(size);
		((Control)Label11).set_TabIndex(23);
		Label11.set_Text("Fuel Tank");
		TextBox obj25 = fueltank_value;
		location = new Point(157, 332);
		((Control)obj25).set_Location(location);
		((Control)fueltank_value).set_Name("fueltank_value");
		TextBox obj26 = fueltank_value;
		size = new Size(95, 20);
		((Control)obj26).set_Size(size);
		((Control)fueltank_value).set_TabIndex(24);
		TextBox obj27 = enginepower_value;
		location = new Point(157, 358);
		((Control)obj27).set_Location(location);
		((Control)enginepower_value).set_Name("enginepower_value");
		TextBox obj28 = enginepower_value;
		size = new Size(95, 20);
		((Control)obj28).set_Size(size);
		((Control)enginepower_value).set_TabIndex(25);
		Label12.set_AutoSize(true);
		Label label23 = Label12;
		location = new Point(38, 361);
		((Control)label23).set_Location(location);
		((Control)Label12).set_Name("Label12");
		Label label24 = Label12;
		size = new Size(73, 13);
		((Control)label24).set_Size(size);
		((Control)Label12).set_TabIndex(26);
		Label12.set_Text("Engine Power");
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label29);
		((Control)GroupBox1).get_Controls().Add((Control)(object)massheight_value);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label26);
		((Control)GroupBox1).get_Controls().Add((Control)(object)enginepos_value);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label25);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_fwidth);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_rwidthrim);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_rsize);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_rheight);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_rwidth);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label24);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_fsize);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_fheight);
		((Control)GroupBox1).get_Controls().Add((Control)(object)tyre_fwidthrim);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label23);
		((Control)GroupBox1).get_Controls().Add((Control)(object)cartype_value);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label21);
		GroupBox groupBox = GroupBox1;
		location = new Point(12, 42);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(255, 474);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(27);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("LFSTweak");
		Label29.set_AutoSize(true);
		((Control)Label29).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label25 = Label29;
		location = new Point(76, 0);
		((Control)label25).set_Location(location);
		((Control)Label29).set_Name("Label29");
		Label label26 = Label29;
		size = new Size(131, 13);
		((Control)label26).set_Size(size);
		((Control)Label29).set_TabIndex(43);
		Label29.set_Text("XFG/XRG/FBM ONLY");
		TextBox obj29 = massheight_value;
		location = new Point(145, 446);
		((Control)obj29).set_Location(location);
		((Control)massheight_value).set_Name("massheight_value");
		TextBox obj30 = massheight_value;
		size = new Size(95, 20);
		((Control)obj30).set_Size(size);
		((Control)massheight_value).set_TabIndex(42);
		Label26.set_AutoSize(true);
		Label label27 = Label26;
		location = new Point(26, 449);
		((Control)label27).set_Location(location);
		((Control)Label26).set_Name("Label26");
		Label label28 = Label26;
		size = new Size(103, 13);
		((Control)label28).set_Size(size);
		((Control)Label26).set_TabIndex(41);
		Label26.set_Text("Mass height position");
		TextBox obj31 = enginepos_value;
		location = new Point(145, 420);
		((Control)obj31).set_Location(location);
		((Control)enginepos_value).set_Name("enginepos_value");
		TextBox obj32 = enginepos_value;
		size = new Size(95, 20);
		((Control)obj32).set_Size(size);
		((Control)enginepos_value).set_TabIndex(30);
		Label25.set_AutoSize(true);
		Label label29 = Label25;
		location = new Point(26, 423);
		((Control)label29).set_Location(location);
		((Control)Label25).set_Name("Label25");
		Label label30 = Label25;
		size = new Size(79, 13);
		((Control)label30).set_Size(size);
		((Control)Label25).set_TabIndex(40);
		Label25.set_Text("Engine position");
		TextBox obj33 = tyre_fwidth;
		location = new Point(111, 368);
		((Control)obj33).set_Location(location);
		((Control)tyre_fwidth).set_Name("tyre_fwidth");
		TextBox obj34 = tyre_fwidth;
		size = new Size(28, 20);
		((Control)obj34).set_Size(size);
		((Control)tyre_fwidth).set_TabIndex(39);
		TextBox obj35 = tyre_rwidthrim;
		location = new Point(145, 394);
		((Control)obj35).set_Location(location);
		((Control)tyre_rwidthrim).set_Name("tyre_rwidthrim");
		TextBox obj36 = tyre_rwidthrim;
		size = new Size(28, 20);
		((Control)obj36).set_Size(size);
		((Control)tyre_rwidthrim).set_TabIndex(38);
		TextBox obj37 = tyre_rsize;
		location = new Point(212, 394);
		((Control)obj37).set_Location(location);
		((Control)tyre_rsize).set_Name("tyre_rsize");
		TextBox obj38 = tyre_rsize;
		size = new Size(28, 20);
		((Control)obj38).set_Size(size);
		((Control)tyre_rsize).set_TabIndex(37);
		TextBox obj39 = tyre_rheight;
		location = new Point(179, 394);
		((Control)obj39).set_Location(location);
		((Control)tyre_rheight).set_Name("tyre_rheight");
		TextBox obj40 = tyre_rheight;
		size = new Size(28, 20);
		((Control)obj40).set_Size(size);
		((Control)tyre_rheight).set_TabIndex(36);
		TextBox obj41 = tyre_rwidth;
		location = new Point(111, 394);
		((Control)obj41).set_Location(location);
		((Control)tyre_rwidth).set_Name("tyre_rwidth");
		TextBox obj42 = tyre_rwidth;
		size = new Size(28, 20);
		((Control)obj42).set_Size(size);
		((Control)tyre_rwidth).set_TabIndex(35);
		Label24.set_AutoSize(true);
		Label label31 = Label24;
		location = new Point(26, 397);
		((Control)label31).set_Location(location);
		((Control)Label24).set_Name("Label24");
		Label label32 = Label24;
		size = new Size(52, 13);
		((Control)label32).set_Size(size);
		((Control)Label24).set_TabIndex(34);
		Label24.set_Text("Rear tires");
		TextBox obj43 = tyre_fsize;
		location = new Point(212, 368);
		((Control)obj43).set_Location(location);
		((Control)tyre_fsize).set_Name("tyre_fsize");
		TextBox obj44 = tyre_fsize;
		size = new Size(28, 20);
		((Control)obj44).set_Size(size);
		((Control)tyre_fsize).set_TabIndex(33);
		TextBox obj45 = tyre_fheight;
		location = new Point(179, 368);
		((Control)obj45).set_Location(location);
		((Control)tyre_fheight).set_Name("tyre_fheight");
		TextBox obj46 = tyre_fheight;
		size = new Size(28, 20);
		((Control)obj46).set_Size(size);
		((Control)tyre_fheight).set_TabIndex(32);
		TextBox obj47 = tyre_fwidthrim;
		location = new Point(145, 368);
		((Control)obj47).set_Location(location);
		((Control)tyre_fwidthrim).set_Name("tyre_fwidthrim");
		TextBox obj48 = tyre_fwidthrim;
		size = new Size(28, 20);
		((Control)obj48).set_Size(size);
		((Control)tyre_fwidthrim).set_TabIndex(31);
		Label23.set_AutoSize(true);
		Label label33 = Label23;
		location = new Point(26, 371);
		((Control)label33).set_Location(location);
		((Control)Label23).set_Name("Label23");
		Label label34 = Label23;
		size = new Size(53, 13);
		((Control)label34).set_Size(size);
		((Control)Label23).set_TabIndex(30);
		Label23.set_Text("Front tires");
		TextBox obj49 = cartype_value;
		location = new Point(145, 342);
		((Control)obj49).set_Location(location);
		((Control)cartype_value).set_Name("cartype_value");
		TextBox obj50 = cartype_value;
		size = new Size(95, 20);
		((Control)obj50).set_Size(size);
		((Control)cartype_value).set_TabIndex(29);
		Label21.set_AutoSize(true);
		Label label35 = Label21;
		location = new Point(26, 345);
		((Control)label35).set_Location(location);
		((Control)Label21).set_Name("Label21");
		Label label36 = Label21;
		size = new Size(43, 13);
		((Control)label36).set_Size(size);
		((Control)Label21).set_TabIndex(29);
		Label21.set_Text("Cartype");
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label22);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_drive);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label20);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_weight);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label19);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_idle);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label18);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_power);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label17);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_gearsmax);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_gearsmin);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label16);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_torque);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label15);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_cylmax);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_cylmin);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label14);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_ccmax);
		((Control)GroupBox2).get_Controls().Add((Control)(object)mec_ccmin);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label13);
		GroupBox groupBox3 = GroupBox2;
		location = new Point(278, 42);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(322, 270);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(28);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Mecanik");
		Label22.set_AutoSize(true);
		((Control)Label22).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Label label37 = Label22;
		location = new Point(6, 22);
		((Control)label37).set_Location(location);
		((Control)Label22).set_Name("Label22");
		Label label38 = Label22;
		size = new Size(298, 13);
		((Control)label38).set_Size(size);
		((Control)Label22).set_TabIndex(47);
		Label22.set_Text("UF1/XRG/XFG/RB4/XRT/FXO/LX4/LX6/FZ5/RAC");
		((ListControl)mec_drive).set_FormattingEnabled(true);
		mec_drive.get_Items().AddRange(new object[4] { "FWD", "RWD", "AWD", "Default" });
		ComboBox obj51 = mec_drive;
		location = new Point(120, 237);
		((Control)obj51).set_Location(location);
		((Control)mec_drive).set_Name("mec_drive");
		ComboBox obj52 = mec_drive;
		size = new Size(121, 21);
		((Control)obj52).set_Size(size);
		((Control)mec_drive).set_TabIndex(46);
		Label20.set_AutoSize(true);
		Label label39 = Label20;
		location = new Point(6, 240);
		((Control)label39).set_Location(location);
		((Control)Label20).set_Name("Label20");
		Label label40 = Label20;
		size = new Size(32, 13);
		((Control)label40).set_Size(size);
		((Control)Label20).set_TabIndex(45);
		Label20.set_Text("Drive");
		TextBox obj53 = mec_weight;
		location = new Point(120, 211);
		((Control)obj53).set_Location(location);
		((Control)mec_weight).set_Name("mec_weight");
		TextBox obj54 = mec_weight;
		size = new Size(95, 20);
		((Control)obj54).set_Size(size);
		((Control)mec_weight).set_TabIndex(44);
		Label19.set_AutoSize(true);
		Label label41 = Label19;
		location = new Point(6, 214);
		((Control)label41).set_Location(location);
		((Control)Label19).set_Name("Label19");
		Label label42 = Label19;
		size = new Size(41, 13);
		((Control)label42).set_Size(size);
		((Control)Label19).set_TabIndex(43);
		Label19.set_Text("Weight");
		TextBox obj55 = mec_idle;
		location = new Point(120, 185);
		((Control)obj55).set_Location(location);
		((Control)mec_idle).set_Name("mec_idle");
		TextBox obj56 = mec_idle;
		size = new Size(95, 20);
		((Control)obj56).set_Size(size);
		((Control)mec_idle).set_TabIndex(42);
		Label18.set_AutoSize(true);
		Label label43 = Label18;
		location = new Point(6, 188);
		((Control)label43).set_Location(location);
		((Control)Label18).set_Name("Label18");
		Label label44 = Label18;
		size = new Size(24, 13);
		((Control)label44).set_Size(size);
		((Control)Label18).set_TabIndex(41);
		Label18.set_Text("Idle");
		TextBox obj57 = mec_power;
		location = new Point(120, 131);
		((Control)obj57).set_Location(location);
		((Control)mec_power).set_Name("mec_power");
		TextBox obj58 = mec_power;
		size = new Size(95, 20);
		((Control)obj58).set_Size(size);
		((Control)mec_power).set_TabIndex(40);
		Label17.set_AutoSize(true);
		Label label45 = Label17;
		location = new Point(6, 135);
		((Control)label45).set_Location(location);
		((Control)Label17).set_Name("Label17");
		Label label46 = Label17;
		size = new Size(73, 13);
		((Control)label46).set_Size(size);
		((Control)Label17).set_TabIndex(39);
		Label17.set_Text("Engine Power");
		TextBox obj59 = mec_gearsmax;
		location = new Point(221, 159);
		((Control)obj59).set_Location(location);
		((Control)mec_gearsmax).set_Name("mec_gearsmax");
		TextBox obj60 = mec_gearsmax;
		size = new Size(95, 20);
		((Control)obj60).set_Size(size);
		((Control)mec_gearsmax).set_TabIndex(38);
		TextBox obj61 = mec_gearsmin;
		location = new Point(120, 159);
		((Control)obj61).set_Location(location);
		((Control)mec_gearsmin).set_Name("mec_gearsmin");
		TextBox obj62 = mec_gearsmin;
		size = new Size(95, 20);
		((Control)obj62).set_Size(size);
		((Control)mec_gearsmin).set_TabIndex(37);
		Label16.set_AutoSize(true);
		Label label47 = Label16;
		location = new Point(6, 162);
		((Control)label47).set_Location(location);
		((Control)Label16).set_Name("Label16");
		Label label48 = Label16;
		size = new Size(35, 13);
		((Control)label48).set_Size(size);
		((Control)Label16).set_TabIndex(36);
		Label16.set_Text("Gears");
		TextBox obj63 = mec_torque;
		location = new Point(120, 105);
		((Control)obj63).set_Location(location);
		((Control)mec_torque).set_Name("mec_torque");
		TextBox obj64 = mec_torque;
		size = new Size(95, 20);
		((Control)obj64).set_Size(size);
		((Control)mec_torque).set_TabIndex(35);
		Label15.set_AutoSize(true);
		Label label49 = Label15;
		location = new Point(6, 108);
		((Control)label49).set_Location(location);
		((Control)Label15).set_Name("Label15");
		Label label50 = Label15;
		size = new Size(77, 13);
		((Control)label50).set_Size(size);
		((Control)Label15).set_TabIndex(34);
		Label15.set_Text("Engine Torque");
		TextBox obj65 = mec_cylmax;
		location = new Point(221, 79);
		((Control)obj65).set_Location(location);
		((Control)mec_cylmax).set_Name("mec_cylmax");
		TextBox obj66 = mec_cylmax;
		size = new Size(95, 20);
		((Control)obj66).set_Size(size);
		((Control)mec_cylmax).set_TabIndex(33);
		TextBox obj67 = mec_cylmin;
		location = new Point(120, 79);
		((Control)obj67).set_Location(location);
		((Control)mec_cylmin).set_Name("mec_cylmin");
		TextBox obj68 = mec_cylmin;
		size = new Size(95, 20);
		((Control)obj68).set_Size(size);
		((Control)mec_cylmin).set_TabIndex(32);
		Label14.set_AutoSize(true);
		Label label51 = Label14;
		location = new Point(6, 82);
		((Control)label51).set_Location(location);
		((Control)Label14).set_Name("Label14");
		Label label52 = Label14;
		size = new Size(85, 13);
		((Control)label52).set_Size(size);
		((Control)Label14).set_TabIndex(31);
		Label14.set_Text("Engine Cylinders");
		TextBox obj69 = mec_ccmax;
		location = new Point(221, 53);
		((Control)obj69).set_Location(location);
		((Control)mec_ccmax).set_Name("mec_ccmax");
		TextBox obj70 = mec_ccmax;
		size = new Size(95, 20);
		((Control)obj70).set_Size(size);
		((Control)mec_ccmax).set_TabIndex(30);
		TextBox obj71 = mec_ccmin;
		location = new Point(120, 53);
		((Control)obj71).set_Location(location);
		((Control)mec_ccmin).set_Name("mec_ccmin");
		TextBox obj72 = mec_ccmin;
		size = new Size(95, 20);
		((Control)obj72).set_Size(size);
		((Control)mec_ccmin).set_TabIndex(29);
		Label13.set_AutoSize(true);
		Label label53 = Label13;
		location = new Point(6, 56);
		((Control)label53).set_Location(location);
		((Control)Label13).set_Name("Label13");
		Label label54 = Label13;
		size = new Size(57, 13);
		((Control)label54).set_Size(size);
		((Control)Label13).set_TabIndex(29);
		Label13.set_Text("Engine CC");
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripMenuItem1 });
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		size = new Size(620, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(29);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)ToolStripMenuItem1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)SaveToolStripMenuItem
		});
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(37, 20);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("File");
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		ToolStripMenuItem fileToolStripMenuItem = FileToolStripMenuItem;
		size = new Size(100, 22);
		((ToolStripItem)fileToolStripMenuItem).set_Size(size);
		((ToolStripItem)FileToolStripMenuItem).set_Text("Load");
		((ToolStripItem)SaveToolStripMenuItem).set_Name("SaveToolStripMenuItem");
		ToolStripMenuItem saveToolStripMenuItem = SaveToolStripMenuItem;
		size = new Size(100, 22);
		((ToolStripItem)saveToolStripMenuItem).set_Size(size);
		((ToolStripItem)SaveToolStripMenuItem).set_Text("Save");
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		Label27.set_AutoSize(true);
		Label label55 = Label27;
		location = new Point(282, 332);
		((Control)label55).set_Location(location);
		((Control)Label27).set_Name("Label27");
		Label label56 = Label27;
		size = new Size(122, 13);
		((Control)label56).set_Size(size);
		((Control)Label27).set_TabIndex(43);
		Label27.set_Text("Front wheel pos (T/A/Y)");
		TextBox obj73 = tyrefronttrack_value;
		location = new Point(410, 328);
		((Control)obj73).set_Location(location);
		((Control)tyrefronttrack_value).set_Name("tyrefronttrack_value");
		TextBox obj74 = tyrefronttrack_value;
		size = new Size(53, 20);
		((Control)obj74).set_Size(size);
		((Control)tyrefronttrack_value).set_TabIndex(43);
		TextBox obj75 = tyrefrontangle_value;
		location = new Point(469, 329);
		((Control)obj75).set_Location(location);
		((Control)tyrefrontangle_value).set_Name("tyrefrontangle_value");
		TextBox obj76 = tyrefrontangle_value;
		size = new Size(50, 20);
		((Control)obj76).set_Size(size);
		((Control)tyrefrontangle_value).set_TabIndex(44);
		TextBox obj77 = tyrereartrack_value;
		location = new Point(410, 354);
		((Control)obj77).set_Location(location);
		((Control)tyrereartrack_value).set_Name("tyrereartrack_value");
		TextBox obj78 = tyrereartrack_value;
		size = new Size(53, 20);
		((Control)obj78).set_Size(size);
		((Control)tyrereartrack_value).set_TabIndex(45);
		TextBox obj79 = tyrerearangle_value;
		location = new Point(469, 354);
		((Control)obj79).set_Location(location);
		((Control)tyrerearangle_value).set_Name("tyrerearangle_value");
		TextBox obj80 = tyrerearangle_value;
		size = new Size(50, 20);
		((Control)obj80).set_Size(size);
		((Control)tyrerearangle_value).set_TabIndex(46);
		Label28.set_AutoSize(true);
		Label label57 = Label28;
		location = new Point(282, 357);
		((Control)label57).set_Location(location);
		((Control)Label28).set_Name("Label28");
		Label label58 = Label28;
		size = new Size(121, 13);
		((Control)label58).set_Size(size);
		((Control)Label28).set_TabIndex(47);
		Label28.set_Text("Rear wheel pos (T/A/Y)");
		TextBox obj81 = tyrefrontypos_value;
		location = new Point(525, 328);
		((Control)obj81).set_Location(location);
		((Control)tyrefrontypos_value).set_Name("tyrefrontypos_value");
		TextBox obj82 = tyrefrontypos_value;
		size = new Size(50, 20);
		((Control)obj82).set_Size(size);
		((Control)tyrefrontypos_value).set_TabIndex(48);
		TextBox obj83 = tyrerearypos_value;
		location = new Point(525, 354);
		((Control)obj83).set_Location(location);
		((Control)tyrerearypos_value).set_Name("tyrerearypos_value");
		TextBox obj84 = tyrerearypos_value;
		size = new Size(50, 20);
		((Control)obj84).set_Size(size);
		((Control)tyrerearypos_value).set_TabIndex(49);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(620, 554);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)tyrerearypos_value);
		((Control)this).get_Controls().Add((Control)(object)tyrefrontypos_value);
		((Control)this).get_Controls().Add((Control)(object)Label28);
		((Control)this).get_Controls().Add((Control)(object)tyrerearangle_value);
		((Control)this).get_Controls().Add((Control)(object)tyrereartrack_value);
		((Control)this).get_Controls().Add((Control)(object)tyrefrontangle_value);
		((Control)this).get_Controls().Add((Control)(object)tyrefronttrack_value);
		((Control)this).get_Controls().Add((Control)(object)Label27);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)Label12);
		((Control)this).get_Controls().Add((Control)(object)enginepower_value);
		((Control)this).get_Controls().Add((Control)(object)fueltank_value);
		((Control)this).get_Controls().Add((Control)(object)Label11);
		((Control)this).get_Controls().Add((Control)(object)Label10);
		((Control)this).get_Controls().Add((Control)(object)Label9);
		((Control)this).get_Controls().Add((Control)(object)engineredline_value);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)transmissiontype_value);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)applyButton);
		((Control)this).get_Controls().Add((Control)(object)torque);
		((Control)this).get_Controls().Add((Control)(object)enginetorque_value);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)engineturbolag_value);
		((Control)this).get_Controls().Add((Control)(object)engineturbopressure_value);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)engineturbo_value);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)enginetype_value);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)enginecylinders_value);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)currentCar);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)enginecc_value);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("LFSTweak V0.6.2 from LFSTweak.net");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void carUpdate(string currentCar)
	{
		if (currentCar.Equals("XRG"))
		{
			Memory.WriteMemorySingle(5854728, (float)(Conversions.ToDouble(tyre_fwidth.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5854732, (float)(Conversions.ToDouble(tyre_fheight.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5854736, (float)(Conversions.ToDouble(tyre_fsize.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5854740, (float)(Conversions.ToDouble(tyre_fwidthrim.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5854664, (float)(Conversions.ToDouble(tyre_rwidth.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5854668, (float)(Conversions.ToDouble(tyre_rheight.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5854672, (float)(Conversions.ToDouble(tyre_rsize.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5854676, (float)(Conversions.ToDouble(tyre_rwidthrim.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5852696, Conversions.ToSingle(enginecc_value.get_Text()));
			Memory.WriteByte(5852700, Conversions.ToInteger(enginecylinders_value.get_Text()));
			if (Operators.CompareString(engineturbo_value.get_Text(), "On", false) == 0)
			{
				Memory.WriteByte(5852688, 13);
			}
			else
			{
				Memory.WriteByte(5852688, 12);
			}
			Memory.WriteMemorySingle(5852708, Conversions.ToSingle(engineturbolag_value.get_Text()));
			Memory.WriteMemorySingle(5852704, Conversions.ToSingle(engineturbopressure_value.get_Text()));
			Memory.WriteMemorySingle(5852724, Conversions.ToSingle(engineredline_value.get_Text()));
			Memory.WriteMemorySingle(5852728, Conversions.ToSingle(enginetorque_value.get_Text()));
			Memory.WriteByte(5852672, Conversions.ToInteger(cartype_value.get_Text()));
			Memory.WriteMemorySingle(5853424, Conversions.ToSingle(fueltank_value.get_Text()));
			Memory.WriteMemorySingle(5852712, Conversions.ToSingle(enginepower_value.get_Text()));
			Memory.WriteMemorySingle(5853336, Conversions.ToSingle(enginepos_value.get_Text()));
			Memory.WriteMemorySingle(5853340, Conversions.ToSingle(massheight_value.get_Text()));
			Memory.WriteMemorySingle(5854780, Conversions.ToSingle(tyrefrontypos_value.get_Text()));
			Memory.WriteMemorySingle(5854768, Conversions.ToSingle(tyrefronttrack_value.get_Text()));
			Memory.WriteMemorySingle(5854764, Conversions.ToSingle(tyrefrontangle_value.get_Text()));
			Memory.WriteMemorySingle(5854716, Conversions.ToSingle(tyrerearypos_value.get_Text()));
			Memory.WriteMemorySingle(5854704, Conversions.ToSingle(tyrereartrack_value.get_Text()));
			Memory.WriteMemorySingle(5854700, Conversions.ToSingle(tyrerearangle_value.get_Text()));
			if (Operators.CompareString(transmissiontype_value.get_Text(), "Manual", false) == 0)
			{
				Memory.WriteByte(5852676, 1);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Motorbike", false) == 0)
			{
				Memory.WriteByte(5852676, 2);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Sequential", false) == 0)
			{
				Memory.WriteByte(5852676, 3);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "??", false) == 0)
			{
				Memory.WriteByte(5852676, 4);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Paddleshift", false) == 0)
			{
				Memory.WriteByte(5852676, 5);
			}
			if (Operators.CompareString(enginetype_value.get_Text(), "Inline", false) == 0)
			{
				Memory.WriteByte(5852701, 0);
			}
			else if (Operators.CompareString(enginetype_value.get_Text(), "Flat", false) == 0)
			{
				Memory.WriteByte(5852701, 1);
			}
			else if (Operators.CompareString(enginetype_value.get_Text(), "V-Type", false) == 0)
			{
				Memory.WriteByte(5852701, 2);
			}
		}
		else if (currentCar.Equals("XFG"))
		{
			Memory.WriteMemorySingle(5848800, (float)(Conversions.ToDouble(tyre_fwidth.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5848804, (float)(Conversions.ToDouble(tyre_fheight.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5848808, (float)(Conversions.ToDouble(tyre_fsize.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5848812, (float)(Conversions.ToDouble(tyre_fwidthrim.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5846936, Conversions.ToSingle(enginecc_value.get_Text()));
			Memory.WriteByte(5846940, Conversions.ToInteger(enginecylinders_value.get_Text()));
			if (Operators.CompareString(engineturbo_value.get_Text(), "On", false) == 0)
			{
				Memory.WriteByte(5846928, 13);
			}
			else
			{
				Memory.WriteByte(5846928, 12);
			}
			Memory.WriteMemorySingle(5846948, Conversions.ToSingle(engineturbolag_value.get_Text()));
			Memory.WriteMemorySingle(5846944, Conversions.ToSingle(engineturbopressure_value.get_Text()));
			Memory.WriteMemorySingle(5846968, Conversions.ToSingle(enginetorque_value.get_Text()));
			Memory.WriteMemorySingle(5846964, Conversions.ToSingle(engineredline_value.get_Text()));
			Memory.WriteByte(5846912, Conversions.ToInteger(cartype_value.get_Text()));
			Memory.WriteMemorySingle(5847664, Conversions.ToSingle(fueltank_value.get_Text()));
			Memory.WriteMemorySingle(5846952, Conversions.ToSingle(enginepower_value.get_Text()));
			Memory.WriteMemorySingle(5847624, Conversions.ToSingle(enginepos_value.get_Text()));
			Memory.WriteMemorySingle(5847628, Conversions.ToSingle(massheight_value.get_Text()));
			Memory.WriteMemorySingle(5848852, Conversions.ToSingle(tyrefrontypos_value.get_Text()));
			Memory.WriteMemorySingle(5848840, Conversions.ToSingle(tyrefronttrack_value.get_Text()));
			Memory.WriteMemorySingle(5848836, Conversions.ToSingle(tyrefrontangle_value.get_Text()));
			if (Operators.CompareString(transmissiontype_value.get_Text(), "Manual", false) == 0)
			{
				Memory.WriteByte(5846916, 1);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Motorbike", false) == 0)
			{
				Memory.WriteByte(5846916, 2);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Sequential", false) == 0)
			{
				Memory.WriteByte(5846916, 3);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "??", false) == 0)
			{
				Memory.WriteByte(5846916, 4);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Paddleshift", false) == 0)
			{
				Memory.WriteByte(5846916, 5);
			}
			if (Operators.CompareString(enginetype_value.get_Text(), "Inline", false) == 0)
			{
				Memory.WriteByte(5846941, 0);
			}
			else if (Operators.CompareString(enginetype_value.get_Text(), "Flat", false) == 0)
			{
				Memory.WriteByte(5846941, 1);
			}
			else if (Operators.CompareString(enginetype_value.get_Text(), "V-Type", false) == 0)
			{
				Memory.WriteByte(5846941, 2);
			}
		}
		else if (currentCar.Equals("FBM"))
		{
			Memory.WriteMemorySingle(5744376, (float)(Conversions.ToDouble(tyre_fwidth.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5744380, (float)(Conversions.ToDouble(tyre_fheight.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5744384, (float)(Conversions.ToDouble(tyre_fsize.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5744388, (float)(Conversions.ToDouble(tyre_fwidthrim.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5744312, (float)(Conversions.ToDouble(tyre_rwidth.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5744316, (float)(Conversions.ToDouble(tyre_rheight.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5744320, (float)(Conversions.ToDouble(tyre_rsize.get_Text()) / 100.0));
			Memory.WriteMemorySingle(5744324, (float)(Conversions.ToDouble(tyre_rwidthrim.get_Text()) / 1000.0));
			Memory.WriteMemorySingle(5742484, Conversions.ToSingle(enginecc_value.get_Text()));
			Memory.WriteByte(5742488, Conversions.ToInteger(enginecylinders_value.get_Text()));
			if (Operators.CompareString(engineturbo_value.get_Text(), "On", false) == 0)
			{
				Memory.WriteByte(5742476, 13);
			}
			else
			{
				Memory.WriteByte(5742476, 12);
			}
			Memory.WriteMemorySingle(5742496, Conversions.ToSingle(engineturbolag_value.get_Text()));
			Memory.WriteMemorySingle(5742492, Conversions.ToSingle(engineturbopressure_value.get_Text()));
			Memory.WriteMemorySingle(5742516, Conversions.ToSingle(enginetorque_value.get_Text()));
			Memory.WriteMemorySingle(5742512, Conversions.ToSingle(engineredline_value.get_Text()));
			Memory.WriteByte(5742460, Conversions.ToInteger(cartype_value.get_Text()));
			Memory.WriteMemorySingle(5743060, Conversions.ToSingle(fueltank_value.get_Text()));
			Memory.WriteMemorySingle(5742500, Conversions.ToSingle(enginepower_value.get_Text()));
			Memory.WriteMemorySingle(5742984, Conversions.ToSingle(enginepos_value.get_Text()));
			Memory.WriteMemorySingle(5742988, Conversions.ToSingle(massheight_value.get_Text()));
			Memory.WriteMemorySingle(5744428, Conversions.ToSingle(tyrefrontypos_value.get_Text()));
			Memory.WriteMemorySingle(5744416, Conversions.ToSingle(tyrefronttrack_value.get_Text()));
			Memory.WriteMemorySingle(5744412, Conversions.ToSingle(tyrefrontangle_value.get_Text()));
			Memory.WriteMemorySingle(5744364, Conversions.ToSingle(tyrerearypos_value.get_Text()));
			Memory.WriteMemorySingle(5744352, Conversions.ToSingle(tyrereartrack_value.get_Text()));
			Memory.WriteMemorySingle(5744348, Conversions.ToSingle(tyrerearangle_value.get_Text()));
			if (Operators.CompareString(transmissiontype_value.get_Text(), "Manual", false) == 0)
			{
				Memory.WriteByte(5742464, 1);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Motorbike", false) == 0)
			{
				Memory.WriteByte(5742464, 2);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Sequential", false) == 0)
			{
				Memory.WriteByte(5742464, 3);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "??", false) == 0)
			{
				Memory.WriteByte(5742464, 4);
			}
			else if (Operators.CompareString(transmissiontype_value.get_Text(), "Paddleshift", false) == 0)
			{
				Memory.WriteByte(5742464, 5);
			}
			if (Operators.CompareString(enginetype_value.get_Text(), "Inline", false) == 0)
			{
				Memory.WriteByte(5742489, 0);
			}
			else if (Operators.CompareString(enginetype_value.get_Text(), "Flat", false) == 0)
			{
				Memory.WriteByte(5742489, 1);
			}
			else if (Operators.CompareString(enginetype_value.get_Text(), "V-Type", false) == 0)
			{
				Memory.WriteByte(5742489, 2);
			}
		}
	}

	public void mecanikUpdater(object currentCarValue)
	{
		if (currentCarValue.Equals("XRG") | currentCarValue.Equals("XFG") | currentCarValue.Equals("UF1"))
		{
			mec_currentcylmin = Conversions.ToByte(Memory.ReadByte2(5966450));
			mec_cylmin.set_Text(Conversions.ToString(mec_currentcylmin));
			mec_currentcylmax = Conversions.ToByte(Memory.ReadByte2(5966451));
			mec_cylmax.set_Text(Conversions.ToString(mec_currentcylmax));
			mec_currentgearsmin = Conversions.ToByte(Memory.ReadByte2(5966446));
			mec_gearsmin.set_Text(Conversions.ToString(mec_currentgearsmin));
			mec_currentgearsmax = Conversions.ToByte(Memory.ReadByte2(5966447));
			mec_gearsmax.set_Text(Conversions.ToString(mec_currentgearsmax));
			mec_currentdrive = Conversions.ToByte(Memory.ReadByte(5966440));
			if (mec_currentdrive == 1)
			{
				mec_drive.set_Text("RWD");
			}
			else if (mec_currentdrive == 2)
			{
				mec_drive.set_Text("FWD");
			}
			else if (mec_currentdrive == 3)
			{
				mec_drive.set_Text("AWD");
			}
			else if (mec_currentdrive == 4)
			{
				mec_drive.set_Text("Default");
			}
			Memory.ReadSingle(5966452, ref mec_currentccmin);
			mec_ccmin.set_Text(Conversions.ToString(mec_currentccmin));
			Memory.ReadSingle(5966456, ref mec_currentccmax);
			mec_ccmax.set_Text(Conversions.ToString(mec_currentccmax));
			Memory.ReadSingle(5966460, ref mec_currenttorque);
			mec_torque.set_Text(Conversions.ToString(mec_currenttorque));
			Memory.ReadSingle(5966472, ref mec_currentpower);
			mec_power.set_Text(Conversions.ToString(mec_currentpower));
			Memory.ReadSingle(5966488, ref mec_currentidle);
			mec_idle.set_Text(Conversions.ToString(mec_currentidle));
			Memory.ReadSingle(5966436, ref mec_currentweight);
			mec_weight.set_Text(Conversions.ToString(mec_currentweight));
		}
		else if (currentCarValue.Equals("LX4") | currentCarValue.Equals("LX6") | currentCarValue.Equals("RB4") | currentCarValue.Equals("FXO") | currentCarValue.Equals("XRT") | currentCarValue.Equals("RAC") | currentCarValue.Equals("FZ5"))
		{
			mec_currentcylmin = Conversions.ToByte(Memory.ReadByte2(5966390));
			mec_cylmin.set_Text(Conversions.ToString(mec_currentcylmin));
			mec_currentcylmax = Conversions.ToByte(Memory.ReadByte2(5966391));
			mec_cylmax.set_Text(Conversions.ToString(mec_currentcylmax));
			mec_currentgearsmin = Conversions.ToByte(Memory.ReadByte2(5966386));
			mec_gearsmin.set_Text(Conversions.ToString(mec_currentgearsmin));
			mec_currentgearsmax = Conversions.ToByte(Memory.ReadByte2(5966387));
			mec_gearsmax.set_Text(Conversions.ToString(mec_currentgearsmax));
			mec_currentdrive = Conversions.ToByte(Memory.ReadByte(5966380));
			if (mec_currentdrive == 1)
			{
				mec_drive.set_Text("RWD");
			}
			else if (mec_currentdrive == 2)
			{
				mec_drive.set_Text("FWD");
			}
			else if (mec_currentdrive == 3)
			{
				mec_drive.set_Text("AWD");
			}
			else if (mec_currentdrive == 4)
			{
				mec_drive.set_Text("Default");
			}
			Memory.ReadSingle(5966392, ref mec_currentccmin);
			mec_ccmin.set_Text(Conversions.ToString(mec_currentccmin));
			Memory.ReadSingle(5966396, ref mec_currentccmax);
			mec_ccmax.set_Text(Conversions.ToString(mec_currentccmax));
			Memory.ReadSingle(5966400, ref mec_currenttorque);
			mec_torque.set_Text(Conversions.ToString(mec_currenttorque));
			Memory.ReadSingle(5966412, ref mec_currentpower);
			mec_power.set_Text(Conversions.ToString(mec_currentpower));
			Memory.ReadSingle(5966428, ref mec_currentidle);
			mec_idle.set_Text(Conversions.ToString(mec_currentidle));
			Memory.ReadSingle(5966376, ref mec_currentweight);
			mec_weight.set_Text(Conversions.ToString(mec_currentweight));
		}
	}

	public void mecanikWriter(object currentCarValue)
	{
		if (currentCarValue.Equals("XRG") | currentCarValue.Equals("XFG") | currentCarValue.Equals("UF1"))
		{
			Memory.WriteByte2(5966450, Conversions.ToInteger(mec_cylmin.get_Text()));
			Memory.WriteByte2(5966451, Conversions.ToInteger(mec_cylmax.get_Text()));
			Memory.WriteByte2(5966446, Conversions.ToInteger(mec_gearsmin.get_Text()));
			Memory.WriteByte2(5966447, Conversions.ToInteger(mec_gearsmax.get_Text()));
			if (Operators.CompareString(mec_drive.get_Text(), "RWD", false) == 0)
			{
				Memory.WriteByte(5966440, 1);
			}
			else if (Operators.CompareString(mec_drive.get_Text(), "FWD", false) == 0)
			{
				Memory.WriteByte(5966440, 2);
			}
			else if (Operators.CompareString(mec_drive.get_Text(), "AWD", false) == 0)
			{
				Memory.WriteByte(5966440, 3);
			}
			else
			{
				Memory.WriteByte(5966440, 4);
			}
			Memory.WriteMemorySingle(5966452, Conversions.ToSingle(mec_ccmin.get_Text()));
			Memory.WriteMemorySingle(5966456, Conversions.ToSingle(mec_ccmax.get_Text()));
			Memory.WriteMemorySingle(5966460, Conversions.ToSingle(mec_torque.get_Text()));
			Memory.WriteMemorySingle(5966472, Conversions.ToSingle(mec_power.get_Text()));
			Memory.WriteMemorySingle(5966488, Conversions.ToSingle(mec_idle.get_Text()));
			Memory.WriteMemorySingle(5966436, Conversions.ToSingle(mec_weight.get_Text()));
		}
		else if (currentCarValue.Equals("LX4") | currentCarValue.Equals("LX6") | currentCarValue.Equals("RB4") | currentCarValue.Equals("FXO") | currentCarValue.Equals("XRT") | currentCarValue.Equals("RAC") | currentCarValue.Equals("FZ5"))
		{
			Memory.WriteByte2(5966390, Conversions.ToInteger(mec_cylmin.get_Text()));
			Memory.WriteByte2(5966391, Conversions.ToInteger(mec_cylmax.get_Text()));
			Memory.WriteByte2(5966386, Conversions.ToInteger(mec_gearsmin.get_Text()));
			Memory.WriteByte2(5966387, Conversions.ToInteger(mec_gearsmax.get_Text()));
			if (Operators.CompareString(mec_drive.get_Text(), "RWD", false) == 0)
			{
				Memory.WriteByte(5966380, 1);
			}
			else if (Operators.CompareString(mec_drive.get_Text(), "FWD", false) == 0)
			{
				Memory.WriteByte(5966380, 2);
			}
			else if (Operators.CompareString(mec_drive.get_Text(), "AWD", false) == 0)
			{
				Memory.WriteByte(5966380, 3);
			}
			else
			{
				Memory.WriteByte(5966380, 4);
			}
			Memory.WriteMemorySingle(5966392, Conversions.ToSingle(mec_ccmin.get_Text()));
			Memory.WriteMemorySingle(5966396, Conversions.ToSingle(mec_ccmax.get_Text()));
			Memory.WriteMemorySingle(5966400, Conversions.ToSingle(mec_torque.get_Text()));
			Memory.WriteMemorySingle(5966412, Conversions.ToSingle(mec_power.get_Text()));
			Memory.WriteMemorySingle(5966428, Conversions.ToSingle(mec_idle.get_Text()));
			Memory.WriteMemorySingle(5966376, Conversions.ToSingle(mec_weight.get_Text()));
		}
	}

	public void carSwitcher(string currentCar)
	{
		if (currentCar.Equals("XRG"))
		{
			((TextBoxBase)tyre_rheight).set_ReadOnly(false);
			((TextBoxBase)tyre_rsize).set_ReadOnly(false);
			((TextBoxBase)tyre_rwidth).set_ReadOnly(false);
			((TextBoxBase)tyre_rwidthrim).set_ReadOnly(false);
			((TextBoxBase)tyrerearangle_value).set_ReadOnly(false);
			((TextBoxBase)tyrereartrack_value).set_ReadOnly(false);
			((TextBoxBase)tyrerearypos_value).set_ReadOnly(false);
			Memory.ReadSingle(5854728, ref currenttyrefwidth);
			Memory.ReadSingle(5854732, ref currenttyrefheight);
			Memory.ReadSingle(5854736, ref currenttyrefsize);
			Memory.ReadSingle(5854740, ref currenttyrefwidthrim);
			tyre_fwidth.set_Text(Conversions.ToString(currenttyrefwidth * 1000f));
			tyre_fheight.set_Text(Conversions.ToString(currenttyrefheight * 100f));
			tyre_fsize.set_Text(Conversions.ToString(currenttyrefsize * 100f));
			tyre_fwidthrim.set_Text(Conversions.ToString(currenttyrefwidthrim * 1000f));
			Memory.ReadSingle(5854664, ref currenttyrerwidth);
			Memory.ReadSingle(5854668, ref currenttyrerheight);
			Memory.ReadSingle(5854672, ref currenttyrersize);
			Memory.ReadSingle(5854676, ref currenttyrerwidthrim);
			tyre_rwidth.set_Text(Conversions.ToString(currenttyrerwidth * 1000f));
			tyre_rheight.set_Text(Conversions.ToString(currenttyrerheight * 100f));
			tyre_rsize.set_Text(Conversions.ToString(currenttyrersize * 100f));
			tyre_rwidthrim.set_Text(Conversions.ToString(currenttyrerwidthrim * 1000f));
			currentenginecylinders = Conversions.ToByte(Memory.ReadByte(5852700));
			enginecylinders_value.set_Text(Conversions.ToString(currentenginecylinders));
			Memory.ReadSingle(5852696, ref currentenginecc);
			enginecc_value.set_Text(Conversions.ToString(currentenginecc));
			currentengineturbo = Conversions.ToByte(Memory.ReadByte(5852688));
			if (currentengineturbo == 12)
			{
				engineturbo_value.set_Text("Off");
			}
			else
			{
				engineturbo_value.set_Text("On");
			}
			Memory.ReadSingle(5852708, ref currentengineturbolag);
			engineturbolag_value.set_Text(Conversions.ToString(currentengineturbolag));
			Memory.ReadSingle(5852704, ref currentengineturbopressure);
			engineturbopressure_value.set_Text(Conversions.ToString(currentengineturbopressure));
			float Value = (float)currentenginetorque;
			Memory.ReadSingle(5852728, ref Value);
			currentenginetorque = Value;
			enginetorque_value.set_Text(Conversions.ToString(currentenginetorque));
			Memory.ReadSingle(5852724, ref currentengineredline);
			engineredline_value.set_Text(Conversions.ToString(currentengineredline));
			currentcartype = Conversions.ToByte(Memory.ReadByte(5852672));
			cartype_value.set_Text(Conversions.ToString(currentcartype));
			Memory.ReadSingle(5853424, ref currentfueltank);
			fueltank_value.set_Text(Conversions.ToString(currentfueltank));
			Memory.ReadSingle(5852712, ref currentenginepower);
			enginepower_value.set_Text(Conversions.ToString(currentenginepower));
			Memory.ReadSingle(5853336, ref enginepos);
			enginepos_value.set_Text(Conversions.ToString(enginepos));
			Memory.ReadSingle(5853340, ref massheightpos);
			massheight_value.set_Text(Conversions.ToString(massheightpos));
			Memory.ReadSingle(5854780, ref tyrefrontypos);
			tyrefrontypos_value.set_Text(Conversions.ToString(tyrefrontypos));
			Memory.ReadSingle(5854768, ref tyrefronttrack);
			tyrefronttrack_value.set_Text(Conversions.ToString(tyrefronttrack));
			Memory.ReadSingle(5854764, ref tyrefrontangle);
			tyrefrontangle_value.set_Text(Conversions.ToString(tyrefrontangle));
			Memory.ReadSingle(5854704, ref tyrereartrack);
			tyrereartrack_value.set_Text(Conversions.ToString(tyrereartrack));
			Memory.ReadSingle(5854716, ref tyrerearypos);
			tyrerearypos_value.set_Text(Conversions.ToString(tyrerearypos));
			Memory.ReadSingle(5854700, ref tyrerearangle);
			tyrerearangle_value.set_Text(Conversions.ToString(tyrerearangle));
			currenttransmissiontype = Conversions.ToByte(Memory.ReadByte(5852676));
			if (currenttransmissiontype == 1)
			{
				transmissiontype_value.set_Text("Manual");
			}
			else if (currenttransmissiontype == 2)
			{
				transmissiontype_value.set_Text("Motorbike");
			}
			else if (currenttransmissiontype == 3)
			{
				transmissiontype_value.set_Text("Sequential");
			}
			else if (currenttransmissiontype == 4)
			{
				transmissiontype_value.set_Text("??");
			}
			else if (currenttransmissiontype == 5)
			{
				transmissiontype_value.set_Text("Paddleshift");
			}
			currentenginetype = Conversions.ToInteger(Memory.ReadByte(5852701));
			if (currentenginetype == 0)
			{
				enginetype_value.set_Text("Inline");
			}
			else if (currentenginetype == 1)
			{
				enginetype_value.set_Text("Flat");
			}
			else if (currentenginetype == 2)
			{
				enginetype_value.set_Text("V-Type");
			}
		}
		else if (currentCar.Equals("XFG"))
		{
			((TextBoxBase)tyre_rheight).set_ReadOnly(true);
			((TextBoxBase)tyre_rsize).set_ReadOnly(true);
			((TextBoxBase)tyre_rwidth).set_ReadOnly(true);
			((TextBoxBase)tyre_rwidthrim).set_ReadOnly(true);
			((TextBoxBase)tyrerearangle_value).set_ReadOnly(true);
			((TextBoxBase)tyrereartrack_value).set_ReadOnly(true);
			((TextBoxBase)tyrerearypos_value).set_ReadOnly(true);
			Memory.ReadSingle(5848800, ref currenttyrefwidth);
			Memory.ReadSingle(5848804, ref currenttyrefheight);
			Memory.ReadSingle(5848808, ref currenttyrefsize);
			Memory.ReadSingle(5848812, ref currenttyrefwidthrim);
			tyre_fwidth.set_Text(Conversions.ToString(currenttyrefwidth * 1000f));
			tyre_fheight.set_Text(Conversions.ToString(currenttyrefheight * 100f));
			tyre_fsize.set_Text(Conversions.ToString(currenttyrefsize * 100f));
			tyre_fwidthrim.set_Text(Conversions.ToString(currenttyrefwidth * 1000f));
			currentenginecylinders = Conversions.ToByte(Memory.ReadByte(5846940));
			enginecylinders_value.set_Text(Conversions.ToString(currentenginecylinders));
			Memory.ReadSingle(5846936, ref currentenginecc);
			enginecc_value.set_Text(Conversions.ToString(currentenginecc));
			currentengineturbo = Conversions.ToByte(Memory.ReadByte(5846928));
			if (currentengineturbo == 12)
			{
				engineturbo_value.set_Text("Off");
			}
			else
			{
				engineturbo_value.set_Text("On");
			}
			Memory.ReadSingle(5846948, ref currentengineturbolag);
			engineturbolag_value.set_Text(Conversions.ToString(currentengineturbolag));
			Memory.ReadSingle(5846944, ref currentengineturbopressure);
			engineturbopressure_value.set_Text(Conversions.ToString(currentengineturbopressure));
			float Value = (float)currentenginetorque;
			Memory.ReadSingle(5846968, ref Value);
			currentenginetorque = Value;
			enginetorque_value.set_Text(Conversions.ToString(currentenginetorque));
			Memory.ReadSingle(5846964, ref currentengineredline);
			engineredline_value.set_Text(Conversions.ToString(currentengineredline));
			currentcartype = Conversions.ToByte(Memory.ReadByte(5846912));
			cartype_value.set_Text(Conversions.ToString(currentcartype));
			Memory.ReadSingle(5847664, ref currentfueltank);
			fueltank_value.set_Text(Conversions.ToString(currentfueltank));
			Memory.ReadSingle(5846952, ref currentenginepower);
			enginepower_value.set_Text(Conversions.ToString(currentenginepower));
			Memory.ReadSingle(5847624, ref enginepos);
			enginepos_value.set_Text(Conversions.ToString(enginepos));
			Memory.ReadSingle(5847628, ref massheightpos);
			massheight_value.set_Text(Conversions.ToString(massheightpos));
			Memory.ReadSingle(5848852, ref tyrefrontypos);
			tyrefrontypos_value.set_Text(Conversions.ToString(tyrefrontypos));
			Memory.ReadSingle(5848840, ref tyrefronttrack);
			tyrefronttrack_value.set_Text(Conversions.ToString(tyrefronttrack));
			Memory.ReadSingle(5848836, ref tyrefrontangle);
			tyrefrontangle_value.set_Text(Conversions.ToString(tyrefrontangle));
			currenttransmissiontype = Conversions.ToByte(Memory.ReadByte(5846916));
			if (currenttransmissiontype == 1)
			{
				transmissiontype_value.set_Text("Manual");
			}
			else if (currenttransmissiontype == 2)
			{
				transmissiontype_value.set_Text("Motorbike");
			}
			else if (currenttransmissiontype == 3)
			{
				transmissiontype_value.set_Text("Sequential");
			}
			else if (currenttransmissiontype == 4)
			{
				transmissiontype_value.set_Text("??");
			}
			else if (currenttransmissiontype == 5)
			{
				transmissiontype_value.set_Text("Paddleshift");
			}
			currentenginetype = Conversions.ToInteger(Memory.ReadByte(5846941));
			if (currentenginetype == 0)
			{
				enginetype_value.set_Text("Inline");
			}
			else if (currentenginetype == 1)
			{
				enginetype_value.set_Text("Flat");
			}
			else if (currentenginetype == 2)
			{
				enginetype_value.set_Text("V-Type");
			}
		}
		else if (currentCar.Equals("FBM"))
		{
			((TextBoxBase)tyre_rheight).set_ReadOnly(false);
			((TextBoxBase)tyre_rsize).set_ReadOnly(false);
			((TextBoxBase)tyre_rwidth).set_ReadOnly(false);
			((TextBoxBase)tyre_rwidthrim).set_ReadOnly(false);
			((TextBoxBase)tyrerearangle_value).set_ReadOnly(false);
			((TextBoxBase)tyrereartrack_value).set_ReadOnly(false);
			((TextBoxBase)tyrerearypos_value).set_ReadOnly(false);
			Memory.ReadSingle(5744376, ref currenttyrefwidth);
			Memory.ReadSingle(5744380, ref currenttyrefheight);
			Memory.ReadSingle(5744384, ref currenttyrefsize);
			Memory.ReadSingle(5744388, ref currenttyrefwidthrim);
			tyre_fwidth.set_Text(Conversions.ToString(currenttyrefwidth * 1000f));
			tyre_fheight.set_Text(Conversions.ToString(currenttyrefheight * 100f));
			tyre_fsize.set_Text(Conversions.ToString(currenttyrefsize * 100f));
			tyre_fwidthrim.set_Text(Conversions.ToString(currenttyrefwidthrim * 1000f));
			Memory.ReadSingle(5744312, ref currenttyrerwidth);
			Memory.ReadSingle(5744316, ref currenttyrerheight);
			Memory.ReadSingle(5744320, ref currenttyrersize);
			Memory.ReadSingle(5744324, ref currenttyrerwidthrim);
			tyre_rwidth.set_Text(Conversions.ToString(currenttyrerwidth * 1000f));
			tyre_rheight.set_Text(Conversions.ToString(currenttyrerheight * 100f));
			tyre_rsize.set_Text(Conversions.ToString(currenttyrersize * 100f));
			tyre_rwidthrim.set_Text(Conversions.ToString(currenttyrerwidthrim * 1000f));
			currentenginecylinders = Conversions.ToByte(Memory.ReadByte(5742488));
			enginecylinders_value.set_Text(Conversions.ToString(currentenginecylinders));
			Memory.ReadSingle(5742484, ref currentenginecc);
			enginecc_value.set_Text(Conversions.ToString(currentenginecc));
			currentengineturbo = Conversions.ToByte(Memory.ReadByte(5742476));
			if (currentengineturbo == 12)
			{
				engineturbo_value.set_Text("Off");
			}
			else
			{
				engineturbo_value.set_Text("On");
			}
			Memory.ReadSingle(5742496, ref currentengineturbolag);
			engineturbolag_value.set_Text(Conversions.ToString(currentengineturbolag));
			Memory.ReadSingle(5742492, ref currentengineturbopressure);
			engineturbopressure_value.set_Text(Conversions.ToString(currentengineturbopressure));
			float Value = (float)currentenginetorque;
			Memory.ReadSingle(5742516, ref Value);
			currentenginetorque = Value;
			enginetorque_value.set_Text(Conversions.ToString(currentenginetorque));
			Memory.ReadSingle(5742512, ref currentengineredline);
			engineredline_value.set_Text(Conversions.ToString(currentengineredline));
			currentcartype = Conversions.ToByte(Memory.ReadByte(5742460));
			cartype_value.set_Text(Conversions.ToString(currentcartype));
			Memory.ReadSingle(5743060, ref currentfueltank);
			fueltank_value.set_Text(Conversions.ToString(currentfueltank));
			Memory.ReadSingle(5742500, ref currentenginepower);
			enginepower_value.set_Text(Conversions.ToString(currentenginepower));
			Memory.ReadSingle(5742984, ref enginepos);
			enginepos_value.set_Text(Conversions.ToString(enginepos));
			Memory.ReadSingle(5742988, ref massheightpos);
			massheight_value.set_Text(Conversions.ToString(massheightpos));
			Memory.ReadSingle(5744428, ref tyrefrontypos);
			tyrefrontypos_value.set_Text(Conversions.ToString(tyrefrontypos));
			Memory.ReadSingle(5744416, ref tyrefronttrack);
			tyrefronttrack_value.set_Text(Conversions.ToString(tyrefronttrack));
			Memory.ReadSingle(5744412, ref tyrefrontangle);
			tyrefrontangle_value.set_Text(Conversions.ToString(tyrefrontangle));
			Memory.ReadSingle(5744352, ref tyrereartrack);
			tyrereartrack_value.set_Text(Conversions.ToString(tyrereartrack));
			Memory.ReadSingle(5744364, ref tyrerearypos);
			tyrerearypos_value.set_Text(Conversions.ToString(tyrerearypos));
			Memory.ReadSingle(5744348, ref tyrerearangle);
			tyrerearangle_value.set_Text(Conversions.ToString(tyrerearangle));
			currenttransmissiontype = Conversions.ToByte(Memory.ReadByte(5742464));
			if (currenttransmissiontype == 1)
			{
				transmissiontype_value.set_Text("Manual");
			}
			else if (currenttransmissiontype == 2)
			{
				transmissiontype_value.set_Text("Motorbike");
			}
			else if (currenttransmissiontype == 3)
			{
				transmissiontype_value.set_Text("Sequential");
			}
			else if (currenttransmissiontype == 4)
			{
				transmissiontype_value.set_Text("??");
			}
			else if (currenttransmissiontype == 5)
			{
				transmissiontype_value.set_Text("Paddleshift");
			}
			currentenginetype = Conversions.ToInteger(Memory.ReadByte(5742489));
			if (currentenginetype == 0)
			{
				enginetype_value.set_Text("Inline");
			}
			else if (currentenginetype == 1)
			{
				enginetype_value.set_Text("Flat");
			}
			else if (currentenginetype == 2)
			{
				enginetype_value.set_Text("V-Type");
			}
		}
	}

	public void carRefresh()
	{
		Memory.ReadMemory(6259912, ref currentCarValue);
		currentCar.set_Text(currentCarValue);
		mecanikUpdater(currentCarValue);
		carSwitcher(currentCarValue);
	}

	public void saveSetup()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog1.set_OverwritePrompt(true);
		((FileDialog)SaveFileDialog1).set_Filter("LTC|*.ltc");
		if (!((Enum)((CommonDialog)SaveFileDialog1).ShowDialog()).Equals((object)(DialogResult)1))
		{
			return;
		}
		try
		{
			FileStream fileStream = new FileStream(((FileDialog)SaveFileDialog1).get_FileName(), FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("car_config:" + currentCar.get_Text());
			if (currentCarValue.Equals("XRG") | currentCarValue.Equals("XFG") | currentCarValue.Equals("UF1"))
			{
				streamWriter.WriteLine("lfstweak_engine_cc:" + enginecc_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_cylinders:" + enginecylinders_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_type:" + ((Operators.CompareString(enginetype_value.get_Text(), "Inline", false) != 0) ? ((Operators.CompareString(enginetype_value.get_Text(), "Flat", false) == 0) ? 1 : 2) : 0));
				streamWriter.WriteLine("lfstweak_engine_turbo:" + ((Operators.CompareString(engineturbo_value.get_Text(), "On", false) != 0) ? 12 : 13));
				streamWriter.WriteLine("lfstweak_engine_turbo_pressure:" + engineturbopressure_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_turbo_lag:" + engineturbolag_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_torque:" + enginetorque_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_transmission_type:" + ((Operators.CompareString(transmissiontype_value.get_Text(), "Manual", false) == 0) ? 1 : ((Operators.CompareString(transmissiontype_value.get_Text(), "Motorbike", false) == 0) ? 2 : ((Operators.CompareString(transmissiontype_value.get_Text(), "Sequential", false) == 0) ? 3 : ((Operators.CompareString(transmissiontype_value.get_Text(), "??", false) != 0) ? 5 : 4)))));
				streamWriter.WriteLine("lfstweak_engine_redline:" + engineredline_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_fueltank:" + fueltank_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_power:" + enginepower_value.get_Text());
				streamWriter.WriteLine("lfstweak_engine_cartype:" + cartype_value.get_Text());
				streamWriter.WriteLine("lfstweak_front_tyre_width:" + tyre_fwidthrim.get_Text());
				streamWriter.WriteLine("lfstweak_front_tyre_height:" + tyre_fheight.get_Text());
				streamWriter.WriteLine("lfstweak_front_rim_size:" + tyre_fsize.get_Text());
				streamWriter.WriteLine("lfstweak_front_rim_width:" + tyre_fwidthrim.get_Text());
				streamWriter.WriteLine("lfstweak_rear_tyre_width:" + tyre_rwidth.get_Text());
				streamWriter.WriteLine("lfstweak_rear_tyre_height:" + tyre_rheight.get_Text());
				streamWriter.WriteLine("lfstweak_rear_rim_size:" + tyre_rsize.get_Text());
				streamWriter.WriteLine("lfstweak_rear_rim_width:" + tyre_rwidthrim.get_Text());
				streamWriter.WriteLine("lfstweak_enginepos:" + enginepos_value.get_Text());
				streamWriter.WriteLine("lfstweak_massheight:" + massheight_value.get_Text());
				streamWriter.WriteLine("lfstweak_tyrefronttrack:" + tyrefronttrack_value.get_Text());
				streamWriter.WriteLine("lfstweak_tyrefrontangle:" + tyrefrontangle_value.get_Text());
				streamWriter.WriteLine("lfstweak_tyrefrontypos:" + tyrefrontypos_value.get_Text());
				streamWriter.WriteLine("lfstweak_tyrereartrack:" + tyrereartrack_value.get_Text());
				streamWriter.WriteLine("lfstweak_tyrerearangle:" + tyrerearangle_value.get_Text());
				streamWriter.WriteLine("lfstweak_tyrerearypos:" + tyrerearypos_value.get_Text());
			}
			if (currentCarValue.Equals("XRG") | currentCarValue.Equals("XFG") | currentCarValue.Equals("UF1"))
			{
				streamWriter.WriteLine("lfsmec_cartype:2");
			}
			streamWriter.WriteLine("lfsmec_engine_cc_min:" + mec_ccmin.get_Text());
			streamWriter.WriteLine("lfsmec_engine_cc_max:" + mec_ccmax.get_Text());
			streamWriter.WriteLine("lfsmec_engine_cylinders_min:" + mec_cylmin.get_Text());
			streamWriter.WriteLine("lfsmec_engine_cylinders_max:" + mec_cylmax.get_Text());
			streamWriter.WriteLine("lfsmec_engine_torque:" + mec_torque.get_Text());
			streamWriter.WriteLine("lfsmec_engine_power:" + mec_power.get_Text());
			streamWriter.WriteLine("lfsmec_engine_gears_min:" + mec_gearsmin.get_Text());
			streamWriter.WriteLine("lfsmec_engine_gears_max:" + mec_gearsmax.get_Text());
			streamWriter.WriteLine("lfsmec_engine_idle:" + mec_idle.get_Text());
			streamWriter.WriteLine("lfsmec_weight:" + mec_weight.get_Text());
			if (Operators.CompareString(mec_drive.get_Text(), "RWD", false) == 0)
			{
				streamWriter.WriteLine("lfsmec_drive:1");
			}
			else if (Operators.CompareString(mec_drive.get_Text(), "FWD", false) == 0)
			{
				streamWriter.WriteLine("lfsmec_drive:2");
			}
			else if (Operators.CompareString(mec_drive.get_Text(), "AWD", false) == 0)
			{
				streamWriter.WriteLine("lfsmec_drive:3");
			}
			else
			{
				streamWriter.WriteLine("lfsmec_drive:4");
			}
			streamWriter.Close();
			fileStream.Close();
			Interaction.MsgBox((object)"Setup succesfully saved!", (MsgBoxStyle)0, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Couldn't open file. Maybe it is in use?", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void loadFile()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		((FileDialog)OpenFileDialog1).set_Filter("LTC|*.ltc");
		if (!((Enum)((CommonDialog)OpenFileDialog1).ShowDialog()).Equals((object)(DialogResult)1))
		{
			return;
		}
		FileStream fileStream = new FileStream(((FileDialog)OpenFileDialog1).get_FileName(), FileMode.Open, FileAccess.Read);
		StreamReader streamReader = new StreamReader(fileStream);
		string text;
		do
		{
			text = streamReader.ReadLine();
			if (Operators.CompareString(text, (string)null, false) == 0)
			{
				continue;
			}
			string[] array = text.Split(new char[1] { ':' });
			string text2 = array[1].Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
			array[1] = text2.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
			if (array[0].Equals("car_config"))
			{
				currentCar.set_Text(array[1]);
				currentCarValue = array[1];
			}
			else if (array[0].Equals("lfstweak_engine_cc"))
			{
				enginecc_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_cylinders"))
			{
				enginecylinders_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_type"))
			{
				if (array[1].Equals("0"))
				{
					enginetype_value.set_Text("Inline");
				}
				else if (array[1].Equals("1"))
				{
					enginetype_value.set_Text("Flat");
				}
				else if (array[1].Equals("2"))
				{
					enginetype_value.set_Text("V-Type");
				}
			}
			else if (array[0].Equals("lfstweak_engine_turbo"))
			{
				if (array[1].Equals("12"))
				{
					engineturbo_value.set_Text("Off");
				}
				else
				{
					engineturbo_value.set_Text("On");
				}
			}
			else if (array[0].Equals("lfstweak_engine_turbo_pressure"))
			{
				engineturbopressure_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_turbo_lag"))
			{
				engineturbolag_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_torque"))
			{
				enginetorque_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_transmission_type"))
			{
				if (array[1].Equals("1"))
				{
					transmissiontype_value.set_Text("Manual");
				}
				else if (array[1].Equals("2"))
				{
					transmissiontype_value.set_Text("Motorbike");
				}
				else if (array[1].Equals("3"))
				{
					transmissiontype_value.set_Text("Sequential");
				}
				else if (array[1].Equals("4"))
				{
					transmissiontype_value.set_Text("??");
				}
				else if (array[1].Equals("5"))
				{
					transmissiontype_value.set_Text("Paddleshift");
				}
			}
			else if (array[0].Equals("lfstweak_engine_redline"))
			{
				engineredline_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_fueltank"))
			{
				fueltank_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_power"))
			{
				enginepower_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_engine_cartype"))
			{
				cartype_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_front_tyre_width"))
			{
				tyre_fwidth.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_front_tyre_height"))
			{
				tyre_fheight.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_front_rim_size"))
			{
				tyre_fsize.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_front_rim_width"))
			{
				tyre_fwidthrim.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_rear_tyre_width"))
			{
				tyre_rwidth.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_rear_tyre_height"))
			{
				tyre_rheight.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_rear_rim_size"))
			{
				tyre_rsize.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_rear_rim_width"))
			{
				tyre_rwidthrim.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_enginepos"))
			{
				enginepos_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_massheight"))
			{
				massheight_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_tyrefronttrack"))
			{
				tyrefronttrack_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_tyrefrontangle"))
			{
				tyrefrontangle_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_tyrefrontypos"))
			{
				tyrefrontypos_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_tyrereartrack"))
			{
				tyrereartrack_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_tyrerearangle"))
			{
				tyrerearangle_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfstweak_tyrerearypos"))
			{
				tyrerearypos_value.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_cc_min"))
			{
				mec_ccmin.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_cc_max"))
			{
				mec_ccmax.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_cylinders_min"))
			{
				mec_cylmin.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_cylinders_max"))
			{
				mec_cylmax.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_torque"))
			{
				mec_torque.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_power"))
			{
				mec_power.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_gears_min"))
			{
				mec_gearsmin.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_gears_max"))
			{
				mec_gearsmax.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_engine_idle"))
			{
				mec_idle.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_weight"))
			{
				mec_weight.set_Text(array[1]);
			}
			else if (array[0].Equals("lfsmec_drive"))
			{
				if (array[1].Equals("1"))
				{
					mec_drive.set_Text("RWD");
				}
				else if (array[1].Equals("2"))
				{
					mec_drive.set_Text("FWD");
				}
				else if (array[1].Equals("3"))
				{
					mec_drive.set_Text("AWD");
				}
				else if (array[1].Equals("4"))
				{
					mec_drive.set_Text("Default");
				}
			}
		}
		while (text != null);
		streamReader.Close();
		fileStream.Close();
		if (currentCarValue.Equals("XRG") | currentCarValue.Equals("XFG") | currentCarValue.Equals("FBM"))
		{
			carUpdate(currentCar.get_Text());
		}
		mecanikWriter(currentCar.get_Text());
		Interaction.MsgBox((object)"Setup succesfully loaded!", (MsgBoxStyle)0, (object)null);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Memory.ReadMemory(6259912, ref currentCarValue);
		currentCar.set_Text(currentCarValue);
		mecanikUpdater(currentCar.get_Text());
		carSwitcher(currentCar.get_Text());
	}

	private void applyButton_Click(object sender, EventArgs e)
	{
		carUpdate(currentCar.get_Text());
		mecanikWriter(currentCar.get_Text());
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		carRefresh();
		mecanikUpdater(currentCar.get_Text());
	}

	private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
	{
		saveSetup();
	}

	private void FileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		loadFile();
	}

	private void Label27_Click(object sender, EventArgs e)
	{
	}
}
