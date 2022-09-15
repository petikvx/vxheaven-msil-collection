using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

internal class Class42
{
	public static void smethod_0(Class43 class43_0)
	{
		Rectangle bounds = class43_0.isimpleElement_0.Bounds;
		Region clip = class43_0.graphics_0.get_Clip();
		if (clip != null)
		{
			class43_0.graphics_0.SetClip(bounds, (CombineMode)1);
		}
		else
		{
			class43_0.graphics_0.SetClip(bounds, (CombineMode)0);
		}
		ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo(class43_0.elementStyle_0, class43_0.graphics_0, bounds);
		ElementStyleDisplay.Paint(elementStyleDisplayInfo);
		class43_0.graphics_0.ResetClip();
		if (class43_0.isimpleElement_0.ImageVisible)
		{
			smethod_1(class43_0);
		}
		if (class43_0.isimpleElement_0.TextVisible)
		{
			elementStyleDisplayInfo.Bounds = (class43_0.rectangle_0.IsEmpty ? class43_0.isimpleElement_0.TextBounds : class43_0.rectangle_0);
			eTextFormat eTextFormat2 = class43_0.elementStyle_0.ETextFormat_0;
			if (class43_0.bool_0)
			{
				eTextFormat2 |= eTextFormat.RightToLeft;
			}
			ElementStyleDisplay.PaintText(elementStyleDisplayInfo, class43_0.isimpleElement_0.Text, class43_0.font_0, useDefaultFont: false, eTextFormat2);
		}
		if (clip != null)
		{
			class43_0.graphics_0.set_Clip(clip);
		}
		else
		{
			class43_0.graphics_0.ResetClip();
		}
	}

	private static void smethod_1(Class43 class43_0)
	{
		if (!class43_0.isimpleElement_0.ImageLayoutSize.IsEmpty && class43_0.isimpleElement_0.Image != null)
		{
			Rectangle imageBounds = class43_0.isimpleElement_0.ImageBounds;
			class43_0.graphics_0.DrawImage(class43_0.isimpleElement_0.Image, imageBounds.X + (imageBounds.Width - class43_0.isimpleElement_0.Image.get_Width()) / 2, imageBounds.Y + (imageBounds.Height - class43_0.isimpleElement_0.Image.get_Height()) / 2);
		}
	}
}
