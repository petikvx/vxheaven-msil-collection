using System;
using System.ComponentModel;
using System.Drawing;

namespace DevComponents.DotNetBar;

public interface ICommand
{
	string Text { get; set; }

	bool Checked { get; set; }

	bool Visible { get; set; }

	Image Image { get; set; }

	Image ImageSmall { get; set; }

	bool Enabled { get; set; }

	event EventHandler Executed;

	event CancelEventHandler PreviewExecuted;

	void Execute();

	void Execute(ICommandSource commandSource);

	void CommandSourceRegistered(ICommandSource source);

	void CommandSourceUnregistered(ICommandSource source);

	void SetValue(string propertyName, object value);
}
