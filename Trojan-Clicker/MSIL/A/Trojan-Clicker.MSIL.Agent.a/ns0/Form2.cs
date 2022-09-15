using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

public class Form2 : Form
{
	private IContainer components = null;

	private LinkLabel linkLabel3;

	private Label label4;

	private Button button3;

	private Label label1;

	private MaskedTextBox maskedTextBox1;

	private MaskedTextBox maskedTextBox2;

	private Button button1;

	private Button button2;

	private WebBrowser webBrowser1;

	private Button button4;

	private Label label2;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void tabPage3_Click(object sender, EventArgs e)
	{
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("ansuanni001@yahoo.com.cn");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Form1 form = new Form1();
		((Control)form).Show();
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("您输入的帐号未激活 请与客服联系QQ11254897", "苍天登陆失败");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("密码不正确 请与客服联系QQ11254897", "苍天注册失败");
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_053d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Expected O, but got Unknown
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		linkLabel3 = new LinkLabel();
		label4 = new Label();
		button3 = new Button();
		label1 = new Label();
		maskedTextBox1 = new MaskedTextBox();
		maskedTextBox2 = new MaskedTextBox();
		button1 = new Button();
		button2 = new Button();
		webBrowser1 = new WebBrowser();
		button4 = new Button();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)linkLabel3).set_AutoSize(true);
		linkLabel3.set_LinkColor(Color.Blue);
		((Control)linkLabel3).set_Location(new Point(83, 249));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(137, 12));
		((Control)linkLabel3).set_TabIndex(10);
		((Label)linkLabel3).set_TabStop(true);
		((Control)linkLabel3).set_Text("ermizi001@yahoo.com.cn");
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_ForeColor(Color.Black);
		((Control)label4).set_Location(new Point(30, 249));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(47, 12));
		((Control)label4).set_TabIndex(11);
		((Control)label4).set_Text("Email：");
		((Control)button3).set_BackColor(Color.Silver);
		((Control)button3).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)1);
		((Control)button3).set_ForeColor(Color.Black);
		((Control)button3).set_Location(new Point(238, 173));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(86, 21));
		((Control)button3).set_TabIndex(16);
		((Control)button3).set_Text("登陆外挂");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 234));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(65, 12));
		((Control)label1).set_TabIndex(17);
		((Control)label1).set_Text("联系客服：");
		((Control)maskedTextBox1).set_BackColor(Color.White);
		((Control)maskedTextBox1).set_Location(new Point(12, 201));
		((Control)maskedTextBox1).set_Name("maskedTextBox1");
		((Control)maskedTextBox1).set_Size(new Size(114, 21));
		((Control)maskedTextBox1).set_TabIndex(35);
		((Control)maskedTextBox2).set_BackColor(Color.White);
		((Control)maskedTextBox2).set_Location(new Point(12, 173));
		((Control)maskedTextBox2).set_Name("maskedTextBox2");
		((Control)maskedTextBox2).set_Size(new Size(114, 21));
		((Control)maskedTextBox2).set_TabIndex(37);
		((Control)button1).set_BackColor(Color.Silver);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_ForeColor(Color.Black);
		((Control)button1).set_Location(new Point(138, 173));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(89, 21));
		((Control)button1).set_TabIndex(34);
		((Control)button1).set_Text("输入官方帐号");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.Silver);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)1);
		((Control)button2).set_ForeColor(Color.Black);
		((Control)button2).set_Location(new Point(138, 200));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(89, 21));
		((Control)button2).set_TabIndex(36);
		((Control)button2).set_Text("输入官方密码");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)webBrowser1).set_Location(new Point(12, 12));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(312, 155));
		((Control)webBrowser1).set_TabIndex(38);
		webBrowser1.set_Url(new Uri("http://www.reddidi.com.cn/soft/cangt.htm", UriKind.Absolute));
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((Control)button4).set_BackColor(Color.Silver);
		((Control)button4).set_BackgroundImageLayout((ImageLayout)3);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)1);
		((Control)button4).set_ForeColor(Color.Black);
		((Control)button4).set_Location(new Point(238, 200));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(86, 21));
		((Control)button4).set_TabIndex(39);
		((Control)button4).set_Text("关闭外挂");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(83, 234));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 12));
		((Control)label2).set_TabIndex(40);
		((Control)label2).set_Text("11254897");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gray);
		((Form)this).set_ClientSize(new Size(340, 267));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)linkLabel3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_MaximumSize(new Size(348, 301));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_MinimumSize(new Size(348, 301));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("购买苍天驳云");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
