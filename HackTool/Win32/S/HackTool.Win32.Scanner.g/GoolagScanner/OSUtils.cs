using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using GoolagScanner.Properties;

namespace GoolagScanner;

internal sealed class OSUtils
{
	private OSUtils()
	{
	}

	public static string getApplicationPath()
	{
		Module module = Assembly.GetExecutingAssembly().GetModules()[0];
		int length = module.Name.Length;
		string fullyQualifiedName = module.FullyQualifiedName;
		fullyQualifiedName = fullyQualifiedName.Remove(fullyQualifiedName.Length - length, length);
		string text = fullyQualifiedName;
		char directorySeparatorChar = Path.DirectorySeparatorChar;
		if (!text.EndsWith(directorySeparatorChar.ToString()))
		{
			string text2 = fullyQualifiedName;
			char directorySeparatorChar2 = Path.DirectorySeparatorChar;
			fullyQualifiedName = text2 + directorySeparatorChar2;
		}
		return fullyQualifiedName;
	}

	public static void runProcess(string mycmd, string myarg)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		Process process = new Process();
		process.EnableRaisingEvents = false;
		process.StartInfo.FileName = mycmd;
		process.StartInfo.Arguments = myarg;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
		try
		{
			process.Start();
		}
		catch (Exception)
		{
			MessageBox.Show("Could not start process: " + mycmd);
		}
	}

	public static void runDocument(string Document)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Process process = new Process();
		process.EnableRaisingEvents = false;
		process.StartInfo.FileName = Document;
		process.StartInfo.Arguments = "";
		process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
		process.StartInfo.Verb = "open";
		process.StartInfo.UseShellExecute = true;
		try
		{
			process.Start();
		}
		catch (Exception)
		{
			MessageBox.Show("Could not open process for document: " + Document);
		}
	}

	public static void OpenInBrowser(string DocumentURL)
	{
		if (Settings.Default.UseSystemBrowser)
		{
			runDocument(DocumentURL);
		}
		else
		{
			runProcess(Settings.Default.PreferredBrowser, DocumentURL);
		}
	}
}
