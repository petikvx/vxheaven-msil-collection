using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Vkontakte;

public class Form1 : Form
{
	public Thread[] threads;

	public bool paused;

	public bruteforce brute;

	private IContainer components;

	private MenuStrip menuStrip1;

	private ToolStripMenuItem aboutToolStripMenuItem;

	private Button startbutton;

	private Button pausebutton;

	private TextBox emailBox;

	private TextBox charsBox;

	private TextBox dictonaryBox;

	private RadioButton radioButton1;

	private RadioButton radioButton2;

	private RadioButton radioButton3;

	private Label label1;

	private Label label2;

	private Label label3;

	private OpenFileDialog openFileDialog1;

	private ListBox listBox1;

	private ComboBox threadsBox;

	private ComboBox lengthBox;

	private Label label4;

	private Label label5;

	private Button button1;

	private Label label6;

	private Timer timer1;

	public Form1()
	{
		InitializeComponent();
	}

	private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		AboutBox1 aboutBox = new AboutBox1();
		((Control)aboutBox).Show();
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)emailBox).set_Enabled(true);
		((Control)charsBox).set_Enabled(true);
		((Control)dictonaryBox).set_Enabled(false);
		((Control)lengthBox).set_Enabled(true);
	}

	private void radioButton2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)emailBox).set_Enabled(false);
		((Control)charsBox).set_Enabled(false);
		((Control)dictonaryBox).set_Enabled(true);
		((Control)lengthBox).set_Enabled(false);
	}

	private void radioButton3_CheckedChanged(object sender, EventArgs e)
	{
		((Control)emailBox).set_Enabled(true);
		((Control)dictonaryBox).set_Enabled(true);
		((Control)charsBox).set_Enabled(false);
		((Control)lengthBox).set_Enabled(false);
	}

	private void startbutton_Click(object sender, EventArgs e)
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		((Control)startbutton).set_Enabled(false);
		((Control)pausebutton).set_Enabled(true);
		((Control)button1).set_Enabled(true);
		paused = false;
		if (radioButton1.get_Checked())
		{
			brute = new bruteforce(((Control)charsBox).get_Text(), int.Parse(((Control)lengthBox).get_Text()), ((Control)emailBox).get_Text(), listBox1);
			threads = new Thread[int.Parse(((Control)lengthBox).get_Text())];
			for (int i = 0; i < threads.Length; i++)
			{
				threads[i] = new Thread(brute.start);
				threads[i].Start();
			}
		}
		if (radioButton2.get_Checked())
		{
			((CommonDialog)openFileDialog1).ShowDialog();
			try
			{
				((Control)dictonaryBox).set_Text(((FileDialog)openFileDialog1).get_FileName());
				FileInfo fileInfo = new FileInfo(((Control)dictonaryBox).get_Text());
				StreamReader s = fileInfo.OpenText();
				brute = new bruteforce(s, listBox1);
				threads = new Thread[int.Parse(((Control)lengthBox).get_Text())];
				for (int j = 0; j < threads.Length; j++)
				{
					threads[j] = new Thread(brute.start);
					threads[j].Start();
				}
			}
			catch
			{
			}
		}
		if (radioButton3.get_Checked())
		{
			((CommonDialog)openFileDialog1).ShowDialog();
			try
			{
				((Control)dictonaryBox).set_Text(((FileDialog)openFileDialog1).get_FileName());
				FileInfo fileInfo2 = new FileInfo(((Control)dictonaryBox).get_Text());
				StreamReader s2 = fileInfo2.OpenText();
				brute = new bruteforce(((Control)emailBox).get_Text(), s2, listBox1);
				threads = new Thread[int.Parse(((Control)lengthBox).get_Text())];
				for (int k = 0; k < threads.Length; k++)
				{
					threads[k] = new Thread(brute.start);
					threads[k].Start();
				}
			}
			catch
			{
			}
		}
		timer1.set_Enabled(true);
	}

	private void pausebutton_Click(object sender, EventArgs e)
	{
		try
		{
			if (!paused)
			{
				timer1.set_Enabled(false);
				for (int i = 0; i < threads.Length; i++)
				{
					threads[i].Suspend();
				}
				paused = true;
				((Control)pausebutton).set_Text("Возобновить");
			}
			else
			{
				timer1.set_Enabled(true);
				for (int j = 0; j < threads.Length; j++)
				{
					threads[j].Resume();
				}
				paused = false;
				((Control)pausebutton).set_Text("Приостановить");
			}
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (threads == null)
		{
			return;
		}
		try
		{
			for (int i = 0; i < threads.Length; i++)
			{
				threads[i].Abort();
			}
			timer1.set_Enabled(false);
		}
		catch
		{
		}
		threads = null;
		listBox1.get_Items().Add((object)"Все потоки остановлены");
		((Control)startbutton).set_Enabled(true);
		((Control)pausebutton).set_Enabled(false);
		((Control)button1).set_Enabled(false);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			for (int i = 0; i < threads.Length; i++)
			{
				threads[i].Abort();
			}
		}
		catch
		{
		}
		Application.ExitThread();
		Application.Exit();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		((Control)label6).set_Text(brute.pass_count.ToString());
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected O, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		menuStrip1 = new MenuStrip();
		aboutToolStripMenuItem = new ToolStripMenuItem();
		startbutton = new Button();
		pausebutton = new Button();
		emailBox = new TextBox();
		charsBox = new TextBox();
		dictonaryBox = new TextBox();
		radioButton1 = new RadioButton();
		radioButton2 = new RadioButton();
		radioButton3 = new RadioButton();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		openFileDialog1 = new OpenFileDialog();
		listBox1 = new ListBox();
		threadsBox = new ComboBox();
		lengthBox = new ComboBox();
		label4 = new Label();
		label5 = new Label();
		button1 = new Button();
		label6 = new Label();
		timer1 = new Timer(components);
		((Control)menuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)menuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)aboutToolStripMenuItem });
		((Control)menuStrip1).set_Location(new Point(0, 0));
		((Control)menuStrip1).set_Name("menuStrip1");
		((Control)menuStrip1).set_Size(new Size(308, 24));
		((Control)menuStrip1).set_TabIndex(0);
		((Control)menuStrip1).set_Text("menuStrip1");
		((ToolStripItem)aboutToolStripMenuItem).set_Name("aboutToolStripMenuItem");
		((ToolStripItem)aboutToolStripMenuItem).set_Size(new Size(48, 20));
		((ToolStripItem)aboutToolStripMenuItem).set_Text("About");
		((ToolStripItem)aboutToolStripMenuItem).add_Click((EventHandler)aboutToolStripMenuItem_Click);
		((Control)startbutton).set_Location(new Point(154, 116));
		((Control)startbutton).set_Name("startbutton");
		((Control)startbutton).set_Size(new Size(147, 23));
		((Control)startbutton).set_TabIndex(1);
		((Control)startbutton).set_Text("Начать");
		((ButtonBase)startbutton).set_UseVisualStyleBackColor(true);
		((Control)startbutton).add_Click((EventHandler)startbutton_Click);
		((Control)pausebutton).set_Enabled(false);
		((Control)pausebutton).set_Location(new Point(154, 156));
		((Control)pausebutton).set_Name("pausebutton");
		((Control)pausebutton).set_Size(new Size(147, 23));
		((Control)pausebutton).set_TabIndex(2);
		((Control)pausebutton).set_Text("Пауза");
		((ButtonBase)pausebutton).set_UseVisualStyleBackColor(true);
		((Control)pausebutton).add_Click((EventHandler)pausebutton_Click);
		((Control)emailBox).set_Location(new Point(7, 41));
		((Control)emailBox).set_Name("emailBox");
		((Control)emailBox).set_Size(new Size(141, 20));
		((Control)emailBox).set_TabIndex(3);
		((Control)emailBox).set_Text("serber2006@yandex.ru");
		((Control)charsBox).set_Location(new Point(7, 79));
		((Control)charsBox).set_Name("charsBox");
		((Control)charsBox).set_Size(new Size(141, 20));
		((Control)charsBox).set_TabIndex(4);
		((Control)charsBox).set_Text("abcdefg");
		((Control)dictonaryBox).set_Enabled(false);
		((Control)dictonaryBox).set_Location(new Point(7, 194));
		((Control)dictonaryBox).set_Name("dictonaryBox");
		((Control)dictonaryBox).set_Size(new Size(141, 20));
		((Control)dictonaryBox).set_TabIndex(5);
		((Control)radioButton1).set_AutoSize(true);
		radioButton1.set_Checked(true);
		((Control)radioButton1).set_Location(new Point(157, 44));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(110, 17));
		((Control)radioButton1).set_TabIndex(6);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Полный перебор");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged);
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Location(new Point(157, 64));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(144, 17));
		((Control)radioButton2).set_TabIndex(7);
		((Control)radioButton2).set_Text("По словарю (email;pass)");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		radioButton2.add_CheckedChanged((EventHandler)radioButton2_CheckedChanged);
		((Control)radioButton3).set_AutoSize(true);
		((Control)radioButton3).set_Location(new Point(157, 83));
		((Control)radioButton3).set_Name("radioButton3");
		((Control)radioButton3).set_Size(new Size(117, 17));
		((Control)radioButton3).set_TabIndex(8);
		((Control)radioButton3).set_Text("По словарю (pass)");
		((ButtonBase)radioButton3).set_UseVisualStyleBackColor(true);
		radioButton3.add_CheckedChanged((EventHandler)radioButton3_CheckedChanged);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(4, 27));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(37, 13));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("e-mail:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(4, 64));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(54, 13));
		((Control)label2).set_TabIndex(10);
		((Control)label2).set_Text("Алфавит:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(4, 181));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(53, 13));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("Словарь:");
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(7, 221));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(294, 69));
		((Control)listBox1).set_TabIndex(13);
		((ListControl)threadsBox).set_FormattingEnabled(true);
		((Control)threadsBox).set_Location(new Point(7, 118));
		((Control)threadsBox).set_Name("threadsBox");
		((Control)threadsBox).set_Size(new Size(141, 21));
		((Control)threadsBox).set_TabIndex(14);
		((Control)threadsBox).set_Text("5");
		((ListControl)lengthBox).set_FormattingEnabled(true);
		((Control)lengthBox).set_Location(new Point(7, 158));
		((Control)lengthBox).set_Name("lengthBox");
		((Control)lengthBox).set_Size(new Size(141, 21));
		((Control)lengthBox).set_TabIndex(15);
		((Control)lengthBox).set_Text("5");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(4, 102));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(113, 13));
		((Control)label4).set_TabIndex(16);
		((Control)label4).set_Text("Количество потоков:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(6, 142));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(82, 13));
		((Control)label5).set_TabIndex(17);
		((Control)label5).set_Text("Длина пароля:");
		((Control)button1).set_Enabled(false);
		((Control)button1).set_Location(new Point(154, 191));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(147, 23));
		((Control)button1).set_TabIndex(18);
		((Control)button1).set_Text("Стоп!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(6, 293));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(13, 13));
		((Control)label6).set_TabIndex(19);
		((Control)label6).set_Text("0");
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(308, 315));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)lengthBox);
		((Control)this).get_Controls().Add((Control)(object)threadsBox);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)radioButton3);
		((Control)this).get_Controls().Add((Control)(object)radioButton2);
		((Control)this).get_Controls().Add((Control)(object)radioButton1);
		((Control)this).get_Controls().Add((Control)(object)dictonaryBox);
		((Control)this).get_Controls().Add((Control)(object)charsBox);
		((Control)this).get_Controls().Add((Control)(object)emailBox);
		((Control)this).get_Controls().Add((Control)(object)pausebutton);
		((Control)this).get_Controls().Add((Control)(object)startbutton);
		((Control)this).get_Controls().Add((Control)(object)menuStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(menuStrip1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Vkontakte");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)menuStrip1).ResumeLayout(false);
		((Control)menuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
