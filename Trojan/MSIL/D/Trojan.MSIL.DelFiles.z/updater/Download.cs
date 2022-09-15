using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using updater.My;

namespace updater;

[StandardModule]
internal sealed class Download
{
	public static double down;

	public static double downTemp;

	public static bool downloadfile(string URL, string save)
	{
		FileStream fileStream = new FileStream(save, FileMode.Create);
		byte[] buffer = new byte[1000];
		MyProject.Forms.Form1.dlfilename.set_Text("Current download: " + save);
		Application.DoEvents();
		checked
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebRequest.GetResponse().GetResponseStream();
				MyProject.Forms.Form1.ProgressBar1.set_Value(0);
				MyProject.Forms.Form1.ProgressBar1.set_Maximum((int)httpWebResponse.ContentLength);
				MyProject.Forms.Form1.Timer1.set_Enabled(true);
				int num;
				do
				{
					num = responseStream.Read(buffer, 0, 1000);
					down += num;
					((Control)MyProject.Forms.Form1.progress).Show();
					MyProject.Forms.Form1.progress.set_Text("Downloaded " + Strings.Format((object)((double)MyProject.Forms.Form1.ProgressBar1.get_Value() / 1024.0), "#,##0.00") + " kb von " + Strings.Format((object)((double)MyProject.Forms.Form1.ProgressBar1.get_Maximum() / 1024.0), "#,##0.00") + " kb");
					Application.DoEvents();
					if (MyProject.Forms.Form1.ProgressBar1.get_Value() + num > MyProject.Forms.Form1.ProgressBar1.get_Maximum())
					{
						MyProject.Forms.Form1.ProgressBar1.set_Value(MyProject.Forms.Form1.ProgressBar1.get_Maximum());
					}
					else
					{
						ProgressBar progressBar = MyProject.Forms.Form1.ProgressBar1;
						progressBar.set_Value(progressBar.get_Value() + num);
					}
					fileStream.Write(buffer, 0, num);
				}
				while (num != 0);
				((Control)MyProject.Forms.Form1.speed).Show();
				MyProject.Forms.Form1.speed.set_Text("");
				down = 0.0;
				MyProject.Forms.Form1.Timer1.set_Enabled(false);
				responseStream.Close();
				fileStream.Close();
				((Control)MyProject.Forms.Form1.progress).Hide();
				((Control)MyProject.Forms.Form1.speed).Hide();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MyProject.Forms.Form1.Timer1.set_Enabled(false);
				((Control)MyProject.Forms.Form1.progress).Hide();
				((Control)MyProject.Forms.Form1.speed).Hide();
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	public static Version getversion(string htmlurl)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		string text = MyProject.Forms.Form1.WebBrowser1.get_DocumentText().ToString();
		int num = 60;
		WebBrowser webBrowser = MyProject.Forms.Form1.WebBrowser1;
		webBrowser.Navigate(htmlurl);
		DateTime now = DateAndTime.get_Now();
		do
		{
			if ((int)webBrowser.get_ReadyState() != 4)
			{
				Application.DoEvents();
				continue;
			}
			webBrowser = null;
			text = MyProject.Forms.Form1.WebBrowser1.get_Document().get_Body().get_InnerHtml()
				.ToString();
			return new Version(text);
		}
		while (DateAndTime.DateDiff((DateInterval)9, now, DateAndTime.get_Now(), (FirstDayOfWeek)1, (FirstWeekOfYear)1) <= num);
		return new Version(0, 0, 0, 0);
	}

	public static bool downloadfilesave(string URL, string save)
	{
		FileStream fileStream = new FileStream(save, FileMode.Create);
		byte[] buffer = new byte[1000];
		MyProject.Forms.Form1.dlfilename.set_Text("Current download: " + save);
		Application.DoEvents();
		checked
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebRequest.GetResponse().GetResponseStream();
				MyProject.Forms.Form1.ProgressBar1.set_Value(0);
				MyProject.Forms.Form1.ProgressBar1.set_Maximum((int)httpWebResponse.ContentLength);
				MyProject.Forms.Form1.Timer1.set_Enabled(true);
				int num;
				do
				{
					num = responseStream.Read(buffer, 0, 1000);
					down += num;
					((Control)MyProject.Forms.Form1.progress).Show();
					MyProject.Forms.Form1.progress.set_Text("Downloaded " + Strings.Format((object)((double)MyProject.Forms.Form1.ProgressBar1.get_Value() / 1024.0), "#,##0.00") + " kb von " + Strings.Format((object)((double)MyProject.Forms.Form1.ProgressBar1.get_Maximum() / 1024.0), "#,##0.00") + " kb");
					Application.DoEvents();
					if (MyProject.Forms.Form1.ProgressBar1.get_Value() + num > MyProject.Forms.Form1.ProgressBar1.get_Maximum())
					{
						MyProject.Forms.Form1.ProgressBar1.set_Value(MyProject.Forms.Form1.ProgressBar1.get_Maximum());
					}
					else
					{
						ProgressBar progressBar = MyProject.Forms.Form1.ProgressBar1;
						progressBar.set_Value(progressBar.get_Value() + num);
					}
					fileStream.Write(buffer, 0, num);
				}
				while (num != 0);
				((Control)MyProject.Forms.Form1.speed).Show();
				MyProject.Forms.Form1.speed.set_Text("");
				down = 0.0;
				MyProject.Forms.Form1.Timer1.set_Enabled(false);
				responseStream.Close();
				fileStream.Close();
				((Control)MyProject.Forms.Form1.progress).Hide();
				((Control)MyProject.Forms.Form1.speed).Hide();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MyProject.Forms.Form1.Timer1.set_Enabled(false);
				((Control)MyProject.Forms.Form1.progress).Hide();
				((Control)MyProject.Forms.Form1.speed).Hide();
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
