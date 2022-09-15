using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class DevCoLicenseProvider : LicenseProvider
{
	private const string string_0 = "dotnetbar";

	public override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
	{
		Class219 @class = null;
		if (context != null)
		{
			@class = new Class219("");
			if (context.UsageMode == LicenseUsageMode.Runtime)
			{
				RemindForm remindForm = new RemindForm();
				remindForm.method_0();
			}
			else
			{
				context.SetSavedLicenseKey(type, @class.LicenseKey);
			}
		}
		if (@class == null && context != null)
		{
			RemindForm remindForm2 = new RemindForm();
			remindForm2.method_0();
			@class = new Class219("");
		}
		return @class;
	}

	private Stream GetManifestResourceStream(Assembly a, string resourceName)
	{
		resourceName = resourceName.ToLower();
		string[] manifestResourceNames = a.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		int num = 0;
		string text;
		while (true)
		{
			if (num < array.Length)
			{
				text = array[num];
				if (text.ToLower() == resourceName)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return a.GetManifestResourceStream(text);
	}

	private string DeserializeLicenseKey(Stream o)
	{
		object obj = null;
		IFormatter formatter = new BinaryFormatter();
		try
		{
			obj = formatter.Deserialize(o);
			if (!(obj is object[]))
			{
				return null;
			}
			object[] array = (object[])obj;
			if (!(array[0] is string))
			{
				return null;
			}
			Hashtable hashtable = (Hashtable)array[1];
			string value = "dotnetbar";
			foreach (DictionaryEntry item in hashtable)
			{
				string text = item.Key.ToString()!.ToLower();
				if (text.IndexOf(value) >= 0)
				{
					return item.Value as string;
				}
			}
		}
		catch
		{
		}
		return null;
	}
}
