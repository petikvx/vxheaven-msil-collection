using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;

namespace DevComponents.DotNetBar.Design;

public class DockSiteDesigner : ParentControlDesigner
{
	private bool bool_0;

	internal bool bool_1;

	public override SelectionRules SelectionRules => (SelectionRules)0;

	protected override void OnContextMenu(int x, int y)
	{
	}

	public override bool CanParent(Control control)
	{
		if (control is IDockInfo && !(control is ContextMenuBar))
		{
			return true;
		}
		return false;
	}

	public override void Initialize(IComponent component)
	{
		((ParentControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += method_1;
			}
			if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && designerHost.Loading)
			{
				((DockSite)component).bool_6 = true;
				designerHost.LoadComplete += method_0;
			}
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		DockSite dockSite = (DockSite)(object)((ControlDesigner)this).get_Control();
		dockSite.bool_6 = false;
		if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
		{
			designerHost.LoadComplete -= method_0;
		}
	}

	protected override void Dispose(bool disposing)
	{
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= method_1;
		}
		((ParentControlDesigner)this).Dispose(disposing);
	}

	private void method_1(object sender, ComponentEventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		if (e.Component != ((ComponentDesigner)this).get_Component())
		{
			return;
		}
		DockSite dockSite = ((ControlDesigner)this).get_Control() as DockSite;
		if ((int)((Control)dockSite).get_Dock() != 5 && !bool_1)
		{
			throw new InvalidOperationException("DotNetBarManager dock sites must not be removed manually. Delete DotNetBarManager component to remove all dock sites.");
		}
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost != null)
		{
			Bar[] array = new Bar[((ArrangedElementCollection)((Control)dockSite).get_Controls()).get_Count()];
			((ArrangedElementCollection)((Control)dockSite).get_Controls()).CopyTo((Array)array, 0);
			Bar[] array2 = array;
			foreach (Bar bar in array2)
			{
				if (bar != null)
				{
					designerHost.DestroyComponent((IComponent)bar);
				}
			}
		}
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= method_1;
		}
		if (dockSite != null && dockSite.Owner != null)
		{
			if (dockSite.Owner.FillDockSite == dockSite)
			{
				dockSite.Owner.FillDockSite = null;
			}
			else if (dockSite.Owner.LeftDockSite == dockSite)
			{
				dockSite.Owner.LeftDockSite = null;
			}
			else if (dockSite.Owner.RightDockSite == dockSite)
			{
				dockSite.Owner.RightDockSite = null;
			}
			else if (dockSite.Owner.TopDockSite == dockSite)
			{
				dockSite.Owner.TopDockSite = null;
			}
			else if (dockSite.Owner.BottomDockSite == dockSite)
			{
				dockSite.Owner.BottomDockSite = null;
			}
		}
	}

	protected override void OnSetCursor()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		DockSite dockSite = ((ControlDesigner)this).get_Control() as DockSite;
		if ((int)((Control)dockSite).get_Dock() != 5 && dockSite.DocumentDockContainer == null)
		{
			return;
		}
		Point mousePosition = Control.get_MousePosition();
		if (dockSite != null && ((ArrangedElementCollection)((Control)dockSite).get_Controls()).get_Count() != 0)
		{
			DocumentDockUIManager documentUIManager = dockSite.GetDocumentUIManager();
			Point point = ((Control)dockSite).PointToClient(mousePosition);
			Cursor val = documentUIManager.method_13(point.X, point.Y);
			if (val != (Cursor)null)
			{
				Cursor.set_Current(val);
			}
			else
			{
				Cursor.set_Current(Cursors.get_Default());
			}
		}
	}

	protected override void OnMouseDragBegin(int x, int y)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		DockSite dockSite = ((ControlDesigner)this).get_Control() as DockSite;
		if (((int)((ControlDesigner)this).get_Control().get_Dock() == 5 && dockSite != null) || dockSite.DocumentDockContainer != null)
		{
			DocumentDockUIManager documentUIManager = dockSite.GetDocumentUIManager();
			Point point = ((Control)dockSite).PointToClient(new Point(x, y));
			Cursor val = documentUIManager.method_13(point.X, point.Y);
			if (val != (Cursor)null)
			{
				documentUIManager.OnMouseDown(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
				bool_0 = true;
			}
		}
		((ParentControlDesigner)this).OnMouseDragBegin(x, y);
		if (bool_0)
		{
			((Control)dockSite).set_Capture(true);
			if ((int)((Control)dockSite).get_Dock() == 5 || dockSite.GetDocumentUIManager().IsResizingDocument)
			{
				Class51.RECT r = new Class51.RECT(0, 0, 0, 0);
				Class51.GetWindowRect(((Control)dockSite).get_Handle(), ref r);
				Rectangle clip = Rectangle.FromLTRB(r.Left, r.Top, r.Right, r.Bottom);
				Cursor.set_Clip(clip);
			}
		}
	}

	protected override void OnMouseDragMove(int x, int y)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		DockSite dockSite = ((ControlDesigner)this).get_Control() as DockSite;
		if (bool_0 && dockSite != null)
		{
			DocumentDockUIManager documentUIManager = dockSite.GetDocumentUIManager();
			Point point = ((Control)dockSite).PointToClient(new Point(x, y));
			documentUIManager.OnMouseMove(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
		}
		else
		{
			((ParentControlDesigner)this).OnMouseDragMove(x, y);
		}
	}

	protected override void OnMouseDragEnd(bool cancel)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		if (bool_0)
		{
			((ControlDesigner)this).get_Control().set_Capture(false);
			Cursor.set_Clip(Rectangle.Empty);
		}
		DockSite dockSite = ((ControlDesigner)this).get_Control() as DockSite;
		if (bool_0 && dockSite != null)
		{
			DocumentDockUIManager documentUIManager = dockSite.GetDocumentUIManager();
			Point point = ((Control)dockSite).PointToClient(Control.get_MousePosition());
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			componentChangeService?.OnComponentChanging(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"]);
			documentUIManager.OnMouseUp(new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0));
			componentChangeService?.OnComponentChanged(dockSite, TypeDescriptor.GetProperties(typeof(DockSite))["DocumentDockContainer"], null, null);
		}
		bool_0 = false;
		((ParentControlDesigner)this).OnMouseDragEnd(cancel);
	}
}
