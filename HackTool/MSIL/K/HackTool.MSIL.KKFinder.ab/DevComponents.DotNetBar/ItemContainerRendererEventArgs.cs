using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class ItemContainerRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public ItemContainer ItemContainer;

	internal ItemPaintArgs itemPaintArgs_0;

	public ItemContainerRendererEventArgs(Graphics g, ItemContainer container)
	{
		Graphics = g;
		ItemContainer = container;
	}
}
