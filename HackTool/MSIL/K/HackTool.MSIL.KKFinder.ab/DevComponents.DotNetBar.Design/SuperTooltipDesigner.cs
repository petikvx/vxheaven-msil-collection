using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class SuperTooltipDesigner : ComponentDesigner
{
	public override void Initialize(IComponent component)
	{
		((ComponentDesigner)this).Initialize(component);
		if (!component.Site!.DesignMode)
		{
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ComponentDesigner)this).InitializeNewComponent(defaultValues);
		SetDesignTimeDefaults();
	}

	private void SetDesignTimeDefaults()
	{
		SuperTooltip superTooltip = ((ComponentDesigner)this).get_Component() as SuperTooltip;
		if (superTooltip == null)
		{
		}
	}
}
