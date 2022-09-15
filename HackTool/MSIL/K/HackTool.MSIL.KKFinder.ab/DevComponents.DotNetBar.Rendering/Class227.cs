using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Rendering;

internal class Class227 : Class226, Interface3
{
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

	public override void PaintSideBar(SideBarRendererEventArgs e)
	{
		Graphics graphics = e.Graphics;
		SideBar sideBar = e.SideBar;
		Office2007SideBarColorTable sideBar2 = office2007ColorTable_0.SideBar;
		LinearGradientColorTable background = sideBar2.Background;
		Rectangle rectangle_ = new Rectangle(Point.Empty, ((Control)sideBar).get_Size());
		Class50.smethod_25(graphics, rectangle_, background);
		Color border = sideBar2.Border;
		Class50.smethod_6(graphics, border, rectangle_);
		base.PaintSideBar(e);
	}

	public override void PaintSideBarPanelItem(SideBarPanelItemRendererEventArgs e)
	{
		Graphics graphics = e.Graphics;
		SideBarPanelItem sideBarPanelItem = e.SideBarPanelItem;
		Office2007SideBarColorTable sideBar = office2007ColorTable_0.SideBar;
		GradientColorTable gradientColorTable = (sideBarPanelItem.Expanded ? sideBar.SideBarPanelItemExpanded : sideBar.SideBarPanelItemDefault);
		if (sideBarPanelItem.IsMouseDown)
		{
			gradientColorTable = sideBar.SideBarPanelItemPressed;
		}
		else if (sideBarPanelItem.IsMouseOver)
		{
			gradientColorTable = sideBar.SideBarPanelItemMouseOver;
		}
		if (!sideBarPanelItem.BackgroundStyle.BackColor1.IsEmpty || sideBarPanelItem.BackgroundStyle.BackgroundImage != null)
		{
			sideBarPanelItem.BackgroundStyle.Paint(graphics, sideBarPanelItem.DisplayRectangle);
		}
		Rectangle panelRect = sideBarPanelItem.PanelRect;
		Rectangle displayRectangle = sideBarPanelItem.DisplayRectangle;
		panelRect.Offset(displayRectangle.Location);
		if (gradientColorTable != null)
		{
			Brush val = Class50.smethod_45(panelRect, gradientColorTable);
			try
			{
				graphics.FillRectangle(val, panelRect);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		if (sideBarPanelItem.Expanded)
		{
			Class50.smethod_32(graphics, panelRect.X, panelRect.Bottom, panelRect.Right, panelRect.Bottom, sideBar.Border, 1);
		}
		Class50.smethod_32(graphics, displayRectangle.X, displayRectangle.Bottom, displayRectangle.Right, displayRectangle.Bottom, sideBar.Border, 1);
		Font font_ = sideBarPanelItem.vmethod_1();
		Class271 @class = sideBarPanelItem.method_34();
		if (@class != null)
		{
			panelRect.X += 2;
			panelRect.Width -= 2;
			@class.method_0(graphics, new Rectangle(panelRect.X, panelRect.Y + (panelRect.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
			panelRect.X += @class.Int32_0 + 4;
			panelRect.Width -= @class.Int32_0 + 8;
		}
		Rectangle rectangle = Rectangle.Empty;
		if (sideBarPanelItem.Text.Length > 0)
		{
			Class55.smethod_1(graphics, sideBarPanelItem.Text, font_, sideBar.SideBarPanelItemText, panelRect, sideBarPanelItem.method_23());
			rectangle = panelRect;
		}
		if (sideBarPanelItem.Focused)
		{
			if (sideBarPanelItem.DesignMode)
			{
				Rectangle panelRect2 = sideBarPanelItem.PanelRect;
				panelRect2.Offset(sideBarPanelItem.DisplayRectangle.Location);
				panelRect2.Inflate(-2, -2);
				Class32.smethod_0(graphics, panelRect2, e.itemPaintArgs_0.Colors.ItemDesignTimeBorder);
			}
			else if (!rectangle.IsEmpty)
			{
				ControlPaint.DrawFocusRectangle(graphics, rectangle);
			}
		}
		base.PaintSideBarPanelItem(e);
	}
}
