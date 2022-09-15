using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace DevComponents.Editors;

[TypeConverter(typeof(ExpandableObjectConverter))]
[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class InputControlColors
{
	private EventHandler eventHandler_0;

	private Color color_0 = Color.Empty;

	private Color color_1 = Color.Empty;

	public Color Highlight
	{
		get
		{
			return color_0;
		}
		set
		{
			if (color_0 != value)
			{
				color_0 = value;
				method_0();
			}
		}
	}

	public Color HighlightText
	{
		get
		{
			return color_1;
		}
		set
		{
			if (color_1 != value)
			{
				color_1 = value;
				method_0();
			}
		}
	}

	public event EventHandler ColorChanged
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHighlight()
	{
		Highlight = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeHighlight()
	{
		return !Highlight.IsEmpty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void ResetHighlightText()
	{
		HighlightText = Color.Empty;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeHighlightText()
	{
		return !HighlightText.IsEmpty;
	}

	private void method_0()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
		}
	}
}
