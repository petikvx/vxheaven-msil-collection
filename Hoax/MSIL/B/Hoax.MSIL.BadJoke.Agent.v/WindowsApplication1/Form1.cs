using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace WindowsApplication1;

[DesignerGenerated]
public class Form1 : Form
{
	public class CloseButton
	{
		private const int SC_CLOSE = 61536;

		private const int MF_BYCOMMAND = 0;

		private const int MF_GRAYED = 1;

		private const int MF_ENABLED = 0;

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetSystemMenu(int hwnd, int revert);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int EnableMenuItem(int menu, int ideEnableItem, int enable);

		private CloseButton()
		{
		}

		public static void Disable(Form form)
		{
			switch (EnableMenuItem(GetSystemMenu(((Control)form).get_Handle().ToInt32(), 0), 61536, 1))
			{
			case -1:
				throw new Exception("The Close menu item does not exist.");
			case 0:
			case 1:
				break;
			}
		}
	}

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	[AccessedThroughProperty("Version")]
	private Label _Version;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	private object currentPath;

	private FolderBrowserDialog Browse1;

	[AccessedThroughProperty("altF4disable")]
	private GlobalHotKey _altF4disable;

	[AccessedThroughProperty("altc")]
	private GlobalHotKey _altc;

	[AccessedThroughProperty("altr")]
	private GlobalHotKey _altr;

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
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click((EventHandler)Button4_Click);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click((EventHandler)Button4_Click);
			}
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click((EventHandler)Button5_Click);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click((EventHandler)Button5_Click);
			}
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_RadioButton1 != null)
			{
				_RadioButton1.remove_CheckedChanged((EventHandler)RadioButton1_CheckedChanged);
			}
			_RadioButton1 = value;
			if (_RadioButton1 != null)
			{
				_RadioButton1.add_CheckedChanged((EventHandler)RadioButton1_CheckedChanged);
			}
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_RadioButton2 != null)
			{
				_RadioButton2.remove_CheckedChanged((EventHandler)RadioButton2_CheckedChanged);
			}
			_RadioButton2 = value;
			if (_RadioButton2 != null)
			{
				_RadioButton2.add_CheckedChanged((EventHandler)RadioButton2_CheckedChanged);
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
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).remove_TextChanged((EventHandler)TextBox1_TextChanged);
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).add_TextChanged((EventHandler)TextBox1_TextChanged);
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

	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button6 != null)
			{
				((Control)_Button6).remove_Click((EventHandler)Button6_Click);
			}
			_Button6 = value;
			if (_Button6 != null)
			{
				((Control)_Button6).add_Click((EventHandler)Button6_Click);
			}
		}
	}

	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button7 != null)
			{
				((Control)_Button7).remove_Click((EventHandler)Button7_Click);
			}
			_Button7 = value;
			if (_Button7 != null)
			{
				((Control)_Button7).add_Click((EventHandler)Button7_Click);
			}
		}
	}

	internal virtual Button Button8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button8 != null)
			{
				((Control)_Button8).remove_Click((EventHandler)Button8_Click);
			}
			_Button8 = value;
			if (_Button8 != null)
			{
				((Control)_Button8).add_Click((EventHandler)Button8_Click);
			}
		}
	}

	internal virtual Button Button9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button9 != null)
			{
				((Control)_Button9).remove_Click((EventHandler)Button9_Click);
			}
			_Button9 = value;
			if (_Button9 != null)
			{
				((Control)_Button9).add_Click((EventHandler)Button9_Click);
			}
		}
	}

	internal virtual Label Version
	{
		[DebuggerNonUserCode]
		get
		{
			return _Version;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Version = value;
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
			if (_CheckBox1 != null)
			{
				_CheckBox1.remove_CheckedChanged((EventHandler)CheckBox1_CheckedChanged);
			}
			_CheckBox1 = value;
			if (_CheckBox1 != null)
			{
				_CheckBox1.add_CheckedChanged((EventHandler)CheckBox1_CheckedChanged);
			}
		}
	}

	internal virtual Button Button10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_Button10 != null)
			{
				((Control)_Button10).remove_Click((EventHandler)Button10_Click);
			}
			_Button10 = value;
			if (_Button10 != null)
			{
				((Control)_Button10).add_Click((EventHandler)Button10_Click);
			}
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

	private virtual GlobalHotKey altF4disable
	{
		[DebuggerNonUserCode]
		get
		{
			return _altF4disable;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_altF4disable != null)
			{
				_altF4disable.HotKeyPressed -= altF4disable_HotKeyPressed;
			}
			_altF4disable = value;
			if (_altF4disable != null)
			{
				_altF4disable.HotKeyPressed += altF4disable_HotKeyPressed;
			}
		}
	}

	private virtual GlobalHotKey altc
	{
		[DebuggerNonUserCode]
		get
		{
			return _altc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_altc != null)
			{
				_altc.HotKeyPressed -= altc_HotKeyPressed;
			}
			_altc = value;
			if (_altc != null)
			{
				_altc.HotKeyPressed += altc_HotKeyPressed;
			}
		}
	}

	private virtual GlobalHotKey altr
	{
		[DebuggerNonUserCode]
		get
		{
			return _altr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_altr != null)
			{
				_altr.HotKeyPressed -= altr_HotKeyPressed;
			}
			_altr = value;
			if (_altr != null)
			{
				_altr.HotKeyPressed += altr_HotKeyPressed;
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
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
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected O, but got Unknown
		//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Button4 = new Button();
		Button5 = new Button();
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		TextBox1 = new TextBox();
		Label1 = new Label();
		Button6 = new Button();
		Button7 = new Button();
		Button8 = new Button();
		Button9 = new Button();
		Version = new Label();
		CheckBox1 = new CheckBox();
		Button10 = new Button();
		Label2 = new Label();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(23, 292);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(325, 30);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Legitimate the player.bmd file");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(370, 252);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(95, 73);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Exit");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(23, 252);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(325, 30);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(2);
		((ButtonBase)Button3).set_Text("Crack the player.bmd file");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Button button7 = Button4;
		location = new Point(12, 40);
		((Control)button7).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button8 = Button4;
		size = new Size(109, 51);
		((Control)button8).set_Size(size);
		((Control)Button4).set_TabIndex(3);
		((ButtonBase)Button4).set_Text("Launch Travis Minimizer");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button5).set_Enabled(false);
		Button button9 = Button5;
		location = new Point(350, 40);
		((Control)button9).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button10 = Button5;
		size = new Size(115, 51);
		((Control)button10).set_Size(size);
		((Control)Button5).set_TabIndex(4);
		((ButtonBase)Button5).set_Text("Launch \"Evil Spirit\" Minimizer (Private Version)");
		((ButtonBase)Button5).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton1.set_Checked(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(23, 145);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(211, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(5);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("Default (C:\\Program Files\\Webzen\\Mu)");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(23, 168);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(93, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(6);
		((ButtonBase)RadioButton2).set_Text("Other (specify)");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Enabled(false);
		TextBox textBox = TextBox1;
		location = new Point(23, 191);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(233, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(7);
		TextBox1.set_Text("C:\\Program Files\\Webzen\\Mu");
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(SystemColors.Info);
		Label label = Label1;
		location = new Point(135, 9);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(202, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(8);
		Label1.set_Text("This program was made by ShadowBeast");
		Button button11 = Button6;
		location = new Point(149, 51);
		((Control)button11).set_Location(location);
		((Control)Button6).set_Name("Button6");
		Button button12 = Button6;
		size = new Size(179, 40);
		((Control)button12).set_Size(size);
		((Control)Button6).set_TabIndex(9);
		((ButtonBase)Button6).set_Text("Fix the lower_03b_m.OZT Problem");
		((ButtonBase)Button6).set_UseVisualStyleBackColor(true);
		Button button13 = Button7;
		location = new Point(354, 108);
		((Control)button13).set_Location(location);
		((Control)Button7).set_Name("Button7");
		Button button14 = Button7;
		size = new Size(114, 43);
		((Control)button14).set_Size(size);
		((Control)Button7).set_TabIndex(10);
		((ButtonBase)Button7).set_Text("Launch Mu Global");
		((ButtonBase)Button7).set_UseVisualStyleBackColor(true);
		((Control)Button8).set_Enabled(false);
		Button button15 = Button8;
		location = new Point(262, 191);
		((Control)button15).set_Location(location);
		((Control)Button8).set_Name("Button8");
		Button button16 = Button8;
		size = new Size(65, 20);
		((Control)button16).set_Size(size);
		((Control)Button8).set_TabIndex(11);
		((ButtonBase)Button8).set_Text("Browse...");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		Button button17 = Button9;
		location = new Point(15, 108);
		((Control)button17).set_Location(location);
		((Control)Button9).set_Name("Button9");
		Button button18 = Button9;
		size = new Size(333, 31);
		((Control)button18).set_Size(size);
		((Control)Button9).set_TabIndex(12);
		((ButtonBase)Button9).set_Text("Disable Sound and Friends for Mu global (If the fix didn't work)");
		((ButtonBase)Button9).set_UseVisualStyleBackColor(true);
		Version.set_AutoSize(true);
		((Control)Version).set_ForeColor(SystemColors.InfoText);
		Label version = Version;
		location = new Point(20, 9);
		((Control)version).set_Location(location);
		((Control)Version).set_Name("Version");
		Label version2 = Version;
		size = new Size(60, 13);
		((Control)version2).set_Size(size);
		((Control)Version).set_TabIndex(13);
		Version.set_Text("Version 1.3");
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(23, 229);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(104, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(14);
		((ButtonBase)CheckBox1).set_Text("Toggle TopMost");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Button button19 = Button10;
		location = new Point(15, 108);
		((Control)button19).set_Location(location);
		((Control)Button10).set_Name("Button10");
		Button button20 = Button10;
		size = new Size(333, 31);
		((Control)button20).set_Size(size);
		((Control)Button10).set_TabIndex(15);
		((ButtonBase)Button10).set_Text("Enable Sound and Friends for Mu global (If the fix did work)");
		((ButtonBase)Button10).set_UseVisualStyleBackColor(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)177));
		((Control)Label2).set_ForeColor(SystemColors.ControlText);
		Label label3 = Label2;
		location = new Point(345, 168);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(120, 43);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(16);
		Label2.set_Text("Your player.bmd file is <unknown>");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientInactiveCaption);
		size = new Size(477, 337);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Button10);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Version);
		((Control)this).get_Controls().Add((Control)(object)Button9);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Button7);
		((Control)this).get_Controls().Add((Control)(object)Button6);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)Button5);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Speed Hack Simplifier");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("winmm.dll")]
	public static extern uint timeGetTime();

	public Form1()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		currentPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
		Browse1 = new FolderBrowserDialog();
		altF4disable = new GlobalHotKey((Keys)115, (Keys)262144);
		altc = new GlobalHotKey((Keys)67, (Keys)262144);
		altr = new GlobalHotKey((Keys)82, (Keys)262144);
		InitializeComponent();
	}

	private void altc_HotKeyPressed(object sender, EventArgs e)
	{
		Button3_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void altr_HotKeyPressed(object sender, EventArgs e)
	{
		Button1_Click(RuntimeHelpers.GetObjectValue(sender), e);
	}

	private void altF4disable_HotKeyPressed(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("The program has temporarly disabled the F4 key." + Environment.NewLine + "Sorry for the inconvenience.", "Sorry!", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	public void CheckBmd()
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FileInfo fileInfo = new FileInfo(TextBox1.get_Text() + "\\Data\\Player\\player.bmd");
			if (fileInfo.Length == 1477974L)
			{
				((Control)Button3).set_Enabled(false);
				((ButtonBase)Button3).set_Text("Player.bmd is cracked");
				Label2.set_Text("Your player.bmd file is cracked");
				((Control)Label2).set_ForeColor(Color.Red);
			}
			else
			{
				((Control)Button1).set_Enabled(false);
				((ButtonBase)Button1).set_Text("Player.bmd is legit");
				Label2.set_Text("Your player.bmd file is legit");
				((Control)Label2).set_ForeColor(Color.Blue);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Wrong Path is Set", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (!((Control)TextBox1).get_Enabled())
		{
			File.Copy(Conversions.ToString(Operators.AddObject(currentPath, (object)"data1.dll")), "C:\\Program Files\\Webzen\\Mu\\Data\\Player\\player.bmd", overwrite: true);
		}
		else
		{
			File.Copy(Conversions.ToString(Operators.AddObject(currentPath, (object)"data1.dll")), TextBox1.get_Text() + "\\Data\\Player\\player.bmd", overwrite: true);
		}
		((Control)Button3).set_Enabled(true);
		((ButtonBase)Button3).set_Text("Crack the player.bmd file");
		((Control)Button1).set_Enabled(false);
		((ButtonBase)Button1).set_Text("Player.bmd is legit");
		Label2.set_Text("Your player.bmd file is legit");
		((Control)Label2).set_ForeColor(Color.Blue);
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		object obj = Registry.CurrentUser.OpenSubKey("Software\\ShadowBeast\\Speed Hack Simplifier", writable: true);
		object[] array = new object[2] { "MuPath", null };
		TextBox textBox = TextBox1;
		array[1] = textBox.get_Text();
		object[] array2 = array;
		bool[] array3 = new bool[2] { false, true };
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", array2, (string[])null, (Type[])null, array3, true);
		if (array3[1])
		{
			textBox.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[1]), typeof(string)));
		}
		NewLateBinding.LateCall(obj, (Type)null, "close", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		ProjectData.EndApp();
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		if (!((Control)TextBox1).get_Enabled())
		{
			File.Copy(Conversions.ToString(Operators.AddObject(currentPath, (object)"data2.dll")), "C:\\Program Files\\Webzen\\Mu\\Data\\Player\\player.bmd", overwrite: true);
		}
		else
		{
			File.Copy(Conversions.ToString(Operators.AddObject(currentPath, (object)"data2.dll")), TextBox1.get_Text() + "\\Data\\Player\\player.bmd", overwrite: true);
		}
		((Control)Button3).set_Enabled(false);
		((ButtonBase)Button3).set_Text("Player.bmd is cracked");
		((Control)Button1).set_Enabled(true);
		((ButtonBase)Button1).set_Text("Legitimate the player.bmd file");
		Label2.set_Text("Your player.bmd file is cracked");
		((Control)Label2).set_ForeColor(Color.Red);
	}

	private void Button4_Click(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(Conversions.ToString(Operators.AddObject(currentPath, (object)"Travis/Travis.exe")));
		processStartInfo.WorkingDirectory = Conversions.ToString(Operators.AddObject(currentPath, (object)"Travis/"));
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "open";
		Process.Start(processStartInfo);
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		NewLateBinding.LateCall((object)null, typeof(Process), "Start", new object[1] { Operators.AddObject(currentPath, (object)"EvilSpirit/EvilSpirit.exe") }, (string[])null, (Type[])null, (bool[])null, true);
	}

	private void RadioButton1_CheckedChanged(object sender, EventArgs e)
	{
		((Control)TextBox1).set_Enabled(false);
		((Control)Button8).set_Enabled(false);
	}

	private void RadioButton2_CheckedChanged(object sender, EventArgs e)
	{
		((Control)TextBox1).set_Enabled(true);
		((Control)Button8).set_Enabled(true);
	}

	private void Button6_Click(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (!((Control)TextBox1).get_Enabled())
		{
			File.Copy(Conversions.ToString(Operators.AddObject(currentPath, (object)"data3.dll")), "C:\\Program Files\\Webzen\\Mu\\Data\\Player\\lower_03b_m.OZT", overwrite: true);
		}
		else
		{
			File.Copy(Conversions.ToString(Operators.AddObject(currentPath, (object)"data3.dll")), TextBox1.get_Text() + "\\Data\\Player\\lower_03b_m.OZT", overwrite: true);
		}
		Interaction.MsgBox((object)"lower_03b_m.OZT problem successfully resolved", (MsgBoxStyle)0, (object)null);
	}

	private int PortEncode(int InVal)
	{
		if (InVal % 10 > 5)
		{
			return checked(InVal - 4);
		}
		return checked(InVal + 4);
	}

	private void Button7_Click(object sender, EventArgs e)
	{
		new Mutex(initiallyOwned: true, "MU AutoUpdate");
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WebZen\\Mu\\Connection");
		registryKey.SetValue("Key", timeGetTime(), RegistryValueKind.DWord);
		registryKey.SetValue("ParameterA", ">79AD91E<71E", RegistryValueKind.String);
		registryKey.SetValue("ParameterB", 44409, RegistryValueKind.DWord);
		if (!((Control)TextBox1).get_Enabled())
		{
			TextBox1.set_Text("C:\\Program Files\\Webzen\\Mu");
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(TextBox1.get_Text() + "\\main.exe");
		ProcessStartInfo processStartInfo = new ProcessStartInfo(TextBox1.get_Text() + "\\main.exe", "connect");
		processStartInfo.WorkingDirectory = directoryInfo.Parent!.FullName;
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "open";
		Process.Start(processStartInfo);
	}

	private void Button8_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)((CommonDialog)Browse1).ShowDialog() > 0)
		{
			TextBox1.set_Text(Browse1.get_SelectedPath());
		}
	}

	private void Button9_Click(object sender, EventArgs e)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		object obj = Registry.CurrentUser.OpenSubKey("Software\\Webzen\\Mu\\Config", writable: true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[2] { "TextInput", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[2] { "SoundOnOff", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[2] { "MusicOnOff", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		Interaction.MsgBox((object)"Sound and Friends successfully Disabled", (MsgBoxStyle)0, (object)null);
		((Control)Button9).set_Visible(false);
		((Control)Button10).set_Visible(true);
	}

	private void CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (!((Form)this).get_TopMost())
		{
			((Form)this).set_TopMost(true);
		}
		else
		{
			((Form)this).set_TopMost(false);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (Registry.CurrentUser.OpenSubKey("Software\\ShadowBeast\\Speed Hack Simplifier", writable: true) == null)
		{
			MessageBox.Show("Thank you for using this program for the first time, remember to read the readme file before further use, enjoy!");
			Registry.CurrentUser.CreateSubKey("Software\\ShadowBeast\\Speed Hack Simplifier");
			Registry.CurrentUser.OpenSubKey("Software\\ShadowBeast\\Speed Hack Simplifier", writable: true)!.SetValue("MuPath", "C:\\Program Files\\Webzen\\Mu");
		}
		else if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(Registry.CurrentUser.OpenSubKey("Software\\ShadowBeast\\Speed Hack Simplifier")!.GetValue("MuPath"), (object)"C:\\Program Files\\Webzen\\Mu", false))))
		{
			RadioButton2.set_Checked(true);
			RadioButton1.set_Checked(false);
			TextBox1.set_Text(Conversions.ToString(Registry.CurrentUser.OpenSubKey("Software\\ShadowBeast\\Speed Hack Simplifier")!.GetValue("MuPath")));
		}
		if (File.Exists(TextBox1.get_Text() + "\\Data\\Player\\lower_03b_m.OZT") | File.Exists("C:\\Program Files\\Webzen\\Mu\\Data\\Player\\lower_03b_m.OZT"))
		{
			((Control)Button6).set_Enabled(false);
			((ButtonBase)Button6).set_Text("Fix Already Applied");
		}
		object obj = Registry.CurrentUser.OpenSubKey("Software\\Webzen\\Mu\\Config", writable: true);
		if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GetValue", new object[1] { "TextInput" }, (string[])null, (Type[])null, (bool[])null), (object)0, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GetValue", new object[1] { "MusicOnOff" }, (string[])null, (Type[])null, (bool[])null), (object)0, false)), Operators.CompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "GetValue", new object[1] { "SoundOnOff" }, (string[])null, (Type[])null, (bool[])null), (object)0, false))))
		{
			((Control)Button9).set_Visible(false);
			((Control)Button10).set_Visible(true);
		}
		else
		{
			((Control)Button10).set_Visible(false);
			((Control)Button9).set_Visible(true);
		}
		CheckBmd();
		CloseButton.Disable((Form)(object)this);
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(TextBox1.get_Text() + "\\Data\\Player\\lower_03b_m.OZT"))
		{
			((Control)Button6).set_Enabled(false);
			((ButtonBase)Button6).set_Text("Fix Already Applied");
		}
		if (File.Exists(TextBox1.get_Text() + "\\main.exe"))
		{
			FileInfo fileInfo = new FileInfo(TextBox1.get_Text() + "\\main.exe");
			if (fileInfo.Length != 893083L)
			{
				MessageBox.Show("This version of Mu is not global v1.00c(1.00.03) and this hack might not work best in this version");
			}
		}
	}

	private void Button10_Click(object sender, EventArgs e)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		object obj = Registry.CurrentUser.OpenSubKey("Software\\Webzen\\Mu\\Config", writable: true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[2] { "TextInput", 2 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[2] { "SoundOnOff", 1 }, (string[])null, (Type[])null, (bool[])null, true);
		NewLateBinding.LateCall(obj, (Type)null, "SetValue", new object[2] { "MusicOnOff", 0 }, (string[])null, (Type[])null, (bool[])null, true);
		MessageBox.Show("Sound and Friends successfully Enabled");
		((Control)Button10).set_Visible(false);
		((Control)Button9).set_Visible(true);
	}
}
