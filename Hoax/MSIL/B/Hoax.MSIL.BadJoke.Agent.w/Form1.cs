using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxInetCtlsObjects;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Inet1")]
	private AxInet _Inet1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("TextBox6")]
	private TextBox _TextBox6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("TextBox7")]
	private TextBox _TextBox7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("TextBox8")]
	private TextBox _TextBox8;

	private Collection MySplitLine;

	private string mainstr;

	private string HTML;

	internal virtual AxInet Inet1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Inet1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Inet1 = value;
		}
	}

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

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked));
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked));
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

	internal virtual TextBox TextBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox7 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual TextBox TextBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox8 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Inet1 = new AxInet();
		TextBox1 = new TextBox();
		Button1 = new Button();
		LinkLabel1 = new LinkLabel();
		Button2 = new Button();
		Label1 = new Label();
		TextBox2 = new TextBox();
		Label2 = new Label();
		Label3 = new Label();
		TextBox3 = new TextBox();
		Label4 = new Label();
		TextBox4 = new TextBox();
		Label5 = new Label();
		TextBox5 = new TextBox();
		Label6 = new Label();
		TextBox6 = new TextBox();
		Label7 = new Label();
		TextBox7 = new TextBox();
		Label8 = new Label();
		TextBox8 = new TextBox();
		((ISupportInitialize)Inet1).BeginInit();
		((Control)this).SuspendLayout();
		((AxHost)Inet1).set_Enabled(true);
		AxInet inet = Inet1;
		Point location = new Point(289, -17);
		((Control)inet).set_Location(location);
		((Control)Inet1).set_Name("Inet1");
		((AxHost)Inet1).set_OcxState((State)componentResourceManager.GetObject("Inet1.OcxState"));
		AxInet inet2 = Inet1;
		Size size = new Size(38, 38);
		((Control)inet2).set_Size(size);
		((Control)Inet1).set_TabIndex(14);
		TextBox textBox = TextBox1;
		location = new Point(76, 141);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(17);
		TextBox1.set_TextAlign((HorizontalAlignment)2);
		Button button = Button1;
		location = new Point(12, 167);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(18);
		((ButtonBase)Button1).set_Text("Calculate");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(95, 193);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(63, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(20);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("RsUG.co.nr");
		Button button3 = Button2;
		location = new Point(167, 167);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(21);
		((ButtonBase)Button2).set_Text("Exit");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(88, 125);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(75, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(22);
		Label1.set_Text("Combat Level:");
		TextBox textBox3 = TextBox2;
		location = new Point(48, 19);
		((Control)textBox3).set_Location(location);
		((TextBoxBase)TextBox2).set_MaxLength(2);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(48, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(23);
		TextBox2.set_TextAlign((HorizontalAlignment)2);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(45, 3);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(41, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(26);
		Label2.set_Text("Attack:");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(99, 3);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(50, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(28);
		Label3.set_Text("Strength:");
		TextBox textBox5 = TextBox3;
		location = new Point(102, 19);
		((Control)textBox5).set_Location(location);
		((TextBoxBase)TextBox3).set_MaxLength(2);
		((Control)TextBox3).set_Name("TextBox3");
		TextBox textBox6 = TextBox3;
		size = new Size(48, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(27);
		TextBox3.set_TextAlign((HorizontalAlignment)2);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(153, 3);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(51, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(30);
		Label4.set_Text("Defence:");
		TextBox textBox7 = TextBox4;
		location = new Point(156, 19);
		((Control)textBox7).set_Location(location);
		((TextBoxBase)TextBox4).set_MaxLength(2);
		((Control)TextBox4).set_Name("TextBox4");
		TextBox textBox8 = TextBox4;
		size = new Size(48, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(29);
		TextBox4.set_TextAlign((HorizontalAlignment)2);
		Label5.set_AutoSize(true);
		Label label9 = Label5;
		location = new Point(153, 44);
		((Control)label9).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label10 = Label5;
		size = new Size(40, 13);
		((Control)label10).set_Size(size);
		((Control)Label5).set_TabIndex(36);
		Label5.set_Text("Prayer:");
		TextBox textBox9 = TextBox5;
		location = new Point(156, 60);
		((Control)textBox9).set_Location(location);
		((TextBoxBase)TextBox5).set_MaxLength(2);
		((Control)TextBox5).set_Name("TextBox5");
		TextBox textBox10 = TextBox5;
		size = new Size(48, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox5).set_TabIndex(35);
		TextBox5.set_TextAlign((HorizontalAlignment)2);
		Label6.set_AutoSize(true);
		Label label11 = Label6;
		location = new Point(99, 44);
		((Control)label11).set_Location(location);
		((Control)Label6).set_Name("Label6");
		Label label12 = Label6;
		size = new Size(48, 13);
		((Control)label12).set_Size(size);
		((Control)Label6).set_TabIndex(34);
		Label6.set_Text("Ranged:");
		TextBox textBox11 = TextBox6;
		location = new Point(102, 60);
		((Control)textBox11).set_Location(location);
		((TextBoxBase)TextBox6).set_MaxLength(2);
		((Control)TextBox6).set_Name("TextBox6");
		TextBox textBox12 = TextBox6;
		size = new Size(48, 20);
		((Control)textBox12).set_Size(size);
		((Control)TextBox6).set_TabIndex(33);
		TextBox6.set_TextAlign((HorizontalAlignment)2);
		Label7.set_AutoSize(true);
		Label label13 = Label7;
		location = new Point(45, 44);
		((Control)label13).set_Location(location);
		((Control)Label7).set_Name("Label7");
		Label label14 = Label7;
		size = new Size(39, 13);
		((Control)label14).set_Size(size);
		((Control)Label7).set_TabIndex(32);
		Label7.set_Text("Magic:");
		TextBox textBox13 = TextBox7;
		location = new Point(48, 60);
		((Control)textBox13).set_Location(location);
		((TextBoxBase)TextBox7).set_MaxLength(2);
		((Control)TextBox7).set_Name("TextBox7");
		TextBox textBox14 = TextBox7;
		size = new Size(48, 20);
		((Control)textBox14).set_Size(size);
		((Control)TextBox7).set_TabIndex(31);
		TextBox7.set_TextAlign((HorizontalAlignment)2);
		Label8.set_AutoSize(true);
		Label label15 = Label8;
		location = new Point(99, 86);
		((Control)label15).set_Location(location);
		((Control)Label8).set_Name("Label8");
		Label label16 = Label8;
		size = new Size(51, 13);
		((Control)label16).set_Size(size);
		((Control)Label8).set_TabIndex(38);
		Label8.set_Text("Hitpoints:");
		TextBox textBox15 = TextBox8;
		location = new Point(102, 102);
		((Control)textBox15).set_Location(location);
		((TextBoxBase)TextBox8).set_MaxLength(2);
		((Control)TextBox8).set_Name("TextBox8");
		TextBox textBox16 = TextBox8;
		size = new Size(48, 20);
		((Control)textBox16).set_Size(size);
		((Control)TextBox8).set_TabIndex(37);
		TextBox8.set_TextAlign((HorizontalAlignment)2);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_BackColor(SystemColors.Control);
		size = new Size(254, 216);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)TextBox8);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)TextBox7);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Inet1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Combat Calculator");
		((ISupportInitialize)Inet1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 301:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0008:
					num = 2;
					mainstr = Conversions.ToString(Inet1.OpenURL((object)("http://www.westscript.com/calcs/combat.php?attack=" + TextBox2.get_Text() + "&defence=" + TextBox4.get_Text() + "&strength=" + TextBox3.get_Text() + "&hitpoints=" + TextBox8.get_Text() + "&prayer=" + TextBox5.get_Text() + "&range=" + TextBox6.get_Text() + "&magic=" + TextBox7.get_Text() + ""), (object)HTML));
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				TextBox1.set_Text(Strings.Split(Strings.Split(mainstr, "Combat Level:&nbsp;&nbsp; ", -1, (CompareMethod)0)[1], "</div>", -1, (CompareMethod)0)[0]);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 301;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 74:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0008:
					num = 2;
					LinkLabel1.set_LinkVisited(true);
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				Process.Start("IExplore", "http://rsug.co.nr");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 74;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 86:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0017;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0017:
					num = 3;
					Application.Exit();
					break;
					IL_0008:
					num = 2;
					Interaction.MsgBox((object)"Thanks for using Super-Man's Combat Calculator! Visit http://rsug.co.nr for more great applications!", (MsgBoxStyle)0, (object)null);
					goto IL_0017;
					end_IL_0000_2:
					break;
				}
				num = 4;
				Process.Start("IExplore", "http://rsug.co.nr");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 86;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
