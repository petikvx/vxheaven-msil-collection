using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
internal sealed class Class5 : ApplicationSettingsBase
{
	private static Class5 class5_0 = (Class5)(object)SettingsBase.Synchronized((SettingsBase)(object)new Class5());

	private static bool bool_0;

	private static object object_0 = RuntimeHelpers.GetObjectValue(new object());

	[DebuggerNonUserCode]
	public Class5()
	{
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	private static void smethod_0(object sender, EventArgs e)
	{
		if (((WindowsFormsApplicationBase)Class1.smethod_1()).get_SaveMySettingsOnExit())
		{
			((ApplicationSettingsBase)Class6.smethod_0()).Save();
		}
	}

	[SpecialName]
	public static Class5 smethod_1()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (!bool_0)
		{
			object obj = object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			Monitor.Enter(obj);
			try
			{
				if (!bool_0)
				{
					((WindowsFormsApplicationBase)Class1.smethod_1()).add_Shutdown((ShutdownEventHandler)delegate
					{
						if (((WindowsFormsApplicationBase)Class1.smethod_1()).get_SaveMySettingsOnExit())
						{
							((ApplicationSettingsBase)Class6.smethod_0()).Save();
						}
					});
					bool_0 = true;
				}
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}
		return class5_0;
	}
}
