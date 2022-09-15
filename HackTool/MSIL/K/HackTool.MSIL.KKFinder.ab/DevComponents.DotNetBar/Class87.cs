using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevComponents.DotNetBar.Presentation;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

internal class Class87 : Class86, Interface3
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

	public override void PaintDialogLauncher(RibbonBarRendererEventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		Rectangle bounds = e.Bounds;
		Graphics graphics = e.Graphics;
		bool flag = (int)((Control)e.RibbonBar).get_RightToLeft() == 1;
		Office2007DialogLauncherStateColorTable office2007DialogLauncherStateColorTable = method_0(e);
		if (!office2007DialogLauncherStateColorTable.TopBackground.IsEmpty && !office2007DialogLauncherStateColorTable.BottomBackground.IsEmpty)
		{
			Class212 @class = new Class212(new Class215(office2007DialogLauncherStateColorTable.OuterBorder), new Class210(office2007DialogLauncherStateColorTable.TopBackground));
			@class.Class214_0 = new Class214(1, 1, 1, 1);
			Class212 class2 = new Class212(new Class210(office2007DialogLauncherStateColorTable.BottomBackground));
			class2.Class217_0.int_1 = bounds.Height / 2;
			@class.Class207_0.method_0(class2);
			class2 = new Class212(new Class215(office2007DialogLauncherStateColorTable.InnerBorder));
			@class.Class207_0.method_0(class2);
			Class216 p = new Class216(graphics, bounds);
			@class.Paint(p);
		}
		Size size = new Size(8, 8);
		bounds = ((!flag) ? new Rectangle(bounds.X + (bounds.Width - size.Width) / 2, bounds.Y + (bounds.Height - size.Height) / 2, size.Width, size.Height) : new Rectangle(bounds.X + (bounds.Width - size.Width) / 2, bounds.Y + (bounds.Height - size.Height) / 2, size.Width, size.Height));
		SmoothingMode smoothingMode = graphics.get_SmoothingMode();
		graphics.set_SmoothingMode((SmoothingMode)0);
		Class215 class3 = new Class215(office2007DialogLauncherStateColorTable.DialogLauncherShade, 1);
		Class210 class4 = new Class210(office2007DialogLauncherStateColorTable.DialogLauncherShade);
		Class209 class5 = new Class209();
		Class213 class209_ = new Class213(new Class208(), new Class208(6, 0), class3);
		class5.Class207_0.method_0(class209_);
		class209_ = new Class213(new Class208(), new Class208(0, 6), class3);
		class5.Class207_0.method_0(class209_);
		Class212 class6 = new Class212();
		class6.Class210_0 = class4;
		class6.Class208_0.int_0 = 5;
		class6.Class208_0.int_1 = 5;
		class6.Class217_0.int_0 = 3;
		class6.Class217_0.int_1 = 3;
		class5.Class207_0.method_0(class6);
		class209_ = new Class213(new Class208(7, 4), new Class208(7, 7), class3);
		class5.Class207_0.method_0(class209_);
		class209_ = new Class213(new Class208(4, 7), new Class208(7, 7), class3);
		class5.Class207_0.method_0(class209_);
		class209_ = new Class213(new Class208(4, 4), new Class208(5, 5), class3);
		class5.Class207_0.method_0(class209_);
		bounds.Offset(1, 1);
		Class216 class7 = new Class216(graphics, bounds);
		class5.Paint(class7);
		class3.color_0 = office2007DialogLauncherStateColorTable.DialogLauncher;
		class4.color_0 = office2007DialogLauncherStateColorTable.DialogLauncher;
		bounds.Offset(-1, -1);
		class7.rectangle_0 = bounds;
		class5.Paint(class7);
		graphics.set_SmoothingMode(smoothingMode);
	}

	private Office2007DialogLauncherStateColorTable method_0(RibbonBarRendererEventArgs ribbonBarRendererEventArgs_0)
	{
		if (ribbonBarRendererEventArgs_0.Pressed)
		{
			return office2007ColorTable_0.DialogLauncher.Pressed;
		}
		if (ribbonBarRendererEventArgs_0.MouseOver)
		{
			return office2007ColorTable_0.DialogLauncher.MouseOver;
		}
		return office2007ColorTable_0.DialogLauncher.Default;
	}
}
