using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class ThemedButtonItemPainter
{
	public static void PaintButton(ButtonItem button, ItemPaintArgs pa)
	{
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		Graphics graphics = pa.Graphics;
		Class79 class79_ = pa.Class79_0;
		Class140 class140_ = Class140.class140_0;
		Class162 @class = Class162.class162_0;
		Color color_ = Class272.smethod_0(button, pa);
		Rectangle rectangle = Rectangle.Empty;
		Rectangle displayRectangle = button.DisplayRectangle;
		Font val = null;
		Class271 class2 = button.method_22();
		val = button.method_40(pa);
		eTextFormat eTextFormat2 = smethod_0(button, pa, class2);
		bool flag;
		if (flag = (button.SubItems.Count > 0 || button.PopupType == ePopupType.Container) && button.ShowSubItems && !button.Rectangle_1.IsEmpty)
		{
			class140_ = Class140.class140_2;
		}
		if (class2 != null)
		{
			rectangle = ((button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom) ? new Rectangle(button.Rectangle_0.X, button.Rectangle_0.Y, displayRectangle.Width, button.Rectangle_0.Height) : new Rectangle(button.Rectangle_0.X, button.Rectangle_0.Y, button.Rectangle_0.Width, button.Rectangle_0.Height));
			rectangle.Offset(displayRectangle.Left, displayRectangle.Top);
			rectangle.Offset((rectangle.Width - button.ImageSize.Width) / 2, (rectangle.Height - button.ImageSize.Height) / 2);
			rectangle.Width = button.ImageSize.Width;
			rectangle.Height = button.ImageSize.Height;
		}
		if (!Class265.smethod_1(button, pa))
		{
			@class = Class162.class162_3;
		}
		else if (button.IsMouseDown)
		{
			@class = Class162.class162_2;
		}
		else if (button.IsMouseOver && button.Checked)
		{
			@class = Class162.class162_5;
		}
		else if (!button.IsMouseOver && !button.Expanded)
		{
			if (button.Checked)
			{
				@class = Class162.class162_4;
			}
		}
		else
		{
			@class = Class162.class162_1;
		}
		Rectangle rectangle_ = button.DisplayRectangle;
		if (button.HotTrackingStyle == eHotTrackingStyle.Image && class2 != null)
		{
			rectangle_ = rectangle;
			rectangle_.Inflate(3, 3);
		}
		else if (flag)
		{
			rectangle_.Width -= button.Rectangle_1.Width;
		}
		if (button.HotTrackingStyle != eHotTrackingStyle.None)
		{
			class79_.method_0(graphics, class140_, @class, rectangle_);
		}
		if (class2 != null && button.ButtonStyle != eButtonStyle.TextOnlyAlways)
		{
			if (@class == Class162.class162_0 && button.HotTrackingStyle == eHotTrackingStyle.Color)
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
			else if (@class == Class162.class162_0 && !class2.Boolean_0)
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
		if (button.ButtonStyle == eButtonStyle.ImageAndText || button.ButtonStyle == eButtonStyle.TextOnlyAlways || class2 == null)
		{
			Rectangle rectangle2 = button.Rectangle_2;
			if (button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)
			{
				if (button.Orientation == eOrientation.Vertical)
				{
					rectangle2 = new Rectangle(button.Rectangle_2.X, button.Rectangle_2.Y, button.Rectangle_2.Width, button.Rectangle_2.Height);
				}
				else
				{
					rectangle2 = new Rectangle(button.Rectangle_2.X, button.Rectangle_2.Y, displayRectangle.Width, button.Rectangle_2.Height);
					if ((button.SubItems.Count > 0 || button.PopupType == ePopupType.Container) && button.ShowSubItems)
					{
						rectangle2.Width -= 10;
					}
				}
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			rectangle2.Offset(displayRectangle.Left, displayRectangle.Top);
			if (button.Orientation == eOrientation.Vertical)
			{
				graphics.RotateTransform(90f);
				Class55.smethod_2(graphics, Class265.smethod_0(button.Text), val, color_, new Rectangle(rectangle2.Top, -rectangle2.Right, rectangle2.Height, rectangle2.Width), eTextFormat2);
				graphics.ResetTransform();
			}
			else
			{
				if (rectangle2.Right > button.DisplayRectangle.Right)
				{
					rectangle2.Width = button.DisplayRectangle.Right - rectangle2.Left;
				}
				Class55.smethod_1(graphics, Class265.smethod_0(button.Text), val, color_, rectangle2, eTextFormat2);
				if (!button.DesignMode && button.Focused && !pa.IsOnMenu && !pa.IsOnMenuBar)
				{
					Rectangle rectangle3 = rectangle2;
					ControlPaint.DrawFocusRectangle(graphics, rectangle3);
				}
			}
		}
		if (flag)
		{
			class140_ = Class140.class140_3;
			@class = (Class265.smethod_1(button, pa) ? Class162.class162_0 : Class162.class162_3);
			if (button.HotTrackingStyle != eHotTrackingStyle.None && button.HotTrackingStyle != eHotTrackingStyle.Image && Class265.smethod_1(button, pa))
			{
				if (!button.Expanded && !button.IsMouseDown)
				{
					if (button.IsMouseOver && button.Checked)
					{
						@class = Class162.class162_5;
					}
					else if (button.Checked)
					{
						@class = Class162.class162_4;
					}
					else if (button.IsMouseOver)
					{
						@class = Class162.class162_1;
					}
				}
				else
				{
					@class = Class162.class162_2;
				}
			}
			if (!button.AutoExpandOnClick)
			{
				if (button.Orientation == eOrientation.Horizontal)
				{
					Rectangle rectangle_2 = button.Rectangle_1;
					rectangle_2.Offset(displayRectangle.X, displayRectangle.Y);
					class79_.method_0(graphics, class140_, @class, rectangle_2);
				}
				else
				{
					Rectangle rectangle_3 = button.Rectangle_1;
					rectangle_3.Offset(displayRectangle.X, displayRectangle.Y);
					class79_.method_0(graphics, class140_, @class, rectangle_3);
				}
			}
		}
		if (button.Focused && button.DesignMode)
		{
			Rectangle rectangle_4 = displayRectangle;
			rectangle_4.Inflate(-1, -1);
			Class32.smethod_0(graphics, rectangle_4, pa.Colors.ItemDesignTimeBorder);
		}
		class2?.Dispose();
	}

	private static eTextFormat smethod_0(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0, Class271 class271_0)
	{
		eTextFormat eTextFormat2 = itemPaintArgs_0.ButtonStringFormat;
		if (!smethod_1(buttonItem_0, itemPaintArgs_0))
		{
			if (buttonItem_0.ContainerControl is RibbonStrip && (class271_0 == null || buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom))
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			else if (itemPaintArgs_0.IsOnMenuBar || (itemPaintArgs_0.ContainerControl is Bar && class271_0 == null) || buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom)
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
		}
		return eTextFormat2;
	}

	private static bool smethod_1(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		bool result;
		if ((result = itemPaintArgs_0.IsOnMenu) && buttonItem_0.Parent is ItemContainer)
		{
			result = false;
		}
		return result;
	}
}
