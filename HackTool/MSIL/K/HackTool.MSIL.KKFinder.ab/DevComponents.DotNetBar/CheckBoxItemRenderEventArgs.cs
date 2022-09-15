using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class CheckBoxItemRenderEventArgs : EventArgs
{
	public Graphics Graphics;

	public CheckBoxItem CheckBoxItem;

	public ColorScheme ColorScheme;

	public bool RightToLeft;

	public Font Font;

	internal ItemPaintArgs itemPaintArgs_0;

	public CheckBoxItemRenderEventArgs(Graphics g, CheckBoxItem item, ColorScheme cs, Font f, bool rtl)
	{
		Graphics = g;
		CheckBoxItem = item;
		ColorScheme = cs;
		RightToLeft = rtl;
		Font = f;
	}
}
