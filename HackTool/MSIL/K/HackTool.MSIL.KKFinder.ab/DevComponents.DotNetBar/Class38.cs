using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class38 : Class36
{
	public override void Paint(Graphics g, TabStrip tabStrip)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		base.Paint(g, tabStrip);
		TabsCollection tabs = tabStrip.Tabs;
		TabColorScheme colorScheme = tabStrip.ColorScheme;
		Rectangle clientRectangle = ((Control)tabStrip).get_ClientRectangle();
		Rectangle displayRectangle = ((Control)tabStrip).get_DisplayRectangle();
		displayRectangle.Inflate(2, 2);
		SolidBrush val = new SolidBrush(((Control)tabStrip).get_BackColor());
		try
		{
			g.FillRectangle((Brush)(object)val, displayRectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		TabItem lastVisibleTab = GetLastVisibleTab(tabs);
		Rectangle selectedTabRect = Rectangle.Empty;
		if (tabStrip.SelectedTab != null)
		{
			selectedTabRect = tabStrip.SelectedTab.DisplayRectangle;
		}
		DrawBackground(tabStrip, clientRectangle, g, colorScheme, GetTabsRegion(tabs, lastVisibleTab), tabStrip.TabAlignment, selectedTabRect);
		bool first = true;
		foreach (TabItem item in tabs)
		{
			if (item.Visible)
			{
				if (item.DisplayRectangle.IntersectsWith(clientRectangle))
				{
					PaintTab(g, item, first, item == lastVisibleTab);
				}
				first = false;
			}
		}
	}

	protected override Region GetTabsRegion(TabsCollection tabs, TabItem lastTab)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		bool bFirst = true;
		Region val = new Region();
		val.MakeEmpty();
		foreach (TabItem tab in tabs)
		{
			if (tab.Visible)
			{
				GraphicsPath tabItemPath = GetTabItemPath(tab, bFirst, tab == lastTab);
				val.Union(tabItemPath);
				bFirst = false;
			}
		}
		return val;
	}

	protected override LinearGradientBrush CreateTabGradientBrush(Rectangle r, Color color1, Color color2, int gradientAngle)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		LinearGradientBrush val = base.CreateTabGradientBrush(r, color1, color2, gradientAngle);
		Blend val2 = new Blend(5);
		val2.set_Factors(new float[5] { 0f, 0.6f, 1f, 0.6f, 0f });
		val2.set_Positions(new float[5] { 0f, 0.3f, 0.5f, 0.7f, 1f });
		val.set_Blend(val2);
		return val;
	}

	protected override void DrawBackground(TabStrip tabStrip, Rectangle tabStripRect, Graphics g, TabColorScheme colors, Region tabsRegion, eTabStripAlignment tabAlignment, Rectangle selectedTabRect)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		int num = 5;
		GraphicsPath val = new GraphicsPath();
		switch (tabAlignment)
		{
		case eTabStripAlignment.Top:
		{
			Rectangle bounds = new Rectangle(tabStripRect.X, tabStripRect.Y + tabStripRect.Height / 2, tabStripRect.Width - 1, tabStripRect.Height - tabStripRect.Height / 2);
			val.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Top + num);
			Struct10 cornerArc4 = GetCornerArc(bounds, num, Enum14.const_0);
			val.AddArc(cornerArc4.int_0, cornerArc4.int_1, cornerArc4.int_2, cornerArc4.int_3, cornerArc4.float_0, cornerArc4.float_1);
			val.AddLine(bounds.X + num, bounds.Y, bounds.Right - num, bounds.Y);
			cornerArc4 = GetCornerArc(bounds, num, Enum14.const_1);
			val.AddArc(cornerArc4.int_0, cornerArc4.int_1, cornerArc4.int_2, cornerArc4.int_3, cornerArc4.float_0, cornerArc4.float_1);
			val.AddLine(bounds.Right, bounds.Y + num, bounds.Right, bounds.Bottom);
			break;
		}
		case eTabStripAlignment.Bottom:
		{
			Rectangle bounds = new Rectangle(tabStripRect.X, tabStripRect.Y, tabStripRect.Width - 1, tabStripRect.Height / 2);
			val.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Bottom - num);
			Struct10 cornerArc3 = GetCornerArc(bounds, num, Enum14.const_3);
			val.AddArc(cornerArc3.int_0, cornerArc3.int_1, cornerArc3.int_2, cornerArc3.int_3, cornerArc3.float_0, cornerArc3.float_1);
			val.AddLine(bounds.Right - num, bounds.Bottom, bounds.X + num, bounds.Bottom);
			cornerArc3 = GetCornerArc(bounds, num, Enum14.const_2);
			val.AddArc(cornerArc3.int_0, cornerArc3.int_1, cornerArc3.int_2, cornerArc3.int_3, cornerArc3.float_0, cornerArc3.float_1);
			val.AddLine(bounds.X, bounds.Bottom - num, bounds.X, bounds.Y);
			break;
		}
		case eTabStripAlignment.Left:
		{
			Rectangle bounds = new Rectangle(tabStripRect.X + tabStripRect.Width / 2, tabStripRect.Y, tabStripRect.Width / 2 + 1, tabStripRect.Height - 1);
			val.AddLine(bounds.Right, bounds.Bottom, bounds.X + num, bounds.Bottom);
			Struct10 cornerArc2 = GetCornerArc(bounds, num, Enum14.const_2);
			val.AddArc(cornerArc2.int_0, cornerArc2.int_1, cornerArc2.int_2, cornerArc2.int_3, cornerArc2.float_0, cornerArc2.float_1);
			val.AddLine(bounds.X, bounds.Bottom - num, bounds.X, bounds.Y + num);
			cornerArc2 = GetCornerArc(bounds, num, Enum14.const_0);
			val.AddArc(cornerArc2.int_0, cornerArc2.int_1, cornerArc2.int_2, cornerArc2.int_3, cornerArc2.float_0, cornerArc2.float_1);
			val.AddLine(bounds.X + num, bounds.Y, bounds.Right, bounds.Y);
			break;
		}
		case eTabStripAlignment.Right:
		{
			Rectangle bounds = new Rectangle(tabStripRect.X, tabStripRect.Y, tabStripRect.Width / 2, tabStripRect.Height - 1);
			val.AddLine(bounds.X, bounds.Y, bounds.Right - num, bounds.Y);
			Struct10 cornerArc = GetCornerArc(bounds, num, Enum14.const_1);
			val.AddArc(cornerArc.int_0, cornerArc.int_1, cornerArc.int_2, cornerArc.int_3, cornerArc.float_0, cornerArc.float_1);
			val.AddLine(bounds.Right, bounds.Y + num, bounds.Right, bounds.Bottom - num);
			cornerArc = GetCornerArc(bounds, num, Enum14.const_3);
			val.AddArc(cornerArc.int_0, cornerArc.int_1, cornerArc.int_2, cornerArc.int_3, cornerArc.float_0, cornerArc.float_1);
			val.AddLine(bounds.Right - num, bounds.Bottom, bounds.X, bounds.Bottom);
			break;
		}
		}
		object obj = val.Clone();
		GraphicsPath val2 = (GraphicsPath)((obj is GraphicsPath) ? obj : null);
		val2.CloseAllFigures();
		g.SetClip(val2, (CombineMode)0);
		g.SetClip(tabsRegion, (CombineMode)4);
		g.Clear(colors.TabPanelBackground);
		g.ResetClip();
		val2.Dispose();
		g.SetClip(tabsRegion, (CombineMode)4);
		Pen val3 = new Pen(colors.TabBorder, 1f);
		try
		{
			g.DrawPath(val3, val);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		val.Dispose();
		g.ResetClip();
	}

	protected override GraphicsPath GetTabItemPath(TabItem tab, bool bFirst, bool bLast)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int num = 3;
		Rectangle displayRectangle = tab.DisplayRectangle;
		if (!bFirst && !bLast)
		{
			val.AddRectangle(displayRectangle);
		}
		else
		{
			if (bFirst)
			{
				if (tab.Parent.TabAlignment != eTabStripAlignment.Top && tab.Parent.TabAlignment != eTabStripAlignment.Bottom)
				{
					Struct10 cornerArc = GetCornerArc(displayRectangle, num, Enum14.const_0);
					val.AddArc(cornerArc.int_0, cornerArc.int_1, cornerArc.int_2, cornerArc.int_3, cornerArc.float_0, cornerArc.float_1);
					val.AddLine(displayRectangle.X + num, displayRectangle.Y, displayRectangle.Right - num, displayRectangle.Y);
					cornerArc = GetCornerArc(displayRectangle, num, Enum14.const_1);
					val.AddArc(cornerArc.int_0, cornerArc.int_1, cornerArc.int_2, cornerArc.int_3, cornerArc.float_0, cornerArc.float_1);
					val.AddLine(displayRectangle.Right, displayRectangle.Y + num, displayRectangle.Right, displayRectangle.Bottom - (bLast ? num : 0));
				}
				else
				{
					val.AddLine(displayRectangle.Right - (bLast ? num : 0), displayRectangle.Bottom, displayRectangle.X + num, displayRectangle.Bottom);
					Struct10 cornerArc2 = GetCornerArc(displayRectangle, num, Enum14.const_2);
					val.AddArc(cornerArc2.int_0, cornerArc2.int_1, cornerArc2.int_2, cornerArc2.int_3, cornerArc2.float_0, cornerArc2.float_1);
					val.AddLine(displayRectangle.X, displayRectangle.Bottom - num, displayRectangle.X, displayRectangle.Y + num);
					cornerArc2 = GetCornerArc(displayRectangle, num, Enum14.const_0);
					val.AddArc(cornerArc2.int_0, cornerArc2.int_1, cornerArc2.int_2, cornerArc2.int_3, cornerArc2.float_0, cornerArc2.float_1);
					val.AddLine(displayRectangle.X + num, displayRectangle.Y, displayRectangle.Right - (bLast ? num : 0), displayRectangle.Y);
				}
			}
			else
			{
				val.AddLine(displayRectangle.X, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y);
			}
			if (bLast)
			{
				if (tab.Parent.TabAlignment != eTabStripAlignment.Top && tab.Parent.TabAlignment != eTabStripAlignment.Bottom)
				{
					if (!bFirst)
					{
						val.AddLine(displayRectangle.Right, displayRectangle.Y, displayRectangle.Right, displayRectangle.Bottom - num);
					}
					Struct10 cornerArc3 = GetCornerArc(displayRectangle, num, Enum14.const_3);
					val.AddArc(cornerArc3.int_0, cornerArc3.int_1, cornerArc3.int_2, cornerArc3.int_3, cornerArc3.float_0, cornerArc3.float_1);
					val.AddLine(displayRectangle.Right - num, displayRectangle.Bottom, displayRectangle.X + num, displayRectangle.Bottom);
					cornerArc3 = GetCornerArc(displayRectangle, num, Enum14.const_2);
					val.AddArc(cornerArc3.int_0, cornerArc3.int_1, cornerArc3.int_2, cornerArc3.int_3, cornerArc3.float_0, cornerArc3.float_1);
					if (!bFirst)
					{
						val.AddLine(displayRectangle.X, displayRectangle.Bottom - num, displayRectangle.X, displayRectangle.Y);
					}
				}
				else
				{
					if (!bFirst)
					{
						val.AddLine(displayRectangle.X, displayRectangle.Y, displayRectangle.Right - num, displayRectangle.Y);
					}
					Struct10 cornerArc4 = GetCornerArc(displayRectangle, num, Enum14.const_1);
					val.AddArc(cornerArc4.int_0, cornerArc4.int_1, cornerArc4.int_2, cornerArc4.int_3, cornerArc4.float_0, cornerArc4.float_1);
					val.AddLine(displayRectangle.Right, displayRectangle.Y + num, displayRectangle.Right, displayRectangle.Bottom - num);
					cornerArc4 = GetCornerArc(displayRectangle, num, Enum14.const_3);
					val.AddArc(cornerArc4.int_0, cornerArc4.int_1, cornerArc4.int_2, cornerArc4.int_3, cornerArc4.float_0, cornerArc4.float_1);
					if (!bFirst)
					{
						val.AddLine(displayRectangle.Right - num, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom);
					}
				}
			}
			else
			{
				val.AddLine(displayRectangle.Right, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom);
			}
			val.CloseAllFigures();
		}
		return val;
	}
}
