using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[Designer(typeof(DockContainerItemDesigner))]
[DesignTimeVisible(false)]
public class DockContainerItem : ImageItem
{
	private EventHandler eventHandler_14;

	private ControlContainerItem.ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_0;

	private ControlContainerItem.ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_1;

	private Control control_0;

	private bool bool_22;

	private bool bool_23;

	private Size size_3 = new Size(32, 32);

	private Size size_4 = new Size(128, 128);

	private Image image_0;

	private int int_4 = -1;

	private Image image_1;

	private Icon icon_0;

	private int int_5 = 64;

	private int int_6 = -1;

	private int int_7 = -1;

	private eTabItemColor eTabItemColor_0;

	[DefaultValue(null)]
	[DevCoBrowsable(false)]
	[Description("Indicates the control hosted on dockable window")]
	[Category("Docking")]
	[Browsable(true)]
	public Control Control
	{
		get
		{
			return control_0;
		}
		set
		{
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			if (control_0 != null && control_0.get_Parent() != null)
			{
				if (!DesignMode || Site == null)
				{
					control_0.set_Visible(false);
				}
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			control_0 = value;
			if (control_0 == null)
			{
				return;
			}
			if (control_0 is PanelDockContainer)
			{
				((PanelDockContainer)(object)control_0).DockContainerItem = this;
			}
			if (control_0 is ListBox)
			{
				((ListBox)control_0).set_IntegralHeight(false);
			}
			if (control_0.get_Parent() != null)
			{
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			control_0.set_Dock((DockStyle)0);
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(control_0);
			if (properties.Find("AutoSize", ignoreCase: true) != null)
			{
				properties.Find("AutoSize", ignoreCase: true)!.SetValue(control_0, false);
			}
			if (!DesignMode || Site == null)
			{
				control_0.set_Visible(false);
			}
			Control val = null;
			if (ContainerControl != null)
			{
				object containerControl = ContainerControl;
				val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					val.get_Controls().Add(control_0);
					if (DesignMode && Site != null && control_0.get_Visible() && !Selected)
					{
						control_0.SendToBack();
					}
				}
			}
			OnDisplayedChanged();
		}
	}

	[Description("Indicates item category used to group similar items at design-time.")]
	[Category("Design")]
	[Browsable(false)]
	[DefaultValue("")]
	[DevCoBrowsable(false)]
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

	[Category("Behavior")]
	[Browsable(false)]
	[Description("Gets or sets whether Click event will be auto repeated when mouse button is kept pressed over the item.")]
	[DefaultValue(false)]
	[DevCoBrowsable(false)]
	public override bool ClickAutoRepeat
	{
		get
		{
			return base.ClickAutoRepeat;
		}
		set
		{
			base.ClickAutoRepeat = value;
		}
	}

	[DefaultValue(600)]
	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[Browsable(false)]
	[Category("Behavior")]
	[DevCoBrowsable(false)]
	public override int ClickRepeatInterval
	{
		get
		{
			return base.ClickRepeatInterval;
		}
		set
		{
			base.ClickRepeatInterval = value;
		}
	}

	[Category("Design")]
	[DefaultValue("")]
	[Description("Indicates description of the item that is displayed during design.")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
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

	[Browsable(false)]
	[Description("Determines alignment of the item inside the container.")]
	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[DefaultValue(eItemAlignment.Near)]
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

	[Description("Indicates list of shortcut keys for this item.")]
	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
	[Category("Design")]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[TypeConverter(typeof(ShortcutsConverter))]
	public override ShortcutsCollection Shortcuts
	{
		get
		{
			return base.Shortcuts;
		}
		set
		{
			base.Shortcuts = value;
		}
	}

	[Description("Determines whether sub-items are displayed.")]
	[Browsable(false)]
	[Category("Behavior")]
	[DefaultValue(true)]
	[DevCoBrowsable(false)]
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

	public override bool Visible
	{
		get
		{
			if (base.IsOnMenu)
			{
				return false;
			}
			if (ContainerControl is Bar bar)
			{
				if (bar.BarState != eBarState.Docked && bar.BarState != eBarState.Floating && bar.BarState != eBarState.AutoHide)
				{
					return false;
				}
				return base.Visible;
			}
			return base.Visible;
		}
		set
		{
			base.Visible = value;
		}
	}

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

	[DefaultValue(null)]
	[Category("Appearance")]
	[Description("Specifies the Tab image. Image specified here is used only on Tab when there are multiple dock containers on Bar.")]
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
			image_1 = null;
			if (ContainerControl is Bar bar)
			{
				bar.method_126(this);
			}
		}
	}

	[Description("Specifies the index of the Tab image if ImageList is used. Image specified here is used only on Tab when there are multiple dock containers on Bar.")]
	[Category("Appearance")]
	[Editor(typeof(ImageIndexEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	[DefaultValue(-1)]
	[TypeConverter(typeof(ImageIndexConverter))]
	[DevCoBrowsable(true)]
	public int ImageIndex
	{
		get
		{
			return int_4;
		}
		set
		{
			if (int_4 != value)
			{
				int_4 = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "ImageIndex");
				}
				image_1 = null;
				if (ContainerControl is Bar bar)
				{
					bar.method_126(this);
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Specifies the Button icon. Icons support multiple image sizes and alpha blending.")]
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
			image_1 = null;
			if (ContainerControl is Bar bar)
			{
				bar.method_126(this);
			}
		}
	}

	[DefaultValue(eTabItemColor.Default)]
	[Category("Style")]
	[Browsable(true)]
	[Description("Applies predefined color to tab.")]
	[DevCoBrowsable(true)]
	public eTabItemColor PredefinedTabColor
	{
		get
		{
			return eTabItemColor_0;
		}
		set
		{
			if (eTabItemColor_0 == value)
			{
				return;
			}
			eTabItemColor_0 = value;
			if (ContainerControl is Bar bar && bar.DockTabControl != null && Parent != null && Parent.SubItems.IndexOf(this) < bar.DockTabControl.Tabs.Count && bar.DockTabControl.Tabs[Parent.SubItems.IndexOf(this)].AttachedItem == this)
			{
				bar.DockTabControl.Tabs[Parent.SubItems.IndexOf(this)].PredefinedColor = eTabItemColor_0;
			}
			if (DesignMode)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					val.Refresh();
				}
			}
		}
	}

	internal Image Image_0
	{
		get
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			if (image_1 == null)
			{
				Image val = method_23();
				if (val != null)
				{
					if (val.get_Width() == 16 && val.get_Height() == 16)
					{
						image_1 = (Image)val.Clone();
					}
					else
					{
						image_1 = (Image)new Bitmap(val, 16, 16);
						Graphics val2 = Graphics.FromImage(image_1);
						val2.DrawImage(val, new Rectangle(0, 0, 16, 16), 0, 0, 16, 16, (GraphicsUnit)2);
						val2.Dispose();
					}
				}
			}
			return image_1;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool Selected
	{
		get
		{
			if (Visible && ContainerControl is Bar bar)
			{
				return bar.SelectedDockContainerItem == this;
			}
			return false;
		}
		set
		{
			if (Visible && ContainerControl is Bar bar)
			{
				bar.SelectedDockContainerItem = this;
			}
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Description("Indicates the width of the item in pixels.")]
	[DefaultValue(0)]
	[Browsable(false)]
	public int Width
	{
		get
		{
			return DisplayRectangle.Width;
		}
		set
		{
			if (value < size_3.Width)
			{
				value = size_3.Width;
			}
			if (value >= size_3.Width)
			{
				Bar bar = ContainerControl as Bar;
				if (Parent is GenericItemContainer genericItemContainer && genericItemContainer.SystemContainer && bar != null && bar.LayoutType == eLayoutType.DockContainer && bar.Stretch)
				{
					bar.method_21(this, value);
					int_6 = -1;
				}
				else
				{
					int_6 = value;
				}
			}
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(true)]
	[Description("Indicates height of the item in pixels.")]
	[DefaultValue(0)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int Height
	{
		get
		{
			return DisplayRectangle.Height;
		}
		set
		{
			if (value < size_3.Height)
			{
				value = size_3.Height;
			}
			if (value >= size_3.Height)
			{
				Bar bar = ContainerControl as Bar;
				if (Parent is GenericItemContainer genericItemContainer && genericItemContainer.SystemContainer && bar != null && bar.LayoutType == eLayoutType.DockContainer && bar.Stretch)
				{
					bar.method_22(this, value);
					int_7 = -1;
				}
				else
				{
					int_7 = value;
				}
			}
		}
	}

	[Description("Gets or sets the minimum size of the item.")]
	[Browsable(false)]
	[Category("Layout")]
	[DevCoBrowsable(false)]
	public Size MinimumSize
	{
		get
		{
			return size_3;
		}
		set
		{
			size_3 = value;
			if (size_3.Width > size_4.Width)
			{
				size_4.Width = size_3.Width;
			}
			if (size_3.Height > size_4.Height)
			{
				size_4.Height = size_3.Height;
			}
			if (ContainerControl is Bar bar)
			{
				bar.method_23(this);
			}
			if (size_3.Width > Width)
			{
				Width = size_3.Width;
			}
			if (size_3.Height > Height)
			{
				Height = size_3.Height;
			}
		}
	}

	[Description("Gets or sets the default floating size of the Bar that is containing this item.")]
	[Category("Layout")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Size DefaultFloatingSize
	{
		get
		{
			return size_4;
		}
		set
		{
			if (value.Width < size_3.Width)
			{
				value.Width = size_3.Width;
			}
			if (value.Height < size_3.Height)
			{
				value.Height = size_3.Height;
			}
			size_4 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Obsolete("This property is obsolete and it will be removed in next version")]
	[Category("Layout")]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DefaultValue(64)]
	[Description("Gets or sets the minimum size of the form client area that is tried to maintain when dockable window is resized.")]
	[DevCoBrowsable(false)]
	public int MinFormClientSize
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(false)]
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

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[Category("Behavior")]
	[Description("Indicates whether item can be customized by user.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override bool CanCustomize
	{
		get
		{
			return base.CanCustomize;
		}
		set
		{
			base.CanCustomize = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override bool IsWindowed => true;

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public override bool DesignMode
	{
		get
		{
			if (!base.DesignMode)
			{
				if (Site != null)
				{
					return Site.DesignMode;
				}
				return false;
			}
			return true;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Indicates whether certain global properties are propagated to all items with the same name when changed.")]
	[DefaultValue(false)]
	[Browsable(true)]
	public override bool GlobalItem
	{
		get
		{
			return base.GlobalItem;
		}
		set
		{
			base.GlobalItem = value;
		}
	}

	public event EventHandler ContainerLoadControl
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

	public event ControlContainerItem.ControlContainerSerializationEventHandler ContainerControlSerialize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			controlContainerSerializationEventHandler_0 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Combine(controlContainerSerializationEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			controlContainerSerializationEventHandler_0 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Remove(controlContainerSerializationEventHandler_0, value);
		}
	}

	public event ControlContainerItem.ControlContainerSerializationEventHandler ContainerControlDeserialize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			controlContainerSerializationEventHandler_1 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Combine(controlContainerSerializationEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			controlContainerSerializationEventHandler_1 = (ControlContainerItem.ControlContainerSerializationEventHandler)Delegate.Remove(controlContainerSerializationEventHandler_1, value);
		}
	}

	public DockContainerItem()
		: this("", "")
	{
	}

	public DockContainerItem(string sName)
		: this(sName, "")
	{
	}

	public DockContainerItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		m_SupportedOrientation = eSupportedOrientation.Both;
		Stretch = true;
		CanCustomize = false;
		m_Displayed = true;
		GlobalItem = false;
	}

	internal void method_17()
	{
		EventArgs e = new EventArgs();
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, e);
		}
		GetIOwnerItemEvents()?.InvokeContainerLoadControl(this, e);
	}

	public override BaseItem Copy()
	{
		ControlContainerItem controlContainerItem = new ControlContainerItem(Name);
		CopyToItem(controlContainerItem);
		return controlContainerItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		DockContainerItem dockContainerItem = copy as DockContainerItem;
		base.CopyToItem(dockContainerItem);
		dockContainerItem.method_24(int_4);
		if (icon_0 != null)
		{
			object obj = icon_0.Clone();
			dockContainerItem.Icon = (Icon)((obj is Icon) ? obj : null);
		}
		if (dockContainerItem.Image != null)
		{
			object obj2 = image_0.Clone();
			dockContainerItem.Image = (Image)((obj2 is Image) ? obj2 : null);
		}
		dockContainerItem.eventHandler_14 = eventHandler_14;
		dockContainerItem.method_17();
	}

	public override void Dispose()
	{
		control_0 = null;
		base.Dispose();
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		XmlElement xmlElement = null;
		XmlElement xmlElement2 = null;
		if (image_0 == null && int_4 < 0)
		{
			if (icon_0 != null)
			{
				xmlElement = itemXmlElement.OwnerDocument.CreateElement("images");
				itemXmlElement.AppendChild(xmlElement);
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "icon");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_14(icon_0, xmlElement2);
			}
		}
		else
		{
			xmlElement = itemXmlElement.OwnerDocument.CreateElement("images");
			itemXmlElement.AppendChild(xmlElement);
			if (int_4 >= 0)
			{
				xmlElement.SetAttribute("imageindex", XmlConvert.ToString(int_4));
			}
			if (image_0 != null)
			{
				xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("image");
				xmlElement2.SetAttribute("type", "default");
				xmlElement.AppendChild(xmlElement2);
				Class109.smethod_13(image_0, xmlElement2);
			}
		}
		if (size_3.Width != 32 || size_3.Height != 32)
		{
			itemXmlElement.SetAttribute("minw", size_3.Width.ToString());
			itemXmlElement.SetAttribute("minh", size_3.Height.ToString());
		}
		if (size_4.Width != 128 || size_4.Height != 128)
		{
			itemXmlElement.SetAttribute("defw", size_4.Width.ToString());
			itemXmlElement.SetAttribute("defh", size_4.Height.ToString());
		}
		if (int_5 != 64)
		{
			itemXmlElement.SetAttribute("csize", int_5.ToString());
		}
		if (eTabItemColor_0 != 0)
		{
			itemXmlElement.SetAttribute("PredefinedTabColor", XmlConvert.ToString((int)eTabItemColor_0));
		}
		if (controlContainerSerializationEventHandler_0 != null)
		{
			controlContainerSerializationEventHandler_0(this, new ControlContainerSerializationEventArgs(itemXmlElement));
		}
		GetIOwnerItemEvents()?.InvokeContainerControlSerialize(this, new ControlContainerSerializationEventArgs(itemXmlElement));
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		foreach (XmlElement childNode in itemXmlElement.ChildNodes)
		{
			if (!(childNode.Name == "images"))
			{
				continue;
			}
			if (childNode.HasAttribute("imageindex"))
			{
				int_4 = XmlConvert.ToInt32(childNode.GetAttribute("imageindex"));
			}
			foreach (XmlElement childNode2 in childNode.ChildNodes)
			{
				if (childNode2.GetAttribute("type") == "default")
				{
					image_0 = Class109.smethod_16(childNode2);
					int_4 = -1;
				}
				else if (childNode2.GetAttribute("type") == "icon")
				{
					icon_0 = Class109.smethod_17(childNode2);
					int_4 = -1;
				}
			}
			break;
		}
		if (itemXmlElement.HasAttribute("minw"))
		{
			size_3 = new Size(XmlConvert.ToInt32(itemXmlElement.GetAttribute("minw")), XmlConvert.ToInt32(itemXmlElement.GetAttribute("minh")));
		}
		if (itemXmlElement.HasAttribute("defw"))
		{
			size_4 = new Size(XmlConvert.ToInt32(itemXmlElement.GetAttribute("defw")), XmlConvert.ToInt32(itemXmlElement.GetAttribute("defh")));
		}
		if (itemXmlElement.HasAttribute("csize"))
		{
			int_5 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("csize"));
		}
		else
		{
			int_5 = 64;
		}
		if (itemXmlElement.HasAttribute("PredefinedTabColor"))
		{
			eTabItemColor_0 = (eTabItemColor)XmlConvert.ToInt32(itemXmlElement.GetAttribute("PredefinedTabColor"));
		}
		else
		{
			eTabItemColor_0 = eTabItemColor.Default;
		}
		method_17();
		if (control_0 == null && context.hashtable_0 != null && context.hashtable_0.ContainsKey(Name))
		{
			object? obj = context.hashtable_0[Name];
			Control = (Control)((obj is Control) ? obj : null);
			context.hashtable_0.Remove(Name);
		}
		if (controlContainerSerializationEventHandler_1 != null)
		{
			controlContainerSerializationEventHandler_1(this, new ControlContainerSerializationEventArgs(itemXmlElement));
		}
		GetIOwnerItemEvents()?.InvokeContainerControlDeserialize(this, new ControlContainerSerializationEventArgs(itemXmlElement));
	}

	protected override void OnExternalSizeChange()
	{
		method_18();
		base.OnExternalSizeChange();
	}

	private void method_18()
	{
		if (bool_23)
		{
			return;
		}
		bool_23 = true;
		try
		{
			Rectangle displayRectangle = DisplayRectangle;
			Size size = method_21();
			if (base.IsOnMenu && Style != eDotNetBarStyle.Office2000)
			{
				size.Width += 7;
				displayRectangle.Width -= size.Width;
				displayRectangle.X += size.Width;
			}
			if (base.IsOnCustomizeMenu)
			{
				if (Style != eDotNetBarStyle.Office2000)
				{
					displayRectangle.X += size.Height + 8;
					displayRectangle.Width -= size.Height + 8;
				}
				else
				{
					displayRectangle.X += size.Height + 4;
					displayRectangle.Width -= size.Height + 4;
				}
			}
			if (control_0 == null)
			{
				return;
			}
			displayRectangle.Inflate(-2, -2);
			if (displayRectangle.Width > 0 && displayRectangle.Height > 0)
			{
				if (!control_0.get_Size().Equals((object?)displayRectangle.Size))
				{
					control_0.SuspendLayout();
					control_0.set_Size(displayRectangle.Size);
					control_0.ResumeLayout();
				}
				Point location = displayRectangle.Location;
				location.Offset((displayRectangle.Width - control_0.get_Width()) / 2, (displayRectangle.Height - control_0.get_Height()) / 2);
				if (location.X != control_0.get_Location().X || location.Y != control_0.get_Location().Y)
				{
					control_0.set_Location(location);
				}
			}
		}
		finally
		{
			bool_23 = false;
		}
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		if (SuspendLayout)
		{
			return;
		}
		Graphics graphics = pa.Graphics;
		if (control_0 != null && control_0.get_Visible() != Displayed && !control_0.get_Visible())
		{
			method_20();
		}
		Rectangle displayRectangle = DisplayRectangle;
		Size size = method_21();
		if (base.IsOnMenu && Style != eDotNetBarStyle.Office2000)
		{
			size.Width += 7;
			displayRectangle.Width -= size.Width;
			displayRectangle.X += size.Width;
			if (base.IsOnCustomizeMenu)
			{
				size.Width += size.Height + 8;
			}
			if (!pa.Colors.MenuSide2.IsEmpty)
			{
				LinearGradientBrush val = Class109.smethod_40(new Rectangle(m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height), pa.Colors.MenuSide, pa.Colors.MenuSide2, pa.Colors.MenuSideGradientAngle);
				graphics.FillRectangle((Brush)(object)val, m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height);
				((Brush)val).Dispose();
			}
			else
			{
				graphics.FillRectangle((Brush)new SolidBrush(pa.Colors.MenuSide), m_Rect.Left, m_Rect.Top, size.Width, m_Rect.Height);
			}
		}
		if (base.IsOnCustomizeMenu)
		{
			if (Style != eDotNetBarStyle.Office2000)
			{
				displayRectangle.X += size.Height + 8;
				displayRectangle.Width -= size.Height + 8;
			}
			else
			{
				displayRectangle.X += size.Height + 4;
				displayRectangle.Width -= size.Height + 4;
			}
		}
		if (control_0 == null)
		{
			string text = m_Text;
			if (text == "")
			{
				text = "Container";
			}
			eTextFormat eTextFormat_ = method_22();
			Font font = GetFont();
			Rectangle rectangle_ = new Rectangle(displayRectangle.X + 8, displayRectangle.Y, displayRectangle.Width, displayRectangle.Height);
			if (Style == eDotNetBarStyle.Office2000)
			{
				Class55.smethod_1(graphics, text, font, SystemColors.ControlText, rectangle_, eTextFormat_);
			}
			else
			{
				Class55.smethod_1(graphics, text, font, SystemColors.ControlText, rectangle_, eTextFormat_);
			}
			Size size2 = Class55.smethod_4(graphics, text, font, 0, eTextFormat_);
			displayRectangle.X += size2.Width + 8;
			displayRectangle.Width -= size2.Width + 8;
		}
		else if (control_0 != null)
		{
			method_18();
		}
		if (base.IsOnCustomizeMenu && Visible)
		{
			Rectangle rectangle_2 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
			if (Style != eDotNetBarStyle.Office2000)
			{
				rectangle_2.Inflate(-1, -1);
			}
			Class109.smethod_12(pa, rectangle_2, Style, bool_22);
		}
		if (Focused && DesignMode)
		{
			displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			Class32.smethod_0(graphics, displayRectangle, pa.Colors.ItemDesignTimeBorder);
		}
	}

	public override void RecalcSize()
	{
		if (SuspendLayout)
		{
			return;
		}
		_ = base.IsOnMenu;
		if (control_0 == null && !DesignMode)
		{
			method_17();
		}
		if (control_0 == null)
		{
			if (Parent != null && Parent is ImageItem)
			{
				m_Rect.Height = ((ImageItem)Parent).SubItemsImageSize.Height + 4;
			}
			else
			{
				m_Rect.Height = SubItemsImageSize.Height + 4;
			}
			if (Style != eDotNetBarStyle.Office2000)
			{
				if (control_0 != null && m_Rect.Height < control_0.get_Height() + 2)
				{
					m_Rect.Height = control_0.get_Height() + 2;
				}
			}
			else if (control_0 != null && m_Rect.Height < control_0.get_Height() + 2)
			{
				m_Rect.Height = control_0.get_Height() + 2;
			}
		}
		else
		{
			m_Rect.Height = size_3.Height + 4;
		}
		m_Rect.Width = size_3.Width + 4;
		if (control_0 == null)
		{
			string text = m_Text;
			if (text == "")
			{
				text = "Container";
			}
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null && BaseItem.IsHandleValid(val))
			{
				Graphics val2 = Class109.smethod_68(val);
				try
				{
					Size size = Class55.smethod_4(val2, text, GetFont(), 0, method_22());
					if (size.Height > SubItemsImageSize.Height && size.Height > m_Rect.Height)
					{
						m_Rect.Height = size.Height + 4;
					}
				}
				finally
				{
					val2.Dispose();
				}
			}
		}
		Size size2 = method_21();
		if (base.IsOnMenu && Style != eDotNetBarStyle.Office2000)
		{
			m_Rect.Width += size2.Width + 7;
		}
		if (base.IsOnCustomizeMenu)
		{
			m_Rect.Width += size2.Height + 2;
		}
		base.RecalcSize();
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		method_19();
	}

	private void method_19()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (control_0 == null)
		{
			return;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == control_0.get_Parent())
		{
			return;
		}
		bool flag = false;
		if (control_0.get_Parent() != null)
		{
			if (control_0 is TextBox && ((TextBoxBase)(TextBox)control_0).get_Multiline())
			{
				flag = true;
				((TextBoxBase)(TextBox)control_0).set_Multiline(false);
			}
			control_0.get_Parent().get_Controls().Remove(control_0);
		}
		if (val != null)
		{
			val.get_Controls().Add(control_0);
			if (control_0 is TextBox && flag)
			{
				((TextBoxBase)(TextBox)control_0).set_Multiline(true);
			}
			if (control_0.get_Visible())
			{
				control_0.Refresh();
			}
		}
	}

	protected internal override void OnProcessDelayedCommands()
	{
		if (int_6 >= 0)
		{
			int width = int_6;
			int_6 = -1;
			Width = width;
		}
		if (int_7 > 0)
		{
			int height = int_7;
			int_7 = -1;
			Height = height;
		}
	}

	protected internal override void OnVisibleChanged(bool newValue)
	{
		if (control_0 != null && !newValue)
		{
			if (DesignMode && Site != null)
			{
				if (newValue)
				{
					control_0.SendToBack();
				}
				else
				{
					control_0.BringToFront();
				}
			}
			else
			{
				control_0.set_Visible(newValue);
			}
		}
		if (ContainerControl is Bar bar && bar.LayoutType == eLayoutType.DockContainer)
		{
			bar.method_122(this);
			if (bar.AutoHide)
			{
				bar.method_121();
			}
			else
			{
				bar.method_120(bool_67: true);
			}
		}
		base.OnVisibleChanged(newValue);
	}

	protected override void OnDisplayedChanged()
	{
		if (Displayed)
		{
			Refresh();
			if (ContainerControl is Bar bar)
			{
				bar.method_131();
			}
		}
		if (control_0 != null && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog)
		{
			method_18();
			if (DesignMode && Site != null)
			{
				if (Displayed)
				{
					control_0.BringToFront();
				}
				else
				{
					control_0.SendToBack();
				}
				method_18();
			}
			else
			{
				control_0.set_Visible(Displayed);
			}
		}
		base.OnDisplayedChanged();
	}

	protected override void OnIsOnCustomizeDialogChanged()
	{
		base.OnIsOnCustomizeDialogChanged();
		method_20();
	}

	protected override void OnDesignModeChanged()
	{
		base.OnDesignModeChanged();
		method_20();
	}

	protected override void OnIsOnCustomizeMenuChanged()
	{
		base.OnIsOnCustomizeMenuChanged();
		method_20();
	}

	private void method_20()
	{
		if (control_0 == null || (DesignMode && Site != null))
		{
			return;
		}
		if (!base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			if (!DesignMode || Site == null)
			{
				control_0.set_Visible(Displayed);
			}
			control_0.set_Enabled(true);
		}
		else
		{
			control_0.set_Enabled(false);
		}
	}

	private Size method_21()
	{
		if (m_Parent != null)
		{
			if (m_Parent is ImageItem imageItem)
			{
				return imageItem.SubItemsImageSize;
			}
			return ImageSize;
		}
		return ImageSize;
	}

	private eTextFormat method_22()
	{
		return eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
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

	protected internal override bool IsAnyOnHandle(int iHandle)
	{
		bool result;
		if (!(result = base.IsAnyOnHandle(iHandle)) && control_0 != null && control_0.get_Handle().ToInt32() == iHandle)
		{
			result = true;
		}
		return result;
	}

	protected override void OnEnabledChanged()
	{
		base.OnEnabledChanged();
		if ((!DesignMode || Site == null) && control_0 != null)
		{
			control_0.set_Enabled(Enabled);
		}
	}

	protected internal override void OnGotFocus()
	{
		base.OnGotFocus();
		if (control_0 != null && !control_0.get_Focused() && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !DesignMode)
		{
			control_0.Focus();
		}
	}

	private Image method_23()
	{
		if (image_0 != null)
		{
			return image_0;
		}
		return method_25(int_4);
	}

	internal void method_24(int int_8)
	{
		int_4 = int_8;
	}

	private Image method_25(int int_8)
	{
		if (int_8 >= 0 && GetOwner() is IOwner owner && owner.Images != null && owner.Images.get_Images().get_Count() > 0 && int_8 < owner.Images.get_Images().get_Count())
		{
			return owner.Images.get_Images().get_Item(int_8);
		}
		return null;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeMinimumSize()
	{
		if (size_3.Width == 32 && size_3.Height == 32)
		{
			return false;
		}
		return true;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetMinimumSize()
	{
		MinimumSize = new Size(32, 32);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeDefaultFloatingSize()
	{
		if (size_4.Width == 128 && size_4.Height == 128)
		{
			return false;
		}
		return true;
	}

	protected internal override void OnAfterItemRemoved(BaseItem item)
	{
		base.OnAfterItemRemoved(item);
		method_19();
	}

	protected override void OnTextChanged()
	{
		base.OnTextChanged();
		if (ContainerControl is Bar)
		{
			((Bar)ContainerControl).method_126(this);
		}
	}

	protected override void OnTooltipChanged()
	{
		base.OnTooltipChanged();
		if (ContainerControl is Bar)
		{
			((Bar)ContainerControl).method_126(this);
		}
	}

	protected override void OnStyleChanged()
	{
		base.OnStyleChanged();
		if (control_0 is PanelDockContainer && !((PanelDockContainer)(object)control_0).UseCustomStyle)
		{
			((PanelDockContainer)(object)control_0).ColorSchemeStyle = Style;
		}
	}
}
