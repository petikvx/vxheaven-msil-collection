using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.AdvTree.Display;

internal class Class9 : NodeExpandDisplay
{
	public override void DrawExpandButton(NodeExpandPartRendererEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		if (!e.ExpandPartBounds.IsEmpty)
		{
			SmoothingMode smoothingMode = e.Graphics.get_SmoothingMode();
			e.Graphics.set_SmoothingMode((SmoothingMode)4);
			Rectangle rectangle = new Rectangle(e.ExpandPartBounds.X, e.ExpandPartBounds.Y + (e.ExpandPartBounds.Height - 8) / 2, 5, 8);
			GraphicsPath val = null;
			if (e.Node.Expanded)
			{
				val = new GraphicsPath();
				val.AddLine(rectangle.X, rectangle.Y + 5, rectangle.X + 5, rectangle.Y);
				val.AddLine(rectangle.X + 5, rectangle.Y, rectangle.X + 5, rectangle.Y + 5);
				val.CloseAllFigures();
			}
			else
			{
				val = new GraphicsPath();
				val.AddLine(rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom);
				val.AddLine(rectangle.X, rectangle.Bottom, rectangle.X + 4, rectangle.Y + rectangle.Height / 2);
				val.CloseAllFigures();
			}
			Brush backgroundBrush = GetBackgroundBrush(e);
			if (backgroundBrush != null)
			{
				e.Graphics.FillPath(backgroundBrush, val);
				backgroundBrush.Dispose();
			}
			Pen borderPen = GetBorderPen(e);
			if (borderPen != null)
			{
				e.Graphics.DrawPath(borderPen, val);
				borderPen.Dispose();
			}
			e.Graphics.set_SmoothingMode(smoothingMode);
		}
	}
}
