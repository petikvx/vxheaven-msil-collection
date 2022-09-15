using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace DevComponents.DotNetBar;

[DesignTimeVisible(false)]
[ToolboxItem(false)]
public class MdiWindowListItem : ImageItem
{
	private bool bool_22;

	private ArrayList arrayList_0 = new ArrayList();

	private int int_4 = 22;

	private bool bool_23 = true;

	private bool bool_24 = true;

	private bool bool_25;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DevCoBrowsable(false)]
	[Browsable(false)]
	public override bool Visible
	{
		get
		{
			if (DesignMode)
			{
				return Site != null;
			}
			return false;
		}
		set
		{
		}
	}

	[Description("Specifies whether the MDI Child Window Icons are displayed on items.")]
	[Category("Appearance")]
	[DevCoBrowsable(true)]
	[Browsable(true)]
	public bool ShowWindowIcons
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
		}
	}

	[DevCoBrowsable(true)]
	[DefaultValue(22)]
	[Category("Behavior")]
	[Description("Indicates maximum form caption length that will be displayed on each item. If caption length exceeds given value ... characters are added.")]
	[Browsable(true)]
	public int MaxCaptionLength
	{
		get
		{
			return int_4;
		}
		set
		{
			if (int_4 != value)
			{
				int_4 = value;
				method_21();
			}
		}
	}

	[Browsable(false)]
	public bool IsInitialized => bool_22;

	[Description("Indicates whether flicker associated with switching maximized Mdi child forms is attempted to eliminate.")]
	[DefaultValue(true)]
	[DevCoBrowsable(true)]
	[Category("Mdi Support")]
	[Browsable(true)]
	public bool MdiNoFormActivateFlicker
	{
		get
		{
			return bool_24;
		}
		set
		{
			if (bool_24 != value)
			{
				bool_24 = value;
			}
		}
	}

	[Category("Mdi Support")]
	[Browsable(true)]
	[DevCoBrowsable(true)]
	[DefaultValue(false)]
	[Description("Indicates whether numbered access keys are created for MDI Child window menu items for first 9 items.")]
	public bool CreateMdiChildAccessKeys
	{
		get
		{
			return bool_25;
		}
		set
		{
			if (bool_25 != value)
			{
				bool_25 = value;
				method_21();
			}
		}
	}

	public MdiWindowListItem()
		: this("", "")
	{
	}

	public MdiWindowListItem(string sName)
		: this(sName, "")
	{
	}

	public MdiWindowListItem(string sName, string ItemText)
		: base(sName, ItemText)
	{
		m_SystemItem = true;
		m_Visible = false;
		IsAccessible = false;
	}

	protected override void OnSiteChanged()
	{
		if (Site != null)
		{
			m_SystemItem = false;
			m_Visible = true;
		}
		else
		{
			m_SystemItem = true;
			m_Visible = false;
		}
		base.OnSiteChanged();
	}

	public override BaseItem Copy()
	{
		MdiWindowListItem mdiWindowListItem = new MdiWindowListItem(Name);
		CopyToItem(mdiWindowListItem);
		return mdiWindowListItem;
	}

	protected override void CopyToItem(BaseItem copy)
	{
		base.CopyToItem(copy);
	}

	public override void Dispose()
	{
		if (arrayList_0 != null && arrayList_0.Count > 0)
		{
			foreach (BaseItem item in arrayList_0)
			{
				item.Tag = null;
				if (Parent != null)
				{
					Parent.SubItems.Remove(item);
				}
			}
			arrayList_0.Clear();
		}
		base.Dispose();
	}

	public override void Paint(ItemPaintArgs pa)
	{
		if (DesignMode)
		{
			Graphics graphics = pa.Graphics;
			Class55.smethod_1(graphics, (Name.Length > 0) ? Name : "MdiWindowListItem", pa.Font, pa.Colors.ItemText, m_Rect, eTextFormat.EndEllipsis | eTextFormat.HorizontalCenter | eTextFormat.VerticalCenter);
			if (Focused)
			{
				Rectangle rect = m_Rect;
				rect.Inflate(-1, -1);
				Class32.smethod_0(graphics, rect, pa.Colors.ItemDesignTimeBorder);
			}
			DrawInsertMarker(pa.Graphics);
		}
	}

	public override void RecalcSize()
	{
		if (DesignMode)
		{
			WidthInternal = 64;
			HeightInternal = 24;
		}
		base.RecalcSize();
	}

	protected internal override void OnContainerChanged(object objOldContainer)
	{
		base.OnContainerChanged(objOldContainer);
		if (ContainerControl != null && !bool_22)
		{
			Initialize();
		}
	}

	protected internal override void Deserialize(ItemSerializationContext context)
	{
		base.Deserialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		if (itemXmlElement.HasAttribute("showicons"))
		{
			bool_23 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("showicons"));
		}
		if (itemXmlElement.HasAttribute("mdiaccesskey"))
		{
			bool_25 = XmlConvert.ToBoolean(itemXmlElement.GetAttribute("mdiaccesskey"));
		}
		if (!bool_22)
		{
			Initialize();
		}
	}

	protected internal override void Serialize(ItemSerializationContext context)
	{
		base.Serialize(context);
		XmlElement itemXmlElement = context.ItemXmlElement;
		if (!bool_23)
		{
			itemXmlElement.SetAttribute("showicons", XmlConvert.ToString(bool_23));
		}
		if (bool_25)
		{
			itemXmlElement.SetAttribute("mdiaccesskey", XmlConvert.ToString(bool_25));
		}
	}

	public void Initialize(Form mdiForm)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (GetOwner() is IOwner owner)
		{
			MdiClient mdiClient = owner.GetMdiClient(mdiForm);
			if (mdiClient == null)
			{
				mdiForm.add_Load((EventHandler)method_17);
				return;
			}
			((Control)mdiClient).add_ControlAdded(new ControlEventHandler(MdiFormAdded));
			((Control)mdiClient).add_ControlRemoved(new ControlEventHandler(MdiFormRemoved));
			mdiForm.add_MdiChildActivate((EventHandler)method_19);
			bool_22 = true;
			method_21();
		}
	}

	public void Initialize()
	{
		if (!(GetOwner() is IOwner owner) || (owner.ParentForm == null && (!(owner is RibbonBar) || !((RibbonBar)owner).Boolean_4)) || bool_22)
		{
			return;
		}
		Form val = owner.ParentForm;
		if (val == null)
		{
			if (Form.get_ActiveForm() != null && Form.get_ActiveForm().get_IsMdiChild())
			{
				val = Form.get_ActiveForm();
			}
			if (val == null)
			{
				return;
			}
		}
		Initialize(val);
	}

	private void method_17(object sender, EventArgs e)
	{
		if (GetOwner() is IOwner owner && owner.ParentForm != null)
		{
			owner.ParentForm.remove_Load((EventHandler)method_17);
			if (!bool_22)
			{
				Initialize();
			}
		}
	}

	private void method_18()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (GetOwner() is IOwner owner && owner.ParentForm != null && bool_22)
		{
			MdiClient mdiClient = owner.GetMdiClient(owner.ParentForm);
			if (mdiClient != null)
			{
				((Control)mdiClient).remove_ControlAdded(new ControlEventHandler(MdiFormAdded));
				((Control)mdiClient).remove_ControlRemoved(new ControlEventHandler(MdiFormRemoved));
				owner.ParentForm.remove_MdiChildActivate((EventHandler)method_19);
				bool_22 = false;
			}
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void MdiFormAdded(object sender, ControlEventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (!(GetOwner() is IOwner owner) || (owner.ParentForm == null && (!(owner is RibbonBar) || !((RibbonBar)owner).Boolean_4)) || !bool_22)
		{
			return;
		}
		Form val = owner.ParentForm;
		if (val == null)
		{
			Control parent = ((Control)sender).get_Parent();
			val = (Form)(object)((parent is Form) ? parent : null);
		}
		Control control = e.get_Control();
		Form val2 = (Form)(object)((control is Form) ? control : null);
		if (val2 == null)
		{
			method_21();
			return;
		}
		int position = Parent.SubItems.IndexOf(this) + 1;
		if (arrayList_0.Count > 0)
		{
			position = Parent.SubItems.IndexOf((BaseItem)arrayList_0[arrayList_0.Count - 1]) + 1;
		}
		string itemText = method_22(((Control)val2).get_Text(), arrayList_0.Count + 1);
		ButtonItem buttonItem = new ButtonItem("mdi-" + ((object)val2).GetHashCode(), itemText);
		buttonItem.ShouldSerialize = false;
		buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
		if (arrayList_0.Count == 0 && BeginGroup)
		{
			buttonItem.BeginGroup = true;
		}
		buttonItem.Tag = val2;
		if (val.get_ActiveMdiChild() == val2)
		{
			buttonItem.Checked = true;
		}
		buttonItem.Click += method_20;
		buttonItem.method_11(bool_22: true);
		if (bool_23 && val2.get_Icon() != null && val2.get_ControlBox())
		{
			object obj = val2.get_Icon().Clone();
			buttonItem.Icon = (Icon)((obj is Icon) ? obj : null);
		}
		arrayList_0.Add(buttonItem);
		Parent.SubItems.Add(buttonItem, position);
		buttonItem.Visible = ((Control)val2).get_Visible();
		if (bool_25)
		{
			method_25();
		}
		if (ContainerControl is Bar)
		{
			((Bar)ContainerControl).RecalcLayout();
		}
		else if (ContainerControl is ItemControl)
		{
			((ItemControl)ContainerControl).RecalcLayout();
		}
		((Control)val2).add_TextChanged((EventHandler)method_24);
		((Control)val2).add_VisibleChanged((EventHandler)method_26);
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void MdiFormRemoved(object sender, ControlEventArgs e)
	{
		Control control = e.get_Control();
		Form val = (Form)(object)((control is Form) ? control : null);
		if (val == null)
		{
			method_21();
			return;
		}
		foreach (BaseItem item in arrayList_0)
		{
			if (item.Tag == val)
			{
				Parent.SubItems.Remove(item);
				item.Tag = null;
				arrayList_0.Remove(item);
				if (BeginGroup && arrayList_0.Count > 0)
				{
					((BaseItem)arrayList_0[0]).BeginGroup = true;
				}
				break;
			}
		}
		if (arrayList_0.Count == 0)
		{
			if (ContainerControl is Bar)
			{
				((Bar)ContainerControl).RecalcLayout();
			}
		}
		else if (bool_25)
		{
			method_25();
		}
	}

	private void method_19(object sender, EventArgs e)
	{
		if (!(GetOwner() is IOwner owner) || (owner.ParentForm == null && (!(owner is RibbonBar) || !((RibbonBar)owner).Boolean_4)) || !bool_22)
		{
			return;
		}
		Form val = (Form)((sender is Form) ? sender : null);
		Form activeMdiChild = val.get_ActiveMdiChild();
		foreach (ButtonItem item in arrayList_0)
		{
			if (item.Tag == activeMdiChild)
			{
				item.Checked = true;
			}
			else
			{
				item.Checked = false;
			}
		}
	}

	private void method_20(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Invalid comparison between Unknown and I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Invalid comparison between Unknown and I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		ButtonItem buttonItem = sender as ButtonItem;
		if (buttonItem.Checked)
		{
			return;
		}
		object tag = buttonItem.Tag;
		Form val = (Form)((tag is Form) ? tag : null);
		IOwner owner = GetOwner() as IOwner;
		Form mdiParent = val.get_MdiParent();
		if (owner != null && mdiParent != null && bool_22)
		{
			Form activeMdiChild = owner.ActiveMdiChild;
			MdiClient mdiClient = owner.GetMdiClient(mdiParent);
			bool flag = false;
			if (mdiClient != null && bool_24 && ((int)val.get_WindowState() == 2 || (activeMdiChild != null && (int)activeMdiChild.get_WindowState() == 2)))
			{
				Class92.SendMessage(((Control)mdiClient).get_Handle(), 11, 0, 0);
				flag = true;
			}
			val.Activate();
			if (flag)
			{
				Class92.SendMessage(((Control)mdiClient).get_Handle(), 11, 1, 0);
				((Control)mdiClient).Refresh();
			}
			if (activeMdiChild != null && (int)activeMdiChild.get_WindowState() == 0 && !(ContainerControl is Bar) && Class109.Boolean_0)
			{
				string text = ((Control)activeMdiChild).get_Text();
				((Control)activeMdiChild).set_Text(text + " ");
				((Control)activeMdiChild).set_Text(text);
			}
		}
	}

	private void method_21()
	{
		if (Parent == null || arrayList_0 == null)
		{
			return;
		}
		Parent.SuspendLayout = true;
		if (arrayList_0.Count > 0)
		{
			foreach (BaseItem item in arrayList_0)
			{
				item.Tag = null;
				Parent.SubItems.Remove(item);
			}
			arrayList_0.Clear();
		}
		if (GetOwner() is IOwner owner && (owner.ParentForm != null || (owner is RibbonBar && ((RibbonBar)owner).Boolean_4)) && bool_22)
		{
			Form val = owner.ParentForm;
			if (owner is RibbonBar && ((RibbonBar)owner).Boolean_4 && val == null)
			{
				if (Form.get_ActiveForm() != null && Form.get_ActiveForm().get_IsMdiChild())
				{
					val = Form.get_ActiveForm();
				}
				if (val == null)
				{
					return;
				}
			}
			MdiClient mdiClient = owner.GetMdiClient(val);
			if (mdiClient == null)
			{
				Parent.SuspendLayout = false;
				return;
			}
			int num = Parent.SubItems.IndexOf(this) + 1;
			bool flag = true;
			int num2 = 1;
			Form[] mdiChildren = mdiClient.get_MdiChildren();
			foreach (Form val2 in mdiChildren)
			{
				string itemText = method_22(((Control)val2).get_Text(), num2);
				ButtonItem buttonItem = new ButtonItem("mdi-" + ((Control)val2).get_Handle(), itemText);
				buttonItem.ShouldSerialize = false;
				buttonItem.ButtonStyle = eButtonStyle.ImageAndText;
				if (flag && BeginGroup)
				{
					buttonItem.BeginGroup = true;
				}
				flag = false;
				buttonItem.Tag = val2;
				if (val.get_ActiveMdiChild() == val2)
				{
					buttonItem.Checked = true;
				}
				buttonItem.Click += method_20;
				buttonItem.method_11(bool_22: true);
				if (bool_23 && val2.get_Icon() != null && val2.get_ControlBox())
				{
					object obj = val2.get_Icon().Clone();
					buttonItem.Icon = (Icon)((obj is Icon) ? obj : null);
				}
				arrayList_0.Add(buttonItem);
				Parent.SubItems.Add(buttonItem, num);
				buttonItem.Visible = ((Control)val2).get_Visible();
				num++;
				((Control)val2).add_TextChanged((EventHandler)method_24);
				num2++;
			}
			Parent.SuspendLayout = false;
			if (arrayList_0.Count > 0 && ContainerControl is Bar)
			{
				((Bar)ContainerControl).RecalcLayout();
			}
		}
		else
		{
			Parent.SuspendLayout = false;
		}
	}

	private string method_22(string string_7, int int_5)
	{
		if (string_7.Length > int_4)
		{
			string_7 = string_7.Substring(0, int_4) + "...";
		}
		if (bool_25 && int_5 < 10)
		{
			string_7 = "&" + int_5 + ". " + string_7;
		}
		return string_7;
	}

	public void RefreshButtonIcons()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_23 || arrayList_0 == null)
		{
			return;
		}
		foreach (ButtonItem item in arrayList_0)
		{
			try
			{
				if (item.Tag is Form && ((Form)item.Tag).get_ControlBox())
				{
					object obj = ((Form)item.Tag).get_Icon().Clone();
					item.Icon = (Icon)((obj is Icon) ? obj : null);
				}
			}
			catch
			{
			}
		}
	}

	public override void SetParent(BaseItem o)
	{
		if (Parent != null)
		{
			Parent.ExpandChange -= method_23;
		}
		base.SetParent(o);
		if (Parent != null)
		{
			Parent.ExpandChange += method_23;
		}
	}

	private void method_23(object sender, EventArgs e)
	{
		if (Parent != null && Parent.Expanded)
		{
			RefreshButtonIcons();
		}
	}

	private void method_24(object sender, EventArgs e)
	{
		Form val = (Form)((sender is Form) ? sender : null);
		if (val == null)
		{
			return;
		}
		int num = 0;
		BaseItem baseItem;
		while (true)
		{
			if (num < arrayList_0.Count)
			{
				baseItem = arrayList_0[num] as BaseItem;
				if (baseItem.Tag == val)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		baseItem.Text = method_22(((Control)val).get_Text(), num + 1);
	}

	private void method_25()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < arrayList_0.Count; i++)
		{
			BaseItem baseItem = arrayList_0[i] as BaseItem;
			baseItem.Text = method_22(((Control)(Form)baseItem.Tag).get_Text(), i + 1);
		}
	}

	private void method_26(object sender, EventArgs e)
	{
		Form val = (Form)((sender is Form) ? sender : null);
		if (val == null)
		{
			return;
		}
		if (bool_25)
		{
			method_25();
		}
		foreach (BaseItem item in arrayList_0)
		{
			if (item.Tag != val)
			{
				continue;
			}
			item.Visible = ((Control)val).get_Visible();
			if (BeginGroup)
			{
				bool flag = true;
				foreach (BaseItem item2 in arrayList_0)
				{
					if (flag && item2.Visible)
					{
						item2.BeginGroup = true;
						flag = false;
					}
					else
					{
						item2.BeginGroup = false;
					}
				}
			}
			if (ContainerControl is Bar && item.Visible)
			{
				((Bar)ContainerControl).RecalcLayout();
			}
			break;
		}
	}
}
