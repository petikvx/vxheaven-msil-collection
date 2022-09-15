using System.Drawing;
using DevComponents.DotNetBar;

namespace DevComponents.Editors;

public class VisualLabel : VisualItem
{
	private string string_0 = "";

	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			if (string_0 != value)
			{
				string_0 = value;
				InvalidateArrange();
			}
		}
	}

	public override void PerformLayout(PaintInfo p)
	{
		Size size = Size.Empty;
		Graphics graphics = p.Graphics;
		Font defaultFont = p.DefaultFont;
		eTextFormat eTextFormat_ = eTextFormat.LeftAndRightPadding;
		if (string_0.Length > 0)
		{
			size = Class55.smethod_4(graphics, Text, defaultFont, 0, eTextFormat_);
		}
		base.Size = size;
		base.PerformLayout(p);
	}

	protected override void OnPaint(PaintInfo p)
	{
		Graphics graphics = p.Graphics;
		Font defaultFont = p.DefaultFont;
		Rectangle renderBounds = base.RenderBounds;
		eTextFormat eTextFormat_ = eTextFormat.Default;
		Color color_ = p.ForeColor;
		if (!GetIsEnabled(p))
		{
			color_ = p.DisabledForeColor;
		}
		if (string_0.Length > 0)
		{
			Class55.smethod_1(graphics, string_0, defaultFont, color_, renderBounds, eTextFormat_);
		}
		base.OnPaint(p);
	}
}
