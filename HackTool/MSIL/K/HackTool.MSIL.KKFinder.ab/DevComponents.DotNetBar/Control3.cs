using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class Control3 : UserControl
{
	private bool bool_0;

	private bool bool_1;

	private eOrientation eOrientation_0;

	private eItemAlignment eItemAlignment_0;

	private Timer timer_0;

	public ColorScheme colorScheme_0;

	private Class63 class63_0;

	public bool bool_2;

	public bool bool_3 = true;

	public bool bool_4;

	public eOrientation EOrientation_0
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			if (eOrientation_0 != value)
			{
				eOrientation_0 = value;
				((Control)this).Refresh();
			}
		}
	}

	public eItemAlignment EItemAlignment_0
	{
		get
		{
			return eItemAlignment_0;
		}
		set
		{
			if (eItemAlignment_0 != value)
			{
				eItemAlignment_0 = value;
				((Control)this).Refresh();
			}
		}
	}

	private Class63 Class63_0
	{
		get
		{
			if (class63_0 == null)
			{
				class63_0 = new Class63((Control)(object)this);
			}
			return class63_0;
		}
	}

	public Control3()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).set_TabStop(false);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected O, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		if (bool_4)
		{
			method_0(e);
			return;
		}
		if (bool_0)
		{
			if (colorScheme_0 == null)
			{
				SolidBrush val = new SolidBrush(ColorFunctions.HoverBackColor(graphics));
				try
				{
					graphics.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
				Class92.smethod_4(graphics, SystemPens.get_Highlight(), ((Control)this).get_ClientRectangle());
			}
			else
			{
				if (!colorScheme_0.ItemHotBackground2.IsEmpty)
				{
					LinearGradientBrush val2 = Class109.smethod_40(((Control)this).get_ClientRectangle(), colorScheme_0.ItemHotBackground, colorScheme_0.ItemHotBackground2, colorScheme_0.ItemHotBackgroundGradientAngle);
					graphics.FillRectangle((Brush)(object)val2, ((Control)this).get_ClientRectangle());
					((Brush)val2).Dispose();
				}
				else
				{
					SolidBrush val3 = new SolidBrush(colorScheme_0.ItemHotBackground);
					try
					{
						graphics.FillRectangle((Brush)(object)val3, ((Control)this).get_DisplayRectangle());
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				Class92.smethod_4(graphics, new Pen(colorScheme_0.ItemHotBorder), ((Control)this).get_ClientRectangle());
			}
		}
		else if (colorScheme_0 == null)
		{
			SolidBrush val4 = new SolidBrush(SystemColors.Control);
			try
			{
				graphics.FillRectangle((Brush)(object)val4, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			Class92.smethod_4(graphics, SystemPens.get_ControlDark(), ((Control)this).get_ClientRectangle());
		}
		else if (colorScheme_0.ItemBackground.IsEmpty)
		{
			SolidBrush val5 = new SolidBrush(colorScheme_0.BarBackground);
			try
			{
				graphics.FillRectangle((Brush)(object)val5, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		else if (colorScheme_0.ItemBackground2.IsEmpty)
		{
			SolidBrush val6 = new SolidBrush(colorScheme_0.ItemBackground);
			try
			{
				graphics.FillRectangle((Brush)(object)val6, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		else
		{
			LinearGradientBrush val7 = Class109.smethod_40(((Control)this).get_DisplayRectangle(), colorScheme_0.ItemBackground, colorScheme_0.ItemBackground2, colorScheme_0.ItemBackgroundGradientAngle);
			try
			{
				graphics.FillRectangle((Brush)(object)val7, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			if (eItemAlignment_0 == eItemAlignment.Far)
			{
				Point[] array = new Point[3];
				array[0].X = ((Control)this).get_ClientRectangle().Width / 2 - 2;
				array[0].Y = (((Control)this).get_ClientRectangle().Height - 8) / 2;
				array[1].X = array[0].X;
				array[1].Y = array[0].Y + 8;
				array[2].X = array[0].X + 4;
				array[2].Y = array[0].Y + 4;
				if (colorScheme_0 == null)
				{
					graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
				}
				else
				{
					graphics.FillPolygon((Brush)new SolidBrush(colorScheme_0.ItemText), array);
				}
			}
			else
			{
				Point[] array2 = new Point[3];
				array2[0].X = ((Control)this).get_ClientRectangle().Width / 2 + 2;
				array2[0].Y = (((Control)this).get_ClientRectangle().Height - 8) / 2;
				array2[1].X = array2[0].X;
				array2[1].Y = array2[0].Y + 8;
				array2[2].X = array2[0].X - 4;
				array2[2].Y = array2[0].Y + 4;
				if (colorScheme_0 == null)
				{
					graphics.FillPolygon(SystemBrushes.get_ControlText(), array2);
				}
				else
				{
					graphics.FillPolygon((Brush)new SolidBrush(colorScheme_0.ItemText), array2);
				}
			}
		}
		else if (eItemAlignment_0 == eItemAlignment.Far)
		{
			Point[] array3 = new Point[3];
			array3[0].X = ((Control)this).get_ClientRectangle().Width / 2 - 3;
			array3[0].Y = (((Control)this).get_ClientRectangle().Height - 4) / 2;
			array3[1].X = array3[0].X + 7;
			array3[1].Y = array3[0].Y;
			array3[2].X = array3[0].X + 3;
			array3[2].Y = array3[0].Y + 4;
			if (colorScheme_0 == null)
			{
				graphics.FillPolygon(SystemBrushes.get_ControlText(), array3);
			}
			else
			{
				graphics.FillPolygon((Brush)new SolidBrush(colorScheme_0.ItemText), array3);
			}
		}
		else
		{
			Point[] array4 = new Point[3];
			array4[0].X = ((Control)this).get_ClientRectangle().Width / 2 - 3;
			array4[0].Y = (((Control)this).get_ClientRectangle().Height + 3) / 2;
			array4[1].X = array4[0].X + 7;
			array4[1].Y = array4[0].Y;
			array4[2].X = array4[0].X + 3;
			array4[2].Y = array4[0].Y - 4;
			if (colorScheme_0 == null)
			{
				graphics.FillPolygon(SystemBrushes.get_ControlText(), array4);
			}
			else
			{
				graphics.FillPolygon((Brush)new SolidBrush(colorScheme_0.ItemText), array4);
			}
		}
	}

	private void method_0(PaintEventArgs paintEventArgs_0)
	{
		Graphics graphics = paintEventArgs_0.get_Graphics();
		if (bool_2)
		{
			Class63 @class = Class63_0;
			Class138 class138_ = Class138.class138_0;
			Class163 class163_ = Class163.class163_0;
			class163_ = (bool_0 ? ((eOrientation_0 == eOrientation.Vertical) ? ((eItemAlignment_0 != 0) ? Class163.class163_5 : Class163.class163_1) : ((eItemAlignment_0 != 0) ? Class163.class163_13 : Class163.class163_9)) : ((eOrientation_0 == eOrientation.Vertical) ? ((eItemAlignment_0 != 0) ? Class163.class163_4 : Class163.class163_0) : ((eItemAlignment_0 != 0) ? Class163.class163_12 : Class163.class163_8)));
			@class.method_0(graphics, class138_, class163_, ((Control)this).get_DisplayRectangle());
			return;
		}
		if (bool_1)
		{
			Class109.smethod_37(graphics, ((Control)this).get_DisplayRectangle(), (Border3DStyle)8);
		}
		else
		{
			Class109.smethod_37(graphics, ((Control)this).get_DisplayRectangle(), (Border3DStyle)5);
		}
		if (eOrientation_0 == eOrientation.Vertical)
		{
			method_1(graphics, ((Control)this).get_DisplayRectangle(), SystemColors.ControlText, eItemAlignment_0 == eItemAlignment.Near);
		}
	}

	private void method_1(Graphics graphics_0, Rectangle rectangle_0, Color color_0, bool bool_5)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		Point[] array = new Point[3];
		if (bool_5)
		{
			array[0].X = rectangle_0.Left + (rectangle_0.Width - 9) / 2;
			array[0].Y = rectangle_0.Top + rectangle_0.Height / 2 + 1;
			array[1].X = array[0].X + 8;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 4;
			array[2].Y = array[0].Y - 5;
		}
		else
		{
			array[0].X = rectangle_0.Left + (rectangle_0.Width - 7) / 2;
			array[0].Y = rectangle_0.Top + (rectangle_0.Height - 4) / 2;
			array[1].X = array[0].X + 7;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y + 4;
		}
		graphics_0.FillPolygon((Brush)new SolidBrush(color_0), array);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		if (!bool_0)
		{
			bool_0 = true;
			((Control)this).Refresh();
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		if (bool_0)
		{
			bool_0 = false;
			((Control)this).Refresh();
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		if (bool_3)
		{
			method_2();
		}
	}

	private void method_2()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		if (timer_0 == null)
		{
			timer_0 = new Timer();
			timer_0.set_Interval(200);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.Start();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		((Control)this).InvokeOnClick((Control)(object)this, new EventArgs());
	}

	protected override void Dispose(bool disposing)
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		((ContainerControl)this).Dispose(disposing);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_3();
		((Control)this).OnHandleDestroyed(e);
	}

	private void method_3()
	{
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = null;
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 794)
		{
			method_4();
		}
		else if (((Message)(ref m)).get_Msg() == 33)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
			return;
		}
		((UserControl)this).WndProc(ref m);
	}

	private void method_4()
	{
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = new Class63((Control)(object)this);
		}
	}
}
