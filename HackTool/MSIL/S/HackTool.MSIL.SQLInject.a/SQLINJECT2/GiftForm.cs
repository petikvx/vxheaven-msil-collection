using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SQLINJECT2;

public class GiftForm : Form
{
	private IContainer components = null;

	private Label label1;

	private Button button1;

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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GiftForm));
		label1 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Verdana", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)163));
		((Control)label1).set_ForeColor(SystemColors.ActiveCaption);
		((Control)label1).set_Location(new Point(-3, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(299, 272));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		((Control)button1).set_Location(new Point(97, 284));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Close");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 310));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MaximumSize(new Size(300, 337));
		((Control)this).set_MinimumSize(new Size(300, 337));
		((Control)this).set_Name("GiftForm");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public GiftForm()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
