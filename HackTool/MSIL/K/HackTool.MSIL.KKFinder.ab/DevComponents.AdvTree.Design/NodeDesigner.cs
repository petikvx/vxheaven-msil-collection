using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace DevComponents.AdvTree.Design;

public class NodeDesigner : ComponentDesigner
{
	[Description("Gets or sets whether node is visible.")]
	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(true)]
	public bool Visible
	{
		get
		{
			return (bool)((ComponentDesigner)this).get_ShadowProperties().get_Item("Visible");
		}
		set
		{
			((ComponentDesigner)this).get_ShadowProperties().set_Item("Visible", (object)value);
		}
	}

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[3]
			{
				new DesignerVerb("Create Child Node", CreateNode),
				new DesignerVerb("Edit Cells...", EditCells),
				new DesignerVerb("Edit Columns...", EditColumns)
			};
			return new DesignerVerbCollection(value);
		}
	}

	public override void Initialize(IComponent component)
	{
		((ComponentDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			ISelectionService selectionService = (ISelectionService)((ComponentDesigner)this).GetService(typeof(ISelectionService));
			if (selectionService != null)
			{
				selectionService.SelectionChanged += OnSelectionChanged;
			}
			if (component is Node node)
			{
				Visible = node.Visible;
			}
		}
	}

	private void OnSelectionChanged(object sender, EventArgs e)
	{
		ISelectionService selectionService = (ISelectionService)sender;
		if (((ComponentDesigner)this).get_Component() == null || selectionService.PrimarySelection == ((ComponentDesigner)this).get_Component())
		{
			return;
		}
		Node node = ((ComponentDesigner)this).get_Component() as Node;
		if (selectionService.PrimarySelection is Node)
		{
			Node node2 = selectionService.PrimarySelection as Node;
			if (node2.TreeControl != node.TreeControl)
			{
				node.TreeControl.SelectedNode = null;
			}
		}
		else if (node != null && node.TreeControl != null)
		{
			node.TreeControl.SelectedNode = null;
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ComponentDesigner)this).PreFilterProperties(properties);
		properties["Visible"] = TypeDescriptor.CreateProperty(typeof(NodeDesigner), (PropertyDescriptor)properties["Visible"], new DefaultValueAttribute(value: true), new BrowsableAttribute(browsable: true), new CategoryAttribute("Layout"));
	}

	private void EditCells(object sender, EventArgs e)
	{
		AdvTreeDesigner.smethod_0((ComponentDesigner)(object)this, ((ComponentDesigner)this).get_Component(), "Cells");
	}

	private void EditColumns(object sender, EventArgs e)
	{
		AdvTreeDesigner.smethod_0((ComponentDesigner)(object)this, ((ComponentDesigner)this).get_Component(), "NodesColumns");
	}

	private void CreateNode(object sender, EventArgs e)
	{
		Node node = CreateNode(((ComponentDesigner)this).get_Component() as Node);
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

	private Node CreateNode(Node parentNode)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		Node node = null;
		AdvTree treeControl = ((Node)((ComponentDesigner)this).get_Component()).TreeControl;
		treeControl.BeginUpdate();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			if (componentChangeService != null)
			{
				if (parentNode != null)
				{
					componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(parentNode).Find("Nodes", ignoreCase: true));
				}
				else
				{
					componentChangeService.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(treeControl).Find("Nodes", ignoreCase: true));
				}
			}
			node = designerHost.CreateComponent(typeof(Node)) as Node;
			if (node != null)
			{
				node.Text = node.Name;
				node.Expanded = true;
				if (parentNode == null)
				{
					treeControl.Nodes.Add(node);
				}
				else
				{
					parentNode.Nodes.Add(node);
					parentNode.Expand();
					TypeDescriptor.GetProperties(node)["Style"]!.SetValue(node, parentNode.Style);
				}
				if (componentChangeService != null)
				{
					if (parentNode != null)
					{
						componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(parentNode).Find("Nodes", ignoreCase: true), null, null);
						return node;
					}
					componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(treeControl).Find("Nodes", ignoreCase: true), null, null);
					return node;
				}
				return node;
			}
			return node;
		}
		finally
		{
			treeControl.EndUpdate();
		}
	}
}
