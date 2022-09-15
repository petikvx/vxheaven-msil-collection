using System.ComponentModel;
using System.Windows.Forms;

namespace DevComponents.DotNetBar.Ribbon;

internal class Control7 : ItemControl
{
	private Class181 class181_0;

	private ElementStyle elementStyle_1 = new ElementStyle();

	[Description("Specifies the visual style of the control.")]
	[DevCoBrowsable(true)]
	[DefaultValue(eDotNetBarStyle.Office2007)]
	[Browsable(true)]
	[Category("Appearance")]
	public eDotNetBarStyle EDotNetBarStyle_0
	{
		get
		{
			return class181_0.Style;
		}
		set
		{
			base.ColorScheme.EDotNetBarStyle_0 = value;
			class181_0.Style = value;
			((Control)this).Invalidate();
			RecalcLayout();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public SubItemsCollection SubItemsCollection_0 => class181_0.SubItems;

	public Control7()
	{
		class181_0 = new Class181();
		class181_0.GlobalItem = false;
		class181_0.ContainerControl = this;
		class181_0.WrapItems = false;
		class181_0.Boolean_3 = false;
		class181_0.Boolean_4 = false;
		class181_0.Stretch = true;
		class181_0.Displayed = true;
		class181_0.SystemContainer = true;
		class181_0.PaddingTop = 0;
		class181_0.PaddingBottom = 0;
		class181_0.ItemSpacing = 0;
		class181_0.method_6(this);
		class181_0.PaddingBottom = 0;
		class181_0.PaddingTop = 0;
		class181_0.ItemSpacing = 1;
		class181_0.Boolean_5 = false;
		SetBaseItemContainer(class181_0);
		class181_0.Style = eDotNetBarStyle.Office2007;
	}

	protected override ElementStyle GetBackgroundStyle()
	{
		if (base.BackgroundStyle.Custom)
		{
			return base.GetBackgroundStyle();
		}
		return elementStyle_1;
	}

	protected override void RecalcSize()
	{
		method_24();
		base.RecalcSize();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		method_24();
		base.OnPaint(e);
	}

	private void method_24()
	{
		RibbonPredefinedColorSchemes.smethod_9(elementStyle_1, this);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 2097152 && ((Control)this).get_Parent() is RibbonControl)
		{
			((RibbonControl)(object)((Control)this).get_Parent()).vmethod_0(HitTest(e.get_X(), e.get_Y()), bool_18: true);
		}
		base.OnMouseDown(e);
	}
}
