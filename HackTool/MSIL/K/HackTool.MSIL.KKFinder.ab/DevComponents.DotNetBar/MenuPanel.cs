using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
public class MenuPanel : Control, Interface0, IAccessibilitySupport, IDesignTimeProvider, IKeyTipsControl
{
	private class Class202
	{
		public LinearGradientColorTable linearGradientColorTable_0 = new LinearGradientColorTable();

		public LinearGradientColorTable linearGradientColorTable_1 = new LinearGradientColorTable();

		public LinearGradientColorTable linearGradientColorTable_2 = new LinearGradientColorTable();

		public LinearGradientColorTable linearGradientColorTable_3 = new LinearGradientColorTable();

		public LinearGradientColorTable linearGradientColorTable_4 = new LinearGradientColorTable();

		public LinearGradientColorTable linearGradientColorTable_5 = new LinearGradientColorTable();
	}

	public class PopupMenuAccessibleObject : ControlAccessibleObject
	{
		private MenuPanel menuPanel_0;

		public override string Name
		{
			get
			{
				if (menuPanel_0 == null)
				{
					return "";
				}
				return ((Control)menuPanel_0).get_AccessibleName();
			}
			set
			{
				if (menuPanel_0 != null)
				{
					((Control)menuPanel_0).set_AccessibleName(value);
				}
			}
		}

		public override string Description
		{
			get
			{
				if (menuPanel_0 == null)
				{
					return "";
				}
				return ((Control)menuPanel_0).get_AccessibleDescription();
			}
		}

		public override AccessibleRole Role
		{
			get
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				if (menuPanel_0 == null)
				{
					return (AccessibleRole)0;
				}
				return ((Control)menuPanel_0).get_AccessibleRole();
			}
		}

		public override AccessibleObject Parent
		{
			get
			{
				if (menuPanel_0 == null)
				{
					return null;
				}
				return menuPanel_0.ParentItem.AccessibleObject;
			}
		}

		public override Rectangle Bounds
		{
			get
			{
				if (menuPanel_0 == null)
				{
					return Rectangle.Empty;
				}
				return ((Control)menuPanel_0).get_DisplayRectangle();
			}
		}

		public override AccessibleStates State
		{
			get
			{
				if (menuPanel_0 != null && !((Control)menuPanel_0).get_IsDisposed())
				{
					return (AccessibleStates)4096;
				}
				return (AccessibleStates)1;
			}
		}

		public PopupMenuAccessibleObject(MenuPanel owner)
			: base((Control)(object)owner)
		{
			menuPanel_0 = owner;
		}

		internal void method_0(BaseItem baseItem_0, AccessibleEvents accessibleEvents_0)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			if (menuPanel_0 != null && menuPanel_0 != null && menuPanel_0.m_ParentItem != null)
			{
				int num = menuPanel_0.m_ParentItem.SubItems.IndexOf(baseItem_0);
				if (num >= 0)
				{
					((Control)menuPanel_0).AccessibilityNotifyClients(accessibleEvents_0, num);
				}
			}
		}

		internal void method_1(AccessibleEvents accessibleEvents_0)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			if (menuPanel_0 != null)
			{
				((Control)menuPanel_0).AccessibilityNotifyClients(accessibleEvents_0, -1);
			}
		}

		public override int GetChildCount()
		{
			if (menuPanel_0 != null && menuPanel_0.m_ParentItem != null)
			{
				return menuPanel_0.m_ParentItem.SubItems.Count;
			}
			return 0;
		}

		public override AccessibleObject GetChild(int iIndex)
		{
			if (menuPanel_0 != null && menuPanel_0.m_ParentItem != null)
			{
				return menuPanel_0.m_ParentItem.SubItems[iIndex].AccessibleObject;
			}
			return null;
		}

		public override void Select(AccessibleSelection flags)
		{
		}

		public override void DoDefaultAction()
		{
		}
	}

	private struct Struct18
	{
		public bool bool_0;

		public bool bool_1;

		public Rectangle rectangle_0;

		public bool bool_2;

		public Struct18(bool personalizedallvisible, bool showexpandbutton, Rectangle rExpandButton, bool mouseover)
		{
			bool_0 = personalizedallvisible;
			bool_1 = showexpandbutton;
			rectangle_0 = rExpandButton;
			bool_2 = mouseover;
		}
	}

	private const int int_0 = 33;

	private const int int_1 = 3;

	private const int int_2 = 4;

	private const int int_3 = 16;

	private const int int_4 = 3;

	private const int int_5 = 9;

	private const int int_6 = 14;

	private const int int_7 = 18;

	protected BaseItem m_ParentItem;

	protected BaseItem m_HotSubItem;

	protected Point m_ParentItemScreenPos;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private int int_8;

	private int int_9;

	private int int_10;

	private Rectangle rectangle_0;

	private SideBarImage sideBarImage_0;

	private Rectangle rectangle_1;

	private object object_0;

	private bool bool_4;

	private Point point_0;

	private ePersonalizedMenus ePersonalizedMenus_0;

	private int int_11 = 14;

	private Struct18 struct18_0 = new Struct18(personalizedallvisible: false, showexpandbutton: false, Rectangle.Empty, mouseover: false);

	private Timer timer_0;

	private ePopupAnimation ePopupAnimation_0 = ePopupAnimation.ManagerControlled;

	private Control8 control8_0;

	private ColorScheme colorScheme_0;

	private bool bool_5;

	private MouseEventArgs mouseEventArgs_0;

	internal bool bool_6;

	private bool bool_7 = true;

	private bool bool_8 = true;

	private BaseItem baseItem_0;

	private bool bool_9 = true;

	private bool bool_10;

	private int int_12 = 3;

	private BaseItem baseItem_1;

	internal bool bool_11;

	private bool bool_12;

	private string string_0 = "";

	private Font font_0;

	private Control1 control1_0;

	private bool bool_13;

	private int int_13 = -1;

	private bool bool_14;

	private IDesignTimeProvider idesignTimeProvider_0;

	private BaseItem baseItem_2;

	private IDesignTimeProvider idesignTimeProvider_1;

	private bool bool_15;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool ShowKeyTips
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
				OnShowKeyTipsChanged();
			}
		}
	}

	string IKeyTipsControl.KeyTipsKeysStack
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			if (control1_0 != null)
			{
				((Control)this).Refresh();
			}
		}
	}

	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates font that is used to display Key Tips (accelerator keys) when they are displayed.")]
	public virtual Font KeyTipsFont
	{
		get
		{
			return font_0;
		}
		set
		{
			font_0 = value;
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

	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool PopupMenu
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

	private bool Boolean_0
	{
		get
		{
			if (m_ParentItem != null && m_ParentItem.SubItems.Count == 1 && m_ParentItem.SubItems[0] is ItemContainer)
			{
				return true;
			}
			return false;
		}
	}

	private bool Boolean_1
	{
		get
		{
			if (m_ParentItem != null)
			{
				if (m_ParentItem.Style != 0 && m_ParentItem.Style != eDotNetBarStyle.Office2003 && m_ParentItem.Style != eDotNetBarStyle.VS2005)
				{
					return Class109.smethod_69(m_ParentItem.Style);
				}
				return true;
			}
			return true;
		}
	}

	public BaseItem ParentItem
	{
		get
		{
			return m_ParentItem;
		}
		set
		{
			method_13();
			m_ParentItem = value;
			if (m_ParentItem != null && m_ParentItem.SubItems.Count != 0)
			{
				if (m_ParentItem.Style != eDotNetBarStyle.Office2003 && m_ParentItem.Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(m_ParentItem.Style))
				{
					int_11 = 14;
				}
				else
				{
					int_11 = 18;
				}
				if (m_ParentItem.SubItems.Count > 0)
				{
					m_ParentItem.SubItems[0].ContainerControl = this;
				}
				for (int i = 1; i < m_ParentItem.SubItems.Count; i++)
				{
					m_ParentItem.SubItems[i].ContainerControl = this;
				}
				object containerControl = m_ParentItem.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (m_ParentItem.Displayed && BaseItem.IsHandleValid(val))
				{
					m_ParentItemScreenPos = val.PointToScreen(new Point(m_ParentItem.LeftInternal, m_ParentItem.TopInternal));
					val = null;
				}
				if (val is ItemControl)
				{
					bool_10 = ((ItemControl)(object)val).AntiAlias;
				}
			}
		}
	}

	private bool Boolean_2
	{
		get
		{
			if (m_ParentItem != null)
			{
				BaseItem baseItem = m_ParentItem;
				while (baseItem.Parent != null)
				{
					baseItem = baseItem.Parent;
				}
				object containerControl = baseItem.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is RibbonStrip || val is RibbonBar || (val is ContextMenuBar && ((ContextMenuBar)(object)val).Style == eDotNetBarStyle.Office2007))
				{
					return true;
				}
			}
			return false;
		}
	}

	private bool Boolean_3
	{
		get
		{
			if (m_ParentItem == null)
			{
				return false;
			}
			if (m_ParentItem.Parent != null && !(m_ParentItem.ContainerControl is ContextMenuBar))
			{
				BaseItem parent = m_ParentItem.Parent;
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				if (parent is PopupItem)
				{
					return true;
				}
				return false;
			}
			return true;
		}
	}

	private int Int32_0
	{
		get
		{
			int num = 0;
			if (m_ParentItem != null && Boolean_1)
			{
				num = 1;
				if (Class109.smethod_69(m_ParentItem.Style))
				{
					num++;
				}
				if (Boolean_0)
				{
					num--;
				}
			}
			else
			{
				num = 3;
			}
			return num;
		}
	}

	private int Int32_1
	{
		get
		{
			int num = 0;
			num = ((m_ParentItem == null || !Boolean_1) ? 3 : 2);
			if (Boolean_0)
			{
				num--;
			}
			return num;
		}
	}

	private int Int32_2
	{
		get
		{
			bool flag = true;
			int num = 0;
			if (object_0 is IOwnerMenuSupport ownerMenuSupport && !ownerMenuSupport.ShowPopupShadow)
			{
				flag = false;
			}
			if (m_ParentItem != null && Boolean_1)
			{
				num = ((Boolean_5 || !flag) ? 1 : 3);
				if (Class109.smethod_69(m_ParentItem.Style))
				{
					num++;
				}
				if (Boolean_0)
				{
					num--;
				}
			}
			else
			{
				num = 3;
			}
			return num;
		}
	}

	private int Int32_3
	{
		get
		{
			IOwnerMenuSupport ownerMenuSupport = object_0 as IOwnerMenuSupport;
			bool flag = true;
			int num = 0;
			if (ownerMenuSupport != null && !ownerMenuSupport.ShowPopupShadow)
			{
				flag = false;
			}
			if (m_ParentItem != null && Boolean_1)
			{
				num = ((Boolean_5 || !flag) ? 2 : 4);
				if (Boolean_0)
				{
					num--;
				}
			}
			else
			{
				num = 3;
			}
			return num;
		}
	}

	internal bool Boolean_4
	{
		get
		{
			if (bool_7 && (m_ParentItem == null || m_ParentItem.Site == null || !m_ParentItem.Site.DesignMode))
			{
				if (object_0 is IOwnerMenuSupport ownerMenuSupport)
				{
					if (m_ParentItem != null && m_ParentItem.Style == eDotNetBarStyle.Office2000)
					{
						if (ownerMenuSupport.MenuDropShadow == eMenuDropShadow.Show)
						{
							return true;
						}
						return false;
					}
					return ownerMenuSupport.ShowPopupShadow;
				}
				if (m_ParentItem != null && m_ParentItem.Style == eDotNetBarStyle.Office2000)
				{
					return false;
				}
				return true;
			}
			return false;
		}
	}

	[Description("Gets or sets whether anti-aliasing is used while painting.")]
	[DefaultValue(false)]
	[Category("Appearance")]
	[Browsable(true)]
	public bool AntiAlias
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
		}
	}

	internal bool Boolean_5
	{
		get
		{
			if (Environment.OSVersion.Version.Major < 5)
			{
				return false;
			}
			if (object_0 is IOwnerMenuSupport ownerMenuSupport && !ownerMenuSupport.AlphaBlendShadow)
			{
				return false;
			}
			return true;
		}
	}

	[Browsable(true)]
	[Category("Run-time Behavior")]
	[Description("Indicates whether Tooltips are shown on Bar and it's sub-items.")]
	[DevCoBrowsable(true)]
	[DefaultValue(true)]
	public bool ShowToolTips
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

	public object Owner
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

	internal bool Boolean_6
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
			if (m_ParentItem == null)
			{
				return;
			}
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				subItem.method_9(bool_4);
			}
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates when menu items are displayed when MenuVisiblity is set to VisibleIfRecentlyUsed and RecentlyUsed is true.")]
	public ePersonalizedMenus PersonalizedMenus
	{
		get
		{
			return ePersonalizedMenus_0;
		}
		set
		{
			ePersonalizedMenus_0 = value;
		}
	}

	public bool PersonalizedAllVisible
	{
		get
		{
			return struct18_0.bool_0;
		}
		set
		{
			struct18_0.bool_0 = value;
		}
	}

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

	public ColorScheme ColorScheme
	{
		get
		{
			return colorScheme_0;
		}
		set
		{
			colorScheme_0 = value;
			if (((Control)this).get_Visible())
			{
				((Control)this).Refresh();
			}
		}
	}

	public BaseItem HotSubItem
	{
		get
		{
			return m_HotSubItem;
		}
		set
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseLeave();
			}
			m_HotSubItem = null;
			if (ParentItem.SubItems.Contains(value))
			{
				m_HotSubItem = value;
				if (m_HotSubItem != null)
				{
					m_HotSubItem.InternalMouseEnter();
					m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 1, m_HotSubItem.TopInternal + 1, 0));
				}
			}
		}
	}

	public MenuPanel()
	{
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		m_ParentItem = null;
		m_HotSubItem = null;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		int_8 = 0;
		int_9 = 0;
		int_10 = 0;
		rectangle_0 = default(Rectangle);
		rectangle_1 = default(Rectangle);
		sideBarImage_0 = default(SideBarImage);
		bool_4 = false;
		object_0 = null;
		_003F val = this;
		object obj = SystemInformation.get_MenuFont().Clone();
		((Control)val).set_Font((Font)((obj is Font) ? obj : null));
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).set_IsAccessible(true);
		((Control)this).set_AccessibleRole((AccessibleRole)11);
	}

	protected override void Dispose(bool disposing)
	{
		if (((Control)this).get_Parent() != null && ((Control)this).get_Parent() is PopupContainer)
		{
			Control parent = ((Control)this).get_Parent();
			((Control)this).get_Parent().get_Controls().Remove((Control)(object)this);
			((Component)(object)parent).Dispose();
			parent = null;
		}
		if (bool_6 && ((Control)this).get_AccessibilityObject() is PopupMenuAccessibleObject popupMenuAccessibleObject)
		{
			popupMenuAccessibleObject.method_1((AccessibleEvents)32769);
		}
		if (control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		method_13();
		m_ParentItem = null;
		((Control)this).Dispose(disposing);
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 33)
		{
			((Message)(ref m)).set_Result(new IntPtr(3));
			return;
		}
		if (((Message)(ref m)).get_Msg() == 1131 && baseItem_1 != null)
		{
			baseItem_1.vmethod_0();
			baseItem_1 = null;
		}
		((Control)this).WndProc(ref m);
	}

	private BaseRenderer method_0()
	{
		BaseRenderer result = GlobalManager.Renderer;
		if (m_ParentItem != null && m_ParentItem.method_0(bool_22: false) is IRenderingSupport)
		{
			BaseRenderer renderer = ((IRenderingSupport)m_ParentItem.method_0(bool_22: false)).GetRenderer();
			if (renderer != null)
			{
				result = renderer;
			}
		}
		return result;
	}

	protected virtual void OnShowKeyTipsChanged()
	{
		string_0 = "";
		if (ShowKeyTips)
		{
			CreateKeyTipCanvas();
		}
		else
		{
			DestroyKeyTipCanvas();
		}
	}

	protected virtual void CreateKeyTipCanvas()
	{
		if (control1_0 != null)
		{
			((Control)control1_0).BringToFront();
			return;
		}
		control1_0 = new Control1(this);
		((Control)control1_0).set_Bounds(new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
		((Control)control1_0).set_Visible(true);
		((Control)this).get_Controls().Add((Control)(object)control1_0);
		((Control)control1_0).BringToFront();
	}

	protected virtual void DestroyKeyTipCanvas()
	{
		if (control1_0 != null)
		{
			((Control)control1_0).set_Visible(false);
			((Control)this).get_Controls().Remove((Control)(object)control1_0);
			((Component)(object)control1_0).Dispose();
			control1_0 = null;
		}
	}

	void Interface0.imethod_0(Graphics graphics_0)
	{
		vmethod_0(graphics_0);
	}

	protected virtual void vmethod_0(Graphics graphics_0)
	{
		if (bool_12 && m_ParentItem != null)
		{
			KeyTipsRendererEventArgs keyTipsRendererEventArgs_ = new KeyTipsRendererEventArgs(graphics_0, Rectangle.Empty, "", GetKeyTipFont(), null);
			BaseRenderer baseRenderer_ = method_0();
			vmethod_1(m_ParentItem, baseRenderer_, keyTipsRendererEventArgs_);
		}
	}

	protected virtual Font GetKeyTipFont()
	{
		Font font = ((Control)this).get_Font();
		if (font_0 != null)
		{
			font = font_0;
		}
		return font;
	}

	internal virtual void vmethod_1(BaseItem baseItem_3, BaseRenderer baseRenderer_0, KeyTipsRendererEventArgs keyTipsRendererEventArgs_0)
	{
		foreach (BaseItem subItem in baseItem_3.SubItems)
		{
			if (!subItem.Visible || !subItem.Displayed)
			{
				continue;
			}
			if (subItem.IsContainer)
			{
				vmethod_1(subItem, baseRenderer_0, keyTipsRendererEventArgs_0);
			}
			if ((subItem.AccessKey != 0 || !(subItem.KeyTips == "")) && (!(string_0 != "") || subItem.KeyTips.StartsWith(string_0)) && (!(subItem.KeyTips == "") || !(string_0 != "")))
			{
				if (subItem.KeyTips != "")
				{
					keyTipsRendererEventArgs_0.KeyTip = subItem.KeyTips;
				}
				else
				{
					keyTipsRendererEventArgs_0.KeyTip = subItem.AccessKey.ToString().ToUpper();
				}
				keyTipsRendererEventArgs_0.Bounds = GetKeyTipRectangle(keyTipsRendererEventArgs_0.Graphics, subItem, keyTipsRendererEventArgs_0.Font, keyTipsRendererEventArgs_0.KeyTip);
				keyTipsRendererEventArgs_0.ReferenceObject = subItem;
				baseRenderer_0.DrawKeyTips(keyTipsRendererEventArgs_0);
			}
		}
	}

	protected virtual Rectangle GetKeyTipRectangle(Graphics g, BaseItem item, Font font, string keyTip)
	{
		Size size_ = Class53.size_0;
		Size size = Class55.smethod_3(g, keyTip, font);
		size.Width += size_.Width;
		size.Height += size_.Height;
		Rectangle displayRectangle = item.DisplayRectangle;
		return new Rectangle(displayRectangle.X + 16, displayRectangle.Bottom - size.Height, size.Width, size.Height);
	}

	public virtual bool ProcessMnemonicEx(char charCode)
	{
		if (method_28(m_ParentItem, charCode))
		{
			return true;
		}
		return false;
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		bool_6 = true;
		return (AccessibleObject)(object)new PopupMenuAccessibleObject(this);
	}

	private void method_1()
	{
		if (m_ParentItem != null && m_ParentItem.Text != "")
		{
			((Control)this).set_AccessibleName(m_ParentItem.Text);
		}
		else
		{
			((Control)this).set_AccessibleName("DotNetBar Popup Menu");
		}
		((Control)this).set_AccessibleDescription("");
		((Control)this).set_AccessibleRole((AccessibleRole)11);
	}

	internal ItemPaintArgs method_2(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = ((colorScheme_0 != null) ? new ItemPaintArgs(object_0 as IOwner, (Control)(object)this, graphics_0, colorScheme_0) : new ItemPaintArgs(object_0 as IOwner, (Control)(object)this, graphics_0, new ColorScheme(graphics_0)));
		itemPaintArgs.BaseRenderer_0 = method_0();
		if (m_ParentItem.DesignMode)
		{
			ISite site = method_17();
			if (site != null && site.DesignMode)
			{
				itemPaintArgs.DesignerSelection = true;
			}
		}
		return itemPaintArgs;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (m_ParentItem != null)
		{
			ItemPaintArgs itemPaintArgs = method_2(e.get_Graphics());
			itemPaintArgs.ClipRectangle = e.get_ClipRectangle();
			SmoothingMode smoothingMode = e.get_Graphics().get_SmoothingMode();
			TextRenderingHint textRenderingHint = e.get_Graphics().get_TextRenderingHint();
			if (bool_10)
			{
				e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
				e.get_Graphics().set_TextRenderingHint(Class50.TextRenderingHint_0);
			}
			if (m_ParentItem.Style == eDotNetBarStyle.Office2000)
			{
				PaintOffice(itemPaintArgs);
			}
			else
			{
				PaintDotNet(itemPaintArgs);
			}
			if (m_ParentItem is Office2007StartButton)
			{
				((Office2007StartButton)m_ParentItem).method_43(itemPaintArgs);
			}
			e.get_Graphics().set_SmoothingMode(smoothingMode);
			e.get_Graphics().set_TextRenderingHint(textRenderingHint);
		}
	}

	private Class202 method_3(ItemPaintArgs itemPaintArgs_0)
	{
		Class202 @class = new Class202();
		if (m_ParentItem != null && m_ParentItem.Style == eDotNetBarStyle.Office2007 && itemPaintArgs_0.BaseRenderer_0 is Office2007Renderer)
		{
			Office2007MenuColorTable menu = ((Office2007Renderer)itemPaintArgs_0.BaseRenderer_0).ColorTable.Menu;
			@class.linearGradientColorTable_0 = menu.Background;
			@class.linearGradientColorTable_3 = menu.Border;
			@class.linearGradientColorTable_1 = menu.Side;
			@class.linearGradientColorTable_4 = menu.SideBorder;
			@class.linearGradientColorTable_5 = menu.SideBorderLight;
			@class.linearGradientColorTable_2 = menu.SideUnused;
		}
		else
		{
			@class.linearGradientColorTable_0.Start = itemPaintArgs_0.Colors.MenuBackground;
			@class.linearGradientColorTable_0.End = itemPaintArgs_0.Colors.MenuBackground2;
			@class.linearGradientColorTable_0.GradientAngle = itemPaintArgs_0.Colors.MenuBackgroundGradientAngle;
			@class.linearGradientColorTable_1.Start = itemPaintArgs_0.Colors.MenuSide;
			@class.linearGradientColorTable_1.End = itemPaintArgs_0.Colors.MenuSide2;
			@class.linearGradientColorTable_1.GradientAngle = itemPaintArgs_0.Colors.MenuSideGradientAngle;
			@class.linearGradientColorTable_2.Start = itemPaintArgs_0.Colors.MenuUnusedSide;
			@class.linearGradientColorTable_2.End = itemPaintArgs_0.Colors.MenuUnusedSide2;
			@class.linearGradientColorTable_2.GradientAngle = itemPaintArgs_0.Colors.MenuUnusedSideGradientAngle;
			@class.linearGradientColorTable_3.Start = itemPaintArgs_0.Colors.MenuBorder;
			@class.linearGradientColorTable_4.Start = itemPaintArgs_0.Colors.ItemSeparator;
			@class.linearGradientColorTable_5.Start = itemPaintArgs_0.Colors.ItemSeparatorShade;
		}
		return @class;
	}

	protected void PaintDotNet(ItemPaintArgs pa)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		Graphics graphics = pa.Graphics;
		if (Boolean_4 && !Boolean_5)
		{
			method_10();
		}
		Class202 @class = method_3(pa);
		Class50.smethod_25(graphics, ((Control)this).get_ClientRectangle(), @class.linearGradientColorTable_0);
		method_9(pa);
		if (m_ParentItem != null)
		{
			Rectangle rectangle = ((Control)this).get_ClientRectangle();
			if (Boolean_4 && !Boolean_5)
			{
				rectangle = new Rectangle(0, 0, ((Control)this).get_ClientSize().Width - 2, ((Control)this).get_ClientSize().Height - 2);
			}
			if (Class109.smethod_69(m_ParentItem.Style))
			{
				if (((Control)this).get_Region() != null)
				{
					Class50.smethod_9(graphics, @class.linearGradientColorTable_3.Start, rectangle, int_12);
					Rectangle rectangle2 = rectangle;
					rectangle2.Inflate(-1, -1);
					Color color = ControlPaint.LightLight(@class.linearGradientColorTable_0.Start);
					if (Boolean_0)
					{
						color = Color.Empty;
						GraphicsPath val = Class50.smethod_13(rectangle2, int_12);
						Region val2 = new Region(val);
						val.Widen(SystemPens.get_Control());
						val2.Union(val);
						graphics.set_Clip(val2);
					}
					if (!color.IsEmpty)
					{
						Pen val3 = new Pen(color);
						try
						{
							Class50.smethod_11(graphics, val3, rectangle2, int_12);
						}
						finally
						{
							((IDisposable)val3)?.Dispose();
						}
					}
				}
				else
				{
					Class50.smethod_6(graphics, @class.linearGradientColorTable_3.Start, rectangle);
				}
			}
			else
			{
				Class50.smethod_33(graphics, rectangle, @class.linearGradientColorTable_3, 1);
			}
			if (Boolean_4 && !Boolean_5 && m_ParentItem != null && m_ParentItem.Style != eDotNetBarStyle.Office2007)
			{
				Pen val4 = new Pen(SystemColors.ControlDark, 2f);
				try
				{
					Point[] array = new Point[3];
					array[0].X = 2;
					array[0].Y = ((Control)this).get_ClientSize().Height - 1;
					array[1].X = ((Control)this).get_ClientSize().Width - 1;
					array[1].Y = ((Control)this).get_ClientSize().Height - 1;
					array[2].X = ((Control)this).get_ClientSize().Width - 1;
					array[2].Y = 2;
					graphics.DrawLines(val4, array);
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
			}
			if (m_ParentItem.Style != eDotNetBarStyle.Office2007 && m_ParentItem is ButtonItem && m_ParentItem.Displayed && m_ParentItem.Visible && m_ParentItem.Orientation == eOrientation.Horizontal && !(m_ParentItem.ContainerControl is ContextMenuBar) && bool_7 && ((Control)this).get_Parent() != null && m_ParentItemScreenPos.Y < ((Control)this).get_Parent().get_Location().Y)
			{
				Point point = new Point(m_ParentItemScreenPos.X - ((Control)this).get_Parent().get_Location().X + 1, 0);
				Point point2 = new Point(point.X + m_ParentItem.WidthInternal - (pa.Colors.ItemExpandedShadow.IsEmpty ? 3 : 5), 0);
				Pen val5 = new Pen(pa.Colors.ItemExpandedBackground, 1f);
				try
				{
					graphics.DrawLine(val5, point, point2);
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
			}
			if (bool_1)
			{
				_ = m_ParentItem.SubItems[0];
				if (bool_2)
				{
					if (m_ParentItem is ImageItem imageItem)
					{
						Rectangle rectangle_ = new Rectangle(rectangle_0.Left, rectangle_0.Top, imageItem.SubItemsImageSize.Width + 7, int_9);
						Class50.smethod_25(graphics, rectangle_, @class.linearGradientColorTable_1);
						if (Class109.smethod_69(m_ParentItem.Style))
						{
							method_6(pa, rectangle_, @class);
						}
					}
					else
					{
						Rectangle rectangle_2 = new Rectangle(rectangle_0.Left, rectangle_0.Top, 23, int_9);
						Class50.smethod_25(graphics, rectangle_2, @class.linearGradientColorTable_1);
						if (Class109.smethod_69(m_ParentItem.Style))
						{
							method_6(pa, rectangle_2, @class);
						}
					}
				}
				if (bool_3)
				{
					if (m_ParentItem is ImageItem imageItem2)
					{
						Rectangle rectangle_3 = new Rectangle(rectangle_0.Left, rectangle_0.Bottom - int_10 - 1, imageItem2.SubItemsImageSize.Width + 7, int_10);
						Class50.smethod_25(graphics, rectangle_3, @class.linearGradientColorTable_1);
						if (Class109.smethod_69(m_ParentItem.Style))
						{
							method_6(pa, rectangle_3, @class);
						}
					}
					else
					{
						Rectangle rectangle_4 = new Rectangle(rectangle_0.Left, rectangle_0.Bottom - int_10 - 1, 23, int_10);
						Class50.smethod_25(graphics, rectangle_4, @class.linearGradientColorTable_1);
						if (Class109.smethod_69(m_ParentItem.Style))
						{
							method_6(pa, rectangle_4, @class);
						}
					}
				}
			}
			method_5(pa, @class);
		}
		else
		{
			Class50.smethod_33(graphics, ((Control)this).get_ClientRectangle(), @class.linearGradientColorTable_3, 1);
		}
	}

	protected void PaintOffice(ItemPaintArgs pa)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(SystemColors.Control);
		try
		{
			pa.Graphics.FillRectangle((Brush)(object)val, ((Control)this).get_DisplayRectangle());
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		method_9(pa);
		ControlPaint.DrawBorder3D(pa.Graphics, 0, 0, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height, (Border3DStyle)5);
		if (m_ParentItem != null)
		{
			method_5(pa, method_3(pa));
		}
	}

	private bool method_4(BaseItem baseItem_3)
	{
		if (!(baseItem_3 is LabelItem) && !(baseItem_3 is ItemContainer))
		{
			return true;
		}
		return false;
	}

	private void method_5(ItemPaintArgs itemPaintArgs_0, Class202 class202_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = itemPaintArgs_0.Graphics;
		bool flag = (int)((Control)this).get_RightToLeft() == 1;
		if (m_ParentItem == null || m_ParentItem == null)
		{
			return;
		}
		Rectangle rectangle = new Rectangle((int)graphics.get_ClipBounds().X, (int)graphics.get_ClipBounds().Y, (int)graphics.get_ClipBounds().Width, (int)graphics.get_ClipBounds().Height);
		if (bool_1)
		{
			if (bool_2)
			{
				Point[] array = new Point[3];
				array[0].X = rectangle_0.Left + (rectangle_0.Width - 8) / 2;
				array[0].Y = rectangle_0.Top + 8;
				array[1].X = array[0].X + 8;
				array[1].Y = array[0].Y;
				array[2].X = array[0].X + 4;
				array[2].Y = array[0].Y - 5;
				graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
			}
			ImageItem imageItem = m_ParentItem as ImageItem;
			int num = 16;
			if (imageItem != null)
			{
				num = imageItem.SubItemsImageSize.Width;
			}
			imageItem = null;
			bool flag2 = false;
			for (int i = int_8; i < m_ParentItem.SubItems.Count; i++)
			{
				BaseItem baseItem = m_ParentItem.SubItems[i];
				if (!rectangle.IntersectsWith(baseItem.DisplayRectangle) || (!baseItem.Visible && !bool_4) || !baseItem.Displayed)
				{
					continue;
				}
				SmoothingMode smoothingMode = graphics.get_SmoothingMode();
				graphics.set_SmoothingMode((SmoothingMode)0);
				if (baseItem.BeginGroup && baseItem.TopInternal > Int32_1)
				{
					if (baseItem.Style == eDotNetBarStyle.Office2000)
					{
						if (bool_4)
						{
							ControlPaint.DrawBorder3D(graphics, baseItem.HeightInternal + 2 + baseItem.LeftInternal + 13, baseItem.TopInternal - 5, baseItem.WidthInternal - 26 - baseItem.HeightInternal - 2, 2, (Border3DStyle)6, (Border3DSide)2);
						}
						else
						{
							ControlPaint.DrawBorder3D(graphics, baseItem.LeftInternal + 13, baseItem.TopInternal - 5, baseItem.WidthInternal - 26, 2, (Border3DStyle)6, (Border3DSide)2);
						}
					}
					else if (bool_4)
					{
						Rectangle rectangle_ = new Rectangle(baseItem.LeftInternal, baseItem.TopInternal - 3, baseItem.HeightInternal + 2 + num + 7, 3);
						rectangle_.Inflate(0, 1);
						Class50.smethod_26(graphics, rectangle_, class202_0.linearGradientColorTable_1.Start, class202_0.linearGradientColorTable_1.End, class202_0.linearGradientColorTable_1.GradientAngle);
						if (Class109.smethod_69(baseItem.Style))
						{
							method_6(itemPaintArgs_0, rectangle_, class202_0);
						}
						Class50.smethod_32(graphics, baseItem.LeftInternal + num + 8 + 7 + baseItem.HeightInternal + 2, baseItem.TopInternal - 2, baseItem.DisplayRectangle.Right - 1, baseItem.TopInternal - 2, class202_0.linearGradientColorTable_4.Start, 1);
						if (Class109.smethod_69(baseItem.Style))
						{
							Class50.smethod_32(graphics, baseItem.LeftInternal + num + 8 + 7 + baseItem.HeightInternal + 2, baseItem.TopInternal - 1, baseItem.DisplayRectangle.Right - 1, baseItem.TopInternal - 1, class202_0.linearGradientColorTable_5.Start, 1);
						}
					}
					else
					{
						bool flag3;
						bool flag4 = (flag3 = method_4(baseItem));
						if (flag3)
						{
							Rectangle rectangle_2 = new Rectangle(baseItem.LeftInternal, baseItem.TopInternal - 3, num + 7, 3);
							rectangle_2.Inflate(0, 1);
							if (baseItem is IPersonalizedMenuItem && ((IPersonalizedMenuItem)baseItem).MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !((IPersonalizedMenuItem)baseItem).RecentlyUsed)
							{
								Class50.smethod_25(graphics, rectangle_2, class202_0.linearGradientColorTable_2);
							}
							else
							{
								Class50.smethod_25(graphics, rectangle_2, class202_0.linearGradientColorTable_1);
							}
							if (Class109.smethod_69(baseItem.Style))
							{
								method_6(itemPaintArgs_0, rectangle_2, class202_0);
							}
						}
						if (flag4 && flag2)
						{
							flag4 = false;
						}
						Class50.smethod_32(graphics, baseItem.LeftInternal + (flag4 ? (num + 8 + 7) : 0), baseItem.TopInternal - 2, baseItem.DisplayRectangle.Right - 1, baseItem.TopInternal - 2, class202_0.linearGradientColorTable_4.Start, 1);
						if (Class109.smethod_69(baseItem.Style))
						{
							Class50.smethod_32(graphics, baseItem.LeftInternal + (flag4 ? (num + 8 + 7) : 0), baseItem.TopInternal - 1, baseItem.DisplayRectangle.Right - 1, baseItem.TopInternal - 1, class202_0.linearGradientColorTable_5.Start, 1);
						}
					}
				}
				graphics.set_SmoothingMode(smoothingMode);
				baseItem.Paint(itemPaintArgs_0);
				flag2 = baseItem.IsContainer;
			}
			if (bool_3)
			{
				Point[] array = new Point[3];
				array[0].X = rectangle_0.Left + (rectangle_0.Width - 8) / 2;
				array[0].Y = rectangle_0.Bottom - 8;
				array[1].X = array[0].X + 8;
				array[1].Y = array[0].Y;
				array[2].X = array[0].X + 4;
				array[2].Y = array[0].Y + 4;
				graphics.FillPolygon(SystemBrushes.get_ControlText(), array);
			}
		}
		else
		{
			ImageItem imageItem2 = m_ParentItem as ImageItem;
			int num2 = 16;
			if (imageItem2 != null)
			{
				num2 = imageItem2.SubItemsImageSize.Width;
			}
			imageItem2 = null;
			bool flag5 = true;
			bool flag6 = false;
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				if (!rectangle.IntersectsWith(subItem.DisplayRectangle) || ((!subItem.Visible || !subItem.Displayed) && !bool_4))
				{
					continue;
				}
				SmoothingMode smoothingMode2 = graphics.get_SmoothingMode();
				graphics.set_SmoothingMode((SmoothingMode)0);
				if (subItem.BeginGroup && !flag5)
				{
					if (subItem.Style == eDotNetBarStyle.Office2000)
					{
						if (bool_4)
						{
							ControlPaint.DrawBorder3D(graphics, subItem.HeightInternal + 2 + subItem.LeftInternal + 13, subItem.TopInternal - 5, subItem.WidthInternal - 26 - subItem.HeightInternal - 2, 2, (Border3DStyle)6, (Border3DSide)2);
						}
						else
						{
							ControlPaint.DrawBorder3D(graphics, subItem.LeftInternal + 13, subItem.TopInternal - 5, subItem.WidthInternal - 26, 2, (Border3DStyle)6, (Border3DSide)2);
						}
					}
					else if (bool_4)
					{
						Rectangle rectangle_3 = new Rectangle(subItem.LeftInternal, subItem.TopInternal - 3, subItem.HeightInternal + 2 + num2 + 7, 3);
						rectangle_3.Inflate(0, 1);
						if (flag)
						{
							rectangle_3.Width = num2 + 7;
							rectangle_3.X = subItem.DisplayRectangle.Right - rectangle_3.Width;
						}
						Class50.smethod_25(graphics, rectangle_3, class202_0.linearGradientColorTable_1);
						if (Class109.smethod_69(subItem.Style))
						{
							method_6(itemPaintArgs_0, rectangle_3, class202_0);
						}
						if (flag)
						{
							Class50.smethod_32(graphics, subItem.LeftInternal + 1, subItem.TopInternal - 2, subItem.DisplayRectangle.Right - (num2 + 8 + 7 + subItem.HeightInternal + 2 + 1), subItem.TopInternal - 2, class202_0.linearGradientColorTable_4.Start, 1);
							if (Class109.smethod_69(subItem.Style))
							{
								Class50.smethod_32(graphics, subItem.LeftInternal + 1, subItem.TopInternal - 1, subItem.DisplayRectangle.Right - (num2 + 8 + 7 + subItem.HeightInternal + 2 + 1), subItem.TopInternal - 1, class202_0.linearGradientColorTable_5.Start, 1);
							}
						}
						else
						{
							Class50.smethod_32(graphics, subItem.LeftInternal + num2 + 8 + 7 + subItem.HeightInternal + 2, subItem.TopInternal - 2, subItem.DisplayRectangle.Right - 1, subItem.TopInternal - 2, class202_0.linearGradientColorTable_4.Start, 1);
							if (Class109.smethod_69(subItem.Style))
							{
								Class50.smethod_32(graphics, subItem.LeftInternal + num2 + 8 + 7 + subItem.HeightInternal + 2, subItem.TopInternal - 1, subItem.DisplayRectangle.Right - 1, subItem.TopInternal - 1, class202_0.linearGradientColorTable_5.Start, 1);
							}
						}
					}
					else
					{
						Rectangle rectangle_4 = new Rectangle(subItem.LeftInternal, subItem.TopInternal - 2, num2 + 7, 3);
						rectangle_4.Inflate(0, 1);
						if (flag)
						{
							rectangle_4.X = subItem.DisplayRectangle.Right - rectangle_4.Width - 1;
						}
						bool flag8;
						bool flag7;
						if ((flag8 = (flag7 = method_4(subItem))) && flag6)
						{
							flag7 = false;
							flag8 = false;
						}
						if (flag7)
						{
							if (subItem is IPersonalizedMenuItem && ((IPersonalizedMenuItem)subItem).MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !((IPersonalizedMenuItem)subItem).RecentlyUsed)
							{
								Class50.smethod_25(graphics, rectangle_4, class202_0.linearGradientColorTable_2);
							}
							else
							{
								Class50.smethod_25(graphics, rectangle_4, class202_0.linearGradientColorTable_1);
							}
							if (Class109.smethod_69(subItem.Style))
							{
								method_6(itemPaintArgs_0, rectangle_4, class202_0);
							}
						}
						if (flag)
						{
							Class50.smethod_32(graphics, subItem.LeftInternal + 1, subItem.TopInternal - 2, subItem.DisplayRectangle.Right - (flag8 ? (num2 + 8 + 7 + 1) : 0), subItem.TopInternal - 2, class202_0.linearGradientColorTable_4.Start, 1);
							if (Class109.smethod_69(subItem.Style))
							{
								Class50.smethod_32(graphics, subItem.LeftInternal + 1, subItem.TopInternal - 1, subItem.DisplayRectangle.Right - (flag8 ? (num2 + 8 + 7 + 1) : 0), subItem.TopInternal - 1, class202_0.linearGradientColorTable_5.Start, 1);
							}
						}
						else
						{
							Class50.smethod_32(graphics, subItem.LeftInternal + (flag8 ? (num2 + 8 + 7) : 0), subItem.TopInternal - 2, subItem.DisplayRectangle.Right - 1, subItem.TopInternal - 2, class202_0.linearGradientColorTable_4.Start, 1);
							if (Class109.smethod_69(subItem.Style) && !itemPaintArgs_0.Colors.ItemSeparatorShade.IsEmpty)
							{
								Class50.smethod_32(graphics, subItem.LeftInternal + (flag8 ? (num2 + 8 + 7) : 0), subItem.TopInternal - 1, subItem.DisplayRectangle.Right - 1, subItem.TopInternal - 1, class202_0.linearGradientColorTable_5.Start, 1);
							}
						}
					}
				}
				graphics.set_SmoothingMode(smoothingMode2);
				flag5 = false;
				subItem.Paint(itemPaintArgs_0);
				subItem.Displayed = true;
				flag6 = subItem.IsContainer;
			}
		}
		method_8(itemPaintArgs_0, class202_0);
	}

	private void method_6(ItemPaintArgs itemPaintArgs_0, Rectangle rectangle_2, Class202 class202_0)
	{
		if (!(itemPaintArgs_0.Owner is DotNetBarManager))
		{
			Graphics graphics = itemPaintArgs_0.Graphics;
			if (itemPaintArgs_0.RightToLeft)
			{
				Point point = new Point(rectangle_2.X, rectangle_2.Y);
				Class50.smethod_32(graphics, point.X, point.Y, point.X, point.Y + rectangle_2.Height, class202_0.linearGradientColorTable_5.Start, 1);
				point.X++;
				Class50.smethod_32(graphics, point.X, point.Y, point.X, point.Y + rectangle_2.Height, class202_0.linearGradientColorTable_4.Start, 1);
			}
			else
			{
				Point point2 = new Point(rectangle_2.Right - 2, rectangle_2.Y);
				Class50.smethod_32(graphics, point2.X, point2.Y, point2.X, point2.Y + rectangle_2.Height, class202_0.linearGradientColorTable_4.Start, 1);
				point2.X++;
				Class50.smethod_32(graphics, point2.X, point2.Y, point2.X, point2.Y + rectangle_2.Height, class202_0.linearGradientColorTable_5.Start, 1);
			}
		}
	}

	private void method_7()
	{
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			ItemPaintArgs itemPaintArgs_ = ((colorScheme_0 != null) ? new ItemPaintArgs(object_0 as IOwner, (Control)(object)this, val, colorScheme_0) : new ItemPaintArgs(object_0 as IOwner, (Control)(object)this, val, new ColorScheme(val)));
			method_8(itemPaintArgs_, method_3(itemPaintArgs_));
		}
		finally
		{
			val.Dispose();
		}
	}

	private void method_8(ItemPaintArgs itemPaintArgs_0, Class202 class202_0)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Invalid comparison between Unknown and I4
		if (!struct18_0.bool_1 || m_ParentItem == null)
		{
			return;
		}
		Graphics graphics = itemPaintArgs_0.Graphics;
		ImageItem imageItem = m_ParentItem as ImageItem;
		int num = 16;
		if (imageItem != null && imageItem.SubItemsImageSize.Width > num)
		{
			num = imageItem.SubItemsImageSize.Width;
		}
		num += 7;
		imageItem = null;
		if (Boolean_1)
		{
			if (struct18_0.bool_2)
			{
				Rectangle rectangle = struct18_0.rectangle_0;
				Class50.smethod_24(graphics, rectangle, itemPaintArgs_0.Colors.MenuBackground, Color.Empty);
				rectangle.Inflate(-1, 0);
				if ((int)Control.get_MouseButtons() == 1048576)
				{
					Class50.smethod_26(graphics, rectangle, itemPaintArgs_0.Colors.ItemPressedBackground, itemPaintArgs_0.Colors.ItemPressedBackground2, itemPaintArgs_0.Colors.ItemPressedBackgroundGradientAngle);
				}
				else
				{
					Class50.smethod_26(graphics, rectangle, itemPaintArgs_0.Colors.ItemHotBackground, itemPaintArgs_0.Colors.ItemHotBackground2, itemPaintArgs_0.Colors.ItemHotBackgroundGradientAngle);
				}
				Class92.smethod_4(graphics, SystemPens.get_Highlight(), rectangle);
			}
			else
			{
				Rectangle rectangle2 = new Rectangle(struct18_0.rectangle_0.Left + num, struct18_0.rectangle_0.Top, struct18_0.rectangle_0.Width - num, struct18_0.rectangle_0.Height);
				Class50.smethod_24(graphics, rectangle2, itemPaintArgs_0.Colors.MenuBackground, Color.Empty);
				Rectangle rectangle_ = new Rectangle(struct18_0.rectangle_0.Left, struct18_0.rectangle_0.Top, num, struct18_0.rectangle_0.Height);
				Class50.smethod_26(graphics, rectangle_, itemPaintArgs_0.Colors.MenuSide, itemPaintArgs_0.Colors.MenuSide2, itemPaintArgs_0.Colors.MenuSideGradientAngle);
				if (m_ParentItem != null && Class109.smethod_69(m_ParentItem.Style))
				{
					method_6(itemPaintArgs_0, rectangle_, class202_0);
				}
			}
			if (m_ParentItem.Style == eDotNetBarStyle.Office2003 || m_ParentItem.Style == eDotNetBarStyle.VS2005 || Class109.smethod_69(m_ParentItem.Style))
			{
				GraphicsPath val = new GraphicsPath();
				Point point = new Point(struct18_0.rectangle_0.X + (struct18_0.rectangle_0.Width - 16) / 2, struct18_0.rectangle_0.Y + (struct18_0.rectangle_0.Height - 16) / 2);
				val.AddEllipse(point.X, point.Y, 16, 16);
				PathGradientBrush val2 = new PathGradientBrush(val);
				val2.set_CenterColor(itemPaintArgs_0.Colors.MenuSide);
				val2.set_SurroundColors(new Color[1] { itemPaintArgs_0.Colors.MenuSide2 });
				val2.set_CenterPoint((PointF)new Point(point.X + 3, point.Y + 3));
				SmoothingMode smoothingMode = graphics.get_SmoothingMode();
				graphics.set_SmoothingMode((SmoothingMode)4);
				graphics.FillEllipse((Brush)(object)val2, point.X, point.Y, 16, 16);
				graphics.set_SmoothingMode(smoothingMode);
			}
		}
		else if (m_ParentItem.Style == eDotNetBarStyle.Office2000)
		{
			if (struct18_0.bool_2)
			{
				graphics.FillRectangle((Brush)new SolidBrush(ColorFunctions.RecentlyUsedOfficeBackColor()), struct18_0.rectangle_0);
				if ((int)Control.get_MouseButtons() == 1048576)
				{
					ControlPaint.DrawBorder(graphics, struct18_0.rectangle_0, SystemColors.Control, (ButtonBorderStyle)4);
				}
				else
				{
					ControlPaint.DrawBorder3D(graphics, struct18_0.rectangle_0, (Border3DStyle)4, (Border3DSide)15);
				}
			}
			else
			{
				graphics.FillRectangle(SystemBrushes.get_Control(), struct18_0.rectangle_0);
			}
		}
		Point[] array = new Point[3];
		array[0].X = struct18_0.rectangle_0.Left + (struct18_0.rectangle_0.Width - 4) / 2;
		if (m_ParentItem.Style != eDotNetBarStyle.Office2003 && m_ParentItem.Style != eDotNetBarStyle.VS2005 && !Class109.smethod_69(m_ParentItem.Style))
		{
			array[0].Y = struct18_0.rectangle_0.Top + 3;
		}
		else
		{
			array[0].Y = struct18_0.rectangle_0.Top + (struct18_0.rectangle_0.Height - 7) / 2;
		}
		array[1].X = array[0].X + 2;
		array[1].Y = array[0].Y + 2;
		array[2].X = array[0].X + 4;
		array[2].Y = array[0].Y;
		graphics.DrawLines(SystemPens.get_ControlText(), array);
		array[0].Y++;
		array[1].Y++;
		array[2].Y++;
		graphics.DrawLines(SystemPens.get_ControlText(), array);
		array[0].Y += 3;
		array[1].Y += 3;
		array[2].Y += 3;
		graphics.DrawLines(SystemPens.get_ControlText(), array);
		array[0].Y++;
		array[1].Y++;
		array[2].Y++;
		graphics.DrawLines(SystemPens.get_ControlText(), array);
	}

	private void method_9(ItemPaintArgs itemPaintArgs_0)
	{
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		Graphics graphics = itemPaintArgs_0.Graphics;
		if (sideBarImage_0.Picture != null)
		{
			if (!sideBarImage_0.GradientColor1.IsEmpty && !sideBarImage_0.GradientColor2.IsEmpty)
			{
				PointF[] array = new PointF[2];
				array[0].X = rectangle_1.Left;
				array[0].Y = rectangle_1.Top;
				array[1].X = rectangle_1.Left;
				array[1].Y = rectangle_1.Bottom;
				LinearGradientBrush val = Class109.smethod_40(rectangle_1, sideBarImage_0.GradientColor1, sideBarImage_0.GradientColor2, sideBarImage_0.GradientAngle);
				graphics.FillRectangle((Brush)(object)val, rectangle_1);
			}
			else if (!sideBarImage_0.BackColor.Equals((object?)Color.Empty))
			{
				graphics.FillRectangle((Brush)new SolidBrush(sideBarImage_0.BackColor), rectangle_1);
			}
			if (sideBarImage_0.StretchPicture)
			{
				graphics.DrawImage(sideBarImage_0.Picture, rectangle_1);
			}
			else if (sideBarImage_0.Alignment == eAlignment.Top)
			{
				graphics.DrawImage(sideBarImage_0.Picture, rectangle_1.X, rectangle_1.Top, rectangle_1.Width, sideBarImage_0.Picture.get_Height());
			}
			else if (sideBarImage_0.Alignment == eAlignment.Bottom)
			{
				graphics.DrawImage(sideBarImage_0.Picture, rectangle_1.Left, rectangle_1.Bottom - sideBarImage_0.Picture.get_Height(), sideBarImage_0.Picture.get_Width(), sideBarImage_0.Picture.get_Height());
			}
			else
			{
				graphics.DrawImage(sideBarImage_0.Picture, rectangle_1.Left, rectangle_1.Top + (rectangle_1.Height - sideBarImage_0.Picture.get_Height()) / 2, sideBarImage_0.Picture.get_Width(), sideBarImage_0.Picture.get_Height());
			}
		}
	}

	private void method_10()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (m_ParentItem != null)
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

	public void RecalcLayout()
	{
		RecalcSize();
		((Control)this).Invalidate(true);
	}

	public void RecalcSize()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		if (m_ParentItem != null)
		{
			m_ParentItem.IsRightToLeft = (int)((Control)this).get_RightToLeft() == 1;
			if (m_ParentItem.Style == eDotNetBarStyle.Office2000)
			{
				method_12();
			}
			else
			{
				method_11();
			}
			if (((Control)this).get_Visible() && bool_7 && ((Control)this).get_Parent() != null && ((Control)this).get_Parent() is PopupContainer)
			{
				Class273 @class = Class109.smethod_53(((Control)this).get_Parent());
				if (@class != null)
				{
					Rectangle rectangle = @class.rectangle_1;
					if (bool_11)
					{
						rectangle = @class.rectangle_0;
					}
					if (((Control)this).get_Parent().get_Location().Y + ((Control)this).get_Size().Height > rectangle.Bottom)
					{
						rectangle_0.Height -= ((Control)this).get_Parent().get_Location().Y + ((Control)this).get_Size().Height - rectangle.Bottom;
						((Control)this).set_Height(((Control)this).get_Height() - (((Control)this).get_Parent().get_Location().Y + ((Control)this).get_Size().Height - rectangle.Bottom));
						if (!bool_1)
						{
							bool_1 = true;
							int_8 = 0;
						}
						method_33();
					}
					else
					{
						bool_1 = false;
					}
				}
			}
		}
		if (!((Control)this).get_Visible())
		{
			return;
		}
		if (m_ParentItem != null && Class109.smethod_69(m_ParentItem.Style) && Boolean_2)
		{
			if (((Control)this).get_Parent() != null)
			{
				method_34(((Control)this).get_Parent());
			}
			method_34((Control)(object)this);
		}
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		if (((Control)this).get_Parent() is PopupContainer)
		{
			((Control)this).get_Parent().set_Size(((Control)this).get_Size());
		}
		((Control)this).OnResize(e);
	}

	private void method_11()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		struct18_0.bool_1 = false;
		if (m_ParentItem != null && m_ParentItem.SubItems.Count != 0)
		{
			int num = 0;
			int num2 = Int32_1;
			int num3 = Int32_0;
			int num4 = 0;
			bool flag = false;
			((Control)this).get_RightToLeft();
			if (sideBarImage_0.Picture != null)
			{
				num3 += sideBarImage_0.Picture.get_Width();
			}
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				subItem.RecalcSize();
				if (!subItem.Visible && !bool_4)
				{
					subItem.Displayed = false;
					continue;
				}
				if (!m_ParentItem.DesignMode && ePersonalizedMenus_0 != 0 && !struct18_0.bool_0 && !bool_4 && subItem is IPersonalizedMenuItem personalizedMenuItem && personalizedMenuItem.MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !personalizedMenuItem.RecentlyUsed)
				{
					subItem.Displayed = false;
					struct18_0.bool_1 = true;
					continue;
				}
				if (subItem.HeightInternal != num4 && subItem is ImageItem)
				{
					if (num4 > 0)
					{
						flag = true;
					}
					if (subItem.HeightInternal > num4)
					{
						num4 = subItem.HeightInternal;
					}
				}
				if (subItem.BeginGroup && num2 > Int32_1)
				{
					num2 += 3;
				}
				subItem.TopInternal = num2;
				subItem.LeftInternal = num3;
				num2 += subItem.HeightInternal;
				if (subItem.WidthInternal > num)
				{
					num = subItem.WidthInternal;
				}
				subItem.Displayed = true;
			}
			if (num == 0)
			{
				num = 120;
			}
			if (flag)
			{
				num2 = Int32_1;
				foreach (BaseItem subItem2 in m_ParentItem.SubItems)
				{
					subItem2.WidthInternal = num;
					if (subItem2.Displayed)
					{
						if (subItem2.BeginGroup && num2 > Int32_1)
						{
							num2 += 3;
						}
						subItem2.TopInternal = num2;
						num2 += subItem2.HeightInternal;
					}
				}
			}
			else
			{
				foreach (BaseItem subItem3 in m_ParentItem.SubItems)
				{
					subItem3.WidthInternal = num;
				}
			}
			if (struct18_0.bool_1)
			{
				struct18_0.rectangle_0 = new Rectangle(num3, num2, num, int_11);
				num2 += int_11;
			}
			rectangle_0 = new Rectangle(num3, Int32_1, num, num2 - Int32_1);
			if (sideBarImage_0.Picture != null)
			{
				rectangle_1 = new Rectangle(num3 - sideBarImage_0.Picture.get_Width(), Int32_1, sideBarImage_0.Picture.get_Width(), num2 - Int32_1);
			}
			((Control)this).set_Size(new Size(num3 + num + Int32_2, num2 + Int32_3));
			if (((Control)this).get_Height() == 92)
			{
				((Control)this).set_Height(92);
			}
		}
		else
		{
			((Control)this).set_Height(24);
			((Control)this).set_Width(m_ParentItem.WidthInternal + 16);
		}
	}

	private void method_12()
	{
		struct18_0.bool_1 = false;
		if (m_ParentItem != null && m_ParentItem.SubItems.Count != 0)
		{
			int num = 0;
			int num2 = Int32_1;
			int num3 = Int32_0;
			int num4 = 0;
			bool flag = false;
			if (sideBarImage_0.Picture != null)
			{
				num3 += sideBarImage_0.Picture.get_Width();
			}
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				subItem.RecalcSize();
				if (!subItem.Visible && !bool_4)
				{
					subItem.Displayed = false;
					continue;
				}
				if (!m_ParentItem.DesignMode && ePersonalizedMenus_0 != 0 && !struct18_0.bool_0 && !bool_4 && subItem is IPersonalizedMenuItem personalizedMenuItem && personalizedMenuItem.MenuVisibility == eMenuVisibility.VisibleIfRecentlyUsed && !personalizedMenuItem.RecentlyUsed)
				{
					subItem.Displayed = false;
					struct18_0.bool_1 = true;
					continue;
				}
				if (subItem.HeightInternal != num4 && subItem is ImageItem)
				{
					if (num4 > 0)
					{
						flag = true;
					}
					if (subItem.HeightInternal > num4)
					{
						num4 = subItem.HeightInternal;
					}
				}
				if (subItem.BeginGroup && num2 > Int32_1)
				{
					num2 += 9;
				}
				subItem.TopInternal = num2;
				subItem.LeftInternal = num3;
				num2 += subItem.HeightInternal;
				if (subItem.WidthInternal > num)
				{
					num = subItem.WidthInternal;
				}
				subItem.Displayed = true;
			}
			if (num == 0)
			{
				num = 120;
			}
			if (flag)
			{
				num2 = 3;
				foreach (BaseItem subItem2 in m_ParentItem.SubItems)
				{
					subItem2.WidthInternal = num;
					if (subItem2.Displayed)
					{
						if (subItem2.BeginGroup && num2 > Int32_1)
						{
							num2 += 9;
						}
						subItem2.TopInternal = num2;
						num2 += subItem2.HeightInternal;
					}
				}
			}
			else
			{
				foreach (BaseItem subItem3 in m_ParentItem.SubItems)
				{
					subItem3.WidthInternal = num;
				}
			}
			if (struct18_0.bool_1)
			{
				struct18_0.rectangle_0 = new Rectangle(num3, num2, num, int_11);
				num2 += int_11;
			}
			rectangle_0 = new Rectangle(num3, Int32_1, num, num2 - Int32_1);
			if (sideBarImage_0.Picture != null)
			{
				rectangle_1 = new Rectangle(num3 - sideBarImage_0.Picture.get_Width(), Int32_1, sideBarImage_0.Picture.get_Width(), num2);
			}
			((Control)this).set_Size(new Size(num3 + num + Int32_2, num2 + Int32_3));
		}
		else
		{
			((Control)this).set_Height(24);
			((Control)this).set_Width(m_ParentItem.WidthInternal + 16);
		}
	}

	private void method_13()
	{
		if (m_ParentItem == null || m_ParentItem.SubItems.Count == 0)
		{
			return;
		}
		foreach (BaseItem subItem in m_ParentItem.SubItems)
		{
			subItem.ContainerControl = null;
		}
		int num = 0;
		while (m_ParentItem != null && num < m_ParentItem.SubItems.Count)
		{
			m_ParentItem.SubItems[num].Expanded = false;
			num++;
		}
		num = 0;
		while (m_ParentItem != null && num < m_ParentItem.SubItems.Count)
		{
			m_ParentItem.SubItems[num].Displayed = false;
			num++;
		}
	}

	private BaseItem method_14()
	{
		if (m_ParentItem != null && m_ParentItem.SubItems.Count > 0)
		{
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				if (!subItem.Expanded || !(subItem is PopupItem))
				{
					if (subItem.IsContainer)
					{
						BaseItem baseItem2 = subItem.ExpandedItem();
						if (baseItem2 is PopupItem)
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

	protected internal BaseItem FocusedItem()
	{
		if (m_ParentItem != null && m_ParentItem.SubItems.Count > 0)
		{
			foreach (BaseItem subItem in m_ParentItem.SubItems)
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

	internal void method_15(BaseItem baseItem_3)
	{
		if (m_ParentItem != null && m_ParentItem.Parent == null)
		{
			BaseItem baseItem = FocusedItem();
			if (baseItem != baseItem_3)
			{
				baseItem?.OnLostFocus();
				baseItem_3?.OnGotFocus();
			}
		}
	}

	internal void method_16(MouseEventArgs mouseEventArgs_1)
	{
		((Control)this).OnMouseMove(mouseEventArgs_1);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Invalid comparison between Unknown and I4
		((Control)this).OnMouseMove(e);
		if (bool_5)
		{
			if (mouseEventArgs_0 == null)
			{
				mouseEventArgs_0 = new MouseEventArgs(e.get_Button(), e.get_Clicks(), e.get_X(), e.get_Y(), e.get_Delta());
				return;
			}
			if (mouseEventArgs_0.get_X() == e.get_X() && mouseEventArgs_0.get_Y() == e.get_Y() && mouseEventArgs_0.get_Button() == e.get_Button())
			{
				return;
			}
			bool_5 = false;
			mouseEventArgs_0 = null;
		}
		if (m_ParentItem != null && m_ParentItem.DesignMode && (int)e.get_Button() == 1048576 && (Math.Abs(e.get_X() - point_0.X) >= 2 || Math.Abs(e.get_Y() - point_0.Y) >= 2 || bool_13))
		{
			BaseItem baseItem = FocusedItem();
			IOwner owner = object_0 as IOwner;
			ISite site = method_17();
			if (site != null && baseItem != null)
			{
				method_18(e);
			}
			else if (baseItem != null && owner != null && baseItem.CanCustomize)
			{
				owner.StartItemDrag(baseItem);
			}
		}
		if (m_ParentItem == null || m_ParentItem.SubItems.Count == 0 || m_ParentItem.DesignMode)
		{
			return;
		}
		BaseItem baseItem2 = ItemAtLocation(e.get_X(), e.get_Y());
		BaseItem baseItem3 = method_14();
		if (baseItem3 != null && baseItem3 is PopupItem)
		{
			Control popupControl = ((PopupItem)baseItem3).PopupControl;
			if (popupControl != null)
			{
				Point pt = popupControl.PointToClient(((Control)this).PointToScreen(new Point(e.get_X(), e.get_Y())));
				if (popupControl.get_ClientRectangle().Contains(pt) && popupControl is MenuPanel)
				{
					((MenuPanel)(object)popupControl).method_16(new MouseEventArgs(e.get_Button(), e.get_Clicks(), pt.X, pt.Y, e.get_Delta()));
					return;
				}
			}
		}
		if (baseItem3 != null && baseItem2 != baseItem3)
		{
			if ((baseItem3 is PopupItem && ((PopupItem)baseItem3).PopupType != 0) || (baseItem3 != null && m_ParentItem != null && m_ParentItem.SubItems.Count > 0 && m_ParentItem.SubItems[0] is ItemContainer && !(m_ParentItem is Office2007StartButton)))
			{
				baseItem3.Expanded = false;
			}
			else
			{
				method_22(baseItem3);
			}
		}
		if (struct18_0.bool_1)
		{
			if (baseItem2 == null && struct18_0.rectangle_0.Contains(e.get_X(), e.get_Y()) && !struct18_0.bool_2)
			{
				struct18_0.bool_2 = true;
				method_7();
			}
			else if (baseItem2 != null && struct18_0.bool_2)
			{
				struct18_0.bool_2 = false;
				method_7();
			}
		}
		if (baseItem2 == null && m_HotSubItem is GalleryContainer)
		{
			GalleryContainer galleryContainer = m_HotSubItem as GalleryContainer;
			if (!galleryContainer.bool_29 && galleryContainer.PopupUsesStandardScrollbars && galleryContainer.ScrollBarCore_0 != null && galleryContainer.ScrollBarCore_0.IsMouseDown && (int)e.get_Button() == 1048576)
			{
				baseItem2 = m_HotSubItem;
			}
		}
		if (baseItem2 != m_HotSubItem)
		{
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalMouseLeave();
				if (bool_0)
				{
					method_30();
					bool_0 = false;
				}
			}
			if (baseItem2 != null)
			{
				baseItem2.InternalMouseEnter();
				baseItem2.InternalMouseMove(e);
				m_HotSubItem = baseItem2;
			}
			else
			{
				m_HotSubItem = null;
			}
		}
		else if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseMove(e);
		}
		if (((Control)this).get_Capture() && !((Control)this).get_DisplayRectangle().Contains(e.get_X(), e.get_Y()) && m_ParentItem != null && m_ParentItem.SubItems.Count > 0 && m_ParentItem.SubItems[0] is GalleryContainer && m_ParentItem.SubItems[0].Visible && m_ParentItem.SubItems[0].Displayed)
		{
			m_ParentItem.SubItems[0].InternalMouseMove(e);
		}
	}

	private ISite method_17()
	{
		ISite site = null;
		IOwner owner = Owner as IOwner;
		Control val = null;
		if (owner is Control)
		{
			val = (Control)((owner is Control) ? owner : null);
		}
		else if (m_ParentItem != null && m_ParentItem.ContainerControl is Control)
		{
			object containerControl = m_ParentItem.ContainerControl;
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
		if (site == null && m_ParentItem != null)
		{
			BaseItem baseItem = m_ParentItem;
			while (site == null && baseItem != null)
			{
				if (baseItem.Site != null && baseItem.Site.DesignMode)
				{
					site = baseItem.Site;
				}
				else
				{
					baseItem = baseItem.Parent;
				}
			}
		}
		return site;
	}

	private void method_18(MouseEventArgs mouseEventArgs_1)
	{
		if (bool_13)
		{
			try
			{
				if (idesignTimeProvider_0 != null)
				{
					idesignTimeProvider_0.DrawReversibleMarker(int_13, bool_14);
					idesignTimeProvider_0 = null;
				}
				InsertPosition insertPosition = idesignTimeProvider_1.GetInsertPosition(Control.get_MousePosition(), baseItem_2);
				if (insertPosition != null)
				{
					if (insertPosition.TargetProvider == null)
					{
						Cursor.set_Current(Cursors.get_No());
					}
					else
					{
						insertPosition.TargetProvider.DrawReversibleMarker(insertPosition.Position, insertPosition.Before);
						int_13 = insertPosition.Position;
						bool_14 = insertPosition.Before;
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
		BaseItem baseItem = m_ParentItem;
		while (baseItem.Parent is IDesignTimeProvider)
		{
			baseItem = baseItem.Parent;
		}
		ISite site = method_17();
		if (site != null && baseItem.ContainerControl != null && site.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
		{
			object containerControl = baseItem.ContainerControl;
			Control val = (Control)((containerControl is Control) ? containerControl : null);
			if (val is RibbonStrip && ((Component)(object)val).Site == null && val.get_Parent() is RibbonControl)
			{
				val = val.get_Parent();
			}
			if (designerHost.GetDesigner((IComponent)val) is BarBaseControlDesigner barBaseControlDesigner)
			{
				barBaseControlDesigner.StartExternalDrag(FocusedItem());
				return;
			}
		}
		idesignTimeProvider_1 = (IDesignTimeProvider)baseItem;
		baseItem_2 = FocusedItem();
		bool_13 = true;
		((Control)this).set_Capture(true);
	}

	private void method_19(MouseEventArgs mouseEventArgs_1)
	{
		ISite site = method_17();
		if (site == null)
		{
			return;
		}
		IComponentChangeService componentChangeService = site.GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_13, bool_14);
			BaseItem parent = baseItem_2.Parent;
			if (parent != null)
			{
				if (parent == (BaseItem)idesignTimeProvider_0 && int_13 > 0 && parent.SubItems.IndexOf(baseItem_2) < int_13)
				{
					int_13--;
				}
				componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(parent)["SubItems"]);
				parent.SubItems.Remove(baseItem_2);
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
			idesignTimeProvider_0.InsertItemAt(baseItem_2, int_13, bool_14);
			idesignTimeProvider_0 = null;
		}
		idesignTimeProvider_1 = null;
		baseItem_2 = null;
		bool_13 = false;
		((Control)this).set_Capture(false);
	}

	private void method_20(MouseEventArgs mouseEventArgs_1)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Invalid comparison between Unknown and I4
		IOwner owner = Owner as IOwner;
		BaseItem baseItem = ItemAtLocation(mouseEventArgs_1.get_X(), mouseEventArgs_1.get_Y());
		if (baseItem != null && baseItem.Parent is GalleryContainer)
		{
			GalleryContainer galleryContainer = baseItem.Parent as GalleryContainer;
			if (galleryContainer.method_36(mouseEventArgs_1.get_X(), mouseEventArgs_1.get_Y()))
			{
				baseItem = galleryContainer;
			}
		}
		if (baseItem != null && baseItem.SystemItem)
		{
			baseItem = null;
		}
		if (baseItem == null)
		{
			if ((int)mouseEventArgs_1.get_Button() != 2097152)
			{
				return;
			}
			ISite site = method_17();
			if (site != null)
			{
				ISelectionService selectionService = (ISelectionService)site.GetService(typeof(ISelectionService));
				if (selectionService.PrimarySelection == m_ParentItem)
				{
					((IMenuCommandService)site.GetService(typeof(IMenuCommandService)))?.ShowContextMenu(MenuCommands.SelectionMenu, Control.get_MousePosition().X, Control.get_MousePosition().Y);
				}
			}
			return;
		}
		BaseItem baseItem2 = method_14();
		if (baseItem2 != null && m_HotSubItem != baseItem2)
		{
			baseItem2.Expanded = false;
		}
		if (owner != null)
		{
			owner.SetFocusItem(baseItem);
			ISite site2 = method_17();
			if (site2 != null)
			{
				ISelectionService selectionService2 = (ISelectionService)site2.GetService(typeof(ISelectionService));
				if (selectionService2 != null)
				{
					ArrayList arrayList = new ArrayList(1);
					arrayList.Add(baseItem);
					selectionService2.SetSelectedComponents(arrayList, SelectionTypes.Click);
				}
				if ((int)mouseEventArgs_1.get_Button() == 2097152)
				{
					((IMenuCommandService)site2.GetService(typeof(IMenuCommandService)))?.ShowContextMenu(MenuCommands.SelectionMenu, Control.get_MousePosition().X, Control.get_MousePosition().Y);
				}
			}
		}
		owner = null;
		baseItem?.InternalMouseDown(mouseEventArgs_1);
	}

	internal void method_21()
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		if (m_ParentItem == null)
		{
			return;
		}
		BaseItem baseItem = null;
		foreach (BaseItem subItem in m_ParentItem.SubItems)
		{
			if (subItem.Displayed && subItem.method_2() && (!(subItem is ItemContainer) || ((ItemContainer)subItem).method_28()))
			{
				baseItem = subItem;
				break;
			}
		}
		if (baseItem == null || m_HotSubItem == baseItem)
		{
			return;
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			if (bool_0)
			{
				method_30();
				bool_0 = false;
			}
		}
		if (baseItem != null)
		{
			if (!(baseItem is ItemContainer))
			{
				baseItem.InternalMouseEnter();
				baseItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, baseItem.LeftInternal + 1, baseItem.TopInternal + 1, 0));
			}
			m_HotSubItem = baseItem;
		}
	}

	private void method_22(BaseItem baseItem_3)
	{
		method_30();
		if (baseItem_0 != null && baseItem_0 != baseItem_3)
		{
			baseItem_0.Expanded = false;
		}
		if (!bool_9)
		{
			baseItem_3.Expanded = false;
			baseItem_0 = null;
			bool_9 = true;
		}
		else
		{
			baseItem_0 = baseItem_3;
			baseItem_0.InternalMouseLeave();
		}
	}

	internal void method_23()
	{
		if ((m_ParentItem != null && m_ParentItem.DesignMode) || m_ParentItem == null)
		{
			return;
		}
		if (baseItem_0 != null)
		{
			baseItem_0.Expanded = false;
			baseItem_0 = null;
		}
		if (m_HotSubItem != null)
		{
			bool flag = false;
			flag = m_HotSubItem.Expanded;
			m_HotSubItem.InternalMouseHover();
			bool_0 = true;
			if (!flag && m_HotSubItem != null && m_HotSubItem.Expanded)
			{
				bool_9 = true;
			}
			else
			{
				bool_9 = true;
			}
		}
		else if (struct18_0.bool_1 && struct18_0.bool_2)
		{
			if (ePersonalizedMenus_0 != ePersonalizedMenus.DisplayOnClick)
			{
				struct18_0.bool_0 = true;
				if (object_0 is IOwnerMenuSupport ownerMenuSupport)
				{
					ownerMenuSupport.PersonalizedAllVisible = true;
				}
				RecalcSize();
				method_30();
			}
		}
		else if (bool_1 && timer_0 == null)
		{
			method_32();
			method_30();
		}
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		method_23();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		if ((m_ParentItem != null && m_ParentItem.DesignMode) || m_ParentItem == null)
		{
			return;
		}
		if (m_HotSubItem != null)
		{
			Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
			if (!m_HotSubItem.DisplayRectangle.Contains(pt) && (!(m_HotSubItem is PopupItem) || !m_HotSubItem.Expanded))
			{
				m_HotSubItem.InternalMouseLeave();
				m_HotSubItem = null;
			}
		}
		else if (struct18_0.bool_1 && struct18_0.bool_2)
		{
			struct18_0.bool_2 = false;
			method_7();
		}
		if (m_HotSubItem == null)
		{
			BaseItem baseItem = method_14();
			if (baseItem != null && baseItem is PopupItem)
			{
				m_HotSubItem = baseItem;
				m_HotSubItem.InternalMouseEnter();
				m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.DisplayRectangle.X + 4, m_HotSubItem.DisplayRectangle.Y + 4, 0));
			}
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		if (m_ParentItem == null)
		{
			return;
		}
		ShowKeyTips = false;
		IOwner owner = Owner as IOwner;
		point_0 = new Point(e.get_X(), e.get_Y());
		if (m_ParentItem.DesignMode)
		{
			method_20(e);
		}
		if (!((Component)this).DesignMode && owner != null && owner.GetFocusItem() != null)
		{
			BaseItem baseItem = ItemAtLocation(e.get_X(), e.get_Y());
			if (baseItem != owner.GetFocusItem())
			{
				owner.GetFocusItem().ReleaseFocus();
			}
		}
		if ((int)e.get_Button() == 2097152 && m_HotSubItem != null && !Boolean_6 && owner is IRibbonCustomize && m_ParentItem != null && m_ParentItem.Name != "syscustomizepopupmenu")
		{
			((IRibbonCustomize)owner).ItemRightClick(m_HotSubItem);
		}
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseDown(e);
		}
		else if (struct18_0.bool_1 && struct18_0.bool_2)
		{
			method_7();
		}
		((Control)this).OnMouseDown(e);
	}

	internal void method_24(MouseEventArgs mouseEventArgs_1)
	{
		((Control)this).OnMouseUp(mouseEventArgs_1);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (bool_13)
		{
			method_19(e);
		}
		else if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseUp(e);
		}
		else if (struct18_0.bool_1 && struct18_0.bool_2)
		{
			if (ePersonalizedMenus_0 != ePersonalizedMenus.DisplayOnHover && struct18_0.rectangle_0.Contains(e.get_X(), e.get_Y()))
			{
				method_25();
			}
			else
			{
				method_7();
			}
		}
		((Control)this).OnMouseUp(e);
	}

	internal void method_25()
	{
		if (ePersonalizedMenus_0 != ePersonalizedMenus.DisplayOnHover)
		{
			struct18_0.bool_0 = true;
			if (Owner is IOwnerMenuSupport ownerMenuSupport)
			{
				ownerMenuSupport.PersonalizedAllVisible = true;
			}
			RecalcSize();
		}
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((m_ParentItem == null || !m_ParentItem.DesignMode) && m_ParentItem != null)
		{
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalClick(Control.get_MouseButtons(), Control.get_MousePosition());
			}
			else if (bool_1)
			{
				method_32();
			}
			((Control)this).OnClick(e);
		}
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		ISite site = method_17();
		if (site != null && site.DesignMode)
		{
			ISelectionService selectionService = (ISelectionService)site.GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				((IDesignerHost)site.GetService(typeof(IDesignerHost)))?.GetDesigner(selectionService.PrimarySelection as IComponent)?.DoDefaultAction();
			}
		}
		if ((m_ParentItem == null || !m_ParentItem.DesignMode) && m_ParentItem != null)
		{
			if (m_HotSubItem != null)
			{
				m_HotSubItem.InternalDoubleClick(Control.get_MouseButtons(), Control.get_MousePosition());
			}
			((Control)this).OnDoubleClick(e);
		}
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (m_ParentItem != null && m_ParentItem.SubItems.Count != 0)
		{
			method_27(e);
			((Control)this).OnKeyDown(e);
		}
		else
		{
			((Control)this).OnKeyDown(e);
		}
	}

	private bool method_26(BaseItem baseItem_3)
	{
		if (baseItem_3 is LabelItem)
		{
			return false;
		}
		return true;
	}

	internal void method_27(KeyEventArgs keyEventArgs_0)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Invalid comparison between Unknown and I4
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Invalid comparison between Unknown and I4
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Invalid comparison between Unknown and I4
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Invalid comparison between Unknown and I4
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Invalid comparison between Unknown and I4
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Invalid comparison between Unknown and I4
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064e: Invalid comparison between Unknown and I4
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Invalid comparison between Unknown and I4
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Invalid comparison between Unknown and I4
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		if (m_ParentItem == null || m_ParentItem.SubItems.Count == 0 || m_ParentItem.DesignMode)
		{
			return;
		}
		if (m_HotSubItem == null || (m_HotSubItem != null && !m_HotSubItem.Expanded))
		{
			if ((int)keyEventArgs_0.get_KeyCode() == 40)
			{
				if (m_ParentItem is ItemContainer)
				{
					m_ParentItem.InternalKeyDown(keyEventArgs_0);
				}
				else
				{
					if (m_HotSubItem is ItemContainer)
					{
						m_HotSubItem.InternalKeyDown(keyEventArgs_0);
					}
					if (!keyEventArgs_0.get_Handled())
					{
						int num = 0;
						if (m_HotSubItem != null)
						{
							m_HotSubItem.InternalMouseLeave();
							num = m_ParentItem.SubItems.IndexOf(m_HotSubItem) + 1;
							if (num == m_ParentItem.SubItems.Count && struct18_0.bool_1)
							{
								struct18_0.bool_2 = true;
								method_7();
							}
							else if (num < 0 || num == m_ParentItem.SubItems.Count)
							{
								num = 0;
							}
							m_HotSubItem = null;
						}
						else if (struct18_0.bool_2)
						{
							struct18_0.bool_2 = false;
							method_7();
							num = 0;
						}
						for (int i = num; i < m_ParentItem.SubItems.Count; i++)
						{
							BaseItem baseItem = m_ParentItem.SubItems[i];
							if (baseItem.Displayed && baseItem.Visible && method_26(baseItem))
							{
								m_HotSubItem = baseItem;
								m_HotSubItem.InternalMouseEnter();
								m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 2, m_HotSubItem.TopInternal + 2, 0));
								if (m_HotSubItem.IsContainer)
								{
									m_HotSubItem.InternalKeyDown(keyEventArgs_0);
								}
								break;
							}
						}
						if (m_HotSubItem == null && struct18_0.bool_1 && !struct18_0.bool_2)
						{
							struct18_0.bool_2 = true;
							method_7();
						}
					}
				}
				keyEventArgs_0.set_Handled(true);
				bool_5 = true;
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 38)
			{
				if (m_ParentItem is ItemContainer)
				{
					m_ParentItem.InternalKeyDown(keyEventArgs_0);
				}
				else
				{
					if (m_HotSubItem is ItemContainer)
					{
						m_HotSubItem.InternalKeyDown(keyEventArgs_0);
					}
					if (!keyEventArgs_0.get_Handled())
					{
						int num2 = 0;
						if (m_HotSubItem != null)
						{
							m_HotSubItem.InternalMouseLeave();
							num2 = m_ParentItem.SubItems.IndexOf(m_HotSubItem) - 1;
							if (num2 < 0 && struct18_0.bool_1)
							{
								struct18_0.bool_2 = true;
								method_7();
							}
							else if (num2 < 0)
							{
								num2 = m_ParentItem.SubItems.Count - 1;
							}
							m_HotSubItem = null;
						}
						else if (struct18_0.bool_2)
						{
							struct18_0.bool_2 = false;
							method_7();
							num2 = m_ParentItem.SubItems.Count - 1;
						}
						else if (struct18_0.bool_1)
						{
							struct18_0.bool_2 = true;
							method_7();
						}
						else
						{
							num2 = m_ParentItem.SubItems.Count - 1;
						}
						int num3 = num2;
						while (num3 >= 0)
						{
							BaseItem baseItem2 = m_ParentItem.SubItems[num3];
							if (!baseItem2.Displayed || !baseItem2.Visible || !method_26(baseItem2))
							{
								num3--;
								continue;
							}
							m_HotSubItem = baseItem2;
							m_HotSubItem.InternalMouseEnter();
							m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 2, m_HotSubItem.TopInternal + 2, 0));
							if (m_HotSubItem.IsContainer)
							{
								m_HotSubItem.InternalKeyDown(keyEventArgs_0);
							}
							break;
						}
						if (m_HotSubItem == null && struct18_0.bool_1 && !struct18_0.bool_2)
						{
							struct18_0.bool_2 = true;
							method_7();
						}
					}
				}
				keyEventArgs_0.set_Handled(true);
				bool_5 = true;
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 39)
			{
				bool_5 = true;
				if (m_HotSubItem != null && m_HotSubItem.method_2() && m_HotSubItem is ButtonItem buttonItem && buttonItem.SubItems.Count > 0 && buttonItem.ShowSubItems && !buttonItem.Expanded)
				{
					buttonItem.Expanded = true;
					if (buttonItem.PopupControl is MenuPanel)
					{
						((MenuPanel)(object)buttonItem.PopupControl).method_21();
					}
					keyEventArgs_0.set_Handled(true);
				}
				if (m_HotSubItem != null && m_HotSubItem is ItemContainer)
				{
					m_HotSubItem.InternalKeyDown(keyEventArgs_0);
				}
				if (!keyEventArgs_0.get_Handled() && m_ParentItem != null)
				{
					foreach (BaseItem subItem in m_ParentItem.SubItems)
					{
						if (subItem is ItemContainer)
						{
							subItem.InternalKeyDown(keyEventArgs_0);
							if (keyEventArgs_0.get_Handled())
							{
								break;
							}
						}
					}
				}
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 37)
			{
				if (m_HotSubItem != null && m_HotSubItem is ItemContainer)
				{
					m_HotSubItem.InternalKeyDown(keyEventArgs_0);
				}
				if (!keyEventArgs_0.get_Handled())
				{
					bool_5 = true;
					if (BaseItem.IsOnPopup(m_ParentItem))
					{
						m_ParentItem.Expanded = false;
						keyEventArgs_0.set_Handled(true);
					}
				}
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 27)
			{
				BaseItem parentItem = m_ParentItem;
				parentItem.Expanded = false;
				if (parentItem.Parent != null && parentItem.Parent is GenericItemContainer && parentItem.Parent.AutoExpand)
				{
					parentItem.Parent.AutoExpand = false;
				}
				keyEventArgs_0.set_Handled(true);
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 13 && m_HotSubItem != null && m_HotSubItem.IsContainer)
			{
				m_HotSubItem.InternalKeyDown(keyEventArgs_0);
			}
			else if ((int)keyEventArgs_0.get_KeyCode() == 13 && m_HotSubItem != null && m_HotSubItem.SubItems.Count > 0 && m_HotSubItem.ShowSubItems && !m_HotSubItem.Expanded && m_HotSubItem.method_2())
			{
				m_HotSubItem.Expanded = true;
				if (m_HotSubItem is PopupItem && ((PopupItem)m_HotSubItem).PopupControl is MenuPanel)
				{
					((MenuPanel)(object)((PopupItem)m_HotSubItem).PopupControl).method_21();
				}
				keyEventArgs_0.set_Handled(true);
			}
			else if (((int)keyEventArgs_0.get_KeyCode() == 13 || (int)keyEventArgs_0.get_KeyCode() == 32) && struct18_0.bool_1 && struct18_0.bool_2)
			{
				method_25();
			}
			else
			{
				int num4 = 0;
				if (keyEventArgs_0.get_Shift())
				{
					try
					{
						byte[] array = new byte[256];
						if (Class92.GetKeyboardState(array))
						{
							byte[] array2 = new byte[2];
							if (Class92.ToAscii((uint)keyEventArgs_0.get_KeyValue(), 0u, array, array2, 0u) != 0)
							{
								num4 = array2[0];
							}
						}
					}
					catch (Exception)
					{
						num4 = 0;
					}
				}
				if (num4 == 0 && !Class109.smethod_64(keyEventArgs_0.get_KeyCode()))
				{
					num4 = (int)Class92.MapVirtualKey((uint)keyEventArgs_0.get_KeyValue(), 2u);
					if (num4 == 0)
					{
						num4 = keyEventArgs_0.get_KeyValue();
					}
				}
				if (num4 > 0)
				{
					char[] array3 = new char[1];
					byte[] bytes = new byte[1] { Convert.ToByte(num4) };
					Encoding.Default.GetDecoder().GetChars(bytes, 0, 1, array3, 0);
					string text = array3[0].ToString();
					array3[0] = text.ToLower()[0];
					if (method_28(m_ParentItem, array3[0]))
					{
						keyEventArgs_0.set_Handled(true);
					}
				}
			}
		}
		if (!keyEventArgs_0.get_Handled() && m_HotSubItem != null)
		{
			m_HotSubItem.InternalKeyDown(keyEventArgs_0);
		}
	}

	private bool method_28(BaseItem baseItem_3, char char_0)
	{
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		BaseItem itemForMnemonic = GetItemForMnemonic(baseItem_3, char_0, deepScan: true);
		if (itemForMnemonic != null && itemForMnemonic.method_2() && itemForMnemonic.Visible)
		{
			if (itemForMnemonic.SubItems.Count > 0 && itemForMnemonic.ShowSubItems && !itemForMnemonic.Expanded)
			{
				if (m_HotSubItem != itemForMnemonic)
				{
					if (m_HotSubItem != null)
					{
						m_HotSubItem.InternalMouseLeave();
					}
					m_HotSubItem = itemForMnemonic;
					m_HotSubItem.InternalMouseEnter();
					m_HotSubItem.InternalMouseMove(new MouseEventArgs((MouseButtons)0, 0, m_HotSubItem.LeftInternal + 2, m_HotSubItem.TopInternal + 2, 0));
				}
				itemForMnemonic.Expanded = true;
				if (itemForMnemonic is PopupItem && ((PopupItem)itemForMnemonic).PopupControl is MenuPanel)
				{
					((MenuPanel)(object)((PopupItem)itemForMnemonic).PopupControl).method_21();
				}
				bool_5 = true;
			}
			else
			{
				ShowKeyTips = false;
				itemForMnemonic.RaiseClick();
			}
			return true;
		}
		return false;
	}

	protected virtual BaseItem GetItemForMnemonic(BaseItem container, char charCode, bool deepScan)
	{
		string text = string_0 + charCode;
		text = text.ToUpper();
		bool flag = false;
		foreach (BaseItem subItem in container.SubItems)
		{
			if (!(subItem.KeyTips != "") && !(string_0 != ""))
			{
				if (Control.IsMnemonic(charCode, subItem.Text) && subItem.Visible && subItem.method_2())
				{
					return subItem;
				}
			}
			else if (subItem.KeyTips != "")
			{
				if (subItem.KeyTips == text)
				{
					if (subItem.Visible && subItem.method_2())
					{
						return subItem;
					}
				}
				else if (subItem.KeyTips.StartsWith(text))
				{
					flag = true;
				}
			}
			if (deepScan && subItem.IsContainer)
			{
				BaseItem itemForMnemonic = GetItemForMnemonic(subItem, charCode, deepScan);
				if (itemForMnemonic != null)
				{
					return itemForMnemonic;
				}
			}
			else if (deepScan && subItem is ControlContainerItem && ((ControlContainerItem)subItem).Control is RibbonBar)
			{
				RibbonBar ribbonBar = ((ControlContainerItem)subItem).Control as RibbonBar;
				BaseItem itemForMnemonic2 = GetItemForMnemonic(ribbonBar.method_17(), charCode, deepScan);
				if (itemForMnemonic2 != null)
				{
					return itemForMnemonic2;
				}
			}
		}
		if (flag)
		{
			string_0 += charCode.ToString().ToUpper();
		}
		return null;
	}

	protected BaseItem ItemAtLocation(int x, int y)
	{
		if (m_ParentItem != null && m_ParentItem.SubItems.Count != 0)
		{
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				if ((!subItem.Visible && !bool_4) || !subItem.Displayed || x < subItem.LeftInternal || x > subItem.LeftInternal + subItem.WidthInternal || y < subItem.TopInternal || y > subItem.TopInternal + subItem.HeightInternal)
				{
					continue;
				}
				if (subItem.IsContainer)
				{
					BaseItem baseItem2 = subItem.ItemAtLocation(x, y);
					if (baseItem2 != null)
					{
						return baseItem2;
					}
				}
				return subItem;
			}
		}
		return null;
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_29();
		((Control)this).OnHandleDestroyed(e);
	}

	internal void method_29()
	{
		if (m_HotSubItem != null)
		{
			m_HotSubItem.InternalMouseLeave();
			m_HotSubItem = null;
		}
	}

	private void method_30()
	{
		Class92.TRACKMOUSEEVENT tme = default(Class92.TRACKMOUSEEVENT);
		tme.dwFlags = 1073741824u;
		tme.hwndTrack = ((Control)this).get_Handle();
		tme.cbSize = Marshal.SizeOf((object)tme);
		Class92.TrackMouseEvent(ref tme);
		tme.dwFlags |= 1u;
		Class92.TrackMouseEvent(ref tme);
	}

	private void method_31()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		timer_0 = new Timer();
		timer_0.set_Interval(100);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		method_32();
	}

	private bool method_32()
	{
		if (!bool_1)
		{
			return false;
		}
		Point point = ((Control)this).PointToClient(Control.get_MousePosition());
		if (bool_2 && point.Y <= int_9 + rectangle_0.Top)
		{
			if (int_8 > 0)
			{
				int_8--;
			}
			method_33();
			((Control)this).Refresh();
			if (timer_0 == null)
			{
				method_31();
			}
			return true;
		}
		if (bool_3 && point.Y >= ((Control)this).get_Height() - int_10)
		{
			int_8++;
			method_33();
			((Control)this).Refresh();
			if (timer_0 == null)
			{
				method_31();
			}
			return true;
		}
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		return false;
	}

	private void method_33()
	{
		bool_2 = false;
		bool_3 = false;
		if (!bool_1 || m_ParentItem == null || m_ParentItem.SubItems.Count == 0)
		{
			return;
		}
		int num = rectangle_0.Top;
		int num2 = 0;
		if (int_8 > 0)
		{
			int_9 = 16;
			num += int_9;
			bool_2 = true;
		}
		bool flag = false;
		int num3 = 0;
		BaseItem baseItem;
		while (true)
		{
			if (num3 >= m_ParentItem.SubItems.Count)
			{
				return;
			}
			baseItem = m_ParentItem.SubItems[num3];
			if (!flag && num3 >= int_8 && (baseItem.Visible || bool_4))
			{
				num2 = baseItem.HeightInternal;
				if (baseItem.BeginGroup)
				{
					num2 = ((m_ParentItem.Style != eDotNetBarStyle.Office2000) ? (num2 + 3) : (num2 + 9));
				}
				if (num2 + num <= rectangle_0.Bottom && (rectangle_0.Bottom - (num2 + num) >= 15 || num3 + 1 >= m_ParentItem.SubItems.Count))
				{
					if (num3 == m_ParentItem.SubItems.Count - 1)
					{
						break;
					}
					if (baseItem.BeginGroup)
					{
						num = ((m_ParentItem.Style != eDotNetBarStyle.Office2000) ? (num + 3) : (num + 9));
					}
					baseItem.TopInternal = num;
					baseItem.Displayed = true;
					num += baseItem.HeightInternal;
				}
				else
				{
					baseItem.Displayed = false;
					flag = true;
					bool_3 = true;
					int_10 = rectangle_0.Bottom - num;
				}
			}
			else
			{
				baseItem.Displayed = false;
			}
			num3++;
		}
		baseItem.Displayed = true;
		num = rectangle_0.Bottom;
		for (int num4 = num3; num4 >= int_8; num4--)
		{
			baseItem = m_ParentItem.SubItems[num4];
			if (baseItem.Visible || bool_4)
			{
				num = (baseItem.TopInternal = num - baseItem.HeightInternal);
				if (baseItem.BeginGroup)
				{
					num = ((m_ParentItem.Style != eDotNetBarStyle.Office2000) ? (num - 3) : (num - 9));
				}
			}
		}
		if (int_8 > 0)
		{
			baseItem = m_ParentItem.SubItems[int_8 - 1];
			if (num - baseItem.HeightInternal - 15 > rectangle_0.Top)
			{
				for (int num6 = int_8 - 1; num6 >= 0; num6--)
				{
					baseItem = m_ParentItem.SubItems[num6];
					if (baseItem.Visible || bool_4)
					{
						if (num - baseItem.HeightInternal - 15 <= rectangle_0.Top)
						{
							break;
						}
						num = (baseItem.TopInternal = num - baseItem.HeightInternal);
						baseItem.Displayed = true;
						if (baseItem.BeginGroup)
						{
							num = ((m_ParentItem.Style != eDotNetBarStyle.Office2000) ? (num - 3) : (num - 9));
						}
						int_8 = num6;
					}
				}
			}
		}
		int_9 = num - rectangle_0.Top;
		bool_3 = false;
	}

	private void method_34(Control control_0)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Rectangle clientRectangle = control_0.get_ClientRectangle();
		clientRectangle.Width--;
		clientRectangle.Height--;
		GraphicsPath val = Class50.smethod_13(clientRectangle, int_12);
		Region val2 = new Region();
		val2.MakeEmpty();
		val2.Union(val);
		val.Widen(SystemPens.get_ControlText());
		val2.Union(val);
		control_0.set_Region(val2);
	}

	public void Hide()
	{
		((Control)this).Hide();
		if (bool_15 && ((Control)this).get_Parent() != null)
		{
			((Control)this).get_Parent().get_Controls().Remove((Control)(object)this);
			bool_15 = false;
		}
	}

	private bool method_35()
	{
		ISite site = method_17();
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
			Point location = val.PointToClient(((Control)this).get_Location());
			val.get_Controls().Add((Control)(object)this);
			((Control)this).set_Location(location);
			((Control)this).set_Visible(true);
			((Control)this).Update();
			((Control)this).BringToFront();
			bool_15 = true;
			return true;
		}
		return false;
	}

	public void Show()
	{
		if (!bool_7)
		{
			((Control)this).set_Visible(true);
			((Control)this).Update();
		}
		else
		{
			if (m_ParentItem != null && ((m_ParentItem.Site != null && m_ParentItem.Site.DesignMode) || m_ParentItem.DesignMode || (m_ParentItem.Parent != null && m_ParentItem.Parent.Site != null && m_ParentItem.Parent.Site.DesignMode)) && method_35())
			{
				return;
			}
			PopupContainer popupContainer = new PopupContainer();
			popupContainer.ShowDropShadow = Boolean_4 && Boolean_5;
			Class273 @class = Class109.smethod_53((Control)(object)this);
			if (@class != null)
			{
				Rectangle rectangle = @class.rectangle_1;
				if (Boolean_3 || bool_11)
				{
					rectangle = @class.rectangle_0;
				}
				if (((Control)this).get_Location().Y + ((Control)this).get_Size().Height > rectangle.Bottom)
				{
					rectangle_0.Height -= ((Control)this).get_Location().Y + ((Control)this).get_Size().Height - rectangle.Bottom;
					((Control)this).set_Height(((Control)this).get_Height() - (((Control)this).get_Location().Y + ((Control)this).get_Size().Height - rectangle.Bottom));
					bool_1 = true;
					int_8 = 0;
					method_33();
				}
			}
			((Control)popupContainer).set_Location(((Control)this).get_Location());
			((Control)popupContainer).get_Controls().Add((Control)(object)this);
			((Control)popupContainer).set_Size(((Control)this).get_Size());
			((Control)this).set_Location(new Point(0, 0));
			((Control)popupContainer).CreateControl();
			if (Class109.smethod_69(m_ParentItem.Style) && Boolean_2)
			{
				method_34((Control)(object)this);
				method_34((Control)(object)popupContainer);
			}
			ePopupAnimation ePopupAnimation2 = ePopupAnimation_0;
			if (!Class109.Boolean_1)
			{
				ePopupAnimation2 = ePopupAnimation.None;
			}
			else
			{
				if (ePopupAnimation2 == ePopupAnimation.ManagerControlled)
				{
					if (object_0 is IOwnerMenuSupport ownerMenuSupport)
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
			if (((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0)
			{
				ePopupAnimation2 = ePopupAnimation.None;
			}
			if (ePopupAnimation2 == ePopupAnimation.Fade && Environment.OSVersion.Version.Major >= 5)
			{
				Class92.AnimateWindow(((Control)popupContainer).get_Handle().ToInt32(), 100, 524288);
				((Control)popupContainer).set_Visible(true);
			}
			else
			{
				switch (ePopupAnimation2)
				{
				case ePopupAnimation.Slide:
					Class92.AnimateWindow(((Control)popupContainer).get_Handle().ToInt32(), 100, 262149);
					((Control)popupContainer).set_Visible(true);
					break;
				case ePopupAnimation.Unfold:
					Class92.AnimateWindow(((Control)popupContainer).get_Handle().ToInt32(), 100, 5);
					((Control)popupContainer).set_Visible(true);
					break;
				default:
					((Control)this).set_Visible(true);
					((Control)popupContainer).set_Visible(true);
					break;
				}
			}
			popupContainer.ShowShadow();
			if (ePopupAnimation2 != 0 && ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() > 0)
			{
				((Control)this).Refresh();
			}
			if (new Rectangle(((Control)popupContainer).get_Location(), ((Control)popupContainer).get_Size()).Contains(Control.get_MousePosition()))
			{
				bool_5 = true;
			}
			((Control)this).Update();
			if (((Control)this).get_AccessibilityObject() is PopupMenuAccessibleObject popupMenuAccessibleObject)
			{
				if (m_ParentItem != null && m_ParentItem.IsOnMenuBar)
				{
					popupMenuAccessibleObject.method_1((AccessibleEvents)4);
				}
				popupMenuAccessibleObject.method_1((AccessibleEvents)6);
			}
		}
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Control)this).get_Visible() && control8_0 != null)
		{
			((Control)control8_0).Hide();
			((Component)(object)control8_0).Dispose();
			control8_0 = null;
		}
		if (!((Control)this).get_Visible() && ((Control)this).get_Parent() != null && ((Control)this).get_Parent() is PopupContainer)
		{
			((Control)this).get_Parent().set_Visible(false);
		}
		if (!((Control)this).get_Visible() && timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
		if (!bool_6 || !(((Control)this).get_AccessibilityObject() is PopupMenuAccessibleObject popupMenuAccessibleObject))
		{
			return;
		}
		if (m_ParentItem != null)
		{
			foreach (BaseItem subItem in m_ParentItem.SubItems)
			{
				popupMenuAccessibleObject.method_0(subItem, (AccessibleEvents)32769);
			}
		}
		if (!((Control)this).get_Visible())
		{
			popupMenuAccessibleObject.method_1((AccessibleEvents)7);
			popupMenuAccessibleObject.method_1((AccessibleEvents)32778);
		}
	}

	public InsertPosition GetInsertPosition(Point pScreen, BaseItem DragItem)
	{
		if (m_ParentItem == null)
		{
			return null;
		}
		return DesignTimeProviderContainer.GetInsertPosition(m_ParentItem, pScreen, DragItem);
	}

	public void DrawReversibleMarker(int iPos, bool Before)
	{
		if (iPos >= 0)
		{
			BaseItem baseItem = m_ParentItem.SubItems[iPos];
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
			new Rectangle(((Control)this).get_ClientRectangle().Left + 2, ((Control)this).get_ClientRectangle().Top + 2, ((Control)this).get_ClientRectangle().Width - 4, 1);
			new Rectangle(((Control)this).get_ClientRectangle().Left + 1, ((Control)this).get_ClientRectangle().Top, 1, 5);
			new Rectangle(((Control)this).get_ClientRectangle().Right - 2, ((Control)this).get_ClientRectangle().Top, 1, 5);
		}
	}

	public void InsertItemAt(BaseItem objItem, int iPos, bool Before)
	{
		if (!Before)
		{
			if (iPos + 1 >= m_ParentItem.SubItems.Count)
			{
				m_ParentItem.SubItems.Add(objItem);
			}
			else
			{
				m_ParentItem.SubItems.Add(objItem, iPos + 1);
			}
		}
		else if (iPos >= m_ParentItem.SubItems.Count)
		{
			m_ParentItem.SubItems.Add(objItem);
		}
		else
		{
			m_ParentItem.SubItems.Add(objItem, iPos);
		}
		objItem.ContainerControl = this;
		method_29();
		RecalcSize();
		ISite site = method_17();
		if (site != null && m_ParentItem != null && ((Component)(object)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			componentChangeService.OnComponentChanged(m_ParentItem, TypeDescriptor.GetProperties(m_ParentItem)["SubItems"], null, null);
		}
	}
}
