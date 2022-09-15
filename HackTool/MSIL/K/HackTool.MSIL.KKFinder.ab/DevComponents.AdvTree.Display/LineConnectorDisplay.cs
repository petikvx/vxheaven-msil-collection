using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.AdvTree.Display;

public class LineConnectorDisplay : NodeConnectorDisplay
{
	public override void DrawConnector(ConnectorRendererEventArgs info)
	{
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		if (info.NodeConnector.LineColor.IsEmpty || info.NodeConnector.LineWidth <= 0)
		{
			return;
		}
		Point point;
		Point point2;
		if (info.FromNode == null)
		{
			Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_0, info.ToNode, info.Offset);
			Rectangle rectangle2 = NodeDisplay.smethod_0(Enum4.const_1, info.ToNode, info.Offset);
			point = new Point(rectangle.X - 4, rectangle.Y + rectangle.Height / 2);
			point2 = new Point(rectangle2.X + rectangle2.Width / 2, point.Y);
		}
		else
		{
			Rectangle rectangle3 = NodeDisplay.smethod_0(Enum4.const_0, info.FromNode, info.Offset);
			Rectangle rectangle4 = NodeDisplay.smethod_0(Enum4.const_1, info.ToNode, info.Offset);
			point = new Point(rectangle4.X + rectangle4.Width / 2, rectangle3.Bottom);
			point2 = new Point(point.X, rectangle4.Y + rectangle4.Height / 2);
		}
		Graphics graphics = info.Graphics;
		Pen linePen = GetLinePen(info);
		try
		{
			SmoothingMode smoothingMode = graphics.get_SmoothingMode();
			if ((int)linePen.get_DashStyle() != 0)
			{
				graphics.set_SmoothingMode((SmoothingMode)0);
			}
			graphics.DrawLine(linePen, point, point2);
			graphics.set_SmoothingMode(smoothingMode);
		}
		finally
		{
			((IDisposable)linePen)?.Dispose();
		}
	}
}
