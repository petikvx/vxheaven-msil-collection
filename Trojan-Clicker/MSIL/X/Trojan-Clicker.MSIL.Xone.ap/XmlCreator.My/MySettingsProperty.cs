using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XmlCreator.My;

[StandardModule]
[DebuggerNonUserCode]
[CompilerGenerated]
[HideModuleName]
internal sealed class MySettingsProperty
{
	[HelpKeyword("My.Settings")]
	internal static MySettings Settings => MySettings.Default;
}
