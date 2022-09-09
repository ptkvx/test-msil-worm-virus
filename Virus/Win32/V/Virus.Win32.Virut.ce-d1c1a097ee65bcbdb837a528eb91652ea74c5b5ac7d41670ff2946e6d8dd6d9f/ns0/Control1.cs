using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

internal abstract class Control1 : Control
{
	protected enum Enum0 : byte
	{
		const_0,
		const_1,
		const_2
	}

	private Graphics graphics_0;

	private Bitmap bitmap_0;

	private Enum0 enum0_0;

	private bool bool_0;

	private Image image_0;

	private Size size_0;

	private Rectangle rectangle_0;

	private LinearGradientBrush linearGradientBrush_0;

	private SolidBrush solidBrush_0;

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Invalidate();
		}
	}

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

	public Image Image_0
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			((Control)this).Invalidate();
		}
	}

	public int Int32_0
	{
		get
		{
			if (image_0 == null)
			{
				return 0;
			}
			return image_0.get_Width();
		}
	}

	public int Int32_1
	{
		get
		{
			if (image_0 == null)
			{
				return 0;
			}
			checked
			{
				return unchecked(((Control)this).get_Height() / 2) - unchecked(image_0.get_Height() / 2);
			}
		}
	}

	public Control1()
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

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		method_1(Enum0.const_0);
		((Control)this).OnMouseLeave(eventArgs_0);
	}

	protected override void OnMouseEnter(EventArgs eventArgs_0)
	{
		method_1(Enum0.const_1);
		((Control)this).OnMouseEnter(eventArgs_0);
	}

	protected override void OnMouseUp(MouseEventArgs mouseEventArgs_0)
	{
		method_1(Enum0.const_1);
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)mouseEventArgs_0.get_Button() == 1048576)
		{
			method_1(Enum0.const_2);
		}
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	private void method_1(Enum0 enum0_1)
	{
		enum0_0 = enum0_1;
		((Control)this).Invalidate();
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

	protected void method_2(Color color_0, Rectangle rectangle_1)
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

	protected void method_3(Pen pen_0, Pen pen_1, Rectangle rectangle_1)
	{
		checked
		{
			graphics_0.DrawRectangle(pen_0, rectangle_1.X, rectangle_1.Y, rectangle_1.Width - 1, rectangle_1.Height - 1);
			graphics_0.DrawRectangle(pen_1, rectangle_1.X + 1, rectangle_1.Y + 1, rectangle_1.Width - 3, rectangle_1.Height - 3);
		}
	}

	protected void method_4(HorizontalAlignment horizontalAlignment_0, Color color_0, int int_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_5(horizontalAlignment_0, color_0, int_0, 0);
	}

	protected void method_5(HorizontalAlignment horizontalAlignment_0, Color color_0, int int_0, int int_1)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected I4, but got Unknown
		checked
		{
			if (!string.IsNullOrEmpty(Text))
			{
				size_0 = graphics_0.MeasureString(Text, ((Control)this).get_Font()).ToSize();
				solidBrush_0 = new SolidBrush(color_0);
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawString(Text, ((Control)this).get_Font(), (Brush)(object)solidBrush_0, (float)int_0, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(size_0.Height / 2) + int_1));
					break;
				case 1:
					graphics_0.DrawString(Text, ((Control)this).get_Font(), (Brush)(object)solidBrush_0, (float)(((Control)this).get_Width() - size_0.Width - int_0), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(size_0.Height / 2) + int_1));
					break;
				case 2:
					graphics_0.DrawString(Text, ((Control)this).get_Font(), (Brush)(object)solidBrush_0, (float)(unchecked(((Control)this).get_Width() / 2) - unchecked(size_0.Width / 2) + int_0), (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(size_0.Height / 2) + int_1));
					break;
				}
			}
		}
	}

	protected void method_6(HorizontalAlignment horizontalAlignment_0, int int_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_7(horizontalAlignment_0, int_0, 0);
	}

	protected void method_7(HorizontalAlignment horizontalAlignment_0, int int_0, int int_1)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		checked
		{
			if (image_0 != null)
			{
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawImage(image_0, int_0, unchecked(((Control)this).get_Height() / 2) - unchecked(image_0.get_Height() / 2) + int_1);
					break;
				case 1:
					graphics_0.DrawImage(image_0, ((Control)this).get_Width() - image_0.get_Width() - int_0, unchecked(((Control)this).get_Height() / 2) - unchecked(image_0.get_Height() / 2) + int_1);
					break;
				case 2:
					graphics_0.DrawImage(image_0, unchecked(((Control)this).get_Width() / 2) - unchecked(image_0.get_Width() / 2), unchecked(((Control)this).get_Height() / 2) - unchecked(image_0.get_Height() / 2));
					break;
				}
			}
		}
	}

	protected void method_8(Color color_0, Color color_1, int int_0, int int_1, int int_2, int int_3, float float_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ref Rectangle reference = ref rectangle_0;
		reference = new Rectangle(int_0, int_1, int_2, int_3);
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_0, color_0, color_1, float_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_0);
	}
}
