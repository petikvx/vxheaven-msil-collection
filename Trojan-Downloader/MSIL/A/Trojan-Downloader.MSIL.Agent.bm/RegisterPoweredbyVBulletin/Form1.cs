using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Shell32;

namespace RegisterPoweredbyVBulletin;

public class Form1 : Form
{
	public static GClass1 gclass1_0;

	public string string_0;

	public int int_0;

	public bool bool_0 = true;

	public string string_1;

	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

	public string string_7;

	public string string_8;

	public int int_1;

	public string string_9;

	public string string_10;

	public string string_11;

	public bool bool_1;

	public bool bool_2;

	private IContainer icontainer_0;

	public WebBrowser webBrowser1;

	private Button button1;

	private Button button2;

	private Button button3;

	private Label label1;

	private Panel panel1;

	public Form1(string registerurl, string timeout1, string year1, string month1, string day1, string pop3server1, string port1, string account1, string password1, string username1, string urlpassword1, string email1, string bnshow, string auto)
	{
		InitializeComponent();
		string_1 = username1;
		string_2 = urlpassword1;
		string_3 = email1;
		string_0 = registerurl;
		string_4 = timeout1;
		string_5 = year1;
		string_6 = month1;
		string_7 = day1;
		string_8 = pop3server1;
		int_1 = int.Parse(port1.Trim());
		string_9 = account1;
		string_10 = password1;
		if (bnshow == "show")
		{
			bool_1 = true;
		}
		else
		{
			bool_1 = false;
		}
		if (!(auto == "auto"))
		{
			bool_2 = false;
		}
		else
		{
			bool_2 = true;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (bool_1)
		{
			((Control)this).Show();
		}
		else
		{
			((Control)this).Hide();
		}
		try
		{
			ShellClass val = new ShellClass();
			Folder val2 = val.NameSpace((object)33);
			FolderItems val3 = val2.Items();
			foreach (FolderItem item in val3)
			{
				FolderItem val4 = item;
				if (!"index.dat".Equals(val4.get_Name().ToLower()))
				{
					try
					{
						File.Delete(val4.get_Path().ToString());
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		GClass2 gClass = new GClass2(webBrowser1);
		if (!gClass.method_2(string_0 + "register.php"))
		{
			if (!bool_2)
			{
				((Control)label1).set_Text("Finish Register by yourself And Make a Decision to Click follow Button  ");
				return;
			}
			int_0 = 0;
			((Form)this).Close();
			return;
		}
		gclass1_0 = new GClass1();
		if (gclass1_0.method_0())
		{
			if (!gclass1_0.bool_0)
			{
				int_0 = 1;
				((Form)this).Close();
			}
			else
			{
				int_0 = 2;
				((Form)this).Close();
			}
		}
		else if (bool_2)
		{
			int_0 = 0;
			((Form)this).Close();
		}
		else
		{
			((Control)label1).set_Text("c!");
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		int_0 = 2;
		((Form)this).Close();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		int_0 = 1;
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		int_0 = 1;
		((Form)this).Close();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		webBrowser1.Stop();
		((Component)(object)webBrowser1).Dispose();
	}

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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		webBrowser1 = new WebBrowser();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		label1 = new Label();
		panel1 = new Panel();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(415, 205));
		((Control)webBrowser1).set_TabIndex(0);
		((Control)button1).set_Dock((DockStyle)2);
		((Control)button1).set_Location(new Point(0, 263));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(415, 23));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Register fail");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Dock((DockStyle)2);
		((Control)button2).set_Location(new Point(0, 240));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(415, 23));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Register successful and waiting active");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Dock((DockStyle)2);
		((Control)button3).set_Location(new Point(0, 217));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(415, 23));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("Register successful and Active");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)label1).set_BackColor(Color.FromArgb(192, 0, 0));
		((Control)label1).set_Dock((DockStyle)2);
		((Control)label1).set_ForeColor(Color.Yellow);
		((Control)label1).set_Location(new Point(0, 205));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(415, 12));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("Work Automatically");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)panel1).get_Controls().Add((Control)(object)webBrowser1);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(415, 205));
		((Control)panel1).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(415, 286));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)3);
		((Control)this).set_Text("Register");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
