using System;
using System.Drawing;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.Editors;

public class VisualCustomButton : VisualButton
{
	protected override void PaintButtonBackground(PaintInfo p, Office2007ButtonItemStateColorTable ct)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		base.PaintButtonBackground(p, ct);
		if (base.Text.Length != 0 || base.Image != null)
		{
			return;
		}
		Point location = new Point(base.RenderBounds.X + (base.RenderBounds.Width - 7) / 2, base.RenderBounds.Bottom - 6);
		SolidBrush val = new SolidBrush(ct.Text);
		try
		{
			Size size = new Size(2, 2);
			for (int i = 0; i < 3; i++)
			{
				p.Graphics.FillRectangle((Brush)(object)val, new Rectangle(location, size));
				location.X += size.Width + 1;
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
