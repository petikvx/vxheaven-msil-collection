using System.Drawing;

namespace DevComponents.AdvTree.Display;

public abstract class NodeConnectorDisplay
{
	public NodeConnectorDisplay()
	{
	}

	public virtual void DrawConnector(ConnectorRendererEventArgs info)
	{
	}

	protected Pen GetLinePen(ConnectorRendererEventArgs info)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		Pen val = new Pen(info.NodeConnector.LineColor, (float)info.NodeConnector.LineWidth);
		val.set_DashStyle(info.NodeConnector.DashStyle);
		return val;
	}
}
