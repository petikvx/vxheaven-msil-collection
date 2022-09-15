using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SQLINJECT2;

public class LoadForm : Form
{
	private IContainer components = null;

	private Timer timer1;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(373, 50));
		((Control)this).set_Name("LoadForm");
		((Control)this).set_Text("Loading ...");
		((Form)this).add_Load((EventHandler)LoadForm_Load);
		((Control)this).ResumeLayout(false);
	}

	public LoadForm()
	{
		InitializeComponent();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (MainForm.load == 1)
		{
			MainForm.load = 0;
			((Form)this).Close();
		}
	}

	private void LoadForm_Load(object sender, EventArgs e)
	{
		MainForm.load = 0;
		timer1.Start();
	}
}
