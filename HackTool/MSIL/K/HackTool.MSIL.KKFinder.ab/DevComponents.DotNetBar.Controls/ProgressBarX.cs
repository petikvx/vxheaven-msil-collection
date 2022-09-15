using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Controls;

[ToolboxItem(true)]
[ComVisible(false)]
[DefaultEvent("Click")]
[ToolboxBitmap(typeof(ProgressBarX), "Controls.ProgressBarX.ico")]
public class ProgressBarX : BaseItemControl
{
	private ProgressBarItem progressBarItem_0;

	[Description("Gets or sets the maximum value of the range of the control.")]
	[Browsable(true)]
	[DefaultValue(100)]
	[Category("Behavior")]
	public int Maximum
	{
		get
		{
			return progressBarItem_0.Maximum;
		}
		set
		{
			progressBarItem_0.Maximum = value;
		}
	}

	[DefaultValue(0)]
	[Description("Gets or sets the minimum value of the range of the control.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	[Category("Behavior")]
	public int Minimum
	{
		get
		{
			return progressBarItem_0.Minimum;
		}
		set
		{
			progressBarItem_0.Minimum = value;
		}
	}

	[DevCoBrowsable(true)]
	[Category("Behavior")]
	[Browsable(true)]
	[Description("Gets or sets the current position of the progress bar.")]
	[DefaultValue(0)]
	public int Value
	{
		get
		{
			return progressBarItem_0.Value;
		}
		set
		{
			progressBarItem_0.Value = value;
		}
	}

	[DevCoBrowsable(true)]
	[Description("Gets or sets the amount by which a call to the PerformStep method increases the current position of the progress bar.")]
	[Browsable(true)]
	[DefaultValue(1)]
	[Category("Behavior")]
	public int Step
	{
		get
		{
			return progressBarItem_0.Step;
		}
		set
		{
			progressBarItem_0.Step = value;
		}
	}

	[Browsable(true)]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Description("Gets or sets the color of the progress chunk.")]
	public Color ChunkColor
	{
		get
		{
			return progressBarItem_0.ChunkColor;
		}
		set
		{
			progressBarItem_0.ChunkColor = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Gets or sets the target gradient color of the progress chunk.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public Color ChunkColor2
	{
		get
		{
			return progressBarItem_0.ChunkColor2;
		}
		set
		{
			progressBarItem_0.ChunkColor2 = value;
			((Control)this).Invalidate();
		}
	}

	[Category("Appearance")]
	[Description("Gets or sets the gradient angle of the progress chunk.")]
	[DevCoBrowsable(true)]
	[DefaultValue(0)]
	[Browsable(true)]
	public int ChunkGradientAngle
	{
		get
		{
			return (int)progressBarItem_0.ChunkGradientAngle;
		}
		set
		{
			progressBarItem_0.ChunkGradientAngle = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Gets or sets whether the text inside the progress bar is displayed.")]
	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(false)]
	public bool TextVisible
	{
		get
		{
			return progressBarItem_0.TextVisible;
		}
		set
		{
			progressBarItem_0.TextVisible = value;
			((Control)this).Invalidate();
		}
	}

	[Description("Indicates type of progress bar used to indicate progress.")]
	[Browsable(true)]
	[Category("Behavior")]
	[DefaultValue(eProgressItemType.Standard)]
	public eProgressItemType ProgressType
	{
		get
		{
			return progressBarItem_0.ProgressType;
		}
		set
		{
			progressBarItem_0.ProgressType = value;
		}
	}

	[Browsable(true)]
	[Category("Behavior")]
	[Description("Indicates marquee animation speed in milliseconds.")]
	[DefaultValue(100)]
	public int MarqueeAnimationSpeed
	{
		get
		{
			return progressBarItem_0.MarqueeAnimationSpeed;
		}
		set
		{
			progressBarItem_0.MarqueeAnimationSpeed = value;
		}
	}

	[Description("Indicates predefined color of item when Office 2007 style is used.")]
	[DevCoBrowsable(false)]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eProgressBarItemColor.Normal)]
	public eProgressBarItemColor ColorTable
	{
		get
		{
			return progressBarItem_0.ColorTable;
		}
		set
		{
			progressBarItem_0.ColorTable = value;
		}
	}

	[DefaultValue(eOrientation.Horizontal)]
	public eOrientation Orientation
	{
		get
		{
			return progressBarItem_0.Orientation;
		}
		set
		{
			if (progressBarItem_0.Orientation != value)
			{
				progressBarItem_0.Orientation = value;
				((Control)this).Invalidate();
			}
		}
	}

	public ProgressBarX()
	{
		progressBarItem_0 = new ProgressBarItem();
		progressBarItem_0.Style = eDotNetBarStyle.Office2007;
		progressBarItem_0.Minimum = 0;
		progressBarItem_0.Maximum = 100;
		progressBarItem_0.Value = 0;
		progressBarItem_0.BackStyle = base.BackgroundStyle;
		HostItem = progressBarItem_0;
	}

	protected override void PaintBackground(PaintEventArgs e)
	{
		Graphics graphics = e.get_Graphics();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		ElementStyle backgroundStyle = GetBackgroundStyle();
		if ((!backgroundStyle.Custom || backgroundStyle.BackColor.IsEmpty) && !((Control)this).get_BackColor().IsEmpty && ((Control)this).get_BackColor() != Color.Transparent)
		{
			Class50.smethod_23(graphics, clientRectangle, ((Control)this).get_BackColor());
		}
	}

	public void PerformStep()
	{
		Value += progressBarItem_0.Step;
	}

	public void Increment(int value)
	{
		Value += value;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeChunkColor()
	{
		return !progressBarItem_0.ChunkColor.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetChunkColor()
	{
		progressBarItem_0.ChunkColor = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeChunkColor2()
	{
		return !progressBarItem_0.ChunkColor2.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetChunkColor2()
	{
		progressBarItem_0.ChunkColor2 = Color.Empty;
	}
}
