using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Shell32;

namespace EditSignaturePoweredbyVBulletin;

public class Form1 : Form
{
	private IContainer icontainer_0 = null;

	public WebBrowser webBrowser1;

	public int int_0;

	public string string_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public bool bool_0 = true;

	public int int_1;

	public string string_4;

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
		webBrowser1 = new WebBrowser();
		((Control)this).SuspendLayout();
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(420, 266));
		((Control)webBrowser1).set_TabIndex(0);
		((Form)this).set_ClientSize(new Size(420, 266));
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).set_Name("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1(string param, string param1, string param2, string param3)
	{
		InitializeComponent();
		string_0 = param.Substring(0, param.IndexOf("|"));
		string text = param.Substring(param.IndexOf("|") + 1);
		string_1 = text.Substring(0, text.IndexOf("|"));
		string text2 = text.Substring(text.IndexOf("|") + 1);
		string_2 = text2.Substring(0, text2.IndexOf("|"));
		if (!(param2 == "show"))
		{
			bool_1 = false;
		}
		else
		{
			bool_1 = true;
		}
		string_3 = param1;
		string_4 = param3.Replace("####", " ");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
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
		if (!bool_1)
		{
			((Control)this).Hide();
		}
		else
		{
			((Control)this).Show();
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
		if (!gClass2.method_0(string_0 + "profile.php?do=editsignature"))
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
}
