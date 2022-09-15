using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar;
using DevComponents.Editors.DateTimeAdv;

namespace DevComponents.Editors.Design;

public class MonthCalendarAdvDesigner : ControlDesigner
{
	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		if (((ControlDesigner)this).get_Control() is MonthCalendarAdv monthCalendarAdv)
		{
			monthCalendarAdv.BackgroundStyle.BackColor = SystemColors.Window;
			monthCalendarAdv.BackgroundStyle.Border = eStyleBorderType.Solid;
			monthCalendarAdv.BackgroundStyle.BorderColorSchemePart = eColorSchemePart.PanelBorder;
			monthCalendarAdv.BackgroundStyle.BorderWidth = 1;
			monthCalendarAdv.NavigationBackgroundStyle.BackColorSchemePart = eColorSchemePart.BarBackground;
			monthCalendarAdv.NavigationBackgroundStyle.BackColor2SchemePart = eColorSchemePart.BarBackground2;
			monthCalendarAdv.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			((Control)monthCalendarAdv).set_AutoSize(true);
		}
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
	}
}
