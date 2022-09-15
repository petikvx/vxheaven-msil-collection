using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class254 : Class245
{
	private string string_0 = "";

	private bool bool_2;

	private bool bool_3 = true;

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			IsSizeValid = false;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			IsSizeValid = false;
		}
	}

	public bool Boolean_1
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public override void Measure(Size availableSize, Class263 d)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		StringFormat val = new StringFormat(StringFormat.get_GenericTypographic());
		val.set_FormatFlags((StringFormatFlags)4096);
		if (!d.bool_3 && bool_3)
		{
			val.set_HotkeyPrefix((HotkeyPrefix)2);
		}
		else
		{
			val.set_HotkeyPrefix((HotkeyPrefix)1);
		}
		if (bool_2)
		{
			if (d.font_0.get_Italic())
			{
				Size size = Size.Ceiling(d.graphics_0.MeasureString(string_0, d.font_0, 0, val));
				size.Width += (int)(d.graphics_0.MeasureString("|", d.font_0).Width / 4f);
				base.Bounds = new Rectangle(Point.Empty, size);
			}
			else
			{
				base.Bounds = new Rectangle(Point.Empty, Size.Ceiling(d.graphics_0.MeasureString(string_0 + "|", d.font_0, 0, val)));
			}
		}
		else
		{
			base.Bounds = new Rectangle(Point.Empty, Size.Ceiling(d.graphics_0.MeasureString(string_0, d.font_0, 0, val)));
		}
		IsSizeValid = true;
	}

	public override void Render(Class263 d)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		Rectangle bounds = base.Bounds;
		bounds.Offset(d.point_0);
		if (!d.rectangle_0.IsEmpty && !bounds.IntersectsWith(d.rectangle_0))
		{
			return;
		}
		StringFormat val = new StringFormat(StringFormat.get_GenericTypographic());
		val.set_FormatFlags((StringFormatFlags)4096);
		if (d.bool_0)
		{
			val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 1));
		}
		if (d.bool_3)
		{
			val.set_HotkeyPrefix((HotkeyPrefix)1);
		}
		else
		{
			val.set_HotkeyPrefix((HotkeyPrefix)2);
		}
		if (!d.rectangle_0.IsEmpty && bounds.Right > d.rectangle_0.Right)
		{
			val.set_Trimming((StringTrimming)3);
			bounds.Width -= bounds.Right - d.rectangle_0.Right;
		}
		Graphics graphics_ = d.graphics_0;
		SolidBrush val2 = new SolidBrush(d.color_0);
		try
		{
			graphics_.DrawString(string_0, d.font_0, (Brush)(object)val2, (RectangleF)bounds, val);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		if ((d.bool_1 && (d.hyperlinkStyle_0 == null || d.hyperlinkStyle_0.UnderlineStyle != 0)) || d.bool_2)
		{
			float num = (float)d.font_0.get_FontFamily().GetCellDescent(d.font_0.get_Style()) * d.font_0.get_Size() / (float)d.font_0.get_FontFamily().GetEmHeight(d.font_0.get_Style());
			Pen val3 = new Pen(d.color_0, 1f);
			try
			{
				if (d.bool_1 && d.hyperlinkStyle_0 != null && d.hyperlinkStyle_0.UnderlineStyle == eHyperlinkUnderlineStyle.DashedLine)
				{
					val3.set_DashStyle((DashStyle)1);
				}
				num -= 1f;
				SmoothingMode smoothingMode = graphics_.get_SmoothingMode();
				graphics_.set_SmoothingMode((SmoothingMode)0);
				graphics_.DrawLine(val3, (float)bounds.X, (float)bounds.Bottom - num, (float)bounds.Right, (float)bounds.Bottom - num);
				graphics_.set_SmoothingMode(smoothingMode);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		base.Rectangle_0 = bounds;
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
	}
}
