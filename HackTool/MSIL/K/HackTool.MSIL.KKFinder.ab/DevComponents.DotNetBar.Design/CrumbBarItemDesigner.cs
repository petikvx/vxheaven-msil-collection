using System.Collections;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class CrumbBarItemDesigner : ComponentDesigner
{
	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(((ComponentDesigner)this).get_AssociatedComponents());
			if (((ComponentDesigner)this).get_Component() is CrumbBarItem crumbBarItem)
			{
				{
					foreach (BaseItem subItem in crumbBarItem.SubItems)
					{
						GetItemsRecursive(subItem, arrayList);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	private void GetItemsRecursive(BaseItem parent, ArrayList c)
	{
		c.Add(parent);
		foreach (BaseItem subItem in parent.SubItems)
		{
			c.Add(subItem);
			GetItemsRecursive(subItem, c);
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ComponentDesigner)this).InitializeNewComponent(defaultValues);
		SetDesignTimeDefaults();
	}

	private void SetDesignTimeDefaults()
	{
		CrumbBarItem crumbBarItem = ((ComponentDesigner)this).get_Component() as CrumbBarItem;
		crumbBarItem.Text = crumbBarItem.Name;
	}
}
