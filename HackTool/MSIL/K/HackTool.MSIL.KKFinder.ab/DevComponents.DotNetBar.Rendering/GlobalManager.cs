namespace DevComponents.DotNetBar.Rendering;

public class GlobalManager
{
	private static BaseRenderer baseRenderer_0;

	public static BaseRenderer Renderer
	{
		get
		{
			if (baseRenderer_0 == null)
			{
				baseRenderer_0 = new Office2007Renderer();
			}
			return baseRenderer_0;
		}
		set
		{
			baseRenderer_0 = value;
		}
	}
}
