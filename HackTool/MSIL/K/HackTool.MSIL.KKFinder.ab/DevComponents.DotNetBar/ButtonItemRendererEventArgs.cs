using System.Drawing;

namespace DevComponents.DotNetBar;

public class ButtonItemRendererEventArgs
{
	public Graphics Graphics;

	public ButtonItem ButtonItem;

	internal ItemPaintArgs itemPaintArgs_0;

	public ButtonItemRendererEventArgs()
	{
	}

	public ButtonItemRendererEventArgs(Graphics g, ButtonItem button)
	{
		Graphics = g;
		ButtonItem = button;
	}

	internal ButtonItemRendererEventArgs(Graphics g, ButtonItem button, ItemPaintArgs pa)
	{
		Graphics = g;
		ButtonItem = button;
		itemPaintArgs_0 = pa;
	}
}
