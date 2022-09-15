using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace DevComponents.DotNetBar.Design;

public class NavigationBarDesigner : BarBaseControlDesigner
{
	public override DesignerVerbCollection Verbs
	{
		get
		{
			DesignerVerb[] value = new DesignerVerb[1]
			{
				new DesignerVerb("Create New Button", method_12)
			};
			return new DesignerVerbCollection(value);
		}
	}

	public NavigationBarDesigner()
	{
		EnableItemDragDrop = false;
	}

	private void method_12(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)((ComponentDesigner)this).GetService(typeof(IDesignerHost));
		if (!(((ControlDesigner)this).get_Control() is NavigationBar navigationBar) || designerHost == null)
		{
			return;
		}
		DesignerTransaction designerTransaction = designerHost.CreateTransaction();
		try
		{
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(((ComponentDesigner)this).get_Component(), null);
			ButtonItem buttonItem = null;
			try
			{
				m_CreatingItem = true;
				buttonItem = designerHost.CreateComponent(typeof(ButtonItem)) as ButtonItem;
				buttonItem.Text = buttonItem.Name;
				buttonItem.OptionGroup = "navBar";
				buttonItem.Image = (Image)(object)Class109.smethod_67("SystemImages.DefaultNavBarImage.png");
				navigationBar.Items.Add(buttonItem);
			}
			finally
			{
				m_CreatingItem = false;
			}
			if (navigationBar.Items.Count == 1)
			{
				buttonItem.Checked = true;
			}
			navigationBar.RecalcLayout();
			componentChangeService?.OnComponentChanged(((ComponentDesigner)this).get_Component(), null, null, null);
		}
		catch
		{
			designerTransaction.Cancel();
		}
		finally
		{
			if (!designerTransaction.Canceled)
			{
				designerTransaction.Commit();
			}
		}
	}

	protected override bool OnMouseDown(ref Message m, MouseButtons mb)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		if (base.OnMouseDown(ref m, mb))
		{
			return true;
		}
		if (GetItemContainerControl() is NavigationBar navigationBar && !((Control)navigationBar).get_IsDisposed() && navigationBar.SplitterVisible)
		{
			Point point = ((Control)navigationBar).PointToClient(Control.get_MousePosition());
			MouseEventArgs val = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
			if (((Message)(ref m)).get_Msg() == 513)
			{
				if (navigationBar.method_16(val.get_X(), val.get_Y()))
				{
					navigationBar.method_15(val);
				}
				if (navigationBar.Boolean_0)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	protected override bool OnMouseUp(ref Message m)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		if (GetItemContainerControl() is NavigationBar navigationBar && !((Control)navigationBar).get_IsDisposed() && navigationBar.SplitterVisible)
		{
			Point point = ((Control)navigationBar).PointToClient(Control.get_MousePosition());
			MouseEventArgs mouseEventArgs_ = new MouseEventArgs((MouseButtons)1048576, 0, point.X, point.Y, 0);
			if (navigationBar.Boolean_0)
			{
				navigationBar.method_17(mouseEventArgs_);
				OnNavigationBarHeightChanged(((Control)navigationBar).get_Height());
			}
			else
			{
				navigationBar.method_17(mouseEventArgs_);
			}
		}
		if (base.OnMouseUp(ref m))
		{
			return true;
		}
		return false;
	}

	protected virtual void OnNavigationBarHeightChanged(int newHeight)
	{
	}

	protected override bool OnMouseMove(ref Message m)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		if (base.OnMouseMove(ref m))
		{
			return true;
		}
		if (GetItemContainerControl() is NavigationBar navigationBar && !((Control)navigationBar).get_IsDisposed() && navigationBar.SplitterVisible)
		{
			Point point = ((Control)navigationBar).PointToClient(Control.get_MousePosition());
			MouseEventArgs mouseEventArgs_ = new MouseEventArgs(Control.get_MouseButtons(), 0, point.X, point.Y, 0);
			navigationBar.method_13(mouseEventArgs_);
		}
		return false;
	}

	protected override bool OnMouseLeave(ref Message m)
	{
		if (base.OnMouseLeave(ref m))
		{
			return true;
		}
		if (GetItemContainerControl() is NavigationBar navigationBar && !((Control)navigationBar).get_IsDisposed() && navigationBar.SplitterVisible)
		{
			navigationBar.method_14();
		}
		return false;
	}

	protected override void OnItemSelected(BaseItem item)
	{
		base.OnItemSelected(item);
		if (item is ButtonItem && !((ButtonItem)item).Checked)
		{
			ButtonItem buttonItem = item as ButtonItem;
			IComponentChangeService componentChangeService = ((ComponentDesigner)this).GetService(typeof(IComponentChangeService)) as IComponentChangeService;
			componentChangeService?.OnComponentChanging(buttonItem, TypeDescriptor.GetProperties(buttonItem).Find("Checked", ignoreCase: true));
			buttonItem.Checked = true;
			componentChangeService?.OnComponentChanged(buttonItem, TypeDescriptor.GetProperties(buttonItem).Find("Checked", ignoreCase: true), null, null);
		}
	}
}
