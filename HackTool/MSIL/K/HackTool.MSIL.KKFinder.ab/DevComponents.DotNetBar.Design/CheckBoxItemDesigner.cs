using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class CheckBoxItemDesigner : BaseItemDesigner
{
	public override DesignerVerbCollection Verbs => new DesignerVerbCollection();

	protected override void SetDesignTimeDefaults()
	{
		if (((ComponentDesigner)this).get_Component() is CheckBoxItem checkBoxItem)
		{
			checkBoxItem.AutoCollapseOnClick = false;
		}
	}
}
