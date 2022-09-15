using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Design;

public class ComboBoxExDesigner : ControlDesigner
{
	private DesignerActionListCollection designerActionListCollection_0;

	public override DesignerActionListCollection ActionLists
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			if (designerActionListCollection_0 == null)
			{
				designerActionListCollection_0 = new DesignerActionListCollection();
				object obj = ((object)this).GetType().Assembly.CreateInstance("System.Windows.Forms.Design.ListControlBoundActionList", ignoreCase: false, BindingFlags.NonPublic, null, new object[1] { this }, null, null);
				if (obj != null)
				{
					designerActionListCollection_0.Add((DesignerActionList)((obj is DesignerActionList) ? obj : null));
				}
			}
			return designerActionListCollection_0;
		}
	}

	public override SelectionRules SelectionRules
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Invalid comparison between Unknown and I4
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Invalid comparison between Unknown and I4
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			SelectionRules selectionRules = ((ControlDesigner)this).get_SelectionRules();
			ComboBoxEx component = ((ControlDesigner)this).get_Control() as ComboBoxEx;
			PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(component)["DropDownStyle"];
			if (propertyDescriptor == null)
			{
				return selectionRules;
			}
			ComboBoxStyle val = (ComboBoxStyle)propertyDescriptor.GetValue(component);
			if ((int)val != 1 && (int)val != 2)
			{
				return selectionRules;
			}
			return (SelectionRules)(selectionRules & -4);
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Gets or sets the combo box flat style")]
	[Browsable(true)]
	public FlatStyle FlatStyle
	{
		get
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			Control control = ((ControlDesigner)this).get_Control();
			ComboBox val = (ComboBox)(object)((control is ComboBox) ? control : null);
			return val.get_FlatStyle();
		}
		set
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			Control control = ((ControlDesigner)this).get_Control();
			ComboBox val = (ComboBox)(object)((control is ComboBox) ? control : null);
			val.set_FlatStyle(value);
		}
	}

	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ControlDesigner)this).get_AssociatedComponents());
			ComboBoxEx comboBoxEx = ((ComponentDesigner)this).get_Component() as ComboBoxEx;
			foreach (object item in comboBoxEx.Items)
			{
				if (item is ComboItem)
				{
					arrayList.Add(item);
				}
			}
			return arrayList;
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
				componentChangeService.ComponentRemoving += method_1;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		IComponentChangeService componentChangeService = (IComponentChangeService)((ComponentDesigner)this).GetService(typeof(IComponentChangeService));
		if (componentChangeService != null)
		{
			componentChangeService.ComponentRemoved -= method_1;
		}
		((ControlDesigner)this).Dispose(disposing);
	}

	private void method_0()
	{
		ComboBoxEx comboBoxEx = ((ControlDesigner)this).get_Control() as ComboBoxEx;
		((ListControl)comboBoxEx).set_DisplayMember("Text");
		((ComboBox)comboBoxEx).set_DrawMode((DrawMode)1);
		((ComboBox)comboBoxEx).set_ItemHeight(comboBoxEx.method_15() + 1);
		((ListControl)comboBoxEx).set_FormattingEnabled(true);
		PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(comboBoxEx)["Text"];
		if (propertyDescriptor != null && (object)propertyDescriptor.PropertyType == typeof(string) && !propertyDescriptor.IsReadOnly && propertyDescriptor.IsBrowsable)
		{
			propertyDescriptor.SetValue(comboBoxEx, "");
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ControlDesigner)this).PreFilterProperties(properties);
		properties["FlatStyle"] = TypeDescriptor.CreateProperty(((object)this).GetType(), "FlatStyle", typeof(FlatStyle), new BrowsableAttribute(browsable: true), new DefaultValueAttribute((object)(FlatStyle)0));
	}

	private void method_1(object sender, ComponentEventArgs e)
	{
		if (e.Component != ((ComponentDesigner)this).get_Component())
		{
			return;
		}
		ComboBoxEx comboBoxEx = ((ComponentDesigner)this).get_Component() as ComboBoxEx;
		if (!(((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost))
		{
			return;
		}
		foreach (object item in comboBoxEx.Items)
		{
			if (item is ComboItem)
			{
				ComboItem component = item as ComboItem;
				designerHost.DestroyComponent(component);
			}
		}
	}
}
