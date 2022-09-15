using System.ComponentModel;
using System.Drawing;

namespace DevComponents.WinForms.Drawing;

internal abstract class Class280
{
	private Class280 class280_0;

	private bool bool_0;

	[DefaultValue(null)]
	public Class280 Class280_0
	{
		get
		{
			return class280_0;
		}
		set
		{
			class280_0 = value;
		}
	}

	[DefaultValue(false)]
	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public abstract void Paint(Graphics g, Rectangle bounds);
}
