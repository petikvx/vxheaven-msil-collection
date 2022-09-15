using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.TextMarkup;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public abstract class BaseItem : IComponent, IDisposable, ICloneable, IBindableComponent, ICommandSource, IBlock
{
	public class ItemAccessibleObject : AccessibleObject
	{
		private BaseItem baseItem_0;

		private bool bool_0;

		internal BaseItem BaseItem_0 => baseItem_0;

		public override string Name
		{
			get
			{
				if (baseItem_0 == null)
				{
					return "";
				}
				if (baseItem_0.AccessibleName != "")
				{
					return baseItem_0.AccessibleName;
				}
				if (baseItem_0.Text != null)
				{
					return baseItem_0.Text.Replace("&", "");
				}
				return baseItem_0.Tooltip;
			}
			set
			{
				baseItem_0.AccessibleName = value;
			}
		}

		public override string Description
		{
			get
			{
				if (baseItem_0 == null)
				{
					return "";
				}
				if (baseItem_0.AccessibleDescription != "")
				{
					return baseItem_0.AccessibleDescription;
				}
				if (baseItem_0.IsOnMenu)
				{
					return ((AccessibleObject)this).get_Name() + " menu item";
				}
				if (baseItem_0.IsOnMenuBar)
				{
					return ((AccessibleObject)this).get_Name() + " menu";
				}
				return ((AccessibleObject)this).get_Name() + " button";
			}
		}

		public override AccessibleRole Role
		{
			get
			{
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0021: Invalid comparison between Unknown and I4
				//IL_0029: Unknown result type (might be due to invalid IL or missing references)
				if (baseItem_0 == null || !baseItem_0.IsAccessible)
				{
					return (AccessibleRole)0;
				}
				if ((int)baseItem_0.AccessibleRole != -1)
				{
					return baseItem_0.AccessibleRole;
				}
				BaseItem parent = baseItem_0;
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				if (!baseItem_0.IsOnMenu && !baseItem_0.IsOnMenuBar && !parent.IsOnMenuBar)
				{
					return (AccessibleRole)43;
				}
				return (AccessibleRole)12;
			}
		}

		public override AccessibleStates State
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0101: Unknown result type (might be due to invalid IL or missing references)
				//IL_0102: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Unknown result type (might be due to invalid IL or missing references)
				//IL_010b: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_0116: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				if (baseItem_0 == null)
				{
					return (AccessibleStates)1;
				}
				AccessibleStates val = (AccessibleStates)0;
				if (!baseItem_0.IsAccessible)
				{
					return (AccessibleStates)1;
				}
				if (baseItem_0.Displayed && baseItem_0.Visible)
				{
					if (!baseItem_0.method_2())
					{
						val = (AccessibleStates)1;
						if (baseItem_0.Expanded || bool_0 || (baseItem_0 is ButtonItem && ((ButtonItem)baseItem_0).IsMouseOver))
						{
							val = (AccessibleStates)(val | 0x84);
						}
						return val;
					}
					val = (AccessibleStates)((baseItem_0.Expanded || bool_0 || (baseItem_0 is ButtonItem && ((ButtonItem)baseItem_0).IsMouseOver)) ? (val | 0x84) : (val | 0x100000));
					if (baseItem_0.ShowSubItems && baseItem_0.SubItems.Count > 0)
					{
						val = (AccessibleStates)((!baseItem_0.Expanded) ? (val | 0x400) : (val | 0x200));
					}
				}
				else
				{
					val = (AccessibleStates)(val | 0x8000);
				}
				return val;
			}
		}

		public override AccessibleObject Parent
		{
			get
			{
				if (baseItem_0 == null)
				{
					return null;
				}
				if (baseItem_0.Parent != null && (!(baseItem_0.Parent is GenericItemContainer) || !((GenericItemContainer)baseItem_0.Parent).SystemContainer))
				{
					return baseItem_0.Parent.AccessibleObject;
				}
				object containerControl = baseItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					return val.get_AccessibilityObject();
				}
				return null;
			}
		}

		public override Rectangle Bounds
		{
			get
			{
				if (baseItem_0 == null)
				{
					return Rectangle.Empty;
				}
				object containerControl = baseItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					return val.RectangleToScreen(baseItem_0.DisplayRectangle);
				}
				return baseItem_0.m_Rect;
			}
		}

		public override string DefaultAction
		{
			get
			{
				if (baseItem_0.AccessibleDefaultActionDescription != "")
				{
					return baseItem_0.AccessibleDefaultActionDescription;
				}
				return "Press";
			}
		}

		public override string KeyboardShortcut => baseItem_0.ShortcutString;

		public ItemAccessibleObject(BaseItem owner)
		{
			baseItem_0 = owner;
			BaseItem baseItem = baseItem_0;
			baseItem.eventHandler_5 = (EventHandler)Delegate.Combine(baseItem.eventHandler_5, new EventHandler(OnMouseEnter));
			BaseItem baseItem2 = baseItem_0;
			baseItem2.eventHandler_6 = (EventHandler)Delegate.Combine(baseItem2.eventHandler_6, new EventHandler(OnMouseLeave));
		}

		protected virtual void OnMouseEnter(object sender, EventArgs e)
		{
			bool_0 = true;
		}

		protected virtual void OnMouseLeave(object sender, EventArgs e)
		{
			bool_0 = false;
		}

		public override int GetChildCount()
		{
			if (baseItem_0 == null)
			{
				return 0;
			}
			return baseItem_0.SubItems.Count;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			if (baseItem_0 == null)
			{
				return null;
			}
			return baseItem_0.SubItems[iIndex].AccessibleObject;
		}

		public override void DoDefaultAction()
		{
			if (baseItem_0 != null)
			{
				object containerControl = baseItem_0.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is MenuPanel && !(val is IAccessibilitySupport))
				{
					object containerControl2 = ((MenuPanel)(object)val).ParentItem.ContainerControl;
					val = (Control)((containerControl2 is Control) ? containerControl2 : null);
				}
				if (val is IAccessibilitySupport accessibilitySupport)
				{
					accessibilitySupport.DoDefaultActionItem = baseItem_0;
					Class92.PostMessage(val.get_Handle().ToInt32(), 1131, 0, 0);
				}
				((AccessibleObject)this).DoDefaultAction();
			}
		}

		public override AccessibleObject GetSelected()
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Invalid comparison between Unknown and I4
			if (baseItem_0 == null)
			{
				return ((AccessibleObject)this).GetSelected();
			}
			foreach (BaseItem subItem in baseItem_0.SubItems)
			{
				if ((subItem.AccessibleObject.get_State() & 0x80) == 128)
				{
					return subItem.AccessibleObject;
				}
			}
			return ((AccessibleObject)this).GetSelected();
		}

		public override AccessibleObject HitTest(int x, int y)
		{
			if (baseItem_0 == null)
			{
				return ((AccessibleObject)this).HitTest(x, y);
			}
			Point point = new Point(x, y);
			foreach (BaseItem subItem in baseItem_0.SubItems)
			{
				object containerControl = subItem.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					Point pt = val.PointToClient(point);
					if (subItem.DisplayRectangle.Contains(pt))
					{
						return subItem.AccessibleObject;
					}
				}
			}
			return ((AccessibleObject)this).HitTest(x, y);
		}

		public override AccessibleObject Navigate(AccessibleNavigation navdir)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Invalid comparison between Unknown and I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Invalid comparison between Unknown and I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Invalid comparison between Unknown and I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Invalid comparison between Unknown and I4
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Invalid comparison between Unknown and I4
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			if (baseItem_0 == null)
			{
				return ((AccessibleObject)this).Navigate(navdir);
			}
			BaseItem baseItem = null;
			if ((int)navdir != 2 && (int)navdir != 4 && (int)navdir != 5)
			{
				if ((int)navdir == 7)
				{
					baseItem = method_0(baseItem_0.SubItems, 0);
				}
				else if ((int)navdir == 8)
				{
					baseItem = method_1(baseItem_0.SubItems, baseItem_0.SubItems.Count - 1);
				}
				else if ((int)navdir == 1 || (int)navdir == 3 || (int)navdir == 6)
				{
					BaseItem parent = baseItem_0.Parent;
					baseItem = method_1(baseItem_0.SubItems, parent.SubItems.IndexOf(baseItem_0) - 1);
				}
			}
			else if (baseItem_0.Parent != null)
			{
				BaseItem parent2 = baseItem_0.Parent;
				baseItem = method_0(parent2.SubItems, parent2.SubItems.IndexOf(baseItem_0) + 1);
			}
			if (baseItem != null)
			{
				return baseItem.AccessibleObject;
			}
			return ((AccessibleObject)this).Navigate(navdir);
		}

		private BaseItem method_0(SubItemsCollection subItemsCollection_0, int int_0)
		{
			int count = subItemsCollection_0.Count;
			int num = int_0;
			while (true)
			{
				if (num < count)
				{
					if (subItemsCollection_0[num].Visible)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return subItemsCollection_0[num];
		}

		private BaseItem method_1(SubItemsCollection subItemsCollection_0, int int_0)
		{
			int num = int_0;
			while (true)
			{
				if (num >= 0)
				{
					if (subItemsCollection_0[num].Visible)
					{
						break;
					}
					num--;
					continue;
				}
				return null;
			}
			return subItemsCollection_0[num];
		}
	}

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private EventHandler eventHandler_4;

	private MouseEventHandler mouseEventHandler_0;

	private MouseEventHandler mouseEventHandler_1;

	private EventHandler eventHandler_5;

	private EventHandler eventHandler_6;

	private MouseEventHandler mouseEventHandler_2;

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private EventHandler eventHandler_9;

	private EventHandler eventHandler_10;

	private EventHandler eventHandler_11;

	private EventHandler eventHandler_12;

	private EventHandler eventHandler_13;

	private CollectionChangeEventHandler collectionChangeEventHandler_0;

	protected string m_Text;

	protected Rectangle m_Rect;

	protected SubItemsCollection m_SubItems;

	protected bool m_Visible;

	protected BaseItem m_HotSubItem;

	protected bool m_IsContainer;

	protected BaseItem m_Parent;

	protected bool m_NeedRecalcSize;

	protected bool m_Expanded;

	protected bool m_AutoExpand;

	protected object m_ContainerControl;

	protected bool m_Displayed;

	protected object m_ItemData;

	protected bool m_Enabled;

	protected bool m_BeginGroup;

	protected eDotNetBarStyle m_Style;

	protected string m_Description;

	protected string m_Tooltip;

	protected string m_Name = "";

	private string string_0 = "";

	protected string m_Category;

	protected eOrientation m_Orientation;

	protected bool m_SystemItem;

	protected eSupportedOrientation m_SupportedOrientation;

	protected bool m_RecalculatingSize;

	protected bool m_CheckMouseMovePressed;

	private bool bool_0;

	private int int_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	protected ToolTip m_ToolTipWnd;

	private static int int_1;

	private bool bool_4;

	private bool bool_5;

	protected char m_AccessKey;

	private bool bool_6;

	private eItemAlignment eItemAlignment_0;

	private ShortcutsCollection shortcutsCollection_0;

	private string string_1 = "";

	private Point point_0;

	private object object_0;

	private bool bool_7;

	private int int_2 = 600;

	private bool bool_8 = true;

	private bool bool_9;

	private bool bool_10;

	private ISite isite_0;

	protected bool m_ThemeAware;

	private bool bool_11 = true;

	private Enum9 enum9_0;

	private Cursor cursor_0;

	private Cursor cursor_1;

	protected bool m_ShouldSerialize = true;

	internal bool bool_12;

	protected bool m_AllowOnlyOneSubItemExpanded = true;

	private string string_2 = "";

	private AccessibleRole accessibleRole_0 = (AccessibleRole)(-1);

	private string string_3 = "";

	private string string_4 = "";

	private bool bool_13 = true;

	private string string_5 = "";

	private int int_3 = -1;

	private string string_6 = "";

	internal Point point_1 = Point.Empty;

	internal bool bool_14 = true;

	internal bool bool_15;

	internal bool bool_16;

	private bool bool_17;

	private bool bool_18;

	private bool bool_19;

	private bool bool_20;

	internal bool bool_21;

	private ICommand icommand_0;

	private object object_1;

	private Class261 class261_0;

	private BindingContext bindingContext_0;

	private ControlBindingsCollection controlBindingsCollection_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual object ContainerControl
	{
		get
		{
			return method_0(bool_22: true);
		}
		set
		{
			object containerControl = ContainerControl;
			m_ContainerControl = value;
			OnContainerChanged(containerControl);
		}
	}

	[Browsable(false)]
	public virtual BaseItem Parent
	{
		get
		{
			if (ContainerControl is Bar)
			{
				Bar bar = ContainerControl as Bar;
				if (bar.ParentItem == this)
				{
					return null;
				}
				if (m_Parent == bar.ItemsContainer)
				{
					return bar.ParentItem;
				}
			}
			return m_Parent;
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether is item enabled.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public virtual bool Enabled
	{
		get
		{
			return m_Enabled;
		}
		set
		{
			if (m_Enabled != value)
			{
				m_Enabled = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "Enabled");
				}
				if (!m_Enabled && m_Expanded)
				{
					Expanded = false;
				}
				Refresh();
				OnEnabledChanged();
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates whether this item is beginning of the group.")]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	public virtual bool BeginGroup
	{
		get
		{
			return m_BeginGroup;
		}
		set
		{
			if (m_BeginGroup != value)
			{
				NeedRecalcSize = true;
				m_BeginGroup = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "BeginGroup");
				}
				Refresh();
				OnAppearanceChanged();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual int LeftInternal
	{
		get
		{
			return m_Rect.Left;
		}
		set
		{
			if (m_Rect.X != value)
			{
				int x = m_Rect.X;
				m_Rect.X = value;
				OnLeftLocationChanged(x);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual int TopInternal
	{
		get
		{
			return m_Rect.Top;
		}
		set
		{
			if (m_Rect.Y != value)
			{
				int y = m_Rect.Y;
				m_Rect.Y = value;
				OnTopLocationChanged(y);
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int WidthInternal
	{
		get
		{
			return m_Rect.Width;
		}
		set
		{
			if (m_Rect.Width != value)
			{
				m_Rect.Width = value;
				OnExternalSizeChange();
			}
		}
	}

	protected internal virtual bool IsRightToLeft
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 == value)
			{
				return;
			}
			bool_10 = value;
			foreach (BaseItem subItem in SubItems)
			{
				subItem.IsRightToLeft = value;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual int HeightInternal
	{
		get
		{
			return m_Rect.Height;
		}
		set
		{
			if (m_Rect.Height != value)
			{
				m_Rect.Height = value;
				OnExternalSizeChange();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Description("Determines whether the item is visible or hidden.")]
	[Browsable(true)]
	[DefaultValue(true)]
	public virtual bool Visible
	{
		get
		{
			return m_Visible;
		}
		set
		{
			if (m_Visible != value)
			{
				m_Visible = value;
				NeedRecalcSize = true;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "Visible");
				}
				if (!m_Visible && m_Displayed && m_Parent != null)
				{
					m_Parent.SubItemSizeChanged(this);
				}
				if (!bool_4)
				{
					Displayed = false;
				}
				OnVisibleChanged(value);
			}
		}
	}

	[DefaultValue(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool Expanded
	{
		get
		{
			return m_Expanded;
		}
		set
		{
			if (m_Expanded != value)
			{
				m_Expanded = value;
				OnExpandChange();
				if (m_Parent != null)
				{
					m_Parent.OnSubItemExpandChange(this);
				}
			}
		}
	}

	[Description("Indicates whether the item will auto-collapse (fold) when clicked.")]
	[Browsable(true)]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public virtual bool AutoCollapseOnClick
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
		}
	}

	[DefaultValue(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool AutoExpand
	{
		get
		{
			return m_AutoExpand;
		}
		set
		{
			if (m_AutoExpand != value)
			{
				m_AutoExpand = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "AutoExpand");
				}
			}
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual Rectangle DisplayRectangle => m_Rect;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual Size Size
	{
		get
		{
			return m_Rect.Size;
		}
		set
		{
			if (m_Rect.Size != value)
			{
				m_Rect.Size = value;
				OnExternalSizeChange();
			}
		}
	}

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Rectangle Bounds
	{
		get
		{
			return m_Rect;
		}
		set
		{
			if (m_Rect != value)
			{
				bool flag = m_Rect.Size != value.Size;
				_ = m_Rect.Top;
				_ = value.Top;
				_ = m_Rect.Left;
				_ = value.Left;
				_ = m_Rect.Left;
				m_Rect = value;
				if (flag)
				{
					OnExternalSizeChange();
				}
			}
		}
	}

	[Browsable(false)]
	public virtual bool IsContainer => m_IsContainer;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool Displayed
	{
		get
		{
			return m_Displayed;
		}
		set
		{
			if (m_Displayed != value)
			{
				m_Displayed = value;
				OnDisplayedChanged();
			}
		}
	}

	[Browsable(false)]
	public bool IsOnContextMenu => GetOwner() is ContextMenuBar;

	internal bool Boolean_0 => true;

	private BaseItem BaseItem_0
	{
		get
		{
			BaseItem parent = m_Parent;
			while (parent != null && parent.Parent != null)
			{
				parent = parent.Parent;
			}
			return parent;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool Focused => bool_2;

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public bool IsRecalculatingSize => m_RecalculatingSize;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool SuspendLayout
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool IsDisposed => bool_18;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DevCoBrowsable(false)]
	public virtual SubItemsCollection SubItems
	{
		get
		{
			if (m_SubItems == null)
			{
				m_SubItems = new SubItemsCollection(this);
			}
			return m_SubItems;
		}
	}

	[Browsable(false)]
	public int VisibleSubItems
	{
		get
		{
			int num = 0;
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem.Visible)
				{
					num++;
				}
			}
			return num;
		}
	}

	[Description("Specifies unique ID of the item.")]
	[Category("Design")]
	[Browsable(false)]
	public long Id => int_0;

	[Localizable(true)]
	[Category("Data")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[TypeConverter(typeof(StringConverter))]
	[DefaultValue("")]
	public virtual object Tag
	{
		get
		{
			return m_ItemData;
		}
		set
		{
			m_ItemData = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DefaultValue(eDotNetBarStyle.OfficeXP)]
	[DevCoBrowsable(false)]
	[Description("Determines the display of the item when shown.")]
	[Category("Appearance")]
	[Browsable(false)]
	public virtual eDotNetBarStyle Style
	{
		get
		{
			return m_Style;
		}
		set
		{
			m_Style = value;
			if (m_SubItems != null)
			{
				foreach (BaseItem subItem in m_SubItems)
				{
					subItem.Style = m_Style;
				}
			}
			OnStyleChanged();
		}
	}

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(true)]
	[Description("Determines whether sub-items are displayed.")]
	[Category("Behavior")]
	public virtual bool ShowSubItems
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				NeedRecalcSize = true;
				bool_1 = value;
				if (Displayed)
				{
					Refresh();
				}
			}
		}
	}

	[DefaultValue(eItemAlignment.Near)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Determines alignment of the item inside the container.")]
	[Category("Appearance")]
	public virtual eItemAlignment ItemAlignment
	{
		get
		{
			return eItemAlignment_0;
		}
		set
		{
			if (eItemAlignment_0 != value)
			{
				eItemAlignment_0 = value;
				NeedRecalcSize = true;
				if (Displayed && Parent != null)
				{
					Parent.SubItemSizeChanged(this);
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Design")]
	[DefaultValue("")]
	[Localizable(true)]
	[Description("Indicates description of the item that is displayed during design.")]
	[Browsable(true)]
	public virtual string Description
	{
		get
		{
			return m_Description;
		}
		set
		{
			if (!(m_Description == value))
			{
				m_Description = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "Description");
				}
			}
		}
	}

	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether item will stretch to consume empty space. Items on stretchable, no-wrap Bars only.")]
	[DefaultValue(false)]
	[Browsable(true)]
	public virtual bool Stretch
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
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "Stretch");
				}
				NeedRecalcSize = true;
				if (Displayed && m_Parent != null && !bool_9)
				{
					m_Parent.SubItemSizeChanged(this);
				}
				OnAppearanceChanged();
			}
		}
	}

	[Description("Indicates the text that is displayed when mouse hovers over the item.")]
	[Localizable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue("")]
	public virtual string Tooltip
	{
		get
		{
			return m_Tooltip;
		}
		set
		{
			if (!(m_Tooltip == value))
			{
				if (value == null)
				{
					value = "";
				}
				m_Tooltip = value;
				if (ShouldSyncProperties)
				{
					Class109.smethod_22(this, "Tooltip");
				}
				OnTooltipChanged();
			}
		}
	}

	[DevCoBrowsable(true)]
	[Localizable(true)]
	[Category("Design")]
	[Description("Indicates item category used to group similar items at design-time.")]
	[Browsable(true)]
	[DefaultValue("")]
	public virtual string Category
	{
		get
		{
			return m_Category;
		}
		set
		{
			m_Category = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Design")]
	[Description("Indicates the name used to identify item.")]
	[Browsable(true)]
	public virtual string Name
	{
		get
		{
			if (isite_0 != null)
			{
				m_Name = isite_0.Name;
			}
			return m_Name;
		}
		set
		{
			if (isite_0 != null)
			{
				isite_0.Name = value;
			}
			if (value == null)
			{
				m_Name = "";
			}
			else
			{
				m_Name = value;
			}
		}
	}

	[Category("Design")]
	[Description("Indicates global name of the item that is used to synchorize the Global properties for the item across all instances with same global name.")]
	[DefaultValue("")]
	[Browsable(true)]
	public virtual string GlobalName
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	protected virtual bool ShouldSyncProperties
	{
		get
		{
			if (GlobalItem && (GlobalName.Length > 0 || Name.Length > 0))
			{
				return !bool_5;
			}
			return false;
		}
	}

	[Browsable(false)]
	public eSupportedOrientation SupportedOrientation => m_SupportedOrientation;

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates whether certain global properties are propagated to all items with the same name when changed.")]
	[Category("Behavior")]
	[DefaultValue(true)]
	public virtual bool GlobalItem
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual eOrientation Orientation
	{
		get
		{
			return m_Orientation;
		}
		set
		{
			if (m_Orientation != value)
			{
				method_7(value);
				NeedRecalcSize = true;
			}
		}
	}

	internal BaseItem BaseItem_1
	{
		get
		{
			return m_HotSubItem;
		}
		set
		{
			m_HotSubItem = value;
		}
	}

	protected virtual bool ShowToolTips => true;

	internal virtual Rectangle Rectangle_0
	{
		get
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val == null)
			{
				return Rectangle.Empty;
			}
			return new Rectangle(val.PointToScreen(DisplayRectangle.Location), DisplayRectangle.Size);
		}
	}

	protected internal bool ToolTipVisible => m_ToolTipWnd != null;

	internal string String_0
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
		}
	}

	internal int Int32_0
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public bool UserCustomized
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

	[Browsable(false)]
	public ToolTip ToolTipControl => m_ToolTipWnd;

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	[Description("Indicates the Key Tips access key or keys for the item when on Ribbon Control or Ribbon Bar.")]
	public virtual string KeyTips
	{
		get
		{
			return string_6;
		}
		set
		{
			if (value == null)
			{
				value = "";
			}
			string_6 = value.ToUpper();
		}
	}

	[DefaultValue("")]
	[Localizable(true)]
	[Category("Appearance")]
	[Description("The text contained in the item.")]
	[Browsable(true)]
	[Bindable(true)]
	[DevCoBrowsable(true)]
	public virtual string Text
	{
		get
		{
			return m_Text;
		}
		set
		{
			if (!(m_Text == value))
			{
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
				NeedRecalcSize = true;
				if (Displayed && m_Parent != null && !bool_9)
				{
					RecalcSize();
					m_Parent.SubItemSizeChanged(this);
				}
				OnTextChanged();
				OnAppearanceChanged();
			}
		}
	}

	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Indicates whether item can be customized by user.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	public virtual bool CanCustomize
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	protected internal bool IsOnCustomizeMenu => bool_4;

	protected internal bool IsOnCustomizeDialog => bool_5;

	[Browsable(false)]
	public bool IsOnMenu
	{
		get
		{
			if (!(ContainerControl is MenuPanel) && !(ContainerControl is Class83))
			{
				return false;
			}
			return true;
		}
	}

	[Browsable(false)]
	public virtual bool IsOnMenuBar
	{
		get
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null && val is Bar)
			{
				return ((Bar)(object)val).MenuBar;
			}
			return false;
		}
	}

	[Browsable(false)]
	public bool IsOnBar
	{
		get
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null && val is Bar)
			{
				return true;
			}
			return false;
		}
	}

	[DevCoBrowsable(false)]
	[Browsable(false)]
	public virtual bool DesignMode => bool_6;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool NeedRecalcSize
	{
		get
		{
			return m_NeedRecalcSize;
		}
		set
		{
			m_NeedRecalcSize = value;
			if (value && Parent != null && ContainerControl == Parent.ContainerControl)
			{
				Parent.NeedRecalcSize = true;
			}
		}
	}

	[Browsable(false)]
	public bool SystemItem => m_SystemItem;

	protected internal char AccessKey => m_AccessKey;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Design")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Description("Indicates list of shortcut keys for this item.")]
	[TypeConverter(typeof(ShortcutsConverter))]
	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
	public virtual ShortcutsCollection Shortcuts
	{
		get
		{
			if (shortcutsCollection_0 == null)
			{
				shortcutsCollection_0 = new ShortcutsCollection(this);
			}
			return shortcutsCollection_0;
		}
		set
		{
			IOwner owner = GetOwner() as IOwner;
			if (shortcutsCollection_0 != null)
			{
				owner?.RemoveShortcutsFromItem(this);
			}
			shortcutsCollection_0 = value;
			shortcutsCollection_0.BaseItem_0 = this;
			if (shortcutsCollection_0 != null)
			{
				owner?.AddShortcutsFromItem(this);
			}
		}
	}

	protected internal string ShortcutString => string_1;

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	[Description("Gets or sets whether Click event will be auto repeated when mouse button is kept pressed over the item.")]
	public virtual bool ClickAutoRepeat
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
		}
	}

	[Category("Behavior")]
	[Description("Gets or sets the auto-repeat interval for the click event when mouse button is kept pressed over the item.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(600)]
	public virtual int ClickRepeatInterval
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	internal Enum9 Enum9_0
	{
		get
		{
			return enum9_0;
		}
		set
		{
			if (enum9_0 != value)
			{
				enum9_0 = value;
				Refresh();
			}
		}
	}

	private bool Boolean_1
	{
		get
		{
			if (Parent is ItemContainer)
			{
				if (((ItemContainer)Parent).LayoutOrientation == eOrientation.Horizontal)
				{
					return true;
				}
				return false;
			}
			if (m_Orientation == eOrientation.Horizontal && !IsOnMenu && !(Parent is SideBarPanelItem) && !(Parent is ExplorerBarGroupItem))
			{
				return true;
			}
			return false;
		}
	}

	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Description("Specifies the mouse cursor displayed when mouse is over the item.")]
	[Browsable(true)]
	[DefaultValue(null)]
	public virtual Cursor Cursor
	{
		get
		{
			return cursor_0;
		}
		set
		{
			if (!(cursor_0 != value))
			{
				return;
			}
			cursor_0 = value;
			if (!(cursor_0 != (Cursor)null) || !m_Visible || !m_Displayed)
			{
				return;
			}
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Point pt = val.PointToClient(Control.get_MousePosition());
				if (m_Rect.Contains(pt))
				{
					val.set_Cursor(cursor_0);
				}
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual ISite Site
	{
		get
		{
			return isite_0;
		}
		set
		{
			isite_0 = value;
			OnSiteChanged();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool ShouldSerialize
	{
		get
		{
			return m_ShouldSerialize;
		}
		set
		{
			m_ShouldSerialize = value;
		}
	}

	internal bool Boolean_2
	{
		get
		{
			if (m_ThemeAware && Class109.Boolean_0 && Class58.bool_0)
			{
				return true;
			}
			return false;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual bool IsWindowed => false;

	[Browsable(true)]
	[Description("Specifies whether item is drawn using Themes when running on OS that supports themes like Windows XP.")]
	[DefaultValue(false)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	public virtual bool ThemeAware
	{
		get
		{
			return m_ThemeAware;
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
				subItem.ThemeAware = value;
			}
		}
	}

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public virtual AccessibleObject AccessibleObject => CreateAccessibilityInstance();

	[Description("Gets or sets the default action description of the control for use by accessibility client applications.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Accessibility")]
	[DefaultValue("")]
	public virtual string AccessibleDefaultActionDescription
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	[Category("Accessibility")]
	[Browsable(true)]
	[DefaultValue("")]
	[DevCoBrowsable(true)]
	[Description("Gets or sets the description of the control used by accessibility client applications.")]
	public virtual string AccessibleDescription
	{
		get
		{
			return string_4;
		}
		set
		{
			if (string_4 != value)
			{
				string_4 = value;
				method_13((AccessibleEvents)32781);
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets the name of the control used by accessibility client applications.")]
	[Browsable(true)]
	[DefaultValue("")]
	[Category("Accessibility")]
	public virtual string AccessibleName
	{
		get
		{
			return string_3;
		}
		set
		{
			if (string_3 != value)
			{
				string_3 = value;
				method_13((AccessibleEvents)32780);
			}
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets the accessible role of the item.")]
	[Category("Accessibility")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	public virtual AccessibleRole AccessibleRole
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return accessibleRole_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			accessibleRole_0 = value;
		}
	}

	[DevCoBrowsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public virtual bool IsAccessible
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

	[DefaultValue(null)]
	[Description("Indicates the command assigned to the item.")]
	[Category("Commands")]
	public Command Command
	{
		get
		{
			return (Command)((ICommandSource)this).Command;
		}
		set
		{
			((ICommandSource)this).Command = value;
			if (ShouldSyncProperties)
			{
				Class109.smethod_22(this, "Command");
			}
		}
	}

	ICommand ICommandSource.Command
	{
		get
		{
			return icommand_0;
		}
		set
		{
			bool flag = false;
			if (icommand_0 != value)
			{
				flag = true;
			}
			if (icommand_0 != null)
			{
				CommandManager.UnRegisterCommandSource(this, icommand_0);
			}
			icommand_0 = value;
			if (value != null)
			{
				CommandManager.RegisterCommand(this, value);
			}
			if (flag)
			{
				OnCommandChanged();
			}
		}
	}

	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[DefaultValue(null)]
	[Localizable(true)]
	[TypeConverter(typeof(StringConverter))]
	[Category("Commands")]
	[Browsable(true)]
	public object CommandParameter
	{
		get
		{
			return object_1;
		}
		set
		{
			object_1 = value;
			if (ShouldSyncProperties)
			{
				Class109.smethod_22(this, "CommandParameter");
			}
		}
	}

	internal Class261 Class261_0 => class261_0;

	protected virtual bool IsMarkupSupported => false;

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public BindingContext BindingContext
	{
		get
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			if (bindingContext_0 != null)
			{
				return bindingContext_0;
			}
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				if (!(val is MenuPanel))
				{
					return val.get_BindingContext();
				}
				object owner = GetOwner();
				if (owner is DotNetBarManager && ((DotNetBarManager)owner).ParentForm != null)
				{
					return ((Control)((DotNetBarManager)owner).ParentForm).get_BindingContext();
				}
				if (owner is Control)
				{
					return ((Control)owner).get_BindingContext();
				}
			}
			return null;
		}
		set
		{
			bindingContext_0 = value;
		}
	}

	[ParenthesizePropertyName(true)]
	[RefreshProperties(RefreshProperties.All)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Data")]
	public ControlBindingsCollection DataBindings
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			if (controlBindingsCollection_0 == null)
			{
				controlBindingsCollection_0 = new ControlBindingsCollection((IBindableComponent)(object)this);
			}
			return controlBindingsCollection_0;
		}
	}

	[Description("Occurs when Item is clicked.")]
	public event EventHandler Click
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

	[Description("Occurs when Item is double-clicked.")]
	public event EventHandler DoubleClick
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

	[Description("Occurs when Item Expanded property has changed.")]
	public event EventHandler ExpandChange
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

	[Description("Occurs when item loses input focus.")]
	public event EventHandler LostFocus
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

	[Description("Occurs when item receives input focus.")]
	public event EventHandler GotFocus
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

	[Description("Occurs when mouse button is pressed.")]
	public event MouseEventHandler MouseDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_0 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_0, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse button is released.")]
	public event MouseEventHandler MouseUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_1 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_1, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse enters the item.")]
	public event EventHandler MouseEnter
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

	[Description("Occurs when mouse leaves the item.")]
	public event EventHandler MouseLeave
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

	[Description("Occurs when mouse moves over the item.")]
	public event MouseEventHandler MouseMove
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			mouseEventHandler_2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)mouseEventHandler_2, (Delegate?)(object)value);
		}
	}

	[Description("Occurs when mouse remains still inside an item for an amount of time.")]
	public event EventHandler MouseHover
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

	[Description("Occurs when copy of the item is made.")]
	public event EventHandler ItemCopied
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

	[Description("Occurs when Text property of an Item has changed.")]
	public event EventHandler TextChanged
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

	[Description("Occurs when Visible property of an Item has changed.")]
	public event EventHandler VisibleChanged
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

	[Description("Occurs when Enabled property of an Item has changed.")]
	public event EventHandler EnabledChanged
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

	[Description("Occurs when component is Disposed.")]
	public event EventHandler Disposed
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

	[Description("Occurs when item's tooltip visibility has changed.")]
	public event EventHandler ToolTipVisibleChanged
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

	[Description("Occurs when content of SubItems collection has changed")]
	public event CollectionChangeEventHandler SubItemsChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			collectionChangeEventHandler_0 = (CollectionChangeEventHandler)Delegate.Combine(collectionChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			collectionChangeEventHandler_0 = (CollectionChangeEventHandler)Delegate.Remove(collectionChangeEventHandler_0, value);
		}
	}

	public BaseItem()
		: this("", "")
	{
	}

	public BaseItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public BaseItem(string sItemName, string ItemText)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if (ItemText == null)
		{
			ItemText = "";
		}
		m_Text = ItemText;
		if (m_Text != "")
		{
			m_AccessKey = Class92.smethod_2(m_Text);
		}
		m_Rect = Rectangle.Empty;
		m_ContainerControl = null;
		m_HotSubItem = null;
		m_IsContainer = false;
		m_SubItems = null;
		m_Parent = null;
		m_NeedRecalcSize = true;
		m_Visible = true;
		m_Expanded = false;
		m_AutoExpand = false;
		m_ItemData = "";
		m_Enabled = true;
		m_BeginGroup = false;
		m_Style = eDotNetBarStyle.OfficeXP;
		m_Description = "";
		m_Tooltip = "";
		m_Name = sItemName;
		m_Category = "";
		m_Orientation = eOrientation.Horizontal;
		m_ToolTipWnd = null;
		int_0 = ++int_1;
		bool_4 = false;
		bool_5 = false;
		m_SystemItem = false;
		shortcutsCollection_0 = null;
		bool_6 = false;
		bool_0 = true;
		bool_1 = true;
		eItemAlignment_0 = eItemAlignment.Near;
		bool_2 = false;
		object_0 = null;
		method_15();
	}

	protected internal virtual void Serialize(ItemSerializationContext context)
	{
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Invalid comparison between Unknown and I4
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected I4, but got Unknown
		XmlElement itemXmlElement = context.ItemXmlElement;
		Type type = GetType();
		AssemblyName name = type.Assembly.GetName();
		if (name.Name != "DevComponents.DotNetBar")
		{
			itemXmlElement.SetAttribute("assembly", name.Name + ", PublicKeyToken=" + Encoding.ASCII.GetString(name.GetPublicKey()));
		}
		else
		{
			itemXmlElement.SetAttribute("assembly", name.Name);
		}
		itemXmlElement.SetAttribute("class", type.FullName);
		itemXmlElement.SetAttribute("name", m_Name);
		itemXmlElement.SetAttribute("globalname", string_0);
		itemXmlElement.SetAttribute("text", m_Text);
		itemXmlElement.SetAttribute("iscontainer", XmlConvert.ToString(m_IsContainer));
		itemXmlElement.SetAttribute("visible", XmlConvert.ToString(m_Visible));
		if (m_ItemData != null && m_ItemData.ToString() != "")
		{
			itemXmlElement.SetAttribute("itemdata", m_ItemData.ToString());
		}
		else
		{
			itemXmlElement.SetAttribute("itemdata", "");
		}
		itemXmlElement.SetAttribute("enabled", XmlConvert.ToString(m_Enabled));
		itemXmlElement.SetAttribute("begingroup", XmlConvert.ToString(m_BeginGroup));
		itemXmlElement.SetAttribute("style", XmlConvert.ToString((int)m_Style));
		itemXmlElement.SetAttribute("desc", m_Description);
		itemXmlElement.SetAttribute("tooltip", m_Tooltip);
		itemXmlElement.SetAttribute("category", m_Category);
		itemXmlElement.SetAttribute("cancustomize", XmlConvert.ToString(bool_0));
		itemXmlElement.SetAttribute("showsubitems", XmlConvert.ToString(bool_1));
		itemXmlElement.SetAttribute("itemalignment", XmlConvert.ToString((int)eItemAlignment_0));
		itemXmlElement.SetAttribute("stretch", XmlConvert.ToString(bool_3));
		itemXmlElement.SetAttribute("global", XmlConvert.ToString(bool_11));
		itemXmlElement.SetAttribute("themes", XmlConvert.ToString(m_ThemeAware));
		if (string_2 != "")
		{
			itemXmlElement.SetAttribute("adefdesc", string_2);
		}
		if (string_4 != "")
		{
			itemXmlElement.SetAttribute("adesc", string_4);
		}
		if (string_3 != "")
		{
			itemXmlElement.SetAttribute("aname", string_3);
		}
		if ((int)accessibleRole_0 != -1)
		{
			itemXmlElement.SetAttribute("arole", XmlConvert.ToString((int)accessibleRole_0));
		}
		if (!bool_8)
		{
			itemXmlElement.SetAttribute("autocollapse", XmlConvert.ToString(bool_8));
		}
		if (bool_7)
		{
			itemXmlElement.SetAttribute("autorepeat", XmlConvert.ToString(bool_7));
		}
		if (int_2 != 600)
		{
			itemXmlElement.SetAttribute("clickrepinterv", XmlConvert.ToString(int_2));
		}
		if (cursor_0 != (Cursor)null)
		{
			if (cursor_0 == Cursors.get_Hand())
			{
				itemXmlElement.SetAttribute("cur", "4");
			}
			else if (cursor_0 == Cursors.get_AppStarting())
			{
				itemXmlElement.SetAttribute("cur", "1");
			}
			else if (cursor_0 == Cursors.get_Arrow())
			{
				itemXmlElement.SetAttribute("cur", "2");
			}
			else if (cursor_0 == Cursors.get_Cross())
			{
				itemXmlElement.SetAttribute("cur", "3");
			}
			else if (cursor_0 == Cursors.get_Help())
			{
				itemXmlElement.SetAttribute("cur", "5");
			}
			else if (cursor_0 == Cursors.get_HSplit())
			{
				itemXmlElement.SetAttribute("cur", "6");
			}
			else if (cursor_0 == Cursors.get_IBeam())
			{
				itemXmlElement.SetAttribute("cur", "7");
			}
			else if (cursor_0 == Cursors.get_No())
			{
				itemXmlElement.SetAttribute("cur", "8");
			}
			else if (cursor_0 == Cursors.get_NoMove2D())
			{
				itemXmlElement.SetAttribute("cur", "9");
			}
			else if (cursor_0 == Cursors.get_NoMoveHoriz())
			{
				itemXmlElement.SetAttribute("cur", "10");
			}
			else if (cursor_0 == Cursors.get_NoMoveVert())
			{
				itemXmlElement.SetAttribute("cur", "11");
			}
			else if (cursor_0 == Cursors.get_PanEast())
			{
				itemXmlElement.SetAttribute("cur", "12");
			}
			else if (cursor_0 == Cursors.get_PanNE())
			{
				itemXmlElement.SetAttribute("cur", "13");
			}
			else if (cursor_0 == Cursors.get_PanNorth())
			{
				itemXmlElement.SetAttribute("cur", "14");
			}
			else if (cursor_0 == Cursors.get_PanNW())
			{
				itemXmlElement.SetAttribute("cur", "15");
			}
			else if (cursor_0 == Cursors.get_PanSE())
			{
				itemXmlElement.SetAttribute("cur", "16");
			}
			else if (cursor_0 == Cursors.get_PanSouth())
			{
				itemXmlElement.SetAttribute("cur", "17");
			}
			else if (cursor_0 == Cursors.get_PanSW())
			{
				itemXmlElement.SetAttribute("cur", "18");
			}
			else if (cursor_0 == Cursors.get_PanWest())
			{
				itemXmlElement.SetAttribute("cur", "19");
			}
			else if (cursor_0 == Cursors.get_SizeAll())
			{
				itemXmlElement.SetAttribute("cur", "20");
			}
			else if (cursor_0 == Cursors.get_SizeNESW())
			{
				itemXmlElement.SetAttribute("cur", "21");
			}
			else if (cursor_0 == Cursors.get_SizeNS())
			{
				itemXmlElement.SetAttribute("cur", "22");
			}
			else if (cursor_0 == Cursors.get_SizeNWSE())
			{
				itemXmlElement.SetAttribute("cur", "23");
			}
			else if (cursor_0 == Cursors.get_SizeWE())
			{
				itemXmlElement.SetAttribute("cur", "24");
			}
			else if (cursor_0 == Cursors.get_UpArrow())
			{
				itemXmlElement.SetAttribute("cur", "25");
			}
			else if (cursor_0 == Cursors.get_VSplit())
			{
				itemXmlElement.SetAttribute("cur", "26");
			}
			else if (cursor_0 == Cursors.get_WaitCursor())
			{
				itemXmlElement.SetAttribute("cur", "27");
			}
		}
		if (SubItems.Count > 0 && ShouldSerializeSubItems())
		{
			XmlElement xmlElement = itemXmlElement.OwnerDocument.CreateElement("subitems");
			itemXmlElement.AppendChild(xmlElement);
			foreach (BaseItem subItem in SubItems)
			{
				if (subItem.ShouldSerialize)
				{
					XmlElement xmlElement2 = itemXmlElement.OwnerDocument.CreateElement("item");
					type = subItem.GetType();
					xmlElement.AppendChild(xmlElement2);
					context.ItemXmlElement = xmlElement2;
					subItem.Serialize(context);
					context.ItemXmlElement = itemXmlElement;
				}
			}
		}
		if (shortcutsCollection_0 != null && shortcutsCollection_0.Count > 0)
		{
			itemXmlElement.SetAttribute("shortcuts", shortcutsCollection_0.ToString(","));
		}
		if (context.HasSerializeItemHandlers)
		{
			XmlElement xmlElement3 = itemXmlElement.OwnerDocument.CreateElement("customData");
			SerializeItemEventArgs e = new SerializeItemEventArgs(this, itemXmlElement, xmlElement3);
			context.Serializer.InvokeSerializeItem(e);
			if (xmlElement3.Attributes.Count > 0 || xmlElement3.ChildNodes.Count > 0)
			{
				itemXmlElement.AppendChild(xmlElement3);
			}
		}
	}

	protected internal virtual void Deserialize(ItemSerializationContext context)
	{
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		XmlElement itemXmlElement = context.ItemXmlElement;
		m_Name = itemXmlElement.GetAttribute("name");
		if (itemXmlElement.HasAttribute("globalname"))
		{
			string_0 = itemXmlElement.GetAttribute("globalname");
		}
		m_Text = itemXmlElement.GetAttribute("text");
		m_AccessKey = Class92.smethod_2(m_Text);
		m_IsContainer = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("iscontainer"));
		if (context.idesignerHost_0 == null)
		{
			m_Visible = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("visible"));
		}
		else
		{
			TypeDescriptor.GetProperties(this)["Visible"]!.SetValue(this, XmlConvert.ToBoolean(itemXmlElement.GetAttribute("visible")));
		}
		if (itemXmlElement.GetAttribute("itemdata") != "")
		{
			m_ItemData = itemXmlElement.GetAttribute("itemdata");
		}
		else
		{
			m_ItemData = "";
		}
		m_Enabled = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("enabled"));
		m_BeginGroup = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("begingroup"));
		m_Style = (eDotNetBarStyle)XmlConvert.ToInt32(itemXmlElement.GetAttribute("style"));
		m_Description = itemXmlElement.GetAttribute("desc");
		m_Tooltip = itemXmlElement.GetAttribute("tooltip");
		m_Category = itemXmlElement.GetAttribute("category");
		bool_0 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("cancustomize"));
		bool_1 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("showsubitems"));
		eItemAlignment_0 = (eItemAlignment)XmlConvert.ToInt32(itemXmlElement.GetAttribute("itemalignment"));
		if (itemXmlElement.HasAttribute("stretch"))
		{
			bool_3 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("stretch"));
		}
		else
		{
			bool_3 = false;
		}
		if (itemXmlElement.HasAttribute("global"))
		{
			bool_11 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("global"));
		}
		if (itemXmlElement.HasAttribute("themes"))
		{
			m_ThemeAware = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("themes"));
		}
		if (itemXmlElement.HasAttribute("adefdesc"))
		{
			string_2 = itemXmlElement.GetAttribute("adefdesc");
		}
		if (itemXmlElement.HasAttribute("adesc"))
		{
			string_4 = itemXmlElement.GetAttribute("adesc");
		}
		if (itemXmlElement.HasAttribute("aname"))
		{
			string_3 = itemXmlElement.GetAttribute("aname");
		}
		if (itemXmlElement.HasAttribute("arole"))
		{
			accessibleRole_0 = (AccessibleRole)XmlConvert.ToInt32(itemXmlElement.GetAttribute("arole"));
		}
		if (itemXmlElement.HasAttribute("autocollapse"))
		{
			bool_8 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("autocollapse"));
		}
		else
		{
			bool_8 = true;
		}
		if (itemXmlElement.HasAttribute("autorepeat"))
		{
			bool_7 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("autorepeat"));
		}
		else
		{
			bool_7 = false;
		}
		if (itemXmlElement.HasAttribute("clickrepinterv"))
		{
			int_2 = XmlConvert.ToInt32(itemXmlElement.GetAttribute("clickrepinterv"));
		}
		else
		{
			int_2 = 600;
		}
		if (itemXmlElement.HasAttribute("cur"))
		{
			switch (itemXmlElement.GetAttribute("cur"))
			{
			case "4":
				cursor_0 = Cursors.get_Hand();
				break;
			case "1":
				cursor_0 = Cursors.get_AppStarting();
				break;
			case "2":
				cursor_0 = Cursors.get_Arrow();
				break;
			case "3":
				cursor_0 = Cursors.get_Cross();
				break;
			case "5":
				cursor_0 = Cursors.get_Help();
				break;
			case "6":
				cursor_0 = Cursors.get_HSplit();
				break;
			case "7":
				cursor_0 = Cursors.get_IBeam();
				break;
			case "8":
				cursor_0 = Cursors.get_No();
				break;
			case "9":
				cursor_0 = Cursors.get_NoMove2D();
				break;
			case "10":
				cursor_0 = Cursors.get_NoMoveHoriz();
				break;
			case "11":
				cursor_0 = Cursors.get_NoMoveVert();
				break;
			case "12":
				cursor_0 = Cursors.get_PanEast();
				break;
			case "13":
				cursor_0 = Cursors.get_PanNE();
				break;
			case "14":
				cursor_0 = Cursors.get_PanNorth();
				break;
			case "15":
				cursor_0 = Cursors.get_PanNW();
				break;
			case "16":
				cursor_0 = Cursors.get_PanSE();
				break;
			case "17":
				cursor_0 = Cursors.get_PanSouth();
				break;
			case "18":
				cursor_0 = Cursors.get_PanSW();
				break;
			case "19":
				cursor_0 = Cursors.get_PanWest();
				break;
			case "20":
				cursor_0 = Cursors.get_SizeAll();
				break;
			case "21":
				cursor_0 = Cursors.get_SizeNESW();
				break;
			case "22":
				cursor_0 = Cursors.get_SizeNS();
				break;
			case "23":
				cursor_0 = Cursors.get_SizeNWSE();
				break;
			case "24":
				cursor_0 = Cursors.get_SizeWE();
				break;
			case "25":
				cursor_0 = Cursors.get_UpArrow();
				break;
			case "26":
				cursor_0 = Cursors.get_VSplit();
				break;
			case "27":
				cursor_0 = Cursors.get_WaitCursor();
				break;
			}
		}
		XmlNodeList elementsByTagName = itemXmlElement.GetElementsByTagName("subitems");
		if (elementsByTagName.Count > 0)
		{
			foreach (XmlElement childNode in elementsByTagName[0]!.ChildNodes)
			{
				BaseItem baseItem = context.method_0(childNode);
				if (baseItem != null)
				{
					SubItems.Add(baseItem);
					context.ItemXmlElement = childNode;
					baseItem.Deserialize(context);
					context.ItemXmlElement = itemXmlElement;
				}
			}
		}
		if (itemXmlElement.HasAttribute("shortcuts"))
		{
			if (shortcutsCollection_0 == null)
			{
				shortcutsCollection_0 = new ShortcutsCollection(this);
			}
			shortcutsCollection_0.FromString(itemXmlElement.GetAttribute("shortcuts"), ",");
		}
		if (context.HasDeserializeItemHandlers)
		{
			XmlNodeList elementsByTagName2 = itemXmlElement.GetElementsByTagName("customData");
			if (elementsByTagName2.Count > 0)
			{
				XmlElement customXmlElement = elementsByTagName2[0] as XmlElement;
				SerializeItemEventArgs e = new SerializeItemEventArgs(this, itemXmlElement, customXmlElement);
				context.Serializer.InvokeDeserializeItem(e);
			}
		}
		method_15();
	}

	protected virtual bool ShouldSerializeSubItems()
	{
		return true;
	}

	protected internal virtual void OnContainerChanged(object objOldContainer)
	{
		if (m_SubItems == null || !IsContainer)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			subItem.OnContainerChanged(objOldContainer);
		}
	}

	internal object method_0(bool bool_22)
	{
		if (m_Parent == null)
		{
			return m_ContainerControl;
		}
		if (m_ContainerControl == null && (m_Parent.IsContainer || !bool_22))
		{
			return m_Parent.method_0(bool_22);
		}
		return m_ContainerControl;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void SetParent(BaseItem o)
	{
		m_Parent = o;
		m_NeedRecalcSize = true;
		OnParentChanged();
	}

	protected virtual void OnParentChanged()
	{
	}

	internal bool method_1(Control control_0)
	{
		if (m_Enabled && control_0 != null)
		{
			if (control_0.get_Enabled())
			{
				return m_Enabled;
			}
			return false;
		}
		return m_Enabled;
	}

	internal bool method_2()
	{
		object obj = method_0(bool_22: false);
		return method_1((Control)((obj is Control) ? obj : null));
	}

	protected virtual void OnExternalSizeChange()
	{
	}

	protected internal virtual void OnVisibleChanged(bool newValue)
	{
		if (eventHandler_10 != null)
		{
			eventHandler_10(this, new EventArgs());
		}
		if (DesignMode)
		{
			if (Parent != null)
			{
				Parent.NeedRecalcSize = true;
				Parent.Refresh();
			}
		}
		else if (Parent != null && Parent is ItemContainer)
		{
			Parent.NeedRecalcSize = true;
		}
	}

	internal void method_3(bool bool_22)
	{
		m_Visible = bool_22;
		if (!m_Visible && !bool_4)
		{
			m_Displayed = false;
		}
	}

	internal void method_4(Rectangle rectangle_0)
	{
		m_Rect = rectangle_0;
	}

	protected internal void SetIsContainer(bool b)
	{
		m_IsContainer = b;
	}

	protected virtual void OnDisplayedChanged()
	{
		if (Displayed && Visible)
		{
			method_13((AccessibleEvents)32770);
		}
		else
		{
			method_13((AccessibleEvents)32771);
		}
	}

	protected internal virtual void OnProcessDelayedCommands()
	{
	}

	protected virtual void OnOwnerChanged()
	{
	}

	protected virtual void OnSubItemsChanged(CollectionChangeEventArgs e)
	{
		collectionChangeEventHandler_0?.Invoke(this, e);
	}

	protected internal virtual void OnItemAdded(BaseItem item)
	{
		if (collectionChangeEventHandler_0 != null)
		{
			OnSubItemsChanged(new CollectionChangeEventArgs(CollectionChangeAction.Add, item));
		}
		GetIOwnerItemEvents()?.InvokeItemAdded(item, new EventArgs());
	}

	protected internal virtual void OnAfterItemRemoved(BaseItem item)
	{
		if (item != null)
		{
			if (collectionChangeEventHandler_0 != null)
			{
				OnSubItemsChanged(new CollectionChangeEventArgs(CollectionChangeAction.Remove, item));
			}
			GetIOwnerItemEvents()?.InvokeItemRemoved(item, this);
		}
	}

	protected virtual void OnClick()
	{
	}

	protected internal virtual void OnSubItemsClear()
	{
	}

	protected internal virtual void OnBeforeItemRemoved(BaseItem item)
	{
	}

	protected virtual void OnIsOnCustomizeMenuChanged()
	{
	}

	protected virtual void OnIsOnCustomizeDialogChanged()
	{
	}

	protected virtual void OnDesignModeChanged()
	{
	}

	protected virtual void OnTooltip(bool bShow)
	{
	}

	protected virtual void OnSubItemGotFocus(BaseItem item)
	{
	}

	protected virtual void OnSubItemLostFocus(BaseItem item)
	{
	}

	protected virtual void OnEnabledChanged()
	{
		if (eventHandler_11 != null)
		{
			eventHandler_11(this, new EventArgs());
		}
	}

	protected virtual void OnTopLocationChanged(int oldValue)
	{
	}

	protected virtual void OnLeftLocationChanged(int oldValue)
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void InternalMouseEnter()
	{
		if (!bool_6)
		{
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeMouseEnter(this, new EventArgs());
			}
		}
		if (DesignMode)
		{
			return;
		}
		ResetHover();
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (cursor_0 != (Cursor)null && val != null)
		{
			cursor_1 = val.get_Cursor();
			val.set_Cursor(cursor_0);
		}
		if ((BarUtilities.AlwaysGenerateAccessibilityFocusEvent && !(val is MenuPanel)) || (val is Bar && IsOnMenuBar))
		{
			if (val.get_AccessibilityObject() is Bar.BarAccessibleObject barAccessibleObject)
			{
				barAccessibleObject.method_0(this, (AccessibleEvents)32773);
			}
			else if (val.get_AccessibilityObject() is ItemControlAccessibleObject itemControlAccessibleObject)
			{
				itemControlAccessibleObject.method_0(this, (AccessibleEvents)32773);
			}
		}
		else if (val is MenuPanel && !((Control)(MenuPanel)(object)val).get_IsDisposed() && val.get_AccessibilityObject() is MenuPanel.PopupMenuAccessibleObject popupMenuAccessibleObject)
		{
			popupMenuAccessibleObject.method_0(this, (AccessibleEvents)32773);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void InternalMouseHover()
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (bool_6)
		{
			return;
		}
		if (m_HotSubItem != null)
		{
			if (!m_AutoExpand)
			{
				BaseItem baseItem = ExpandedItem();
				if (baseItem != null && m_HotSubItem != baseItem && baseItem.Visible && (IsOnMenu || ContainerControl is Bar || ContainerControl is RibbonBar))
				{
					baseItem.Expanded = false;
				}
			}
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseHover();
			}
			return;
		}
		if ((int)Control.get_MouseButtons() == 0)
		{
			ShowToolTip();
		}
		if (!bool_6)
		{
			if (eventHandler_7 != null)
			{
				eventHandler_7(this, new EventArgs());
			}
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeMouseHover(this, new EventArgs());
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void InternalMouseLeave()
	{
		if (cursor_1 != (Cursor)null)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.set_Cursor(cursor_1);
			}
			cursor_1 = null;
		}
		if (bool_6)
		{
			return;
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			m_HotSubItem = null;
		}
		else
		{
			if (class261_0 != null)
			{
				Class261 @class = class261_0;
				object containerControl2 = ContainerControl;
				@class.method_4((Control)((containerControl2 is Control) ? containerControl2 : null));
			}
			if (eventHandler_6 != null)
			{
				eventHandler_6(this, new EventArgs());
			}
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeMouseLeave(this, new EventArgs());
			}
		}
		HideToolTip();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Invalid comparison between Unknown and I4
		IOwner owner = null;
		point_0 = new Point(objArg.get_X(), objArg.get_Y());
		BaseItem baseItem = ExpandedItem();
		if (baseItem != null && baseItem != m_HotSubItem && !DesignMode && m_AllowOnlyOneSubItemExpanded)
		{
			baseItem.Expanded = false;
			m_AutoExpand = false;
		}
		if (bool_6 && (bool_0 || (Site != null && Site.DesignMode)))
		{
			if (IsContainer && SubItems.Count > 0)
			{
				BaseItem baseItem2 = ItemAtLocation(objArg.get_X(), objArg.get_Y());
				if (baseItem2 != null && (baseItem2.CanCustomize || (Site != null && Site.DesignMode) || (baseItem2.Site != null && baseItem2.Site.DesignMode)))
				{
					if (GetOwner() is IOwner owner2)
					{
						owner2.SetFocusItem(baseItem2);
					}
				}
				else if (baseItem2 == null && GetOwner() is IOwner owner3)
				{
					owner3.SetFocusItem(null);
				}
				if (baseItem2 != null && baseItem2 != this)
				{
					baseItem2.InternalMouseDown(objArg);
				}
			}
			if ((int)objArg.get_Button() == 2097152 && !m_IsContainer && GetOwner() is IOwner owner4)
			{
				owner4.DesignTimeContextMenu(this);
			}
		}
		if (!DesignMode && GetOwner() is IOwner owner5 && owner5.GetFocusItem() != null)
		{
			BaseItem baseItem3 = ItemAtLocation(objArg.get_X(), objArg.get_Y());
			if (baseItem3 != owner5.GetFocusItem())
			{
				owner5.GetFocusItem().ReleaseFocus();
			}
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseDown(objArg);
		}
		else if (!bool_6)
		{
			if (class261_0 != null)
			{
				Class261 @class = class261_0;
				object containerControl = ContainerControl;
				@class.method_6((Control)((containerControl is Control) ? containerControl : null), objArg);
			}
			if (mouseEventHandler_0 != null)
			{
				mouseEventHandler_0.Invoke((object)this, objArg);
			}
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeMouseDown(this, objArg);
			}
		}
		HideToolTip();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void InternalMouseUp(MouseEventArgs objArg)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		if (m_HotSubItem != null)
		{
			if (m_HotSubItem.DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()) || m_HotSubItem.bool_15)
			{
				m_HotSubItem.InternalMouseUp(objArg);
			}
		}
		else if (!bool_6)
		{
			if (class261_0 != null)
			{
				Class261 @class = class261_0;
				object containerControl = ContainerControl;
				@class.method_7((Control)((containerControl is Control) ? containerControl : null), objArg);
			}
			if (mouseEventHandler_1 != null)
			{
				mouseEventHandler_1.Invoke((object)this, objArg);
			}
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeMouseUp(this, objArg);
			}
			if (((int)objArg.get_Button() == 1048576 || ((int)objArg.get_Button() == 2097152 && IsOnContextMenu)) && DisplayRectangle.Contains(objArg.get_X(), objArg.get_Y()) && ((DisplayRectangle.Contains(point_0) && method_2()) || IsOnMenu))
			{
				RaiseClick(eEventSource.Mouse);
			}
		}
		else
		{
			BaseItem baseItem = ItemAtLocation(objArg.get_X(), objArg.get_Y());
			if (baseItem != null && baseItem != this)
			{
				baseItem.InternalMouseUp(objArg);
			}
		}
		point_0 = Point.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void InternalKeyDown(KeyEventArgs objArg)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		if (bool_6)
		{
			objArg.set_Handled(true);
			return;
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalKeyDown(objArg);
		}
		if (((int)objArg.get_KeyCode() == 13 || (int)objArg.get_KeyCode() == 13) && !IsOnMenuBar && ((!IsOnMenu && !ShowSubItems) || SubItems.Count <= 0) && method_2())
		{
			RaiseClick(eEventSource.Keyboard);
			objArg.set_Handled(true);
			if (GetOwner() is RibbonStrip || GetOwner() is RibbonBar)
			{
				((ItemControl)GetOwner()).ReleaseFocus();
				((ItemControl)GetOwner()).Boolean_3 = false;
			}
		}
	}

	protected virtual void LeaveHotSubItem(BaseItem newMouseOverItem)
	{
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			if (newMouseOverItem != null && m_HotSubItem.Expanded && (IsOnMenu || (ContainerControl is Bar && ((Bar)ContainerControl).BarType == eBarType.MenuBar)))
			{
				m_HotSubItem.Expanded = false;
			}
			m_HotSubItem = null;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public virtual void InternalMouseMove(MouseEventArgs objArg)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Invalid comparison between Unknown and I4
		if (bool_6 && (int)objArg.get_Button() == 1048576 && (Math.Abs(objArg.get_X() - point_0.X) >= 2 || Math.Abs(objArg.get_Y() - point_0.Y) >= 2))
		{
			BaseItem baseItem = FocusedItem();
			if (baseItem != null && baseItem.CanCustomize)
			{
				if (!baseItem.SystemItem && GetOwner() is IOwner owner)
				{
					owner.StartItemDrag(baseItem);
				}
			}
			else if (!m_IsContainer && !SystemItem && bool_0 && GetOwner() is IOwner owner2)
			{
				owner2.StartItemDrag(this);
			}
		}
		else if (m_IsContainer && !bool_6)
		{
			BaseItem baseItem2 = ItemAtLocation(objArg.get_X(), objArg.get_Y());
			if (baseItem2 != m_HotSubItem && ((int)objArg.get_Button() == 0 || m_HotSubItem == null || m_CheckMouseMovePressed) && (m_HotSubItem == null || !m_HotSubItem.bool_16 || (int)objArg.get_Button() != 1048576))
			{
				LeaveHotSubItem(baseItem2);
				if (baseItem2 != null)
				{
					if (m_AutoExpand)
					{
						BaseItem baseItem3 = ExpandedItem();
						if (baseItem3 != null && baseItem3 != baseItem2)
						{
							baseItem3.Expanded = false;
						}
					}
					if (baseItem2 != this)
					{
						baseItem2.InternalMouseEnter();
						baseItem2.InternalMouseMove(objArg);
						if (m_AutoExpand && baseItem2.ShowSubItems && baseItem2.method_2())
						{
							if (baseItem2 is PopupItem)
							{
								PopupItem popupItem = baseItem2 as PopupItem;
								ePopupAnimation popupAnimation = popupItem.PopupAnimation;
								popupItem.PopupAnimation = ePopupAnimation.None;
								if (baseItem2.SubItems.Count > 0)
								{
									baseItem2.Expanded = true;
								}
								popupItem.PopupAnimation = popupAnimation;
							}
							else
							{
								baseItem2.Expanded = true;
							}
						}
						m_HotSubItem = baseItem2;
					}
				}
				else
				{
					m_HotSubItem = null;
				}
				if (mouseEventHandler_2 != null)
				{
					mouseEventHandler_2.Invoke((object)this, objArg);
				}
			}
			else if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseMove(objArg);
			}
			else
			{
				if (class261_0 != null)
				{
					Class261 @class = class261_0;
					object containerControl = ContainerControl;
					@class.method_5((Control)((containerControl is Control) ? containerControl : null), objArg);
				}
				if (mouseEventHandler_2 != null)
				{
					mouseEventHandler_2.Invoke((object)this, objArg);
				}
				IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
				if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
				{
					iOwnerItemEvents.InvokeMouseMove(this, objArg);
				}
			}
		}
		else if (!bool_6)
		{
			if (class261_0 != null)
			{
				Class261 class2 = class261_0;
				object containerControl2 = ContainerControl;
				class2.method_5((Control)((containerControl2 is Control) ? containerControl2 : null), objArg);
			}
			if (mouseEventHandler_2 != null)
			{
				mouseEventHandler_2.Invoke((object)this, objArg);
			}
			IOwnerItemEvents iOwnerItemEvents2 = GetIOwnerItemEvents();
			if (iOwnerItemEvents2 != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents2.InvokeMouseMove(this, objArg);
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void InternalClick(MouseButtons mb, Point mpos)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalClick(mb, mpos);
		}
		else if (class261_0 != null)
		{
			Class261 @class = class261_0;
			object containerControl = ContainerControl;
			@class.method_8((Control)((containerControl is Control) ? containerControl : null));
		}
	}

	public virtual void RaiseClick(eEventSource source)
	{
		if (!Boolean_0)
		{
			return;
		}
		IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
		BaseItem baseItem_ = BaseItem_0;
		if (bool_8)
		{
			if ((!SystemItem || (SystemItem && Name.StartsWith("mdi-"))) && IsOnPopup(this) && (m_Parent == null || !m_Parent.SystemItem || m_Parent is DisplayMoreItem) && (!(this is PopupItem) || !((PopupItem)this).ShowSubItems || (SubItems.Count <= 0 && ((PopupItem)this).PopupType != ePopupType.Container)))
			{
				CollapseAll(this);
			}
			if (m_Parent != null && m_Parent.AutoExpand && SubItems.Count == 0)
			{
				m_Parent.AutoExpand = false;
			}
		}
		if (bool_19)
		{
			return;
		}
		bool_19 = true;
		try
		{
			OnClick();
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
			}
			if (baseItem_ != null && baseItem_.ContainerControl is Bar bar)
			{
				bar.method_69(this, new EventArgs());
			}
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeItemClick(this);
			}
		}
		finally
		{
			bool_19 = false;
		}
	}

	public virtual void RaiseClick()
	{
		RaiseClick(eEventSource.Code);
	}

	internal void method_5()
	{
		eventHandler_0 = null;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void InternalDoubleClick(MouseButtons mb, Point mpos)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalDoubleClick(mb, mpos);
		}
		else
		{
			InvokeDoubleClick();
		}
	}

	protected virtual void InvokeDoubleClick()
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
	}

	protected internal virtual void OnGotFocus()
	{
		bool_2 = true;
		if (!bool_6)
		{
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeGotFocus(this, new EventArgs());
			}
		}
		Refresh();
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, new EventArgs());
		}
	}

	protected internal virtual void OnLostFocus()
	{
		if (IsDisposed)
		{
			return;
		}
		if (!bool_6)
		{
			IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
			if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
			{
				iOwnerItemEvents.InvokeLostFocus(this, new EventArgs());
			}
		}
		else
		{
			InternalMouseLeave();
		}
		bool_2 = false;
		Refresh();
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, new EventArgs());
		}
	}

	public virtual void Focus()
	{
		if (IsOnPopup(this) && ContainerControl is MenuPanel menuPanel && menuPanel.ParentItem.Parent == null)
		{
			menuPanel.method_15(this);
			return;
		}
		if (GetOwner() is IOwner owner)
		{
			owner.SetFocusItem(this);
		}
		else
		{
			OnGotFocus();
		}
		if (Parent != null)
		{
			Parent.OnSubItemGotFocus(this);
		}
	}

	public virtual void ReleaseFocus()
	{
		if (!bool_2)
		{
			return;
		}
		if (IsOnPopup(this) && ContainerControl is MenuPanel menuPanel && menuPanel.ParentItem.Parent == null)
		{
			menuPanel.method_15(null);
			return;
		}
		if (GetOwner() is IOwner owner)
		{
			owner.SetFocusItem(null);
		}
		else
		{
			OnLostFocus();
		}
		if (Parent != null)
		{
			Parent.OnSubItemLostFocus(this);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void ContainerLostFocus(bool appLostFocus)
	{
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				subItem.ContainerLostFocus(appLostFocus);
			}
		}
		if (m_HotSubItem != null)
		{
			bool flag = true;
			if (!appLostFocus)
			{
				object containerControl = ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val != null)
				{
					Point pt = val.PointToClient(Control.get_MousePosition());
					if (m_HotSubItem.DisplayRectangle.Contains(pt))
					{
						flag = false;
					}
				}
			}
			if (flag)
			{
				m_HotSubItem.InternalMouseLeave();
				m_HotSubItem = null;
			}
		}
		if (Focused && GetOwner() is IOwner owner)
		{
			owner.SetFocusItem(null);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void ContainerGotFocus()
	{
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			subItem.ContainerGotFocus();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void SubItemSizeChanged(BaseItem objChildItem)
	{
	}

	public virtual BaseItem ItemAtLocation(int x, int y)
	{
		if (!m_IsContainer)
		{
			return null;
		}
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				if ((subItem.Visible || bool_4) && subItem.Displayed && subItem.DisplayRectangle.Contains(x, y))
				{
					return subItem;
				}
			}
		}
		return null;
	}

	protected internal virtual BaseItem ExpandedItem()
	{
		if (!m_IsContainer)
		{
			return null;
		}
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				if (!(subItem is GalleryContainer) || !((GalleryContainer)subItem).IsGalleryPopupOpen)
				{
					if (subItem is ItemContainer)
					{
						BaseItem baseItem2 = subItem.ExpandedItem();
						if (baseItem2 != null)
						{
							return baseItem2;
						}
					}
					else if (subItem.Expanded)
					{
						return subItem;
					}
					continue;
				}
				return subItem;
			}
		}
		return null;
	}

	protected internal BaseItem FocusedItem()
	{
		if (!m_IsContainer)
		{
			return null;
		}
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				if (!subItem.Focused)
				{
					if (subItem.IsContainer)
					{
						BaseItem baseItem2 = subItem.FocusedItem();
						if (baseItem2 != null)
						{
							return baseItem2;
						}
					}
					continue;
				}
				return subItem;
			}
		}
		return null;
	}

	public object GetOwner()
	{
		if (object_0 != null)
		{
			return object_0;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val is Bar)
		{
			return ((Bar)(object)val).Owner;
		}
		if (val is MenuPanel)
		{
			return ((MenuPanel)(object)val).Owner;
		}
		if (m_Parent != null)
		{
			return m_Parent.GetOwner();
		}
		return null;
	}

	protected internal IOwnerItemEvents GetIOwnerItemEvents()
	{
		return GetOwner() as IOwnerItemEvents;
	}

	internal void method_6(object object_2)
	{
		if (object_0 != object_2)
		{
			object_0 = object_2;
			OnOwnerChanged();
		}
	}

	public virtual void RecalcSize()
	{
		m_NeedRecalcSize = false;
	}

	public abstract void Paint(ItemPaintArgs p);

	public abstract BaseItem Copy();

	protected virtual void CopyToItem(BaseItem objCopy)
	{
		objCopy.Visible = m_Visible;
		objCopy.SetIsContainer(m_IsContainer);
		objCopy.AutoExpand = m_AutoExpand;
		objCopy.BeginGroup = m_BeginGroup;
		objCopy.Enabled = m_Enabled;
		objCopy.Description = m_Description;
		objCopy.Tooltip = m_Tooltip;
		objCopy.Category = m_Category;
		objCopy.Orientation = m_Orientation;
		objCopy.Text = m_Text;
		objCopy.Name = m_Name;
		objCopy.GlobalName = string_0;
		objCopy.GlobalItem = bool_11;
		objCopy.Style = m_Style;
		objCopy.SetDesignMode(bool_6);
		objCopy.ShowSubItems = bool_1;
		objCopy.Stretch = bool_3;
		if (shortcutsCollection_0 != null && shortcutsCollection_0.Count > 0)
		{
			objCopy.Shortcuts.FromString(shortcutsCollection_0.ToString(","), ",");
		}
		objCopy.eventHandler_0 = eventHandler_0;
		objCopy.eventHandler_2 = eventHandler_2;
		objCopy.eventHandler_3 = eventHandler_3;
		objCopy.eventHandler_4 = eventHandler_4;
		objCopy.mouseEventHandler_0 = mouseEventHandler_0;
		objCopy.eventHandler_5 = eventHandler_5;
		objCopy.eventHandler_7 = eventHandler_7;
		objCopy.eventHandler_6 = eventHandler_6;
		objCopy.mouseEventHandler_2 = mouseEventHandler_2;
		objCopy.mouseEventHandler_1 = mouseEventHandler_1;
		objCopy.eventHandler_10 = eventHandler_10;
		objCopy.eventHandler_11 = eventHandler_11;
		objCopy.eventHandler_9 = eventHandler_9;
		objCopy.IsRightToLeft = IsRightToLeft;
		objCopy.Cursor = cursor_0;
		objCopy.ThemeAware = m_ThemeAware;
		objCopy.AutoCollapseOnClick = AutoCollapseOnClick;
		objCopy.Tag = m_ItemData;
		objCopy.CanCustomize = bool_0;
		objCopy.Command = Command;
		objCopy.CommandParameter = CommandParameter;
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				objCopy.SubItems.Add(subItem.Copy());
			}
		}
		if (eventHandler_8 != null)
		{
			eventHandler_8(objCopy, new EventArgs());
		}
	}

	public object Clone()
	{
		return Copy();
	}

	public virtual void Refresh()
	{
		if (bool_9 || (!m_Visible && !bool_4) || !m_Displayed)
		{
			return;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == null || !IsHandleValid(val) || val is Class83)
		{
			return;
		}
		if (m_NeedRecalcSize)
		{
			if (m_Parent is ItemContainer)
			{
				m_Parent.RecalcSize();
			}
			else
			{
				RecalcSize();
				if (m_Parent != null)
				{
					m_Parent.SubItemSizeChanged(this);
				}
			}
		}
		Invalidate(val);
	}

	protected virtual void Invalidate(Control containerControl)
	{
		containerControl.Invalidate(m_Rect, true);
	}

	protected internal void OnAppearanceChanged()
	{
		if (bool_20 || !DesignMode)
		{
			return;
		}
		bool_20 = true;
		try
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				Class109.smethod_2(val, bool_3: true);
			}
		}
		finally
		{
			bool_20 = false;
		}
	}

	protected internal virtual void OnExpandChange()
	{
		HideToolTip();
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, new EventArgs());
		}
		IOwnerItemEvents iOwnerItemEvents = GetIOwnerItemEvents();
		if (iOwnerItemEvents != null && !SystemItem && !IsOnCustomizeMenu && !IsOnCustomizeDialog)
		{
			iOwnerItemEvents.InvokeExpandedChange(this, new EventArgs());
		}
	}

	protected internal virtual void OnSubItemExpandChange(BaseItem item)
	{
	}

	public virtual void Dispose()
	{
		if (m_Expanded && ((isite_0 != null && !isite_0.DesignMode) || isite_0 == null))
		{
			Expanded = false;
		}
		HideToolTip();
		if (m_Parent != null)
		{
			m_Parent = null;
		}
		if (GetOwner() is IOwner owner)
		{
			owner.RemoveShortcutsFromItem(this);
		}
		if (isite_0 == null || (isite_0 != null && !isite_0.DesignMode))
		{
			if (m_SubItems != null && m_SubItems.Count > 0)
			{
				ArrayList arrayList = new ArrayList(m_SubItems.Count);
				m_SubItems.method_4(arrayList);
				foreach (BaseItem item in arrayList)
				{
					if (item.Parent == this)
					{
						item.Dispose();
					}
				}
				m_SubItems.method_2();
			}
			m_SubItems = null;
		}
		if (eventHandler_12 != null)
		{
			eventHandler_12(this, EventArgs.Empty);
		}
		if (isite_0 == null || (isite_0 != null && !isite_0.DesignMode))
		{
			if (shortcutsCollection_0 != null)
			{
				shortcutsCollection_0 = null;
			}
			m_ContainerControl = null;
		}
		if (icommand_0 != null)
		{
			Command = null;
		}
		bool_18 = true;
	}

	protected virtual void OnStyleChanged()
	{
	}

	protected virtual void OnTextChanged()
	{
		method_15();
		if (eventHandler_9 != null)
		{
			eventHandler_9(this, new EventArgs());
		}
		GetIOwnerItemEvents()?.InvokeItemTextChanged(this, new EventArgs());
		method_13((AccessibleEvents)32780);
		OnAppearanceChanged();
	}

	protected internal static bool IsHandleValid(Control objCtrl)
	{
		if (objCtrl != null && !objCtrl.get_Disposing() && !objCtrl.get_IsDisposed())
		{
			return objCtrl.get_IsHandleCreated();
		}
		return false;
	}

	protected virtual void ResetHover()
	{
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (IsHandleValid(val))
		{
			Class92.TRACKMOUSEEVENT tme = default(Class92.TRACKMOUSEEVENT);
			tme.dwFlags = 1073741824u;
			tme.hwndTrack = val.get_Handle();
			tme.cbSize = Marshal.SizeOf((object)tme);
			Class92.TrackMouseEvent(ref tme);
			tme.dwFlags |= 1u;
			Class92.TrackMouseEvent(ref tme);
			val = null;
		}
	}

	protected internal virtual bool IsAnyOnHandle(int iHandle)
	{
		bool result = false;
		if (m_SubItems != null && m_SubItems.Count != 0)
		{
			BaseItem baseItem = m_SubItems[0];
			Control val = null;
			if (baseItem != null)
			{
				object containerControl = baseItem.ContainerControl;
				val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is MenuPanel && ((MenuPanel)(object)val).PopupMenu)
				{
					val = val.get_Parent();
				}
				if (val != null && val.get_Handle().ToInt32() == iHandle)
				{
					return true;
				}
				baseItem = null;
			}
			{
				foreach (BaseItem subItem in m_SubItems)
				{
					if (subItem.Expanded && subItem.IsAnyOnHandle(iHandle))
					{
						return true;
					}
				}
				return result;
			}
		}
		return result;
	}

	protected virtual void OnTooltipChanged()
	{
	}

	internal void method_7(eOrientation eOrientation_0)
	{
		if (m_Orientation == eOrientation_0)
		{
			return;
		}
		m_Orientation = eOrientation_0;
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				subItem.Orientation = m_Orientation;
			}
		}
		m_NeedRecalcSize = true;
	}

	protected internal void HideToolTip()
	{
		if (m_ToolTipWnd == null)
		{
			return;
		}
		Rectangle bounds = ((Control)m_ToolTipWnd).get_Bounds();
		bounds.Width += 5;
		bounds.Height += 6;
		OnTooltip(bShow: false);
		method_8(new EventArgs());
		try
		{
			if (m_ToolTipWnd != null)
			{
				((Control)m_ToolTipWnd).Hide();
				((Component)(object)m_ToolTipWnd).Dispose();
				m_ToolTipWnd = null;
			}
		}
		catch
		{
		}
		if (ContainerControl != null)
		{
			object containerControl = ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val != null)
			{
				val.Invalidate(val.RectangleToClient(bounds), false);
			}
		}
	}

	private void method_8(EventArgs eventArgs_0)
	{
		EventHandler eventHandler = eventHandler_13;
		if (eventHandler != null)
		{
			eventHandler_13(this, eventArgs_0);
		}
	}

	public virtual void ShowToolTip()
	{
		if (bool_6 || !m_Visible || !m_Displayed || m_Expanded)
		{
			return;
		}
		IOwner owner = GetOwner() as IOwner;
		if ((owner != null && !owner.ShowToolTips) || !ShowToolTips)
		{
			return;
		}
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if ((val is Bar && !((Bar)(object)val).ShowToolTips) || (val is MenuPanel && !((MenuPanel)(object)val).ShowToolTips))
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
			m_ToolTipWnd.Style = m_Style;
			m_ToolTipWnd.Text = m_Tooltip;
			if (owner != null && owner.ShowShortcutKeysInToolTips && shortcutsCollection_0 != null && shortcutsCollection_0.Count > 0)
			{
				ToolTip toolTipWnd = m_ToolTipWnd;
				toolTipWnd.Text = toolTipWnd.Text + " (" + ShortcutString + ")";
			}
			GetIOwnerItemEvents()?.InvokeToolTipShowing(this, new EventArgs());
			m_ToolTipWnd.ReferenceRectangle = Rectangle_0;
			method_8(new EventArgs());
			m_ToolTipWnd.ShowToolTip();
		}
	}

	internal void method_9(bool bool_22)
	{
		if (bool_4 != bool_22)
		{
			bool_4 = bool_22;
			OnIsOnCustomizeMenuChanged();
		}
	}

	public override string ToString()
	{
		return m_Text;
	}

	internal void method_10(bool bool_22)
	{
		if (bool_5 != bool_22)
		{
			bool_5 = bool_22;
			OnIsOnCustomizeDialogChanged();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void SetDesignMode(bool b)
	{
		if (bool_6 == b)
		{
			return;
		}
		bool_6 = b;
		if (m_SubItems != null)
		{
			foreach (BaseItem subItem in m_SubItems)
			{
				subItem.SetDesignMode(bool_6);
			}
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			m_HotSubItem = null;
		}
		OnDesignModeChanged();
	}

	internal void method_11(bool bool_22)
	{
		m_SystemItem = bool_22;
	}

	internal void method_12()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		string_1 = "";
		if (shortcutsCollection_0 != null && shortcutsCollection_0.Count != 0)
		{
			KeysConverter val = new KeysConverter();
			string_1 = ((TypeConverter)(object)val).ConvertToString((object)(Keys)shortcutsCollection_0[0]);
		}
	}

	public static void CollapseSubItems(BaseItem item)
	{
		if (item == null && item.SubItems.Count == 0)
		{
			return;
		}
		BaseItem[] array = new BaseItem[item.SubItems.Count];
		item.SubItems.CopyTo(array, 0);
		BaseItem[] array2 = array;
		foreach (BaseItem baseItem in array2)
		{
			if (baseItem.Expanded)
			{
				baseItem.Expanded = false;
			}
		}
	}

	public static void CollapseAll(BaseItem objItem)
	{
		if (objItem == null)
		{
			return;
		}
		do
		{
			object containerControl = objItem.ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (!(val is MenuPanel))
			{
				if (val is Bar)
				{
					if (((Bar)(object)val).BaseItem_0 == null)
					{
						break;
					}
					objItem = ((Bar)(object)val).ParentItem;
				}
				else if (objItem.Parent != null)
				{
					objItem = objItem.Parent;
				}
			}
			else if (objItem.Parent != null)
			{
				objItem = objItem.Parent;
			}
		}
		while (objItem != null && objItem.Parent != null);
		if (objItem != null)
		{
			objItem.Expanded = false;
			objItem.AutoExpand = false;
			if (objItem.Parent != null)
			{
				objItem.Parent.AutoExpand = false;
			}
		}
	}

	public static bool IsOnPopup(BaseItem item)
	{
		if (item == null)
		{
			return false;
		}
		object containerControl = item.ContainerControl;
		if (containerControl == null)
		{
			return false;
		}
		if (containerControl is MenuPanel)
		{
			return true;
		}
		if (containerControl is Bar && ((Bar)containerControl).BarState == eBarState.Popup)
		{
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return int_0;
	}

	protected internal void DrawInsertMarker(Graphics g)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		IOwner owner = GetOwner() as IOwner;
		if (enum9_0 == Enum9.const_0 || !Visible || !Displayed || ((owner == null || !owner.DragInProgress) && !DesignMode))
		{
			return;
		}
		Color color = ColorScheme.GetColor("834DD5");
		Color color2 = ColorScheme.GetColor("CCCFF8");
		int num = 4;
		int num2 = 1;
		int num3 = 2;
		if (Boolean_1)
		{
			Point point = new Point(m_Rect.X, m_Rect.Y + num3);
			Point point2 = new Point(m_Rect.X, m_Rect.Bottom - (num3 + 1));
			if (enum9_0 == Enum9.const_2)
			{
				point = new Point(m_Rect.Right - num * 2, m_Rect.Y + num3);
				point2 = new Point(m_Rect.Right - num * 2, m_Rect.Bottom - (num3 + 1));
			}
			SolidBrush val = new SolidBrush(color2);
			try
			{
				Pen val2 = new Pen(color, 1f);
				try
				{
					GraphicsPath val3 = new GraphicsPath();
					try
					{
						val3.AddLine(point.X, point.Y + num, point.X + num, point.Y);
						val3.AddLine(point.X + num * 2, point.Y + num, point.X + (num * 2 - (num - num2)), point.Y + num);
						val3.AddLine(point2.X + (num * 2 - (num - num2)), point2.Y - num, point2.X + num * 2, point2.Y - num);
						val3.AddLine(point2.X + num, point2.Y, point2.X, point2.Y - num);
						val3.AddLine(point2.X + (num - num2), point2.Y - num, point.X + (num - num2), point.Y + num);
						val3.CloseAllFigures();
						g.FillPath((Brush)(object)val, val3);
						g.DrawPath(val2, val3);
						return;
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		Point point3 = new Point(m_Rect.X + num3, m_Rect.Y);
		Point point4 = new Point(m_Rect.Right - (num3 + 1), m_Rect.Y);
		if (enum9_0 == Enum9.const_2)
		{
			point3 = new Point(m_Rect.X + num3, m_Rect.Bottom - (num * 2 + 1));
			point4 = new Point(m_Rect.Right - (num3 + 1), m_Rect.Bottom - (num * 2 + 1));
		}
		SolidBrush val4 = new SolidBrush(color2);
		try
		{
			Pen val5 = new Pen(color, 1f);
			try
			{
				GraphicsPath val6 = new GraphicsPath();
				try
				{
					val6.AddLine(point3.X, point3.Y + num, point3.X + num, point3.Y);
					val6.AddLine(point3.X + num, point3.Y + (num - num2), point4.X - num, point4.Y + (num - num2));
					val6.AddLine(point4.X - num, point4.Y, point4.X, point4.Y + num);
					val6.AddLine(point4.X - num, point4.Y + num * 2, point4.X - num, point4.Y + (num * 2 - (num - num3)));
					val6.AddLine(point3.X + num, point3.Y + (num * 2 - (num - num3)), point3.X + num, point3.Y + num * 2);
					val6.CloseAllFigures();
					g.FillPath((Brush)(object)val4, val6);
					g.DrawPath(val5, val6);
				}
				finally
				{
					((IDisposable)val6)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val4)?.Dispose();
		}
	}

	protected virtual void OnSiteChanged()
	{
	}

	protected virtual AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new ItemAccessibleObject(this);
	}

	internal void method_13(AccessibleEvents accessibleEvents_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (ContainerControl is Bar && ((Bar)ContainerControl).bool_29 && ((Control)(Bar)ContainerControl).get_AccessibilityObject() is Bar.BarAccessibleObject barAccessibleObject)
		{
			barAccessibleObject.method_0(this, accessibleEvents_0);
		}
	}

	internal virtual void vmethod_0()
	{
		if (VisibleSubItems > 0 && (IsOnMenu || IsOnMenuBar || bool_21))
		{
			if (Expanded)
			{
				Expanded = false;
				if (Parent != null && IsOnMenuBar)
				{
					Parent.AutoExpand = false;
				}
			}
			else
			{
				if (IsOnMenuBar && Parent != null)
				{
					Parent.AutoExpand = true;
				}
				Expanded = true;
			}
			Refresh();
			bool_21 = false;
		}
		else
		{
			RaiseClick(eEventSource.Keyboard);
		}
	}

	protected virtual void ExecuteCommand()
	{
		if (icommand_0 != null)
		{
			CommandManager.smethod_0(this);
		}
	}

	internal void method_14()
	{
		ExecuteCommand();
	}

	protected virtual void OnCommandChanged()
	{
	}

	private void method_15()
	{
		class261_0 = null;
		if (IsMarkupSupported && Class243.smethod_2(ref m_Text))
		{
			class261_0 = Class243.smethod_0(m_Text);
			if (class261_0 != null)
			{
				class261_0.Event_0 += TextMarkupLinkClick;
			}
		}
	}

	protected virtual void TextMarkupLinkClick(object sender, EventArgs e)
	{
	}

	internal void method_16()
	{
		if (controlBindingsCollection_0 != null)
		{
			BindingContext bindingContext = BindingContext;
			for (int i = 0; i < ((BaseCollection)controlBindingsCollection_0).get_Count(); i++)
			{
				BindingContext.UpdateBinding(bindingContext, ((BindingsCollection)controlBindingsCollection_0).get_Item(i));
			}
		}
		if (m_SubItems == null)
		{
			return;
		}
		foreach (BaseItem subItem in m_SubItems)
		{
			subItem.method_16();
		}
	}
}
