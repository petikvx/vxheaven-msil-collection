using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.AdvTree.Display;
using DevComponents.DotNetBar;

namespace DevComponents.AdvTree.Design;

public class AdvTreeDesigner : ParentControlDesigner
{
	private const string string_0 = "tempDragDropItem";

	private const int int_0 = 516;

	private const int int_1 = 513;

	private const int int_2 = 515;

	private bool bool_0;

	private Timer timer_0;

	private Timer timer_1;

	private bool bool_1;

	private bool bool_2;

	private DateTime dateTime_0 = DateTime.MinValue;

	private bool bool_3;

	private Point point_0 = Point.Empty;

	private DesignerActionListCollection designerActionListCollection_0;

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			if (((ControlDesigner)this).get_Control() is AdvTree advTree)
			{
				foreach (Node node in advTree.Nodes)
				{
					method_5(node, arrayList);
				}
				foreach (ElementStyle style in advTree.Styles)
				{
					arrayList.Add(style);
				}
				if (advTree.NodesConnector != null)
				{
					arrayList.Add(advTree.NodesConnector);
				}
				if (advTree.NodeConnector_0 != null)
				{
					arrayList.Add(advTree.NodeConnector_0);
				}
				{
					foreach (ColumnHeader column in advTree.Columns)
					{
						arrayList.Add(column);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	public override SelectionRules SelectionRules => (SelectionRules)1342177295;

	public override DesignerActionListCollection ActionLists
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (designerActionListCollection_0 == null)
			{
				designerActionListCollection_0 = new DesignerActionListCollection();
				designerActionListCollection_0.Add((DesignerActionList)(object)new Class4(this));
			}
			return designerActionListCollection_0;
		}
	}

	public override void Initialize(IComponent component)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		((ParentControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged += method_3;
			}
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += OnComponentRemoving;
			}
			if (component is Control)
			{
				((Control)component).add_ControlAdded(new ControlEventHandler(method_9));
				((Control)component).add_ControlRemoved(new ControlEventHandler(method_10));
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null)
		{
			selectionService.SelectionChanged -= method_3;
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= OnComponentRemoving;
		}
		if (((ControlDesigner)this).get_Control() != null)
		{
			((ControlDesigner)this).get_Control().remove_ControlAdded(new ControlEventHandler(method_9));
			((ControlDesigner)this).get_Control().remove_ControlRemoved(new ControlEventHandler(method_10));
		}
		((ParentControlDesigner)this).Dispose(disposing);
	}

	internal void method_0(Control control_0)
	{
		((ControlDesigner)this).HookChildControls(control_0);
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		method_1();
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
	}

	private void method_1()
	{
		method_2(null, bool_4: true);
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost != null)
		{
			Utilities.smethod_0(((ControlDesigner)this).get_Control() as AdvTree, new Class25(designerHost));
			((ControlDesigner)this).get_Control().set_Size(new Size(100, 100));
		}
	}

	private Node method_2(Node node_0, bool bool_4)
	{
		AdvTree advTree = ((ControlDesigner)this).get_Control() as AdvTree;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		Node node = null;
		advTree.BeginUpdate();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			if (bool_4 && componentChangeService != null)
			{
				if (node_0 != null)
				{
					componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(node_0).Find("Nodes", ignoreCase: true));
				}
				else
				{
					componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree).Find("Nodes", ignoreCase: true));
				}
			}
			node = designerHost.CreateComponent(typeof(Node)) as Node;
			if (node != null)
			{
				node.Text = node.Name;
				node.Expanded = true;
				if (bool_4)
				{
					if (node_0 == null)
					{
						advTree.Nodes.Add(node);
					}
					else
					{
						node_0.Nodes.Add(node);
					}
					if (componentChangeService != null)
					{
						if (node_0 != null)
						{
							componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(node_0).Find("Nodes", ignoreCase: true), null, null);
							return node;
						}
						componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree).Find("Nodes", ignoreCase: true), null, null);
						return node;
					}
					return node;
				}
				return node;
			}
			return node;
		}
		finally
		{
			advTree.EndUpdate();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		ISelectionService selectionService = (ISelectionService)sender;
		if (selectionService.PrimarySelection == ((ComponentDesigner)this).get_Component())
		{
			AdvTree advTree = ((ControlDesigner)this).get_Control() as AdvTree;
			advTree.SelectedNode = null;
		}
	}

	public void OnComponentRemoving(object sender, ComponentEventArgs e)
	{
		if (e.Component == ((ComponentDesigner)this).get_Component())
		{
			IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
			if (designerHost == null)
			{
				return;
			}
			ArrayList arrayList = new ArrayList(((ComponentDesigner)this).get_AssociatedComponents());
			{
				foreach (IComponent item in arrayList)
				{
					designerHost.DestroyComponent(item);
				}
				return;
			}
		}
		if (e.Component is Node && ((Node)e.Component).TreeControl == ((ControlDesigner)this).get_Control())
		{
			method_4(e.Component as Node);
		}
	}

	private void method_4(Node node_0)
	{
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (node_0.Parent != null)
		{
			Node parent = node_0.Parent;
			componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(parent)["Nodes"]);
			node_0.Remove();
			componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(parent)["Nodes"], null, null);
		}
		else
		{
			AdvTree component = ((ControlDesigner)this).get_Control() as AdvTree;
			componentChangeService?.OnComponentChanging(component, TypeDescriptor.GetProperties(component)["Nodes"]);
			node_0.Remove();
			componentChangeService?.OnComponentChanged(component, TypeDescriptor.GetProperties(component)["Nodes"], null, null);
		}
		if (node_0.Nodes.Count > 0)
		{
			Node[] array = new Node[node_0.Nodes.Count];
			node_0.Nodes.method_1(array);
			Node[] array2 = array;
			foreach (Node node in array2)
			{
				node.Remove();
				if (node.ParentConnector != null)
				{
					designerHost?.DestroyComponent(node.ParentConnector);
				}
				designerHost?.DestroyComponent(node);
			}
		}
		method_8();
	}

	private void method_5(Node node_0, ArrayList arrayList_0)
	{
		arrayList_0.Add(node_0);
		if (node_0.ParentConnector != null)
		{
			arrayList_0.Add(node_0.ParentConnector);
		}
		foreach (Node node in node_0.Nodes)
		{
			arrayList_0.Add(node);
			if (node.Cells.Count > 1)
			{
				for (int i = 1; i < node.Cells.Count; i++)
				{
					arrayList_0.Add(node.Cells[i]);
				}
			}
			if (node.NodesColumns.Count > 0)
			{
				foreach (ColumnHeader nodesColumn in node.NodesColumns)
				{
					arrayList_0.Add(nodesColumn);
				}
			}
			method_5(node, arrayList_0);
		}
	}

	protected override void WndProc(ref Message m)
	{
		switch (((Message)(ref m)).get_Msg())
		{
		case 513:
			if (OnMouseDown(ref m, (MouseButtons)1048576))
			{
				return;
			}
			break;
		case 515:
			if (method_6())
			{
				return;
			}
			break;
		case 516:
			if (OnMouseDown(ref m, (MouseButtons)2097152))
			{
				return;
			}
			break;
		}
		((ControlDesigner)this).WndProc(ref m);
	}

	private bool method_6()
	{
		bool result = false;
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService.PrimarySelection is Node && ((Node)selectionService.PrimarySelection).TreeControl == ((ControlDesigner)this).get_Control())
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

	protected virtual bool OnMouseDown(ref Message m, MouseButtons button)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		if (!(((ControlDesigner)this).get_Control() is AdvTree advTree))
		{
			return false;
		}
		Point p = ((Control)advTree).PointToClient(Control.get_MousePosition());
		Node nodeAt = advTree.GetNodeAt(p);
		if (nodeAt != null && (int)button == 2097152)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			ArrayList arrayList = new ArrayList(1);
			arrayList.Add(nodeAt);
			selectionService.SetSelectedComponents(arrayList, SelectionTypes.MouseDown);
			advTree.SelectedNode = nodeAt;
			((ControlDesigner)this).OnContextMenu(Control.get_MousePosition().X, Control.get_MousePosition().Y);
			return true;
		}
		return false;
	}

	private void method_7(IComponent icomponent_0)
	{
		((IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost)))?.DestroyComponent(icomponent_0);
	}

	private void method_8()
	{
		if (((ControlDesigner)this).get_Control() is AdvTree advTree)
		{
			advTree.RecalcLayout();
			((Control)advTree).Refresh();
		}
	}

	private void method_9(object sender, ControlEventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		if (bool_3 || (!bool_3 && OnControlAdded(e)))
		{
			timer_0 = new Timer();
			timer_0.add_Tick((EventHandler)timer_0_Tick);
			timer_0.set_Interval(50);
			timer_0.set_Enabled(true);
			timer_0.Start();
			bool_3 = false;
		}
	}

	protected virtual bool OnControlAdded(ControlEventArgs e)
	{
		return false;
	}

	private void method_10(object sender, ControlEventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null || designerHost.Loading)
		{
			return;
		}
		if (dateTime_0 != DateTime.MinValue && DateTime.Now.Subtract(dateTime_0).Seconds < 2)
		{
			dateTime_0 = DateTime.MinValue;
			return;
		}
		dateTime_0 = DateTime.MinValue;
		if (bool_1)
		{
			method_11(e.get_Control());
			return;
		}
		if (timer_1 != null)
		{
			bool_2 = true;
			return;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection == e.get_Control() && Utilities.FindNodeForControl(((ControlDesigner)this).get_Control() as AdvTree, e.get_Control()) != null)
		{
			method_11(e.get_Control());
		}
	}

	private void method_11(Control control_0)
	{
		AdvTree advTree = ((ControlDesigner)this).get_Control() as AdvTree;
		if (control_0 == null)
		{
			return;
		}
		Node node = Utilities.FindNodeForControl(advTree, control_0);
		if (node != null)
		{
			if (bool_0)
			{
				advTree.method_66();
				bool_0 = false;
			}
			if (node.Parent != null)
			{
				Node parent = node.Parent;
				IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
				componentChangeService?.OnComponentChanging(parent, TypeDescriptor.GetProperties(parent)["Nodes"]);
				node.Remove();
				componentChangeService?.OnComponentChanged(parent, TypeDescriptor.GetProperties(parent)["Nodes"], null, null);
			}
			method_7(node);
			method_8();
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		timer_0.Stop();
		timer_0.set_Enabled(false);
		timer_0 = null;
		method_8();
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection is Control && ((ControlDesigner)this).get_Control().get_Controls().Contains((Control)selectionService.PrimarySelection))
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService.OnComponentChanged(selectionService.PrimarySelection, null, null, null);
		}
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
			bool_1 = false;
		}
		else
		{
			bool_1 = true;
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
		if (bool_2)
		{
			bool_2 = false;
			if (((ComponentDesigner)this).GetService(typeof(ISelectionService)) is ISelectionService selectionService && selectionService.PrimarySelection is Control)
			{
				method_11((Control)selectionService.PrimarySelection);
			}
		}
	}

	protected override void OnDragLeave(EventArgs e)
	{
		if (bool_0)
		{
			AdvTree advTree = ((ControlDesigner)this).get_Control() as AdvTree;
			advTree.method_66();
			bool_0 = false;
		}
		((ParentControlDesigner)this).OnDragLeave(e);
	}

	protected override void OnDragOver(DragEventArgs de)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		if (!(((ControlDesigner)this).get_Control() is AdvTree advTree))
		{
			((ParentControlDesigner)this).OnDragOver(de);
			return;
		}
		if (bool_0)
		{
			DragEventArgs dragEventArgs_ = new DragEventArgs((IDataObject)null, de.get_KeyState(), de.get_X(), de.get_Y(), (DragDropEffects)(-2147483645), (DragDropEffects)2);
			advTree.method_68(dragEventArgs_);
			de.set_Effect((DragDropEffects)2);
			return;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection != ((ComponentDesigner)this).get_Component())
		{
			if (selectionService.PrimarySelection is Control && ((ControlDesigner)this).get_Control().get_Controls().Contains((Control)selectionService.PrimarySelection))
			{
				object primarySelection = selectionService.PrimarySelection;
				Node node = Utilities.FindNodeForControl(advTree, (Control)((primarySelection is Control) ? primarySelection : null));
				if (node != null && advTree.method_77(node))
				{
					if (timer_1 == null)
					{
						timer_1 = new Timer();
						timer_1.add_Tick((EventHandler)timer_1_Tick);
						timer_1.set_Interval(100);
						timer_1.set_Enabled(true);
						timer_1.Start();
					}
					bool_0 = true;
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
				Node node2 = new Node();
				node2.Name = "tempDragDropItem";
				node2.Text = ((Control)selectionService.PrimarySelection).get_Name();
				if (advTree.method_77(node2))
				{
					bool_0 = true;
				}
			}
		}
		((ParentControlDesigner)this).OnDragOver(de);
	}

	protected override void OnDragDrop(DragEventArgs de)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		if (!(((ControlDesigner)this).get_Control() is AdvTree advTree))
		{
			((ParentControlDesigner)this).OnDragDrop(de);
			return;
		}
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		if (selectionService != null && selectionService.PrimarySelection is Control && ((ControlDesigner)this).get_Control().get_Controls().Contains((Control)selectionService.PrimarySelection))
		{
			de.set_Effect((DragDropEffects)2);
			advTree.method_65(new DragEventArgs((IDataObject)null, 0, 0, 0, (DragDropEffects)2, (DragDropEffects)(-2147483645)));
		}
		else
		{
			if (selectionService.SelectionCount > 1)
			{
				de.set_Effect((DragDropEffects)0);
				return;
			}
			Node node = advTree.method_79();
			if (node != null && node.Tag is Node && ((Node)node.Tag).Name == "tempDragDropItem")
			{
				dateTime_0 = DateTime.Now;
				Node node2 = method_2(null, bool_4: false);
				PropertyDescriptor? propertyDescriptor = TypeDescriptor.GetProperties(node2)["HostedControl"];
				object primarySelection = selectionService.PrimarySelection;
				propertyDescriptor!.SetValue(node2, (primarySelection is Control) ? primarySelection : null);
				TypeDescriptor.GetProperties(node2)["Text"]!.SetValue(node2, node2.HostedControl.get_Name());
				node.Tag = node2;
				advTree.method_65(new DragEventArgs((IDataObject)null, 0, 0, 0, (DragDropEffects)2, (DragDropEffects)(-2147483645)));
				bool_3 = true;
				bool_0 = false;
			}
		}
		((ParentControlDesigner)this).OnDragDrop(de);
	}

	protected virtual void OnNodeSelected(Node node)
	{
	}

	protected virtual bool CanDragNode(Node node)
	{
		return true;
	}

	protected override void OnMouseDragBegin(int x, int y)
	{
		if (!(((ControlDesigner)this).get_Control() is AdvTree advTree))
		{
			((ParentControlDesigner)this).OnMouseDragBegin(x, y);
			return;
		}
		Point point = ((Control)advTree).PointToClient(new Point(x, y));
		Node nodeAt = advTree.GetNodeAt(point);
		if (nodeAt != null)
		{
			Rectangle rectangle = NodeDisplay.smethod_0(Enum4.const_2, nodeAt, advTree.NodeDisplay_0.Offset);
			if (!rectangle.IsEmpty && rectangle.Contains(point))
			{
				nodeAt.Expanded = !nodeAt.Expanded;
				return;
			}
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				ArrayList arrayList = new ArrayList(1);
				arrayList.Add(nodeAt);
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.MouseDown);
				OnNodeSelected(nodeAt);
			}
			advTree.SelectedNode = nodeAt;
		}
		else
		{
			advTree.SelectedNode = null;
		}
		if (nodeAt != null && CanDragNode(nodeAt))
		{
			point_0 = new Point(x, y);
			((ControlDesigner)this).get_Control().set_Capture(true);
		}
		else if (nodeAt == null)
		{
			((ParentControlDesigner)this).OnMouseDragBegin(x, y);
		}
		else
		{
			((ControlDesigner)this).get_Control().set_Capture(true);
		}
	}

	protected override void OnMouseDragMove(int x, int y)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected I4, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		AdvTree advTree = ((ControlDesigner)this).get_Control() as AdvTree;
		if (!point_0.IsEmpty && advTree.SelectedNode != null && (Math.Abs(point_0.X - x) >= SystemInformation.get_DragSize().Width || Math.Abs(point_0.Y - y) >= SystemInformation.get_DragSize().Height))
		{
			advTree.method_77(advTree.SelectedNode);
			point_0 = Point.Empty;
			bool_0 = true;
		}
		else if (bool_0)
		{
			DragEventArgs dragEventArgs_ = new DragEventArgs((IDataObject)null, (int)Control.get_ModifierKeys(), x, y, (DragDropEffects)(-2147483645), (DragDropEffects)2);
			advTree.method_68(dragEventArgs_);
		}
	}

	protected override void OnMouseDragEnd(bool cancel)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		((ControlDesigner)this).get_Control().set_Capture(false);
		Cursor.set_Clip(Rectangle.Empty);
		AdvTree advTree = ((ControlDesigner)this).get_Control() as AdvTree;
		if (bool_0)
		{
			if (advTree != null && advTree.IsDragDropInProgress)
			{
				if (cancel)
				{
					advTree.method_66();
				}
				else if (advTree.method_79() != null)
				{
					IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
					if (advTree.method_79().Tag is Node node)
					{
						Node parent = advTree.method_79().Parent;
						Node parent2 = node.Parent;
						if (componentChangeService != null)
						{
							if (parent2 != null)
							{
								componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(parent2).Find("Nodes", ignoreCase: true));
							}
							else
							{
								componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree).Find("Nodes", ignoreCase: true));
							}
							if (parent != null)
							{
								componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(parent).Find("Nodes", ignoreCase: true));
							}
							else
							{
								componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree).Find("Nodes", ignoreCase: true));
							}
						}
						advTree.method_65(new DragEventArgs((IDataObject)null, 0, 0, 0, (DragDropEffects)0, (DragDropEffects)0));
						if (componentChangeService != null)
						{
							if (parent2 != null)
							{
								componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(parent2).Find("Nodes", ignoreCase: true), null, null);
							}
							else
							{
								componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree).Find("Nodes", ignoreCase: true), null, null);
							}
							if (parent != null)
							{
								componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(parent).Find("Nodes", ignoreCase: true), null, null);
							}
							else
							{
								componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree).Find("Nodes", ignoreCase: true), null, null);
							}
						}
					}
				}
			}
			cancel = true;
		}
		else if (advTree.SelectedNode != null)
		{
			cancel = true;
		}
		bool_0 = false;
		((ParentControlDesigner)this).OnMouseDragEnd(cancel);
	}

	private void method_12(object sender, EventArgs e)
	{
		method_13();
	}

	internal void method_13()
	{
		AdvTree object_ = ((ComponentDesigner)this).get_Component() as AdvTree;
		smethod_0((ComponentDesigner)(object)this, object_, "Columns");
	}

	internal static object smethod_0(ComponentDesigner componentDesigner_0, object object_0, string string_1)
	{
		Type type = Type.GetType("System.Windows.Forms.Design.EditorServiceContext");
		if ((object)type == null)
		{
			type = Type.GetType("System.Windows.Forms.Design.EditorServiceContext, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
		}
		if ((object)type != null)
		{
			MethodInfo method = type.GetMethod("EditValue");
			if ((object)method != null)
			{
				return method.Invoke(null, new object[3] { componentDesigner_0, object_0, string_1 });
			}
		}
		return null;
	}

	private void method_14(object sender, EventArgs e)
	{
		method_15();
	}

	internal void method_15()
	{
		Node node = method_16(((ComponentDesigner)this).get_Component() as AdvTree);
		if (node != null)
		{
			ISelectionService selectionService = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
			ArrayList arrayList = new ArrayList(1);
			arrayList.Add(node);
			if (selectionService != null)
			{
				selectionService.SetSelectedComponents(arrayList, SelectionTypes.MouseDown);
				node.TreeControl.SelectedNode = node;
			}
		}
	}

	private Node method_16(AdvTree advTree_0)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		Node node = null;
		advTree_0.BeginUpdate();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree_0).Find("Nodes", ignoreCase: true));
			node = designerHost.CreateComponent(typeof(Node)) as Node;
			if (node != null)
			{
				node.Text = node.Name;
				node.Expanded = true;
				advTree_0.Nodes.Add(node);
				if (componentChangeService != null)
				{
					componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(advTree_0).Find("Nodes", ignoreCase: true), null, null);
					return node;
				}
				return node;
			}
			return node;
		}
		finally
		{
			advTree_0.EndUpdate();
		}
	}

	protected override bool GetHitTest(Point pt)
	{
		if (((ControlDesigner)this).get_Control() is AdvTree advTree && ((Control)advTree).get_IsHandleCreated() && advTree.AutoScroll)
		{
			Point pt2 = ((Control)advTree).PointToClient(pt);
			if (advTree.VScrollBar != null && ((Control)advTree.VScrollBar).get_Bounds().Contains(pt2))
			{
				return true;
			}
			if (advTree.HScrollBar != null && ((Control)advTree.HScrollBar).get_Bounds().Contains(pt2))
			{
				return true;
			}
		}
		return ((ControlDesigner)this).GetHitTest(pt);
	}
}
