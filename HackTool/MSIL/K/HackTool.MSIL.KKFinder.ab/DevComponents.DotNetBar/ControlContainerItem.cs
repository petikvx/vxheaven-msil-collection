using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[Designer(typeof(SimpleBaseItemDesigner))]
[ToolboxItem(false)]
public class ControlContainerItem : ImageItem, IPersonalizedMenuItem
{
	public delegate void ControlContainerSerializationEventHandler(object sender, ControlContainerSerializationEventArgs e);

	private EventHandler eventHandler_14;

	private ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_0;

	private ControlContainerSerializationEventHandler controlContainerSerializationEventHandler_1;

	private eMenuVisibility eMenuVisibility_0;

	private bool bool_22;

	private Control control_0;

	private bool bool_23;

	private bool bool_24 = true;

	private bool bool_25;

	[DevCoBrowsable(true)]
	[Description("Indicates item's visiblity when on pop-up menu.")]
	[Browsable(true)]
	[Category("Appearance")]
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
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[Localizable(true)]
	[Description("Indicates the text that is displayed when mouse hovers over the item.")]
	[Browsable(false)]
	[Category("Appearance")]
	[DefaultValue("")]
	[DevCoBrowsable(false)]
	public override string Tooltip
	{
		get
		{
			return base.Tooltip;
		}
		set
		{
			base.Tooltip = value;
		}
	}

	[Category("Data")]
	[DefaultValue(null)]
	[Description("Indicates the control that is managed by the item.")]
	public Control Control
	{
		get
		{
			return control_0;
		}
		set
		{
			if (control_0 != null && control_0.get_Parent() != null)
			{
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			control_0 = value;
			if (control_0 == null)
			{
				return;
			}
			if (control_0.get_Parent() != null)
			{
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			control_0.set_Dock((DockStyle)0);
			Control val = null;
			if (ContainerControl != null)
			{
				object containerControl = ContainerControl;
				val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					val.get_Controls().Add(control_0);
					control_0.Refresh();
				}
			}
			if (!Displayed)
			{
				control_0.set_Visible(false);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public override Rectangle Bounds
	{
		get
		{
			return base.Bounds;
		}
		set
		{
			if (base.Bounds != value)
			{
				bool flag = base.Bounds.Top != value.Top;
				bool flag2 = base.Bounds.Left != value.Left;
				base.Bounds = value;
				if (flag || flag2)
				{
					method_18();
				}
			}
		}
	}

	[Browsable(true)]
	[Description("Specifies whether contained control can be automatically resized to fill the item container.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public bool AllowItemResize
	{
		get
		{
			return bool_24;
		}
		set
		{
			bool_24 = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool IsWindowed => true;

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

	public event ControlContainerSerializationEventHandler ContainerControlSerialize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			controlContainerSerializationEventHandler_0 = (ControlContainerSerializationEventHandler)Delegate.Combine(controlContainerSerializationEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			controlContainerSerializationEventHandler_0 = (ControlContainerSerializationEventHandler)Delegate.Remove(controlContainerSerializationEventHandler_0, value);
		}
	}

	public event ControlContainerSerializationEventHandler ContainerControlDeserialize
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			controlContainerSerializationEventHandler_1 = (ControlContainerSerializationEventHandler)Delegate.Combine(controlContainerSerializationEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			controlContainerSerializationEventHandler_1 = (ControlContainerSerializationEventHandler)Delegate.Remove(controlContainerSerializationEventHandler_1, value);
		}
	}

	public ControlContainerItem()
		: this("", "")
	{
	}

	public ControlContainerItem(string sName)
		: this(sName, "")
	{
	}

	public ControlContainerItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		m_SupportedOrientation = eSupportedOrientation.Horizontal;
	}

	internal void method_17()
	{
		EventArgs e = new EventArgs();
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, e);
		}
		GetIOwnerItemEvents()?.InvokeContainerLoadControl(this, e);
		method_19();
	}

	public override BaseItem Copy()
	{
		ControlContainerItem controlContainerItem = new ControlContainerItem(Name);
		controlContainerItem.AllowItemResize = AllowItemResize;
		CopyToItem(controlContainerItem);
		return controlContainerItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		ControlContainerItem controlContainerItem = copy as ControlContainerItem;
		base.CopyToItem(controlContainerItem);
		controlContainerItem.eventHandler_14 = eventHandler_14;
		controlContainerItem.method_17();
	}

	public override void Dispose()
	{
		if (control_0 != null)
		{
			control_0 = null;
		}
		base.Dispose();
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		itemXmlElement.SetAttribute("AllowResize", XmlConvert.ToString(bool_24));
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
		bool_24 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("AllowResize"));
		method_17();
		if (controlContainerSerializationEventHandler_1 != null)
		{
			controlContainerSerializationEventHandler_1(this, new ControlContainerSerializationEventArgs(itemXmlElement));
		}
		GetIOwnerItemEvents()?.InvokeContainerControlDeserialize(this, new ControlContainerSerializationEventArgs(itemXmlElement));
	}

	public override void Paint(ItemPaintArgs pa)
	{
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		if (SuspendLayout)
		{
			return;
		}
		Graphics graphics = pa.Graphics;
		if (control_0 != null && control_0.get_Visible() != Displayed && !control_0.get_Visible())
		{
			method_19();
		}
		Rectangle displayRectangle = DisplayRectangle;
		Size size = method_20();
		bool flag;
		if ((flag = base.IsOnMenu) && Parent is ItemContainer)
		{
			flag = false;
		}
		if (Orientation == eOrientation.Horizontal)
		{
			if (flag && !Stretch)
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
			if (flag)
			{
				_ = Style;
			}
			if (control_0 != null && !method_22() && !base.IsOnCustomizeMenu)
			{
				if (control_0 != null)
				{
					displayRectangle.Inflate(-2, -2);
					if (bool_24)
					{
						control_0.set_Width(displayRectangle.Width);
					}
					Point location = displayRectangle.Location;
					location.Offset((displayRectangle.Width - control_0.get_Width()) / 2, (displayRectangle.Height - control_0.get_Height()) / 2);
					Control containerControl = pa.ContainerControl;
					ScrollableControl val2 = (ScrollableControl)(object)((containerControl is ScrollableControl) ? containerControl : null);
					if (val2 != null && val2.get_AutoScroll())
					{
						location.Offset(val2.get_AutoScrollPosition().X, val2.get_AutoScrollPosition().Y);
					}
					if (control_0.get_Location() != location)
					{
						control_0.set_Location(location);
					}
				}
			}
			else
			{
				string text = m_Text;
				if (text == "")
				{
					text = "Container";
				}
				eTextFormat eTextFormat_ = method_21();
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
			if (base.IsOnCustomizeMenu && Visible)
			{
				Rectangle rectangle_2 = new Rectangle(m_Rect.Left, m_Rect.Top, m_Rect.Height, m_Rect.Height);
				if (Style != eDotNetBarStyle.Office2000)
				{
					rectangle_2.Inflate(-1, -1);
				}
				Class109.smethod_12(pa, rectangle_2, Style, bool_23);
			}
		}
		if (Focused && (method_22() || (control_0 == null && DesignMode)))
		{
			displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-1, -1);
			Class32.smethod_0(graphics, displayRectangle, pa.Colors.ItemDesignTimeBorder);
		}
	}

	private void method_18()
	{
		if (control_0 != null)
		{
			Rectangle displayRectangle = DisplayRectangle;
			displayRectangle.Inflate(-2, -2);
			control_0.set_Location(displayRectangle.Location);
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
		if (Parent != null && Parent is ImageItem)
		{
			m_Rect.Height = ((ImageItem)Parent).SubItemsImageSize.Height + 4;
		}
		else
		{
			m_Rect.Height = SubItemsImageSize.Height + 4;
		}
		if (Style != 0 && Style != eDotNetBarStyle.Office2003 && Style != eDotNetBarStyle.VS2005)
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
		if (control_0 != null)
		{
			if (Stretch)
			{
				m_Rect.Width = 32;
			}
			else
			{
				m_Rect.Width = control_0.get_Width() + 4;
			}
		}
		else
		{
			m_Rect.Width = 68;
		}
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
					Size size = Class55.smethod_4(val2, text, GetFont(), 0, method_21());
					if (size.Height > SubItemsImageSize.Height && size.Height > m_Rect.Height)
					{
						m_Rect.Height = size.Height + 4;
					}
					m_Rect.Width = size.Width + 8;
				}
				finally
				{
					val2.Dispose();
				}
			}
		}
		Size size2 = method_20();
		if (base.IsOnMenu && Style != eDotNetBarStyle.Office2000 && !Stretch && !(Parent is ItemContainer))
		{
			m_Rect.Width += size2.Width + 7;
		}
		if (base.IsOnCustomizeMenu)
		{
			m_Rect.Width += size2.Height + 2;
		}
		base.RecalcSize();
	}

	protected override void OnExternalSizeChange()
	{
		base.OnExternalSizeChange();
		if (bool_24)
		{
			NeedRecalcSize = true;
		}
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		if (control_0 != null)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (control_0.get_Parent() != null && val != control_0.get_Parent())
			{
				control_0.get_Parent().get_Controls().Remove(control_0);
			}
			if (val != null && control_0.get_Parent() == null)
			{
				val.get_Controls().Add(control_0);
				control_0.Refresh();
			}
		}
	}

	protected internal override void OnVisibleChanged(bool newValue)
	{
		if (control_0 != null && !newValue)
		{
			control_0.set_Visible(newValue);
		}
		base.OnVisibleChanged(newValue);
	}

	protected override void OnDisplayedChanged()
	{
		if (!Displayed && control_0 != null && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !method_22())
		{
			control_0.set_Visible(Displayed);
		}
	}

	protected override void OnIsOnCustomizeDialogChanged()
	{
		base.OnIsOnCustomizeDialogChanged();
		method_19();
	}

	protected override void OnDesignModeChanged()
	{
		base.OnDesignModeChanged();
		method_19();
	}

	protected override void OnIsOnCustomizeMenuChanged()
	{
		base.OnIsOnCustomizeMenuChanged();
		method_19();
	}

	private void method_19()
	{
		if (control_0 == null || bool_25)
		{
			return;
		}
		bool_25 = true;
		try
		{
			if (!base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !method_22())
			{
				control_0.set_Visible(Displayed);
			}
			else
			{
				control_0.set_Visible(false);
			}
		}
		finally
		{
			bool_25 = false;
		}
	}

	private Size method_20()
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

	private eTextFormat method_21()
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
		if (control_0 != null)
		{
			control_0.set_Enabled(Enabled);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseEnter()
	{
		base.InternalMouseEnter();
		if (!bool_23)
		{
			bool_23 = true;
			Refresh();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		if (bool_23)
		{
			bool_23 = false;
			Refresh();
		}
	}

	protected internal override void OnGotFocus()
	{
		base.OnGotFocus();
		if (control_0 != null && !control_0.get_Focused() && !base.IsOnCustomizeMenu && !base.IsOnCustomizeDialog && !method_22())
		{
			control_0.Focus();
		}
	}

	private bool method_22()
	{
		if (ContainerControl is IBarDesignerServices && ((IBarDesignerServices)ContainerControl).Designer != null)
		{
			return false;
		}
		return base.DesignMode;
	}
}
