using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar.Ribbon;

[ToolboxItem(true)]
[Designer(typeof(RibbonClientPanelDesigner))]
public class RibbonClientPanel : PanelControl
{
	private bool bool_9 = true;

	[DefaultValue(true)]
	[Description("Indicates whether panel automatically provides shadows for child controls.")]
	[Browsable(true)]
	[Category("Appearance")]
	public bool IsShadowEnabled
	{
		get
		{
			return bool_9;
		}
		set
		{
			if (bool_9 != value)
			{
				bool_9 = value;
				((Control)this).Invalidate();
			}
		}
	}

	protected override void PaintInnerContent(PaintEventArgs e, ElementStyle style, bool paintText)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		base.PaintInnerContent(e, style, paintText);
		if (!bool_9)
		{
			return;
		}
		Graphics graphics = e.get_Graphics();
		ShadowPaintInfo shadowPaintInfo = new ShadowPaintInfo();
		shadowPaintInfo.Graphics = graphics;
		shadowPaintInfo.Size = 6;
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			if (val.get_Visible() && (!(val.get_BackColor() == Color.Transparent) || val is GroupPanel))
			{
				if (val is GroupPanel)
				{
					GroupPanel groupPanel = val as GroupPanel;
					shadowPaintInfo.Rectangle = new Rectangle(val.get_Bounds().X, val.get_Bounds().Y + groupPanel.method_9().Y / 2, val.get_Bounds().Width, val.get_Bounds().Height - groupPanel.method_9().Y / 2);
				}
				else
				{
					shadowPaintInfo.Rectangle = val.get_Bounds();
				}
				ShadowPainter.Paint2(shadowPaintInfo);
			}
		}
	}
}
