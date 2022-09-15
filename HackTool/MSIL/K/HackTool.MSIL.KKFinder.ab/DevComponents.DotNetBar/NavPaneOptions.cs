using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class NavPaneOptions : Form
{
	internal Label labelListCaption;

	private NavigationBarContainer navigationBarContainer_0;

	private CheckedListBox lbButtons;

	internal Button cmdMoveUp;

	internal Button cmdMoveDown;

	internal Button cmdReset;

	internal Button cmdOK;

	internal Button cmdCancel;

	private Container container_0;

	public NavigationBarContainer NavBarContainer
	{
		get
		{
			return navigationBarContainer_0;
		}
		set
		{
			navigationBarContainer_0 = value;
			method_0();
		}
	}

	public NavPaneOptions()
	{
		InitializeComponent();
		((Control)cmdReset).set_Visible(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && container_0 != null)
		{
			container_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		((ObjectCollection)lbButtons.get_Items()).Clear();
		if (navigationBarContainer_0 == null)
		{
			return;
		}
		foreach (BaseItem subItem in navigationBarContainer_0.SubItems)
		{
			lbButtons.get_Items().Add((object)subItem, subItem.Visible);
		}
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		labelListCaption = new Label();
		lbButtons = new CheckedListBox();
		cmdMoveUp = new Button();
		cmdMoveDown = new Button();
		cmdReset = new Button();
		cmdOK = new Button();
		cmdCancel = new Button();
		((Control)this).SuspendLayout();
		((Control)labelListCaption).set_AutoSize(true);
		((Control)labelListCaption).set_Location(new Point(8, 8));
		((Control)labelListCaption).set_Name("labelListCaption");
		((Control)labelListCaption).set_Size(new Size(144, 13));
		((Control)labelListCaption).set_TabIndex(0);
		((Control)labelListCaption).set_Text("Display &buttons in this order");
		((Control)lbButtons).set_Location(new Point(8, 32));
		((Control)lbButtons).set_Name("lbButtons");
		((Control)lbButtons).set_Size(new Size(210, 109));
		((Control)lbButtons).set_TabIndex(1);
		((ListBox)lbButtons).add_SelectedIndexChanged((EventHandler)lbButtons_SelectedIndexChanged);
		((ButtonBase)cmdMoveUp).set_FlatStyle((FlatStyle)3);
		((Control)cmdMoveUp).set_Location(new Point(224, 32));
		((Control)cmdMoveUp).set_Name("cmdMoveUp");
		((Control)cmdMoveUp).set_TabIndex(2);
		((Control)cmdMoveUp).set_Text("Move &Up");
		((Control)cmdMoveUp).add_Click((EventHandler)cmdMoveUp_Click);
		((ButtonBase)cmdMoveDown).set_FlatStyle((FlatStyle)3);
		((Control)cmdMoveDown).set_Location(new Point(224, 64));
		((Control)cmdMoveDown).set_Name("cmdMoveDown");
		((Control)cmdMoveDown).set_TabIndex(3);
		((Control)cmdMoveDown).set_Text("Move &Down");
		((Control)cmdMoveDown).add_Click((EventHandler)cmdMoveDown_Click);
		((ButtonBase)cmdReset).set_FlatStyle((FlatStyle)3);
		((Control)cmdReset).set_Location(new Point(224, 104));
		((Control)cmdReset).set_Name("cmdReset");
		((Control)cmdReset).set_TabIndex(4);
		((Control)cmdReset).set_Text("&Reset");
		((Control)cmdReset).add_Click((EventHandler)cmdReset_Click);
		cmdOK.set_DialogResult((DialogResult)1);
		((ButtonBase)cmdOK).set_FlatStyle((FlatStyle)3);
		((Control)cmdOK).set_Location(new Point(144, 152));
		((Control)cmdOK).set_Name("cmdOK");
		((Control)cmdOK).set_TabIndex(5);
		((Control)cmdOK).set_Text("OK");
		((Control)cmdOK).add_Click((EventHandler)cmdOK_Click);
		cmdCancel.set_DialogResult((DialogResult)2);
		((ButtonBase)cmdCancel).set_FlatStyle((FlatStyle)3);
		((Control)cmdCancel).set_Location(new Point(224, 152));
		((Control)cmdCancel).set_Name("cmdCancel");
		((Control)cmdCancel).set_TabIndex(6);
		((Control)cmdCancel).set_Text("Cancel");
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(304, 182));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[7]
		{
			(Control)cmdCancel,
			(Control)cmdOK,
			(Control)cmdReset,
			(Control)cmdMoveDown,
			(Control)cmdMoveUp,
			(Control)lbButtons,
			(Control)labelListCaption
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("NavPaneOptions");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Navigation Pane Options");
		((Control)this).ResumeLayout(false);
	}

	private void lbButtons_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)lbButtons).get_SelectedIndex() == 0)
		{
			((Control)cmdMoveUp).set_Enabled(false);
		}
		else
		{
			((Control)cmdMoveUp).set_Enabled(true);
		}
		if (((ListControl)lbButtons).get_SelectedIndex() == ((ObjectCollection)lbButtons.get_Items()).get_Count() - 1)
		{
			((Control)cmdMoveDown).set_Enabled(false);
		}
		else
		{
			((Control)cmdMoveDown).set_Enabled(true);
		}
	}

	private void cmdMoveUp_Click(object sender, EventArgs e)
	{
		if (((ListControl)lbButtons).get_SelectedIndex() >= 0)
		{
			BaseItem baseItem = ((ListBox)lbButtons).get_SelectedItem() as BaseItem;
			int selectedIndex = ((ListControl)lbButtons).get_SelectedIndex();
			((ObjectCollection)lbButtons.get_Items()).RemoveAt(selectedIndex);
			selectedIndex--;
			((ObjectCollection)lbButtons.get_Items()).Insert(selectedIndex, (object)baseItem);
			lbButtons.SetItemChecked(selectedIndex, baseItem.Visible);
			((ListControl)lbButtons).set_SelectedIndex(selectedIndex);
		}
	}

	private void cmdMoveDown_Click(object sender, EventArgs e)
	{
		if (((ListControl)lbButtons).get_SelectedIndex() >= 0)
		{
			BaseItem baseItem = ((ListBox)lbButtons).get_SelectedItem() as BaseItem;
			int selectedIndex = ((ListControl)lbButtons).get_SelectedIndex();
			((ObjectCollection)lbButtons.get_Items()).RemoveAt(selectedIndex);
			selectedIndex++;
			((ObjectCollection)lbButtons.get_Items()).Insert(selectedIndex, (object)baseItem);
			lbButtons.SetItemChecked(selectedIndex, baseItem.Visible);
			((ListControl)lbButtons).set_SelectedIndex(selectedIndex);
		}
	}

	private void cmdReset_Click(object sender, EventArgs e)
	{
	}

	private void cmdOK_Click(object sender, EventArgs e)
	{
		navigationBarContainer_0.SuspendLayout = true;
		navigationBarContainer_0.SubItems.method_2();
		for (int i = 0; i < ((ObjectCollection)lbButtons.get_Items()).get_Count(); i++)
		{
			BaseItem baseItem = ((ObjectCollection)lbButtons.get_Items()).get_Item(i) as BaseItem;
			baseItem.Visible = lbButtons.GetItemChecked(i);
			navigationBarContainer_0.SubItems.method_0(baseItem);
		}
		navigationBarContainer_0.SuspendLayout = false;
		if (navigationBarContainer_0.ContainerControl is BarBaseControl)
		{
			((BarBaseControl)navigationBarContainer_0.ContainerControl).RecalcLayout();
		}
	}
}
