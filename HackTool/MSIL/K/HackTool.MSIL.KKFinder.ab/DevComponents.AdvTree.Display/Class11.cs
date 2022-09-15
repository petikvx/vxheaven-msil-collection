using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.AdvTree.Display;

internal class Class11
{
	private Color color_0;

	public Color Color_0
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	public void method_0(DragDropMarkerRendererEventArgs dragDropMarkerRendererEventArgs_0)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		Graphics graphics = dragDropMarkerRendererEventArgs_0.Graphics;
		Rectangle bounds = dragDropMarkerRendererEventArgs_0.Bounds;
		if (bounds.IsEmpty || color_0.IsEmpty)
		{
			return;
		}
		SolidBrush val = new SolidBrush(color_0);
		try
		{
			Pen val2 = new Pen((Brush)(object)val, 1f);
			try
			{
				Point point = new Point(bounds.X, bounds.Y + 4);
				graphics.DrawLine(val2, point.X, point.Y, bounds.Right - 1, point.Y);
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			GraphicsPath val3 = new GraphicsPath();
			try
			{
				val3.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y + 8);
				val3.AddLine(bounds.X, bounds.Y + 8, bounds.X + 4, bounds.Y + 4);
				val3.CloseAllFigures();
				graphics.FillPath((Brush)(object)val, val3);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			GraphicsPath val4 = new GraphicsPath();
			try
			{
				val4.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y + 8);
				val4.AddLine(bounds.Right, bounds.Y + 8, bounds.Right - 4, bounds.Y + 4);
				val4.CloseAllFigures();
				graphics.FillPath((Brush)(object)val, val4);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
