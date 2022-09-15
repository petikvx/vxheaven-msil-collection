using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Poison_Ivy_Connection_Patch.Properties;

namespace Poison_Ivy_Connection_Patch;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private TextBox textBox2;

	private LinkLabel linkLabel1;

	private Label label3;

	private ListBox listBox1;

	private CheckBox checkBox1;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.poisonivy-rat.com");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		string text = "Poison Ivy 2.3.3.exe";
		if (File.Exists(text))
		{
			if (checkBox1.get_Checked())
			{
				Path.ChangeExtension(text, ".exe.bak");
				BinaryWriter binaryWriter = null;
				byte[] pIvy = Resources.PIvy;
				try
				{
					FileStream output = new FileStream("Poison Ivy 2.3.3.exe", FileMode.Create);
					binaryWriter = new BinaryWriter(output);
					binaryWriter.Write(pIvy, 0, pIvy.Length);
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return;
				}
				finally
				{
					binaryWriter?.Close();
				}
			}
			if (checkBox1.get_Checked())
			{
				return;
			}
			File.Delete(text);
			BinaryWriter binaryWriter2 = null;
			byte[] pIvy2 = Resources.PIvy;
			try
			{
				FileStream output2 = new FileStream("Poison Ivy 2.3.3.exe", FileMode.Create);
				binaryWriter2 = new BinaryWriter(output2);
				binaryWriter2.Write(pIvy2, 0, pIvy2.Length);
				return;
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString());
				return;
			}
			finally
			{
				binaryWriter2?.Close();
			}
		}
		MessageBox.Show("Could Not Find " + text, "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
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
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		textBox2 = new TextBox();
		linkLabel1 = new LinkLabel();
		label3 = new Label();
		listBox1 = new ListBox();
		checkBox1 = new CheckBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(41, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Author:");
		((Control)textBox1).set_BackColor(SystemColors.ControlLight);
		((Control)textBox1).set_Location(new Point(59, 6));
		((TextBoxBase)textBox1).set_MaxLength(5);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(240, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("Gee19");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 31));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(32, 13));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("URL:");
		((Control)textBox2).set_BackColor(SystemColors.ControlLight);
		((Control)textBox2).set_Location(new Point(59, 28));
		((TextBoxBase)textBox2).set_MaxLength(28);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(240, 20));
		((Control)textBox2).set_TabIndex(3);
		linkLabel1.set_ActiveLinkColor(Color.LightGray);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(60, 31));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(147, 13));
		((Control)linkLabel1).set_TabIndex(4);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("http://www.poisonivy-rat.com");
		linkLabel1.set_VisitedLinkColor(Color.FromArgb(0, 0, 225));
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(12, 65));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(70, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Release Info:");
		((ListControl)listBox1).set_FormattingEnabled(true);
		listBox1.get_Items().AddRange(new object[2] { "Poison Ivy Connection Limit Bypass", "Created By Gee19" });
		((Control)listBox1).set_Location(new Point(15, 81));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(284, 69));
		((Control)listBox1).set_TabIndex(6);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(15, 158));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(121, 17));
		((Control)checkBox1).set_TabIndex(7);
		((Control)checkBox1).set_Text("Backup Poison Ivy?");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Location(new Point(142, 154));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(157, 23));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Patch");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(309, 181));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Poison Ivy Connection Bypass Patch");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
