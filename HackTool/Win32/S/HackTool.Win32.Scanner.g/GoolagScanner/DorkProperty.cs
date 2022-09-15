using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GoolagScanner;

public class DorkProperty : Form
{
	private IContainer components;

	private Panel panel1;

	private Button button1;

	private Label label1;

	private Label label2;

	private Label label3;

	private SplitContainer splitContainer1;

	private RichTextBox richTextBox1;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	public DorkProperty()
	{
		InitializeComponent();
	}

	public void setDork(Dork t)
	{
		if (t != null)
		{
			((Control)this).set_Text(t.Title);
			((Control)textBox1).set_Text(t.Name);
			((Control)textBox2).set_Text(t.Category);
			((Control)textBox3).set_Text(t.Query);
			((Control)richTextBox1).set_Text(t.Comment);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Component)this).Dispose();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		panel1 = new Panel();
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		splitContainer1 = new SplitContainer();
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		textBox1 = new TextBox();
		richTextBox1 = new RichTextBox();
		((Control)panel1).SuspendLayout();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).set_Location(new Point(3, 139));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(422, 30));
		((Control)panel1).set_TabIndex(0);
		((Control)button1).set_Location(new Point(322, 0));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(97, 31));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Ok");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(8, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Name");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 35));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(49, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Category");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(8, 61));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(35, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Query");
		splitContainer1.set_Dock((DockStyle)5);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)textBox3);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)textBox2);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)textBox1);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)label3);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)label2);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)label1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)richTextBox1);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)panel1);
		((Control)splitContainer1).set_Size(new Size(426, 259));
		splitContainer1.set_SplitterDistance(85);
		((Control)splitContainer1).set_TabIndex(0);
		((Control)textBox3).set_Location(new Point(75, 54));
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		((Control)textBox3).set_Size(new Size(347, 20));
		((Control)textBox3).set_TabIndex(5);
		((Control)textBox2).set_Location(new Point(75, 32));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(347, 20));
		((Control)textBox2).set_TabIndex(4);
		((Control)textBox1).set_Location(new Point(75, 10));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(347, 20));
		((Control)textBox1).set_TabIndex(3);
		((Control)richTextBox1).set_Dock((DockStyle)1);
		((Control)richTextBox1).set_Location(new Point(0, 0));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(426, 136));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text("");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(426, 259));
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("DorkProperty");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("DorkProperty");
		((Control)panel1).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel1()).PerformLayout();
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
