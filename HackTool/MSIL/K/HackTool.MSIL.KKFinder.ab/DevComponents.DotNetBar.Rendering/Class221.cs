using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar.Rendering;

internal class Class221 : Class220, Interface3
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

	public override void PaintColorItem(ColorItemRendererEventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.Graphics;
		ColorItem colorItem = e.ColorItem;
		Rectangle bounds = colorItem.Bounds;
		Color border = office2007ColorTable_0.ColorItem.Border;
		Color mouseOverOuterBorder = office2007ColorTable_0.ColorItem.MouseOverOuterBorder;
		Color mouseOverInnerBorder = office2007ColorTable_0.ColorItem.MouseOverInnerBorder;
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)0);
		Region clip = graphics.get_Clip();
		graphics.SetClip(bounds);
		Color color = Color.Empty;
		ColorPickerDropDown colorPickerDropDown = null;
		BaseItem parent = colorItem.Parent;
		while (parent != null)
		{
			if (!(parent is ColorPickerDropDown))
			{
				parent = parent.Parent;
				continue;
			}
			colorPickerDropDown = parent as ColorPickerDropDown;
			break;
		}
		if (colorPickerDropDown != null)
		{
			color = colorPickerDropDown.SelectedColor;
		}
		try
		{
			if (!colorItem.Color.IsEmpty)
			{
				Rectangle rectangle_ = bounds;
				rectangle_.Inflate(1, 1);
				Class50.smethod_24(graphics, rectangle_, colorItem.Color, Color.Empty);
			}
			if (!colorItem.IsMouseOver && !(color == colorItem.Color))
			{
				eColorItemBorder border2 = colorItem.Border;
				switch (border2)
				{
				case eColorItemBorder.All:
					Class50.smethod_6(graphics, border, bounds);
					break;
				default:
				{
					Pen val = new Pen(border);
					try
					{
						if ((border2 & eColorItemBorder.Left) == eColorItemBorder.Left)
						{
							graphics.DrawLine(val, bounds.X, bounds.Y, bounds.X, bounds.Bottom - 1);
						}
						if ((border2 & eColorItemBorder.Right) == eColorItemBorder.Right)
						{
							graphics.DrawLine(val, bounds.Right - 1, bounds.Y, bounds.Right - 1, bounds.Bottom - 1);
						}
						if ((border2 & eColorItemBorder.Top) == eColorItemBorder.Top)
						{
							graphics.DrawLine(val, bounds.X, bounds.Y, bounds.Right - 1, bounds.Y);
						}
						if ((border2 & eColorItemBorder.Bottom) == eColorItemBorder.Bottom)
						{
							graphics.DrawLine(val, bounds.X, bounds.Bottom - 1, bounds.Right - 1, bounds.Bottom - 1);
						}
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
					break;
				}
				case eColorItemBorder.None:
					break;
				}
			}
			else
			{
				Rectangle rectangle_2 = bounds;
				rectangle_2.Inflate(-1, -1);
				Class50.smethod_6(graphics, mouseOverInnerBorder, rectangle_2);
				Class50.smethod_6(graphics, mouseOverOuterBorder, bounds);
			}
		}
		finally
		{
			if (clip != null)
			{
				graphics.set_Clip(clip);
			}
			else
			{
				graphics.ResetClip();
			}
		}
		graphics.set_SmoothingMode(smoothingMode);
	}
}
