using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
public class ItemStyleMapper
{
	private ElementStyle elementStyle_0;

	private ColorExMapper colorExMapper_0;

	private ColorExMapper colorExMapper_1;

	private ColorExMapper colorExMapper_2;

	private ColorExMapper colorExMapper_3;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public ColorExMapper BackColor1 => colorExMapper_0;

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ColorExMapper BackColor2 => colorExMapper_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public ColorExMapper ForeColor => colorExMapper_2;

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int GradientAngle
	{
		get
		{
			return elementStyle_0.BackColorGradientAngle;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["BackColorGradientAngle"]!.SetValue(elementStyle_0, value);
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	public Font Font
	{
		get
		{
			return elementStyle_0.Font;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["Font"]!.SetValue(elementStyle_0, value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public bool WordWrap
	{
		get
		{
			return elementStyle_0.WordWrap;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["WordWrap"]!.SetValue(elementStyle_0, value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public StringAlignment Alignment
	{
		get
		{
			return (StringAlignment)elementStyle_0.TextAlignment;
		}
		set
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I4, but got Unknown
			TypeDescriptor.GetProperties(elementStyle_0)["TextAlignment"]!.SetValue(elementStyle_0, (eStyleTextAlignment)value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public StringAlignment LineAlignment
	{
		get
		{
			return (StringAlignment)elementStyle_0.TextLineAlignment;
		}
		set
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I4, but got Unknown
			TypeDescriptor.GetProperties(elementStyle_0)["TextLineAlignment"]!.SetValue(elementStyle_0, (eStyleTextAlignment)value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public StringTrimming TextTrimming
	{
		get
		{
			return (StringTrimming)elementStyle_0.TextTrimming;
		}
		set
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected I4, but got Unknown
			TypeDescriptor.GetProperties(elementStyle_0)["TextTrimming"]!.SetValue(elementStyle_0, (eStyleTextTrimming)value);
		}
	}

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Image BackgroundImage
	{
		get
		{
			return elementStyle_0.BackgroundImage;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["BackgroundImage"]!.SetValue(elementStyle_0, value);
		}
	}

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public eBackgroundImagePosition BackgroundImagePosition
	{
		get
		{
			return (eBackgroundImagePosition)elementStyle_0.BackgroundImagePosition;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["BackgroundImagePosition"]!.SetValue(elementStyle_0, (eStyleBackgroundImage)value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public byte BackgroundImageAlpha
	{
		get
		{
			return elementStyle_0.BackgroundImageAlpha;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["BackgroundImageAlpha"]!.SetValue(elementStyle_0, value);
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public eCornerType CornerType
	{
		get
		{
			return elementStyle_0.CornerType;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["CornerType"]!.SetValue(elementStyle_0, value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public int CornerDiameter
	{
		get
		{
			return elementStyle_0.CornerDiameter;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["CornerDiameter"]!.SetValue(elementStyle_0, value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public eBorderType Border
	{
		get
		{
			return eBorderType.None;
		}
		set
		{
			eStyleBorderType eStyleBorderType2 = eStyleBorderType.None;
			if (value != 0)
			{
				eStyleBorderType2 = eStyleBorderType.Solid;
			}
			TypeDescriptor.GetProperties(elementStyle_0)["BorderLeft"]!.SetValue(elementStyle_0, eStyleBorderType2);
			TypeDescriptor.GetProperties(elementStyle_0)["BorderTop"]!.SetValue(elementStyle_0, eStyleBorderType2);
			TypeDescriptor.GetProperties(elementStyle_0)["BorderRight"]!.SetValue(elementStyle_0, eStyleBorderType2);
			TypeDescriptor.GetProperties(elementStyle_0)["BorderBottom"]!.SetValue(elementStyle_0, eStyleBorderType2);
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DashStyle BorderDashStyle
	{
		get
		{
			return (DashStyle)0;
		}
		set
		{
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public eBorderSide BorderSide
	{
		get
		{
			return eBorderSide.None;
		}
		set
		{
			if ((value & eBorderSide.Left) == eBorderSide.Left)
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderLeft"]!.SetValue(elementStyle_0, eStyleBorderType.Solid);
			}
			else
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderLeft"]!.SetValue(elementStyle_0, eStyleBorderType.None);
			}
			if ((value & eBorderSide.Right) == eBorderSide.Right)
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderRight"]!.SetValue(elementStyle_0, eStyleBorderType.Solid);
			}
			else
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderRight"]!.SetValue(elementStyle_0, eStyleBorderType.None);
			}
			if ((value & eBorderSide.Top) == eBorderSide.Top)
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderTop"]!.SetValue(elementStyle_0, eStyleBorderType.Solid);
			}
			else
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderTop"]!.SetValue(elementStyle_0, eStyleBorderType.None);
			}
			if ((value & eBorderSide.Bottom) == eBorderSide.Bottom)
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderBottom"]!.SetValue(elementStyle_0, eStyleBorderType.Solid);
			}
			else
			{
				TypeDescriptor.GetProperties(elementStyle_0)["BorderBottom"]!.SetValue(elementStyle_0, eStyleBorderType.None);
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public ColorExMapper BorderColor => colorExMapper_3;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	public int BorderWidth
	{
		get
		{
			return elementStyle_0.BorderLeftWidth;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["BorderLeftWidth"]!.SetValue(elementStyle_0, value);
			TypeDescriptor.GetProperties(elementStyle_0)["BorderTopWidth"]!.SetValue(elementStyle_0, value);
			TypeDescriptor.GetProperties(elementStyle_0)["BorderRightWidth"]!.SetValue(elementStyle_0, value);
			TypeDescriptor.GetProperties(elementStyle_0)["BorderBottomWidth"]!.SetValue(elementStyle_0, value);
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int MarginLeft
	{
		get
		{
			return elementStyle_0.MarginLeft;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["MarginLeft"]!.SetValue(elementStyle_0, value);
		}
	}

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int MarginRight
	{
		get
		{
			return elementStyle_0.MarginRight;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["MarginRight"]!.SetValue(elementStyle_0, value);
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int MarginTop
	{
		get
		{
			return elementStyle_0.MarginTop;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["MarginTop"]!.SetValue(elementStyle_0, value);
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int MarginBottom
	{
		get
		{
			return elementStyle_0.MarginBottom;
		}
		set
		{
			TypeDescriptor.GetProperties(elementStyle_0)["MarginBottom"]!.SetValue(elementStyle_0, value);
		}
	}

	public ItemStyleMapper(ElementStyle style)
	{
		elementStyle_0 = style;
		colorExMapper_0 = new ColorExMapper("BackColor", style);
		colorExMapper_1 = new ColorExMapper("BackColor2", style);
		colorExMapper_2 = new ColorExMapper("TextColor", style);
		colorExMapper_3 = new ColorExMapper("BorderColor", style);
	}
}
