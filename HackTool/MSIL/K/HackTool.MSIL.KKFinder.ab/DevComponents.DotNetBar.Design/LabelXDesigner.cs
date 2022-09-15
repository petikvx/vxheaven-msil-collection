using System;
using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.Design.Behavior;

namespace DevComponents.DotNetBar.Design;

public class LabelXDesigner : ControlDesigner
{
	public override IList SnapLines
	{
		get
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Invalid comparison between Unknown and I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Invalid comparison between Unknown and I4
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			LabelX labelX = ((ControlDesigner)this).get_Control() as LabelX;
			IList snapLines = ((ControlDesigner)this).get_SnapLines();
			int num = (int)Math.Floor(((Control)labelX).get_Font().get_Size() * (float)((Control)labelX).get_Font().get_FontFamily().GetCellDescent(((Control)labelX).get_Font().get_Style()) / (float)((Control)labelX).get_Font().get_FontFamily().GetEmHeight(((Control)labelX).get_Font().get_Style()));
			num = (((int)labelX.TextLineAlignment == 1) ? ((int)Math.Floor((double)(((Control)labelX).get_Height() - ((Control)labelX).get_Font().get_Height()) / 2.0) + ((Control)labelX).get_Font().get_Height() - num) : (((int)labelX.TextLineAlignment != 2) ? (((Control)labelX).get_Font().get_Height() - num) : (((Control)labelX).get_Height() - num)));
			snapLines.Add((object?)new SnapLine((SnapLineType)6, num, (SnapLinePriority)2));
			return snapLines;
		}
	}
}
