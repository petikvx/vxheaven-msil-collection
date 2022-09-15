using System.Drawing;

namespace DevComponents.UI.ContentManager;

public interface IBlock
{
	Rectangle Bounds { get; set; }

	bool Visible { get; set; }
}
