using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class ExpandablePanelDesigner : PanelExDesigner
{
	[Description("Gets or sets color scheme style.")]
	[Category("Style")]
	[DefaultValue(eDotNetBarStyle.Office2003)]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	public eDotNetBarStyle ColorSchemeStyle
	{
		get
		{
			ExpandablePanel expandablePanel = ((ControlDesigner)this).get_Control() as ExpandablePanel;
			return expandablePanel.ColorSchemeStyle;
		}
		set
		{
			ExpandablePanel expandablePanel = ((ControlDesigner)this).get_Control() as ExpandablePanel;
			expandablePanel.ColorSchemeStyle = value;
			if (((ComponentDesigner)this).GetService(typeof(IDesignerHost)) is IDesignerHost designerHost && !designerHost.Loading)
			{
				if (value == eDotNetBarStyle.Office2007)
				{
					expandablePanel.TitleStyle.Border = eBorderType.RaisedInner;
				}
				else
				{
					expandablePanel.TitleStyle.Border = eBorderType.SingleLine;
				}
			}
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		base.InitializeNewComponent(defaultValues);
		method_5();
	}

	private void method_5()
	{
		if (((ControlDesigner)this).get_Control() is ExpandablePanel expandablePanel)
		{
			expandablePanel.ApplyLabelStyle();
			expandablePanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.BarDockedBorder;
			expandablePanel.Style.Border = eBorderType.SingleLine;
			expandablePanel.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
			expandablePanel.Style.BackColor2.ColorSchemePart = eColorSchemePart.PanelBackground2;
			((Control)expandablePanel).set_Text("");
			expandablePanel.TitlePanel.ApplyPanelStyle();
			ColorSchemeStyle = eDotNetBarStyle.Office2007;
		}
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		((ParentControlDesigner)this).PreFilterProperties(properties);
		properties["ColorSchemeStyle"] = TypeDescriptor.CreateProperty(typeof(ExpandablePanelDesigner), (PropertyDescriptor)properties["ColorSchemeStyle"], new DefaultValueAttribute(eDotNetBarStyle.Office2003), new BrowsableAttribute(browsable: true), new CategoryAttribute("Style"), new DescriptionAttribute("Gets or sets color scheme style."));
	}

	protected override bool GetHitTest(Point pt)
	{
		if (((ControlDesigner)this).get_Control() is ExpandablePanel expandablePanel)
		{
			Point pt2 = ((Control)expandablePanel).PointToClient(pt);
			Class204 @class = expandablePanel.TitlePanel as Class204;
			if (@class != null && @class.ButtonItem_0 != null && @class.ButtonItem_0.DisplayRectangle.Contains(pt2))
			{
				return true;
			}
			if (@class != null && @class.ButtonItem_0 != null)
			{
				@class.ButtonItem_0.InternalMouseLeave();
			}
		}
		return ((ScrollableControlDesigner)this).GetHitTest(pt);
	}
}
