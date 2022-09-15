#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using GoolagScanner.Debug;

namespace GoolagScanner;

internal class ScanMonitor : IDisposable
{
	private class ActiveScan
	{
		private Scanner scanner;

		private Thread thread;

		public Scanner Scanner
		{
			get
			{
				return scanner;
			}
			set
			{
				scanner = value;
			}
		}

		public Thread Thread
		{
			get
			{
				return thread;
			}
			set
			{
				thread = value;
			}
		}
	}

	private int MaxThreads;

	private Queue<Scanner> FinishedScans = new Queue<Scanner>();

	private object FinishedScansLock = new object();

	private List<ActiveScan> ScansTodo = new List<ActiveScan>();

	private object ScansTodoLock = new object();

	private Thread WatcherThread;

	public ScanMonitor(int MaxParallelScans)
	{
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceInfo, MaxParallelScans, "Monitor initialised. Threads to use");
		MaxThreads = MaxParallelScans;
		WatcherThread = new Thread(Watcher);
		WatcherThread.Start();
		System.Diagnostics.Trace.WriteLineIf(GoolagScanner.Debug.Trace.TraceGoolag.TraceVerbose, "Monitor: Watcher started.");
	}

	public void Add(Scanner scanner)
	{
		ActiveScan activeScan = new ActiveScan();
		activeScan.Scanner = scanner;
		activeScan.Thread = new Thread(scanner.Do);
		lock (ScansTodoLock)
		{
			ScansTodo.Add(activeScan);
		}
		activeScan.Thread.Start();
	}

	public bool IsThreadAvail()
	{
		lock (ScansTodoLock)
		{
			return ScansTodo.Count < MaxThreads;
		}
	}

	public bool HasResults()
	{
		lock (FinishedScansLock)
		{
			return FinishedScans.Count > 0;
		}
	}

	public bool HasPendingScans()
	{
		lock (ScansTodoLock)
		{
			return ScansTodo.Count > 0;
		}
	}

	public Scanner GetFinishedScanner()
	{
		Scanner scanner = null;
		lock (FinishedScansLock)
		{
			return FinishedScans.Dequeue();
		}
	}

	public void Watcher()
	{
		while (true)
		{
			lock (ScansTodoLock)
			{
				for (int i = 0; i < ScansTodo.Count; i++)
				{
					ActiveScan activeScan = ScansTodo[i];
					if (activeScan.Scanner.ScanStatus == 2 || activeScan.Scanner.ScanStatus == 3)
					{
						lock (FinishedScansLock)
						{
							FinishedScans.Enqueue(activeScan.Scanner);
						}
						ScansTodo.RemoveAt(i);
						break;
					}
				}
			}
			Thread.Sleep(500);
		}
	}

	public void Dispose()
	{
		lock (ScansTodoLock)
		{
			foreach (ActiveScan item in ScansTodo)
			{
				item.Scanner.Abort();
				item.Thread.Abort();
			}
		}
		WatcherThread.Abort();
	}

	public int StopAllActive()
	{
		int num = 0;
		lock (ScansTodoLock)
		{
			foreach (ActiveScan item in ScansTodo)
			{
				if (item.Scanner.ScanStatus != 3)
				{
					item.Scanner.Abort();
					item.Thread.Abort();
					item.Scanner.ScanStatus = 3;
					num++;
				}
			}
			return num;
		}
	}
}
