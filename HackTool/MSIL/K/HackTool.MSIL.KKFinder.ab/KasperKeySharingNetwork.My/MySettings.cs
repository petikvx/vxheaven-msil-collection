using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace KasperKeySharingNetwork.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	private static bool addedHandler;

	private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

	public static MySettings Default
	{
		get
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			if (!addedHandler)
			{
				object obj = addedHandlerLockObject;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				Monitor.Enter(obj);
				try
				{
					if (!addedHandler)
					{
						((WindowsFormsApplicationBase)MyProject.Application).add_Shutdown((ShutdownEventHandler)delegate
						{
							if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
							{
								((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
							}
						});
						addedHandler = true;
					}
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			return defaultInstance;
		}
	}

	[SettingsManageability(/*Could not decode attribute arguments.*/)]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string SaveLocation
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("SaveLocation"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("SaveLocation", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[SettingsManageability(/*Could not decode attribute arguments.*/)]
	[UserScopedSetting]
	[DefaultSettingValue("2008-08-01")]
	public DateTime TheDownloadDate
	{
		get
		{
			return Conversions.ToDate(((ApplicationSettingsBase)this).get_Item("TheDownloadDate"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("TheDownloadDate", (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	[SettingsManageability(/*Could not decode attribute arguments.*/)]
	public int TotalDownloads
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this).get_Item("TotalDownloads"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("TotalDownloads", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string DownloadHistory
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("DownloadHistory"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("DownloadHistory", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string Physical
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Physical"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Physical", (object)value);
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerNonUserCode]
	private static void AutoSaveSettings(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)MyProject.Application).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
