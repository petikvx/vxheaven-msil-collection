using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(LabelXDesigner))]
[ComVisible(false)]
[ToolboxBitmap(typeof(LabelX), "Controls.LabelX.ico")]
[ToolboxItem(true)]
public class LabelX : BaseItemControl, ICommandSource
{
	private LabelItem labelItem_0;

	private bool bool_4 = true;

	private Size size_0 = Size.Empty;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private ICommand icommand_0;

	private object object_0;

	[Category("Appearance")]
	[DefaultValue(true)]
	[Description("Indicates whether text-markup support is enabled for controls Text property.")]
	public bool EnableMarkup
	{
		get
		{
			return labelItem_0.EnableMarkup;
		}
		set
		{
			labelItem_0.EnableMarkup = value;
		}
	}

	[Category("Behavior")]
	[DefaultValue(false)]
	[Description("Indicates whether control displays focus cues when focused.")]
	public override bool FocusCuesEnabled
	{
		get
		{
			return base.FocusCuesEnabled;
		}
		set
		{
			base.FocusCuesEnabled = value;
		}
	}

	[Description("Specifies border sides that are displayed.")]
	[Browsable(false)]
	[Category("Appearance")]
	[DefaultValue(eBorderSide.All)]
	public eBorderSide BorderSide
	{
		get
		{
			return labelItem_0.BorderSide;
		}
		set
		{
			labelItem_0.BorderSide = value;
			method_1();
		}
	}

	[Browsable(false)]
	[Category("Appearance")]
	[Description("Indicates the type of the border drawn around the label.")]
	[DefaultValue(eBorderType.None)]
	public eBorderType BorderType
	{
		get
		{
			return labelItem_0.BorderType;
		}
		set
		{
			labelItem_0.BorderType = value;
			method_1();
		}
	}

	[Description("The image that will be displayed on the face of the item.")]
	[DefaultValue(null)]
	[Browsable(true)]
	[Category("Appearance")]
	public Image Image
	{
		get
		{
			return labelItem_0.Image;
		}
		set
		{
			labelItem_0.Image = value;
			method_1();
		}
	}

	[Browsable(true)]
	[Description("The alignment of the image in relation to text displayed by this item.")]
	[Category("Appearance")]
	[DefaultValue(eImagePosition.Left)]
	public eImagePosition ImagePosition
	{
		get
		{
			return labelItem_0.ImagePosition;
		}
		set
		{
			labelItem_0.ImagePosition = value;
			method_1();
		}
	}

	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates border line color when border is single line.")]
	public Color SingleLineColor
	{
		get
		{
			return labelItem_0.SingleLineColor;
		}
		set
		{
			labelItem_0.SingleLineColor = value;
		}
	}

	[Editor(typeof(TextMarkupUIEditor), typeof(UITypeEditor))]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("The text contained in the item.")]
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

	[Description("Indicates text alignment.")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Layout")]
	public StringAlignment TextAlignment
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return labelItem_0.TextAlignment;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			labelItem_0.TextAlignment = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[DevCoBrowsable(true)]
	[Category("Layout")]
	[Description("Indicates text line alignment.")]
	[Browsable(true)]
	public StringAlignment TextLineAlignment
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return labelItem_0.TextLineAlignment;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			labelItem_0.TextLineAlignment = value;
		}
	}

	[DefaultValue(false)]
	[Description("Gets or sets a value that determines whether text is displayed in multiple lines or one long line.")]
	[Category("Style")]
	[Browsable(true)]
	public bool WordWrap
	{
		get
		{
			return labelItem_0.WordWrap;
		}
		set
		{
			labelItem_0.WordWrap = value;
			RecalcLayout();
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

	[DefaultValue(0)]
	[Description("Indicates left padding in pixels.")]
	[Category("Layout")]
	[Browsable(true)]
	public int PaddingLeft
	{
		get
		{
			return labelItem_0.PaddingLeft;
		}
		set
		{
			labelItem_0.PaddingLeft = value;
			method_1();
		}
	}

	[Browsable(true)]
	[Category("Layout")]
	[DefaultValue(0)]
	[Description("Indicates right padding in pixels.")]
	public int PaddingRight
	{
		get
		{
			return labelItem_0.PaddingRight;
		}
		set
		{
			labelItem_0.PaddingRight = value;
			method_1();
		}
	}

	[Category("Layout")]
	[DefaultValue(0)]
	[Description("Indicates top padding in pixels.")]
	[Browsable(true)]
	public int PaddingTop
	{
		get
		{
			return labelItem_0.PaddingTop;
		}
		set
		{
			labelItem_0.PaddingTop = value;
			method_1();
		}
	}

	[DefaultValue(0)]
	[Description("Indicates bottom padding in pixels.")]
	[Browsable(true)]
	[Category("Layout")]
	public int PaddingBottom
	{
		get
		{
			return labelItem_0.PaddingBottom;
		}
		set
		{
			labelItem_0.PaddingBottom = value;
			method_1();
		}
	}

	[Description("Indicates whether the control interprets an ampersand character (&) in the control's Text property to be an access key prefix character.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool UseMnemonic
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
			method_1();
			((Control)this).Invalidate();
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

	[EditorBrowsable(EditorBrowsableState.Always)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(false)]
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
				method_3();
			}
		}
	}

	[DefaultValue(null)]
	[Category("Commands")]
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
	[Category("Commands")]
	[TypeConverter(typeof(StringConverter))]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Localizable(true)]
	[Browsable(true)]
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

	public event MarkupLinkClickEventHandler MarkupLinkClick
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Combine(markupLinkClickEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			markupLinkClickEventHandler_0 = (MarkupLinkClickEventHandler)Delegate.Remove(markupLinkClickEventHandler_0, value);
		}
	}

	public LabelX()
	{
		labelItem_0 = new LabelItem();
		labelItem_0.Style = eDotNetBarStyle.Office2007;
		labelItem_0.MarkupLinkClick += labelItem_0_MarkupLinkClick;
		FocusCuesEnabled = false;
		HostItem = labelItem_0;
		TabStop = false;
		((Control)this).SetStyle((ControlStyles)512, false);
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (((Control)this).get_AutoSize())
		{
			method_3();
		}
		RecalcLayout();
		((Control)this).OnHandleCreated(e);
	}

	protected override void RecalcSize()
	{
		labelItem_0.bool_26 = true;
		labelItem_0.Width = labelItem_0.Bounds.Width;
		labelItem_0.Height = labelItem_0.Bounds.Height;
		labelItem_0.bool_26 = false;
		base.RecalcSize();
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		labelItem_0.BackColor = ((Control)this).get_BackColor();
		((Control)this).OnBackColorChanged(e);
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		labelItem_0.ForeColor = ((Control)this).get_ForeColor();
		((Control)this).OnForeColorChanged(e);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeSingleLineColor()
	{
		return labelItem_0.ShouldSerializeSingleLineColor();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetSingleLineColor()
	{
		labelItem_0.ResetSingleLineColor();
	}

	private void labelItem_0_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
	{
		OnMarkupLinkClick(e);
	}

	protected virtual void OnMarkupLinkClick(MarkupLinkClickEventArgs e)
	{
		if (markupLinkClickEventHandler_0 != null)
		{
			markupLinkClickEventHandler_0(this, e);
		}
	}

	private void method_1()
	{
		size_0 = Size.Empty;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (bool_4)
		{
			labelItem_0.Boolean_3 = true;
		}
		else
		{
			labelItem_0.Boolean_3 = false;
		}
		base.OnPaint(e);
	}

	private bool method_2()
	{
		if (((Control)this).get_Enabled() && ((Control)this).get_Visible())
		{
			return true;
		}
		return false;
	}

	protected override bool ProcessMnemonic(char charCode)
	{
		if (UseMnemonic && Control.IsMnemonic(charCode, ((Control)this).get_Text()) && method_2())
		{
			Control parent = ((Control)this).get_Parent();
			if (parent != null && parent.SelectNextControl((Control)(object)this, true, false, true, false) && !parent.get_ContainsFocus())
			{
				parent.Focus();
			}
			return true;
		}
		return false;
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (!size_0.IsEmpty)
		{
			return size_0;
		}
		if (!Class109.smethod_11((Control)(object)this))
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		if (((Control)this).get_Text().Length == 0)
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		int width = labelItem_0.Width;
		int height = labelItem_0.Height;
		labelItem_0.bool_26 = true;
		labelItem_0.Width = 0;
		labelItem_0.Height = 0;
		if (((proposedSize.Width > 0 && proposedSize.Width < 500000) || ((Control)this).get_MaximumSize().Width > 0) && labelItem_0.Class261_0 != null)
		{
			labelItem_0.method_22((((Control)this).get_MaximumSize().Width > 0) ? ((Control)this).get_MaximumSize().Width : proposedSize.Width);
		}
		else
		{
			labelItem_0.RecalcSize();
			if (WordWrap && labelItem_0.WidthInternal > ((Control)this).get_MaximumSize().Width && ((Control)this).get_MaximumSize().Width > 0)
			{
				labelItem_0.Height = 0;
				labelItem_0.Width = ((Control)this).get_MaximumSize().Width;
				labelItem_0.RecalcSize();
			}
		}
		Size size = labelItem_0.Size;
		size.Height += 2;
		labelItem_0.Width = width;
		labelItem_0.Height = height;
		labelItem_0.bool_26 = false;
		size_0 = size;
		return size_0;
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

	protected override void OnFontChanged(EventArgs e)
	{
		method_1();
		base.OnFontChanged(e);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		method_1();
		base.OnTextChanged(e);
		method_3();
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
