using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class253 : Class245
{
	public override bool IsSizeValid
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override bool IsNewLineAfterElement => true;

	public override void Measure(Size availableSize, Class263 d)
	{
		base.Bounds = new Rectangle(0, 0, 0, d.font_0.get_Height());
	}

	public override void Render(Class263 d)
	{
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
	}
}
