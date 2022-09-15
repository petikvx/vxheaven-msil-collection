using System.Drawing;

namespace DevComponents.UI.ContentManager;

public interface IContentLayout
{
	Rectangle Layout(Rectangle containerBounds, IBlock[] contentBlocks, BlockLayoutManager blockLayout);
}
