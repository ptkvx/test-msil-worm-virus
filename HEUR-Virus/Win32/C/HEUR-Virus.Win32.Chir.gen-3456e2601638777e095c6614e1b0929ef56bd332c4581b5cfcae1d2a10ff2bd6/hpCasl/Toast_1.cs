using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using hpCasl.Properties;

namespace hpCasl;

public class Toast_1 : GForm0
{
	public delegate void GDelegate2(Toast_1 toast_1_0);

	private struct Struct6
	{
		public int int_0;

		public Point point_0;

		public Point point_1;

		public int int_1;

		public GEnum0 genum0_0;

		public GEnum1 genum1_0;

		public GEnum1 genum1_1;
	}

	private struct Struct7
	{
		public uint uint_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public string string_4;
	}

	private struct Struct8
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public string string_0;

		public FontStyle fontStyle_0;

		public int int_3;

		public Color color_0;

		public Rectangle rectangle_0;

		public string string_1;

		public FontStyle fontStyle_1;

		public int int_4;

		public Color color_1;

		public Rectangle rectangle_1;

		public Point point_0;

		public Point point_1;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public int int_10;

		public int int_11;

		public bool bool_0;

		public Bitmap bitmap_0;

		public Bitmap bitmap_1;

		public Icon icon_0;

		public Icon icon_1;

		public Icon icon_2;
	}

	private GDelegate2 gdelegate2_0;

	private Struct6 struct6_0;

	private Struct7 struct7_0;

	private Struct8 struct8_0;

	private IContainer icontainer_0;

	private Timer timer_0;

	private Timer timer_1;

	protected override bool ShowWithoutActivation => true;

	[SpecialName]
	public uint method_5()
	{
		return struct7_0.uint_0;
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

	public Toast_1(GDelegate2 gdelegate2_1, int int_2, Point point_0, string string_0)
	{
		gdelegate2_0 = gdelegate2_1;
		InitializeComponent();
		method_10();
		struct6_0.int_0 = int_2;
		struct6_0.point_0 = point_0;
		method_11();
		method_6(string_0);
	}

	public void method_6(string string_0)
	{
		Random random = new Random();
		struct7_0.uint_0 = (uint)random.Next();
		struct7_0.string_0 = "";
		struct7_0.string_1 = "";
		struct7_0.string_2 = null;
		struct7_0.string_3 = null;
		struct7_0.string_4 = null;
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
				case "Parameters":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct7_0.string_4 = xmlTextReader.Value;
					break;
				case "Path":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct7_0.string_3 = xmlTextReader.Value;
					break;
				case "IconPath":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct7_0.string_2 = xmlTextReader.Value;
					break;
				case "Text":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct7_0.string_1 = xmlTextReader.Value;
					break;
				case "Title":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct7_0.string_0 = xmlTextReader.Value;
					break;
				case "ID":
				{
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					if (uint.TryParse(xmlTextReader.Value, out var result))
					{
						struct7_0.uint_0 = result;
					}
					break;
				}
				}
			}
		}
		catch
		{
		}
		if (string.IsNullOrEmpty(struct7_0.string_0) && string.IsNullOrEmpty(struct7_0.string_1) && string.IsNullOrEmpty(struct7_0.string_2))
		{
			struct7_0.string_0 = Assembly.GetExecutingAssembly().GetName().Name;
			struct7_0.string_2 = Assembly.GetExecutingAssembly().Location;
			struct7_0.string_1 = FileVersionInfo.GetVersionInfo(struct7_0.string_2).FileVersion;
			FileInfo fileInfo = new FileInfo(struct7_0.string_2);
			ref Struct7 reference = ref struct7_0;
			reference.string_1 = reference.string_1 + "\r\n" + fileInfo.LastWriteTime;
		}
		if (string.IsNullOrEmpty(struct7_0.string_3) && string.IsNullOrEmpty(struct7_0.string_4))
		{
			((Control)this).set_Cursor(Cursors.get_Default());
		}
		else
		{
			((Control)this).set_Cursor(Cursors.get_Hand());
		}
		method_14();
		method_13(GEnum0.const_0);
	}

	[SpecialName]
	public void method_7(Point point_0)
	{
		struct6_0.point_0 = point_0;
	}

	[SpecialName]
	public void method_8(int int_2)
	{
		struct6_0.int_0 = int_2;
	}

	public void method_9()
	{
		struct6_0.point_1 = method_12(struct6_0.int_0, struct6_0.point_0);
		timer_1.set_Enabled(true);
	}

	private void method_10()
	{
		struct6_0.int_0 = 0;
		struct6_0.point_0 = new Point(0, 0);
		struct6_0.point_1 = new Point(0, 0);
		struct6_0.int_1 = 0;
		struct6_0.genum1_0 = GEnum1.const_0;
		struct6_0.genum1_1 = GEnum1.const_0;
		struct6_0.genum0_0 = GEnum0.const_0;
	}

	private void method_11()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		struct8_0.int_0 = method_1(Toast.Default.Width);
		struct8_0.int_1 = method_2(Toast.Default.Height);
		struct8_0.int_2 = method_1(Toast.Default.Margin);
		struct8_0.string_0 = Toast.Default.TitleFontName;
		struct8_0.fontStyle_0 = Toast.Default.TitleFontStyle;
		struct8_0.int_3 = method_2(Toast.Default.TitleFontSize);
		struct8_0.rectangle_0 = method_3(Toast.Default.TitleRect);
		struct8_0.color_0 = Toast.Default.TitleColor;
		struct8_0.string_1 = Toast.Default.TextFontName;
		struct8_0.fontStyle_1 = Toast.Default.TextFontStyle;
		struct8_0.int_4 = method_2(Toast.Default.TextFontSize);
		struct8_0.rectangle_1 = method_3(Toast.Default.TextRect);
		struct8_0.color_1 = Toast.Default.TextColor;
		struct8_0.point_0 = method_4(Toast.Default.IconLocation);
		struct8_0.point_1 = method_4(Toast.Default.CloseButtonLocation);
		struct8_0.int_5 = Toast.Default.OpacityFadeSpeed;
		struct8_0.int_6 = Toast.Default.OpacityStepPercent;
		struct8_0.int_7 = Toast.Default.OpacityNormalPercent;
		struct8_0.int_8 = Toast.Default.OpacityHoverPercent;
		struct8_0.int_9 = Toast.Default.MoveDivisor;
		struct8_0.int_10 = Toast.Default.MoveDuration;
		struct8_0.int_11 = (int)Class1.class0_0.method_22();
		struct8_0.bool_0 = Toast.Default.EnablePopUpEffect;
		struct8_0.bitmap_0 = null;
		struct8_0.bitmap_1 = null;
		struct8_0.icon_0 = null;
		struct8_0.icon_1 = null;
		struct8_0.icon_2 = null;
		if (struct8_0.int_9 < 2)
		{
			struct8_0.int_9 = 2;
		}
		if (struct8_0.int_10 < 1)
		{
			struct8_0.int_10 = 1;
		}
		if (struct8_0.int_11 < 1)
		{
			struct8_0.int_11 = 1;
		}
		((Form)this).set_Opacity((double)struct6_0.int_1 / 100.0);
		timer_1.set_Interval(struct8_0.int_10);
		((Form)this).set_ClientSize(new Size(struct8_0.int_0, struct8_0.int_1));
		struct8_0.bitmap_0 = new Bitmap(struct8_0.int_0, struct8_0.int_1);
		Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule!.FileName));
		if (!string.IsNullOrEmpty(Toast.Default.BackgroundImage) && File.Exists(Toast.Default.BackgroundImage))
		{
			Bitmap val = new Bitmap(Toast.Default.BackgroundImage);
			struct8_0.bitmap_1 = new Bitmap(struct8_0.int_0, struct8_0.int_1);
			Graphics val2 = Graphics.FromImage((Image)(object)struct8_0.bitmap_1);
			try
			{
				val2.DrawImage((Image)(object)val, new Rectangle(Point.Empty, ((Image)struct8_0.bitmap_1).get_Size()), new Rectangle(Point.Empty, ((Image)val).get_Size()), (GraphicsUnit)2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		struct8_0.icon_0 = Resources.Close;
		struct8_0.icon_1 = Resources.CloseHover;
		struct8_0.icon_2 = Resources.CloseClicked;
		if (!string.IsNullOrEmpty(Toast.Default.CloseIcon) && File.Exists(Toast.Default.CloseIcon))
		{
			struct8_0.icon_0 = new Icon(Toast.Default.CloseIcon);
		}
		if (!string.IsNullOrEmpty(Toast.Default.CloseHoverIcon) && File.Exists(Toast.Default.CloseHoverIcon))
		{
			struct8_0.icon_1 = new Icon(Toast.Default.CloseHoverIcon);
		}
		if (!string.IsNullOrEmpty(Toast.Default.CloseClickedIcon) && File.Exists(Toast.Default.CloseClickedIcon))
		{
			struct8_0.icon_2 = new Icon(Toast.Default.CloseClickedIcon);
		}
	}

	private Point method_12(int int_2, Point point_0)
	{
		Point result = new Point(0, 0);
		Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
		int num = point_0.Y / (struct8_0.int_2 + ((Control)this).get_Height());
		int num2 = workingArea.Height / (struct8_0.int_2 + ((Control)this).get_Height());
		if (int_2 < num)
		{
			result.X = point_0.X - (struct8_0.int_2 + ((Control)this).get_Width());
			result.Y = point_0.Y - (struct8_0.int_2 + ((Control)this).get_Height()) * (int_2 + 1);
		}
		else
		{
			int num3 = (int_2 - num) / num2;
			int num4 = (int_2 - num) % num2;
			result.X = point_0.X - (struct8_0.int_2 + ((Control)this).get_Width()) * (num3 + 2);
			result.Y = workingArea.Bottom - (struct8_0.int_2 + ((Control)this).get_Height()) * (num4 + 1);
		}
		return result;
	}

	private void method_13(GEnum0 genum0_0)
	{
		struct6_0.genum0_0 = genum0_0;
		int interval = 0;
		switch (genum0_0)
		{
		case GEnum0.const_2:
			interval = struct8_0.int_11;
			break;
		case GEnum0.const_0:
		case GEnum0.const_1:
		case GEnum0.const_3:
			interval = struct8_0.int_5 * struct8_0.int_6 / struct8_0.int_7;
			break;
		}
		timer_0.set_Interval(interval);
		timer_0.set_Enabled(true);
	}

	private void method_14()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		if (struct8_0.bitmap_0 == null)
		{
			return;
		}
		Graphics val = Graphics.FromImage((Image)(object)struct8_0.bitmap_0);
		try
		{
			Brush val2 = null;
			Font val3 = null;
			if (struct8_0.bitmap_1 != null)
			{
				val.DrawImage((Image)(object)struct8_0.bitmap_1, 0, 0);
			}
			else
			{
				method_0(val, struct6_0.genum1_0);
			}
			val3 = new Font(struct8_0.string_0, (float)struct8_0.int_3, struct8_0.fontStyle_0, (GraphicsUnit)2);
			val2 = (Brush)new SolidBrush(Color.Black);
			Rectangle rectangle_ = struct8_0.rectangle_0;
			rectangle_.X--;
			rectangle_.Y--;
			val.DrawString(struct7_0.string_0, val3, val2, (RectangleF)rectangle_);
			val2.Dispose();
			val2 = (Brush)new SolidBrush(struct8_0.color_0);
			val.DrawString(struct7_0.string_0, val3, val2, (RectangleF)struct8_0.rectangle_0);
			val2.Dispose();
			val3.Dispose();
			val3 = new Font(struct8_0.string_1, (float)struct8_0.int_4, struct8_0.fontStyle_1, (GraphicsUnit)2);
			val2 = (Brush)new SolidBrush(Color.Black);
			rectangle_ = struct8_0.rectangle_1;
			rectangle_.X--;
			rectangle_.Y--;
			val.DrawString(struct7_0.string_1, val3, val2, (RectangleF)rectangle_);
			val2.Dispose();
			val2 = (Brush)new SolidBrush(struct8_0.color_1);
			val.DrawString(struct7_0.string_1, val3, val2, (RectangleF)struct8_0.rectangle_1);
			val2.Dispose();
			val3.Dispose();
			if (File.Exists(struct7_0.string_2))
			{
				Icon val4 = Icon.ExtractAssociatedIcon(struct7_0.string_2);
				val.DrawIcon(val4, struct8_0.point_0.X, struct8_0.point_0.Y);
				val4.Dispose();
			}
			Icon val5 = null;
			switch (struct6_0.genum1_1)
			{
			case GEnum1.const_0:
				val5 = struct8_0.icon_0;
				break;
			case GEnum1.const_1:
				val5 = struct8_0.icon_1;
				break;
			case GEnum1.const_2:
				val5 = struct8_0.icon_2;
				break;
			}
			val.DrawIcon(val5, new Rectangle(struct8_0.point_1.X, struct8_0.point_1.Y, method_1(val5.get_Width()), method_2(val5.get_Height())));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		((Control)this).Invalidate();
	}

	private void Toast_1_Load(object sender, EventArgs e)
	{
		Point location = method_12(struct6_0.int_0, struct6_0.point_0);
		if (struct8_0.bool_0)
		{
			location = method_12(0, new Point(Screen.get_PrimaryScreen().get_WorkingArea().Right, Screen.get_PrimaryScreen().get_WorkingArea().Bottom));
		}
		((Form)this).set_Location(location);
		method_9();
		try
		{
			Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MinWorkingSet;
		}
		catch
		{
		}
	}

	private void Toast_1_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (gdelegate2_0 != null)
		{
			gdelegate2_0(this);
		}
	}

	private void Toast_1_MouseEnter(object sender, EventArgs e)
	{
		struct6_0.genum1_0 = GEnum1.const_1;
		method_14();
		method_13(GEnum0.const_1);
	}

	private void Toast_1_MouseLeave(object sender, EventArgs e)
	{
		if (struct6_0.genum1_1 != 0)
		{
			struct6_0.genum1_1 = GEnum1.const_0;
		}
		struct6_0.genum1_0 = GEnum1.const_0;
		method_14();
		method_13(GEnum0.const_0);
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		Point point = new Point(0, 0);
		if (((Form)this).get_Location().X == struct6_0.point_1.X && ((Form)this).get_Location().Y == struct6_0.point_1.Y)
		{
			timer_1.set_Enabled(false);
			return;
		}
		if (((Form)this).get_Location().X != struct6_0.point_1.X)
		{
			point.X = (struct6_0.point_1.X - ((Form)this).get_Location().X) / struct8_0.int_9;
			if (point.X == 0)
			{
				point.X = ((struct6_0.point_1.X > ((Form)this).get_Location().X) ? 1 : (-1));
			}
		}
		if (((Form)this).get_Location().Y != struct6_0.point_1.Y)
		{
			point.Y = (struct6_0.point_1.Y - ((Form)this).get_Location().Y) / struct8_0.int_9;
			if (point.Y == 0)
			{
				point.Y = ((struct6_0.point_1.Y > ((Form)this).get_Location().Y) ? 1 : (-1));
			}
		}
		((Form)this).set_Location(new Point(((Form)this).get_Location().X + point.X, ((Form)this).get_Location().Y + point.Y));
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		switch (struct6_0.genum0_0)
		{
		case GEnum0.const_0:
			if (struct6_0.int_1 == struct8_0.int_7)
			{
				method_13(GEnum0.const_2);
			}
			else if (struct6_0.int_1 > struct8_0.int_7)
			{
				struct6_0.int_1 -= struct8_0.int_6;
				if (struct6_0.int_1 < struct8_0.int_7)
				{
					struct6_0.int_1 = struct8_0.int_7;
				}
				((Form)this).set_Opacity((double)struct6_0.int_1 / 100.0);
			}
			else
			{
				struct6_0.int_1 += struct8_0.int_6;
				if (struct6_0.int_1 > struct8_0.int_7)
				{
					struct6_0.int_1 = struct8_0.int_7;
				}
				((Form)this).set_Opacity((double)struct6_0.int_1 / 100.0);
			}
			break;
		case GEnum0.const_1:
			if (struct6_0.int_1 == struct8_0.int_8)
			{
				timer_0.set_Enabled(false);
			}
			else if (struct6_0.int_1 > struct8_0.int_8)
			{
				struct6_0.int_1 -= struct8_0.int_6;
				if (struct6_0.int_1 < struct8_0.int_8)
				{
					struct6_0.int_1 = struct8_0.int_8;
				}
				((Form)this).set_Opacity((double)struct6_0.int_1 / 100.0);
			}
			else
			{
				struct6_0.int_1 += struct8_0.int_6;
				if (struct6_0.int_1 > struct8_0.int_8)
				{
					struct6_0.int_1 = struct8_0.int_8;
				}
				((Form)this).set_Opacity((double)struct6_0.int_1 / 100.0);
			}
			break;
		case GEnum0.const_2:
			method_13(GEnum0.const_3);
			break;
		case GEnum0.const_3:
			if (struct6_0.int_1 <= 0)
			{
				timer_0.set_Enabled(false);
				((Form)this).Close();
				break;
			}
			struct6_0.int_1 -= struct8_0.int_6;
			if (struct6_0.int_1 < 0)
			{
				struct6_0.int_1 = 0;
			}
			((Form)this).set_Opacity((double)struct6_0.int_1 / 100.0);
			break;
		}
	}

	private void Toast_1_Paint(object sender, PaintEventArgs e)
	{
		if (struct8_0.bitmap_0 != null)
		{
			e.get_Graphics().DrawImage((Image)(object)struct8_0.bitmap_0, 0, 0);
		}
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	private void Toast_1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		bool flag = false;
		if (struct8_0.icon_0 != null)
		{
			bool flag2 = new Rectangle(struct8_0.point_1.X, struct8_0.point_1.Y, method_1(struct8_0.icon_0.get_Width()), method_2(struct8_0.icon_0.get_Height())).Contains(e.get_Location());
			GEnum1 gEnum = GEnum1.const_0;
			if (flag2)
			{
				gEnum = (((int)e.get_Button() != 1048576) ? GEnum1.const_1 : GEnum1.const_2);
			}
			if (gEnum != struct6_0.genum1_1)
			{
				struct6_0.genum1_1 = gEnum;
				flag = true;
			}
		}
		GEnum1 gEnum2 = GEnum1.const_0;
		gEnum2 = (((int)e.get_Button() != 1048576) ? GEnum1.const_1 : ((struct6_0.genum1_1 == GEnum1.const_2) ? GEnum1.const_1 : GEnum1.const_2));
		if (gEnum2 != struct6_0.genum1_0)
		{
			struct6_0.genum1_0 = gEnum2;
			flag = true;
		}
		if (flag)
		{
			method_14();
		}
	}

	private void Toast_1_MouseUp(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() != 1048576)
		{
			return;
		}
		if (struct8_0.icon_0 != null)
		{
			if (new Rectangle(struct8_0.point_1.X, struct8_0.point_1.Y, method_1(struct8_0.icon_0.get_Width()), method_2(struct8_0.icon_0.get_Height())).Contains(e.get_Location()))
			{
				((Form)this).Close();
				return;
			}
			Rectangle rectangle = new Rectangle(((Form)this).get_Location(), ((Form)this).get_Size());
			if (((Control)this).RectangleToClient(rectangle).Contains(e.get_Location()))
			{
				method_15();
			}
		}
		else
		{
			Rectangle rectangle2 = new Rectangle(((Form)this).get_Location(), ((Form)this).get_Size());
			if (((Control)this).RectangleToClient(rectangle2).Contains(e.get_Location()))
			{
				method_15();
			}
		}
	}

	private void Toast_1_MouseDown(object sender, MouseEventArgs e)
	{
		Toast_1_MouseMove(sender, e);
	}

	private void method_15()
	{
		if (!string.IsNullOrEmpty(struct7_0.string_3) && File.Exists(struct7_0.string_3))
		{
			Process process = new Process();
			process.StartInfo.FileName = struct7_0.string_3;
			process.StartInfo.Arguments = struct7_0.string_4;
			process.Start();
		}
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
		((Form)this).set_ClientSize(new Size(284, 71));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Toast");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Toast");
		((Form)this).add_Load((EventHandler)Toast_1_Load);
		((Control)this).add_MouseUp(new MouseEventHandler(Toast_1_MouseUp));
		((Control)this).add_Paint(new PaintEventHandler(Toast_1_Paint));
		((Control)this).add_MouseEnter((EventHandler)Toast_1_MouseEnter);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Toast_1_FormClosed));
		((Control)this).add_MouseDown(new MouseEventHandler(Toast_1_MouseDown));
		((Control)this).add_MouseLeave((EventHandler)Toast_1_MouseLeave);
		((Control)this).add_MouseMove(new MouseEventHandler(Toast_1_MouseMove));
		((Control)this).ResumeLayout(false);
	}
}
