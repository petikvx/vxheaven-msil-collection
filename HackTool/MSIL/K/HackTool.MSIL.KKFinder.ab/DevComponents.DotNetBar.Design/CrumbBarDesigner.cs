using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar.Design;

public class CrumbBarDesigner : ControlDesigner
{
	[DefaultValue(eCrumbBarStyle.Vista)]
	[Description("Indicates visual style of the control.")]
	[Category("Appearance")]
	public eCrumbBarStyle Style
	{
		get
		{
			return ((CrumbBar)(object)((ControlDesigner)this).get_Control()).Style;
		}
		set
		{
			CrumbBar crumbBar = ((ControlDesigner)this).get_Control() as CrumbBar;
			bool flag = crumbBar.Style != value;
			crumbBar.Style = value;
			if (flag && ((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && !designerHost.Loading)
			{
				switch (value)
				{
				case eCrumbBarStyle.Vista:
					method_1();
					break;
				case eCrumbBarStyle.Office2007:
					method_2();
					break;
				}
			}
		}
	}

	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] array = null;
			array = new DesignerVerb[1]
			{
				new DesignerVerb("Edit Items...", method_3)
			};
			return new DesignerVerbCollection(array);
		}
	}

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			if (((ControlDesigner)this).get_Control() is CrumbBar crumbBar)
			{
				{
					foreach (BaseItem item in crumbBar.Items)
					{
						method_10(item, arrayList);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	public override void Initialize(IComponent component)
	{
		((ControlDesigner)this).Initialize(component);
		if (component.Site!.DesignMode)
		{
			IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
			if (componentChangeService != null)
			{
				componentChangeService.ComponentRemoving += OnComponentRemoving;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoving -= OnComponentRemoving;
		}
		((ControlDesigner)this).Dispose(disposing);
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		method_0();
	}

	private void method_0()
	{
		method_1();
		CrumbBar crumbBar = ((ControlDesigner)this).get_Control() as CrumbBar;
		((Control)crumbBar).set_AutoSize(true);
	}

	private void method_1()
	{
		CrumbBar crumbBar = ((ControlDesigner)this).get_Control() as CrumbBar;
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		componentChangeService?.OnComponentChanging(this, TypeDescriptor.GetProperties(crumbBar)["BackgroundStyle"]);
		crumbBar.BackgroundStyle.Reset();
		crumbBar.BackgroundStyle.Border = eStyleBorderType.Solid;
		crumbBar.BackgroundStyle.BorderWidth = 1;
		crumbBar.BackgroundStyle.BorderColor = ColorScheme.GetColor("53595E");
		crumbBar.BackgroundStyle.BorderColor2 = ColorScheme.GetColor("A9B4BF");
		crumbBar.BackgroundStyle.BackColor = ColorScheme.GetColor("F8FAFD");
		componentChangeService?.OnComponentChanged(this, TypeDescriptor.GetProperties(crumbBar)["BackgroundStyle"], null, null);
	}

	private void method_2()
	{
		CrumbBar crumbBar = ((ControlDesigner)this).get_Control() as CrumbBar;
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		componentChangeService?.OnComponentChanging(this, TypeDescriptor.GetProperties(crumbBar)["BackgroundStyle"]);
		crumbBar.BackgroundStyle.Reset();
		crumbBar.BackgroundStyle.Class = ElementStyleClassKeys.CrumbBarBackgroundKey;
		componentChangeService?.OnComponentChanged(this, TypeDescriptor.GetProperties(crumbBar)["BackgroundStyle"], null, null);
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ControlDesigner)this).PreFilterProperties(properties);
		properties["Style"] = TypeDescriptor.CreateProperty(typeof(CrumbBarDesigner), (PropertyDescriptor)properties["Style"], new DefaultValueAttribute(eCrumbBarStyle.Vista), new BrowsableAttribute(browsable: true), new CategoryAttribute("Appearance"));
	}

	private void method_3(object sender, EventArgs e)
	{
		method_4();
	}

	internal void method_4()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		CrumbBar crumbBar_ = ((ComponentDesigner)this).get_Component() as CrumbBar;
		Form val = new Form();
		((Control)val).set_Text("CrumbBar control editor");
		val.set_FormBorderStyle((FormBorderStyle)4);
		val.set_MinimizeBox(false);
		val.set_StartPosition((FormStartPosition)1);
		CrumbBarItemsEditor crumbBarItemsEditor = new CrumbBarItemsEditor();
		((Control)crumbBarItemsEditor).set_Dock((DockStyle)5);
		val.set_Size(new Size(800, 600));
		((Control)val).get_Controls().Add((Control)(object)crumbBarItemsEditor);
		crumbBarItemsEditor.CrumbBar_0 = crumbBar_;
		crumbBarItemsEditor.CrumbBarDesigner_0 = this;
		crumbBarItemsEditor.method_4();
		val.ShowDialog();
		((Component)(object)val).Dispose();
	}

	private void method_5(object sender, EventArgs e)
	{
		method_6();
	}

	internal void method_6()
	{
		CrumbBarItem crumbBarItem = method_7(((ComponentDesigner)this).get_Component() as CrumbBar);
		if (crumbBarItem == null)
		{
			return;
		}
		ISelectionService selectionService = ((ComponentDesigner)this).GetService(typeof(ISelectionService)) as ISelectionService;
		ArrayList arrayList = new ArrayList(1);
		arrayList.Add(crumbBarItem);
		if (selectionService != null)
		{
			selectionService.SetSelectedComponents(arrayList, SelectionTypes.MouseDown);
			if (((ComponentDesigner)this).get_Component() is CrumbBar crumbBar && crumbBar.SelectedItem == null)
			{
				crumbBar.SelectedItem = crumbBarItem;
			}
		}
	}

	public object GetDesignService(Type serviceType)
	{
		return ((ComponentDesigner)this).GetService(serviceType);
	}

	private CrumbBarItem method_7(CrumbBar crumbBar_0)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (designerHost == null)
		{
			return null;
		}
		CrumbBarItem crumbBarItem = null;
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(crumbBar_0).Find("Items", ignoreCase: true));
			crumbBarItem = designerHost.CreateComponent(typeof(CrumbBarItem)) as CrumbBarItem;
			if (crumbBarItem != null)
			{
				crumbBarItem.Text = crumbBarItem.Name;
				crumbBar_0.Items.Add(crumbBarItem);
				if (componentChangeService != null)
				{
					componentChangeService.OnComponentChanged(((ComponentDesigner)this).get_Component(), TypeDescriptor.GetProperties(crumbBar_0).Find("Items", ignoreCase: true), null, null);
					return crumbBarItem;
				}
				return crumbBarItem;
			}
			return crumbBarItem;
		}
		finally
		{
			crumbBar_0.RecalcLayout();
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
		if (e.Component is CrumbBarItem && ((CrumbBarItem)e.Component).GetOwner() == ((ControlDesigner)this).get_Control())
		{
			method_8(e.Component as CrumbBarItem);
		}
	}

	private void method_8(CrumbBarItem crumbBarItem_0)
	{
		IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		CrumbBar crumbBar = ((ControlDesigner)this).get_Control() as CrumbBar;
		bool isInSelectedPath = crumbBar.GetIsInSelectedPath(crumbBarItem_0);
		if (crumbBarItem_0.Parent != null)
		{
			if (crumbBarItem_0.Parent is CrumbBarItem crumbBarItem)
			{
				componentChangeService?.OnComponentChanging(crumbBarItem, TypeDescriptor.GetProperties(crumbBarItem)["SubItems"]);
				crumbBarItem.SubItems.Remove(crumbBarItem_0);
				componentChangeService?.OnComponentChanged(crumbBarItem, TypeDescriptor.GetProperties(crumbBarItem)["SubItems"], null, null);
			}
		}
		else
		{
			componentChangeService?.OnComponentChanging(crumbBar, TypeDescriptor.GetProperties(crumbBar)["Items"]);
			crumbBar.Items.Remove(crumbBarItem_0);
			componentChangeService?.OnComponentChanged(crumbBar, TypeDescriptor.GetProperties(crumbBar)["Items"], null, null);
		}
		if (crumbBarItem_0.SubItems.Count > 0)
		{
			BaseItem[] array = new BaseItem[crumbBarItem_0.SubItems.Count];
			crumbBarItem_0.SubItems.CopyTo(array, 0);
			BaseItem[] array2 = array;
			foreach (BaseItem baseItem in array2)
			{
				crumbBarItem_0.SubItems.Remove(baseItem);
				designerHost?.DestroyComponent(baseItem);
			}
		}
		if (isInSelectedPath)
		{
			crumbBar.SelectedItem = crumbBar.method_27();
		}
		method_9();
	}

	private void method_9()
	{
		if (((ControlDesigner)this).get_Control() is CrumbBar crumbBar)
		{
			crumbBar.RecalcLayout();
		}
	}

	private void method_10(BaseItem baseItem_0, ArrayList arrayList_0)
	{
		arrayList_0.Add(baseItem_0);
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			arrayList_0.Add(subItem);
			method_10(subItem, arrayList_0);
		}
	}
}
