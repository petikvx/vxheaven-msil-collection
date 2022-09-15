using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace KasperskyKeyFinder.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	[DebuggerHidden]
	[STAThread]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	private void MyApplication_NetworkAvailabilityChanged(object sender, NetworkAvailableEventArgs e)
	{
		Connection();
	}

	public bool Connection()
	{
		try
		{
			bool isAvailable = ((ServerComputer)MyProject.Computer).get_Network().get_IsAvailable();
			string text = "Network Detected";
			string text2 = "Network Disconnected";
			Color foreColor = Color.Green;
			text = "Network Detected";
			text2 = "Network Disconnected";
			if (!isAvailable)
			{
				text = text2;
				foreColor = Color.Red;
			}
			KasperskyKeyFinder kasperskyKeyFinder = MyProject.Forms.KasperskyKeyFinder;
			kasperskyKeyFinder.DisableEnableDownloadButton();
			((ToolStripItem)kasperskyKeyFinder.tsb_ListKeys).set_Enabled(isAvailable);
			kasperskyKeyFinder.tsm_ShowAvailKeys.set_Enabled(isAvailable);
			((ToolStripItem)kasperskyKeyFinder.ts_Networklabel).set_Text(text);
			((ToolStripItem)kasperskyKeyFinder.ts_Networklabel).set_ForeColor(foreColor);
			kasperskyKeyFinder = null;
			return isAvailable;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((WindowsFormsApplicationBase)this).add_NetworkAvailabilityChanged(new NetworkAvailableEventHandler(MyApplication_NetworkAvailabilityChanged));
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.KasperskyKeyFinder);
	}
}
