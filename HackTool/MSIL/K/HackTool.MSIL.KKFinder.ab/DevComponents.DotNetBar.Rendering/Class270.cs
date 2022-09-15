using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar.Rendering;

internal class Class270 : Class268
{
	public override Rectangle GetImageRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		Rectangle empty = Rectangle.Empty;
		IsOnMenu(button, pa);
		if (image != null)
		{
			empty.Width = image.Int32_0 + 16;
			empty.Height = image.Int32_1 + 16;
			empty.X = button.DisplayRectangle.X + (button.DisplayRectangle.Width - empty.Width) / 2;
			empty.Y = button.DisplayRectangle.Y + 3;
		}
		return empty;
	}

	public override void PaintButtonImage(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle imagebounds)
	{
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		if (button is Class184 @class && @class.ribbonBar_0 != null)
		{
			ElementStyle elementStyle = @class.ribbonBar_0.method_16();
			ElementStyle titleStyle = @class.ribbonBar_0.TitleStyle;
			int int_ = 3;
			if (elementStyle.BackColorBlend.Count > 0)
			{
				Class50.smethod_19(pa.Graphics, imagebounds, int_, elementStyle.BackColorBlend[0].Color, elementStyle.BackColorBlend[elementStyle.BackColorBlend.Count - 1].Color, @class.ribbonBar_0.BackgroundStyle.BackColorGradientAngle);
			}
			else
			{
				Class50.smethod_19(pa.Graphics, imagebounds, int_, elementStyle.BackColor, elementStyle.BackColor2, elementStyle.BackColorGradientAngle);
			}
			if (!button.Expanded)
			{
				Class50.smethod_26(pa.Graphics, new Rectangle(imagebounds.X + 1, imagebounds.Bottom - 8, imagebounds.Width - 2, 7), titleStyle.BackColor, titleStyle.BackColor2, titleStyle.BackColorGradientAngle);
			}
			if (!elementStyle.BorderColor.IsEmpty)
			{
				GraphicsPath val = new GraphicsPath();
				try
				{
					val.AddLine(imagebounds.X, imagebounds.Bottom - 8, imagebounds.Right, imagebounds.Bottom - 8);
					ElementStyleDisplay.smethod_9(val, imagebounds, int_, Enum14.const_3);
					ElementStyleDisplay.smethod_9(val, imagebounds, int_, Enum14.const_2);
					val.CloseAllFigures();
					SolidBrush val2 = new SolidBrush(Color.FromArgb(192, elementStyle.BorderColor));
					try
					{
						pa.Graphics.FillPath((Brush)(object)val2, val);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			Class50.smethod_38(pa.Graphics, imagebounds, elementStyle.BorderColor, elementStyle.BorderColor2, elementStyle.BorderGradientAngle, 1, int_);
			imagebounds.X += (imagebounds.Width - image.Int32_0) / 2;
			imagebounds.Y += 4;
			imagebounds.Width = image.Int32_0;
			imagebounds.Height = image.Int32_1;
			image.method_0(pa.Graphics, imagebounds);
		}
		else
		{
			base.PaintButtonImage(button, pa, image, imagebounds);
		}
	}

	protected override Rectangle GetTextRectangle(ButtonItem button, ItemPaintArgs pa, eTextFormat stringFormat, Class271 image)
	{
		Rectangle textRectangle = base.GetTextRectangle(button, pa, stringFormat, image);
		textRectangle.Offset(0, 12);
		return textRectangle;
	}

	protected override void PaintState(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r, bool isMouseDown)
	{
	}
}
