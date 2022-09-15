using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using DevComponents.AdvTree;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class ElementStyle : IComponent, IDisposable
{
	private const int int_0 = 8;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private Color color_0 = Color.Empty;

	private eColorSchemePart eColorSchemePart_0 = eColorSchemePart.None;

	private Color color_1 = Color.Empty;

	private eColorSchemePart eColorSchemePart_1 = eColorSchemePart.None;

	private int int_1;

	private Image image_0;

	private eStyleBackgroundImage eStyleBackgroundImage_0;

	private byte byte_0 = byte.MaxValue;

	private eGradientType eGradientType_0;

	private Font font_0;

	private bool bool_0;

	private eStyleTextAlignment eStyleTextAlignment_0;

	private eStyleTextAlignment eStyleTextAlignment_1 = eStyleTextAlignment.Center;

	private eStyleTextTrimming eStyleTextTrimming_0 = eStyleTextTrimming.EllipsisCharacter;

	private Color color_2 = Color.Empty;

	private eColorSchemePart eColorSchemePart_2 = eColorSchemePart.None;

	private Color color_3 = Color.Empty;

	private eColorSchemePart eColorSchemePart_3 = eColorSchemePart.None;

	private Point point_0 = Point.Empty;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private eStyleBorderType eStyleBorderType_0;

	private eStyleBorderType eStyleBorderType_1;

	private eStyleBorderType eStyleBorderType_2;

	private eStyleBorderType eStyleBorderType_3;

	private Color color_4 = Color.Empty;

	private eColorSchemePart eColorSchemePart_4 = eColorSchemePart.None;

	private Color color_5 = Color.Empty;

	private eColorSchemePart eColorSchemePart_5 = eColorSchemePart.None;

	private int int_10 = 90;

	private Color color_6 = Color.Empty;

	private eColorSchemePart eColorSchemePart_6 = eColorSchemePart.None;

	private Color color_7 = Color.Empty;

	private eColorSchemePart eColorSchemePart_7 = eColorSchemePart.None;

	private int int_11 = 90;

	private Color color_8 = Color.Empty;

	private eColorSchemePart eColorSchemePart_8 = eColorSchemePart.None;

	private Color color_9 = Color.Empty;

	private eColorSchemePart eColorSchemePart_9 = eColorSchemePart.None;

	private Color color_10 = Color.Empty;

	private eColorSchemePart eColorSchemePart_10 = eColorSchemePart.None;

	private Color color_11 = Color.Empty;

	private eColorSchemePart eColorSchemePart_11 = eColorSchemePart.None;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private eCornerType eCornerType_0 = eCornerType.Square;

	private eCornerType eCornerType_1;

	private eCornerType eCornerType_2;

	private eCornerType eCornerType_3;

	private eCornerType eCornerType_4;

	private int int_16 = 8;

	private Size size_0 = Size.Empty;

	private bool bool_1 = true;

	private string string_0 = "";

	private string string_1 = "";

	private int int_17;

	private ISite isite_0;

	private bool bool_2;

	private ColorScheme colorScheme_0;

	private BackgroundColorBlendCollection backgroundColorBlendCollection_0 = new BackgroundColorBlendCollection();

	private string string_2 = "";

	private bool bool_3;

	private eOrientation eOrientation_0;

	private int int_18;

	private ElementStyleCollection elementStyleCollection_0;

	private DevComponents.AdvTree.AdvTree advTree_0;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Collection that defines the multicolor gradient background.")]
	public BackgroundColorBlendCollection BackColorBlend => backgroundColorBlendCollection_0;

	[Description("Gets or sets the background color for UI element.")]
	[Browsable(true)]
	[Category("Background")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[DevCoSerialize]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	public Color BackColor
	{
		get
		{
			return method_3(color_0, eColorSchemePart_0);
		}
		set
		{
			if (value != BackColor && ((eColorSchemePart_0 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BackColorSchemePart = eColorSchemePart.None;
			}
			color_0 = value;
			method_1();
		}
	}

	[Browsable(false)]
	[DevCoSerialize]
	[DefaultValue(eColorSchemePart.None)]
	public eColorSchemePart BackColorSchemePart
	{
		get
		{
			return eColorSchemePart_0;
		}
		set
		{
			eColorSchemePart_0 = value;
			method_1();
		}
	}

	[TypeConverter(typeof(ColorSchemeColorConverter))]
	[Browsable(true)]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[DevCoSerialize]
	[Category("Background")]
	[Description("Gets or sets the target gradient background color for UI element.")]
	public Color BackColor2
	{
		get
		{
			return method_3(color_1, eColorSchemePart_1);
		}
		set
		{
			if (value != BackColor2 && ((eColorSchemePart_1 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BackColor2SchemePart = eColorSchemePart.None;
			}
			color_1 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[DevCoSerialize]
	[Browsable(false)]
	public eColorSchemePart BackColor2SchemePart
	{
		get
		{
			return eColorSchemePart_1;
		}
		set
		{
			eColorSchemePart_1 = value;
			method_1();
		}
	}

	[Category("Background")]
	[DefaultValue(0)]
	[Browsable(true)]
	[Description("Gets or sets the background gradient angle.")]
	[DevCoSerialize]
	public int BackColorGradientAngle
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
				method_1();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(eGradientType.Linear)]
	[DevCoSerialize]
	[Category("Background")]
	[Description("Indicates background gradient fill type.")]
	public eGradientType BackColorGradientType
	{
		get
		{
			return eGradientType_0;
		}
		set
		{
			if (eGradientType_0 != value)
			{
				eGradientType_0 = value;
				method_1();
			}
		}
	}

	[Category("Background")]
	[DevCoSerialize]
	[Browsable(true)]
	[Description("Specifies background image.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(null)]
	public Image BackgroundImage
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[Browsable(true)]
	[DefaultValue(eStyleBackgroundImage.Stretch)]
	[Description("Specifies background image position when container is larger than image.")]
	[Category("Background")]
	public eStyleBackgroundImage BackgroundImagePosition
	{
		get
		{
			return eStyleBackgroundImage_0;
		}
		set
		{
			if (eStyleBackgroundImage_0 != value)
			{
				eStyleBackgroundImage_0 = value;
				method_1();
			}
		}
	}

	[Browsable(true)]
	[Category("Background")]
	[Description("Specifies the transparency of background image.")]
	[DefaultValue(byte.MaxValue)]
	[DevCoSerialize]
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
				method_1();
			}
		}
	}

	[TypeConverter(typeof(ColorSchemeColorConverter))]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Description("Gets or sets the text color displayed in this UI element.")]
	[DevCoSerialize]
	[Category("Text Properties")]
	[Browsable(true)]
	public Color TextColor
	{
		get
		{
			return method_3(color_2, eColorSchemePart_2);
		}
		set
		{
			if (value != TextColor && ((eColorSchemePart_2 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				TextColorSchemePart = eColorSchemePart.None;
			}
			color_2 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[Browsable(false)]
	[DevCoSerialize]
	public eColorSchemePart TextColorSchemePart
	{
		get
		{
			return eColorSchemePart_2;
		}
		set
		{
			eColorSchemePart_2 = value;
			method_1();
		}
	}

	[Browsable(true)]
	[Description("Indicates text shadow color.")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Category("Text Properties")]
	[TypeConverter(typeof(ColorConverter))]
	[DevCoSerialize]
	public Color TextShadowColor
	{
		get
		{
			return method_3(color_3, eColorSchemePart_3);
		}
		set
		{
			if ((eColorSchemePart_3 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty)
			{
				TextShadowColorSchemePart = eColorSchemePart.None;
			}
			color_3 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[Browsable(false)]
	[DevCoSerialize]
	public eColorSchemePart TextShadowColorSchemePart
	{
		get
		{
			return eColorSchemePart_3;
		}
		set
		{
			eColorSchemePart_3 = value;
			method_1();
		}
	}

	[Browsable(true)]
	[DevCoSerialize]
	[Description("Indicates text shadow offset in pixels.")]
	[Category("Text Properties")]
	public Point TextShadowOffset
	{
		get
		{
			return point_0;
		}
		set
		{
			point_0 = value;
			method_1();
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the Font used to draw this the text.")]
	[DevCoSerialize]
	[DefaultValue(null)]
	[Category("Text Properties")]
	public Font Font
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
			method_1();
			method_2();
		}
	}

	[DevCoSerialize]
	[Category("Text Formatting")]
	[Browsable(true)]
	[Description("Gets or sets a value that determines whether text is displayed in multiple lines or one long line.")]
	[DefaultValue(false)]
	public bool WordWrap
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			method_1();
			method_2();
		}
	}

	[DefaultValue(eStyleTextAlignment.Near)]
	[DevCoSerialize]
	[Browsable(true)]
	[Category("Text Formatting")]
	[Description("Specifies alignment of the text.")]
	public eStyleTextAlignment TextAlignment
	{
		get
		{
			return eStyleTextAlignment_0;
		}
		set
		{
			eStyleTextAlignment_0 = value;
			method_1();
		}
	}

	[Category("Text Formatting")]
	[Browsable(true)]
	[Description("Specifies alignment of the text.")]
	[DefaultValue(eStyleTextAlignment.Center)]
	[DevCoSerialize]
	public eStyleTextAlignment TextLineAlignment
	{
		get
		{
			return eStyleTextAlignment_1;
		}
		set
		{
			eStyleTextAlignment_1 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[Description("Specifies how to trim characters when text does not fit.")]
	[DefaultValue(eStyleTextTrimming.EllipsisCharacter)]
	[Category("Text Formatting")]
	[Browsable(true)]
	public eStyleTextTrimming TextTrimming
	{
		get
		{
			return eStyleTextTrimming_0;
		}
		set
		{
			if (eStyleTextTrimming_0 != value)
			{
				eStyleTextTrimming_0 = value;
				method_1();
			}
		}
	}

	[Browsable(false)]
	public int MarginHorizontal => int_2 + int_3;

	[Browsable(false)]
	public int MarginVertical => int_4 + int_5;

	[Category("Margins")]
	[Browsable(true)]
	[DevCoSerialize]
	[DefaultValue(0)]
	[Description("Specifies left margin.")]
	public int MarginLeft
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			method_1();
			method_2();
		}
	}

	[DefaultValue(0)]
	[Category("Margins")]
	[Browsable(true)]
	[DevCoSerialize]
	[Description("Specifies right margin.")]
	public int MarginRight
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			method_1();
			method_2();
		}
	}

	[Category("Margins")]
	[Description("Specifies top margin.")]
	[Browsable(true)]
	[DefaultValue(0)]
	[DevCoSerialize]
	public int MarginTop
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			method_1();
			method_2();
		}
	}

	[DevCoSerialize]
	[Description("Specifies bottom margin.")]
	[Category("Margins")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int MarginBottom
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			method_1();
			method_2();
		}
	}

	internal bool Boolean_0
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	[Browsable(false)]
	public Size Size => size_0;

	[Description("Indicates the border type for all sides of the element.")]
	[Category("Border")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(eStyleBorderType.None)]
	public eStyleBorderType Border
	{
		get
		{
			return eStyleBorderType_2;
		}
		set
		{
			if (Boolean_8)
			{
				TypeDescriptor.GetProperties(this)["BorderLeft"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["BorderRight"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["BorderTop"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["BorderBottom"]!.SetValue(this, value);
			}
			else
			{
				BorderLeft = value;
				BorderRight = value;
				BorderTop = value;
				BorderBottom = value;
			}
		}
	}

	[Description("Indicates border width in pixels.")]
	[DefaultValue(0)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Category("Border")]
	[Browsable(true)]
	public int BorderWidth
	{
		get
		{
			return int_14;
		}
		set
		{
			if (Boolean_8)
			{
				TypeDescriptor.GetProperties(this)["BorderLeftWidth"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["BorderRightWidth"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["BorderTopWidth"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["BorderBottomWidth"]!.SetValue(this, value);
			}
			else
			{
				BorderLeftWidth = value;
				BorderRightWidth = value;
				BorderTopWidth = value;
				BorderBottomWidth = value;
			}
			method_1();
			method_2();
		}
	}

	[DefaultValue(eStyleBorderType.None)]
	[DevCoSerialize]
	[Description("Indicates the border type for top side of the element.")]
	[Browsable(true)]
	[Category("Border")]
	public eStyleBorderType BorderTop
	{
		get
		{
			return eStyleBorderType_2;
		}
		set
		{
			if (eStyleBorderType_2 != value)
			{
				eStyleBorderType_2 = value;
				method_1();
				method_2();
			}
		}
	}

	[DevCoSerialize]
	[DefaultValue(eStyleBorderType.None)]
	[Category("Border")]
	[Browsable(true)]
	[Description("Indicates the border type for bottom side of the element.")]
	public eStyleBorderType BorderBottom
	{
		get
		{
			return eStyleBorderType_3;
		}
		set
		{
			if (eStyleBorderType_3 != value)
			{
				eStyleBorderType_3 = value;
				method_1();
				method_2();
			}
		}
	}

	[Description("Indicates the border type for left side of the element.")]
	[DevCoSerialize]
	[Category("Border")]
	[DefaultValue(eStyleBorderType.None)]
	[Browsable(true)]
	public eStyleBorderType BorderLeft
	{
		get
		{
			return eStyleBorderType_0;
		}
		set
		{
			if (eStyleBorderType_0 != value)
			{
				eStyleBorderType_0 = value;
				method_1();
				method_2();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates the border type for right side of the element.")]
	[DevCoSerialize]
	[Category("Border")]
	[DefaultValue(eStyleBorderType.None)]
	public eStyleBorderType BorderRight
	{
		get
		{
			return eStyleBorderType_1;
		}
		set
		{
			if (eStyleBorderType_1 != value)
			{
				eStyleBorderType_1 = value;
				method_1();
				method_2();
			}
		}
	}

	[DefaultValue(0)]
	[Description("Indicates border width in pixels.")]
	[DevCoSerialize]
	[Category("Border")]
	[Browsable(true)]
	public int BorderTopWidth
	{
		get
		{
			return int_14;
		}
		set
		{
			if (int_14 != value)
			{
				int_14 = value;
				method_1();
				method_2();
			}
		}
	}

	[DevCoSerialize]
	[Category("Border")]
	[Description("Indicates border width in pixels.")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int BorderBottomWidth
	{
		get
		{
			return int_15;
		}
		set
		{
			if (int_15 != value)
			{
				int_15 = value;
				method_1();
				method_2();
			}
		}
	}

	[Browsable(true)]
	[DevCoSerialize]
	[Description("Indicates border width in pixels.")]
	[DefaultValue(0)]
	[Category("Border")]
	public int BorderLeftWidth
	{
		get
		{
			return int_12;
		}
		set
		{
			if (int_12 != value)
			{
				int_12 = value;
				method_1();
				method_2();
			}
		}
	}

	[Browsable(true)]
	[Category("Border")]
	[DefaultValue(0)]
	[DevCoSerialize]
	[Description("Indicates border width in pixels.")]
	public int BorderRightWidth
	{
		get
		{
			return int_13;
		}
		set
		{
			if (int_13 != value)
			{
				int_13 = value;
				method_1();
				method_2();
			}
		}
	}

	[Description("Indicates border color for all sides. Specifing the color for the side will override this value.")]
	[Category("Border")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DevCoSerialize]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	public Color BorderColor
	{
		get
		{
			return method_3(color_4, eColorSchemePart_4);
		}
		set
		{
			if (value != BorderColor && ((eColorSchemePart_4 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderColorSchemePart = eColorSchemePart.None;
			}
			color_4 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[DevCoSerialize]
	[Browsable(false)]
	public eColorSchemePart BorderColorSchemePart
	{
		get
		{
			return eColorSchemePart_4;
		}
		set
		{
			eColorSchemePart_4 = value;
			method_1();
		}
	}

	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Category("Border")]
	[Browsable(true)]
	[Description("Indicates target background gradient color for border on all sides. ")]
	[DevCoSerialize]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	public Color BorderColor2
	{
		get
		{
			return method_3(color_5, eColorSchemePart_5);
		}
		set
		{
			if (value != BorderColor2 && ((eColorSchemePart_5 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderColor2SchemePart = eColorSchemePart.None;
			}
			color_5 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[DevCoSerialize]
	[Browsable(false)]
	public eColorSchemePart BorderColor2SchemePart
	{
		get
		{
			return eColorSchemePart_5;
		}
		set
		{
			eColorSchemePart_5 = value;
			method_1();
		}
	}

	[Browsable(true)]
	[Category("Background")]
	[Description("Gets or sets the border gradient angle.")]
	[DefaultValue(90)]
	[DevCoSerialize]
	public int BorderGradientAngle
	{
		get
		{
			return int_10;
		}
		set
		{
			if (int_10 != value)
			{
				int_10 = value;
				method_1();
			}
		}
	}

	[DevCoSerialize]
	[Category("Border")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	[Description("Indicates color for light border part when etched border is used.")]
	[Browsable(true)]
	public Color BorderColorLight
	{
		get
		{
			return method_3(color_6, eColorSchemePart_6);
		}
		set
		{
			if (value != BorderColorLight && ((eColorSchemePart_6 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderColorLightSchemePart = eColorSchemePart.None;
			}
			color_6 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[DefaultValue(eColorSchemePart.None)]
	[Browsable(false)]
	public eColorSchemePart BorderColorLightSchemePart
	{
		get
		{
			return eColorSchemePart_6;
		}
		set
		{
			eColorSchemePart_6 = value;
			method_1();
		}
	}

	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Category("Border")]
	[Description("Indicates target background gradient color for border on all sides. ")]
	[Browsable(true)]
	[DevCoSerialize]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	public Color BorderColorLight2
	{
		get
		{
			return method_3(color_7, eColorSchemePart_7);
		}
		set
		{
			if (value != BorderColorLight2 && ((eColorSchemePart_7 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderColorLight2SchemePart = eColorSchemePart.None;
			}
			color_7 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[DevCoSerialize]
	[Browsable(false)]
	public eColorSchemePart BorderColorLight2SchemePart
	{
		get
		{
			return eColorSchemePart_7;
		}
		set
		{
			eColorSchemePart_7 = value;
			method_1();
		}
	}

	[Category("Background")]
	[Description("Gets or sets the border gradient angle.")]
	[DefaultValue(90)]
	[DevCoSerialize]
	[Browsable(true)]
	public int BorderLightGradientAngle
	{
		get
		{
			return int_11;
		}
		set
		{
			if (int_11 != value)
			{
				int_11 = value;
				method_1();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates background color for the left side border.")]
	[DevCoSerialize]
	[Category("Border")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	public Color BorderLeftColor
	{
		get
		{
			return method_3(color_8, eColorSchemePart_8);
		}
		set
		{
			if (value != BorderLeftColor && ((eColorSchemePart_8 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderLeftColorSchemePart = eColorSchemePart.None;
			}
			color_8 = value;
			method_1();
		}
	}

	[DefaultValue(eColorSchemePart.None)]
	[Browsable(false)]
	[DevCoSerialize]
	public eColorSchemePart BorderLeftColorSchemePart
	{
		get
		{
			return eColorSchemePart_8;
		}
		set
		{
			eColorSchemePart_8 = value;
			method_1();
		}
	}

	[TypeConverter(typeof(ColorSchemeColorConverter))]
	[Description("Indicates background color for the right side border.")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[DevCoSerialize]
	[Browsable(true)]
	[Category("Border")]
	public Color BorderRightColor
	{
		get
		{
			return method_3(color_9, eColorSchemePart_9);
		}
		set
		{
			if (value != BorderRightColor && ((eColorSchemePart_9 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderRightColorSchemePart = eColorSchemePart.None;
			}
			color_9 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[Browsable(false)]
	[DefaultValue(eColorSchemePart.None)]
	public eColorSchemePart BorderRightColorSchemePart
	{
		get
		{
			return eColorSchemePart_9;
		}
		set
		{
			eColorSchemePart_9 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[Description("Indicates background color for the top side border.")]
	[Browsable(true)]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	[Category("Border")]
	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	public Color BorderTopColor
	{
		get
		{
			return method_3(color_10, eColorSchemePart_10);
		}
		set
		{
			if (value != BorderTopColor && ((eColorSchemePart_10 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderTopColorSchemePart = eColorSchemePart.None;
			}
			color_10 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[Browsable(false)]
	[DefaultValue(eColorSchemePart.None)]
	public eColorSchemePart BorderTopColorSchemePart
	{
		get
		{
			return eColorSchemePart_10;
		}
		set
		{
			eColorSchemePart_10 = value;
			method_1();
		}
	}

	[Editor(typeof(ColorTypeEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[Description("Indicates background color for the bottom side border.")]
	[DevCoSerialize]
	[TypeConverter(typeof(ColorSchemeColorConverter))]
	[Category("Border")]
	public Color BorderBottomColor
	{
		get
		{
			return method_3(color_11, eColorSchemePart_11);
		}
		set
		{
			if (value != BorderBottomColor && ((eColorSchemePart_11 != eColorSchemePart.None && !value.IsEmpty) || value.IsEmpty))
			{
				BorderBottomColorSchemePart = eColorSchemePart.None;
			}
			color_11 = value;
			method_1();
		}
	}

	[DevCoSerialize]
	[Browsable(false)]
	[DefaultValue(eColorSchemePart.None)]
	public eColorSchemePart BorderBottomColorSchemePart
	{
		get
		{
			return eColorSchemePart_11;
		}
		set
		{
			eColorSchemePart_11 = value;
			method_1();
		}
	}

	[Browsable(false)]
	public int PaddingHorizontal => int_6 + int_7;

	[Browsable(false)]
	public int PaddingVertical => int_8 + int_9;

	[DefaultValue(0)]
	[Category("PaddingTop")]
	[Browsable(true)]
	[Description("Indicates padding space in pixels for all 4 sides of the box.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Padding
	{
		get
		{
			return int_8;
		}
		set
		{
			if (Boolean_8)
			{
				TypeDescriptor.GetProperties(this)["PaddingLeft"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["PaddingRight"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["PaddingTop"]!.SetValue(this, value);
				TypeDescriptor.GetProperties(this)["PaddingBottom"]!.SetValue(this, value);
			}
			else
			{
				PaddingLeft = value;
				PaddingRight = value;
				PaddingTop = value;
				PaddingBottom = value;
			}
			method_1();
			method_2();
		}
	}

	[DevCoSerialize]
	[Description("Indicates the amount of space to insert between the top border of the element and the content.")]
	[Browsable(true)]
	[Category("Padding")]
	[DefaultValue(0)]
	public int PaddingTop
	{
		get
		{
			return int_8;
		}
		set
		{
			int_8 = value;
			method_1();
			method_2();
		}
	}

	[Description("Indicates the amount of space to insert between the bottom border of the element and the content.")]
	[Browsable(true)]
	[DevCoSerialize]
	[DefaultValue(0)]
	[Category("Padding")]
	public int PaddingBottom
	{
		get
		{
			return int_9;
		}
		set
		{
			int_9 = value;
			method_1();
			method_2();
		}
	}

	[Category("Padding")]
	[DefaultValue(0)]
	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates the amount of space to insert between the left border of the element and the content.")]
	public int PaddingLeft
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
			method_1();
			method_2();
		}
	}

	[Category("Padding")]
	[DevCoSerialize]
	[Description("Indicates the amount of space to insert between the right border of the element and the content.")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int PaddingRight
	{
		get
		{
			return int_7;
		}
		set
		{
			int_7 = value;
			method_1();
			method_2();
		}
	}

	[DefaultValue("")]
	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates name of the style.")]
	[Category("Design")]
	public string Name
	{
		get
		{
			if (isite_0 != null)
			{
				string_0 = isite_0.Name;
			}
			return string_0;
		}
		set
		{
			if (isite_0 != null)
			{
				isite_0.Name = value;
			}
			if (value == null)
			{
				string_0 = "";
			}
			else
			{
				string_0 = value;
			}
		}
	}

	[Browsable(true)]
	[Editor(typeof(ElementStyleClassTypeEditor), typeof(UITypeEditor))]
	[DevCoSerialize]
	[Description("Indicates the class style belongs to.")]
	[Category("Design")]
	[DefaultValue("")]
	public string Class
	{
		get
		{
			return string_2;
		}
		set
		{
			if (value == null)
			{
				throw new NullReferenceException("null is not valid value for this property");
			}
			if (string_2 != value)
			{
				string_2 = value;
				method_1();
			}
		}
	}

	[Description("Indicates description of the style.")]
	[Category("Design")]
	[Browsable(true)]
	[DefaultValue("")]
	[DevCoSerialize]
	public string Description
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual ISite Site
	{
		get
		{
			return isite_0;
		}
		set
		{
			isite_0 = value;
		}
	}

	[DefaultValue(0)]
	[Category("Text Formatting")]
	[DevCoSerialize]
	[Browsable(true)]
	[Description("Indicates the maximum height of the element. This property should be used in conjunction with the WordWrap property to limit the size of text bounding box.")]
	public int MaximumHeight
	{
		get
		{
			return int_17;
		}
		set
		{
			if (int_17 != value)
			{
				int_17 = value;
				method_1();
				method_2();
			}
		}
	}

	internal StringFormat StringFormat_0
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			StringFormat val = new StringFormat(StringFormat.get_GenericDefault());
			val.set_Alignment((StringAlignment)eStyleTextAlignment_0);
			val.set_LineAlignment((StringAlignment)eStyleTextAlignment_1);
			val.set_Trimming((StringTrimming)eStyleTextTrimming_0);
			if (bool_0)
			{
				val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() & ~(val.get_FormatFlags() & 0x1000)));
			}
			else
			{
				val.set_FormatFlags((StringFormatFlags)(val.get_FormatFlags() | 0x1000));
			}
			return val;
		}
	}

	[DefaultValue(eOrientation.Horizontal)]
	internal eOrientation EOrientation_0
	{
		get
		{
			return eOrientation_0;
		}
		set
		{
			if (eOrientation_0 != value)
			{
				eOrientation_0 = value;
				method_1();
			}
		}
	}

	internal eTextFormat ETextFormat_0
	{
		get
		{
			eTextFormat eTextFormat2 = eTextFormat.Default;
			if (eStyleTextAlignment_0 == eStyleTextAlignment.Center)
			{
				eTextFormat2 |= eTextFormat.HorizontalCenter;
			}
			else if (eStyleTextAlignment_0 == eStyleTextAlignment.Far)
			{
				eTextFormat2 |= eTextFormat.Right;
			}
			if (eStyleTextAlignment_1 == eStyleTextAlignment.Center)
			{
				eTextFormat2 |= eTextFormat.VerticalCenter;
			}
			else if (eStyleTextAlignment_1 == eStyleTextAlignment.Far)
			{
				eTextFormat2 |= eTextFormat.Bottom;
			}
			eTextFormat2 = ((!bool_0) ? (eTextFormat2 | eTextFormat.SingleLine) : (eTextFormat2 | eTextFormat.WordBreak));
			if (eStyleTextTrimming_0 != 0)
			{
				eTextFormat2 |= eTextFormat.EndEllipsis;
			}
			eTextFormat2 |= eTextFormat.HidePrefix;
			if (eOrientation_0 == eOrientation.Vertical)
			{
				eTextFormat2 |= eTextFormat.Vertical;
			}
			return eTextFormat2;
		}
	}

	[DevCoSerialize]
	[Category("Border")]
	[Description("Indicates border corner type.")]
	[DefaultValue(eCornerType.Square)]
	[Browsable(true)]
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
				if (eCornerType_0 == eCornerType.Inherit)
				{
					eCornerType_0 = eCornerType.Square;
				}
				method_1();
			}
		}
	}

	[Category("Border")]
	[Browsable(true)]
	[Description("Indicates top left border corner type.")]
	[DefaultValue(eCornerType.Inherit)]
	[DevCoSerialize]
	public eCornerType CornerTypeTopLeft
	{
		get
		{
			return eCornerType_1;
		}
		set
		{
			if (eCornerType_1 != value)
			{
				eCornerType_1 = value;
				method_1();
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates top right border corner type.")]
	[DevCoSerialize]
	[Category("Border")]
	[DefaultValue(eCornerType.Inherit)]
	public eCornerType CornerTypeTopRight
	{
		get
		{
			return eCornerType_2;
		}
		set
		{
			if (eCornerType_2 != value)
			{
				eCornerType_2 = value;
				method_1();
			}
		}
	}

	[DevCoSerialize]
	[Category("Border")]
	[DefaultValue(eCornerType.Inherit)]
	[Browsable(true)]
	[Description("Indicates bottom left border corner type.")]
	public eCornerType CornerTypeBottomLeft
	{
		get
		{
			return eCornerType_3;
		}
		set
		{
			if (eCornerType_3 != value)
			{
				eCornerType_3 = value;
				method_1();
			}
		}
	}

	[Browsable(true)]
	[Category("Border")]
	[DevCoSerialize]
	[DefaultValue(eCornerType.Inherit)]
	[Description("Indicates bottom right border corner type.")]
	public eCornerType CornerTypeBottomRight
	{
		get
		{
			return eCornerType_4;
		}
		set
		{
			if (eCornerType_4 != value)
			{
				eCornerType_4 = value;
				method_1();
			}
		}
	}

	[Category("Border")]
	[DevCoSerialize]
	[DefaultValue(8)]
	[Browsable(true)]
	[Description("Indicates diameter in pixels of the corner type rounded or diagonal.")]
	public int CornerDiameter
	{
		get
		{
			return int_16;
		}
		set
		{
			if (int_16 != value)
			{
				int_16 = value;
				method_1();
			}
		}
	}

	internal bool Boolean_1
	{
		get
		{
			if (BorderLeft != 0 && BorderLeftWidth > 0 && (!BorderColor.IsEmpty || !BorderLeftColor.IsEmpty || BorderColorSchemePart != eColorSchemePart.None || BorderLeftColorSchemePart != eColorSchemePart.None))
			{
				return true;
			}
			return false;
		}
	}

	internal bool Boolean_2
	{
		get
		{
			if (BorderRight != 0 && BorderRightWidth > 0 && (!BorderColor.IsEmpty || !BorderRightColor.IsEmpty || BorderColorSchemePart != eColorSchemePart.None || BorderRightColorSchemePart != eColorSchemePart.None))
			{
				return true;
			}
			return false;
		}
	}

	internal bool Boolean_3
	{
		get
		{
			if (BorderTop != 0 && BorderTopWidth > 0 && (!BorderColor.IsEmpty || !BorderTopColor.IsEmpty || BorderColorSchemePart != eColorSchemePart.None || BorderTopColorSchemePart != eColorSchemePart.None))
			{
				return true;
			}
			return false;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			if (BorderBottom != 0 && BorderBottomWidth > 0 && (!BorderColor.IsEmpty || !BorderBottomColor.IsEmpty || BorderColorSchemePart != eColorSchemePart.None || BorderBottomColorSchemePart != eColorSchemePart.None))
			{
				return true;
			}
			return false;
		}
	}

	internal bool Boolean_5 => Boolean_3 | Boolean_4 | Boolean_1 | Boolean_2;

	internal bool Boolean_6
	{
		get
		{
			if (Boolean_3 && Boolean_4 && Boolean_1)
			{
				return Boolean_2;
			}
			return false;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool Custom
	{
		get
		{
			if (!BackColor.IsEmpty)
			{
				return true;
			}
			if (!BackColor2.IsEmpty)
			{
				return true;
			}
			if (BackColorBlend.Count > 0)
			{
				return true;
			}
			if (BackColorGradientAngle != 0)
			{
				return true;
			}
			if (BackColorGradientType != 0)
			{
				return true;
			}
			if (BackgroundImage != null)
			{
				return true;
			}
			if (BackgroundImageAlpha != byte.MaxValue)
			{
				return true;
			}
			if (BackgroundImagePosition != 0)
			{
				return true;
			}
			if (BorderBottom != 0)
			{
				return true;
			}
			if (!BorderBottomColor.IsEmpty)
			{
				return true;
			}
			if (BorderBottomWidth != 0)
			{
				return true;
			}
			if (!BorderColor.IsEmpty)
			{
				return true;
			}
			if (BorderLeft != 0)
			{
				return true;
			}
			if (!BorderLeftColor.IsEmpty)
			{
				return true;
			}
			if (BorderLeftWidth != 0)
			{
				return true;
			}
			if (BorderTop != 0)
			{
				return true;
			}
			if (!BorderTopColor.IsEmpty)
			{
				return true;
			}
			if (BorderTopWidth != 0)
			{
				return true;
			}
			if (BorderRight != 0)
			{
				return true;
			}
			if (!BorderRightColor.IsEmpty)
			{
				return true;
			}
			if (BorderRightWidth != 0)
			{
				return true;
			}
			if (CornerDiameter != 8)
			{
				return true;
			}
			if (CornerType != eCornerType.Square)
			{
				return true;
			}
			if (CornerTypeTopLeft != 0)
			{
				return true;
			}
			if (CornerTypeTopRight != 0)
			{
				return true;
			}
			if (CornerTypeBottomLeft != 0)
			{
				return true;
			}
			if (CornerTypeBottomRight != 0)
			{
				return true;
			}
			if (Font != null)
			{
				return true;
			}
			if (MarginBottom != 0)
			{
				return true;
			}
			if (MarginLeft != 0)
			{
				return true;
			}
			if (MarginRight != 0)
			{
				return true;
			}
			if (MarginTop != 0)
			{
				return true;
			}
			if (MaximumHeight != 0)
			{
				return true;
			}
			if (PaddingBottom != 0)
			{
				return true;
			}
			if (PaddingLeft != 0)
			{
				return true;
			}
			if (PaddingRight != 0)
			{
				return true;
			}
			if (PaddingTop != 0)
			{
				return true;
			}
			if (TextAlignment != 0)
			{
				return true;
			}
			if (!TextColor.IsEmpty)
			{
				return true;
			}
			if (TextLineAlignment != eStyleTextAlignment.Center)
			{
				return true;
			}
			if (TextTrimming != eStyleTextTrimming.EllipsisCharacter)
			{
				return true;
			}
			if (WordWrap)
			{
				return true;
			}
			if (!TextShadowColor.IsEmpty)
			{
				return true;
			}
			if (!TextShadowOffset.IsEmpty)
			{
				return true;
			}
			if (MaximumWidth != 0)
			{
				return true;
			}
			return false;
		}
	}

	internal bool Boolean_7
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

	internal bool Boolean_8
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	[Description("Indicates the maximum width of the element. This property should be used in conjunction with the WordWrap property to limit the size of text bounding box.")]
	[DefaultValue(0)]
	[Category("Text Formatting")]
	[Browsable(true)]
	[DevCoSerialize]
	public int MaximumWidth
	{
		get
		{
			return int_18;
		}
		set
		{
			if (int_18 != value)
			{
				int_18 = value;
				method_1();
				method_2();
			}
		}
	}

	internal ElementStyleCollection ElementStyleCollection_0
	{
		get
		{
			return elementStyleCollection_0;
		}
		set
		{
			elementStyleCollection_0 = value;
		}
	}

	internal DevComponents.AdvTree.AdvTree AdvTree_0
	{
		get
		{
			return advTree_0;
		}
		set
		{
			advTree_0 = value;
		}
	}

	public event EventHandler StyleChanged
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

	[Description("Occurs when component is Disposed.")]
	public event EventHandler Disposed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public ElementStyle()
	{
		backgroundColorBlendCollection_0.ElementStyle_0 = this;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		if (!color_0.IsEmpty)
		{
			return eColorSchemePart_0 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor()
	{
		color_0 = Color.Empty;
		method_1();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor2()
	{
		if (!color_1.IsEmpty)
		{
			return eColorSchemePart_1 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackColor2()
	{
		color_1 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundImage()
	{
		image_0 = null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		if (!color_2.IsEmpty)
		{
			return eColorSchemePart_2 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		color_2 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextShadowColor()
	{
		if (!color_3.IsEmpty)
		{
			return eColorSchemePart_3 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextShadowColor()
	{
		color_3 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextShadowOffset()
	{
		return !point_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextShadowOffset()
	{
		point_0 = Point.Empty;
	}

	internal void method_0(Size size_1)
	{
		size_0 = size_1;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColor()
	{
		if (!color_4.IsEmpty)
		{
			return eColorSchemePart_4 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderColor()
	{
		color_4 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColor2()
	{
		if (!color_5.IsEmpty)
		{
			return eColorSchemePart_5 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private void ResetBorderColor2()
	{
		color_5 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColorLight()
	{
		if (!color_6.IsEmpty)
		{
			return eColorSchemePart_6 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private void ResetBorderColorLight()
	{
		color_6 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderColorLight2()
	{
		if (!color_7.IsEmpty)
		{
			return eColorSchemePart_7 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private void ResetBorderColorLight2()
	{
		color_7 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderLeftColor()
	{
		if (!color_8.IsEmpty)
		{
			return eColorSchemePart_8 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderLeftColor()
	{
		color_8 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderRightColor()
	{
		if (!color_9.IsEmpty)
		{
			return eColorSchemePart_9 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderRightColor()
	{
		color_9 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderTopColor()
	{
		if (!color_10.IsEmpty)
		{
			return eColorSchemePart_10 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderTopColor()
	{
		color_10 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBorderBottomColor()
	{
		if (!color_11.IsEmpty)
		{
			return eColorSchemePart_11 == eColorSchemePart.None;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderBottomColor()
	{
		color_11 = Color.Empty;
	}

	public virtual void Dispose()
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, EventArgs.Empty);
		}
	}

	public void ApplyFontStyle(ElementStyle style)
	{
		if (style.Font != null)
		{
			Font = style.Font;
		}
		if (style.MarginBottom != 0)
		{
			MarginBottom = style.MarginBottom;
		}
		if (style.MarginLeft != 0)
		{
			MarginLeft = style.MarginLeft;
		}
		if (style.MarginRight != 0)
		{
			MarginRight = style.MarginRight;
		}
		if (style.MarginTop != 0)
		{
			MarginTop = style.MarginTop;
		}
		if (style.MaximumHeight != 0)
		{
			MaximumHeight = style.MaximumHeight;
		}
		if (style.MaximumWidth != 0)
		{
			MaximumWidth = style.MaximumWidth;
		}
		if (style.PaddingBottom != 0)
		{
			PaddingBottom = style.PaddingBottom;
		}
		if (style.PaddingLeft != 0)
		{
			PaddingLeft = style.PaddingLeft;
		}
		if (style.PaddingRight != 0)
		{
			PaddingRight = style.PaddingRight;
		}
		if (style.PaddingTop != 0)
		{
			PaddingTop = style.PaddingTop;
		}
		if (style.TextAlignment != TextAlignment)
		{
			TextAlignment = style.TextAlignment;
		}
		if (!style.TextColor.IsEmpty)
		{
			TextColor = style.TextColor;
		}
		else if (style.TextColorSchemePart != eColorSchemePart.None)
		{
			TextColorSchemePart = style.TextColorSchemePart;
		}
		if (style.TextLineAlignment != TextLineAlignment)
		{
			TextLineAlignment = style.TextLineAlignment;
		}
		if (style.TextTrimming == eStyleTextTrimming.EllipsisCharacter)
		{
			TextTrimming = style.TextTrimming;
		}
		if (style.WordWrap)
		{
			WordWrap = style.WordWrap;
		}
		if (!style.TextShadowColor.IsEmpty)
		{
			TextShadowColor = style.TextShadowColor;
		}
		if (!style.TextShadowOffset.IsEmpty)
		{
			TextShadowOffset = style.TextShadowOffset;
		}
	}

	public virtual void ApplyStyle(ElementStyle style)
	{
		if (!style.BackColor.IsEmpty)
		{
			BackColor = style.BackColor;
		}
		else if (style.BackColorSchemePart != eColorSchemePart.None)
		{
			BackColorSchemePart = style.BackColorSchemePart;
		}
		if (!style.BackColor2.IsEmpty)
		{
			BackColor2 = style.BackColor2;
		}
		else if (style.BackColor2SchemePart != eColorSchemePart.None)
		{
			BackColor2SchemePart = style.BackColor2SchemePart;
		}
		if (style.BackColorGradientAngle != 0)
		{
			BackColorGradientAngle = style.BackColorGradientAngle;
		}
		BackColorGradientType = style.BackColorGradientType;
		if (style.BackgroundImage != null)
		{
			BackgroundImage = style.BackgroundImage;
		}
		if (style.BackgroundImageAlpha != byte.MaxValue)
		{
			BackgroundImageAlpha = style.BackgroundImageAlpha;
		}
		if (style.BackgroundImagePosition != 0)
		{
			BackgroundImagePosition = style.BackgroundImagePosition;
		}
		if (style.BorderBottom != 0)
		{
			BorderBottom = style.BorderBottom;
		}
		if (!style.BorderBottomColor.IsEmpty)
		{
			BorderBottomColor = style.BorderBottomColor;
		}
		else if (style.BorderBottomColorSchemePart != eColorSchemePart.None)
		{
			BorderBottomColorSchemePart = style.BorderBottomColorSchemePart;
		}
		if (style.BorderBottomWidth != 0)
		{
			BorderBottomWidth = style.BorderBottomWidth;
		}
		if (!style.BorderColor.IsEmpty)
		{
			BorderColor = style.BorderColor;
		}
		else if (style.BorderColorSchemePart != eColorSchemePart.None)
		{
			BorderColorSchemePart = style.BorderColorSchemePart;
		}
		if (style.BorderColor2.IsEmpty && style.BorderColor.IsEmpty)
		{
			if (style.BorderColor2SchemePart != eColorSchemePart.None)
			{
				BorderColor2SchemePart = style.BorderColor2SchemePart;
			}
		}
		else
		{
			BorderColor2 = style.BorderColor2;
		}
		if (style.BorderGradientAngle != 90)
		{
			BorderGradientAngle = style.BorderGradientAngle;
		}
		if (!style.BorderColorLight.IsEmpty)
		{
			BorderColorLight = style.BorderColorLight;
		}
		else if (style.BorderColorLightSchemePart != eColorSchemePart.None)
		{
			BorderColorLightSchemePart = style.BorderColorLightSchemePart;
		}
		if (style.BorderColorLight2.IsEmpty && style.BorderColorLight.IsEmpty)
		{
			if (style.BorderColorLight2SchemePart != eColorSchemePart.None)
			{
				BorderColorLight2SchemePart = style.BorderColorLight2SchemePart;
			}
		}
		else
		{
			BorderColorLight2 = style.BorderColorLight2;
		}
		if (style.BorderLightGradientAngle != 90)
		{
			BorderLightGradientAngle = style.BorderLightGradientAngle;
		}
		if (style.BorderLeft != 0)
		{
			BorderLeft = style.BorderLeft;
		}
		if (!style.BorderLeftColor.IsEmpty)
		{
			BorderLeftColor = style.BorderLeftColor;
		}
		else if (style.BorderLeftColorSchemePart != eColorSchemePart.None)
		{
			BorderLeftColorSchemePart = style.BorderLeftColorSchemePart;
		}
		if (style.BorderLeftWidth != 0)
		{
			BorderLeftWidth = style.BorderLeftWidth;
		}
		if (style.BorderTop != 0)
		{
			BorderTop = style.BorderTop;
		}
		else if (style.BorderTopColorSchemePart != eColorSchemePart.None)
		{
			BorderTopColorSchemePart = style.BorderTopColorSchemePart;
		}
		if (!style.BorderTopColor.IsEmpty)
		{
			BorderTopColor = style.BorderTopColor;
		}
		if (style.BorderTopWidth != 0)
		{
			BorderTopWidth = style.BorderTopWidth;
		}
		if (style.BorderRight != 0)
		{
			BorderRight = style.BorderRight;
		}
		else if (style.BorderRightColorSchemePart != eColorSchemePart.None)
		{
			BorderRightColorSchemePart = style.BorderRightColorSchemePart;
		}
		if (!style.BorderRightColor.IsEmpty)
		{
			BorderRightColor = style.BorderRightColor;
		}
		if (style.BorderRightWidth != 0)
		{
			BorderRightWidth = style.BorderRightWidth;
		}
		if (style.CornerDiameter != 8)
		{
			CornerDiameter = style.CornerDiameter;
		}
		if (style.CornerType != eCornerType.Square)
		{
			CornerType = style.CornerType;
		}
		if (style.CornerTypeTopLeft != 0)
		{
			CornerTypeTopLeft = style.CornerTypeTopLeft;
		}
		if (style.CornerTypeTopRight != 0)
		{
			CornerTypeTopRight = style.CornerTypeTopRight;
		}
		if (style.CornerTypeBottomLeft != 0)
		{
			CornerTypeBottomLeft = style.CornerTypeBottomLeft;
		}
		if (style.CornerTypeBottomRight != 0)
		{
			CornerTypeBottomRight = style.CornerTypeBottomRight;
		}
		if (style.Font != null)
		{
			Font = style.Font;
		}
		if (style.MarginBottom != 0)
		{
			MarginBottom = style.MarginBottom;
		}
		if (style.MarginLeft != 0)
		{
			MarginLeft = style.MarginLeft;
		}
		if (style.MarginRight != 0)
		{
			MarginRight = style.MarginRight;
		}
		if (style.MarginTop != 0)
		{
			MarginTop = style.MarginTop;
		}
		if (style.MaximumHeight != 0)
		{
			MaximumHeight = style.MaximumHeight;
		}
		if (style.PaddingBottom != 0)
		{
			PaddingBottom = style.PaddingBottom;
		}
		if (style.PaddingLeft != 0)
		{
			PaddingLeft = style.PaddingLeft;
		}
		if (style.PaddingRight != 0)
		{
			PaddingRight = style.PaddingRight;
		}
		if (style.PaddingTop != 0)
		{
			PaddingTop = style.PaddingTop;
		}
		if (style.TextAlignment != TextAlignment)
		{
			TextAlignment = style.TextAlignment;
		}
		if (!style.TextColor.IsEmpty)
		{
			TextColor = style.TextColor;
		}
		else if (style.TextColorSchemePart != eColorSchemePart.None)
		{
			TextColorSchemePart = style.TextColorSchemePart;
		}
		if (style.TextLineAlignment != TextLineAlignment)
		{
			TextLineAlignment = style.TextLineAlignment;
		}
		if (style.TextTrimming == eStyleTextTrimming.EllipsisCharacter)
		{
			TextTrimming = style.TextTrimming;
		}
		if (style.WordWrap)
		{
			WordWrap = style.WordWrap;
		}
		if (!style.TextShadowColor.IsEmpty)
		{
			TextShadowColor = style.TextShadowColor;
		}
		if (!style.TextShadowOffset.IsEmpty)
		{
			TextShadowOffset = style.TextShadowOffset;
		}
		if (style.BackColorBlend.Count > 0)
		{
			BackColorBlend.Clear();
			{
				foreach (BackgroundColorBlend item in style.BackColorBlend)
				{
					BackColorBlend.Add(new BackgroundColorBlend(item.Color, item.Position));
				}
				return;
			}
		}
		if (!style.BackColor.IsEmpty || !style.BackColor2.IsEmpty)
		{
			BackColorBlend.Clear();
		}
	}

	public ElementStyle Copy()
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.BackColor = BackColor;
		elementStyle.BackColorSchemePart = BackColorSchemePart;
		elementStyle.BackColor2 = BackColor2;
		elementStyle.BackColor2SchemePart = BackColor2SchemePart;
		elementStyle.BackColorGradientAngle = BackColorGradientAngle;
		elementStyle.BackColorGradientType = BackColorGradientType;
		elementStyle.BackgroundImage = BackgroundImage;
		elementStyle.BackgroundImageAlpha = BackgroundImageAlpha;
		elementStyle.BackgroundImagePosition = BackgroundImagePosition;
		elementStyle.BorderColor = BorderColor;
		elementStyle.BorderColorSchemePart = BorderColorSchemePart;
		elementStyle.BorderColor2 = BorderColor2;
		elementStyle.BorderColor2SchemePart = BorderColor2SchemePart;
		elementStyle.BorderGradientAngle = BorderGradientAngle;
		elementStyle.BorderColorLight = BorderColorLight;
		elementStyle.BorderColorLightSchemePart = BorderColorLightSchemePart;
		elementStyle.BorderColorLight2 = BorderColorLight2;
		elementStyle.BorderColorLight2SchemePart = BorderColorLight2SchemePart;
		elementStyle.BorderLightGradientAngle = BorderLightGradientAngle;
		elementStyle.BorderBottom = BorderBottom;
		elementStyle.BorderBottomColor = BorderBottomColor;
		elementStyle.BorderBottomColorSchemePart = BorderBottomColorSchemePart;
		elementStyle.BorderBottomWidth = BorderBottomWidth;
		elementStyle.BorderLeft = BorderLeft;
		elementStyle.BorderLeftWidth = BorderLeftWidth;
		elementStyle.BorderLeftColor = BorderLeftColor;
		elementStyle.BorderLeftColorSchemePart = BorderLeftColorSchemePart;
		elementStyle.BorderRight = BorderRight;
		elementStyle.BorderRightWidth = BorderRightWidth;
		elementStyle.BorderRightColor = BorderRightColor;
		elementStyle.BorderRightColorSchemePart = BorderRightColorSchemePart;
		elementStyle.BorderTop = BorderTop;
		elementStyle.BorderTopWidth = BorderTopWidth;
		elementStyle.BorderBottomColor = BorderBottomColor;
		elementStyle.BorderBottomColorSchemePart = BorderBottomColorSchemePart;
		elementStyle.CornerDiameter = CornerDiameter;
		elementStyle.CornerType = CornerType;
		elementStyle.CornerTypeTopLeft = CornerTypeTopLeft;
		elementStyle.CornerTypeTopRight = CornerTypeTopRight;
		elementStyle.CornerTypeBottomLeft = CornerTypeBottomLeft;
		elementStyle.CornerTypeBottomRight = CornerTypeBottomRight;
		elementStyle.Font = Font;
		elementStyle.MarginBottom = MarginBottom;
		elementStyle.MarginLeft = MarginLeft;
		elementStyle.MarginRight = MarginRight;
		elementStyle.MarginTop = MarginTop;
		elementStyle.PaddingBottom = PaddingBottom;
		elementStyle.PaddingLeft = PaddingLeft;
		elementStyle.PaddingRight = PaddingRight;
		elementStyle.PaddingTop = PaddingTop;
		elementStyle.TextAlignment = TextAlignment;
		elementStyle.TextColor = TextColor;
		elementStyle.TextColorSchemePart = TextColorSchemePart;
		elementStyle.TextLineAlignment = TextLineAlignment;
		elementStyle.TextTrimming = TextTrimming;
		elementStyle.WordWrap = WordWrap;
		elementStyle.Description = Description;
		elementStyle.TextShadowColor = TextShadowColor;
		elementStyle.TextShadowColorSchemePart = TextShadowColorSchemePart;
		elementStyle.TextShadowOffset = TextShadowOffset;
		elementStyle.Class = string_2;
		elementStyle.MaximumWidth = MaximumWidth;
		foreach (BackgroundColorBlend item in backgroundColorBlendCollection_0)
		{
			elementStyle.BackColorBlend.Add(new BackgroundColorBlend(item.Color, item.Position));
		}
		return elementStyle;
	}

	public void Reset()
	{
		color_0 = Color.Empty;
		eColorSchemePart_0 = eColorSchemePart.None;
		color_1 = Color.Empty;
		eColorSchemePart_1 = eColorSchemePart.None;
		int_1 = 0;
		eGradientType_0 = eGradientType.Linear;
		image_0 = null;
		eStyleBackgroundImage_0 = eStyleBackgroundImage.Stretch;
		byte_0 = byte.MaxValue;
		backgroundColorBlendCollection_0.Clear();
		font_0 = null;
		bool_0 = false;
		eStyleTextAlignment_0 = eStyleTextAlignment.Near;
		eStyleTextAlignment_1 = eStyleTextAlignment.Center;
		eStyleTextTrimming_0 = eStyleTextTrimming.EllipsisCharacter;
		color_2 = Color.Empty;
		eColorSchemePart_2 = eColorSchemePart.None;
		color_3 = Color.Empty;
		eColorSchemePart_3 = eColorSchemePart.None;
		point_0 = Point.Empty;
		int_2 = 0;
		int_3 = 0;
		int_4 = 0;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		int_8 = 0;
		int_9 = 0;
		eStyleBorderType_0 = eStyleBorderType.None;
		eStyleBorderType_1 = eStyleBorderType.None;
		eStyleBorderType_2 = eStyleBorderType.None;
		eStyleBorderType_3 = eStyleBorderType.None;
		color_4 = Color.Empty;
		eColorSchemePart_4 = eColorSchemePart.None;
		color_5 = Color.Empty;
		eColorSchemePart_5 = eColorSchemePart.None;
		int_10 = 90;
		color_6 = Color.Empty;
		eColorSchemePart_6 = eColorSchemePart.None;
		color_7 = Color.Empty;
		eColorSchemePart_7 = eColorSchemePart.None;
		int_11 = 90;
		color_8 = Color.Empty;
		eColorSchemePart_8 = eColorSchemePart.None;
		color_9 = Color.Empty;
		eColorSchemePart_9 = eColorSchemePart.None;
		color_10 = Color.Empty;
		eColorSchemePart_10 = eColorSchemePart.None;
		color_11 = Color.Empty;
		eColorSchemePart_11 = eColorSchemePart.None;
		int_12 = 0;
		int_13 = 0;
		int_14 = 0;
		int_15 = 0;
		eCornerType_0 = eCornerType.Square;
		eCornerType_1 = eCornerType.Inherit;
		eCornerType_2 = eCornerType.Inherit;
		eCornerType_3 = eCornerType.Inherit;
		eCornerType_4 = eCornerType.Inherit;
		int_16 = 8;
		string_2 = "";
		int_17 = 0;
	}

	public static ElementStyle GetDefaultCellStyle(ElementStyle defaultNodeStyle)
	{
		ElementStyle elementStyle = new ElementStyle();
		if (defaultNodeStyle != null)
		{
			elementStyle.TextColor = defaultNodeStyle.TextColor;
			elementStyle.Font = defaultNodeStyle.Font;
			elementStyle.TextAlignment = defaultNodeStyle.TextAlignment;
			elementStyle.TextLineAlignment = defaultNodeStyle.TextLineAlignment;
			elementStyle.TextTrimming = defaultNodeStyle.TextTrimming;
			elementStyle.WordWrap = defaultNodeStyle.WordWrap;
		}
		if (elementStyle.TextColor.IsEmpty)
		{
			elementStyle.TextColor = SystemColors.ControlText;
		}
		return elementStyle;
	}

	public static ElementStyle GetDefaultDisabledCellStyle()
	{
		ElementStyle elementStyle = new ElementStyle();
		elementStyle.TextColor = SystemColors.GrayText;
		return elementStyle;
	}

	public static ElementStyle GetDefaultSelectedCellStyle()
	{
		return new ElementStyle();
	}

	public static void SetColorsAlpha(ElementStyle style, int alpha)
	{
		if (!style.TextColor.IsEmpty)
		{
			style.TextColor = Color.FromArgb(alpha, style.TextColor);
		}
		if (!style.BackColor.IsEmpty)
		{
			style.BackColor = Color.FromArgb(alpha, style.BackColor);
		}
		if (!style.BackColor2.IsEmpty)
		{
			style.BackColor2 = Color.FromArgb(alpha, style.BackColor2);
		}
		if (!style.BorderColor.IsEmpty)
		{
			style.BorderColor = Color.FromArgb(alpha, style.BorderColor);
		}
		if (!style.BorderBottomColor.IsEmpty)
		{
			style.BorderBottomColor = Color.FromArgb(alpha, style.BorderBottomColor);
		}
		if (!style.BorderLeftColor.IsEmpty)
		{
			style.BorderLeftColor = Color.FromArgb(alpha, style.BorderLeftColor);
		}
		if (!style.BorderRightColor.IsEmpty)
		{
			style.BorderRightColor = Color.FromArgb(alpha, style.BorderRightColor);
		}
		if (!style.BorderRightColor.IsEmpty)
		{
			style.BorderRightColor = Color.FromArgb(alpha, style.BorderRightColor);
		}
		if (!style.BorderTopColor.IsEmpty)
		{
			style.BorderTopColor = Color.FromArgb(alpha, style.BorderTopColor);
		}
	}

	private void method_1()
	{
		if (!bool_3 && eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}

	private void method_2()
	{
		bool_1 = true;
	}

	private Color method_3(Color color_12, eColorSchemePart eColorSchemePart_12)
	{
		if (eColorSchemePart_12 == eColorSchemePart.None)
		{
			return color_12;
		}
		ColorScheme colorScheme = GetColorScheme();
		if (colorScheme == null)
		{
			return color_12;
		}
		return eColorSchemePart_12 switch
		{
			eColorSchemePart.BarBackground => colorScheme.BarBackground, 
			eColorSchemePart.BarBackground2 => colorScheme.BarBackground2, 
			eColorSchemePart.BarCaptionBackground => colorScheme.BarCaptionBackground, 
			eColorSchemePart.BarCaptionBackground2 => colorScheme.BarCaptionBackground2, 
			eColorSchemePart.BarCaptionInactiveBackground => colorScheme.BarCaptionInactiveBackground, 
			eColorSchemePart.BarCaptionInactiveBackground2 => colorScheme.BarCaptionInactiveBackground2, 
			eColorSchemePart.BarCaptionInactiveText => colorScheme.BarCaptionInactiveText, 
			eColorSchemePart.BarCaptionText => colorScheme.BarCaptionText, 
			eColorSchemePart.BarDockedBorder => colorScheme.BarDockedBorder, 
			eColorSchemePart.BarFloatingBorder => colorScheme.BarFloatingBorder, 
			eColorSchemePart.BarPopupBackground => colorScheme.BarPopupBackground, 
			eColorSchemePart.BarPopupBorder => colorScheme.BarPopupBorder, 
			eColorSchemePart.BarStripeColor => colorScheme.BarStripeColor, 
			eColorSchemePart.CustomizeBackground => colorScheme.CustomizeBackground, 
			eColorSchemePart.CustomizeBackground2 => colorScheme.CustomizeBackground2, 
			eColorSchemePart.CustomizeText => colorScheme.CustomizeText, 
			eColorSchemePart.ItemBackground => colorScheme.ItemBackground, 
			eColorSchemePart.ItemBackground2 => colorScheme.ItemBackground2, 
			eColorSchemePart.ItemCheckedBackground => colorScheme.ItemCheckedBackground, 
			eColorSchemePart.ItemCheckedBackground2 => colorScheme.ItemCheckedBackground2, 
			eColorSchemePart.ItemCheckedBorder => colorScheme.ItemCheckedBorder, 
			eColorSchemePart.ItemCheckedText => colorScheme.ItemCheckedText, 
			eColorSchemePart.ItemDesignTimeBorder => colorScheme.ItemDesignTimeBorder, 
			eColorSchemePart.ItemDisabledBackground => colorScheme.ItemDisabledBackground, 
			eColorSchemePart.ItemDisabledText => colorScheme.ItemDisabledText, 
			eColorSchemePart.ItemExpandedBackground => colorScheme.ItemExpandedBackground, 
			eColorSchemePart.ItemExpandedBackground2 => colorScheme.ItemExpandedBackground2, 
			eColorSchemePart.ItemExpandedBorder => colorScheme.ItemExpandedBorder, 
			eColorSchemePart.ItemExpandedShadow => colorScheme.ItemExpandedShadow, 
			eColorSchemePart.ItemExpandedText => colorScheme.ItemExpandedText, 
			eColorSchemePart.ItemHotBackground => colorScheme.ItemHotBackground, 
			eColorSchemePart.ItemHotBackground2 => colorScheme.ItemHotBackground2, 
			eColorSchemePart.ItemHotBorder => colorScheme.ItemHotBorder, 
			eColorSchemePart.ItemHotText => colorScheme.ItemHotText, 
			eColorSchemePart.ItemPressedBackground => colorScheme.ItemPressedBackground, 
			eColorSchemePart.ItemPressedBackground2 => colorScheme.ItemPressedBackground2, 
			eColorSchemePart.ItemPressedBorder => colorScheme.ItemPressedBorder, 
			eColorSchemePart.ItemPressedText => colorScheme.ItemPressedText, 
			eColorSchemePart.ItemSeparator => colorScheme.ItemSeparator, 
			eColorSchemePart.ItemSeparatorShade => colorScheme.ItemSeparatorShade, 
			eColorSchemePart.ItemText => colorScheme.ItemText, 
			eColorSchemePart.MenuBackground => colorScheme.MenuBackground, 
			eColorSchemePart.MenuBackground2 => colorScheme.MenuBackground2, 
			eColorSchemePart.MenuBarBackground => colorScheme.MenuBarBackground, 
			eColorSchemePart.MenuBarBackground2 => colorScheme.MenuBarBackground2, 
			eColorSchemePart.MenuBorder => colorScheme.MenuBorder, 
			eColorSchemePart.MenuSide => colorScheme.MenuSide, 
			eColorSchemePart.MenuSide2 => colorScheme.MenuSide2, 
			eColorSchemePart.MenuUnusedBackground => colorScheme.MenuUnusedBackground, 
			eColorSchemePart.MenuUnusedSide => colorScheme.MenuUnusedSide, 
			eColorSchemePart.MenuUnusedSide2 => colorScheme.MenuUnusedSide2, 
			eColorSchemePart.PanelBackground => colorScheme.PanelBackground, 
			eColorSchemePart.PanelBackground2 => colorScheme.PanelBackground2, 
			eColorSchemePart.PanelBorder => colorScheme.PanelBorder, 
			eColorSchemePart.PanelText => colorScheme.PanelText, 
			eColorSchemePart.ExplorerBarBackground => colorScheme.ExplorerBarBackground, 
			eColorSchemePart.ExplorerBarBackground2 => colorScheme.ExplorerBarBackground2, 
			eColorSchemePart.DockSiteBackColor => colorScheme.DockSiteBackColor, 
			eColorSchemePart.DockSiteBackColor2 => colorScheme.DockSiteBackColor2, 
			_ => (Color)colorScheme.GetType().GetProperty(eColorSchemePart_12.ToString())!.GetValue(colorScheme, null), 
		};
	}

	public override string ToString()
	{
		string text = Name;
		if (Description != "")
		{
			text = text + " " + Description;
		}
		return text;
	}

	internal ColorScheme GetColorScheme()
	{
		if (elementStyleCollection_0 != null && elementStyleCollection_0.AdvTree_0 != null)
		{
			return elementStyleCollection_0.AdvTree_0.ColorScheme_0;
		}
		if (advTree_0 != null)
		{
			return advTree_0.ColorScheme_0;
		}
		return colorScheme_0;
	}

	internal void method_4(ColorScheme colorScheme_1)
	{
		colorScheme_0 = colorScheme_1;
	}
}
