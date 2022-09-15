using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

public interface IRenderingSupport
{
	eRenderMode RenderMode { get; set; }

	BaseRenderer Renderer { get; set; }

	BaseRenderer GetRenderer();
}
