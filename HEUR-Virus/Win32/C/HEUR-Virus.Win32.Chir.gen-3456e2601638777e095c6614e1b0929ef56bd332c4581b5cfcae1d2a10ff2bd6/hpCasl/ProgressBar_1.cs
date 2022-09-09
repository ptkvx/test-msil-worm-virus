using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using hpCasl.Properties;

namespace hpCasl;

public class ProgressBar_1 : GForm0
{
	public delegate void GDelegate1();

	private struct Struct3
	{
		public Point point_0;

		public int int_0;

		public GEnum0 genum0_0;

		public GEnum1 genum1_0;
	}

	private struct Struct4
	{
		public int int_0;

		public string string_0;

		public string string_1;
	}

	private struct Struct5
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public Point point_0;

		public Point point_1;

		public Rectangle rectangle_0;

		public int int_3;

		public uint uint_0;

		public Color color_0;

		public Color color_1;

		public Color color_2;

		public Color color_3;

		public Color color_4;

		public Color color_5;

		public Color color_6;

		public Color color_7;

		public Color color_8;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public int int_9;

		public bool bool_0;

		public bool bool_1;

		public int int_10;

		public Bitmap bitmap_0;

		public Bitmap bitmap_1;
	}

	private GDelegate1 gdelegate1_0;

	private Struct3 struct3_0;

	private Struct4 struct4_0;

	private Struct5 struct5_0;

	private IContainer icontainer_0;

	private Timer timer_0;

	private Timer timer_1;

	protected override bool ShowWithoutActivation => true;

	public ProgressBar_1(GDelegate1 gdelegate1_1, string string_0)
	{
		gdelegate1_0 = gdelegate1_1;
		InitializeComponent();
		method_7();
		method_8();
		method_5(string_0);
	}

	public void method_5(string string_0)
	{
		struct4_0.int_0 = 0;
		struct4_0.string_0 = null;
		struct4_0.string_1 = null;
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
					struct4_0.string_1 = xmlTextReader.Value;
					break;
				case "LeftIconPath":
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					struct4_0.string_0 = xmlTextReader.Value;
					break;
				case "Percentage":
				{
					xmlTextReader.MoveToContent();
					xmlTextReader.Read();
					if (int.TryParse(xmlTextReader.Value, out var result))
					{
						struct4_0.int_0 = result;
					}
					if (struct4_0.int_0 < 0)
					{
						struct4_0.int_0 = 0;
					}
					if (struct4_0.int_0 > 100)
					{
						struct4_0.int_0 = 100;
					}
					break;
				}
				}
			}
		}
		catch
		{
		}
		method_11();
		method_6(1);
		method_10(GEnum0.const_0);
	}

	public void method_6(int int_2)
	{
		Point point_ = method_9(int_2);
		struct3_0.point_0 = point_;
		timer_0.set_Enabled(true);
	}

	private void method_7()
	{
		struct3_0.point_0 = new Point(0, 0);
		struct3_0.int_0 = 0;
		struct3_0.genum0_0 = GEnum0.const_0;
	}

	private void method_8()
	{
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		struct5_0.int_0 = method_1(ProgressBar.Default.Width);
		struct5_0.int_1 = method_2(ProgressBar.Default.Height);
		struct5_0.int_2 = method_1(ProgressBar.Default.BottomMargin);
		struct5_0.color_8 = Global.Default.HighlightColor;
		struct5_0.color_0 = ProgressBar.Default.BarBackgroundColor;
		struct5_0.color_1 = ProgressBar.Default.BarColor;
		struct5_0.color_2 = ProgressBar.Default.BarCapStartColor;
		struct5_0.color_3 = ProgressBar.Default.BarCapEndColor;
		struct5_0.color_5 = ProgressBar.Default.BarGlowColor;
		struct5_0.color_6 = ProgressBar.Default.BarGlowAccentColor;
		struct5_0.color_4 = ProgressBar.Default.BarCapEndGlowColor;
		struct5_0.color_7 = ProgressBar.Default.BarBorderColor;
		struct5_0.point_0 = method_4(ProgressBar.Default.LeftIconLocation);
		struct5_0.point_1 = method_4(ProgressBar.Default.RightIconLocation);
		struct5_0.rectangle_0 = method_3(ProgressBar.Default.BarRectangle);
		struct5_0.int_3 = method_1(ProgressBar.Default.BarMargin);
		struct5_0.uint_0 = ProgressBar.Default.BarSegments;
		struct5_0.int_8 = ProgressBar.Default.MoveDivisor;
		struct5_0.int_9 = ProgressBar.Default.MoveDuration;
		struct5_0.int_4 = ProgressBar.Default.OpacityFadeSpeed;
		struct5_0.int_5 = ProgressBar.Default.OpacityStepPercent;
		struct5_0.int_6 = ProgressBar.Default.OpacityNormalPercent;
		struct5_0.int_7 = ProgressBar.Default.OpacityHoverPercent;
		struct5_0.bool_0 = ProgressBar.Default.EnablePopUpEffect;
		struct5_0.bool_1 = ProgressBar.Default.EnablePopDownEffect;
		struct5_0.int_10 = (int)Class1.class0_0.method_22();
		struct5_0.bitmap_0 = null;
		struct5_0.bitmap_1 = null;
		if (struct5_0.int_8 < 2)
		{
			struct5_0.int_8 = 2;
		}
		if (struct5_0.int_9 < 1)
		{
			struct5_0.int_9 = 1;
		}
		if (struct5_0.int_10 < 1)
		{
			struct5_0.int_10 = 1;
		}
		((Form)this).set_Opacity((double)struct3_0.int_0 / 100.0);
		timer_0.set_Interval(struct5_0.int_9);
		((Form)this).set_ClientSize(new Size(struct5_0.int_0, struct5_0.int_1));
		struct5_0.bitmap_0 = new Bitmap(struct5_0.int_0, struct5_0.int_1);
		Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule!.FileName));
		if (!string.IsNullOrEmpty(ProgressBar.Default.BackgroundImage) && File.Exists(ProgressBar.Default.BackgroundImage))
		{
			Bitmap val = new Bitmap(ProgressBar.Default.BackgroundImage);
			struct5_0.bitmap_1 = new Bitmap(struct5_0.int_0, struct5_0.int_1);
			Graphics val2 = Graphics.FromImage((Image)(object)struct5_0.bitmap_1);
			try
			{
				val2.DrawImage((Image)(object)val, new Rectangle(Point.Empty, ((Image)struct5_0.bitmap_1).get_Size()), new Rectangle(Point.Empty, ((Image)val).get_Size()), (GraphicsUnit)2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
	}

	private Point method_9(int int_2)
	{
		Point result = new Point(0, 0);
		Rectangle workingArea = Screen.get_PrimaryScreen().get_WorkingArea();
		result.X = (workingArea.Right - ((Control)this).get_Width()) / 2;
		if (int_2 == 0)
		{
			result.Y = workingArea.Bottom;
		}
		else
		{
			result.Y = workingArea.Bottom - ((Control)this).get_Height() - struct5_0.int_2;
		}
		return result;
	}

	private void method_10(GEnum0 genum0_0)
	{
		struct3_0.genum0_0 = genum0_0;
		int num = 0;
		switch (genum0_0)
		{
		case GEnum0.const_2:
			num = struct5_0.int_10;
			break;
		case GEnum0.const_0:
		case GEnum0.const_1:
		case GEnum0.const_3:
			num = struct5_0.int_4 * struct5_0.int_5 / struct5_0.int_6;
			break;
		}
		if (num < 1)
		{
			num = 1;
		}
		timer_1.set_Interval(num);
		timer_1.set_Enabled(true);
	}

	private void method_11()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0199: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		if (struct5_0.bitmap_0 == null)
		{
			return;
		}
		Graphics val = Graphics.FromImage((Image)(object)struct5_0.bitmap_0);
		try
		{
			Pen val2 = null;
			Brush val3 = null;
			if (struct5_0.bitmap_1 != null)
			{
				val.DrawImage((Image)(object)struct5_0.bitmap_1, 0, 0);
			}
			else
			{
				method_0(val, struct3_0.genum1_0);
			}
			SolidBrush val4 = new SolidBrush(struct5_0.color_0);
			val3 = (Brush)val4;
			Brush val5 = (Brush)val4;
			try
			{
				val.FillRectangle(val3, struct5_0.rectangle_0);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
			Pen val6 = new Pen(struct5_0.color_7);
			val2 = val6;
			Pen val7 = val6;
			try
			{
				val.DrawRectangle(val2, struct5_0.rectangle_0);
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
			int int_ = struct5_0.int_3;
			Rectangle rectangle = default(Rectangle);
			rectangle.X = struct5_0.rectangle_0.Left + int_ + 1;
			rectangle.Y = struct5_0.rectangle_0.Top + int_ + 1;
			rectangle.Width = struct5_0.rectangle_0.Width - int_ * 2 - 1;
			rectangle.Height = struct5_0.rectangle_0.Height - int_ * 2 - 1;
			Rectangle rectangle2 = rectangle;
			rectangle2.Width = rectangle2.Width * struct4_0.int_0 / 100;
			if (rectangle2.Width > 0)
			{
				if (struct5_0.uint_0 == 0)
				{
					SolidBrush val8 = new SolidBrush(struct5_0.color_1);
					val3 = (Brush)val8;
					Brush val9 = (Brush)val8;
					try
					{
						val.FillRectangle(val3, rectangle2);
					}
					finally
					{
						((IDisposable)val9)?.Dispose();
					}
					int num = rectangle2.Width * 3 / 10;
					if (num > 0)
					{
						Rectangle rectangle3 = rectangle2;
						rectangle3.Width = num;
						rectangle3.X--;
						rectangle3.Width++;
						LinearGradientBrush val10 = new LinearGradientBrush(rectangle3, struct5_0.color_2, struct5_0.color_3, (LinearGradientMode)0);
						try
						{
							rectangle3.X++;
							rectangle3.Width--;
							if (rectangle3.Width > rectangle2.Width)
							{
								rectangle3.Width = rectangle2.Width;
							}
							val.FillRectangle((Brush)(object)val10, rectangle3);
						}
						finally
						{
							((IDisposable)val10)?.Dispose();
						}
						Rectangle rectangle4 = rectangle2;
						rectangle4.X = rectangle4.X + rectangle4.Width - num;
						rectangle4.Width = num;
						rectangle4.X--;
						rectangle4.Width++;
						LinearGradientBrush val11 = new LinearGradientBrush(rectangle4, struct5_0.color_3, struct5_0.color_2, (LinearGradientMode)0);
						try
						{
							rectangle4.X++;
							rectangle4.Width--;
							if (rectangle4.Width > rectangle2.Width)
							{
								rectangle4.X = rectangle2.X;
								rectangle4.Width = rectangle2.Width;
							}
							val.FillRectangle((Brush)(object)val11, rectangle4);
						}
						finally
						{
							((IDisposable)val11)?.Dispose();
						}
					}
					int num2 = rectangle2.Width * 6 / 10;
					int num3 = rectangle2.Height * 6 / 10;
					if (num2 > 0 && num3 > 0)
					{
						GraphicsPath val12 = new GraphicsPath();
						val12.AddEllipse(rectangle2.X + rectangle2.Width * 2 / 10, rectangle2.Y + rectangle2.Height * 705 / 1000, num2, num3);
						PathGradientBrush val13 = new PathGradientBrush(val12);
						val13.SetBlendTriangularShape(1f, 0.8f);
						val13.set_CenterColor(struct5_0.color_5);
						ColorBlend val14 = new ColorBlend(4);
						val14.set_Positions(new float[4] { 0f, 0.45f, 0.55f, 1f });
						val14.set_Colors(new Color[4]
						{
							Color.FromArgb(0, struct5_0.color_5),
							Color.FromArgb(85, struct5_0.color_5),
							Color.FromArgb(187, struct5_0.color_6),
							Color.FromArgb(255, struct5_0.color_5)
						});
						val13.set_InterpolationColors(val14);
						val.FillRectangle((Brush)(object)val13, rectangle2);
						((Brush)val13).Dispose();
						val12.Dispose();
					}
					Rectangle rectangle5 = rectangle2;
					rectangle5.X += rectangle5.Width;
					rectangle5.Width = rectangle.Width / 10;
					rectangle5.X--;
					rectangle5.Width++;
					LinearGradientBrush val15 = new LinearGradientBrush(rectangle5, Color.FromArgb(84, struct5_0.color_4), Color.FromArgb(0, struct5_0.color_4), (LinearGradientMode)0);
					try
					{
						rectangle5.X++;
						rectangle5.Width--;
						if (rectangle2.Width + rectangle5.Width > rectangle.Width)
						{
							rectangle5.Width = rectangle.Width - rectangle2.Width;
						}
						if (rectangle5.Width > 0)
						{
							val.FillRectangle((Brush)(object)val15, rectangle5);
						}
					}
					finally
					{
						((IDisposable)val15)?.Dispose();
					}
				}
				else
				{
					Rectangle rectangle6 = new Rectangle(rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height);
					SolidBrush val16 = new SolidBrush(struct5_0.color_1);
					try
					{
						if (struct5_0.uint_0 == 0)
						{
							rectangle6.Width = rectangle6.Width * struct4_0.int_0 / 100;
							val.FillRectangle((Brush)(object)val16, rectangle6);
						}
						else
						{
							uint num4 = (uint)((double)(float)struct4_0.int_0 / 100.0 * (double)struct5_0.uint_0 + 0.5);
							Rectangle rectangle7 = rectangle6;
							for (int i = 0; i < num4; i++)
							{
								rectangle7.Width = (int)((long)((rectangle6.Width - 2 + int_) * (i + 1)) / (long)struct5_0.uint_0 + rectangle6.X - rectangle7.X);
								val.FillRectangle((Brush)(object)val16, rectangle7);
								rectangle7.X = rectangle7.Right + int_;
							}
						}
					}
					finally
					{
						((IDisposable)val16)?.Dispose();
					}
					rectangle6 = new Rectangle(rectangle.Left, rectangle.Top + rectangle.Height / 2, rectangle.Width, rectangle.Height / 2);
					LinearGradientBrush val17 = new LinearGradientBrush(rectangle6, Color.FromArgb(0, struct5_0.color_5), struct5_0.color_5, (LinearGradientMode)1);
					try
					{
						if (struct5_0.uint_0 == 0)
						{
							rectangle6.Width = rectangle6.Width * struct4_0.int_0 / 100;
							val.FillRectangle((Brush)(object)val17, rectangle6);
						}
						else
						{
							uint num5 = (uint)((double)(float)struct4_0.int_0 / 100.0 * (double)struct5_0.uint_0 + 0.5);
							Rectangle rectangle8 = rectangle6;
							for (int j = 0; j < num5; j++)
							{
								rectangle8.Width = (int)((long)((rectangle6.Width - 2 + int_) * (j + 1)) / (long)struct5_0.uint_0 + rectangle6.X - rectangle8.X);
								val.FillRectangle((Brush)(object)val17, rectangle8);
								rectangle8.X = rectangle8.Right + int_;
							}
						}
					}
					finally
					{
						((IDisposable)val17)?.Dispose();
					}
				}
			}
			Rectangle rectangle9 = rectangle;
			rectangle9.Height /= 2;
			LinearGradientBrush val18 = new LinearGradientBrush(rectangle9, Color.FromArgb(85, struct5_0.color_8), Color.FromArgb(22, struct5_0.color_8), (LinearGradientMode)1);
			try
			{
				val.FillRectangle((Brush)(object)val18, rectangle9);
			}
			finally
			{
				((IDisposable)val18)?.Dispose();
			}
			if (File.Exists(struct4_0.string_0))
			{
				Icon val19 = Icon.ExtractAssociatedIcon(struct4_0.string_0);
				val.DrawIcon(val19, struct5_0.point_0.X, struct5_0.point_0.Y);
				val19.Dispose();
			}
			if (File.Exists(struct4_0.string_1))
			{
				Icon val20 = Icon.ExtractAssociatedIcon(struct4_0.string_1);
				val.DrawIcon(val20, struct5_0.point_1.X, struct5_0.point_1.Y);
				val20.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		((Control)this).Invalidate();
	}

	private void ProgressBar_1_Load(object sender, EventArgs e)
	{
		Point location = method_9(1);
		if (struct5_0.bool_0)
		{
			location = method_9(0);
		}
		((Form)this).set_Location(location);
		method_6(1);
		try
		{
			Process.GetCurrentProcess().MaxWorkingSet = Process.GetCurrentProcess().MinWorkingSet;
		}
		catch
		{
		}
	}

	private void ProgressBar_1_FormClosed(object sender, FormClosedEventArgs e)
	{
		if (gdelegate1_0 != null)
		{
			gdelegate1_0();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		Point point = new Point(0, 0);
		if (((Form)this).get_Location().X == struct3_0.point_0.X && ((Form)this).get_Location().Y == struct3_0.point_0.Y)
		{
			timer_0.set_Enabled(false);
			return;
		}
		if (((Form)this).get_Location().X != struct3_0.point_0.X)
		{
			point.X = (struct3_0.point_0.X - ((Form)this).get_Location().X) / struct5_0.int_8;
			if (point.X == 0)
			{
				point.X = ((struct3_0.point_0.X > ((Form)this).get_Location().X) ? 1 : (-1));
			}
		}
		if (((Form)this).get_Location().Y != struct3_0.point_0.Y)
		{
			point.Y = (struct3_0.point_0.Y - ((Form)this).get_Location().Y) / struct5_0.int_8;
			if (point.Y == 0)
			{
				point.Y = ((struct3_0.point_0.Y > ((Form)this).get_Location().Y) ? 1 : (-1));
			}
		}
		((Form)this).set_Location(new Point(((Form)this).get_Location().X + point.X, ((Form)this).get_Location().Y + point.Y));
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		switch (struct3_0.genum0_0)
		{
		case GEnum0.const_0:
			if (struct3_0.int_0 == struct5_0.int_6)
			{
				method_10(GEnum0.const_2);
			}
			else if (struct3_0.int_0 > struct5_0.int_6)
			{
				struct3_0.int_0 -= struct5_0.int_5;
				if (struct3_0.int_0 < struct5_0.int_6)
				{
					struct3_0.int_0 = struct5_0.int_6;
				}
				((Form)this).set_Opacity((double)struct3_0.int_0 / 100.0);
			}
			else
			{
				struct3_0.int_0 += struct5_0.int_5;
				if (struct3_0.int_0 > struct5_0.int_6)
				{
					struct3_0.int_0 = struct5_0.int_6;
				}
				((Form)this).set_Opacity((double)struct3_0.int_0 / 100.0);
			}
			break;
		case GEnum0.const_1:
			if (struct3_0.int_0 == struct5_0.int_7)
			{
				timer_1.set_Enabled(false);
			}
			else if (struct3_0.int_0 > struct5_0.int_7)
			{
				struct3_0.int_0 -= struct5_0.int_5;
				if (struct3_0.int_0 < struct5_0.int_7)
				{
					struct3_0.int_0 = struct5_0.int_7;
				}
				((Form)this).set_Opacity((double)struct3_0.int_0 / 100.0);
			}
			else
			{
				struct3_0.int_0 += struct5_0.int_5;
				if (struct3_0.int_0 > struct5_0.int_7)
				{
					struct3_0.int_0 = struct5_0.int_7;
				}
				((Form)this).set_Opacity((double)struct3_0.int_0 / 100.0);
			}
			break;
		case GEnum0.const_2:
			if (struct5_0.bool_1)
			{
				method_6(0);
			}
			method_10(GEnum0.const_3);
			break;
		case GEnum0.const_3:
			if (struct3_0.int_0 <= 0)
			{
				timer_1.set_Enabled(false);
				((Form)this).Close();
				break;
			}
			struct3_0.int_0 -= struct5_0.int_5;
			if (struct3_0.int_0 < 0)
			{
				struct3_0.int_0 = 0;
			}
			((Form)this).set_Opacity((double)struct3_0.int_0 / 100.0);
			break;
		}
	}

	private void ProgressBar_1_MouseEnter(object sender, EventArgs e)
	{
		struct3_0.genum1_0 = GEnum1.const_1;
		method_11();
	}

	private void ProgressBar_1_MouseLeave(object sender, EventArgs e)
	{
		struct3_0.genum1_0 = GEnum1.const_0;
		method_11();
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	private void ProgressBar_1_Paint(object sender, PaintEventArgs e)
	{
		if (struct5_0.bitmap_0 != null)
		{
			e.get_Graphics().DrawImage((Image)(object)struct5_0.bitmap_0, 0, 0);
		}
	}

	private void ProgressBar_1_MouseDown(object sender, MouseEventArgs e)
	{
		struct3_0.genum1_0 = GEnum1.const_2;
		method_11();
	}

	private void ProgressBar_1_MouseMove(object sender, MouseEventArgs e)
	{
	}

	private void ProgressBar_1_MouseUp(object sender, MouseEventArgs e)
	{
		struct3_0.genum1_0 = GEnum1.const_1;
		method_11();
		Rectangle rectangle = new Rectangle(((Form)this).get_Location(), ((Form)this).get_Size());
		if (((Control)this).RectangleToClient(rectangle).Contains(e.get_Location()))
		{
			((Form)this).Close();
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
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		timer_1 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_ClientSize(new Size(284, 66));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("ProgressBar");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("ProgressBar");
		((Form)this).add_Load((EventHandler)ProgressBar_1_Load);
		((Control)this).add_MouseUp(new MouseEventHandler(ProgressBar_1_MouseUp));
		((Control)this).add_Paint(new PaintEventHandler(ProgressBar_1_Paint));
		((Control)this).add_MouseEnter((EventHandler)ProgressBar_1_MouseEnter);
		((Form)this).add_FormClosed(new FormClosedEventHandler(ProgressBar_1_FormClosed));
		((Control)this).add_MouseDown(new MouseEventHandler(ProgressBar_1_MouseDown));
		((Control)this).add_MouseLeave((EventHandler)ProgressBar_1_MouseLeave);
		((Control)this).add_MouseMove(new MouseEventHandler(ProgressBar_1_MouseMove));
		((Control)this).ResumeLayout(false);
	}
}
