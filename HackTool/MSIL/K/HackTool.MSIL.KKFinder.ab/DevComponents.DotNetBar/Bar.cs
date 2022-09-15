using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;
using System.Xml;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;
using Microsoft.Win32;

namespace DevComponents.DotNetBar;

[Designer(typeof(BarDesigner))]
[ToolboxItem(true)]
[ToolboxBitmap(typeof(Bar), "Bar.ico")]
[ComVisible(false)]
[DefaultEvent("ItemClick")]
public class Bar : Control, ISupportInitialize, IBarDesignerServices, IAccessibilitySupport, IBarImageSize, ICustomSerialization, IDockInfo, IOwner, IOwnerLocalize, IOwnerMenuSupport, IRenderingSupport, Interface5
{
	private struct Struct11
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public bool Boolean_0
		{
			get
			{
				if (int_0 == 0 && int_1 == 0 && int_2 == 0)
				{
					return int_3 == 0;
				}
				return false;
			}
		}
	}

	private class Class179
	{
		private EventHandler eventHandler_0;

		private EventHandler eventHandler_1;

		private EventHandler eventHandler_2;

		private EventHandler eventHandler_3;

		private EventHandler eventHandler_4;

		private EventHandler eventHandler_5;

		private EventHandler eventHandler_6;

		private EventHandler eventHandler_7;

		public Rectangle rectangle_0;

		public Rectangle rectangle_1;

		public Rectangle rectangle_2;

		public Rectangle rectangle_3;

		public Size size_0 = new Size(14, 14);

		private bool bool_0;

		private bool bool_1;

		private bool bool_2;

		private bool bool_3;

		private bool bool_4;

		private bool bool_5;

		private bool bool_6;

		private bool bool_7;

		public bool Boolean_0
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
					if (eventHandler_0 != null)
					{
						eventHandler_0(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_1
		{
			get
			{
				return bool_6;
			}
			set
			{
				if (bool_6 != value)
				{
					bool_6 = value;
					if (eventHandler_6 != null)
					{
						eventHandler_6(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_2
		{
			get
			{
				return bool_1;
			}
			set
			{
				if (bool_1 != value)
				{
					bool_1 = value;
					if (eventHandler_1 != null)
					{
						eventHandler_1(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_3
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
					if (eventHandler_3 != null)
					{
						eventHandler_3(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_4
		{
			get
			{
				return bool_7;
			}
			set
			{
				if (bool_7 != value)
				{
					bool_7 = value;
					if (eventHandler_7 != null)
					{
						eventHandler_7(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_5
		{
			get
			{
				return bool_3;
			}
			set
			{
				if (bool_3 != value)
				{
					bool_3 = value;
					if (eventHandler_4 != null)
					{
						eventHandler_4(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_6
		{
			get
			{
				return bool_4;
			}
			set
			{
				if (bool_4 != value)
				{
					bool_4 = value;
					if (eventHandler_2 != null)
					{
						eventHandler_2(this, new EventArgs());
					}
				}
			}
		}

		public bool Boolean_7
		{
			get
			{
				return bool_5;
			}
			set
			{
				if (bool_5 != value)
				{
					bool_5 = value;
					if (eventHandler_5 != null)
					{
						eventHandler_5(this, new EventArgs());
					}
				}
			}
		}

		public event EventHandler Event_0
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

		public event EventHandler Event_1
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

		public event EventHandler Event_2
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
			}
		}

		public event EventHandler Event_3
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
			}
		}

		public event EventHandler Event_4
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_4 = (EventHandler)Delegate.Combine(eventHandler_4, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_4 = (EventHandler)Delegate.Remove(eventHandler_4, value);
			}
		}

		public event EventHandler Event_5
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
			}
		}

		public event EventHandler Event_6
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_6 = (EventHandler)Delegate.Combine(eventHandler_6, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_6 = (EventHandler)Delegate.Remove(eventHandler_6, value);
			}
		}

		public event EventHandler Event_7
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
			}
		}

		public Class179(Rectangle closerect, Rectangle custrect, bool mouseoverclose, bool mouseovercustomize, bool mousednclose, bool mousedncust)
		{
			rectangle_0 = closerect;
			rectangle_1 = custrect;
			Boolean_0 = mouseoverclose;
			Boolean_2 = mouseovercustomize;
			Boolean_3 = mousednclose;
			Boolean_5 = mousedncust;
			Boolean_6 = false;
			Boolean_7 = false;
			rectangle_2 = Rectangle.Empty;
		}
	}

	public class BarAccessibleObject : ControlAccessibleObject
	{
		private Bar bar_0;

		public override string Name
		{
			get
			{
				if (bar_0 != null && !((Control)bar_0).get_IsDisposed())
				{
					return ((Control)bar_0).get_AccessibleName();
				}
				return "";
			}
			set
			{
				if (bar_0 != null && !((Control)bar_0).get_IsDisposed())
				{
					((Control)bar_0).set_AccessibleName(value);
				}
			}
		}

		public override string Description
		{
			get
			{
				if (bar_0 != null && !((Control)bar_0).get_IsDisposed())
				{
					return ((Control)bar_0).get_AccessibleDescription();
				}
				return "";
			}
		}

		public override AccessibleRole Role
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				if (bar_0 == null || ((Control)bar_0).get_IsDisposed())
				{
					return (AccessibleRole)0;
				}
				return ((Control)bar_0).get_AccessibleRole();
			}
		}

		public override AccessibleObject Parent
		{
			get
			{
				if (bar_0 != null && !((Control)bar_0).get_IsDisposed())
				{
					return ((Control)bar_0).get_Parent().get_AccessibilityObject();
				}
				return null;
			}
		}

		public override Rectangle Bounds
		{
			get
			{
				if (bar_0 != null && !((Control)bar_0).get_IsDisposed() && ((Control)bar_0).get_Parent() != null)
				{
					return ((Control)bar_0).get_Parent().RectangleToScreen(((Control)bar_0).get_Bounds());
				}
				return Rectangle.Empty;
			}
		}

		public override AccessibleStates State
		{
			get
			{
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004b: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				if (bar_0 == null || ((Control)bar_0).get_IsDisposed())
				{
					return (AccessibleStates)0;
				}
				AccessibleStates val;
				if (bar_0.GrabHandleStyle != 0 && bar_0.GrabHandleStyle != eGrabHandleStyle.ResizeHandle)
				{
					val = (AccessibleStates)262144;
					if (bar_0.DockSide == eDockSide.None)
					{
						val = (AccessibleStates)(val | 0x1000);
					}
				}
				else
				{
					val = (AccessibleStates)0;
				}
				return val;
			}
		}

		public BarAccessibleObject(Bar owner)
			: base((Control)(object)owner)
		{
			bar_0 = owner;
		}

		internal void method_0(BaseItem baseItem_0, AccessibleEvents accessibleEvents_0)
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			int num = bar_0.Items.IndexOf(baseItem_0);
			if (num >= 0 && bar_0 != null && !((Control)bar_0).get_IsDisposed())
			{
				((Control)bar_0).AccessibilityNotifyClients(accessibleEvents_0, num);
			}
		}

		public override int GetChildCount()
		{
			if (bar_0 != null && !((Control)bar_0).get_IsDisposed() && bar_0.Items != null)
			{
				return bar_0.Items.Count;
			}
			return 0;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			if (bar_0 != null && !((Control)bar_0).get_IsDisposed() && bar_0.Items != null)
			{
				return bar_0.Items[iIndex].AccessibleObject;
			}
			return null;
		}
	}

	private const int int_0 = 33;

	private const int int_1 = 3;

	private const int int_2 = 4;

	private const long long_0 = 2147483648L;

	private const long long_1 = 67108864L;

	private const long long_2 = 33554432L;

	private const long long_3 = 8L;

	private const long long_4 = 128L;

	private const long long_5 = 268435456L;

	private const int int_3 = 70;

	private const int int_4 = 71;

	private const int int_5 = 1;

	private const int int_6 = 2;

	private const int int_7 = 3;

	private const int int_8 = 4;

	private const int int_9 = 5;

	private const int int_10 = 6;

	private const int int_11 = 7;

	private const int int_12 = 8;

	private const int int_13 = 9;

	private const int int_14 = 10;

	private const int int_15 = 11;

	private const int int_16 = 12;

	private const int int_17 = 13;

	private const int int_18 = 14;

	private const int int_19 = 15;

	private const int int_20 = 3;

	private const int int_21 = 7;

	private const int int_22 = 7;

	private const int int_23 = 17;

	private const int int_24 = 23;

	private const int int_25 = 20;

	private const int int_26 = 25;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private DotNetBarManager.DockTabChangeEventHandler dockTabChangeEventHandler_0;

	private EventHandler eventHandler_4;

	private EventHandler eventHandler_5;

	private DotNetBarManager.BarClosingEventHandler barClosingEventHandler_0;

	private DotNetBarManager.AutoHideDisplayEventHandler autoHideDisplayEventHandler_0;

	private EventHandler eventHandler_6;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private DotNetBarManager.PopupOpenEventHandler popupOpenEventHandler_0;

	private EventHandler eventHandler_9;

	private EventHandler eventHandler_10;

	private EventHandler eventHandler_11;

	private DockTabClosingEventHandler dockTabClosingEventHandler_0;

	private SerializeItemEventHandler serializeItemEventHandler_0;

	private SerializeItemEventHandler serializeItemEventHandler_1;

	private EventHandler eventHandler_12;

	private RenderBarEventHandler renderBarEventHandler_0;

	private RenderBarEventHandler renderBarEventHandler_1;

	private DotNetBarManager.LocalizeStringEventHandler localizeStringEventHandler_0;

	private BaseItem baseItem_0;

	private Point point_0;

	private object object_0;

	private Rectangle rectangle_0;

	private SideBarImage sideBarImage_0;

	private Rectangle rectangle_1;

	private GenericItemContainer genericItemContainer_0;

	private int int_27;

	private eBarState eBarState_0;

	private eGrabHandleStyle eGrabHandleStyle_0;

	private Rectangle rectangle_2;

	private int int_28;

	private int int_29;

	private object object_1;

	private Point point_1;

	private Size size_0;

	private bool bool_0;

	private int int_30 = -1;

	private Rectangle rectangle_3;

	private Size size_1 = Size.Empty;

	private Size size_2 = Size.Empty;

	private int int_31;

	private DockSiteInfo dockSiteInfo_0;

	private Rectangle rectangle_4;

	private DockSiteInfo dockSiteInfo_1;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private Form0 form0_0;

	private bool bool_5;

	private int int_32;

	private bool bool_6 = true;

	private bool bool_7 = true;

	private bool bool_8 = true;

	private bool bool_9 = true;

	private bool bool_10;

	private bool bool_11 = true;

	private bool bool_12 = true;

	private bool bool_13 = true;

	private bool bool_14;

	private bool bool_15;

	private bool bool_16;

	private bool bool_17 = true;

	private eBorderType eBorderType_0;

	private Color color_0 = SystemColors.ControlDark;

	private bool bool_18;

	private Class179 class179_0 = new Class179(Rectangle.Empty, Rectangle.Empty, mouseoverclose: false, mouseovercustomize: false, mousednclose: false, mousedncust: false);

	private ePopupAnimation ePopupAnimation_0 = ePopupAnimation.ManagerControlled;

	private Control8 control8_0;

	private eBarImageSize eBarImageSize_0;

	private Color color_1 = Color.Empty;

	private Color color_2 = Color.Empty;

	private PopupItem popupItem_0;

	private TabStrip tabStrip_0;

	private bool bool_19;

	private bool bool_20 = true;

	private bool bool_21;

	private bool bool_22;

	private bool bool_23;

	private bool bool_24;

	private ColorScheme colorScheme_0;

	internal bool bool_25;

	private bool bool_26;

	private Struct11 struct11_0 = default(Struct11);

	private Class77 class77_0;

	private Class78 class78_0;

	private Class79 class79_0;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class64 class64_0;

	private int int_33;

	private int int_34;

	private Bar bar_0;

	private eTabStripAlignment eTabStripAlignment_0 = eTabStripAlignment.Bottom;

	private bool bool_27 = true;

	private Point point_2 = Point.Empty;

	private bool bool_28;

	internal bool bool_29;

	private bool bool_30;

	private bool bool_31;

	private BaseItem baseItem_1;

	private int int_35 = 100;

	private eBackgroundImagePosition eBackgroundImagePosition_0;

	private byte byte_0 = byte.MaxValue;

	private bool bool_32 = true;

	private bool bool_33 = true;

	protected ToolTip m_ToolTipWnd;

	private int int_36 = -1;

	private bool bool_34;

	private bool bool_35 = true;

	private bool bool_36;

	private bool bool_37;

	private bool bool_38;

	private int int_37 = -1;

	private bool bool_39;

	private bool bool_40 = true;

	private PopupItem popupItem_1;

	private bool bool_41;

	private bool bool_42 = true;

	private bool bool_43;

	private BarBaseControlDesigner barBaseControlDesigner_0;

	private bool bool_44;

	private bool bool_45;

	internal Hashtable hashtable_0 = new Hashtable();

	private int int_38 = 3;

	private bool bool_46;

	private bool bool_47;

	private eBarType eBarType_0;

	private bool bool_48 = true;

	private bool bool_49;

	private bool bool_50;

	internal bool bool_51;

	private BaseRenderer baseRenderer_0;

	private BaseRenderer baseRenderer_1;

	private eRenderMode eRenderMode_0 = eRenderMode.Global;

	private bool bool_52;

	private bool bool_53;

	private Rectangle rectangle_5 = Rectangle.Empty;

	private Form form_0;

	private bool bool_54 = true;

	private bool bool_55;

	private bool bool_56;

	private bool bool_57;

	private Component component_0;

	private bool bool_58;

	private bool bool_59 = true;

	private BaseItem baseItem_2;

	private BaseItem baseItem_3;

	private Hashtable hashtable_1 = new Hashtable();

	private EventHandler eventHandler_13;

	private ImageList imageList_0;

	private ImageList imageList_1;

	private ImageList imageList_2;

	private ArrayList arrayList_0 = new ArrayList();

	private bool bool_60;

	private Class94 class94_0;

	private bool bool_61;

	private bool bool_62;

	private bool bool_63;

	private bool bool_64;

	private bool bool_65;

	private int int_39 = -1;

	private bool bool_66;

	private IDesignTimeProvider idesignTimeProvider_0;

	private BaseItem baseItem_4;

	private IDesignTimeProvider idesignTimeProvider_1;

	[DevCoBrowsable(false)]
	[DefaultValue(null)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public object Owner
	{
		get
		{
			if (baseItem_0 is CustomizeItem)
			{
				return baseItem_0.GetOwner();
			}
			if ((((Control)this).get_Parent() != null && !(((Control)this).get_Parent() is Form0) && !(((Control)this).get_Parent() is DockSite) && !AutoHide && !bool_56) || (((Control)this).get_Parent() == null && object_1 == null))
			{
				return this;
			}
			return object_1;
		}
		set
		{
			object_1 = value;
			if (((Component)this).DesignMode && ((Component)(object)this).Site != null && tabStrip_0 != null)
			{
				method_120(bool_67: false);
			}
		}
	}

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Control)this).get_CreateParams();
			if (bool_25)
			{
				return createParams;
			}
			if (eBarState_0 == eBarState.Popup && (baseItem_0 == null || baseItem_0.Site == null || !baseItem_0.Site.DesignMode))
			{
				createParams.set_Style(-2046820352);
				createParams.set_ExStyle(136);
			}
			createParams.set_Caption("");
			return createParams;
		}
	}

	internal bool Boolean_0
	{
		get
		{
			return bool_35;
		}
		set
		{
			if (bool_35 != value && Visible)
			{
				bool_35 = value;
				if (bool_35)
				{
					Class92.SendMessage(((Control)this).get_Handle(), 11, 1, 0);
				}
				else
				{
					Class92.SendMessage(((Control)this).get_Handle(), 11, 0, 0);
				}
			}
		}
	}

	BaseItem IAccessibilitySupport.DoDefaultActionItem
	{
		get
		{
			return baseItem_1;
		}
		set
		{
			baseItem_1 = value;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Control LastFocusControl
	{
		get
		{
			if (((Control)this).get_Focused() && int_32 != 0)
			{
				return Control.FromChildHandle(new IntPtr(int_32));
			}
			return null;
		}
	}

	private bool Boolean_1
	{
		get
		{
			if (Style != eDotNetBarStyle.Office2003 && Style != eDotNetBarStyle.VS2005)
			{
				return Class109.smethod_69(Style);
			}
			return true;
		}
	}

	[Browsable(false)]
	[DefaultValue(eRenderMode.Global)]
	public eRenderMode RenderMode
	{
		get
		{
			return eRenderMode_0;
		}
		set
		{
			if (eRenderMode_0 != value)
			{
				eRenderMode_0 = value;
				((Control)this).Invalidate(true);
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(false)]
	public BaseRenderer Renderer
	{
		get
		{
			return baseRenderer_1;
		}
		set
		{
			baseRenderer_1 = value;
		}
	}

	private bool Boolean_2 => renderBarEventHandler_1 != null;

	private bool Boolean_3
	{
		get
		{
			if (Style == eDotNetBarStyle.VS2005 && LayoutType == eLayoutType.DockContainer)
			{
				return false;
			}
			return true;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			if (IsThemed && genericItemContainer_0.m_BackgroundColor.IsEmpty)
			{
				return true;
			}
			return false;
		}
	}

	internal bool Boolean_5
	{
		get
		{
			if (Style == eDotNetBarStyle.Office2007)
			{
				return false;
			}
			if (!IsThemed && (eBarState_0 != eBarState.Floating || !Class109.Boolean_0 || !Class58.bool_0 || LayoutType != eLayoutType.DockContainer))
			{
				return false;
			}
			return true;
		}
	}

	internal BaseItem BaseItem_0 => baseItem_0;

	[Browsable(false)]
	public BaseItem ParentItem
	{
		get
		{
			if (baseItem_0 != null)
			{
				return baseItem_0;
			}
			return genericItemContainer_0;
		}
		set
		{
			method_34();
			if (genericItemContainer_0.SubItems.Count > 0)
			{
				genericItemContainer_0.SubItems.Clear();
			}
			baseItem_0 = value;
			if (baseItem_0 == null || baseItem_0.SubItems.Count == 0)
			{
				return;
			}
			genericItemContainer_0.Style = baseItem_0.Style;
			BaseItem baseItem = baseItem_0.SubItems[0];
			if (baseItem != null)
			{
				object_0 = baseItem.ContainerControl;
			}
			else
			{
				object_0 = null;
			}
			genericItemContainer_0.SubItems.Boolean_0 = false;
			foreach (BaseItem subItem in baseItem_0.SubItems)
			{
				subItem.ContainerControl = this;
				genericItemContainer_0.SubItems.Add(subItem);
			}
			genericItemContainer_0.SubItems.Boolean_0 = true;
			if (baseItem_0.Displayed)
			{
				object containerControl = baseItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (BaseItem.IsHandleValid(val))
				{
					point_0 = val.PointToScreen(new Point(baseItem_0.LeftInternal, baseItem_0.TopInternal));
					val = null;
				}
			}
		}
	}

	internal int Int32_0
	{
		get
		{
			if (((Control)this).get_Parent() != null && int_34 > 0)
			{
				int num = ((Control)this).get_Parent().get_Height() * int_34 / 1000;
				Size size = method_134(MinimumDockSize(eOrientation.Horizontal));
				if (num < size.Height)
				{
					num = size.Height;
				}
				return num;
			}
			return 0;
		}
		set
		{
			if (((Control)this).get_Parent() != null && value > 0)
			{
				if (value > ((Control)this).get_Parent().get_Height())
				{
					value = ((Control)this).get_Parent().get_Height();
				}
				int_34 = (int)((float)value / (float)((Control)this).get_Parent().get_Height() * 1000f);
			}
			else
			{
				int_34 = 0;
			}
		}
	}

	internal int Int32_1
	{
		get
		{
			if (((Control)this).get_Parent() != null && int_33 > 0)
			{
				return ((Control)this).get_Parent().get_Width() * int_33 / 1000;
			}
			return 0;
		}
		set
		{
			if (((Control)this).get_Parent() != null && value > 0)
			{
				if (value > ((Control)this).get_Parent().get_Width())
				{
					value = ((Control)this).get_Parent().get_Width();
				}
				int_33 = (int)((float)value / (float)((Control)this).get_Parent().get_Width() * 1000f);
			}
			else
			{
				int_33 = 0;
			}
		}
	}

	internal int Int32_2
	{
		get
		{
			if (genericItemContainer_0.Int32_1 > 0)
			{
				return genericItemContainer_0.Int32_1 + method_25();
			}
			return 0;
		}
		set
		{
			if (genericItemContainer_0 != null)
			{
				if (value > 0)
				{
					genericItemContainer_0.Int32_1 = value - method_25();
				}
				else
				{
					genericItemContainer_0.Int32_1 = 0;
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool LoadingHideFloating
	{
		get
		{
			return bool_44;
		}
		set
		{
			bool_44 = value;
		}
	}

	internal Bar Bar_0 => bar_0;

	internal bool Boolean_6 => bool_0;

	internal bool Boolean_7 => int_31 != 0;

	internal bool Boolean_8 => bool_54;

	internal Class77 Class77_0
	{
		get
		{
			if (class77_0 == null)
			{
				class77_0 = new Class77((Control)(object)this);
			}
			return class77_0;
		}
	}

	internal Class78 Class78_0
	{
		get
		{
			if (class78_0 == null)
			{
				class78_0 = new Class78((Control)(object)this);
			}
			return class78_0;
		}
	}

	internal Class79 Class79_0
	{
		get
		{
			if (class79_0 == null)
			{
				class79_0 = new Class79((Control)(object)this);
			}
			return class79_0;
		}
	}

	internal Class65 Class65_0
	{
		get
		{
			if (class65_0 == null)
			{
				class65_0 = new Class65((Control)(object)this);
			}
			return class65_0;
		}
	}

	internal Class63 Class63_0
	{
		get
		{
			if (class63_0 == null)
			{
				class63_0 = new Class63((Control)(object)this);
			}
			return class63_0;
		}
	}

	internal Class64 Class64_0
	{
		get
		{
			if (class64_0 == null)
			{
				class64_0 = new Class64((Control)(object)this);
			}
			return class64_0;
		}
	}

	private int Int32_3
	{
		get
		{
			int num = 0;
			if (baseItem_0 != null && baseItem_0.Style != eDotNetBarStyle.Office2000)
			{
				return 1;
			}
			return 3;
		}
	}

	private int Int32_4
	{
		get
		{
			int num = 0;
			if (baseItem_0 != null && baseItem_0.Style != eDotNetBarStyle.Office2000)
			{
				return 2;
			}
			return 3;
		}
	}

	private int Int32_5
	{
		get
		{
			bool flag = true;
			int num = 0;
			if (object_1 is IOwnerMenuSupport ownerMenuSupport && !ownerMenuSupport.ShowPopupShadow)
			{
				flag = false;
			}
			if (baseItem_0 != null && baseItem_0.Style != eDotNetBarStyle.Office2000)
			{
				if (!Boolean_10 && flag)
				{
					return 3;
				}
				return 1;
			}
			return 3;
		}
	}

	private int Int32_6
	{
		get
		{
			bool flag = true;
			int num = 0;
			if (object_1 is IOwnerMenuSupport ownerMenuSupport && !ownerMenuSupport.ShowPopupShadow)
			{
				flag = false;
			}
			if (baseItem_0 != null && baseItem_0.Style != eDotNetBarStyle.Office2000)
			{
				if (!Boolean_10 && flag)
				{
					return 4;
				}
				return 2;
			}
			return 3;
		}
	}

	internal bool Boolean_9
	{
		get
		{
			if (bool_25)
			{
				return false;
			}
			if (object_1 is IOwnerMenuSupport ownerMenuSupport)
			{
				if (baseItem_0 != null && baseItem_0.Style == eDotNetBarStyle.Office2000)
				{
					if (ownerMenuSupport.MenuDropShadow == eMenuDropShadow.Show)
					{
						return true;
					}
					return false;
				}
				return ownerMenuSupport.ShowPopupShadow;
			}
			if (baseItem_0 != null && baseItem_0.Style == eDotNetBarStyle.Office2000)
			{
				return false;
			}
			return true;
		}
	}

	internal bool Boolean_10
	{
		get
		{
			if (Environment.OSVersion.Version.Major < 5)
			{
				return false;
			}
			if (object_1 is IOwnerMenuSupport ownerMenuSupport && !ownerMenuSupport.AlphaBlendShadow)
			{
				return false;
			}
			return Class92.Boolean_3;
		}
	}

	internal bool Boolean_11
	{
		get
		{
			return bool_38;
		}
		set
		{
			if (bool_38 == value)
			{
				return;
			}
			bool_38 = value;
			if (bool_38)
			{
				genericItemContainer_0.method_29();
				if (object_1 is DotNetBarManager dotNetBarManager)
				{
					dotNetBarManager.FocusedBar = this;
				}
			}
			else
			{
				if (genericItemContainer_0 != null)
				{
					genericItemContainer_0.AutoExpand = false;
					genericItemContainer_0.method_30();
					genericItemContainer_0.ContainerLostFocus(appLostFocus: false);
				}
				if (object_1 is DotNetBarManager dotNetBarManager2)
				{
					dotNetBarManager2.FocusedBar = null;
				}
			}
			if (MenuBar)
			{
				((Control)this).Refresh();
			}
		}
	}

	internal int Int32_7
	{
		get
		{
			return int_27;
		}
		set
		{
			int_27 = value;
		}
	}

	[DefaultValue(ePopupAnimation.ManagerControlled)]
	[Browsable(false)]
	public ePopupAnimation PopupAnimation
	{
		get
		{
			return ePopupAnimation_0;
		}
		set
		{
			ePopupAnimation_0 = value;
		}
	}

	bool ICustomSerialization.HasSerializeItemHandlers
	{
		get
		{
			bool flag = serializeItemEventHandler_0 != null;
			if (Owner != this && Owner is ICustomSerialization)
			{
				flag |= ((ICustomSerialization)Owner).HasSerializeItemHandlers;
			}
			return flag;
		}
	}

	bool ICustomSerialization.HasDeserializeItemHandlers
	{
		get
		{
			bool flag = serializeItemEventHandler_1 != null;
			if (Owner != this && Owner is ICustomSerialization)
			{
				flag |= ((ICustomSerialization)Owner).HasDeserializeItemHandlers;
			}
			return flag;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string Definition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			method_76(xmlDocument);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			method_77(xmlDocument);
		}
	}

	private bool Boolean_12
	{
		get
		{
			eDockSide dockSide = DockSide;
			if (dockSide != 0 && dockSide != eDockSide.Left && dockSide != eDockSide.Right)
			{
				return false;
			}
			return true;
		}
	}

	private bool Boolean_13
	{
		get
		{
			eDockSide dockSide = DockSide;
			if (dockSide != 0 && dockSide != eDockSide.Top && dockSide != eDockSide.Bottom)
			{
				return false;
			}
			return true;
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Indicates whether layout changes are saved for this bar")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	public bool SaveLayoutChanges
	{
		get
		{
			return bool_42;
		}
		set
		{
			bool_42 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public string LayoutDefinition
	{
		get
		{
			XmlDocument xmlDocument = new XmlDocument();
			method_83(xmlDocument);
			return xmlDocument.OuterXml;
		}
		set
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(value);
			method_84(xmlDocument);
		}
	}

	[DevCoBrowsable(true)]
	[Description("Specifies background image position when container is larger than image.")]
	[Category("Appearance")]
	[DefaultValue(eBackgroundImagePosition.Stretch)]
	[Browsable(true)]
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
				((Control)this).Refresh();
			}
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(byte.MaxValue)]
	[Description("Specifies the transparency of background image.")]
	[Browsable(true)]
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
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(false)]
	public SideBarImage SideBar
	{
		get
		{
			return sideBarImage_0;
		}
		set
		{
			sideBarImage_0 = value;
		}
	}

	[DevCoBrowsable(true)]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			if (((Control)this).get_Text() != value)
			{
				((Control)this).set_Text(value);
				if (Visible && (eBarState_0 == eBarState.Floating || ((eBarState_0 == eBarState.Docked || eBarState_0 == eBarState.AutoHide) && (eGrabHandleStyle_0 == eGrabHandleStyle.Caption || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted))))
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
			if (((Control)this).get_Font() != null)
			{
				bool_23 = ShouldSerializeFont();
			}
		}
	}

	protected internal bool IsThemed
	{
		get
		{
			if (bool_26 && Style != eDotNetBarStyle.Office2000 && Class109.Boolean_0 && Class58.bool_0)
			{
				return true;
			}
			return false;
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	[Description("Specifies whether SideBar is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[Browsable(true)]
	public virtual bool ThemeAware
	{
		get
		{
			return bool_26;
		}
		set
		{
			bool_26 = value;
			genericItemContainer_0.ThemeAware = value;
		}
	}

	[Browsable(false)]
	public eBarState BarState => eBarState_0;

	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public SubItemsCollection Items
	{
		get
		{
			if (genericItemContainer_0 == null)
			{
				return null;
			}
			return genericItemContainer_0.SubItems;
		}
	}

	[Browsable(false)]
	public GenericItemContainer ItemsContainer => genericItemContainer_0;

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether the items that could not be displayed on the non-wrap Bar are displayed on popup menu or popup Bar.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public bool DisplayMoreItemsOnMenu
	{
		get
		{
			return genericItemContainer_0.MoreItemsOnMenu;
		}
		set
		{
			genericItemContainer_0.MoreItemsOnMenu = value;
		}
	}

	[Description("Indicates the spacing in pixels between the sub-items.")]
	[DefaultValue(0)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Layout")]
	public int ItemSpacing
	{
		get
		{
			return genericItemContainer_0.ItemSpacing;
		}
		set
		{
			if (genericItemContainer_0.ItemSpacing != value)
			{
				genericItemContainer_0.ItemSpacing = value;
				RecalcLayout();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(1)]
	[Category("Layout")]
	[Description("Gets/Sets the padding in pixels. This represents the spacing between the top of the bar and the top of the item.")]
	[Browsable(true)]
	public int PaddingTop
	{
		get
		{
			return genericItemContainer_0.PaddingTop;
		}
		set
		{
			if (genericItemContainer_0.PaddingTop != value)
			{
				genericItemContainer_0.PaddingTop = value;
				if (((Component)this).DesignMode)
				{
					RecalcLayout();
				}
			}
		}
	}

	[Description("Gets/Sets the padding in pixels. This represents the spacing between the bottom edge of the bar and the bottom of the item.")]
	[Category("Layout")]
	[Browsable(true)]
	[DefaultValue(1)]
	[DevCoBrowsable(true)]
	public int PaddingBottom
	{
		get
		{
			return genericItemContainer_0.PaddingBottom;
		}
		set
		{
			if (genericItemContainer_0.PaddingBottom != value)
			{
				genericItemContainer_0.PaddingBottom = value;
				if (((Component)this).DesignMode)
				{
					RecalcLayout();
				}
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(1)]
	[DevCoBrowsable(true)]
	[Description("Gets/Sets the padding in pixels. This represents the spacing between the left edge of the bar and the left position of the first item.")]
	[Category("Layout")]
	public int PaddingLeft
	{
		get
		{
			return genericItemContainer_0.PaddingLeft;
		}
		set
		{
			if (genericItemContainer_0.PaddingLeft != value)
			{
				genericItemContainer_0.PaddingLeft = value;
				if (((Component)this).DesignMode)
				{
					RecalcLayout();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(1)]
	[Category("Layout")]
	[Description("Gets/Sets the padding in pixels. This represents the spacing between the right edge of the bar and the right side of the last item.")]
	public int PaddingRight
	{
		get
		{
			return genericItemContainer_0.PaddingRight;
		}
		set
		{
			if (genericItemContainer_0.PaddingRight != value)
			{
				genericItemContainer_0.PaddingRight = value;
				if (((Component)this).DesignMode)
				{
					RecalcLayout();
				}
			}
		}
	}

	[DefaultValue(false)]
	[Description("Indicates Bar layout type.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Behavior")]
	public bool MenuBar
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			method_1();
		}
	}

	[Description("Indicates visual type of the bar. The type specified here is used to determine the appearance of the bar.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(eBarType.Toolbar)]
	[Browsable(true)]
	public eBarType BarType
	{
		get
		{
			return eBarType_0;
		}
		set
		{
			eBarType_0 = value;
			if (eBarType_0 == eBarType.StatusBar)
			{
				genericItemContainer_0.EContainerVerticalAlignment_0 = eContainerVerticalAlignment.Middle;
			}
			else
			{
				genericItemContainer_0.EContainerVerticalAlignment_0 = eContainerVerticalAlignment.Top;
			}
			((Control)this).Invalidate();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Description("Gets or sets Bar Color Scheme.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Editor(typeof(ColorSchemeVSEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public ColorScheme ColorScheme
	{
		get
		{
			return colorScheme_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentException("NULL is not a valid value for this property.");
			}
			colorScheme_0 = value;
			if (Visible)
			{
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Category("Appearance")]
	[Description("Indicates the background color of the caption (Title bar).")]
	public Color CaptionBackColor
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
				((Control)this).Refresh();
			}
		}
	}

	[Category("Appearance")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[DevCoBrowsable(true)]
	[Description("Indicates the caption (Title bar) text color.")]
	public Color CaptionForeColor
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
				((Control)this).Refresh();
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether toolbars with appropriate style appear with rounded corners.")]
	[DefaultValue(true)]
	[DevCoBrowsable(false)]
	public bool RoundCorners
	{
		get
		{
			return bool_48;
		}
		set
		{
			bool_48 = value;
			RecalcLayout();
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Specifies the visual style of the Bar.")]
	[DefaultValue(eDotNetBarStyle.OfficeXP)]
	public eDotNetBarStyle Style
	{
		get
		{
			return genericItemContainer_0.Style;
		}
		set
		{
			colorScheme_0.method_0(value);
			genericItemContainer_0.Style = value;
			if ((value == eDotNetBarStyle.Office2003 || value == eDotNetBarStyle.VS2005 || Class109.smethod_69(value)) && LayoutType == eLayoutType.Toolbar && GrabHandleStyle != 0 && GrabHandleStyle != eGrabHandleStyle.ResizeHandle)
			{
				eGrabHandleStyle_0 = eGrabHandleStyle.Office2003;
			}
			method_117(value);
			if (AutoHide)
			{
				AutoHidePanel autoHidePanel = GetAutoHidePanel();
				if (autoHidePanel != null)
				{
					autoHidePanel.Style = value;
				}
			}
			else
			{
				((Control)this).Invalidate();
				RecalcLayout();
			}
		}
	}

	internal bool Boolean_14 => bool_5;

	[Browsable(false)]
	public bool WrapItems => genericItemContainer_0.WrapItems;

	[Description("Indicates whether the items will be wrapped into next line when Bar is full. Applies only to Bars that are docked.")]
	[DefaultValue(false)]
	[Category("Layout")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool WrapItemsDock
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
	[DevCoBrowsable(true)]
	[Category("Layout")]
	[Description("Indicates whether the items will be wrapped into next line when Bar is full. Applies only to Bars that are floating.")]
	[DefaultValue(true)]
	public bool WrapItemsFloat
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

	[Category("Appearance")]
	[DefaultValue(eGrabHandleStyle.None)]
	[Description("Indicates the grab handle style of the docked Bars.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public eGrabHandleStyle GrabHandleStyle
	{
		get
		{
			return eGrabHandleStyle_0;
		}
		set
		{
			if (eGrabHandleStyle_0 != value)
			{
				eGrabHandleStyle_0 = value;
				method_1();
				if (Visible && !bool_55)
				{
					RecalcLayout();
				}
			}
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public Rectangle GrabHandleRect => rectangle_2;

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Determines whether bar can be hidden.")]
	[Category("Behavior")]
	[Browsable(true)]
	public bool CanHide
	{
		get
		{
			return bool_15;
		}
		set
		{
			if (bool_15 == value)
			{
				return;
			}
			bool_15 = value;
			if (eBarState_0 == eBarState.Floating || (eBarState_0 == eBarState.Docked && (eGrabHandleStyle_0 == eGrabHandleStyle.Caption || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted)))
			{
				((Control)this).Refresh();
			}
			method_115();
			if (tabStrip_0 != null && Class109.smethod_11((Control)(object)this))
			{
				tabStrip_0.RecalcSize();
				if (((Component)this).DesignMode)
				{
					((Control)tabStrip_0).Refresh();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[DefaultValue(eBorderType.None)]
	[Browsable(true)]
	[Description("Indicates border style when Bar is docked.")]
	public eBorderType DockedBorderStyle
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
				if (eBarState_0 == eBarState.Docked && Visible)
				{
					RecalcLayout();
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	[Description("Indicates whether floating bar is hidden when application loses focus.")]
	[Browsable(false)]
	[Category("Docking")]
	public bool HideFloatingInactive
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

	[DevCoBrowsable(true)]
	[Description("Indicates whether tab navigation buttons are shown for tabbed dockable bars.")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Docking")]
	public bool TabNavigation
	{
		get
		{
			return bool_28;
		}
		set
		{
			if (bool_28 != value)
			{
				bool_28 = value;
				method_115();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates the border line color when docked border is a single line.")]
	[Browsable(true)]
	[Category("Appearance")]
	public Color SingleLineColor
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
				if (eBarState_0 == eBarState.Docked && Visible && eBorderType_0 == eBorderType.SingleLine)
				{
					((Control)this).Refresh();
				}
			}
		}
	}

	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	public bool Visible
	{
		get
		{
			if (eBarState_0 == eBarState.Floating && form0_0 != null)
			{
				return ((Control)form0_0).get_Visible();
			}
			return ((Control)this).get_Visible();
		}
		set
		{
			bool_54 = value;
			if (((Control)this).get_Visible() == value)
			{
				if (!value)
				{
					((Control)this).set_Visible(false);
				}
			}
			else if (value)
			{
				method_97();
			}
			else
			{
				method_95();
			}
		}
	}

	[Browsable(false)]
	public int VisibleItemCount => genericItemContainer_0.VisibleSubItems;

	[DevCoBrowsable(true)]
	[Browsable(false)]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Description("Determines whether end-user can drag and drop items on the Bar.")]
	public bool AcceptDropItems
	{
		get
		{
			return bool_17;
		}
		set
		{
			bool_17 = value;
		}
	}

	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Gets or sets whether items on the Bar can be customized.")]
	public bool CanCustomize
	{
		get
		{
			if (genericItemContainer_0 != null)
			{
				return genericItemContainer_0.CanCustomize;
			}
			return false;
		}
		set
		{
			if (!((Component)this).DesignMode && genericItemContainer_0 != null)
			{
				genericItemContainer_0.CanCustomize = value;
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool CustomBar
	{
		get
		{
			return bool_18;
		}
		set
		{
			bool_18 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Design")]
	[Browsable(false)]
	[Description("Bar name that can be used to identify Bar from code.")]
	public string Name
	{
		get
		{
			return ((Control)this).get_Name();
		}
		set
		{
			((Control)this).set_Name(value);
			if (((Component)(object)this).Site != null)
			{
				((Component)(object)this).Site!.Name = value;
			}
		}
	}

	[Category("Behavior")]
	[Description("Specifies the Image size that will be used by items on this bar.")]
	[DevCoBrowsable(true)]
	[DefaultValue(eBarImageSize.Default)]
	[Browsable(true)]
	public eBarImageSize ImageSize
	{
		get
		{
			return eBarImageSize_0;
		}
		set
		{
			if (eBarImageSize_0 != value)
			{
				eBarImageSize_0 = value;
				genericItemContainer_0.RefreshImageSize();
				RecalcLayout();
			}
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(eLayoutType.Toolbar)]
	[Description("Indicates Bar layout type.")]
	public eLayoutType LayoutType
	{
		get
		{
			if (genericItemContainer_0 == null)
			{
				return eLayoutType.Toolbar;
			}
			return genericItemContainer_0.LayoutType;
		}
		set
		{
			if (genericItemContainer_0.LayoutType != value)
			{
				genericItemContainer_0.LayoutType = value;
				method_1();
				RecalcLayout();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates that buttons will be automatically resized to match the size of the largest button on the bar.")]
	public bool EqualButtonSize
	{
		get
		{
			return genericItemContainer_0.EqualButtonSize;
		}
		set
		{
			if (genericItemContainer_0.EqualButtonSize != value)
			{
				genericItemContainer_0.EqualButtonSize = value;
				RecalcLayout();
			}
		}
	}

	internal int Int32_8
	{
		get
		{
			return int_38;
		}
		set
		{
			int_38 = value;
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Appearance")]
	public bool AntiAlias
	{
		get
		{
			return bool_47;
		}
		set
		{
			if (bool_47 != value)
			{
				bool_47 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether mouse over fade effect for buttons is enabled.")]
	public bool FadeEffect
	{
		get
		{
			return bool_46;
		}
		set
		{
			bool_46 = value;
		}
	}

	internal bool Boolean_15
	{
		get
		{
			if (!((Component)this).DesignMode && genericItemContainer_0.Style == eDotNetBarStyle.Office2007 && (!bool_46 || !Class92.smethod_7()) && !IsThemed && !Class55.bool_1)
			{
				return bool_46;
			}
			return false;
		}
	}

	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Specifies background color of the Bar.")]
	public override Color BackColor
	{
		get
		{
			if (genericItemContainer_0 != null)
			{
				return genericItemContainer_0.BackColor;
			}
			return ((Control)this).get_BackColor();
		}
		set
		{
			if (genericItemContainer_0 != null)
			{
				genericItemContainer_0.BackColor = value;
			}
			else
			{
				((Control)this).set_BackColor(value);
			}
			((Control)this).Invalidate();
		}
	}

	[Category("Behavior")]
	[Description("Indicates the Customize popup menu.")]
	[DefaultValue(null)]
	[Browsable(false)]
	public PopupItem CustomizeMenu
	{
		get
		{
			return popupItem_0;
		}
		set
		{
			popupItem_0 = value;
		}
	}

	[DevCoBrowsable(false)]
	[Description("Indicates the auto-hide side of the parent form where bar is positioned.")]
	[Category("Behavior")]
	[Browsable(false)]
	public eDockSide AutoHideSide
	{
		get
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected I4, but got Unknown
			eDockSide result = eDockSide.None;
			if (bool_19)
			{
				DockStyle dockSide = dockSiteInfo_1.DockSide;
				result = (dockSide - 1) switch
				{
					0 => eDockSide.Top, 
					2 => eDockSide.Left, 
					3 => eDockSide.Right, 
					_ => eDockSide.Bottom, 
				};
			}
			return result;
		}
	}

	[Description("")]
	[DefaultValue(false)]
	[Browsable(true)]
	[Category("Auto-Hide")]
	public bool AutoHideTabTextAlwaysVisible
	{
		get
		{
			return bool_49;
		}
		set
		{
			bool_49 = value;
			if (AutoHide && GetAutoHidePanel() != null)
			{
				((Control)GetAutoHidePanel()).Invalidate();
			}
		}
	}

	[DevCoBrowsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(true)]
	[Description("Indicates whether Bar is in auto-hide state. Applies to non-document dockable bars only.")]
	[DefaultValue(false)]
	[Category("Auto-Hide")]
	public virtual bool AutoHide
	{
		get
		{
			return bool_19;
		}
		set
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Invalid comparison between Unknown and I4
			if (!((Component)this).DesignMode)
			{
				if (bool_55)
				{
					bool_57 = value;
				}
				else if (bool_20 && LayoutType == eLayoutType.DockContainer && (((Control)this).get_Parent() == null || (int)((Control)this).get_Parent().get_Dock() != 5 || !value) && bool_19 != value)
				{
					bool_19 = value;
					method_102();
				}
			}
		}
	}

	[Description("Gets or sets the visibility of the bar when bar is in auto-hide state.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[Category("Auto-Hide")]
	public bool AutoHideVisible
	{
		get
		{
			return Visible;
		}
		set
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			if (AutoHide && Visible != value)
			{
				AutoHidePanel autoHidePanel = method_99(dockSiteInfo_1.DockSide);
				if (value && autoHidePanel != null && bool_19)
				{
					autoHidePanel.method_7(this);
				}
				else if (!value && autoHidePanel != null && bool_19)
				{
					autoHidePanel.method_8(this);
				}
			}
		}
	}

	[Category("Auto-Hide")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Indicates whether Bar can be auto hidden.")]
	public bool CanAutoHide
	{
		get
		{
			return bool_20;
		}
		set
		{
			bool_20 = value;
			if (!bool_20)
			{
				class179_0.rectangle_2 = Rectangle.Empty;
				class179_0.Boolean_6 = false;
				class179_0.Boolean_7 = false;
			}
			if (((Control)this).get_IsHandleCreated())
			{
				((Control)this).Invalidate();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Component GlobalParentComponent
	{
		get
		{
			return component_0;
		}
		set
		{
			component_0 = value;
		}
	}

	[Description("Specifies how long it takes to play the auto-hide animation, in milliseconds. Maximum value is 2000, 0 disables animation.")]
	[DevCoBrowsable(true)]
	[DefaultValue(100)]
	[Browsable(true)]
	[Category("Auto-Hide")]
	public virtual int AutoHideAnimationTime
	{
		get
		{
			return int_35;
		}
		set
		{
			if (value < 0)
			{
				value = 0;
			}
			if (value > 2000)
			{
				value = 2000;
			}
			int_35 = value;
		}
	}

	private bool Boolean_16
	{
		get
		{
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && (eGrabHandleStyle_0 == eGrabHandleStyle.Caption || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) && popupItem_0 != null)
			{
				return true;
			}
			if (genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				if (genericItemContainer_0.HaveCustomizeItem)
				{
					return true;
				}
				return popupItem_0 != null;
			}
			return false;
		}
	}

	private bool Boolean_17 => m_ToolTipWnd != null;

	[DevCoBrowsable(false)]
	[Browsable(false)]
	public TabStrip DockTabControl => tabStrip_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public DockContainerItem SelectedDockContainerItem
	{
		get
		{
			if (genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				return null;
			}
			int selectedDockTab = SelectedDockTab;
			if (selectedDockTab >= 0)
			{
				return Items[selectedDockTab] as DockContainerItem;
			}
			if (VisibleItemCount > 0)
			{
				foreach (BaseItem item in Items)
				{
					if (item.Visible)
					{
						return item as DockContainerItem;
					}
				}
			}
			return null;
		}
		set
		{
			if (genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				throw new InvalidOperationException("Bar type is not dockable window. LayoutType must be set to eLayoutType.DockContainer");
			}
			if (!Items.Contains(value))
			{
				throw new InvalidOperationException("Bar.Items collection does not contain the item");
			}
			SelectedDockTab = Items.IndexOf(value);
		}
	}

	[DefaultValue(-1)]
	[Category("Docking")]
	[Description("Gets or sets the tab (DockContainerItem) index for Bars with LayoutType set to eLayoutType.DockContainer.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public int SelectedDockTab
	{
		get
		{
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && tabStrip_0 != null)
			{
				if (tabStrip_0.SelectedTab != null)
				{
					return genericItemContainer_0.SubItems.IndexOf(tabStrip_0.SelectedTab.AttachedItem);
				}
				return -1;
			}
			return -1;
		}
		set
		{
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			if (tabStrip_0 == null || (tabStrip_0 != null && AutoHide))
			{
				if (value < Items.Count)
				{
					for (int i = 0; i < Items.Count; i++)
					{
						if (i == value && Items[i].Visible)
						{
							Items[i].Displayed = true;
						}
						else
						{
							Items[i].Displayed = false;
						}
					}
					if (tabStrip_0 == null)
					{
						if (Items[value].Displayed)
						{
							method_132(null, Items[value]);
						}
						method_121();
					}
				}
				if (tabStrip_0 == null)
				{
					return;
				}
			}
			if (genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				throw new InvalidOperationException("SelectedDockTab property can be set only for LayoutType=eLayoutType.DockContainer.");
			}
			if (value < 0)
			{
				value = 0;
			}
			if (value >= genericItemContainer_0.SubItems.Count)
			{
				throw new InvalidOperationException("Invalid tab index.");
			}
			BaseItem baseItem = genericItemContainer_0.SubItems[value];
			foreach (TabItem tab in tabStrip_0.Tabs)
			{
				if (tab.AttachedItem == baseItem)
				{
					if (tabStrip_0.SelectedTab == tab && AutoHide)
					{
						method_133(baseItem);
					}
					tabStrip_0.SelectedTab = tab;
					if (AutoHide)
					{
						AutoHidePanel autoHidePanel = method_99(dockSiteInfo_1.DockSide);
						autoHidePanel.DockContainerItem_0 = baseItem as DockContainerItem;
					}
					break;
				}
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Cursor Cursor
	{
		get
		{
			return ((Control)this).get_Cursor();
		}
		set
		{
			((Control)this).set_Cursor(value);
		}
	}

	[Description("Indicates Bar background image.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override RightToLeft RightToLeft
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_RightToLeft();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_RightToLeft(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override ContextMenu ContextMenu
	{
		get
		{
			return ((Control)this).get_ContextMenu();
		}
		set
		{
			((Control)this).set_ContextMenu(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public ImeMode ImeMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_ImeMode();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_ImeMode(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public int TabIndex
	{
		get
		{
			return ((Control)this).get_TabIndex();
		}
		set
		{
			((Control)this).set_TabIndex(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool TabStop
	{
		get
		{
			return ((Control)this).get_TabStop();
		}
		set
		{
			((Control)this).set_TabStop(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public bool CausesValidation
	{
		get
		{
			return ((Control)this).get_CausesValidation();
		}
		set
		{
			((Control)this).set_CausesValidation(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override AnchorStyles Anchor
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Anchor();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Anchor(value);
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			if (DockSide != eDockSide.Document || (int)value == 0 || !(((Control)this).get_Parent() is DockSite))
			{
				((Control)this).set_Dock(value);
			}
		}
	}

	[Browsable(false)]
	public Point Location
	{
		get
		{
			return ((Control)this).get_Location();
		}
		set
		{
			if (eBarState_0 == eBarState.Floating)
			{
				if (form0_0 != null)
				{
					((Form)form0_0).set_Location(value);
				}
			}
			else
			{
				((Control)this).set_Location(value);
			}
		}
	}

	[Browsable(false)]
	public Size Size
	{
		get
		{
			return ((Control)this).get_Size();
		}
		set
		{
			((Control)this).set_Size(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override bool AllowDrop
	{
		get
		{
			return ((Control)this).get_AllowDrop();
		}
		set
		{
			((Control)this).set_AllowDrop(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public Padding Padding
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Padding();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Padding(value);
		}
	}

	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates whether caption button drop-down menu is automatically created")]
	[Browsable(true)]
	[Category("Behavior")]
	public virtual bool AutoCreateCaptionMenu
	{
		get
		{
			return bool_40;
		}
		set
		{
			bool_40 = value;
			if (Visible)
			{
				RecalcLayout();
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Indicates whether caption is automatically set to the active dock container item text.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public virtual bool AutoSyncBarCaption
	{
		get
		{
			return bool_41;
		}
		set
		{
			bool_41 = value;
			method_131();
		}
	}

	[Description("Specifies whether Bar can be undocked.")]
	[DevCoBrowsable(true)]
	[Category("Docking")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool CanUndock
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(false)]
	[DefaultValue(true)]
	[Category("Docking")]
	[Description("Specifes whether end-user can tear-off (deattach) the tabs on dockable window.")]
	public bool CanTearOffTabs
	{
		get
		{
			return bool_11;
		}
		set
		{
			if (bool_11 != value)
			{
				bool_11 = value;
			}
		}
	}

	[DefaultValue(true)]
	[Category("Docking")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Specifes whether end-user can reorder the tabs on dockable window.")]
	public bool CanReorderTabs
	{
		get
		{
			return bool_12;
		}
		set
		{
			if (bool_12 != value)
			{
				bool_12 = value;
				if (tabStrip_0 != null)
				{
					tabStrip_0.CanReorderTabs = value;
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Indicates whether bar or DockContainerItem that is torn-off this bar can be docked as tab to another bar.")]
	[Category("Docking")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool CanDockTab
	{
		get
		{
			return bool_13;
		}
		set
		{
			bool_13 = value;
		}
	}

	[Category("Docking")]
	[Description("Determines whether bar can be docked to the top edge of container.")]
	[Browsable(true)]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	public bool CanDockTop
	{
		get
		{
			return bool_8;
		}
		set
		{
			if (bool_8 != value)
			{
				bool_8 = value;
			}
		}
	}

	[Description("Determines whether bar can be docked to the bottom edge of container.")]
	[Category("Docking")]
	[Browsable(true)]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	public bool CanDockBottom
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
			}
		}
	}

	[Browsable(true)]
	[Description("Determines whether bar can be docked to the left edge of container.")]
	[Category("Docking")]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	public bool CanDockLeft
	{
		get
		{
			return bool_6;
		}
		set
		{
			if (bool_6 != value)
			{
				bool_6 = value;
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Determines whether bar can be docked to the right edge of container.")]
	[DefaultValue(true)]
	[Category("Docking")]
	[Browsable(true)]
	public bool CanDockRight
	{
		get
		{
			return bool_7;
		}
		set
		{
			if (bool_7 != value)
			{
				bool_7 = value;
			}
		}
	}

	[Description("Specifes whether Bar can be docked as document.")]
	[DevCoBrowsable(true)]
	[Category("Docking")]
	[Browsable(false)]
	[DefaultValue(false)]
	public bool CanDockDocument
	{
		get
		{
			return bool_14;
		}
		set
		{
			bool_14 = value;
		}
	}

	[DefaultValue(false)]
	[Description("Specifies whether Bar will stretch to always fill the space in dock site.")]
	[Category("Layout")]
	[Browsable(false)]
	public bool Stretch
	{
		get
		{
			return bool_4;
		}
		set
		{
			if (bool_4 != value)
			{
				bool_4 = value;
				RecalcLayout();
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Gets or sets whether gray-scale algorithm is used to create automatic gray-scale images.")]
	public bool DisabledImagesGrayScale
	{
		get
		{
			return bool_59;
		}
		set
		{
			bool_59 = value;
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(true)]
	[Category("Docking")]
	[Description("Indicates the distance from the far left/top side of the docking site..")]
	[DefaultValue(0)]
	public int DockOffset
	{
		get
		{
			return int_28;
		}
		set
		{
			int_28 = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Docking")]
	[Browsable(false)]
	[DefaultValue(0)]
	[Description("Indicates the docking line.")]
	public int DockLine
	{
		get
		{
			return int_29;
		}
		set
		{
			int_29 = value;
			if (eBarState_0 == eBarState.Docked && ((Control)this).get_Parent() is DockSite && !bool_55)
			{
				((DockSite)(object)((Control)this).get_Parent()).method_5((Control)(object)this);
			}
		}
	}

	[Browsable(true)]
	[DefaultValue(eTabStripAlignment.Bottom)]
	[DevCoBrowsable(true)]
	[Description("Gets or sets the dock tab alignment.")]
	[Category("Docking")]
	public eTabStripAlignment DockTabAlignment
	{
		get
		{
			return eTabStripAlignment_0;
		}
		set
		{
			eTabStripAlignment_0 = value;
			if (tabStrip_0 != null)
			{
				tabStrip_0.TabAlignment = eTabStripAlignment_0;
				RecalcLayout();
				method_129();
			}
		}
	}

	[Category("Docking")]
	[Browsable(true)]
	[Description("Indicates whether selected dock tab is closed when Bar caption close button is pressed. Default value is false which indicates that whole bar will be hidden when bars close button is pressed.")]
	[DefaultValue(false)]
	public bool CloseSingleTab
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates whether close button is displayed on each dock tab that allows closing of the tab.")]
	[DefaultValue(false)]
	[Category("Docking")]
	public bool DockTabCloseButtonVisible
	{
		get
		{
			return bool_50;
		}
		set
		{
			if (bool_50 != value)
			{
				bool_50 = value;
				if (tabStrip_0 != null)
				{
					tabStrip_0.CloseButtonOnTabsVisible = bool_50;
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether tab that shows all dock containers on the bar is visible all the time.")]
	[Category("Docking")]
	public virtual bool AlwaysDisplayDockTab
	{
		get
		{
			return bool_36;
		}
		set
		{
			if (bool_36 != value)
			{
				bool_36 = value;
				method_120(bool_67: false);
			}
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether bar is locked to prevent docking below it. Applies to undockable bars only.")]
	[Category("Docking")]
	public bool LockDockPosition
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
			}
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(true)]
	[DefaultValue(eOrientation.Horizontal)]
	public eOrientation DockOrientation
	{
		get
		{
			return genericItemContainer_0.Orientation;
		}
		set
		{
			if (genericItemContainer_0.Orientation != value)
			{
				genericItemContainer_0.Orientation = value;
			}
			if (((Component)this).DesignMode && !(((Control)this).get_Parent() is DockSite))
			{
				RecalcLayout();
			}
		}
	}

	[Browsable(false)]
	public bool Docked => eBarState_0 == eBarState.Docked;

	[Browsable(false)]
	public Control DockedSite => ((Control)this).get_Parent();

	[Browsable(false)]
	[DevCoBrowsable(true)]
	[Description("Indicates the dock side for the Bar.")]
	[Category("Docking")]
	public eDockSide DockSide
	{
		get
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Invalid comparison between Unknown and I4
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Invalid comparison between Unknown and I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Invalid comparison between Unknown and I4
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Invalid comparison between Unknown and I4
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Invalid comparison between Unknown and I4
			if (eBarState_0 != eBarState.Docked)
			{
				return eDockSide.None;
			}
			if (((Control)this).get_Parent() == null)
			{
				return eDockSide.Top;
			}
			if ((int)((Control)this).get_Parent().get_Dock() == 3)
			{
				return eDockSide.Left;
			}
			if ((int)((Control)this).get_Parent().get_Dock() == 4)
			{
				return eDockSide.Right;
			}
			if ((int)((Control)this).get_Parent().get_Dock() == 1)
			{
				return eDockSide.Top;
			}
			if ((int)((Control)this).get_Parent().get_Dock() == 2)
			{
				return eDockSide.Bottom;
			}
			if ((int)((Control)this).get_Parent().get_Dock() == 5)
			{
				return eDockSide.Document;
			}
			return eDockSide.None;
		}
		set
		{
			if (Owner != null && !bool_55)
			{
				if (AutoHide)
				{
					method_136(value);
					return;
				}
				DockSiteInfo dockSiteInfo_ = default(DockSiteInfo);
				if (!(object_1 is IOwnerBarSupport ownerBarSupport))
				{
					int_36 = (int)value;
					return;
				}
				dockSiteInfo_.InsertPosition = -10;
				dockSiteInfo_.DockLine = int_29;
				dockSiteInfo_.DockOffset = int_28;
				if (!bool_30)
				{
					Int32_0 = 0;
					Int32_1 = 0;
				}
				switch (value)
				{
				case eDockSide.Left:
				{
					DockSite dockSite4 = null;
					if (LayoutType == eLayoutType.Toolbar)
					{
						dockSite4 = ownerBarSupport.ToolbarLeftDockSite;
						if (dockSite4 == null)
						{
							throw new InvalidOperationException("DotNetBarManager.ToolbarLeftDockSite dock-site is not set.");
						}
					}
					else
					{
						dockSite4 = ownerBarSupport.LeftDockSite;
						if (dockSite4 == null)
						{
							throw new InvalidOperationException("DotNetBarManager.LeftDockSite dock-site is not set.");
						}
					}
					dockSiteInfo_.objDockSite = dockSite4;
					break;
				}
				case eDockSide.Right:
				{
					DockSite dockSite3 = null;
					if (LayoutType == eLayoutType.Toolbar)
					{
						dockSite3 = ownerBarSupport.ToolbarRightDockSite;
						if (dockSite3 == null)
						{
							throw new InvalidOperationException("DotNetBarManager.ToolbarRightDockSite dock-site is not set.");
						}
					}
					else
					{
						dockSite3 = ownerBarSupport.RightDockSite;
						if (dockSite3 == null)
						{
							throw new InvalidOperationException("DotNetBarManager.RightDockSite dock-site is not set.");
						}
					}
					dockSiteInfo_.objDockSite = dockSite3;
					break;
				}
				case eDockSide.Top:
				{
					DockSite dockSite2 = null;
					if (LayoutType == eLayoutType.Toolbar)
					{
						dockSite2 = ownerBarSupport.ToolbarTopDockSite;
						if (dockSite2 == null)
						{
							throw new InvalidOperationException("DotNetBarManager.ToolbarTopDockSite dock-site is not set.");
						}
					}
					else
					{
						dockSite2 = ownerBarSupport.TopDockSite;
						if (dockSite2 == null)
						{
							throw new InvalidOperationException("DotNetBarManager.TopDockSite dock-site is not set.");
						}
					}
					dockSiteInfo_.objDockSite = dockSite2;
					break;
				}
				case eDockSide.Bottom:
				{
					DockSite dockSite = null;
					if (LayoutType == eLayoutType.Toolbar)
					{
						dockSite = ownerBarSupport.ToolbarBottomDockSite;
						if (dockSite == null)
						{
							throw new InvalidOperationException("DotNetBarManager.ToolbarBottomDockSite dock-site is not set.");
						}
					}
					else
					{
						dockSite = ownerBarSupport.BottomDockSite;
						if (dockSite == null)
						{
							throw new InvalidOperationException("DotNetBarManager.BottomDockSite dock-site is not set.");
						}
					}
					if (dockSite == null)
					{
						throw new InvalidOperationException("Bottom dock-site is not set.");
					}
					dockSiteInfo_.objDockSite = dockSite;
					break;
				}
				case eDockSide.Document:
					dockSiteInfo_.objDockSite = ownerBarSupport.FillDockSite;
					break;
				default:
					dockSiteInfo_.objDockSite = null;
					break;
				}
				method_42(dockSiteInfo_, rectangle_3.Location);
			}
			else
			{
				int_36 = (int)value;
			}
		}
	}

	[Browsable(false)]
	[Description("Indicates the inital floating location.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DevCoBrowsable(false)]
	public Point InitalFloatLocation
	{
		get
		{
			return rectangle_3.Location;
		}
		set
		{
			rectangle_3.Location = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates whether Tooltips are shown on Bar and it's sub-items.")]
	[Category("Run-time Behavior")]
	public bool ShowToolTips
	{
		get
		{
			return bool_32;
		}
		set
		{
			bool_32 = value;
		}
	}

	internal bool Boolean_18
	{
		get
		{
			return bool_45;
		}
		set
		{
			if (bool_45 != value)
			{
				bool_45 = value;
				((Control)this).Refresh();
			}
		}
	}

	bool IOwner.DesignMode => ((Component)this).DesignMode;

	[DevCoBrowsable(false)]
	[Category("Run-time Behavior")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether accelerator letters for menu or toolbar commands are underlined regardless of current Windows settings.")]
	public bool AlwaysDisplayKeyAccelerators
	{
		get
		{
			return bool_39;
		}
		set
		{
			if (bool_39 != value)
			{
				bool_39 = value;
				((Control)this).Refresh();
			}
		}
	}

	Form IOwner.ParentForm
	{
		get
		{
			return ((Control)this).FindForm();
		}
		set
		{
		}
	}

	Form IOwner.ActiveMdiChild
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				return null;
			}
			if (val.get_IsMdiContainer())
			{
				return val.get_ActiveMdiChild();
			}
			return null;
		}
	}

	[DevCoBrowsable(false)]
	[Category("Data")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Description("ImageList for images used on Items. Images specified here will always be used on menu-items and are by default used on all Bars.")]
	public ImageList Images
	{
		get
		{
			return imageList_0;
		}
		set
		{
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed -= imageList_2_Disposed;
			}
			imageList_0 = value;
			if (imageList_0 != null)
			{
				((Component)(object)imageList_0).Disposed += imageList_2_Disposed;
			}
		}
	}

	[Category("Data")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Description("ImageList for medium-sized images used on Items.")]
	public ImageList ImagesMedium
	{
		get
		{
			return imageList_1;
		}
		set
		{
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed -= imageList_2_Disposed;
			}
			imageList_1 = value;
			if (imageList_1 != null)
			{
				((Component)(object)imageList_1).Disposed += imageList_2_Disposed;
			}
		}
	}

	[Category("Data")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Description("ImageList for large-sized images used on Items.")]
	public ImageList ImagesLarge
	{
		get
		{
			return imageList_2;
		}
		set
		{
			if (imageList_2 != null)
			{
				((Component)(object)imageList_2).Disposed -= imageList_2_Disposed;
			}
			imageList_2 = value;
			if (imageList_2 != null)
			{
				((Component)(object)imageList_2).Disposed += imageList_2_Disposed;
			}
		}
	}

	BarBaseControlDesigner IBarDesignerServices.Designer
	{
		get
		{
			return barBaseControlDesigner_0;
		}
		set
		{
			barBaseControlDesigner_0 = value;
		}
	}

	bool IOwner.ShowResetButton
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool IOwner.ShowShortcutKeysInToolTips
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	BaseItem IOwner.DragItem => null;

	bool IOwner.DragInProgress => false;

	bool IOwnerMenuSupport.PersonalizedAllVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.ShowFullMenusOnHover
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.AlwaysShowFullMenus
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.ShowPopupShadow => true;

	eMenuDropShadow IOwnerMenuSupport.MenuDropShadow
	{
		get
		{
			return eMenuDropShadow.SystemDefault;
		}
		set
		{
		}
	}

	ePopupAnimation IOwnerMenuSupport.PopupAnimation
	{
		get
		{
			return ePopupAnimation.SystemDefault;
		}
		set
		{
		}
	}

	bool IOwnerMenuSupport.AlphaBlendShadow
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	internal bool Boolean_19
	{
		get
		{
			return bool_62;
		}
		set
		{
			bool_62 = value;
		}
	}

	internal bool Boolean_20
	{
		get
		{
			return bool_63;
		}
		set
		{
			bool_63 = value;
		}
	}

	bool Interface5.Boolean_0
	{
		get
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				return val.get_Modal();
			}
			return false;
		}
	}

	private bool Boolean_21
	{
		get
		{
			Form val = ((Control)this).FindForm();
			Form activeForm = Form.get_ActiveForm();
			if (val == null)
			{
				return false;
			}
			if (val.get_IsMdiChild() && val.get_MdiParent() != null)
			{
				if (val.get_MdiParent().get_ActiveMdiChild() == val && (val == activeForm || val.get_MdiParent() == activeForm))
				{
					return true;
				}
				return false;
			}
			return val == Form.get_ActiveForm();
		}
	}

	bool IDockInfo.CanDockTop => CanDockTop;

	bool IDockInfo.CanDockBottom => CanDockBottom;

	bool IDockInfo.CanDockLeft => CanDockLeft;

	bool IDockInfo.CanDockRight => CanDockRight;

	bool IDockInfo.CanDockDocument => CanDockDocument;

	bool IDockInfo.Stretch
	{
		get
		{
			return Stretch;
		}
		set
		{
			Stretch = value;
		}
	}

	int IDockInfo.DockOffset
	{
		get
		{
			return DockOffset;
		}
		set
		{
			DockOffset = value;
		}
	}

	int IDockInfo.DockLine
	{
		get
		{
			return DockLine;
		}
		set
		{
			DockLine = value;
		}
	}

	eOrientation IDockInfo.DockOrientation
	{
		get
		{
			return DockOrientation;
		}
		set
		{
			DockOrientation = value;
		}
	}

	bool IDockInfo.Docked => Docked;

	Control IDockInfo.DockedSite => DockedSite;

	eDockSide IDockInfo.DockSide
	{
		get
		{
			return DockSide;
		}
		set
		{
			DockSide = value;
		}
	}

	bool IDockInfo.LockDockPosition
	{
		get
		{
			return LockDockPosition;
		}
		set
		{
			LockDockPosition = value;
		}
	}

	[Description("Occurs when Item is clicked.")]
	[Category("Item")]
	public event EventHandler ItemClick
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

	[Description("Occurs after Bar is docked.")]
	public event EventHandler BarDock
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

	[Description("Occurs after Bar is undocked.")]
	public event EventHandler BarUndock
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	[Description("Occurs after Bar definition is loaded.")]
	public event EventHandler DefinitionLoaded
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	[Description("Occurs when current Dock tab has changed.")]
	public event DotNetBarManager.DockTabChangeEventHandler DockTabChange
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dockTabChangeEventHandler_0 = (DotNetBarManager.DockTabChangeEventHandler)Delegate.Combine(dockTabChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dockTabChangeEventHandler_0 = (DotNetBarManager.DockTabChangeEventHandler)Delegate.Remove(dockTabChangeEventHandler_0, value);
		}
	}

	[Description("Occurs when bar visibility has changed as a result of user action.")]
	public event EventHandler UserVisibleChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_4 = (EventHandler)Delegate.Combine(eventHandler_4, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_4 = (EventHandler)Delegate.Remove(eventHandler_4, value);
		}
	}

	[Description("Occurs when bar auto hide state has changed.")]
	public event EventHandler AutoHideChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	[Description("Occurs when Bar is about to be closed as a result of user clicking the Close button on the bar.")]
	public event DotNetBarManager.BarClosingEventHandler Closing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			barClosingEventHandler_0 = (DotNetBarManager.BarClosingEventHandler)Delegate.Combine(barClosingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			barClosingEventHandler_0 = (DotNetBarManager.BarClosingEventHandler)Delegate.Remove(barClosingEventHandler_0, value);
		}
	}

	[Description("Occurs when Bar in auto-hide state is about to be displayed.")]
	public event DotNetBarManager.AutoHideDisplayEventHandler AutoHideDisplay
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			autoHideDisplayEventHandler_0 = (DotNetBarManager.AutoHideDisplayEventHandler)Delegate.Combine(autoHideDisplayEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			autoHideDisplayEventHandler_0 = (DotNetBarManager.AutoHideDisplayEventHandler)Delegate.Remove(autoHideDisplayEventHandler_0, value);
		}
	}

	[Description("Occurs when popup item is closing.")]
	[Category("Item")]
	public event EventHandler PopupClose
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_6 = (EventHandler)Delegate.Combine(eventHandler_6, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_6 = (EventHandler)Delegate.Remove(eventHandler_6, value);
		}
	}

	[Category("Item")]
	[Description("Occurs when popup of type container is loading.")]
	public event EventHandler PopupContainerLoad
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
		}
	}

	[Description("Occurs when popup of type container is unloading.")]
	[Category("Item")]
	public event EventHandler PopupContainerUnload
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	[Category("Item")]
	[Description("Occurs when popup item is about to open.")]
	public event DotNetBarManager.PopupOpenEventHandler PopupOpen
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			popupOpenEventHandler_0 = (DotNetBarManager.PopupOpenEventHandler)Delegate.Combine(popupOpenEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			popupOpenEventHandler_0 = (DotNetBarManager.PopupOpenEventHandler)Delegate.Remove(popupOpenEventHandler_0, value);
		}
	}

	[Description("Occurs just before popup window is shown.")]
	[Category("Item")]
	public event EventHandler PopupShowing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
		}
	}

	[Description("Occurs before dock tab is displayed.")]
	public event EventHandler BeforeDockTabDisplayed
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_10 = (EventHandler)Delegate.Combine(eventHandler_10, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_10 = (EventHandler)Delegate.Remove(eventHandler_10, value);
		}
	}

	[Description("Occurs when caption button is clicked on bars with grab handle style task pane.")]
	public event EventHandler CaptionButtonClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_11 = (EventHandler)Delegate.Combine(eventHandler_11, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_11 = (EventHandler)Delegate.Remove(eventHandler_11, value);
		}
	}

	[Description("Occurs on dockable bars when end-user attempts to close the individual DockContainerItem objects using system buttons on dock tab.")]
	public event DockTabClosingEventHandler DockTabClosing
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			dockTabClosingEventHandler_0 = (DockTabClosingEventHandler)Delegate.Combine(dockTabClosingEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			dockTabClosingEventHandler_0 = (DockTabClosingEventHandler)Delegate.Remove(dockTabClosingEventHandler_0, value);
		}
	}

	public event SerializeItemEventHandler SerializeItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			serializeItemEventHandler_0 = (SerializeItemEventHandler)Delegate.Combine(serializeItemEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			serializeItemEventHandler_0 = (SerializeItemEventHandler)Delegate.Remove(serializeItemEventHandler_0, value);
		}
	}

	public event SerializeItemEventHandler DeserializeItem
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			serializeItemEventHandler_1 = (SerializeItemEventHandler)Delegate.Combine(serializeItemEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			serializeItemEventHandler_1 = (SerializeItemEventHandler)Delegate.Remove(serializeItemEventHandler_1, value);
		}
	}

	public event EventHandler TabStripStyleChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_12 = (EventHandler)Delegate.Combine(eventHandler_12, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_12 = (EventHandler)Delegate.Remove(eventHandler_12, value);
		}
	}

	public event RenderBarEventHandler PreRender
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			renderBarEventHandler_0 = (RenderBarEventHandler)Delegate.Combine(renderBarEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			renderBarEventHandler_0 = (RenderBarEventHandler)Delegate.Remove(renderBarEventHandler_0, value);
		}
	}

	public event RenderBarEventHandler PostRender
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			renderBarEventHandler_1 = (RenderBarEventHandler)Delegate.Combine(renderBarEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			renderBarEventHandler_1 = (RenderBarEventHandler)Delegate.Remove(renderBarEventHandler_1, value);
		}
	}

	public event DotNetBarManager.LocalizeStringEventHandler LocalizeString
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			localizeStringEventHandler_0 = (DotNetBarManager.LocalizeStringEventHandler)Delegate.Combine(localizeStringEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			localizeStringEventHandler_0 = (DotNetBarManager.LocalizeStringEventHandler)Delegate.Remove(localizeStringEventHandler_0, value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler FocusItemChange
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_13 = (EventHandler)Delegate.Combine(eventHandler_13, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_13 = (EventHandler)Delegate.Remove(eventHandler_13, value);
		}
	}

	public Bar()
	{
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		if (!ColorFunctions.bool_0)
		{
			Class92.smethod_5();
			Class92.smethod_6();
			ColorFunctions.LoadColors();
		}
		colorScheme_0 = new ColorScheme();
		baseItem_0 = null;
		object_0 = null;
		rectangle_0 = Rectangle.Empty;
		rectangle_1 = Rectangle.Empty;
		sideBarImage_0 = default(SideBarImage);
		genericItemContainer_0 = new GenericItemContainer();
		genericItemContainer_0.GlobalItem = false;
		genericItemContainer_0.ContainerControl = this;
		genericItemContainer_0.WrapItems = true;
		genericItemContainer_0.Stretch = false;
		genericItemContainer_0.Displayed = true;
		genericItemContainer_0.SystemContainer = true;
		int_27 = 164;
		eBarState_0 = eBarState.Docked;
		int_28 = 0;
		int_29 = 0;
		eGrabHandleStyle_0 = eGrabHandleStyle.None;
		rectangle_2 = Rectangle.Empty;
		object_1 = null;
		point_1 = Point.Empty;
		size_0 = new Size(0, 0);
		bool_0 = false;
		rectangle_3 = Rectangle.Empty;
		int_31 = 0;
		rectangle_4 = Rectangle.Empty;
		bool_1 = false;
		bool_2 = true;
		bool_4 = false;
		bool_3 = false;
		((Control)this).set_Text("");
		form0_0 = null;
		bool_5 = false;
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		TabStop = false;
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
		bool_6 = true;
		bool_7 = true;
		bool_8 = true;
		bool_9 = true;
		bool_10 = true;
		SystemEvents.add_UserPreferenceChanged(new UserPreferenceChangedEventHandler(method_0));
		((Control)this).set_IsAccessible(true);
		class179_0.Event_5 += method_110;
		class179_0.Event_3 += method_110;
		class179_0.Event_4 += method_110;
		class179_0.Event_2 += method_107;
		class179_0.Event_1 += method_108;
		class179_0.Event_0 += method_109;
	}

	public Bar(string BarCaption)
		: this()
	{
		((Control)this).set_Text(BarCaption);
	}

	private void method_0(object sender, UserPreferenceChangedEventArgs e)
	{
		if (!bool_22 && !bool_23)
		{
			bool_22 = true;
			Class92.PostMessage(((Control)this).get_Handle().ToInt32(), 1126, 0, 0);
		}
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		bool_29 = true;
		return (AccessibleObject)(object)new BarAccessibleObject(this);
	}

	private void method_1()
	{
		if (((Control)this).get_Text() != "")
		{
			((Control)this).set_AccessibleName(((Control)this).get_Text());
		}
		else
		{
			((Control)this).set_AccessibleName("DotNetBar Bar");
		}
		((Control)this).set_AccessibleDescription(((Control)this).get_AccessibleName() + " (" + Name + ")");
		if (MenuBar)
		{
			((Control)this).set_AccessibleRole((AccessibleRole)2);
		}
		else if (GrabHandleStyle == eGrabHandleStyle.ResizeHandle)
		{
			((Control)this).set_AccessibleRole((AccessibleRole)23);
		}
		else
		{
			((Control)this).set_AccessibleRole((AccessibleRole)22);
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		bool_51 = true;
		if (bool_31)
		{
			DotNetBarManager.UnRegisterOwnerParentMsgHandler(this, null);
			bool_31 = false;
		}
		if (form0_0 != null && disposing)
		{
			try
			{
				if (((Control)form0_0).get_Controls().Contains((Control)(object)this))
				{
					((Control)form0_0).get_Controls().Remove((Control)(object)this);
				}
				form0_0.method_0();
				((Component)(object)form0_0).Dispose();
				form0_0 = null;
			}
			catch (Exception)
			{
			}
		}
		if (object_1 is DotNetBarManager && ((DotNetBarManager)object_1).bool_28)
		{
			((Control)this).get_Controls().Clear();
		}
		if (((Control)this).get_Parent() != null)
		{
			try
			{
				((Control)this).get_Parent().get_Controls().Remove((Control)(object)this);
			}
			catch (Exception)
			{
			}
		}
		SystemEvents.remove_UserPreferenceChanged(new UserPreferenceChangedEventHandler(method_0));
		if (tabStrip_0 != null)
		{
			((Component)(object)tabStrip_0).Dispose();
			tabStrip_0 = null;
		}
		if (control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		if (bool_60)
		{
			Class107.smethod_1(this);
			bool_60 = false;
		}
		method_34();
		object_1 = null;
		baseItem_0 = null;
		object_0 = null;
		if (genericItemContainer_0 != null)
		{
			genericItemContainer_0.Dispose();
		}
		genericItemContainer_0 = null;
		((Control)this).Dispose(disposing);
		bool_51 = false;
	}

	internal void method_2(bool bool_67)
	{
		bool_21 = bool_67;
		((Control)this).Refresh();
	}

	protected override void OnLeave(EventArgs e)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnLeave(e);
		if (bool_21)
		{
			bool_21 = false;
			if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption && (eBarState_0 == eBarState.Docked || eBarState_0 == eBarState.AutoHide))
			{
				((Control)this).Invalidate();
			}
			if (eBarState_0 == eBarState.AutoHide)
			{
				method_99(dockSiteInfo_1.DockSide).method_3();
			}
		}
	}

	protected override void OnEnter(EventArgs e)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnEnter(e);
		if (bool_21)
		{
			return;
		}
		bool_21 = true;
		if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption && (eBarState_0 == eBarState.Docked || eBarState_0 == eBarState.AutoHide))
		{
			((Control)this).Invalidate();
		}
		if (eBarState_0 == eBarState.AutoHide)
		{
			Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
			if (((Control)this).get_ClientRectangle().Contains(pt))
			{
				method_99(dockSiteInfo_1.DockSide).method_2();
			}
		}
	}

	protected override bool IsInputKey(Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData != 37 && (int)keyData != 39 && (int)keyData != 38 && (int)keyData != 40 && (int)keyData != 13 && (int)keyData != 13 && (int)keyData != 9 && (int)keyData != 27)
		{
			return ((Control)this).IsInputKey(keyData);
		}
		return true;
	}

	protected override void OnBindingContextChanged(EventArgs e)
	{
		((Control)this).OnBindingContextChanged(e);
		if (genericItemContainer_0 != null)
		{
			genericItemContainer_0.method_16();
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33 && (eBarState_0 == eBarState.Popup || (eBarState_0 == eBarState.Floating && genericItemContainer_0.LayoutType == eLayoutType.TaskList)))
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
			return;
		}
		if (((Message)(ref m)).get_Msg() == 1125)
		{
			if (!bool_5 && eBarState_0 == eBarState.Floating)
			{
				Class92.SetWindowPos(((Control)this).get_Handle(), 0, 0, 0, 0, 0, 19);
			}
		}
		else if (((Message)(ref m)).get_Msg() == 1126)
		{
			if (Name == "StatusBar")
			{
				Name = Name;
			}
			_003F val = this;
			object obj = SystemInformation.get_MenuFont().Clone();
			((Control)val).set_Font((Font)((obj is Font) ? obj : null));
			RecalcLayout();
			bool_22 = false;
		}
		else if (((Message)(ref m)).get_Msg() == 1131)
		{
			if (baseItem_1 != null)
			{
				baseItem_1.vmethod_0();
				baseItem_1 = null;
			}
		}
		else if (((Message)(ref m)).get_Msg() == 7)
		{
			int value = ((Message)(ref m)).get_WParam().ToInt32();
			Control val2 = Control.FromChildHandle(new IntPtr(value));
			if (val2 != null && !(val2 is Bar) && !(val2 is MenuPanel) && !(val2 is TextBoxX))
			{
				Form val3 = val2.FindForm();
				if (val3 == ((Control)this).FindForm())
				{
					int_32 = ((Message)(ref m)).get_WParam().ToInt32();
				}
				else if (val3 != null)
				{
					int_32 = ((Message)(ref m)).get_WParam().ToInt32();
				}
			}
		}
		else if (((Message)(ref m)).get_Msg() == 8)
		{
			bool flag = false;
			Control val4 = Control.FromChildHandle(((Message)(ref m)).get_WParam());
			if (val4 != null)
			{
				while (val4.get_Parent() != null)
				{
					val4 = val4.get_Parent();
				}
				if (val4 != this && genericItemContainer_0 != null && !genericItemContainer_0.IsAnyOnHandle(val4.get_Handle().ToInt32()))
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
			if (flag && genericItemContainer_0 != null)
			{
				genericItemContainer_0.ContainerLostFocus(appLostFocus: false);
			}
		}
		else if (((Message)(ref m)).get_Msg() == 794)
		{
			method_74();
			method_72();
			Class58.smethod_1();
		}
		((Control)this).WndProc(ref m);
	}

	protected override void OnSystemColorsChanged(EventArgs e)
	{
		((Control)this).OnSystemColorsChanged(e);
		Application.DoEvents();
		GetColorScheme().Refresh(null, bSystemColorEvent: true);
		((Control)this).Refresh();
	}

	public void ReleaseFocus()
	{
		if (!((Control)this).get_Focused() || int_32 == 0)
		{
			return;
		}
		Control val = Control.FromChildHandle(new IntPtr(int_32));
		if (val != null)
		{
			val.Select();
			if (!val.get_Focused())
			{
				Class92.SetFocus(int_32);
			}
		}
		else
		{
			Class92.SetFocus(int_32);
		}
		int_32 = 0;
		genericItemContainer_0.AutoExpand = false;
	}

	internal void method_3()
	{
		if (!((Control)this).get_Focused())
		{
			genericItemContainer_0.method_29();
			((Control)this).Focus();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (genericItemContainer_0 != null && !((Control)this).get_IsDisposed())
		{
			if (((Control)this).get_BackColor() == Color.Transparent)
			{
				((Control)this).OnPaintBackground(e);
			}
			Graphics graphics = e.get_Graphics();
			graphics.set_PageUnit((GraphicsUnit)2);
			if (Class92.smethod_0())
			{
				graphics.Clear(Color.White);
				graphics.DrawString("Your DotNetBar Trial has expired.", ((Control)this).get_Font(), SystemBrushes.get_ControlText(), 0f, 0f);
			}
			else if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
			{
				PaintOffice(graphics);
			}
			else
			{
				PaintDotNet(e);
			}
		}
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		if (!bool_34 && ((Control)this).get_Width() != 0 && ((Control)this).get_Height() != 0)
		{
			if (!(((Control)this).get_Parent() is DockSite) && !(((Control)this).get_Parent() is Form0) && eBarState_0 == eBarState.Docked && !bool_55)
			{
				RecalcLayout();
			}
			method_129();
		}
	}

	private void method_4(Graphics graphics_0)
	{
		if (((Control)this).get_BackgroundImage() != null)
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			Class109.smethod_63(graphics_0, clientRectangle, ((Control)this).get_BackgroundImage(), eBackgroundImagePosition_0, byte_0);
		}
	}

	public Graphics CreateGraphics()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = ((Control)this).CreateGraphics();
		if (bool_47)
		{
			val.set_SmoothingMode((SmoothingMode)4);
			if (!SystemInformation.get_IsFontSmoothingEnabled())
			{
				val.set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
		}
		return val;
	}

	public virtual BaseRenderer GetRenderer()
	{
		if (eRenderMode_0 == eRenderMode.Global && GlobalManager.Renderer != null)
		{
			return GlobalManager.Renderer;
		}
		if (eRenderMode_0 == eRenderMode.Custom && baseRenderer_1 != null)
		{
			return baseRenderer_1;
		}
		if (baseRenderer_0 == null && Style == eDotNetBarStyle.Office2007)
		{
			baseRenderer_0 = new Office2007Renderer();
		}
		return baseRenderer_1;
	}

	internal ItemPaintArgs method_5(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = new ItemPaintArgs(object_1 as IOwner, (Control)(object)this, graphics_0, GetColorScheme());
		itemPaintArgs.DesignerSelection = bool_45;
		itemPaintArgs.BaseRenderer_0 = GetRenderer();
		if (eBarState_0 == eBarState.Popup && baseItem_0 != null && baseItem_0.DesignMode)
		{
			ISite site = method_142();
			if (site != null && site.DesignMode)
			{
				itemPaintArgs.DesignerSelection = true;
			}
		}
		return itemPaintArgs;
	}

	protected void PaintDotNet(PaintEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Expected O, but got Unknown
		//IL_0cc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e58: Expected O, but got Unknown
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f00: Expected O, but got Unknown
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected O, but got Unknown
		//IL_0f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1096: Expected O, but got Unknown
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_111d: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.get_Graphics();
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		TextRenderingHint textRenderingHint = graphics.get_TextRenderingHint();
		RenderBarEventArgs renderBarEventArgs = null;
		if (bool_47)
		{
			graphics.set_SmoothingMode((SmoothingMode)4);
			graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		class179_0.rectangle_1 = Rectangle.Empty;
		class179_0.rectangle_0 = Rectangle.Empty;
		class179_0.rectangle_2 = Rectangle.Empty;
		class179_0.rectangle_3 = Rectangle.Empty;
		GetColorScheme();
		ItemPaintArgs itemPaintArgs = method_5(graphics);
		itemPaintArgs.ClipRectangle = e.get_ClipRectangle();
		Pen val = ((eBarState_0 != 0) ? new Pen(itemPaintArgs.Colors.BarFloatingBorder) : new Pen(itemPaintArgs.Colors.BarPopupBorder, 1f));
		if (Boolean_9 && !Boolean_10 && baseItem_0 != null && baseItem_0.Style != eDotNetBarStyle.Office2007)
		{
			method_19();
		}
		if (eBarState_0 == eBarState.Popup)
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Background, ((Control)this).get_ClientRectangle());
			OnPreRender(renderBarEventArgs);
			if (!renderBarEventArgs.Cancel)
			{
				if (baseItem_0 != null && Class109.smethod_69(baseItem_0.Style) && GetRenderer() != null)
				{
					ToolbarRendererEventArgs toolbarRendererEventArgs = new ToolbarRendererEventArgs(this, graphics, ((Control)this).get_DisplayRectangle());
					toolbarRendererEventArgs.itemPaintArgs_0 = itemPaintArgs;
					GetRenderer().DrawPopupToolbarBackground(toolbarRendererEventArgs);
				}
				else
				{
					SolidBrush val2 = new SolidBrush(itemPaintArgs.Colors.BarPopupBackground);
					try
					{
						graphics.FillRectangle((Brush)(object)val2, ((Control)this).get_DisplayRectangle());
					}
					finally
					{
						((IDisposable)val2)?.Dispose();
					}
					method_4(itemPaintArgs.Graphics);
					method_18(graphics);
					Rectangle rectangle = ((Control)this).get_ClientRectangle();
					if (Boolean_9 && !Boolean_10)
					{
						rectangle = new Rectangle(0, 0, ((Control)this).get_ClientSize().Width - 2, ((Control)this).get_ClientSize().Height - 2);
					}
					if (baseItem_0 != null && Class109.smethod_69(baseItem_0.Style))
					{
						Class50.smethod_11(graphics, val, rectangle, int_38);
					}
					else
					{
						Class92.smethod_4(graphics, val, rectangle);
					}
					if (Boolean_9 && !Boolean_10)
					{
						val.Dispose();
						val = new Pen(SystemColors.ControlDark, 2f);
						Point[] array = new Point[3];
						array[0].X = 2;
						array[0].Y = ((Control)this).get_ClientSize().Height - 1;
						array[1].X = ((Control)this).get_ClientSize().Width - 1;
						array[1].Y = ((Control)this).get_ClientSize().Height - 1;
						array[2].X = ((Control)this).get_ClientSize().Width - 1;
						array[2].Y = 2;
						graphics.DrawLines(val, array);
					}
					if (baseItem_0 != null && baseItem_0.Style != eDotNetBarStyle.Office2007 && baseItem_0 is ButtonItem && baseItem_0.Displayed && point_0.Y < Location.Y)
					{
						Point point = new Point(point_0.X - Location.X + 1, 0);
						Class50.smethod_31(point_1: new Point(point.X + baseItem_0.WidthInternal - 5, 0), graphics_0: graphics, point_0: point, color_0: itemPaintArgs.Colors.ItemExpandedBackground, int_0: 1);
					}
				}
			}
		}
		else if (eBarState_0 == eBarState.Floating)
		{
			bool flag = true;
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Background, ((Control)this).get_ClientRectangle());
			OnPreRender(renderBarEventArgs);
			if (!renderBarEventArgs.Cancel)
			{
				if (Class109.smethod_69(Style) && GetRenderer() != null)
				{
					ToolbarRendererEventArgs toolbarRendererEventArgs2 = new ToolbarRendererEventArgs(this, graphics, ((Control)this).get_DisplayRectangle());
					toolbarRendererEventArgs2.itemPaintArgs_0 = itemPaintArgs;
					GetRenderer().DrawToolbarBackground(toolbarRendererEventArgs2);
				}
				else
				{
					smoothingMode = graphics.get_SmoothingMode();
					graphics.set_SmoothingMode((SmoothingMode)0);
					if (MenuBar)
					{
						Class50.smethod_26(graphics, ((Control)this).get_ClientRectangle(), itemPaintArgs.Colors.MenuBarBackground, itemPaintArgs.Colors.MenuBarBackground2, itemPaintArgs.Colors.MenuBarBackgroundGradientAngle);
					}
					else
					{
						Class50.smethod_26(graphics, ((Control)this).get_ClientRectangle(), itemPaintArgs.Colors.BarBackground, itemPaintArgs.Colors.BarBackground2, itemPaintArgs.Colors.BarBackgroundGradientAngle);
					}
					method_4(itemPaintArgs.Graphics);
					graphics.set_SmoothingMode(smoothingMode);
				}
			}
			Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Class77 @class = null;
			Class124 class124_ = Class124.class124_10;
			Class149 class149_ = Class149.class149_4;
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Caption, Rectangle.Empty);
			if (Boolean_5)
			{
				renderBarEventArgs.Bounds = new Rectangle(0, 0, ((Control)this).get_Width(), struct11_0.int_1 + 1);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					@class = Class77_0;
					if (LayoutType == eLayoutType.DockContainer && !bool_21)
					{
						class149_ = Class149.class149_5;
					}
					@class.method_0(graphics, class124_, class149_, new Rectangle(0, 0, struct11_0.int_0, ((Control)this).get_Height()));
					class124_ = Class124.class124_11;
					@class.method_0(graphics, class124_, class149_, new Rectangle(((Control)this).get_Width() - struct11_0.int_2, 0, struct11_0.int_0, ((Control)this).get_Height()));
					class124_ = Class124.class124_12;
					@class.method_0(graphics, class124_, class149_, new Rectangle(0, ((Control)this).get_Height() - struct11_0.int_3, ((Control)this).get_Width(), struct11_0.int_3));
					if (LayoutType == eLayoutType.DockContainer && !bool_21)
					{
						class149_ = Class149.class149_2;
					}
					class124_ = Class124.class124_2;
				}
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width(), struct11_0.int_1 + 1);
				@class.method_0(graphics, class124_, class149_, rectangle2);
				rectangle2.Offset(0, 1);
			}
			else if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption && LayoutType == eLayoutType.DockContainer && Style == eDotNetBarStyle.Office2000)
			{
				Rectangle rectangle3 = (renderBarEventArgs.Bounds = new Rectangle(3, 3, ((Control)this).get_Width() - 6, method_39()));
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					ControlPaint.DrawBorder3D(graphics, rectangle2, (Border3DStyle)5, (Border3DSide)2063);
					Enum6 @enum = Enum6.flag_1 | Enum6.flag_3 | Enum6.flag_5;
					if (bool_21)
					{
						@enum |= Enum6.flag_0;
					}
					IntPtr hdc = graphics.GetHdc();
					Class92.RECT lprc = new Class92.RECT(rectangle3.X, rectangle3.Y, rectangle3.Right, rectangle3.Bottom);
					try
					{
						Class92.DrawCaption(((Control)this).get_Handle(), hdc, ref lprc, @enum);
					}
					finally
					{
						graphics.ReleaseHdc(hdc);
					}
				}
				flag = false;
				rectangle2 = rectangle3;
			}
			else
			{
				Rectangle rectangle4 = (renderBarEventArgs.Bounds = new Rectangle(3, 3, ((Control)this).get_Width() - 6, method_39()));
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Pen val3 = new Pen(itemPaintArgs.Colors.BarFloatingBorder, 1f);
					Class92.smethod_4(graphics, val, rectangle2);
					rectangle2.Inflate(-1, -1);
					Class92.smethod_4(graphics, val, rectangle2);
					val3.Dispose();
					val3 = new Pen(itemPaintArgs.Colors.BarFloatingBorder, 1f);
					graphics.DrawLine(val3, 1, 2, 2, 2);
					graphics.DrawLine(val3, ((Control)this).get_Width() - 3, 2, ((Control)this).get_Width() - 2, 2);
					graphics.DrawLine(val3, 1, ((Control)this).get_Height() - 3, 2, ((Control)this).get_Height() - 3);
					graphics.DrawLine(val3, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 3);
					val3.Dispose();
					val3 = null;
					if (GrabHandleStyle != eGrabHandleStyle.CaptionTaskPane)
					{
						smoothingMode = graphics.get_SmoothingMode();
						graphics.set_SmoothingMode((SmoothingMode)0);
						if (color_1.IsEmpty)
						{
							if (LayoutType != 0 && !bool_21)
							{
								Class50.smethod_26(graphics, rectangle4, itemPaintArgs.Colors.BarCaptionInactiveBackground, itemPaintArgs.Colors.BarCaptionInactiveBackground2, itemPaintArgs.Colors.Int32_0);
							}
							else
							{
								Class50.smethod_26(graphics, rectangle4, itemPaintArgs.Colors.BarCaptionBackground, itemPaintArgs.Colors.BarCaptionBackground2, itemPaintArgs.Colors.BarCaptionBackgroundGradientAngle);
							}
						}
						else
						{
							Class50.smethod_24(graphics, new Rectangle(3, 3, ((Control)this).get_Width() - 6, method_39()), color_1, Color.Empty);
						}
						graphics.set_SmoothingMode(smoothingMode);
					}
				}
				rectangle2 = rectangle4;
			}
			rectangle2.Inflate(-1, -1);
			if (GrabHandleStyle != eGrabHandleStyle.CaptionTaskPane)
			{
				if (bool_15)
				{
					class179_0.rectangle_0 = new Rectangle(rectangle2.Right - (class179_0.size_0.Width + 3), rectangle2.Y + (rectangle2.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
					renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.CloseButton, class179_0.rectangle_0);
					OnPreRender(renderBarEventArgs);
					class179_0.rectangle_0 = renderBarEventArgs.Bounds;
					rectangle2.Width -= class179_0.rectangle_0.Width + 3;
					if (!renderBarEventArgs.Cancel)
					{
						method_11(itemPaintArgs);
					}
				}
				if (Boolean_16)
				{
					class179_0.rectangle_1 = new Rectangle(rectangle2.Right - (class179_0.size_0.Width + 1), rectangle2.Y + (rectangle2.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
					renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.CustomizeButton, class179_0.rectangle_1);
					OnPreRender(renderBarEventArgs);
					class179_0.rectangle_1 = renderBarEventArgs.Bounds;
					rectangle2.Width -= class179_0.rectangle_1.Width + 2;
					if (!renderBarEventArgs.Cancel)
					{
						method_15(itemPaintArgs);
					}
				}
				rectangle2.X += 2;
				rectangle2.Width -= 2;
				if (rectangle2.Width > 0 && flag)
				{
					renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.CaptionText, rectangle2);
					OnPreRender(renderBarEventArgs);
					if (!renderBarEventArgs.Cancel)
					{
						Font val4 = null;
						try
						{
							val4 = new Font(((Control)this).get_Font(), (FontStyle)1);
						}
						catch
						{
							val4 = SystemInformation.get_MenuFont();
						}
						eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
						if (color_2.IsEmpty)
						{
							if (Boolean_5)
							{
								if (bool_21)
								{
									class149_ = Class149.class149_1;
								}
								else
								{
									class149_ = Class149.class149_2;
								}
								rectangle2.Y++;
							}
							Class55.smethod_1(graphics, ((Control)this).get_Text(), val4, (bool_21 || LayoutType == eLayoutType.Toolbar) ? itemPaintArgs.Colors.BarCaptionText : itemPaintArgs.Colors.BarCaptionInactiveText, rectangle2, eTextFormat_);
						}
						else
						{
							Class55.smethod_1(graphics, ((Control)this).get_Text(), val4, color_2, rectangle2, eTextFormat_);
						}
					}
				}
			}
			else
			{
				method_6(itemPaintArgs);
			}
		}
		else if (eBarState_0 == eBarState.Docked && Class109.smethod_69(Style) && GetRenderer() != null && (!IsThemed || MenuBar))
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Background, ((Control)this).get_DisplayRectangle());
			OnPreRender(renderBarEventArgs);
			if (!renderBarEventArgs.Cancel && ((Control)this).get_BackColor() != Color.Transparent)
			{
				ToolbarRendererEventArgs toolbarRendererEventArgs3 = new ToolbarRendererEventArgs(this, graphics, ((Control)this).get_DisplayRectangle());
				toolbarRendererEventArgs3.itemPaintArgs_0 = itemPaintArgs;
				GetRenderer().DrawToolbarBackground(toolbarRendererEventArgs3);
			}
			else
			{
				method_6(itemPaintArgs);
			}
		}
		else
		{
			val.Dispose();
			val = null;
			bool flag2 = true;
			if (genericItemContainer_0.m_BackgroundColor.IsEmpty && ((Control)this).get_BackColor() != Color.Transparent)
			{
				if (IsThemed)
				{
					Rectangle rectangle5 = new Rectangle(-Location.X, -Location.Y, ((Control)this).get_Parent().get_Width(), ((Control)this).get_Parent().get_Height());
					Class78 class2 = Class78_0;
					class2.method_0(graphics, Class139.class139_0, Class164.class164_0, rectangle5);
				}
				else
				{
					smoothingMode = graphics.get_SmoothingMode();
					graphics.set_SmoothingMode((SmoothingMode)0);
					renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Background, ((Control)this).get_ClientRectangle());
					OnPreRender(renderBarEventArgs);
					if (!renderBarEventArgs.Cancel)
					{
						if (MenuBar)
						{
							if (!itemPaintArgs.Colors.MenuBarBackground2.IsEmpty && itemPaintArgs.Colors.MenuBarBackground2.A > 0)
							{
								LinearGradientBrush val5 = Class109.smethod_40(((Control)this).get_ClientRectangle(), itemPaintArgs.Colors.MenuBarBackground, itemPaintArgs.Colors.MenuBarBackground2, itemPaintArgs.Colors.MenuBarBackgroundGradientAngle);
								graphics.FillRectangle((Brush)(object)val5, ((Control)this).get_ClientRectangle());
								((Brush)val5).Dispose();
							}
							else if (Boolean_1 && ((Control)this).get_Parent() != null && !itemPaintArgs.Colors.DockSiteBackColor2.IsEmpty && !itemPaintArgs.Colors.DockSiteBackColor.IsEmpty)
							{
								LinearGradientBrush val6 = Class109.smethod_40(new Rectangle(-((Control)this).get_Left(), -((Control)this).get_Top(), ((Control)this).get_Parent().get_Width(), ((Control)this).get_Parent().get_Height()), itemPaintArgs.Colors.DockSiteBackColor, itemPaintArgs.Colors.DockSiteBackColor2, 0f);
								graphics.FillRectangle((Brush)(object)val6, -((Control)this).get_Left(), -((Control)this).get_Top(), ((Control)this).get_Parent().get_Width(), ((Control)this).get_Parent().get_Height());
								((Brush)val6).Dispose();
							}
							else
							{
								SolidBrush val7 = new SolidBrush(itemPaintArgs.Colors.MenuBarBackground);
								try
								{
									graphics.FillRectangle((Brush)(object)val7, ((Control)this).get_DisplayRectangle());
								}
								finally
								{
									((IDisposable)val7)?.Dispose();
								}
							}
						}
						else if (Style == eDotNetBarStyle.VS2005 && LayoutType == eLayoutType.DockContainer && !((Control)this).get_BackColor().IsEmpty)
						{
							Class50.smethod_24(graphics, ((Control)this).get_ClientRectangle(), ((Control)this).get_BackColor(), Color.Empty);
						}
						else if (Boolean_3)
						{
							Class50.smethod_26(graphics, ((Control)this).get_ClientRectangle(), itemPaintArgs.Colors.BarBackground, itemPaintArgs.Colors.BarBackground2, itemPaintArgs.Colors.BarBackgroundGradientAngle);
						}
						else
						{
							SolidBrush val8 = new SolidBrush(itemPaintArgs.Colors.BarBackground);
							try
							{
								graphics.FillRectangle((Brush)(object)val8, ((Control)this).get_ClientRectangle());
							}
							finally
							{
								((IDisposable)val8)?.Dispose();
							}
						}
					}
					else
					{
						flag2 = false;
					}
					graphics.set_SmoothingMode(smoothingMode);
				}
			}
			else if (!genericItemContainer_0.BackColor.IsEmpty)
			{
				smoothingMode = graphics.get_SmoothingMode();
				graphics.set_SmoothingMode((SmoothingMode)0);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Background, ((Control)this).get_DisplayRectangle());
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					SolidBrush val9 = new SolidBrush(genericItemContainer_0.BackColor);
					try
					{
						graphics.FillRectangle((Brush)(object)val9, ((Control)this).get_DisplayRectangle());
					}
					finally
					{
						((IDisposable)val9)?.Dispose();
					}
				}
				else
				{
					flag2 = false;
				}
				graphics.set_SmoothingMode(smoothingMode);
			}
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_BackgroundImage() != null && ((Control)this).get_Parent() is DockSite)
			{
				Rectangle rectangle6 = new Rectangle(-Location.X, -Location.Y, ((Control)this).get_Parent().get_Width(), ((Control)this).get_Parent().get_Height());
				DockSite dockSite = ((Control)this).get_Parent() as DockSite;
				Class109.smethod_63(graphics, rectangle6, ((Control)dockSite).get_BackgroundImage(), dockSite.BackgroundImagePosition, dockSite.BackgroundImageAlpha);
			}
			else
			{
				method_4(itemPaintArgs.Graphics);
			}
			if (flag2)
			{
				if (Boolean_1 && !IsThemed && LayoutType == eLayoutType.Toolbar && !MenuBar && BarType == eBarType.Toolbar && ((Control)this).get_BackColor() != Color.Transparent)
				{
					val = new Pen(itemPaintArgs.Colors.BarDockedBorder, 1f);
					graphics.DrawLine(val, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
					val.Dispose();
				}
				else
				{
					Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
					clientRectangle.Inflate(-2, -2);
					Class109.smethod_28(graphics, eBorderType_0, clientRectangle, color_0);
				}
			}
			method_6(itemPaintArgs);
		}
		genericItemContainer_0.Paint(itemPaintArgs);
		if (eBarType_0 == eBarType.StatusBar && GrabHandleStyle == eGrabHandleStyle.ResizeHandle)
		{
			method_6(itemPaintArgs);
		}
		graphics.set_SmoothingMode(smoothingMode);
		graphics.set_TextRenderingHint(textRenderingHint);
		if (Boolean_2)
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.All, ((Control)this).get_ClientRectangle());
			OnPostRender(renderBarEventArgs);
		}
	}

	protected virtual void OnPreRender(RenderBarEventArgs e)
	{
		if (renderBarEventHandler_0 != null)
		{
			renderBarEventHandler_0(this, e);
		}
	}

	protected virtual void OnPostRender(RenderBarEventArgs e)
	{
		if (renderBarEventHandler_1 != null)
		{
			renderBarEventHandler_1(this, e);
		}
	}

	internal void method_6(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c57: Invalid comparison between Unknown and I4
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Invalid comparison between Unknown and I4
		//IL_0cb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cba: Expected O, but got Unknown
		//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f31: Expected O, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected O, but got Unknown
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Expected O, but got Unknown
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1112: Expected O, but got Unknown
		//IL_1258: Unknown result type (might be due to invalid IL or missing references)
		//IL_125f: Expected O, but got Unknown
		//IL_1292: Unknown result type (might be due to invalid IL or missing references)
		//IL_1299: Expected O, but got Unknown
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ad: Expected O, but got Unknown
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ff: Expected O, but got Unknown
		//IL_1324: Unknown result type (might be due to invalid IL or missing references)
		//IL_132b: Expected O, but got Unknown
		//IL_1334: Unknown result type (might be due to invalid IL or missing references)
		//IL_133b: Expected O, but got Unknown
		RenderBarEventArgs renderBarEventArgs = null;
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (eGrabHandleStyle_0 == eGrabHandleStyle.None)
		{
			return;
		}
		Rectangle empty = Rectangle.Empty;
		if (eGrabHandleStyle_0 != eGrabHandleStyle.Caption && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted && IsThemed && eGrabHandleStyle_0 != eGrabHandleStyle.ResizeHandle)
		{
			Class78 @class = Class78_0;
			Class139 class139_ = Class139.class139_1;
			if (genericItemContainer_0.Orientation == eOrientation.Vertical)
			{
				class139_ = Class139.class139_2;
				empty = new Rectangle(this.rectangle_2.X + 2, this.rectangle_2.Top + 2, this.rectangle_2.Width - 4, 5);
			}
			else
			{
				empty = new Rectangle(this.rectangle_2.X + 2, this.rectangle_2.Top + 2, 5, this.rectangle_2.Height - 4);
			}
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
			OnPreRender(renderBarEventArgs);
			empty = renderBarEventArgs.Bounds;
			if (!renderBarEventArgs.Cancel)
			{
				@class.method_0(graphics, class139_, Class164.class164_0, empty);
			}
			return;
		}
		Color color = itemPaintArgs_0.Colors.BarBackground;
		if (!genericItemContainer_0.m_BackgroundColor.IsEmpty)
		{
			color = genericItemContainer_0.m_BackgroundColor;
		}
		switch (eGrabHandleStyle_0)
		{
		case eGrabHandleStyle.Single:
			if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				empty = new Rectangle(this.rectangle_2.X + 2, this.rectangle_2.Top + 2, 3, this.rectangle_2.Height - 4);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color);
				}
			}
			else
			{
				empty = new Rectangle(this.rectangle_2.X + 2, this.rectangle_2.Top + 2, this.rectangle_2.Width - 4, 3);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color);
				}
			}
			break;
		case eGrabHandleStyle.Dotted:
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (renderBarEventArgs.Cancel)
			{
				break;
			}
			Brush val4 = (Brush)new SolidBrush(ControlPaint.Dark(color));
			Brush val5 = (Brush)new SolidBrush(ControlPaint.Light(color));
			if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				for (int j = 0; j < this.rectangle_2.Height - 4; j += 4)
				{
					graphics.FillRectangle(val4, this.rectangle_2.X + 1, this.rectangle_2.Top + 2 + j, 2, 2);
					graphics.FillRectangle(val5, this.rectangle_2.X + 1, this.rectangle_2.Top + 2 + j, 1, 1);
					graphics.FillRectangle(val4, this.rectangle_2.X + 5, this.rectangle_2.Top + 2 + j, 2, 2);
					graphics.FillRectangle(val5, this.rectangle_2.X + 5, this.rectangle_2.Top + 2 + j, 1, 1);
				}
			}
			else
			{
				for (int k = 0; k < this.rectangle_2.Width - 4; k += 4)
				{
					graphics.FillRectangle(SystemBrushes.get_ControlDark(), this.rectangle_2.Left + 2 + k, this.rectangle_2.Y + 1, 2, 2);
					graphics.FillRectangle(SystemBrushes.get_ControlLight(), this.rectangle_2.Left + 2 + k, this.rectangle_2.Y + 1, 1, 1);
					graphics.FillRectangle(SystemBrushes.get_ControlDark(), this.rectangle_2.Left + 2 + k, this.rectangle_2.Y + 5, 2, 2);
					graphics.FillRectangle(SystemBrushes.get_ControlLight(), this.rectangle_2.Left + 2 + k, this.rectangle_2.Y + 5, 1, 1);
				}
			}
			val4.Dispose();
			val5.Dispose();
			break;
		}
		case eGrabHandleStyle.Double:
			if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				empty = new Rectangle(this.rectangle_2.X + 1, this.rectangle_2.Top + 1, 3, this.rectangle_2.Height - 2);
				Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color);
				empty.Offset(3, 0);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color);
				}
			}
			else
			{
				empty = new Rectangle(this.rectangle_2.X + 1, this.rectangle_2.Top + 1, this.rectangle_2.Width - 2, 3);
				Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color);
				empty.Offset(0, 3);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)2063, color);
				}
			}
			break;
		case eGrabHandleStyle.DoubleThin:
			if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				empty = new Rectangle(this.rectangle_2.X + 1, this.rectangle_2.Top + 2, 3, this.rectangle_2.Height - 4);
				Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)5, color);
				empty.Offset(3, 0);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)5, color);
				}
			}
			else
			{
				empty = new Rectangle(this.rectangle_2.X + 2, this.rectangle_2.Top + 1, this.rectangle_2.Width - 4, 2);
				Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)10, color);
				empty.Offset(0, 3);
				renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, empty);
				OnPreRender(renderBarEventArgs);
				if (!renderBarEventArgs.Cancel)
				{
					Class109.smethod_35(graphics, empty, (Border3DStyle)4, (Border3DSide)10, color);
				}
			}
			break;
		case eGrabHandleStyle.DoubleFlat:
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (!renderBarEventArgs.Cancel)
			{
				Pen val11 = new Pen(ControlPaint.Dark(color), 1f);
				if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
				{
					graphics.DrawLine(val11, this.rectangle_2.X + 2, this.rectangle_2.Top + 2, this.rectangle_2.X + 2, this.rectangle_2.Height - 4);
					graphics.DrawLine(val11, this.rectangle_2.X + 5, this.rectangle_2.Top + 2, this.rectangle_2.X + 5, this.rectangle_2.Height - 4);
				}
				else
				{
					graphics.DrawLine(val11, this.rectangle_2.X + 2, this.rectangle_2.Top + 2, this.rectangle_2.Width - 4, this.rectangle_2.Y + 2);
					graphics.DrawLine(val11, this.rectangle_2.X + 2, this.rectangle_2.Top + 5, this.rectangle_2.Width - 4, this.rectangle_2.Y + 5);
				}
				val11.Dispose();
				val11 = null;
			}
			break;
		case eGrabHandleStyle.Stripe:
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (renderBarEventArgs.Cancel)
			{
				break;
			}
			if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				for (int l = 0; l < this.rectangle_2.Height - 4; l += 3)
				{
					Class109.smethod_38(graphics, this.rectangle_2.X + 2, this.rectangle_2.Top + l + 2, 5, 2, (Border3DStyle)4, (Border3DSide)10, color);
				}
			}
			else
			{
				for (int m = 0; m < this.rectangle_2.Width - 4; m += 3)
				{
					Class109.smethod_38(graphics, this.rectangle_2.Left + m + 2, this.rectangle_2.Y + 2, 2, 5, (Border3DStyle)4, (Border3DSide)5, color);
				}
			}
			break;
		case eGrabHandleStyle.StripeFlat:
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (renderBarEventArgs.Cancel)
			{
				break;
			}
			Pen val14 = new Pen(itemPaintArgs_0.Colors.BarStripeColor, 1f);
			if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
			{
				for (int num7 = 2; num7 < this.rectangle_2.Height - 6; num7 += 2)
				{
					graphics.DrawLine(val14, this.rectangle_2.X + 3, this.rectangle_2.Top + num7 + 3, this.rectangle_2.X + 5, this.rectangle_2.Top + num7 + 3);
				}
			}
			else
			{
				for (int num8 = 1; num8 < this.rectangle_2.Width - 6; num8 += 2)
				{
					graphics.DrawLine(val14, this.rectangle_2.Left + num8 + 3, this.rectangle_2.Y + 2, this.rectangle_2.Left + num8 + 3, this.rectangle_2.Y + 5);
				}
			}
			val14.Dispose();
			break;
		}
		case eGrabHandleStyle.Caption:
		{
			Rectangle rectangle_2 = this.rectangle_2;
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Caption, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (!renderBarEventArgs.Cancel)
			{
				Class77 class2 = null;
				Class124 class124_ = Class124.class124_2;
				Class149 class149_ = Class149.class149_2;
				if (Boolean_5)
				{
					class2 = Class77_0;
				}
				if (eBorderType_0 == eBorderType.None)
				{
					rectangle_2.Inflate(-1, 0);
				}
				if (color_1.IsEmpty)
				{
					if (Style == eDotNetBarStyle.Office2000)
					{
						if (bool_21)
						{
							graphics.FillRectangle(SystemBrushes.get_ActiveCaption(), rectangle_2);
						}
						else
						{
							graphics.FillRectangle(SystemBrushes.get_InactiveCaption(), rectangle_2);
						}
					}
					else if (Boolean_5)
					{
						if (bool_21)
						{
							class149_ = Class149.class149_1;
						}
						class2.method_0(graphics, class124_, class149_, rectangle_2);
					}
					else if (bool_21)
					{
						if (itemPaintArgs_0.Colors.BarCaptionBackground2.IsEmpty)
						{
							Class50.smethod_23(graphics, rectangle_2, itemPaintArgs_0.Colors.BarCaptionBackground);
						}
						else
						{
							LinearGradientBrush val6 = Class109.smethod_40(rectangle_2, itemPaintArgs_0.Colors.BarCaptionBackground, itemPaintArgs_0.Colors.BarCaptionBackground2, itemPaintArgs_0.Colors.BarCaptionBackgroundGradientAngle);
							try
							{
								graphics.FillRectangle((Brush)(object)val6, rectangle_2);
							}
							finally
							{
								((IDisposable)val6)?.Dispose();
							}
						}
					}
					else
					{
						if (itemPaintArgs_0.Colors.BarCaptionInactiveBackground2.IsEmpty)
						{
							Class50.smethod_23(graphics, rectangle_2, itemPaintArgs_0.Colors.BarCaptionInactiveBackground);
						}
						else
						{
							LinearGradientBrush val7 = Class109.smethod_40(rectangle_2, itemPaintArgs_0.Colors.BarCaptionInactiveBackground, itemPaintArgs_0.Colors.BarCaptionInactiveBackground2, itemPaintArgs_0.Colors.Int32_0);
							try
							{
								graphics.FillRectangle((Brush)(object)val7, rectangle_2);
							}
							finally
							{
								((IDisposable)val7)?.Dispose();
							}
						}
						if (Style != eDotNetBarStyle.VS2005)
						{
							Pen val8 = new Pen(itemPaintArgs_0.Colors.BarCaptionBackground, 1f);
							graphics.DrawLine(val8, rectangle_2.X + 1, rectangle_2.Y, rectangle_2.Right - 2, rectangle_2.Y);
							graphics.DrawLine(val8, rectangle_2.X + 1, rectangle_2.Bottom - 1, rectangle_2.Right - 2, rectangle_2.Bottom - 1);
							graphics.DrawLine(val8, rectangle_2.X, rectangle_2.Y + 1, rectangle_2.X, rectangle_2.Bottom - 2);
							graphics.DrawLine(val8, rectangle_2.Right - 1, rectangle_2.Y + 1, rectangle_2.Right - 1, rectangle_2.Bottom - 2);
							val8.Dispose();
						}
					}
				}
				else
				{
					Class50.smethod_23(graphics, rectangle_2, color_1);
				}
			}
			rectangle_2.Inflate(-1, -1);
			method_9(itemPaintArgs_0, ref rectangle_2);
			method_7(itemPaintArgs_0, rectangle_2);
			break;
		}
		case eGrabHandleStyle.ResizeHandle:
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.ResizeHandle, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (renderBarEventArgs.Cancel)
			{
				break;
			}
			Form val9 = ((Control)this).FindForm();
			if (val9 == null || (int)val9.get_WindowState() != 2)
			{
				int num3 = 1;
				Point point = new Point(((Control)this).get_ClientRectangle().Right, ((Control)this).get_ClientRectangle().Bottom);
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					num3 = -1;
					point = new Point(0, ((Control)this).get_ClientRectangle().Bottom - 2);
				}
				Pen val10 = new Pen(ControlPaint.LightLight(color), 1f);
				graphics.DrawLine(val10, point.X - 2 * num3, point.Y - 2, point.X - 3 * num3, point.Y - 2);
				graphics.DrawLine(val10, point.X - 6 * num3, point.Y - 2, point.X - 7 * num3, point.Y - 2);
				graphics.DrawLine(val10, point.X - 10 * num3, point.Y - 2, point.X - 11 * num3, point.Y - 2);
				graphics.DrawLine(val10, point.X - 2 * num3, point.Y - 2, point.X - 2 * num3, point.Y - 3);
				graphics.DrawLine(val10, point.X - 6 * num3, point.Y - 2, point.X - 6 * num3, point.Y - 3);
				graphics.DrawLine(val10, point.X - 10 * num3, point.Y - 2, point.X - 10 * num3, point.Y - 3);
				graphics.DrawLine(val10, point.X - 2 * num3, point.Y - 6, point.X - 3 * num3, point.Y - 6);
				graphics.DrawLine(val10, point.X - 6 * num3, point.Y - 6, point.X - 7 * num3, point.Y - 6);
				graphics.DrawLine(val10, point.X - 2 * num3, point.Y - 6, point.X - 2 * num3, point.Y - 7);
				graphics.DrawLine(val10, point.X - 6 * num3, point.Y - 6, point.X - 6 * num3, point.Y - 7);
				graphics.DrawLine(val10, point.X - 2 * num3, point.Y - 10, point.X - 3 * num3, point.Y - 10);
				graphics.DrawLine(val10, point.X - 2 * num3, point.Y - 10, point.X - 2 * num3, point.Y - 11);
				val10 = new Pen(itemPaintArgs_0.Colors.BarStripeColor, 1f);
				graphics.DrawRectangle(val10, point.X - 4 * num3, point.Y - 4, 1, 1);
				graphics.DrawRectangle(val10, point.X - 8 * num3, point.Y - 4, 1, 1);
				graphics.DrawRectangle(val10, point.X - 12 * num3, point.Y - 4, 1, 1);
				graphics.DrawRectangle(val10, point.X - 4 * num3, point.Y - 8, 1, 1);
				graphics.DrawRectangle(val10, point.X - 8 * num3, point.Y - 8, 1, 1);
				graphics.DrawRectangle(val10, point.X - 4 * num3, point.Y - 12, 1, 1);
				val10.Dispose();
				val10 = null;
			}
			break;
		}
		case eGrabHandleStyle.Office2003:
		case eGrabHandleStyle.Office2003SingleDot:
		{
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.GrabHandle, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (renderBarEventArgs.Cancel)
			{
				break;
			}
			int num4 = this.rectangle_2.Left + (this.rectangle_2.Width - 3) / 2;
			int num5 = this.rectangle_2.Top + 4;
			if (eGrabHandleStyle_0 == eGrabHandleStyle.Office2003SingleDot)
			{
				num4 = this.rectangle_2.Left + (this.rectangle_2.Width - 3) / 2;
				num5 = this.rectangle_2.Top + (this.rectangle_2.Height - 3) / 2;
			}
			else if (genericItemContainer_0.Orientation == eOrientation.Vertical)
			{
				num4 = this.rectangle_2.Left + 4;
				num5 = this.rectangle_2.Top + (this.rectangle_2.Height - 3) / 2;
			}
			Brush val12 = null;
			Brush val13 = (Brush)new SolidBrush(ControlPaint.Light(color));
			if (!itemPaintArgs_0.Colors.BarStripeColor.IsEmpty)
			{
				color = itemPaintArgs_0.Colors.BarStripeColor;
				val12 = (Brush)new SolidBrush(color);
			}
			else
			{
				val12 = (Brush)new SolidBrush(ControlPaint.Dark(color));
			}
			if (eGrabHandleStyle_0 == eGrabHandleStyle.Office2003SingleDot)
			{
				graphics.FillRectangle(val13, num4 + 1, num5 + 1, 2, 2);
				graphics.FillRectangle(val12, num4, num5, 2, 2);
			}
			else if (genericItemContainer_0.Orientation == eOrientation.Vertical)
			{
				for (int n = num4; n <= this.rectangle_2.Right - 4; n += 5)
				{
					graphics.FillRectangle(val13, n + 1, num5 + 1, 2, 2);
					graphics.FillRectangle(val12, n, num5, 2, 2);
				}
			}
			else
			{
				for (int num6 = num5; num6 <= this.rectangle_2.Bottom - 4; num6 += 5)
				{
					graphics.FillRectangle(val13, num4 + 1, num6 + 1, 2, 2);
					graphics.FillRectangle(val12, num4, num6, 2, 2);
				}
			}
			val12.Dispose();
			val13.Dispose();
			break;
		}
		case eGrabHandleStyle.CaptionTaskPane:
		case eGrabHandleStyle.CaptionDotted:
		{
			Rectangle rectangle_ = this.rectangle_2;
			Brush val = null;
			renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.Caption, this.rectangle_2);
			OnPreRender(renderBarEventArgs);
			if (!renderBarEventArgs.Cancel)
			{
				if (eBarState_0 == eBarState.Floating)
				{
					Class50.smethod_26(graphics, rectangle_, itemPaintArgs_0.Colors.BarCaptionBackground, itemPaintArgs_0.Colors.BarCaptionBackground2, itemPaintArgs_0.Colors.BarCaptionBackgroundGradientAngle);
				}
				else
				{
					if (!CaptionBackColor.IsEmpty)
					{
						val = (Brush)new SolidBrush(CaptionBackColor);
					}
					val = (Brush)((!itemPaintArgs_0.Colors.BarBackground2.IsEmpty) ? ((object)Class109.smethod_40(rectangle_, itemPaintArgs_0.Colors.BarBackground, itemPaintArgs_0.Colors.BarBackground2, itemPaintArgs_0.Colors.BarBackgroundGradientAngle)) : ((object)((!bool_21 || eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted) ? new SolidBrush(itemPaintArgs_0.Colors.BarBackground) : new SolidBrush(itemPaintArgs_0.Colors.BarCaptionBackground))));
					graphics.FillRectangle(val, rectangle_);
					val.Dispose();
					val = null;
				}
				Brush val2 = null;
				Brush val3 = (Brush)new SolidBrush(ControlPaint.Light(color));
				if (!itemPaintArgs_0.Colors.BarStripeColor.IsEmpty)
				{
					color = itemPaintArgs_0.Colors.BarStripeColor;
					val2 = (Brush)new SolidBrush(color);
				}
				else
				{
					val2 = (Brush)new SolidBrush(ControlPaint.Dark(color));
				}
				int num = this.rectangle_2.Top + 4;
				int num2 = this.rectangle_2.Left + 4;
				for (int i = num; i <= this.rectangle_2.Bottom - 4; i += 5)
				{
					graphics.FillRectangle(val3, num2 + 1, i + 1, 2, 2);
					graphics.FillRectangle(val2, num2, i, 2, 2);
				}
				if (val3 != null)
				{
					val3.Dispose();
				}
				if (val2 != null)
				{
					val2.Dispose();
				}
			}
			rectangle_.X += 8;
			rectangle_.Width -= 8;
			rectangle_.Inflate(-1, -1);
			method_9(itemPaintArgs_0, ref rectangle_);
			if (eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted)
			{
				method_7(itemPaintArgs_0, rectangle_);
			}
			break;
		}
		}
	}

	private void method_7(ItemPaintArgs itemPaintArgs_0, Rectangle rectangle_6)
	{
		Graphics graphics = itemPaintArgs_0.Graphics;
		RenderBarEventArgs renderBarEventArgs = new RenderBarEventArgs(this, graphics, eBarRenderPart.CaptionText, rectangle_6);
		OnPreRender(renderBarEventArgs);
		if (renderBarEventArgs.Cancel)
		{
			return;
		}
		Font val = null;
		bool flag = false;
		try
		{
			object obj = ((Control)this).get_Font().Clone();
			val = (Font)((obj is Font) ? obj : null);
			flag = true;
		}
		catch
		{
			val = SystemInformation.get_MenuFont();
		}
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		if (color_2.IsEmpty)
		{
			if (IsThemed)
			{
				if (rectangle_6.Height < val.get_Height())
				{
					rectangle_6.Height = val.get_Height();
				}
				if (rectangle_6.Width > 0)
				{
					if (!bool_21)
					{
						Class55.smethod_1(graphics, ((Control)this).get_Text(), val, SystemColors.WindowText, rectangle_6, eTextFormat_);
					}
					else
					{
						Class55.smethod_1(graphics, ((Control)this).get_Text(), val, SystemColors.ActiveCaptionText, rectangle_6, eTextFormat_);
					}
				}
			}
			else
			{
				if (rectangle_6.Height < val.get_Height())
				{
					rectangle_6.Height = val.get_Height();
				}
				if (rectangle_6.Width > 0)
				{
					Color color = itemPaintArgs_0.Colors.BarCaptionText;
					if (eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted)
					{
						color = itemPaintArgs_0.Colors.ItemText;
					}
					else if ((Style == eDotNetBarStyle.OfficeXP || Style == eDotNetBarStyle.Office2003 || Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style)) && !bool_21)
					{
						color = itemPaintArgs_0.Colors.BarCaptionInactiveText;
					}
					Class55.smethod_1(graphics, ((Control)this).get_Text(), val, color, rectangle_6, eTextFormat_);
				}
			}
		}
		else if (rectangle_6.Width > 0)
		{
			Class55.smethod_1(graphics, ((Control)this).get_Text(), val, color_2, rectangle_6, eTextFormat_);
		}
		if (flag)
		{
			val.Dispose();
		}
	}

	private bool method_8()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		bool result = false;
		if (bool_20 && genericItemContainer_0.LayoutType == eLayoutType.DockContainer && eBarState_0 != eBarState.Floating)
		{
			result = ((!(((Control)this).get_Parent() is DockSite) || (int)((Control)this).get_Parent().get_Dock() != 5) ? true : false);
		}
		return result;
	}

	private void method_9(ItemPaintArgs itemPaintArgs_0, ref Rectangle rectangle_6)
	{
		RenderBarEventArgs renderBarEventArgs = null;
		if (bool_15)
		{
			if (Style == eDotNetBarStyle.Office2000)
			{
				class179_0.rectangle_0 = new Rectangle(rectangle_6.Right - 11, rectangle_6.Y + (rectangle_6.Height - class179_0.size_0.Width) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
			}
			else
			{
				class179_0.rectangle_0 = new Rectangle(rectangle_6.Right - (class179_0.size_0.Width + 1), rectangle_6.Y + (rectangle_6.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
			}
			renderBarEventArgs = new RenderBarEventArgs(this, itemPaintArgs_0.Graphics, eBarRenderPart.CloseButton, class179_0.rectangle_0);
			OnPreRender(renderBarEventArgs);
			class179_0.rectangle_0 = renderBarEventArgs.Bounds;
			rectangle_6.Width -= class179_0.rectangle_0.Width + 3;
			if (!renderBarEventArgs.Cancel)
			{
				method_11(itemPaintArgs_0);
			}
		}
		if (method_8())
		{
			if (Style == eDotNetBarStyle.Office2000)
			{
				class179_0.rectangle_2 = new Rectangle(rectangle_6.Right - (class179_0.size_0.Width - 1), rectangle_6.Y + (rectangle_6.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
			}
			else
			{
				class179_0.rectangle_2 = new Rectangle(rectangle_6.Right - (class179_0.size_0.Width + 1), rectangle_6.Y + (rectangle_6.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
			}
			renderBarEventArgs = new RenderBarEventArgs(this, itemPaintArgs_0.Graphics, eBarRenderPart.AutoHideButton, class179_0.rectangle_2);
			OnPreRender(renderBarEventArgs);
			class179_0.rectangle_2 = renderBarEventArgs.Bounds;
			rectangle_6.Width -= class179_0.rectangle_2.Width + 3;
			if (!renderBarEventArgs.Cancel)
			{
				method_17(itemPaintArgs_0);
			}
		}
		if (Boolean_16)
		{
			renderBarEventArgs = new RenderBarEventArgs(this, itemPaintArgs_0.Graphics, eBarRenderPart.CustomizeButton, Rectangle.Empty);
			if (Style == eDotNetBarStyle.Office2000)
			{
				class179_0.rectangle_1 = new Rectangle(rectangle_6.X, rectangle_6.Y + (rectangle_6.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
				renderBarEventArgs.Bounds = class179_0.rectangle_1;
				OnPreRender(renderBarEventArgs);
				class179_0.rectangle_1 = renderBarEventArgs.Bounds;
				rectangle_6.Width -= class179_0.rectangle_1.Width + 2;
				rectangle_6.X += class179_0.rectangle_1.Width + 2;
			}
			else
			{
				class179_0.rectangle_1 = new Rectangle(rectangle_6.Right - (class179_0.size_0.Width + 1), rectangle_6.Y + (rectangle_6.Height - class179_0.size_0.Height) / 2, class179_0.size_0.Width, class179_0.size_0.Height);
				renderBarEventArgs.Bounds = class179_0.rectangle_1;
				OnPreRender(renderBarEventArgs);
				class179_0.rectangle_1 = renderBarEventArgs.Bounds;
				rectangle_6.Width -= class179_0.rectangle_1.Width + 2;
			}
			if (!renderBarEventArgs.Cancel)
			{
				method_15(itemPaintArgs_0);
			}
		}
		if (GrabHandleStyle == eGrabHandleStyle.CaptionTaskPane)
		{
			rectangle_6.X += 2;
			rectangle_6.Width -= 2;
			rectangle_6.Inflate(0, -2);
			class179_0.rectangle_3 = rectangle_6;
			renderBarEventArgs = new RenderBarEventArgs(this, itemPaintArgs_0.Graphics, eBarRenderPart.CaptionTaskPane, class179_0.rectangle_3);
			OnPreRender(renderBarEventArgs);
			class179_0.rectangle_3 = renderBarEventArgs.Bounds;
			if (!renderBarEventArgs.Cancel)
			{
				method_13(itemPaintArgs_0);
			}
		}
		rectangle_6.X += 2;
		rectangle_6.Width -= 2;
	}

	protected void PaintOffice(Graphics g)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		class179_0.rectangle_1 = Rectangle.Empty;
		class179_0.rectangle_0 = Rectangle.Empty;
		if (genericItemContainer_0.BackColor.IsEmpty)
		{
			SolidBrush val = new SolidBrush(SystemColors.Control);
			try
			{
				g.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		else
		{
			SolidBrush val2 = new SolidBrush(genericItemContainer_0.BackColor);
			try
			{
				g.FillRectangle((Brush)(object)val2, ((Control)this).get_DisplayRectangle());
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		GetColorScheme();
		method_18(g);
		ItemPaintArgs itemPaintArgs = method_5(g);
		if (genericItemContainer_0.SubItems.Count <= 0)
		{
			return;
		}
		if (eBarState_0 == eBarState.Popup)
		{
			ControlPaint.DrawBorder3D(g, 0, 0, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height, (Border3DStyle)5);
			method_18(g);
		}
		else if (eBarState_0 == eBarState.Floating)
		{
			ControlPaint.DrawBorder3D(g, 0, 0, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height, (Border3DStyle)5);
			if (color_1.IsEmpty)
			{
				g.FillRectangle(SystemBrushes.get_ActiveCaption(), 4, 4, ((Control)this).get_ClientSize().Width - 8, 15);
			}
			else
			{
				SolidBrush val3 = new SolidBrush(color_1);
				try
				{
					g.FillRectangle((Brush)(object)val3, 4, 4, ((Control)this).get_ClientSize().Width - 8, 15);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			Font val4 = null;
			bool flag = false;
			try
			{
				val4 = new Font(((Control)this).get_Font(), (FontStyle)1);
				flag = true;
			}
			catch
			{
				val4 = SystemInformation.get_MenuFont();
			}
			Rectangle rectangle = Rectangle.Empty;
			if (Boolean_16)
			{
				rectangle = new Rectangle(18, 4, ((Control)this).get_ClientSize().Width - 22, 15);
				class179_0.rectangle_1 = new Rectangle(5, 6, 15, 14);
				method_15(itemPaintArgs);
			}
			else
			{
				rectangle = new Rectangle(4, 4, ((Control)this).get_ClientSize().Width - 8, 15);
			}
			if (bool_15)
			{
				class179_0.rectangle_0 = new Rectangle(rectangle.Right - class179_0.size_0.Width, 6, class179_0.size_0.Width, class179_0.size_0.Height);
				method_11(itemPaintArgs);
				rectangle.Width -= class179_0.size_0.Width + 1;
			}
			if (color_2.IsEmpty)
			{
				Class55.smethod_1(g, ((Control)this).get_Text(), val4, SystemColors.ActiveCaptionText, rectangle, eTextFormat.Default);
			}
			else
			{
				Class55.smethod_1(g, ((Control)this).get_Text(), val4, color_2, rectangle, eTextFormat.Default);
			}
			if (flag)
			{
				val4.Dispose();
			}
		}
		else
		{
			Class109.smethod_28(g, eBorderType_0, ((Control)this).get_ClientRectangle(), color_0);
			method_6(itemPaintArgs);
		}
		genericItemContainer_0.Paint(itemPaintArgs);
	}

	private void method_10()
	{
		((Control)this).Invalidate(class179_0.rectangle_0);
		((Control)this).Update();
	}

	private void method_11(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		if (class179_0.rectangle_0.IsEmpty)
		{
			return;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (Boolean_5)
		{
			Class77 @class = Class77_0;
			Class124 class124_ = Class124.class124_18;
			Class149 class149_ = Class149.class149_6;
			if (class179_0.Boolean_3)
			{
				class149_ = Class149.class149_8;
			}
			else if (class179_0.Boolean_0)
			{
				class149_ = Class149.class149_7;
			}
			@class.method_0(graphics, class124_, class149_, class179_0.rectangle_0);
			return;
		}
		if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
		{
			ButtonState val = (ButtonState)0;
			if (class179_0.Boolean_3)
			{
				val = (ButtonState)512;
			}
			ControlPaint.DrawCaptionButton(graphics, class179_0.rectangle_0, (CaptionButton)0, val);
			return;
		}
		Pen val2 = null;
		if (class179_0.Boolean_3)
		{
			if (itemPaintArgs_0.Colors.ItemPressedBackground2.IsEmpty)
			{
				Class50.smethod_23(graphics, class179_0.rectangle_0, itemPaintArgs_0.Colors.ItemPressedBackground);
			}
			else
			{
				LinearGradientBrush val3 = Class109.smethod_40(class179_0.rectangle_0, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val3, class179_0.rectangle_0);
				((Brush)val3).Dispose();
			}
			Pen val4 = new Pen(itemPaintArgs_0.Colors.ItemPressedBorder);
			try
			{
				Class92.smethod_4(graphics, val4, class179_0.rectangle_0);
			}
			finally
			{
				((IDisposable)val4)?.Dispose();
			}
		}
		else if (class179_0.Boolean_0)
		{
			val2 = new Pen(itemPaintArgs_0.Colors.ItemHotText);
			if (!itemPaintArgs_0.Colors.ItemHotBackground2.IsEmpty)
			{
				LinearGradientBrush val5 = Class109.smethod_40(class179_0.rectangle_0, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val5, class179_0.rectangle_0);
				((Brush)val5).Dispose();
			}
			else
			{
				Class50.smethod_23(graphics, class179_0.rectangle_0, itemPaintArgs_0.Colors.ItemHotBackground);
			}
			Pen val6 = new Pen(itemPaintArgs_0.Colors.ItemHotBorder);
			try
			{
				Class92.smethod_4(graphics, val6, class179_0.rectangle_0);
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		val2 = ((eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) ? new Pen(itemPaintArgs_0.Colors.ItemText) : new Pen((bool_21 || LayoutType == eLayoutType.Toolbar) ? itemPaintArgs_0.Colors.BarCaptionText : itemPaintArgs_0.Colors.BarCaptionInactiveText));
		if (class179_0.Boolean_0)
		{
			val2 = new Pen(itemPaintArgs_0.Colors.ItemHotText, 1f);
		}
		else if (class179_0.Boolean_3)
		{
			val2 = new Pen(itemPaintArgs_0.Colors.ItemPressedText, 1f);
		}
		else if (!color_2.IsEmpty)
		{
			val2 = new Pen(color_2, 1f);
		}
		else if (!bool_21 && eBarState_0 != eBarState.Floating && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted)
		{
			val2 = new Pen(itemPaintArgs_0.Colors.BarCaptionInactiveText);
		}
		Point[] array = new Point[2];
		Rectangle rectangle = class179_0.rectangle_0;
		rectangle.Inflate(-1, -1);
		array[0].X = rectangle.Left + 2;
		array[0].Y = rectangle.Top + 3;
		array[1].X = rectangle.Right - 4;
		array[1].Y = rectangle.Bottom - 4;
		graphics.DrawLine(val2, array[0], array[1]);
		array[0].X++;
		array[1].X++;
		graphics.DrawLine(val2, array[0], array[1]);
		array[0].X = rectangle.Right - 3;
		array[0].Y = rectangle.Top + 3;
		array[1].X = rectangle.Left + 3;
		array[1].Y = rectangle.Bottom - 4;
		graphics.DrawLine(val2, array[0], array[1]);
		array[0].X--;
		array[1].X--;
		graphics.DrawLine(val2, array[0], array[1]);
	}

	private void method_12()
	{
		((Control)this).Invalidate(class179_0.rectangle_3);
		((Control)this).Update();
	}

	private void method_13(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		if (class179_0.rectangle_3.IsEmpty)
		{
			return;
		}
		Rectangle rectangle = class179_0.rectangle_3;
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
		{
			ButtonState val = (ButtonState)0;
			if (class179_0.Boolean_4)
			{
				val = (ButtonState)512;
			}
			ControlPaint.DrawButton(graphics, rectangle, val);
		}
		else if (popupItem_1 != null && popupItem_1.Expanded)
		{
			if (itemPaintArgs_0.Colors.ItemExpandedBackground2.IsEmpty)
			{
				Class50.smethod_23(graphics, rectangle, itemPaintArgs_0.Colors.ItemExpandedBackground);
			}
			else
			{
				LinearGradientBrush val2 = Class109.smethod_40(rectangle, itemPaintArgs_0.Colors.ItemExpandedBackground, itemPaintArgs_0.Colors.ItemExpandedBackground2, itemPaintArgs_0.Colors.ItemExpandedBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val2, rectangle);
				((Brush)val2).Dispose();
			}
			Pen val3 = new Pen(itemPaintArgs_0.Colors.ItemExpandedBorder);
			try
			{
				Class92.smethod_4(graphics, val3, rectangle);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		else if (class179_0.Boolean_4)
		{
			if (itemPaintArgs_0.Colors.ItemPressedBackground2.IsEmpty)
			{
				Class50.smethod_23(graphics, rectangle, itemPaintArgs_0.Colors.ItemPressedBackground);
			}
			else
			{
				LinearGradientBrush val4 = Class109.smethod_40(rectangle, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val4, rectangle);
				((Brush)val4).Dispose();
			}
			Pen val5 = new Pen(itemPaintArgs_0.Colors.ItemPressedBorder);
			try
			{
				Class92.smethod_4(graphics, val5, rectangle);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		else if (class179_0.Boolean_1)
		{
			new Pen(itemPaintArgs_0.Colors.ItemHotText);
			if (!itemPaintArgs_0.Colors.ItemHotBackground2.IsEmpty)
			{
				LinearGradientBrush val6 = Class109.smethod_40(rectangle, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val6, rectangle);
				((Brush)val6).Dispose();
			}
			else
			{
				Class50.smethod_23(graphics, rectangle, itemPaintArgs_0.Colors.ItemHotBackground);
			}
			Pen val7 = new Pen(itemPaintArgs_0.Colors.ItemHotBorder);
			try
			{
				Class92.smethod_4(graphics, val7, rectangle);
			}
			finally
			{
				((IDisposable)val7)?.Dispose();
			}
		}
		SolidBrush val8 = null;
		Color itemText = itemPaintArgs_0.Colors.ItemText;
		itemText = (class179_0.Boolean_1 ? itemPaintArgs_0.Colors.ItemHotText : (class179_0.Boolean_4 ? itemPaintArgs_0.Colors.ItemPressedText : (color_2.IsEmpty ? itemPaintArgs_0.Colors.ItemText : color_2)));
		val8 = new SolidBrush(itemText);
		eTextFormat eTextFormat_ = eTextFormat.EndEllipsis | eTextFormat.SingleLine | eTextFormat.VerticalCenter;
		Rectangle rectangle2 = rectangle;
		rectangle2.Width -= 12;
		rectangle2.X += 3;
		if (rectangle2.Width > 8)
		{
			Class55.smethod_1(graphics, ((Control)this).get_Text(), ((Control)this).get_Font(), itemText, rectangle2, eTextFormat_);
		}
		Point[] array = new Point[3];
		array[0].X = rectangle.Right - 9;
		array[0].Y = rectangle.Top + (rectangle.Height + 6) / 2;
		array[1].X = array[0].X - 4;
		array[1].Y = array[0].Y - 5;
		array[2].X = array[1].X + 9;
		array[2].Y = array[1].Y;
		graphics.FillPolygon((Brush)(object)val8, array);
		((Brush)val8).Dispose();
	}

	private void method_14()
	{
		((Control)this).Invalidate(class179_0.rectangle_1);
		((Control)this).Update();
	}

	private void method_15(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		if (class179_0.rectangle_1.IsEmpty)
		{
			return;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		Brush val = (Brush)new SolidBrush((bool_21 || LayoutType == eLayoutType.Toolbar) ? itemPaintArgs_0.Colors.BarCaptionText : itemPaintArgs_0.Colors.BarCaptionInactiveText);
		if (!Boolean_5)
		{
			if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
			{
				Point[] array = new Point[3];
				array[0].X = class179_0.rectangle_1.X + 4;
				array[0].Y = class179_0.rectangle_1.Y + 8;
				array[1].X = array[0].X - 3;
				array[1].Y = array[0].Y - 4;
				array[2].X = array[1].X + 7;
				array[2].Y = array[1].Y;
				graphics.FillPolygon(SystemBrushes.get_ActiveCaptionText(), array);
				return;
			}
			if (!color_2.IsEmpty)
			{
				val = (Brush)new SolidBrush(color_2);
			}
			if (!bool_21 && eBarState_0 != eBarState.Floating)
			{
				val = (Brush)new SolidBrush(itemPaintArgs_0.Colors.BarCaptionInactiveText);
			}
			if (class179_0.Boolean_5)
			{
				if (itemPaintArgs_0.Colors.ItemPressedBackground2.IsEmpty)
				{
					graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemPressedBackground), class179_0.rectangle_1);
				}
				else
				{
					LinearGradientBrush val2 = Class109.smethod_40(class179_0.rectangle_1, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
					graphics.FillRectangle((Brush)(object)val2, class179_0.rectangle_1);
					((Brush)val2).Dispose();
				}
				Pen val3 = new Pen(itemPaintArgs_0.Colors.ItemPressedBorder);
				try
				{
					Class92.smethod_4(graphics, val3, class179_0.rectangle_1);
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			else if (class179_0.Boolean_2)
			{
				val = (Brush)new SolidBrush(itemPaintArgs_0.Colors.BarCaptionText);
				if (!itemPaintArgs_0.Colors.ItemHotBackground2.IsEmpty)
				{
					LinearGradientBrush val4 = Class109.smethod_40(class179_0.rectangle_1, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
					graphics.FillRectangle((Brush)(object)val4, class179_0.rectangle_1);
					((Brush)val4).Dispose();
				}
				else
				{
					graphics.FillRectangle((Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemHotBackground), class179_0.rectangle_1);
				}
				Pen val5 = new Pen(itemPaintArgs_0.Colors.ItemHotBorder);
				try
				{
					Class92.smethod_4(graphics, val5, class179_0.rectangle_1);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
		}
		val = (Brush)((eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) ? new SolidBrush(itemPaintArgs_0.Colors.ItemText) : new SolidBrush((bool_21 || LayoutType == eLayoutType.Toolbar) ? itemPaintArgs_0.Colors.BarCaptionText : itemPaintArgs_0.Colors.BarCaptionInactiveText));
		if (class179_0.Boolean_2)
		{
			val = (Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemHotText);
		}
		else if (class179_0.Boolean_5)
		{
			val = (Brush)new SolidBrush(itemPaintArgs_0.Colors.ItemPressedText);
		}
		else if (!color_2.IsEmpty)
		{
			val = (Brush)new SolidBrush(color_2);
		}
		else if (!bool_21 && eBarState_0 != eBarState.Floating && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted)
		{
			val = (Brush)new SolidBrush(itemPaintArgs_0.Colors.BarCaptionInactiveText);
		}
		Point[] array2 = new Point[3];
		array2[0].X = class179_0.rectangle_1.Right - 7;
		array2[0].Y = class179_0.rectangle_1.Top + 8;
		array2[1].X = array2[0].X - 3;
		array2[1].Y = array2[0].Y - 4;
		array2[2].X = array2[1].X + 7;
		array2[2].Y = array2[1].Y;
		graphics.FillPolygon(val, array2);
	}

	private void method_16()
	{
		if (!class179_0.rectangle_2.IsEmpty)
		{
			Rectangle rectangle = class179_0.rectangle_2;
			rectangle.Inflate(1, 1);
			((Control)this).Invalidate(rectangle);
			((Control)this).Update();
		}
	}

	private void method_17(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_061e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		if (class179_0.rectangle_2.IsEmpty)
		{
			return;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (Boolean_5)
		{
			Image val = null;
			if ((class179_0.Boolean_7 && !AutoHide) || (AutoHide && !class179_0.Boolean_7))
			{
				val = (Image)(object)((!class179_0.Boolean_6) ? Class109.smethod_67("SystemImages.PinInactive.png") : Class109.smethod_67("SystemImages.Pin.png"));
				graphics.DrawImage(val, class179_0.rectangle_2.X + (class179_0.rectangle_2.Width - val.get_Width()) / 2, class179_0.rectangle_2.Y + (class179_0.rectangle_2.Height - val.get_Height()) / 2, val.get_Width(), val.get_Height());
			}
			else
			{
				val = (Image)(object)((!class179_0.Boolean_6) ? Class109.smethod_67("SystemImages.PinPushedInactive.png") : Class109.smethod_67("SystemImages.PinPushed.png"));
				graphics.DrawImage(val, class179_0.rectangle_2.X + (class179_0.rectangle_2.Width - val.get_Width()) / 2, class179_0.rectangle_2.Y + (class179_0.rectangle_2.Height - val.get_Height()) / 2, val.get_Width(), val.get_Height());
			}
			return;
		}
		if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
		{
			Rectangle rectangle = class179_0.rectangle_2;
			rectangle.Inflate(1, 0);
			if (class179_0.Boolean_7)
			{
				ControlPaint.DrawBorder3D(graphics, rectangle, (Border3DStyle)8, (Border3DSide)2063);
			}
			else
			{
				ControlPaint.DrawBorder3D(graphics, rectangle, (Border3DStyle)5, (Border3DSide)2063);
			}
		}
		else if (class179_0.Boolean_7)
		{
			if (itemPaintArgs_0.Colors.ItemPressedBackground2.IsEmpty)
			{
				Class50.smethod_23(graphics, class179_0.rectangle_2, itemPaintArgs_0.Colors.ItemPressedBackground);
			}
			else
			{
				LinearGradientBrush val2 = Class109.smethod_40(class179_0.rectangle_2, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val2, class179_0.rectangle_2);
				((Brush)val2).Dispose();
			}
			Pen val3 = new Pen(itemPaintArgs_0.Colors.ItemPressedBorder);
			try
			{
				Class92.smethod_4(graphics, val3, class179_0.rectangle_2);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		else if (class179_0.Boolean_6)
		{
			if (!itemPaintArgs_0.Colors.ItemHotBackground2.IsEmpty)
			{
				LinearGradientBrush val4 = Class109.smethod_40(class179_0.rectangle_2, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
				graphics.FillRectangle((Brush)(object)val4, class179_0.rectangle_2);
				((Brush)val4).Dispose();
			}
			else
			{
				Class50.smethod_23(graphics, class179_0.rectangle_2, itemPaintArgs_0.Colors.ItemHotBackground);
			}
			Pen val5 = new Pen(itemPaintArgs_0.Colors.ItemHotBorder);
			try
			{
				Class92.smethod_4(graphics, val5, class179_0.rectangle_2);
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		if ((class179_0.Boolean_7 && !AutoHide) || (AutoHide && !class179_0.Boolean_7))
		{
			Rectangle rectangle2 = new Rectangle(class179_0.rectangle_2.X + (class179_0.rectangle_2.Width - 10) / 2, class179_0.rectangle_2.Y + (class179_0.rectangle_2.Height - 7) / 2, 10, 7);
			Pen val6 = null;
			val6 = ((eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) ? new Pen(itemPaintArgs_0.Colors.ItemText) : new Pen((bool_21 || LayoutType == eLayoutType.Toolbar) ? itemPaintArgs_0.Colors.BarCaptionText : itemPaintArgs_0.Colors.BarCaptionInactiveText));
			if (class179_0.Boolean_6)
			{
				val6 = new Pen(itemPaintArgs_0.Colors.ItemHotText, 1f);
			}
			else if (class179_0.Boolean_7)
			{
				val6 = new Pen(itemPaintArgs_0.Colors.ItemPressedText, 1f);
			}
			else if (!color_2.IsEmpty)
			{
				val6 = new Pen(color_2, 1f);
			}
			else if (!bool_21 && eBarState_0 != eBarState.Floating && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted)
			{
				val6 = new Pen(itemPaintArgs_0.Colors.BarCaptionInactiveText);
			}
			graphics.DrawRectangle(val6, rectangle2.X + 4, rectangle2.Y + 1, 5, 4);
			graphics.DrawLine(val6, rectangle2.X + 4, rectangle2.Y + 4, rectangle2.X + 9, rectangle2.Y + 4);
			graphics.DrawLine(val6, rectangle2.X + 4, rectangle2.Y, rectangle2.X + 4, rectangle2.Y + 6);
			graphics.DrawLine(val6, rectangle2.X, rectangle2.Y + 3, rectangle2.X + 3, rectangle2.Y + 3);
		}
		else
		{
			Rectangle rectangle3 = new Rectangle(class179_0.rectangle_2.X + (class179_0.rectangle_2.Width - 7) / 2, class179_0.rectangle_2.Y + (class179_0.rectangle_2.Height - 9) / 2, 7, 9);
			Pen val7 = null;
			val7 = ((eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) ? new Pen(itemPaintArgs_0.Colors.ItemText) : new Pen((bool_21 || LayoutType == eLayoutType.Toolbar) ? itemPaintArgs_0.Colors.BarCaptionText : itemPaintArgs_0.Colors.BarCaptionInactiveText));
			if (class179_0.Boolean_6)
			{
				val7 = new Pen(itemPaintArgs_0.Colors.ItemHotText, 1f);
			}
			else if (class179_0.Boolean_7)
			{
				val7 = new Pen(itemPaintArgs_0.Colors.ItemPressedText, 1f);
			}
			else if (!color_2.IsEmpty)
			{
				val7 = new Pen(color_2, 1f);
			}
			else if (!bool_21 && eBarState_0 != eBarState.Floating && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted)
			{
				val7 = new Pen(itemPaintArgs_0.Colors.BarCaptionInactiveText);
			}
			graphics.DrawRectangle(val7, rectangle3.X + 1, rectangle3.Y, 4, 5);
			graphics.DrawLine(val7, rectangle3.X + 4, rectangle3.Y, rectangle3.X + 4, rectangle3.Y + 5);
			graphics.DrawLine(val7, rectangle3.X, rectangle3.Y + 5, rectangle3.X + 6, rectangle3.Y + 5);
			graphics.DrawLine(val7, rectangle3.X + 3, rectangle3.Y + 5, rectangle3.X + 3, rectangle3.Y + 8);
		}
	}

	internal void method_18(Graphics graphics_0)
	{
		if (sideBarImage_0.Picture != null && eBarState_0 == eBarState.Popup)
		{
			if (!sideBarImage_0.GradientColor1.IsEmpty && !sideBarImage_0.GradientColor2.IsEmpty)
			{
				LinearGradientBrush val = Class109.smethod_40(rectangle_1, sideBarImage_0.GradientColor1, sideBarImage_0.GradientColor2, sideBarImage_0.GradientAngle);
				graphics_0.FillRectangle((Brush)(object)val, rectangle_1);
			}
			else if (!sideBarImage_0.BackColor.Equals((object?)Color.Empty))
			{
				Class50.smethod_23(graphics_0, rectangle_1, sideBarImage_0.BackColor);
			}
			if (sideBarImage_0.StretchPicture)
			{
				graphics_0.DrawImage(sideBarImage_0.Picture, rectangle_1);
			}
			else if (sideBarImage_0.Alignment == eAlignment.Top)
			{
				graphics_0.DrawImage(sideBarImage_0.Picture, rectangle_1.X, rectangle_1.Top, rectangle_1.Width, sideBarImage_0.Picture.get_Height());
			}
			else if (sideBarImage_0.Alignment == eAlignment.Bottom)
			{
				graphics_0.DrawImage(sideBarImage_0.Picture, rectangle_1.Left, rectangle_1.Bottom - sideBarImage_0.Picture.get_Height(), sideBarImage_0.Picture.get_Width(), sideBarImage_0.Picture.get_Height());
			}
			else
			{
				graphics_0.DrawImage(sideBarImage_0.Picture, rectangle_1.Left, rectangle_1.Top + (rectangle_1.Height - sideBarImage_0.Picture.get_Height()) / 2, sideBarImage_0.Picture.get_Width(), sideBarImage_0.Picture.get_Height());
			}
		}
	}

	private void method_19()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (eBarState_0 == eBarState.Popup)
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			Region val = new Region(rectangle);
			rectangle.X = ((Control)this).get_Width() - 2;
			rectangle.Y = 0;
			rectangle.Width = 2;
			rectangle.Height = 2;
			val.Xor(rectangle);
			rectangle.X = 0;
			rectangle.Y = ((Control)this).get_Height() - 2;
			rectangle.Width = 2;
			rectangle.Height = 2;
			val.Xor(rectangle);
			((Control)this).set_Region(val);
		}
	}

	private void method_20(Control control_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Rectangle clientRectangle = control_0.get_ClientRectangle();
		clientRectangle.Width--;
		clientRectangle.Height--;
		GraphicsPath val = Class50.smethod_13(clientRectangle, int_38);
		Region val2 = new Region();
		val2.MakeEmpty();
		val2.Union(val);
		val.Widen(SystemPens.get_ControlText());
		val2.Union(val);
		control_0.set_Region(val2);
	}

	public void RecalcLayout()
	{
		if (bool_55)
		{
			return;
		}
		if (eBarState_0 == eBarState.Docked)
		{
			if (((Control)this).get_Parent() != null && !bool_25)
			{
				if (genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
				{
					((Control)this).Invalidate(((Control)this).get_Region(), true);
				}
				if (((Control)this).get_Parent() is DockSite)
				{
					((DockSite)(object)((Control)this).get_Parent()).RecalcLayout();
				}
				else
				{
					RecalcSize();
					((Control)this).Refresh();
				}
				method_129();
			}
		}
		else
		{
			RecalcSize();
			method_129();
			((Control)this).Refresh();
		}
	}

	internal void method_21(DockContainerItem dockContainerItem_0, int int_40)
	{
		if (bool_55)
		{
			return;
		}
		if (DockSide != eDockSide.Document && (!(((Control)this).get_Parent() is DockSite) || ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer == null))
		{
			if (eBarState_0 == eBarState.AutoHide)
			{
				genericItemContainer_0.Int32_2 = int_40;
				dockSiteInfo_1.DockedWidth = int_40 + 2;
			}
		}
		else
		{
			((DockSite)(object)DockedSite).GetDocumentUIManager().SetBarWidth(this, int_40 + 2);
		}
	}

	internal void method_22(DockContainerItem dockContainerItem_0, int int_40)
	{
		if (bool_55)
		{
			return;
		}
		if (DockSide != eDockSide.Document && (!(((Control)this).get_Parent() is DockSite) || ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer == null))
		{
			if (eBarState_0 == eBarState.AutoHide)
			{
				genericItemContainer_0.Int32_1 = int_40;
				dockSiteInfo_1.DockedHeight = int_40 + 2;
			}
		}
		else
		{
			((DockSite)(object)DockedSite).GetDocumentUIManager().SetBarHeight(this, int_40 + method_25());
		}
	}

	internal void method_23(DockContainerItem dockContainerItem_0)
	{
		if (AutoHide)
		{
			dockSiteInfo_1.DockedHeight = 0;
			dockSiteInfo_1.DockedWidth = 0;
		}
	}

	private void method_24(Size size_3)
	{
		if (((Control)this).get_Parent() == null || ((ArrangedElementCollection)((Control)this).get_Parent().get_Controls()).get_Count() <= 1)
		{
			return;
		}
		Bar bar = null;
		Bar bar2 = null;
		Bar bar3 = method_51(this);
		Bar bar4 = method_52(this);
		if (bar4 != null && bar4.LayoutType == eLayoutType.DockContainer && bar4.DockLine == DockLine)
		{
			bar = this;
			bar2 = bar4;
		}
		else if (bar3 != null && bar3.LayoutType == eLayoutType.DockContainer && bar3.DockLine == DockLine)
		{
			bar = bar3;
			bar2 = this;
			if (size_3.Width > 0)
			{
				size_3.Width = ((Control)bar).get_Width() + (((Control)bar2).get_Width() - size_3.Width);
			}
			if (size_3.Height > 0)
			{
				size_3.Height = ((Control)bar).get_Height() + (((Control)bar2).get_Height() - size_3.Height);
			}
		}
		if (DockSide != eDockSide.Left && DockSide != eDockSide.Right)
		{
			if (DockSide != eDockSide.Top && DockSide != eDockSide.Bottom)
			{
				return;
			}
			if (bar != null && bar2 != null && bar.DockLine == bar2.DockLine)
			{
				Size size = bar.MinimumDockSize(eOrientation.Horizontal);
				Size size2 = bar2.MinimumDockSize(eOrientation.Horizontal);
				int num = size_3.Width - ((Control)bar).get_Width();
				if (size_3.Width >= size.Width && ((Control)bar2).get_Width() - num >= size2.Width)
				{
					Size size3 = bar.Size;
					Size size4 = bar2.Size;
					Size size5 = bar.method_28(new Size(size_3.Width, ((Control)bar).get_Height()));
					Size size6 = bar2.method_28(new Size(((Control)bar2).get_Width() - num, ((Control)bar2).get_Height()));
					if (!size3.Equals((object?)size5) && !size4.Equals((object?)size6))
					{
						bar2.Int32_1 = 0;
						bar.Int32_1 = size_3.Width;
					}
				}
			}
			else
			{
				Int32_0 = 0;
				Int32_1 = 0;
			}
		}
		else if (bar != null && bar2 != null && bar.DockLine == bar2.DockLine)
		{
			Size size7 = bar.MinimumDockSize(eOrientation.Horizontal);
			Size size8 = bar2.MinimumDockSize(eOrientation.Horizontal);
			int num2 = size_3.Height - ((Control)bar).get_Height();
			if (size_3.Height >= size7.Height && ((Control)bar2).get_Height() - num2 >= size8.Height)
			{
				Size size9 = bar.Size;
				Size size10 = bar2.Size;
				Size size11 = bar.method_28(new Size(((Control)bar).get_Width(), size_3.Height));
				Size size12 = bar2.method_28(new Size(((Control)bar2).get_Width(), ((Control)bar2).get_Height() - num2));
				if (!size9.Equals((object?)size11) && !size10.Equals((object?)size12))
				{
					bar2.Int32_0 = 0;
					bar.Int32_0 = size_3.Height;
				}
			}
		}
		else
		{
			Int32_0 = 0;
			Int32_1 = 0;
		}
	}

	internal int method_25()
	{
		return method_39() + 2;
	}

	public void RecalcSize()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		if (!Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		rectangle_2 = Rectangle.Empty;
		if (bool_52 || genericItemContainer_0 == null)
		{
			return;
		}
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			return;
		}
		bool_52 = true;
		if (LayoutType == eLayoutType.DockContainer && tabStrip_0 == null)
		{
			method_120(bool_67: false);
		}
		try
		{
			if (eBarState_0 == eBarState.Docked)
			{
				genericItemContainer_0.WrapItems = bool_1;
				genericItemContainer_0.Stretch = bool_4;
			}
			else if (eBarState_0 != eBarState.Floating && eBarState_0 != eBarState.AutoHide)
			{
				genericItemContainer_0.WrapItems = true;
				genericItemContainer_0.Stretch = false;
			}
			else
			{
				genericItemContainer_0.WrapItems = bool_2;
				if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
				{
					genericItemContainer_0.Stretch = bool_4;
				}
				else
				{
					genericItemContainer_0.Stretch = false;
				}
			}
			if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
			{
				if (eBarState_0 == eBarState.Docked && !(((Control)this).get_Parent() is DockSite))
				{
					Size size = method_32();
					if (genericItemContainer_0.Orientation == eOrientation.Horizontal)
					{
						((Control)this).set_Height(size.Height);
					}
					else
					{
						((Control)this).set_Width(size.Width);
					}
				}
				else
				{
					((Control)this).set_ClientSize(method_32());
				}
			}
			else if (eBarState_0 == eBarState.Docked && !(((Control)this).get_Parent() is DockSite))
			{
				Size size2 = method_30();
				if (genericItemContainer_0.Orientation == eOrientation.Horizontal)
				{
					((Control)this).set_Height(size2.Height);
				}
				else
				{
					((Control)this).set_Width(size2.Width);
				}
			}
			else
			{
				((Control)this).set_ClientSize(method_30());
			}
			if (control8_0 != null)
			{
				Class92.SetWindowPos(((Control)control8_0).get_Handle(), -2, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
			}
			if (eBarState_0 == eBarState.Docked)
			{
				if (genericItemContainer_0.Orientation == eOrientation.Horizontal)
				{
					size_1 = Size;
				}
				else
				{
					size_2 = Size;
				}
				method_26();
			}
			else if (((Control)this).get_Region() != null)
			{
				((Control)this).set_Region((Region)null);
			}
			if (eBarState_0 == eBarState.Floating && !bool_25)
			{
				form0_0.method_1(((Control)this).get_ClientSize());
				((Form)form0_0).set_ClientSize(((Control)this).get_ClientSize());
			}
		}
		finally
		{
			bool_52 = false;
		}
		if (LayoutType == eLayoutType.DockContainer && tabStrip_0 != null && ((Component)this).DesignMode && ((Component)(object)this).Site != null)
		{
			method_120(bool_67: false);
		}
	}

	private void method_26()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		if (bool_48 && Boolean_1 && !MenuBar && LayoutType == eLayoutType.Toolbar && !IsThemed && GrabHandleStyle != eGrabHandleStyle.ResizeHandle && ((Control)this).get_BackColor() != Color.Transparent)
		{
			GraphicsPath val = new GraphicsPath();
			val.AddLine(0, 2, 2, 0);
			val.AddLine(2, 0, ((Control)this).get_Width() - 2, 0);
			val.AddLine(((Control)this).get_Width(), 2, ((Control)this).get_Width(), ((Control)this).get_Height() - 3);
			val.AddLine(((Control)this).get_Width() - 3, ((Control)this).get_Height(), 3, ((Control)this).get_Height());
			val.AddLine(2, ((Control)this).get_Height(), 0, ((Control)this).get_Height() - 3);
			((Control)this).set_Region(new Region(val));
		}
		else if (((Control)this).get_Region() != null)
		{
			((Control)this).set_Region((Region)null);
		}
	}

	internal void method_27(Size size_3)
	{
		rectangle_2 = Rectangle.Empty;
		if (bool_52 || genericItemContainer_0 == null)
		{
			return;
		}
		bool_52 = true;
		try
		{
			if (eBarState_0 == eBarState.Docked)
			{
				genericItemContainer_0.WrapItems = bool_1;
				genericItemContainer_0.Stretch = bool_4;
			}
			else if (eBarState_0 != eBarState.Floating && eBarState_0 != eBarState.AutoHide)
			{
				genericItemContainer_0.WrapItems = true;
				genericItemContainer_0.Stretch = false;
			}
			else
			{
				genericItemContainer_0.WrapItems = bool_2;
				if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
				{
					genericItemContainer_0.Stretch = bool_4;
				}
				else
				{
					genericItemContainer_0.Stretch = false;
				}
			}
			if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
			{
				((Control)this).set_ClientSize(method_33(bool_67: false, size_3, genericItemContainer_0.Orientation, eBarState_0, genericItemContainer_0.WrapItems));
			}
			else
			{
				((Control)this).set_ClientSize(method_31(bool_67: false, size_3, genericItemContainer_0.Orientation, eBarState_0, genericItemContainer_0.WrapItems));
			}
			if (control8_0 != null)
			{
				Class92.SetWindowPos(((Control)control8_0).get_Handle(), -2, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
			}
			if (eBarState_0 == eBarState.Docked)
			{
				if (genericItemContainer_0.Orientation == eOrientation.Horizontal)
				{
					size_1 = Size;
				}
				else
				{
					size_2 = Size;
				}
				method_26();
			}
			if (eBarState_0 == eBarState.Floating && !bool_25)
			{
				form0_0.method_1(((Control)this).get_ClientSize());
				((Form)form0_0).set_ClientSize(((Control)this).get_ClientSize());
			}
		}
		finally
		{
			bool_52 = false;
		}
	}

	private Size method_28(Size size_3)
	{
		return method_29(size_3, genericItemContainer_0.Orientation, eBarState_0, genericItemContainer_0.WrapItems);
	}

	private Size method_29(Size size_3, eOrientation eOrientation_0, eBarState eBarState_1, bool bool_67)
	{
		if (genericItemContainer_0.SubItems.Count > 0)
		{
			if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
			{
				return method_33(bool_67: true, size_3, eOrientation_0, eBarState_1, bool_67);
			}
			return method_31(bool_67: true, size_3, eOrientation_0, eBarState_1, bool_67);
		}
		return Size.Empty;
	}

	private Size method_30()
	{
		return method_31(bool_67: false, Size, genericItemContainer_0.Orientation, eBarState_0, genericItemContainer_0.WrapItems);
	}

	private Size method_31(bool bool_67, Size size_3, eOrientation eOrientation_0, eBarState eBarState_1, bool bool_68)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Invalid comparison between Unknown and I4
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Invalid comparison between Unknown and I4
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Invalid comparison between Unknown and I4
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Invalid comparison between Unknown and I4
		Size empty = Size.Empty;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int widthInternal = 0;
		int heightInternal = 0;
		eOrientation orientation = genericItemContainer_0.Orientation;
		eBarState eBarState2 = eBarState_0;
		bool stretch = genericItemContainer_0.Stretch;
		bool wrapItems = genericItemContainer_0.WrapItems;
		genericItemContainer_0.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
		if (bool_67)
		{
			genericItemContainer_0.Orientation = eOrientation_0;
			eBarState2 = eBarState_1;
			genericItemContainer_0.WrapItems = bool_68;
			if (eBarState_1 == eBarState.Docked)
			{
				genericItemContainer_0.Stretch = bool_4;
			}
			else if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
			{
				genericItemContainer_0.Stretch = bool_4;
			}
			else
			{
				genericItemContainer_0.Stretch = false;
			}
		}
		switch (eBarState2)
		{
		case eBarState.Docked:
			if (eBorderType_0 != 0)
			{
				num = 3;
				num2 = 3;
				num3 = 3;
				num4 = 3;
			}
			break;
		case eBarState.Floating:
			if (!IsThemed && !Boolean_5)
			{
				num = ((GrabHandleStyle != eGrabHandleStyle.CaptionTaskPane) ? method_25() : (method_38() + 4));
				num3 = 2;
				num4 = 2;
				num2 = 3;
				break;
			}
			if (struct11_0.Boolean_0)
			{
				method_72();
			}
			num = struct11_0.int_1;
			num3 = struct11_0.int_0;
			num4 = struct11_0.int_2;
			num2 = struct11_0.int_3;
			if (GrabHandleStyle == eGrabHandleStyle.CaptionTaskPane)
			{
				num = method_38() + struct11_0.int_3;
			}
			break;
		default:
			num = Int32_4;
			num3 = Int32_3;
			num4 = Int32_5;
			num2 = Int32_6;
			break;
		}
		int num6 = num;
		int num7 = num3;
		if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && !bool_19 && method_127() && (genericItemContainer_0.VisibleSubItems > 1 || (bool_36 && genericItemContainer_0.VisibleSubItems == 1 && eBarState_0 != eBarState.Floating)))
		{
			switch (eTabStripAlignment_0)
			{
			default:
				num2 += 25;
				break;
			case eTabStripAlignment.Left:
				num7 += 25;
				break;
			case eTabStripAlignment.Right:
				num5 = 25;
				break;
			case eTabStripAlignment.Top:
				num6 += 25;
				break;
			}
		}
		if (eBarState2 == eBarState.Popup && sideBarImage_0.Picture != null)
		{
			num7 += sideBarImage_0.Picture.get_Width();
		}
		else if ((eBarState2 == eBarState.Docked || BarState == eBarState.AutoHide) && eGrabHandleStyle_0 != 0)
		{
			if (eGrabHandleStyle_0 == eGrabHandleStyle.ResizeHandle)
			{
				if ((int)((Control)this).get_RightToLeft() == 1)
				{
					num7 += 17;
				}
				else
				{
					num4 += 17;
				}
			}
			else if (genericItemContainer_0.Orientation != 0 || genericItemContainer_0.LayoutType != 0)
			{
				num6 = ((eGrabHandleStyle_0 == eGrabHandleStyle.Caption) ? (num6 + method_39()) : ((eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) ? (num6 + method_38()) : (num6 + 7)));
			}
			else if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption)
			{
				num7 += method_39();
			}
			else if ((int)((Control)this).get_RightToLeft() == 1)
			{
				num4 += 7;
			}
			else
			{
				num7 += 7;
			}
		}
		if (!bool_67)
		{
			genericItemContainer_0.TopInternal = num6;
			genericItemContainer_0.LeftInternal = num7;
		}
		else
		{
			heightInternal = genericItemContainer_0.HeightInternal;
			widthInternal = genericItemContainer_0.WidthInternal;
		}
		genericItemContainer_0.SuspendLayout = true;
		if (!bool_67)
		{
			if (eBarState2 == eBarState.Popup)
			{
				genericItemContainer_0.WidthInternal = int_27;
			}
			else
			{
				genericItemContainer_0.WidthInternal = size_3.Width - num7 - num4 - num5;
				genericItemContainer_0.HeightInternal = size_3.Height - num6 - num2;
			}
		}
		else
		{
			genericItemContainer_0.WidthInternal = size_3.Width - num7 - num4 - num5;
			genericItemContainer_0.HeightInternal = size_3.Height - num6 - num2;
		}
		genericItemContainer_0.SuspendLayout = false;
		if (genericItemContainer_0.VisibleSubItems != 0 && (genericItemContainer_0.SubItems.Count != 1 || !(genericItemContainer_0.SubItems[0] is CustomizeItem) || genericItemContainer_0.SubItems[0].Visible))
		{
			genericItemContainer_0.RecalcSize();
		}
		else
		{
			genericItemContainer_0.RecalcSize();
			if (LayoutType != eLayoutType.DockContainer && DockSide != eDockSide.Document)
			{
				genericItemContainer_0.WidthInternal = 36;
				genericItemContainer_0.HeightInternal = 24;
			}
		}
		num6 += genericItemContainer_0.HeightInternal;
		if (Boolean_1 && LayoutType == eLayoutType.Toolbar && !MenuBar && !IsThemed)
		{
			num6++;
		}
		if (!bool_67)
		{
			if ((int)((Control)this).get_RightToLeft() == 1)
			{
				if (LayoutType == eLayoutType.Toolbar && genericItemContainer_0.WidthInternal < size_3.Width - num7 - num4 - num5 && Stretch)
				{
					genericItemContainer_0.LeftInternal = size_3.Width - num4 - genericItemContainer_0.WidthInternal;
					genericItemContainer_0.RecalcSize();
				}
				rectangle_0 = new Rectangle(genericItemContainer_0.LeftInternal, num, genericItemContainer_0.WidthInternal, num6);
			}
			else
			{
				rectangle_0 = new Rectangle(num7, num, genericItemContainer_0.WidthInternal, num6);
			}
		}
		if (!bool_67)
		{
			if ((eBarState2 == eBarState.Docked || eBarState2 == eBarState.AutoHide) && eGrabHandleStyle_0 != 0 && eGrabHandleStyle_0 != eGrabHandleStyle.ResizeHandle)
			{
				if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType == eLayoutType.Toolbar)
				{
					if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption)
					{
						rectangle_2 = new Rectangle(num3, num, method_39(), num6);
					}
					else if ((int)((Control)this).get_RightToLeft() == 1)
					{
						rectangle_2 = new Rectangle(genericItemContainer_0.WidthInternal + num7 + num3, num, 10, num6);
					}
					else
					{
						rectangle_2 = new Rectangle(num3, num, 10, num6);
					}
				}
				else if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption)
				{
					rectangle_2 = new Rectangle(num3, num, genericItemContainer_0.WidthInternal + num7 - num3 + num5, method_39());
				}
				else if (eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted)
				{
					rectangle_2 = new Rectangle(num3, num, genericItemContainer_0.WidthInternal + num7 - num3 + num5, 10);
				}
				else
				{
					rectangle_2 = new Rectangle(num3, num, genericItemContainer_0.WidthInternal + num7 - num3 + num5, method_38());
				}
			}
			else if (eBarState2 == eBarState.Floating)
			{
				if (eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane)
				{
					rectangle_2 = new Rectangle(num3, (IsThemed || Boolean_5) ? struct11_0.int_3 : 2, genericItemContainer_0.WidthInternal + num7 - num3 + num5, method_38());
				}
				else
				{
					rectangle_2 = new Rectangle(2, 2, genericItemContainer_0.WidthInternal + num5, method_39());
					if (bool_15)
					{
						rectangle_2.Width -= 14;
					}
				}
			}
			if (eBarState2 == eBarState.Popup && sideBarImage_0.Picture != null)
			{
				rectangle_1 = new Rectangle(num7 - sideBarImage_0.Picture.get_Width(), num, sideBarImage_0.Picture.get_Width(), num6 - num);
			}
			empty = new Size(num7 + genericItemContainer_0.WidthInternal + num4 + num5, num6 + num2);
		}
		else
		{
			empty = new Size(num7 + genericItemContainer_0.WidthInternal + num4 + num5, num6 + num2);
			genericItemContainer_0.WidthInternal = widthInternal;
			genericItemContainer_0.HeightInternal = heightInternal;
			genericItemContainer_0.Orientation = orientation;
			genericItemContainer_0.WrapItems = wrapItems;
			genericItemContainer_0.Stretch = stretch;
			genericItemContainer_0.RecalcSize();
		}
		return empty;
	}

	private Size method_32()
	{
		return method_33(bool_67: false, Size, genericItemContainer_0.Orientation, eBarState_0, genericItemContainer_0.WrapItems);
	}

	private Size method_33(bool bool_67, Size size_3, eOrientation eOrientation_0, eBarState eBarState_1, bool bool_68)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Invalid comparison between Unknown and I4
		Size empty = Size.Empty;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int widthInternal = 0;
		int heightInternal = 0;
		eOrientation orientation = genericItemContainer_0.Orientation;
		eBarState eBarState2 = eBarState_0;
		bool stretch = genericItemContainer_0.Stretch;
		bool wrapItems = genericItemContainer_0.WrapItems;
		genericItemContainer_0.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
		if (bool_67)
		{
			genericItemContainer_0.Orientation = eOrientation_0;
			eBarState2 = eBarState_1;
			genericItemContainer_0.WrapItems = bool_68;
			if (eBarState_1 == eBarState.Docked)
			{
				genericItemContainer_0.Stretch = bool_4;
			}
			else if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
			{
				genericItemContainer_0.Stretch = bool_4;
			}
			else
			{
				genericItemContainer_0.Stretch = false;
			}
		}
		switch (eBarState2)
		{
		case eBarState.Docked:
			if (eBorderType_0 != 0)
			{
				num = 2;
				num2 = 2;
				num3 = 2;
				num4 = 2;
			}
			break;
		case eBarState.Floating:
			num = 22;
			num3 = 4;
			num4 = 4;
			num2 = 4;
			break;
		default:
			num = Int32_4;
			num3 = Int32_3;
			num4 = Int32_5;
			num2 = Int32_6;
			break;
		}
		int num6 = num;
		int num7 = num3;
		if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && !bool_19 && method_127() && (genericItemContainer_0.VisibleSubItems > 1 || (bool_36 && genericItemContainer_0.VisibleSubItems == 1 && eBarState_0 != eBarState.Floating)))
		{
			switch (eTabStripAlignment_0)
			{
			default:
				num2 += 25;
				break;
			case eTabStripAlignment.Left:
				num7 += 25;
				break;
			case eTabStripAlignment.Right:
				num5 = 25;
				break;
			case eTabStripAlignment.Top:
				num6 += 25;
				break;
			}
		}
		if (eBarState2 == eBarState.Popup && sideBarImage_0.Picture != null)
		{
			num7 += sideBarImage_0.Picture.get_Width();
		}
		else if ((eBarState2 == eBarState.Docked || BarState == eBarState.AutoHide) && eGrabHandleStyle_0 != 0)
		{
			if (genericItemContainer_0.Orientation != 0 || genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
			{
				num6 = ((eGrabHandleStyle_0 == eGrabHandleStyle.Caption) ? (num6 + method_39()) : ((eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane || eGrabHandleStyle_0 == eGrabHandleStyle.CaptionDotted) ? (num6 + method_38()) : (num6 + 7)));
			}
			else
			{
				num7 += 7;
			}
		}
		if (!bool_67)
		{
			genericItemContainer_0.TopInternal = num6;
			genericItemContainer_0.LeftInternal = num7;
		}
		else
		{
			heightInternal = genericItemContainer_0.HeightInternal;
			widthInternal = genericItemContainer_0.WidthInternal;
		}
		if (!bool_67)
		{
			if (eBarState2 == eBarState.Popup)
			{
				genericItemContainer_0.WidthInternal = int_27;
			}
			else
			{
				genericItemContainer_0.WidthInternal = size_3.Width - num7 - num4 - num5;
				genericItemContainer_0.HeightInternal = size_3.Height - num6 - num2;
			}
		}
		else
		{
			genericItemContainer_0.WidthInternal = size_3.Width - num7 - num4 - num5;
			genericItemContainer_0.HeightInternal = size_3.Height - num6 - num2;
		}
		if (genericItemContainer_0.VisibleSubItems == 0)
		{
			genericItemContainer_0.WidthInternal = 36;
			genericItemContainer_0.HeightInternal = 24;
		}
		else
		{
			genericItemContainer_0.RecalcSize();
		}
		num6 += genericItemContainer_0.HeightInternal;
		if (!bool_67)
		{
			rectangle_0 = new Rectangle(num7, num, genericItemContainer_0.WidthInternal, num6);
		}
		if (!bool_67)
		{
			if ((eBarState2 == eBarState.Docked || BarState == eBarState.AutoHide) && eGrabHandleStyle_0 != 0)
			{
				if (genericItemContainer_0.Orientation == eOrientation.Horizontal && genericItemContainer_0.LayoutType != eLayoutType.DockContainer)
				{
					rectangle_2 = new Rectangle(num3, num, 12, num6);
				}
				else if (eGrabHandleStyle_0 == eGrabHandleStyle.Caption)
				{
					rectangle_2 = new Rectangle(num3, num, genericItemContainer_0.WidthInternal + num7 - num3 + num5, method_39());
				}
				else if (eGrabHandleStyle_0 != eGrabHandleStyle.CaptionTaskPane && eGrabHandleStyle_0 != eGrabHandleStyle.CaptionDotted)
				{
					rectangle_2 = new Rectangle(num3, num, genericItemContainer_0.WidthInternal + num7 - num3 + num5, 12);
				}
				else
				{
					rectangle_2 = new Rectangle(num3, num, genericItemContainer_0.WidthInternal + num7 - num3 + num5, method_38());
				}
			}
			else if (eBarState2 == eBarState.Floating)
			{
				if (eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane)
				{
					rectangle_2 = new Rectangle(4, 4, genericItemContainer_0.WidthInternal + num5, method_38());
				}
				else
				{
					rectangle_2 = new Rectangle(4, 4, genericItemContainer_0.WidthInternal + num5, 15);
				}
				if (bool_15)
				{
					rectangle_2.Width -= 14;
				}
			}
			if (eBarState2 == eBarState.Popup && sideBarImage_0.Picture != null)
			{
				rectangle_1 = new Rectangle(num7 - sideBarImage_0.Picture.get_Width(), num, sideBarImage_0.Picture.get_Width(), num6 - num);
			}
			empty = new Size(num7 + genericItemContainer_0.WidthInternal + num4 + num5, num6 + num2);
		}
		else
		{
			empty = new Size(num7 + genericItemContainer_0.WidthInternal + num4 + num5, num6 + num2);
			genericItemContainer_0.WidthInternal = widthInternal;
			genericItemContainer_0.HeightInternal = heightInternal;
			genericItemContainer_0.Orientation = orientation;
			genericItemContainer_0.WrapItems = wrapItems;
			genericItemContainer_0.Stretch = stretch;
			genericItemContainer_0.RecalcSize();
		}
		return empty;
	}

	private void method_34()
	{
		if (baseItem_0 == null)
		{
			return;
		}
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			subItem.Expanded = false;
			subItem.SetParent(baseItem_0);
			subItem.ContainerControl = object_0;
			subItem.Displayed = false;
			subItem.Orientation = baseItem_0.Orientation;
		}
		genericItemContainer_0.SubItems.method_2();
	}

	internal void method_35()
	{
		if (object_1 != null && object_1 is IOwner && ((IOwner)object_1).Images != null)
		{
			genericItemContainer_0.RefreshImageSize();
		}
	}

	internal void method_36()
	{
		if (int_36 < 0)
		{
			return;
		}
		if (int_36 != 5 || DockSide != eDockSide.Document)
		{
			DockSide = (eDockSide)int_36;
		}
		int_36 = -1;
		foreach (BaseItem subItem in genericItemContainer_0.SubItems)
		{
			subItem.OnProcessDelayedCommands();
		}
	}

	private bool method_37(Control control_0, Control control_1)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (control_0 == control_1)
		{
			return true;
		}
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control val = item;
			if (val != control_1)
			{
				if (method_37(val, control_1))
				{
					return true;
				}
				continue;
			}
			return true;
		}
		return false;
	}

	private int method_38()
	{
		if (((Control)this).get_Font() != null)
		{
			return Math.Max(23, ((Control)this).get_Font().get_Height() + 2);
		}
		return 23;
	}

	private int method_39()
	{
		if (((Control)this).get_Font() != null)
		{
			return Math.Max(20, ((Control)this).get_Font().get_Height() + 2);
		}
		return 20;
	}

	internal void method_40(DockSiteInfo dockSiteInfo_2)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		DocumentDockUIManager documentUIManager = dockSiteInfo_2.objDockSite.GetDocumentUIManager();
		if ((int)((Control)dockSiteInfo_2.objDockSite).get_Dock() == 5)
		{
			documentUIManager.Dock(dockSiteInfo_2.MouseOverBar, this, dockSiteInfo_2.MouseOverDockSide);
		}
		else if ((dockSiteInfo_2.DockLine != -1 && dockSiteInfo_2.DockLine != 999) || ((int)((Control)dockSiteInfo_2.objDockSite).get_Dock() != 3 && (int)((Control)dockSiteInfo_2.objDockSite).get_Dock() != 4))
		{
			if ((dockSiteInfo_2.DockLine != -1 && dockSiteInfo_2.DockLine != 999) || ((int)((Control)dockSiteInfo_2.objDockSite).get_Dock() != 1 && (int)((Control)dockSiteInfo_2.objDockSite).get_Dock() != 2))
			{
				documentUIManager.Dock(dockSiteInfo_2.MouseOverBar, this, dockSiteInfo_2.MouseOverDockSide);
			}
			else
			{
				documentUIManager.Dock(null, this, (dockSiteInfo_2.DockLine == -1) ? eDockSide.Top : eDockSide.None);
			}
		}
		else
		{
			documentUIManager.Dock(null, this, (dockSiteInfo_2.DockLine == -1) ? eDockSide.Left : eDockSide.None);
		}
	}

	internal void method_41()
	{
		if (form0_0 != null)
		{
			rectangle_3 = new Rectangle(((Form)form0_0).get_Location(), Size);
			((Control)form0_0).get_Controls().Remove((Control)(object)this);
			((Control)form0_0).Hide();
			((Component)(object)form0_0).Dispose();
			form0_0 = null;
		}
	}

	internal void method_42(DockSiteInfo dockSiteInfo_2, Point point_3)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected I4, but got Unknown
		IOwner owner = object_1 as IOwner;
		if (bar_0 != null && dockSiteInfo_2.TabDockContainer == bar_0)
		{
			return;
		}
		if (dockSiteInfo_2.objDockSite == null && (eBarState_0 != eBarState.Floating || form0_0 == null))
		{
			bool_5 = true;
			if (bar_0 != null)
			{
				method_45();
				bar_0.RecalcLayout();
				bar_0 = null;
			}
			dockSiteInfo_1 = default(DockSiteInfo);
			dockSiteInfo_1.DockedHeight = ((Control)this).get_Height();
			dockSiteInfo_1.DockedWidth = ((Control)this).get_Width();
			dockSiteInfo_1.DockLine = DockLine;
			dockSiteInfo_1.DockOffset = DockOffset;
			if (((Control)this).get_Parent() != null)
			{
				dockSiteInfo_1.DockSide = ((Control)this).get_Parent().get_Dock();
			}
			else
			{
				dockSiteInfo_1.DockSide = (DockStyle)3;
			}
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is DockSite)
			{
				dockSiteInfo_1.InsertPosition = ((Control)(DockSite)(object)((Control)this).get_Parent()).get_Controls().GetChildIndex((Control)(object)this);
				dockSiteInfo_1.objDockSite = (DockSite)(object)DockedSite;
			}
			if (dockSiteInfo_1.objDockSite == null && object_1 is IOwnerBarSupport ownerBarSupport)
			{
				DockStyle dockSide = dockSiteInfo_1.DockSide;
				switch (dockSide - 1)
				{
				case 0:
					dockSiteInfo_1.objDockSite = ownerBarSupport.TopDockSite;
					break;
				case 1:
					dockSiteInfo_1.objDockSite = ownerBarSupport.BottomDockSite;
					break;
				case 2:
					dockSiteInfo_1.objDockSite = ownerBarSupport.LeftDockSite;
					break;
				case 3:
					dockSiteInfo_1.objDockSite = ownerBarSupport.RightDockSite;
					break;
				}
			}
			eBarState_0 = eBarState.Floating;
			if (form0_0 == null)
			{
				form0_0 = new Form0(this);
				((Control)form0_0).CreateControl();
			}
			if (owner.ParentForm != null && ((ContainerControl)owner.ParentForm).get_ActiveControl() == this)
			{
				((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
				((Control)this).Focus();
			}
			else if (owner.ParentForm != null && method_37((Control)(object)this, ((ContainerControl)owner.ParentForm).get_ActiveControl()))
			{
				((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
				((Control)this).Focus();
			}
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is DockSite)
			{
				if (!((DockSite)(object)((Control)this).get_Parent()).Boolean_2 && ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer == null)
				{
					((DockSite)(object)((Control)this).get_Parent()).method_21((Control)(object)this);
				}
				else
				{
					((DockSite)(object)((Control)this).get_Parent()).GetDocumentUIManager().UnDock(this);
				}
			}
			((Control)this).set_Parent((Control)null);
			((Control)form0_0).get_Controls().Add((Control)(object)this);
			if (!Visible)
			{
				((Control)this).set_Visible(true);
			}
			((Control)this).set_Location(new Point(0, 0));
			rectangle_3 = new Rectangle(rectangle_3.Location, method_44());
			Size = rectangle_3.Size;
			DockOrientation = eOrientation.Horizontal;
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && bool_36)
			{
				method_120(bool_67: true);
			}
			RecalcSize();
			rectangle_3.Size = Size;
			((Form)form0_0).set_Location(point_3);
			if (genericItemContainer_0.LayoutType != 0)
			{
				point_1 = new Point(((Control)this).get_Width() / 2, 8);
			}
			else
			{
				point_1 = new Point(8, 8);
			}
			if (bool_44)
			{
				((Control)form0_0).set_Visible(false);
			}
			else
			{
				((Control)form0_0).Show();
			}
			rectangle_3.Location = ((Form)form0_0).get_Location();
			if (((Control)form0_0).get_Width() != rectangle_3.Width)
			{
				((Control)form0_0).set_Width(rectangle_3.Width);
			}
			if (owner.ParentForm != null)
			{
				owner.ParentForm.Activate();
			}
			bool_5 = false;
			if (eventHandler_2 != null)
			{
				eventHandler_2(this, new EventArgs());
			}
			if (object_1 is IOwnerBarSupport ownerBarSupport2)
			{
				ownerBarSupport2.InvokeBarUndock(this, new EventArgs());
			}
			method_129();
			return;
		}
		if ((dockSiteInfo_2.FullSizeDock || dockSiteInfo_2.PartialSizeDock) && dockSiteInfo_2.DockSiteZOrderIndex >= 0 && dockSiteInfo_2.objDockSite != null && ((Control)dockSiteInfo_2.objDockSite).get_Parent() != null)
		{
			((Control)dockSiteInfo_2.objDockSite).get_Parent().get_Controls().SetChildIndex((Control)(object)dockSiteInfo_2.objDockSite, dockSiteInfo_2.DockSiteZOrderIndex);
		}
		if (object_1 != null)
		{
			if (dockSiteInfo_2.TabDockContainer != null)
			{
				if (bar_0 != null && dockSiteInfo_2.TabDockContainer != bar_0)
				{
					method_45();
					bar_0.RecalcLayout();
					bar_0 = null;
				}
				if (bar_0 != dockSiteInfo_2.TabDockContainer)
				{
					bool_5 = true;
					if (int_30 == -1)
					{
						if (form0_0 != null && ((Control)form0_0).get_Visible())
						{
							if (owner.ParentForm != null)
							{
								owner.ParentForm.Activate();
							}
							rectangle_3 = new Rectangle(((Form)form0_0).get_Location(), Size);
							int_28 = dockSiteInfo_2.DockOffset;
							int_29 = dockSiteInfo_2.DockLine;
							((Control)form0_0).get_Controls().Remove((Control)(object)this);
							((Control)form0_0).Hide();
							((Component)(object)form0_0).Dispose();
							form0_0 = null;
						}
						else if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is DockSite)
						{
							((DockSite)(object)((Control)this).get_Parent()).method_21((Control)(object)this);
						}
						eBarState_0 = eBarState.Docked;
						if (!bool_30)
						{
							((Control)this).set_Visible(false);
						}
						foreach (BaseItem subItem in genericItemContainer_0.SubItems)
						{
							if (subItem is DockContainerItem dockContainerItem)
							{
								DockContainerItem dockContainerItem2 = new DockContainerItem();
								dockContainerItem2.Displayed = false;
								dockContainerItem2.Text = subItem.Text;
								dockContainerItem2.Image = dockContainerItem.Image;
								dockContainerItem2.ImageIndex = dockContainerItem.ImageIndex;
								dockContainerItem2.Icon = dockContainerItem.Icon;
								dockContainerItem2.Tag = "systempdockitem";
								dockSiteInfo_2.TabDockContainer.Items.Add(dockContainerItem2);
							}
							bar_0 = dockSiteInfo_2.TabDockContainer;
							bar_0.RecalcLayout();
							((Control)bar_0).Refresh();
						}
					}
					else
					{
						if (genericItemContainer_0.SubItems[int_30] is DockContainerItem dockContainerItem3)
						{
							DockContainerItem dockContainerItem4 = new DockContainerItem();
							dockContainerItem4.Displayed = false;
							dockContainerItem4.Text = dockContainerItem3.Text;
							dockContainerItem4.Image = dockContainerItem3.Image;
							dockContainerItem4.ImageIndex = dockContainerItem3.ImageIndex;
							dockContainerItem4.Icon = dockContainerItem3.Icon;
							dockContainerItem4.Tag = "systempdockitem";
							dockSiteInfo_2.TabDockContainer.Items.Add(dockContainerItem4);
						}
						bar_0 = dockSiteInfo_2.TabDockContainer;
						bar_0.RecalcLayout();
						((Control)bar_0).Refresh();
					}
					bool_5 = false;
				}
			}
			else
			{
				if (bar_0 != null)
				{
					if (dockSiteInfo_2.objDockSite == ((Control)bar_0).get_Parent())
					{
						return;
					}
					method_45();
					bar_0.RecalcLayout();
					bar_0 = null;
				}
				if (!Visible && !bool_30)
				{
					Visible = true;
				}
				if (dockSiteInfo_2.objDockSite != null && eBarState_0 != eBarState.Docked)
				{
					bool_5 = true;
					if (form0_0 != null && eBarState_0 == eBarState.Floating)
					{
						if (owner.ParentForm != null)
						{
							owner.ParentForm.Activate();
						}
						rectangle_3 = new Rectangle(((Form)form0_0).get_Location(), Size);
						int_28 = dockSiteInfo_2.DockOffset;
						int_29 = dockSiteInfo_2.DockLine;
						((Control)form0_0).get_Controls().Remove((Control)(object)this);
						((Control)form0_0).Hide();
						((Component)(object)form0_0).Dispose();
						form0_0 = null;
					}
					eBarState_0 = eBarState.Docked;
					if (!dockSiteInfo_2.objDockSite.Boolean_2 && dockSiteInfo_2.objDockSite.DocumentDockContainer == null)
					{
						if (dockSiteInfo_2.InsertPosition == -10)
						{
							dockSiteInfo_2.objDockSite.method_1((Control)(object)this);
						}
						else
						{
							dockSiteInfo_2.objDockSite.method_2((Control)(object)this, dockSiteInfo_2.InsertPosition);
						}
					}
					else
					{
						method_40(dockSiteInfo_2);
					}
					bool_5 = false;
				}
				else if (dockSiteInfo_2.objDockSite != null && dockSiteInfo_2.objDockSite != ((Control)this).get_Parent())
				{
					bool_5 = true;
					if (owner.ParentForm != null && ((ContainerControl)owner.ParentForm).get_ActiveControl() == this)
					{
						((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
						((Control)this).Focus();
					}
					else if (owner.ParentForm != null && method_37((Control)(object)this, ((ContainerControl)owner.ParentForm).get_ActiveControl()))
					{
						((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
						((Control)this).Focus();
					}
					if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is DockSite)
					{
						if (!((DockSite)(object)((Control)this).get_Parent()).Boolean_2 && ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer == null)
						{
							((DockSite)(object)((Control)this).get_Parent()).method_21((Control)(object)this);
						}
						else
						{
							((DockSite)(object)((Control)this).get_Parent()).GetDocumentUIManager().UnDock(this);
						}
					}
					if (!Visible && !bool_30)
					{
						Visible = true;
					}
					int_28 = dockSiteInfo_2.DockOffset;
					int_29 = dockSiteInfo_2.DockLine;
					if (!dockSiteInfo_2.objDockSite.Boolean_2 && dockSiteInfo_2.objDockSite.DocumentDockContainer == null)
					{
						if (dockSiteInfo_2.InsertPosition == -10)
						{
							dockSiteInfo_2.objDockSite.method_1((Control)(object)this);
						}
						else
						{
							dockSiteInfo_2.objDockSite.method_2((Control)(object)this, dockSiteInfo_2.InsertPosition);
						}
					}
					else
					{
						dockSiteInfo_2.objDockSite.GetDocumentUIManager().Dock(dockSiteInfo_2.MouseOverBar, this, dockSiteInfo_2.MouseOverDockSide);
					}
					bool_5 = false;
				}
				else if (((Control)this).get_Parent() != null && dockSiteInfo_2.objDockSite == ((Control)this).get_Parent())
				{
					if (!dockSiteInfo_2.objDockSite.Boolean_2 && dockSiteInfo_2.objDockSite.DocumentDockContainer == null)
					{
						if (int_29 != dockSiteInfo_2.DockLine || (int_28 != dockSiteInfo_2.DockOffset && !Stretch) || ((Control)dockSiteInfo_2.objDockSite).get_Controls().GetChildIndex((Control)(object)this) != dockSiteInfo_2.InsertPosition || dockSiteInfo_2.NewLine)
						{
							int_29 = dockSiteInfo_2.DockLine;
							int_28 = dockSiteInfo_2.DockOffset;
							if (!Visible && !bool_30)
							{
								Visible = true;
							}
							if (dockSiteInfo_2.NewLine)
							{
								dockSiteInfo_2.objDockSite.method_4((Control)(object)this, dockSiteInfo_2.InsertPosition, bool_8: true);
							}
							else if (dockSiteInfo_2.InsertPosition == -10)
							{
								dockSiteInfo_2.objDockSite.method_5((Control)(object)this);
								dockSiteInfo_2.objDockSite.RecalcLayout();
							}
							else
							{
								dockSiteInfo_2.objDockSite.method_3((Control)(object)this, dockSiteInfo_2.InsertPosition);
							}
						}
					}
					else
					{
						dockSiteInfo_2.objDockSite.GetDocumentUIManager().Dock(dockSiteInfo_2.MouseOverBar, this, dockSiteInfo_2.MouseOverDockSide);
					}
				}
				else
				{
					Point location = new Point(point_3.X - point_1.X, point_3.Y - point_1.Y);
					Class273 @class = Class109.smethod_53((Control)(object)form0_0);
					if (@class != null && location.Y + 8 >= @class.rectangle_1.Bottom)
					{
						location.Y = @class.rectangle_1.Bottom - 8;
					}
					((Form)form0_0).set_Location(location);
					if (((IOwner)object_1).ParentForm != null)
					{
						((Control)((IOwner)object_1).ParentForm).Update();
					}
				}
			}
		}
		if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && (tabStrip_0 == null || !((Control)tabStrip_0).get_Visible()))
		{
			int visibleSubItems = genericItemContainer_0.VisibleSubItems;
			if ((eBarState_0 != eBarState.Floating || visibleSubItems > 1) && (bool_36 || visibleSubItems > 0))
			{
				eBarState eBarState2 = eBarState_0;
				eBarState_0 = eBarState.Docked;
				method_120(bool_67: false);
				eBarState_0 = eBarState2;
			}
		}
		if (eBarState_0 != eBarState.Floating)
		{
			method_43();
		}
	}

	internal void method_43()
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
		if (object_1 is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.InvokeBarDock(this, new EventArgs());
		}
	}

	private Size method_44()
	{
		Size result = rectangle_3.Size;
		if (result.IsEmpty)
		{
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
			{
				int selectedDockTab = SelectedDockTab;
				if (selectedDockTab >= 0 && genericItemContainer_0.SubItems[selectedDockTab] is DockContainerItem)
				{
					DockContainerItem dockContainerItem = genericItemContainer_0.SubItems[selectedDockTab] as DockContainerItem;
					result = dockContainerItem.DefaultFloatingSize;
				}
				else if (genericItemContainer_0.SubItems.Count <= 0 || !(genericItemContainer_0.SubItems[0] is DockContainerItem))
				{
					result = ((genericItemContainer_0.Orientation != eOrientation.Vertical) ? new Size(genericItemContainer_0.HeightInternal + 24, genericItemContainer_0.HeightInternal + 24) : new Size(genericItemContainer_0.WidthInternal + 16, genericItemContainer_0.WidthInternal + 16));
				}
				else
				{
					DockContainerItem dockContainerItem2 = genericItemContainer_0.SubItems[0] as DockContainerItem;
					result = dockContainerItem2.DefaultFloatingSize;
				}
			}
			else
			{
				result = Screen.FromControl((Control)(object)this).get_WorkingArea().Size;
			}
		}
		return result;
	}

	private void method_45()
	{
		if (bar_0 == null)
		{
			return;
		}
		ArrayList arrayList = new ArrayList(bar_0.Items.Count);
		bar_0.Items.method_4(arrayList);
		foreach (BaseItem item in arrayList)
		{
			if (item.Tag != null && item.Tag.ToString() == "systempdockitem")
			{
				bar_0.Items.Remove(item);
			}
		}
	}

	internal void method_46()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Point point = ((Control)this).PointToClient(Control.get_MousePosition());
		((Control)this).OnMouseMove(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
	}

	internal void method_47()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Point point = ((Control)this).PointToClient(Control.get_MousePosition());
		((Control)this).OnMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
	}

	internal void method_48(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
	}

	internal void method_49()
	{
		method_60(bool_67: true, Point.Empty);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		method_50();
		((Control)this).OnFontChanged(e);
	}

	private void method_50()
	{
		if (genericItemContainer_0 != null)
		{
			BarUtilities.smethod_0(genericItemContainer_0.SubItems);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Invalid comparison between Unknown and I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Invalid comparison between Unknown and I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Invalid comparison between Unknown and I4
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Invalid comparison between Unknown and I4
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Invalid comparison between Unknown and I4
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Invalid comparison between Unknown and I4
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Invalid comparison between Unknown and I4
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Invalid comparison between Unknown and I4
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Invalid comparison between Unknown and I4
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Invalid comparison between Unknown and I4
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Invalid comparison between Unknown and I4
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c9: Invalid comparison between Unknown and I4
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Invalid comparison between Unknown and I4
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccd: Expected O, but got Unknown
		//IL_1edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee2: Expected O, but got Unknown
		//IL_1f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f85: Invalid comparison between Unknown and I4
		if (bool_53)
		{
			return;
		}
		bool_53 = true;
		if (bool_0 && eBarState_0 != 0 && (int)e.get_Button() == 1048576)
		{
			if (((Control)this).get_Cursor() != Cursors.get_SizeAll())
			{
				((Control)this).set_Cursor(Cursors.get_SizeAll());
			}
			Point mousePosition = Control.get_MousePosition();
			Point point = ((Control)this).PointToClient(mousePosition);
			if (!(object_1 is IOwnerBarSupport ownerBarSupport) || (Math.Abs(point.X - point_1.X) <= 4 && Math.Abs(point.Y - point_1.Y) <= 4))
			{
				((Control)this).OnMouseMove(e);
				bool_53 = false;
				return;
			}
			DockSiteInfo dockInfo = ownerBarSupport.GetDockInfo(this, mousePosition.X, mousePosition.Y);
			if (dockInfo.objDockSite == null && !bool_10)
			{
				((Control)this).OnMouseMove(e);
				bool_53 = false;
				return;
			}
			bool flag = true;
			if (!rectangle_5.IsEmpty)
			{
				Class92.smethod_1(rectangle_5, 3);
				rectangle_5 = Rectangle.Empty;
			}
			if (dockInfo.UseOutline && dockInfo.objDockSite != null)
			{
				Rectangle rectangle = dockInfo.objDockSite.method_17(this, ref dockInfo);
				if (!rectangle.IsEmpty)
				{
					flag = false;
					if (form_0 == null)
					{
						form_0 = Class109.smethod_15();
					}
					Class92.SetWindowPos(((Control)form_0).get_Handle(), 0, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, 80);
				}
			}
			if (flag && form_0 != null)
			{
				((Control)form_0).set_Visible(false);
			}
			dockSiteInfo_0 = dockInfo;
			if (flag)
			{
				method_42(dockInfo, mousePosition);
			}
		}
		else if ((int)e.get_Button() == 0)
		{
			if (eBarState_0 == eBarState.Floating)
			{
				if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && ((e.get_X() <= 2 && e.get_Y() <= 2) || (e.get_X() >= ((Control)this).get_Width() - 4 && e.get_Y() >= ((Control)this).get_Height() - 4)))
				{
					((Control)this).set_Cursor(Cursors.get_SizeNWSE());
				}
				else if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && ((e.get_X() >= ((Control)this).get_Width() - 2 && e.get_Y() <= 2) || (e.get_X() <= 4 && e.get_Y() >= ((Control)this).get_Height() - 4)))
				{
					((Control)this).set_Cursor(Cursors.get_SizeNESW());
				}
				else if ((e.get_X() >= 0 && e.get_X() <= 2) || (e.get_X() >= ((Control)this).get_Width() - 3 && e.get_X() <= ((Control)this).get_Width()))
				{
					((Control)this).set_Cursor(Cursors.get_SizeWE());
				}
				else if ((e.get_Y() >= 0 && e.get_Y() <= 2) || (e.get_Y() >= ((Control)this).get_Height() - 3 && e.get_Y() <= ((Control)this).get_Height()))
				{
					((Control)this).set_Cursor(Cursors.get_SizeNS());
				}
				else if (((Control)this).get_Cursor() == Cursors.get_SizeWE() || ((Control)this).get_Cursor() == Cursors.get_SizeNS() || ((Control)this).get_Cursor() == Cursors.get_SizeNWSE() || ((Control)this).get_Cursor() == Cursors.get_SizeNESW())
				{
					((Control)this).set_Cursor(Cursors.get_Default());
				}
			}
			else if (eBarState_0 == eBarState.AutoHide && genericItemContainer_0.LayoutType == eLayoutType.DockContainer && genericItemContainer_0.Stretch)
			{
				if ((e.get_X() <= 2 && (int)dockSiteInfo_1.DockSide == 4) || (e.get_X() >= ((Control)this).get_Width() - 2 && (int)dockSiteInfo_1.DockSide == 3))
				{
					((Control)this).set_Cursor(Cursors.get_VSplit());
				}
				else if ((e.get_Y() <= 2 && (int)dockSiteInfo_1.DockSide == 2) || (e.get_Y() >= ((Control)this).get_Height() - 2 && (int)dockSiteInfo_1.DockSide == 1))
				{
					((Control)this).set_Cursor(Cursors.get_HSplit());
				}
				else if (e.get_X() <= 2 && ((int)dockSiteInfo_1.DockSide == 2 || (int)dockSiteInfo_1.DockSide == 1) && ((Control)this).get_Left() > 0)
				{
					((Control)this).set_Cursor(Cursors.get_VSplit());
				}
				else if (e.get_Y() <= 2 && ((int)dockSiteInfo_1.DockSide == 3 || (int)dockSiteInfo_1.DockSide == 4) && ((Control)this).get_Top() > 0)
				{
					((Control)this).set_Cursor(Cursors.get_HSplit());
				}
				else if (((Control)this).get_Cursor() == Cursors.get_HSplit() || ((Control)this).get_Cursor() == Cursors.get_VSplit())
				{
					((Control)this).set_Cursor(Cursors.get_Default());
				}
			}
			else if (eBarState_0 == eBarState.Docked && eGrabHandleStyle_0 == eGrabHandleStyle.ResizeHandle)
			{
				if ((e.get_X() > Location.X + ((Control)this).get_Width() - 17 && (int)((Control)this).get_RightToLeft() == 0) || (e.get_X() < Location.X + 17 && (int)((Control)this).get_RightToLeft() == 1))
				{
					Form val = ((Control)this).FindForm();
					if (val != null && (int)val.get_WindowState() == 2)
					{
						if (((Control)this).get_Cursor() == Cursors.get_SizeNESW() || ((Control)this).get_Cursor() == Cursors.get_SizeNWSE())
						{
							((Control)this).set_Cursor(Cursors.get_Default());
						}
					}
					else if ((int)((Control)this).get_RightToLeft() == 1)
					{
						((Control)this).set_Cursor(Cursors.get_SizeNESW());
					}
					else
					{
						((Control)this).set_Cursor(Cursors.get_SizeNWSE());
					}
				}
				else if (((Control)this).get_Cursor() == Cursors.get_SizeNESW() || ((Control)this).get_Cursor() == Cursors.get_SizeNWSE())
				{
					((Control)this).set_Cursor(Cursors.get_Default());
				}
			}
			if (genericItemContainer_0.Style == eDotNetBarStyle.OfficeXP || genericItemContainer_0.Style == eDotNetBarStyle.Office2003 || genericItemContainer_0.Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(Style))
			{
				if (!class179_0.rectangle_0.IsEmpty && class179_0.rectangle_0.Contains(e.get_X(), e.get_Y()))
				{
					if (!class179_0.Boolean_0)
					{
						class179_0.Boolean_0 = true;
						method_10();
					}
				}
				else if (class179_0.Boolean_0)
				{
					class179_0.Boolean_0 = false;
					method_10();
				}
				if (!class179_0.rectangle_3.IsEmpty && class179_0.rectangle_3.Contains(e.get_X(), e.get_Y()))
				{
					if (!class179_0.Boolean_1)
					{
						class179_0.Boolean_1 = true;
						method_12();
					}
				}
				else if (class179_0.Boolean_1)
				{
					class179_0.Boolean_1 = false;
					method_12();
				}
				if (!class179_0.rectangle_1.IsEmpty && class179_0.rectangle_1.Contains(e.get_X(), e.get_Y()))
				{
					if (!class179_0.Boolean_2)
					{
						class179_0.Boolean_2 = true;
						method_14();
					}
				}
				else if (class179_0.Boolean_2)
				{
					class179_0.Boolean_2 = false;
					method_14();
				}
				if (!class179_0.rectangle_2.IsEmpty && class179_0.rectangle_2.Contains(e.get_X(), e.get_Y()))
				{
					if (!class179_0.Boolean_6)
					{
						class179_0.Boolean_6 = true;
						method_16();
					}
				}
				else if (class179_0.Boolean_6)
				{
					class179_0.Boolean_6 = false;
					method_16();
				}
			}
		}
		else if ((int)e.get_Button() == 1048576 && int_31 != 0 && eBarState_0 == eBarState.Floating)
		{
			Size clientSize = ((Control)this).get_ClientSize();
			Size empty = Size.Empty;
			Size size = MinimumDockSize(genericItemContainer_0.Orientation);
			if (int_31 != 5 && int_31 != 6)
			{
				if (int_31 != 7 && int_31 != 8)
				{
					if (int_31 == 2)
					{
						empty = method_28(new Size(e.get_X(), ((Control)this).get_Height()));
						if (!clientSize.Equals((object?)empty) && empty.Width >= size.Width && empty.Height >= size.Height)
						{
							((Control)this).set_ClientSize(empty);
							RecalcSize();
							((Control)this).Update();
							if (object_1 is IOwner owner && owner.ParentForm != null)
							{
								((Control)owner.ParentForm).Update();
							}
						}
					}
					else if (int_31 == 1)
					{
						empty = method_28(new Size(((Control)this).get_Width() - e.get_X(), ((Control)this).get_Height()));
						if (!clientSize.Equals((object?)empty) && empty.Width >= size.Width && empty.Height >= size.Height)
						{
							int right = ((Control)form0_0).get_Right();
							((Control)this).set_ClientSize(empty);
							RecalcSize();
							((Control)form0_0).set_Left(((Control)form0_0).get_Left() + right - ((Control)form0_0).get_Right());
							((Control)this).Update();
							if (object_1 is IOwner owner2 && owner2.ParentForm != null)
							{
								((Control)owner2.ParentForm).Update();
							}
						}
					}
					else if (int_31 == 4)
					{
						if (e.get_Y() > 0)
						{
							empty = ((genericItemContainer_0.LayoutType == eLayoutType.TaskList || genericItemContainer_0.LayoutType == eLayoutType.DockContainer) ? method_28(new Size(((Control)this).get_Width(), e.get_Y())) : method_28(new Size((int)((float)size_0.Width * ((float)size_0.Height / (float)e.get_Y())), ((Control)this).get_Height())));
							if (!clientSize.Equals((object?)empty) && empty.Width >= size.Width && empty.Height >= size.Height)
							{
								((Control)this).set_ClientSize(empty);
								RecalcSize();
								((Control)this).Update();
								if (object_1 is IOwner owner3 && owner3.ParentForm != null)
								{
									((Control)owner3.ParentForm).Update();
								}
							}
						}
					}
					else if (int_31 == 3 && e.get_Y() != 0)
					{
						empty = ((genericItemContainer_0.LayoutType == eLayoutType.TaskList || genericItemContainer_0.LayoutType == eLayoutType.DockContainer) ? method_28(new Size(((Control)this).get_Width(), ((Control)this).get_Height() - e.get_Y())) : method_28(new Size((int)((float)size_0.Width * ((float)size_0.Height / (float)(((Control)this).get_Height() - e.get_Y()))), ((Control)this).get_Height())));
						if (!clientSize.Equals((object?)empty) && empty.Width >= size.Width && empty.Height >= size.Height)
						{
							int bottom = ((Control)form0_0).get_Bottom();
							((Control)this).set_ClientSize(empty);
							RecalcSize();
							((Control)form0_0).set_Top(((Control)form0_0).get_Top() + bottom - ((Control)form0_0).get_Bottom());
							((Control)this).Update();
							if (object_1 is IOwner owner4 && owner4.ParentForm != null)
							{
								((Control)owner4.ParentForm).Update();
							}
						}
					}
				}
				else
				{
					empty = ((int_31 != 8) ? method_28(new Size(e.get_X(), ((Control)this).get_Height() - e.get_Y())) : method_28(new Size(((Control)this).get_Width() - e.get_X(), e.get_Y())));
					if (!clientSize.Equals((object?)empty) && empty.Width >= size.Width && empty.Height >= size.Height)
					{
						if (int_31 == 8)
						{
							((Form)form0_0).set_Location(new Point(((Control)form0_0).get_Left() + (((Control)this).get_Width() - empty.Width), ((Control)form0_0).get_Top()));
							((Control)this).set_ClientSize(empty);
						}
						else
						{
							((Form)form0_0).set_Location(new Point(((Control)form0_0).get_Left(), ((Control)form0_0).get_Top() + (((Control)this).get_Height() - empty.Height)));
							((Control)this).set_ClientSize(empty);
						}
						RecalcSize();
						((Control)this).Update();
						if (object_1 is IOwner owner5 && owner5.ParentForm != null)
						{
							((Control)owner5.ParentForm).Update();
						}
					}
				}
			}
			else
			{
				empty = ((int_31 != 6) ? method_28(new Size(((Control)this).get_Width() - e.get_X(), ((Control)this).get_Height() - e.get_Y())) : method_28(new Size(e.get_X(), e.get_Y())));
				if (!clientSize.Equals((object?)empty) && empty.Width >= size.Width && empty.Height >= size.Height)
				{
					if (int_31 == 6)
					{
						((Control)this).set_ClientSize(empty);
					}
					else
					{
						((Form)form0_0).set_Location(new Point(((Control)form0_0).get_Left() + (((Control)this).get_Width() - empty.Width), ((Control)form0_0).get_Top() + (((Control)this).get_Height() - empty.Height)));
						((Control)this).set_ClientSize(empty);
					}
					RecalcSize();
					((Control)this).Update();
					if (object_1 is IOwner owner6 && owner6.ParentForm != null)
					{
						((Control)owner6.ParentForm).Update();
					}
				}
			}
			rectangle_3 = new Rectangle(Location, Size);
		}
		else if (((int)e.get_Button() == 1048576 && int_31 != 0 && eBarState_0 == eBarState.AutoHide) || (int_31 == 15 && eBarState_0 == eBarState.Docked))
		{
			Size clientSize2 = ((Control)this).get_ClientSize();
			Size empty2 = Size.Empty;
			if (int_31 == 15)
			{
				if ((int)((Control)this).get_RightToLeft() == 0)
				{
					if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Parent() != null)
					{
						Point point2 = ((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y()));
						if (((Control)this).get_Parent().get_Parent().get_Parent() != null)
						{
							Point point3 = ((Control)this).get_Parent().get_Parent().get_Parent()
								.PointToScreen(((Control)this).get_Parent().get_Parent().get_Location());
							((Control)this).get_Parent().get_Parent().set_Size(new Size(point2.X - point3.X + point_2.X, point2.Y - point3.Y + point_2.Y));
						}
						else
						{
							((Control)this).get_Parent().get_Parent().set_Size(new Size(point2.X - ((Control)this).get_Parent().get_Parent().get_Location()
								.X + point_2.X, point2.Y - ((Control)this).get_Parent().get_Parent().get_Location()
								.Y + point_2.Y));
						}
						if (object_1 is IOwner owner7 && owner7.ParentForm != null)
						{
							((Control)owner7.ParentForm).Update();
						}
					}
					else if (object_1 == null && !(((Control)this).get_Parent() is DockSite) && !(((Control)this).get_Parent() is Form0))
					{
						Form val2 = ((Control)this).FindForm();
						if (val2 != null)
						{
							Point point4 = ((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y()));
							val2.set_Size(new Size(point4.X - val2.get_Location().X + point_2.X, point4.Y - val2.get_Location().Y + point_2.Y));
							((Control)val2).Update();
						}
					}
				}
				else if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Parent() != null)
				{
					Point point5 = ((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y()));
					if (((Control)this).get_Parent().get_Parent().get_Parent() != null)
					{
						Point point6 = ((Control)this).get_Parent().get_Parent().get_Parent()
							.PointToScreen(((Control)this).get_Parent().get_Parent().get_Location());
						Rectangle bounds = ((Control)this).get_Parent().get_Parent().get_Bounds();
						bounds.X = point5.X - point_2.X;
						bounds.Width += ((Control)this).get_Parent().get_Parent().get_Left() - bounds.X;
						bounds.Height = point5.Y - point6.Y + point_2.Y;
						((Control)this).get_Parent().get_Parent().set_Bounds(bounds);
					}
					else
					{
						Rectangle bounds2 = ((Control)this).get_Parent().get_Parent().get_Bounds();
						bounds2.X = point5.X - point_2.X;
						bounds2.Width += ((Control)this).get_Parent().get_Parent().get_Left() - bounds2.X;
						bounds2.Height = point5.Y - ((Control)this).get_Parent().get_Parent().get_Location()
							.Y + point_2.Y;
						((Control)this).get_Parent().get_Parent().set_Bounds(bounds2);
					}
					if (object_1 is IOwner owner8 && owner8.ParentForm != null)
					{
						((Control)owner8.ParentForm).Update();
					}
				}
				else if (object_1 == null && !(((Control)this).get_Parent() is DockSite) && !(((Control)this).get_Parent() is Form0))
				{
					Form val3 = ((Control)this).FindForm();
					if (val3 != null)
					{
						Point point7 = ((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y()));
						Rectangle bounds3 = ((Control)val3).get_Bounds();
						bounds3.X = point7.X - point_2.X;
						bounds3.Width += ((Control)val3).get_Left() - bounds3.X;
						bounds3.Height = point7.Y - val3.get_Location().Y + point_2.Y;
						((Control)val3).set_Bounds(bounds3);
						((Control)val3).Update();
					}
				}
			}
			else if (int_31 == 9)
			{
				int num = method_53();
				int num2 = e.get_X();
				int num3 = 32;
				if (object_1 is DotNetBarManager)
				{
					num3 = ((DotNetBarManager)object_1).MinimumClientSize.Width;
				}
				if (num3 > 0 && num + num2 < num3)
				{
					num2 = num3 - num;
				}
				if (num + num2 >= num3 || num3 == 0)
				{
					int int32_ = genericItemContainer_0.Int32_2;
					genericItemContainer_0.Int32_2 = 0;
					empty2 = method_28(new Size(((Control)this).get_Width() - num2, ((Control)this).get_Height()));
					genericItemContainer_0.Int32_2 = int32_;
					if (!clientSize2.Equals((object?)empty2))
					{
						if (eBarState_0 == eBarState.AutoHide)
						{
							Rectangle bounds4 = ((Control)this).get_Bounds();
							Boolean_0 = false;
							try
							{
								genericItemContainer_0.Int32_2 = genericItemContainer_0.WidthInternal - num2;
								((Control)this).set_Width(((Control)this).get_Width() - num2);
								RecalcSize();
								((Control)this).set_Left(((Control)this).get_Left() + (clientSize2.Width - Size.Width));
							}
							finally
							{
								Boolean_0 = true;
							}
							if (((Control)this).get_Parent() != null)
							{
								((Control)this).get_Parent().Invalidate(bounds4, true);
								((Control)this).get_Parent().Invalidate(((Control)this).get_Bounds(), true);
								((Control)this).get_Parent().Update();
							}
							else
							{
								((Control)this).Refresh();
							}
						}
						else
						{
							int int32_2 = genericItemContainer_0.Int32_2;
							genericItemContainer_0.Int32_2 = genericItemContainer_0.WidthInternal - num2;
							if (genericItemContainer_0.Int32_2 < int32_2)
							{
								method_55();
							}
							RecalcLayout();
						}
						if (eBarState_0 == eBarState.AutoHide)
						{
							dockSiteInfo_1.DockedWidth = ((Control)this).get_Width();
						}
					}
				}
			}
			else if (int_31 == 10)
			{
				int num4 = method_53();
				int num5 = e.get_X();
				int num6 = 32;
				if (object_1 is DotNetBarManager)
				{
					num6 = ((DotNetBarManager)object_1).MinimumClientSize.Width;
				}
				if (num6 > 0 && num4 - (num5 - ((Control)this).get_Width()) < num6)
				{
					num5 = num4 + ((Control)this).get_Width() - num6;
				}
				if (num4 - (num5 - ((Control)this).get_Width()) >= num6 || num6 == 0)
				{
					int int32_3 = genericItemContainer_0.Int32_2;
					genericItemContainer_0.Int32_2 = 0;
					empty2 = method_28(new Size(num5, ((Control)this).get_Height()));
					genericItemContainer_0.Int32_2 = int32_3;
					if (!clientSize2.Equals((object?)empty2))
					{
						if (eBarState_0 == eBarState.AutoHide)
						{
							Rectangle bounds5 = ((Control)this).get_Bounds();
							Boolean_0 = false;
							try
							{
								genericItemContainer_0.Int32_2 = genericItemContainer_0.WidthInternal + (num5 - ((Control)this).get_Width());
								((Control)this).set_Width(((Control)this).get_Width() + (num5 - ((Control)this).get_Width()));
								RecalcSize();
							}
							finally
							{
								Boolean_0 = true;
							}
							if (((Control)this).get_Parent() != null)
							{
								((Control)this).get_Parent().Invalidate(bounds5, true);
								((Control)this).get_Parent().Invalidate(((Control)this).get_Bounds(), true);
								((Control)this).get_Parent().Update();
							}
							else
							{
								((Control)this).Refresh();
							}
						}
						else
						{
							int int32_4 = genericItemContainer_0.Int32_2;
							genericItemContainer_0.Int32_2 = genericItemContainer_0.WidthInternal + (num5 - ((Control)this).get_Width());
							if (genericItemContainer_0.Int32_2 < int32_4)
							{
								method_55();
							}
							RecalcLayout();
						}
						if (eBarState_0 == eBarState.AutoHide)
						{
							dockSiteInfo_1.DockedWidth = ((Control)this).get_Width();
						}
					}
				}
			}
			else if (int_31 == 12)
			{
				int num7 = method_54();
				int num8 = e.get_Y();
				int num9 = 32;
				if (object_1 is DotNetBarManager)
				{
					num9 = ((DotNetBarManager)object_1).MinimumClientSize.Height;
				}
				if (num9 > 0 && num7 + num8 < num9)
				{
					num8 = num9 - num7;
				}
				if (num7 + num8 >= num9 || num9 == 0)
				{
					int int32_5 = genericItemContainer_0.Int32_1;
					genericItemContainer_0.Int32_1 = 0;
					empty2 = method_28(new Size(((Control)this).get_Width(), ((Control)this).get_Height() - num8));
					genericItemContainer_0.Int32_1 = int32_5;
					if (!clientSize2.Equals((object?)empty2))
					{
						if (eBarState_0 == eBarState.AutoHide)
						{
							Rectangle bounds6 = ((Control)this).get_Bounds();
							Boolean_0 = false;
							try
							{
								genericItemContainer_0.Int32_1 = genericItemContainer_0.HeightInternal - num8;
								((Control)this).set_Height(((Control)this).get_Height() - num8);
								RecalcSize();
								((Control)this).set_Top(((Control)this).get_Top() + (clientSize2.Height - ((Control)this).get_Height()));
							}
							finally
							{
								Boolean_0 = true;
							}
							if (((Control)this).get_Parent() != null)
							{
								((Control)this).get_Parent().Invalidate(bounds6, true);
								((Control)this).get_Parent().Invalidate(((Control)this).get_Bounds(), true);
								((Control)this).get_Parent().Update();
							}
							else
							{
								((Control)this).Refresh();
							}
						}
						else
						{
							int int32_6 = genericItemContainer_0.Int32_1;
							Size size2 = MinimumDockSize(genericItemContainer_0.Orientation);
							if (genericItemContainer_0.HeightInternal - num8 >= size2.Height)
							{
								genericItemContainer_0.Int32_1 = genericItemContainer_0.HeightInternal - num8;
							}
							if (genericItemContainer_0.Int32_1 < int32_6)
							{
								method_56();
							}
							RecalcLayout();
						}
						if (eBarState_0 == eBarState.AutoHide)
						{
							dockSiteInfo_1.DockedHeight = ((Control)this).get_Height();
						}
					}
				}
			}
			else if (int_31 == 11)
			{
				int num10 = method_54();
				int num11 = e.get_Y();
				int num12 = 32;
				if (object_1 is DotNetBarManager)
				{
					num12 = ((DotNetBarManager)object_1).MinimumClientSize.Height;
				}
				if (num12 > 0 && num10 - (num11 - ((Control)this).get_Height()) < num12)
				{
					num11 = num10 + ((Control)this).get_Height() - num12;
				}
				if (num10 - (num11 - ((Control)this).get_Height()) >= num12 || num12 == 0)
				{
					int int32_7 = genericItemContainer_0.Int32_1;
					genericItemContainer_0.Int32_1 = 0;
					empty2 = method_28(new Size(((Control)this).get_Width(), num11));
					genericItemContainer_0.Int32_1 = int32_7;
					if (!clientSize2.Equals((object?)empty2))
					{
						if (eBarState_0 == eBarState.AutoHide)
						{
							Rectangle bounds7 = ((Control)this).get_Bounds();
							Boolean_0 = false;
							try
							{
								genericItemContainer_0.Int32_1 = genericItemContainer_0.HeightInternal + (num11 - ((Control)this).get_Height());
								((Control)this).set_Height(num11);
								RecalcSize();
							}
							finally
							{
								Boolean_0 = true;
							}
							if (((Control)this).get_Parent() != null)
							{
								((Control)this).get_Parent().Invalidate(bounds7, true);
								((Control)this).get_Parent().Invalidate(((Control)this).get_Bounds(), true);
								((Control)this).get_Parent().Update();
							}
							else
							{
								((Control)this).Refresh();
							}
						}
						else
						{
							int int32_8 = genericItemContainer_0.Int32_1;
							genericItemContainer_0.Int32_1 = genericItemContainer_0.HeightInternal + (num11 - ((Control)this).get_Height());
							if (genericItemContainer_0.Int32_1 < int32_8)
							{
								method_56();
							}
							RecalcLayout();
						}
						if (eBarState_0 == eBarState.AutoHide)
						{
							dockSiteInfo_1.DockedHeight = ((Control)this).get_Height();
						}
					}
				}
			}
			else if (int_31 == 13 && ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) > 0)
			{
				Bar bar = method_51(this);
				if (bar != null && bar.DockLine == DockLine)
				{
					Size size3 = method_134(bar.MinimumDockSize(eOrientation.Horizontal));
					Size size4 = method_134(MinimumDockSize(eOrientation.Horizontal));
					int num13 = e.get_X();
					if (((Control)bar).get_Width() + num13 < size3.Width)
					{
						num13 += size3.Width - (((Control)bar).get_Width() + num13) - 1;
					}
					if (((Control)this).get_Width() - num13 < size4.Width)
					{
						num13 -= size4.Width - (((Control)this).get_Width() - num13) + 1;
					}
					if (((Control)bar).get_Width() + num13 >= size3.Width && ((Control)this).get_Width() - num13 >= size4.Width)
					{
						Size size5 = bar.Size;
						Size size6 = bar.method_28(new Size(((Control)bar).get_Width() + num13, ((Control)this).get_Height()));
						empty2 = method_28(new Size(((Control)this).get_Width() - num13, ((Control)this).get_Height()));
						if (!size5.Equals((object?)size6) && !clientSize2.Equals((object?)empty2))
						{
							Int32_1 = 0;
							bar.Int32_1 = ((Control)bar).get_Width() + num13;
							foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
							{
								Control val4 = item;
								if (val4 != this && val4 != bar && val4.get_Visible() && val4 is Bar)
								{
									Bar bar2 = val4 as Bar;
									if (bar2.DockLine == DockLine && bar2.Int32_0 == 0)
									{
										bar2.Int32_1 = ((Control)bar2).get_Width();
									}
								}
							}
							RecalcLayout();
						}
					}
				}
			}
			else if (int_31 == 14 && ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) > 0)
			{
				Bar bar3 = method_51(this);
				if (bar3 != null && bar3.DockLine == DockLine)
				{
					Size size7 = method_134(bar3.MinimumDockSize(eOrientation.Horizontal));
					Size size8 = method_134(MinimumDockSize(eOrientation.Horizontal));
					int num14 = e.get_Y();
					if (((Control)bar3).get_Height() + num14 < size7.Height)
					{
						num14 += size7.Height - (((Control)bar3).get_Height() + num14) - 1;
					}
					if (((Control)this).get_Height() - num14 < size8.Height)
					{
						num14 -= size8.Height - (((Control)this).get_Height() - num14) + 1;
					}
					if (((Control)bar3).get_Height() + num14 >= size7.Height && ((Control)this).get_Height() - num14 >= size8.Height)
					{
						Size size9 = bar3.Size;
						Size size10 = bar3.method_28(new Size(((Control)bar3).get_Width(), ((Control)this).get_Height() + num14));
						empty2 = method_28(new Size(((Control)this).get_Width(), ((Control)this).get_Height() - num14));
						if (!size9.Equals((object?)size10) && !clientSize2.Equals((object?)empty2))
						{
							Int32_0 = 0;
							bar3.Int32_0 = ((Control)bar3).get_Height() + num14;
							foreach (Control item2 in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
							{
								Control val5 = item2;
								if (val5 != this && val5 != bar3 && val5.get_Visible() && val5 is Bar)
								{
									Bar bar4 = val5 as Bar;
									if (bar4.DockLine == DockLine && bar4.Int32_0 == 0)
									{
										bar4.Int32_0 = ((Control)bar4).get_Height();
									}
								}
							}
							RecalcLayout();
						}
					}
				}
			}
		}
		if (eBarState_0 == eBarState.Popup && baseItem_0 != null && baseItem_0.DesignMode && (int)e.get_Button() == 1048576 && (Math.Abs(e.get_X() - point_1.X) >= 2 || Math.Abs(e.get_Y() - point_1.Y) >= 2 || bool_65))
		{
			BaseItem focusItem = baseItem_3;
			if (object_1 is IOwner)
			{
				focusItem = ((IOwner)object_1).GetFocusItem();
			}
			ISite site = method_142();
			if (site != null && focusItem != null)
			{
				method_143(e);
			}
		}
		((Control)this).OnMouseMove(e);
		if (genericItemContainer_0.SubItems.Count == 0)
		{
			bool_53 = false;
			return;
		}
		if (!bool_0 && int_31 == 0)
		{
			genericItemContainer_0.InternalMouseMove(e);
		}
		bool_53 = false;
	}

	private Bar method_51(Bar bar_1)
	{
		if (((Control)this).get_Parent() == null)
		{
			return null;
		}
		int num = ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) - 1;
		if (num >= 0)
		{
			int num2 = num;
			while (num2 >= 0)
			{
				if (!((Control)this).get_Parent().get_Controls().get_Item(num2)
					.get_Visible())
				{
					num2--;
					continue;
				}
				return ((Control)this).get_Parent().get_Controls().get_Item(num2) as Bar;
			}
		}
		return null;
	}

	private Bar method_52(Bar bar_1)
	{
		if (((Control)this).get_Parent() == null)
		{
			return null;
		}
		int num = ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) + 1;
		if (num >= 0)
		{
			for (int i = num; i < ((ArrangedElementCollection)((Control)this).get_Parent().get_Controls()).get_Count(); i++)
			{
				if (((Control)this).get_Parent().get_Controls().get_Item(i)
					.get_Visible())
				{
					return ((Control)this).get_Parent().get_Controls().get_Item(i) as Bar;
				}
			}
		}
		return null;
	}

	private int method_53()
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		if (object_1 is IOwner owner && ((Control)this).get_Parent() != null && (((Control)this).get_Parent().get_Parent() != null || eBarState_0 == eBarState.AutoHide))
		{
			Control val = ((Control)this).get_Parent().get_Parent();
			if (eBarState_0 == eBarState.AutoHide)
			{
				val = (Control)(object)owner.ParentForm;
			}
			if (val == null && owner.ParentForm == null && object_1 is DotNetBarManager)
			{
				val = ((DotNetBarManager)object_1).ParentUserControl;
			}
			if (val == null)
			{
				return 0;
			}
			int num = val.get_ClientSize().Width;
			foreach (Control item in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item;
				if (val2.get_Visible() && ((int)val2.get_Dock() == 3 || (int)val2.get_Dock() == 4))
				{
					num -= val2.get_Width();
				}
			}
			if (eBarState_0 == eBarState.AutoHide && Visible)
			{
				num -= ((Control)this).get_Width();
			}
			return num;
		}
		return 0;
	}

	private int method_54()
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Invalid comparison between Unknown and I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		if (object_1 is IOwner owner && ((Control)this).get_Parent() != null && (((Control)this).get_Parent().get_Parent() != null || eBarState_0 == eBarState.AutoHide))
		{
			Control val = null;
			val = (Control)((eBarState_0 != eBarState.AutoHide) ? ((object)((Control)this).get_Parent().get_Parent()) : ((object)owner.ParentForm));
			if (val == null && owner.ParentForm == null && object_1 is DotNetBarManager)
			{
				val = ((DotNetBarManager)object_1).ParentUserControl;
			}
			if (val == null)
			{
				return 0;
			}
			int num = val.get_ClientSize().Height;
			foreach (Control item in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item;
				if (val2.get_Visible() && ((int)val2.get_Dock() == 1 || (int)val2.get_Dock() == 2))
				{
					num -= val2.get_Height();
				}
			}
			if (eBarState_0 == eBarState.AutoHide && Visible)
			{
				num -= ((Control)this).get_Height();
			}
			return num;
		}
		return 0;
	}

	internal void method_55()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (((Control)this).get_Parent() == null)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
		{
			Control val = item;
			if (val is Bar bar && bar != this && bar.DockLine == int_29)
			{
				bar.ItemsContainer.Int32_2 = genericItemContainer_0.Int32_2;
			}
		}
	}

	internal void method_56()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		if (((Control)this).get_Parent() == null)
		{
			return;
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
		{
			Control val = item;
			if (val is Bar bar && bar != this && bar.DockLine == int_29)
			{
				bar.ItemsContainer.Int32_1 = genericItemContainer_0.Int32_1;
			}
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		method_57();
	}

	internal void method_57()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (bool_0)
		{
			return;
		}
		if ((int)Control.get_MouseButtons() == 1048576)
		{
			Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
			if (!((Control)this).get_ClientRectangle().Contains(pt) && Owner is IOwnerMenuSupport ownerMenuSupport && ownerMenuSupport.RelayMouseHover())
			{
				return;
			}
		}
		genericItemContainer_0.InternalMouseHover();
		if (class179_0.Boolean_6)
		{
			using (Class264 @class = new Class264(object_1 as IOwnerLocalize))
			{
				string text = @class.method_1(LocalizationKeys.BarAutoHideButtonTooltip);
				if (text != "")
				{
					method_114(text);
				}
				return;
			}
		}
		if (class179_0.Boolean_2)
		{
			using (Class264 class2 = new Class264(object_1 as IOwnerLocalize))
			{
				string text2 = class2.method_1(LocalizationKeys.BarCustomizeButtonTooltip);
				if (text2 != "")
				{
					method_114(text2);
				}
				return;
			}
		}
		if (!class179_0.Boolean_0)
		{
			return;
		}
		using Class264 class3 = new Class264(object_1 as IOwnerLocalize);
		string text3 = class3.method_1(LocalizationKeys.BarCloseButtonTooltip);
		if (text3 != "")
		{
			method_114(text3);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (((Control)this).get_Cursor() != Cursors.get_Arrow())
		{
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		if (class179_0.Boolean_0)
		{
			class179_0.Boolean_0 = false;
			method_10();
		}
		if (class179_0.Boolean_1)
		{
			class179_0.Boolean_1 = false;
			method_12();
		}
		if (class179_0.Boolean_2)
		{
			class179_0.Boolean_2 = false;
			method_14();
		}
		if (class179_0.Boolean_6)
		{
			class179_0.Boolean_6 = false;
			method_16();
		}
		if (!bool_0)
		{
			genericItemContainer_0.InternalMouseLeave();
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Invalid comparison between Unknown and I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Invalid comparison between Unknown and I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Invalid comparison between Unknown and I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Invalid comparison between Unknown and I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Invalid comparison between Unknown and I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Invalid comparison between Unknown and I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Invalid comparison between Unknown and I4
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Invalid comparison between Unknown and I4
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Invalid comparison between Unknown and I4
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Invalid comparison between Unknown and I4
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Invalid comparison between Unknown and I4
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Invalid comparison between Unknown and I4
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Invalid comparison between Unknown and I4
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Invalid comparison between Unknown and I4
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Invalid comparison between Unknown and I4
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Invalid comparison between Unknown and I4
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Invalid comparison between Unknown and I4
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Invalid comparison between Unknown and I4
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Invalid comparison between Unknown and I4
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Invalid comparison between Unknown and I4
		point_1 = new Point(e.get_X(), e.get_Y());
		size_0 = Size;
		method_111();
		if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_1.IsEmpty && class179_0.rectangle_1.Contains(point_1) && !((Component)this).DesignMode && !genericItemContainer_0.DesignMode)
		{
			if (popupItem_0 != null)
			{
				if (popupItem_0.GetOwner() == null)
				{
					popupItem_0.method_6(object_1);
				}
				Point point = ((genericItemContainer_0.Style != eDotNetBarStyle.Office2000) ? new Point(class179_0.rectangle_1.Left, class179_0.rectangle_1.Bottom) : new Point(0, 16));
				if (point.X < 0)
				{
					point.X = 0;
				}
				point = ((Control)this).PointToScreen(point);
				popupItem_0.SetSourceControl((Control)(object)this);
				popupItem_0.Popup(point);
				((Control)this).OnMouseDown(e);
				return;
			}
			foreach (BaseItem subItem in genericItemContainer_0.SubItems)
			{
				if (subItem is CustomizeItem && !subItem.Expanded)
				{
					if (genericItemContainer_0.Style == eDotNetBarStyle.Office2000)
					{
						((CustomizeItem)subItem).PopupLocation = new Point(((Control)this).get_Left() - 128, ((Control)this).get_Top() + 16);
					}
					else
					{
						((CustomizeItem)subItem).PopupLocation = new Point(class179_0.rectangle_1.Left, class179_0.rectangle_1.Bottom);
					}
					subItem.Expanded = true;
					((Control)this).OnMouseDown(e);
					return;
				}
			}
		}
		else
		{
			if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_0.IsEmpty && class179_0.rectangle_0.Contains(e.get_X(), e.get_Y()))
			{
				class179_0.Boolean_3 = true;
				method_10();
				((Control)this).OnMouseDown(e);
				return;
			}
			if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_3.IsEmpty && class179_0.rectangle_3.Contains(e.get_X(), e.get_Y()))
			{
				class179_0.Boolean_4 = true;
				method_12();
				((Control)this).OnMouseDown(e);
				return;
			}
			if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_2.IsEmpty && class179_0.rectangle_2.Contains(e.get_X(), e.get_Y()))
			{
				class179_0.Boolean_7 = true;
				method_16();
				((Control)this).OnMouseDown(e);
				return;
			}
			if ((int)e.get_Button() == 1048576 && eBarState_0 == eBarState.Floating)
			{
				if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && e.get_X() <= 4 && e.get_Y() <= 4)
				{
					int_31 = 5;
				}
				else if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && e.get_X() >= ((Control)this).get_Width() - 4 && e.get_Y() >= ((Control)this).get_Height() - 4)
				{
					int_31 = 6;
				}
				else if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && e.get_X() >= ((Control)this).get_Width() - 4 && e.get_Y() <= 4)
				{
					int_31 = 7;
				}
				else if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && e.get_X() <= 4 && e.get_Y() >= ((Control)this).get_Height() - 4)
				{
					int_31 = 8;
				}
				else if (e.get_X() >= 0 && e.get_X() <= 2)
				{
					int_31 = 1;
				}
				else if (e.get_X() >= ((Control)this).get_Width() - 3 && e.get_X() <= ((Control)this).get_Width())
				{
					int_31 = 2;
				}
				else if (e.get_Y() >= 0 && e.get_Y() <= 2)
				{
					int_31 = 3;
				}
				else if (e.get_Y() >= ((Control)this).get_Height() - 3 && e.get_Y() <= ((Control)this).get_Height())
				{
					int_31 = 4;
				}
			}
			else if ((int)e.get_Button() == 1048576 && eBarState_0 == eBarState.AutoHide && genericItemContainer_0.LayoutType == eLayoutType.DockContainer && genericItemContainer_0.Stretch)
			{
				if ((int)dockSiteInfo_1.DockSide == 4 && e.get_X() <= 2)
				{
					int_31 = 9;
				}
				else if ((int)dockSiteInfo_1.DockSide == 3 && e.get_X() >= ((Control)this).get_Width() - 2)
				{
					int_31 = 10;
				}
				else if ((int)dockSiteInfo_1.DockSide == 2 && e.get_Y() <= 2)
				{
					int_31 = 12;
				}
				else if ((int)dockSiteInfo_1.DockSide == 1 && e.get_Y() >= ((Control)this).get_Height() - 2)
				{
					int_31 = 11;
				}
				else if (((int)dockSiteInfo_1.DockSide == 2 || (int)dockSiteInfo_1.DockSide == 1) && e.get_X() <= 2 && ((Control)this).get_Left() > 0)
				{
					int_31 = 13;
				}
				else if (((int)dockSiteInfo_1.DockSide == 3 || (int)dockSiteInfo_1.DockSide == 4) && e.get_Y() <= 2 && ((Control)this).get_Top() > 0)
				{
					int_31 = 14;
				}
			}
			else if ((int)e.get_Button() == 2097152 && CanCustomize && !genericItemContainer_0.DesignMode && eBarState_0 != 0 && !bool_0 && object_1 is DotNetBarManager && object_1 is IOwnerBarSupport ownerBarSupport)
			{
				ownerBarSupport.BarContextMenu((Control)(object)this, e);
			}
		}
		if ((int)e.get_Button() == 1048576 && eBarState_0 == eBarState.Docked && eGrabHandleStyle_0 == eGrabHandleStyle.ResizeHandle && point_1.X > Location.X + ((Control)this).get_Width() - 17 && (int)((Control)this).get_RightToLeft() == 0)
		{
			Form val = ((Control)this).FindForm();
			if ((val != null && (int)val.get_WindowState() != 2) || val == null)
			{
				((Control)this).set_Capture(true);
				((Control)this).set_Cursor(Cursors.get_SizeNWSE());
				int_31 = 15;
				Point point2 = ((Control)this).PointToScreen(point_1);
				if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Parent() != null)
				{
					point2 = ((Control)this).get_Parent().get_Parent().PointToClient(point2);
					point_2 = new Point(((Control)this).get_Parent().get_Parent().get_Width() - point2.X, ((Control)this).get_Parent().get_Parent().get_ClientRectangle()
						.Height - point2.Y);
				}
				else if (object_1 == null && !(((Control)this).get_Parent() is DockSite) && !(((Control)this).get_Parent() is Form0) && val != null)
				{
					point2 = ((Control)val).PointToClient(point2);
					point_2 = new Point(((Control)val).get_Width() - point2.X, ((Control)val).get_ClientRectangle().Height - point2.Y);
				}
			}
		}
		else if ((int)e.get_Button() == 1048576 && eBarState_0 == eBarState.Docked && eGrabHandleStyle_0 == eGrabHandleStyle.ResizeHandle && point_1.X < Location.X + 17 && (int)((Control)this).get_RightToLeft() == 1)
		{
			Form val2 = ((Control)this).FindForm();
			if ((val2 != null && (int)val2.get_WindowState() != 2) || val2 == null)
			{
				((Control)this).set_Capture(true);
				((Control)this).set_Cursor(Cursors.get_SizeNESW());
				int_31 = 15;
				Point point3 = point_1;
				if ((object)((object)val2).GetType().GetProperty("RightToLeftLayout") != null && (bool)TypeDescriptor.GetProperties(val2)["RightToLeftLayout"]!.GetValue(val2))
				{
					point3.X = ((Control)this).get_Width() - point3.X;
				}
				Point point4 = ((Control)this).PointToScreen(point3);
				if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_Parent() != null)
				{
					point4 = ((Control)this).get_Parent().get_Parent().PointToClient(point4);
					point_2 = new Point(point4.X, ((Control)this).get_Parent().get_Parent().get_ClientRectangle()
						.Height - point4.Y);
				}
				else if (object_1 == null && !(((Control)this).get_Parent() is DockSite) && !(((Control)this).get_Parent() is Form0) && val2 != null)
				{
					point4 = ((Control)val2).PointToClient(point4);
					point_2 = new Point(point4.X, ((Control)val2).get_ClientRectangle().Height - point4.Y);
				}
			}
		}
		if ((int)e.get_Button() == 1048576 && !rectangle_2.IsEmpty && rectangle_2.Contains(point_1) && int_31 == 0 && !bool_19 && (popupItem_0 == null || !popupItem_0.Expanded))
		{
			((Control)this).set_Cursor(Cursors.get_SizeAll());
			((Control)this).set_Capture(true);
			bool_0 = true;
		}
		if (eBarState_0 == eBarState.Popup && baseItem_0 != null && baseItem_0.DesignMode)
		{
			method_145(e);
		}
		else
		{
			genericItemContainer_0.InternalMouseDown(e);
		}
		((Control)this).OnMouseDown(e);
	}

	internal void method_58(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}

	internal void method_59()
	{
		BarClosingEventArgs barClosingEventArgs = new BarClosingEventArgs();
		method_68(barClosingEventArgs);
		if (!barClosingEventArgs.Cancel)
		{
			if (AutoHide)
			{
				AutoHide = false;
			}
			method_95();
			IOwner owner = Owner as IOwner;
			if (owner.ParentForm != null && !((Control)owner.ParentForm).get_ContainsFocus())
			{
				((Control)owner.ParentForm).Focus();
			}
			method_65();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Invalid comparison between Unknown and I4
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Invalid comparison between Unknown and I4
		if (bool_0 || int_31 != 0)
		{
			((Control)this).set_Cursor(Cursors.get_Default());
		}
		if (bool_65)
		{
			method_144(e);
		}
		if (bool_0)
		{
			method_60(bool_67: false, new Point(e.get_X(), e.get_Y()));
		}
		else if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_0.IsEmpty && class179_0.rectangle_0.Contains(point_1))
		{
			class179_0.Boolean_3 = false;
			method_10();
			if (class179_0.rectangle_0.Contains(e.get_X(), e.get_Y()))
			{
				if (bool_16 && SelectedDockContainerItem != null)
				{
					CloseDockTab(SelectedDockContainerItem);
				}
				else
				{
					method_59();
				}
			}
		}
		else if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_3.IsEmpty && class179_0.rectangle_3.Contains(point_1))
		{
			class179_0.Boolean_4 = false;
			method_12();
			if (class179_0.rectangle_3.Contains(e.get_X(), e.get_Y()))
			{
				InvokeCaptionButtonClick();
				if (bool_40)
				{
					method_124();
					method_12();
				}
			}
		}
		else if ((int)e.get_Button() == 1048576 && !class179_0.rectangle_2.IsEmpty && class179_0.rectangle_2.Contains(point_1))
		{
			class179_0.Boolean_7 = false;
			method_16();
			if (class179_0.rectangle_2.Contains(e.get_X(), e.get_Y()))
			{
				bool_33 = false;
				AutoHide = !AutoHide;
				method_66();
			}
		}
		bool_0 = false;
		int_31 = 0;
		if (genericItemContainer_0 != null)
		{
			genericItemContainer_0.InternalMouseUp(e);
		}
		((Control)this).OnMouseUp(e);
	}

	private void method_60(bool bool_67, Point point_3)
	{
		if (((Control)this).get_Capture())
		{
			((Control)this).set_Capture(false);
		}
		((Control)this).set_Cursor(Cursors.get_Default());
		if (Owner is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.DockComplete();
		}
		if (dockSiteInfo_0.IsEmpty())
		{
			bool_0 = false;
			return;
		}
		if (bar_0 == null && dockSiteInfo_0.TabDockContainer == null)
		{
			if (int_30 != -1)
			{
				method_61();
				if (bool_67)
				{
					method_42(dockSiteInfo_1, ((Control)this).PointToScreen(new Point(point_3.X, point_3.Y)));
				}
				else
				{
					DockContainerItem dockContainerItem = (DockContainerItem)Items[int_30];
					Bar bar = method_63(dockContainerItem, bool_67: false);
					bar.method_42(dockSiteInfo_0, ((Control)this).PointToScreen(new Point(point_3.X, point_3.Y)));
					Form val = ((Control)this).FindForm();
					if (val != null && dockContainerItem != null && dockContainerItem.Control != null)
					{
						((ContainerControl)val).set_ActiveControl(dockContainerItem.Control);
					}
				}
				dockSiteInfo_0 = default(DockSiteInfo);
				int_30 = -1;
			}
			else if (rectangle_5.IsEmpty && form_0 == null)
			{
				if (bool_67)
				{
					method_42(dockSiteInfo_1, ((Control)this).PointToScreen(new Point(point_3.X, point_3.Y)));
					dockSiteInfo_0 = default(DockSiteInfo);
				}
			}
			else
			{
				method_61();
				if (bool_67)
				{
					method_42(dockSiteInfo_1, ((Control)this).PointToScreen(new Point(point_3.X, point_3.Y)));
				}
				else
				{
					method_42(dockSiteInfo_0, ((Control)this).PointToScreen(new Point(point_3.X, point_3.Y)));
				}
				dockSiteInfo_0 = default(DockSiteInfo);
			}
			bool_0 = false;
			return;
		}
		method_61();
		Bar tabDockContainer = bar_0;
		if (tabDockContainer == null)
		{
			tabDockContainer = dockSiteInfo_0.TabDockContainer;
		}
		method_45();
		if (dockSiteInfo_0.TabDockContainer != this)
		{
			if (int_30 == -1)
			{
				ArrayList arrayList = new ArrayList(genericItemContainer_0.SubItems.Count);
				genericItemContainer_0.SubItems.method_4(arrayList);
				DockContainerItem dockContainerItem2 = null;
				Form val2 = ((Control)tabDockContainer).FindForm();
				if (val2 != null)
				{
					((ContainerControl)val2).set_ActiveControl((Control)(object)tabDockContainer);
				}
				foreach (BaseItem item in arrayList)
				{
					if (item is DockContainerItem dockContainerItem3)
					{
						if (dockContainerItem2 == null)
						{
							dockContainerItem2 = dockContainerItem3;
						}
						dockContainerItem3.Displayed = false;
						if (dockContainerItem3.String_0 == "")
						{
							dockContainerItem3.String_0 = Name;
							dockContainerItem3.Int32_0 = genericItemContainer_0.SubItems.IndexOf(dockContainerItem3);
						}
						genericItemContainer_0.SubItems.Remove(dockContainerItem3);
						tabDockContainer.Items.Add(dockContainerItem3);
					}
				}
				tabDockContainer.RecalcLayout();
				if (dockContainerItem2 != null)
				{
					tabDockContainer.SelectedDockContainerItem = dockContainerItem2;
				}
				tabDockContainer.method_43();
				if (object_1 is DotNetBarManager dotNetBarManager)
				{
					bool_0 = false;
					tabDockContainer = null;
					if (CustomBar)
					{
						dotNetBarManager.Bars.Remove(this);
						((Component)this).Dispose();
					}
					else
					{
						Visible = false;
					}
					if (dotNetBarManager.ParentForm != null)
					{
						dotNetBarManager.ParentForm.Activate();
					}
					return;
				}
			}
			else
			{
				Form val3 = ((Control)tabDockContainer).FindForm();
				if (val3 != null)
				{
					((ContainerControl)val3).set_ActiveControl((Control)(object)tabDockContainer);
				}
				DockContainerItem dockContainerItem4 = genericItemContainer_0.SubItems[int_30] as DockContainerItem;
				dockContainerItem4.Displayed = false;
				genericItemContainer_0.SubItems.Remove(dockContainerItem4);
				tabDockContainer.Items.Add(dockContainerItem4);
				tabDockContainer.SelectedDockContainerItem = dockContainerItem4;
				tabDockContainer.RecalcLayout();
				tabDockContainer.method_43();
			}
		}
		bar_0 = null;
		int_30 = -1;
		bool_0 = false;
		dockSiteInfo_0 = default(DockSiteInfo);
	}

	private void method_61()
	{
		if (!rectangle_5.IsEmpty || form_0 != null)
		{
			if (!rectangle_5.IsEmpty)
			{
				Class92.smethod_1(rectangle_5, 3);
				rectangle_5 = Rectangle.Empty;
			}
			if (form_0 != null)
			{
				((Control)form_0).set_Visible(false);
				((Component)(object)form_0).Dispose();
				form_0 = null;
			}
		}
	}

	internal Bar method_62()
	{
		if (tabStrip_0.SelectedTab == null)
		{
			return null;
		}
		if (!(tabStrip_0.SelectedTab.AttachedItem is DockContainerItem dockContainerItem))
		{
			return null;
		}
		if (!(object_1 is DotNetBarManager))
		{
			return null;
		}
		if (VisibleItemCount == 1 && GrabHandleStyle == eGrabHandleStyle.None)
		{
			method_64();
			return this;
		}
		if (!CanUndock)
		{
			int_30 = Items.IndexOf(dockContainerItem);
			method_64();
			return this;
		}
		Bar bar = method_63(dockContainerItem, bool_67: true);
		bar.InitalFloatLocation = Point.Empty;
		bar.method_64();
		return bar;
	}

	private Bar method_63(DockContainerItem dockContainerItem_0, bool bool_67)
	{
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			((ContainerControl)val).set_ActiveControl((Control)(object)this);
		}
		DotNetBarManager dotNetBarManager = object_1 as DotNetBarManager;
		genericItemContainer_0.SubItems.Remove(dockContainerItem_0);
		RecalcLayout();
		Bar bar = Class109.smethod_6(this);
		((Control)bar).set_Text(dockContainerItem_0.Text);
		Point location = (bar.InitalFloatLocation = new Point(Control.get_MousePosition().X - 32, Control.get_MousePosition().Y - 8));
		if (dotNetBarManager.Bars.Contains(dockContainerItem_0.Name))
		{
			string name = dockContainerItem_0.Name;
			int num = 0;
			while (dotNetBarManager.Bars.Contains(name + num))
			{
				num++;
			}
			bar.Name = name + num;
		}
		else
		{
			bar.Name = dockContainerItem_0.Name;
		}
		bar.Items.Add(dockContainerItem_0);
		dotNetBarManager.Bars.Add(bar);
		if (bool_67)
		{
			bar.DockSide = eDockSide.None;
			bar.Location = location;
		}
		bar.CustomBar = true;
		if (object_1 is IOwnerBarSupport ownerBarSupport)
		{
			if (ownerBarSupport.ApplyDocumentBarStyle && DockSide == eDockSide.Document)
			{
				Class109.smethod_10(bar);
			}
			ownerBarSupport.InvokeBarTearOff(bar, new EventArgs());
		}
		return bar;
	}

	internal void method_64()
	{
		point_1 = ((Control)this).PointToClient(Control.get_MousePosition());
		size_0 = Size;
		((Control)this).set_Cursor(Cursors.get_SizeAll());
		bool_0 = true;
	}

	internal void method_65()
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, new EventArgs());
		}
	}

	private void method_66()
	{
		EventArgs e = new EventArgs();
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
		}
		if (object_1 is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.InvokeAutoHideChanged(this, e);
		}
	}

	public void CloseDockTab(DockContainerItem dockTab)
	{
		CloseDockTab(dockTab, eEventSource.Code);
	}

	public void CloseDockTab(DockContainerItem dockTab, eEventSource source)
	{
		DockTabClosingEventArgs dockTabClosingEventArgs = new DockTabClosingEventArgs(dockTab, source);
		method_67(dockTabClosingEventArgs);
		if (dockTabClosingEventArgs.Cancel)
		{
			return;
		}
		if (VisibleItemCount > 1)
		{
			if (dockTabClosingEventArgs.RemoveDockTab)
			{
				Items.Remove(dockTab);
			}
			else
			{
				BarUtilities.SetDockContainerVisible(dockTab, visible: false);
			}
			return;
		}
		if (dockTabClosingEventArgs.RemoveDockTab)
		{
			Items.Remove(dockTab);
		}
		method_59();
		if (!Visible)
		{
			dockTab.Visible = false;
		}
	}

	internal void method_67(DockTabClosingEventArgs dockTabClosingEventArgs_0)
	{
		if (dockTabClosingEventHandler_0 != null)
		{
			dockTabClosingEventHandler_0(this, dockTabClosingEventArgs_0);
		}
		if (Owner is DotNetBarManager)
		{
			((DotNetBarManager)Owner).InvokeDockTabClosing(this, dockTabClosingEventArgs_0);
		}
	}

	private void method_68(BarClosingEventArgs barClosingEventArgs_0)
	{
		if (barClosingEventHandler_0 != null)
		{
			barClosingEventHandler_0(this, barClosingEventArgs_0);
		}
		if (object_1 is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.InvokeBarClosing(this, barClosingEventArgs_0);
		}
	}

	protected virtual void OnItemClick(BaseItem item, EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(item, e);
		}
	}

	internal void method_69(BaseItem baseItem_5, EventArgs eventArgs_0)
	{
		OnItemClick(baseItem_5, eventArgs_0);
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		genericItemContainer_0.InternalClick(Control.get_MouseButtons(), ((Control)this).PointToClient(Control.get_MousePosition()));
		((Control)this).OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		if (eBarState_0 == eBarState.Popup)
		{
			ISite site = method_142();
			if (site != null && site.DesignMode)
			{
				ISelectionService selectionService = (ISelectionService)site.GetService(typeof(ISelectionService));
				if (selectionService != null)
				{
					((IDesignerHost)site.GetService(typeof(IDesignerHost)))?.GetDesigner(selectionService.PrimarySelection as IComponent)?.DoDefaultAction();
				}
			}
		}
		if (rectangle_2.Contains(((Control)this).PointToClient(Control.get_MousePosition())))
		{
			if (eBarState_0 == eBarState.Floating && (CanDockBottom || CanDockTop || CanDockLeft || CanDockRight))
			{
				method_42(dockSiteInfo_1, Point.Empty);
			}
			else if (eBarState_0 == eBarState.Docked && CanUndock && ((Control)this).get_Parent() is DockSite)
			{
				Point empty = Point.Empty;
				empty = ((!rectangle_3.IsEmpty) ? rectangle_3.Location : Control.get_MousePosition());
				method_42(default(DockSiteInfo), empty);
			}
		}
		genericItemContainer_0.InternalDoubleClick(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		method_70(e);
		((Control)this).OnKeyDown(e);
	}

	internal void method_70(KeyEventArgs keyEventArgs_0)
	{
		genericItemContainer_0.InternalKeyDown(keyEventArgs_0);
	}

	private void method_71()
	{
		Class92.TRACKMOUSEEVENT tme = default(Class92.TRACKMOUSEEVENT);
		tme.dwFlags = 1073741824u;
		tme.hwndTrack = ((Control)this).get_Handle();
		tme.cbSize = Marshal.SizeOf((object)tme);
		Class92.TrackMouseEvent(ref tme);
		tme.dwFlags |= 1u;
		Class92.TrackMouseEvent(ref tme);
	}

	public override string ToString()
	{
		return ((Control)this).get_Text();
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (((Control)this).get_IsHandleCreated())
		{
			bool_54 = ((Control)this).get_Visible();
		}
		if (int_37 >= 0)
		{
			if (((Control)this).get_Parent() is DockSite && ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this) != int_37)
			{
				((Control)this).get_Parent().get_Controls().SetChildIndex((Control)(object)this, int_37);
			}
			int_37 = -1;
		}
		if (object_1 is IOwner owner)
		{
			if (owner.ParentForm != null && ((ContainerControl)owner.ParentForm).get_ActiveControl() == this)
			{
				((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
				((Control)this).Focus();
			}
			else if (owner.ParentForm != null && method_37((Control)(object)this, ((ContainerControl)owner.ParentForm).get_ActiveControl()))
			{
				((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
				((Control)this).Focus();
			}
		}
		((Control)this).OnVisibleChanged(e);
		if (eBarState_0 == eBarState.Docked && !bool_5 && Visible)
		{
			if (LayoutType == eLayoutType.DockContainer && bool_36)
			{
				method_120(bool_67: false);
			}
			RecalcLayout();
		}
		if (!Visible && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		if (!Visible && popupItem_0 != null && popupItem_0.Expanded)
		{
			popupItem_0.Expanded = false;
		}
	}

	public void SuspendLayout()
	{
		bool_55 = true;
		((Control)this).SuspendLayout();
	}

	public void ResumeLayout()
	{
		ResumeLayout(performLayout: true);
	}

	public void ResumeLayout(bool performLayout)
	{
		bool_55 = false;
		((Control)this).ResumeLayout(true);
	}

	protected override void OnParentChanged(EventArgs e)
	{
		((Control)this).OnParentChanged(e);
		if (((Control)this).get_Parent() != null && !(((Control)this).get_Parent() is Form0) && !(((Control)this).get_Parent() is DockSite))
		{
			genericItemContainer_0.method_6(this);
			if (!bool_31 && ((Component)this).DesignMode && ((Control)this).FindForm() != null)
			{
				DotNetBarManager.RegisterOwnerParentMsgHandler(this, ((Control)this).FindForm());
				bool_31 = true;
			}
			if (hashtable_1.Count == 0)
			{
				foreach (BaseItem subItem in genericItemContainer_0.SubItems)
				{
					((IOwner)this).AddShortcutsFromItem(subItem);
				}
			}
			if (((Control)this).get_Parent() != null && !(((Control)this).get_Parent() is Form0) && !(((Control)this).get_Parent() is DockSite) && !AutoHide && !bool_60)
			{
				Class107.smethod_0(this);
				bool_60 = true;
			}
			if (!bool_4)
			{
				Stretch = true;
			}
		}
		else if (bool_60)
		{
			Class107.smethod_1(this);
			bool_60 = false;
		}
		if (((Component)this).DesignMode)
		{
			genericItemContainer_0.SetDesignMode(((Component)this).DesignMode);
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (struct11_0.Boolean_0)
		{
			method_72();
		}
		if (((Control)this).get_Parent() != null && !(((Control)this).get_Parent() is Form0) && !(((Control)this).get_Parent() is DockSite) && !AutoHide && !bool_60)
		{
			Class107.smethod_0(this);
			bool_60 = true;
		}
		RecalcSize();
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_73();
		method_138();
		if (bool_60)
		{
			Class107.smethod_1(this);
			bool_60 = false;
		}
		((Control)this).OnHandleDestroyed(e);
	}

	private void method_72()
	{
		if (!Class109.Boolean_0)
		{
			return;
		}
		Class77 @class = Class77_0;
		Graphics val = CreateGraphics();
		try
		{
			Size size = @class.ThemeMinSize(val, Class124.class124_10, Class149.class149_4);
			struct11_0.int_0 = size.Width;
			size = @class.ThemeMinSize(val, Class124.class124_11, Class149.class149_4);
			struct11_0.int_2 = size.Width;
			size = @class.ThemeMinSize(val, Class124.class124_12, Class149.class149_4);
			struct11_0.int_3 = size.Height;
			size = @class.ThemeTrueSize(val, Class124.class124_2, Class149.class149_4);
			struct11_0.int_1 = size.Height;
		}
		finally
		{
			val.Dispose();
		}
	}

	private void method_73()
	{
		if (class77_0 != null)
		{
			class77_0.Dispose();
			class77_0 = null;
		}
		if (class78_0 != null)
		{
			class78_0.Dispose();
			class78_0 = null;
		}
		if (class79_0 != null)
		{
			class79_0.Dispose();
			class79_0 = null;
		}
		if (class65_0 != null)
		{
			class65_0.Dispose();
			class65_0 = null;
		}
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = null;
		}
		if (class64_0 != null)
		{
			class64_0.Dispose();
			class64_0 = null;
		}
	}

	private void method_74()
	{
		if (class77_0 != null)
		{
			class77_0.Dispose();
			class77_0 = new Class77((Control)(object)this);
		}
		if (class78_0 != null)
		{
			class78_0.Dispose();
			class78_0 = new Class78((Control)(object)this);
		}
		if (class79_0 != null)
		{
			class79_0.Dispose();
			class79_0 = new Class79((Control)(object)this);
		}
		if (class65_0 != null)
		{
			class65_0.Dispose();
			class65_0 = new Class65((Control)(object)this);
		}
		if (class63_0 != null)
		{
			class63_0.Dispose();
			class63_0 = new Class63((Control)(object)this);
		}
		if (class64_0 != null)
		{
			class64_0.Dispose();
			class64_0 = new Class64((Control)(object)this);
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).OnGotFocus(e);
		if (MenuBar)
		{
			((Control)this).Refresh();
		}
	}

	protected override void OnLostFocus(EventArgs e)
	{
		((Control)this).OnLostFocus(e);
		if (MenuBar)
		{
			((Control)this).Refresh();
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void SetDesignMode(bool b)
	{
		genericItemContainer_0.SetDesignMode(b);
	}

	internal bool method_75()
	{
		return ((Component)this).DesignMode;
	}

	void ICustomSerialization.InvokeSerializeItem(SerializeItemEventArgs e)
	{
		if (serializeItemEventHandler_0 != null)
		{
			serializeItemEventHandler_0(this, e);
		}
		if (Owner != this && Owner is ICustomSerialization)
		{
			((ICustomSerialization)Owner).InvokeSerializeItem(e);
		}
	}

	void ICustomSerialization.InvokeDeserializeItem(SerializeItemEventArgs e)
	{
		if (serializeItemEventHandler_1 != null)
		{
			serializeItemEventHandler_1(this, e);
		}
		if (Owner != this && Owner is ICustomSerialization)
		{
			((ICustomSerialization)Owner).InvokeDeserializeItem(e);
		}
	}

	public void SaveDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		method_76(xmlDocument);
		xmlDocument.Save(FileName);
	}

	internal void method_76(XmlDocument xmlDocument_0)
	{
		XmlElement xmlElement = xmlDocument_0.CreateElement("bar");
		xmlDocument_0.AppendChild(xmlElement);
		method_78(xmlElement);
	}

	public void LoadDefinition(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(FileName);
		method_77(xmlDocument);
	}

	internal void method_77(XmlDocument xmlDocument_0)
	{
		if (xmlDocument_0.FirstChild!.Name != "bar")
		{
			throw new InvalidOperationException("XML Format not recognized");
		}
		genericItemContainer_0.SubItems.Clear();
		method_80(xmlDocument_0.FirstChild as XmlElement);
		if (object_1 is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.AddShortcutsFromBar(this);
		}
		((IOwner)this).InvokeDefinitionLoaded((object)this, new EventArgs());
	}

	void IOwner.InvokeDefinitionLoaded(object sender, EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(sender, e);
		}
	}

	internal void method_78(XmlElement xmlElement_0)
	{
		method_79(xmlElement_0, bool_67: false);
	}

	internal void method_79(XmlElement xmlElement_0, bool bool_67)
	{
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected I4, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected I4, but got Unknown
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		xmlElement_0.SetAttribute("name", Name);
		xmlElement_0.SetAttribute("candockleft", XmlConvert.ToString(bool_6));
		xmlElement_0.SetAttribute("candockright", XmlConvert.ToString(bool_7));
		xmlElement_0.SetAttribute("candocktop", XmlConvert.ToString(bool_8));
		xmlElement_0.SetAttribute("candockbottom", XmlConvert.ToString(bool_9));
		xmlElement_0.SetAttribute("candockdoc", XmlConvert.ToString(bool_14));
		xmlElement_0.SetAttribute("candocktab", XmlConvert.ToString(bool_13));
		xmlElement_0.SetAttribute("text", ((Control)this).get_Text());
		xmlElement_0.SetAttribute("dockline", XmlConvert.ToString(int_29));
		if (DockSide != eDockSide.Top && DockSide != eDockSide.Bottom)
		{
			if (DockSide == eDockSide.Left || DockSide == eDockSide.Right)
			{
				xmlElement_0.SetAttribute("dockoffset", XmlConvert.ToString(((Control)this).get_Top()));
			}
		}
		else
		{
			xmlElement_0.SetAttribute("dockoffset", XmlConvert.ToString(((Control)this).get_Left()));
		}
		xmlElement_0.SetAttribute("grabhandle", XmlConvert.ToString((int)eGrabHandleStyle_0));
		xmlElement_0.SetAttribute("menubar", XmlConvert.ToString(bool_3));
		xmlElement_0.SetAttribute("stretch", XmlConvert.ToString(bool_4));
		xmlElement_0.SetAttribute("style", XmlConvert.ToString((int)genericItemContainer_0.Style));
		xmlElement_0.SetAttribute("wrapdock", XmlConvert.ToString(bool_1));
		xmlElement_0.SetAttribute("wrapfloat", XmlConvert.ToString(bool_2));
		if (bool_24)
		{
			xmlElement_0.SetAttribute("lockdockpos", XmlConvert.ToString(bool_24));
		}
		if (!bool_10)
		{
			xmlElement_0.SetAttribute("canundock", XmlConvert.ToString(bool_10));
		}
		if (bool_28)
		{
			xmlElement_0.SetAttribute("tabnav", XmlConvert.ToString(bool_28));
		}
		if (!bool_32)
		{
			xmlElement_0.SetAttribute("tooltips", XmlConvert.ToString(bool_32));
		}
		if (genericItemContainer_0.MoreItemsOnMenu)
		{
			xmlElement_0.SetAttribute("overflowmenu", XmlConvert.ToString(genericItemContainer_0.MoreItemsOnMenu));
		}
		if (bool_19)
		{
			xmlElement_0.SetAttribute("state", XmlConvert.ToString(2));
			eDockSide eDockSide2 = eDockSide.None;
			DockStyle dockSide = dockSiteInfo_1.DockSide;
			switch (dockSide - 1)
			{
			case 0:
				eDockSide2 = eDockSide.Top;
				break;
			case 1:
				eDockSide2 = eDockSide.Bottom;
				break;
			case 2:
				eDockSide2 = eDockSide.Left;
				break;
			case 3:
				eDockSide2 = eDockSide.Right;
				break;
			}
			xmlElement_0.SetAttribute("dockside", XmlConvert.ToString((int)eDockSide2));
		}
		else
		{
			xmlElement_0.SetAttribute("state", XmlConvert.ToString((int)eBarState_0));
			xmlElement_0.SetAttribute("dockside", XmlConvert.ToString((int)DockSide));
			if (DockSide == eDockSide.None && form0_0 != null)
			{
				xmlElement_0.SetAttribute("fpos", ((Form)form0_0).get_Location().X + "," + ((Form)form0_0).get_Location().Y + "," + ((Control)this).get_DisplayRectangle().Width + "," + ((Control)this).get_DisplayRectangle().Height);
			}
		}
		IOwnerBarSupport ownerBarSupport = object_1 as IOwnerBarSupport;
		if (eBarState_0 == eBarState.Floating && !Visible && ownerBarSupport != null && ownerBarSupport.WereVisible.Count > 0 && ownerBarSupport.WereVisible.Contains(this))
		{
			xmlElement_0.SetAttribute("visible", XmlConvert.ToString(value: true));
		}
		else if (bool_19)
		{
			xmlElement_0.SetAttribute("visible", XmlConvert.ToString(value: true));
			xmlElement_0.SetAttribute("autohide", XmlConvert.ToString(value: true));
		}
		else
		{
			xmlElement_0.SetAttribute("visible", XmlConvert.ToString(Visible));
		}
		xmlElement_0.SetAttribute("custom", XmlConvert.ToString(bool_18));
		xmlElement_0.SetAttribute("canhide", XmlConvert.ToString(bool_15));
		xmlElement_0.SetAttribute("imagesize", XmlConvert.ToString((int)eBarImageSize_0));
		xmlElement_0.SetAttribute("itemsp", XmlConvert.ToString(genericItemContainer_0.ItemSpacing));
		xmlElement_0.SetAttribute("themes", XmlConvert.ToString(bool_26));
		if (!genericItemContainer_0.CanCustomize)
		{
			xmlElement_0.SetAttribute("cancust", XmlConvert.ToString(genericItemContainer_0.CanCustomize));
		}
		if (((Control)this).get_Font() != null && bool_23)
		{
			xmlElement_0.SetAttribute("fontname", ((Control)this).get_Font().get_Name());
			xmlElement_0.SetAttribute("fontemsize", XmlConvert.ToString(((Control)this).get_Font().get_Size()));
			xmlElement_0.SetAttribute("fontstyle", XmlConvert.ToString((int)((Control)this).get_Font().get_Style()));
		}
		if (!genericItemContainer_0.m_BackgroundColor.IsEmpty)
		{
			xmlElement_0.SetAttribute("backcolor", Class109.smethod_50(genericItemContainer_0.BackColor));
		}
		xmlElement_0.SetAttribute("layout", XmlConvert.ToString((int)genericItemContainer_0.LayoutType));
		xmlElement_0.SetAttribute("eqbutton", XmlConvert.ToString(genericItemContainer_0.EqualButtonSize));
		if (eBorderType_0 != 0)
		{
			xmlElement_0.SetAttribute("dborder", XmlConvert.ToString((int)eBorderType_0));
		}
		if (!bool_17)
		{
			xmlElement_0.SetAttribute("acceptdrop", XmlConvert.ToString(bool_17));
		}
		if (color_0 != SystemColors.ControlDark)
		{
			xmlElement_0.SetAttribute("slcolor", Class109.smethod_50(color_0));
		}
		if (!color_1.IsEmpty)
		{
			xmlElement_0.SetAttribute("captionbc", Class109.smethod_50(color_1));
		}
		if (!color_2.IsEmpty)
		{
			xmlElement_0.SetAttribute("captionfc", Class109.smethod_50(color_2));
		}
		if (bool_36)
		{
			xmlElement_0.SetAttribute("showtab", XmlConvert.ToString(bool_36));
		}
		if (AutoHide)
		{
			if (genericItemContainer_0.Int32_2 != 0)
			{
				xmlElement_0.SetAttribute("dockwidth", XmlConvert.ToString(genericItemContainer_0.Int32_2));
			}
			else if (dockSiteInfo_1.DockedWidth != 0)
			{
				xmlElement_0.SetAttribute("dockwidth", XmlConvert.ToString(dockSiteInfo_1.DockedWidth));
			}
			if (genericItemContainer_0.Int32_1 != 0)
			{
				xmlElement_0.SetAttribute("dockheight", XmlConvert.ToString(genericItemContainer_0.Int32_1));
			}
			else if (dockSiteInfo_1.DockedHeight != 0)
			{
				xmlElement_0.SetAttribute("dockheight", XmlConvert.ToString(dockSiteInfo_1.DockedHeight));
			}
		}
		else
		{
			if (genericItemContainer_0.Int32_2 != 0 && Boolean_12)
			{
				xmlElement_0.SetAttribute("dockwidth", XmlConvert.ToString(genericItemContainer_0.Int32_2));
			}
			if (genericItemContainer_0.Int32_1 != 0 && Boolean_13)
			{
				xmlElement_0.SetAttribute("dockheight", XmlConvert.ToString(genericItemContainer_0.Int32_1));
			}
		}
		if (int_33 > 0)
		{
			xmlElement_0.SetAttribute("splitwidthpercent", XmlConvert.ToString(int_33));
		}
		if (int_34 > 0)
		{
			xmlElement_0.SetAttribute("splitheightpercent", XmlConvert.ToString(int_34));
		}
		if (genericItemContainer_0.PaddingBottom != 1)
		{
			xmlElement_0.SetAttribute("padbottom", XmlConvert.ToString(genericItemContainer_0.PaddingBottom));
		}
		if (genericItemContainer_0.PaddingLeft != 1)
		{
			xmlElement_0.SetAttribute("padleft", XmlConvert.ToString(genericItemContainer_0.PaddingLeft));
		}
		if (genericItemContainer_0.PaddingRight != 1)
		{
			xmlElement_0.SetAttribute("padright", XmlConvert.ToString(genericItemContainer_0.PaddingRight));
		}
		if (genericItemContainer_0.PaddingTop != 1)
		{
			xmlElement_0.SetAttribute("padtop", XmlConvert.ToString(genericItemContainer_0.PaddingTop));
		}
		if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && SelectedDockTab >= 0)
		{
			xmlElement_0.SetAttribute("seldocktab", XmlConvert.ToString(SelectedDockTab));
		}
		if (!bool_20)
		{
			xmlElement_0.SetAttribute("canautohide", XmlConvert.ToString(bool_20));
		}
		if (!bool_12)
		{
			xmlElement_0.SetAttribute("canreordertabs", XmlConvert.ToString(bool_12));
		}
		if (!bool_11)
		{
			xmlElement_0.SetAttribute("cantearoff", XmlConvert.ToString(bool_11));
		}
		if (!bool_27)
		{
			xmlElement_0.SetAttribute("hidein", XmlConvert.ToString(bool_27));
		}
		if (eTabStripAlignment_0 != eTabStripAlignment.Bottom)
		{
			xmlElement_0.SetAttribute("tabalign", XmlConvert.ToString((int)eTabStripAlignment_0));
		}
		if (int_35 != 100)
		{
			xmlElement_0.SetAttribute("ahanim", XmlConvert.ToString(int_35));
		}
		if (!bool_40)
		{
			xmlElement_0.SetAttribute("autocaptionmenu", XmlConvert.ToString(bool_40));
		}
		if (bool_41)
		{
			xmlElement_0.SetAttribute("autocaptionsync", XmlConvert.ToString(bool_41));
		}
		if (!bool_42)
		{
			xmlElement_0.SetAttribute("savelayout", XmlConvert.ToString(bool_42));
		}
		if (colorScheme_0.SchemeChanged)
		{
			XmlElement xmlElement = xmlElement_0.OwnerDocument.CreateElement("colorscheme");
			colorScheme_0.Serialize(xmlElement);
			xmlElement_0.AppendChild(xmlElement);
		}
		if (((Control)this).get_BackgroundImage() != null)
		{
			XmlElement xmlElement2 = xmlElement_0.OwnerDocument.CreateElement("backimage");
			xmlElement_0.AppendChild(xmlElement2);
			Class109.smethod_13(((Control)this).get_BackgroundImage(), xmlElement2);
			int num = (int)eBackgroundImagePosition_0;
			xmlElement2.SetAttribute("pos", num.ToString());
			xmlElement2.SetAttribute("alpha", byte_0.ToString());
		}
		if (bool_67)
		{
			return;
		}
		XmlElement xmlElement3 = xmlElement_0.OwnerDocument.CreateElement("items");
		xmlElement_0.AppendChild(xmlElement3);
		foreach (BaseItem subItem in genericItemContainer_0.SubItems)
		{
			if (subItem.ShouldSerialize)
			{
				XmlElement xmlElement4 = xmlElement_0.OwnerDocument.CreateElement("item");
				xmlElement3.AppendChild(xmlElement4);
				itemSerializationContext.ItemXmlElement = xmlElement4;
				subItem.Serialize(itemSerializationContext);
			}
		}
	}

	internal void method_80(XmlElement xmlElement_0)
	{
		ItemSerializationContext itemSerializationContext = new ItemSerializationContext();
		itemSerializationContext.Serializer = this;
		itemSerializationContext.HasDeserializeItemHandlers = ((ICustomSerialization)this).HasDeserializeItemHandlers;
		itemSerializationContext.HasSerializeItemHandlers = ((ICustomSerialization)this).HasSerializeItemHandlers;
		method_81(xmlElement_0, itemSerializationContext);
	}

	internal void method_81(XmlElement xmlElement_0, ItemSerializationContext itemSerializationContext_0)
	{
		bool_30 = true;
		bool_33 = true;
		try
		{
			method_82(xmlElement_0);
			((Control)this).set_BackgroundImage((Image)null);
			foreach (XmlElement childNode in xmlElement_0.ChildNodes)
			{
				switch (childNode.Name)
				{
				case "backimage":
					((Control)this).set_BackgroundImage(Class109.smethod_16(childNode));
					eBackgroundImagePosition_0 = (eBackgroundImagePosition)XmlConvert.ToInt32(childNode.GetAttribute("pos"));
					byte_0 = XmlConvert.ToByte(childNode.GetAttribute("alpha"));
					break;
				case "colorscheme":
					colorScheme_0.Deserialize(childNode);
					break;
				case "items":
					foreach (XmlElement childNode2 in childNode.ChildNodes)
					{
						BaseItem baseItem = itemSerializationContext_0.method_0(childNode2);
						genericItemContainer_0.SubItems.Add(baseItem);
						itemSerializationContext_0.ItemXmlElement = childNode2;
						baseItem.Deserialize(itemSerializationContext_0);
					}
					break;
				}
			}
			if (XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockside")) == 0)
			{
				if (xmlElement_0.HasAttribute("fpos"))
				{
					string attribute = xmlElement_0.GetAttribute("fpos");
					string[] array = attribute.Split(new char[1] { ',' });
					if (array.Length == 4)
					{
						Rectangle rectangle = (rectangle_3 = new Rectangle(XmlConvert.ToInt32(array[0]), XmlConvert.ToInt32(array[1]), XmlConvert.ToInt32(array[2]), XmlConvert.ToInt32(array[3])));
					}
				}
				if (!XmlConvert.ToBoolean(xmlElement_0.GetAttribute("visible")) || (xmlElement_0.HasAttribute("autohide") && XmlConvert.ToBoolean(xmlElement_0.GetAttribute("autohide"))))
				{
					bool_44 = true;
				}
			}
			if (xmlElement_0.HasAttribute("seldocktab"))
			{
				int num = XmlConvert.ToInt32(xmlElement_0.GetAttribute("seldocktab"));
				if (num >= 0 && num < genericItemContainer_0.SubItems.Count)
				{
					foreach (BaseItem subItem in genericItemContainer_0.SubItems)
					{
						subItem.Displayed = false;
					}
					genericItemContainer_0.SubItems[num].Displayed = true;
				}
			}
			int_29 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockline"));
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
			{
				method_120(bool_67: true);
			}
			DockSide = (eDockSide)XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockside"));
			if (bool_44)
			{
				bool_44 = false;
			}
			if (xmlElement_0.HasAttribute("autohide") && itemSerializationContext_0.idesignerHost_0 == null)
			{
				((Control)this).set_Visible(false);
				if (genericItemContainer_0.Int32_2 > 0)
				{
					((Control)this).set_Width(genericItemContainer_0.Int32_2);
				}
				if (genericItemContainer_0.Int32_1 > 0)
				{
					((Control)this).set_Height(genericItemContainer_0.Int32_1);
				}
				AutoHide = true;
				dockSiteInfo_1.DockedWidth = genericItemContainer_0.Int32_2;
				dockSiteInfo_1.DockedHeight = genericItemContainer_0.Int32_1;
			}
			else if (itemSerializationContext_0.idesignerHost_0 == null)
			{
				Visible = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("visible"));
			}
			else
			{
				Visible = true;
			}
		}
		finally
		{
			bool_30 = false;
		}
		bool_43 = false;
		method_1();
	}

	private void method_82(XmlElement xmlElement_0)
	{
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		eBarState_0 = eBarState.Docked;
		Name = xmlElement_0.GetAttribute("name");
		if (xmlElement_0.HasAttribute("candockleft"))
		{
			bool_6 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("candockleft"));
		}
		if (xmlElement_0.HasAttribute("candockright"))
		{
			bool_7 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("candockright"));
		}
		if (xmlElement_0.HasAttribute("candocktop"))
		{
			bool_8 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("candocktop"));
		}
		if (xmlElement_0.HasAttribute("candockbottom"))
		{
			bool_9 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("candockbottom"));
		}
		if (xmlElement_0.HasAttribute("candockdoc"))
		{
			bool_14 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("candockdoc"));
		}
		if (xmlElement_0.HasAttribute("candocktab"))
		{
			bool_13 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("candocktab"));
		}
		if (xmlElement_0.HasAttribute("text"))
		{
			((Control)this).set_Text(xmlElement_0.GetAttribute("text"));
		}
		if (xmlElement_0.HasAttribute("dockline"))
		{
			int_29 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockline"));
		}
		if (xmlElement_0.HasAttribute("dockoffset"))
		{
			int_28 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockoffset"));
		}
		if (xmlElement_0.HasAttribute("grabhandle"))
		{
			eGrabHandleStyle_0 = (eGrabHandleStyle)XmlConvert.ToInt32(xmlElement_0.GetAttribute("grabhandle"));
		}
		if (xmlElement_0.HasAttribute("menubar"))
		{
			bool_3 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("menubar"));
		}
		if (xmlElement_0.HasAttribute("stretch"))
		{
			bool_4 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("stretch"));
		}
		if (xmlElement_0.HasAttribute("wrapdock"))
		{
			bool_1 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("wrapdock"));
		}
		if (xmlElement_0.HasAttribute("wrapfloat"))
		{
			bool_2 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("wrapfloat"));
		}
		if (xmlElement_0.HasAttribute("custom"))
		{
			bool_18 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("custom"));
		}
		if (xmlElement_0.HasAttribute("canhide"))
		{
			bool_15 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("canhide"));
		}
		if (xmlElement_0.HasAttribute("imagesize"))
		{
			eBarImageSize_0 = (eBarImageSize)XmlConvert.ToInt32(xmlElement_0.GetAttribute("imagesize"));
		}
		if (xmlElement_0.HasAttribute("itemsp"))
		{
			genericItemContainer_0.ItemSpacing = XmlConvert.ToInt32(xmlElement_0.GetAttribute("itemsp"));
		}
		if (xmlElement_0.HasAttribute("backcolor"))
		{
			genericItemContainer_0.BackColor = Class109.smethod_51(xmlElement_0.GetAttribute("backcolor"));
		}
		if (xmlElement_0.HasAttribute("layout"))
		{
			genericItemContainer_0.LayoutType = (eLayoutType)XmlConvert.ToInt32(xmlElement_0.GetAttribute("layout"));
		}
		if (xmlElement_0.HasAttribute("eqbutton"))
		{
			genericItemContainer_0.EqualButtonSize = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("eqbutton"));
		}
		if (xmlElement_0.HasAttribute("dborder"))
		{
			eBorderType_0 = (eBorderType)XmlConvert.ToInt32(xmlElement_0.GetAttribute("dborder"));
		}
		if (xmlElement_0.HasAttribute("acceptdrop"))
		{
			bool_17 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("acceptdrop"));
		}
		if (xmlElement_0.HasAttribute("slcolor"))
		{
			color_0 = Class109.smethod_51(xmlElement_0.GetAttribute("slcolor"));
		}
		if (xmlElement_0.HasAttribute("captionbc"))
		{
			color_1 = Class109.smethod_51(xmlElement_0.GetAttribute("captionbc"));
		}
		if (xmlElement_0.HasAttribute("captionfc"))
		{
			color_2 = Class109.smethod_51(xmlElement_0.GetAttribute("captionfc"));
		}
		if (xmlElement_0.HasAttribute("dockwidth"))
		{
			genericItemContainer_0.Int32_2 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockwidth"));
		}
		if (xmlElement_0.HasAttribute("dockheight"))
		{
			genericItemContainer_0.Int32_1 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockheight"));
		}
		if (xmlElement_0.HasAttribute("splitwidthpercent"))
		{
			int_33 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("splitwidthpercent"));
		}
		else
		{
			int_33 = 0;
		}
		if (xmlElement_0.HasAttribute("splitheightpercent"))
		{
			int_34 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("splitheightpercent"));
		}
		if (xmlElement_0.HasAttribute("padbottom"))
		{
			genericItemContainer_0.PaddingBottom = XmlConvert.ToInt32(xmlElement_0.GetAttribute("padbottom"));
		}
		if (xmlElement_0.HasAttribute("padleft"))
		{
			genericItemContainer_0.PaddingLeft = XmlConvert.ToInt32(xmlElement_0.GetAttribute("padleft"));
		}
		if (xmlElement_0.HasAttribute("padright"))
		{
			genericItemContainer_0.PaddingRight = XmlConvert.ToInt32(xmlElement_0.GetAttribute("padright"));
		}
		if (xmlElement_0.HasAttribute("padtop"))
		{
			genericItemContainer_0.PaddingTop = XmlConvert.ToInt32(xmlElement_0.GetAttribute("padtop"));
		}
		if (xmlElement_0.HasAttribute("lockdockpos"))
		{
			bool_24 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("lockdockpos"));
		}
		if (xmlElement_0.HasAttribute("canundock"))
		{
			bool_10 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("canundock"));
		}
		if (xmlElement_0.HasAttribute("canreordertabs"))
		{
			bool_12 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("canreordertabs"));
		}
		if (xmlElement_0.HasAttribute("cantearoff"))
		{
			bool_11 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("cantearoff"));
		}
		if (xmlElement_0.HasAttribute("canautohide"))
		{
			bool_20 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("canautohide"));
		}
		if (xmlElement_0.HasAttribute("cancust"))
		{
			genericItemContainer_0.CanCustomize = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("cancust"));
		}
		if (xmlElement_0.HasAttribute("tabalign"))
		{
			eTabStripAlignment_0 = (eTabStripAlignment)XmlConvert.ToInt32(xmlElement_0.GetAttribute("tabalign"));
		}
		if (xmlElement_0.HasAttribute("showtab"))
		{
			bool_36 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("showtab"));
		}
		if (xmlElement_0.HasAttribute("hidein"))
		{
			bool_27 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("hidein"));
		}
		if (xmlElement_0.HasAttribute("themes"))
		{
			bool_26 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("themes"));
			genericItemContainer_0.ThemeAware = bool_26;
		}
		if (xmlElement_0.HasAttribute("tabnav"))
		{
			bool_28 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("tabnav"));
		}
		if (xmlElement_0.HasAttribute("tooltips"))
		{
			bool_32 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("tooltips"));
		}
		if (xmlElement_0.HasAttribute("overflowmenu"))
		{
			genericItemContainer_0.MoreItemsOnMenu = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("overflowmenu"));
		}
		if (xmlElement_0.HasAttribute("autocaptionmenu"))
		{
			bool_40 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("autocaptionmenu"));
		}
		if (xmlElement_0.HasAttribute("autocaptionsync"))
		{
			AutoSyncBarCaption = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("autocaptionsync"));
		}
		if (xmlElement_0.HasAttribute("style"))
		{
			string attribute = xmlElement_0.GetAttribute("style");
			if (attribute == "5")
			{
				Style = eDotNetBarStyle.Office2007;
			}
			else
			{
				Style = (eDotNetBarStyle)XmlConvert.ToInt32(attribute);
			}
		}
		if (xmlElement_0.HasAttribute("fontname"))
		{
			string attribute2 = xmlElement_0.GetAttribute("fontname");
			float num = XmlConvert.ToSingle(xmlElement_0.GetAttribute("fontemsize"));
			FontStyle val = (FontStyle)XmlConvert.ToInt32(xmlElement_0.GetAttribute("fontstyle"));
			try
			{
				((Control)this).set_Font(new Font(attribute2, num, val));
			}
			catch (Exception)
			{
				_003F val2 = this;
				object obj = SystemInformation.get_MenuFont().Clone();
				((Control)val2).set_Font((Font)((obj is Font) ? obj : null));
			}
			bool_23 = true;
		}
		if (xmlElement_0.HasAttribute("ahanim"))
		{
			int_35 = XmlConvert.ToInt32(xmlElement_0.GetAttribute("ahanim"));
		}
		if (xmlElement_0.HasAttribute("savelayout"))
		{
			bool_42 = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("savelayout"));
		}
	}

	public void SaveLayout(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		method_83(xmlDocument);
		xmlDocument.Save(FileName);
	}

	internal void method_83(XmlDocument xmlDocument_0)
	{
		XmlElement xmlElement = xmlDocument_0.CreateElement("bar");
		xmlDocument_0.AppendChild(xmlElement);
		method_85(xmlElement);
	}

	public void LoadLayout(string FileName)
	{
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.Load(FileName);
		method_84(xmlDocument);
	}

	internal void method_84(XmlDocument xmlDocument_0)
	{
		if (xmlDocument_0.FirstChild!.Name != "bar")
		{
			throw new InvalidOperationException("XML Format not recognized");
		}
		method_86(xmlDocument_0.FirstChild as XmlElement);
	}

	internal void method_85(XmlElement xmlElement_0)
	{
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected I4, but got Unknown
		if (CustomBar)
		{
			method_79(xmlElement_0, bool_67: true);
		}
		else
		{
			xmlElement_0.SetAttribute("name", Name);
			xmlElement_0.SetAttribute("dockline", XmlConvert.ToString(int_29));
			xmlElement_0.SetAttribute("layout", XmlConvert.ToString((int)LayoutType));
			if (int_28 == 0 && ((Control)this).get_Left() > 0 && (DockSide == eDockSide.Top || DockSide == eDockSide.Bottom))
			{
				xmlElement_0.SetAttribute("dockoffset", XmlConvert.ToString(((Control)this).get_Left()));
			}
			else if (int_28 == 0 && ((Control)this).get_Top() > 0 && (DockSide == eDockSide.Left || DockSide == eDockSide.Right))
			{
				xmlElement_0.SetAttribute("dockoffset", XmlConvert.ToString(((Control)this).get_Top()));
			}
			else
			{
				xmlElement_0.SetAttribute("dockoffset", XmlConvert.ToString(int_28));
			}
			if (bool_19)
			{
				xmlElement_0.SetAttribute("state", XmlConvert.ToString(2));
				eDockSide eDockSide2 = eDockSide.None;
				DockStyle dockSide = dockSiteInfo_1.DockSide;
				switch (dockSide - 1)
				{
				case 0:
					eDockSide2 = eDockSide.Top;
					break;
				case 1:
					eDockSide2 = eDockSide.Bottom;
					break;
				case 2:
					eDockSide2 = eDockSide.Left;
					break;
				case 3:
					eDockSide2 = eDockSide.Right;
					break;
				}
				xmlElement_0.SetAttribute("dockside", XmlConvert.ToString((int)eDockSide2));
			}
			else
			{
				xmlElement_0.SetAttribute("state", XmlConvert.ToString((int)eBarState_0));
				xmlElement_0.SetAttribute("dockside", XmlConvert.ToString((int)DockSide));
				if (DockSide == eDockSide.None && form0_0 != null)
				{
					xmlElement_0.SetAttribute("fpos", ((Form)form0_0).get_Location().X + "," + ((Form)form0_0).get_Location().Y + "," + ((Control)this).get_DisplayRectangle().Width + "," + ((Control)this).get_DisplayRectangle().Height);
				}
				else if (!rectangle_3.IsEmpty)
				{
					xmlElement_0.SetAttribute("fpos", rectangle_3.X + "," + rectangle_3.Y + "," + rectangle_3.Width + "," + rectangle_3.Height);
				}
			}
			IOwnerBarSupport ownerBarSupport = object_1 as IOwnerBarSupport;
			if (eBarState_0 == eBarState.Floating && !Visible && ownerBarSupport != null && ownerBarSupport.WereVisible.Count > 0 && ownerBarSupport.WereVisible.Contains(this))
			{
				xmlElement_0.SetAttribute("visible", XmlConvert.ToString(value: true));
			}
			else if (bool_19)
			{
				xmlElement_0.SetAttribute("visible", XmlConvert.ToString(value: true));
				xmlElement_0.SetAttribute("autohide", XmlConvert.ToString(value: true));
			}
			else
			{
				xmlElement_0.SetAttribute("visible", XmlConvert.ToString(Visible));
			}
			if (genericItemContainer_0.Int32_2 != 0)
			{
				xmlElement_0.SetAttribute("dockwidth", XmlConvert.ToString(genericItemContainer_0.Int32_2));
			}
			if (genericItemContainer_0.Int32_1 != 0)
			{
				xmlElement_0.SetAttribute("dockheight", XmlConvert.ToString(genericItemContainer_0.Int32_1));
			}
			if (int_33 > 0)
			{
				xmlElement_0.SetAttribute("splitwidthpercent", XmlConvert.ToString(int_33));
			}
			if (int_34 > 0)
			{
				xmlElement_0.SetAttribute("splitheightpercent", XmlConvert.ToString(int_34));
			}
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && SelectedDockTab >= 0)
			{
				xmlElement_0.SetAttribute("seldocktab", XmlConvert.ToString(SelectedDockTab));
			}
		}
		XmlElement xmlElement = xmlElement_0.OwnerDocument.CreateElement("items");
		foreach (BaseItem subItem in genericItemContainer_0.SubItems)
		{
			if (subItem.String_0 != "" || subItem.Int32_0 >= 0 || subItem.UserCustomized || CustomBar || bool_43 || LayoutType == eLayoutType.DockContainer)
			{
				XmlElement xmlElement2 = xmlElement_0.OwnerDocument.CreateElement("item");
				xmlElement2.SetAttribute("name", subItem.Name);
				xmlElement2.SetAttribute("origBar", subItem.String_0);
				xmlElement2.SetAttribute("origPos", XmlConvert.ToString(subItem.Int32_0));
				xmlElement2.SetAttribute("pos", XmlConvert.ToString(genericItemContainer_0.SubItems.IndexOf(subItem)));
				if (!subItem.Visible)
				{
					xmlElement2.SetAttribute("visible", XmlConvert.ToString(subItem.Visible));
				}
				xmlElement.AppendChild(xmlElement2);
			}
		}
		if (xmlElement.ChildNodes.Count > 0)
		{
			xmlElement_0.AppendChild(xmlElement);
		}
	}

	internal void method_86(XmlElement xmlElement_0)
	{
		bool_30 = true;
		try
		{
			bool_33 = true;
			method_82(xmlElement_0);
			if (xmlElement_0.ChildNodes.Count > 0 && xmlElement_0.ChildNodes[0]!.Name == "items")
			{
				method_87(xmlElement_0);
			}
			if (xmlElement_0.HasAttribute("fpos"))
			{
				string attribute = xmlElement_0.GetAttribute("fpos");
				string[] array = attribute.Split(new char[1] { ',' });
				if (array.Length == 4)
				{
					Rectangle rectangle = (rectangle_3 = new Rectangle(XmlConvert.ToInt32(array[0]), XmlConvert.ToInt32(array[1]), XmlConvert.ToInt32(array[2]), XmlConvert.ToInt32(array[3])));
				}
			}
			if (XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockside")) == 0 && !XmlConvert.ToBoolean(xmlElement_0.GetAttribute("visible")))
			{
				bool_44 = true;
			}
			if (xmlElement_0.HasAttribute("seldocktab"))
			{
				int num = XmlConvert.ToInt32(xmlElement_0.GetAttribute("seldocktab"));
				if (num >= 0 && num < genericItemContainer_0.SubItems.Count)
				{
					foreach (BaseItem subItem in genericItemContainer_0.SubItems)
					{
						subItem.Displayed = false;
					}
					genericItemContainer_0.SubItems[num].Displayed = true;
					if (bool_41)
					{
						((Control)this).set_Text(genericItemContainer_0.SubItems[num].Text);
					}
				}
			}
			if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer)
			{
				method_120(bool_67: true);
			}
			if (AutoHide)
			{
				if (xmlElement_0.HasAttribute("autohide"))
				{
					int int32_ = genericItemContainer_0.Int32_2;
					int int32_2 = genericItemContainer_0.Int32_1;
					genericItemContainer_0.Int32_2 = 0;
					genericItemContainer_0.Int32_1 = 0;
					AutoHide = false;
					genericItemContainer_0.Int32_2 = int32_;
					genericItemContainer_0.Int32_1 = int32_2;
				}
				else
				{
					AutoHide = false;
				}
			}
			DockSide = (eDockSide)XmlConvert.ToInt32(xmlElement_0.GetAttribute("dockside"));
			if (bool_44)
			{
				bool_44 = false;
			}
			if (xmlElement_0.HasAttribute("autohide"))
			{
				if (!AutoHide)
				{
					((Control)this).set_Visible(false);
					if (genericItemContainer_0.Int32_2 > 0)
					{
						((Control)this).set_Width(genericItemContainer_0.Int32_2);
					}
					if (genericItemContainer_0.Int32_1 > 0)
					{
						((Control)this).set_Height(genericItemContainer_0.Int32_1);
					}
					AutoHide = true;
					dockSiteInfo_1.DockedWidth = genericItemContainer_0.Int32_2;
					dockSiteInfo_1.DockedHeight = genericItemContainer_0.Int32_1;
				}
			}
			else
			{
				Visible = XmlConvert.ToBoolean(xmlElement_0.GetAttribute("visible"));
			}
		}
		finally
		{
			bool_30 = false;
		}
	}

	private void method_87(XmlElement xmlElement_0)
	{
		eLayoutType eLayoutType2 = eLayoutType.Toolbar;
		DotNetBarManager dotNetBarManager = null;
		if (object_1 != null && object_1 is DotNetBarManager)
		{
			dotNetBarManager = object_1 as DotNetBarManager;
		}
		if (xmlElement_0.HasAttribute("layout"))
		{
			eLayoutType2 = (eLayoutType)XmlConvert.ToInt32(xmlElement_0.GetAttribute("layout"));
		}
		if (eLayoutType2 == eLayoutType.DockContainer)
		{
			bool_43 = true;
		}
		if (xmlElement_0.HasAttribute("custom"))
		{
			XmlConvert.ToBoolean(xmlElement_0.GetAttribute("custom"));
		}
		foreach (XmlElement childNode in xmlElement_0.ChildNodes)
		{
			string name;
			if ((name = childNode.Name) == null || !(name == "items"))
			{
				continue;
			}
			for (int i = 0; i < childNode.ChildNodes.Count; i++)
			{
				XmlElement xmlElement2 = childNode.ChildNodes[i] as XmlElement;
				string attribute = xmlElement2.GetAttribute("name");
				string attribute2 = xmlElement2.GetAttribute("origBar");
				int int32_ = XmlConvert.ToInt32(xmlElement2.GetAttribute("origPos"));
				int num = XmlConvert.ToInt32(xmlElement2.GetAttribute("pos"));
				bool flag = true;
				if (xmlElement2.HasAttribute("visible"))
				{
					flag = XmlConvert.ToBoolean(xmlElement2.GetAttribute("visible"));
				}
				if (eLayoutType2 == eLayoutType.DockContainer)
				{
					if (Items.Contains(attribute))
					{
						BaseItem baseItem = Items[attribute];
						if (baseItem.Visible != flag)
						{
							baseItem.Visible = flag;
						}
						if (Items.IndexOf(Items[attribute]) != num)
						{
							Items.Remove(baseItem);
							if (Items.Count > num)
							{
								Items.Insert(num, baseItem);
							}
							else
							{
								Items.Add(baseItem);
							}
						}
					}
					else
					{
						if (dotNetBarManager == null)
						{
							continue;
						}
						BaseItem item = dotNetBarManager.GetItem(attribute);
						if (item == null || !(item is DockContainerItem))
						{
							continue;
						}
						Bar bar = item.ContainerControl as Bar;
						item.Parent.SubItems.Remove(item);
						if (item.Visible != flag)
						{
							item.Visible = flag;
						}
						if (Items.Count > num)
						{
							Items.Insert(num, item);
						}
						else
						{
							Items.Add(item);
						}
						if (bar != null && bar.Items.Count == 0)
						{
							if (bar.AutoHide)
							{
								bar.AutoHide = false;
							}
							bar.Visible = false;
						}
						else if (bar != null && bar.VisibleItemCount == 0)
						{
							bar.Visible = false;
						}
					}
					continue;
				}
				BaseItem baseItem2 = null;
				if (Items.Contains(attribute))
				{
					baseItem2 = Items[attribute];
					if (Items.IndexOf(attribute) != num)
					{
						Items.Remove(baseItem2);
						if (Items.Count > num)
						{
							Items.Insert(num, baseItem2);
						}
						else
						{
							Items.Add(baseItem2);
						}
					}
				}
				else
				{
					if (attribute2 != "" && dotNetBarManager != null && dotNetBarManager.Bars.Contains(attribute2) && dotNetBarManager.Bars[attribute2].Items.Contains(attribute))
					{
						baseItem2 = dotNetBarManager.Bars[attribute2].Items[attribute];
					}
					if (baseItem2 == null)
					{
						baseItem2 = dotNetBarManager.GetItem(attribute, FullSearch: true);
					}
					if (baseItem2 != null)
					{
						if (baseItem2.ContainerControl != null && (!(attribute2 == "") || baseItem2.ContainerControl is Bar))
						{
							baseItem2.Parent.SubItems.Remove(baseItem2);
						}
						else
						{
							baseItem2 = baseItem2.Copy();
						}
						if (Items.Count > num)
						{
							Items.Insert(num, baseItem2);
						}
						else
						{
							Items.Add(baseItem2);
						}
					}
				}
				if (baseItem2 != null)
				{
					if (baseItem2.Visible != flag)
					{
						baseItem2.Visible = flag;
					}
					baseItem2.String_0 = attribute2;
					baseItem2.Int32_0 = int32_;
					baseItem2.UserCustomized = true;
				}
			}
		}
	}

	[Obsolete("Method is obsolete. Use DocumentDockUIManager.SetBarWidth or DocumentDockUIManager.SetBarHeight instead. You can obtain DocumentDockUIManager using DockSite.GetDocumentUIManager method.")]
	public void SetSize(int width, int height)
	{
		if (eBarState_0 == eBarState.Docked)
		{
			genericItemContainer_0.Int32_1 = height;
			genericItemContainer_0.Int32_2 = width;
			method_55();
			method_56();
		}
		else
		{
			Size = new Size(width, height);
		}
		if (((Control)this).get_IsHandleCreated())
		{
			RecalcLayout();
		}
	}

	[Obsolete("Method is obsolete. Use DocumentDockUIManager.SetBarWidth or DocumentDockUIManager.SetBarHeight instead. You can obtain DocumentDockUIManager using DockSite.GetDocumentUIManager method.")]
	public void SetSize(Size size)
	{
		SetSize(size.Width, size.Height);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeBackgroundImageAlpha()
	{
		return byte_0 != byte.MaxValue;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeFont()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_Font() != null)
		{
			if (!(((Control)this).get_Font().get_Name() != SystemInformation.get_MenuFont().get_Name()) && ((Control)this).get_Font().get_Size() == SystemInformation.get_MenuFont().get_Size() && ((Control)this).get_Font().get_Style() == SystemInformation.get_MenuFont().get_Style())
			{
				return false;
			}
			return true;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetFont()
	{
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
	}

	internal void method_88(eBarState eBarState_1)
	{
		eBarState_0 = eBarState_1;
		if (eBarState_0 != 0 && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
	}

	internal ColorScheme GetColorScheme()
	{
		if (Style == eDotNetBarStyle.Office2007 && GetRenderer() is Office2007Renderer office2007Renderer && office2007Renderer.ColorTable.LegacyColors != null)
		{
			return office2007Renderer.ColorTable.LegacyColors;
		}
		if (object_1 is DotNetBarManager && ((DotNetBarManager)object_1).UseGlobalColorScheme)
		{
			return ((DotNetBarManager)object_1).ColorScheme;
		}
		return colorScheme_0;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeColorScheme()
	{
		return colorScheme_0.SchemeChanged;
	}

	public void ResetColorScheme()
	{
		colorScheme_0.Refresh();
		((Control)this).Invalidate();
	}

	internal void method_89(bool bool_67)
	{
		if (genericItemContainer_0 == null)
		{
			return;
		}
		try
		{
			if (genericItemContainer_0.SubItems.Contains("dotnetbarsysiconitem"))
			{
				genericItemContainer_0.SubItems.Remove("dotnetbarsysiconitem");
			}
			if (genericItemContainer_0.SubItems.Contains("dotnetbarsysmenuitem"))
			{
				genericItemContainer_0.SubItems.Remove("dotnetbarsysmenuitem");
			}
			if (bool_67)
			{
				RecalcLayout();
			}
		}
		catch (Exception)
		{
		}
	}

	internal void method_90(Form form_1, bool bool_67)
	{
		method_89(bool_67);
		if (form_1 != null)
		{
			MDISystemItem mDISystemItem = new MDISystemItem("dotnetbarsysiconitem");
			mDISystemItem.Icon = form_1.get_Icon();
			if (!form_1.get_ControlBox())
			{
				mDISystemItem.CloseEnabled = false;
			}
			if (!form_1.get_MinimizeBox())
			{
				mDISystemItem.MinimizeEnabled = false;
			}
			mDISystemItem.Click += method_91;
			mDISystemItem.IsSystemIcon = true;
			genericItemContainer_0.SubItems.Add(mDISystemItem, 0);
			mDISystemItem = new MDISystemItem("dotnetbarsysmenuitem");
			if (!form_1.get_ControlBox())
			{
				mDISystemItem.CloseEnabled = false;
			}
			if (!form_1.get_MinimizeBox())
			{
				mDISystemItem.MinimizeEnabled = false;
			}
			mDISystemItem.ItemAlignment = eItemAlignment.Far;
			mDISystemItem.Click += method_91;
			genericItemContainer_0.SubItems.Add(mDISystemItem);
			if (bool_67)
			{
				RecalcLayout();
			}
		}
	}

	private void method_91(object sender, EventArgs e)
	{
		MDISystemItem mDISystemItem = sender as MDISystemItem;
		IOwner owner = object_1 as IOwner;
		Form val = null;
		if (owner != null)
		{
			val = owner.ActiveMdiChild;
		}
		if (val == null)
		{
			method_89(bool_67: true);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_1)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61472, 0);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_2)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61728, 0);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_3)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61536, 0);
		}
		else if (mDISystemItem.Enum13_0 == Enum13.const_6)
		{
			Class92.PostMessage(((Control)val).get_Handle().ToInt32(), 274, 61504, 0);
		}
	}

	internal bool method_92(int int_40, int int_41)
	{
		Point pt = ((Control)this).PointToClient(new Point(int_40, int_41));
		if (!rectangle_2.Contains(pt) && (tabStrip_0 == null || !((Control)tabStrip_0).get_Bounds().Contains(pt)))
		{
			return false;
		}
		return true;
	}

	internal void method_93()
	{
		if (genericItemContainer_0 != null)
		{
			genericItemContainer_0.ContainerLostFocus(appLostFocus: true);
		}
		if (!((Control)this).get_IsDisposed())
		{
			((Control)this).AccessibilityNotifyClients((AccessibleEvents)32778, 0);
		}
	}

	internal void method_94()
	{
		if (!((Control)this).get_IsDisposed())
		{
			((Control)this).AccessibilityNotifyClients((AccessibleEvents)32778, 0);
		}
	}

	internal void method_95()
	{
		if (bool_56 && ((Control)this).get_Parent() != null)
		{
			((Control)this).get_Parent().get_Controls().Remove((Control)(object)this);
			bool_56 = false;
		}
		if (eBarState_0 == eBarState.Floating)
		{
			if (form0_0 != null)
			{
				((Control)form0_0).Hide();
				((Control)this).OnVisibleChanged(new EventArgs());
			}
			return;
		}
		((Control)this).Hide();
		if (!bool_5 && !bool_55 && ((Control)this).get_Parent() is DockSite && ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer != null)
		{
			((DockSite)(object)((Control)this).get_Parent()).GetDocumentUIManager().method_4(this, bool_2: true);
		}
		if (object_1 == null || !(object_1 is DotNetBarManager) || !((DotNetBarManager)object_1).IsDisposed)
		{
			RecalcLayout();
		}
	}

	private bool method_96()
	{
		ISite site = method_142();
		if (site == null)
		{
			return false;
		}
		if (!(site.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost))
		{
			return false;
		}
		IComponent rootComponent = designerHost.RootComponent;
		Control val = (Control)((rootComponent is Control) ? rootComponent : null);
		while (val != null)
		{
			val = val.get_Parent();
			if (val != null && ((object)val).GetType().Name.IndexOf("DesignerFrame") >= 0)
			{
				break;
			}
		}
		if (val != null && val.get_Parent() != null)
		{
			Point location = val.PointToClient(Location);
			val.get_Controls().Add((Control)(object)this);
			Location = location;
			((Control)this).Show();
			((Control)this).Update();
			((Control)this).BringToFront();
			bool_56 = true;
			return true;
		}
		return false;
	}

	internal void method_97()
	{
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Invalid comparison between Unknown and I4
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Invalid comparison between Unknown and I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Invalid comparison between Unknown and I4
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Invalid comparison between Unknown and I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Invalid comparison between Unknown and I4
		if (bool_25)
		{
			((Control)this).Show();
			((Control)this).Update();
			return;
		}
		if (eBarState_0 == eBarState.Floating)
		{
			if (form0_0 == null)
			{
				form0_0 = new Form0(this);
				((Control)form0_0).CreateControl();
				if (((Control)this).get_Parent() != null)
				{
					if (((Control)this).get_Parent() is DockSite)
					{
						((DockSite)(object)((Control)this).get_Parent()).method_21((Control)(object)this);
					}
					else
					{
						((Control)this).get_Parent().get_Controls().Remove((Control)(object)this);
					}
				}
				((Control)this).set_Parent((Control)null);
				((Control)form0_0).get_Controls().Add((Control)(object)this);
				((Control)this).set_Location(new Point(0, 0));
			}
			if (form0_0 != null)
			{
				((Form)form0_0).set_TopLevel(true);
				((Control)form0_0).set_Visible(true);
				if (!((Control)this).get_Visible())
				{
					((Control)this).set_Visible(true);
				}
				((Control)form0_0).Refresh();
			}
		}
		else if (eBarState_0 == eBarState.Popup)
		{
			if (baseItem_0 != null && ((baseItem_0.Site != null && baseItem_0.Site.DesignMode) || (baseItem_0.Parent != null && baseItem_0.Parent.Site != null && baseItem_0.Parent.Site.DesignMode)) && method_96())
			{
				return;
			}
			ePopupAnimation ePopupAnimation2 = ePopupAnimation_0;
			if (!Class109.Boolean_1)
			{
				ePopupAnimation2 = ePopupAnimation.None;
			}
			else
			{
				IOwnerMenuSupport ownerMenuSupport = object_1 as IOwnerMenuSupport;
				if (ePopupAnimation2 == ePopupAnimation.ManagerControlled)
				{
					if (ownerMenuSupport != null)
					{
						ePopupAnimation2 = ownerMenuSupport.PopupAnimation;
					}
					if (ePopupAnimation2 == ePopupAnimation.ManagerControlled)
					{
						ePopupAnimation2 = ePopupAnimation.SystemDefault;
					}
				}
				switch (ePopupAnimation2)
				{
				case ePopupAnimation.SystemDefault:
					ePopupAnimation2 = Class92.EPopupAnimation_0;
					break;
				case ePopupAnimation.Random:
				{
					Random random = new Random();
					int num = random.Next(2);
					ePopupAnimation2 = ePopupAnimation.Fade;
					switch (num)
					{
					case 1:
						ePopupAnimation2 = ePopupAnimation.Slide;
						break;
					case 2:
						ePopupAnimation2 = ePopupAnimation.Unfold;
						break;
					}
					break;
				}
				}
			}
			if (Class109.smethod_69(Style))
			{
				method_20((Control)(object)this);
			}
			if (ePopupAnimation2 == ePopupAnimation.Fade && Environment.OSVersion.Version.Major >= 5)
			{
				Class92.AnimateWindow(((Control)this).get_Handle().ToInt32(), 100, 524288);
			}
			else
			{
				switch (ePopupAnimation2)
				{
				case ePopupAnimation.Slide:
					Class92.AnimateWindow(((Control)this).get_Handle().ToInt32(), 100, 262149);
					break;
				case ePopupAnimation.Unfold:
					Class92.AnimateWindow(((Control)this).get_Handle().ToInt32(), 100, 5);
					break;
				default:
					((Control)this).Show();
					break;
				}
			}
			if (ePopupAnimation2 != 0 && ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0)
			{
				((Control)this).Refresh();
			}
			if (Boolean_9 && Boolean_10)
			{
				if (control8_0 != null)
				{
					((Control)control8_0).Hide();
					((Component)(object)control8_0).Dispose();
				}
				control8_0 = new Control8(bAlphaShadow: true);
				((Control)control8_0).CreateControl();
				Class92.SetWindowPos(((Control)control8_0).get_Handle(), -2, ((Control)this).get_Left() + 5, ((Control)this).get_Top() + 5, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2, 80);
				control8_0.method_1();
			}
		}
		else
		{
			if (((Control)this).get_Parent() is DockSite)
			{
				int_37 = ((Control)this).get_Parent().get_Controls().IndexOf((Control)(object)this);
			}
			else
			{
				int_37 = -1;
			}
			if (!bool_5 && !bool_55 && ((Control)this).get_Parent() is DockSite && (int)((Control)this).get_Parent().get_Dock() != 5 && ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer != null)
			{
				DockSite dockSite = ((Control)this).get_Parent() as DockSite;
				bool_55 = true;
				((Control)this).Show();
				bool_55 = false;
				dockSite.GetDocumentUIManager().method_4(this, bool_2: true);
				if (!bool_30)
				{
					DocumentBaseContainer documentFromBar = dockSite.GetDocumentUIManager().GetDocumentFromBar(this);
					if (documentFromBar != null && documentFromBar.Parent is DocumentDockContainer)
					{
						DocumentDockContainer documentDockContainer = documentFromBar.Parent as DocumentDockContainer;
						if (documentDockContainer.Documents.Count > 1)
						{
							if (documentDockContainer.Orientation == eOrientation.Horizontal && ((int)((Control)dockSite).get_Dock() == 1 || (int)((Control)dockSite).get_Dock() == 2))
							{
								float num2 = 1f + (float)documentFromBar.LayoutBounds.Width / (float)(documentDockContainer.DisplayBounds.Width - documentFromBar.LayoutBounds.Width);
								documentFromBar.method_1(new Rectangle(documentFromBar.LayoutBounds.X, documentFromBar.LayoutBounds.Y, (int)((float)documentFromBar.LayoutBounds.Width * num2), documentFromBar.LayoutBounds.Height));
							}
							else if (documentDockContainer.Orientation == eOrientation.Vertical && ((int)((Control)dockSite).get_Dock() == 3 || (int)((Control)dockSite).get_Dock() == 4))
							{
								float num3 = 1f + (float)documentFromBar.LayoutBounds.Height / (float)(documentDockContainer.DisplayBounds.Height - documentFromBar.LayoutBounds.Height);
								documentFromBar.method_1(new Rectangle(documentFromBar.LayoutBounds.X, documentFromBar.LayoutBounds.Y, documentFromBar.LayoutBounds.Width, (int)((float)documentFromBar.LayoutBounds.Height * num3)));
							}
						}
					}
				}
				if (Owner is DotNetBarManager dotNetBarManager && dotNetBarManager.SuspendLayout)
				{
					dockSite.NeedsLayout = true;
				}
			}
			else
			{
				((Control)this).Show();
			}
			int_37 = -1;
		}
		((Control)this).Update();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSingleLineColor()
	{
		return color_0 != SystemColors.ControlDark;
	}

	private BaseItem method_98()
	{
		foreach (BaseItem item in Items)
		{
			if (item.Visible)
			{
				return item;
			}
		}
		return null;
	}

	public void Show()
	{
		Visible = true;
	}

	public void Hide()
	{
		if (AutoHide)
		{
			AutoHide = false;
		}
		Visible = false;
		RecalcLayout();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override void ResetBackColor()
	{
		if (genericItemContainer_0 != null)
		{
			genericItemContainer_0.BackColor = Color.Empty;
		}
		else
		{
			((Control)this).set_BackColor(SystemColors.Control);
		}
	}

	public bool ShouldSerializeBackColor()
	{
		if (genericItemContainer_0 != null && !genericItemContainer_0.m_BackgroundColor.IsEmpty)
		{
			return true;
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSize()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if (LayoutType == eLayoutType.DockContainer && ((Control)this).get_Parent() is DockSite && (int)((Control)this).get_Parent().get_Dock() == 5)
		{
			return false;
		}
		return true;
	}

	public BaseItem GetItem(string name)
	{
		BaseItem baseItem = Class109.smethod_44(genericItemContainer_0, name);
		if (baseItem != null)
		{
			return baseItem;
		}
		if (component_0 != null)
		{
			if (component_0 is RibbonControl)
			{
				return ((RibbonControl)(object)component_0).RibbonStrip.GetItem(name);
			}
			if (component_0 is DotNetBarManager)
			{
				return ((DotNetBarManager)component_0).GetItem(name);
			}
		}
		return null;
	}

	public ArrayList GetItems(string ItemName)
	{
		ArrayList arrayList = new ArrayList(15);
		if (component_0 != null)
		{
			if (component_0 is RibbonControl)
			{
				arrayList.AddRange(((RibbonControl)(object)component_0).RibbonStrip.GetItems(ItemName));
			}
			else if (component_0 is DotNetBarManager)
			{
				arrayList.AddRange(((DotNetBarManager)component_0).GetItems(ItemName));
			}
		}
		else
		{
			Class109.smethod_46(genericItemContainer_0, ItemName, arrayList);
		}
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, Type itemType)
	{
		ArrayList arrayList = new ArrayList(15);
		if (component_0 != null)
		{
			if (component_0 is RibbonControl)
			{
				arrayList.AddRange(((RibbonControl)(object)component_0).RibbonStrip.GetItems(ItemName, itemType));
			}
			else if (component_0 is DotNetBarManager)
			{
				arrayList.AddRange(((DotNetBarManager)component_0).GetItems(ItemName, itemType));
			}
		}
		else
		{
			Class109.smethod_48(genericItemContainer_0, ItemName, arrayList, itemType);
		}
		return arrayList;
	}

	public ArrayList GetItems(string ItemName, Type itemType, bool useGlobalName)
	{
		ArrayList arrayList = new ArrayList(15);
		if (component_0 != null)
		{
			if (component_0 is RibbonControl)
			{
				arrayList.AddRange(((RibbonControl)(object)component_0).RibbonStrip.GetItems(ItemName, itemType, useGlobalName));
			}
			else if (component_0 is DotNetBarManager)
			{
				arrayList.AddRange(((DotNetBarManager)component_0).GetItems(ItemName, itemType, fullSearch: false, useGlobalName));
			}
		}
		else
		{
			Class109.smethod_49(genericItemContainer_0, ItemName, arrayList, itemType, useGlobalName);
		}
		return arrayList;
	}

	public AutoHidePanel GetAutoHidePanel()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (!AutoHide)
		{
			return null;
		}
		return method_99(dockSiteInfo_1.DockSide);
	}

	private AutoHidePanel method_99(DockStyle dockStyle_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected I4, but got Unknown
		if (!(object_1 is IOwnerAutoHideSupport ownerAutoHideSupport))
		{
			return null;
		}
		AutoHidePanel autoHidePanel = null;
		DockStyle dockSide = dockSiteInfo_1.DockSide;
		autoHidePanel = (dockSide - 1) switch
		{
			0 => ownerAutoHideSupport.TopAutoHidePanel, 
			2 => ownerAutoHideSupport.LeftAutoHidePanel, 
			3 => ownerAutoHideSupport.RightAutoHidePanel, 
			_ => ownerAutoHideSupport.BottomAutoHidePanel, 
		};
		if (AntiAlias)
		{
			autoHidePanel.AntiAlias = true;
		}
		return autoHidePanel;
	}

	private Size method_100()
	{
		Size empty = Size.Empty;
		foreach (BaseItem subItem in genericItemContainer_0.SubItems)
		{
			if (subItem is DockContainerItem)
			{
				DockContainerItem dockContainerItem = subItem as DockContainerItem;
				if (dockContainerItem.MinimumSize.Width > empty.Width)
				{
					empty.Width = dockContainerItem.MinimumSize.Width;
				}
				if (dockContainerItem.MinimumSize.Height > empty.Height)
				{
					empty.Height = dockContainerItem.MinimumSize.Height;
				}
			}
		}
		return empty;
	}

	private Control method_101()
	{
		Control result = null;
		IOwner owner = object_1 as IOwner;
		if (owner is DotNetBarManager && ((DotNetBarManager)owner).TopDockSite != null)
		{
			result = ((Control)((DotNetBarManager)owner).TopDockSite).get_Parent();
		}
		else if (owner != null)
		{
			result = (Control)(object)owner.ParentForm;
		}
		return result;
	}

	private void method_102()
	{
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Invalid comparison between Unknown and I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Invalid comparison between Unknown and I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Invalid comparison between Unknown and I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Invalid comparison between Unknown and I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Invalid comparison between Unknown and I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		if (!(object_1 is IOwner))
		{
			return;
		}
		Control val = method_101();
		if (val == null)
		{
			return;
		}
		if (bool_19)
		{
			if (eBarState_0 == eBarState.AutoHide)
			{
				return;
			}
			if (tabStrip_0 != null)
			{
				((Control)tabStrip_0).set_Visible(false);
			}
			dockSiteInfo_1 = default(DockSiteInfo);
			if (!bool_30)
			{
				if (((Control)this).get_Height() > 0)
				{
					dockSiteInfo_1.DockedHeight = ((Control)this).get_Height();
				}
				else if (genericItemContainer_0 != null && genericItemContainer_0.Int32_1 > 0)
				{
					dockSiteInfo_1.DockedHeight = genericItemContainer_0.Int32_1 + 22;
				}
				if (((Control)this).get_Width() > 0)
				{
					dockSiteInfo_1.DockedWidth = ((Control)this).get_Width();
				}
				else if (genericItemContainer_0 != null && genericItemContainer_0.Int32_2 > 0)
				{
					dockSiteInfo_1.DockedWidth = genericItemContainer_0.Int32_2 + 22;
				}
				Size size = method_100();
				if (size.Width > dockSiteInfo_1.DockedWidth)
				{
					dockSiteInfo_1.DockedWidth = 0;
				}
				if (size.Height > dockSiteInfo_1.DockedHeight)
				{
					dockSiteInfo_1.DockedHeight = 0;
				}
			}
			dockSiteInfo_1.DockLine = DockLine;
			dockSiteInfo_1.DockOffset = DockOffset;
			if (((Control)this).get_Parent() != null && eBarState_0 == eBarState.Docked)
			{
				dockSiteInfo_1.DockSide = ((Control)this).get_Parent().get_Dock();
			}
			else
			{
				dockSiteInfo_1.DockSide = (DockStyle)3;
			}
			if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is DockSite)
			{
				dockSiteInfo_1.InsertPosition = ((Control)(DockSite)(object)((Control)this).get_Parent()).get_Controls().GetChildIndex((Control)(object)this);
				dockSiteInfo_1.objDockSite = (DockSite)(object)DockedSite;
			}
			eBarState_0 = eBarState.AutoHide;
			method_106();
			val.SuspendLayout();
			try
			{
				((Control)this).set_Visible(false);
				if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is DockSite)
				{
					DockSite dockSite = ((Control)this).get_Parent() as DockSite;
					if (dockSite.DocumentDockContainer != null)
					{
						if ((int)((Control)dockSite).get_Dock() != 5 && dockSite.GetDocumentUIManager().GetDocumentFromBar(this) is DocumentBarContainer documentBarContainer && documentBarContainer.Parent is DocumentDockContainer)
						{
							DocumentDockContainer documentDockContainer = documentBarContainer.Parent as DocumentDockContainer;
							if ((documentDockContainer.Orientation == eOrientation.Horizontal && ((int)((Control)dockSite).get_Dock() == 1 || (int)((Control)dockSite).get_Dock() == 2)) || (documentDockContainer.Orientation == eOrientation.Vertical && ((int)((Control)dockSite).get_Dock() == 3 || (int)((Control)dockSite).get_Dock() == 4) && documentDockContainer.Documents.Count > 1))
							{
								for (int i = 0; i < documentDockContainer.Documents.Count; i++)
								{
									if (documentDockContainer.Documents[i] is DocumentBarContainer && documentDockContainer.Documents[i].Visible && documentDockContainer.Documents[i] != documentBarContainer)
									{
										dockSiteInfo_1.MouseOverBar = ((DocumentBarContainer)documentDockContainer.Documents[i]).Bar;
										if (i < documentDockContainer.Documents.IndexOf(documentBarContainer))
										{
											dockSiteInfo_1.MouseOverDockSide = ((documentDockContainer.Orientation == eOrientation.Horizontal) ? eDockSide.Left : eDockSide.Top);
										}
										else
										{
											dockSiteInfo_1.MouseOverDockSide = ((documentDockContainer.Orientation == eOrientation.Horizontal) ? eDockSide.Right : eDockSide.Bottom);
										}
										break;
									}
								}
							}
						}
						dockSite.GetDocumentUIManager().UnDock(this);
					}
					else
					{
						((DockSite)(object)((Control)this).get_Parent()).method_21((Control)(object)this);
					}
				}
				((Control)this).set_Parent((Control)null);
				val.get_Controls().Add((Control)(object)this);
				val.get_Controls().SetChildIndex((Control)(object)this, 0);
				AutoHidePanel autoHidePanel = method_99(dockSiteInfo_1.DockSide);
				autoHidePanel.AddBar(this);
				if (!bool_30)
				{
					method_103();
				}
				if (!bool_33 && int_35 != 0)
				{
					Visible = true;
				}
			}
			finally
			{
				val.ResumeLayout();
			}
			if (!bool_30)
			{
				((Control)this).Update();
				method_105();
			}
			return;
		}
		AutoHidePanel autoHidePanel2 = method_99(dockSiteInfo_1.DockSide);
		autoHidePanel2.RemoveBar(this);
		if (dockSiteInfo_1.objDockSite != null)
		{
			if (dockSiteInfo_1.MouseOverBar != null && (dockSiteInfo_1.objDockSite.GetDocumentUIManager() == null || dockSiteInfo_1.objDockSite.GetDocumentUIManager().GetDocumentFromBar(dockSiteInfo_1.MouseOverBar) == null))
			{
				dockSiteInfo_1.MouseOverBar = null;
				dockSiteInfo_1.MouseOverDockSide = eDockSide.None;
				dockSiteInfo_1.NewLine = true;
			}
		}
		else
		{
			dockSiteInfo_1.MouseOverBar = null;
			dockSiteInfo_1.MouseOverDockSide = eDockSide.None;
			dockSiteInfo_1.NewLine = true;
		}
		method_42(dockSiteInfo_1, Point.Empty);
		if (!Boolean_8)
		{
			Visible = true;
		}
		method_120(bool_67: true);
		method_129();
		genericItemContainer_0.Int32_1 = 0;
		genericItemContainer_0.Int32_2 = 0;
	}

	internal void method_103()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected I4, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Invalid comparison between Unknown and I4
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Invalid comparison between Unknown and I4
		IOwner owner = object_1 as IOwner;
		IOwnerBarSupport ownerBarSupport = object_1 as IOwnerBarSupport;
		IOwnerAutoHideSupport ownerAutoHideSupport = object_1 as IOwnerAutoHideSupport;
		Control val = method_101();
		if (owner == null || val == null || ownerBarSupport == null || ownerAutoHideSupport == null)
		{
			return;
		}
		int width = val.get_ClientSize().Width;
		int height = val.get_ClientSize().Height;
		int num = 0;
		int num2 = 0;
		DockStyle dockSide = dockSiteInfo_1.DockSide;
		switch (dockSide - 1)
		{
		case 0:
		{
			width = ((Control)ownerBarSupport.TopDockSite).get_Parent().get_Width();
			height = ((Control)ownerBarSupport.TopDockSite).get_Parent().get_Height();
			Point location4 = ((Control)ownerAutoHideSupport.TopAutoHidePanel).get_Location();
			num = location4.X;
			num2 = location4.Y + ((Control)ownerAutoHideSupport.TopAutoHidePanel).get_Height();
			break;
		}
		default:
		{
			width = ((Control)ownerBarSupport.BottomDockSite).get_Parent().get_Width();
			height = ((Control)ownerBarSupport.BottomDockSite).get_Parent().get_Height();
			Point location3 = ((Control)ownerAutoHideSupport.BottomAutoHidePanel).get_Location();
			num = location3.X;
			num2 = location3.Y;
			break;
		}
		case 2:
		{
			width = ((Control)ownerBarSupport.LeftDockSite).get_Parent().get_Width();
			height = ((Control)ownerBarSupport.LeftDockSite).get_Parent().get_Height();
			Point location2 = ((Control)ownerAutoHideSupport.LeftAutoHidePanel).get_Location();
			num = location2.X + ((Control)ownerAutoHideSupport.LeftAutoHidePanel).get_Width();
			num2 = location2.Y;
			break;
		}
		case 3:
		{
			width = ((Control)ownerBarSupport.RightDockSite).get_Parent().get_Width();
			height = ((Control)ownerBarSupport.RightDockSite).get_Parent().get_Height();
			Point location = ((Control)ownerAutoHideSupport.RightAutoHidePanel).get_Location();
			num = location.X;
			num2 = location.Y;
			break;
		}
		}
		DockStyle dockSide2 = dockSiteInfo_1.DockSide;
		switch (dockSide2 - 1)
		{
		case 0:
			width = ((Control)ownerAutoHideSupport.TopAutoHidePanel).get_Width();
			height = dockSiteInfo_1.DockedHeight;
			if (height == 0)
			{
				int num4 = -1;
				if (SelectedDockTab >= 0 && Items[SelectedDockTab] is DockContainerItem)
				{
					num4 = SelectedDockTab;
				}
				else if (Items.Count > 0 && Items[0] is DockContainerItem)
				{
					num4 = 0;
				}
				if (num4 >= 0)
				{
					height = Math.Max(((DockContainerItem)Items[num4]).MinimumSize.Height, ((DockContainerItem)Items[num4]).Height);
				}
				Boolean_0 = false;
				try
				{
					Size = new Size(width, height);
					RecalcSize();
				}
				finally
				{
					Boolean_0 = true;
				}
				height = ((Control)this).get_Height();
				dockSiteInfo_1.DockedHeight = height;
			}
			break;
		default:
			width = ((Control)ownerAutoHideSupport.BottomAutoHidePanel).get_Width();
			height = dockSiteInfo_1.DockedHeight;
			if (height == 0)
			{
				int num5 = -1;
				if (SelectedDockTab >= 0 && Items[SelectedDockTab] is DockContainerItem)
				{
					num5 = SelectedDockTab;
				}
				else if (Items.Count > 0 && Items[0] is DockContainerItem)
				{
					num5 = 0;
				}
				if (num5 >= 0)
				{
					height = Math.Max(((DockContainerItem)Items[num5]).MinimumSize.Height, ((DockContainerItem)Items[num5]).Height);
				}
				Boolean_0 = false;
				try
				{
					Size = new Size(width, height);
					RecalcSize();
				}
				finally
				{
					Boolean_0 = true;
				}
				height = ((Control)this).get_Height();
				dockSiteInfo_1.DockedHeight = height;
				if (tabStrip_0 != null)
				{
					dockSiteInfo_1.DockedHeight += ((Control)tabStrip_0).get_Height();
				}
			}
			num2 -= height;
			break;
		case 2:
			height = ((Control)ownerAutoHideSupport.LeftAutoHidePanel).get_Height();
			width = dockSiteInfo_1.DockedWidth;
			if (width == 0)
			{
				int num6 = -1;
				if (SelectedDockTab >= 0 && Items[SelectedDockTab] is DockContainerItem)
				{
					num6 = SelectedDockTab;
				}
				else if (Items.Count > 0 && Items[0] is DockContainerItem)
				{
					num6 = 0;
				}
				if (num6 >= 0)
				{
					width = Math.Max(((DockContainerItem)Items[num6]).MinimumSize.Width, ((DockContainerItem)Items[num6]).Width);
				}
				Boolean_0 = false;
				try
				{
					Size = new Size(width, height);
					RecalcSize();
				}
				finally
				{
					Boolean_0 = true;
				}
				width = ((Control)this).get_Width();
				dockSiteInfo_1.DockedWidth = width;
			}
			break;
		case 3:
			height = ((Control)ownerAutoHideSupport.RightAutoHidePanel).get_Height();
			width = dockSiteInfo_1.DockedWidth;
			if (width == 0)
			{
				int num3 = -1;
				if (SelectedDockTab >= 0 && Items[SelectedDockTab] is DockContainerItem)
				{
					num3 = SelectedDockTab;
				}
				else if (Items.Count > 0 && Items[0] is DockContainerItem)
				{
					num3 = 0;
				}
				if (num3 >= 0)
				{
					width = Math.Max(((DockContainerItem)Items[num3]).MinimumSize.Width, ((DockContainerItem)Items[num3]).Width);
				}
				Boolean_0 = false;
				try
				{
					Size = new Size(width, height);
					RecalcSize();
				}
				finally
				{
					Boolean_0 = true;
				}
				width = ((Control)this).get_Width();
				dockSiteInfo_1.DockedWidth = width;
			}
			num -= width;
			break;
		}
		Rectangle rectangle = new Rectangle(num, num2, width, height);
		AutoHideDisplayEventArgs autoHideDisplayEventArgs = new AutoHideDisplayEventArgs(rectangle);
		if (autoHideDisplayEventHandler_0 != null)
		{
			autoHideDisplayEventHandler_0(this, autoHideDisplayEventArgs);
			rectangle = autoHideDisplayEventArgs.DisplayRectangle;
		}
		if (ownerBarSupport != null)
		{
			ownerBarSupport.InvokeAutoHideDisplay(this, autoHideDisplayEventArgs);
			rectangle = autoHideDisplayEventArgs.DisplayRectangle;
		}
		((Control)this).set_Bounds(rectangle);
		RecalcSize();
		if ((int)dockSiteInfo_1.DockSide == 2)
		{
			if (((Control)this).get_Height() != height)
			{
				((Control)this).set_Top(((Control)this).get_Top() + (height - ((Control)this).get_Height()));
			}
		}
		else if ((int)dockSiteInfo_1.DockSide == 4 && ((Control)this).get_Width() != width)
		{
			((Control)this).set_Left(((Control)this).get_Left() + (width - ((Control)this).get_Width()));
		}
	}

	internal void method_104()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected I4, but got Unknown
		if (Visible)
		{
			return;
		}
		method_103();
		Rectangle rectangle = new Rectangle(Location, Size);
		Rectangle rectangle2 = rectangle;
		((Control)this).get_Parent().get_Controls().SetChildIndex((Control)(object)this, 0);
		if (!bool_33 && int_35 > 0)
		{
			DockStyle dockSide = dockSiteInfo_1.DockSide;
			switch (dockSide - 1)
			{
			case 0:
				rectangle2.Height = 1;
				break;
			default:
				rectangle2.Y = rectangle2.Bottom - 1;
				rectangle2.Height = 1;
				break;
			case 2:
				rectangle2.Width = 1;
				break;
			case 3:
				rectangle2.X = rectangle2.Right - 1;
				rectangle2.Width = 1;
				break;
			}
		}
		try
		{
			bool_34 = true;
			Class109.smethod_66((Control)(object)this, bool_3: true, int_35, rectangle2, rectangle);
		}
		finally
		{
			bool_34 = false;
		}
		bool_33 = false;
	}

	internal void method_105()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected I4, but got Unknown
		if (!Visible)
		{
			return;
		}
		((Control)this).get_Parent().get_Controls().SetChildIndex((Control)(object)this, 0);
		Rectangle rectangle = new Rectangle(Location, Size);
		Rectangle rectangle2 = rectangle;
		if (!bool_33 && int_35 > 0)
		{
			DockStyle dockSide = dockSiteInfo_1.DockSide;
			switch (dockSide - 1)
			{
			case 0:
				rectangle2.Height = 1;
				break;
			default:
				rectangle2.Y = rectangle2.Bottom - 1;
				rectangle2.Height = 1;
				break;
			case 2:
				rectangle2.Width = 1;
				break;
			case 3:
				rectangle2.X = rectangle2.Right - 1;
				rectangle2.Width = 1;
				break;
			}
			try
			{
				bool_34 = true;
				Class109.smethod_66((Control)(object)this, bool_3: false, int_35, rectangle, rectangle2);
				return;
			}
			finally
			{
				bool_34 = false;
			}
		}
		Visible = false;
	}

	private void method_106()
	{
		IOwner owner = object_1 as IOwner;
		if (owner.ParentForm != null && ((ContainerControl)owner.ParentForm).get_ActiveControl() == this)
		{
			((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
			((Control)this).Focus();
		}
		else if (owner.ParentForm != null && method_37((Control)(object)this, ((ContainerControl)owner.ParentForm).get_ActiveControl()))
		{
			((ContainerControl)owner.ParentForm).set_ActiveControl((Control)null);
			((Control)this).Focus();
		}
	}

	private void method_107(object sender, EventArgs e)
	{
		if (!class179_0.Boolean_6)
		{
			method_111();
		}
		else
		{
			method_71();
		}
	}

	private void method_108(object sender, EventArgs e)
	{
		if (!class179_0.Boolean_2)
		{
			method_111();
		}
		else
		{
			method_71();
		}
	}

	private void method_109(object sender, EventArgs e)
	{
		if (!class179_0.Boolean_0)
		{
			method_111();
		}
		else
		{
			method_71();
		}
	}

	private void method_110(object sender, EventArgs e)
	{
		method_111();
	}

	private void method_111()
	{
		if (m_ToolTipWnd != null)
		{
			((Control)m_ToolTipWnd).Hide();
			((Component)(object)m_ToolTipWnd).Dispose();
			m_ToolTipWnd = null;
			method_71();
		}
	}

	internal void method_112()
	{
		method_111();
		if (genericItemContainer_0 == null)
		{
			return;
		}
		foreach (BaseItem subItem in genericItemContainer_0.SubItems)
		{
			method_113(subItem);
		}
	}

	private void method_113(BaseItem baseItem_5)
	{
		baseItem_5.HideToolTip();
		foreach (BaseItem subItem in baseItem_5.SubItems)
		{
			method_113(subItem);
		}
	}

	private void method_114(string string_0)
	{
		if (!((Component)this).DesignMode && bool_32 && string_0 != null && !(string_0 == "") && Visible)
		{
			if (m_ToolTipWnd == null)
			{
				m_ToolTipWnd = new ToolTip();
			}
			m_ToolTipWnd.Text = string_0;
			if (Owner is IOwnerItemEvents ownerItemEvents)
			{
				ownerItemEvents.InvokeToolTipShowing(m_ToolTipWnd, new EventArgs());
			}
			m_ToolTipWnd.ShowToolTip();
		}
	}

	private void method_115()
	{
		if (tabStrip_0 != null && Class109.smethod_11((Control)(object)this))
		{
			if (tabStrip_0.CanReorderTabs != bool_12)
			{
				tabStrip_0.CanReorderTabs = bool_12;
			}
			if (tabStrip_0.TabAlignment != eTabStripAlignment_0)
			{
				tabStrip_0.TabAlignment = eTabStripAlignment_0;
			}
			if (bool_28)
			{
				tabStrip_0.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
			}
			else
			{
				tabStrip_0.TabLayoutType = eTabLayoutType.FitContainer;
			}
			tabStrip_0.ShowFocusRectangle = false;
			if (tabStrip_0.Class26_0 != null)
			{
				tabStrip_0.Class26_0.Boolean_0 = CanHide;
			}
			if (bool_19)
			{
				((Control)tabStrip_0).set_Visible(false);
			}
		}
	}

	internal void method_116()
	{
		if (tabStrip_0 == null && Class109.smethod_11((Control)(object)this))
		{
			tabStrip_0 = new TabStrip();
			method_115();
			SuspendLayout();
			method_129();
			tabStrip_0.SelectedTabChanging += tabStrip_0_SelectedTabChanging;
			tabStrip_0.BeforeTabDisplay += tabStrip_0_BeforeTabDisplay;
			tabStrip_0.TabMoved += tabStrip_0_TabMoved;
			tabStrip_0.TabItemClose += tabStrip_0_TabItemClose;
			tabStrip_0.CloseButtonOnTabsVisible = bool_50;
			((Control)this).get_Controls().Add((Control)(object)tabStrip_0);
			method_117(Style);
			((Control)tabStrip_0).set_Visible(method_127());
			method_128();
			((Control)this).Invalidate();
			ResumeLayout();
		}
	}

	private void tabStrip_0_TabItemClose(object sender, TabStripActionEventArgs e)
	{
		if (sender is TabItem tabItem && tabItem.AttachedItem is DockContainerItem dockTab)
		{
			CloseDockTab(dockTab, eEventSource.Mouse);
		}
	}

	internal void method_117(eDotNetBarStyle eDotNetBarStyle_0)
	{
		if (tabStrip_0 == null)
		{
			return;
		}
		if (Style == eDotNetBarStyle.Office2003)
		{
			IOwnerBarSupport ownerBarSupport = object_1 as IOwnerBarSupport;
			if (DockSide == eDockSide.Document && ownerBarSupport != null && ownerBarSupport.ApplyDocumentBarStyle)
			{
				tabStrip_0.Style = eTabStripStyle.OneNote;
			}
			else
			{
				tabStrip_0.Style = eTabStripStyle.Office2003;
			}
		}
		else if (Style == eDotNetBarStyle.VS2005)
		{
			IOwnerBarSupport ownerBarSupport2 = object_1 as IOwnerBarSupport;
			if (DockSide == eDockSide.Document && ownerBarSupport2 != null && ownerBarSupport2.ApplyDocumentBarStyle)
			{
				tabStrip_0.Style = eTabStripStyle.VS2005Document;
			}
			else
			{
				tabStrip_0.Style = eTabStripStyle.VS2005;
			}
		}
		else if (Class109.smethod_69(Style))
		{
			IOwnerBarSupport ownerBarSupport3 = object_1 as IOwnerBarSupport;
			if (DockSide == eDockSide.Document && ownerBarSupport3 != null && ownerBarSupport3.ApplyDocumentBarStyle)
			{
				tabStrip_0.Style = eTabStripStyle.Office2007Document;
			}
			else
			{
				tabStrip_0.Style = eTabStripStyle.Office2007Dock;
			}
		}
		else
		{
			tabStrip_0.Style = eTabStripStyle.Flat;
		}
		tabStrip_0.ColorScheme.TabBorder = Color.Empty;
		if (eventHandler_12 != null)
		{
			eventHandler_12(this, new EventArgs());
		}
	}

	private void tabStrip_0_BeforeTabDisplay(object sender, EventArgs e)
	{
		if (sender is TabItem)
		{
			method_133(((TabItem)sender).AttachedItem);
		}
	}

	private void method_118()
	{
		if (tabStrip_0 != null)
		{
			if (tabStrip_0.Boolean_11)
			{
				((Control)tabStrip_0).set_Visible(false);
				tabStrip_0.Tabs.Clear();
			}
			else
			{
				((Control)this).get_Controls().Remove((Control)(object)tabStrip_0);
				((Component)(object)tabStrip_0).Dispose();
				tabStrip_0 = null;
			}
		}
	}

	internal void method_119()
	{
		if (tabStrip_0 != null)
		{
			((Control)tabStrip_0).Refresh();
		}
	}

	internal void method_120(bool bool_67)
	{
		if (genericItemContainer_0 == null || !Class109.smethod_11((Control)(object)this))
		{
			return;
		}
		method_131();
		int visibleSubItems = genericItemContainer_0.VisibleSubItems;
		if (visibleSubItems <= 1 && (!bool_36 || eBarState_0 == eBarState.Floating))
		{
			if (visibleSubItems == 1 && tabStrip_0 != null)
			{
				DockContainerItem dockContainerItem = null;
				foreach (BaseItem subItem in genericItemContainer_0.SubItems)
				{
					if (subItem.Visible && subItem is DockContainerItem)
					{
						dockContainerItem = subItem as DockContainerItem;
						break;
					}
				}
				if (dockContainerItem != null && bool_67)
				{
					method_132(null, dockContainerItem);
				}
			}
			method_118();
		}
		else if (tabStrip_0 == null)
		{
			method_116();
		}
		else
		{
			if (!((Control)tabStrip_0).get_Visible())
			{
				((Control)tabStrip_0).set_Visible(method_127());
			}
			BaseItem baseItem2 = null;
			if (bool_67 && tabStrip_0 != null && tabStrip_0.SelectedTab != null)
			{
				baseItem2 = tabStrip_0.SelectedTab.AttachedItem;
			}
			method_128();
			if (bool_67 && tabStrip_0 != null && tabStrip_0.SelectedTab != null && baseItem2 != tabStrip_0.SelectedTab.AttachedItem)
			{
				method_132(baseItem2, tabStrip_0.SelectedTab.AttachedItem);
			}
		}
	}

	internal void method_121()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (!AutoHide)
		{
			return;
		}
		AutoHidePanel autoHidePanel = method_99(dockSiteInfo_1.DockSide);
		if (autoHidePanel != null)
		{
			autoHidePanel.RefreshBar(this);
			if (autoHidePanel.DockContainerItem_0 != null)
			{
				method_132(null, autoHidePanel.DockContainerItem_0);
			}
		}
	}

	internal void method_122(DockContainerItem dockContainerItem_0)
	{
		if (!AutoHide || dockContainerItem_0.Visible)
		{
			return;
		}
		bool flag = true;
		foreach (BaseItem item in Items)
		{
			if (item.Visible && flag)
			{
				item.Displayed = true;
				flag = false;
			}
			else
			{
				item.Displayed = false;
			}
		}
	}

	public void ReDock()
	{
		if (eBarState_0 == eBarState.Floating && (CanDockBottom || CanDockTop || CanDockLeft || CanDockRight))
		{
			method_42(dockSiteInfo_1, Point.Empty);
		}
	}

	internal void method_123(BaseItem baseItem_5)
	{
		if (baseItem_5 is DockContainerItem && LayoutType == eLayoutType.DockContainer)
		{
			if (baseItem_5.Displayed)
			{
				bool flag = false;
				foreach (BaseItem item in Items)
				{
					if (item.Displayed)
					{
						flag = true;
					}
				}
				if (!flag && Items.Count > 0)
				{
					Items[0].Displayed = true;
				}
			}
			method_120(bool_67: true);
			if (AutoHide)
			{
				GetAutoHidePanel()?.RefreshBar(this);
			}
		}
		method_131();
	}

	protected void InvokeCaptionButtonClick()
	{
		if (eventHandler_11 != null)
		{
			eventHandler_11(this, new EventArgs());
		}
	}

	private void method_124()
	{
		if (popupItem_1 != null)
		{
			bool expanded;
			if (expanded = popupItem_1.Expanded)
			{
				popupItem_1.ClosePopup();
			}
			popupItem_1.Dispose();
			popupItem_1 = null;
			if (expanded)
			{
				return;
			}
		}
		if (Items.Count <= 0)
		{
			return;
		}
		popupItem_1 = new ButtonItem("sysCaptionButtonMenuParent");
		popupItem_1.Style = Style;
		popupItem_1.PopupShowing += popupItem_1_PopupShowing;
		popupItem_1.PopupFinalized += popupItem_1_PopupFinalized;
		foreach (BaseItem item in Items)
		{
			ButtonItem buttonItem = new ButtonItem("sysCaption_" + item.Name);
			buttonItem.Tag = item;
			buttonItem.OptionGroup = "sysCaptionMenu";
			buttonItem.Text = item.Text;
			buttonItem.BeginGroup = item.BeginGroup;
			if (item is DockContainerItem)
			{
				DockContainerItem dockContainerItem = item as DockContainerItem;
				buttonItem.Checked = item.Displayed;
				if (dockContainerItem.Image != null)
				{
					object obj = dockContainerItem.Image.Clone();
					buttonItem.Image = (Image)((obj is Image) ? obj : null);
				}
				else if (dockContainerItem.Icon != null)
				{
					object obj2 = dockContainerItem.Icon.Clone();
					buttonItem.Icon = (Icon)((obj2 is Icon) ? obj2 : null);
				}
				else if (dockContainerItem.ImageIndex >= 0 && dockContainerItem.ImageList != null)
				{
					object obj3 = dockContainerItem.ImageList.get_Images().get_Item(dockContainerItem.ImageIndex).Clone();
					buttonItem.Image = (Image)((obj3 is Image) ? obj3 : null);
				}
			}
			else
			{
				buttonItem.Checked = item.Visible;
			}
			buttonItem.Click += method_125;
			popupItem_1.SubItems.Add(buttonItem);
		}
		if (popupItem_1.GetOwner() == null)
		{
			popupItem_1.method_6(object_1);
		}
		Size popupSize = popupItem_1.PopupSize;
		Point point = new Point(class179_0.rectangle_3.Right - popupSize.Width, class179_0.rectangle_3.Bottom);
		if (point.X < 0)
		{
			point.X = 0;
		}
		point = ((Control)this).PointToScreen(point);
		popupItem_1.Popup(point);
	}

	private void method_125(object sender, EventArgs e)
	{
		if (!(sender is ButtonItem buttonItem))
		{
			return;
		}
		if (LayoutType == eLayoutType.DockContainer)
		{
			SelectedDockTab = Items.IndexOf(buttonItem.Tag as BaseItem);
			return;
		}
		foreach (BaseItem item in Items)
		{
			if (item == buttonItem.Tag)
			{
				item.Visible = true;
			}
			else
			{
				item.Visible = false;
			}
		}
		RecalcLayout();
		popupItem_1.Dispose();
		popupItem_1 = null;
	}

	private void popupItem_1_PopupShowing(object sender, EventArgs e)
	{
		if (popupItem_1 != null)
		{
			((MenuPanel)(object)popupItem_1.PopupControl).ColorScheme = GetColorScheme();
		}
	}

	private void popupItem_1_PopupFinalized(object sender, EventArgs e)
	{
		method_12();
	}

	internal void method_126(DockContainerItem dockContainerItem_0)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (genericItemContainer_0 != null && tabStrip_0 != null)
		{
			foreach (TabItem tab in tabStrip_0.Tabs)
			{
				if (tab.AttachedItem == dockContainerItem_0)
				{
					tab.Text = dockContainerItem_0.Text;
					tab.AttachedItem = dockContainerItem_0;
					tab.Tooltip = dockContainerItem_0.Tooltip;
					tab.Name = dockContainerItem_0.Name;
					if (dockContainerItem_0.Icon != null)
					{
						object obj = dockContainerItem_0.Icon.Clone();
						tab.Icon = (Icon)((obj is Icon) ? obj : null);
					}
					else
					{
						tab.Image = dockContainerItem_0.Image_0;
						tab.Icon = null;
					}
					break;
				}
			}
			((Control)tabStrip_0).Refresh();
			if (AutoHide)
			{
				AutoHidePanel autoHidePanel = method_99(dockSiteInfo_1.DockSide);
				if (autoHidePanel != null)
				{
					((Control)autoHidePanel).Refresh();
				}
			}
			method_131();
		}
		else
		{
			method_131();
		}
	}

	private bool method_127()
	{
		if (eGrabHandleStyle_0 == eGrabHandleStyle.CaptionTaskPane && bool_40)
		{
			return false;
		}
		return true;
	}

	private void method_128()
	{
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		if (bool_58)
		{
			return;
		}
		if (!((Control)tabStrip_0).get_Visible() && eBarState_0 != eBarState.AutoHide)
		{
			((Control)tabStrip_0).set_Visible(method_127());
			if (IsThemed && eBarState_0 == eBarState.Floating)
			{
				((Control)tabStrip_0).set_Size(new Size(((Control)this).get_Width() - (struct11_0.int_0 + struct11_0.int_2), 25));
				((Control)tabStrip_0).set_Location(new Point(struct11_0.int_0, ((Control)this).get_Height() - 25 - struct11_0.int_3));
			}
			else
			{
				((Control)tabStrip_0).set_Size(new Size(((Control)this).get_Width() - 4, 25));
				((Control)tabStrip_0).set_Location(new Point(2, ((Control)this).get_Height() - 25 - 2));
			}
		}
		bool_58 = true;
		try
		{
			tabStrip_0.Tabs.Clear();
			int num = 0;
			foreach (BaseItem subItem in genericItemContainer_0.SubItems)
			{
				if (!subItem.Visible)
				{
					continue;
				}
				num++;
				TabItem tabItem = new TabItem();
				tabItem.Text = subItem.Text;
				tabItem.Tooltip = subItem.Tooltip;
				tabItem.Name = subItem.Name;
				if (subItem is DockContainerItem)
				{
					DockContainerItem dockContainerItem = subItem as DockContainerItem;
					if (dockContainerItem.Icon != null)
					{
						object obj = dockContainerItem.Icon.Clone();
						tabItem.Icon = (Icon)((obj is Icon) ? obj : null);
					}
					else
					{
						tabItem.Image = dockContainerItem.Image_0;
					}
					tabItem.PredefinedColor = dockContainerItem.PredefinedTabColor;
				}
				tabStrip_0.Tabs.Add(tabItem);
				tabItem.AttachedItem = subItem;
				if (subItem.Displayed)
				{
					tabStrip_0.bool_23 = true;
					tabStrip_0.SelectedTab = tabItem;
					tabStrip_0.bool_23 = false;
				}
			}
			if (num <= 1 && (num != 1 || !bool_36 || eBarState_0 == eBarState.Floating))
			{
				if (((Control)tabStrip_0).get_Visible())
				{
					((Control)tabStrip_0).set_Visible(false);
				}
			}
			else
			{
				if (!((Control)tabStrip_0).get_Visible() && eBarState_0 != eBarState.AutoHide)
				{
					((Control)tabStrip_0).set_Visible(method_127());
				}
				if (tabStrip_0.SelectedTab == null)
				{
					tabStrip_0.SelectedTab = tabStrip_0.Tabs[0];
				}
				else if (tabStrip_0.SelectedTab.AttachedItem != null && !tabStrip_0.SelectedTab.AttachedItem.Displayed)
				{
					tabStrip_0.SelectedTab.AttachedItem.Displayed = true;
				}
				((Control)tabStrip_0).Refresh();
			}
		}
		finally
		{
			bool_58 = false;
		}
		if (eBarState_0 == eBarState.AutoHide)
		{
			method_99(dockSiteInfo_1.DockSide)?.RefreshBar(this);
		}
	}

	private void method_129()
	{
		if (tabStrip_0 == null || !((Control)tabStrip_0).get_Visible())
		{
			return;
		}
		Point point = Point.Empty;
		Size size = Size.Empty;
		switch (eTabStripAlignment_0)
		{
		default:
			point = new Point(0, ((Control)this).get_Height() - 25);
			size = new Size(((Control)this).get_Width(), 25);
			if (DockSide == eDockSide.Top && eBarState_0 == eBarState.Docked)
			{
				point = new Point(0, ((Control)this).get_Height() - 25 - 1);
				size = new Size(((Control)this).get_Width(), 25);
			}
			if (eBarState_0 == eBarState.Docked)
			{
				if (eBorderType_0 != 0)
				{
					point = new Point(2, ((Control)this).get_Height() - 25 - 3);
					size = new Size(((Control)this).get_Width() - 4, 25);
				}
			}
			else if (eBarState_0 == eBarState.Floating)
			{
				if (IsThemed)
				{
					point = new Point(struct11_0.int_0, ((Control)this).get_Height() - 25 - struct11_0.int_2);
					size = new Size(((Control)this).get_Width() - (struct11_0.int_0 + struct11_0.int_2), 25);
				}
				else
				{
					point = new Point(3, ((Control)this).get_Height() - 25 - 3);
					size = new Size(((Control)this).get_Width() - 6, 25);
				}
			}
			else
			{
				((Control)tabStrip_0).set_Visible(false);
			}
			break;
		case eTabStripAlignment.Left:
			if (eGrabHandleStyle_0 != 0 && !rectangle_2.IsEmpty)
			{
				point = new Point(rectangle_2.X + 1, rectangle_2.Bottom + 1);
				size = new Size(25, genericItemContainer_0.HeightInternal - 1);
			}
			else if (eBarState_0 == eBarState.Docked)
			{
				point = new Point(2, 1);
				size = new Size(25, ((Control)this).get_Height() - 3);
			}
			else if (eBarState_0 == eBarState.Floating)
			{
				if (IsThemed)
				{
					point = new Point(struct11_0.int_0, struct11_0.int_1);
					size = new Size(((Control)this).get_Width() - (struct11_0.int_0 + struct11_0.int_2), 25);
				}
				else
				{
					point = new Point(3, 3);
					size = new Size(((Control)this).get_Width() - 6, 25);
				}
			}
			else
			{
				((Control)tabStrip_0).set_Visible(false);
			}
			break;
		case eTabStripAlignment.Right:
			if (eGrabHandleStyle_0 != 0 && !rectangle_2.IsEmpty && eBarState_0 == eBarState.Docked)
			{
				point = new Point(((Control)this).get_ClientRectangle().Right - 25, rectangle_2.Bottom + 1);
				size = new Size(23, genericItemContainer_0.HeightInternal);
			}
			else if (eBarState_0 == eBarState.Docked)
			{
				point = new Point(((Control)this).get_Width() - 25, 1);
				size = new Size(25, ((Control)this).get_Height() - 2);
			}
			else if (eBarState_0 == eBarState.Floating)
			{
				if (IsThemed)
				{
					point = new Point(((Control)this).get_Width() - struct11_0.int_2 - 25, struct11_0.int_1);
					size = new Size(25, ((Control)this).get_Height() - (struct11_0.int_1 + struct11_0.int_3));
				}
				else
				{
					point = new Point(((Control)this).get_Width() - 3 - 25, genericItemContainer_0.TopInternal);
					size = new Size(25, genericItemContainer_0.HeightInternal);
				}
			}
			else
			{
				((Control)tabStrip_0).set_Visible(false);
			}
			break;
		case eTabStripAlignment.Top:
			if (eGrabHandleStyle_0 != 0 && !rectangle_2.IsEmpty)
			{
				point = new Point(rectangle_2.X, rectangle_2.Bottom);
				size = new Size(((Control)this).get_Width() - rectangle_2.Left * 2, 25);
			}
			else if (eBarState_0 == eBarState.Docked)
			{
				point = new Point(1, 1);
				size = new Size(((Control)this).get_Width() - 2, 25);
			}
			else if (eBarState_0 == eBarState.Floating)
			{
				if (IsThemed)
				{
					point = new Point(struct11_0.int_0, struct11_0.int_1);
					size = new Size(((Control)this).get_Width() - (struct11_0.int_0 + struct11_0.int_2), 25);
				}
				else
				{
					point = new Point(3, 3);
					size = new Size(((Control)this).get_Width() - 6, 25);
				}
			}
			else
			{
				((Control)tabStrip_0).set_Visible(false);
			}
			break;
		}
		((Control)tabStrip_0).SetBounds(point.X, point.Y, size.Width, size.Height);
	}

	private void tabStrip_0_SelectedTabChanging(object sender, TabStripTabChangingEventArgs e)
	{
		if (!bool_58)
		{
			e.Cancel = method_132((e.OldTab == null) ? null : e.OldTab.AttachedItem, (e.NewTab == null) ? null : e.NewTab.AttachedItem);
		}
	}

	private void method_130(BaseItem baseItem_5)
	{
		if (!bool_41 || LayoutType != eLayoutType.DockContainer)
		{
			return;
		}
		DockContainerItem selectedDockContainerItem = SelectedDockContainerItem;
		if ((selectedDockContainerItem != null && selectedDockContainerItem.Visible) || baseItem_5 != null)
		{
			if (baseItem_5 == null)
			{
				baseItem_5 = selectedDockContainerItem;
			}
			((Control)this).set_Text(baseItem_5.Text);
			return;
		}
		foreach (BaseItem item in Items)
		{
			if (item.Visible && item.Displayed)
			{
				((Control)this).set_Text(item.Text);
				break;
			}
		}
	}

	internal void method_131()
	{
		method_130(null);
	}

	private bool method_132(BaseItem baseItem_5, BaseItem baseItem_6)
	{
		DockTabChangeEventArgs dockTabChangeEventArgs = null;
		IOwnerBarSupport ownerBarSupport = object_1 as IOwnerBarSupport;
		bool flag = false;
		if (dockTabChangeEventHandler_0 != null)
		{
			dockTabChangeEventArgs = new DockTabChangeEventArgs(baseItem_5, baseItem_6);
			dockTabChangeEventHandler_0(this, dockTabChangeEventArgs);
			if (flag = dockTabChangeEventArgs.Cancel)
			{
				return flag;
			}
		}
		if (object_1 != null)
		{
			if (dockTabChangeEventArgs == null)
			{
				dockTabChangeEventArgs = new DockTabChangeEventArgs(baseItem_5, baseItem_6);
			}
			ownerBarSupport?.InvokeDockTabChange(this, dockTabChangeEventArgs);
			flag = dockTabChangeEventArgs.Cancel;
		}
		if (!flag)
		{
			method_130(baseItem_6);
		}
		return flag;
	}

	internal void method_133(BaseItem baseItem_5)
	{
		if (eventHandler_10 != null)
		{
			eventHandler_10(baseItem_5, new EventArgs());
		}
		if (object_1 is IOwnerBarSupport ownerBarSupport)
		{
			ownerBarSupport.InvokeBeforeDockTabDisplay(baseItem_5, new EventArgs());
		}
	}

	private void tabStrip_0_TabMoved(object sender, TabStripTabMovedEventArgs e)
	{
		genericItemContainer_0.SubItems.method_3((DockContainerItem)e.Tab.AttachedItem);
		genericItemContainer_0.SubItems.method_1((DockContainerItem)e.Tab.AttachedItem, e.NewIndex);
		bool_43 = true;
	}

	public Size MinimumDockSize(eOrientation dockOrientation)
	{
		if (genericItemContainer_0 == null)
		{
			return new Size(32, 32);
		}
		if (genericItemContainer_0.LayoutType == eLayoutType.DockContainer && (genericItemContainer_0.Stretch || bool_4))
		{
			if (genericItemContainer_0.SubItems.Count > 0 && genericItemContainer_0.SubItems[0] is DockContainerItem)
			{
				return ((DockContainerItem)genericItemContainer_0.SubItems[0]).MinimumSize;
			}
			return new Size(32, 32);
		}
		if (!genericItemContainer_0.Stretch && !bool_4)
		{
			if (genericItemContainer_0.SubItems.Count > 0)
			{
				BaseItem baseItem = genericItemContainer_0.SubItems[0];
				if (baseItem != null)
				{
					return new Size(baseItem.WidthInternal + rectangle_0.Left * 2, baseItem.HeightInternal);
				}
			}
			return new Size(0, 0);
		}
		return PreferredDockSize(dockOrientation);
	}

	internal Size method_134(Size size_3)
	{
		Size result = size_3;
		if (tabStrip_0 != null && ((Control)tabStrip_0).get_Visible() && (DockTabAlignment == eTabStripAlignment.Top || DockTabAlignment == eTabStripAlignment.Bottom))
		{
			result.Height += ((Control)tabStrip_0).get_Height();
		}
		result.Height += 6 + SystemInformation.get_ToolWindowCaptionHeight();
		result.Width += 6;
		return result;
	}

	internal int method_135(eOrientation eOrientation_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		if (genericItemContainer_0 == null)
		{
			return 0;
		}
		if (eOrientation_0 == eOrientation.Horizontal && dockSiteInfo_1.DockedHeight > 0 && ((int)dockSiteInfo_1.DockSide == 1 || (int)dockSiteInfo_1.DockSide == 2))
		{
			return dockSiteInfo_1.DockedHeight;
		}
		if (eOrientation_0 == eOrientation.Vertical && dockSiteInfo_1.DockedWidth > 0 && ((int)dockSiteInfo_1.DockSide == 3 || (int)dockSiteInfo_1.DockSide == 4))
		{
			return dockSiteInfo_1.DockedWidth;
		}
		if (eOrientation_0 == eOrientation.Horizontal && genericItemContainer_0.Int32_1 > 0 && genericItemContainer_0.Int32_1 + SystemInformation.get_ToolWindowCaptionHeight() < method_54())
		{
			return genericItemContainer_0.Int32_1 + SystemInformation.get_ToolWindowCaptionHeight();
		}
		if (eOrientation_0 == eOrientation.Vertical && genericItemContainer_0.Int32_2 > 0 && genericItemContainer_0.Int32_2 + SystemInformation.get_ToolWindowCaptionHeight() < method_53())
		{
			return genericItemContainer_0.Int32_2 + SystemInformation.get_ToolWindowCaptionHeight();
		}
		if (SelectedDockTab >= 0 || (VisibleItemCount > 0 && LayoutType == eLayoutType.DockContainer))
		{
			DockContainerItem dockContainerItem = null;
			dockContainerItem = ((SelectedDockTab < 0) ? (method_98() as DockContainerItem) : (Items[SelectedDockTab] as DockContainerItem));
			if (dockContainerItem != null)
			{
				if (eOrientation_0 == eOrientation.Horizontal)
				{
					if (dockContainerItem.MinimumSize.Height > 0)
					{
						if (((Control)this).get_Height() > dockContainerItem.MinimumSize.Height)
						{
							return ((Control)this).get_Height();
						}
						return dockContainerItem.MinimumSize.Height * 2 + 25 + 6;
					}
				}
				else if (dockContainerItem.MinimumSize.Width > 0)
				{
					if (((Control)this).get_Width() > dockContainerItem.MinimumSize.Width)
					{
						return ((Control)this).get_Width();
					}
					return dockContainerItem.MinimumSize.Width * 2 + 6;
				}
			}
		}
		if (eOrientation_0 == eOrientation.Horizontal)
		{
			return ((Control)this).get_Height();
		}
		return ((Control)this).get_Width();
	}

	public Size PreferredDockSize(eOrientation dockOrientation)
	{
		IOwner owner = object_1 as IOwner;
		if (dockOrientation == eOrientation.Horizontal)
		{
			if (size_1.IsEmpty)
			{
				if (owner != null && owner.ParentForm != null)
				{
					size_1 = method_29(owner.ParentForm.get_Size(), eOrientation.Horizontal, eBarState.Docked, bool_1);
				}
				else
				{
					size_1 = method_29(Screen.FromControl((Control)(object)this).get_WorkingArea().Size, eOrientation.Horizontal, eBarState.Docked, bool_1);
				}
			}
			return size_1;
		}
		if (size_2.IsEmpty)
		{
			Size empty = Size.Empty;
			empty = ((owner == null || owner.ParentForm == null) ? method_29(Screen.FromControl((Control)(object)this).get_WorkingArea().Size, eOrientation.Horizontal, eBarState.Docked, bool_1) : method_29(owner.ParentForm.get_Size(), eOrientation.Horizontal, eBarState.Docked, bool_1));
			size_2 = new Size(empty.Height, empty.Width);
		}
		return size_2;
	}

	protected override void OnDockChanged(EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnDockChanged(e);
		if ((int)((Control)this).get_Dock() != 0)
		{
			bool_4 = true;
		}
		else
		{
			bool_4 = false;
		}
		RecalcLayout();
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void SetDockLine(int iLine)
	{
		int_29 = iLine;
	}

	public bool ShouldSerializeDockSide()
	{
		if (((Control)this).get_Parent() is DockSite && ((DockSite)(object)((Control)this).get_Parent()).DocumentDockContainer != null)
		{
			return false;
		}
		return DockSide != eDockSide.None;
	}

	private void method_136(eDockSide eDockSide_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (!AutoHide)
		{
			return;
		}
		DockStyle val = (DockStyle)3;
		switch (eDockSide_0)
		{
		case eDockSide.Bottom:
			val = (DockStyle)2;
			break;
		case eDockSide.Right:
			val = (DockStyle)4;
			break;
		case eDockSide.Top:
			val = (DockStyle)1;
			break;
		}
		if (dockSiteInfo_1.DockSide == val || eDockSide_0 == eDockSide.None)
		{
			return;
		}
		AutoHidePanel autoHidePanel = method_99(dockSiteInfo_1.DockSide);
		if (autoHidePanel != null && object_1 is IOwnerBarSupport ownerBarSupport)
		{
			method_105();
			autoHidePanel.RemoveBar(this);
			dockSiteInfo_1.DockSide = val;
			DockStyle val2 = val;
			switch (val2 - 1)
			{
			case 0:
				dockSiteInfo_1.objDockSite = ownerBarSupport.TopDockSite;
				break;
			case 1:
				dockSiteInfo_1.objDockSite = ownerBarSupport.BottomDockSite;
				break;
			case 2:
				dockSiteInfo_1.objDockSite = ownerBarSupport.LeftDockSite;
				break;
			case 3:
				dockSiteInfo_1.objDockSite = ownerBarSupport.RightDockSite;
				break;
			}
			autoHidePanel = method_99(val);
			autoHidePanel.AddBar(this);
		}
	}

	void IOwner.SetExpandedItem(BaseItem objItem)
	{
		if (objItem != null && objItem.Parent is PopupItem)
		{
			return;
		}
		if (baseItem_2 != null)
		{
			if (baseItem_2.Expanded)
			{
				baseItem_2.Expanded = false;
			}
			baseItem_2 = null;
		}
		baseItem_2 = objItem;
	}

	BaseItem IOwner.GetExpandedItem()
	{
		return baseItem_2;
	}

	void IOwner.SetFocusItem(BaseItem objFocusItem)
	{
		if (DockSide == eDockSide.Document && object_1 != null)
		{
			((IOwner)object_1).SetFocusItem(objFocusItem);
			return;
		}
		if (baseItem_3 != null && baseItem_3 != objFocusItem)
		{
			baseItem_3.OnLostFocus();
		}
		baseItem_3 = objFocusItem;
		if (baseItem_3 != null)
		{
			baseItem_3.OnGotFocus();
		}
		if (eventHandler_13 != null)
		{
			eventHandler_13(this, new EventArgs());
		}
	}

	BaseItem IOwner.GetFocusItem()
	{
		if (DockSide == eDockSide.Document && object_1 != null)
		{
			return ((IOwner)object_1).GetFocusItem();
		}
		return baseItem_3;
	}

	void IOwner.DesignTimeContextMenu(BaseItem objItem)
	{
	}

	void IOwner.RemoveShortcutsFromItem(BaseItem objItem)
	{
		Class49 @class = null;
		if (objItem.ShortcutString != "")
		{
			foreach (eShortcut shortcut in objItem.Shortcuts)
			{
				if (!hashtable_1.ContainsKey(shortcut))
				{
					continue;
				}
				@class = (Class49)hashtable_1[shortcut];
				try
				{
					@class.hashtable_0.Remove(objItem.Id);
					if (@class.hashtable_0.Count == 0)
					{
						hashtable_1.Remove(@class.eShortcut_0);
					}
				}
				catch (ArgumentException)
				{
				}
			}
		}
		foreach (BaseItem subItem in objItem.SubItems)
		{
			((IOwner)this).RemoveShortcutsFromItem(subItem);
		}
	}

	void IOwner.AddShortcutsFromItem(BaseItem objItem)
	{
		Class49 @class = null;
		if (objItem.ShortcutString != "")
		{
			foreach (eShortcut shortcut in objItem.Shortcuts)
			{
				if (hashtable_1.ContainsKey(shortcut))
				{
					@class = (Class49)hashtable_1[objItem.Shortcuts[0]];
				}
				else
				{
					@class = new Class49(shortcut);
					hashtable_1.Add(@class.eShortcut_0, @class);
				}
				try
				{
					@class.hashtable_0.Add(objItem.Id, objItem);
				}
				catch (ArgumentException)
				{
				}
			}
		}
		foreach (BaseItem subItem in objItem.SubItems)
		{
			((IOwner)this).AddShortcutsFromItem(subItem);
		}
	}

	MdiClient IOwner.GetMdiClient(Form MdiForm)
	{
		return Class109.smethod_58(MdiForm);
	}

	void IOwner.Customize()
	{
	}

	private void imageList_2_Disposed(object sender, EventArgs e)
	{
		if (sender == imageList_0)
		{
			Images = null;
		}
		else if (sender == imageList_2)
		{
			ImagesLarge = null;
		}
		else if (sender == imageList_1)
		{
			ImagesMedium = null;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void BeginInit()
	{
		bool_55 = true;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public void EndInit()
	{
		bool_55 = false;
		if (DockSide == eDockSide.Document && ((Control)this).get_Parent() is DockSite)
		{
			((DockSite)(object)((Control)this).get_Parent()).RecalcLayout();
		}
		else
		{
			RecalcSize();
		}
		if (AutoHide != bool_57)
		{
			AutoHide = bool_57;
		}
	}

	void IOwner.InvokeResetDefinition(BaseItem item, EventArgs e)
	{
	}

	void IOwner.InvokeUserCustomize(object sender, EventArgs e)
	{
	}

	void IOwner.InvokeEndUserCustomize(object sender, EndUserCustomizeEventArgs e)
	{
	}

	void IOwner.StartItemDrag(BaseItem objItem)
	{
		if (((Component)this).DesignMode && barBaseControlDesigner_0 != null)
		{
			barBaseControlDesigner_0.StartExternalDrag(objItem);
		}
	}

	void IOwner.OnApplicationActivate()
	{
	}

	void IOwner.OnApplicationDeactivate()
	{
		ClosePopups();
	}

	void IOwner.OnParentPositionChanging()
	{
	}

	private void method_137()
	{
		if (!bool_37)
		{
			bool_37 = true;
			Form val = ((Control)this).FindForm();
			if (val == null)
			{
				bool_37 = false;
				return;
			}
			((Control)val).add_Resize((EventHandler)method_139);
			val.add_Deactivate((EventHandler)method_140);
			DotNetBarManager.RegisterParentMsgHandler(this, val);
		}
	}

	private void method_138()
	{
		if (bool_37)
		{
			bool_37 = false;
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				DotNetBarManager.UnRegisterParentMsgHandler(this, val);
				((Control)val).remove_Resize((EventHandler)method_139);
				val.remove_Deactivate((EventHandler)method_140);
			}
		}
	}

	private void method_139(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	private void method_140(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		Form val = ((Control)this).FindForm();
		if (val != null && (int)val.get_WindowState() == 1)
		{
			((IOwner)this).OnApplicationDeactivate();
		}
	}

	void IOwnerMenuSupport.RegisterPopup(PopupItem objPopup)
	{
		if (arrayList_0.Contains(objPopup))
		{
			return;
		}
		if (!((Component)this).DesignMode)
		{
			if (!bool_60)
			{
				Class107.smethod_0(this);
				bool_60 = true;
			}
			if (!bool_37)
			{
				method_137();
			}
		}
		else if (class94_0 == null)
		{
			class94_0 = new Class94(this);
		}
		arrayList_0.Add(objPopup);
		if (objPopup.GetOwner() != this)
		{
			objPopup.method_6(this);
		}
	}

	void IOwnerMenuSupport.UnregisterPopup(PopupItem objPopup)
	{
		if (arrayList_0.Contains(objPopup))
		{
			arrayList_0.Remove(objPopup);
		}
		if (arrayList_0.Count == 0)
		{
			method_138();
			if (class94_0 != null)
			{
				class94_0.Dispose();
				class94_0 = null;
			}
		}
	}

	bool IOwnerMenuSupport.RelayMouseHover()
	{
		foreach (PopupItem item in arrayList_0)
		{
			Control popupControl = item.PopupControl;
			if (popupControl != null && popupControl.get_DisplayRectangle().Contains(Control.get_MousePosition()))
			{
				if (popupControl is MenuPanel)
				{
					((MenuPanel)(object)popupControl).method_23();
				}
				else if (popupControl is Bar)
				{
					((Bar)(object)popupControl).method_57();
				}
				return true;
			}
		}
		return false;
	}

	void IOwnerMenuSupport.ClosePopups()
	{
		ClosePopups();
	}

	internal void ClosePopups()
	{
		ArrayList arrayList = new ArrayList(arrayList_0);
		foreach (PopupItem item in arrayList)
		{
			item.ClosePopup();
		}
	}

	void IOwnerMenuSupport.InvokePopupClose(PopupItem item, EventArgs e)
	{
		if (eventHandler_6 != null)
		{
			eventHandler_6(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerLoad(PopupItem item, EventArgs e)
	{
		if (eventHandler_7 != null)
		{
			eventHandler_7(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupContainerUnload(PopupItem item, EventArgs e)
	{
		if (eventHandler_8 != null)
		{
			eventHandler_8(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupOpen(PopupItem item, PopupOpenEventArgs e)
	{
		if (popupOpenEventHandler_0 != null)
		{
			popupOpenEventHandler_0(item, e);
		}
	}

	void IOwnerMenuSupport.InvokePopupShowing(PopupItem item, EventArgs e)
	{
		if (eventHandler_9 != null)
		{
			eventHandler_9(item, e);
		}
	}

	bool Interface5.imethod_5(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return false;
	}

	bool Interface5.imethod_2(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Invalid comparison between Unknown and I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected I4, but got Unknown
		bool designMode = ((Component)this).DesignMode;
		if (arrayList_0.Count > 0)
		{
			BaseItem baseItem = (BaseItem)arrayList_0[arrayList_0.Count - 1];
			Keys val = (Keys)Class92.MapVirtualKey((uint)(int)intptr_1, 2u);
			if ((int)val == 0)
			{
				val = (Keys)intptr_1.ToInt32();
			}
			if (baseItem.Parent == null || IsContextPopup(baseItem) || (int)val == 27 || (int)val == 13 || (int)val == 37 || (int)val == 39 || (int)val == 40 || (int)val == 38)
			{
				PopupItem popupItem = (PopupItem)arrayList_0[arrayList_0.Count - 1];
				Control popupControl = popupItem.PopupControl;
				Control val2 = Control.FromChildHandle(intptr_0);
				if (val2 != null)
				{
					while (val2.get_Parent() != null)
					{
						val2 = val2.get_Parent();
					}
				}
				bool flag = false;
				if (val2 != null && popupItem != null)
				{
					flag = popupItem.IsAnyOnHandle(val2.get_Handle().ToInt32());
				}
				bool flag2 = (popupControl != null && val2 != null && popupControl.get_Handle() == val2.get_Handle()) || flag;
				if (!flag)
				{
					popupItem.InternalKeyDown(new KeyEventArgs(val));
				}
				if (flag2)
				{
					return false;
				}
				return !designMode;
			}
		}
		Form val3 = ((Control)this).FindForm();
		if (val3 != null && (val3 == Form.get_ActiveForm() || val3.get_MdiParent() != null) && (val3.get_MdiParent() == null || val3.get_MdiParent().get_ActiveMdiChild() == val3))
		{
			if (intptr_1.ToInt32() < 112 && (int)Control.get_ModifierKeys() == 0 && (intptr_2.ToInt32() & 0x1000000000L) == 0L && intptr_1.ToInt32() != 46 && intptr_1.ToInt32() != 45)
			{
				return false;
			}
			int eShortcut_ = Control.get_ModifierKeys() | intptr_1.ToInt32();
			if (method_141((eShortcut)eShortcut_))
			{
				return !designMode;
			}
			return false;
		}
		return false;
	}

	protected virtual bool IsContextPopup(BaseItem popup)
	{
		return false;
	}

	private bool method_141(eShortcut eShortcut_0)
	{
		if (!Boolean_21)
		{
			return false;
		}
		bool result = Class109.smethod_5(eShortcut_0, hashtable_1);
		if (!bool_61)
		{
			return result;
		}
		return false;
	}

	bool Interface5.imethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (arrayList_0.Count != 0 && !((Component)this).DesignMode)
		{
			for (int num = arrayList_0.Count - 1; num >= 0; num--)
			{
				PopupItem popupItem = arrayList_0[num] as PopupItem;
				object containerControl = popupItem.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				bool flag;
				if (!(flag = popupItem.IsAnyOnHandle(intptr_0.ToInt32())))
				{
					Control val2 = Control.FromChildHandle(intptr_0);
					if (val2 != null)
					{
						if (val2 is MenuPanel)
						{
							flag = true;
						}
						else
						{
							while (val2.get_Parent() != null)
							{
								val2 = val2.get_Parent();
								if (((object)val2).GetType().FullName!.IndexOf("DropDownHolder") >= 0 || val2 is MenuPanel || val2 is PopupContainerControl)
								{
									flag = true;
									break;
								}
							}
						}
						if (!flag)
						{
							flag = popupItem.IsAnyOnHandle(val2.get_Handle().ToInt32());
						}
					}
					else
					{
						string text = Class92.smethod_8(intptr_0);
						text = text.ToLower();
						if (text.IndexOf("combolbox") >= 0)
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					Control val3 = popupItem.PopupControl;
					if (val3 != null)
					{
						while (val3.get_Parent() != null)
						{
							val3 = val3.get_Parent();
						}
					}
					if (val3 != null && val3.get_Bounds().Contains(Control.get_MousePosition()))
					{
						flag = true;
					}
				}
				if (flag)
				{
					break;
				}
				if (val != null && intptr_0 != val.get_Handle() && !flag)
				{
					popupItem.Expanded = !popupItem.Expanded;
					if (!popupItem.Expanded && popupItem.Parent != null)
					{
						popupItem.Parent.AutoExpand = false;
					}
				}
				else if (val == null && !flag)
				{
					popupItem.ClosePopup();
				}
				if (arrayList_0.Count == 0)
				{
					break;
				}
			}
			return false;
		}
		return false;
	}

	bool Interface5.imethod_4(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (arrayList_0.Count > 0)
		{
			foreach (BaseItem item in arrayList_0)
			{
				if (item.Parent == null)
				{
					Control popupControl = ((PopupItem)item).PopupControl;
					if (popupControl != null && popupControl.get_Handle() != intptr_0 && !item.IsAnyOnHandle(intptr_0.ToInt32()) && (popupControl.get_Parent() == null || !(popupControl.get_Parent().get_Handle() != intptr_0)))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	protected virtual bool InternalSysKeyDown(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected I4, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Invalid comparison between Unknown and I4
		if (wParam.ToInt32() == 18 && (int)Control.get_ModifierKeys() == 262144)
		{
			ClosePopups();
		}
		Form val = ((Control)this).FindForm();
		if (val != null && Class109.smethod_65(val))
		{
			Bar bar = null;
			if (MenuBar)
			{
				bar = this;
			}
			if (bar != null && bar.ItemsContainer != null && !bar.ItemsContainer.DesignMode)
			{
				GenericItemContainer itemsContainer = bar.ItemsContainer;
				if (itemsContainer == null)
				{
					return false;
				}
				if (wParam.ToInt32() != 18 && (wParam.ToInt32() != 121 || bool_64 || ((int)Control.get_ModifierKeys() != 0 && (int)Control.get_ModifierKeys() != 262144)))
				{
					if ((int)Control.get_ModifierKeys() != 0 || (wParam.ToInt32() >= 112 && wParam.ToInt32() <= 123))
					{
						int eShortcut_ = Control.get_ModifierKeys() | wParam.ToInt32();
						if (method_141((eShortcut)eShortcut_))
						{
							return true;
						}
					}
					bool_62 = true;
					if (wParam.ToInt32() >= 27 && wParam.ToInt32() <= 111)
					{
						int num = (int)Class92.MapVirtualKey((uint)(int)wParam, 2u);
						if (num == 0)
						{
							num = wParam.ToInt32();
						}
						if (num > 0 && itemsContainer.method_27(num))
						{
							return true;
						}
					}
				}
				else if (itemsContainer.ExpandedItem() != null && ((Control)bar).get_Focused())
				{
					bar.ReleaseFocus();
					bool_62 = true;
					return true;
				}
			}
			else if (bar == null && !((Component)this).DesignMode && ((int)Control.get_ModifierKeys() != 0 || (wParam.ToInt32() >= 112 && wParam.ToInt32() <= 123)))
			{
				int eShortcut_2 = Control.get_ModifierKeys() | wParam.ToInt32();
				if (method_141((eShortcut)eShortcut_2))
				{
					return true;
				}
			}
			if ((int)Control.get_ModifierKeys() == 262144 && wParam.ToInt32() > 27)
			{
				bool_62 = true;
				int num2 = (int)Class92.MapVirtualKey((uint)(int)wParam, 2u);
				if (num2 != 0 && !((Component)this).DesignMode && genericItemContainer_0.method_27(num2))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	bool Interface5.imethod_0(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		return InternalSysKeyDown(intptr_0, intptr_1, intptr_2);
	}

	bool Interface5.imethod_1(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		Form val = ((Control)this).FindForm();
		if (val != null && !((Component)this).DesignMode && Class109.smethod_65(val))
		{
			if (intptr_1.ToInt32() == 18 || intptr_1.ToInt32() == 121)
			{
				if (bool_62)
				{
					bool_62 = false;
					return false;
				}
				if (bool_63)
				{
					bool_63 = false;
					return true;
				}
				if (intptr_1.ToInt32() == 18 || (intptr_1.ToInt32() == 121 && !bool_64))
				{
					Bar bar = null;
					if (MenuBar)
					{
						bar = this;
					}
					if (bar != null && !bar.ItemsContainer.DesignMode)
					{
						if (((Control)bar).get_Focused())
						{
							bar.ReleaseFocus();
						}
						else
						{
							bar.method_3();
						}
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	Size IDockInfo.MinimumDockSize(eOrientation dockOrientation)
	{
		return MinimumDockSize(dockOrientation);
	}

	Size IDockInfo.PreferredDockSize(eOrientation dockOrientation)
	{
		return PreferredDockSize(dockOrientation);
	}

	void IDockInfo.SetDockLine(int iLine)
	{
		SetDockLine(iLine);
	}

	private ISite method_142()
	{
		ISite site = null;
		IOwner owner = Owner as IOwner;
		Control val = null;
		if (owner is Control)
		{
			val = (Control)((owner is Control) ? owner : null);
		}
		if (baseItem_0 != null && baseItem_0.ContainerControl is Control && (val == null || (val != null && ((Component)(object)val).Site == null)))
		{
			object containerControl = baseItem_0.ContainerControl;
			val = (Control)((containerControl is Control) ? containerControl : null);
		}
		if (val != null)
		{
			while (site == null && val != null)
			{
				if (((Component)(object)val).Site != null && ((Component)(object)val).Site!.DesignMode)
				{
					site = ((Component)(object)val).Site;
				}
				else
				{
					val = val.get_Parent();
				}
			}
		}
		if (site == null && baseItem_0 != null)
		{
			BaseItem parent = baseItem_0;
			while (site == null && parent != null)
			{
				if (parent.Site != null && parent.Site.DesignMode)
				{
					site = parent.Site;
				}
				else
				{
					parent = parent.Parent;
				}
			}
		}
		return site;
	}

	private void method_143(MouseEventArgs mouseEventArgs_0)
	{
		if (bool_65)
		{
			try
			{
				if (idesignTimeProvider_0 != null)
				{
					idesignTimeProvider_0.DrawReversibleMarker(int_39, bool_66);
					idesignTimeProvider_0 = null;
				}
				InsertPosition insertPosition = idesignTimeProvider_1.GetInsertPosition(Control.get_MousePosition(), baseItem_4);
				if (insertPosition != null)
				{
					if (insertPosition.TargetProvider == null)
					{
						Cursor.set_Current(Cursors.get_No());
					}
					else
					{
						insertPosition.TargetProvider.DrawReversibleMarker(insertPosition.Position, insertPosition.Before);
						int_39 = insertPosition.Position;
						bool_66 = insertPosition.Before;
						idesignTimeProvider_0 = insertPosition.TargetProvider;
						Cursor.set_Current(Cursors.get_Hand());
					}
				}
				else
				{
					Cursor.set_Current(Cursors.get_No());
				}
				return;
			}
			catch
			{
				idesignTimeProvider_0 = null;
				return;
			}
		}
		if (object_1 is IOwner)
		{
			baseItem_4 = ((IOwner)object_1).GetFocusItem();
		}
		if (baseItem_4 != null)
		{
			BaseItem parent = baseItem_0;
			while (parent.Parent is IDesignTimeProvider)
			{
				parent = parent.Parent;
			}
			idesignTimeProvider_1 = (IDesignTimeProvider)parent;
			bool_65 = true;
			((Control)this).set_Capture(true);
		}
	}

	private void method_144(MouseEventArgs mouseEventArgs_0)
	{
		ISite site = method_142();
		if (site == null)
		{
			return;
		}
		IComponentChangeService componentChangeService = site.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_39, bool_66);
			BaseItem parent = baseItem_4.Parent;
			if (parent != null)
			{
				if (parent == (BaseItem)idesignTimeProvider_0 && int_39 > 0 && parent.SubItems.IndexOf(baseItem_4) < int_39)
				{
					int_39--;
				}
				componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(parent)["SubItems"]);
				parent.SubItems.Remove(baseItem_4);
				componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(parent)["SubItems"], null, null);
				object containerControl = parent.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is Bar)
				{
					((Bar)(object)val).RecalcLayout();
				}
				else if (val is MenuPanel)
				{
					((MenuPanel)(object)val).RecalcSize();
				}
			}
			idesignTimeProvider_0.InsertItemAt(baseItem_4, int_39, bool_66);
			idesignTimeProvider_0 = null;
		}
		idesignTimeProvider_1 = null;
		baseItem_4 = null;
		bool_65 = false;
		((Control)this).set_Capture(false);
	}

	private void method_145(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		IOwner owner = Owner as IOwner;
		BaseItem baseItem = genericItemContainer_0.ItemAtLocation(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
		if (baseItem != null && baseItem.SystemItem)
		{
			baseItem = null;
		}
		if (baseItem == null)
		{
			return;
		}
		if (owner != null)
		{
			owner.SetFocusItem(baseItem);
			ISite site = method_142();
			if (site != null)
			{
				ISelectionService selectionService = (ISelectionService)site.GetService(typeof(ISelectionService));
				if (selectionService != null)
				{
					ArrayList arrayList = new ArrayList(1);
					arrayList.Add(baseItem);
					selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
				}
				if ((int)mouseEventArgs_0.get_Button() == 2097152)
				{
					((IMenuCommandService)site.GetService(typeof(IMenuCommandService)))?.ShowContextMenu(MenuCommands.SelectionMenu, Control.get_MousePosition().X, Control.get_MousePosition().Y);
				}
			}
		}
		owner = null;
		baseItem?.InternalMouseDown(mouseEventArgs_0);
	}

	void IOwnerLocalize.InvokeLocalizeString(LocalizeEventArgs e)
	{
		if (localizeStringEventHandler_0 != null)
		{
			localizeStringEventHandler_0(this, e);
		}
	}
}
