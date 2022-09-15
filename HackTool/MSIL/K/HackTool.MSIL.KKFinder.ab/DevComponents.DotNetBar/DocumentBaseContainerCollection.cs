using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar;

public class DocumentBaseContainerCollection : CollectionBase
{
	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private DocumentBaseContainer documentBaseContainer_0;

	public DocumentBaseContainer this[int index]
	{
		get
		{
			return (DocumentBaseContainer)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	internal DocumentBaseContainer DocumentBaseContainer_0
	{
		get
		{
			return documentBaseContainer_0;
		}
		set
		{
			documentBaseContainer_0 = value;
		}
	}

	public event EventHandler DocumentRemoved
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_0 = (EventHandler)Delegate.Combine(eventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_0 = (EventHandler)Delegate.Remove(eventHandler_0, value);
		}
	}

	public event EventHandler DocumentAdded
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_1 = (EventHandler)Delegate.Combine(eventHandler_1, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_1 = (EventHandler)Delegate.Remove(eventHandler_1, value);
		}
	}

	public int Add(DocumentBaseContainer tab)
	{
		return base.List.Add(tab);
	}

	public void AddRange(DocumentBaseContainer[] documents)
	{
		foreach (DocumentBaseContainer value in documents)
		{
			base.List.Add(value);
		}
	}

	public void Insert(int index, DocumentBaseContainer value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(DocumentBaseContainer value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(DocumentBaseContainer value)
	{
		return base.List.Contains(value);
	}

	public void Remove(DocumentBaseContainer value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		DocumentBaseContainer documentBaseContainer = value as DocumentBaseContainer;
		documentBaseContainer.method_2(null);
		if (eventHandler_0 != null)
		{
			eventHandler_0(documentBaseContainer, new EventArgs());
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		DocumentBaseContainer documentBaseContainer = value as DocumentBaseContainer;
		if (documentBaseContainer_0 != null)
		{
			documentBaseContainer.method_2(documentBaseContainer_0);
		}
		if (eventHandler_1 != null)
		{
			eventHandler_1(documentBaseContainer, new EventArgs());
		}
	}

	public void CopyTo(DocumentBaseContainer[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(DocumentBaseContainer[] documentBaseContainer_1)
	{
		base.List.CopyTo(documentBaseContainer_1, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
