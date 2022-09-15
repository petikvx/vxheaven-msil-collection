using System;
using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

internal class Class235 : Class234, Interface3
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

	public override void PaintButtonBackground(NavPaneRenderEventArgs e)
	{
		Graphics graphics = e.Graphics;
		Rectangle bounds = e.Bounds;
		Office2007NavigationPaneColorTable navigationPane = office2007ColorTable_0.NavigationPane;
		Brush val = Class50.smethod_45(bounds, navigationPane.ButtonBackground);
		try
		{
			graphics.FillRectangle(val, bounds);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
