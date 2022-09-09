using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

internal abstract class Control0 : ContainerControl
{
	private Graphics graphics_0;

	private Bitmap bitmap_0;

	private bool bool_0;

	private Rectangle rectangle_0;

	private LinearGradientBrush linearGradientBrush_0;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Control0()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)139270, true);
		bitmap_0 = new Bitmap(1, 1);
		graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
	}

	public void method_0()
	{
		((Control)this).SetStyle((ControlStyles)4, false);
		((Control)this).SetStyle((ControlStyles)2048, true);
	}

	public abstract void vmethod_0();

	protected sealed override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			vmethod_0();
			paintEventArgs_0.get_Graphics().DrawImage((Image)(object)bitmap_0, 0, 0);
		}
	}

	protected override void OnSizeChanged(EventArgs eventArgs_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			bitmap_0 = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
			graphics_0 = Graphics.FromImage((Image)(object)bitmap_0);
			((Control)this).Invalidate();
		}
		((Control)this).OnSizeChanged(eventArgs_0);
	}

	protected void method_1(Color color_0, Rectangle rectangle_1)
	{
		checked
		{
			if (!bool_0)
			{
				bitmap_0.SetPixel(rectangle_1.X, rectangle_1.Y, color_0);
				bitmap_0.SetPixel(rectangle_1.X + (rectangle_1.Width - 1), rectangle_1.Y, color_0);
				bitmap_0.SetPixel(rectangle_1.X, rectangle_1.Y + (rectangle_1.Height - 1), color_0);
				bitmap_0.SetPixel(rectangle_1.X + (rectangle_1.Width - 1), rectangle_1.Y + (rectangle_1.Height - 1), color_0);
			}
		}
	}

	protected void method_2(Pen pen_0, Pen pen_1, Rectangle rectangle_1)
	{
		checked
		{
			graphics_0.DrawRectangle(pen_0, rectangle_1.X, rectangle_1.Y, rectangle_1.Width - 1, rectangle_1.Height - 1);
			graphics_0.DrawRectangle(pen_1, rectangle_1.X + 1, rectangle_1.Y + 1, rectangle_1.Width - 3, rectangle_1.Height - 3);
		}
	}

	protected void method_3(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3, float float_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_0, int_1, int_2, int_3);
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_0, color_0, color_1, float_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_0);
	}
}
