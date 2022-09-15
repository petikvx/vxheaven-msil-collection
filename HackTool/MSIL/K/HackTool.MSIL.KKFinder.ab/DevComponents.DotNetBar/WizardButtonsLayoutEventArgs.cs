using System;
using System.Drawing;

namespace DevComponents.DotNetBar;

public class WizardButtonsLayoutEventArgs : EventArgs
{
	public Rectangle BackButtonBounds = Rectangle.Empty;

	public Rectangle NextButtonBounds = Rectangle.Empty;

	public Rectangle FinishButtonBounds = Rectangle.Empty;

	public Rectangle CancelButtonBounds = Rectangle.Empty;

	public Rectangle HelpButtonBounds = Rectangle.Empty;

	public WizardButtonsLayoutEventArgs()
	{
	}

	public WizardButtonsLayoutEventArgs(Rectangle backBounds, Rectangle nextBounds, Rectangle finishBounds, Rectangle cancelBounds, Rectangle helpBounds)
	{
		BackButtonBounds = backBounds;
		NextButtonBounds = nextBounds;
		FinishButtonBounds = finishBounds;
		CancelButtonBounds = cancelBounds;
		HelpButtonBounds = helpBounds;
	}
}
