using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007RibbonBarStateColorTable
{
	public int TopBackgroundHeight = 15;

	public LinearGradientColorTable OuterBorder = new LinearGradientColorTable(13030111, 10469851);

	public LinearGradientColorTable InnerBorder = new LinearGradientColorTable(15725818, 15989247);

	public LinearGradientColorTable TopBackground = new LinearGradientColorTable(14608629, 13754352);

	public LinearGradientColorTable BottomBackground = new LinearGradientColorTable(13097197, 15201023);

	public LinearGradientColorTable TitleBackground = new LinearGradientColorTable(12769777, 12704240);

	public Color TitleText = ColorScheme.GetColor(4090538);
}
