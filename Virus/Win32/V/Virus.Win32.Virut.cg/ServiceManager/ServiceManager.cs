using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PCL;

namespace ServiceManager;

public class ServiceManager
{
	private object objWMI;

	private object colItems;

	private object objItem;

	public ServiceManager()
	{
		objWMI = RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:/root/cimv2", (string)null));
	}

	public void GetAllServicesDrivers(ListView ListViewName, ImageList imageListName)
	{
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		ListViewName.set_SmallImageList(imageListName);
		ListViewName.BeginUpdate();
		string[] array = new string[10];
		ListViewName.get_Items().Clear();
		colItems = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objWMI, (Type)null, "ExecQuery", new object[1] { "SELECT * From " + Module2.WMIClassName }, (string[])null, (Type[])null, (bool[])null));
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)colItems).GetEnumerator();
			while (enumerator.MoveNext())
			{
				objItem = RuntimeHelpers.GetObjectValue(enumerator.Current);
				try
				{
					array[0] = NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
					array[1] = NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
					array[2] = NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
					array[3] = NewLateBinding.LateGet(objItem, (Type)null, "PathName", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
					if (Strings.InStr(array[3].ToLower(), "windows\\system32\\msiexec", (CompareMethod)0) > 0 && Strings.InStr(array[3].ToLower(), "windows\\system32\\msiexec.exe", (CompareMethod)0) == 0)
					{
						array[3] = array[3].Replace("msiexec", "msiexec.exe");
					}
					array[7] = Module3.GetTrueFileDir(array[3]);
					if (Operators.CompareString(array[7], "", false) != 0)
					{
						if (Module3.FileOrDirIsExist(array[7]))
						{
							array[4] = "Yes";
						}
						else
						{
							array[4] = "No(Advise removing)";
						}
					}
					else
					{
						array[4] = "No(Advise removing)";
					}
					try
					{
						array[5] = GetFileDate(array[7]);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					array[6] = "";
					array[8] = NewLateBinding.LateGet(objItem, (Type)null, "Description", new object[0], (string[])null, (Type[])null, (bool[])null).ToString();
					array[9] = GetServicesDependedOn(array[0]);
					ListViewItem val = new ListViewItem(array);
					val.set_Tag((object)NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString());
					if (Operators.CompareString(array[4], "No(Advise removing)", false) == 0)
					{
						val.set_ForeColor(Color.Red);
					}
					Icon defaultIcon = MyClsIcon.GetDefaultIcon(array[7], (IconSize)1, "");
					if (defaultIcon != null)
					{
						imageListName.get_Images().Add(defaultIcon);
						val.set_ImageIndex(checked(imageListName.get_Images().get_Count() - 1));
					}
					ListViewName.get_Items().Add(val);
					Application.DoEvents();
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		ListViewName.EndUpdate();
	}

	private string GetServicesDependedOn(string ServiceDisplayName)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		string text = "";
		try
		{
			ServiceController val = new ServiceController(ServiceDisplayName);
			ServiceController[] servicesDependedOn = val.get_ServicesDependedOn();
			if (servicesDependedOn.Length != 0)
			{
				ServiceController[] array = servicesDependedOn;
				foreach (ServiceController val2 in array)
				{
					text = text + val2.get_DisplayName() + ";  ";
				}
				return text;
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return text;
		}
	}

	private string GetFileDate(string FileName)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(FileName);
			return fileInfo.LastWriteTime.Date.ToShortDateString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	public void GetService(ListView ListViewRecommend, ListView listViewCustom)
	{
		bool flag = true;
		bool flag2 = true;
		colItems = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objWMI, (Type)null, "ExecQuery", new object[1] { "SELECT * From Win32_Service" }, (string[])null, (Type[])null, (bool[])null));
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((IEnumerable)colItems).GetEnumerator();
			while (enumerator.MoveNext())
			{
				objItem = RuntimeHelpers.GetObjectValue(enumerator.Current);
				switch (NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower())
				{
				case "remoteregistry":
					addListView(ListViewRecommend, "Disables remote users to modify registry settings on this computer", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "ssdpsrv":
					addListView(ListViewRecommend, "Disables discovery of UPnP devices on your home network", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Manual");
					break;
				case "seclogon":
					addListView(ListViewRecommend, "Disables starting processes under alternate credentials", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "emdmgmt":
					addListView(listViewCustom, "I do not want use movable devices to speedup my system", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "spooler":
					addListView(listViewCustom, "I have no printer and do not use a network printer", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "stisvc":
					addListView(listViewCustom, "I have no scanner and digital camera", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Manual");
					break;
				case "tabletinputservice":
					addListView(listViewCustom, "I have no the pen of Table PC", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "pcasvc":
					addListView(listViewCustom, "There are no the compatibility problems with my programs in Windows Vista", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "sens":
					addListView(listViewCustom, "Disable system tracking of logon, network, etc.", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "uxsms":
					addListView(listViewCustom, "Disable transparent window and 3D shadow effect on desktop for improving performance", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "windefend":
					addListView(listViewCustom, "I do not want use Windows Defender", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "dps":
					addListView(listViewCustom, "Disable System Diagnostic tools and function", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "wscsvc":
					addListView(listViewCustom, "I do not use Security Center", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "wsearch":
					addListView(listViewCustom, "Disable system to index and cache files for searching on my disk", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "policyagent":
					addListView(listViewCustom, "Disable IP security policy managing", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "wersvc":
					addListView(listViewCustom, "Disable to send the error reports to Microsoft", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "iphlpsvc":
					addListView(listViewCustom, "My Network protocol is not the IPv6", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "w32time":
					addListView(listViewCustom, "Disable synchronize date and time to network", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "mpssvc":
					addListView(listViewCustom, "Disable system firewall functions", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "wuauserv":
					addListView(listViewCustom, "Disable automatic Windows Updates at website", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "cscservice":
					addListView(listViewCustom, "I do not want cache the Offline Files on local", NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString(), Conversions.ToString(NewLateBinding.LateGet(objItem, (Type)null, "DisplayName", new object[0], (string[])null, (Type[])null, (bool[])null)), NewLateBinding.LateGet(objItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "Auto");
					break;
				case "lmhosts":
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "auto", false) == 0)
					{
						flag = flag && false;
					}
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "running", false) == 0)
					{
						flag2 = flag2 && false;
					}
					break;
				case "browser":
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "auto", false) == 0)
					{
						flag = flag && false;
					}
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "running", false) == 0)
					{
						flag2 = flag2 && false;
					}
					break;
				case "lanmanserver":
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "auto", false) == 0)
					{
						flag = flag && false;
					}
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "running", false) == 0)
					{
						flag2 = flag2 && false;
					}
					break;
				case "fdrespub":
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "StartMode", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "auto", false) == 0)
					{
						flag = flag && false;
					}
					if (Operators.CompareString(NewLateBinding.LateGet(objItem, (Type)null, "State", new object[0], (string[])null, (Type[])null, (bool[])null).ToString()!.ToLower(), "running", false) == 0)
					{
						flag2 = flag2 && false;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		if (flag)
		{
			if (flag2)
			{
				addListView(listViewCustom, "I am a single user with one internet connection", "Disabled", "Stopped", "TCP/IP NetBIOS Helper,Computer Browser,Server", "lmhosts,browser,lanmanserver", "Auto");
			}
			else
			{
				addListView(listViewCustom, "I am a single user with one internet connection", "Disabled", "Running", "TCP/IP NetBIOS Helper,Computer Browser,Server", "lmhosts,browser,lanmanserver", "Auto");
			}
		}
		else if (flag2)
		{
			addListView(listViewCustom, "I am a single user with one internet connection", "Auto", "Stopped", "TCP/IP NetBIOS Helper,Computer Browser,Server", "lmhosts,browser,lanmanserver", "Auto");
		}
		else
		{
			addListView(listViewCustom, "I am a single user with one internet connection", "Auto", "Running", "TCP/IP NetBIOS Helper,Computer Browser,Server", "lmhosts,browser,lanmanserver", "Auto");
		}
	}

	private void addListView(ListView ListViewName, string Desc, string SartupMode, string Status, string DisplayName, string ServiceName, string DefaultStartupMode)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		try
		{
			string[] array = new string[6] { Desc, SartupMode, Status, DisplayName, null, DefaultStartupMode };
			ListViewItem val = new ListViewItem(array);
			val.set_Tag((object)ServiceName);
			if (Operators.CompareString(SartupMode, "Disabled", false) == 0)
			{
				val.set_Checked(true);
				val.get_SubItems().get_Item(4).set_Text("True");
			}
			else
			{
				val.get_SubItems().get_Item(4).set_Text("False");
			}
			if (Operators.CompareString(array[1], DefaultStartupMode, false) == 0)
			{
				val.set_ForeColor(Color.ForestGreen);
				Application.DoEvents();
			}
			else
			{
				val.set_ForeColor(Color.Firebrick);
				Application.DoEvents();
			}
			ListViewName.get_Items().Add(val);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void SetService(string ServiceName, string strStartupMode)
	{
		try
		{
			if (Operators.CompareString(strStartupMode, "Disabled", false) == 0)
			{
				Module2.ManagerService("Win32_Service", ServiceName, Module2.ServiceMethod.ChangeStartMode, Module2.StartMode.Disabled);
				Module2.ManagerService("Win32_Service", ServiceName, Module2.ServiceMethod.StopService);
			}
			else if (Operators.CompareString(strStartupMode, "Manual", false) == 0)
			{
				Module2.ManagerService("Win32_Service", ServiceName, Module2.ServiceMethod.ChangeStartMode, Module2.StartMode.Manual);
			}
			else
			{
				Module2.ManagerService("Win32_Service", ServiceName, Module2.ServiceMethod.ChangeStartMode, Module2.StartMode.Automatic);
				Module2.ManagerService("Win32_Service", ServiceName, Module2.ServiceMethod.StartService);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
