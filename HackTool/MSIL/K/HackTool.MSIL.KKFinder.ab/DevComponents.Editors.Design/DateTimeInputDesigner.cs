using System.Collections;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar;
using DevComponents.Editors.DateTimeAdv;

namespace DevComponents.Editors.Design;

public class DateTimeInputDesigner : VisualControlBaseDesigner
{
	public override SelectionRules SelectionRules
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			SelectionRules val = ((ControlDesigner)this).get_SelectionRules();
			if (!((ControlDesigner)this).get_Control().get_AutoSize())
			{
				val = (SelectionRules)(val & -4);
			}
			return val;
		}
	}

	public DateTimeInputDesigner()
	{
		((ControlDesigner)this).set_AutoResizeHandles(true);
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		if (((ControlDesigner)this).get_Control() is DateTimeInput dateTimeInput)
		{
			dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = eColorSchemePart.PanelBackground;
			dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = eColorSchemePart.PanelBackground2;
			dateTimeInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
			dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = eColorSchemePart.BarBackground;
			dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = eColorSchemePart.BarBackground2;
			dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
			dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = eStyleBorderType.Solid;
			dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = eColorSchemePart.BarDockedBorder;
			dateTimeInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
			dateTimeInput.ButtonDropDown.Visible = true;
			dateTimeInput.MonthCalendar.TodayButtonVisible = true;
			dateTimeInput.MonthCalendar.ClearButtonVisible = true;
		}
		base.InitializeNewComponent(defaultValues);
	}
}
