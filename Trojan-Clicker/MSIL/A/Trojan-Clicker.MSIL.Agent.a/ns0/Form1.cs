using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

public class Form1 : Form
{
	private IContainer components = null;

	private Button button1;

	private Button button2;

	private TrackBar trackBar1;

	private TrackBar trackBar2;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private GroupBox groupBox1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label8;

	private Label label7;

	private ComboBox comboBox2;

	private ComboBox comboBox1;

	private Button button4;

	private HScrollBar hScrollBar2;

	private HScrollBar hScrollBar1;

	private Label label13;

	private Label label12;

	private Label label11;

	private Label label10;

	private Label label9;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private TabPage tabPage3;

	private TabPage tabPage4;

	private ComboBox comboBox3;

	private ComboBox comboBox4;

	private ComboBox comboBox5;

	private ComboBox comboBox6;

	private ComboBox comboBox7;

	private ComboBox comboBox8;

	private ComboBox comboBox9;

	private ComboBox comboBox10;

	private ComboBox comboBox11;

	private ComboBox comboBox12;

	private ComboBox comboBox14;

	private ComboBox comboBox13;

	private ComboBox comboBox16;

	private ComboBox comboBox15;

	private ComboBox comboBox18;

	private ComboBox comboBox17;

	private Button button3;

	private Button button6;

	private Button button7;

	private RichTextBox richTextBox1;

	private CheckBox checkBox1;

	private CheckBox checkBox2;

	private CheckBox checkBox3;

	private TabPage tabPage5;

	private ComboBox comboBox19;

	private ComboBox comboBox21;

	private ComboBox comboBox20;

	private ComboBox comboBox23;

	private ComboBox comboBox22;

	private Label label14;

	private Button button5;

	private HScrollBar hScrollBar4;

	private HScrollBar hScrollBar3;

	private Label label17;

	private Label label18;

	private Label label16;

	private Label label15;

	private Button button8;

	private Label label19;

	private Button button9;

	private Label label22;

	private Label label23;

	private Label label24;

	private Label label25;

	private Label label26;

	private HScrollBar hScrollBar5;

	private HScrollBar hScrollBar6;

	private Button button11;

	private Label label34;

	private Label label35;

	private Label label36;

	private Label label37;

	private Label label38;

	private HScrollBar hScrollBar9;

	private HScrollBar hScrollBar10;

	private Button button10;

	private Label label28;

	private Label label29;

	private Label label30;

	private Label label31;

	private Label label32;

	private HScrollBar hScrollBar7;

	private HScrollBar hScrollBar8;

	private CheckBox checkBox4;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel3;

	private Button button12;

	public Form1()
	{
		InitializeComponent();
	}

	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		((Control)label3).set_Text(trackBar1.get_Value().ToString());
	}

	private void trackBar2_Scroll(object sender, EventArgs e)
	{
		((Control)label4).set_Text(trackBar2.get_Value().ToString());
	}

	private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label10).set_Text(((ScrollBar)hScrollBar1).get_Value().ToString());
	}

	private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label11).set_Text(((ScrollBar)hScrollBar2).get_Value().ToString());
	}

	private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label15).set_Text(((ScrollBar)hScrollBar3).get_Value().ToString());
	}

	private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label18).set_Text(((ScrollBar)hScrollBar4).get_Value().ToString());
	}

	private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label26).set_Text(((ScrollBar)hScrollBar6).get_Value().ToString());
	}

	private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label24).set_Text(((ScrollBar)hScrollBar5).get_Value().ToString());
	}

	private void tabPage3_Click(object sender, EventArgs e)
	{
	}

	private void hScrollBar8_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label32).set_Text(((ScrollBar)hScrollBar8).get_Value().ToString());
	}

	private void hScrollBar7_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label30).set_Text(((ScrollBar)hScrollBar7).get_Value().ToString());
	}

	private void hScrollBar10_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label38).set_Text(((ScrollBar)hScrollBar10).get_Value().ToString());
	}

	private void hScrollBar9_Scroll(object sender, ScrollEventArgs e)
	{
		((Control)label36).set_Text(((ScrollBar)hScrollBar9).get_Value().ToString());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.reddidi.com.cn/buy.htm");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.reddidi.com.cn");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.reddidi.com.cn");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button10_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button9_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button8_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		Form3 form = new Form3();
		((Control)form).Show();
	}

	private void button7_Click(object sender, EventArgs e)
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected O, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf3: Expected O, but got Unknown
		//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5f: Expected O, but got Unknown
		//IL_1335: Unknown result type (might be due to invalid IL or missing references)
		//IL_1651: Unknown result type (might be due to invalid IL or missing references)
		//IL_165b: Expected O, but got Unknown
		//IL_16b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c3: Expected O, but got Unknown
		//IL_1be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0e: Expected O, but got Unknown
		//IL_1f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f76: Expected O, but got Unknown
		//IL_249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_27d8: Expected O, but got Unknown
		//IL_2836: Unknown result type (might be due to invalid IL or missing references)
		//IL_2840: Expected O, but got Unknown
		//IL_2d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_3081: Unknown result type (might be due to invalid IL or missing references)
		//IL_308b: Expected O, but got Unknown
		//IL_30e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f3: Expected O, but got Unknown
		//IL_35aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_5ac9: Expected O, but got Unknown
		//IL_5b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b53: Expected O, but got Unknown
		//IL_5bd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_5bdd: Expected O, but got Unknown
		//IL_5bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c04: Expected O, but got Unknown
		//IL_5e3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e47: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		button2 = new Button();
		trackBar1 = new TrackBar();
		trackBar2 = new TrackBar();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		groupBox1 = new GroupBox();
		label13 = new Label();
		label12 = new Label();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		hScrollBar2 = new HScrollBar();
		hScrollBar1 = new HScrollBar();
		comboBox2 = new ComboBox();
		comboBox1 = new ComboBox();
		button4 = new Button();
		label8 = new Label();
		label7 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		button11 = new Button();
		label34 = new Label();
		label35 = new Label();
		label36 = new Label();
		label37 = new Label();
		label38 = new Label();
		hScrollBar9 = new HScrollBar();
		hScrollBar10 = new HScrollBar();
		comboBox12 = new ComboBox();
		comboBox11 = new ComboBox();
		comboBox7 = new ComboBox();
		comboBox3 = new ComboBox();
		tabPage2 = new TabPage();
		button10 = new Button();
		label28 = new Label();
		label29 = new Label();
		label30 = new Label();
		label31 = new Label();
		label32 = new Label();
		hScrollBar7 = new HScrollBar();
		hScrollBar8 = new HScrollBar();
		comboBox14 = new ComboBox();
		comboBox13 = new ComboBox();
		comboBox8 = new ComboBox();
		comboBox4 = new ComboBox();
		tabPage3 = new TabPage();
		button9 = new Button();
		label22 = new Label();
		label23 = new Label();
		label24 = new Label();
		label25 = new Label();
		label26 = new Label();
		hScrollBar5 = new HScrollBar();
		hScrollBar6 = new HScrollBar();
		comboBox16 = new ComboBox();
		comboBox15 = new ComboBox();
		comboBox9 = new ComboBox();
		comboBox5 = new ComboBox();
		tabPage4 = new TabPage();
		button8 = new Button();
		label19 = new Label();
		label17 = new Label();
		label18 = new Label();
		label16 = new Label();
		label15 = new Label();
		hScrollBar4 = new HScrollBar();
		hScrollBar3 = new HScrollBar();
		comboBox18 = new ComboBox();
		comboBox17 = new ComboBox();
		comboBox10 = new ComboBox();
		comboBox6 = new ComboBox();
		tabPage5 = new TabPage();
		label14 = new Label();
		button5 = new Button();
		comboBox23 = new ComboBox();
		comboBox22 = new ComboBox();
		comboBox21 = new ComboBox();
		comboBox20 = new ComboBox();
		comboBox19 = new ComboBox();
		button3 = new Button();
		button6 = new Button();
		button7 = new Button();
		richTextBox1 = new RichTextBox();
		checkBox1 = new CheckBox();
		checkBox2 = new CheckBox();
		checkBox3 = new CheckBox();
		checkBox4 = new CheckBox();
		linkLabel1 = new LinkLabel();
		linkLabel2 = new LinkLabel();
		linkLabel3 = new LinkLabel();
		button12 = new Button();
		((ISupportInitialize)trackBar1).BeginInit();
		((ISupportInitialize)trackBar2).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)tabPage4).SuspendLayout();
		((Control)tabPage5).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Location(new Point(12, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(109, 20));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("隐藏苍天挂(F10)");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)1);
		((Control)button2).set_Location(new Point(12, 38));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(109, 20));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("显示苍天挂(F11)");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)trackBar1).set_AutoSize(false);
		((Control)trackBar1).set_Location(new Point(184, 12));
		trackBar1.set_Maximum(100);
		((Control)trackBar1).set_Name("trackBar1");
		((Control)trackBar1).set_Size(new Size(114, 28));
		((Control)trackBar1).set_TabIndex(2);
		trackBar1.set_TickStyle((TickStyle)0);
		trackBar1.add_Scroll((EventHandler)trackBar1_Scroll);
		((Control)trackBar2).set_AutoSize(false);
		((Control)trackBar2).set_Location(new Point(184, 38));
		trackBar2.set_Maximum(200);
		((Control)trackBar2).set_Name("trackBar2");
		((Control)trackBar2).set_Size(new Size(114, 28));
		((Control)trackBar2).set_TabIndex(3);
		trackBar2.set_TickStyle((TickStyle)0);
		trackBar2.add_Scroll((EventHandler)trackBar2_Scroll);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(127, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(53, 12));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("移动速度");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(127, 42));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(53, 12));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("攻击速度");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(295, 16));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(11, 12));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("0");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(295, 42));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(11, 12));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("0");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(314, 16));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(11, 12));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("%");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(314, 42));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(11, 12));
		((Control)label6).set_TabIndex(9);
		((Control)label6).set_Text("%");
		((Control)groupBox1).get_Controls().Add((Control)(object)label13);
		((Control)groupBox1).get_Controls().Add((Control)(object)label12);
		((Control)groupBox1).get_Controls().Add((Control)(object)label11);
		((Control)groupBox1).get_Controls().Add((Control)(object)label10);
		((Control)groupBox1).get_Controls().Add((Control)(object)label9);
		((Control)groupBox1).get_Controls().Add((Control)(object)hScrollBar2);
		((Control)groupBox1).get_Controls().Add((Control)(object)hScrollBar1);
		((Control)groupBox1).get_Controls().Add((Control)(object)comboBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)comboBox1);
		((Control)groupBox1).get_Controls().Add((Control)(object)button4);
		((Control)groupBox1).get_Controls().Add((Control)(object)label8);
		((Control)groupBox1).get_Controls().Add((Control)(object)label7);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox2);
		((Control)groupBox1).set_Location(new Point(12, 60));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(314, 65));
		((Control)groupBox1).set_TabIndex(10);
		groupBox1.set_TabStop(false);
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_Location(new Point(250, 46));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(17, 12));
		((Control)label13).set_TabIndex(11);
		((Control)label13).set_Text("秒");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Location(new Point(250, 18));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(17, 12));
		((Control)label12).set_TabIndex(11);
		((Control)label12).set_Text("秒");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(233, 46));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(11, 12));
		((Control)label11).set_TabIndex(11);
		((Control)label11).set_Text("0");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(233, 18));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(11, 12));
		((Control)label10).set_TabIndex(11);
		((Control)label10).set_Text("0");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(176, 32));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(53, 12));
		((Control)label9).set_TabIndex(11);
		((Control)label9).set_Text("设置延迟");
		((Control)hScrollBar2).set_Location(new Point(172, 46));
		((ScrollBar)hScrollBar2).set_Maximum(99);
		((Control)hScrollBar2).set_Name("hScrollBar2");
		((Control)hScrollBar2).set_Size(new Size(58, 13));
		((Control)hScrollBar2).set_TabIndex(14);
		((ScrollBar)hScrollBar2).add_Scroll(new ScrollEventHandler(hScrollBar2_Scroll));
		((Control)hScrollBar1).set_Location(new Point(172, 15));
		((ScrollBar)hScrollBar1).set_Maximum(99);
		((Control)hScrollBar1).set_Name("hScrollBar1");
		((Control)hScrollBar1).set_Size(new Size(58, 13));
		((Control)hScrollBar1).set_TabIndex(11);
		((ScrollBar)hScrollBar1).add_Scroll(new ScrollEventHandler(hScrollBar1_Scroll));
		((Control)comboBox2).set_ForeColor(Color.FromArgb(255, 128, 0));
		((ListControl)comboBox2).set_FormattingEnabled(true);
		comboBox2.get_Items().AddRange(new object[4] { "淤血汤", "健血汤", "百灵汤(网吧)", "大补气血丹" });
		((Control)comboBox2).set_Location(new Point(88, 38));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(82, 20));
		((Control)comboBox2).set_TabIndex(11);
		((Control)comboBox2).set_Text("淤血汤");
		((Control)comboBox1).set_ForeColor(Color.Red);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[11]
		{
			"双和汤", "四君子汤", "葛根汤", "于根汤(网吧)", "健胜汤", "贵妃汤", "十全大补汤", "百花汤", "小青龙汤", "八阵汤",
			"大青龙汤"
		});
		((Control)comboBox1).set_Location(new Point(88, 15));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(82, 20));
		((Control)comboBox1).set_TabIndex(11);
		((Control)comboBox1).set_Text("双和汤");
		((ButtonBase)button4).set_FlatStyle((FlatStyle)1);
		((Control)button4).set_Location(new Point(267, 21));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(41, 35));
		((Control)button4).set_TabIndex(11);
		((Control)button4).set_Text("确认(F&5)");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)label8).set_Location(new Point(3, 42));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(41, 12));
		((Control)label8).set_TabIndex(13);
		((Control)label8).set_Text("行动力");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_ForeColor(Color.Red);
		((Control)label7).set_Location(new Point(3, 18));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(29, 12));
		((Control)label7).set_TabIndex(11);
		((Control)label7).set_Text("体力");
		((Control)textBox1).set_ForeColor(Color.Red);
		((Control)textBox1).set_Location(new Point(48, 14));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(38, 21));
		((Control)textBox1).set_TabIndex(11);
		((Control)textBox1).set_Text("500");
		((Control)textBox2).set_ForeColor(Color.FromArgb(255, 128, 0));
		((Control)textBox2).set_Location(new Point(48, 38));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(38, 21));
		((Control)textBox2).set_TabIndex(12);
		((Control)textBox2).set_Text("20");
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage3);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage4);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage5);
		((Control)tabControl1).set_Location(new Point(12, 128));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(315, 86));
		((Control)tabControl1).set_TabIndex(11);
		((Control)tabPage1).get_Controls().Add((Control)(object)button11);
		((Control)tabPage1).get_Controls().Add((Control)(object)label34);
		((Control)tabPage1).get_Controls().Add((Control)(object)label35);
		((Control)tabPage1).get_Controls().Add((Control)(object)label36);
		((Control)tabPage1).get_Controls().Add((Control)(object)label37);
		((Control)tabPage1).get_Controls().Add((Control)(object)label38);
		((Control)tabPage1).get_Controls().Add((Control)(object)hScrollBar9);
		((Control)tabPage1).get_Controls().Add((Control)(object)hScrollBar10);
		((Control)tabPage1).get_Controls().Add((Control)(object)comboBox12);
		((Control)tabPage1).get_Controls().Add((Control)(object)comboBox11);
		((Control)tabPage1).get_Controls().Add((Control)(object)comboBox7);
		((Control)tabPage1).get_Controls().Add((Control)(object)comboBox3);
		tabPage1.set_Location(new Point(4, 21));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(307, 61));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("剑客");
		tabPage1.set_UseVisualStyleBackColor(true);
		((ButtonBase)button11).set_FlatStyle((FlatStyle)1);
		((Control)button11).set_Location(new Point(224, 35));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(80, 20));
		((Control)button11).set_TabIndex(50);
		((Control)button11).set_Text("确认(F&3)");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)label34).set_AutoSize(true);
		((Control)label34).set_Location(new Point(3, 46));
		((Control)label34).set_Name("label34");
		((Control)label34).set_Size(new Size(209, 12));
		((Control)label34).set_TabIndex(48);
		((Control)label34).set_Text("技能延迟  必杀延迟  (推荐10秒以上)");
		((Control)label35).set_AutoSize(true);
		((Control)label35).set_Location(new Point(189, 30));
		((Control)label35).set_Name("label35");
		((Control)label35).set_Size(new Size(17, 12));
		((Control)label35).set_TabIndex(47);
		((Control)label35).set_Text("秒");
		((Control)label36).set_AutoSize(true);
		((Control)label36).set_Location(new Point(172, 30));
		((Control)label36).set_Name("label36");
		((Control)label36).set_Size(new Size(11, 12));
		((Control)label36).set_TabIndex(46);
		((Control)label36).set_Text("0");
		((Control)label37).set_AutoSize(true);
		((Control)label37).set_Location(new Point(82, 30));
		((Control)label37).set_Name("label37");
		((Control)label37).set_Size(new Size(17, 12));
		((Control)label37).set_TabIndex(45);
		((Control)label37).set_Text("秒");
		((Control)label38).set_AutoSize(true);
		((Control)label38).set_Location(new Point(65, 30));
		((Control)label38).set_Name("label38");
		((Control)label38).set_Size(new Size(11, 12));
		((Control)label38).set_TabIndex(44);
		((Control)label38).set_Text("0");
		((Control)hScrollBar9).set_Location(new Point(104, 29));
		((ScrollBar)hScrollBar9).set_Maximum(69);
		((Control)hScrollBar9).set_Name("hScrollBar9");
		((Control)hScrollBar9).set_Size(new Size(62, 13));
		((Control)hScrollBar9).set_TabIndex(43);
		((ScrollBar)hScrollBar9).add_Scroll(new ScrollEventHandler(hScrollBar9_Scroll));
		((Control)hScrollBar10).set_Location(new Point(0, 29));
		((ScrollBar)hScrollBar10).set_Maximum(69);
		((Control)hScrollBar10).set_Name("hScrollBar10");
		((Control)hScrollBar10).set_Size(new Size(62, 13));
		((Control)hScrollBar10).set_TabIndex(42);
		((ScrollBar)hScrollBar10).add_Scroll(new ScrollEventHandler(hScrollBar10_Scroll));
		((ListControl)comboBox12).set_FormattingEnabled(true);
		comboBox12.get_Items().AddRange(new object[17]
		{
			"弹步", "起上攻击", "起上回避", "全力疾走", "飞击", "迅速交替", "强击", "突进", "反击态势", "狮子吼",
			"双击", "推进击", "疾走攻击", "反击斩", "强袭", "风轮斩", "速射"
		});
		((Control)comboBox12).set_Location(new Point(150, 6));
		((Control)comboBox12).set_Name("comboBox12");
		((Control)comboBox12).set_Size(new Size(71, 20));
		((Control)comboBox12).set_TabIndex(15);
		((Control)comboBox12).set_Text("起上回避");
		((ListControl)comboBox11).set_FormattingEnabled(true);
		comboBox11.get_Items().AddRange(new object[17]
		{
			"弹步", "起上攻击", "起上回避", "全力疾走", "飞击", "迅速交替", "强击", "突进", "反击态势", "狮子吼",
			"双击", "推进击", "疾走攻击", "反击斩", "强袭", "风轮斩", "速射"
		});
		((Control)comboBox11).set_Location(new Point(75, 6));
		((Control)comboBox11).set_Name("comboBox11");
		((Control)comboBox11).set_Size(new Size(71, 20));
		((Control)comboBox11).set_TabIndex(14);
		((Control)comboBox11).set_Text("起上攻击");
		((ListControl)comboBox7).set_FormattingEnabled(true);
		comboBox7.get_Items().AddRange(new object[11]
		{
			"闪功烈斩", "斩破击", "燕月真", "疾风烈斩", "斩将闪", "闪攻剑", "断月阴", "连振", "疾风剑", "月刃击",
			"乱射"
		});
		((Control)comboBox7).set_Location(new Point(224, 6));
		((Control)comboBox7).set_Name("comboBox7");
		((Control)comboBox7).set_Size(new Size(80, 20));
		((Control)comboBox7).set_TabIndex(13);
		((Control)comboBox7).set_Text("剑必杀技");
		((ListControl)comboBox3).set_FormattingEnabled(true);
		comboBox3.get_Items().AddRange(new object[17]
		{
			"弹步", "起上攻击", "起上回避", "全力疾走", "飞击", "迅速交替", "强击", "突进", "反击态势", "狮子吼",
			"双击", "推进击", "疾走攻击", "反击斩", "强袭", "风轮斩", "速射"
		});
		((Control)comboBox3).set_Location(new Point(0, 6));
		((Control)comboBox3).set_Name("comboBox3");
		((Control)comboBox3).set_Size(new Size(71, 20));
		((Control)comboBox3).set_TabIndex(12);
		((Control)comboBox3).set_Text("弹步");
		((Control)tabPage2).get_Controls().Add((Control)(object)button10);
		((Control)tabPage2).get_Controls().Add((Control)(object)label28);
		((Control)tabPage2).get_Controls().Add((Control)(object)label29);
		((Control)tabPage2).get_Controls().Add((Control)(object)label30);
		((Control)tabPage2).get_Controls().Add((Control)(object)label31);
		((Control)tabPage2).get_Controls().Add((Control)(object)label32);
		((Control)tabPage2).get_Controls().Add((Control)(object)hScrollBar7);
		((Control)tabPage2).get_Controls().Add((Control)(object)hScrollBar8);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox14);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox13);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox8);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox4);
		tabPage2.set_Location(new Point(4, 21));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(307, 61));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("侠客");
		tabPage2.set_UseVisualStyleBackColor(true);
		((ButtonBase)button10).set_FlatStyle((FlatStyle)1);
		((Control)button10).set_Location(new Point(224, 35));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(80, 20));
		((Control)button10).set_TabIndex(50);
		((Control)button10).set_Text("确认(F&3)");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)label28).set_AutoSize(true);
		((Control)label28).set_Location(new Point(3, 46));
		((Control)label28).set_Name("label28");
		((Control)label28).set_Size(new Size(209, 12));
		((Control)label28).set_TabIndex(48);
		((Control)label28).set_Text("技能延迟  必杀延迟  (推荐10秒以上)");
		((Control)label29).set_AutoSize(true);
		((Control)label29).set_Location(new Point(189, 30));
		((Control)label29).set_Name("label29");
		((Control)label29).set_Size(new Size(17, 12));
		((Control)label29).set_TabIndex(47);
		((Control)label29).set_Text("秒");
		((Control)label30).set_AutoSize(true);
		((Control)label30).set_Location(new Point(172, 30));
		((Control)label30).set_Name("label30");
		((Control)label30).set_Size(new Size(11, 12));
		((Control)label30).set_TabIndex(46);
		((Control)label30).set_Text("0");
		((Control)label31).set_AutoSize(true);
		((Control)label31).set_Location(new Point(82, 30));
		((Control)label31).set_Name("label31");
		((Control)label31).set_Size(new Size(17, 12));
		((Control)label31).set_TabIndex(45);
		((Control)label31).set_Text("秒");
		((Control)label32).set_AutoSize(true);
		((Control)label32).set_Location(new Point(65, 30));
		((Control)label32).set_Name("label32");
		((Control)label32).set_Size(new Size(11, 12));
		((Control)label32).set_TabIndex(44);
		((Control)label32).set_Text("0");
		((Control)hScrollBar7).set_Location(new Point(104, 29));
		((ScrollBar)hScrollBar7).set_Maximum(69);
		((Control)hScrollBar7).set_Name("hScrollBar7");
		((Control)hScrollBar7).set_Size(new Size(62, 13));
		((Control)hScrollBar7).set_TabIndex(43);
		((ScrollBar)hScrollBar7).add_Scroll(new ScrollEventHandler(hScrollBar7_Scroll));
		((Control)hScrollBar8).set_Location(new Point(0, 29));
		((ScrollBar)hScrollBar8).set_Maximum(69);
		((Control)hScrollBar8).set_Name("hScrollBar8");
		((Control)hScrollBar8).set_Size(new Size(62, 13));
		((Control)hScrollBar8).set_TabIndex(42);
		((ScrollBar)hScrollBar8).add_Scroll(new ScrollEventHandler(hScrollBar8_Scroll));
		((ListControl)comboBox14).set_FormattingEnabled(true);
		comboBox14.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "全力疾走", "飞击", "迅速交替", "突进", "回击", "狮子吼", "狂暴态势",
			"进龙击", "连击", "疾走攻击", "暴走态势", "移象", "炼狱", "速射"
		});
		((Control)comboBox14).set_Location(new Point(150, 6));
		((Control)comboBox14).set_Name("comboBox14");
		((Control)comboBox14).set_Size(new Size(71, 20));
		((Control)comboBox14).set_TabIndex(16);
		((Control)comboBox14).set_Text("起上回避");
		((ListControl)comboBox13).set_FormattingEnabled(true);
		comboBox13.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "全力疾走", "飞击", "迅速交替", "突进", "回击", "狮子吼", "狂暴态势",
			"进龙击", "连击", "疾走攻击", "暴走态势", "移象", "炼狱", "速射"
		});
		((Control)comboBox13).set_Location(new Point(75, 6));
		((Control)comboBox13).set_Name("comboBox13");
		((Control)comboBox13).set_Size(new Size(71, 20));
		((Control)comboBox13).set_TabIndex(15);
		((Control)comboBox13).set_Text("起上攻击");
		((ListControl)comboBox8).set_FormattingEnabled(true);
		comboBox8.get_Items().AddRange(new object[11]
		{
			"双空牙", "火影", "烈阵闪", "偃舞", "重剑", "空牙", "血红莲", "列闪", "云舞", "红莲",
			"乱射"
		});
		((Control)comboBox8).set_Location(new Point(224, 6));
		((Control)comboBox8).set_Name("comboBox8");
		((Control)comboBox8).set_Size(new Size(80, 20));
		((Control)comboBox8).set_TabIndex(14);
		((Control)comboBox8).set_Text("侠必杀技");
		((ListControl)comboBox4).set_FormattingEnabled(true);
		comboBox4.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "全力疾走", "飞击", "迅速交替", "突进", "回击", "狮子吼", "狂暴态势",
			"进龙击", "连击", "疾走攻击", "暴走态势", "移象", "炼狱", "速射"
		});
		((Control)comboBox4).set_Location(new Point(0, 6));
		((Control)comboBox4).set_Name("comboBox4");
		((Control)comboBox4).set_Size(new Size(71, 20));
		((Control)comboBox4).set_TabIndex(13);
		((Control)comboBox4).set_Text("落步");
		((Control)tabPage3).get_Controls().Add((Control)(object)button9);
		((Control)tabPage3).get_Controls().Add((Control)(object)label22);
		((Control)tabPage3).get_Controls().Add((Control)(object)label23);
		((Control)tabPage3).get_Controls().Add((Control)(object)label24);
		((Control)tabPage3).get_Controls().Add((Control)(object)label25);
		((Control)tabPage3).get_Controls().Add((Control)(object)label26);
		((Control)tabPage3).get_Controls().Add((Control)(object)hScrollBar5);
		((Control)tabPage3).get_Controls().Add((Control)(object)hScrollBar6);
		((Control)tabPage3).get_Controls().Add((Control)(object)comboBox16);
		((Control)tabPage3).get_Controls().Add((Control)(object)comboBox15);
		((Control)tabPage3).get_Controls().Add((Control)(object)comboBox9);
		((Control)tabPage3).get_Controls().Add((Control)(object)comboBox5);
		tabPage3.set_Location(new Point(4, 21));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Padding(new Padding(3));
		((Control)tabPage3).set_Size(new Size(307, 61));
		tabPage3.set_TabIndex(2);
		((Control)tabPage3).set_Text("力士");
		tabPage3.set_UseVisualStyleBackColor(true);
		((Control)tabPage3).add_Click((EventHandler)tabPage3_Click);
		((ButtonBase)button9).set_FlatStyle((FlatStyle)1);
		((Control)button9).set_Location(new Point(224, 35));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(80, 20));
		((Control)button9).set_TabIndex(41);
		((Control)button9).set_Text("确认(F&3)");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)label22).set_AutoSize(true);
		((Control)label22).set_Location(new Point(3, 46));
		((Control)label22).set_Name("label22");
		((Control)label22).set_Size(new Size(209, 12));
		((Control)label22).set_TabIndex(39);
		((Control)label22).set_Text("技能延迟  必杀延迟  (推荐10秒以上)");
		((Control)label23).set_AutoSize(true);
		((Control)label23).set_Location(new Point(189, 30));
		((Control)label23).set_Name("label23");
		((Control)label23).set_Size(new Size(17, 12));
		((Control)label23).set_TabIndex(38);
		((Control)label23).set_Text("秒");
		((Control)label24).set_AutoSize(true);
		((Control)label24).set_Location(new Point(172, 30));
		((Control)label24).set_Name("label24");
		((Control)label24).set_Size(new Size(11, 12));
		((Control)label24).set_TabIndex(37);
		((Control)label24).set_Text("0");
		((Control)label25).set_AutoSize(true);
		((Control)label25).set_Location(new Point(82, 30));
		((Control)label25).set_Name("label25");
		((Control)label25).set_Size(new Size(17, 12));
		((Control)label25).set_TabIndex(36);
		((Control)label25).set_Text("秒");
		((Control)label26).set_AutoSize(true);
		((Control)label26).set_Location(new Point(65, 30));
		((Control)label26).set_Name("label26");
		((Control)label26).set_Size(new Size(11, 12));
		((Control)label26).set_TabIndex(35);
		((Control)label26).set_Text("0");
		((Control)hScrollBar5).set_Location(new Point(104, 29));
		((ScrollBar)hScrollBar5).set_Maximum(69);
		((Control)hScrollBar5).set_Name("hScrollBar5");
		((Control)hScrollBar5).set_Size(new Size(62, 13));
		((Control)hScrollBar5).set_TabIndex(34);
		((ScrollBar)hScrollBar5).add_Scroll(new ScrollEventHandler(hScrollBar5_Scroll));
		((Control)hScrollBar6).set_Location(new Point(0, 29));
		((ScrollBar)hScrollBar6).set_Maximum(69);
		((Control)hScrollBar6).set_Name("hScrollBar6");
		((Control)hScrollBar6).set_Size(new Size(62, 13));
		((Control)hScrollBar6).set_TabIndex(33);
		((ScrollBar)hScrollBar6).add_Scroll(new ScrollEventHandler(hScrollBar6_Scroll));
		((ListControl)comboBox16).set_FormattingEnabled(true);
		comboBox16.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "盾牌格挡", "盾击", "迅速交替", "突进", "推击", "狂暴态势", "狮子吼",
			"回转击", "回浪击", "方阵斩", "暴走态势", "旋风击", "背轮打", "速射"
		});
		((Control)comboBox16).set_Location(new Point(150, 6));
		((Control)comboBox16).set_Name("comboBox16");
		((Control)comboBox16).set_Size(new Size(71, 20));
		((Control)comboBox16).set_TabIndex(17);
		((Control)comboBox16).set_Text("起上回避");
		((ListControl)comboBox15).set_FormattingEnabled(true);
		comboBox15.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "盾牌格挡", "盾击", "迅速交替", "突进", "推击", "狂暴态势", "狮子吼",
			"回转击", "回浪击", "方阵斩", "暴走态势", "旋风击", "背轮打", "速射"
		});
		((Control)comboBox15).set_Location(new Point(75, 6));
		((Control)comboBox15).set_Name("comboBox15");
		((Control)comboBox15).set_Size(new Size(71, 20));
		((Control)comboBox15).set_TabIndex(16);
		((Control)comboBox15).set_Text("起上攻击");
		((ListControl)comboBox9).set_FormattingEnabled(true);
		comboBox9.get_Items().AddRange(new object[11]
		{
			"大霹雳斧", "狼牙斩", "玄武绞厄", "旋风烈斩", "破骨", "霹雳斧", "大地波动", "绞厄", "旋风斩", "大地震动",
			"乱射"
		});
		((Control)comboBox9).set_Location(new Point(224, 6));
		((Control)comboBox9).set_Name("comboBox9");
		((Control)comboBox9).set_Size(new Size(80, 20));
		((Control)comboBox9).set_TabIndex(15);
		((Control)comboBox9).set_Text("力必杀技");
		((ListControl)comboBox5).set_FormattingEnabled(true);
		comboBox5.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "盾牌格挡", "盾击", "迅速交替", "突进", "推击", "狂暴态势", "狮子吼",
			"回转击", "回浪击", "方阵斩", "暴走态势", "旋风击", "背轮打", "速射"
		});
		((Control)comboBox5).set_Location(new Point(0, 6));
		((Control)comboBox5).set_Name("comboBox5");
		((Control)comboBox5).set_Size(new Size(71, 20));
		((Control)comboBox5).set_TabIndex(14);
		((Control)comboBox5).set_Text("落步");
		((Control)tabPage4).get_Controls().Add((Control)(object)button8);
		((Control)tabPage4).get_Controls().Add((Control)(object)label19);
		((Control)tabPage4).get_Controls().Add((Control)(object)label17);
		((Control)tabPage4).get_Controls().Add((Control)(object)label18);
		((Control)tabPage4).get_Controls().Add((Control)(object)label16);
		((Control)tabPage4).get_Controls().Add((Control)(object)label15);
		((Control)tabPage4).get_Controls().Add((Control)(object)hScrollBar4);
		((Control)tabPage4).get_Controls().Add((Control)(object)hScrollBar3);
		((Control)tabPage4).get_Controls().Add((Control)(object)comboBox18);
		((Control)tabPage4).get_Controls().Add((Control)(object)comboBox17);
		((Control)tabPage4).get_Controls().Add((Control)(object)comboBox10);
		((Control)tabPage4).get_Controls().Add((Control)(object)comboBox6);
		tabPage4.set_Location(new Point(4, 21));
		((Control)tabPage4).set_Name("tabPage4");
		((Control)tabPage4).set_Padding(new Padding(3));
		((Control)tabPage4).set_Size(new Size(307, 61));
		tabPage4.set_TabIndex(3);
		((Control)tabPage4).set_Text("武士");
		tabPage4.set_UseVisualStyleBackColor(true);
		((ButtonBase)button8).set_FlatStyle((FlatStyle)1);
		((Control)button8).set_Location(new Point(224, 35));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(80, 20));
		((Control)button8).set_TabIndex(32);
		((Control)button8).set_Text("确认(F&3)");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)label19).set_AutoSize(true);
		((Control)label19).set_Location(new Point(3, 46));
		((Control)label19).set_Name("label19");
		((Control)label19).set_Size(new Size(209, 12));
		((Control)label19).set_TabIndex(30);
		((Control)label19).set_Text("技能延迟  必杀延迟  (推荐10秒以上)");
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Location(new Point(189, 30));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(17, 12));
		((Control)label17).set_TabIndex(29);
		((Control)label17).set_Text("秒");
		((Control)label18).set_AutoSize(true);
		((Control)label18).set_Location(new Point(172, 30));
		((Control)label18).set_Name("label18");
		((Control)label18).set_Size(new Size(11, 12));
		((Control)label18).set_TabIndex(28);
		((Control)label18).set_Text("0");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(82, 30));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(17, 12));
		((Control)label16).set_TabIndex(27);
		((Control)label16).set_Text("秒");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(65, 30));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(11, 12));
		((Control)label15).set_TabIndex(26);
		((Control)label15).set_Text("0");
		((Control)hScrollBar4).set_Location(new Point(104, 29));
		((ScrollBar)hScrollBar4).set_Maximum(69);
		((Control)hScrollBar4).set_Name("hScrollBar4");
		((Control)hScrollBar4).set_Size(new Size(62, 13));
		((Control)hScrollBar4).set_TabIndex(25);
		((ScrollBar)hScrollBar4).add_Scroll(new ScrollEventHandler(hScrollBar4_Scroll));
		((Control)hScrollBar3).set_Location(new Point(0, 29));
		((ScrollBar)hScrollBar3).set_Maximum(69);
		((Control)hScrollBar3).set_Name("hScrollBar3");
		((Control)hScrollBar3).set_Size(new Size(62, 13));
		((Control)hScrollBar3).set_TabIndex(24);
		((ScrollBar)hScrollBar3).add_Scroll(new ScrollEventHandler(hScrollBar3_Scroll));
		((ListControl)comboBox18).set_FormattingEnabled(true);
		comboBox18.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "盾牌格挡", "升龙斩", "迅速交替", "强击", "突进", "反击态势", "狮子吼",
			"双击", "震风斩", "方阵斩", "反击斩", "迅击", "影闪", "速射"
		});
		((Control)comboBox18).set_Location(new Point(150, 6));
		((Control)comboBox18).set_Name("comboBox18");
		((Control)comboBox18).set_Size(new Size(71, 20));
		((Control)comboBox18).set_TabIndex(18);
		((Control)comboBox18).set_Text("起上回避");
		((ListControl)comboBox17).set_FormattingEnabled(true);
		comboBox17.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "盾牌格挡", "升龙斩", "迅速交替", "强击", "突进", "反击态势", "狮子吼",
			"双击", "震风斩", "方阵斩", "反击斩", "迅击", "影闪", "速射"
		});
		((Control)comboBox17).set_Location(new Point(75, 6));
		((Control)comboBox17).set_Name("comboBox17");
		((Control)comboBox17).set_Size(new Size(71, 20));
		((Control)comboBox17).set_TabIndex(17);
		((Control)comboBox17).set_Text("起上攻击");
		((ListControl)comboBox10).set_FormattingEnabled(true);
		comboBox10.get_Items().AddRange(new object[11]
		{
			"朱雀螺环", "月强波", "猛虎锐爪", "螺旋双轮", "热风斩", "朱雀环", "半月双打", "猛虎卧宿", "螺旋轮", "半月斩",
			"乱射"
		});
		((Control)comboBox10).set_Location(new Point(224, 6));
		((Control)comboBox10).set_Name("comboBox10");
		((Control)comboBox10).set_Size(new Size(80, 20));
		((Control)comboBox10).set_TabIndex(16);
		((Control)comboBox10).set_Text("武必杀技");
		((ListControl)comboBox6).set_FormattingEnabled(true);
		comboBox6.get_Items().AddRange(new object[17]
		{
			"落步", "起上攻击", "起上回避", "盾牌格挡", "升龙斩", "迅速交替", "强击", "突进", "反击态势", "狮子吼",
			"双击", "震风斩", "方阵斩", "反击斩", "迅击", "影闪", "速射"
		});
		((Control)comboBox6).set_Location(new Point(0, 6));
		((Control)comboBox6).set_Name("comboBox6");
		((Control)comboBox6).set_Size(new Size(71, 20));
		((Control)comboBox6).set_TabIndex(15);
		((Control)comboBox6).set_Text("落步");
		((Control)tabPage5).get_Controls().Add((Control)(object)label14);
		((Control)tabPage5).get_Controls().Add((Control)(object)button5);
		((Control)tabPage5).get_Controls().Add((Control)(object)comboBox23);
		((Control)tabPage5).get_Controls().Add((Control)(object)comboBox22);
		((Control)tabPage5).get_Controls().Add((Control)(object)comboBox21);
		((Control)tabPage5).get_Controls().Add((Control)(object)comboBox20);
		((Control)tabPage5).get_Controls().Add((Control)(object)comboBox19);
		tabPage5.set_Location(new Point(4, 21));
		((Control)tabPage5).set_Name("tabPage5");
		((Control)tabPage5).set_Padding(new Padding(3));
		((Control)tabPage5).set_Size(new Size(307, 61));
		tabPage5.set_TabIndex(4);
		((Control)tabPage5).set_Text("挂机地图");
		tabPage5.set_UseVisualStyleBackColor(true);
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_Location(new Point(-1, 47));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(299, 12));
		((Control)label14).set_TabIndex(24);
		((Control)label14).set_Text("选择所需要的地图脚本进行挂机,确认按扭予以确认(F&2)");
		((ButtonBase)button5).set_FlatStyle((FlatStyle)1);
		((Control)button5).set_Location(new Point(237, 24));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(64, 20));
		((Control)button5).set_TabIndex(5);
		((Control)button5).set_Text("确认(F&2)");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((ListControl)comboBox23).set_FormattingEnabled(true);
		comboBox23.get_Items().AddRange(new object[599]
		{
			"[演练场]近战训练1", "黄巾军讨伐军", "候战室", "普通对练场", "国境战场", "城门前", "董卓掠夺战场", "小规模对练场", "盗马军阵营", "兴汉军阵营",
			"人乌军阵营", "黄巾军 侦察军", "黄巾军 搜查军", "袁术掠夺战场", "训练战场", "黄巾军 太平3军", "黄巾军 离合天军", "黄巾军 合一天军", "严白虎军 1军营", "袁绍军 3军营",
			"刘焉军 2军营", "王郎军 1军营", "刘焉军 1军营", "孔融军 弓箭手", "董卓军 3军营", "王郎军 2军营", "孔伷军 1军营", "张邈军 1军营", "孔融军 1军营", "黄巾军 三位人军",
			"黄巾军 补给1军", "韩玄军 弓箭手", "黄巾军 离合人军", "陶谦军 1军营", "刘岱军1军营", "首阳山入口", "狼牙平原", "白马内黄", "荥阳永宁", "博望山麓",
			"古城余音", "秦县灵壁", "淮阴山地", "石亭平原", "牛渚武威", "背玉山麓", "夏口入口", "泰山入口", "鱼腹浦", "位兴韩遂",
			"天荡山地", "剑阁险地", "广汉盆地", "建威舞阳", "列柳城退路", "子午谷险路", "金城入口", "陇西高原", "北地险路", "辛评入口",
			"上党入口", "太行山入口", "清河内黄", "乐安港湾", "芒砀入口", "大梁平原", "竟陵入口", "南乡峡谷", "雷阳林野", "邵陵安乡",
			"苍梧北部", "郁林合浦", "建安延平", "临川峡谷", "副城入口", "云南许昌", "云南沙口", "乌林北部", "沓中入口", "嘉定渭川",
			"华山入口", "狼牙前阳", "朝歌", "荥阳高原", "博望登县", "古城南亭", "秦县入口", "淮阴安风", "石亭硖石", "广陵镇安",
			"牛渚三山", "豫章入口", "南部夏口", "北部夷陵", "白帝入口", "东部魏兴", "南定军山", "剑阁西充", "巴郡广汉", "官渡林野",
			"河内入口", "北南梁县", "濡须荒江", "丹阳南端", "南昌湖水", "武昌入口", "鄱阳洞庭", "济北黄河边", "济北入口", "巨野北部",
			"巨野南部", "彭城险地", "长坂山麓", "樊城险地", "新城入口 ", "巴西南江", "张家中水", "云南回天", "落凤坡", "阴平险路",
			"嘉定入口", "造阳入口", "白马阳平", "元山山野", "博望入口", "古城案件", "秦县贺齐", "淮阴东县", "石亭江边", "广陵东端",
			"牛渚虎林", "玉华山边", "夏口江边", "夷陵山麓", "八阵图", "位兴山野", "武乡入口 ", "剑阁山地", "西部广汉", "建威西陵",
			"渭水入口", "斜谷入口", "金城退路", "陇西林野", "辛评西部", "上党北部", "壶关入口", "清河南部", "乐安下流", "芒砀险地",
			"大梁许典", "黎阳南部", "竟陵水路", "南乡山地", "雷阳背山", "邵陵草地", "苍梧峰台", "郁林西部", "建安流放地", "临川贫村",
			"长坂峡谷", "樊城东端", "巴西寿亭", "张家外水", "济北平野", "巨野平原", "北彭元城", "官渡高原", "高山入口", "南阳巨山",
			"濡须平原", "曲阿亶洲", "丹阳吴兴", "东部南昌", "严安外角", "嘉定北原", "红衣入口", "狼牙山麓", "白马邺阳", "西荥阳入口",
			"博望险路", "古城险地", "秦县平原 ", "淮阴北县", "石亭领县", "广陵真阴 ", "牛渚平原", "豫章北端", "夏口丘陵 ", "夷陵建平",
			"北白帝城", "南部魏兴 ", "剑阁德阳", "东部广汉", "建威青城", "牛头山血路", "辛评退路", "金城东部", "陇西外角", "北地丘陵",
			"辛评武功", "上党南部 ", "壶关埋伏地", "清河毛城", "乐安平原", "芒砀山军", "大梁东部", "黎阳贺齐", "竟陵南郡", "南乡江边",
			"雷阳草地", "邵陵平野", "苍梧苏妻", "郁林平原", "竟山入口", "黄巾军 ", "竟陵东部", "南乡东部", "雷阳丘陵", "邵陵入口",
			"苍梧顺堎", "郁林险路", "建安入口", "临川苏妻", "公安帝陵", "长坂退路", "公安西陵", "公安丘陵", "新城房陵", "曲阿东部",
			"鄱阳西部", "鄱阳安城", "汉水水路", "汉水丘陵", "汉水南部 ", "濡须南部 ", "祁山文山  ", "黄巾军 合一地军", "云南关埠", "汉水东部",
			"南阳两牌", "公安巴江", "长坂衡山", "樊城入口", "巴天入口", "张家江阳", "临川溪谷", "洛城入口", "武都险路", "嘉定金城",
			"北高山地", "济北镇山", "九里山", "彭城入口", "官渡平原 ", "汎水入口", "南阳山地", "濡须长江", "丹阳北端", "北部南昌",
			"三江入口", "鄱阳丘陵", "建威盆地", "狼牙林野", "北地高原", "新城甜水", "西定军山", "建安险地", "广陵南端", "黎阳平原",
			"袁绍军 2军营", "西彭临城", "黄河西部", "高山险地", "丹阳神亭", "南昌武穆 ", "建昌入口", "新城退路", "巴西山地", "张家盆地",
			"岳阳入口", "武功乡退路", "金城外地", "陇西入口", "北地入口", "辛评江边", "上党高原 ", "平阳向入口", "清河平原", "乐安入口",
			"芒砀峡谷", "大梁北部", "黎阳山野  ", "曲阿入口", "袁绍军 1军营", "山越军 1军营", "孔伷军 2军营", "董卓军 弓箭手", "韩馥军 1军营", "嗣王军",
			"刘岱军", "黄巾军 补给3军", "濡须", "长坂", "淮阴", "位兴", "陇西", "大梁", "郁林", "柴桑城门",
			"邺城门", "武陵城门", "晋阳城门", "永安内城", "小沛内城", "上庸内城", "越嶲内城", "南海内城", "汉中内城", "寿春内城",
			"新野内城", "吴内城", "桂阳内城", "洛阳内城", "庐江内城", "汝南内城", "长沙内城", "汉中城门", "洛阳城门", "清河 ",
			"上党", "古城", "夷陵", "五丈原", "乐安", "邵陵", "西凉城门", "襄阳内城", "下邳内城", "天水内城",
			"西凉内城", "江陵内城", "北海内城", "梓潼内城", "建宁内城", "石亭", "广陵", "剑阁", "辛评", "临川",
			"长安城门", "合肥城门", "宛城门", "山越城门", "谯城门", "博望坡", "济北", "汉水", "丹阳", "巨野",
			"南阳", "南昌", "公安", "巴西", "祁山", "白马", "秦 ", "牛渚", "白帝城", "广汉",
			"金城", "绵竹关", "新城", "江陵城门", "北海城门", "梓潼城门", "建宁城门", "襄阳城门", "官渡", "曲阿",
			"鄱阳", "樊城", "云南", "东关", "夏口", "定军山", "长安内城", "合肥内城", "宛内城", "山越内城",
			"谯内城", "狼牙", "长沙城门  ", "吴城门", "建安", "苍梧", "雷阳", "竟陵", "黎阳", "芒砀山",
			"北地", "嘉定", "平原内城", "虎牢关", "彭城", "乌林", "张家", "荥阳", "豫章", "建威",
			"壶关", "南乡", "江夏内城", "濮阳内城", "江州内城", "安定内城", "下邳城门", "寿春城门", "庐江城门", "江夏城门",
			"阳平关", "安定城门", "桂阳城门", "平原城门 ", "柴桑内城", "邺内城", "武陵内城", "晋阳内城", "江州城门", "朱隽逃脱路",
			"天水城门", "新野城门", "汝南城门", "濮阳城门", "永安城门", "小沛城门", "上庸城门", "越嶲城门", "南海城门", "董卓军 2军营",
			"张鲁军 1教军", "山越军 2军营", "张鲁军 2教军", "黄巾军 离合地军", "张邈军 2军营", "孔融军 2军营", "马腾军 先锋队", "袁术军 3军营", "黄巾军 合一人军", "严白虎军 2军营",
			"黄巾军 弓箭手", "金旋军 3军营", "山越军 3军营", "黄巾军 补给2军", "董卓军 补给队", "黑山军 1军", "嗣王军 2军营", "碧山军 1军", "黄巾军 太平1军", "黄巾军 三位天军",
			"官渡", "南阳", "荥阳", "濡须", "建安", "云南", "东关", "黎阳", "石亭", "樊城",
			"乌林", "长坂", "公安", "汉水", "临川", "南乡", "邵陵", "郁林", "淮阴", "广陵",
			"豫章", "夷陵", "位兴", "剑阁", "建威", "五丈原", "陇西", "辛评", "壶关", "乐安",
			"曲阿", "绵竹关", "鄱阳", "张家", "巴西", "新城", "白马", "芒砀山", "广汉", "嘉定",
			"清河", "狼牙", "济北", "虎牢关", "丹阳", "秦", "牛渚", "夏口", "白帝城", "定军山",
			"古城", "彭城", "阳平关", "金城", "北地", "上党", "大梁", "祁山", "巨野", "竟陵",
			"张鲁军讨伐战场", "苍梧", "雷阳", "博望", "南昌", "碧山军 2军", "黄巾军 三位地军", "黑山军 2军", "伯珪军 先锋队", "吕布军 先锋队",
			"韩玄军 1军营", "嗣王军 3军营", "袁绍军 4军营", "泰山军 1军营", "陶谦军 2军营", "汉中城门", "江夏城门", "寿春城门", "濮阳城门", "新野城门",
			"江州城门", "安定城门", "平原城门", "长沙城门", "吴城门", "北海城门", "宛城门", "梓潼城门", "山越城门", "建宁城门",
			"谯城门", "董卓军 1军营", "泰山军2军营", "永安城门", "小沛城门", "邺城门", "上庸城门", "武陵城门", "越嶲城门", "晋阳城门",
			"南海城门", "合肥城门", "西凉城门", "长安城门", "江陵城门", "韩玄军 2军营", "桂阳城门", "洛阳城门", "襄阳城门", "庐江城门",
			"下邳城门", "汝南城门", "天水城门", "柴桑城门", "韩馥军 2军营", "乌丸族 天马军", "金旋军 1军营", "张鲁军 3教军", "金旋军 2军营", "伯珪军 2军营",
			"建宁军  前军", "袁术军 讨伐战场", "马腾军 3军营", "袁绍军  中军", "董卓军 4军营", "袁术军 1军营", "袁术军 2军营", "伯珪军 1军营", "马腾军 1军营", "建宁军  中军",
			"吕布军 1军营", "吕布的最后", "刘表军 1军营", "刘表军 2军营", "吕布军 2军营", "马腾军 2军营", "山越军 4军营", "建宁军  后军", "袁绍军 5军营"
		});
		((Control)comboBox23).set_Location(new Point(136, 24));
		((Control)comboBox23).set_Name("comboBox23");
		((Control)comboBox23).set_Size(new Size(95, 20));
		((Control)comboBox23).set_TabIndex(4);
		((Control)comboBox23).set_Text("其它地图选择");
		((ListControl)comboBox22).set_FormattingEnabled(true);
		comboBox22.get_Items().AddRange(new object[30]
		{
			"宛城战斗", "宛城官舍", "宛城附近的我军营寨", "盱眙地区孙坚的自宅", "下邳城官厅", "宛城官舍", "宛城附近的我军营寨", "卢植将军 陈忠", "桃园结义", "涿县",
			"颖川附近的我军营寨", "谯县曹操的本家", "谯县曹操的本家", "泸州黄巾军讨伐", "张独目讨伐战", "许昌讨伐战", "幽州城涿郡战斗", "朱青讨伐战", "天地硝烟", "曲阳之战",
			"颖川之战", "六德讨伐战", "遇见大英雄", "少女的报答", "与张飞的胜负", "异样的眼神", "朱隽逃脱路", "张鲁军讨伐战场", "袁术军 讨伐战场", "吕布的最后"
		});
		((Control)comboBox22).set_Location(new Point(0, 24));
		((Control)comboBox22).set_Name("comboBox22");
		((Control)comboBox22).set_Size(new Size(130, 20));
		((Control)comboBox22).set_TabIndex(3);
		((Control)comboBox22).set_Text("剧情地图选择");
		((ListControl)comboBox21).set_FormattingEnabled(true);
		comboBox21.get_Items().AddRange(new object[17]
		{
			"建业", "建业训练场", "江陵", "江夏", "柴桑", "庐江", "合肥", "寿春", "武陵", "长沙",
			"山越", "吴", "桂阳", "南海", "建业城门", "建业内城", "建业城门"
		});
		((Control)comboBox21).set_Location(new Point(206, 2));
		((Control)comboBox21).set_Name("comboBox21");
		((Control)comboBox21).set_Size(new Size(95, 20));
		((Control)comboBox21).set_TabIndex(2);
		((Control)comboBox21).set_Text("吴国地图选择");
		((ListControl)comboBox20).set_FormattingEnabled(true);
		comboBox20.get_Items().AddRange(new object[17]
		{
			"洛阳", "小沛", "下邳", "北海", "濮阳", "邺", "汝南", "宛", "新野", "晋阳",
			"平原", "谯", "许都训练场", "许都", "许都城门", "许都内城", "许都城门"
		});
		((Control)comboBox20).set_Location(new Point(103, 2));
		((Control)comboBox20).set_Name("comboBox20");
		((Control)comboBox20).set_Size(new Size(95, 20));
		((Control)comboBox20).set_TabIndex(1);
		((Control)comboBox20).set_Text("魏国地图选择");
		((ListControl)comboBox19).set_FormattingEnabled(true);
		comboBox19.get_Items().AddRange(new object[17]
		{
			"成都", "长安", "汉中", "永安", "襄阳", "上庸", "天水", "江州", "越嶲", "西凉",
			"建宁", "安定", "梓潼", "成都训练场", "成都内城", "成都城门", "成都城门"
		});
		((Control)comboBox19).set_Location(new Point(0, 2));
		((Control)comboBox19).set_Name("comboBox19");
		((Control)comboBox19).set_Size(new Size(95, 20));
		((Control)comboBox19).set_TabIndex(0);
		((Control)comboBox19).set_Text("蜀国地图选择");
		((ButtonBase)button3).set_FlatStyle((FlatStyle)1);
		((Control)button3).set_Location(new Point(103, 345));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(70, 22));
		((Control)button3).set_TabIndex(12);
		((Control)button3).set_Text("保存设置");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)1);
		((Control)button6).set_Location(new Point(179, 345));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(70, 22));
		((Control)button6).set_TabIndex(14);
		((Control)button6).set_Text("启动外挂");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((ButtonBase)button7).set_FlatStyle((FlatStyle)1);
		((Control)button7).set_Location(new Point(255, 345));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(70, 22));
		((Control)button7).set_TabIndex(15);
		((Control)button7).set_Text("关闭外挂");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)richTextBox1).set_Location(new Point(12, 238));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(313, 85));
		((Control)richTextBox1).set_TabIndex(16);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(17, 216));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(72, 16));
		((Control)checkBox1).set_TabIndex(17);
		((Control)checkBox1).set_Text("补充弓箭");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(97, 216));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(72, 16));
		((Control)checkBox2).set_TabIndex(18);
		((Control)checkBox2).set_Text("招招毙命");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		((Control)checkBox3).set_AutoSize(true);
		((Control)checkBox3).set_Location(new Point(175, 216));
		((Control)checkBox3).set_Name("checkBox3");
		((Control)checkBox3).set_Size(new Size(72, 16));
		((Control)checkBox3).set_TabIndex(19);
		((Control)checkBox3).set_Text("提高命中");
		((ButtonBase)checkBox3).set_UseVisualStyleBackColor(true);
		((Control)checkBox4).set_AutoSize(true);
		((Control)checkBox4).set_Location(new Point(251, 216));
		((Control)checkBox4).set_Name("checkBox4");
		((Control)checkBox4).set_Size(new Size(72, 16));
		((Control)checkBox4).set_TabIndex(24);
		((Control)checkBox4).set_Text("防御加倍");
		((ButtonBase)checkBox4).set_UseVisualStyleBackColor(true);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(101, 330));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(95, 12));
		((Control)linkLabel1).set_TabIndex(25);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("购买苍天驳云2.0");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_Location(new Point(249, 330));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(77, 12));
		((Control)linkLabel2).set_TabIndex(26);
		((Label)linkLabel2).set_TabStop(true);
		((Control)linkLabel2).set_Text("访问外挂主页");
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		((Control)linkLabel3).set_AutoSize(true);
		((Control)linkLabel3).set_Location(new Point(202, 330));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(41, 12));
		((Control)linkLabel3).set_TabIndex(30);
		((Label)linkLabel3).set_TabStop(true);
		((Control)linkLabel3).set_Text("提建议");
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		((ButtonBase)button12).set_FlatStyle((FlatStyle)1);
		((ButtonBase)button12).set_Image((Image)componentResourceManager.GetObject("button12.Image"));
		((Control)button12).set_Location(new Point(12, 329));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(86, 38));
		((Control)button12).set_TabIndex(31);
		((Control)button12).set_Text("苍天驳云2.0 QQ11254897");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(339, 373));
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)linkLabel3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)checkBox4);
		((Control)this).get_Controls().Add((Control)(object)checkBox3);
		((Control)this).get_Controls().Add((Control)(object)checkBox2);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)trackBar2);
		((Control)this).get_Controls().Add((Control)(object)trackBar1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_MaximumSize(new Size(347, 407));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_MinimumSize(new Size(347, 407));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("苍天驳云2.0");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)trackBar1).EndInit();
		((ISupportInitialize)trackBar2).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage3).PerformLayout();
		((Control)tabPage4).ResumeLayout(false);
		((Control)tabPage4).PerformLayout();
		((Control)tabPage5).ResumeLayout(false);
		((Control)tabPage5).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
