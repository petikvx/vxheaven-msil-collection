using System.Drawing;

namespace DevComponents.DotNetBar.Presentation;

internal class Class209
{
	private Class208 class208_0 = new Class208();

	private Class217 class217_0 = new Class217();

	private Class207 class207_0;

	private Class214 class214_0;

	private bool bool_0;

	public Class208 Class208_0 => class208_0;

	public Class217 Class217_0 => class217_0;

	public Class214 Class214_0
	{
		get
		{
			return class214_0;
		}
		set
		{
			class214_0 = value;
		}
	}

	public Class207 Class207_0
	{
		get
		{
			if (class207_0 == null)
			{
				class207_0 = new Class207();
			}
			return class207_0;
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

	public virtual void Paint(Class216 p)
	{
		if (class207_0 == null || class207_0.Count <= 0)
		{
			return;
		}
		Rectangle rectangle_ = p.rectangle_0;
		Rectangle rectangle = new Rectangle(GetLocation(p.rectangle_0), GetSize(p.rectangle_0));
		if (class214_0 != null)
		{
			rectangle.Width -= class214_0.Int32_0;
			rectangle.Height -= class214_0.Int32_1;
			rectangle.X += class214_0.int_0;
			rectangle.Y += class214_0.int_2;
		}
		p.rectangle_0 = rectangle;
		Region val = ClipChildren(p.graphics_0, rectangle);
		if (bool_0 && p.graphics_0.get_Clip() != null)
		{
			p.region_0 = p.graphics_0.get_Clip().Clone();
		}
		foreach (Class209 item in class207_0)
		{
			item.Paint(p);
		}
		if (val != null)
		{
			p.graphics_0.set_Clip(val);
		}
		else
		{
			p.graphics_0.ResetClip();
		}
		p.rectangle_0 = rectangle_;
	}

	protected virtual Region ClipChildren(Graphics g, Rectangle childBounds)
	{
		Region clip = g.get_Clip();
		g.SetClip(childBounds);
		return clip;
	}

	protected virtual Point GetLocation(Rectangle bounds)
	{
		return GetLocation(bounds, class208_0);
	}

	protected virtual Point GetLocation(Rectangle bounds, Class208 refLocation)
	{
		Point location = bounds.Location;
		if (refLocation.enum23_0 == Enum23.const_3)
		{
			location.X = bounds.Right;
		}
		else if (refLocation.enum23_0 == Enum23.const_1)
		{
			location.X = bounds.Y;
		}
		else if (refLocation.enum23_0 == Enum23.const_4)
		{
			location.X = bounds.Bottom;
		}
		if (refLocation.enum23_1 == Enum23.const_4)
		{
			location.Y = bounds.Bottom;
		}
		else if (refLocation.enum23_1 == Enum23.const_3)
		{
			location.Y = bounds.Right;
		}
		else if (refLocation.enum23_1 == Enum23.const_2)
		{
			location.Y = bounds.X;
		}
		location.Offset(refLocation.int_0, refLocation.int_1);
		return location;
	}

	protected virtual Size GetSize(Rectangle bounds)
	{
		Size size = bounds.Size;
		if (class217_0.enum24_0 == Enum24.const_1)
		{
			size.Width = bounds.Width + class217_0.int_0;
		}
		else if (class217_0.enum24_0 == Enum24.const_2)
		{
			size.Width = bounds.Height + class217_0.int_1;
		}
		else if (class217_0.int_0 != 0)
		{
			size.Width = class217_0.int_0;
		}
		if (class217_0.enum24_1 == Enum24.const_2)
		{
			size.Height = bounds.Height + class217_0.int_1;
		}
		else if (class217_0.enum24_1 == Enum24.const_1)
		{
			size.Height = bounds.Width + class217_0.int_1;
		}
		else if (class217_0.int_1 != 0)
		{
			size.Height = class217_0.int_1;
		}
		return size;
	}

	protected virtual Rectangle GetBounds(Rectangle parentBounds)
	{
		return new Rectangle(GetLocation(parentBounds), GetSize(parentBounds));
	}
}
