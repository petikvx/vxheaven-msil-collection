namespace DevComponents.Editors;

public class CollectionChangedInfo
{
	private VisualItem[] visualItem_0;

	private VisualItem[] visualItem_1;

	private eCollectionChangeType eCollectionChangeType_0;

	public VisualItem[] Added => visualItem_0;

	public VisualItem[] Removed => visualItem_1;

	public eCollectionChangeType ChangeType => eCollectionChangeType_0;

	public CollectionChangedInfo(VisualItem[] added, VisualItem[] removed, eCollectionChangeType changeType)
	{
		visualItem_0 = added;
		visualItem_1 = removed;
		eCollectionChangeType_0 = changeType;
	}
}
