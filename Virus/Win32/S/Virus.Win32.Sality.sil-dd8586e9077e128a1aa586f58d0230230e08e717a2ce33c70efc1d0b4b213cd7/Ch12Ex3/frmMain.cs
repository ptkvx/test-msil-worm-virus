using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Course;

namespace Ch12Ex3;

public class frmMain : Form
{
	[AccessedThroughProperty("btnExit")]
	private Button _btnExit;

	[AccessedThroughProperty("btnShuffle")]
	private Button _btnShuffle;

	[AccessedThroughProperty("lstCards")]
	private ListBox _lstCards;

	private IContainer components;

	internal virtual ListBox lstCards
	{
		get
		{
			return _lstCards;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_lstCards == null)
			{
			}
			_lstCards = value;
			if (_lstCards != null)
			{
			}
		}
	}

	internal virtual Button btnShuffle
	{
		get
		{
			return _btnShuffle;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnShuffle != null)
			{
				((Control)_btnShuffle).remove_Click((EventHandler)btnShuffle_Click);
			}
			_btnShuffle = value;
			if (_btnShuffle != null)
			{
				((Control)_btnShuffle).add_Click((EventHandler)btnShuffle_Click);
			}
		}
	}

	internal virtual Button btnExit
	{
		get
		{
			return _btnExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_btnExit != null)
			{
				((Control)_btnExit).remove_Click((EventHandler)btnExit_Click);
			}
			_btnExit = value;
			if (_btnExit != null)
			{
				((Control)_btnExit).add_Click((EventHandler)btnExit_Click);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new frmMain());
	}

	public frmMain()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		lstCards = new ListBox();
		btnShuffle = new Button();
		btnExit = new Button();
		((Control)this).SuspendLayout();
		ListBox obj = lstCards;
		Point location = new Point(16, 24);
		((Control)obj).set_Location(location);
		((Control)lstCards).set_Name("lstCards");
		ListBox obj2 = lstCards;
		Size size = new Size(200, 264);
		((Control)obj2).set_Size(size);
		((Control)lstCards).set_TabIndex(0);
		((ButtonBase)btnShuffle).set_FlatStyle((FlatStyle)0);
		Button obj3 = btnShuffle;
		location = new Point(248, 208);
		((Control)obj3).set_Location(location);
		((Control)btnShuffle).set_Name("btnShuffle");
		Button obj4 = btnShuffle;
		size = new Size(120, 32);
		((Control)obj4).set_Size(size);
		((Control)btnShuffle).set_TabIndex(1);
		((Control)btnShuffle).set_Text("Shuffle");
		((ButtonBase)btnExit).set_FlatStyle((FlatStyle)0);
		Button obj5 = btnExit;
		location = new Point(248, 256);
		((Control)obj5).set_Location(location);
		((Control)btnExit).set_Name("btnExit");
		Button obj6 = btnExit;
		size = new Size(120, 32);
		((Control)obj6).set_Size(size);
		((Control)btnExit).set_TabIndex(2);
		((Control)btnExit).set_Text("Exit");
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		size = new Size(432, 325);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			(Control)btnExit,
			(Control)btnShuffle,
			(Control)lstCards
		});
		((Control)this).set_Name("frmMain");
		((Control)this).set_Text("Chapter 12, Exercise 3");
		((Control)this).ResumeLayout(false);
	}

	private void btnShuffle_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Deck val = new Deck();
		lstCards.get_Items().Clear();
		val.Shuffle();
		int num = 1;
		do
		{
			lstCards.get_Items().Add((object)val.DealCard());
			num = checked(num + 1);
		}
		while (num <= 52);
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
