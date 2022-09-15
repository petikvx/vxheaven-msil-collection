using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(SimpleItemDesigner))]
[ToolboxItem(false)]
public class ProgressBarItem : ImageItem, IPersonalizedMenuItem
{
	private class Class218
	{
		public ElementStyle elementStyle_0;

		public Color color_0 = Color.Empty;

		public Color color_1 = Color.Empty;

		public int int_0;

		public Class218()
		{
		}

		public Class218(ElementStyle style, Color chunkColor, Color chunkColor2, int chunkGradientAngle)
		{
			elementStyle_0 = style;
			color_0 = chunkColor;
			color_1 = chunkColor2;
			int_0 = chunkGradientAngle;
		}
	}

	private eMenuVisibility eMenuVisibility_0;

	private bool bool_22;

	private int int_4 = 100;

	private int int_5;

	private int int_6;

	private int int_7 = 1;

	private bool bool_23;

	private EventHandler eventHandler_14;

	private int int_8 = 96;

	private int int_9;

	private ElementStyle elementStyle_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private float float_0;

	private eProgressItemType eProgressItemType_0;

	private int int_10 = 100;

	private int int_11;

	private eProgressBarItemColor eProgressBarItemColor_0;

	private ElementStyle elementStyle_1;

	private Timer timer_0;

	[Browsable(false)]
	[Description("Gets or sets the background style.")]
	[Obsolete("BackgroundStyle property is replaced with the BackStyle property")]
	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ItemStyle BackgroundStyle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets bar background style.")]
	public ElementStyle BackStyle
	{
		get
		{
			return elementStyle_0;
		}
		set
		{
			if (value == null)
			{
				throw new InvalidOperationException("Null is not valid value for this property.");
			}
			elementStyle_0 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(100)]
	[Description("Gets or sets the maximum value of the range of the control.")]
	public int Maximum
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			Refresh();
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets the minimum value of the range of the control.")]
	[Browsable(true)]
	[DefaultValue(0)]
	[Category("Behavior")]
	public int Minimum
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			Refresh();
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Gets or sets the current position of the progress bar.")]
	[DefaultValue(0)]
	[Browsable(true)]
	public int Value
	{
		get
		{
			return int_6;
		}
		set
		{
			int int_ = int_6;
			if (value < int_5)
			{
				int_6 = int_5;
			}
			else if (value > int_4)
			{
				int_6 = int_4;
			}
			else
			{
				int_6 = value;
			}
			if (eventHandler_14 != null)
			{
				eventHandler_14(this, new EventArgs());
			}
			if (method_21(int_, int_6))
			{
				Refresh();
				OnAppearanceChanged();
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					val.Update();
				}
			}
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the amount by which a call to the PerformStep method increases the current position of the progress bar.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[DefaultValue(1)]
	public int Step
	{
		get
		{
			return int_7;
		}
		set
		{
			int_7 = value;
		}
	}

	[DefaultValue(false)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Gets or sets whether the text inside the progress bar is displayed.")]
	[DevCoBrowsable(true)]
	public bool TextVisible
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
			Refresh();
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("Indicates the width of the label in pixels.")]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(96)]
	public int Width
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

	[Category("Layout")]
	[Browsable(true)]
	[Description("Indicates height of the label in pixels.")]
	[DefaultValue(0)]
	[DevCoBrowsable(true)]
	public int Height
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
				Refresh();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Gets or sets the color of the progress chunk.")]
	[DevCoBrowsable(true)]
	public Color ChunkColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Gets or sets the target gradient color of the progress chunk.")]
	public Color ChunkColor2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			OnAppearanceChanged();
			Refresh();
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	[Description("Gets or sets the gradient angle of the progress chunk.")]
	[Browsable(true)]
	public float ChunkGradientAngle
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
			if (!color_1.IsEmpty)
			{
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates item's visiblity when on pop-up menu.")]
	[DevCoBrowsable(true)]
	public eMenuVisibility MenuVisibility
	{
		get
		{
			return eMenuVisibility_0;
		}
		set
		{
			if (eMenuVisibility_0 != value)
			{
				eMenuVisibility_0 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "MenuVisibility");
				}
			}
		}
	}

	[Browsable(false)]
	public bool RecentlyUsed
	{
		get
		{
			return bool_22;
		}
		set
		{
			if (bool_22 != value)
			{
				bool_22 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "RecentlyUsed");
				}
			}
		}
	}

	[Category("Behavior")]
	[Description("Indicates type of progress bar used to indicate progress.")]
	[DefaultValue(eProgressItemType.Standard)]
	[Browsable(true)]
	public eProgressItemType ProgressType
	{
		get
		{
			return eProgressItemType_0;
		}
		set
		{
			eProgressItemType_0 = value;
			method_22();
		}
	}

	internal int Int32_1 => int_11;

	[Browsable(true)]
	[DefaultValue(100)]
	[Description("Indicates marquee animation speed in milliseconds.")]
	[Category("Behavior")]
	public int MarqueeAnimationSpeed
	{
		get
		{
			return int_10;
		}
		set
		{
			int_10 = value;
			method_22();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(false)]
	[DefaultValue(eProgressBarItemColor.Normal)]
	[Description("Indicates predefined color of item when Office 2007 style is used.")]
	public eProgressBarItemColor ColorTable
	{
		get
		{
			return eProgressBarItemColor_0;
		}
		set
		{
			if (eProgressBarItemColor_0 != value)
			{
				eProgressBarItemColor_0 = value;
				Refresh();
			}
		}
	}

	public event EventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_14 = (EventHandler)Delegate.Combine(eventHandler_14, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_14 = (EventHandler)Delegate.Remove(eventHandler_14, value);
		}
	}

	public ProgressBarItem()
		: this("", "")
	{
	}

	public ProgressBarItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public ProgressBarItem(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		ResetBackgroundStyle();
	}

	public override BaseItem Copy()
	{
		ProgressBarItem progressBarItem = new ProgressBarItem(m_Name);
		CopyToItem(progressBarItem);
		return progressBarItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		ProgressBarItem progressBarItem = copy as ProgressBarItem;
		base.CopyToItem(progressBarItem);
		progressBarItem.Minimum = Minimum;
		progressBarItem.Maximum = Maximum;
		progressBarItem.Step = Step;
		progressBarItem.TextVisible = TextVisible;
		progressBarItem.Width = Width;
		progressBarItem.Style = Style;
		progressBarItem.Value = Value;
	}

	private Brush method_17(Rectangle rectangle_0, Class218 class218_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (class218_0.color_1.IsEmpty)
		{
			return (Brush)new SolidBrush(class218_0.color_0);
		}
		return (Brush)(object)Class50.smethod_0(rectangle_0, class218_0.color_0, class218_0.color_1, class218_0.int_0);
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		if (SuspendLayout || (base.Boolean_2 && method_18(pa)))
		{
			return;
		}
		Class218 @class = method_19();
		@class.elementStyle_0.method_4(pa.Colors);
		Graphics graphics = pa.Graphics;
		Font font = GetFont();
		if (Style == eDotNetBarStyle.Office2007)
		{
			pa.BaseRenderer_0?.DrawProgressBarItem(new ProgressBarItemRenderEventArgs(pa.Graphics, this, pa.Font, pa.RightToLeft));
		}
		else
		{
			Rectangle rect = m_Rect;
			ElementStyleDisplay.Paint(new ElementStyleDisplayInfo(@class.elementStyle_0, graphics, rect));
			rect.Inflate(-Class52.smethod_1(@class.elementStyle_0), -Class52.smethod_2(@class.elementStyle_0));
			switch (Style)
			{
			case eDotNetBarStyle.OfficeXP:
			{
				Rectangle rectangle_ = rect;
				int num6 = (int)Math.Floor((float)rect.Height * 0.65f);
				if (num6 <= 0)
				{
					num6 = 2;
				}
				int num7 = (int)Math.Ceiling((double)rect.Width / (double)(num6 + 2));
				Region clip2 = graphics.get_Clip();
				graphics.SetClip(rect, (CombineMode)1);
				int num8 = (int)((float)num7 * ((float)(int_6 - int_5) / (float)(int_4 - int_5)));
				int num9 = rect.X;
				if (eProgressItemType_0 == eProgressItemType.Marquee)
				{
					num8 = 5;
					num9 += rect.Width * int_11 / 100 - (int)((double)(num6 * 5) * 0.65);
				}
				Brush val3 = method_17(rectangle_, @class);
				try
				{
					int num10 = num9;
					for (int j = 0; j < num8; j++)
					{
						graphics.FillRectangle(val3, num10, rect.Y, num6, rect.Height);
						num10 += num6 + 2;
						if (eProgressItemType_0 == eProgressItemType.Marquee && num10 > rect.Right)
						{
							num10 = rect.X;
						}
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
				graphics.set_Clip(clip2);
				break;
			}
			case eDotNetBarStyle.Office2000:
			{
				Region clip3 = graphics.get_Clip();
				graphics.SetClip(rect, (CombineMode)1);
				Rectangle rectangle_2 = rect;
				if (eProgressItemType_0 == eProgressItemType.Marquee)
				{
					rect.Width = (int)((double)rect.Width * 0.29);
					rect.X += rectangle_2.Width * int_11 / 100 - rect.Width / 2;
				}
				else
				{
					rect.Width = (int)((float)rect.Width * ((float)(int_6 - int_5) / (float)(int_4 - int_5)));
				}
				Brush val4 = method_17(rectangle_2, @class);
				try
				{
					graphics.FillRectangle(val4, rect);
					if (eProgressItemType_0 == eProgressItemType.Marquee && rect.Right > rectangle_2.Right + 4)
					{
						rect = new Rectangle(rectangle_2.X, rectangle_2.Y, rect.Right - rectangle_2.Right - 4, rectangle_2.Height);
						graphics.FillRectangle(val4, rect);
					}
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				graphics.set_Clip(clip3);
				break;
			}
			case eDotNetBarStyle.Office2003:
			case eDotNetBarStyle.VS2005:
			{
				int num = (int)Math.Floor((float)rect.Height * 0.65f);
				if (num <= 0)
				{
					num = 2;
				}
				int num2 = (int)Math.Ceiling((double)rect.Width / (double)(num + 2));
				Region clip = graphics.get_Clip();
				graphics.SetClip(rect, (CombineMode)1);
				int num3 = (int)((float)num2 * ((float)(int_6 - int_5) / (float)(int_4 - int_5)));
				int num4 = rect.X;
				if (eProgressItemType_0 == eProgressItemType.Marquee)
				{
					num3 = 5;
					num4 += rect.Width * int_11 / 100 - (int)((double)(num * 5) * 0.65);
				}
				Brush val = null;
				if (@class.color_1.IsEmpty)
				{
					val = (Brush)new SolidBrush(@class.color_0);
				}
				else
				{
					LinearGradientBrush val2 = Class50.smethod_0(new Rectangle(0, 0, num, rect.Height), @class.color_0, @class.color_1, @class.int_0);
					val2.SetBlendTriangularShape(0.1f);
					val = (Brush)(object)val2;
				}
				try
				{
					int num5 = num4;
					for (int i = 0; i < num3; i++)
					{
						graphics.FillRectangle(val, num5, rect.Y, num, rect.Height);
						num5 += num + 2;
						if (eProgressItemType_0 == eProgressItemType.Marquee && num5 > rect.Right)
						{
							num5 = rect.X;
						}
					}
				}
				finally
				{
					val.Dispose();
				}
				graphics.set_Clip(clip);
				break;
			}
			}
		}
		if (bool_23)
		{
			ElementStyleDisplay.PaintText(new ElementStyleDisplayInfo(@class.elementStyle_0, graphics, m_Rect), m_Text, font);
		}
		if (DesignMode && Focused)
		{
			Rectangle rect2 = m_Rect;
			rect2.Inflate(-1, -1);
			Class32.smethod_0(graphics, rect2, pa.Colors.ItemDesignTimeBorder);
		}
	}

	private bool method_18(ItemPaintArgs itemPaintArgs_0)
	{
		if (SuspendLayout)
		{
			return true;
		}
		if (m_NeedRecalcSize)
		{
			RecalcSize();
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		Class64 class64_ = itemPaintArgs_0.Class64_0;
		if (class64_ == null)
		{
			return false;
		}
		Class141 class141_ = Class141.class141_0;
		Rectangle rect = m_Rect;
		rect.Inflate(-1, -1);
		class64_.method_0(graphics, class141_, Class166.class166_0, rect);
		class141_ = Class141.class141_2;
		rect.Width = (int)((float)rect.Width * ((float)(int_6 - int_5) / (float)(int_4 - int_5)));
		if (rect.Width > 5)
		{
			rect.Inflate(-4, -4);
			class64_.method_0(graphics, class141_, Class166.class166_0, rect);
		}
		if (DesignMode && Focused)
		{
			rect = m_Rect;
			rect.Inflate(-1, -1);
			Class32.smethod_0(graphics, rect, itemPaintArgs_0.Colors.ItemDesignTimeBorder);
		}
		return true;
	}

	protected virtual Font GetFont()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null)
		{
			return val.get_Font();
		}
		return SystemInformation.get_MenuFont();
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		int num = int_9;
		int num2 = int_8;
		if ((int_8 != 0 && int_9 != 0) || !bool_23)
		{
			num = ((int_9 != 0) ? int_9 : ImageSize.Height);
			num2 = ((int_8 != 0) ? int_8 : 96);
		}
		else
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (!BaseItem.IsHandleValid(val))
			{
				return;
			}
			Graphics val2 = Class109.smethod_68(val);
			try
			{
				ElementStyle elementStyle = method_20();
				Font font = GetFont();
				Size empty = Size.Empty;
				eTextFormat eTextFormat_ = elementStyle.ETextFormat_0;
				if (m_Text != "")
				{
					empty = Class55.smethod_4(val2, m_Text, font, 0, eTextFormat_);
					empty.Width += 4;
				}
				else
				{
					empty = Class55.smethod_4(val2, " ", font, 0, eTextFormat_);
					empty.Width += 4;
				}
				if (elementStyle.Border != 0)
				{
					empty.Width += 4;
				}
				empty.Height += 6;
				if (int_8 == 0)
				{
					num2 = empty.Width;
				}
				if (int_9 == 0)
				{
					num = empty.Height;
				}
			}
			finally
			{
				val2.set_TextRenderingHint((TextRenderingHint)0);
				val2.set_SmoothingMode((SmoothingMode)0);
				val2.Dispose();
			}
		}
		if (Orientation == eOrientation.Horizontal)
		{
			HeightInternal = num;
			WidthInternal = num2;
		}
		else
		{
			HeightInternal = num2;
			WidthInternal = num;
		}
		base.RecalcSize();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBackgroundStyle()
	{
		if (elementStyle_0 != null)
		{
			elementStyle_0.StyleChanged -= elementStyle_0_StyleChanged;
		}
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_0_StyleChanged;
		Refresh();
	}

	private void elementStyle_0_StyleChanged(object sender, EventArgs e)
	{
		OnAppearanceChanged();
	}

	private Class218 method_19()
	{
		ElementStyle elementStyle = null;
		Color empty = Color.Empty;
		Color empty2 = Color.Empty;
		int chunkGradientAngle = (int)float_0;
		elementStyle = ((!elementStyle_0.Custom) ? method_20() : elementStyle_0);
		if (!color_0.IsEmpty)
		{
			empty = color_0;
			empty2 = color_1;
		}
		else
		{
			switch (Style)
			{
			default:
			{
				ColorScheme colorScheme = GetColorScheme();
				chunkGradientAngle = 90;
				empty = colorScheme.ItemPressedBackground;
				empty2 = colorScheme.ItemPressedBackground2;
				break;
			}
			case eDotNetBarStyle.OfficeXP:
			case eDotNetBarStyle.Office2000:
				empty = SystemColors.Highlight;
				empty2 = Color.Empty;
				break;
			}
		}
		if (Orientation == eOrientation.Vertical)
		{
			elementStyle.EOrientation_0 = eOrientation.Vertical;
		}
		return new Class218(elementStyle, empty, empty2, chunkGradientAngle);
	}

	private ColorScheme GetColorScheme()
	{
		ColorScheme colorScheme = null;
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val is Bar)
		{
			colorScheme = ((Bar)(object)val).ColorScheme;
		}
		else if (val is MenuPanel)
		{
			colorScheme = ((MenuPanel)(object)val).ColorScheme;
		}
		else if (val is ItemControl)
		{
			colorScheme = ((ItemControl)(object)val).ColorScheme;
		}
		else if (val is BaseItemControl)
		{
			colorScheme = ((BaseItemControl)(object)val).ColorScheme;
		}
		if (colorScheme == null)
		{
			colorScheme = new ColorScheme(Style);
		}
		return colorScheme;
	}

	private ElementStyle method_20()
	{
		if (elementStyle_1 != null)
		{
			return elementStyle_1;
		}
		ElementStyle elementStyle = new ElementStyle();
		if (Style != eDotNetBarStyle.Office2000 && Style != 0)
		{
			if (Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
			{
				ColorScheme colorScheme = null;
				if (ContainerControl is Bar)
				{
					colorScheme = ((Bar)ContainerControl).ColorScheme;
				}
				else if (ContainerControl is MenuPanel)
				{
					colorScheme = ((MenuPanel)ContainerControl).ColorScheme;
				}
				if (colorScheme == null)
				{
					colorScheme = new ColorScheme(Style);
				}
				elementStyle.Border = eStyleBorderType.Solid;
				elementStyle.BorderWidth = 1;
				elementStyle.BorderColorSchemePart = eColorSchemePart.BarDockedBorder;
				elementStyle.BackColorSchemePart = eColorSchemePart.BarBackground;
				elementStyle.BackColor2SchemePart = eColorSchemePart.BarBackground2;
				elementStyle.BackColorGradientAngle = 90;
				elementStyle.TextColorSchemePart = eColorSchemePart.ItemPressedText;
			}
		}
		else
		{
			elementStyle.Border = eStyleBorderType.Solid;
			elementStyle.BorderWidth = 1;
			elementStyle.BorderColor = SystemColors.ControlDark;
			elementStyle.BackColor = SystemColors.Control;
			elementStyle.TextColor = SystemColors.ControlText;
		}
		elementStyle.TextLineAlignment = eStyleTextAlignment.Center;
		elementStyle.TextAlignment = eStyleTextAlignment.Center;
		elementStyle_1 = elementStyle;
		return elementStyle_1;
	}

	protected override void OnStyleChanged()
	{
		elementStyle_1 = null;
		base.OnStyleChanged();
	}

	private bool method_21(int int_12, int int_13)
	{
		int num = (int)((float)WidthInternal * ((float)int_12 / (float)(int_4 - int_5)));
		int num2 = (int)((float)WidthInternal * ((float)int_13 / (float)(int_4 - int_5)));
		return num != num2;
	}

	public void PerformStep()
	{
		Value += int_7;
	}

	public void Increment(int value)
	{
		Value += value;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeChunkColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetChunkColor()
	{
		color_0 = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeChunkColor2()
	{
		return !color_1.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetChunkColor2()
	{
		color_1 = Color.Empty;
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		int_8 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("width"));
		int_9 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("height"));
		int_6 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("value"));
		int_5 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("min"));
		int_4 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("max"));
		bool_23 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("textvisible"));
		int_7 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("step"));
		if (itemXmlElement.HasAttribute("chunkcolor"))
		{
			color_0 = Class109.smethod_51(itemXmlElement.GetAttribute("chunkcolor"));
		}
		if (itemXmlElement.HasAttribute("chunkcolor2"))
		{
			color_1 = Class109.smethod_51(itemXmlElement.GetAttribute("chunkcolor2"));
		}
		float_0 = XmlConvert.ToSingle(itemXmlElement.GetAttribute("chunkga"));
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			string name;
			if ((name = childNode.Name) != null && name == "backstyle2")
			{
				ElementSerializer.Deserialize(elementStyle_0, childNode);
			}
		}
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("width", XmlConvert.ToString(int_8));
		itemXmlElement.SetAttribute("height", XmlConvert.ToString(int_9));
		itemXmlElement.SetAttribute("value", XmlConvert.ToString(int_6));
		itemXmlElement.SetAttribute("min", XmlConvert.ToString(int_5));
		itemXmlElement.SetAttribute("max", XmlConvert.ToString(int_4));
		itemXmlElement.SetAttribute("textvisible", XmlConvert.ToString(bool_23));
		itemXmlElement.SetAttribute("step", XmlConvert.ToString(int_7));
		if (!color_0.IsEmpty)
		{
			itemXmlElement.SetAttribute("chunkcolor", Class109.smethod_50(color_0));
		}
		if (!color_1.IsEmpty)
		{
			itemXmlElement.SetAttribute("chunkcolor2", Class109.smethod_50(color_1));
		}
		itemXmlElement.SetAttribute("chunkga", XmlConvert.ToString(float_0));
		if (elementStyle_0.Custom)
		{
			XmlElement xmlElement = itemXmlElement.OwnerDocument.CreateElement("backstyle2");
			itemXmlElement.AppendChild(xmlElement);
			ElementSerializer.Serialize(elementStyle_0, xmlElement);
		}
	}

	protected override void OnDesignModeChanged()
	{
		if (DesignMode && eProgressItemType_0 == eProgressItemType.Marquee)
		{
			method_23();
		}
		base.OnDesignModeChanged();
	}

	private void method_22()
	{
		if (!DesignMode)
		{
			method_23();
			if (eProgressItemType_0 == eProgressItemType.Marquee)
			{
				method_24();
			}
			OnAppearanceChanged();
			Refresh();
		}
	}

	protected internal override void OnVisibleChanged(bool newValue)
	{
		base.OnVisibleChanged(newValue);
		if (eProgressItemType_0 == eProgressItemType.Marquee && timer_0 != null)
		{
			if (newValue)
			{
				timer_0.Start();
			}
			else
			{
				timer_0.Stop();
			}
		}
	}

	public override void Dispose()
	{
		method_23();
		base.Dispose();
	}

	private void method_23()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	private void method_24()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (timer_0 != null)
		{
			method_23();
		}
		int_11 = 0;
		if (int_10 != 0)
		{
			timer_0 = new Timer();
			timer_0.set_Interval(int_10);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			if (Visible)
			{
				timer_0.Start();
			}
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		int_11 += 5;
		if (int_11 > 100)
		{
			int_11 = 0;
		}
		Refresh();
	}
}
