using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;

namespace DevComponents.DotNetBar;

[ComVisible(false)]
[ToolboxItem(false)]
public class frmCustomize : Form
{
	private TabControl tabCtrl;

	private Label label1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private TabPage tabPage1;

	private Button cmdNew;

	private Button cmdDelete;

	private Button cmdRename;

	private Button cmdReset;

	private CheckedListBox lstBars;

	private DotNetBarManager dotNetBarManager_0;

	private Button cmdKeyboard;

	private Button cmdClose;

	private Label label2;

	private Label label3;

	private Label label4;

	private ListBox lstCategories;

	private Class83 lstCommands;

	private bool bool_0;

	private Cursor cursor_0;

	private Cursor cursor_1;

	private Cursor cursor_2;

	private IDesignTimeProvider idesignTimeProvider_0;

	private int int_0;

	private bool bool_1;

	private bool bool_2;

	private Point point_0;

	public BaseItem DragItem;

	private BaseItem baseItem_0;

	private ButtonItem buttonItem_0;

	private Label label5;

	private CheckBox chkShowFullMenus;

	private CheckBox chkFullAfterDelay;

	private Label label6;

	private Button button1;

	private CheckBox chkShowScreenTips;

	private CheckBox chkTipsShowShortcuts;

	private Label label7;

	private ComboItem comboItem_0;

	private ComboItem comboItem_1;

	private ComboItem comboItem_2;

	private ComboItem comboItem_3;

	private ComboItem comboItem_4;

	private ComboBoxEx cboAnimations;

	private ComboItem comboItem_5;

	private Timer timer_0;

	private Container container_0;

	private bool bool_3;

	public bool DragInProgress => bool_0;

	public frmCustomize(DotNetBarManager ctrl)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		InitializeComponent();
		dotNetBarManager_0 = ctrl;
		((Form)this).set_StartPosition((FormStartPosition)1);
		bool_0 = false;
		try
		{
			cursor_0 = new Cursor(typeof(DotNetBarManager), "DRAGMOVE.CUR");
			cursor_1 = new Cursor(typeof(DotNetBarManager), "DRAGCOPY.CUR");
			cursor_2 = new Cursor(typeof(DotNetBarManager), "DRAGNONE.CUR");
		}
		catch (Exception)
		{
			cursor_0 = null;
			cursor_1 = null;
			cursor_2 = null;
		}
		idesignTimeProvider_0 = null;
		bool_2 = false;
		baseItem_0 = null;
		using (Class264 @class = new Class264(dotNetBarManager_0))
		{
			((Control)cmdNew).set_Text(@class.method_1(((Control)cmdNew).get_Text()));
			((Control)tabPage1).set_Text(@class.method_1(((Control)tabPage1).get_Text()));
			((Control)cmdReset).set_Text(@class.method_1(((Control)cmdReset).get_Text()));
			((Control)cmdRename).set_Text(@class.method_1(((Control)cmdRename).get_Text()));
			((Control)cmdDelete).set_Text(@class.method_1(((Control)cmdDelete).get_Text()));
			((Control)label1).set_Text(@class.method_1(((Control)label1).get_Text()));
			((Control)tabPage2).set_Text(@class.method_1(((Control)tabPage2).get_Text()));
			((Control)label4).set_Text(@class.method_1(((Control)label4).get_Text()));
			((Control)label3).set_Text(@class.method_1(((Control)label3).get_Text()));
			((Control)label2).set_Text(@class.method_1(((Control)label2).get_Text()));
			((Control)tabPage3).set_Text(@class.method_1(((Control)tabPage3).get_Text()));
			((Control)cmdKeyboard).set_Text(@class.method_1(((Control)cmdKeyboard).get_Text()));
			((Control)cmdClose).set_Text(@class.method_1(((Control)cmdClose).get_Text()));
			((Control)label5).set_Text(@class.method_1(((Control)label5).get_Text()));
			((Control)chkShowFullMenus).set_Text(@class.method_1(((Control)chkShowFullMenus).get_Text()));
			((Control)chkFullAfterDelay).set_Text(@class.method_1(((Control)chkFullAfterDelay).get_Text()));
			((Control)label6).set_Text(@class.method_1(((Control)label6).get_Text()));
			((Control)button1).set_Text(@class.method_1(((Control)button1).get_Text()));
			((Control)chkShowScreenTips).set_Text(@class.method_1(((Control)chkShowScreenTips).get_Text()));
			((Control)chkTipsShowShortcuts).set_Text(@class.method_1(((Control)chkTipsShowShortcuts).get_Text()));
			((Control)label7).set_Text(@class.method_1(((Control)label7).get_Text()));
			comboItem_0.Text = @class.method_1(comboItem_0.Text);
			comboItem_1.Text = @class.method_1(comboItem_1.Text);
			comboItem_2.Text = @class.method_1(comboItem_2.Text);
			comboItem_3.Text = @class.method_1(comboItem_3.Text);
			comboItem_4.Text = @class.method_1(comboItem_4.Text);
			comboItem_5.Text = @class.method_1(comboItem_5.Text);
			((Control)this).set_Text(@class.method_1(((Control)this).get_Text()));
		}
		((Control)cmdReset).set_Visible(dotNetBarManager_0.ShowResetButton);
		((Control)cmdKeyboard).set_Visible(false);
		((Form)this).set_KeyPreview(true);
		if (!Class109.Boolean_1)
		{
			((Control)cboAnimations).set_Visible(false);
			((Control)label7).set_Visible(false);
		}
		lstCommands.eDotNetBarStyle_0 = dotNetBarManager_0.Style;
	}

	protected override void Dispose(bool disposing)
	{
		if (buttonItem_0 != null)
		{
			buttonItem_0.Dispose();
			buttonItem_0 = null;
		}
		dotNetBarManager_0 = null;
		if (cursor_0 != (Cursor)null)
		{
			cursor_0.Dispose();
		}
		if (cursor_1 != (Cursor)null)
		{
			cursor_1.Dispose();
		}
		if (cursor_2 != (Cursor)null)
		{
			cursor_2.Dispose();
		}
		cursor_0 = null;
		cursor_1 = null;
		cursor_2 = null;
		if (container_0 != null)
		{
			container_0.Dispose();
		}
		container_0 = null;
		((Form)this).Dispose(disposing);
	}

	public void RefreshBars()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		bool_3 = true;
		try
		{
			CheckState val = (CheckState)1;
			((ObjectCollection)lstBars.get_Items()).Clear();
			foreach (Bar bar in dotNetBarManager_0.Bars)
			{
				if ((!bar.CanHide && !bar.CanCustomize && bar.LayoutType == eLayoutType.Toolbar) || bar.LayoutType != 0)
				{
					bar.SetDesignMode(b: true);
					bar.RecalcLayout();
					continue;
				}
				val = ((!bar.Visible) ? ((CheckState)0) : ((CheckState)1));
				lstBars.get_Items().Add((object)bar, val);
				bar.SetDesignMode(b: true);
				bar.RecalcLayout();
			}
		}
		finally
		{
			bool_3 = false;
		}
	}

	public void RefreshCategories()
	{
		Hashtable hashtable = new Hashtable();
		lstCategories.get_Items().Clear();
		lstCategories.set_Sorted(true);
		for (int i = 0; i < dotNetBarManager_0.Items.Count; i++)
		{
			BaseItem baseItem = dotNetBarManager_0.Items[i];
			if (baseItem.Category != "" && !hashtable.ContainsKey(baseItem.Category))
			{
				hashtable.Add(baseItem.Category, baseItem.Category);
			}
		}
		foreach (string value in hashtable.Values)
		{
			lstCategories.get_Items().Add((object)value);
		}
	}

	protected void BarsCheck(object sender, ItemCheckEventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		if (bool_3 || !(((ObjectCollection)lstBars.get_Items()).get_Item(e.get_Index()) is Bar bar))
		{
			return;
		}
		if (!bar.CanHide && bar.Visible)
		{
			e.set_NewValue((CheckState)1);
			return;
		}
		if ((int)e.get_NewValue() == 1)
		{
			if (!bar.Visible)
			{
				bar.method_97();
			}
		}
		else if (bar.Visible)
		{
			bar.method_95();
		}
		bar.method_65();
		((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)bar, new EventArgs());
		((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)bar, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.BarVisibilityChanged));
	}

	protected override void OnLoad(EventArgs e)
	{
		((Form)this).OnLoad(e);
		RefreshBars();
		RefreshCategories();
		chkShowFullMenus.set_Checked(dotNetBarManager_0.AlwaysShowFullMenus);
		chkFullAfterDelay.set_Checked(dotNetBarManager_0.ShowFullMenusOnHover);
		chkShowScreenTips.set_Checked(dotNetBarManager_0.ShowToolTips);
		chkTipsShowShortcuts.set_Checked(dotNetBarManager_0.ShowShortcutKeysInToolTips);
		switch (dotNetBarManager_0.PopupAnimation)
		{
		case ePopupAnimation.None:
			((ComboBox)cboAnimations).set_SelectedItem((object)comboItem_0);
			break;
		case ePopupAnimation.Slide:
			((ComboBox)cboAnimations).set_SelectedItem((object)comboItem_3);
			break;
		case ePopupAnimation.Unfold:
			((ComboBox)cboAnimations).set_SelectedItem((object)comboItem_2);
			break;
		case ePopupAnimation.ManagerControlled:
			break;
		case ePopupAnimation.Fade:
			((ComboBox)cboAnimations).set_SelectedItem((object)comboItem_4);
			break;
		case ePopupAnimation.Random:
			((ComboBox)cboAnimations).set_SelectedItem((object)comboItem_1);
			break;
		case ePopupAnimation.SystemDefault:
			((ComboBox)cboAnimations).set_SelectedItem((object)comboItem_5);
			break;
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		IOwner owner = dotNetBarManager_0;
		owner.SetFocusItem(null);
		foreach (Bar bar in dotNetBarManager_0.Bars)
		{
			bar.SetDesignMode(b: false);
			bar.RecalcLayout();
		}
		dotNetBarManager_0.AlwaysShowFullMenus = chkShowFullMenus.get_Checked();
		dotNetBarManager_0.ShowFullMenusOnHover = chkFullAfterDelay.get_Checked();
		dotNetBarManager_0.ShowToolTips = chkShowScreenTips.get_Checked();
		dotNetBarManager_0.ShowShortcutKeysInToolTips = chkTipsShowShortcuts.get_Checked();
		if (((ComboBox)cboAnimations).get_SelectedItem() == comboItem_4)
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.Fade;
		}
		else if (((ComboBox)cboAnimations).get_SelectedItem() == comboItem_0)
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.None;
		}
		else if (((ComboBox)cboAnimations).get_SelectedItem() == comboItem_1)
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.Random;
		}
		else if (((ComboBox)cboAnimations).get_SelectedItem() == comboItem_3)
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.Slide;
		}
		else if (((ComboBox)cboAnimations).get_SelectedItem() == comboItem_5)
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.SystemDefault;
		}
		else if (((ComboBox)cboAnimations).get_SelectedItem() == comboItem_2)
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.Unfold;
		}
		else
		{
			dotNetBarManager_0.PopupAnimation = ePopupAnimation.SystemDefault;
		}
		dotNetBarManager_0.CustomizeClosing();
		((Form)this).OnClosing(e);
	}

	protected override void OnClosed(EventArgs e)
	{
		((Form)this).OnClosed(e);
		if (dotNetBarManager_0 != null && dotNetBarManager_0.ParentForm != null)
		{
			((Control)dotNetBarManager_0.ParentForm).BringToFront();
		}
	}

	protected void Close_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	protected void CatSelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)lstCategories).get_SelectedIndex() < 0)
		{
			((ListBox)lstCommands).get_Items().Clear();
			return;
		}
		string text = lstCategories.get_Items().get_Item(((ListControl)lstCategories).get_SelectedIndex()) as string;
		ArrayList arrayList = new ArrayList();
		BaseItem baseItem = null;
		for (int i = 0; i < dotNetBarManager_0.Items.Count; i++)
		{
			BaseItem baseItem2 = dotNetBarManager_0.Items[i];
			if (!(baseItem2.Category != text) && !baseItem2.SystemItem)
			{
				baseItem = baseItem2.Copy();
				baseItem.SetDesignMode(b: true);
				baseItem.method_6(dotNetBarManager_0);
				arrayList.Add(baseItem);
			}
		}
		lstCommands.method_1(arrayList);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
	}

	private void method_0(Point point_1)
	{
		if (!bool_0)
		{
			return;
		}
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_1);
			idesignTimeProvider_0 = null;
		}
		foreach (Bar bar in dotNetBarManager_0.Bars)
		{
			if (!bar.Visible || !bar.AcceptDropItems)
			{
				continue;
			}
			InsertPosition insertPosition = ((IDesignTimeProvider)bar.ItemsContainer).GetInsertPosition(point_1, DragItem);
			if (insertPosition == null)
			{
				if (cursor_2 != (Cursor)null)
				{
					Cursor.set_Current(cursor_2);
				}
				else
				{
					Cursor.set_Current(Cursors.get_No());
				}
				continue;
			}
			if (insertPosition.TargetProvider == null)
			{
				if (cursor_2 != (Cursor)null)
				{
					Cursor.set_Current(cursor_2);
				}
				else
				{
					Cursor.set_Current(Cursors.get_No());
				}
				break;
			}
			insertPosition.TargetProvider.DrawReversibleMarker(insertPosition.Position, insertPosition.Before);
			int_0 = insertPosition.Position;
			bool_1 = insertPosition.Before;
			idesignTimeProvider_0 = insertPosition.TargetProvider;
			if (bool_2)
			{
				if (cursor_1 != (Cursor)null)
				{
					Cursor.set_Current(cursor_1);
				}
				else
				{
					Cursor.set_Current(Cursors.get_Hand());
				}
			}
			else if (cursor_0 != (Cursor)null)
			{
				Cursor.set_Current(cursor_0);
			}
			else
			{
				Cursor.set_Current(Cursors.get_Hand());
			}
			break;
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
	}

	private void method_1(Point point_1)
	{
		if (!bool_0)
		{
			return;
		}
		method_9();
		DragItem.InternalMouseLeave();
		if (idesignTimeProvider_0 != null)
		{
			idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_1);
			BaseItem parent = DragItem.Parent;
			if (parent != null)
			{
				if (parent == (BaseItem)idesignTimeProvider_0 && int_0 > 0)
				{
					if (parent.SubItems.IndexOf(DragItem) < int_0)
					{
						int_0--;
					}
				}
				else
				{
					Bar bar = parent.ContainerControl as Bar;
					if (bar != null && DragItem.String_0 == "")
					{
						DragItem.String_0 = bar.Name;
					}
					else if (bar != null && bar.Name == DragItem.String_0)
					{
						DragItem.String_0 = "";
					}
				}
				if (DragItem.Int32_0 < 0)
				{
					if (parent == (BaseItem)idesignTimeProvider_0)
					{
						if (parent.SubItems.IndexOf(DragItem) != int_0)
						{
							DragItem.Int32_0 = parent.SubItems.IndexOf(DragItem);
						}
					}
					else
					{
						DragItem.Int32_0 = parent.SubItems.IndexOf(DragItem);
					}
				}
				else if (parent == (BaseItem)idesignTimeProvider_0 && int_0 == DragItem.Int32_0)
				{
					DragItem.Int32_0 = -1;
				}
				parent.SubItems.Remove(DragItem);
				object containerControl = parent.ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (val is Bar)
				{
					((Bar)(object)val).RecalcLayout();
				}
				else if (val is MenuPanel)
				{
					((MenuPanel)(object)val).RecalcSize();
				}
			}
			else
			{
				DragItem.Int32_0 = 0;
			}
			idesignTimeProvider_0.InsertItemAt(DragItem, int_0, bool_1);
			idesignTimeProvider_0 = null;
			((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)DragItem, new EventArgs());
			((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)DragItem, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemMoved));
		}
		else if (DragItem.Parent != null)
		{
			if (dotNetBarManager_0.ParentForm != null && !((Control)dotNetBarManager_0.ParentForm).get_Bounds().Contains(point_1))
			{
				BaseItem parent2 = DragItem.Parent;
				parent2.SubItems.Remove(DragItem);
				object containerControl2 = parent2.ContainerControl;
				Control val2 = (Control)((containerControl2 is Control) ? containerControl2 : null);
				if (val2 is Bar)
				{
					((Bar)(object)val2).RecalcLayout();
				}
				else if (val2 is MenuPanel)
				{
					((MenuPanel)(object)val2).RecalcSize();
				}
				((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)DragItem, new EventArgs());
				((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)DragItem, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemDeleted));
			}
		}
		bool_0 = false;
		Cursor.set_Current(Cursors.get_Default());
		((Control)this).set_Capture(false);
		IOwner owner = dotNetBarManager_0;
		owner.SetFocusItem(null);
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 27 && bool_0)
		{
			method_2();
			return true;
		}
		return ((Form)this).ProcessDialogKey(keyData);
	}

	internal void method_2()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		if (bool_0)
		{
			method_9();
			if (idesignTimeProvider_0 != null)
			{
				idesignTimeProvider_0.DrawReversibleMarker(int_0, bool_1);
			}
			bool_0 = false;
			Cursor.set_Current(Cursors.get_Default());
			((Control)this).set_Capture(false);
			IOwner owner = dotNetBarManager_0;
			owner.SetFocusItem(null);
			if (DragItem != null)
			{
				DragItem.InternalMouseUp(new MouseEventArgs((MouseButtons)1048576, 1, DragItem.LeftInternal + 1, DragItem.TopInternal + 1, 0));
				DragItem.Refresh();
			}
			DragItem = null;
		}
	}

	protected void Commands_OnMouseDown(object sender, MouseEventArgs e)
	{
		point_0 = new Point(e.get_X(), e.get_Y());
	}

	protected void Commands_OnMouseMove(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && (Math.Abs(point_0.X - e.get_X()) > 2 || Math.Abs(point_0.Y - e.get_Y()) > 2) && !bool_0 && ((ListControl)lstCommands).get_SelectedIndex() >= 0 && ((ListBox)lstCommands).get_Items().get_Item(((ListControl)lstCommands).get_SelectedIndex()) is BaseItem baseItem)
		{
			DragItem = baseItem.Copy();
			DragItem.SetDesignMode(b: true);
			bool_0 = true;
			bool_2 = true;
			((Control)this).set_Capture(true);
			method_8();
			if (cursor_2 != (Cursor)null)
			{
				Cursor.set_Current(cursor_2);
			}
			else
			{
				Cursor.set_Current(Cursors.get_No());
			}
		}
	}

	public void DesignTimeContextMenu(BaseItem objItem)
	{
		using Class264 @class = new Class264(dotNetBarManager_0);
		baseItem_0 = objItem;
		if (buttonItem_0 != null)
		{
			buttonItem_0.Dispose();
		}
		buttonItem_0 = new ButtonItem("syscustomizepopupmenu");
		buttonItem_0.Style = objItem.Style;
		ButtonItem buttonItem = new ButtonItem("reset");
		buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuReset);
		buttonItem.Click += method_3;
		buttonItem_0.SubItems.Add(buttonItem);
		buttonItem = new ButtonItem("delete");
		buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuDelete);
		buttonItem.Click += method_7;
		buttonItem_0.SubItems.Add(buttonItem);
		TextBoxItem textBoxItem = new TextBoxItem("name");
		textBoxItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuChangeName);
		textBoxItem.BeginGroup = true;
		textBoxItem.ControlText = objItem.Text;
		textBoxItem.LostFocus += method_4;
		buttonItem_0.SubItems.Add(textBoxItem);
		if (baseItem_0 is ButtonItem)
		{
			ButtonItem buttonItem2 = baseItem_0 as ButtonItem;
			buttonItem = new ButtonItem("defaultstyle");
			buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuDefaultStyle);
			buttonItem.BeginGroup = true;
			buttonItem.Click += method_5;
			if (buttonItem2.ButtonStyle == eButtonStyle.Default)
			{
				buttonItem.Checked = true;
			}
			buttonItem_0.SubItems.Add(buttonItem);
			buttonItem = new ButtonItem("textonly");
			buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuTextOnly);
			buttonItem.Click += method_5;
			if (buttonItem2.ButtonStyle == eButtonStyle.TextOnlyAlways)
			{
				buttonItem.Checked = true;
			}
			buttonItem_0.SubItems.Add(buttonItem);
			buttonItem = new ButtonItem("imageandtext");
			buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuImageAndText);
			buttonItem.Click += method_5;
			if (buttonItem2.ButtonStyle == eButtonStyle.ImageAndText)
			{
				buttonItem.Checked = true;
			}
			buttonItem_0.SubItems.Add(buttonItem);
		}
		buttonItem = new ButtonItem("begingroup");
		buttonItem.BeginGroup = true;
		buttonItem.Text = @class.method_1(LocalizationKeys.CustomizeMenuBeginGroup);
		buttonItem.Checked = baseItem_0.BeginGroup;
		buttonItem.Click += method_6;
		buttonItem_0.SubItems.Add(buttonItem);
		dotNetBarManager_0.OnCustomizeContextMenu(this, buttonItem_0);
		buttonItem_0.method_6(dotNetBarManager_0);
		buttonItem_0.PopupMenu(Control.get_MousePosition());
	}

	private void method_3(object sender, EventArgs e)
	{
		((IOwner)dotNetBarManager_0).InvokeResetDefinition(baseItem_0, e);
	}

	private void method_4(object sender, EventArgs e)
	{
		baseItem_0.Text = ((TextBoxItem)buttonItem_0.SubItems["name"]).ControlText;
		baseItem_0.Refresh();
		((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)baseItem_0, new EventArgs());
		((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)baseItem_0, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemTextChanged));
	}

	private void method_5(object sender, EventArgs e)
	{
		ButtonItem buttonItem = sender as ButtonItem;
		ButtonItem buttonItem2 = baseItem_0 as ButtonItem;
		if (buttonItem != null)
		{
			if (buttonItem.Name == "defaultstyle" && !buttonItem.Checked)
			{
				buttonItem2.ButtonStyle = eButtonStyle.Default;
				buttonItem2.Refresh();
				((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)baseItem_0, new EventArgs());
				((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)baseItem_0, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemStyleChanged));
			}
			else if (buttonItem.Name == "textonly" && !buttonItem.Checked)
			{
				buttonItem2.ButtonStyle = eButtonStyle.TextOnlyAlways;
				buttonItem2.Refresh();
				((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)baseItem_0, new EventArgs());
				((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)baseItem_0, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemStyleChanged));
			}
			else if (buttonItem.Name == "imageandtext" && !buttonItem.Checked)
			{
				buttonItem2.ButtonStyle = eButtonStyle.ImageAndText;
				buttonItem2.Refresh();
				((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)baseItem_0, new EventArgs());
				((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)baseItem_0, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemStyleChanged));
			}
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		if (sender is ButtonItem buttonItem)
		{
			buttonItem.Checked = !buttonItem.Checked;
			baseItem_0.BeginGroup = buttonItem.Checked;
			buttonItem.Refresh();
			baseItem_0.Refresh();
			((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)baseItem_0, new EventArgs());
			((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)baseItem_0, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemBeginGroupChanged));
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		BaseItem parent = baseItem_0.Parent;
		parent.SubItems.Remove(baseItem_0);
		parent.Refresh();
		if (parent.ContainerControl is Bar bar)
		{
			bar.RecalcLayout();
		}
		((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)baseItem_0, new EventArgs());
		((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)baseItem_0, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.ItemDeleted));
	}

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 1731)
		{
			((Control)this).set_Capture(true);
			if (cursor_0 != (Cursor)null)
			{
				Cursor.set_Current(cursor_0);
			}
			else
			{
				Cursor.set_Current(Cursors.get_Hand());
			}
			bool_0 = true;
			((Control)this).Focus();
			method_8();
		}
		else
		{
			((Form)this).WndProc(ref m);
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		chkShowScreenTips = new CheckBox();
		tabCtrl = new TabControl();
		tabPage1 = new TabPage();
		cmdReset = new Button();
		cmdRename = new Button();
		cmdDelete = new Button();
		cmdNew = new Button();
		label1 = new Label();
		lstBars = new CheckedListBox();
		tabPage2 = new TabPage();
		lstCommands = new Class83();
		lstCategories = new ListBox();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		tabPage3 = new TabPage();
		cboAnimations = new ComboBoxEx();
		comboItem_0 = new ComboItem();
		comboItem_5 = new ComboItem();
		comboItem_1 = new ComboItem();
		comboItem_2 = new ComboItem();
		comboItem_3 = new ComboItem();
		comboItem_4 = new ComboItem();
		label7 = new Label();
		chkTipsShowShortcuts = new CheckBox();
		button1 = new Button();
		label6 = new Label();
		chkFullAfterDelay = new CheckBox();
		chkShowFullMenus = new CheckBox();
		label5 = new Label();
		cmdKeyboard = new Button();
		cmdClose = new Button();
		((Control)tabCtrl).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)chkShowScreenTips).set_Location(new Point(24, 152));
		((Control)chkShowScreenTips).set_Name("chkShowScreenTips");
		((Control)chkShowScreenTips).set_Size(new Size(320, 16));
		((Control)chkShowScreenTips).set_TabIndex(3);
		((Control)chkShowScreenTips).set_Text("cust_chk_showst");
		((Control)tabCtrl).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			(Control)tabPage1,
			(Control)tabPage2,
			(Control)tabPage3
		});
		((Control)tabCtrl).set_Location(new Point(6, 6));
		((Control)tabCtrl).set_Name("tabCtrl");
		tabCtrl.set_SelectedIndex(0);
		((Control)tabCtrl).set_Size(new Size(354, 303));
		((Control)tabCtrl).set_TabIndex(0);
		((Control)tabPage1).get_Controls().AddRange((Control[])(object)new Control[6]
		{
			(Control)cmdReset,
			(Control)cmdRename,
			(Control)cmdDelete,
			(Control)cmdNew,
			(Control)label1,
			(Control)lstBars
		});
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Size(new Size(346, 277));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("cust_tab_toolbars");
		tabPage1.set_Visible(false);
		((Control)cmdReset).set_Enabled(true);
		((ButtonBase)cmdReset).set_FlatStyle((FlatStyle)3);
		((Control)cmdReset).set_Location(new Point(250, 118));
		((Control)cmdReset).set_Name("cmdReset");
		((Control)cmdReset).set_Size(new Size(90, 24));
		((Control)cmdReset).set_TabIndex(4);
		((Control)cmdReset).set_Text("cust_btn_reset");
		((Control)cmdReset).set_Visible(false);
		((Control)cmdReset).add_Click((EventHandler)cmdReset_Click);
		((Control)cmdRename).set_Enabled(false);
		((ButtonBase)cmdRename).set_FlatStyle((FlatStyle)3);
		((Control)cmdRename).set_Location(new Point(250, 52));
		((Control)cmdRename).set_Name("cmdRename");
		((Control)cmdRename).set_Size(new Size(90, 24));
		((Control)cmdRename).set_TabIndex(2);
		((Control)cmdRename).set_Text("cust_btn_rename");
		((Control)cmdRename).add_Click((EventHandler)cmdRename_Click);
		((Control)cmdDelete).set_Enabled(false);
		((ButtonBase)cmdDelete).set_FlatStyle((FlatStyle)3);
		((Control)cmdDelete).set_Location(new Point(250, 85));
		((Control)cmdDelete).set_Name("cmdDelete");
		((Control)cmdDelete).set_Size(new Size(90, 24));
		((Control)cmdDelete).set_TabIndex(3);
		((Control)cmdDelete).set_Text("cust_btn_delete");
		((Control)cmdDelete).add_Click((EventHandler)cmdDelete_Click);
		((ButtonBase)cmdNew).set_FlatStyle((FlatStyle)3);
		((Control)cmdNew).set_Location(new Point(250, 19));
		((Control)cmdNew).set_Name("cmdNew");
		((Control)cmdNew).set_Size(new Size(90, 24));
		((Control)cmdNew).set_TabIndex(1);
		((Control)cmdNew).set_Text("cust_btn_new");
		((Control)cmdNew).add_Click((EventHandler)cmdNew_Click);
		((Control)label1).set_Location(new Point(5, 5));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(259, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("cust_lbl_tlbs");
		((Control)lstBars).set_Location(new Point(5, 19));
		((Control)lstBars).set_Name("lstBars");
		((ListBox)lstBars).set_IntegralHeight(false);
		((Control)lstBars).set_Size(new Size(239, 249));
		((Control)lstBars).set_TabIndex(0);
		((ListBox)lstBars).add_SelectedIndexChanged((EventHandler)lstBars_SelectedIndexChanged);
		lstBars.add_ItemCheck(new ItemCheckEventHandler(BarsCheck));
		((Control)tabPage2).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			(Control)lstCategories,
			(Control)lstCommands,
			(Control)label4,
			(Control)label3,
			(Control)label2
		});
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Size(new Size(346, 277));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("cust_tab_commands");
		tabPage2.set_Visible(false);
		((Control)lstCommands).set_BackColor(SystemColors.Control);
		((ListBox)lstCommands).set_DrawMode((DrawMode)1);
		((ListBox)lstCommands).set_IntegralHeight(false);
		((Control)lstCommands).set_Location(new Point(136, 71));
		((Control)lstCommands).set_Name("lstCommands");
		((Control)lstCommands).set_Size(new Size(200, 197));
		((Control)lstCommands).set_TabIndex(2);
		((Control)lstCommands).add_MouseDown(new MouseEventHandler(Commands_OnMouseDown));
		((Control)lstCommands).add_MouseMove(new MouseEventHandler(Commands_OnMouseMove));
		((Control)lstCategories).set_Location(new Point(5, 71));
		((Control)lstCategories).set_Name("lstCategories");
		lstCategories.set_IntegralHeight(false);
		((Control)lstCategories).set_Size(new Size(121, 197));
		((Control)lstCategories).set_TabIndex(2);
		lstCategories.add_SelectedIndexChanged((EventHandler)CatSelectedIndexChanged);
		((Control)label4).set_Location(new Point(136, 56));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(197, 13));
		((Control)label4).set_TabIndex(1);
		((Control)label4).set_Text("cust_lbl_cmds");
		((Control)label3).set_Location(new Point(5, 56));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(123, 13));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text("cust_lbl_cats");
		((Control)label2).set_Location(new Point(4, 4));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(336, 46));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("cust_lbl_cmdsins");
		((Control)tabPage3).get_Controls().AddRange((Control[])(object)new Control[9]
		{
			(Control)chkShowFullMenus,
			(Control)chkFullAfterDelay,
			(Control)button1,
			(Control)chkShowScreenTips,
			(Control)chkTipsShowShortcuts,
			(Control)cboAnimations,
			(Control)label7,
			(Control)label6,
			(Control)label5
		});
		tabPage3.set_Location(new Point(4, 22));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Size(new Size(346, 277));
		tabPage3.set_TabIndex(2);
		((Control)tabPage3).set_Text("cust_tab_options");
		tabPage3.set_Visible(false);
		cboAnimations.DefaultStyle = false;
		cboAnimations.DisableInternalDrawing = false;
		((ComboBox)cboAnimations).set_DropDownStyle((ComboBoxStyle)2);
		((ComboBox)cboAnimations).set_DropDownWidth(120);
		cboAnimations.Images = null;
		cboAnimations.Items.AddRange(new object[6] { comboItem_0, comboItem_5, comboItem_1, comboItem_2, comboItem_3, comboItem_4 });
		((Control)cboAnimations).set_Location(new Point(24, 224));
		((Control)cboAnimations).set_Name("cboAnimations");
		((Control)cboAnimations).set_Size(new Size(120, 21));
		cboAnimations.Style = eDotNetBarStyle.OfficeXP;
		((Control)cboAnimations).set_TabIndex(5);
		comboItem_0.BackColor = Color.Empty;
		comboItem_0.FontName = "";
		comboItem_0.FontSize = 8f;
		comboItem_0.FontStyle = (FontStyle)0;
		comboItem_0.ForeColor = Color.Empty;
		comboItem_0.Image = null;
		comboItem_0.ImageIndex = -1;
		comboItem_0.ImagePosition = (HorizontalAlignment)0;
		comboItem_0.Tag = null;
		comboItem_0.Text = "cust_cbo_none";
		comboItem_0.TextAlignment = (StringAlignment)0;
		comboItem_0.TextLineAlignment = (StringAlignment)0;
		comboItem_5.BackColor = Color.Empty;
		comboItem_5.FontName = "";
		comboItem_5.FontSize = 8f;
		comboItem_5.FontStyle = (FontStyle)0;
		comboItem_5.ForeColor = Color.Empty;
		comboItem_5.Image = null;
		comboItem_5.ImageIndex = -1;
		comboItem_5.ImagePosition = (HorizontalAlignment)0;
		comboItem_5.Tag = null;
		comboItem_5.Text = "cust_cbo_system";
		comboItem_5.TextAlignment = (StringAlignment)0;
		comboItem_5.TextLineAlignment = (StringAlignment)0;
		comboItem_1.BackColor = Color.Empty;
		comboItem_1.FontName = "";
		comboItem_1.FontSize = 8f;
		comboItem_1.FontStyle = (FontStyle)0;
		comboItem_1.ForeColor = Color.Empty;
		comboItem_1.Image = null;
		comboItem_1.ImageIndex = -1;
		comboItem_1.ImagePosition = (HorizontalAlignment)0;
		comboItem_1.Tag = null;
		comboItem_1.Text = "cust_cbo_random";
		comboItem_1.TextAlignment = (StringAlignment)0;
		comboItem_1.TextLineAlignment = (StringAlignment)0;
		comboItem_2.BackColor = Color.Empty;
		comboItem_2.FontName = "";
		comboItem_2.FontSize = 8f;
		comboItem_2.FontStyle = (FontStyle)0;
		comboItem_2.ForeColor = Color.Empty;
		comboItem_2.Image = null;
		comboItem_2.ImageIndex = -1;
		comboItem_2.ImagePosition = (HorizontalAlignment)0;
		comboItem_2.Tag = null;
		comboItem_2.Text = "cust_cbo_unfold";
		comboItem_2.TextAlignment = (StringAlignment)0;
		comboItem_2.TextLineAlignment = (StringAlignment)0;
		comboItem_3.BackColor = Color.Empty;
		comboItem_3.FontName = "";
		comboItem_3.FontSize = 8f;
		comboItem_3.FontStyle = (FontStyle)0;
		comboItem_3.ForeColor = Color.Empty;
		comboItem_3.Image = null;
		comboItem_3.ImageIndex = -1;
		comboItem_3.ImagePosition = (HorizontalAlignment)0;
		comboItem_3.Tag = null;
		comboItem_3.Text = "cust_cbo_slide";
		comboItem_3.TextAlignment = (StringAlignment)0;
		comboItem_3.TextLineAlignment = (StringAlignment)0;
		comboItem_4.BackColor = Color.Empty;
		comboItem_4.FontName = "";
		comboItem_4.FontSize = 8f;
		comboItem_4.FontStyle = (FontStyle)0;
		comboItem_4.ForeColor = Color.Empty;
		comboItem_4.Image = null;
		comboItem_4.ImageIndex = -1;
		comboItem_4.ImagePosition = (HorizontalAlignment)0;
		comboItem_4.Tag = null;
		comboItem_4.Text = "cust_cbo_fade";
		comboItem_4.TextAlignment = (StringAlignment)0;
		comboItem_4.TextLineAlignment = (StringAlignment)0;
		((Control)label7).set_Location(new Point(24, 208));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(320, 16));
		((Control)label7).set_TabIndex(6);
		((Control)label7).set_Text("cust_lbl_menuan");
		((Control)chkTipsShowShortcuts).set_Location(new Point(40, 176));
		((Control)chkTipsShowShortcuts).set_Name("chkTipsShowShortcuts");
		((Control)chkTipsShowShortcuts).set_Size(new Size(304, 16));
		((Control)chkTipsShowShortcuts).set_TabIndex(4);
		((Control)chkTipsShowShortcuts).set_Text("cust_chk_showsk");
		((ButtonBase)button1).set_FlatStyle((FlatStyle)3);
		((Control)button1).set_Location(new Point(24, 80));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(180, 24));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("cust_btn_resetusage");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label6).set_Location(new Point(8, 128));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(336, 16));
		((Control)label6).set_TabIndex(7);
		((Control)label6).set_Text("cust_lbl_other");
		((Control)chkFullAfterDelay).set_Location(new Point(40, 56));
		((Control)chkFullAfterDelay).set_Name("chkFullAfterDelay");
		((Control)chkFullAfterDelay).set_Size(new Size(304, 16));
		((Control)chkFullAfterDelay).set_TabIndex(1);
		((Control)chkFullAfterDelay).set_Text("cust_chk_delay");
		((Control)chkShowFullMenus).set_Location(new Point(24, 32));
		((Control)chkShowFullMenus).set_Name("chkShowFullMenus");
		((Control)chkShowFullMenus).set_Size(new Size(320, 16));
		((Control)chkShowFullMenus).set_TabIndex(0);
		((Control)chkShowFullMenus).set_Text("cust_chk_fullmenus");
		((Control)label5).set_Location(new Point(8, 8));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(336, 16));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("cust_lbl_pmt");
		((ButtonBase)cmdKeyboard).set_FlatStyle((FlatStyle)3);
		((Control)cmdKeyboard).set_Location(new Point(160, 317));
		((Control)cmdKeyboard).set_Name("cmdKeyboard");
		((Control)cmdKeyboard).set_Size(new Size(96, 24));
		((Control)cmdKeyboard).set_TabIndex(1);
		((Control)cmdKeyboard).set_Text("cust_btn_keyboard");
		cmdClose.set_DialogResult((DialogResult)2);
		((ButtonBase)cmdClose).set_FlatStyle((FlatStyle)3);
		((Control)cmdClose).set_Location(new Point(264, 317));
		((Control)cmdClose).set_Name("cmdClose");
		((Control)cmdClose).set_Size(new Size(96, 24));
		((Control)cmdClose).set_TabIndex(2);
		((Control)cmdClose).set_Text("cust_btn_close");
		((Control)cmdClose).add_Click((EventHandler)Close_Click);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(368, 347));
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			(Control)cmdClose,
			(Control)cmdKeyboard,
			(Control)tabCtrl
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmCustomize");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("cust_caption");
		((Control)tabCtrl).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage3).ResumeLayout(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)cmdClose);
		((Form)this).set_CancelButton((IButtonControl)(object)cmdClose);
		((Control)this).ResumeLayout(false);
	}

	private void cmdNew_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		ToolbarName toolbarName = new ToolbarName();
		((Control)toolbarName.txtName).set_Text("Custom Bar");
		using (Class264 @class = new Class264(dotNetBarManager_0))
		{
			((Control)toolbarName.txtName).set_Text(@class.method_1("sys_custombar"));
		}
		((Form)toolbarName).set_StartPosition((FormStartPosition)4);
		if ((int)((Form)toolbarName).ShowDialog((IWin32Window)(object)this) == 1)
		{
			Bar bar = new Bar(((Control)toolbarName.txtName).get_Text());
			bar.CustomBar = true;
			bar.CanHide = true;
			bar.SetDesignMode(b: true);
			bar.GrabHandleStyle = eGrabHandleStyle.StripeFlat;
			string text = "userBar";
			int num = 0;
			while (dotNetBarManager_0.Bars.Contains(text + num))
			{
				num++;
			}
			bar.Name = text + num;
			dotNetBarManager_0.Bars.Add(bar);
			bar.DockSide = eDockSide.None;
			lstBars.get_Items().Add((object)bar, (CheckState)1);
			if (dotNetBarManager_0.AllowUserBarCustomize)
			{
				bar.Items.Add(new CustomizeItem());
			}
			((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)bar, new EventArgs());
			((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)bar, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.NewBarCreated));
		}
		((Form)toolbarName).Close();
		((Component)(object)toolbarName).Dispose();
	}

	private void lstBars_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)lstBars).get_SelectedIndex() >= 0)
		{
			Bar bar = ((ListBox)lstBars).get_SelectedItem() as Bar;
			if (bar.CustomBar)
			{
				((Control)cmdRename).set_Enabled(true);
				((Control)cmdReset).set_Enabled(false);
				((Control)cmdDelete).set_Enabled(true);
			}
			else
			{
				((Control)cmdRename).set_Enabled(false);
				((Control)cmdReset).set_Enabled(dotNetBarManager_0.ShowResetButton);
				((Control)cmdDelete).set_Enabled(false);
			}
		}
		else
		{
			((Control)cmdRename).set_Enabled(false);
			((Control)cmdReset).set_Enabled(dotNetBarManager_0.ShowResetButton);
			((Control)cmdDelete).set_Enabled(false);
		}
	}

	private void cmdRename_Click(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Invalid comparison between Unknown and I4
		if (((ListControl)lstBars).get_SelectedIndex() >= 0 && ((ListBox)lstBars).get_SelectedItem() is Bar bar)
		{
			ToolbarName toolbarName = new ToolbarName();
			toolbarName.bool_0 = true;
			((Control)toolbarName.txtName).set_Text(((Control)bar).get_Text());
			((Form)toolbarName).set_StartPosition((FormStartPosition)4);
			if ((int)((Form)toolbarName).ShowDialog((IWin32Window)(object)this) == 1)
			{
				((Control)bar).set_Text(((Control)toolbarName.txtName).get_Text());
				((Control)lstBars).Refresh();
				((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)bar, new EventArgs());
				((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)bar, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.BarRenamed));
			}
			((Form)toolbarName).Close();
			((Component)(object)toolbarName).Dispose();
		}
	}

	private void cmdDelete_Click(object sender, EventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		if (((ListControl)lstBars).get_SelectedIndex() < 0 || !(((ListBox)lstBars).get_SelectedItem() is Bar bar) || !bar.CustomBar)
		{
			return;
		}
		using Class264 @class = new Class264(dotNetBarManager_0);
		if ((int)MessageBox.Show(@class.method_1(LocalizationKeys.CustomizeDialogOptionsConfirmDelete).Replace("<barname>", "'" + ((Control)bar).get_Text() + "'"), ((Control)this).get_Text(), (MessageBoxButtons)4) == 6)
		{
			((ObjectCollection)lstBars.get_Items()).Remove((object)bar);
			dotNetBarManager_0.Bars.Remove(bar);
			((IOwner)dotNetBarManager_0).InvokeUserCustomize((object)bar, new EventArgs());
			((IOwner)dotNetBarManager_0).InvokeEndUserCustomize((object)bar, new EndUserCustomizeEventArgs(eEndUserCustomizeAction.BarDeleted));
			((Component)(object)bar).Dispose();
		}
	}

	private void cmdReset_Click(object sender, EventArgs e)
	{
		IOwner owner = dotNetBarManager_0;
		if (((ListControl)lstBars).get_SelectedIndex() >= 0)
		{
			if (((ListBox)lstBars).get_SelectedItem() is Bar bar && (bar.CustomBar || dotNetBarManager_0.ShowResetButton))
			{
				owner?.InvokeResetDefinition(bar.ItemsContainer, new EventArgs());
			}
		}
		else
		{
			owner?.InvokeResetDefinition(null, new EventArgs());
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		dotNetBarManager_0.ResetUsageData();
	}

	private void method_8()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		if (timer_0 != null)
		{
			timer_0.Start();
			return;
		}
		timer_0 = new Timer();
		timer_0.set_Interval(100);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		if ((int)Control.get_MouseButtons() == 1048576)
		{
			method_0(Control.get_MousePosition());
		}
		else
		{
			method_1(Control.get_MousePosition());
		}
	}

	private void method_9()
	{
		if (timer_0 != null)
		{
			timer_0.Stop();
			((Component)(object)timer_0).Dispose();
			timer_0 = null;
		}
	}

	internal DotNetBarManager method_10()
	{
		return dotNetBarManager_0;
	}
}
