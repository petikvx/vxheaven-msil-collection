namespace DevComponents.DotNetBar;

public class GradientColorTable
{
	public BackgroundColorBlendCollection Colors = new BackgroundColorBlendCollection();

	public eGradientType GradientType;

	public int LinearGradientAngle = 90;

	public GradientColorTable()
	{
	}

	public GradientColorTable(int color1, int color2)
		: this(color1, color2, 90)
	{
	}

	public GradientColorTable(int color1, int color2, int linearGradientAngle)
	{
		BackgroundColorBlendCollection.InitializeCollection(Colors, color1, color2);
		LinearGradientAngle = linearGradientAngle;
	}
}
