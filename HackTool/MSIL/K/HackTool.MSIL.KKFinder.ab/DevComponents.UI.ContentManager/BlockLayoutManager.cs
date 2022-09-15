using System.Drawing;

namespace DevComponents.UI.ContentManager;

public abstract class BlockLayoutManager
{
	private Graphics graphics_0;

	public Graphics Graphics
	{
		get
		{
			return graphics_0;
		}
		set
		{
			graphics_0 = value;
		}
	}

	public BlockLayoutManager()
	{
	}

	public abstract void Layout(IBlock block, Size availableSize);
}
