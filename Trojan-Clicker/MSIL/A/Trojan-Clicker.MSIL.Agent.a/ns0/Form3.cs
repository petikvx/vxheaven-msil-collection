using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

public class Form3 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Button button1;

	public Form3()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Form3_Load(object sender, EventArgs e)
	{
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
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form3));
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		button1 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		pictureBox1.set_InitialImage((Image)null);
		((Control)pictureBox1).set_Location(new Point(12, 18));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(48, 48));
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(66, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(149, 12));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("软件未注册请购买后再使用");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(66, 44));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(107, 12));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("联系人QQ:11254897");
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Location(new Point(86, 71));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(66, 20));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("确定");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(224, 103));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_MaximumSize(new Size(232, 137));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_MinimumSize(new Size(232, 137));
		((Control)this).set_Name("Form3");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("苍天");
		((Form)this).add_Load((EventHandler)Form3_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
