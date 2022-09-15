using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007RibbonTabGroupColorTable
{
	public string Name = "";

	public LinearGradientColorTable Background = new LinearGradientColorTable(ColorScheme.GetColor(13294579), ColorScheme.GetColor(13483991));

	public LinearGradientColorTable BackgroundHighlight = new LinearGradientColorTable(Color.FromArgb(192, ColorScheme.GetColor(13658313)), Color.Transparent);

	public Color Text = ColorScheme.GetColor(1393291);

	public LinearGradientColorTable Border = new LinearGradientColorTable(Color.FromArgb(16, Color.DarkGray), Color.FromArgb(192, Color.DarkGray));
}
