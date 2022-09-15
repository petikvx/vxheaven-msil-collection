using System.Drawing;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class278 : BlockLayoutManager
{
	private Class263 class263_0;

	public Class263 Class263_0
	{
		get
		{
			return class263_0;
		}
		set
		{
			class263_0 = value;
		}
	}

	public override void Layout(IBlock block, Size availableSize)
	{
		if (block is Class245)
		{
			Class245 @class = block as Class245;
			if (!@class.IsSizeValid)
			{
				@class.Measure(availableSize, class263_0);
			}
		}
	}
}
