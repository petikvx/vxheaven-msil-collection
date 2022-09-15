using System;
using System.ComponentModel;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Kladd_Talk;

public class Form1 : Form
{
	private IContainer components = null;

	private Button button1;

	private RichTextBox richTextBox1;

	private PictureBox pictureBox1;

	private Timer timer1;

	private Label label1;

	private SpeechSynthesizer sp = new SpeechSynthesizer();

	private SpeechSynthesizer synth = new SpeechSynthesizer();

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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		button1 = new Button();
		richTextBox1 = new RichTextBox();
		pictureBox1 = new PictureBox();
		timer1 = new Timer(components);
		label1 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(12, 206));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(228, 55));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Speak");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)richTextBox1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(12, 12));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(260, 188));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text("Write what to say here...");
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(293, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(189, 188));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(Color.Lime);
		((Control)label1).set_Location(new Point(277, 233));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(188, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Made by Jesper_Kladden @ Tpforums");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(494, 264));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("KladdTalk");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		SpeechSynthesizer val = new SpeechSynthesizer();
		try
		{
			InitializeComponent();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		synth.SelectVoiceByHints((VoiceGender)1);
		synth.Speak(((Control)richTextBox1).get_Text());
	}

	private void checkBox1_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}
}
