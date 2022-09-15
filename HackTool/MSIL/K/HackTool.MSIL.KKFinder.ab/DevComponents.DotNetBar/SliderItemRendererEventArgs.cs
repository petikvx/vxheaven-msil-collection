using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class SliderItemRendererEventArgs : EventArgs
{
	public SliderItem SliderItem;

	public Graphics Graphics;

	internal ItemPaintArgs itemPaintArgs_0;

	public SliderItemRendererEventArgs(SliderItem item, Graphics g)
	{
		SliderItem = item;
		Graphics = g;
	}
}
