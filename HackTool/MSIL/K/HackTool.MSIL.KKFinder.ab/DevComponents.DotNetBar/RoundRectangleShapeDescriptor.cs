using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(RoundRectangleShapeDescriptorConverter))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class RoundRectangleShapeDescriptor : ShapeDescriptor
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_0 = new RoundRectangleShapeDescriptor();

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_1 = new RoundRectangleShapeDescriptor(2);

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_2 = new RoundRectangleShapeDescriptor(3);

	[Description("Gets or sets the top-left round corner size.")]
	[DefaultValue(0)]
	public int TopLeft
	{
		get
		{
			return int_0;
		}
		set
		{
			if (int_0 != value)
			{
				int_0 = Math.Max(0, value);
			}
		}
	}

	[Description("Gets or sets the top-right round corner size.")]
	[DefaultValue(0)]
	public int TopRight
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = Math.Max(0, value);
			}
		}
	}

	[Description("Gets or sets the bottom-left round corner size.")]
	[DefaultValue(0)]
	public int BottomLeft
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 != value)
			{
				int_2 = Math.Max(0, value);
			}
		}
	}

	[DefaultValue(0)]
	[Description("Gets or sets the bottom-right round corner size.")]
	public int BottomRight
	{
		get
		{
			return int_3;
		}
		set
		{
			if (int_3 != value)
			{
				int_3 = Math.Max(0, value);
			}
		}
	}

	[Browsable(false)]
	public bool IsEmpty
	{
		get
		{
			if (int_0 == 0 && int_1 == 0 && int_2 == 0)
			{
				return int_3 == 0;
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsUniform
	{
		get
		{
			if (int_0 == int_1 && int_0 == int_2)
			{
				return int_0 == int_3;
			}
			return false;
		}
	}

	public static RoundRectangleShapeDescriptor RectangleShape => roundRectangleShapeDescriptor_0;

	public static RoundRectangleShapeDescriptor RoundCorner2 => roundRectangleShapeDescriptor_1;

	public static RoundRectangleShapeDescriptor RoundCorner3 => roundRectangleShapeDescriptor_2;

	public RoundRectangleShapeDescriptor()
	{
	}

	public RoundRectangleShapeDescriptor(int cornerSize)
		: this(cornerSize, cornerSize, cornerSize, cornerSize)
	{
	}

	public RoundRectangleShapeDescriptor(int topLeft, int topRight, int bottomLeft, int bottomRight)
	{
		int_0 = topLeft;
		int_1 = topRight;
		int_2 = bottomLeft;
		int_3 = bottomRight;
	}

	public override GraphicsPath GetShape(Rectangle bounds)
	{
		if (!CanDrawShape(bounds))
		{
			return null;
		}
		return method_0(bounds, int_0, int_1, int_2, int_3);
	}

	public override GraphicsPath GetInnerShape(Rectangle bounds, int borderSize)
	{
		return method_0(bounds, Math.Max(0, int_0 - borderSize), Math.Max(0, int_1 - borderSize), Math.Max(0, int_2 - borderSize), Math.Max(0, int_3 - borderSize));
	}

	private GraphicsPath method_0(Rectangle rectangle_0, int int_4, int int_5, int int_6, int int_7)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		if (int_4 == 0 && int_5 == 0 && int_6 == 0 && int_7 == 0)
		{
			GraphicsPath val = new GraphicsPath();
			val.AddRectangle(rectangle_0);
			return val;
		}
		return Class50.smethod_17(rectangle_0, int_4, int_5, int_6, int_7, eStyleBackgroundPathPart.Complete, eCornerType.Rounded, eCornerType.Rounded, eCornerType.Rounded, eCornerType.Rounded, 0f);
	}

	public override bool CanDrawShape(Rectangle bounds)
	{
		if (bounds.Width >= Math.Max(int_0 + int_1, int_2 + int_3) && bounds.Height >= Math.Max(int_0 + int_1, int_2 + int_3) && bounds.Height > 0 && bounds.Width > 0)
		{
			return true;
		}
		return false;
	}
}
