using System;
using System.ComponentModel;
using System.Diagnostics;

internal class Class52
{
	public static Version smethod_0(string string_0)
	{
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(string_0);
			if (versionInfo == null)
			{
				return new Version(0, 0, 0, 0);
			}
			return new Version(versionInfo.FileMajorPart, versionInfo.FileMinorPart, versionInfo.FileBuildPart, 0);
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return new Version(0, 0, 0, 0);
		}
	}

	public static Win32Exception smethod_1()
	{
		Win32Exception ex = new Win32Exception(GClass3.smethod_0());
		Class47.smethod_8(ex);
		return ex;
	}

	public static int smethod_2(string string_0, string string_1)
	{
		try
		{
			GClass3.Struct4 struct4_ = default(GClass3.Struct4);
			GClass3.Struct5 struct5_ = default(GClass3.Struct5);
			if (GClass3.CreateProcess(string_0, string_1, IntPtr.Zero, IntPtr.Zero, 0, 0, IntPtr.Zero, IntPtr.Zero, ref struct5_, ref struct4_) == 0)
			{
				return 0;
			}
			return struct4_.int_0;
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			return 0;
		}
	}
}
