using System.Collections;
using System.Windows.Forms.Design;

namespace DevComponents.Editors.Design;

public class NumericInputBaseDesigner : VisualControlBaseDesigner
{
	public override SelectionRules SelectionRules
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			SelectionRules val = ((ControlDesigner)this).get_SelectionRules();
			if (!((ControlDesigner)this).get_Control().get_AutoSize())
			{
				val = (SelectionRules)(val & -4);
			}
			return val;
		}
	}

	public NumericInputBaseDesigner()
	{
		((ControlDesigner)this).set_AutoResizeHandles(true);
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		if (((ControlDesigner)this).get_Control() is NumericInputBase numericInputBase)
		{
			numericInputBase.ShowUpDown = true;
			numericInputBase.AutoOverwrite = false;
		}
		base.InitializeNewComponent(defaultValues);
	}
}
