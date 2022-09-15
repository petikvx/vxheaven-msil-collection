using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[Designer(typeof(SideBarPanelItemDesigner))]
[ToolboxItem(false)]
public class SideBarPanelItem : ImageItem, IDesignTimeProvider
{
	private const string string_7 = "Right-click header and choose Add New Button or use SubItems collection to create new buttons.";

	private const int int_4 = 26;

	private const int int_5 = 2;

	private int int_6;

	private bool bool_22;

	private Rectangle[] rectangle_0 = new Rectangle[2]
	{
		Rectangle.Empty,
		Rectangle.Empty
	};

	private int int_7 = -1;

	private int int_8 = 3;

	private bool bool_23;

	private bool bool_24;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private Color color_0 = SystemColors.ControlText;

	private Color color_1 = Color.Empty;

	private bool bool_25;

	private bool bool_26;

	private bool bool_27;

	private eBarImageSize eBarImageSize_0;

	private Point point_2;

	private SideBarPanelControlHost sideBarPanelControlHost_0;

	private ItemStyle itemStyle_0 = new ItemStyle();

	private ItemStyle itemStyle_1;

	private ItemStyle itemStyle_2;

	private ItemStyle itemStyle_3;

	private ItemStyle itemStyle_4;

	private ItemStyle itemStyle_5;

	private ItemStyle itemStyle_6;

	private bool bool_28;

	private Image image_0;

	private int int_9 = -1;

	private Image image_1;

	private int int_10 = -1;

	private Image image_2;

	private int int_11 = -1;

	private Icon icon_0;

	private Image image_3;

	private ItemPaintArgs itemPaintArgs_0;

	private eSideBarAppearance eSideBarAppearance_0;

	private bool bool_29;

	private DateTime dateTime_0 = DateTime.MinValue;

	private Rectangle rectangle_2 = Rectangle.Empty;

	private bool bool_30 = true;

	private eSideBarLayoutType eSideBarLayoutType_0;

	private eStyleTextAlignment eStyleTextAlignment_0 = eStyleTextAlignment.Center;

	[Browsable(false)]
	public bool IsMouseOver => bool_23;

	[Browsable(false)]
	public bool IsMouseDown => bool_24;

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eStyleTextAlignment.Center)]
	[Description("Specifies alignment of the text.")]
	[DevCoSerialize]
	public eStyleTextAlignment TextAlignment
	{
		get
		{
			return eStyleTextAlignment_0;
		}
		set
		{
			eStyleTextAlignment_0 = value;
			OnAppearanceChanged();
		}
	}

	[Description("Gets or sets the layout type for the items.")]
	[DefaultValue(eSideBarLayoutType.Default)]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public eSideBarLayoutType LayoutType
	{
		get
		{
			return eSideBarLayoutType_0;
		}
		set
		{
			if (eSideBarLayoutType_0 != value)
			{
				eSideBarLayoutType_0 = value;
				NeedRecalcSize = true;
				if (DesignMode)
				{
					Refresh();
				}
			}
		}
	}

	[Description("The text contained in the item.")]
	[Localizable(true)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
			if (m_Text == "")
			{
				int_8 = 0;
			}
			else
			{
				int_8 = 3;
			}
			NeedRecalcSize = true;
			if (Parent != null)
			{
				Parent.NeedRecalcSize = true;
			}
			if (DesignMode)
			{
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets group background style.")]
	[Category("Style")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public ItemStyle BackgroundStyle => itemStyle_0;

	internal bool Boolean_3
	{
		get
		{
			if (itemStyle_1 != null)
			{
				return true;
			}
			return false;
		}
	}

	[Browsable(true)]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[Description("Gets or sets the item header style. Applies only when SideBar.Appearance is set to Flat.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	public ItemStyle HeaderStyle
	{
		get
		{
			if (itemStyle_1 == null)
			{
				method_26(new ItemStyle());
			}
			return itemStyle_1;
		}
	}

	[Description("Gets or sets the item header style when mouse is over the header. Applies only when SideBar.Appearance is set to Flat.")]
	[NotifyParentProperty(true)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(true)]
	public ItemStyle HeaderHotStyle
	{
		get
		{
			if (itemStyle_2 == null)
			{
				method_27(new ItemStyle());
			}
			return itemStyle_2;
		}
	}

	[DevCoBrowsable(true)]
	[NotifyParentProperty(true)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets the item header style when left mouse button is pressed on header. Applies only when SideBar.Appearance is set to Flat.")]
	[Category("Style")]
	public ItemStyle HeaderMouseDownStyle
	{
		get
		{
			if (itemStyle_3 == null)
			{
				method_28(new ItemStyle());
			}
			return itemStyle_3;
		}
	}

	[Browsable(true)]
	[NotifyParentProperty(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[Description("Gets or sets the item header side style. Applies only when SideBar.Appearance is set to Flat.")]
	public ItemStyle HeaderSideStyle
	{
		get
		{
			if (itemStyle_4 == null)
			{
				method_29(new ItemStyle());
			}
			return itemStyle_4;
		}
	}

	[Description("Gets or sets the item header side style when mouse is over the header. Applies only when SideBar.Appearance is set to Flat.")]
	[DevCoBrowsable(true)]
	[Category("Style")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[NotifyParentProperty(true)]
	public ItemStyle HeaderSideHotStyle
	{
		get
		{
			if (itemStyle_5 == null)
			{
				method_30(new ItemStyle());
			}
			return itemStyle_5;
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[NotifyParentProperty(true)]
	[Description("Gets or sets the item header side style when left mouse button is pressed on header. Applies only when SideBar.Appearance is set to Flat.")]
	[DevCoBrowsable(true)]
	public ItemStyle HeaderSideMouseDownStyle
	{
		get
		{
			if (itemStyle_6 == null)
			{
				method_31(new ItemStyle());
			}
			return itemStyle_6;
		}
	}

	internal eSideBarAppearance ESideBarAppearance_0
	{
		get
		{
			return eSideBarAppearance_0;
		}
		set
		{
			if (eSideBarAppearance_0 != value)
			{
				eSideBarAppearance_0 = value;
				NeedRecalcSize = true;
			}
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Specifies that text font is bold when text is rendered.")]
	public bool FontBold
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "FontBold");
				}
				if (Displayed)
				{
					Refresh();
				}
			}
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Specifies that text font is bold when mouse is over the item.")]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	public bool HotFontBold
	{
		get
		{
			return bool_26;
		}
		set
		{
			if (bool_26 != value)
			{
				bool_26 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotFontBold");
				}
				if (Displayed && bool_23)
				{
					Refresh();
				}
			}
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Specifies that text font is underlined when mouse is over the item.")]
	public bool HotFontUnderline
	{
		get
		{
			return bool_25;
		}
		set
		{
			if (bool_25 != value)
			{
				bool_25 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotFontUnderline");
				}
				if (Displayed && bool_23)
				{
					Refresh();
				}
			}
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Description("The foreground color used to display text when mouse is over the item.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color HotForeColor
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HotForeColor");
				}
				if (Displayed && bool_23)
				{
					Refresh();
				}
			}
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Description("The foreground color used to display text.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Color ForeColor
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ForeColor");
				}
				if (Displayed)
				{
					Refresh();
				}
			}
			OnAppearanceChanged();
		}
	}

	[DefaultValue(eItemAlignment.Near)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[Description("Determines alignment of the item inside the container.")]
	public override eItemAlignment ItemAlignment
	{
		get
		{
			return base.ItemAlignment;
		}
		set
		{
			base.ItemAlignment = value;
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(false)]
	[DefaultValue(false)]
	[Description("Indicates whether item will stretch to consume empty space. Items on stretchable, no-wrap Bars only.")]
	[Browsable(false)]
	public override bool Stretch
	{
		get
		{
			return base.Stretch;
		}
		set
		{
			base.Stretch = value;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public override bool AutoCollapseOnClick
	{
		get
		{
			return base.AutoCollapseOnClick;
		}
		set
		{
			base.AutoCollapseOnClick = value;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Determines whether sub-items are displayed.")]
	public override bool ShowSubItems
	{
		get
		{
			return base.ShowSubItems;
		}
		set
		{
			base.ShowSubItems = value;
		}
	}

	[Category("Design")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Description("Indicates item category used to group similar items at design-time.")]
	[DefaultValue("")]
	public override string Category
	{
		get
		{
			return base.Category;
		}
		set
		{
			base.Category = value;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Category("Design")]
	[DefaultValue("")]
	[Description("Indicates description of the item that is displayed during design.")]
	public override string Description
	{
		get
		{
			return base.Description;
		}
		set
		{
			base.Description = value;
		}
	}

	[DevCoBrowsable(false)]
	[DefaultValue(false)]
	[Description("Indicates whether this item is beginning of the group.")]
	[Browsable(false)]
	[Category("Appearance")]
	public override bool BeginGroup
	{
		get
		{
			return base.BeginGroup;
		}
		set
		{
			base.BeginGroup = value;
		}
	}

	[Description("Collection of sub items.")]
	[Category("Data")]
	[Editor(typeof(SideBarPanelItemEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(false)]
	public override SubItemsCollection SubItems => base.SubItems;

	[DefaultValue(eBarImageSize.Default)]
	[Description("Specifies the Image size that will be used by items on this bar.")]
	[Browsable(true)]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	public eBarImageSize ItemImageSize
	{
		get
		{
			return eBarImageSize_0;
		}
		set
		{
			eBarImageSize_0 = value;
			eImagePosition imagePosition = eImagePosition.Left;
			if (eBarImageSize_0 != 0)
			{
				imagePosition = eImagePosition.Top;
			}
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is ButtonItem buttonItem)
				{
					buttonItem.ImagePosition = imagePosition;
				}
			}
			int_6 = 0;
			RefreshImageSize();
			RecalcSize();
			Refresh();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Rectangle PanelRect => rectangle_1;

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public int TopItemIndex
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
			NeedRecalcSize = true;
			Refresh();
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Layout")]
	[Description("Indicates a value that determines whether text is displayed in multiple lines or one long line.")]
	public bool WordWrap
	{
		get
		{
			return bool_28;
		}
		set
		{
			bool_28 = value;
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is ButtonItem)
				{
					((ButtonItem)subItem).bool_36 = bool_28;
				}
			}
			NeedRecalcSize = true;
			if (DesignMode && ContainerControl is SideBar sideBar)
			{
				sideBar.RecalcLayout();
			}
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Specifies whether scroll buttons are displayed when content of the panel exceeds it's height.")]
	[DefaultValue(true)]
	[Browsable(true)]
	public bool EnableScrollButtons
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
			if (!bool_30)
			{
				NeedRecalcSize = true;
				if (DesignMode)
				{
					Refresh();
				}
			}
		}
	}

	internal bool Boolean_4 => bool_22;

	internal bool Boolean_5 => base.Boolean_2;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ImageList ImageList
	{
		get
		{
			if (GetOwner() is IOwner owner)
			{
				return owner.Images;
			}
			return null;
		}
	}

	[Browsable(true)]
	[DefaultValue(null)]
	[Description("Specifies the Button icon. Icons support multiple image sizes and alpha blending.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	public Icon Icon
	{
		get
		{
			return icon_0;
		}
		set
		{
			NeedRecalcSize = true;
			icon_0 = value;
			OnImageChanged();
			Refresh();
			OnAppearanceChanged();
		}
	}

	[Description("The image that will be displayed on the face of the item.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			NeedRecalcSize = true;
			image_0 = value;
			OnImageChanged();
			Refresh();
			OnAppearanceChanged();
		}
	}

	[DefaultValue(-1)]
	[Description("The image list image index of the image that will be displayed on the face of the item.")]
	[Category("Appearance")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[DevCoBrowsable(true)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Browsable(true)]
	public int ImageIndex
	{
		get
		{
			return int_9;
		}
		set
		{
			image_3 = null;
			if (int_9 != value)
			{
				int_9 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ImageIndex");
				}
				if (m_Parent != null)
				{
					OnImageChanged();
					NeedRecalcSize = true;
					Refresh();
				}
			}
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	[Description("The image that will be displayed when mouse hovers over the item.")]
	[Browsable(true)]
	[Category("Appearance")]
	public Image HoverImage
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
			OnAppearanceChanged();
		}
	}

	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("The image list image index of the image that will be displayed when mouse hovers over the item.")]
	[DefaultValue(-1)]
	[DevCoBrowsable(true)]
	public int HoverImageIndex
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "HoverImageIndex");
				}
				Refresh();
			}
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("The image that will be displayed when item is pressed.")]
	public Image PressedImage
	{
		get
		{
			return image_2;
		}
		set
		{
			image_2 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Category("Appearance")]
	[Description("The image list image index of the image that will be displayed when item is pressed.")]
	[DefaultValue(-1)]
	public int PressedImageIndex
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "PressedImageIndex");
				}
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

	public SideBarPanelItem()
		: this("", "")
	{
	}

	public SideBarPanelItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public SideBarPanelItem(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		m_IsContainer = true;
		itemStyle_0.Event_0 += method_17;
	}

	public override BaseItem Copy()
	{
		SideBarPanelItem sideBarPanelItem = new SideBarPanelItem();
		CopyToItem(sideBarPanelItem);
		return sideBarPanelItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		SideBarPanelItem sideBarPanelItem = copy as SideBarPanelItem;
		base.CopyToItem(sideBarPanelItem);
		sideBarPanelItem.HotFontBold = bool_26;
		sideBarPanelItem.HotFontUnderline = bool_25;
		sideBarPanelItem.HotForeColor = color_1;
		sideBarPanelItem.ForeColor = color_0;
		sideBarPanelItem.ItemImageSize = eBarImageSize_0;
		sideBarPanelItem.method_25(itemStyle_0.Clone() as ItemStyle);
	}

	private void method_17(object sender, EventArgs e)
	{
		method_18();
		NeedRecalcSize = true;
		OnAppearanceChanged();
	}

	internal void method_18()
	{
		if (ContainerControl is SideBar sideBar)
		{
			if (itemStyle_0 != null)
			{
				itemStyle_0.method_1(sideBar.ColorScheme);
			}
			if (itemStyle_1 != null)
			{
				itemStyle_1.method_1(sideBar.ColorScheme);
			}
			if (itemStyle_2 != null)
			{
				itemStyle_2.method_1(sideBar.ColorScheme);
			}
			if (itemStyle_3 != null)
			{
				itemStyle_3.method_1(sideBar.ColorScheme);
			}
			if (itemStyle_4 != null)
			{
				itemStyle_4.method_1(sideBar.ColorScheme);
			}
			if (itemStyle_5 != null)
			{
				itemStyle_5.method_1(sideBar.ColorScheme);
			}
			if (itemStyle_6 != null)
			{
				itemStyle_6.method_1(sideBar.ColorScheme);
			}
		}
	}

	public override void RecalcSize()
	{
		bool_22 = false;
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!BaseItem.IsHandleValid(val))
		{
			return;
		}
		Class271 @class = method_34();
		Size empty = Size.Empty;
		if (@class != null)
		{
			empty = @class.Size_0;
			empty.Width += 4;
			empty.Height += 4;
		}
		@class = null;
		Size size = Size.Empty;
		string text = m_Text;
		Graphics val2 = Class109.smethod_68(val);
		try
		{
			if (text != "")
			{
				size = Class55.smethod_4(val2, text, vmethod_1(), m_Rect.Width, method_23());
			}
		}
		finally
		{
			val2.Dispose();
		}
		if (empty.Height > size.Height + int_8 * 2)
		{
			rectangle_1 = new Rectangle(0, 0, m_Rect.Width, empty.Height);
		}
		else
		{
			rectangle_1 = new Rectangle(0, 0, m_Rect.Width, size.Height + int_8 * 2);
			if (eSideBarAppearance_0 == eSideBarAppearance.Flat)
			{
				rectangle_1.Height += 4;
			}
		}
		if (Expanded)
		{
			if (m_Rect.Height < rectangle_1.Height)
			{
				m_Rect.Height = rectangle_1.Height;
			}
			int num = m_Rect.Width;
			bool flag = false;
			if (eSideBarLayoutType_0 == eSideBarLayoutType.MultiColumn && int_6 > 0)
			{
				flag = true;
			}
			if (m_SubItems != null)
			{
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				do
				{
					num2++;
					num3 = m_Rect.Top + rectangle_1.Height + 1;
					int num5 = m_Rect.Left;
					num4 = m_Rect.Bottom;
					if (sideBarPanelControlHost_0 != null)
					{
						num3 = 0;
						num5 = 0;
						num4 = m_Rect.Height - (rectangle_1.Height + 1);
					}
					int num6 = -1;
					int num7 = num3;
					int num8 = m_Rect.Width;
					if (eSideBarAppearance_0 == eSideBarAppearance.Flat)
					{
						num8 = ((!empty.IsEmpty) ? (num8 - empty.Width) : (num8 - 26));
						if (num8 <= 0)
						{
							num8 = m_Rect.Width;
						}
						if (num8 > 16)
						{
							num8 -= 4;
							num5 += m_Rect.Width - num8 - 2;
						}
						else
						{
							num5 += m_Rect.Width - num8;
						}
						num = num8 + 4;
						if (sideBarPanelControlHost_0 != null)
						{
							num5 = 2;
						}
					}
					int num9 = num5;
					int num10 = 0;
					foreach (BaseItem subItem in m_SubItems)
					{
						num6++;
						if (subItem.Visible && (num3 <= num4 || flag))
						{
							if (num6 < int_6 && !flag)
							{
								subItem.WidthInternal = num8;
								subItem.RecalcSize();
								num7 += subItem.HeightInternal;
								subItem.Displayed = false;
								continue;
							}
							if (eSideBarLayoutType_0 == eSideBarLayoutType.MultiColumn)
							{
								subItem.WidthInternal = num8;
								subItem.RecalcSize();
								if (subItem.WidthInternal > num8 && num10 == 0)
								{
									subItem.WidthInternal = num8;
									num10 = subItem.HeightInternal;
								}
								else
								{
									if (num5 + subItem.WidthInternal - num9 > num8)
									{
										num5 = num9;
										num3 += num10;
										num7 += num10;
										num10 = 0;
									}
									if (subItem.HeightInternal > num10)
									{
										num10 = subItem.HeightInternal;
									}
									subItem.TopInternal = num3;
									subItem.LeftInternal = num5;
									num5 += subItem.WidthInternal;
								}
							}
							else
							{
								subItem.WidthInternal = num8;
								subItem.RecalcSize();
								subItem.WidthInternal = num8;
								if (DesignMode && subItem.IsWindowed && num3 + subItem.HeightInternal > num4)
								{
									num7 += subItem.HeightInternal;
									subItem.Displayed = false;
									continue;
								}
								if (subItem.BeginGroup)
								{
									num3 += 3;
									num7 += 3;
								}
								subItem.TopInternal = num3;
								subItem.LeftInternal = num5;
								num3 += subItem.HeightInternal;
								num7 += subItem.HeightInternal;
							}
							subItem.Displayed = true;
						}
						else
						{
							if (bool_30 && subItem.Visible)
							{
								bool_22 = true;
							}
							if (subItem.Visible && num3 > num4)
							{
								subItem.RecalcSize();
								num7 += subItem.HeightInternal;
							}
							subItem.Displayed = false;
						}
					}
					if (eSideBarLayoutType_0 == eSideBarLayoutType.MultiColumn && num10 > 0)
					{
						num7 += num10;
						num3 += num10;
					}
					if (flag)
					{
						int topInternal = SubItems[int_6].TopInternal;
						int num11 = int_6;
						while (num11 > 0)
						{
							num11--;
							if (SubItems[num11].Visible && SubItems[num11].TopInternal < topInternal)
							{
								num11++;
								break;
							}
						}
						int_6 = num11;
						flag = false;
						num2 = 2;
					}
					else if (num7 > 0 && num7 < num4 && int_6 > 0)
					{
						int_6 = 0;
						bool_22 = false;
						num2++;
					}
				}
				while (num2 == 2);
				if (num3 > num4 && bool_30)
				{
					bool_22 = true;
				}
			}
			if (sideBarPanelControlHost_0 != null)
			{
				Size empty2 = Size.Empty;
				empty2 = ((eSideBarAppearance_0 != 0) ? new Size(num, m_Rect.Height - rectangle_1.Height) : new Size(m_Rect.Width, m_Rect.Height - (rectangle_1.Height + 1)));
				Point empty3 = Point.Empty;
				empty3 = ((eSideBarAppearance_0 != 0) ? new Point(m_Rect.Right - num, m_Rect.Top + rectangle_1.Height) : new Point(m_Rect.Left, m_Rect.Top + rectangle_1.Height + 1));
				((Control)sideBarPanelControlHost_0).set_Size(empty2);
				((Control)sideBarPanelControlHost_0).set_Location(empty3);
				((Control)sideBarPanelControlHost_0).set_Visible(true);
			}
		}
		else
		{
			if (sideBarPanelControlHost_0 != null)
			{
				((Control)sideBarPanelControlHost_0).set_Visible(false);
			}
			m_Rect.Height = rectangle_1.Height;
			foreach (BaseItem subItem2 in m_SubItems)
			{
				subItem2.Displayed = false;
			}
		}
		if (sideBarPanelControlHost_0 != null && Expanded)
		{
			sideBarPanelControlHost_0.SetupScrollButtons();
		}
		base.RecalcSize();
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		if (bool_28)
		{
			pa.ButtonStringFormat &= ~(pa.ButtonStringFormat & eTextFormat.SingleLine);
			pa.ButtonStringFormat |= eTextFormat.WordBreak;
		}
		itemPaintArgs_0 = pa;
		Rectangle rect = m_Rect;
		Font val = vmethod_1();
		Graphics graphics = pa.Graphics;
		if (m_NeedRecalcSize)
		{
			RecalcSize();
		}
		if (Style == eDotNetBarStyle.Office2007)
		{
			SideBarPanelItemRendererEventArgs sideBarPanelItemRendererEventArgs = new SideBarPanelItemRendererEventArgs(this, pa.Graphics);
			sideBarPanelItemRendererEventArgs.itemPaintArgs_0 = pa;
			pa.BaseRenderer_0.DrawSideBarPanelItem(sideBarPanelItemRendererEventArgs);
			rect = rectangle_1;
			rect.Offset(m_Rect.X, m_Rect.Y);
		}
		else
		{
			if (base.Boolean_2)
			{
				method_19(pa);
				if (bool_28)
				{
					pa.ButtonStringFormat |= eTextFormat.SingleLine;
				}
				itemPaintArgs_0 = null;
				return;
			}
			if (SuspendLayout)
			{
				if (bool_28)
				{
					pa.ButtonStringFormat |= eTextFormat.SingleLine;
				}
				itemPaintArgs_0 = null;
				return;
			}
			Class271 @class = method_34();
			Rectangle rectangle = Rectangle.Empty;
			if (eSideBarAppearance_0 == eSideBarAppearance.Traditional)
			{
				Color color = SystemColors.Control;
				Color foreColor = color_0;
				object containerControl = ContainerControl;
				Control val2 = (Control)((containerControl is Control) ? containerControl : null);
				if (!itemStyle_0.BackColor1.IsEmpty || itemStyle_0.BackgroundImage != null)
				{
					itemStyle_0.Paint(graphics, m_Rect);
					color = itemStyle_0.BackColor1.Color;
				}
				if (val2 != null)
				{
					color = val2.get_BackColor();
					if (color_0 == SystemColors.ControlText)
					{
						foreColor = val2.get_ForeColor();
					}
				}
				if (bool_23 && !color_1.IsEmpty)
				{
					foreColor = color_1;
				}
				rect = rectangle_1;
				rect.Offset(m_Rect.X, m_Rect.Y);
				if (m_Text != "")
				{
					if (bool_24)
					{
						Class109.smethod_33(graphics, rect.X, rect.Y, rect.Width, rect.Height, (Border3DStyle)10, color);
					}
					else if (bool_23)
					{
						Class109.smethod_33(graphics, rect.X, rect.Y, rect.Width, rect.Height, (Border3DStyle)5, color);
					}
					else
					{
						Class109.smethod_33(graphics, rect.X, rect.Y, rect.Width, rect.Height, (Border3DStyle)4, color);
					}
				}
				rect.Inflate(-2, -2);
				if (@class != null)
				{
					rect.X += 2;
					rect.Width -= 2;
					@class.method_0(graphics, new Rectangle(rect.X, rect.Y + (rect.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
					rect.X += @class.Int32_0 + 4;
					rect.Width -= @class.Int32_0 + 8;
				}
				if (m_Text != "")
				{
					Class55.smethod_1(graphics, m_Text, val, foreColor, rect, method_23());
					rectangle = rect;
				}
			}
			else
			{
				int num = 26;
				if (@class != null)
				{
					num = @class.Int32_0 + 4;
				}
				if (num >= m_Rect.Width)
				{
					num = 0;
				}
				rect.Offset(num, 0);
				rect.Width -= num;
				if (!itemStyle_0.BackColor1.IsEmpty || itemStyle_0.BackgroundImage != null)
				{
					itemStyle_0.Paint(graphics, rect);
				}
				rect = rectangle_1;
				rect.Offset(m_Rect.Location);
				if (num > 0)
				{
					Rectangle r = new Rectangle(rect.X, rect.Y, num + 1, rect.Height);
					rect.Offset(num + 1, 0);
					rect.Width -= num + 1;
					if (itemStyle_4 != null)
					{
						ItemStyle itemStyle = itemStyle_4.Clone() as ItemStyle;
						if (bool_24 && !Expanded)
						{
							itemStyle.method_0(itemStyle_6);
						}
						else if (bool_23 && !Expanded)
						{
							itemStyle.method_0(itemStyle_5);
						}
						itemStyle.Paint(graphics, r);
						@class?.method_0(graphics, new Rectangle(r.X + (r.Width - @class.Int32_0) / 2, r.Y + (r.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
					}
				}
				if (itemStyle_1 != null)
				{
					ItemStyle itemStyle2 = itemStyle_1.Clone() as ItemStyle;
					if (bool_24 && !Expanded)
					{
						itemStyle2.method_0(itemStyle_3);
					}
					else if (bool_23 && !Expanded)
					{
						itemStyle2.method_0(itemStyle_2);
					}
					else if (Expanded && !itemStyle_0.ForeColor.IsEmpty)
					{
						itemStyle2.ForeColor.Color = itemStyle_0.ForeColor.Color;
					}
					rectangle = rect;
					rectangle.Offset(4, 0);
					rectangle.Width -= 4;
					if (Expanded)
					{
						itemStyle2.PaintText(graphics, m_Text, rectangle, val);
					}
					else
					{
						itemStyle2.Paint(graphics, rect, m_Text, rectangle, val);
					}
				}
			}
			@class = null;
			if (Focused)
			{
				if (DesignMode)
				{
					Rectangle rectangle2 = rectangle_1;
					rectangle2.Offset(m_Rect.X, m_Rect.Y);
					rectangle2.Inflate(-2, -2);
					Class32.smethod_0(graphics, rectangle2, pa.Colors.ItemDesignTimeBorder);
				}
				else if (!rectangle.IsEmpty)
				{
					Rectangle rectangle3 = rectangle;
					ControlPaint.DrawFocusRectangle(graphics, rectangle3);
				}
			}
		}
		if (Expanded && m_SubItems != null && sideBarPanelControlHost_0 == null)
		{
			rect = new Rectangle(m_Rect.X, m_Rect.Y + rect.Height + 1, m_Rect.Width, m_Rect.Height - rect.Height - 1);
			graphics.SetClip(rect);
			for (int i = int_6; i < m_SubItems.Count; i++)
			{
				BaseItem baseItem = m_SubItems[i];
				if (!baseItem.Displayed || !baseItem.Visible)
				{
					continue;
				}
				if (baseItem.BeginGroup && eSideBarLayoutType_0 == eSideBarLayoutType.Default)
				{
					Color color2 = SystemColors.ControlDark;
					if (itemStyle_1 != null && !itemStyle_1.BorderColor.IsEmpty)
					{
						color2 = itemStyle_1.BorderColor.Color;
					}
					Pen val3 = new Pen(color2, 1f);
					try
					{
						graphics.DrawLine(val3, baseItem.LeftInternal + 2, baseItem.TopInternal - 2, baseItem.DisplayRectangle.Right - 4, baseItem.TopInternal - 2);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				baseItem.Paint(pa);
			}
			graphics.ResetClip();
		}
		if (sideBarPanelControlHost_0 == null)
		{
			if (int_6 > 0 && bool_30)
			{
				if (Style == eDotNetBarStyle.Office2007)
				{
					Office2007SideBarColorTable sideBar = ((Office2007Renderer)pa.BaseRenderer_0).ColorTable.SideBar;
					GradientColorTable sideBarPanelItemDefault = sideBar.SideBarPanelItemDefault;
					if (sideBarPanelItemDefault != null)
					{
						ref Rectangle reference = ref rectangle_0[0];
						reference = new Rectangle(rect.Right - 18, rect.Top + 4, 16, 16);
						Brush val4 = Class50.smethod_45(rect, sideBarPanelItemDefault);
						try
						{
							graphics.FillRectangle(val4, rectangle_0[0]);
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
						Class50.smethod_6(graphics, sideBar.Border, rectangle_0[0]);
						method_22(graphics, rectangle_0[0], sideBar.SideBarPanelItemText, bool_31: true);
					}
				}
				else if (eSideBarAppearance_0 != 0 && itemStyle_1 != null)
				{
					ref Rectangle reference2 = ref rectangle_0[0];
					reference2 = new Rectangle(rect.Right - 16, rect.Top + 2, 14, 14);
					ItemStyle itemStyle3 = itemStyle_1.Clone() as ItemStyle;
					itemStyle3.BorderSide = eBorderSide.All;
					itemStyle3.Paint(graphics, rectangle_0[0]);
					method_22(graphics, rectangle_0[0], SystemColors.ControlText, bool_31: true);
				}
				else
				{
					ref Rectangle reference3 = ref rectangle_0[0];
					reference3 = new Rectangle(rect.Right - 18, rect.Top + 4, 16, 16);
					Class109.smethod_37(graphics, rectangle_0[0], (Border3DStyle)5);
					method_22(graphics, rectangle_0[0], SystemColors.ControlText, bool_31: true);
				}
			}
			else
			{
				ref Rectangle reference4 = ref rectangle_0[0];
				reference4 = Rectangle.Empty;
			}
			if (bool_22)
			{
				if (Style == eDotNetBarStyle.Office2007)
				{
					Office2007SideBarColorTable sideBar2 = ((Office2007Renderer)pa.BaseRenderer_0).ColorTable.SideBar;
					GradientColorTable sideBarPanelItemDefault2 = sideBar2.SideBarPanelItemDefault;
					if (sideBarPanelItemDefault2 != null)
					{
						ref Rectangle reference5 = ref rectangle_0[1];
						reference5 = new Rectangle(m_Rect.Right - 18, m_Rect.Bottom - 18, 16, 16);
						Brush val5 = Class50.smethod_45(rect, sideBarPanelItemDefault2);
						try
						{
							graphics.FillRectangle(val5, rectangle_0[1]);
						}
						finally
						{
							((IDisposable)val5)?.Dispose();
						}
						Class50.smethod_6(graphics, sideBar2.Border, rectangle_0[1]);
						method_22(graphics, rectangle_0[1], sideBar2.SideBarPanelItemText, bool_31: false);
					}
				}
				else if (eSideBarAppearance_0 != 0 && itemStyle_1 != null)
				{
					ref Rectangle reference6 = ref rectangle_0[1];
					reference6 = new Rectangle(m_Rect.Right - 16, m_Rect.Bottom - 16, 14, 14);
					ItemStyle itemStyle4 = itemStyle_1.Clone() as ItemStyle;
					itemStyle4.BorderSide = eBorderSide.All;
					itemStyle4.Paint(graphics, rectangle_0[1]);
					method_22(graphics, rectangle_0[1], SystemColors.ControlText, bool_31: false);
				}
				else
				{
					ref Rectangle reference7 = ref rectangle_0[1];
					reference7 = new Rectangle(m_Rect.Right - 18, m_Rect.Bottom - 18, 16, 16);
					Class109.smethod_37(graphics, rectangle_0[1], (Border3DStyle)5);
					method_22(graphics, rectangle_0[1], SystemColors.ControlText, bool_31: false);
				}
			}
			else
			{
				ref Rectangle reference8 = ref rectangle_0[1];
				reference8 = Rectangle.Empty;
			}
		}
		if (bool_28)
		{
			pa.ButtonStringFormat |= eTextFormat.SingleLine;
		}
		method_20(pa);
		itemPaintArgs_0 = null;
	}

	private void method_19(ItemPaintArgs itemPaintArgs_1)
	{
		if (SuspendLayout)
		{
			return;
		}
		Graphics graphics = itemPaintArgs_1.Graphics;
		if (m_NeedRecalcSize)
		{
			RecalcSize();
		}
		Class65 class65_ = itemPaintArgs_1.Class65_0;
		Rectangle clip = rectangle_1;
		clip.Offset(m_Rect.X, m_Rect.Y);
		Font font_ = vmethod_1();
		Class125 class125_ = Class125.class125_1;
		Class148 class148_ = Class148.class148_0;
		if (m_Text != "")
		{
			if (bool_24)
			{
				class148_ = Class148.class148_2;
				class125_ = Class125.class125_0;
			}
			else if (bool_23)
			{
				class148_ = Class148.class148_1;
				class125_ = Class125.class125_0;
			}
			class65_.method_0(graphics, class125_, class148_, clip);
		}
		Class271 @class = method_34();
		clip.Inflate(-2, -2);
		if (@class != null)
		{
			clip.X += 2;
			clip.Width -= 2;
			@class.method_0(graphics, new Rectangle(clip.X, clip.Y + (clip.Height - @class.Int32_1) / 2, @class.Int32_0, @class.Int32_1));
			clip.X += @class.Int32_0 + 4;
			clip.Width -= @class.Int32_0 + 4;
			clip.Inflate(0, -2);
		}
		if (m_Text != "")
		{
			class65_.method_1(graphics, m_Text, font_, clip, class125_, class148_, (Enum10)32773, !m_Enabled);
		}
		if (DesignMode && Focused)
		{
			Rectangle rectangle = rectangle_1;
			rectangle.Offset(m_Rect.X, m_Rect.Y);
			rectangle.Inflate(-2, -2);
			Class32.smethod_0(graphics, rectangle, itemPaintArgs_1.Colors.ItemDesignTimeBorder);
		}
		if (Expanded && m_SubItems != null && sideBarPanelControlHost_0 == null)
		{
			clip = new Rectangle(m_Rect.X, m_Rect.Y + clip.Height + 1, m_Rect.Width, m_Rect.Height - clip.Height - 1);
			graphics.SetClip(clip);
			IntPtr hdc = graphics.GetHdc();
			int num = 0;
			try
			{
				num = Class92.CreateRectRgn(clip.Left, clip.Top, clip.Right, clip.Bottom);
				if (num != 0)
				{
					Class92.SelectClipRgn(hdc, num);
				}
			}
			finally
			{
				graphics.ReleaseHdc(hdc);
			}
			for (int i = int_6; i < m_SubItems.Count; i++)
			{
				BaseItem baseItem = m_SubItems[i];
				if (baseItem.Displayed && baseItem.Visible)
				{
					baseItem.Paint(itemPaintArgs_1);
				}
			}
			graphics.ResetClip();
			if (num != 0)
			{
				hdc = graphics.GetHdc();
				try
				{
					Class92.SelectClipRgn(hdc, 0);
					Class51.DeleteObject(num);
				}
				finally
				{
					graphics.ReleaseHdc(hdc);
				}
			}
		}
		if (sideBarPanelControlHost_0 == null)
		{
			if (int_6 > 0)
			{
				Class63 class63_ = itemPaintArgs_1.Class63_0;
				ref Rectangle reference = ref rectangle_0[0];
				reference = new Rectangle(clip.Right - 17, clip.Top + 4, 17, 16);
				class63_.method_0(graphics, Class138.class138_0, Class163.class163_0, rectangle_0[0]);
			}
			else
			{
				ref Rectangle reference2 = ref rectangle_0[0];
				reference2 = Rectangle.Empty;
			}
			if (bool_22)
			{
				Class63 class63_2 = itemPaintArgs_1.Class63_0;
				ref Rectangle reference3 = ref rectangle_0[1];
				reference3 = new Rectangle(m_Rect.Right - 17, m_Rect.Bottom - 18, 17, 16);
				class63_2.method_0(graphics, Class138.class138_0, Class163.class163_4, rectangle_0[1]);
			}
			else
			{
				ref Rectangle reference4 = ref rectangle_0[1];
				reference4 = Rectangle.Empty;
			}
		}
		method_20(itemPaintArgs_1);
	}

	private void method_20(ItemPaintArgs itemPaintArgs_1)
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		if (m_SubItems == null || m_SubItems.Count != 0 || !DesignMode || !Expanded)
		{
			return;
		}
		Rectangle rect = m_Rect;
		if (!rectangle_1.IsEmpty)
		{
			rect.Y += rectangle_1.Height;
			rect.Height -= rectangle_1.Height;
		}
		string text = "Right-click header and choose Add New Button or use SubItems collection to create new buttons.";
		rect.Inflate(-1, -1);
		if (eSideBarAppearance_0 == eSideBarAppearance.Flat)
		{
			Class271 @class = method_34();
			int num = 26;
			if (@class != null)
			{
				num = @class.Int32_0 + 4;
			}
			if (num >= m_Rect.Width)
			{
				num = 0;
			}
			rect.Offset(num, 0);
			rect.Width -= num;
		}
		Font val = vmethod_1();
		if (val != null)
		{
			Font val2 = new Font(val.get_FontFamily(), val.get_Size() - 1f);
			try
			{
				Class55.smethod_1(itemPaintArgs_1.Graphics, text, val2, SystemColors.ControlDark, rect, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
			}
			finally
			{
				val2.Dispose();
			}
		}
	}

	private void method_21()
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
			Class63 @class = null;
			bool flag = false;
			if (val is Interface6)
			{
				@class = ((Interface6)val).Class63_0;
			}
			else if (val is Bar)
			{
				@class = ((Bar)(object)val).Class63_0;
			}
			else
			{
				flag = true;
				@class = new Class63(val);
			}
			Class138 class138_ = Class138.class138_0;
			Class163 class163_ = Class163.class163_0;
			if (int_6 > 0)
			{
				if (int_7 == 0)
				{
					class163_ = Class163.class163_1;
				}
				@class.method_0(val2, class138_, class163_, rectangle_0[0]);
			}
			if (bool_22)
			{
				class163_ = Class163.class163_4;
				if (int_7 == 1)
				{
					class163_ = Class163.class163_5;
				}
				@class.method_0(val2, class138_, class163_, rectangle_0[1]);
			}
			if (flag)
			{
				@class.Dispose();
			}
		}
		finally
		{
			if (val2 != null)
			{
				val2.Dispose();
			}
		}
	}

	public override void SubItemSizeChanged(BaseItem objChildItem)
	{
		NeedRecalcSize = true;
	}

	private void method_22(Graphics graphics_0, Rectangle rectangle_3, Color color_2, bool bool_31)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		Point[] array = new Point[3];
		if (bool_31)
		{
			array[0].X = rectangle_3.Left + (rectangle_3.Width - 9) / 2;
			array[0].Y = rectangle_3.Top + rectangle_3.Height / 2 + 1;
			array[1].X = array[0].X + 8;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 4;
			array[2].Y = array[0].Y - 5;
		}
		else
		{
			array[0].X = rectangle_3.Left + (rectangle_3.Width - 7) / 2;
			array[0].Y = rectangle_3.Top + (rectangle_3.Height - 4) / 2;
			array[1].X = array[0].X + 7;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y + 4;
		}
		graphics_0.FillPolygon((Brush)new SolidBrush(color_2), array);
	}

	internal virtual Font vmethod_1()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		Font val = SystemInformation.get_MenuFont();
		object containerControl = ContainerControl;
		Control val2 = (Control)((containerControl is Control) ? containerControl : null);
		if (val2 != null)
		{
			val = val2.get_Font();
		}
		if (bool_23 && (bool_26 || bool_25))
		{
			FontStyle val3 = (FontStyle)0;
			if (bool_26)
			{
				val3 = (FontStyle)(val3 | 1);
			}
			if (bool_25)
			{
				val3 = (FontStyle)(val3 | 4);
			}
			try
			{
				return new Font(val, val3);
			}
			catch
			{
				object obj = SystemInformation.get_MenuFont().Clone();
				return (Font)((obj is Font) ? obj : null);
			}
		}
		if (bool_27)
		{
			FontStyle style = val.get_Style();
			style = (FontStyle)(style | 1);
			try
			{
				return new Font(val, style);
			}
			catch
			{
				object obj3 = SystemInformation.get_MenuFont().Clone();
				return (Font)((obj3 is Font) ? obj3 : null);
			}
		}
		return val;
	}

	internal eTextFormat method_23()
	{
		eTextFormat eTextFormat2 = eTextFormat.EndEllipsis | eTextFormat.ExternalLeading | eTextFormat.VerticalCenter;
		if (eStyleTextAlignment_0 == eStyleTextAlignment.Center)
		{
			eTextFormat2 |= eTextFormat.HorizontalCenter;
		}
		else if (eStyleTextAlignment_0 == eStyleTextAlignment.Far)
		{
			eTextFormat2 |= eTextFormat.Right;
		}
		if (!bool_28)
		{
			return eTextFormat2 | eTextFormat.SingleLine;
		}
		return eTextFormat2 | eTextFormat.WordBreak;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() == 1048576 && (Math.Abs(objArg.get_X() - point_2.X) >= 4 || Math.Abs(objArg.get_Y() - point_2.Y) >= 4) && ContainerControl is SideBar sideBar && sideBar.AllowUserCustomize && CanCustomize)
		{
			BaseItem hotSubItem = m_HotSubItem;
			if (hotSubItem != null && hotSubItem.CanCustomize && !hotSubItem.SystemItem && GetOwner() is IOwner owner && owner.DragItem == null)
			{
				owner.StartItemDrag(hotSubItem);
				return;
			}
		}
		bool flag = false;
		if (!rectangle_0[0].Contains(objArg.get_X(), objArg.get_Y()) && !rectangle_0[1].Contains(objArg.get_X(), objArg.get_Y()))
		{
			if (int_7 >= 0)
			{
				int_7 = -1;
				flag = true;
			}
			if (sideBarPanelControlHost_0 != null)
			{
				m_IsContainer = false;
				base.InternalMouseMove(objArg);
				m_IsContainer = true;
			}
			else
			{
				base.InternalMouseMove(objArg);
			}
			Rectangle rectangle = rectangle_1;
			rectangle.Offset(m_Rect.Location);
			if (rectangle.Contains(objArg.get_X(), objArg.get_Y()))
			{
				bool_23 = true;
				Refresh();
			}
			else if (bool_23)
			{
				bool_23 = false;
				Refresh();
			}
			else if (flag && base.Boolean_2)
			{
				method_21();
			}
		}
		else
		{
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseLeave();
				m_HotSubItem = null;
			}
			if (rectangle_0[0].Contains(objArg.get_X(), objArg.get_Y()))
			{
				int_7 = 0;
			}
			else
			{
				int_7 = 1;
			}
			if (base.Boolean_2)
			{
				method_21();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		bool_23 = false;
		bool_24 = false;
		if (int_7 >= 0)
		{
			int_7 = -1;
		}
		Refresh();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Invalid comparison between Unknown and I4
		Rectangle rectangle = rectangle_1;
		rectangle.Offset(m_Rect.Location);
		point_2 = new Point(objArg.get_X(), objArg.get_Y());
		if (DesignMode)
		{
			if (ItemAtLocation(objArg.get_X(), objArg.get_Y()) == null && !rectangle.Contains(objArg.get_X(), objArg.get_Y()) && Expanded)
			{
				if (GetOwner() is IOwner owner)
				{
					owner.SetFocusItem(null);
				}
			}
			else if (!rectangle.Contains(objArg.get_X(), objArg.get_Y()))
			{
				base.InternalMouseDown(objArg);
			}
			return;
		}
		if ((int)objArg.get_Button() == 1048576 && rectangle_0[0].Contains(objArg.get_X(), objArg.get_Y()))
		{
			method_24(bool_31: true);
			return;
		}
		if ((int)objArg.get_Button() == 1048576 && rectangle_0[1].Contains(objArg.get_X(), objArg.get_Y()))
		{
			method_24(bool_31: false);
			return;
		}
		if ((int)objArg.get_Button() == 1048576 && rectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			bool_24 = true;
			Refresh();
		}
		if (dateTime_0 != DateTime.MinValue)
		{
			if (DateTime.Now.Subtract(dateTime_0).TotalMilliseconds < 1000.0 && rectangle_2.Contains(objArg.get_X(), objArg.get_Y()))
			{
				return;
			}
			dateTime_0 = DateTime.MinValue;
		}
		base.InternalMouseDown(objArg);
	}

	internal void method_24(bool bool_31)
	{
		if (bool_31)
		{
			if (int_6 > 0)
			{
				rectangle_2 = rectangle_0[0];
				if (eSideBarLayoutType_0 == eSideBarLayoutType.MultiColumn)
				{
					while (int_6 > 0)
					{
						int_6--;
						if (SubItems[int_6].Visible)
						{
							break;
						}
					}
				}
				else
				{
					int_6--;
				}
				NeedRecalcSize = true;
				Refresh();
				bool_29 = true;
			}
		}
		else
		{
			rectangle_2 = rectangle_0[1];
			if (eSideBarLayoutType_0 == eSideBarLayoutType.MultiColumn)
			{
				int topInternal = SubItems[int_6].TopInternal;
				while (int_6 < SubItems.Count)
				{
					int_6++;
					if (SubItems[int_6].Visible && SubItems[int_6].TopInternal > topInternal)
					{
						break;
					}
				}
			}
			else
			{
				int_6++;
			}
			NeedRecalcSize = true;
			Refresh();
			bool_29 = true;
		}
		if (sideBarPanelControlHost_0 != null)
		{
			((Control)sideBarPanelControlHost_0).Refresh();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() == 1048576)
		{
			bool_24 = false;
			Refresh();
		}
		if (bool_29)
		{
			bool_29 = false;
			dateTime_0 = DateTime.Now;
		}
		else if (dateTime_0 != DateTime.MinValue)
		{
			return;
		}
		Rectangle rectangle = rectangle_1;
		rectangle.Offset(m_Rect.Location);
		base.InternalMouseUp(objArg);
		if ((!(GetOwner() is IOwner) || !((IOwner)GetOwner()).DragInProgress) && !Expanded && (int)objArg.get_Button() == 1048576 && rectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			Expanded = true;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalClick(MouseButtons mb, Point mpos)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		base.InternalClick(mb, mpos);
	}

	protected internal override void OnExpandChange()
	{
		base.OnExpandChange();
		int_6 = 0;
	}

	public void ResetBackgroundStyle()
	{
		method_25(new ItemStyle());
	}

	internal void method_25(ItemStyle itemStyle_7)
	{
		if (itemStyle_0 != null)
		{
			itemStyle_0.Event_0 -= method_17;
		}
		itemStyle_0 = itemStyle_7;
		if (itemStyle_0 != null)
		{
			itemStyle_0.Event_0 += method_17;
		}
	}

	public void ResetHeaderStyle()
	{
		method_26(null);
	}

	internal void method_26(ItemStyle itemStyle_7)
	{
		if (itemStyle_1 != null)
		{
			itemStyle_1.Event_0 -= method_17;
		}
		itemStyle_1 = itemStyle_7;
		if (itemStyle_1 != null)
		{
			itemStyle_1.Event_0 += method_17;
		}
	}

	public void ResetHeaderHotStyle()
	{
		method_27(null);
	}

	internal void method_27(ItemStyle itemStyle_7)
	{
		if (itemStyle_2 != null)
		{
			itemStyle_2.Event_0 -= method_17;
		}
		itemStyle_2 = itemStyle_7;
		if (itemStyle_2 != null)
		{
			itemStyle_2.Event_0 += method_17;
		}
	}

	public void ResetHeaderMouseDownStyle()
	{
		method_28(null);
	}

	internal void method_28(ItemStyle itemStyle_7)
	{
		if (itemStyle_3 != null)
		{
			itemStyle_3.Event_0 -= method_17;
		}
		itemStyle_3 = itemStyle_7;
		if (itemStyle_3 != null)
		{
			itemStyle_3.Event_0 += method_17;
		}
	}

	public void ResetHeaderSideStyle()
	{
		method_29(null);
	}

	internal void method_29(ItemStyle itemStyle_7)
	{
		if (itemStyle_4 != null)
		{
			itemStyle_4.Event_0 -= method_17;
		}
		itemStyle_4 = itemStyle_7;
		if (itemStyle_4 != null)
		{
			itemStyle_4.Event_0 += method_17;
		}
	}

	public void ResetHeaderSideHotStyle()
	{
		method_30(null);
	}

	internal void method_30(ItemStyle itemStyle_7)
	{
		if (itemStyle_5 != null)
		{
			itemStyle_5.Event_0 -= method_17;
		}
		itemStyle_5 = itemStyle_7;
		if (itemStyle_5 != null)
		{
			itemStyle_5.Event_0 += method_17;
		}
	}

	public void ResetHeaderSideMouseDownStyle()
	{
		method_31(null);
	}

	internal void method_31(ItemStyle itemStyle_7)
	{
		if (itemStyle_6 != null)
		{
			itemStyle_6.Event_0 -= method_17;
		}
		itemStyle_6 = itemStyle_7;
		if (itemStyle_6 != null)
		{
			itemStyle_6.Event_0 += method_17;
		}
	}

	public bool ShouldSerializeHotForeColor()
	{
		if (color_1 != Color.Empty)
		{
			return true;
		}
		return false;
	}

	public bool ShouldSerializeForeColor()
	{
		if (color_0 != SystemColors.ControlText)
		{
			return true;
		}
		return false;
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		if (color_0 != SystemColors.ControlText)
		{
			itemXmlElement.SetAttribute("forecolor", Class109.smethod_50(color_0));
		}
		if (bool_26)
		{
			itemXmlElement.SetAttribute("hotfb", XmlConvert.ToString(bool_26));
		}
		if (bool_25)
		{
			itemXmlElement.SetAttribute("hotfu", XmlConvert.ToString(bool_25));
		}
		if (!color_1.IsEmpty)
		{
			itemXmlElement.SetAttribute("hotclr", Class109.smethod_50(color_1));
		}
		if (eBarImageSize_0 != 0)
		{
			itemXmlElement.SetAttribute("itemimagesize", XmlConvert.ToString((int)eBarImageSize_0));
		}
		if (!bool_30)
		{
			itemXmlElement.SetAttribute("enablescrollbuttons", XmlConvert.ToString(bool_30));
		}
		XmlElement xmlElement = null;
		XmlElement xmlElement2 = null;
		if (image_0 != null || int_9 >= 0 || image_1 != null || int_10 >= 0 || image_2 != null || int_11 >= 0 || icon_0 != null)
		{
			xmlElement = itemXmlElement.OwnerDocument.CreateElement("images");
			itemXmlElement.AppendChild(xmlElement);
			if (int_9 >= 0)
			{
				xmlElement.SetAttribute("imageindex", XmlConvert.ToString(int_9));
			}
			if (int_10 >= 0)
			{
				xmlElement.SetAttribute("hoverimageindex", XmlConvert.ToString(int_10));
			}
			if (int_11 >= 0)
			{
				xmlElement.SetAttribute("pressedimageindex", XmlConvert.ToString(int_11));
			}
			if (image_0 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "default");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_0, xmlElement2);
			}
			if (image_1 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "hover");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_1, xmlElement2);
			}
			if (image_2 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "pressed");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_2, xmlElement2);
			}
			if (icon_0 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "icon");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_14(icon_0, xmlElement2);
			}
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		if (itemXmlElement.HasAttribute("forecolor"))
		{
			color_0 = Class109.smethod_51(itemXmlElement.GetAttribute("forecolor"));
		}
		else
		{
			color_0 = SystemColors.ControlText;
		}
		if (itemXmlElement.HasAttribute("hotclr"))
		{
			color_1 = Class109.smethod_51(itemXmlElement.GetAttribute("hotclr"));
		}
		else
		{
			color_1 = Color.Empty;
		}
		if (itemXmlElement.HasAttribute("hotfb"))
		{
			bool_26 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("hotfb"));
		}
		else
		{
			bool_26 = false;
		}
		if (itemXmlElement.HasAttribute("hotfu"))
		{
			bool_25 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("hotfu"));
		}
		else
		{
			bool_25 = false;
		}
		if (itemXmlElement.HasAttribute("itemimagesize"))
		{
			eBarImageSize_0 = (eBarImageSize)XmlConvert.ToInt32(itemXmlElement.GetAttribute("itemimagesize"));
		}
		else
		{
			eBarImageSize_0 = eBarImageSize.Default;
		}
		if (itemXmlElement.HasAttribute("enablescrollbuttons"))
		{
			bool_30 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("enablescrollbuttons"));
		}
		else
		{
			bool_30 = true;
		}
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			if (!(childNode.Name == "images"))
			{
				continue;
			}
			if (childNode.HasAttribute("imageindex"))
			{
				int_9 = XmlConvert.ToInt32(childNode.GetAttribute("imageindex"));
			}
			if (childNode.HasAttribute("hoverimageindex"))
			{
				int_10 = XmlConvert.ToInt32(childNode.GetAttribute("hoverimageindex"));
			}
			if (childNode.HasAttribute("pressedimageindex"))
			{
				int_11 = XmlConvert.ToInt32(childNode.GetAttribute("pressedimageindex"));
			}
			foreach (XmlElement childNode2 in childNode.ChildNodes)
			{
				switch (childNode2.GetAttribute("type"))
				{
				case "pressed":
					image_2 = Class109.smethod_16(childNode2);
					int_11 = -1;
					break;
				case "hover":
					image_1 = Class109.smethod_16(childNode2);
					int_10 = -1;
					break;
				case "icon":
					icon_0 = Class109.smethod_17(childNode2);
					int_9 = -1;
					break;
				case "default":
					image_0 = Class109.smethod_16(childNode2);
					int_9 = -1;
					break;
				}
			}
			break;
		}
		RefreshImageSize();
		NeedRecalcSize = true;
	}

	protected internal override void OnItemAdded(BaseItem item)
	{
		NeedRecalcSize = true;
		if (item.IsWindowed && !DesignMode)
		{
			method_32();
		}
		base.OnItemAdded(item);
		if (!Expanded)
		{
			if (!item.Displayed)
			{
				item.Displayed = true;
			}
			item.Displayed = false;
		}
		if (sideBarPanelControlHost_0 != null)
		{
			item.ContainerControl = sideBarPanelControlHost_0;
		}
		if (item is ButtonItem)
		{
			((ButtonItem)item).bool_36 = bool_28;
		}
	}

	protected internal override void OnBeforeItemRemoved(BaseItem item)
	{
		if (item is ButtonItem)
		{
			((ButtonItem)item).bool_36 = false;
		}
		base.OnBeforeItemRemoved(item);
	}

	private void method_32()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null && sideBarPanelControlHost_0 == null)
		{
			sideBarPanelControlHost_0 = new SideBarPanelControlHost(this);
			((Control)sideBarPanelControlHost_0).set_Visible(false);
			val.get_Controls().Add((Control)(object)sideBarPanelControlHost_0);
		}
	}

	public override void ShowToolTip()
	{
		if (DesignMode || !Visible || !Displayed)
		{
			return;
		}
		IOwner owner = GetOwner() as IOwner;
		if (owner != null && !owner.ShowToolTips)
		{
			return;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == null || !rectangle_1.Contains(val.PointToClient(Control.get_MousePosition())))
		{
			return;
		}
		OnTooltip(bShow: true);
		if (m_Tooltip != "")
		{
			if (m_ToolTipWnd == null)
			{
				m_ToolTipWnd = new ToolTip();
			}
			m_ToolTipWnd.Text = m_Tooltip;
			if (owner != null && owner.ShowShortcutKeysInToolTips && Shortcuts.Count > 0)
			{
				ToolTip toolTipWnd = m_ToolTipWnd;
				toolTipWnd.Text = toolTipWnd.Text + " (" + base.ShortcutString + ")";
			}
			GetIOwnerItemEvents()?.InvokeToolTipShowing(this, new EventArgs());
			m_ToolTipWnd.ShowToolTip();
		}
	}

	public override void Refresh()
	{
		if (SuspendLayout)
		{
			return;
		}
		if (sideBarPanelControlHost_0 != null && Expanded)
		{
			if ((!Visible && !base.IsOnCustomizeMenu) || !Displayed)
			{
				return;
			}
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val == null || !BaseItem.IsHandleValid(val) || val is Class83)
			{
				return;
			}
			if (m_NeedRecalcSize)
			{
				RecalcSize();
				if (m_Parent != null)
				{
					m_Parent.SubItemSizeChanged(this);
				}
			}
			Rectangle rectangle = rectangle_1;
			rectangle.Inflate(4, 4);
			val.Invalidate(m_Rect, false);
		}
		else
		{
			base.Refresh();
		}
	}

	internal void method_33(int int_12)
	{
		int_9 = int_12;
	}

	internal Class271 method_34()
	{
		if (bool_24)
		{
			return method_35(Enum15.const_3);
		}
		if (bool_23)
		{
			return method_35(Enum15.const_2);
		}
		return method_35(Enum15.const_0);
	}

	private Class271 method_35(Enum15 enum15_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Image val = null;
		if (icon_0 != null)
		{
			Size size = Size_0;
			Icon val2 = null;
			try
			{
				val2 = new Icon(icon_0, size);
			}
			catch
			{
				val2 = null;
			}
			if (val2 == null)
			{
				return new Class271(icon_0, dispose: false);
			}
			return new Class271(val2, dispose: true);
		}
		if (enum15_0 == Enum15.const_2 && (image_1 != null || int_10 >= 0))
		{
			if (image_1 != null)
			{
				return new Class271(image_1, dispose: false);
			}
			if (int_10 >= 0)
			{
				val = method_36(int_10);
				if (val != null)
				{
					return new Class271(val, dispose: false);
				}
				return null;
			}
		}
		if (enum15_0 == Enum15.const_3 && (image_2 != null || int_11 >= 0))
		{
			if (image_2 != null)
			{
				return new Class271(image_2, dispose: false);
			}
			if (int_11 >= 0)
			{
				val = method_36(int_11);
				if (val != null)
				{
					return new Class271(val, dispose: false);
				}
				return null;
			}
		}
		if (image_0 != null)
		{
			return new Class271(image_0, dispose: false);
		}
		if (int_9 >= 0)
		{
			val = method_36(int_9);
			if (val != null)
			{
				return new Class271(val, dispose: false);
			}
		}
		return null;
	}

	private Image method_36(int int_12)
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
							if (int_12 == int_9)
							{
								if (image_3 == null)
								{
									image_3 = owner.Images.get_Images().get_Item(int_12);
								}
								return image_3;
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
						if (int_12 == int_9)
						{
							if (image_3 == null)
							{
								image_3 = owner.Images.get_Images().get_Item(int_12);
							}
							return image_3;
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

	InsertPosition IDesignTimeProvider.GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		InsertPosition insertPosition = null;
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val != null && CanCustomize)
		{
			Point pt = val.PointToClient(pScreen);
			Rectangle displayRectangle = DisplayRectangle;
			if (displayRectangle.Contains(pt))
			{
				Rectangle rectangle = displayRectangle;
				rectangle.Size = rectangle_1.Size;
				rectangle.X += rectangle_1.Left;
				rectangle.Y += rectangle_1.Top;
				if (rectangle.Contains(pt) && !Expanded)
				{
					Expanded = true;
					insertPosition = new InsertPosition();
					insertPosition.TargetProvider = this;
					if (SubItems.Count == 0)
					{
						insertPosition.Position = -1;
					}
					else
					{
						insertPosition.Position = 0;
						insertPosition.Before = true;
					}
					return insertPosition;
				}
				BaseItem baseItem = ExpandedItem();
				if (baseItem != null && baseItem is IDesignTimeProvider designTimeProvider)
				{
					insertPosition = designTimeProvider.GetInsertPosition(pScreen, DragItem);
					if (insertPosition != null)
					{
						return insertPosition;
					}
				}
				for (int i = 0; i < SubItems.Count; i++)
				{
					baseItem = SubItems[i];
					rectangle = baseItem.DisplayRectangle;
					rectangle.Inflate(2, 2);
					if (!baseItem.Visible || !baseItem.Displayed || !rectangle.Contains(pt))
					{
						continue;
					}
					if (baseItem.SystemItem && SubItems.Count != 1)
					{
						return null;
					}
					if (baseItem == DragItem)
					{
						return new InsertPosition();
					}
					insertPosition = new InsertPosition();
					insertPosition.TargetProvider = this;
					insertPosition.Position = i;
					if (pt.Y <= baseItem.TopInternal + baseItem.HeightInternal / 2 || baseItem.SystemItem)
					{
						insertPosition.Before = true;
					}
					if (GetOwner() is IOwner owner)
					{
						BaseItem baseItem2 = owner.GetExpandedItem();
						if (baseItem2 != null)
						{
							while (baseItem2.Parent != null)
							{
								baseItem2 = baseItem2.Parent;
							}
							BaseItem baseItem3 = baseItem;
							while (baseItem3.Parent != null)
							{
								baseItem3 = baseItem3.Parent;
							}
							if (baseItem2 != baseItem3)
							{
								owner.SetExpandedItem(null);
							}
						}
					}
					if (baseItem is PopupItem && (baseItem.SubItems.Count > 0 || baseItem.IsOnMenuBar))
					{
						if (!baseItem.Expanded)
						{
							baseItem.Expanded = true;
						}
					}
					else
					{
						BaseItem.CollapseSubItems(this);
					}
					break;
				}
				if (insertPosition == null)
				{
					insertPosition = ((SubItems.Count <= 1 || !SubItems[SubItems.Count - 1].SystemItem) ? new InsertPosition(SubItems.Count - 1, bBefore: false, this) : new InsertPosition(SubItems.Count - 2, bBefore: true, this));
				}
				return insertPosition;
			}
			{
				foreach (BaseItem subItem in SubItems)
				{
					if (subItem != DragItem && subItem is IDesignTimeProvider designTimeProvider2)
					{
						insertPosition = designTimeProvider2.GetInsertPosition(pScreen, DragItem);
						if (insertPosition != null)
						{
							return insertPosition;
						}
					}
				}
				return insertPosition;
			}
		}
		return null;
	}

	void IDesignTimeProvider.DrawReversibleMarker(int iPos, bool Before)
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == null)
		{
			return;
		}
		BaseItem baseItem = null;
		if (iPos >= 0)
		{
			baseItem = SubItems[iPos];
		}
		if (baseItem != null)
		{
			if (baseItem.Enum9_0 != 0)
			{
				baseItem.Enum9_0 = Enum9.const_0;
			}
			else if (Before)
			{
				baseItem.Enum9_0 = Enum9.const_1;
			}
			else
			{
				baseItem.Enum9_0 = Enum9.const_2;
			}
		}
		else
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			displayRectangle.Offset(rectangle_1.X, rectangle_1.Bottom);
			new Rectangle(displayRectangle.Left + 2, displayRectangle.Top + 2, displayRectangle.Width - 4, 1);
			new Rectangle(displayRectangle.Left + 1, displayRectangle.Top, 1, 5);
			new Rectangle(displayRectangle.Right - 2, displayRectangle.Top, 1, 5);
		}
	}

	void IDesignTimeProvider.InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
		if (ExpandedItem() != null)
		{
			ExpandedItem().Expanded = false;
		}
		if (!Before)
		{
			if (iPos + 1 >= SubItems.Count)
			{
				SubItems.Add(objItem, method_37(this));
			}
			else
			{
				SubItems.Add(objItem, iPos + 1);
			}
		}
		else if (iPos >= SubItems.Count)
		{
			SubItems.Add(objItem, method_37(this));
		}
		else
		{
			SubItems.Add(objItem, iPos);
		}
		if (ContainerControl is Bar)
		{
			((Bar)ContainerControl).RecalcLayout();
			return;
		}
		if (ContainerControl is MenuPanel)
		{
			((MenuPanel)ContainerControl).RecalcSize();
			return;
		}
		RecalcSize();
		Refresh();
	}

	private int method_37(BaseItem baseItem_0)
	{
		int result = -1;
		int num = baseItem_0.SubItems.Count - 1;
		while (num >= 0 && baseItem_0.SubItems[num].SystemItem)
		{
			result = num;
			num--;
		}
		return result;
	}
}
