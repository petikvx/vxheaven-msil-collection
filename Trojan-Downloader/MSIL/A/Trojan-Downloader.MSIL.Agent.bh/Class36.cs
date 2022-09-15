using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32;

internal class Class36
{
	public const int int_0 = 10;

	public readonly TimeSpan timeSpan_0 = TimeSpan.FromMinutes(15.0);

	public readonly TimeSpan timeSpan_1 = TimeSpan.FromMinutes(1.0);

	public readonly TimeSpan timeSpan_2 = TimeSpan.FromMinutes(30.0);

	public readonly TimeSpan timeSpan_3 = TimeSpan.FromMinutes(1.0);

	public readonly TimeSpan timeSpan_4 = TimeSpan.FromMinutes(20.0);

	public DateTime dateTime_0 = DateTime.MinValue;

	public DateTime dateTime_1 = DateTime.MinValue;

	public Class11 class11_0;

	protected Random random_0 = new Random();

	protected bool bool_0 = false;

	protected bool bool_1 = false;

	protected AutoResetEvent autoResetEvent_0 = new AutoResetEvent(initialState: false);

	public Class36(Class11 class11_1)
	{
		class11_0 = class11_1;
	}

	public bool method_0(Class5 class5_0)
	{
		try
		{
			class11_0.int_2++;
			if (class5_0 != null)
			{
				Class47.smethod_12();
				Class34 @class = class5_0.method_0();
				Class33 class2 = class5_0.method_5();
				Enum3 @enum = Enum3.Error;
				DateTime now = DateTime.Now;
				Class27 class3 = @class.class25_0.method_12();
				if (class3 != null && Class51.smethod_16(class5_0.method_2()))
				{
					try
					{
						dateTime_1 = DateTime.Now;
						@enum = class3.method_8(null, class5_0);
					}
					catch (Exception exception_)
					{
						class11_0.method_19(class5_0.string_0, @class.string_0, null, null, -1, exception_);
					}
					finally
					{
						Class47.smethod_14();
					}
					try
					{
						class11_0.class38_0.method_1(class5_0.string_0, new Class39(now, (class3.class8_0 == null) ? null : class3.class8_0.string_1, class3.enum3_0, 0, class3.method_9(), class3.timeSpan_0, class3.method_23()));
						if (@enum != Enum3.NoConnection)
						{
							foreach (Class13 item in class3.arrayList_1)
							{
								item.enum3_0 = @enum;
								class11_0.method_31(item);
							}
							if (@enum == Enum3.Clickthrough)
							{
								class5_0.int_2++;
								@class.int_2++;
							}
							if (@enum == Enum3.Error)
							{
								class5_0.int_1++;
								@class.int_1++;
							}
							else
							{
								class5_0.int_0++;
								@class.int_0++;
							}
							class5_0.dateTime_0 = now;
							@class.dateTime_0 = now;
							class2.dateTime_0 = now;
						}
						class5_0.bool_1 = true;
						@class.bool_1 = true;
					}
					catch
					{
					}
					return @enum != Enum3.Error && @enum != Enum3.NoConnection;
				}
				class11_0.int_1++;
				return true;
			}
			class11_0.int_1++;
			return false;
		}
		catch (Exception exception_2)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("5E5AAA4C-3284-4ee9-A42F-7DA3A871E81D", exception_2);
			}
			else
			{
				Class47.smethod_8(exception_2);
			}
			return false;
		}
	}

	public bool method_1()
	{
		return method_0(class11_0.method_24());
	}

	public void method_2(int int_1)
	{
		Thread.Sleep(int_1);
	}

	public bool method_3(TimeSpan timeSpan_5)
	{
		try
		{
			bool_0 = true;
			autoResetEvent_0.Set();
			DateTime now = DateTime.Now;
			while (bool_1 && DateTime.Now - now < timeSpan_5)
			{
				Thread.Sleep(250);
			}
			return true;
		}
		catch (Exception exception_)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("ERR00021", exception_);
			}
			else
			{
				Class47.smethod_8(exception_);
			}
			return false;
		}
	}

	protected void method_4(object sender, SessionEndingEventArgs e)
	{
		try
		{
			method_3(TimeSpan.FromSeconds(5.0));
		}
		catch
		{
		}
	}

	protected void method_5()
	{
		if (class11_0.method_34() && DateTime.Now - dateTime_0 > timeSpan_0)
		{
			dateTime_0 = DateTime.Now;
			class11_0.method_38();
			GC.Collect();
		}
		if (class11_0.method_36())
		{
			class11_0.method_18();
		}
		if (class11_0.method_35() && DateTime.Now - dateTime_0 > timeSpan_2)
		{
			dateTime_0 = DateTime.Now;
			class11_0.method_16();
		}
	}

	protected void method_6(TimeSpan timeSpan_5)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		DateTime now = DateTime.Now;
		try
		{
			if (class11_0.enum0_0 != Enum0.WindowsService)
			{
				SystemEvents.add_SessionEnding(new SessionEndingEventHandler(method_4));
			}
			lock (this)
			{
				bool_1 = true;
			}
			int num = 0;
			while (!bool_0 && DateTime.Now - now < timeSpan_5 && num < 10)
			{
				try
				{
					method_5();
					if (!class11_0.bool_5 && !class11_0.bool_2 && class11_0.bool_1 && DateTime.Now - dateTime_1 > timeSpan_1)
					{
						method_1();
					}
					if (bool_0 || class11_0.bool_2 || class11_0.bool_5)
					{
						break;
					}
					int num2 = class11_0.method_37();
					int num3 = num2;
					TimeSpan timeSpan = timeSpan_3;
					if (num3 < (int)timeSpan.TotalMilliseconds)
					{
						timeSpan = timeSpan_3;
						num2 = (int)timeSpan.TotalMilliseconds;
					}
					else
					{
						int num4 = num2;
						timeSpan = timeSpan_4;
						if (num4 > (int)timeSpan.TotalMilliseconds)
						{
							timeSpan = timeSpan_4;
							num2 = (int)timeSpan.TotalMilliseconds;
						}
					}
					autoResetEvent_0.WaitOne(num2, exitContext: false);
					num = 0;
					continue;
				}
				catch (Exception exception_)
				{
					if (class11_0 != null)
					{
						class11_0.method_20("9C187B81-3536-4e57-9DB0-FAC30CF06D47", exception_);
					}
					else
					{
						Class47.smethod_8(exception_);
					}
					num++;
					continue;
				}
			}
		}
		catch (Exception exception_2)
		{
			if (class11_0 != null)
			{
				class11_0.method_20("9C187B81-3536-4e57-9DB0-FAC30CF06D47", exception_2);
			}
			else
			{
				Class47.smethod_8(exception_2);
			}
		}
		finally
		{
			class11_0.method_18();
			lock (this)
			{
				bool_1 = false;
			}
		}
		if (class11_0.bool_2)
		{
			Class1.smethod_2(class11_0);
		}
	}

	public void method_7(TimeSpan timeSpan_5)
	{
		if (!Class0.bool_0)
		{
			Thread.Sleep(Class3.timeSpan_1);
			Class0.smethod_11();
		}
		Mutex mutex = null;
		try
		{
			mutex = new Mutex(initiallyOwned: false, Class3.string_10);
			if (mutex.WaitOne(0, exitContext: false))
			{
				if (class11_0.method_12() && !class11_0.bool_5)
				{
					method_6(timeSpan_5);
				}
				else if (class11_0.bool_2)
				{
					Class1.smethod_1(class11_0.enum0_0);
				}
			}
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
		}
		finally
		{
			try
			{
				mutex?.ReleaseMutex();
			}
			catch
			{
			}
		}
	}

	[SpecialName]
	public bool method_8()
	{
		return bool_1;
	}
}
