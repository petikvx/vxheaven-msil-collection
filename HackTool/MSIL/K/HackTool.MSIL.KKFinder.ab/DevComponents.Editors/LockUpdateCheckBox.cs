using System;
using System.Drawing;

namespace DevComponents.Editors;

public class LockUpdateCheckBox : VisualCheckBox
{
	public LockUpdateCheckBox()
	{
		Checked = true;
	}

	public override void PerformLayout(PaintInfo pi)
	{
		base.PerformLayout(pi);
		base.Size = new Size(base.Size.Width + 4, base.Size.Height);
	}

	protected override void OnCheckedChanged(EventArgs e)
	{
		if (base.Parent != null)
		{
			VisualGroup parent = base.Parent;
			for (int i = 0; i < parent.Items.Count; i++)
			{
				VisualItem visualItem = parent.Items[i];
				if (visualItem != this)
				{
					visualItem.Enabled = Checked;
				}
			}
		}
		base.OnCheckedChanged(e);
	}
}
