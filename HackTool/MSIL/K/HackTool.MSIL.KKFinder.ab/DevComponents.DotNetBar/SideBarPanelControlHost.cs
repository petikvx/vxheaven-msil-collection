using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
[DesignTimeVisible(false)]
[ComVisible(false)]
public class SideBarPanelControlHost : Control, Interface6
{
	private SideBarPanelItem sideBarPanelItem_0;

	private BaseItem baseItem_0;

	private Point point_0 = Point.Empty;

	private Class77 class77_0;

	private Class78 class78_0;

	private Class79 class79_0;

	private Class65 class65_0;

	private Class63 class63_0;

	private Class81 class81_0;

	private Class64 class64_0;

	private Class82 class82_0;

	private Control3 control3_0;

	private Control3 control3_1;

	Class77 Interface6.Class77_0
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

	Class78 Interface6.Class78_0
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

	Class79 Interface6.Class79_0
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

	Class65 Interface6.Class65_0
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

	Class63 Interface6.Class63_0
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

	Class81 Interface6.Class81_0
	{
		get
		{
			if (class81_0 == null)
			{
				class81_0 = new Class81((Control)(object)this);
			}
			return class81_0;
		}
	}

	Class64 Interface6.Class64_0
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

	Class82 Interface6.Class82_0
	{
		get
		{
			if (class82_0 == null)
			{
				class82_0 = new Class82((Control)(object)this);
			}
			return class82_0;
		}
	}

	public SideBarPanelControlHost(SideBarPanelItem parentPanel)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).set_TabStop(false);
		control3_0 = new Control3();
		control3_0.bool_3 = false;
		control3_0.bool_4 = true;
		((Control)control3_0).set_Visible(false);
		control3_0.EOrientation_0 = eOrientation.Vertical;
		control3_0.EItemAlignment_0 = eItemAlignment.Near;
		ColorScheme colorScheme = null;
		if (parentPanel.ESideBarAppearance_0 == eSideBarAppearance.Flat)
		{
			((Control)control3_0).set_Size(new Size(14, 14));
			if (parentPanel.HeaderStyle != null)
			{
				colorScheme = new ColorScheme();
				colorScheme.ItemBackground = Color.Empty;
				colorScheme.ItemBackground = Color.Empty;
				colorScheme.ItemBackground = parentPanel.HeaderStyle.BackColor1.Color;
				colorScheme.ItemHotBackground = parentPanel.HeaderStyle.BackColor1.Color;
				colorScheme.ItemHotBackground2 = parentPanel.HeaderStyle.BackColor2.Color;
				colorScheme.ItemHotBorder = parentPanel.HeaderStyle.BorderColor.Color;
				colorScheme.ItemPressedBorder = parentPanel.HeaderStyle.BorderColor.Color;
				colorScheme.ItemText = parentPanel.HeaderStyle.ForeColor.Color;
				colorScheme.ItemHotText = parentPanel.HeaderStyle.ForeColor.Color;
				colorScheme.ItemPressedText = parentPanel.HeaderStyle.ForeColor.Color;
				colorScheme.ItemPressedBackground = ControlPaint.Light(parentPanel.HeaderStyle.BackColor1.Color);
				colorScheme.ItemPressedBackground2 = ControlPaint.Light(parentPanel.HeaderStyle.BackColor2.Color);
				control3_0.colorScheme_0 = colorScheme;
				control3_0.bool_4 = false;
			}
		}
		else
		{
			((Control)control3_0).set_Size(new Size(16, 16));
		}
		((Control)this).get_Controls().Add((Control)(object)control3_0);
		control3_1 = new Control3();
		control3_1.bool_3 = false;
		control3_1.bool_4 = true;
		((Control)control3_1).set_Visible(false);
		control3_1.EOrientation_0 = eOrientation.Vertical;
		control3_1.EItemAlignment_0 = eItemAlignment.Far;
		if (parentPanel.ESideBarAppearance_0 == eSideBarAppearance.Flat)
		{
			((Control)control3_1).set_Size(new Size(14, 14));
			if (colorScheme != null)
			{
				control3_1.colorScheme_0 = colorScheme;
				control3_1.bool_4 = false;
			}
		}
		else
		{
			((Control)control3_1).set_Size(new Size(16, 16));
		}
		((Control)this).get_Controls().Add((Control)(object)control3_1);
		((Control)control3_1).add_MouseDown(new MouseEventHandler(control3_0_MouseDown));
		((Control)control3_0).add_MouseDown(new MouseEventHandler(control3_0_MouseDown));
		sideBarPanelItem_0 = parentPanel;
		foreach (BaseItem subItem in sideBarPanelItem_0.SubItems)
		{
			subItem.ContainerControl = this;
		}
	}

	public void SetupScrollButtons()
	{
		if (sideBarPanelItem_0.TopItemIndex > 0 && sideBarPanelItem_0.EnableScrollButtons)
		{
			((Control)control3_0).set_Location(new Point(((Control)this).get_Width() - (((Control)control3_0).get_Width() + 2), 4));
			control3_0.bool_2 = sideBarPanelItem_0.Boolean_5;
			((Control)control3_0).BringToFront();
			if (!((Control)control3_0).get_Visible())
			{
				((Control)control3_0).set_Visible(true);
			}
		}
		else
		{
			((Control)control3_0).set_Visible(false);
		}
		if (sideBarPanelItem_0.Boolean_4 && sideBarPanelItem_0.EnableScrollButtons)
		{
			((Control)control3_1).set_Location(new Point(((Control)this).get_Width() - (((Control)control3_1).get_Width() + 2), ((Control)this).get_Height() - (((Control)control3_1).get_Height() + 2)));
			control3_1.bool_2 = sideBarPanelItem_0.Boolean_5;
			((Control)control3_1).BringToFront();
			if (!((Control)control3_1).get_Visible())
			{
				((Control)control3_1).set_Visible(true);
			}
		}
		else
		{
			((Control)control3_1).set_Visible(false);
		}
	}

	private void control3_0_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			if (sender == control3_0)
			{
				sideBarPanelItem_0.method_24(bool_31: true);
			}
			else
			{
				sideBarPanelItem_0.method_24(bool_31: false);
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (sideBarPanelItem_0 == null || ((Control)this).get_IsDisposed())
		{
			return;
		}
		ItemPaintArgs itemPaintArgs = null;
		SideBar sideBar = sideBarPanelItem_0.ContainerControl as SideBar;
		itemPaintArgs = ((sideBar == null) ? new ItemPaintArgs(sideBarPanelItem_0.GetOwner() as IOwner, (Control)(object)this, e.get_Graphics(), new ColorScheme(e.get_Graphics())) : new ItemPaintArgs(sideBarPanelItem_0.GetOwner() as IOwner, (Control)(object)this, e.get_Graphics(), sideBar.ColorScheme));
		itemPaintArgs.BaseRenderer_0 = sideBar.GetRenderer();
		if (sideBarPanelItem_0.Boolean_5)
		{
			((Interface6)this).Class78_0.method_0(e.get_Graphics(), Class139.class139_0, Class164.class164_0, ((Control)this).get_DisplayRectangle());
		}
		else if (!sideBarPanelItem_0.BackgroundStyle.BackColor1.IsEmpty)
		{
			if (sideBarPanelItem_0.ESideBarAppearance_0 == eSideBarAppearance.Flat)
			{
				eBorderSide borderSide = sideBarPanelItem_0.BackgroundStyle.BorderSide;
				sideBarPanelItem_0.BackgroundStyle.BorderSide = ~(borderSide & eBorderSide.Top) & borderSide;
				sideBarPanelItem_0.BackgroundStyle.Paint(e.get_Graphics(), ((Control)this).get_ClientRectangle());
				sideBarPanelItem_0.BackgroundStyle.BorderSide = borderSide;
			}
			else
			{
				sideBarPanelItem_0.BackgroundStyle.Paint(e.get_Graphics(), ((Control)this).get_ClientRectangle());
			}
		}
		else
		{
			Color color_ = SystemColors.Control;
			if (sideBar != null && sideBar.Style == eDotNetBarStyle.Office2007 && ((Control)sideBar).get_BackColor() == SystemColors.Control)
			{
				if (itemPaintArgs.BaseRenderer_0 is Office2007Renderer)
				{
					Class50.smethod_25(e.get_Graphics(), ((Control)this).get_ClientRectangle(), ((Office2007Renderer)itemPaintArgs.BaseRenderer_0).ColorTable.SideBar.Background);
					color_ = Color.Empty;
				}
			}
			else if (((Control)this).get_Parent() != null && ((Control)this).get_Parent().get_BackColor() != Color.Transparent)
			{
				color_ = ((Control)this).get_Parent().get_BackColor();
			}
			Class50.smethod_24(e.get_Graphics(), ((Control)this).get_ClientRectangle(), color_, Color.Empty);
		}
		for (int i = sideBarPanelItem_0.TopItemIndex; i < sideBarPanelItem_0.SubItems.Count; i++)
		{
			BaseItem baseItem = sideBarPanelItem_0.SubItems[i];
			if (baseItem.Displayed && baseItem.Visible)
			{
				baseItem.Paint(itemPaintArgs);
			}
		}
	}

	private void method_0(MouseButtons mouseButtons_0, Point point_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (baseItem_0 != null)
		{
			baseItem_0.InternalClick(mouseButtons_0, point_1);
		}
	}

	private void method_1(MouseButtons mouseButtons_0, Point point_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (baseItem_0 != null)
		{
			baseItem_0.InternalDoubleClick(mouseButtons_0, point_1);
		}
	}

	private void method_2(KeyEventArgs keyEventArgs_0)
	{
		if (sideBarPanelItem_0.DesignMode)
		{
			keyEventArgs_0.set_Handled(true);
		}
		else if (baseItem_0 != null)
		{
			baseItem_0.InternalKeyDown(keyEventArgs_0);
		}
	}

	private void method_3(MouseEventArgs mouseEventArgs_0)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Invalid comparison between Unknown and I4
		IOwner owner = null;
		point_0 = new Point(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
		BaseItem baseItem = sideBarPanelItem_0.ExpandedItem();
		if (baseItem != null && baseItem != baseItem_0 && !sideBarPanelItem_0.DesignMode)
		{
			baseItem.Expanded = false;
			sideBarPanelItem_0.AutoExpand = false;
		}
		if (sideBarPanelItem_0.DesignMode && sideBarPanelItem_0.CanCustomize)
		{
			if (sideBarPanelItem_0.IsContainer && sideBarPanelItem_0.SubItems.Count > 0)
			{
				BaseItem baseItem2 = method_6(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
				if (baseItem2 != null && baseItem2.CanCustomize && sideBarPanelItem_0.GetOwner() is IOwner owner2)
				{
					owner2.SetFocusItem(baseItem2);
				}
				baseItem2?.InternalMouseDown(mouseEventArgs_0);
			}
			if ((int)mouseEventArgs_0.get_Button() == 2097152 && !sideBarPanelItem_0.IsContainer && sideBarPanelItem_0.GetOwner() is IOwner owner3)
			{
				owner3.DesignTimeContextMenu(sideBarPanelItem_0);
			}
		}
		if (!sideBarPanelItem_0.DesignMode && sideBarPanelItem_0.GetOwner() is IOwner owner4 && owner4.GetFocusItem() != null)
		{
			BaseItem baseItem3 = method_6(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
			if (baseItem3 != owner4.GetFocusItem())
			{
				owner4.GetFocusItem().ReleaseFocus();
			}
		}
		if (baseItem_0 != null)
		{
			baseItem_0.InternalMouseDown(mouseEventArgs_0);
		}
	}

	private void method_4()
	{
		if (sideBarPanelItem_0.DesignMode || baseItem_0 == null)
		{
			return;
		}
		if (!sideBarPanelItem_0.AutoExpand)
		{
			BaseItem baseItem = sideBarPanelItem_0.ExpandedItem();
			if (baseItem != null && baseItem_0 != baseItem && (sideBarPanelItem_0.IsOnMenu || sideBarPanelItem_0.ContainerControl is Bar))
			{
				baseItem.Expanded = false;
			}
		}
		if (baseItem_0 != null)
		{
			baseItem_0.InternalMouseHover();
		}
	}

	public virtual void InternalMouseLeave()
	{
		if (!sideBarPanelItem_0.DesignMode && baseItem_0 != null)
		{
			baseItem_0.InternalMouseLeave();
			baseItem_0 = null;
		}
	}

	private void method_5(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if (sideBarPanelItem_0.DesignMode && (int)mouseEventArgs_0.get_Button() == 1048576 && (Math.Abs(mouseEventArgs_0.get_X() - point_0.X) >= 2 || Math.Abs(mouseEventArgs_0.get_Y() - point_0.Y) >= 2))
		{
			BaseItem baseItem = sideBarPanelItem_0.FocusedItem();
			if (baseItem != null && baseItem.CanCustomize)
			{
				if (!baseItem.SystemItem && sideBarPanelItem_0.GetOwner() is IOwner owner)
				{
					owner.StartItemDrag(baseItem);
				}
			}
			else if (!sideBarPanelItem_0.IsContainer && !sideBarPanelItem_0.SystemItem && sideBarPanelItem_0.CanCustomize && sideBarPanelItem_0.GetOwner() is IOwner owner2)
			{
				owner2.StartItemDrag(sideBarPanelItem_0);
			}
		}
		else
		{
			if (!sideBarPanelItem_0.IsContainer || sideBarPanelItem_0.DesignMode)
			{
				return;
			}
			BaseItem baseItem2 = method_6(mouseEventArgs_0.get_X(), mouseEventArgs_0.get_Y());
			if (baseItem2 != baseItem_0)
			{
				if (baseItem_0 != null)
				{
					baseItem_0.InternalMouseLeave();
					if (baseItem2 != null && baseItem_0.Expanded && (sideBarPanelItem_0.IsOnMenu || sideBarPanelItem_0.ContainerControl is Bar))
					{
						baseItem_0.Expanded = false;
					}
				}
				if (baseItem2 != null)
				{
					if (sideBarPanelItem_0.AutoExpand)
					{
						BaseItem baseItem3 = sideBarPanelItem_0.ExpandedItem();
						if (baseItem3 != null && baseItem3 != baseItem2)
						{
							baseItem3.Expanded = false;
						}
					}
					baseItem2.InternalMouseEnter();
					baseItem2.InternalMouseMove(mouseEventArgs_0);
					if (sideBarPanelItem_0.AutoExpand && baseItem2.Enabled && baseItem2.ShowSubItems)
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
					baseItem_0 = baseItem2;
					method_7();
				}
				else
				{
					baseItem_0 = null;
				}
			}
			else if (baseItem_0 != null)
			{
				baseItem_0.InternalMouseMove(mouseEventArgs_0);
			}
		}
	}

	private BaseItem method_6(int int_0, int int_1)
	{
		foreach (BaseItem subItem in sideBarPanelItem_0.SubItems)
		{
			if ((subItem.Visible || sideBarPanelItem_0.IsOnCustomizeMenu) && subItem.Displayed && subItem.DisplayRectangle.Contains(int_0, int_1))
			{
				return subItem;
			}
		}
		return null;
	}

	private void method_7()
	{
		Class92.TRACKMOUSEEVENT tme = default(Class92.TRACKMOUSEEVENT);
		tme.dwFlags = 1073741824u;
		tme.hwndTrack = ((Control)this).get_Handle();
		tme.cbSize = Marshal.SizeOf((object)tme);
		Class92.TrackMouseEvent(ref tme);
		tme.dwFlags |= 1u;
		Class92.TrackMouseEvent(ref tme);
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_0(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnClick(e);
	}

	protected override void OnDoubleClick(EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_1(Control.get_MouseButtons(), Control.get_MousePosition());
		((Control)this).OnDoubleClick(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		method_2(e);
		((Control)this).OnKeyDown(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		method_3(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		((Control)this).OnMouseHover(e);
		method_4();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (((Control)this).get_Cursor() != Cursors.get_Arrow())
		{
			((Control)this).set_Cursor(Cursors.get_Arrow());
		}
		InternalMouseLeave();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		method_5(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		if (baseItem_0 != null)
		{
			baseItem_0.InternalMouseUp(e);
		}
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		method_8();
		((Control)this).OnHandleDestroyed(e);
	}

	private void method_8()
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
		if (class81_0 != null)
		{
			class81_0.Dispose();
			class81_0 = null;
		}
		if (class82_0 != null)
		{
			class82_0.Dispose();
			class82_0 = null;
		}
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 794)
		{
			method_9();
		}
		((Control)this).WndProc(ref m);
	}

	private void method_9()
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
		if (class81_0 != null)
		{
			class81_0.Dispose();
			class81_0 = new Class81((Control)(object)this);
		}
	}
}
