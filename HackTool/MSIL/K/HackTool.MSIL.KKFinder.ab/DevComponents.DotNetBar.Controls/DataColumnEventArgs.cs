using System;
using DevComponents.AdvTree;

namespace DevComponents.DotNetBar.Controls;

public class DataColumnEventArgs : EventArgs
{
	public ColumnHeader ColumnHeader;

	public DataColumnEventArgs(ColumnHeader header)
	{
		ColumnHeader = header;
	}
}
