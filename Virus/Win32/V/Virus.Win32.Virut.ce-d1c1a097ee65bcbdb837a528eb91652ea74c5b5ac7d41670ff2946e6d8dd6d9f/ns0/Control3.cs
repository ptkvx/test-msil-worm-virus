using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

internal abstract class Control3 : ContainerControl
{
	private struct Struct0
	{
		private readonly Cursor cursor_0;

		private readonly byte byte_0;

		public Struct0(Cursor cursor_1, byte byte_1)
		{
			this = default(Struct0);
			cursor_0 = cursor_1;
			byte_0 = byte_1;
		}
	}

	private Graphics graphics_0;

	private bool bool_0;

	private bool bool_1;

	private int int_0;

	private IntPtr intptr_0;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private Point point_0;

	private Struct0 struct0_0;

	private Struct0 struct0_1;

	private Rectangle rectangle_0;

	private Color color_0;

	private Image image_0;

	private Size size_0;

	private Rectangle rectangle_1;

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
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			ref Rectangle reference = ref rectangle_0;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, int_0 - 7));
		}
	}

	public Color Color_0
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
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

	public int Int32_1
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

	public Control3()
	{
		bool_1 = true;
		int_0 = 24;
		((Control)this).SetStyle((ControlStyles)139270, true);
	}

	protected override void OnHandleCreated(EventArgs eventArgs_0)
	{
		((Control)this).set_Dock((DockStyle)5);
		bool_0 = ((Control)this).get_Parent() is Form;
		if (bool_0)
		{
			if (!(color_0 == Color.Empty))
			{
				((ContainerControl)this).get_ParentForm().set_TransparencyKey(color_0);
			}
			((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
		}
		((Control)this).OnHandleCreated(eventArgs_0);
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)mouseEventArgs_0.get_Button() != 1048576 || (bool_0 && (int)((ContainerControl)this).get_ParentForm().get_WindowState() == 2))
		{
			return;
		}
		if (rectangle_0.Contains(mouseEventArgs_0.get_Location()))
		{
			ref IntPtr reference = ref intptr_0;
			reference = new IntPtr(2);
		}
		else
		{
			if ((struct0_0.byte_0 == 0) | !bool_1)
			{
				return;
			}
			ref IntPtr reference2 = ref intptr_0;
			reference2 = new IntPtr(struct0_0.byte_0);
		}
		((Control)this).set_Capture(false);
		IntPtr intPtr = default(IntPtr);
		Message val = Message.Create(((Control)this).get_Parent().get_Handle(), 161, intptr_0, intPtr);
		((Control)this).DefWndProc(ref val);
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	private Struct0 method_0()
	{
		point_0 = ((Control)this).PointToClient(Control.get_MousePosition());
		bool_2 = point_0.X < 7;
		checked
		{
			bool_3 = point_0.X > ((Control)this).get_Width() - 7;
			bool_4 = point_0.Y < 7;
			bool_5 = point_0.Y > ((Control)this).get_Height() - 7;
			if (bool_2 & bool_4)
			{
				return new Struct0(Cursors.get_SizeNWSE(), 13);
			}
			if (bool_2 & bool_5)
			{
				return new Struct0(Cursors.get_SizeNESW(), 16);
			}
			if (bool_3 & bool_4)
			{
				return new Struct0(Cursors.get_SizeNESW(), 14);
			}
			if (bool_3 & bool_5)
			{
				return new Struct0(Cursors.get_SizeNWSE(), 17);
			}
			if (bool_2)
			{
				return new Struct0(Cursors.get_SizeWE(), 10);
			}
			if (bool_3)
			{
				return new Struct0(Cursors.get_SizeWE(), 11);
			}
			if (bool_4)
			{
				return new Struct0(Cursors.get_SizeNS(), 12);
			}
			if (bool_5)
			{
				return new Struct0(Cursors.get_SizeNS(), 15);
			}
			return new Struct0(Cursors.get_Default(), 0);
		}
	}

	private void method_1()
	{
		struct0_1 = method_0();
		if (struct0_0.byte_0 != struct0_1.byte_0)
		{
			struct0_0 = method_0();
			((Control)this).set_Cursor(struct0_0.cursor_0);
		}
	}

	protected override void OnMouseMove(MouseEventArgs mouseEventArgs_0)
	{
		if (bool_1)
		{
			method_1();
		}
		((Control)this).OnMouseMove(mouseEventArgs_0);
	}

	protected override void OnSizeChanged(EventArgs eventArgs_0)
	{
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			ref Rectangle reference = ref rectangle_0;
			reference = checked(new Rectangle(7, 7, ((Control)this).get_Width() - 14, int_0 - 7));
			((Control)this).Invalidate();
			((Control)this).OnSizeChanged(eventArgs_0);
		}
	}

	public abstract void vmethod_0();

	protected sealed override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		if (((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			graphics_0 = paintEventArgs_0.get_Graphics();
			vmethod_0();
		}
	}

	protected void method_2(Color color_1, Rectangle rectangle_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		solidBrush_0 = new SolidBrush(color_1);
		graphics_0.FillRectangle((Brush)(object)solidBrush_0, rectangle_2.X, rectangle_2.Y, 1, 1);
		checked
		{
			graphics_0.FillRectangle((Brush)(object)solidBrush_0, rectangle_2.X + (rectangle_2.Width - 1), rectangle_2.Y, 1, 1);
			graphics_0.FillRectangle((Brush)(object)solidBrush_0, rectangle_2.X, rectangle_2.Y + (rectangle_2.Height - 1), 1, 1);
			graphics_0.FillRectangle((Brush)(object)solidBrush_0, rectangle_2.X + (rectangle_2.Width - 1), rectangle_2.Y + (rectangle_2.Height - 1), 1, 1);
		}
	}

	protected void method_3(Pen pen_0, Pen pen_1, Rectangle rectangle_2)
	{
		checked
		{
			graphics_0.DrawRectangle(pen_0, rectangle_2.X, rectangle_2.Y, rectangle_2.Width - 1, rectangle_2.Height - 1);
			graphics_0.DrawRectangle(pen_1, rectangle_2.X + 1, rectangle_2.Y + 1, rectangle_2.Width - 3, rectangle_2.Height - 3);
		}
	}

	protected void method_4(HorizontalAlignment horizontalAlignment_0, Color color_1, int int_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_5(horizontalAlignment_0, color_1, int_1, 0);
	}

	protected void method_5(HorizontalAlignment horizontalAlignment_0, Color color_1, int int_1, int int_2)
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
				solidBrush_0 = new SolidBrush(color_1);
				switch (unchecked((int)horizontalAlignment_0))
				{
				case 0:
					graphics_0.DrawString(Text, ((Control)this).get_Font(), (Brush)(object)solidBrush_0, (float)int_1, (float)(unchecked(int_0 / 2) - unchecked(size_0.Height / 2) + int_2));
					break;
				case 1:
					graphics_0.DrawString(Text, ((Control)this).get_Font(), (Brush)(object)solidBrush_0, (float)(((Control)this).get_Width() - size_0.Width - int_1), (float)(unchecked(int_0 / 2) - unchecked(size_0.Height / 2) + int_2));
					break;
				case 2:
					graphics_0.DrawString(Text, ((Control)this).get_Font(), (Brush)(object)solidBrush_0, (float)(unchecked(((Control)this).get_Width() / 2) - unchecked(size_0.Width / 2) + int_1), (float)(unchecked(int_0 / 2) - unchecked(size_0.Height / 2) + int_2));
					break;
				}
			}
		}
	}

	protected void method_6(HorizontalAlignment horizontalAlignment_0, int int_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_7(horizontalAlignment_0, int_1, 0);
	}

	protected void method_7(HorizontalAlignment horizontalAlignment_0, int int_1, int int_2)
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
					graphics_0.DrawImage(image_0, int_1, unchecked(int_0 / 2) - unchecked(image_0.get_Height() / 2) + int_2);
					break;
				case 1:
					graphics_0.DrawImage(image_0, ((Control)this).get_Width() - image_0.get_Width() - int_1, unchecked(int_0 / 2) - unchecked(image_0.get_Height() / 2) + int_2);
					break;
				case 2:
					graphics_0.DrawImage(image_0, unchecked(((Control)this).get_Width() / 2) - unchecked(image_0.get_Width() / 2), unchecked(int_0 / 2) - unchecked(image_0.get_Height() / 2));
					break;
				}
			}
		}
	}

	protected void method_8(Color color_1, Color color_2, int int_1, int int_2, int int_3, int int_4, float float_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		ref Rectangle reference = ref rectangle_1;
		reference = new Rectangle(int_1, int_2, int_3, int_4);
		linearGradientBrush_0 = new LinearGradientBrush(rectangle_1, color_1, color_2, float_0);
		graphics_0.FillRectangle((Brush)(object)linearGradientBrush_0, rectangle_1);
	}
}
