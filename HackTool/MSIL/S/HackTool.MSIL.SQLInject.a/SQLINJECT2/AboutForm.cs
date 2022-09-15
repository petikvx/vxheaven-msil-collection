using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SQLINJECT2;

public class AboutForm : Form
{
	private IContainer components = null;

	private Label label1;

	private GroupBox groupBox1;

	private Label label2;

	private Button button1;

	private Label label3;

	public AboutForm()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutForm));
		label1 = new Label();
		groupBox1 = new GroupBox();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Verdana", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(87, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(231, 23));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("AKĐ SQL INJECTION");
		((Control)groupBox1).get_Controls().Add((Control)(object)button1);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).set_Location(new Point(1, 40));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(418, 259));
		((Control)groupBox1).set_TabIndex(1);
		groupBox1.set_TabStop(false);
		((Control)button1).set_Location(new Point(154, 230));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Close");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Verdana", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)163));
		((Control)label2).set_ForeColor(Color.Indigo);
		((Control)label2).set_Location(new Point(2, 16));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(412, 210));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label3).set_ForeColor(SystemColors.GradientActiveCaption);
		((Control)label3).set_Location(new Point(276, 32));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(79, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Version : 2.0");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(418, 298));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MaximumSize(new Size(426, 325));
		((Control)this).set_MinimumSize(new Size(426, 325));
		((Control)this).set_Name("AboutForm");
		((Control)this).set_Text("About");
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
