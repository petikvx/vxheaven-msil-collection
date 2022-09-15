using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class Class97
{
	public static void smethod_0(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		Class82 class82_ = itemPaintArgs_0.Class82_0;
		Class142 class142_ = Class142.class142_0;
		Class167 @class = Class167.class167_0;
		Color color_ = Class272.smethod_0(buttonItem_0, itemPaintArgs_0);
		Rectangle rectangle = Rectangle.Empty;
		Rectangle displayRectangle = buttonItem_0.DisplayRectangle;
		Font val = null;
		Class271 class2 = buttonItem_0.method_22();
		eTextFormat eTextFormat2 = smethod_1(buttonItem_0, itemPaintArgs_0, class2);
		val = buttonItem_0.method_40(itemPaintArgs_0);
		bool flag = (buttonItem_0.SubItems.Count > 0 || buttonItem_0.PopupType == ePopupType.Container) && buttonItem_0.ShowSubItems && !buttonItem_0.Rectangle_1.IsEmpty;
		if (class2 != null)
		{
			rectangle = ((buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom) ? new Rectangle(buttonItem_0.Rectangle_0.X, buttonItem_0.Rectangle_0.Y, displayRectangle.Width, buttonItem_0.Rectangle_0.Height) : new Rectangle(buttonItem_0.Rectangle_0.X, buttonItem_0.Rectangle_0.Y, buttonItem_0.Rectangle_0.Width, buttonItem_0.Rectangle_0.Height));
			rectangle.Offset(displayRectangle.Left, displayRectangle.Top);
			rectangle.Offset((rectangle.Width - buttonItem_0.ImageSize.Width) / 2, (rectangle.Height - buttonItem_0.ImageSize.Height) / 2);
			rectangle.Width = buttonItem_0.ImageSize.Width;
			rectangle.Height = buttonItem_0.ImageSize.Height;
		}
		if (!Class265.smethod_1(buttonItem_0, itemPaintArgs_0))
		{
			@class = Class167.class167_3;
		}
		else if (!buttonItem_0.IsMouseDown && !buttonItem_0.Expanded)
		{
			if (buttonItem_0.IsMouseOver && buttonItem_0.Checked)
			{
				@class = Class167.class167_2;
			}
			else if (buttonItem_0.IsMouseOver)
			{
				@class = Class167.class167_1;
			}
			else if (!buttonItem_0.Checked && !buttonItem_0.Expanded)
			{
				if (buttonItem_0.Focused || itemPaintArgs_0.ContainerControl.get_Focused())
				{
					@class = Class167.class167_4;
				}
			}
			else
			{
				@class = Class167.class167_2;
			}
		}
		else
		{
			@class = Class167.class167_2;
		}
		Rectangle rectangle_ = buttonItem_0.DisplayRectangle;
		if (buttonItem_0.HotTrackingStyle == eHotTrackingStyle.Image && class2 != null)
		{
			rectangle_ = rectangle;
			rectangle_.Inflate(3, 3);
		}
		if (buttonItem_0.HotTrackingStyle != eHotTrackingStyle.None)
		{
			class82_.method_0(graphics, class142_, @class, rectangle_);
		}
		if (class2 != null && buttonItem_0.ButtonStyle != eButtonStyle.TextOnlyAlways)
		{
			if (@class == Class167.class167_0 && buttonItem_0.HotTrackingStyle == eHotTrackingStyle.Color)
			{
				ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
				{
					new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
					new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
					new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
					new float[5] { 0f, 0f, 0f, 1f, 0f },
					new float[5] { 0.2f, 0.2f, 0.2f, 0f, 1f }
				});
				ImageAttributes val2 = new ImageAttributes();
				val2.SetColorMatrix(colorMatrix);
				class2.method_2(graphics, rectangle, 0, 0, class2.Int32_0, class2.Int32_1, (GraphicsUnit)2, val2);
			}
			else if (@class == Class167.class167_0 && !class2.Boolean_0)
			{
				ImageAttributes val3 = new ImageAttributes();
				val3.SetGamma(0.7f, (ColorAdjustType)1);
				class2.method_2(graphics, rectangle, 0, 0, class2.Int32_0, class2.Int32_1, (GraphicsUnit)2, val3);
			}
			else
			{
				class2.method_0(graphics, rectangle);
			}
		}
		if (buttonItem_0.ButtonStyle == eButtonStyle.ImageAndText || buttonItem_0.ButtonStyle == eButtonStyle.TextOnlyAlways || class2 == null)
		{
			Rectangle rectangle_2 = buttonItem_0.Rectangle_2;
			if (buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom)
			{
				rectangle_2 = ((buttonItem_0.Orientation != eOrientation.Vertical) ? new Rectangle(buttonItem_0.Rectangle_2.X, buttonItem_0.Rectangle_2.Y, buttonItem_0.Rectangle_2.Width, buttonItem_0.Rectangle_2.Height) : new Rectangle(buttonItem_0.Rectangle_2.X, buttonItem_0.Rectangle_2.Y, buttonItem_0.Rectangle_2.Width, buttonItem_0.Rectangle_2.Height));
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			rectangle_2.Offset(displayRectangle.Left, displayRectangle.Top);
			if (buttonItem_0.Orientation == eOrientation.Vertical)
			{
				graphics.RotateTransform(90f);
				Class55.smethod_2(graphics, Class265.smethod_0(buttonItem_0.Text), val, color_, new Rectangle(rectangle_2.Top, -rectangle_2.Right, rectangle_2.Height, rectangle_2.Width), eTextFormat2);
				graphics.ResetTransform();
			}
			else
			{
				if (rectangle_2.Right > buttonItem_0.DisplayRectangle.Right)
				{
					rectangle_2.Width = buttonItem_0.DisplayRectangle.Right - rectangle_2.Left;
				}
				Class55.smethod_1(graphics, Class265.smethod_0(buttonItem_0.Text), val, color_, rectangle_2, eTextFormat2);
				if (!buttonItem_0.DesignMode && buttonItem_0.Focused && !itemPaintArgs_0.IsOnMenu && !itemPaintArgs_0.IsOnMenuBar)
				{
					Rectangle bounds = buttonItem_0.Bounds;
					bounds.Inflate(-3, -3);
					ControlPaint.DrawFocusRectangle(graphics, bounds);
				}
			}
		}
		if (flag)
		{
			Class265.smethod_3(buttonItem_0, itemPaintArgs_0);
		}
		class2?.Dispose();
	}

	private static eTextFormat smethod_1(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0, Class271 class271_0)
	{
		eTextFormat eTextFormat2 = itemPaintArgs_0.ButtonStringFormat;
		if (!smethod_2(buttonItem_0, itemPaintArgs_0) && (class271_0 == null || buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom))
		{
			eTextFormat2 |= eTextFormat.HorizontalCenter;
		}
		return eTextFormat2;
	}

	private static bool smethod_2(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		bool result;
		if ((result = itemPaintArgs_0.IsOnMenu) && buttonItem_0.Parent is ItemContainer)
		{
			result = false;
		}
		return result;
	}
}
