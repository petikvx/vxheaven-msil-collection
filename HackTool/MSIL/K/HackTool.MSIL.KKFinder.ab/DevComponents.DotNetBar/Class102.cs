using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.TextMarkup;

namespace DevComponents.DotNetBar;

internal class Class102 : Interface3
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

	public void method_0(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		method_1(buttonItem_0, itemPaintArgs_0, office2007ColorTable_0.CrumbBarItemView);
	}

	public void method_1(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0, CrumbBarItemViewColorTable crumbBarItemViewColorTable_0)
	{
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = itemPaintArgs_0.Graphics;
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.Default;
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable_ = null;
		bool bool_ = false;
		if (!buttonItem_0.IsMouseDown && !buttonItem_0.Expanded)
		{
			if (buttonItem_0.IsMouseOverExpand)
			{
				crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.MouseOverInactive;
				crumbBarItemViewStateColorTable_ = crumbBarItemViewColorTable_0.MouseOver;
			}
			else if (buttonItem_0.IsMouseOver)
			{
				crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.MouseOver;
			}
		}
		else
		{
			crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.Pressed;
			bool_ = true;
		}
		Rectangle rectangle_ = buttonItem_0.DisplayRectangle;
		rectangle_.Width--;
		rectangle_.Height--;
		Rectangle rectangle_2 = buttonItem_0.method_42();
		if (!rectangle_2.IsEmpty)
		{
			rectangle_2.Offset(rectangle_.Location);
			rectangle_2.Width--;
			rectangle_2.Height--;
		}
		smethod_0(buttonItem_0, graphics, crumbBarItemViewStateColorTable, crumbBarItemViewStateColorTable_, bool_, ref rectangle_, ref rectangle_2);
		Color color = crumbBarItemViewStateColorTable.Foreground;
		if (!buttonItem_0.ForeColor.IsEmpty)
		{
			color = buttonItem_0.ForeColor;
		}
		if (color.IsEmpty)
		{
			return;
		}
		Font val = buttonItem_0.method_40(itemPaintArgs_0);
		bool rightToLeft = itemPaintArgs_0.RightToLeft;
		rectangle_ = GetTextRectangle(buttonItem_0);
		eTextFormat eTextFormat2 = eTextFormat.HidePrefix | eTextFormat.VerticalCenter;
		if (buttonItem_0.Class261_0 == null)
		{
			Class55.smethod_1(graphics, Class265.smethod_0(buttonItem_0.Text), val, color, rectangle_, eTextFormat2);
		}
		else
		{
			Class263 @class = new Class263(graphics, val, color, rightToLeft);
			@class.bool_3 = (eTextFormat2 & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
			@class.object_0 = buttonItem_0;
			Rectangle bounds = new Rectangle(rectangle_.X, rectangle_.Y + (rectangle_.Height - buttonItem_0.Class261_0.Bounds.Height) / 2 + 1, buttonItem_0.Class261_0.Bounds.Width, buttonItem_0.Class261_0.Bounds.Height);
			buttonItem_0.Class261_0.Bounds = bounds;
			buttonItem_0.Class261_0.Render(@class);
		}
		if ((buttonItem_0.SubItems.Count <= 0 && buttonItem_0.PopupType != ePopupType.Container) || !buttonItem_0.ShowSubItems)
		{
			return;
		}
		GraphicsPath val2 = method_2(buttonItem_0, rectangle_2);
		if (val2 != null)
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			graphics.set_SmoothingMode((SmoothingMode)0);
			Brush val3 = (Brush)new SolidBrush(crumbBarItemViewStateColorTable.Foreground);
			try
			{
				graphics.FillPath(val3, val2);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			graphics.set_SmoothingMode(smoothingMode);
		}
	}

	private static void smethod_0(ButtonItem buttonItem_0, Graphics graphics_0, CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable_0, CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable_1, bool bool_0, ref Rectangle rectangle_0, ref Rectangle rectangle_1)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		if (crumbBarItemViewStateColorTable_0.Background != null && crumbBarItemViewStateColorTable_0.Background.Count > 0)
		{
			Brush val = Class50.smethod_46(rectangle_0, crumbBarItemViewStateColorTable_0.Background, 90, eGradientType.Linear);
			try
			{
				graphics_0.FillRectangle(val, rectangle_0);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			if (buttonItem_0.IsMouseOverExpand && crumbBarItemViewStateColorTable_1 != null && crumbBarItemViewStateColorTable_1.Background != null && crumbBarItemViewStateColorTable_1.Background.Count > 0)
			{
				Brush val2 = Class50.smethod_46(rectangle_0, crumbBarItemViewStateColorTable_1.Background, 90, eGradientType.Linear);
				try
				{
					graphics_0.FillRectangle(val2, rectangle_1);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		if (!crumbBarItemViewStateColorTable_0.Border.IsEmpty)
		{
			Pen val3 = new Pen(crumbBarItemViewStateColorTable_0.Border, 1f);
			try
			{
				graphics_0.DrawLine(val3, rectangle_0.X, rectangle_0.Y, rectangle_0.X, rectangle_0.Bottom);
				Pen val4 = (Pen)((crumbBarItemViewStateColorTable_1 != null) ? ((object)new Pen(crumbBarItemViewStateColorTable_1.Border, 1f)) : ((object)val3));
				if (!rectangle_1.IsEmpty)
				{
					graphics_0.DrawLine(val4, rectangle_1.X, rectangle_1.Y, rectangle_1.X, rectangle_1.Bottom);
				}
				if (bool_0)
				{
					graphics_0.DrawLine(val3, rectangle_0.X, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y);
				}
				graphics_0.DrawLine(val4, rectangle_0.Right, rectangle_0.Y, rectangle_0.Right, rectangle_0.Bottom);
				if (crumbBarItemViewStateColorTable_1 != null)
				{
					val4.Dispose();
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		if (crumbBarItemViewStateColorTable_0.BorderLight.IsEmpty)
		{
			return;
		}
		Rectangle rectangle = rectangle_0;
		if (!rectangle_1.IsEmpty)
		{
			rectangle.Width -= rectangle_1.Width;
		}
		rectangle.Inflate(-1, 0);
		Pen val5 = new Pen(crumbBarItemViewStateColorTable_0.BorderLight, 1f);
		try
		{
			if (bool_0)
			{
				graphics_0.DrawLine(val5, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y);
				graphics_0.DrawLine(val5, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom);
				if (!rectangle_1.IsEmpty)
				{
					rectangle = rectangle_1;
					rectangle.Inflate(-1, 0);
					graphics_0.DrawLine(val5, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y);
					graphics_0.DrawLine(val5, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom);
				}
			}
			else
			{
				graphics_0.DrawRectangle(val5, rectangle);
				if (!rectangle_1.IsEmpty)
				{
					rectangle = rectangle_1;
					rectangle.Inflate(-1, 0);
					graphics_0.DrawRectangle(val5, rectangle);
				}
			}
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
	}

	private GraphicsPath method_2(ButtonItem buttonItem_0, Rectangle rectangle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		if (buttonItem_0.Expanded)
		{
			Point point = new Point(rectangle_0.X + (rectangle_0.Width - 6) / 2, rectangle_0.Y + (rectangle_0.Height - 1) / 2);
			if (buttonItem_0.IsMouseDown)
			{
				point.Offset(1, 1);
			}
			val.AddLine(point.X, point.Y, point.X + 8, point.Y);
			val.AddLine(point.X + 8, point.Y, point.X + 4, point.Y + 4);
			val.CloseAllFigures();
		}
		else
		{
			Point point2 = new Point(rectangle_0.X + (rectangle_0.Width - 2) / 2, rectangle_0.Y + (rectangle_0.Height - 7) / 2);
			if (buttonItem_0.IsMouseDown)
			{
				point2.Offset(1, 1);
			}
			val.AddLine(point2.X, point2.Y, point2.X, point2.Y + 8);
			val.AddLine(point2.X, point2.Y + 8, point2.X + 4, point2.Y + 4);
			val.CloseAllFigures();
		}
		return val;
	}

	protected virtual Rectangle GetTextRectangle(ButtonItem button)
	{
		Rectangle displayRectangle = button.DisplayRectangle;
		Rectangle rectangle_ = button.Rectangle_2;
		rectangle_.Offset(displayRectangle.Left, displayRectangle.Top);
		if (rectangle_.Right > displayRectangle.Right)
		{
			rectangle_.Width = displayRectangle.Right - rectangle_.Left;
		}
		rectangle_.X += 2;
		rectangle_.Y--;
		if (button.IsMouseDown)
		{
			rectangle_.Offset(1, 1);
		}
		return rectangle_;
	}

	public void method_3(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0)
	{
		method_4(buttonItem_0, itemPaintArgs_0, office2007ColorTable_0.CrumbBarItemView);
	}

	public void method_4(ButtonItem buttonItem_0, ItemPaintArgs itemPaintArgs_0, CrumbBarItemViewColorTable crumbBarItemViewColorTable_0)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.Default;
		CrumbBarItemViewStateColorTable crumbBarItemViewStateColorTable_ = null;
		bool flag = false;
		if (!buttonItem_0.IsMouseDown && !buttonItem_0.Expanded)
		{
			if (buttonItem_0.IsMouseOver)
			{
				crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.MouseOver;
			}
		}
		else
		{
			crumbBarItemViewStateColorTable = crumbBarItemViewColorTable_0.Pressed;
			flag = true;
		}
		Rectangle rectangle_ = buttonItem_0.DisplayRectangle;
		rectangle_.Width--;
		rectangle_.Height--;
		Rectangle rectangle_2 = Rectangle.Empty;
		smethod_0(buttonItem_0, graphics, crumbBarItemViewStateColorTable, crumbBarItemViewStateColorTable_, flag, ref rectangle_, ref rectangle_2);
		Color foreground = crumbBarItemViewStateColorTable.Foreground;
		if (foreground.IsEmpty)
		{
			return;
		}
		graphics.get_SmoothingMode();
		Point point = new Point(rectangle_.X + (rectangle_.Width - 7) / 2, rectangle_.Y + (rectangle_.Height - 5) / 2);
		if (flag)
		{
			point.Offset(1, 1);
		}
		Pen val = new Pen(foreground, 1f);
		try
		{
			for (int i = 0; i < 2; i++)
			{
				graphics.DrawLine(val, point.X + 3, point.Y, point.X, point.Y + 2);
				graphics.DrawLine(val, point.X, point.Y + 2, point.X + 3, point.Y + 4);
				point.X += 4;
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
