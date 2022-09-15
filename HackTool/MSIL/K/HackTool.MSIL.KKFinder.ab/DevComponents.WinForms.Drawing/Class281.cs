using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar;

namespace DevComponents.WinForms.Drawing;

internal class Class281 : Class280
{
	private Border border_0;

	private Fill fill_0;

	private CornerRadius cornerRadius_0;

	[DefaultValue(null)]
	[Description("Indicates shape border.")]
	public Border Border_0
	{
		get
		{
			return border_0;
		}
		set
		{
			border_0 = value;
		}
	}

	[DefaultValue(null)]
	[Description("Indicates shape fill")]
	public Fill Fill_0
	{
		get
		{
			return fill_0;
		}
		set
		{
			fill_0 = value;
		}
	}

	public CornerRadius CornerRadius_0
	{
		get
		{
			return cornerRadius_0;
		}
		set
		{
			cornerRadius_0 = value;
		}
	}

	public override void Paint(Graphics g, Rectangle bounds)
	{
		if (bounds.Width < 2 || bounds.Height < 2 || g == null || (fill_0 == null && border_0 == null))
		{
			return;
		}
		GraphicsPath val = null;
		if (!cornerRadius_0.Boolean_0)
		{
			val = Class50.smethod_14(bounds, cornerRadius_0.TopLeft, cornerRadius_0.TopRight, cornerRadius_0.BottomRight, cornerRadius_0.BottomLeft);
		}
		if (fill_0 != null)
		{
			Brush val2 = fill_0.CreateBrush(bounds);
			if (val2 != null)
			{
				if (val == null)
				{
					g.FillRectangle(val2, bounds);
				}
				else
				{
					g.FillPath(val2, val);
				}
				val2.Dispose();
			}
		}
		if (border_0 != null)
		{
			Pen val3 = border_0.CreatePen();
			if (val3 != null)
			{
				if (val == null)
				{
					g.DrawRectangle(val3, bounds);
				}
				else
				{
					g.DrawPath(val3, val);
				}
				val3.Dispose();
			}
		}
		Class280 @class = base.Class280_0;
		if (@class != null)
		{
			Rectangle bounds2 = Border.Deflate(bounds, border_0);
			Region val4 = null;
			if (val != null && base.Boolean_0)
			{
				val4 = g.get_Clip();
				g.SetClip(val, (CombineMode)1);
			}
			@class.Paint(g, bounds2);
			if (val4 != null)
			{
				g.set_Clip(val4);
			}
		}
		if (val != null)
		{
			val.Dispose();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeCornerRadius()
	{
		return !cornerRadius_0.Boolean_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetCornerRadius()
	{
		CornerRadius_0 = default(CornerRadius);
	}
}
