using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[Designer(typeof(NavigationPanePanelDesigner))]
[ToolboxItem(false)]
public class NavigationPanePanel : PanelEx
{
	private const string string_1 = "Drop controls on this panel to associate them with current selection";

	private BaseItem baseItem_0;

	[Browsable(false)]
	[DevCoBrowsable(false)]
	public BaseItem ParentItem
	{
		get
		{
			return baseItem_0;
		}
		set
		{
			baseItem_0 = value;
			if (baseItem_0 != null && ((Control)this).get_Parent() is NavigationPane && baseItem_0 is ButtonItem && ((ButtonItem)baseItem_0).Checked)
			{
				((Control)this).set_Visible(true);
				((Control)this).BringToFront();
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		base.OnPaint(e);
		if (((Component)(object)this).DesignMode && ((ArrangedElementCollection)((Control)this).get_Controls()).get_Count() == 0 && ((Control)this).get_Text() == "")
		{
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			clientRectangle.Inflate(-2, -2);
			Font val = new Font(((Control)this).get_Font(), (FontStyle)1);
			Class55.smethod_1(e.get_Graphics(), "Drop controls on this panel to associate them with current selection", val, ControlPaint.Dark(base.Style.BackColor1.Color), clientRectangle, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter);
			val.Dispose();
		}
	}
}
