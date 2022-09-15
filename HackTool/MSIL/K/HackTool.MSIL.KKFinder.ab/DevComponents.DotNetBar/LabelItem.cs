using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.DotNetBar.Ribbon;
using DevComponents.DotNetBar.TextMarkup;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[DefaultEvent("Click")]
[Designer(typeof(SimpleBaseItemDesigner))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class LabelItem : BaseItem
{
	internal const eBorderSide eBorderSide_0 = eBorderSide.All;

	private const int int_4 = 2;

	private eBorderType eBorderType_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = SystemColors.ControlText;

	private Color color_2 = SystemColors.ControlDark;

	private bool bool_22;

	private StringAlignment stringAlignment_0;

	private StringAlignment stringAlignment_1 = (StringAlignment)1;

	private Font font_0;

	private bool bool_23;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private bool bool_24;

	private eImagePosition eImagePosition_0;

	private Image image_0;

	private Image image_1;

	private Image image_2;

	private Icon icon_0;

	private Icon icon_1;

	private int int_11 = -1;

	private ItemPaintArgs itemPaintArgs_0;

	private eBorderSide eBorderSide_1 = eBorderSide.All;

	private bool bool_25;

	internal bool bool_26;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private bool bool_27 = true;

	protected override bool IsMarkupSupported => bool_27;

	[Category("Appearance")]
	[Description("Indicates whether text-markup support is enabled for items Text property.")]
	[DefaultValue(true)]
	public bool EnableMarkup
	{
		get
		{
			return bool_27;
		}
		set
		{
			if (bool_27 != value)
			{
				bool_27 = value;
				NeedRecalcSize = true;
				OnTextChanged();
			}
		}
	}

	[Category("Appearance")]
	[Description("Indicates the type of the border drawn around the label.")]
	[DefaultValue(eBorderType.None)]
	[Browsable(true)]
	public eBorderType BorderType
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
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eBorderSide.All)]
	[Description("Specifies border sides that are displayed.")]
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
				Refresh();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Determines the background color of the label.")]
	[DevCoBrowsable(true)]
	public Color BackColor
	{
		get
		{
			return color_0;
		}
		set
		{
			if (!(color_0 == value))
			{
				color_0 = value;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates text color.")]
	[Category("Appearance")]
	public Color ForeColor
	{
		get
		{
			return color_1;
		}
		set
		{
			if (!(color_1 == value))
			{
				color_1 = value;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates border line color when border is single line.")]
	[DevCoBrowsable(true)]
	public Color SingleLineColor
	{
		get
		{
			return color_2;
		}
		set
		{
			if (!(color_2 == value))
			{
				color_2 = value;
				if (color_2 != SystemColors.ControlDark)
				{
					bool_22 = true;
				}
				else
				{
					bool_22 = false;
				}
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates text alignment.")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	public StringAlignment TextAlignment
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
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (stringAlignment_0 != value)
			{
				stringAlignment_0 = value;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Indicates text line alignment.")]
	public StringAlignment TextLineAlignment
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
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (stringAlignment_1 != value)
			{
				stringAlignment_1 = value;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	[Description("Indicates label font.")]
	[Browsable(true)]
	public Font Font
	{
		get
		{
			return font_0;
		}
		set
		{
			if (font_0 != value)
			{
				font_0 = value;
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	[DefaultValue(0)]
	[Description("Indicates left padding in pixels.")]
	public int PaddingLeft
	{
		get
		{
			return int_5;
		}
		set
		{
			if (int_5 != value)
			{
				int_5 = value;
				NeedRecalcSize = true;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates right padding in pixels.")]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(0)]
	public int PaddingRight
	{
		get
		{
			return int_6;
		}
		set
		{
			if (int_6 != value)
			{
				int_6 = value;
				NeedRecalcSize = true;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	[Category("Layout")]
	[Browsable(true)]
	[Description("Indicates top padding in pixels.")]
	public int PaddingTop
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
				NeedRecalcSize = true;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates bottom padding in pixels.")]
	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(0)]
	public int PaddingBottom
	{
		get
		{
			return int_8;
		}
		set
		{
			if (int_8 != value)
			{
				int_8 = value;
				NeedRecalcSize = true;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(0)]
	[Category("Layout")]
	[Description("Indicates the width of the label in pixels.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public int Width
	{
		get
		{
			return int_9;
		}
		set
		{
			if (int_9 != value)
			{
				int_9 = value;
				NeedRecalcSize = true;
				if (!bool_26)
				{
					Refresh();
					OnAppearanceChanged();
				}
			}
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[Description("Indicates height of the label in pixels.")]
	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	public int Height
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
				NeedRecalcSize = true;
				if (!bool_26)
				{
					Refresh();
					OnAppearanceChanged();
				}
			}
		}
	}

	[Browsable(true)]
	[Description("Indicates whether label has divider style.")]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public bool DividerStyle
	{
		get
		{
			return bool_23;
		}
		set
		{
			if (bool_23 != value)
			{
				bool_23 = value;
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[Description("Gets or sets a value that determines whether text is displayed in multiple lines or one long line.")]
	[DefaultValue(false)]
	public bool WordWrap
	{
		get
		{
			return bool_24;
		}
		set
		{
			if (bool_24 != value)
			{
				bool_24 = value;
				m_NeedRecalcSize = true;
			}
			OnAppearanceChanged();
		}
	}

	internal bool Boolean_3
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[DevCoBrowsable(true)]
	[Description("The text contained in the item.")]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			if (m_Text == value)
			{
				return;
			}
			if (value == null)
			{
				m_Text = "";
			}
			else
			{
				m_Text = value;
			}
			m_AccessKey = Class92.smethod_2(m_Text);
			if (ShouldSyncProperties)
			{
				Class109.smethod_22(this, "Text");
			}
			if (Displayed && m_Parent != null && !SuspendLayout)
			{
				if (int_9 == 0)
				{
					NeedRecalcSize = true;
				}
				if (!(ContainerControl is LabelX))
				{
					Refresh();
				}
			}
			OnTextChanged();
			OnAppearanceChanged();
			if (ContainerControl is BaseItemControl)
			{
				NeedRecalcSize = true;
				Refresh();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the label icon.")]
	[DefaultValue(null)]
	[Category("Appearance")]
	public Icon Icon
	{
		get
		{
			return icon_1;
		}
		set
		{
			icon_1 = value;
			method_25();
			OnAppearanceChanged();
		}
	}

	[DefaultValue(null)]
	[Description("The image that will be displayed on the face of the item.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			method_25();
			OnAppearanceChanged();
		}
	}

	[DefaultValue(-1)]
	[Browsable(true)]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Description("The image list image index of the image that will be displayed on the face of the item.")]
	public int ImageIndex
	{
		get
		{
			return int_11;
		}
		set
		{
			image_1 = null;
			if (int_11 != value)
			{
				int_11 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ImageIndex");
				}
				method_25();
			}
			OnAppearanceChanged();
		}
	}

	[Description("The alignment of the image in relation to text displayed by this item.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(eImagePosition.Left)]
	[Category("Appearance")]
	public eImagePosition ImagePosition
	{
		get
		{
			return eImagePosition_0;
		}
		set
		{
			if (eImagePosition_0 != value)
			{
				eImagePosition_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ImagePosition");
				}
				NeedRecalcSize = true;
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	private Size Size_0
	{
		get
		{
			Size result = new Size(16, 16);
			IBarImageSize barImageSize = null;
			if (itemPaintArgs_0 != null)
			{
				barImageSize = itemPaintArgs_0.ContainerControl as IBarImageSize;
			}
			if (barImageSize == null)
			{
				barImageSize = ContainerControl as IBarImageSize;
			}
			try
			{
				if (barImageSize != null && barImageSize.ImageSize != 0)
				{
					if (barImageSize.ImageSize == eBarImageSize.Medium)
					{
						result = new Size(24, 24);
						return result;
					}
					if (barImageSize.ImageSize == eBarImageSize.Large)
					{
						result = new Size(32, 32);
						return result;
					}
					return result;
				}
				if (m_Parent is SideBarPanelItem)
				{
					if (((SideBarPanelItem)m_Parent).ItemImageSize != 0)
					{
						switch (((SideBarPanelItem)m_Parent).ItemImageSize)
						{
						case eBarImageSize.Medium:
							result = new Size(24, 24);
							return result;
						case eBarImageSize.Large:
							result = new Size(32, 32);
							return result;
						default:
							return result;
						}
					}
					return result;
				}
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	public event MarkupLinkClickEventHandler MarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	public LabelItem()
		: this("", "")
	{
	}

	public LabelItem(string sName)
		: this(sName, "")
	{
	}

	public LabelItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		IsAccessible = false;
	}

	public override BaseItem Copy()
	{
		LabelItem labelItem = new LabelItem(m_Name);
		CopyToItem(labelItem);
		return labelItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		LabelItem labelItem = copy as LabelItem;
		base.CopyToItem(labelItem);
		labelItem.BorderType = eBorderType_0;
		labelItem.BorderSide = eBorderSide_1;
		labelItem.BackColor = color_0;
		labelItem.ForeColor = color_1;
		if (bool_22)
		{
			labelItem.SingleLineColor = color_2;
		}
		labelItem.WidthInternal = WidthInternal;
		labelItem.HeightInternal = HeightInternal;
		labelItem.TextAlignment = TextAlignment;
		labelItem.TextLineAlignment = TextLineAlignment;
		labelItem.Font = font_0;
		labelItem.PaddingBottom = int_8;
		labelItem.PaddingLeft = int_5;
		labelItem.PaddingRight = int_6;
		labelItem.PaddingTop = int_7;
		labelItem.Image = Image;
		labelItem.ImageIndex = ImageIndex;
		labelItem.ImagePosition = ImagePosition;
		labelItem.WordWrap = WordWrap;
		labelItem.DividerStyle = DividerStyle;
		labelItem.EnableMarkup = EnableMarkup;
		labelItem.Width = Width;
		labelItem.Height = Height;
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Invalid comparison between Unknown and I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Invalid comparison between Unknown and I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Invalid comparison between Unknown and I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Invalid comparison between Unknown and I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Invalid comparison between Unknown and I4
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e7: Invalid comparison between Unknown and I4
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Invalid comparison between Unknown and I4
		if (SuspendLayout)
		{
			return;
		}
		itemPaintArgs_0 = pa;
		Class271 @class = method_26();
		Graphics graphics = pa.Graphics;
		Rectangle displayRectangle = DisplayRectangle;
		Rectangle rectangle = Rectangle.Empty;
		Border3DSide val = (bool_23 ? ((Border3DSide)2) : ((eBorderSide_1 != eBorderSide.All) ? ((Border3DSide)((((eBorderSide_1 & eBorderSide.Left) != 0) ? 1 : 0) | (((eBorderSide_1 & eBorderSide.Right) != 0) ? 4 : 0) | (((eBorderSide_1 & eBorderSide.Top) != 0) ? 2 : 0) | (((eBorderSide_1 & eBorderSide.Bottom) != 0) ? 8 : 0))) : ((Border3DSide)15)));
		Class50.smethod_24(graphics, DisplayRectangle, color_0, Color.Empty);
		if (bool_23)
		{
			object containerControl = ContainerControl;
			Control val2 = (Control)((containerControl is Control) ? containerControl : null);
			RightToLeft val3 = (RightToLeft)0;
			if (val2 != null && (int)val2.get_RightToLeft() == 1)
			{
				val3 = (RightToLeft)1;
			}
			Size size = Class55.smethod_4(graphics, m_Text, GetFont(), m_Rect.Width, method_24());
			size.Width += 4;
			if (size.Width > displayRectangle.Width)
			{
				size.Width = displayRectangle.Width;
			}
			rectangle = new Rectangle(displayRectangle.X, displayRectangle.Y, size.Width, size.Height);
			if ((int)stringAlignment_0 == 1)
			{
				rectangle.Offset((displayRectangle.Width - size.Width) / 2, 0);
			}
			else if (((int)stringAlignment_0 == 2 && (int)val3 == 0) || ((int)stringAlignment_0 == 0 && (int)val3 == 1))
			{
				rectangle.Offset(displayRectangle.Width - rectangle.Width, 0);
			}
			if ((int)stringAlignment_1 == 1)
			{
				rectangle.Offset(0, (displayRectangle.Height - rectangle.Height) / 2);
			}
			else if (((int)stringAlignment_1 == 2 && (int)val3 == 0) || ((int)stringAlignment_1 == 0 && (int)val3 == 1))
			{
				rectangle.Offset(0, displayRectangle.Height - rectangle.Height);
			}
		}
		switch (eBorderType_0)
		{
		case eBorderType.SingleLine:
			if (bool_23)
			{
				graphics.DrawLine(new Pen(method_23(), 1f), m_Rect.X, m_Rect.Y + m_Rect.Height / 2, m_Rect.Right, m_Rect.Y + m_Rect.Height / 2);
				break;
			}
			Class109.smethod_31(graphics, eBorderType.SingleLine, m_Rect, method_23(), eBorderSide_1, (DashStyle)0, 1);
			displayRectangle.Inflate(-1, -1);
			break;
		case eBorderType.DoubleLine:
			Class109.smethod_28(graphics, eBorderType.DoubleLine, m_Rect, method_23());
			displayRectangle.Inflate(-2, -2);
			break;
		case eBorderType.Sunken:
			if (bool_23)
			{
				ControlPaint.DrawBorder3D(graphics, m_Rect.X, m_Rect.Y + m_Rect.Height / 2, m_Rect.Width, 2, (Border3DStyle)2, val);
				break;
			}
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)2, val);
			displayRectangle.Inflate(-2, -2);
			break;
		case eBorderType.Etched:
			if (bool_23)
			{
				ControlPaint.DrawBorder3D(graphics, m_Rect.X, m_Rect.Y + m_Rect.Height / 2, m_Rect.Width, 2, (Border3DStyle)6, val);
				break;
			}
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)6, val);
			displayRectangle.Inflate(-2, -2);
			break;
		case eBorderType.Bump:
			if (bool_23)
			{
				ControlPaint.DrawBorder3D(graphics, m_Rect.X, m_Rect.Y + m_Rect.Height / 2, m_Rect.Width, 2, (Border3DStyle)9, val);
				break;
			}
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)9, val);
			displayRectangle.Inflate(-2, -2);
			break;
		case eBorderType.Raised:
		case eBorderType.RaisedInner:
			if (bool_23)
			{
				ControlPaint.DrawBorder3D(graphics, m_Rect.X, m_Rect.Y + m_Rect.Height / 2, m_Rect.Width, 2, (Border3DStyle)4, val);
				break;
			}
			ControlPaint.DrawBorder3D(graphics, m_Rect, (Border3DStyle)4, val);
			displayRectangle.Inflate(-2, -2);
			break;
		}
		if (bool_23)
		{
			graphics.FillRectangle((Brush)new SolidBrush(color_0), rectangle);
		}
		if (Orientation == eOrientation.Horizontal)
		{
			displayRectangle.X += int_5;
		}
		else
		{
			displayRectangle.Y += int_5;
		}
		if (Orientation == eOrientation.Horizontal)
		{
			displayRectangle.Width -= int_5 + int_6;
		}
		else
		{
			displayRectangle.Width -= int_7 + int_8;
		}
		displayRectangle.Y += int_7;
		if (Orientation == eOrientation.Horizontal)
		{
			displayRectangle.Height -= int_7 + int_8;
		}
		else
		{
			displayRectangle.Height -= int_5 + int_6;
		}
		if (@class != null)
		{
			switch (eImagePosition_0)
			{
			case eImagePosition.Left:
				@class.method_0(graphics, new Rectangle(displayRectangle.X + 2, displayRectangle.Y + (displayRectangle.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
				if (m_Orientation == eOrientation.Horizontal)
				{
					displayRectangle.X += @class.Int32_0 + 4;
					displayRectangle.Width -= @class.Int32_0 + 4;
				}
				else
				{
					displayRectangle.Y += @class.Int32_1 + 4;
					displayRectangle.Height -= @class.Int32_1 + 4;
				}
				break;
			case eImagePosition.Right:
				if (m_Orientation == eOrientation.Horizontal)
				{
					@class.method_0(graphics, new Rectangle(displayRectangle.Right - @class.Int32_0 - 2, displayRectangle.Y + (displayRectangle.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
					displayRectangle.Width -= @class.Int32_0 + 4;
				}
				else
				{
					@class.method_0(graphics, new Rectangle(displayRectangle.X, displayRectangle.Bottom - @class.Int32_1 - 2, @class.Int32_0, @class.Int32_1));
					displayRectangle.Height -= @class.Int32_1 + 4;
				}
				break;
			case eImagePosition.Top:
				if (m_Orientation == eOrientation.Horizontal)
				{
					@class.method_0(graphics, new Rectangle(displayRectangle.X + (displayRectangle.Width - @class.Int32_0) / 2, displayRectangle.Y, @class.Int32_0, @class.Int32_1));
					displayRectangle.Y += @class.Int32_1 + 2;
					displayRectangle.Height -= @class.Int32_1 + 2;
				}
				else
				{
					@class.method_0(graphics, new Rectangle(displayRectangle.X, displayRectangle.Y + (displayRectangle.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
					displayRectangle.X += @class.Int32_0 + 2;
					displayRectangle.Width -= @class.Int32_0 + 2;
				}
				break;
			case eImagePosition.Bottom:
				if (m_Orientation == eOrientation.Horizontal)
				{
					@class.method_0(graphics, new Rectangle(displayRectangle.X + (displayRectangle.Width - @class.Int32_0) / 2, displayRectangle.Bottom - @class.Int32_1, @class.Int32_0, @class.Int32_1));
					displayRectangle.Height -= @class.Int32_1 + 2;
				}
				else
				{
					@class.method_0(graphics, new Rectangle(displayRectangle.Right - @class.Int32_0, displayRectangle.Y + (displayRectangle.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
					displayRectangle.Width -= @class.Int32_0 + 2;
				}
				break;
			}
		}
		Color currentForeColor = method_17(pa);
		if (displayRectangle.Height > 0 && displayRectangle.Width > 0)
		{
			if (Orientation == eOrientation.Horizontal)
			{
				if (base.Class261_0 != null)
				{
					Class263 class2 = new Class263(graphics, GetFont(), currentForeColor, pa.RightToLeft);
					class2.bool_3 = (method_24() & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
					if ((int)stringAlignment_1 == 0)
					{
						base.Class261_0.Bounds = new Rectangle(displayRectangle.Location, base.Class261_0.Bounds.Size);
					}
					else if ((int)stringAlignment_1 == 1)
					{
						base.Class261_0.Bounds = new Rectangle(new Point(displayRectangle.X, displayRectangle.Y + (displayRectangle.Height - base.Class261_0.Bounds.Height) / 2), base.Class261_0.Bounds.Size);
					}
					else if ((int)stringAlignment_1 == 2)
					{
						base.Class261_0.Bounds = new Rectangle(new Point(displayRectangle.X, displayRectangle.Bottom - base.Class261_0.Bounds.Height), base.Class261_0.Bounds.Size);
					}
					Region clip = graphics.get_Clip();
					Rectangle rectangle2 = displayRectangle;
					rectangle2.Inflate(2, 2);
					graphics.SetClip(rectangle2, (CombineMode)0);
					base.Class261_0.Render(class2);
					if (clip != null)
					{
						graphics.set_Clip(clip);
					}
					else
					{
						graphics.ResetClip();
					}
				}
				else
				{
					eTextFormat eTextFormat2 = method_24();
					if (pa.RightToLeft)
					{
						eTextFormat2 |= eTextFormat.RightToLeft;
					}
					if (pa.GlassEnabled && Parent is Class181 && !(ContainerControl is Control7))
					{
						if (!pa.bool_0)
						{
							Class169.smethod_0(graphics, m_Text, GetFont(), displayRectangle, Class55.smethod_12(eTextFormat2));
						}
					}
					else
					{
						Class55.smethod_1(graphics, m_Text, GetFont(), currentForeColor, displayRectangle, eTextFormat2);
					}
				}
			}
			else
			{
				graphics.RotateTransform(90f);
				if (base.Class261_0 != null)
				{
					base.Class261_0.Bounds = new Rectangle(displayRectangle.Top, -displayRectangle.Right, base.Class261_0.Bounds.Width, base.Class261_0.Bounds.Height);
					Class263 class3 = new Class263(graphics, GetFont(), currentForeColor, pa.RightToLeft);
					class3.bool_3 = (method_24() & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
					base.Class261_0.Render(class3);
				}
				else
				{
					Class55.smethod_2(graphics, m_Text, GetFont(), currentForeColor, new Rectangle(displayRectangle.Top, -displayRectangle.Right, displayRectangle.Height, displayRectangle.Width), method_24());
				}
				graphics.ResetTransform();
			}
		}
		DrawInsertMarker(graphics);
		if (DesignMode && Focused)
		{
			Rectangle rect = m_Rect;
			rect.Width--;
			rect.Height--;
			Class32.smethod_0(graphics, rect, pa.Colors.ItemDesignTimeBorder);
		}
		itemPaintArgs_0 = null;
	}

	private Color method_17(ItemPaintArgs itemPaintArgs_1)
	{
		if (Style == eDotNetBarStyle.Office2007 && color_1 == SystemColors.ControlText && itemPaintArgs_1.BaseRenderer_0 is Office2007Renderer)
		{
			if ((itemPaintArgs_1.IsOnMenu || itemPaintArgs_1.IsOnPopupBar) && ((Office2007Renderer)itemPaintArgs_1.BaseRenderer_0).ColorTable.ButtonItemColors.Count > 0)
			{
				if (!method_1(itemPaintArgs_1.ContainerControl))
				{
					return itemPaintArgs_1.Colors.ItemDisabledText;
				}
				return ((Office2007Renderer)itemPaintArgs_1.BaseRenderer_0).ColorTable.ButtonItemColors[0].Default.Text;
			}
			if ((itemPaintArgs_1.ContainerControl is RibbonStrip || itemPaintArgs_1.ContainerControl is Bar) && ((Office2007Renderer)itemPaintArgs_1.BaseRenderer_0).ColorTable.RibbonTabItemColors.Count > 0)
			{
				return ((Office2007Renderer)itemPaintArgs_1.BaseRenderer_0).ColorTable.RibbonTabItemColors[0].Default.Text;
			}
			Office2007ButtonItemColorTable office2007ButtonItemColorTable = ((Office2007Renderer)itemPaintArgs_1.BaseRenderer_0).ColorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.Orange)];
			if (office2007ButtonItemColorTable != null && !office2007ButtonItemColorTable.Default.Text.IsEmpty)
			{
				if (!method_1(itemPaintArgs_1.ContainerControl))
				{
					return itemPaintArgs_1.Colors.ItemDisabledText;
				}
				return office2007ButtonItemColorTable.Default.Text;
			}
		}
		return color_1;
	}

	private Graphics method_18()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!BaseItem.IsHandleValid(val))
		{
			return null;
		}
		return Class109.smethod_68(val);
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		if (base.Class261_0 != null)
		{
			method_21();
		}
		else
		{
			Class271 @class = method_26();
			if (Orientation != 0 && int_9 != 0)
			{
				WidthInternal = int_10;
				HeightInternal = int_9;
			}
			else if (int_9 == 0)
			{
				Graphics val = method_18();
				if (val == null)
				{
					return;
				}
				try
				{
					Font val2 = null;
					val2 = ((font_0 == null) ? GetFont() : font_0);
					Size empty = Size.Empty;
					eTextFormat eTextFormat_ = method_24();
					if (m_Text != "")
					{
						string text = m_Text;
						if (text.EndsWith(" "))
						{
							text += ".";
						}
						int width = 0;
						if (bool_24 && Stretch && WidthInternal > 16)
						{
							width = WidthInternal;
						}
						empty = ((m_Orientation != eOrientation.Vertical || base.IsOnMenu) ? Class55.smethod_4(val, text, val2, width, eTextFormat_) : Class55.smethod_7(val, text, val2, new Size(width, 0), eTextFormat_));
						empty.Width += 2;
					}
					else
					{
						empty = ((m_Orientation != eOrientation.Vertical || base.IsOnMenu) ? Class55.smethod_4(val, " ", val2, 0, eTextFormat_) : Class55.smethod_7(val, " ", val2, Size.Empty, eTextFormat_));
						empty.Width += 2;
					}
					if (Parent is Class181)
					{
						empty.Width += 2;
					}
					if (eBorderType_0 != 0)
					{
						empty.Width += 4;
						empty.Height += 2;
						if (eBorderType_0 != eBorderType.SingleLine)
						{
							empty.Height += 2;
						}
					}
					if (Orientation == eOrientation.Horizontal)
					{
						if (Stretch && !(Parent is ItemContainer))
						{
							WidthInternal = 8;
						}
						else
						{
							WidthInternal = empty.Width + int_5 + int_6;
						}
						HeightInternal = empty.Height + int_7 + int_8;
						if (@class != null)
						{
							if (eImagePosition_0 != 0 && eImagePosition_0 != eImagePosition.Right)
							{
								HeightInternal += @class.Int32_1 + 4;
							}
							else
							{
								WidthInternal += @class.Int32_0 + 4;
								HeightInternal = Math.Max(HeightInternal, @class.Int32_1 + 2);
							}
						}
					}
					else
					{
						if (Stretch && !(Parent is ItemContainer))
						{
							HeightInternal = 8;
						}
						else
						{
							HeightInternal = empty.Width + int_5 + int_6;
						}
						WidthInternal = empty.Height + int_7 + int_8;
						if (@class != null)
						{
							if (eImagePosition_0 != 0 && eImagePosition_0 != eImagePosition.Right)
							{
								WidthInternal += @class.Int32_1 + 4;
							}
							else
							{
								HeightInternal += @class.Int32_0 + 4;
								WidthInternal = Math.Max(HeightInternal, @class.Int32_1 + 2);
							}
						}
					}
				}
				finally
				{
					val.set_TextRenderingHint((TextRenderingHint)0);
					val.set_SmoothingMode((SmoothingMode)0);
					val.Dispose();
				}
			}
			else
			{
				WidthInternal = int_9;
				if (int_10 == 0)
				{
					Font val3 = null;
					val3 = ((font_0 == null) ? GetFont() : font_0);
					if (WordWrap)
					{
						Graphics val4 = method_18();
						if (val4 != null)
						{
							HeightInternal = Class55.smethod_5(val4, Text, val3, WidthInternal - (int_5 + int_6)).Height + 2;
						}
						else
						{
							HeightInternal = (int)Math.Ceiling(val3.GetHeight());
						}
					}
					else
					{
						HeightInternal = (int)Math.Ceiling(val3.GetHeight());
					}
					HeightInternal += int_7 + int_8 + (IsRightToLeft ? 2 : 0);
					if (eBorderType_0 != 0)
					{
						HeightInternal += 2;
						if (eBorderType_0 != eBorderType.SingleLine)
						{
							HeightInternal += 2;
						}
					}
					if (@class != null)
					{
						if (Orientation == eOrientation.Horizontal)
						{
							if (eImagePosition_0 != 0 && eImagePosition_0 != eImagePosition.Right)
							{
								HeightInternal += @class.Int32_1 + 4;
							}
							else
							{
								HeightInternal = Math.Max(HeightInternal, @class.Int32_1);
							}
						}
						else if (eImagePosition_0 != 0 && eImagePosition_0 != eImagePosition.Right)
						{
							WidthInternal += @class.Int32_1 + 4;
						}
						else
						{
							WidthInternal = Math.Max(HeightInternal, @class.Int32_1 + 2);
						}
					}
				}
				else
				{
					HeightInternal = int_10;
				}
			}
		}
		base.RecalcSize();
	}

	protected override void OnExternalSizeChange()
	{
		if (base.Class261_0 != null)
		{
			method_19(WidthInternal);
		}
		base.OnExternalSizeChange();
	}

	private void method_19(int int_12)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (BaseItem.IsHandleValid(val))
		{
			Graphics g = Class109.smethod_68(val);
			Font val2 = null;
			val2 = ((font_0 == null) ? GetFont() : font_0);
			method_26();
			Size size = method_20(int_12);
			Class263 @class = new Class263(g, val2, ForeColor, rightToLeft: false);
			@class.bool_3 = (method_24() & eTextFormat.HidePrefix) != eTextFormat.HidePrefix;
			base.Class261_0.Measure(size, @class);
			@class.bool_0 = (int)val.get_RightToLeft() == 1;
			if (int_12 == 0 && int_9 == 0)
			{
				size = base.Class261_0.Bounds.Size;
			}
			base.Class261_0.method_2(new Rectangle(Point.Empty, size), @class);
		}
	}

	private Size method_20(int int_12)
	{
		Size result = new Size((int_12 == 0) ? int_9 : int_12, 1);
		Class271 @class = method_26();
		if (result.Width == 0)
		{
			result.Width = 1600;
		}
		else
		{
			result.Width -= int_5 + int_6;
			if (@class != null && (eImagePosition_0 == eImagePosition.Left || eImagePosition_0 == eImagePosition.Right))
			{
				result.Width -= @class.Int32_0 + 4;
			}
			if (eBorderType_0 != 0)
			{
				result.Width -= 4;
			}
		}
		return result;
	}

	private void method_21()
	{
		method_22(0);
	}

	internal void method_22(int int_12)
	{
		method_19(int_12);
		int num = base.Class261_0.Bounds.Width;
		int num2 = base.Class261_0.Bounds.Height;
		if (eBorderType_0 != 0)
		{
			num += 4;
			num2 += 4;
		}
		Class271 @class = method_26();
		if (@class != null && int_9 == 0)
		{
			if (eImagePosition_0 != 0 && eImagePosition_0 != eImagePosition.Right)
			{
				num2 += @class.Int32_1 + 4;
				num = Math.Max(num, @class.Int32_0 + 2);
			}
			else
			{
				num += @class.Int32_0 + 4;
				num2 = Math.Max(num2, @class.Int32_1 + 2);
			}
		}
		if (int_9 == 0)
		{
			num += int_5 + int_6;
			num2 += int_7 + int_8;
			if (Stretch && !(Parent is ItemContainer))
			{
				num = 8;
			}
		}
		if (int_9 == 0)
		{
			WidthInternal = num;
		}
		else
		{
			WidthInternal = int_9;
		}
		if (int_10 == 0)
		{
			HeightInternal = num2;
		}
		else
		{
			HeightInternal = int_10;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeForeColor()
	{
		return color_1 != SystemColors.ControlText;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSingleLineColor()
	{
		return color_2 != SystemColors.ControlDark;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSingleLineColor()
	{
		SingleLineColor = SystemColors.ControlDark;
	}

	private Color method_23()
	{
		if (bool_22)
		{
			return color_2;
		}
		Color toolbarBottomBorder = color_2;
		if (Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
		{
			if (Style == eDotNetBarStyle.Office2007)
			{
				if (ContainerControl is IRenderingSupport)
				{
					Office2007Renderer office2007Renderer = ((IRenderingSupport)ContainerControl).GetRenderer() as Office2007Renderer;
					if (office2007Renderer == null)
					{
						office2007Renderer = GlobalManager.Renderer as Office2007Renderer;
					}
					if (office2007Renderer != null)
					{
						toolbarBottomBorder = office2007Renderer.ColorTable.Bar.ToolbarBottomBorder;
					}
				}
			}
			else
			{
				ColorScheme colorScheme = null;
				colorScheme = ((ContainerControl is Bar) ? ((Bar)ContainerControl).ColorScheme : ((!(ContainerControl is MenuPanel)) ? new ColorScheme(Style) : ((MenuPanel)ContainerControl).ColorScheme));
				if (colorScheme != null)
				{
					color_2 = colorScheme.BarDockedBorder;
				}
				else
				{
					color_2 = SystemColors.ControlDark;
				}
			}
		}
		return toolbarBottomBorder;
	}

	protected virtual Font GetFont()
	{
		if (font_0 != null)
		{
			return font_0;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			return val.get_Font();
		}
		return SystemInformation.get_MenuFont();
	}

	private eTextFormat method_24()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		eTextFormat eTextFormat2 = eTextFormat.EndEllipsis | eTextFormat.ExpandTabs;
		if (!bool_25)
		{
			eTextFormat2 |= eTextFormat.NoPrefix;
		}
		eTextFormat2 = (bool_24 ? (eTextFormat2 | eTextFormat.WordBreak) : (eTextFormat2 | eTextFormat.SingleLine));
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
		if (IsRightToLeft)
		{
			eTextFormat2 |= eTextFormat.RightToLeft;
		}
		return eTextFormat2;
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected I4, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected I4, but got Unknown
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("bt", XmlConvert.ToString((int)eBorderType_0));
		if (eBorderSide_1 != eBorderSide.All)
		{
			itemXmlElement.SetAttribute("BorderSide", XmlConvert.ToString((int)eBorderSide_1));
		}
		if (!color_0.IsEmpty)
		{
			itemXmlElement.SetAttribute("bc", Class109.smethod_50(color_0));
		}
		itemXmlElement.SetAttribute("fc", Class109.smethod_50(color_1));
		if (bool_22)
		{
			itemXmlElement.SetAttribute("sc", Class109.smethod_50(color_2));
		}
		itemXmlElement.SetAttribute("ta", XmlConvert.ToString((int)stringAlignment_0));
		itemXmlElement.SetAttribute("tla", XmlConvert.ToString((int)stringAlignment_1));
		itemXmlElement.SetAttribute("ds", XmlConvert.ToString(bool_23));
		itemXmlElement.SetAttribute("pl", XmlConvert.ToString(int_5));
		itemXmlElement.SetAttribute("pr", XmlConvert.ToString(int_6));
		itemXmlElement.SetAttribute("pt", XmlConvert.ToString(int_7));
		itemXmlElement.SetAttribute("pb", XmlConvert.ToString(int_8));
		itemXmlElement.SetAttribute("w", XmlConvert.ToString(int_9));
		itemXmlElement.SetAttribute("h", XmlConvert.ToString(int_10));
		if (Font != null && (Font.get_Name() != SystemInformation.get_MenuFont().get_Name() || Font.get_Size() != SystemInformation.get_MenuFont().get_Size() || Font.get_Style() != SystemInformation.get_MenuFont().get_Style()))
		{
			itemXmlElement.SetAttribute("fontname", Font.get_Name());
			itemXmlElement.SetAttribute("fontemsize", XmlConvert.ToString(Font.get_Size()));
			itemXmlElement.SetAttribute("fontstyle", XmlConvert.ToString((int)Font.get_Style()));
		}
		XmlElement xmlElement = null;
		XmlElement xmlElement2 = null;
		if (image_0 != null || int_11 >= 0 || icon_1 != null)
		{
			xmlElement = itemXmlElement.OwnerDocument.CreateElement("images");
			itemXmlElement.AppendChild(xmlElement);
			if (int_11 >= 0)
			{
				xmlElement.SetAttribute("imageindex", XmlConvert.ToString(int_11));
			}
			if (image_0 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "default");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_0, xmlElement2);
			}
			if (icon_1 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "icon");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_14(icon_1, xmlElement2);
			}
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		eBorderType_0 = (eBorderType)XmlConvert.ToInt32(itemXmlElement.GetAttribute("bt"));
		if (itemXmlElement.HasAttribute("BorderSide"))
		{
			eBorderSide_1 = (eBorderSide)XmlConvert.ToInt32(itemXmlElement.GetAttribute("BorderSide"));
		}
		else
		{
			eBorderSide_1 = eBorderSide.All;
		}
		if (itemXmlElement.HasAttribute("bc"))
		{
			color_0 = Class109.smethod_51(itemXmlElement.GetAttribute("bc"));
		}
		else
		{
			color_0 = Color.Empty;
		}
		color_1 = Class109.smethod_51(itemXmlElement.GetAttribute("fc"));
		if (itemXmlElement.HasAttribute("sc"))
		{
			color_2 = Class109.smethod_51(itemXmlElement.GetAttribute("sc"));
			if (color_2 != SystemColors.ControlDark)
			{
				bool_22 = true;
			}
		}
		else
		{
			bool_22 = false;
			color_2 = SystemColors.ControlDark;
		}
		stringAlignment_0 = (StringAlignment)XmlConvert.ToInt32(itemXmlElement.GetAttribute("ta"));
		stringAlignment_1 = (StringAlignment)XmlConvert.ToInt32(itemXmlElement.GetAttribute("tla"));
		bool_23 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("ds"));
		int_5 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("pl"));
		int_6 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("pr"));
		int_7 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("pt"));
		int_8 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("pb"));
		int_9 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("w"));
		int_10 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("h"));
		if (itemXmlElement.HasAttribute("fontname"))
		{
			string attribute = itemXmlElement.GetAttribute("fontname");
			float num = XmlConvert.ToSingle(itemXmlElement.GetAttribute("fontemsize"));
			FontStyle val = (FontStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("fontstyle"));
			try
			{
				Font = new Font(attribute, num, val);
			}
			catch (Exception)
			{
				object obj = SystemInformation.get_MenuFont().Clone();
				Font = (Font)((obj is Font) ? obj : null);
			}
		}
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			if (!(childNode.Name == "images"))
			{
				continue;
			}
			if (childNode.HasAttribute("imageindex"))
			{
				int_11 = XmlConvert.ToInt32(childNode.GetAttribute("imageindex"));
			}
			{
				foreach (XmlElement childNode2 in childNode.ChildNodes)
				{
					switch (childNode2.GetAttribute("type"))
					{
					case "icon":
						icon_1 = Class109.smethod_17(childNode2);
						int_11 = -1;
						break;
					case "default":
						image_0 = Class109.smethod_16(childNode2);
						int_11 = -1;
						break;
					}
				}
				break;
			}
		}
	}

	private void method_25()
	{
		if (image_2 != null)
		{
			image_2.Dispose();
			image_2 = null;
		}
		if (icon_0 != null)
		{
			icon_0.Dispose();
			icon_0 = null;
		}
		NeedRecalcSize = true;
		Refresh();
	}

	private Class271 method_26()
	{
		if (method_2())
		{
			return method_27(Enum15.const_0);
		}
		return method_27(Enum15.const_1);
	}

	private Class271 method_27(Enum15 enum15_0)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		Image val = null;
		if (enum15_0 == Enum15.const_1)
		{
			if (image_2 == null && icon_0 == null && (icon_1 != null || image_0 != null || int_11 >= 0))
			{
				method_28();
			}
			if (icon_0 != null)
			{
				return new Class271(new Icon(icon_0, Size_0), dispose: true);
			}
			if (image_2 != null)
			{
				return new Class271(image_2, dispose: false);
			}
		}
		if (icon_1 != null)
		{
			Size size_ = Size_0;
			return new Class271(new Icon(icon_1, size_), dispose: true);
		}
		if (image_0 != null)
		{
			return new Class271(image_0, dispose: false);
		}
		if (int_11 >= 0)
		{
			val = method_29(int_11);
			if (val != null)
			{
				return new Class271(val, dispose: false);
			}
		}
		return null;
	}

	private void method_28()
	{
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Invalid comparison between Unknown and I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Invalid comparison between Unknown and I4
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Invalid comparison between Unknown and I4
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		if (image_0 == null && int_11 < 0 && icon_1 == null)
		{
			return;
		}
		if (image_2 != null)
		{
			image_2.Dispose();
		}
		image_2 = null;
		if (icon_0 != null)
		{
			icon_0.Dispose();
		}
		icon_0 = null;
		Class271 @class = method_27(Enum15.const_0);
		if (@class == null)
		{
			return;
		}
		if (GetOwner() is IOwner && ((IOwner)GetOwner()).DisabledImagesGrayScale)
		{
			if (@class.Boolean_0)
			{
				icon_0 = Class109.smethod_59(@class.Icon_0);
			}
			else
			{
				ref Image reference = ref image_2;
				Image obj = @class.Image_0;
				reference = (Image)(object)Class31.smethod_1((obj is Bitmap) ? obj : null);
			}
		}
		if (icon_0 == null && image_2 == null)
		{
			PixelFormat val = (PixelFormat)2498570;
			if (!@class.Boolean_0 && @class.Image_0 != null)
			{
				val = @class.Image_0.get_PixelFormat();
			}
			if ((int)val == 196865 || (int)val == 197634 || (int)val == 198659)
			{
				val = (PixelFormat)2498570;
			}
			Bitmap val2 = new Bitmap(@class.Int32_0, @class.Int32_1, val);
			image_2 = (Image)new Bitmap(@class.Int32_0, @class.Int32_1, val);
			Graphics val3 = Graphics.FromImage((Image)(object)val2);
			SolidBrush val4 = new SolidBrush(Color.White);
			try
			{
				val3.FillRectangle((Brush)(object)val4, 0, 0, @class.Int32_0, @class.Int32_1);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
			@class.method_0(val3, new Rectangle(0, 0, @class.Int32_0, @class.Int32_1));
			val3.Dispose();
			val3 = Graphics.FromImage(image_2);
			val2.MakeTransparent(Color.White);
			if ((m_Style == eDotNetBarStyle.OfficeXP || m_Style == eDotNetBarStyle.Office2003 || m_Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_Style)) && Class92.int_74 >= 8)
			{
				float[][] array = new float[5][];
				float[] array2 = (array[0] = new float[5]);
				float[] array3 = (array[1] = new float[5]);
				float[] array4 = (array[2] = new float[5]);
				array[3] = new float[5] { 0.5f, 0.5f, 0.5f, 0.5f, 0f };
				float[] array5 = (array[4] = new float[5]);
				ColorMatrix colorMatrix = new ColorMatrix(array);
				ImageAttributes val5 = new ImageAttributes();
				val5.ClearColorKey();
				val5.SetColorMatrix(colorMatrix);
				val3.DrawImage((Image)(object)val2, new Rectangle(0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height()), 0, 0, ((Image)val2).get_Width(), ((Image)val2).get_Height(), (GraphicsUnit)2, val5);
			}
			else
			{
				ControlPaint.DrawImageDisabled(val3, (Image)(object)val2, 0, 0, ColorFunctions.MenuBackColor(val3));
			}
			val3.Dispose();
			val3 = null;
			((Image)val2).Dispose();
			val2 = null;
			@class.Dispose();
		}
	}

	private Image method_29(int int_12)
	{
		if (int_12 >= 0)
		{
			IOwner owner = null;
			IBarImageSize barImageSize = null;
			if (itemPaintArgs_0 != null)
			{
				owner = itemPaintArgs_0.Owner;
				barImageSize = itemPaintArgs_0.ContainerControl as IBarImageSize;
			}
			if (owner == null)
			{
				owner = GetOwner() as IOwner;
			}
			if (barImageSize == null)
			{
				barImageSize = ContainerControl as IBarImageSize;
			}
			if (owner != null)
			{
				try
				{
					if (barImageSize != null && barImageSize.ImageSize != 0)
					{
						if (barImageSize.ImageSize == eBarImageSize.Medium && owner.ImagesMedium != null)
						{
							return owner.ImagesMedium.get_Images().get_Item(int_12);
						}
						if (barImageSize.ImageSize == eBarImageSize.Large && owner.ImagesLarge != null)
						{
							return owner.ImagesLarge.get_Images().get_Item(int_12);
						}
						if (owner.Images != null)
						{
							if (int_12 == int_11)
							{
								if (image_1 == null)
								{
									image_1 = owner.Images.get_Images().get_Item(int_12);
								}
								return image_1;
							}
							return owner.Images.get_Images().get_Item(int_12);
						}
					}
					else if (m_Parent is SideBarPanelItem && ((SideBarPanelItem)m_Parent).ItemImageSize != 0)
					{
						eBarImageSize itemImageSize = ((SideBarPanelItem)m_Parent).ItemImageSize;
						if (itemImageSize == eBarImageSize.Medium && owner.ImagesMedium != null)
						{
							return owner.ImagesMedium.get_Images().get_Item(int_12);
						}
						if (itemImageSize == eBarImageSize.Large && owner.ImagesLarge != null)
						{
							return owner.ImagesLarge.get_Images().get_Item(int_12);
						}
						if (owner.Images != null)
						{
							return owner.Images.get_Images().get_Item(int_12);
						}
					}
					else if (owner.Images != null)
					{
						if (int_12 == int_11)
						{
							if (image_1 == null)
							{
								image_1 = owner.Images.get_Images().get_Item(int_12);
							}
							return image_1;
						}
						return owner.Images.get_Images().get_Item(int_12);
					}
				}
				catch (Exception)
				{
					return null;
				}
			}
		}
		return null;
	}

	protected override void OnCommandChanged()
	{
		if (!DesignMode && base.Command == null)
		{
			Text = "";
		}
		base.OnCommandChanged();
	}

	protected override void TextMarkupLinkClick(object sender, EventArgs e)
	{
		if (sender is Class262 @class)
		{
			OnMarkupLinkClick(new MarkupLinkClickEventArgs(@class.String_1, @class.String_0));
		}
		base.TextMarkupLinkClick(sender, e);
	}

	protected virtual void OnMarkupLinkClick(MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, e);
		}
	}
}
