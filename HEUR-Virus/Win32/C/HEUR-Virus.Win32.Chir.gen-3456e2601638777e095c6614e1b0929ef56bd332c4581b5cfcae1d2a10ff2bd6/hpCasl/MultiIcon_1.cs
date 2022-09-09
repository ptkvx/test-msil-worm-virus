using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using hpCasl.Properties;

namespace hpCasl;

public class MultiIcon_1 : GForm0
{
	public delegate void GDelegate0(MultiIcon_1 multiIcon_1_0);

	private struct Struct0
	{
		public int int_0;

		public Point point_0;

		public int int_1;

		public GEnum0 genum0_0;

		public GEnum1 genum1_0;

		public GEnum1 genum1_1;
	}

	private struct Struct1
	{
		public uint uint_0;

		public string string_0;

		public string string_1;

		public string string_2;
	}

	private struct Struct2
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public Point point_0;

		public int int_3;

		public Point point_1;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;

		public bool bool_0;

		public Bitmap bitmap_0;

		public Bitmap bitmap_1;

		public Icon icon_0;

		public Icon icon_1;

		public Icon icon_2;
	}

	private GDelegate0 gdelegate0_0;

	private Struct0 struct0_0;

	private Struct1 struct1_0;

	private Struct2 struct2_0;

	private IContainer icontainer_0;

	private Timer timer_0;

	private Timer timer_1;

	protected override bool ShowWithoutActivation => true;

	[SpecialName]
	public uint method_5()
	{
		return struct1_0.uint_0;
	}

	[SpecialName]
	public static uint smethod_0()
	{
		uint num = Class1.class0_0.method_23();
		if (num < 1)
		{
			num = 1u;
		}
		return num;
	}

	public static bool smethod_1(string string_0, out uint uint_0)
	{
		bool result = false;
		uint_0 = 0u;
		try
		{
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(string_0));
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType == XmlNodeType.Element && xmlTextReader.Name == "ID")
				{
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					if (uint.TryParse(xmlTextReader.Value, out var result2))
					{
						uint_0 = result2;
						result = true;
					}
				}
			}
			return result;
		}
		catch
		{
			return result;
		}
	}

	[SpecialName]
	public Point method_6()
	{
		return new Point(struct0_0.point_0.X + struct2_0.int_0 + struct2_0.int_2, struct0_0.point_0.Y);
	}

	public MultiIcon_1(GDelegate0 gdelegate0_1, int int_2, string string_0)
	{
		gdelegate0_0 = gdelegate0_1;
		InitializeComponent();
		method_9();
		struct0_0.int_0 = int_2;
		method_10();
		method_7(string_0);
	}

	public void method_7(string string_0)
	{
		Random random = new Random();
		struct1_0.uint_0 = (uint)random.Next();
		struct1_0.string_0 = null;
		struct1_0.string_1 = null;
		struct1_0.string_2 = null;
		try
		{
			XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(string_0));
			while (xmlTextReader.Read())
			{
				if (xmlTextReader.NodeType != XmlNodeType.Element)
				{
					continue;
				}
				switch (xmlTextReader.Name)
				{
				case "RightIconPath":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct1_0.string_2 = xmlTextReader.Value;
					break;
				case "MiddleIconPath":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct1_0.string_1 = xmlTextReader.Value;
					break;
				case "LeftIconPath":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct1_0.string_0 = xmlTextReader.Value;
					break;
				case "ID":
				{
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					if (uint.TryParse(xmlTextReader.Value, out var result))
					{
						struct1_0.uint_0 = result;
					}
					break;
				}
				}
			}
		}
		catch
		{
		}
		method_13();
		method_12(GEnum0.const_0);
	}

	public void method_8(int int_2)
	{
		struct0_0.int_0 = int_2;
		Point point_ = method_11(int_2);
		struct0_0.point_0 = point_;
		timer_1.set_Enabled(true);
	}

	private void method_9()
	{
		struct0_0.int_0 = 0;
		struct0_0.point_0 = new Point(0, 0);
		struct0_0.int_1 = 0;
		struct0_0.genum1_1 = GEnum1.const_0;
		struct0_0.genum0_0 = GEnum0.const_0;
	}

	private void method_10()
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		struct2_0.int_0 = method_1(MultiIcon.Default.Width);
		struct2_0.int_1 = method_2(MultiIcon.Default.Height);
		struct2_0.int_2 = method_1(MultiIcon.Default.Margin);
		struct2_0.point_0 = method_4(MultiIcon.Default.IconLocation);
		struct2_0.int_3 = method_1(MultiIcon.Default.IconSpacing);
		struct2_0.point_1 = method_4(MultiIcon.Default.CloseButtonLocation);
		struct2_0.int_4 = MultiIcon.Default.OpacityFadeSpeed;
		struct2_0.int_5 = MultiIcon.Default.OpacityStepPercent;
		struct2_0.int_6 = MultiIcon.Default.OpacityNormalPercent;
		struct2_0.int_7 = MultiIcon.Default.OpacityHoverPercent;
		struct2_0.int_8 = MultiIcon.Default.MoveDivisor;
		struct2_0.int_9 = MultiIcon.Default.MoveDuration;
		struct2_0.int_10 = (int)Class1.class0_0.method_22();
		struct2_0.bool_0 = MultiIcon.Default.EnablePopUpEffect;
		struct2_0.bitmap_0 = null;
		struct2_0.bitmap_1 = null;
		struct2_0.icon_0 = null;
		struct2_0.icon_1 = null;
		struct2_0.icon_2 = null;
		if (struct2_0.int_8 < 2)
		{
			struct2_0.int_8 = 2;
		}
		if (struct2_0.int_9 < 1)
		{
			struct2_0.int_9 = 1;
		}
		if (struct2_0.int_10 < 1)
		{
			struct2_0.int_10 = 1;
		}
		((Form)this).set_Opacity((double)struct0_0.int_1 / 100.0);
		timer_1.set_Interval(struct2_0.int_9);
		((Form)this).set_ClientSize(new Size(struct2_0.int_0, struct2_0.int_1));
		struct2_0.bitmap_0 = new Bitmap(struct2_0.int_0, struct2_0.int_1);
		Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule!.FileName));
		if (!string.IsNullOrEmpty(MultiIcon.Default.BackgroundImage) && File.Exists(MultiIcon.Default.BackgroundImage))
		{
			Bitmap val = new Bitmap(MultiIcon.Default.BackgroundImage);
			struct2_0.bitmap_1 = new Bitmap(struct2_0.int_0, struct2_0.int_1);
			Graphics val2 = Graphics.FromImage((Image)(object)struct2_0.bitmap_1);
			try
			{
				val2.DrawImage((Image)(object)val, new Rectangle(Point.Empty, ((Image)struct2_0.bitmap_1).get_Size()), new Rectangle(Point.Empty, ((Image)val).get_Size()), (GraphicsUnit)2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		struct2_0.icon_0 = Resources.Close;
		struct2_0.icon_1 = Resources.CloseHover;
		struct2_0.icon_2 = Resources.CloseClicked;
		if (!string.IsNullOrEmpty(MultiIcon.Default.CloseIcon) && File.Exists(MultiIcon.Default.CloseIcon))
		{
			struct2_0.icon_0 = new Icon(MultiIcon.Default.CloseIcon);
		}
		if (!string.IsNullOrEmpty(MultiIcon.Default.CloseHoverIcon) && File.Exists(MultiIcon.Default.CloseHoverIcon))
		{
			struct2_0.icon_1 = new Icon(MultiIcon.Default.CloseHoverIcon);
		}
		if (!string.IsNullOrEmpty(MultiIcon.Default.CloseClickedIcon) && File.Exists(MultiIcon.Default.CloseClickedIcon))
		{
			struct2_0.icon_2 = new Icon(MultiIcon.Default.CloseClickedIcon);
		}
	}

	private Point method_11(int int_2)
	{
		Point result = new Point(0, 0);
		Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
		int num = workingArea.Height / (struct2_0.int_2 + ((Control)this).get_Height());
		int num2 = int_2 / num;
		int num3 = int_2 % num;
		result.X = workingArea.Right - (struct2_0.int_2 + ((Control)this).get_Width()) * (num2 + 1);
		result.Y = workingArea.Bottom - (struct2_0.int_2 + ((Control)this).get_Height()) * (num3 + 1);
		return result;
	}

	private void method_12(GEnum0 genum0_0)
	{
		struct0_0.genum0_0 = genum0_0;
		int interval = 0;
		switch (genum0_0)
		{
		case GEnum0.const_2:
			interval = struct2_0.int_10;
			break;
		case GEnum0.const_0:
		case GEnum0.const_1:
		case GEnum0.const_3:
			interval = struct2_0.int_4 * struct2_0.int_5 / struct2_0.int_6;
			break;
		}
		timer_0.set_Interval(interval);
		timer_0.set_Enabled(true);
	}

	private void method_13()
	{
		if (struct2_0.bitmap_0 == null)
		{
			return;
		}
		Graphics val = Graphics.FromImage((Image)(object)struct2_0.bitmap_0);
		try
		{
			if (struct2_0.bitmap_1 != null)
			{
				val.DrawImage((Image)(object)struct2_0.bitmap_1, 0, 0);
			}
			else
			{
				method_0(val, struct0_0.genum1_0);
			}
			if (File.Exists(struct1_0.string_0))
			{
				Icon val2 = Icon.ExtractAssociatedIcon(struct1_0.string_0);
				val.DrawIcon(val2, struct2_0.point_0.X, struct2_0.point_0.Y);
				val2.Dispose();
			}
			if (File.Exists(struct1_0.string_1))
			{
				Icon val3 = Icon.ExtractAssociatedIcon(struct1_0.string_1);
				val.DrawIcon(val3, struct2_0.point_0.X + struct2_0.int_3, struct2_0.point_0.Y);
				val3.Dispose();
			}
			if (File.Exists(struct1_0.string_2))
			{
				Icon val4 = Icon.ExtractAssociatedIcon(struct1_0.string_2);
				val.DrawIcon(val4, struct2_0.point_0.X + struct2_0.int_3 * 2, struct2_0.point_0.Y);
				val4.Dispose();
			}
			Icon val5 = null;
			switch (struct0_0.genum1_1)
			{
			case GEnum1.const_0:
				val5 = struct2_0.icon_0;
				break;
			case GEnum1.const_1:
				val5 = struct2_0.icon_1;
				break;
			case GEnum1.const_2:
				val5 = struct2_0.icon_2;
				break;
			}
			val.DrawIcon(val5, new Rectangle(struct2_0.point_1.X, struct2_0.point_1.Y, method_1(val5.get_Width()), method_2(val5.get_Height())));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		((Control)this).Invalidate();
	}

	private void MultiIcon_1_Load(object sender, EventArgs e)
	{
		Point location = method_11(struct0_0.int_0);
		if (struct2_0.bool_0)
		{
			location = method_11(0);
		}
		((Form)this).set_Location(location);
		method_8(struct0_0.int_0);
		try
		{
			Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MinWorkingSet;
		}
		catch
		{
		}
	}

	private void MultiIcon_1_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (gdelegate0_0 != null)
		{
			gdelegate0_0(this);
		}
	}

	private void MultiIcon_1_MouseEnter(object sender, EventArgs e)
	{
		struct0_0.genum1_0 = GEnum1.const_1;
		method_13();
		method_12(GEnum0.const_1);
	}

	private void MultiIcon_1_MouseLeave(object sender, EventArgs e)
	{
		if (struct0_0.genum1_1 != 0)
		{
			struct0_0.genum1_1 = GEnum1.const_0;
		}
		struct0_0.genum1_0 = GEnum1.const_0;
		method_13();
		method_12(GEnum0.const_0);
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		Point point = new Point(0, 0);
		if (((Form)this).get_Location().X == struct0_0.point_0.X && ((Form)this).get_Location().Y == struct0_0.point_0.Y)
		{
			timer_1.set_Enabled(false);
			return;
		}
		if (((Form)this).get_Location().X != struct0_0.point_0.X)
		{
			point.X = (struct0_0.point_0.X - ((Form)this).get_Location().X) / struct2_0.int_8;
			if (point.X == 0)
			{
				point.X = ((struct0_0.point_0.X > ((Form)this).get_Location().X) ? 1 : (-1));
			}
		}
		if (((Form)this).get_Location().Y != struct0_0.point_0.Y)
		{
			point.Y = (struct0_0.point_0.Y - ((Form)this).get_Location().Y) / struct2_0.int_8;
			if (point.Y == 0)
			{
				point.Y = ((struct0_0.point_0.Y > ((Form)this).get_Location().Y) ? 1 : (-1));
			}
		}
		((Form)this).set_Location(new Point(((Form)this).get_Location().X + point.X, ((Form)this).get_Location().Y + point.Y));
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		switch (struct0_0.genum0_0)
		{
		case GEnum0.const_0:
			if (struct0_0.int_1 == struct2_0.int_6)
			{
				method_12(GEnum0.const_2);
			}
			else if (struct0_0.int_1 > struct2_0.int_6)
			{
				struct0_0.int_1 -= struct2_0.int_5;
				if (struct0_0.int_1 < struct2_0.int_6)
				{
					struct0_0.int_1 = struct2_0.int_6;
				}
				((Form)this).set_Opacity((double)struct0_0.int_1 / 100.0);
			}
			else
			{
				struct0_0.int_1 += struct2_0.int_5;
				if (struct0_0.int_1 > struct2_0.int_6)
				{
					struct0_0.int_1 = struct2_0.int_6;
				}
				((Form)this).set_Opacity((double)struct0_0.int_1 / 100.0);
			}
			break;
		case GEnum0.const_1:
			if (struct0_0.int_1 == struct2_0.int_7)
			{
				timer_0.set_Enabled(false);
			}
			else if (struct0_0.int_1 > struct2_0.int_7)
			{
				struct0_0.int_1 -= struct2_0.int_5;
				if (struct0_0.int_1 < struct2_0.int_7)
				{
					struct0_0.int_1 = struct2_0.int_7;
				}
				((Form)this).set_Opacity((double)struct0_0.int_1 / 100.0);
			}
			else
			{
				struct0_0.int_1 += struct2_0.int_5;
				if (struct0_0.int_1 > struct2_0.int_7)
				{
					struct0_0.int_1 = struct2_0.int_7;
				}
				((Form)this).set_Opacity((double)struct0_0.int_1 / 100.0);
			}
			break;
		case GEnum0.const_2:
			method_12(GEnum0.const_3);
			break;
		case GEnum0.const_3:
			if (struct0_0.int_1 <= 0)
			{
				timer_0.set_Enabled(false);
				((Form)this).Close();
				break;
			}
			struct0_0.int_1 -= struct2_0.int_5;
			if (struct0_0.int_1 < 0)
			{
				struct0_0.int_1 = 0;
			}
			((Form)this).set_Opacity((double)struct0_0.int_1 / 100.0);
			break;
		}
	}

	private void MultiIcon_1_Paint(object sender, PaintEventArgs e)
	{
		if (struct2_0.bitmap_0 != null)
		{
			e.get_Graphics().DrawImage((Image)(object)struct2_0.bitmap_0, 0, 0);
		}
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	private void MultiIcon_1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		bool flag = false;
		if (struct2_0.icon_0 != null)
		{
			bool flag2 = new Rectangle(struct2_0.point_1.X, struct2_0.point_1.Y, method_1(struct2_0.icon_0.get_Width()), method_2(struct2_0.icon_0.get_Height())).Contains(e.get_Location());
			GEnum1 gEnum = GEnum1.const_0;
			if (flag2)
			{
				gEnum = (((int)e.get_Button() != 1048576) ? GEnum1.const_1 : GEnum1.const_2);
			}
			if (gEnum != struct0_0.genum1_1)
			{
				struct0_0.genum1_1 = gEnum;
				flag = true;
			}
		}
		GEnum1 gEnum2 = GEnum1.const_0;
		gEnum2 = (((int)e.get_Button() != 1048576) ? GEnum1.const_1 : ((struct0_0.genum1_1 == GEnum1.const_2) ? GEnum1.const_1 : GEnum1.const_2));
		if (gEnum2 != struct0_0.genum1_0)
		{
			struct0_0.genum1_0 = gEnum2;
			flag = true;
		}
		if (flag)
		{
			method_13();
		}
	}

	private void MultiIcon_1_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && struct2_0.icon_0 != null && new Rectangle(struct2_0.point_1.X, struct2_0.point_1.Y, method_1(struct2_0.icon_0.get_Width()), method_2(struct2_0.icon_0.get_Height())).Contains(e.get_Location()))
		{
			((Form)this).Close();
		}
	}

	private void MultiIcon_1_MouseDown(object sender, MouseEventArgs e)
	{
		MultiIcon_1_MouseMove(sender, e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_ClientSize(new Size(284, 69));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("MultiIcon");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("MultiIcon");
		((Form)this).add_Load((EventHandler)MultiIcon_1_Load);
		((Control)this).add_MouseUp(new MouseEventHandler(MultiIcon_1_MouseUp));
		((Control)this).add_Paint(new PaintEventHandler(MultiIcon_1_Paint));
		((Control)this).add_MouseEnter((EventHandler)MultiIcon_1_MouseEnter);
		((Form)this).add_FormClosed(new FormClosedEventHandler(MultiIcon_1_FormClosed));
		((Control)this).add_MouseDown(new MouseEventHandler(MultiIcon_1_MouseDown));
		((Control)this).add_MouseLeave((EventHandler)MultiIcon_1_MouseLeave);
		((Control)this).add_MouseMove(new MouseEventHandler(MultiIcon_1_MouseMove));
		((Control)this).ResumeLayout(false);
	}
}
