using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using DevComponents.AdvTree;
using DevComponents.AdvTree.Design;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class ComboTreeDesigner : ControlDesigner
{
	private DesignerActionListCollection designerActionListCollection_0;

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			ComboTree comboTree = ((ComponentDesigner)this).get_Component() as ComboTree;
			foreach (Node node in comboTree.Nodes)
			{
				arrayList.Add(node);
				method_1(node, arrayList);
			}
			return arrayList;
		}
	}

	public override DesignerActionListCollection ActionLists
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (designerActionListCollection_0 == null)
			{
				designerActionListCollection_0 = new DesignerActionListCollection();
				designerActionListCollection_0.Add((DesignerActionList)(object)new Class199(this));
			}
			return designerActionListCollection_0;
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		method_0();
	}

	public override void Initialize(IComponent component)
	{
		((ControlDesigner)this).Initialize(component);
		if (component.Site == null || component.Site!.DesignMode)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += method_2;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoved -= method_2;
		}
		((ControlDesigner)this).Dispose(disposing);
	}

	private void method_0()
	{
		ComboTree comboTree = ((ControlDesigner)this).get_Control() as ComboTree;
		PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(comboTree)["Text"];
		if (propertyDescriptor != null && (object)propertyDescriptor.PropertyType == typeof(string) && !propertyDescriptor.IsReadOnly && propertyDescriptor.IsBrowsable)
		{
			propertyDescriptor.SetValue(comboTree, "");
		}
		comboTree.ButtonDropDown.Visible = true;
		comboTree.BackgroundStyle.Class = ElementStyleClassKeys.TextBoxBorderKey;
	}

	private void method_1(Node node_0, ArrayList arrayList_0)
	{
		foreach (Node node in node_0.Nodes)
		{
			arrayList_0.Add(node);
		}
	}

	private void method_2(object sender, ComponentEventArgs e)
	{
		if (e.Component != ((ComponentDesigner)this).get_Component())
		{
			return;
		}
		ICollection associatedComponents = ((ComponentDesigner)this).get_AssociatedComponents();
		if (!(((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost))
		{
			return;
		}
		foreach (object item in associatedComponents)
		{
			if (item is Node)
			{
				Node component = item as Node;
				designerHost.DestroyComponent(component);
			}
		}
	}

	internal void method_3()
	{
		ComboTree object_ = ((ComponentDesigner)this).get_Component() as ComboTree;
		AdvTreeDesigner.smethod_0((ComponentDesigner)(object)this, object_, "Columns");
	}

	internal void method_4()
	{
		method_5(((ComponentDesigner)this).get_Component() as ComboTree);
	}

	private Node method_5(ComboTree comboTree_0)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		Node node = null;
		comboTree_0.AdvTree.BeginUpdate();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(comboTree_0).Find("Nodes", ignoreCase: true));
			node = designerHost.CreateComponent(typeof(Node)) as Node;
			if (node != null)
			{
				node.Text = node.Name;
				node.Expanded = true;
				comboTree_0.Nodes.Add(node);
				if (componentChangeService != null)
				{
					componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(comboTree_0).Find("Nodes", ignoreCase: true), null, null);
					return node;
				}
				return node;
			}
			return node;
		}
		finally
		{
			comboTree_0.AdvTree.EndUpdate();
		}
	}
}
