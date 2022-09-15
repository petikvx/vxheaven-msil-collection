using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ExplorerBarDesigner : BarBaseControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[2]
			{
				new DesignerVerb("Create Group", method_13),
				new DesignerVerb("Create Button", method_15)
			};
			return new DesignerVerbCollection(value);
		}
	}

	public ExplorerBarDesigner()
	{
		EnableItemDragDrop = true;
	}

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		if (component.Site!.DesignMode && ((ControlDesigner)this).get_Control() is ExplorerBar explorerBar)
		{
			explorerBar.method_13();
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_12();
	}

	private void method_12()
	{
		if (((ControlDesigner)this).get_Control() is ExplorerBar)
		{
			ExplorerBar explorerBar = ((ControlDesigner)this).get_Control() as ExplorerBar;
			explorerBar.method_4();
			explorerBar.ThemeAware = true;
			explorerBar.StockStyle = eExplorerBarStockStyle.SystemColors;
		}
	}

	protected override BaseItem GetItemContainer()
	{
		if (((ControlDesigner)this).get_Control() is ExplorerBar explorerBar)
		{
			return explorerBar.ItemsContainer;
		}
		return null;
	}

	protected override void RecalcLayout()
	{
		if (GetItemContainerControl() is ExplorerBar explorerBar)
		{
			explorerBar.RecalcLayout();
		}
	}

	protected override void OnSubItemsChanging()
	{
		base.OnSubItemsChanging();
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			ExplorerBar component = GetItemContainerControl() as ExplorerBar;
			componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(component).Find("Groups", ignoreCase: true));
		}
	}

	protected override void OnSubItemsChanged()
	{
		base.OnSubItemsChanged();
		if (((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) is IComponentChangeService componentChangeService)
		{
			ExplorerBar component = GetItemContainerControl() as ExplorerBar;
			componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(component).Find("Groups", ignoreCase: true), null, null);
		}
	}

	private void method_13(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			method_14();
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
		}
	}

	private ExplorerBarGroupItem method_14()
	{
		ExplorerBar explorerBar = ((ComponentDesigner)this).get_Component() as ExplorerBar;
		ExplorerBarGroupItem result = null;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (explorerBar != null && designerHost != null)
		{
			OnSubItemsChanging();
			try
			{
				m_CreatingItem = true;
				if (!(designerHost.CreateComponent(typeof(ExplorerBarGroupItem)) is ExplorerBarGroupItem explorerBarGroupItem))
				{
					return null;
				}
				explorerBarGroupItem.SetDefaultAppearance();
				explorerBarGroupItem.Text = "New Group";
				explorerBarGroupItem.Expanded = true;
				explorerBar.Groups.Add(explorerBarGroupItem);
				OnSubItemsChanged();
				return explorerBarGroupItem;
			}
			finally
			{
				m_CreatingItem = false;
			}
		}
		return result;
	}

	private void method_15(object sender, EventArgs e)
	{
		ExplorerBar explorerBar = ((ComponentDesigner)this).get_Component() as ExplorerBar;
		ExplorerBarGroupItem explorerBarGroupItem = null;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			if (selectionService != null && selectionService.PrimarySelection is ExplorerBarGroupItem)
			{
				explorerBarGroupItem = selectionService.PrimarySelection as ExplorerBarGroupItem;
			}
			else if (explorerBar.Groups.Count > 0)
			{
				Point pt = ((Control)explorerBar).PointToClient(Control.get_MousePosition());
				if (((Control)explorerBar).get_Bounds().Contains(pt))
				{
					foreach (BaseItem group in explorerBar.Groups)
					{
						if (group.DisplayRectangle.Contains(pt))
						{
							explorerBarGroupItem = group as ExplorerBarGroupItem;
							break;
						}
					}
				}
				if (explorerBarGroupItem == null)
				{
					foreach (BaseItem group2 in explorerBar.Groups)
					{
						if (group2.Visible)
						{
							explorerBarGroupItem = group2 as ExplorerBarGroupItem;
							break;
						}
					}
				}
			}
			if (explorerBarGroupItem == null)
			{
				explorerBarGroupItem = method_14();
			}
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(explorerBarGroupItem).Find("SubItems", ignoreCase: true));
			try
			{
				m_CreatingItem = true;
				if (!(designerHost.CreateComponent(typeof(ButtonItem)) is ButtonItem buttonItem))
				{
					return;
				}
				ExplorerBarGroupItem.smethod_0(buttonItem, explorerBarGroupItem.StockStyle);
				explorerBarGroupItem.SubItems.Add(buttonItem);
				componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(explorerBarGroupItem).Find("SubItems", ignoreCase: true), null, null);
			}
			finally
			{
				m_CreatingItem = false;
			}
			RecalcLayout();
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
		}
	}

	protected override bool CanDragItem(BaseItem item)
	{
		if (item is ExplorerBarGroupItem)
		{
			return false;
		}
		return base.CanDragItem(item);
	}
}
