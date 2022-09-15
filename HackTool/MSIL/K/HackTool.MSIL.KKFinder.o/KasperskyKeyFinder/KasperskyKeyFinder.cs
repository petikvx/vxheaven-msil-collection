using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using KasperskyKeyFinder.My;
using KasperskyKeyFinder.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace KasperskyKeyFinder;

[DesignerGenerated]
public class KasperskyKeyFinder : Form
{
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

	[AccessedThroughProperty("Server1")]
	private RadioButton _Server1;

	[AccessedThroughProperty("Server2")]
	private RadioButton _Server2;

	[AccessedThroughProperty("Server3")]
	private RadioButton _Server3;

	[AccessedThroughProperty("Server4")]
	private RadioButton _Server4;

	[AccessedThroughProperty("Server5")]
	private RadioButton _Server5;

	private const string SWVersion = "V1.4.1";

	private DataTable TheTable;

	private object OpeationRunning;

	private object TimeOut;

	private object StopBG;

	private bool UpdatingApplicationInProcess;

	private object RetrieveBGWResponse;

	private object ConnectionStatus;

	private object TheDownloadLink;

	private object RetrieveBGWResponseForSWUD;

	private string TheDownloadLocation;

	private StreamReader sr;

	private HttpWebResponse mrRes;

	private string[] SWUDLinks;

	private const byte MaxDownloads = 75;

	private string KeyText;

	public const bool GoLeechVersion = false;

	[SpecialName]
	private Random _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen;

	[SpecialName]
	private StaticLocalInitFlag _0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init;

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
			EventHandler eventHandler = ListKeys_Click;
			if (_tsb_ListKeys != null)
			{
				((ToolStripItem)_tsb_ListKeys).remove_Click(eventHandler);
			}
			_tsb_ListKeys = value;
			if (_tsb_ListKeys != null)
			{
				((ToolStripItem)_tsb_ListKeys).add_Click(eventHandler);
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

	internal virtual RadioButton Server1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Server1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Server1 = value;
		}
	}

	internal virtual RadioButton Server2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Server2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Server2 = value;
		}
	}

	internal virtual RadioButton Server3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Server3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Server3 = value;
		}
	}

	internal virtual RadioButton Server4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Server4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Server4 = value;
		}
	}

	internal virtual RadioButton Server5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Server5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Server5 = value;
		}
	}

	public KasperskyKeyFinder()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		((Control)this).add_Move((EventHandler)KasperskyKeyFinder_Move);
		((Control)this).add_Resize((EventHandler)KasperskyKeyFinder_Resize);
		((Form)this).add_Load((EventHandler)KasperskyKeyFinder_Load);
		OpeationRunning = false;
		TimeOut = false;
		StopBG = false;
		UpdatingApplicationInProcess = false;
		RetrieveBGWResponse = "";
		ConnectionStatus = "";
		TheDownloadLink = null;
		RetrieveBGWResponseForSWUD = "";
		TheDownloadLocation = null;
		SWUDLinks = new string[7] { "http://rsmam.pcriot.com/KKF/KKF-SWUD.txt", "http://www.freewebs.com/dan2010/KKF/KKF-SWUD.txt", "http://rsmam.freehostia.com/KKF/KKF-SWUD.txt", "http://rsmam.awardspace.com/KKF/KKF-SWUD.txt", "http://rsmam.atspace.com/KKF/KKF-SWUD.txt", "http://rsmam.110mb.com/KKF/KKF-SWUD.txt", "http://rsmam.we.bs/KKF/KKF-SWUD.txt" };
		KeyText = "";
		_0024STATIC_0024RandomNumber_0024202888_0024RandomNumGen_0024Init = new StaticLocalInitFlag();
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
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Expected O, but got Unknown
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		//IL_0e87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e91: Expected O, but got Unknown
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_138b: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KasperskyKeyFinder));
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
		LinkLabel1 = new LinkLabel();
		Label1 = new Label();
		ApplicationUpdateTimer = new Timer(components);
		bg_ApplicationUpdate = new BackgroundWorker();
		Server1 = new RadioButton();
		Server2 = new RadioButton();
		Server3 = new RadioButton();
		Server4 = new RadioButton();
		Server5 = new RadioButton();
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
		Size size = new Size(794, 231);
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
		location = new Point(0, 323);
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
		ToolStrip1.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[11]
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
			(ToolStripItem)tsl_DownloadLocation
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
		((Control)LinkLabel1).set_Anchor((AnchorStyles)10);
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(710, 307);
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
		location = new Point(663, 307);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(50, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(11);
		Label1.set_Text("Icons by:");
		((Control)Server1).set_Anchor((AnchorStyles)6);
		((ButtonBase)Server1).set_AutoSize(true);
		Server1.set_Checked(true);
		RadioButton server = Server1;
		location = new Point(6, 305);
		((Control)server).set_Location(location);
		((Control)Server1).set_Name("Server1");
		RadioButton server2 = Server1;
		size = new Size(68, 17);
		((Control)server2).set_Size(size);
		((Control)Server1).set_TabIndex(12);
		Server1.set_TabStop(true);
		((ButtonBase)Server1).set_Text("Server 1.");
		((ButtonBase)Server1).set_UseVisualStyleBackColor(true);
		((Control)Server2).set_Anchor((AnchorStyles)6);
		((ButtonBase)Server2).set_AutoSize(true);
		RadioButton server3 = Server2;
		location = new Point(99, 305);
		((Control)server3).set_Location(location);
		((Control)Server2).set_Name("Server2");
		RadioButton server4 = Server2;
		size = new Size(68, 17);
		((Control)server4).set_Size(size);
		((Control)Server2).set_TabIndex(13);
		((ButtonBase)Server2).set_Text("Server 2.");
		((ButtonBase)Server2).set_UseVisualStyleBackColor(true);
		((Control)Server3).set_Anchor((AnchorStyles)6);
		((ButtonBase)Server3).set_AutoSize(true);
		RadioButton server5 = Server3;
		location = new Point(192, 305);
		((Control)server5).set_Location(location);
		((Control)Server3).set_Name("Server3");
		RadioButton server6 = Server3;
		size = new Size(68, 17);
		((Control)server6).set_Size(size);
		((Control)Server3).set_TabIndex(14);
		((ButtonBase)Server3).set_Text("Server 3.");
		((ButtonBase)Server3).set_UseVisualStyleBackColor(true);
		((Control)Server4).set_Anchor((AnchorStyles)6);
		((ButtonBase)Server4).set_AutoSize(true);
		RadioButton server7 = Server4;
		location = new Point(280, 305);
		((Control)server7).set_Location(location);
		((Control)Server4).set_Name("Server4");
		RadioButton server8 = Server4;
		size = new Size(68, 17);
		((Control)server8).set_Size(size);
		((Control)Server4).set_TabIndex(15);
		((ButtonBase)Server4).set_Text("Server 4.");
		((ButtonBase)Server4).set_UseVisualStyleBackColor(true);
		((Control)Server5).set_Anchor((AnchorStyles)6);
		((ButtonBase)Server5).set_AutoSize(true);
		RadioButton server9 = Server5;
		location = new Point(368, 305);
		((Control)server9).set_Location(location);
		((Control)Server5).set_Name("Server5");
		RadioButton server10 = Server5;
		size = new Size(68, 17);
		((Control)server10).set_Size(size);
		((Control)Server5).set_TabIndex(16);
		((ButtonBase)Server5).set_Text("Server 5.");
		((ButtonBase)Server5).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(794, 345);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Server5);
		((Control)this).get_Controls().Add((Control)(object)Server4);
		((Control)this).get_Controls().Add((Control)(object)Server3);
		((Control)this).get_Controls().Add((Control)(object)Server2);
		((Control)this).get_Controls().Add((Control)(object)Server1);
		((Control)this).get_Controls().Add((Control)(object)SelectDeselectAll);
		((Control)this).get_Controls().Add((Control)(object)ToolStrip1);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)dgv_TheList);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		size = new Size(620, 276);
		((Form)this).set_MinimumSize(size);
		((Control)this).set_Name("KasperskyKeyFinder");
		((Control)this).set_Tag((object)"");
		((Form)this).set_Text("Kaspersky Key Finder. V1.0");
		((ISupportInitialize)dgv_TheList).EndInit();
		((Control)cms_TheListMenu).ResumeLayout(false);
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)ToolStrip1).ResumeLayout(false);
		((Control)ToolStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string GetHTMLSource(string URLAddress, bool ReturnTheError = false)
	{
		Uri uri = new Uri(URLAddress);
		try
		{
			string text = "";
			int num = 0;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URLAddress);
			httpWebRequest.Timeout = 10000;
			ConnectionStatus = "mres";
			if (Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
			{
				text = "";
			}
			else
			{
				mrRes = (HttpWebResponse)httpWebRequest.GetResponse();
				ConnectionStatus = "Requesting from Database Server.";
				if (Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
				{
					text = "";
				}
				else
				{
					sr = new StreamReader(mrRes.GetResponseStream(), Encoding.Default);
					ConnectionStatus = "";
					if (Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
					{
						text = "";
					}
					else
					{
						while (!text.ToLower().Contains("</html>"))
						{
							text = text + sr.ReadLine() + "\r\n";
							if (!Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
							{
								num = checked(num + 1);
								continue;
							}
							text = "";
							break;
						}
					}
					sr.Dispose();
					sr.Close();
				}
			}
			mrRes.Close();
			return text;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			string result;
			if (ReturnTheError)
			{
				result = ex2.Message.ToString();
				ProjectData.ClearProjectError();
				return result;
			}
			string message = ex2.Message;
			if (ex2.Message.Contains(uri.Host))
			{
				message = message.Replace(uri.Host, "Database Server");
			}
			result = "";
			ProjectData.ClearProjectError();
			return result;
		}
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Error: Unable to get data.";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public int RandomNumber(int low, int high)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			int result = 0;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool IsValidKey(string TheKeyLocation)
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
			KeyText = "Valid Key";
			text = null;
			return true;
		}
		KeyText = "";
		text = null;
		return false;
	}

	public bool DisableEnableDownloadButton()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		bool flag = false;
		checked
		{
			int num = dgv_TheList.get_RowCount() - 1;
			for (int i = 0; i <= num; i++)
			{
				DataGridViewCheckBoxCell val = (DataGridViewCheckBoxCell)dgv_TheList.get_Item("Select", i);
				if (Conversions.ToBoolean(((DataGridViewCell)val).get_EditedFormattedValue()))
				{
					flag = true;
				}
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
	}

	private ArrayList AvailableDrive(int MinimumSizeKB)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		ArrayList arrayList = new ArrayList();
		checked
		{
			int num = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if ((((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].DriveType == DriveType.Fixed) & ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].IsReady)
				{
					long num2 = (long)Math.Round((double)((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].TotalFreeSpace / 1024.0);
					if (num2 > MinimumSizeKB)
					{
						arrayList.Add(((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives()[i].Name);
					}
				}
			}
			if (arrayList.Count == 0)
			{
				Interaction.MsgBox((object)"The Application Require an Available Local Drive with Enough Space to Continue.", (MsgBoxStyle)0, (object)null);
				arrayList = null;
				return null;
			}
			return arrayList;
		}
	}

	private long OnlineFileSizeKB(string url)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (httpWebResponse.ContentLength < 0L)
		{
			return -1L;
		}
		return checked((long)Math.Round((double)httpWebResponse.ContentLength / 1024.0));
	}

	private void RetrieveTheKeyList()
	{
		checked
		{
			try
			{
				if (!MyProject.Application.Connection())
				{
					return;
				}
				TheTable.Clear();
				((ToolStripItem)ts_FileNumbers).set_ForeColor(Color.Red);
				((ToolStripItem)ts_FileNumbers).set_Text("0");
				((ToolStripItem)ts_TheMessageLabel).set_Text("Connecting to the Database..");
				ts_ProgressBar.set_Style((ProgressBarStyle)2);
				((ToolStripItem)ts_ProgressBar).set_Visible(true);
				if (Conversions.ToBoolean(StopBG))
				{
					((ToolStripItem)ts_TheMessageLabel).set_Text("Stopped..");
				}
				else
				{
					RetrieveBGWResponse = "";
					bg_KeyList.RunWorkerAsync("http://www.freewebs.com/kkfpage/KKF/TheList.KKP");
					DateTime now = DateAndTime.get_Now();
					string text = "";
					Timer1.set_Enabled(true);
					Timer1.set_Interval(10);
					Timer1.Start();
					while (bg_KeyList.IsBusy)
					{
						if ((DateAndTime.get_Now() - now).TotalMinutes > 1.0)
						{
							bg_KeyList.CancelAsync();
							text = "Unable to Access Database (Time out)..";
							TimeOut = true;
						}
						if (Conversions.ToBoolean(StopBG))
						{
							bg_KeyList.CancelAsync();
							((ToolStripItem)ts_TheMessageLabel).set_Text("Trying to Stop..");
							text = "Stopped..";
						}
						Application.DoEvents();
					}
					Timer1.Stop();
					if ((Operators.CompareString(text, "Unable to Access Database (Time out)..", false) == 0) | (Operators.CompareString(text, "Stopped..", false) == 0))
					{
						((ToolStripItem)ts_TheMessageLabel).set_Text(text);
					}
					else
					{
						string text2 = Conversions.ToString(RetrieveBGWResponse);
						if ((Operators.CompareString(text2, "", false) == 0) | text2.ToLower().Contains("<HTML>".ToLower()))
						{
							((ToolStripItem)ts_TheMessageLabel).set_Text("Unable to Access Database (Error Returned)..");
						}
						else
						{
							string[] array = Strings.Split(text2, "\r\n", -1, (CompareMethod)0);
							int num = 0;
							string[] array2 = new string[3001];
							string[] array3 = new string[3001];
							string[] array4 = new string[3001];
							string[] array5 = new string[3001];
							string[] array6 = new string[3001];
							((ToolStripItem)ts_TheMessageLabel).set_Text("Accessing Keys Availability Database..");
							((Control)StatusStrip1).Refresh();
							int num2 = array.Length - 1;
							for (int i = 0; i <= num2; i++)
							{
								string[] array7 = array[i].Split(new char[1] { '|' });
								array3[num] = array7[0];
								array2[num] = array7[2];
								array5[num] = array2[num].Substring(0, array2[num].IndexOf("_"));
								array4[num] = array7[1];
								array6[num] = ExtractData(array2[num], array5[num] + "_", "_", "-");
								try
								{
									array6[num] = array6[num].Substring(0, 4) + "-" + array6[num].Substring(4, 2) + "-" + array6[num].Substring(6, 2);
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
								}
								num++;
							}
							array2 = (string[])Utils.CopyArray((Array)array2, (Array)new string[num - 1 + 1]);
							array3 = (string[])Utils.CopyArray((Array)array3, (Array)new string[num - 1 + 1]);
							array4 = (string[])Utils.CopyArray((Array)array4, (Array)new string[num - 1 + 1]);
							array5 = (string[])Utils.CopyArray((Array)array5, (Array)new string[num - 1 + 1]);
							array6 = (string[])Utils.CopyArray((Array)array6, (Array)new string[num - 1 + 1]);
							((ToolStripItem)ts_FileNumbers).set_ForeColor(Color.Green);
							((ToolStripItem)ts_FileNumbers).set_Text(Conversions.ToString(num));
							((ToolStripItem)ts_TheMessageLabel).set_Text("Keys Information Found..");
							((Control)StatusStrip1).Refresh();
							TheTable.Clear();
							int num3 = num - 1;
							for (int j = 0; j <= num3; j++)
							{
								if (array5[j].Length > 3)
								{
									if (Operators.CompareString(array5[j].Substring(0, 3).ToLower(), "kav", false) == 0)
									{
										array5[j] = "Kaspersky Anti-Virus " + array5[j].Substring(3, array5[j].Length - 3);
									}
									if (Operators.CompareString(array5[j].Substring(0, 3).ToLower(), "kis", false) == 0)
									{
										array5[j] = "Kaspersky Internet Security " + array5[j].Substring(3, array5[j].Length - 3);
									}
								}
								TheTable.Rows.Add(false, array5[j], array2[j], array4[j], array6[j], "Not Started", array3[j]);
							}
							((ToolStripItem)ts_TheMessageLabel).set_Text("Keys listed successfully..");
						}
					}
				}
				((ToolStripItem)ts_ProgressBar).set_Visible(false);
				ts_ProgressBar.set_Style((ProgressBarStyle)0);
				((Control)StatusStrip1).Refresh();
				StopBG = false;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void dgv_TheList_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
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
					for (int i = 1; i <= num; i++)
					{
						dgv_TheList.get_Item(i, e.get_RowIndex()).get_Style().set_BackColor(Color.LightPink);
					}
					((ToolStripItem)tsb_DownloadKey).set_Enabled(true);
					tsm_DownloadSelectedKeys.set_Enabled(true);
				}
				else
				{
					int num2 = dgv_TheList.get_ColumnCount() - 1;
					for (int j = 1; j <= num2; j++)
					{
						dgv_TheList.get_Item(j, e.get_RowIndex()).get_Style().set_BackColor(Color.White);
					}
					DisableEnableDownloadButton();
				}
				dgv_TheList.get_Item(e.get_ColumnIndex() + 1, e.get_RowIndex()).set_Selected(true);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
					for (int i = 1; i <= num; i++)
					{
						dgv_TheList.get_Item(i, e.get_RowIndex()).get_Style().set_BackColor(Color.LightPink);
					}
					((ToolStripItem)tsb_DownloadKey).set_Enabled(true);
					tsm_DownloadSelectedKeys.set_Enabled(true);
				}
				else
				{
					int num2 = dgv_TheList.get_ColumnCount() - 1;
					for (int j = 1; j <= num2; j++)
					{
						dgv_TheList.get_Item(j, e.get_RowIndex()).get_Style().set_BackColor(Color.White);
					}
					DisableEnableDownloadButton();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					int num2 = dgv_TheList.get_ColumnCount() - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (dgv_TheList.get_Item(0, i).get_Selected())
						{
							dgv_TheList.get_Item(0, i).set_Selected(false);
						}
						else if (dgv_TheList.get_Item(j, i).get_Selected())
						{
							int num3 = dgv_TheList.get_ColumnCount() - 1;
							for (int k = 1; k <= num3; k++)
							{
								dgv_TheList.get_Item(k, i).set_Selected(true);
							}
						}
					}
				}
				DisableEnableDownloadButton();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SelectDeselectAll_CheckedChanged(object sender, EventArgs e)
	{
		((Control)Label1).Select();
		checked
		{
			try
			{
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					dgv_TheList.get_Item("Select", i).set_Value((object)SelectDeselectAll.get_Checked());
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
					int num2 = dgv_TheList.get_ColumnCount() - 1;
					for (int j = 1; j <= num2; j++)
					{
						dgv_TheList.get_Item(j, i).get_Style().set_BackColor(backColor);
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dgv_TheList.get_Item("Select", i).get_Value(), (object)true, false))
					{
						int num2 = dgv_TheList.get_ColumnCount() - 1;
						for (int j = 1; j <= num2; j++)
						{
							dgv_TheList.get_Item(j, i).get_Style().set_BackColor(Color.LightPink);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
			dgv_TheList.set_DataSource((object)TheTable);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
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
			val5.set_FillWeight(15f);
			val5.set_Visible(true);
			val5 = null;
			DataGridViewColumn val6 = dgv_TheList.get_Columns().get_Item("DownloadStatus");
			val6.set_HeaderText("Download Status");
			((DataGridViewCell)val6.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val6.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val6.set_FillWeight(25f);
			val6.set_Visible(true);
			val6 = null;
			DataGridViewColumn val7 = dgv_TheList.get_Columns().get_Item("DownloadLink");
			val7.set_HeaderText("Download Link");
			((DataGridViewCell)val7.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
			val7.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
			val7.set_FillWeight(0.01f);
			val7.set_Visible(false);
			val7 = null;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("http://dryicons.com");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
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
				bool flag = false;
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
				int num = TheTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(dgv_TheList.get_Item("Select", i).get_Value()))
					{
						dgv_TheList.get_Item("DownloadStatus", i).set_Value((object)"Waiting for Download..");
						((Control)dgv_TheList).Refresh();
						flag = true;
					}
				}
				if (!flag)
				{
					((ToolStripItem)ts_TheMessageLabel).set_Text("Select Key to Download.");
				}
				else
				{
					string text = "Download Completed";
					int num2 = TheTable.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (!Conversions.ToBoolean(dgv_TheList.get_Item("Select", j).get_Value()))
						{
							continue;
						}
						if (Conversions.ToBoolean(StopBG))
						{
							text = "Download Stopped.";
						}
						else
						{
							dgv_TheList.get_Item("DownloadStatus", j).set_Value((object)"Downloading");
							((Control)dgv_TheList).Refresh();
							if (MySettingsProperty.Settings.TotalDownloads >= 75)
							{
								text = "Maximum Downloads Reached for Today.";
							}
							else
							{
								if (((ToolStripControlHost)tstb_DownloadLocation).get_Text().EndsWith("\\"))
								{
									((ToolStripControlHost)tstb_DownloadLocation).set_Text(((ToolStripControlHost)tstb_DownloadLocation).get_Text().Remove(((ToolStripControlHost)tstb_DownloadLocation).get_Text().Length - 1, 1));
								}
								if (File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dgv_TheList.get_Item("KeyName", j).get_Value()))))
								{
									File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dgv_TheList.get_Item("KeyName", j).get_Value())));
								}
								if (Server1.get_Checked())
								{
									TheDownloadLink = Operators.ConcatenateObject((object)"http://kkf.awardspace.us/KKF/", dgv_TheList.get_Item("DownloadLink", j).get_Value());
								}
								if (Server2.get_Checked())
								{
									TheDownloadLink = Operators.ConcatenateObject((object)"http://heyman.awardspace.com/KKF/", dgv_TheList.get_Item("DownloadLink", j).get_Value());
								}
								if (Server3.get_Checked())
								{
									TheDownloadLink = Operators.ConcatenateObject((object)"http://k-k-f.0catch.com/KKF/", dgv_TheList.get_Item("DownloadLink", j).get_Value());
								}
								if (Server4.get_Checked())
								{
									TheDownloadLink = Operators.ConcatenateObject((object)"http://www.k-k-f.we.bs/KKF/", dgv_TheList.get_Item("DownloadLink", j).get_Value());
								}
								if (Server5.get_Checked())
								{
									TheDownloadLink = Operators.ConcatenateObject((object)"http://kkf.freehostia.com/KKF/", dgv_TheList.get_Item("DownloadLink", j).get_Value());
								}
								TheDownloadLocation = Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dgv_TheList.get_Item("KeyName", j).get_Value()));
								bg_DownloadKey.RunWorkerAsync();
								DateTime now = DateAndTime.get_Now();
								while (bg_DownloadKey.IsBusy)
								{
									if (Conversions.ToBoolean(StopBG))
									{
										bg_DownloadKey.CancelAsync();
										text = "Download Stopped..";
									}
									if ((DateAndTime.get_Now() - now).TotalSeconds > 30.0)
									{
										bg_DownloadKey.CancelAsync();
										text = "Unable to Download, Try Again..";
									}
									Application.DoEvents();
								}
								if (((Operators.CompareString(text, "Unable to Download, Try Again..", false) == 0) | (Operators.CompareString(text, "Download Stopped..", false) == 0)) && File.Exists(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dgv_TheList.get_Item("KeyName", j).get_Value()))))
								{
									File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)(((ToolStripControlHost)tstb_DownloadLocation).get_Text() + "\\"), dgv_TheList.get_Item("KeyName", j).get_Value())));
								}
								switch (KeyText)
								{
								case null:
								case "":
									text = "Try again Later, or Try Another server.";
									break;
								case "Unable to Download, Try Another Server.":
									text = KeyText;
									break;
								case "Bandwidth Limit Exceeded":
									text = "Server " + KeyText + ", Try Another Server.";
									break;
								}
								KeyText = "";
							}
						}
						dgv_TheList.get_Item("DownloadStatus", j).set_Value((object)text);
						((Control)dgv_TheList).Refresh();
					}
					((ToolStripItem)ts_TheMessageLabel).set_Text(text);
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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DownloadLocation_Click(object sender, EventArgs e)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Select_DeselectHighlighted_Click(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ToolStripMenuItem val = (ToolStripMenuItem)sender;
		bool flag = false;
		Color backColor = Color.White;
		if (Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)tsm_SelectHighlighted).get_Name(), false) == 0)
		{
			flag = true;
			backColor = Color.LightPink;
		}
		checked
		{
			try
			{
				int num = dgv_TheList.get_Rows().get_Count() - 1;
				for (int i = 0; i <= num; i++)
				{
					if (dgv_TheList.get_Item("KeyName", i).get_Selected())
					{
						dgv_TheList.get_Item("Select", i).set_Value((object)flag);
						int num2 = dgv_TheList.get_ColumnCount() - 1;
						for (int j = 1; j <= num2; j++)
						{
							dgv_TheList.get_Item(j, i).get_Style().set_BackColor(backColor);
						}
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				((ToolStripItem)ts_TheMessageLabel).set_Text("Error");
				ProjectData.ClearProjectError();
			}
		}
	}

	private void KasperskyKeyFinder_Move(object sender, EventArgs e)
	{
		try
		{
			ToolStripTextBox obj = tstb_DownloadLocation;
			Size size = new Size(checked(((Control)this).get_Width() - 392), ((ToolStripItem)tstb_DownloadLocation).get_Height());
			((ToolStripControlHost)obj).set_Size(size);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KasperskyKeyFinder_Resize(object sender, EventArgs e)
	{
		try
		{
			ToolStripTextBox obj = tstb_DownloadLocation;
			Size size = new Size(checked(((Control)this).get_Width() - 392), ((ToolStripItem)tstb_DownloadLocation).get_Height());
			((ToolStripControlHost)obj).set_Size(size);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void KasperskyKeyFinder_Load(object sender, EventArgs e)
	{
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Form)this).set_Text("Kaspersky Key Finder. V1.4.1");
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
			if (MySettingsProperty.Settings.TotalDownloads >= 75)
			{
				Interaction.MsgBox((object)"You Have Reached The Maximum Key Downloads for Today. Try again Tomorrow.", (MsgBoxStyle)16, (object)"Kaspersky Key Finder.");
				Application.Exit();
			}
			switch (RandomNumber(1, 5))
			{
			case 1:
				Server1.set_Checked(true);
				break;
			case 2:
				Server2.set_Checked(true);
				break;
			case 3:
				Server3.set_Checked(true);
				break;
			case 4:
				Server4.set_Checked(true);
				break;
			case 5:
				Server5.set_Checked(true);
				break;
			}
			ApplicationUpdateTimer.Start();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
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
				try
				{
					Network network = ((ServerComputer)MyProject.Computer).get_Network();
					object[] array = new object[2]
					{
						RuntimeHelpers.GetObjectValue(TheDownloadLink),
						TheDownloadLocation
					};
					bool[] array2 = new bool[2] { true, true };
					NewLateBinding.LateCall((object)network, (Type)null, "DownloadFile", array, (string[])null, (Type[])null, array2, true);
					if (array2[0])
					{
						TheDownloadLink = RuntimeHelpers.GetObjectValue(array[0]);
					}
					if (array2[1])
					{
						TheDownloadLocation = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					KeyText = "Unable to Download, Try Another Server.";
					ProjectData.ClearProjectError();
					goto IL_0149;
				}
				if (!IsValidKey(TheDownloadLocation) & File.Exists(TheDownloadLocation))
				{
					File.Delete(TheDownloadLocation);
				}
				else if (File.Exists(TheDownloadLocation))
				{
					MySettingsProperty.Settings.TotalDownloads++;
					((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
				}
				goto IL_0149;
				IL_0149:
				TheDownloadLink = null;
				TheDownloadLocation = null;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Conversions.ToBoolean(Operators.OrObject(StopBG, TimeOut)))
			{
				sr.Close();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}

	private void ApplicationUpdateTimer_Tick(object sender, EventArgs e)
	{
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Invalid comparison between Unknown and I4
		try
		{
			if (UpdatingApplicationInProcess || UpdatingApplicationInProcess)
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
				bg_ApplicationUpdate.RunWorkerAsync();
				while (bg_ApplicationUpdate.IsBusy)
				{
					Application.DoEvents();
				}
				string text = Conversions.ToString(RetrieveBGWResponseForSWUD);
				if (Operators.CompareString(text, "", false) != 0)
				{
					string[] array = Strings.Split(text, "\n", -1, (CompareMethod)0);
					byte b = 0;
					if (!(!array[0].Contains("Version:") | (Operators.CompareString(array[1], "", false) == 0)))
					{
						array[0] = array[b].Replace("Version:", "").Trim();
						checked
						{
							array[1] = array[unchecked((int)b) + 1].Replace("New Update:", "").Trim();
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
							}
							else
							{
								array[6] = "";
								array[7] = "";
							}
							if (Operators.CompareString(array[0].Trim(), "V1.4.1", false) == 0)
							{
								flag = true;
							}
							if ((!array[3].ToLower().Contains("yes") | array[7].Contains("V1.4.1")) || flag)
							{
								goto IL_031d;
							}
						}
						if (!MyProject.Application.Connection())
						{
							ApplicationUpdateTimer.set_Interval(2000);
						}
						else
						{
							if (!(array[2].Contains("Force") & !array[6].Contains("V1.4.1")))
							{
								MsgBoxResult val = Interaction.MsgBox((object)array[4], (MsgBoxStyle)4, (object)"Kaspersky Key Finder Update Available.");
								if ((int)val == 6)
								{
									Process.Start(array[1].Replace("New Update:", "").Trim());
								}
								goto IL_031d;
							}
							Interaction.MsgBox((object)array[5], (MsgBoxStyle)16, (object)"Kaspersky Key Finder Update Available.");
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
			goto end_IL_0000;
			IL_031d:
			ApplicationUpdateTimer.set_Interval(86400000);
			end_IL_0000:;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		UpdatingApplicationInProcess = false;
	}

	private void bg_ApplicationUpdate_DoWork(object sender, DoWorkEventArgs e)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(SWUDLinks[RandomNumber(0, checked(SWUDLinks.Length - 1))]);
			IPHostEntry hostEntry = Dns.GetHostEntry(httpWebRequest.Address.Host);
			string text = hostEntry.AddressList.GetValue(0)!.ToString();
			if (Operators.CompareString(text, "127.0.0.1", false) == 0)
			{
				Interaction.MsgBox((object)"Do not Direct the Network to your Local Machine.", (MsgBoxStyle)16, (object)"127.0.0.1");
				Application.Exit();
				return;
			}
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.ASCII);
			RetrieveBGWResponseForSWUD = streamReader.ReadToEnd();
			streamReader.Close();
			httpWebResponse.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
