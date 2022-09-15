using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using PCL;
using ServiceManager.My;

namespace ServiceManager;

public class frmMain : Form
{
	[AccessedThroughProperty("CHServicesDependedOn")]
	private ColumnHeader _CHServicesDependedOn;

	private ServiceManager objServiceManager;

	private IContainer components;

	[AccessedThroughProperty("DotNetBarManager1")]
	private DotNetBarManager _DotNetBarManager1;

	[AccessedThroughProperty("barLeftDockSite")]
	private DockSite _barLeftDockSite;

	[AccessedThroughProperty("barRightDockSite")]
	private DockSite _barRightDockSite;

	[AccessedThroughProperty("barTopDockSite")]
	private DockSite _barTopDockSite;

	[AccessedThroughProperty("barBottomDockSite")]
	private DockSite _barBottomDockSite;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("ilService")]
	private ImageList _ilService;

	[AccessedThroughProperty("PanelEx1")]
	private PanelEx _PanelEx1;

	[AccessedThroughProperty("ExpandableSplitter1")]
	private ExpandableSplitter _ExpandableSplitter1;

	[AccessedThroughProperty("PanelEx2")]
	private PanelEx _PanelEx2;

	[AccessedThroughProperty("lblDesc")]
	private Label _lblDesc;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PanelEx3")]
	private PanelEx _PanelEx3;

	[AccessedThroughProperty("ExpandableSplitter2")]
	private ExpandableSplitter _ExpandableSplitter2;

	[AccessedThroughProperty("lvwServices")]
	private ListView _lvwServices;

	[AccessedThroughProperty("CHName")]
	private ColumnHeader _CHName;

	[AccessedThroughProperty("CHStatus")]
	private ColumnHeader _CHStatus;

	[AccessedThroughProperty("CHType")]
	private ColumnHeader _CHType;

	[AccessedThroughProperty("CHExe")]
	private ColumnHeader _CHExe;

	[AccessedThroughProperty("CHFileExist")]
	private ColumnHeader _CHFileExist;

	[AccessedThroughProperty("CHFileDate")]
	private ColumnHeader _CHFileDate;

	[AccessedThroughProperty("CHDesc")]
	private ColumnHeader _CHDesc;

	[AccessedThroughProperty("CHDigitalSign")]
	private ColumnHeader _CHDigitalSign;

	[AccessedThroughProperty("PanelEx4")]
	private PanelEx _PanelEx4;

	[AccessedThroughProperty("rbSystemDriver")]
	private RadioButton _rbSystemDriver;

	[AccessedThroughProperty("rbSystemService")]
	private RadioButton _rbSystemService;

	[AccessedThroughProperty("CHTruePath")]
	private ColumnHeader _CHTruePath;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker _BackgroundWorker1;

	[AccessedThroughProperty("TimerFoused")]
	private Timer _TimerFoused;

	[AccessedThroughProperty("llOptimizeService")]
	private LinkLabel _llOptimizeService;

	internal virtual ColumnHeader CHServicesDependedOn
	{
		get
		{
			return _CHServicesDependedOn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHServicesDependedOn = value;
		}
	}

	internal virtual DotNetBarManager DotNetBarManager1
	{
		get
		{
			return _DotNetBarManager1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = DotNetBarManager1_ItemClick;
			if (_DotNetBarManager1 != null)
			{
				_DotNetBarManager1.remove_ItemClick(eventHandler);
			}
			_DotNetBarManager1 = value;
			if (_DotNetBarManager1 != null)
			{
				_DotNetBarManager1.add_ItemClick(eventHandler);
			}
		}
	}

	internal virtual DockSite barLeftDockSite
	{
		get
		{
			return _barLeftDockSite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_barLeftDockSite = value;
		}
	}

	internal virtual DockSite barRightDockSite
	{
		get
		{
			return _barRightDockSite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_barRightDockSite = value;
		}
	}

	internal virtual DockSite barTopDockSite
	{
		get
		{
			return _barTopDockSite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_barTopDockSite = value;
		}
	}

	internal virtual DockSite barBottomDockSite
	{
		get
		{
			return _barBottomDockSite;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_barBottomDockSite = value;
		}
	}

	internal virtual Panel Panel1
	{
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual ImageList ilService
	{
		get
		{
			return _ilService;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ilService = value;
		}
	}

	internal virtual PanelEx PanelEx1
	{
		get
		{
			return _PanelEx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PanelEx1 = value;
		}
	}

	internal virtual ExpandableSplitter ExpandableSplitter1
	{
		get
		{
			return _ExpandableSplitter1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ExpandableSplitter1 = value;
		}
	}

	internal virtual PanelEx PanelEx2
	{
		get
		{
			return _PanelEx2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PanelEx2 = value;
		}
	}

	internal virtual Label lblDesc
	{
		get
		{
			return _lblDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_lblDesc = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual PanelEx PanelEx3
	{
		get
		{
			return _PanelEx3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PanelEx3 = value;
		}
	}

	internal virtual ExpandableSplitter ExpandableSplitter2
	{
		get
		{
			return _ExpandableSplitter2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_ExpandableSplitter2 = value;
		}
	}

	internal virtual ListView lvwServices
	{
		get
		{
			return _lvwServices;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			ColumnClickEventHandler val = new ColumnClickEventHandler(lvwServices_ColumnClick);
			EventHandler eventHandler = lvwServices_SelectedIndexChanged;
			if (_lvwServices != null)
			{
				_lvwServices.remove_ColumnClick(val);
				_lvwServices.remove_SelectedIndexChanged(eventHandler);
			}
			_lvwServices = value;
			if (_lvwServices != null)
			{
				_lvwServices.add_ColumnClick(val);
				_lvwServices.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual ColumnHeader CHName
	{
		get
		{
			return _CHName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHName = value;
		}
	}

	internal virtual ColumnHeader CHStatus
	{
		get
		{
			return _CHStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHStatus = value;
		}
	}

	internal virtual ColumnHeader CHType
	{
		get
		{
			return _CHType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHType = value;
		}
	}

	internal virtual ColumnHeader CHExe
	{
		get
		{
			return _CHExe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHExe = value;
		}
	}

	internal virtual ColumnHeader CHFileExist
	{
		get
		{
			return _CHFileExist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHFileExist = value;
		}
	}

	internal virtual ColumnHeader CHFileDate
	{
		get
		{
			return _CHFileDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHFileDate = value;
		}
	}

	internal virtual ColumnHeader CHDesc
	{
		get
		{
			return _CHDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHDesc = value;
		}
	}

	internal virtual ColumnHeader CHDigitalSign
	{
		get
		{
			return _CHDigitalSign;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHDigitalSign = value;
		}
	}

	internal virtual PanelEx PanelEx4
	{
		get
		{
			return _PanelEx4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_PanelEx4 = value;
		}
	}

	internal virtual RadioButton rbSystemDriver
	{
		get
		{
			return _rbSystemDriver;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = rbSystemDriver_CheckedChanged;
			if (_rbSystemDriver != null)
			{
				_rbSystemDriver.remove_CheckedChanged(eventHandler);
			}
			_rbSystemDriver = value;
			if (_rbSystemDriver != null)
			{
				_rbSystemDriver.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual RadioButton rbSystemService
	{
		get
		{
			return _rbSystemService;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = rbSystemService_CheckedChanged;
			if (_rbSystemService != null)
			{
				_rbSystemService.remove_CheckedChanged(eventHandler);
			}
			_rbSystemService = value;
			if (_rbSystemService != null)
			{
				_rbSystemService.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual ColumnHeader CHTruePath
	{
		get
		{
			return _CHTruePath;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_CHTruePath = value;
		}
	}

	internal virtual Label Label1
	{
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual BackgroundWorker BackgroundWorker1
	{
		get
		{
			return _BackgroundWorker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			RunWorkerCompletedEventHandler value2 = BackgroundWorker1_RunWorkerCompleted;
			DoWorkEventHandler value3 = BackgroundWorker1_DoWork;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.RunWorkerCompleted -= value2;
				_BackgroundWorker1.DoWork -= value3;
			}
			_BackgroundWorker1 = value;
			if (_BackgroundWorker1 != null)
			{
				_BackgroundWorker1.RunWorkerCompleted += value2;
				_BackgroundWorker1.DoWork += value3;
			}
		}
	}

	internal virtual Timer TimerFoused
	{
		get
		{
			return _TimerFoused;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler eventHandler = TimerFoused_Tick;
			if (_TimerFoused != null)
			{
				_TimerFoused.remove_Tick(eventHandler);
			}
			_TimerFoused = value;
			if (_TimerFoused != null)
			{
				_TimerFoused.add_Tick(eventHandler);
			}
		}
	}

	internal virtual LinkLabel llOptimizeService
	{
		get
		{
			return _llOptimizeService;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(llOptimizeService_LinkClicked);
			if (_llOptimizeService != null)
			{
				_llOptimizeService.remove_LinkClicked(val);
			}
			_llOptimizeService = value;
			if (_llOptimizeService != null)
			{
				_llOptimizeService.add_LinkClicked(val);
			}
		}
	}

	public frmMain()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)this).add_Resize((EventHandler)frmMain_Resize);
		((Form)this).add_FormClosed(new FormClosedEventHandler(frmMain_FormClosed));
		objServiceManager = new ServiceManager();
		InitializeComponent();
		InitRegisterPWD();
	}

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
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Expected O, but got Unknown
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected O, but got Unknown
		//IL_153e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Expected O, but got Unknown
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_155e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		DotNetBarManager1 = new DotNetBarManager(components);
		barBottomDockSite = new DockSite();
		barLeftDockSite = new DockSite();
		barRightDockSite = new DockSite();
		barTopDockSite = new DockSite();
		lvwServices = new ListView();
		CHName = new ColumnHeader();
		CHStatus = new ColumnHeader();
		CHType = new ColumnHeader();
		CHExe = new ColumnHeader();
		CHFileExist = new ColumnHeader();
		CHFileDate = new ColumnHeader();
		CHDigitalSign = new ColumnHeader();
		CHTruePath = new ColumnHeader();
		CHDesc = new ColumnHeader();
		Panel1 = new Panel();
		PanelEx4 = new PanelEx();
		llOptimizeService = new LinkLabel();
		rbSystemDriver = new RadioButton();
		rbSystemService = new RadioButton();
		PanelEx1 = new PanelEx();
		ilService = new ImageList(components);
		ExpandableSplitter1 = new ExpandableSplitter();
		PanelEx2 = new PanelEx();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		lblDesc = new Label();
		PanelEx3 = new PanelEx();
		ExpandableSplitter2 = new ExpandableSplitter();
		BackgroundWorker1 = new BackgroundWorker();
		TimerFoused = new Timer(components);
		CHServicesDependedOn = new ColumnHeader();
		((Control)Panel1).SuspendLayout();
		((Control)PanelEx4).SuspendLayout();
		((Control)PanelEx2).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)PanelEx3).SuspendLayout();
		((Control)this).SuspendLayout();
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)112);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)131139);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)131137);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)131158);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)131160);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)131162);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)46);
		DotNetBarManager1.get_AutoDispatchShortcuts().Add((eShortcut)45);
		DotNetBarManager1.set_BottomDockSite(barBottomDockSite);
		DotNetBarManager1.set_DefinitionName("frmMain.DotNetBarManager1.xml");
		DotNetBarManager1.set_LeftDockSite(barLeftDockSite);
		DotNetBarManager1.set_ParentForm((Form)(object)this);
		DotNetBarManager1.set_RightDockSite(barRightDockSite);
		DotNetBarManager1.set_Style((eDotNetBarStyle)2);
		DotNetBarManager1.set_TopDockSite(barTopDockSite);
		((Control)barBottomDockSite).set_AccessibleRole((AccessibleRole)9);
		barBottomDockSite.set_BackgroundImageAlpha(byte.MaxValue);
		barBottomDockSite.set_Dock((DockStyle)2);
		DockSite obj = barBottomDockSite;
		Point location = new Point(0, 650);
		((Control)obj).set_Location(location);
		((Control)barBottomDockSite).set_Name("barBottomDockSite");
		DockSite obj2 = barBottomDockSite;
		Size size = new Size(976, 21);
		((Control)obj2).set_Size(size);
		((Control)barBottomDockSite).set_TabIndex(3);
		((Control)barBottomDockSite).set_TabStop(false);
		((Control)barLeftDockSite).set_AccessibleRole((AccessibleRole)9);
		barLeftDockSite.set_BackgroundImageAlpha(byte.MaxValue);
		barLeftDockSite.set_Dock((DockStyle)3);
		DockSite obj3 = barLeftDockSite;
		location = new Point(0, 50);
		((Control)obj3).set_Location(location);
		((Control)barLeftDockSite).set_Name("barLeftDockSite");
		DockSite obj4 = barLeftDockSite;
		size = new Size(0, 600);
		((Control)obj4).set_Size(size);
		((Control)barLeftDockSite).set_TabIndex(0);
		((Control)barLeftDockSite).set_TabStop(false);
		((Control)barRightDockSite).set_AccessibleRole((AccessibleRole)9);
		barRightDockSite.set_BackgroundImageAlpha(byte.MaxValue);
		barRightDockSite.set_Dock((DockStyle)4);
		DockSite obj5 = barRightDockSite;
		location = new Point(976, 50);
		((Control)obj5).set_Location(location);
		((Control)barRightDockSite).set_Name("barRightDockSite");
		DockSite obj6 = barRightDockSite;
		size = new Size(0, 600);
		((Control)obj6).set_Size(size);
		((Control)barRightDockSite).set_TabIndex(1);
		((Control)barRightDockSite).set_TabStop(false);
		((Control)barTopDockSite).set_AccessibleRole((AccessibleRole)9);
		barTopDockSite.set_BackgroundImageAlpha(byte.MaxValue);
		barTopDockSite.set_Dock((DockStyle)1);
		DockSite obj7 = barTopDockSite;
		location = new Point(0, 0);
		((Control)obj7).set_Location(location);
		((Control)barTopDockSite).set_Name("barTopDockSite");
		DockSite obj8 = barTopDockSite;
		size = new Size(976, 50);
		((Control)obj8).set_Size(size);
		((Control)barTopDockSite).set_TabIndex(2);
		((Control)barTopDockSite).set_TabStop(false);
		lvwServices.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[10] { CHName, CHStatus, CHType, CHExe, CHFileExist, CHFileDate, CHDigitalSign, CHTruePath, CHDesc, CHServicesDependedOn });
		DotNetBarManager1.SetContextMenuEx((Control)(object)lvwServices, "ContextMenu");
		((Control)lvwServices).set_Dock((DockStyle)5);
		lvwServices.set_FullRowSelect(true);
		ListView obj9 = lvwServices;
		location = new Point(141, 70);
		((Control)obj9).set_Location(location);
		lvwServices.set_MultiSelect(false);
		((Control)lvwServices).set_Name("lvwServices");
		ListView obj10 = lvwServices;
		size = new Size(835, 500);
		((Control)obj10).set_Size(size);
		((Control)lvwServices).set_TabIndex(9);
		lvwServices.set_UseCompatibleStateImageBehavior(false);
		lvwServices.set_View((View)1);
		CHName.set_Text("Name");
		CHName.set_Width(180);
		CHStatus.set_Text("Status");
		CHType.set_Text("Startup Type");
		CHType.set_Width(80);
		CHExe.set_Text("Executable file path");
		CHExe.set_Width(245);
		CHFileExist.set_Text("Available");
		CHFileExist.set_Width(67);
		CHFileDate.set_DisplayIndex(6);
		CHFileDate.set_Text("File Date");
		CHFileDate.set_Width(75);
		CHDigitalSign.set_DisplayIndex(8);
		CHDigitalSign.set_Text("Digital Signature ");
		CHDigitalSign.set_Width(103);
		CHTruePath.set_DisplayIndex(5);
		CHTruePath.set_Text("");
		CHTruePath.set_Width(0);
		CHDesc.set_DisplayIndex(7);
		CHDesc.set_Text("Desc");
		CHDesc.set_Width(0);
		((Control)Panel1).get_Controls().Add((Control)(object)PanelEx4);
		((Control)Panel1).get_Controls().Add((Control)(object)PanelEx1);
		((Control)Panel1).set_Dock((DockStyle)3);
		Panel panel = Panel1;
		location = new Point(0, 50);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(138, 600);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(4);
		PanelEx4.set_AntiAlias(true);
		((Control)PanelEx4).get_Controls().Add((Control)(object)llOptimizeService);
		((Control)PanelEx4).get_Controls().Add((Control)(object)rbSystemDriver);
		((Control)PanelEx4).get_Controls().Add((Control)(object)rbSystemService);
		((Control)PanelEx4).set_Dock((DockStyle)5);
		PanelEx panelEx = PanelEx4;
		location = new Point(0, 21);
		((Control)panelEx).set_Location(location);
		((Control)PanelEx4).set_Name("PanelEx4");
		PanelEx panelEx2 = PanelEx4;
		size = new Size(138, 579);
		((Control)panelEx2).set_Size(size);
		PanelEx4.get_Style().set_Alignment((StringAlignment)1);
		PanelEx4.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)48);
		PanelEx4.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)47);
		PanelEx4.get_Style().set_Border((eBorderType)1);
		PanelEx4.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)49);
		PanelEx4.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)50);
		PanelEx4.get_Style().set_GradientAngle(90);
		((Control)PanelEx4).set_TabIndex(11);
		((Control)llOptimizeService).set_BackColor(Color.Transparent);
		((Control)llOptimizeService).set_Font(new Font("Tahoma", 11f, (FontStyle)1, (GraphicsUnit)2, (byte)134));
		((Label)llOptimizeService).set_Image((Image)componentResourceManager.GetObject("llOptimizeService.Image"));
		((Label)llOptimizeService).set_ImageAlign((ContentAlignment)2);
		llOptimizeService.set_LinkBehavior((LinkBehavior)2);
		llOptimizeService.set_LinkColor(Color.White);
		LinkLabel obj11 = llOptimizeService;
		location = new Point(9, 196);
		((Control)obj11).set_Location(location);
		((Control)llOptimizeService).set_Name("llOptimizeService");
		LinkLabel obj12 = llOptimizeService;
		size = new Size(120, 42);
		((Control)obj12).set_Size(size);
		((Control)llOptimizeService).set_TabIndex(13);
		((Label)llOptimizeService).set_TabStop(true);
		llOptimizeService.set_Text("Optimize Services");
		((Label)llOptimizeService).set_TextAlign((ContentAlignment)512);
		rbSystemDriver.set_Appearance((Appearance)1);
		((ButtonBase)rbSystemDriver).set_BackColor(Color.White);
		((ButtonBase)rbSystemDriver).get_FlatAppearance().set_CheckedBackColor(Color.FromArgb(224, 224, 224));
		((ButtonBase)rbSystemDriver).set_Image((Image)componentResourceManager.GetObject("rbSystemDriver.Image"));
		((ButtonBase)rbSystemDriver).set_ImageAlign((ContentAlignment)2);
		RadioButton obj13 = rbSystemDriver;
		location = new Point(14, 116);
		((Control)obj13).set_Location(location);
		((Control)rbSystemDriver).set_Name("rbSystemDriver");
		RadioButton obj14 = rbSystemDriver;
		size = new Size(105, 57);
		((Control)obj14).set_Size(size);
		((Control)rbSystemDriver).set_TabIndex(12);
		((ButtonBase)rbSystemDriver).set_Text("System Driver");
		rbSystemDriver.set_TextAlign((ContentAlignment)512);
		((ButtonBase)rbSystemDriver).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)rbSystemDriver).set_UseVisualStyleBackColor(false);
		rbSystemService.set_Appearance((Appearance)1);
		((ButtonBase)rbSystemService).set_BackColor(Color.White);
		rbSystemService.set_Checked(true);
		((ButtonBase)rbSystemService).set_Image((Image)componentResourceManager.GetObject("rbSystemService.Image"));
		((ButtonBase)rbSystemService).set_ImageAlign((ContentAlignment)2);
		RadioButton obj15 = rbSystemService;
		location = new Point(14, 42);
		((Control)obj15).set_Location(location);
		((Control)rbSystemService).set_Name("rbSystemService");
		RadioButton obj16 = rbSystemService;
		size = new Size(105, 57);
		((Control)obj16).set_Size(size);
		((Control)rbSystemService).set_TabIndex(10);
		rbSystemService.set_TabStop(true);
		((ButtonBase)rbSystemService).set_Text("System Service");
		rbSystemService.set_TextAlign((ContentAlignment)512);
		((ButtonBase)rbSystemService).set_TextImageRelation((TextImageRelation)1);
		((ButtonBase)rbSystemService).set_UseVisualStyleBackColor(false);
		PanelEx1.set_AntiAlias(true);
		((Control)PanelEx1).set_Dock((DockStyle)1);
		PanelEx panelEx3 = PanelEx1;
		location = new Point(0, 0);
		((Control)panelEx3).set_Location(location);
		((Control)PanelEx1).set_Name("PanelEx1");
		PanelEx panelEx4 = PanelEx1;
		size = new Size(138, 21);
		((Control)panelEx4).set_Size(size);
		PanelEx1.get_Style().set_Alignment((StringAlignment)1);
		PanelEx1.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)47);
		PanelEx1.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)48);
		PanelEx1.get_Style().set_Border((eBorderType)1);
		PanelEx1.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)49);
		PanelEx1.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)50);
		PanelEx1.get_Style().set_GradientAngle(90);
		((Control)PanelEx1).set_TabIndex(0);
		PanelEx1.set_Text("Service and Drivers");
		ilService.set_ColorDepth((ColorDepth)32);
		ImageList obj17 = ilService;
		size = new Size(16, 16);
		obj17.set_ImageSize(size);
		ilService.set_TransparentColor(Color.Transparent);
		ExpandableSplitter1.set_BackColor2(SystemColors.ControlDarkDark);
		ExpandableSplitter1.set_BackColor2SchemePart((eColorSchemePart)49);
		ExpandableSplitter1.set_BackColorSchemePart((eColorSchemePart)47);
		ExpandableSplitter1.set_ExpandFillColor(SystemColors.ControlDarkDark);
		ExpandableSplitter1.set_ExpandFillColorSchemePart((eColorSchemePart)49);
		ExpandableSplitter1.set_ExpandLineColor(SystemColors.ControlText);
		ExpandableSplitter1.set_ExpandLineColorSchemePart((eColorSchemePart)36);
		ExpandableSplitter1.set_GripDarkColor(SystemColors.ControlText);
		ExpandableSplitter1.set_GripDarkColorSchemePart((eColorSchemePart)36);
		ExpandableSplitter1.set_GripLightColor(Color.FromArgb(252, 252, 252));
		ExpandableSplitter1.set_GripLightColorSchemePart((eColorSchemePart)0);
		ExpandableSplitter1.set_HotBackColor(Color.FromArgb(163, 209, 255));
		ExpandableSplitter1.set_HotBackColor2(Color.FromArgb(234, 244, 255));
		ExpandableSplitter1.set_HotBackColor2SchemePart((eColorSchemePart)31);
		ExpandableSplitter1.set_HotBackColorSchemePart((eColorSchemePart)30);
		ExpandableSplitter1.set_HotExpandFillColor(SystemColors.ControlDarkDark);
		ExpandableSplitter1.set_HotExpandFillColorSchemePart((eColorSchemePart)49);
		ExpandableSplitter1.set_HotExpandLineColor(SystemColors.ControlText);
		ExpandableSplitter1.set_HotExpandLineColorSchemePart((eColorSchemePart)36);
		ExpandableSplitter1.set_HotGripDarkColor(SystemColors.ControlDarkDark);
		ExpandableSplitter1.set_HotGripDarkColorSchemePart((eColorSchemePart)49);
		ExpandableSplitter1.set_HotGripLightColor(Color.FromArgb(252, 252, 252));
		ExpandableSplitter1.set_HotGripLightColorSchemePart((eColorSchemePart)0);
		ExpandableSplitter expandableSplitter = ExpandableSplitter1;
		location = new Point(138, 50);
		((Control)expandableSplitter).set_Location(location);
		((Control)ExpandableSplitter1).set_Name("ExpandableSplitter1");
		ExpandableSplitter expandableSplitter2 = ExpandableSplitter1;
		size = new Size(3, 600);
		((Control)expandableSplitter2).set_Size(size);
		((Control)ExpandableSplitter1).set_TabIndex(5);
		((Splitter)ExpandableSplitter1).set_TabStop(false);
		PanelEx2.set_AntiAlias(true);
		((Control)PanelEx2).get_Controls().Add((Control)(object)Label1);
		((Control)PanelEx2).set_Dock((DockStyle)1);
		PanelEx panelEx5 = PanelEx2;
		location = new Point(141, 50);
		((Control)panelEx5).set_Location(location);
		((Control)PanelEx2).set_Name("PanelEx2");
		PanelEx panelEx6 = PanelEx2;
		size = new Size(835, 20);
		((Control)panelEx6).set_Size(size);
		PanelEx2.get_Style().set_Alignment((StringAlignment)1);
		PanelEx2.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)47);
		PanelEx2.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)48);
		PanelEx2.get_Style().set_Border((eBorderType)1);
		PanelEx2.get_Style().get_BorderColor().set_ColorSchemePart((eColorSchemePart)49);
		PanelEx2.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)50);
		PanelEx2.get_Style().set_GradientAngle(90);
		((Control)PanelEx2).set_TabIndex(6);
		PanelEx2.set_Text("Service and Drivers List");
		((Control)Label1).set_Anchor((AnchorStyles)8);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_ForeColor(Color.White);
		Label label = Label1;
		location = new Point(627, 4);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(180, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("(Click column header to sort entries)");
		((Control)PictureBox1).set_BackColor(Color.Transparent);
		PictureBox pictureBox = PictureBox1;
		location = new Point(14, 10);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(42, 33);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(5);
		PictureBox1.set_TabStop(false);
		((Control)lblDesc).set_Anchor((AnchorStyles)15);
		((Control)lblDesc).set_BackColor(Color.Transparent);
		Label obj18 = lblDesc;
		location = new Point(64, 8);
		((Control)obj18).set_Location(location);
		((Control)lblDesc).set_Name("lblDesc");
		Label obj19 = lblDesc;
		size = new Size(762, 63);
		((Control)obj19).set_Size(size);
		((Control)lblDesc).set_TabIndex(4);
		PanelEx3.set_AntiAlias(true);
		((Control)PanelEx3).get_Controls().Add((Control)(object)lblDesc);
		((Control)PanelEx3).get_Controls().Add((Control)(object)PictureBox1);
		((Control)PanelEx3).set_Dock((DockStyle)2);
		PanelEx panelEx7 = PanelEx3;
		location = new Point(141, 573);
		((Control)panelEx7).set_Location(location);
		((Control)PanelEx3).set_Name("PanelEx3");
		PanelEx panelEx8 = PanelEx3;
		size = new Size(835, 77);
		((Control)panelEx8).set_Size(size);
		PanelEx3.get_Style().set_Alignment((StringAlignment)1);
		PanelEx3.get_Style().get_BackColor1().set_ColorSchemePart((eColorSchemePart)0);
		PanelEx3.get_Style().get_BackColor2().set_ColorSchemePart((eColorSchemePart)1);
		PanelEx3.get_Style().set_BackgroundImagePosition((eBackgroundImagePosition)2);
		PanelEx3.get_Style().get_ForeColor().set_ColorSchemePart((eColorSchemePart)36);
		PanelEx3.get_Style().set_GradientAngle(90);
		((Control)PanelEx3).set_TabIndex(7);
		ExpandableSplitter2.set_BackColor2(SystemColors.ControlDarkDark);
		ExpandableSplitter2.set_BackColor2SchemePart((eColorSchemePart)49);
		ExpandableSplitter2.set_BackColorSchemePart((eColorSchemePart)47);
		((Splitter)ExpandableSplitter2).set_Dock((DockStyle)2);
		ExpandableSplitter2.set_ExpandFillColor(SystemColors.ControlDarkDark);
		ExpandableSplitter2.set_ExpandFillColorSchemePart((eColorSchemePart)49);
		ExpandableSplitter2.set_ExpandLineColor(SystemColors.ControlText);
		ExpandableSplitter2.set_ExpandLineColorSchemePart((eColorSchemePart)36);
		ExpandableSplitter2.set_GripDarkColor(SystemColors.ControlText);
		ExpandableSplitter2.set_GripDarkColorSchemePart((eColorSchemePart)36);
		ExpandableSplitter2.set_GripLightColor(Color.FromArgb(252, 252, 252));
		ExpandableSplitter2.set_GripLightColorSchemePart((eColorSchemePart)0);
		ExpandableSplitter2.set_HotBackColor(Color.FromArgb(163, 209, 255));
		ExpandableSplitter2.set_HotBackColor2(Color.FromArgb(234, 244, 255));
		ExpandableSplitter2.set_HotBackColor2SchemePart((eColorSchemePart)31);
		ExpandableSplitter2.set_HotBackColorSchemePart((eColorSchemePart)30);
		ExpandableSplitter2.set_HotExpandFillColor(SystemColors.ControlDarkDark);
		ExpandableSplitter2.set_HotExpandFillColorSchemePart((eColorSchemePart)49);
		ExpandableSplitter2.set_HotExpandLineColor(SystemColors.ControlText);
		ExpandableSplitter2.set_HotExpandLineColorSchemePart((eColorSchemePart)36);
		ExpandableSplitter2.set_HotGripDarkColor(SystemColors.ControlDarkDark);
		ExpandableSplitter2.set_HotGripDarkColorSchemePart((eColorSchemePart)49);
		ExpandableSplitter2.set_HotGripLightColor(Color.FromArgb(252, 252, 252));
		ExpandableSplitter2.set_HotGripLightColorSchemePart((eColorSchemePart)0);
		ExpandableSplitter expandableSplitter3 = ExpandableSplitter2;
		location = new Point(141, 570);
		((Control)expandableSplitter3).set_Location(location);
		((Control)ExpandableSplitter2).set_Name("ExpandableSplitter2");
		ExpandableSplitter expandableSplitter4 = ExpandableSplitter2;
		size = new Size(835, 3);
		((Control)expandableSplitter4).set_Size(size);
		((Control)ExpandableSplitter2).set_TabIndex(8);
		((Splitter)ExpandableSplitter2).set_TabStop(false);
		CHServicesDependedOn.set_Text("Services Depended On");
		CHServicesDependedOn.set_Width(0);
		size = new Size(5, 14);
		((Form)this).set_AutoScaleBaseSize(size);
		size = new Size(976, 671);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)lvwServices);
		((Control)this).get_Controls().Add((Control)(object)ExpandableSplitter2);
		((Control)this).get_Controls().Add((Control)(object)PanelEx3);
		((Control)this).get_Controls().Add((Control)(object)PanelEx2);
		((Control)this).get_Controls().Add((Control)(object)ExpandableSplitter1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)barLeftDockSite);
		((Control)this).get_Controls().Add((Control)(object)barRightDockSite);
		((Control)this).get_Controls().Add((Control)(object)barTopDockSite);
		((Control)this).get_Controls().Add((Control)(object)barBottomDockSite);
		((Control)this).set_Font(new Font("Tahoma", 11f, (FontStyle)0, (GraphicsUnit)2, (byte)134));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("frmMain");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)Panel1).ResumeLayout(false);
		((Control)PanelEx4).ResumeLayout(false);
		((Control)PanelEx2).ResumeLayout(false);
		((Control)PanelEx2).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)PanelEx3).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void InitRegisterPWD()
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if (!DetectWindowsVersion.WindowsVersionOK())
		{
			ProjectData.EndApp();
		}
		((Form)this).set_Text(((ApplicationBase)MyProject.Application).get_Info().get_ProductName() + " " + Conversions.ToString(((ApplicationBase)MyProject.Application).get_Info().get_Version().Major) + "." + Conversions.ToString(((ApplicationBase)MyProject.Application).get_Info().get_Version().Minor));
		if (InstanceRunning.prevInstance())
		{
			MessageBox.Show(((Form)this).get_Text() + " 正在运行！", "提示", (MessageBoxButtons)0, (MessageBoxIcon)64);
			ProjectData.EndApp();
		}
		try
		{
			string text = MyClsDetermineRegister.DetermineRegistered();
			if (Operators.CompareString(text, "Registered", false) != 0)
			{
				if (Operators.CompareString(text, "Expired", false) != 0)
				{
					((Form)this).set_Text(((Form)this).get_Text() + " (Unregistered - " + text + " days left)");
				}
				else
				{
					ProjectData.EndApp();
				}
			}
			if (!DeterminePassword.DeterminePWD())
			{
				ProjectData.EndApp();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		RefreshService();
		if (Operators.CompareString(SubMain.Arg, "", false) != 0)
		{
			TimerFoused.set_Enabled(true);
		}
	}

	private void TimerFoused_Tick(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Component)(object)TimerFoused).Dispose();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = lvwServices.get_Items().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				if (Operators.CompareString(val.get_Text().ToLower(), SubMain.Arg.ToLower(), false) == 0)
				{
					val.EnsureVisible();
					val.set_Selected(true);
					((Control)lvwServices).Focus();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void frmMain_Resize(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)((Form)this).get_WindowState() == 2)
		{
			byte b = checked((byte)(lvwServices.get_Columns().get_Count() - 3));
			byte b2 = 0;
			while ((uint)b2 <= (uint)b)
			{
				lvwServices.get_Columns().get_Item((int)b2).set_Width(-2);
				checked
				{
					b2 = (byte)unchecked((uint)(b2 + 1));
				}
			}
		}
	}

	private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
	{
		ProjectData.EndApp();
	}

	private void rbSystemService_CheckedChanged(object sender, EventArgs e)
	{
		if (rbSystemService.get_Checked() && Operators.CompareString(Module2.WMIClassName, "Win32_Service", false) != 0)
		{
			Module2.WMIClassName = "Win32_Service";
			RefreshService();
		}
	}

	private void rbSystemDriver_CheckedChanged(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (rbSystemDriver.get_Checked() && Operators.CompareString(Module2.WMIClassName, "Win32_SystemDriver", false) != 0)
		{
			Module2.WMIClassName = "Win32_SystemDriver";
			MessageBox.Show("Please do not change any drivers if your system just" + Environment.NewLine + "works well or you are unfamiliar with computers!", "Warning", (MessageBoxButtons)0, (MessageBoxIcon)48);
			RefreshService();
		}
	}

	private void llOptimizeService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		((Control)llOptimizeService).set_Enabled(false);
		frmOptimizeServices frmOptimizeServices2 = new frmOptimizeServices();
		((Form)frmOptimizeServices2).ShowDialog();
		((Control)llOptimizeService).set_Enabled(true);
		((Control)this).set_Cursor(Cursors.get_Default());
	}

	private void lvwServices_SelectedIndexChanged(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (lvwServices.get_SelectedItems().get_Count() <= 0)
		{
			return;
		}
		try
		{
			if (Operators.CompareString(Module2.WMIClassName, "Win32_Service", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStartupTypeResotre")).set_Enabled(true);
			}
			else
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStartupTypeResotre")).set_Enabled(false);
			}
			lblDesc.set_Text(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(8)
				.get_Text() + Environment.NewLine + Environment.NewLine + "Services Depended On: " + lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(9)
				.get_Text());
			PictureBox1.set_Image((Image)(object)MyClsIcon.GetDefaultIcon(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(7)
				.get_Text(), (IconSize)0, "").ToBitmap());
			ButtonByServiceOrDrive();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void lvwServices_ColumnClick(object sender, ColumnClickEventArgs e)
	{
		clsListViewItemSorter.sortListView(lvwServices, e);
	}

	private void ButtonByServiceOrDrive()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		if (lvwServices.get_SelectedItems().get_Count() > 0)
		{
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BICheckOne")).set_Enabled(true);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIQueryInternet")).set_Enabled(true);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIFileProperty")).set_Enabled(true);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDelete")).set_Enabled(true);
			if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(4)
				.get_Text(), "Yes", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIOpenFolder")).set_Enabled(true);
			}
			else
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIOpenFolder")).set_Enabled(false);
			}
			if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(1)
				.get_Text(), "Running", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStart")).set_Enabled(false);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStop")).set_Enabled(true);
			}
			else if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text(), "Disabled", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStart")).set_Enabled(false);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStop")).set_Enabled(false);
			}
			else
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStart")).set_Enabled(true);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStop")).set_Enabled(false);
			}
			if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text(), "Disabled", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIAuto")).set_Enabled(true);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIManual")).set_Enabled(true);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDisable")).set_Enabled(false);
			}
			else if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text(), "Manual", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIAuto")).set_Enabled(true);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIManual")).set_Enabled(false);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDisable")).set_Enabled(true);
			}
			else if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(2)
				.get_Text(), "Auto", false) == 0)
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIAuto")).set_Enabled(false);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIManual")).set_Enabled(true);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDisable")).set_Enabled(true);
			}
			else
			{
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIAuto")).set_Enabled(false);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIManual")).set_Enabled(false);
				((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDisable")).set_Enabled(false);
			}
		}
		else
		{
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BICheckOne")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIFileProperty")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIQueryInternet")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDelete")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIOpenFolder")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStart")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIStop")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIAuto")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIManual")).set_Enabled(false);
			((BaseItem)(ButtonItem)DotNetBarManager1.GetItem("BIDisable")).set_Enabled(false);
		}
	}

	private void DotNetBarManager1_ItemClick(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Invalid comparison between Unknown and I4
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Expected O, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Invalid comparison between Unknown and I4
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Invalid comparison between Unknown and I4
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Invalid comparison between Unknown and I4
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		BaseItem val = (BaseItem)sender;
		if ((val == null) | (Operators.CompareString(val.get_Name(), "", false) == 0) | val.get_SystemItem())
		{
			return;
		}
		switch (NewLateBinding.LateGet(sender, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString())
		{
		case "BICheckOne":
			VerifyOne(lvwServices.get_SelectedItems().get_Item(0));
			break;
		case "BICheckAll":
			((Control)PanelEx4).set_Enabled(false);
			((Control)lvwServices).set_Enabled(false);
			((Control)barTopDockSite).set_Enabled(false);
			BackgroundWorker1.RunWorkerAsync();
			break;
		case "BIOptimize":
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			frmOptimizeServices frmOptimizeServices2 = new frmOptimizeServices();
			((Form)frmOptimizeServices2).ShowDialog();
			((Control)this).set_Cursor(Cursors.get_Default());
			break;
		}
		case "BIRefresh":
			RefreshService();
			break;
		case "BIFileProperty":
			try
			{
				SHELLEXECUTEINFO.ShowPropertiesDialog(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(7)
					.get_Text());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			break;
		case "BIOpenFolder":
			if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
				.get_Item(4)
				.get_Text(), "Yes", false) == 0)
			{
				try
				{
					Process.Start("explorer", "/e, /select, " + lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
						.get_Item(7)
						.get_Text());
				}
				catch (Exception projectError5)
				{
					ProjectData.SetProjectError(projectError5);
					ProjectData.ClearProjectError();
				}
			}
			break;
		case "BIQueryInternet":
		{
			string text2;
			if (Operators.CompareString(Module2.WMIClassName, "Win32_Service", false) == 0)
			{
				text2 = lvwServices.get_SelectedItems().get_Item(0).get_Text();
				if (Operators.CompareString(text2, "", false) != 0)
				{
					text2 += " service";
				}
			}
			else
			{
				text2 = lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(3)
					.get_Text();
				text2 = ((Operators.CompareString(text2, "", false) == 0) ? (lvwServices.get_SelectedItems().get_Item(0).get_Text() + " driver") : (Path.GetFileName(text2) + " driver"));
			}
			try
			{
				string name = Thread.CurrentThread.CurrentCulture.Name;
				Process.Start("http://www.google.com/search?hl=" + name + "&q=" + text2 + "&btnG=Google+%E6%90%9C%E7%B4%A2&lr=");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			break;
		}
		case "BIStart":
			try
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				string text4 = Module2.ManagerService(Module2.WMIClassName, Conversions.ToString(lvwServices.get_SelectedItems().get_Item(0).get_Tag()), Module2.ServiceMethod.StartService);
				if (Operators.CompareString(text4, "Success", false) == 0)
				{
					lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
						.get_Item(1)
						.set_Text("Running");
				}
				else
				{
					MessageBox.Show(text4);
				}
			}
			catch (Exception projectError7)
			{
				ProjectData.SetProjectError(projectError7);
				ProjectData.ClearProjectError();
			}
			finally
			{
				((Control)this).set_Cursor(Cursors.get_Default());
			}
			break;
		case "BIStop":
			try
			{
				((Control)this).set_Cursor(Cursors.get_WaitCursor());
				string text3 = Module2.ManagerService(Module2.WMIClassName, Conversions.ToString(lvwServices.get_SelectedItems().get_Item(0).get_Tag()), Module2.ServiceMethod.StopService);
				if (Operators.CompareString(text3, "Success", false) == 0)
				{
					lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
						.get_Item(1)
						.set_Text("Stopped");
				}
				else
				{
					MessageBox.Show(text3);
				}
			}
			catch (Exception projectError6)
			{
				ProjectData.SetProjectError(projectError6);
				ProjectData.ClearProjectError();
			}
			finally
			{
				((Control)this).set_Cursor(Cursors.get_Default());
			}
			break;
		case "BIAuto":
			SetToAuto(lvwServices.get_SelectedItems().get_Item(0));
			break;
		case "BIManual":
			SetToManual(lvwServices.get_SelectedItems().get_Item(0));
			break;
		case "BIDisable":
			SetToDisabled(lvwServices.get_SelectedItems().get_Item(0));
			break;
		case "BIRestoreAllStartupType":
		{
			if ((int)MessageBox.Show("Are you sure restore the startup mode of all services to system default?", "Restore Serivce", (MessageBoxButtons)4, (MessageBoxIcon)32) != 6)
			{
				break;
			}
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = lvwServices.get_Items().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ListViewItem val2 = (ListViewItem)enumerator.Current;
					try
					{
						val2.EnsureVisible();
						Module2.StartMode serviceDefaultStartType2 = Module2.GetServiceDefaultStartType(Conversions.ToString(val2.get_Tag()));
						if (serviceDefaultStartType2 != 0 && !serviceDefaultStartType2.ToString().Contains(val2.get_SubItems().get_Item(2).get_Text()))
						{
							val2.set_BackColor(Color.Red);
							Application.DoEvents();
							switch (serviceDefaultStartType2)
							{
							case Module2.StartMode.Automatic:
								SetToAuto(val2);
								break;
							case Module2.StartMode.Manual:
								SetToManual(val2);
								break;
							case Module2.StartMode.Disabled:
								SetToDisabled(val2);
								break;
							}
							val2.set_BackColor(Color.White);
							Application.DoEvents();
						}
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					Application.DoEvents();
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			((Control)this).set_Cursor(Cursors.get_Default());
			MessageBox.Show("Services restored, restart to take effect!", "Finish", (MessageBoxButtons)0, (MessageBoxIcon)64);
			break;
		}
		case "BIRestoreSelectedtStartupType":
			try
			{
				Module2.StartMode serviceDefaultStartType = Module2.GetServiceDefaultStartType(Conversions.ToString(lvwServices.get_SelectedItems().get_Item(0).get_Tag()));
				if (serviceDefaultStartType == Module2.StartMode.Boot)
				{
					MessageBox.Show("Unknown Startup Mode!", "Finish", (MessageBoxButtons)0, (MessageBoxIcon)64);
					return;
				}
				if (serviceDefaultStartType.ToString().Contains(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(2)
					.get_Text()))
				{
					MessageBox.Show(lvwServices.get_SelectedItems().get_Item(0).get_Text() + " is the default startup mode!", "Information", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
				else if ((int)MessageBox.Show("Are you sure to restore the startup mode of " + lvwServices.get_SelectedItems().get_Item(0).get_Text() + " to system default (" + serviceDefaultStartType.ToString() + ")?", "Restore Service", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
				{
					switch (serviceDefaultStartType)
					{
					case Module2.StartMode.Automatic:
						SetToAuto(lvwServices.get_SelectedItems().get_Item(0));
						break;
					case Module2.StartMode.Manual:
						SetToManual(lvwServices.get_SelectedItems().get_Item(0));
						break;
					case Module2.StartMode.Disabled:
						SetToDisabled(lvwServices.get_SelectedItems().get_Item(0));
						break;
					}
					MessageBox.Show("The service restored, restart to take effect!", "Finish", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
			break;
		case "BIDelete":
		{
			short num = checked((short)lvwServices.get_SelectedItems().get_Item(0).get_Index());
			try
			{
				if (Operators.CompareString(lvwServices.get_SelectedItems().get_Item(0).get_SubItems()
					.get_Item(4)
					.get_Text(), "Yes", false) == 0)
				{
					if ((int)MessageBox.Show(lvwServices.get_SelectedItems().get_Item(0).get_Text() + " is valid now, are you sure to delete it?", "Warning", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
					{
						return;
					}
				}
				else if ((int)MessageBox.Show("Are you sure to delete invalid" + lvwServices.get_SelectedItems().get_Item(0).get_Text() + " ?", "Warning", (MessageBoxButtons)4, (MessageBoxIcon)48) == 7)
				{
					return;
				}
				string text = Module2.ManagerService(Module2.WMIClassName, Conversions.ToString(lvwServices.get_SelectedItems().get_Item(0).get_Tag()), Module2.ServiceMethod.Delete);
				if (Operators.CompareString(text, "Success", false) == 0)
				{
					ListViewMoveToNext.DeleteMoveToNext(lvwServices);
				}
				else
				{
					MessageBox.Show(text + "!", "Finish", (MessageBoxButtons)0, (MessageBoxIcon)64);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (lvwServices.get_Items().get_Count() > 0)
			{
				if (num != lvwServices.get_Items().get_Count())
				{
					lvwServices.get_Items().get_Item((int)num).set_Selected(true);
				}
				else
				{
					lvwServices.get_Items().get_Item(0).set_Selected(true);
				}
			}
			((Control)lvwServices).Focus();
			break;
		}
		case "BIExit":
			((Form)this).Close();
			break;
		}
		lvwServices_SelectedIndexChanged(null, null);
	}

	private void SetToAuto(ListViewItem LVI)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string text = Module2.ManagerService(Module2.WMIClassName, Conversions.ToString(LVI.get_Tag()), Module2.ServiceMethod.ChangeStartMode, Module2.StartMode.Automatic);
			if (Operators.CompareString(text, "Success", false) == 0)
			{
				LVI.get_SubItems().get_Item(2).set_Text("Auto");
				lvwServices_SelectedIndexChanged(null, null);
			}
			else
			{
				MessageBox.Show(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void SetToManual(ListViewItem LVI)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string text = Module2.ManagerService(Module2.WMIClassName, Conversions.ToString(LVI.get_Tag()), Module2.ServiceMethod.ChangeStartMode, Module2.StartMode.Manual);
			if (Operators.CompareString(text, "Success", false) == 0)
			{
				LVI.get_SubItems().get_Item(2).set_Text("Manual");
				lvwServices_SelectedIndexChanged(null, null);
			}
			else
			{
				MessageBox.Show(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void SetToDisabled(ListViewItem LVI)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			string text = Module2.ManagerService(Module2.WMIClassName, Conversions.ToString(LVI.get_Tag()), Module2.ServiceMethod.ChangeStartMode, Module2.StartMode.Disabled);
			if (Operators.CompareString(text, "Success", false) == 0)
			{
				LVI.get_SubItems().get_Item(2).set_Text("Disabled");
				lvwServices_SelectedIndexChanged(null, null);
			}
			else
			{
				MessageBox.Show(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		finally
		{
			((Control)this).set_Cursor(Cursors.get_Default());
		}
	}

	private void RefreshService()
	{
		frmInit frmInit2 = new frmInit();
		((Control)frmInit2).Show();
		Application.DoEvents();
		((Control)this).set_Cursor(Cursors.get_WaitCursor());
		DotNetBarManager1.get_Bars().get_Item("statusBar1").get_Items()
			.get_Item("LIStatus")
			.set_Text("Receiving services and drivers...");
		Application.DoEvents();
		objServiceManager.GetAllServicesDrivers(lvwServices, ilService);
		if (Operators.CompareString(Module2.WMIClassName, "Win32_Service", false) == 0)
		{
			DotNetBarManager1.get_Bars().get_Item("statusBar1").get_Items()
				.get_Item("LIType")
				.set_Text("Current Type: System Service");
		}
		else
		{
			DotNetBarManager1.get_Bars().get_Item("statusBar1").get_Items()
				.get_Item("LIType")
				.set_Text("Current Type: System Driver");
		}
		DotNetBarManager1.get_Bars().get_Item("statusBar1").get_Items()
			.get_Item("LIStatus")
			.set_Text("Total " + Conversions.ToString(lvwServices.get_Items().get_Count()));
		((Form)frmInit2).Close();
		((Control)this).set_Cursor(Cursors.get_Default());
		lvwServices.get_Items().get_Item(0).set_Selected(true);
		((Control)lvwServices).Focus();
	}

	private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = lvwServices.get_Items().GetEnumerator();
			while (enumerator.MoveNext())
			{
				ListViewItem val = (ListViewItem)enumerator.Current;
				val.EnsureVisible();
				VerifyOne(val);
				Application.DoEvents();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)PanelEx4).set_Enabled(true);
		((Control)lvwServices).set_Enabled(true);
		((Control)barTopDockSite).set_Enabled(true);
	}

	private void VerifyOne(ListViewItem ListViemItem)
	{
		ListViemItem.set_ForeColor(Color.Black);
		string signer = GetDigitalSigner.GetSigner(ListViemItem.get_SubItems().get_Item(7).get_Text());
		if (signer.ToLower().Contains("microsoft"))
		{
			ListViemItem.get_SubItems().get_Item(6).set_Text("Microsoft(Safety)");
		}
		else if (Operators.CompareString(signer, "", false) == 0)
		{
			ListViemItem.get_SubItems().get_Item(6).set_Text("Unknown");
			ListViemItem.set_ForeColor(Color.Red);
		}
		else
		{
			ListViemItem.get_SubItems().get_Item(6).set_Text(signer);
			ListViemItem.set_ForeColor(Color.DarkOrange);
		}
		Application.DoEvents();
	}
}
