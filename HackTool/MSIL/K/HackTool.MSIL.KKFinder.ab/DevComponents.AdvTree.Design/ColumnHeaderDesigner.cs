using System.Collections;
using System.ComponentModel.Design;

namespace DevComponents.AdvTree.Design;

public class ColumnHeaderDesigner : ComponentDesigner
{
	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		SetDefaults();
		((ComponentDesigner)this).InitializeNewComponent(defaultValues);
	}

	private void SetDefaults()
	{
		ColumnHeader columnHeader = ((ComponentDesigner)this).get_Component() as ColumnHeader;
		columnHeader.Width.Absolute = 150;
		columnHeader.Text = "Column";
	}
}
