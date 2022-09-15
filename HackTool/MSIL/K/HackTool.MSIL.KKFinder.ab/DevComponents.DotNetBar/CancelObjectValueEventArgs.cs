using System.ComponentModel;

namespace DevComponents.DotNetBar;

public class CancelObjectValueEventArgs : CancelEventArgs
{
	public object Data;

	public CancelObjectValueEventArgs(object o)
	{
		Data = o;
	}
}
