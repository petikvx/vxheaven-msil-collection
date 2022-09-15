using System.Drawing;

namespace DevComponents.DotNetBar;

internal class Class112 : Class111
{
	private eButtonStyle eButtonStyle_0;

	private eImagePosition eImagePosition_0;

	private Size size_0 = Size.Empty;

	private string string_0;

	public override void RecordSetting(BaseItem item)
	{
		if (!base.Boolean_0)
		{
			ButtonItem buttonItem = item as ButtonItem;
			eButtonStyle_0 = buttonItem.ButtonStyle;
			eImagePosition_0 = buttonItem.ImagePosition;
			size_0 = buttonItem.ImageFixedSize;
			if (buttonItem.Class261_0 != null && buttonItem.Class261_0.bool_2)
			{
				string_0 = buttonItem.Text;
			}
			base.RecordSetting(item);
		}
	}

	public override void RestoreSettings()
	{
		if (base.Boolean_0)
		{
			ButtonItem buttonItem = baseItem_0 as ButtonItem;
			bool globalItem = buttonItem.GlobalItem;
			buttonItem.GlobalItem = false;
			buttonItem.ButtonStyle = eButtonStyle_0;
			buttonItem.ImagePosition = eImagePosition_0;
			buttonItem.ImageFixedSize = size_0;
			if (string_0 != null)
			{
				buttonItem.Text = string_0;
			}
			buttonItem.GlobalItem = globalItem;
			base.RestoreSettings();
		}
	}
}
