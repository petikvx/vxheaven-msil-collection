using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007TabColorTable
{
	public Office2007TabItemStateColorTable Default = new Office2007TabItemStateColorTable();

	public Office2007TabItemStateColorTable MouseOver = new Office2007TabItemStateColorTable();

	public Office2007TabItemStateColorTable Selected = new Office2007TabItemStateColorTable();

	public LinearGradientColorTable TabBackground = new LinearGradientColorTable();

	public LinearGradientColorTable TabPanelBackground = new LinearGradientColorTable();

	public Color TabPanelBorder = Color.Empty;
}
