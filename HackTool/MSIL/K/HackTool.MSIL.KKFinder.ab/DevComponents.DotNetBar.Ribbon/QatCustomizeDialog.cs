using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Ribbon;

public class QatCustomizeDialog : Office2007Form
{
	private QatCustomizePanel qatCustomizePanel1;

	internal ButtonX buttonOK;

	internal ButtonX buttonCancel;

	private IContainer icontainer_1;

	public QatCustomizePanel QatCustomizePanel => qatCustomizePanel1;

	public QatCustomizeDialog()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_1 != null)
		{
			icontainer_1.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		qatCustomizePanel1 = new QatCustomizePanel();
		buttonOK = new ButtonX();
		buttonCancel = new ButtonX();
		((Control)this).SuspendLayout();
		((Control)qatCustomizePanel1).set_BackColor(Color.Transparent);
		((Control)qatCustomizePanel1).set_Location(new Point(0, 0));
		((Control)qatCustomizePanel1).set_Name("qatCustomizePanel1");
		((Control)qatCustomizePanel1).set_Size(new Size(444, 298));
		((Control)qatCustomizePanel1).set_TabIndex(0);
		buttonOK.ColorTable = eButtonColor.OrangeWithBackground;
		buttonOK.DialogResult = (DialogResult)1;
		((Control)buttonOK).set_Location(new Point(285, 297));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(73, 21));
		((Control)buttonOK).set_TabIndex(1);
		((Control)buttonOK).set_Text("OK");
		buttonCancel.ColorTable = eButtonColor.OrangeWithBackground;
		buttonCancel.DialogResult = (DialogResult)2;
		((Control)buttonCancel).set_Location(new Point(364, 297));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(73, 21));
		((Control)buttonCancel).set_TabIndex(2);
		((Control)buttonCancel).set_Text("Cancel");
		((Form)this).set_ClientSize(new Size(445, 324));
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonOK);
		((Control)this).get_Controls().Add((Control)(object)qatCustomizePanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Name("QatCustomizeDialog");
		((Control)this).set_Text("Customize");
		((Control)this).ResumeLayout(false);
	}

	public void LoadItems(RibbonControl rc)
	{
		qatCustomizePanel1.LoadItems(rc);
	}
}
