using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Controls;

[ToolboxBitmap(typeof(Slider), "Controls.Slider.ico")]
[ComVisible(false)]
[ToolboxItem(true)]
[DefaultEvent("ValueChanged")]
public class Slider : BaseItemControl, ICommandSource
{
	private SliderItem sliderItem_0;

	private EventHandler eventHandler_0;

	private CancelIntValueEventHandler cancelIntValueEventHandler_0;

	private ICommand icommand_0;

	private object object_0;

	[Category("Appearance")]
	[Description("Indicates whether text-markup support is enabled for controls Text property.")]
	[DefaultValue(true)]
	public bool EnableMarkup
	{
		get
		{
			return sliderItem_0.EnableMarkup;
		}
		set
		{
			sliderItem_0.EnableMarkup = value;
		}
	}

	[DefaultValue(eSliderLabelPosition.Left)]
	[Browsable(true)]
	[Description("Indicates text label position in relationship to the slider")]
	[Category("Layout")]
	public eSliderLabelPosition LabelPosition
	{
		get
		{
			return sliderItem_0.LabelPosition;
		}
		set
		{
			sliderItem_0.LabelPosition = value;
		}
	}

	[DefaultValue(true)]
	[Description("Gets or sets whether the label text is displayed.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool LabelVisible
	{
		get
		{
			return sliderItem_0.LabelVisible;
		}
		set
		{
			sliderItem_0.LabelVisible = value;
		}
	}

	[Category("Layout")]
	[DevCoBrowsable(true)]
	[DefaultValue(38)]
	[Browsable(true)]
	[Description("Indicates width of the label part of the item in pixels.")]
	public int LabelWidth
	{
		get
		{
			return sliderItem_0.LabelWidth;
		}
		set
		{
			sliderItem_0.LabelWidth = value;
		}
	}

	[Browsable(true)]
	[Description("Gets or sets the maximum value of the range of the control.")]
	[Category("Behavior")]
	[DevCoBrowsable(true)]
	[DefaultValue(100)]
	public int Maximum
	{
		get
		{
			return sliderItem_0.Maximum;
		}
		set
		{
			sliderItem_0.Maximum = value;
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	[Description("Gets or sets the minimum value of the range of the control.")]
	[Browsable(true)]
	[Category("Behavior")]
	public int Minimum
	{
		get
		{
			return sliderItem_0.Minimum;
		}
		set
		{
			sliderItem_0.Minimum = value;
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets the current position of the slider.")]
	[Category("Behavior")]
	[Browsable(true)]
	public int Value
	{
		get
		{
			return sliderItem_0.Value;
		}
		set
		{
			sliderItem_0.Value = value;
		}
	}

	[Description("Gets or sets the amount by which a call to the PerformStep method increases the current position of the slider.")]
	[DefaultValue(1)]
	[Category("Behavior")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public int Step
	{
		get
		{
			return sliderItem_0.Step;
		}
		set
		{
			sliderItem_0.Step = value;
		}
	}

	[Category("Appearance")]
	[Description("Indicates color of the label text.")]
	[Browsable(true)]
	public Color TextColor
	{
		get
		{
			return sliderItem_0.TextColor;
		}
		set
		{
			sliderItem_0.TextColor = value;
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

	[DefaultValue(true)]
	[Category("Appearance")]
	[Description("Indicates whether vertical line track marker is displayed on the slide line.")]
	[Browsable(true)]
	public virtual bool TrackMarker
	{
		get
		{
			return sliderItem_0.TrackMarker;
		}
		set
		{
			sliderItem_0.TrackMarker = value;
		}
	}

	[Description("Indicates tooltip for the Increase button of the slider.")]
	[Category("Appearance")]
	[Localizable(true)]
	[Browsable(true)]
	[DefaultValue("")]
	public string IncreaseTooltip
	{
		get
		{
			return sliderItem_0.IncreaseTooltip;
		}
		set
		{
			sliderItem_0.IncreaseTooltip = value;
		}
	}

	[DefaultValue("")]
	[Category("Appearance")]
	[Browsable(true)]
	[Description("Indicates tooltip for the Increase button of the slider.")]
	[Localizable(true)]
	public string DecreaseTooltip
	{
		get
		{
			return sliderItem_0.DecreaseTooltip;
		}
		set
		{
			sliderItem_0.DecreaseTooltip = value;
		}
	}

	[Category("Appearance")]
	[Description("Indicates slider orientation.")]
	[DefaultValue(eOrientation.Horizontal)]
	public eOrientation SliderOrientation
	{
		get
		{
			return sliderItem_0.SliderOrientation;
		}
		set
		{
			sliderItem_0.SliderOrientation = value;
			RecalcLayout();
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

	[DefaultValue(null)]
	[Description("Indicates user defined data value that can be passed to the command when it is executed.")]
	[Category("Commands")]
	[Browsable(true)]
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

	public event CancelIntValueEventHandler ValueChanging
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelIntValueEventHandler_0 = (CancelIntValueEventHandler)Delegate.Combine(cancelIntValueEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelIntValueEventHandler_0 = (CancelIntValueEventHandler)Delegate.Remove(cancelIntValueEventHandler_0, value);
		}
	}

	public Slider()
	{
		sliderItem_0 = new SliderItem();
		sliderItem_0.Style = eDotNetBarStyle.Office2007;
		sliderItem_0.ValueChanged += sliderItem_0_ValueChanged;
		sliderItem_0.ValueChanging += sliderItem_0_ValueChanging;
		HostItem = sliderItem_0;
	}

	private void sliderItem_0_ValueChanging(object sender, CancelIntValueEventArgs e)
	{
		OnValueChanging(e);
	}

	private void sliderItem_0_ValueChanged(object sender, EventArgs e)
	{
		OnValueChanged(e);
		ExecuteCommand();
	}

	protected virtual void OnValueChanged(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	protected virtual void OnValueChanging(CancelIntValueEventArgs e)
	{
		if (cancelIntValueEventHandler_0 != null)
		{
			cancelIntValueEventHandler_0(this, e);
		}
	}

	public void PerformStep()
	{
		sliderItem_0.PerformStep();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTextColor()
	{
		return sliderItem_0.ShouldSerializeTextColor();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetTextColor()
	{
		sliderItem_0.ResetTextColor();
	}

	public override void RecalcLayout()
	{
		Rectangle itemBounds = GetItemBounds();
		sliderItem_0.Width = Math.Max(itemBounds.Width - (sliderItem_0.LabelVisible ? sliderItem_0.LabelWidth : 0), 30);
		base.RecalcLayout();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 37)
		{
			sliderItem_0.Increment(-sliderItem_0.Step);
			return true;
		}
		if ((int)keyData == 39)
		{
			sliderItem_0.Increment(sliderItem_0.Step);
			return true;
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
