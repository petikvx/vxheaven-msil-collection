using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace XmlCreator;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox3_Leave;
			if (_TextBox3 != null)
			{
				((Control)_TextBox3).remove_Leave(eventHandler);
			}
			_TextBox3 = value;
			if (_TextBox3 != null)
			{
				((Control)_TextBox3).add_Leave(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button1_Click;
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click(eventHandler);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button2_Click;
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click(eventHandler);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox4 = value;
		}
	}

	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox5 = value;
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox1 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button3_Click;
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click(eventHandler);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox6 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		TextBox3 = new TextBox();
		Label3 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		Label4 = new Label();
		Label5 = new Label();
		RichTextBox1 = new RichTextBox();
		Button3 = new Button();
		TextBox6 = new TextBox();
		Label6 = new Label();
		Button4 = new Button();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(35, 70);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(185, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(2);
		TextBox textBox3 = TextBox2;
		location = new Point(250, 70);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(164, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(3);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(93, 51);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(67, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Item Number");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(279, 51);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(82, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(12);
		Label2.set_Text("Chance of Drop");
		TextBox textBox5 = TextBox3;
		location = new Point(414, 12);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(133, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(1);
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(323, 19);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(85, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text("Monster Number");
		Button button = Button1;
		location = new Point(472, 68);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Add");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(70, 401);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(150, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(8);
		((ButtonBase)Button2).set_Text("Create XML FIle");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		TextBox textBox7 = TextBox4;
		location = new Point(35, 147);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(185, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(5);
		TextBox textBox9 = TextBox5;
		location = new Point(250, 147);
		((Control)textBox9).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox10 = TextBox5;
		size = new Size(164, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox5).set_TabIndex(6);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(83, 131);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(77, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(13);
		Label4.set_Text("Minimum Meso");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(297, 131);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(80, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(14);
		Label5.set_Text("Maximum Meso");
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(35, 173);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(528, 222);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(15);
		RichTextBox1.set_Text("");
		Button button5 = Button3;
		location = new Point(472, 143);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(7);
		((ButtonBase)Button3).set_Text("Add");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		TextBox textBox11 = TextBox6;
		location = new Point(86, 12);
		((Control)textBox11).set_Location(location);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox12 = TextBox6;
		size = new Size(214, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox6).set_TabIndex(0);
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(32, 19);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(48, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(9);
		Label6.set_Text("Monster ");
		Button button7 = Button4;
		location = new Point(385, 401);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(75, 23);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(16);
		((ButtonBase)Button4).set_Text("Quit");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(592, 436);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Drop List Creator");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void TextBox3_Leave(object sender, EventArgs e)
	{
		((TextBoxBase)RichTextBox1).AppendText("<!-- " + TextBox6.get_Text() + " -->\r\n");
		((TextBoxBase)RichTextBox1).AppendText("<Mob>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t<Drops>\r\n");
		((Control)RichTextBox1).Refresh();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((TextBoxBase)RichTextBox1).AppendText("\t\t<Drop>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t\t\t<ID>" + TextBox1.get_Text() + "</ID>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t\t\t<Chance>" + TextBox2.get_Text() + "</Chance>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t\t</Drop>\r\n");
		TextBox1.set_Text("");
		((Control)TextBox1).Focus();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		((TextBoxBase)RichTextBox1).AppendText("\t</Drops>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t<Mesos>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t\t<Min>" + TextBox4.get_Text() + "</Min>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t\t<Max>" + TextBox5.get_Text() + "</Max>\r\n");
		((TextBoxBase)RichTextBox1).AppendText("\t</Mesos>\r\n");
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((TextBoxBase)RichTextBox1).AppendText("</Mob>");
		RichTextBox1.SaveFile("C:\\Drops\\" + TextBox3.get_Text().ToString() + ".xml", (RichTextBoxStreamType)4);
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox6).Clear();
		((TextBoxBase)RichTextBox1).Clear();
		((Control)TextBox6).Focus();
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
