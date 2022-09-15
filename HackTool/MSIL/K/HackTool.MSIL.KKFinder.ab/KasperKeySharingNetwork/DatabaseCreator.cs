using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using KasperKeySharingNetwork.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class DatabaseCreator : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("dgv_TheWebserverList")]
	private DataGridView _dgv_TheWebserverList;

	[AccessedThroughProperty("Webserver_txtbx")]
	private TextBox _Webserver_txtbx;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("AddWebserver_btn")]
	private Button _AddWebserver_btn;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("File_txtbx")]
	private TextBox _File_txtbx;

	[AccessedThroughProperty("Key_txtbx")]
	private TextBox _Key_txtbx;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Add_Key_btn")]
	private Button _Add_Key_btn;

	[AccessedThroughProperty("dgv_TheKeyList")]
	private DataGridView _dgv_TheKeyList;

	[AccessedThroughProperty("Create_btn")]
	private Button _Create_btn;

	[AccessedThroughProperty("Password_txtbx")]
	private TextBox _Password_txtbx;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Import_btn")]
	private Button _Import_btn;

	[AccessedThroughProperty("SelectDeselectAll_Webserver_chk")]
	private CheckBox _SelectDeselectAll_Webserver_chk;

	[AccessedThroughProperty("SelectDeselectAll_Key_chk")]
	private CheckBox _SelectDeselectAll_Key_chk;

	[AccessedThroughProperty("AcceptBtn")]
	private Button _AcceptBtn;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("OpenFileDialog1")]
	private OpenFileDialog _OpenFileDialog1;

	[AccessedThroughProperty("cms_Webservers")]
	private ContextMenuStrip _cms_Webservers;

	[AccessedThroughProperty("cms_Keys")]
	private ContextMenuStrip _cms_Keys;

	[AccessedThroughProperty("SelectHighlightedToolStripMenuItem")]
	private ToolStripMenuItem _SelectHighlightedToolStripMenuItem;

	[AccessedThroughProperty("DeselectHighlightedToolStripMenuItem")]
	private ToolStripMenuItem _DeselectHighlightedToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator1")]
	private ToolStripSeparator _ToolStripSeparator1;

	[AccessedThroughProperty("RemoveSelectedToolStripMenuItem")]
	private ToolStripMenuItem _RemoveSelectedToolStripMenuItem;

	[AccessedThroughProperty("SelectHighlightedToolStripMenuItem1")]
	private ToolStripMenuItem _SelectHighlightedToolStripMenuItem1;

	[AccessedThroughProperty("DeselectHighlightedToolStripMenuItem1")]
	private ToolStripMenuItem _DeselectHighlightedToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripSeparator2")]
	private ToolStripSeparator _ToolStripSeparator2;

	[AccessedThroughProperty("RemoveSelectedToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveSelectedToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripSeparator3")]
	private ToolStripSeparator _ToolStripSeparator3;

	[AccessedThroughProperty("LinkSelectedKeysToolStripMenuItem")]
	private ToolStripMenuItem _LinkSelectedKeysToolStripMenuItem;

	[AccessedThroughProperty("ToolStripComboBox1")]
	private ToolStripComboBox _ToolStripComboBox1;

	[AccessedThroughProperty("DeLinkSelectedKeysToolStripMenuItem")]
	private ToolStripMenuItem _DeLinkSelectedKeysToolStripMenuItem;

	[AccessedThroughProperty("ToolStripComboBox2")]
	private ToolStripComboBox _ToolStripComboBox2;

	[AccessedThroughProperty("SelectAllToolStripMenuItem")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem;

	[AccessedThroughProperty("DeselectAllToolStripMenuItem")]
	private ToolStripMenuItem _DeselectAllToolStripMenuItem;

	[AccessedThroughProperty("ToolStripSeparator5")]
	private ToolStripSeparator _ToolStripSeparator5;

	[AccessedThroughProperty("SelectAllToolStripMenuItem1")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem1;

	[AccessedThroughProperty("DeselectAllToolStripMenuItem1")]
	private ToolStripMenuItem _DeselectAllToolStripMenuItem1;

	[AccessedThroughProperty("ToolStripSeparator4")]
	private ToolStripSeparator _ToolStripSeparator4;

	[AccessedThroughProperty("ToolStripSeparator6")]
	private ToolStripSeparator _ToolStripSeparator6;

	[AccessedThroughProperty("ImportKeysToTextFileToolStripMenuItem")]
	private ToolStripMenuItem _ImportKeysToTextFileToolStripMenuItem;

	[AccessedThroughProperty("ExportKeysToTextFileToolStripMenuItem")]
	private ToolStripMenuItem _ExportKeysToTextFileToolStripMenuItem;

	[AccessedThroughProperty("RemoveAllToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveAllToolStripMenuItem1;

	[AccessedThroughProperty("RemoveAllToolStripMenuItem")]
	private ToolStripMenuItem _RemoveAllToolStripMenuItem;

	private DataTable TheWebserverTable;

	private DataTable TheKeyTable;

	private bool SelectionInProcess;

	private string dAkEY;

	private string dAIv;

	internal virtual DataGridView dgv_TheWebserverList
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgv_TheWebserverList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(TheDGV_CellContentClick);
			EventHandler eventHandler = TheDGV_Sorted;
			EventHandler eventHandler2 = TheDGV_SelectionChanged;
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(TheDGV_CellEndEdit);
			if (_dgv_TheWebserverList != null)
			{
				_dgv_TheWebserverList.remove_CellContentClick(val);
				_dgv_TheWebserverList.remove_Sorted(eventHandler);
				_dgv_TheWebserverList.remove_SelectionChanged(eventHandler2);
				_dgv_TheWebserverList.remove_CellEndEdit(val2);
			}
			_dgv_TheWebserverList = value;
			if (_dgv_TheWebserverList != null)
			{
				_dgv_TheWebserverList.add_CellContentClick(val);
				_dgv_TheWebserverList.add_Sorted(eventHandler);
				_dgv_TheWebserverList.add_SelectionChanged(eventHandler2);
				_dgv_TheWebserverList.add_CellEndEdit(val2);
			}
		}
	}

	internal virtual TextBox Webserver_txtbx
	{
		[DebuggerNonUserCode]
		get
		{
			return _Webserver_txtbx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Webserver_txtbx = value;
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

	internal virtual Button AddWebserver_btn
	{
		[DebuggerNonUserCode]
		get
		{
			return _AddWebserver_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AddButtons_Click;
			if (_AddWebserver_btn != null)
			{
				((Control)_AddWebserver_btn).remove_Click(eventHandler);
			}
			_AddWebserver_btn = value;
			if (_AddWebserver_btn != null)
			{
				((Control)_AddWebserver_btn).add_Click(eventHandler);
			}
		}
	}

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

	internal virtual TextBox File_txtbx
	{
		[DebuggerNonUserCode]
		get
		{
			return _File_txtbx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_File_txtbx = value;
		}
	}

	internal virtual TextBox Key_txtbx
	{
		[DebuggerNonUserCode]
		get
		{
			return _Key_txtbx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Key_txtbx = value;
		}
	}

	internal virtual Label Label3
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

	internal virtual Button Add_Key_btn
	{
		[DebuggerNonUserCode]
		get
		{
			return _Add_Key_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AddButtons_Click;
			if (_Add_Key_btn != null)
			{
				((Control)_Add_Key_btn).remove_Click(eventHandler);
			}
			_Add_Key_btn = value;
			if (_Add_Key_btn != null)
			{
				((Control)_Add_Key_btn).add_Click(eventHandler);
			}
		}
	}

	internal virtual DataGridView dgv_TheKeyList
	{
		[DebuggerNonUserCode]
		get
		{
			return _dgv_TheKeyList;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(TheDGV_CellContentClick);
			EventHandler eventHandler = TheDGV_Sorted;
			EventHandler eventHandler2 = TheDGV_SelectionChanged;
			DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(TheDGV_CellEndEdit);
			if (_dgv_TheKeyList != null)
			{
				_dgv_TheKeyList.remove_CellContentClick(val);
				_dgv_TheKeyList.remove_Sorted(eventHandler);
				_dgv_TheKeyList.remove_SelectionChanged(eventHandler2);
				_dgv_TheKeyList.remove_CellEndEdit(val2);
			}
			_dgv_TheKeyList = value;
			if (_dgv_TheKeyList != null)
			{
				_dgv_TheKeyList.add_CellContentClick(val);
				_dgv_TheKeyList.add_Sorted(eventHandler);
				_dgv_TheKeyList.add_SelectionChanged(eventHandler2);
				_dgv_TheKeyList.add_CellEndEdit(val2);
			}
		}
	}

	internal virtual Button Create_btn
	{
		[DebuggerNonUserCode]
		get
		{
			return _Create_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Create_btn_Click;
			if (_Create_btn != null)
			{
				((Control)_Create_btn).remove_Click(eventHandler);
			}
			_Create_btn = value;
			if (_Create_btn != null)
			{
				((Control)_Create_btn).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox Password_txtbx
	{
		[DebuggerNonUserCode]
		get
		{
			return _Password_txtbx;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Password_txtbx = value;
		}
	}

	internal virtual Label Label4
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

	internal virtual Button Import_btn
	{
		[DebuggerNonUserCode]
		get
		{
			return _Import_btn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Import_btn_Click;
			if (_Import_btn != null)
			{
				((Control)_Import_btn).remove_Click(eventHandler);
			}
			_Import_btn = value;
			if (_Import_btn != null)
			{
				((Control)_Import_btn).add_Click(eventHandler);
			}
		}
	}

	internal virtual CheckBox SelectDeselectAll_Webserver_chk
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectDeselectAll_Webserver_chk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselectAll_CheckedChanged;
			if (_SelectDeselectAll_Webserver_chk != null)
			{
				_SelectDeselectAll_Webserver_chk.remove_CheckedChanged(eventHandler);
			}
			_SelectDeselectAll_Webserver_chk = value;
			if (_SelectDeselectAll_Webserver_chk != null)
			{
				_SelectDeselectAll_Webserver_chk.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual CheckBox SelectDeselectAll_Key_chk
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectDeselectAll_Key_chk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselectAll_CheckedChanged;
			if (_SelectDeselectAll_Key_chk != null)
			{
				_SelectDeselectAll_Key_chk.remove_CheckedChanged(eventHandler);
			}
			_SelectDeselectAll_Key_chk = value;
			if (_SelectDeselectAll_Key_chk != null)
			{
				_SelectDeselectAll_Key_chk.add_CheckedChanged(eventHandler);
			}
		}
	}

	internal virtual Button AcceptBtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _AcceptBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = AcceptBtn_Click;
			if (_AcceptBtn != null)
			{
				((Control)_AcceptBtn).remove_Click(eventHandler);
			}
			_AcceptBtn = value;
			if (_AcceptBtn != null)
			{
				((Control)_AcceptBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual SaveFileDialog SaveFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFileDialog1 = value;
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

	internal virtual ContextMenuStrip cms_Webservers
	{
		[DebuggerNonUserCode]
		get
		{
			return _cms_Webservers;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cms_Opened;
			if (_cms_Webservers != null)
			{
				((ToolStripDropDown)_cms_Webservers).remove_Opened(eventHandler);
			}
			_cms_Webservers = value;
			if (_cms_Webservers != null)
			{
				((ToolStripDropDown)_cms_Webservers).add_Opened(eventHandler);
			}
		}
	}

	internal virtual ContextMenuStrip cms_Keys
	{
		[DebuggerNonUserCode]
		get
		{
			return _cms_Keys;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cms_Opened;
			if (_cms_Keys != null)
			{
				((ToolStripDropDown)_cms_Keys).remove_Opened(eventHandler);
			}
			_cms_Keys = value;
			if (_cms_Keys != null)
			{
				((ToolStripDropDown)_cms_Keys).add_Opened(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SelectHighlightedToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectHighlightedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectHighlightedToolStripMenuItem_Click;
			if (_SelectHighlightedToolStripMenuItem != null)
			{
				((ToolStripItem)_SelectHighlightedToolStripMenuItem).remove_Click(eventHandler);
			}
			_SelectHighlightedToolStripMenuItem = value;
			if (_SelectHighlightedToolStripMenuItem != null)
			{
				((ToolStripItem)_SelectHighlightedToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeselectHighlightedToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeselectHighlightedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectHighlightedToolStripMenuItem_Click;
			if (_DeselectHighlightedToolStripMenuItem != null)
			{
				((ToolStripItem)_DeselectHighlightedToolStripMenuItem).remove_Click(eventHandler);
			}
			_DeselectHighlightedToolStripMenuItem = value;
			if (_DeselectHighlightedToolStripMenuItem != null)
			{
				((ToolStripItem)_DeselectHighlightedToolStripMenuItem).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem RemoveSelectedToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveSelectedToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveSelectedToolStripMenuItem_Click;
			if (_RemoveSelectedToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveSelectedToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveSelectedToolStripMenuItem = value;
			if (_RemoveSelectedToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveSelectedToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SelectHighlightedToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectHighlightedToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectHighlightedToolStripMenuItem_Click;
			if (_SelectHighlightedToolStripMenuItem1 != null)
			{
				((ToolStripItem)_SelectHighlightedToolStripMenuItem1).remove_Click(eventHandler);
			}
			_SelectHighlightedToolStripMenuItem1 = value;
			if (_SelectHighlightedToolStripMenuItem1 != null)
			{
				((ToolStripItem)_SelectHighlightedToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeselectHighlightedToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeselectHighlightedToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectHighlightedToolStripMenuItem_Click;
			if (_DeselectHighlightedToolStripMenuItem1 != null)
			{
				((ToolStripItem)_DeselectHighlightedToolStripMenuItem1).remove_Click(eventHandler);
			}
			_DeselectHighlightedToolStripMenuItem1 = value;
			if (_DeselectHighlightedToolStripMenuItem1 != null)
			{
				((ToolStripItem)_DeselectHighlightedToolStripMenuItem1).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem RemoveSelectedToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveSelectedToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveSelectedToolStripMenuItem1_Click;
			if (_RemoveSelectedToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoveSelectedToolStripMenuItem1).remove_Click(eventHandler);
			}
			_RemoveSelectedToolStripMenuItem1 = value;
			if (_RemoveSelectedToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoveSelectedToolStripMenuItem1).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem LinkSelectedKeysToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkSelectedKeysToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LinkSelectedKeysToolStripMenuItem_MouseEnter;
			if (_LinkSelectedKeysToolStripMenuItem != null)
			{
				((ToolStripItem)_LinkSelectedKeysToolStripMenuItem).remove_MouseEnter(eventHandler);
			}
			_LinkSelectedKeysToolStripMenuItem = value;
			if (_LinkSelectedKeysToolStripMenuItem != null)
			{
				((ToolStripItem)_LinkSelectedKeysToolStripMenuItem).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual ToolStripComboBox ToolStripComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripComboBox_TextChanged;
			if (_ToolStripComboBox1 != null)
			{
				((ToolStripItem)_ToolStripComboBox1).remove_TextChanged(eventHandler);
			}
			_ToolStripComboBox1 = value;
			if (_ToolStripComboBox1 != null)
			{
				((ToolStripItem)_ToolStripComboBox1).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeLinkSelectedKeysToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeLinkSelectedKeysToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = LinkSelectedKeysToolStripMenuItem_MouseEnter;
			if (_DeLinkSelectedKeysToolStripMenuItem != null)
			{
				((ToolStripItem)_DeLinkSelectedKeysToolStripMenuItem).remove_MouseEnter(eventHandler);
			}
			_DeLinkSelectedKeysToolStripMenuItem = value;
			if (_DeLinkSelectedKeysToolStripMenuItem != null)
			{
				((ToolStripItem)_DeLinkSelectedKeysToolStripMenuItem).add_MouseEnter(eventHandler);
			}
		}
	}

	internal virtual ToolStripComboBox ToolStripComboBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ToolStripComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ToolStripComboBox_TextChanged;
			if (_ToolStripComboBox2 != null)
			{
				((ToolStripItem)_ToolStripComboBox2).remove_TextChanged(eventHandler);
			}
			_ToolStripComboBox2 = value;
			if (_ToolStripComboBox2 != null)
			{
				((ToolStripItem)_ToolStripComboBox2).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselect_Click;
			if (_SelectAllToolStripMenuItem != null)
			{
				((ToolStripItem)_SelectAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_SelectAllToolStripMenuItem = value;
			if (_SelectAllToolStripMenuItem != null)
			{
				((ToolStripItem)_SelectAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeselectAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeselectAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselect_Click;
			if (_DeselectAllToolStripMenuItem != null)
			{
				((ToolStripItem)_DeselectAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_DeselectAllToolStripMenuItem = value;
			if (_DeselectAllToolStripMenuItem != null)
			{
				((ToolStripItem)_DeselectAllToolStripMenuItem).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem SelectAllToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SelectAllToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselect_Click;
			if (_SelectAllToolStripMenuItem1 != null)
			{
				((ToolStripItem)_SelectAllToolStripMenuItem1).remove_Click(eventHandler);
			}
			_SelectAllToolStripMenuItem1 = value;
			if (_SelectAllToolStripMenuItem1 != null)
			{
				((ToolStripItem)_SelectAllToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem DeselectAllToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _DeselectAllToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = SelectDeselect_Click;
			if (_DeselectAllToolStripMenuItem1 != null)
			{
				((ToolStripItem)_DeselectAllToolStripMenuItem1).remove_Click(eventHandler);
			}
			_DeselectAllToolStripMenuItem1 = value;
			if (_DeselectAllToolStripMenuItem1 != null)
			{
				((ToolStripItem)_DeselectAllToolStripMenuItem1).add_Click(eventHandler);
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

	internal virtual ToolStripMenuItem ImportKeysToTextFileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImportKeysToTextFileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ImportKeysToTextFileToolStripMenuItem_Click;
			if (_ImportKeysToTextFileToolStripMenuItem != null)
			{
				((ToolStripItem)_ImportKeysToTextFileToolStripMenuItem).remove_Click(eventHandler);
			}
			_ImportKeysToTextFileToolStripMenuItem = value;
			if (_ImportKeysToTextFileToolStripMenuItem != null)
			{
				((ToolStripItem)_ImportKeysToTextFileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ExportKeysToTextFileToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _ExportKeysToTextFileToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ExportKeysToTextFileToolStripMenuItem_Click;
			if (_ExportKeysToTextFileToolStripMenuItem != null)
			{
				((ToolStripItem)_ExportKeysToTextFileToolStripMenuItem).remove_Click(eventHandler);
			}
			_ExportKeysToTextFileToolStripMenuItem = value;
			if (_ExportKeysToTextFileToolStripMenuItem != null)
			{
				((ToolStripItem)_ExportKeysToTextFileToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveAllToolStripMenuItem1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveAllToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveAllToolStripMenuItem1_Click;
			if (_RemoveAllToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoveAllToolStripMenuItem1).remove_Click(eventHandler);
			}
			_RemoveAllToolStripMenuItem1 = value;
			if (_RemoveAllToolStripMenuItem1 != null)
			{
				((ToolStripItem)_RemoveAllToolStripMenuItem1).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem RemoveAllToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return _RemoveAllToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RemoveAllToolStripMenuItem_Click;
			if (_RemoveAllToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveAllToolStripMenuItem).remove_Click(eventHandler);
			}
			_RemoveAllToolStripMenuItem = value;
			if (_RemoveAllToolStripMenuItem != null)
			{
				((ToolStripItem)_RemoveAllToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	public DatabaseCreator()
	{
		((Form)this).add_Load((EventHandler)DatabaseCreator_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		SelectionInProcess = false;
		dAkEY = "#@&%HySlou;:J*.,gRns{(+|";
		dAIv = "%h@9!}:.";
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
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
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
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
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
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
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6a: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7b: Expected O, but got Unknown
		//IL_150c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1516: Expected O, but got Unknown
		components = new Container();
		DataGridViewCellStyle val = new DataGridViewCellStyle();
		DataGridViewCellStyle val2 = new DataGridViewCellStyle();
		DataGridViewCellStyle val3 = new DataGridViewCellStyle();
		DataGridViewCellStyle val4 = new DataGridViewCellStyle();
		DataGridViewCellStyle val5 = new DataGridViewCellStyle();
		DataGridViewCellStyle val6 = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DatabaseCreator));
		dgv_TheWebserverList = new DataGridView();
		cms_Webservers = new ContextMenuStrip(components);
		SelectAllToolStripMenuItem = new ToolStripMenuItem();
		DeselectAllToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator5 = new ToolStripSeparator();
		SelectHighlightedToolStripMenuItem1 = new ToolStripMenuItem();
		DeselectHighlightedToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripSeparator2 = new ToolStripSeparator();
		RemoveAllToolStripMenuItem1 = new ToolStripMenuItem();
		RemoveSelectedToolStripMenuItem1 = new ToolStripMenuItem();
		Webserver_txtbx = new TextBox();
		Label1 = new Label();
		AddWebserver_btn = new Button();
		Label2 = new Label();
		File_txtbx = new TextBox();
		Key_txtbx = new TextBox();
		Label3 = new Label();
		Add_Key_btn = new Button();
		dgv_TheKeyList = new DataGridView();
		cms_Keys = new ContextMenuStrip(components);
		SelectAllToolStripMenuItem1 = new ToolStripMenuItem();
		DeselectAllToolStripMenuItem1 = new ToolStripMenuItem();
		ToolStripSeparator4 = new ToolStripSeparator();
		SelectHighlightedToolStripMenuItem = new ToolStripMenuItem();
		DeselectHighlightedToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator1 = new ToolStripSeparator();
		RemoveAllToolStripMenuItem = new ToolStripMenuItem();
		RemoveSelectedToolStripMenuItem = new ToolStripMenuItem();
		ToolStripSeparator3 = new ToolStripSeparator();
		LinkSelectedKeysToolStripMenuItem = new ToolStripMenuItem();
		ToolStripComboBox1 = new ToolStripComboBox();
		DeLinkSelectedKeysToolStripMenuItem = new ToolStripMenuItem();
		ToolStripComboBox2 = new ToolStripComboBox();
		ToolStripSeparator6 = new ToolStripSeparator();
		ImportKeysToTextFileToolStripMenuItem = new ToolStripMenuItem();
		ExportKeysToTextFileToolStripMenuItem = new ToolStripMenuItem();
		Create_btn = new Button();
		Password_txtbx = new TextBox();
		Label4 = new Label();
		Import_btn = new Button();
		SelectDeselectAll_Webserver_chk = new CheckBox();
		SelectDeselectAll_Key_chk = new CheckBox();
		AcceptBtn = new Button();
		SaveFileDialog1 = new SaveFileDialog();
		OpenFileDialog1 = new OpenFileDialog();
		((ISupportInitialize)dgv_TheWebserverList).BeginInit();
		((Control)cms_Webservers).SuspendLayout();
		((ISupportInitialize)dgv_TheKeyList).BeginInit();
		((Control)cms_Keys).SuspendLayout();
		((Control)this).SuspendLayout();
		dgv_TheWebserverList.set_AllowUserToAddRows(false);
		dgv_TheWebserverList.set_AllowUserToDeleteRows(false);
		dgv_TheWebserverList.set_AllowUserToResizeRows(false);
		((Control)dgv_TheWebserverList).set_Anchor((AnchorStyles)13);
		dgv_TheWebserverList.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dgv_TheWebserverList.set_BackgroundColor(Color.White);
		dgv_TheWebserverList.set_ClipboardCopyMode((DataGridViewClipboardCopyMode)0);
		val.set_Alignment((DataGridViewContentAlignment)16);
		val.set_BackColor(SystemColors.Control);
		val.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val.set_ForeColor(SystemColors.WindowText);
		val.set_SelectionBackColor(SystemColors.Highlight);
		val.set_SelectionForeColor(SystemColors.HighlightText);
		val.set_WrapMode((DataGridViewTriState)1);
		dgv_TheWebserverList.set_ColumnHeadersDefaultCellStyle(val);
		dgv_TheWebserverList.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgv_TheWebserverList).set_ContextMenuStrip(cms_Webservers);
		val2.set_Alignment((DataGridViewContentAlignment)16);
		val2.set_BackColor(SystemColors.Window);
		val2.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val2.set_ForeColor(SystemColors.ControlText);
		val2.set_SelectionBackColor(SystemColors.Highlight);
		val2.set_SelectionForeColor(SystemColors.HighlightText);
		val2.set_WrapMode((DataGridViewTriState)2);
		dgv_TheWebserverList.set_DefaultCellStyle(val2);
		DataGridView obj = dgv_TheWebserverList;
		Point location = new Point(12, 53);
		((Control)obj).set_Location(location);
		((Control)dgv_TheWebserverList).set_Name("dgv_TheWebserverList");
		val3.set_Alignment((DataGridViewContentAlignment)16);
		val3.set_BackColor(SystemColors.Control);
		val3.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val3.set_ForeColor(SystemColors.WindowText);
		val3.set_SelectionBackColor(SystemColors.Highlight);
		val3.set_SelectionForeColor(SystemColors.HighlightText);
		val3.set_WrapMode((DataGridViewTriState)1);
		dgv_TheWebserverList.set_RowHeadersDefaultCellStyle(val3);
		dgv_TheWebserverList.set_RowHeadersVisible(false);
		DataGridView obj2 = dgv_TheWebserverList;
		Size size = new Size(617, 143);
		((Control)obj2).set_Size(size);
		((Control)dgv_TheWebserverList).set_TabIndex(2);
		((ToolStrip)cms_Webservers).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)SelectAllToolStripMenuItem,
			(ToolStripItem)DeselectAllToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator5,
			(ToolStripItem)SelectHighlightedToolStripMenuItem1,
			(ToolStripItem)DeselectHighlightedToolStripMenuItem1,
			(ToolStripItem)ToolStripSeparator2,
			(ToolStripItem)RemoveAllToolStripMenuItem1,
			(ToolStripItem)RemoveSelectedToolStripMenuItem1
		});
		((Control)cms_Webservers).set_Name("cms_Webservers");
		ContextMenuStrip obj3 = cms_Webservers;
		size = new Size(176, 170);
		((Control)obj3).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Name("SelectAllToolStripMenuItem");
		ToolStripMenuItem selectAllToolStripMenuItem = SelectAllToolStripMenuItem;
		size = new Size(175, 22);
		((ToolStripItem)selectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem).set_Text("Select All.");
		((ToolStripItem)DeselectAllToolStripMenuItem).set_Name("DeselectAllToolStripMenuItem");
		ToolStripMenuItem deselectAllToolStripMenuItem = DeselectAllToolStripMenuItem;
		size = new Size(175, 22);
		((ToolStripItem)deselectAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeselectAllToolStripMenuItem).set_Text("Deselect All.");
		((ToolStripItem)ToolStripSeparator5).set_Name("ToolStripSeparator5");
		ToolStripSeparator toolStripSeparator = ToolStripSeparator5;
		size = new Size(172, 6);
		((ToolStripItem)toolStripSeparator).set_Size(size);
		((ToolStripItem)SelectHighlightedToolStripMenuItem1).set_Name("SelectHighlightedToolStripMenuItem1");
		ToolStripMenuItem selectHighlightedToolStripMenuItem = SelectHighlightedToolStripMenuItem1;
		size = new Size(175, 22);
		((ToolStripItem)selectHighlightedToolStripMenuItem).set_Size(size);
		((ToolStripItem)SelectHighlightedToolStripMenuItem1).set_Text("Select Highlighted.");
		((ToolStripItem)DeselectHighlightedToolStripMenuItem1).set_Name("DeselectHighlightedToolStripMenuItem1");
		ToolStripMenuItem deselectHighlightedToolStripMenuItem = DeselectHighlightedToolStripMenuItem1;
		size = new Size(175, 22);
		((ToolStripItem)deselectHighlightedToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeselectHighlightedToolStripMenuItem1).set_Text("Deselect Highlighted.");
		((ToolStripItem)ToolStripSeparator2).set_Name("ToolStripSeparator2");
		ToolStripSeparator toolStripSeparator2 = ToolStripSeparator2;
		size = new Size(172, 6);
		((ToolStripItem)toolStripSeparator2).set_Size(size);
		((ToolStripItem)RemoveAllToolStripMenuItem1).set_Name("RemoveAllToolStripMenuItem1");
		ToolStripMenuItem removeAllToolStripMenuItem = RemoveAllToolStripMenuItem1;
		size = new Size(175, 22);
		((ToolStripItem)removeAllToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveAllToolStripMenuItem1).set_Text("Remove All.");
		((ToolStripItem)RemoveSelectedToolStripMenuItem1).set_Name("RemoveSelectedToolStripMenuItem1");
		ToolStripMenuItem removeSelectedToolStripMenuItem = RemoveSelectedToolStripMenuItem1;
		size = new Size(175, 22);
		((ToolStripItem)removeSelectedToolStripMenuItem).set_Size(size);
		((ToolStripItem)RemoveSelectedToolStripMenuItem1).set_Text("Remove Selected.");
		((Control)Webserver_txtbx).set_Anchor((AnchorStyles)13);
		TextBox webserver_txtbx = Webserver_txtbx;
		location = new Point(12, 26);
		((Control)webserver_txtbx).set_Location(location);
		((Control)Webserver_txtbx).set_Name("Webserver_txtbx");
		TextBox webserver_txtbx2 = Webserver_txtbx;
		size = new Size(556, 20);
		((Control)webserver_txtbx2).set_Size(size);
		((Control)Webserver_txtbx).set_TabIndex(3);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(12, 10);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(65, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("WebServer:");
		((Control)AddWebserver_btn).set_Anchor((AnchorStyles)9);
		Button addWebserver_btn = AddWebserver_btn;
		location = new Point(574, 24);
		((Control)addWebserver_btn).set_Location(location);
		((Control)AddWebserver_btn).set_Name("AddWebserver_btn");
		Button addWebserver_btn2 = AddWebserver_btn;
		size = new Size(55, 23);
		((Control)addWebserver_btn2).set_Size(size);
		((Control)AddWebserver_btn).set_TabIndex(5);
		((ButtonBase)AddWebserver_btn).set_Text("Add");
		((ButtonBase)AddWebserver_btn).set_UseVisualStyleBackColor(true);
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(12, 205);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(103, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("File Path and Name:");
		((Control)File_txtbx).set_Anchor((AnchorStyles)13);
		TextBox file_txtbx = File_txtbx;
		location = new Point(121, 202);
		((Control)file_txtbx).set_Location(location);
		((Control)File_txtbx).set_Name("File_txtbx");
		TextBox file_txtbx2 = File_txtbx;
		size = new Size(447, 20);
		((Control)file_txtbx2).set_Size(size);
		((Control)File_txtbx).set_TabIndex(9);
		((Control)Key_txtbx).set_Anchor((AnchorStyles)13);
		TextBox key_txtbx = Key_txtbx;
		location = new Point(121, 228);
		((Control)key_txtbx).set_Location(location);
		((Control)Key_txtbx).set_Name("Key_txtbx");
		TextBox key_txtbx2 = Key_txtbx;
		size = new Size(447, 20);
		((Control)key_txtbx2).set_Size(size);
		((Control)Key_txtbx).set_TabIndex(11);
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(56, 231);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(59, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(10);
		Label3.set_Text("Key Name:");
		((Control)Add_Key_btn).set_Anchor((AnchorStyles)9);
		Button add_Key_btn = Add_Key_btn;
		location = new Point(574, 202);
		((Control)add_Key_btn).set_Location(location);
		((Control)Add_Key_btn).set_Name("Add_Key_btn");
		Button add_Key_btn2 = Add_Key_btn;
		size = new Size(55, 46);
		((Control)add_Key_btn2).set_Size(size);
		((Control)Add_Key_btn).set_TabIndex(12);
		((ButtonBase)Add_Key_btn).set_Text("Add");
		((ButtonBase)Add_Key_btn).set_UseVisualStyleBackColor(true);
		dgv_TheKeyList.set_AllowUserToAddRows(false);
		dgv_TheKeyList.set_AllowUserToDeleteRows(false);
		dgv_TheKeyList.set_AllowUserToResizeRows(false);
		((Control)dgv_TheKeyList).set_Anchor((AnchorStyles)15);
		dgv_TheKeyList.set_BackgroundColor(Color.White);
		val4.set_Alignment((DataGridViewContentAlignment)16);
		val4.set_BackColor(SystemColors.Control);
		val4.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val4.set_ForeColor(SystemColors.WindowText);
		val4.set_SelectionBackColor(SystemColors.Highlight);
		val4.set_SelectionForeColor(SystemColors.HighlightText);
		val4.set_WrapMode((DataGridViewTriState)1);
		dgv_TheKeyList.set_ColumnHeadersDefaultCellStyle(val4);
		dgv_TheKeyList.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dgv_TheKeyList).set_ContextMenuStrip(cms_Keys);
		val5.set_Alignment((DataGridViewContentAlignment)16);
		val5.set_BackColor(SystemColors.Window);
		val5.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val5.set_ForeColor(SystemColors.ControlText);
		val5.set_SelectionBackColor(SystemColors.Highlight);
		val5.set_SelectionForeColor(SystemColors.HighlightText);
		val5.set_WrapMode((DataGridViewTriState)2);
		dgv_TheKeyList.set_DefaultCellStyle(val5);
		DataGridView obj4 = dgv_TheKeyList;
		location = new Point(12, 254);
		((Control)obj4).set_Location(location);
		((Control)dgv_TheKeyList).set_Name("dgv_TheKeyList");
		val6.set_Alignment((DataGridViewContentAlignment)16);
		val6.set_BackColor(SystemColors.Control);
		val6.set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		val6.set_ForeColor(SystemColors.WindowText);
		val6.set_SelectionBackColor(SystemColors.Highlight);
		val6.set_SelectionForeColor(SystemColors.HighlightText);
		val6.set_WrapMode((DataGridViewTriState)1);
		dgv_TheKeyList.set_RowHeadersDefaultCellStyle(val6);
		dgv_TheKeyList.set_RowHeadersVisible(false);
		DataGridView obj5 = dgv_TheKeyList;
		size = new Size(617, 150);
		((Control)obj5).set_Size(size);
		((Control)dgv_TheKeyList).set_TabIndex(13);
		((ToolStrip)cms_Keys).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[14]
		{
			(ToolStripItem)SelectAllToolStripMenuItem1,
			(ToolStripItem)DeselectAllToolStripMenuItem1,
			(ToolStripItem)ToolStripSeparator4,
			(ToolStripItem)SelectHighlightedToolStripMenuItem,
			(ToolStripItem)DeselectHighlightedToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator1,
			(ToolStripItem)RemoveAllToolStripMenuItem,
			(ToolStripItem)RemoveSelectedToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator3,
			(ToolStripItem)LinkSelectedKeysToolStripMenuItem,
			(ToolStripItem)DeLinkSelectedKeysToolStripMenuItem,
			(ToolStripItem)ToolStripSeparator6,
			(ToolStripItem)ImportKeysToTextFileToolStripMenuItem,
			(ToolStripItem)ExportKeysToTextFileToolStripMenuItem
		});
		((Control)cms_Keys).set_Name("cms_Keys");
		ContextMenuStrip obj6 = cms_Keys;
		size = new Size(208, 248);
		((Control)obj6).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem1).set_Name("SelectAllToolStripMenuItem1");
		ToolStripMenuItem selectAllToolStripMenuItem2 = SelectAllToolStripMenuItem1;
		size = new Size(207, 22);
		((ToolStripItem)selectAllToolStripMenuItem2).set_Size(size);
		((ToolStripItem)SelectAllToolStripMenuItem1).set_Text("Select All.");
		((ToolStripItem)DeselectAllToolStripMenuItem1).set_Name("DeselectAllToolStripMenuItem1");
		ToolStripMenuItem deselectAllToolStripMenuItem2 = DeselectAllToolStripMenuItem1;
		size = new Size(207, 22);
		((ToolStripItem)deselectAllToolStripMenuItem2).set_Size(size);
		((ToolStripItem)DeselectAllToolStripMenuItem1).set_Text("Deselect All.");
		((ToolStripItem)ToolStripSeparator4).set_Name("ToolStripSeparator4");
		ToolStripSeparator toolStripSeparator3 = ToolStripSeparator4;
		size = new Size(204, 6);
		((ToolStripItem)toolStripSeparator3).set_Size(size);
		((ToolStripItem)SelectHighlightedToolStripMenuItem).set_Name("SelectHighlightedToolStripMenuItem");
		ToolStripMenuItem selectHighlightedToolStripMenuItem2 = SelectHighlightedToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)selectHighlightedToolStripMenuItem2).set_Size(size);
		((ToolStripItem)SelectHighlightedToolStripMenuItem).set_Text("Select Highlighted.");
		((ToolStripItem)DeselectHighlightedToolStripMenuItem).set_Name("DeselectHighlightedToolStripMenuItem");
		ToolStripMenuItem deselectHighlightedToolStripMenuItem2 = DeselectHighlightedToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)deselectHighlightedToolStripMenuItem2).set_Size(size);
		((ToolStripItem)DeselectHighlightedToolStripMenuItem).set_Text("Deselect Highlighted.");
		((ToolStripItem)ToolStripSeparator1).set_Name("ToolStripSeparator1");
		ToolStripSeparator toolStripSeparator4 = ToolStripSeparator1;
		size = new Size(204, 6);
		((ToolStripItem)toolStripSeparator4).set_Size(size);
		((ToolStripItem)RemoveAllToolStripMenuItem).set_Name("RemoveAllToolStripMenuItem");
		ToolStripMenuItem removeAllToolStripMenuItem2 = RemoveAllToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)removeAllToolStripMenuItem2).set_Size(size);
		((ToolStripItem)RemoveAllToolStripMenuItem).set_Text("Remove All.");
		((ToolStripItem)RemoveSelectedToolStripMenuItem).set_Name("RemoveSelectedToolStripMenuItem");
		ToolStripMenuItem removeSelectedToolStripMenuItem2 = RemoveSelectedToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)removeSelectedToolStripMenuItem2).set_Size(size);
		((ToolStripItem)RemoveSelectedToolStripMenuItem).set_Text("Remove Selected.");
		((ToolStripItem)ToolStripSeparator3).set_Name("ToolStripSeparator3");
		ToolStripSeparator toolStripSeparator5 = ToolStripSeparator3;
		size = new Size(204, 6);
		((ToolStripItem)toolStripSeparator5).set_Size(size);
		((ToolStripDropDownItem)LinkSelectedKeysToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripComboBox1 });
		((ToolStripItem)LinkSelectedKeysToolStripMenuItem).set_Name("LinkSelectedKeysToolStripMenuItem");
		ToolStripMenuItem linkSelectedKeysToolStripMenuItem = LinkSelectedKeysToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)linkSelectedKeysToolStripMenuItem).set_Size(size);
		((ToolStripItem)LinkSelectedKeysToolStripMenuItem).set_Text("Link Selected Keys.");
		((ToolStripItem)ToolStripComboBox1).set_Name("ToolStripComboBox1");
		ToolStripComboBox toolStripComboBox = ToolStripComboBox1;
		size = new Size(121, 21);
		((ToolStripControlHost)toolStripComboBox).set_Size(size);
		((ToolStripControlHost)ToolStripComboBox1).set_Text("Select a Webserver.");
		((ToolStripDropDownItem)DeLinkSelectedKeysToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ToolStripComboBox2 });
		((ToolStripItem)DeLinkSelectedKeysToolStripMenuItem).set_Name("DeLinkSelectedKeysToolStripMenuItem");
		ToolStripMenuItem deLinkSelectedKeysToolStripMenuItem = DeLinkSelectedKeysToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)deLinkSelectedKeysToolStripMenuItem).set_Size(size);
		((ToolStripItem)DeLinkSelectedKeysToolStripMenuItem).set_Text("De-Link Selected Keys.");
		((ToolStripItem)ToolStripComboBox2).set_Name("ToolStripComboBox2");
		ToolStripComboBox toolStripComboBox2 = ToolStripComboBox2;
		size = new Size(121, 21);
		((ToolStripControlHost)toolStripComboBox2).set_Size(size);
		((ToolStripControlHost)ToolStripComboBox2).set_Text("Select a Webserver.");
		((ToolStripItem)ToolStripSeparator6).set_Name("ToolStripSeparator6");
		ToolStripSeparator toolStripSeparator6 = ToolStripSeparator6;
		size = new Size(204, 6);
		((ToolStripItem)toolStripSeparator6).set_Size(size);
		((ToolStripItem)ImportKeysToTextFileToolStripMenuItem).set_Name("ImportKeysToTextFileToolStripMenuItem");
		ToolStripMenuItem importKeysToTextFileToolStripMenuItem = ImportKeysToTextFileToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)importKeysToTextFileToolStripMenuItem).set_Size(size);
		((ToolStripItem)ImportKeysToTextFileToolStripMenuItem).set_Text("Import Keys From Text File.");
		((ToolStripItem)ExportKeysToTextFileToolStripMenuItem).set_Name("ExportKeysToTextFileToolStripMenuItem");
		ToolStripMenuItem exportKeysToTextFileToolStripMenuItem = ExportKeysToTextFileToolStripMenuItem;
		size = new Size(207, 22);
		((ToolStripItem)exportKeysToTextFileToolStripMenuItem).set_Size(size);
		((ToolStripItem)ExportKeysToTextFileToolStripMenuItem).set_Text("Export Keys to Text File.");
		((Control)Create_btn).set_Anchor((AnchorStyles)10);
		Button create_btn = Create_btn;
		location = new Point(345, 410);
		((Control)create_btn).set_Location(location);
		((Control)Create_btn).set_Name("Create_btn");
		Button create_btn2 = Create_btn;
		size = new Size(75, 23);
		((Control)create_btn2).set_Size(size);
		((Control)Create_btn).set_TabIndex(14);
		((ButtonBase)Create_btn).set_Text("Create");
		((ButtonBase)Create_btn).set_UseVisualStyleBackColor(true);
		((Control)Password_txtbx).set_Anchor((AnchorStyles)14);
		TextBox password_txtbx = Password_txtbx;
		location = new Point(121, 412);
		((Control)password_txtbx).set_Location(location);
		((Control)Password_txtbx).set_Name("Password_txtbx");
		TextBox password_txtbx2 = Password_txtbx;
		size = new Size(218, 20);
		((Control)password_txtbx2).set_Size(size);
		((Control)Password_txtbx).set_TabIndex(15);
		((Control)Label4).set_Anchor((AnchorStyles)6);
		Label4.set_AutoSize(true);
		Label label7 = Label4;
		location = new Point(59, 415);
		((Control)label7).set_Location(location);
		((Control)Label4).set_Name("Label4");
		Label label8 = Label4;
		size = new Size(57, 13);
		((Control)label8).set_Size(size);
		((Control)Label4).set_TabIndex(16);
		Label4.set_Text("Password:");
		((Control)Import_btn).set_Anchor((AnchorStyles)10);
		Button import_btn = Import_btn;
		location = new Point(426, 410);
		((Control)import_btn).set_Location(location);
		((Control)Import_btn).set_Name("Import_btn");
		Button import_btn2 = Import_btn;
		size = new Size(75, 23);
		((Control)import_btn2).set_Size(size);
		((Control)Import_btn).set_TabIndex(17);
		((ButtonBase)Import_btn).set_Text("Import");
		((ButtonBase)Import_btn).set_UseVisualStyleBackColor(true);
		((ButtonBase)SelectDeselectAll_Webserver_chk).set_AutoSize(true);
		CheckBox selectDeselectAll_Webserver_chk = SelectDeselectAll_Webserver_chk;
		location = new Point(17, 58);
		((Control)selectDeselectAll_Webserver_chk).set_Location(location);
		((Control)SelectDeselectAll_Webserver_chk).set_Name("SelectDeselectAll_Webserver_chk");
		CheckBox selectDeselectAll_Webserver_chk2 = SelectDeselectAll_Webserver_chk;
		size = new Size(15, 14);
		((Control)selectDeselectAll_Webserver_chk2).set_Size(size);
		((Control)SelectDeselectAll_Webserver_chk).set_TabIndex(18);
		((ButtonBase)SelectDeselectAll_Webserver_chk).set_UseVisualStyleBackColor(true);
		((ButtonBase)SelectDeselectAll_Key_chk).set_AutoSize(true);
		CheckBox selectDeselectAll_Key_chk = SelectDeselectAll_Key_chk;
		location = new Point(17, 259);
		((Control)selectDeselectAll_Key_chk).set_Location(location);
		((Control)SelectDeselectAll_Key_chk).set_Name("SelectDeselectAll_Key_chk");
		CheckBox selectDeselectAll_Key_chk2 = SelectDeselectAll_Key_chk;
		size = new Size(15, 14);
		((Control)selectDeselectAll_Key_chk2).set_Size(size);
		((Control)SelectDeselectAll_Key_chk).set_TabIndex(19);
		((ButtonBase)SelectDeselectAll_Key_chk).set_UseVisualStyleBackColor(true);
		((Control)AcceptBtn).set_Anchor((AnchorStyles)9);
		Button acceptBtn = AcceptBtn;
		location = new Point(512, 29);
		((Control)acceptBtn).set_Location(location);
		((Control)AcceptBtn).set_Name("AcceptBtn");
		Button acceptBtn2 = AcceptBtn;
		size = new Size(10, 14);
		((Control)acceptBtn2).set_Size(size);
		((Control)AcceptBtn).set_TabIndex(21);
		((ButtonBase)AcceptBtn).set_Text("AcceptBtn");
		((ButtonBase)AcceptBtn).set_UseVisualStyleBackColor(true);
		((FileDialog)OpenFileDialog1).set_FileName("OpenFileDialog1");
		((Form)this).set_AcceptButton((IButtonControl)(object)AcceptBtn);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(641, 446);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)SelectDeselectAll_Key_chk);
		((Control)this).get_Controls().Add((Control)(object)SelectDeselectAll_Webserver_chk);
		((Control)this).get_Controls().Add((Control)(object)Import_btn);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Password_txtbx);
		((Control)this).get_Controls().Add((Control)(object)Create_btn);
		((Control)this).get_Controls().Add((Control)(object)dgv_TheKeyList);
		((Control)this).get_Controls().Add((Control)(object)Add_Key_btn);
		((Control)this).get_Controls().Add((Control)(object)Key_txtbx);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)File_txtbx);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)AddWebserver_btn);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)Webserver_txtbx);
		((Control)this).get_Controls().Add((Control)(object)dgv_TheWebserverList);
		((Control)this).get_Controls().Add((Control)(object)AcceptBtn);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("DatabaseCreator");
		((Form)this).set_Text("KKL Creator");
		((ISupportInitialize)dgv_TheWebserverList).EndInit();
		((Control)cms_Webservers).ResumeLayout(false);
		((ISupportInitialize)dgv_TheKeyList).EndInit();
		((Control)cms_Keys).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void TheDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		checked
		{
			try
			{
				DataGridView val = (DataGridView)sender;
				if ((e.get_RowIndex() < 0) | (e.get_ColumnIndex() > 0))
				{
					return;
				}
				DataGridViewCheckBoxCell val2 = (DataGridViewCheckBoxCell)val.get_Item("Select", e.get_RowIndex());
				if (Conversions.ToBoolean(((DataGridViewCell)val2).get_EditedFormattedValue()))
				{
					int num = val.get_ColumnCount() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							val.get_Item(num2, e.get_RowIndex()).get_Style().set_BackColor(Color.LightPink);
							num2++;
							continue;
						}
						break;
					}
				}
				else
				{
					int num5 = val.get_ColumnCount() - 1;
					int num6 = 1;
					while (true)
					{
						int num7 = num6;
						int num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						val.get_Item(num6, e.get_RowIndex()).get_Style().set_BackColor(Color.White);
						num6++;
					}
				}
				val.get_Item(e.get_ColumnIndex() + 1, e.get_RowIndex()).set_Selected(true);
				if (((Control)val).get_Name().Contains("Key"))
				{
					TheKeyTable.Rows[e.get_RowIndex()][e.get_ColumnIndex()] = Conversions.ToBoolean(((DataGridViewCell)val2).get_EditedFormattedValue());
				}
				if (((Control)val).get_Name().Contains("Web"))
				{
					TheWebserverTable.Rows[e.get_RowIndex()][e.get_ColumnIndex()] = Conversions.ToBoolean(((DataGridViewCell)val2).get_EditedFormattedValue());
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TheDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		checked
		{
			try
			{
				DataGridView val = (DataGridView)sender;
				if (e.get_ColumnIndex() != 0)
				{
					return;
				}
				if (Conversions.ToBoolean(val.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
					.get_Item(0)
					.get_Value()))
				{
					int num = val.get_ColumnCount() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							val.get_Item(num2, e.get_RowIndex()).get_Style().set_BackColor(Color.LightPink);
							num2++;
							continue;
						}
						break;
					}
					return;
				}
				int num5 = val.get_ColumnCount() - 1;
				int num6 = 1;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						val.get_Item(num6, e.get_RowIndex()).get_Style().set_BackColor(Color.White);
						num6++;
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TheDGV_SelectionChanged(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		checked
		{
			try
			{
				if (SelectionInProcess)
				{
					return;
				}
				SelectionInProcess = true;
				DataGridView val = (DataGridView)sender;
				int num = -10;
				int num2 = val.get_ColumnCount() - 1;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ((BaseCollection)val.get_SelectedCells()).GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						if (Operators.CompareString(((Control)val).get_Name(), ((Control)dgv_TheKeyList).get_Name(), false) == 0)
						{
							num2 = 3;
						}
						if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null), (object)num, false))
						{
							continue;
						}
						if (val.get_Item(0, Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null))).get_Selected())
						{
							val.get_Item(0, Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null))).set_Selected(false);
						}
						int num3 = num2;
						int num4 = 1;
						while (true)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (!val.get_Item(num4, Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null))).get_Selected())
							{
								val.get_Item(num4, Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null))).set_Selected(true);
							}
							num4++;
						}
						num = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				SelectionInProcess = false;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				SelectionInProcess = false;
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SelectDeselectAll_CheckedChanged(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		checked
		{
			try
			{
				((Control)Label1).Select();
				CheckBox val = (CheckBox)sender;
				DataGridView val2 = dgv_TheWebserverList;
				DataTable dataTable = TheWebserverTable;
				if (((Control)val).get_Name().Contains("Webserver"))
				{
					val2 = dgv_TheWebserverList;
					dataTable = TheWebserverTable;
				}
				else if (((Control)val).get_Name().Contains("Key"))
				{
					val2 = dgv_TheKeyList;
					dataTable = TheKeyTable;
				}
				int num = dataTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					dataTable.Rows[num2][0] = val.get_Checked();
					Color backColor = ((!val.get_Checked()) ? Color.White : Color.LightPink);
					int num5 = val2.get_ColumnCount() - 1;
					int num6 = 1;
					while (true)
					{
						int num7 = num6;
						num4 = num5;
						if (num7 > num4)
						{
							break;
						}
						val2.get_Item(num6, num2).get_Style().set_BackColor(backColor);
						num6++;
					}
					num2++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void TheDGV_Sorted(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		checked
		{
			try
			{
				DataGridView val = (DataGridView)sender;
				int num = val.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (Operators.ConditionalCompareObjectEqual(val.get_Item("Select", num2).get_Value(), (object)true, false))
					{
						int num5 = val.get_ColumnCount() - 1;
						int num6 = 1;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							val.get_Item(num6, num2).get_Style().set_BackColor(Color.LightPink);
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
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AddingColumnsForTable()
	{
		try
		{
			TheWebserverTable = new DataTable("TheWebserverList");
			TheWebserverTable.Columns.Add("Select", typeof(bool));
			TheWebserverTable.Columns.Add("Number", Type.GetType("System.String"));
			TheWebserverTable.Columns.Add("Webserver", Type.GetType("System.String"));
			dgv_TheWebserverList.set_DataSource((object)TheWebserverTable);
			TheKeyTable = new DataTable("TheKeyList");
			TheKeyTable.Columns.Add("Select", typeof(bool));
			TheKeyTable.Columns.Add("FileName", Type.GetType("System.String"));
			TheKeyTable.Columns.Add("Date", Type.GetType("System.String"));
			TheKeyTable.Columns.Add("Key", Type.GetType("System.String"));
			dgv_TheKeyList.set_DataSource((object)TheKeyTable);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	public void PrepareDataTable()
	{
		checked
		{
			try
			{
				AddingColumnsForTable();
				int num = 0;
				DataGridView val = dgv_TheWebserverList;
				num = ((Control)val).get_Width();
				DataGridViewColumn val2 = val.get_Columns().get_Item("Select");
				val2.set_HeaderText("");
				((DataGridViewCell)val2.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val2.set_Width(21);
				val2.set_Frozen(true);
				val2.set_ReadOnly(false);
				val2.set_Resizable((DataGridViewTriState)2);
				val2.get_DefaultCellStyle().set_BackColor(Color.LightCyan);
				val2 = null;
				DataGridViewColumn val3 = val.get_Columns().get_Item("Number");
				val3.set_HeaderText("#");
				((DataGridViewCell)val3.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val3.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
				val3.set_Width((int)Math.Round(0.1 * (double)num));
				val3.set_Visible(true);
				val3.set_ReadOnly(true);
				((DataGridViewCell)val3.get_HeaderCell()).get_Style().set_ForeColor(Color.Red);
				val3 = null;
				DataGridViewColumn val4 = val.get_Columns().get_Item("Webserver");
				val4.set_HeaderText("Webserver");
				((DataGridViewCell)val4.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val4.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)16);
				val4.set_Visible(true);
				val4.set_ReadOnly(false);
				val4.set_Width((int)Math.Round(0.9 * (double)num));
				val4 = null;
				val = null;
				DataGridView val5 = dgv_TheKeyList;
				num = ((Control)val5).get_Width();
				DataGridViewColumn val6 = val5.get_Columns().get_Item("Select");
				val6.set_HeaderText("");
				((DataGridViewCell)val6.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val6.set_Width(21);
				val6.set_Frozen(true);
				val6.set_ReadOnly(false);
				val6.set_Resizable((DataGridViewTriState)2);
				val6.get_DefaultCellStyle().set_BackColor(Color.LightCyan);
				val6 = null;
				DataGridViewColumn val7 = val5.get_Columns().get_Item("FileName");
				val7.set_HeaderText("File Name/Path");
				((DataGridViewCell)val7.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val7.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)32);
				val7.set_Width((int)Math.Round(0.45 * (double)num));
				val7.set_Visible(true);
				val7.set_ReadOnly(false);
				((DataGridViewCell)val7.get_HeaderCell()).get_Style().set_ForeColor(Color.Red);
				val7 = null;
				DataGridViewColumn val8 = val5.get_Columns().get_Item("Date");
				val8.set_HeaderText("Update");
				((DataGridViewCell)val8.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val8.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)16);
				val8.set_Visible(true);
				val8.set_ReadOnly(false);
				val8.set_Width((int)Math.Round(0.1 * (double)num));
				val8 = null;
				DataGridViewColumn val9 = val5.get_Columns().get_Item("Key");
				val9.set_HeaderText("Key Name");
				((DataGridViewCell)val9.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val9.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)16);
				val9.set_Visible(true);
				val9.set_ReadOnly(false);
				val9.set_Width((int)Math.Round(0.45 * (double)num));
				val9 = null;
				val5 = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void DatabaseCreator_Load(object sender, EventArgs e)
	{
		try
		{
			PrepareDataTable();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void AddButtons_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null));
			if (Operators.CompareString(text, "AddWebserver_btn", false) == 0)
			{
				AddWebserver();
			}
			else if (Operators.CompareString(text, "Add_Key_btn", false) == 0)
			{
				AddKeys();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void AddWebserver(string WebServers = "")
	{
		checked
		{
			try
			{
				if ((Operators.CompareString(Webserver_txtbx.get_Text(), "", false) == 0) & (Operators.CompareString(WebServers, "", false) == 0))
				{
					((Control)Webserver_txtbx).Select();
					return;
				}
				string text = Webserver_txtbx.get_Text();
				if (Operators.CompareString(WebServers, "", false) != 0)
				{
					text = WebServers;
				}
				DataRow[] array = TheWebserverTable.Select("Webserver = '" + text + "'");
				if (array.Length > 0)
				{
					((Control)Webserver_txtbx).Select();
					return;
				}
				TheWebserverTable.Rows.Add(SelectDeselectAll_Webserver_chk.get_Checked(), TheWebserverTable.Rows.Count + 1, text);
				if (SelectDeselectAll_Webserver_chk.get_Checked())
				{
					int num = dgv_TheWebserverList.get_ColumnCount() - 1;
					int num2 = 1;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						dgv_TheWebserverList.get_Item(num2, dgv_TheWebserverList.get_RowCount() - 1).get_Style().set_BackColor(Color.LightPink);
						num2++;
					}
				}
				TheKeyTable.Columns.Add(text, typeof(bool));
				string text2 = Conversions.ToString(TheWebserverTable.Rows.Count);
				DataGridViewColumn val = dgv_TheKeyList.get_Columns().get_Item(text);
				val.set_HeaderText(text2);
				((DataGridViewCell)val.get_HeaderCell()).get_Style().set_Alignment((DataGridViewContentAlignment)32);
				val.get_DefaultCellStyle().set_Alignment((DataGridViewContentAlignment)16);
				val.set_Visible(true);
				val.set_ReadOnly(false);
				val.set_SortMode((DataGridViewColumnSortMode)0);
				val.set_Width(21);
				val.set_Resizable((DataGridViewTriState)2);
				val = null;
				if (ToolStripComboBox1.get_Items().IndexOf((object)text2) < 0)
				{
					ToolStripComboBox1.get_Items().Add((object)text2);
				}
				if (ToolStripComboBox2.get_Items().IndexOf((object)text2) < 0)
				{
					ToolStripComboBox2.get_Items().Add((object)text2);
				}
				((Control)Webserver_txtbx).Select();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AddKeys()
	{
		checked
		{
			try
			{
				if ((Operators.CompareString(File_txtbx.get_Text(), "", false) == 0) | (Operators.CompareString(Key_txtbx.get_Text(), "", false) == 0))
				{
					return;
				}
				TheKeyTable.Rows.Add(SelectDeselectAll_Key_chk.get_Checked(), File_txtbx.get_Text(), Strings.Format((object)DateAndTime.get_Today(), "MMM dd, yy"), Key_txtbx.get_Text());
				if (!SelectDeselectAll_Key_chk.get_Checked())
				{
					return;
				}
				int num = dgv_TheKeyList.get_ColumnCount() - 1;
				int num2 = 1;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						dgv_TheKeyList.get_Item(num2, dgv_TheKeyList.get_RowCount() - 1).get_Style().set_BackColor(Color.LightPink);
						num2++;
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Remove_Webservers()
	{
		checked
		{
			try
			{
				if (TheWebserverTable.Select("Select = 'True'").Length == TheWebserverTable.Rows.Count)
				{
					TheWebserverTable.Rows.Clear();
					SelectDeselectAll_Webserver_chk.set_Checked(false);
					int num = TheKeyTable.Columns.Count - 1;
					while (true)
					{
						int num2 = num;
						int num3 = 4;
						if (num2 < 4)
						{
							break;
						}
						TheKeyTable.Columns.RemoveAt(num);
						num += -1;
					}
					ToolStripComboBox1.get_Items().Clear();
					ToolStripComboBox2.get_Items().Clear();
					return;
				}
				DataRow[] array = TheWebserverTable.Select("Select = 'True'");
				foreach (DataRow dataRow in array)
				{
					TheKeyTable.Columns.Remove(dataRow["Webserver"].ToString());
					TheWebserverTable.Rows.Remove(dataRow);
				}
				if (dgv_TheWebserverList.get_Rows().get_Count() == 0)
				{
					SelectDeselectAll_Webserver_chk.set_Checked(false);
					return;
				}
				int num4 = TheWebserverTable.Rows.Count - 1;
				int num5 = 0;
				while (true)
				{
					int num6 = num5;
					int num3 = num4;
					if (num6 > num3)
					{
						break;
					}
					TheWebserverTable.Rows[num5]["Number"] = num5 + 1;
					dgv_TheKeyList.get_Columns().get_Item(TheWebserverTable.Rows[num5]["Webserver"].ToString()).set_HeaderText(Conversions.ToString(num5 + 1));
					num5++;
				}
				int num7 = TheWebserverTable.Rows.Count + 1;
				int count = ToolStripComboBox1.get_Items().get_Count();
				int num8 = num7;
				while (true)
				{
					int num9 = num8;
					int num3 = count;
					if (num9 > num3)
					{
						break;
					}
					ToolStripComboBox1.get_Items().Remove((object)num8.ToString());
					num8++;
				}
				int num10 = TheWebserverTable.Rows.Count + 1;
				int count2 = ToolStripComboBox2.get_Items().get_Count();
				int num11 = num10;
				while (true)
				{
					int num12 = num11;
					int num3 = count2;
					if (num12 <= num3)
					{
						ToolStripComboBox2.get_Items().Remove((object)num11.ToString());
						num11++;
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void AcceptBtn_Click(object sender, EventArgs e)
	{
		if (((Control)Webserver_txtbx).get_Focused())
		{
			AddWebserver();
		}
		if (((Control)Key_txtbx).get_Focused() | ((Control)File_txtbx).get_Focused())
		{
			AddKeys();
		}
	}

	private void Create_btn_Click(object sender, EventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				new Factory();
				ICryptographer cryptographer = Factory.GetCryptographer("tripledes");
				if (Operators.CompareString(Password_txtbx.get_Text(), "", false) == 0)
				{
					Interaction.MsgBox((object)"Must be Password Protected.", (MsgBoxStyle)0, (object)null);
					return;
				}
				string text = "WebServer:\r\n";
				int num = TheWebserverTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					text = text + TheWebserverTable.Rows[num2]["Webserver"].ToString() + "\r\n";
					num2++;
				}
				text += "\r\nKeys:";
				int num5 = TheKeyTable.Rows.Count - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					text += "\r\n";
					int num8 = TheKeyTable.Columns.Count - 2;
					int num9 = 1;
					string text2;
					while (true)
					{
						int num10 = num9;
						num4 = num8;
						if (num10 > num4)
						{
							break;
						}
						text2 = TheKeyTable.Rows[num6][num9].ToString();
						unchecked
						{
							if (Operators.CompareString(text2, "", false) == 0 && num9 > 2)
							{
								text2 = "F";
							}
							else if (Operators.CompareString(text2, "True", false) == 0 && num9 > 2)
							{
								text2 = "T";
							}
							text = text + text2 + "|";
						}
						num9++;
					}
					text2 = TheKeyTable.Rows[num6][TheKeyTable.Columns.Count - 1].ToString();
					switch (text2)
					{
					case null:
					case "":
						text2 = "F";
						break;
					case "True":
						text2 = "T";
						break;
					}
					text += text2;
					num6++;
				}
				text = text + "\r\n\r\nEnter: " + Password_txtbx.get_Text();
				string value = cryptographer.Encrypt(text);
				((FileDialog)SaveFileDialog1).set_AddExtension(true);
				((FileDialog)SaveFileDialog1).set_CheckPathExists(true);
				((FileDialog)SaveFileDialog1).set_DefaultExt("KKL");
				((FileDialog)SaveFileDialog1).set_Filter("KasperKey List (*.KKL)|*.KKL");
				SaveFileDialog1.set_OverwritePrompt(true);
				((FileDialog)SaveFileDialog1).set_Title("Save the KasperKey List");
				((FileDialog)SaveFileDialog1).set_FileName("");
				((CommonDialog)SaveFileDialog1).ShowDialog();
				string fileName = ((FileDialog)SaveFileDialog1).get_FileName();
				if (Operators.CompareString(fileName, "", false) != 0)
				{
					StreamWriter streamWriter = new StreamWriter(fileName);
					streamWriter.Write(value);
					streamWriter.Flush();
					streamWriter.Close();
					streamWriter.Dispose();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	public byte[] Encrypt(string plainText)
	{
		checked
		{
			try
			{
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				byte[] bytes = uTF8Encoding.GetBytes(plainText);
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				byte[] bytes2 = Encoding.UTF8.GetBytes(dAkEY);
				byte[] bytes3 = Encoding.UTF8.GetBytes(dAIv);
				ICryptoTransform transform = tripleDESCryptoServiceProvider.CreateEncryptor(bytes2, bytes3);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
				memoryStream.Read(array, 0, (int)memoryStream.Length);
				cryptoStream.Close();
				return array;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public string Decrypt(byte[] inputInBytes)
	{
		checked
		{
			try
			{
				new UTF8Encoding();
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				byte[] bytes = Encoding.UTF8.GetBytes(dAkEY);
				byte[] bytes2 = Encoding.UTF8.GetBytes(dAIv);
				ICryptoTransform transform = tripleDESCryptoServiceProvider.CreateDecryptor(bytes, bytes2);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(inputInBytes, 0, inputInBytes.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)(memoryStream.Length - 1L) + 1];
				memoryStream.Read(array, 0, (int)memoryStream.Length);
				cryptoStream.Close();
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				return uTF8Encoding.GetString(array);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				string result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public string ImportTheListData()
	{
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new Factory();
			ICryptographer cryptographer = Factory.GetCryptographer("tripledes");
			OpenFileDialog1.set_CheckFileExists(true);
			((FileDialog)OpenFileDialog1).set_CheckPathExists(true);
			((FileDialog)OpenFileDialog1).set_DefaultExt("KKL");
			((FileDialog)OpenFileDialog1).set_Filter("KasperKey List (*.KKL)|*.KKL");
			OpenFileDialog1.set_Multiselect(false);
			((FileDialog)OpenFileDialog1).set_Title("Load the KasperKey List");
			((FileDialog)OpenFileDialog1).set_FileName("");
			((CommonDialog)OpenFileDialog1).ShowDialog();
			string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
			if ((Operators.CompareString(fileName, "", false) == 0) | (Operators.CompareString(fileName, (string)null, false) == 0))
			{
				return "";
			}
			StreamReader streamReader = new StreamReader(fileName);
			string data = streamReader.ReadToEnd();
			string result = cryptographer.Decrypt(data);
			data = null;
			streamReader.Close();
			streamReader.Dispose();
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			string result2 = null;
			ProjectData.ClearProjectError();
			return result2;
		}
	}

	private void Import_btn_Click(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				if (Operators.CompareString(Password_txtbx.get_Text().Trim(), "", false) == 0)
				{
					Interaction.MsgBox((object)"Must enter the list password.", (MsgBoxStyle)0, (object)null);
					return;
				}
				string text = ImportTheListData();
				if (!text.EndsWith(Password_txtbx.get_Text()) | (Operators.CompareString(Password_txtbx.get_Text(), "", false) == 0))
				{
					Interaction.MsgBox((object)"Wrong Password", (MsgBoxStyle)0, (object)null);
					text = null;
					return;
				}
				string[] array = Strings.Split(text, "\r\n\r\n", -1, (CompareMethod)0);
				string[] array2 = null;
				if (array.Length != 3)
				{
					return;
				}
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
						string[] array3 = Strings.Split(array[num2], "\r\n", -1, (CompareMethod)0);
						array2 = array3;
						int num5 = array3.Length - 1;
						int num6 = 0;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 <= num4)
							{
								AddWebserver(array3[num6]);
								num6++;
								continue;
							}
							break;
						}
					}
					else if (array[num2].StartsWith("Keys:\r\n"))
					{
						array[num2] = array[num2].Replace("Keys:\r\n", "");
						string[] array4 = Strings.Split(array[num2], "\r\n", -1, (CompareMethod)0);
						int num8 = array4.Length - 1;
						int num9 = 0;
						while (true)
						{
							int num10 = num9;
							num4 = num8;
							if (num10 > num4)
							{
								break;
							}
							string[] array5 = Strings.Split(array4[num9], "|", -1, (CompareMethod)0);
							if (array5.Length > 3)
							{
								TheKeyTable.Rows.Add(false, array5[0], array5[1], array5[2]);
							}
							if (array5.Length > 3)
							{
								int num11 = array5.Length - 1;
								int num12 = 3;
								while (true)
								{
									int num13 = num12;
									num4 = num11;
									if (num13 > num4)
									{
										break;
									}
									if (Operators.CompareString(array5[num12], "T", false) == 0)
									{
										dgv_TheKeyList.get_Item(array2[num12 - 3], TheKeyTable.Rows.Count - 1).set_Value((object)true);
									}
									num12++;
								}
							}
							num9++;
						}
					}
					num2++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void cms_Opened(object sender, EventArgs e)
	{
		try
		{
			((ToolStripControlHost)ToolStripComboBox1).set_Text("Select a Webserver.");
			((ToolStripControlHost)ToolStripComboBox2).set_Text("Select a Webserver.");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripComboBox_TextChanged(object sender, EventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		checked
		{
			try
			{
				ToolStripComboBox val = (ToolStripComboBox)sender;
				if (Operators.CompareString(((ToolStripControlHost)val).get_Text(), "Select a Webserver.", false) == 0)
				{
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ToolStripItem)ToolStripComboBox1).get_Name(), false))
				{
					val = ToolStripComboBox1;
				}
				else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ToolStripItem)ToolStripComboBox2).get_Name(), false))
				{
					val = ToolStripComboBox2;
				}
				int num = dgv_TheKeyList.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					int num5 = Conversions.ToInteger(((ToolStripControlHost)val).get_Text());
					if (Conversions.ToBoolean(dgv_TheKeyList.get_Item(0, num2).get_Value()))
					{
						if (Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)ToolStripComboBox1).get_Name(), false) == 0)
						{
							dgv_TheKeyList.get_Item(num5 + 3, num2).set_Value((object)true);
						}
						if (Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)ToolStripComboBox2).get_Name(), false) == 0)
						{
							dgv_TheKeyList.get_Item(num5 + 3, num2).set_Value((object)false);
						}
					}
					num2++;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SelectHighlightedToolStripMenuItem_Click(object sender, EventArgs e)
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
				DataGridView val2 = null;
				if ((Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)SelectHighlightedToolStripMenuItem).get_Name(), false) == 0) | (Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)SelectHighlightedToolStripMenuItem1).get_Name(), false) == 0))
				{
					flag = true;
					backColor = Color.LightPink;
				}
				val2 = ((!((Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)SelectHighlightedToolStripMenuItem).get_Name(), false) == 0) | (Operators.CompareString(((ToolStripItem)val).get_Name(), ((ToolStripItem)DeselectHighlightedToolStripMenuItem).get_Name(), false) == 0))) ? dgv_TheWebserverList : dgv_TheKeyList);
				int num = val2.get_Rows().get_Count() - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					if (val2.get_Item(1, num2).get_Selected())
					{
						val2.get_Item("Select", num2).set_Value((object)flag);
						int num5 = val2.get_ColumnCount() - 1;
						int num6 = 1;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							val2.get_Item(num6, num2).get_Style().set_BackColor(backColor);
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
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SelectDeselect_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ToolStripItem)SelectAllToolStripMenuItem1).get_Name(), false))
			{
				SelectDeselectAll_Key_chk.set_Checked(true);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ToolStripItem)DeselectAllToolStripMenuItem1).get_Name(), false))
			{
				SelectDeselectAll_Key_chk.set_Checked(false);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ToolStripItem)SelectAllToolStripMenuItem).get_Name(), false))
			{
				SelectDeselectAll_Webserver_chk.set_Checked(true);
			}
			else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(sender, (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)((ToolStripItem)DeselectAllToolStripMenuItem).get_Name(), false))
			{
				SelectDeselectAll_Webserver_chk.set_Checked(false);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoveSelectedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (TheKeyTable.Select("Select = 'True'").Length == TheKeyTable.Rows.Count)
			{
				TheKeyTable.Rows.Clear();
				SelectDeselectAll_Key_chk.set_Checked(false);
				return;
			}
			DataRow[] array = TheKeyTable.Select("Select = 'True'");
			foreach (DataRow row in array)
			{
				TheKeyTable.Rows.Remove(row);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoveSelectedToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			Remove_Webservers();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkSelectedKeysToolStripMenuItem_MouseEnter(object sender, EventArgs e)
	{
		try
		{
			((ToolStripControlHost)ToolStripComboBox2).set_Text("Select a Webserver.");
			((ToolStripControlHost)ToolStripComboBox1).set_Text("Select a Webserver.");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void ImportKeysToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				OpenFileDialog1.set_CheckFileExists(true);
				((FileDialog)OpenFileDialog1).set_CheckPathExists(true);
				((FileDialog)OpenFileDialog1).set_DefaultExt("txt");
				((FileDialog)OpenFileDialog1).set_Filter("TAB Seperated Text File (*.txt)|*.txt");
				OpenFileDialog1.set_Multiselect(false);
				((FileDialog)OpenFileDialog1).set_Title("Load the Key List (TAB Seperated)");
				((FileDialog)OpenFileDialog1).set_FileName("");
				((CommonDialog)OpenFileDialog1).ShowDialog();
				string fileName = ((FileDialog)OpenFileDialog1).get_FileName();
				if (Operators.CompareString(fileName, "", false) == 0)
				{
					return;
				}
				StreamReader streamReader = new StreamReader(fileName);
				string text = streamReader.ReadToEnd();
				streamReader.Close();
				streamReader.Dispose();
				string[] array = Strings.Split(text, "\r\n", -1, (CompareMethod)0);
				if ((array.Length == 1) & (Operators.CompareString(array[0].Trim(), "", false) == 0))
				{
					return;
				}
				int num = 0;
				int num2 = array.Length - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					string[] array2 = Strings.Split(array[num3], "\t", -1, (CompareMethod)0);
					if (array2.Length >= 3)
					{
						TheKeyTable.Rows.Add(false, array2[0], array2[1], array2[2]);
						num++;
					}
					num3++;
				}
				if (num == 0)
				{
					Interaction.MsgBox((object)"To be able to Import Key List, must have at lease three data columns:\r\nFile Path and Name, Date, and The key Name ", (MsgBoxStyle)0, (object)null);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void ExportKeysToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				string text = "";
				int num = TheKeyTable.Rows.Count - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					text = text + TheKeyTable.Rows[num2][1].ToString() + "\t" + TheKeyTable.Rows[num2][2].ToString() + "\t" + TheKeyTable.Rows[num2][3].ToString() + "\r\n";
					num2++;
				}
				((FileDialog)SaveFileDialog1).set_AddExtension(true);
				((FileDialog)SaveFileDialog1).set_AutoUpgradeEnabled(true);
				((FileDialog)SaveFileDialog1).set_CheckPathExists(true);
				((FileDialog)SaveFileDialog1).set_DefaultExt("txt");
				((FileDialog)SaveFileDialog1).set_Filter("Text File (*.txt)|*.txt");
				SaveFileDialog1.set_OverwritePrompt(true);
				((FileDialog)SaveFileDialog1).set_Title("Save the Key List.");
				((FileDialog)SaveFileDialog1).set_FileName("");
				((CommonDialog)SaveFileDialog1).ShowDialog();
				string fileName = ((FileDialog)SaveFileDialog1).get_FileName();
				if (Operators.CompareString(fileName, "", false) != 0)
				{
					StreamWriter streamWriter = new StreamWriter(fileName);
					streamWriter.Write(text);
					streamWriter.Flush();
					streamWriter.Close();
					streamWriter.Dispose();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RemoveAllToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			SelectDeselectAll_Webserver_chk.set_Checked(true);
			Remove_Webservers();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoveAllToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			TheKeyTable.Rows.Clear();
			SelectDeselectAll_Key_chk.set_Checked(false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MyProject.Forms.cls_KasperKeySharingNetwork.ShowError(ex2);
			ProjectData.ClearProjectError();
		}
	}
}
