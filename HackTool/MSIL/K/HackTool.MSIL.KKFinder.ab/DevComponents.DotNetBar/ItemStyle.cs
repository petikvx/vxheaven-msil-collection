using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar;

[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class ItemStyle : ICloneable
{
	private const eBorderSide eBorderSide_0 = eBorderSide.All;

	private const int int_0 = 8;

	private ColorEx colorEx_0 = ColorEx.Empty;

	private ColorEx colorEx_1 = ColorEx.Empty;

	private int int_1;

	private ColorEx colorEx_2 = ColorEx.Empty;

	private Font font_0;

	private Image image_0;

	private eBackgroundImagePosition eBackgroundImagePosition_0;

	private byte byte_0 = byte.MaxValue;

	private bool bool_0;

	private StringAlignment stringAlignment_0;

	private StringAlignment stringAlignment_1 = (StringAlignment)1;

	private StringTrimming stringTrimming_0 = (StringTrimming)3;

	private eBorderType eBorderType_0;

	private eBorderSide eBorderSide_1 = eBorderSide.All;

	private int int_2 = 1;

	private ColorEx colorEx_3 = ColorEx.Empty;

	private bool bool_1;

	private DashStyle dashStyle_0;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private bool bool_2;

	private EventHandler eventHandler_0;

	private eCornerType eCornerType_0 = eCornerType.Square;

	private int int_7 = 8;

	internal bool Boolean_0
	{
		get
		{
			return bool_1 | colorEx_0.bool_0 | colorEx_1.bool_0 | colorEx_2.bool_0;
		}
		set
		{
			bool_1 = value;
			colorEx_0.bool_0 = value;
			colorEx_1.bool_0 = value;
			colorEx_2.bool_0 = value;
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	public bool VerticalText
	{
		get
		{
			return bool_2;
		}
		set
		{
			if (bool_2 != value)
			{
				bool_2 = value;
				method_3();
			}
		}
	}

	[Description("Gets or sets a background color or starting color for gradient background.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	[Category("Style")]
	public ColorEx BackColor1 => colorEx_0;

	[NotifyParentProperty(true)]
	[Browsable(true)]
	[Category("Style")]
	[Description("Gets or sets a background color or ending color for gradient background.")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ColorEx BackColor2 => colorEx_1;

	[Description("Gets or sets a text color.")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	public ColorEx ForeColor => colorEx_2;

	[Category("Style")]
	[Description("Gets or sets the gradient angle.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(0)]
	[NotifyParentProperty(true)]
	public int GradientAngle
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[Description("Gets or sets the style Font")]
	[DefaultValue(null)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	[Category("Style")]
	public Font Font
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			bool_1 = true;
			method_3();
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets a value that determines whether text is displayed in multiple lines or one long line.")]
	[Browsable(true)]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[DefaultValue(false)]
	public bool WordWrap
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (bool_0 != value)
			{
				bool_0 = value;
			}
			bool_1 = true;
			method_3();
		}
	}

	[Description("Specifies alignment of the text.")]
	[Browsable(true)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	public StringAlignment Alignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return stringAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			if (stringAlignment_0 != value)
			{
				stringAlignment_0 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies alignment of the text.")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	[Category("Style")]
	public StringAlignment LineAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return stringAlignment_1;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			if (stringAlignment_1 != value)
			{
				stringAlignment_1 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[DevCoBrowsable(true)]
	[Description("Specifies how to trim characters when text does not fit.")]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	[Category("Style")]
	public StringTrimming TextTrimming
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return stringTrimming_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			if (stringTrimming_0 != value)
			{
				stringTrimming_0 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[DefaultValue(null)]
	[DevCoBrowsable(true)]
	[Description("Specifies background image.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[Browsable(true)]
	public Image BackgroundImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			bool_1 = true;
			method_3();
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies background image position when container is larger than image.")]
	[DefaultValue(eBackgroundImagePosition.Stretch)]
	[NotifyParentProperty(true)]
	public eBackgroundImagePosition BackgroundImagePosition
	{
		get
		{
			return eBackgroundImagePosition_0;
		}
		set
		{
			if (eBackgroundImagePosition_0 != value)
			{
				eBackgroundImagePosition_0 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[DefaultValue(byte.MaxValue)]
	[Category("Style")]
	[Description("Specifies the transparency of background image.")]
	[NotifyParentProperty(true)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public byte BackgroundImageAlpha
	{
		get
		{
			return byte_0;
		}
		set
		{
			if (byte_0 != value)
			{
				byte_0 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[NotifyParentProperty(true)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(eCornerType.Square)]
	[Description("Indicates corner type.")]
	public eCornerType CornerType
	{
		get
		{
			return eCornerType_0;
		}
		set
		{
			if (eCornerType_0 != value)
			{
				eCornerType_0 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates diameter in pixels of the corner type rounded or diagonal.")]
	[NotifyParentProperty(true)]
	[Category("Style")]
	[DefaultValue(8)]
	[DevCoBrowsable(true)]
	public int CornerDiameter
	{
		get
		{
			return int_7;
		}
		set
		{
			if (int_7 != value)
			{
				int_7 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(eBorderType.None)]
	[Category("Style")]
	[Description("Specifies the border type.")]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	public eBorderType Border
	{
		get
		{
			return eBorderType_0;
		}
		set
		{
			if (eBorderType_0 != value)
			{
				eBorderType_0 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[Browsable(true)]
	[NotifyParentProperty(true)]
	[Description("Indicates dash style for single line border type.")]
	[Category("Style")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[DevCoBrowsable(true)]
	public DashStyle BorderDashStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return dashStyle_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			dashStyle_0 = value;
			method_3();
		}
	}

	[NotifyParentProperty(true)]
	[DefaultValue(eBorderSide.All)]
	[Category("Style")]
	[Description("Specifies border sides that are displayed.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public eBorderSide BorderSide
	{
		get
		{
			return eBorderSide_1;
		}
		set
		{
			if (eBorderSide_1 != value)
			{
				eBorderSide_1 = value;
				bool_1 = true;
				method_3();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Browsable(true)]
	[Description("Specifies the border color.")]
	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	public ColorEx BorderColor => colorEx_3;

	[NotifyParentProperty(true)]
	[DefaultValue(1)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies the line tickness of single line border.")]
	[Category("Style")]
	public int BorderWidth
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			method_3();
		}
	}

	[Category("Style")]
	[Description("Specifies left text margin.")]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	public int MarginLeft
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			method_3();
		}
	}

	[Description("Specifies right text margin.")]
	[Category("Style")]
	[Browsable(true)]
	[NotifyParentProperty(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	public int MarginRight
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			method_3();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[Description("Specifies top text margin.")]
	[NotifyParentProperty(true)]
	[DefaultValue(0)]
	public int MarginTop
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			method_3();
		}
	}

	[NotifyParentProperty(true)]
	[Description("Specifies bottom text margin.")]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int MarginBottom
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
			method_3();
		}
	}

	internal StringFormat StringFormat_0
	{
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			StringFormat val = Class109.smethod_3();
			val.set_Alignment(stringAlignment_0);
			val.set_LineAlignment(stringAlignment_1);
			if (bool_0)
			{
				val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() & ~(val.get_FormatFlags() & 0x1000)));
			}
			else
			{
				val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 0x1000));
			}
			val.set_Trimming(stringTrimming_0);
			val.set_HotkeyPrefix((HotkeyPrefix)1);
			return val;
		}
	}

	internal Enum10 Enum10_0
	{
		get
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected I4, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected I4, but got Unknown
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected I4, but got Unknown
			Enum10 @enum = Enum10.const_22;
			StringAlignment val = stringAlignment_0;
			switch ((int)val)
			{
			case 0:
				@enum |= (SystemInformation.get_RightAlignedMenus() ? Enum10.const_3 : Enum10.const_0);
				break;
			case 1:
				@enum |= Enum10.const_2;
				break;
			case 2:
				@enum |= ((!SystemInformation.get_RightAlignedMenus()) ? Enum10.const_3 : Enum10.const_0);
				break;
			}
			StringAlignment val2 = stringAlignment_1;
			switch ((int)val2)
			{
			case 0:
				@enum = @enum;
				break;
			case 1:
				@enum |= (bool_0 ? Enum10.const_5 : Enum10.const_4);
				break;
			case 2:
				@enum |= Enum10.const_5;
				break;
			}
			@enum = ((!bool_0) ? (@enum | Enum10.const_7) : (@enum | Enum10.const_6));
			StringTrimming val3 = stringTrimming_0;
			switch (val3 - 1)
			{
			case 0:
				@enum |= Enum10.const_21;
				break;
			case 1:
				@enum |= Enum10.const_20;
				break;
			case 2:
				@enum |= Enum10.const_17;
				break;
			case 3:
				@enum |= Enum10.const_20;
				break;
			case 4:
				@enum |= Enum10.const_16;
				break;
			}
			return @enum;
		}
	}

	internal event EventHandler Event_0
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public ItemStyle()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		colorEx_0.Event_0 += method_2;
		colorEx_1.Event_0 += method_2;
		colorEx_2.Event_0 += method_2;
		colorEx_3.Event_0 += method_2;
	}

	public object Clone()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		ItemStyle itemStyle = new ItemStyle();
		itemStyle.Alignment = Alignment;
		itemStyle.BackColor1.method_0(BackColor1.Color);
		itemStyle.BackColor1.Alpha = BackColor1.Alpha;
		itemStyle.BackColor1.method_1(BackColor1.ColorSchemePart);
		itemStyle.BackColor2.method_0(BackColor2.Color);
		itemStyle.BackColor2.Alpha = BackColor2.Alpha;
		itemStyle.BackColor2.method_1(BackColor2.ColorSchemePart);
		if (BackgroundImage != null)
		{
			object obj = BackgroundImage.Clone();
			itemStyle.BackgroundImage = (Image)((obj is Image) ? obj : null);
		}
		itemStyle.BackgroundImageAlpha = BackgroundImageAlpha;
		itemStyle.BackgroundImagePosition = BackgroundImagePosition;
		itemStyle.Border = Border;
		itemStyle.BorderDashStyle = BorderDashStyle;
		itemStyle.BorderColor.method_0(BorderColor.Color);
		itemStyle.BorderColor.Alpha = BorderColor.Alpha;
		itemStyle.BorderColor.method_1(BorderColor.ColorSchemePart);
		itemStyle.BorderWidth = BorderWidth;
		if (Font != null)
		{
			object obj2 = Font.Clone();
			itemStyle.Font = (Font)((obj2 is Font) ? obj2 : null);
		}
		itemStyle.ForeColor.method_0(ForeColor.Color);
		itemStyle.ForeColor.Alpha = ForeColor.Alpha;
		itemStyle.ForeColor.method_1(ForeColor.ColorSchemePart);
		itemStyle.GradientAngle = GradientAngle;
		itemStyle.LineAlignment = LineAlignment;
		itemStyle.BorderSide = BorderSide;
		itemStyle.TextTrimming = TextTrimming;
		itemStyle.WordWrap = WordWrap;
		itemStyle.Boolean_0 = Boolean_0;
		itemStyle.MarginBottom = MarginBottom;
		itemStyle.MarginLeft = MarginLeft;
		itemStyle.MarginRight = MarginRight;
		itemStyle.MarginTop = MarginTop;
		itemStyle.CornerType = CornerType;
		itemStyle.CornerDiameter = CornerDiameter;
		itemStyle.VerticalText = VerticalText;
		return itemStyle;
	}

	internal void method_0(ItemStyle itemStyle_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Invalid comparison between Unknown and I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		if (itemStyle_0 != null)
		{
			stringAlignment_0 = itemStyle_0.Alignment;
			if (!itemStyle_0.BackColor1.IsEmpty)
			{
				colorEx_0 = itemStyle_0.BackColor1;
			}
			if (!itemStyle_0.BackColor2.IsEmpty)
			{
				colorEx_1 = itemStyle_0.BackColor2;
			}
			if (itemStyle_0.BackgroundImage != null)
			{
				image_0 = itemStyle_0.BackgroundImage;
			}
			if (itemStyle_0.BackgroundImageAlpha != byte.MaxValue)
			{
				byte_0 = itemStyle_0.BackgroundImageAlpha;
			}
			if (itemStyle_0.BackgroundImagePosition != 0)
			{
				eBackgroundImagePosition_0 = itemStyle_0.BackgroundImagePosition;
			}
			if (itemStyle_0.Border != 0)
			{
				eBorderType_0 = itemStyle_0.Border;
			}
			if ((int)itemStyle_0.BorderDashStyle != 0)
			{
				dashStyle_0 = itemStyle_0.BorderDashStyle;
			}
			if (!itemStyle_0.BorderColor.IsEmpty)
			{
				colorEx_3 = itemStyle_0.BorderColor;
			}
			if (itemStyle_0.BorderSide != eBorderSide.All)
			{
				eBorderSide_1 = itemStyle_0.BorderSide;
			}
			if (itemStyle_0.BorderWidth != 1)
			{
				int_2 = itemStyle_0.BorderWidth;
			}
			if (itemStyle_0.Font != null)
			{
				font_0 = itemStyle_0.Font;
			}
			if (!itemStyle_0.ForeColor.IsEmpty)
			{
				colorEx_2 = itemStyle_0.ForeColor;
			}
			if ((int)itemStyle_0.LineAlignment != 1)
			{
				stringAlignment_1 = itemStyle_0.LineAlignment;
			}
			if ((int)itemStyle_0.TextTrimming != 3)
			{
				stringTrimming_0 = itemStyle_0.TextTrimming;
			}
			if (itemStyle_0.WordWrap)
			{
				bool_0 = itemStyle_0.WordWrap;
			}
			if (itemStyle_0.MarginBottom != 0)
			{
				int_6 = itemStyle_0.MarginBottom;
			}
			if (itemStyle_0.MarginLeft != 0)
			{
				int_3 = itemStyle_0.MarginLeft;
			}
			if (itemStyle_0.MarginRight != 0)
			{
				int_4 = itemStyle_0.MarginRight;
			}
			if (itemStyle_0.MarginTop != 0)
			{
				int_5 = itemStyle_0.MarginTop;
			}
			if (itemStyle_0.CornerType != eCornerType.Square)
			{
				eCornerType_0 = itemStyle_0.CornerType;
			}
			if (itemStyle_0.CornerDiameter != 8)
			{
				int_7 = itemStyle_0.CornerDiameter;
			}
			if (itemStyle_0.VerticalText)
			{
				bool_2 = itemStyle_0.VerticalText;
			}
		}
	}

	internal void method_1(ColorScheme colorScheme_0)
	{
		if (BackColor1.ColorSchemePart != eColorSchemePart.Custom)
		{
			BackColor1.method_0((Color)colorScheme_0.GetType().GetProperty(BackColor1.ColorSchemePart.ToString())!.GetValue(colorScheme_0, null));
		}
		if (BackColor2.ColorSchemePart != eColorSchemePart.Custom)
		{
			BackColor2.method_0((Color)colorScheme_0.GetType().GetProperty(BackColor2.ColorSchemePart.ToString())!.GetValue(colorScheme_0, null));
		}
		if (BorderColor.ColorSchemePart != eColorSchemePart.Custom)
		{
			BorderColor.method_0((Color)colorScheme_0.GetType().GetProperty(BorderColor.ColorSchemePart.ToString())!.GetValue(colorScheme_0, null));
		}
		if (ForeColor.ColorSchemePart != eColorSchemePart.Custom)
		{
			ForeColor.method_0((Color)colorScheme_0.GetType().GetProperty(ForeColor.ColorSchemePart.ToString())!.GetValue(colorScheme_0, null));
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		method_3();
	}

	private void method_3()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor1()
	{
		return !colorEx_0.IsEmpty;
	}

	public void ResetBackColor1()
	{
		colorEx_0.Event_0 -= method_2;
		colorEx_0 = ColorEx.Empty;
		colorEx_0.Event_0 += method_2;
	}

	internal void method_4(ColorEx colorEx_4)
	{
		colorEx_0 = colorEx_4;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor2()
	{
		return !colorEx_1.IsEmpty;
	}

	public void ResetBackColor2()
	{
		colorEx_1.Event_0 -= method_2;
		colorEx_1 = ColorEx.Empty;
		colorEx_1.Event_0 += method_2;
	}

	internal void method_5(ColorEx colorEx_4)
	{
		colorEx_1 = colorEx_4;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeForeColor()
	{
		return !colorEx_2.IsEmpty;
	}

	internal Region method_6(Rectangle rectangle_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		rectangle_0.Width++;
		rectangle_0.Height++;
		GraphicsPath val = method_7(rectangle_0);
		Region val2 = new Region();
		val2.MakeEmpty();
		val2.Union(val);
		if (eBorderType_0 != 0 && int_2 > 0 && eCornerType_0 != eCornerType.Square && !colorEx_3.IsEmpty)
		{
			Pen val3 = new Pen(Color.Black, (float)int_2);
			try
			{
				val.Widen(val3);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			new Region(val);
			val2.Union(val);
		}
		return val2;
	}

	private GraphicsPath method_7(Rectangle rectangle_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		if (eCornerType_0 != eCornerType.Square)
		{
			rectangle_0.Width--;
			rectangle_0.Height--;
		}
		switch (eCornerType_0)
		{
		case eCornerType.Square:
			val.AddRectangle(rectangle_0);
			break;
		case eCornerType.Rounded:
			val.AddLine(rectangle_0.X, rectangle_0.Bottom - int_7, rectangle_0.X, rectangle_0.Y + int_7);
			val.AddArc(rectangle_0.X, rectangle_0.Y, int_7 * 2, int_7 * 2, 180f, 90f);
			val.AddLine(rectangle_0.X + int_7, rectangle_0.Y, rectangle_0.Right - int_7, rectangle_0.Y);
			val.AddArc(rectangle_0.Right - int_7 * 2, rectangle_0.Y, int_7 * 2, int_7 * 2, 270f, 90f);
			val.AddLine(rectangle_0.Right, rectangle_0.Y + int_7, rectangle_0.Right, rectangle_0.Bottom - int_7);
			val.AddArc(rectangle_0.Right - int_7 * 2, rectangle_0.Bottom - int_7 * 2, int_7 * 2, int_7 * 2, 0f, 90f);
			val.AddLine(rectangle_0.Right - int_7, rectangle_0.Bottom, rectangle_0.X + int_7, rectangle_0.Bottom);
			val.AddArc(rectangle_0.X, rectangle_0.Bottom - int_7 * 2, int_7 * 2, int_7 * 2, 90f, 90f);
			val.CloseAllFigures();
			break;
		case eCornerType.Diagonal:
			val.AddLine(rectangle_0.X, rectangle_0.Bottom - int_7, rectangle_0.X, rectangle_0.Y + int_7);
			val.AddLine(rectangle_0.X + int_7, rectangle_0.Y, rectangle_0.Right - int_7, rectangle_0.Y);
			val.AddLine(rectangle_0.Right, rectangle_0.Y + int_7, rectangle_0.Right, rectangle_0.Bottom - int_7);
			val.AddLine(rectangle_0.Right - int_7, rectangle_0.Bottom, rectangle_0.X + int_7, rectangle_0.Bottom);
			val.CloseAllFigures();
			break;
		}
		return val;
	}

	public void ResetBackgroundImage()
	{
		image_0 = null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColor()
	{
		return !colorEx_3.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderColor()
	{
		colorEx_3.Event_0 -= method_2;
		colorEx_3 = ColorEx.Empty;
		colorEx_3.Event_0 += method_2;
	}

	public void Paint(Graphics g, Rectangle r, string text, Rectangle textRect, Font font)
	{
		Paint(g, r, text, textRect, font, null);
	}

	public void Paint(Graphics g, Rectangle r, string text, Rectangle textRect, Font font, Point[] borderShape)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		if (r.Width == 0 || r.Height == 0)
		{
			return;
		}
		Rectangle rectangle_ = r;
		if ((int)g.get_SmoothingMode() == 4)
		{
			rectangle_.Inflate(1, 1);
		}
		if (eBorderType_0 != 0 && !colorEx_3.IsEmpty)
		{
			int num = 1;
			if (int_2 > 1)
			{
				num = int_2 / 2;
			}
			if ((eBorderSide_1 & eBorderSide.Top) == eBorderSide.Top)
			{
				rectangle_.Y += num;
				rectangle_.Height -= num;
			}
			if ((eBorderSide_1 & eBorderSide.Bottom) == eBorderSide.Bottom)
			{
				rectangle_.Height -= num;
			}
			if ((eBorderSide_1 & eBorderSide.Left) == eBorderSide.Left)
			{
				rectangle_.X += num;
				rectangle_.Width -= num;
			}
			if ((eBorderSide_1 & eBorderSide.Right) == eBorderSide.Right)
			{
				rectangle_.Width -= num;
			}
		}
		GraphicsPath val = method_7(rectangle_);
		if (!colorEx_0.IsEmpty)
		{
			if (!colorEx_1.IsEmpty)
			{
				Color color_ = Color.FromArgb(colorEx_0.Alpha, colorEx_0.Color);
				Color color_2 = Color.FromArgb(colorEx_1.Alpha, colorEx_1.Color);
				Rectangle rectangle_2 = r;
				rectangle_2.Inflate(1, 1);
				LinearGradientBrush val2 = Class109.smethod_42(rectangle_2, color_, color_2, int_1, bool_3: false);
				g.FillPath((Brush)(object)val2, val);
				((Brush)val2).Dispose();
			}
			else if (colorEx_0.Color != Color.Transparent)
			{
				Color color = Color.FromArgb(colorEx_0.Alpha, colorEx_0.Color);
				SolidBrush val3 = new SolidBrush(color);
				g.FillPath((Brush)(object)val3, val);
				((Brush)val3).Dispose();
			}
		}
		val = method_7(r);
		if (image_0 != null)
		{
			Region clip = g.get_Clip();
			g.SetClip(val);
			Class109.smethod_63(g, r, image_0, eBackgroundImagePosition_0, byte_0);
			g.set_Clip(clip);
		}
		if (eBorderType_0 != 0 && !colorEx_3.IsEmpty)
		{
			if (eCornerType_0 != eCornerType.Square)
			{
				if ((int)dashStyle_0 == 0)
				{
					g.set_SmoothingMode((SmoothingMode)4);
				}
				Pen val4 = new Pen(colorEx_3.GetCompositeColor(), (float)int_2);
				try
				{
					val4.set_Alignment((PenAlignment)1);
					val4.set_DashStyle(dashStyle_0);
					g.DrawPath(val4, val);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				if ((int)dashStyle_0 == 0)
				{
					g.set_SmoothingMode((SmoothingMode)0);
				}
			}
			else if (eBorderType_0 == eBorderType.SingleLine && borderShape != null && borderShape.Length > 0)
			{
				Pen val5 = new Pen(colorEx_3.GetCompositeColor(), (float)int_2);
				try
				{
					val5.set_DashStyle(dashStyle_0);
					g.DrawLines(val5, borderShape);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			else
			{
				switch (eBorderType_0)
				{
				case eBorderType.Sunken:
					Class109.smethod_36(border3DSide_0: (eBorderSide_1 != eBorderSide.All) ? ((Border3DSide)((((eBorderSide_1 & eBorderSide.Left) != 0) ? 1 : 0) | (((eBorderSide_1 & eBorderSide.Right) != 0) ? 4 : 0) | (((eBorderSide_1 & eBorderSide.Top) != 0) ? 2 : 0) | (((eBorderSide_1 & eBorderSide.Bottom) != 0) ? 8 : 0))) : ((Border3DSide)2063), graphics_0: g, rectangle_0: r, border3DStyle_0: (Border3DStyle)2, color_0: colorEx_3.IsEmpty ? colorEx_0.Color : Color.FromArgb(colorEx_3.Alpha, colorEx_3.Color), bool_3: false);
					break;
				case eBorderType.Raised:
					Class109.smethod_36(border3DSide_0: (eBorderSide_1 != eBorderSide.All) ? ((Border3DSide)((((eBorderSide_1 & eBorderSide.Left) != 0) ? 1 : 0) | (((eBorderSide_1 & eBorderSide.Right) != 0) ? 4 : 0) | (((eBorderSide_1 & eBorderSide.Top) != 0) ? 2 : 0) | (((eBorderSide_1 & eBorderSide.Bottom) != 0) ? 8 : 0))) : ((Border3DSide)2063), graphics_0: g, rectangle_0: r, border3DStyle_0: (Border3DStyle)4, color_0: colorEx_3.IsEmpty ? colorEx_0.Color : Color.FromArgb(colorEx_3.Alpha, colorEx_3.Color), bool_3: false);
					break;
				case eBorderType.SingleLine:
				case eBorderType.DoubleLine:
				case eBorderType.Etched:
				case eBorderType.Bump:
					Class109.smethod_31(g, eBorderType_0, r, colorEx_3.IsEmpty ? SystemColors.ControlText : Color.FromArgb(colorEx_3.Alpha, colorEx_3.Color), eBorderSide_1, dashStyle_0, int_2);
					break;
				case eBorderType.RaisedInner:
				{
					Pen val6 = new Pen(Color.White);
					try
					{
						if ((eBorderSide_1 & eBorderSide.Top) == eBorderSide.Top)
						{
							g.DrawLine(val6, r.X, r.Y, r.Right, r.Y);
						}
						if ((eBorderSide_1 & eBorderSide.Left) == eBorderSide.Left)
						{
							g.DrawLine(val6, r.X, r.Y, r.X, r.Bottom);
						}
					}
					finally
					{
						((IDisposable)val6)?.Dispose();
					}
					Pen val7 = new Pen(colorEx_3.GetCompositeColor());
					try
					{
						if ((eBorderSide_1 & eBorderSide.Right) == eBorderSide.Right)
						{
							g.DrawLine(val7, r.Right - 1, r.Y, r.Right - 1, r.Bottom);
						}
						if ((eBorderSide_1 & eBorderSide.Bottom) == eBorderSide.Bottom)
						{
							g.DrawLine(val7, r.X, r.Bottom - 1, r.Right, r.Bottom - 1);
						}
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
					break;
				}
				}
			}
		}
		if (text != "" && !colorEx_2.IsEmpty)
		{
			if (font_0 != null)
			{
				font = font_0;
			}
			Color color_3 = Color.FromArgb(colorEx_2.Alpha, colorEx_2.Color);
			if (int_3 != 0)
			{
				textRect.X += int_3;
				textRect.Width -= int_3;
			}
			if (int_4 != 0)
			{
				textRect.Width -= int_4;
			}
			if (int_5 != 0)
			{
				textRect.Y += int_5;
				textRect.Height -= int_5;
			}
			if (int_6 != 0)
			{
				textRect.Height -= int_6;
			}
			if (textRect.Width > 0 && textRect.Height > 0)
			{
				if (bool_2)
				{
					g.RotateTransform(-90f);
					Class55.smethod_2(g, text, font, color_3, new Rectangle(-textRect.Bottom, textRect.X, textRect.Height, textRect.Width), method_8());
					g.ResetTransform();
				}
				else
				{
					Class55.smethod_1(g, text, font, color_3, textRect, method_8());
				}
			}
		}
		if (eCornerType_0 != eCornerType.Square)
		{
			g.ResetClip();
		}
	}

	public void Paint(Graphics g, Rectangle r)
	{
		Paint(g, r, "", Rectangle.Empty, Control.get_DefaultFont());
	}

	public void PaintText(Graphics g, string text, Rectangle textRect, Font font)
	{
		if (!(text != ""))
		{
			return;
		}
		if (font_0 != null)
		{
			font = font_0;
		}
		Color color_ = Color.FromArgb(colorEx_2.Alpha, colorEx_2.Color);
		if (int_3 != 0)
		{
			textRect.X += int_3;
			textRect.Width -= int_3;
		}
		if (int_4 != 0)
		{
			textRect.Width -= int_4;
		}
		if (int_5 != 0)
		{
			textRect.Y += int_5;
			textRect.Height -= int_5;
		}
		if (int_6 != 0)
		{
			textRect.Height -= int_6;
		}
		if (textRect.Width > 0 && textRect.Height > 0)
		{
			if (bool_2)
			{
				g.RotateTransform(-90f);
				Class55.smethod_2(g, text, font, color_, new Rectangle(-textRect.Bottom, textRect.X, textRect.Height, textRect.Width), method_8());
				g.ResetTransform();
			}
			else
			{
				Class55.smethod_1(g, text, font, color_, textRect, method_8());
			}
		}
	}

	internal eTextFormat method_8()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		eTextFormat eTextFormat2 = eTextFormat.Default;
		if ((int)stringAlignment_0 == 1)
		{
			eTextFormat2 |= eTextFormat.HorizontalCenter;
		}
		else if ((int)stringAlignment_0 == 2)
		{
			eTextFormat2 |= eTextFormat.Right;
		}
		if ((int)stringAlignment_1 == 1)
		{
			eTextFormat2 |= eTextFormat.VerticalCenter;
		}
		else if ((int)stringAlignment_1 == 2)
		{
			eTextFormat2 |= eTextFormat.Bottom;
		}
		eTextFormat2 = (bool_0 ? (eTextFormat2 | eTextFormat.WordBreak) : (eTextFormat2 | eTextFormat.SingleLine));
		if ((int)stringTrimming_0 != 0)
		{
			eTextFormat2 |= eTextFormat.EndEllipsis;
		}
		return eTextFormat2;
	}

	internal void method_9(XmlElement xmlElement_0)
	{
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected I4, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected I4, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Invalid comparison between Unknown and I4
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected I4, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Invalid comparison between Unknown and I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected I4, but got Unknown
		if (!colorEx_0.IsEmpty)
		{
			if (colorEx_0.ColorSchemePart == eColorSchemePart.Custom)
			{
				xmlElement_0.SetAttribute("bc1", Class109.smethod_50(colorEx_0.Color));
				xmlElement_0.SetAttribute("bc1a", colorEx_0.Alpha.ToString());
			}
			else
			{
				xmlElement_0.SetAttribute("bc1csp", colorEx_0.ColorSchemePart.ToString());
			}
		}
		if (!colorEx_1.IsEmpty)
		{
			if (colorEx_1.ColorSchemePart == eColorSchemePart.Custom)
			{
				xmlElement_0.SetAttribute("bc2", Class109.smethod_50(colorEx_1.Color));
				xmlElement_0.SetAttribute("bc2a", colorEx_1.Alpha.ToString());
			}
			else
			{
				xmlElement_0.SetAttribute("bc2csp", colorEx_1.ColorSchemePart.ToString());
			}
		}
		if (!colorEx_2.IsEmpty)
		{
			if (colorEx_2.ColorSchemePart == eColorSchemePart.Custom)
			{
				xmlElement_0.SetAttribute("fc", Class109.smethod_50(colorEx_2.Color));
				xmlElement_0.SetAttribute("fca", colorEx_2.Alpha.ToString());
			}
			else
			{
				xmlElement_0.SetAttribute("fccsp", colorEx_2.ColorSchemePart.ToString());
			}
		}
		if (!colorEx_3.IsEmpty)
		{
			if (colorEx_3.ColorSchemePart == eColorSchemePart.Custom)
			{
				xmlElement_0.SetAttribute("borderc", Class109.smethod_50(colorEx_3.Color));
				xmlElement_0.SetAttribute("borderca", colorEx_3.Alpha.ToString());
			}
			else
			{
				xmlElement_0.SetAttribute("bordercsp", colorEx_3.ColorSchemePart.ToString());
			}
		}
		xmlElement_0.SetAttribute("ga", int_1.ToString());
		if (font_0 != null)
		{
			xmlElement_0.SetAttribute("fontname", font_0.get_Name());
			xmlElement_0.SetAttribute("fontemsize", XmlConvert.ToString(font_0.get_Size()));
			xmlElement_0.SetAttribute("fontstyle", XmlConvert.ToString((int)font_0.get_Style()));
		}
		if (image_0 != null)
		{
			XmlElement xmlElement = xmlElement_0.OwnerDocument.CreateElement("backimage");
			xmlElement_0.AppendChild(xmlElement);
			Class109.smethod_13(image_0, xmlElement);
			int num = (int)eBackgroundImagePosition_0;
			xmlElement.SetAttribute("pos", num.ToString());
			xmlElement.SetAttribute("alpha", byte_0.ToString());
		}
		if (bool_0)
		{
			xmlElement_0.SetAttribute("wordwrap", XmlConvert.ToString(bool_0));
		}
		if ((int)stringAlignment_0 != 0)
		{
			xmlElement_0.SetAttribute("align", XmlConvert.ToString((int)stringAlignment_0));
		}
		if ((int)stringAlignment_1 != 1)
		{
			xmlElement_0.SetAttribute("valign", XmlConvert.ToString((int)stringAlignment_1));
		}
		if ((int)stringTrimming_0 != 3)
		{
			xmlElement_0.SetAttribute("trim", XmlConvert.ToString((int)stringTrimming_0));
		}
		if (eBorderType_0 != 0)
		{
			xmlElement_0.SetAttribute("border", XmlConvert.ToString((int)eBorderType_0));
		}
		if (int_2 != 1)
		{
			xmlElement_0.SetAttribute("borderw", int_2.ToString());
		}
		if (int_7 != 8)
		{
			xmlElement_0.SetAttribute("cornerdiameter", int_7.ToString());
		}
		if (eCornerType_0 != eCornerType.Square)
		{
			xmlElement_0.SetAttribute("cornertype", XmlConvert.ToString((int)eCornerType_0));
		}
	}

	internal void method_10(XmlElement xmlElement_0)
	{
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		colorEx_0 = ColorEx.Empty;
		if (xmlElement_0.HasAttribute("bc1"))
		{
			colorEx_0.Color = Class109.smethod_51(xmlElement_0.GetAttribute("bc1"));
			colorEx_0.Alpha = XmlConvert.ToByte(xmlElement_0.GetAttribute("bc1a"));
		}
		else if (xmlElement_0.HasAttribute("bc1csp"))
		{
			colorEx_0.ColorSchemePart = (eColorSchemePart)Enum.Parse(typeof(eColorSchemePart), xmlElement_0.GetAttribute("bc1csp"));
		}
		colorEx_1 = ColorEx.Empty;
		if (xmlElement_0.HasAttribute("bc2"))
		{
			colorEx_1.Color = Class109.smethod_51(xmlElement_0.GetAttribute("bc2"));
			colorEx_1.Alpha = XmlConvert.ToByte(xmlElement_0.GetAttribute("bc2a"));
		}
		else if (xmlElement_0.HasAttribute("bc2csp"))
		{
			colorEx_1.ColorSchemePart = (eColorSchemePart)Enum.Parse(typeof(eColorSchemePart), xmlElement_0.GetAttribute("bc2csp"));
		}
		colorEx_2 = ColorEx.Empty;
		if (xmlElement_0.HasAttribute("fc"))
		{
			colorEx_2.Color = Class109.smethod_51(xmlElement_0.GetAttribute("fc"));
			colorEx_2.Alpha = XmlConvert.ToByte(xmlElement_0.GetAttribute("fca"));
		}
		else if (xmlElement_0.HasAttribute("fccsp"))
		{
			colorEx_2.ColorSchemePart = (eColorSchemePart)Enum.Parse(typeof(eColorSchemePart), xmlElement_0.GetAttribute("fccsp"));
		}
		colorEx_3 = ColorEx.Empty;
		if (xmlElement_0.HasAttribute("borderc"))
		{
			colorEx_3.Color = Class109.smethod_51(xmlElement_0.GetAttribute("borderc"));
			colorEx_3.Alpha = XmlConvert.ToByte(xmlElement_0.GetAttribute("borderca"));
		}
		else if (xmlElement_0.HasAttribute("bordercsp"))
		{
			colorEx_3.ColorSchemePart = (eColorSchemePart)Enum.Parse(typeof(eColorSchemePart), xmlElement_0.GetAttribute("bordercsp"));
		}
		int_1 = XmlConvert.ToInt16(xmlElement_0.GetAttribute("ga"));
		font_0 = null;
		if (xmlElement_0.HasAttribute("fontname"))
		{
			string attribute = xmlElement_0.GetAttribute("fontname");
			float num = XmlConvert.ToSingle(xmlElement_0.GetAttribute("fontemsize"));
			FontStyle val = (FontStyle)XmlConvert.ToInt32(xmlElement_0.GetAttribute("fontstyle"));
			try
			{
				font_0 = new Font(attribute, num, val);
			}
			catch (Exception)
			{
				font_0 = null;
			}
		}
		image_0 = null;
		foreach (XmlElement childNode in xmlElement_0.ChildNodes)
		{
			if (childNode.Name == "backimage")
			{
				image_0 = Class109.smethod_16(childNode);
				eBackgroundImagePosition_0 = (eBackgroundImagePosition)XmlConvert.ToInt32(childNode.GetAttribute("pos"));
				byte_0 = XmlConvert.ToByte(childNode.GetAttribute("alpha"));
			}
		}
		bool_0 = false;
		if (xmlElement_0.HasAttribute("wordwrap"))
		{
			bool_0 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("wordwrap"));
		}
		stringAlignment_0 = (StringAlignment)0;
		if (xmlElement_0.HasAttribute("align"))
		{
			stringAlignment_0 = (StringAlignment)XmlConvert.ToInt32(xmlElement_0.GetAttribute("align"));
		}
		stringAlignment_1 = (StringAlignment)1;
		if (xmlElement_0.HasAttribute("valign"))
		{
			stringAlignment_1 = (StringAlignment)XmlConvert.ToInt32(xmlElement_0.GetAttribute("valign"));
		}
		stringTrimming_0 = (StringTrimming)3;
		if (xmlElement_0.HasAttribute("trim"))
		{
			stringTrimming_0 = (StringTrimming)XmlConvert.ToInt32(xmlElement_0.GetAttribute("trim"));
		}
		eBorderType_0 = eBorderType.None;
		if (xmlElement_0.HasAttribute("border"))
		{
			eBorderType_0 = (eBorderType)XmlConvert.ToInt32(xmlElement_0.GetAttribute("border"));
		}
		int_2 = 1;
		if (xmlElement_0.HasAttribute("borderw"))
		{
			int_2 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("borderw"));
		}
		eCornerType_0 = eCornerType.Square;
		if (xmlElement_0.HasAttribute("cornertype"))
		{
			eCornerType_0 = (eCornerType)XmlConvert.ToInt32(xmlElement_0.GetAttribute("cornertype"));
		}
		int_7 = 8;
		if (xmlElement_0.HasAttribute("cornerdiameter"))
		{
			int_7 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("cornerdiameter"));
		}
	}
}
