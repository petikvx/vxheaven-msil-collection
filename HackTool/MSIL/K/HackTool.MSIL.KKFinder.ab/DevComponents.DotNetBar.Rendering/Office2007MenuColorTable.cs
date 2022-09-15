using System.Drawing;

namespace DevComponents.DotNetBar.Rendering;

public class Office2007MenuColorTable
{
	public LinearGradientColorTable Background;

	public LinearGradientColorTable Side;

	public LinearGradientColorTable SideUnused;

	public LinearGradientColorTable Border;

	public LinearGradientColorTable SideBorder;

	public LinearGradientColorTable SideBorderLight;

	public BackgroundColorBlendCollection FileBackgroundBlend = new BackgroundColorBlendCollection();

	public Color FileContainerBorder = Color.Empty;

	public Color FileContainerBorderLight = Color.Empty;

	public Color FileColumnOneBackground = Color.Empty;

	public Color FileColumnOneBorder = Color.Empty;

	public Color FileColumnTwoBackground = Color.Empty;

	public BackgroundColorBlendCollection FileBottomContainerBackgroundBlend = new BackgroundColorBlendCollection();
}
