using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Controls;

namespace DevComponents.DotNetBar.Ribbon;

public class QatCustomizePanel : UserControl
{
	public ItemPanel itemPanelCommands;

	public ItemPanel itemPanelQat;

	public ButtonX buttonAddToQat;

	public ButtonX buttonRemoveFromQat;

	public ComboBoxEx comboCategories;

	public Label labelCategories;

	public CheckBoxX checkQatBelowRibbon;

	private Hashtable hashtable_0 = new Hashtable();

	private bool bool_0;

	private IContainer icontainer_0;

	[Browsable(false)]
	[DefaultValue(false)]
	public bool DataChanged
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public QatCustomizePanel()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		itemPanelCommands = new ItemPanel();
		itemPanelQat = new ItemPanel();
		buttonAddToQat = new ButtonX();
		buttonRemoveFromQat = new ButtonX();
		comboCategories = new ComboBoxEx();
		labelCategories = new Label();
		checkQatBelowRibbon = new CheckBoxX();
		((Control)this).SuspendLayout();
		((Control)itemPanelCommands).set_Anchor((AnchorStyles)15);
		itemPanelCommands.AutoScroll = true;
		itemPanelCommands.BackgroundStyle.BackColor = Color.White;
		itemPanelCommands.BackgroundStyle.BorderBottom = eStyleBorderType.Solid;
		itemPanelCommands.BackgroundStyle.BorderBottomWidth = 1;
		itemPanelCommands.BackgroundStyle.BorderColor = Color.FromArgb(127, 157, 185);
		itemPanelCommands.BackgroundStyle.BorderLeft = eStyleBorderType.Solid;
		itemPanelCommands.BackgroundStyle.BorderLeftWidth = 1;
		itemPanelCommands.BackgroundStyle.BorderRight = eStyleBorderType.Solid;
		itemPanelCommands.BackgroundStyle.BorderRightWidth = 1;
		itemPanelCommands.BackgroundStyle.BorderTop = eStyleBorderType.Solid;
		itemPanelCommands.BackgroundStyle.BorderTopWidth = 1;
		itemPanelCommands.BackgroundStyle.PaddingBottom = 1;
		itemPanelCommands.BackgroundStyle.PaddingLeft = 1;
		itemPanelCommands.BackgroundStyle.PaddingRight = 1;
		itemPanelCommands.BackgroundStyle.PaddingTop = 1;
		itemPanelCommands.FadeEffect = false;
		itemPanelCommands.LayoutOrientation = eOrientation.Vertical;
		((Control)itemPanelCommands).set_Location(new Point(9, 46));
		((Control)itemPanelCommands).set_Name("itemPanelCommands");
		((Control)itemPanelCommands).set_Size(new Size(173, 257));
		((Control)itemPanelCommands).set_TabIndex(2);
		((Control)itemPanelCommands).set_Text("itemPanelCommands");
		((Control)itemPanelCommands).add_KeyUp(new KeyEventHandler(itemPanelQat_KeyUp));
		((Control)itemPanelQat).set_Anchor((AnchorStyles)11);
		itemPanelQat.AutoScroll = true;
		itemPanelQat.BackgroundStyle.BackColor = Color.White;
		itemPanelQat.BackgroundStyle.BorderBottom = eStyleBorderType.Solid;
		itemPanelQat.BackgroundStyle.BorderBottomWidth = 1;
		itemPanelQat.BackgroundStyle.BorderColor = Color.FromArgb(127, 157, 185);
		itemPanelQat.BackgroundStyle.BorderLeft = eStyleBorderType.Solid;
		itemPanelQat.BackgroundStyle.BorderLeftWidth = 1;
		itemPanelQat.BackgroundStyle.BorderRight = eStyleBorderType.Solid;
		itemPanelQat.BackgroundStyle.BorderRightWidth = 1;
		itemPanelQat.BackgroundStyle.BorderTop = eStyleBorderType.Solid;
		itemPanelQat.BackgroundStyle.BorderTopWidth = 1;
		itemPanelQat.BackgroundStyle.PaddingBottom = 1;
		itemPanelQat.BackgroundStyle.PaddingLeft = 1;
		itemPanelQat.BackgroundStyle.PaddingRight = 1;
		itemPanelQat.BackgroundStyle.PaddingTop = 1;
		itemPanelQat.EnableDragDrop = true;
		itemPanelQat.FadeEffect = false;
		itemPanelQat.LayoutOrientation = eOrientation.Vertical;
		((Control)itemPanelQat).set_Location(new Point(266, 46));
		((Control)itemPanelQat).set_Name("itemPanelQat");
		((Control)itemPanelQat).set_Size(new Size(173, 257));
		((Control)itemPanelQat).set_TabIndex(5);
		((Control)itemPanelQat).set_Text("itemPanelCommands");
		((Control)itemPanelQat).add_DragDrop(new DragEventHandler(itemPanelQat_DragDrop));
		itemPanelQat.UserCustomize += itemPanelQat_UserCustomize;
		((Control)itemPanelQat).add_KeyUp(new KeyEventHandler(itemPanelQat_KeyUp));
		((Control)buttonAddToQat).set_Anchor((AnchorStyles)9);
		buttonAddToQat.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)buttonAddToQat).set_Location(new Point(188, 126));
		((Control)buttonAddToQat).set_Name("buttonAddToQat");
		((Control)buttonAddToQat).set_Size(new Size(73, 21));
		((Control)buttonAddToQat).set_TabIndex(3);
		((Control)buttonAddToQat).set_Text("&Add >>");
		((Control)buttonAddToQat).add_Click((EventHandler)buttonAddToQat_Click);
		((Control)buttonRemoveFromQat).set_Anchor((AnchorStyles)9);
		buttonRemoveFromQat.ColorTable = eButtonColor.OrangeWithBackground;
		((Control)buttonRemoveFromQat).set_Location(new Point(188, 153));
		((Control)buttonRemoveFromQat).set_Name("buttonRemoveFromQat");
		((Control)buttonRemoveFromQat).set_Size(new Size(73, 21));
		((Control)buttonRemoveFromQat).set_TabIndex(4);
		((Control)buttonRemoveFromQat).set_Text("&Remove");
		((Control)buttonRemoveFromQat).add_Click((EventHandler)buttonRemoveFromQat_Click);
		((Control)comboCategories).set_Anchor((AnchorStyles)13);
		((ComboBox)comboCategories).set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboCategories).set_Location(new Point(9, 19));
		((Control)comboCategories).set_Name("comboCategories");
		((Control)comboCategories).set_Size(new Size(173, 21));
		((ComboBox)comboCategories).set_Sorted(true);
		((Control)comboCategories).set_TabIndex(1);
		((ComboBox)comboCategories).add_SelectedIndexChanged((EventHandler)comboCategories_SelectedIndexChanged);
		comboCategories.Style = eDotNetBarStyle.Office2007;
		((ComboBox)comboCategories).set_DrawMode((DrawMode)1);
		comboCategories.ThemeAware = false;
		((Control)labelCategories).set_AutoSize(true);
		((Control)labelCategories).set_BackColor(Color.Transparent);
		((Control)labelCategories).set_Location(new Point(6, 3));
		((Control)labelCategories).set_Name("labelCategories");
		((Control)labelCategories).set_Size(new Size(123, 13));
		((Control)labelCategories).set_TabIndex(0);
		((Control)labelCategories).set_Text("&Choose commands from:");
		((Control)checkQatBelowRibbon).set_Anchor((AnchorStyles)6);
		((Control)checkQatBelowRibbon).set_BackColor(Color.Transparent);
		((Control)checkQatBelowRibbon).set_Location(new Point(9, 311));
		((Control)checkQatBelowRibbon).set_Name("checkQatBelowRibbon");
		((Control)checkQatBelowRibbon).set_Size(new Size(280, 17));
		((Control)checkQatBelowRibbon).set_TabIndex(6);
		((Control)checkQatBelowRibbon).set_Text("&Place Quick Access Toolbar below the Ribbon");
		checkQatBelowRibbon.CheckedChangedEx += checkQatBelowRibbon_CheckedChangedEx;
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).get_Controls().Add((Control)(object)comboCategories);
		((Control)this).get_Controls().Add((Control)(object)checkQatBelowRibbon);
		((Control)this).get_Controls().Add((Control)(object)labelCategories);
		((Control)this).get_Controls().Add((Control)(object)buttonRemoveFromQat);
		((Control)this).get_Controls().Add((Control)(object)buttonAddToQat);
		((Control)this).get_Controls().Add((Control)(object)itemPanelQat);
		((Control)this).get_Controls().Add((Control)(object)itemPanelCommands);
		((Control)this).set_Name("QatCustomizePanel");
		((Control)this).set_Size(new Size(444, 334));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void itemPanelQat_KeyUp(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() != 38 && (int)e.get_KeyCode() != 40 && (int)e.get_KeyCode() != 37 && (int)e.get_KeyCode() != 39)
		{
			return;
		}
		ItemPanel itemPanel = sender as ItemPanel;
		foreach (BaseItem item in itemPanel.Items)
		{
			if (item is ButtonItem buttonItem && buttonItem.IsMouseOver && !buttonItem.Checked)
			{
				buttonItem.Checked = true;
				break;
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (((Control)this).get_BackColor() == Color.Transparent || ((Control)this).get_BackColor().A < byte.MaxValue)
		{
			((ScrollableControl)this).OnPaintBackground(e);
		}
		if (!(((Control)this).get_BackColor() == Color.Transparent))
		{
			Class50.smethod_23(e.get_Graphics(), ((Control)this).get_ClientRectangle(), ((Control)this).get_BackColor());
		}
	}

	public void LoadItems(RibbonControl rc)
	{
		hashtable_0.Clear();
		itemPanelCommands.Items.Clear();
		itemPanelQat.Items.Clear();
		method_10(rc);
		if (rc.CategorizeMode == eCategorizeMode.Categories)
		{
			method_0(rc);
		}
		else
		{
			method_5(rc);
		}
		method_14();
		checkQatBelowRibbon.Checked = rc.QatPositionedBelowRibbon;
		((Control)checkQatBelowRibbon).set_Visible(rc.EnableQatPlacement);
		bool_0 = false;
	}

	private void method_0(RibbonControl ribbonControl_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)ribbonControl_0).get_Controls())
		{
			Control control_ = item;
			method_1(control_);
		}
		BaseItem baseItem = ribbonControl_0.method_47();
		if (baseItem != null)
		{
			method_3(baseItem);
		}
	}

	private void method_1(Control control_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (control_0 is RibbonBar)
		{
			method_2(control_0 as RibbonBar);
		}
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control control_ = item;
			method_1(control_);
		}
	}

	private void method_2(RibbonBar ribbonBar_0)
	{
		foreach (BaseItem item in ribbonBar_0.Items)
		{
			method_3(item);
		}
	}

	private void method_3(BaseItem baseItem_0)
	{
		if (method_13(baseItem_0))
		{
			string key = method_4(baseItem_0);
			ArrayList arrayList = hashtable_0[key] as ArrayList;
			if (arrayList == null)
			{
				arrayList = new ArrayList();
				hashtable_0.Add(key, arrayList);
			}
			arrayList.Add(method_12(baseItem_0));
		}
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			method_3(subItem);
		}
	}

	private string method_4(BaseItem baseItem_0)
	{
		if (baseItem_0.Category != "")
		{
			return baseItem_0.Category;
		}
		return "Unassigned";
	}

	private void method_5(RibbonControl ribbonControl_0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		foreach (Control item in (ArrangedElementCollection)((Control)ribbonControl_0).get_Controls())
		{
			Control control_ = item;
			method_6(control_);
		}
		BaseItem baseItem = ribbonControl_0.method_47();
		if (baseItem != null)
		{
			method_9(baseItem, method_8(baseItem.Text));
		}
	}

	private void method_6(Control control_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (control_0 is RibbonBar)
		{
			method_7(control_0 as RibbonBar);
		}
		foreach (Control item in (ArrangedElementCollection)control_0.get_Controls())
		{
			Control control_ = item;
			method_6(control_);
		}
	}

	private void method_7(RibbonBar ribbonBar_0)
	{
		foreach (BaseItem item in ribbonBar_0.Items)
		{
			method_9(item, method_8(((Control)ribbonBar_0).get_Text()));
		}
	}

	private string method_8(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(string_0.Length);
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == '&')
			{
				if (i + 1 < string_0.Length && string_0[i + 1] == '&')
				{
					stringBuilder.Append(string_0[i]);
				}
			}
			else
			{
				stringBuilder.Append(string_0[i]);
			}
		}
		return stringBuilder.ToString();
	}

	private void method_9(BaseItem baseItem_0, string string_0)
	{
		if (method_13(baseItem_0))
		{
			ArrayList arrayList = hashtable_0[string_0] as ArrayList;
			if (arrayList == null)
			{
				arrayList = new ArrayList();
				hashtable_0.Add(string_0, arrayList);
			}
			arrayList.Add(method_12(baseItem_0));
		}
		foreach (BaseItem subItem in baseItem_0.SubItems)
		{
			method_9(subItem, string_0);
		}
	}

	private void method_10(RibbonControl ribbonControl_0)
	{
		int count = ribbonControl_0.QuickToolbarItems.Count;
		int num = 0;
		BaseItem baseItem = ribbonControl_0.method_47();
		if (baseItem != null)
		{
			num = ribbonControl_0.QuickToolbarItems.IndexOf(baseItem) + 1;
		}
		for (int i = num; i < count; i++)
		{
			BaseItem baseItem2 = ribbonControl_0.QuickToolbarItems[i];
			if (!method_11(baseItem2) && baseItem2.CanCustomize)
			{
				BaseItem baseItem3 = method_12(baseItem2);
				baseItem3.Tag = null;
				itemPanelQat.Items.Add(baseItem3);
			}
		}
	}

	private bool method_11(BaseItem baseItem_0)
	{
		if (!baseItem_0.SystemItem && !(baseItem_0 is ItemContainer) && !(baseItem_0 is CustomizeItem) && !(baseItem_0 is SystemCaptionItem))
		{
			return false;
		}
		return true;
	}

	private ButtonItem method_12(BaseItem baseItem_0)
	{
		ButtonItem buttonItem = new ButtonItem(baseItem_0.Name);
		buttonItem.Text = baseItem_0.Text;
		buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
		buttonItem.ImagePaddingVertical = 4;
		buttonItem.OptionGroup = "sys";
		buttonItem.GlobalItem = false;
		if (buttonItem.Text == "")
		{
			buttonItem.Text = "Unassigned";
		}
		buttonItem.Tag = baseItem_0;
		if (baseItem_0 is ButtonItem)
		{
			ButtonItem buttonItem2 = baseItem_0 as ButtonItem;
			if (buttonItem2.ImageSmall != null)
			{
				buttonItem.Image = buttonItem2.ImageSmall;
				if (buttonItem2.ImageSmall.get_Width() != 16 || buttonItem2.ImageSmall.get_Height() != 16)
				{
					buttonItem.ImageFixedSize = new Size(16, 16);
				}
			}
			else
			{
				Class271 @class = buttonItem2.method_23(Enum15.const_0);
				if (@class != null)
				{
					if (@class.Boolean_0)
					{
						buttonItem.Icon = @class.Icon_0;
					}
					else
					{
						buttonItem.Image = @class.Image_0;
					}
					buttonItem.ImageFixedSize = new Size(16, 16);
				}
			}
		}
		else if (baseItem_0 is ComboBoxItem || baseItem_0 is TextBoxItem || baseItem_0 is ControlContainerItem)
		{
			buttonItem.ImagePosition = eImagePosition.Right;
			buttonItem.Image = (Image)(object)Class109.smethod_67("SystemImages.QatCustomizeItemCombo.png");
		}
		return buttonItem;
	}

	private bool method_13(BaseItem baseItem_0)
	{
		if (baseItem_0 == null)
		{
			return false;
		}
		if (baseItem_0.CanCustomize && !baseItem_0.SystemItem && !(baseItem_0.Name == "tempColorPickerItem"))
		{
			if (!(baseItem_0 is ItemContainer) && !(baseItem_0 is GenericItemContainer))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void method_14()
	{
		comboCategories.Items.Clear();
		foreach (string key in hashtable_0.Keys)
		{
			comboCategories.Items.Add((object)key);
		}
		if (comboCategories.Items.get_Count() > 0)
		{
			((ListControl)comboCategories).set_SelectedIndex(0);
		}
	}

	private void comboCategories_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)comboCategories).get_SelectedIndex() < 0)
		{
			itemPanelCommands.Items.Clear();
			itemPanelCommands.RecalcLayout();
			return;
		}
		string key = comboCategories.Items.get_Item(((ListControl)comboCategories).get_SelectedIndex()).ToString();
		ArrayList arrayList = hashtable_0[key] as ArrayList;
		itemPanelCommands.Items.Clear();
		foreach (BaseItem item in arrayList)
		{
			itemPanelCommands.Items.Add(item);
		}
		itemPanelCommands.RecalcLayout();
	}

	private void buttonAddToQat_Click(object sender, EventArgs e)
	{
		ButtonItem @checked = itemPanelCommands.GetChecked();
		if (@checked != null && !itemPanelQat.Items.Contains(@checked.Name))
		{
			ButtonItem buttonItem = @checked.Copy() as ButtonItem;
			buttonItem.Checked = false;
			itemPanelQat.Items.Add(buttonItem);
			buttonItem.Checked = true;
			itemPanelQat.RecalcLayout();
			bool_0 = true;
			int num = itemPanelCommands.Items.IndexOf(@checked) + 1;
			if (num != itemPanelCommands.Items.Count && itemPanelCommands.Items[num] is ButtonItem buttonItem2)
			{
				buttonItem2.Checked = true;
				itemPanelCommands.EnsureVisible(buttonItem2);
			}
		}
	}

	private void buttonRemoveFromQat_Click(object sender, EventArgs e)
	{
		ButtonItem @checked = itemPanelQat.GetChecked();
		if (@checked == null)
		{
			return;
		}
		int num = itemPanelQat.Items.IndexOf(@checked);
		itemPanelQat.Items.Remove(@checked);
		if (num >= 0 && itemPanelQat.Items.Count > 0)
		{
			if (num + 1 >= itemPanelQat.Items.Count)
			{
				num = itemPanelQat.Items.Count - 1;
			}
			if (itemPanelQat.Items[num] is ButtonItem buttonItem)
			{
				buttonItem.Checked = true;
				itemPanelQat.EnsureVisible(buttonItem);
			}
		}
		itemPanelQat.RecalcLayout();
		bool_0 = true;
	}

	private void itemPanelQat_DragDrop(object sender, DragEventArgs e)
	{
		bool_0 = true;
	}

	private void itemPanelQat_UserCustomize(object sender, EventArgs e)
	{
		bool_0 = true;
	}

	private void checkQatBelowRibbon_CheckedChangedEx(object sender, CheckBoxXChangeEventArgs e)
	{
		bool_0 = true;
	}
}
