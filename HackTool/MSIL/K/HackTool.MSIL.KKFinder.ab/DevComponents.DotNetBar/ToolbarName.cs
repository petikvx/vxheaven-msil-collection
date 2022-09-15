using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace DevComponents.DotNetBar;

[ToolboxItem(false)]
internal class ToolbarName : Form
{
	public bool bool_0;

	public TextBox txtName;

	private Label label1;

	private Button cmdOK;

	private Button cmdCancel;

	private Container container_0;

	public ToolbarName()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		cmdOK = new Button();
		cmdCancel = new Button();
		label1 = new Label();
		txtName = new TextBox();
		((Control)this).SuspendLayout();
		cmdOK.set_DialogResult((DialogResult)1);
		((ButtonBase)cmdOK).set_FlatStyle((FlatStyle)3);
		((Control)cmdOK).set_Location(new Point(113, 56));
		((Control)cmdOK).set_Name("cmdOK");
		((Control)cmdOK).set_Size(new Size(80, 24));
		((Control)cmdOK).set_TabIndex(2);
		((Control)cmdOK).set_Text("barname_ok");
		((Control)cmdCancel).set_CausesValidation(false);
		cmdCancel.set_DialogResult((DialogResult)2);
		((ButtonBase)cmdCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdCancel).set_Location(new Point(197, 56));
		((Control)cmdCancel).set_Name("cmdCancel");
		((Control)cmdCancel).set_Size(new Size(80, 24));
		((Control)cmdCancel).set_TabIndex(3);
		((Control)cmdCancel).set_Text("barname_cancel");
		((Control)label1).set_Location(new Point(8, 8));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(272, 16));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("barname_name");
		((Control)txtName).set_Location(new Point(8, 28));
		((Control)txtName).set_Name("txtName");
		((Control)txtName).set_Size(new Size(268, 20));
		((Control)txtName).set_TabIndex(1);
		((Control)txtName).set_Text("");
		((Control)txtName).add_Validating((CancelEventHandler)txtName_Validating);
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdOK);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_CancelButton((IButtonControl)(object)cmdCancel);
		((Form)this).set_ClientSize(new Size(286, 87));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[4]
		{
			(Control)cmdCancel,
			(Control)cmdOK,
			(Control)label1,
			(Control)txtName
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ToolbarName");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("barname_caption");
		((Form)this).add_Load((EventHandler)ToolbarName_Load);
		((Control)this).ResumeLayout(false);
	}

	private void ToolbarName_Load(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		DotNetBarManager manager = null;
		if (((Form)this).get_Owner() is frmCustomize)
		{
			manager = ((frmCustomize)(object)((Form)this).get_Owner()).method_10();
		}
		using (Class264 @class = new Class264(manager))
		{
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
			{
				Control val = item;
				if (!(val is TextBox))
				{
					val.set_Text(@class.method_1(val.get_Text()));
				}
			}
			if (bool_0)
			{
				((Control)this).set_Text(@class.method_1(LocalizationKeys.RenameBarDialogCaption));
			}
			else
			{
				((Control)this).set_Text(@class.method_1(((Control)this).get_Text()));
			}
		}
		manager = null;
	}

	private void txtName_Validating(object sender, CancelEventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)txtName).get_Text().Trim() == "")
		{
			DotNetBarManager manager = null;
			if (((Form)this).get_Owner() is frmCustomize)
			{
				manager = ((frmCustomize)(object)((Form)this).get_Owner()).method_10();
			}
			using (Class264 @class = new Class264(manager))
			{
				MessageBox.Show(@class.method_1(LocalizationKeys.BarEditDialogInvalidNameMessage));
			}
			manager = null;
			e.Cancel = true;
		}
	}
}
