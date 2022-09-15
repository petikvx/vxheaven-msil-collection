using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using KasperKeySharingNetwork.My;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

[DesignerGenerated]
public class form_CheckBlacklist : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("lbl_One")]
	private ReflectionLabel _lbl_One;

	[AccessedThroughProperty("btn_Yes")]
	private ButtonX _btn_Yes;

	[AccessedThroughProperty("btn_NO")]
	private ButtonX _btn_NO;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBarX _ProgressBar1;

	[AccessedThroughProperty("lbl_Two")]
	private ReflectionLabel _lbl_Two;

	[AccessedThroughProperty("lbl_Three")]
	private ReflectionLabel _lbl_Three;

	[AccessedThroughProperty("bg_Blacklist")]
	private BackgroundWorker _bg_Blacklist;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	[DebuggerNonUserCode]
	public form_CheckBlacklist()
	{
		((Form)this).add_Load((EventHandler)form_CheckBlacklist_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(form_CheckBlacklist));
		lbl_One = new ReflectionLabel();
		btn_Yes = new ButtonX();
		btn_NO = new ButtonX();
		ProgressBar1 = new ProgressBarX();
		lbl_Two = new ReflectionLabel();
		lbl_Three = new ReflectionLabel();
		bg_Blacklist = new BackgroundWorker();
		Label1 = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)lbl_One).set_BackColor(Color.Transparent);
		ReflectionLabel reflectionLabel = lbl_One;
		Point location = new Point(19, 20);
		((Control)reflectionLabel).set_Location(location);
		((Control)lbl_One).set_Name("lbl_One");
		ReflectionLabel reflectionLabel2 = lbl_One;
		Size size = new Size(413, 74);
		((Control)reflectionLabel2).set_Size(size);
		((Control)lbl_One).set_TabIndex(0);
		lbl_One.Text = "<b><font size=\"+6\"><font color=\"#B02B2C\">Do you wish to view the Keys </font><i>Blacklist </i><font color=\"#B02B2C\">Status? </font></font></b>";
		((Control)btn_Yes).set_AccessibleRole((AccessibleRole)43);
		((Control)btn_Yes).set_BackColor(Color.Transparent);
		btn_Yes.ColorTable = eButtonColor.BlueOrb;
		btn_Yes.DialogResult = (DialogResult)6;
		((Control)btn_Yes).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		ButtonX buttonX = btn_Yes;
		location = new Point(228, 100);
		((Control)buttonX).set_Location(location);
		((Control)btn_Yes).set_Name("btn_Yes");
		btn_Yes.Shape = new RoundRectangleShapeDescriptor(10);
		ButtonX buttonX2 = btn_Yes;
		size = new Size(75, 23);
		((Control)buttonX2).set_Size(size);
		((Control)btn_Yes).set_TabIndex(1);
		btn_Yes.Text = "Yes";
		((Control)btn_NO).set_AccessibleRole((AccessibleRole)43);
		((Control)btn_NO).set_BackColor(Color.Transparent);
		btn_NO.ColorTable = eButtonColor.Office2007WithBackground;
		btn_NO.DialogResult = (DialogResult)7;
		((Control)btn_NO).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		ButtonX buttonX3 = btn_NO;
		location = new Point(147, 100);
		((Control)buttonX3).set_Location(location);
		((Control)btn_NO).set_Name("btn_NO");
		btn_NO.Shape = new RoundRectangleShapeDescriptor(10);
		ButtonX buttonX4 = btn_NO;
		size = new Size(75, 23);
		((Control)buttonX4).set_Size(size);
		((Control)btn_NO).set_TabIndex(2);
		btn_NO.Text = "No";
		((Control)ProgressBar1).set_BackColor(Color.Transparent);
		ProgressBar1.ChunkColor = Color.Red;
		ProgressBar1.ChunkColor2 = Color.Yellow;
		ProgressBarX progressBar = ProgressBar1;
		location = new Point(101, 45);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar1.ProgressType = eProgressItemType.Marquee;
		ProgressBarX progressBar2 = ProgressBar1;
		size = new Size(248, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(3);
		((Control)ProgressBar1).set_Text("ProgressBarX1");
		((Control)ProgressBar1).set_Visible(false);
		((Control)lbl_Two).set_BackColor(Color.Transparent);
		ReflectionLabel reflectionLabel3 = lbl_Two;
		location = new Point(57, 72);
		((Control)reflectionLabel3).set_Location(location);
		((Control)lbl_Two).set_Name("lbl_Two");
		ReflectionLabel reflectionLabel4 = lbl_Two;
		size = new Size(212, 48);
		((Control)reflectionLabel4).set_Size(size);
		((Control)lbl_Two).set_TabIndex(4);
		lbl_Two.Text = "<b><font size=\"+6\"><font color=\"#B02B2C\">Retrieving </font><i>Blacklist </i><font color=\"#B02B2C\">file.</font></font></b> ";
		((Control)lbl_Two).set_Visible(false);
		((Control)lbl_Three).set_BackColor(Color.Transparent);
		ReflectionLabel reflectionLabel5 = lbl_Three;
		location = new Point(268, 78);
		((Control)reflectionLabel5).set_Location(location);
		((Control)lbl_Three).set_Name("lbl_Three");
		ReflectionLabel reflectionLabel6 = lbl_Three;
		size = new Size(105, 37);
		((Control)reflectionLabel6).set_Size(size);
		((Control)lbl_Three).set_TabIndex(5);
		lbl_Three.Text = "<font size=\"+2\"><font color=\"#B02B2C\">Please standby..</font></font>";
		((Control)lbl_Three).set_Visible(false);
		bg_Blacklist.WorkerReportsProgress = true;
		bg_Blacklist.WorkerSupportsCancellation = true;
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(144, 123);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Label1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(451, 148);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)lbl_Three);
		((Control)this).get_Controls().Add((Control)(object)lbl_Two);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)btn_NO);
		((Control)this).get_Controls().Add((Control)(object)btn_Yes);
		((Control)this).get_Controls().Add((Control)(object)lbl_One);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("form_CheckBlacklist");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_Text("Blaklist.");
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void btn_Yes_Click(object sender, EventArgs e)
	{
		((Control)btn_NO).set_Visible(false);
		((Control)btn_Yes).set_Visible(false);
		((Control)lbl_One).set_Visible(false);
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
		((Control)lbl_Two).set_Visible(false);
		((Control)lbl_Three).set_Visible(false);
		((Control)ProgressBar1).set_Visible(false);
		bg_Blacklist.WorkerReportsProgress = false;
		((Form)this).Close();
		((Control)MyProject.Forms.form_KeyViewer).Show();
	}

	private void bg_Blacklist_DoWork(object sender, DoWorkEventArgs e)
	{
		Timer1.set_Enabled(true);
		Timer1.set_Interval(50);
		Timer1.Start();
		BlacklistViewer.Download.Overwrite = true;
		BlacklistViewer.FileInfo.Uppercase = true;
		BlacklistViewer.Functions.AnalyzeFile();
		Timer1.Stop();
		((Component)(object)Timer1).Dispose();
		Timer1.set_Enabled(false);
	}

	private void btn_NO_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).Close();
		((Control)MyProject.Forms.form_KeyViewer).Show();
	}

	private void form_CheckBlacklist_Load(object sender, EventArgs e)
	{
		if (BlacklistViewer.FileInfo.KeyList.Length > 0)
		{
			((Control)this).Hide();
			((Form)this).Close();
			((Control)MyProject.Forms.form_KeyViewer).Show();
		}
	}

	private void bg_Blacklist_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		Label1.set_Text(BlacklistViewer.ProcessStage);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		bg_Blacklist.ReportProgress(100);
	}
}
