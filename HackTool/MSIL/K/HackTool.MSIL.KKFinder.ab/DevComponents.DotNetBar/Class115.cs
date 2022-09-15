using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class115 : Class114, Interface3
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

	public override void PaintSystemIcon(SystemCaptionItemRendererEventArgs e)
	{
		Graphics graphics = e.Graphics;
		SystemCaptionItem systemCaptionItem = e.SystemCaptionItem;
		Rectangle displayRectangle = systemCaptionItem.DisplayRectangle;
		displayRectangle.Offset((displayRectangle.Width - 16) / 2, (displayRectangle.Height - 16) / 2);
		if (systemCaptionItem.Icon == null)
		{
			return;
		}
		if (Environment.Version.Build <= 3705 && Environment.Version.Revision == 288 && Environment.Version.Major == 1 && Environment.Version.Minor == 0)
		{
			IntPtr hdc = graphics.GetHdc();
			try
			{
				Class92.DrawIconEx(hdc, displayRectangle.X, displayRectangle.Y, systemCaptionItem.Icon.get_Handle(), displayRectangle.Width, displayRectangle.Height, 0, IntPtr.Zero, 3);
				return;
			}
			finally
			{
				graphics.ReleaseHdc(hdc);
			}
		}
		graphics.DrawIcon(systemCaptionItem.Icon, displayRectangle);
	}

	public override void PaintFormButtons(SystemCaptionItemRendererEventArgs e)
	{
		if (e.GlassEnabled)
		{
			return;
		}
		Graphics graphics = e.Graphics;
		SystemCaptionItem systemCaptionItem = e.SystemCaptionItem;
		Office2007SystemButtonColorTable systemButton = office2007ColorTable_0.SystemButton;
		Rectangle displayRectangle = systemCaptionItem.DisplayRectangle;
		Region clip = graphics.get_Clip();
		Rectangle clip2 = displayRectangle;
		clip2.Height++;
		graphics.SetClip(clip2);
		Size size = systemCaptionItem.vmethod_1();
		if (size.Height > displayRectangle.Height)
		{
			size = new Size(displayRectangle.Height, displayRectangle.Height);
		}
		Rectangle r = new Rectangle(displayRectangle.X, displayRectangle.Y + (displayRectangle.Height - size.Height) / 2, size.Width, size.Height);
		Office2007SystemButtonStateColorTable ct = systemButton.Default;
		if (systemCaptionItem.HelpVisible && (!systemCaptionItem.IsRightToLeft || (systemCaptionItem.CloseVisible && systemCaptionItem.IsRightToLeft)))
		{
			if ((systemCaptionItem.CloseEnabled && systemCaptionItem.IsRightToLeft) || !systemCaptionItem.IsRightToLeft)
			{
				if ((systemCaptionItem.Enum13_2 == Enum13.const_4 && !systemCaptionItem.IsRightToLeft) || (systemCaptionItem.Enum13_2 == Enum13.const_3 && systemCaptionItem.IsRightToLeft))
				{
					ct = systemButton.Pressed;
				}
				else if ((systemCaptionItem.Enum13_1 == Enum13.const_4 && !systemCaptionItem.IsRightToLeft) || (systemCaptionItem.Enum13_1 == Enum13.const_3 && systemCaptionItem.IsRightToLeft))
				{
					ct = systemButton.MouseOver;
				}
			}
			PaintBackground(graphics, r, ct);
			if (systemCaptionItem.IsRightToLeft)
			{
				PaintClose(graphics, r, ct, systemCaptionItem.CloseEnabled);
			}
			else
			{
				PaintHelp(graphics, r, ct);
			}
			r.Offset(r.Width + 1, 0);
		}
		if ((systemCaptionItem.MinimizeVisible && systemCaptionItem.HelpVisible) || (systemCaptionItem.MinimizeVisible && !systemCaptionItem.HelpVisible && (!systemCaptionItem.IsRightToLeft || (systemCaptionItem.CloseVisible && systemCaptionItem.IsRightToLeft))))
		{
			ct = systemButton.Default;
			if ((systemCaptionItem.CloseEnabled && systemCaptionItem.IsRightToLeft) || !systemCaptionItem.IsRightToLeft)
			{
				if ((systemCaptionItem.Enum13_2 == Enum13.const_1 && !systemCaptionItem.IsRightToLeft) || (systemCaptionItem.Enum13_2 == Enum13.const_3 && systemCaptionItem.IsRightToLeft))
				{
					ct = systemButton.Pressed;
				}
				else if ((systemCaptionItem.Enum13_1 == Enum13.const_1 && !systemCaptionItem.IsRightToLeft) || (systemCaptionItem.Enum13_1 == Enum13.const_3 && systemCaptionItem.IsRightToLeft))
				{
					ct = systemButton.MouseOver;
				}
			}
			PaintBackground(graphics, r, ct);
			if (systemCaptionItem.IsRightToLeft)
			{
				PaintClose(graphics, r, ct, systemCaptionItem.CloseEnabled);
			}
			else
			{
				PaintMinimize(graphics, r, ct);
			}
			r.Offset(r.Width + 1, 0);
		}
		if (systemCaptionItem.RestoreMaximizeVisible)
		{
			if (systemCaptionItem.RestoreEnabled)
			{
				ct = systemButton.Default;
				if (systemCaptionItem.Enum13_2 == Enum13.const_2)
				{
					ct = systemButton.Pressed;
				}
				else if (systemCaptionItem.Enum13_1 == Enum13.const_2)
				{
					ct = systemButton.MouseOver;
				}
				PaintBackground(graphics, r, ct);
				PaintRestore(graphics, r, ct);
			}
			else
			{
				ct = systemButton.Default;
				if (systemCaptionItem.Enum13_2 == Enum13.const_5)
				{
					ct = systemButton.Pressed;
				}
				else if (systemCaptionItem.Enum13_1 == Enum13.const_5)
				{
					ct = systemButton.MouseOver;
				}
				PaintBackground(graphics, r, ct);
				PaintMaximize(graphics, r, ct);
			}
			r.Offset(r.Width + 1, 0);
		}
		if ((systemCaptionItem.CloseVisible && !systemCaptionItem.IsRightToLeft) || (!systemCaptionItem.HelpVisible && systemCaptionItem.MinimizeVisible && systemCaptionItem.IsRightToLeft) || (systemCaptionItem.HelpVisible && systemCaptionItem.IsRightToLeft))
		{
			ct = systemButton.Default;
			if ((systemCaptionItem.CloseEnabled && !systemCaptionItem.IsRightToLeft) || systemCaptionItem.IsRightToLeft)
			{
				if ((systemCaptionItem.Enum13_2 == Enum13.const_3 && !systemCaptionItem.IsRightToLeft) || (systemCaptionItem.Enum13_2 == Enum13.const_1 && systemCaptionItem.IsRightToLeft))
				{
					ct = systemButton.Pressed;
				}
				else if ((systemCaptionItem.Enum13_1 == Enum13.const_3 && !systemCaptionItem.IsRightToLeft) || (systemCaptionItem.Enum13_1 == Enum13.const_1 && systemCaptionItem.IsRightToLeft))
				{
					ct = systemButton.MouseOver;
				}
			}
			PaintBackground(graphics, r, ct);
			if (systemCaptionItem.IsRightToLeft)
			{
				if (systemCaptionItem.HelpVisible)
				{
					PaintHelp(graphics, r, ct);
				}
				else
				{
					PaintMinimize(graphics, r, ct);
				}
			}
			else
			{
				PaintClose(graphics, r, ct, systemCaptionItem.CloseEnabled);
			}
		}
		graphics.set_Clip(clip);
	}

	protected virtual void PaintBackground(Graphics g, Rectangle r, Office2007SystemButtonStateColorTable ct)
	{
		int int_ = 2;
		Rectangle rectangle_ = r;
		if (!ct.OuterBorder.IsEmpty)
		{
			r.Inflate(-1, -1);
		}
		Rectangle rectangle_2 = new Rectangle(r.X, r.Y, r.Width, r.Height / 2);
		if (!ct.TopBackground.IsEmpty)
		{
			Class50.smethod_25(g, rectangle_2, ct.TopBackground);
		}
		g.get_Clip();
		if (!ct.BottomBackground.IsEmpty)
		{
			rectangle_2.Y += rectangle_2.Height;
			rectangle_2.Height = r.Height - rectangle_2.Height;
			Class50.smethod_25(g, rectangle_2, ct.BottomBackground);
		}
		if (!ct.TopHighlight.IsEmpty)
		{
			Rectangle rectangle_3 = r;
			rectangle_3.Height /= 2;
			method_0(g, ct.TopHighlight, rectangle_3, new PointF(rectangle_3.X + rectangle_3.Width / 2, rectangle_3.Bottom));
		}
		if (!ct.BottomHighlight.IsEmpty)
		{
			Rectangle rectangle_4 = r;
			rectangle_4.Height /= 2;
			rectangle_4.Y += r.Height - rectangle_4.Height;
			method_0(g, ct.BottomHighlight, rectangle_4, new PointF(rectangle_4.X + rectangle_4.Width / 2, rectangle_4.Bottom));
		}
		if (!ct.OuterBorder.IsEmpty)
		{
			Class50.smethod_37(g, rectangle_, ct.OuterBorder, 1, int_);
			rectangle_.Inflate(-1, -1);
		}
		if (!ct.InnerBorder.IsEmpty)
		{
			Class50.smethod_37(g, rectangle_, ct.InnerBorder, 1, int_);
		}
	}

	private void method_0(Graphics graphics_0, LinearGradientColorTable linearGradientColorTable_0, Rectangle rectangle_0, PointF pointF_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(rectangle_0.X, rectangle_0.Y, rectangle_0.Width, rectangle_0.Height * 2);
		GraphicsPath val = new GraphicsPath();
		val.AddEllipse(rectangle);
		PathGradientBrush val2 = new PathGradientBrush(val);
		val2.set_CenterColor(linearGradientColorTable_0.Start);
		val2.set_SurroundColors(new Color[1] { linearGradientColorTable_0.End });
		val2.set_CenterPoint(pointF_0);
		Blend val3 = new Blend();
		val3.set_Factors(new float[3] { 0f, 0.5f, 1f });
		val3.set_Positions(new float[3] { 0f, 0.4f, 1f });
		val2.set_Blend(val3);
		graphics_0.FillRectangle((Brush)(object)val2, rectangle_0);
		((Brush)val2).Dispose();
		val.Dispose();
	}

	protected virtual void PaintMinimize(Graphics g, Rectangle r, Office2007SystemButtonStateColorTable ct)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Size size_ = new Size(7, 3);
		Rectangle rectangle = method_1(r, size_);
		Class50.smethod_32(g, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y, ct.DarkShade, 1);
		rectangle.Offset(0, 1);
		Class50.smethod_32(g, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y, ct.Foreground.Start, 1);
		rectangle.Offset(0, 1);
		Class50.smethod_32(g, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y, ct.LightShade, 1);
		g.set_SmoothingMode(smoothingMode);
	}

	private Rectangle method_1(Rectangle rectangle_0, Size size_0)
	{
		if (rectangle_0.Height < 10)
		{
			return Rectangle.Empty;
		}
		return new Rectangle(rectangle_0.X + (rectangle_0.Width - size_0.Width) / 2, rectangle_0.Bottom - rectangle_0.Height / 4 - size_0.Height, size_0.Width, size_0.Height);
	}

	protected virtual void PaintRestore(Graphics g, Rectangle r, Office2007SystemButtonStateColorTable ct)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Size size_ = new Size(9, 8);
		Rectangle rectangle = method_1(r, size_);
		Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y + 1, 7, 7);
		Region clip = g.get_Clip();
		for (int i = 0; i < 2; i++)
		{
			Class50.smethod_33(g, new Rectangle(rectangle2.X, rectangle2.Y + 1, rectangle2.Width, rectangle2.Height - 1), ct.Foreground, 1);
			Class50.smethod_32(g, rectangle2.X, rectangle2.Y, rectangle2.Right - 1, rectangle2.Y, ct.DarkShade, 1);
			Class50.smethod_32(g, rectangle2.X + 1, rectangle2.Y + 2, rectangle2.Right - 2, rectangle2.Y + 2, ct.LightShade, 1);
			Class50.smethod_32(g, rectangle2.X + 1, rectangle2.Y + 2, rectangle2.Right - 2, rectangle2.Y + 2, ct.LightShade, 1);
			g.SetClip(rectangle2, (CombineMode)4);
			rectangle2.Offset(2, -1);
		}
		if (clip != null)
		{
			g.set_Clip(clip);
		}
		else
		{
			g.ResetClip();
		}
		g.set_SmoothingMode(smoothingMode);
	}

	protected virtual void PaintMaximize(Graphics g, Rectangle r, Office2007SystemButtonStateColorTable ct)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Size size_ = new Size(9, 8);
		Rectangle rectangle = method_1(r, size_);
		Class50.smethod_32(g, rectangle.X, rectangle.Y, rectangle.Right - 1, rectangle.Y, ct.DarkShade, 1);
		rectangle.Y++;
		rectangle.Height--;
		Class50.smethod_32(g, rectangle.X, rectangle.Y, rectangle.Right - 1, rectangle.Y, ct.Foreground.Start, 1);
		rectangle.Y++;
		rectangle.Height--;
		Rectangle rectangle_ = rectangle;
		rectangle_.Height--;
		Class50.smethod_33(g, rectangle_, ct.Foreground, 1);
		Class50.smethod_32(g, rectangle.X, rectangle.Bottom - 1, rectangle.Right - 1, rectangle.Bottom - 1, ct.LightShade, 1);
		g.set_SmoothingMode(smoothingMode);
	}

	protected virtual void PaintClose(Graphics g, Rectangle r, Office2007SystemButtonStateColorTable ct, bool isEnabled)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		g.set_SmoothingMode((SmoothingMode)0);
		Size size_ = new Size(11, 9);
		Rectangle rectangle = method_1(r, size_);
		Rectangle rectangle2 = rectangle;
		rectangle2.Inflate(-1, 0);
		rectangle2.Height--;
		GraphicsPath val = new GraphicsPath();
		try
		{
			val.AddLine(rectangle2.X, rectangle2.Y, rectangle2.X + 2, rectangle2.Y);
			val.AddLine(rectangle2.X + 2, rectangle2.Y, rectangle2.X + 4, rectangle2.Y + 2);
			val.AddLine(rectangle2.X + 4, rectangle2.Y + 2, rectangle2.X + 6, rectangle2.Y);
			val.AddLine(rectangle2.X + 6, rectangle2.Y, rectangle2.X + 8, rectangle2.Y);
			val.AddLine(rectangle2.X + 8, rectangle2.Y, rectangle2.X + 5, rectangle2.Y + 3);
			val.AddLine(rectangle2.X + 5, rectangle2.Y + 4, rectangle2.X + 8, rectangle2.Y + 7);
			val.AddLine(rectangle2.X + 8, rectangle2.Y + 7, rectangle2.X + 6, rectangle2.Y + 7);
			val.AddLine(rectangle2.X + 6, rectangle2.Y + 7, rectangle2.X + 4, rectangle2.Y + 5);
			val.AddLine(rectangle2.X + 4, rectangle2.Y + 5, rectangle2.X + 2, rectangle2.Y + 7);
			val.AddLine(rectangle2.X + 2, rectangle2.Y + 7, rectangle2.X, rectangle2.Y + 7);
			val.AddLine(rectangle2.X, rectangle2.Y + 7, rectangle2.X + 3, rectangle2.Y + 4);
			val.AddLine(rectangle2.X + 3, rectangle2.Y + 3, rectangle2.X, rectangle2.Y);
			if (isEnabled)
			{
				Class50.smethod_29(g, val, ct.Foreground);
				Class50.smethod_39(g, val, ct.Foreground, 1);
			}
			else
			{
				LinearGradientColorTable linearGradientColorTable_ = new LinearGradientColorTable(ct.Foreground.Start.IsEmpty ? ct.Foreground.Start : Color.FromArgb(128, ct.Foreground.Start), ct.Foreground.End.IsEmpty ? ct.Foreground.End : Color.FromArgb(128, ct.Foreground.End), ct.Foreground.GradientAngle);
				Class50.smethod_29(g, val, linearGradientColorTable_);
				Class50.smethod_39(g, val, linearGradientColorTable_, 1);
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (!ct.DarkShade.IsEmpty)
		{
			Pen val2 = new Pen(isEnabled ? ct.DarkShade : Color.FromArgb(128, ct.DarkShade), 1f);
			try
			{
				g.DrawLine(val2, rectangle2.X, rectangle2.Y, rectangle2.X + 2, rectangle2.Y);
				g.DrawLine(val2, rectangle2.X + 2, rectangle2.Y, rectangle2.X + 4, rectangle2.Y + 2);
				g.DrawLine(val2, rectangle2.X + 4, rectangle2.Y + 2, rectangle2.X + 6, rectangle2.Y);
				g.DrawLine(val2, rectangle2.X + 6, rectangle2.Y, rectangle2.X + 8, rectangle2.Y);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (!ct.LightShade.IsEmpty)
		{
			Pen val3 = new Pen(isEnabled ? ct.LightShade : Color.FromArgb(128, ct.LightShade), 1f);
			try
			{
				g.DrawLine(val3, rectangle.X, rectangle.Y + 8, rectangle.X + 3, rectangle.Y + 8);
				g.DrawLine(val3, rectangle.X + 3, rectangle.Y + 8, rectangle.X + 5, rectangle.Y + 6);
				g.DrawLine(val3, rectangle.X + 5, rectangle.Y + 6, rectangle.X + 7, rectangle.Y + 8);
				g.DrawLine(val3, rectangle.X + 7, rectangle.Y + 8, rectangle.X + 10, rectangle.Y + 8);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		g.set_SmoothingMode(smoothingMode);
	}

	protected virtual void PaintHelp(Graphics g, Rectangle r, Office2007SystemButtonStateColorTable ct)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		SmoothingMode smoothingMode = g.get_SmoothingMode();
		TextRenderingHint textRenderingHint = g.get_TextRenderingHint();
		g.set_SmoothingMode((SmoothingMode)0);
		g.set_TextRenderingHint((TextRenderingHint)5);
		Font val = new Font(SystemFonts.get_DefaultFont(), (FontStyle)1);
		try
		{
			Size size_ = Class55.smethod_3(g, "?", val);
			size_.Width += 4;
			size_.Height -= 2;
			Rectangle rectangle = method_1(r, size_);
			rectangle.Offset(1, 1);
			SolidBrush val2 = new SolidBrush(ct.LightShade);
			try
			{
				g.DrawString("?", val, (Brush)(object)val2, (RectangleF)rectangle);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			rectangle.Offset(-1, -1);
			SolidBrush val3 = new SolidBrush(ct.Foreground.Start);
			try
			{
				g.DrawString("?", val, (Brush)(object)val3, (RectangleF)rectangle);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		g.set_SmoothingMode(smoothingMode);
		g.set_TextRenderingHint(textRenderingHint);
	}
}
