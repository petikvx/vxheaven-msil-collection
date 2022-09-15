using System;
using System.Resources;

namespace DevComponents.DotNetBar;

internal class Class264 : IDisposable
{
	private ResourceManager resourceManager_0;

	private IOwnerLocalize iownerLocalize_0;

	public Class264(IOwnerLocalize manager)
	{
		iownerLocalize_0 = manager;
	}

	public void Dispose()
	{
		resourceManager_0 = null;
		iownerLocalize_0 = null;
	}

	public string method_0(string string_0)
	{
		string text = method_1(string_0);
		if (text == "" || text == null)
		{
			ResourceManager resourceManager = Class109.smethod_26(bool_3: true);
			text = resourceManager.GetString(string_0);
		}
		if (text == null)
		{
			text = "";
		}
		return text;
	}

	public static string smethod_0(string string_0, string string_1)
	{
		LocalizeEventArgs localizeEventArgs = new LocalizeEventArgs();
		localizeEventArgs.Key = string_0;
		localizeEventArgs.LocalizedValue = string_1;
		LocalizationKeys.smethod_0(localizeEventArgs);
		if (localizeEventArgs.Handled)
		{
			return localizeEventArgs.LocalizedValue;
		}
		return string_1;
	}

	public string method_1(string string_0)
	{
		string text = "";
		if (resourceManager_0 == null)
		{
			resourceManager_0 = Class109.smethod_27();
		}
		if (resourceManager_0 != null)
		{
			text = resourceManager_0.GetString(string_0);
			if (text == null)
			{
				text = "";
			}
		}
		LocalizeEventArgs localizeEventArgs = new LocalizeEventArgs();
		localizeEventArgs.Key = string_0;
		localizeEventArgs.LocalizedValue = text;
		LocalizationKeys.smethod_0(localizeEventArgs);
		if (localizeEventArgs.Handled)
		{
			return localizeEventArgs.LocalizedValue;
		}
		if (iownerLocalize_0 != null)
		{
			iownerLocalize_0.InvokeLocalizeString(localizeEventArgs);
			if (localizeEventArgs.Handled)
			{
				return localizeEventArgs.LocalizedValue;
			}
		}
		return text;
	}
}
