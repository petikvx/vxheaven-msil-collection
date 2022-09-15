using System.ComponentModel;
using System.Drawing;

namespace DevComponents.WinForms.Drawing;

[ToolboxItem(false)]
public abstract class Fill : Component
{
	public abstract Brush CreateBrush(Rectangle bounds);

	public abstract Pen CreatePen(int width);
}
