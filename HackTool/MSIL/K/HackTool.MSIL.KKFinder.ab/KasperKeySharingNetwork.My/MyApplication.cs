using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace KasperKeySharingNetwork.My;

[GeneratedCode("MyTemplate", "8.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DebuggerHidden]
	[STAThread]
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
			cls_KasperKeySharingNetwork cls_KasperKeySharingNetwork = MyProject.Forms.cls_KasperKeySharingNetwork;
			IamNOTaFuckingVir_us();
			Buttons(isAvailable);
			cls_KasperKeySharingNetwork.tsm_ShowAvailKeys.set_Enabled(isAvailable);
			((ToolStripItem)cls_KasperKeySharingNetwork.ts_Networklabel).set_Text(text);
			((ToolStripItem)cls_KasperKeySharingNetwork.ts_Networklabel).set_ForeColor(foreColor);
			cls_KasperKeySharingNetwork = null;
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

	private void Buttons(bool status)
	{
		((ToolStripItem)MyProject.Forms.cls_KasperKeySharingNetwork.tsb_ListKeys).set_Enabled(status);
	}

	public void IamNOTaFuckingVir_us()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		cls_KasperKeySharingNetwork cls_KasperKeySharingNetwork = MyProject.Forms.cls_KasperKeySharingNetwork;
		bool flag = false;
		checked
		{
			int num = cls_KasperKeySharingNetwork.dgv_TheList.get_RowCount() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				DataGridViewCheckBoxCell val = (DataGridViewCheckBoxCell)cls_KasperKeySharingNetwork.dgv_TheList.get_Item("Select", num2);
				if (Conversions.ToBoolean(((DataGridViewCell)val).get_EditedFormattedValue()))
				{
					flag = true;
				}
				num2++;
			}
			if (flag)
			{
				((ToolStripItem)cls_KasperKeySharingNetwork.tsb_DownloadKey).set_Enabled(true);
				cls_KasperKeySharingNetwork.tsm_DownloadSelectedKeys.set_Enabled(true);
			}
			else
			{
				((ToolStripItem)cls_KasperKeySharingNetwork.tsb_DownloadKey).set_Enabled(false);
				cls_KasperKeySharingNetwork.tsm_DownloadSelectedKeys.set_Enabled(false);
			}
			((Control)cls_KasperKeySharingNetwork.ToolStrip1).Refresh();
			cls_KasperKeySharingNetwork = null;
		}
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((WindowsFormsApplicationBase)this).add_NetworkAvailabilityChanged(new NetworkAvailableEventHandler(MyApplication_NetworkAvailabilityChanged));
		lock (__ENCList)
		{
			__ENCList.Add(new WeakReference(this));
		}
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(true);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.cls_KasperKeySharingNetwork);
	}
}
