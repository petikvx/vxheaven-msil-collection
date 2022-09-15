using System.Drawing;

namespace DevComponents.DotNetBar.Presentation;

internal class Class213 : Class209
{
	private Class208 class208_1 = new Class208();

	private Class208 class208_2 = new Class208();

	private Class215 class215_0 = new Class215();

	public Class208 Class208_1 => class208_1;

	public Class208 Class208_2 => class208_2;

	public Class215 Class215_0 => class215_0;

	public Class213()
	{
	}

	public Class213(Class208 startPoint, Class208 endPoint, Class215 border)
	{
		class208_1 = startPoint;
		class208_2 = endPoint;
		class215_0 = border;
	}

	public override void Paint(Class216 p)
	{
		Point location = GetLocation(p.rectangle_0, class208_1);
		Point location2 = GetLocation(p.rectangle_0, class208_2);
		Graphics graphics_ = p.graphics_0;
		if (class215_0.color_1.IsEmpty)
		{
			if (!class215_0.color_0.IsEmpty)
			{
				Class50.smethod_31(graphics_, location, location2, class215_0.color_0, class215_0.int_0);
			}
		}
		else
		{
			Class50.smethod_43(graphics_, location, location2, class215_0.color_0, class215_0.color_1, class215_0.int_1, class215_0.int_0);
		}
		base.Paint(p);
	}
}
