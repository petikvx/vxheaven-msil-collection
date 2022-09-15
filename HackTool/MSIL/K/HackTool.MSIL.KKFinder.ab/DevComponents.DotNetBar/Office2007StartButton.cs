using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.Design;
using DevComponents.DotNetBar.Rendering;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[Designer(typeof(BaseItemDesigner))]
[ToolboxItem(false)]
[DefaultEvent("Click")]
public class Office2007StartButton : ButtonItem
{
	private bool bool_49;

	internal override bool Boolean_8
	{
		get
		{
			return base.Boolean_8;
		}
		set
		{
			base.Boolean_8 = value;
			if (base.Boolean_8 && bool_49)
			{
				bool_49 = false;
			}
		}
	}

	public override void RecalcSize()
	{
		Class88.smethod_5(this, bool_0: true);
		m_NeedRecalcSize = false;
	}

	protected internal override void OnExpandChange()
	{
		bool_49 = false;
		if (!DesignMode && Expanded && base.PopupLocation.IsEmpty && PopupSide == ePopupSide.Default && Parent is Class181 && SubItems.Count > 0 && SubItems[0] is ItemContainer && ((ItemContainer)SubItems[0]).BackgroundStyle.Class == ElementStyleClassKeys.RibbonFileMenuContainerKey && ContainerControl is RibbonStrip ribbonStrip)
		{
			base.PopupLocation = new Point(IsRightToLeft ? Bounds.Right : LeftInternal, ribbonStrip.method_31().Y - 1);
			bool_49 = true;
		}
		base.OnExpandChange();
	}

	internal void method_43(ItemPaintArgs itemPaintArgs_1)
	{
		if (!bool_49)
		{
			return;
		}
		Graphics graphics = itemPaintArgs_1.Graphics;
		if (ContainerControl is RibbonStrip ribbonStrip)
		{
			if (itemPaintArgs_1.RightToLeft)
			{
				graphics.TranslateTransform((float)(-(LeftInternal - itemPaintArgs_1.ContainerControl.get_Width() + WidthInternal)), (float)(-(ribbonStrip.method_31().Y - 1)));
			}
			else
			{
				graphics.TranslateTransform((float)(-LeftInternal), (float)(-(ribbonStrip.method_31().Y - 1)));
			}
			graphics.ResetClip();
			Control containerControl = itemPaintArgs_1.ContainerControl;
			itemPaintArgs_1.ContainerControl = (Control)(object)ribbonStrip;
			itemPaintArgs_1.IsOnMenu = false;
			base.Boolean_6 = true;
			Paint(itemPaintArgs_1);
			base.Boolean_6 = false;
			itemPaintArgs_1.ContainerControl = containerControl;
			itemPaintArgs_1.IsOnMenu = true;
			graphics.ResetTransform();
		}
	}

	protected override void OnCommandChanged()
	{
	}
}
