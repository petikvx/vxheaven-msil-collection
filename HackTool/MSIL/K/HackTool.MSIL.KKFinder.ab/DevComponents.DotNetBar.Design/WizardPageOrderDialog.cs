using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Design;

[ToolboxItem(false)]
internal class WizardPageOrderDialog : Form
{
	private IContainer icontainer_0;

	private ListView listView1;

	private Button buttonOK;

	private Button buttonCancel;

	private Bar bar1;

	private ButtonItem buttonPageUp;

	private ButtonItem buttonPageDown;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private Wizard wizard_0;

	private ColumnHeader columnHeader_3;

	internal bool bool_0;

	internal string String_0
	{
		get
		{
			if (listView1.get_SelectedItems().get_Count() == 1)
			{
				return listView1.get_SelectedItems().get_Item(0).get_Text();
			}
			return "";
		}
	}

	internal string[] String_1
	{
		get
		{
			string[] array = new string[listView1.get_Items().get_Count()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = listView1.get_Items().get_Item(i).get_Text();
			}
			return array;
		}
	}

	public WizardPageOrderDialog()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		listView1 = new ListView();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		buttonOK = new Button();
		buttonCancel = new Button();
		bar1 = new Bar();
		buttonPageUp = new ButtonItem();
		buttonPageDown = new ButtonItem();
		columnHeader_3 = new ColumnHeader();
		((ISupportInitialize)bar1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)listView1).set_Anchor((AnchorStyles)15);
		listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[4] { columnHeader_0, columnHeader_3, columnHeader_1, columnHeader_2 });
		listView1.set_FullRowSelect(true);
		listView1.set_HeaderStyle((ColumnHeaderStyle)1);
		listView1.set_HideSelection(false);
		((Control)listView1).set_Location(new Point(12, 31));
		listView1.set_MultiSelect(false);
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(488, 233));
		((Control)listView1).set_TabIndex(0);
		listView1.set_View((View)1);
		((Control)listView1).add_DoubleClick((EventHandler)listView1_DoubleClick);
		((Control)listView1).add_Resize((EventHandler)listView1_Resize);
		columnHeader_0.set_Text("Name");
		columnHeader_0.set_Width(100);
		columnHeader_1.set_Text("Page Title");
		columnHeader_1.set_Width(150);
		columnHeader_2.set_Text("Page Description");
		columnHeader_2.set_Width(187);
		((Control)buttonOK).set_Anchor((AnchorStyles)10);
		buttonOK.set_DialogResult((DialogResult)1);
		((Control)buttonOK).set_Location(new Point(352, 270));
		((Control)buttonOK).set_Name("buttonOK");
		((Control)buttonOK).set_Size(new Size(73, 25));
		((Control)buttonOK).set_TabIndex(1);
		((Control)buttonOK).set_Text("OK");
		((Control)buttonCancel).set_Anchor((AnchorStyles)10);
		buttonCancel.set_DialogResult((DialogResult)2);
		((Control)buttonCancel).set_Location(new Point(427, 270));
		((Control)buttonCancel).set_Name("buttonCancel");
		((Control)buttonCancel).set_Size(new Size(73, 25));
		((Control)buttonCancel).set_TabIndex(2);
		((Control)buttonCancel).set_Text("Cancel");
		bar1.BackgroundImageAlpha = byte.MaxValue;
		((Control)bar1).set_Dock((DockStyle)1);
		bar1.Items.AddRange(new BaseItem[2] { buttonPageUp, buttonPageDown });
		bar1.Location = new Point(0, 0);
		bar1.Name = "bar1";
		bar1.Size = new Size(512, 25);
		bar1.Stretch = true;
		bar1.Style = eDotNetBarStyle.VS2005;
		bar1.TabIndex = 3;
		bar1.TabStop = false;
		((Control)bar1).set_Text("bar1");
		buttonPageUp.Name = "buttonPageUp";
		buttonPageUp.Shortcuts.Add(eShortcut.CtrlUp);
		buttonPageUp.Text = "Move Page Up";
		buttonPageUp.Tooltip = "Change selected page order by moving it up";
		buttonPageUp.Click += buttonPageUp_Click;
		buttonPageDown.Name = "buttonPageDown";
		buttonPageDown.Shortcuts.Add(eShortcut.CtrlDown);
		buttonPageDown.Text = "Move Page Down";
		buttonPageDown.Tooltip = "Change selected page order by moving it down";
		buttonPageDown.Click += buttonPageDown_Click;
		columnHeader_3.set_Text("Interior");
		columnHeader_3.set_Width(47);
		((Form)this).set_AcceptButton((IButtonControl)(object)buttonOK);
		((Form)this).set_CancelButton((IButtonControl)(object)buttonCancel);
		((Form)this).set_ClientSize(new Size(512, 303));
		((Control)this).get_Controls().Add((Control)(object)bar1);
		((Control)this).get_Controls().Add((Control)(object)buttonCancel);
		((Control)this).get_Controls().Add((Control)(object)buttonOK);
		((Control)this).get_Controls().Add((Control)(object)listView1);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("WizardPageOrderDialog");
		((Control)this).set_Text("Wizard Pages");
		((ISupportInitialize)bar1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void listView1_DoubleClick(object sender, EventArgs e)
	{
		if (listView1.get_SelectedItems().get_Count() == 1)
		{
			((Form)this).set_DialogResult((DialogResult)1);
			((Form)this).Close();
		}
	}

	public void method_0(Wizard wizard_1)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		wizard_0 = wizard_1;
		foreach (WizardPage wizardPage in wizard_0.WizardPages)
		{
			ListViewItem val = new ListViewItem(new string[4]
			{
				((Control)wizardPage).get_Name(),
				wizardPage.InteriorPage ? "Yes" : "No",
				wizardPage.PageTitle,
				wizardPage.PageDescription
			});
			listView1.get_Items().Add(val);
		}
	}

	private void buttonPageUp_Click(object sender, EventArgs e)
	{
		if (listView1.get_SelectedItems().get_Count() == 1)
		{
			int index = listView1.get_SelectedItems().get_Item(0).get_Index();
			if (index != 0)
			{
				ListViewItem val = listView1.get_SelectedItems().get_Item(0);
				listView1.get_Items().Remove(val);
				listView1.get_Items().Insert(index - 1, val);
				bool_0 = true;
			}
		}
	}

	private void buttonPageDown_Click(object sender, EventArgs e)
	{
		if (listView1.get_SelectedItems().get_Count() == 1 && listView1.get_SelectedItems().get_Count() == 1)
		{
			int index = listView1.get_SelectedItems().get_Item(0).get_Index();
			if (index != listView1.get_Items().get_Count() - 1)
			{
				ListViewItem val = listView1.get_SelectedItems().get_Item(0);
				listView1.get_Items().Remove(val);
				listView1.get_Items().Insert(index + 1, val);
				bool_0 = false;
			}
		}
	}

	private void listView1_Resize(object sender, EventArgs e)
	{
		int num = ((Control)listView1).get_Width() - columnHeader_0.get_Width() - columnHeader_3.get_Width() - columnHeader_1.get_Width() - 6;
		if (num > 64)
		{
			columnHeader_2.set_Width(num);
		}
	}
}
