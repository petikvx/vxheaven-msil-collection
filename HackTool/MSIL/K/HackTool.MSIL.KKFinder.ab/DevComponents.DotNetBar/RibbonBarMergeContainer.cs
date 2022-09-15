using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using DevComponents.DotNetBar.Design;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[Designer(typeof(RibbonBarMergeContainerDesigner))]
[ComVisible(false)]
[ToolboxBitmap(typeof(RibbonBarMergeContainer), "Ribbon.RibbonControl.ico")]
public class RibbonBarMergeContainer : RibbonPanel
{
	private bool bool_15 = true;

	private string string_3 = "";

	private string string_4 = "";

	private ArrayList arrayList_0 = new ArrayList();

	private bool bool_16;

	private bool bool_17;

	private bool bool_18 = true;

	private string string_5 = "";

	private int int_2 = -1;

	private eRibbonTabColor eRibbonTabColor_0;

	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private EventHandler eventHandler_2;

	private EventHandler eventHandler_3;

	public bool IsMerged => arrayList_0.Count > 0;

	[Description("Indicates whether RibbonTab item the RibbonBar controls are added to when merged is automatically activated (selected) after controls are merged.")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Category("Behaviour")]
	public bool AutoActivateTab
	{
		get
		{
			return bool_15;
		}
		set
		{
			bool_15 = value;
		}
	}

	[Category("Behaviour")]
	[DefaultValue(true)]
	[Browsable(true)]
	[Description("Indicates whether merge functionality is enabled for the container.")]
	public bool AllowMerge
	{
		get
		{
			return bool_18;
		}
		set
		{
			bool_18 = value;
		}
	}

	[DefaultValue("")]
	[Category("Data")]
	[Browsable(true)]
	[Description("Indicates the Ribbon Tab text for the tab that will be created when ribbon bar objects from this container are merged into the ribbon.")]
	[Localizable(true)]
	public string RibbonTabText
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	[Description("Indicates predefined color for the ribbon tab that is created when ribbon bar controls are merged into the ribbon.")]
	[Category("Appearance")]
	[Browsable(true)]
	[DefaultValue(eRibbonTabColor.Default)]
	public eRibbonTabColor RibbonTabColorTable
	{
		get
		{
			return eRibbonTabColor_0;
		}
		set
		{
			eRibbonTabColor_0 = value;
		}
	}

	[Browsable(true)]
	[Description("Indicates the name of RibbonTabItem object that already exists on Ribbon control into which the RibbonBar controls are merged.")]
	[DefaultValue("")]
	[Category("Data")]
	public string MergeIntoRibbonTabItemName
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

	[Description("Indicates the name of the RibbonTabItemGroup the new Ribbon Tab Item that is created will be added to.")]
	[Browsable(true)]
	[Category("Data")]
	[DefaultValue("")]
	public string MergeRibbonGroupName
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

	[DefaultValue(-1)]
	[Category("Data")]
	[Browsable(true)]
	[Description("Indicates the insertion index for the ribbon tab item that is created when ribbon bars are merged into the ribbon control.")]
	public int MergeRibbonTabItemIndex
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
		}
	}

	public event EventHandler BeforeRibbonMerge
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

	public event EventHandler AfterRibbonMerge
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

	public event EventHandler BeforeRibbonUnmerge
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_2 = (EventHandler)Delegate.Combine(eventHandler_2, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_2 = (EventHandler)Delegate.Remove(eventHandler_2, value);
		}
	}

	public event EventHandler AfterRibbonUnmerge
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			eventHandler_3 = (EventHandler)Delegate.Combine(eventHandler_3, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			eventHandler_3 = (EventHandler)Delegate.Remove(eventHandler_3, value);
		}
	}

	public virtual void RemoveMergedRibbonBars(RibbonControl ribbon)
	{
		OnBeforeRibbonUnmerge(new EventArgs());
		Control val = null;
		foreach (RibbonBar item in arrayList_0)
		{
			if (((Control)item).get_Parent() != null)
			{
				if (val == null)
				{
					val = ((Control)item).get_Parent();
					val.SuspendLayout();
				}
				((Control)item).get_Parent().get_Controls().Remove((Control)(object)item);
			}
			((Control)this).get_Controls().Add((Control)(object)item);
			((Control)item).set_Enabled(false);
		}
		if (val != null)
		{
			val.ResumeLayout();
		}
		if (bool_16)
		{
			base.RibbonTabItem.Parent.SubItems.Remove(base.RibbonTabItem);
			bool_16 = false;
		}
		base.RibbonTabItem = null;
		if (base.Visible != bool_17)
		{
			base.Visible = bool_17;
		}
		OnAfterRibbonUnmerge(new EventArgs());
	}

	public virtual void MergeRibbonBars(RibbonControl ribbon)
	{
		OnBeforeRibbonMerge(new EventArgs());
		bool_17 = base.Visible;
		if (base.Visible)
		{
			base.Visible = false;
		}
		RibbonTabItem ribbonTabItem = method_12(ribbon);
		Control[] array = (Control[])(object)new Control[((ArrangedElementCollection)((Control)this).get_Controls()).get_Count()];
		((ArrangedElementCollection)((Control)this).get_Controls()).CopyTo((Array)array, 0);
		int num = ((Control)ribbonTabItem.Panel).get_Width() + 1;
		((Control)ribbonTabItem.Panel).SuspendLayout();
		Control[] array2 = array;
		foreach (Control val in array2)
		{
			if (val is RibbonBar)
			{
				((Control)this).get_Controls().Remove(val);
				if (string_4.Length > 0 && !ribbonTabItem.Panel.DefaultLayout)
				{
					val.set_Left(num);
					num += val.get_Width();
				}
				((Control)ribbonTabItem.Panel).get_Controls().Add(val);
				val.set_Enabled(true);
				arrayList_0.Add(val);
			}
		}
		((Control)ribbonTabItem.Panel).ResumeLayout();
		OnAfterRibbonMerge(new EventArgs());
	}

	private RibbonTabItem method_12(RibbonControl ribbonControl_1)
	{
		if (string_4 != "")
		{
			if (ribbonControl_1.Items.IndexOf(string_4) < 0)
			{
				throw new NullReferenceException("MergeIntoRibbonTabItemName specified (" + string_4 + ") cannot be found in RibbonControl.Items collection");
			}
			base.RibbonTabItem = ribbonControl_1.Items[string_4] as RibbonTabItem;
			return base.RibbonTabItem;
		}
		string name = string_3;
		if (name.Length == 0)
		{
			name = ((Control)this).get_Name();
		}
		string name2 = ((((Control)this).get_Parent() != null) ? (((Control)this).get_Parent().get_Name() + ".") : "") + ((Control)this).get_Name();
		base.RibbonTabItem = ribbonControl_1.CreateRibbonTab(name, name2, int_2);
		base.RibbonTabItem.ColorTable = eRibbonTabColor_0;
		bool_16 = true;
		if (string_5.Length > 0)
		{
			RibbonTabItemGroup ribbonTabItemGroup = ribbonControl_1.TabGroups[string_5];
			if (ribbonTabItemGroup != null)
			{
				int num = -1;
				for (int i = 0; i < ribbonControl_1.Items.Count; i++)
				{
					if (ribbonControl_1.Items[i] is RibbonTabItem && ((RibbonTabItem)ribbonControl_1.Items[i]).Group == ribbonTabItemGroup)
					{
						num = i;
					}
				}
				base.RibbonTabItem.Group = ribbonTabItemGroup;
				if (num >= 0)
				{
					ribbonControl_1.Items.Remove(base.RibbonTabItem);
					ribbonControl_1.Items.Insert(num + 1, base.RibbonTabItem);
				}
			}
		}
		return base.RibbonTabItem;
	}

	protected virtual void OnBeforeRibbonMerge(EventArgs e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
		}
	}

	protected virtual void OnAfterRibbonMerge(EventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
		}
	}

	protected virtual void OnBeforeRibbonUnmerge(EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
		}
	}

	protected virtual void OnAfterRibbonUnmerge(EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
	}
}
