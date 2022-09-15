using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar.Presentation;

internal class Class212 : Class209
{
	private int int_0;

	private Class215 class215_0 = new Class215();

	private Class210 class210_0 = new Class210();

	private eCornerType eCornerType_0 = eCornerType.Square;

	private eCornerType eCornerType_1 = eCornerType.Square;

	private eCornerType eCornerType_2 = eCornerType.Square;

	private eCornerType eCornerType_3 = eCornerType.Square;

	public int Int32_0
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

	public eCornerType ECornerType_0
	{
		get
		{
			return eCornerType_0;
		}
		set
		{
			eCornerType_0 = value;
			eCornerType_1 = value;
			eCornerType_2 = value;
			eCornerType_3 = value;
		}
	}

	public eCornerType ECornerType_1
	{
		get
		{
			return eCornerType_0;
		}
		set
		{
			eCornerType_0 = value;
		}
	}

	public eCornerType ECornerType_2
	{
		get
		{
			return eCornerType_1;
		}
		set
		{
			eCornerType_1 = value;
		}
	}

	public eCornerType ECornerType_3
	{
		get
		{
			return eCornerType_2;
		}
		set
		{
			eCornerType_2 = value;
		}
	}

	public eCornerType ECornerType_4
	{
		get
		{
			return eCornerType_3;
		}
		set
		{
			eCornerType_3 = value;
		}
	}

	public Class212()
	{
	}

	public Class212(Class215 border)
	{
		class215_0 = border;
	}

	public Class212(Class215 border, int cornerSize, eCornerType cornerType)
	{
		class215_0 = border;
		int_0 = cornerSize;
		ECornerType_0 = cornerType;
	}

	public Class212(Class215 border, Class210 fill)
	{
		class215_0 = border;
		class210_0 = fill;
	}

	public Class212(Class215 border, Class210 fill, int cornerSize, eCornerType cornerType)
	{
		class215_0 = border;
		class210_0 = fill;
		int_0 = cornerSize;
		ECornerType_0 = cornerType;
	}

	public Class212(Class215 border, Class210 fill, int cornerSize, eCornerType cornerType, Class214 padding)
	{
		class215_0 = border;
		class210_0 = fill;
		int_0 = cornerSize;
		base.Class214_0 = padding;
		ECornerType_0 = cornerType;
	}

	public Class212(Class210 fill)
	{
		class210_0 = fill;
	}

	public override void Paint(Class216 p)
	{
		Rectangle bounds = GetBounds(p.rectangle_0);
		Graphics graphics_ = p.graphics_0;
		PaintFill(graphics_, bounds);
		PaintBorder(graphics_, bounds);
		base.Paint(p);
	}

	protected virtual void PaintBorder(Graphics g, Rectangle r)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		if (class215_0.int_0 == 0 || class215_0.color_0.IsEmpty || r.Width <= 0 || r.Height <= 0)
		{
			return;
		}
		Class215 @class = class215_0;
		r.Width--;
		r.Height--;
		GraphicsPath val = Class50.smethod_15(r, int_0, eStyleBackgroundPathPart.Complete, eCornerType_0, eCornerType_1, eCornerType_2, eCornerType_3);
		try
		{
			Pen val2 = new Pen(@class.color_0, (float)@class.int_0);
			try
			{
				val.Widen(val2);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			if (@class.color_1.IsEmpty)
			{
				SolidBrush val3 = new SolidBrush(@class.color_0);
				try
				{
					g.FillPath((Brush)(object)val3, val);
					return;
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			LinearGradientBrush val4 = Class50.smethod_0(r, @class.color_0, @class.color_1, @class.int_1);
			try
			{
				g.FillPath((Brush)(object)val4, val);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected virtual void PaintFill(Graphics g, Rectangle r)
	{
		if (r.Width <= 0 || r.Height <= 0)
		{
			return;
		}
		int num = int_0;
		if (num > 0)
		{
			GraphicsPath val = Class50.smethod_15(r, int_0, eStyleBackgroundPathPart.Complete, eCornerType_0, eCornerType_1, eCornerType_2, eCornerType_3);
			try
			{
				Brush val2 = class210_0.method_1(Rectangle.Ceiling(val.GetBounds()));
				if (val2 != null)
				{
					Class50.smethod_30(g, val, class210_0.color_0, class210_0.color_1, class210_0.int_0);
					val2.Dispose();
				}
				return;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		Brush val3 = class210_0.method_1(r);
		if (val3 != null)
		{
			g.FillRectangle(val3, r);
			val3.Dispose();
		}
	}

	protected override Region ClipChildren(Graphics g, Rectangle childBounds)
	{
		if (int_0 > 0)
		{
			Region clip = g.get_Clip();
			g.SetClip(Class50.smethod_15(childBounds, int_0, eStyleBackgroundPathPart.Complete, eCornerType_0, eCornerType_1, eCornerType_2, eCornerType_3));
			return clip;
		}
		return base.ClipChildren(g, childBounds);
	}
}
