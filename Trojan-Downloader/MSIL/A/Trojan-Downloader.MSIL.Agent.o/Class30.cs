using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32;

internal class Class30
{
	public Class23 class23_0;

	protected Random random_0 = new Random();

	protected bool bool_0 = false;

	protected bool bool_1 = false;

	protected AutoResetEvent autoResetEvent_0 = new AutoResetEvent(initialState: false);

	public Class30(Class23 class23_1)
	{
		class23_0 = class23_1;
	}

	public bool method_0()
	{
		try
		{
			Class17 @class = class23_0.method_16();
			class23_0.int_3++;
			if (@class != null)
			{
				Class37.smethod_12();
				Class18 class18_ = @class.class18_0;
				Class28 class2 = @class.method_1();
				Enum1 @enum = Enum1.Error;
				try
				{
					DateTime now = DateTime.Now;
					Class13 class3 = class18_.class11_0.method_7();
					@enum = class3.method_6(null, @class);
					class23_0.class32_0.method_1(new Class33(@class.string_0, now, (class3.class21_0 == null) ? null : class3.class21_0.string_1, class3.enum1_0, 0, class3.method_7(), class3.timeSpan_0, class3.method_19()));
					foreach (Class25 item in class3.arrayList_1)
					{
						item.enum1_0 = @enum;
						class23_0.method_23(item);
					}
					if (@enum == Enum1.Clickthrough)
					{
						@class.int_2++;
						class18_.int_2++;
					}
					if (@enum == Enum1.Error)
					{
						@class.int_1++;
						class18_.int_1++;
					}
					else
					{
						@class.int_0++;
						class18_.int_0++;
					}
					@class.dateTime_0 = now;
					class18_.dateTime_0 = now;
					class2.dateTime_0 = now;
				}
				catch (Exception exception_)
				{
					class23_0.method_12(@class.string_0, class18_.string_0, null, null, -1, exception_);
				}
				finally
				{
					Class37.smethod_14();
				}
				return @enum != Enum1.Error;
			}
			class23_0.int_2++;
			return false;
		}
		catch (Exception exception_2)
		{
			if (class23_0 != null)
			{
				class23_0.method_13(exception_2);
			}
			else
			{
				Class37.smethod_8(exception_2);
			}
			return false;
		}
	}

	public void method_1(int int_0)
	{
		Thread.Sleep(int_0);
	}

	public bool method_2(TimeSpan timeSpan_0)
	{
		try
		{
			bool_0 = true;
			autoResetEvent_0.Set();
			DateTime now = DateTime.Now;
			while (bool_1 && DateTime.Now - now < timeSpan_0)
			{
				Thread.Sleep(250);
			}
			return true;
		}
		catch (Exception exception_)
		{
			if (class23_0 != null)
			{
				class23_0.method_13(exception_);
			}
			else
			{
				Class37.smethod_8(exception_);
			}
			return false;
		}
	}

	protected void method_3(object sender, SessionEndingEventArgs e)
	{
		try
		{
			method_2(TimeSpan.FromSeconds(5.0));
		}
		catch
		{
		}
	}

	protected void method_4(TimeSpan timeSpan_0)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		DateTime now = DateTime.Now;
		try
		{
			if (class23_0.enum2_0 != Enum2.WindowsService)
			{
				SystemEvents.add_SessionEnding(new SessionEndingEventHandler(method_3));
			}
			lock (this)
			{
				bool_1 = true;
			}
			while (!bool_0 && DateTime.Now - now < timeSpan_0)
			{
				if (DateTime.Now - class23_0.dateTime_3 > (class23_0.bool_3 ? class23_0.timeSpan_2 : class23_0.timeSpan_5))
				{
					class23_0.method_9();
					GC.Collect();
				}
				if (class23_0.bool_0)
				{
					if (DateTime.Now - class23_0.dateTime_5 > class23_0.timeSpan_3)
					{
						class23_0.method_8();
					}
					else if (DateTime.Now - class23_0.dateTime_4 > class23_0.timeSpan_4)
					{
						class23_0.method_11();
					}
					method_0();
				}
				if (!bool_0 && !class23_0.bool_1 && !class23_0.bool_4)
				{
					int num = (int)(class23_0.timeSpan_0.TotalMilliseconds * class23_0.method_25());
					num += random_0.Next(-num / 4, num / 4);
					autoResetEvent_0.WaitOne(num, exitContext: false);
					continue;
				}
				break;
			}
		}
		catch (Exception exception_)
		{
			if (class23_0 != null)
			{
				class23_0.method_13(exception_);
			}
			else
			{
				Class37.smethod_8(exception_);
			}
		}
		finally
		{
			class23_0.method_11();
			lock (this)
			{
				bool_1 = false;
			}
		}
		if (class23_0.bool_1)
		{
			Class41.smethod_1(class23_0.enum2_0);
		}
	}

	public void method_5(TimeSpan timeSpan_0)
	{
		Mutex mutex = null;
		try
		{
			mutex = new Mutex(initiallyOwned: false, "_w3cs_core_mutex_");
			if (mutex.WaitOne(0, exitContext: false))
			{
				method_4(timeSpan_0);
			}
		}
		catch (Exception exception_)
		{
			Class37.smethod_8(exception_);
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
	public bool method_6()
	{
		return bool_1;
	}
}
