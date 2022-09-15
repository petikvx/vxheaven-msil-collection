using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Start;

[RunInstaller(true)]
public class CWSInstaller : Installer
{
	private IContainer components;

	[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool InternetSetCookie(string lpszUrlName, string lpszCookieName, string lpszCookieData);

	public CWSInstaller()
	{
		InitializeComponent();
	}

	public override void Commit(IDictionary savedState)
	{
		((Installer)this).Commit(savedState);
		InternetSetCookie("http://coolwallpaper.com", "CWM", "1; expires = Saturday, 01-Jan-2050 00:00:00 GMT");
		InternetSetCookie("http://www.coolwallpaper.com", "CWM", "1; expires = Saturday, 01-Jan-2050 00:00:00 GMT");
		Process.Start(((Installer)this).get_Context().get_Parameters()["INSTALLDIR"] + "cwm_tray.exe");
		Process.Start(((Installer)this).get_Context().get_Parameters()["INSTALLDIR"] + "cwm_next.exe");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Component)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
	}
}
