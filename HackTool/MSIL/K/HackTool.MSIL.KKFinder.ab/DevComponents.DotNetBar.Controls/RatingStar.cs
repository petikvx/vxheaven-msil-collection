using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevComponents.Editors;

namespace DevComponents.DotNetBar.Controls;

[ToolboxBitmap(typeof(RatingStar), "Controls.RatingStar.ico")]
[DefaultEvent("RatingChanged")]
[ToolboxItem(true)]
[ComVisible(true)]
public class RatingStar : BaseItemControl, ICommandSource
{
	private RatingItem ratingItem_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private RatingChangeEventHandler ratingChangeEventHandler_0;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	private MarkupLinkClickEventHandler markupLinkClickEventHandler_0;

	private ParseIntegerValueEventHandler parseIntegerValueEventHandler_0;

	private ParseDoubleValueEventHandler parseDoubleValueEventHandler_0;

	private ICommand icommand_0;

	private object object_0;

	[Category("Data")]
	[Description("Indicates rating value represented by the control.")]
	[DefaultValue(0)]
	public int Rating
	{
		get
		{
			return ratingItem_0.Rating;
		}
		set
		{
			ratingItem_0.Rating = value;
		}
	}

	[DefaultValue(0.0)]
	[Description("Indicates average rating shown by control.")]
	[Category("Data")]
	public double AverageRating
	{
		get
		{
			return ratingItem_0.AverageRating;
		}
		set
		{
			ratingItem_0.AverageRating = value;
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[Browsable(false)]
	[Bindable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[TypeConverter(typeof(StringConverter))]
	public object AverageRatingValue
	{
		get
		{
			return ratingItem_0.AverageRatingValue;
		}
		set
		{
			ratingItem_0.AverageRatingValue = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Category("Images")]
	[Browsable(true)]
	[Description("Gets the reference to custom rating images.")]
	public RatingImages CustomImages => ratingItem_0.CustomImages;

	[Description("Indicates whether text assigned to the check box is visible.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(true)]
	public bool TextVisible
	{
		get
		{
			return ratingItem_0.TextVisible;
		}
		set
		{
			ratingItem_0.TextVisible = value;
		}
	}

	[Description("Indicates whether text-markup support is enabled for items Text property.")]
	[DefaultValue(true)]
	[Category("Appearance")]
	public bool EnableMarkup
	{
		get
		{
			return ratingItem_0.EnableMarkup;
		}
		set
		{
			ratingItem_0.EnableMarkup = value;
		}
	}

	[Description("Indicates whether rating can be edited.")]
	[DefaultValue(true)]
	[Category("Behavior")]
	public bool IsEditable
	{
		get
		{
			return ratingItem_0.IsEditable;
		}
		set
		{
			ratingItem_0.IsEditable = value;
		}
	}

	[Description("Gets or sets the orientation of rating control.")]
	[DefaultValue(eOrientation.Horizontal)]
	[Category("Appearance")]
	public eOrientation RatingOrientation
	{
		get
		{
			return ratingItem_0.RatingOrientation;
		}
		set
		{
			ratingItem_0.RatingOrientation = value;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[RefreshProperties(RefreshProperties.All)]
	[Bindable(true)]
	public object RatingValue
	{
		get
		{
			return ratingItem_0.RatingValue;
		}
		set
		{
			ratingItem_0.RatingValue = value;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[Description("Indicates text color.")]
	public Color TextColor
	{
		get
		{
			return ratingItem_0.TextColor;
		}
		set
		{
			ratingItem_0.TextColor = value;
		}
	}

	[Description("Gets or sets the spacing between optional text and the rating.")]
	[DefaultValue(0)]
	[Category("Appearance")]
	public int TextSpacing
	{
		get
		{
			return ratingItem_0.TextSpacing;
		}
		set
		{
			ratingItem_0.TextSpacing = value;
		}
	}

	[Localizable(true)]
	[Browsable(false)]
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

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DefaultValue(false)]
	[EditorBrowsable(EditorBrowsableState.Always)]
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
				method_1();
			}
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

	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Browsable(true)]
	[DefaultValue(null)]
	[Category("Commands")]
	[Localizable(true)]
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

	[Description("Occurs when Rating property has changed.")]
	public event EventHandler RatingChanged
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

	[Description("Occurs when Rating property has changed.")]
	public event EventHandler RatingValueChanged
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

	[Description("Occurs when Rating property has changed.")]
	public event RatingChangeEventHandler RatingChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			ratingChangeEventHandler_0 = (RatingChangeEventHandler)Delegate.Combine(ratingChangeEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			ratingChangeEventHandler_0 = (RatingChangeEventHandler)Delegate.Remove(ratingChangeEventHandler_0, value);
		}
	}

	[Description("Occurs when AverageRating property has changed.")]
	public event EventHandler AverageRatingChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	[Description("Occurs when AverageRatingValue property has changed.")]
	public event EventHandler AverageRatingValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
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

	public event ParseIntegerValueEventHandler ParseRatingValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseIntegerValueEventHandler_0 = (ParseIntegerValueEventHandler)Delegate.Combine(parseIntegerValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseIntegerValueEventHandler_0 = (ParseIntegerValueEventHandler)Delegate.Remove(parseIntegerValueEventHandler_0, value);
		}
	}

	public event ParseDoubleValueEventHandler ParseAverageRatingValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			parseDoubleValueEventHandler_0 = (ParseDoubleValueEventHandler)Delegate.Combine(parseDoubleValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			parseDoubleValueEventHandler_0 = (ParseDoubleValueEventHandler)Delegate.Remove(parseDoubleValueEventHandler_0, value);
		}
	}

	public RatingStar()
	{
		((Control)this).SetStyle((ControlStyles)512, false);
		ratingItem_0 = new RatingItem();
		ratingItem_0.Style = eDotNetBarStyle.Office2007;
		ratingItem_0.RatingChanging += ratingItem_0_RatingChanging;
		ratingItem_0.RatingChanged += ratingItem_0_RatingChanged;
		ratingItem_0.AverageRatingChanged += ratingItem_0_AverageRatingChanged;
		ratingItem_0.ParseAverageRatingValue += ratingItem_0_ParseAverageRatingValue;
		ratingItem_0.ParseRatingValue += ratingItem_0_ParseRatingValue;
		HostItem = ratingItem_0;
	}

	private void ratingItem_0_ParseRatingValue(object sender, ParseIntegerValueEventArgs e)
	{
		OnParseRatingValue(e);
	}

	protected virtual void OnParseRatingValue(ParseIntegerValueEventArgs e)
	{
		if (parseIntegerValueEventHandler_0 != null)
		{
			parseIntegerValueEventHandler_0(this, e);
		}
	}

	private void ratingItem_0_ParseAverageRatingValue(object sender, ParseDoubleValueEventArgs e)
	{
		OnParseAverageRatingValue(e);
	}

	protected virtual void OnParseAverageRatingValue(ParseDoubleValueEventArgs e)
	{
		if (parseDoubleValueEventHandler_0 != null)
		{
			parseDoubleValueEventHandler_0(this, e);
		}
	}

	private void ratingItem_0_AverageRatingChanged(object sender, EventArgs e)
	{
		OnAverageRatingChanged(e);
	}

	protected virtual void OnAverageRatingChanged(EventArgs eventArgs)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, eventArgs);
		}
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, eventArgs);
		}
	}

	private void ratingItem_0_RatingChanged(object sender, EventArgs e)
	{
		OnRatingChanged(e);
	}

	protected virtual void OnRatingChanged(EventArgs eventArgs)
	{
		eventHandler_0?.Invoke(this, eventArgs);
		eventHandler_1?.Invoke(this, eventArgs);
	}

	private void ratingItem_0_RatingChanging(object sender, RatingChangeEventArgs e)
	{
		OnRatingChanging(e);
	}

	protected virtual void OnRatingChanging(RatingChangeEventArgs e)
	{
		if (ratingChangeEventHandler_0 != null)
		{
			ratingChangeEventHandler_0(this, e);
		}
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		if (!Class109.smethod_11((Control)(object)this))
		{
			return ((Control)this).GetPreferredSize(proposedSize);
		}
		ratingItem_0.RecalcSize();
		Size size = ratingItem_0.Size;
		size.Width += 2;
		size.Height += 2;
		if (!TextVisible)
		{
			size.Width += 2;
		}
		size.Width += Class52.smethod_1(GetBackgroundStyle());
		size.Height += Class52.smethod_2(GetBackgroundStyle());
		ratingItem_0.Bounds = GetItemBounds();
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

	private void method_1()
	{
		if (((Control)this).get_AutoSize())
		{
			((Control)this).set_Size(((Control)this).get_PreferredSize());
		}
	}

	protected override void OnVisualPropertyChanged()
	{
		base.OnVisualPropertyChanged();
		method_1();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		base.OnTextChanged(e);
		method_1();
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		if (((Control)this).get_AutoSize())
		{
			method_1();
		}
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
