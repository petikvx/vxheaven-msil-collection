using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GetRef_Clicker.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GetRef_Clicker;

[DesignerGenerated]
public class frmMain : Form
{
	private IContainer components;

	[AccessedThroughProperty("nid")]
	private NotifyIcon _nid;

	[AccessedThroughProperty("wb")]
	private WebBrowser _wb;

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

	private bool bStop;

	private int counter;

	private int amount;

	private string[] Ads;

	private int view;

	private bool bDone;

	private bool bAds;

	private string[] strName;

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
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			if (_wb != null)
			{
				_wb.remove_NewWindow((CancelEventHandler)wb_NewWindow);
				_wb.remove_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted));
			}
			_wb = value;
			if (_wb != null)
			{
				_wb.add_NewWindow((CancelEventHandler)wb_NewWindow);
				_wb.add_DocumentCompleted(new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted));
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

	public frmMain()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(frmMain_FormClosing));
		Ads = new string[101];
		strName = new string[101];
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
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
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0d43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		nid = new NotifyIcon(components);
		wb = new WebBrowser();
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
		lblAdWatch = new Label();
		txtCheck = new TextBox();
		lblCheck = new Label();
		txtWait = new TextBox();
		chkAds = new CheckBox();
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
		((Control)fraOptions).SuspendLayout();
		((Control)mnu).SuspendLayout();
		((Control)this).SuspendLayout();
		nid.set_Icon((Icon)componentResourceManager.GetObject("nid.Icon"));
		WebBrowser obj = wb;
		Point location = new Point(5, 146);
		((Control)obj).set_Location(location);
		WebBrowser obj2 = wb;
		Size minimumSize = new Size(20, 20);
		((Control)obj2).set_MinimumSize(minimumSize);
		((Control)wb).set_Name("wb");
		wb.set_ScriptErrorsSuppressed(true);
		WebBrowser obj3 = wb;
		minimumSize = new Size(528, 322);
		((Control)obj3).set_Size(minimumSize);
		((Control)wb).set_TabIndex(0);
		lbl1.set_AutoSize(true);
		Label obj4 = lbl1;
		location = new Point(9, 54);
		((Control)obj4).set_Location(location);
		((Control)lbl1).set_Name("lbl1");
		Label obj5 = lbl1;
		minimumSize = new Size(94, 13);
		((Control)obj5).set_Size(minimumSize);
		((Control)lbl1).set_TabIndex(1);
		lbl1.set_Text("1. Login to GetRef");
		lbl2.set_AutoSize(true);
		Label obj6 = lbl2;
		location = new Point(9, 67);
		((Control)obj6).set_Location(location);
		((Control)lbl2).set_Name("lbl2");
		Label obj7 = lbl2;
		minimumSize = new Size(74, 13);
		((Control)obj7).set_Size(minimumSize);
		((Control)lbl2).set_TabIndex(2);
		lbl2.set_Text("2. Set Options");
		lbl3.set_AutoSize(true);
		Label obj8 = lbl3;
		location = new Point(9, 80);
		((Control)obj8).set_Location(location);
		((Control)lbl3).set_Name("lbl3");
		Label obj9 = lbl3;
		minimumSize = new Size(70, 13);
		((Control)obj9).set_Size(minimumSize);
		((Control)lbl3).set_TabIndex(3);
		lbl3.set_Text("3. Click Start ");
		lblInstructions.set_AutoSize(true);
		((Control)lblInstructions).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		Label obj10 = lblInstructions;
		location = new Point(13, 32);
		((Control)obj10).set_Location(location);
		((Control)lblInstructions).set_Name("lblInstructions");
		Label obj11 = lblInstructions;
		minimumSize = new Size(86, 16);
		((Control)obj11).set_Size(minimumSize);
		((Control)lblInstructions).set_TabIndex(4);
		lblInstructions.set_Text("Instructions");
		Button obj12 = cmdStart;
		location = new Point(130, 32);
		((Control)obj12).set_Location(location);
		((Control)cmdStart).set_Name("cmdStart");
		Button obj13 = cmdStart;
		minimumSize = new Size(72, 32);
		((Control)obj13).set_Size(minimumSize);
		((Control)cmdStart).set_TabIndex(5);
		((ButtonBase)cmdStart).set_Text("Start");
		((ButtonBase)cmdStart).set_UseVisualStyleBackColor(true);
		((Control)cmdStop).set_Enabled(false);
		Button obj14 = cmdStop;
		location = new Point(208, 32);
		((Control)obj14).set_Location(location);
		((Control)cmdStop).set_Name("cmdStop");
		Button obj15 = cmdStop;
		minimumSize = new Size(72, 32);
		((Control)obj15).set_Size(minimumSize);
		((Control)cmdStop).set_TabIndex(6);
		((ButtonBase)cmdStop).set_Text("Stop");
		((ButtonBase)cmdStop).set_UseVisualStyleBackColor(true);
		Button obj16 = cmdHide;
		location = new Point(286, 32);
		((Control)obj16).set_Location(location);
		((Control)cmdHide).set_Name("cmdHide");
		Button obj17 = cmdHide;
		minimumSize = new Size(72, 32);
		((Control)obj17).set_Size(minimumSize);
		((Control)cmdHide).set_TabIndex(7);
		((ButtonBase)cmdHide).set_Text("Hide");
		((ButtonBase)cmdHide).set_UseVisualStyleBackColor(true);
		((Control)fraOptions).get_Controls().Add((Control)(object)lblAdWatch);
		((Control)fraOptions).get_Controls().Add((Control)(object)txtCheck);
		((Control)fraOptions).get_Controls().Add((Control)(object)lblCheck);
		((Control)fraOptions).get_Controls().Add((Control)(object)txtWait);
		((Control)fraOptions).get_Controls().Add((Control)(object)chkAds);
		GroupBox obj18 = fraOptions;
		location = new Point(364, 32);
		((Control)obj18).set_Location(location);
		((Control)fraOptions).set_Name("fraOptions");
		GroupBox obj19 = fraOptions;
		minimumSize = new Size(169, 108);
		((Control)obj19).set_Size(minimumSize);
		((Control)fraOptions).set_TabIndex(8);
		fraOptions.set_TabStop(false);
		fraOptions.set_Text("Options");
		lblAdWatch.set_AutoSize(true);
		Label obj20 = lblAdWatch;
		location = new Point(6, 51);
		((Control)obj20).set_Location(location);
		((Control)lblAdWatch).set_Name("lblAdWatch");
		Label obj21 = lblAdWatch;
		minimumSize = new Size(98, 13);
		((Control)obj21).set_Size(minimumSize);
		((Control)lblAdWatch).set_TabIndex(4);
		lblAdWatch.set_Text("Ad Watch Time (s):");
		TextBox obj22 = txtCheck;
		location = new Point(79, 19);
		((Control)obj22).set_Location(location);
		((Control)txtCheck).set_Name("txtCheck");
		TextBox obj23 = txtCheck;
		minimumSize = new Size(49, 20);
		((Control)obj23).set_Size(minimumSize);
		((Control)txtCheck).set_TabIndex(1);
		txtCheck.set_Text("10");
		txtCheck.set_TextAlign((HorizontalAlignment)2);
		lblCheck.set_AutoSize(true);
		Label obj24 = lblCheck;
		location = new Point(6, 22);
		((Control)obj24).set_Location(location);
		((Control)lblCheck).set_Name("lblCheck");
		Label obj25 = lblCheck;
		minimumSize = new Size(158, 13);
		((Control)obj25).set_Size(minimumSize);
		((Control)lblCheck).set_TabIndex(3);
		lblCheck.set_Text("Check every                     sec(s)");
		TextBox obj26 = txtWait;
		location = new Point(110, 48);
		((Control)obj26).set_Location(location);
		((Control)txtWait).set_Name("txtWait");
		TextBox obj27 = txtWait;
		minimumSize = new Size(49, 20);
		((Control)obj27).set_Size(minimumSize);
		((Control)txtWait).set_TabIndex(2);
		txtWait.set_TextAlign((HorizontalAlignment)2);
		((ButtonBase)chkAds).set_AutoSize(true);
		CheckBox obj28 = chkAds;
		location = new Point(6, 82);
		((Control)obj28).set_Location(location);
		((Control)chkAds).set_Name("chkAds");
		CheckBox obj29 = chkAds;
		minimumSize = new Size(144, 17);
		((Control)obj29).set_Size(minimumSize);
		((Control)chkAds).set_TabIndex(0);
		((ButtonBase)chkAds).set_Text("Display Total Ads In Tray");
		((ButtonBase)chkAds).set_UseVisualStyleBackColor(true);
		lblCash.set_AutoSize(true);
		Label obj30 = lblCash;
		location = new Point(12, 114);
		((Control)obj30).set_Location(location);
		((Control)lblCash).set_Name("lblCash");
		Label obj31 = lblCash;
		minimumSize = new Size(37, 13);
		((Control)obj31).set_Size(minimumSize);
		((Control)lblCash).set_TabIndex(9);
		lblCash.set_Text("Credit:");
		lblTimerCount.set_AutoSize(true);
		Label obj32 = lblTimerCount;
		location = new Point(12, 127);
		((Control)obj32).set_Location(location);
		((Control)lblTimerCount).set_Name("lblTimerCount");
		Label obj33 = lblTimerCount;
		minimumSize = new Size(93, 13);
		((Control)obj33).set_Size(minimumSize);
		((Control)lblTimerCount).set_TabIndex(10);
		lblTimerCount.set_Text("Timer Count (sec):");
		lblCashAmount.set_AutoSize(true);
		Label obj34 = lblCashAmount;
		location = new Point(114, 114);
		((Control)obj34).set_Location(location);
		((Control)lblCashAmount).set_Name("lblCashAmount");
		Label obj35 = lblCashAmount;
		minimumSize = new Size(27, 13);
		((Control)obj35).set_Size(minimumSize);
		((Control)lblCashAmount).set_TabIndex(11);
		lblCashAmount.set_Text("N/A");
		lblTime.set_AutoSize(true);
		Label obj36 = lblTime;
		location = new Point(114, 127);
		((Control)obj36).set_Location(location);
		((Control)lblTime).set_Name("lblTime");
		Label obj37 = lblTime;
		minimumSize = new Size(36, 13);
		((Control)obj37).set_Size(minimumSize);
		((Control)lblTime).set_TabIndex(12);
		lblTime.set_Text("0 / 10");
		((ListControl)lstAds).set_FormattingEnabled(true);
		ListBox obj38 = lstAds;
		location = new Point(156, 88);
		((Control)obj38).set_Location(location);
		((Control)lstAds).set_Name("lstAds");
		ListBox obj39 = lstAds;
		minimumSize = new Size(203, 56);
		((Control)obj39).set_Size(minimumSize);
		((Control)lstAds).set_TabIndex(13);
		Label obj40 = lblAdsClicked;
		location = new Point(153, 67);
		((Control)obj40).set_Location(location);
		((Control)lblAdsClicked).set_Name("lblAdsClicked");
		Label obj41 = lblAdsClicked;
		minimumSize = new Size(205, 18);
		((Control)obj41).set_Size(minimumSize);
		((Control)lblAdsClicked).set_TabIndex(14);
		lblAdsClicked.set_Text("0 Ads Clicked");
		lblAdsClicked.set_TextAlign((ContentAlignment)2);
		((ToolStrip)mnu).set_BackColor(SystemColors.Control);
		((ToolStrip)mnu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)FileToolStripMenuItem,
			(ToolStripItem)mnuAbout
		});
		MenuStrip obj42 = mnu;
		location = new Point(0, 0);
		((Control)obj42).set_Location(location);
		((Control)mnu).set_Name("mnu");
		MenuStrip obj43 = mnu;
		minimumSize = new Size(537, 24);
		((Control)obj43).set_Size(minimumSize);
		((Control)mnu).set_TabIndex(15);
		((Control)mnu).set_Text("MenuStrip1");
		((ToolStripDropDownItem)FileToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)mnuSave,
			(ToolStripItem)mnuExit
		});
		((ToolStripItem)FileToolStripMenuItem).set_Name("FileToolStripMenuItem");
		ToolStripMenuItem fileToolStripMenuItem = FileToolStripMenuItem;
		minimumSize = new Size(35, 20);
		((ToolStripItem)fileToolStripMenuItem).set_Size(minimumSize);
		((ToolStripItem)FileToolStripMenuItem).set_Text("&File");
		((ToolStripItem)mnuSave).set_Name("mnuSave");
		ToolStripMenuItem obj44 = mnuSave;
		minimumSize = new Size(151, 22);
		((ToolStripItem)obj44).set_Size(minimumSize);
		((ToolStripItem)mnuSave).set_Text("Save Settings");
		((ToolStripItem)mnuExit).set_Name("mnuExit");
		ToolStripMenuItem obj45 = mnuExit;
		minimumSize = new Size(151, 22);
		((ToolStripItem)obj45).set_Size(minimumSize);
		((ToolStripItem)mnuExit).set_Text("E&xit");
		((ToolStripItem)mnuAbout).set_Name("mnuAbout");
		ToolStripMenuItem obj46 = mnuAbout;
		minimumSize = new Size(48, 20);
		((ToolStripItem)obj46).set_Size(minimumSize);
		((ToolStripItem)mnuAbout).set_Text("About");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		minimumSize = new Size(537, 471);
		((Form)this).set_ClientSize(minimumSize);
		((Control)this).get_Controls().Add((Control)(object)lstAds);
		((Control)this).get_Controls().Add((Control)(object)lblAdsClicked);
		((Control)this).get_Controls().Add((Control)(object)lblTime);
		((Control)this).get_Controls().Add((Control)(object)lblCashAmount);
		((Control)this).get_Controls().Add((Control)(object)lblTimerCount);
		((Control)this).get_Controls().Add((Control)(object)lblCash);
		((Control)this).get_Controls().Add((Control)(object)fraOptions);
		((Control)this).get_Controls().Add((Control)(object)cmdHide);
		((Control)this).get_Controls().Add((Control)(object)cmdStop);
		((Control)this).get_Controls().Add((Control)(object)cmdStart);
		((Control)this).get_Controls().Add((Control)(object)lblInstructions);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)wb);
		((Control)this).get_Controls().Add((Control)(object)mnu);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MainMenuStrip(mnu);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Text("GetRef Auto Clicker");
		((Control)fraOptions).ResumeLayout(false);
		((Control)fraOptions).PerformLayout();
		((Control)mnu).ResumeLayout(false);
		((Control)mnu).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		Save();
	}

	public void Save()
	{
		wb.Stop();
		StreamWriter streamWriter = File.CreateText("getref-settings.ini");
		streamWriter.WriteLine(lblCashAmount.get_Text());
		streamWriter.WriteLine(txtCheck.get_Text());
		streamWriter.WriteLine(txtWait.get_Text());
		streamWriter.Close();
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		bStop = false;
		view = 0;
		counter = 0;
		bDone = false;
		if (File.Exists("getref-settings.ini"))
		{
			StreamReader streamReader = File.OpenText("getref-settings.ini");
			lblCashAmount.set_Text(streamReader.ReadLine());
			txtCheck.set_Text(streamReader.ReadLine());
			txtWait.set_Text(streamReader.ReadLine());
			streamReader.Close();
		}
		wb.Navigate("http://www.getref.com/index.asp");
	}

	private void mnuExit_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got Unknown
		string text = Conversions.ToString((int)Interaction.MsgBox((object)"Are you sure you want to exit?", (MsgBoxStyle)4, (object)"GetRef Auto Clicker"));
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
		nid.set_Text("GetRef Auto Clicker\0");
		if ((int)chkAds.get_CheckState() == 1)
		{
			nid.set_Text("GetRef Auto Clicker\r\nTotal Ads Clicked: " + Conversions.ToString(lstAds.get_Items().get_Count()) + "\0");
		}
		nid.set_Visible(true);
	}

	private void nid_DoubleClick(object sender, EventArgs e)
	{
		((Control)this).Show();
		nid.set_Visible(false);
	}

	private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		bDone = true;
	}

	private void wb_NewWindow(object sender, CancelEventArgs e)
	{
		e.Cancel = true;
	}

	private void cmdStart_Click(object sender, EventArgs e)
	{
		view = 0;
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
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
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
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 578:
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
							goto IL_0013;
						case 4:
							goto IL_001d;
						case 5:
							goto IL_0027;
						case 6:
							goto IL_0031;
						case 9:
							goto IL_0046;
						case 7:
						case 8:
						case 10:
							goto IL_004f;
						case 11:
							goto IL_0070;
						case 12:
							goto IL_007c;
						case 13:
							goto IL_008c;
						case 14:
							goto IL_009c;
						case 15:
							goto IL_00a7;
						case 16:
							goto IL_00b2;
						case 18:
						case 19:
							goto IL_00c2;
						case 20:
							goto IL_00dc;
						case 21:
							goto IL_00ea;
						case 22:
							goto IL_0109;
						case 23:
							goto IL_011d;
						case 24:
							goto IL_012e;
						case 25:
							goto IL_0143;
						case 26:
							goto IL_014f;
						case 27:
							goto IL_0163;
						case 28:
							goto IL_0173;
						case 30:
						case 31:
							goto IL_0183;
						case 32:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 17:
						case 29:
						case 33:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0046:
					num = 9;
					Application.DoEvents();
					goto IL_004f;
					IL_0183:
					num = 31;
					tmr.set_Interval(1000);
					break;
					IL_0009:
					num = 2;
					view = 0;
					goto IL_0013;
					IL_0013:
					num = 3;
					counter = 0;
					goto IL_001d;
					IL_001d:
					num = 4;
					bDone = false;
					goto IL_0027;
					IL_0027:
					num = 5;
					bStop = false;
					goto IL_0031;
					IL_0031:
					num = 6;
					wb.Navigate("http://www.getref.com/earnlink.asp");
					goto IL_004f;
					IL_004f:
					num = 8;
					if (!((((int)wb.get_ReadyState() == 4) & bDone) | bStop))
					{
						goto IL_0046;
					}
					goto IL_0070;
					IL_0070:
					num = 11;
					if (bStop)
					{
						goto IL_007c;
					}
					goto IL_00c2;
					IL_007c:
					num = 12;
					tmrWait.set_Enabled(false);
					goto IL_008c;
					IL_008c:
					num = 13;
					tmr.set_Enabled(false);
					goto IL_009c;
					IL_009c:
					num = 14;
					bDone = false;
					goto IL_00a7;
					IL_00a7:
					num = 15;
					view = 0;
					goto IL_00b2;
					IL_00b2:
					num = 16;
					counter = 0;
					goto end_IL_0000_3;
					IL_00c2:
					num = 19;
					outerHtml = wb.get_Document().get_Body().get_OuterHtml();
					goto IL_00dc;
					IL_00dc:
					num = 20;
					num5 = 1L;
					goto IL_00ea;
					IL_00ea:
					num = 21;
					num5 = checked(Strings.InStr((int)num5, outerHtml, "You have ", (CompareMethod)1) + Strings.Len("You have "));
					goto IL_0109;
					IL_0109:
					num = 22;
					num6 = Strings.InStr(checked((int)num5), outerHtml, " credits", (CompareMethod)1);
					goto IL_011d;
					IL_011d:
					num = 23;
					text = checked(Strings.Mid(outerHtml, (int)num5, (int)(num6 - num5)));
					goto IL_012e;
					IL_012e:
					num = 24;
					lblCashAmount.set_Text(Strings.Trim(text));
					goto IL_0143;
					IL_0143:
					num = 25;
					if (bAds)
					{
						goto IL_014f;
					}
					goto IL_0183;
					IL_014f:
					num = 26;
					tmrWait.set_Interval(1000);
					goto IL_0163;
					IL_0163:
					num = 27;
					tmrWait.set_Enabled(true);
					goto IL_0173;
					IL_0173:
					num = 28;
					bAds = false;
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 32;
				tmr.set_Enabled(true);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 578;
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

	private void cmdStop_Click(object sender, EventArgs e)
	{
		bStop = true;
		((Control)cmdStop).set_Enabled(false);
		((Control)cmdStart).set_Enabled(true);
		((Control)txtCheck).set_Enabled(true);
		((Control)txtWait).set_Enabled(true);
		wb.Stop();
		bDone = true;
	}

	private void tmr_Tick(object sender, EventArgs e)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		if (bStop)
		{
			tmrWait.set_Enabled(false);
			tmr.set_Enabled(false);
			bDone = false;
			view = 0;
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
			wb.Navigate("http://www.getref.com/earnlink.asp");
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
				view = 0;
				counter = 0;
				return;
			}
			object outerHtml = wb.get_Document().get_Body().get_OuterHtml();
			long num = 1L;
			amount = 0;
			int upperBound = Ads.GetUpperBound(0);
			for (int i = 0; i <= upperBound; i++)
			{
				Ads[i] = "";
				strName[i] = "";
			}
			while (Strings.InStr((int)num, Conversions.ToString(outerHtml), "earnlinkbrowse.asp?id=", (CompareMethod)1) != 0)
			{
				num = Strings.InStr((int)num, Conversions.ToString(outerHtml), "earnlinkbrowse.asp?id=", (CompareMethod)1) + Strings.Len("earnlinkbrowse.asp?id=");
				long num2 = Strings.InStr((int)num, Conversions.ToString(outerHtml), "target=new", (CompareMethod)1) - 1;
				string text = Strings.Mid(Conversions.ToString(outerHtml), (int)num, (int)(num2 - num));
				if (Operators.CompareString(Strings.Trim(text), "", false) != 0)
				{
					Ads = (string[])Utils.CopyArray((Array)Ads, (Array)new string[amount + 1]);
					strName = (string[])Utils.CopyArray((Array)strName, (Array)new string[amount + 1]);
					Ads[amount] = text;
					num = Strings.InStr((int)num, Conversions.ToString(outerHtml), "<font class=", (CompareMethod)1) + Strings.Len("<font class=");
					num = Strings.InStr((int)num, Conversions.ToString(outerHtml), ">", (CompareMethod)1) + Strings.Len(">");
					num2 = Strings.InStr((int)num, Conversions.ToString(outerHtml), "</font>", (CompareMethod)1);
					text = Strings.Mid(Conversions.ToString(outerHtml), (int)num, (int)(num2 - num));
					strName[amount] = text;
					amount++;
					Application.DoEvents();
				}
			}
			if (amount != 0)
			{
				tmrWait.set_Interval(1000);
				tmrWait.set_Enabled(true);
			}
			else
			{
				counter = 0;
				view = 0;
				tmr.set_Enabled(true);
			}
		}
	}

	private void tmrWait_Tick(object sender, EventArgs e)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Invalid comparison between Unknown and I4
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Invalid comparison between Unknown and I4
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Invalid comparison between Unknown and I4
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
						if (bStop)
						{
							tmrWait.set_Enabled(false);
							tmr.set_Enabled(false);
							bDone = false;
							view = 0;
							counter = 0;
							goto end_IL_0000;
						}
						tmrWait.set_Enabled(false);
						unchecked
						{
							if ((amount != 0) & (Operators.CompareString(Ads[view], "", false) != 0))
							{
								if ((double)tmrWait.get_Interval() == Conversions.ToDouble(txtWait.get_Text()) * 1000.0)
								{
									ProjectData.ClearProjectError();
									num2 = 2;
									wb.get_Document().get_Forms().get_Item("counter")
										.InvokeMember("submit");
									bDone = false;
									while (!((((int)wb.get_ReadyState() == 4) & bDone) | bStop))
									{
										Application.DoEvents();
									}
								}
								goto IL_00f6;
							}
							ProjectData.ClearProjectError();
							num2 = 3;
							wb.get_Document().get_Forms().get_Item("counter")
								.InvokeMember("submit");
							bDone = false;
							while (!((((int)wb.get_ReadyState() == 4) & bDone) | bStop))
							{
								Application.DoEvents();
							}
							break;
						}
					case 804:
						{
							num = -1;
							switch (num2)
							{
							case 2:
								break;
							case 3:
								goto end_IL_0000_2;
							default:
								goto IL_035e;
							}
							goto IL_00f6;
						}
						IL_00f6:
						Ads[view] = Strings.Trim(Ads[view]);
						wb.Navigate("http://www.getref.com/earnlinkbrowse_frame1.asp?id=" + Strings.Left(Ads[view], Strings.Len(Ads[view]) - 1));
						lstAds.get_Items().Add((object)strName[view]);
						lblAdsClicked.set_Text(Conversions.ToString(lstAds.get_Items().get_Count()) + " Ads Clicked");
						if (unchecked((int)chkAds.get_CheckState()) == 1)
						{
							nid.set_Text("GetRef Auto Clicker\r\nTotal Ads Clicked: " + Conversions.ToString(lstAds.get_Items().get_Count()) + "\0");
						}
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
							view = 0;
							counter = 0;
							goto end_IL_0000;
						}
						view++;
						if (view == amount)
						{
							tmrWait.set_Enabled(false);
							counter = 0;
							GetStats();
						}
						else
						{
							tmrWait.set_Interval((int)Math.Round(Conversions.ToDouble(txtWait.get_Text()) * 1000.0));
							tmrWait.set_Enabled(true);
						}
						goto end_IL_0000_3;
						end_IL_0000_2:
						break;
					}
					tmrWait.set_Enabled(false);
					counter = 0;
					GetStats();
				}
				end_IL_0000_3:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 804;
				continue;
			}
			break;
			IL_035e:
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

	private void mnuSave_Click(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Save();
		Interaction.MsgBox((object)"Successfully saved.", (MsgBoxStyle)64, (object)"Save Settings");
	}

	private void mnuAbout_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.frmAbout).Show();
	}
}
