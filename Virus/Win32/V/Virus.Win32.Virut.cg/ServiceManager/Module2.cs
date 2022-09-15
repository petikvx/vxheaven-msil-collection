using System;
using System.Management;
using Microsoft.VisualBasic.CompilerServices;

namespace ServiceManager;

[StandardModule]
internal sealed class Module2
{
	public enum ServiceMethod
	{
		StopService,
		StartService,
		Delete,
		ChangeStartMode
	}

	public enum StartMode
	{
		Boot,
		System,
		Automatic,
		Manual,
		Disabled
	}

	public static string WMIClassName = "Win32_Service";

	public static string ManagerService(string WMIClass, string ServiceName, ServiceMethod ServiceMethod, StartMode StartMode = StartMode.Boot)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		try
		{
			int returnValue = -1;
			string text = "";
			switch (ServiceMethod)
			{
			case ServiceMethod.StopService:
				text = "StopService";
				break;
			case ServiceMethod.StartService:
				text = "StartService";
				break;
			case ServiceMethod.Delete:
				text = "Delete";
				break;
			case ServiceMethod.ChangeStartMode:
				text = "ChangeStartMode";
				break;
			}
			string text2 = "";
			if (StartMode != 0)
			{
				switch (StartMode)
				{
				case StartMode.Boot:
					text2 = "Boot";
					break;
				case StartMode.System:
					text2 = "System";
					break;
				case StartMode.Automatic:
					text2 = "Automatic";
					break;
				case StartMode.Manual:
					text2 = "Manual";
					break;
				case StartMode.Disabled:
					text2 = "Disabled";
					break;
				}
			}
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From " + WMIClass + " Where Name = '" + ServiceName + "'");
			ManagementObjectCollection val2 = val.Get();
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					returnValue = ((Operators.CompareString(text2, "", false) != 0) ? Conversions.ToInteger(val3.InvokeMethod(text, new object[1] { text2 }).ToString()) : Conversions.ToInteger(val3.InvokeMethod(text, (object[])null).ToString()));
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return GetMethodResult(returnValue);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "Unknown Failure";
	}

	private static string GetMethodResult(int returnValue)
	{
		return returnValue switch
		{
			0 => "Success", 
			1 => "Not Supported", 
			2 => "Access Denied", 
			3 => "Dependent Services Running", 
			4 => "Invalid Service Control", 
			5 => "Service Cannot Accept Control", 
			6 => "Service Not Active", 
			7 => "Service Request Timeout", 
			8 => "Unknown Failure", 
			9 => "Path Not Found", 
			10 => "Service Already Running", 
			11 => "Service Database Locked", 
			12 => "Service Dependency Deleted", 
			13 => "Service Dependency Failure", 
			14 => "Service Disabled", 
			15 => "Service Logon Failure", 
			16 => "Service Marked For Deletion", 
			17 => "Service No Thread", 
			18 => "Status Circular Dependency", 
			19 => "Status Duplicate Name", 
			20 => "Status Invalid Name", 
			21 => "Status Invalid Parameter", 
			22 => "Status Invalid Service Account", 
			23 => "Status Service Exists", 
			24 => "Service Already Paused", 
			_ => "Unknown Failure", 
		};
	}

	public static StartMode GetServiceDefaultStartType(string ServiceName)
	{
		switch (ServiceName.ToLower())
		{
		default:
			return StartMode.Boot;
		case "wuauserv":
		case "bits":
		case "browser":
		case "cryptsvc":
		case "dcomlaunch":
		case "dhcp":
		case "trkwks":
		case "dnscache":
		case "ersvc":
		case "eventlog":
		case "helpsvc":
		case "policyagent":
		case "dmserver":
		case "plugplay":
		case "spooler":
		case "protectedstroage":
		case "rpcss":
		case "remoteregistry":
		case "seclogon":
		case "samss":
		case "wscsvc":
		case "lanmanserver":
		case "shellhwdetection":
		case "sens":
		case "srservice":
		case "schedule":
		case "lmhosts":
		case "themes":
		case "webclient":
		case "audiosrv":
		case "sharedaccess":
		case "winmgmt":
		case "w32time":
		case "wzcsvc":
		case "lanmanworkstation":
			return StartMode.Automatic;
		case "alg":
		case "appmgmt":
		case "eventsystem":
		case "comsysapp":
		case "msdtc":
		case "fastuserswitchingcompatibility":
		case "httpfilter":
		case "imapiservice":
		case "cisvc":
		case "dmadmin":
		case "usnjsvc":
		case "swprv":
		case "netlogon":
		case "mnmsrvc":
		case "netman":
		case "nla":
		case "xmlprov":
		case "ntlmssp":
		case "ose":
		case "sysmonlog":
		case "wmdmpmsn":
		case "rsvp":
		case "rasauto":
		case "rasman":
		case "rdsessmgr":
		case "rpclocator":
		case "ntmssvc":
		case "scardsvr":
		case "ssdpsrv":
		case "tapisrv":
		case "termservice":
		case "ups":
		case "upnphost":
		case "vss":
		case "stisvc":
		case "msiserver":
		case "wmi":
		case "wmiapsrv":
			return StartMode.Manual;
		case "alerter":
		case "clipsrv":
		case "hidserv":
		case "messenger":
		case "netdde":
		case "netddedsdm":
		case "remoteaccess":
		case "tlntsvr":
			return StartMode.Disabled;
		}
	}
}
