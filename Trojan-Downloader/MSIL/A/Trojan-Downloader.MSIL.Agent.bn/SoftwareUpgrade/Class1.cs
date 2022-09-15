using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SoftwareUpgrade;

internal class Class1
{
	public WebClient webClient_0 = new WebClient();

	public void method_0(string string_0, string string_1, DateTime dateTime_0)
	{
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processes = Process.GetProcesses();
			string text = string_1.Split(new char[1] { '\\' })[^1].Split(new char[1] { '.' })[0].ToLower().Trim();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i].ProcessName.ToLower().Trim() == text && processes[i].MainWindowTitle.Trim() == "")
				{
					processes[i].Kill();
				}
			}
			WebRequest.Create(string_0);
		}
		catch (WebException)
		{
			Process.GetCurrentProcess().Kill();
		}
		try
		{
			Class0.form1_0.progressBar1.set_Value(0);
			Class0.form1_0.progressBar1.set_Minimum(0);
			Stream stream = webClient_0.OpenRead(string_0);
			int num = smethod_0(string_0);
			byte[] buffer = new byte[num * 8];
			int num2 = 0;
			num2 = ((num * 8 < 10240) ? num : 10240);
			int num3 = 0;
			int num4 = 0;
			num4 = ((num / num2 == 1) ? 1 : (num / num2 + 1));
			Class0.form1_0.progressBar1.set_Maximum(num4);
			int num5 = num * 8;
			while (num5 > 0)
			{
				Application.DoEvents();
				int num6 = stream.Read(buffer, num3, num2);
				if (num6 == 0)
				{
					break;
				}
				num3 += num6;
				num5 -= num6;
				if (Class0.form1_0.progressBar1.get_Value() < num4)
				{
					ProgressBar progressBar = Class0.form1_0.progressBar1;
					progressBar.set_Value(progressBar.get_Value() + 1);
				}
			}
			FileStream fileStream = new FileStream(string_1, FileMode.OpenOrCreate, FileAccess.Write);
			try
			{
				fileStream.Write(buffer, 0, num3);
				stream.Close();
				fileStream.Close();
				File.SetLastWriteTime(string_1, dateTime_0);
			}
			catch (Exception)
			{
				MessageBox.Show("Update file fail!");
				File.Copy("tempoldfiles\\" + string_1.Substring(string_1.LastIndexOf("\\") + 1), string_1);
				Process.GetCurrentProcess().Kill();
			}
		}
		catch (WebException)
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	private static int smethod_0(string string_0)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		int result = (int)httpWebResponse.ContentLength;
		httpWebResponse.Close();
		return result;
	}
}
