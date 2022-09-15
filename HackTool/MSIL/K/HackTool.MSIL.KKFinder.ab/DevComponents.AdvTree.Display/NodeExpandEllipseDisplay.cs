using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.AdvTree.Display;

public class NodeExpandEllipseDisplay : NodeExpandDisplay
{
	public override void DrawExpandButton(NodeExpandPartRendererEventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		if (e.ExpandPartBounds.IsEmpty)
		{
			return;
		}
		Brush backgroundBrush = GetBackgroundBrush(e);
		if (backgroundBrush != null)
		{
			e.Graphics.FillEllipse(backgroundBrush, e.ExpandPartBounds);
			backgroundBrush.Dispose();
		}
		Pen borderPen = GetBorderPen(e);
		if (borderPen != null)
		{
			SmoothingMode smoothingMode = e.Graphics.get_SmoothingMode();
			e.Graphics.set_SmoothingMode((SmoothingMode)4);
			e.Graphics.DrawEllipse(borderPen, e.ExpandPartBounds);
			e.Graphics.set_SmoothingMode(smoothingMode);
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
