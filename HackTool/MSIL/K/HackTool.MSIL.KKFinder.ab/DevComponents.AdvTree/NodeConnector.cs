using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace DevComponents.AdvTree;

[DesignTimeVisible(false)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[ToolboxItem(false)]
public class NodeConnector : Component
{
	private int int_0 = 1;

	private Color color_0 = SystemColors.Highlight;

	private eNodeConnectorType eNodeConnectorType_0;

	private EventHandler eventHandler_0;

	private DashStyle dashStyle_0 = (DashStyle)2;

	[Category("Appearance")]
	[Description("Indicates connector line width.")]
	[Browsable(true)]
	[DefaultValue(1)]
	public int LineWidth
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			OnAppearanceChanged();
		}
	}

	[Browsable(true)]
	[Description("Indicates color of the connector line.")]
	[Category("Appearance")]
	public Color LineColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			OnAppearanceChanged();
		}
	}

	[Category("Appearance")]
	[Description("Indicates visual type of the connector.")]
	[Browsable(false)]
	[DefaultValue(eNodeConnectorType.Line)]
	public eNodeConnectorType ConnectorType
	{
		get
		{
			return eNodeConnectorType_0;
		}
		set
		{
			eNodeConnectorType_0 = value;
			OnAppearanceChanged();
		}
	}

	[Description("Indicates DashStyle for the connector line")]
	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Appearance")]
	public DashStyle DashStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return dashStyle_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			dashStyle_0 = value;
		}
	}

	public event EventHandler AppearanceChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public NodeConnector()
	{
	}//IL_0014: Unknown result type (might be due to invalid IL or missing references)


	public NodeConnector(int lineWidth, eNodeConnectorType type)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		LineWidth = lineWidth;
		ConnectorType = type;
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeLineColor()
	{
		return color_0 != SystemColors.Highlight;
	}

	private void OnAppearanceChanged()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}
}
