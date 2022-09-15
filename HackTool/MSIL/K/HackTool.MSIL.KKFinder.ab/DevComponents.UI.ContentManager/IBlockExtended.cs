namespace DevComponents.UI.ContentManager;

public interface IBlockExtended : IBlock
{
	bool IsBlockElement { get; }

	bool IsNewLineAfterElement { get; }

	bool CanStartNewLine { get; }
}
