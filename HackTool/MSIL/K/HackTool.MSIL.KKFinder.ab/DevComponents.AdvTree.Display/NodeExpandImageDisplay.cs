namespace DevComponents.AdvTree.Display;

public class NodeExpandImageDisplay : NodeExpandDisplay
{
	public override void DrawExpandButton(NodeExpandPartRendererEventArgs e)
	{
		if (e.Node.Expanded)
		{
			if (e.ExpandImageCollapse != null)
			{
				e.Graphics.DrawImage(e.ExpandImageCollapse, e.ExpandPartBounds);
			}
		}
		else if (e.ExpandImage != null)
		{
			e.Graphics.DrawImage(e.ExpandImage, e.ExpandPartBounds);
		}
	}
}
