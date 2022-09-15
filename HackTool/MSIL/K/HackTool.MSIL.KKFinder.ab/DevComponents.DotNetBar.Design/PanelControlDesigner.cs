using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class PanelControlDesigner : ScrollableControlDesigner
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
		if (((ControlDesigner)this).get_Control() is PanelControl panelControl)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			panelControl.ApplyPanelStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is PanelControl panelControl)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			panelControl.ApplyButtonStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is PanelControl panelControl)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			panelControl.ApplyLabelStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		SetDesignTimeDefaults();
	}

	protected virtual void SetDesignTimeDefaults()
	{
		if (((ControlDesigner)this).get_Control() is PanelControl panelControl)
		{
			panelControl.ApplyPanelStyle();
			panelControl.CanvasColor = SystemColors.Control;
		}
	}

	protected override void OnPaintAdornments(PaintEventArgs pe)
	{
		PanelControl panelControl = ((ComponentDesigner)this).get_Component() as PanelControl;
		if (panelControl.Style.Border == eStyleBorderType.None)
		{
			DrawBorder(pe.get_Graphics());
		}
		((ParentControlDesigner)this).OnPaintAdornments(pe);
	}

	protected virtual void DrawBorder(Graphics g)
	{
		PanelControl panelControl = ((ControlDesigner)this).get_Control() as PanelControl;
		Color controlDarkDark = SystemColors.ControlDarkDark;
		Rectangle clientRectangle = ((ControlDesigner)this).get_Control().get_ClientRectangle();
		Color backColor = panelControl.Style.BackColor;
		Class109.smethod_43(g, clientRectangle, backColor, controlDarkDark, 1);
	}
}
