using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DevComponents.Editors.Primitives;

namespace DevComponents.Editors;

public class VisualStringListInput : VisualListInput
{
	private List<string> list_0 = new List<string>();

	private string string_3 = "";

	private string string_4 = "";

	private string string_5 = "";

	private bool bool_12;

	private EventHandler eventHandler_5;

	public List<string> Items => list_0;

	protected string LastValidatedInputStack
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
		}
	}

	protected string LastMatch
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
		}
	}

	protected bool LastMatchComplete
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
		}
	}

	[DefaultValue("")]
	public string Text
	{
		get
		{
			return GetInputStringValue();
		}
		set
		{
			if (string_3 != value)
			{
				List<string> items = GetItems();
				if (value == "" && !base.AllowEmptyState && items.Count > 0)
				{
					value = items[0];
				}
				else if (value != null && value.Length > 0 && !items.Contains(value))
				{
					value = ((base.AllowEmptyState || items.Count <= 0) ? "" : items[0]);
				}
				string_3 = value;
				ResetInputStack();
				OnInputChanged();
				OnSelectedIndexChanged(new EventArgs());
				InvalidateArrange();
				if (IsEmpty)
				{
					IsEmpty = false;
				}
			}
		}
	}

	[DefaultValue(-1)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public int SelectedIndex
	{
		get
		{
			if (!IsEmpty && !(string_3 == ""))
			{
				List<string> items = GetItems();
				return items.IndexOf(Text);
			}
			return -1;
		}
		set
		{
			if (value >= 0)
			{
				List<string> items = GetItems();
				Text = items[value];
			}
			else
			{
				Text = "";
			}
		}
	}

	public event EventHandler SelectedIndexChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_5 = (EventHandler)Delegate.Combine(eventHandler_5, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_5 = (EventHandler)Delegate.Remove(eventHandler_5, value);
		}
	}

	protected virtual List<string> GetItems()
	{
		return list_0;
	}

	protected override bool ValidateNewInputStack(string s)
	{
		string_4 = "";
		string_5 = "";
		bool_12 = false;
		if (s.Length > 0)
		{
			List<string> items = GetItems();
			Class277 @class = new Class277(s.ToLower(), 2);
			List<string> list = items.FindAll(@class.Predicate_1);
			if (list != null && list.Count != 0)
			{
				string_5 = list[0];
				string_4 = s;
				bool_12 = list.Count == 1;
				return true;
			}
			return false;
		}
		return base.ValidateNewInputStack(s);
	}

	protected override void OnInputStackChanged()
	{
		bool flag = false;
		if (string_4.Length > 0 && base.InputStack == string_4)
		{
			flag = string_3 != string_5;
			string_3 = string_5;
		}
		else if (base.InputStack.Length == 0)
		{
			flag = string_3 != "";
			string_3 = "";
		}
		InvalidateArrange();
		if (flag)
		{
			OnSelectedIndexChanged(new EventArgs());
		}
		base.OnInputStackChanged();
	}

	protected override void OnInputKeyAccepted()
	{
		if (bool_12)
		{
			InputComplete(sendNotification: true);
			bool_12 = false;
		}
		base.OnInputKeyAccepted();
	}

	protected virtual void OnSelectedIndexChanged(EventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
		}
	}

	protected override string GetInputStringValue()
	{
		if (string_3 == null)
		{
			return "";
		}
		return string_3;
	}

	public override void SelectNext()
	{
		int num = SelectedIndex + 1;
		List<string> items = GetItems();
		if (num >= items.Count)
		{
			num = 0;
		}
		SelectedIndex = num;
		base.SelectNext();
	}

	public override void SelectPrevious()
	{
		int num = SelectedIndex - 1;
		if (num < 0)
		{
			List<string> items = GetItems();
			num = items.Count - 1;
		}
		SelectedIndex = num;
		base.SelectPrevious();
	}
}
