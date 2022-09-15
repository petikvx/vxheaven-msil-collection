using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.ScrollBar;

namespace DevComponents.DotNetBar;

[DefaultEvent("Scroll")]
[ToolboxItem(false)]
[DefaultProperty("Value")]
public abstract class ScrollBarAdv : Control, ICommandSource
{
	private ScrollBarCore scrollBarCore_0;

	private EventHandler eventHandler_0;

	private ScrollEventHandler scrollEventHandler_0;

	private int int_0 = 10;

	private int int_1 = 100;

	private int int_2;

	private int int_3 = 1;

	private int int_4;

	private eScrollBarAppearance eScrollBarAppearance_0;

	private ICommand icommand_0;

	private object object_0;

	[DefaultValue(10)]
	[Category("Behavior")]
	[Description("Indicates value to be added to or subtracted from the Value property when the scroll box is moved a large distance")]
	public int LargeChange
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (int_0 != value)
			{
				int_0 = value;
				if (scrollBarCore_0 != null)
				{
					scrollBarCore_0.LargeChange = int_0;
				}
			}
		}
	}

	[Description("Indicates upper limit of values of the scrollable range.")]
	[Category("Behavior")]
	[RefreshProperties(RefreshProperties.Repaint)]
	[DefaultValue(100)]
	public int Maximum
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				int_1 = value;
				if (scrollBarCore_0 != null)
				{
					scrollBarCore_0.Maximum = int_1;
				}
			}
		}
	}

	[Category("Behavior")]
	[DefaultValue(0)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Description("Indicates lower limit of values of the scrollable range.")]
	public int Minimum
	{
		get
		{
			return int_2;
		}
		set
		{
			if (int_2 != value)
			{
				int_2 = value;
				if (scrollBarCore_0 != null)
				{
					scrollBarCore_0.Minimum = int_2;
				}
			}
		}
	}

	[Description("Indicates value to be added to or subtracted from the Value property when the scroll box is moved a small distance.")]
	[Category("Behavior")]
	[DefaultValue(1)]
	public int SmallChange
	{
		get
		{
			return Math.Min(int_3, int_0);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (int_3 != value)
			{
				int_3 = value;
				if (scrollBarCore_0 != null)
				{
					scrollBarCore_0.SmallChange = SmallChange;
				}
			}
		}
	}

	[DefaultValue(0)]
	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Behavior")]
	[Description("Indicates numeric value that represents the current position of the scroll box on the scroll bar control")]
	public int Value
	{
		get
		{
			if (scrollBarCore_0 != null)
			{
				return scrollBarCore_0.Value;
			}
			return 0;
		}
		set
		{
			if (value < Minimum)
			{
				throw new ArgumentOutOfRangeException("Value must be greater or equal than Minimum property value.");
			}
			if (value > Maximum)
			{
				throw new ArgumentOutOfRangeException("Value must be less or equal than Maximum property value.");
			}
			if (scrollBarCore_0 != null)
			{
				scrollBarCore_0.Value = value;
			}
		}
	}

	[RefreshProperties(RefreshProperties.Repaint)]
	[Category("Appearance")]
	[Description("Indicates scroll bar appearance style.")]
	[DefaultValue(eScrollBarAppearance.Default)]
	public eScrollBarAppearance Appearance
	{
		get
		{
			return eScrollBarAppearance_0;
		}
		set
		{
			if (eScrollBarAppearance_0 != value)
			{
				eScrollBarAppearance_0 = value;
				method_3();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override bool AutoSize
	{
		get
		{
			return ((Control)this).get_AutoSize();
		}
		set
		{
			((Control)this).set_AutoSize(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Image BackgroundImage
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override ImageLayout BackgroundImageLayout
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
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

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ImeMode ImeMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_ImeMode();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_ImeMode(value);
		}
	}

	[DefaultValue(false)]
	public bool TabStop
	{
		get
		{
			return ((Control)this).get_TabStop();
		}
		set
		{
			((Control)this).set_TabStop(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public override RightToLeft RightToLeft
	{
		get
		{
			return (RightToLeft)0;
		}
		set
		{
		}
	}

	[Description("Indicates the command assigned to the item.")]
	[Category("Commands")]
	[DefaultValue(null)]
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

	[Localizable(true)]
	[Browsable(true)]
	[Category("Commands")]
	[DefaultValue(null)]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
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
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event ScrollEventHandler Scroll
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			scrollEventHandler_0 = (ScrollEventHandler)Delegate.Combine((Delegate?)(object)scrollEventHandler_0, (Delegate?)(object)value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			scrollEventHandler_0 = (ScrollEventHandler)Delegate.Remove((Delegate?)(object)scrollEventHandler_0, (Delegate?)(object)value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public event EventHandler AutoSizeChanged
	{
		add
		{
			((Control)this).add_AutoSizeChanged(value);
		}
		remove
		{
			((Control)this).remove_AutoSizeChanged(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public event MouseEventHandler MouseClick
	{
		add
		{
			((Control)this).add_MouseClick(value);
		}
		remove
		{
			((Control)this).remove_MouseClick(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public event MouseEventHandler MouseDoubleClick
	{
		add
		{
			((Control)this).add_MouseDoubleClick(value);
		}
		remove
		{
			((Control)this).remove_MouseDoubleClick(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler BackColorChanged
	{
		add
		{
			((Control)this).add_BackColorChanged(value);
		}
		remove
		{
			((Control)this).remove_BackColorChanged(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler BackgroundImageChanged
	{
		add
		{
			((Control)this).add_BackgroundImageChanged(value);
		}
		remove
		{
			((Control)this).remove_BackgroundImageChanged(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler BackgroundImageLayoutChanged
	{
		add
		{
			((Control)this).add_BackgroundImageLayoutChanged(value);
		}
		remove
		{
			((Control)this).remove_BackgroundImageLayoutChanged(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public event EventHandler Click
	{
		add
		{
			((Control)this).add_Click(value);
		}
		remove
		{
			((Control)this).remove_Click(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public event EventHandler DoubleClick
	{
		add
		{
			((Control)this).add_DoubleClick(value);
		}
		remove
		{
			((Control)this).remove_DoubleClick(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler FontChanged
	{
		add
		{
			((Control)this).add_FontChanged(value);
		}
		remove
		{
			((Control)this).remove_FontChanged(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler ForeColorChanged
	{
		add
		{
			((Control)this).add_ForeColorChanged(value);
		}
		remove
		{
			((Control)this).remove_ForeColorChanged(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler ImeModeChanged
	{
		add
		{
			((Control)this).add_ImeModeChanged(value);
		}
		remove
		{
			((Control)this).remove_ImeModeChanged(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event MouseEventHandler MouseDown
	{
		add
		{
			((Control)this).add_MouseDown(value);
		}
		remove
		{
			((Control)this).remove_MouseDown(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event MouseEventHandler MouseMove
	{
		add
		{
			((Control)this).add_MouseMove(value);
		}
		remove
		{
			((Control)this).remove_MouseMove(value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public event MouseEventHandler MouseUp
	{
		add
		{
			((Control)this).add_MouseUp(value);
		}
		remove
		{
			((Control)this).remove_MouseUp(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event PaintEventHandler Paint
	{
		add
		{
			((Control)this).add_Paint(value);
		}
		remove
		{
			((Control)this).remove_Paint(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler TextChanged
	{
		add
		{
			((Control)this).add_TextChanged(value);
		}
		remove
		{
			((Control)this).remove_TextChanged(value);
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public event EventHandler RightToLeftChanged
	{
		add
		{
			((Control)this).add_RightToLeftChanged(value);
		}
		remove
		{
			((Control)this).remove_RightToLeftChanged(value);
		}
	}

	public ScrollBarAdv()
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		TabStop = false;
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)8192, true);
		((Control)this).SetStyle((ControlStyles)4, true);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle(Class50.ControlStyles_0, true);
		((Control)this).SetStyle((ControlStyles)2048, false);
		((Control)this).SetStyle((ControlStyles)1, false);
		((Control)this).SetStyle((ControlStyles)512, true);
		method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.Dispose();
			scrollBarCore_0 = null;
		}
		((Control)this).Dispose(disposing);
	}

	protected abstract bool IsVertical();

	private void method_0()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		scrollBarCore_0 = new ScrollBarCore((Control)(object)this, isPassive: false);
		scrollBarCore_0.Orientation = (IsVertical() ? eOrientation.Vertical : eOrientation.Horizontal);
		scrollBarCore_0.LargeChange = int_0;
		scrollBarCore_0.Maximum = int_1;
		scrollBarCore_0.Minimum = int_2;
		scrollBarCore_0.SmallChange = SmallChange;
		scrollBarCore_0.Value = int_4;
		scrollBarCore_0.ValueChanged += scrollBarCore_0_ValueChanged;
		scrollBarCore_0.Scroll += new ScrollEventHandler(scrollBarCore_0_Scroll);
	}

	private void scrollBarCore_0_Scroll(object sender, ScrollEventArgs e)
	{
		OnScroll(e);
	}

	private void scrollBarCore_0_ValueChanged(object sender, EventArgs e)
	{
		OnValueChanged(e);
		ExecuteCommand();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.Paint(method_1(e));
		}
		((Control)this).OnPaint(e);
	}

	private ItemPaintArgs method_1(PaintEventArgs paintEventArgs_0)
	{
		return new ItemPaintArgs(null, (Control)(object)this, paintEventArgs_0.get_Graphics(), null);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.MouseMove(e);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (TabStop && !((Control)this).get_Focused())
		{
			((Control)this).Select();
		}
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.MouseDown(e);
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.method_15();
		}
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.method_15();
		}
		((Control)this).OnLeave(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.MouseUp(e);
		}
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.MouseLeave();
		}
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnResize(EventArgs e)
	{
		if (scrollBarCore_0 != null)
		{
			scrollBarCore_0.DisplayRectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		}
		((Control)this).OnResize(e);
	}

	internal void method_2(int int_5, ScrollEventType scrollEventType_0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		int value = Value;
		Value = int_5;
		OnScroll(new ScrollEventArgs(scrollEventType_0, value, int_5, (ScrollOrientation)(scrollBarCore_0.Orientation == eOrientation.Vertical)));
	}

	protected virtual void OnScroll(ScrollEventArgs e)
	{
		ScrollEventHandler val = scrollEventHandler_0;
		if (val != null)
		{
			val.Invoke((object)this, e);
		}
	}

	protected virtual void OnValueChanged(EventArgs e)
	{
		eventHandler_0?.Invoke(this, e);
	}

	private void method_3()
	{
		if (scrollBarCore_0 != null)
		{
			if (eScrollBarAppearance_0 == eScrollBarAppearance.Default)
			{
				scrollBarCore_0.IsAppScrollBarStyle = false;
			}
			else
			{
				scrollBarCore_0.IsAppScrollBarStyle = true;
			}
		}
		((Control)this).Invalidate();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (scrollBarCore_0 != null)
		{
			return scrollBarCore_0.method_14(ref msg, keyData);
		}
		return ((Control)this).ProcessCmdKey(ref msg, keyData);
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
