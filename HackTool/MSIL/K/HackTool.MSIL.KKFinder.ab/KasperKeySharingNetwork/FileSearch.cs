using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork;

public class FileSearch
{
	private static ArrayList ary_FoundFilePath = new ArrayList();

	private static ArrayList ary_LostDirectories = new ArrayList();

	private static object TotalFiles = 0;

	private static int TotalDirectory = 0;

	public static string str_TheFileLabelText;

	public static string str_TheDirectoryLabelText;

	private static ArrayList Found = new ArrayList();

	public static Array FoundFilePath => ary_FoundFilePath.ToArray();

	public static Array LostDirectories => ary_LostDirectories.ToArray();

	[DebuggerNonUserCode]
	public FileSearch()
	{
	}

	public static bool FindFile(string Location = "")
	{
		checked
		{
			try
			{
				TotalDirectory = 0;
				TotalFiles = 0;
				ary_FoundFilePath.Clear();
				ary_LostDirectories.Clear();
				if (Operators.CompareString(Location, "", false) == 0)
				{
					DriveInfo[] drives = DriveInfo.GetDrives();
					int num = drives.Length - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 <= num4)
						{
							if (drives[num2].IsReady)
							{
								DisplayTree(drives[num2].Name);
							}
							num2++;
							continue;
						}
						break;
					}
				}
				else
				{
					DisplayTree(Location);
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

	private static void DisplayTree(string Dir)
	{
		string[] files = Directory.GetFiles(Dir.Trim());
		TotalFiles = Operators.AddObject(TotalFiles, (object)files.Length);
		try
		{
			BlacklistViewer.ProcessStage = Conversions.ToString(Operators.ConcatenateObject((object)"Searching for Local Blacklist File. ", TotalFiles));
			Application.DoEvents();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		string[] directories = Directory.GetDirectories(Dir.Trim());
		checked
		{
			TotalDirectory += directories.Length;
			try
			{
				str_TheDirectoryLabelText = "Searching for Local Blacklist File." + Conversions.ToString(TotalDirectory);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			Application.DoEvents();
			if (files.Length != 0)
			{
				string text = Strings.Join(files, "\r\n");
				if (text.ToLower().Contains("black") & text.ToLower().Contains(".lst"))
				{
					string[] array = files;
					foreach (string text2 in array)
					{
						if ((text2.ToLower().Contains("black") & text2.ToLower().Contains(".lst")) && Operators.CompareString(Path.GetExtension(text2), ".lst", false) == 0)
						{
							ary_FoundFilePath.Add(text2);
						}
					}
				}
			}
			string[] array2 = directories;
			foreach (string text3 in array2)
			{
				try
				{
					Directory.GetFiles(text3.Trim());
					DisplayTree(text3.Trim());
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ary_LostDirectories.Add(text3);
					ProjectData.ClearProjectError();
				}
			}
		}
	}

	private static void DisplayTree2(string theDir)
	{
		string[] directories = Directory.GetDirectories(theDir);
		string[] array = directories;
		foreach (string text in array)
		{
			if (Operators.CompareString(text, theDir + "System Volume Information", false) != 0)
			{
				string[] files = Directory.GetFiles(text.Trim(), "*black*.lst", SearchOption.AllDirectories);
				if (files.Length != 0)
				{
					Found.Add(files);
				}
			}
		}
	}
}
