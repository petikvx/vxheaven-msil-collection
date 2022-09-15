using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Install;

public class Form1 : Form
{
	private IContainer components = null;

	private SplitContainer splitContainer1;

	private SplitContainer splitContainer2;

	private RichTextBox richTextBox1;

	private Button button1;

	private WebBrowser webBrowser1;

	private Panel panel1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)button1).set_Enabled(false);
		webBrowser1.Navigate("http://www.baictron.com/redirect.php");
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		Environment.Exit(0);
	}

	private void Form1_SizeChanged(object sender, EventArgs e)
	{
		splitContainer1.set_SplitterDistance(((Control)button1).get_Height() + 10);
		splitContainer2.set_SplitterDistance(((Control)splitContainer2).get_Width() - ((Control)button1).get_Width() - 20);
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
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		splitContainer1 = new SplitContainer();
		splitContainer2 = new SplitContainer();
		richTextBox1 = new RichTextBox();
		button1 = new Button();
		webBrowser1 = new WebBrowser();
		panel1 = new Panel();
		((Control)splitContainer1.get_Panel1()).SuspendLayout();
		((Control)splitContainer1.get_Panel2()).SuspendLayout();
		((Control)splitContainer1).SuspendLayout();
		((Control)splitContainer2.get_Panel1()).SuspendLayout();
		((Control)splitContainer2.get_Panel2()).SuspendLayout();
		((Control)splitContainer2).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		splitContainer1.set_Dock((DockStyle)5);
		splitContainer1.set_FixedPanel((FixedPanel)1);
		splitContainer1.set_IsSplitterFixed(true);
		((Control)splitContainer1).set_Location(new Point(0, 0));
		((Control)splitContainer1).set_Name("splitContainer1");
		splitContainer1.set_Orientation((Orientation)0);
		((Control)splitContainer1.get_Panel1()).get_Controls().Add((Control)(object)splitContainer2);
		((Control)splitContainer1.get_Panel2()).get_Controls().Add((Control)(object)webBrowser1);
		((Control)splitContainer1).set_Size(new Size(794, 575));
		splitContainer1.set_SplitterDistance(94);
		((Control)splitContainer1).set_TabIndex(0);
		splitContainer2.set_Dock((DockStyle)5);
		((Control)splitContainer2).set_Location(new Point(0, 0));
		((Control)splitContainer2).set_Name("splitContainer2");
		((Control)splitContainer2.get_Panel1()).get_Controls().Add((Control)(object)richTextBox1);
		((Control)splitContainer2.get_Panel2()).get_Controls().Add((Control)(object)panel1);
		((Control)splitContainer2).set_Size(new Size(794, 94));
		splitContainer2.set_SplitterDistance(626);
		((Control)splitContainer2).set_TabIndex(0);
		((TextBoxBase)richTextBox1).set_BorderStyle((BorderStyle)0);
		((Control)richTextBox1).set_Cursor(Cursors.get_Arrow());
		((Control)richTextBox1).set_Dock((DockStyle)5);
		((Control)richTextBox1).set_Location(new Point(0, 0));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(626, 94));
		((Control)richTextBox1).set_TabIndex(5);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)button1).set_Location(new Point(15, 3));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(146, 84));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("Install");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)webBrowser1).set_Dock((DockStyle)5);
		((Control)webBrowser1).set_Location(new Point(0, 0));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		((Control)webBrowser1).set_Size(new Size(794, 477));
		((Control)webBrowser1).set_TabIndex(0);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(164, 94));
		((Control)panel1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(794, 575));
		((Control)this).get_Controls().Add((Control)(object)splitContainer1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Please Follow The Directions");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_SizeChanged((EventHandler)Form1_SizeChanged);
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Control)splitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer1.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer1).ResumeLayout(false);
		((Control)splitContainer2.get_Panel1()).ResumeLayout(false);
		((Control)splitContainer2.get_Panel2()).ResumeLayout(false);
		((Control)splitContainer2).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
