using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GoolagScan.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[DebuggerNonUserCode]
	[DefaultSettingValue("DorkData")]
	[ApplicationScopedSetting]
	public string DataPath => (string)((SettingsBase)this).get_Item("DataPath");

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("www.google.com")]
	public string GoogleSearch
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("GoogleSearch");
		}
		set
		{
			((SettingsBase)this).set_Item("GoogleSearch", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("firefox.exe")]
	[UserScopedSetting]
	public string PreferredBrowser
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("PreferredBrowser");
		}
		set
		{
			((SettingsBase)this).set_Item("PreferredBrowser", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("10")]
	public int WarnScan
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("WarnScan");
		}
		set
		{
			((SettingsBase)this).set_Item("WarnScan", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("gdorks.xml")]
	[UserScopedSetting]
	public string DorkFile
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("DorkFile");
		}
		set
		{
			((SettingsBase)this).set_Item("DorkFile", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("20000")]
	public int ScanTimeOut
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("ScanTimeOut");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanTimeOut", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int ScanVerboseLevel
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("ScanVerboseLevel");
		}
		set
		{
			((SettingsBase)this).set_Item("ScanVerboseLevel", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("True")]
	public bool ShowSummary
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ShowSummary");
		}
		set
		{
			((SettingsBase)this).set_Item("ShowSummary", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("400")]
	public int StealthTime
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("StealthTime");
		}
		set
		{
			((SettingsBase)this).set_Item("StealthTime", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("1")]
	public int RequestPages
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("RequestPages");
		}
		set
		{
			((SettingsBase)this).set_Item("RequestPages", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool AllowFreeScan
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("AllowFreeScan");
		}
		set
		{
			((SettingsBase)this).set_Item("AllowFreeScan", (object)value);
		}
	}

	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public bool ShowSplash
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ShowSplash");
		}
		set
		{
			((SettingsBase)this).set_Item("ShowSplash", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("True")]
	[DebuggerNonUserCode]
	public bool ShowMassScanDialog
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ShowMassScanDialog");
		}
		set
		{
			((SettingsBase)this).set_Item("ShowMassScanDialog", (object)value);
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool UseSystemBrowser
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("UseSystemBrowser");
		}
		set
		{
			((SettingsBase)this).set_Item("UseSystemBrowser", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string ProxyAddress
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ProxyAddress");
		}
		set
		{
			((SettingsBase)this).set_Item("ProxyAddress", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("False")]
	public bool UseSystemProxy
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("UseSystemProxy");
		}
		set
		{
			((SettingsBase)this).set_Item("UseSystemProxy", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("4")]
	[UserScopedSetting]
	public int TraceLevel
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("TraceLevel");
		}
		set
		{
			((SettingsBase)this).set_Item("TraceLevel", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("8")]
	public int MaxParallelScans
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("MaxParallelScans");
		}
		set
		{
			((SettingsBase)this).set_Item("MaxParallelScans", (object)value);
		}
	}

	[DefaultSettingValue("True")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public bool ShowAboutAtStart
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("ShowAboutAtStart");
		}
		set
		{
			((SettingsBase)this).set_Item("ShowAboutAtStart", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.11) Gecko/20071127 Firefox/2.0.0.11")]
	public string UserAgent
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("UserAgent");
		}
		set
		{
			((SettingsBase)this).set_Item("UserAgent", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("1")]
	[DebuggerNonUserCode]
	public int BlockDetectMode
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("BlockDetectMode");
		}
		set
		{
			((SettingsBase)this).set_Item("BlockDetectMode", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	[UserScopedSetting]
	public bool RandomScanOrder
	{
		get
		{
			return (bool)((SettingsBase)this).get_Item("RandomScanOrder");
		}
		set
		{
			((SettingsBase)this).set_Item("RandomScanOrder", (object)value);
		}
	}

	private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
	{
	}

	private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
	{
	}
}
