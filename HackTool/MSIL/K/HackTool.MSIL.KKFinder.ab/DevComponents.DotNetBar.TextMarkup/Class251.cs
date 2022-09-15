using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Xml;

namespace DevComponents.DotNetBar.TextMarkup;

internal class Class251 : Class245
{
	private Size size_0 = Size.Empty;

	private string string_0 = "";

	private Image image_0;

	public override bool IsBlockElement => false;

	public override void Measure(Size availableSize, Class263 d)
	{
		if (!size_0.IsEmpty)
		{
			base.Bounds = new Rectangle(Point.Empty, size_0);
			return;
		}
		if (string_0.Length == 0)
		{
			base.Bounds = Rectangle.Empty;
			return;
		}
		Image val = method_3();
		if (val != null)
		{
			base.Bounds = new Rectangle(Point.Empty, val.get_Size());
		}
		else
		{
			base.Bounds = new Rectangle(Point.Empty, new Size(16, 16));
		}
	}

	private Image method_3()
	{
		if (image_0 != null)
		{
			return image_0;
		}
		Assembly assembly = null;
		if (string_0.IndexOf('/') >= 0)
		{
			string[] array = string_0.Split(new char[1] { '/' });
			assembly = Assembly.Load(array[0]);
			if ((object)assembly != null)
			{
				image_0 = method_4(array[1], assembly);
				if (image_0 == null)
				{
					image_0 = method_5(array[1], assembly);
				}
				if (image_0 != null)
				{
					return image_0;
				}
			}
		}
		assembly = Assembly.GetExecutingAssembly();
		image_0 = method_4(string_0, assembly);
		if (image_0 == null)
		{
			image_0 = method_5(string_0, assembly);
		}
		if (image_0 == null)
		{
			assembly = Assembly.GetEntryAssembly();
			image_0 = method_4(string_0, assembly);
			if (image_0 == null)
			{
				image_0 = method_5(string_0, assembly);
			}
		}
		return image_0;
	}

	private Image method_4(string string_1, Assembly assembly_0)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		Image result = null;
		if (string_1.StartsWith("global::"))
		{
			string text = string_1.Substring(8);
			if (text.Length > 0)
			{
				try
				{
					int num = text.LastIndexOf('.');
					string baseName = text.Substring(0, num);
					text = text.Substring(num + 1);
					ResourceManager resourceManager = new ResourceManager(baseName, assembly_0);
					object @object = resourceManager.GetObject(text);
					return (Image)(Bitmap)@object;
				}
				catch
				{
					return null;
				}
			}
		}
		return result;
	}

	private Image method_5(string string_1, Assembly assembly_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		Image result = null;
		try
		{
			result = (Image)new Bitmap(assembly_0.GetManifestResourceStream(string_1));
			return result;
		}
		catch
		{
			return result;
		}
	}

	public override void Render(Class263 d)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		Rectangle bounds = base.Bounds;
		bounds.Offset(d.point_0);
		if (!d.rectangle_0.IsEmpty && !bounds.IntersectsWith(d.rectangle_0))
		{
			return;
		}
		Image val = method_3();
		if (val != null)
		{
			d.graphics_0.DrawImage(val, bounds);
			return;
		}
		SolidBrush val2 = new SolidBrush(Color.White);
		try
		{
			d.graphics_0.FillRectangle((Brush)(object)val2, bounds);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		Pen val3 = new Pen(Color.DarkGray, 1f);
		try
		{
			d.graphics_0.DrawRectangle(val3, bounds);
			d.graphics_0.DrawLine(val3, bounds.X, bounds.Y, bounds.Right, bounds.Bottom);
			d.graphics_0.DrawLine(val3, bounds.Right, bounds.Y, bounds.X, bounds.Bottom);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	protected override void ArrangeCore(Rectangle finalRect, Class263 d)
	{
	}

	public override void ReadAttributes(XmlTextReader reader)
	{
		size_0 = Size.Empty;
		string_0 = "";
		image_0 = null;
		for (int i = 0; i < reader.AttributeCount; i++)
		{
			reader.MoveToAttribute(i);
			if (reader.Name.ToLower() == "width")
			{
				string value = reader.Value;
				size_0.Width = int.Parse(value);
			}
			else if (reader.Name.ToLower() == "height")
			{
				string value2 = reader.Value;
				size_0.Height = int.Parse(value2);
			}
			else if (reader.Name.ToLower() == "src")
			{
				string_0 = reader.Value;
			}
		}
	}
}
