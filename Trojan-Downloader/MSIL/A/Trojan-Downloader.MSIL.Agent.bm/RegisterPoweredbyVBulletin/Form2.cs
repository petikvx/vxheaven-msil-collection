using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RegisterPoweredbyVBulletin;

public class Form2 : Form
{
	private IContainer icontainer_0;

	private Button finish;

	public PictureBox pictureBox1;

	private TextBox textcode;

	private Label label3;

	private Label label1;

	public string string_0;

	public bool bool_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		finish = new Button();
		pictureBox1 = new PictureBox();
		textcode = new TextBox();
		label3 = new Label();
		label1 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)finish).set_Location(new Point(12, 180));
		((Control)finish).set_Name("finish");
		((Control)finish).set_Size(new Size(269, 32));
		((Control)finish).set_TabIndex(23);
		((Control)finish).set_Text("Submit");
		((ButtonBase)finish).set_UseVisualStyleBackColor(true);
		((Control)finish).add_Click((EventHandler)finish_Click);
		((Control)pictureBox1).set_Location(new Point(8, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(276, 114));
		pictureBox1.set_TabIndex(22);
		pictureBox1.set_TabStop(false);
		((Control)textcode).set_Location(new Point(113, 132));
		((Control)textcode).set_Name("textcode");
		((Control)textcode).set_Size(new Size(171, 21));
		((Control)textcode).set_TabIndex(21);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(7, 136));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(101, 12));
		((Control)label3).set_TabIndex(20);
		((Control)label3).set_Text("Validation code:\n");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 161));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(269, 12));
		((Control)label1).set_TabIndex(24);
		((Control)label1).set_Text("After input ,Press \"Enter\" Or Click \"Submit\"");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(290, 221));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)finish);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textcode);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("input code");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void finish_Click(object sender, EventArgs e)
	{
		string_0 = ((Control)textcode).get_Text();
		bool_0 = true;
		((Control)this).Hide();
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if ((int)keyData == 13)
		{
			SendKeys.Send("{TAB}");
			object sender = new object();
			EventArgs e = new EventArgs();
			finish_Click(sender, e);
			return true;
		}
		return ((Form)this).ProcessCmdKey(ref msg, keyData);
	}
}
