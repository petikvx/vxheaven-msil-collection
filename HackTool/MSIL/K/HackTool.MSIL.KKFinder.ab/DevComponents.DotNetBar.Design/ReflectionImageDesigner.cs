using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms.Design;
using DevComponents.DotNetBar.Controls;
using Microsoft.Win32;

namespace DevComponents.DotNetBar.Design;

public class ReflectionImageDesigner : ControlDesigner
{
	public override void InitializeNewComponent(IDictionary defaultValues)
	{
		((ControlDesigner)this).InitializeNewComponent(defaultValues);
		SetDesignTimeDefaults();
	}

	protected virtual void SetDesignTimeDefaults()
	{
		ReflectionImage reflectionImage = ((ControlDesigner)this).get_Control() as ReflectionImage;
		reflectionImage.Image = smethod_0();
		if (reflectionImage.Image != null)
		{
			reflectionImage.BackgroundStyle.TextAlignment = eStyleTextAlignment.Center;
		}
	}

	private static Image smethod_0()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		string text = "ReflectionImage.png";
		try
		{
			RegistryKey registryKey = Registry.LocalMachine;
			string text2 = "";
			try
			{
				if (registryKey != null)
				{
					registryKey = registryKey.OpenSubKey("Software\\DevComponents\\DotNetBar");
				}
				if (registryKey != null)
				{
					text2 = registryKey.GetValue("InstallationFolder", "")!.ToString();
				}
			}
			finally
			{
				registryKey?.Close();
			}
			if (text2 != "")
			{
				if (text2.Substring(text2.Length - 1, 1) != "\\")
				{
					text2 += "\\";
				}
				text2 += "Images\\";
				text2 = ((!File.Exists(text2 + text)) ? "" : (text2 + text));
			}
			if (text2 != "")
			{
				return (Image)new Bitmap(text2);
			}
		}
		catch (Exception)
		{
		}
		return null;
	}
}
