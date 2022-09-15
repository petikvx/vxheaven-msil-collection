using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Ribbon;

namespace DevComponents.DotNetBar;

[ToolboxItem(true)]
[DefaultEvent("Executed")]
[DesignTimeVisible(true)]
[ToolboxBitmap(typeof(Command), "Command.ico")]
public class Command : Component, ICommand
{
	private EventHandler eventHandler_0;

	private CancelEventHandler cancelEventHandler_0;

	private string string_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private Image image_0;

	private bool bool_5;

	private Image image_1;

	private bool bool_6;

	private bool bool_7 = true;

	private bool bool_8;

	[Localizable(true)]
	[Description("Indicates Text that is assigned to all command sources that are using this command and have Text property.")]
	public string Text
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			bool_0 = true;
			OnTextChanged();
		}
	}

	[Description("Indicates value for the Checked property that is assigned to the command subscribers using this command and have Checked property.")]
	public bool Checked
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			bool_2 = true;
			OnCheckedChanged();
		}
	}

	[Description("Indicates value for the Visible property that is assigned to the command subscribers using this command and have Visible property.")]
	public bool Visible
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			bool_4 = true;
			OnVisibleChanged();
		}
	}

	[Localizable(true)]
	[Description("Indicates image that is assigned to the command subscribers using this command and have Image property.")]
	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			bool_5 = true;
			OnImageChanged();
		}
	}

	[Description("Indicates small image that is assigned to the command subscribers using this command and have ImageSmall property.")]
	[Localizable(true)]
	public Image ImageSmall
	{
		get
		{
			return image_1;
		}
		set
		{
			image_1 = value;
			bool_6 = true;
			OnImageSmallChanged();
		}
	}

	[Description("Indicates value for Enabled property assigned to the command subscribers using this command and have Enabled property.")]
	public bool Enabled
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
			bool_8 = true;
			OnEnabledChanged();
		}
	}

	public event EventHandler Executed
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

	public event CancelEventHandler PreviewExecuted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Combine(cancelEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			cancelEventHandler_0 = (CancelEventHandler)Delegate.Remove(cancelEventHandler_0, value);
		}
	}

	public virtual void Execute()
	{
		Execute(null);
	}

	public virtual void Execute(ICommandSource commandSource)
	{
		CancelEventArgs cancelEventArgs = new CancelEventArgs();
		OnPreviewExecuted(commandSource, cancelEventArgs);
		if (!cancelEventArgs.Cancel)
		{
			OnExecuted(commandSource, new EventArgs());
		}
	}

	protected virtual void OnExecuted(ICommandSource commandSource, EventArgs e)
	{
		eventHandler_0?.Invoke(commandSource, e);
	}

	protected virtual void OnPreviewExecuted(ICommandSource commandSource, CancelEventArgs e)
	{
		cancelEventHandler_0?.Invoke(commandSource, e);
	}

	protected virtual void OnTextChanged()
	{
		SetTextProperty();
	}

	protected virtual void SetTextProperty()
	{
		ArrayList subscribers = GetSubscribers();
		string text = string_0;
		if (GetDesignMode())
		{
			foreach (object item in subscribers)
			{
				SetPropertyValue(item, "Text", text);
			}
		}
		else
		{
			foreach (object item2 in subscribers)
			{
				SetTextProperty(item2, text);
			}
		}
		RecalcLayout(subscribers);
	}

	protected virtual void SetTextProperty(object item, string text)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (item is ComboBoxItem)
		{
			ComboBoxItem comboBoxItem = item as ComboBoxItem;
			if ((int)comboBoxItem.DropDownStyle == 2)
			{
				if (((Control)comboBoxItem.ComboBoxEx).get_Text() != text)
				{
					if (!(text == "") && text != null)
					{
						comboBoxItem.SelectedIndex = ((ComboBox)comboBoxItem.ComboBoxEx).FindString(text);
					}
					else
					{
						comboBoxItem.SelectedIndex = -1;
					}
				}
			}
			else
			{
				comboBoxItem.Text = text;
			}
		}
		else if (item is BaseItem)
		{
			((BaseItem)item).Text = text;
		}
		else if (item is TabItem)
		{
			((TabItem)item).Text = text;
		}
		else if (item is Control)
		{
			((Control)item).set_Text(text);
		}
		else
		{
			SetPropertyValue(item, "Text", text);
		}
	}

	private void RecalcLayout(ArrayList list)
	{
		if (!CommandManager.AutoUpdateLayout)
		{
			return;
		}
		ArrayList arrayList = new ArrayList(list.Count);
		foreach (object item in list)
		{
			if (item is BaseItem)
			{
				object containerControl = ((BaseItem)item).ContainerControl;
				Control val = (Control)((containerControl is Control) ? containerControl : null);
				if (Class109.smethod_11(val) && !arrayList.Contains(val))
				{
					InvokeRecalcLayout(val);
					arrayList.Add(val);
				}
			}
		}
	}

	private void InvokeRecalcLayout(Control control)
	{
		if (control is Bar)
		{
			((Bar)(object)control).RecalcLayout();
		}
		else if (control is RibbonBar && ((Control)(RibbonBar)(object)control).get_Parent() is RibbonPanel && !((RibbonPanel)(object)((Control)(RibbonBar)(object)control).get_Parent()).DefaultLayout)
		{
			((RibbonBar)(object)control).RecalcLayout();
			((Control)(RibbonPanel)(object)((Control)(RibbonBar)(object)control).get_Parent()).PerformLayout();
		}
		else if (control is ItemControl)
		{
			((ItemControl)(object)control).RecalcLayout();
		}
		else if (control is BaseItemControl)
		{
			((BaseItemControl)(object)control).RecalcLayout();
		}
		else if (control is MenuPanel)
		{
			((MenuPanel)(object)control).RecalcLayout();
		}
		else if (control is ExplorerBar)
		{
			((ExplorerBar)(object)control).RecalcLayout();
		}
		else if (control is SideBar)
		{
			((SideBar)(object)control).RecalcLayout();
		}
	}

	private bool GetDesignMode()
	{
		if (Site != null)
		{
			return Site!.DesignMode;
		}
		return false;
	}

	protected virtual void SetPropertyValue(object item, string propertyName, object value)
	{
		if (CommandManager.UseReflection)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(item);
			properties.Find(propertyName, ignoreCase: false)?.SetValue(item, value);
		}
	}

	public void SetValue(string propertyName, object value)
	{
		ArrayList subscribers = GetSubscribers();
		Type type = null;
		if (value != null)
		{
			type = value.GetType();
		}
		ArrayList arrayList = new ArrayList(subscribers.Count);
		foreach (object item in subscribers)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(item);
			PropertyDescriptor propertyDescriptor = properties.Find(propertyName, ignoreCase: false);
			if (propertyDescriptor != null && ((object)type == null || (object)propertyDescriptor.PropertyType == type))
			{
				propertyDescriptor.SetValue(item, value);
				arrayList.Add(item);
			}
		}
		RecalcLayout(arrayList);
	}

	private ArrayList GetSubscribers()
	{
		return CommandManager.GetSubscribers(this);
	}

	public bool ShouldSerializeText()
	{
		return bool_0;
	}

	public void ResetText()
	{
		bool_0 = false;
		string_0 = null;
	}

	protected virtual void OnCheckedChanged()
	{
		SetCheckedProperty();
	}

	protected virtual void SetCheckedProperty()
	{
		ArrayList subscribers = GetSubscribers();
		bool check = bool_1;
		foreach (object item in subscribers)
		{
			SetCheckedProperty(item, check);
		}
	}

	protected virtual void SetCheckedProperty(object item, bool check)
	{
		if (item is ButtonItem)
		{
			((ButtonItem)item).Checked = check;
		}
		else if (item is ButtonX)
		{
			((ButtonX)item).Checked = check;
		}
		else if (item is CheckBoxItem)
		{
			((CheckBoxItem)item).Checked = check;
		}
		else
		{
			SetPropertyValue(item, "Checked", check);
		}
	}

	public bool ShouldSerializeChecked()
	{
		return bool_2;
	}

	public void ResetChecked()
	{
		bool_2 = false;
		bool_1 = false;
	}

	protected virtual void OnVisibleChanged()
	{
		SetVisibleProperty();
	}

	protected virtual void SetVisibleProperty()
	{
		ArrayList subscribers = GetSubscribers();
		bool visible = bool_3;
		foreach (object item in subscribers)
		{
			SetVisibleProperty(item, visible);
		}
	}

	protected virtual void SetVisibleProperty(object item, bool visible)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		ArrayList subscribers = GetSubscribers();
		if (base.DesignMode)
		{
			SetPropertyValue(item, "Visible", visible);
		}
		else if (item is BaseItem)
		{
			((BaseItem)item).Visible = visible;
		}
		else if (item is Control)
		{
			((Control)item).set_Visible(visible);
		}
		else
		{
			SetPropertyValue(item, "Visible", visible);
		}
		RecalcLayout(subscribers);
	}

	public bool ShouldSerializeVisible()
	{
		return bool_4;
	}

	public void ResetVisible()
	{
		bool_4 = false;
		bool_3 = false;
	}

	protected virtual void OnImageChanged()
	{
		SetImageProperty();
	}

	protected virtual void SetImageProperty()
	{
		ArrayList subscribers = GetSubscribers();
		Image val = image_0;
		if (GetDesignMode())
		{
			foreach (object item in subscribers)
			{
				if (item is ButtonItem)
				{
					ButtonItem buttonItem = item as ButtonItem;
					bool flag = false;
					if (buttonItem.ContainerControl is RibbonStrip)
					{
						RibbonStrip ribbonStrip = buttonItem.ContainerControl as RibbonStrip;
						if (((Control)ribbonStrip).get_Parent() is RibbonControl && ((RibbonControl)(object)((Control)ribbonStrip).get_Parent()).QuickToolbarItems.Contains(buttonItem))
						{
							flag = true;
						}
					}
					else if (buttonItem.ContainerControl is Control7)
					{
						flag = true;
					}
					if (flag && val != null && (val.get_Width() > 16 || val.get_Height() > 16))
					{
						buttonItem.UseSmallImage = true;
						if (buttonItem.ImageSmall == null)
						{
							TypeDescriptor.GetProperties(buttonItem)["ImageFixedSize"]!.SetValue(buttonItem, new Size(16, 16));
						}
					}
				}
				SetPropertyValue(item, "Image", val);
			}
		}
		else
		{
			foreach (object item2 in subscribers)
			{
				SetImageProperty(item2, val);
			}
		}
		RecalcLayout(subscribers);
	}

	protected virtual void SetImageProperty(object item, Image image)
	{
		if (item is ButtonItem)
		{
			((ButtonItem)item).Image = image;
		}
		else if (item is ExplorerBarGroupItem)
		{
			((ExplorerBarGroupItem)item).Image = image;
		}
		else if (item is LabelItem)
		{
			((LabelItem)item).Image = image;
		}
		else if (item is SideBarPanelItem)
		{
			((SideBarPanelItem)item).Image = image;
		}
		else if (item is TabItem)
		{
			((TabItem)item).Image = image;
		}
		else if (item is ButtonX)
		{
			((BubbleButton)item).Image = image;
		}
		else if (item is LabelX)
		{
			((LabelX)item).Image = image;
		}
		else if (item is ReflectionImage)
		{
			((ReflectionImage)item).Image = image;
		}
		else if (item is BubbleButton)
		{
			((BubbleButton)item).Image = image;
		}
		else
		{
			SetPropertyValue(item, "Image", image);
		}
	}

	public bool ShouldSerializeImage()
	{
		return bool_5;
	}

	public void ResetImage()
	{
		bool_5 = false;
		image_0 = null;
	}

	protected virtual void OnImageSmallChanged()
	{
		SetImageSmallProperty();
	}

	protected virtual void SetImageSmallProperty()
	{
		ArrayList subscribers = GetSubscribers();
		Image image = image_1;
		foreach (object item in subscribers)
		{
			SetImageSmallProperty(item, image);
		}
		RecalcLayout(subscribers);
	}

	protected virtual void SetImageSmallProperty(object item, Image image)
	{
		if (item is ButtonItem)
		{
			((ButtonItem)item).ImageSmall = image;
		}
		else
		{
			SetPropertyValue(item, "ImageSmall", image);
		}
	}

	public bool ShouldSerializeImageSmall()
	{
		return bool_6;
	}

	public void ResetImageSmall()
	{
		bool_6 = false;
		image_1 = null;
	}

	protected virtual void OnEnabledChanged()
	{
		SetEnabledProperty();
	}

	protected virtual void SetEnabledProperty()
	{
		ArrayList subscribers = GetSubscribers();
		bool enabled = bool_7;
		foreach (object item in subscribers)
		{
			SetEnabledProperty(item, enabled);
		}
	}

	protected virtual void SetEnabledProperty(object item, bool enabled)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (item is BaseItem)
		{
			((BaseItem)item).Enabled = enabled;
		}
		else if (item is Control)
		{
			((Control)item).set_Enabled(enabled);
		}
		else
		{
			SetPropertyValue(item, "Enabled", enabled);
		}
	}

	public bool ShouldSerializeEnabled()
	{
		return bool_8;
	}

	public void ResetEnabled()
	{
		bool_8 = false;
		bool_7 = false;
	}

	public virtual void CommandSourceRegistered(ICommandSource source)
	{
		if (source != null && !GetDesignMode())
		{
			if (bool_8)
			{
				SetEnabledProperty(source, bool_7);
			}
			if (bool_2)
			{
				SetCheckedProperty(source, bool_1);
			}
			if (bool_5)
			{
				SetImageProperty(source, image_0);
			}
			if (bool_6)
			{
				SetImageSmallProperty(source, image_1);
			}
			if (bool_0)
			{
				SetTextProperty(source, string_0);
			}
		}
	}

	public virtual void CommandSourceUnregistered(ICommandSource source)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			CommandManager.UnRegisterCommand(this);
		}
		base.Dispose(disposing);
	}
}
