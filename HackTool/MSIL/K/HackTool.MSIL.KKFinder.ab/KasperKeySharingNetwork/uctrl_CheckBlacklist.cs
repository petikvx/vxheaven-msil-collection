using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using KasperKeySharingNetwork.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class uctrl_CheckBlacklist : UserControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("lbl_Three")]
	private ReflectionLabel _lbl_Three;

	[AccessedThroughProperty("lbl_Two")]
	private ReflectionLabel _lbl_Two;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBarX _ProgressBar1;

	[AccessedThroughProperty("btn_NO")]
	private ButtonX _btn_NO;

	[AccessedThroughProperty("btn_Yes")]
	private ButtonX _btn_Yes;

	[AccessedThroughProperty("lbl_One")]
	private ReflectionLabel _lbl_One;

	[AccessedThroughProperty("bg_Blacklist")]
	private BackgroundWorker _bg_Blacklist;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("rbtn_ManualLocation")]
	private RadioButton _rbtn_ManualLocation;

	[AccessedThroughProperty("rbtn_AutomaticLocation")]
	private RadioButton _rbtn_AutomaticLocation;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("gbx_Auto")]
	private GroupBox _gbx_Auto;

	[AccessedThroughProperty("gbx_Manual")]
	private GroupBox _gbx_Manual;

	[AccessedThroughProperty("rbtn_Download")]
	private RadioButton _rbtn_Download;

	[AccessedThroughProperty("rbtn_Serach")]
	private RadioButton _rbtn_Serach;

	[AccessedThroughProperty("rbtn_AllDrive")]
	private RadioButton _rbtn_AllDrive;

	[AccessedThroughProperty("txbx_Auto")]
	private TextBoxX _txbx_Auto;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("txbx_Manual")]
	private TextBoxX _txbx_Manual;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	private string BlackFileLocation;

	private int ProcedureToFollow;

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
			EventHandler eventHandler = Label1_TextChanged;
			if (_Label1 != null)
			{
				((Control)_Label1).remove_TextChanged(eventHandler);
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual ReflectionLabel lbl_Three
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_Three;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_Three = value;
		}
	}

	internal virtual ReflectionLabel lbl_Two
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_Two;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_Two = value;
		}
	}

	internal virtual ProgressBarX ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual ButtonX btn_NO
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_NO;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btn_NO_Click;
			if (_btn_NO != null)
			{
				((Control)_btn_NO).remove_Click(eventHandler);
			}
			_btn_NO = value;
			if (_btn_NO != null)
			{
				((Control)_btn_NO).add_Click(eventHandler);
			}
		}
	}

	internal virtual ButtonX btn_Yes
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_Yes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = btn_Yes_Click;
			if (_btn_Yes != null)
			{
				((Control)_btn_Yes).remove_Click(eventHandler);
			}
			_btn_Yes = value;
			if (_btn_Yes != null)
			{
				((Control)_btn_Yes).add_Click(eventHandler);
			}
		}
	}

	internal virtual ReflectionLabel lbl_One
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_One;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_One = value;
		}
	}

	internal virtual BackgroundWorker bg_Blacklist
	{
		[DebuggerNonUserCode]
		get
		{
			return _bg_Blacklist;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = bg_Blacklist_DoWork;
			ProgressChangedEventHandler value3 = bg_Blacklist_ProgressChanged;
			if (_bg_Blacklist != null)
			{
				_bg_Blacklist.DoWork -= value2;
				_bg_Blacklist.ProgressChanged -= value3;
			}
			_bg_Blacklist = value;
			if (_bg_Blacklist != null)
			{
				_bg_Blacklist.DoWork += value2;
				_bg_Blacklist.ProgressChanged += value3;
			}
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
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual RadioButton rbtn_ManualLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtn_ManualLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = ManualLocation_CheckedChanged;
			MouseEventHandler val = new MouseEventHandler(ManualLocation_MouseClick);
			if (_rbtn_ManualLocation != null)
			{
				_rbtn_ManualLocation.remove_CheckedChanged(eventHandler);
				((Control)_rbtn_ManualLocation).remove_MouseClick(val);
			}
			_rbtn_ManualLocation = value;
			if (_rbtn_ManualLocation != null)
			{
				_rbtn_ManualLocation.add_CheckedChanged(eventHandler);
				((Control)_rbtn_ManualLocation).add_MouseClick(val);
			}
		}
	}

	internal virtual RadioButton rbtn_AutomaticLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtn_AutomaticLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AutomaticLocation_CheckedChanged;
			if (_rbtn_AutomaticLocation != null)
			{
				_rbtn_AutomaticLocation.remove_CheckedChanged(eventHandler);
			}
			_rbtn_AutomaticLocation = value;
			if (_rbtn_AutomaticLocation != null)
			{
				_rbtn_AutomaticLocation.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual OpenFileDialog OpenFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _OpenFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_OpenFileDialog1 = value;
		}
	}

	internal virtual GroupBox gbx_Auto
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbx_Auto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbx_Auto = value;
		}
	}

	internal virtual GroupBox gbx_Manual
	{
		[DebuggerNonUserCode]
		get
		{
			return _gbx_Manual;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_gbx_Manual = value;
		}
	}

	internal virtual RadioButton rbtn_Download
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtn_Download;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbtn_Download = value;
		}
	}

	internal virtual RadioButton rbtn_Serach
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtn_Serach;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbtn_Serach = value;
		}
	}

	internal virtual RadioButton rbtn_AllDrive
	{
		[DebuggerNonUserCode]
		get
		{
			return _rbtn_AllDrive;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_rbtn_AllDrive = value;
		}
	}

	internal virtual TextBoxX txbx_Auto
	{
		[DebuggerNonUserCode]
		get
		{
			return _txbx_Auto;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txbx_Auto = value;
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

	internal virtual TextBoxX txbx_Manual
	{
		[DebuggerNonUserCode]
		get
		{
			return _txbx_Manual;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txbx_Manual = value;
		}
	}

	internal virtual FolderBrowserDialog FolderBrowserDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _FolderBrowserDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FolderBrowserDialog1 = value;
		}
	}

	public uctrl_CheckBlacklist()
	{
		((Control)this).add_EnabledChanged((EventHandler)uctrl_CheckBlacklist_EnabledChanged);
		((UserControl)this).add_Load((EventHandler)uctrl_CheckBlacklist_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		BlackFileLocation = "";
		ProcedureToFollow = 0;
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
			((ContainerControl)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		lbl_Three = new ReflectionLabel();
		lbl_Two = new ReflectionLabel();
		ProgressBar1 = new ProgressBarX();
		btn_NO = new ButtonX();
		btn_Yes = new ButtonX();
		lbl_One = new ReflectionLabel();
		bg_Blacklist = new BackgroundWorker();
		Timer1 = new Timer(components);
		rbtn_ManualLocation = new RadioButton();
		rbtn_AutomaticLocation = new RadioButton();
		OpenFileDialog1 = new OpenFileDialog();
		gbx_Auto = new GroupBox();
		Button1 = new Button();
		txbx_Auto = new TextBoxX();
		rbtn_Download = new RadioButton();
		rbtn_Serach = new RadioButton();
		rbtn_AllDrive = new RadioButton();
		gbx_Manual = new GroupBox();
		Button2 = new Button();
		txbx_Manual = new TextBoxX();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		((Control)gbx_Auto).SuspendLayout();
		((Control)gbx_Manual).SuspendLayout();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		Label label = Label1;
		Point location = new Point(162, 161);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		Size size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(13);
		Label1.set_Text("Label1");
		((Control)lbl_Three).set_BackColor(Color.Transparent);
		ReflectionLabel reflectionLabel = lbl_Three;
		location = new Point(278, 97);
		((Control)reflectionLabel).set_Location(location);
		((Control)lbl_Three).set_Name("lbl_Three");
		ReflectionLabel reflectionLabel2 = lbl_Three;
		size = new Size(105, 37);
		((Control)reflectionLabel2).set_Size(size);
		((Control)lbl_Three).set_TabIndex(12);
		lbl_Three.Text = "<font size=\"+2\"><font color=\"#B02B2C\">Please standby..</font></font>";
		((Control)lbl_Three).set_Visible(false);
		((Control)lbl_Two).set_BackColor(Color.Transparent);
		ReflectionLabel reflectionLabel3 = lbl_Two;
		location = new Point(67, 91);
		((Control)reflectionLabel3).set_Location(location);
		((Control)lbl_Two).set_Name("lbl_Two");
		ReflectionLabel reflectionLabel4 = lbl_Two;
		size = new Size(212, 48);
		((Control)reflectionLabel4).set_Size(size);
		((Control)lbl_Two).set_TabIndex(11);
		lbl_Two.Text = "<b><font size=\"+6\"><font color=\"#B02B2C\">Retrieving </font><i>Blacklist </i><font color=\"#B02B2C\">file.</font></font></b> ";
		((Control)lbl_Two).set_Visible(false);
		((Control)ProgressBar1).set_BackColor(Color.Transparent);
		ProgressBar1.ChunkColor = Color.Red;
		ProgressBar1.ChunkColor2 = Color.Yellow;
		ProgressBarX progressBar = ProgressBar1;
		location = new Point(111, 64);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar1.ProgressType = eProgressItemType.Marquee;
		ProgressBarX progressBar2 = ProgressBar1;
		size = new Size(248, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(10);
		((Control)ProgressBar1).set_Text("ProgressBarX1");
		((Control)ProgressBar1).set_Visible(false);
		((Control)btn_NO).set_AccessibleRole((AccessibleRole)43);
		((Control)btn_NO).set_BackColor(Color.Transparent);
		btn_NO.ColorTable = eButtonColor.Office2007WithBackground;
		btn_NO.DialogResult = (DialogResult)7;
		((Control)btn_NO).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		ButtonX buttonX = btn_NO;
		location = new Point(157, 77);
		((Control)buttonX).set_Location(location);
		((Control)btn_NO).set_Name("btn_NO");
		btn_NO.Shape = new RoundRectangleShapeDescriptor(10);
		ButtonX buttonX2 = btn_NO;
		size = new Size(75, 23);
		((Control)buttonX2).set_Size(size);
		((Control)btn_NO).set_TabIndex(9);
		btn_NO.Text = "No";
		((Control)btn_Yes).set_AccessibleRole((AccessibleRole)43);
		((Control)btn_Yes).set_BackColor(Color.Transparent);
		btn_Yes.ColorTable = eButtonColor.BlueOrb;
		btn_Yes.DialogResult = (DialogResult)6;
		((Control)btn_Yes).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		ButtonX buttonX3 = btn_Yes;
		location = new Point(238, 77);
		((Control)buttonX3).set_Location(location);
		((Control)btn_Yes).set_Name("btn_Yes");
		btn_Yes.Shape = new RoundRectangleShapeDescriptor(10);
		ButtonX buttonX4 = btn_Yes;
		size = new Size(75, 23);
		((Control)buttonX4).set_Size(size);
		((Control)btn_Yes).set_TabIndex(8);
		btn_Yes.Text = "Yes";
		((Control)lbl_One).set_BackColor(Color.Transparent);
		ReflectionLabel reflectionLabel5 = lbl_One;
		location = new Point(29, 4);
		((Control)reflectionLabel5).set_Location(location);
		((Control)lbl_One).set_Name("lbl_One");
		ReflectionLabel reflectionLabel6 = lbl_One;
		size = new Size(413, 74);
		((Control)reflectionLabel6).set_Size(size);
		((Control)lbl_One).set_TabIndex(7);
		lbl_One.Text = "<b><font size=\"+6\"><font color=\"#B02B2C\">Do you wish to view the Keys </font><i>Blacklist </i><font color=\"#B02B2C\">Status? </font></font></b>";
		bg_Blacklist.WorkerReportsProgress = true;
		bg_Blacklist.WorkerSupportsCancellation = true;
		((ButtonBase)rbtn_ManualLocation).set_AutoSize(true);
		RadioButton obj = rbtn_ManualLocation;
		location = new Point(78, 104);
		((Control)obj).set_Location(location);
		((Control)rbtn_ManualLocation).set_Name("rbtn_ManualLocation");
		RadioButton obj2 = rbtn_ManualLocation;
		size = new Size(107, 17);
		((Control)obj2).set_Size(size);
		((Control)rbtn_ManualLocation).set_TabIndex(14);
		((ButtonBase)rbtn_ManualLocation).set_Text("Manual Location.");
		((ButtonBase)rbtn_ManualLocation).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbtn_AutomaticLocation).set_AutoSize(true);
		rbtn_AutomaticLocation.set_Checked(true);
		RadioButton obj3 = rbtn_AutomaticLocation;
		location = new Point(285, 104);
		((Control)obj3).set_Location(location);
		((Control)rbtn_AutomaticLocation).set_Name("rbtn_AutomaticLocation");
		RadioButton obj4 = rbtn_AutomaticLocation;
		size = new Size(119, 17);
		((Control)obj4).set_Size(size);
		((Control)rbtn_AutomaticLocation).set_TabIndex(14);
		rbtn_AutomaticLocation.set_TabStop(true);
		((ButtonBase)rbtn_AutomaticLocation).set_Text("Automatic Location.");
		((ButtonBase)rbtn_AutomaticLocation).set_UseVisualStyleBackColor(true);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((Control)gbx_Auto).get_Controls().Add((Control)(object)Button1);
		((Control)gbx_Auto).get_Controls().Add((Control)(object)txbx_Auto);
		((Control)gbx_Auto).get_Controls().Add((Control)(object)rbtn_Download);
		((Control)gbx_Auto).get_Controls().Add((Control)(object)rbtn_Serach);
		((Control)gbx_Auto).get_Controls().Add((Control)(object)rbtn_AllDrive);
		GroupBox obj5 = gbx_Auto;
		location = new Point(247, 119);
		((Control)obj5).set_Location(location);
		((Control)gbx_Auto).set_Name("gbx_Auto");
		GroupBox obj6 = gbx_Auto;
		size = new Size(207, 71);
		((Control)obj6).set_Size(size);
		((Control)gbx_Auto).set_TabIndex(15);
		gbx_Auto.set_TabStop(false);
		Button button = Button1;
		location = new Point(181, 27);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		size = new Size(20, 20);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("..");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		txbx_Auto.Border.Class = "TextBoxBorder";
		TextBoxX textBoxX = txbx_Auto;
		location = new Point(63, 27);
		((Control)textBoxX).set_Location(location);
		((Control)txbx_Auto).set_Name("txbx_Auto");
		TextBoxX textBoxX2 = txbx_Auto;
		size = new Size(117, 20);
		((Control)textBoxX2).set_Size(size);
		((Control)txbx_Auto).set_TabIndex(3);
		txbx_Auto.WatermarkBehavior = eWatermarkBehavior.HideNonEmpty;
		txbx_Auto.WatermarkText = "Choose folder/drive";
		((ButtonBase)rbtn_Download).set_AutoSize(true);
		RadioButton obj7 = rbtn_Download;
		location = new Point(6, 50);
		((Control)obj7).set_Location(location);
		((Control)rbtn_Download).set_Name("rbtn_Download");
		RadioButton obj8 = rbtn_Download;
		size = new Size(122, 17);
		((Control)obj8).set_Size(size);
		((Control)rbtn_Download).set_TabIndex(2);
		((ButtonBase)rbtn_Download).set_Text("Download the latest.");
		((ButtonBase)rbtn_Download).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbtn_Serach).set_AutoSize(true);
		RadioButton obj9 = rbtn_Serach;
		location = new Point(6, 29);
		((Control)obj9).set_Location(location);
		((Control)rbtn_Serach).set_Name("rbtn_Serach");
		RadioButton obj10 = rbtn_Serach;
		size = new Size(62, 17);
		((Control)obj10).set_Size(size);
		((Control)rbtn_Serach).set_TabIndex(1);
		((ButtonBase)rbtn_Serach).set_Text("Search:");
		((ButtonBase)rbtn_Serach).set_UseVisualStyleBackColor(true);
		((ButtonBase)rbtn_AllDrive).set_AutoSize(true);
		rbtn_AllDrive.set_Checked(true);
		RadioButton obj11 = rbtn_AllDrive;
		location = new Point(6, 9);
		((Control)obj11).set_Location(location);
		((Control)rbtn_AllDrive).set_Name("rbtn_AllDrive");
		RadioButton obj12 = rbtn_AllDrive;
		size = new Size(109, 17);
		((Control)obj12).set_Size(size);
		((Control)rbtn_AllDrive).set_TabIndex(0);
		rbtn_AllDrive.set_TabStop(true);
		((ButtonBase)rbtn_AllDrive).set_Text("Search All Drives.");
		((ButtonBase)rbtn_AllDrive).set_UseVisualStyleBackColor(true);
		((Control)gbx_Manual).get_Controls().Add((Control)(object)Button2);
		((Control)gbx_Manual).get_Controls().Add((Control)(object)txbx_Manual);
		GroupBox obj13 = gbx_Manual;
		location = new Point(27, 119);
		((Control)obj13).set_Location(location);
		((Control)gbx_Manual).set_Name("gbx_Manual");
		GroupBox obj14 = gbx_Manual;
		size = new Size(207, 71);
		((Control)obj14).set_Size(size);
		((Control)gbx_Manual).set_TabIndex(17);
		gbx_Manual.set_TabStop(false);
		Button button3 = Button2;
		location = new Point(184, 25);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(17, 20);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(16);
		((ButtonBase)Button2).set_Text("..");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		txbx_Manual.Border.Class = "TextBoxBorder";
		TextBoxX textBoxX3 = txbx_Manual;
		location = new Point(6, 25);
		((Control)textBoxX3).set_Location(location);
		((Control)txbx_Manual).set_Name("txbx_Manual");
		TextBoxX textBoxX4 = txbx_Manual;
		size = new Size(178, 20);
		((Control)textBoxX4).set_Size(size);
		((Control)txbx_Manual).set_TabIndex(15);
		txbx_Manual.WatermarkBehavior = eWatermarkBehavior.HideNonEmpty;
		txbx_Manual.WatermarkText = "Choose the \"black.lst\" File";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)rbtn_ManualLocation);
		((Control)this).get_Controls().Add((Control)(object)gbx_Manual);
		((Control)this).get_Controls().Add((Control)(object)rbtn_AutomaticLocation);
		((Control)this).get_Controls().Add((Control)(object)gbx_Auto);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)btn_NO);
		((Control)this).get_Controls().Add((Control)(object)btn_Yes);
		((Control)this).get_Controls().Add((Control)(object)lbl_One);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)lbl_Two);
		((Control)this).get_Controls().Add((Control)(object)lbl_Three);
		((Control)this).set_Name("uctrl_CheckBlacklist");
		size = new Size(471, 195);
		((Control)this).set_Size(size);
		((Control)gbx_Auto).ResumeLayout(false);
		((Control)gbx_Auto).PerformLayout();
		((Control)gbx_Manual).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btn_Yes_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		BlackFileLocation = "";
		ProcedureToFollow = 0;
		if (rbtn_ManualLocation.get_Checked())
		{
			if (Operators.CompareString(((TextBox)txbx_Manual).get_Text(), "", false) == 0)
			{
				Interaction.MsgBox((object)"You must select the 'blacl.lst' file.", (MsgBoxStyle)0, (object)null);
				return;
			}
			ProcedureToFollow = 1;
			BlackFileLocation = ((TextBox)txbx_Manual).get_Text();
		}
		else
		{
			if (!rbtn_AutomaticLocation.get_Checked())
			{
				return;
			}
			if (rbtn_AllDrive.get_Checked())
			{
				ProcedureToFollow = 2;
			}
			else if (rbtn_Serach.get_Checked())
			{
				if (Operators.CompareString(((TextBox)txbx_Auto).get_Text(), "", false) == 0)
				{
					Interaction.MsgBox((object)"You must select a location to search from.", (MsgBoxStyle)0, (object)null);
					return;
				}
				ProcedureToFollow = 3;
				BlackFileLocation = ((TextBox)txbx_Auto).get_Text();
			}
			else if (rbtn_Download.get_Checked())
			{
				ProcedureToFollow = 4;
			}
		}
		((Control)btn_NO).set_Visible(false);
		((Control)btn_Yes).set_Visible(false);
		((Control)lbl_One).set_Visible(false);
		((Control)rbtn_AutomaticLocation).set_Visible(false);
		((Control)rbtn_ManualLocation).set_Visible(false);
		((Control)gbx_Auto).set_Visible(false);
		((Control)gbx_Manual).set_Visible(false);
		((Control)lbl_Two).set_Visible(true);
		((Control)lbl_Three).set_Visible(true);
		((Control)ProgressBar1).set_Visible(true);
		bg_Blacklist.WorkerReportsProgress = true;
		bg_Blacklist.RunWorkerAsync();
		while (bg_Blacklist.IsBusy)
		{
			Application.DoEvents();
		}
		((Control)this).Hide();
		((Control)btn_NO).set_Visible(true);
		((Control)btn_Yes).set_Visible(true);
		((Control)lbl_One).set_Visible(true);
		((Control)rbtn_AutomaticLocation).set_Visible(true);
		((Control)rbtn_ManualLocation).set_Visible(true);
		if (rbtn_ManualLocation.get_Checked())
		{
			((Control)gbx_Manual).set_Visible(true);
		}
		if (rbtn_AutomaticLocation.get_Checked())
		{
			((Control)gbx_Auto).set_Visible(true);
		}
		((Control)lbl_Two).set_Visible(false);
		((Control)lbl_Three).set_Visible(false);
		((Control)ProgressBar1).set_Visible(false);
		bg_Blacklist.WorkerReportsProgress = false;
		((Control)this).set_Enabled(false);
		((Control)this).set_Visible(false);
	}

	private void bg_Blacklist_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		Timer1.set_Enabled(true);
		Timer1.set_Interval(50);
		Timer1.Start();
		BlacklistViewer.Download.Overwrite = true;
		BlacklistViewer.FileName_Path = BlackFileLocation;
		BlacklistViewer.FileInfo.Uppercase = true;
		if (!BlacklistViewer.Functions.AnalyzeFile(ProcedureToFollow))
		{
			string processStage = BlacklistViewer.ProcessStage;
			string text = "";
			text = processStage switch
			{
				"Checking Network Availability." => "Unable to Download Blacklist file, Check the Network Connection.", 
				"Determining the File Name." => "Unable to Find the Blacklist file.", 
				"Unable to Find the Local Blacklist file." => "Unable to Find the Blacklist file.", 
				"Unable to Download the Blacklist file." => "Unable to Download Blacklist file.", 
				_ => "Unable to Locate, Download or Read the Blacklist file.", 
			};
			if ((Operators.CompareString(processStage, "Converting Data.", false) == 0) | (Operators.CompareString(processStage, "Analyzing Data Header.", false) == 0) | (Operators.CompareString(processStage, "Analyzing Data Footer.", false) == 0) | (Operators.CompareString(processStage, "Processing Key List.", false) == 0) | (Operators.CompareString(processStage, "Reading the Blacklist File", false) == 0))
			{
				text = "Unable to Read the Blacklist File.";
			}
			if (processStage.StartsWith("Downloading the Blacklist File, Try # "))
			{
				text = "Unable to Download Blacklist file.";
			}
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
			BlackFileLocation = "";
			rbtn_AutomaticLocation.set_Checked(true);
			rbtn_ManualLocation.set_Checked(false);
		}
		Timer1.Stop();
		((Component)(object)Timer1).Dispose();
		Timer1.set_Enabled(false);
	}

	private void btn_NO_Click(object sender, EventArgs e)
	{
		((Control)this).set_Enabled(false);
		((Control)this).set_Visible(false);
	}

	private void uctrl_CheckBlacklist_EnabledChanged(object sender, EventArgs e)
	{
		Label1.set_Text("");
		CenterLabel();
		rbtn_AutomaticLocation.set_Checked(true);
		rbtn_ManualLocation.set_Checked(false);
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "enabled", new object[0], (string[])null, (Type[])null, (bool[])null)) && BlacklistViewer.FileInfo.KeyList.Length > 0)
		{
			((Control)this).set_Enabled(false);
			((Control)this).set_Visible(false);
		}
	}

	private void uctrl_CheckBlacklist_Load(object sender, EventArgs e)
	{
		rbtn_AutomaticLocation.set_Checked(true);
		rbtn_ManualLocation.set_Checked(false);
		if (BlacklistViewer.FileInfo.KeyList.Length > 0)
		{
			((Control)this).set_Visible(false);
			((Control)this).set_Enabled(false);
			((Control)MyProject.Forms.form_KeyViewer).Show();
		}
	}

	private void bg_Blacklist_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		Label1.set_Text(BlacklistViewer.ProcessStage);
		CenterLabel();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		bg_Blacklist.ReportProgress(100);
	}

	private void Label1_TextChanged(object sender, EventArgs e)
	{
		CenterLabel();
	}

	private void CenterLabel()
	{
		checked
		{
			int num = (int)Math.Round((double)((Control)Label1).get_Width() / 2.0);
			int num2 = (int)Math.Round((double)((Control)this).get_Width() / 2.0);
			Label label = Label1;
			Point location = new Point(num2 - num, ((Control)Label1).get_Location().Y);
			((Control)label).set_Location(location);
		}
	}

	private void ManualLocation_MouseClick(object sender, MouseEventArgs e)
	{
	}

	private void ManualLocation_CheckedChanged(object sender, EventArgs e)
	{
		rbtn_AutomaticLocation.set_Checked(Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(sender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null))));
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			((Control)gbx_Manual).set_Visible(true);
			((Control)gbx_Auto).set_Visible(false);
			((Control)rbtn_AutomaticLocation).set_Visible(true);
		}
	}

	private void AutomaticLocation_CheckedChanged(object sender, EventArgs e)
	{
		rbtn_ManualLocation.set_Checked(Conversions.ToBoolean(Operators.NotObject(NewLateBinding.LateGet(sender, (Type)null, "Checked", new object[0], (string[])null, (Type[])null, (bool[])null))));
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "checked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			((Control)gbx_Auto).set_Visible(true);
			((Control)gbx_Manual).set_Visible(false);
			((Control)rbtn_ManualLocation).set_Visible(true);
		}
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Invalid comparison between Unknown and I4
		OpenFileDialog1.set_CheckFileExists(true);
		((FileDialog)OpenFileDialog1).set_CheckPathExists(true);
		((FileDialog)OpenFileDialog1).set_DefaultExt("lst");
		((FileDialog)OpenFileDialog1).set_Filter("Kasperskey Blacklist (*.lst)|*.lst|All Files (*.*)|*.*");
		OpenFileDialog1.set_Multiselect(false);
		((FileDialog)OpenFileDialog1).set_Title("Load the Kasperskey Blacklist File.");
		((FileDialog)OpenFileDialog1).set_FileName("");
		((FileDialog)OpenFileDialog1).set_InitialDirectory(Directory.GetCurrentDirectory());
		if ((int)((CommonDialog)OpenFileDialog1).ShowDialog() != 2)
		{
			((TextBox)txbx_Manual).set_Text(((FileDialog)OpenFileDialog1).get_FileName());
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		FolderBrowserDialog1.set_Description("Black.lst Location.");
		FolderBrowserDialog1.set_ShowNewFolderButton(true);
		if ((int)((CommonDialog)FolderBrowserDialog1).ShowDialog() != 2)
		{
			((TextBox)txbx_Auto).set_Text(FolderBrowserDialog1.get_SelectedPath());
		}
	}
}
