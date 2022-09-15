using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
[TypeConverter(typeof(DocumentBarContainerConverter))]
public class DocumentBarContainer : DocumentBaseContainer
{
	private Bar bar_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Bar Bar
	{
		get
		{
			return bar_0;
		}
		set
		{
			bar_0 = value;
		}
	}

	public override bool Visible
	{
		get
		{
			if (bar_0 == null)
			{
				return false;
			}
			if (bar_0.method_75())
			{
				return true;
			}
			return bar_0.Boolean_8;
		}
	}

	protected internal override Size MinimumSize => bar_0.method_134(bar_0.MinimumDockSize(eOrientation.Horizontal));

	public DocumentBarContainer()
	{
	}

	public DocumentBarContainer(Bar bar)
	{
		bar_0 = bar;
		if (bar_0.Int32_0 > 0 || bar_0.Int32_1 > 0)
		{
			method_1(new Rectangle(0, 0, bar_0.Int32_1, bar_0.Int32_0));
		}
	}

	public DocumentBarContainer(Bar bar, int proposedWidth, int proposedHeight)
	{
		bar_0 = bar;
		method_1(new Rectangle(0, 0, proposedWidth, proposedHeight));
	}

	public override void Layout(Rectangle bounds)
	{
		if (bar_0 != null)
		{
			bar_0.Int32_0 = 0;
			bar_0.Int32_1 = 0;
			bar_0.Int32_2 = 0;
			bar_0.method_27(bounds.Size);
			bar_0.Location = bounds.Location;
		}
		method_0(bounds);
	}
}
