using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Xml;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class252 : Class245
{
	private enum Enum30
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5
	}

	private Size size_0 = new Size(5, 4);

	private Enum30 enum30_0 = Enum30.const_4;

	public override bool CanStartNewLine => false;

	public override void Measure(Size availableSize, Class263 d)
	{
		base.Bounds = new Rectangle(Point.Empty, size_0);
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
	}

	public override void Render(Class263 d)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		Rectangle bounds = base.Bounds;
		bounds.Offset(d.point_0);
		if (!d.rectangle_0.IsEmpty && !bounds.IntersectsWith(d.rectangle_0))
		{
			return;
		}
		Graphics graphics_ = d.graphics_0;
		Color color_ = d.color_0;
		Enum30 @enum = Enum30.const_3;
		if (enum30_0 != Enum30.const_4)
		{
			@enum = enum30_0;
		}
		if (d.object_0 is ButtonItem && enum30_0 == Enum30.const_4)
		{
			ButtonItem buttonItem = d.object_0 as ButtonItem;
			if (buttonItem.IsOnMenu)
			{
				@enum = Enum30.const_1;
				if ((buttonItem.PopupSide == ePopupSide.Default && d.bool_0) || buttonItem.PopupSide == ePopupSide.Left)
				{
					@enum = Enum30.const_0;
				}
			}
			else if (buttonItem.PopupSide == ePopupSide.Default)
			{
				@enum = Enum30.const_3;
			}
			else if (buttonItem.PopupSide == ePopupSide.Left)
			{
				@enum = Enum30.const_0;
			}
			else if (buttonItem.PopupSide == ePopupSide.Right)
			{
				@enum = Enum30.const_1;
			}
			else if (buttonItem.PopupSide == ePopupSide.Bottom)
			{
				@enum = Enum30.const_3;
			}
			else if (buttonItem.PopupSide == ePopupSide.Top)
			{
				@enum = Enum30.const_2;
			}
		}
		SmoothingMode smoothingMode = graphics_.get_SmoothingMode();
		graphics_.set_SmoothingMode((SmoothingMode)3);
		Rectangle rectangle_ = bounds;
		switch (@enum)
		{
		case Enum30.const_2:
			rectangle_.Offset(0, -1);
			break;
		case Enum30.const_0:
			rectangle_.Offset(1, 0);
			break;
		case Enum30.const_1:
			rectangle_.Offset(-1, 0);
			break;
		case Enum30.const_3:
		case Enum30.const_5:
			rectangle_.Offset(0, 1);
			break;
		}
		Point[] array = method_3(rectangle_, @enum);
		SolidBrush val = new SolidBrush(Color.FromArgb(96, Color.White));
		try
		{
			graphics_.FillPolygon((Brush)(object)val, array);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		array = method_3(bounds, @enum);
		SolidBrush val2 = new SolidBrush(color_);
		try
		{
			graphics_.FillPolygon((Brush)(object)val2, array);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if (@enum == Enum30.const_5)
		{
			Pen val3 = new Pen(color_, 1f);
			try
			{
				graphics_.DrawLine(val3, bounds.X, bounds.Y - 2, bounds.Right - 1, bounds.Y - 2);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			Pen val4 = new Pen(Color.FromArgb(96, Color.White), 1f);
			try
			{
				graphics_.DrawLine(val4, bounds.X, bounds.Y - 1, bounds.Right - 1, bounds.Y - 1);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		graphics_.set_SmoothingMode(smoothingMode);
		base.Rectangle_0 = bounds;
	}

	private Point[] method_3(Rectangle rectangle_2, Enum30 enum30_1)
	{
		Point[] array = new Point[3];
		switch (enum30_1)
		{
		case Enum30.const_0:
			array[0].X = rectangle_2.Left + 3;
			array[0].Y = rectangle_2.Top + (rectangle_2.Height - size_0.Height) / 2 - 1;
			array[1].X = array[0].X;
			array[1].Y = array[0].Y + 6;
			array[2].X = array[0].X - 3;
			array[2].Y = array[0].Y + 3;
			break;
		case Enum30.const_1:
			array[0].X = rectangle_2.Left + 1;
			array[0].Y = rectangle_2.Top + (rectangle_2.Height - size_0.Height) / 2 - 1;
			array[1].X = array[0].X;
			array[1].Y = array[0].Y + 6;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y + 3;
			break;
		case Enum30.const_2:
			array[0].X = rectangle_2.Left - 1;
			array[0].Y = rectangle_2.Top + (rectangle_2.Height - size_0.Height) / 2 + size_0.Height;
			array[1].X = array[0].X + 6;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y - 4;
			break;
		case Enum30.const_3:
		case Enum30.const_5:
			array[0].X = rectangle_2.Left;
			array[0].Y = rectangle_2.Top + (rectangle_2.Height - size_0.Height) / 2 + 1;
			array[1].X = array[0].X + 5;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 2;
			array[2].Y = array[0].Y + 3;
			break;
		}
		return array;
	}

	public override void ReadAttributes(XmlTextReader reader)
	{
		enum30_0 = Enum30.const_4;
		int num = 0;
		while (true)
		{
			if (num < reader.AttributeCount)
			{
				reader.MoveToAttribute(num);
				if (reader.Name.ToLower() == "direction")
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		switch (reader.Value.ToLower())
		{
		case "left":
			enum30_0 = Enum30.const_0;
			break;
		case "right":
			enum30_0 = Enum30.const_1;
			break;
		case "top":
			enum30_0 = Enum30.const_2;
			break;
		case "bottom":
			enum30_0 = Enum30.const_3;
			break;
		case "popup":
			enum30_0 = Enum30.const_5;
			break;
		}
	}
}
