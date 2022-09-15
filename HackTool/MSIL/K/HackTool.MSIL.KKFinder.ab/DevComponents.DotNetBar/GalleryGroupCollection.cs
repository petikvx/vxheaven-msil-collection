using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace DevComponents.DotNetBar;

public class GalleryGroupCollection : CollectionBase
{
	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private GalleryContainer galleryContainer_0;

	public GalleryGroup this[int index]
	{
		get
		{
			return (GalleryGroup)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public GalleryGroup this[string name]
	{
		get
		{
			foreach (GalleryGroup item in base.List)
			{
				if (item.Name == name)
				{
					return item;
				}
			}
			return null;
		}
	}

	internal GalleryContainer GalleryContainer_0
	{
		get
		{
			return galleryContainer_0;
		}
		set
		{
			galleryContainer_0 = value;
		}
	}

	public event EventHandler GroupRemoved
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

	public event EventHandler GroupAdded
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

	public int Add(GalleryGroup tab)
	{
		return base.List.Add(tab);
	}

	public void AddRange(GalleryGroup[] groups)
	{
		foreach (GalleryGroup value in groups)
		{
			base.List.Add(value);
		}
	}

	public void Insert(int index, GalleryGroup value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(GalleryGroup value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(GalleryGroup value)
	{
		return base.List.Contains(value);
	}

	public void Remove(GalleryGroup value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		GalleryGroup galleryGroup = value as GalleryGroup;
		galleryGroup.SetParentGallery(null);
		if (eventHandler_0 != null)
		{
			eventHandler_0(galleryGroup, new EventArgs());
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		GalleryGroup galleryGroup = value as GalleryGroup;
		if (galleryContainer_0 != null)
		{
			galleryGroup.SetParentGallery(galleryContainer_0);
		}
		if (eventHandler_1 != null)
		{
			eventHandler_1(galleryGroup, new EventArgs());
		}
	}

	public void CopyTo(GalleryGroup[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(GalleryGroup[] galleryGroup_0)
	{
		base.List.CopyTo(galleryGroup_0, 0);
	}

	protected override void OnClear()
	{
		base.OnClear();
	}
}
