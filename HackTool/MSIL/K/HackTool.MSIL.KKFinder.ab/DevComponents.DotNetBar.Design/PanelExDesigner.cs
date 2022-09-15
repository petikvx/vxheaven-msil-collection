using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class PanelExDesigner : ScrollableControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[3]
			{
				new DesignerVerb("Apply Panel Style", method_0),
				new DesignerVerb("Apply Button Style", method_1),
				new DesignerVerb("Apply Label Style", method_2)
			};
			return new DesignerVerbCollection(value);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is PanelEx panelEx)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			panelEx.ApplyPanelStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is PanelEx panelEx)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			panelEx.ApplyButtonStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is PanelEx panelEx)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			panelEx.ApplyLabelStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_3();
	}

	private void method_3()
	{
		if (((ControlDesigner)this).get_Control() is PanelEx panelEx)
		{
			panelEx.ApplyPanelStyle();
			panelEx.CanvasColor = SystemColors.Control;
		}
	}

	protected override void OnPaintAdornments(PaintEventArgs pe)
	{
		if (((ComponentDesigner)this).get_Component() is PanelEx panelEx && panelEx.Style.Border == eBorderType.None)
		{
			method_4(pe.get_Graphics());
		}
		((ParentControlDesigner)this).OnPaintAdornments(pe);
	}

	private void method_4(Graphics graphics_0)
	{
		PanelEx panelEx = ((ControlDesigner)this).get_Control() as PanelEx;
		Color controlDarkDark = SystemColors.ControlDarkDark;
		Rectangle clientRectangle = ((ControlDesigner)this).get_Control().get_ClientRectangle();
		Color color = panelEx.Style.BackColor1.Color;
		Class109.smethod_43(graphics_0, clientRectangle, color, controlDarkDark, 1);
	}
}
