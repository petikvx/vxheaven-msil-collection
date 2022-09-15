namespace DevComponents.DotNetBar;

public class WizardCancelPageChangeEventArgs : WizardPageChangeEventArgs
{
	public bool Cancel;

	public WizardCancelPageChangeEventArgs(WizardPage newPage, WizardPage oldPage, eWizardPageChangeSource pageChangeSource)
		: base(newPage, oldPage, pageChangeSource)
	{
	}
}
