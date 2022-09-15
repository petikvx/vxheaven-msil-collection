using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DevComponents.DotNetBar;

public class DesignTimeDte
{
	public static string GetProjectPath(IServiceProvider service)
	{
		object dTE = GetDTE(service);
		if (dTE != null)
		{
			if (!(dTE.GetType().InvokeMember("ActiveSolutionProjects", BindingFlags.GetProperty, null, dTE, new object[0]) is Array array))
			{
				return "";
			}
			if (array.Length > 0)
			{
				object value = array.GetValue(0);
				object obj = value.GetType().InvokeMember("Properties", BindingFlags.GetProperty, null, value, new object[0]);
				if (obj != null)
				{
					object obj2 = obj.GetType().InvokeMember("Item", BindingFlags.InvokeMethod, null, obj, new object[1] { "FullPath" });
					if (obj2 != null)
					{
						object obj3 = obj2.GetType().InvokeMember("Value", BindingFlags.GetProperty, null, obj2, new object[0]);
						if (obj3 != null && obj3 is string)
						{
							return obj3.ToString();
						}
					}
				}
			}
		}
		return "";
	}

	public static string GetDefinitionPath(string definitionName, IServiceProvider service)
	{
		object dTE = GetDTE(service);
		if (dTE == null)
		{
			return "";
		}
		object obj = dTE.GetType().InvokeMember("ActiveDocument", BindingFlags.GetProperty, null, dTE, new object[0]);
		if (obj != null)
		{
			string text = (string)obj.GetType().InvokeMember("Path", BindingFlags.GetProperty, null, obj, new object[0]);
			if (!text.EndsWith("\\"))
			{
				text += "\\";
			}
			if (File.Exists(text + definitionName))
			{
				return text;
			}
		}
		object obj2 = dTE.GetType().InvokeMember("Documents", BindingFlags.GetProperty, null, dTE, new object[0]);
		int num = (int)obj2.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, obj2, new object[0]);
		int num2 = 1;
		string text2;
		while (true)
		{
			if (num2 <= num)
			{
				object obj3 = obj2.GetType().InvokeMember("Item", BindingFlags.InvokeMethod, null, obj2, new object[1] { num2 });
				text2 = (string)obj3.GetType().InvokeMember("Path", BindingFlags.GetProperty, null, obj3, new object[0]);
				if (!text2.EndsWith("\\"))
				{
					text2 += "\\";
				}
				if (File.Exists(text2 + definitionName))
				{
					break;
				}
				num2++;
				continue;
			}
			return GetProjectPath(service);
		}
		return text2;
	}

	public static string GetActiveDocumentPath(IServiceProvider service)
	{
		object dTE = GetDTE(service);
		if (dTE == null)
		{
			return "";
		}
		object obj = dTE.GetType().InvokeMember("ActiveDocument", BindingFlags.GetProperty, null, dTE, new object[0]);
		if (obj != null)
		{
			string text = (string)obj.GetType().InvokeMember("Path", BindingFlags.GetProperty, null, obj, new object[0]);
			if (!text.EndsWith("\\"))
			{
				text += "\\";
			}
			return text;
		}
		return GetProjectPath(service);
	}

	public static bool AddFileToProject(string filename, IServiceProvider service)
	{
		bool result = false;
		object dTE = GetDTE(service);
		if (dTE != null)
		{
			object obj = dTE.GetType().InvokeMember("ItemOperations", BindingFlags.GetProperty, null, dTE, new object[0]);
			if (obj != null)
			{
				object obj2 = obj.GetType().InvokeMember("AddExistingItem", BindingFlags.InvokeMethod, null, obj, new object[1] { filename });
				if (obj2 != null)
				{
					try
					{
						object obj3 = obj2.GetType().InvokeMember("Properties", BindingFlags.GetProperty, null, obj2, new object[0]);
						if (obj3 == null)
						{
							return result;
						}
						object obj4 = obj3.GetType().InvokeMember("Item", BindingFlags.InvokeMethod, null, obj3, new object[1] { "BuildAction" });
						if (obj4 != null)
						{
							obj4.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, obj4, new object[1] { 3 });
							return true;
						}
						return result;
					}
					catch
					{
						return true;
					}
				}
			}
		}
		return result;
	}

	public static bool ExistInProject(string filename, IServiceProvider service)
	{
		object dTE = GetDTE(service);
		if (dTE == null)
		{
			return false;
		}
		if (!(dTE.GetType().InvokeMember("ActiveSolutionProjects", BindingFlags.GetProperty, null, dTE, new object[0]) is Array array))
		{
			return false;
		}
		foreach (object item in array)
		{
			object obj = item.GetType().InvokeMember("ProjectItems", BindingFlags.GetProperty, null, item, new object[0]);
			int num = (int)obj.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, obj, new object[0]);
			for (int i = 1; i <= num; i++)
			{
				object object_ = obj.GetType().InvokeMember("Item", BindingFlags.InvokeMethod, null, obj, new object[1] { i });
				if (smethod_0(object_, filename))
				{
					return true;
				}
			}
		}
		return false;
	}

	private static bool smethod_0(object object_0, string string_0)
	{
		try
		{
			string text = (string)object_0.GetType().InvokeMember("Name", BindingFlags.GetProperty, null, object_0, new object[0]);
			if (text.ToLower() == string_0.ToLower())
			{
				return true;
			}
			short num = (short)object_0.GetType().InvokeMember("FileCount", BindingFlags.GetProperty, null, object_0, new object[0]);
			short num2 = 0;
			while (num2 < num)
			{
				string text2 = (string)object_0.GetType().InvokeMember("get_FileNames", BindingFlags.GetProperty, null, object_0, new object[1] { num2 });
				if (!text2.ToLower().EndsWith(string_0.ToLower()))
				{
					num2 = (short)(num2 + 1);
					continue;
				}
				return true;
			}
			object obj = object_0.GetType().InvokeMember("ProjectItems", BindingFlags.GetProperty, null, object_0, new object[0]);
			int num3 = (int)obj.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, obj, new object[0]);
			for (int i = 1; i <= num3; i++)
			{
				object object_ = obj.GetType().InvokeMember("Item", BindingFlags.InvokeMethod, null, obj, new object[1] { i });
				if (smethod_0(object_, string_0))
				{
					return true;
				}
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool ExistInProject2(string filename, IServiceProvider service)
	{
		try
		{
			object dTE = GetDTE(service);
			if (dTE == null)
			{
				return false;
			}
			if (!(dTE.GetType().InvokeMember("ActiveSolutionProjects", BindingFlags.GetProperty, null, dTE, new object[0]) is Array array))
			{
				return false;
			}
			object obj = null;
			if (array.Length > 0)
			{
				obj = array.GetValue(0);
			}
			if (obj == null)
			{
				return false;
			}
			object obj2 = obj.GetType().InvokeMember("ProjectItems", BindingFlags.GetProperty, null, obj, new object[0]);
			if (obj2 == null)
			{
				return false;
			}
			object obj3 = obj2.GetType().InvokeMember("Item", BindingFlags.InvokeMethod, null, obj2, new object[1] { filename });
			if (obj3 == null)
			{
				return false;
			}
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static bool CheckOutFile(string filename, IServiceProvider service)
	{
		try
		{
			object dTE = GetDTE(service);
			if (dTE == null)
			{
				return false;
			}
			object obj = dTE.GetType().InvokeMember("SourceControl", BindingFlags.GetProperty, null, dTE, new object[0]);
			if (obj == null)
			{
				return false;
			}
			object obj2 = obj.GetType().InvokeMember("IsItemUnderSCC", BindingFlags.InvokeMethod, null, obj, new object[1] { filename });
			if (obj2 != null && obj2 is bool && (bool)obj2)
			{
				obj2 = obj.GetType().InvokeMember("CheckOutItem", BindingFlags.InvokeMethod, null, obj, new object[1] { filename });
				if (obj2 != null && obj2 is bool)
				{
					return (bool)obj2;
				}
				return false;
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static object GetDTE(IServiceProvider service)
	{
		object obj = GetMSDEVFromGIT("VisualStudio.DTE", Process.GetCurrentProcess().Id.ToString());
		if (obj == null)
		{
			obj = GetMSDEVFromGIT(".DTE", Process.GetCurrentProcess().Id.ToString());
		}
		if (obj == null && service != null)
		{
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			Assembly[] array = assemblies;
			foreach (Assembly assembly in array)
			{
				if (assembly.FullName!.ToLower().StartsWith("envdte"))
				{
					Type type = assembly.GetType("EnvDTE._DTE", throwOnError: false, ignoreCase: true);
					if ((object)type != null)
					{
						obj = service.GetService(type);
						break;
					}
				}
			}
		}
		return obj;
	}

	[DllImport("ole32.dll")]
	public static extern int GetRunningObjectTable(int reserved, out IRunningObjectTable prot);

	[DllImport("ole32.dll")]
	public static extern int CreateBindCtx(int reserved, out IBindCtx ppbc);

	[STAThread]
	public static object GetMSDEVFromGIT(string strProgID, string processId)
	{
		try
		{
			GetRunningObjectTable(0, out var prot);
			prot.EnumRunning(out var ppenumMoniker);
			ppenumMoniker.Reset();
			IntPtr zero = IntPtr.Zero;
			IMoniker[] array = new IMoniker[1];
			while (ppenumMoniker.Next(1, array, zero) == 0)
			{
				CreateBindCtx(0, out var ppbc);
				array[0].GetDisplayName(ppbc, null, out var ppszDisplayName);
				if (ppszDisplayName.IndexOf(strProgID) > 0 && (ppszDisplayName.IndexOf(":" + processId) > 0 || processId == ""))
				{
					prot.GetObject(array[0], out var ppunkObject);
					return ppunkObject;
				}
			}
		}
		catch
		{
			return null;
		}
		return null;
	}
}
