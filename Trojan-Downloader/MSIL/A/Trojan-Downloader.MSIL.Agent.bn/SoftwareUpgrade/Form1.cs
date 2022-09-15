using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SoftwareUpgrade;

public class Form1 : Form
{
	private IContainer icontainer_0;

	private Label label1;

	private Label label2;

	public ProgressBar progressBar1;

	public ProgressBar progressBar2;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	public int int_0;

	public int int_1;

	private string string_0;

	public string string_1;

	public string string_2 = Application.get_StartupPath();

	private string string_3;

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
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		progressBar1 = new ProgressBar();
		progressBar2 = new ProgressBar();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		((Control)statusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(19, 80));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(137, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Single File Progress：");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial", 10.5f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(14, 12));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(141, 16));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Main  Progress   ：");
		((Control)progressBar1).set_Location(new Point(162, 81));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(413, 11));
		((Control)progressBar1).set_TabIndex(3);
		((Control)progressBar2).set_ForeColor(Color.Lime);
		((Control)progressBar2).set_Location(new Point(17, 31));
		((Control)progressBar2).set_Name("progressBar2");
		((Control)progressBar2).set_Size(new Size(560, 23));
		progressBar2.set_Style((ProgressBarStyle)1);
		((Control)progressBar2).set_TabIndex(4);
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 111));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(598, 22));
		((Control)statusStrip1).set_TabIndex(5);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStrip)statusStrip1).add_ItemClicked(new ToolStripItemClickedEventHandler(statusStrip1_ItemClicked));
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(131, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("toolStripStatusLabel1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(598, 133));
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)progressBar2);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1(string updatefile1, string mainexe1)
	{
		InitializeComponent();
		string_0 = updatefile1;
		string_1 = mainexe1;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		method_0();
	}

	private void method_0()
	{
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (File.Exists(Application.get_StartupPath() + "\\UPDATEINF.TXT"))
			{
				File.Delete(Application.get_StartupPath() + "\\UPDATEINF.TXT");
			}
			((ToolStripItem)toolStripStatusLabel1).set_Text("Connecting software server...");
			Class1 @class = new Class1();
			string_3 = Path.Combine(string_2, "UPDATEINF.TXT");
			@class.method_0(string_0, string_3, DateTime.Now);
			File.SetAttributes(string_3, FileAttributes.Hidden);
			string_0 = string_0.Substring(0, string_0.LastIndexOf("/") + 1);
			FileStream fileStream = new FileStream(string_3, FileMode.Open, FileAccess.Read, FileShare.None);
			fileStream.Seek(0L, SeekOrigin.Begin);
			StreamReader streamReader = new StreamReader(fileStream);
			int_1 = 0;
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string path = text.Substring(0, text.IndexOf("|")).Trim();
				string value = text.Substring(text.IndexOf("|") + 1).Trim();
				string_3 = Path.Combine(string_2, path);
				DateTime now = DateTime.Now;
				try
				{
					now = Convert.ToDateTime(value);
				}
				catch (Exception)
				{
					int_0 = 0;
					return;
				}
				if (!File.Exists(string_3))
				{
					int_1++;
				}
				else if (now.CompareTo(File.GetLastWriteTime(string_3)) > 0)
				{
					int_1++;
				}
			}
			if (int_1 == 0)
			{
				int_0 = 0;
				((Component)(object)this).Dispose(disposing: true);
			}
			((Control)this).set_Text(string_1 + " is Upgrading ");
			((Control)this).Show();
			Application.DoEvents();
			((ToolStripItem)toolStripStatusLabel1).set_Text("Software is upgrading...");
			Process[] processesByName = Process.GetProcessesByName(string_1);
			if (processesByName.Length > 0)
			{
				for (int i = 0; i < processesByName.Length; i++)
				{
					try
					{
						processesByName[i].Kill();
					}
					catch
					{
					}
				}
			}
			if (!Directory.Exists("tempoldfiles"))
			{
				Directory.CreateDirectory("tempoldfiles");
			}
			progressBar2.set_Value(0);
			progressBar2.set_Minimum(0);
			progressBar2.set_Maximum(int_1);
			fileStream.Seek(0L, SeekOrigin.Begin);
			while ((text = streamReader.ReadLine()) != null)
			{
				if (!(text.Trim() != ""))
				{
					continue;
				}
				string text2 = text.Substring(0, text.IndexOf("|")).Trim();
				string value2 = text.Substring(text.IndexOf("|") + 1).Trim();
				string_3 = Path.Combine(string_2, text2);
				string text3 = Path.Combine(string_0, text2);
				DateTime now2 = DateTime.Now;
				try
				{
					now2 = Convert.ToDateTime(value2);
				}
				catch (Exception)
				{
					MessageBox.Show("File error!");
					int_0 = 0;
					return;
				}
				if (File.Exists(string_3))
				{
					if (now2.CompareTo(File.GetLastWriteTime(string_3)) > 0)
					{
						((ToolStripItem)toolStripStatusLabel1).set_Text("Upgrading " + text2 + "...");
						Class1 class2 = new Class1();
						method_1(text2, "tempoldfiles");
						class2.method_0(text3, string_3, now2);
						ProgressBar obj2 = progressBar2;
						obj2.set_Value(obj2.get_Value() + 1);
					}
					continue;
				}
				((ToolStripItem)toolStripStatusLabel1).set_Text("Upgrading " + text2 + "...");
				Class1 class3 = new Class1();
				if (text2.LastIndexOf("\\") >= 0)
				{
					string path2 = text2.Substring(0, text2.LastIndexOf("\\"));
					if (!Directory.Exists(path2))
					{
						Directory.CreateDirectory(path2);
					}
				}
				method_1(text2, "tempoldfiles");
				class3.method_0(text3, string_3, now2);
				ProgressBar obj3 = progressBar2;
				obj3.set_Value(obj3.get_Value() + 1);
			}
			int_0 = 1;
			streamReader.Close();
			MessageBox.Show(string_1 + " Update is completed . Press button to startup " + string_1 + ".", "Software Update Completion");
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = string_1 + ".exe";
			processStartInfo.WorkingDirectory = string_2;
			try
			{
				Process.Start(processStartInfo);
				((Form)this).Close();
			}
			catch (Win32Exception)
			{
				MessageBox.Show("Can't find file -- " + string_1 + ".exe");
				((Form)this).Close();
			}
		}
		catch
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	private void method_1(string string_4, string string_5)
	{
		if (!File.Exists(string_4))
		{
			return;
		}
		if (string_4.LastIndexOf("\\") >= 0)
		{
			string text = string_4.Substring(string_4.LastIndexOf("\\") + 1);
			if (File.Exists(string_5 + "\\" + text))
			{
				File.Delete(string_5 + "\\" + text);
			}
			File.Copy(string_4, string_5 + "\\" + text);
		}
		else
		{
			if (File.Exists(string_5 + "\\" + string_4))
			{
				File.Delete(string_5 + "\\" + string_4);
			}
			File.Copy(string_4, string_5 + "\\" + string_4);
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		Process.GetCurrentProcess().Kill();
	}

	private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
	{
	}
}
