using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AdbuxAutoClicker.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace AdbuxAutoClicker;

[DesignerGenerated]
public class frmMain : Form
{
	private IContainer components;

	[AccessedThroughProperty("nid")]
	private NotifyIcon _nid;

	[AccessedThroughProperty("lbl1")]
	private Label _lbl1;

	[AccessedThroughProperty("lbl2")]
	private Label _lbl2;

	[AccessedThroughProperty("lbl3")]
	private Label _lbl3;

	[AccessedThroughProperty("lblInstructions")]
	private Label _lblInstructions;

	[AccessedThroughProperty("cmdStart")]
	private Button _cmdStart;

	[AccessedThroughProperty("cmdStop")]
	private Button _cmdStop;

	[AccessedThroughProperty("cmdHide")]
	private Button _cmdHide;

	[AccessedThroughProperty("tmr")]
	private Timer _tmr;

	[AccessedThroughProperty("tmrWait")]
	private Timer _tmrWait;

	[AccessedThroughProperty("fraOptions")]
	private GroupBox _fraOptions;

	[AccessedThroughProperty("lblAdWatch")]
	private Label _lblAdWatch;

	[AccessedThroughProperty("txtCheck")]
	private TextBox _txtCheck;

	[AccessedThroughProperty("lblCheck")]
	private Label _lblCheck;

	[AccessedThroughProperty("txtWait")]
	private TextBox _txtWait;

	[AccessedThroughProperty("chkAds")]
	private CheckBox _chkAds;

	[AccessedThroughProperty("lblCash")]
	private Label _lblCash;

	[AccessedThroughProperty("lblTimerCount")]
	private Label _lblTimerCount;

	[AccessedThroughProperty("lblCashAmount")]
	private Label _lblCashAmount;

	[AccessedThroughProperty("lblTime")]
	private Label _lblTime;

	[AccessedThroughProperty("lstAds")]
	private ListBox _lstAds;

	[AccessedThroughProperty("lblAdsClicked")]
	private Label _lblAdsClicked;

	[AccessedThroughProperty("mnu")]
	private MenuStrip _mnu;

	[AccessedThroughProperty("FileToolStripMenuItem")]
	private ToolStripMenuItem _FileToolStripMenuItem;

	[AccessedThroughProperty("mnuExit")]
	private ToolStripMenuItem _mnuExit;

	[AccessedThroughProperty("mnuAbout")]
	private ToolStripMenuItem _mnuAbout;

	[AccessedThroughProperty("mnuSave")]
	private ToolStripMenuItem _mnuSave;

	[AccessedThroughProperty("chkAuto")]
	private CheckBox _chkAuto;

	[AccessedThroughProperty("ToolTip")]
	private ToolTip _ToolTip;

	[AccessedThroughProperty("lblC")]
	private Label _lblC;

	[AccessedThroughProperty("lblTR")]
	private Label _lblTR;

	[AccessedThroughProperty("lblRC")]
	private Label _lblRC;

	[AccessedThroughProperty("lblNC")]
	private Label _lblNC;

	[AccessedThroughProperty("lblNTR")]
	private Label _lblNTR;

	[AccessedThroughProperty("lblNRC")]
	private Label _lblNRC;

	[AccessedThroughProperty("chkStartup")]
	private CheckBox _chkStartup;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("lblRunningTime")]
	private ToolStripStatusLabel _lblRunningTime;

	[AccessedThroughProperty("lblRT")]
	private ToolStripStatusLabel _lblRT;

	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[AccessedThroughProperty("lblBrowser")]
	private ToolStripStatusLabel _lblBrowser;

	[AccessedThroughProperty("lblStatus")]
	private ToolStripStatusLabel _lblStatus;

	[AccessedThroughProperty("tmrTime")]
	private Timer _tmrTime;

	[AccessedThroughProperty("wb1")]
	private WebBrowser _wb1;

	[AccessedThroughProperty("wb")]
	private WebBrowser _wb;

	private bool bStop;

	private int counter;

	private string Ads;

	private string Names;

	private bool bDone;

	private bool bNext;

	internal virtual NotifyIcon nid
	{
		[DebuggerNonUserCode]
		get
		{
			return _nid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_nid != null)
			{
				_nid.remove_DoubleClick((EventHandler)nid_DoubleClick);
			}
			_nid = value;
			if (_nid != null)
			{
				_nid.add_DoubleClick((EventHandler)nid_DoubleClick);
			}
		}
	}

	internal virtual Label lbl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl1 = value;
		}
	}

	internal virtual Label lbl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl2 = value;
		}
	}

	internal virtual Label lbl3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl3 = value;
		}
	}

	internal virtual Label lblInstructions
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInstructions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInstructions = value;
		}
	}

	internal virtual Button cmdStart
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdStart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdStart != null)
			{
				((Control)_cmdStart).remove_Click((EventHandler)cmdStart_Click);
			}
			_cmdStart = value;
			if (_cmdStart != null)
			{
				((Control)_cmdStart).add_Click((EventHandler)cmdStart_Click);
			}
		}
	}

	internal virtual Button cmdStop
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdStop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdStop != null)
			{
				((Control)_cmdStop).remove_Click((EventHandler)cmdStop_Click);
			}
			_cmdStop = value;
			if (_cmdStop != null)
			{
				((Control)_cmdStop).add_Click((EventHandler)cmdStop_Click);
			}
		}
	}

	internal virtual Button cmdHide
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdHide;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_cmdHide != null)
			{
				((Control)_cmdHide).remove_Click((EventHandler)cmdHide_Click);
			}
			_cmdHide = value;
			if (_cmdHide != null)
			{
				((Control)_cmdHide).add_Click((EventHandler)cmdHide_Click);
			}
		}
	}

	internal virtual Timer tmr
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_tmr != null)
			{
				_tmr.remove_Tick((EventHandler)tmr_Tick);
			}
			_tmr = value;
			if (_tmr != null)
			{
				_tmr.add_Tick((EventHandler)tmr_Tick);
			}
		}
	}

	internal virtual Timer tmrWait
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmrWait;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_tmrWait != null)
			{
				_tmrWait.remove_Tick((EventHandler)tmrWait_Tick);
			}
			_tmrWait = value;
			if (_tmrWait != null)
			{
				_tmrWait.add_Tick((EventHandler)tmrWait_Tick);
			}
		}
	}

	internal virtual GroupBox fraOptions
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraOptions;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraOptions = value;
		}
	}

	internal virtual Label lblAdWatch
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAdWatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAdWatch = value;
		}
	}

	internal virtual TextBox txtCheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_txtCheck != null)
			{
				((Control)_txtCheck).remove_TextChanged((EventHandler)txtCheck_TextChanged);
			}
			_txtCheck = value;
			if (_txtCheck != null)
			{
				((Control)_txtCheck).add_TextChanged((EventHandler)txtCheck_TextChanged);
			}
		}
	}

	internal virtual Label lblCheck
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCheck;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCheck = value;
		}
	}

	internal virtual TextBox txtWait
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtWait;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtWait = value;
		}
	}

	internal virtual CheckBox chkAds
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkAds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkAds = value;
		}
	}

	internal virtual Label lblCash
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCash;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCash = value;
		}
	}

	internal virtual Label lblTimerCount
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTimerCount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTimerCount = value;
		}
	}

	internal virtual Label lblCashAmount
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCashAmount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCashAmount = value;
		}
	}

	internal virtual Label lblTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTime = value;
		}
	}

	internal virtual ListBox lstAds
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstAds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lstAds = value;
		}
	}

	internal virtual Label lblAdsClicked
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAdsClicked;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAdsClicked = value;
		}
	}

	internal virtual MenuStrip mnu
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnu = value;
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

	internal virtual ToolStripMenuItem mnuExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_mnuExit != null)
			{
				((ToolStripItem)_mnuExit).remove_Click((EventHandler)mnuExit_Click);
			}
			_mnuExit = value;
			if (_mnuExit != null)
			{
				((ToolStripItem)_mnuExit).add_Click((EventHandler)mnuExit_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem mnuAbout
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_mnuAbout != null)
			{
				((ToolStripItem)_mnuAbout).remove_Click((EventHandler)mnuAbout_Click);
			}
			_mnuAbout = value;
			if (_mnuAbout != null)
			{
				((ToolStripItem)_mnuAbout).add_Click((EventHandler)mnuAbout_Click);
			}
		}
	}

	internal virtual ToolStripMenuItem mnuSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_mnuSave != null)
			{
				((ToolStripItem)_mnuSave).remove_Click((EventHandler)mnuSave_Click);
			}
			_mnuSave = value;
			if (_mnuSave != null)
			{
				((ToolStripItem)_mnuSave).add_Click((EventHandler)mnuSave_Click);
			}
		}
	}

	internal virtual CheckBox chkAuto
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkAuto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkAuto = value;
		}
	}

	internal virtual ToolTip ToolTip
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolTip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolTip = value;
		}
	}

	internal virtual Label lblC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblC = value;
		}
	}

	internal virtual Label lblTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTR = value;
		}
	}

	internal virtual Label lblRC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRC = value;
		}
	}

	internal virtual Label lblNC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNC = value;
		}
	}

	internal virtual Label lblNTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNTR = value;
		}
	}

	internal virtual Label lblNRC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNRC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNRC = value;
		}
	}

	internal virtual CheckBox chkStartup
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkStartup;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_chkStartup != null)
			{
				_chkStartup.remove_CheckedChanged((EventHandler)chkStartup_CheckedChanged);
			}
			_chkStartup = value;
			if (_chkStartup != null)
			{
				_chkStartup.add_CheckedChanged((EventHandler)chkStartup_CheckedChanged);
			}
		}
	}

	internal virtual StatusStrip StatusStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _StatusStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_StatusStrip1 = value;
		}
	}

	internal virtual ToolStripStatusLabel lblRunningTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRunningTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRunningTime = value;
		}
	}

	internal virtual ToolStripStatusLabel lblRT
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRT;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRT = value;
		}
	}

	internal virtual ToolStripStatusLabel ToolStripStatusLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripStatusLabel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripStatusLabel3 = value;
		}
	}

	internal virtual ToolStripStatusLabel lblBrowser
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBrowser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBrowser = value;
		}
	}

	internal virtual ToolStripStatusLabel lblStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblStatus = value;
		}
	}

	internal virtual Timer tmrTime
	{
		[DebuggerNonUserCode]
		get
		{
			return _tmrTime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_tmrTime != null)
			{
				_tmrTime.remove_Tick((EventHandler)tmrTime_Tick);
			}
			_tmrTime = value;
			if (_tmrTime != null)
			{
				_tmrTime.add_Tick((EventHandler)tmrTime_Tick);
			}
		}
	}

	internal virtual WebBrowser wb1
	{
		[DebuggerNonUserCode]
		get
		{
			return _wb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_wb1 = value;
		}
	}

	internal virtual WebBrowser wb
	{
		[DebuggerNonUserCode]
		get
		{
			return _wb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			if (_wb != null)
			{
				_wb.remove_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted));
			}
			_wb = value;
			if (_wb != null)
			{
				_wb.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted));
			}
		}
	}

	public frmMain()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		bStop = false;
		counter = 0;
		bDone = false;
		bNext = false;
		InitializeComponent();
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fb: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		nid = new NotifyIcon(components);
		lbl1 = new Label();
		lbl2 = new Label();
		lbl3 = new Label();
		lblInstructions = new Label();
		cmdStart = new Button();
		cmdStop = new Button();
		cmdHide = new Button();
		tmr = new Timer(components);
		tmrWait = new Timer(components);
		fraOptions = new GroupBox();
		chkAuto = new CheckBox();
		lblAdWatch = new Label();
		txtCheck = new TextBox();
		lblCheck = new Label();
		txtWait = new TextBox();
		chkAds = new CheckBox();
		chkStartup = new CheckBox();
		lblCash = new Label();
		lblTimerCount = new Label();
		lblCashAmount = new Label();
		lblTime = new Label();
		lstAds = new ListBox();
		lblAdsClicked = new Label();
		mnu = new MenuStrip();
		FileToolStripMenuItem = new ToolStripMenuItem();
		mnuSave = new ToolStripMenuItem();
		mnuExit = new ToolStripMenuItem();
		mnuAbout = new ToolStripMenuItem();
		ToolTip = new ToolTip(components);
		lblC = new Label();
		lblTR = new Label();
		lblRC = new Label();
		lblNC = new Label();
		lblNTR = new Label();
		lblNRC = new Label();
		StatusStrip1 = new StatusStrip();
		lblRunningTime = new ToolStripStatusLabel();
		lblRT = new ToolStripStatusLabel();
		ToolStripStatusLabel3 = new ToolStripStatusLabel();
		lblBrowser = new ToolStripStatusLabel();
		lblStatus = new ToolStripStatusLabel();
		tmrTime = new Timer(components);
		wb1 = new WebBrowser();
		wb = new WebBrowser();
		((Control)fraOptions).SuspendLayout();
		((Control)mnu).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		nid.set_Icon((Icon)componentResourceManager.GetObject("nid.Icon"));
		nid.set_Text("NotifyIcon1");
		lbl1.set_AutoSize(true);
		Label obj = lbl1;
		Point location = new Point(3, 49);
		((Control)obj).set_Location(location);
		((Control)lbl1).set_Name("lbl1");
		Label obj2 = lbl1;
		Size size = new Size(90, 13);
		((Control)obj2).set_Size(size);
		((Control)lbl1).set_TabIndex(1);
		lbl1.set_Text("1. Login to Adbux");
		lbl2.set_AutoSize(true);
		Label obj3 = lbl2;
		location = new Point(3, 62);
		((Control)obj3).set_Location(location);
		((Control)lbl2).set_Name("lbl2");
		Label obj4 = lbl2;
		size = new Size(74, 13);
		((Control)obj4).set_Size(size);
		((Control)lbl2).set_TabIndex(2);
		lbl2.set_Text("2. Set Options");
		lbl3.set_AutoSize(true);
		Label obj5 = lbl3;
		location = new Point(3, 75);
		((Control)obj5).set_Location(location);
		((Control)lbl3).set_Name("lbl3");
		Label obj6 = lbl3;
		size = new Size(70, 13);
		((Control)obj6).set_Size(size);
		((Control)lbl3).set_TabIndex(3);
		lbl3.set_Text("3. Click Start ");
		lblInstructions.set_AutoSize(true);
		((Control)lblInstructions).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		Label obj7 = lblInstructions;
		location = new Point(7, 27);
		((Control)obj7).set_Location(location);
		((Control)lblInstructions).set_Name("lblInstructions");
		Label obj8 = lblInstructions;
		size = new Size(86, 16);
		((Control)obj8).set_Size(size);
		((Control)lblInstructions).set_TabIndex(4);
		lblInstructions.set_Text("Instructions");
		Button obj9 = cmdStart;
		location = new Point(97, 27);
		((Control)obj9).set_Location(location);
		((Control)cmdStart).set_Name("cmdStart");
		Button obj10 = cmdStart;
		size = new Size(72, 32);
		((Control)obj10).set_Size(size);
		((Control)cmdStart).set_TabIndex(5);
		((ButtonBase)cmdStart).set_Text("Start");
		((ButtonBase)cmdStart).set_UseVisualStyleBackColor(true);
		((Control)cmdStop).set_Enabled(false);
		Button obj11 = cmdStop;
		location = new Point(97, 62);
		((Control)obj11).set_Location(location);
		((Control)cmdStop).set_Name("cmdStop");
		Button obj12 = cmdStop;
		size = new Size(72, 32);
		((Control)obj12).set_Size(size);
		((Control)cmdStop).set_TabIndex(6);
		((ButtonBase)cmdStop).set_Text("Stop");
		((ButtonBase)cmdStop).set_UseVisualStyleBackColor(true);
		Button obj13 = cmdHide;
		location = new Point(97, 97);
		((Control)obj13).set_Location(location);
		((Control)cmdHide).set_Name("cmdHide");
		Button obj14 = cmdHide;
		size = new Size(72, 32);
		((Control)obj14).set_Size(size);
		((Control)cmdHide).set_TabIndex(7);
		((ButtonBase)cmdHide).set_Text("Hide");
		((ButtonBase)cmdHide).set_UseVisualStyleBackColor(true);
		((Control)fraOptions).get_Controls().Add((Control)(object)chkAuto);
		((Control)fraOptions).get_Controls().Add((Control)(object)lblAdWatch);
		((Control)fraOptions).get_Controls().Add((Control)(object)txtCheck);
		((Control)fraOptions).get_Controls().Add((Control)(object)lblCheck);
		((Control)fraOptions).get_Controls().Add((Control)(object)txtWait);
		((Control)fraOptions).get_Controls().Add((Control)(object)chkAds);
		((Control)fraOptions).get_Controls().Add((Control)(object)chkStartup);
		GroupBox obj15 = fraOptions;
		location = new Point(6, 277);
		((Control)obj15).set_Location(location);
		((Control)fraOptions).set_Name("fraOptions");
		GroupBox obj16 = fraOptions;
		size = new Size(162, 104);
		((Control)obj16).set_Size(size);
		((Control)fraOptions).set_TabIndex(8);
		fraOptions.set_TabStop(false);
		fraOptions.set_Text("Options");
		((ButtonBase)chkAuto).set_AutoSize(true);
		CheckBox obj17 = chkAuto;
		location = new Point(9, 52);
		((Control)obj17).set_Location(location);
		((Control)chkAuto).set_Name("chkAuto");
		CheckBox obj18 = chkAuto;
		size = new Size(99, 17);
		((Control)obj18).set_Size(size);
		((Control)chkAuto).set_TabIndex(5);
		((ButtonBase)chkAuto).set_Text("Auto Ad Watch");
		ToolTip.SetToolTip((Control)(object)chkAuto, "This function will override your Ad Watch Time.\r\nWill automatically move to the next ad after you have received the credit.");
		((ButtonBase)chkAuto).set_UseVisualStyleBackColor(true);
		lblAdWatch.set_AutoSize(true);
		Label obj19 = lblAdWatch;
		location = new Point(6, 36);
		((Control)obj19).set_Location(location);
		((Control)lblAdWatch).set_Name("lblAdWatch");
		Label obj20 = lblAdWatch;
		size = new Size(98, 13);
		((Control)obj20).set_Size(size);
		((Control)lblAdWatch).set_TabIndex(4);
		lblAdWatch.set_Text("Ad Watch Time (s):");
		TextBox obj21 = txtCheck;
		location = new Point(78, 13);
		((Control)obj21).set_Location(location);
		((Control)txtCheck).set_Name("txtCheck");
		TextBox obj22 = txtCheck;
		size = new Size(27, 20);
		((Control)obj22).set_Size(size);
		((Control)txtCheck).set_TabIndex(1);
		txtCheck.set_Text("10");
		txtCheck.set_TextAlign((HorizontalAlignment)2);
		lblCheck.set_AutoSize(true);
		Label obj23 = lblCheck;
		location = new Point(6, 16);
		((Control)obj23).set_Location(location);
		((Control)lblCheck).set_Name("lblCheck");
		Label obj24 = lblCheck;
		size = new Size(73, 13);
		((Control)obj24).set_Size(size);
		((Control)lblCheck).set_TabIndex(3);
		lblCheck.set_Text("Refresh Rate:");
		TextBox obj25 = txtWait;
		location = new Point(105, 33);
		((Control)obj25).set_Location(location);
		((Control)txtWait).set_Name("txtWait");
		TextBox obj26 = txtWait;
		size = new Size(26, 20);
		((Control)obj26).set_Size(size);
		((Control)txtWait).set_TabIndex(2);
		txtWait.set_Text("40");
		txtWait.set_TextAlign((HorizontalAlignment)2);
		((ButtonBase)chkAds).set_AutoSize(true);
		CheckBox obj27 = chkAds;
		location = new Point(9, 68);
		((Control)obj27).set_Location(location);
		((Control)chkAds).set_Name("chkAds");
		CheckBox obj28 = chkAds;
		size = new Size(144, 17);
		((Control)obj28).set_Size(size);
		((Control)chkAds).set_TabIndex(0);
		((ButtonBase)chkAds).set_Text("Display Total Ads In Tray");
		((ButtonBase)chkAds).set_UseVisualStyleBackColor(true);
		((ButtonBase)chkStartup).set_AutoSize(true);
		((ButtonBase)chkStartup).set_BackColor(Color.Transparent);
		CheckBox obj29 = chkStartup;
		location = new Point(9, 87);
		((Control)obj29).set_Location(location);
		((Control)chkStartup).set_Name("chkStartup");
		CheckBox obj30 = chkStartup;
		size = new Size(102, 17);
		((Control)obj30).set_Size(size);
		((Control)chkStartup).set_TabIndex(6);
		((ButtonBase)chkStartup).set_Text("Load on Startup");
		((ButtonBase)chkStartup).set_UseVisualStyleBackColor(false);
		lblCash.set_AutoSize(true);
		Label obj31 = lblCash;
		location = new Point(4, 239);
		((Control)obj31).set_Location(location);
		((Control)lblCash).set_Name("lblCash");
		Label obj32 = lblCash;
		size = new Size(61, 13);
		((Control)obj32).set_Size(size);
		((Control)lblCash).set_TabIndex(9);
		lblCash.set_Text("Total Cash:");
		lblTimerCount.set_AutoSize(true);
		Label obj33 = lblTimerCount;
		location = new Point(4, 261);
		((Control)obj33).set_Location(location);
		((Control)lblTimerCount).set_Name("lblTimerCount");
		Label obj34 = lblTimerCount;
		size = new Size(93, 13);
		((Control)obj34).set_Size(size);
		((Control)lblTimerCount).set_TabIndex(10);
		lblTimerCount.set_Text("Timer Count (sec):");
		lblCashAmount.set_AutoSize(true);
		lblCashAmount.set_BorderStyle((BorderStyle)2);
		Label obj35 = lblCashAmount;
		location = new Point(113, 237);
		((Control)obj35).set_Location(location);
		((Control)lblCashAmount).set_Name("lblCashAmount");
		Label obj36 = lblCashAmount;
		size = new Size(36, 15);
		((Control)obj36).set_Size(size);
		((Control)lblCashAmount).set_TabIndex(11);
		lblCashAmount.set_Text("$0.00");
		lblTime.set_AutoSize(true);
		Label obj37 = lblTime;
		location = new Point(110, 261);
		((Control)obj37).set_Location(location);
		((Control)lblTime).set_Name("lblTime");
		Label obj38 = lblTime;
		size = new Size(36, 13);
		((Control)obj38).set_Size(size);
		((Control)lblTime).set_TabIndex(12);
		lblTime.set_Text("0 / 10");
		((ListControl)lstAds).set_FormattingEnabled(true);
		ListBox obj39 = lstAds;
		location = new Point(10, 133);
		((Control)obj39).set_Location(location);
		((Control)lstAds).set_Name("lstAds");
		ListBox obj40 = lstAds;
		size = new Size(159, 56);
		((Control)obj40).set_Size(size);
		((Control)lstAds).set_TabIndex(13);
		Label obj41 = lblAdsClicked;
		location = new Point(7, 114);
		((Control)obj41).set_Location(location);
		((Control)lblAdsClicked).set_Name("lblAdsClicked");
		Label obj42 = lblAdsClicked;
		size = new Size(79, 18);
		((Control)obj42).set_Size(size);
		((Control)lblAdsClicked).set_TabIndex(14);
		lblAdsClicked.set_Text("0 Ads Clicked");
		lblAdsClicked.set_TextAlign((ContentAlignment)2);
		((ToolStrip)mnu).set_BackColor(SystemColors.Control);
		((ToolStrip)mnu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)mnuAbout
		});
		MenuStrip obj43 = mnu;
		location = new Point(0, 0);
		((Control)obj43).set_Location(location);
		((Control)mnu).set_Name("mnu");
		MenuStrip obj44 = mnu;
		size = new Size(606, 24);
		((Control)obj44).set_Size(size);
		((Control)mnu).set_TabIndex(15);
		((Control)mnu).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)mnuSave,
			(ToolStripItem)mnuExit
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		ToolStripMenuItem fileToolStripMenuItem = FileToolStripMenuItem;
		size = new Size(35, 20);
		((ToolStripItem)fileToolStripMenuItem).set_Size(size);
		((ToolStripItem)FileToolStripMenuItem).set_Text("&File");
		((ToolStripItem)mnuSave).set_Name("mnuSave");
		ToolStripMenuItem obj45 = mnuSave;
		size = new Size(151, 22);
		((ToolStripItem)obj45).set_Size(size);
		((ToolStripItem)mnuSave).set_Text("Save Settings");
		((ToolStripItem)mnuExit).set_Name("mnuExit");
		ToolStripMenuItem obj46 = mnuExit;
		size = new Size(151, 22);
		((ToolStripItem)obj46).set_Size(size);
		((ToolStripItem)mnuExit).set_Text("E&xit");
		((ToolStripItem)mnuAbout).set_Name("mnuAbout");
		ToolStripMenuItem obj47 = mnuAbout;
		size = new Size(48, 20);
		((ToolStripItem)obj47).set_Size(size);
		((ToolStripItem)mnuAbout).set_Text("About");
		lblC.set_AutoSize(true);
		Label obj48 = lblC;
		location = new Point(4, 192);
		((Control)obj48).set_Location(location);
		((Control)lblC).set_Name("lblC");
		Label obj49 = lblC;
		size = new Size(62, 13);
		((Control)obj49).set_Size(size);
		((Control)lblC).set_TabIndex(18);
		lblC.set_Text("# Of Clicks:");
		lblTR.set_AutoSize(true);
		Label obj50 = lblTR;
		location = new Point(4, 207);
		((Control)obj50).set_Location(location);
		((Control)lblTR).set_Name("lblTR");
		Label obj51 = lblTR;
		size = new Size(103, 13);
		((Control)obj51).set_Size(size);
		((Control)lblTR).set_TabIndex(19);
		lblTR.set_Text("# Of Total Referrals:");
		lblRC.set_AutoSize(true);
		Label obj52 = lblRC;
		location = new Point(4, 222);
		((Control)obj52).set_Location(location);
		((Control)lblRC).set_Name("lblRC");
		Label obj53 = lblRC;
		size = new Size(100, 13);
		((Control)obj53).set_Size(size);
		((Control)lblRC).set_TabIndex(20);
		lblRC.set_Text("# of Referral Clicks:");
		lblNC.set_AutoSize(true);
		lblNC.set_BorderStyle((BorderStyle)2);
		Label obj54 = lblNC;
		location = new Point(113, 192);
		((Control)obj54).set_Location(location);
		((Control)lblNC).set_Name("lblNC");
		Label obj55 = lblNC;
		size = new Size(15, 15);
		((Control)obj55).set_Size(size);
		((Control)lblNC).set_TabIndex(21);
		lblNC.set_Text("0");
		lblNTR.set_AutoSize(true);
		lblNTR.set_BorderStyle((BorderStyle)2);
		Label obj56 = lblNTR;
		location = new Point(113, 207);
		((Control)obj56).set_Location(location);
		((Control)lblNTR).set_Name("lblNTR");
		Label obj57 = lblNTR;
		size = new Size(15, 15);
		((Control)obj57).set_Size(size);
		((Control)lblNTR).set_TabIndex(22);
		lblNTR.set_Text("0");
		lblNRC.set_AutoSize(true);
		lblNRC.set_BorderStyle((BorderStyle)2);
		Label obj58 = lblNRC;
		location = new Point(113, 222);
		((Control)obj58).set_Location(location);
		((Control)lblNRC).set_Name("lblNRC");
		Label obj59 = lblNRC;
		size = new Size(15, 15);
		((Control)obj59).set_Size(size);
		((Control)lblNRC).set_TabIndex(23);
		lblNRC.set_Text("0");
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)lblRunningTime,
			(ToolStripItem)lblRT,
			(ToolStripItem)ToolStripStatusLabel3,
			(ToolStripItem)lblBrowser,
			(ToolStripItem)lblStatus
		});
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 392);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(606, 22);
		((Control)statusStrip2).set_Size(size);
		StatusStrip1.set_SizingGrip(false);
		StatusStrip1.set_Stretch(false);
		((Control)StatusStrip1).set_TabIndex(24);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)lblRunningTime).set_Name("lblRunningTime");
		ToolStripStatusLabel obj60 = lblRunningTime;
		size = new Size(75, 17);
		((ToolStripItem)obj60).set_Size(size);
		((ToolStripItem)lblRunningTime).set_Text("Running Time:");
		((ToolStripItem)lblRT).set_Name("lblRT");
		ToolStripStatusLabel obj61 = lblRT;
		size = new Size(33, 17);
		((ToolStripItem)obj61).set_Size(size);
		((ToolStripItem)lblRT).set_Text("0:0:0");
		((ToolStripItem)ToolStripStatusLabel3).set_Name("ToolStripStatusLabel3");
		ToolStripStatusLabel toolStripStatusLabel = ToolStripStatusLabel3;
		size = new Size(11, 17);
		((ToolStripItem)toolStripStatusLabel).set_Size(size);
		((ToolStripItem)ToolStripStatusLabel3).set_Text("|");
		((ToolStripItem)lblBrowser).set_Name("lblBrowser");
		ToolStripStatusLabel obj62 = lblBrowser;
		size = new Size(84, 17);
		((ToolStripItem)obj62).set_Size(size);
		((ToolStripItem)lblBrowser).set_Text("Browser Status:");
		((ToolStripItem)lblStatus).set_Name("lblStatus");
		ToolStripStatusLabel obj63 = lblStatus;
		size = new Size(95, 17);
		((ToolStripItem)obj63).set_Size(size);
		((ToolStripItem)lblStatus).set_Text("Waiting to Start...");
		tmrTime.set_Interval(1000);
		WebBrowser obj64 = wb1;
		location = new Point(516, 27);
		((Control)obj64).set_Location(location);
		WebBrowser obj65 = wb1;
		size = new Size(20, 20);
		((Control)obj65).set_MinimumSize(size);
		((Control)wb1).set_Name("wb1");
		wb1.set_ScriptErrorsSuppressed(true);
		WebBrowser obj66 = wb1;
		size = new Size(87, 354);
		((Control)obj66).set_Size(size);
		((Control)wb1).set_TabIndex(25);
		((Control)wb1).set_Visible(false);
		WebBrowser obj67 = wb;
		location = new Point(180, 27);
		((Control)obj67).set_Location(location);
		WebBrowser obj68 = wb;
		size = new Size(20, 20);
		((Control)obj68).set_MinimumSize(size);
		((Control)wb).set_Name("wb");
		wb.set_ScriptErrorsSuppressed(true);
		WebBrowser obj69 = wb;
		size = new Size(423, 362);
		((Control)obj69).set_Size(size);
		((Control)wb).set_TabIndex(26);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(606, 414);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)wb);
		((Control)this).get_Controls().Add((Control)(object)wb1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)lblNRC);
		((Control)this).get_Controls().Add((Control)(object)lblNTR);
		((Control)this).get_Controls().Add((Control)(object)lblNC);
		((Control)this).get_Controls().Add((Control)(object)lblRC);
		((Control)this).get_Controls().Add((Control)(object)lblTR);
		((Control)this).get_Controls().Add((Control)(object)lblC);
		((Control)this).get_Controls().Add((Control)(object)fraOptions);
		((Control)this).get_Controls().Add((Control)(object)lstAds);
		((Control)this).get_Controls().Add((Control)(object)lblAdsClicked);
		((Control)this).get_Controls().Add((Control)(object)lblTime);
		((Control)this).get_Controls().Add((Control)(object)lblCashAmount);
		((Control)this).get_Controls().Add((Control)(object)lblTimerCount);
		((Control)this).get_Controls().Add((Control)(object)lblCash);
		((Control)this).get_Controls().Add((Control)(object)cmdHide);
		((Control)this).get_Controls().Add((Control)(object)cmdStop);
		((Control)this).get_Controls().Add((Control)(object)cmdStart);
		((Control)this).get_Controls().Add((Control)(object)lblInstructions);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)mnu);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(mnu);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Adbux Auto Clicker [1.2.1]");
		((Control)fraOptions).ResumeLayout(false);
		((Control)fraOptions).PerformLayout();
		((Control)mnu).ResumeLayout(false);
		((Control)mnu).PerformLayout();
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(int hwnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		Save();
		ProjectData.EndApp();
	}

	public void Save()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected I4, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected I4, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected I4, but got Unknown
		StreamWriter streamWriter = File.CreateText("adbux-settings.ini");
		streamWriter.WriteLine(lblCashAmount.get_Text());
		streamWriter.WriteLine(txtCheck.get_Text());
		streamWriter.WriteLine(txtWait.get_Text());
		streamWriter.WriteLine((int)chkAuto.get_CheckState());
		streamWriter.WriteLine((int)chkAds.get_CheckState());
		streamWriter.WriteLine((int)chkStartup.get_CheckState());
		streamWriter.Close();
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		if (File.Exists("adbux-settings.ini"))
		{
			StreamReader streamReader = File.OpenText("adbux-settings.ini");
			lblCashAmount.set_Text(streamReader.ReadLine());
			txtCheck.set_Text(streamReader.ReadLine());
			txtWait.set_Text(streamReader.ReadLine());
			chkAuto.set_CheckState((CheckState)Conversions.ToInteger(streamReader.ReadLine()));
			chkAds.set_CheckState((CheckState)Conversions.ToInteger(streamReader.ReadLine()));
			chkStartup.set_CheckState((CheckState)Conversions.ToInteger(streamReader.ReadLine()));
			streamReader.Close();
		}
		Application.DoEvents();
		wb.Navigate("http://adbux.org/stats.php");
		wb1.Navigate("http://www.mlwares.co.nr");
	}

	private void mnuExit_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got Unknown
		string text = Conversions.ToString((int)Interaction.MsgBox((object)"Are you sure you want to exit?", (MsgBoxStyle)4, (object)"Adbux Auto Clicker"));
		if (Conversions.ToDouble(text) == 6.0)
		{
			wb.Stop();
			tmrWait.set_Enabled(false);
			tmr.set_Enabled(false);
			Save();
			ProjectData.EndApp();
		}
	}

	private void txtCheck_TextChanged(object sender, EventArgs e)
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
				case 144:
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
							goto IL_0023;
						case 5:
							goto IL_003a;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
						case 7:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_003a:
					num = 5;
					break;
					IL_0023:
					num = 3;
					lblTime.set_Text("0 / 0");
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					if (Operators.CompareString(txtCheck.get_Text(), "", false) == 0)
					{
						goto IL_0023;
					}
					goto IL_003a;
					end_IL_0000_2:
					break;
				}
				num = 6;
				lblTime.set_Text("0 / " + txtCheck.get_Text());
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 144;
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

	private void cmdHide_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		((Control)this).Hide();
		nid.set_Text("Adbux Auto Clicker\0");
		if ((int)chkAds.get_CheckState() == 1)
		{
			nid.set_Text("Adbux Auto Clicker\r\nTotal Ads Clicked: " + Conversions.ToString(lstAds.get_Items().get_Count()) + "\0");
		}
		nid.set_Visible(true);
	}

	private void nid_DoubleClick(object sender, EventArgs e)
	{
		((Control)this).Show();
		nid.set_Visible(false);
	}

	private void cmdStop_Click(object sender, EventArgs e)
	{
		bStop = true;
		tmrTime.set_Enabled(false);
		((Control)cmdStop).set_Enabled(false);
		((Control)cmdStart).set_Enabled(true);
		((Control)txtCheck).set_Enabled(true);
		((Control)txtWait).set_Enabled(true);
		wb.Stop();
		bDone = true;
		((ToolStripItem)lblStatus).set_Text("Stopped.");
	}

	private void cmdStart_Click(object sender, EventArgs e)
	{
		tmrTime.set_Enabled(true);
		counter = 0;
		bDone = false;
		bStop = false;
		((Control)cmdStop).set_Enabled(true);
		((Control)cmdStart).set_Enabled(false);
		((Control)txtCheck).set_Enabled(false);
		((Control)txtWait).set_Enabled(false);
		GetStats();
	}

	public void GetStats()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string outerHtml = default(string);
		long num5 = default(long);
		long num6 = default(long);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 951:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0013;
							case 4:
								goto IL_001d;
							case 5:
								goto IL_0027;
							case 6:
								goto IL_003a;
							case 9:
								goto IL_004f;
							case 7:
							case 8:
							case 10:
								goto IL_0058;
							case 11:
								goto IL_0079;
							case 12:
								goto IL_0085;
							case 13:
								goto IL_0095;
							case 14:
								goto IL_00a5;
							case 15:
								goto IL_00b0;
							case 17:
							case 18:
								goto IL_00c0;
							case 19:
								goto IL_00d4;
							case 20:
								goto IL_00ee;
							case 21:
								goto IL_00fc;
							case 22:
								goto IL_011b;
							case 23:
								goto IL_0131;
							case 24:
								goto IL_0145;
							case 25:
								goto IL_0156;
							case 26:
								goto IL_016b;
							case 27:
								goto IL_018a;
							case 28:
								goto IL_01a0;
							case 29:
								goto IL_01b4;
							case 30:
								goto IL_01c5;
							case 31:
								goto IL_01da;
							case 32:
								goto IL_01f9;
							case 33:
								goto IL_020f;
							case 34:
								goto IL_0223;
							case 35:
								goto IL_0234;
							case 36:
								goto IL_0249;
							case 37:
								goto IL_0268;
							case 38:
								goto IL_027e;
							case 39:
								goto IL_0292;
							case 40:
								goto IL_02a3;
							case 41:
								goto IL_02b8;
							case 42:
								goto IL_02cc;
							case 43:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 16:
							case 44:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_004f:
						num = 9;
						Application.DoEvents();
						goto IL_0058;
						IL_02cc:
						num = 42;
						tmr.set_Interval(1000);
						break;
						IL_0009:
						num = 2;
						counter = 0;
						goto IL_0013;
						IL_0013:
						num = 3;
						bDone = false;
						goto IL_001d;
						IL_001d:
						num = 4;
						bStop = false;
						goto IL_0027;
						IL_0027:
						num = 5;
						((ToolStripItem)lblStatus).set_Text("Going to stats");
						goto IL_003a;
						IL_003a:
						num = 6;
						wb.Navigate("http://adbux.org/stats.php");
						goto IL_0058;
						IL_0058:
						num = 8;
						if (!(((unchecked((int)wb.get_ReadyState()) == 4) & bDone) | bStop))
						{
							goto IL_004f;
						}
						goto IL_0079;
						IL_0079:
						num = 11;
						if (bStop)
						{
							goto IL_0085;
						}
						goto IL_00c0;
						IL_0085:
						num = 12;
						tmrWait.set_Enabled(false);
						goto IL_0095;
						IL_0095:
						num = 13;
						tmr.set_Enabled(false);
						goto IL_00a5;
						IL_00a5:
						num = 14;
						bDone = false;
						goto IL_00b0;
						IL_00b0:
						num = 15;
						counter = 0;
						goto end_IL_0000_3;
						IL_00c0:
						num = 18;
						((ToolStripItem)lblStatus).set_Text("Getting stats");
						goto IL_00d4;
						IL_00d4:
						num = 19;
						outerHtml = wb.get_Document().get_Body().get_OuterHtml();
						goto IL_00ee;
						IL_00ee:
						num = 20;
						num5 = 1L;
						goto IL_00fc;
						IL_00fc:
						num = 21;
						num5 = Strings.InStr((int)num5, outerHtml, "# of Clicks", (CompareMethod)1) + Strings.Len("# of Clicks");
						goto IL_011b;
						IL_011b:
						num = 22;
						num5 = Strings.InStr((int)num5, outerHtml, "<strong>", (CompareMethod)1) + 8;
						goto IL_0131;
						IL_0131:
						num = 23;
						num6 = Strings.InStr((int)num5, outerHtml, "</strong>", (CompareMethod)1);
						goto IL_0145;
						IL_0145:
						num = 24;
						text = Strings.Mid(outerHtml, (int)num5, (int)(num6 - num5));
						goto IL_0156;
						IL_0156:
						num = 25;
						lblNC.set_Text(Strings.Trim(text));
						goto IL_016b;
						IL_016b:
						num = 26;
						num5 = Strings.InStr((int)num5, outerHtml, "# of Total Referrals", (CompareMethod)1) + Strings.Len("# of Total Referrals");
						goto IL_018a;
						IL_018a:
						num = 27;
						num5 = Strings.InStr((int)num5, outerHtml, "<strong>", (CompareMethod)1) + 8;
						goto IL_01a0;
						IL_01a0:
						num = 28;
						num6 = Strings.InStr((int)num5, outerHtml, "</strong>", (CompareMethod)1);
						goto IL_01b4;
						IL_01b4:
						num = 29;
						text = Strings.Mid(outerHtml, (int)num5, (int)(num6 - num5));
						goto IL_01c5;
						IL_01c5:
						num = 30;
						lblNTR.set_Text(Strings.Trim(text));
						goto IL_01da;
						IL_01da:
						num = 31;
						num5 = Strings.InStr((int)num5, outerHtml, "# of Referral Clicks", (CompareMethod)1) + Strings.Len("# of Referral Clicks");
						goto IL_01f9;
						IL_01f9:
						num = 32;
						num5 = Strings.InStr((int)num5, outerHtml, "<strong>", (CompareMethod)1) + 8;
						goto IL_020f;
						IL_020f:
						num = 33;
						num6 = Strings.InStr((int)num5, outerHtml, "</strong>", (CompareMethod)1);
						goto IL_0223;
						IL_0223:
						num = 34;
						text = Strings.Mid(outerHtml, (int)num5, (int)(num6 - num5));
						goto IL_0234;
						IL_0234:
						num = 35;
						lblNRC.set_Text(Strings.Trim(text));
						goto IL_0249;
						IL_0249:
						num = 36;
						num5 = Strings.InStr((int)num5, outerHtml, "Total Balance", (CompareMethod)1) + Strings.Len("Total Balance");
						goto IL_0268;
						IL_0268:
						num = 37;
						num5 = Strings.InStr((int)num5, outerHtml, "<strong>", (CompareMethod)1) + 8;
						goto IL_027e;
						IL_027e:
						num = 38;
						num6 = Strings.InStr((int)num5, outerHtml, "</strong>", (CompareMethod)1);
						goto IL_0292;
						IL_0292:
						num = 39;
						text = Strings.Mid(outerHtml, (int)num5, (int)(num6 - num5));
						goto IL_02a3;
						IL_02a3:
						num = 40;
						lblCashAmount.set_Text(Strings.Trim(text));
						goto IL_02b8;
						IL_02b8:
						num = 41;
						((ToolStripItem)lblStatus).set_Text("Waiting...");
						goto IL_02cc;
						end_IL_0000_2:
						break;
					}
					num = 43;
					tmr.set_Enabled(true);
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 951;
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

	private void tmr_Tick(object sender, EventArgs e)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		if (bStop)
		{
			tmrWait.set_Enabled(false);
			tmr.set_Enabled(false);
			bDone = false;
			counter = 0;
			return;
		}
		checked
		{
			counter++;
			lblTime.set_Text(Conversions.ToString(counter) + " / " + txtCheck.get_Text());
			if (!((double)counter >= Conversions.ToDouble(txtCheck.get_Text())))
			{
				return;
			}
			tmr.set_Enabled(false);
			((ToolStripItem)lblStatus).set_Text("Going to ads");
			wb.Navigate("http://adbux.org/browse.php");
			bDone = false;
			while (!(((unchecked((int)wb.get_ReadyState()) == 4) & bDone) | bStop))
			{
				Application.DoEvents();
			}
			if (bStop)
			{
				tmrWait.set_Enabled(false);
				tmr.set_Enabled(false);
				bDone = false;
				counter = 0;
				return;
			}
			((ToolStripItem)lblStatus).set_Text("Analyzing ads");
			object outerHtml = wb.get_Document().get_Body().get_OuterHtml();
			long num = 1L;
			Ads = "";
			((Control)this).set_Name("");
			int num2 = 0;
			int num3 = 0;
			while (Strings.InStr((int)num, Conversions.ToString(outerHtml), "http://adbux.org/viewad.php?ad=", (CompareMethod)1) != 0)
			{
				num3 = 0;
				num2 = 0;
				num = Strings.InStr((int)num, Conversions.ToString(outerHtml), "http://adbux.org/viewad.php?ad=", (CompareMethod)1) + Strings.Len("http://adbux.org/viewad.php?ad=");
				long num4 = Strings.InStr((int)num, Conversions.ToString(outerHtml), "target", (CompareMethod)1) - 2;
				string ads = Strings.Mid(Conversions.ToString(outerHtml), (int)num, (int)(num4 - num));
				string text = "";
				num2 = (int)(num - Strings.Len("images/check.gif border=0 align=absbottom> <a href=") - 2L - Strings.Len("http://adbux.org/viewad.php?ad="));
				num3 = num2 + Strings.Len("images/check.gif");
				if (Operators.CompareString(Strings.LCase(Strings.Mid(Conversions.ToString(outerHtml), num2, num3 - num2)), "images/check.gif", false) == 0)
				{
					Application.DoEvents();
					continue;
				}
				Ads = ads;
				num = Strings.InStr((int)num, Conversions.ToString(outerHtml), ">", (CompareMethod)1) + 1;
				num4 = Strings.InStr((int)num, Conversions.ToString(outerHtml), "</a></span>", (CompareMethod)1);
				text = (Names = Strings.Mid(Conversions.ToString(outerHtml), (int)num, (int)(num4 - num)));
				break;
			}
			if (Operators.CompareString(Ads, "", false) != 0)
			{
				bNext = true;
				tmrWait.set_Interval(1000);
				tmrWait.set_Enabled(true);
			}
			else
			{
				bNext = false;
				((ToolStripItem)lblStatus).set_Text("Waiting...");
				counter = 0;
				tmr.set_Enabled(true);
			}
		}
	}

	private void tmrWait_Tick(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Invalid comparison between Unknown and I4
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Invalid comparison between Unknown and I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
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
					if (bStop)
					{
						tmrWait.set_Enabled(false);
						tmr.set_Enabled(false);
						bDone = false;
						counter = 0;
						goto end_IL_0000;
					}
					tmrWait.set_Enabled(false);
					if (Operators.CompareString(Ads, "", false) != 0)
					{
						Ads = Strings.Trim(Ads);
						((ToolStripItem)lblStatus).set_Text("Navigating to an ad");
						Thread.Sleep(500);
						wb.Navigate("http://adbux.org/viewad.php?ad=" + Strings.Left(Ads, Strings.Len(Ads)));
						lstAds.get_Items().Add((object)Names);
						lblAdsClicked.set_Text(Conversions.ToString(lstAds.get_Items().get_Count()) + " Ads Clicked");
						if ((int)chkAds.get_CheckState() == 1)
						{
							nid.set_Text("Adbux Auto Clicker\r\nTotal Ads Clicked: " + Conversions.ToString(lstAds.get_Items().get_Count()) + "\0");
						}
						bDone = false;
						while (!((((int)wb.get_ReadyState() == 4) & bDone) | bStop))
						{
							Application.DoEvents();
						}
						((ToolStripItem)lblStatus).set_Text("Waiting at ad");
						if (bStop)
						{
							tmrWait.set_Enabled(false);
							tmr.set_Enabled(false);
							bDone = false;
							counter = 0;
							goto end_IL_0000;
						}
						if ((int)chkAuto.get_CheckState() != 1)
						{
							goto IL_0208;
						}
						ProjectData.ClearProjectError();
						num2 = 2;
						Ads = "";
						string attribute = wb.get_Document().get_All().get_Item("clock")
							.GetAttribute("Value");
						tmrWait.set_Interval(checked((Conversions.ToInteger(attribute) + 5) * 1000));
						tmrWait.set_Enabled(true);
					}
					else if (bNext)
					{
						NextAd();
					}
					else
					{
						((ToolStripItem)lblStatus).set_Text("Waiting...");
						tmrWait.set_Enabled(false);
						counter = 0;
						GetStats();
					}
					goto end_IL_0000_2;
				case 647:
					{
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto end_IL_0000_3;
						}
						goto IL_0208;
					}
					IL_0208:
					Ads = "";
					tmrWait.set_Interval(checked((int)Math.Round(Conversions.ToDouble(txtWait.get_Text()) * 1000.0)));
					tmrWait.set_Enabled(true);
					goto end_IL_0000_2;
					end_IL_0000_3:
					break;
				}
				goto IL_02bd;
				end_IL_0000_2:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 647;
				continue;
			}
			break;
			IL_02bd:
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void NextAd()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		object outerHtml = default(object);
		long num5 = default(long);
		int num6 = default(int);
		int num7 = default(int);
		long num8 = default(long);
		string ads = default(string);
		string names = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 1043:
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
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_0018;
							case 4:
								goto IL_002b;
							case 5:
								goto IL_003e;
							case 8:
								goto IL_004a;
							case 6:
							case 7:
							case 9:
								goto IL_0052;
							case 10:
								goto IL_0073;
							case 11:
								goto IL_007f;
							case 12:
								goto IL_008f;
							case 13:
								goto IL_009f;
							case 14:
								goto IL_00aa;
							case 16:
							case 17:
								goto IL_00ba;
							case 18:
								goto IL_00ce;
							case 19:
								goto IL_00e9;
							case 20:
								goto IL_00f7;
							case 21:
								goto IL_0106;
							case 22:
								goto IL_0115;
							case 23:
								goto IL_011b;
							case 26:
								goto IL_0126;
							case 27:
								goto IL_012c;
							case 28:
								goto IL_0132;
							case 29:
								goto IL_0157;
							case 30:
								goto IL_0173;
							case 31:
								goto IL_018b;
							case 32:
								goto IL_0196;
							case 33:
								goto IL_01bf;
							case 34:
								goto IL_01d0;
							case 41:
							case 42:
								goto IL_01f9;
							case 24:
							case 25:
							case 43:
								goto IL_0202;
							case 35:
								goto IL_0222;
							case 36:
								goto IL_022e;
							case 37:
								goto IL_024a;
							case 38:
								goto IL_0264;
							case 39:
								goto IL_027c;
							case 40:
							case 44:
								goto IL_0288;
							case 45:
								goto IL_02a0;
							case 46:
								goto IL_02ab;
							case 47:
								goto IL_02bf;
							case 49:
								goto IL_02d4;
							case 50:
								goto IL_02d8;
							case 51:
								goto IL_02e3;
							case 52:
								goto IL_02f7;
							case 53:
								goto IL_0307;
							case 54:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 15:
							case 48:
							case 55:
							case 56:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_004a:
						num = 8;
						Application.DoEvents();
						goto IL_0052;
						IL_01f9:
						num = 42;
						Application.DoEvents();
						goto IL_0202;
						IL_0009:
						num = 2;
						tmr.set_Enabled(false);
						goto IL_0018;
						IL_0018:
						num = 3;
						((ToolStripItem)lblStatus).set_Text("Going to ads");
						goto IL_002b;
						IL_002b:
						num = 4;
						wb.Navigate("http://adbux.org/browse.php");
						goto IL_003e;
						IL_003e:
						num = 5;
						bDone = false;
						goto IL_0052;
						IL_0052:
						num = 7;
						if (!(((unchecked((int)wb.get_ReadyState()) == 4) & bDone) | bStop))
						{
							goto IL_004a;
						}
						goto IL_0073;
						IL_0073:
						num = 10;
						if (bStop)
						{
							goto IL_007f;
						}
						goto IL_00ba;
						IL_007f:
						num = 11;
						tmrWait.set_Enabled(false);
						goto IL_008f;
						IL_008f:
						num = 12;
						tmr.set_Enabled(false);
						goto IL_009f;
						IL_009f:
						num = 13;
						bDone = false;
						goto IL_00aa;
						IL_00aa:
						num = 14;
						counter = 0;
						goto end_IL_0000_3;
						IL_00ba:
						num = 17;
						((ToolStripItem)lblStatus).set_Text("Analyzing ads");
						goto IL_00ce;
						IL_00ce:
						num = 18;
						outerHtml = wb.get_Document().get_Body().get_OuterHtml();
						goto IL_00e9;
						IL_00e9:
						num = 19;
						num5 = 1L;
						goto IL_00f7;
						IL_00f7:
						num = 20;
						Ads = "";
						goto IL_0106;
						IL_0106:
						num = 21;
						((Control)this).set_Name("");
						goto IL_0115;
						IL_0115:
						num = 22;
						num6 = 0;
						goto IL_011b;
						IL_011b:
						num = 23;
						num7 = 0;
						goto IL_0202;
						IL_0202:
						num = 25;
						if (Strings.InStr((int)num5, Conversions.ToString(outerHtml), "http://adbux.org/viewad.php?ad=", (CompareMethod)1) != 0)
						{
							goto IL_0126;
						}
						goto IL_0288;
						IL_0126:
						num = 26;
						num7 = 0;
						goto IL_012c;
						IL_012c:
						num = 27;
						num6 = 0;
						goto IL_0132;
						IL_0132:
						num = 28;
						num5 = Strings.InStr((int)num5, Conversions.ToString(outerHtml), "http://adbux.org/viewad.php?ad=", (CompareMethod)1) + Strings.Len("http://adbux.org/viewad.php?ad=");
						goto IL_0157;
						IL_0157:
						num = 29;
						num8 = Strings.InStr((int)num5, Conversions.ToString(outerHtml), "target", (CompareMethod)1) - 2;
						goto IL_0173;
						IL_0173:
						num = 30;
						ads = Strings.Mid(Conversions.ToString(outerHtml), (int)num5, (int)(num8 - num5));
						goto IL_018b;
						IL_018b:
						num = 31;
						names = "";
						goto IL_0196;
						IL_0196:
						num = 32;
						num6 = (int)(num5 - Strings.Len("images/check.gif border=0 align=absbottom> <a href=") - 2L - Strings.Len("http://adbux.org/viewad.php?ad="));
						goto IL_01bf;
						IL_01bf:
						num = 33;
						num7 = num6 + Strings.Len("images/check.gif");
						goto IL_01d0;
						IL_01d0:
						num = 34;
						if (Operators.CompareString(Strings.LCase(Strings.Mid(Conversions.ToString(outerHtml), num6, num7 - num6)), "images/check.gif", false) == 0)
						{
							goto IL_01f9;
						}
						goto IL_0222;
						IL_0222:
						num = 35;
						Ads = ads;
						goto IL_022e;
						IL_022e:
						num = 36;
						num5 = Strings.InStr((int)num5, Conversions.ToString(outerHtml), ">", (CompareMethod)1) + 1;
						goto IL_024a;
						IL_024a:
						num = 37;
						num8 = Strings.InStr((int)num5, Conversions.ToString(outerHtml), "</a></span>", (CompareMethod)1);
						goto IL_0264;
						IL_0264:
						num = 38;
						names = Strings.Mid(Conversions.ToString(outerHtml), (int)num5, (int)(num8 - num5));
						goto IL_027c;
						IL_027c:
						num = 39;
						Names = names;
						goto IL_0288;
						IL_0288:
						num = 44;
						if (Operators.CompareString(Ads, "", false) != 0)
						{
							goto IL_02a0;
						}
						goto IL_02d4;
						IL_02a0:
						num = 45;
						bNext = true;
						goto IL_02ab;
						IL_02ab:
						num = 46;
						tmrWait.set_Interval(1000);
						goto IL_02bf;
						IL_02bf:
						num = 47;
						tmrWait.set_Enabled(true);
						goto end_IL_0000_3;
						IL_02d4:
						num = 49;
						goto IL_02d8;
						IL_02d8:
						num = 50;
						bNext = false;
						goto IL_02e3;
						IL_02e3:
						num = 51;
						((ToolStripItem)lblStatus).set_Text("Waiting...");
						goto IL_02f7;
						IL_02f7:
						num = 52;
						tmrWait.set_Enabled(false);
						goto IL_0307;
						IL_0307:
						num = 53;
						counter = 0;
						break;
						end_IL_0000_2:
						break;
					}
					num = 54;
					GetStats();
					break;
				}
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1043;
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

	private void mnuAbout_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.frmAbout).Show();
	}

	private void mnuSave_Click(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Save();
		Interaction.MsgBox((object)"Successfully saved.", (MsgBoxStyle)64, (object)"Save Settings");
	}

	private void chkStartup_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		RegistryKey currentUser = default(RegistryKey);
		RegistryKey currentUser2 = default(RegistryKey);
		RegistryKey registryKey2 = default(RegistryKey);
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
					goto IL_0009;
				case 204:
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
							goto IL_0009;
						case 3:
							goto IL_001a;
						case 4:
							goto IL_0023;
						case 5:
							goto IL_0033;
						case 7:
							goto IL_004b;
						case 8:
							goto IL_005c;
						case 9:
							goto IL_0065;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 11:
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0065:
					num = 9;
					registryKey = currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					break;
					IL_005c:
					num = 8;
					currentUser = Registry.CurrentUser;
					goto IL_0065;
					IL_0009:
					num = 2;
					if ((int)chkStartup.get_CheckState() == 1)
					{
						goto IL_001a;
					}
					goto IL_004b;
					IL_001a:
					num = 3;
					currentUser2 = Registry.CurrentUser;
					goto IL_0023;
					IL_0023:
					num = 4;
					registryKey2 = currentUser2.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
					goto IL_0033;
					IL_0033:
					num = 5;
					registryKey2.SetValue("Adbux Auto Clicker", Application.get_ExecutablePath());
					goto end_IL_0000_3;
					IL_004b:
					num = 7;
					if ((int)chkStartup.get_CheckState() != 0)
					{
						goto end_IL_0000_3;
					}
					goto IL_005c;
					end_IL_0000_2:
					break;
				}
				num = 10;
				registryKey.DeleteValue("Adbux Auto Clicker");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 204;
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

	private void tmrTime_Tick(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						string[] array = Strings.Split(((ToolStripItem)lblRT).get_Text(), ":", -1, (CompareMethod)0);
						string text = array[0];
						string text2 = array[1];
						string text3 = array[2];
						if (Conversions.ToDouble(text3) == 59.0)
						{
							text2 = Conversions.ToString(Conversions.ToDouble(text2) + 1.0);
							text3 = Conversions.ToString(0);
						}
						else
						{
							text3 = Conversions.ToString(Conversions.ToDouble(text3) + 1.0);
						}
						if (Conversions.ToDouble(text2) == 59.0)
						{
							text = Conversions.ToString(Conversions.ToDouble(text) + 1.0);
							text2 = Conversions.ToString(0);
						}
						((ToolStripItem)lblRT).set_Text(text + ":" + text2 + ":" + text3);
						ProjectData.ClearProjectError();
						num2 = 2;
						Interaction.AppActivate("Windows Internet Explorer");
						long num3 = GetForegroundWindow();
						long num4 = GetWindowTextLengthA((int)num3) + 1;
						string lpString = Strings.Space((int)num4);
						num4 = GetWindowTextA((int)num3, ref lpString, (int)num4);
						if (Operators.CompareString(lpString.Substring(0, (int)num4), "Windows Internet Explorer", false) == 0)
						{
							SendKeys.SendWait("{ENTER}");
						}
						break;
					}
					case 319:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0179;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 319;
				continue;
			}
			break;
			IL_0179:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		bDone = true;
	}
}
