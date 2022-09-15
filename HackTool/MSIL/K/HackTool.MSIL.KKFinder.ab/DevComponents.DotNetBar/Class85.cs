using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class85 : Class84, Interface3
{
	private float float_0 = 0.4f;

	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public override void PaintDockedBackground(ToolbarRendererEventArgs e)
	{
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		Graphics graphics = e.Graphics;
		Bar bar = e.Bar;
		ItemPaintArgs itemPaintArgs_ = e.itemPaintArgs_0;
		Rectangle bounds = e.Bounds;
		ColorScheme legacyColors = office2007ColorTable_0.LegacyColors;
		if (bar.LayoutType != eLayoutType.DockContainer && bar.LayoutType != eLayoutType.TaskList)
		{
			if (bar.MenuBar)
			{
				Class50.smethod_26(graphics, bounds, legacyColors.MenuBarBackground, legacyColors.MenuBarBackground2, legacyColors.MenuBarBackgroundGradientAngle);
			}
			else if (bar.GrabHandleStyle != eGrabHandleStyle.ResizeHandle && bar.BarType != eBarType.StatusBar)
			{
				if (bar.ItemsContainer.m_BackgroundColor.IsEmpty && ((Control)bar).get_BackColor() != Color.Transparent)
				{
					if (bar.IsThemed)
					{
						Rectangle rectangle_ = new Rectangle(-bar.Location.X, -bar.Location.Y, ((Control)bar).get_Parent().get_Width(), ((Control)bar).get_Parent().get_Height());
						Class78 class78_ = ((Interface6)bar).Class78_0;
						class78_.method_0(graphics, Class139.class139_0, Class164.class164_0, rectangle_);
					}
					else if (method_0(bar))
					{
						Class50.smethod_27(graphics, bounds, legacyColors.BarBackground, legacyColors.BarBackground2, legacyColors.BarBackgroundGradientAngle, new float[3] { 0f, 0.12f, 1f }, new float[3] { 0f, 0.5f, 1f });
					}
					else
					{
						Class50.smethod_23(graphics, bounds, legacyColors.BarBackground);
					}
				}
				else if (!bar.ItemsContainer.BackColor.IsEmpty)
				{
					Class50.smethod_23(graphics, bounds, bar.ItemsContainer.BackColor);
				}
				if (((Control)bar).get_Parent() != null && ((Control)bar).get_Parent().get_BackgroundImage() != null && ((Control)bar).get_Parent() is DockSite)
				{
					Rectangle rectangle_2 = new Rectangle(-bar.Location.X, -bar.Location.Y, ((Control)bar).get_Parent().get_Width(), ((Control)bar).get_Parent().get_Height());
					DockSite dockSite = ((Control)bar).get_Parent() as DockSite;
					Class109.smethod_63(graphics, rectangle_2, ((Control)dockSite).get_BackgroundImage(), dockSite.BackgroundImagePosition, dockSite.BackgroundImageAlpha);
				}
				else if (((Control)bar).get_BackgroundImage() != null)
				{
					Class109.smethod_63(graphics, bounds, ((Control)bar).get_BackgroundImage(), bar.BackgroundImagePosition, bar.BackgroundImageAlpha);
				}
				if (!bar.IsThemed && bar.LayoutType == eLayoutType.Toolbar && ((Control)bar).get_BackColor() != Color.Transparent && itemPaintArgs_ != null)
				{
					Pen val = new Pen(itemPaintArgs_.Colors.BarDockedBorder, 1f);
					try
					{
						graphics.DrawLine(val, 0, ((Control)bar).get_Height() - 1, ((Control)bar).get_Width(), ((Control)bar).get_Height() - 1);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				else
				{
					Rectangle rectangle_3 = bounds;
					rectangle_3.Inflate(-2, -2);
					Class109.smethod_28(graphics, bar.DockedBorderStyle, rectangle_3, bar.SingleLineColor);
				}
			}
			else if (!((Control)bar).get_BackColor().IsEmpty && bar.ShouldSerializeBackColor())
			{
				Class50.smethod_23(graphics, bounds, ((Control)bar).get_BackColor());
			}
			else
			{
				Office2007BarColorTable bar2 = office2007ColorTable_0.Bar;
				Rectangle rectangle_4 = bounds;
				rectangle_4.Inflate(1, 1);
				rectangle_4.Height = (int)((float)rectangle_4.Height * float_0);
				rectangle_4.Height++;
				Class50.smethod_25(graphics, rectangle_4, bar2.ToolbarTopBackground);
				rectangle_4.Height--;
				rectangle_4.Y += rectangle_4.Height;
				rectangle_4.Height = bounds.Height - rectangle_4.Height + 1;
				Class50.smethod_25(graphics, rectangle_4, bar2.ToolbarBottomBackground);
				if (bar.BarType == eBarType.StatusBar && bar.Items.Count > 0 && bar.Items[bar.Items.Count - 1] is ItemContainer && e.itemPaintArgs_0 != null && e.itemPaintArgs_0.bool_0)
				{
					ItemContainer itemContainer = bar.Items[bar.Items.Count - 1] as ItemContainer;
					if (itemContainer.Visible && itemContainer.BackgroundStyle.Class == ElementStyleClassKeys.Office2007StatusBarBackground2Key)
					{
						Rectangle bounds2 = new Rectangle(itemContainer.Bounds.X, bounds.Y, itemContainer.Bounds.Width, ((Control)e.Bar).get_Height() + 1);
						if (e.itemPaintArgs_0.RightToLeft)
						{
							bounds2.Width += bounds2.X;
							bounds2.X = 0;
						}
						else
						{
							bounds2.X += e.itemPaintArgs_0.ContainerControl.get_Left();
							bounds2.Width += bounds.Right - bounds2.Right;
						}
						ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(itemContainer.BackgroundStyle, graphics, bounds2));
					}
				}
				if (((Control)bar).get_Parent() != null && ((Control)bar).get_Parent().get_BackgroundImage() != null && ((Control)bar).get_Parent() is DockSite)
				{
					Rectangle rectangle_5 = new Rectangle(-bar.Location.X, -bar.Location.Y, ((Control)bar).get_Parent().get_Width(), ((Control)bar).get_Parent().get_Height());
					DockSite dockSite2 = ((Control)bar).get_Parent() as DockSite;
					Class109.smethod_63(graphics, rectangle_5, ((Control)dockSite2).get_BackgroundImage(), dockSite2.BackgroundImagePosition, dockSite2.BackgroundImageAlpha);
				}
				else if (((Control)bar).get_BackgroundImage() != null)
				{
					Class109.smethod_63(graphics, ((Control)bar).get_ClientRectangle(), ((Control)bar).get_BackgroundImage(), bar.BackgroundImagePosition, bar.BackgroundImageAlpha);
				}
				if ((!bar2.ToolbarBottomBorder.IsEmpty && bar.BarType != eBarType.StatusBar) || (!bar2.StatusBarTopBorder.IsEmpty && bar.BarType == eBarType.StatusBar))
				{
					if (bar.BarType == eBarType.StatusBar)
					{
						Pen val2 = new Pen(bar2.StatusBarTopBorder, 1f);
						try
						{
							graphics.DrawLine(val2, bounds.X, bounds.Y, bounds.Right, bounds.Y);
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
						if (!bar2.StatusBarTopBorderLight.IsEmpty)
						{
							Pen val3 = new Pen(bar2.StatusBarTopBorderLight, 1f);
							try
							{
								graphics.DrawLine(val3, bounds.X, bounds.Y + 1, bounds.Right, bounds.Y + 1);
							}
							finally
							{
								((IDisposable)val3)?.Dispose();
							}
						}
					}
					else
					{
						Pen val4 = new Pen(bar2.ToolbarBottomBorder, 1f);
						try
						{
							graphics.DrawLine(val4, bounds.X, bounds.Bottom - 1, bounds.Right, bounds.Bottom - 1);
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
				}
			}
		}
		else
		{
			Class50.smethod_26(graphics, bounds, legacyColors.BarBackground, legacyColors.BarBackground2, legacyColors.BarBackgroundGradientAngle);
		}
		if (itemPaintArgs_ != null && !itemPaintArgs_.bool_0)
		{
			bar.method_6(itemPaintArgs_);
		}
	}

	private bool method_0(Bar bar_0)
	{
		if (bar_0.Style == eDotNetBarStyle.VS2005 && bar_0.LayoutType == eLayoutType.DockContainer)
		{
			return false;
		}
		return true;
	}

	public override void PaintFloatingBackground(ToolbarRendererEventArgs e)
	{
		Graphics graphics = e.Graphics;
		Bar bar = e.Bar;
		Rectangle bounds = e.Bounds;
		ColorScheme legacyColors = office2007ColorTable_0.LegacyColors;
		Class50.smethod_27(graphics, bounds, legacyColors.BarBackground, legacyColors.BarBackground2, legacyColors.BarBackgroundGradientAngle, new float[3] { 0f, 0.12f, 1f }, new float[3] { 0f, 0.5f, 1f });
		if (((Control)bar).get_BackgroundImage() != null)
		{
			Class109.smethod_63(graphics, ((Control)bar).get_ClientRectangle(), ((Control)bar).get_BackgroundImage(), bar.BackgroundImagePosition, bar.BackgroundImageAlpha);
		}
	}

	public override void PaintPopupBackground(ToolbarRendererEventArgs e)
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		Graphics graphics = e.Graphics;
		Bar bar = e.Bar;
		Office2007BarColorTable bar2 = office2007ColorTable_0.Bar;
		int int32_ = bar.Int32_8;
		Rectangle bounds = e.Bounds;
		Class50.smethod_26(graphics, bounds, bar2.PopupToolbarBackground.Start, bar2.PopupToolbarBackground.End, bar2.PopupToolbarBackground.GradientAngle);
		if (((Control)bar).get_BackgroundImage() != null)
		{
			Class109.smethod_63(graphics, ((Control)bar).get_ClientRectangle(), ((Control)bar).get_BackgroundImage(), bar.BackgroundImagePosition, bar.BackgroundImageAlpha);
		}
		bar.method_18(graphics);
		Rectangle rectangle_ = bounds;
		if (bar.Boolean_9 && !bar.Boolean_10)
		{
			rectangle_ = new Rectangle(0, 0, ((Control)bar).get_ClientSize().Width - 2, ((Control)bar).get_ClientSize().Height - 2);
		}
		Pen val = new Pen(bar2.PopupToolbarBorder, 1f);
		try
		{
			Class50.smethod_11(graphics, val, rectangle_, int32_);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (bar.Boolean_9 && !bar.Boolean_10)
		{
			Point[] array = new Point[3];
			array[0].X = 2;
			array[0].Y = bounds.Height - 1;
			array[1].X = bounds.Width - 1;
			array[1].Y = bounds.Height - 1;
			array[2].X = bounds.Width - 1;
			array[2].Y = 2;
			Pen val2 = new Pen(SystemColors.ControlDark, 2f);
			try
			{
				graphics.DrawLines(val2, array);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
	}
}
