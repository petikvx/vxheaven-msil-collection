using System.Drawing;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public class Office2007BarColorTable
{
	public LinearGradientColorTable ToolbarTopBackground = new LinearGradientColorTable(ColorScheme.GetColor("D7E6F9"), ColorScheme.GetColor("C7DCF8"));

	public LinearGradientColorTable ToolbarBottomBackground = new LinearGradientColorTable(ColorScheme.GetColor("B3D0F5"), ColorScheme.GetColor("D7E5F7"));

	public Color ToolbarBottomBorder = ColorScheme.GetColor("BAD4F7");

	public LinearGradientColorTable PopupToolbarBackground = new LinearGradientColorTable(ColorScheme.GetColor("FAFAFA"), Color.Empty);

	public Color PopupToolbarBorder = ColorScheme.GetColor("868686");

	public Color StatusBarTopBorder = Color.Empty;

	public Color StatusBarTopBorderLight = Color.Empty;

	public BackgroundColorBlendCollection StatusBarAltBackground = new BackgroundColorBlendCollection();
}
