using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TabColorScheme
{
	private EventHandler eventHandler_0;

	private eTabStripStyle eTabStripStyle_0 = eTabStripStyle.OneNote;

	private Color color_0 = Color.Empty;

	private bool bool_0;

	private Color color_1 = Color.Empty;

	private bool bool_1;

	private int int_0 = 90;

	private Color color_2 = Color.Empty;

	private bool bool_2;

	private Color color_3 = Color.Empty;

	private bool bool_3;

	private Color color_4 = Color.Empty;

	private bool bool_4;

	private int int_1 = 90;

	private Color color_5 = Color.Empty;

	private bool bool_5;

	private Color color_6 = Color.Empty;

	private bool bool_6;

	private Color color_7 = Color.Empty;

	private bool bool_7;

	private Color color_8 = Color.Empty;

	private bool bool_8;

	private Color color_9 = Color.Empty;

	private bool bool_9;

	private Color color_10 = Color.Empty;

	private bool bool_10;

	private int int_2 = 90;

	private BackgroundColorBlendCollection backgroundColorBlendCollection_0 = new BackgroundColorBlendCollection();

	private Color color_11 = Color.Empty;

	private bool bool_11;

	private Color color_12 = Color.Empty;

	private bool bool_12;

	private Color color_13 = Color.Empty;

	private bool bool_13;

	private Color color_14 = Color.Empty;

	private bool bool_14;

	private Color color_15 = Color.Empty;

	private bool bool_15;

	private Color color_16 = Color.Empty;

	private bool bool_16;

	private int int_3 = 90;

	private BackgroundColorBlendCollection backgroundColorBlendCollection_1 = new BackgroundColorBlendCollection();

	private Color color_17 = Color.Empty;

	private bool bool_17;

	private Color color_18 = Color.Empty;

	private bool bool_18;

	private Color color_19 = Color.Empty;

	private bool bool_19;

	private Color color_20 = Color.Empty;

	private bool bool_20;

	private Color color_21 = Color.Empty;

	private bool bool_21;

	private Color color_22 = Color.Empty;

	private bool bool_22;

	private int int_4 = 90;

	private BackgroundColorBlendCollection backgroundColorBlendCollection_2 = new BackgroundColorBlendCollection();

	private Color color_23 = Color.Empty;

	private bool bool_23;

	private Color color_24 = Color.Empty;

	private bool bool_24;

	private Color color_25 = Color.Empty;

	private bool bool_25;

	private bool bool_26;

	private bool bool_27;

	[Description("Indicates style that color scheme represents.")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Category("Appearance")]
	[DefaultValue(eTabStripStyle.OneNote)]
	public eTabStripStyle Style
	{
		get
		{
			return eTabStripStyle_0;
		}
		set
		{
			if (eTabStripStyle_0 != value)
			{
				eTabStripStyle_0 = value;
				Refresh();
			}
		}
	}

	internal bool Boolean_0
	{
		get
		{
			return bool_26;
		}
		set
		{
			bool_26 = value;
			Refresh();
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	public bool SchemeChanged
	{
		get
		{
			if (!bool_1 && !bool_0 && !bool_2 && !bool_10 && !bool_9 && !bool_6 && !bool_8 && !bool_7 && !bool_11 && !bool_16 && !bool_15 && !bool_12 && !bool_14 && !bool_13 && !bool_17 && !bool_22 && !bool_21 && !bool_18 && !bool_20 && !bool_19 && !bool_23 && !bool_24 && !bool_25)
			{
				return bool_27;
			}
			return true;
		}
	}

	[Description("Specifies the background color of the tab control.")]
	[Browsable(true)]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	public Color TabBackground
	{
		get
		{
			return color_0;
		}
		set
		{
			if (color_0 != value)
			{
				color_0 = value;
				bool_0 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the target gradient background color of the tab control.")]
	[DevCoBrowsable(true)]
	[Category("Tab Control Colors")]
	[Browsable(true)]
	public Color TabBackground2
	{
		get
		{
			return color_1;
		}
		set
		{
			if (color_1 != value)
			{
				color_1 = value;
				bool_1 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the gradient angle.")]
	[Category("Tab Control Colors")]
	[DefaultValue(90)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public int TabBackgroundGradientAngle
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			InvokeColorChanged();
			bool_27 = true;
		}
	}

	[Category("Tab Control Colors")]
	[Description("Specifies the border color of the tab control.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color TabBorder
	{
		get
		{
			return color_2;
		}
		set
		{
			if (color_2 != value)
			{
				color_2 = value;
				bool_2 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the background color of the tab panel.")]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color TabPanelBackground
	{
		get
		{
			return color_3;
		}
		set
		{
			if (color_3 != value)
			{
				color_3 = value;
				bool_3 = true;
				InvokeColorChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Tab Control Colors")]
	[Description("Specifies the target gradient background color of the tab panel.")]
	[Browsable(true)]
	public Color TabPanelBackground2
	{
		get
		{
			return color_4;
		}
		set
		{
			if (color_4 != value)
			{
				color_4 = value;
				bool_4 = true;
				InvokeColorChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(90)]
	[Category("Tab Control Colors")]
	[Description("Specifies the gradient angle.")]
	public int TabPanelBackgroundGradientAngle
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			InvokeColorChanged();
			bool_27 = true;
		}
	}

	[Category("Tab Control Colors")]
	[Description("Specifies the border color of the tab panel.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color TabPanelBorder
	{
		get
		{
			return color_5;
		}
		set
		{
			if (color_5 != value)
			{
				color_5 = value;
				bool_5 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies the border color of the tab item.")]
	[Category("Tab Control Colors")]
	public Color TabItemBorder
	{
		get
		{
			return color_6;
		}
		set
		{
			if (color_6 != value)
			{
				color_6 = value;
				bool_6 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the light border color of the tab item.")]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color TabItemBorderLight
	{
		get
		{
			return color_7;
		}
		set
		{
			if (color_7 != value)
			{
				color_7 = value;
				bool_7 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[Description("Specifies the dark border color of the tab item.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color TabItemBorderDark
	{
		get
		{
			return color_8;
		}
		set
		{
			if (color_8 != value)
			{
				color_8 = value;
				bool_8 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Description("Specifies the background color of the tab item.")]
	public Color TabItemBackground
	{
		get
		{
			return color_9;
		}
		set
		{
			if (color_9 != value)
			{
				color_9 = value;
				bool_9 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies the target gradient background color of the tab item.")]
	[DevCoBrowsable(true)]
	[Category("Tab Control Colors")]
	public Color TabItemBackground2
	{
		get
		{
			return color_10;
		}
		set
		{
			if (color_10 != value)
			{
				color_10 = value;
				bool_10 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Description("Specifies the gradient angle.")]
	[DefaultValue(90)]
	public int TabItemBackgroundGradientAngle
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			InvokeColorChanged();
			bool_27 = true;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Description("Collection that defines the multicolor gradient background.")]
	public BackgroundColorBlendCollection TabItemBackgroundColorBlend => backgroundColorBlendCollection_0;

	[Category("Tab Control Colors")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifies the text of the tab item.")]
	public Color TabItemText
	{
		get
		{
			return color_11;
		}
		set
		{
			if (color_11 != value)
			{
				color_11 = value;
				bool_11 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Description("Specifies the border color of the tab item when mouse is over it.")]
	[Browsable(true)]
	public Color TabItemHotBorder
	{
		get
		{
			return color_12;
		}
		set
		{
			if (color_12 != value)
			{
				color_12 = value;
				bool_12 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the light border color of the tab item when mouse is over it.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Tab Control Colors")]
	public Color TabItemHotBorderLight
	{
		get
		{
			return color_13;
		}
		set
		{
			if (color_13 != value)
			{
				color_13 = value;
				bool_13 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies the dark border color of the tab item when mouse is over it.")]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	public Color TabItemHotBorderDark
	{
		get
		{
			return color_14;
		}
		set
		{
			if (color_14 != value)
			{
				color_14 = value;
				bool_14 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Description("Specifies the background color of the tab item when mouse is over it.")]
	public Color TabItemHotBackground
	{
		get
		{
			return color_15;
		}
		set
		{
			if (color_15 != value)
			{
				color_15 = value;
				bool_15 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the target gradient background color of the tab item when mouse is over it.")]
	[Browsable(true)]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	public Color TabItemHotBackground2
	{
		get
		{
			return color_16;
		}
		set
		{
			if (color_16 != value)
			{
				color_16 = value;
				bool_16 = true;
				InvokeColorChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(90)]
	[Description("Specifies the gradient angle.")]
	[Category("Tab Control Colors")]
	public int TabItemHotBackgroundGradientAngle
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			InvokeColorChanged();
			bool_27 = true;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	[Description("Collection that defines the multicolor gradient background.")]
	public BackgroundColorBlendCollection TabItemHotBackgroundColorBlend => backgroundColorBlendCollection_1;

	[Description("Specifies the text color of the tab item when mouse is over it.")]
	[Browsable(true)]
	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	public Color TabItemHotText
	{
		get
		{
			return color_17;
		}
		set
		{
			if (color_17 != value)
			{
				color_17 = value;
				bool_17 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[Browsable(true)]
	[Description("Specifies the border color of the tab item when selected.")]
	[DevCoBrowsable(true)]
	public Color TabItemSelectedBorder
	{
		get
		{
			return color_18;
		}
		set
		{
			if (color_18 != value)
			{
				color_18 = value;
				bool_18 = true;
				InvokeColorChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the light border color of the tab item when selected.")]
	[Category("Tab Control Colors")]
	public Color TabItemSelectedBorderLight
	{
		get
		{
			return color_19;
		}
		set
		{
			if (color_19 != value)
			{
				color_19 = value;
				bool_19 = true;
				InvokeColorChanged();
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies the dark border color of the tab item when selected.")]
	[DevCoBrowsable(true)]
	[Category("Tab Control Colors")]
	public Color TabItemSelectedBorderDark
	{
		get
		{
			return color_20;
		}
		set
		{
			if (color_20 != value)
			{
				color_20 = value;
				bool_20 = true;
				InvokeColorChanged();
			}
		}
	}

	[Description("Specifies the background color of the tab item when selected.")]
	[Category("Tab Control Colors")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color TabItemSelectedBackground
	{
		get
		{
			return color_21;
		}
		set
		{
			if (color_21 != value)
			{
				color_21 = value;
				bool_21 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[Description("Specifies the target gradient background color of the tab item when selected.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color TabItemSelectedBackground2
	{
		get
		{
			return color_22;
		}
		set
		{
			if (color_22 != value)
			{
				color_22 = value;
				bool_22 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[DefaultValue(90)]
	[Description("Specifies the gradient angle.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public int TabItemSelectedBackgroundGradientAngle
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			InvokeColorChanged();
			bool_27 = true;
		}
	}

	[Browsable(true)]
	[Description("Collection that defines the multicolor gradient background.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public BackgroundColorBlendCollection TabItemSelectedBackgroundColorBlend => backgroundColorBlendCollection_2;

	[DevCoBrowsable(true)]
	[Category("Tab Control Colors")]
	[Description("Specifies the text color of the tab item when selected.")]
	[Browsable(true)]
	public Color TabItemSelectedText
	{
		get
		{
			return color_23;
		}
		set
		{
			if (color_23 != value)
			{
				color_23 = value;
				bool_23 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the tab item separator color.")]
	public Color TabItemSeparator
	{
		get
		{
			return color_24;
		}
		set
		{
			if (color_24 != value)
			{
				color_24 = value;
				bool_24 = true;
				InvokeColorChanged();
			}
		}
	}

	[Category("Tab Control Colors")]
	[Description("Specifies the tab item separator shadow color.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color TabItemSeparatorShade
	{
		get
		{
			return color_25;
		}
		set
		{
			if (color_25 != value)
			{
				color_25 = value;
				bool_25 = true;
				InvokeColorChanged();
			}
		}
	}

	public event EventHandler ColorChanged
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

	public TabColorScheme()
	{
		Refresh();
	}

	public TabColorScheme(eTabStripStyle style)
	{
		eTabStripStyle_0 = style;
		Refresh();
	}

	public void Refresh()
	{
		if (bool_26)
		{
			method_5();
			return;
		}
		switch (eTabStripStyle_0)
		{
		case eTabStripStyle.Flat:
			method_1();
			break;
		case eTabStripStyle.Office2003:
			method_3();
			break;
		default:
			method_6();
			break;
		case eTabStripStyle.VS2005:
			method_7(bool_28: false);
			break;
		case eTabStripStyle.RoundHeader:
			method_8();
			break;
		case eTabStripStyle.VS2005Dock:
			method_7(bool_28: true);
			break;
		case eTabStripStyle.VS2005Document:
			method_4();
			break;
		case eTabStripStyle.SimulatedTheme:
			method_7(bool_28: true);
			method_0();
			break;
		case eTabStripStyle.Office2007Document:
		case eTabStripStyle.Office2007Dock:
			method_10();
			break;
		}
		if (!bool_11 && !color_9.IsEmpty && (double)Math.Abs(color_11.GetBrightness() - color_9.GetBrightness()) <= 0.2)
		{
			color_11 = (((double)color_11.GetBrightness() < 0.5) ? ControlPaint.Light(color_11) : ControlPaint.Dark(color_11));
		}
		if (!bool_23 && !color_21.IsEmpty && (double)Math.Abs(color_23.GetBrightness() - color_21.GetBrightness()) <= 0.2)
		{
			color_23 = (((double)color_23.GetBrightness() < 0.5) ? ControlPaint.Light(color_23) : ControlPaint.Dark(color_23));
		}
	}

	private void method_0()
	{
		if (Class109.Enum19_0 == Enum19.const_0)
		{
			if (!bool_20)
			{
				color_20 = SystemColors.Highlight;
			}
			if (!bool_19)
			{
				color_19 = Color.FromArgb(128, SystemColors.Highlight);
			}
		}
		else
		{
			if (!bool_20)
			{
				color_20 = method_9("E68B2C");
			}
			if (!bool_19)
			{
				color_19 = method_9("FFC73C");
			}
		}
		if (!bool_14)
		{
			color_14 = color_20;
		}
		if (!bool_13)
		{
			color_13 = color_19;
		}
		if (!bool_12)
		{
			color_12 = color_6;
		}
		if (!bool_7)
		{
			color_7 = SystemColors.ControlLightLight;
		}
		if (!bool_8)
		{
			color_8 = SystemColors.Control;
		}
	}

	private void method_1()
	{
		if (!bool_24)
		{
			color_24 = SystemColors.ControlDark;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = method_2();
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_2)
		{
			color_2 = SystemColors.ControlDark;
		}
		if (!bool_6)
		{
			color_6 = Color.Empty;
		}
		if (!bool_7)
		{
			color_7 = Color.Empty;
		}
		if (!bool_8)
		{
			color_8 = Color.Empty;
		}
		if (!bool_9)
		{
			color_9 = Color.Empty;
		}
		if (!bool_10)
		{
			color_10 = Color.Empty;
		}
		if (!bool_11)
		{
			color_11 = SystemColors.ControlDark;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_13)
		{
			color_13 = Color.Empty;
		}
		if (!bool_14)
		{
			color_14 = Color.Empty;
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = Color.Empty;
		}
		if (!bool_18)
		{
			color_18 = SystemColors.ControlText;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlLightLight;
		}
		if (!bool_20)
		{
			color_20 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = SystemColors.Control;
		}
		if (!bool_22)
		{
			color_22 = Color.Empty;
		}
		if (!bool_23)
		{
			color_23 = SystemColors.ControlText;
		}
		if (!bool_3)
		{
			color_3 = color_21;
		}
		if (!bool_4)
		{
			color_4 = Color.Empty;
		}
		if (!bool_5)
		{
			color_5 = SystemColors.ControlDark;
		}
	}

	private Color method_2()
	{
		Color result = ControlPaint.Light(SystemColors.Control);
		switch (Class109.Enum19_0)
		{
		case Enum19.const_1:
			result = Color.FromArgb(255, 251, 233);
			break;
		case Enum19.const_2:
			result = Color.FromArgb(255, 251, 233);
			break;
		case Enum19.const_3:
			result = Color.FromArgb(251, 250, 255);
			break;
		}
		return result;
	}

	private void method_3()
	{
		ColorScheme colorScheme = new ColorScheme();
		colorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.Office2003;
		if (!bool_24)
		{
			color_24 = colorScheme.ItemSeparator;
		}
		if (!bool_25)
		{
			color_25 = colorScheme.ItemSeparatorShade;
		}
		if (!bool_0)
		{
			color_0 = colorScheme.BarBackground;
		}
		if (!bool_1)
		{
			color_1 = colorScheme.BarBackground2;
		}
		if (!bool_2)
		{
			color_2 = Color.Empty;
		}
		if (!bool_6)
		{
			color_6 = Color.Empty;
		}
		if (!bool_7)
		{
			color_7 = Color.Empty;
		}
		if (!bool_8)
		{
			color_8 = Color.Empty;
		}
		if (!bool_9)
		{
			color_9 = Color.Empty;
		}
		if (!bool_10)
		{
			color_10 = Color.Empty;
		}
		if (!bool_11)
		{
			color_11 = SystemColors.ControlText;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_13)
		{
			color_13 = Color.Empty;
		}
		if (!bool_14)
		{
			color_14 = Color.Empty;
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = Color.Empty;
		}
		if (!bool_18)
		{
			color_18 = colorScheme.ItemPressedBorder;
		}
		if (!bool_19)
		{
			color_19 = colorScheme.ItemPressedBorder;
		}
		if (!bool_20)
		{
			color_20 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = colorScheme.ItemPressedBackground;
		}
		if (!bool_22)
		{
			color_22 = colorScheme.ItemPressedBackground2;
		}
		if (!bool_23)
		{
			color_23 = colorScheme.ItemPressedText;
		}
		if (!bool_3)
		{
			color_3 = color_1;
		}
		if (!bool_4)
		{
			color_4 = color_0;
		}
		if (!bool_5)
		{
			color_5 = color_18;
		}
	}

	private void method_4()
	{
		ColorScheme colorScheme = new ColorScheme();
		colorScheme.EDotNetBarStyle_0 = eDotNetBarStyle.VS2005;
		if (!bool_24)
		{
			color_24 = colorScheme.ItemSeparator;
		}
		if (!bool_25)
		{
			color_25 = colorScheme.ItemSeparatorShade;
		}
		if (!bool_0)
		{
			color_0 = colorScheme.BarBackground;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_2)
		{
			color_2 = Color.Empty;
		}
		if (!bool_6)
		{
			color_6 = method_9("ACA899");
		}
		if (!bool_7)
		{
			color_7 = Color.White;
		}
		if (!bool_8)
		{
			color_8 = method_9("ECE9D8");
		}
		if (!bool_9)
		{
			color_9 = method_9("FDFCFB");
		}
		if (!bool_10)
		{
			color_10 = method_9("F1EFE2");
		}
		if (!bool_11)
		{
			color_11 = SystemColors.ControlText;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_13)
		{
			color_13 = Color.Empty;
		}
		if (!bool_14)
		{
			color_14 = Color.Empty;
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = Color.Empty;
		}
		if (!bool_18)
		{
			color_18 = method_9("7F9DB9");
		}
		if (!bool_19)
		{
			color_19 = Color.Empty;
		}
		if (!bool_20)
		{
			color_20 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = Color.White;
		}
		if (!bool_22)
		{
			color_22 = Color.Empty;
		}
		if (!bool_23)
		{
			color_23 = SystemColors.ControlText;
		}
		if (!bool_3)
		{
			color_3 = color_1;
		}
		if (!bool_4)
		{
			color_4 = color_0;
		}
		if (!bool_5)
		{
			color_5 = color_18;
		}
	}

	private void method_5()
	{
		if (!bool_24)
		{
			color_24 = SystemColors.ControlDark;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = Color.Empty;
		}
		if (!bool_1)
		{
			color_1 = Color.Empty;
		}
		if (!bool_2)
		{
			color_2 = Color.Empty;
		}
		if (!bool_6)
		{
			color_6 = Color.Empty;
		}
		if (!bool_7)
		{
			color_7 = Color.Empty;
		}
		if (!bool_8)
		{
			color_8 = Color.Empty;
		}
		if (!bool_9)
		{
			color_9 = Color.Empty;
		}
		if (!bool_10)
		{
			color_10 = Color.Empty;
		}
		if (!bool_11)
		{
			color_11 = SystemColors.ControlText;
		}
		if (!bool_3)
		{
			color_3 = SystemColors.Control;
		}
		if (!bool_4)
		{
			color_4 = Color.Empty;
		}
		if (!bool_5)
		{
			color_5 = Color.Empty;
		}
		if (!bool_12)
		{
			color_12 = Color.Empty;
		}
		if (!bool_13)
		{
			color_13 = Color.Empty;
		}
		if (!bool_14)
		{
			color_14 = Color.Empty;
		}
		if (!bool_15)
		{
			color_15 = Color.Empty;
		}
		if (!bool_16)
		{
			color_16 = Color.Empty;
		}
		if (!bool_17)
		{
			color_17 = Color.Empty;
		}
		if (!bool_18)
		{
			color_18 = SystemColors.ControlText;
		}
		if (!bool_19)
		{
			color_19 = SystemColors.ControlLightLight;
		}
		if (!bool_20)
		{
			color_20 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = SystemColors.Control;
		}
		if (!bool_22)
		{
			color_22 = Color.Empty;
		}
		if (!bool_23)
		{
			color_23 = SystemColors.ControlText;
		}
	}

	private void method_6()
	{
		Enum19 enum19_ = Class109.Enum19_0;
		if (!bool_24)
		{
			color_24 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		ColorScheme colorScheme = new ColorScheme(eDotNetBarStyle.Office2003);
		switch (enum19_)
		{
		default:
			if (!bool_0)
			{
				color_0 = colorScheme.BarBackground;
			}
			if (!bool_1)
			{
				color_1 = colorScheme.BarBackground2;
			}
			if (!bool_2)
			{
				color_2 = Color.Empty;
			}
			if (!bool_6)
			{
				color_6 = SystemColors.ControlDark;
			}
			if (!bool_7)
			{
				color_7 = Color.White;
			}
			if (!bool_8)
			{
				color_8 = SystemColors.ControlDarkDark;
			}
			if (!bool_9)
			{
				color_9 = color_1;
			}
			if (!bool_10)
			{
				color_10 = color_0;
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = color_1;
			}
			if (!bool_4)
			{
				color_4 = ControlPaint.LightLight(color_1);
			}
			if (!bool_5)
			{
				color_5 = Color.Empty;
			}
			if (!bool_12)
			{
				color_12 = colorScheme.BarDockedBorder;
			}
			if (!bool_13)
			{
				color_13 = colorScheme.BarDockedBorder;
			}
			if (!bool_14)
			{
				color_14 = colorScheme.BarDockedBorder;
			}
			if (!bool_15)
			{
				color_15 = colorScheme.ItemHotBackground;
			}
			if (!bool_16)
			{
				color_16 = colorScheme.ItemHotBackground2;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = SystemColors.ControlDark;
			}
			if (!bool_19)
			{
				color_19 = SystemColors.ControlLightLight;
			}
			if (!bool_20)
			{
				color_20 = color_19;
			}
			if (!bool_21)
			{
				color_21 = colorScheme.ItemPressedBackground2;
			}
			if (!bool_22)
			{
				color_22 = colorScheme.ItemPressedBackground;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_1:
			if (!bool_0)
			{
				color_0 = Color.FromArgb(196, 218, 250);
			}
			if (!bool_1)
			{
				color_1 = Color.FromArgb(253, 254, 255);
			}
			if (!bool_2)
			{
				color_2 = Color.Empty;
			}
			if (!bool_6)
			{
				color_6 = Color.FromArgb(0, 53, 154);
			}
			if (!bool_7)
			{
				color_7 = Color.White;
			}
			if (!bool_8)
			{
				color_8 = Color.FromArgb(117, 166, 241);
			}
			if (!bool_9)
			{
				color_9 = Color.FromArgb(236, 243, 252);
			}
			if (!bool_10)
			{
				color_10 = Color.FromArgb(191, 214, 246);
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = color_10;
			}
			if (!bool_4)
			{
				color_4 = Color.White;
			}
			if (!bool_5)
			{
				color_5 = Color.Empty;
			}
			if (!bool_12)
			{
				color_12 = Color.FromArgb(0, 0, 128);
			}
			if (!bool_13)
			{
				color_13 = Color.FromArgb(0, 0, 128);
			}
			if (!bool_14)
			{
				color_14 = Color.FromArgb(0, 0, 128);
			}
			if (!bool_15)
			{
				color_15 = Color.FromArgb(255, 249, 237);
			}
			if (!bool_16)
			{
				color_16 = Color.FromArgb(255, 240, 199);
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = colorScheme.BarDockedBorder;
			}
			if (!bool_19)
			{
				color_19 = Color.White;
			}
			if (!bool_20)
			{
				color_20 = color_19;
			}
			if (!bool_21)
			{
				color_21 = colorScheme.BarBackground;
			}
			if (!bool_22)
			{
				color_22 = colorScheme.BarBackground2;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_2:
			if (!bool_0)
			{
				color_0 = Color.FromArgb(242, 241, 228);
			}
			if (!bool_1)
			{
				color_1 = Color.FromArgb(230, 236, 209);
			}
			if (!bool_2)
			{
				color_2 = Color.Empty;
			}
			if (!bool_6)
			{
				color_6 = Color.FromArgb(96, 119, 107);
			}
			if (!bool_7)
			{
				color_7 = Color.White;
			}
			if (!bool_8)
			{
				color_8 = Color.FromArgb(176, 194, 140);
			}
			if (!bool_9)
			{
				color_9 = Color.FromArgb(244, 247, 236);
			}
			if (!bool_10)
			{
				color_10 = Color.FromArgb(221, 229, 192);
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = Color.FromArgb(221, 229, 192);
			}
			if (!bool_4)
			{
				color_4 = Color.White;
			}
			if (!bool_5)
			{
				color_5 = Color.Empty;
			}
			if (!bool_12)
			{
				color_12 = Color.FromArgb(63, 93, 56);
			}
			if (!bool_13)
			{
				color_13 = Color.FromArgb(63, 93, 56);
			}
			if (!bool_14)
			{
				color_14 = Color.FromArgb(63, 93, 56);
			}
			if (!bool_15)
			{
				color_15 = Color.FromArgb(255, 249, 237);
			}
			if (!bool_16)
			{
				color_16 = Color.FromArgb(255, 240, 199);
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = colorScheme.BarDockedBorder;
			}
			if (!bool_19)
			{
				color_19 = Color.White;
			}
			if (!bool_20)
			{
				color_20 = color_19;
			}
			if (!bool_21)
			{
				color_21 = colorScheme.BarBackground;
			}
			if (!bool_22)
			{
				color_22 = colorScheme.BarBackground;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_3:
			if (!bool_0)
			{
				color_0 = Color.FromArgb(243, 243, 247);
			}
			if (!bool_1)
			{
				color_1 = Color.FromArgb(226, 226, 235);
			}
			if (!bool_2)
			{
				color_2 = Color.Empty;
			}
			if (!bool_6)
			{
				color_6 = Color.FromArgb(118, 116, 146);
			}
			if (!bool_7)
			{
				color_7 = Color.White;
			}
			if (!bool_8)
			{
				color_8 = Color.FromArgb(186, 185, 206);
			}
			if (!bool_9)
			{
				color_9 = Color.FromArgb(243, 243, 247);
			}
			if (!bool_10)
			{
				color_10 = Color.FromArgb(215, 215, 228);
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = Color.FromArgb(215, 215, 228);
			}
			if (!bool_4)
			{
				color_4 = Color.White;
			}
			if (!bool_5)
			{
				color_5 = Color.Empty;
			}
			if (!bool_12)
			{
				color_12 = Color.FromArgb(75, 75, 111);
			}
			if (!bool_13)
			{
				color_13 = Color.FromArgb(75, 75, 111);
			}
			if (!bool_14)
			{
				color_14 = Color.FromArgb(75, 75, 111);
			}
			if (!bool_15)
			{
				color_15 = Color.FromArgb(255, 249, 237);
			}
			if (!bool_16)
			{
				color_16 = Color.FromArgb(255, 240, 199);
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = colorScheme.BarDockedBorder;
			}
			if (!bool_19)
			{
				color_19 = Color.White;
			}
			if (!bool_20)
			{
				color_20 = color_19;
			}
			if (!bool_21)
			{
				color_21 = colorScheme.BarBackground;
			}
			if (!bool_22)
			{
				color_22 = colorScheme.BarBackground;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		}
		if (!bool_3)
		{
			color_3 = color_22;
		}
		if (!bool_4)
		{
			color_4 = color_21;
		}
		if (!bool_5)
		{
			color_5 = color_18;
		}
	}

	private void method_7(bool bool_28)
	{
		Enum19 enum19_ = Class109.Enum19_0;
		ColorScheme colorScheme = new ColorScheme(eDotNetBarStyle.VS2005);
		switch (enum19_)
		{
		default:
			if (!bool_0)
			{
				color_0 = colorScheme.BarBackground;
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = colorScheme.BarBackground2;
			}
			if (!bool_6)
			{
				if (bool_28)
				{
					color_6 = color_2;
				}
				else
				{
					color_6 = Color.Empty;
				}
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = color_0;
			}
			if (!bool_10)
			{
				color_10 = Color.Empty;
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = color_9;
			}
			if (!bool_4)
			{
				color_4 = ControlPaint.LightLight(color_9);
			}
			if (!bool_5)
			{
				color_5 = Color.Empty;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = Color.Empty;
			}
			if (!bool_18)
			{
				color_18 = colorScheme.BarFloatingBorder;
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = ControlPaint.LightLight(colorScheme.BarBackground);
			}
			if (!bool_22)
			{
				color_22 = Color.Empty;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_1:
			if (!bool_0)
			{
				color_0 = method_9("F4F2E8");
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = method_9("ACA899");
			}
			if (!bool_6)
			{
				if (bool_28)
				{
					color_6 = method_9("ACA899");
				}
				else
				{
					color_6 = Color.Empty;
				}
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = method_9("F4F2E8");
			}
			if (!bool_10)
			{
				color_10 = Color.Empty;
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = color_9;
			}
			if (!bool_4)
			{
				color_4 = Color.White;
			}
			if (!bool_5)
			{
				color_5 = color_2;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = method_9("ACA899");
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = Color.White;
			}
			if (!bool_22)
			{
				color_22 = Color.Empty;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_2:
			if (!bool_0)
			{
				color_0 = method_9("F4F2E9");
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = method_9("ACA899");
			}
			if (!bool_6)
			{
				if (bool_28)
				{
					color_6 = color_2;
				}
				else
				{
					color_6 = Color.Empty;
				}
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = method_9("F4F2E9");
			}
			if (!bool_10)
			{
				color_10 = Color.Empty;
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = color_9;
			}
			if (!bool_4)
			{
				color_4 = Color.White;
			}
			if (!bool_5)
			{
				color_5 = color_2;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = method_9("ACA899");
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = Color.White;
			}
			if (!bool_22)
			{
				color_22 = Color.Empty;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_3:
			if (!bool_0)
			{
				color_0 = method_9("E7E7EF");
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = method_9("9D9DA1");
			}
			if (!bool_6)
			{
				if (bool_28)
				{
					color_6 = color_2;
				}
				else
				{
					color_6 = Color.Empty;
				}
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = method_9("E7E7EF");
			}
			if (!bool_10)
			{
				color_10 = Color.Empty;
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = color_9;
			}
			if (!bool_4)
			{
				color_4 = Color.White;
			}
			if (!bool_5)
			{
				color_5 = color_6;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = color_2;
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = Color.White;
			}
			if (!bool_22)
			{
				color_22 = Color.Empty;
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		}
		if (!bool_24)
		{
			color_24 = color_18;
		}
		if (!bool_25)
		{
			color_25 = color_19;
		}
	}

	private void method_8()
	{
		Enum19 enum19_ = Class109.Enum19_0;
		if (!bool_24)
		{
			color_24 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		ColorScheme colorScheme = new ColorScheme(eDotNetBarStyle.VS2005);
		switch (enum19_)
		{
		default:
			if (!bool_0)
			{
				color_0 = SystemColors.Control;
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = SystemColors.ControlDarkDark;
			}
			if (!bool_6)
			{
				color_6 = SystemColors.ControlDarkDark;
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = ControlPaint.Light(colorScheme.BarBackground2);
			}
			if (!bool_10)
			{
				color_10 = ControlPaint.Light(colorScheme.BarBackground);
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = ControlPaint.LightLight(color_9);
			}
			if (!bool_4)
			{
				color_4 = color_9;
			}
			if (!bool_5)
			{
				color_5 = color_2;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = Color.Empty;
			}
			if (!bool_18)
			{
				color_18 = color_6;
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = SystemColors.Highlight;
			}
			if (!bool_22)
			{
				color_22 = Color.FromArgb(45, color_21);
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_1:
			if (!bool_0)
			{
				color_0 = method_9("F9F8F4");
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = SystemColors.ControlDarkDark;
			}
			if (!bool_6)
			{
				color_6 = SystemColors.ControlDarkDark;
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = method_9("ECE9D7");
			}
			if (!bool_10)
			{
				color_10 = method_9("FEFDFD");
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = Color.White;
			}
			if (!bool_4)
			{
				color_4 = color_9;
			}
			if (!bool_5)
			{
				color_5 = color_2;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = color_6;
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = method_9("0266FB");
			}
			if (!bool_22)
			{
				color_22 = Color.FromArgb(45, color_21);
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_2:
			if (!bool_0)
			{
				color_0 = SystemColors.Control;
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = SystemColors.ControlDarkDark;
			}
			if (!bool_6)
			{
				color_6 = SystemColors.ControlDarkDark;
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = method_9("ECE9D7");
			}
			if (!bool_10)
			{
				color_10 = method_9("FEFDFD");
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = Color.White;
			}
			if (!bool_4)
			{
				color_4 = color_9;
			}
			if (!bool_5)
			{
				color_5 = color_2;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = method_9("ACA899");
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = SystemColors.Highlight;
			}
			if (!bool_22)
			{
				color_22 = Color.FromArgb(45, color_21);
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		case Enum19.const_3:
			if (!bool_0)
			{
				color_0 = SystemColors.Control;
			}
			if (!bool_1)
			{
				color_1 = Color.Empty;
			}
			if (!bool_2)
			{
				color_2 = SystemColors.ControlDarkDark;
			}
			if (!bool_6)
			{
				color_6 = SystemColors.ControlDarkDark;
			}
			if (!bool_7)
			{
				color_7 = Color.Empty;
			}
			if (!bool_8)
			{
				color_8 = Color.Empty;
			}
			if (!bool_9)
			{
				color_9 = method_9("F2F2F7");
			}
			if (!bool_10)
			{
				color_10 = method_9("FEFEFE");
			}
			if (!bool_11)
			{
				color_11 = SystemColors.ControlText;
			}
			if (!bool_3)
			{
				color_3 = Color.White;
			}
			if (!bool_4)
			{
				color_4 = color_9;
			}
			if (!bool_5)
			{
				color_5 = color_6;
			}
			if (!bool_12)
			{
				color_12 = Color.Empty;
			}
			if (!bool_13)
			{
				color_13 = Color.Empty;
			}
			if (!bool_14)
			{
				color_14 = Color.Empty;
			}
			if (!bool_15)
			{
				color_15 = Color.Empty;
			}
			if (!bool_16)
			{
				color_16 = Color.Empty;
			}
			if (!bool_17)
			{
				color_17 = SystemColors.ControlText;
			}
			if (!bool_18)
			{
				color_18 = color_6;
			}
			if (!bool_19)
			{
				color_19 = Color.Empty;
			}
			if (!bool_20)
			{
				color_20 = Color.Empty;
			}
			if (!bool_21)
			{
				color_21 = SystemColors.Highlight;
			}
			if (!bool_22)
			{
				color_22 = Color.FromArgb(45, color_21);
			}
			if (!bool_23)
			{
				color_23 = SystemColors.ControlText;
			}
			break;
		}
	}

	private Color method_9(string string_0)
	{
		if (!(string_0 == "") && string_0 != null)
		{
			return Color.FromArgb(Convert.ToInt32(string_0.Substring(0, 2), 16), Convert.ToInt32(string_0.Substring(2, 2), 16), Convert.ToInt32(string_0.Substring(4, 2), 16));
		}
		return Color.Empty;
	}

	private void method_10()
	{
		Office2007TabColorTable office2007TabColorTable = null;
		if (GlobalManager.Renderer is Office2007Renderer)
		{
			office2007TabColorTable = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.TabControl;
		}
		if (office2007TabColorTable == null)
		{
			method_6();
			return;
		}
		if (!bool_24)
		{
			color_24 = Color.Empty;
		}
		if (!bool_25)
		{
			color_25 = Color.Empty;
		}
		if (!bool_0)
		{
			color_0 = office2007TabColorTable.TabBackground.Start;
		}
		if (!bool_1)
		{
			color_1 = office2007TabColorTable.TabBackground.End;
		}
		if (!bool_2)
		{
			color_2 = Color.Empty;
		}
		if (!bool_6)
		{
			color_6 = office2007TabColorTable.Default.OuterBorder;
		}
		if (!bool_7)
		{
			color_7 = office2007TabColorTable.Default.InnerBorder;
		}
		if (!bool_8)
		{
			color_8 = Color.Empty;
		}
		if (!bool_9)
		{
			color_9 = office2007TabColorTable.Default.TopBackground.Start;
		}
		if (!bool_10)
		{
			color_10 = office2007TabColorTable.Default.BottomBackground.End;
		}
		if (!bool_9)
		{
			backgroundColorBlendCollection_0.Clear();
			backgroundColorBlendCollection_0.Add(new BackgroundColorBlend(office2007TabColorTable.Default.TopBackground.Start, 0f));
			backgroundColorBlendCollection_0.Add(new BackgroundColorBlend(office2007TabColorTable.Default.TopBackground.End, 0.45f));
			backgroundColorBlendCollection_0.Add(new BackgroundColorBlend(office2007TabColorTable.Default.BottomBackground.Start, 0.45f));
			backgroundColorBlendCollection_0.Add(new BackgroundColorBlend(office2007TabColorTable.Default.BottomBackground.End, 1f));
		}
		if (!bool_11)
		{
			color_11 = office2007TabColorTable.Default.Text;
		}
		if (!bool_3)
		{
			color_3 = office2007TabColorTable.TabPanelBackground.Start;
		}
		if (!bool_4)
		{
			color_4 = office2007TabColorTable.TabPanelBackground.End;
		}
		if (!bool_5)
		{
			color_5 = office2007TabColorTable.TabPanelBorder;
		}
		if (!bool_12)
		{
			color_12 = office2007TabColorTable.MouseOver.OuterBorder;
		}
		if (!bool_13)
		{
			color_13 = office2007TabColorTable.MouseOver.InnerBorder;
		}
		if (!bool_14)
		{
			color_14 = Color.Empty;
		}
		if (!bool_15)
		{
			color_15 = office2007TabColorTable.MouseOver.TopBackground.Start;
		}
		if (!bool_16)
		{
			color_16 = office2007TabColorTable.MouseOver.BottomBackground.End;
		}
		if (!bool_15)
		{
			backgroundColorBlendCollection_1.Clear();
			backgroundColorBlendCollection_1.Add(new BackgroundColorBlend(office2007TabColorTable.MouseOver.TopBackground.Start, 0f));
			backgroundColorBlendCollection_1.Add(new BackgroundColorBlend(office2007TabColorTable.MouseOver.TopBackground.End, 0.45f));
			backgroundColorBlendCollection_1.Add(new BackgroundColorBlend(office2007TabColorTable.MouseOver.BottomBackground.Start, 0.45f));
			backgroundColorBlendCollection_1.Add(new BackgroundColorBlend(office2007TabColorTable.MouseOver.BottomBackground.End, 1f));
		}
		if (!bool_17)
		{
			color_17 = office2007TabColorTable.MouseOver.Text;
		}
		if (!bool_18)
		{
			color_18 = office2007TabColorTable.Selected.OuterBorder;
		}
		if (!bool_19)
		{
			color_19 = office2007TabColorTable.Selected.InnerBorder;
		}
		if (!bool_20)
		{
			color_20 = Color.Empty;
		}
		if (!bool_21)
		{
			color_21 = office2007TabColorTable.Selected.TopBackground.Start;
		}
		if (!bool_22)
		{
			color_22 = office2007TabColorTable.Selected.BottomBackground.End;
		}
		if (!bool_21)
		{
			backgroundColorBlendCollection_2.Clear();
			backgroundColorBlendCollection_2.Add(new BackgroundColorBlend(office2007TabColorTable.Selected.TopBackground.Start, 0f));
			backgroundColorBlendCollection_2.Add(new BackgroundColorBlend(office2007TabColorTable.Selected.TopBackground.End, 0.45f));
			backgroundColorBlendCollection_2.Add(new BackgroundColorBlend(office2007TabColorTable.Selected.BottomBackground.Start, 0.45f));
			backgroundColorBlendCollection_2.Add(new BackgroundColorBlend(office2007TabColorTable.Selected.BottomBackground.End, 1f));
		}
		if (!bool_23)
		{
			color_23 = office2007TabColorTable.Selected.Text;
		}
		if (!bool_3)
		{
			color_3 = office2007TabColorTable.TabPanelBackground.Start;
		}
		if (!bool_4)
		{
			color_4 = office2007TabColorTable.TabPanelBackground.End;
		}
		if (!bool_5)
		{
			color_5 = office2007TabColorTable.TabPanelBorder;
		}
	}

	protected virtual void InvokeColorChanged()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}

	public void ResetChangedFlag()
	{
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_9 = false;
		bool_10 = false;
		bool_6 = false;
		bool_8 = false;
		bool_7 = false;
		bool_11 = false;
		bool_15 = false;
		bool_16 = false;
		bool_12 = false;
		bool_14 = false;
		bool_13 = false;
		bool_17 = false;
		bool_21 = false;
		bool_22 = false;
		bool_18 = false;
		bool_20 = false;
		bool_19 = false;
		bool_23 = false;
		bool_24 = false;
		bool_25 = false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabBackground()
	{
		return bool_0;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabBackground2()
	{
		return bool_1;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabBorder()
	{
		return bool_2;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabPanelBackground()
	{
		return bool_3;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabPanelBackground2()
	{
		return bool_4;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabPanelBorder()
	{
		return bool_5;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemBorder()
	{
		return bool_6;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemBorderLight()
	{
		return bool_7;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemBorderDark()
	{
		return bool_8;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemBackground()
	{
		return bool_9;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemBackground2()
	{
		return bool_10;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemText()
	{
		return bool_11;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemHotBorder()
	{
		return bool_12;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemHotBorderLight()
	{
		return bool_13;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemHotBorderDark()
	{
		return bool_14;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemHotBackground()
	{
		return bool_15;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemHotBackground2()
	{
		return bool_16;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemHotText()
	{
		return bool_17;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSelectedBorder()
	{
		return bool_18;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSelectedBorderLight()
	{
		return bool_19;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSelectedBorderDark()
	{
		return bool_20;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSelectedBackground()
	{
		return bool_21;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSelectedBackground2()
	{
		return bool_22;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSelectedText()
	{
		return bool_23;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSeparator()
	{
		return bool_24;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTabItemSeparatorShade()
	{
		return bool_25;
	}

	public static void ApplyPredefinedColor(TabItem item, eTabItemColor c)
	{
		item.BackColorGradientAngle = 90;
		switch (c)
		{
		default:
			item.BackColor = Color.Empty;
			item.BackColor2 = Color.Empty;
			break;
		case eTabItemColor.Blue:
			item.BackColor = Color.FromArgb(221, 230, 247);
			item.BackColor2 = Color.FromArgb(138, 168, 228);
			break;
		case eTabItemColor.Yellow:
			item.BackColor = Color.FromArgb(255, 244, 213);
			item.BackColor2 = Color.FromArgb(255, 216, 105);
			break;
		case eTabItemColor.Green:
			item.BackColor = Color.FromArgb(234, 240, 226);
			item.BackColor2 = Color.FromArgb(183, 201, 151);
			break;
		case eTabItemColor.Red:
			item.BackColor = Color.FromArgb(249, 225, 226);
			item.BackColor2 = Color.FromArgb(238, 149, 151);
			break;
		case eTabItemColor.Purple:
			item.BackColor = Color.FromArgb(234, 227, 245);
			item.BackColor2 = Color.FromArgb(180, 158, 222);
			break;
		case eTabItemColor.Cyan:
			item.BackColor = Color.FromArgb(227, 236, 243);
			item.BackColor2 = Color.FromArgb(155, 187, 210);
			break;
		case eTabItemColor.Orange:
			item.BackColor = Color.FromArgb(252, 233, 217);
			item.BackColor2 = Color.FromArgb(246, 176, 120);
			break;
		case eTabItemColor.Magenta:
			item.BackColor = Color.FromArgb(243, 229, 236);
			item.BackColor2 = Color.FromArgb(213, 164, 187);
			break;
		case eTabItemColor.BlueMist:
			item.BackColor = Color.FromArgb(227, 236, 243);
			item.BackColor2 = Color.FromArgb(155, 187, 210);
			break;
		case eTabItemColor.PurpleMist:
			item.BackColor = Color.FromArgb(232, 227, 234);
			item.BackColor2 = Color.FromArgb(171, 156, 183);
			break;
		case eTabItemColor.Tan:
			item.BackColor = Color.FromArgb(248, 242, 226);
			item.BackColor2 = Color.FromArgb(232, 209, 153);
			break;
		case eTabItemColor.Lemon:
			item.BackColor = Color.FromArgb(252, 253, 215);
			item.BackColor2 = Color.FromArgb(245, 249, 111);
			break;
		case eTabItemColor.Apple:
			item.BackColor = Color.FromArgb(232, 248, 224);
			item.BackColor2 = Color.FromArgb(173, 231, 146);
			break;
		case eTabItemColor.Teal:
			item.BackColor = Color.FromArgb(205, 236, 240);
			item.BackColor2 = Color.FromArgb(78, 188, 202);
			break;
		case eTabItemColor.Silver:
			item.BackColor = Color.FromArgb(225, 225, 232);
			item.BackColor2 = Color.FromArgb(149, 149, 170);
			break;
		}
	}

	public static void ApplyPredefinedColor(ISimpleTab item, eTabItemColor c)
	{
		item.BackColorGradientAngle = 90;
		item.TextColor = Color.Black;
		item.BorderColor = Color.Empty;
		item.DarkBorderColor = Color.FromArgb(190, Color.DimGray);
		item.LightBorderColor = Color.FromArgb(128, Color.White);
		switch (c)
		{
		default:
			item.BackColor = Color.Empty;
			item.BackColor2 = Color.Empty;
			break;
		case eTabItemColor.Blue:
			item.BackColor = Color.FromArgb(221, 230, 247);
			item.BackColor2 = Color.FromArgb(138, 168, 228);
			break;
		case eTabItemColor.Yellow:
			item.BackColor = Color.FromArgb(255, 244, 213);
			item.BackColor2 = Color.FromArgb(255, 216, 105);
			break;
		case eTabItemColor.Green:
			item.BackColor = Color.FromArgb(234, 240, 226);
			item.BackColor2 = Color.FromArgb(183, 201, 151);
			break;
		case eTabItemColor.Red:
			item.BackColor = Color.FromArgb(249, 225, 226);
			item.BackColor2 = Color.FromArgb(238, 149, 151);
			break;
		case eTabItemColor.Purple:
			item.BackColor = Color.FromArgb(234, 227, 245);
			item.BackColor2 = Color.FromArgb(180, 158, 222);
			break;
		case eTabItemColor.Cyan:
			item.BackColor = Color.FromArgb(227, 236, 243);
			item.BackColor2 = Color.FromArgb(155, 187, 210);
			break;
		case eTabItemColor.Orange:
			item.BackColor = Color.FromArgb(252, 233, 217);
			item.BackColor2 = Color.FromArgb(246, 176, 120);
			break;
		case eTabItemColor.Magenta:
			item.BackColor = Color.FromArgb(243, 229, 236);
			item.BackColor2 = Color.FromArgb(213, 164, 187);
			break;
		case eTabItemColor.BlueMist:
			item.BackColor = Color.FromArgb(227, 236, 243);
			item.BackColor2 = Color.FromArgb(155, 187, 210);
			break;
		case eTabItemColor.PurpleMist:
			item.BackColor = Color.FromArgb(232, 227, 234);
			item.BackColor2 = Color.FromArgb(171, 156, 183);
			break;
		case eTabItemColor.Tan:
			item.BackColor = Color.FromArgb(248, 242, 226);
			item.BackColor2 = Color.FromArgb(232, 209, 153);
			break;
		case eTabItemColor.Lemon:
			item.BackColor = Color.FromArgb(252, 253, 215);
			item.BackColor2 = Color.FromArgb(245, 249, 111);
			break;
		case eTabItemColor.Apple:
			item.BackColor = Color.FromArgb(232, 248, 224);
			item.BackColor2 = Color.FromArgb(173, 231, 146);
			break;
		case eTabItemColor.Teal:
			item.BackColor = Color.FromArgb(205, 236, 240);
			item.BackColor2 = Color.FromArgb(78, 188, 202);
			break;
		case eTabItemColor.Silver:
			item.BackColor = Color.FromArgb(225, 225, 232);
			item.BackColor2 = Color.FromArgb(149, 149, 170);
			break;
		}
	}
}
