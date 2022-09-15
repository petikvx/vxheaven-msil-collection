using System.Drawing;

namespace DevComponents.DotNetBar;

public interface ISimpleElement
{
	Rectangle Bounds { get; set; }

	int FixedWidth { get; set; }

	bool ImageVisible { get; }

	Size ImageLayoutSize { get; }

	eSimplePartAlignment ImageAlignment { get; set; }

	Rectangle ImageBounds { get; set; }

	int ImageTextSpacing { get; }

	bool TextVisible { get; }

	string Text { get; set; }

	Rectangle TextBounds { get; set; }

	Image Image { get; set; }
}
