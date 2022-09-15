using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

public interface IShapeDescriptor
{
	GraphicsPath GetShape(Rectangle bounds);

	GraphicsPath GetInnerShape(Rectangle bounds, int borderSize);

	bool CanDrawShape(Rectangle bounds);
}
