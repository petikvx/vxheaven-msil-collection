using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using KasperKeySharingNetwork.My;
using KasperKeySharingNetwork.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class cls_KasperKeySharingNetwork : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dgv_TheList")]
	private DataGridView _dgv_TheList;

	[AccessedThroughProperty("SelectDeselectAll")]
	private CheckBox _SelectDeselectAll;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ts_Networklabel")]
	private ToolStripStatusLabel _ts_Networklabel;

	[AccessedThroughProperty("ts_TotalFiles")]
	private ToolStripStatusLabel _ts_TotalFiles;

	[AccessedThroughProperty("ts_TheMessageLabel")]
	private ToolStripStatusLabel _ts_TheMessageLabel;

	[AccessedThroughProperty("ts_ProgressBar")]
	private ToolStripProgressBar _ts_ProgressBar;

	[AccessedThroughProperty("ts_FileNumbers")]
	private ToolStripStatusLabel _ts_FileNumbers;

	[AccessedThroughProperty("cms_TheListMenu")]
	private ContextMenuStrip _cms_TheListMenu;

	[AccessedThroughProperty("tsm_ShowAvailKeys")]
	private ToolStripMenuItem _tsm_ShowAvailKeys;

	[AccessedThroughProperty("tsm_DownloadSelectedKeys")]
	private ToolStripMenuItem _tsm_DownloadSelectedKeys;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("tsm_SelectHighlighted")]
	private ToolStripMenuItem _tsm_SelectHighlighted;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("tsm_DownloadLocation")]
	private ToolStripMenuItem _tsm_DownloadLocation;

	[AccessedThroughProperty("tsm_Exit")]
	private ToolStripMenuItem _tsm_Exit;

	[AccessedThroughProperty("tsm_DeselectHighlighted")]
	private ToolStripMenuItem _tsm_DeselectHighlighted;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("bg_KeyList")]
	private BackgroundWorker _bg_KeyList;

	[AccessedThroughProperty("bg_DownloadKey")]
	private BackgroundWorker _bg_DownloadKey;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("ToolStrip1")]
	private ToolStrip _ToolStrip1;

	[AccessedThroughProperty("tsb_ListKeys")]
	private ToolStripButton _tsb_ListKeys;

	[AccessedThroughProperty("tsb_DownloadKey")]
	private ToolStripButton _tsb_DownloadKey;

	[AccessedThroughProperty("tsb_Stop")]
	private ToolStripButton _tsb_Stop;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("tstb_DownloadLocation")]
	private ToolStripTextBox _tstb_DownloadLocation;

	[AccessedThroughProperty("tsb_DownloadLocation")]
	private ToolStripButton _tsb_DownloadLocation;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("ToolStripSeparator7")]
	private ToolStripSeparator _ToolStripSeparator7;

	[AccessedThroughProperty("ToolStripSeparator8")]
	private ToolStripSeparator _ToolStripSeparator8;

	[AccessedThroughProperty("tsl_DownloadLocation")]
	private ToolStripLabel _tsl_DownloadLocation;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ApplicationUpdateTimer")]
	private Timer _ApplicationUpdateTimer;

	[AccessedThroughProperty("bg_ApplicationUpdate")]
	private BackgroundWorker _bg_ApplicationUpdate;

	[AccessedThroughProperty("TSB_Database_Creator")]
	private ToolStripButton _TSB_Database_Creator;

	[AccessedThroughProperty("Prep")]
	private ToolStripButton _Prep;

	[AccessedThroughProperty("ToolStripSeparator9")]
	private ToolStripSeparator _ToolStripSeparator9;

	[AccessedThroughProperty("ToolStripButton1")]
	private ToolStripButton _ToolStripButton1;

	[AccessedThroughProperty("ToolStripButton2")]
	private ToolStripButton _ToolStripButton2;

	[AccessedThroughProperty("lbl_Unlimited")]
	private Label _lbl_Unlimited;

	[AccessedThroughProperty("bg_Blacklist")]
	private BackgroundWorker _bg_Blacklist;

	[AccessedThroughProperty("ToolStripButton3")]
	private ToolStripButton _ToolStripButton3;

	[AccessedThroughProperty("Uctrl_CheckBlacklist1")]
	private uctrl_CheckBlacklist _Uctrl_CheckBlacklist1;

	private string SWVersion;

	private DataTable TheTable;

	private object OpeationRunning;

	private object TimeOut;

	private object StopBG;

	private bool UpdatingApplicationInProcess;

	private object RetrieveBGWResponse;

	private object ConnectionStatus;

	private object TheDownloadLink;

	private object RetrieveBGWResponseForSWUD;

	private object RetrieveBGWResponseForLIMIT;

	private string TheDownloadLocation;

	private StreamReader sr;

	private HttpWebResponse mrRes;

	private string[] TheDowWebServ;

	private string[] SWUDLinks;

	private string[] LIMITLinks;

	private object HomePage;

	private string KKLPage;

	private int MaxDownloads;

	private string KeyText;

	public const bool GoLeechVersion = false;

	public const bool nsanedownVersion = false;

	public const bool ddlarea = true;

	public const bool EnableErrorDetails = false;

	public const bool BetaVersion = false;

	private bool SelectionInProcess;

	private bool AlreadyWorkingforUpdate;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init;

	[SpecialName]
	private Random _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen;

	internal virtual DataGridView dgv_TheList
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgv_TheList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = DataGridView1_Sorted;
			EventHandler eventHandler2 = dgv_TheList_SelectionChanged;
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(dgv_TheList_CellEndEdit);
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(dgv_TheList_CellContentClick);
			if (_dgv_TheList != null)
			{
				_dgv_TheList.remove_Sorted(eventHandler);
				_dgv_TheList.remove_SelectionChanged(eventHandler2);
				_dgv_TheList.remove_CellEndEdit(val);
				_dgv_TheList.remove_CellContentClick(val2);
			}
			_dgv_TheList = value;
			if (_dgv_TheList != null)
			{
				_dgv_TheList.add_Sorted(eventHandler);
				_dgv_TheList.add_SelectionChanged(eventHandler2);
				_dgv_TheList.add_CellEndEdit(val);
				_dgv_TheList.add_CellContentClick(val2);
			}
		}
	}

	internal virtual CheckBox SelectDeselectAll
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectDeselectAll;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselectAll_CheckedChanged;
			if (_SelectDeselectAll != null)
			{
				_SelectDeselectAll.remove_CheckedChanged(eventHandler);
			}
			_SelectDeselectAll = value;
			if (_SelectDeselectAll != null)
			{
				_SelectDeselectAll.add_CheckedChanged(eventHandler);
			}
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

	internal virtual ToolStripStatusLabel ts_Networklabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_Networklabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_Networklabel = value;
		}
	}

	internal virtual ToolStripStatusLabel ts_TotalFiles
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_TotalFiles;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_TotalFiles = value;
		}
	}

	internal virtual ToolStripStatusLabel ts_TheMessageLabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_TheMessageLabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_TheMessageLabel = value;
		}
	}

	internal virtual ToolStripProgressBar ts_ProgressBar
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_ProgressBar;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_ProgressBar = value;
		}
	}

	internal virtual ToolStripStatusLabel ts_FileNumbers
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_FileNumbers;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_FileNumbers = value;
		}
	}

	internal virtual ContextMenuStrip cms_TheListMenu
	{
		[DebuggerNonUserCode]
		get
		{
			return _cms_TheListMenu;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cms_TheListMenu = value;
		}
	}

	internal virtual ToolStripMenuItem tsm_ShowAvailKeys
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsm_ShowAvailKeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ListKeys_Click;
			if (_tsm_ShowAvailKeys != null)
			{
				((ToolStripItem)_tsm_ShowAvailKeys).remove_Click(eventHandler);
			}
			_tsm_ShowAvailKeys = value;
			if (_tsm_ShowAvailKeys != null)
			{
				((ToolStripItem)_tsm_ShowAvailKeys).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem tsm_DownloadSelectedKeys
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsm_DownloadSelectedKeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadKey_Click;
			if (_tsm_DownloadSelectedKeys != null)
			{
				((ToolStripItem)_tsm_DownloadSelectedKeys).remove_Click(eventHandler);
			}
			_tsm_DownloadSelectedKeys = value;
			if (_tsm_DownloadSelectedKeys != null)
			{
				((ToolStripItem)_tsm_DownloadSelectedKeys).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator2 = value;
		}
	}

	internal virtual ToolStripMenuItem tsm_SelectHighlighted
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsm_SelectHighlighted;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Select_DeselectHighlighted_Click;
			if (_tsm_SelectHighlighted != null)
			{
				((ToolStripItem)_tsm_SelectHighlighted).remove_Click(eventHandler);
			}
			_tsm_SelectHighlighted = value;
			if (_tsm_SelectHighlighted != null)
			{
				((ToolStripItem)_tsm_SelectHighlighted).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator1 = value;
		}
	}

	internal virtual ToolStripMenuItem tsm_DownloadLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsm_DownloadLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadLocation_Click;
			if (_tsm_DownloadLocation != null)
			{
				((ToolStripItem)_tsm_DownloadLocation).remove_Click(eventHandler);
			}
			_tsm_DownloadLocation = value;
			if (_tsm_DownloadLocation != null)
			{
				((ToolStripItem)_tsm_DownloadLocation).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem tsm_Exit
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsm_Exit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tsm_Exit = value;
		}
	}

	internal virtual ToolStripMenuItem tsm_DeselectHighlighted
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsm_DeselectHighlighted;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Select_DeselectHighlighted_Click;
			if (_tsm_DeselectHighlighted != null)
			{
				((ToolStripItem)_tsm_DeselectHighlighted).remove_Click(eventHandler);
			}
			_tsm_DeselectHighlighted = value;
			if (_tsm_DeselectHighlighted != null)
			{
				((ToolStripItem)_tsm_DeselectHighlighted).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator3 = value;
		}
	}

	internal virtual BackgroundWorker bg_KeyList
	{
		[DebuggerNonUserCode]
		get
		{
			return _bg_KeyList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = bg_KeyList_DoWork;
			if (_bg_KeyList != null)
			{
				_bg_KeyList.DoWork -= value2;
			}
			_bg_KeyList = value;
			if (_bg_KeyList != null)
			{
				_bg_KeyList.DoWork += value2;
			}
		}
	}

	internal virtual BackgroundWorker bg_DownloadKey
	{
		[DebuggerNonUserCode]
		get
		{
			return _bg_DownloadKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = bg_DownloadKey_DoWork;
			if (_bg_DownloadKey != null)
			{
				_bg_DownloadKey.DoWork -= value2;
			}
			_bg_DownloadKey = value;
			if (_bg_DownloadKey != null)
			{
				_bg_DownloadKey.DoWork += value2;
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

	internal virtual ToolStrip ToolStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStrip1 = value;
		}
	}

	internal virtual ToolStripButton tsb_ListKeys
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsb_ListKeys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsb_ListKeys_EnabledChanged;
			EventHandler eventHandler2 = ListKeys_Click;
			if (_tsb_ListKeys != null)
			{
				((ToolStripItem)_tsb_ListKeys).remove_EnabledChanged(eventHandler);
				((ToolStripItem)_tsb_ListKeys).remove_Click(eventHandler2);
			}
			_tsb_ListKeys = value;
			if (_tsb_ListKeys != null)
			{
				((ToolStripItem)_tsb_ListKeys).add_EnabledChanged(eventHandler);
				((ToolStripItem)_tsb_ListKeys).add_Click(eventHandler2);
			}
		}
	}

	internal virtual ToolStripButton tsb_DownloadKey
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsb_DownloadKey;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadKey_Click;
			if (_tsb_DownloadKey != null)
			{
				((ToolStripItem)_tsb_DownloadKey).remove_Click(eventHandler);
			}
			_tsb_DownloadKey = value;
			if (_tsb_DownloadKey != null)
			{
				((ToolStripItem)_tsb_DownloadKey).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripButton tsb_Stop
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsb_Stop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tsb_Stop_Click;
			if (_tsb_Stop != null)
			{
				((ToolStripItem)_tsb_Stop).remove_Click(eventHandler);
			}
			_tsb_Stop = value;
			if (_tsb_Stop != null)
			{
				((ToolStripItem)_tsb_Stop).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator4 = value;
		}
	}

	internal virtual ToolStripTextBox tstb_DownloadLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _tstb_DownloadLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tstb_DownloadLocation = value;
		}
	}

	internal virtual ToolStripButton tsb_DownloadLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsb_DownloadLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DownloadLocation_Click;
			if (_tsb_DownloadLocation != null)
			{
				((ToolStripItem)_tsb_DownloadLocation).remove_Click(eventHandler);
			}
			_tsb_DownloadLocation = value;
			if (_tsb_DownloadLocation != null)
			{
				((ToolStripItem)_tsb_DownloadLocation).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator5 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator6 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator7 = value;
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator8 = value;
		}
	}

	internal virtual ToolStripLabel tsl_DownloadLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _tsl_DownloadLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tsl_DownloadLocation = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.remove_LinkClicked(val);
			}
			_LinkLabel1 = value;
			if (_LinkLabel1 != null)
			{
				_LinkLabel1.add_LinkClicked(val);
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

	internal virtual Timer ApplicationUpdateTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _ApplicationUpdateTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ApplicationUpdateTimer_Tick;
			if (_ApplicationUpdateTimer != null)
			{
				_ApplicationUpdateTimer.remove_Tick(eventHandler);
			}
			_ApplicationUpdateTimer = value;
			if (_ApplicationUpdateTimer != null)
			{
				_ApplicationUpdateTimer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual BackgroundWorker bg_ApplicationUpdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _bg_ApplicationUpdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DoWorkEventHandler value2 = bg_ApplicationUpdate_DoWork;
			if (_bg_ApplicationUpdate != null)
			{
				_bg_ApplicationUpdate.DoWork -= value2;
			}
			_bg_ApplicationUpdate = value;
			if (_bg_ApplicationUpdate != null)
			{
				_bg_ApplicationUpdate.DoWork += value2;
			}
		}
	}

	internal virtual ToolStripButton TSB_Database_Creator
	{
		[DebuggerNonUserCode]
		get
		{
			return _TSB_Database_Creator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = DatabaseCreatorButton_Click;
			if (_TSB_Database_Creator != null)
			{
				((ToolStripItem)_TSB_Database_Creator).remove_Click(eventHandler);
			}
			_TSB_Database_Creator = value;
			if (_TSB_Database_Creator != null)
			{
				((ToolStripItem)_TSB_Database_Creator).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripButton Prep
	{
		[DebuggerNonUserCode]
		get
		{
			return _Prep;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripButton1_Click;
			if (_Prep != null)
			{
				((ToolStripItem)_Prep).remove_Click(eventHandler);
			}
			_Prep = value;
			if (_Prep != null)
			{
				((ToolStripItem)_Prep).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripSeparator ToolStripSeparator9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripSeparator9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripSeparator9 = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripButton1_Click_1;
			if (_ToolStripButton1 != null)
			{
				((ToolStripItem)_ToolStripButton1).remove_Click(eventHandler);
			}
			_ToolStripButton1 = value;
			if (_ToolStripButton1 != null)
			{
				((ToolStripItem)_ToolStripButton1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripButton ToolStripButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripButton2_Click;
			if (_ToolStripButton2 != null)
			{
				((ToolStripItem)_ToolStripButton2).remove_Click(eventHandler);
			}
			_ToolStripButton2 = value;
			if (_ToolStripButton2 != null)
			{
				((ToolStripItem)_ToolStripButton2).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label lbl_Unlimited
	{
		[DebuggerNonUserCode]
		get
		{
			return _lbl_Unlimited;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lbl_Unlimited = value;
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
			_bg_Blacklist = value;
		}
	}

	internal virtual ToolStripButton ToolStripButton3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripButton3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripButton3_Click;
			if (_ToolStripButton3 != null)
			{
				((ToolStripItem)_ToolStripButton3).remove_Click(eventHandler);
			}
			_ToolStripButton3 = value;
			if (_ToolStripButton3 != null)
			{
				((ToolStripItem)_ToolStripButton3).add_Click(eventHandler);
			}
		}
	}

	internal virtual uctrl_CheckBlacklist Uctrl_CheckBlacklist1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Uctrl_CheckBlacklist1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Uctrl_CheckBlacklist1 = value;
		}
	}

	public cls_KasperKeySharingNetwork()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)KasperskyKeyFinder_Load);
		((Form)this).add_Shown((EventHandler)cls_KasperKeySharingNetwork_Shown);
		((Control)this).add_Move((EventHandler)KasperskyKeyFinder_Move);
		((Form)this).add_FormClosed(new FormClosedEventHandler(cls_KasperKeySharingNetwork_FormClosed));
		((Control)this).add_Resize((EventHandler)KasperskyKeyFinder_Resize);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		SWVersion = "V" + Assembly.GetExecutingAssembly().GetName().Version!.ToString();
		OpeationRunning = false;
		TimeOut = false;
		StopBG = false;
		UpdatingApplicationInProcess = false;
		RetrieveBGWResponse = "";
		ConnectionStatus = "";
		TheDownloadLink = null;
		RetrieveBGWResponseForSWUD = "";
		RetrieveBGWResponseForLIMIT = "";
		TheDownloadLocation = null;
		SWUDLinks = new string[5] { "http://rsmam.freehostia.com/KKF/KKSN_SWUD_EncV2.txt", "http://rsmam.awardspace.com/KKF/KKSN_SWUD_EncV2.txt", "http://rsmam.110mb.com/KKF/KKSN_SWUD_EncV2.txt", "http://rsmam.atspace.com/KKF/KKSN_SWUD_EncV2.txt", "http://rsmam.we.bs/KKF/KKSN_SWUD_EncV2.txt" };
		LIMITLinks = new string[5] { "http://rsmam.freehostia.com/KKSN/KKSN_Limit.txt", "http://rsmam.awardspace.com/KKSN/KKSN_Limit.txt", "http://rsmam.110mb.com/KKF/KKSN/KKSN_Limit.txt", "http://rsmam.atspace.com/KKSN/KKSN_Limit.txt", "http://rsmam.we.bs/KKSN/KKSN_Limit.txt" };
		HomePage = "";
		KKLPage = "";
		MaxDownloads = 5;
		KeyText = "";
		SelectionInProcess = false;
		AlreadyWorkingforUpdate = false;
		_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init = new StaticLocalInitFlag();
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
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_08ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected O, but got Unknown
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected O, but got Unknown
		//IL_0c8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c95: Expected O, but got Unknown
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Expected O, but got Unknown
		//IL_0f01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected O, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1296: Expected O, but got Unknown
		//IL_14a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b3: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cls_KasperKeySharingNetwork));
		dgv_TheList = new DataGridView();
		cms_TheListMenu = new ContextMenuStrip(components);
		tsm_DownloadLocation = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		tsm_ShowAvailKeys = new ToolStripMenuItem();
		tsm_DownloadSelectedKeys = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		tsm_SelectHighlighted = new ToolStripMenuItem();
		tsm_DeselectHighlighted = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		tsm_Exit = new ToolStripMenuItem();
		SelectDeselectAll = new CheckBox();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		StatusStrip1 = new StatusStrip();
		ts_Networklabel = new ToolStripStatusLabel();
		ts_TotalFiles = new ToolStripStatusLabel();
		ts_FileNumbers = new ToolStripStatusLabel();
		ts_TheMessageLabel = new ToolStripStatusLabel();
		ts_ProgressBar = new ToolStripProgressBar();
		bg_KeyList = new BackgroundWorker();
		bg_DownloadKey = new BackgroundWorker();
		Timer1 = new Timer(components);
		ToolStrip1 = new ToolStrip();
		ToolStripSeparator5 = new ToolStripSeparator();
		tsb_ListKeys = new ToolStripButton();
		ToolStripSeparator6 = new ToolStripSeparator();
		tsb_DownloadKey = new ToolStripButton();
		ToolStripSeparator7 = new ToolStripSeparator();
		tsb_Stop = new ToolStripButton();
		ToolStripSeparator4 = new ToolStripSeparator();
		ToolStripSeparator8 = new ToolStripSeparator();
		tsb_DownloadLocation = new ToolStripButton();
		tstb_DownloadLocation = new ToolStripTextBox();
		tsl_DownloadLocation = new ToolStripLabel();
		TSB_Database_Creator = new ToolStripButton();
		Prep = new ToolStripButton();
		ToolStripSeparator9 = new ToolStripSeparator();
		ToolStripButton1 = new ToolStripButton();
		ToolStripButton2 = new ToolStripButton();
		ToolStripButton3 = new ToolStripButton();
		LinkLabel1 = new LinkLabel();
		Label1 = new Label();
		ApplicationUpdateTimer = new Timer(components);
		bg_ApplicationUpdate = new BackgroundWorker();
		lbl_Unlimited = new Label();
		bg_Blacklist = new BackgroundWorker();
		Uctrl_CheckBlacklist1 = new uctrl_CheckBlacklist();
		((ISupportInitialize)dgv_TheList).BeginInit();
		((Control)cms_TheListMenu).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)ToolStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		dgv_TheList.set_AllowUserToAddRows(false);
		dgv_TheList.set_AllowUserToDeleteRows(false);
		dgv_TheList.set_AllowUserToResizeRows(false);
		((Control)dgv_TheList).set_Anchor((AnchorStyles)15);
		dgv_TheList.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dgv_TheList.set_BackgroundColor(Color.White);
		dgv_TheList.set_ClipboardCopyMode((DataGridViewClipboardCopyMode)0);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		dgv_TheList.set_ColumnHeadersDefaultCellStyle(val);
		dgv_TheList.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgv_TheList).set_ContextMenuStrip(cms_TheListMenu);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.HighlightText);
		val2.set_WrapMode((DataGridViewTriState)2);
		dgv_TheList.set_DefaultCellStyle(val2);
		DataGridView obj = dgv_TheList;
		Point location = new Point(0, 73);
		((Control)obj).set_Location(location);
		((Control)dgv_TheList).set_Name("dgv_TheList");
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(SystemColors.Control);
		val3.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_ForeColor(SystemColors.WindowText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)1);
		dgv_TheList.set_RowHeadersDefaultCellStyle(val3);
		dgv_TheList.set_RowHeadersVisible(false);
		DataGridView obj2 = dgv_TheList;
		Size size = new Size(794, 256);
		((Control)obj2).set_Size(size);
		((Control)dgv_TheList).set_TabIndex(1);
		ContextMenuStrip obj3 = cms_TheListMenu;
		size = new Size(28, 28);
		((ToolStrip)obj3).set_ImageScalingSize(size);
		((ToolStrip)cms_TheListMenu).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)tsm_DownloadLocation,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)tsm_ShowAvailKeys,
			(ToolStripItem)tsm_DownloadSelectedKeys,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)tsm_SelectHighlighted,
			(ToolStripItem)tsm_DeselectHighlighted,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)tsm_Exit
		});
		((Control)cms_TheListMenu).set_Name("cms_TheListMenu");
		ContextMenuStrip obj4 = cms_TheListMenu;
		size = new Size(188, 226);
		((Control)obj4).set_Size(size);
		((ToolStripItem)tsm_DownloadLocation).set_Image((Image)(object)Resources.folder_search);
		((ToolStripItem)tsm_DownloadLocation).set_Name("tsm_DownloadLocation");
		ToolStripMenuItem obj5 = tsm_DownloadLocation;
		size = new Size(187, 34);
		((ToolStripItem)obj5).set_Size(size);
		((ToolStripItem)tsm_DownloadLocation).set_Text("Save Location.");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator3;
		size = new Size(184, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)tsm_ShowAvailKeys).set_Image((Image)(object)Resources.database_down);
		((ToolStripItem)tsm_ShowAvailKeys).set_Name("tsm_ShowAvailKeys");
		ToolStripMenuItem obj6 = tsm_ShowAvailKeys;
		size = new Size(187, 34);
		((ToolStripItem)obj6).set_Size(size);
		((ToolStripItem)tsm_ShowAvailKeys).set_Text("List Keys.");
		tsm_DownloadSelectedKeys.set_Enabled(false);
		((ToolStripItem)tsm_DownloadSelectedKeys).set_Image((Image)(object)Resources.down);
		((ToolStripItem)tsm_DownloadSelectedKeys).set_Name("tsm_DownloadSelectedKeys");
		ToolStripMenuItem obj7 = tsm_DownloadSelectedKeys;
		size = new Size(187, 34);
		((ToolStripItem)obj7).set_Size(size);
		((ToolStripItem)tsm_DownloadSelectedKeys).set_Text("Save Keys.");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator2;
		size = new Size(184, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)tsm_SelectHighlighted).set_Name("tsm_SelectHighlighted");
		ToolStripMenuItem obj8 = tsm_SelectHighlighted;
		size = new Size(187, 34);
		((ToolStripItem)obj8).set_Size(size);
		((ToolStripItem)tsm_SelectHighlighted).set_Text("Select Highlighted.");
		((ToolStripItem)tsm_DeselectHighlighted).set_Name("tsm_DeselectHighlighted");
		ToolStripMenuItem obj9 = tsm_DeselectHighlighted;
		size = new Size(187, 34);
		((ToolStripItem)obj9).set_Size(size);
		((ToolStripItem)tsm_DeselectHighlighted).set_Text("Deselect Highlighted.");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator1;
		size = new Size(184, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)tsm_Exit).set_Name("tsm_Exit");
		ToolStripMenuItem obj10 = tsm_Exit;
		size = new Size(187, 34);
		((ToolStripItem)obj10).set_Size(size);
		((ToolStripItem)tsm_Exit).set_Text("Exit.");
		((ButtonBase)SelectDeselectAll).set_AutoSize(true);
		CheckBox selectDeselectAll = SelectDeselectAll;
		location = new Point(6, 79);
		((Control)selectDeselectAll).set_Location(location);
		((Control)SelectDeselectAll).set_Name("SelectDeselectAll");
		CheckBox selectDeselectAll2 = SelectDeselectAll;
		size = new Size(15, 14);
		((Control)selectDeselectAll2).set_Size(size);
		((Control)SelectDeselectAll).set_TabIndex(3);
		((ButtonBase)SelectDeselectAll).set_UseVisualStyleBackColor(true);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)ts_Networklabel,
			(ToolStripItem)ts_TotalFiles,
			(ToolStripItem)ts_FileNumbers,
			(ToolStripItem)ts_TheMessageLabel,
			(ToolStripItem)ts_ProgressBar
		});
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 350);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(794, 22);
		((Control)statusStrip2).set_Size(size);
		((Control)StatusStrip1).set_TabIndex(7);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ts_Networklabel).set_AutoSize(false);
		((ToolStripItem)ts_Networklabel).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)ts_Networklabel).set_ForeColor(Color.Green);
		((ToolStripItem)ts_Networklabel).set_Name("ts_Networklabel");
		ToolStripStatusLabel obj11 = ts_Networklabel;
		size = new Size(135, 17);
		((ToolStripItem)obj11).set_Size(size);
		((ToolStripItem)ts_Networklabel).set_Text("Network Status");
		((ToolStripItem)ts_TotalFiles).set_AutoSize(false);
		ts_TotalFiles.set_BorderSides((ToolStripStatusLabelBorderSides)1);
		((ToolStripItem)ts_TotalFiles).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)ts_TotalFiles).set_Name("ts_TotalFiles");
		ToolStripStatusLabel obj12 = ts_TotalFiles;
		size = new Size(70, 17);
		((ToolStripItem)obj12).set_Size(size);
		((ToolStripItem)ts_TotalFiles).set_Text("Total Keys: ");
		((ToolStripItem)ts_TotalFiles).set_TextAlign((ContentAlignment)16);
		((ToolStripItem)ts_FileNumbers).set_AutoSize(false);
		((ToolStripItem)ts_FileNumbers).set_ForeColor(Color.Red);
		((ToolStripItem)ts_FileNumbers).set_Name("ts_FileNumbers");
		ToolStripStatusLabel obj13 = ts_FileNumbers;
		size = new Size(70, 17);
		((ToolStripItem)obj13).set_Size(size);
		((ToolStripItem)ts_FileNumbers).set_Text("0");
		((ToolStripItem)ts_TheMessageLabel).set_AutoSize(false);
		ts_TheMessageLabel.set_BorderSides((ToolStripStatusLabelBorderSides)5);
		((ToolStripItem)ts_TheMessageLabel).set_Name("ts_TheMessageLabel");
		ToolStripStatusLabel obj14 = ts_TheMessageLabel;
		size = new Size(300, 17);
		((ToolStripItem)obj14).set_Size(size);
		((ToolStripItem)ts_ProgressBar).set_Name("ts_ProgressBar");
		ToolStripProgressBar obj15 = ts_ProgressBar;
		size = new Size(200, 16);
		((ToolStripControlHost)obj15).set_Size(size);
		((ToolStripItem)ts_ProgressBar).set_Visible(false);
		bg_KeyList.WorkerSupportsCancellation = true;
		bg_DownloadKey.WorkerSupportsCancellation = true;
		ToolStrip1.set_GripStyle((ToolStripGripStyle)0);
		ToolStrip toolStrip = ToolStrip1;
		size = new Size(50, 50);
		toolStrip.set_ImageScalingSize(size);
		ToolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[17]
		{
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)tsb_ListKeys,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)tsb_DownloadKey,
			(ToolStripItem)ToolStripSeparator7,
			(ToolStripItem)tsb_Stop,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)ToolStripSeparator8,
			(ToolStripItem)tsb_DownloadLocation,
			(ToolStripItem)tstb_DownloadLocation,
			(ToolStripItem)tsl_DownloadLocation,
			(ToolStripItem)TSB_Database_Creator,
			(ToolStripItem)Prep,
			(ToolStripItem)ToolStripSeparator9,
			(ToolStripItem)ToolStripButton1,
			(ToolStripItem)ToolStripButton2,
			(ToolStripItem)ToolStripButton3
		});
		ToolStrip toolStrip2 = ToolStrip1;
		location = new Point(0, 0);
		((Control)toolStrip2).set_Location(location);
		((Control)ToolStrip1).set_Name("ToolStrip1");
		ToolStrip toolStrip3 = ToolStrip1;
		size = new Size(794, 70);
		((Control)toolStrip3).set_Size(size);
		((Control)ToolStrip1).set_TabIndex(9);
		((Control)ToolStrip1).set_Text("ToolStrip1");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator5;
		size = new Size(6, 70);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)tsb_ListKeys).set_Enabled(false);
		((ToolStripItem)tsb_ListKeys).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)tsb_ListKeys).set_ForeColor(Color.Black);
		((ToolStripItem)tsb_ListKeys).set_Image((Image)(object)Resources.database_down);
		((ToolStripItem)tsb_ListKeys).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)tsb_ListKeys).set_Name("tsb_ListKeys");
		ToolStripButton obj16 = tsb_ListKeys;
		size = new Size(61, 67);
		((ToolStripItem)obj16).set_Size(size);
		((ToolStripItem)tsb_ListKeys).set_Text("List Keys");
		((ToolStripItem)tsb_ListKeys).set_TextImageRelation((TextImageRelation)1);
		((ToolStripItem)tsb_ListKeys).set_ToolTipText("List Keys");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator6;
		size = new Size(6, 70);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripItem)tsb_DownloadKey).set_Enabled(false);
		((ToolStripItem)tsb_DownloadKey).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)tsb_DownloadKey).set_Image((Image)(object)Resources.down);
		((ToolStripItem)tsb_DownloadKey).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)tsb_DownloadKey).set_Name("tsb_DownloadKey");
		ToolStripButton obj17 = tsb_DownloadKey;
		size = new Size(63, 67);
		((ToolStripItem)obj17).set_Size(size);
		((ToolStripItem)tsb_DownloadKey).set_Text("Save Key");
		((ToolStripItem)tsb_DownloadKey).set_TextImageRelation((TextImageRelation)1);
		((ToolStripItem)ToolStripSeparator7).set_Name("ToolStripSeparator7");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator7;
		size = new Size(6, 70);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)tsb_Stop).set_Enabled(false);
		((ToolStripItem)tsb_Stop).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)tsb_Stop).set_Image((Image)(object)Resources.red_button);
		((ToolStripItem)tsb_Stop).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)tsb_Stop).set_Name("tsb_Stop");
		ToolStripButton obj18 = tsb_Stop;
		size = new Size(54, 67);
		((ToolStripItem)obj18).set_Size(size);
		((ToolStripItem)tsb_Stop).set_Text("Stop");
		((ToolStripItem)tsb_Stop).set_TextImageRelation((TextImageRelation)1);
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator7 = ToolStripSeparator4;
		size = new Size(6, 70);
		((ToolStripItem)toolStripSeparator7).set_Size(size);
		((ToolStripItem)ToolStripSeparator8).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)ToolStripSeparator8).set_Name("ToolStripSeparator8");
		ToolStripSeparator toolStripSeparator8 = ToolStripSeparator8;
		size = new Size(6, 70);
		((ToolStripItem)toolStripSeparator8).set_Size(size);
		((ToolStripItem)tsb_DownloadLocation).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)tsb_DownloadLocation).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)tsb_DownloadLocation).set_Image((Image)(object)Resources.folder_search);
		((ToolStripItem)tsb_DownloadLocation).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)tsb_DownloadLocation).set_Name("tsb_DownloadLocation");
		ToolStripButton obj19 = tsb_DownloadLocation;
		size = new Size(54, 67);
		((ToolStripItem)obj19).set_Size(size);
		((ToolStripItem)tsb_DownloadLocation).set_Text("Find Folder");
		((ToolStripItem)tsb_DownloadLocation).set_TextImageRelation((TextImageRelation)1);
		((ToolStripItem)tstb_DownloadLocation).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripControlHost)tstb_DownloadLocation).set_BackColor(Color.White);
		tstb_DownloadLocation.set_BorderStyle((BorderStyle)1);
		((ToolStripItem)tstb_DownloadLocation).set_Name("tstb_DownloadLocation");
		tstb_DownloadLocation.set_ReadOnly(true);
		ToolStripTextBox obj20 = tstb_DownloadLocation;
		size = new Size(410, 70);
		((ToolStripControlHost)obj20).set_Size(size);
		((ToolStripItem)tsl_DownloadLocation).set_Alignment((ToolStripItemAlignment)1);
		((ToolStripItem)tsl_DownloadLocation).set_Font(new Font("Tahoma", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)tsl_DownloadLocation).set_Name("tsl_DownloadLocation");
		ToolStripLabel obj21 = tsl_DownloadLocation;
		size = new Size(97, 67);
		((ToolStripItem)obj21).set_Size(size);
		((ToolStripItem)tsl_DownloadLocation).set_Text("Save Location:");
		((ToolStripItem)TSB_Database_Creator).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)TSB_Database_Creator).set_Image((Image)(object)Resources.database_process);
		((ToolStripItem)TSB_Database_Creator).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)TSB_Database_Creator).set_Name("TSB_Database_Creator");
		ToolStripButton tSB_Database_Creator = TSB_Database_Creator;
		size = new Size(54, 54);
		((ToolStripItem)tSB_Database_Creator).set_Size(size);
		((ToolStripItem)TSB_Database_Creator).set_Text("KKL Creator");
		((ToolStripItem)Prep).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)Prep).set_Image((Image)(object)Resources.page_edit);
		((ToolStripItem)Prep).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)Prep).set_Name("Prep");
		ToolStripButton prep = Prep;
		size = new Size(54, 54);
		((ToolStripItem)prep).set_Size(size);
		((ToolStripItem)Prep).set_Text("Keys Prep.");
		((ToolStripItem)ToolStripSeparator9).set_Name("ToolStripSeparator9");
		ToolStripSeparator toolStripSeparator9 = ToolStripSeparator9;
		size = new Size(6, 6);
		((ToolStripItem)toolStripSeparator9).set_Size(size);
		((ToolStripItem)ToolStripButton1).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton1).set_Image((Image)(object)Resources.home_info);
		((ToolStripItem)ToolStripButton1).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ToolStripButton1).set_Name("ToolStripButton1");
		ToolStripButton toolStripButton = ToolStripButton1;
		size = new Size(54, 54);
		((ToolStripItem)toolStripButton).set_Size(size);
		((ToolStripItem)ToolStripButton1).set_Text("KKSN Latest Update WebPage.");
		((ToolStripItem)ToolStripButton2).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton2).set_Image((Image)(object)Resources.globe_search);
		((ToolStripItem)ToolStripButton2).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ToolStripButton2).set_Name("ToolStripButton2");
		ToolStripButton toolStripButton2 = ToolStripButton2;
		size = new Size(54, 54);
		((ToolStripItem)toolStripButton2).set_Size(size);
		((ToolStripItem)ToolStripButton2).set_Text("Find KKL Files");
		((ToolStripItem)ToolStripButton3).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ToolStripButton3).set_Image((Image)(object)Resources.notebook_search);
		((ToolStripItem)ToolStripButton3).set_ImageTransparentColor(Color.Magenta);
		((ToolStripItem)ToolStripButton3).set_Name("ToolStripButton3");
		ToolStripButton toolStripButton3 = ToolStripButton3;
		size = new Size(54, 54);
		((ToolStripItem)toolStripButton3).set_Size(size);
		((ToolStripItem)ToolStripButton3).set_Text("Key Viewer");
		((Control)LinkLabel1).set_Anchor((AnchorStyles)10);
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(710, 334);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(72, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(10);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("DryIcons.com");
		((Control)Label1).set_Anchor((AnchorStyles)10);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(662, 334);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(50, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Icons by:");
		((Control)lbl_Unlimited).set_Anchor((AnchorStyles)6);
		lbl_Unlimited.set_AutoSize(true);
		((Control)lbl_Unlimited).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)lbl_Unlimited).set_ForeColor(Color.Red);
		Label obj22 = lbl_Unlimited;
		location = new Point(12, 332);
		((Control)obj22).set_Location(location);
		((Control)lbl_Unlimited).set_Name("lbl_Unlimited");
		Label obj23 = lbl_Unlimited;
		size = new Size(230, 16);
		((Control)obj23).set_Size(size);
		((Control)lbl_Unlimited).set_TabIndex(14);
		lbl_Unlimited.set_Text("You Have Unlimited Downloads.");
		((Control)lbl_Unlimited).set_Visible(false);
		((Control)Uctrl_CheckBlacklist1).set_Anchor((AnchorStyles)13);
		((Control)Uctrl_CheckBlacklist1).set_BackColor(Color.White);
		((Control)Uctrl_CheckBlacklist1).set_Enabled(false);
		uctrl_CheckBlacklist uctrl_CheckBlacklist2 = Uctrl_CheckBlacklist1;
		location = new Point(162, 123);
		((Control)uctrl_CheckBlacklist2).set_Location(location);
		uctrl_CheckBlacklist uctrl_CheckBlacklist3 = Uctrl_CheckBlacklist1;
		size = new Size(471, 195);
		((Control)uctrl_CheckBlacklist3).set_MaximumSize(size);
		uctrl_CheckBlacklist uctrl_CheckBlacklist4 = Uctrl_CheckBlacklist1;
		size = new Size(471, 195);
		((Control)uctrl_CheckBlacklist4).set_MinimumSize(size);
		((Control)Uctrl_CheckBlacklist1).set_Name("Uctrl_CheckBlacklist1");
		uctrl_CheckBlacklist uctrl_CheckBlacklist5 = Uctrl_CheckBlacklist1;
		size = new Size(471, 195);
		((Control)uctrl_CheckBlacklist5).set_Size(size);
		((Control)Uctrl_CheckBlacklist1).set_TabIndex(15);
		((Control)Uctrl_CheckBlacklist1).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(794, 372);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Uctrl_CheckBlacklist1);
		((Control)this).get_Controls().Add((Control)(object)lbl_Unlimited);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)SelectDeselectAll);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)dgv_TheList);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		size = new Size(620, 276);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("cls_KasperKeySharingNetwork");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Tag((object)"");
		((Form)this).set_Text("Kasper-Key Sharing Network. V1.0");
		((ISupportInitialize)dgv_TheList).EndInit();
		((Control)cms_TheListMenu).ResumeLayout(false);
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)ToolStrip1).ResumeLayout(false);
		((Control)ToolStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string ExtractData(string TheText, string RemoveStart, string RemoveEnd, string OptionToRemove = "")
	{
		try
		{
			int num = TheText.ToLower().LastIndexOf(RemoveStart.ToLower());
			if (num == -1 && Operators.CompareString(OptionToRemove, "", false) != 0)
			{
				num = TheText.ToLower().LastIndexOf(OptionToRemove.ToLower());
				if (num == -1)
				{
					return "Reading Probelm.";
				}
			}
			string text = TheText.Substring(checked(num + RemoveStart.Length)).Trim();
			int num2 = text.ToLower().LastIndexOf(RemoveEnd.ToLower());
			if (num2 == -1 && Operators.CompareString(OptionToRemove, "", false) != 0)
			{
				num2 = text.ToLower().LastIndexOf(OptionToRemove.ToLower());
				if (num2 == -1)
				{
					return "Reading Probelm.";
				}
			}
			if (Operators.CompareString(RemoveEnd, "", false) != 0)
			{
				text = text.Remove(num2).Trim();
			}
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			string result = "Error: Unable to get data.";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public int RandomNumber(int low, int high)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Monitor.Enter(_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init);
			try
			{
				if (_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State == 0)
				{
					_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State = 2;
					_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen = new Random();
				}
				else if (_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init.State = 1;
				Monitor.Exit(_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init);
			}
			return _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen.Next(low, checked(high + 1));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool IsValidKey(string TheKeyLocation)
	{
		try
		{
			StreamReader streamReader = new StreamReader(TheKeyLocation);
			string text = streamReader.ReadToEnd();
			streamReader.Close();
			streamReader.Dispose();
			KeyText = "";
			if (text.ToLower().Contains("Bandwidth Limit Exceeded".ToLower()))
			{
				KeyText = "Bandwidth Limit Exceeded";
				text = null;
				return false;
			}
			if (text.ToLower().Contains("Kaspersky".ToLower()))
			{
				KeyViewer.FileName_Path = TheKeyLocation;
				if (KeyViewer.Functions.AnalyzeKey())
				{
					TimeSpan timeSpan = KeyViewer.Licence.ExpiryDate - DateAndTime.get_Now();
					bool flag = false;
					bool flag2 = false;
					if (timeSpan.Days < 0)
					{
						flag = true;
					}
					int num = Array.IndexOf(BlacklistViewer.FileInfo.KeyList, KeyViewer.Summary.KeyNumber);
					if (num >= 0)
					{
						flag2 = true;
					}
					if (!flag && !flag2)
					{
						KeyText = "Valid Key";
						text = null;
						return true;
					}
					KeyText = "This is not a valid key (Expired and/or Blacklisted).";
					text = null;
					return false;
				}
				KeyText = "";
				text = null;
				return false;
			}
			KeyText = "";
			text = null;
			return false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool DisableEnableDownloadButton()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		checked
		{
			try
			{
				bool flag = false;
				int num = dgv_TheList.get_RowCount() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					DataGridViewCheckBoxCell val = (DataGridViewCheckBoxCell)dgv_TheList.get_Item("Select", num2);
					if (Conversions.ToBoolean(((DataGridViewCell)val).get_EditedFormattedValue()))
					{
						flag = true;
					}
					num2++;
				}
				if (flag)
				{
					((ToolStripItem)tsb_DownloadKey).set_Enabled(true);
					tsm_DownloadSelectedKeys.set_Enabled(true);
				}
				else
				{
					((ToolStripItem)tsb_DownloadKey).set_Enabled(false);
					tsm_DownloadSelectedKeys.set_Enabled(false);
				}
				((Control)ToolStrip1).Refresh();
				return flag;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private ArrayList AvailableDrive(int MinimumSizeKB)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				ArrayList arrayList = new ArrayList();
				int num = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if ((((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num2].DriveType == DriveType.Fixed) & ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num2].IsReady)
					{
						long num5 = (long)Math.Round((double)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num2].TotalFreeSpace / 1024.0);
						if (num5 > MinimumSizeKB)
						{
							arrayList.Add(((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[num2].Name);
						}
					}
					num2++;
				}
				if (arrayList.Count == 0)
				{
					Interaction.MsgBox((object)"The Application Require an Available Local Drive with Enough Space to Continue.", (MsgBoxStyle)0, (object)null);
					arrayList = null;
					return null;
				}
				return arrayList;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
			return null;
		}
	}

	private long OnlineFileSizeKB(string url)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.ContentLength < 0L)
			{
				return -1L;
			}
			return checked((long)Math.Round((double)httpWebResponse.ContentLength / 1024.0));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
		return -1L;
	}

	public void ShowError(Exception ex)
	{
	}

	public string MeAndMyCaller()
	{
		StackTrace stackTrace = new StackTrace();
		return stackTrace.GetFrame(2)!.GetMethod()!.Name;
	}

	private void RetrieveTheKeyList()
	{
		checked
		{
			try
			{
				TheTable.Clear();
				((ToolStripItem)ts_FileNumbers).set_ForeColor(Color.Red);
				((ToolStripItem)ts_FileNumbers).set_Text("0");
				((ToolStripItem)ts_TheMessageLabel).set_Text("");
				string text = "";
				try
				{
					text = MyProject.Forms.DatabaseCreator.ImportTheListData();
					if (text == null)
					{
						((ToolStripItem)ts_TheMessageLabel).set_Text("Unable to Decrypt Database.");
						ts_ProgressBar.set_Style((ProgressBarStyle)2);
						((ToolStripItem)ts_ProgressBar).set_Visible(false);
						return;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					((ToolStripItem)ts_TheMessageLabel).set_Text("Unable to Decrypt Database.");
					ts_ProgressBar.set_Style((ProgressBarStyle)2);
					((ToolStripItem)ts_ProgressBar).set_Visible(false);
					ProjectData.ClearProjectError();
					return;
				}
				((ToolStripItem)ts_TheMessageLabel).set_Text("Reading the Database..");
				ts_ProgressBar.set_Style((ProgressBarStyle)1);
				ts_ProgressBar.set_Value(0);
				((ToolStripItem)ts_ProgressBar).set_Visible(true);
				string[] array = Strings.Split(text, "\r\n\r\n", -1, (CompareMethod)0);
				string[] array2 = null;
				if (array.Length == 3)
				{
					int num = array.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						if (array[num2].StartsWith("WebServer:\r\n"))
						{
							array[num2] = array[num2].Replace("WebServer:\r\n", "");
							array2 = (TheDowWebServ = Strings.Split(array[num2], "\r\n", -1, (CompareMethod)0));
						}
						else if (array[num2].StartsWith("Keys:\r\n"))
						{
							array[num2] = array[num2].Replace("Keys:\r\n", "");
							string[] array3 = Strings.Split(array[num2], "\r\n", -1, (CompareMethod)0);
							ts_ProgressBar.set_Maximum(array3.Length);
							int num5 = array3.Length - 1;
							int num6 = 0;
							while (true)
							{
								int num7 = num6;
								num4 = num5;
								if (num7 > num4)
								{
									break;
								}
								string[] array4 = Strings.Split(array3[num6], "|", -1, (CompareMethod)0);
								string text2 = "";
								string text3 = "";
								string text4 = "";
								if (array4.Length > 3)
								{
									if (array4[2].Length > 3)
									{
										try
										{
											text2 = array4[2].Substring(0, array4[2].IndexOf("_"));
											text3 = text2;
											string text5 = text2.Substring(0, 3).ToLower();
											text2 = ((Operators.CompareString(text5, "kav", false) == 0) ? ("Kaspersky Anti-Virus " + text2.Substring(3, text2.Length - 3)) : ((Operators.CompareString(text5, "kis", false) != 0) ? "Unknown." : ("Kaspersky Internet Security " + text2.Substring(3, text2.Length - 3))));
										}
										catch (Exception projectError2)
										{
											ProjectData.SetProjectError(projectError2);
											text2 = "Unknown.";
											ProjectData.ClearProjectError();
										}
										if (Operators.CompareString(text2, "Unknown.", false) != 0)
										{
											text3 = ExtractData(array4[2], text3 + "_", "_", "-");
											try
											{
												text3 = text3.Substring(0, 4) + "-" + text3.Substring(4, 2) + "-" + text3.Substring(6, 2);
											}
											catch (Exception ex)
											{
												ProjectData.SetProjectError(ex);
												Exception ex2 = ex;
												ShowError(ex2);
												ProjectData.ClearProjectError();
											}
										}
										else
										{
											text3 = Conversions.ToString(DateAndTime.get_Today());
										}
									}
									text4 = "";
									int num8 = 0;
									int num9 = array4.Length - 1;
									int num10 = 3;
									while (true)
									{
										int num11 = num10;
										num4 = num9;
										if (num11 > num4)
										{
											break;
										}
										if (Operators.CompareString(array4[num10], "T", false) == 0)
										{
											text4 = text4 + "|" + Conversions.ToString(num10 - 3) + "|,";
											num8++;
										}
										num10++;
									}
									string[] array5 = Strings.Split(array4[2], "_", -1, (CompareMethod)0);
									string[] array6 = Strings.Split(array5[2], ".", -1, (CompareMethod)0);
									string text6 = "N/A";
									if (BlacklistViewer.FileInfo.KeyList.Length > 0)
									{
										text6 = ((Array.IndexOf(BlacklistViewer.FileInfo.KeyList, array6[0]) < 0) ? "No" : "Yes");
									}
									TheTable.Rows.Add(false, text2, array4[2], array4[1], text3, "Not Started", array4[0], num8, text4, "N/A", text6);
									((ToolStripItem)ts_FileNumbers).set_Text(Conversions.ToString(TheTable.Rows.Count));
									Application.DoEvents();
								}
								Application.DoEvents();
								ToolStripProgressBar val = ts_ProgressBar;
								val.set_Value(val.get_Value() + 1);
								num6++;
							}
						}
						num2++;
					}
				}
				if (array2 == null)
				{
					((ToolStripItem)ts_FileNumbers).set_ForeColor(Color.Red);
					((ToolStripItem)ts_FileNumbers).set_Text(Conversions.ToString(0));
					((ToolStripItem)ts_TheMessageLabel).set_Text("");
				}
				else
				{
					((ToolStripItem)ts_FileNumbers).set_ForeColor(Color.Green);
					((ToolStripItem)ts_FileNumbers).set_Text(Conversions.ToString(TheTable.Rows.Count));
					((ToolStripItem)ts_TheMessageLabel).set_Text("Keys listed successfully..");
				}
				((ToolStripItem)ts_ProgressBar).set_Visible(false);
				ts_ProgressBar.set_Style((ProgressBarStyle)0);
				((Control)StatusStrip1).Refresh();
				StopBG = false;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ShowError(ex4);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void dgv_TheList_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		checked
		{
			try
			{
				if ((e.get_RowIndex() < 0) | (e.get_ColumnIndex() > 0))
				{
					return;
				}
				DataGridViewCheckBoxCell val = (DataGridViewCheckBoxCell)dgv_TheList.get_Item("Select", e.get_RowIndex());
				if (Conversions.ToBoolean(((DataGridViewCell)val).get_EditedFormattedValue()))
				{
					int num = dgv_TheList.get_ColumnCount() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						dgv_TheList.get_Item(num2, e.get_RowIndex()).get_Style().set_BackColor(Color.LightPink);
						num2++;
					}
					((ToolStripItem)tsb_DownloadKey).set_Enabled(true);
					tsm_DownloadSelectedKeys.set_Enabled(true);
				}
				else
				{
					int num5 = dgv_TheList.get_ColumnCount() - 1;
					int num6 = 1;
					while (true)
					{
						int num7 = num6;
						int num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						dgv_TheList.get_Item(num6, e.get_RowIndex()).get_Style().set_BackColor(Color.White);
						num6++;
					}
					DisableEnableDownloadButton();
				}
				dgv_TheList.get_Item(e.get_ColumnIndex() + 1, e.get_RowIndex()).set_Selected(true);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void dgv_TheList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		checked
		{
			try
			{
				if (e.get_ColumnIndex() != 0)
				{
					return;
				}
				if (Conversions.ToBoolean(dgv_TheList.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
					.get_Item(0)
					.get_Value()))
				{
					int num = dgv_TheList.get_ColumnCount() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						dgv_TheList.get_Item(num2, e.get_RowIndex()).get_Style().set_BackColor(Color.LightPink);
						num2++;
					}
					((ToolStripItem)tsb_DownloadKey).set_Enabled(true);
					tsm_DownloadSelectedKeys.set_Enabled(true);
					return;
				}
				int num5 = dgv_TheList.get_ColumnCount() - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					dgv_TheList.get_Item(num6, e.get_RowIndex()).get_Style().set_BackColor(Color.White);
					num6++;
				}
				DisableEnableDownloadButton();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void dgv_TheList_SelectionChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (SelectionInProcess)
				{
					return;
				}
				SelectionInProcess = true;
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					int num5 = dgv_TheList.get_ColumnCount() - 1;
					int num6 = 0;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						if (dgv_TheList.get_Item(0, num2).get_Selected())
						{
							dgv_TheList.get_Item(0, num2).set_Selected(false);
						}
						else if (dgv_TheList.get_Item(num6, num2).get_Selected())
						{
							int num8 = dgv_TheList.get_ColumnCount() - 1;
							int num9 = 1;
							while (true)
							{
								int num10 = num9;
								num4 = num8;
								if (num10 > num4)
								{
									break;
								}
								dgv_TheList.get_Item(num9, num2).set_Selected(true);
								num9++;
							}
						}
						num6++;
					}
					num2++;
				}
				DisableEnableDownloadButton();
				SelectionInProcess = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				SelectionInProcess = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SelectDeselectAll_CheckedChanged(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				((Control)Label1).Select();
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dgv_TheList.get_Item("Select", num2).set_Value((object)SelectDeselectAll.get_Checked());
					Color backColor;
					if (SelectDeselectAll.get_Checked())
					{
						backColor = Color.LightPink;
						((ToolStripItem)tsb_DownloadKey).set_Enabled(true);
						tsm_DownloadSelectedKeys.set_Enabled(true);
					}
					else
					{
						backColor = Color.White;
						((ToolStripItem)tsb_DownloadKey).set_Enabled(false);
						tsm_DownloadSelectedKeys.set_Enabled(false);
					}
					int num5 = dgv_TheList.get_ColumnCount() - 1;
					int num6 = 1;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						dgv_TheList.get_Item(num6, num2).get_Style().set_BackColor(backColor);
						num6++;
					}
					num2++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DataGridView1_Sorted(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(dgv_TheList.get_Item("Select", num2).get_Value(), (object)true, false))
					{
						int num5 = dgv_TheList.get_ColumnCount() - 1;
						int num6 = 1;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							dgv_TheList.get_Item(num6, num2).get_Style().set_BackColor(Color.LightPink);
							num6++;
						}
					}
					num2++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AddingColumnsForTable()
	{
		try
		{
			TheTable = new DataTable("TheList");
			TheTable.Columns.Add("Select", typeof(bool));
			TheTable.Columns.Add("KeyType", Type.GetType("System.String"));
			TheTable.Columns.Add("KeyName", Type.GetType("System.String"));
			TheTable.Columns.Add("UpdateDate", Type.GetType("System.String"));
			TheTable.Columns.Add("KeyValidity", Type.GetType("System.String"));
			TheTable.Columns.Add("DownloadStatus", Type.GetType("System.String"));
			TheTable.Columns.Add("DownloadLink", Type.GetType("System.String"));
			TheTable.Columns.Add("NumberOfWebServ", typeof(int));
			TheTable.Columns.Add("DownloadWebServ", Type.GetType("System.String"));
			TheTable.Columns.Add("DownloadHistory", Type.GetType("System.String"));
			TheTable.Columns.Add("Blacklisted", Type.GetType("System.String"));
			dgv_TheList.set_DataSource((object)TheTable);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	public void PrepareDataTable()
	{
		try
		{
			AddingColumnsForTable();
			DataGridViewColumn val = dgv_TheList.get_Columns().get_Item("Select");
			val.set_HeaderText("");
			((DataGridViewCell)val.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val.set_Width(21);
			val.set_Frozen(true);
			val.set_ReadOnly(false);
			val.set_Resizable((DataGridViewTriState)2);
			val.get_DefaultCellStyle().set_BackColor(Color.LightCyan);
			val = null;
			DataGridViewColumn val2 = dgv_TheList.get_Columns().get_Item("KeyType");
			val2.set_HeaderText("Key Type");
			((DataGridViewCell)val2.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val2.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)16);
			val2.set_FillWeight(23f);
			val2.set_Visible(true);
			((DataGridViewCell)val2.get_HeaderCell()).get_Style().set_ForeColor(Color.Red);
			val2 = null;
			DataGridViewColumn val3 = dgv_TheList.get_Columns().get_Item("KeyName");
			val3.set_HeaderText("Key Name");
			((DataGridViewCell)val3.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val3.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)16);
			val3.set_Visible(true);
			val3.set_FillWeight(27f);
			val3 = null;
			DataGridViewColumn val4 = dgv_TheList.get_Columns().get_Item("UpdateDate");
			val4.set_HeaderText("Update Date");
			((DataGridViewCell)val4.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val4.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val4.set_FillWeight(10f);
			val4.set_Visible(true);
			val4 = null;
			DataGridViewColumn val5 = dgv_TheList.get_Columns().get_Item("KeyValidity");
			val5.set_HeaderText("Key Validity");
			((DataGridViewCell)val5.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val5.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val5.set_FillWeight(12f);
			val5.set_Visible(true);
			val5 = null;
			DataGridViewColumn val6 = dgv_TheList.get_Columns().get_Item("DownloadStatus");
			val6.set_HeaderText("Download Status");
			((DataGridViewCell)val6.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val6.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val6.set_FillWeight(18f);
			val6.set_Visible(true);
			val6 = null;
			DataGridViewColumn val7 = dgv_TheList.get_Columns().get_Item("DownloadLink");
			val7.set_HeaderText("Download Link");
			((DataGridViewCell)val7.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val7.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val7.set_FillWeight(0.01f);
			val7.set_Visible(false);
			val7 = null;
			DataGridViewColumn val8 = dgv_TheList.get_Columns().get_Item("NumberOfWebServ");
			val8.set_HeaderText("Number of Mirrors");
			((DataGridViewCell)val8.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val8.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val8.set_FillWeight(10f);
			val8.set_Visible(true);
			val8 = null;
			DataGridViewColumn val9 = dgv_TheList.get_Columns().get_Item("DownloadWebServ");
			val9.set_HeaderText("Download WebServer");
			((DataGridViewCell)val9.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val9.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val9.set_FillWeight(0.01f);
			val9.set_Visible(false);
			val9 = null;
			DataGridViewColumn val10 = dgv_TheList.get_Columns().get_Item("DownloadHistory");
			val10.set_HeaderText("Download History");
			((DataGridViewCell)val10.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val10.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val10.set_FillWeight(0.01f);
			val10.set_Visible(false);
			val10 = null;
			DataGridViewColumn val11 = dgv_TheList.get_Columns().get_Item("Blacklisted");
			val11.set_HeaderText("Blacklisted");
			((DataGridViewCell)val11.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val11.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val11.set_FillWeight(10f);
			val11.set_Visible(true);
			val11 = null;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("http://dryicons.com");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ListKeys_Click(object sender, EventArgs e)
	{
		try
		{
			if (!Conversions.ToBoolean(OpeationRunning))
			{
				OpeationRunning = true;
				((ToolStripItem)tsb_ListKeys).set_Enabled(false);
				tsm_ShowAvailKeys.set_Enabled(false);
				((ToolStripItem)tsb_DownloadKey).set_Enabled(false);
				tsm_DownloadSelectedKeys.set_Enabled(false);
				((ToolStripItem)tsb_Stop).set_Enabled(true);
				((Control)ToolStrip1).Refresh();
				((Control)Label1).Select();
				while (((ToolStripItem)tsb_ListKeys).get_Enabled())
				{
					Application.DoEvents();
				}
				StopBG = false;
				TimeOut = false;
				RetrieveTheKeyList();
				((ToolStripItem)tsb_Stop).set_Enabled(false);
				((ToolStripItem)tsb_ListKeys).set_Enabled(true);
				tsm_ShowAvailKeys.set_Enabled(true);
				((Control)ToolStrip1).Refresh();
				OpeationRunning = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void DownloadKey_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				if (Conversions.ToBoolean(OpeationRunning))
				{
					return;
				}
				OpeationRunning = true;
				((ToolStripItem)tsb_Stop).set_Enabled(true);
				((Control)Label1).Select();
				StopBG = false;
				((ToolStripItem)ts_TheMessageLabel).set_Text("Download in Progress..");
				ts_ProgressBar.set_Style((ProgressBarStyle)2);
				((ToolStripItem)ts_ProgressBar).set_Visible(true);
				((Control)StatusStrip1).Refresh();
				if (!MyProject.Application.Connection())
				{
					return;
				}
				((ToolStripItem)tsb_ListKeys).set_Enabled(false);
				tsm_ShowAvailKeys.set_Enabled(false);
				if (TheTable.Select("Select = 'True'").Length < 1)
				{
					((ToolStripItem)ts_TheMessageLabel).set_Text("Select Key to Download.");
				}
				else
				{
					DataRow[] array = TheTable.Select("Select = 'True'");
					foreach (DataRow dataRow in array)
					{
						dataRow["DownloadStatus"] = "Waiting for Download..";
					}
					string text = "Download Completed";
					DataRow[] array2 = TheTable.Select("Select = 'True'");
					foreach (DataRow dataRow2 in array2)
					{
						if (Conversions.ToBoolean(StopBG))
						{
							text = "Download Stopped.";
							continue;
						}
						dataRow2["DownloadStatus"] = "Downloading";
						((Control)dgv_TheList).Refresh();
						if (MySettingsProperty.Settings.TotalDownloads >= MaxDownloads)
						{
							text = "Maximum Downloads Reached for Today.";
							continue;
						}
						if (((ToolStripControlHost)tstb_DownloadLocation).get_Text().EndsWith("\\"))
						{
							((ToolStripControlHost)tstb_DownloadLocation).set_Text(((ToolStripControlHost)tstb_DownloadLocation).get_Text().Remove(((ToolStripControlHost)tstb_DownloadLocation).get_Text().Length - 1, 1));
						}
						if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dataRow2["KeyName"]))))
						{
							File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dataRow2["KeyName"])));
						}
						string[] array3 = Strings.Split(Conversions.ToString(dataRow2["DownloadWebServ"]), ",", -1, (CompareMethod)0);
						int num = array3.Length - 1;
						int num2 = 0;
						while (true)
						{
							int num3 = num2;
							int num4 = num;
							if (num3 > num4)
							{
								break;
							}
							int num5 = RandomNumber(0, array3.Length - 2);
							if (num2 == array3.Length - 1)
							{
								break;
							}
							while (Operators.CompareString(array3[num5], "", false) == 0)
							{
								num5 = RandomNumber(0, array3.Length - 2);
							}
							text = "Download Completed";
							if (Conversions.ToBoolean(StopBG))
							{
								text = "Download Stopped.";
							}
							else
							{
								dataRow2["DownloadStatus"] = "Downloading from Mirror " + Conversions.ToString(num5 + 1);
								((Control)dgv_TheList).Refresh();
								if (MySettingsProperty.Settings.TotalDownloads >= MaxDownloads)
								{
									text = "Maximum Downloads Reached for Today.";
								}
								else
								{
									TheDownloadLink = Operators.ConcatenateObject((object)TheDowWebServ[Conversions.ToInteger(array3[num5].Replace("|", "").Trim())], dataRow2["DownloadLink"]);
									TheDownloadLocation = Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dataRow2["KeyName"]));
									bg_DownloadKey.RunWorkerAsync();
									DateTime now = DateAndTime.get_Now();
									while (bg_DownloadKey.IsBusy)
									{
										if (Conversions.ToBoolean(StopBG))
										{
											bg_DownloadKey.CancelAsync();
											text = "Download Stopped..";
										}
										if ((DateAndTime.get_Now() - now).TotalSeconds > 20.0)
										{
											bg_DownloadKey.CancelAsync();
											text = "Unable to Download from Mirror " + Conversions.ToString(num5 + 1) + ", Trying Another Mirror(if Any).";
											array3[num5] = "";
										}
										Application.DoEvents();
									}
									if ((text.Contains("Unable to Download from Mirror") | (Operators.CompareString(text, "Download Stopped..", false) == 0)) && File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dataRow2["KeyName"]))))
									{
										File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dataRow2["KeyName"])));
									}
									switch (KeyText)
									{
									case null:
									case "":
										text = "Unable to Download from Mirror " + Conversions.ToString(num5 + 1) + ", Trying Another Mirror(if Any).";
										array3[num5] = "";
										break;
									case "Unable to Download, Try Another Server.":
										text = "Unable to Download from Mirror " + Conversions.ToString(num5 + 1) + ", Trying Another Mirror(if Any).";
										array3[num5] = "";
										break;
									case "Bandwidth Limit Exceeded":
										text = "Unable to Download from Mirror " + Conversions.ToString(num5 + 1) + ", Trying Another Mirror(if Any).";
										array3[num5] = "";
										break;
									}
									if (KeyText.Contains("Download Completed as File Name") | KeyText.Contains("This is not a valid key (Expired and/or Blacklisted)."))
									{
										text = KeyText;
									}
									KeyText = "";
								}
							}
							dataRow2["DownloadStatus"] = text;
							((Control)dgv_TheList).Refresh();
							if (text.Contains("Completed") | text.Contains("This is not a valid key"))
							{
								break;
							}
							num2++;
						}
						if (text.Contains("Unable to Download from Mirror"))
						{
							dataRow2["DownloadStatus"] = "Unable to Download from All Available Mirrors.";
							((Control)dgv_TheList).Refresh();
						}
					}
					((ToolStripItem)ts_TheMessageLabel).set_Text("Operation Completed");
				}
				((ToolStripItem)ts_ProgressBar).set_Visible(false);
				ts_ProgressBar.set_Style((ProgressBarStyle)0);
				((Control)StatusStrip1).Refresh();
				StopBG = false;
				((ToolStripItem)tsb_Stop).set_Enabled(false);
				((ToolStripItem)tsb_ListKeys).set_Enabled(true);
				tsm_ShowAvailKeys.set_Enabled(true);
				OpeationRunning = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void tsb_Stop_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)Label1).Select();
			if (!Conversions.ToBoolean(Operators.NotObject(OpeationRunning)))
			{
				StopBG = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void DownloadLocation_Click(object sender, EventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)Label1).Select();
			FolderBrowserDialog1.set_Description("Save Key Location.");
			if (Directory.Exists(((ToolStripControlHost)tstb_DownloadLocation).get_Text()))
			{
				FolderBrowserDialog1.set_SelectedPath(((ToolStripControlHost)tstb_DownloadLocation).get_Text());
			}
			else
			{
				FolderBrowserDialog1.set_SelectedPath(Conversions.ToString(5));
			}
			FolderBrowserDialog1.set_ShowNewFolderButton(true);
			((CommonDialog)FolderBrowserDialog1).ShowDialog();
			if (Operators.CompareString(FolderBrowserDialog1.get_SelectedPath(), "5", false) == 0)
			{
				FolderBrowserDialog1.set_SelectedPath(((ToolStripControlHost)tstb_DownloadLocation).get_Text());
			}
			MySettingsProperty.Settings.SaveLocation = FolderBrowserDialog1.get_SelectedPath();
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			((ToolStripControlHost)tstb_DownloadLocation).set_Text(FolderBrowserDialog1.get_SelectedPath());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void Select_DeselectHighlighted_Click(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		checked
		{
			try
			{
				ToolStripMenuItem val = (ToolStripMenuItem)sender;
				bool flag = false;
				Color backColor = Color.White;
				if (Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)tsm_SelectHighlighted).get_Name(), false) == 0)
				{
					flag = true;
					backColor = Color.LightPink;
				}
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (dgv_TheList.get_Item("KeyName", num2).get_Selected())
					{
						dgv_TheList.get_Item("Select", num2).set_Value((object)flag);
						int num5 = dgv_TheList.get_ColumnCount() - 1;
						int num6 = 1;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							dgv_TheList.get_Item(num6, num2).get_Style().set_BackColor(backColor);
							num6++;
						}
					}
					num2++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				((ToolStripItem)ts_TheMessageLabel).set_Text("Error");
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cls_KasperKeySharingNetwork_FormClosed(object sender, FormClosedEventArgs e)
	{
		((Control)Uctrl_CheckBlacklist1).set_Enabled(false);
		Application.Exit();
	}

	private void KasperskyKeyFinder_Move(object sender, EventArgs e)
	{
		try
		{
			ToolStripTextBox obj = tstb_DownloadLocation;
			Size size = new Size(checked(((Control)this).get_Width() - 392), ((ToolStripItem)tstb_DownloadLocation).get_Height());
			((ToolStripControlHost)obj).set_Size(size);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void KasperskyKeyFinder_Resize(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				ToolStripTextBox obj = tstb_DownloadLocation;
				Size size = new Size(((Control)this).get_Width() - 392, ((ToolStripItem)tstb_DownloadLocation).get_Height());
				((ToolStripControlHost)obj).set_Size(size);
				if (((Control)Uctrl_CheckBlacklist1).get_Enabled())
				{
					int num = (int)Math.Round((double)((Control)this).get_Width() / 2.0);
					int num2 = (int)Math.Round((double)((Control)Uctrl_CheckBlacklist1).get_Width() / 2.0);
					uctrl_CheckBlacklist uctrl_CheckBlacklist2 = Uctrl_CheckBlacklist1;
					Point location = new Point(num - num2, ((Control)Uctrl_CheckBlacklist1).get_Location().Y);
					((Control)uctrl_CheckBlacklist2).set_Location(location);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void KasperskyKeyFinder_Load(object sender, EventArgs e)
	{
		try
		{
			((Form)this).set_Text("Kasper-Key Sharing Network. " + SWVersion);
			((Form)this).set_Text(((Form)this).get_Text() + "d \"ddlarea.com Edition.\"");
			MyProject.Application.Connection();
			((ToolStripItem)tsb_DownloadKey).set_Enabled(false);
			tsm_DownloadSelectedKeys.set_Enabled(false);
			((ToolStripItem)tsb_Stop).set_Enabled(false);
			PrepareDataTable();
			try
			{
				if (Operators.CompareString(MySettingsProperty.Settings.SaveLocation, "", false) == 0)
				{
					MySettingsProperty.Settings.SaveLocation = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
				}
				if (!Directory.Exists(MySettingsProperty.Settings.SaveLocation))
				{
					MySettingsProperty.Settings.SaveLocation = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_MyDocuments();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				if (Operators.CompareString(MySettingsProperty.Settings.SaveLocation, "", false) == 0)
				{
					MySettingsProperty.Settings.SaveLocation = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
				}
				if (!Directory.Exists(MySettingsProperty.Settings.SaveLocation))
				{
					MySettingsProperty.Settings.SaveLocation = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop();
				}
				ProjectData.ClearProjectError();
			}
			((ToolStripControlHost)tstb_DownloadLocation).set_Text(MySettingsProperty.Settings.SaveLocation);
			if (DateTime.Compare(MySettingsProperty.Settings.TheDownloadDate, DateAndTime.get_Now().Date) != 0)
			{
				MySettingsProperty.Settings.TheDownloadDate = DateAndTime.get_Now().Date;
				MySettingsProperty.Settings.TotalDownloads = 0;
			}
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			ApplicationUpdateTimer.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void bg_KeyList_DoWork(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				if (bg_KeyList.CancellationPending)
				{
					e.Cancel = true;
					return;
				}
				long num = OnlineFileSizeKB(e.Argument!.ToString());
				if (num == -1L)
				{
					return;
				}
				ArrayList arrayList = new ArrayList();
				arrayList = AvailableDrive((int)num);
				if (arrayList != null)
				{
					string text = Conversions.ToString(arrayList[RandomNumber(0, arrayList.Count - 1)]);
					arrayList = null;
					string text2 = text + Conversions.ToString(RandomNumber(0, 100000)) + ".kvb";
					if (File.Exists(text2))
					{
						File.Delete(text2);
					}
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(e.Argument!.ToString(), text2);
					StreamReader streamReader = new StreamReader(text2);
					RetrieveBGWResponse = streamReader.ReadToEnd();
					streamReader.Close();
					File.Delete(text2);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void bg_DownloadKey_DoWork(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				if (bg_DownloadKey.CancellationPending)
				{
					e.Cancel = true;
					return;
				}
				if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(TheDownloadLink, (object)null, false), (object)(Operators.CompareString(TheDownloadLocation, (string)null, false) == 0))))
				{
					return;
				}
				string text = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
				if (Directory.Exists(text))
				{
					do
					{
						text = text + "\\" + Path.GetRandomFileName();
					}
					while (File.Exists(text));
				}
				try
				{
					Network network = ((ServerComputer)MyProject.Computer).get_Network();
					object[] array = new object[2]
					{
						RuntimeHelpers.GetObjectValue(TheDownloadLink),
						text
					};
					bool[] array2 = new bool[2] { true, true };
					NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array, (string[])null, (Type[])null, array2, true);
					if (array2[0])
					{
						TheDownloadLink = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					KeyText = "Unable to Download, Try Another Server.";
					ProjectData.ClearProjectError();
					goto IL_0258;
				}
				if (!IsValidKey(text) & File.Exists(text))
				{
					if (!KeyText.Contains("This is not a valid key (Expired and/or Blacklisted)."))
					{
						KeyText = "Unable to Download, Try Another Server.";
					}
					else
					{
						string text2 = "";
						if (Operators.CompareString(Path.GetFileName(TheDownloadLocation)!.ToLower(), KeyViewer.Summary.ActualFileName.ToLower(), false) != 0)
						{
							text2 = " Real file name is '" + KeyViewer.Summary.ActualFileName + "'";
						}
						KeyText = "This is not a valid key (Expired and/or Blacklisted)." + text2;
					}
					File.Delete(text);
				}
				else if (File.Exists(text))
				{
					string text3 = Path.GetDirectoryName(TheDownloadLocation) + "\\";
					text3 += KeyViewer.Summary.ActualFileName;
					if (File.Exists(text3))
					{
						File.Delete(text3);
					}
					File.Move(text, text3);
					MySettingsProperty.Settings.TotalDownloads++;
					((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
					if (Operators.CompareString(Path.GetFileName(text3)!.ToLower(), Path.GetFileName(TheDownloadLocation)!.ToLower(), false) != 0)
					{
						KeyText = "Download Completed as File Name '" + Path.GetFileName(text3) + "'";
					}
				}
				goto IL_0258;
				IL_0258:
				TheDownloadLink = null;
				TheDownloadLocation = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
			{
				mrRes.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
			{
				sr.Close();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ShowError(ex4);
			ProjectData.ClearProjectError();
		}
	}

	private void ApplicationUpdateTimer_Tick(object sender, EventArgs e)
	{
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Invalid comparison between Unknown and I4
		new Factory();
		ICryptographer cryptographer = Factory.GetCryptographer("tripledes");
		try
		{
			if (UpdatingApplicationInProcess)
			{
				return;
			}
			UpdatingApplicationInProcess = true;
			ApplicationUpdateTimer.set_Interval(30000);
			bool flag = false;
			if (!MyProject.Application.Connection())
			{
				ApplicationUpdateTimer.set_Interval(2000);
			}
			else
			{
				RetrieveBGWResponseForSWUD = "";
				RetrieveBGWResponseForLIMIT = "";
				bg_ApplicationUpdate.RunWorkerAsync();
				while (bg_ApplicationUpdate.IsBusy)
				{
					Application.DoEvents();
				}
				CheckTheLimit();
				string text = Conversions.ToString(RetrieveBGWResponseForSWUD);
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = cryptographer.Decrypt(text);
					string[] array = Strings.Split(text, "\n", -1, (CompareMethod)0);
					byte b = 0;
					b = 0;
					if (!(!array[0].Contains("Version:") | (Operators.CompareString(array[1], "", false) == 0)))
					{
						array[0] = array[b].Replace("Version:", "").Trim();
						checked
						{
							array[1] = array[unchecked((int)b) + 1].Replace("New Update:", "").Trim();
							HomePage = array[1];
							array[2] = array[unchecked((int)b) + 2].Replace("Update Type:", "").Trim();
							array[3] = array[unchecked((int)b) + 3].Replace("Notify:", "").Trim();
							array[4] = array[unchecked((int)b) + 4].Replace("Notify Message:", "").Trim();
							array[4] = array[4].Replace("|", "\r\n").Trim();
							array[5] = array[unchecked((int)b) + 5].Replace("Force Message:", "").Trim();
							array[5] = array[5].Replace("|", "\r\n").Trim();
							if (array.Length > 5)
							{
								array[6] = array[unchecked((int)b) + 6].Replace("Do Not Force List:", "").Trim();
								array[7] = array[unchecked((int)b) + 7].Replace("Do Not Notify List:", "").Trim();
								KKLPage = array[unchecked((int)b) + 8].Replace("KKL Site:", "").Trim();
							}
							else
							{
								array[6] = "";
								array[7] = "";
							}
							if (Operators.CompareString(array[0].Trim(), SWVersion, false) == 0)
							{
								flag = true;
								((ToolStripItem)ts_TheMessageLabel).set_Text("The Application is Up to date.");
							}
							else
							{
								string[] array2 = Strings.Split(SWVersion, ".", -1, (CompareMethod)0);
								string[] array3 = Strings.Split(array[0].Trim(), ".", -1, (CompareMethod)0);
								array2[0] = Strings.Replace(array2[0], "V", "", 1, -1, (CompareMethod)0);
								array3[0] = Strings.Replace(array3[0], "V", "", 1, -1, (CompareMethod)0);
								if (Operators.CompareString(array2[0], array3[0], false) > 0)
								{
									flag = true;
								}
								else if (Operators.CompareString(array2[0], array3[0], false) == 0)
								{
									if (Operators.CompareString(array2[1], array3[1], false) > 0)
									{
										flag = true;
									}
									else if (Operators.CompareString(array2[1], array3[1], false) == 0 && Operators.CompareString(array2[2], array3[2], false) >= 0)
									{
										flag = true;
									}
								}
							}
							if (!array[3].ToLower().Contains("yes") | array[7].Contains(SWVersion))
							{
								goto IL_0494;
							}
							if (flag)
							{
								((ToolStripItem)ts_TheMessageLabel).set_Text("The Application is Up to date.");
								goto IL_0494;
							}
						}
						if (!MyProject.Application.Connection())
						{
							ApplicationUpdateTimer.set_Interval(2000);
						}
						else
						{
							if (!(array[2].Contains("Force") & !array[6].Contains(SWVersion)))
							{
								((ToolStripItem)ts_TheMessageLabel).set_Text("Application Update is Available.");
								MsgBoxResult val = Interaction.MsgBox((object)array[4], (MsgBoxStyle)4, (object)"Kasper-Key Sharing Network Update Available.");
								if ((int)val == 6)
								{
									Process.Start(array[1].Replace("New Update:", "").Trim());
								}
								goto IL_0494;
							}
							((ToolStripItem)ts_TheMessageLabel).set_Text("Application Update is Available.");
							Interaction.MsgBox((object)array[5], (MsgBoxStyle)16, (object)"Kasper-Key Sharing Network Update Available.");
							ApplicationUpdateTimer.set_Interval(1800000);
							((Control)ToolStrip1).set_Enabled(false);
							((Control)cms_TheListMenu).set_Enabled(false);
							((Control)ToolStrip1).Refresh();
							Process.Start(array[1]);
							ApplicationUpdateTimer.set_Interval(86400000);
							Application.Exit();
						}
					}
				}
			}
			goto end_IL_0011;
			IL_0494:
			ApplicationUpdateTimer.set_Interval(86400000);
			end_IL_0011:;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			((ToolStripItem)ts_TheMessageLabel).set_Text("Unable to Check for Update.");
			ProjectData.ClearProjectError();
		}
		UpdatingApplicationInProcess = false;
	}

	private void bg_ApplicationUpdate_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (AlreadyWorkingforUpdate)
				{
					return;
				}
				AlreadyWorkingforUpdate = true;
				string text = "";
				string text2 = "";
				int num = SWUDLinks.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					text = text + Conversions.ToString(num2) + ",";
					num2++;
				}
				int num5 = LIMITLinks.Length - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					text2 = text2 + Conversions.ToString(num6) + ",";
					num6++;
				}
				int num8 = 1000000000;
				HttpWebRequest httpWebRequest = null;
				string text3 = "";
				string text4 = "";
				HttpWebResponse httpWebResponse = null;
				StreamReader streamReader = null;
				int num9 = SWUDLinks.Length - 1;
				int num10 = 0;
				while (true)
				{
					int num11 = num10;
					int num4 = num9;
					if (num11 <= num4)
					{
						while (!text.Contains(Conversions.ToString(num8) + ","))
						{
							num8 = RandomNumber(0, SWUDLinks.Length - 1);
						}
						text = text.Replace(Conversions.ToString(num8) + ",", "");
						httpWebRequest = (HttpWebRequest)WebRequest.Create(SWUDLinks[num8]);
						IPHostEntry hostEntry = Dns.GetHostEntry(httpWebRequest.Address.Host);
						text3 = hostEntry.AddressList.GetValue(0)!.ToString();
						if (Operators.CompareString(text3, "127.0.0.1", false) != 0)
						{
							httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
							streamReader = new StreamReader(httpWebResponse.GetResponseStream());
							text4 = streamReader.ReadToEnd();
							if (text4.Contains("</html>"))
							{
								num10++;
								continue;
							}
							RetrieveBGWResponseForSWUD = text4;
							break;
						}
						Interaction.MsgBox((object)"Do not Direct the Network to your Local Machine.", (MsgBoxStyle)16, (object)"127.0.0.1");
						Application.Exit();
						return;
					}
					break;
				}
				num8 = 1000000000;
				int num12 = LIMITLinks.Length - 1;
				int num13 = 0;
				while (true)
				{
					int num14 = num13;
					int num4 = num12;
					if (num14 <= num4)
					{
						while (!text2.Contains(Conversions.ToString(num8) + ","))
						{
							num8 = RandomNumber(0, LIMITLinks.Length - 1);
						}
						text2 = text2.Replace(Conversions.ToString(num8) + ",", "");
						httpWebRequest = (HttpWebRequest)WebRequest.Create(LIMITLinks[num8]);
						IPHostEntry hostEntry = Dns.GetHostEntry(httpWebRequest.Address.Host);
						text3 = hostEntry.AddressList.GetValue(0)!.ToString();
						if (Operators.CompareString(text3, "127.0.0.1", false) != 0)
						{
							httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
							streamReader = new StreamReader(httpWebResponse.GetResponseStream());
							text4 = streamReader.ReadToEnd();
							if (text4.Contains("</html>"))
							{
								num13++;
								continue;
							}
							RetrieveBGWResponseForLIMIT = text4;
							break;
						}
						Interaction.MsgBox((object)"Do not Direct the Network to your Local Machine.", (MsgBoxStyle)16, (object)"127.0.0.1");
						Application.Exit();
						return;
					}
					break;
				}
				streamReader.Close();
				httpWebRequest.Abort();
				httpWebResponse.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ShowError(ex2);
				ProjectData.ClearProjectError();
			}
			AlreadyWorkingforUpdate = false;
		}
	}

	private void DatabaseCreatorButton_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)MyProject.Forms.DatabaseCreator).Show();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripButton1_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)MyProject.Forms.KeysAndListPrep).Show();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripButton1_Click_1(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(HomePage, (object)"", false))
			{
				((ToolStripItem)ts_TheMessageLabel).set_Text("Unable to Locate the website. Try Later.");
				return;
			}
			Type typeFromHandle = typeof(Process);
			object[] array = new object[1] { RuntimeHelpers.GetObjectValue(HomePage) };
			bool[] array2 = new bool[1] { true };
			NewLateBinding.LateCall((object)null, typeFromHandle, "Start", array, (string[])null, (Type[])null, array2, true);
			if (array2[0])
			{
				HomePage = RuntimeHelpers.GetObjectValue(array[0]);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripButton2_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(KKLPage, "", false) == 0)
			{
				((ToolStripItem)ts_TheMessageLabel).set_Text("Unable to Locate the website. Try Later.");
			}
			else
			{
				Process.Start(KKLPage);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void CheckTheLimit()
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		new Factory();
		ICryptographer cryptographer = Factory.GetCryptographer("tripledes");
		RetrieveBGWResponseForLIMIT = cryptographer.Decrypt(Conversions.ToString(RetrieveBGWResponseForLIMIT));
		string[] array = Strings.Split(Conversions.ToString(RetrieveBGWResponseForLIMIT), "-------------------------------", -1, (CompareMethod)0);
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		NetworkInterface[] array2 = allNetworkInterfaces;
		checked
		{
			foreach (NetworkInterface networkInterface in array2)
			{
				string text = networkInterface.GetPhysicalAddress().ToString().ToUpper()
					.Trim();
				if (array[0].ToUpper().Contains(text) & (Operators.CompareString(text, "", false) != 0))
				{
					MaxDownloads = 1000000;
				}
				if (!(array[1].ToUpper().Contains(text) & (Operators.CompareString(text, "", false) != 0)))
				{
					continue;
				}
				MaxDownloads = 75;
				if (Operators.CompareString(MySettingsProperty.Settings.Physical.ToUpper().Trim(), text, false) == 0)
				{
					break;
				}
				MySettingsProperty.Settings.Physical = text;
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				string[] array3 = Strings.Split(array[2], "\r\n", -1, (CompareMethod)0);
				int num = array3.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (!array3[num2].StartsWith("Lifted:"))
					{
						num2++;
						continue;
					}
					string text2 = array3[num2].Replace("Lifted:", "").Trim();
					if (Operators.CompareString(text2, "", false) != 0)
					{
						text2 = text2.Replace("|", "\r\n");
						Interaction.MsgBox((object)text2, (MsgBoxStyle)0, (object)null);
					}
					break;
				}
				break;
			}
			if (MaxDownloads == 1000000)
			{
				((Control)lbl_Unlimited).set_Visible(true);
				MySettingsProperty.Settings.Physical = "";
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				return;
			}
			((Control)lbl_Unlimited).set_Visible(false);
			if (MySettingsProperty.Settings.TotalDownloads >= MaxDownloads)
			{
				Interaction.MsgBox((object)"You Have Reached The Maximum Key Downloads for Today. Try again Tomorrow.", (MsgBoxStyle)16, (object)"Kasper-Key Sharing Network.");
				Application.Exit();
			}
		}
	}

	private void ToolStripButton3_Click(object sender, EventArgs e)
	{
		Size minimumSize = new Size(802, 406);
		((Form)this).set_MinimumSize(minimumSize);
		((ToolStripItem)tsb_ListKeys).set_Enabled(false);
		((Control)Uctrl_CheckBlacklist1).set_Enabled(true);
		((Control)Uctrl_CheckBlacklist1).set_Visible(true);
		while (((Control)Uctrl_CheckBlacklist1).get_Enabled())
		{
			Application.DoEvents();
		}
		if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
		{
			((ToolStripItem)ts_TheMessageLabel).set_Text("Blacklist Not Checked.");
		}
		else
		{
			((ToolStripItem)ts_TheMessageLabel).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
		}
		((Control)Uctrl_CheckBlacklist1).set_Enabled(false);
		((Control)Uctrl_CheckBlacklist1).set_Visible(false);
		((Control)MyProject.Forms.form_KeyViewer).Show();
		((ToolStripItem)tsb_ListKeys).set_Enabled(true);
		minimumSize = new Size(620, 276);
		((Form)this).set_MinimumSize(minimumSize);
	}

	private void cls_KasperKeySharingNetwork_Shown(object sender, EventArgs e)
	{
		Size minimumSize = new Size(802, 406);
		((Form)this).set_MinimumSize(minimumSize);
		((ToolStripItem)tsb_ListKeys).set_Enabled(false);
		((Control)Uctrl_CheckBlacklist1).set_Enabled(true);
		((Control)Uctrl_CheckBlacklist1).set_Visible(true);
		while (((Control)Uctrl_CheckBlacklist1).get_Enabled())
		{
			Application.DoEvents();
		}
		if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
		{
			((ToolStripItem)ts_TheMessageLabel).set_Text("Blacklist Not Checked.");
		}
		else
		{
			((ToolStripItem)ts_TheMessageLabel).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
		}
		((Control)Uctrl_CheckBlacklist1).set_Enabled(false);
		((Control)Uctrl_CheckBlacklist1).set_Visible(false);
		((ToolStripItem)tsb_ListKeys).set_Enabled(true);
		minimumSize = new Size(620, 276);
		((Form)this).set_MinimumSize(minimumSize);
	}

	private void tsb_ListKeys_EnabledChanged(object sender, EventArgs e)
	{
		if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, (Type)null, "enabled", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			if (((Control)Uctrl_CheckBlacklist1).get_Visible())
			{
				NewLateBinding.LateSet(sender, (Type)null, "enabled", new object[1] { false }, (string[])null, (Type[])null);
			}
			else
			{
				NewLateBinding.LateSet(sender, (Type)null, "enabled", new object[1] { true }, (string[])null, (Type[])null);
			}
		}
	}
}
