using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007ItemGroupColorTable
{
	public LinearGradientColorTable OuterBorder = new LinearGradientColorTable(ColorScheme.GetColor("99B6E0"), ColorScheme.GetColor("7394BD"));

	public LinearGradientColorTable InnerBorder = new LinearGradientColorTable(ColorScheme.GetColor("D5E3F1"), ColorScheme.GetColor("E3EDFB"));

	public LinearGradientColorTable TopBackground = new LinearGradientColorTable(ColorScheme.GetColor("C8DBEE"), ColorScheme.GetColor("C9DDF6"));

	public LinearGradientColorTable BottomBackground = new LinearGradientColorTable(ColorScheme.GetColor("BCD0E9"), ColorScheme.GetColor("D0E1F7"));

	public Color ItemGroupDividerDark = Color.FromArgb(196, ColorScheme.GetColor("B8C8DC"));

	public Color ItemGroupDividerLight = Color.FromArgb(128, ColorScheme.GetColor("FFFFFF"));
}
