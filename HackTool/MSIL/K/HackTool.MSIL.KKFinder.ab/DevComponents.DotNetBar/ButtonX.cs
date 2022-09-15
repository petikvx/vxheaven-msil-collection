using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[DefaultEvent("Click")]
[Designer(typeof(ButtonXDesigner))]
[ToolboxBitmap(typeof(ButtonX), "ButtonX.ButtonX.ico")]
[ToolboxItem(true)]
[ComVisible(false)]
public class ButtonX : PopupItemControl, IButtonControl, ICommandSource
{
	private EventHandler eventHandler_5;

	private ButtonItem buttonItem_0;

	private ColorScheme colorScheme_1;

	private DialogResult dialogResult_0;

	private bool bool_5;

	private bool bool_6 = true;

	private eButtonTextAlignment eButtonTextAlignment_0 = eButtonTextAlignment.Center;

	private Size size_0 = Size.Empty;

	private Point point_0 = Point.Empty;

	private static RoundRectangleShapeDescriptor roundRectangleShapeDescriptor_0 = new RoundRectangleShapeDescriptor(2);

	private ShapeDescriptor shapeDescriptor_0;

	private bool bool_7 = true;

	private AutoSizeMode autoSizeMode_0 = (AutoSizeMode)1;

	private ICommand icommand_0;

	private object object_0;

	[Description("Indicates whether text-markup support is enabled for controls Text property.")]
	[Category("Appearance")]
	[DefaultValue(true)]
	public bool EnableMarkup
	{
		get
		{
			return buttonItem_0.EnableMarkup;
		}
		set
		{
			buttonItem_0.EnableMarkup = value;
		}
	}

	[Browsable(false)]
	public bool IsPulsing => buttonItem_0.IsPulsing;

	[Description("Indicates whether pulse effect started with Pulse method stops automatically when mouse moves over the button.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public bool StopPulseOnMouseOver
	{
		get
		{
			return buttonItem_0.StopPulseOnMouseOver;
		}
		set
		{
			buttonItem_0.StopPulseOnMouseOver = value;
		}
	}

	[DefaultValue(12)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Indicates pulse speed. The value must be greater than 0 and less than 128.")]
	public int PulseSpeed
	{
		get
		{
			return buttonItem_0.PulseSpeed;
		}
		set
		{
			buttonItem_0.PulseSpeed = value;
		}
	}

	[Browsable(true)]
	public Size ImageFixedSize
	{
		get
		{
			return buttonItem_0.ImageFixedSize;
		}
		set
		{
			buttonItem_0.ImageFixedSize = value;
			RecalcLayout();
		}
	}

	[Browsable(true)]
	[Description("Indicates text alignment. Applies only when button text is not composed using text markup. Default value is center.")]
	[Category("Appearance")]
	[DefaultValue(eButtonTextAlignment.Center)]
	public eButtonTextAlignment TextAlignment
	{
		get
		{
			return eButtonTextAlignment_0;
		}
		set
		{
			eButtonTextAlignment_0 = value;
			RecalcLayout();
		}
	}

	protected virtual bool ExecuteCommandOnClick => true;

	[DefaultValue(null)]
	[Description("The image that will be displayed on the face of the button.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	public Image Image
	{
		get
		{
			return buttonItem_0.Image;
		}
		set
		{
			buttonItem_0.Image = value;
			InvalidateAutoSize();
			AdjustSize();
		}
	}

	[Description("The image that will be displayed when mouse hovers over the item.")]
	[Category("Appearance")]
	[DefaultValue(null)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public Image HoverImage
	{
		get
		{
			return buttonItem_0.HoverImage;
		}
		set
		{
			buttonItem_0.HoverImage = value;
		}
	}

	[Category("Appearance")]
	[Description("The image that will be displayed when item is disabled.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[DefaultValue(null)]
	public Image DisabledImage
	{
		get
		{
			return buttonItem_0.DisabledImage;
		}
		set
		{
			buttonItem_0.DisabledImage = value;
		}
	}

	[DefaultValue(null)]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("The image that will be displayed when item is pressed.")]
	public Image PressedImage
	{
		get
		{
			return buttonItem_0.PressedImage;
		}
		set
		{
			buttonItem_0.PressedImage = value;
		}
	}

	[Description("Indicates location of popup in relation to it's parent.")]
	[Browsable(true)]
	[DevCoBrowsable(false)]
	[DefaultValue(ePopupSide.Default)]
	public ePopupSide PopupSide
	{
		get
		{
			return buttonItem_0.PopupSide;
		}
		set
		{
			buttonItem_0.PopupSide = value;
			InvalidateAutoSize();
		}
	}

	[DevCoBrowsable(false)]
	[Description("Collection of sub items.")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Data")]
	[Editor(typeof(ButtonItemEditor), typeof(UITypeEditor))]
	[Browsable(true)]
	public virtual SubItemsCollection SubItems => buttonItem_0.SubItems;

	[Description("Indicates whether button appears as split button.")]
	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(false)]
	public bool SplitButton
	{
		get
		{
			return buttonItem_0.SplitButton;
		}
		set
		{
			buttonItem_0.SplitButton = value;
			InvalidateAutoSize();
		}
	}

	[DevCoBrowsable(true)]
	[Description("Determines whether sub-items are displayed.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	[Browsable(true)]
	public bool ShowSubItems
	{
		get
		{
			return buttonItem_0.ShowSubItems;
		}
		set
		{
			buttonItem_0.ShowSubItems = value;
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(eImagePosition.Left)]
	[Category("Appearance")]
	[Description("The alignment of the image in relation to text displayed by this item.")]
	[Browsable(true)]
	public eImagePosition ImagePosition
	{
		get
		{
			return buttonItem_0.ImagePosition;
		}
		set
		{
			buttonItem_0.ImagePosition = value;
			InvalidateAutoSize();
			RecalcLayout();
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Indicates whether mouse over fade effect is enabled")]
	public bool FadeEffect
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
		}
	}

	internal bool Boolean_1
	{
		get
		{
			if (!((Component)(object)this).DesignMode && buttonItem_0.Style == eDotNetBarStyle.Office2007 && (!bool_6 || !Class92.smethod_7()) && !base.IsThemed && !Class55.bool_1)
			{
				return bool_6;
			}
			return false;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(eHotTrackingStyle.Default)]
	[Description("Indicates the button mouse over tracking style. Setting the value to Color will render the image in gray-scale when mouse is not over the item.")]
	public virtual eHotTrackingStyle HotTrackingStyle
	{
		get
		{
			return buttonItem_0.HotTrackingStyle;
		}
		set
		{
			buttonItem_0.HotTrackingStyle = value;
		}
	}

	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Description("Indicates the width of the expand part of the button item.")]
	[Category("Behavior")]
	[DefaultValue(12)]
	public virtual int SubItemsExpandWidth
	{
		get
		{
			return buttonItem_0.SubItemsExpandWidth;
		}
		set
		{
			buttonItem_0.SubItemsExpandWidth = value;
			RecalcLayout();
		}
	}

	[Description("Indicates text associated with this button..")]
	[Localizable(true)]
	[DefaultValue("")]
	[Browsable(true)]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Category("Appearance")]
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

	[Category("Appearance")]
	[Description("Indicates informational text (tooltip) for the button.")]
	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Localizable(true)]
	[DefaultValue("")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public virtual string Tooltip
	{
		get
		{
			return buttonItem_0.Tooltip;
		}
		set
		{
			buttonItem_0.Tooltip = value;
		}
	}

	[DefaultValue(false)]
	[Browsable(true)]
	[Description("Indicates whether the button will auto-expand (display pop-up menu or toolbar) when clicked.")]
	[DevCoBrowsable(true)]
	[Category("Behavior")]
	public virtual bool AutoExpandOnClick
	{
		get
		{
			return buttonItem_0.AutoExpandOnClick;
		}
		set
		{
			buttonItem_0.AutoExpandOnClick = value;
			RecalcLayout();
		}
	}

	[Description("Indicates whether Checked property is automatically inverted when button is clicked.")]
	[Browsable(true)]
	[DefaultValue(false)]
	[Category("Behavior")]
	public bool AutoCheckOnClick
	{
		get
		{
			return buttonItem_0.AutoCheckOnClick;
		}
		set
		{
			buttonItem_0.AutoCheckOnClick = value;
		}
	}

	[Description("Indicates whether item is checked or not.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Browsable(true)]
	public virtual bool Checked
	{
		get
		{
			return buttonItem_0.Checked;
		}
		set
		{
			buttonItem_0.Checked = value;
			((Control)this).Invalidate();
		}
	}

	[MergableProperty(false)]
	[Editor(typeof(ShapeTypeEditor), typeof(UITypeEditor))]
	[DefaultValue(null)]
	[TypeConverter(typeof(ShapeStringConverter))]
	public ShapeDescriptor Shape
	{
		get
		{
			return shapeDescriptor_0;
		}
		set
		{
			if (shapeDescriptor_0 != value)
			{
				shapeDescriptor_0 = value;
				((Control)this).Invalidate();
			}
		}
	}

	[DefaultValue(true)]
	[Description("Indicates whether control displays focus cues when focused.")]
	[Category("Behavior")]
	public virtual bool FocusCuesEnabled
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
			if (((Control)this).get_Focused())
			{
				((Control)this).Invalidate();
			}
		}
	}

	internal int Int32_0 => 2;

	[DevCoBrowsable(false)]
	[DefaultValue("")]
	[Description("Indicates custom color table name for the button when Office 2007 style is used.")]
	[Category("Appearance")]
	[Browsable(true)]
	public string CustomColorName
	{
		get
		{
			return buttonItem_0.CustomColorName;
		}
		set
		{
			buttonItem_0.CustomColorName = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates predefined color of button when Office 2007 style is used.")]
	[DefaultValue(eButtonColor.BlueWithBackground)]
	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[Browsable(true)]
	public eButtonColor ColorTable
	{
		get
		{
			return buttonItem_0.ColorTable;
		}
		set
		{
			if (buttonItem_0.ColorTable != value)
			{
				buttonItem_0.ColorTable = value;
				((Control)this).Invalidate();
			}
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
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
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
				InvalidateAutoSize();
				AdjustSize();
			}
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Indicates the mode by which the Button automatically resizes itself. ")]
	[Localizable(true)]
	public AutoSizeMode AutoSizeMode
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return autoSizeMode_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			if (autoSizeMode_0 != value)
			{
				autoSizeMode_0 = value;
				InvalidateAutoSize();
				AdjustSize();
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[Category("Behavior")]
	[Browsable(true)]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Description("Gets or sets the value returned to the parent form when the button is clicked.")]
	public DialogResult DialogResult
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return dialogResult_0;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			if (Enum.IsDefined(typeof(DialogResult), value))
			{
				dialogResult_0 = value;
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public virtual bool Expanded
	{
		get
		{
			return buttonItem_0.Expanded;
		}
		set
		{
			buttonItem_0.Expanded = value;
		}
	}

	[Editor(typeof(ShortcutsDesigner), typeof(UITypeEditor))]
	[TypeConverter(typeof(ShortcutsConverter))]
	[Description("Indicates list of shortcut keys for this button.")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[Category("Design")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public virtual ShortcutsCollection Shortcuts
	{
		get
		{
			return buttonItem_0.Shortcuts;
		}
		set
		{
			buttonItem_0.Shortcuts = value;
		}
	}

	[Category("Commands")]
	[Description("Indicates the command assigned to the item.")]
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

	[Browsable(true)]
	[Category("Commands")]
	[Localizable(true)]
	[DefaultValue(null)]
	[TypeConverter(typeof(StringConverter))]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
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

	[Description("Occurs when Checked property has changed.")]
	public event EventHandler CheckedChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	public ButtonX()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_IsAccessible(true);
		((Control)this).set_AccessibleRole((AccessibleRole)43);
		((Control)this).SetStyle((ControlStyles)4352, false);
	}

	protected virtual ButtonItem CreateButtonItem()
	{
		return new ButtonItem();
	}

	protected override PopupItem CreatePopupItem()
	{
		buttonItem_0 = CreateButtonItem();
		buttonItem_0.GlobalItem = false;
		buttonItem_0.Displayed = true;
		buttonItem_0.ContainerControl = this;
		buttonItem_0.ColorTable = eButtonColor.BlueWithBackground;
		buttonItem_0.ButtonStyle = eButtonStyle.ImageAndText;
		buttonItem_0.bool_36 = true;
		buttonItem_0.Style = eDotNetBarStyle.Office2007;
		buttonItem_0.method_6(this);
		buttonItem_0.CheckedChanged += buttonItem_0_CheckedChanged;
		return buttonItem_0;
	}

	private void buttonItem_0_CheckedChanged(object sender, EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
		}
	}

	protected override AccessibleObject CreateAccessibilityInstance()
	{
		return (AccessibleObject)(object)new ButtonXAccessibleObject(this);
	}

	public void Pulse()
	{
		buttonItem_0.Pulse();
	}

	public void Pulse(int pulseBeatCount)
	{
		buttonItem_0.Pulse(pulseBeatCount);
	}

	public void StopPulse()
	{
		buttonItem_0.StopPulse();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeImageFixedSize()
	{
		return buttonItem_0.ShouldSerializeImageFixedSize();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)this).get_BackColor().IsEmpty && !(((Control)this).get_BackColor() == Color.Transparent))
		{
			Class50.smethod_24(e.get_Graphics(), ((Control)this).get_ClientRectangle(), ((Control)this).get_BackColor(), Color.Empty);
		}
		else
		{
			((Control)this).OnPaintBackground(e);
		}
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		Graphics graphics = e.get_Graphics();
		ColorScheme colorScheme = GetColorScheme();
		if (!base.IsThemed && !Class109.smethod_69(buttonItem_0.Style))
		{
			Class50.smethod_26(graphics, clientRectangle, colorScheme.BarBackground, colorScheme.BarBackground2, colorScheme.BarBackgroundGradientAngle);
			Class50.smethod_6(graphics, colorScheme.BarDockedBorder, clientRectangle);
		}
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		TextRenderingHint textRenderingHint = graphics.get_TextRenderingHint();
		ItemPaintArgs itemPaintArgs = vmethod_0(graphics);
		if (base.AntiAlias)
		{
			itemPaintArgs.Graphics.set_SmoothingMode((SmoothingMode)4);
			itemPaintArgs.Graphics.set_TextRenderingHint(Class50.TextRenderingHint_0);
		}
		IShapeDescriptor shapeDescriptor = method_11();
		if (!(shapeDescriptor is RoundRectangleShapeDescriptor))
		{
			Rectangle clientRectangle2 = ((Control)this).get_ClientRectangle();
			clientRectangle2.Y--;
			clientRectangle2.X--;
			clientRectangle2.Width++;
			clientRectangle2.Height++;
			if (shapeDescriptor.CanDrawShape(clientRectangle2))
			{
				GraphicsPath shape = shapeDescriptor.GetShape(clientRectangle2);
				try
				{
					graphics.SetClip(shape);
				}
				finally
				{
					((IDisposable)shape)?.Dispose();
				}
			}
		}
		buttonItem_0.Paint(itemPaintArgs);
		graphics.set_SmoothingMode(smoothingMode);
		graphics.set_TextRenderingHint(textRenderingHint);
	}

	protected override void OnResize(EventArgs e)
	{
		RecalcLayout();
		((Control)this).OnResize(e);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		buttonItem_0.Text = ((Control)this).get_Text();
		InvalidateAutoSize();
		AdjustSize();
		RecalcLayout();
		((Control)this).OnTextChanged(e);
	}

	protected override void OnFontChanged(EventArgs e)
	{
		base.OnFontChanged(e);
		InvalidateAutoSize();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		if (((Control)this).get_ForeColor() != SystemColors.ControlText)
		{
			buttonItem_0.ForeColor = ((Control)this).get_ForeColor();
		}
		else
		{
			buttonItem_0.ForeColor = Color.Empty;
		}
		((Control)this).OnForeColorChanged(e);
	}

	protected override void RecalcSize()
	{
		buttonItem_0.Bounds = ((Control)this).get_ClientRectangle();
		buttonItem_0.RecalcSize();
		buttonItem_0.Bounds = ((Control)this).get_ClientRectangle();
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32 && !buttonItem_0.Expanded)
		{
			if (buttonItem_0.method_35())
			{
				buttonItem_0.Expanded = true;
			}
			else
			{
				buttonItem_0.method_36(bool_49: true);
			}
			((Control)this).Invalidate();
		}
		((Control)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 32 && !buttonItem_0.Expanded)
		{
			buttonItem_0.method_36(bool_49: false);
			((Control)this).Invalidate();
			PerformClick();
		}
		((Control)this).OnKeyUp(e);
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		buttonItem_0.InternalMouseEnter();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		buttonItem_0.InternalMouseMove(e);
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		buttonItem_0.InternalMouseLeave();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseHover(EventArgs e)
	{
		buttonItem_0.InternalMouseHover();
		((Control)this).OnMouseHover(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			if (!((Control)this).get_Focused())
			{
				((Control)this).Focus();
			}
			point_0 = new Point(e.get_X(), e.get_Y());
		}
		buttonItem_0.InternalMouseDown(e);
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		buttonItem_0.InternalMouseUp(e);
		if ((int)e.get_Button() == 1048576 && ((Control)this).get_ClientRectangle().Contains(e.get_X(), e.get_Y()) && !point_0.IsEmpty)
		{
			((Control)this).OnMouseClick(e);
			((Control)this).OnClick((EventArgs)(object)e);
		}
		point_0 = Point.Empty;
		((Control)this).OnMouseUp(e);
	}

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (buttonItem_0.IsMouseOver)
		{
			buttonItem_0.InternalMouseLeave();
		}
		((Control)this).OnVisibleChanged(e);
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!buttonItem_0.Rectangle_1.IsEmpty)
		{
			Point pt = ((Control)this).PointToClient(Control.get_MousePosition());
			if (buttonItem_0.Rectangle_1.Contains(pt))
			{
				return;
			}
		}
		if (SplitButton && !buttonItem_0.Rectangle_2.IsEmpty)
		{
			Point pt2 = ((Control)this).PointToClient(Control.get_MousePosition());
			if (buttonItem_0.Rectangle_2.Contains(pt2))
			{
				return;
			}
		}
		Form val = ((Control)this).FindForm();
		if (val != null)
		{
			val.set_DialogResult(DialogResult);
		}
		((Control)this).OnClick(e);
		if (ExecuteCommandOnClick)
		{
			ExecuteCommand();
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		buttonItem_0.OnGotFocus();
		((Control)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		buttonItem_0.OnLostFocus();
		((Control)this).OnLostFocus(e);
	}

	internal override ItemPaintArgs vmethod_0(Graphics graphics_0)
	{
		ItemPaintArgs itemPaintArgs = base.vmethod_0(graphics_0);
		itemPaintArgs.bool_1 = bool_5 && bool_7;
		return itemPaintArgs;
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		if (Control.IsMnemonic(charCode, ((Control)this).get_Text()) && ((Control)this).get_Enabled() && ((Control)this).Focus())
		{
			PerformClick();
			return true;
		}
		return ((Control)this).ProcessMnemonic(charCode);
	}

	internal IShapeDescriptor method_11()
	{
		if (Shape != null)
		{
			return Shape;
		}
		return roundRectangleShapeDescriptor_0;
	}

	protected override void InvalidateAutoSize()
	{
		size_0 = Size.Empty;
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		if (!size_0.IsEmpty)
		{
			return size_0;
		}
		if (!Class109.smethod_11((Control)(object)this))
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		if (((Control)this).get_Text().Length == 0 && Image == null)
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		_ = buttonItem_0.WidthInternal;
		_ = buttonItem_0.HeightInternal;
		buttonItem_0.bool_36 = false;
		buttonItem_0.RecalcSize();
		Size size = buttonItem_0.Size;
		if (size.Width < ((Control)this).get_MinimumSize().Width)
		{
			size.Width = ((Control)this).get_MinimumSize().Width;
		}
		if (size.Height < ((Control)this).get_MinimumSize().Height)
		{
			size.Height = ((Control)this).get_MinimumSize().Height;
		}
		if ((int)autoSizeMode_0 == 1)
		{
			if (size.Width < ((Control)this).get_Size().Width)
			{
				size.Width = ((Control)this).get_Size().Width;
			}
			if (size.Height < ((Control)this).get_Size().Height)
			{
				size.Height = ((Control)this).get_Size().Height;
			}
			if (proposedSize.Width > 0 && proposedSize.Width < 50000 && size.Width < proposedSize.Width)
			{
				size.Width = proposedSize.Width;
			}
			if (proposedSize.Height > 0 && proposedSize.Height < 50000 && size.Height < proposedSize.Height)
			{
				size.Height = proposedSize.Height;
			}
		}
		buttonItem_0.bool_36 = true;
		RecalcSize();
		size_0 = size;
		return size_0;
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_AutoSize())
		{
			Size preferredSize = ((Control)this).get_PreferredSize();
			if (preferredSize.Width > 0)
			{
				width = preferredSize.Width;
			}
			if (preferredSize.Height > 0)
			{
				height = preferredSize.Height;
			}
		}
		((Control)this).SetBoundsCore(x, y, width, height, specified);
	}

	protected override void AdjustSize()
	{
		if (((Control)this).get_AutoSize())
		{
			Size preferredSize = ((Control)this).get_PreferredSize();
			if (preferredSize.Width > 0 && preferredSize.Height > 0)
			{
				((Control)this).set_Size(((Control)this).get_PreferredSize());
			}
		}
	}

	public void NotifyDefault(bool value)
	{
		if (bool_5 != value)
		{
			bool_5 = value;
			((Control)this).Invalidate();
		}
	}

	public override void PerformClick()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)this).get_Enabled())
		{
			Form val = ((Control)this).FindForm();
			if (val != null)
			{
				val.set_DialogResult(DialogResult);
			}
			if (AutoCheckOnClick)
			{
				Checked = !Checked;
			}
			buttonItem_0.method_14();
			((Control)this).OnClick(EventArgs.Empty);
		}
	}

	public virtual void Popup(Point p)
	{
		buttonItem_0.Popup(p);
	}

	public virtual void Popup(int x, int y)
	{
		buttonItem_0.Popup(x, y);
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
