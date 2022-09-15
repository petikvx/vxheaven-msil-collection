using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar.Presentation;

internal class Class211 : Class209
{
	private Class215 class215_0;

	private Class210 class210_0;

	private GraphicsPath graphicsPath_0;

	public GraphicsPath GraphicsPath_0
	{
		get
		{
			return graphicsPath_0;
		}
		set
		{
			graphicsPath_0 = value;
		}
	}

	public Class215 Class215_0
	{
		get
		{
			return class215_0;
		}
		set
		{
			class215_0 = value;
		}
	}

	public Class210 Class210_0
	{
		get
		{
			return class210_0;
		}
		set
		{
			class210_0 = value;
		}
	}

	public Class211()
	{
	}

	public Class211(Class215 border)
	{
		class215_0 = border;
	}

	public Class211(Class210 fill)
	{
		class210_0 = fill;
	}

	public Class211(Class215 border, Class210 fill)
	{
		class215_0 = border;
		class210_0 = fill;
	}

	public override void Paint(Class216 p)
	{
		if (graphicsPath_0 != null)
		{
			Rectangle bounds = GetBounds(p.rectangle_0);
			Graphics graphics_ = p.graphics_0;
			if (class210_0 != null)
			{
				PaintFill(graphics_, bounds);
			}
			if (class215_0 != null)
			{
				PaintBorder(graphics_, bounds);
			}
			base.Paint(p);
		}
	}

	protected virtual void PaintBorder(Graphics g, Rectangle r)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		if (class215_0.color_0.IsEmpty)
		{
			return;
		}
		Class215 @class = class215_0;
		object obj = graphicsPath_0.Clone();
		GraphicsPath val = (GraphicsPath)((obj is GraphicsPath) ? obj : null);
		try
		{
			val.Transform(new Matrix(1f, 0f, 0f, 1f, (float)r.X, (float)r.Y));
			Class50.smethod_40(g, val, @class.color_0, @class.color_1, @class.int_1, @class.int_0);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected virtual void PaintFill(Graphics g, Rectangle r)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		if (r.Width <= 0 || r.Height <= 0 || class210_0 == null)
		{
			return;
		}
		object obj = graphicsPath_0.Clone();
		GraphicsPath val = (GraphicsPath)((obj is GraphicsPath) ? obj : null);
		try
		{
			Rectangle rectangle = Rectangle.Ceiling(val.GetBounds());
			int num = r.X + (int)Math.Ceiling((double)(Math.Max(r.Width, rectangle.Width) - rectangle.Width) / 2.0);
			int num2 = r.Y + (r.Height - rectangle.Height) / 2;
			val.Transform(new Matrix(1f, 0f, 0f, 1f, (float)num, (float)num2));
			rectangle = Rectangle.Ceiling(val.GetBounds());
			Brush val2 = class210_0.method_1(rectangle);
			if (val2 != null)
			{
				g.FillPath(val2, val);
				val2.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
