using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace KasperKeySharingNetwork;

public class MyMAC
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[AccessedThroughProperty("theProcess")]
	private Process _theProcess;

	private StreamWriter theStreamWriter;

	public string TheText;

	private ProcessStartInfo theProcessStartInfo;

	internal virtual Process theProcess
	{
		[DebuggerNonUserCode]
		get
		{
			return _theProcess;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			DataReceivedEventHandler value2 = theProcessOutputHandler;
			if (_theProcess != null)
			{
				_theProcess.OutputDataReceived -= value2;
			}
			_theProcess = value;
			if (_theProcess != null)
			{
				_theProcess.OutputDataReceived += value2;
			}
		}
	}

	public MyMAC()
	{
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		theProcess = new Process();
		TheText = "";
		theProcessStartInfo = new ProcessStartInfo("cmd.exe");
	}

	public void SendCommand(string TheCommand)
	{
		theStreamWriter.WriteLine(TheCommand);
	}

	private void theProcessOutputHandler(object sender, DataReceivedEventArgs e)
	{
		TheText += e.Data;
	}

	public void Start()
	{
		theProcessStartInfo.CreateNoWindow = true;
		theProcessStartInfo.UseShellExecute = false;
		theProcessStartInfo.RedirectStandardInput = true;
		theProcessStartInfo.RedirectStandardOutput = true;
		theProcess.StartInfo = theProcessStartInfo;
		theProcess.Start();
		theProcess.BeginOutputReadLine();
		theStreamWriter = theProcess.StandardInput;
	}

	public void StopProcess()
	{
		theProcess.CancelOutputRead();
		theProcess.Close();
		theProcess.Dispose();
		theStreamWriter.Flush();
		theStreamWriter.Close();
		theStreamWriter.Dispose();
		TheText = "";
	}
}
