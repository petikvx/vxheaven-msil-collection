using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class36
{
	private bool bool_0 = true;

	private bool bool_1;

	private bool bool_2;

	private Size size_0 = new Size(11, 11);

	private int int_0 = 3;

	public virtual bool AntiAlias
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
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

	public bool Boolean_1
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
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
		}
	}

	public virtual void Paint(Graphics g, TabStrip tabStrip)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		if (AntiAlias)
		{
			g.set_SmoothingMode((SmoothingMode)4);
			g.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
	}

	protected virtual void PaintTab(Graphics g, TabItem tab, bool first, bool last)
	{
		if (!tab.Visible)
		{
			return;
		}
		if (tab.Parent != null && tab.Parent.Boolean_4)
		{
			RenderTabItemEventArgs renderTabItemEventArgs = new RenderTabItemEventArgs(tab, g);
			tab.Parent.method_19(renderTabItemEventArgs);
			if (renderTabItemEventArgs.Cancel)
			{
				return;
			}
		}
		GraphicsPath tabItemPath = GetTabItemPath(tab, first, last);
		try
		{
			TabColors colors = tab.Parent.method_44(tab);
			DrawTabItemBackground(tab, tabItemPath, colors, g);
			DrawTabText(tab, colors, g);
		}
		finally
		{
			((IDisposable)tabItemPath)?.Dispose();
		}
		if (tab.Parent != null && tab.Parent.Boolean_5)
		{
			RenderTabItemEventArgs renderTabItemEventArgs_ = new RenderTabItemEventArgs(tab, g);
			tab.Parent.method_20(renderTabItemEventArgs_);
		}
	}

	protected virtual Region GetTabsRegion(TabsCollection tabs, TabItem lastTab)
	{
		return null;
	}

	protected virtual void DrawTabItemBackground(TabItem tab, GraphicsPath path, TabColors colors, Graphics g)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		RectangleF bounds = path.GetBounds();
		Rectangle r = new Rectangle((int)bounds.X, (int)bounds.Y, (int)bounds.Width, (int)bounds.Height);
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Enum11 @enum = colors.BackgroundColorBlend.method_1();
		int num = colors.BackColorGradientAngle;
		if (tab.TabAlignment == eTabStripAlignment.Left || tab.TabAlignment == eTabStripAlignment.Right)
		{
			num -= 90;
		}
		switch (@enum)
		{
		case Enum11.const_1:
			try
			{
				Rectangle rectangle_ = Rectangle.Ceiling(bounds);
				rectangle_.Inflate(1, 1);
				LinearGradientBrush val2 = Class50.smethod_0(rectangle_, colors.BackColor, colors.BackColor2, num);
				try
				{
					val2.set_InterpolationColors(colors.BackgroundColorBlend.GetColorBlend());
					g.FillPath((Brush)(object)val2, path);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			catch
			{
				@enum = Enum11.const_0;
			}
			break;
		default:
		{
			Rectangle rectangle = Rectangle.Ceiling(bounds);
			BackgroundColorBlendCollection backgroundColorBlend = colors.BackgroundColorBlend;
			Region clip = g.get_Clip();
			g.SetClip(path, (CombineMode)1);
			for (int i = 0; i < backgroundColorBlend.Count; i += 2)
			{
				BackgroundColorBlend backgroundColorBlend2 = backgroundColorBlend[i];
				BackgroundColorBlend backgroundColorBlend3 = null;
				if (i < backgroundColorBlend.Count)
				{
					backgroundColorBlend3 = backgroundColorBlend[i + 1];
				}
				if (backgroundColorBlend2 != null && backgroundColorBlend3 != null)
				{
					Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y + (int)backgroundColorBlend2.Position, rectangle.Width, ((backgroundColorBlend3.Position == 1f) ? rectangle.Height : ((int)backgroundColorBlend3.Position)) - (int)backgroundColorBlend2.Position);
					LinearGradientBrush val = Class50.smethod_0(rectangle2, backgroundColorBlend2.Color, backgroundColorBlend3.Color, num);
					try
					{
						g.FillRectangle((Brush)(object)val, rectangle2);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
			}
			g.set_Clip(clip);
			break;
		}
		case Enum11.const_0:
			break;
		}
		if (@enum == Enum11.const_0)
		{
			if (colors.BackColor2.IsEmpty)
			{
				if (!colors.BackColor.IsEmpty)
				{
					SolidBrush val3 = new SolidBrush(colors.BackColor);
					try
					{
						g.FillPath((Brush)(object)val3, path);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
			}
			else
			{
				SolidBrush val4 = new SolidBrush(Color.White);
				try
				{
					g.FillPath((Brush)(object)val4, path);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				LinearGradientBrush val5 = CreateTabGradientBrush(r, colors.BackColor, colors.BackColor2, num);
				try
				{
					g.FillPath((Brush)(object)val5, path);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
		}
		g.set_SmoothingMode(smoothingMode);
		DrawTabBorder(tab, path, colors, g);
	}

	protected virtual void DrawTabBorder(TabItem tab, GraphicsPath path, TabColors colors, Graphics g)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!colors.BorderColor.IsEmpty)
		{
			Pen val = new Pen(colors.BorderColor, 1f);
			try
			{
				g.DrawPath(val, path);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	protected virtual LinearGradientBrush CreateTabGradientBrush(Rectangle r, Color color1, Color color2, int gradientAngle)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (r.Width <= 0)
		{
			r.Width = 1;
		}
		if (r.Height <= 0)
		{
			r.Height = 1;
		}
		return new LinearGradientBrush(new Rectangle(r.X, r.Y - 1, r.Width, r.Height + 1), color1, color2, (float)gradientAngle);
	}

	private Rectangle method_0(Graphics graphics_0, bool bool_3, bool bool_4, ref Rectangle rectangle_0, TabStrip tabStrip_0)
	{
		Size size = size_0;
		int num = int_0;
		bool flag = tabStrip_0.CloseButtonPosition == eTabCloseButtonPosition.Left;
		Rectangle empty = Rectangle.Empty;
		empty = (flag ? ((!bool_3) ? new Rectangle(rectangle_0.X + num, rectangle_0.Y + (rectangle_0.Height - size.Height) / 2, size.Width, size.Height) : new Rectangle(rectangle_0.X + (rectangle_0.Width - size.Width) / 2, rectangle_0.Y + num, size.Width, size.Height)) : ((!bool_3) ? new Rectangle(rectangle_0.Right - num - size.Width, rectangle_0.Y + (rectangle_0.Height - size.Height) / 2, size.Width, size.Height) : new Rectangle(rectangle_0.X + (rectangle_0.Width - size.Width) / 2, rectangle_0.Bottom - num - size.Height, size.Width, size.Height)));
		AdjustCloseButtonRectangle(ref empty, flag, bool_3);
		smethod_0(graphics_0, empty, bool_4, tabStrip_0);
		if (bool_3)
		{
			if (flag)
			{
				rectangle_0.Y += empty.Height + num * 2;
			}
			rectangle_0.Height -= empty.Height + num * 2;
		}
		else
		{
			if (flag)
			{
				rectangle_0.X += empty.Width + num * 2;
			}
			rectangle_0.Width -= empty.Width + num * 2;
		}
		return empty;
	}

	protected virtual void AdjustCloseButtonRectangle(ref Rectangle close, bool closeOnLeftSide, bool vertical)
	{
	}

	protected virtual void DrawTabText(TabItem tab, TabColors colors, Graphics g)
	{
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		eTabStripAlignment tabAlignment = tab.Parent.TabAlignment;
		Rectangle rectangle_ = tab.DisplayRectangle;
		bool flag = (tabAlignment == eTabStripAlignment.Left || tabAlignment == eTabStripAlignment.Right) && !bool_1;
		if (bool_2 && tab.CloseButtonVisible)
		{
			if (flag)
			{
				rectangle_.Y++;
				rectangle_.Height--;
			}
			else
			{
				rectangle_.X += 2;
				rectangle_.Width -= 2;
			}
			tab.CloseButtonBounds = method_0(g, flag, tab.CloseButtonMouseOver, ref rectangle_, tab.Parent);
		}
		Class271 tabImage = GetTabImage(tab);
		if (tabImage != null && tabImage.Int32_0 + 4 <= rectangle_.Width)
		{
			if (tabAlignment != eTabStripAlignment.Top && tabAlignment != eTabStripAlignment.Bottom && !bool_1)
			{
				tabImage.method_0(g, new Rectangle(rectangle_.X + (rectangle_.Width - tabImage.Int32_0) / 2, rectangle_.Y + 3, tabImage.Int32_0, tabImage.Int32_1));
				int num2 = tabImage.Int32_1 + 2;
				rectangle_.Y += num2;
				rectangle_.Height -= num2;
			}
			else
			{
				tabImage.method_0(g, new Rectangle(rectangle_.X + 3, rectangle_.Y + (rectangle_.Height - tabImage.Int32_1) / 2, tabImage.Int32_0, tabImage.Int32_1));
				int num3 = tabImage.Int32_0 + 2;
				rectangle_.X += num3;
				rectangle_.Width -= num3;
			}
		}
		bool flag2 = tab == tab.Parent.SelectedTab;
		if (tab.Parent.DisplaySelectedTextOnly && !flag2)
		{
			return;
		}
		if (!tab.Parent.AntiAlias)
		{
			g.set_TextRenderingHint((TextRenderingHint)0);
		}
		Font font_ = ((Control)tab.Parent).get_Font();
		if (flag2 && tab.Parent.SelectedTabFont != null)
		{
			font_ = tab.Parent.SelectedTabFont;
		}
		AdjustTextRectangle(ref rectangle_, tabAlignment);
		if (flag)
		{
			g.RotateTransform(90f);
			rectangle_ = new Rectangle(rectangle_.Top, -rectangle_.Right, rectangle_.Height, rectangle_.Width);
		}
		if (rectangle_.Width > num)
		{
			if ((tabAlignment == eTabStripAlignment.Left || tabAlignment == eTabStripAlignment.Right) && !bool_1)
			{
				Class55.smethod_2(g, tab.Text, font_, colors.TextColor, rectangle_, eTextFormat_);
			}
			else
			{
				Class55.smethod_1(g, tab.Text, font_, colors.TextColor, rectangle_, eTextFormat_);
			}
		}
		if (flag)
		{
			g.ResetTransform();
		}
		if (!tab.Parent.AntiAlias)
		{
			g.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		if (tab.Parent.ShowFocusRectangle && ((Control)tab.Parent).get_Focused() && flag2)
		{
			ControlPaint.DrawFocusRectangle(g, GetFocusRectangle(tab.DisplayRectangle));
		}
	}

	protected virtual void AdjustTextRectangle(ref Rectangle rText, eTabStripAlignment tabAlignment)
	{
	}

	protected virtual Class271 GetTabImage(TabItem tab)
	{
		Image image = tab.GetImage();
		if (image != null)
		{
			return new Class271(image, dispose: false);
		}
		Icon icon = tab.Icon;
		if (icon != null)
		{
			return new Class271(icon, dispose: false, tab.IconSize);
		}
		return null;
	}

	protected virtual Rectangle GetFocusRectangle(Rectangle rText)
	{
		rText.Inflate(-1, -1);
		return rText;
	}

	protected virtual TabItem GetLastVisibleTab(TabsCollection tabs)
	{
		int num = tabs.Count - 1;
		int num2 = num;
		while (true)
		{
			if (num2 >= 0)
			{
				if (tabs[num2].Visible)
				{
					break;
				}
				num2--;
				continue;
			}
			return null;
		}
		return tabs[num2];
	}

	protected virtual void DrawBackground(TabStrip tabStrip, Rectangle tabStripRect, Graphics g, TabColorScheme colors, Region tabsRegion, eTabStripAlignment tabAlignment, Rectangle selectedTabRect)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (colors.TabBackground2.IsEmpty)
		{
			SolidBrush val = new SolidBrush(colors.TabBackground);
			try
			{
				g.FillRegion((Brush)(object)val, tabsRegion);
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		LinearGradientBrush val2 = Class109.smethod_41(tabsRegion.GetBounds(g), colors.TabBackground, colors.TabBackground2, colors.TabBackgroundGradientAngle);
		try
		{
			g.FillRegion((Brush)(object)val2, tabsRegion);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected virtual GraphicsPath GetTabItemPath(TabItem tab, bool bFirst, bool bLast)
	{
		return null;
	}

	protected virtual Struct10 GetCornerArc(Rectangle bounds, int cornerDiameter, Enum14 corner)
	{
		int num = cornerDiameter * 2;
		return corner switch
		{
			Enum14.const_0 => new Struct10(bounds.X, bounds.Y, num, num, 180f, 90f), 
			Enum14.const_1 => new Struct10(bounds.Right - num, bounds.Y, num, num, 270f, 90f), 
			Enum14.const_2 => new Struct10(bounds.X, bounds.Bottom - num, num, num, 90f, 90f), 
			_ => new Struct10(bounds.Right - num, bounds.Bottom - num, num, num, 0f, 90f), 
		};
	}

	public static void smethod_0(Graphics graphics_0, Rectangle rectangle_0, bool bool_3, TabStrip tabStrip_0)
	{
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		if (tabStrip_0.TabCloseButtonNormal != null)
		{
			Image val = tabStrip_0.TabCloseButtonNormal;
			if (bool_3 && tabStrip_0.TabCloseButtonHot != null)
			{
				val = tabStrip_0.TabCloseButtonHot;
			}
			graphics_0.DrawImageUnscaled(val, rectangle_0);
			return;
		}
		Color color = tabStrip_0.ColorScheme.TabItemBorder;
		Color color2 = tabStrip_0.ColorScheme.TabItemBorderLight;
		if (!color.IsEmpty && (double)Math.Abs(color.GetBrightness() - color2.GetBrightness()) <= 0.38)
		{
			color = Class109.smethod_0(color, 40);
		}
		if (color.IsEmpty)
		{
			if (!tabStrip_0.ColorScheme.TabItemSelectedBorder.IsEmpty)
			{
				color = tabStrip_0.ColorScheme.TabItemSelectedBorder;
				if (!tabStrip_0.ColorScheme.TabItemSelectedBorderLight.IsEmpty)
				{
					color2 = tabStrip_0.ColorScheme.TabItemSelectedBorderLight;
				}
			}
			else
			{
				color = SystemColors.ControlDark;
				color2 = SystemColors.ControlLightLight;
			}
		}
		if (color2.IsEmpty)
		{
			color2 = SystemColors.ControlLightLight;
		}
		if (!color.IsEmpty && (double)Math.Abs(color.GetBrightness() - color2.GetBrightness()) <= 0.38)
		{
			if ((double)color2.GetBrightness() < 0.5)
			{
				color = color2;
				color2 = SystemColors.ControlLightLight;
			}
			else
			{
				color = (((double)color2.GetBrightness() < 0.5) ? SystemColors.ControlLightLight : SystemColors.ControlDarkDark);
			}
		}
		color = Color.FromArgb(bool_3 ? 255 : 200, color);
		Pen val2 = new Pen(Color.White, 1f);
		try
		{
			graphics_0.DrawEllipse(val2, rectangle_0);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Pen val3 = new Pen(color, 1f);
		try
		{
			graphics_0.DrawEllipse(val3, rectangle_0);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		SolidBrush val4 = new SolidBrush(Color.White);
		try
		{
			graphics_0.FillEllipse((Brush)(object)val4, rectangle_0);
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		SolidBrush val5 = new SolidBrush(color);
		try
		{
			graphics_0.FillEllipse((Brush)(object)val5, rectangle_0);
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
		Pen val6 = new Pen(color2, 1f);
		try
		{
			Rectangle rectangle = rectangle_0;
			rectangle.Inflate(-3, -3);
			rectangle.Width--;
			graphics_0.DrawLine(val6, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Bottom);
			graphics_0.DrawLine(val6, rectangle.X, rectangle.Bottom, rectangle.Right, rectangle.Y);
			rectangle.Offset(1, 0);
			graphics_0.DrawLine(val6, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Bottom);
			graphics_0.DrawLine(val6, rectangle.X, rectangle.Bottom, rectangle.Right, rectangle.Y);
		}
		finally
		{
			((IDisposable)val6)?.Dispose();
		}
	}
}
