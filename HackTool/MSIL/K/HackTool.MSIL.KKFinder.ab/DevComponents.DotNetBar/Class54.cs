using System;
using System.Drawing;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class54 : Class53, Interface3
{
	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public override void PaintKeyTips(KeyTipsRendererEventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		Rectangle bounds = e.Bounds;
		Color keyTipBorder = office2007ColorTable_0.KeyTips.KeyTipBorder;
		Color color = office2007ColorTable_0.KeyTips.KeyTipText;
		Color color2 = office2007ColorTable_0.KeyTips.KeyTipBackground;
		if (e.ReferenceObject is BaseItem && !((BaseItem)e.ReferenceObject).Enabled)
		{
			color2 = Color.FromArgb(128, color2);
			color = Color.FromArgb(128, color);
			keyTipBorder = Color.FromArgb(128, keyTipBorder);
		}
		Graphics graphics = e.Graphics;
		string keyTip = e.KeyTip;
		Font font = e.Font;
		SolidBrush val = new SolidBrush(color2);
		try
		{
			Class50.smethod_22(graphics, (Brush)(object)val, bounds, 2);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		Pen val2 = new Pen(color, 1f);
		try
		{
			Class50.smethod_11(graphics, val2, bounds, 2);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Class55.smethod_1(graphics, keyTip, font, color, bounds, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter);
	}
}
