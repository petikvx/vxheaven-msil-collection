using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace GoolagScan.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("GoolagScan.Properties.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static Bitmap Cdc009
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("Cdc009", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap cdc2
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("cdc2", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap cdc2d
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("cdc2d", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap eraser
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("eraser", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap greenball
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("greenball", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap greyball
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("greyball", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap gscan_sm
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("gscan-sm", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap gscansplashd
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("gscansplashd", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap loading
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("loading", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static string RES_BLOCKED => ResourceManager.GetString("RES_BLOCKED", resourceCulture);

	internal static string RES_CANCEL => ResourceManager.GetString("RES_CANCEL", resourceCulture);

	internal static string RES_CANCELSCAN => ResourceManager.GetString("RES_CANCELSCAN", resourceCulture);

	internal static string RES_DORKS => ResourceManager.GetString("RES_DORKS", resourceCulture);

	internal static string RES_DORKS_LOADED => ResourceManager.GetString("RES_DORKS_LOADED", resourceCulture);

	internal static string RES_E_ENTERHOST => ResourceManager.GetString("RES_E_ENTERHOST", resourceCulture);

	internal static string RES_E_GENERIC => ResourceManager.GetString("RES_E_GENERIC", resourceCulture);

	internal static string RES_E_OPENFILE => ResourceManager.GetString("RES_E_OPENFILE", resourceCulture);

	internal static string RES_E_SCANERROR => ResourceManager.GetString("RES_E_SCANERROR", resourceCulture);

	internal static string RES_E_SELECTDORK => ResourceManager.GetString("RES_E_SELECTDORK", resourceCulture);

	internal static string RES_E_XMLINCORRECT => ResourceManager.GetString("RES_E_XMLINCORRECT", resourceCulture);

	internal static string RES_FAILED => ResourceManager.GetString("RES_FAILED", resourceCulture);

	internal static string RES_LARGSCAN => ResourceManager.GetString("RES_LARGSCAN", resourceCulture);

	internal static string RES_NORESULT => ResourceManager.GetString("RES_NORESULT", resourceCulture);

	internal static string RES_READY => ResourceManager.GetString("RES_READY", resourceCulture);

	internal static string RES_SCAN => ResourceManager.GetString("RES_SCAN", resourceCulture);

	internal static string RES_SCANNING => ResourceManager.GetString("RES_SCANNING", resourceCulture);

	internal static string RES_SUCCESS => ResourceManager.GetString("RES_SUCCESS", resourceCulture);

	internal static string RES_VERBOSE0 => ResourceManager.GetString("RES_VERBOSE0", resourceCulture);

	internal static string RES_VERBOSE1 => ResourceManager.GetString("RES_VERBOSE1", resourceCulture);

	internal static string RES_W_LARGESCAN => ResourceManager.GetString("RES_W_LARGESCAN", resourceCulture);

	internal static Bitmap throbber
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("throbber", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}
