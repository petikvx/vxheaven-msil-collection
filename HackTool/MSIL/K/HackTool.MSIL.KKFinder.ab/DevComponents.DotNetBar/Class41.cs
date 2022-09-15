using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class41 : Class36
{
	private int int_1 = 3;

	public override void Paint(Graphics g, TabStrip tabStrip)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		base.Paint(g, tabStrip);
		TabColorScheme colorScheme = tabStrip.ColorScheme;
		Rectangle displayRectangle = ((Control)tabStrip).get_DisplayRectangle();
		if (((Control)tabStrip).get_BackColor() != Color.Transparent || colorScheme.TabBackground != Color.Transparent)
		{
			if (colorScheme.TabPanelBackground2.IsEmpty)
			{
				if (!colorScheme.TabPanelBackground.IsEmpty)
				{
					SolidBrush val = new SolidBrush(colorScheme.TabPanelBackground);
					try
					{
						g.FillRectangle((Brush)(object)val, displayRectangle);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
			}
			else
			{
				SolidBrush val2 = new SolidBrush(Color.White);
				try
				{
					g.FillRectangle((Brush)(object)val2, displayRectangle);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				LinearGradientBrush val3 = CreateTabGradientBrush(displayRectangle, colorScheme.TabPanelBackground, colorScheme.TabPanelBackground2, colorScheme.TabPanelBackgroundGradientAngle);
				try
				{
					g.FillRectangle((Brush)(object)val3, displayRectangle);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
		}
		Rectangle selectedTabRect = Rectangle.Empty;
		if (tabStrip.SelectedTab != null)
		{
			selectedTabRect = tabStrip.SelectedTab.DisplayRectangle;
		}
		Region val4 = new Region(((Control)tabStrip).get_DisplayRectangle());
		try
		{
			DrawBackground(tabStrip, displayRectangle, g, colorScheme, val4, tabStrip.TabAlignment, selectedTabRect);
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		Rectangle systemBoxRectangle = tabStrip.GetSystemBoxRectangle();
		systemBoxRectangle.Inflate(-2, -2);
		for (int num = tabStrip.Tabs.Count - 1; num >= 0; num--)
		{
			TabItem tabItem = tabStrip.Tabs[num];
			if (tabItem.Visible && tabItem != tabStrip.SelectedTab && !tabItem.DisplayRectangle.IntersectsWith(systemBoxRectangle) && tabItem.DisplayRectangle.IntersectsWith(displayRectangle))
			{
				PaintTab(g, tabItem, first: false, last: false);
			}
		}
		if (tabStrip.SelectedTab != null && tabStrip.Tabs.Contains(tabStrip.SelectedTab) && !method_1(tabStrip.SelectedTab).IntersectsWith(systemBoxRectangle))
		{
			PaintTab(g, tabStrip.SelectedTab, first: false, last: false);
		}
		g.ResetClip();
		tabStrip.method_1(g);
	}

	private Rectangle method_1(TabItem tabItem_0)
	{
		Rectangle displayRectangle = tabItem_0.DisplayRectangle;
		if (tabItem_0.TabAlignment != eTabStripAlignment.Top && tabItem_0.TabAlignment != eTabStripAlignment.Bottom)
		{
			displayRectangle.Height -= displayRectangle.Width - 6;
		}
		else
		{
			displayRectangle.Width -= displayRectangle.Height - 6;
		}
		return displayRectangle;
	}

	protected override GraphicsPath GetTabItemPath(TabItem tab, bool bFirst, bool bLast)
	{
		return method_2(tab.DisplayRectangle, tab.TabAlignment, bool_3: true);
	}

	private GraphicsPath method_2(Rectangle rectangle_0, eTabStripAlignment eTabStripAlignment_0, bool bool_3)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		Rectangle rectangle = rectangle_0;
		switch (eTabStripAlignment_0)
		{
		case eTabStripAlignment.Right:
			rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Height, rectangle.Width);
			break;
		case eTabStripAlignment.Left:
			rectangle = new Rectangle(rectangle.X, rectangle.Y, rectangle.Height, rectangle.Width);
			break;
		}
		if (eTabStripAlignment_0 != eTabStripAlignment.Bottom && eTabStripAlignment_0 != eTabStripAlignment.Top)
		{
			rectangle.Offset(1, 0);
		}
		else
		{
			rectangle.Offset(0, 1);
		}
		GraphicsPath val = new GraphicsPath();
		if (eTabStripAlignment_0 != eTabStripAlignment.Bottom && eTabStripAlignment_0 != 0)
		{
			val.AddLine(rectangle.X, rectangle.Bottom, rectangle.X, rectangle.Y + int_1);
			val.AddLine(rectangle.X, rectangle.Y + int_1, rectangle.X + int_1, rectangle.Y);
			val.AddLine(rectangle.X + int_1, rectangle.Y, rectangle.Right - rectangle.Height / 2, rectangle.Y);
			Point[] array = new Point[4];
			array[0].X = rectangle.Right - rectangle.Height / 2;
			array[0].Y = rectangle.Y;
			array[1].X = array[0].X + 5;
			array[1].Y = array[0].Y + 3;
			array[2].X = array[1].X + rectangle.Height / 2;
			array[2].Y = rectangle.Bottom - 3;
			array[3].X = array[2].X + 4;
			array[3].Y = rectangle.Bottom;
			val.AddCurve(array, 0, 3, 0.1f);
			if (bool_3)
			{
				val.AddLine(rectangle.Right, rectangle.Bottom, rectangle.X, rectangle.Bottom);
			}
		}
		else
		{
			val.AddLine(rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom - int_1);
			val.AddLine(rectangle.X, rectangle.Bottom - int_1, rectangle.X + int_1, rectangle.Bottom);
			val.AddLine(rectangle.X + int_1, rectangle.Bottom, rectangle.Right - rectangle.Height / 2, rectangle.Bottom);
			Point[] array2 = new Point[4];
			array2[0].X = rectangle.Right - rectangle.Height / 2;
			array2[0].Y = rectangle.Bottom;
			array2[1].X = array2[0].X + 5;
			array2[1].Y = array2[0].Y - 3;
			array2[2].X = array2[1].X + rectangle.Height / 2;
			array2[2].Y = rectangle.Y + 3;
			array2[3].X = array2[2].X + 4;
			array2[3].Y = rectangle.Y;
			val.AddCurve(array2, 0, 3, 0.1f);
			if (bool_3)
			{
				val.AddLine(rectangle.Right, rectangle.Y, rectangle.X, rectangle.Y);
			}
		}
		switch (eTabStripAlignment_0)
		{
		case eTabStripAlignment.Left:
		{
			Matrix val3 = new Matrix();
			val3.RotateAt(90f, new PointF(rectangle.Right, rectangle.Bottom));
			val3.Translate((float)(-rectangle.Width - 2), (float)(rectangle.Width - rectangle.Height), (MatrixOrder)1);
			val.Transform(val3);
			break;
		}
		case eTabStripAlignment.Right:
		{
			Matrix val2 = new Matrix();
			val2.RotateAt(90f, new PointF(rectangle.Right, rectangle.Bottom));
			val2.Translate((float)(-rectangle.Width), (float)(rectangle.Width - rectangle.Height), (MatrixOrder)1);
			val.Transform(val2);
			break;
		}
		}
		if (bool_3)
		{
			val.CloseAllFigures();
		}
		return val;
	}

	protected override void DrawTabBorder(TabItem tab, GraphicsPath path, TabColors colors, Graphics g)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		Rectangle displayRectangle = tab.DisplayRectangle;
		eTabStripAlignment tabAlignment = tab.TabAlignment;
		Region clip = g.get_Clip();
		Rectangle clip2 = Rectangle.Ceiling(path.GetBounds());
		if (tab.TabAlignment == eTabStripAlignment.Right || tab.TabAlignment == eTabStripAlignment.Bottom)
		{
			clip2.Inflate(1, 1);
		}
		g.SetClip(clip2);
		if (!colors.BorderColor.IsEmpty)
		{
			GraphicsPath val = method_2(displayRectangle, tabAlignment, bool_3: false);
			try
			{
				Pen val2 = new Pen(colors.BorderColor);
				try
				{
					g.DrawPath(val2, val);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		switch (tabAlignment)
		{
		case eTabStripAlignment.Top:
			displayRectangle.Offset(1, 1);
			displayRectangle.Width--;
			break;
		case eTabStripAlignment.Bottom:
			displayRectangle.Offset(1, -1);
			displayRectangle.Width--;
			break;
		case eTabStripAlignment.Left:
			displayRectangle.Offset(1, 1);
			displayRectangle.Height--;
			break;
		case eTabStripAlignment.Right:
			displayRectangle.Offset(-1, 1);
			displayRectangle.Height--;
			break;
		}
		if (!colors.LightBorderColor.IsEmpty)
		{
			GraphicsPath val3 = method_2(displayRectangle, tabAlignment, bool_3: false);
			try
			{
				clip2 = Rectangle.Ceiling(path.GetBounds());
				g.SetClip(clip2);
				Pen val4 = new Pen(colors.LightBorderColor);
				try
				{
					g.DrawPath(val4, val3);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		g.set_Clip(clip);
	}

	protected override void DrawBackground(TabStrip tabStrip, Rectangle tabStripRect, Graphics g, TabColorScheme colors, Region tabsRegion, eTabStripAlignment tabAlignment, Rectangle selectedTabRect)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		base.DrawBackground(tabStrip, tabStripRect, g, colors, tabsRegion, tabAlignment, selectedTabRect);
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Pen val = new Pen(colors.TabItemBorder, 1f);
		try
		{
			int num = 9;
			if (selectedTabRect.IsEmpty)
			{
				num = 0;
			}
			Color color_ = colors.TabItemSelectedBackground2;
			if (tabStrip.SelectedTab != null)
			{
				TabColors tabColors = tabStrip.method_44(tabStrip.SelectedTab);
				color_ = tabColors.BackColor2;
			}
			switch (tabAlignment)
			{
			case eTabStripAlignment.Top:
			{
				if (selectedTabRect.X > tabStripRect.Right || selectedTabRect.Bottom < tabStripRect.Bottom - 4)
				{
					selectedTabRect = Rectangle.Empty;
					num = 0;
				}
				Rectangle rectangle_3 = new Rectangle(tabStripRect.X, tabStripRect.Bottom - 1, tabStripRect.Width, 1);
				Class50.smethod_24(g, rectangle_3, color_, Color.Empty);
				g.DrawLine(val, rectangle_3.X, rectangle_3.Y, selectedTabRect.X, rectangle_3.Y);
				g.DrawLine(val, selectedTabRect.Right + num, rectangle_3.Y, rectangle_3.Right, rectangle_3.Y);
				g.DrawLine(val, rectangle_3.X, rectangle_3.Y, rectangle_3.X, rectangle_3.Bottom);
				g.DrawLine(val, rectangle_3.Right - 1, rectangle_3.Y, rectangle_3.Right - 1, rectangle_3.Bottom);
				break;
			}
			case eTabStripAlignment.Bottom:
			{
				if (selectedTabRect.X > tabStripRect.Right || selectedTabRect.Y > 4)
				{
					selectedTabRect = Rectangle.Empty;
					num = 0;
				}
				Rectangle rectangle_2 = new Rectangle(tabStripRect.X, tabStripRect.Y, tabStripRect.Width, 1);
				Class50.smethod_24(g, rectangle_2, color_, Color.Empty);
				g.DrawLine(val, rectangle_2.X, rectangle_2.Bottom - 1, selectedTabRect.X, rectangle_2.Bottom - 1);
				g.DrawLine(val, selectedTabRect.Right + num, rectangle_2.Bottom - 1, rectangle_2.Right, rectangle_2.Bottom - 1);
				g.DrawLine(val, rectangle_2.X, rectangle_2.Y, rectangle_2.X, rectangle_2.Bottom - 1);
				g.DrawLine(val, rectangle_2.Right - 1, rectangle_2.Y, rectangle_2.Right - 1, rectangle_2.Bottom - 1);
				break;
			}
			case eTabStripAlignment.Left:
			{
				if (selectedTabRect.Y > tabStripRect.Bottom || selectedTabRect.Right < tabStripRect.Right - 4)
				{
					selectedTabRect = Rectangle.Empty;
					num = 0;
				}
				Rectangle rectangle_4 = new Rectangle(tabStripRect.Right - 1, tabStripRect.Y, 1, tabStripRect.Height);
				Class50.smethod_24(g, rectangle_4, color_, Color.Empty);
				g.DrawLine(val, rectangle_4.X, rectangle_4.Y, rectangle_4.X, selectedTabRect.Y);
				g.DrawLine(val, rectangle_4.X, selectedTabRect.Bottom + num, rectangle_4.X, rectangle_4.Bottom);
				g.DrawLine(val, rectangle_4.X, rectangle_4.Y, rectangle_4.Right, rectangle_4.Y);
				g.DrawLine(val, rectangle_4.X, rectangle_4.Bottom - 1, rectangle_4.Right, rectangle_4.Bottom - 1);
				break;
			}
			case eTabStripAlignment.Right:
			{
				if (selectedTabRect.Y > tabStripRect.Bottom || selectedTabRect.X > 4)
				{
					selectedTabRect = Rectangle.Empty;
					num = 0;
				}
				Rectangle rectangle_ = new Rectangle(tabStripRect.X, tabStripRect.Y, 1, tabStripRect.Height);
				Class50.smethod_24(g, rectangle_, color_, Color.Empty);
				g.DrawLine(val, rectangle_.Right - 1, rectangle_.Y, rectangle_.Right - 1, selectedTabRect.Y);
				g.DrawLine(val, rectangle_.Right - 1, selectedTabRect.Bottom + num, rectangle_.Right - 1, rectangle_.Bottom);
				g.DrawLine(val, rectangle_.X, rectangle_.Y, rectangle_.Right, rectangle_.Y);
				g.DrawLine(val, rectangle_.X, rectangle_.Bottom - 1, rectangle_.Right, rectangle_.Bottom - 1);
				break;
			}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		g.set_SmoothingMode(smoothingMode);
	}

	protected override void AdjustTextRectangle(ref Rectangle rText, eTabStripAlignment tabAlignment)
	{
		if (tabAlignment == eTabStripAlignment.Top || tabAlignment == eTabStripAlignment.Bottom)
		{
			rText.Width -= 3;
		}
		base.AdjustTextRectangle(ref rText, tabAlignment);
	}

	protected override void AdjustCloseButtonRectangle(ref Rectangle close, bool closeOnLeftSide, bool vertical)
	{
		if (!closeOnLeftSide)
		{
			if (!vertical)
			{
				close.X -= base.Int32_0 + close.Y / 5;
			}
			else
			{
				close.Y -= base.Int32_0 + close.X / 5;
			}
		}
	}
}
