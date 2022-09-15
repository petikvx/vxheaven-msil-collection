using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class BarBaseControlDesigner : ParentControlDesigner, IDesignerServices
{
	private const string string_0 = "tempDragDropItem";

	private bool bool_0;

	private bool bool_1 = true;

	private Point point_0 = Point.Empty;

	private BaseItem baseItem_0;

	private bool bool_2;

	private IDesignTimeProvider idesignTimeProvider_0;

	private int int_0;

	private bool bool_3;

	private bool bool_4;

	private Control control_0;

	private Timer timer_0;

	private Timer timer_1;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private DateTime dateTime_0 = DateTime.MinValue;

	private bool bool_9;

	private bool bool_10;

	protected bool m_AddingItem;

	protected bool m_CreatingItem;

	protected DesignerTransaction m_InsertItemTransaction;

	private bool bool_11;

	protected bool m_InternalRemoving;

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			BaseItem itemContainer = GetItemContainer();
			if (itemContainer != null)
			{
				foreach (BaseItem subItem in itemContainer.SubItems)
				{
					if (subItem.DesignMode)
					{
						arrayList.Add(subItem);
					}
				}
				return arrayList;
			}
			return arrayList;
		}
	}

	protected ICollection BaseAssociatedComponents => ((ControlDesigner)this).get_AssociatedComponents();

	protected virtual eDotNetBarStyle InternalStyle => eDotNetBarStyle.Office2003;

	protected virtual bool DragInProgress
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

	internal BaseItem BaseItem_0 => baseItem_0;

	protected virtual bool EnableItemDragDrop
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

	protected virtual bool AcceptExternalControls
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

	protected virtual bool IsDockableWindow => false;

	protected virtual bool MouseDownSelectionPerformed
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

	protected virtual bool PassiveContainer
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

	public override void Initialize(IComponent component)
	{
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		((ParentControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged += method_4;
			}
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += method_6;
				componentChangeService.ComponentRemoved += method_7;
				componentChangeService.ComponentAdding += method_0;
				componentChangeService.ComponentAdded += ComponentChangeComponentAdded;
			}
			if (((ComponentDesigner)this).GetService(typeof(IDesignerEventService)) is IDesignerEventService designerEventService)
			{
				designerEventService.ActiveDesignerChanged += method_5;
				designerEventService.SelectionChanged += method_11;
			}
			if (((ControlDesigner)this).get_Control() is IBarDesignerServices)
			{
				((IBarDesignerServices)((ControlDesigner)this).get_Control()).Designer = this;
			}
			if (((ControlDesigner)this).get_Control() is ItemControl)
			{
				((ItemControl)(object)((ControlDesigner)this).get_Control()).method_0(bool_25: true);
			}
			if (component is Control)
			{
				((Control)component).add_ControlAdded(new ControlEventHandler(method_1));
				((Control)component).add_ControlRemoved(new ControlEventHandler(method_2));
			}
		}
	}

	protected virtual void ComponentChangeComponentAdded(object sender, ComponentEventArgs e)
	{
		if (m_AddingItem)
		{
			m_AddingItem = false;
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ControlDesigner)this).get_Control(), null);
			GetItemContainer().SubItems.Add(e.Component as BaseItem);
			componentChangeService?.OnComponentChanged(((ControlDesigner)this).get_Control(), null, null, null);
			m_InsertItemTransaction.Commit();
			m_InsertItemTransaction = null;
			RecalcLayout();
		}
	}

	private void method_0(object sender, ComponentEventArgs e)
	{
		if (m_InsertItemTransaction == null && !m_AddingItem && !m_CreatingItem && e.Component is BaseItem && ((ComponentDesigner)this).GetService(typeof(ISelectionService)) is ISelectionService selectionService && selectionService.PrimarySelection == ((ControlDesigner)this).get_Control())
		{
			m_AddingItem = true;
			IDesignerHost designerHost = ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) as IDesignerHost;
			m_InsertItemTransaction = designerHost.CreateTransaction("Adding Item Clip");
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= method_6;
			componentChangeService.ComponentRemoved -= method_7;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null)
		{
			selectionService.SelectionChanged -= method_4;
		}
		if (((ComponentDesigner)this).GetService(typeof(IDesignerEventService)) is IDesignerEventService designerEventService)
		{
			designerEventService.ActiveDesignerChanged -= method_5;
			designerEventService.SelectionChanged -= method_11;
		}
		if (((ComponentDesigner)this).get_Component() is Control)
		{
			((Control)((ComponentDesigner)this).get_Component()).remove_ControlAdded(new ControlEventHandler(method_1));
			((Control)((ComponentDesigner)this).get_Component()).remove_ControlRemoved(new ControlEventHandler(method_2));
		}
		((ParentControlDesigner)this).Dispose(disposing);
	}

	public override bool CanParent(Control control)
	{
		BaseItem controlItem = GetControlItem(control);
		if (controlItem != null && controlItem != baseItem_0 && !bool_5)
		{
			return false;
		}
		return ((ParentControlDesigner)this).CanParent(control);
	}

	private void method_1(object sender, ControlEventArgs e)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if ((bool_5 && bool_0 && bool_1 && !IsDockableWindow) || (!bool_5 && OnControlAdded(e)))
		{
			timer_0 = new Timer();
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.set_Interval(50);
			timer_0.set_Enabled(true);
			timer_0.Start();
			bool_5 = false;
		}
	}

	protected virtual bool OnControlAdded(ControlEventArgs e)
	{
		return false;
	}

	private void method_2(object sender, ControlEventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null || designerHost.Loading || bool_11)
		{
			return;
		}
		if (dateTime_0 != DateTime.MinValue && DateTime.Now.Subtract(dateTime_0).Seconds < 2)
		{
			dateTime_0 = DateTime.MinValue;
			return;
		}
		dateTime_0 = DateTime.MinValue;
		if (bool_7)
		{
			method_3(e.get_Control());
			return;
		}
		if (timer_1 != null)
		{
			bool_8 = true;
			return;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection == e.get_Control() && GetControlItem(e.get_Control()) != null)
		{
			method_3(e.get_Control());
		}
	}

	private void method_3(Control control_1)
	{
		if (control_1 == null || bool_11)
		{
			return;
		}
		BaseItem controlItem = GetControlItem(control_1);
		if (controlItem != null)
		{
			method_10(-1, -1);
			if (controlItem.Parent != null)
			{
				controlItem.Parent.SubItems.Remove(controlItem);
			}
			if (controlItem is ControlContainerItem)
			{
				((ControlContainerItem)controlItem).Control = null;
			}
			DestroyComponent(controlItem);
			RecalcLayout();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		timer_0.Stop();
		timer_0.set_Enabled(false);
		timer_0 = null;
		RecalcLayout();
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection is Control && ((ControlDesigner)this).get_Control().get_Controls().Contains((Control)selectionService.PrimarySelection))
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService.OnComponentChanged(selectionService.PrimarySelection, null, null, null);
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		DesignTimeSelectionChanged(sender as ISelectionService);
	}

	private void method_5(object sender, ActiveDesignerEventArgs e)
	{
		ActiveDesignerChanged(e);
	}

	protected virtual void ActiveDesignerChanged(ActiveDesignerEventArgs e)
	{
		ClosePopups();
	}

	protected virtual void ClosePopups()
	{
		GetIOwner()?.OnApplicationDeactivate();
	}

	protected virtual IOwner GetIOwner()
	{
		return GetItemContainerControl() as IOwner;
	}

	protected virtual IOwnerMenuSupport GetIOwnerMenuSupport()
	{
		return GetItemContainerControl() as IOwnerMenuSupport;
	}

	protected virtual void DesignTimeSelectionChanged(ISelectionService ss)
	{
		if (ss == null || ((ControlDesigner)this).get_Control() == null || ((ControlDesigner)this).get_Control().get_IsDisposed() || IsDockableWindow)
		{
			return;
		}
		if (ss.PrimarySelection != ((ControlDesigner)this).get_Control())
		{
			BaseItem itemContainer = GetItemContainer();
			if (itemContainer == null)
			{
				return;
			}
			if (ss.PrimarySelection is BaseItem)
			{
				BaseItem baseItem = ss.PrimarySelection as BaseItem;
				if (baseItem.ContainerControl == GetItemContainerControl())
				{
					if ((!baseItem.IsOnMenu || (baseItem.IsOnBar && ((Bar)baseItem.ContainerControl).BarState == eBarState.Popup)) && (!baseItem.Expanded || !(baseItem is PopupItem)) && (!(baseItem is GalleryContainer) || !((GalleryContainer)baseItem).ButtonItem_0.Expanded))
					{
						GetIOwnerMenuSupport().ClosePopups();
					}
					return;
				}
				if (GetAllAssociatedComponents().Contains(baseItem))
				{
					if (!baseItem.IsOnMenu && (!baseItem.IsOnBar || ((Bar)baseItem.ContainerControl).BarState != 0))
					{
						GetIOwnerMenuSupport().ClosePopups();
					}
					return;
				}
				IOwner iOwner = GetIOwner();
				if (iOwner != null && iOwner != baseItem.GetOwner())
				{
					iOwner.SetFocusItem(null);
					iOwner.OnApplicationDeactivate();
				}
			}
			else
			{
				IOwner iOwner2 = GetIOwner();
				if (iOwner2 != null)
				{
					iOwner2.SetFocusItem(null);
					iOwner2.OnApplicationDeactivate();
				}
			}
		}
		else
		{
			GetIOwner()?.OnApplicationDeactivate();
		}
	}

	protected virtual BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is BarBaseControl barBaseControl)
		{
			return barBaseControl.method_10();
		}
		if (((ControlDesigner)this).get_Control() is ItemControl)
		{
			return ((ItemControl)(object)((ControlDesigner)this).get_Control()).method_17();
		}
		return null;
	}

	protected virtual Control GetItemContainerControl()
	{
		return ((ControlDesigner)this).get_Control();
	}

	private void method_6(object sender, ComponentEventArgs e)
	{
		if (e.Component == ((ComponentDesigner)this).get_Component())
		{
			ThisComponentRemoving(sender, e);
		}
		else
		{
			OtherComponentRemoving(sender, e);
		}
	}

	private void method_7(object sender, ComponentEventArgs e)
	{
		ComponentRemoved(sender, e);
	}

	protected virtual void ComponentRemoved(object sender, ComponentEventArgs e)
	{
	}

	protected virtual void ThisComponentRemoving(object sender, ComponentEventArgs e)
	{
		if (m_InternalRemoving)
		{
			return;
		}
		m_InternalRemoving = true;
		try
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving -= method_6;
			}
			BaseItem itemContainer = GetItemContainer();
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost == null || itemContainer == null)
			{
				return;
			}
			foreach (BaseItem subItem in itemContainer.SubItems)
			{
				if (subItem.Parent == itemContainer)
				{
					DestroySubItems(subItem, designerHost);
					designerHost.DestroyComponent(subItem);
				}
			}
		}
		finally
		{
			m_InternalRemoving = false;
		}
	}

	protected virtual void OtherComponentRemoving(object sender, ComponentEventArgs e)
	{
		if (!(e.Component is BaseItem))
		{
			return;
		}
		BaseItem baseItem = e.Component as BaseItem;
		if (baseItem.ContainerControl == GetItemContainerControl())
		{
			if (baseItem.Parent != null && baseItem.Parent.SubItems.Contains(baseItem))
			{
				baseItem.Parent.SubItems.Remove(baseItem);
			}
			if (baseItem != null)
			{
				DestroySubItems(baseItem);
			}
			RecalcLayout();
		}
	}

	protected virtual void DestroySubItems(BaseItem parent, IDesignerHost dh)
	{
		if (parent is ControlContainerItem)
		{
			if (((ControlContainerItem)parent).Control != null)
			{
				Control control = ((ControlContainerItem)parent).Control;
				((ControlContainerItem)parent).Control = null;
				dh.DestroyComponent((IComponent)control);
			}
		}
		else if (parent is DockContainerItem && ((DockContainerItem)parent).Control != null)
		{
			Control control2 = ((DockContainerItem)parent).Control;
			((DockContainerItem)parent).Control = null;
			dh.DestroyComponent((IComponent)control2);
		}
		BaseItem[] array = new BaseItem[parent.SubItems.Count];
		parent.SubItems.CopyTo(array, 0);
		BaseItem[] array2 = array;
		foreach (BaseItem baseItem in array2)
		{
			DestroySubItems(baseItem, dh);
			dh.DestroyComponent(baseItem);
		}
	}

	protected virtual void DestroySubItems(BaseItem parent)
	{
		if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost dh)
		{
			DestroySubItems(parent, dh);
		}
	}

	protected override void WndProc(ref Message m)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		if (control_0 == null)
		{
			control_0 = Control.FromHandle(((Message)(ref m)).get_HWnd());
		}
		BaseItem itemContainer = GetItemContainer();
		Control itemContainerControl = GetItemContainerControl();
		if (itemContainer != null && itemContainerControl != null && !itemContainerControl.get_IsDisposed())
		{
			switch (((Message)(ref m)).get_Msg())
			{
			case 675:
				if (OnMouseLeave(ref m))
				{
					break;
				}
				goto default;
			case 512:
				if (OnMouseMove(ref m))
				{
					((Message)(ref m)).set_Result(IntPtr.Zero);
					break;
				}
				goto default;
			case 515:
				if (OnMouseDoubleClick(m))
				{
					break;
				}
				goto default;
			case 513:
			case 516:
				if (OnMouseDown(ref m, (MouseButtons)((((Message)(ref m)).get_Msg() == 513) ? 1048576 : 2097152)))
				{
					break;
				}
				goto default;
			case 514:
			case 517:
				if (OnMouseUp(ref m))
				{
					break;
				}
				goto default;
			default:
				((ControlDesigner)this).WndProc(ref m);
				break;
			case 276:
			case 277:
				((ControlDesigner)this).WndProc(ref m);
				RecalcLayout();
				break;
			}
		}
		else
		{
			((ControlDesigner)this).WndProc(ref m);
		}
	}

	protected virtual bool OnMouseDown(ref Message m, MouseButtons button)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		if (IsDockableWindow)
		{
			return false;
		}
		Control itemContainerControl = GetItemContainerControl();
		BaseItem itemContainer = GetItemContainer();
		IOwner iOwner = GetIOwner();
		if (itemContainerControl != null && iOwner != null && itemContainer != null)
		{
			if (((Message)(ref m)).get_Msg() == 516)
			{
				Point point_ = itemContainerControl.PointToClient(Control.get_MousePosition());
				MouseEventArgs objArg = new MouseEventArgs((MouseButtons)1048576, 0, point_.X, point_.Y, 0);
				itemContainer.InternalMouseDown(objArg);
				BaseItem focusItem = iOwner.GetFocusItem();
				if (focusItem != null)
				{
					ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
					if (selectionService != null)
					{
						ArrayList arrayList = new ArrayList(1);
						arrayList.Add(focusItem);
						selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
						OnItemSelected(focusItem);
						if (arrayList[0] is PopupItem && ((PopupItem)arrayList[0]).SubItems.Count > 0 && !((PopupItem)arrayList[0]).Expanded)
						{
							((PopupItem)arrayList[0]).Expanded = true;
						}
						focusItem.point_1 = point_;
						((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	protected virtual bool OnMouseUp(ref Message m)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		bool result = false;
		if (bool_4)
		{
			bool_4 = false;
			Control val = Control.FromHandle(((Message)(ref m)).get_HWnd());
			if (val != null)
			{
				val.set_Capture(false);
			}
		}
		Control itemContainerControl = GetItemContainerControl();
		BaseItem itemContainer = GetItemContainer();
		IOwner iOwner = GetIOwner();
		if (itemContainerControl != null && iOwner != null && itemContainer != null)
		{
			Point point = itemContainerControl.PointToClient(Control.get_MousePosition());
			MouseEventArgs objArg = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
			itemContainer.InternalMouseUp(objArg);
			if (bool_9)
			{
				result = true;
			}
			bool_9 = false;
			if (baseItem_0 != null && baseItem_0 is ControlContainerItem && ((ControlContainerItem)baseItem_0).Control != null)
			{
				method_10(point.X, point.Y);
			}
			return result;
		}
		return false;
	}

	protected virtual bool OnMouseMove(ref Message m)
	{
		return false;
	}

	protected override void OnMouseDragBegin(int x, int y)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		if (bool_10)
		{
			((ParentControlDesigner)this).OnMouseDragBegin(x, y);
			return;
		}
		Control itemContainerControl = GetItemContainerControl();
		Control itemContainerControl2 = GetItemContainerControl();
		IOwner iOwner = GetIOwner();
		BaseItem itemContainer = GetItemContainer();
		Point point = itemContainerControl2.PointToClient(new Point(x, y));
		MouseEventArgs objArg = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
		BaseItem baseItem = null;
		iOwner.GetFocusItem();
		itemContainer.InternalMouseDown(objArg);
		baseItem = iOwner.GetFocusItem();
		if (baseItem != null)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(baseItem);
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
				OnItemSelected(iOwner.GetFocusItem());
			}
		}
		if (itemContainerControl != null && baseItem != null && !IsDockableWindow && bool_0 && CanDragItem(baseItem))
		{
			itemContainerControl.set_Capture(true);
			if (IsDockableWindow)
			{
				Class51.RECT r = new Class51.RECT(0, 0, 0, 0);
				Class51.GetWindowRect(itemContainerControl.get_Handle(), ref r);
				Rectangle clip = Rectangle.FromLTRB(r.Left, r.Top, r.Right, r.Bottom);
				Cursor.set_Clip(clip);
			}
			StartItemDrag(baseItem);
			((ControlDesigner)this).get_Control().set_Capture(true);
		}
		else if (baseItem == null)
		{
			((ParentControlDesigner)this).OnMouseDragBegin(x, y);
		}
		else
		{
			((ControlDesigner)this).get_Control().set_Capture(true);
		}
	}

	protected virtual bool CanDragItem(BaseItem item)
	{
		if (item is ControlContainerItem && ((ControlContainerItem)item).Control != null)
		{
			return false;
		}
		return true;
	}

	protected override void OnMouseDragMove(int x, int y)
	{
		if (bool_2)
		{
			Point point = ((ControlDesigner)this).get_Control().PointToClient(new Point(x, y));
			method_9(point.X, point.Y);
		}
	}

	protected override void OnMouseDragEnd(bool cancel)
	{
		if (!IsDockableWindow && !bool_10)
		{
			((ControlDesigner)this).get_Control().set_Capture(false);
			Cursor.set_Clip(Rectangle.Empty);
			if (bool_2)
			{
				if (cancel)
				{
					method_10(-1, -1);
				}
				else
				{
					Point point = ((ControlDesigner)this).get_Control().PointToClient(Control.get_MousePosition());
					method_10(point.X, point.Y);
				}
				cancel = true;
			}
			else
			{
				GetItemContainerControl();
				IOwner iOwner = GetIOwner();
				if (iOwner != null && iOwner.GetFocusItem() != null)
				{
					cancel = true;
				}
			}
		}
		((ParentControlDesigner)this).OnMouseDragEnd(cancel);
	}

	protected virtual bool OnMouseLeave(ref Message m)
	{
		return false;
	}

	protected virtual bool OnMouseDoubleClick(Message m)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		bool result = false;
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection == ((ControlDesigner)this).get_Control())
		{
			Point point = ((ControlDesigner)this).get_Control().PointToClient(Control.get_MousePosition());
			IOwner iOwner = GetIOwner();
			BaseItem itemContainer = GetItemContainer();
			itemContainer.InternalMouseDown(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
			BaseItem focusItem = iOwner.GetFocusItem();
			if (focusItem != null)
			{
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(focusItem);
				selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.Click);
			}
		}
		if (selectionService != null && selectionService.PrimarySelection is ButtonItem && ((ButtonItem)selectionService.PrimarySelection).ContainerControl == GetItemContainerControl())
		{
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost != null)
			{
				IDesigner designer = designerHost.GetDesigner(selectionService.PrimarySelection as IComponent);
				if (designer != null)
				{
					designer.DoDefaultAction();
					result = true;
				}
			}
		}
		return result;
	}

	protected virtual void OnItemSelected(BaseItem item)
	{
	}

	protected virtual void RecalcLayout()
	{
		Control itemContainerControl = GetItemContainerControl();
		if (itemContainerControl is BarBaseControl)
		{
			((BarBaseControl)(object)itemContainerControl).RecalcLayout();
		}
		else if (itemContainerControl is ItemControl)
		{
			((ItemControl)(object)itemContainerControl).RecalcLayout();
		}
		else if (itemContainerControl is ButtonX)
		{
			((ButtonX)(object)itemContainerControl).RecalcLayout();
		}
	}

	protected virtual void SetComponentSelected(bool selected)
	{
		if (GetItemContainerControl() is ItemControl)
		{
			((ItemControl)(object)GetItemContainerControl()).Boolean_1 = selected;
		}
		else if (GetItemContainerControl() is Bar)
		{
			((Bar)(object)GetItemContainerControl()).Boolean_18 = selected;
		}
		else if (GetItemContainerControl() is ExplorerBar)
		{
			((ExplorerBar)(object)GetItemContainerControl()).Boolean_0 = selected;
		}
	}

	protected virtual ArrayList GetAllAssociatedComponents()
	{
		ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
		BaseItem itemContainer = GetItemContainer();
		if (itemContainer != null)
		{
			AddSubItems(itemContainer, arrayList);
		}
		return arrayList;
	}

	protected override bool GetHitTest(Point pt)
	{
		if (((ControlDesigner)this).GetHitTest(pt))
		{
			return true;
		}
		Control control = ((ControlDesigner)this).get_Control();
		ScrollableControl val = (ScrollableControl)(object)((control is ScrollableControl) ? control : null);
		if (val != null && ((Control)val).get_IsHandleCreated() && val.get_AutoScroll())
		{
			int num = Class92.SendMessage(((Control)val).get_Handle(), 132, 0, Class92.smethod_9(pt.X, pt.Y));
			if (num == 7 || num == 6)
			{
				return true;
			}
		}
		return false;
	}

	protected virtual void AddSubItems(BaseItem parent, ArrayList list)
	{
		foreach (BaseItem subItem in parent.SubItems)
		{
			if (subItem.DesignMode)
			{
				list.Add(subItem);
			}
			AddSubItems(subItem, list);
		}
	}

	protected virtual void CreateButton(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateButton(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateButton(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(ButtonItem)) is ButtonItem buttonItem)
			{
				TypeDescriptor.GetProperties(buttonItem)["Text"]!.SetValue(buttonItem, buttonItem.Name);
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(buttonItem);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(buttonItem);
			}
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
			m_CreatingItem = false;
		}
	}

	protected virtual void CreateRatingItem(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateRatingItem(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateRatingItem(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(RatingItem)) is RatingItem item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
			m_CreatingItem = false;
		}
	}

	protected virtual void CreateCheckBox(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateCheckBox(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateCheckBox(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(CheckBoxItem)) is CheckBoxItem checkBoxItem)
			{
				TypeDescriptor.GetProperties(checkBoxItem)["Text"]!.SetValue(checkBoxItem, checkBoxItem.Name);
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(checkBoxItem);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(checkBoxItem);
			}
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
			m_CreatingItem = false;
		}
	}

	protected virtual void CreateTextBox(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateTextBox(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateTextBox(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(TextBoxItem)) is TextBoxItem item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
			m_CreatingItem = false;
		}
	}

	protected virtual void CreateComboBox(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateComboBox(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateComboBox(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(ComboBoxItem)) is ComboBoxItem item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateLabel(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateLabel(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateLabel(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(LabelItem)) is LabelItem labelItem)
			{
				TypeDescriptor.GetProperties(labelItem)["Text"]!.SetValue(labelItem, labelItem.Name);
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(labelItem);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(labelItem);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateColorPicker(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateColorPicker(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateColorPicker(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(ColorPickerDropDown)) is ColorPickerDropDown colorPickerDropDown)
			{
				TypeDescriptor.GetProperties(colorPickerDropDown)["Text"]!.SetValue(colorPickerDropDown, colorPickerDropDown.Name);
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(colorPickerDropDown);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(colorPickerDropDown);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateContainer(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateContainer(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateContainer(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(ItemContainer)) is ItemContainer item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateProgressBar(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateProgressBar(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateProgressBar(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(ProgressBarItem)) is ProgressBarItem item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateDocument(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			DockContainerItem dockContainerItem = designerHost.CreateComponent(typeof(DockContainerItem)) as DockContainerItem;
			dockContainerItem.Text = dockContainerItem.Name;
			OnSubItemsChanging();
			GetItemContainer().SubItems.Add(dockContainerItem);
			PanelDockContainer panelDockContainer = designerHost.CreateComponent(typeof(PanelDockContainer)) as PanelDockContainer;
			((ControlDesigner)this).get_Control().get_Controls().Add((Control)(object)panelDockContainer);
			panelDockContainer.ColorSchemeStyle = InternalStyle;
			panelDockContainer.ApplyLabelStyle();
			dockContainerItem.Control = (Control)(object)panelDockContainer;
			OnSubItemsChanged();
			RecalcLayout();
			if (((ControlDesigner)this).get_Control() is Bar)
			{
				Bar bar = ((ControlDesigner)this).get_Control() as Bar;
				bar.SelectedDockTab = bar.Items.IndexOf(dockContainerItem);
			}
			((Control)panelDockContainer).BringToFront();
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateControlContainer(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateControlContainer(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateControlContainer(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(ControlContainerItem)) is ControlContainerItem controlContainerItem)
			{
				controlContainerItem.AllowItemResize = false;
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(controlContainerItem);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(controlContainerItem);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateGalleryContainer(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateGalleryContainer(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateGalleryContainer(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(GalleryContainer)) is GalleryContainer item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateCustomizeItem(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateCustomizeItem(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateCustomizeItem(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(CustomizeItem)) is CustomizeItem item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateMdiWindowList(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateMdiWindowList(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateMdiWindowList(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(MdiWindowListItem)) is MdiWindowListItem item)
			{
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(item);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(item);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void CreateSliderItem(object sender, EventArgs e)
	{
		OnSubItemsChanging();
		CreateSliderItem(GetItemContainer());
		OnSubItemsChanged();
	}

	protected virtual void CreateSliderItem(BaseItem parent)
	{
		if (parent == null)
		{
			return;
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Adding new item");
		try
		{
			m_CreatingItem = true;
			if (designerHost.CreateComponent(typeof(SliderItem)) is SliderItem sliderItem)
			{
				TypeDescriptor.GetProperties(sliderItem)["Text"]!.SetValue(sliderItem, sliderItem.Name);
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"]);
				}
				parent.SubItems.Add(sliderItem);
				RecalcLayout();
				if (parent != GetItemContainer())
				{
					componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
				}
				OnitemCreated(sliderItem);
			}
		}
		catch
		{
			designerTransaction.Cancel();
			throw;
		}
		finally
		{
			m_CreatingItem = false;
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected virtual void OnitemCreated(BaseItem item)
	{
	}

	protected virtual void OnSubItemsChanging()
	{
	}

	protected virtual void OnSubItemsChanged()
	{
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		Point pt = ((ControlDesigner)this).get_Control().PointToClient(Control.get_MousePosition());
		if (((ControlDesigner)this).get_Control().get_Bounds().Contains(pt))
		{
			bool_7 = false;
		}
		else
		{
			bool_7 = true;
		}
		if ((int)Control.get_MouseButtons() == 1048576)
		{
			return;
		}
		timer_1.set_Enabled(false);
		timer_1.Stop();
		timer_1.remove_Tick((EventHandler)timer_1_Tick);
		((Component)(object)timer_1).Dispose();
		timer_1 = null;
		if (bool_8)
		{
			bool_8 = false;
			if (((ComponentDesigner)this).GetService(typeof(ISelectionService)) is ISelectionService selectionService && selectionService.PrimarySelection is Control)
			{
				method_3((Control)selectionService.PrimarySelection);
			}
		}
		else if (bool_2 && bool_7)
		{
			ControlContainerItem controlContainerItem = baseItem_0 as ControlContainerItem;
			method_10(-1, -1);
			if (controlContainerItem != null)
			{
				controlContainerItem.Control = null;
				DestroyComponent(controlContainerItem);
			}
		}
	}

	protected override void OnDragLeave(EventArgs e)
	{
		if (bool_2 && bool_1 && !IsDockableWindow)
		{
			method_10(-1, -1);
		}
		((ParentControlDesigner)this).OnDragLeave(e);
	}

	protected override void OnDragOver(DragEventArgs de)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		if (bool_2)
		{
			Point point = ((ControlDesigner)this).get_Control().PointToClient(new Point(de.get_X(), de.get_Y()));
			method_9(point.X, point.Y);
			de.set_Effect((DragDropEffects)2);
			return;
		}
		if (bool_0 && bool_1 && !IsDockableWindow)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null && selectionService.PrimarySelection != ((ComponentDesigner)this).get_Component())
			{
				if (selectionService.PrimarySelection is Control && ((ControlDesigner)this).get_Control().get_Controls().Contains((Control)selectionService.PrimarySelection))
				{
					object primarySelection = selectionService.PrimarySelection;
					BaseItem controlItem = GetControlItem((Control)((primarySelection is Control) ? primarySelection : null));
					if (controlItem != null)
					{
						point_0 = ((ControlDesigner)this).get_Control().PointToClient(new Point(de.get_X(), de.get_Y()));
						bool_6 = true;
						StartItemDrag(controlItem);
						if (timer_1 == null)
						{
							timer_1 = new Timer();
							timer_1.add_Tick((EventHandler)timer_1_Tick);
							timer_1.set_Interval(100);
							timer_1.set_Enabled(true);
							timer_1.Start();
						}
					}
					return;
				}
				if (selectionService.SelectionCount > 1)
				{
					de.set_Effect((DragDropEffects)0);
					return;
				}
				if (selectionService.PrimarySelection is Control && ((Control)selectionService.PrimarySelection).get_Parent() != null)
				{
					BaseItem baseItem = null;
					if (IsDockableWindow)
					{
						DockContainerItem dockContainerItem = new DockContainerItem();
						dockContainerItem.Name = "tempDragDropItem";
						baseItem = dockContainerItem;
					}
					else
					{
						ControlContainerItem controlContainerItem = new ControlContainerItem();
						controlContainerItem.AllowItemResize = false;
						controlContainerItem.Name = "tempDragDropItem";
						baseItem = controlContainerItem;
					}
					point_0 = ((ControlDesigner)this).get_Control().PointToClient(new Point(de.get_X(), de.get_Y()));
					bool_6 = true;
					StartItemDrag(baseItem);
					if (timer_1 == null)
					{
						timer_1 = new Timer();
						timer_1.add_Tick((EventHandler)timer_1_Tick);
						timer_1.set_Interval(100);
						timer_1.set_Enabled(true);
						timer_1.Start();
					}
				}
			}
		}
		((ParentControlDesigner)this).OnDragOver(de);
	}

	protected override void OnDragDrop(DragEventArgs de)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		if (bool_0 && bool_1 && !IsDockableWindow)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null && selectionService.PrimarySelection is Control && ((ControlDesigner)this).get_Control().get_Controls().Contains((Control)selectionService.PrimarySelection))
			{
				de.set_Effect((DragDropEffects)2);
				Point point = ((ControlDesigner)this).get_Control().PointToClient(new Point(de.get_X(), de.get_Y()));
				method_10(point.X, point.Y);
			}
			else
			{
				if (selectionService.SelectionCount > 1)
				{
					de.set_Effect((DragDropEffects)0);
					return;
				}
				if (baseItem_0 != null && baseItem_0.Name == "tempDragDropItem" && (baseItem_0 is ControlContainerItem || baseItem_0 is DockContainerItem))
				{
					dateTime_0 = DateTime.Now;
					BaseItem baseItem = null;
					if (baseItem_0 is ControlContainerItem)
					{
						ControlContainerItem controlContainerItem = baseItem_0 as ControlContainerItem;
						controlContainerItem.Control = null;
						controlContainerItem = CreateComponent(typeof(ControlContainerItem)) as ControlContainerItem;
						PropertyDescriptor? propertyDescriptor = TypeDescriptor.GetProperties(controlContainerItem)["Control"];
						ControlContainerItem component = controlContainerItem;
						object primarySelection = selectionService.PrimarySelection;
						propertyDescriptor!.SetValue(component, (primarySelection is Control) ? primarySelection : null);
						TypeDescriptor.GetProperties(controlContainerItem)["AllowItemResize"]!.SetValue(controlContainerItem, false);
						baseItem = controlContainerItem;
					}
					else if (baseItem_0 is DockContainerItem)
					{
						DockContainerItem dockContainerItem = baseItem_0 as DockContainerItem;
						dockContainerItem.Control = null;
						dockContainerItem = CreateComponent(typeof(DockContainerItem)) as DockContainerItem;
						PropertyDescriptor? propertyDescriptor2 = TypeDescriptor.GetProperties(dockContainerItem)["Control"];
						DockContainerItem component2 = dockContainerItem;
						object primarySelection2 = selectionService.PrimarySelection;
						propertyDescriptor2!.SetValue(component2, (primarySelection2 is Control) ? primarySelection2 : null);
						baseItem = dockContainerItem;
					}
					baseItem_0 = baseItem;
					Point point2 = ((ControlDesigner)this).get_Control().PointToClient(new Point(de.get_X(), de.get_Y()));
					method_10(point2.X, point2.Y);
				}
				bool_5 = true;
			}
		}
		((ParentControlDesigner)this).OnDragDrop(de);
	}

	protected virtual BaseItem GetControlItem(Control control)
	{
		BaseItem itemContainer = GetItemContainer();
		if (itemContainer == null)
		{
			return null;
		}
		return method_8(control, itemContainer);
	}

	private BaseItem method_8(Control control_1, BaseItem baseItem_1)
	{
		if (baseItem_1 is ControlContainerItem && ((ControlContainerItem)baseItem_1).Control == control_1)
		{
			return baseItem_1;
		}
		if (baseItem_1 is DockContainerItem && ((DockContainerItem)baseItem_1).Control == control_1)
		{
			return baseItem_1;
		}
		foreach (BaseItem subItem in baseItem_1.SubItems)
		{
			BaseItem baseItem = method_8(control_1, subItem);
			if (baseItem != null)
			{
				return baseItem;
			}
		}
		return null;
	}

	protected void StartItemDrag(BaseItem item)
	{
		if (item != null && baseItem_0 == null)
		{
			baseItem_0 = item;
			if (!bool_6)
			{
				Cursor.set_Current(Cursors.get_Hand());
			}
			bool_2 = true;
		}
	}

	private void method_9(int int_1, int int_2)
	{
		if (!bool_2)
		{
			return;
		}
		BaseItem dragItem = baseItem_0;
		BaseItem itemContainer = GetItemContainer();
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_3);
			idesignTimeProvider_0 = null;
		}
		Control itemContainerControl = GetItemContainerControl();
		Point pScreen = itemContainerControl.PointToScreen(new Point(int_1, int_2));
		InsertPosition insertPosition = ((IDesignTimeProvider)itemContainer).GetInsertPosition(pScreen, dragItem);
		if (insertPosition != null)
		{
			if (insertPosition.TargetProvider == null)
			{
				if (!bool_6)
				{
					Cursor.set_Current(Cursors.get_No());
				}
				return;
			}
			insertPosition.TargetProvider.DrawReversibleMarker(insertPosition.Position, insertPosition.Before);
			int_0 = insertPosition.Position;
			bool_3 = insertPosition.Before;
			idesignTimeProvider_0 = insertPosition.TargetProvider;
			if (!bool_6)
			{
				Cursor.set_Current(Cursors.get_Hand());
			}
		}
		else if (!bool_6)
		{
			Cursor.set_Current(Cursors.get_No());
		}
	}

	internal void method_10(int int_1, int int_2)
	{
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		if (!bool_2)
		{
			return;
		}
		if (control_0 != null && control_0.get_Capture())
		{
			control_0.set_Capture(false);
		}
		BaseItem baseItem = baseItem_0;
		BaseItem itemContainer = GetItemContainer();
		bool flag = false;
		if (idesignTimeProvider_0 != null)
		{
			if (int_1 == -1 && int_2 == -1)
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_3);
			}
			else
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_3);
				if (baseItem != null)
				{
					bool_11 = true;
					try
					{
						BaseItem parent = baseItem.Parent;
						if (parent != null)
						{
							if (parent == (BaseItem)idesignTimeProvider_0 && int_0 > 0 && parent.SubItems.IndexOf(baseItem) < int_0)
							{
								int_0--;
							}
							parent.SubItems.Remove(baseItem);
						}
						idesignTimeProvider_0.InsertItemAt(baseItem, int_0, bool_3);
						idesignTimeProvider_0 = null;
						flag = true;
						if (baseItem.Parent != null && baseItem.Parent != GetItemContainer())
						{
							((IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService)))?.OnComponentChanged(baseItem.Parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
						}
					}
					finally
					{
						bool_11 = false;
					}
				}
			}
		}
		else if (int_1 != -1 && int_2 != -1 && baseItem is ControlContainerItem && ((ControlContainerItem)baseItem).Control != null)
		{
			BaseItem baseItem2 = itemContainer;
			if (baseItem.Parent != null)
			{
				baseItem.Parent.SubItems.Remove(baseItem);
			}
			baseItem2.SubItems.Add(baseItem);
			((IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService)))?.OnComponentChanged(baseItem.Parent, TypeDescriptor.GetProperties(typeof(BaseItem))["SubItems"], null, null);
			flag = true;
		}
		idesignTimeProvider_0 = null;
		bool_2 = false;
		if (!bool_6)
		{
			Cursor.set_Current(Cursors.get_Default());
		}
		if (baseItem != null)
		{
			baseItem.bool_12 = true;
		}
		itemContainer.InternalMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, int_1, int_2, 0));
		if (baseItem != null)
		{
			baseItem.bool_12 = false;
		}
		baseItem_0 = null;
		RecalcLayout();
		if (flag)
		{
			((IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService)))?.OnComponentChanged(((ControlDesigner)this).get_Control(), null, null, null);
		}
	}

	public void StartExternalDrag(BaseItem item)
	{
		if (!bool_2 && control_0 != null)
		{
			bool_6 = false;
			point_0 = ((ControlDesigner)this).get_Control().PointToClient(Control.get_MousePosition());
			StartItemDrag(item);
			control_0.set_Capture(true);
		}
	}

	protected virtual void SelectComponent(IComponent comp, SelectionTypes selectionType)
	{
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && comp != null)
		{
			ArrayList arrayList = new ArrayList(1);
			arrayList.Add(comp);
			selectionService.SetSelectedComponents(arrayList, selectionType);
		}
	}

	public object CreateComponent(Type componentClass)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		object obj = null;
		try
		{
			m_CreatingItem = true;
			return designerHost.CreateComponent(componentClass);
		}
		finally
		{
			m_CreatingItem = false;
		}
	}

	public object CreateComponent(Type componentClass, string name)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		object obj = null;
		try
		{
			m_CreatingItem = true;
			return designerHost.CreateComponent(componentClass, name);
		}
		finally
		{
			m_CreatingItem = false;
		}
	}

	public void DestroyComponent(IComponent c)
	{
		((IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost)))?.DestroyComponent(c);
	}

	object IDesignerServices.GetService(Type serviceType)
	{
		return ((ComponentDesigner)this).GetService(serviceType);
	}

	private void method_11(object sender, EventArgs e)
	{
		if (!(((ComponentDesigner)this).GetService(typeof(ISelectionService)) is ISelectionService selectionService))
		{
			SetComponentSelected(selected: false);
			return;
		}
		bool componentSelected = false;
		if (selectionService.PrimarySelection != ((ControlDesigner)this).get_Control() && selectionService.PrimarySelection != GetItemContainerControl())
		{
			if (selectionService.PrimarySelection is BaseItem && ((BaseItem)selectionService.PrimarySelection).ContainerControl == GetItemContainerControl())
			{
				componentSelected = true;
			}
		}
		else
		{
			componentSelected = true;
		}
		SetComponentSelected(componentSelected);
	}
}
