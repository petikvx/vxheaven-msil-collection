using System.Drawing;

namespace DevComponents.DotNetBar.TextMarkup;

public static class MarkupSettings
{
	private static HyperlinkStyle hyperlinkStyle_0 = new HyperlinkStyle(Color.Blue, eHyperlinkUnderlineStyle.SolidLine);

	private static HyperlinkStyle hyperlinkStyle_1 = new HyperlinkStyle();

	private static HyperlinkStyle hyperlinkStyle_2 = new HyperlinkStyle();

	public static HyperlinkStyle NormalHyperlink => hyperlinkStyle_0;

	public static HyperlinkStyle MouseOverHyperlink => hyperlinkStyle_1;

	public static HyperlinkStyle VisitedHyperlink => hyperlinkStyle_2;
}
