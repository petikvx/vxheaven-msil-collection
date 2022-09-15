using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar.Rendering;

internal class Class229 : Class228, Interface3
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

	public override void Paint(CheckBoxItemRenderEventArgs e)
	{
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.Graphics;
		CheckBoxItem checkBoxItem = e.CheckBoxItem;
		bool rightToLeft = e.RightToLeft;
		Font font = e.Font;
		Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable = method_3(e);
		Rectangle rectangle_ = Rectangle.Empty;
		Rectangle rectangle = Rectangle.Empty;
		eTextFormat eTextFormat = eTextFormat.Default;
		if ((checkBoxItem.CheckBoxPosition == eCheckBoxPosition.Left && !rightToLeft) || (checkBoxItem.CheckBoxPosition == eCheckBoxPosition.Right && rightToLeft))
		{
			rectangle_ = new Rectangle(checkBoxItem.DisplayRectangle.X + checkBoxItem.Int32_1 / 2, checkBoxItem.DisplayRectangle.Y + (checkBoxItem.DisplayRectangle.Height - checkBoxItem.Size_0.Height) / 2, checkBoxItem.Size_0.Width, checkBoxItem.Size_0.Height);
			rectangle = new Rectangle(rectangle_.Right + checkBoxItem.Int32_1 / 2, checkBoxItem.DisplayRectangle.Y, checkBoxItem.DisplayRectangle.Right - (rectangle_.Right + checkBoxItem.Int32_1 / 2), checkBoxItem.DisplayRectangle.Height);
			rectangle.Height = rectangle_.Height + rectangle_.Y - checkBoxItem.DisplayRectangle.Y + font.get_FontFamily().GetCellAscent(font.get_Style()) / font.get_FontFamily().GetEmHeight(font.get_Style());
			eTextFormat |= eTextFormat.Bottom;
		}
		else if ((checkBoxItem.CheckBoxPosition == eCheckBoxPosition.Right && !rightToLeft) || (checkBoxItem.CheckBoxPosition == eCheckBoxPosition.Left && rightToLeft))
		{
			rectangle_ = new Rectangle(checkBoxItem.DisplayRectangle.Right - checkBoxItem.Int32_1 / 2 - checkBoxItem.Size_0.Width, checkBoxItem.DisplayRectangle.Y + (checkBoxItem.DisplayRectangle.Height - checkBoxItem.Size_0.Height) / 2, checkBoxItem.Size_0.Width, checkBoxItem.Size_0.Height);
			rectangle = new Rectangle(checkBoxItem.DisplayRectangle.X, checkBoxItem.DisplayRectangle.Y, rectangle_.X - (checkBoxItem.DisplayRectangle.X + checkBoxItem.Int32_1 / 2), checkBoxItem.DisplayRectangle.Height);
			rectangle.Height = rectangle_.Height + rectangle_.Y - checkBoxItem.DisplayRectangle.Y + font.get_FontFamily().GetCellAscent(font.get_Style()) / font.get_FontFamily().GetEmHeight(font.get_Style());
			eTextFormat |= eTextFormat.Bottom | eTextFormat.Right;
		}
		else if (checkBoxItem.CheckBoxPosition == eCheckBoxPosition.Top)
		{
			rectangle_ = new Rectangle(checkBoxItem.DisplayRectangle.X + (checkBoxItem.DisplayRectangle.Width - checkBoxItem.Size_0.Width) / 2, checkBoxItem.DisplayRectangle.Y + checkBoxItem.Int32_2, checkBoxItem.Size_0.Width, checkBoxItem.Size_0.Height);
			rectangle = new Rectangle(checkBoxItem.DisplayRectangle.X, rectangle_.Bottom, checkBoxItem.DisplayRectangle.Width, checkBoxItem.DisplayRectangle.Bottom - rectangle_.Bottom);
			eTextFormat |= eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter;
		}
		else if (checkBoxItem.CheckBoxPosition == eCheckBoxPosition.Bottom)
		{
			rectangle_ = new Rectangle(checkBoxItem.DisplayRectangle.X + (checkBoxItem.DisplayRectangle.Width - checkBoxItem.Size_0.Width) / 2, checkBoxItem.DisplayRectangle.Bottom - checkBoxItem.Int32_2 - checkBoxItem.Size_0.Height, checkBoxItem.Size_0.Width, checkBoxItem.Size_0.Height);
			rectangle = new Rectangle(checkBoxItem.DisplayRectangle.X, checkBoxItem.DisplayRectangle.Y, checkBoxItem.DisplayRectangle.Width, rectangle_.Y - (checkBoxItem.DisplayRectangle.Y + checkBoxItem.Int32_2));
			eTextFormat |= eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter;
		}
		if (checkBoxItem.CheckBoxStyle == eCheckBoxStyle.CheckBox)
		{
			method_1(graphics, rectangle_, office2007CheckBoxStateColorTable, checkBoxItem.CheckState);
		}
		else
		{
			method_0(graphics, rectangle_, office2007CheckBoxStateColorTable, checkBoxItem.Checked);
		}
		Color color = office2007CheckBoxStateColorTable.Text;
		if (!checkBoxItem.TextColor.IsEmpty)
		{
			color = checkBoxItem.TextColor;
		}
		if (checkBoxItem.Text != "" && !rectangle.IsEmpty && !color.IsEmpty && checkBoxItem.Orientation != eOrientation.Vertical && checkBoxItem.TextVisible)
		{
			if (checkBoxItem.Class261_0 != null)
			{
				Class263 @class = new Class263(graphics, font, color, rightToLeft);
				@class.bool_3 = (eTextFormat & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
				if ((eTextFormat & eTextFormat.VerticalCenter) == eTextFormat.VerticalCenter)
				{
					rectangle.Y = checkBoxItem.TopInternal + (checkBoxItem.Bounds.Height - rectangle.Height) / 2;
				}
				else if ((eTextFormat & eTextFormat.Bottom) == eTextFormat.Bottom)
				{
					rectangle.Y += checkBoxItem.Bounds.Height - rectangle.Height + 1;
				}
				checkBoxItem.Class261_0.Bounds = rectangle;
				checkBoxItem.Class261_0.Render(@class);
			}
			else if (e.itemPaintArgs_0 != null && e.itemPaintArgs_0.GlassEnabled && checkBoxItem.Parent is Class181)
			{
				if (!e.itemPaintArgs_0.bool_0)
				{
					Class169.smethod_0(graphics, checkBoxItem.Text, font, rectangle, Class55.smethod_12(eTextFormat));
				}
			}
			else
			{
				Class55.smethod_1(graphics, checkBoxItem.Text, font, color, rectangle, eTextFormat);
			}
		}
		if (checkBoxItem.Focused && checkBoxItem.DesignMode)
		{
			Rectangle displayRectangle = checkBoxItem.DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			Class32.smethod_0(graphics, displayRectangle, e.ColorScheme.ItemDesignTimeBorder);
		}
	}

	public void method_0(Graphics graphics_0, Rectangle rectangle_0, Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable_0, bool bool_0)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		Rectangle rectangle = rectangle_0;
		rectangle.Inflate(-1, -1);
		GraphicsPath val = new GraphicsPath();
		try
		{
			val.AddEllipse(rectangle);
			Class50.smethod_29(graphics_0, val, office2007CheckBoxStateColorTable_0.CheckBackground);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Pen val2 = new Pen(office2007CheckBoxStateColorTable_0.CheckBorder, 1f);
		try
		{
			graphics_0.DrawEllipse(val2, rectangle_0);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		rectangle_0.Inflate(-3, -3);
		Pen val3 = new Pen(office2007CheckBoxStateColorTable_0.CheckInnerBorder, 1f);
		try
		{
			graphics_0.DrawEllipse(val3, rectangle_0);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		if (!office2007CheckBoxStateColorTable_0.CheckInnerBackground.IsEmpty)
		{
			if (office2007CheckBoxStateColorTable_0.CheckInnerBackground.End.IsEmpty)
			{
				rectangle = rectangle_0;
				rectangle.Inflate(-1, -1);
				SolidBrush val4 = new SolidBrush(office2007CheckBoxStateColorTable_0.CheckInnerBackground.Start);
				try
				{
					graphics_0.FillEllipse((Brush)(object)val4, rectangle);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			else
			{
				Region clip = graphics_0.get_Clip();
				graphics_0.SetClip(rectangle_0, (CombineMode)0);
				GraphicsPath val5 = new GraphicsPath();
				try
				{
					val5.AddEllipse(rectangle_0);
					PathGradientBrush val6 = new PathGradientBrush(val5);
					try
					{
						val6.set_CenterColor(office2007CheckBoxStateColorTable_0.CheckInnerBackground.Start);
						val6.set_SurroundColors(new Color[1] { office2007CheckBoxStateColorTable_0.CheckInnerBackground.End });
						val6.set_CenterPoint(new PointF(rectangle_0.X, rectangle_0.Y));
						graphics_0.FillEllipse((Brush)(object)val6, rectangle_0);
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
				graphics_0.set_Clip(clip);
			}
		}
		if (bool_0 && !office2007CheckBoxStateColorTable_0.CheckSign.IsEmpty)
		{
			rectangle = rectangle_0;
			GraphicsPath val7 = new GraphicsPath();
			try
			{
				val7.AddEllipse(rectangle);
				Class50.smethod_29(graphics_0, val7, office2007CheckBoxStateColorTable_0.CheckSign);
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
	}

	public void method_1(Graphics graphics_0, Rectangle rectangle_0, Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable_0, CheckState checkState_0)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Invalid comparison between Unknown and I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		Rectangle rectangle_ = rectangle_0;
		rectangle_.Inflate(-1, -1);
		if (rectangle_0.Width < 5 || rectangle_0.Height < 5)
		{
			return;
		}
		Class50.smethod_25(graphics_0, rectangle_, office2007CheckBoxStateColorTable_0.CheckBackground);
		Class50.smethod_6(graphics_0, office2007CheckBoxStateColorTable_0.CheckBorder, rectangle_0);
		rectangle_0.Inflate(-2, -2);
		Class50.smethod_6(graphics_0, office2007CheckBoxStateColorTable_0.CheckInnerBorder, rectangle_0);
		if (!office2007CheckBoxStateColorTable_0.CheckInnerBackground.IsEmpty)
		{
			if (office2007CheckBoxStateColorTable_0.CheckInnerBackground.End.IsEmpty)
			{
				rectangle_ = rectangle_0;
				rectangle_.Inflate(-1, -1);
				Class50.smethod_23(graphics_0, rectangle_, office2007CheckBoxStateColorTable_0.CheckInnerBackground.Start);
			}
			else
			{
				Region clip = graphics_0.get_Clip();
				graphics_0.SetClip(rectangle_0, (CombineMode)1);
				GraphicsPath val = new GraphicsPath();
				try
				{
					val.AddRectangle(rectangle_0);
					PathGradientBrush val2 = new PathGradientBrush(val);
					try
					{
						val2.set_CenterColor(office2007CheckBoxStateColorTable_0.CheckInnerBackground.Start);
						val2.set_SurroundColors(new Color[1] { office2007CheckBoxStateColorTable_0.CheckInnerBackground.End });
						val2.set_CenterPoint(new PointF(rectangle_0.X, rectangle_0.Y));
						graphics_0.FillRectangle((Brush)(object)val2, rectangle_0);
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
				graphics_0.set_Clip(clip);
			}
		}
		if ((int)checkState_0 == 2)
		{
			rectangle_0.Inflate(-2, -2);
			SmoothingMode smoothingMode = graphics_0.get_SmoothingMode();
			graphics_0.set_SmoothingMode((SmoothingMode)3);
			Class50.smethod_25(graphics_0, rectangle_0, office2007CheckBoxStateColorTable_0.CheckSign);
			graphics_0.set_SmoothingMode(smoothingMode);
		}
		else if ((int)checkState_0 == 1 && !office2007CheckBoxStateColorTable_0.CheckSign.IsEmpty)
		{
			GraphicsPath val3 = method_2(rectangle_0);
			try
			{
				Class50.smethod_29(graphics_0, val3, office2007CheckBoxStateColorTable_0.CheckSign);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
	}

	private GraphicsPath method_2(Rectangle rectangle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Rectangle rectangle = rectangle_0;
		rectangle.Inflate(-1, -1);
		val.AddLine((float)rectangle.X, (float)rectangle.Y + (float)rectangle.Height * 0.75f, (float)rectangle.X + (float)rectangle.Width * 0.3f, (float)rectangle.Bottom);
		val.AddLine((float)rectangle.X + (float)rectangle.Width * 0.4f, (float)rectangle.Bottom, (float)rectangle.Right, (float)rectangle.Y + (float)rectangle.Height * 0.05f);
		val.AddLine((float)rectangle.Right - (float)rectangle.Width * 0.3f, (float)rectangle.Y, (float)rectangle.X + (float)rectangle.Width * 0.25f, (float)rectangle.Y + (float)rectangle.Height * 0.75f);
		val.AddLine((float)rectangle.X + (float)rectangle.Width * 0.1f, (float)rectangle.Y + (float)rectangle.Height * 0.5f, (float)rectangle.X, (float)rectangle.Y + (float)rectangle.Height * 0.55f);
		val.CloseAllFigures();
		return val;
	}

	private Office2007CheckBoxStateColorTable method_3(CheckBoxItemRenderEventArgs checkBoxItemRenderEventArgs_0)
	{
		CheckBoxItem checkBoxItem = checkBoxItemRenderEventArgs_0.CheckBoxItem;
		if (office2007ColorTable_0 != null && checkBoxItemRenderEventArgs_0.CheckBoxItem.Style == eDotNetBarStyle.Office2007)
		{
			Office2007CheckBoxColorTable checkBoxItem2 = office2007ColorTable_0.CheckBoxItem;
			if (!checkBoxItem.method_2())
			{
				return checkBoxItem2.Disabled;
			}
			if (checkBoxItem.IsMouseDown)
			{
				return checkBoxItem2.Pressed;
			}
			if (checkBoxItem.IsMouseOver)
			{
				return checkBoxItem2.MouseOver;
			}
			return checkBoxItem2.Default;
		}
		ColorScheme colorScheme = checkBoxItemRenderEventArgs_0.ColorScheme;
		Office2007CheckBoxStateColorTable office2007CheckBoxStateColorTable = new Office2007CheckBoxStateColorTable();
		if (!checkBoxItem.method_2())
		{
			office2007CheckBoxStateColorTable.CheckBackground = new LinearGradientColorTable(colorScheme.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckBorder = colorScheme.ItemDisabledText;
			office2007CheckBoxStateColorTable.CheckInnerBorder = colorScheme.ItemDisabledText;
			office2007CheckBoxStateColorTable.CheckInnerBackground = new LinearGradientColorTable();
			office2007CheckBoxStateColorTable.CheckSign = new LinearGradientColorTable(colorScheme.ItemDisabledText, Color.Empty);
			office2007CheckBoxStateColorTable.Text = colorScheme.ItemDisabledText;
		}
		else if (checkBoxItem.IsMouseDown)
		{
			office2007CheckBoxStateColorTable.CheckBackground = new LinearGradientColorTable(colorScheme.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckBorder = colorScheme.ItemPressedBorder;
			office2007CheckBoxStateColorTable.CheckInnerBorder = colorScheme.ItemPressedBorder;
			office2007CheckBoxStateColorTable.CheckInnerBackground = new LinearGradientColorTable(colorScheme.ItemPressedBackground, colorScheme.ItemPressedBackground2);
			office2007CheckBoxStateColorTable.CheckSign = new LinearGradientColorTable(colorScheme.ItemPressedText, Color.Empty);
			office2007CheckBoxStateColorTable.Text = colorScheme.ItemPressedText;
		}
		else if (checkBoxItem.IsMouseOver)
		{
			office2007CheckBoxStateColorTable.CheckBackground = new LinearGradientColorTable(colorScheme.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckBorder = colorScheme.ItemHotBorder;
			office2007CheckBoxStateColorTable.CheckInnerBorder = colorScheme.ItemHotBorder;
			office2007CheckBoxStateColorTable.CheckInnerBackground = new LinearGradientColorTable(colorScheme.ItemHotBackground, colorScheme.ItemHotBackground2);
			office2007CheckBoxStateColorTable.CheckSign = new LinearGradientColorTable(colorScheme.ItemHotText, Color.Empty);
			office2007CheckBoxStateColorTable.Text = colorScheme.ItemHotText;
		}
		else
		{
			office2007CheckBoxStateColorTable.CheckBackground = new LinearGradientColorTable(colorScheme.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckBorder = colorScheme.PanelBorder;
			office2007CheckBoxStateColorTable.CheckInnerBorder = ColorBlendFactory.smethod_1(colorScheme.PanelBorder, Color.White);
			office2007CheckBoxStateColorTable.CheckInnerBackground = new LinearGradientColorTable(colorScheme.MenuBackground, Color.Empty);
			office2007CheckBoxStateColorTable.CheckSign = new LinearGradientColorTable(colorScheme.ItemText, Color.Empty);
			office2007CheckBoxStateColorTable.Text = colorScheme.ItemText;
		}
		return office2007CheckBoxStateColorTable;
	}
}
