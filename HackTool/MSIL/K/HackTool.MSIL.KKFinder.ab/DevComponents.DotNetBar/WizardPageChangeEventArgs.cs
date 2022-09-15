using System;

namespace DevComponents.DotNetBar;

public class WizardPageChangeEventArgs : EventArgs
{
	public WizardPage NewPage;

	public WizardPage OldPage;

	public eWizardPageChangeSource PageChangeSource = eWizardPageChangeSource.NextButton;

	public WizardPageChangeEventArgs(WizardPage newPage, WizardPage oldPage, eWizardPageChangeSource pageChangeSource)
	{
		NewPage = newPage;
		OldPage = oldPage;
		PageChangeSource = pageChangeSource;
	}
}
