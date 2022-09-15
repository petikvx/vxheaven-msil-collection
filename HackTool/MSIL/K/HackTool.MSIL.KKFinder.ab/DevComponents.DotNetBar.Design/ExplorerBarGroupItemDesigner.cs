using System.Collections;
using System.ComponentModel.Design;

namespace DevComponents.DotNetBar.Design;

public class ExplorerBarGroupItemDesigner : BaseItemDesigner
{
	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(base.AssociatedComponents);
			if (((ComponentDesigner)this).get_Component() is BaseItem baseItem)
			{
				{
					foreach (BaseItem subItem in baseItem.SubItems)
					{
						arrayList.Add(subItem);
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	protected override void BeforeNewItemAdded(BaseItem item)
	{
		base.BeforeNewItemAdded(item);
		if (item is ButtonItem)
		{
			ExplorerBarGroupItem.smethod_0((ButtonItem)item, ((ExplorerBarGroupItem)((ComponentDesigner)this).get_Component()).StockStyle);
		}
	}

	protected override void SetDesignTimeDefaults()
	{
		if (((ComponentDesigner)this).get_Component() is ExplorerBarGroupItem)
		{
			ExplorerBarGroupItem explorerBarGroupItem = ((ComponentDesigner)this).get_Component() as ExplorerBarGroupItem;
			explorerBarGroupItem.SetDefaultAppearance();
			explorerBarGroupItem.StockStyle = eExplorerBarStockStyle.SystemColors;
		}
	}
}
