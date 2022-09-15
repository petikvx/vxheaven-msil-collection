using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

internal class Class88
{
	private struct Struct7
	{
		public Size size_0;

		public Size size_1;
	}

	public static void smethod_0(ButtonItem buttonItem_0)
	{
		int num = 8;
		bool flag;
		if ((flag = buttonItem_0.IsOnMenu) && buttonItem_0.Parent is ItemContainer)
		{
			flag = false;
		}
		bool flag2 = false;
		if (buttonItem_0.method_22() != null)
		{
			flag2 = true;
		}
		bool isRightToLeft = buttonItem_0.IsRightToLeft;
		Size size = smethod_7(buttonItem_0, flag2, flag, bool_2: false);
		Rectangle displayRectangle = buttonItem_0.DisplayRectangle;
		if (flag)
		{
			size.Height += 2;
			size.Width += 7;
			if (buttonItem_0.IsOnCustomizeMenu && !isRightToLeft)
			{
				buttonItem_0.Rectangle_0 = new Rectangle(displayRectangle.Height + 2, Math.Max(0, (displayRectangle.Height - size.Height) / 2), size.Width, size.Height);
			}
			else
			{
				buttonItem_0.Rectangle_0 = new Rectangle(0, Math.Max(0, (displayRectangle.Height - size.Height) / 2), size.Width, size.Height);
			}
			buttonItem_0.Rectangle_2 = new Rectangle(buttonItem_0.Rectangle_0.Right + 8, Math.Max(0, (displayRectangle.Height - buttonItem_0.Rectangle_2.Height) / 2), buttonItem_0.Rectangle_2.Width, buttonItem_0.Rectangle_2.Height);
			return;
		}
		int val = 0;
		if (!buttonItem_0.Rectangle_1.IsEmpty)
		{
			Rectangle rectangle_ = buttonItem_0.Rectangle_1;
			if (buttonItem_0.ContainerControl is RibbonBar && (buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom))
			{
				rectangle_ = new Rectangle(0, displayRectangle.Height - rectangle_.Height, displayRectangle.Width, rectangle_.Height);
				displayRectangle.Height -= rectangle_.Height;
			}
			else if (buttonItem_0.Orientation == eOrientation.Horizontal)
			{
				if (isRightToLeft)
				{
					rectangle_ = new Rectangle(0, 0, rectangle_.Width, displayRectangle.Height);
					val = rectangle_.Width;
				}
				else
				{
					rectangle_ = new Rectangle(displayRectangle.Width - rectangle_.Width, 0, rectangle_.Width, displayRectangle.Height);
					displayRectangle.Width -= rectangle_.Width;
				}
			}
			else
			{
				rectangle_ = new Rectangle(0, 0, displayRectangle.Width, rectangle_.Height);
				displayRectangle.Height -= rectangle_.Height;
			}
			buttonItem_0.Rectangle_1 = rectangle_;
		}
		if (flag2 && buttonItem_0.ButtonStyle != eButtonStyle.TextOnlyAlways)
		{
			if ((buttonItem_0.ButtonStyle == eButtonStyle.Default && buttonItem_0.ImagePosition != eImagePosition.Top && buttonItem_0.ImagePosition != eImagePosition.Bottom) || displayRectangle.Width < size.Width + num)
			{
				buttonItem_0.Rectangle_0 = new Rectangle(Math.Max(0, (displayRectangle.Width - buttonItem_0.Rectangle_0.Width) / 2), Math.Max(0, (displayRectangle.Height - buttonItem_0.Rectangle_0.Height) / 2), buttonItem_0.Rectangle_0.Width, buttonItem_0.Rectangle_0.Height);
				if (displayRectangle.Width < size.Width + num)
				{
					buttonItem_0.Rectangle_2 = Rectangle.Empty;
				}
			}
			else if ((buttonItem_0.ImagePosition == eImagePosition.Left && !isRightToLeft) || (buttonItem_0.ImagePosition == eImagePosition.Right && isRightToLeft))
			{
				buttonItem_0.Rectangle_0 = new Rectangle(0, Math.Max(0, (displayRectangle.Height - buttonItem_0.Rectangle_0.Height) / 2), buttonItem_0.Rectangle_0.Width, buttonItem_0.Rectangle_0.Height);
				buttonItem_0.Rectangle_2 = new Rectangle(buttonItem_0.Rectangle_0.Right - 2, Math.Max(0, (displayRectangle.Height - buttonItem_0.Rectangle_2.Height) / 2), Math.Min(buttonItem_0.Rectangle_2.Width, displayRectangle.Width - (buttonItem_0.Rectangle_0.Right - 2)), buttonItem_0.Rectangle_2.Height);
			}
			else if ((buttonItem_0.ImagePosition == eImagePosition.Right && !isRightToLeft) || (buttonItem_0.ImagePosition == eImagePosition.Left && isRightToLeft))
			{
				buttonItem_0.Rectangle_0 = new Rectangle(displayRectangle.Width - buttonItem_0.Rectangle_0.Width, Math.Max(0, (displayRectangle.Height - buttonItem_0.Rectangle_2.Height) / 2), buttonItem_0.Rectangle_0.Width, buttonItem_0.Rectangle_0.Height);
				buttonItem_0.Rectangle_2 = new Rectangle(Math.Max(val, buttonItem_0.Rectangle_0.X - buttonItem_0.Rectangle_2.Width + 2), Math.Max(0, (displayRectangle.Height - buttonItem_0.Rectangle_2.Height) / 2), Math.Min(buttonItem_0.Rectangle_2.Width, buttonItem_0.Rectangle_0.X), buttonItem_0.Rectangle_2.Height);
			}
			else if (buttonItem_0.ImagePosition == eImagePosition.Top)
			{
				int y = Math.Max(2, (displayRectangle.Height - (buttonItem_0.Rectangle_2.Height + buttonItem_0.Rectangle_0.Height - 2)) / 2);
				if (buttonItem_0.Name != "sysOverflowButton" && buttonItem_0.Parent is ItemContainer && ((ItemContainer)buttonItem_0.Parent).LayoutOrientation == eOrientation.Horizontal && ((ItemContainer)buttonItem_0.Parent).VerticalItemAlignment == eVerticalItemsAlignment.Top)
				{
					y = 2;
				}
				buttonItem_0.Rectangle_0 = new Rectangle(0, y, displayRectangle.Width, buttonItem_0.Rectangle_0.Height);
				buttonItem_0.Rectangle_2 = new Rectangle(Math.Max(0, (displayRectangle.Width - buttonItem_0.Rectangle_2.Width) / 2), buttonItem_0.Rectangle_0.Bottom, buttonItem_0.Rectangle_2.Width, buttonItem_0.Rectangle_2.Height);
			}
			else if (buttonItem_0.ImagePosition == eImagePosition.Bottom)
			{
				int num2 = Math.Max(0, (displayRectangle.Height - (buttonItem_0.Rectangle_2.Height + buttonItem_0.Rectangle_0.Height - 2)) / 2);
				buttonItem_0.Rectangle_0 = new Rectangle(0, displayRectangle.Height - num2 - buttonItem_0.Rectangle_0.Height, displayRectangle.Width, buttonItem_0.Rectangle_0.Height);
				buttonItem_0.Rectangle_2 = new Rectangle(Math.Max(0, (displayRectangle.Width - buttonItem_0.Rectangle_0.Width) / 2), Math.Max(0, buttonItem_0.Rectangle_0.Y + 2 - buttonItem_0.Rectangle_2.Height), buttonItem_0.Rectangle_2.Width, Math.Min(buttonItem_0.Rectangle_2.Height, buttonItem_0.Rectangle_0.Y));
			}
		}
		else
		{
			int num3 = displayRectangle.Height - 2;
			buttonItem_0.Rectangle_2 = new Rectangle(2, Math.Max(0, (displayRectangle.Height - num3) / 2), displayRectangle.Width - 4, num3);
		}
	}

	public static Size smethod_1(BaseItem baseItem_0, Graphics graphics_0, int int_0, Font font_0, eTextFormat eTextFormat_0, bool bool_0)
	{
		return smethod_2(baseItem_0, graphics_0, int_0, font_0, eTextFormat_0, bool_0, bool_1: false, eImagePosition.Left);
	}

	public static Size smethod_2(BaseItem baseItem_0, Graphics graphics_0, int int_0, Font font_0, eTextFormat eTextFormat_0, bool bool_0, bool bool_1, eImagePosition eImagePosition_0)
	{
		if (baseItem_0.Text == "" && baseItem_0.Class261_0 == null)
		{
			return Size.Empty;
		}
		Size empty = Size.Empty;
		if (baseItem_0.Class261_0 == null)
		{
			return Class55.smethod_4(graphics_0, Class265.smethod_0(baseItem_0.Text), font_0, int_0, eTextFormat_0);
		}
		Size availableSize = new Size(int_0, 1);
		if (int_0 == 0)
		{
			availableSize.Width = 1600;
		}
		Class263 @class = new Class263(graphics_0, font_0, Color.Empty, rightToLeft: false);
		baseItem_0.Class261_0.Measure(availableSize, @class);
		availableSize = baseItem_0.Class261_0.Bounds.Size;
		if (int_0 != 0 && (!bool_1 || eImagePosition_0 != eImagePosition.Top))
		{
			availableSize.Width = int_0;
		}
		@class.bool_0 = bool_0;
		baseItem_0.Class261_0.method_2(new Rectangle(0, 0, availableSize.Width, availableSize.Height), @class);
		return baseItem_0.Class261_0.Bounds.Size;
	}

	public static void smethod_3(ButtonItem buttonItem_0)
	{
		smethod_5(buttonItem_0, bool_0: false);
	}

	private static bool smethod_4(ButtonItem buttonItem_0)
	{
		if (buttonItem_0.Class261_0 == null)
		{
			return buttonItem_0.Text.IndexOf(' ') > 0;
		}
		if (buttonItem_0.Text.IndexOf(' ') > 0 && !buttonItem_0.Class261_0.bool_2)
		{
			return true;
		}
		if (buttonItem_0.Text.Split(new char[1] { ' ' }).Length > 2 && buttonItem_0.Class261_0.bool_2)
		{
			return buttonItem_0.ButtonStyle != eButtonStyle.Default;
		}
		return false;
	}

	public static void smethod_5(ButtonItem buttonItem_0, bool bool_0)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		object containerControl = buttonItem_0.ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == null || val.get_Disposing() || val.get_IsDisposed())
		{
			return;
		}
		if (val is ButtonX && buttonItem_0.bool_36)
		{
			smethod_10(buttonItem_0);
			return;
		}
		if (buttonItem_0.FixedSize.Width > 0 && buttonItem_0.FixedSize.Height > 0)
		{
			buttonItem_0.method_4(new Rectangle(buttonItem_0.DisplayRectangle.Location, buttonItem_0.FixedSize));
			smethod_10(buttonItem_0);
			return;
		}
		bool flag;
		if ((flag = buttonItem_0.IsOnMenu) && buttonItem_0.Parent is ItemContainer)
		{
			flag = false;
		}
		bool flag2 = false;
		if (buttonItem_0.method_22() != null || bool_0)
		{
			flag2 = true;
		}
		eImagePosition eImagePosition2 = buttonItem_0.ImagePosition;
		bool flag3 = (int)val.get_RightToLeft() == 1;
		Rectangle rectangle_ = Rectangle.Empty;
		Rectangle rectangle_2 = Rectangle.Empty;
		Rectangle rectangle = Rectangle.Empty;
		Rectangle rectangle2 = new Rectangle(buttonItem_0.DisplayRectangle.Location, Size.Empty);
		if (flag3 && buttonItem_0.Orientation == eOrientation.Horizontal)
		{
			switch (eImagePosition2)
			{
			case eImagePosition.Left:
				eImagePosition2 = eImagePosition.Right;
				break;
			case eImagePosition.Right:
				eImagePosition2 = eImagePosition.Left;
				break;
			}
		}
		int num = 0;
		if (buttonItem_0.bool_36)
		{
			num = buttonItem_0.DisplayRectangle.Width - 4;
		}
		rectangle2.Width = 0;
		rectangle2.Height = 0;
		Graphics val2 = Class109.smethod_68(val);
		try
		{
			eTextFormat eTextFormat2 = smethod_9(buttonItem_0);
			Size size = smethod_7(buttonItem_0, flag2, flag, bool_0);
			bool flag4 = false;
			if (buttonItem_0.bool_36 && flag2 && (eImagePosition2 == eImagePosition.Left || eImagePosition2 == eImagePosition.Right))
			{
				num -= size.Width + 10;
			}
			else if (buttonItem_0.RibbonWordWrap && flag2 && eImagePosition2 == eImagePosition.Top && val is RibbonBar && smethod_4(buttonItem_0))
			{
				num = size.Width + 4;
				eTextFormat2 |= eTextFormat.WordBreak;
				flag4 = true;
			}
			Font val3 = buttonItem_0.method_40(null);
			SizeF sizeF = SizeF.Empty;
			if ((buttonItem_0.Text != "" || buttonItem_0.Class261_0 != null) && (!flag2 || flag || buttonItem_0.ButtonStyle != 0 || (buttonItem_0.ImagePosition != 0 && flag2)))
			{
				sizeF = smethod_2(buttonItem_0, val2, num, val3, eTextFormat2, flag3, flag4, eImagePosition2);
				int num2 = 0;
				while (flag4 && (double)sizeF.Height > (double)val3.get_Height() * 2.2 && num2 < 3)
				{
					num += size.Width / 2;
					sizeF = smethod_2(buttonItem_0, val2, num, val3, eTextFormat2, flag3, flag4, eImagePosition2);
					num2++;
				}
			}
			if (flag)
			{
				if (size.IsEmpty)
				{
					size = new Size(16, 16);
				}
				size.Height += 2;
				size.Width += 7;
				if (sizeF.Height > (float)size.Height)
				{
					rectangle2.Height = (int)sizeF.Height + 4;
				}
				else
				{
					rectangle2.Height = size.Height + 4;
				}
				rectangle2.Height += buttonItem_0.Int32_1;
				rectangle_2 = ((!buttonItem_0.IsOnCustomizeMenu || flag3) ? new Rectangle(0, (rectangle2.Height - size.Height) / 2, size.Width, size.Height) : new Rectangle(rectangle2.Height + 2, (rectangle2.Height - size.Height) / 2, size.Width, size.Height));
				rectangle2.Width = (int)sizeF.Width;
				if (buttonItem_0.String_1 != "")
				{
					Size size2 = Class55.smethod_4(val2, buttonItem_0.String_1, val3, 0, eTextFormat2);
					rectangle2.Width += size2.Width + 14;
				}
				rectangle_ = new Rectangle(rectangle_2.Right + 8, 2, rectangle2.Width, rectangle2.Height - 4);
				rectangle2.Width += rectangle_2.Right + 8 + 26;
				rectangle2.Width += buttonItem_0.Int32_2;
			}
			else
			{
				bool boolean_ = buttonItem_0.Boolean_2;
				if (buttonItem_0.Orientation == eOrientation.Horizontal && (eImagePosition2 == eImagePosition.Left || eImagePosition2 == eImagePosition.Right))
				{
					size.Width += buttonItem_0.ImagePaddingHorizontal;
					if (sizeF.Height > (float)size.Height)
					{
						rectangle2.Height = (int)sizeF.Height + buttonItem_0.ImagePaddingVertical;
					}
					else
					{
						rectangle2.Height = size.Height + buttonItem_0.ImagePaddingVertical;
					}
					rectangle2.Height += buttonItem_0.Int32_1;
					if (boolean_ && !buttonItem_0.IsOnMenuBar)
					{
						rectangle2.Height += 4;
					}
					rectangle_2 = Rectangle.Empty;
					if (buttonItem_0.ButtonStyle != eButtonStyle.TextOnlyAlways && flag2)
					{
						rectangle_2 = new Rectangle(0, (rectangle2.Height - size.Height) / 2, size.Width, size.Height);
					}
					rectangle_ = Rectangle.Empty;
					if (buttonItem_0.ButtonStyle != 0 || !flag2)
					{
						if (rectangle_2.Right > 0)
						{
							rectangle2.Width = (int)sizeF.Width + 1;
							rectangle_ = new Rectangle(rectangle_2.Right - 2, 2, rectangle2.Width, rectangle2.Height - 4);
						}
						else
						{
							rectangle2.Width = (int)sizeF.Width + 6;
							if (!flag2 && buttonItem_0.IsOnMenuBar)
							{
								rectangle2.Width += 6;
								rectangle_ = new Rectangle(2, 2, rectangle2.Width, rectangle2.Height - 4);
							}
							else
							{
								rectangle_ = new Rectangle(2, 2, rectangle2.Width + buttonItem_0.Int32_2 - 4, rectangle2.Height - 4);
							}
						}
					}
					rectangle2.Width += rectangle_2.Right;
					if (eImagePosition2 == eImagePosition.Right && rectangle_2.Right > 0 && flag2)
					{
						rectangle_.X = 3;
						rectangle_2.X = rectangle2.Width - rectangle_2.Width;
					}
					rectangle2.Width += buttonItem_0.Int32_2;
				}
				else if (buttonItem_0.Orientation == eOrientation.Horizontal)
				{
					if (sizeF.Width > (float)size.Width)
					{
						rectangle2.Width = (int)sizeF.Width + buttonItem_0.ImagePaddingHorizontal;
					}
					else
					{
						rectangle2.Width = size.Width + buttonItem_0.ImagePaddingHorizontal;
					}
					rectangle2.Height = (int)((float)size.Height + sizeF.Height + (float)buttonItem_0.ImagePaddingVertical);
					rectangle2.Width += buttonItem_0.Int32_2;
					rectangle2.Height += buttonItem_0.Int32_1;
					if (eImagePosition2 == eImagePosition.Top)
					{
						rectangle_2 = new Rectangle(0, buttonItem_0.Int32_1 / 2 + 2, rectangle2.Width, size.Height);
						rectangle_ = new Rectangle((int)((float)rectangle2.Width - sizeF.Width) / 2, rectangle_2.Bottom, (int)sizeF.Width, (int)sizeF.Height + 5);
					}
					else
					{
						rectangle_ = new Rectangle((int)((float)rectangle2.Width - sizeF.Width) / 2, buttonItem_0.Int32_1 / 2, (int)sizeF.Width, (int)sizeF.Height + 2);
						rectangle_2 = new Rectangle(0, rectangle_.Bottom, rectangle2.Width, size.Height + 5);
					}
				}
				else
				{
					if (sizeF.Height > (float)size.Width && buttonItem_0.ButtonStyle != 0)
					{
						rectangle2.Width = (int)sizeF.Height + 6;
					}
					else
					{
						rectangle2.Width = size.Width + 10;
					}
					rectangle2.Width += buttonItem_0.Int32_2;
					if (buttonItem_0.ButtonStyle == eButtonStyle.Default && flag2)
					{
						rectangle2.Height = size.Height + 6;
					}
					else if (flag2)
					{
						rectangle2.Height = (int)((float)size.Height + sizeF.Width + 12f);
					}
					else
					{
						rectangle2.Height = (int)(sizeF.Width + 6f);
					}
					if (eImagePosition2 != eImagePosition.Top && eImagePosition2 != 0)
					{
						rectangle_ = new Rectangle((int)((float)rectangle2.Width - sizeF.Height) / 2, 5, (int)sizeF.Height, (int)sizeF.Width + 5);
						if (flag2)
						{
							rectangle_2 = new Rectangle(0, rectangle_.Bottom - 3, rectangle2.Width, size.Height + 5);
						}
					}
					else
					{
						if (flag2)
						{
							rectangle_2 = new Rectangle(0, 0, rectangle2.Width, size.Height + 6);
						}
						rectangle_ = new Rectangle((int)((float)rectangle2.Width - sizeF.Height) / 2, rectangle_2.Bottom + 2, (int)sizeF.Height, (int)sizeF.Width + 5);
					}
					rectangle2.Height += buttonItem_0.Int32_1;
				}
				if (smethod_6(buttonItem_0))
				{
					rectangle = smethod_8(buttonItem_0, rectangle2, flag3);
					Rectangle b = rectangle;
					b.Offset(rectangle2.Location);
					if (flag3 && (!(val is RibbonBar) || (buttonItem_0.ImagePosition != eImagePosition.Top && buttonItem_0.ImagePosition != eImagePosition.Bottom)))
					{
						if (!rectangle_.IsEmpty)
						{
							rectangle_.Offset(rectangle.Width + 1, 0);
						}
						if (!rectangle_2.IsEmpty && buttonItem_0.Orientation == eOrientation.Horizontal && (eImagePosition2 == eImagePosition.Left || eImagePosition2 == eImagePosition.Right))
						{
							rectangle_2.Offset(rectangle.Width, 0);
						}
						rectangle2.X += rectangle.Width;
					}
					rectangle2 = Rectangle.Union(rectangle2, b);
				}
			}
		}
		finally
		{
			val2.set_TextRenderingHint((TextRenderingHint)0);
			val2.set_SmoothingMode((SmoothingMode)0);
			val2.Dispose();
		}
		val = null;
		buttonItem_0.method_4(rectangle2);
		buttonItem_0.Rectangle_0 = rectangle_2;
		buttonItem_0.Rectangle_2 = rectangle_;
		buttonItem_0.Rectangle_1 = rectangle;
	}

	private static bool smethod_6(ButtonItem buttonItem_0)
	{
		if ((buttonItem_0.SubItems.Count > 0 || buttonItem_0.PopupType == ePopupType.Container) && buttonItem_0.ShowSubItems && !buttonItem_0.IsOnMenuBar)
		{
			if (buttonItem_0.Class261_0 != null && buttonItem_0.Class261_0.bool_2)
			{
				return buttonItem_0.ButtonStyle == eButtonStyle.Default;
			}
			return true;
		}
		return false;
	}

	private static Size smethod_7(ButtonItem buttonItem_0, bool bool_0, bool bool_1, bool bool_2)
	{
		Size result = Size.Empty;
		result = ((buttonItem_0.Parent != null && buttonItem_0.ImageFixedSize.IsEmpty) ? ((!(buttonItem_0.Parent is ImageItem imageItem) || imageItem.SubItemsImageSize.IsEmpty) ? buttonItem_0.ImageSize : ((!bool_0 || bool_1) ? new Size(imageItem.SubItemsImageSize.Width, imageItem.SubItemsImageSize.Height) : ((buttonItem_0.Orientation != 0) ? new Size(Math.Max(imageItem.SubItemsImageSize.Width, buttonItem_0.ImageSize.Width), buttonItem_0.ImageSize.Height) : new Size(buttonItem_0.ImageSize.Width, Math.Max(imageItem.SubItemsImageSize.Height, buttonItem_0.ImageSize.Height))))) : (buttonItem_0.ImageFixedSize.IsEmpty ? buttonItem_0.ImageSize : buttonItem_0.ImageFixedSize));
		if (bool_2 && GlobalManager.Renderer is Office2007Renderer office2007Renderer && office2007Renderer.ColorTable != null)
		{
			Office2007ColorTable colorTable = office2007Renderer.ColorTable;
			if (colorTable.RibbonControl.StartButtonDefault != null)
			{
				if (result.Width < colorTable.RibbonControl.StartButtonDefault.get_Width())
				{
					result.Width = colorTable.RibbonControl.StartButtonDefault.get_Width();
				}
				if (result.Height < colorTable.RibbonControl.StartButtonDefault.get_Height())
				{
					result.Height = colorTable.RibbonControl.StartButtonDefault.get_Height();
				}
			}
		}
		return result;
	}

	public static Rectangle smethod_8(ButtonItem buttonItem_0, Rectangle rectangle_0, bool bool_0)
	{
		Rectangle empty = Rectangle.Empty;
		return (buttonItem_0.ContainerControl is RibbonBar && (buttonItem_0.ImagePosition == eImagePosition.Top || buttonItem_0.ImagePosition == eImagePosition.Bottom)) ? new Rectangle(0, rectangle_0.Height, rectangle_0.Width, buttonItem_0.SubItemsExpandWidth) : ((buttonItem_0.Orientation != 0) ? new Rectangle(0, rectangle_0.Height - 2, rectangle_0.Width, buttonItem_0.SubItemsExpandWidth) : (buttonItem_0.Boolean_2 ? ((!bool_0) ? new Rectangle(rectangle_0.Width, 0, buttonItem_0.SubItemsExpandWidth, rectangle_0.Height) : new Rectangle(0, 0, buttonItem_0.SubItemsExpandWidth, rectangle_0.Height)) : ((!bool_0) ? new Rectangle(rectangle_0.Width + 1, 0, buttonItem_0.SubItemsExpandWidth, rectangle_0.Height) : new Rectangle(0, 0, buttonItem_0.SubItemsExpandWidth, rectangle_0.Height))));
	}

	public static eTextFormat smethod_9(ButtonItem buttonItem_0)
	{
		eTextFormat eTextFormat2 = eTextFormat.Default;
		eTextFormat2 = (buttonItem_0.bool_36 ? (eTextFormat2 | eTextFormat.WordBreak) : (eTextFormat2 | eTextFormat.SingleLine));
		return eTextFormat2 | eTextFormat.VerticalCenter;
	}

	public static void smethod_10(ButtonItem buttonItem_0)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		object containerControl = buttonItem_0.ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		ButtonX buttonX = buttonItem_0.ContainerControl as ButtonX;
		if (!Class109.smethod_11(val))
		{
			return;
		}
		bool flag;
		if ((flag = buttonItem_0.IsOnMenu) && buttonItem_0.Parent is ItemContainer)
		{
			flag = false;
		}
		bool flag2 = false;
		if (buttonItem_0.method_22() != null)
		{
			flag2 = true;
		}
		eImagePosition eImagePosition2 = buttonItem_0.ImagePosition;
		bool flag3 = (int)val.get_RightToLeft() == 1;
		Rectangle rectangle_ = Rectangle.Empty;
		Rectangle rectangle_2 = Rectangle.Empty;
		Rectangle rectangle_3 = Rectangle.Empty;
		Rectangle bounds = buttonItem_0.Bounds;
		if (buttonItem_0.SubItems.Count > 0 && buttonItem_0.ShowSubItems && (buttonItem_0.Class261_0 == null || !buttonItem_0.Class261_0.bool_2 || buttonItem_0.ButtonStyle == eButtonStyle.Default))
		{
			if (buttonItem_0.Orientation == eOrientation.Horizontal)
			{
				rectangle_3 = ((!flag3) ? new Rectangle(bounds.Width - buttonItem_0.SubItemsExpandWidth, 0, buttonItem_0.SubItemsExpandWidth, bounds.Height) : new Rectangle(0, 0, buttonItem_0.SubItemsExpandWidth, bounds.Height));
				if (flag3)
				{
					bounds.X += buttonItem_0.SubItemsExpandWidth + 1;
				}
				bounds.Width -= buttonItem_0.SubItemsExpandWidth + 1;
			}
			else
			{
				rectangle_3 = new Rectangle(0, bounds.Height - buttonItem_0.SubItemsExpandWidth, bounds.Width, buttonItem_0.SubItemsExpandWidth);
				bounds.Height -= buttonItem_0.SubItemsExpandWidth + 1;
			}
		}
		if (flag3 && buttonItem_0.Orientation == eOrientation.Horizontal)
		{
			switch (eImagePosition2)
			{
			case eImagePosition.Left:
				eImagePosition2 = eImagePosition.Right;
				break;
			case eImagePosition.Right:
				eImagePosition2 = eImagePosition.Left;
				break;
			}
		}
		int num = 0;
		num = bounds.Width;
		Graphics val2 = Class109.smethod_68(val);
		try
		{
			Size empty = Size.Empty;
			empty = (buttonItem_0.ImageFixedSize.IsEmpty ? buttonItem_0.ImageSize : buttonItem_0.ImageFixedSize);
			if (flag2 && (eImagePosition2 == eImagePosition.Left || eImagePosition2 == eImagePosition.Right))
			{
				num -= empty.Width + 8;
			}
			Font val3 = buttonItem_0.method_40(null);
			SizeF sizeF = SizeF.Empty;
			eTextFormat eTextFormat2 = eTextFormat.VerticalCenter;
			if (buttonX != null || (val is RibbonBar && buttonItem_0.RibbonWordWrap))
			{
				eTextFormat2 |= eTextFormat.WordBreak;
			}
			if (buttonItem_0.Text != "")
			{
				if (buttonItem_0.Class261_0 == null)
				{
					sizeF = ((buttonItem_0.Orientation != eOrientation.Vertical || flag) ? ((SizeF)Class55.smethod_4(val2, Class265.smethod_0(buttonItem_0.Text), val3, num, eTextFormat2)) : ((SizeF)Class55.smethod_7(val2, Class265.smethod_0(buttonItem_0.Text), val3, new Size(num, 0), eTextFormat2)));
				}
				else
				{
					Size availableSize = new Size(num, 1);
					if (num == 0)
					{
						availableSize.Width = 1600;
					}
					Class263 @class = new Class263(val2, val3, Color.Empty, rightToLeft: false);
					@class.bool_0 = flag3;
					buttonItem_0.Class261_0.Measure(availableSize, @class);
					availableSize = buttonItem_0.Class261_0.Bounds.Size;
					buttonItem_0.Class261_0.method_2(new Rectangle(0, 0, availableSize.Width, availableSize.Height), @class);
					sizeF = buttonItem_0.Class261_0.Bounds.Size;
				}
			}
			if (buttonItem_0.Orientation == eOrientation.Horizontal && (eImagePosition2 == eImagePosition.Left || eImagePosition2 == eImagePosition.Right))
			{
				if (buttonItem_0.ButtonStyle != 0 || !flag2)
				{
					empty.Width += 4;
				}
				rectangle_2 = Rectangle.Empty;
				if (buttonItem_0.ButtonStyle != eButtonStyle.TextOnlyAlways && flag2)
				{
					rectangle_2 = ((eImagePosition2 == eImagePosition.Left) ? ((buttonX != null && buttonX.TextAlignment == eButtonTextAlignment.Left) ? new Rectangle(2, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height) : ((buttonX != null && buttonX.TextAlignment == eButtonTextAlignment.Right) ? new Rectangle(bounds.Width - (empty.Width + (int)Math.Ceiling(sizeF.Width) + 4), (bounds.Height - empty.Height) / 2, empty.Width, empty.Height) : ((buttonX == null) ? new Rectangle(0, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height) : new Rectangle((int)((float)bounds.Width - (sizeF.Width + (float)empty.Width)) / 2, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height)))) : ((buttonX != null && buttonX.TextAlignment == eButtonTextAlignment.Left) ? new Rectangle((int)sizeF.Width + 4, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height) : ((buttonX != null && buttonX.TextAlignment == eButtonTextAlignment.Right) ? new Rectangle(bounds.Width - empty.Width, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height) : ((buttonX == null) ? new Rectangle(bounds.Width - empty.Width, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height) : new Rectangle(bounds.Width - (int)((float)bounds.Width - (sizeF.Width + (float)empty.Width)) / 2 - empty.Width, (bounds.Height - empty.Height) / 2, empty.Width, empty.Height)))));
				}
				rectangle_ = Rectangle.Empty;
				if (buttonItem_0.ButtonStyle != 0 || !flag2)
				{
					rectangle_ = (flag2 ? ((eImagePosition2 == eImagePosition.Left) ? ((buttonX != null && buttonX.TextAlignment == eButtonTextAlignment.Center) ? new Rectangle(rectangle_2.Right + 1, (int)(((float)bounds.Height - sizeF.Height) / 2f), (int)sizeF.Width, (int)sizeF.Height) : ((buttonX == null || (buttonX.TextAlignment != eButtonTextAlignment.Right && buttonX.TextAlignment != 0)) ? new Rectangle(rectangle_2.Right + 1, (int)(((float)bounds.Height - sizeF.Height) / 2f), bounds.Width - 3 - rectangle_2.Width, (int)sizeF.Height) : new Rectangle(rectangle_2.Right + 1, (int)(((float)bounds.Height - sizeF.Height) / 2f), bounds.Width - 3 - rectangle_2.Width, (int)sizeF.Height))) : ((buttonX != null && buttonX.TextAlignment == eButtonTextAlignment.Center) ? new Rectangle((int)((float)rectangle_2.X - sizeF.Width) - 1, (int)(((float)bounds.Height - sizeF.Height) / 2f), (int)sizeF.Width, (int)sizeF.Height) : ((buttonX == null || buttonX.TextAlignment != eButtonTextAlignment.Right) ? new Rectangle(3, (int)(((float)bounds.Height - sizeF.Height) / 2f), rectangle_2.X - 2, (int)sizeF.Height) : new Rectangle(rectangle_2.X - ((int)sizeF.Width + 4), (int)(((float)bounds.Height - sizeF.Height) / 2f), (int)sizeF.Width + 2, (int)sizeF.Height)))) : (((buttonX == null || buttonX.TextAlignment != eButtonTextAlignment.Center) && !buttonItem_0.bool_45) ? new Rectangle(3, (int)(((float)bounds.Height - sizeF.Height) / 2f), bounds.Width - 6, (int)sizeF.Height) : new Rectangle((int)(((float)bounds.Width - sizeF.Width) / 2f), (int)(((float)bounds.Height - sizeF.Height) / 2f), (int)sizeF.Width, (int)sizeF.Height)));
				}
			}
			else if (buttonItem_0.Orientation == eOrientation.Horizontal)
			{
				if (eImagePosition2 == eImagePosition.Top)
				{
					rectangle_2 = new Rectangle(0, (int)((float)bounds.Height - ((float)empty.Height + sizeF.Height)) / 2, bounds.Width, empty.Height);
					rectangle_ = new Rectangle(0, rectangle_2.Bottom, (int)sizeF.Width, (int)sizeF.Height + 5);
				}
				else
				{
					rectangle_ = new Rectangle((int)((float)bounds.Width - sizeF.Width) / 2, (int)((float)bounds.Height - ((float)empty.Height + sizeF.Height)) / 2, (int)sizeF.Width, (int)sizeF.Height);
					rectangle_2 = new Rectangle(0, rectangle_.Bottom, bounds.Width, empty.Height + 5);
				}
			}
			else if (eImagePosition2 != eImagePosition.Top && eImagePosition2 != 0)
			{
				rectangle_ = new Rectangle((int)((float)bounds.Width - sizeF.Width) / 2, 0, (int)sizeF.Height, (int)sizeF.Width + 5);
				if (flag2)
				{
					rectangle_2 = new Rectangle(0, rectangle_.Bottom + 2, bounds.Width, empty.Height + 5);
				}
			}
			else
			{
				if (flag2)
				{
					rectangle_2 = new Rectangle(0, 0, bounds.Width, empty.Height + 6);
				}
				rectangle_ = new Rectangle((int)((float)bounds.Width - sizeF.Height) / 2, rectangle_2.Bottom + 2, (int)sizeF.Height, (int)sizeF.Width + 5);
			}
		}
		finally
		{
			val2.set_TextRenderingHint((TextRenderingHint)0);
			val2.set_SmoothingMode((SmoothingMode)0);
			val2.Dispose();
		}
		buttonItem_0.Rectangle_0 = rectangle_2;
		buttonItem_0.Rectangle_2 = rectangle_;
		buttonItem_0.Rectangle_1 = rectangle_3;
	}
}
