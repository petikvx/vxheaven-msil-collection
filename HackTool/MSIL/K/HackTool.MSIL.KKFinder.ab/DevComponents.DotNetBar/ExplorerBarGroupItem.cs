using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[Designer(typeof(ExplorerBarGroupItemDesigner))]
public class ExplorerBarGroupItem : ImageItem, IDesignTimeProvider
{
	private const int int_4 = 25;

	private const string string_7 = "Right-click header and choose one of Create commands or use SubItems collection to create new buttons. You can also drag & drop controls on this panel.";

	private Rectangle rectangle_0 = Rectangle.Empty;

	private bool bool_22;

	private int int_5 = 2;

	private bool bool_23;

	private bool bool_24;

	private Rectangle rectangle_1 = Rectangle.Empty;

	private ItemStyleMapper itemStyleMapper_0;

	private ItemStyleMapper itemStyleMapper_1;

	private ItemStyleMapper itemStyleMapper_2;

	private ElementStyle elementStyle_0;

	private ElementStyle elementStyle_1;

	private ElementStyle elementStyle_2;

	private eExplorerBarStockStyle eExplorerBarStockStyle_0 = eExplorerBarStockStyle.Custom;

	private bool bool_25 = true;

	private Point point_2;

	private Image image_0;

	private int int_6 = -1;

	private Image image_1;

	private int int_7 = 4;

	private bool bool_26;

	private Color color_0 = Color.DarkGray;

	private Color color_1 = Color.White;

	private Color color_2 = SystemColors.ActiveCaption;

	private Color color_3 = Color.DarkGray;

	private Color color_4 = Color.White;

	private Color color_5 = SystemColors.ActiveCaption;

	private bool bool_27 = true;

	private bool bool_28 = true;

	private bool bool_29 = true;

	private ShadowPaintInfo shadowPaintInfo_0;

	private bool bool_30;

	[Category("Appearance")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(false)]
	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public override bool ThemeAware
	{
		get
		{
			return base.ThemeAware;
		}
		set
		{
			m_ThemeAware = value;
			if (m_SubItems == null)
			{
				return;
			}
			foreach (BaseItem subItem in m_SubItems)
			{
				if (!(subItem is ButtonItem))
				{
					subItem.ThemeAware = value;
				}
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Gets or sets whether expand button is visible.")]
	[DevCoBrowsable(true)]
	public bool ExpandButtonVisible
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Description("Gets or sets a value indicating whether group is expanded or not.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public override bool Expanded
	{
		get
		{
			return base.Expanded;
		}
		set
		{
			base.Expanded = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether drop shadow is displayed when non-themed display is used.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool DropShadow
	{
		get
		{
			return bool_29;
		}
		set
		{
			bool_29 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Description("Gets or sets a normal item style.")]
	public ElementStyle TitleStyle => elementStyle_0;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[Description("Gets or sets a mouse over item style.")]
	public ElementStyle TitleHotStyle => elementStyle_1;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Style")]
	[Description("Gets or sets group background style.")]
	[DevCoBrowsable(true)]
	public ElementStyle BackStyle => elementStyle_2;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("This property is obsolete. Use TitleStyle property instead")]
	[Browsable(false)]
	public ItemStyleMapper HeaderStyle => itemStyleMapper_0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Obsolete("This property is obsolete. Use TitleHotStyle property instead")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ItemStyleMapper HeaderHotStyle => itemStyleMapper_1;

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("This property is obsolete. Use BackStyle property instead")]
	public ItemStyleMapper BackgroundStyle => itemStyleMapper_2;

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Determines whether clicking the header of the control expands the item.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool HeaderExpands
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
		}
	}

	[Description("Applies the stock style to the object.")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(eExplorerBarStockStyle.Custom)]
	[Category("Style")]
	[DevCoBrowsable(true)]
	public eExplorerBarStockStyle StockStyle
	{
		get
		{
			return eExplorerBarStockStyle_0;
		}
		set
		{
			eExplorerBarStockStyle_0 = value;
			if (eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom)
			{
				return;
			}
			Class109.smethod_56(this, eExplorerBarStockStyle_0);
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem is ButtonItem)
				{
					Class109.smethod_57(subItem as ButtonItem, eExplorerBarStockStyle_0);
				}
			}
			if (eExplorerBarStockStyle_0 != eExplorerBarStockStyle.BlueSpecial && eExplorerBarStockStyle_0 != eExplorerBarStockStyle.OliveGreenSpecial && eExplorerBarStockStyle_0 != eExplorerBarStockStyle.SilverSpecial)
			{
				if (eExplorerBarStockStyle_0 != eExplorerBarStockStyle.SystemColors)
				{
					XPSpecialGroup = false;
				}
			}
			else
			{
				XPSpecialGroup = true;
			}
			Refresh();
		}
	}

	[Category("Appearance")]
	[DefaultValue(eDotNetBarStyle.OfficeXP)]
	[Browsable(false)]
	[Description("Determines the display of the item when shown.")]
	[DevCoBrowsable(false)]
	public override eDotNetBarStyle Style
	{
		get
		{
			return base.Style;
		}
		set
		{
			base.Style = value;
		}
	}

	[Browsable(true)]
	[Description("Specifies expand button border color.")]
	[Category("Style")]
	[DevCoBrowsable(true)]
	public Color ExpandBorderColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			OnAppearanceChanged();
		}
	}

	[Category("Style")]
	[Description("Specifies expand button back color.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ExpandBackColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Category("Style")]
	[Description("Specifies expand button fore color.")]
	[Browsable(true)]
	public Color ExpandForeColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("Specifies hot expand button border color.")]
	[Category("Style")]
	[DevCoBrowsable(true)]
	public Color ExpandHotBorderColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			OnAppearanceChanged();
		}
	}

	[Description("Specifies hot expand button back color.")]
	[Category("Style")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ExpandHotBackColor
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			OnAppearanceChanged();
		}
	}

	[Category("Style")]
	[Browsable(true)]
	[Description("Specifies hot expand button fore color.")]
	[DevCoBrowsable(true)]
	public Color ExpandHotForeColor
	{
		get
		{
			return color_5;
		}
		set
		{
			color_5 = value;
			OnAppearanceChanged();
		}
	}

	[DefaultValue(eItemAlignment.Near)]
	[Description("Determines alignment of the item inside the container.")]
	[Browsable(false)]
	[Category("Appearance")]
	[DevCoBrowsable(false)]
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

	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[Browsable(false)]
	[DefaultValue(false)]
	[Description("Indicates whether item will stretch to consume empty space. Items on stretchable, no-wrap Bars only.")]
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

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
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

	[Description("Determines whether sub-items are displayed.")]
	[DevCoBrowsable(false)]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(false)]
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

	[Description("Indicates item category used to group similar items at design-time.")]
	[DevCoBrowsable(false)]
	[Category("Design")]
	[Browsable(false)]
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

	[Category("Design")]
	[Browsable(false)]
	[Description("Indicates description of the item that is displayed during design.")]
	[DefaultValue("")]
	[DevCoBrowsable(false)]
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

	[Category("Appearance")]
	[Browsable(false)]
	[Description("Indicates whether this item is beginning of the group.")]
	[DefaultValue(false)]
	[DevCoBrowsable(false)]
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

	[Description("Indicates whether is item enabled.")]
	[Category("Behavior")]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DefaultValue(true)]
	public override bool Enabled
	{
		get
		{
			return base.Enabled;
		}
		set
		{
			base.Enabled = value;
		}
	}

	[Description("Collection of sub items.")]
	[DevCoBrowsable(false)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Data")]
	[Editor(typeof(ExplorerBarGroupItemEditor), typeof(UITypeEditor))]
	public override SubItemsCollection SubItems => base.SubItems;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public Rectangle PanelRect => rectangle_1;

	internal bool Boolean_3 => base.Boolean_2;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ImageList ImageList
	{
		get
		{
			if (GetOwner() is IOwner owner)
			{
				return owner.ImagesMedium;
			}
			return null;
		}
	}

	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("The image that will be displayed on the face of the item.")]
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
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates whether XP themed special group colors are used for drawing.")]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	public bool XPSpecialGroup
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

	[Browsable(true)]
	[DefaultValue(4)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Indicates margin in pixels between the edge of the container and the items contained inside of it")]
	public int SubItemsMargin
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

	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates whether text on sub items is wrapped on new line if it cannot fit the space available.")]
	public bool WordWrapSubItems
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
			OnAppearanceChanged();
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[Category("Appearance")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Description("The image list image index of the image that will be displayed on the face of the item.")]
	[Browsable(true)]
	public int ImageIndex
	{
		get
		{
			return int_6;
		}
		set
		{
			image_1 = null;
			if (int_6 != value)
			{
				int_6 = value;
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
		}
	}

	public ExplorerBarGroupItem()
		: this("", "")
	{
	}

	public ExplorerBarGroupItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public ExplorerBarGroupItem(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
		m_IsContainer = true;
		m_AllowOnlyOneSubItemExpanded = false;
		elementStyle_0 = new ElementStyle();
		elementStyle_0.StyleChanged += elementStyle_2_StyleChanged;
		elementStyle_1 = new ElementStyle();
		elementStyle_1.StyleChanged += elementStyle_2_StyleChanged;
		elementStyle_2 = new ElementStyle();
		elementStyle_2.StyleChanged += elementStyle_2_StyleChanged;
		itemStyleMapper_0 = new ItemStyleMapper(elementStyle_0);
		itemStyleMapper_1 = new ItemStyleMapper(elementStyle_1);
		itemStyleMapper_2 = new ItemStyleMapper(elementStyle_2);
		SubItemsImageSize = new Size(12, 12);
		ImageSize = new Size(12, 12);
		Class109.smethod_56(this, eExplorerBarStockStyle_0);
	}

	public override BaseItem Copy()
	{
		ExplorerBarGroupItem explorerBarGroupItem = new ExplorerBarGroupItem();
		CopyToItem(explorerBarGroupItem);
		return explorerBarGroupItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		ExplorerBarGroupItem objCopy = copy as ExplorerBarGroupItem;
		base.CopyToItem(objCopy);
	}

	private void elementStyle_2_StyleChanged(object sender, EventArgs e)
	{
		method_17();
	}

	internal void method_17()
	{
		OnAppearanceChanged();
	}

	public override void RecalcSize()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!BaseItem.IsHandleValid(val))
		{
			return;
		}
		Graphics val2 = Graphics.FromHwnd(val.get_Handle());
		SizeF empty = SizeF.Empty;
		Image val3 = method_18();
		string text = m_Text;
		if (text == "")
		{
			text = " ";
		}
		int num = m_Rect.Width - int_5 * 2;
		if (bool_25)
		{
			num -= 25;
		}
		if (val3 != null)
		{
			num -= val3.get_Width() + int_5 * 2;
		}
		if (num <= 0)
		{
			num = 1;
		}
		empty = Class55.smethod_4(val2, text, GetFont(), num, elementStyle_0.ETextFormat_0);
		val2.Dispose();
		m_Rect.Height = 23;
		if (m_Rect.Height < (int)empty.Height + int_5 * 2)
		{
			m_Rect.Height = (int)empty.Height + int_5 * 2;
		}
		if (val3 != null)
		{
			int height = m_Rect.Height;
			if (val3.get_Height() > m_Rect.Height)
			{
				m_Rect.Height = val3.get_Height() + int_5 * 2;
			}
			rectangle_1 = new Rectangle(0, m_Rect.Height - height, m_Rect.Width, height);
		}
		else
		{
			rectangle_1 = new Rectangle(0, 0, m_Rect.Width, m_Rect.Height);
		}
		if (bool_25)
		{
			rectangle_0 = new Rectangle(rectangle_1.Right - 25, rectangle_1.Y, 25, rectangle_1.Height);
		}
		if (Expanded)
		{
			if (m_SubItems != null)
			{
				int num2 = m_Rect.Bottom + 1;
				int leftInternal = m_Rect.Left + int_7;
				int num3 = -1;
				foreach (BaseItem subItem in m_SubItems)
				{
					num3++;
					if (!subItem.Visible)
					{
						subItem.Displayed = false;
						continue;
					}
					subItem.WidthInternal = m_Rect.Width - int_7 * 2;
					subItem.RecalcSize();
					subItem.WidthInternal = m_Rect.Width - int_7 * 2;
					if (subItem.BeginGroup)
					{
						num2 += 3;
					}
					subItem.TopInternal = num2;
					subItem.LeftInternal = leftInternal;
					num2 += subItem.HeightInternal;
					subItem.Displayed = true;
				}
				m_Rect.Height = num2 - m_Rect.Top + 2;
			}
		}
		else
		{
			foreach (BaseItem subItem2 in m_SubItems)
			{
				subItem2.Displayed = false;
			}
		}
		if (Expanded && DesignMode && SubItems.Count == 0 && Parent != null && Parent.SubItems.Count == 1)
		{
			m_Rect.Height += 64;
		}
		base.RecalcSize();
	}

	private Image method_18()
	{
		if (image_0 != null)
		{
			return image_0;
		}
		if (int_6 >= 0)
		{
			return method_19(int_6);
		}
		return null;
	}

	private Image method_19(int int_8)
	{
		if (int_8 >= 0)
		{
			IOwner owner = null;
			owner = GetOwner() as IOwner;
			_ = ContainerControl is Bar;
			if (owner != null)
			{
				try
				{
					if (owner.ImagesMedium != null)
					{
						if (image_1 == null)
						{
							image_1 = owner.ImagesMedium.get_Images().get_Item(int_8);
						}
						return image_1;
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

	private ShadowPaintInfo method_20()
	{
		if (shadowPaintInfo_0 == null)
		{
			shadowPaintInfo_0 = new ShadowPaintInfo();
		}
		shadowPaintInfo_0.Size = 3;
		return shadowPaintInfo_0;
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		if (DisplayRectangle.Width <= 0 || DisplayRectangle.Height <= 0 || bool_30)
		{
			return;
		}
		bool_30 = true;
		try
		{
			if (base.Boolean_2)
			{
				method_22(pa);
				DrawInsertMarker(pa.Graphics);
			}
			else
			{
				if (SuspendLayout)
				{
					return;
				}
				Graphics graphics = pa.Graphics;
				if (m_NeedRecalcSize)
				{
					RecalcSize();
				}
				Rectangle rectangle = rectangle_1;
				rectangle.Offset(m_Rect.X, m_Rect.Y);
				Font font = GetFont();
				_ = ContainerControl;
				Image val = method_18();
				Rectangle rectangle2 = rectangle;
				rectangle2.X += int_5;
				rectangle2.X += int_5 * 2;
				rectangle2.Width -= int_5 * 3;
				if (val != null)
				{
					rectangle2.Width -= val.get_Width() + int_5;
					rectangle2.X += val.get_Width() + int_5;
				}
				if (bool_25)
				{
					rectangle2.Width -= 25;
				}
				ElementStyleDisplayInfo elementStyleDisplayInfo = new ElementStyleDisplayInfo();
				elementStyleDisplayInfo.Bounds = rectangle;
				elementStyleDisplayInfo.Graphics = graphics;
				if (bool_23)
				{
					elementStyleDisplayInfo.Style = elementStyle_1;
				}
				else
				{
					elementStyleDisplayInfo.Style = elementStyle_0;
				}
				ElementStyleDisplay.Paint(elementStyleDisplayInfo);
				if (elementStyleDisplayInfo.Style.Font != null)
				{
					font = elementStyleDisplayInfo.Style.Font;
				}
				if (pa.RightToLeft)
				{
					Class55.smethod_1(graphics, m_Text, font, elementStyleDisplayInfo.Style.TextColor, method_21(rectangle_1, rectangle2), elementStyleDisplayInfo.Style.ETextFormat_0 | eTextFormat.RightToLeft);
				}
				else
				{
					Class55.smethod_1(graphics, m_Text, font, elementStyleDisplayInfo.Style.TextColor, rectangle2, elementStyleDisplayInfo.Style.ETextFormat_0);
				}
				if (bool_25)
				{
					Rectangle rectangle3 = rectangle_0;
					rectangle3.Offset(m_Rect.X, m_Rect.Y);
					if (pa.RightToLeft)
					{
						method_26(pa, method_21(m_Rect, rectangle3), bool_23, bool_24, m_Expanded);
					}
					else
					{
						method_26(pa, rectangle3, bool_23, bool_24, m_Expanded);
					}
				}
				int cornerDiameter = elementStyle_0.CornerDiameter;
				Rectangle bounds = new Rectangle(m_Rect.X, rectangle_1.Bottom + m_Rect.Y, m_Rect.Width, m_Rect.Height - rectangle_1.Bottom);
				if (bounds.Width > 0 && bounds.Height > 0)
				{
					elementStyleDisplayInfo.Style = elementStyle_2;
					elementStyleDisplayInfo.Bounds = bounds;
					ElementStyleDisplay.Paint(elementStyleDisplayInfo);
					if (bool_29)
					{
						ShadowPaintInfo shadowPaintInfo = method_20();
						shadowPaintInfo.Rectangle = new Rectangle(m_Rect.X, m_Rect.Y + rectangle_1.Top + cornerDiameter, m_Rect.Width, m_Rect.Height - rectangle_1.Top - cornerDiameter);
						shadowPaintInfo.Graphics = graphics;
						ShadowPainter.Paint(shadowPaintInfo);
					}
				}
				else if (bool_29)
				{
					rectangle.Y += cornerDiameter;
					rectangle.Height -= cornerDiameter;
					ShadowPaintInfo shadowPaintInfo2 = method_20();
					shadowPaintInfo2.Rectangle = rectangle;
					shadowPaintInfo2.Graphics = graphics;
					ShadowPainter.Paint(shadowPaintInfo2);
				}
				if (val != null)
				{
					if (pa.RightToLeft)
					{
						graphics.DrawImage(val, method_21(rectangle_1, new Rectangle(rectangle.Left + int_5, rectangle.Bottom - int_5 - val.get_Height(), val.get_Width(), val.get_Height())));
					}
					else
					{
						graphics.DrawImage(val, rectangle.Left + int_5, rectangle.Bottom - int_5 - val.get_Height(), val.get_Width(), val.get_Height());
					}
				}
				if (Focused)
				{
					if (DesignMode)
					{
						Rectangle rectangle_ = rectangle;
						rectangle_.Inflate(-1, -1);
						if (pa.RightToLeft)
						{
							rectangle_ = method_21(rectangle_1, rectangle_);
						}
						Class32.smethod_0(graphics, rectangle, pa.Colors.ItemDesignTimeBorder);
					}
					else
					{
						Rectangle rectangle4 = rectangle2;
						rectangle4.Inflate(0, -1);
						rectangle4.Width -= 2;
						rectangle4.X -= 2;
						if (pa.RightToLeft)
						{
							rectangle4 = method_21(rectangle_1, rectangle4);
						}
						ControlPaint.DrawFocusRectangle(graphics, rectangle4);
					}
				}
				if ((Expanded || (Parent is ExplorerBarContainerItem && ((ExplorerBarContainerItem)Parent).bool_22)) && m_SubItems != null)
				{
					rectangle = new Rectangle(m_Rect.X, m_Rect.Y + rectangle.Height + 1, m_Rect.Width, m_Rect.Height - rectangle.Height - 1);
					for (int i = 0; i < m_SubItems.Count; i++)
					{
						BaseItem baseItem = m_SubItems[i];
						if (!baseItem.Displayed || !baseItem.Visible)
						{
							continue;
						}
						if (baseItem.BeginGroup)
						{
							Pen val2 = new Pen(pa.Colors.ItemSeparator, 1f);
							try
							{
								graphics.DrawLine(val2, baseItem.LeftInternal + 2, baseItem.TopInternal - 2, baseItem.DisplayRectangle.Right - 4, baseItem.TopInternal - 2);
							}
							finally
							{
								((IDisposable)val2)?.Dispose();
							}
						}
						baseItem.Paint(pa);
					}
				}
				DrawInsertMarker(pa.Graphics);
				method_23(pa);
			}
		}
		finally
		{
			bool_30 = false;
		}
	}

	private Rectangle method_21(Rectangle rectangle_2, Rectangle rectangle_3)
	{
		return new Rectangle(rectangle_2.Right - (rectangle_3.Width + (rectangle_3.X - rectangle_2.X)), rectangle_3.Y, rectangle_3.Width, rectangle_3.Height);
	}

	private void method_22(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (SuspendLayout)
		{
			return;
		}
		if (m_NeedRecalcSize)
		{
			RecalcSize();
		}
		Bitmap val = new Bitmap(DisplayRectangle.Width, DisplayRectangle.Height, itemPaintArgs_0.Graphics);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Class81 class81_ = itemPaintArgs_0.Class81_0;
		Rectangle rectangle = rectangle_1;
		Class123 class123_ = Class123.class123_7;
		Class165 class165_ = Class165.class165_20;
		if (bool_26)
		{
			class123_ = Class123.class123_11;
		}
		class81_.method_0(val2, class123_, class165_, rectangle);
		Rectangle rectangle2 = new Rectangle(0, rectangle_1.Bottom, m_Rect.Width + (bool_26 ? 0 : 0), m_Rect.Height - rectangle_1.Bottom);
		if (rectangle2.Width > 0 && rectangle2.Height > 0)
		{
			Class123 class123_2;
			Class165 class165_2;
			if (bool_26)
			{
				class123_2 = Class123.class123_8;
				class165_2 = Class165.class165_21;
			}
			else
			{
				class123_2 = Class123.class123_4;
				class165_2 = Class165.class165_13;
			}
			class81_.method_0(val2, class123_2, class165_2, rectangle2);
		}
		Image val3 = method_18();
		Rectangle rectangle3 = rectangle;
		rectangle3.X += int_5;
		rectangle3.X += int_5 * 2;
		rectangle3.Width -= int_5 * 5;
		if (val3 != null)
		{
			rectangle3.Width -= val3.get_Width() + int_5;
			rectangle3.X += val3.get_Width() + int_5;
		}
		if (bool_25)
		{
			rectangle3.Width -= 25;
		}
		Font font = GetFont();
		ElementStyle elementStyle = elementStyle_0;
		if (bool_23)
		{
			elementStyle = elementStyle_1;
		}
		if (elementStyle.Font != null)
		{
			font = elementStyle.Font;
		}
		if (itemPaintArgs_0.RightToLeft)
		{
			Class55.smethod_2(val2, m_Text, font, elementStyle.TextColor, method_21(rectangle_1, rectangle3), elementStyle.ETextFormat_0 | eTextFormat.RightToLeft);
		}
		else
		{
			Class55.smethod_2(val2, m_Text, font, elementStyle.TextColor, rectangle3, elementStyle.ETextFormat_0);
		}
		if (bool_25)
		{
			Rectangle rectangle_ = rectangle_0;
			if (bool_26)
			{
				if (Expanded)
				{
					class123_ = Class123.class123_9;
					class165_ = ((!bool_22) ? Class165.class165_22 : Class165.class165_23);
				}
				else
				{
					class123_ = Class123.class123_10;
					class165_ = ((!bool_22) ? Class165.class165_25 : Class165.class165_26);
				}
			}
			else if (Expanded)
			{
				class123_ = Class123.class123_5;
				class165_ = ((!bool_22) ? Class165.class165_14 : Class165.class165_15);
			}
			else
			{
				class123_ = Class123.class123_6;
				class165_ = ((!bool_22) ? Class165.class165_17 : Class165.class165_18);
			}
			if (itemPaintArgs_0.RightToLeft)
			{
				class81_.method_0(val2, class123_, class165_, method_21(m_Rect, rectangle_));
			}
			else
			{
				class81_.method_0(val2, class123_, class165_, rectangle_);
			}
		}
		if (val3 != null)
		{
			if (itemPaintArgs_0.RightToLeft)
			{
				val2.DrawImage(val3, method_21(rectangle_1, new Rectangle(rectangle.Left + int_5, rectangle.Bottom - int_5 - val3.get_Height(), val3.get_Width(), val3.get_Height())));
			}
			else
			{
				val2.DrawImage(val3, rectangle.Left + int_5, rectangle.Bottom - int_5 - val3.get_Height(), val3.get_Width(), val3.get_Height());
			}
		}
		if (Focused)
		{
			if (DesignMode)
			{
				Rectangle rectangle_2 = rectangle;
				rectangle_2.Inflate(-1, -1);
				if (itemPaintArgs_0.RightToLeft)
				{
					rectangle_2 = method_21(rectangle_1, rectangle_2);
				}
				Class32.smethod_0(val2, rectangle, itemPaintArgs_0.Colors.ItemDesignTimeBorder);
			}
			else
			{
				Rectangle rectangle4 = rectangle3;
				rectangle4.Inflate(0, -1);
				rectangle4.Width -= 2;
				rectangle4.X -= 2;
				if (itemPaintArgs_0.RightToLeft)
				{
					rectangle4 = method_21(rectangle_1, rectangle4);
				}
				ControlPaint.DrawFocusRectangle(val2, rectangle4);
			}
		}
		val2.Dispose();
		val2 = itemPaintArgs_0.Graphics;
		val2.DrawImage((Image)(object)val, DisplayRectangle.X, DisplayRectangle.Y, ((Image)val).get_Width(), ((Image)val).get_Height());
		((Image)val).Dispose();
		if ((Expanded || (Parent is ExplorerBarContainerItem && ((ExplorerBarContainerItem)Parent).bool_22)) && m_SubItems != null)
		{
			rectangle = new Rectangle(m_Rect.X, m_Rect.Y + rectangle.Height + 1, m_Rect.Width, m_Rect.Height - rectangle.Height - 1);
			for (int i = 0; i < m_SubItems.Count; i++)
			{
				BaseItem baseItem = m_SubItems[i];
				if (baseItem.Displayed && baseItem.Visible)
				{
					baseItem.Paint(itemPaintArgs_0);
				}
			}
		}
		method_23(itemPaintArgs_0);
	}

	private void method_23(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		if (m_SubItems != null && m_SubItems.Count == 0 && DesignMode)
		{
			Rectangle rect = m_Rect;
			if (!rectangle_1.IsEmpty)
			{
				rect.Y += rectangle_1.Height;
				rect.Height -= rectangle_1.Height;
			}
			string text = "Right-click header and choose one of Create commands or use SubItems collection to create new buttons. You can also drag & drop controls on this panel.";
			rect.Inflate(-1, -1);
			Font val = new Font(SystemInformation.get_MenuFont().get_FontFamily(), 7f);
			Class55.smethod_1(itemPaintArgs_0.Graphics, text, val, SystemColors.ControlText, rect, eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter | eTextFormat.WordBreak);
			val.Dispose();
		}
	}

	private void method_24()
	{
		if (!bool_25)
		{
			return;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (!BaseItem.IsHandleValid(val))
		{
			return;
		}
		Graphics val2 = Class109.smethod_68(val);
		try
		{
			Class81 @class = null;
			bool flag = false;
			if (val is Interface6)
			{
				@class = ((Interface6)val).Class81_0;
			}
			else
			{
				flag = true;
				@class = new Class81(val);
			}
			Class123 class123_ = Class123.class123_5;
			Class165 class165_ = Class165.class165_14;
			Rectangle rectangle = rectangle_0;
			rectangle.Offset(m_Rect.X, m_Rect.Y);
			if (bool_26)
			{
				if (Expanded)
				{
					class123_ = Class123.class123_9;
					class165_ = ((!bool_22) ? Class165.class165_22 : Class165.class165_23);
				}
				else
				{
					class123_ = Class123.class123_10;
					class165_ = ((!bool_22) ? Class165.class165_25 : Class165.class165_26);
				}
			}
			else if (Expanded)
			{
				class123_ = Class123.class123_5;
				class165_ = ((!bool_22) ? Class165.class165_14 : Class165.class165_15);
			}
			else
			{
				class123_ = Class123.class123_6;
				class165_ = ((!bool_22) ? Class165.class165_17 : Class165.class165_18);
			}
			@class.method_0(val2, class123_, class165_, rectangle);
			if (flag)
			{
				@class.Dispose();
			}
		}
		finally
		{
			if (val2 != null)
			{
				val2.set_SmoothingMode((SmoothingMode)0);
				val2.set_TextRenderingHint((TextRenderingHint)0);
				val2.Dispose();
			}
		}
	}

	private void method_25()
	{
		if (bool_25)
		{
			Rectangle rectangle = rectangle_0;
			rectangle.Offset(m_Rect.X, m_Rect.Y);
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.Invalidate(rectangle);
				val.Update();
			}
		}
	}

	private void method_26(ItemPaintArgs itemPaintArgs_0, Rectangle rectangle_2, bool bool_31, bool bool_32, bool bool_33)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (itemPaintArgs_0.ContainerControl is ExplorerBar explorerBar && ((explorerBar.GroupButtonExpandNormal != null && !bool_33) || (explorerBar.GroupButtonCollapseNormal != null && bool_33)))
		{
			Image val = explorerBar.GroupButtonExpandNormal;
			if (bool_33)
			{
				val = explorerBar.GroupButtonCollapseNormal;
			}
			if (bool_32)
			{
				if (!bool_33 && explorerBar.GroupButtonExpandPressed != null)
				{
					val = explorerBar.GroupButtonExpandPressed;
				}
				else if (bool_33 && explorerBar.GroupButtonCollapsePressed != null)
				{
					val = explorerBar.GroupButtonCollapsePressed;
				}
			}
			else if (bool_31)
			{
				if (!bool_33 && explorerBar.GroupButtonExpandHot != null)
				{
					val = explorerBar.GroupButtonExpandHot;
				}
				else if (bool_33 && explorerBar.GroupButtonCollapseHot != null)
				{
					val = explorerBar.GroupButtonCollapseHot;
				}
			}
			Rectangle rectangle = rectangle_2;
			rectangle.Y += (rectangle.Height - val.get_Height()) / 2;
			graphics.DrawImageUnscaled(val, rectangle);
			return;
		}
		Pen val2 = new Pen(bool_31 ? color_3 : color_0, 1f);
		try
		{
			if (rectangle_2.Width > 16)
			{
				rectangle_2.Offset((rectangle_2.Width - 16) / 2, 0);
			}
			if (rectangle_2.Height > 16)
			{
				rectangle_2.Offset(0, (rectangle_2.Height - 16) / 2);
			}
			rectangle_2.Width = 16;
			rectangle_2.Height = 16;
			Brush val3 = (Brush)new SolidBrush(bool_31 ? color_4 : color_1);
			graphics.FillEllipse(val3, rectangle_2);
			val3.Dispose();
			graphics.DrawEllipse(val2, rectangle_2);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Pen val4 = new Pen(bool_31 ? color_5 : color_2, 1f);
		try
		{
			if (bool_33)
			{
				Point point = new Point(rectangle_2.X + 8, rectangle_2.Y + 4);
				graphics.DrawLine(val4, point.X, point.Y, point.X - 3, point.Y + 3);
				graphics.DrawLine(val4, point.X, point.Y, point.X + 3, point.Y + 3);
				graphics.DrawLine(val4, point.X, point.Y + 1, point.X - 3, point.Y + 4);
				graphics.DrawLine(val4, point.X, point.Y + 1, point.X + 3, point.Y + 4);
				point.Y += 4;
				graphics.DrawLine(val4, point.X, point.Y, point.X - 3, point.Y + 3);
				graphics.DrawLine(val4, point.X, point.Y, point.X + 3, point.Y + 3);
				graphics.DrawLine(val4, point.X, point.Y + 1, point.X - 3, point.Y + 4);
				graphics.DrawLine(val4, point.X, point.Y + 1, point.X + 3, point.Y + 4);
			}
			else
			{
				Point point2 = new Point(rectangle_2.X + 8, rectangle_2.Y + 8);
				graphics.DrawLine(val4, point2.X, point2.Y, point2.X - 3, point2.Y - 3);
				graphics.DrawLine(val4, point2.X, point2.Y, point2.X + 3, point2.Y - 3);
				graphics.DrawLine(val4, point2.X, point2.Y - 1, point2.X - 3, point2.Y - 4);
				graphics.DrawLine(val4, point2.X, point2.Y - 1, point2.X + 3, point2.Y - 4);
				point2.Y += 4;
				graphics.DrawLine(val4, point2.X, point2.Y, point2.X - 3, point2.Y - 3);
				graphics.DrawLine(val4, point2.X, point2.Y, point2.X + 3, point2.Y - 3);
				graphics.DrawLine(val4, point2.X, point2.Y - 1, point2.X - 3, point2.Y - 4);
				graphics.DrawLine(val4, point2.X, point2.Y - 1, point2.X + 3, point2.Y - 4);
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
	}

	public override void SubItemSizeChanged(BaseItem objChildItem)
	{
		NeedRecalcSize = true;
	}

	private void method_27(Graphics graphics_0, Rectangle rectangle_2, Color color_6, bool bool_31)
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		Point[] array = new Point[3];
		if (bool_31)
		{
			array[0].X = rectangle_2.Left + (rectangle_2.Width - 9) / 2;
			array[0].Y = rectangle_2.Top + rectangle_2.Height / 2 + 1;
			array[1].X = array[0].X + 8;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 4;
			array[2].Y = array[0].Y - 5;
		}
		else
		{
			array[0].X = rectangle_2.Left + (rectangle_2.Width - 7) / 2;
			array[0].Y = rectangle_2.Top + (rectangle_2.Height - 4) / 2;
			array[1].X = array[0].X + 7;
			array[1].Y = array[0].Y;
			array[2].X = array[0].X + 3;
			array[2].Y = array[0].Y + 4;
		}
		graphics_0.FillPolygon((Brush)new SolidBrush(color_6), array);
	}

	protected virtual Font GetFont()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		if (TitleStyle.Font != null)
		{
			return TitleStyle.Font;
		}
		Font val = SystemInformation.get_MenuFont();
		object containerControl = ContainerControl;
		Control val2 = (Control)((containerControl is Control) ? containerControl : null);
		if (val2 != null)
		{
			val = val2.get_Font();
		}
		if (!val.get_Bold())
		{
			val = new Font(val, (FontStyle)1);
		}
		return val;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseMove(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() == 1048576 && (Math.Abs(objArg.get_X() - point_2.X) >= 4 || Math.Abs(objArg.get_Y() - point_2.Y) >= 4) && ContainerControl is ExplorerBar explorerBar && explorerBar.AllowUserCustomize && CanCustomize)
		{
			BaseItem hotSubItem = m_HotSubItem;
			if (hotSubItem != null && hotSubItem.CanCustomize && !hotSubItem.SystemItem && GetOwner() is IOwner owner && owner.DragItem == null)
			{
				owner.StartItemDrag(hotSubItem);
				return;
			}
		}
		Rectangle rectangle = rectangle_1;
		rectangle.Offset(m_Rect.Location);
		if (rectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			if (!bool_23)
			{
				bool_23 = true;
				if (bool_27)
				{
					Cursor = Cursors.get_Hand();
				}
				Refresh();
			}
		}
		else if (bool_23)
		{
			if (bool_27)
			{
				Cursor = Cursors.get_Default();
			}
			bool_23 = false;
			Refresh();
		}
		Rectangle rectangle2 = rectangle_0;
		rectangle2.Offset(m_Rect.Location);
		if (bool_25 && rectangle2.Contains(objArg.get_X(), objArg.get_Y()))
		{
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseLeave();
				m_HotSubItem = null;
			}
			bool_22 = true;
			method_25();
		}
		else
		{
			if (bool_22)
			{
				bool_22 = false;
				method_25();
			}
			base.InternalMouseMove(objArg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseLeave()
	{
		Cursor = Cursors.get_Default();
		base.InternalMouseLeave();
		bool_23 = false;
		bool_24 = false;
		if (bool_22)
		{
			bool_22 = false;
		}
		Refresh();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Invalid comparison between Unknown and I4
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
		Rectangle rectangle2 = rectangle_0;
		rectangle2.Offset(m_Rect.X, m_Rect.Y);
		if (bool_25 && (int)objArg.get_Button() == 1048576 && rectangle2.Contains(objArg.get_X(), objArg.get_Y()))
		{
			method_28();
			return;
		}
		base.InternalMouseDown(objArg);
		if ((int)objArg.get_Button() == 1048576 && rectangle.Contains(objArg.get_X(), objArg.get_Y()))
		{
			bool_24 = true;
			if (bool_27)
			{
				Expanded = !Expanded;
			}
			else
			{
				Refresh();
			}
		}
	}

	internal void method_28()
	{
		Expanded = !Expanded;
	}

	protected internal override void OnExpandChange()
	{
		base.OnExpandChange();
		foreach (BaseItem subItem in SubItems)
		{
			if (subItem.Visible)
			{
				subItem.Displayed = Expanded;
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)objArg.get_Button() == 1048576)
		{
			bool_24 = false;
			Refresh();
		}
		base.InternalMouseUp(objArg);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalClick(MouseButtons mb, Point mpos)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		base.InternalClick(mb, mpos);
		if (GetOwner() is IOwner && ((IOwner)GetOwner()).DragInProgress)
		{
		}
	}

	protected internal override void OnSubItemsClear()
	{
		base.OnSubItemsClear();
		NeedRecalcSize = true;
		if (DesignMode)
		{
			Refresh();
		}
	}

	protected override void OnTopLocationChanged(int oldValue)
	{
		int num = m_Rect.Top - oldValue;
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			if (subItem.Visible)
			{
				subItem.TopInternal += num;
			}
		}
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		if (ContainerControl is ExplorerBar)
		{
			ExplorerBar explorerBar = ContainerControl as ExplorerBar;
			elementStyle_0.method_4(explorerBar.ColorScheme);
			elementStyle_1.method_4(explorerBar.ColorScheme);
			elementStyle_2.method_4(explorerBar.ColorScheme);
		}
	}

	protected internal override void OnVisibleChanged(bool bVisible)
	{
		base.OnVisibleChanged(bVisible);
		if (bVisible)
		{
			return;
		}
		foreach (BaseItem subItem in SubItems)
		{
			subItem.Displayed = false;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandBorderColor()
	{
		if (color_0 != Color.DarkGray)
		{
			return eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
	public bool ShouldSerializeExpandBackColor()
	{
		if (color_1 != Color.White)
		{
			return eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom;
		}
		return false;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	public bool ShouldSerializeExpandForeColor()
	{
		if (color_2 != SystemColors.ActiveCaption)
		{
			return eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom;
		}
		return false;
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeExpandHotBorderColor()
	{
		if (color_3 != Color.DarkGray)
		{
			return eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom;
		}
		return false;
	}

	[DevCoBrowsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool ShouldSerializeExpandHotBackColor()
	{
		if (color_4 != Color.White)
		{
			return eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public bool ShouldSerializeExpandHotForeColor()
	{
		if (color_5 != SystemColors.ActiveCaption)
		{
			return eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom;
		}
		return false;
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("stockstyle", XmlConvert.ToString((int)eExplorerBarStockStyle_0));
		itemXmlElement.SetAttribute("expvisible", XmlConvert.ToString(bool_25));
		itemXmlElement.SetAttribute("subitemsmargin", XmlConvert.ToString(int_7));
		itemXmlElement.SetAttribute("xpspecial", XmlConvert.ToString(bool_26));
		itemXmlElement.SetAttribute("expborder", Class109.smethod_50(color_0));
		itemXmlElement.SetAttribute("expbc", Class109.smethod_50(color_1));
		itemXmlElement.SetAttribute("expfc", Class109.smethod_50(color_2));
		itemXmlElement.SetAttribute("exphborder", Class109.smethod_50(color_3));
		itemXmlElement.SetAttribute("exphbc", Class109.smethod_50(color_4));
		itemXmlElement.SetAttribute("exphfc", Class109.smethod_50(color_5));
		itemXmlElement.SetAttribute("headerexp", XmlConvert.ToString(bool_27));
		itemXmlElement.SetAttribute("expanded", XmlConvert.ToString(m_Expanded));
		if (eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom)
		{
			XmlElement xmlElement = itemXmlElement.OwnerDocument.CreateElement("backstyle");
			itemXmlElement.AppendChild(xmlElement);
			method_29(elementStyle_2, xmlElement);
		}
		if (eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom)
		{
			XmlElement xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("headerhotstyle");
			itemXmlElement.AppendChild(xmlElement2);
			method_29(elementStyle_1, xmlElement2);
		}
		if (eExplorerBarStockStyle_0 == eExplorerBarStockStyle.Custom)
		{
			XmlElement xmlElement3 = itemXmlElement.OwnerDocument.CreateElement("headerstyle");
			itemXmlElement.AppendChild(xmlElement3);
			method_29(elementStyle_0, xmlElement3);
		}
		if (int_6 != -1)
		{
			itemXmlElement.SetAttribute("imageindex", XmlConvert.ToString(int_6));
		}
		else if (image_0 != null)
		{
			XmlElement xmlElement4 = itemXmlElement.OwnerDocument.CreateElement("image");
			itemXmlElement.AppendChild(xmlElement4);
			Class109.smethod_13(image_0, xmlElement4);
		}
	}

	private void method_29(ElementStyle elementStyle_3, XmlElement xmlElement_0)
	{
		ElementSerializer.Serialize(elementStyle_3, xmlElement_0);
	}

	private void method_30(ElementStyle elementStyle_3, XmlElement xmlElement_0)
	{
		ElementSerializer.Deserialize(elementStyle_3, xmlElement_0);
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		eExplorerBarStockStyle_0 = (eExplorerBarStockStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("stockstyle"));
		bool_25 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("expvisible"));
		int_7 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("subitemsmargin"));
		bool_26 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("xpspecial"));
		color_0 = Class109.smethod_51(itemXmlElement.GetAttribute("expborder"));
		color_1 = Class109.smethod_51(itemXmlElement.GetAttribute("expbc"));
		color_2 = Class109.smethod_51(itemXmlElement.GetAttribute("expfc"));
		color_3 = Class109.smethod_51(itemXmlElement.GetAttribute("exphborder"));
		color_4 = Class109.smethod_51(itemXmlElement.GetAttribute("exphbc"));
		color_5 = Class109.smethod_51(itemXmlElement.GetAttribute("exphfc"));
		bool_27 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("headerexp"));
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			switch (childNode.Name)
			{
			case "image":
				image_0 = Class109.smethod_16(childNode);
				break;
			case "headerstyle":
				method_30(elementStyle_0, childNode);
				break;
			case "headerhotstyle":
				method_30(elementStyle_1, childNode);
				break;
			case "backstyle":
				method_30(elementStyle_2, childNode);
				break;
			}
		}
		if (itemXmlElement.HasAttribute("imageindex"))
		{
			ImageIndex = XmlConvert.ToInt32(itemXmlElement.GetAttribute("imageindex"));
		}
		RefreshImageSize();
		Expanded = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("expanded"));
	}

	protected internal override void OnItemAdded(BaseItem item)
	{
		NeedRecalcSize = true;
		if (item is ButtonItem)
		{
			((ButtonItem)item).bool_36 = bool_28;
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
		if (item is ButtonItem)
		{
			ButtonItem buttonItem = item as ButtonItem;
			buttonItem.ThemeAware = false;
			if (buttonItem.ForeColor.IsEmpty && buttonItem.HotForeColor.IsEmpty)
			{
				Class109.smethod_57(item as ButtonItem, eExplorerBarStockStyle_0);
			}
		}
		item.NeedRecalcSize = true;
		if (DesignMode)
		{
			Refresh();
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
		if (val == null)
		{
			return;
		}
		Rectangle rectangle = rectangle_1;
		rectangle.Offset(m_Rect.X, m_Rect.Y);
		if (!rectangle.Contains(val.PointToClient(Control.get_MousePosition())))
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
		if (!Expanded)
		{
			base.Refresh();
		}
		else
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
	}

	protected virtual InsertPosition GetContainerInsertPosition(Point pScreen, BaseItem dragItem)
	{
		return DesignTimeProviderContainer.GetInsertPosition(this, pScreen, dragItem);
	}

	InsertPosition IDesignTimeProvider.GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		return GetContainerInsertPosition(pScreen, DragItem);
	}

	void IDesignTimeProvider.DrawReversibleMarker(int iPos, bool Before)
	{
		DesignTimeProviderContainer.DrawReversibleMarker(this, iPos, Before);
	}

	void IDesignTimeProvider.InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
		DesignTimeProviderContainer.InsertItemAt(this, objItem, iPos, Before);
	}

	private int method_31(BaseItem baseItem_0)
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

	internal static void smethod_0(ButtonItem buttonItem_0, eExplorerBarStockStyle eExplorerBarStockStyle_1)
	{
		Class109.smethod_57(buttonItem_0, eExplorerBarStockStyle_1);
		buttonItem_0.Text = "New Button";
		buttonItem_0.ButtonStyle = eButtonStyle.ImageAndText;
		buttonItem_0.ImagePosition = eImagePosition.Left;
		buttonItem_0.HotTrackingStyle = eHotTrackingStyle.None;
		buttonItem_0.HotFontUnderline = true;
		buttonItem_0.Cursor = Cursors.get_Hand();
	}

	public void SetDefaultAppearance()
	{
		StockStyle = eExplorerBarStockStyle.SystemColors;
		BackStyle.BackColorSchemePart = eColorSchemePart.BarBackground;
		BackStyle.BorderLeft = eStyleBorderType.Solid;
		BackStyle.BorderRight = eStyleBorderType.Solid;
		BackStyle.BorderTop = eStyleBorderType.Solid;
		BackStyle.BorderBottom = eStyleBorderType.Solid;
		BackStyle.BorderLeftColor = SystemColors.Window;
		BackStyle.BorderRightColor = SystemColors.Window;
		BackStyle.BorderTopColor = SystemColors.Window;
		BackStyle.BorderBottomColor = SystemColors.Window;
		BackStyle.BorderLeftWidth = 1;
		BackStyle.BorderRightWidth = 1;
		BackStyle.BorderTopWidth = 1;
		BackStyle.BorderBottomWidth = 1;
		ExpandBackColor = SystemColors.Window;
		ExpandBorderColor = SystemColors.InactiveCaption;
		ExpandForeColor = SystemColors.Highlight;
		ExpandHotBackColor = SystemColors.Window;
		ExpandHotForeColor = SystemColors.ActiveCaption;
		ExpandHotBorderColor = SystemColors.ActiveCaption;
		TitleHotStyle.BackColor = SystemColors.Window;
		TitleHotStyle.BackColor2 = SystemColors.InactiveCaption;
		TitleHotStyle.TextColor = SystemColors.ActiveCaption;
		TitleStyle.BackColor = SystemColors.Window;
		TitleStyle.BackColor2SchemePart = eColorSchemePart.BarBackground2;
		TitleStyle.TextColor = SystemColors.ControlText;
		ThemeAware = true;
	}
}
