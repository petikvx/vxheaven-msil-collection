using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevComponents.DotNetBar;

public class WizardPageCollection : CollectionBase
{
	private Wizard wizard_0;

	internal bool bool_0;

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Wizard Parent => wizard_0;

	internal Wizard Wizard_0
	{
		get
		{
			return wizard_0;
		}
		set
		{
			wizard_0 = value;
		}
	}

	public WizardPage this[int index]
	{
		get
		{
			return (WizardPage)base.List[index];
		}
		set
		{
			base.List[index] = value;
		}
	}

	public WizardPage this[string name]
	{
		get
		{
			foreach (WizardPage item in base.List)
			{
				if (((Control)item).get_Name() == name)
				{
					return item;
				}
			}
			return null;
		}
	}

	public int Add(WizardPage WizardPage)
	{
		return base.List.Add(WizardPage);
	}

	public void AddRange(WizardPage[] WizardPages)
	{
		foreach (WizardPage value in WizardPages)
		{
			base.List.Add(value);
		}
	}

	public void Insert(int index, WizardPage value)
	{
		base.List.Insert(index, value);
	}

	public int IndexOf(WizardPage value)
	{
		return base.List.IndexOf(value);
	}

	public bool Contains(WizardPage value)
	{
		return base.List.Contains(value);
	}

	public void Remove(WizardPage value)
	{
		base.List.Remove(value);
	}

	protected override void OnRemove(int index, object value)
	{
		base.OnRemove(index, value);
	}

	protected override void OnRemoveComplete(int index, object value)
	{
		base.OnRemoveComplete(index, value);
		if (!bool_0 && wizard_0 != null)
		{
			wizard_0.method_7(value as WizardPage);
		}
	}

	protected override void OnInsertComplete(int index, object value)
	{
		base.OnInsertComplete(index, value);
		if (!bool_0 && wizard_0 != null)
		{
			wizard_0.method_6(value as WizardPage);
		}
	}

	public void CopyTo(WizardPage[] array, int index)
	{
		base.List.CopyTo(array, index);
	}

	internal void method_0(WizardPage[] wizardPage_0)
	{
		base.List.CopyTo(wizardPage_0, 0);
	}

	internal void method_1(WizardPageCollection wizardPageCollection_0)
	{
		foreach (WizardPage item in base.List)
		{
			wizardPageCollection_0.Add(item);
		}
	}

	protected override void OnClear()
	{
		if (!bool_0 && wizard_0 != null)
		{
			foreach (WizardPage item in base.List)
			{
				wizard_0.method_7(item);
			}
		}
		base.OnClear();
	}
}
