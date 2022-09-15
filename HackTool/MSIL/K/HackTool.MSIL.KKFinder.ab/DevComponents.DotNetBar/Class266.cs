using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

internal class Class266 : Class265
{
	protected virtual Color GetTextColor(ButtonItem button, ItemPaintArgs pa)
	{
		return Class272.smethod_0(button, pa);
	}

	public override void PaintButton(ButtonItem button, ItemPaintArgs pa)
	{
		bool flag;
		if ((flag = IsOnMenu(button, pa)) && button.Parent is ItemContainer)
		{
			flag = false;
		}
		bool isOnMenuBar = pa.IsOnMenuBar;
		bool boolean_ = button.Boolean_2;
		Graphics graphics = pa.Graphics;
		Region val = graphics.get_Clip().Clone();
		try
		{
			graphics.SetClip(button.DisplayRectangle, (CombineMode)1);
			if (!pa.IsOnMenu && !isOnMenuBar && boolean_)
			{
				if (pa.ContainerControl is ButtonX)
				{
					Class97.smethod_0(button, pa);
				}
				else
				{
					ThemedButtonItemPainter.PaintButton(button, pa);
				}
				return;
			}
			Rectangle displayRectangle = button.DisplayRectangle;
			Class271 @class = button.method_22();
			Rectangle imageRectangle = GetImageRectangle(button, pa, @class);
			PaintButtonBackground(button, pa, @class);
			Rectangle customizeMenuCheckRectangle = GetCustomizeMenuCheckRectangle(button, pa);
			Rectangle checkRectangle = GetCheckRectangle(button, pa, @class);
			Rectangle mouseOverRectangle = GetMouseOverRectangle(button, pa, @class);
			bool flag2 = button.IsMouseOver;
			if (button.Expanded && !flag)
			{
				flag2 = false;
			}
			if (flag && button.Expanded && pa.ContainerControl != null && pa.ContainerControl.get_Parent() != null && !pa.ContainerControl.get_Parent().get_Bounds().Contains(Control.get_MousePosition()))
			{
				flag2 = true;
			}
			if (button.HotTrackingStyle != eHotTrackingStyle.None && (flag2 || (button.IsMouseDown && !button.DesignMode)))
			{
				PaintButtonMouseOver(button, pa, @class, mouseOverRectangle);
			}
			if (flag && button.IsOnCustomizeMenu && button.Visible && !button.SystemItem)
			{
				PaintCustomizeCheck(button, pa, customizeMenuCheckRectangle);
			}
			if (button.Checked && !button.IsOnCustomizeMenu && (button.method_1(pa.ContainerControl) || flag))
			{
				PaintButtonCheck(button, pa, @class, checkRectangle);
			}
			if (@class != null && button.ButtonStyle != eButtonStyle.TextOnlyAlways)
			{
				PaintButtonImage(button, pa, @class, imageRectangle);
			}
			Color textColor = GetTextColor(button, pa);
			if (!(button is Office2007StartButton))
			{
				PaintButtonText(button, pa, textColor, @class);
			}
			PaintExpandButton(button, pa);
			if (button.Focused && button.DesignMode)
			{
				Rectangle rectangle_ = displayRectangle;
				rectangle_.Inflate(-1, -1);
				Class32.smethod_0(graphics, rectangle_, pa.Colors.ItemDesignTimeBorder);
			}
			@class?.Dispose();
		}
		finally
		{
			if (val != null)
			{
				graphics.set_Clip(val);
			}
			else
			{
				graphics.ResetClip();
			}
		}
	}

	protected virtual bool IsOnMenu(ButtonItem button, ItemPaintArgs pa)
	{
		bool result;
		if ((result = pa.IsOnMenu) && button.Parent is ItemContainer)
		{
			result = false;
		}
		return result;
	}

	public override void PaintButtonImage(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle imagebounds)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		if (IsOnMenu(button, pa))
		{
			image.method_0(pa.Graphics, imagebounds);
		}
		else if (!button.IsMouseOver && button.HotTrackingStyle == eHotTrackingStyle.Color)
		{
			ColorMatrix colorMatrix = new ColorMatrix(new float[5][]
			{
				new float[5] { 0.2125f, 0.2125f, 0.2125f, 0f, 0f },
				new float[5] { 0.5f, 0.5f, 0.5f, 0f, 0f },
				new float[5] { 0.0361f, 0.0361f, 0.0361f, 0f, 0f },
				new float[5] { 0f, 0f, 0f, 1f, 0f },
				new float[5] { 0.2f, 0.2f, 0.2f, 0f, 1f }
			});
			ImageAttributes val = new ImageAttributes();
			val.SetColorMatrix(colorMatrix);
			image.method_2(pa.Graphics, imagebounds, 0, 0, image.Int32_0, image.Int32_1, (GraphicsUnit)2, val);
		}
		else
		{
			image.method_0(pa.Graphics, imagebounds);
		}
	}

	public override Rectangle GetImageRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		Rectangle result = Rectangle.Empty;
		bool flag = IsOnMenu(button, pa);
		if (image != null)
		{
			Size imageSize = button.ImageSize;
			if (pa.RightToLeft && flag)
			{
				result = new Rectangle(button.DisplayRectangle.Right - (button.Rectangle_0.X + imageSize.Width + 2), button.Rectangle_0.Y + button.DisplayRectangle.Y, imageSize.Width, imageSize.Height);
			}
			else
			{
				result = ((flag || (button.ImagePosition != eImagePosition.Top && button.ImagePosition != eImagePosition.Bottom)) ? new Rectangle(button.Rectangle_0.X, button.Rectangle_0.Y, button.Rectangle_0.Width, button.Rectangle_0.Height) : new Rectangle(button.Rectangle_0.X, button.Rectangle_0.Y, button.DisplayRectangle.Width, button.Rectangle_0.Height));
				result.Offset(button.DisplayRectangle.Left, button.DisplayRectangle.Top);
				result.Offset((result.Width - imageSize.Width) / 2, (result.Height - imageSize.Height) / 2);
				result.Width = imageSize.Width;
				result.Height = imageSize.Height;
			}
		}
		return result;
	}

	public override Rectangle GetCheckRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		Rectangle result = Rectangle.Empty;
		if (IsOnMenu(button, pa))
		{
			if (pa.RightToLeft)
			{
				result = new Rectangle(button.DisplayRectangle.Right - button.Rectangle_0.Width + 1, button.DisplayRectangle.Y, button.Rectangle_0.Width - 2, button.DisplayRectangle.Height);
				result.Inflate(-1, -1);
			}
			else
			{
				result = new Rectangle(button.DisplayRectangle.X, button.DisplayRectangle.Y, button.Rectangle_0.Width - 2, button.DisplayRectangle.Height);
				result.Inflate(-1, -1);
			}
		}
		else if (button.HotTrackingStyle == eHotTrackingStyle.Image && image != null)
		{
			result = GetImageRectangle(button, pa, image);
			result.Inflate(2, 2);
		}
		else
		{
			result = button.DisplayRectangle;
		}
		return result;
	}

	public override Rectangle GetCustomizeMenuCheckRectangle(ButtonItem button, ItemPaintArgs pa)
	{
		bool flag = IsOnMenu(button, pa);
		Rectangle result = Rectangle.Empty;
		if (flag && button.IsOnCustomizeMenu && button.Visible && !button.SystemItem)
		{
			result = new Rectangle(button.DisplayRectangle.Left, button.DisplayRectangle.Top, button.DisplayRectangle.Height, button.DisplayRectangle.Height);
			result.Inflate(-1, -1);
		}
		return result;
	}

	public override void PaintCustomizeCheck(ButtonItem button, ItemPaintArgs pa, Rectangle r)
	{
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		Color color = pa.Colors.ItemCheckedBackground;
		Graphics graphics = pa.Graphics;
		if (button.IsMouseOver && !pa.Colors.ItemHotBackground2.IsEmpty)
		{
			LinearGradientBrush val = Class109.smethod_40(r, pa.Colors.ItemHotBackground, pa.Colors.ItemHotBackground2, pa.Colors.ItemHotBackgroundGradientAngle);
			try
			{
				graphics.FillRectangle((Brush)(object)val, r);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			if (button.IsMouseOver)
			{
				color = pa.Colors.ItemHotBackground;
			}
			if (!pa.Colors.ItemCheckedBackground2.IsEmpty && !button.IsMouseOver)
			{
				LinearGradientBrush val2 = Class109.smethod_40(r, pa.Colors.ItemCheckedBackground, pa.Colors.ItemCheckedBackground2, pa.Colors.ItemCheckedBackgroundGradientAngle);
				try
				{
					graphics.FillRectangle((Brush)(object)val2, r);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			else
			{
				SolidBrush val3 = new SolidBrush(color);
				try
				{
					graphics.FillRectangle((Brush)(object)val3, r);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
		}
		Pen val4 = new Pen(pa.Colors.ItemCheckedBorder, 1f);
		Class50.smethod_8(graphics, val4, r);
		val4.Dispose();
		val4 = new Pen(pa.Colors.ItemCheckedText);
		Point[] array = new Point[3];
		array[0].X = r.Left + (r.Width - 5) / 2 - 1;
		array[0].Y = r.Top + (r.Height - 6) / 2 + 3;
		array[1].X = array[0].X + 2;
		array[1].Y = array[0].Y + 2;
		array[2].X = array[1].X + 4;
		array[2].Y = array[1].Y - 4;
		graphics.DrawLines(val4, array);
		array[0].X++;
		array[1].X++;
		array[2].X++;
		graphics.DrawLines(val4, array);
		val4.Dispose();
	}

	public override void PaintButtonMouseOver(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		bool isMouseDown = button.IsMouseDown;
		bool flag = IsOnMenu(button, pa);
		Graphics graphics = pa.Graphics;
		Brush val = null;
		Pen val2 = null;
		if (isMouseDown && !flag)
		{
			val = (Brush)((!pa.Colors.ItemPressedBackground2.IsEmpty) ? ((object)Class109.smethod_40(r, pa.Colors.ItemPressedBackground, pa.Colors.ItemPressedBackground2, pa.Colors.ItemPressedBackgroundGradientAngle)) : ((object)new SolidBrush(pa.Colors.ItemPressedBackground)));
			val2 = new Pen(pa.Colors.ItemPressedBorder, 1f);
		}
		else if (Class265.smethod_1(button, pa))
		{
			val = (Brush)(pa.Colors.ItemHotBackground2.IsEmpty ? ((object)new SolidBrush(pa.Colors.ItemHotBackground)) : ((object)Class109.smethod_40(r, pa.Colors.ItemHotBackground, pa.Colors.ItemHotBackground2, pa.Colors.ItemHotBackgroundGradientAngle)));
			val2 = new Pen(pa.Colors.ItemHotBorder, 1f);
		}
		else if (flag)
		{
			val2 = new Pen(pa.Colors.ItemHotBorder, 1f);
		}
		if (val != null)
		{
			graphics.FillRectangle(val, r);
		}
		if (val2 != null)
		{
			Class50.smethod_8(graphics, val2, r);
		}
		if (val != null)
		{
			val.Dispose();
		}
		if (val2 != null)
		{
			val2.Dispose();
		}
	}

	protected virtual void PaintButtonCheckBackground(ButtonItem button, ItemPaintArgs pa, Rectangle r)
	{
		Graphics graphics = pa.Graphics;
		bool flag = IsOnMenu(button, pa);
		if (!button.IsMouseOver || flag)
		{
			Class50.smethod_26(graphics, r, pa.Colors.ItemCheckedBackground, pa.Colors.ItemCheckedBackground2, pa.Colors.ItemCheckedBackgroundGradientAngle);
			Class50.smethod_6(graphics, pa.Colors.ItemCheckedBorder, r);
		}
	}

	public override void PaintButtonCheck(ButtonItem button, ItemPaintArgs pa, Class271 image, Rectangle r)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		if (r.IsEmpty)
		{
			return;
		}
		bool flag = IsOnMenu(button, pa);
		Graphics graphics = pa.Graphics;
		PaintButtonCheckBackground(button, pa, r);
		if ((image != null && button.ButtonStyle != eButtonStyle.TextOnlyAlways) || !flag)
		{
			return;
		}
		Pen val = new Pen(Class265.smethod_1(button, pa) ? pa.Colors.ItemCheckedText : pa.Colors.ItemDisabledText);
		try
		{
			Point[] array = new Point[3];
			array[0].X = r.Left + (r.Width - 5) / 2 - 1;
			array[0].Y = r.Top + (r.Height - 6) / 2 + 3;
			array[1].X = array[0].X + 2;
			array[1].Y = array[0].Y + 2;
			array[2].X = array[1].X + 4;
			array[2].Y = array[1].Y - 4;
			graphics.DrawLines(val, array);
			array[0].X++;
			array[1].X++;
			array[2].X++;
			graphics.DrawLines(val, array);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public override Rectangle GetMouseOverRectangle(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		Rectangle displayRectangle = button.DisplayRectangle;
		if (button.HotTrackingStyle != eHotTrackingStyle.None && button.HotTrackingStyle != eHotTrackingStyle.Color)
		{
			if (button.HotTrackingStyle == eHotTrackingStyle.Image && image != null)
			{
				displayRectangle = GetImageRectangle(button, pa, image);
				displayRectangle.Inflate(2, 2);
				return displayRectangle;
			}
			if (IsOnMenu(button, pa))
			{
				displayRectangle.X++;
				displayRectangle.Width -= 2;
			}
			return displayRectangle;
		}
		return Rectangle.Empty;
	}

	public override eTextFormat GetStringFormat(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		eTextFormat eTextFormat2 = pa.ButtonStringFormat;
		if (!IsOnMenu(button, pa))
		{
			if ((pa.ContainerControl is RibbonStrip && (image == null || button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)) || button.bool_45)
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			else if (pa.ContainerControl is ButtonX)
			{
				ButtonX buttonX = pa.ContainerControl as ButtonX;
				if (buttonX.TextAlignment == eButtonTextAlignment.Center)
				{
					eTextFormat2 |= eTextFormat.HorizontalCenter;
				}
				else if (buttonX.TextAlignment == eButtonTextAlignment.Left)
				{
					eTextFormat2 = eTextFormat2;
				}
				else if (buttonX.TextAlignment == eButtonTextAlignment.Right && (image == null || button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom))
				{
					eTextFormat2 |= eTextFormat.Right;
				}
			}
			else if (pa.IsOnMenuBar || ((pa.ContainerControl is Bar || pa.ContainerControl is ButtonX || button.Orientation == eOrientation.Vertical) && image == null) || button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			if (pa.ContainerControl is RibbonBar && image != null && button.ImagePosition == eImagePosition.Top)
			{
				eTextFormat2 |= eTextFormat.WordBreak;
			}
		}
		if (pa.RightToLeft)
		{
			eTextFormat2 |= eTextFormat.RightToLeft;
		}
		return eTextFormat2;
	}

	protected virtual bool IsTextCentered(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		if (!IsOnMenu(button, pa))
		{
			Control containerControl = pa.ContainerControl;
			if ((containerControl is RibbonStrip && (image == null || button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)) || button.Name.StartsWith("sysgallery") || button.bool_45)
			{
				return true;
			}
			if (containerControl is ButtonX)
			{
				ButtonX buttonX = containerControl as ButtonX;
				if (buttonX.TextAlignment == eButtonTextAlignment.Center)
				{
					return true;
				}
			}
			else if (pa.IsOnMenuBar || (containerControl is Bar && image == null) || button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)
			{
				return true;
			}
		}
		return false;
	}

	protected virtual Rectangle GetTextRectangle(ButtonItem button, ItemPaintArgs pa, eTextFormat stringFormat, Class271 image)
	{
		bool flag = IsOnMenu(button, pa);
		bool isOnMenuBar = pa.IsOnMenuBar;
		Rectangle displayRectangle = button.DisplayRectangle;
		Rectangle result = button.Rectangle_2;
		Rectangle rectangle_ = button.Rectangle_0;
		bool rightToLeft = pa.RightToLeft;
		if (flag || button.ButtonStyle != 0 || image == null || (!flag && (button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)))
		{
			if (flag)
			{
				result = ((!rightToLeft) ? new Rectangle(result.X, result.Y, displayRectangle.Width - rectangle_.Right - 26, result.Height) : ((!button.IsOnCustomizeMenu) ? new Rectangle(17, result.Y, displayRectangle.Width - rectangle_.Width - 28, result.Height) : new Rectangle(displayRectangle.Height, result.Y, displayRectangle.Width - rectangle_.Width - 11 - displayRectangle.Height, result.Height)));
			}
			else if ((button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom) && button.Orientation != eOrientation.Vertical)
			{
				result = new Rectangle(0, result.Y, displayRectangle.Width, result.Height);
				if (button.SplitButton)
				{
					result.Y += 3;
				}
			}
			if (image == null && (stringFormat & eTextFormat.HorizontalCenter) != eTextFormat.HorizontalCenter && !flag && !isOnMenuBar && result.X == 0 && !pa.RightToLeft)
			{
				result.X = 3;
			}
			result.Offset(displayRectangle.Left, displayRectangle.Top);
			if (button.Orientation == eOrientation.Vertical && !flag)
			{
				if (result.Bottom > displayRectangle.Bottom)
				{
					result.Height = displayRectangle.Bottom - result.Y;
				}
			}
			else if (result.Right > displayRectangle.Right)
			{
				result.Width = displayRectangle.Right - result.Left;
			}
		}
		return result;
	}

	public override void PaintButtonText(ButtonItem button, ItemPaintArgs pa, Color textColor, Class271 image)
	{
		if (!button.bool_14)
		{
			return;
		}
		Graphics graphics = pa.Graphics;
		eTextFormat stringFormat = GetStringFormat(button, pa, image);
		bool flag = IsOnMenu(button, pa);
		bool isOnMenuBar = pa.IsOnMenuBar;
		Rectangle displayRectangle = button.DisplayRectangle;
		Rectangle textRectangle = GetTextRectangle(button, pa, stringFormat, image);
		Font val = button.method_40(pa);
		bool rightToLeft = pa.RightToLeft;
		if (flag || button.ButtonStyle != 0 || image == null || (!flag && (button.ImagePosition == eImagePosition.Top || button.ImagePosition == eImagePosition.Bottom)))
		{
			if (button.Orientation == eOrientation.Vertical && !flag)
			{
				graphics.RotateTransform(90f);
				if (button.Class261_0 == null)
				{
					Class55.smethod_2(graphics, Class265.smethod_0(button.Text), val, textColor, new Rectangle(textRectangle.Top, -textRectangle.Right, textRectangle.Height, textRectangle.Width), stringFormat);
				}
				else
				{
					Class263 @class = new Class263(graphics, val, textColor, rightToLeft);
					@class.bool_3 = (stringFormat & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
					button.Class261_0.Bounds = new Rectangle(textRectangle.Top, -textRectangle.Right, button.Class261_0.Bounds.Width, button.Class261_0.Bounds.Height);
					button.Class261_0.Render(@class);
				}
				graphics.ResetTransform();
			}
			else
			{
				if (button.Class261_0 == null)
				{
					if (pa.GlassEnabled && button.Parent is Class181)
					{
						if (!pa.bool_0)
						{
							Class169.smethod_0(graphics, button.Text, val, textRectangle, Class55.smethod_12(stringFormat));
						}
					}
					else
					{
						Class55.smethod_1(graphics, Class265.smethod_0(button.Text), val, textColor, textRectangle, stringFormat);
					}
				}
				else
				{
					Class263 class2 = new Class263(graphics, val, textColor, rightToLeft);
					class2.bool_3 = (stringFormat & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
					class2.object_0 = button;
					Rectangle bounds = new Rectangle((!rightToLeft || !flag) ? textRectangle.X : (textRectangle.X + textRectangle.Width - button.Class261_0.Bounds.Width), textRectangle.Y + (textRectangle.Height - button.Class261_0.Bounds.Height) / 2 + 1, button.Class261_0.Bounds.Width, button.Class261_0.Bounds.Height);
					if (IsTextCentered(button, pa, image))
					{
						bounds.Offset((textRectangle.Width - bounds.Width) / 2, 0);
					}
					if (button.bool_45)
					{
						bounds.Y--;
					}
					button.Class261_0.Bounds = bounds;
					button.Class261_0.Render(class2);
				}
				if (!button.DesignMode && button.Focused && !flag && !isOnMenuBar && (!(pa.ContainerControl is ButtonX) || ((ButtonX)(object)pa.ContainerControl).FocusCuesEnabled))
				{
					Rectangle rectangle = displayRectangle;
					rectangle.Inflate(-2, -2);
					ControlPaint.DrawFocusRectangle(graphics, rectangle);
				}
			}
		}
		if (button.String_1 != "" && flag && !button.IsOnCustomizeDialog)
		{
			stringFormat |= eTextFormat.HidePrefix;
			stringFormat |= eTextFormat.Right;
			Class55.smethod_1(graphics, button.String_1, val, textColor, textRectangle, stringFormat);
		}
	}

	protected virtual Rectangle GetTotalSubItemsRect(ButtonItem button)
	{
		return button.method_42();
	}

	public override void PaintExpandButton(ButtonItem button, ItemPaintArgs pa)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		Graphics graphics = pa.Graphics;
		bool flag = IsOnMenu(button, pa);
		Rectangle displayRectangle = button.DisplayRectangle;
		bool isMouseOver = button.IsMouseOver;
		Color textColor = GetTextColor(button, pa);
		SolidBrush val = new SolidBrush(textColor);
		try
		{
			if ((button.SubItems.Count <= 0 && button.PopupType != ePopupType.Container) || !button.ShowSubItems)
			{
				return;
			}
			if (flag)
			{
				Point[] array = new Point[3];
				if (pa.RightToLeft)
				{
					array[0].X = displayRectangle.Left + 8;
					array[0].Y = displayRectangle.Top + (displayRectangle.Height - 8) / 2;
					array[1].X = array[0].X;
					array[1].Y = array[0].Y + 8;
					array[2].X = array[0].X - 4;
					array[2].Y = array[0].Y + 4;
				}
				else
				{
					array[0].X = displayRectangle.Left + displayRectangle.Width - 12;
					array[0].Y = displayRectangle.Top + (displayRectangle.Height - 8) / 2;
					array[1].X = array[0].X;
					array[1].Y = array[0].Y + 8;
					array[2].X = array[0].X + 4;
					array[2].Y = array[0].Y + 4;
				}
				graphics.FillPolygon((Brush)(object)val, array);
			}
			else
			{
				if (button.Rectangle_1.IsEmpty)
				{
					return;
				}
				if (Class265.smethod_1(button, pa) && (isMouseOver || button.Checked) && !button.Expanded && button.HotTrackingStyle != eHotTrackingStyle.None && button.HotTrackingStyle != eHotTrackingStyle.Image && !button.AutoExpandOnClick)
				{
					Rectangle totalSubItemsRect = GetTotalSubItemsRect(button);
					totalSubItemsRect.Offset(displayRectangle.Location);
					Pen val2 = new Pen(isMouseOver ? pa.Colors.ItemHotBorder : pa.Colors.ItemCheckedBorder);
					try
					{
						Class50.smethod_8(graphics, val2, totalSubItemsRect);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				Class265.smethod_3(button, pa);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected virtual void PaintMenuItemSide(ButtonItem button, ItemPaintArgs pa, Rectangle sideRect)
	{
		Graphics graphics = pa.Graphics;
		Region val = graphics.get_Clip().Clone();
		graphics.SetClip(sideRect);
		sideRect.Inflate(0, 1);
		if (button.MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !button.RecentlyUsed)
		{
			Class50.smethod_26(graphics, sideRect, pa.Colors.MenuUnusedSide, pa.Colors.MenuUnusedSide2, pa.Colors.MenuUnusedSideGradientAngle);
		}
		else
		{
			Class50.smethod_26(graphics, sideRect, pa.Colors.MenuSide, pa.Colors.MenuSide2, pa.Colors.MenuSideGradientAngle);
		}
		if (val != null)
		{
			graphics.set_Clip(val);
		}
		else
		{
			graphics.ResetClip();
		}
	}

	public override void PaintButtonBackground(ButtonItem button, ItemPaintArgs pa, Class271 image)
	{
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		Graphics graphics = pa.Graphics;
		bool flag;
		if (flag = IsOnMenu(button, pa))
		{
			Rectangle sideRect = new Rectangle(button.DisplayRectangle.Left, button.DisplayRectangle.Top, button.Rectangle_0.Right, button.DisplayRectangle.Height);
			if (pa.RightToLeft)
			{
				sideRect = new Rectangle(button.DisplayRectangle.Right - button.Rectangle_0.Right, button.DisplayRectangle.Top, button.Rectangle_0.Right, button.DisplayRectangle.Height);
			}
			PaintMenuItemSide(button, pa, sideRect);
		}
		else if (!pa.Colors.ItemBackground.IsEmpty)
		{
			if (pa.Colors.ItemBackground2.IsEmpty)
			{
				SolidBrush val = new SolidBrush(pa.Colors.ItemBackground);
				try
				{
					graphics.FillRectangle((Brush)(object)val, button.DisplayRectangle);
				}
				finally
				{
					((IDisposable)val)?.Dispose();
				}
			}
			else
			{
				LinearGradientBrush val2 = Class109.smethod_40(button.DisplayRectangle, pa.Colors.ItemBackground, pa.Colors.ItemBackground2, pa.Colors.ItemBackgroundGradientAngle);
				try
				{
					graphics.FillRectangle((Brush)(object)val2, button.DisplayRectangle);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		else if (!Class265.smethod_1(button, pa) && !pa.Colors.ItemDisabledBackground.IsEmpty)
		{
			SolidBrush val3 = new SolidBrush(pa.Colors.ItemDisabledBackground);
			try
			{
				graphics.FillRectangle((Brush)(object)val3, button.DisplayRectangle);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		Rectangle displayRectangle = button.DisplayRectangle;
		if ((!Class265.smethod_1(button, pa) && !button.DesignMode) || !button.Expanded || flag)
		{
			return;
		}
		if (pa.Colors.ItemExpandedBackground2.IsEmpty)
		{
			Rectangle displayRectangle2 = button.DisplayRectangle;
			if (!pa.Colors.ItemExpandedShadow.IsEmpty)
			{
				displayRectangle2.Width -= 2;
			}
			SolidBrush val4 = new SolidBrush(pa.Colors.ItemExpandedBackground);
			try
			{
				graphics.FillRectangle((Brush)(object)val4, displayRectangle2);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		else
		{
			LinearGradientBrush val5 = Class109.smethod_40(new Rectangle(displayRectangle.Left, displayRectangle.Top, displayRectangle.Width - 2, displayRectangle.Height), pa.Colors.ItemExpandedBackground, pa.Colors.ItemExpandedBackground2, pa.Colors.ItemExpandedBackgroundGradientAngle);
			Rectangle rectangle = new Rectangle(displayRectangle.Left, displayRectangle.Top, displayRectangle.Width, displayRectangle.Height);
			if (!pa.Colors.ItemExpandedShadow.IsEmpty)
			{
				rectangle.Width -= 2;
			}
			graphics.FillRectangle((Brush)(object)val5, rectangle);
			((Brush)val5).Dispose();
		}
		Point[] array = ((button.Orientation != 0 || button.PopupSide != 0) ? new Point[5] : new Point[4]);
		array[0].X = displayRectangle.Left;
		array[0].Y = displayRectangle.Top + displayRectangle.Height - 1;
		array[1].X = displayRectangle.Left;
		array[1].Y = displayRectangle.Top;
		if (button.Orientation == eOrientation.Horizontal)
		{
			if (!pa.Colors.ItemExpandedShadow.IsEmpty)
			{
				array[2].X = displayRectangle.Left + displayRectangle.Width - 3;
			}
			else
			{
				array[2].X = displayRectangle.Right - 1;
			}
		}
		else
		{
			array[2].X = displayRectangle.Left + displayRectangle.Width - 1;
		}
		array[2].Y = displayRectangle.Top;
		if (button.Orientation == eOrientation.Horizontal)
		{
			if (!pa.Colors.ItemExpandedShadow.IsEmpty)
			{
				array[3].X = displayRectangle.Left + displayRectangle.Width - 3;
			}
			else
			{
				array[3].X = displayRectangle.Right - 1;
			}
		}
		else
		{
			array[3].X = displayRectangle.Left + displayRectangle.Width - 1;
		}
		array[3].Y = displayRectangle.Top + displayRectangle.Height - 1;
		if (button.Orientation == eOrientation.Vertical || button.PopupSide != 0)
		{
			array[4].X = displayRectangle.Left;
			array[4].Y = displayRectangle.Top + displayRectangle.Height - 1;
		}
		if (!pa.Colors.ItemExpandedBorder.IsEmpty)
		{
			Pen val6 = new Pen(pa.Colors.ItemExpandedBorder, 1f);
			try
			{
				graphics.DrawLines(val6, array);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		if (!pa.Colors.ItemExpandedShadow.IsEmpty && button.Orientation == eOrientation.Horizontal)
		{
			SolidBrush val7 = new SolidBrush(pa.Colors.ItemExpandedShadow);
			try
			{
				graphics.FillRectangle((Brush)(object)val7, displayRectangle.Left + displayRectangle.Width - 2, displayRectangle.Top + 2, 2, displayRectangle.Height - 2);
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
	}
}
