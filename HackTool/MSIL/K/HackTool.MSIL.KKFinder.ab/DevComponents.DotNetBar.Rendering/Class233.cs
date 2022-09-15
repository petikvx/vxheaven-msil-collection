using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar.Rendering;

internal class Class233 : Class232, Interface3
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

	public override void Paint(SliderItemRendererEventArgs e)
	{
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_070c: Unknown result type (might be due to invalid IL or missing references)
		Office2007SliderColorTable slider = office2007ColorTable_0.Slider;
		SliderItem sliderItem = e.SliderItem;
		Office2007SliderStateColorTable office2007SliderStateColorTable = null;
		Office2007SliderStateColorTable office2007SliderStateColorTable2 = null;
		Office2007SliderStateColorTable office2007SliderStateColorTable3 = null;
		if (sliderItem.method_2())
		{
			office2007SliderStateColorTable = slider.Default;
			office2007SliderStateColorTable2 = slider.Default;
			office2007SliderStateColorTable3 = slider.Default;
			if (sliderItem.MouseDownPart == eSliderPart.DecreaseButton)
			{
				office2007SliderStateColorTable = slider.Pressed;
			}
			else if (sliderItem.MouseDownPart == eSliderPart.IncreaseButton)
			{
				office2007SliderStateColorTable2 = slider.Pressed;
			}
			else if (sliderItem.MouseDownPart == eSliderPart.TrackArea)
			{
				office2007SliderStateColorTable3 = slider.Pressed;
			}
			else if (sliderItem.ESliderPart_0 == eSliderPart.DecreaseButton)
			{
				office2007SliderStateColorTable = slider.MouseOver;
			}
			else if (sliderItem.ESliderPart_0 == eSliderPart.IncreaseButton)
			{
				office2007SliderStateColorTable2 = slider.MouseOver;
			}
			else if (sliderItem.ESliderPart_0 == eSliderPart.TrackArea)
			{
				office2007SliderStateColorTable3 = slider.MouseOver;
			}
		}
		else
		{
			office2007SliderStateColorTable = slider.Disabled;
			office2007SliderStateColorTable2 = slider.Disabled;
			office2007SliderStateColorTable3 = slider.Disabled;
		}
		Rectangle displayRectangle = sliderItem.DisplayRectangle;
		Rectangle rectangle_ = sliderItem.Rectangle_0;
		Graphics graphics = e.Graphics;
		string text = method_0(sliderItem);
		if (!rectangle_.IsEmpty && text.Length > 0)
		{
			rectangle_.Offset(displayRectangle.Location);
			eTextFormat eTextFormat = eTextFormat.WordEllipsis;
			if (sliderItem.LabelPosition == eSliderLabelPosition.Left)
			{
				eTextFormat |= eTextFormat.VerticalCenter;
			}
			else if (sliderItem.LabelPosition == eSliderLabelPosition.Right)
			{
				eTextFormat |= eTextFormat.Right | eTextFormat.VerticalCenter;
			}
			else if (sliderItem.LabelPosition == eSliderLabelPosition.Top)
			{
				eTextFormat |= eTextFormat.HorizontalCenter | eTextFormat.WordBreak;
			}
			else if (sliderItem.LabelPosition == eSliderLabelPosition.Bottom)
			{
				eTextFormat |= eTextFormat.Bottom | eTextFormat.HorizontalCenter | eTextFormat.WordBreak;
			}
			Color color = office2007SliderStateColorTable3.LabelColor;
			if (!sliderItem.TextColor.IsEmpty)
			{
				color = sliderItem.TextColor;
			}
			if (sliderItem.Class261_0 == null)
			{
				if (e.itemPaintArgs_0 != null && e.itemPaintArgs_0.GlassEnabled && sliderItem.Parent is Class181)
				{
					if (!e.itemPaintArgs_0.bool_0)
					{
						Class169.smethod_0(graphics, method_0(sliderItem), e.itemPaintArgs_0.Font, rectangle_, Class55.smethod_12(eTextFormat));
					}
				}
				else if (sliderItem.SliderOrientation == eOrientation.Vertical)
				{
					graphics.RotateTransform(90f);
					Class55.smethod_1(graphics, method_0(sliderItem), e.itemPaintArgs_0.Font, color, new Rectangle(rectangle_.Top, -rectangle_.Right, rectangle_.Height, rectangle_.Width), eTextFormat);
					graphics.ResetTransform();
				}
				else
				{
					Class55.smethod_1(graphics, method_0(sliderItem), e.itemPaintArgs_0.Font, color, rectangle_, eTextFormat);
				}
			}
			else if (sliderItem.SliderOrientation == eOrientation.Vertical)
			{
				graphics.RotateTransform(90f);
				Class263 @class = new Class263(graphics, e.itemPaintArgs_0.Font, color, e.itemPaintArgs_0.RightToLeft);
				@class.bool_3 = (eTextFormat & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
				sliderItem.Class261_0.Bounds = new Rectangle(rectangle_.Top, -rectangle_.Right, sliderItem.Class261_0.Bounds.Width, sliderItem.Class261_0.Bounds.Height);
				sliderItem.Class261_0.Render(@class);
				graphics.ResetTransform();
			}
			else
			{
				Class263 class2 = new Class263(graphics, e.itemPaintArgs_0.Font, color, e.itemPaintArgs_0.RightToLeft);
				class2.bool_3 = (eTextFormat & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
				sliderItem.Class261_0.Bounds = rectangle_;
				sliderItem.Class261_0.Render(class2);
			}
		}
		rectangle_ = sliderItem.Rectangle_3;
		if (!rectangle_.IsEmpty)
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			graphics.set_SmoothingMode((SmoothingMode)3);
			rectangle_.Offset(displayRectangle.Location);
			if (sliderItem.SliderOrientation == eOrientation.Horizontal)
			{
				int num = rectangle_.Y + rectangle_.Height / 2 - 1;
				int num2 = rectangle_.X + rectangle_.Width / 2;
				if (!office2007SliderStateColorTable3.TrackLineColor.IsEmpty)
				{
					Pen val = new Pen(office2007SliderStateColorTable3.TrackLineColor);
					try
					{
						graphics.DrawLine(val, rectangle_.X - 1, num, rectangle_.Right, num);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				if (!office2007SliderStateColorTable3.TrackLineLightColor.IsEmpty)
				{
					num++;
					num2++;
					Pen val2 = new Pen(office2007SliderStateColorTable3.TrackLineLightColor);
					try
					{
						if (sliderItem.TrackMarker)
						{
							graphics.DrawLine(val2, num2, num - 3, num2, num + 3);
						}
						graphics.DrawLine(val2, rectangle_.X - 1, num, rectangle_.Right, num);
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
				}
				if (!office2007SliderStateColorTable3.TrackLineColor.IsEmpty && sliderItem.TrackMarker)
				{
					num--;
					num2--;
					Pen val3 = new Pen(office2007SliderStateColorTable3.TrackLineColor);
					try
					{
						graphics.DrawLine(val3, num2, num - 3, num2, num + 3);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				graphics.set_SmoothingMode(smoothingMode);
				int num3 = 0;
				num3 = ((!e.itemPaintArgs_0.RightToLeft) ? ((int)((float)(rectangle_.Width - 11) * ((sliderItem.Maximum - sliderItem.Minimum == 0) ? 0f : ((float)(sliderItem.Value - sliderItem.Minimum) / (float)(sliderItem.Maximum - sliderItem.Minimum))))) : ((int)((float)(rectangle_.Width - 11) * (1f - ((sliderItem.Maximum - sliderItem.Minimum == 0) ? 0f : ((float)(sliderItem.Value - sliderItem.Minimum) / (float)(sliderItem.Maximum - sliderItem.Minimum)))))));
				Rectangle rectangle = rectangle_;
				rectangle.X += num3;
				rectangle.Width = 11;
				rectangle.Height = 15;
				rectangle.Y += (rectangle_.Height - rectangle.Height) / 2;
				method_2(office2007SliderStateColorTable3, rectangle, graphics, eSliderPart.TrackArea, sliderItem.SliderOrientation);
				sliderItem.Rectangle_4 = rectangle;
			}
			else
			{
				int num4 = rectangle_.X + rectangle_.Width / 2 - 1;
				int num5 = rectangle_.Y + rectangle_.Height / 2;
				if (!office2007SliderStateColorTable3.TrackLineColor.IsEmpty)
				{
					Pen val4 = new Pen(office2007SliderStateColorTable3.TrackLineColor);
					try
					{
						graphics.DrawLine(val4, num4, rectangle_.Y - 1, num4, rectangle_.Bottom);
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
				}
				if (!office2007SliderStateColorTable3.TrackLineLightColor.IsEmpty)
				{
					num4++;
					num5++;
					Pen val5 = new Pen(office2007SliderStateColorTable3.TrackLineLightColor);
					try
					{
						if (sliderItem.TrackMarker)
						{
							graphics.DrawLine(val5, num4 - 3, num5, num4 + 3, num5);
						}
						graphics.DrawLine(val5, num4, rectangle_.Y - 1, num4, rectangle_.Bottom);
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
				}
				if (!office2007SliderStateColorTable3.TrackLineColor.IsEmpty && sliderItem.TrackMarker)
				{
					num4--;
					num5--;
					Pen val6 = new Pen(office2007SliderStateColorTable3.TrackLineColor);
					try
					{
						graphics.DrawLine(val6, num4 - 3, num5, num4 + 3, num5);
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
				}
				graphics.set_SmoothingMode(smoothingMode);
				int num6 = 0;
				num6 = rectangle_.Height - 16 - (int)((float)(rectangle_.Height - 11) * ((sliderItem.Maximum - sliderItem.Minimum == 0) ? 0f : ((float)(sliderItem.Value - sliderItem.Minimum) / (float)(sliderItem.Maximum - sliderItem.Minimum))));
				Rectangle rectangle2 = rectangle_;
				rectangle2.Y += num6;
				rectangle2.Width = 15;
				rectangle2.Height = 11;
				rectangle2.X += (rectangle_.Width - rectangle2.Width) / 2;
				method_2(office2007SliderStateColorTable3, rectangle2, graphics, eSliderPart.TrackArea, sliderItem.SliderOrientation);
				sliderItem.Rectangle_4 = rectangle2;
			}
		}
		rectangle_ = sliderItem.Rectangle_1;
		if (!rectangle_.IsEmpty)
		{
			rectangle_.Offset(displayRectangle.Location);
			rectangle_.Width--;
			rectangle_.Height--;
			method_1(office2007SliderStateColorTable, rectangle_, graphics, eSliderPart.DecreaseButton);
		}
		rectangle_ = sliderItem.Rectangle_2;
		if (!rectangle_.IsEmpty)
		{
			rectangle_.Offset(displayRectangle.Location);
			rectangle_.Width--;
			rectangle_.Height--;
			method_1(office2007SliderStateColorTable2, rectangle_, graphics, eSliderPart.IncreaseButton);
		}
		base.Paint(e);
	}

	private string method_0(SliderItem sliderItem_0)
	{
		return sliderItem_0.Text;
	}

	private void method_1(Office2007SliderStateColorTable office2007SliderStateColorTable_0, Rectangle rectangle_0, Graphics graphics_0, eSliderPart eSliderPart_0)
	{
		method_2(office2007SliderStateColorTable_0, rectangle_0, graphics_0, eSliderPart_0, eOrientation.Horizontal);
	}

	private void method_2(Office2007SliderStateColorTable office2007SliderStateColorTable_0, Rectangle rectangle_0, Graphics graphics_0, eSliderPart eSliderPart_0, eOrientation eOrientation_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		if (rectangle_0.Width <= 0 || rectangle_0.Height <= 0)
		{
			return;
		}
		switch (eSliderPart_0)
		{
		case eSliderPart.TrackArea:
		{
			if (eOrientation_0 == eOrientation.Vertical)
			{
				Matrix val8 = new Matrix();
				val8.RotateAt(-90f, new PointF(rectangle_0.X, rectangle_0.Bottom));
				val8.Translate((float)rectangle_0.Height, (float)(rectangle_0.Width - rectangle_0.Height), (MatrixOrder)1);
				graphics_0.set_Transform(val8);
			}
			GraphicsPath val9 = new GraphicsPath();
			try
			{
				val9.AddLine(rectangle_0.X, rectangle_0.Y, rectangle_0.X + 11, rectangle_0.Y);
				val9.AddLine(rectangle_0.X + 11, rectangle_0.Y, rectangle_0.X + 11, rectangle_0.Y + 9);
				val9.AddLine(rectangle_0.X + 11, rectangle_0.Y + 9, rectangle_0.X + 6, rectangle_0.Y + 15);
				val9.AddLine(rectangle_0.X + 5, rectangle_0.Y + 15, rectangle_0.X, rectangle_0.Y + 10);
				val9.CloseAllFigures();
				SolidBrush val10 = new SolidBrush(office2007SliderStateColorTable_0.PartBorderLightColor);
				try
				{
					graphics_0.FillPath((Brush)(object)val10, val9);
				}
				finally
				{
					((IDisposable)val10)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val9)?.Dispose();
			}
			SmoothingMode smoothingMode2 = graphics_0.get_SmoothingMode();
			graphics_0.set_SmoothingMode((SmoothingMode)4);
			rectangle_0.Offset(1, 1);
			GraphicsPath val11 = new GraphicsPath();
			try
			{
				val11.AddLine(rectangle_0.X, rectangle_0.Y, rectangle_0.X + 8, rectangle_0.Y);
				val11.AddLine(rectangle_0.X + 8, rectangle_0.Y + 8, rectangle_0.X + 4, rectangle_0.Y + 12);
				val11.AddLine(rectangle_0.X, rectangle_0.Y + 8, rectangle_0.X, rectangle_0.Y);
				val11.CloseAllFigures();
				Brush val12 = Class50.smethod_45(Rectangle.Ceiling(val11.GetBounds()), office2007SliderStateColorTable_0.PartBackground);
				try
				{
					graphics_0.FillPath(val12, val11);
				}
				finally
				{
					((IDisposable)val12)?.Dispose();
				}
				Pen val13 = new Pen(office2007SliderStateColorTable_0.PartBorderColor, 1f);
				try
				{
					graphics_0.DrawPath(val13, val11);
				}
				finally
				{
					((IDisposable)val13)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val11)?.Dispose();
			}
			Pen val14 = new Pen(Color.FromArgb(200, office2007SliderStateColorTable_0.PartForeColor), 1f);
			try
			{
				graphics_0.DrawLine(val14, rectangle_0.X + 4, rectangle_0.Y + 3, rectangle_0.X + 4, rectangle_0.Y + 8);
			}
			finally
			{
				((IDisposable)val14)?.Dispose();
			}
			Pen val15 = new Pen(office2007SliderStateColorTable_0.PartForeLightColor, 1f);
			try
			{
				graphics_0.DrawLine(val15, rectangle_0.X + 5, rectangle_0.Y + 4, rectangle_0.X + 5, rectangle_0.Y + 7);
			}
			finally
			{
				((IDisposable)val15)?.Dispose();
			}
			graphics_0.set_SmoothingMode(smoothingMode2);
			if (eOrientation_0 == eOrientation.Vertical)
			{
				graphics_0.ResetTransform();
			}
			break;
		}
		case eSliderPart.IncreaseButton:
		case eSliderPart.DecreaseButton:
		{
			rectangle_0.Inflate(-1, -1);
			SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
			graphics_0.set_SmoothingMode((SmoothingMode)4);
			Brush val = Class50.smethod_45(rectangle_0, office2007SliderStateColorTable_0.PartBackground);
			try
			{
				graphics_0.FillEllipse(val, rectangle_0);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			if (!office2007SliderStateColorTable_0.PartBorderColor.IsEmpty)
			{
				Pen val2 = new Pen(office2007SliderStateColorTable_0.PartBorderColor, 1f);
				try
				{
					graphics_0.DrawEllipse(val2, rectangle_0);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			rectangle_0.Inflate(1, 1);
			if (!office2007SliderStateColorTable_0.PartBorderLightColor.IsEmpty)
			{
				Pen val3 = new Pen(office2007SliderStateColorTable_0.PartBorderLightColor, 1f);
				try
				{
					graphics_0.DrawEllipse(val3, rectangle_0);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			graphics_0.set_SmoothingMode((SmoothingMode)3);
			switch (eSliderPart_0)
			{
			case eSliderPart.DecreaseButton:
			{
				Size size2 = new Size(9, 3);
				Rectangle rectangle2 = new Rectangle(rectangle_0.X + (rectangle_0.Width - size2.Width) / 2, rectangle_0.Y + (rectangle_0.Height - size2.Height) / 2, size2.Width, size2.Height);
				if (!office2007SliderStateColorTable_0.PartForeLightColor.IsEmpty)
				{
					Pen val6 = new Pen(office2007SliderStateColorTable_0.PartForeLightColor, 1f);
					try
					{
						graphics_0.DrawRectangle(val6, rectangle2);
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
				}
				if (!office2007SliderStateColorTable_0.PartForeColor.IsEmpty)
				{
					rectangle2.Offset(1, 1);
					rectangle2.Width--;
					rectangle2.Height--;
					SolidBrush val7 = new SolidBrush(office2007SliderStateColorTable_0.PartForeColor);
					try
					{
						graphics_0.FillRectangle((Brush)(object)val7, rectangle2);
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
				}
				break;
			}
			case eSliderPart.IncreaseButton:
			{
				Size size = new Size(8, 8);
				Rectangle rectangle = new Rectangle(rectangle_0.X + (rectangle_0.Width - size.Width) / 2, rectangle_0.Y + (rectangle_0.Height - size.Height) / 2, size.Width, size.Height);
				if (!office2007SliderStateColorTable_0.TrackLineLightColor.IsEmpty)
				{
					SolidBrush val4 = new SolidBrush(office2007SliderStateColorTable_0.PartForeLightColor);
					try
					{
						graphics_0.FillRectangle((Brush)(object)val4, new Rectangle(rectangle.X, rectangle.Y + 3, rectangle.Width + 2, 4));
						graphics_0.FillRectangle((Brush)(object)val4, new Rectangle(rectangle.X + 3, rectangle.Y, 4, 3));
						graphics_0.FillRectangle((Brush)(object)val4, new Rectangle(rectangle.X + 3, rectangle.Bottom - 1, 4, 3));
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
				}
				if (!office2007SliderStateColorTable_0.TrackLineColor.IsEmpty)
				{
					SolidBrush val5 = new SolidBrush(office2007SliderStateColorTable_0.PartForeColor);
					try
					{
						graphics_0.FillRectangle((Brush)(object)val5, new Rectangle(rectangle.X + 1, rectangle.Y + 4, rectangle.Width, 2));
						graphics_0.FillRectangle((Brush)(object)val5, new Rectangle(rectangle.X + 4, rectangle.Y + 1, 2, 3));
						graphics_0.FillRectangle((Brush)(object)val5, new Rectangle(rectangle.X + 4, rectangle.Bottom - 2, 2, 3));
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
				}
				break;
			}
			}
			graphics_0.set_SmoothingMode(smoothingMode);
			break;
		}
		}
	}
}
