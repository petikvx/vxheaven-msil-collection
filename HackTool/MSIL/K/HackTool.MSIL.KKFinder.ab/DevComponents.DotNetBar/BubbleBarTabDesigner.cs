using System.Collections;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar;

public class BubbleBarTabDesigner : ComponentDesigner
{
	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList();
			if (!(((ComponentDesigner)this).get_Component() is BubbleBarTab bubbleBarTab))
			{
				return ((ComponentDesigner)this).get_AssociatedComponents();
			}
			bubbleBarTab.Buttons.method_5(arrayList);
			return arrayList;
		}
	}
}
