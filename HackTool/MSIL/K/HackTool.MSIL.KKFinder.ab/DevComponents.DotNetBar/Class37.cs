using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class37 : Class36
{
	public Class37()
	{
		base.Boolean_0 = true;
	}

	public override void Paint(Graphics g, TabStrip tabStrip)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		base.Paint(g, tabStrip);
		TabColorScheme colorScheme = tabStrip.ColorScheme;
		Rectangle clientRectangle = ((Control)tabStrip).get_ClientRectangle();
		if (((Control)tabStrip).get_BackColor() != Color.Transparent || colorScheme.TabBackground != Color.Transparent)
		{
			if (colorScheme.TabPanelBackground2.IsEmpty)
			{
				if (!colorScheme.TabPanelBackground.IsEmpty)
				{
					SolidBrush val = new SolidBrush(colorScheme.TabPanelBackground);
					try
					{
						g.FillRectangle((Brush)(object)val, clientRectangle);
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
					g.FillRectangle((Brush)(object)val2, clientRectangle);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				LinearGradientBrush val3 = CreateTabGradientBrush(clientRectangle, colorScheme.TabPanelBackground, colorScheme.TabPanelBackground2, colorScheme.TabPanelBackgroundGradientAngle);
				try
				{
					g.FillRectangle((Brush)(object)val3, clientRectangle);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
		}
		tabStrip.method_5(g);
		method_2(clientRectangle, g, colorScheme, new Region(((Control)tabStrip).get_DisplayRectangle()), tabStrip.TabAlignment, tabStrip.Rectangle_0);
		for (int num = tabStrip.Tabs.Count - 1; num >= 0; num--)
		{
			TabItem tabItem = tabStrip.Tabs[num];
			if (tabItem.Visible && !tabItem.IsSelected && tabItem.DisplayRectangle.IntersectsWith(clientRectangle))
			{
				PaintTab(g, tabItem, first: false, last: false);
			}
		}
		if (tabStrip.SelectedTab != null && tabStrip.Tabs.Contains(tabStrip.SelectedTab))
		{
			PaintTab(g, tabStrip.SelectedTab, first: false, last: false);
		}
		g.ResetClip();
		tabStrip.method_1(g);
	}

	protected override GraphicsPath GetTabItemPath(TabItem tab, bool bFirst, bool bLast)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		Rectangle displayRectangle = tab.DisplayRectangle;
		GraphicsPath val = new GraphicsPath();
		if (!tab.IsSelected && !tab.IsMouseOver)
		{
			if (tab.TabAlignment == eTabStripAlignment.Bottom)
			{
				displayRectangle.Height--;
			}
			else if (tab.TabAlignment == eTabStripAlignment.Top)
			{
				displayRectangle.Height--;
				displayRectangle.Y++;
			}
			else if (tab.TabAlignment == eTabStripAlignment.Left)
			{
				displayRectangle.Width--;
				displayRectangle.X++;
			}
			else if (tab.TabAlignment == eTabStripAlignment.Right)
			{
				displayRectangle.Width--;
			}
			val.AddRectangle(displayRectangle);
		}
		else
		{
			if (tab.TabAlignment == eTabStripAlignment.Bottom)
			{
				val.AddLine(displayRectangle.X + 2, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom - 2);
				val.AddLine(displayRectangle.X, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y);
				val.AddLine(displayRectangle.Right, displayRectangle.Bottom - 2, displayRectangle.Right - 2, displayRectangle.Bottom);
				val.AddLine(displayRectangle.Right - 2, displayRectangle.Bottom, displayRectangle.X + 2, displayRectangle.Bottom);
			}
			else if (tab.TabAlignment == eTabStripAlignment.Top)
			{
				val.AddLine(displayRectangle.X, displayRectangle.Y + 2, displayRectangle.X + 2, displayRectangle.Y);
				val.AddLine(displayRectangle.Right - 2, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y + 2);
				val.AddLine(displayRectangle.Right, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom);
			}
			else if (tab.TabAlignment == eTabStripAlignment.Left)
			{
				val.AddLine(displayRectangle.Right, displayRectangle.Bottom, displayRectangle.X + 2, displayRectangle.Bottom);
				val.AddLine(displayRectangle.X + 2, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom - 2);
				val.AddLine(displayRectangle.X, displayRectangle.Bottom - 2, displayRectangle.X, displayRectangle.Y + 2);
				val.AddLine(displayRectangle.X, displayRectangle.Y + 2, displayRectangle.X + 2, displayRectangle.Y);
				val.AddLine(displayRectangle.Right - 1, displayRectangle.Y, displayRectangle.Right - 1, displayRectangle.Bottom);
			}
			else if (tab.TabAlignment == eTabStripAlignment.Right)
			{
				val.AddLine(displayRectangle.X, displayRectangle.Y, displayRectangle.Right - 2, displayRectangle.Y);
				val.AddLine(displayRectangle.Right - 2, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y + 2);
				val.AddLine(displayRectangle.Right, displayRectangle.Y + 2, displayRectangle.Right, displayRectangle.Bottom - 2);
				val.AddLine(displayRectangle.Right, displayRectangle.Bottom - 2, displayRectangle.Right - 2, displayRectangle.Bottom);
				val.AddLine(displayRectangle.X, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Y);
			}
			val.CloseAllFigures();
		}
		return val;
	}

	private GraphicsPath method_1(TabItem tabItem_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Rectangle displayRectangle = tabItem_0.DisplayRectangle;
		if (tabItem_0.TabAlignment == eTabStripAlignment.Bottom)
		{
			displayRectangle.Height++;
			val.AddLine(displayRectangle.Right, displayRectangle.Bottom - 2, displayRectangle.Right - 2, displayRectangle.Bottom);
			val.AddLine(displayRectangle.Right - 2, displayRectangle.Bottom, displayRectangle.X + 2, displayRectangle.Bottom);
			val.AddLine(displayRectangle.X + 2, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom - 2);
		}
		else if (tabItem_0.TabAlignment == eTabStripAlignment.Top)
		{
			displayRectangle.Height++;
			displayRectangle.Y--;
			val.AddLine(displayRectangle.X, displayRectangle.Y + 2, displayRectangle.X + 2, displayRectangle.Y);
			val.AddLine(displayRectangle.X + 2, displayRectangle.Y, displayRectangle.Right - 2, displayRectangle.Y);
			val.AddLine(displayRectangle.Right - 2, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y + 2);
		}
		else if (tabItem_0.TabAlignment == eTabStripAlignment.Left)
		{
			displayRectangle.Width++;
			displayRectangle.X--;
			val.AddLine(displayRectangle.X + 2, displayRectangle.Bottom, displayRectangle.X, displayRectangle.Bottom - 2);
			val.AddLine(displayRectangle.X, displayRectangle.Bottom - 2, displayRectangle.X, displayRectangle.Y + 2);
			val.AddLine(displayRectangle.X, displayRectangle.Y + 2, displayRectangle.X + 2, displayRectangle.Y);
		}
		else if (tabItem_0.TabAlignment == eTabStripAlignment.Right)
		{
			displayRectangle.Width++;
			val.AddLine(displayRectangle.Right - 2, displayRectangle.Y, displayRectangle.Right, displayRectangle.Y + 2);
			val.AddLine(displayRectangle.Right, displayRectangle.Y + 2, displayRectangle.Right, displayRectangle.Bottom - 2);
			val.AddLine(displayRectangle.Right, displayRectangle.Bottom - 2, displayRectangle.Right - 2, displayRectangle.Bottom);
		}
		return val;
	}

	private void method_2(Rectangle rectangle_0, Graphics graphics_0, TabColorScheme tabColorScheme_0, Region region_0, eTabStripAlignment eTabStripAlignment_0, Rectangle rectangle_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		int num = 3;
		GraphicsPath val = new GraphicsPath();
		GraphicsPath val2 = null;
		if (!rectangle_1.IsEmpty)
		{
			Rectangle bounds;
			switch (eTabStripAlignment_0)
			{
			case eTabStripAlignment.Top:
			{
				rectangle_1.Width += 3;
				bounds = new Rectangle(rectangle_0.X, rectangle_1.Y + 1, (rectangle_1.Right > rectangle_0.Right) ? rectangle_0.Width : rectangle_1.Right, rectangle_1.Height - 1);
				val.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Top + num);
				Struct10 cornerArc3 = GetCornerArc(bounds, num, Enum14.const_0);
				val.AddArc(cornerArc3.int_0, cornerArc3.int_1, cornerArc3.int_2, cornerArc3.int_3, cornerArc3.float_0, cornerArc3.float_1);
				val.AddLine(bounds.X + num, bounds.Y, bounds.Right - num, bounds.Y);
				cornerArc3 = GetCornerArc(bounds, num, Enum14.const_1);
				val.AddArc(cornerArc3.int_0, cornerArc3.int_1, cornerArc3.int_2, cornerArc3.int_3, cornerArc3.float_0, cornerArc3.float_1);
				val.AddLine(bounds.Right, bounds.Y + num, bounds.Right, bounds.Bottom);
				object obj3 = val.Clone();
				val2 = (GraphicsPath)((obj3 is GraphicsPath) ? obj3 : null);
				val2.CloseAllFigures();
				if (rectangle_1.Right < rectangle_0.Right)
				{
					val.AddLine(bounds.Right, bounds.Bottom, rectangle_0.Right, bounds.Bottom);
				}
				break;
			}
			case eTabStripAlignment.Bottom:
			{
				rectangle_1.Width += 3;
				bounds = new Rectangle(rectangle_0.X, rectangle_0.Y, (rectangle_1.Right > rectangle_0.Right) ? rectangle_0.Width : rectangle_1.Right, rectangle_1.Height - 1);
				val.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Bottom - num);
				Struct10 cornerArc4 = GetCornerArc(bounds, num, Enum14.const_3);
				val.AddArc(cornerArc4.int_0, cornerArc4.int_1, cornerArc4.int_2, cornerArc4.int_3, cornerArc4.float_0, cornerArc4.float_1);
				val.AddLine(bounds.Right - num, bounds.Bottom, bounds.X + num, bounds.Bottom);
				cornerArc4 = GetCornerArc(bounds, num, Enum14.const_2);
				val.AddArc(cornerArc4.int_0, cornerArc4.int_1, cornerArc4.int_2, cornerArc4.int_3, cornerArc4.float_0, cornerArc4.float_1);
				val.AddLine(bounds.X, bounds.Bottom - num, bounds.X, bounds.Y);
				object obj4 = val.Clone();
				val2 = (GraphicsPath)((obj4 is GraphicsPath) ? obj4 : null);
				val2.CloseAllFigures();
				if (rectangle_1.Right < rectangle_0.Right)
				{
					val.AddLine(bounds.Right, bounds.Y, rectangle_0.Right, bounds.Y);
				}
				break;
			}
			case eTabStripAlignment.Left:
			{
				rectangle_1.Height += 3;
				bounds = new Rectangle(rectangle_1.X + 1, rectangle_0.Y, rectangle_1.Width - 1, (rectangle_1.Bottom > rectangle_0.Bottom) ? rectangle_0.Height : rectangle_1.Bottom);
				val.AddLine(bounds.Right - 1, bounds.Bottom, bounds.X + num, bounds.Bottom);
				Struct10 cornerArc2 = GetCornerArc(bounds, num, Enum14.const_2);
				val.AddArc(cornerArc2.int_0, cornerArc2.int_1, cornerArc2.int_2, cornerArc2.int_3, cornerArc2.float_0, cornerArc2.float_1);
				val.AddLine(bounds.X, bounds.Bottom - num, bounds.X, bounds.Y + num);
				cornerArc2 = GetCornerArc(bounds, num, Enum14.const_0);
				val.AddArc(cornerArc2.int_0, cornerArc2.int_1, cornerArc2.int_2, cornerArc2.int_3, cornerArc2.float_0, cornerArc2.float_1);
				val.AddLine(bounds.X + num, bounds.Y, bounds.Right - 1, bounds.Y);
				object obj2 = val.Clone();
				val2 = (GraphicsPath)((obj2 is GraphicsPath) ? obj2 : null);
				val2.CloseAllFigures();
				if (rectangle_1.Bottom < rectangle_0.Bottom)
				{
					val.AddLine(bounds.Right - 1, bounds.Bottom, bounds.Right - 1, rectangle_0.Bottom);
				}
				break;
			}
			case eTabStripAlignment.Right:
			{
				rectangle_1.Height += 3;
				bounds = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_1.Width - 1, (rectangle_1.Bottom > rectangle_0.Bottom) ? rectangle_0.Height : rectangle_1.Bottom);
				val.AddLine(bounds.X, bounds.Y, bounds.Right - num, bounds.Y);
				Struct10 cornerArc = GetCornerArc(bounds, num, Enum14.const_1);
				val.AddArc(cornerArc.int_0, cornerArc.int_1, cornerArc.int_2, cornerArc.int_3, cornerArc.float_0, cornerArc.float_1);
				val.AddLine(bounds.Right, bounds.Y + num, bounds.Right, bounds.Bottom - num);
				cornerArc = GetCornerArc(bounds, num, Enum14.const_3);
				val.AddArc(cornerArc.int_0, cornerArc.int_1, cornerArc.int_2, cornerArc.int_3, cornerArc.float_0, cornerArc.float_1);
				val.AddLine(bounds.Right - num, bounds.Bottom, bounds.X, bounds.Bottom);
				object obj = val.Clone();
				val2 = (GraphicsPath)((obj is GraphicsPath) ? obj : null);
				val2.CloseAllFigures();
				if (rectangle_1.Bottom < rectangle_0.Bottom)
				{
					val.AddLine(bounds.X, bounds.Bottom, bounds.X, rectangle_0.Bottom);
				}
				break;
			}
			}
		}
		else
		{
			val.AddRectangle(rectangle_0);
		}
		if (tabColorScheme_0.TabPanelBackground2.IsEmpty)
		{
			if (!tabColorScheme_0.TabPanelBackground.IsEmpty)
			{
				SolidBrush val3 = new SolidBrush(tabColorScheme_0.TabPanelBackground);
				try
				{
					graphics_0.FillPath((Brush)(object)val3, val);
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
				graphics_0.FillPath((Brush)(object)val4, val);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			LinearGradientBrush val5 = CreateTabGradientBrush(rectangle_0, tabColorScheme_0.TabPanelBackground, tabColorScheme_0.TabPanelBackground2, tabColorScheme_0.TabPanelBackgroundGradientAngle);
			try
			{
				graphics_0.FillPath((Brush)(object)val5, val);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		if (!tabColorScheme_0.TabBorder.IsEmpty)
		{
			val.CloseAllFigures();
			Pen val6 = new Pen(tabColorScheme_0.TabBorder, 1f);
			try
			{
				graphics_0.DrawPath(val6, val);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		if (val2 != null)
		{
			val2.Dispose();
		}
		if (val != null)
		{
			val.Dispose();
		}
	}

	protected override void DrawTabItemBackground(TabItem tab, GraphicsPath path, TabColors colors, Graphics g)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		RectangleF bounds = path.GetBounds();
		Rectangle r = new Rectangle((int)bounds.X, (int)bounds.Y, (int)bounds.Width, (int)bounds.Height);
		if (colors.BackColor2.IsEmpty)
		{
			if (!colors.BackColor.IsEmpty)
			{
				SolidBrush val = new SolidBrush(colors.BackColor);
				try
				{
					g.FillPath((Brush)(object)val, path);
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
				g.FillPath((Brush)(object)val2, path);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			LinearGradientBrush val3 = CreateTabGradientBrush(r, colors.BackColor, colors.BackColor2, colors.BackColorGradientAngle);
			try
			{
				g.FillPath((Brush)(object)val3, path);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		Pen val4 = new Pen(colors.BorderColor, 1f);
		try
		{
			if (!colors.BorderColor.IsEmpty && (tab.IsSelected || tab.IsMouseOver))
			{
				g.DrawPath(val4, path);
			}
			else if (tab.TabAlignment != eTabStripAlignment.Top && tab.TabAlignment != eTabStripAlignment.Bottom)
			{
				if (tab.TabAlignment == eTabStripAlignment.Left || tab.TabAlignment == eTabStripAlignment.Right)
				{
					if (!colors.LightBorderColor.IsEmpty)
					{
						Pen val5 = new Pen(colors.LightBorderColor, 1f);
						try
						{
							g.DrawLine(val5, r.X + 4, r.Bottom - 1, r.Right - 4, r.Bottom - 1);
						}
						finally
						{
							((IDisposable)val5)?.Dispose();
						}
					}
					if (!colors.DarkBorderColor.IsEmpty)
					{
						Pen val6 = new Pen(colors.DarkBorderColor, 1f);
						try
						{
							g.DrawLine(val6, r.X + 4, r.Bottom, r.Right - 4, r.Bottom);
						}
						finally
						{
							((IDisposable)val6)?.Dispose();
						}
					}
					g.DrawLine(val4, r.X, r.Y, r.X, r.Bottom);
					if (tab.TabAlignment == eTabStripAlignment.Left)
					{
						g.DrawLine(val4, r.Right - 1, r.Y, r.Right - 1, r.Bottom);
					}
					else
					{
						g.DrawLine(val4, r.Right, r.Y, r.Right, r.Bottom);
					}
				}
			}
			else
			{
				if (!colors.LightBorderColor.IsEmpty)
				{
					Pen val7 = new Pen(colors.LightBorderColor, 1f);
					try
					{
						g.DrawLine(val7, r.Right - 1, r.Y + 4, r.Right - 1, r.Bottom - 4);
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
				}
				if (!colors.DarkBorderColor.IsEmpty)
				{
					Pen val8 = new Pen(colors.DarkBorderColor, 1f);
					try
					{
						g.DrawLine(val8, r.Right, r.Y + 4, r.Right, r.Bottom - 4);
					}
					finally
					{
						((IDisposable)val8)?.Dispose();
					}
				}
				g.DrawLine(val4, r.X, r.Y, r.Right, r.Y);
				g.DrawLine(val4, r.X, r.Bottom, r.Right, r.Bottom);
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
		if (!tab.IsSelected && !tab.IsMouseOver)
		{
			return;
		}
		GraphicsPath val9 = method_1(tab);
		if (!colors.LightBorderColor.IsEmpty)
		{
			object obj = val9.Clone();
			GraphicsPath val10 = (GraphicsPath)((obj is GraphicsPath) ? obj : null);
			val10.CloseAllFigures();
			SolidBrush val11 = new SolidBrush(colors.LightBorderColor);
			try
			{
				g.FillPath((Brush)(object)val11, val10);
			}
			finally
			{
				((IDisposable)val11)?.Dispose();
			}
			val10.Dispose();
		}
		if (!colors.DarkBorderColor.IsEmpty)
		{
			Pen val12 = new Pen(colors.DarkBorderColor, 1f);
			try
			{
				g.DrawPath(val12, val9);
			}
			finally
			{
				((IDisposable)val12)?.Dispose();
			}
		}
		val9.Dispose();
	}
}
