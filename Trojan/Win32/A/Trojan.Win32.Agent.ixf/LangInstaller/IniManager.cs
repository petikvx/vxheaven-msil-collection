using System;
using System.Runtime.InteropServices;

namespace LangInstaller;

public class IniManager
{
	private string FileNames;

	public string FileName
	{
		get
		{
			return FileNames;
		}
		set
		{
			FileNames = value;
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault, IntPtr lpReturnedBuffer, int nSize, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	public IniManager(string FileName = "lang_fr.ini")
	{
		FileNames = FileName;
	}

	public string GetValue(string Section, string Key, string DefaultValue)
	{
		IntPtr intPtr = Marshal.StringToHGlobalAnsi(new string('\0', 1024));
		string lpDefault = "";
		int privateProfileStringA = GetPrivateProfileStringA(ref Section, ref Key, ref lpDefault, intPtr, 255, ref FileNames);
		string result = Marshal.PtrToStringAnsi(intPtr, privateProfileStringA);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public bool WriteValue(string Section, string Key, string Value)
	{
		WritePrivateProfileStringA(ref Section, ref Key, ref Value, ref FileNames);
		return true;
	}
}
