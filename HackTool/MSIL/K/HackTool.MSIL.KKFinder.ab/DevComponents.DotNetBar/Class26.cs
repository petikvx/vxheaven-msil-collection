using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class26
{
	public Rectangle rectangle_0 = Rectangle.Empty;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private Rectangle rectangle_3 = Rectangle.Empty;

	public int int_0 = 43;

	private bool bool_0 = true;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private eMouseState eMouseState_0;

	private eMouseState eMouseState_1;

	private eMouseState eMouseState_2;

	private TabStrip tabStrip_0;

	protected ToolTip toolTip_0;

	private Timer timer_0;

	private bool bool_3;

	private bool bool_4;

	public bool bool_5 = true;

	public bool Boolean_0
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			if (bool_2)
			{
				int_0 = 43;
			}
			else
			{
				int_0 = 32;
			}
		}
	}

	public Rectangle Rectangle_0 => rectangle_2;

	public Rectangle Rectangle_1 => rectangle_3;

	public bool Boolean_1
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				bool_1 = value;
				if (!bool_1)
				{
					method_1();
				}
			}
		}
	}

	public bool Boolean_2
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
				if (!bool_0)
				{
					method_1();
				}
			}
		}
	}

	public event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler Event_1
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public event EventHandler Event_2
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	public Class26(TabStrip parent)
	{
		tabStrip_0 = parent;
	}

	public void method_0()
	{
		method_1();
	}

	private void method_1()
	{
		bool_3 = false;
		bool_4 = false;
		if (timer_0 != null)
		{
			timer_0.Stop();
			timer_0.set_Enabled(false);
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	public void method_2()
	{
		method_12();
		if (!rectangle_0.IsEmpty && (eMouseState_0 != 0 || eMouseState_1 != 0 || eMouseState_2 != 0))
		{
			method_8();
			((Control)tabStrip_0).Invalidate(rectangle_0, false);
		}
	}

	public void method_3()
	{
		method_12();
		if (rectangle_0.IsEmpty)
		{
		}
	}

	public void method_4(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Invalid comparison between Unknown and I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Invalid comparison between Unknown and I4
		if (rectangle_0.IsEmpty)
		{
			return;
		}
		bool flag = false;
		if (eMouseState_0 != 0 || eMouseState_1 != 0 || eMouseState_2 != 0)
		{
			method_8();
			flag = true;
		}
		if (!rectangle_0.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			if (flag)
			{
				((Control)tabStrip_0).Invalidate(rectangle_0, false);
			}
			return;
		}
		if (rectangle_1.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			if (Boolean_0 && tabStrip_0.SelectedTab != null)
			{
				if ((int)mouseEventArgs_0.get_Button() == 1048576)
				{
					eMouseState_0 = eMouseState.Down;
				}
				else
				{
					eMouseState_0 = eMouseState.Hot;
				}
				flag = true;
			}
		}
		else if (rectangle_3.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			if (Boolean_2)
			{
				if ((int)mouseEventArgs_0.get_Button() == 1048576)
				{
					eMouseState_1 = eMouseState.Down;
				}
				else
				{
					eMouseState_1 = eMouseState.Hot;
				}
				flag = true;
			}
		}
		else if (rectangle_2.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()) && Boolean_1)
		{
			if ((int)mouseEventArgs_0.get_Button() == 1048576)
			{
				eMouseState_2 = eMouseState.Down;
			}
			else
			{
				eMouseState_2 = eMouseState.Hot;
			}
			flag = true;
		}
		if (flag)
		{
			Rectangle rectangle = rectangle_0;
			rectangle.Inflate(2, 2);
			((Control)tabStrip_0).Invalidate(rectangle, false);
		}
	}

	public void method_5(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		if ((int)mouseEventArgs_0.get_Button() != 1048576 || rectangle_0.IsEmpty)
		{
			return;
		}
		if (Boolean_0 && rectangle_1.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()) && tabStrip_0.SelectedTab != null)
		{
			eMouseState_0 = eMouseState.Down;
		}
		else if (Boolean_2 && rectangle_3.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			eMouseState_1 = eMouseState.Down;
			if (tabStrip_0.TabScrollAutoRepeat)
			{
				bool_3 = true;
				bool_4 = false;
				if (timer_0 == null)
				{
					timer_0 = new Timer();
				}
				timer_0.set_Interval(tabStrip_0.TabScrollRepeatInterval);
				timer_0.add_Tick((EventHandler)timer_0_Tick);
				timer_0.Start();
			}
		}
		else if (Boolean_1 && rectangle_2.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			eMouseState_2 = eMouseState.Down;
			if (tabStrip_0.TabScrollAutoRepeat)
			{
				bool_4 = true;
				bool_3 = false;
				if (timer_0 == null)
				{
					timer_0 = new Timer();
				}
				timer_0.set_Interval(tabStrip_0.TabScrollRepeatInterval);
				timer_0.add_Tick((EventHandler)timer_0_Tick);
				timer_0.Start();
			}
		}
		if (eMouseState_0 != 0 || eMouseState_1 != 0 || eMouseState_2 != 0)
		{
			((Control)tabStrip_0).Invalidate(rectangle_0, false);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (bool_3)
		{
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
		else if (bool_4)
		{
			if (eventHandler_1 != null)
			{
				eventHandler_1(this, new EventArgs());
			}
		}
		else if (timer_0 != null)
		{
			timer_0.Stop();
		}
	}

	public void method_6(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		method_1();
		if ((int)mouseEventArgs_0.get_Button() != 1048576 || rectangle_0.IsEmpty)
		{
			return;
		}
		bool flag = false;
		if (eMouseState_0 != 0 || eMouseState_1 != 0 || eMouseState_2 != 0)
		{
			flag = true;
		}
		if (Boolean_0 && rectangle_1.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()) && tabStrip_0.SelectedTab != null)
		{
			if (eMouseState_0 == eMouseState.Down && eventHandler_2 != null)
			{
				eventHandler_2(this, new EventArgs());
			}
			method_8();
		}
		else if (Boolean_2 && rectangle_3.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			if (eMouseState_1 == eMouseState.Down && eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
			method_8();
			eMouseState_1 = eMouseState.Hot;
		}
		else if (Boolean_1 && rectangle_2.Contains(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y()))
		{
			if (eMouseState_2 == eMouseState.Down && eventHandler_1 != null)
			{
				eventHandler_1(this, new EventArgs());
			}
			method_8();
			eMouseState_2 = eMouseState.Hot;
		}
		if (flag || eMouseState_0 != 0 || eMouseState_1 != 0 || eMouseState_2 != 0)
		{
			((Control)tabStrip_0).Invalidate(rectangle_0, false);
		}
	}

	public void method_7(MouseEventArgs mouseEventArgs_0)
	{
		if (tabStrip_0.Int32_1 <= 0)
		{
			return;
		}
		if (mouseEventArgs_0.get_Delta() > 0)
		{
			if (eventHandler_0 != null && Boolean_2)
			{
				eventHandler_0(this, new EventArgs());
			}
		}
		else if (eventHandler_1 != null && Boolean_1)
		{
			eventHandler_1(this, new EventArgs());
		}
	}

	private void method_8()
	{
		eMouseState_0 = eMouseState.None;
		eMouseState_1 = eMouseState.None;
		eMouseState_2 = eMouseState.None;
	}

	public void method_9(Graphics graphics_0)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		if (rectangle_0.IsEmpty)
		{
			return;
		}
		int x = rectangle_0.X;
		int y = rectangle_0.Y;
		Color color = graphics_0.GetNearestColor(ControlPaint.Light(tabStrip_0.ColorScheme.TabItemSelectedText));
		if ((double)Math.Abs(color.GetBrightness() - tabStrip_0.ColorScheme.TabBackground.GetBrightness()) <= 0.2)
		{
			color = (((double)tabStrip_0.ColorScheme.TabBackground.GetBrightness() < 0.5) ? ControlPaint.Light(tabStrip_0.ColorScheme.TabBackground) : ControlPaint.Dark(tabStrip_0.ColorScheme.TabBackground));
		}
		SolidBrush val = null;
		Pen val2 = new Pen(color, 1f);
		if (Boolean_2 || Boolean_1)
		{
			val = new SolidBrush(color);
		}
		if (tabStrip_0.TabAlignment != 0 && tabStrip_0.TabAlignment != eTabStripAlignment.Right)
		{
			x += (rectangle_0.Width - (bool_2 ? 32 : 18)) / 2;
			y += (rectangle_0.Height - 9) / 2;
			Point[] array = new Point[3];
			array[0].X = x + 4;
			array[0].Y = y;
			array[1].X = x + 4;
			array[1].Y = y + 8;
			array[2].X = x;
			array[2].Y = y + 4;
			rectangle_3 = new Rectangle(x - 5, y - 3, 14, 14);
			if (Boolean_2)
			{
				if (eMouseState_1 == eMouseState.Hot)
				{
					method_10(graphics_0, rectangle_3);
				}
				else if (eMouseState_1 == eMouseState.Down)
				{
					method_11(graphics_0, rectangle_3);
				}
				graphics_0.FillPolygon((Brush)(object)val, array);
			}
			graphics_0.DrawPolygon(val2, array);
			x += 14;
			array[0].X = x;
			array[0].Y = y;
			array[1].X = x;
			array[1].Y = y + 8;
			array[2].X = x + 4;
			array[2].Y = y + 4;
			rectangle_2 = new Rectangle(x - 5, y - 3, 14, 14);
			if (Boolean_1)
			{
				if (eMouseState_2 == eMouseState.Hot)
				{
					method_10(graphics_0, rectangle_2);
				}
				else if (eMouseState_2 == eMouseState.Down)
				{
					method_11(graphics_0, rectangle_2);
				}
				graphics_0.FillPolygon((Brush)(object)val, array);
			}
			graphics_0.DrawPolygon(val2, array);
			x += 13;
			if (Boolean_0)
			{
				rectangle_1 = new Rectangle(x - 4, y - 3, 14, 14);
				if (Boolean_0)
				{
					if (eMouseState_0 == eMouseState.Hot)
					{
						method_10(graphics_0, rectangle_1);
					}
					else if (eMouseState_0 == eMouseState.Down)
					{
						method_11(graphics_0, rectangle_1);
					}
				}
				graphics_0.DrawLine(val2, x, y + 1, x + 6, y + 7);
				graphics_0.DrawLine(val2, x + 1, y + 1, x + 7, y + 7);
				graphics_0.DrawLine(val2, x + 6, y + 1, x, y + 7);
				graphics_0.DrawLine(val2, x + 7, y + 1, x + 1, y + 7);
			}
		}
		else
		{
			y += (rectangle_0.Height - (bool_2 ? 32 : 18)) / 2;
			x += (rectangle_0.Width - 9) / 2;
			Point[] array2 = new Point[3];
			array2[0].X = x + 4;
			array2[0].Y = y;
			array2[1].X = x;
			array2[1].Y = y + 4;
			array2[2].X = x + 8;
			array2[2].Y = y + 4;
			rectangle_3 = new Rectangle(x - 3, y - 5, 14, 14);
			if (Boolean_2)
			{
				if (eMouseState_1 == eMouseState.Hot)
				{
					method_10(graphics_0, rectangle_3);
				}
				else if (eMouseState_1 == eMouseState.Down)
				{
					method_11(graphics_0, rectangle_3);
				}
				graphics_0.FillPolygon((Brush)(object)val, array2);
			}
			graphics_0.DrawPolygon(val2, array2);
			y += 14;
			array2[0].X = x;
			array2[0].Y = y;
			array2[1].X = x + 8;
			array2[1].Y = y;
			array2[2].X = x + 4;
			array2[2].Y = y + 4;
			rectangle_2 = new Rectangle(x - 3, y - 5, 14, 14);
			if (Boolean_1)
			{
				if (eMouseState_2 == eMouseState.Hot)
				{
					method_10(graphics_0, rectangle_2);
				}
				else if (eMouseState_2 == eMouseState.Down)
				{
					method_11(graphics_0, rectangle_2);
				}
				graphics_0.FillPolygon((Brush)(object)val, array2);
			}
			graphics_0.DrawPolygon(val2, array2);
			y += 13;
			if (Boolean_0)
			{
				rectangle_1 = new Rectangle(x - 3, y - 3, 14, 14);
				if (Boolean_0)
				{
					if (eMouseState_0 == eMouseState.Hot)
					{
						method_10(graphics_0, rectangle_1);
					}
					else if (eMouseState_0 == eMouseState.Down)
					{
						method_11(graphics_0, rectangle_1);
					}
				}
				graphics_0.DrawLine(val2, x + 1, y, x + 7, y + 6);
				graphics_0.DrawLine(val2, x + 1, y + 1, x + 7, y + 7);
				graphics_0.DrawLine(val2, x + 1, y + 6, x + 7, y);
				graphics_0.DrawLine(val2, x + 1, y + 7, x + 7, y + 1);
			}
		}
		val2.Dispose();
		if (val != null)
		{
			((Brush)val).Dispose();
		}
	}

	private void method_10(Graphics graphics_0, Rectangle rectangle_4)
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		Color color = tabStrip_0.ColorScheme.TabItemHotBorder;
		Color color2 = tabStrip_0.ColorScheme.TabItemHotBackground;
		Color color3 = tabStrip_0.ColorScheme.TabItemHotBackground2;
		if ((tabStrip_0.Style == eTabStripStyle.Office2003 || tabStrip_0.Style == eTabStripStyle.VS2005 || tabStrip_0.Style == eTabStripStyle.VS2005Document || tabStrip_0.Style == eTabStripStyle.VS2005Dock) && color2.IsEmpty && color3.IsEmpty)
		{
			ColorScheme colorScheme = ((tabStrip_0.Style != eTabStripStyle.Office2003) ? new ColorScheme(eDotNetBarStyle.VS2005) : new ColorScheme(eDotNetBarStyle.Office2003));
			color2 = colorScheme.ItemHotBackground;
			color3 = colorScheme.ItemHotBackground2;
			color = colorScheme.ItemHotBorder;
		}
		if (tabStrip_0.Style != eTabStripStyle.OneNote && tabStrip_0.Style != eTabStripStyle.Office2007Document && tabStrip_0.Style != eTabStripStyle.Office2007Dock && tabStrip_0.Style != eTabStripStyle.Office2003 && tabStrip_0.Style != eTabStripStyle.VS2005 && tabStrip_0.Style != eTabStripStyle.VS2005Document && tabStrip_0.Style != eTabStripStyle.VS2005Dock)
		{
			Color nearestColor = graphics_0.GetNearestColor(ControlPaint.LightLight(tabStrip_0.ColorScheme.TabBackground));
			Class109.smethod_36(graphics_0, rectangle_4, (Border3DStyle)4, (Border3DSide)15, nearestColor, bool_3: false);
			return;
		}
		if (color3.IsEmpty)
		{
			if (!color2.IsEmpty)
			{
				SolidBrush val = new SolidBrush(color2);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val, rectangle_4);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		else
		{
			LinearGradientBrush val2 = new LinearGradientBrush(rectangle_4, color2, color3, (float)tabStrip_0.ColorScheme.TabItemHotBackgroundGradientAngle);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val2, rectangle_4);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Pen val3 = new Pen(color, 1f);
		try
		{
			graphics_0.DrawRectangle(val3, rectangle_4);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	private void method_11(Graphics graphics_0, Rectangle rectangle_4)
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		Color color = tabStrip_0.ColorScheme.TabItemHotBorder;
		Color color2 = tabStrip_0.ColorScheme.TabItemHotBackground;
		Color color3 = tabStrip_0.ColorScheme.TabItemHotBackground2;
		if ((tabStrip_0.Style == eTabStripStyle.Office2003 || tabStrip_0.Style == eTabStripStyle.VS2005 || tabStrip_0.Style == eTabStripStyle.VS2005Document || tabStrip_0.Style == eTabStripStyle.VS2005Dock) && color2.IsEmpty && color3.IsEmpty)
		{
			ColorScheme colorScheme = ((tabStrip_0.Style != eTabStripStyle.Office2003) ? new ColorScheme(eDotNetBarStyle.VS2005) : new ColorScheme(eDotNetBarStyle.Office2003));
			color2 = colorScheme.ItemPressedBackground;
			color3 = colorScheme.ItemPressedBackground2;
			color = colorScheme.ItemPressedBorder;
		}
		if (tabStrip_0.Style != eTabStripStyle.OneNote && tabStrip_0.Style != eTabStripStyle.Office2007Document && tabStrip_0.Style != eTabStripStyle.Office2007Dock && tabStrip_0.Style != eTabStripStyle.Office2003 && tabStrip_0.Style != eTabStripStyle.VS2005 && tabStrip_0.Style != eTabStripStyle.VS2005 && tabStrip_0.Style != eTabStripStyle.VS2005Document)
		{
			Color nearestColor = graphics_0.GetNearestColor(ControlPaint.LightLight(tabStrip_0.ColorScheme.TabBackground));
			Class109.smethod_36(graphics_0, rectangle_4, (Border3DStyle)2, (Border3DSide)15, nearestColor, bool_3: false);
			return;
		}
		if (color3.IsEmpty)
		{
			if (!color2.IsEmpty)
			{
				SolidBrush val = new SolidBrush(color2);
				try
				{
					graphics_0.FillRectangle((Brush)(object)val, rectangle_4);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
		}
		else
		{
			LinearGradientBrush val2 = new LinearGradientBrush(rectangle_4, color3, color2, (float)tabStrip_0.ColorScheme.TabItemHotBackgroundGradientAngle);
			try
			{
				graphics_0.FillRectangle((Brush)(object)val2, rectangle_4);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		Pen val3 = new Pen(color, 1f);
		try
		{
			graphics_0.DrawRectangle(val3, rectangle_4);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	private void method_12()
	{
		if (toolTip_0 != null)
		{
			((Control)toolTip_0).Hide();
			((Component)(object)toolTip_0).Dispose();
			toolTip_0 = null;
		}
	}
}
