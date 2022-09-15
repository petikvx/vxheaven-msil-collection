using System.Drawing;

namespace DevComponents.DotNetBar;

public class RibbonTabItemRendererEventArgs
{
	public Graphics Graphics;

	public RibbonTabItem RibbonTabItem;

	internal ItemPaintArgs itemPaintArgs_0;

	public RibbonTabItemRendererEventArgs()
	{
	}

	public RibbonTabItemRendererEventArgs(Graphics g, RibbonTabItem button)
	{
		Graphics = g;
		RibbonTabItem = button;
	}

	internal RibbonTabItemRendererEventArgs(Graphics g, RibbonTabItem button, ItemPaintArgs pa)
	{
		Graphics = g;
		RibbonTabItem = button;
		itemPaintArgs_0 = pa;
	}
}
