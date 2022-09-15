using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

internal abstract class Class265
{
	public abstract void PaintButton(ButtonItem button, ItemPaintArgs pa);

	public abstract void PaintButtonBackground(ButtonItem button, ItemPaintArgs pa, Class271 image);

	public abstract void PaintButtonCheck(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r);

	public abstract void PaintButtonImage(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle imagebounds);

	public abstract void PaintButtonMouseOver(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r);

	public abstract void PaintButtonText(ButtonItem button, ItemPaintArgs pa, Color textColor, Class271 image);

	public abstract void PaintCustomizeCheck(ButtonItem button, ItemPaintArgs pa, Rectangle r);

	public abstract void PaintExpandButton(ButtonItem button, ItemPaintArgs pa);

	public abstract Rectangle GetCheckRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image);

	public abstract Rectangle GetCustomizeMenuCheckRectangle(ButtonItem button, ItemPaintArgs pa);

	public abstract Rectangle GetImageRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image);

	public abstract Rectangle GetMouseOverRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image);

	public abstract eTextFormat GetStringFormat(ButtonItem button, ItemPaintArgs pa, Class271 image);

	public static string smethod_0(string string_0)
	{
		return string_0;
	}

	public static bool smethod_1(BaseItem baseItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		if (baseItem_0.Enabled)
		{
			return itemPaintArgs_0.ContainerControl.get_Enabled();
		}
		return false;
	}

	public static Point[] smethod_2(Rectangle rectangle_0, ePopupSide ePopupSide_0)
	{
		Point[] array = new Point[3];
		Size size = new Size(4, 3);
		switch (ePopupSide_0)
		{
		case ePopupSide.Left:
			array[0].X = rectangle_0.Left + 3;
			array[0].Y = rectangle_0.Top + (rectangle_0.Height - size.Height) / 2 - 1;
			array[1].X = array[0].X;
			array[1].Y = array[0].Y + 6;
			array[2].X = array[0].X - 3;
			array[2].Y = array[0].Y + 3;
			break;
		case ePopupSide.Right:
			array[0].X = rectangle_0.Left + 1;
			array[0].Y = rectangle_0.Top + (rectangle_0.Height - size.Height) / 2 - 1;
			array[1].X = array[0].X;
			array[1].Y = array[0].Y + 6;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y + 3;
			break;
		case ePopupSide.Top:
			array[0].X = rectangle_0.Left + (rectangle_0.Width - size.Width) / 2 - 1;
			array[0].Y = rectangle_0.Top + (rectangle_0.Height - size.Height) / 2 + size.Height;
			array[1].X = array[0].X + 6;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y - 4;
			break;
		case ePopupSide.Default:
		case ePopupSide.Bottom:
			array[0].X = rectangle_0.Left + (rectangle_0.Width - size.Width) / 2;
			array[0].Y = rectangle_0.Top + (rectangle_0.Height - size.Height) / 2 + 1;
			array[1].X = array[0].X + 5;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 2;
			array[2].Y = array[0].Y + 3;
			break;
		}
		return array;
	}

	public static void smethod_3(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		Rectangle displayRectangle = buttonItem_0.DisplayRectangle;
		Point[] array = new Point[3];
		Rectangle rectangle_ = buttonItem_0.Rectangle_1;
		if (buttonItem_0.PopupSide == ePopupSide.Default)
		{
			if (buttonItem_0.Orientation == eOrientation.Horizontal)
			{
				array[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 5) / 2;
				array[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 3) / 2 + 1;
				array[1].X = array[0].X + 5;
				array[1].Y = array[0].Y;
				array[2].X = array[0].X + 2;
				array[2].Y = array[0].Y + 3;
			}
			else
			{
				array[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2;
				array[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
				array[1].X = array[0].X;
				array[1].Y = array[0].Y + 6;
				array[2].X = array[0].X + 3;
				array[2].Y = array[0].Y + 3;
			}
		}
		else
		{
			switch (buttonItem_0.PopupSide)
			{
			case ePopupSide.Left:
				array[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2 + 3;
				array[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
				array[1].X = array[0].X;
				array[1].Y = array[0].Y + 6;
				array[2].X = array[0].X - 3;
				array[2].Y = array[0].Y + 3;
				break;
			case ePopupSide.Right:
				array[0].X = displayRectangle.Left + rectangle_.Left + rectangle_.Width / 2;
				array[0].Y = displayRectangle.Top + rectangle_.Top + rectangle_.Height / 2 - 3;
				array[1].X = array[0].X;
				array[1].Y = array[0].Y + 6;
				array[2].X = array[0].X + 3;
				array[2].Y = array[0].Y + 3;
				break;
			case ePopupSide.Top:
				array[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 5) / 2;
				array[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 3) / 2 + 4;
				array[1].X = array[0].X + 6;
				array[1].Y = array[0].Y;
				array[2].X = array[0].X + 3;
				array[2].Y = array[0].Y - 4;
				break;
			case ePopupSide.Bottom:
				array[0].X = displayRectangle.Left + rectangle_.Left + (rectangle_.Width - 5) / 2 + 1;
				array[0].Y = displayRectangle.Top + rectangle_.Top + (rectangle_.Height - 3) / 2 + 1;
				array[1].X = array[0].X + 5;
				array[1].Y = array[0].Y;
				array[2].X = array[0].X + 2;
				array[2].Y = array[0].Y + 3;
				break;
			}
		}
		if (smethod_1(buttonItem_0, itemPaintArgs_0))
		{
			SolidBrush val = new SolidBrush(itemPaintArgs_0.Colors.ItemText);
			try
			{
				graphics.FillPolygon((Brush)(object)val, array);
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		SolidBrush val2 = new SolidBrush(itemPaintArgs_0.Colors.ItemDisabledText);
		try
		{
			graphics.FillPolygon((Brush)(object)val2, array);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
