using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class249 : Class246
{
	protected override void SetFont(Class263 d)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Font val = d.font_0;
		FontStyle val2 = (FontStyle)(val.get_Style() | 2);
		if (!val.get_Italic() && d.font_0.get_FontFamily().IsStyleAvailable(val2))
		{
			d.font_0 = new Font(val, val2);
		}
		else
		{
			val = null;
		}
		if (val != null)
		{
			font_0 = val;
		}
		base.SetFont(d);
	}
}
