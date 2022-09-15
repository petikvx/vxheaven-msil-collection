using System;
using System.Runtime.InteropServices;

namespace Proxy_Switcher;

public static class WinInetNotification
{
	private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;

	[DllImport("wininet.dll", SetLastError = true)]
	private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int lpdwBufferLength);

	public static void NotifyProxyChange()
	{
		InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0);
	}
}
