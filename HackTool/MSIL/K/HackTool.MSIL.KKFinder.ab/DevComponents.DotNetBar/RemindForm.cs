using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

internal class RemindForm : Form
{
	private Label label1;

	private Label label2;

	private Button button1;

	private Button button2;

	private Timer timer_0;

	private Label label3;

	private Label label4;

	private GroupBox groupBox1;

	private Label label5;

	private Label label6;

	private LinkLabel linkOrder;

	private Label label7;

	private LinkLabel linkEmail;

	private LinkLabel linkHome;

	private IContainer icontainer_0;

	private static DateTime dateTime_0 = DateTime.MinValue;

	public RemindForm()
	{
		InitializeComponent();
		((Control)label2).set_Text("(c) " + DateTime.Now.Year + " by DevComponents, All Rights Reserved.");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	public void method_0()
	{
		if (!(dateTime_0 != DateTime.MinValue) || !(dateTime_0.Subtract(DateTime.Now).TotalMinutes < 15.0))
		{
			dateTime_0 = DateTime.Now;
		}
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		icontainer_0 = new Container();
		label1 = new Label();
		label2 = new Label();
		button1 = new Button();
		button2 = new Button();
		timer_0 = new Timer(icontainer_0);
		linkEmail = new LinkLabel();
		label3 = new Label();
		label4 = new Label();
		linkHome = new LinkLabel();
		groupBox1 = new GroupBox();
		label7 = new Label();
		linkOrder = new LinkLabel();
		label6 = new Label();
		label5 = new Label();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 8));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(252, 15));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("DevComponents DotNetBar Component");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(10, 32));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(307, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("(c) 2001-2004 by DevComponents.com, All Rights Reserved");
		((Control)button1).set_Enabled(false);
		((Control)button1).set_Location(new Point(10, 242));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(72, 24));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("OK");
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(89, 242));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(72, 24));
		((Control)button2).set_TabIndex(3);
		((Control)button2).set_Text("Buy Now");
		((Control)button2).add_Click((EventHandler)button2_Click);
		timer_0.set_Enabled(true);
		timer_0.set_Interval(800);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)linkEmail).set_Location(new Point(52, 200));
		((Control)linkEmail).set_Name("linkEmail");
		((Control)linkEmail).set_Size(new Size(145, 16));
		((Control)linkEmail).set_TabIndex(4);
		((Label)linkEmail).set_TabStop(true);
		((Control)linkEmail).set_Text("info@devcomponents.com");
		linkEmail.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkEmail_LinkClicked));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(12, 201));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(40, 13));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("E-Mail:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(13, 217));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(31, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Web:");
		((Control)linkHome).set_Location(new Point(53, 216));
		((Control)linkHome).set_Name("linkHome");
		((Control)linkHome).set_Size(new Size(145, 16));
		((Control)linkHome).set_TabIndex(6);
		((Label)linkHome).set_TabStop(true);
		((Control)linkHome).set_Text("www.devcomponents.com");
		linkHome.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkHome_LinkClicked));
		((Control)groupBox1).get_Controls().AddRange((Control[])(object)new Control[4]
		{
			(Control)label7,
			(Control)linkOrder,
			(Control)label6,
			(Control)label5
		});
		((Control)groupBox1).set_Location(new Point(14, 55));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(294, 135));
		((Control)groupBox1).set_TabIndex(8);
		groupBox1.set_TabStop(false);
		((Control)label7).set_Location(new Point(3, 104));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(285, 12));
		((Control)label7).set_TabIndex(3);
		((Control)label7).set_Text("Order at:");
		label7.set_TextAlign((ContentAlignment)32);
		((Control)linkOrder).set_Location(new Point(6, 116));
		((Control)linkOrder).set_Name("linkOrder");
		((Control)linkOrder).set_Size(new Size(280, 15));
		((Control)linkOrder).set_TabIndex(2);
		((Label)linkOrder).set_TabStop(true);
		((Control)linkOrder).set_Text("http://www.devcomponents.com/dotnetbar/order.html");
		((Label)linkOrder).set_TextAlign((ContentAlignment)32);
		linkOrder.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkOrder_LinkClicked));
		((Control)label6).set_Location(new Point(9, 72));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(276, 31));
		((Control)label6).set_TabIndex(1);
		((Control)label6).set_Text("For pricing and licensing information please visit our web site. ");
		((Control)label5).set_ForeColor(Color.Maroon);
		((Control)label5).set_Location(new Point(8, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(276, 41));
		((Control)label5).set_TabIndex(0);
		((Control)label5).set_Text("This component is not registered and it is provided for evaluation purposes only. This message will not appear after you register the component.");
		((Control)this).set_BackColor(Color.WhiteSmoke);
		((Form)this).set_AcceptButton((IButtonControl)(object)button1);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(321, 273));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[9]
		{
			(Control)groupBox1,
			(Control)label4,
			(Control)label3,
			(Control)label2,
			(Control)label1,
			(Control)linkHome,
			(Control)linkEmail,
			(Control)button2,
			(Control)button1
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("RemindForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Component not registered");
		((Control)groupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.set_Enabled(false);
		((Control)button1).set_Enabled(true);
		((Control)button1).Focus();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Process.Start(((Control)linkOrder).get_Text());
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("http://www.devcomponents.com");
	}

	private void linkEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("mailto:info@devcomponents.com");
	}

	private void linkOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start(((Control)linkOrder).get_Text());
	}
}
