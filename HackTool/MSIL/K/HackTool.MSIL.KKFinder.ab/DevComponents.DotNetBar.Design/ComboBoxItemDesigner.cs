using System.Collections;
using System.ComponentModel.Design;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Design;

public class ComboBoxItemDesigner : SimpleBaseItemDesigner
{
	public override ICollection AssociatedComponents
	{
		get
		{
			ArrayList arrayList = new ArrayList(base.AssociatedComponents);
			if (((ComponentDesigner)this).get_Component() is ComboBoxItem comboBoxItem)
			{
				{
					foreach (object item in comboBoxItem.Items)
					{
						if (item is ComboItem)
						{
							arrayList.Add(item);
						}
					}
					return arrayList;
				}
			}
			return arrayList;
		}
	}

	protected override void SetDesignTimeDefaults()
	{
		if (((ComponentDesigner)this).get_Component() is ComboBoxItem comboBoxItem)
		{
			comboBoxItem.DisplayMember = "Text";
		}
		base.SetDesignTimeDefaults();
	}
}
