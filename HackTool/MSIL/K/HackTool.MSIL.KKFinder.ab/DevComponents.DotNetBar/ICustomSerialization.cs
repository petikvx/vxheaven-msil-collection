namespace DevComponents.DotNetBar;

public interface ICustomSerialization
{
	bool HasSerializeItemHandlers { get; }

	bool HasDeserializeItemHandlers { get; }

	event SerializeItemEventHandler SerializeItem;

	event SerializeItemEventHandler DeserializeItem;

	void InvokeSerializeItem(SerializeItemEventArgs e);

	void InvokeDeserializeItem(SerializeItemEventArgs e);
}
