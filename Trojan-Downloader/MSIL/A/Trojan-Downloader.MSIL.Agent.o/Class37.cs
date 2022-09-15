using System;
using System.Collections;
using System.Data;
using System.Threading;

internal class Class37
{
	protected static Hashtable hashtable_0 = new Hashtable();

	public static void smethod_0(string string_0, params object[] object_0)
	{
	}

	public static void smethod_1(string string_0, params object[] object_0)
	{
	}

	public static void smethod_2(Exception exception_0)
	{
	}

	public static void smethod_3(string string_0, params object[] object_0)
	{
	}

	public static void smethod_4(string string_0, params object[] object_0)
	{
	}

	public static void smethod_5(string string_0, params object[] object_0)
	{
	}

	public static void smethod_6(string string_0, params object[] object_0)
	{
	}

	public static void smethod_7(string string_0, params object[] object_0)
	{
	}

	public static void smethod_8(Exception exception_0)
	{
	}

	public static void smethod_9(string string_0, params object[] object_0)
	{
	}

	public static void smethod_10()
	{
		smethod_0(DateTime.Now.ToString("hh:mm:ss.fff"));
	}

	public static void smethod_11(string string_0)
	{
		Stack stack;
		if (hashtable_0.ContainsKey(Thread.CurrentThread))
		{
			stack = hashtable_0[Thread.CurrentThread] as Stack;
		}
		else
		{
			stack = new Stack();
			lock (typeof(Class37))
			{
				hashtable_0.Add(Thread.CurrentThread, stack);
			}
		}
		if (string_0 != null && string_0 != "")
		{
			smethod_0(string_0);
		}
		stack.Push(DateTime.Now);
	}

	public static void smethod_12()
	{
		smethod_11(null);
	}

	public static TimeSpan smethod_13(string string_0)
	{
		if (!hashtable_0.ContainsKey(Thread.CurrentThread))
		{
			throw new InvalidOperationException("This call does not correspond to a BeginTimer call.");
		}
		Stack stack = hashtable_0[Thread.CurrentThread] as Stack;
		TimeSpan result = DateTime.Now - (DateTime)stack.Pop();
		if (stack.Count == 0)
		{
			lock (typeof(Class37))
			{
				hashtable_0.Remove(Thread.CurrentThread);
				return result;
			}
		}
		return result;
	}

	public static TimeSpan smethod_14()
	{
		return smethod_13(null);
	}

	public static void smethod_15(DataSet dataSet_0, params string[] string_0)
	{
	}

	public static void smethod_16(DataTable dataTable_0)
	{
	}

	public static void smethod_17(DataSet dataSet_0, int int_0, params string[] string_0)
	{
	}

	public static void smethod_18(DataSet dataSet_0, params string[] string_0)
	{
	}

	public static void smethod_19(DataTable dataTable_0, params string[] string_0)
	{
	}

	public static void smethod_20(DataTable dataTable_0, int int_0, params string[] string_0)
	{
	}

	public static void smethod_21(IList ilist_0, int int_0, params string[] string_0)
	{
	}
}
