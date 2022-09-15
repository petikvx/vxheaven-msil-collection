using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
[TypeConverter(typeof(EllipticalShapeDescriptorConverter))]
public class EllipticalShapeDescriptor : ShapeDescriptor
{
	public override GraphicsPath GetShape(Rectangle bounds)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		val.AddEllipse(bounds);
		return val;
	}

	public override GraphicsPath GetInnerShape(Rectangle bounds, int borderSize)
	{
		return GetShape(bounds);
	}

	public override bool CanDrawShape(Rectangle bounds)
	{
		if (bounds.Width > 2)
		{
			return bounds.Height > 2;
		}
		return false;
	}
}
