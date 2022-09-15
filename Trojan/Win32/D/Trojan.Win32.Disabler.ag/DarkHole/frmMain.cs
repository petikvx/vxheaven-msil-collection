using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DarkHole;

public class frmMain : Form
{
	private IContainer components;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new frmMain());
	}

	public frmMain()
	{
		((Form)this).add_Load((EventHandler)Form_Load);
		((Form)this).add_Closing((CancelEventHandler)Form_Closing);
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		Size autoScaleBaseSize = new Size(5, 14);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(96, 80);
		((Form)this).set_ClientSize(autoScaleBaseSize);
		((Form)this).set_ControlBox(false);
		((Control)this).set_Font(new Font("Tahoma", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("frmMain");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Dark Hole");
		((Form)this).set_TopMost(true);
	}

	private void Form_Load(object sender, EventArgs e)
	{
		frmMain frmHl = this;
		MainModule.DarkHole = new ADarkHole(ref frmHl);
	}

	private void Form_Closing(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}
}
