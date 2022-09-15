using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.AdvTree;
using DevComponents.DotNetBar;
using KasperKeySharingNetwork.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class form_KeyViewer : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("AdvTree1")]
	private AdvTree _AdvTree1;

	[AccessedThroughProperty("FileName")]
	private Node _FileName;

	[AccessedThroughProperty("Node1")]
	private Node _Node1;

	[AccessedThroughProperty("Node10")]
	private Node _Node10;

	[AccessedThroughProperty("Node11")]
	private Node _Node11;

	[AccessedThroughProperty("Node12")]
	private Node _Node12;

	[AccessedThroughProperty("Node13")]
	private Node _Node13;

	[AccessedThroughProperty("Node14")]
	private Node _Node14;

	[AccessedThroughProperty("Node15")]
	private Node _Node15;

	[AccessedThroughProperty("Node16")]
	private Node _Node16;

	[AccessedThroughProperty("Node17")]
	private Node _Node17;

	[AccessedThroughProperty("Node18")]
	private Node _Node18;

	[AccessedThroughProperty("ColumnHeader1")]
	private ColumnHeader _ColumnHeader1;

	[AccessedThroughProperty("ColumnHeader2")]
	private ColumnHeader _ColumnHeader2;

	[AccessedThroughProperty("Node2")]
	private Node _Node2;

	[AccessedThroughProperty("Node19")]
	private Node _Node19;

	[AccessedThroughProperty("Node20")]
	private Node _Node20;

	[AccessedThroughProperty("Node21")]
	private Node _Node21;

	[AccessedThroughProperty("Node22")]
	private Node _Node22;

	[AccessedThroughProperty("Node23")]
	private Node _Node23;

	[AccessedThroughProperty("Node24")]
	private Node _Node24;

	[AccessedThroughProperty("Node25")]
	private Node _Node25;

	[AccessedThroughProperty("ColumnHeader3")]
	private ColumnHeader _ColumnHeader3;

	[AccessedThroughProperty("ColumnHeader4")]
	private ColumnHeader _ColumnHeader4;

	[AccessedThroughProperty("Node3")]
	private Node _Node3;

	[AccessedThroughProperty("Node26")]
	private Node _Node26;

	[AccessedThroughProperty("Node27")]
	private Node _Node27;

	[AccessedThroughProperty("Node28")]
	private Node _Node28;

	[AccessedThroughProperty("Node29")]
	private Node _Node29;

	[AccessedThroughProperty("Node30")]
	private Node _Node30;

	[AccessedThroughProperty("Node31")]
	private Node _Node31;

	[AccessedThroughProperty("ColumnHeader5")]
	private ColumnHeader _ColumnHeader5;

	[AccessedThroughProperty("ColumnHeader6")]
	private ColumnHeader _ColumnHeader6;

	[AccessedThroughProperty("Node4")]
	private Node _Node4;

	[AccessedThroughProperty("Node32")]
	private Node _Node32;

	[AccessedThroughProperty("Node33")]
	private Node _Node33;

	[AccessedThroughProperty("Node34")]
	private Node _Node34;

	[AccessedThroughProperty("ColumnHeader7")]
	private ColumnHeader _ColumnHeader7;

	[AccessedThroughProperty("ColumnHeader8")]
	private ColumnHeader _ColumnHeader8;

	[AccessedThroughProperty("Node5")]
	private Node _Node5;

	[AccessedThroughProperty("Node35")]
	private Node _Node35;

	[AccessedThroughProperty("Node36")]
	private Node _Node36;

	[AccessedThroughProperty("Node37")]
	private Node _Node37;

	[AccessedThroughProperty("Node38")]
	private Node _Node38;

	[AccessedThroughProperty("Node39")]
	private Node _Node39;

	[AccessedThroughProperty("Node40")]
	private Node _Node40;

	[AccessedThroughProperty("Node41")]
	private Node _Node41;

	[AccessedThroughProperty("Node42")]
	private Node _Node42;

	[AccessedThroughProperty("Node43")]
	private Node _Node43;

	[AccessedThroughProperty("ColumnHeader9")]
	private ColumnHeader _ColumnHeader9;

	[AccessedThroughProperty("ColumnHeader10")]
	private ColumnHeader _ColumnHeader10;

	[AccessedThroughProperty("Node8")]
	private Node _Node8;

	[AccessedThroughProperty("ColumnHeader11")]
	private ColumnHeader _ColumnHeader11;

	[AccessedThroughProperty("ColumnHeader12")]
	private ColumnHeader _ColumnHeader12;

	[AccessedThroughProperty("ColumnHeader13")]
	private ColumnHeader _ColumnHeader13;

	[AccessedThroughProperty("Node7")]
	private Node _Node7;

	[AccessedThroughProperty("ColumnHeader14")]
	private ColumnHeader _ColumnHeader14;

	[AccessedThroughProperty("ColumnHeader15")]
	private ColumnHeader _ColumnHeader15;

	[AccessedThroughProperty("ColumnHeader16")]
	private ColumnHeader _ColumnHeader16;

	[AccessedThroughProperty("Node44")]
	private Node _Node44;

	[AccessedThroughProperty("Node45")]
	private Node _Node45;

	[AccessedThroughProperty("Node9")]
	private Node _Node9;

	[AccessedThroughProperty("ColumnHeader18")]
	private ColumnHeader _ColumnHeader18;

	[AccessedThroughProperty("ColumnHeader19")]
	private ColumnHeader _ColumnHeader19;

	[AccessedThroughProperty("ColumnHeader20")]
	private ColumnHeader _ColumnHeader20;

	[AccessedThroughProperty("NodeConnector1")]
	private NodeConnector _NodeConnector1;

	[AccessedThroughProperty("Cell1")]
	private Cell _Cell1;

	[AccessedThroughProperty("Cell2")]
	private Cell _Cell2;

	[AccessedThroughProperty("Cell3")]
	private Cell _Cell3;

	[AccessedThroughProperty("Cell4")]
	private Cell _Cell4;

	[AccessedThroughProperty("Cell5")]
	private Cell _Cell5;

	[AccessedThroughProperty("Cell6")]
	private Cell _Cell6;

	[AccessedThroughProperty("Cell7")]
	private Cell _Cell7;

	[AccessedThroughProperty("Cell8")]
	private Cell _Cell8;

	[AccessedThroughProperty("Cell9")]
	private Cell _Cell9;

	[AccessedThroughProperty("Cell10")]
	private Cell _Cell10;

	[AccessedThroughProperty("Cell11")]
	private Cell _Cell11;

	[AccessedThroughProperty("Cell12")]
	private Cell _Cell12;

	[AccessedThroughProperty("Cell13")]
	private Cell _Cell13;

	[AccessedThroughProperty("Cell14")]
	private Cell _Cell14;

	[AccessedThroughProperty("Cell15")]
	private Cell _Cell15;

	[AccessedThroughProperty("Cell16")]
	private Cell _Cell16;

	[AccessedThroughProperty("Cell17")]
	private Cell _Cell17;

	[AccessedThroughProperty("Cell18")]
	private Cell _Cell18;

	[AccessedThroughProperty("Cell19")]
	private Cell _Cell19;

	[AccessedThroughProperty("Cell20")]
	private Cell _Cell20;

	[AccessedThroughProperty("Cell21")]
	private Cell _Cell21;

	[AccessedThroughProperty("Cell22")]
	private Cell _Cell22;

	[AccessedThroughProperty("Cell23")]
	private Cell _Cell23;

	[AccessedThroughProperty("Cell24")]
	private Cell _Cell24;

	[AccessedThroughProperty("Cell25")]
	private Cell _Cell25;

	[AccessedThroughProperty("Cell26")]
	private Cell _Cell26;

	[AccessedThroughProperty("Cell27")]
	private Cell _Cell27;

	[AccessedThroughProperty("Cell28")]
	private Cell _Cell28;

	[AccessedThroughProperty("Cell29")]
	private Cell _Cell29;

	[AccessedThroughProperty("Cell30")]
	private Cell _Cell30;

	[AccessedThroughProperty("Cell31")]
	private Cell _Cell31;

	[AccessedThroughProperty("Cell32")]
	private Cell _Cell32;

	[AccessedThroughProperty("Cell33")]
	private Cell _Cell33;

	[AccessedThroughProperty("Cell34")]
	private Cell _Cell34;

	[AccessedThroughProperty("Cell35")]
	private Cell _Cell35;

	[AccessedThroughProperty("Cell36")]
	private Cell _Cell36;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("Node6")]
	private Node _Node6;

	[AccessedThroughProperty("Node46")]
	private Node _Node46;

	[AccessedThroughProperty("Cell_KeyLocation")]
	private Cell _Cell_KeyLocation;

	[AccessedThroughProperty("Node47")]
	private Node _Node47;

	[AccessedThroughProperty("Cell_ActualName")]
	private Cell _Cell_ActualName;

	[AccessedThroughProperty("Node48")]
	private Node _Node48;

	[AccessedThroughProperty("Node49")]
	private Node _Node49;

	[AccessedThroughProperty("Cell38")]
	private Cell _Cell38;

	[AccessedThroughProperty("Node50")]
	private Node _Node50;

	[AccessedThroughProperty("Cell37")]
	private Cell _Cell37;

	[AccessedThroughProperty("Cell39")]
	private Cell _Cell39;

	[AccessedThroughProperty("Node51")]
	private Node _Node51;

	[AccessedThroughProperty("Cell40")]
	private Cell _Cell40;

	[AccessedThroughProperty("Cell41")]
	private Cell _Cell41;

	[AccessedThroughProperty("Node52")]
	private Node _Node52;

	[AccessedThroughProperty("Cell42")]
	private Cell _Cell42;

	[AccessedThroughProperty("Cell43")]
	private Cell _Cell43;

	[AccessedThroughProperty("Node53")]
	private Node _Node53;

	[AccessedThroughProperty("Cell44")]
	private Cell _Cell44;

	[AccessedThroughProperty("ColumnHeader17")]
	private ColumnHeader _ColumnHeader17;

	[AccessedThroughProperty("ColumnHeader21")]
	private ColumnHeader _ColumnHeader21;

	[AccessedThroughProperty("Node54")]
	private Node _Node54;

	[AccessedThroughProperty("Node55")]
	private Node _Node55;

	[AccessedThroughProperty("Cell45")]
	private Cell _Cell45;

	[AccessedThroughProperty("FolderBrowserDialog1")]
	private FolderBrowserDialog _FolderBrowserDialog1;

	[AccessedThroughProperty("StatusStrip1")]
	private StatusStrip _StatusStrip1;

	[AccessedThroughProperty("ts_StatusLabel1")]
	private ToolStripStatusLabel _ts_StatusLabel1;

	[AccessedThroughProperty("ts_ProgressBar1")]
	private ToolStripProgressBar _ts_ProgressBar1;

	[AccessedThroughProperty("Keys")]
	private Node _Keys;

	[AccessedThroughProperty("Node57")]
	private Node _Node57;

	[AccessedThroughProperty("Node58")]
	private Node _Node58;

	[AccessedThroughProperty("Node59")]
	private Node _Node59;

	[AccessedThroughProperty("Template")]
	private Node _Template;

	[AccessedThroughProperty("ElementStyle1")]
	private ElementStyle _ElementStyle1;

	[AccessedThroughProperty("TotalKeysDisplayed")]
	private Cell _TotalKeysDisplayed;

	[AccessedThroughProperty("TotalKeysDisplayed0")]
	private Cell _TotalKeysDisplayed0;

	[AccessedThroughProperty("TotalKeysDisplayed1")]
	private Cell _TotalKeysDisplayed1;

	[AccessedThroughProperty("TotalKeysDisplayed2")]
	private Cell _TotalKeysDisplayed2;

	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	[AccessedThroughProperty("ContextMenuStrip1")]
	private ContextMenuStrip _ContextMenuStrip1;

	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[AccessedThroughProperty("RemoveCheckedKeysToolStripMenuItem")]
	private ToolStripMenuItem _RemoveCheckedKeysToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("ts_StatusLabel2")]
	private ToolStripStatusLabel _ts_StatusLabel2;

	private object ReportKeyToDan;

	private bool JustLoaded;

	private object OpenDirectoryPath;

	private string SaveDirectoryPath;

	private string NotExpired;

	private string NotBlacklisted_NotExpired;

	private string ExpiredOrBlacklisted;

	private object OpeningFilesNumber;

	private object OpeningFilesTotal;

	private int OpeningFilesKeysFound;

	private bool CancelOperation;

	[AccessedThroughProperty("KeyWorker")]
	private BackgroundWorker _KeyWorker;

	private bool KeyReadingResult;

	internal virtual AdvTree AdvTree1
	{
		[DebuggerNonUserCode]
		get
		{
			return _AdvTree1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			AdvTreeCellEventHandler value2 = AdvTree1_AfterCheck;
			TreeNodeCollectionEventHandler value3 = AdvTree1_AfterNodeRemove;
			TreeNodeCollectionEventHandler value4 = AdvTree1_AfterNodeInsert;
			if (_AdvTree1 != null)
			{
				_AdvTree1.AfterCheck -= value2;
				_AdvTree1.AfterNodeRemove -= value3;
				_AdvTree1.AfterNodeInsert -= value4;
			}
			_AdvTree1 = value;
			if (_AdvTree1 != null)
			{
				_AdvTree1.AfterCheck += value2;
				_AdvTree1.AfterNodeRemove += value3;
				_AdvTree1.AfterNodeInsert += value4;
			}
		}
	}

	internal virtual Node FileName
	{
		[DebuggerNonUserCode]
		get
		{
			return _FileName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_FileName = value;
		}
	}

	internal virtual Node Node1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node1 = value;
		}
	}

	internal virtual Node Node10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node10 = value;
		}
	}

	internal virtual Node Node11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node11 = value;
		}
	}

	internal virtual Node Node12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node12 = value;
		}
	}

	internal virtual Node Node13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node13 = value;
		}
	}

	internal virtual Node Node14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node14 = value;
		}
	}

	internal virtual Node Node15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node15 = value;
		}
	}

	internal virtual Node Node16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node16 = value;
		}
	}

	internal virtual Node Node17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node17 = value;
		}
	}

	internal virtual Node Node18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node18 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader1 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader2 = value;
		}
	}

	internal virtual Node Node2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node2 = value;
		}
	}

	internal virtual Node Node19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node19 = value;
		}
	}

	internal virtual Node Node20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node20 = value;
		}
	}

	internal virtual Node Node21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node21 = value;
		}
	}

	internal virtual Node Node22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node22 = value;
		}
	}

	internal virtual Node Node23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node23 = value;
		}
	}

	internal virtual Node Node24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node24 = value;
		}
	}

	internal virtual Node Node25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node25 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader3 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader4 = value;
		}
	}

	internal virtual Node Node3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node3 = value;
		}
	}

	internal virtual Node Node26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node26 = value;
		}
	}

	internal virtual Node Node27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node27 = value;
		}
	}

	internal virtual Node Node28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node28 = value;
		}
	}

	internal virtual Node Node29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node29 = value;
		}
	}

	internal virtual Node Node30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node30 = value;
		}
	}

	internal virtual Node Node31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node31 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader5 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader6
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader6 = value;
		}
	}

	internal virtual Node Node4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node4 = value;
		}
	}

	internal virtual Node Node32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node32 = value;
		}
	}

	internal virtual Node Node33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node33 = value;
		}
	}

	internal virtual Node Node34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node34 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader7
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader7 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader8
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader8 = value;
		}
	}

	internal virtual Node Node5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node5 = value;
		}
	}

	internal virtual Node Node35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node35 = value;
		}
	}

	internal virtual Node Node36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node36 = value;
		}
	}

	internal virtual Node Node37
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node37 = value;
		}
	}

	internal virtual Node Node38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node38 = value;
		}
	}

	internal virtual Node Node39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node39 = value;
		}
	}

	internal virtual Node Node40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node40 = value;
		}
	}

	internal virtual Node Node41
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node41 = value;
		}
	}

	internal virtual Node Node42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node42 = value;
		}
	}

	internal virtual Node Node43
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node43 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader9
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader9 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader10
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader10 = value;
		}
	}

	internal virtual Node Node8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node8 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader11
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader11 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader12
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader12 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader13
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader13 = value;
		}
	}

	internal virtual Node Node7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node7 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader14
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader14 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader15
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader15 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader16
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader16 = value;
		}
	}

	internal virtual Node Node44
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node44 = value;
		}
	}

	internal virtual Node Node45
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node45 = value;
		}
	}

	internal virtual Node Node9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node9 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader18
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader18 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader19
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader19 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader20
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader20 = value;
		}
	}

	internal virtual NodeConnector NodeConnector1
	{
		[DebuggerNonUserCode]
		get
		{
			return _NodeConnector1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_NodeConnector1 = value;
		}
	}

	internal virtual Cell Cell1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell1 = value;
		}
	}

	internal virtual Cell Cell2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell2 = value;
		}
	}

	internal virtual Cell Cell3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell3 = value;
		}
	}

	internal virtual Cell Cell4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell4 = value;
		}
	}

	internal virtual Cell Cell5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell5 = value;
		}
	}

	internal virtual Cell Cell6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell6 = value;
		}
	}

	internal virtual Cell Cell7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell7 = value;
		}
	}

	internal virtual Cell Cell8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell8 = value;
		}
	}

	internal virtual Cell Cell9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell9 = value;
		}
	}

	internal virtual Cell Cell10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell10 = value;
		}
	}

	internal virtual Cell Cell11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell11 = value;
		}
	}

	internal virtual Cell Cell12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell12 = value;
		}
	}

	internal virtual Cell Cell13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell13 = value;
		}
	}

	internal virtual Cell Cell14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell14 = value;
		}
	}

	internal virtual Cell Cell15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell15 = value;
		}
	}

	internal virtual Cell Cell16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell16 = value;
		}
	}

	internal virtual Cell Cell17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell17 = value;
		}
	}

	internal virtual Cell Cell18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell18 = value;
		}
	}

	internal virtual Cell Cell19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell19 = value;
		}
	}

	internal virtual Cell Cell20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell20 = value;
		}
	}

	internal virtual Cell Cell21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell21 = value;
		}
	}

	internal virtual Cell Cell22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell22 = value;
		}
	}

	internal virtual Cell Cell23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell23 = value;
		}
	}

	internal virtual Cell Cell24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell24 = value;
		}
	}

	internal virtual Cell Cell25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell25 = value;
		}
	}

	internal virtual Cell Cell26
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell26 = value;
		}
	}

	internal virtual Cell Cell27
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell27 = value;
		}
	}

	internal virtual Cell Cell28
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell28 = value;
		}
	}

	internal virtual Cell Cell29
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell29 = value;
		}
	}

	internal virtual Cell Cell30
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell30 = value;
		}
	}

	internal virtual Cell Cell31
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell31 = value;
		}
	}

	internal virtual Cell Cell32
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell32 = value;
		}
	}

	internal virtual Cell Cell33
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell33 = value;
		}
	}

	internal virtual Cell Cell34
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell34 = value;
		}
	}

	internal virtual Cell Cell35
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell35 = value;
		}
	}

	internal virtual Cell Cell36
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell36 = value;
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

	internal virtual Node Node6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node6 = value;
		}
	}

	internal virtual Node Node46
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node46 = value;
		}
	}

	internal virtual Cell Cell_KeyLocation
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell_KeyLocation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell_KeyLocation = value;
		}
	}

	internal virtual Node Node47
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node47 = value;
		}
	}

	internal virtual Cell Cell_ActualName
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell_ActualName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell_ActualName = value;
		}
	}

	internal virtual Node Node48
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node48 = value;
		}
	}

	internal virtual Node Node49
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node49 = value;
		}
	}

	internal virtual Cell Cell38
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell38 = value;
		}
	}

	internal virtual Node Node50
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node50 = value;
		}
	}

	internal virtual Cell Cell37
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell37 = value;
		}
	}

	internal virtual Cell Cell39
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell39 = value;
		}
	}

	internal virtual Node Node51
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node51 = value;
		}
	}

	internal virtual Cell Cell40
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell40 = value;
		}
	}

	internal virtual Cell Cell41
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell41 = value;
		}
	}

	internal virtual Node Node52
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node52 = value;
		}
	}

	internal virtual Cell Cell42
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell42 = value;
		}
	}

	internal virtual Cell Cell43
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell43 = value;
		}
	}

	internal virtual Node Node53
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node53 = value;
		}
	}

	internal virtual Cell Cell44
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell44 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader17
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader17 = value;
		}
	}

	internal virtual ColumnHeader ColumnHeader21
	{
		[DebuggerNonUserCode]
		get
		{
			return _ColumnHeader21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ColumnHeader21 = value;
		}
	}

	internal virtual Node Node54
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node54 = value;
		}
	}

	internal virtual Node Node55
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node55 = value;
		}
	}

	internal virtual Cell Cell45
	{
		[DebuggerNonUserCode]
		get
		{
			return _Cell45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Cell45 = value;
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

	internal virtual ToolStripStatusLabel ts_StatusLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_StatusLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_StatusLabel1 = value;
		}
	}

	internal virtual ToolStripProgressBar ts_ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_ProgressBar1 = value;
		}
	}

	internal virtual Node Keys
	{
		[DebuggerNonUserCode]
		get
		{
			return _Keys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Keys = value;
		}
	}

	internal virtual Node Node57
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node57 = value;
		}
	}

	internal virtual Node Node58
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node58 = value;
		}
	}

	internal virtual Node Node59
	{
		[DebuggerNonUserCode]
		get
		{
			return _Node59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Node59 = value;
		}
	}

	internal virtual Node Template
	{
		[DebuggerNonUserCode]
		get
		{
			return _Template;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Template = value;
		}
	}

	internal virtual ElementStyle ElementStyle1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ElementStyle1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ElementStyle1 = value;
		}
	}

	internal virtual Cell TotalKeysDisplayed
	{
		[DebuggerNonUserCode]
		get
		{
			return _TotalKeysDisplayed;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TotalKeysDisplayed = value;
		}
	}

	internal virtual Cell TotalKeysDisplayed0
	{
		[DebuggerNonUserCode]
		get
		{
			return _TotalKeysDisplayed0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TotalKeysDisplayed0 = value;
		}
	}

	internal virtual Cell TotalKeysDisplayed1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TotalKeysDisplayed1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TotalKeysDisplayed1 = value;
		}
	}

	internal virtual Cell TotalKeysDisplayed2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TotalKeysDisplayed2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TotalKeysDisplayed2 = value;
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
			EventHandler eventHandler = Button4_Click;
			if (_Button4 != null)
			{
				((Control)_Button4).remove_Click(eventHandler);
			}
			_Button4 = value;
			if (_Button4 != null)
			{
				((Control)_Button4).add_Click(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ContextMenuStrip1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ContextMenuStrip1 = value;
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem1_Click;
			if (_ToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ToolStripMenuItem1).remove_Click(eventHandler);
			}
			_ToolStripMenuItem1 = value;
			if (_ToolStripMenuItem1 != null)
			{
				((ToolStripItem)_ToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem2_Click;
			if (_ToolStripMenuItem2 != null)
			{
				((ToolStripItem)_ToolStripMenuItem2).remove_Click(eventHandler);
			}
			_ToolStripMenuItem2 = value;
			if (_ToolStripMenuItem2 != null)
			{
				((ToolStripItem)_ToolStripMenuItem2).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveCheckedKeysToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveCheckedKeysToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveCheckedKeysToolStripMenuItem_Click;
			if (_RemoveCheckedKeysToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveCheckedKeysToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveCheckedKeysToolStripMenuItem = value;
			if (_RemoveCheckedKeysToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveCheckedKeysToolStripMenuItem).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem ToolStripMenuItem3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem3_Click;
			if (_ToolStripMenuItem3 != null)
			{
				((ToolStripItem)_ToolStripMenuItem3).remove_Click(eventHandler);
			}
			_ToolStripMenuItem3 = value;
			if (_ToolStripMenuItem3 != null)
			{
				((ToolStripItem)_ToolStripMenuItem3).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripMenuItem4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ToolStripMenuItem4 = value;
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

	internal virtual ToolStripStatusLabel ts_StatusLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ts_StatusLabel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ts_StatusLabel2 = value;
		}
	}

	private virtual BackgroundWorker KeyWorker
	{
		[DebuggerNonUserCode]
		get
		{
			return _KeyWorker;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			RunWorkerCompletedEventHandler value2 = KeyWorker_RunWorkerCompleted;
			DoWorkEventHandler value3 = KeyWorker_DoWork;
			if (_KeyWorker != null)
			{
				_KeyWorker.RunWorkerCompleted -= value2;
				_KeyWorker.DoWork -= value3;
			}
			_KeyWorker = value;
			if (_KeyWorker != null)
			{
				_KeyWorker.RunWorkerCompleted += value2;
				_KeyWorker.DoWork += value3;
			}
		}
	}

	public form_KeyViewer()
	{
		((Form)this).add_Shown((EventHandler)form_KeyViewer_Shown);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		ReportKeyToDan = false;
		JustLoaded = true;
		OpenDirectoryPath = Environment.SpecialFolder.Personal;
		SaveDirectoryPath = Conversions.ToString(5);
		NotExpired = "<h3><font color=\"#1919F2\"><b>";
		NotBlacklisted_NotExpired = "<h3><font color=\"#4E5D30\"><b>";
		ExpiredOrBlacklisted = "<h3><font color=\"#ED1C24\"><b>";
		OpeningFilesNumber = 0;
		OpeningFilesTotal = 0;
		OpeningFilesKeysFound = 0;
		CancelOperation = false;
		KeyReadingResult = false;
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
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_2851: Unknown result type (might be due to invalid IL or missing references)
		//IL_285b: Expected O, but got Unknown
		//IL_2937: Unknown result type (might be due to invalid IL or missing references)
		//IL_2941: Expected O, but got Unknown
		//IL_2a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a2b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(form_KeyViewer));
		AdvTree1 = new AdvTree();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		ToolStripMenuItem1 = new ToolStripMenuItem();
		RemoveCheckedKeysToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem2 = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		ToolStripMenuItem3 = new ToolStripMenuItem();
		ToolStripMenuItem4 = new ToolStripMenuItem();
		Label1 = new Label();
		Template = new Node();
		FileName = new Node();
		Cell38 = new Cell();
		Node46 = new Node();
		Cell_KeyLocation = new Cell();
		Node47 = new Node();
		Cell39 = new Cell();
		Node50 = new Node();
		Cell37 = new Cell();
		Node55 = new Node();
		Cell45 = new Cell();
		Node1 = new Node();
		Node10 = new Node();
		Cell1 = new Cell();
		Node11 = new Node();
		Cell2 = new Cell();
		Node12 = new Node();
		Cell3 = new Cell();
		Node13 = new Node();
		Cell4 = new Cell();
		Node14 = new Node();
		Cell5 = new Cell();
		Node15 = new Node();
		Cell6 = new Cell();
		Node16 = new Node();
		Cell7 = new Cell();
		Node17 = new Node();
		Cell8 = new Cell();
		Node18 = new Node();
		Cell9 = new Cell();
		ColumnHeader1 = new ColumnHeader();
		ColumnHeader2 = new ColumnHeader();
		Node2 = new Node();
		Node19 = new Node();
		Cell10 = new Cell();
		Node20 = new Node();
		Cell11 = new Cell();
		Node21 = new Node();
		Cell12 = new Cell();
		Node22 = new Node();
		Cell13 = new Cell();
		Node23 = new Node();
		Cell14 = new Cell();
		Node24 = new Node();
		Cell15 = new Cell();
		Node25 = new Node();
		Cell16 = new Cell();
		ColumnHeader3 = new ColumnHeader();
		ColumnHeader4 = new ColumnHeader();
		Node3 = new Node();
		Node26 = new Node();
		Cell17 = new Cell();
		Node27 = new Node();
		Cell18 = new Cell();
		Node28 = new Node();
		Cell19 = new Cell();
		Node29 = new Node();
		Cell20 = new Cell();
		Node30 = new Node();
		Cell21 = new Cell();
		Node31 = new Node();
		Cell22 = new Cell();
		ColumnHeader5 = new ColumnHeader();
		ColumnHeader6 = new ColumnHeader();
		Node4 = new Node();
		Node32 = new Node();
		Cell23 = new Cell();
		Node33 = new Node();
		Cell24 = new Cell();
		Node34 = new Node();
		Cell25 = new Cell();
		ColumnHeader7 = new ColumnHeader();
		ColumnHeader8 = new ColumnHeader();
		Node5 = new Node();
		Node35 = new Node();
		Cell26 = new Cell();
		Node36 = new Node();
		Cell27 = new Cell();
		Node37 = new Node();
		Cell28 = new Cell();
		Node38 = new Node();
		Cell29 = new Cell();
		Node39 = new Node();
		Cell30 = new Cell();
		Node40 = new Node();
		Cell31 = new Cell();
		Node41 = new Node();
		Cell32 = new Cell();
		Node42 = new Node();
		Cell33 = new Cell();
		Node43 = new Node();
		Cell34 = new Cell();
		ColumnHeader9 = new ColumnHeader();
		ColumnHeader10 = new ColumnHeader();
		Node8 = new Node();
		Node51 = new Node();
		Cell40 = new Cell();
		Cell41 = new Cell();
		ColumnHeader11 = new ColumnHeader();
		ColumnHeader12 = new ColumnHeader();
		ColumnHeader13 = new ColumnHeader();
		Node7 = new Node();
		Node52 = new Node();
		Cell42 = new Cell();
		Cell43 = new Cell();
		ColumnHeader14 = new ColumnHeader();
		ColumnHeader15 = new ColumnHeader();
		ColumnHeader16 = new ColumnHeader();
		Node44 = new Node();
		Node45 = new Node();
		Cell35 = new Cell();
		Node9 = new Node();
		Cell36 = new Cell();
		ColumnHeader18 = new ColumnHeader();
		ColumnHeader19 = new ColumnHeader();
		ColumnHeader20 = new ColumnHeader();
		Node6 = new Node();
		Node53 = new Node();
		Cell44 = new Cell();
		ColumnHeader17 = new ColumnHeader();
		ColumnHeader21 = new ColumnHeader();
		Node54 = new Node();
		Keys = new Node();
		TotalKeysDisplayed = new Cell();
		Node58 = new Node();
		TotalKeysDisplayed0 = new Cell();
		Node59 = new Node();
		TotalKeysDisplayed1 = new Cell();
		Node57 = new Node();
		TotalKeysDisplayed2 = new Cell();
		NodeConnector1 = new NodeConnector();
		ElementStyle1 = new ElementStyle();
		Cell_ActualName = new Cell();
		OpenFileDialog1 = new OpenFileDialog();
		Node48 = new Node();
		Node49 = new Node();
		FolderBrowserDialog1 = new FolderBrowserDialog();
		StatusStrip1 = new StatusStrip();
		ts_StatusLabel1 = new ToolStripStatusLabel();
		ts_StatusLabel2 = new ToolStripStatusLabel();
		ts_ProgressBar1 = new ToolStripProgressBar();
		Button4 = new Button();
		((ISupportInitialize)AdvTree1).BeginInit();
		((Control)AdvTree1).SuspendLayout();
		((Control)ContextMenuStrip1).SuspendLayout();
		((Control)StatusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)AdvTree1).set_AccessibleRole((AccessibleRole)35);
		((Control)AdvTree1).set_AllowDrop(true);
		((Control)AdvTree1).set_Anchor((AnchorStyles)15);
		((Control)AdvTree1).set_BackColor(SystemColors.Window);
		AdvTree1.BackgroundStyle.Class = "TreeBorderKey";
		((Control)AdvTree1).set_ContextMenuStrip(ContextMenuStrip1);
		((Control)AdvTree1).get_Controls().Add((Control)(object)Label1);
		AdvTree1.GridRowLines = true;
		AdvTree1.HotTracking = true;
		AdvTree advTree = AdvTree1;
		Point location = new Point(0, 0);
		((Control)advTree).set_Location(location);
		((Control)AdvTree1).set_Name("AdvTree1");
		AdvTree1.Nodes.AddRange(new Node[1] { Template });
		AdvTree1.NodesConnector = NodeConnector1;
		AdvTree1.NodeStyle = ElementStyle1;
		AdvTree1.PathSeparator = ";";
		AdvTree advTree2 = AdvTree1;
		Size size = new Size(652, 416);
		((Control)advTree2).set_Size(size);
		AdvTree1.Styles.Add(ElementStyle1);
		((Control)AdvTree1).set_TabIndex(1);
		((Control)AdvTree1).set_Text("AdvTree1");
		((ToolStrip)ContextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)RemoveCheckedKeysToolStripMenuItem,
			(ToolStripItem)ToolStripMenuItem2,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)ToolStripMenuItem3,
			(ToolStripItem)ToolStripMenuItem4
		});
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		ContextMenuStrip contextMenuStrip = ContextMenuStrip1;
		size = new Size(265, 120);
		((Control)contextMenuStrip).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		ToolStripMenuItem toolStripMenuItem = ToolStripMenuItem1;
		size = new Size(264, 22);
		((ToolStripItem)toolStripMenuItem).set_Size(size);
		((ToolStripItem)ToolStripMenuItem1).set_Text("Add Keys.");
		((ToolStripItem)RemoveCheckedKeysToolStripMenuItem).set_Name("RemoveCheckedKeysToolStripMenuItem");
		ToolStripMenuItem removeCheckedKeysToolStripMenuItem = RemoveCheckedKeysToolStripMenuItem;
		size = new Size(264, 22);
		((ToolStripItem)removeCheckedKeysToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveCheckedKeysToolStripMenuItem).set_Text("Remove Checked Keys.");
		((ToolStripItem)ToolStripMenuItem2).set_Name("ToolStripMenuItem2");
		ToolStripMenuItem toolStripMenuItem2 = ToolStripMenuItem2;
		size = new Size(264, 22);
		((ToolStripItem)toolStripMenuItem2).set_Size(size);
		((ToolStripItem)ToolStripMenuItem2).set_Text("Remove All Keys.");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator1;
		size = new Size(261, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Name("ToolStripMenuItem3");
		ToolStripMenuItem toolStripMenuItem3 = ToolStripMenuItem3;
		size = new Size(264, 22);
		((ToolStripItem)toolStripMenuItem3).set_Size(size);
		((ToolStripItem)ToolStripMenuItem3).set_Text("Save Selected Keys with Correct Name.");
		ToolStripMenuItem4.set_Checked(true);
		ToolStripMenuItem4.set_CheckOnClick(true);
		ToolStripMenuItem4.set_CheckState((CheckState)1);
		((ToolStripItem)ToolStripMenuItem4).set_Name("ToolStripMenuItem4");
		ToolStripMenuItem toolStripMenuItem4 = ToolStripMenuItem4;
		size = new Size(264, 22);
		((ToolStripItem)toolStripMenuItem4).set_Size(size);
		((ToolStripItem)ToolStripMenuItem4).set_Text("Overwrite Same File Name.");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(SystemColors.ActiveCaption);
		Label label = Label1;
		location = new Point(218, 214);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(216, 20);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("Right Click Here to Add Keys.");
		Template.Expanded = true;
		Template.Name = "Template";
		Template.Nodes.AddRange(new Node[2] { FileName, Keys });
		Template.Text = "Template";
		Template.Visible = false;
		FileName.Cells.Add(Cell38);
		FileName.CheckBoxVisible = true;
		FileName.Expanded = true;
		FileName.Name = "FileName";
		FileName.Nodes.AddRange(new Node[14]
		{
			Node46, Node47, Node50, Node55, Node1, Node2, Node3, Node4, Node5, Node8,
			Node7, Node44, Node6, Node54
		});
		FileName.Text = "<h3><font color=\"#1919F1\"><b>File Name</b></font></h3>";
		Cell38.Name = "Cell38";
		Cell38.StyleMouseOver = null;
		Cell38.Text = " (<font color=\"#ED1C24\"><b>Please report this Key for software improvment.</b></font>)";
		Node46.Cells.Add(Cell_KeyLocation);
		Node46.Name = "Node46";
		Node46.Text = "<h4><font color=\"#C0504D\"><b>Key Location:</b></font></h4>";
		Cell_KeyLocation.Name = "Cell_KeyLocation";
		Cell_KeyLocation.StyleMouseOver = null;
		Node47.Cells.Add(Cell39);
		Node47.Expanded = true;
		Node47.Name = "Node47";
		Node47.Text = "<h4><font color=\"#C0504D\"><b>File Actual Name:</b></font></h4>";
		Cell39.Name = "Cell39";
		Cell39.StyleMouseOver = null;
		Node50.Cells.Add(Cell37);
		Node50.Expanded = true;
		Node50.Name = "Node50";
		Node50.Text = "<h4><font color=\"#C0504D\"><b>Blacklist Status:</b></font></h4>";
		Cell37.Name = "Cell37";
		Cell37.StyleMouseOver = null;
		Cell37.Text = "<b><font color=\"#5C83B4\">Unavailable.</font></b>";
		Node55.Cells.Add(Cell45);
		Node55.Expanded = true;
		Node55.Name = "Node55";
		Node55.Text = "<h4><font color=\"#C0504D\"><b>Expired:</b></font></h4>";
		Cell45.Name = "Cell45";
		Cell45.StyleMouseOver = null;
		Node1.Expanded = true;
		Node1.Name = "Node1";
		Node1.Nodes.AddRange(new Node[9] { Node10, Node11, Node12, Node13, Node14, Node15, Node16, Node17, Node18 });
		Node1.NodesColumns.Add(ColumnHeader1);
		Node1.NodesColumns.Add(ColumnHeader2);
		Node1.Text = "<h5><font color=\"#17365D\"><b>General</b></font></h5>";
		Node10.Cells.Add(Cell1);
		Node10.Name = "Node10";
		Node10.Text = "<b>Type</b>";
		Cell1.Name = "Cell1";
		Cell1.StyleMouseOver = null;
		Node11.Cells.Add(Cell2);
		Node11.Name = "Node11";
		Node11.Text = "<b>Description</b>";
		Cell2.Name = "Cell2";
		Cell2.StyleMouseOver = null;
		Node12.Cells.Add(Cell3);
		Node12.Name = "Node12";
		Node12.Text = "<b>Version</b>";
		Cell3.Name = "Cell3";
		Cell3.StyleMouseOver = null;
		Node13.Cells.Add(Cell4);
		Node13.Name = "Node13";
		Node13.Text = "<b>Serial Number</b>";
		Cell4.Name = "Cell4";
		Cell4.StyleMouseOver = null;
		Node14.Cells.Add(Cell5);
		Node14.Name = "Node14";
		Node14.Text = "<b>Date Created</b>";
		Cell5.Name = "Cell5";
		Cell5.StyleMouseOver = null;
		Node15.Cells.Add(Cell6);
		Node15.Name = "Node15";
		Node15.Text = "<b>Request GUID</b>";
		Cell6.Name = "Cell6";
		Cell6.StyleMouseOver = null;
		Node16.Cells.Add(Cell7);
		Node16.Name = "Node16";
		Node16.Text = "<b>Parent GUID</b>";
		Cell7.Name = "Cell7";
		Cell7.StyleMouseOver = null;
		Node17.Cells.Add(Cell8);
		Node17.Name = "Node17";
		Node17.Text = "<b>Parent Number</b>";
		Cell8.Name = "Cell8";
		Cell8.StyleMouseOver = null;
		Node18.Cells.Add(Cell9);
		Node18.Name = "Node18";
		Node18.Text = "<b>Category</b>";
		Cell9.Name = "Cell9";
		Cell9.StyleMouseOver = null;
		ColumnHeader1.Name = "ColumnHeader1";
		ColumnHeader1.Text = "Name";
		ColumnHeader1.Width.Relative = 15;
		ColumnHeader2.Name = "ColumnHeader2";
		ColumnHeader2.Text = "Value";
		ColumnHeader2.Width.Relative = 75;
		Node2.Name = "Node2";
		Node2.Nodes.AddRange(new Node[7] { Node19, Node20, Node21, Node22, Node23, Node24, Node25 });
		Node2.NodesColumns.Add(ColumnHeader3);
		Node2.NodesColumns.Add(ColumnHeader4);
		Node2.Text = "<h5><font color=\"#17365D\"><b>Licence</b></font></h5>";
		Node19.Cells.Add(Cell10);
		Node19.Name = "Node19";
		Node19.Text = "<b>Licence Type</b>";
		Cell10.Name = "Cell10";
		Cell10.StyleMouseOver = null;
		Node20.Cells.Add(Cell11);
		Node20.Name = "Node20";
		Node20.Text = "<b>Key is Trial</b>";
		Cell11.Name = "Cell11";
		Cell11.StyleMouseOver = null;
		Node21.Cells.Add(Cell12);
		Node21.Name = "Node21";
		Node21.Text = "<b>Key is Personal</b>";
		Cell12.Name = "Cell12";
		Cell12.StyleMouseOver = null;
		Node22.Cells.Add(Cell13);
		Node22.Name = "Node22";
		Node22.Text = "<b>Life Span</b>";
		Cell13.Name = "Cell13";
		Cell13.StyleMouseOver = null;
		Node23.Cells.Add(Cell14);
		Node23.Name = "Node23";
		Node23.Text = "<b>Expiry Date</b>";
		Cell14.Name = "Cell14";
		Cell14.StyleMouseOver = null;
		Node24.Cells.Add(Cell15);
		Node24.Name = "Node24";
		Node24.Text = "<b>Licence Count</b>";
		Cell15.Name = "Cell15";
		Cell15.StyleMouseOver = null;
		Node25.Cells.Add(Cell16);
		Node25.Name = "Node25";
		Node25.Text = "<b>Key Has Support</b>";
		Cell16.Name = "Cell16";
		Cell16.StyleMouseOver = null;
		ColumnHeader3.Name = "ColumnHeader3";
		ColumnHeader3.Text = "Name";
		ColumnHeader3.Width.Relative = 15;
		ColumnHeader4.Name = "ColumnHeader4";
		ColumnHeader4.Text = "Value";
		ColumnHeader4.Width.Relative = 75;
		Node3.Name = "Node3";
		Node3.Nodes.AddRange(new Node[6] { Node26, Node27, Node28, Node29, Node30, Node31 });
		Node3.NodesColumns.Add(ColumnHeader5);
		Node3.NodesColumns.Add(ColumnHeader6);
		Node3.Text = "<h5><font color=\"#17365D\"><b>Product</b></font></h5>";
		Node26.Cells.Add(Cell17);
		Node26.Name = "Node26";
		Node26.Text = "<b>Application ID</b>";
		Cell17.Name = "Cell17";
		Cell17.StyleMouseOver = null;
		Node27.Cells.Add(Cell18);
		Node27.Name = "Node27";
		Node27.Text = "<b>Application Name</b>";
		Cell18.Name = "Cell18";
		Cell18.StyleMouseOver = null;
		Node28.Cells.Add(Cell19);
		Node28.Name = "Node28";
		Node28.Text = "<b>Product ID</b>";
		Cell19.Name = "Cell19";
		Cell19.StyleMouseOver = null;
		Node29.Cells.Add(Cell20);
		Node29.Name = "Node29";
		Node29.Text = "<b>Product Version</b>";
		Cell20.Name = "Cell20";
		Cell20.StyleMouseOver = null;
		Node30.Cells.Add(Cell21);
		Node30.Name = "Node30";
		Node30.Text = "<b>Market Sector</b>";
		Cell21.Name = "Cell21";
		Cell21.StyleMouseOver = null;
		Node31.Cells.Add(Cell22);
		Node31.Name = "Node31";
		Node31.Text = "<b>Sales Channel</b>";
		Cell22.Name = "Cell22";
		Cell22.StyleMouseOver = null;
		ColumnHeader5.Name = "ColumnHeader5";
		ColumnHeader5.Text = "Name";
		ColumnHeader5.Width.Relative = 15;
		ColumnHeader6.Name = "ColumnHeader6";
		ColumnHeader6.Text = "Value";
		ColumnHeader6.Width.Relative = 75;
		Node4.Name = "Node4";
		Node4.Nodes.AddRange(new Node[3] { Node32, Node33, Node34 });
		Node4.NodesColumns.Add(ColumnHeader7);
		Node4.NodesColumns.Add(ColumnHeader8);
		Node4.Text = "<h5><font color=\"#17365D\"><b>Partner</b></font></h5>";
		Node32.Cells.Add(Cell23);
		Node32.Name = "Node32";
		Node32.Text = "<b>Partner ID</b>";
		Cell23.Name = "Cell23";
		Cell23.StyleMouseOver = null;
		Node33.Cells.Add(Cell24);
		Node33.Name = "Node33";
		Node33.Text = "<b>Partner Name</b>";
		Cell24.Name = "Cell24";
		Cell24.StyleMouseOver = null;
		Node34.Cells.Add(Cell25);
		Node34.Name = "Node34";
		Node34.Text = "<b>Reseller</b>";
		Cell25.Name = "Cell25";
		Cell25.StyleMouseOver = null;
		ColumnHeader7.Name = "ColumnHeader7";
		ColumnHeader7.Text = "Name";
		ColumnHeader7.Width.Relative = 15;
		ColumnHeader8.Name = "ColumnHeader8";
		ColumnHeader8.Text = "Value";
		ColumnHeader8.Width.Relative = 75;
		Node5.Name = "Node5";
		Node5.Nodes.AddRange(new Node[9] { Node35, Node36, Node37, Node38, Node39, Node40, Node41, Node42, Node43 });
		Node5.NodesColumns.Add(ColumnHeader9);
		Node5.NodesColumns.Add(ColumnHeader10);
		Node5.Text = "<h5><font color=\"#17365D\"><b>Customer</b></font></h5>";
		Node35.Cells.Add(Cell26);
		Node35.Name = "Node35";
		Node35.Text = "<b>Company</b>";
		Cell26.Name = "Cell26";
		Cell26.StyleMouseOver = null;
		Node36.Cells.Add(Cell27);
		Node36.Name = "Node36";
		Node36.Text = "<b>Name</b>";
		Cell27.Name = "Cell27";
		Cell27.StyleMouseOver = null;
		Node37.Cells.Add(Cell28);
		Node37.Name = "Node37";
		Node37.Text = "<b>Country</b>";
		Cell28.Name = "Cell28";
		Cell28.StyleMouseOver = null;
		Node38.Cells.Add(Cell29);
		Node38.Name = "Node38";
		Node38.Text = "<b>City</b>";
		Cell29.Name = "Cell29";
		Cell29.StyleMouseOver = null;
		Node39.Cells.Add(Cell30);
		Node39.Name = "Node39";
		Node39.Text = "<b>Address</b>";
		Cell30.Name = "Cell30";
		Cell30.StyleMouseOver = null;
		Node40.Cells.Add(Cell31);
		Node40.Name = "Node40";
		Node40.Text = "<b>Phone</b>";
		Cell31.Name = "Cell31";
		Cell31.StyleMouseOver = null;
		Node41.Cells.Add(Cell32);
		Node41.Name = "Node41";
		Node41.Text = "<b>Fax</b>";
		Cell32.Name = "Cell32";
		Cell32.StyleMouseOver = null;
		Node42.Cells.Add(Cell33);
		Node42.Name = "Node42";
		Node42.Text = "<b>eMail</b>";
		Cell33.Name = "Cell33";
		Cell33.StyleMouseOver = null;
		Node43.Cells.Add(Cell34);
		Node43.Name = "Node43";
		Node43.Text = "<b>Site</b>";
		Cell34.Name = "Cell34";
		Cell34.StyleMouseOver = null;
		ColumnHeader9.Name = "ColumnHeader9";
		ColumnHeader9.Text = "Name";
		ColumnHeader9.Width.Relative = 15;
		ColumnHeader10.Name = "ColumnHeader10";
		ColumnHeader10.Text = "Value";
		ColumnHeader10.Width.Relative = 75;
		Node8.Name = "Node8";
		Node8.Nodes.AddRange(new Node[1] { Node51 });
		Node8.NodesColumns.Add(ColumnHeader11);
		Node8.NodesColumns.Add(ColumnHeader12);
		Node8.NodesColumns.Add(ColumnHeader13);
		Node8.Text = "<h5><font color=\"#17365D\"><b>Functionality</b></font></h5>";
		Node51.Cells.Add(Cell40);
		Node51.Cells.Add(Cell41);
		Node51.Expanded = true;
		Node51.Name = "Node51";
		Node51.Text = "Temp";
		Node51.Visible = false;
		Cell40.Name = "Cell40";
		Cell40.StyleMouseOver = null;
		Cell41.Name = "Cell41";
		Cell41.StyleMouseOver = null;
		ColumnHeader11.Name = "ColumnHeader11";
		ColumnHeader11.Text = "ID";
		ColumnHeader11.Width.Relative = 10;
		ColumnHeader12.Name = "ColumnHeader12";
		ColumnHeader12.Text = "Name";
		ColumnHeader12.Width.Relative = 45;
		ColumnHeader13.Name = "ColumnHeader13";
		ColumnHeader13.Text = "Functionality";
		ColumnHeader13.Width.Relative = 35;
		Node7.Name = "Node7";
		Node7.Nodes.AddRange(new Node[1] { Node52 });
		Node7.NodesColumns.Add(ColumnHeader14);
		Node7.NodesColumns.Add(ColumnHeader15);
		Node7.NodesColumns.Add(ColumnHeader16);
		Node7.Text = "<h5><font color=\"#17365D\"><b>License Count</b></font></h5>";
		Node52.Cells.Add(Cell42);
		Node52.Cells.Add(Cell43);
		Node52.Expanded = true;
		Node52.Name = "Node52";
		Node52.Text = "Temp";
		Node52.Visible = false;
		Cell42.Name = "Cell42";
		Cell42.StyleMouseOver = null;
		Cell43.Name = "Cell43";
		Cell43.StyleMouseOver = null;
		ColumnHeader14.Name = "ColumnHeader14";
		ColumnHeader14.Text = "ID";
		ColumnHeader14.Width.Relative = 10;
		ColumnHeader15.Name = "ColumnHeader15";
		ColumnHeader15.Text = "Object";
		ColumnHeader15.Width.Relative = 40;
		ColumnHeader16.Name = "ColumnHeader16";
		ColumnHeader16.Text = "Licences";
		ColumnHeader16.Width.Relative = 40;
		Node44.Name = "Node44";
		Node44.Nodes.AddRange(new Node[2] { Node45, Node9 });
		Node44.NodesColumns.Add(ColumnHeader19);
		Node44.NodesColumns.Add(ColumnHeader20);
		Node44.Text = "<h5><font color=\"#17365D\"><b>Other Information</b></font></h5>";
		Node45.Cells.Add(Cell35);
		Node45.Name = "Node45";
		Node45.Text = "<b>Licence Info</b>";
		Cell35.Name = "Cell35";
		Cell35.StyleMouseOver = null;
		Node9.Cells.Add(Cell36);
		Node9.Name = "Node9";
		Node9.NodesColumns.Add(ColumnHeader18);
		Node9.Text = "<b>Support Info</b>";
		Cell36.Editable = false;
		Cell36.Name = "Cell36";
		Cell36.StyleMouseOver = null;
		ColumnHeader18.Name = "ColumnHeader18";
		ColumnHeader18.Text = "Value";
		ColumnHeader18.Width.Absolute = 150;
		ColumnHeader19.Name = "ColumnHeader19";
		ColumnHeader19.Text = "Name";
		ColumnHeader19.Width.Relative = 15;
		ColumnHeader20.Name = "ColumnHeader20";
		ColumnHeader20.Text = "Value";
		ColumnHeader20.Width.Relative = 75;
		Node6.Name = "Node6";
		Node6.Nodes.AddRange(new Node[1] { Node53 });
		Node6.NodesColumns.Add(ColumnHeader17);
		Node6.NodesColumns.Add(ColumnHeader21);
		Node6.Text = "<h5><font color=\"#17365D\"><b>Unknown Data</b></font></h5>";
		Node53.Cells.Add(Cell44);
		Node53.Expanded = true;
		Node53.Name = "Node53";
		Node53.Text = "Temp";
		Node53.Visible = false;
		Cell44.Name = "Cell44";
		Cell44.StyleMouseOver = null;
		ColumnHeader17.Name = "ColumnHeader17";
		ColumnHeader17.Text = "Tag";
		ColumnHeader17.Width.Relative = 30;
		ColumnHeader21.Name = "ColumnHeader21";
		ColumnHeader21.Text = "Value";
		ColumnHeader21.Width.Relative = 60;
		Node54.Name = "Node54";
		Node54.Text = "<h5><font color=\"#17365D\"><b>Lost Data</b></font></h5>";
		Keys.Cells.Add(TotalKeysDisplayed);
		Keys.CheckBoxVisible = true;
		Keys.Expanded = true;
		Keys.Name = "Keys";
		Keys.Nodes.AddRange(new Node[3] { Node58, Node59, Node57 });
		Keys.Text = "<font size=\"+8\"><font color=\"#F909B5\"><b>Keys</b></font></font>";
		TotalKeysDisplayed.Name = "TotalKeysDisplayed";
		TotalKeysDisplayed.StyleMouseOver = null;
		Node58.Cells.Add(TotalKeysDisplayed0);
		Node58.CheckBoxVisible = true;
		Node58.Name = "Node58";
		Node58.Text = "<font color=\"#4E5D30\"><b><font size=\"+6\">Valid Keys</font> </b>(Unexpired and Unblacklisted)</font>";
		Node58.Visible = false;
		TotalKeysDisplayed0.Name = "TotalKeysDisplayed0";
		TotalKeysDisplayed0.StyleMouseOver = null;
		Node59.Cells.Add(TotalKeysDisplayed1);
		Node59.CheckBoxVisible = true;
		Node59.Name = "Node59";
		Node59.Text = "<font color=\"#1919F1\"><b><font size=\"+6\">Unexpired Keys</font></b> (Unavailable Blacklist Status)</font>";
		Node59.Visible = false;
		TotalKeysDisplayed1.Name = "TotalKeysDisplayed1";
		TotalKeysDisplayed1.StyleMouseOver = null;
		Node57.Cells.Add(TotalKeysDisplayed2);
		Node57.CheckBoxVisible = true;
		Node57.Name = "Node57";
		Node57.Text = "<font color=\"#ED1C24\"><b><font size=\"+6\">Invalid Keys</font></b> (Expired and/or Blacklisted)</font><font color=\"#84A2C6\"></font>";
		Node57.Visible = false;
		TotalKeysDisplayed2.Name = "TotalKeysDisplayed2";
		TotalKeysDisplayed2.StyleMouseOver = null;
		NodeConnector1.LineColor = SystemColors.ControlText;
		ElementStyle1.CornerType = eCornerType.Rounded;
		ElementStyle1.Name = "ElementStyle1";
		ElementStyle1.TextColor = SystemColors.ControlText;
		Cell_ActualName.Name = "Cell_ActualName";
		Cell_ActualName.StyleMouseOver = null;
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		Node48.Cells.Add(Cell_ActualName);
		Node48.Expanded = true;
		Node48.Name = "Node48";
		Node48.Text = "<h4><font color=\"#C0504D\"><b>File Actual Name:</b></font></h4>";
		Node49.Expanded = true;
		Node49.Name = "Node49";
		Node49.Text = "<h4><font color=\"#C0504D\"><b>File Actual Name:</b></font></h4>";
		((ToolStrip)StatusStrip1).set_AutoSize(false);
		((ToolStrip)StatusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ts_StatusLabel1,
			(ToolStripItem)ts_StatusLabel2,
			(ToolStripItem)ts_ProgressBar1
		});
		StatusStrip statusStrip = StatusStrip1;
		location = new Point(0, 416);
		((Control)statusStrip).set_Location(location);
		((Control)StatusStrip1).set_Name("StatusStrip1");
		StatusStrip statusStrip2 = StatusStrip1;
		size = new Size(652, 32);
		((Control)statusStrip2).set_Size(size);
		StatusStrip1.set_SizingGrip(false);
		StatusStrip1.set_Stretch(false);
		((Control)StatusStrip1).set_TabIndex(10);
		((Control)StatusStrip1).set_Text("StatusStrip1");
		((ToolStripItem)ts_StatusLabel1).set_AutoSize(false);
		((ToolStripItem)ts_StatusLabel1).set_Name("ts_StatusLabel1");
		ToolStripStatusLabel obj = ts_StatusLabel1;
		size = new Size(280, 27);
		((ToolStripItem)obj).set_Size(size);
		((ToolStripItem)ts_StatusLabel2).set_AutoSize(false);
		((ToolStripItem)ts_StatusLabel2).set_Font(new Font("Tahoma", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ToolStripItem)ts_StatusLabel2).set_ImageScaling((ToolStripItemImageScaling)0);
		((ToolStripItem)ts_StatusLabel2).set_Name("ts_StatusLabel2");
		((ToolStripItem)ts_StatusLabel2).set_Overflow((ToolStripItemOverflow)0);
		ToolStripStatusLabel obj2 = ts_StatusLabel2;
		size = new Size(128, 27);
		((ToolStripItem)obj2).set_Size(size);
		((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: ");
		((ToolStripItem)ts_StatusLabel2).set_TextAlign((ContentAlignment)16);
		((ToolStripItem)ts_ProgressBar1).set_AutoSize(false);
		((ToolStripItem)ts_ProgressBar1).set_Name("ts_ProgressBar1");
		ToolStripProgressBar obj3 = ts_ProgressBar1;
		size = new Size(200, 26);
		((ToolStripControlHost)obj3).set_Size(size);
		((ToolStripItem)ts_ProgressBar1).set_Visible(false);
		((Control)Button4).set_Anchor((AnchorStyles)6);
		((Control)Button4).set_BackgroundImage((Image)(object)Resources.red_button);
		((Control)Button4).set_BackgroundImageLayout((ImageLayout)4);
		((Control)Button4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button button = Button4;
		location = new Point(614, 417);
		((Control)button).set_Location(location);
		((Control)Button4).set_Name("Button4");
		Button button2 = Button4;
		size = new Size(34, 30);
		((Control)button2).set_Size(size);
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((Control)Button4).set_Visible(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(652, 448);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)StatusStrip1);
		((Control)this).get_Controls().Add((Control)(object)AdvTree1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("form_KeyViewer");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("Key Viewer");
		((ISupportInitialize)AdvTree1).EndInit();
		((Control)AdvTree1).ResumeLayout(false);
		((Control)AdvTree1).PerformLayout();
		((Control)ContextMenuStrip1).ResumeLayout(false);
		((Control)StatusStrip1).ResumeLayout(false);
		((Control)StatusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void form_KeyViewer_Shown(object sender, EventArgs e)
	{
		if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
		{
			((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
		}
		else
		{
			((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
		}
		if (JustLoaded)
		{
			JustLoaded = false;
			if (BlacklistViewer.FileInfo.KeyList.Length <= 0)
			{
			}
			StartAll();
		}
	}

	private void StartAll(Array FileName = null)
	{
		try
		{
			if (FileName == null)
			{
				FileName = GetFileName();
			}
			ts_ProgressBar1.set_Value(0);
			((ToolStripItem)ts_StatusLabel1).set_Text("");
			if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
			{
				((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
			}
			else
			{
				((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
			}
			OpeningFilesNumber = 0;
			OpeningFilesKeysFound = 0;
			if (Conversions.ToBoolean(Operators.OrObject((object)(FileName == null), Operators.AndObject((object)(FileName.Length == 1), Operators.CompareObjectEqual(NewLateBinding.LateIndexGet((object)FileName, new object[1] { 0 }, (string[])null), (object)"", false)))))
			{
				return;
			}
			((ToolStripItem)ts_ProgressBar1).set_Visible(true);
			((Control)Button4).set_Visible(true);
			OpeningFilesTotal = FileName.Length;
			ts_ProgressBar1.set_Maximum(Conversions.ToInteger(OpeningFilesTotal));
			((Control)ContextMenuStrip1).set_Enabled(false);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = FileName.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string text = Conversions.ToString(enumerator.Current);
					if (!CancelOperation)
					{
						if (Operators.CompareString(text, "", false) != 0)
						{
							ReadFileandAssign(text);
						}
						continue;
					}
					CancelOperation = false;
					break;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			ReportKeyToDan = false;
			((ToolStripItem)ts_ProgressBar1).set_Visible(false);
			((Control)Button4).set_Visible(false);
			ts_ProgressBar1.set_Value(0);
			if (Conversions.ToBoolean(Operators.AndObject(Operators.NotObject(Operators.CompareObjectEqual(OpeningFilesNumber, (object)0, false)), (object)(Operators.CompareString(((ToolStripItem)ts_StatusLabel1).get_Text(), "Keys Already Posted.", false) != 0))))
			{
				((ToolStripItem)ts_StatusLabel1).set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(OpeningFilesNumber, (object)" Files Opened, "), (object)OpeningFilesKeysFound), (object)" Kaspersky Keys Found .")));
				if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
				{
					((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
				}
				else
				{
					((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
				}
			}
			((Control)ContextMenuStrip1).set_Enabled(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private Array GetFileName()
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).Refresh();
			((Control)this).Focus();
			Application.DoEvents();
			OpeningFilesNumber = 0;
			OpeningFilesTotal = 0;
			OpenFileDialog1.set_CheckFileExists(true);
			((FileDialog)OpenFileDialog1).set_CheckPathExists(true);
			((FileDialog)OpenFileDialog1).set_DefaultExt("Key");
			((FileDialog)OpenFileDialog1).set_Filter("Kasperskey Key (*.Key)|*.Key|All Files (*.*)|*.*");
			OpenFileDialog1.set_Multiselect(true);
			((FileDialog)OpenFileDialog1).set_Title("Load the Kasperskey Key");
			((FileDialog)OpenFileDialog1).set_FileName("");
			((FileDialog)OpenFileDialog1).set_InitialDirectory(Conversions.ToString(OpenDirectoryPath));
			((CommonDialog)OpenFileDialog1).ShowDialog();
			string[] fileNames = ((FileDialog)OpenFileDialog1).get_FileNames();
			if (fileNames.Length <= 0)
			{
				return null;
			}
			((Control)this).Refresh();
			((Control)this).Focus();
			Application.DoEvents();
			Array.Sort(fileNames);
			return fileNames;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Array result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void ReadFileandAssign(string FileName)
	{
		KeyViewer.FileName_Path = FileName;
		string text;
		string text2;
		Node node2;
		Node node3;
		Node node4;
		Node node5;
		TimeSpan timeSpan;
		bool flag;
		bool flag2;
		bool flag3;
		Node node6;
		checked
		{
			text = FileName.Substring(FileName.LastIndexOf("\\") + 1, FileName.Length - FileName.LastIndexOf("\\") - 1);
			text2 = (string)(OpenDirectoryPath = FileName.Substring(0, FileName.LastIndexOf("\\") + 1));
			Node node = AdvTree1.FindNodeByText(NotExpired + text + "</b></font></h3>");
			if (node == null)
			{
				node = AdvTree1.FindNodeByText(NotBlacklisted_NotExpired + text + "</b></font></h3>");
			}
			if (node == null)
			{
				node = AdvTree1.FindNodeByText(ExpiredOrBlacklisted + text + "</b></font></h3>");
			}
			if (node != null && Operators.CompareString(node.Nodes[0].Cells[1].Text, text2, false) == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(OpeningFilesNumber, (object)0, false))
				{
					((ToolStripItem)ts_StatusLabel1).set_Text("Keys Already Posted.");
				}
				if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
				{
					((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
				}
				else
				{
					((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
				}
				return;
			}
			KeyWorker = new BackgroundWorker();
			KeyWorker.WorkerReportsProgress = true;
			KeyWorker.WorkerSupportsCancellation = true;
			KeyWorker.RunWorkerAsync();
			OpeningFilesNumber = Operators.AddObject(OpeningFilesNumber, (object)1);
			while (KeyWorker.IsBusy)
			{
				Application.DoEvents();
			}
			if (!KeyReadingResult)
			{
				return;
			}
			OpeningFilesKeysFound++;
			if (AdvTree1.Nodes.Count == 1)
			{
				AdvTree1.Nodes.Add(AdvTree1.Nodes[0].Nodes[1].DeepCopy());
			}
			node2 = AdvTree1.Nodes[1];
			node2.Visible = true;
			node3 = node2.Nodes[0];
			node4 = node2.Nodes[1];
			node5 = node2.Nodes[2];
			timeSpan = KeyViewer.Licence.ExpiryDate - DateAndTime.get_Now();
			flag = false;
			flag2 = false;
			flag3 = false;
			if (timeSpan.Days < 0)
			{
				flag = true;
			}
			int num = Array.IndexOf(BlacklistViewer.FileInfo.KeyList, KeyViewer.Summary.KeyNumber);
			if (BlacklistViewer.FileInfo.KeyList.Length > 0)
			{
				flag3 = true;
			}
			if (num >= 0)
			{
				flag2 = true;
			}
			node6 = null;
		}
		if (!flag && !flag2 && flag3)
		{
			node3.Visible = true;
			int index = node3.Nodes.Add(AdvTree1.Nodes[0].Nodes[0].DeepCopy());
			node6 = node3.Nodes[index];
			node6.Visible = true;
			node6.Text = NotBlacklisted_NotExpired + text + "</b></font></h3>";
			node6.Nodes[3].Cells[1].Text = "<h4><font color=\"#22B14C\"><b>No, The Key can be used for the next \"" + timeSpan.Days + "\" days.</b></font></h4>";
			node6.Nodes[2].Cells[1].Text = "<h4><font color=\"#22B14C\"><b>Not Blacklisted</b></font></h4>";
			node3.Cells[1].Text = "( " + Conversions.ToString(node3.Nodes.Count) + " )";
		}
		else if (!flag && !flag3)
		{
			node4.Visible = true;
			int index2 = node4.Nodes.Add(AdvTree1.Nodes[0].Nodes[0].DeepCopy());
			node6 = node4.Nodes[index2];
			node6.Visible = true;
			node6.Text = NotExpired + text + "</b></font></h3>";
			node6.Nodes[3].Cells[1].Text = "<h4><font color=\"#22B14C\"><b>No, The Key can be used for the next \"" + timeSpan.Days + "\" days.</b></font></h4>";
			node4.Cells[1].Text = "( " + Conversions.ToString(node4.Nodes.Count) + " )";
		}
		else
		{
			node5.Visible = true;
			int index3 = node5.Nodes.Add(AdvTree1.Nodes[0].Nodes[0].DeepCopy());
			node6 = node5.Nodes[index3];
			node6.Visible = true;
			node6.Text = ExpiredOrBlacklisted + text + "</b></font></h3>";
			if (flag2)
			{
				node6.Nodes[2].Cells[1].Text = "<h4><font color=\"#ED1C24\"><b>Blacklisted</b></font></h4>";
			}
			else
			{
				node6.Nodes[2].Cells[1].Text = "<h4><font color=\"#22B14C\"><b>Not Blacklisted</b></font></h4>";
			}
			if (flag)
			{
				node6.Nodes[3].Cells[1].Text = "<h4><font color=\"#ED1C24\"><b>Yes, \"" + timeSpan.Days.ToString().Replace("-", "") + "\" days ago.</b></font></h4>";
			}
			else
			{
				node6.Nodes[3].Cells[1].Text = "<h4><font color=\"#22B14C\"><b>No, The Key can be used for the next \"" + timeSpan.Days + "\" days.</b></font></h4>";
			}
			node5.Cells[1].Text = "( " + Conversions.ToString(node5.Nodes.Count) + " )";
		}
		node6.Nodes[0].Cells[1].Text = text2;
		node6.Nodes[1].Cells[1].Text = KeyViewer.Summary.ActualFileName;
		SubFileData(node6);
		if (Conversions.ToBoolean(Operators.NotObject(ReportKeyToDan)))
		{
			node6.Cells[1].Text = "";
		}
		ReportKeyToDan = false;
		node6.CollapseAll();
		node6.Parent.Nodes.Sort();
		node2.Cells[1].Text = "( " + Conversions.ToString(checked(node3.Nodes.Count + node4.Nodes.Count + node5.Nodes.Count)) + " )";
	}

	private bool SubFileData(Node TheFileNode)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TheFileNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Text.Contains("General"))
					{
						GeneralData(node);
					}
					else if (node.Text.Contains("Licence"))
					{
						LicenceData(node);
					}
					else if (node.Text.Contains("Product"))
					{
						ProductData(node);
					}
					else if (node.Text.Contains("Partner"))
					{
						PartnerData(node);
					}
					else if (node.Text.Contains("Customer"))
					{
						CustomerData(node);
					}
					else if (node.Text.Contains("Functionality"))
					{
						FunctionalityData(node);
					}
					else if (node.Text.Contains("License Count"))
					{
						LicenseCountData(node);
					}
					else if (node.Text.Contains("Other Information"))
					{
						OtherInformationData(node);
					}
					else if (node.Text.Contains("Unknown Data"))
					{
						UnknownDataData(node);
					}
					else if (node.Text.Contains("Lost Data"))
					{
						LostDataData(node);
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool GeneralData(Node TheFileNode)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TheFileNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Text.Contains("Type"))
					{
						node.Cells[1].Text = KeyViewer.General.Type;
					}
					else if (node.Text.Contains("Description"))
					{
						node.Cells[1].Text = KeyViewer.General.Description;
					}
					else if (node.Text.Contains("Version"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.General.Version);
					}
					else if (node.Text.Contains("Serial Number"))
					{
						node.Cells[1].Text = KeyViewer.General.SerialNumber;
					}
					else if (node.Text.Contains("Date Created"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.General.DateCreate);
					}
					else if (node.Text.Contains("Request GUID"))
					{
						node.Cells[1].Text = KeyViewer.General.RequestGUID;
					}
					else if (node.Text.Contains("Parent GUID"))
					{
						node.Cells[1].Text = KeyViewer.General.ParentGUID;
					}
					else if (node.Text.Contains("Parent Number"))
					{
						node.Cells[1].Text = KeyViewer.General.ParentNumber;
					}
					else if (node.Text.Contains("Category"))
					{
						node.Cells[1].Text = KeyViewer.General.Category;
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool LicenceData(Node TheFileNode)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TheFileNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Text.Contains("Licence Type"))
					{
						node.Cells[1].Text = KeyViewer.Licence.LicenceType;
					}
					else if (node.Text.Contains("Key is Trial"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.Licence.KeyIsTrial);
					}
					else if (node.Text.Contains("Key is Personal"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.Licence.KeyIsPersonal);
					}
					else if (node.Text.Contains("Life Span"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.Licence.LifeSpan);
					}
					else if (node.Text.Contains("Expiry Date"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.Licence.ExpiryDate);
					}
					else if (node.Text.Contains("Licence Count"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.Licence.LicenceCount);
					}
					else if (node.Text.Contains("Key Has Support"))
					{
						node.Cells[1].Text = Conversions.ToString(KeyViewer.Licence.KeyHasSupport);
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool ProductData(Node TheFileNode)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TheFileNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Text.Contains("Application ID"))
					{
						node.Cells[1].Text = KeyViewer.Product.ApplicationID;
					}
					else if (node.Text.Contains("Application Name"))
					{
						node.Cells[1].Text = KeyViewer.Product.ApplicationName;
					}
					else if (node.Text.Contains("Product ID"))
					{
						node.Cells[1].Text = KeyViewer.Product.ProductID;
					}
					else if (node.Text.Contains("Product Version"))
					{
						node.Cells[1].Text = KeyViewer.Product.ProductVersion;
					}
					else if (node.Text.Contains("Market Sector"))
					{
						node.Cells[1].Text = KeyViewer.Product.MarketSector;
					}
					else if (node.Text.Contains("Sales Channel"))
					{
						node.Cells[1].Text = KeyViewer.Product.SalesChannel;
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool PartnerData(Node TheFileNode)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TheFileNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Text.Contains("Partner ID"))
					{
						node.Cells[1].Text = KeyViewer.Partner.PartnerID;
					}
					else if (node.Text.Contains("Partner Name"))
					{
						node.Cells[1].Text = KeyViewer.Partner.PartnerName;
					}
					else if (node.Text.Contains("Reseller"))
					{
						node.Cells[1].Text = KeyViewer.Partner.Reseller;
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool CustomerData(Node TheFileNode)
	{
		try
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = TheFileNode.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Text.Contains("Company"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Company;
					}
					else if (node.Text.Contains("Name"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Name;
					}
					else if (node.Text.Contains("Country"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Country;
					}
					else if (node.Text.Contains("City"))
					{
						node.Cells[1].Text = KeyViewer.Customer.City;
					}
					else if (node.Text.Contains("Address"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Address;
					}
					else if (node.Text.Contains("Phone"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Phone;
					}
					else if (node.Text.Contains("Fax"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Fax;
					}
					else if (node.Text.Contains("eMail"))
					{
						node.Cells[1].Text = KeyViewer.Customer.eMail;
					}
					else if (node.Text.Contains("Site"))
					{
						node.Cells[1].Text = KeyViewer.Customer.Site;
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool FunctionalityData(Node TheFileNode)
	{
		try
		{
			if (KeyViewer.MoreData.ID_Name_Functionality.Length > 0)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = KeyViewer.MoreData.ID_Name_Functionality.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						int index = TheFileNode.Nodes.Add(TheFileNode.Nodes[0].DeepCopy());
						string[] array = Strings.Split(Conversions.ToString(objectValue), "\t", -1, (CompareMethod)0);
						TheFileNode.Nodes[index].Visible = true;
						TheFileNode.Nodes[index].Cells[0].Text = array[0];
						TheFileNode.Nodes[index].Cells[1].Text = array[1];
						TheFileNode.Nodes[index].Cells[2].Text = array[2];
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool LicenseCountData(Node TheFileNode)
	{
		try
		{
			if (KeyViewer.MoreData.ID_Object_Licence.Length > 0)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = KeyViewer.MoreData.ID_Object_Licence.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						int index = TheFileNode.Nodes.Add(TheFileNode.Nodes[0].DeepCopy());
						string[] array = Strings.Split(Conversions.ToString(objectValue), "\t", -1, (CompareMethod)0);
						TheFileNode.Nodes[index].Visible = true;
						TheFileNode.Nodes[index].Cells[0].Text = array[0];
						TheFileNode.Nodes[index].Cells[1].Text = array[1];
						TheFileNode.Nodes[index].Cells[2].Text = array[2];
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool OtherInformationData(Node TheFileNode)
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = TheFileNode.Nodes.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Node node = (Node)enumerator.Current;
						if (node.Text.Contains("Licence Info"))
						{
							node.Cells[1].Text = KeyViewer.Licence.LicenceInfo;
						}
						else
						{
							if (!node.Text.Contains("Support Info"))
							{
								continue;
							}
							string text = KeyViewer.MoreData.SupportInfo;
							int num = text.ToLower().IndexOf("LOCAL OFFICE: Kaspe".ToLower()) + "LOCAL OFFICE: Kaspe".Length;
							string text2 = "";
							if (num != 18)
							{
								int num2 = text.ToLower().IndexOf("rsky Lab".ToLower(), num);
								if (num2 != -1)
								{
									text2 = text.Substring(num, num2 - num);
									text = text.Remove(num, num2 - num);
								}
							}
							byte[] bytes = Encoding.ASCII.GetBytes(text2.ToCharArray());
							_ = (string[])ByteToHex(bytes);
							int num3 = 0;
							do
							{
								if (!unchecked(num3 == 9 || num3 == 10 || num3 == 13 || (num3 >= 32 && num3 <= 126)))
								{
									text = text.Replace(Conversions.ToString(Strings.Chr(num3)), "");
								}
								num3++;
							}
							while (num3 <= 255);
							text = text.Replace("\r\n", "<br/>");
							node.Cells[1].Text = text;
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
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)KeyViewer.FileName_Path, (MsgBoxStyle)0, (object)null);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private Array ByteToHex(byte[] TheByte)
	{
		checked
		{
			string[] array = new string[TheByte.Length - 1 + 1];
			int num = TheByte.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = Conversion.Hex(TheByte[num2]);
				if (array[num2].Length == 1)
				{
					array[num2] = "0" + array[num2];
				}
				num2++;
			}
			return array;
		}
	}

	private bool UnknownDataData(Node TheFileNode)
	{
		try
		{
			if (KeyViewer.MoreData.UnKnownData.Length > 0)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = KeyViewer.MoreData.UnKnownData.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						int index = TheFileNode.Nodes.Add(TheFileNode.Nodes[0].DeepCopy());
						string[] array = Strings.Split(Conversions.ToString(objectValue), ":", -1, (CompareMethod)0);
						TheFileNode.Nodes[index].Visible = true;
						TheFileNode.Nodes[index].Cells[0].Text = array[0].ToUpper();
						TheFileNode.Nodes[index].Cells[1].Text = array[1].ToUpper();
						string[] array2 = new string[29]
						{
							"0b 00 4b 4c 31 31 32 35 48 43 41 48 54", "0b 00 4b 4c 31 31 32 35 48 44 41 46 53", "0b 00 4b 4c 31 31 32 35 4e 43 41 48 4e", "0b 00 4b 4c 31 31 32 35 4e 58 41 46 53", "0b 00 4b 4c 31 31 32 35 52 44 41 46 52", "0b 00 4b 4c 31 31 32 36 48 44 41 46 53", "0b 00 4b 4c 31 31 32 36 48 44 41 48 53", "0b 00 4b 4c 31 31 32 37 48 43 41 46 53", "0b 00 4b 4c 31 31 32 37 48 43 41 48 54", "0b 00 4b 4c 31 31 32 37 48 44 41 46 53",
							"0b 00 4b 4c 31 31 32 37 48 44 41 48 53", "0b 00 4b 4c 31 31 32 39 52 42 41 46 53", "0b 00 4b 4c 31 38 32 35 48 44 41 46 53", "0b 00 4b 4c 31 38 32 35 4e 42 43 46 53", "0b 00 4b 4c 31 38 32 35 55 43 43 46 53", "0b 00 4b 4c 31 38 32 35 48 42 41 46 53", "0b 00 4b 4c 31 38 32 36 48 44 41 46 53", "0b 00 4b 4c 31 38 32 37 48 43 41 46 53", "0b 00 4b 4c 31 38 32 37 48 44 41 46 53", "0b 00 4b 4c 31 38 32 37 48 44 41 48 53",
							"0b 00 4b 4c 31 38 32 39 4e 43 41 51 54", "0b 00 4b 4c 36 30 32 38 50 45 41 48 53", "0b 00 4b 4c 31 38 32 35 52 44 45 46 53", "0b 00 4b 4c 31 31 32 31 48 43 41 46 53", "0b 00 4b 4c 31 38 32 39 55 43 41 4a 4e", "0b 00 4b 4c 31 31 32 35 48 43 41 46 4e", "0b 00 4b 4c 31 38 32 31 42 43 41 46 53", "0b 00 4b 4c 31 38 32 35 4e 42 41 46 53", "0b 00 4b 4c 31 31 32 31 48 44 41 48 53"
						};
						string[] array3 = new string[13]
						{
							"00 00", "04 00 30 32 34 31", "04 00 30 32 34 36", "04 00 30 32 36 31", "04 00 30 32 36 36", "04 00 30 32 33 39", "07 00 30 32 36 37 28 31 29", "07 00 30 32 36 37 28 32 29", "08 00 30 32 34 37 2d 31 2d 33", "08 00 30 32 34 37 2d 32 2d 32",
							"08 00 30 32 34 39 28 32 29 32", "0b 00 44 56 44 32 30 30 35 32 30 30 38", "0b 00 31 36 30 35 32 30 30 38 42 4f 58"
						};
						if (!((Operators.CompareString(array[0].Trim().ToLower(), "1a 00 01 09", false) == 0) & (Operators.CompareString(array[1].Trim(), "00 00 00 00", false) == 0)) && !((Operators.CompareString(array[0].Trim().ToLower(), "1d 00 01 09", false) == 0) & ((Operators.CompareString(array[1].Trim(), "01 00 00 00", false) == 0) | (Operators.CompareString(array[1].Trim(), "07 00 00 00", false) == 0))) && !((Operators.CompareString(array[0].Trim().ToLower(), "2b 00 01 09", false) == 0) & ((Operators.CompareString(array[1].Trim(), "00 00 00 00", false) == 0) | (Operators.CompareString(array[1].Trim(), "01 00 00 00", false) == 0))) && !((Operators.CompareString(array[0].Trim().ToLower(), "01 00 00 09 03 01 00 08 01", false) == 0) & (Operators.CompareString(array[1].Trim(), "", false) == 0)) && !((Operators.CompareString(array[0].Trim().ToLower(), "01 00 00 09 07 01 00 08 01", false) == 0) & (Operators.CompareString(array[1].Trim(), "", false) == 0)) && !((Operators.CompareString(array[0].Trim().ToLower(), "25 00 01 28", false) == 0) & (Array.IndexOf(array2, array[1].Trim().ToLower()) >= 0)) && !((Operators.CompareString(array[0].Trim().ToLower(), "24 00 01 28", false) == 0) & (Array.IndexOf(array3, array[1].Trim().ToLower()) >= 0)) && !(array[0].Trim().ToLower().EndsWith("01 28") & (Operators.CompareString(array[1].Trim(), "00 00", false) == 0)))
						{
							ReportKeyToDan = true;
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool LostDataData(Node TheFileNode)
	{
		try
		{
			if (KeyViewer.MoreData.LostData.Length > 0)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = KeyViewer.MoreData.LostData.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						Node node = new Node();
						node.Text = Conversions.ToString(objectValue);
						TheFileNode.Nodes.Add(node);
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ToLower", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"01 00 00 00 fc 03 00 00 03", false))))
						{
							ReportKeyToDan = true;
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
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool CreateSubNodesStructure(Node TheFileNode)
	{
		try
		{
			string[] array = new string[7] { "General", "Licence", "Product\"Partner", "Customer", "Functionality", "License Count", "Other Information" };
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i = checked(i + 1))
			{
				TheFileNode.DeepCopy();
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void KeyWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		KeyReadingResult = KeyViewer.Functions.AnalyzeKey();
	}

	private void KeyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((ToolStripItem)ts_StatusLabel1).set_Text(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Processing ", OpeningFilesNumber), (object)" of "), OpeningFilesTotal)));
		if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
		{
			((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
		}
		else
		{
			((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
		}
		ts_ProgressBar1.set_Value(Conversions.ToInteger(OpeningFilesNumber));
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		CancelOperation = true;
	}

	private void AdvTree1_AfterCheck(object sender, AdvTreeCellEventArgs e)
	{
		if (e.Action == eTreeAction.Code)
		{
			return;
		}
		string[] array = Strings.Split(e.Cell.Parent.FullPath, ";", -1, (CompareMethod)0);
		Node parent = e.Cell.Parent;
		if (array.Length == 3)
		{
			bool flag;
			if (flag = AllNodesChecked(parent.Parent, CheckStatus: true))
			{
				parent.Parent.CheckState = (CheckState)1;
			}
			else if (!flag & !AllNodesChecked(parent.Parent, CheckStatus: false))
			{
				parent.Parent.CheckState = (CheckState)2;
			}
			else if (!flag)
			{
				parent.Parent.CheckState = (CheckState)0;
			}
			DealWith2nsLevelNodes(parent.Parent);
			return;
		}
		if (array.Length == 2)
		{
			DealWith2nsLevelNodes(parent);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = parent.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if (node.Checked != parent.Checked)
					{
						node.Checked = parent.Checked;
					}
				}
				return;
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		if (array.Length != 1)
		{
			return;
		}
		bool @checked = parent.Checked;
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = parent.Nodes.GetEnumerator();
			IEnumerator enumerator3 = default(IEnumerator);
			while (enumerator2.MoveNext())
			{
				Node node2 = (Node)enumerator2.Current;
				if (!((node2.Checked != @checked) & node2.Visible))
				{
					continue;
				}
				node2.Checked = @checked;
				try
				{
					enumerator3 = node2.Nodes.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						Node node3 = (Node)enumerator3.Current;
						if ((node3.Checked != @checked) & node3.Visible)
						{
							node3.Checked = @checked;
						}
					}
				}
				finally
				{
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
	}

	private bool AllNodesChecked(Node theNodeParent, bool CheckStatus)
	{
		try
		{
			bool result = true;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = theNodeParent.Nodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Node node = (Node)enumerator.Current;
					if ((node.Checked != CheckStatus) & node.Visible)
					{
						result = false;
						break;
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
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result2 = false;
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	private void DealWith2nsLevelNodes(Node thenode)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		bool flag;
		if (flag = AllNodesChecked(thenode.Parent, CheckStatus: true))
		{
			thenode.Parent.CheckState = (CheckState)1;
		}
		else if (!flag & !AllNodesChecked(thenode.Parent, CheckStatus: false))
		{
			thenode.Parent.CheckState = (CheckState)2;
		}
		else if (!flag)
		{
			thenode.Parent.CheckState = (CheckState)0;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = thenode.Parent.Nodes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Node node = (Node)enumerator.Current;
				if ((int)node.CheckState == 2)
				{
					node.Parent.CheckState = (CheckState)2;
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

	private void Button4_Click(object sender, EventArgs e)
	{
		CancelOperation = true;
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		StartAll();
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		AdvTree1.Nodes[1].Remove();
		((ToolStripItem)ts_StatusLabel1).set_Text("");
		if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
		{
			((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
		}
		else
		{
			((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
		}
	}

	private void RemoveCheckedKeysToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Invalid comparison between Unknown and I4
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Invalid comparison between Unknown and I4
		Node node = AdvTree1.Nodes[1];
		if ((int)node.CheckState == 2)
		{
			int num = 0;
			checked
			{
				do
				{
					if (!((unchecked((int)node.Nodes[num].CheckState) == 2) & node.Nodes[num].Visible))
					{
						if ((unchecked((int)node.Nodes[num].CheckState) == 1) & node.Nodes[num].Visible)
						{
							for (int i = node.Nodes[num].Nodes.Count - 1; i >= 0; i += -1)
							{
								node.Nodes[num].Nodes[i].Remove();
							}
							node.Nodes[num].CheckState = (CheckState)0;
							node.Nodes[num].Cells[1].Text = "( " + Conversions.ToString(node.Nodes[num].Nodes.Count) + " )";
							node.Nodes[num].Visible = false;
						}
					}
					else
					{
						for (int j = node.Nodes[num].Nodes.Count - 1; j >= 0; j += -1)
						{
							if (node.Nodes[num].Nodes[j].Checked)
							{
								node.Nodes[num].Nodes[j].Remove();
							}
						}
						node.Nodes[num].Cells[1].Text = "( " + Conversions.ToString(node.Nodes[num].Nodes.Count) + " )";
					}
					num++;
				}
				while (num <= 2);
				node.Cells[1].Text = "( " + Conversions.ToString(node.Nodes[0].Nodes.Count + node.Nodes[1].Nodes.Count + node.Nodes[2].Nodes.Count) + " )";
			}
		}
		else if ((int)node.CheckState == 1)
		{
			node.Remove();
		}
	}

	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Invalid comparison between Unknown and I4
		FolderBrowserDialog1.set_Description("Save Key Location.");
		if (!Directory.Exists(SaveDirectoryPath))
		{
			SaveDirectoryPath = Conversions.ToString(5);
		}
		FolderBrowserDialog1.set_SelectedPath(SaveDirectoryPath);
		FolderBrowserDialog1.set_ShowNewFolderButton(true);
		if ((int)((CommonDialog)FolderBrowserDialog1).ShowDialog() != 2)
		{
			SaveDirectoryPath = FolderBrowserDialog1.get_SelectedPath();
			SaveCheckedKeysAndRename(SaveDirectoryPath + "\\");
		}
	}

	private bool SaveCheckedKeysAndRename(string ToLocation)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Invalid comparison between Unknown and I4
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Invalid comparison between Unknown and I4
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Invalid comparison between Unknown and I4
		try
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			Node node = AdvTree1.Nodes[1];
			int num3 = 0;
			int num4 = 0;
			IEnumerator enumerator = default(IEnumerator);
			IEnumerator enumerator2 = default(IEnumerator);
			while (true)
			{
				text = ToLocation + "Valid Keys";
				while (true)
				{
					checked
					{
						if (!((unchecked((int)node.Nodes[num3].CheckState) == 2) & node.Nodes[num3].Visible))
						{
							if ((unchecked((int)node.Nodes[num3].CheckState) == 1) & node.Nodes[num3].Visible)
							{
								if (!Directory.Exists(text))
								{
									Directory.CreateDirectory(text);
								}
								try
								{
									enumerator = node.Nodes[num3].Nodes.GetEnumerator();
									while (enumerator.MoveNext())
									{
										Node node2 = (Node)enumerator.Current;
										string text2 = node2.Text.Remove(0, node2.Text.IndexOf("\"><b>") + 5);
										text2 = text2.Substring(0, text2.IndexOf("</b><"));
										text2 = node2.Nodes[0].Cells[1].Text + text2;
										string text3 = text + "\\" + node2.Nodes[1].Cells[1].Text;
										bool flag = File.Exists(text3);
										string text4 = text3;
										if (flag)
										{
											BlacklistViewer.Download.Overwrite = ToolStripMenuItem4.get_Checked();
											text4 = BlacklistViewer.Functions.FileNameDetermination(text3);
										}
										File.Copy(text2, text4);
										if (Operators.CompareString(text3, text4, false) != 0)
										{
											num++;
										}
										else if (unchecked(Operators.CompareString(text3, text4, false) == 0 && !flag))
										{
											num++;
										}
										num2++;
										((ToolStripItem)ts_StatusLabel1).set_Text("Copying " + Conversions.ToString(num) + " keys of " + Conversions.ToString(num2) + " Checked Keys.");
									}
								}
								finally
								{
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
								if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
								{
									((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
								}
								else
								{
									((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
								}
							}
						}
						else
						{
							if (!Directory.Exists(text))
							{
								Directory.CreateDirectory(text);
							}
							try
							{
								enumerator2 = node.Nodes[num3].Nodes.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									Node node3 = (Node)enumerator2.Current;
									if (node3.Checked)
									{
										string text5 = node3.Text.Remove(0, node3.Text.IndexOf("\"><b>") + 5);
										text5 = text5.Substring(0, text5.IndexOf("</b><"));
										text5 = node3.Nodes[0].Cells[1].Text + text5;
										string text6 = text + "\\" + node3.Nodes[1].Cells[1].Text;
										bool flag2 = File.Exists(text6);
										string text7 = text6;
										if (flag2)
										{
											BlacklistViewer.Download.Overwrite = ToolStripMenuItem4.get_Checked();
											text7 = BlacklistViewer.Functions.FileNameDetermination(text6);
										}
										File.Copy(text5, text7);
										if (Operators.CompareString(text6, text7, false) != 0)
										{
											num++;
										}
										else if (unchecked(Operators.CompareString(text6, text7, false) == 0 && !flag2))
										{
											num++;
										}
										num2++;
										((ToolStripItem)ts_StatusLabel1).set_Text("Copying " + Conversions.ToString(num) + " keys of " + Conversions.ToString(num2) + " Checked Keys.");
									}
								}
							}
							finally
							{
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
							{
								((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
							}
							else
							{
								((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
							}
						}
						num3++;
						int num5 = num3;
						num4 = 2;
						if (num5 <= 2)
						{
							switch (num3)
							{
							case 1:
								text = ToLocation + "Unexpired Keys";
								continue;
							case 2:
								text = ToLocation + "Invalid Keys";
								continue;
							default:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					if ((num == 0) & ((int)node.CheckState != 0))
					{
						((ToolStripItem)ts_StatusLabel1).set_Text("Selected keys already exist in the target folder.");
						if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
						{
							((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
						}
						else
						{
							((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
						}
					}
					else if ((int)node.CheckState == 0)
					{
						((ToolStripItem)ts_StatusLabel1).set_Text("No Key Selected.");
						if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
						{
							((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
						}
						else
						{
							((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
						}
					}
					else
					{
						((ToolStripItem)ts_StatusLabel1).set_Text(Conversions.ToString(num) + " of " + Conversions.ToString(num2) + " Checked Keys Copied.");
						if (DateTime.Compare(BlacklistViewer.FileInfo.UpdateDate, DateTime.MinValue) == 0)
						{
							((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist Not Checked.");
						}
						else
						{
							((ToolStripItem)ts_StatusLabel2).set_Text("Blacklist: " + Strings.Format((object)BlacklistViewer.FileInfo.UpdateDate, "yyyy-MM-dd"));
						}
					}
					return true;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void AdvTree1_AfterNodeInsert(object sender, TreeNodeCollectionEventArgs e)
	{
		if (AdvTree1.Nodes.Count == 1)
		{
			((Control)Label1).set_Visible(true);
		}
		else
		{
			((Control)Label1).set_Visible(false);
		}
	}

	private void AdvTree1_AfterNodeRemove(object sender, TreeNodeCollectionEventArgs e)
	{
		if (AdvTree1.Nodes.Count == 1)
		{
			((Control)Label1).set_Visible(true);
		}
		else
		{
			((Control)Label1).set_Visible(false);
		}
	}
}
