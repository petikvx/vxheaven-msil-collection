using System;
using System.IO;
using System.Reflection;
using ITWX;

internal class Class4
{
	public static AppDomain appDomain_0 = AppDomain.CreateDomain("Runner");

	public static Assembly assembly_0 = null;

	protected static void smethod_0(Exception exception_0)
	{
		Class47.smethod_8(exception_0);
	}

	protected static void smethod_1(string string_0, params object[] object_0)
	{
		Class47.smethod_1(string_0, object_0);
	}

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			assembly_0 = Assembly.GetAssembly(typeof(Class4));
			string assemblyFile = smethod_3();
			object obj = appDomain_0.CreateInstanceFromAndUnwrap(assemblyFile, "ITWX.DuperRunner");
			MethodInfo method = obj.GetType().GetMethod("MainEntry");
			if ((object)method == null)
			{
				throw new Exception("Could not find the service entry point.");
			}
			method.Invoke(obj, new object[1] { args });
		}
		catch (Exception exception_)
		{
			Class47.smethod_8(exception_);
			try
			{
				DuperRunner duperRunner = new DuperRunner();
				duperRunner.MainEntry(args);
			}
			catch (Exception exception_2)
			{
				Class47.smethod_8(exception_2);
			}
		}
	}

	protected static void smethod_2(string string_0, string string_1, out string string_2, out Version version_0)
	{
		string_2 = null;
		version_0 = new Version();
		DateTime minValue = DateTime.MinValue;
		try
		{
			string[] files = Directory.GetFiles(string_0, string_1);
			string[] array = files;
			foreach (string text in array)
			{
				try
				{
					Version version = Class52.smethod_0(text);
					DateTime creationTime = File.GetCreationTime(text);
					if (string_2 != null && Class51.smethod_28(version_0, version) >= 0 && (Class51.smethod_28(version_0, version) != 0 || !(minValue < creationTime)))
					{
						try
						{
							File.Delete(text);
						}
						catch (Exception exception_)
						{
							smethod_0(exception_);
						}
						continue;
					}
					try
					{
						if (string_2 != null)
						{
							File.Delete(string_2);
						}
					}
					catch (Exception exception_2)
					{
						smethod_0(exception_2);
					}
					string_2 = text;
					version_0 = version;
				}
				catch (Exception exception_3)
				{
					smethod_0(exception_3);
				}
			}
			if (string_2 != null)
			{
				smethod_1("Most recent file: {0}, Version: {1}", string_2, version_0);
			}
			else
			{
				smethod_1("No existing copies were found.");
			}
		}
		catch (Exception exception_4)
		{
			smethod_0(exception_4);
		}
	}

	protected static string smethod_3()
	{
		try
		{
			string directoryName = Path.GetDirectoryName(assembly_0.Location);
			Version version = assembly_0.GetName().Version;
			smethod_2(directoryName, "*.tmp", out var string_, out var version_);
			if (string_ != null && Class51.smethod_28(version, version_) <= 0)
			{
				return string_;
			}
			smethod_1("Spawning the current assembly...");
			string location = assembly_0.Location;
			string text = Path.Combine(directoryName, Guid.NewGuid().ToString() + ".tmp");
			File.Copy(location, text, overwrite: true);
			File.SetCreationTime(text, DateTime.Now);
			smethod_1("Assembly was spawned into {0}.", text);
			return text;
		}
		catch (Exception exception_)
		{
			smethod_0(exception_);
			return assembly_0.Location;
		}
	}
}
