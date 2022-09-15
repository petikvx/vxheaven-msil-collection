using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Design;

[ToolboxItem(false)]
internal class WizardPageNavigationControl : UserControl
{
	public LinkLabel LinkBack;

	public LinkLabel LinkNext;

	private Container container_0;

	public WizardPageNavigationControl()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		LinkBack = new LinkLabel();
		LinkNext = new LinkLabel();
		((Control)this).SuspendLayout();
		((Control)LinkBack).set_Dock((DockStyle)3);
		((Control)LinkBack).set_Name("LinkBack");
		((Control)LinkBack).set_Size(new Size(45, 16));
		((Control)LinkBack).set_TabIndex(0);
		((Label)LinkBack).set_TabStop(true);
		((Control)LinkBack).set_Text("< Back");
		((Control)LinkNext).set_Dock((DockStyle)5);
		((Control)LinkNext).set_Location(new Point(40, 0));
		((Control)LinkNext).set_Name("LinkNext");
		((Control)LinkNext).set_Size(new Size(45, 16));
		((Control)LinkNext).set_TabIndex(1);
		((Label)LinkNext).set_TabStop(true);
		((Control)LinkNext).set_Text("Next >");
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[2]
		{
			(Control)LinkNext,
			(Control)LinkBack
		});
		((Control)this).set_Name("WizardPageNavigationControl");
		((Control)this).set_Size(new Size(90, 16));
		((Control)this).ResumeLayout(false);
	}
}
