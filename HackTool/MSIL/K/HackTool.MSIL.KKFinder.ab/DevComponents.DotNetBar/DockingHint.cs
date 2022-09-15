using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class DockingHint : Form
{
	private Container container_0;

	private Enum7 enum7_0 = Enum7.flag_5;

	private Enum12 enum12_0;

	private bool bool_0;

	private GraphicsPath graphicsPath_0;

	private GraphicsPath graphicsPath_1;

	private GraphicsPath graphicsPath_2;

	private GraphicsPath graphicsPath_3;

	private GraphicsPath graphicsPath_4;

	private bool bool_1;

	private static Bitmap bitmap_0;

	private static Bitmap bitmap_1;

	private static Bitmap bitmap_2;

	private static Bitmap bitmap_3;

	private static Bitmap bitmap_4;

	private static Bitmap bitmap_5;

	public static Bitmap Bitmap_0
	{
		get
		{
			if (bitmap_0 == null)
			{
				bitmap_0 = Class109.smethod_67("SystemImages.DockHintTop.png");
			}
			return bitmap_0;
		}
	}

	public static Bitmap Bitmap_1
	{
		get
		{
			if (bitmap_1 == null)
			{
				bitmap_1 = Class109.smethod_67("SystemImages.DockHintBottom.png");
			}
			return bitmap_1;
		}
	}

	public static Bitmap Bitmap_2
	{
		get
		{
			if (bitmap_2 == null)
			{
				bitmap_2 = Class109.smethod_67("SystemImages.DockHintLeft.png");
			}
			return bitmap_2;
		}
	}

	public static Bitmap Bitmap_3
	{
		get
		{
			if (bitmap_3 == null)
			{
				bitmap_3 = Class109.smethod_67("SystemImages.DockHintRight.png");
			}
			return bitmap_3;
		}
	}

	public static Bitmap Bitmap_4
	{
		get
		{
			if (bitmap_4 == null)
			{
				bitmap_4 = Class109.smethod_67("SystemImages.DockHintTab.png");
			}
			return bitmap_4;
		}
	}

	public static Bitmap Bitmap_5
	{
		get
		{
			if (bitmap_5 == null)
			{
				bitmap_5 = Class109.smethod_67("SystemImages.DockHintAllSides.png");
			}
			return bitmap_5;
		}
	}

	private Enum12 Enum12_0
	{
		get
		{
			return enum12_0;
		}
		set
		{
			if (enum12_0 != value)
			{
				enum12_0 = value;
				bool_0 = true;
			}
		}
	}

	public Enum7 Enum7_0
	{
		get
		{
			return enum7_0;
		}
		set
		{
			if (enum7_0 != value)
			{
				enum7_0 = value;
				method_1();
				if (((Control)this).get_IsHandleCreated())
				{
					((Control)this).Refresh();
				}
			}
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

	public DockingHint(Enum7 hintSide)
		: this(hintSide, middleDockingHint: false)
	{
	}

	public DockingHint(Enum7 hintSide, bool middleDockingHint)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		bool_1 = middleDockingHint;
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		enum7_0 = hintSide;
		method_1();
	}

	public void method_0()
	{
		Size size = ((Form)this).get_Size();
		Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, size.Width, size.Height, 82);
		((Form)this).set_TopMost(true);
		if (!Class109.Boolean_0)
		{
			method_1();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_1()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		Region val = null;
		Size empty = Size.Empty;
		if (bool_1)
		{
			GraphicsPath val2 = new GraphicsPath();
			graphicsPath_4 = method_3(Enum7.flag_4);
			if ((enum7_0 & Enum7.flag_0) != 0)
			{
				graphicsPath_0 = method_3(Enum7.flag_0);
				val2.AddPath(graphicsPath_0, true);
			}
			else
			{
				val2.AddLine(23, 57, 23, 29);
			}
			if ((enum7_0 & Enum7.flag_2) != 0)
			{
				graphicsPath_3 = method_3(Enum7.flag_2);
				val2.AddPath(graphicsPath_3, true);
			}
			else
			{
				val2.AddLine(29, 23, 57, 23);
			}
			if ((enum7_0 & Enum7.flag_1) != 0)
			{
				graphicsPath_1 = method_3(Enum7.flag_1);
				val2.AddPath(graphicsPath_1, true);
			}
			else
			{
				val2.AddLine(64, 29, 64, 57);
			}
			if ((enum7_0 & Enum7.flag_3) != 0)
			{
				graphicsPath_2 = method_3(Enum7.flag_3);
				val2.AddPath(graphicsPath_2, true);
			}
			else
			{
				val2.AddLine(57, 64, 29, 64);
			}
			val2.CloseAllFigures();
			empty = new Size(88, 88);
			val = new Region(val2);
		}
		else
		{
			empty = (((enum7_0 & Enum7.flag_0) != 0 || (enum7_0 & Enum7.flag_1) != 0) ? new Size(31, 29) : new Size(29, 31));
			if ((enum7_0 & Enum7.flag_0) != 0)
			{
				graphicsPath_0 = new GraphicsPath();
				graphicsPath_0.AddRectangle(new Rectangle(Point.Empty, empty));
			}
			if ((enum7_0 & Enum7.flag_1) != 0)
			{
				graphicsPath_1 = new GraphicsPath();
				graphicsPath_1.AddRectangle(new Rectangle(Point.Empty, empty));
			}
			if ((enum7_0 & Enum7.flag_2) != 0)
			{
				graphicsPath_3 = new GraphicsPath();
				graphicsPath_3.AddRectangle(new Rectangle(Point.Empty, empty));
			}
			if ((enum7_0 & Enum7.flag_3) != 0)
			{
				graphicsPath_2 = new GraphicsPath();
				graphicsPath_2.AddRectangle(new Rectangle(Point.Empty, empty));
			}
			val = new Region(new Rectangle(Point.Empty, empty));
		}
		((Form)this).set_Size(empty);
		if (val != null)
		{
			((Control)this).set_Region(val);
		}
	}

	private Rectangle method_2()
	{
		Size size = Size.Empty;
		if ((enum7_0 & Enum7.flag_3) == Enum7.flag_3)
		{
			SizeF size2 = graphicsPath_2.GetBounds().Size;
			size = new Size((int)size2.Width, (int)size2.Height);
		}
		if ((enum7_0 & Enum7.flag_2) == Enum7.flag_2)
		{
			SizeF size3 = graphicsPath_3.GetBounds().Size;
			size = new Size((int)size3.Width, (int)size3.Height);
		}
		if ((enum7_0 & Enum7.flag_1) == Enum7.flag_1)
		{
			SizeF size4 = graphicsPath_1.GetBounds().Size;
			size = new Size((int)size4.Width, (int)size4.Height);
		}
		if ((enum7_0 & Enum7.flag_4) == Enum7.flag_4)
		{
			SizeF size5 = graphicsPath_4.GetBounds().Size;
			size = new Size((int)size5.Width, (int)size5.Height);
		}
		if ((enum7_0 & Enum7.flag_0) == Enum7.flag_0)
		{
			SizeF size6 = graphicsPath_0.GetBounds().Size;
			size = new Size((int)size6.Width, (int)size6.Height);
		}
		if (enum7_0 == Enum7.flag_6)
		{
			size = new Size(88, 88);
		}
		return new Rectangle(Point.Empty, size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		Color color = Color.FromArgb(65, 112, 202);
		Color color2 = Color.FromArgb(228, 228, 228);
		SolidBrush val = new SolidBrush(color2);
		Pen val2 = new Pen(color, 1f);
		try
		{
			if (bool_1)
			{
				graphics.DrawImageUnscaled((Image)(object)Bitmap_5, 0, 0);
				if ((enum7_0 & Enum7.flag_4) == Enum7.flag_4)
				{
					graphics.DrawImageUnscaled((Image)(object)Bitmap_4, (((Control)this).get_Width() - ((Image)Bitmap_4).get_Width()) / 2 + 2, (((Control)this).get_Height() - ((Image)Bitmap_4).get_Height()) / 2 + 2);
				}
				if ((enum7_0 & Enum7.flag_3) != Enum7.flag_3)
				{
					graphics.FillRectangle((Brush)(object)val, 33, 60, 23, 26);
				}
				if ((enum7_0 & Enum7.flag_2) != Enum7.flag_2)
				{
					graphics.FillRectangle((Brush)(object)val, 33, 4, 23, 26);
				}
				if ((enum7_0 & Enum7.flag_0) != Enum7.flag_0)
				{
					graphics.FillRectangle((Brush)(object)val, 4, 33, 26, 23);
				}
				if ((enum7_0 & Enum7.flag_1) != Enum7.flag_1)
				{
					graphics.FillRectangle((Brush)(object)val, 60, 33, 26, 23);
				}
			}
			else
			{
				if ((enum7_0 & Enum7.flag_0) == Enum7.flag_0)
				{
					graphics.DrawImage((Image)(object)Bitmap_2, graphicsPath_0.GetBounds());
				}
				if ((enum7_0 & Enum7.flag_1) == Enum7.flag_1)
				{
					graphics.DrawImage((Image)(object)Bitmap_3, graphicsPath_1.GetBounds());
				}
				if ((enum7_0 & Enum7.flag_2) == Enum7.flag_2)
				{
					graphics.DrawImage((Image)(object)Bitmap_0, graphicsPath_3.GetBounds());
				}
				if ((enum7_0 & Enum7.flag_3) == Enum7.flag_3)
				{
					graphics.DrawImage((Image)(object)Bitmap_1, graphicsPath_2.GetBounds());
				}
				else
				{
					graphics.FillRectangle((Brush)(object)val, 33, 84, 23, 26);
				}
			}
			if (enum12_0 == Enum12.const_1)
			{
				RectangleF bounds = graphicsPath_0.GetBounds();
				if (bool_1)
				{
					bounds.Inflate(0f, -6f);
					bounds.Width -= 6f;
				}
				graphics.DrawLine(val2, bounds.X, bounds.Y, bounds.Right, bounds.Y);
				graphics.DrawLine(val2, bounds.X, bounds.Y, bounds.X, bounds.Bottom);
				graphics.DrawLine(val2, bounds.X, bounds.Bottom - 1f, bounds.Right, bounds.Bottom - 1f);
			}
			if (enum12_0 == Enum12.const_2)
			{
				RectangleF bounds2 = graphicsPath_1.GetBounds();
				if (bool_1)
				{
					bounds2.Inflate(0f, -6f);
					bounds2.Width -= 6f;
					bounds2.X += 6f;
				}
				graphics.DrawLine(val2, bounds2.X, bounds2.Y, bounds2.Right, bounds2.Y);
				graphics.DrawLine(val2, bounds2.Right - 1f, bounds2.Y, bounds2.Right - 1f, bounds2.Bottom);
				graphics.DrawLine(val2, bounds2.X, bounds2.Bottom - 1f, bounds2.Right, bounds2.Bottom - 1f);
			}
			if (enum12_0 == Enum12.const_3)
			{
				RectangleF bounds3 = graphicsPath_3.GetBounds();
				if (bool_1)
				{
					bounds3.Inflate(-6f, 0f);
					bounds3.Height -= 6f;
				}
				graphics.DrawLine(val2, bounds3.X, bounds3.Y, bounds3.Right, bounds3.Y);
				graphics.DrawLine(val2, bounds3.Right - 1f, bounds3.Y, bounds3.Right - 1f, bounds3.Bottom);
				graphics.DrawLine(val2, bounds3.X, bounds3.Y, bounds3.X, bounds3.Bottom);
			}
			if (enum12_0 == Enum12.const_4)
			{
				RectangleF bounds4 = graphicsPath_2.GetBounds();
				if (bool_1)
				{
					bounds4.Inflate(-6f, 0f);
					bounds4.Height -= 6f;
					bounds4.Y += 6f;
				}
				graphics.DrawLine(val2, bounds4.X, bounds4.Bottom - 1f, bounds4.Right, bounds4.Bottom - 1f);
				graphics.DrawLine(val2, bounds4.Right - 1f, bounds4.Y, bounds4.Right - 1f, bounds4.Bottom);
				graphics.DrawLine(val2, bounds4.X, bounds4.Y, bounds4.X, bounds4.Bottom);
			}
		}
		finally
		{
			((Brush)val).Dispose();
			val2.Dispose();
		}
	}

	private GraphicsPath method_3(Enum7 enum7_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		if (enum7_1 == Enum7.flag_4)
		{
			val.AddRectangle(new Rectangle(29, 29, 29, 29));
		}
		else
		{
			val.StartFigure();
			val.AddLine(23, 28, 28, 23);
			val.AddLine(29, 23, 29, 0);
			val.AddLine(57, 0, 57, 23);
			val.AddLine(58, 23, 63, 28);
		}
		switch (enum7_1)
		{
		case Enum7.flag_3:
		{
			Matrix val4 = new Matrix();
			try
			{
				val4.Rotate(180f);
				val4.Translate((0f - val.GetBounds().Width) * 2f - 6f, (0f - val.GetBounds().Height) * 2f - 30f);
				val.Transform(val4);
				return val;
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		case Enum7.flag_0:
		{
			Matrix val3 = new Matrix();
			try
			{
				val3.Rotate(-90f);
				val3.Translate(-46f, 0f);
				val.Transform(val3);
				val3.Reset();
				val3.Translate(0f, val.GetBounds().Height);
				val.Transform(val3);
				return val;
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		case Enum7.flag_1:
		{
			Matrix val2 = new Matrix();
			try
			{
				val2.Rotate(90f);
				val.Transform(val2);
				val2.Reset();
				val2.Translate(val.GetBounds().Width * 2f + 30f, 0f);
				val.Transform(val2);
				return val;
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		default:
			return val;
		}
	}

	public Enum12 method_4(int int_0, int int_1)
	{
		if (((Control)this).get_Bounds().Contains(int_0, int_1))
		{
			Point point = ((Control)this).PointToClient(new Point(int_0, int_1));
			if (graphicsPath_0 != null && graphicsPath_0.IsVisible(point))
			{
				Enum12_0 = Enum12.const_1;
			}
			else if (graphicsPath_1 != null && graphicsPath_1.IsVisible(point))
			{
				Enum12_0 = Enum12.const_2;
			}
			else if (graphicsPath_3 != null && graphicsPath_3.IsVisible(point))
			{
				Enum12_0 = Enum12.const_3;
			}
			else if (graphicsPath_2 != null && graphicsPath_2.IsVisible(point))
			{
				Enum12_0 = Enum12.const_4;
			}
			else if (graphicsPath_4 != null && graphicsPath_4.IsVisible(point) && (enum7_0 & Enum7.flag_4) == Enum7.flag_4)
			{
				Enum12_0 = Enum12.const_5;
			}
			else
			{
				Enum12_0 = Enum12.const_0;
			}
		}
		else
		{
			Enum12_0 = Enum12.const_0;
		}
		method_5();
		return Enum12_0;
	}

	private void method_5()
	{
		if (bool_0)
		{
			bool_0 = false;
			((Control)this).Refresh();
		}
	}

	private void InitializeComponent()
	{
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_ControlBox(false);
		((Control)this).set_Name("DockingHint");
		((Control)this).set_Text("");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)0);
	}
}
