using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SQLScanner2.My.Resources;

namespace SQLScanner2;

[DesignerGenerated]
public class type : Form
{
	private IContainer components;

	[DebuggerNonUserCode]
	public type()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
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
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.digital_shodan);
		Size clientSize = new Size(313, 266);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("type");
		((Form)this).set_Text("Sort by Database Type");
		((Control)this).ResumeLayout(false);
	}
}
