using System.Collections;

namespace DevComponents.DotNetBar;

internal class Class49
{
	public eShortcut eShortcut_0;

	public Hashtable hashtable_0;

	public Class49(eShortcut key)
	{
		eShortcut_0 = key;
		hashtable_0 = new Hashtable();
	}

	public override int GetHashCode()
	{
		return (int)eShortcut_0;
	}
}
