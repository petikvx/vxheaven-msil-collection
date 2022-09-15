using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class39 : Class36
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
			if (colorScheme.TabBackground2.IsEmpty)
			{
				if (!colorScheme.TabBackground.IsEmpty)
				{
					SolidBrush val = new SolidBrush(colorScheme.TabBackground);
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
				LinearGradientBrush val3 = CreateTabGradientBrush(displayRectangle, colorScheme.TabBackground, colorScheme.TabBackground2, colorScheme.TabBackgroundGradientAngle);
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
		for (int num = tabStrip.Tabs.Count - 1; num >= 0; num--)
		{
			TabItem tabItem = tabStrip.Tabs[num];
			if (tabItem.Visible && tabItem != tabStrip.SelectedTab)
			{
				if (!tabItem.DisplayRectangle.IntersectsWith(systemBoxRectangle))
				{
					if (tabItem.DisplayRectangle.IntersectsWith(displayRectangle))
					{
						PaintTab(g, tabItem, first: false, last: false);
					}
				}
				else
				{
					Region clip = g.get_Clip();
					g.SetClip(systemBoxRectangle, (CombineMode)4);
					PaintTab(g, tabItem, first: false, last: false);
					g.set_Clip(clip);
				}
			}
		}
		if (tabStrip.SelectedTab != null && tabStrip.Tabs.Contains(tabStrip.SelectedTab))
		{
			if (!tabStrip.SelectedTab.DisplayRectangle.IntersectsWith(systemBoxRectangle))
			{
				PaintTab(g, tabStrip.SelectedTab, first: false, last: false);
			}
			else
			{
				Region clip2 = g.get_Clip();
				g.SetClip(systemBoxRectangle, (CombineMode)4);
				PaintTab(g, tabStrip.SelectedTab, first: false, last: false);
				g.set_Clip(clip2);
			}
		}
		g.ResetClip();
		tabStrip.method_1(g);
	}

	protected override GraphicsPath GetTabItemPath(TabItem tab, bool bFirst, bool bLast)
	{
		return method_1(tab.DisplayRectangle, tab.TabAlignment, bool_3: true);
	}

	private GraphicsPath method_1(Rectangle rectangle_0, eTabStripAlignment eTabStripAlignment_0, bool bool_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		switch (eTabStripAlignment_0)
		{
		case eTabStripAlignment.Left:
			rectangle_0.X--;
			rectangle_0.Height--;
			if (bool_3)
			{
				rectangle_0.Width--;
			}
			val.AddLine(rectangle_0.Right, rectangle_0.Y, rectangle_0.X + int_1, rectangle_0.Y);
			val.AddLine(rectangle_0.X + int_1, rectangle_0.Y, rectangle_0.X, rectangle_0.Y + int_1);
			val.AddLine(rectangle_0.X, rectangle_0.Y + int_1, rectangle_0.X, rectangle_0.Bottom - int_1);
			val.AddLine(rectangle_0.X, rectangle_0.Bottom - int_1, rectangle_0.X + int_1, rectangle_0.Bottom);
			val.AddLine(rectangle_0.X + int_1, rectangle_0.Bottom, rectangle_0.Right, rectangle_0.Bottom);
			break;
		case eTabStripAlignment.Right:
			rectangle_0.X++;
			if (bool_3)
			{
				rectangle_0.Width--;
			}
			val.AddLine(rectangle_0.X, rectangle_0.Y, rectangle_0.Right - int_1, rectangle_0.Y);
			val.AddLine(rectangle_0.Right - int_1, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y + int_1);
			val.AddLine(rectangle_0.Right, rectangle_0.Y + int_1, rectangle_0.Right, rectangle_0.Bottom - int_1);
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom - int_1, rectangle_0.Right - int_1, rectangle_0.Bottom);
			val.AddLine(rectangle_0.Right - int_1, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Bottom);
			break;
		case eTabStripAlignment.Top:
			if (bool_3)
			{
				rectangle_0.Height++;
			}
			val.AddLine(rectangle_0.X, rectangle_0.Bottom, rectangle_0.X, rectangle_0.Y + int_1);
			val.AddLine(rectangle_0.X, rectangle_0.Y + int_1, rectangle_0.X + int_1, rectangle_0.Y);
			val.AddLine(rectangle_0.X + int_1, rectangle_0.Y, rectangle_0.Right - int_1, rectangle_0.Y);
			val.AddLine(rectangle_0.Right - int_1, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y + int_1);
			val.AddLine(rectangle_0.Right, rectangle_0.Y + int_1, rectangle_0.Right, rectangle_0.Bottom);
			break;
		case eTabStripAlignment.Bottom:
			rectangle_0.Y++;
			rectangle_0.Height--;
			val.AddLine(rectangle_0.X, rectangle_0.Y, rectangle_0.X, rectangle_0.Bottom - int_1);
			val.AddLine(rectangle_0.X, rectangle_0.Bottom - int_1, rectangle_0.X + int_1, rectangle_0.Bottom);
			val.AddLine(rectangle_0.X + int_1, rectangle_0.Bottom, rectangle_0.Right - int_1, rectangle_0.Bottom);
			val.AddLine(rectangle_0.Right - int_1, rectangle_0.Bottom, rectangle_0.Right, rectangle_0.Bottom - int_1);
			val.AddLine(rectangle_0.Right, rectangle_0.Bottom - int_1, rectangle_0.Right, rectangle_0.Y);
			break;
		}
		if (bool_3)
		{
			val.CloseAllFigures();
		}
		return val;
	}

	protected override void DrawTabBorder(TabItem tab, GraphicsPath path, TabColors colors, Graphics g)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		Rectangle displayRectangle = tab.DisplayRectangle;
		eTabStripAlignment tabAlignment = tab.TabAlignment;
		if (!colors.BorderColor.IsEmpty)
		{
			GraphicsPath val = method_1(displayRectangle, tabAlignment, bool_3: false);
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
			displayRectangle.Width -= 2;
			displayRectangle.Height--;
			break;
		case eTabStripAlignment.Bottom:
			displayRectangle.Offset(1, 0);
			displayRectangle.Height--;
			displayRectangle.Width -= 2;
			break;
		case eTabStripAlignment.Left:
			displayRectangle.Offset(1, 1);
			displayRectangle.Height -= 2;
			displayRectangle.Width -= 2;
			break;
		case eTabStripAlignment.Right:
			displayRectangle.Offset(1, 1);
			displayRectangle.Height -= 2;
			displayRectangle.Width -= 2;
			break;
		}
		if (colors.LightBorderColor.IsEmpty)
		{
			return;
		}
		GraphicsPath val3 = method_1(displayRectangle, tabAlignment, bool_3: false);
		try
		{
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

	protected override void DrawBackground(TabStrip tabStrip, Rectangle tabStripRect, Graphics g, TabColorScheme colors, Region tabsRegion, eTabStripAlignment tabAlignment, Rectangle selectedTabRect)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		base.DrawBackground(tabStrip, tabStripRect, g, colors, tabsRegion, tabAlignment, selectedTabRect);
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Pen val = new Pen(colors.TabItemBorder, 1f);
		try
		{
			switch (tabAlignment)
			{
			case eTabStripAlignment.Top:
			{
				if (selectedTabRect.X > tabStripRect.Right)
				{
					selectedTabRect = Rectangle.Empty;
				}
				Rectangle rectangle_3 = new Rectangle(tabStripRect.X, tabStripRect.Bottom - 1, tabStripRect.Width, 2);
				Class50.smethod_24(g, rectangle_3, colors.TabItemBackground, Color.Empty);
				g.DrawLine(val, rectangle_3.X, rectangle_3.Y, selectedTabRect.X - 1, rectangle_3.Y);
				g.DrawLine(val, selectedTabRect.Right, rectangle_3.Y, rectangle_3.Right, rectangle_3.Y);
				g.DrawLine(val, rectangle_3.X, rectangle_3.Y, rectangle_3.X, rectangle_3.Bottom);
				g.DrawLine(val, rectangle_3.Right - 1, rectangle_3.Y, rectangle_3.Right - 1, rectangle_3.Bottom);
				break;
			}
			case eTabStripAlignment.Bottom:
			{
				if (selectedTabRect.X > tabStripRect.Right)
				{
					selectedTabRect = Rectangle.Empty;
				}
				Rectangle rectangle_2 = new Rectangle(tabStripRect.X, tabStripRect.Y, tabStripRect.Width, 1);
				Class50.smethod_24(g, rectangle_2, colors.TabItemBackground, Color.Empty);
				g.DrawLine(val, rectangle_2.X, rectangle_2.Bottom - 1, selectedTabRect.X - 1, rectangle_2.Bottom - 1);
				g.DrawLine(val, selectedTabRect.Right, rectangle_2.Bottom - 1, rectangle_2.Right, rectangle_2.Bottom - 1);
				g.DrawLine(val, rectangle_2.X, rectangle_2.Y, rectangle_2.X, rectangle_2.Bottom - 1);
				g.DrawLine(val, rectangle_2.Right - 1, rectangle_2.Y, rectangle_2.Right - 1, rectangle_2.Bottom - 1);
				break;
			}
			case eTabStripAlignment.Left:
			{
				if (selectedTabRect.Y > tabStripRect.Bottom)
				{
					selectedTabRect = Rectangle.Empty;
				}
				Rectangle rectangle_4 = new Rectangle(tabStripRect.Right - 1, tabStripRect.Y, 1, tabStripRect.Height);
				Class50.smethod_24(g, rectangle_4, colors.TabItemBackground, Color.Empty);
				g.DrawLine(val, rectangle_4.X, rectangle_4.Y, rectangle_4.X, selectedTabRect.Y - 1);
				g.DrawLine(val, rectangle_4.X, selectedTabRect.Bottom, rectangle_4.X, rectangle_4.Bottom);
				g.DrawLine(val, rectangle_4.X, rectangle_4.Y, rectangle_4.Right, rectangle_4.Y);
				g.DrawLine(val, rectangle_4.X, rectangle_4.Bottom - 1, rectangle_4.Right, rectangle_4.Bottom - 1);
				break;
			}
			case eTabStripAlignment.Right:
			{
				if (selectedTabRect.Y > tabStripRect.Bottom)
				{
					selectedTabRect = Rectangle.Empty;
				}
				Rectangle rectangle_ = new Rectangle(tabStripRect.X, tabStripRect.Y, 1, tabStripRect.Height);
				Class50.smethod_24(g, rectangle_, colors.TabItemBackground, Color.Empty);
				g.DrawLine(val, rectangle_.Right - 1, rectangle_.Y, rectangle_.Right - 1, selectedTabRect.Y - 1);
				g.DrawLine(val, rectangle_.Right - 1, selectedTabRect.Bottom, rectangle_.Right - 1, rectangle_.Bottom);
				g.DrawLine(val, rectangle_.X, rectangle_.Y, rectangle_.Right - 1, rectangle_.Y);
				g.DrawLine(val, rectangle_.X, rectangle_.Bottom - 1, rectangle_.Right - 1, rectangle_.Bottom - 1);
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
}
