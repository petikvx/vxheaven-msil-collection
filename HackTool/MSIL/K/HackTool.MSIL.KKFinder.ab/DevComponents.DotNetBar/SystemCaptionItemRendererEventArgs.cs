using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class SystemCaptionItemRendererEventArgs : EventArgs
{
	public Graphics Graphics;

	public SystemCaptionItem SystemCaptionItem;

	public bool GlassEnabled;

	public SystemCaptionItemRendererEventArgs(Graphics g, SystemCaptionItem item, bool glassEnabled)
	{
		Graphics = g;
		SystemCaptionItem = item;
		GlassEnabled = glassEnabled;
	}
}
