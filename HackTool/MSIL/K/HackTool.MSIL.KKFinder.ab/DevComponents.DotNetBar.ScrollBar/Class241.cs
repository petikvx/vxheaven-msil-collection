using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Presentation;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.ScrollBar;

internal class Class241 : Class240, Interface3
{
	private Office2007ColorTable office2007ColorTable_0;

	private bool bool_0;

	private Class215 class215_0 = new Class215(1);

	private Class215 class215_1 = new Class215(1);

	private Class210 class210_0 = new Class210();

	private Class210 class210_1 = new Class210();

	private Class209 class209_0;

	private Class211 class211_0;

	private Size size_0 = new Size(9, 5);

	private Class209 class209_1;

	private Class215 class215_2 = new Class215(1);

	private Class215 class215_3 = new Class215(1);

	private Class210 class210_2 = new Class210();

	private Class209 class209_2;

	private Class215 class215_4 = new Class215(1);

	private Class210 class210_3 = new Class210();

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

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public Class241()
	{
		class209_0 = method_2();
		class209_1 = method_3();
		class209_2 = method_1();
	}

	public override void PaintThumb(Graphics g, Rectangle bounds, Enum25 position, Enum26 state)
	{
		Office2007ScrollBarStateColorTable office2007ScrollBarStateColorTable = method_0(state);
		if (office2007ScrollBarStateColorTable != null)
		{
			class215_0.method_0(office2007ScrollBarStateColorTable.ThumbOuterBorder);
			class215_1.method_0(office2007ScrollBarStateColorTable.ThumbInnerBorder);
			class210_0.backgroundColorBlendCollection_0 = office2007ScrollBarStateColorTable.ThumbBackground;
			class210_1.method_0(office2007ScrollBarStateColorTable.ThumbSignBackground);
			class211_0.GraphicsPath_0 = method_4(position);
			class209_0.Paint(new Class216(g, bounds));
			class211_0.GraphicsPath_0.Dispose();
			class211_0.GraphicsPath_0 = null;
		}
	}

	private Office2007ScrollBarStateColorTable method_0(Enum26 enum26_0)
	{
		Office2007ScrollBarColorTable office2007ScrollBarColorTable = (bool_0 ? office2007ColorTable_0.AppScrollBar : office2007ColorTable_0.ScrollBar);
		return enum26_0 switch
		{
			Enum26.const_0 => office2007ScrollBarColorTable.Default, 
			Enum26.const_4 => office2007ScrollBarColorTable.Disabled, 
			Enum26.const_2 => office2007ScrollBarColorTable.MouseOverControl, 
			Enum26.const_1 => office2007ScrollBarColorTable.MouseOver, 
			Enum26.const_3 => office2007ScrollBarColorTable.Pressed, 
			_ => null, 
		};
	}

	public override void PaintTrackHorizontal(Graphics g, Rectangle bounds, Enum26 state)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		Office2007ScrollBarStateColorTable office2007ScrollBarStateColorTable = method_0(state);
		if (office2007ScrollBarStateColorTable == null)
		{
			return;
		}
		class215_2.method_0(office2007ScrollBarStateColorTable.TrackOuterBorder);
		class215_3.method_0(office2007ScrollBarStateColorTable.TrackInnerBorder);
		class210_2.backgroundColorBlendCollection_0 = office2007ScrollBarStateColorTable.TrackBackground;
		class210_2.int_0 = 90;
		class209_1.Paint(new Class216(g, bounds));
		if (bounds.Height <= 10 || office2007ScrollBarStateColorTable.TrackSignBackground.Start.IsEmpty)
		{
			return;
		}
		Rectangle rectangle = new Rectangle(bounds.X + (bounds.Width - 7) / 2, bounds.Y + (bounds.Height - 8) / 2, 8, 8);
		Pen val = new Pen(office2007ScrollBarStateColorTable.TrackSignBackground.Start, 1f);
		Pen val2 = null;
		if (!office2007ScrollBarStateColorTable.TrackSignBackground.End.IsEmpty)
		{
			val2 = new Pen(office2007ScrollBarStateColorTable.TrackSignBackground.End, 1f);
		}
		for (int i = 0; i < 4; i++)
		{
			g.DrawLine(val, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom);
			rectangle.X++;
			if (val2 != null)
			{
				g.DrawLine(val2, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom);
			}
			rectangle.X++;
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

	public override void PaintTrackVertical(Graphics g, Rectangle bounds, Enum26 state)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		Office2007ScrollBarStateColorTable office2007ScrollBarStateColorTable = method_0(state);
		if (office2007ScrollBarStateColorTable == null)
		{
			return;
		}
		class215_2.method_0(office2007ScrollBarStateColorTable.TrackOuterBorder);
		class215_3.method_0(office2007ScrollBarStateColorTable.TrackInnerBorder);
		class210_2.backgroundColorBlendCollection_0 = office2007ScrollBarStateColorTable.TrackBackground;
		class210_2.int_0 = 0;
		class209_1.Paint(new Class216(g, bounds));
		if (bounds.Height <= 10 || office2007ScrollBarStateColorTable.TrackSignBackground.Start.IsEmpty)
		{
			return;
		}
		Rectangle rectangle = new Rectangle(bounds.X + (bounds.Width - 8) / 2, bounds.Y + (bounds.Height - 7) / 2, 8, 8);
		Pen val = new Pen(office2007ScrollBarStateColorTable.TrackSignBackground.Start, 1f);
		Pen val2 = null;
		if (!office2007ScrollBarStateColorTable.TrackSignBackground.End.IsEmpty)
		{
			val2 = new Pen(office2007ScrollBarStateColorTable.TrackSignBackground.End, 1f);
		}
		for (int i = 0; i < 4; i++)
		{
			g.DrawLine(val, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y);
			rectangle.Y++;
			if (val2 != null)
			{
				g.DrawLine(val2, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y);
			}
			rectangle.Y++;
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

	public override void PaintBackground(Graphics g, Rectangle bounds, Enum26 state, bool horizontal, bool sideBorderOnly, bool rtl)
	{
		Office2007ScrollBarStateColorTable office2007ScrollBarStateColorTable = method_0(state);
		if (office2007ScrollBarStateColorTable == null)
		{
			return;
		}
		if (sideBorderOnly)
		{
			class215_4.method_0(null);
		}
		else
		{
			class215_4.method_0(office2007ScrollBarStateColorTable.Border);
		}
		class210_3.method_0(office2007ScrollBarStateColorTable.Background);
		class210_3.int_0 = (horizontal ? 90 : 0);
		class209_2.Paint(new Class216(g, bounds));
		if (sideBorderOnly && !office2007ScrollBarStateColorTable.Border.Start.IsEmpty)
		{
			if (horizontal)
			{
				Class50.smethod_32(g, bounds.X, bounds.Y, bounds.Right, bounds.Y, office2007ScrollBarStateColorTable.Border.Start, 1);
			}
			else if (rtl)
			{
				Class50.smethod_32(g, bounds.Right - 1, bounds.Y, bounds.Right - 1, bounds.Bottom, office2007ScrollBarStateColorTable.Border.Start, 1);
			}
			else
			{
				Class50.smethod_32(g, 0, bounds.Y, 0, bounds.Bottom, office2007ScrollBarStateColorTable.Border.Start, 1);
			}
		}
	}

	private Class209 method_1()
	{
		Class212 @class = new Class212();
		@class.Class215_0 = class215_4;
		@class.Class210_0 = class210_3;
		@class.Class214_0 = new Class214(1, 1, 1, 1);
		return @class;
	}

	private Class209 method_2()
	{
		Class212 @class = new Class212();
		@class.Class215_0 = class215_0;
		@class.Class214_0 = new Class214(1, 1, 1, 1);
		Class212 class2 = new Class212();
		class2.Class214_0 = new Class214(1, 1, 1, 1);
		class2.Class215_0 = class215_1;
		class2.Class210_0 = class210_0;
		@class.Class207_0.method_0(class2);
		class211_0 = new Class211();
		class211_0.Class210_0 = class210_1;
		class2.Class207_0.method_0(class211_0);
		return @class;
	}

	private Class209 method_3()
	{
		Class212 @class = new Class212();
		@class.ECornerType_0 = eCornerType.Rounded;
		@class.Int32_0 = 1;
		@class.Class215_0 = class215_2;
		@class.Class214_0 = new Class214(1, 1, 1, 1);
		Class212 class2 = new Class212();
		class2.Class214_0 = new Class214(1, 1, 1, 1);
		class2.Class215_0 = class215_3;
		class2.Class210_0 = class210_2;
		@class.Class207_0.method_0(class2);
		return @class;
	}

	private GraphicsPath method_4(Enum25 enum25_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Size size = size_0;
		if (enum25_0 == Enum25.const_2 || enum25_0 == Enum25.const_3)
		{
			int width = size.Width;
			size.Width = size.Height;
			size.Height = width;
		}
		switch (enum25_0)
		{
		case Enum25.const_0:
			val.AddPolygon(new PointF[6]
			{
				new PointF(-1f, size.Height),
				new PointF(size.Width / 2, -1f),
				new PointF(size.Width / 2, -1f),
				new PointF(size.Width, size.Height),
				new PointF(size.Width, size.Height),
				new PointF(-1f, size.Height)
			});
			val.CloseAllFigures();
			break;
		case Enum25.const_1:
			val.AddLine(size.Width / 2, size.Height + 1, size.Width, 1);
			val.AddLine(size.Width, 1, 0, 1);
			val.AddLine(0, 1, size.Width / 2, size.Height + 1);
			val.CloseAllFigures();
			break;
		case Enum25.const_2:
		{
			size.Height++;
			int num = size.Height / 2;
			val.AddLine(0, num, size.Width, 0);
			val.AddLine(size.Width, 0, size.Width, size.Height);
			val.AddLine(size.Width, size.Height, 0, num);
			val.CloseAllFigures();
			break;
		}
		case Enum25.const_3:
			size.Height++;
			val.AddLine(size.Width, size.Height / 2, 0, 0);
			val.AddLine(0, 0, 0, size.Height);
			val.AddLine(0, size.Height, size.Width, size.Height / 2);
			val.CloseAllFigures();
			break;
		}
		return val;
	}
}
