using System;
using System.Drawing;
using DevComponents.UI.ContentManager;

namespace DevComponents.DotNetBar;

public class BubbleButtonLayoutManager : BlockLayoutManager
{
	public override void Layout(IBlock block, Size availableSize)
	{
		BubbleButton bubbleButton = block as BubbleButton;
		BubbleBar bubbleBar = bubbleButton.GetBubbleBar();
		if (bubbleBar == null)
		{
			if (bubbleButton.Site == null || !bubbleButton.Site!.DesignMode)
			{
				throw new InvalidOperationException("BubbleBar object could not be found for button named: '" + bubbleButton.Name + "' in BubbleButtonLayoutManager.Layout");
			}
		}
		else
		{
			Size imageSizeNormal = bubbleBar.ImageSizeNormal;
			bubbleButton.SetDisplayRectangle(new Rectangle(bubbleButton.DisplayRectangle.Location, imageSizeNormal));
		}
	}
}
