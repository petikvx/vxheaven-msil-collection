using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;

namespace DevComponents.DotNetBar.Design;

public class GroupPanelDesigner : ScrollableControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[1]
			{
				new DesignerVerb("Reset Style", method_0)
			};
			return new DesignerVerbCollection(value);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		if (((ControlDesigner)this).get_Control() is GroupPanel groupPanel)
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			groupPanel.SetDefaultPanelStyle();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
	}

	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ParentControlDesigner)this).InitializeNewComponent(defaultValues);
		method_1();
	}

	private void method_1()
	{
		if (((ControlDesigner)this).get_Control() is GroupPanel groupPanel)
		{
			groupPanel.SetDefaultPanelStyle();
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

	protected override void WndProc(ref Message m)
	{
		if (((Message)(ref m)).get_Msg() == 132 && ((ControlDesigner)this).get_Control() is GroupPanel groupPanel)
		{
			int x = Class51.smethod_4(((Message)(ref m)).get_LParam());
			int y = Class51.smethod_5(((Message)(ref m)).get_LParam());
			if (((Control)groupPanel).PointToClient(new Point(x, y)).Y < 0)
			{
				((Message)(ref m)).set_Result(new IntPtr(1));
				return;
			}
		}
		((ScrollableControlDesigner)this).WndProc(ref m);
	}
}
