using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevComponents.DotNetBar.Presentation;

namespace DevComponents.DotNetBar.Rendering;

internal class Class231 : Class230, Interface3
{
	private Office2007ColorTable office2007ColorTable_0;

	public Office2007ColorTable Office2007ColorTable_0
	{
		get
		{
			return office2007ColorTable_0;
		}
		set
		{
			office2007ColorTable_0 = value;
		}
	}

	public override void Paint(QatOverflowItemRendererEventArgs e)
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		Graphics graphics = e.Graphics;
		QatOverflowItem overflowItem = e.OverflowItem;
		Rectangle displayRectangle = overflowItem.DisplayRectangle;
		Region val = null;
		if (graphics.get_Clip() != null)
		{
			val = graphics.get_Clip().Clone();
		}
		graphics.SetClip(overflowItem.DisplayRectangle, (CombineMode)1);
		Office2007ButtonItemColorTable colorTable = GetColorTable();
		Office2007ButtonItemStateColorTable office2007ButtonItemStateColorTable = colorTable.Default;
		if (overflowItem.Expanded)
		{
			office2007ButtonItemStateColorTable = colorTable.Expanded;
		}
		else if (overflowItem.IsMouseOver)
		{
			office2007ButtonItemStateColorTable = colorTable.MouseOver;
		}
		Class268.smethod_4(graphics, office2007ButtonItemStateColorTable, displayRectangle, RoundRectangleShapeDescriptor.RoundCorner2);
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)0);
		Color expandBackground = office2007ButtonItemStateColorTable.ExpandBackground;
		Color expandLight = office2007ButtonItemStateColorTable.ExpandLight;
		Class209 @class = new Class209();
		Class215 border = new Class215(expandLight, 1);
		Class215 border2 = new Class215(expandBackground, 1);
		@class.Class207_0.method_0(new Class213(new Class208(0, 0), new Class208(2, 2), border));
		@class.Class207_0.method_0(new Class213(new Class208(2, 2), new Class208(0, 4), border));
		@class.Class207_0.method_0(new Class213(new Class208(0, 1), new Class208(1, 2), border2));
		@class.Class207_0.method_0(new Class213(new Class208(1, 2), new Class208(0, 3), border2));
		@class.Class207_0.method_0(new Class213(new Class208(0, 3), new Class208(0, 1), border2));
		Rectangle rectangle = new Rectangle(displayRectangle.X + (displayRectangle.Width - 5) / 2, displayRectangle.Y + (displayRectangle.Height - 4) / 2, 3, 6);
		Class216 class2 = new Class216(graphics, rectangle);
		@class.Paint(class2);
		rectangle.Offset(4, 0);
		class2.rectangle_0 = rectangle;
		@class.Paint(class2);
		graphics.set_SmoothingMode(smoothingMode);
		if (val != null)
		{
			graphics.set_Clip(val);
		}
		else
		{
			graphics.ResetClip();
		}
	}

	protected virtual Office2007ButtonItemColorTable GetColorTable()
	{
		Office2007ColorTable office2007ColorTable = Office2007ColorTable_0;
		Office2007ButtonItemColorTable office2007ButtonItemColorTable = null;
		office2007ButtonItemColorTable = office2007ColorTable.ButtonItemColors[Enum.GetName(typeof(eButtonColor), eButtonColor.Orange)];
		if (office2007ButtonItemColorTable == null)
		{
			return office2007ColorTable.ButtonItemColors[0];
		}
		return office2007ButtonItemColorTable;
	}
}
