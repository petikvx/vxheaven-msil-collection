using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

public abstract class ShapeDescriptor : IShapeDescriptor
{
	public abstract GraphicsPath GetShape(Rectangle bounds);

	public abstract GraphicsPath GetInnerShape(Rectangle bounds, int borderSize);

	public abstract bool CanDrawShape(Rectangle bounds);
}
