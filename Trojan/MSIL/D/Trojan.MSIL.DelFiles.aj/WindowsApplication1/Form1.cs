using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	[AccessedThroughProperty("MenuStrip1")]
	private MenuStrip _MenuStrip1;

	[AccessedThroughProperty("FileToolStripMenuItem")]
	private ToolStripMenuItem _FileToolStripMenuItem;

	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

	[AccessedThroughProperty("ExitToolStripMenuItem1")]
	private ToolStripMenuItem _ExitToolStripMenuItem1;

	[AccessedThroughProperty("EditToolStripMenuItem")]
	private ToolStripMenuItem _EditToolStripMenuItem;

	[AccessedThroughProperty("CopyCodeToClipboardToolStripMenuItem")]
	private ToolStripMenuItem _CopyCodeToClipboardToolStripMenuItem;

	[AccessedThroughProperty("HelpToolStripMenuItem")]
	private ToolStripMenuItem _HelpToolStripMenuItem;

	[AccessedThroughProperty("InstructionsToolStripMenuItem")]
	private ToolStripMenuItem _InstructionsToolStripMenuItem;

	[AccessedThroughProperty("AboutToolStripMenuItem")]
	private ToolStripMenuItem _AboutToolStripMenuItem;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	internal virtual MenuStrip MenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _MenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_MenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem FileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FileToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExitToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExitToolStripMenuItem_Click;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem = value;
			if (_ExitToolStripMenuItem != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ExitToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExitToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExitToolStripMenuItem1_Click;
			if (_ExitToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem1).remove_Click(eventHandler);
			}
			_ExitToolStripMenuItem1 = value;
			if (_ExitToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ExitToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem EditToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _EditToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_EditToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem CopyCodeToClipboardToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _CopyCodeToClipboardToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = CopyCodeToClipboardToolStripMenuItem_Click;
			if (_CopyCodeToClipboardToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyCodeToClipboardToolStripMenuItem).remove_Click(eventHandler);
			}
			_CopyCodeToClipboardToolStripMenuItem = value;
			if (_CopyCodeToClipboardToolStripMenuItem != null)
			{
				((ToolStripItem)_CopyCodeToClipboardToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem HelpToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _HelpToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_HelpToolStripMenuItem = value;
		}
	}

	internal virtual ToolStripMenuItem InstructionsToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _InstructionsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = InstructionsToolStripMenuItem_Click;
			if (_InstructionsToolStripMenuItem != null)
			{
				((ToolStripItem)_InstructionsToolStripMenuItem).remove_Click(eventHandler);
			}
			_InstructionsToolStripMenuItem = value;
			if (_InstructionsToolStripMenuItem != null)
			{
				((ToolStripItem)_InstructionsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem AboutToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _AboutToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AboutToolStripMenuItem_Click;
			if (_AboutToolStripMenuItem != null)
			{
				((ToolStripItem)_AboutToolStripMenuItem).remove_Click(eventHandler);
			}
			_AboutToolStripMenuItem = value;
			if (_AboutToolStripMenuItem != null)
			{
				((ToolStripItem)_AboutToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
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

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		MenuStrip1 = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem = new ToolStripMenuItem();
		ExitToolStripMenuItem1 = new ToolStripMenuItem();
		EditToolStripMenuItem = new ToolStripMenuItem();
		CopyCodeToClipboardToolStripMenuItem = new ToolStripMenuItem();
		HelpToolStripMenuItem = new ToolStripMenuItem();
		InstructionsToolStripMenuItem = new ToolStripMenuItem();
		AboutToolStripMenuItem = new ToolStripMenuItem();
		ComboBox1 = new ComboBox();
		Label1 = new Label();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button button = Button1;
		Point location = new Point(92, 97);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Generate Code");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(12, 71);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		size = new Size(44, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(1);
		TextBox textBox3 = TextBox2;
		location = new Point(62, 71);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		TextBox textBox4 = TextBox2;
		size = new Size(44, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(1);
		TextBox textBox5 = TextBox3;
		location = new Point(112, 71);
		((Control)textBox5).set_Location(location);
		((Control)TextBox3).set_Name("TextBox3");
		((TextBoxBase)TextBox3).set_ReadOnly(true);
		TextBox textBox6 = TextBox3;
		size = new Size(44, 20);
		((Control)textBox6).set_Size(size);
		((Control)TextBox3).set_TabIndex(1);
		TextBox textBox7 = TextBox4;
		location = new Point(162, 71);
		((Control)textBox7).set_Location(location);
		((Control)TextBox4).set_Name("TextBox4");
		((TextBoxBase)TextBox4).set_ReadOnly(true);
		TextBox textBox8 = TextBox4;
		size = new Size(44, 20);
		((Control)textBox8).set_Size(size);
		((Control)TextBox4).set_TabIndex(1);
		TextBox textBox9 = TextBox5;
		location = new Point(212, 71);
		((Control)textBox9).set_Location(location);
		((Control)TextBox5).set_Name("TextBox5");
		((TextBoxBase)TextBox5).set_ReadOnly(true);
		TextBox textBox10 = TextBox5;
		size = new Size(44, 20);
		((Control)textBox10).set_Size(size);
		((Control)TextBox5).set_TabIndex(1);
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)EditToolStripMenuItem,
			(ToolStripItem)HelpToolStripMenuItem
		});
		MenuStrip menuStrip = MenuStrip1;
		location = new Point(0, 0);
		((Control)menuStrip).set_Location(location);
		((Control)MenuStrip1).set_Name("MenuStrip1");
		MenuStrip menuStrip2 = MenuStrip1;
		size = new Size(265, 24);
		((Control)menuStrip2).set_Size(size);
		((Control)MenuStrip1).set_TabIndex(2);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)ExitToolStripMenuItem,
			(ToolStripItem)ExitToolStripMenuItem1
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		ToolStripMenuItem fileToolStripMenuItem = FileToolStripMenuItem;
		size = new Size(35, 20);
		((ToolStripItem)fileToolStripMenuItem).set_Size(size);
		((ToolStripItem)FileToolStripMenuItem).set_Text("File");
		((ToolStripItem)ExitToolStripMenuItem).set_Name("ExitToolStripMenuItem");
		ToolStripMenuItem exitToolStripMenuItem = ExitToolStripMenuItem;
		size = new Size(158, 22);
		((ToolStripItem)exitToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem).set_Text("Generate Code");
		((ToolStripItem)ExitToolStripMenuItem1).set_Name("ExitToolStripMenuItem1");
		ToolStripMenuItem exitToolStripMenuItem2 = ExitToolStripMenuItem1;
		size = new Size(158, 22);
		((ToolStripItem)exitToolStripMenuItem2).set_Size(size);
		((ToolStripItem)ExitToolStripMenuItem1).set_Text("Exit");
		((ToolStripDropDownItem)EditToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)CopyCodeToClipboardToolStripMenuItem });
		((ToolStripItem)EditToolStripMenuItem).set_Name("EditToolStripMenuItem");
		ToolStripMenuItem editToolStripMenuItem = EditToolStripMenuItem;
		size = new Size(37, 20);
		((ToolStripItem)editToolStripMenuItem).set_Size(size);
		((ToolStripItem)EditToolStripMenuItem).set_Text("Edit");
		((ToolStripItem)CopyCodeToClipboardToolStripMenuItem).set_Name("CopyCodeToClipboardToolStripMenuItem");
		ToolStripMenuItem copyCodeToClipboardToolStripMenuItem = CopyCodeToClipboardToolStripMenuItem;
		size = new Size(197, 22);
		((ToolStripItem)copyCodeToClipboardToolStripMenuItem).set_Size(size);
		((ToolStripItem)CopyCodeToClipboardToolStripMenuItem).set_Text("Copy code to Clipboard");
		((ToolStripDropDownItem)HelpToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)InstructionsToolStripMenuItem,
			(ToolStripItem)AboutToolStripMenuItem
		});
		((ToolStripItem)HelpToolStripMenuItem).set_Name("HelpToolStripMenuItem");
		ToolStripMenuItem helpToolStripMenuItem = HelpToolStripMenuItem;
		size = new Size(40, 20);
		((ToolStripItem)helpToolStripMenuItem).set_Size(size);
		((ToolStripItem)HelpToolStripMenuItem).set_Text("Help");
		((ToolStripItem)InstructionsToolStripMenuItem).set_Name("InstructionsToolStripMenuItem");
		ToolStripMenuItem instructionsToolStripMenuItem = InstructionsToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)instructionsToolStripMenuItem).set_Size(size);
		((ToolStripItem)InstructionsToolStripMenuItem).set_Text("Instructions");
		((ToolStripItem)AboutToolStripMenuItem).set_Name("AboutToolStripMenuItem");
		ToolStripMenuItem aboutToolStripMenuItem = AboutToolStripMenuItem;
		size = new Size(152, 22);
		((ToolStripItem)aboutToolStripMenuItem).set_Size(size);
		((ToolStripItem)AboutToolStripMenuItem).set_Text("About...");
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[4] { "400", "800", "1600", "4000" });
		ComboBox comboBox = ComboBox1;
		location = new Point(108, 37);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(96, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(3);
		ComboBox1.set_Text("800");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		Label label = Label1;
		location = new Point(42, 40);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(46, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Amount:");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(265, 125);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.95);
		((Form)this).set_Text("Uber Generator Pro v 1.5");
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public static string RandomString(int iLength)
	{
		Random random = new Random(DateTime.Now.Millisecond);
		int num = 48;
		int num2 = 57;
		int num3 = 65;
		int num4 = 90;
		string text = "";
		int num5 = default(int);
		while (num5 < iLength)
		{
			int num6 = random.Next(num, num4);
			if ((num6 >= num && num6 <= num2) || (num6 >= num3 && num6 <= num4))
			{
				text += Conversions.ToString(Strings.Chr(num6));
				num5 = checked(num5 + 1);
			}
		}
		return text;
	}

	public static string RandomString2(int iLength)
	{
		Thread.Sleep(15);
		Random random = new Random(DateTime.Now.Millisecond);
		int num = 48;
		int num2 = 57;
		int num3 = 65;
		int num4 = 90;
		string text = "";
		int num5 = default(int);
		while (num5 < iLength)
		{
			int num6 = random.Next(num, num4);
			if ((num6 >= num && num6 <= num2) || (num6 >= num3 && num6 <= num4))
			{
				text += Conversions.ToString(Strings.Chr(num6));
				num5 = checked(num5 + 1);
			}
		}
		return text;
	}

	public static string RandomString3(int iLength)
	{
		Thread.Sleep(10);
		Random random = new Random(DateTime.Now.Millisecond);
		int num = 48;
		int num2 = 57;
		int num3 = 65;
		int num4 = 90;
		string text = "";
		int num5 = default(int);
		while (num5 < iLength)
		{
			int num6 = random.Next(num, num4);
			if ((num6 >= num && num6 <= num2) || (num6 >= num3 && num6 <= num4))
			{
				text += Conversions.ToString(Strings.Chr(num6));
				num5 = checked(num5 + 1);
			}
		}
		return text;
	}

	public static string RandomString4(int iLength)
	{
		Thread.Sleep(14);
		Random random = new Random(DateTime.Now.Millisecond);
		int num = 48;
		int num2 = 57;
		int num3 = 65;
		int num4 = 90;
		string text = "";
		int num5 = default(int);
		while (num5 < iLength)
		{
			int num6 = random.Next(num, num4);
			if ((num6 >= num && num6 <= num2) || (num6 >= num3 && num6 <= num4))
			{
				text += Conversions.ToString(Strings.Chr(num6));
				num5 = checked(num5 + 1);
			}
		}
		return text;
	}

	public static string RandomString5(int iLength)
	{
		Thread.Sleep(11);
		Random random = new Random(DateTime.Now.Millisecond);
		int num = 48;
		int num2 = 57;
		int num3 = 65;
		int num4 = 90;
		string text = "";
		int num5 = default(int);
		while (num5 < iLength)
		{
			int num6 = random.Next(num, num4);
			if ((num6 >= num && num6 <= num2) || (num6 >= num3 && num6 <= num4))
			{
				text += Conversions.ToString(Strings.Chr(num6));
				num5 = checked(num5 + 1);
			}
		}
		return text;
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		TextBox1.set_Text(RandomString(Conversions.ToInteger("5")));
		TextBox2.set_Text(RandomString2(Conversions.ToInteger("5")));
		TextBox3.set_Text(RandomString3(Conversions.ToInteger("5")));
		TextBox4.set_Text(RandomString4(Conversions.ToInteger("5")));
		TextBox5.set_Text(RandomString5(Conversions.ToInteger("5")));
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Console.Beep(500, 100);
		Console.Beep(600, 100);
		Console.Beep(700, 100);
		Console.Beep(800, 100);
		Console.Beep(700, 100);
		Console.Beep(600, 100);
		Console.Beep(500, 100);
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		TextBox1.set_Text(RandomString(Conversions.ToInteger("5")));
		TextBox2.set_Text(RandomString2(Conversions.ToInteger("5")));
		TextBox3.set_Text(RandomString3(Conversions.ToInteger("5")));
		TextBox4.set_Text(RandomString4(Conversions.ToInteger("5")));
		TextBox5.set_Text(RandomString5(Conversions.ToInteger("5")));
	}

	private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Created by Headshots 1125", "Uber Generator Pro");
	}

	private void InstructionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("The code generated is based on how many points it's used for, so all you need to do is choose the amount of points, either 400, 800, 1600, or 4000, and then hit generate. Yes, it's really that simple", "Instructions");
	}

	private void CopyCodeToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Clipboard.Clear();
		Clipboard.SetText(TextBox1.get_Text() + "-" + TextBox2.get_Text() + "-" + TextBox3.get_Text() + "-" + TextBox4.get_Text() + "-" + TextBox5.get_Text());
	}
}
