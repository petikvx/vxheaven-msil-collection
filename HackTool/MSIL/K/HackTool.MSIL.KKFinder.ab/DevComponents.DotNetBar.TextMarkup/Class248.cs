using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class248 : Class246
{
	protected override void SetFont(Class263 d)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		Font val = d.font_0;
		FontStyle val2 = (FontStyle)(d.font_0.get_Style() | 1);
		if (!val.get_Bold() && val.get_FontFamily().IsStyleAvailable(val2))
		{
			d.font_0 = new Font(d.font_0, val2);
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
