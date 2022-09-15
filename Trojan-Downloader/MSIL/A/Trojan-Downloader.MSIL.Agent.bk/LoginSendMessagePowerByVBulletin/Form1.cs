using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Shell32;

namespace LoginSendMessagePowerByVBulletin;

public class Form1 : Form
{
	private IContainer icontainer_0;

	public WebBrowser webBrowser1;

	public string string_0;

	public int int_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public string string_4;

	public bool bool_0 = true;

	public int int_1;

	public string string_5;

	public string string_6;

	public bool bool_1;

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
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(440, 288));
		((Control)webBrowser1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(440, 288));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("LoginSendMessage");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1(string param, string param1, string param2, string param3, string param4, string param5)
	{
		InitializeComponent();
		string_1 = param.Substring(0, param.IndexOf("|"));
		string text = param.Substring(param.IndexOf("|") + 1);
		string_2 = text.Substring(0, text.IndexOf("|"));
		string text2 = text.Substring(text.IndexOf("|") + 1);
		string_3 = text2.Substring(0, text2.IndexOf("|"));
		if (param3 == "show")
		{
			bool_1 = true;
		}
		else
		{
			bool_1 = false;
		}
		string_4 = param1;
		int_1 = int.Parse(param2);
		string_5 = param4;
		string_6 = param5;
		string_5 = param4.Replace("####", " ");
		string_6 = param5.Replace("####", " ");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
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
		if (bool_1)
		{
			((Control)this).Show();
		}
		else
		{
			((Control)this).Hide();
		}
		GClass0 gClass = new GClass0();
		if (!gClass.method_0())
		{
			int_0 = 0;
			((Form)this).Close();
			return;
		}
		if (!gClass.method_1())
		{
			int_0 = 0;
			((Form)this).Close();
			return;
		}
		GClass1 gClass2 = new GClass1();
		if (!gClass2.method_0(string_1 + "private.php?do=newpm&u=" + Class0.form1_0.int_1))
		{
			int_0 = 0;
			((Form)this).Close();
		}
		else
		{
			int_0 = 1;
			((Form)this).Close();
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		webBrowser1.Stop();
		((Component)(object)webBrowser1).Dispose();
	}
}
