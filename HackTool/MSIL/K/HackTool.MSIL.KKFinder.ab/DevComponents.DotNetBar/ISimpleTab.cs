using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

public interface ISimpleTab
{
	[Description("Indicates the text displayed on the tab.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	string Text { get; set; }

	[Category("Behavior")]
	[DefaultValue(true)]
	[Description("Indicates whether the tab is visible.")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	bool Visible { get; set; }

	[Browsable(false)]
	Rectangle DisplayRectangle { get; }

	[Browsable(true)]
	[Description("Indicates the inactive tab background color.")]
	[Category("Style")]
	Color BackColor { get; set; }

	[Description("Indicates the inactive tab target gradient background color.")]
	[Browsable(true)]
	[Category("Style")]
	Color BackColor2 { get; set; }

	[Description("Indicates the gradient angle.")]
	[Browsable(true)]
	[Category("Style")]
	[DefaultValue(90)]
	int BackColorGradientAngle { get; set; }

	[Category("Style")]
	[Description("Indicates the inactive tab light border color.")]
	[Browsable(true)]
	Color LightBorderColor { get; set; }

	[Browsable(true)]
	[Description("Indicates the inactive tab dark border color.")]
	[Category("Style")]
	Color DarkBorderColor { get; set; }

	[Category("Style")]
	[Description("Indicates the inactive tab border color.")]
	[Browsable(true)]
	Color BorderColor { get; set; }

	[Browsable(true)]
	[Description("Indicates the inactive tab text color.")]
	[Category("Style")]
	Color TextColor { get; set; }

	[Category("Design")]
	[DevCoBrowsable(true)]
	[Description("Indicates the name used to identify item.")]
	[Browsable(true)]
	string Name { get; set; }

	[Browsable(true)]
	[Category("Style")]
	[Description("Applies predefined color to tab.")]
	[DefaultValue(eTabItemColor.Default)]
	eTabItemColor PredefinedColor { get; set; }

	bool IsSelected { get; }

	bool IsMouseOver { get; }

	eTabStripAlignment TabAlignment { get; }

	Font GetTabFont();
}
