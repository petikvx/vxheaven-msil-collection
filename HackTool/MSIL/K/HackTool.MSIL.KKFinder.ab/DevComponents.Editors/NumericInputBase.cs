using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DevComponents.Editors;

[DefaultEvent("ValueChanged")]
[ToolboxItem(false)]
public abstract class NumericInputBase : VisualControlBase, ICommandSource
{
	private VisualInputGroup visualInputGroup_0;

	private ButtonItem buttonItem_0;

	private static string string_1 = "sysPopupControlContainer";

	private static string string_2 = "sysPopupItemContainer";

	private EventHandler eventHandler_7;

	private EventHandler eventHandler_8;

	private CancelEventHandler cancelEventHandler_0;

	private CancelEventHandler cancelEventHandler_1;

	private EventHandler eventHandler_9;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private InputButtonSettings inputButtonSettings_2;

	private InputButtonSettings inputButtonSettings_3;

	private string string_3 = "";

	private Control control_0;

	private DateTime dateTime_0 = DateTime.MinValue;

	private Control control_1;

	private ICommand icommand_0;

	private object object_0;

	[DefaultValue(false)]
	[Description("Indicates whether input part of the control is read-only.")]
	public bool IsInputReadOnly
	{
		get
		{
			return visualInputGroup_0.IsReadOnly;
		}
		set
		{
			visualInputGroup_0.IsReadOnly = value;
		}
	}

	[Description("Indicates whether a check box is displayed to the left of the input value which allows locking of the control.")]
	[DefaultValue(false)]
	public bool ShowCheckBox
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
			OnShowCheckBoxChanged();
		}
	}

	private LockUpdateCheckBox LockUpdateCheckBox_0
	{
		get
		{
			if (visualInputGroup_0.Items[0] is LockUpdateCheckBox)
			{
				return (LockUpdateCheckBox)visualInputGroup_0.Items[0];
			}
			return null;
		}
	}

	[DefaultValue(false)]
	[Description("Indicates whether check box shown using ShowCheckBox property which locks/unlocks the control update is checked.")]
	public bool LockUpdateChecked
	{
		get
		{
			return bool_10;
		}
		set
		{
			if (bool_10 != value)
			{
				bool_10 = value;
				LockUpdateCheckBox lockUpdateCheckBox_ = LockUpdateCheckBox_0;
				if (lockUpdateCheckBox_ != null)
				{
					lockUpdateCheckBox_.Checked = bool_10;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool ShowUpDown
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
			OnShowUpDownChanged();
		}
	}

	[Category("Buttons")]
	[Description("Describes the settings for the button that shows drop-down when clicked.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public InputButtonSettings ButtonDropDown => inputButtonSettings_2;

	[Category("Buttons")]
	[Description("Describes the settings for the button that clears the content of the control when clicked.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public InputButtonSettings ButtonClear => inputButtonSettings_3;

	[DefaultValue("")]
	[Description("Indicates Numeric String Format that is used to format the numeric value entered for display purpose.")]
	public string DisplayFormat
	{
		get
		{
			return string_3;
		}
		set
		{
			if (value != null)
			{
				12.ToString(value);
				string_3 = value;
				OnDisplayFormatChanged();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether empty null/nothing state of the control is allowed.")]
	public bool AllowEmptyState
	{
		get
		{
			return visualInputGroup_0.AllowEmptyState;
		}
		set
		{
			visualInputGroup_0.AllowEmptyState = value;
			((Control)this).Invalidate();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool IsEmpty
	{
		get
		{
			return visualInputGroup_0.IsEmpty;
		}
		set
		{
			visualInputGroup_0.IsEmpty = value;
		}
	}

	[Description("Indicates alignment of input fields inside of the control.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(eHorizontalAlignment.Right)]
	public override eHorizontalAlignment InputHorizontalAlignment
	{
		get
		{
			return base.InputHorizontalAlignment;
		}
		set
		{
			base.InputHorizontalAlignment = value;
		}
	}

	[Description("Indicates reference of the control that will be displayed on popup that is shown when drop-down button is clicked.")]
	[DefaultValue(null)]
	public Control DropDownControl
	{
		get
		{
			return control_1;
		}
		set
		{
			control_1 = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public SubItemsCollection DropDownItems => buttonItem_0.SubItems;

	[DefaultValue(false)]
	[Description("Indicates whether auto-overwrite functionality for input is enabled.")]
	public bool AutoOverwrite
	{
		get
		{
			return visualInputGroup_0.AutoOverwrite;
		}
		set
		{
			visualInputGroup_0.AutoOverwrite = value;
		}
	}

	[Description("Indicates the command assigned to the item.")]
	[DefaultValue(null)]
	[Category("Commands")]
	public Command Command
	{
		get
		{
			return (Command)((ICommandSource)this).Command;
		}
		set
		{
			((ICommandSource)this).Command = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	ICommand ICommandSource.Command
	{
		get
		{
			return icommand_0;
		}
		set
		{
			bool flag = false;
			if (icommand_0 != value)
			{
				flag = true;
			}
			if (icommand_0 != null)
			{
				CommandManager.UnRegisterCommandSource(this, icommand_0);
			}
			icommand_0 = value;
			if (value != null)
			{
				CommandManager.RegisterCommand(this, value);
			}
			if (flag)
			{
				OnCommandChanged();
			}
		}
	}

	[Category("Commands")]
	[Localizable(true)]
	[DefaultValue(null)]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Browsable(true)]
	[TypeConverter(typeof(StringConverter))]
	public object CommandParameter
	{
		get
		{
			return object_0;
		}
		set
		{
			object_0 = value;
		}
	}

	public event EventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_7 = (EventHandler)Delegate.Combine(eventHandler_7, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_7 = (EventHandler)Delegate.Remove(eventHandler_7, value);
		}
	}

	public event EventHandler ValueObjectChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_8 = (EventHandler)Delegate.Combine(eventHandler_8, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_8 = (EventHandler)Delegate.Remove(eventHandler_8, value);
		}
	}

	public event CancelEventHandler ButtonClearClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	public event CancelEventHandler ButtonDropDownClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_1 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_1, value);
		}
	}

	public event EventHandler LockUpdateChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_9 = (EventHandler)Delegate.Combine(eventHandler_9, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_9 = (EventHandler)Delegate.Remove(eventHandler_9, value);
		}
	}

	public NumericInputBase()
	{
		inputButtonSettings_3 = new InputButtonSettings(this);
		inputButtonSettings_2 = new InputButtonSettings(this);
		visualInputGroup_0 = RootVisualItem as VisualInputGroup;
		visualInputGroup_0.AutoOverwrite = false;
		InputHorizontalAlignment = eHorizontalAlignment.Right;
	}

	protected virtual void OnShowCheckBoxChanged()
	{
		LockUpdateCheckBox lockUpdateCheckBox_ = LockUpdateCheckBox_0;
		if (lockUpdateCheckBox_ != null)
		{
			visualInputGroup_0.Items.Remove(lockUpdateCheckBox_);
			lockUpdateCheckBox_.CheckedChanged -= method_16;
		}
		if (ShowCheckBox && !(visualInputGroup_0.Items[0] is LockUpdateCheckBox))
		{
			lockUpdateCheckBox_ = new LockUpdateCheckBox();
			lockUpdateCheckBox_.CheckedChanged += method_16;
			visualInputGroup_0.Items.Insert(0, lockUpdateCheckBox_);
			lockUpdateCheckBox_.Checked = bool_10;
		}
	}

	private void method_16(object sender, EventArgs e)
	{
		LockUpdateCheckBox lockUpdateCheckBox_ = LockUpdateCheckBox_0;
		if (lockUpdateCheckBox_ != null)
		{
			bool_10 = lockUpdateCheckBox_.Checked;
		}
		OnLockUpdateChanged(e);
	}

	protected virtual void OnLockUpdateChanged(EventArgs e)
	{
		if (eventHandler_9 != null)
		{
			eventHandler_9(this, e);
		}
	}

	protected override void RecreateButtons()
	{
		base.RecreateButtons();
		OnShowUpDownChanged();
		OnShowCheckBoxChanged();
	}

	protected virtual void OnShowUpDownChanged()
	{
		int num = visualInputGroup_0.Items.Count - 1;
		while (num >= 0)
		{
			if (!(visualInputGroup_0.Items[num] is VisualUpDownButton))
			{
				num--;
				continue;
			}
			visualInputGroup_0.Items.RemoveAt(num);
			break;
		}
		if (ShowUpDown)
		{
			VisualUpDownButton visualUpDownButton = new VisualUpDownButton();
			visualUpDownButton.Alignment = eItemAlignment.Right;
			visualUpDownButton.AutoChange = eUpDownButtonAutoChange.FocusedItem;
			visualInputGroup_0.Items.Add(visualUpDownButton);
		}
	}

	protected override VisualItem CreateButton(InputButtonSettings buttonSettings)
	{
		VisualItem visualItem = null;
		if (buttonSettings == inputButtonSettings_2)
		{
			visualItem = new VisualDropDownButton();
			ApplyButtonSettings(buttonSettings, visualItem as VisualButton);
		}
		else
		{
			visualItem = base.CreateButton(buttonSettings);
		}
		VisualButton visualButton = visualItem as VisualButton;
		visualButton.ClickAutoRepeat = false;
		if (buttonSettings == inputButtonSettings_3 && buttonSettings.Image == null)
		{
			visualButton.Image = (Image)(object)Class109.smethod_67("SystemImages.DateReset.png");
		}
		return visualItem;
	}

	protected abstract void OnDisplayFormatChanged();

	protected override SortedList CreateSortedButtonList()
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		SortedList sortedList = base.CreateSortedButtonList();
		if (inputButtonSettings_3.Visible)
		{
			VisualItem visualItem = CreateButton(inputButtonSettings_3);
			if (inputButtonSettings_3.ItemReference != null)
			{
				inputButtonSettings_3.ItemReference.Click -= method_19;
			}
			inputButtonSettings_3.ItemReference = visualItem;
			visualItem.Click += method_19;
			sortedList.Add(inputButtonSettings_3, visualItem);
		}
		if (inputButtonSettings_2.Visible)
		{
			VisualItem visualItem2 = CreateButton(inputButtonSettings_2);
			if (inputButtonSettings_2.ItemReference != null)
			{
				inputButtonSettings_2.ItemReference.MouseDown -= new MouseEventHandler(method_17);
			}
			inputButtonSettings_2.ItemReference = visualItem2;
			visualItem2.MouseDown += new MouseEventHandler(method_17);
			sortedList.Add(inputButtonSettings_2, visualItem2);
		}
		return sortedList;
	}

	private void method_17(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576 && (!(dateTime_0 != DateTime.MinValue) || DateTime.Now.Subtract(dateTime_0).TotalMilliseconds >= 150.0))
		{
			ShowDropDown();
		}
		else
		{
			dateTime_0 = DateTime.MinValue;
		}
	}

	public void ShowDropDown()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		if (control_1 == null && buttonItem_0.SubItems.Count == 0)
		{
			return;
		}
		if (buttonItem_0.Expanded)
		{
			buttonItem_0.Expanded = false;
			return;
		}
		ControlContainerItem controlContainerItem = null;
		ItemContainer itemContainer = null;
		if (control_1 != null)
		{
			itemContainer = new ItemContainer();
			itemContainer.Name = string_2;
			controlContainerItem = new ControlContainerItem(string_1);
			itemContainer.SubItems.Add(controlContainerItem);
			buttonItem_0.SubItems.Insert(0, itemContainer);
		}
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnButtonDropDownClick(cancelEventArgs);
		if (!cancelEventArgs.Cancel && buttonItem_0.SubItems.Count != 0)
		{
			control_0 = control_1.get_Parent();
			controlContainerItem.Control = control_1;
			buttonItem_0.method_4(((Control)this).get_ClientRectangle());
			if ((int)((Control)this).get_RightToLeft() == 0)
			{
				Point point = new Point(((Control)this).get_Width() - buttonItem_0.PopupSize.Width, ((Control)this).get_Height());
				Class273 @class = Class109.smethod_53((Control)(object)this);
				Point point2 = ((Control)this).PointToScreen(point);
				if (@class != null && @class.rectangle_1.X > point2.X)
				{
					point.X = 0;
				}
				buttonItem_0.PopupLocation = point;
			}
			buttonItem_0.Expanded = !buttonItem_0.Expanded;
		}
		else if (itemContainer != null)
		{
			buttonItem_0.SubItems.Remove(itemContainer);
		}
	}

	public void CloseDropDown()
	{
		if (buttonItem_0.Expanded)
		{
			buttonItem_0.Expanded = false;
		}
	}

	private void method_18(object sender, EventArgs e)
	{
		dateTime_0 = DateTime.Now;
		if (!(buttonItem_0.SubItems[string_2] is ItemContainer itemContainer))
		{
			return;
		}
		if (itemContainer.SubItems[string_1] is ControlContainerItem controlContainerItem)
		{
			controlContainerItem.Control = null;
			itemContainer.SubItems.Remove(controlContainerItem);
			if (control_1 != null)
			{
				control_1.set_Parent(control_0);
				control_0 = null;
			}
		}
		buttonItem_0.SubItems.Remove(itemContainer);
	}

	private void method_19(object sender, EventArgs e)
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnButtonClearClick(cancelEventArgs);
		if (!cancelEventArgs.Cancel)
		{
			IsEmpty = true;
		}
	}

	protected virtual void OnButtonClearClick(CancelEventArgs e)
	{
		if (cancelEventHandler_0 != null)
		{
			cancelEventHandler_0(this, e);
		}
	}

	protected virtual void OnButtonDropDownClick(CancelEventArgs e)
	{
		if (cancelEventHandler_1 != null)
		{
			cancelEventHandler_1(this, e);
		}
	}

	protected virtual void OnValueChanged(EventArgs e)
	{
		if (!IsInitializing)
		{
			if (eventHandler_7 != null)
			{
				eventHandler_7(this, e);
			}
			if (eventHandler_8 != null)
			{
				eventHandler_8(this, e);
			}
			ExecuteCommand();
		}
	}

	protected override PopupItem CreatePopupItem()
	{
		ButtonItem buttonItem = new ButtonItem("sysPopupProvider");
		buttonItem.PopupFinalized += method_18;
		buttonItem_0 = buttonItem;
		return buttonItem;
	}

	protected virtual void ExecuteCommand()
	{
		if (icommand_0 != null)
		{
			CommandManager.smethod_0(this);
		}
	}

	protected virtual void OnCommandChanged()
	{
	}
}
