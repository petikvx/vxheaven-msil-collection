using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using KasperKeySharingNetwork.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace KasperKeySharingNetwork;

public class BlacklistViewer
{
	public class Download
	{
		public static bool Overwrite
		{
			get
			{
				return Conversions.ToBoolean(bln_OverwriteDownloadedFile);
			}
			set
			{
				bln_OverwriteDownloadedFile = value;
			}
		}

		public static string Location
		{
			get
			{
				return str_DownloadLocation;
			}
			set
			{
				str_DownloadLocation = value;
			}
		}

		public static Array Link
		{
			get
			{
				return str_DownloadLink;
			}
			set
			{
				str_DownloadLink = (string[])value;
			}
		}

		[DebuggerNonUserCode]
		public Download()
		{
		}
	}

	public class FileInfo
	{
		public static DateTime UpdateDate => str_UpdateDate;

		public static int Version => int_Version;

		public static int TotalKeysListed => int_TotalKeysListed;

		public static Array KeyList => ary_KeyList.ToArray();

		public static bool Uppercase
		{
			get
			{
				return bln_UppercaseKeys;
			}
			set
			{
				bln_UppercaseKeys = value;
			}
		}

		public static string FilePathUsed => Conversions.ToString(str_FileName_Path__USED__);

		public static int CurrentKeyReading => Conversions.ToInteger(int_CurrentKeyReading);

		[DebuggerNonUserCode]
		public FileInfo()
		{
		}
	}

	public class Functions
	{
		[DebuggerNonUserCode]
		public Functions()
		{
		}

		public static string DownloadFile()
		{
			checked
			{
				try
				{
					string text = "";
					int num = 1;
					string[] str_DownloadLink = BlacklistViewer.str_DownloadLink;
					foreach (string text2 in str_DownloadLink)
					{
						ProcessStage = "Checking Network Availability.";
						int num2 = 1;
						do
						{
							Application.DoEvents();
							Thread.Sleep(50);
							num2++;
						}
						while (num2 <= 10);
						if (((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable())
						{
							text = FileNameDetermination(str_DownloadLocation + "\\black.lst");
							if (Operators.CompareString(text, "", false) != 0)
							{
								ProcessStage = "Downloading the Blacklist File, Try # " + Conversions.ToString(num);
								int num3 = 1;
								do
								{
									Application.DoEvents();
									Thread.Sleep(50);
									num3++;
								}
								while (num3 <= 15);
								try
								{
									((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text2, text);
								}
								catch (Exception projectError)
								{
									ProjectData.SetProjectError(projectError);
									ProjectData.ClearProjectError();
								}
								if (!File.Exists(text))
								{
									num++;
									continue;
								}
								break;
							}
							return "";
						}
						return "";
					}
					return text;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					string result = "";
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public static string FileNameDetermination(string FileName_And_Location)
		{
			try
			{
				ProcessStage = "Determining the File Name.";
				Application.DoEvents();
				if (Operators.CompareString(FileName_And_Location, "", false) == 0)
				{
					return "";
				}
				int num = FileName_And_Location.LastIndexOf(".");
				string text = FileName_And_Location.Substring(num, checked(FileName_And_Location.Length - num));
				FileName_And_Location = FileName_And_Location.Substring(0, num);
				bool flag = false;
				string text2 = "";
				string text3 = Conversions.ToString(1);
				do
				{
					if (!File.Exists(FileName_And_Location + text2 + text))
					{
						flag = false;
						continue;
					}
					if (Conversions.ToBoolean(bln_OverwriteDownloadedFile))
					{
						try
						{
							File.SetAttributes(FileName_And_Location + text2 + text, FileAttributes.Normal);
							File.Delete(FileName_And_Location + text2 + text);
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							text2 = "(" + text3 + ")";
							text3 = Conversions.ToString(Conversions.ToDouble(text3) + 1.0);
							ProjectData.ClearProjectError();
						}
					}
					else
					{
						text2 = "(" + text3 + ")";
						text3 = Conversions.ToString(Conversions.ToDouble(text3) + 1.0);
					}
					flag = true;
				}
				while (flag);
				ProcessStage = "";
				Application.DoEvents();
				return FileName_And_Location + text2 + text;
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				string result = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static bool AnalyzeFile(int Procedure = 0)
		{
			try
			{
				theTimer.set_Enabled(true);
				theTimer.set_Interval(10);
				theTimer.Start();
				BlacklistViewer blacklistViewer = new BlacklistViewer();
				blacklistViewer.CleanData();
				switch (Procedure)
				{
				default:
					return false;
				case 0:
					str_FileName_Path__USED__ = LatestLocalFilePath();
					break;
				case 1:
					str_FileName_Path__USED__ = RuntimeHelpers.GetObjectValue(str_FileName_Path);
					break;
				case 2:
					str_FileName_Path__USED__ = LatestLocalFilePath();
					break;
				case 3:
					str_FileName_Path__USED__ = LatestLocalFilePath(Conversions.ToString(str_FileName_Path));
					break;
				case 4:
				{
					string text = DownloadFile();
					if (!File.Exists(text))
					{
						ProcessStage = "Unable to Download the Blacklist file.";
						Application.DoEvents();
						return false;
					}
					str_FileName_Path__USED__ = text;
					break;
				}
				}
				if (!File.Exists(Conversions.ToString(str_FileName_Path__USED__)))
				{
					ProcessStage = "Unable to Find the Local Blacklist file.";
					Application.DoEvents();
					string text2 = DownloadFile();
					if (!File.Exists(text2))
					{
						ProcessStage = "Unable to Download the Blacklist file.";
						Application.DoEvents();
						return false;
					}
					str_FileName_Path__USED__ = text2;
				}
				string theHexText = blacklistViewer.ReadTheFile(Conversions.ToString(str_FileName_Path__USED__));
				if (!blacklistViewer.FileStructure(theHexText))
				{
					return false;
				}
				if (!blacklistViewer.ReadHeader())
				{
					return false;
				}
				if (!blacklistViewer.ReadFooter())
				{
					return false;
				}
				if (!blacklistViewer.ReadBody())
				{
					return false;
				}
				ProcessStage = "";
				Application.DoEvents();
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private static object str_FileName_Path = "";

	private static object str_FileName_Path__USED__ = "";

	private static string str_DownloadLocation = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);

	private static object bln_OverwriteDownloadedFile = false;

	private static bool bln_UppercaseKeys = true;

	private static DateTime str_UpdateDate;

	private static int int_Version;

	private static int int_TotalKeysListed;

	private static ArrayList ary_Header = new ArrayList();

	private static ArrayList ary_Footer = new ArrayList();

	private static ArrayList ary_KeyList = new ArrayList();

	[AccessedThroughProperty("BGName")]
	private static BackgroundWorker _BGName;

	public static object int_CurrentKeyReading = 0;

	public static int ProcessPercent = 0;

	public static string ProcessStage = "";

	[AccessedThroughProperty("theTimer")]
	private static Timer _theTimer;

	private static Array ary_theHexArray;

	private static string[] str_DownloadLink = new string[12]
	{
		"ftp://ftp.kaspersky.ru/updates/black.lst", "ftp://downloads.kaspersky-labs.com/updates/black.lst", "ftp://downloads0.kaspersky-labs.com/updates/black.lst", "ftp://downloads1.kaspersky-labs.com/updates/black.lst", "ftp://downloads2.kaspersky-labs.com/updates/black.lst", "ftp://downloads3.kaspersky-labs.com/updates/black.lst", "ftp://downloads4.kaspersky-labs.com/updates/black.lst", "ftp://downloads5.kaspersky-labs.com/updates/black.lst", "ftp://downloads6.kaspersky-labs.com/updates/black.lst", "ftp://downloads7.kaspersky-labs.com/updates/black.lst",
		"ftp://downloads8.kaspersky-labs.com/updates/black.lst", "ftp://downloads9.kaspersky-labs.com/updates/black.lst"
	};

	private object str_Header;

	private object str_Body;

	private string str_Footer;

	private static BackgroundWorker BGName
	{
		[DebuggerNonUserCode]
		get
		{
			return _BGName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BGName = value;
		}
	}

	private static Timer theTimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _theTimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = theTimer_Tick;
			if (_theTimer != null)
			{
				_theTimer.remove_Tick(eventHandler);
			}
			_theTimer = value;
			if (_theTimer != null)
			{
				_theTimer.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static string FileName_Path
	{
		get
		{
			return Conversions.ToString(str_FileName_Path);
		}
		set
		{
			str_FileName_Path = value;
		}
	}

	public static BackgroundWorker BackgroundWorkerName
	{
		get
		{
			return BGName;
		}
		set
		{
			BGName = value;
		}
	}

	public BlacklistViewer()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		str_Header = "";
		str_Body = "";
		str_Footer = "";
	}

	private static string LatestLocalFilePath(string Location = "")
	{
		checked
		{
			try
			{
				ProcessStage = "Searching for Local Blacklist File.";
				BlacklistViewer blacklistViewer = new BlacklistViewer();
				FileSearch.str_TheFileLabelText = ProcessStage;
				if (!FileSearch.FindFile(Location))
				{
					throw new ArgumentException("Yehoo");
				}
				Array foundFilePath = FileSearch.FoundFilePath;
				if (foundFilePath.Length == 0)
				{
					return "Not Found";
				}
				DateTime[] array = new DateTime[foundFilePath.Length - 1 + 1];
				int num = -1;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = foundFilePath.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string text = Conversions.ToString(enumerator.Current);
						blacklistViewer.CleanData();
						if (File.Exists(text))
						{
							num++;
							string theHexText = blacklistViewer.ReadTheFile(text);
							if (blacklistViewer.FileStructure(theHexText, HeaderOnly: true) && blacklistViewer.ReadHeader())
							{
								ref DateTime reference = ref array[num];
								reference = FileInfo.UpdateDate;
							}
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				DateTime[] array2 = new DateTime[array.Length - 1 + 1];
				int num2 = array2.Length - 1;
				int num3 = 0;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					ref DateTime reference2 = ref array2[num3];
					reference2 = array[num3];
					num3++;
				}
				Array.Sort(array2);
				int num6 = Array.IndexOf(array, array2[array2.Length - 1]);
				return Conversions.ToString(NewLateBinding.LateIndexGet((object)foundFilePath, new object[1] { num6 }, (string[])null));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string result = "C:\\Documents and Settings\\All Users\\Application Data\\Kaspersky Lab\\AVP8\\Bases\\black.lst";
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private static void theTimer_Tick(object sender, EventArgs e)
	{
		Application.DoEvents();
	}

	private void CleanData()
	{
		str_UpdateDate = default(DateTime);
		int_Version = 0;
		int_TotalKeysListed = 0;
		ary_Header.Clear();
		ary_Footer.Clear();
		ary_KeyList.Clear();
		str_Header = "";
		str_Body = "";
		str_Footer = "";
		str_FileName_Path__USED__ = "";
		int_CurrentKeyReading = 0;
	}

	private string ReadTheFile(string TheFile)
	{
		ProcessStage = "Reading the Blacklist File";
		Application.DoEvents();
		FileStream fileStream = new FileStream(TheFile, FileMode.Open, FileAccess.Read);
		checked
		{
			byte[] array = new byte[(int)(fileStream.Length - 1L) + 1];
			fileStream.Read(array, 0, (int)fileStream.Length);
			fileStream.Dispose();
			fileStream.Close();
			string text = Strings.Join((string[])(ary_theHexArray = (string[])ByteToHex(array)), " ").Trim();
			if (bln_UppercaseKeys)
			{
				return text.ToUpper();
			}
			return text.ToLower();
		}
	}

	private Array ByteToHex(byte[] TheByte)
	{
		checked
		{
			string[] array = new string[TheByte.Length - 1 + 1];
			int num = TheByte.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = Conversion.Hex(TheByte[num2]);
				if (array[num2].Length == 1)
				{
					array[num2] = "0" + array[num2];
				}
				num2++;
			}
			return array;
		}
	}

	private bool FileStructure(string TheHexText, bool HeaderOnly = false)
	{
		checked
		{
			try
			{
				ProcessStage = "Converting Data.";
				Application.DoEvents();
				if (!TheHexText.ToUpper().StartsWith("4B 4C 42 4C"))
				{
					return false;
				}
				TheHexText = TheHexText.Remove(0, 12).Trim();
				int valueData = GetValueData(TheHexText.Substring(0, 12).Trim());
				TheHexText = TheHexText.Remove(0, 12).Trim();
				str_Header = TheHexText.Substring(0, valueData * 3).Trim();
				TheHexText = TheHexText.Remove(0, valueData * 3).Trim();
				if (HeaderOnly)
				{
					return true;
				}
				int num = GetValueData(TheHexText.Substring(0, 12).Trim()) * 4;
				int_TotalKeysListed = (int)Math.Round((double)num / 4.0);
				TheHexText = TheHexText.Remove(0, 12).Trim();
				str_Body = TheHexText.Substring(0, num * 3).Trim();
				TheHexText = TheHexText.Remove(0, num * 3).Trim();
				ArrayList arrayList = new ArrayList();
				int num2 = valueData + 12;
				int num3 = num - 1 + (valueData + 12);
				int num4 = num2;
				while (true)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					arrayList.Add(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet((object)ary_theHexArray, new object[1] { num4 }, (string[])null)));
					num4++;
				}
				ary_theHexArray = arrayList.ToArray();
				arrayList.Clear();
				str_Footer = TheHexText;
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private int GetValueData(string TheTextHex)
	{
		string text = "";
		text = Conversions.ToString(Little_Endian(Strings.Split(TheTextHex.Trim(), " ", -1, (CompareMethod)0), IntegerResults: true));
		return Conversions.ToInteger(text);
	}

	private int Little_Endian(string[] theHex, bool IntegerResults, int Start = 0, int Length = 0)
	{
		if (Length == 0)
		{
			Length = theHex.Length;
		}
		checked
		{
			Length--;
			int num = 0;
			string text = "";
			int num2 = Start + Length;
			while (true)
			{
				int num3 = num2;
				int num4 = Start;
				if (num3 < num4)
				{
					break;
				}
				text += theHex[num2];
				num2 += -1;
			}
			return HexToDec(text);
		}
	}

	private int HexToDec(string TheText)
	{
		return Convert.ToInt32(TheText, 16);
	}

	private bool ReadHeader()
	{
		try
		{
			ProcessStage = "Analyzing Data Header.";
			Application.DoEvents();
			int_Version = GetValueData(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(str_Header, (Type)null, "Substring", new object[2] { 0, 12 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null)));
			str_Header = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(str_Header, (Type)null, "Remove", new object[2] { 0, 12 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null));
			string[] array = Strings.Split(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(str_Header, (Type)null, "substring", new object[2] { 0, 24 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "trim", new object[0], (string[])null, (Type[])null, (bool[])null)), " ", -1, (CompareMethod)0);
			string text = HexToChr(array[4]) + HexToChr(array[5]) + HexToChr(array[6]) + HexToChr(array[7]);
			text = text + "/" + HexToChr(array[2]) + HexToChr(array[3]);
			text = text + "/" + HexToChr(array[0]) + HexToChr(array[1]) + " 00:00:01";
			str_UpdateDate = DateTime.ParseExact(text, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
			str_Header = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(str_Header, (Type)null, "Remove", new object[2] { 0, 24 }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Trim", new object[0], (string[])null, (Type[])null, (bool[])null));
			ary_Header.Add(RuntimeHelpers.GetObjectValue(str_Header));
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool ReadFooter()
	{
		try
		{
			ProcessStage = "Analyzing Data Footer.";
			Application.DoEvents();
			if (!str_Footer.ToUpper().StartsWith("0D 0A 3B 20") | !str_Footer.ToUpper().EndsWith("AD AD"))
			{
				return false;
			}
			ary_Footer.Add(str_Footer);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private bool ReadBody()
	{
		checked
		{
			try
			{
				ProcessStage = "Processing Key List.";
				Application.DoEvents();
				Array array = ary_theHexArray;
				Application.DoEvents();
				int num = array.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					ary_KeyList.Add(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet((object)array, new object[1] { num2 + 3 }, (string[])null), NewLateBinding.LateIndexGet((object)array, new object[1] { num2 + 2 }, (string[])null)), NewLateBinding.LateIndexGet((object)array, new object[1] { num2 + 1 }, (string[])null)), NewLateBinding.LateIndexGet((object)array, new object[1] { num2 }, (string[])null)));
					int_CurrentKeyReading = Operators.AddObject(int_CurrentKeyReading, (object)1);
					Application.DoEvents();
					num2 += 4;
				}
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string HexToChr(string TheText)
	{
		return Conversions.ToString(Strings.Chr(Convert.ToInt32(TheText, 16)));
	}
}
