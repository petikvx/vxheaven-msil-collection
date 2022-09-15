namespace DevComponents.Editors.DateTimeAdv;

public interface IDateTimePartInput
{
	int Value { get; set; }

	int MinValue { get; set; }

	int MaxValue { get; set; }

	eDateTimePart Part { get; }

	bool IsEmpty { get; set; }

	void UndoInput();
}
