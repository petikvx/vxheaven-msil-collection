namespace DevComponents.DotNetBar;

internal class Class114
{
	public virtual void Paint(SystemCaptionItemRendererEventArgs e)
	{
		if (e.SystemCaptionItem.IsSystemIcon)
		{
			PaintSystemIcon(e);
		}
		else
		{
			PaintFormButtons(e);
		}
	}

	public virtual void PaintSystemIcon(SystemCaptionItemRendererEventArgs e)
	{
	}

	public virtual void PaintFormButtons(SystemCaptionItemRendererEventArgs e)
	{
	}
}
