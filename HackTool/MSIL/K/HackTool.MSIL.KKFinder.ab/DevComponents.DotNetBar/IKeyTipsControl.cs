namespace DevComponents.DotNetBar;

public interface IKeyTipsControl
{
	bool ShowKeyTips { get; set; }

	string KeyTipsKeysStack { get; set; }

	bool ProcessMnemonicEx(char charCode);
}
