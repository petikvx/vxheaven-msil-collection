using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[Designer(typeof(BubbleBarTabDesigner))]
[ToolboxItem(false)]
public class BubbleBarTab : Component, ISimpleTab, IBlock
{
	private string string_0 = "";

	private BubbleBar bubbleBar_0;

	private bool bool_0 = true;

	private Rectangle rectangle_0 = Rectangle.Empty;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	private int int_0 = 90;

	private Color color_2 = Color.Empty;

	private Color color_3 = Color.Empty;

	private Color color_4 = Color.Empty;

	private Color color_5 = Color.Empty;

	private string string_1 = "";

	private eTabItemColor eTabItemColor_0;

	private object object_0;

	private BubbleButtonCollection bubbleButtonCollection_0;

	private bool bool_1;

	[Description("Returns collection of buttons on the tab.")]
	[Category("Buttons")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Editor(typeof(BubbleButtonCollectionEditor), typeof(UITypeEditor))]
	public BubbleButtonCollection Buttons => bubbleButtonCollection_0;

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates the text displayed on the tab.")]
	[Localizable(true)]
	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			if (!(string_0 == value))
			{
				string_0 = value;
				if (bubbleBar_0 != null)
				{
					bubbleBar_0.method_37(this);
				}
				Refresh();
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether the tab is visible.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	public bool Visible
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
				if (bubbleBar_0 != null)
				{
					bubbleBar_0.method_38(this);
				}
				Refresh();
			}
		}
	}

	[Browsable(false)]
	public Rectangle DisplayRectangle => rectangle_0;

	[DefaultValue(null)]
	[Category("Data")]
	[Description("Indicates text that contains data about the cell.")]
	[Browsable(false)]
	public object Tag
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	[Browsable(true)]
	[DefaultValue("")]
	[Description("Indicates text that contains data about the cell.")]
	[Category("Data")]
	public string TagString
	{
		get
		{
			if (object_0 == null)
			{
				return "";
			}
			return object_0.ToString();
		}
		set
		{
			object_0 = value;
		}
	}

	[Description("Indicates the inactive tab background color.")]
	[Category("Style")]
	[Browsable(true)]
	public Color BackColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Refresh();
		}
	}

	[Description("Indicates the inactive tab target gradient background color.")]
	[Category("Style")]
	[Browsable(true)]
	public Color BackColor2
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			Refresh();
		}
	}

	[Browsable(true)]
	[DefaultValue(90)]
	[Description("Indicates the gradient angle.")]
	[Category("Style")]
	public int BackColorGradientAngle
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			Refresh();
		}
	}

	[Category("Style")]
	[Description("Indicates the inactive tab light border color.")]
	[Browsable(true)]
	public Color LightBorderColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			Refresh();
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[Description("Indicates the inactive tab dark border color.")]
	public Color DarkBorderColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			Refresh();
		}
	}

	[Description("Indicates the inactive tab border color.")]
	[Category("Style")]
	[Browsable(true)]
	public Color BorderColor
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			Refresh();
		}
	}

	[Description("Indicates the inactive tab text color.")]
	[Browsable(true)]
	[Category("Style")]
	public Color TextColor
	{
		get
		{
			return color_5;
		}
		set
		{
			color_5 = value;
			Refresh();
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates the name used to identify item.")]
	[Category("Design")]
	public string Name
	{
		get
		{
			if (Site != null)
			{
				string_1 = Site!.Name;
			}
			return string_1;
		}
		set
		{
			if (Site != null)
			{
				Site!.Name = value;
			}
			if (value == null)
			{
				string_1 = "";
			}
			else
			{
				string_1 = value;
			}
		}
	}

	[DefaultValue(eTabItemColor.Default)]
	[Browsable(true)]
	[Category("Style")]
	[Description("Applies predefined color to tab.")]
	public eTabItemColor PredefinedColor
	{
		get
		{
			return eTabItemColor_0;
		}
		set
		{
			eTabItemColor_0 = value;
			TabColorScheme.ApplyPredefinedColor(this, eTabItemColor_0);
			Refresh();
		}
	}

	[Browsable(false)]
	public bool IsSelected
	{
		get
		{
			if (bubbleBar_0 != null)
			{
				return bubbleBar_0.SelectedTab == this;
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsMouseOver
	{
		get
		{
			if (bubbleBar_0 != null)
			{
				return bubbleBar_0.method_40() == this;
			}
			return false;
		}
	}

	eTabStripAlignment ISimpleTab.TabAlignment
	{
		get
		{
			if (bubbleBar_0 != null && bubbleBar_0.Alignment == eBubbleButtonAlignment.Top)
			{
				return eTabStripAlignment.Bottom;
			}
			return eTabStripAlignment.Top;
		}
	}

	[Browsable(false)]
	public BubbleBar Parent => bubbleBar_0;

	internal bool Focus
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

	Rectangle IBlock.Bounds
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	public BubbleBarTab()
		: this(null)
	{
	}

	public BubbleBarTab(IContainer container)
	{
		container?.Add(this);
		bubbleButtonCollection_0 = new BubbleButtonCollection(this);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBackColor()
	{
		BackColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBackColor2()
	{
		return !color_1.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetBackColor2()
	{
		BackColor2 = Color.Empty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeLightBorderColor()
	{
		return !color_2.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetLightBorderColor()
	{
		LightBorderColor = Color.Empty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDarkBorderColor()
	{
		return !color_3.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public void ResetDarkBorderColor()
	{
		DarkBorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeBorderColor()
	{
		return !color_4.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetBorderColor()
	{
		BorderColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeTextColor()
	{
		return !color_5.IsEmpty;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	public override string ToString()
	{
		return string_0;
	}

	public Font GetTabFont()
	{
		if (bubbleBar_0 != null)
		{
			return ((Control)bubbleBar_0).get_Font();
		}
		return SystemInformation.get_MenuFont();
	}

	internal void SetParent(BubbleBar parent)
	{
		bubbleBar_0 = parent;
	}

	private void Refresh()
	{
		if (bubbleBar_0 != null)
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Width += 16;
			displayRectangle.X -= 8;
			((Control)bubbleBar_0).Invalidate(displayRectangle);
			((Control)bubbleBar_0).Update();
		}
	}

	internal void OnButtonInserted(BubbleButton button)
	{
		if (bubbleBar_0 != null)
		{
			bubbleBar_0.method_22(this, button);
		}
	}

	internal void OnButtonRemoved(BubbleButton button)
	{
		if (bubbleBar_0 != null)
		{
			bubbleBar_0.method_20(this, button);
		}
	}

	internal void OnButtonsCollectionClear()
	{
		if (bubbleBar_0 != null)
		{
			bubbleBar_0.method_19(this);
		}
	}
}
