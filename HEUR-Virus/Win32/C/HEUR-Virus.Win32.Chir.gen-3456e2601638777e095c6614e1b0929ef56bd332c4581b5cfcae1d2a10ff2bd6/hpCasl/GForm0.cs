using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using hpCasl.Properties;

namespace hpCasl;

public class GForm0 : Form
{
	protected enum GEnum0
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	protected enum GEnum1
	{
		const_0,
		const_1,
		const_2
	}

	private static int int_0;

	private static int int_1;

	protected void method_0(Graphics graphics_0, GEnum1 genum1_0)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		Pen val = null;
		Color color = Global.Default.BackgroundTopColor;
		Color color2 = Global.Default.BackgroundBottomColor;
		if (genum1_0 == GEnum1.const_2)
		{
			color = Global.Default.BackgroundTopClickedColor;
			color2 = Global.Default.BackgroundBottomClickedColor;
		}
		LinearGradientBrush val2 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()), color, color2, (LinearGradientMode)1);
		try
		{
			graphics_0.FillRectangle((Brush)(object)val2, new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (genum1_0 == GEnum1.const_1 || genum1_0 == GEnum1.const_2)
		{
			GraphicsPath val3 = new GraphicsPath();
			val3.AddEllipse(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() * 2);
			PathGradientBrush val4 = new PathGradientBrush(val3);
			val4.set_CenterColor(Color.FromArgb(255, Global.Default.BackgroundHoverColor));
			val4.set_SurroundColors(new Color[1] { Color.FromArgb(0, Global.Default.BackgroundHoverColor) });
			graphics_0.FillEllipse((Brush)(object)val4, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() * 2);
			((Brush)val4).Dispose();
			val3.Dispose();
		}
		if (Global.Default.EnableHighlight)
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height() / 2);
			LinearGradientBrush val5 = new LinearGradientBrush(rectangle, Color.FromArgb(85, Global.Default.HighlightColor), Color.FromArgb(22, Global.Default.HighlightColor), (LinearGradientMode)1);
			graphics_0.FillRectangle((Brush)(object)val5, rectangle);
			((Brush)val5).Dispose();
		}
		val = new Pen(Global.Default.BackgroundBevelHighlightColor);
		graphics_0.DrawRectangle(val, new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
		val.Dispose();
		val = new Pen(Global.Default.BackgroundBevelShadowColor);
		graphics_0.DrawRectangle(val, new Rectangle(0, 0, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2));
		val.Dispose();
		val = new Pen(Global.Default.BackgroundBorderColor);
		graphics_0.DrawRectangle(val, new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
		val.Dispose();
	}

	static GForm0()
	{
		Graphics val = Graphics.FromHwnd(IntPtr.Zero);
		try
		{
			int_0 = (int)val.get_DpiX();
			int_1 = (int)val.get_DpiY();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected int method_1(int int_2)
	{
		return int_2 * int_0 / 96;
	}

	protected int method_2(int int_2)
	{
		return int_2 * int_1 / 96;
	}

	protected Rectangle method_3(Rectangle rectangle_0)
	{
		return new Rectangle(method_1(rectangle_0.X), method_2(rectangle_0.Y), method_1(rectangle_0.Width), method_2(rectangle_0.Height));
	}

	protected Point method_4(Point point_0)
	{
		return new Point(method_1(point_0.X), method_2(point_0.Y));
	}
}
