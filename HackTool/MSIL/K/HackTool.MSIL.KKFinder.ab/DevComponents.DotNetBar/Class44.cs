using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

internal abstract class Class44
{
	private int int_0 = 6;

	protected int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public Class44()
	{
	}

	public virtual void Paint(Class47 info)
	{
	}

	protected virtual void PaintArrow(Point p, Class47 info)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		GraphicsPath val = Class34.smethod_0(p, Int32_0, method_0(info));
		if (!info.class48_0.color_5.IsEmpty)
		{
			SolidBrush val2 = new SolidBrush(info.class48_0.color_5);
			try
			{
				info.graphics_0.FillPath((Brush)(object)val2, val);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		if (!info.class48_0.color_4.IsEmpty)
		{
			Pen val3 = new Pen(info.class48_0.color_4, 1f);
			try
			{
				info.graphics_0.DrawPath(val3, val);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		val.Dispose();
	}

	protected Enum8 method_0(Class47 class47_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		if (((int)class47_0.dockStyle_0 == 1 && class47_0.bool_1) || ((int)class47_0.dockStyle_0 == 2 && !class47_0.bool_1))
		{
			return Enum8.const_2;
		}
		if (((int)class47_0.dockStyle_0 == 1 && !class47_0.bool_1) || ((int)class47_0.dockStyle_0 == 2 && class47_0.bool_1))
		{
			return Enum8.const_3;
		}
		if (((int)class47_0.dockStyle_0 == 3 && class47_0.bool_1) || ((int)class47_0.dockStyle_0 == 4 && !class47_0.bool_1))
		{
			return Enum8.const_0;
		}
		return Enum8.const_1;
	}

	protected LinearGradientBrush method_1(Rectangle rectangle_0, Color color_0, Color color_1, float float_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		return new LinearGradientBrush(new Rectangle(rectangle_0.X - 1, rectangle_0.Y - 1, rectangle_0.Width + 1, rectangle_0.Height + 1), color_0, color_1, float_0);
	}

	protected virtual void PaintBackground(Class47 info)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		int num = info.class48_0.int_0;
		Rectangle rectangle_ = info.rectangle_0;
		if ((int)info.dockStyle_0 == 1 || (int)info.dockStyle_0 == 2)
		{
			num += 90;
		}
		if (info.class48_0.color_1.IsEmpty)
		{
			SolidBrush val = new SolidBrush(info.class48_0.color_0);
			try
			{
				info.graphics_0.FillRectangle((Brush)(object)val, rectangle_);
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		LinearGradientBrush val2 = method_1(rectangle_, info.class48_0.color_0, info.class48_0.color_1, num);
		try
		{
			info.graphics_0.FillRectangle((Brush)(object)val2, rectangle_);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
