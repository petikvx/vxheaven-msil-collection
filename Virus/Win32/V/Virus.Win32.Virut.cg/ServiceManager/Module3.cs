using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ServiceManager;

[StandardModule]
internal sealed class Module3
{
	private static string tempReturnValue;

	private static string regexFile = "([a-zA-Z]\\:|\\\\\\\\[^\\/\\\\:*^,?\"<>|]+\\\\[^\\/\\\\:*^,?\"<>|]+)(\\\\[^\\/\\\\:*^,?\"<>|]+)+(\\.[^\\/\\\\:(0-9)*^[? %!,\"<>|-]+)";

	public static string GetTrueFileDir(string strValue)
	{
		if (Operators.CompareString(strValue, "", false) != 0)
		{
			if (Strings.InStr(strValue, "%", (CompareMethod)0) > 0)
			{
				strValue = Environment.ExpandEnvironmentVariables(strValue);
			}
			if (Strings.InStr(strValue, "\\\\", (CompareMethod)0) > 0)
			{
				strValue = strValue.Replace("\\\\", "\\");
			}
			if (strValue.EndsWith("\\"))
			{
				strValue = strValue.Remove(checked(strValue.Length - 1), 1);
			}
			strValue = ProsPecificPath(strValue);
			if (FileOrDirIsExist(strValue))
			{
				return strValue;
			}
			try
			{
				if (Strings.InStr(strValue.ToLower(), "rundll32", (CompareMethod)0) > 0)
				{
					strValue = ExeFromRundll(strValue);
					if (Operators.CompareString(strValue, "", false) != 0)
					{
						if (Operators.CompareString(Strings.Trim(Regex.Match(strValue, regexFile).ToString()), "", false) != 0)
						{
							return strValue;
						}
						return FullPathEnvironmentVariablesExist(strValue);
					}
					return strValue;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (strValue.Length > 3)
			{
				if (!strValue.EndsWith("\\"))
				{
					tempReturnValue = Strings.Trim(Regex.Match(strValue, regexFile).ToString());
					if (Operators.CompareString(tempReturnValue, "", false) != 0 && tempReturnValue.Length > 3)
					{
						return tempReturnValue;
					}
					return FullPathEnvironmentVariablesExist(strValue);
				}
				if (Regex.IsMatch(strValue, "^[A-Za-z][:][\\^\\\\]") && (strValue.EndsWith("\\") || !Path.HasExtension(strValue)))
				{
					strValue = strValue.Split(new char[1] { ';' })[0];
					return strValue;
				}
			}
		}
		return "";
	}

	public static bool FileOrDirIsExist(string FileOrDirName)
	{
		try
		{
			if (!File.Exists(FileOrDirName) && !Directory.Exists(FileOrDirName))
			{
				return false;
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

	private static string ExeFromRundll(string strRundll)
	{
		try
		{
			if (Operators.CompareString(strRundll, "", false) != 0)
			{
				strRundll = strRundll.ToLower();
				if (Strings.InStr(strRundll, "rundll32.exe", (CompareMethod)0) == 0 && strRundll.StartsWith("rundll32") && Operators.CompareString(strRundll, "rundll32", false) != 0)
				{
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32")[1]);
				}
				else if (strRundll.StartsWith("rundll32.exe") && Operators.CompareString(strRundll, "rundll32.exe", false) != 0)
				{
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32.exe")[1]);
				}
				else if (strRundll.StartsWith("\"rundll32.exe\"") && Operators.CompareString(strRundll, "\"rundll32.exe\"", false) != 0)
				{
					strRundll = strRundll.Replace("\"", "");
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32.exe")[1]);
				}
				else if (strRundll.StartsWith(Environment.SystemDirectory.ToLower() + "\\rundll32.exe") && Operators.CompareString(strRundll, Environment.SystemDirectory.ToLower() + "\\rundll32.exe", false) != 0)
				{
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32.exe")[1]);
				}
				else if (strRundll.StartsWith(Environment.SystemDirectory.Remove(0, 1).ToLower() + "\\rundll32.exe") && Operators.CompareString(strRundll, Environment.SystemDirectory.Remove(0, 1).ToLower() + "\\rundll32.exe", false) != 0)
				{
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32.exe")[1]);
				}
				else if (strRundll.StartsWith("\"" + Environment.SystemDirectory.ToLower() + "\\rundll32.exe\"") && Operators.CompareString(strRundll, "\"" + Environment.SystemDirectory.ToLower() + "\\rundll32.exe\"", false) != 0)
				{
					strRundll = strRundll.Replace("\"", "");
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32.exe")[1]);
				}
				else
				{
					if (!strRundll.StartsWith("\"" + Environment.SystemDirectory.Remove(0, 1).ToLower() + "\\rundll32.exe\"") || Operators.CompareString(strRundll, "\"" + Environment.SystemDirectory.Remove(0, 1).ToLower() + "\\rundll32.exe\"", false) == 0)
					{
						return "";
					}
					strRundll = strRundll.Replace("\"", "");
					strRundll = Strings.Trim(Regex.Split(strRundll, "rundll32.exe")[1]);
				}
				string text = Strings.Trim(strRundll.Split(new char[1] { ',' })[0]);
				if (text.StartsWith("\"") && text.EndsWith("\""))
				{
					text = text.Split(new char[1] { '"' })[1];
				}
				if (text.StartsWith(":\\"))
				{
					text = Conversions.ToString(GetSystemRoot()[0]) + text;
				}
				if (Strings.InStr(text, ".", (CompareMethod)0) == 0)
				{
					text += ".dll";
				}
				return text;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	public static string FullPathEnvironmentVariablesExist(string fileName)
	{
		string text = "";
		IDictionary environmentVariables = Environment.GetEnvironmentVariables();
		IDictionaryEnumerator enumerator = environmentVariables.GetEnumerator();
		DictionaryEntry dictionaryEntry = default(DictionaryEntry);
		while (enumerator.MoveNext())
		{
			object current = enumerator.Current;
			DictionaryEntry dictionaryEntry2 = ((current != null) ? ((DictionaryEntry)current) : dictionaryEntry);
			if (Operators.CompareString(dictionaryEntry2.Key.ToString()!.ToLower(), "path", false) == 0)
			{
				text = Conversions.ToString(dictionaryEntry2.Value);
			}
		}
		string[] array = text.Split(new char[1] { ';' });
		int num = 0;
		string text3;
		while (true)
		{
			if (num < array.Length)
			{
				string text2 = array[num];
				text3 = ((!text2.EndsWith("\\")) ? (text2 + "\\" + fileName) : (text2 + fileName));
				if (FileOrDirIsExist(text3))
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return "";
		}
		return text3;
	}

	private static string GetSystemRoot()
	{
		return Directory.GetParent(Directory.GetParent(Environment.SystemDirectory.ToString())!.ToString())!.ToString();
	}

	private static string ProsPecificPath(string Path)
	{
		if (Operators.CompareString(Path, "", false) != 0)
		{
			Path = Path.ToLower();
			if (Strings.InStr(Path, Environment.SystemDirectory.ToLower() + "\\svchost", (CompareMethod)0) > 0 && Strings.InStr(Path, Environment.SystemDirectory.ToLower() + "\\svchost.exe", (CompareMethod)0) == 0)
			{
				Path = Path.ToLower().Replace(Environment.SystemDirectory.ToLower() + "\\svchost", Environment.SystemDirectory.ToLower() + "\\svchost.exe");
			}
			return Path;
		}
		return "";
	}
}
