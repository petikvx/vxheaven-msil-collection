using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace DevComponents.AdvTree.Design;

internal class Class4 : DesignerActionList
{
	private AdvTreeDesigner advTreeDesigner_0;

	public bool HotTracking
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).HotTracking;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["HotTracking"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public bool SelectionBox
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).SelectionBox;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["SelectionBox"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public eSelectionStyle SelectionBoxStyle
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).SelectionBoxStyle;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["SelectionBoxStyle"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public bool ColumnsVisible
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).ColumnsVisible;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["ColumnsVisible"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public bool GridColumnLines
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).GridColumnLines;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["GridColumnLines"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public bool GridRowLines
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).GridRowLines;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["GridRowLines"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public Color GridLinesColor
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).GridLinesColor;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["GridLinesColor"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public bool CellEdit
	{
		get
		{
			return ((AdvTree)((DesignerActionList)this).get_Component()).CellEdit;
		}
		set
		{
			TypeDescriptor.GetProperties(((DesignerActionList)this).get_Component())["CellEdit"]!.SetValue(((DesignerActionList)this).get_Component(), value);
		}
	}

	public Class4(AdvTreeDesigner designer)
		: base(((ComponentDesigner)designer).get_Component())
	{
		advTreeDesigner_0 = designer;
	}

	public override DesignerActionItemCollection GetSortedActionItems()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		DesignerActionItemCollection val = new DesignerActionItemCollection();
		val.Add((DesignerActionItem)new DesignerActionHeaderItem("Nodes"));
		val.Add((DesignerActionItem)new DesignerActionHeaderItem("Columns"));
		val.Add((DesignerActionItem)new DesignerActionHeaderItem("Selection"));
		val.Add((DesignerActionItem)new DesignerActionMethodItem((DesignerActionList)(object)this, "CreateNode", "Create Node", "Nodes", true));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("CellEdit", "Allow node text editing?", "Nodes", "Indicates whether node cells are editable"));
		val.Add((DesignerActionItem)new DesignerActionMethodItem((DesignerActionList)(object)this, "EditColumns", "Edit Columns...", "Columns", "Edit Tree Control Columns", true));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("ColumnsVisible", "Column header visible?", "Columns", "Indicates whether tree column header is visible"));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("GridColumnLines", "Show grid column lines?", "Columns", "Indicates whether grid lines are visible"));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("GridRowLines", "Show grid row lines?", "Nodes", "Indicates whether grid lines between nodes are visible"));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("GridLinesColor", "Grid lines color:", "Columns", "Indicates custom color for grid lines"));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("SelectionBox", "Show selection?", "Selection", "Indicates whether selection is shown for selected node"));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("SelectionBoxStyle", "Selection style:", "Selection", "Indicates selection style"));
		val.Add((DesignerActionItem)new DesignerActionPropertyItem("HotTracking", "Highlight mouse over node?", "Selection", "Indicates whether node that mouse is over is highlighted"));
		return val;
	}

	public void CreateNode()
	{
		advTreeDesigner_0.method_15();
	}

	public void EditColumns()
	{
		advTreeDesigner_0.method_13();
	}
}
