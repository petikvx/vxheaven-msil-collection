using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[DefaultEvent("Click")]
[Designer(typeof(CheckBoxItemDesigner))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class CheckBoxItem : BaseItem
{
	private bool bool_22;

	private eCheckBoxStyle eCheckBoxStyle_0;

	private Size size_0 = new Size(13, 13);

	private eCheckBoxPosition eCheckBoxPosition_0;

	private int int_4 = 6;

	private int int_5 = 3;

	private bool bool_23;

	private bool bool_24;

	private bool bool_25 = true;

	private Color color_0 = Color.Empty;

	private bool bool_26;

	private CheckState checkState_0;

	private CheckBoxChangeEventHandler checkBoxChangeEventHandler_0;

	private CheckBoxChangeEventHandler checkBoxChangeEventHandler_1;

	private EventHandler eventHandler_14;

	private EventHandler eventHandler_15;

	private bool bool_27 = true;

	internal int Int32_1 => int_4;

	internal int Int32_2
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
		}
	}

	internal Size Size_0 => size_0;

	[Browsable(true)]
	[DefaultValue("")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Description("The text contained in the item.")]
	[Category("Appearance")]
	[Localizable(true)]
	public override string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
		}
	}

	protected override bool IsMarkupSupported => bool_27;

	[Description("Indicates whether text-markup support is enabled for items Text property.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool EnableMarkup
	{
		get
		{
			return bool_27;
		}
		set
		{
			if (bool_27 != value)
			{
				bool_27 = value;
				NeedRecalcSize = true;
				OnTextChanged();
			}
		}
	}

	[DefaultValue(true)]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates whether text assigned to the check box is visible.")]
	public bool TextVisible
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Description("Indicates text color.")]
	[Browsable(true)]
	public Color TextColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			OnAppearanceChanged();
		}
	}

	[Description("Indicates appearance style of the item. Default value is CheckBox. Item can also assume the style of radio-button.")]
	[DefaultValue(eCheckBoxStyle.CheckBox)]
	[Browsable(true)]
	[Category("Appearance")]
	public eCheckBoxStyle CheckBoxStyle
	{
		get
		{
			return eCheckBoxStyle_0;
		}
		set
		{
			eCheckBoxStyle_0 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("Indicates the check box position relative to the text.")]
	[Category("Appearance")]
	[DefaultValue(eCheckBoxPosition.Left)]
	public eCheckBoxPosition CheckBoxPosition
	{
		get
		{
			return eCheckBoxPosition_0;
		}
		set
		{
			eCheckBoxPosition_0 = value;
			NeedRecalcSize = true;
			OnAppearanceChanged();
		}
	}

	[Browsable(false)]
	public bool IsMouseOver => bool_24;

	[Browsable(false)]
	public bool IsMouseDown => bool_23;

	[Browsable(true)]
	[Description("Indicates whether item is checked or not.")]
	[Category("Appearance")]
	[DefaultValue(false)]
	[Bindable(false)]
	[RefreshProperties(RefreshProperties.All)]
	public virtual bool Checked
	{
		get
		{
			return bool_22;
		}
		set
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if (bool_22 != value && (!bool_26 || !value || (int)checkState_0 == 0))
			{
				SetChecked(value, eEventSource.Code);
			}
		}
	}

	[Description("Indicates whether item is checked or not.")]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
	[Browsable(false)]
	[Bindable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Category("Appearance")]
	public virtual bool CheckedBindable
	{
		get
		{
			return Checked;
		}
		set
		{
			Checked = value;
		}
	}

	[Browsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether the CheckBox will allow three check states rather than two.")]
	[Category("Behavior")]
	public bool ThreeState
	{
		get
		{
			return bool_26;
		}
		set
		{
			bool_26 = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Bindable(true)]
	[Description("Specifies the state of a control, such as a check box, that can be checked, unchecked, or set to an indeterminate state")]
	[Browsable(true)]
	[RefreshProperties(RefreshProperties.All)]
	public CheckState CheckState
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return checkState_0;
		}
		set
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			if (value != checkState_0)
			{
				SetChecked(value, eEventSource.Code);
			}
		}
	}

	public event CheckBoxChangeEventHandler CheckedChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			checkBoxChangeEventHandler_0 = (CheckBoxChangeEventHandler)Delegate.Combine(checkBoxChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			checkBoxChangeEventHandler_0 = (CheckBoxChangeEventHandler)Delegate.Remove(checkBoxChangeEventHandler_0, value);
		}
	}

	public event CheckBoxChangeEventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			checkBoxChangeEventHandler_1 = (CheckBoxChangeEventHandler)Delegate.Combine(checkBoxChangeEventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			checkBoxChangeEventHandler_1 = (CheckBoxChangeEventHandler)Delegate.Remove(checkBoxChangeEventHandler_1, value);
		}
	}

	public event EventHandler CheckStateChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_14 = (EventHandler)Delegate.Combine(eventHandler_14, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_14 = (EventHandler)Delegate.Remove(eventHandler_14, value);
		}
	}

	public event EventHandler CheckedBindableChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_15 = (EventHandler)Delegate.Combine(eventHandler_15, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_15 = (EventHandler)Delegate.Remove(eventHandler_15, value);
		}
	}

	public CheckBoxItem()
		: this("", "")
	{
	}

	public CheckBoxItem(string sItemName)
		: this(sItemName, "")
	{
	}

	public CheckBoxItem(string sItemName, string ItemText)
		: base(sItemName, ItemText)
	{
	}

	public override BaseItem Copy()
	{
		CheckBoxItem checkBoxItem = new CheckBoxItem(m_Name);
		CopyToItem(checkBoxItem);
		return checkBoxItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		CheckBoxItem checkBoxItem = copy as CheckBoxItem;
		checkBoxItem.CheckBoxPosition = CheckBoxPosition;
		checkBoxItem.CheckBoxStyle = CheckBoxStyle;
		checkBoxItem.Checked = Checked;
		checkBoxItem.CheckState = CheckState;
		checkBoxItem.TextColor = TextColor;
		checkBoxItem.TextVisible = TextVisible;
		base.CopyToItem(checkBoxItem);
	}

	public override void Paint(ItemPaintArgs p)
	{
		BaseRenderer baseRenderer_ = p.BaseRenderer_0;
		if (baseRenderer_ != null)
		{
			CheckBoxItemRenderEventArgs checkBoxItemRenderEventArgs = new CheckBoxItemRenderEventArgs(p.Graphics, this, p.Colors, p.Font, p.RightToLeft);
			checkBoxItemRenderEventArgs.itemPaintArgs_0 = p;
			baseRenderer_.DrawCheckBoxItem(checkBoxItemRenderEventArgs);
		}
		else
		{
			Class228 @class = Class274.smethod_16(this);
			if (@class != null)
			{
				CheckBoxItemRenderEventArgs checkBoxItemRenderEventArgs2 = new CheckBoxItemRenderEventArgs(p.Graphics, this, p.Colors, p.Font, p.RightToLeft);
				checkBoxItemRenderEventArgs2.itemPaintArgs_0 = p;
				@class.Paint(checkBoxItemRenderEventArgs2);
			}
		}
		DrawInsertMarker(p.Graphics);
	}

	public override void RecalcSize()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		object containerControl = ContainerControl;
		Control val = (Control)((containerControl is Control) ? containerControl : null);
		if (val == null || val.get_Disposing() || val.get_IsDisposed())
		{
			return;
		}
		int num = int_5;
		int num2 = int_4;
		Graphics val2 = Class109.smethod_68(val);
		if (val2 == null)
		{
			return;
		}
		if (bool_25)
		{
			try
			{
				Size size = Class88.smethod_1(this, val2, 0, val.get_Font(), eTextFormat.Default, (int)val.get_RightToLeft() == 1);
				size.Width++;
				if (eCheckBoxPosition_0 != 0 && eCheckBoxPosition_0 != eCheckBoxPosition.Right)
				{
					m_Rect = new Rectangle(m_Rect.X, m_Rect.Y, Math.Max(size.Width, size_0.Width) + num * 2, size.Height + num2 + size_0.Height);
				}
				else
				{
					m_Rect = new Rectangle(m_Rect.X, m_Rect.Y, size.Width + num2 + size_0.Width, Math.Max(size_0.Height, size.Height) + num * 2);
				}
			}
			finally
			{
				val2.Dispose();
			}
		}
		else
		{
			Size size2 = size_0;
			size2.Width += num * 2;
			size2.Height += num * 2;
			m_Rect = new Rectangle(m_Rect.Location, size2);
		}
		base.RecalcSize();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return !color_0.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		TextColor = Color.Empty;
	}

	public override void InternalMouseEnter()
	{
		base.InternalMouseEnter();
		if (!DesignMode)
		{
			bool_24 = true;
			if (method_2())
			{
				Refresh();
			}
		}
	}

	public override void InternalMouseLeave()
	{
		base.InternalMouseLeave();
		if (!DesignMode)
		{
			bool_24 = false;
			if (method_2())
			{
				Refresh();
			}
		}
	}

	public override void InternalMouseDown(MouseEventArgs objArg)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		base.InternalMouseDown(objArg);
		if ((int)objArg.get_Button() == 1048576 && !DesignMode)
		{
			bool_23 = true;
			if (method_2())
			{
				Refresh();
			}
		}
	}

	public override void InternalMouseUp(MouseEventArgs objArg)
	{
		base.InternalMouseUp(objArg);
		if (bool_23 && !DesignMode)
		{
			bool_23 = false;
			if (method_2())
			{
				Refresh();
			}
		}
	}

	public override void RaiseClick(eEventSource source)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		if (base.Boolean_0 && (CheckBoxStyle != eCheckBoxStyle.RadioButton || !Checked))
		{
			if (ThreeState)
			{
				if ((int)CheckState == 0)
				{
					SetChecked((CheckState)1, source);
				}
				else if ((int)CheckState == 1)
				{
					SetChecked((CheckState)2, source);
				}
				else if ((int)CheckState == 2)
				{
					SetChecked((CheckState)0, source);
				}
			}
			else
			{
				SetChecked(!Checked, source);
			}
			ExecuteCommand();
		}
		base.RaiseClick(source);
	}

	public virtual void SetChecked(bool newValue, eEventSource source)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		if (eCheckBoxStyle_0 == eCheckBoxStyle.RadioButton && newValue && Parent != null)
		{
			CheckBoxItem checkBoxItem = null;
			foreach (BaseItem subItem in Parent.SubItems)
			{
				if (subItem != this)
				{
					checkBoxItem = subItem as CheckBoxItem;
					if (checkBoxItem != null && checkBoxItem.Checked && checkBoxItem.CheckBoxStyle == eCheckBoxStyle.RadioButton)
					{
						break;
					}
				}
			}
			CheckBoxChangeEventArgs checkBoxChangeEventArgs = new CheckBoxChangeEventArgs(checkBoxItem, this, source);
			InvokeCheckedChanging(checkBoxChangeEventArgs);
			if (checkBoxChangeEventArgs.Cancel)
			{
				return;
			}
		}
		else
		{
			CheckBoxChangeEventArgs checkBoxChangeEventArgs2 = new CheckBoxChangeEventArgs(null, this, source);
			InvokeCheckedChanging(checkBoxChangeEventArgs2);
			if (checkBoxChangeEventArgs2.Cancel)
			{
				return;
			}
		}
		bool_22 = newValue;
		if ((bool_22 && (int)checkState_0 == 0) || (!bool_22 && (int)checkState_0 != 0))
		{
			checkState_0 = (CheckState)(bool_22 ? 1 : 0);
		}
		OnCheckedChanged(source);
		OnCheckedBindableChanged(EventArgs.Empty);
		if (ShouldSyncProperties)
		{
			Class109.smethod_22(this, "Checked");
		}
		if (Displayed)
		{
			Refresh();
		}
	}

	public virtual void SetChecked(CheckState newValue, eEventSource source)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		CheckBoxChangeEventArgs checkBoxChangeEventArgs = new CheckBoxChangeEventArgs(null, this, source);
		InvokeCheckedChanging(checkBoxChangeEventArgs);
		if (!checkBoxChangeEventArgs.Cancel)
		{
			checkState_0 = newValue;
			bool_22 = (int)newValue != 0;
			OnCheckedChanged(source);
			OnCheckStateChanged(EventArgs.Empty);
			if (ShouldSyncProperties)
			{
				Class109.smethod_22(this, "CheckState");
			}
			if (Displayed)
			{
				Refresh();
			}
		}
	}

	protected virtual void OnCheckStateChanged(EventArgs eventArgs)
	{
		if (eventHandler_14 != null)
		{
			eventHandler_14(this, eventArgs);
		}
	}

	protected virtual void OnCheckedBindableChanged(EventArgs eventArgs)
	{
		if (eventHandler_15 != null)
		{
			eventHandler_15(this, eventArgs);
		}
	}

	protected virtual void OnCheckedChanged(eEventSource source)
	{
		CheckBoxItem oldchecked = null;
		if (eCheckBoxStyle_0 == eCheckBoxStyle.RadioButton && bool_22 && Parent != null)
		{
			foreach (BaseItem subItem in Parent.SubItems)
			{
				if (subItem != this && subItem is CheckBoxItem checkBoxItem && checkBoxItem.Checked && checkBoxItem.CheckBoxStyle == eCheckBoxStyle.RadioButton)
				{
					checkBoxItem.Checked = false;
					oldchecked = checkBoxItem;
				}
			}
		}
		InvokeCheckedChanged(new CheckBoxChangeEventArgs(oldchecked, this, source));
	}

	protected virtual void InvokeCheckedChanging(CheckBoxChangeEventArgs e)
	{
		if (checkBoxChangeEventHandler_0 != null)
		{
			checkBoxChangeEventHandler_0(this, e);
		}
	}

	protected virtual void InvokeCheckedChanged(CheckBoxChangeEventArgs e)
	{
		if (checkBoxChangeEventHandler_1 != null)
		{
			checkBoxChangeEventHandler_1(this, e);
		}
	}
}
