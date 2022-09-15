using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Vkontakte.Properties;

namespace Vkontakte;

internal class AboutBox1 : Form
{
	private IContainer components;

	private PictureBox logoPictureBox;

	private Button button1;

	private TextBox textBox1;

	public AboutBox1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		logoPictureBox = new PictureBox();
		button1 = new Button();
		textBox1 = new TextBox();
		((ISupportInitialize)logoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		logoPictureBox.set_BorderStyle((BorderStyle)1);
		logoPictureBox.set_Image((Image)(object)Resources.ramz);
		((Control)logoPictureBox).set_Location(new Point(3, 3));
		((Control)logoPictureBox).set_Name("logoPictureBox");
		((Control)logoPictureBox).set_Size(new Size(203, 152));
		logoPictureBox.set_SizeMode((PictureBoxSizeMode)2);
		logoPictureBox.set_TabIndex(13);
		logoPictureBox.set_TabStop(false);
		((Control)button1).set_Location(new Point(212, 132));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(203, 23));
		((Control)button1).set_TabIndex(14);
		((Control)button1).set_Text("Закрыть");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_BackColor(SystemColors.Control);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Location(new Point(212, 3));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(203, 123));
		((Control)textBox1).set_TabIndex(15);
		((Control)textBox1).set_Text("Vkontakte Bruteforce\r\n\r\nCopyright © 2008 by serber\r\n\r\nICQ# 175487");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(418, 159));
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)logoPictureBox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AboutBox1");
		((Control)this).set_Padding(new Padding(9));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("About");
		((ISupportInitialize)logoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
