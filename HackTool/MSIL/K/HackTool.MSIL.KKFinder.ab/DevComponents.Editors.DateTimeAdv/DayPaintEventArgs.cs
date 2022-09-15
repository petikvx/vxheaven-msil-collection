using System;
using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.Editors.DateTimeAdv;

public class DayPaintEventArgs : EventArgs
{
	public readonly Graphics Graphics;

	public eDayPaintParts RenderParts = eDayPaintParts.All;

	internal DayLabel dayLabel_0;

	internal ItemPaintArgs itemPaintArgs_0;

	public DayPaintEventArgs(ItemPaintArgs p, DayLabel item)
	{
		Graphics = p.Graphics;
		itemPaintArgs_0 = p;
		dayLabel_0 = item;
	}

	public void PaintBackground()
	{
		dayLabel_0.method_20(itemPaintArgs_0);
	}

	public void PaintText()
	{
		dayLabel_0.method_21(itemPaintArgs_0, null, Color.Empty, dayLabel_0.TextAlign);
	}

	public void PaintText(Color textColor)
	{
		dayLabel_0.method_21(itemPaintArgs_0, null, textColor, dayLabel_0.TextAlign);
	}

	public void PaintText(Color textColor, eLabelPartAlignment textAlign)
	{
		dayLabel_0.method_21(itemPaintArgs_0, null, textColor, textAlign);
	}

	public void PaintText(Color textColor, Font textFont)
	{
		dayLabel_0.method_21(itemPaintArgs_0, textFont, textColor, dayLabel_0.TextAlign);
	}

	public void PaintText(Color textColor, Font textFont, eLabelPartAlignment textAlign)
	{
		dayLabel_0.method_21(itemPaintArgs_0, textFont, textColor, textAlign);
	}

	public void PaintImage()
	{
		dayLabel_0.method_18(itemPaintArgs_0, dayLabel_0.Image, dayLabel_0.ImageAlign);
	}

	public void PaintImage(eLabelPartAlignment imageAlign)
	{
		dayLabel_0.method_18(itemPaintArgs_0, dayLabel_0.Image, imageAlign);
	}
}
