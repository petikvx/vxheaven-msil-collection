using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RSMInit;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		WebBrowser val = new WebBrowser();
		((Control)val).set_Visible(false);
		val.Navigate("http://images.rapidshare.com/software/rapidmanager/RapidShareManager.application", true);
		((Form)this).Close();
	}

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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(16, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(256, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Installing RapidShare  Manager. Downloading files ...");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(290, 40));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("RapidShare Manager Installer");
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
