using System;

namespace DevComponents.DotNetBar;

public class LocalizeEventArgs : EventArgs
{
	public bool Handled;

	public string Key = "";

	public string LocalizedValue = "";
}
