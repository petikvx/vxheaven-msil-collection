using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using GEHero109UserManager.WebReference;

namespace GEHero109UserManager;

public class Form1 : Form
{
	private TextBox UserName;

	private TextBox Code;

	private TextBox CodePW;

	private Button button1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Button button_0;

	private Label label5;

	private TextBox GameID;

	private Label label4;

	private Button button2;

	private TextBox CodeID;

	private GEHero109DataSet geHero109DataSet_CodeInfo;

	private Label label6;

	private TextBox PW;

	private Label label7;

	private TextBox IDNew;

	private TextBox ChangePW;

	private Label label8;

	private TextBox IDOld;

	private Label label9;

	private Button button3;

	private Container components = null;

	public Form1()
	{
		InitializeComponent();
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		UserName = new TextBox();
		Code = new TextBox();
		CodePW = new TextBox();
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		GameID = new TextBox();
		button_0 = new Button();
		label5 = new Label();
		label4 = new Label();
		button2 = new Button();
		CodeID = new TextBox();
		geHero109DataSet_CodeInfo = new GEHero109DataSet();
		label6 = new Label();
		PW = new TextBox();
		label7 = new Label();
		IDNew = new TextBox();
		ChangePW = new TextBox();
		label8 = new Label();
		IDOld = new TextBox();
		label9 = new Label();
		button3 = new Button();
		((ISupportInitialize)geHero109DataSet_CodeInfo).BeginInit();
		((Control)this).SuspendLayout();
		((Control)UserName).set_Location(new Point(56, 16));
		((Control)UserName).set_Name("UserName");
		((Control)UserName).set_Size(new Size(128, 21));
		((Control)UserName).set_TabIndex(0);
		((Control)UserName).set_Text("");
		((Control)Code).set_Location(new Point(56, 48));
		((Control)Code).set_Name("Code");
		((Control)Code).set_Size(new Size(128, 21));
		((Control)Code).set_TabIndex(1);
		((Control)Code).set_Text("");
		((Control)CodePW).set_Location(new Point(280, 48));
		((Control)CodePW).set_Name("CodePW");
		((Control)CodePW).set_Size(new Size(184, 21));
		((Control)CodePW).set_TabIndex(2);
		((Control)CodePW).set_Text("");
		((Control)button1).set_Location(new Point(488, 48));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(88, 23));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("添加用户信息");
		((Control)button1).add_Click((EventHandler)button1_Click);
		label1.set_AutoSize(true);
		((Control)label1).set_Location(new Point(8, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(42, 17));
		((Control)label1).set_TabIndex(5);
		((Control)label1).set_Text("帐户名");
		label1.set_TextAlign((ContentAlignment)32);
		label2.set_AutoSize(true);
		((Control)label2).set_Location(new Point(8, 48));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(29, 17));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("卡号");
		label2.set_TextAlign((ContentAlignment)32);
		label3.set_AutoSize(true);
		((Control)label3).set_Location(new Point(208, 48));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(42, 17));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("卡密码");
		label3.set_TextAlign((ContentAlignment)32);
		((Control)GameID).set_Location(new Point(56, 88));
		((Control)GameID).set_Name("GameID");
		((Control)GameID).set_Size(new Size(136, 21));
		((Control)GameID).set_TabIndex(6);
		((Control)GameID).set_Text("");
		((Control)button_0).set_Location(new Point(216, 88));
		((Control)button_0).set_Name("帐号测试");
		((Control)button_0).set_TabIndex(7);
		((Control)button_0).set_Text("帐号测试");
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		label5.set_AutoSize(true);
		((Control)label5).set_Location(new Point(8, 88));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(29, 17));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("帐号");
		label5.set_TextAlign((ContentAlignment)32);
		label4.set_AutoSize(true);
		((Control)label4).set_Location(new Point(8, 128));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(29, 17));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("卡号");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)button2).set_Location(new Point(216, 128));
		((Control)button2).set_Name("button2");
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("卡号测试");
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)CodeID).set_Location(new Point(56, 128));
		((Control)CodeID).set_Name("CodeID");
		((Control)CodeID).set_Size(new Size(136, 21));
		((Control)CodeID).set_TabIndex(6);
		((Control)CodeID).set_Text("");
		geHero109DataSet_CodeInfo.DataSetName = "GEHero109DataSet";
		geHero109DataSet_CodeInfo.Locale = new CultureInfo("zh-CN");
		label6.set_AutoSize(true);
		((Control)label6).set_Location(new Point(208, 16));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(54, 17));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text("更名密码");
		label6.set_TextAlign((ContentAlignment)32);
		((Control)PW).set_Location(new Point(280, 16));
		((Control)PW).set_Name("PW");
		((Control)PW).set_Size(new Size(136, 21));
		((Control)PW).set_TabIndex(6);
		((Control)PW).set_Text("");
		label7.set_AutoSize(true);
		((Control)label7).set_Location(new Point(194, 176));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(42, 17));
		((Control)label7).set_TabIndex(5);
		((Control)label7).set_Text("帐户新");
		label7.set_TextAlign((ContentAlignment)32);
		((Control)IDNew).set_Location(new Point(240, 174));
		((Control)IDNew).set_Name("IDNew");
		((Control)IDNew).set_Size(new Size(136, 21));
		((Control)IDNew).set_TabIndex(0);
		((Control)IDNew).set_Text("");
		((Control)ChangePW).set_Location(new Point(438, 174));
		((Control)ChangePW).set_Name("ChangePW");
		((Control)ChangePW).set_Size(new Size(136, 21));
		((Control)ChangePW).set_TabIndex(6);
		((Control)ChangePW).set_Text("");
		label8.set_AutoSize(true);
		((Control)label8).set_Location(new Point(380, 176));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(54, 17));
		((Control)label8).set_TabIndex(5);
		((Control)label8).set_Text("更名密码");
		label8.set_TextAlign((ContentAlignment)32);
		((Control)IDOld).set_Location(new Point(54, 174));
		((Control)IDOld).set_Name("IDOld");
		((Control)IDOld).set_Size(new Size(136, 21));
		((Control)IDOld).set_TabIndex(0);
		((Control)IDOld).set_Text("");
		label9.set_AutoSize(true);
		((Control)label9).set_Location(new Point(8, 176));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(42, 17));
		((Control)label9).set_TabIndex(5);
		((Control)label9).set_Text("帐户旧");
		label9.set_TextAlign((ContentAlignment)32);
		((Control)button3).set_Location(new Point(504, 200));
		((Control)button3).set_Name("button3");
		((Control)button3).set_TabIndex(7);
		((Control)button3).set_Text("更改用户");
		((Control)button3).add_Click((EventHandler)button3_Click_1);
		((Form)this).set_AutoScaleBaseSize(new Size(6, 14));
		((Form)this).set_ClientSize(new Size(584, 245));
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)GameID);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)CodePW);
		((Control)this).get_Controls().Add((Control)(object)Code);
		((Control)this).get_Controls().Add((Control)(object)UserName);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)CodeID);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)PW);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)IDNew);
		((Control)this).get_Controls().Add((Control)(object)ChangePW);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)IDOld);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("帐号管理");
		((ISupportInitialize)geHero109DataSet_CodeInfo).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[STAThread]
	private static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)PW).get_Text().Length <= 0)
		{
			MessageBox.Show("保护密码不能为空！");
			return;
		}
		validate validate = new validate();
		string text = validate.AddValidateInfo(((Control)UserName).get_Text(), ((Control)Code).get_Text(), ((Control)CodePW).get_Text(), ((Control)PW).get_Text());
		MessageBox.Show(text);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		validate validate = new validate();
		string text = validate.Validate(((Control)GameID).get_Text(), "null");
		MessageBox.Show(text);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		validate validate = new validate();
		string text = validate.CodeInfo(((Control)CodeID).get_Text());
		MessageBox.Show(text);
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void button4_Click(object sender, EventArgs e)
	{
	}

	private void button3_Click_1(object sender, EventArgs e)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		validate validate = new validate();
		string text = validate.ChangeUserID(((Control)IDOld).get_Text(), ((Control)IDNew).get_Text(), ((Control)ChangePW).get_Text());
		MessageBox.Show(text);
	}
}
