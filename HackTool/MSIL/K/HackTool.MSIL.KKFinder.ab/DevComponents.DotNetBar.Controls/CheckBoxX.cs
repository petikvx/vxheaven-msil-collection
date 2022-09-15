using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar.Controls;

[ComVisible(false)]
[ToolboxItem(true)]
[DefaultEvent("CheckedChanged")]
[ToolboxBitmap(typeof(CheckBoxX), "Controls.CheckBoxX.ico")]
public class CheckBoxX : BaseItemControl, ICommandSource
{
	private const string string_0 = "N";

	private const string string_1 = "Y";

	private const object object_0 = /*Constant with invalid typecode: 28*/;

	private CheckBoxItem checkBoxItem_0;

	private object object_1 = "N";

	private object object_2 = "N";

	private object object_3 = "Y";

	private object object_4;

	private bool bool_4 = true;

	private CheckBoxXChangeEventHandler checkBoxXChangeEventHandler_0;

	private CheckBoxXChangeEventHandler checkBoxXChangeEventHandler_1;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private ICommand icommand_0;

	private object object_5;

	[Category("Appearance")]
	[Description("Indicates whether text-markup support is enabled for controls Text property.")]
	[DefaultValue(true)]
	public bool EnableMarkup
	{
		get
		{
			return checkBoxItem_0.EnableMarkup;
		}
		set
		{
			checkBoxItem_0.EnableMarkup = value;
		}
	}

	[Description("Indicates appearance style of the item. Default value is CheckBox. Item can also assume the style of radio-button.")]
	[Browsable(true)]
	[DefaultValue(eCheckBoxStyle.CheckBox)]
	[Category("Appearance")]
	public eCheckBoxStyle CheckBoxStyle
	{
		get
		{
			return checkBoxItem_0.CheckBoxStyle;
		}
		set
		{
			checkBoxItem_0.CheckBoxStyle = value;
		}
	}

	[Description("Indicates the check box position relative to the text.")]
	[DefaultValue(eCheckBoxPosition.Left)]
	[Browsable(true)]
	[Category("Appearance")]
	public eCheckBoxPosition CheckBoxPosition
	{
		get
		{
			return checkBoxItem_0.CheckBoxPosition;
		}
		set
		{
			checkBoxItem_0.CheckBoxPosition = value;
		}
	}

	[DefaultValue(false)]
	[Bindable(true)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Appearance")]
	[Description("Indicates whether item is checked or not.")]
	public virtual bool Checked
	{
		get
		{
			return checkBoxItem_0.Checked;
		}
		set
		{
			checkBoxItem_0.Checked = value;
		}
	}

	[Description("Indicates whether text assigned to the check box is visible.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool TextVisible
	{
		get
		{
			return checkBoxItem_0.TextVisible;
		}
		set
		{
			checkBoxItem_0.TextVisible = value;
			RecalcLayout();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates text color.")]
	public Color TextColor
	{
		get
		{
			return checkBoxItem_0.TextColor;
		}
		set
		{
			checkBoxItem_0.TextColor = value;
		}
	}

	[Browsable(false)]
	public override Color ForeColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	[Localizable(true)]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue("")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Description("Indicates text associated with this button..")]
	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	[Browsable(false)]
	[Localizable(true)]
	public Padding Padding
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Padding();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Padding(value);
		}
	}

	[DefaultValue(false)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override bool AutoSize
	{
		get
		{
			return ((Control)this).get_AutoSize();
		}
		set
		{
			if (((Control)this).get_AutoSize() != value)
			{
				((Control)this).set_AutoSize(value);
				method_3();
			}
		}
	}

	[Description("Indicates whether the CheckBox will allow three check states rather than two.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool ThreeState
	{
		get
		{
			return checkBoxItem_0.ThreeState;
		}
		set
		{
			checkBoxItem_0.ThreeState = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Browsable(true)]
	[Description("Specifies the state of a control, such as a check box, that can be checked, unchecked, or set to an indeterminate state")]
	[Category("Behavior")]
	public CheckState CheckState
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return checkBoxItem_0.CheckState;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			checkBoxItem_0.CheckState = value;
		}
	}

	[Bindable(true)]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue("N")]
	[TypeConverter(typeof(StringConverter))]
	public object CheckValue
	{
		get
		{
			return object_1;
		}
		set
		{
			object_1 = value;
			method_4();
		}
	}

	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates whether empty string is consider as null value during CheckValue value comparison.")]
	[DefaultValue(true)]
	public bool ConsiderEmptyStringAsNull
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
		}
	}

	[Category("Behavior")]
	[Description("Represents the Indeterminate state value of check box when CheckValue property is set to that value")]
	[DefaultValue(null)]
	[Browsable(true)]
	[TypeConverter(typeof(StringConverter))]
	public object CheckValueIndeterminate
	{
		get
		{
			return object_4;
		}
		set
		{
			object_4 = value;
			method_4();
		}
	}

	[DefaultValue("Y")]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Represents the Checked state value of check box when CheckValue property is set to that value")]
	[TypeConverter(typeof(StringConverter))]
	public object CheckValueChecked
	{
		get
		{
			return object_3;
		}
		set
		{
			object_3 = value;
			method_4();
		}
	}

	[Category("Behavior")]
	[TypeConverter(typeof(StringConverter))]
	[DefaultValue("N")]
	[Browsable(true)]
	[Description("Represents the Unchecked state value of check box when CheckValue property is set to that value")]
	public object CheckValueUnchecked
	{
		get
		{
			return object_2;
		}
		set
		{
			object_2 = value;
			method_4();
		}
	}

	[Category("Commands")]
	[DefaultValue(null)]
	[Description("Indicates the command assigned to the item.")]
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

	[DefaultValue(null)]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Browsable(true)]
	[TypeConverter(typeof(StringConverter))]
	[Category("Commands")]
	[Localizable(true)]
	public object CommandParameter
	{
		get
		{
			return object_5;
		}
		set
		{
			object_5 = value;
		}
	}

	public event CheckBoxXChangeEventHandler CheckedChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			checkBoxXChangeEventHandler_0 = (CheckBoxXChangeEventHandler)Delegate.Combine(checkBoxXChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			checkBoxXChangeEventHandler_0 = (CheckBoxXChangeEventHandler)Delegate.Remove(checkBoxXChangeEventHandler_0, value);
		}
	}

	public event CheckBoxXChangeEventHandler CheckedChangedEx
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			checkBoxXChangeEventHandler_1 = (CheckBoxXChangeEventHandler)Delegate.Combine(checkBoxXChangeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			checkBoxXChangeEventHandler_1 = (CheckBoxXChangeEventHandler)Delegate.Remove(checkBoxXChangeEventHandler_1, value);
		}
	}

	public event EventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler CheckValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public CheckBoxX()
	{
		((Control)this).SetStyle((ControlStyles)512, true);
		checkBoxItem_0 = new CheckBoxItem();
		checkBoxItem_0.Int32_2 = 0;
		checkBoxItem_0.Style = eDotNetBarStyle.Office2007;
		checkBoxItem_0.CheckedChanging += checkBoxItem_0_CheckedChanging;
		checkBoxItem_0.CheckedChanged += checkBoxItem_0_CheckedChanged;
		HostItem = checkBoxItem_0;
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (!((Control)this).get_Focused())
		{
			((Control)this).Select();
		}
		base.OnMouseDown(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		if (CheckBoxStyle == eCheckBoxStyle.RadioButton && (int)Control.get_MouseButtons() == 0 && Class51.GetKeyState(9) < 0)
		{
			checkBoxItem_0.SetChecked(newValue: true, eEventSource.Keyboard);
		}
		((Control)this).OnEnter(e);
	}

	private void checkBoxItem_0_CheckedChanged(object sender, CheckBoxChangeEventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		CheckBoxX oldchecked = null;
		if (checkBoxItem_0.CheckBoxStyle == eCheckBoxStyle.RadioButton && checkBoxItem_0.Checked && ((Control)this).get_Parent() != null)
		{
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
			{
				Control val = item;
				if (val != this && val is CheckBoxX checkBoxX && checkBoxX.Checked && checkBoxX.CheckBoxStyle == eCheckBoxStyle.RadioButton)
				{
					checkBoxX.Checked = false;
					oldchecked = checkBoxX;
				}
			}
		}
		CheckBoxXChangeEventArgs e2 = new CheckBoxXChangeEventArgs(oldchecked, this, e.EventSource);
		if (checkBoxXChangeEventHandler_1 != null)
		{
			checkBoxXChangeEventHandler_1(this, e2);
		}
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
		if (method_7(object_1) != CheckState)
		{
			object_1 = method_6(CheckState);
		}
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, new EventArgs());
		}
		ExecuteCommand();
	}

	private void checkBoxItem_0_CheckedChanging(object sender, CheckBoxChangeEventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		CheckBoxXChangeEventArgs checkBoxXChangeEventArgs = new CheckBoxXChangeEventArgs(null, this, e.EventSource);
		if (checkBoxItem_0.CheckBoxStyle == eCheckBoxStyle.RadioButton && !checkBoxItem_0.Checked && ((Control)this).get_Parent() != null)
		{
			CheckBoxX checkBoxX = null;
			foreach (Control item in (ArrangedElementCollection)((Control)this).get_Parent().get_Controls())
			{
				Control val = item;
				if (val != this)
				{
					checkBoxX = val as CheckBoxX;
					if (checkBoxX != null && checkBoxX.Checked && checkBoxX.CheckBoxStyle == eCheckBoxStyle.RadioButton)
					{
						break;
					}
				}
			}
			checkBoxXChangeEventArgs = new CheckBoxXChangeEventArgs(checkBoxX, this, e.EventSource);
		}
		if (checkBoxXChangeEventHandler_0 != null)
		{
			checkBoxXChangeEventHandler_0(this, checkBoxXChangeEventArgs);
			e.Cancel = checkBoxXChangeEventArgs.Cancel;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !checkBoxItem_0.TextColor.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32 && ((Control)this).get_Enabled())
		{
			if (CheckBoxStyle == eCheckBoxStyle.CheckBox)
			{
				method_1(!Checked, eEventSource.Keyboard);
			}
			else if (!Checked)
			{
				method_1(bool_5: true, eEventSource.Keyboard);
			}
		}
		base.OnKeyDown(e);
	}

	private void method_1(bool bool_5, eEventSource eEventSource_0)
	{
		checkBoxItem_0.SetChecked(bool_5, eEventSource_0);
	}

	private void method_2(CheckState checkState_0, eEventSource eEventSource_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		checkBoxItem_0.SetChecked(checkState_0, eEventSource_0);
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (!Class109.smethod_11((Control)(object)this))
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		if (((Control)this).get_Text().Length == 0)
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		checkBoxItem_0.RecalcSize();
		Size size = checkBoxItem_0.Size;
		size.Width += 2;
		size.Height += 2;
		if (!TextVisible)
		{
			size.Width += 2;
		}
		checkBoxItem_0.Bounds = GetItemBounds();
		return size;
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_AutoSize())
		{
			Size preferredSize = ((Control)this).get_PreferredSize();
			width = preferredSize.Width;
			height = preferredSize.Height;
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	private void method_3()
	{
		if (((Control)this).get_AutoSize())
		{
			((Control)this).set_Size(((Control)this).get_PreferredSize());
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		method_3();
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (((Control)this).get_AutoSize())
		{
			method_3();
		}
	}

	private void method_4()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		CheckState val2 = (CheckState = method_7(object_1));
	}

	private bool method_5(object object_6)
	{
		if (object_6 != null && (!(object_6 is string) || !((string)object_6 == string.Empty) || !bool_4))
		{
			return object_6 == DBNull.Value;
		}
		return true;
	}

	private object method_6(CheckState checkState_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)checkState_0 == 2)
		{
			return object_4;
		}
		if ((int)checkState_0 == 0)
		{
			return object_2;
		}
		return object_3;
	}

	private CheckState method_7(object object_6)
	{
		if ((object_4 != null || !method_5(object_6)) && (object_4 == null || !object_4.Equals(object_6)))
		{
			if ((object_3 != null || !method_5(object_6)) && (object_3 == null || !object_3.Equals(object_6)))
			{
				if ((object_2 != null || !method_5(object_6)) && (object_2 == null || !object_2.Equals(object_6)))
				{
					return (CheckState)2;
				}
				return (CheckState)0;
			}
			return (CheckState)1;
		}
		return (CheckState)2;
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
