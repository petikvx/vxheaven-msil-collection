using System.Drawing;

namespace DevComponents.AdvTree.Display;

public class NodeExpandRectDisplay : NodeExpandDisplay
{
	public override void DrawExpandButton(NodeExpandPartRendererEventArgs e)
	{
		if (e.ExpandPartBounds.IsEmpty)
		{
			return;
		}
		Brush backgroundBrush = GetBackgroundBrush(e);
		if (backgroundBrush != null)
		{
			e.Graphics.FillRectangle(backgroundBrush, e.ExpandPartBounds);
			backgroundBrush.Dispose();
		}
		Pen borderPen = GetBorderPen(e);
		if (borderPen != null)
		{
			e.Graphics.DrawRectangle(borderPen, e.ExpandPartBounds);
			borderPen.Dispose();
			borderPen = null;
		}
		if (e.Node.Expanded)
		{
			borderPen = GetExpandPen(e);
			if (borderPen != null)
			{
				e.Graphics.DrawLine(borderPen, e.ExpandPartBounds.X + 2, e.ExpandPartBounds.Y + e.ExpandPartBounds.Height / 2, e.ExpandPartBounds.Right - 2, e.ExpandPartBounds.Y + e.ExpandPartBounds.Height / 2);
				borderPen.Dispose();
			}
			return;
		}
		borderPen = GetExpandPen(e);
		if (borderPen != null)
		{
			e.Graphics.DrawLine(borderPen, e.ExpandPartBounds.X + 2, e.ExpandPartBounds.Y + e.ExpandPartBounds.Height / 2, e.ExpandPartBounds.Right - 2, e.ExpandPartBounds.Y + e.ExpandPartBounds.Height / 2);
			e.Graphics.DrawLine(borderPen, e.ExpandPartBounds.X + e.ExpandPartBounds.Width / 2, e.ExpandPartBounds.Y + 2, e.ExpandPartBounds.X + e.ExpandPartBounds.Width / 2, e.ExpandPartBounds.Bottom - 2);
			borderPen.Dispose();
		}
	}
}
