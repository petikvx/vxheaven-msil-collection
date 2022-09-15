using System;
using System.Collections;

namespace DevComponents.DotNetBar;

public class CommandManager
{
	private static Hashtable hashtable_0 = new Hashtable();

	private static bool bool_0 = true;

	private static bool bool_1 = true;

	public static bool UseReflection
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public static bool AutoUpdateLayout
	{
		get
		{
			return bool_1;
		}
		set
		{
			if (bool_1 != value)
			{
				bool_1 = value;
			}
		}
	}

	public static void RegisterCommand(ICommandSource commandSource, ICommand command)
	{
		if (commandSource == null)
		{
			throw new NullReferenceException("commandSource cannot be null");
		}
		if (command == null)
		{
			throw new NullReferenceException("command cannot be null");
		}
		ArrayList arrayList = null;
		if (hashtable_0.Contains(command))
		{
			arrayList = (ArrayList)hashtable_0[command];
			if (!arrayList.Contains(commandSource))
			{
				arrayList.Add(commandSource);
			}
		}
		else
		{
			arrayList = new ArrayList();
			arrayList.Add(commandSource);
			hashtable_0.Add(command, arrayList);
		}
		command.CommandSourceRegistered(commandSource);
	}

	public static void UnRegisterCommandSource(ICommandSource commandSource, ICommand command)
	{
		if (commandSource == null)
		{
			throw new NullReferenceException("commandSource cannot be null");
		}
		if (command == null)
		{
			throw new NullReferenceException("command cannot be null");
		}
		if (hashtable_0.Contains(command))
		{
			ArrayList arrayList = (ArrayList)hashtable_0[command];
			if (arrayList.Contains(commandSource))
			{
				arrayList.Remove(commandSource);
			}
		}
		command.CommandSourceUnregistered(commandSource);
	}

	public static void UnRegisterCommand(ICommand command)
	{
		if (command == null)
		{
			throw new NullReferenceException("command cannot be null");
		}
		if (hashtable_0.Contains(command))
		{
			hashtable_0.Remove(command);
		}
	}

	public static ArrayList GetSubscribers(ICommand command)
	{
		if (command == null)
		{
			throw new NullReferenceException("command cannot be null");
		}
		ArrayList arrayList = null;
		if (hashtable_0.Contains(command))
		{
			return (ArrayList)hashtable_0[command];
		}
		return new ArrayList();
	}

	internal static void smethod_0(ICommandSource icommandSource_0)
	{
		if (icommandSource_0 == null)
		{
			throw new NullReferenceException("commandSource cannot be null");
		}
		ICommand command = icommandSource_0.Command;
		if (command == null)
		{
			throw new NullReferenceException("commandSource.Command cannot be null");
		}
		command.Execute(icommandSource_0);
	}
}
