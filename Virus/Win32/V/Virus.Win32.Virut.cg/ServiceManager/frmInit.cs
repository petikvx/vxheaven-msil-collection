using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ServiceManager;

public class frmInit : Form
{
	private IContainer components;

	[AccessedThroughProperty("PanelEx1")]
	private PanelEx _PanelEx1;

	internal virtual PanelEx PanelEx1
	{
		get
		{
			return _PanelEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PanelEx1 = value;
		}
	}

	public frmInit()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		PanelEx1 = new PanelEx();
		((Control)this).SuspendLayout();
		PanelEx1.set_AntiAlias(true);
		((Control)PanelEx1).set_Dock((DockStyle)5);
		((Control)PanelEx1).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)134));
		PanelEx panelEx = PanelEx1;
		Point location = new Point(0, 0);
		((Control)panelEx).set_Location(location);
		((Control)PanelEx1).set_Name("PanelEx1");
		PanelEx panelEx2 = PanelEx1;
		Size size = new Size(327, 47);
		((Control)panelEx2).set_Size(size);
		PanelEx1.get_Style().set_Alignment((StringAlignment)1);
		PanelEx1.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)47);
		PanelEx1.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)48);
		PanelEx1.get_Style().set_Border((eBorderType)1);
		PanelEx1.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)49);
		PanelEx1.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)50);
		PanelEx1.get_Style().set_GradientAngle(90);
		((Control)PanelEx1).set_TabIndex(0);
		PanelEx1.set_Text("Receiving services and drives, please wait...");
		size = new Size(5, 14);
		((Form)this).set_AutoScaleBaseSize(size);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(327, 47);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)PanelEx1);
		((Control)this).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)134));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmInit");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}
}
