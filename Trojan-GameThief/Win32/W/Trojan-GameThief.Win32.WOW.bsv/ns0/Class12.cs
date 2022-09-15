using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class12 : IDisposable
{
	protected AutoResetEvent autoResetEvent_0;

	protected Queue queue_0;

	protected Thread thread_0 = null;

	protected bool bool_0 = false;

	protected string string_0;

	protected bool bool_1 = false;

	public bool Boolean_0
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	protected bool method_0()
	{
		lock (queue_0.SyncRoot)
		{
			if (queue_0.Count > 0)
			{
				return true;
			}
		}
		return false;
	}

	protected string method_1()
	{
		lock (queue_0.SyncRoot)
		{
			if (queue_0.Count > 0)
			{
				return (string)queue_0.Dequeue();
			}
		}
		return null;
	}

	protected void method_2()
	{
		StreamWriter streamWriter = null;
		while (!bool_0)
		{
			autoResetEvent_0.WaitOne();
			if (bool_0)
			{
				continue;
			}
			try
			{
				streamWriter = new StreamWriter(string_0, append: true, Encoding.ASCII);
				lock (queue_0.SyncRoot)
				{
					while (method_0())
					{
						string text = method_1();
						text = text.Replace("\r", "");
						text = text.Replace("\n", "");
						streamWriter.WriteLine(text);
					}
				}
				streamWriter.Close();
			}
			catch (Exception)
			{
				streamWriter?.Close();
			}
		}
	}

	internal Class12(string string_1)
	{
		string_0 = string_1;
		queue_0 = Queue.Synchronized(new Queue(0));
		autoResetEvent_0 = new AutoResetEvent(initialState: false);
		thread_0 = new Thread(method_2);
		thread_0.Name = "WoW!LogEngine writeThread";
		thread_0.Start();
	}

	~Class12()
	{
		Dispose();
	}

	public void Dispose()
	{
		if (thread_0 != null)
		{
			bool_0 = true;
			autoResetEvent_0.Set();
			thread_0.Join();
			thread_0 = null;
		}
	}

	protected void method_3(string string_1)
	{
		if (bool_1)
		{
			lock (queue_0.SyncRoot)
			{
				queue_0.Enqueue(string_1);
				autoResetEvent_0.Set();
			}
		}
	}

	public void method_4(string string_1)
	{
		try
		{
			method_3(string_1);
		}
		catch
		{
		}
	}

	public void method_5(string string_1, params object[] object_0)
	{
		StringWriter stringWriter = new StringWriter();
		stringWriter.WriteLine(string_1, object_0);
		string string_2 = stringWriter.ToString();
		method_4(string_2);
	}
}
